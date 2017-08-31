using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MetaItemTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("ItemImages")]
		private ImageList _ItemImages;

		[AccessedThroughProperty("cmMetaTree")]
		private ContextMenu _cmMetaTree;

		private MMetaItem _MetaItem;

		private NInstanceItem _InstanceItem;

		private MMetaItem _DragMetaItem;

		private TreeNode _DragTreeNode;

		private TreeNode _RootNode;

		private MenuItem miExportMetaItem;

		private bool _CreateStatus;

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

		internal virtual ContextMenu cmMetaTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmMetaTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmMetaTree = value;
			}
		}

		public MMetaItem MetaItem
		{
			get
			{
				return this._MetaItem;
			}
			set
			{
				this._MetaItem = value;
				this.Nodes.Clear();
				this.InitTree(this._MetaItem, this.Nodes);
				this._RootNode = this.Nodes[0];
				this.SelectedNode = this._RootNode;
				this._RootNode.ExpandAll();
			}
		}

		public NInstanceItem InstanceItem
		{
			get
			{
				return this._InstanceItem;
			}
			set
			{
				this._InstanceItem = value;
			}
		}

		public MMetaItem DragMetaItem
		{
			get
			{
				return this._DragMetaItem;
			}
			set
			{
				value = this._DragMetaItem;
			}
		}

		public TreeNode DragTreeNode
		{
			get
			{
				return this._DragTreeNode;
			}
			set
			{
				this._DragTreeNode = value;
			}
		}

		public bool CreateStatus
		{
			get
			{
				return this._CreateStatus;
			}
			set
			{
				this._CreateStatus = value;
			}
		}

		public MetaItemTree()
		{
			base.MouseDown += new MouseEventHandler(this.MetaItemTree_MouseDown);
			base.MouseUp += new MouseEventHandler(this.MetaItemTree_MouseUp);
			base.ItemDrag += new ItemDragEventHandler(this.MetaItemTree_ItemDrag);
			base.DragDrop += new DragEventHandler(this.MetaItemTree_DragDrop);
			base.DragEnter += new DragEventHandler(this.MetaItemTree_DragEnter);
			base.DragOver += new DragEventHandler(this.MetaItemTree_DragOver);
			base.KeyDown += new KeyEventHandler(this.MetaItemTree_KeyDown);
			base.DragLeave += new EventHandler(this.MetaItemTree_DragLeave);
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
			ResourceManager resourceManager = new ResourceManager(typeof(MetaItemTree));
			this.ItemImages = new ImageList(this.components);
			this.cmMetaTree = new ContextMenu();
			ImageList arg_49_0 = this.ItemImages;
			Size imageSize = new Size(24, 24);
			arg_49_0.ImageSize = imageSize;
			this.ItemImages.ImageStream = (ImageListStreamer)resourceManager.GetObject("ItemImages.ImageStream");
			this.ItemImages.TransparentColor = Color.Transparent;
			this.AllowDrop = true;
			this.ContextMenu = this.cmMetaTree;
			this.ImageIndex = 0;
			this.ImageList = this.ItemImages;
			this.SelectedImageIndex = 0;
			this.ShowRootLines = false;
		}

		private void Init()
		{
		}

		private string Export(int startpos, MMetaItem metaitem)
		{
			string text = Strings.Space(startpos) + metaitem.Text + "\r\n";
			if (metaitem.SubItems != null)
			{
				MMetaItemEnumerator enumerator = metaitem.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					MMetaItem metaitem2 = (MMetaItem)enumerator.Current;
					text += this.Export(checked(startpos + 2), metaitem2);
				}
			}
			return text;
		}

		public void ExportNode()
		{
			if (this.SelectedNode == null)
			{
				MessageManager.ShowWarningMessage("未选中节点！");
				return;
			}
			string dataObject = this.Export(0, (MMetaItem)this.SelectedNode.Tag);
			Clipboard.SetDataObject(dataObject);
		}

		private void InitTree(MMetaItem curMetaItem, TreeNodeCollection curNodes)
		{
			TreeNode treeNode = new TreeNode();
			treeNode.Text = curMetaItem.Text;
			treeNode.Tag = curMetaItem;
			treeNode.ImageIndex = this.GetImageIndex(curMetaItem);
			treeNode.SelectedImageIndex = this.GetImageIndex(curMetaItem);
			if (curMetaItem.Status == EPRStatus.ABandon)
			{
				treeNode.ForeColor = Color.Silver;
			}
			curNodes.Add(treeNode);
			if (curMetaItem.SubItems != null)
			{
				if (!(curMetaItem is MITextDesc))
				{
					MMetaItemEnumerator enumerator = curMetaItem.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MMetaItem curMetaItem2 = (MMetaItem)enumerator.Current;
						this.InitTree(curMetaItem2, treeNode.Nodes);
					}
				}
			}
		}

		private int GetImageIndex(MMetaItem curMetaItem)
		{
			if (curMetaItem is MMetaData)
			{
				return 0;
			}
			if (curMetaItem is MIString)
			{
				return 1;
			}
			if (curMetaItem is MINumber)
			{
				return 2;
			}
			if (curMetaItem is MIMonoChoice)
			{
				return 3;
			}
			if (curMetaItem is MIMultiChoice)
			{
				return 4;
			}
			if (curMetaItem is MIQuantity)
			{
				return 5;
			}
			if (curMetaItem is MIDateTime)
			{
				return 6;
			}
			if (curMetaItem is MIDictionary)
			{
				return 7;
			}
			if (curMetaItem is MITable)
			{
				return 8;
			}
			if (curMetaItem is MICluster)
			{
				return 9;
			}
			if (curMetaItem is MITextDesc)
			{
				return 10;
			}
			if (curMetaItem is MILink)
			{
				return 11;
			}
			if (curMetaItem is MISegment)
			{
				return 12;
			}
			if (curMetaItem is MIImageAnnotate)
			{
				return 13;
			}
			if (curMetaItem is MIPosition)
			{
				return 14;
			}
			if (curMetaItem is MIFigure)
			{
				return 15;
			}
			int result;
			return result;
		}

		public bool HasSameNameControls(ref ArrayList arrNodes)
		{
			Hashtable htNodes = new Hashtable();
			return this.CheckSameNameControls(this._RootNode, htNodes, ref arrNodes);
		}

		private bool CheckSameNameControls(TreeNode node, Hashtable htNodes, ref ArrayList arrNodes)
		{
			bool result = false;
			if (node != null && node.Tag != null)
			{
				MMetaItem mMetaItem = (MMetaItem)node.Tag;
				if (mMetaItem.Status != EPRStatus.ABandon)
				{
					if (htNodes.Contains(node.FullPath))
					{
						result = true;
						if (arrNodes.Count == 0)
						{
							arrNodes.Add(RuntimeHelpers.GetObjectValue(htNodes[node.FullPath]));
							arrNodes.Add(node);
						}
						else if (node.FullPath.Equals(((TreeNode)arrNodes[0]).FullPath))
						{
							arrNodes.Add(node);
						}
					}
					else
					{
						htNodes.Add(node.FullPath, node);
					}
					if (node.GetNodeCount(true) > 0)
					{
						try
						{
							IEnumerator enumerator = node.Nodes.GetEnumerator();
							while (enumerator.MoveNext())
							{
								TreeNode node2 = (TreeNode)enumerator.Current;
								if (this.CheckSameNameControls(node2, htNodes, ref arrNodes))
								{
									result = true;
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
				}
			}
			return result;
		}

		public void LabeledSameNameControls(ArrayList arrNodes)
		{
			this.HightlightControls(this._RootNode, arrNodes);
		}

		private void HightlightControls(TreeNode node, ArrayList arrNodes)
		{
			checked
			{
				if (node != null && node.Tag != null)
				{
					MMetaItem mMetaItem = (MMetaItem)node.Tag;
					if (mMetaItem.Status != EPRStatus.ABandon)
					{
						int arg_33_0 = 0;
						int num = arrNodes.Count - 1;
						for (int i = arg_33_0; i <= num; i++)
						{
							if (Operators.CompareString(mMetaItem.Code, ((MMetaItem)((TreeNode)arrNodes[i]).Tag).Code, false) == 0)
							{
								node.ForeColor = Color.Red;
								break;
							}
							node.ForeColor = Color.Black;
						}
						if (node.GetNodeCount(true) > 0)
						{
							try
							{
								IEnumerator enumerator = node.Nodes.GetEnumerator();
								while (enumerator.MoveNext())
								{
									TreeNode node2 = (TreeNode)enumerator.Current;
									this.HightlightControls(node2, arrNodes);
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
					}
				}
			}
		}

		private void MetaItemTree_MouseDown(object sender, MouseEventArgs e)
		{
			TreeNode nodeAt = this.GetNodeAt(e.X, e.Y);
			if (nodeAt != null)
			{
				if (e.Button == MouseButtons.Left)
				{
					this.Cursor = Cursors.Hand;
				}
				else if (e.Button == MouseButtons.Right)
				{
					this.SelectedNode = nodeAt;
				}
			}
		}

		private void MetaItemTree_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void MetaItemTree_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this._DragTreeNode = (TreeNode)e.Item;
				this._DragMetaItem = (MMetaItem)this._DragTreeNode.Tag;
				this._DragTreeNode.Collapse();
				this.AllowDrop = true;
				this.DoDragDrop(this._DragMetaItem, DragDropEffects.Move);
			}
		}

		private void MetaItemTree_DragDrop(object sender, DragEventArgs e)
		{
			TreeNode treeNode;
			if (this._DragTreeNode != null)
			{
				treeNode = this._DragTreeNode;
			}
			else
			{
				if (this._DragMetaItem == null)
				{
					this._DragMetaItem = null;
					this._DragTreeNode = null;
					this.Cursor = Cursors.Default;
					return;
				}
				this._MetaItem.InitMetaItem(this._DragMetaItem);
				treeNode = new TreeNode();
				treeNode.Text = this._DragMetaItem.Text;
				treeNode.Tag = this._DragMetaItem;
				treeNode.ImageIndex = this.GetImageIndex(this._DragMetaItem);
				treeNode.SelectedImageIndex = this.GetImageIndex(this._DragMetaItem);
			}
			if (e.Effect == DragDropEffects.None)
			{
				this._DragMetaItem = null;
				this._DragTreeNode = null;
				this.Cursor = Cursors.Default;
				return;
			}
			Point point;
			point.X = e.X;
			point.Y = e.Y;
			point = this.PointToClient(point);
			TreeNode nodeAt = this.GetNodeAt(point);
			TreeNode treeNode2;
			int num;
			if (nodeAt != null)
			{
				if (nodeAt.Tag is MMetaData)
				{
					treeNode2 = nodeAt;
					num = nodeAt.GetNodeCount(false);
				}
				else if (nodeAt.Tag is MICluster)
				{
					treeNode2 = nodeAt;
					num = nodeAt.GetNodeCount(false);
				}
				else if (nodeAt.Tag is MITable & this._DragMetaItem is MISimple)
				{
					treeNode2 = nodeAt;
					num = nodeAt.GetNodeCount(false);
				}
				else if (nodeAt.Tag is MISegment & (this._DragMetaItem is MISimple | this._DragMetaItem is MILink))
				{
					treeNode2 = nodeAt;
					num = nodeAt.GetNodeCount(false);
				}
				else if (nodeAt.Tag is MIImageAnnotate & this._DragMetaItem is MISimple)
				{
					treeNode2 = nodeAt;
					num = nodeAt.GetNodeCount(false);
				}
				else
				{
					treeNode2 = nodeAt.Parent;
					num = nodeAt.Index;
				}
			}
			else
			{
				treeNode2 = this._RootNode;
				num = this._RootNode.GetNodeCount(false);
				this._RootNode.Expand();
			}
			checked
			{
				if (e.Effect == DragDropEffects.Move)
				{
					MMetaItem mMetaItem = (MMetaItem)treeNode.Parent.Tag;
					if (this._DragMetaItem.BindInstanceItem != null && this._DragMetaItem.BindInstanceItem.Parent != null && !(mMetaItem is MISegment))
					{
						mMetaItem.BindInstanceItem.SubItems.Remove(this._DragMetaItem.BindInstanceItem);
					}
					mMetaItem.SubItems.Remove(this._DragMetaItem);
					if (treeNode.Parent == treeNode2 & num > treeNode.Index)
					{
						num--;
					}
					treeNode.Parent.Nodes.Remove(treeNode);
				}
				if (treeNode2.GetNodeCount(false) == num)
				{
					treeNode2.Nodes.Add(treeNode);
				}
				else
				{
					treeNode2.Nodes.Insert(num, treeNode);
				}
				if (!treeNode2.IsExpanded)
				{
					treeNode2.Expand();
				}
				MMetaItem mMetaItem2 = (MMetaItem)treeNode2.Tag;
				mMetaItem2.SubItems.Insert(mMetaItem2, num, this._DragMetaItem);
				if (!(mMetaItem2 is MITable))
				{
					if (!(mMetaItem2 is MISegment))
					{
						if (this._DragMetaItem.BindInstanceItem == null)
						{
							this._DragMetaItem.BindInstanceItem = this._DragMetaItem.CreateInstance();
						}
						mMetaItem2.BindInstanceItem.SubItems.Insert(mMetaItem2.BindInstanceItem, num, this._DragMetaItem.BindInstanceItem);
					}
				}
				this._DragMetaItem = null;
				this._DragTreeNode = null;
				this.CreateStatus = true;
				this.SelectedNode = treeNode;
				this.CreateStatus = false;
			}
		}

		private void MetaItemTree_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
			this._DragMetaItem = this.GetMetaData(e.Data);
			if (this._DragMetaItem != null && this._DragTreeNode != null && this._DragTreeNode.Tag != this._DragMetaItem)
			{
				this._DragTreeNode = null;
			}
		}

		public MMetaItem GetMetaData(IDataObject data)
		{
			MMetaItem result = null;
			if (data.GetData("dhcc.epr.eprlib.metadata.MIString", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIString", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MINumber", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MINumber", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIMonoChoice", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIMonoChoice", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIMultiChoice", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIMultiChoice", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIDateTime", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIDateTime", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIDictionary", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIDictionary", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIQuantity", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIQuantity", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MITable", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MITable", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MICluster", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MICluster", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MITextDesc", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MITextDesc", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MILink", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MILink", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MISegment", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MISegment", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIImageAnnotate", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIImageAnnotate", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIPosition", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIPosition", false);
			}
			else if (data.GetData("dhcc.epr.eprlib.metadata.MIFigure", false) != null)
			{
				result = (MMetaItem)data.GetData("dhcc.epr.eprlib.metadata.MIFigure", false);
			}
			return result;
		}

		public void InsertMetaItem(MMetaItem metaitem)
		{
			TreeNode selectedNode = this.SelectedNode;
			TreeNode treeNode = null;
			TreeNode treeNode2 = new TreeNode(metaitem.Text, this.GetImageIndex(metaitem), this.GetImageIndex(metaitem));
			treeNode2.Tag = metaitem;
			int num;
			if (selectedNode != null)
			{
				if (selectedNode.Tag is MMetaData)
				{
					treeNode = selectedNode;
					num = selectedNode.GetNodeCount(false);
				}
				else if (selectedNode.Tag is MICluster)
				{
					treeNode = selectedNode;
					num = selectedNode.GetNodeCount(false);
				}
				else if (selectedNode.Tag is MITable & metaitem is MISimple)
				{
					treeNode = selectedNode;
					num = selectedNode.GetNodeCount(false);
				}
				else if (selectedNode.Tag is MISegment & (metaitem is MISimple | metaitem is MILink))
				{
					treeNode = selectedNode;
					num = selectedNode.GetNodeCount(false);
				}
				else
				{
					if (selectedNode.Parent == null)
					{
						return;
					}
					treeNode = selectedNode.Parent;
					num = selectedNode.Index;
				}
			}
			if (treeNode.GetNodeCount(false) == num)
			{
				treeNode.Nodes.Add(treeNode2);
			}
			else
			{
				treeNode.Nodes.Insert(num, treeNode2);
			}
			if (!treeNode.IsExpanded)
			{
				treeNode.Expand();
			}
			MMetaItem mMetaItem = (MMetaItem)treeNode.Tag;
			mMetaItem.SubItems.Insert(mMetaItem, num, metaitem);
			if (!(mMetaItem is MITable))
			{
				if (!(mMetaItem is MISegment))
				{
					metaitem.BindInstanceItem = metaitem.CreateInstance();
					mMetaItem.BindInstanceItem.SubItems.Insert(mMetaItem.BindInstanceItem, num, metaitem.BindInstanceItem);
				}
			}
			this.CreateStatus = true;
			this.SelectedNode = treeNode2;
			this.CreateStatus = false;
		}

		private void MetaItemTree_DragOver(object sender, DragEventArgs e)
		{
			Point point;
			point.X = e.X;
			point.Y = e.Y;
			point = this.PointToClient(point);
			TreeNode treeNode = this.GetNodeAt(point);
			if (treeNode == null)
			{
				treeNode = this._RootNode;
			}
			if (this._DragMetaItem != null)
			{
				MMetaItem mMetaItem = (MMetaItem)treeNode.Tag;
				if (this._DragMetaItem.Parent is MISegment & !(mMetaItem == this._DragMetaItem.Parent | mMetaItem.Parent == this._DragMetaItem.Parent))
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (this._DragMetaItem.Parent != null && (this._DragMetaItem.Parent is MITable & this._DragMetaItem.Parent.BindControl))
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (this._DragMetaItem.Parent is MITable & !(mMetaItem == this._DragMetaItem.Parent | mMetaItem.Parent == this._DragMetaItem.Parent))
				{
					e.Effect = DragDropEffects.None;
					return;
				}
			}
			if (treeNode.Parent != null && treeNode.Parent.Tag is MITable)
			{
				MITable mITable = (MITable)treeNode.Parent.Tag;
				if (mITable.BindControl)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				if (this._DragMetaItem is MICluster | this._DragMetaItem is MITextDesc | this._DragMetaItem is MITable | this._DragMetaItem is MILink | this._DragMetaItem is MISegment)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
			}
			if (treeNode.Parent != null && (treeNode.Parent.Tag is MISegment | treeNode.Tag is MISegment) && (this._DragMetaItem is MICluster | this._DragMetaItem is MITextDesc | this._DragMetaItem is MITable | this._DragMetaItem is MISegment | this._DragMetaItem.BindControl | this._DragMetaItem.BindLabel))
			{
				e.Effect = DragDropEffects.None;
				return;
			}
			if (treeNode.Parent != null && ((treeNode.Parent.Tag is MICluster | treeNode.Parent.Tag is MMetaData | treeNode.Parent.Tag is MITable) & !(treeNode.Tag is MISegment)) && this._DragMetaItem is MILink)
			{
				e.Effect = DragDropEffects.None;
				return;
			}
			if (treeNode.Tag is MMetaData && this._DragMetaItem is MILink)
			{
				e.Effect = DragDropEffects.None;
				return;
			}
			if (treeNode.Tag is MITable)
			{
				MITable mITable2 = (MITable)treeNode.Tag;
				if (mITable2.BindControl)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
			}
			if (treeNode.Tag is MIImageAnnotate)
			{
				if (!(this._DragMetaItem is MISimple))
				{
					e.Effect = DragDropEffects.None;
					return;
				}
			}
			else if (this._DragTreeNode != null)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void MetaItemTree_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Delete))
			{
				this.DeleteNode();
			}
		}

		public void DeleteNode()
		{
			if (this.SelectedNode == null)
			{
				MessageManager.ShowInformationMessage("没有选中单元，请选中后再删除！");
				return;
			}
			if (this.SelectedNode == this._RootNode)
			{
				MessageManager.ShowInformationMessage("不能删除根节点！");
				return;
			}
			if (this.SelectedNode.GetNodeCount(false) > 0)
			{
				MessageManager.ShowInformationMessage("该单元下有子节点，不能删除！");
				return;
			}
			MMetaItem mMetaItem = (MMetaItem)this.SelectedNode.Tag;
			if (mMetaItem.BindLabel)
			{
				MessageManager.ShowInformationMessage("该单元已被界面模板标签引用，不能删除！");
				return;
			}
			if (mMetaItem.BindControl)
			{
				MessageManager.ShowInformationMessage("该单元已被界面模板控件引用，不能删除！");
				return;
			}
			if (mMetaItem.Parent is MITable & mMetaItem.Parent.BindControl)
			{
				MessageManager.ShowInformationMessage("该单元已被界面模板控件引用，不能删除！");
				return;
			}
			if (mMetaItem.Status != EPRStatus.Create)
			{
				MessageManager.ShowInformationMessage("该单元已发布，不能删除！");
				return;
			}
			MMetaItem mMetaItem2 = (MMetaItem)this.SelectedNode.Parent.Tag;
			if (!(mMetaItem2 is MISegment))
			{
				if (mMetaItem.BindInstanceItem != null && mMetaItem.BindInstanceItem.Parent != null)
				{
					mMetaItem.BindInstanceItem.Parent.SubItems.Remove(mMetaItem.BindInstanceItem);
				}
				mMetaItem2.SubItems.Remove(mMetaItem);
				this.SelectedNode.Parent.Nodes.Remove(this.SelectedNode);
				return;
			}
			if (mMetaItem2.BindInstanceItem.SubItems.Contains(mMetaItem.BindInstanceItem))
			{
				MessageManager.ShowInformationMessage("该单元已经被文本片断引用，不能删除！");
				return;
			}
			mMetaItem2.SubItems.Remove(mMetaItem);
			this.SelectedNode.Parent.Nodes.Remove(this.SelectedNode);
		}

		private void MetaItemTree_DragLeave(object sender, EventArgs e)
		{
		}
	}
}
