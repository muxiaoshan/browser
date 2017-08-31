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

namespace dhcc.epr.eprlib.design.lislink
{
	public class LISItemTree : TreeView
	{
		private const string TREE_NAME = "检验项目";

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

		public LISItemTree(IContainer Container) : this()
		{
			Container.Add(this);
		}

		public LISItemTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.LISItemTree_BeforeExpand);
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
			ResourceManager resourceManager = new ResourceManager(typeof(LISItemTree));
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
			TreeNode treeNode = new TreeNode("检验项目", 0, 1);
			treeNode.Tag = "RT";
			this.Nodes.Add(treeNode);
			try
			{
				DataSet dataSet = WebServiceLayer.LISDataAccess.SelectLISItemCategory();
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
						string text3 = dataRow[2].ToString();
						string str;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							str = "检验项目." + text3;
						}
						else
						{
							str = this.GetNodeDesc(parentNode) + "." + text3;
						}
						TreeNode treeNode = new TreeNode(text3, 0, 1);
						treeNode.Tag = "CT^" + str + "#TYPE:LIS#CATEID:" + text;
						parentNode.Nodes.Add(treeNode);
						DataSet dataSet = WebServiceLayer.LISDataAccess.SelectLISItemByCateID(text);
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
			catch (Exception expr_12F)
			{
				ProjectData.SetProjectError(expr_12F);
				Exception ex = expr_12F;
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
						string text3 = dataRow[2].ToString();
						string text4;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							text4 = "检验项目." + text3;
						}
						else
						{
							text4 = this.GetNodeDesc(parentNode) + "." + text3;
						}
						TreeNode treeNode = new TreeNode(text3, 0, 1);
						treeNode.Tag = string.Concat(new string[]
						{
							"IT^",
							text4,
							"#TYPE:LIS#CATEID:",
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
			catch (Exception expr_13B)
			{
				ProjectData.SetProjectError(expr_13B);
				Exception ex = expr_13B;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void LISItemTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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
			string text = parentNode.Tag.ToString();
			try
			{
				parentNode.Nodes.Clear();
				DataSet dataSet = WebServiceLayer.LISDataAccess.SelectLISItemIndicators(itemId);
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
						if (dataRow[1] != null)
						{
							string text3 = dataRow[1].ToString();
						}
						string text4;
						if (dataRow[2] == null)
						{
							text4 = null;
						}
						else
						{
							text4 = dataRow[2].ToString();
						}
						string text5;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							text5 = "检验项目." + text4;
						}
						else
						{
							text5 = this.GetNodeDesc(parentNode) + "." + text4;
						}
						TreeNode treeNode = new TreeNode(text4, 2, 2);
						treeNode.Tag = string.Concat(new string[]
						{
							"RS^",
							text5,
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
			catch (Exception expr_178)
			{
				ProjectData.SetProjectError(expr_178);
				Exception ex = expr_178;
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
