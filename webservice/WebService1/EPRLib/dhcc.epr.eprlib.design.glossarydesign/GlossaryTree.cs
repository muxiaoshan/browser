using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using GlossaryCategoryData;
using GlossaryData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.glossarydesign
{
	public class GlossaryTree : TreeView
	{
		private const string TREE_NAME = "术语集";

		protected const int ROOT_NODE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 1;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 2;

		protected const int GLOSSARY_NODE_IMGINDEX = 3;

		public const string ROOT_NODE_TYPE = "RT";

		public const string CATEGORY_NODE_TYPE = "CT";

		public const string RESOURCE_NODE_TYPE = "RS";

		private IContainer components;

		[AccessedThroughProperty("ItemImages")]
		private ImageList _ItemImages;

		internal virtual ImageList ItemImages
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItemImages;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ItemImages = value;
			}
		}

		public GlossaryTree(IContainer Container) : this()
		{
			Container.Add(this);
		}

		public GlossaryTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.GlossaryTree_BeforeExpand);
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
			ResourceManager resourceManager = new ResourceManager(typeof(GlossaryTree));
			this.ItemImages = new ImageList(this.components);
			ImageList arg_3E_0 = this.ItemImages;
			Size imageSize = new Size(24, 24);
			arg_3E_0.ImageSize = imageSize;
			this.ItemImages.ImageStream = (ImageListStreamer)resourceManager.GetObject("ItemImages.ImageStream");
			this.ItemImages.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.ItemImages;
			this.Indent = 27;
			this.ItemHeight = 24;
			this.SelectedImageIndex = 0;
			this.Tag = "";
		}

		public void Init()
		{
			TreeNode treeNode = new TreeNode("术语集", 0, 0);
			treeNode.Tag = "RT";
			this.Nodes.Add(treeNode);
			this.InitTreeViewNodes();
		}

		private void InitTreeViewNodes()
		{
			try
			{
				EGlossaryCategoryDataset eGlossaryCategoryDataset = WebServiceLayer.GlossaryCategoryAccess.SelectAllGlossaryCategory();
				if (eGlossaryCategoryDataset != null & eGlossaryCategoryDataset.SelectAll != null)
				{
					this.InitCategoryNodes(eGlossaryCategoryDataset.SelectAll, this.Nodes[0], "0");
				}
				this.Nodes[0].Expand();
			}
			catch (Exception expr_51)
			{
				ProjectData.SetProjectError(expr_51);
				Exception ex = expr_51;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(EGlossaryCategoryDataset.SelectAllDataTable dt, TreeNode parentNode, string parentId)
		{
			checked
			{
				try
				{
					string filterExpression = dt.ParentIDColumn.ColumnName + "='" + parentId + "'";
					DataRow[] array = dt.Select(filterExpression);
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						string text = dataRow[dt.IDColumn.ColumnName].ToString();
						string text2 = dataRow[dt.NameColumn].ToString();
						string text3 = dataRow[dt.ResChildCountColumn].ToString();
						string str;
						if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
						{
							str = "术语集." + text2;
						}
						else
						{
							str = this.GetAllName(parentNode) + "." + text2;
						}
						TreeNode treeNode = new TreeNode(dataRow[dt.NameColumn].ToString(), 1, 1);
						treeNode.Tag = "CT^" + str + "#TYPE:Glossary#GID:" + text;
						parentNode.Nodes.Add(treeNode);
						this.InitCategoryNodes(dt, treeNode, text);
						int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
						int arg_140_0 = 0;
						int num2 = num - 1;
						for (int j = arg_140_0; j <= num2; j++)
						{
							TreeNode treeNode2 = new TreeNode(null, 3, 3);
							treeNode2.Tag = "RS";
							treeNode.Nodes.Add(treeNode2);
						}
					}
				}
				catch (Exception expr_188)
				{
					ProjectData.SetProjectError(expr_188);
					Exception ex = expr_188;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void GlossaryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				e.Cancel = !this.InitResourceNodes(e.Node);
			}
		}

		private bool InitResourceNodes(TreeNode parentNode)
		{
			string id = this.GetId(parentNode);
			string nodeType = this.GetNodeType(parentNode);
			parentNode.Nodes.Clear();
			checked
			{
				try
				{
					if (Operators.CompareString(nodeType, "CT", false) == 0)
					{
						EGlossaryDataset eGlossaryDataset = WebServiceLayer.GlossaryAccess.SelectAllGlossaryByCategoryID(id);
						string columnName = eGlossaryDataset.SelectAllByCategoryID.IDColumn.ColumnName;
						string columnName2 = eGlossaryDataset.SelectAllByCategoryID.NameColumn.ColumnName;
						string columnName3 = eGlossaryDataset.SelectAllByCategoryID.GUIDColumn.ColumnName;
						string columnName4 = eGlossaryDataset.SelectAllByCategoryID.GlossaryTypeColumn.ColumnName;
						string columnName5 = eGlossaryDataset.SelectAllByCategoryID.ChildCountColumn.ColumnName;
						int arg_B1_0 = 0;
						int num = eGlossaryDataset.SelectAllByCategoryID.Rows.Count - 1;
						for (int i = arg_B1_0; i <= num; i++)
						{
							string str;
							if (eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName] == null)
							{
								str = null;
							}
							else
							{
								str = eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName].ToString();
							}
							string text;
							if (eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName2] == null)
							{
								text = null;
							}
							else
							{
								text = eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName2].ToString();
							}
							if (eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName3] != null)
							{
								string text2 = eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName3].ToString();
							}
							int num2;
							if (eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName5] == null)
							{
								num2 = 0;
							}
							else
							{
								num2 = Convert.ToInt32(eGlossaryDataset.SelectAllByCategoryID.Rows[i][columnName5].ToString());
							}
							string str2;
							if (Operators.CompareString(this.GetNodeType(parentNode), "RT", false) == 0)
							{
								str2 = "术语集." + text;
							}
							else
							{
								str2 = this.GetAllName(parentNode) + "." + text;
							}
							TreeNode treeNode = new TreeNode(text, 3, 3);
							treeNode.Tag = "RS^" + str2 + "#TYPE:Glossary#GID:" + str;
							parentNode.Nodes.Add(treeNode);
							int arg_239_0 = 0;
							int num3 = num2 - 1;
							for (int j = arg_239_0; j <= num3; j++)
							{
								TreeNode treeNode2 = new TreeNode(null, 3, 3);
								treeNode2.Tag = "RS";
								treeNode.Nodes.Add(treeNode2);
							}
						}
					}
					else
					{
						EGlossarySubDataset subGlossariesByParentID = WebServiceLayer.GlossaryAccess.GetSubGlossariesByParentID(id);
						string columnName6 = subGlossariesByParentID.GetSubGlossariesByParentID.IDColumn.ColumnName;
						string columnName7 = subGlossariesByParentID.GetSubGlossariesByParentID.NameColumn.ColumnName;
						string columnName8 = subGlossariesByParentID.GetSubGlossariesByParentID.DescriptionColumn.ColumnName;
						string columnName9 = subGlossariesByParentID.GetSubGlossariesByParentID.GlossaryTypeColumn.ColumnName;
						int arg_2F1_0 = 0;
						int num4 = subGlossariesByParentID.GetSubGlossariesByParentID.Rows.Count - 1;
						for (int k = arg_2F1_0; k <= num4; k++)
						{
							string str3;
							if (subGlossariesByParentID.GetSubGlossariesByParentID.Rows[k][columnName6] == null)
							{
								str3 = null;
							}
							else
							{
								str3 = subGlossariesByParentID.GetSubGlossariesByParentID.Rows[k][columnName6].ToString();
							}
							string text3;
							if (subGlossariesByParentID.GetSubGlossariesByParentID.Rows[k][columnName7] == null)
							{
								text3 = null;
							}
							else
							{
								text3 = subGlossariesByParentID.GetSubGlossariesByParentID.Rows[k][columnName7].ToString();
							}
							string str4 = string.Format("{0}.{1}", this.GetAllName(parentNode), text3);
							TreeNode treeNode3 = new TreeNode(text3, 3, 3);
							treeNode3.Tag = "RS^" + str4 + "#TYPE:Glossary#GID:" + str3;
							parentNode.Nodes.Add(treeNode3);
						}
					}
				}
				catch (Exception expr_3D5)
				{
					ProjectData.SetProjectError(expr_3D5);
					Exception ex = expr_3D5;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
				return true;
			}
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

		public string GetId(TreeNode node)
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
			return text.Substring(checked(text.IndexOf("#GID:") + 5));
		}

		private string GetAllName(TreeNode node)
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
