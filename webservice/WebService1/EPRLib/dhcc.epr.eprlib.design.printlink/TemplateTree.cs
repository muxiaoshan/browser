using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using InterfaceTemplateData;
using ITCategoryData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.printlink
{
	public class TemplateTree : TreeView
	{
		public enum ShowLevel
		{
			Category = 1,
			Template,
			Version,
			OnlySingle,
			OnlyMultiple
		}

		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		private const string TREE_NAME = "界面模板";

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 1;

		protected const int INTERFACETEMPLATE_NODE_IMGINDEX = 2;

		protected const int NEW_VERSION_NODE_IMGINDEX = 3;

		protected const int MODIFY_VERSION_NODE_IMGINDEX = 4;

		protected const int PUBLISHED_VERSION_NODE_IMGINDEX = 5;

		public const string ROOT_NODE_TYPE = "RT";

		public const string CATEGORY_NODE_TYPE = "CG";

		public const string RESOURCE_NODE_TYPE = "LF";

		public const string VERSION_NODE_TYPE = "IT";

		private bool _ShowVersion;

		private bool _ShowTemplate;

		private bool _ShowOnlySingle;

		private bool _ShowOnlyMultiple;

		private bool _ShowBinded;

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

		public TemplateTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.KBTreeView_BeforeExpand);
			this._ShowVersion = true;
			this._ShowTemplate = true;
			this._ShowOnlySingle = false;
			this._ShowOnlyMultiple = false;
			this._ShowBinded = true;
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
			ResourceManager resourceManager = new ResourceManager(typeof(TemplateTree));
			this.treeViewIcons = new ImageList(this.components);
			ImageList arg_3E_0 = this.treeViewIcons;
			Size imageSize = new Size(16, 16);
			arg_3E_0.ImageSize = imageSize;
			this.treeViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.treeViewIcons;
			this.SelectedImageIndex = 0;
		}

		public TemplateTree(TemplateTree.ShowLevel level) : this()
		{
			if (level == TemplateTree.ShowLevel.Category)
			{
				this._ShowTemplate = false;
				this._ShowVersion = false;
			}
			else if (level == TemplateTree.ShowLevel.Template)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
			}
			else if (level == TemplateTree.ShowLevel.Version)
			{
				this._ShowTemplate = true;
				this._ShowVersion = true;
			}
			else if (level == TemplateTree.ShowLevel.OnlySingle)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
				this._ShowOnlySingle = true;
			}
			else if (level == TemplateTree.ShowLevel.OnlyMultiple)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
				this._ShowOnlyMultiple = true;
			}
		}

		public TemplateTree(TemplateTree.ShowLevel level, bool boolBinded) : this()
		{
			if (level == TemplateTree.ShowLevel.Category)
			{
				this._ShowTemplate = false;
				this._ShowVersion = false;
			}
			else if (level == TemplateTree.ShowLevel.Template)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
			}
			else if (level == TemplateTree.ShowLevel.Version)
			{
				this._ShowTemplate = true;
				this._ShowVersion = true;
			}
			else if (level == TemplateTree.ShowLevel.OnlySingle)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
				this._ShowOnlySingle = true;
			}
			else if (level == TemplateTree.ShowLevel.OnlyMultiple)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
				this._ShowOnlyMultiple = true;
			}
			else if (level == TemplateTree.ShowLevel.OnlyMultiple)
			{
				this._ShowTemplate = true;
				this._ShowVersion = false;
				this._ShowOnlyMultiple = true;
			}
			this._ShowBinded = boolBinded;
		}

		public void Init()
		{
			TreeNode treeNode = new TreeNode("界面模板", 0, 1);
			treeNode.Tag = "RT";
			this.Nodes.Add(treeNode);
			this.InitTreeViewNodes();
		}

		private void InitTreeViewNodes()
		{
			try
			{
				ETemplateCategoryDataset eTemplateCategoryDataset = WebServiceLayer.ITCategoryAccess.SelectAllTemplateCategory();
				if (eTemplateCategoryDataset != null & eTemplateCategoryDataset.SELECTALL != null)
				{
					this.initCategoryNodes(eTemplateCategoryDataset.SELECTALL, this.Nodes[0], "0");
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

		private void initCategoryNodes(ETemplateCategoryDataset.SELECTALLDataTable dt, TreeNode parentNode, string parentId)
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
					string text3 = dataRow[dt.CategoryTypeColumn.ColumnName].ToString();
					string text4 = dataRow[dt.CategoryPropertyColumn.ColumnName].ToString();
					TreeNode treeNode = new TreeNode(dataRow[dt.NameColumn.ColumnName].ToString(), 0, 0);
					treeNode.Tag = string.Concat(new string[]
					{
						"CG^",
						text,
						"^",
						text4,
						"^",
						text3
					});
					parentNode.Nodes.Add(treeNode);
					this.initCategoryNodes(dt, treeNode, text);
					if (this._ShowTemplate)
					{
						int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
						int arg_159_0 = 0;
						int num2 = num - 1;
						for (int j = arg_159_0; j <= num2; j++)
						{
							TreeNode treeNode2 = new TreeNode(null, 2, 2);
							treeNode2.Tag = "LF";
							treeNode.Nodes.Add(treeNode2);
						}
					}
				}
			}
		}

		private void KBTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				string nodeType = this.GetNodeType(e.Node);
				if (Operators.CompareString(nodeType, "CG", false) == 0 & this._ShowTemplate)
				{
					e.Cancel = !this.initResourceNodes(e.Node);
				}
				else if (Operators.CompareString(nodeType, "LF", false) == 0 & this._ShowVersion)
				{
					e.Cancel = !this.initVersionNodes(e.Node);
				}
			}
		}

		public bool initResourceNodes(TreeNode parentNode)
		{
			bool result = false;
			string nodeId = this.GetNodeId(parentNode);
			checked
			{
				if (nodeId != null)
				{
					try
					{
						ETemplateDataset templateAll = WebServiceLayer.InterfaceTemplateAccess.GetTemplateAll(nodeId);
						parentNode.Nodes.Clear();
						string columnName = templateAll.SELECTALLByCategoryID.IDColumn.ColumnName;
						string columnName2 = templateAll.SELECTALLByCategoryID.NameColumn.ColumnName;
						string columnName3 = templateAll.SELECTALLByCategoryID.DescriptionColumn.ColumnName;
						string columnName4 = templateAll.SELECTALLByCategoryID.LastVersionColumn.ColumnName;
						string columnName5 = templateAll.SELECTALLByCategoryID.ChartItemTypeColumn.ColumnName;
						string columnName6 = templateAll.SELECTALLByCategoryID.TemplatePropertyColumn.ColumnName;
						string columnName7 = templateAll.SELECTALLByCategoryID.BindPrintTemplateIDColumn.ColumnName;
						int arg_C2_0 = 0;
						int num = templateAll.SELECTALLByCategoryID.Rows.Count - 1;
						for (int i = arg_C2_0; i <= num; i++)
						{
							string text;
							if (templateAll.SELECTALLByCategoryID.Rows[i][columnName7] is DBNull)
							{
								text = null;
							}
							else
							{
								text = Conversions.ToString(templateAll.SELECTALLByCategoryID.Rows[i][columnName7]);
							}
							string left;
							if (templateAll.SELECTALLByCategoryID.Rows[i][columnName5] is DBNull)
							{
								left = null;
							}
							else
							{
								left = Conversions.ToString(templateAll.SELECTALLByCategoryID.Rows[i][columnName5]);
							}
							bool flag = true;
							if (this._ShowOnlySingle & Operators.CompareString(left, TemplateType.Multiple.ToString(), false) == 0)
							{
								flag = false;
							}
							if (this._ShowOnlyMultiple & Operators.CompareString(left, TemplateType.Single.ToString(), false) == 0)
							{
								flag = false;
							}
							if (!this._ShowBinded & !(text == null | Operators.CompareString(text, "", false) == 0))
							{
								flag = false;
							}
							if (flag)
							{
								TreeNode treeNode = new TreeNode(templateAll.SELECTALLByCategoryID.Rows[i][columnName2].ToString(), 2, 2);
								treeNode.Tag = "LF^" + templateAll.SELECTALLByCategoryID.Rows[i][columnName].ToString() + "^" + templateAll.SELECTALLByCategoryID.Rows[i][columnName6].ToString();
								parentNode.Nodes.Add(treeNode);
								if (Operators.CompareString(templateAll.SELECTALLByCategoryID.Rows[i][columnName4].ToString(), "0", false) != 0 & this._ShowVersion)
								{
									int num2 = Convert.ToInt32(templateAll.SELECTALLByCategoryID.Rows[i][columnName4].ToString());
									int arg_2BB_0 = 0;
									int num3 = num2 - 1;
									for (int j = arg_2BB_0; j <= num3; j++)
									{
										TreeNode treeNode2 = new TreeNode(null, 3, 3);
										treeNode2.Tag = "LF";
										treeNode.Nodes.Add(treeNode2);
									}
								}
							}
						}
						result = true;
					}
					catch (Exception expr_303)
					{
						ProjectData.SetProjectError(expr_303);
						Exception ex = expr_303;
						MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private bool initVersionNodes(TreeNode parentNode)
		{
			bool result = false;
			string nodeId = this.GetNodeId(parentNode);
			checked
			{
				if (nodeId != null)
				{
					try
					{
						ETemplateVersionDataset templateVersionAll = WebServiceLayer.InterfaceTemplateAccess.GetTemplateVersionAll(nodeId);
						if (templateVersionAll.SELECTALL.Rows.Count <= 0)
						{
							throw new AppException("获取版本信息失败。");
						}
						parentNode.Nodes.Clear();
						string columnName = templateVersionAll.SELECTALL.IDColumn.ColumnName;
						string columnName2 = templateVersionAll.SELECTALL.VersionNumberColumn.ColumnName;
						string columnName3 = templateVersionAll.SELECTALL.CreateDateColumn.ColumnName;
						string columnName4 = templateVersionAll.SELECTALL.LastSaveDateColumn.ColumnName;
						string columnName5 = templateVersionAll.SELECTALL.PublicationDateColumn.ColumnName;
						string columnName6 = templateVersionAll.SELECTALL.StatusColumn.ColumnName;
						int arg_CB_0 = 0;
						int num = templateVersionAll.SELECTALL.Rows.Count - 1;
						for (int i = arg_CB_0; i <= num; i++)
						{
							int num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(templateVersionAll.SELECTALL.Rows[i][columnName6]));
							string text;
							int num3;
							if (num2 == 2)
							{
								text = "V" + templateVersionAll.SELECTALL.Rows[i][columnName2].ToString() + ".0 " + Convert.ToDateTime(RuntimeHelpers.GetObjectValue(templateVersionAll.SELECTALL.Rows[i][columnName5])).ToString("yyyy-M-d");
								num3 = 5;
							}
							else if (num2 == 1)
							{
								text = "V" + templateVersionAll.SELECTALL.Rows[i][columnName2].ToString() + ".0 " + Convert.ToDateTime(RuntimeHelpers.GetObjectValue(templateVersionAll.SELECTALL.Rows[i][columnName4])).ToString("yyyy-M-d");
								num3 = 4;
							}
							else
							{
								text = "V" + templateVersionAll.SELECTALL.Rows[i][columnName2].ToString() + ".0 " + Convert.ToDateTime(RuntimeHelpers.GetObjectValue(templateVersionAll.SELECTALL.Rows[i][columnName3])).ToString("yyyy-M-d");
								num3 = 3;
							}
							TreeNode treeNode = new TreeNode(text, num3, num3);
							treeNode.Tag = "IT" + templateVersionAll.SELECTALL.Rows[i][columnName].ToString();
							parentNode.Nodes.Add(treeNode);
						}
						result = true;
					}
					catch (AppException expr_299)
					{
						ProjectData.SetProjectError(expr_299);
						AppException ex = expr_299;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		public string GetNodeId(TreeNode node)
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
				1
			}, null));
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

		public string GetNodeProperty(TreeNode node)
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
				2
			}, null));
		}

		public string GetNodeCategoryType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			if (Operators.CompareString(this.GetNodeType(node), "CG", false) == 0)
			{
				return Conversions.ToString(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(node.Tag, null, "Split", new object[]
				{
					"^"
				}, null, null, null), new object[]
				{
					3
				}, null));
			}
			return null;
		}

		public string GetCategoryInfo(TreeNode node)
		{
			if (node.Parent != null && Operators.CompareString(this.GetNodeType(node.Parent), "CG", false) == 0 && node.Parent.Text.ToString() != null)
			{
				return this.GetCategoryInfo(node.Parent) + "." + node.Parent.Text.ToString();
			}
			return node.Parent.Text.ToString();
		}
	}
}
