using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using KnowledgeBaseData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class DCKB : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("MainPanel")]
		private Panel _MainPanel;

		[AccessedThroughProperty("KBTreePanel")]
		private Panel _KBTreePanel;

		[AccessedThroughProperty("Splitter")]
		private Splitter _Splitter;

		[AccessedThroughProperty("KBNodePanel")]
		private Panel _KBNodePanel;

		private string _KBID;

		private EKnowledgeBase _EKnowledgeBase;

		[AccessedThroughProperty("KBTree")]
		private KBTree _KBTree;

		[AccessedThroughProperty("DCKBNode")]
		private DCKBNode _DCKBNode;

		[AccessedThroughProperty("DCKBTreeCategory")]
		private DCKBTreeCategory _DCKBTreeCategory;

		internal virtual Panel MainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainPanel = value;
			}
		}

		internal virtual Panel KBTreePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBTreePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KBTreePanel = value;
			}
		}

		internal virtual Splitter Splitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Splitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter = value;
			}
		}

		internal virtual Panel KBNodePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBNodePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KBNodePanel = value;
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
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.KBTree_AfterSelect);
				if (this._KBTree != null)
				{
					this._KBTree.AfterSelect -= value2;
				}
				this._KBTree = value;
				if (this._KBTree != null)
				{
					this._KBTree.AfterSelect += value2;
				}
			}
		}

		public virtual DCKBNode DCKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCKBNode = value;
			}
		}

		public virtual DCKBTreeCategory DCKBTreeCategory
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCKBTreeCategory;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCKBTreeCategory = value;
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
					this.DCKBNode.EKnowledgeBase = this._EKnowledgeBase;
					this.KBTree.EKnowledgeBase = this._EKnowledgeBase;
				}
			}
		}

		public DCKB(bool enableRoleKBTree, List<string> kbIDs)
		{
			this.InitializeComponent();
			this.Init(enableRoleKBTree, kbIDs);
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
			this.MainPanel = new Panel();
			this.Splitter = new Splitter();
			this.KBTreePanel = new Panel();
			this.KBNodePanel = new Panel();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			this.MainPanel.Controls.Add(this.KBNodePanel);
			this.MainPanel.Controls.Add(this.Splitter);
			this.MainPanel.Controls.Add(this.KBTreePanel);
			this.MainPanel.Dock = DockStyle.Fill;
			Control arg_9B_0 = this.MainPanel;
			Point location = new Point(0, 0);
			arg_9B_0.Location = location;
			this.MainPanel.Name = "MainPanel";
			Control arg_C8_0 = this.MainPanel;
			Size size = new Size(712, 480);
			arg_C8_0.Size = size;
			this.MainPanel.TabIndex = 1;
			Control arg_ED_0 = this.Splitter;
			location = new Point(200, 0);
			arg_ED_0.Location = location;
			this.Splitter.Name = "Splitter";
			Control arg_116_0 = this.Splitter;
			size = new Size(8, 480);
			arg_116_0.Size = size;
			this.Splitter.TabIndex = 1;
			this.Splitter.TabStop = false;
			this.KBTreePanel.Dock = DockStyle.Left;
			this.KBTreePanel.DockPadding.All = 5;
			Control arg_160_0 = this.KBTreePanel;
			location = new Point(0, 0);
			arg_160_0.Location = location;
			this.KBTreePanel.Name = "KBTreePanel";
			Control arg_18D_0 = this.KBTreePanel;
			size = new Size(200, 480);
			arg_18D_0.Size = size;
			this.KBTreePanel.TabIndex = 0;
			this.KBNodePanel.Dock = DockStyle.Fill;
			Control arg_1BE_0 = this.KBNodePanel;
			location = new Point(208, 0);
			arg_1BE_0.Location = location;
			this.KBNodePanel.Name = "KBNodePanel";
			Control arg_1EB_0 = this.KBNodePanel;
			size = new Size(504, 480);
			arg_1EB_0.Size = size;
			this.KBNodePanel.TabIndex = 2;
			this.Controls.Add(this.MainPanel);
			this.Name = "DCKB";
			size = new Size(712, 480);
			this.Size = size;
			this.MainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void Init(bool enableRoleKBTree, List<string> kbIDs)
		{
			this.KBTree = new KBTree();
			this.KBTree.Dock = DockStyle.Fill;
			this.KBTree.Editable = true;
			this.KBTreePanel.Controls.Add(this.KBTree);
			this.DCKBNode = new DCKBNode();
			this.DCKBNode.Dock = DockStyle.Fill;
			this.DCKBNode.Editable = true;
			this.DCKBNode.ClientMode = false;
			this.DCKBNode.SetRoleKBTree(enableRoleKBTree, ref kbIDs);
			this.DCKBNode.txtNodeName.TextChanged += new EventHandler(this.txtNodeName_TextChanged);
			this.DCKBTreeCategory = new DCKBTreeCategory();
			this.DCKBTreeCategory.Dock = DockStyle.Fill;
			this.DCKBTreeCategory.Editable = true;
			this.DCKBTreeCategory.SetRoleKBTree(enableRoleKBTree, ref kbIDs);
			this.DCKBTreeCategory.txtCategoryName.TextChanged += new EventHandler(this.txtCategoryName_TextChanged);
		}

		private void KBTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.KBNodePanel.Controls.Clear();
			if (Operators.CompareString(this.KBTree.GetNodeType(this.KBTree.SelectedNode), "CG", false) == 0)
			{
				this.KBNodePanel.Controls.Add(this.DCKBTreeCategory);
				this.DCKBTreeCategory.KBTreeID = this.KBTree.GetNodeId(this.KBTree.SelectedNode);
				this.DCKBTreeCategory.SetBtnEnable();
			}
			else if (Operators.CompareString(this.KBTree.GetNodeType(this.KBTree.SelectedNode), "LF", false) == 0)
			{
				if (Operators.CompareString(this.KBTree.GetNodeType(this.KBTree.SelectedNode.Parent), "PC", false) != 0)
				{
					this.DCKBNode.CTLogID = this.GetKBTreeCTLog(this.KBTree.SelectedNode);
					this.KBNodePanel.Controls.Add(this.DCKBNode);
				}
				this.DCKBNode.IsPersonlKBNode = this.KBTree.GetNodeType(this.KBTree.SelectedNode.Parent).Equals("PC");
				this.DCKBNode.KBNodeID = this.KBTree.GetNodeId(this.KBTree.SelectedNode);
				this.DCKBNode.SetBtnEnable(this.KBTree.GetNodeId(this.KBTree.SelectedNode.Parent));
			}
		}

		private string GetKBTreeCTLog(TreeNode tmpNode)
		{
			string empty = string.Empty;
			if (tmpNode.Level == 1)
			{
				return WebServiceLayer.KbConfigAccess.GetBindLocByID(this.KBTree.GetNodeId(tmpNode));
			}
			return this.GetKBTreeCTLog(tmpNode.Parent);
		}

		private void txtNodeName_TextChanged(object sender, EventArgs e)
		{
			this.KBTree.SelectedNode.Text = this.DCKBNode.txtNodeName.Text;
		}

		private void txtCategoryName_TextChanged(object sender, EventArgs e)
		{
			this.KBTree.SelectedNode.Text = this.DCKBTreeCategory.txtCategoryName.Text;
		}
	}
}
