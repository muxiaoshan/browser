using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using ImageItemData;
using ImageLibData;
using ImageTreeData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class ImageLibTree : EPRTreeView
	{
		private IContainer components;

		[AccessedThroughProperty("cmImageTree")]
		private ContextMenu _cmImageTree;

		[AccessedThroughProperty("ilKBTree")]
		private ImageList _ilKBTree;

		public const int TREE_NODE_COLLAPSE_IMGINDEX = 0;

		public const int TREE_NODE_EXPAND_IMGINDEX = 1;

		public const int LIBNODE_NODE_IMGINDEX = 2;

		public const string ROOT_NODE_TYPE = "RT";

		public const string TREE_NODE_TYPE = "CG";

		public const string RESOURCE_NODE_TYPE = "LF";

		public const string PERSONAL_TREE_NODE_TYPE = "PC";

		public const string DEFAULT_TREE_NODE_NAME = "新增目录";

		public const string DEFAULT_RESOURCE_NODE_NAME = "新增节点";

		private string NODE_TYPE;

		[AccessedThroughProperty("miCut")]
		private MenuItem _miCut;

		[AccessedThroughProperty("miDelete")]
		private MenuItem _miDelete;

		[AccessedThroughProperty("miNodeUp")]
		private MenuItem _miNodeUp;

		[AccessedThroughProperty("miNodeDown")]
		private MenuItem _miNodeDown;

		[AccessedThroughProperty("miAddImage")]
		private MenuItem _miAddImage;

		[AccessedThroughProperty("miAddFolder")]
		private MenuItem _miAddFolder;

		[AccessedThroughProperty("miAddPersonalFolder")]
		private MenuItem _miAddPersonalFolder;

		private TreeNode CurrentNode;

		private string CurrentNodeType;

		private bool _Editable;

		private bool _ClientMode;

		private EImageLib _EImageLib;

		private TreeNode _DragTreeNode;

		private string _LocID;

		private string _UserID;

		private string _UserName;

		private string _DiagnosID;

		internal virtual ContextMenu cmImageTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmImageTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmImageTree = value;
			}
		}

		internal virtual ImageList ilKBTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ilKBTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ilKBTree = value;
			}
		}

		protected virtual MenuItem miCut
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miCut;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._miCut = value;
			}
		}

		protected virtual MenuItem miDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._miDelete = value;
			}
		}

		protected virtual MenuItem miNodeUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miNodeUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miNodeUp_Click);
				if (this._miNodeUp != null)
				{
					this._miNodeUp.Click -= value2;
				}
				this._miNodeUp = value;
				if (this._miNodeUp != null)
				{
					this._miNodeUp.Click += value2;
				}
			}
		}

		protected virtual MenuItem miNodeDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miNodeDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miNodeDown_Click);
				if (this._miNodeDown != null)
				{
					this._miNodeDown.Click -= value2;
				}
				this._miNodeDown = value;
				if (this._miNodeDown != null)
				{
					this._miNodeDown.Click += value2;
				}
			}
		}

		protected virtual MenuItem miAddImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miAddImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miAddImage_Click);
				if (this._miAddImage != null)
				{
					this._miAddImage.Click -= value2;
				}
				this._miAddImage = value;
				if (this._miAddImage != null)
				{
					this._miAddImage.Click += value2;
				}
			}
		}

		protected virtual MenuItem miAddFolder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miAddFolder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miAddFolder_Click);
				if (this._miAddFolder != null)
				{
					this._miAddFolder.Click -= value2;
				}
				this._miAddFolder = value;
				if (this._miAddFolder != null)
				{
					this._miAddFolder.Click += value2;
				}
			}
		}

		protected virtual MenuItem miAddPersonalFolder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miAddPersonalFolder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miAddPersonalFolder_Click);
				if (this._miAddPersonalFolder != null)
				{
					this._miAddPersonalFolder.Click -= value2;
				}
				this._miAddPersonalFolder = value;
				if (this._miAddPersonalFolder != null)
				{
					this._miAddPersonalFolder.Click += value2;
				}
			}
		}

		public bool ClientMode
		{
			get
			{
				return this._ClientMode;
			}
			set
			{
				this._ClientMode = value;
			}
		}

		public bool Editable
		{
			get
			{
				return this._Editable;
			}
			set
			{
				this._Editable = value;
			}
		}

		public object DiagnosID
		{
			get
			{
				return this._DiagnosID;
			}
			set
			{
				this._DiagnosID = Conversions.ToString(value);
			}
		}

		public EImageLib EImageLib
		{
			get
			{
				return this._EImageLib;
			}
			set
			{
				this._EImageLib = value;
				this.Nodes.Clear();
				TreeNode treeNode = new TreeNode(this._EImageLib.Name, 0, 1);
				treeNode.Tag = "RT";
				this.Nodes.Add(treeNode);
				string valueByKey = GlobalValues.GetValueByKey("CTLocID");
				if (Operators.CompareString(valueByKey, null, false) == 0)
				{
					this.InitTreeViewNodes(this._EImageLib.ID, "");
				}
				else
				{
					this.InitTreeViewNodes(this._EImageLib.ID, valueByKey);
				}
			}
		}

		public ImageLibTree()
		{
			base.BeforeExpand += new TreeViewCancelEventHandler(this.ImageLibTree_BeforeExpand);
			base.MouseDown += new MouseEventHandler(this.ImageLibTree_MouseDown);
			this.NODE_TYPE = "1";
			this._LocID = string.Empty;
			this._UserID = string.Empty;
			this._UserName = string.Empty;
			this._DiagnosID = string.Empty;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ImageLibTree));
			this.cmImageTree = new ContextMenu();
			this.ilKBTree = new ImageList(this.components);
			this.SuspendLayout();
			this.ilKBTree.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ilKBTree.ImageStream");
			this.ilKBTree.TransparentColor = Color.Transparent;
			this.ilKBTree.Images.SetKeyName(0, "");
			this.ilKBTree.Images.SetKeyName(1, "");
			this.ilKBTree.Images.SetKeyName(2, "");
			this.ilKBTree.Images.SetKeyName(3, "");
			this.ilKBTree.Images.SetKeyName(4, "");
			this.ilKBTree.Images.SetKeyName(5, "");
			this.AllowDrop = true;
			this.HideSelection = false;
			this.ImageIndex = 0;
			this.ImageList = this.ilKBTree;
			this.Name = "ImageLibTree";
			this.SelectedImageIndex = 0;
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.miAddFolder = new MenuItem("新增目录");
			this.miAddImage = new MenuItem("新增节点");
			this.miNodeUp = new MenuItem("节点上移");
			this.miNodeDown = new MenuItem("节点下移");
			this.miAddPersonalFolder = new MenuItem("新增个人图库");
			this._LocID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("CTLocID") == null, string.Empty, GlobalValues.GetValueByKey("CTLocID")));
			this._UserID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserID") == null, string.Empty, GlobalValues.GetValueByKey("UserID")));
			this._UserName = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserName") == null, string.Empty, GlobalValues.GetValueByKey("UserName")));
		}

		private void InitTreeViewNodes(string imageLibID, string locID)
		{
			try
			{
				EImageTreeDataSet byImageLibID = WebServiceLayer.ImageTreeAccess.GetByImageLibID(imageLibID);
				if (byImageLibID != null & byImageLibID.GetByImageLibID != null)
				{
					this.InitCategoryNodes(byImageLibID.GetByImageLibID, this.Nodes[0], "0", locID);
				}
				this.Nodes[0].Expand();
			}
			catch (Exception expr_53)
			{
				ProjectData.SetProjectError(expr_53);
				Exception ex = expr_53;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(EImageTreeDataSet.GetByImageLibIDDataTable dt, TreeNode parentNode, string parentID, string ctLocID)
		{
			string filterExpression = Conversions.ToString(this.GetFilter(dt, parentID, ctLocID, this._UserID));
			DataRow[] array = dt.Select(filterExpression, "Sequence asc");
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
					treeNode.Tag = "CG" + text;
					parentNode.Nodes.Add(treeNode);
					this.InitCategoryNodes(dt, treeNode, text, ctLocID);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ChildCountColumn.ColumnName]));
					int arg_EC_0 = 0;
					int num2 = num - 1;
					for (int j = arg_EC_0; j <= num2; j++)
					{
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "LF";
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
		}

		private object GetFilter(EImageTreeDataSet.GetByImageLibIDDataTable dt, string parentNodeID, string ctLocID, string userID)
		{
			return dt.ParentIDColumn.ColumnName + "='" + parentNodeID + "'";
		}

		private object GetCTLocLibFilter(string columnName, string ctLocID)
		{
			string empty = string.Empty;
			return columnName + " in " + empty;
		}

		private object GetPersonalLibFilter(string columnName, string userID)
		{
			string text = columnName + " is " + "null";
			string text2 = columnName + " = " + "''";
			string text3 = columnName + " = " + userID;
			return string.Concat(new string[]
			{
				"(",
				text,
				" or ",
				text2,
				" or ",
				text3,
				")"
			});
		}

		private string IsPersonalTreeNode(string userID)
		{
			if (!string.IsNullOrEmpty(userID))
			{
				return Conversions.ToString(true);
			}
			return Conversions.ToString(false);
		}

		private void ImageLibTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
			{
				e.Cancel = !this.InitResourceNodes(e.Node);
			}
		}

		private bool InitResourceNodes(TreeNode parentNode)
		{
			bool result = false;
			string nodeID = ImageLibTree.GetNodeID(parentNode);
			checked
			{
				if (nodeID != null)
				{
					try
					{
						EImageItemDataSet byImageTreeID = WebServiceLayer.ImageItemAccess.GetByImageTreeID(nodeID);
						if (this.ClientMode)
						{
							string empty = string.Empty;
							string sysOptionValue = SysOptionManager.GetSysOptionValue("ImageLibDiagnosFilter", "N");
							if (Operators.CompareString(sysOptionValue, "Y", false) == 0)
							{
								Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(this.DiagnosID, string.Empty, false), Operators.CompareObjectNotEqual(this.DiagnosID, "0", false)));
							}
						}
						string columnName = byImageTreeID.GetByImageTreeID.IDColumn.ColumnName;
						string columnName2 = byImageTreeID.GetByImageTreeID.NameColumn.ColumnName;
						string columnName3 = byImageTreeID.GetByImageTreeID.DescriptionColumn.ColumnName;
						if (parentNode.Nodes.Count == byImageTreeID.GetByImageTreeID.Rows.Count)
						{
							int arg_E8_0 = 0;
							int num = byImageTreeID.GetByImageTreeID.Rows.Count - 1;
							for (int i = arg_E8_0; i <= num; i++)
							{
								parentNode.Nodes[i].Tag = "LF" + byImageTreeID.GetByImageTreeID.Rows[i][columnName].ToString();
								parentNode.Nodes[i].Text = byImageTreeID.GetByImageTreeID.Rows[i][columnName2].ToString();
							}
						}
						else
						{
							int arg_179_0 = 0;
							int num2 = parentNode.Nodes.Count - 1;
							for (int j = arg_179_0; j <= num2; j++)
							{
								parentNode.Nodes[0].Remove();
							}
							int arg_1B0_0 = 0;
							int num3 = byImageTreeID.GetByImageTreeID.Rows.Count - 1;
							for (int k = arg_1B0_0; k <= num3; k++)
							{
								TreeNode treeNode = new TreeNode(null, 2, 2);
								treeNode.Tag = "LF" + byImageTreeID.GetByImageTreeID.Rows[k][columnName].ToString();
								treeNode.Text = byImageTreeID.GetByImageTreeID.Rows[k][columnName2].ToString();
								parentNode.Nodes.Add(treeNode);
							}
						}
						result = true;
					}
					catch (AppException expr_232)
					{
						ProjectData.SetProjectError(expr_232);
						AppException ex = expr_232;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private EImageItemDataSet DataTableFilter(EImageItemDataSet dsNode, ref string nodeID)
		{
			string[] array = nodeID.Split(new char[]
			{
				','
			});
			EImageItemDataSet eImageItemDataSet = (EImageItemDataSet)dsNode.Clone();
			checked
			{
				try
				{
					IEnumerator enumerator = dsNode.GetByImageTreeID.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string right = array2[i];
							if (Operators.CompareString(dataRow["ID"].ToString(), right, false) == 0)
							{
								eImageItemDataSet.GetByImageTreeID.ImportRow(dataRow);
							}
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
				return eImageItemDataSet;
			}
		}

		public static string GetNodeID(TreeNode node)
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

		public static string GetNodeType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(0, 2);
		}

		private string ReplaceXmlStrImageLibNodeID(string strReplace, string flag, string nodeID)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(strReplace);
			if (Operators.CompareString(flag, "InstanceData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//NISegment/ImageLibNodeID");
				xmlNode.InnerText = nodeID;
			}
			else if (Operators.CompareString(flag, "MetaData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//MISegment/KBNodeID");
				xmlNode.InnerText = nodeID;
			}
			return xmlDocument.OuterXml;
		}

		private void ImageLibTree_MouseDown(object sender, MouseEventArgs e)
		{
			TreeNode nodeAt = this.GetNodeAt(e.Location);
			this.SetCurrentNodeInfo(nodeAt);
			this.cmImageTree.MenuItems.Clear();
			if (nodeAt != null && e.Button == MouseButtons.Right)
			{
				this.SetImageTreeMenu(ImageLibTree.GetNodeType(nodeAt));
				ContextMenu arg_5B_0 = this.cmImageTree;
				Point pos = new Point(e.X, e.Y);
				arg_5B_0.Show(this, pos);
			}
		}

		private void miAddFolder_Click(object sender, EventArgs e)
		{
			try
			{
				EImageTree eImageTree = this.CreateImageTree(this._UserID, this._UserName);
				TreeNode treeNode = new TreeNode(eImageTree.Name, 0, 1);
				treeNode.Tag = this.CreateImageTreeTag(eImageTree.ID);
				this.SelectedNode.Nodes.Add(treeNode);
				this.SelectedNode.Expand();
				this.SelectedNode = treeNode;
			}
			catch (Exception expr_59)
			{
				ProjectData.SetProjectError(expr_59);
				Exception ex = expr_59;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void miAddImage_Click(object sender, EventArgs e)
		{
			try
			{
				EImageItem eImageItem = new EImageItem();
				eImageItem.Name = "新增节点";
				eImageItem.ImageLibID = Conversions.ToLong(this._EImageLib.ID);
				eImageItem.ImageLibIDSpecified = true;
				eImageItem.ImageTreeID = Conversions.ToLong(ImageLibTree.GetNodeID(this.CurrentNode));
				eImageItem.ImageTreeIDSpecified = true;
				eImageItem.Status = "0";
				eImageItem.IsPublish = "0";
				string text = WebServiceLayer.ImageItemAccess.Create(eImageItem);
				eImageItem.ID = text;
				TreeNode treeNode = new TreeNode(eImageItem.Name, 2, 2);
				treeNode.Tag = "LF" + text;
				this.SelectedNode.Nodes.Add(treeNode);
				this.SelectedNode.Expand();
				this.SelectedNode = treeNode;
			}
			catch (Exception expr_B9)
			{
				ProjectData.SetProjectError(expr_B9);
				Exception ex = expr_B9;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void miNodeUp_Click(object sender, EventArgs e)
		{
			if (this.SelectedNode != null)
			{
				TreeNode prevNode = this.SelectedNode.PrevNode;
				if (prevNode != null)
				{
					string nodeID = ImageLibTree.GetNodeID(prevNode);
					string nodeID2 = ImageLibTree.GetNodeID(this.SelectedNode);
					this.SelectedNode.PrevNode.Remove();
					int index = checked(this.SelectedNode.Index + 1);
					if (this.SelectedNode.Parent == null)
					{
						this.Nodes.Insert(index, prevNode);
					}
					else
					{
						this.SelectedNode.Parent.Nodes.Insert(index, prevNode);
						if (Operators.CompareString(this.NODE_TYPE, "2", false) == 0)
						{
							this.SwapSequence(ref nodeID, ref nodeID2);
						}
						else if (Operators.CompareString(this.NODE_TYPE, "1", false) == 0)
						{
							this.SwapFordSequence(ref nodeID, ref nodeID2);
						}
					}
				}
			}
		}

		private void miNodeDown_Click(object sender, EventArgs e)
		{
			if (this.SelectedNode != null)
			{
				TreeNode nextNode = this.SelectedNode.NextNode;
				if (nextNode != null)
				{
					string nodeID = ImageLibTree.GetNodeID(nextNode);
					string nodeID2 = ImageLibTree.GetNodeID(this.SelectedNode);
					this.SelectedNode.NextNode.Remove();
					int index = this.SelectedNode.Index;
					if (this.SelectedNode.Parent == null)
					{
						this.Nodes.Insert(index, nextNode);
					}
					else
					{
						this.SelectedNode.Parent.Nodes.Insert(index, nextNode);
						if (Operators.CompareString(this.NODE_TYPE, "2", false) == 0)
						{
							this.SwapSequence(ref nodeID, ref nodeID2);
						}
						else if (Operators.CompareString(this.NODE_TYPE, "1", false) == 0)
						{
							this.SwapFordSequence(ref nodeID, ref nodeID2);
						}
					}
				}
			}
		}

		private void SwapSequence(ref string preNodeID, ref string curNodeID)
		{
			ImageTreeInfo arg_0F_0 = WebServiceLayer.ImageTreeAccess;
			string arg_0F_1 = preNodeID;
			string arg_0F_2 = curNodeID;
			bool flag = true;
			bool flag2;
			arg_0F_0.SwapSequence(arg_0F_1, arg_0F_2, ref flag2, ref flag);
		}

		private void SwapFordSequence(ref string preNodeID, ref string curNodeID)
		{
			ImageTreeInfo arg_0F_0 = WebServiceLayer.ImageTreeAccess;
			string arg_0F_1 = preNodeID;
			string arg_0F_2 = curNodeID;
			bool flag = true;
			bool flag2;
			arg_0F_0.SwapSequence(arg_0F_1, arg_0F_2, ref flag2, ref flag);
		}

		private void miAddPersonalFolder_Click(object sender, EventArgs e)
		{
			this.miAddFolder_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void SetCurrentNodeInfo(TreeNode curTreeNode)
		{
			this.SelectedNode = curTreeNode;
			this.CurrentNode = curTreeNode;
			this.CurrentNodeType = ImageLibTree.GetNodeType(curTreeNode);
		}

		private void SetImageTreeMenu(string strNodeType)
		{
			this.NODE_TYPE = "1";
			if (this._ClientMode)
			{
				this.SetClientImageTreeMenu(strNodeType);
			}
			else
			{
				this.SetMaintainImageTreeMenu(strNodeType);
			}
		}

		private void SetClientImageTreeMenu(string strNodeType)
		{
		}

		private void SetMaintainImageTreeMenu(string strNodeType)
		{
			if (Operators.CompareString(strNodeType, "RT", false) == 0)
			{
				this.cmImageTree.MenuItems.Add(this.miAddFolder);
			}
			else if (Operators.CompareString(strNodeType, "CG", false) == 0)
			{
				if (this.CurrentNode.Nodes.Count == 0)
				{
					this.cmImageTree.MenuItems.Add(this.miAddFolder);
					this.cmImageTree.MenuItems.Add(this.miAddImage);
				}
				else if (Operators.CompareString(ImageLibTree.GetNodeType(this.CurrentNode.Nodes[0]), "CG", false) == 0)
				{
					this.cmImageTree.MenuItems.Add(this.miAddFolder);
				}
				else if (Operators.CompareString(ImageLibTree.GetNodeType(this.CurrentNode.Nodes[0]), "PC", false) == 0)
				{
					this.cmImageTree.MenuItems.Add(this.miAddFolder);
				}
				else
				{
					this.cmImageTree.MenuItems.Add(this.miAddImage);
				}
			}
			else if (Operators.CompareString(strNodeType, "PC", false) != 0)
			{
				if (Operators.CompareString(strNodeType, "LF", false) == 0)
				{
					this.NODE_TYPE = "2";
				}
			}
		}

		private EImageTree CreateImageTree(string userID, string userName)
		{
			EImageTree eImageTree = new EImageTree();
			eImageTree.ImageLibID = this._EImageLib.ID;
			eImageTree.Name = this.GetImageTreeName(userName);
			eImageTree.UserID = this._UserID;
			eImageTree.ParentID = ImageLibTree.GetNodeID(this.CurrentNode);
			eImageTree.ID = WebServiceLayer.ImageTreeAccess.Create(eImageTree);
			return eImageTree;
		}

		private string GetImageTreeName(string userName)
		{
			if (this._ClientMode && this.CurrentNode.Level == 1)
			{
				return userName + "个人图库";
			}
			return "新增目录";
		}

		private string CreateImageTreeTag(string imageTreeID)
		{
			if (this._ClientMode)
			{
				return "PC" + imageTreeID;
			}
			return "CG" + imageTreeID;
		}

		private bool IsRealClientMode(bool isClientMode, string envVariable)
		{
			return isClientMode && envVariable != null && !envVariable.Equals(string.Empty);
		}
	}
}
