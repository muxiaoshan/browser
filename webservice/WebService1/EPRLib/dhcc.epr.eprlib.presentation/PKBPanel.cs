using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.kbdesign;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using KBNodeData;
using KnowledgeBaseData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class PKBPanel : UserControl
	{
		public delegate void KBNodeProcessHandler(string title);

		private IContainer components;

		[AccessedThroughProperty("KBPanel")]
		private Panel _KBPanel;

		[AccessedThroughProperty("KBSplitter")]
		private Splitter _KBSplitter;

		[AccessedThroughProperty("SpcTree")]
		private SplitContainer _SpcTree;

		[AccessedThroughProperty("btFind")]
		private Button _btFind;

		[AccessedThroughProperty("tbCategoryNode")]
		private TextBox _tbCategoryNode;

		[AccessedThroughProperty("KPanel")]
		private Panel _KPanel;

		private string _KBID;

		private string _ECODE;

		private int _KBPartNo;

		public PMsg PMsg;

		[AccessedThroughProperty("KBTree")]
		private KBTree _KBTree;

		private static string _KBEditable;

		private EKnowledgeBase _EKnowledgeBase;

		private PKBPanel.KBNodeProcessHandler OnKBNodeProcessEvent;

		public event PKBPanel.KBNodeProcessHandler OnKBNodeProcess
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnKBNodeProcessEvent = (PKBPanel.KBNodeProcessHandler)Delegate.Combine(this.OnKBNodeProcessEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnKBNodeProcessEvent = (PKBPanel.KBNodeProcessHandler)Delegate.Remove(this.OnKBNodeProcessEvent, value);
			}
		}

		internal virtual Panel KBPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KBPanel = value;
			}
		}

		internal virtual Splitter KBSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KBSplitter = value;
			}
		}

		internal virtual SplitContainer SpcTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SpcTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SpcTree = value;
			}
		}

		internal virtual Button btFind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btFind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btFind_Click);
				if (this._btFind != null)
				{
					this._btFind.Click -= value2;
				}
				this._btFind = value;
				if (this._btFind != null)
				{
					this._btFind.Click += value2;
				}
			}
		}

		internal virtual TextBox tbCategoryNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbCategoryNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.tbCategoryNode_KeyPress);
				if (this._tbCategoryNode != null)
				{
					this._tbCategoryNode.KeyPress -= value2;
				}
				this._tbCategoryNode = value;
				if (this._tbCategoryNode != null)
				{
					this._tbCategoryNode.KeyPress += value2;
				}
			}
		}

		internal virtual Panel KPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KPanel = value;
			}
		}

		public virtual KBTree KBTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KBTree = value;
			}
		}

		public string ECODE
		{
			get
			{
				return this._ECODE;
			}
			set
			{
				this._ECODE = value;
			}
		}

		public int KBPartNo
		{
			get
			{
				return this._KBPartNo;
			}
			set
			{
				this._KBPartNo = value;
			}
		}

		public string KBID
		{
			get
			{
				return this._KBID;
			}
			set
			{
				this._KBID = value;
				try
				{
					this._EKnowledgeBase = WebServiceLayer.KnowledgeBaseAccess.SelectKnowledgeBaseByID(this._KBID);
				}
				catch (Exception expr_1F)
				{
					ProjectData.SetProjectError(expr_1F);
					Exception ex = expr_1F;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
				if (this._EKnowledgeBase != null)
				{
					string valueByKey = GlobalValues.GetValueByKey("EpisodeID");
					if (!string.IsNullOrEmpty(valueByKey))
					{
						string kBDiagnosIDByEpisodeID = WebServiceLayer.InstanceAccess.GetKBDiagnosIDByEpisodeID(valueByKey);
						if (!string.IsNullOrEmpty(kBDiagnosIDByEpisodeID))
						{
							this.KBTree.KBDiagnosID = kBDiagnosIDByEpisodeID;
						}
					}
					this.KBTree.EKnowledgeBase = this._EKnowledgeBase;
				}
			}
		}

		public bool KBEditable
		{
			get
			{
				if (PKBPanel._KBEditable == null)
				{
					try
					{
						string sysOptionValue = SysOptionManager.GetSysOptionValue("KBEditable", "TRUE");
						PKBPanel._KBEditable = Strings.UCase(sysOptionValue);
					}
					catch (Exception expr_24)
					{
						ProjectData.SetProjectError(expr_24);
						Exception ex = expr_24;
						MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
						ProjectData.ClearProjectError();
					}
				}
				return PKBPanel._KBEditable.Equals("TRUE");
			}
		}

		public PKBPanel()
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
			this.KBPanel = new Panel();
			this.SpcTree = new SplitContainer();
			this.btFind = new Button();
			this.tbCategoryNode = new TextBox();
			this.KBSplitter = new Splitter();
			this.KPanel = new Panel();
			this.KBPanel.SuspendLayout();
			this.SpcTree.Panel1.SuspendLayout();
			this.SpcTree.SuspendLayout();
			this.SuspendLayout();
			this.KBPanel.Controls.Add(this.SpcTree);
			this.KBPanel.Dock = DockStyle.Right;
			Control arg_A4_0 = this.KBPanel;
			Point location = new Point(546, 0);
			arg_A4_0.Location = location;
			this.KBPanel.Name = "KBPanel";
			Control arg_D1_0 = this.KBPanel;
			Size size = new Size(254, 464);
			arg_D1_0.Size = size;
			this.KBPanel.TabIndex = 0;
			this.SpcTree.Dock = DockStyle.Fill;
			Control arg_FE_0 = this.SpcTree;
			location = new Point(0, 0);
			arg_FE_0.Location = location;
			this.SpcTree.Name = "SpcTree";
			this.SpcTree.Orientation = Orientation.Horizontal;
			this.SpcTree.Panel1.Controls.Add(this.btFind);
			this.SpcTree.Panel1.Controls.Add(this.tbCategoryNode);
			this.SpcTree.Panel1MinSize = 5;
			this.SpcTree.Panel2MinSize = 5;
			Control arg_185_0 = this.SpcTree;
			size = new Size(254, 464);
			arg_185_0.Size = size;
			this.SpcTree.SplitterDistance = 26;
			this.SpcTree.SplitterWidth = 1;
			this.SpcTree.TabIndex = 0;
			Control arg_1C3_0 = this.btFind;
			location = new Point(131, 3);
			arg_1C3_0.Location = location;
			this.btFind.Name = "btFind";
			Control arg_1EA_0 = this.btFind;
			size = new Size(39, 23);
			arg_1EA_0.Size = size;
			this.btFind.TabIndex = 3;
			this.btFind.Text = "查找";
			this.btFind.UseVisualStyleBackColor = true;
			Control arg_227_0 = this.tbCategoryNode;
			location = new Point(0, 3);
			arg_227_0.Location = location;
			this.tbCategoryNode.Name = "tbCategoryNode";
			Control arg_251_0 = this.tbCategoryNode;
			size = new Size(130, 21);
			arg_251_0.Size = size;
			this.tbCategoryNode.TabIndex = 2;
			this.KBSplitter.Dock = DockStyle.Right;
			Control arg_282_0 = this.KBSplitter;
			location = new Point(544, 0);
			arg_282_0.Location = location;
			this.KBSplitter.Name = "KBSplitter";
			Control arg_2AB_0 = this.KBSplitter;
			size = new Size(2, 464);
			arg_2AB_0.Size = size;
			this.KBSplitter.TabIndex = 2;
			this.KBSplitter.TabStop = false;
			this.KPanel.Dock = DockStyle.Fill;
			Control arg_2E4_0 = this.KPanel;
			location = new Point(0, 0);
			arg_2E4_0.Location = location;
			this.KPanel.Name = "KPanel";
			Control arg_311_0 = this.KPanel;
			size = new Size(544, 464);
			arg_311_0.Size = size;
			this.KPanel.TabIndex = 3;
			this.Controls.Add(this.KPanel);
			this.Controls.Add(this.KBSplitter);
			this.Controls.Add(this.KBPanel);
			this.Name = "PKBPanel";
			size = new Size(800, 464);
			this.Size = size;
			this.KBPanel.ResumeLayout(false);
			this.SpcTree.Panel1.ResumeLayout(false);
			this.SpcTree.Panel1.PerformLayout();
			this.SpcTree.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.PMsg = new PMsg();
			this.PMsg.Dock = DockStyle.Fill;
			this.KPanel.Controls.Add(this.PMsg);
			this.KBTree = new KBTree();
			this.KBTree.Dock = DockStyle.Fill;
			this.KBTree.ClientMode = true;
			this.KBTree.Editable = this.KBEditable;
			this.SpcTree.Panel2.Controls.Add(this.KBTree);
			this.SpcTree.Dock = DockStyle.Fill;
			this.KBPanel.Controls.Add(this.SpcTree);
			string sysOptionValue = SysOptionManager.GetSysOptionValue("KBPanelWidth", this.KBPanel.Width.ToString());
			if (Versioned.IsNumeric(sysOptionValue))
			{
				this.KBPanel.Width = (int)Convert.ToInt16(sysOptionValue);
			}
			this.KBTree.DoubleClick += new EventHandler(this.KBTree_DoubleClick);
			this.KBTree.miAddContent.Click += new EventHandler(this.miAddContent_Click);
			this.KBTree.miReplaceContent.Click += new EventHandler(this.miReplaceContent_Click);
		}

		private void miAddContent_Click(object sender, EventArgs e)
		{
			string nodeId = this.KBTree.GetNodeId(this.KBTree.SelectedNode);
			EKBNode eKbNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(nodeId);
			this.PMsg.PPanel.AddTextDesc(this.GetNISegment(eKbNode, 1), this.GetNISegment(eKbNode, 2), this.GetNISegment(eKbNode, 3), this.ECODE, this.KBPartNo);
			PKBPanel.KBNodeProcessHandler onKBNodeProcessEvent = this.OnKBNodeProcessEvent;
			if (onKBNodeProcessEvent != null)
			{
				onKBNodeProcessEvent(this.KBTree.SelectedNode.Text);
			}
		}

		private void miReplaceContent_Click(object sender, EventArgs e)
		{
			string nodeId = this.KBTree.GetNodeId(this.KBTree.SelectedNode);
			EKBNode eKbNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(nodeId);
			this.PMsg.PPanel.ReplaceTextDesc(this.GetNISegment(eKbNode, 1), this.GetNISegment(eKbNode, 2), this.GetNISegment(eKbNode, 3), this.ECODE, this.KBPartNo);
			PKBPanel.KBNodeProcessHandler onKBNodeProcessEvent = this.OnKBNodeProcessEvent;
			if (onKBNodeProcessEvent != null)
			{
				onKBNodeProcessEvent(this.KBTree.SelectedNode.Text);
			}
		}

		private void KBTree_DoubleClick(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.KBTree.GetNodeType(this.KBTree.SelectedNode), "LF", false) == 0)
			{
				string nodeId = this.KBTree.GetNodeId(this.KBTree.SelectedNode);
				EKBNode eKbNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(nodeId);
				this.PMsg.PPanel.AddTextDesc(this.GetNISegment(eKbNode, 1), this.GetNISegment(eKbNode, 2), this.GetNISegment(eKbNode, 3), this.ECODE, this.KBPartNo);
				PKBPanel.KBNodeProcessHandler onKBNodeProcessEvent = this.OnKBNodeProcessEvent;
				if (onKBNodeProcessEvent != null)
				{
					onKBNodeProcessEvent(this.KBTree.SelectedNode.ToolTipText);
				}
			}
		}

		private void btFind_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			this.KBTree.FindNode(this.tbCategoryNode.Text);
		}

		private void tbCategoryNode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(13))
			{
				this.btFind_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private NISegment GetNISegment(EKBNode eKbNode, int kbPartNo)
		{
			if (eKbNode == null)
			{
				return null;
			}
			switch (kbPartNo)
			{
			case 1:
				return this.GetCurrentSegment(eKbNode.S1MetaData, eKbNode.S1InstanceData);
			case 2:
				return this.GetCurrentSegment(eKbNode.S2MetaData, eKbNode.S2InstanceData);
			case 3:
				return this.GetCurrentSegment(eKbNode.S3MetaData, eKbNode.S3InstanceData);
			default:
				return null;
			}
		}

		private NISegment GetCurrentSegment(string curMetaData, string curInstanceData)
		{
			if (!string.IsNullOrEmpty(curMetaData))
			{
				NISegment nISegment = new NISegment();
				MISegment mISegment = new MISegment();
				mISegment.XMLString = curMetaData;
				nISegment.XMLString = curInstanceData;
				nISegment.SyncMetaItem(mISegment);
				return nISegment;
			}
			return null;
		}
	}
}
