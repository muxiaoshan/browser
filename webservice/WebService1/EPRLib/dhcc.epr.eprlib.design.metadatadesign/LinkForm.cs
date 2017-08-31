using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.printlink;
using dhcc.epr.systemframework;
using InterfaceTemplateData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class LinkForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("TemplatePanel")]
		private Panel _TemplatePanel;

		[AccessedThroughProperty("gbxLine")]
		private GroupBox _gbxLine;

		[AccessedThroughProperty("MetaDataPanel")]
		private Panel _MetaDataPanel;

		private string _StrLink;

		[AccessedThroughProperty("TemplateTree")]
		private TemplateTree _TemplateTree;

		[AccessedThroughProperty("UnitTree")]
		private UnitTree _UnitTree;

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= value2;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += value2;
				}
			}
		}

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		internal virtual Panel TemplatePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TemplatePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TemplatePanel = value;
			}
		}

		internal virtual GroupBox gbxLine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxLine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxLine = value;
			}
		}

		internal virtual Panel MetaDataPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetaDataPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetaDataPanel = value;
			}
		}

		public virtual TemplateTree TemplateTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TemplateTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.TemplateTree_AfterSelect);
				if (this._TemplateTree != null)
				{
					this._TemplateTree.AfterSelect -= value2;
				}
				this._TemplateTree = value;
				if (this._TemplateTree != null)
				{
					this._TemplateTree.AfterSelect += value2;
				}
			}
		}

		public virtual UnitTree UnitTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnitTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.UnitTree_AfterSelect);
				if (this._UnitTree != null)
				{
					this._UnitTree.AfterSelect -= value2;
				}
				this._UnitTree = value;
				if (this._UnitTree != null)
				{
					this._UnitTree.AfterSelect += value2;
				}
			}
		}

		public string StrLink
		{
			get
			{
				return this._StrLink;
			}
			set
			{
				this._StrLink = value;
			}
		}

		public LinkForm()
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
			this.TemplatePanel = new Panel();
			this.MetaDataPanel = new Panel();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.gbxLine = new GroupBox();
			this.SuspendLayout();
			this.TemplatePanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_59_0 = this.TemplatePanel;
			Point location = new Point(4, 4);
			arg_59_0.Location = location;
			this.TemplatePanel.Name = "TemplatePanel";
			Control arg_86_0 = this.TemplatePanel;
			Size size = new Size(248, 255);
			arg_86_0.Size = size;
			this.TemplatePanel.TabIndex = 0;
			this.MetaDataPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_B8_0 = this.MetaDataPanel;
			location = new Point(278, 5);
			arg_B8_0.Location = location;
			this.MetaDataPanel.Name = "MetaDataPanel";
			Control arg_E5_0 = this.MetaDataPanel;
			size = new Size(248, 254);
			arg_E5_0.Size = size;
			this.MetaDataPanel.TabIndex = 1;
			this.btnOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_11B_0 = this.btnOK;
			location = new Point(371, 276);
			arg_11B_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_142_0 = this.btnOK;
			size = new Size(75, 23);
			arg_142_0.Size = size;
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "确定";
			this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_188_0 = this.btnCancel;
			location = new Point(452, 276);
			arg_188_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_1AF_0 = this.btnCancel;
			size = new Size(75, 23);
			arg_1AF_0.Size = size;
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "取消";
			this.gbxLine.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_1F1_0 = this.gbxLine;
			location = new Point(0, 265);
			arg_1F1_0.Location = location;
			this.gbxLine.Name = "gbxLine";
			Control arg_21A_0 = this.gbxLine;
			size = new Size(530, 4);
			arg_21A_0.Size = size;
			this.gbxLine.TabIndex = 4;
			this.gbxLine.TabStop = false;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(530, 304);
			this.ClientSize = size;
			this.Controls.Add(this.gbxLine);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.MetaDataPanel);
			this.Controls.Add(this.TemplatePanel);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.Name = "LinkForm";
			this.ShowInTaskbar = false;
			this.Text = "选择链接单元";
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.TemplateTree = new TemplateTree();
			this.TemplateTree.Dock = DockStyle.Fill;
			this.TemplatePanel.Controls.Add(this.TemplateTree);
			this.UnitTree = new UnitTree();
			this.UnitTree.Dock = DockStyle.Fill;
			this.MetaDataPanel.Controls.Add(this.UnitTree);
		}

		private void UnitTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.UnitTree.SelectedNode != null)
			{
				if (this.UnitTree.SelectedNode.Tag != null)
				{
					this._StrLink = Conversions.ToString(this.UnitTree.SelectedNode.Tag);
				}
				else
				{
					this._StrLink = null;
				}
			}
		}

		private void TemplateTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.TemplateTree.SelectedNode != null && Operators.CompareString(this.TemplateTree.GetNodeType(this.TemplateTree.SelectedNode), "IT", false) == 0)
			{
				try
				{
					string nodeId = this.TemplateTree.GetNodeId(this.TemplateTree.SelectedNode);
					ETemplateVersion versionByID = WebServiceLayer.InterfaceTemplateAccess.GetVersionByID(nodeId, true, true);
					this.UnitTree.ITID = versionByID.TemplateID;
					this.UnitTree.ITVersion = versionByID.VersionNumber.ToString() + ".0";
					this.UnitTree.ITName = this.TemplateTree.SelectedNode.Parent.Text;
					this.UnitTree.StrMetaData = versionByID.MetaData;
				}
				catch (AppException expr_C3)
				{
					ProjectData.SetProjectError(expr_C3);
					AppException ex = expr_C3;
					MessageManager.ShowErrorMessage(ex.ShowInfo);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
