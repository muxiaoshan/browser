using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using KBNodeData;
using KBTreeData;
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
	public class KBNodeTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		public const string ROOT_NODE_TYPE = "RT";

		public const string TREE_NODE_TYPE = "CG";

		public const string RESOURCE_NODE_TYPE = "LF";

		public const int TREE_NODE_COLLAPSE_IMGINDEX = 0;

		public const int TREE_NODE_EXPAND_IMGINDEX = 1;

		public const int KBNODE_NODE_IMGINDEX = 2;

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

		public KBNodeTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.KBNodeTree_BeforeExpand);
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KBNodeTree));
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
			this.HideSelection = false;
			this.ImageIndex = 2;
			this.ImageList = this.treeViewIcons;
			this.ItemHeight = 17;
			this.SelectedImageIndex = 0;
			this.ResumeLayout(false);
		}

		public void Init(string kbNodeID, string KbNodeText)
		{
			this.Nodes.Clear();
			this.InitRoot(kbNodeID, KbNodeText);
			this.InitKBNodes(kbNodeID);
		}

		private void InitRoot(string kbNodeID, string KbNodeText)
		{
			TreeNode treeNode = new TreeNode(KbNodeText, 0, 0);
			treeNode.Tag = string.Format("{0}{1}", "RT", kbNodeID);
			this.Nodes.Add(treeNode);
		}

		private void InitKBNodes(string kbNodeID)
		{
			try
			{
				EKBTreeAllDataset eKBTreeAllDataset = WebServiceLayer.KBTreeAccess.SelectALLKBTree(kbNodeID);
				if (eKBTreeAllDataset != null & eKBTreeAllDataset.SELECTALL != null)
				{
					this.InitCategoryNodes(eKBTreeAllDataset.SELECTALL, this.Nodes[0], "0");
				}
				this.Nodes[0].Expand();
			}
			catch (AppException expr_52)
			{
				ProjectData.SetProjectError(expr_52);
				AppException ex = expr_52;
				MessageManager.ShowErrorMessage(ex.ShowInfo);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(EKBTreeAllDataset.SELECTALLDataTable dt, TreeNode parentNode, string parentID)
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("EnableKBTreeLocConfig", "N");
			string filterExpression = dt.ParentIDColumn.ColumnName + "='" + parentID + "'";
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
					this.InitCategoryNodes(dt, treeNode, text);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
					int arg_F3_0 = 0;
					int num2 = num - 1;
					for (int j = arg_F3_0; j <= num2; j++)
					{
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "LF";
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
		}

		private void KBNodeTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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
						EKBNodeDataset eKBNodeDataset = WebServiceLayer.KBNodeAccess.SelectKBNodeByKBTreeID(nodeID);
						if (parentNode.Nodes.Count != eKBNodeDataset.SELECTBYPARENTID.Rows.Count)
						{
							throw new AppException("获取知识库信息失败。");
						}
						string columnName = eKBNodeDataset.SELECTBYPARENTID.IDColumn.ColumnName;
						string columnName2 = eKBNodeDataset.SELECTBYPARENTID.NameColumn.ColumnName;
						string columnName3 = eKBNodeDataset.SELECTBYPARENTID.DescriptionColumn.ColumnName;
						int arg_87_0 = 0;
						int num = eKBNodeDataset.SELECTBYPARENTID.Rows.Count - 1;
						for (int i = arg_87_0; i <= num; i++)
						{
							parentNode.Nodes[i].Tag = "LF" + eKBNodeDataset.SELECTBYPARENTID.Rows[i][columnName].ToString();
							parentNode.Nodes[i].Text = eKBNodeDataset.SELECTBYPARENTID.Rows[i][columnName2].ToString();
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

		public string GetNodeID(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			if (Operators.CompareString(node.Tag.ToString(), "RT", false) == 0)
			{
				return "0";
			}
			return node.Tag.ToString().Substring(2);
		}

		public string GetNodeType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(0, 2);
		}
	}
}
