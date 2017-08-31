using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using GlossaryItemData;
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
	public class GlossaryUnitTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("itemViewIcons")]
		private ImageList _itemViewIcons;

		private const int ROOT_NODE_IMAGE_INDEX = 0;

		private string _ID;

		private string _Name;

		private string _Desc;

		private string _GUID;

		private string _GlossaryCategoryID;

		private string _GlossaryType;

		private string _ParentID;

		internal virtual ImageList itemViewIcons
		{
			[DebuggerNonUserCode]
			get
			{
				return this._itemViewIcons;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._itemViewIcons = value;
			}
		}

		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		public string GName
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				this._GUID = value;
			}
		}

		public string CategoryID
		{
			get
			{
				return this._GlossaryCategoryID;
			}
			set
			{
				this._GlossaryCategoryID = value;
			}
		}

		public string GlossaryType
		{
			get
			{
				return this._GlossaryType;
			}
			set
			{
				this._GlossaryType = value;
			}
		}

		public string ParentID
		{
			get
			{
				return this._ParentID;
			}
			set
			{
				this._ParentID = value;
			}
		}

		public GlossaryUnitTree(IContainer Container) : this()
		{
			Container.Add(this);
		}

		public GlossaryUnitTree()
		{
			this._ID = null;
			this._Name = null;
			this._Desc = null;
			this._GUID = null;
			this._GlossaryCategoryID = null;
			this._GlossaryType = null;
			this._ParentID = null;
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
			ResourceManager resourceManager = new ResourceManager(typeof(GlossaryUnitTree));
			this.itemViewIcons = new ImageList(this.components);
			ImageList arg_3E_0 = this.itemViewIcons;
			Size imageSize = new Size(20, 20);
			arg_3E_0.ImageSize = imageSize;
			this.itemViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("itemViewIcons.ImageStream");
			this.itemViewIcons.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.itemViewIcons;
			this.SelectedImageIndex = 0;
			this.ShowRootLines = false;
		}

		public int GetImageIndex(string subItem)
		{
			string left = string.Empty;
			if (subItem.LastIndexOf(".") != -1)
			{
				left = subItem.Substring(checked(subItem.LastIndexOf(".") + 1), 1);
			}
			else
			{
				left = subItem.Substring(0, 1);
			}
			if (Operators.CompareString(left, "S", false) == 0)
			{
				return 1;
			}
			if (Operators.CompareString(left, "N", false) == 0)
			{
				return 2;
			}
			if (Operators.CompareString(left, "O", false) == 0)
			{
				return 3;
			}
			if (Operators.CompareString(left, "M", false) == 0)
			{
				return 4;
			}
			if (Operators.CompareString(left, "Q", false) == 0)
			{
				return 5;
			}
			if (Operators.CompareString(left, "D", false) == 0)
			{
				return 6;
			}
			if (Operators.CompareString(left, "I", false) == 0)
			{
				return 7;
			}
			if (Operators.CompareString(left, "T", false) == 0)
			{
				return 8;
			}
			if (Operators.CompareString(left, "C", false) == 0)
			{
				return 9;
			}
			if (Operators.CompareString(left, "E", false) == 0)
			{
				return 10;
			}
			if (Operators.CompareString(left, "L", false) == 0)
			{
				return 11;
			}
			if (Operators.CompareString(left, "G", false) == 0)
			{
				return 12;
			}
			if (Operators.CompareString(left, "Y", false) == 0)
			{
				return 13;
			}
			if (Operators.CompareString(left, "P", false) == 0)
			{
				return 14;
			}
			int result;
			return result;
		}

		public void InitTree()
		{
			this.Nodes.Clear();
			this.InitRootNode();
			this.InitTreeNodes(this.ID, this.GlossaryType, this.Nodes[0].Nodes);
		}

		private void InitRootNode()
		{
			TreeNode treeNode = new TreeNode(this.GName, 0, 0);
			if (Operators.CompareString(this.GlossaryType, EPRGlossaryType.TG.ToString(), false) == 0)
			{
				treeNode.Tag = string.Format("{0}^{1}", this.ID, this.GlossaryType);
			}
			else
			{
				treeNode.Tag = string.Format("{0}^{1}^{2}", this.ID, this.GlossaryType, this.ParentID);
			}
			this.Nodes.Add(treeNode);
		}

		private void InitTreeNodes(string glossaryID, string glossaryType, TreeNodeCollection curNodes)
		{
			if (Operators.CompareString(glossaryID, null, false) != 0)
			{
				if (Operators.CompareString(glossaryID, "", false) == 0)
				{
					return;
				}
				if (Operators.CompareString(glossaryType.ToUpper(), "TG", false) == 0)
				{
					EGlossaryItemDataset glossaryItems = WebServiceLayer.GlossaryItemAccess.GetGlossaryItems(glossaryID);
					if (glossaryItems != null & glossaryItems.GetItemsByID != null)
					{
						this.InitGlossaryItems(glossaryItems.GetItemsByID, glossaryID, ref curNodes);
					}
				}
				else
				{
					EGlossaryKBItemDataset glossaryKBItems = WebServiceLayer.GlossaryItemAccess.GetGlossaryKBItems(glossaryID);
					if (glossaryKBItems != null & glossaryKBItems.GetKBItemsByID != null)
					{
						this.InitGlossaryKBItems(glossaryKBItems.GetKBItemsByID, glossaryID, ref curNodes);
					}
				}
				this.ExpandAll();
			}
		}

		private void InitGlossaryItems(EGlossaryItemDataset.GetItemsByIDDataTable dt, string glossaryID, ref TreeNodeCollection nodes)
		{
			string filterExpression = dt.GlossaryIDColumn.ColumnName + "='" + glossaryID + "'";
			DataRow[] array = dt.Select(filterExpression);
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					string text = dataRow[dt.IDColumn.ColumnName].ToString();
					string arg = dataRow[dt.TemplateIDColumn.ColumnName].ToString();
					string text2 = dataRow[dt.ItemNameColumn.ColumnName].ToString();
					string text3 = dataRow[dt.ItemCodeColumn.ColumnName].ToString();
					string arg2 = dataRow[dt.ValueTypeColumn.ColumnName].ToString();
					int imageIndex = this.GetImageIndex(text3);
					TreeNode treeNode = new TreeNode(text2, imageIndex, imageIndex);
					treeNode.Tag = string.Format("{0}^{1}^{2}", arg, text3, arg2);
					nodes.Add(treeNode);
				}
			}
		}

		private void InitGlossaryKBItems(EGlossaryKBItemDataset.GetKBItemsByIDDataTable dt, string glossaryID, ref TreeNodeCollection nodes)
		{
			string filterExpression = dt.GlossaryIDColumn.ColumnName + "='" + glossaryID + "'";
			DataRow[] array = dt.Select(filterExpression);
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					string text = dataRow[dt.IDColumn.ColumnName].ToString();
					string text2 = dataRow[dt.ContextGlossaryIDColumn.ColumnName].ToString();
					string text3 = dataRow[dt.KBNodeIDColumn.ColumnName].ToString();
					string text4 = dataRow[dt.KBPartNoColumn.ColumnName].ToString();
					string text5 = dataRow[dt.ItemNameColumn.ColumnName].ToString();
					string text6 = dataRow[dt.ItemCodeColumn.ColumnName].ToString();
					string text7 = dataRow[dt.ValueTypeColumn.ColumnName].ToString();
					int imageIndex = this.GetImageIndex(text6);
					TreeNode treeNode = new TreeNode(text5, imageIndex, imageIndex);
					treeNode.Tag = string.Format("{0}^{1}^{2}^{3}", new object[]
					{
						text3,
						text4,
						text6,
						text7
					});
					nodes.Add(treeNode);
				}
			}
		}
	}
}
