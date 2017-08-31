using dhcc.epr.eprlib.dataaccess;
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

namespace dhcc.epr.eprlib.design.printlink
{
	public class KBCategoryTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		protected const string ROOT_NODE_TYPE = "RT";

		protected const string CATEGORY_NODE_TYPE = "CG";

		protected const string RESOURCE_NODE_TYPE = "LF";

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 1;

		protected const int KNOWLEDGEBASE_NODE_IMGINDEX = 2;

		internal virtual ImageList treeViewIcons
		{
			[DebuggerNonUserCode]
			get
			{
				return this._treeViewIcons;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._treeViewIcons = value;
			}
		}

		public KBCategoryTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.KBCategoryTree_BeforeExpand);
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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KBCategoryTree));
			this.treeViewIcons = new ImageList(this.components);
			this.SuspendLayout();
			this.treeViewIcons.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.treeViewIcons.Images.SetKeyName(0, "");
			this.treeViewIcons.Images.SetKeyName(1, "");
			this.treeViewIcons.Images.SetKeyName(2, "");
			this.treeViewIcons.Images.SetKeyName(3, "");
			this.treeViewIcons.Images.SetKeyName(4, "");
			this.treeViewIcons.Images.SetKeyName(5, "");
			this.ImageIndex = 0;
			this.ImageList = this.treeViewIcons;
			this.ItemHeight = 17;
			this.LineColor = Color.White;
			this.SelectedImageIndex = 2;
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.Nodes.Clear();
			this.InitKBCategoryRoot();
			this.InitKBCategoryTree();
		}

		private void InitKBCategoryRoot()
		{
			TreeNode treeNode = new TreeNode("知识库", 0, 0);
			treeNode.Tag = string.Format("{0}{1}", "RT", "0");
			this.Nodes.Add(treeNode);
		}

		private void InitKBCategoryTree()
		{
			try
			{
				EKBCategoryDataset eKBCategoryDataset = WebServiceLayer.KBCategoryAccess.SelectAllKBCategory();
				if (eKBCategoryDataset != null & eKBCategoryDataset.SELECTALL != null)
				{
					this.InitCategoryNodes(eKBCategoryDataset.SELECTALL, this.Nodes[0].Nodes, "0");
					this.Nodes[0].Expand();
				}
			}
			catch (Exception expr_56)
			{
				ProjectData.SetProjectError(expr_56);
				Exception ex = expr_56;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(EKBCategoryDataset.SELECTALLDataTable dt, TreeNodeCollection parentNode, string parentID)
		{
			string filterExpression = dt.ParentIDColumn.ColumnName + "='" + parentID + "'";
			DataRow[] array = dt.Select(filterExpression);
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					string text = dataRow[dt.IDColumn.ColumnName].ToString();
					string text2 = dataRow[dt.NameColumn.ColumnName].ToString();
					string text3 = dataRow[dt.DescriptionColumn.ColumnName].ToString();
					TreeNode treeNode = new TreeNode(text2, 0, 0);
					treeNode.Tag = string.Format("{0}{1}", "CG", text);
					parentNode.Add(treeNode);
					this.InitCategoryNodes(dt, treeNode.Nodes, text);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
					int arg_F0_0 = 0;
					int num2 = num - 1;
					for (int j = arg_F0_0; j <= num2; j++)
					{
						this.AddTempNode(treeNode, "LF", 2);
					}
				}
			}
		}

		private void AddTempNode(TreeNode parentNode, string nodeType, int imgIndex)
		{
			TreeNode treeNode = new TreeNode(null, imgIndex, imgIndex);
			treeNode.Tag = nodeType;
			parentNode.Nodes.Add(treeNode);
		}

		protected void KBCategoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				e.Cancel = !this.InitResourceNodes(e.Node);
			}
		}

		private bool InitResourceNodes(TreeNode parentNode)
		{
			bool result = false;
			string nodeID = this.GetNodeID(parentNode);
			checked
			{
				if (nodeID != null)
				{
					try
					{
						EKnowledgeBaseDataset eKnowledgeBaseDataset = WebServiceLayer.KnowledgeBaseAccess.SelectKnowledgeBaseBYPARENTID(nodeID);
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
							this.SetResourceNode(parentNode.Nodes[i], eKnowledgeBaseDataset.SELECTBYCATEID.Rows[i][columnName].ToString(), eKnowledgeBaseDataset.SELECTBYCATEID.Rows[i][columnName2].ToString(), eKnowledgeBaseDataset.SELECTBYCATEID.Rows[i][columnName3].ToString());
						}
						result = true;
					}
					catch (AppException expr_113)
					{
						ProjectData.SetProjectError(expr_113);
						AppException ex = expr_113;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private string GetNodeID(TreeNode node)
		{
			string result = "";
			if (node != null)
			{
				result = node.Tag.ToString().Substring(2);
			}
			return result;
		}

		private void SetResourceNode(TreeNode node, string id, string name, string desc)
		{
			node.Text = name;
			node.Tag = string.Format("{0}{1}", "LF", id);
		}
	}
}
