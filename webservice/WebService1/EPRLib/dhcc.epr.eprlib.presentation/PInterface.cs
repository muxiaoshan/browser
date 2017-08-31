using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class PInterface : UserControl
	{
		public delegate void SetEPRListTitleHandler(string title);

		public delegate void RefreshBindKBTreeHandler(string code);

		private IContainer components;

		private MMetaData _MetaData;

		private NInstanceData _InstanceData;

		private bool _KBSupport;

		public PMsg PMsg;

		private PKBPanel PKBPanel;

		private PInterface.SetEPRListTitleHandler OnKBNodeUpdateEvent;

		private PInterface.RefreshBindKBTreeHandler OnRefreshBindKBTreeEvent;

		public event PInterface.SetEPRListTitleHandler OnKBNodeUpdate
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnKBNodeUpdateEvent = (PInterface.SetEPRListTitleHandler)Delegate.Combine(this.OnKBNodeUpdateEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnKBNodeUpdateEvent = (PInterface.SetEPRListTitleHandler)Delegate.Remove(this.OnKBNodeUpdateEvent, value);
			}
		}

		public event PInterface.RefreshBindKBTreeHandler OnRefreshBindKBTree
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnRefreshBindKBTreeEvent = (PInterface.RefreshBindKBTreeHandler)Delegate.Combine(this.OnRefreshBindKBTreeEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnRefreshBindKBTreeEvent = (PInterface.RefreshBindKBTreeHandler)Delegate.Remove(this.OnRefreshBindKBTreeEvent, value);
			}
		}

		public MMetaData MetaData
		{
			get
			{
				return this._MetaData;
			}
			set
			{
				this.Controls.Clear();
				this._MetaData = value;
				if (!this._MetaData.BindKB)
				{
					this._KBSupport = false;
					this.PMsg = new PMsg();
					this.PMsg.Dock = DockStyle.Fill;
					this.Controls.Add(this.PMsg);
				}
				else
				{
					this._KBSupport = true;
					this.PKBPanel = new PKBPanel();
					this.PKBPanel.KBID = this._MetaData.BindKBCode;
					this.PMsg = this.PKBPanel.PMsg;
					this.PKBPanel.Dock = DockStyle.Fill;
					this.Controls.Add(this.PKBPanel);
					this.PKBPanel.OnKBNodeProcess += new PKBPanel.KBNodeProcessHandler(this.ProcessEPRListTitle);
					this.PKBPanel.PMsg.PPanel.OnRefreshBindKBTree += new PPanel.RefreshBindKBTreeHandler(this.RefreshBindKBTree);
				}
			}
		}

		public NInstanceData InstanceData
		{
			get
			{
				return this._InstanceData;
			}
			set
			{
				this._InstanceData = value;
				this.PMsg.PPanel.InstanceData = value;
			}
		}

		public string StrPresentation
		{
			set
			{
				this.PMsg.PPanel.XMLString = value;
			}
		}

		public bool KBSupport
		{
			get
			{
				return this._KBSupport;
			}
		}

		public PInterface()
		{
			this.InitializeComponent();
			this.Init();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Name = "PInterface";
			Size size = new Size(912, 504);
			this.Size = size;
		}

		public void Init()
		{
		}

		public void BindInstance()
		{
			this.PMsg.PPanel.BindInstance();
		}

		private void ProcessEPRListTitle(string title)
		{
			PInterface.SetEPRListTitleHandler onKBNodeUpdateEvent = this.OnKBNodeUpdateEvent;
			if (onKBNodeUpdateEvent != null)
			{
				onKBNodeUpdateEvent(title);
			}
		}

		private void RefreshBindKBTree(string code, string kbBaseID, int kbPartNo)
		{
			string kBID = this.PKBPanel.KBID;
			if (string.IsNullOrEmpty(kBID) || !kBID.Equals(kbBaseID))
			{
				this.PKBPanel.KBID = kbBaseID;
			}
			this.PKBPanel.ECODE = code;
			this.PKBPanel.KBPartNo = kbPartNo;
		}
	}
}
