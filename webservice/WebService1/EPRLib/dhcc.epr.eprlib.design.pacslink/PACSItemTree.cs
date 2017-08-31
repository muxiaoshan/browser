using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.pacslink
{
	public class PACSItemTree : TreeView
	{
		private const string TREE_NAME = "检查项目";

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 1;

		protected const int RESOURCE_NODE_IMGINDEX = 2;

		public const string ROOT_NODE_TYPE = "RT";

		public const string CATEGORY_NODE_TYPE = "CT";

		public const string ITEM_NODE_TYPE = "IT";

		public const string RESOURCE_NODE_TYPE = "RS";

		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

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

		public PACSItemTree(IContainer Container) : this()
		{
			Container.Add(this);
		}

		public PACSItemTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.PACSItemTree_BeforeExpand);
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
			ResourceManager resourceManager = new ResourceManager(typeof(PACSItemTree));
			this.treeViewIcons = new ImageList(this.components);
			ImageList arg_3E_0 = this.treeViewIcons;
			Size imageSize = new Size(16, 16);
			arg_3E_0.ImageSize = imageSize;
			this.treeViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.treeViewIcons;
			this.SelectedImageIndex = 0;
			this.Tag = "";
		}

		public void Init()
		{
			TreeNode treeNode = new TreeNode("检查项目", 0, 1);
			treeNode.Tag = "RT";
			this.Nodes.Add(treeNode);
			try
			{
				DataSet dataSet = WebServiceLayer.PACSDataAccess.SelectPACSArcCateList();
				if (dataSet != null & dataSet.Tables[0] != null)
				{
					this.InitCategoryNodes(dataSet.Tables[0], this.Nodes[0], "0");
				}
				this.Nodes[0].Expand();
			}
			catch (Exception expr_82)
			{
				ProjectData.SetProjectError(expr_82);
				Exception ex = expr_82;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(DataTable dt, TreeNode parentNode, string parentId)
		{
			try
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text = dataRow[0].ToString();
						string text2 = dataRow[1].ToString();
						string str;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							str = "检查项目." + text2;
						}
						else
						{
							str = this.GetNodeDesc(parentNode) + "." + text2;
						}
						TreeNode treeNode = new TreeNode(text2, 0, 1);
						treeNode.Tag = "CT^" + str + "#TYPE:PACS#CATEID:" + text;
						parentNode.Nodes.Add(treeNode);
						DataSet dataSet = WebServiceLayer.PACSDataAccess.SelectPACSArcItemList(text);
						if (dataSet != null & dataSet.Tables[0] != null)
						{
							this.InitItemNodes(dataSet.Tables[0], treeNode, text);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception expr_121)
			{
				ProjectData.SetProjectError(expr_121);
				Exception ex = expr_121;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitItemNodes(DataTable dt, TreeNode parentNode, string parentId)
		{
			try
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text = dataRow[0].ToString();
						string text2 = dataRow[1].ToString();
						string text3;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							text3 = "检查项目." + text2;
						}
						else
						{
							text3 = this.GetNodeDesc(parentNode) + "." + text2;
						}
						TreeNode treeNode = new TreeNode(text2, 0, 1);
						treeNode.Tag = string.Concat(new string[]
						{
							"IT^",
							text3,
							"#TYPE:PACS#CATEID:",
							parentId,
							"#ITEMID:",
							text
						});
						parentNode.Nodes.Add(treeNode);
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "RS";
						treeNode.Nodes.Add(treeNode2);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception expr_12D)
			{
				ProjectData.SetProjectError(expr_12D);
				Exception ex = expr_12D;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void PACSItemTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				string nodeType = this.GetNodeType(e.Node);
				if (Operators.CompareString(nodeType, "IT", false) == 0)
				{
					e.Cancel = !this.InitResourceNodes(e.Node);
				}
			}
		}

		private bool InitResourceNodes(TreeNode parentNode)
		{
			bool result = false;
			string itemId = this.GetItemId(parentNode);
			string text = Conversions.ToString(parentNode.Tag);
			try
			{
				parentNode.Nodes.Clear();
				DataSet dataSet = WebServiceLayer.PACSDataAccess.SelectRptStructure();
				try
				{
					IEnumerator enumerator = dataSet.Tables[0].Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text2;
						if (dataRow[0] == null)
						{
							text2 = null;
						}
						else
						{
							text2 = dataRow[0].ToString();
						}
						string text3;
						if (dataRow[1] == null)
						{
							text3 = null;
						}
						else
						{
							text3 = dataRow[1].ToString();
						}
						string text4;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							text4 = "检查项目." + text3;
						}
						else
						{
							text4 = this.GetNodeDesc(parentNode) + "." + text3;
						}
						TreeNode treeNode = new TreeNode(text3, 2, 2);
						treeNode.Tag = string.Concat(new string[]
						{
							"RS^",
							text4,
							text.Substring(text.IndexOf("#TYPE:")),
							"#PARTNO:",
							text2
						});
						parentNode.Nodes.Add(treeNode);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = true;
			}
			catch (Exception expr_159)
			{
				ProjectData.SetProjectError(expr_159);
				Exception ex = expr_159;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private string GetItemId(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(node.Tag, null, "Split", new object[]
			{
				"^"
			}, null, null, null), new object[]
			{
				1
			}, null));
			return text.Substring(checked(text.IndexOf("#ITEMID:") + 8));
		}

		public string GetNodeType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return Conversions.ToString(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(node.Tag, null, "Split", new object[]
			{
				"^"
			}, null, null, null), new object[]
			{
				0
			}, null));
		}

		private string GetNodeDesc(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(node.Tag, null, "Split", new object[]
			{
				"^"
			}, null, null, null), new object[]
			{
				1
			}, null));
			return text.Substring(0, text.IndexOf("#TYPE:"));
		}
	}
}
