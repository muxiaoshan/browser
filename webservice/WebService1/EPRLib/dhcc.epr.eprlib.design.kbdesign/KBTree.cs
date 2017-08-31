using BOEPRDiagnosConfig;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using KBNodeData;
using KBTreeData;
using KnowledgeBaseData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class KBTree : EPRTreeView
	{
		private IContainer components;

		[AccessedThroughProperty("cmKBTree")]
		private ContextMenu _cmKBTree;

		[AccessedThroughProperty("ilKBTree")]
		private ImageList _ilKBTree;

		public static KBTree ConstKBTree;

		public const int TREE_NODE_COLLAPSE_IMGINDEX = 0;

		public const int TREE_NODE_EXPAND_IMGINDEX = 1;

		public const int KBNODE_NODE_IMGINDEX = 2;

		public const string ROOT_NODE_TYPE = "RT";

		public const string TREE_NODE_TYPE = "CG";

		public const string RESOURCE_NODE_TYPE = "LF";

		public const string PERSONAL_TREE_NODE_TYPE = "PC";

		public const string DEFAULT_TREE_NODE_NAME = "新增目录";

		public const string DEFAULT_RESOURCE_NODE_NAME = "新增节点";

		private string NODE_TYPE;

		[AccessedThroughProperty("miAddFolder")]
		private MenuItem _miAddFolder;

		[AccessedThroughProperty("miAddKBNode")]
		private MenuItem _miAddKBNode;

		[AccessedThroughProperty("miCut")]
		private MenuItem _miCut;

		[AccessedThroughProperty("miCopy")]
		private MenuItem _miCopy;

		[AccessedThroughProperty("miPaste")]
		private MenuItem _miPaste;

		[AccessedThroughProperty("miDelete")]
		private MenuItem _miDelete;

		[AccessedThroughProperty("miExport")]
		private MenuItem _miExport;

		[AccessedThroughProperty("miImport")]
		private MenuItem _miImport;

		[AccessedThroughProperty("miEdit")]
		private MenuItem _miEdit;

		[AccessedThroughProperty("miAddPersonalFolder")]
		private MenuItem _miAddPersonalFolder;

		[AccessedThroughProperty("miCategoryEdit")]
		private MenuItem _miCategoryEdit;

		[AccessedThroughProperty("miConvertToCommon")]
		private MenuItem _miConvertToCommon;

		[AccessedThroughProperty("miNodeUp")]
		private MenuItem _miNodeUp;

		[AccessedThroughProperty("miNodeDown")]
		private MenuItem _miNodeDown;

		public MenuItem miAddContent;

		public MenuItem miReplaceContent;

		private EKnowledgeBase _EKnowledgeBase;

		private string CurrentNodeType;

		private TreeNode CurrentNode;

		private bool _ClientMode;

		private bool _Editable;

		private TreeNode _DragTreeNode;

		private static EKBNode CopyKBNode;

		private ArrayList m_ArrayOldTid;

		private ArrayList m_ArrayNewTid;

		private ArrayList m_ArrayGuid;

		private ArrayList m_ArrayDesc;

		private string _CtLocID;

		private string _UserID;

		private string _UserName;

		private string _KBDiagnosID;

		private string CanDeleteNode;

		private EKBNodeSelectByNameDataset dsKBNode;

		private string FindText;

		internal virtual ContextMenu cmKBTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmKBTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmKBTree = value;
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

		protected virtual MenuItem miAddKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miAddKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miAddKBNode_Click);
				if (this._miAddKBNode != null)
				{
					this._miAddKBNode.Click -= value2;
				}
				this._miAddKBNode = value;
				if (this._miAddKBNode != null)
				{
					this._miAddKBNode.Click += value2;
				}
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

		protected virtual MenuItem miCopy
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miCopy;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miCopy_Click);
				if (this._miCopy != null)
				{
					this._miCopy.Click -= value2;
				}
				this._miCopy = value;
				if (this._miCopy != null)
				{
					this._miCopy.Click += value2;
				}
			}
		}

		protected virtual MenuItem miPaste
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miPaste;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miPaste_Click);
				if (this._miPaste != null)
				{
					this._miPaste.Click -= value2;
				}
				this._miPaste = value;
				if (this._miPaste != null)
				{
					this._miPaste.Click += value2;
				}
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
				EventHandler value2 = new EventHandler(this.miDelete_Click);
				if (this._miDelete != null)
				{
					this._miDelete.Click -= value2;
				}
				this._miDelete = value;
				if (this._miDelete != null)
				{
					this._miDelete.Click += value2;
				}
			}
		}

		protected virtual MenuItem miExport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miExport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miExport_Click);
				if (this._miExport != null)
				{
					this._miExport.Click -= value2;
				}
				this._miExport = value;
				if (this._miExport != null)
				{
					this._miExport.Click += value2;
				}
			}
		}

		protected virtual MenuItem miImport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miImport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miImport_Click);
				if (this._miImport != null)
				{
					this._miImport.Click -= value2;
				}
				this._miImport = value;
				if (this._miImport != null)
				{
					this._miImport.Click += value2;
				}
			}
		}

		protected virtual MenuItem miEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miEdit_Click);
				if (this._miEdit != null)
				{
					this._miEdit.Click -= value2;
				}
				this._miEdit = value;
				if (this._miEdit != null)
				{
					this._miEdit.Click += value2;
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

		protected virtual MenuItem miCategoryEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miCategoryEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miCategoryEdit_Click);
				if (this._miCategoryEdit != null)
				{
					this._miCategoryEdit.Click -= value2;
				}
				this._miCategoryEdit = value;
				if (this._miCategoryEdit != null)
				{
					this._miCategoryEdit.Click += value2;
				}
			}
		}

		protected virtual MenuItem miConvertToCommon
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miConvertToCommon;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miConvertToCommon_Click);
				if (this._miConvertToCommon != null)
				{
					this._miConvertToCommon.Click -= value2;
				}
				this._miConvertToCommon = value;
				if (this._miConvertToCommon != null)
				{
					this._miConvertToCommon.Click += value2;
				}
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

		public object KBDiagnosID
		{
			get
			{
				return this._KBDiagnosID;
			}
			set
			{
				this._KBDiagnosID = Conversions.ToString(value);
			}
		}

		public EKnowledgeBase EKnowledgeBase
		{
			get
			{
				return this._EKnowledgeBase;
			}
			set
			{
				this._EKnowledgeBase = value;
				this.Nodes.Clear();
				TreeNode treeNode = new TreeNode(this._EKnowledgeBase.Name, 0, 1);
				treeNode.Tag = "RT";
				this.Nodes.Add(treeNode);
				string valueByKey = GlobalValues.GetValueByKey("CTLocID");
				if (Operators.CompareString(valueByKey, null, false) == 0)
				{
					this.InitTreeViewNodes(this._EKnowledgeBase.ID, "");
				}
				else
				{
					this.InitTreeViewNodes(this._EKnowledgeBase.ID, valueByKey);
				}
			}
		}

		public KBTree()
		{
			base.MouseDown += new MouseEventHandler(this.KBTree_MouseDown);
			base.ItemDrag += new ItemDragEventHandler(this.KBTree_ItemDrag);
			base.DragDrop += new DragEventHandler(this.KBTree_DragDrop);
			base.DragOver += new DragEventHandler(this.KBTree_DragOver);
			base.BeforeExpand += new TreeViewCancelEventHandler(this.KBTreeView_BeforeExpand);
			this.NODE_TYPE = "1";
			this.m_ArrayOldTid = new ArrayList();
			this.m_ArrayNewTid = new ArrayList();
			this.m_ArrayGuid = new ArrayList();
			this.m_ArrayDesc = new ArrayList();
			this._CtLocID = string.Empty;
			this._UserID = string.Empty;
			this._UserName = string.Empty;
			this._KBDiagnosID = string.Empty;
			this.CanDeleteNode = string.Empty;
			this.dsKBNode = new EKBNodeSelectByNameDataset();
			this.FindText = string.Empty;
			this.InitializeComponent();
			this.Init();
			KBTree.ConstKBTree = this;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KBTree));
			this.cmKBTree = new ContextMenu();
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
			this.SelectedImageIndex = 0;
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.miAddFolder = new MenuItem("新增目录");
			this.miAddKBNode = new MenuItem("新增节点");
			this.miCopy = new MenuItem("复制节点");
			this.miPaste = new MenuItem("粘贴节点");
			this.miAddContent = new MenuItem("添加内容");
			this.miReplaceContent = new MenuItem("替换内容");
			this.miExport = new MenuItem("导出节点");
			this.miImport = new MenuItem("导入节点");
			this.miEdit = new MenuItem("编辑知识库");
			this.miNodeUp = new MenuItem("节点上移");
			this.miNodeDown = new MenuItem("节点下移");
			this.miAddPersonalFolder = new MenuItem("新增个人模板");
			this.miCategoryEdit = new MenuItem("修改节点");
			this.miConvertToCommon = new MenuItem("转换为通用模板");
			this.miDelete = new MenuItem("删除节点");
			this._CtLocID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("CTLocID") == null, string.Empty, GlobalValues.GetValueByKey("CTLocID")));
			this._UserID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserID") == null, string.Empty, GlobalValues.GetValueByKey("UserID")));
			this._UserName = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserName") == null, string.Empty, GlobalValues.GetValueByKey("UserName")));
			this.CanDeleteNode = SysOptionManager.GetSysOptionValue("CanDeleteKBTreeOrKBNode", "Y");
		}

		private void InitTreeViewNodes(string AKnowledgeBase, string ALocID)
		{
			try
			{
				EKBTreeAllDataset eKBTreeAllDataset = WebServiceLayer.KBTreeAccess.SelectALLKBTree(AKnowledgeBase);
				if (eKBTreeAllDataset != null & eKBTreeAllDataset.SELECTALL != null)
				{
					this.initCategoryNodes(eKBTreeAllDataset.SELECTALL, this.Nodes[0], "0", ALocID);
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

		private void initCategoryNodes(EKBTreeAllDataset.SELECTALLDataTable dt, TreeNode parentNode, string parentId, string locId)
		{
			string filterExpression = Conversions.ToString(this.GetFilter(dt, parentId, locId, this._UserID));
			DataRow[] array = dt.Select(filterExpression, "Sequence asc");
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					string text = dataRow[dt.IDColumn.ColumnName].ToString();
					string text2 = dataRow[dt.DescriptionColumn.ColumnName].ToString();
					TreeNode treeNode = new TreeNode(dataRow[dt.NameColumn.ColumnName].ToString(), 0, 0);
					if (Conversions.ToBoolean(this.IsPersonalTreeNode(dataRow["PersonalKBUserID"].ToString())))
					{
						treeNode.Tag = "PC" + text;
					}
					else
					{
						treeNode.Tag = "CG" + text;
					}
					parentNode.Nodes.Add(treeNode);
					this.initCategoryNodes(dt, treeNode, text, locId);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ResChildCountColumn.ColumnName]));
					int arg_114_0 = 0;
					int num2 = num - 1;
					for (int j = arg_114_0; j <= num2; j++)
					{
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "LF";
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
		}

		private object GetFilter(EKBTreeAllDataset.SELECTALLDataTable dt, string parentNodeID, string ctLocID, string userID)
		{
			string text = dt.ParentIDColumn.ColumnName + "='" + parentNodeID + "'";
			bool flag = Operators.CompareString(parentNodeID, "0", false) == 0 && this.IsRealClientMode(this._ClientMode, ctLocID) && Operators.CompareString(SysOptionManager.GetSysOptionValue("EnableKBTreeLocConfig", "N"), "Y", false) == 0;
			if (flag)
			{
				string str = Conversions.ToString(this.GetCTLocKBFilter(dt.IDColumn.ColumnName, ctLocID));
				text = text + " and " + str;
			}
			bool flag2 = this.IsRealClientMode(this._ClientMode, userID);
			if (flag2)
			{
				string str2 = Conversions.ToString(this.GetPersonalKBFilter(dt.PersonalKBUserIDColumn.ColumnName, userID));
				text = text + " and " + str2;
			}
			return text;
		}

		private object GetCTLocKBFilter(string columnName, string ctLocID)
		{
			string kBTreeByLoc = WebServiceLayer.KbConfigAccess.GetKBTreeByLoc(ctLocID);
			return columnName + " in " + kBTreeByLoc;
		}

		private object GetPersonalKBFilter(string columnName, string userID)
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

		private string IsPersonalTreeNode(string kbTreeUserID)
		{
			if (kbTreeUserID.Equals(string.Empty))
			{
				return Conversions.ToString(false);
			}
			return Conversions.ToString(true);
		}

		private void KBTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.LastNode.Text == null | Operators.CompareString(e.Node.LastNode.Text, string.Empty, false) == 0)
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
						EKBNodeInUseDataset eKBNodeInUseDataset = WebServiceLayer.KBNodeAccess.SelectKBNodeInUseByID(nodeId);
						if (this.ClientMode)
						{
							string nodeId2 = string.Empty;
							string sysOptionValue = SysOptionManager.GetSysOptionValue("KBDiagnosFilter", "N");
							if (Operators.CompareString(sysOptionValue, "Y", false) == 0 && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(this.KBDiagnosID, string.Empty, false), Operators.CompareObjectNotEqual(this.KBDiagnosID, "0", false))))
							{
								string valueByKey = GlobalValues.GetValueByKey("EpisodeID");
								nodeId2 = this.FindDiagnosConfig(nodeId, Conversions.ToString(this.KBDiagnosID), valueByKey);
								eKBNodeInUseDataset = this.DataTableFilter(eKBNodeInUseDataset, nodeId2);
							}
						}
						string columnName = eKBNodeInUseDataset.SELECTInUseBYPARENTID.IDColumn.ColumnName;
						string columnName2 = eKBNodeInUseDataset.SELECTInUseBYPARENTID.NameColumn.ColumnName;
						string columnName3 = eKBNodeInUseDataset.SELECTInUseBYPARENTID.DescriptionColumn.ColumnName;
						string columnName4 = eKBNodeInUseDataset.SELECTInUseBYPARENTID.IsCommonColumn.ColumnName;
						int num = eKBNodeInUseDataset.SELECTInUseBYPARENTID.Rows.Count - 1;
						string left = string.Empty;
						for (int i = parentNode.Nodes.Count - 1; i >= 0; i += -1)
						{
							left = this.GetNodeType(parentNode.Nodes[i]);
							if (Operators.CompareString(left, "CG", false) != 0 && Operators.CompareString(left, "PC", false) != 0)
							{
								if (num >= 0)
								{
									parentNode.Nodes[i].Tag = "LF" + eKBNodeInUseDataset.SELECTInUseBYPARENTID.Rows[num][columnName].ToString();
									parentNode.Nodes[i].Text = eKBNodeInUseDataset.SELECTInUseBYPARENTID.Rows[num][columnName2].ToString();
									parentNode.Nodes[i].ToolTipText = eKBNodeInUseDataset.SELECTInUseBYPARENTID.Rows[num][columnName3].ToString();
									num--;
								}
								else
								{
									parentNode.Nodes.Remove(parentNode.Nodes[i]);
								}
							}
						}
						result = true;
					}
					catch (AppException expr_238)
					{
						ProjectData.SetProjectError(expr_238);
						AppException ex = expr_238;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private EKBNodeInUseDataset DataTableFilter(EKBNodeInUseDataset dsNode, string NodeId)
		{
			EKBNodeInUseDataset eKBNodeInUseDataset = (EKBNodeInUseDataset)dsNode.Clone();
			string[] array = NodeId.Split(new char[]
			{
				','
			});
			checked
			{
				try
				{
					IEnumerator enumerator = dsNode.SELECTInUseBYPARENTID.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string right = array2[i];
							if (Operators.CompareString(dataRow["ID"].ToString(), right, false) == 0)
							{
								eKBNodeInUseDataset.SELECTInUseBYPARENTID.ImportRow(dataRow);
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
				return eKBNodeInUseDataset;
			}
		}

		private string FindDiagnosConfig(string treeId, string diagnosID, string episodeID)
		{
			string text = string.Empty;
			checked
			{
				if (Operators.CompareString(treeId, "0", false) != 0)
				{
					EKBDiagnosConfigDataSet dataByTreeID = WebServiceLayer.KBDiagnosConfigAccess.GetDataByTreeID(treeId, diagnosID, episodeID);
					int arg_3E_0 = 0;
					int num = dataByTreeID.Tables[0].Rows.Count - 1;
					for (int i = arg_3E_0; i <= num; i++)
					{
						text = text + dataByTreeID.Tables[0].Rows[i]["KBNodeID"].ToString() + ",";
					}
					text = text.TrimEnd(new char[]
					{
						','
					});
				}
				return text;
			}
		}

		public string GetNodeId(TreeNode node)
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

		private string ReplaceXmlStrKbNodeId(string AReplaceStr, string StrFlag, string ANodeId)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(AReplaceStr);
			if (Operators.CompareString(StrFlag, "InstanceData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//NISegment/KBNodeID");
				xmlNode.InnerText = ANodeId;
			}
			else if (Operators.CompareString(StrFlag, "MetaData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//MISegment/KBNodeID");
				xmlNode.InnerText = ANodeId;
			}
			return xmlDocument.OuterXml;
		}

		private void KBTree_MouseDown(object sender, MouseEventArgs e)
		{
			TreeNode nodeAt = this.GetNodeAt(e.X, e.Y);
			this.SetCurrentNodeInfo(nodeAt);
			if (nodeAt != null && e.Button == MouseButtons.Right)
			{
				this.cmKBTree.MenuItems.Clear();
				this.SetKBTreeMenu(this.GetNodeType(nodeAt));
				ContextMenu arg_62_0 = this.cmKBTree;
				Point pos = new Point(e.X, e.Y);
				arg_62_0.Show(this, pos);
			}
		}

		private void miExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "xml 文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.AddExtension = true;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(saveFileDialog.FileName))
				{
					if (MessageManager.ShowQuestionMessage("文件已存在，是否覆盖？") == DialogResult.Yes)
					{
						this.ExportKB(saveFileDialog.FileName);
					}
				}
				else
				{
					this.ExportKB(saveFileDialog.FileName);
				}
			}
		}

		private void miImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "xml 文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.ImportKBFile(openFileDialog.FileName);
			}
		}

		private void miAddFolder_Click(object sender, EventArgs e)
		{
			try
			{
				EKBTree eKBTree = this.CreateKBTree(this._UserID, this._UserName);
				TreeNode treeNode = new TreeNode(eKBTree.Name, 0, 1);
				treeNode.Tag = this.CreateKBTreeTag(eKBTree.ID);
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

		private void miAddKBNode_Click(object sender, EventArgs e)
		{
			try
			{
				EKBNode eKBNode = new EKBNode();
				eKBNode.Name = "新增节点";
				eKBNode.KnowledgeBaseID = this._EKnowledgeBase.ID;
				eKBNode.KBTreeID = this.GetNodeId(this.CurrentNode);
				eKBNode.IsCommon = "Y";
				string text = WebServiceLayer.KBNodeAccess.CreateKBNode(eKBNode);
				eKBNode.ID = text;
				TreeNode treeNode = new TreeNode(eKBNode.Name, 2, 2);
				treeNode.Tag = "LF" + text;
				this.SelectedNode.Nodes.Add(treeNode);
				this.SelectedNode.Expand();
			}
			catch (Exception expr_90)
			{
				ProjectData.SetProjectError(expr_90);
				Exception ex = expr_90;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void miCopy_Click(object sender, EventArgs e)
		{
			try
			{
				KBTree.CopyKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(this.GetNodeId(this.SelectedNode));
			}
			catch (Exception expr_1D)
			{
				ProjectData.SetProjectError(expr_1D);
				Exception ex = expr_1D;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void miPaste_Click(object sender, EventArgs e)
		{
			try
			{
				KBTree.CopyKBNode.KBTreeID = this.GetNodeId(this.CurrentNode);
				KBTree.CopyKBNode.ID = WebServiceLayer.KBNodeAccess.CreateKBNode(KBTree.CopyKBNode);
				KBTree.CopyKBNode.Name = "新增节点";
				if (Operators.CompareString(KBTree.CopyKBNode.S1InstanceData, "", false) != 0)
				{
					KBTree.CopyKBNode.S1InstanceData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S1InstanceData, "InstanceData", KBTree.CopyKBNode.ID);
				}
				if (Operators.CompareString(KBTree.CopyKBNode.S2InstanceData, "", false) != 0)
				{
					KBTree.CopyKBNode.S2InstanceData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S2InstanceData, "InstanceData", KBTree.CopyKBNode.ID);
				}
				if (Operators.CompareString(KBTree.CopyKBNode.S3InstanceData, "", false) != 0)
				{
					KBTree.CopyKBNode.S3InstanceData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S3InstanceData, "InstanceData", KBTree.CopyKBNode.ID);
				}
				if (Operators.CompareString(KBTree.CopyKBNode.S1MetaData, "", false) != 0)
				{
					KBTree.CopyKBNode.S1MetaData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S1MetaData, "MetaData", KBTree.CopyKBNode.ID);
				}
				if (Operators.CompareString(KBTree.CopyKBNode.S2MetaData, "", false) != 0)
				{
					KBTree.CopyKBNode.S2MetaData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S2MetaData, "MetaData", KBTree.CopyKBNode.ID);
				}
				if (Operators.CompareString(KBTree.CopyKBNode.S3MetaData, "", false) != 0)
				{
					KBTree.CopyKBNode.S3MetaData = this.ReplaceXmlStrKbNodeId(KBTree.CopyKBNode.S3MetaData, "MetaData", KBTree.CopyKBNode.ID);
				}
				try
				{
					KBNodeInfo arg_1D5_0 = WebServiceLayer.KBNodeAccess;
					EKBNode arg_1D5_1 = KBTree.CopyKBNode;
					bool flag = true;
					bool flag2;
					arg_1D5_0.UpdateKBNode(arg_1D5_1, ref flag2, ref flag);
				}
				catch (Exception expr_1DC)
				{
					ProjectData.SetProjectError(expr_1DC);
					Exception ex = expr_1DC;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
				TreeNode treeNode = new TreeNode(KBTree.CopyKBNode.Name, 2, 2);
				treeNode.Tag = "LF" + KBTree.CopyKBNode.ID;
				this.SelectedNode.Nodes.Add(treeNode);
				this.SelectedNode.Expand();
			}
			catch (Exception expr_24B)
			{
				ProjectData.SetProjectError(expr_24B);
				Exception ex2 = expr_24B;
				MessageManager.ShowErrorMessage(ex2.Message + ex2.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void KBTree_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button == MouseButtons.Left & this._Editable)
			{
				this._DragTreeNode = (TreeNode)e.Item;
				this._DragTreeNode.Collapse();
				this.AllowDrop = true;
				this.DoDragDrop(this._DragTreeNode, DragDropEffects.Move);
			}
		}

		private void KBTree_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.None)
			{
				this._DragTreeNode = null;
				this.Cursor = Cursors.Default;
				return;
			}
			Point point;
			point.X = e.X;
			point.Y = e.Y;
			point = this.PointToClient(point);
			TreeNode nodeAt = this.GetNodeAt(point);
			if (nodeAt == null)
			{
				return;
			}
			if (nodeAt == this.SelectedNode)
			{
				return;
			}
			string nodeType = this.GetNodeType(this._DragTreeNode);
			if (Operators.CompareString(nodeType, "LF", false) == 0)
			{
				try
				{
					string nodeId = this.GetNodeId(this._DragTreeNode);
					EKBNode eKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(nodeId);
					string nodeId2 = this.GetNodeId(nodeAt);
					eKBNode.KBTreeID = nodeId2;
					KBNodeInfo arg_AD_0 = WebServiceLayer.KBNodeAccess;
					EKBNode arg_AD_1 = eKBNode;
					bool flag = true;
					bool flag2;
					arg_AD_0.UpdateKBNode(arg_AD_1, ref flag2, ref flag);
					if (!flag2)
					{
						MessageManager.ShowErrorMessage("更新失败！");
						return;
					}
					this._DragTreeNode.Parent.Nodes.Remove(this._DragTreeNode);
					nodeAt.Nodes.Add(this._DragTreeNode);
					return;
				}
				catch (Exception expr_F7)
				{
					ProjectData.SetProjectError(expr_F7);
					Exception ex = expr_F7;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (Operators.CompareString(nodeType, "CG", false) == 0)
			{
				try
				{
					string nodeId3 = this.GetNodeId(this._DragTreeNode);
					EKBTree eKBTree = WebServiceLayer.KBTreeAccess.SelectKBTreeBYID(nodeId3);
					string nodeId4 = this.GetNodeId(nodeAt);
					eKBTree.ParentID = nodeId4;
					KBTreeInfo arg_16F_0 = WebServiceLayer.KBTreeAccess;
					EKBTree arg_16F_1 = eKBTree;
					bool flag = true;
					bool flag3;
					arg_16F_0.UpdateKBTree(arg_16F_1, ref flag3, ref flag);
					if (!flag3)
					{
						MessageManager.ShowErrorMessage("更新失败！");
					}
					else
					{
						this._DragTreeNode.Parent.Nodes.Remove(this._DragTreeNode);
						nodeAt.Nodes.Add(this._DragTreeNode);
					}
				}
				catch (Exception expr_1B3)
				{
					ProjectData.SetProjectError(expr_1B3);
					Exception ex2 = expr_1B3;
					MessageManager.ShowErrorMessage(ex2.Message + ex2.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void KBTree_DragOver(object sender, DragEventArgs e)
		{
			Point point;
			point.X = e.X;
			point.Y = e.Y;
			point = this.PointToClient(point);
			TreeNode nodeAt = this.GetNodeAt(point);
			if (nodeAt == null)
			{
				return;
			}
			string nodeType = this.GetNodeType(nodeAt);
			string nodeType2 = this.GetNodeType(this._DragTreeNode);
			if (Operators.CompareString(nodeType2, "LF", false) == 0)
			{
				if (Operators.CompareString(nodeType, "RT", false) == 0)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (Operators.CompareString(nodeType, "LF", false) == 0)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (Operators.CompareString(nodeType, "CG", false) == 0)
				{
					if (nodeAt.Nodes.Count == 0)
					{
						e.Effect = DragDropEffects.Move;
						return;
					}
					if (Operators.CompareString(this.GetNodeType(nodeAt.Nodes[0]), "CG", false) == 0)
					{
						e.Effect = DragDropEffects.None;
						return;
					}
					if (Operators.CompareString(this.GetNodeType(nodeAt.Nodes[0]), "LF", false) == 0)
					{
						e.Effect = DragDropEffects.Move;
						return;
					}
				}
			}
			else
			{
				if (Operators.CompareString(nodeType2, "CG", false) != 0)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (Operators.CompareString(nodeType, "RT", false) == 0)
				{
					e.Effect = DragDropEffects.Move;
					return;
				}
				if (Operators.CompareString(nodeType, "LF", false) == 0)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (Operators.CompareString(nodeType, "CG", false) == 0)
				{
					if (nodeAt.Nodes.Count == 0)
					{
						e.Effect = DragDropEffects.Move;
						return;
					}
					if (Operators.CompareString(this.GetNodeType(nodeAt.Nodes[0]), "CG", false) == 0)
					{
						e.Effect = DragDropEffects.Move;
						return;
					}
					if (Operators.CompareString(this.GetNodeType(nodeAt.Nodes[0]), "LF", false) == 0)
					{
						e.Effect = DragDropEffects.None;
						return;
					}
				}
			}
		}

		private void miNodeUp_Click(object sender, EventArgs e)
		{
			if (this.SelectedNode != null)
			{
				TreeNode treeNode = new TreeNode();
				treeNode = this.SelectedNode.PrevNode;
				string nodeId = this.GetNodeId(treeNode);
				string nodeId2 = this.GetNodeId(this.SelectedNode);
				if (treeNode != null)
				{
					this.SelectedNode.PrevNode.Remove();
					int index = checked(this.SelectedNode.Index + 1);
					if (this.SelectedNode.Parent == null)
					{
						this.Nodes.Insert(index, treeNode);
					}
					else
					{
						this.SelectedNode.Parent.Nodes.Insert(index, treeNode);
						if (Operators.CompareString(this.NODE_TYPE, "2", false) == 0)
						{
							this.SwapSequence(ref nodeId, ref nodeId2);
						}
						else if (Operators.CompareString(this.NODE_TYPE, "1", false) == 0)
						{
							this.SwapFordSequence(ref nodeId, ref nodeId2);
						}
					}
				}
			}
		}

		private void miNodeDown_Click(object sender, EventArgs e)
		{
			if (this.SelectedNode != null)
			{
				TreeNode treeNode = new TreeNode();
				treeNode = this.SelectedNode.NextNode;
				string nodeId = this.GetNodeId(treeNode);
				string nodeId2 = this.GetNodeId(this.SelectedNode);
				if (treeNode != null)
				{
					this.SelectedNode.NextNode.Remove();
					int index = this.SelectedNode.Index;
					if (this.SelectedNode.Parent == null)
					{
						this.Nodes.Insert(index, treeNode);
					}
					else
					{
						this.SelectedNode.Parent.Nodes.Insert(index, treeNode);
						if (Operators.CompareString(this.NODE_TYPE, "2", false) == 0)
						{
							this.SwapSequence(ref nodeId, ref nodeId2);
						}
						else if (Operators.CompareString(this.NODE_TYPE, "1", false) == 0)
						{
							this.SwapFordSequence(ref nodeId, ref nodeId2);
						}
					}
				}
			}
		}

		private void SwapSequence(ref string PreId, ref string SelectId)
		{
			KBNodeInfo arg_0F_0 = WebServiceLayer.KBNodeAccess;
			string arg_0F_1 = PreId;
			string arg_0F_2 = SelectId;
			bool flag = true;
			bool flag2;
			arg_0F_0.SwapSequence(arg_0F_1, arg_0F_2, ref flag2, ref flag);
		}

		private void SwapFordSequence(ref string PreId, ref string SelectId)
		{
			KBTreeInfo arg_0F_0 = WebServiceLayer.KBTreeAccess;
			string arg_0F_1 = PreId;
			string arg_0F_2 = SelectId;
			bool flag = true;
			bool flag2;
			arg_0F_0.SwapSequence(arg_0F_1, arg_0F_2, ref flag2, ref flag);
		}

		private void miAddPersonalFolder_Click(object sender, EventArgs e)
		{
			this.miAddFolder_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void miConvertToCommon_Click(object sender, EventArgs e)
		{
			EKBTree eKBTree = new EKBTree();
			eKBTree = this.SelectEKBTree(this.GetNodeId(this.SelectedNode));
			bool flag = this.UpdatePersonalToEmpty(eKBTree);
			this.UpdateAll(eKBTree.ID);
			this.EKnowledgeBase = WebServiceLayer.KnowledgeBaseAccess.SelectKnowledgeBaseByID(eKBTree.KnowledgeBaseID);
		}

		private void miDelete_Click(object sender, EventArgs e)
		{
			string nodeId = this.GetNodeId(this.SelectedNode);
			string text = this.GetNodeType(this.SelectedNode);
			if (Operators.CompareString(text, "LF", false) == 0)
			{
				MessageBox.Show("不允许删除节点");
				return;
			}
			text = "0";
			string left = WebServiceLayer.KBTreeAccess.DeleteTreeNode(nodeId, text);
			if (Operators.CompareString(left, "2", false) == 0)
			{
				MessageManager.ShowInformationMessage("此节点为非空目录，不能直接删除");
			}
			else if (Operators.CompareString(left, "1", false) == 0)
			{
				MessageManager.ShowInformationMessage("删除成功");
				this.Nodes.Remove(this.SelectedNode);
			}
			else
			{
				MessageManager.ShowInformationMessage("删除失败");
			}
		}

		private void miCategoryEdit_Click(object sender, EventArgs e)
		{
			new ClientTreeCategoryEdit
			{
				KBTreeID = this.GetNodeId(this.SelectedNode)
			}.ShowDialog();
		}

		private void miEdit_Click(object sender, EventArgs e)
		{
			new ClientKBEditForm
			{
				DCKBNode = 
				{
					EKnowledgeBase = this.EKnowledgeBase,
					IsPersonlKBNode = true,
					CTLogID = this._CtLocID,
					ClientMode = true,
					KBNodeID = this.GetNodeId(this.SelectedNode)
				}
			}.ShowDialog();
		}

		public void UpdateNodeName(string NewName)
		{
			this.SelectedNode.Text = NewName;
		}

		private void SetCurrentNodeInfo(TreeNode curTreeNode)
		{
			this.SelectedNode = curTreeNode;
			this.CurrentNode = curTreeNode;
			this.CurrentNodeType = this.GetNodeType(curTreeNode);
		}

		private void ExportKB(string filename)
		{
			XmlDocument xmlDocument = this.ExportByNode(this.CurrentNode);
			string text = "";
			string innerText = "";
			this.GetBindTids(xmlDocument, ref text, ref innerText);
			string bindGuidsByTids = this.GetBindGuidsByTids(text);
			XmlDocument xmlDocument2 = new XmlDocument();
			xmlDocument2.LoadXml("<KBData></KBData>");
			XmlElement xmlElement = xmlDocument2.CreateElement("KBTrees");
			xmlElement.InnerXml = xmlDocument.OuterXml;
			xmlDocument2.DocumentElement.AppendChild(xmlElement);
			xmlElement = xmlDocument2.CreateElement("BindTemplateIds");
			xmlElement.InnerText = text;
			xmlDocument2.DocumentElement.AppendChild(xmlElement);
			xmlElement = xmlDocument2.CreateElement("BindTemplateGuids");
			xmlElement.InnerText = bindGuidsByTids;
			xmlDocument2.DocumentElement.AppendChild(xmlElement);
			xmlElement = xmlDocument2.CreateElement("BindTemplateDescs");
			xmlElement.InnerText = innerText;
			xmlDocument2.DocumentElement.AppendChild(xmlElement);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(filename, Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlDocument2.Save(xmlTextWriter);
			xmlTextWriter.Flush();
			xmlTextWriter.Close();
			MessageManager.ShowInformationMessage("导出成功！");
		}

		private XmlDocument ExportByNode(TreeNode node)
		{
			XmlDocument xmlDocument = new XmlDocument();
			if (Operators.CompareString(this.GetNodeType(node), "RT", false) == 0 || Operators.CompareString(this.GetNodeType(node), "CG", false) == 0)
			{
				xmlDocument.LoadXml("<KBTree></KBTree>");
				XmlElement xmlElement = xmlDocument.CreateElement("Name");
				xmlElement.InnerText = node.Text;
				xmlDocument.DocumentElement.AppendChild(xmlElement);
				xmlElement = xmlDocument.CreateElement("Desc");
				xmlElement.InnerText = "";
				xmlDocument.DocumentElement.AppendChild(xmlElement);
				xmlElement = xmlDocument.CreateElement("SubNodes");
				xmlElement.InnerText = "";
				xmlDocument.DocumentElement.AppendChild(xmlElement);
				XmlNode xmlNode = xmlDocument.SelectSingleNode("/KBTree/SubNodes");
				if (!node.IsExpanded)
				{
					node.Expand();
				}
				try
				{
					IEnumerator enumerator = node.Nodes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						TreeNode node2 = (TreeNode)enumerator.Current;
						XmlDocumentFragment xmlDocumentFragment = xmlDocument.CreateDocumentFragment();
						xmlDocumentFragment.InnerXml = this.ExportByNode(node2).OuterXml;
						xmlNode.AppendChild(xmlDocumentFragment);
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
				return xmlDocument;
			}
			if (Operators.CompareString(this.GetNodeType(node), "LF", false) == 0)
			{
				try
				{
					EKBNode eKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(this.GetNodeId(node));
					if (eKBNode != null)
					{
						xmlDocument.LoadXml("<KBNode></KBNode>");
						XmlElement xmlElement2 = xmlDocument.CreateElement("Name");
						xmlElement2.InnerText = eKBNode.Name;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("IsCommon");
						xmlElement2.InnerXml = eKBNode.IsCommon;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S1MetaData");
						xmlElement2.InnerXml = eKBNode.S1MetaData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S1InstanceData");
						xmlElement2.InnerXml = eKBNode.S1InstanceData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S2MetaData");
						xmlElement2.InnerXml = eKBNode.S2MetaData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S2InstanceData");
						xmlElement2.InnerXml = eKBNode.S2InstanceData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S3MetaData");
						xmlElement2.InnerXml = eKBNode.S3MetaData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
						xmlElement2 = xmlDocument.CreateElement("S3InstanceData");
						xmlElement2.InnerXml = eKBNode.S3InstanceData;
						xmlDocument.DocumentElement.AppendChild(xmlElement2);
					}
				}
				catch (Exception arg_2B1_0)
				{
					ProjectData.SetProjectError(arg_2B1_0);
					ProjectData.ClearProjectError();
				}
				return xmlDocument;
			}
			return xmlDocument;
		}

		private void ImportKBFile(string fileName)
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(fileName);
				if (!this.IsImportDataValid(xmlDocument))
				{
					MessageManager.ShowErrorMessage("导入文件格式错误！该导入文件可能是由低版本维护程序生成的！");
				}
				else
				{
					string value = "";
					if (!this.IsBindTidsValid(xmlDocument, ref value))
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("下列界面模板不存在：\n---------------------");
						stringBuilder.Append(value);
						stringBuilder.Append("\n---------------------\n导入会造成数据绑定失效！");
						stringBuilder.Append("\n是否继续导入？");
						if (MessageManager.ShowQuestionMessage(stringBuilder.ToString()) == DialogResult.No)
						{
							return;
						}
					}
					this.RefreshBindTids(ref xmlDocument);
					string innerXml = xmlDocument.SelectSingleNode("/KBData/KBTrees").InnerXml;
					this.ImportKB(innerXml);
				}
			}
			catch (Exception expr_9A)
			{
				ProjectData.SetProjectError(expr_9A);
				Exception ex = expr_9A;
				MessageManager.ShowErrorMessage("导入知识库错误！\n" + ex.Message + "\n" + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private bool IsImportDataValid(XmlDocument doc)
		{
			return doc.SelectSingleNode("/KBData/BindTemplateIds") != null && doc.SelectSingleNode("/KBData/BindTemplateGuids") != null && doc.SelectSingleNode("/KBData/BindTemplateDescs") != null;
		}

		private bool IsBindTidsValid(XmlDocument doc, ref string errorMessage)
		{
			bool result = true;
			errorMessage = "";
			XmlNode xmlNode = doc.SelectSingleNode("/KBData/BindTemplateIds");
			if (Operators.CompareString(xmlNode.InnerText, "", false) == 0)
			{
				return true;
			}
			this.m_ArrayOldTid = new ArrayList(xmlNode.InnerText.Split(new char[]
			{
				','
			}));
			xmlNode = doc.SelectSingleNode("/KBData/BindTemplateGuids");
			this.m_ArrayGuid = new ArrayList(xmlNode.InnerText.Split(new char[]
			{
				','
			}));
			string bindTidsByGuids = this.GetBindTidsByGuids(xmlNode.InnerText);
			this.m_ArrayNewTid = new ArrayList(bindTidsByGuids.Split(new char[]
			{
				','
			}));
			xmlNode = doc.SelectSingleNode("/KBData/BindTemplateDescs");
			this.m_ArrayDesc = new ArrayList(xmlNode.InnerText.Split(new char[]
			{
				','
			}));
			if (this.m_ArrayOldTid.Count != this.m_ArrayNewTid.Count)
			{
				throw new AppException("获取绑定界面模板的新编码错误。");
			}
			int arg_116_0 = 0;
			checked
			{
				int num = this.m_ArrayNewTid.Count - 1;
				for (int i = arg_116_0; i <= num; i++)
				{
					string text = Conversions.ToString(this.m_ArrayNewTid[i]);
					if (Operators.CompareString(text, "", false) == 0 || Operators.CompareString(text.ToUpper(), "*NULL", false) == 0)
					{
						result = false;
						errorMessage = Conversions.ToString(Operators.AddObject(errorMessage, Operators.AddObject(Operators.AddObject(Operators.AddObject("\n界面模板：", this.m_ArrayDesc[i]), ", GUID："), this.m_ArrayGuid[i])));
					}
				}
				return result;
			}
		}

		private void RefreshBindTids(ref XmlDocument doc)
		{
			if (this.m_ArrayOldTid.Count == 0)
			{
				return;
			}
			XmlNodeList xmlNodeList = doc.SelectNodes("//SubItems/*/EPRBindCode");
			int arg_27_0 = 0;
			checked
			{
				int num = xmlNodeList.Count - 1;
				for (int i = arg_27_0; i <= num; i++)
				{
					string text = xmlNodeList[i].InnerText;
					string tidFromEPRBindCode = this.GetTidFromEPRBindCode(text);
					if (Operators.CompareString(tidFromEPRBindCode, "", false) != 0)
					{
						string newTidByOldTid = this.GetNewTidByOldTid(tidFromEPRBindCode);
						text = text.Replace("#TID:" + tidFromEPRBindCode, "#TID:" + newTidByOldTid);
						xmlNodeList[i].InnerText = text;
					}
				}
			}
		}

		private void ImportKB(string kbTreeData)
		{
			try
			{
				XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(kbTreeData));
				xmlTextReader.Read();
				if (Operators.CompareString(xmlTextReader.Name, "KBNode", false) == 0)
				{
					bool flag = false;
					if (Operators.CompareString(this.GetNodeType(this.CurrentNode), "CG", false) == 0)
					{
						if (this.CurrentNode.GetNodeCount(false) > 0)
						{
							if (Operators.CompareString(this.GetNodeType(this.CurrentNode.Nodes[0]), "LF", false) == 0)
							{
								flag = true;
							}
						}
						else
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.AddKBNode(this.CurrentNode, xmlTextReader);
					}
					else
					{
						MessageManager.ShowWarningMessage("当前节点不能导入知识库节点！");
					}
					xmlTextReader.Close();
					MessageManager.ShowInformationMessage("导入成功！");
				}
				else if (Operators.CompareString(xmlTextReader.Name, "KBTree", false) == 0)
				{
					TreeNode currentNode = this.CurrentNode;
					bool flag2 = false;
					DialogResult dialogResult = MessageManager.ShowQuestionMessage("导入树作为子节点导入？");
					if (dialogResult == DialogResult.Yes)
					{
						if (Operators.CompareString(this.GetNodeType(currentNode), "RT", false) == 0)
						{
							this.AddKBTree(currentNode, xmlTextReader);
						}
						else if (Operators.CompareString(this.GetNodeType(this.CurrentNode), "CG", false) == 0)
						{
							if (this.CurrentNode.GetNodeCount(false) > 0)
							{
								if (Operators.CompareString(this.GetNodeType(currentNode.Nodes[0]), "CG", false) == 0)
								{
									flag2 = true;
								}
							}
							else
							{
								flag2 = true;
							}
							if (flag2)
							{
								this.AddKBTree(currentNode, xmlTextReader);
							}
							else
							{
								MessageManager.ShowWarningMessage("当前节点不能导入知识库树！");
							}
						}
					}
					else if (dialogResult == DialogResult.No)
					{
						bool flag3;
						while (xmlTextReader.Read())
						{
							if (Operators.CompareString(xmlTextReader.Name, "SubNodes", false) == 0)
							{
								if (!xmlTextReader.IsEmptyElement)
								{
									xmlTextReader.Read();
									flag3 = (Operators.CompareString(xmlTextReader.Name, "KBTree", false) == 0);
									break;
								}
								MessageManager.ShowWarningMessage("xml 文件中没有可导入的节点！");
								return;
							}
						}
						if (flag3)
						{
							if (Operators.CompareString(this.GetNodeType(this.CurrentNode), "RT", false) == 0)
							{
								flag2 = true;
							}
							else if (Operators.CompareString(this.GetNodeType(this.CurrentNode), "CG", false) == 0)
							{
								if (this.CurrentNode.GetNodeCount(false) > 0)
								{
									if (Operators.CompareString(this.GetNodeType(this.CurrentNode.Nodes[0]), "CG", false) == 0)
									{
										flag2 = true;
									}
								}
								else
								{
									flag2 = true;
								}
							}
							if (flag2)
							{
								this.AddKBTree(this.CurrentNode, xmlTextReader);
								while (xmlTextReader.Read())
								{
									if (Operators.CompareString(xmlTextReader.Name, "KBTree", false) == 0 & xmlTextReader.IsStartElement())
									{
										this.AddKBTree(this.CurrentNode, xmlTextReader);
									}
									else if (Operators.CompareString(xmlTextReader.Name, "SubNodes", false) == 0 & xmlTextReader.NodeType == XmlNodeType.EndElement)
									{
										break;
									}
								}
							}
							else
							{
								MessageManager.ShowWarningMessage("当前节点不能导入知识库树！");
							}
						}
						else
						{
							if (Operators.CompareString(this.GetNodeType(this.CurrentNode), "CG", false) == 0)
							{
								if (this.CurrentNode.GetNodeCount(false) > 0)
								{
									if (Operators.CompareString(this.GetNodeType(this.CurrentNode.Nodes[0]), "LF", false) == 0)
									{
										flag2 = true;
									}
								}
								else
								{
									flag2 = true;
								}
							}
							if (flag2)
							{
								this.AddKBNode(this.CurrentNode, xmlTextReader);
								while (xmlTextReader.Read())
								{
									if (Operators.CompareString(xmlTextReader.Name, "KBNode", false) == 0 & xmlTextReader.IsStartElement())
									{
										this.AddKBTree(this.CurrentNode, xmlTextReader);
									}
									else if (Operators.CompareString(xmlTextReader.Name, "SubNodes", false) == 0 & xmlTextReader.NodeType == XmlNodeType.EndElement)
									{
										break;
									}
								}
							}
							else
							{
								MessageManager.ShowWarningMessage("当前节点不能导入知识库树！");
							}
						}
					}
					xmlTextReader.Close();
					MessageManager.ShowInformationMessage("导入成功！");
				}
				else
				{
					MessageManager.ShowWarningMessage("无效的 xml 文件！");
				}
			}
			catch (Exception expr_3BD)
			{
				ProjectData.SetProjectError(expr_3BD);
				Exception ex = expr_3BD;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void AddKBNode(TreeNode node, XmlReader reader)
		{
			try
			{
				EKBNode eKBNode = new EKBNode();
				eKBNode.KnowledgeBaseID = this._EKnowledgeBase.ID;
				eKBNode.KBTreeID = this.GetNodeId(node);
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					reader.Read();
					eKBNode.Name = reader.Value;
					reader.Read();
				}
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					reader.Read();
					eKBNode.IsCommon = reader.Value;
					reader.Read();
				}
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					eKBNode.S1MetaData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				if (!reader.IsEmptyElement)
				{
					eKBNode.S1InstanceData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				if (!reader.IsEmptyElement)
				{
					eKBNode.S2MetaData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				if (!reader.IsEmptyElement)
				{
					eKBNode.S2InstanceData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				if (!reader.IsEmptyElement)
				{
					eKBNode.S3MetaData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				if (!reader.IsEmptyElement)
				{
					eKBNode.S3InstanceData = reader.ReadInnerXml();
				}
				else
				{
					reader.Read();
				}
				string text = WebServiceLayer.KBNodeAccess.CreateKBNode(eKBNode);
				eKBNode.ID = text;
				if (Operators.CompareString(eKBNode.S1InstanceData, "", false) != 0)
				{
					eKBNode.S1InstanceData = this.ReplaceXmlStrKbNodeId(eKBNode.S1InstanceData, "InstanceData", text);
				}
				if (Operators.CompareString(eKBNode.S2InstanceData, "", false) != 0)
				{
					eKBNode.S2InstanceData = this.ReplaceXmlStrKbNodeId(eKBNode.S2InstanceData, "InstanceData", text);
				}
				if (Operators.CompareString(eKBNode.S3InstanceData, "", false) != 0)
				{
					eKBNode.S3InstanceData = this.ReplaceXmlStrKbNodeId(eKBNode.S3InstanceData, "InstanceData", text);
				}
				if (Operators.CompareString(eKBNode.S1MetaData, "", false) != 0)
				{
					eKBNode.S1MetaData = this.ReplaceXmlStrKbNodeId(eKBNode.S1MetaData, "MetaData", text);
				}
				if (Operators.CompareString(eKBNode.S2MetaData, "", false) != 0)
				{
					eKBNode.S2MetaData = this.ReplaceXmlStrKbNodeId(eKBNode.S2MetaData, "MetaData", text);
				}
				if (Operators.CompareString(eKBNode.S3MetaData, "", false) != 0)
				{
					eKBNode.S3MetaData = this.ReplaceXmlStrKbNodeId(eKBNode.S3MetaData, "MetaData", text);
				}
				try
				{
					KBNodeInfo arg_253_0 = WebServiceLayer.KBNodeAccess;
					EKBNode arg_253_1 = eKBNode;
					bool flag = true;
					bool flag2;
					arg_253_0.UpdateKBNode(arg_253_1, ref flag2, ref flag);
				}
				catch (Exception expr_25A)
				{
					ProjectData.SetProjectError(expr_25A);
					Exception ex = expr_25A;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
				TreeNode treeNode = new TreeNode(eKBNode.Name, 2, 2);
				treeNode.Tag = "LF" + text;
				node.Nodes.Add(treeNode);
			}
			catch (Exception expr_2AF)
			{
				ProjectData.SetProjectError(expr_2AF);
				Exception ex2 = expr_2AF;
				MessageManager.ShowErrorMessage(ex2.Message + ex2.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void AddKBTree(TreeNode node, XmlReader reader)
		{
			try
			{
				EKBTree eKBTree = new EKBTree();
				eKBTree.KnowledgeBaseID = this._EKnowledgeBase.ID;
				if (Operators.CompareString(this.GetNodeType(node), "RT", false) == 0)
				{
					eKBTree.ParentID = Conversions.ToString(0);
				}
				else
				{
					eKBTree.ParentID = this.GetNodeId(node);
				}
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					reader.Read();
					eKBTree.Name = reader.Value;
					reader.Read();
				}
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					reader.Read();
					eKBTree.Description = reader.Value;
					if (Operators.CompareString(reader.Value, "", false) != 0)
					{
						reader.Read();
					}
				}
				string iD = WebServiceLayer.KBTreeAccess.CreateKBTree(eKBTree);
				eKBTree.ID = iD;
				TreeNode treeNode = new TreeNode(eKBTree.Name, 0, 1);
				treeNode.Tag = "CG" + eKBTree.ID;
				node.Nodes.Add(treeNode);
				reader.Read();
				if (!reader.IsEmptyElement)
				{
					while (reader.Read())
					{
						if (Operators.CompareString(reader.Name, "KBTree", false) == 0 & reader.IsStartElement())
						{
							this.AddKBTree(treeNode, reader);
						}
						else if (Operators.CompareString(reader.Name, "KBNode", false) == 0 & reader.IsStartElement())
						{
							this.AddKBNode(treeNode, reader);
						}
						else if (Operators.CompareString(reader.Name, "SubNodes", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
						{
							break;
						}
					}
				}
			}
			catch (Exception expr_17D)
			{
				ProjectData.SetProjectError(expr_17D);
				Exception ex = expr_17D;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void GetBindTids(XmlDocument doc, ref string templateIds, ref string templateDescs)
		{
			templateIds = "";
			templateDescs = "";
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			XmlNodeList xmlNodeList = doc.SelectNodes("//SubItems/*/EPRBindCode");
			int arg_33_0 = 0;
			checked
			{
				int num = xmlNodeList.Count - 1;
				for (int i = arg_33_0; i <= num; i++)
				{
					XmlNode xmlNode = xmlNodeList.Item(i);
					string innerText = xmlNode.InnerText;
					string tidFromEPRBindCode = this.GetTidFromEPRBindCode(innerText);
					if (Operators.CompareString(tidFromEPRBindCode, "", false) != 0)
					{
						string value = innerText.Substring(0, innerText.IndexOf("."));
						if (!arrayList.Contains(tidFromEPRBindCode))
						{
							arrayList.Add(tidFromEPRBindCode);
							arrayList2.Add(value);
						}
					}
				}
				int arg_A8_0 = 0;
				int num2 = arrayList.Count - 1;
				for (int j = arg_A8_0; j <= num2; j++)
				{
					templateIds = Conversions.ToString(Operators.AddObject(templateIds, Operators.AddObject(arrayList[j], ",")));
					templateDescs = Conversions.ToString(Operators.AddObject(templateDescs, Operators.AddObject(arrayList2[j], ",")));
				}
				templateIds = templateIds.TrimEnd(new char[]
				{
					','
				});
				templateDescs = templateDescs.TrimEnd(new char[]
				{
					','
				});
			}
		}

		private string GetTidFromEPRBindCode(string bindCode)
		{
			string result = "";
			if (Operators.CompareString(bindCode, "", false) == 0)
			{
				return result;
			}
			int num = bindCode.IndexOf("#TID:");
			int num2 = bindCode.IndexOf("#TVER:");
			if (num > -1 && num2 > -1)
			{
				result = checked(bindCode.Substring(num + 5, num2 - num - 5));
			}
			return result;
		}

		private string GetBindGuidsByTids(string templateIds)
		{
			string result = "";
			if (Operators.CompareString(templateIds, "", false) == 0)
			{
				return result;
			}
			try
			{
				result = WebServiceLayer.InterfaceTemplateAccess.IDMap2Guid(templateIds);
			}
			catch (Exception expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				Exception ex = expr_25;
				MessageManager.ShowErrorMessage("获取绑定界面模板的唯一编码错误。" + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private string GetBindTidsByGuids(string templateGUIDs)
		{
			string result = "";
			if (Operators.CompareString(templateGUIDs, "", false) == 0)
			{
				return result;
			}
			try
			{
				result = WebServiceLayer.InterfaceTemplateAccess.GuidMap2ID(templateGUIDs);
			}
			catch (Exception expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				Exception ex = expr_25;
				MessageManager.ShowErrorMessage("获取绑定界面模板的新编码错误。" + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private string GetNewTidByOldTid(string oldTid)
		{
			int num = this.m_ArrayOldTid.IndexOf(oldTid);
			if (num == -1)
			{
				return oldTid;
			}
			return Conversions.ToString(this.m_ArrayNewTid[num]);
		}

		public void FindNode(string NodeName)
		{
			if (Operators.CompareString(NodeName.Trim(), string.Empty, false) == 0)
			{
				return;
			}
			if (Operators.CompareString(NodeName.Trim(), this.FindText, false) == 0)
			{
				if (this.dsKBNode != null)
				{
					if (this.dsKBNode.Tables[0].Rows.Count > 0)
					{
						goto IL_7F;
					}
				}
			}
			this.dsKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByName(NodeName.Trim(), this.EKnowledgeBase.ID);
			this.FindText = NodeName.Trim();
			IL_7F:
			string nodeName = string.Empty;
			string nodeID = string.Empty;
			int arg_AD_0 = 0;
			checked
			{
				int num = this.dsKBNode.Tables[0].Rows.Count - 1;
				for (int i = arg_AD_0; i <= num; i++)
				{
					nodeName = this.dsKBNode.Tables[0].Rows[0]["KBTreeID"].ToString();
					nodeID = this.dsKBNode.Tables[0].Rows[0]["ID"].ToString();
					this.dsKBNode.Tables[0].Rows.RemoveAt(0);
					TreeNode treeNode = this.FindChildNode(this.Nodes[0], nodeName);
					if (treeNode != null)
					{
						this.SelectAndExpand(treeNode, nodeID);
						return;
					}
				}
			}
		}

		private TreeNode FindChildNode(TreeNode tnParent, string NodeName)
		{
			if (tnParent == null)
			{
				return null;
			}
			if (Operators.CompareString(this.GetNodeId(tnParent), NodeName, false) == 0)
			{
				return tnParent;
			}
			TreeNode treeNode = null;
			try
			{
				IEnumerator enumerator = tnParent.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode tnParent2 = (TreeNode)enumerator.Current;
					treeNode = this.FindChildNode(tnParent2, NodeName);
					if (treeNode != null)
					{
						break;
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
			return treeNode;
		}

		private void ExpandNodes(TreeNode TempNode)
		{
			TempNode.Expand();
			if (TempNode.Parent != null)
			{
				this.ExpandNodes(TempNode.Parent);
			}
		}

		private void SelectAndExpand(TreeNode TempNode, string NodeID)
		{
			this.ExpandNodes(TempNode);
			try
			{
				IEnumerator enumerator = TempNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (Operators.CompareString(this.GetNodeId(treeNode), NodeID, false) == 0)
					{
						this.SelectedNode = treeNode;
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

		private void SetKBTreeMenu(string strNodeType)
		{
			this.NODE_TYPE = "1";
			if (this._ClientMode)
			{
				this.SetClientKBTreeMenu(strNodeType);
			}
			else
			{
				this.SetMaintainKBTreeMenu(strNodeType);
			}
		}

		private void SetMaintainKBTreeMenu(string strNodeType)
		{
			if (Operators.CompareString(strNodeType, "RT", false) == 0)
			{
				this.cmKBTree.MenuItems.Add(this.miAddFolder);
				this.cmKBTree.MenuItems.Add(this.miExport);
				this.cmKBTree.MenuItems.Add(this.miImport);
			}
			else if (Operators.CompareString(strNodeType, "CG", false) == 0)
			{
				if (this.CurrentNode.Nodes.Count == 0)
				{
					this.cmKBTree.MenuItems.Add(this.miAddFolder);
					this.cmKBTree.MenuItems.Add(this.miAddKBNode);
					if (KBTree.CopyKBNode != null)
					{
						this.cmKBTree.MenuItems.Add(this.miPaste);
					}
				}
				else if (Operators.CompareString(this.IsHaveFolder(this.CurrentNode), "CG", false) == 0)
				{
					this.cmKBTree.MenuItems.Add(this.miAddFolder);
				}
				else
				{
					this.cmKBTree.MenuItems.Add(this.miAddKBNode);
					if (KBTree.CopyKBNode != null)
					{
						this.cmKBTree.MenuItems.Add(this.miPaste);
					}
				}
				this.AddDeleteToMenu();
				this.cmKBTree.MenuItems.Add(this.miExport);
				this.cmKBTree.MenuItems.Add(this.miImport);
			}
			else if (Operators.CompareString(strNodeType, "PC", false) == 0)
			{
				if (this.CurrentNode.Level == 2)
				{
					this.cmKBTree.MenuItems.Add(this.miConvertToCommon);
				}
				this.cmKBTree.MenuItems.Add(this.miExport);
			}
			else if (Operators.CompareString(strNodeType, "LF", false) == 0 && Operators.CompareString(this.GetNodeType(this.CurrentNode.Parent), "PC", false) != 0)
			{
				this.cmKBTree.MenuItems.Add(this.miCopy);
				this.cmKBTree.MenuItems.Add(this.miExport);
				this.NODE_TYPE = "2";
			}
			this.cmKBTree.MenuItems.Add(this.miNodeUp);
			this.cmKBTree.MenuItems.Add(this.miNodeDown);
		}

		private void SetClientKBTreeMenu(string strNodeType)
		{
			if (Operators.CompareString(strNodeType, "LF", false) == 0)
			{
				this.cmKBTree.MenuItems.Add(this.miAddContent);
				this.cmKBTree.MenuItems.Add(this.miReplaceContent);
				this.NODE_TYPE = "2";
			}
			if (!this._Editable)
			{
				return;
			}
			if (Operators.CompareString(this._UserID, "", false) == 0 || Operators.CompareString(this._UserName, "", false) == 0)
			{
				return;
			}
			if (Operators.CompareString(strNodeType, "CG", false) == 0)
			{
				if (this.CurrentNode.Level == 1)
				{
					this.cmKBTree.MenuItems.Add(this.miAddPersonalFolder);
				}
			}
			else if (Operators.CompareString(strNodeType, "PC", false) == 0)
			{
				if (this.CurrentNode.Level == 2)
				{
					if (this.CurrentNode.Nodes.Count == 0)
					{
						this.cmKBTree.MenuItems.Add(this.miAddFolder);
						this.cmKBTree.MenuItems.Add(this.miAddKBNode);
					}
					else if (Operators.CompareString(this.GetNodeType(this.CurrentNode.Nodes[0]), "LF", false) == 0)
					{
						this.cmKBTree.MenuItems.Add(this.miAddKBNode);
					}
					else
					{
						this.cmKBTree.MenuItems.Add(this.miAddFolder);
					}
				}
				else if (this.CurrentNode.Level == 3)
				{
					this.cmKBTree.MenuItems.Add(this.miAddKBNode);
				}
				this.AddDeleteToMenu();
				this.cmKBTree.MenuItems.Add(this.miCategoryEdit);
				this.cmKBTree.MenuItems.Add(this.miExport);
				this.cmKBTree.MenuItems.Add(this.miImport);
			}
			else if (Operators.CompareString(strNodeType, "LF", false) == 0 && Operators.CompareString(this.GetNodeType(this.CurrentNode.Parent), "PC", false) == 0)
			{
				this.cmKBTree.MenuItems.Add(this.miEdit);
				this.cmKBTree.MenuItems.Add(this.miExport);
				this.NODE_TYPE = "2";
			}
			this.cmKBTree.MenuItems.Add(this.miNodeUp);
			this.cmKBTree.MenuItems.Add(this.miNodeDown);
		}

		public string IsHaveFolder(TreeNode PNode)
		{
			string result = string.Empty;
			try
			{
				IEnumerator enumerator = this.CurrentNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (Operators.CompareString(this.GetNodeType(this.CurrentNode.Nodes[0]), "CG", false) == 0)
					{
						result = "CG";
						break;
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
			return result;
		}

		private void AddDeleteToMenu()
		{
			if (Operators.CompareString(this.CanDeleteNode, "Y", false) == 0)
			{
				this.cmKBTree.MenuItems.Add(this.miDelete);
			}
		}

		private EKBTree CreateKBTree(string userID, string userName)
		{
			EKBTree eKBTree = new EKBTree();
			eKBTree.KnowledgeBaseID = this._EKnowledgeBase.ID;
			eKBTree.Name = this.GetKBTreeName(userName);
			eKBTree.PersonalKBUserID = this.GetKBTreeUserID(userID);
			eKBTree.ParentID = this.GetNodeId(this.CurrentNode);
			eKBTree.ID = WebServiceLayer.KBTreeAccess.CreateKBTree(eKBTree);
			return eKBTree;
		}

		private string GetKBTreeName(string userName)
		{
			if (this._ClientMode && this.CurrentNode.Level == 1)
			{
				return userName + "的个人模板";
			}
			return "新增目录";
		}

		private string GetKBTreeUserID(string userID)
		{
			if (this._ClientMode)
			{
				return userID;
			}
			return string.Empty;
		}

		private string CreateKBTreeTag(string kbTreeID)
		{
			if (this._ClientMode)
			{
				return "PC" + kbTreeID;
			}
			return "CG" + kbTreeID;
		}

		private void UpdateAll(string AID)
		{
			EKBTree eKBTree = new EKBTree();
			string text = this.SelectChilds(AID);
			checked
			{
				if (Operators.CompareString(text, string.Empty, false) != 0)
				{
					string[] array = text.Split(new char[]
					{
						'^'
					});
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						string iD = array2[i];
						eKBTree = this.SelectEKBTree(iD);
						this.UpdatePersonalToEmpty(eKBTree);
						this.UpdateAll(eKBTree.ID);
					}
				}
			}
		}

		private string SelectChilds(string PId)
		{
			string text = string.Empty;
			EKBTreeDataset eKBTreeDataset = new EKBTreeDataset();
			eKBTreeDataset = WebServiceLayer.KBTreeAccess.SelectKBTreeBYPARENTID(PId);
			checked
			{
				if (eKBTreeDataset != null & eKBTreeDataset.Tables[0].Rows.Count > 0)
				{
					int arg_56_0 = 0;
					int num = eKBTreeDataset.Tables[0].Rows.Count - 1;
					for (int i = arg_56_0; i <= num; i++)
					{
						text = text + eKBTreeDataset.Tables[0].Rows[i]["ID"].ToString() + "^";
					}
				}
				return text.TrimEnd(new char[]
				{
					'^'
				});
			}
		}

		private EKBTree SelectEKBTree(string ID)
		{
			EKBTree eKBTree = new EKBTree();
			return WebServiceLayer.KBTreeAccess.SelectKBTreeBYID(ID);
		}

		private bool UpdatePersonalToEmpty(EKBTree tempEKBTree)
		{
			tempEKBTree.PersonalKBUserID = string.Empty;
			KBTreeInfo arg_17_0 = WebServiceLayer.KBTreeAccess;
			bool flag = true;
			bool result;
			arg_17_0.UpdateKBTree(tempEKBTree, ref result, ref flag);
			return result;
		}

		private bool IsRealClientMode(bool isClientMode, string envVariable)
		{
			return isClientMode && envVariable != null && !envVariable.Equals(string.Empty);
		}
	}
}
