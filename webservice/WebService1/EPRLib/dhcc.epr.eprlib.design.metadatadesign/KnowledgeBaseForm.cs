using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using KBCategoryData;
using KnowledgeBaseData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class KnowledgeBaseForm : dhcc.epr.eprlib.presentation.MovableForm
	{
		private IContainer components;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("KBTreeView")]
		private TreeView _KBTreeView;

		[AccessedThroughProperty("ILTree")]
		private ImageList _ILTree;

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 1;

		protected const int KNOWLEDGEBASE_NODE_IMGINDEX = 2;

		protected const string ROOT_NODE_TYPE = "RT";

		protected const string CATEGORY_NODE_TYPE = "CG";

		protected const string RESOURCE_NODE_TYPE = "LF";

		private string _KBCode;

		private string _KBName;

		private bool BoolMouseDown;

		private Point ClickedPoint;

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

		internal virtual TreeView KBTreeView
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KBTreeView;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewCancelEventHandler value2 = new TreeViewCancelEventHandler(this.KBTreeView_BeforeExpand);
				TreeViewEventHandler value3 = new TreeViewEventHandler(this.KBTreeView_AfterSelect);
				if (this._KBTreeView != null)
				{
					this._KBTreeView.BeforeExpand -= value2;
					this._KBTreeView.AfterSelect -= value3;
				}
				this._KBTreeView = value;
				if (this._KBTreeView != null)
				{
					this._KBTreeView.BeforeExpand += value2;
					this._KBTreeView.AfterSelect += value3;
				}
			}
		}

		internal virtual ImageList ILTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ILTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ILTree = value;
			}
		}

		public string KBCode
		{
			get
			{
				return this._KBCode;
			}
			set
			{
				this._KBCode = value;
			}
		}

		public string KBName
		{
			get
			{
				return this._KBName;
			}
			set
			{
				this._KBName = value;
			}
		}

		public KnowledgeBaseForm()
		{
			base.Load += new EventHandler(this.KnowledgeBaseForm_Load);
			base.Paint += new PaintEventHandler(this.ChoiceForm_Paint);
			this.BoolMouseDown = false;
			this.InitializeComponent();
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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KnowledgeBaseForm));
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.KBTreeView = new TreeView();
			this.ILTree = new ImageList(this.components);
			this.SuspendLayout();
			Control arg_6B_0 = this.btnCancel;
			Point location = new Point(236, 341);
			arg_6B_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_92_0 = this.btnCancel;
			Size size = new Size(64, 24);
			arg_92_0.Size = size;
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "取消(&C)";
			Control arg_CC_0 = this.btnOK;
			location = new Point(167, 341);
			arg_CC_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_F3_0 = this.btnOK;
			size = new Size(64, 24);
			arg_F3_0.Size = size;
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "确定(&O)";
			this.KBTreeView.ImageIndex = 0;
			this.KBTreeView.ImageList = this.ILTree;
			Control arg_142_0 = this.KBTreeView;
			location = new Point(4, 4);
			arg_142_0.Location = location;
			this.KBTreeView.Name = "KBTreeView";
			this.KBTreeView.SelectedImageIndex = 0;
			Control arg_17B_0 = this.KBTreeView;
			size = new Size(296, 331);
			arg_17B_0.Size = size;
			this.KBTreeView.TabIndex = 13;
			this.ILTree.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ILTree.ImageStream");
			this.ILTree.TransparentColor = Color.Transparent;
			this.ILTree.Images.SetKeyName(0, "");
			this.ILTree.Images.SetKeyName(1, "");
			this.ILTree.Images.SetKeyName(2, "");
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(304, 368);
			this.ClientSize = size;
			this.Controls.Add(this.KBTreeView);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "KnowledgeBaseForm";
			this.Text = "KnowledgeBaseForm";
			this.ResumeLayout(false);
		}

		private void ChoiceForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics arg_28_0 = graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_28_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void KnowledgeBaseForm_Load(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode("知识库目录", 0, 1);
			treeNode.Tag = "RT";
			this.KBTreeView.Nodes.Add(treeNode);
			this.InitTreeViewNodes();
		}

		private void KBTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (Operators.CompareString(this.GetNodeType(this.KBTreeView.SelectedNode), "LF", false) == 0)
			{
				this._KBCode = this.GetNodeId(this.KBTreeView.SelectedNode);
				this._KBName = this.KBTreeView.SelectedNode.Text;
			}
		}

		private void InitTreeViewNodes()
		{
			try
			{
				EKBCategoryDataset eKBCategoryDataset = WebServiceLayer.KBCategoryAccess.SelectAllKBCategory();
				if (eKBCategoryDataset != null & eKBCategoryDataset.SELECTALL != null)
				{
					this.initCategoryNodes(eKBCategoryDataset.SELECTALL, this.KBTreeView.Nodes[0], "0");
				}
				this.KBTreeView.Nodes[0].Expand();
			}
			catch (Exception expr_5B)
			{
				ProjectData.SetProjectError(expr_5B);
				Exception ex = expr_5B;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void initCategoryNodes(EKBCategoryDataset.SELECTALLDataTable dt, TreeNode parentNode, string parentId)
		{
			string filterExpression = dt.ParentIDColumn.ColumnName + "='" + parentId + "'";
			DataRow[] array = dt.Select(filterExpression);
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					string text = dataRow[dt.IDColumn.ColumnName].ToString();
					string text2 = dataRow[dt.DescriptionColumn.ColumnName].ToString();
					TreeNode treeNode = new TreeNode(dataRow[dt.NameColumn.ColumnName].ToString(), 0, 0);
					treeNode.Tag = "CG" + text;
					parentNode.Nodes.Add(treeNode);
					this.initCategoryNodes(dt, treeNode, text);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
					int arg_E1_0 = 0;
					int num2 = num - 1;
					for (int j = arg_E1_0; j <= num2; j++)
					{
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "LF";
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
		}

		private void KBTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				e.Cancel = !this.initResourceNodes(e.Node);
			}
		}

		private bool initResourceNodes(TreeNode parentNode)
		{
			bool result = false;
			string nodeId = this.GetNodeId(parentNode);
			checked
			{
				if (nodeId != null)
				{
					try
					{
						EKnowledgeBaseDataset eKnowledgeBaseDataset = WebServiceLayer.KnowledgeBaseAccess.SelectKnowledgeBaseBYPARENTID(nodeId);
						if (parentNode.Nodes.Count != eKnowledgeBaseDataset.SELECTBYCATEID.Rows.Count)
						{
							throw new AppException("获取知识库信息失败。");
						}
						string columnName = eKnowledgeBaseDataset.SELECTBYCATEID.IDColumn.ColumnName;
						string columnName2 = eKnowledgeBaseDataset.SELECTBYCATEID.NameColumn.ColumnName;
						string columnName3 = eKnowledgeBaseDataset.SELECTBYCATEID.DescriptionColumn.ColumnName;
						int arg_87_0 = 0;
						int num = eKnowledgeBaseDataset.SELECTBYCATEID.Rows.Count - 1;
						for (int i = arg_87_0; i <= num; i++)
						{
							parentNode.Nodes[i].Tag = "LF" + eKnowledgeBaseDataset.SELECTBYCATEID.Rows[i][columnName].ToString();
							parentNode.Nodes[i].Text = eKnowledgeBaseDataset.SELECTBYCATEID.Rows[i][columnName2].ToString();
						}
						result = true;
					}
					catch (AppException expr_110)
					{
						ProjectData.SetProjectError(expr_110);
						AppException ex = expr_110;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private string GetNodeId(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(2);
		}

		private string GetNodeType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(0, 2);
		}
	}
}
