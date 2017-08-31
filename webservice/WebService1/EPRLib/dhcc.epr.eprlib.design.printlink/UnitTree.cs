using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.printlink
{
	public class UnitTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("ItemImages")]
		private ImageList _ItemImages;

		private string _ITName;

		private string _ITVersion;

		private string _ITID;

		private MMetaData _MetaData;

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

		public string ITName
		{
			get
			{
				return this._ITName;
			}
			set
			{
				this._ITName = value;
			}
		}

		public string ITVersion
		{
			get
			{
				return this._ITVersion;
			}
			set
			{
				this._ITVersion = value;
			}
		}

		public string ITID
		{
			get
			{
				return this._ITID;
			}
			set
			{
				this._ITID = value;
			}
		}

		public string StrMetaData
		{
			set
			{
				this.Nodes.Clear();
				if (!(value == null | Operators.CompareString(value, "", false) == 0))
				{
					this._MetaData = new MMetaData();
					this._MetaData.XMLString = value;
					this.InitTree(this._MetaData, this.Nodes, null);
					this.SelectedNode = this.Nodes[0];
					this.Nodes[0].Expand();
				}
			}
		}

		public UnitTree()
		{
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
			ResourceManager resourceManager = new ResourceManager(typeof(UnitTree));
			this.ItemImages = new ImageList(this.components);
			ImageList arg_3E_0 = this.ItemImages;
			Size imageSize = new Size(24, 24);
			arg_3E_0.ImageSize = imageSize;
			this.ItemImages.ImageStream = (ImageListStreamer)resourceManager.GetObject("ItemImages.ImageStream");
			this.ItemImages.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.ItemImages;
			this.SelectedImageIndex = 0;
			this.ShowRootLines = false;
		}

		private void InitTree(MMetaItem curMetaItem, TreeNodeCollection curNodes, MMetaItem parentMetaItem)
		{
			TreeNode treeNode = new TreeNode();
			treeNode.Text = curMetaItem.Text;
			string text = null;
			if ((parentMetaItem is MMetaData | parentMetaItem is MICluster) & curMetaItem is MISimple)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					curMetaItem.Text,
					"#TYPE:Simple#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#SCODE:",
					curMetaItem.Code,
					"#VTYPE:",
					this.GetDefaultVTYPE(curMetaItem)
				});
			}
			else if (parentMetaItem is MITable & curMetaItem is MISimple)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					parentMetaItem.Text,
					".",
					curMetaItem.Text,
					"#TYPE:Table#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#TCODE:",
					parentMetaItem.Code,
					"#SCODE:",
					curMetaItem.Code,
					"#ROWNO:0#VTYPE:",
					this.GetDefaultVTYPE(curMetaItem)
				});
			}
			else if (curMetaItem is MISegment)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					curMetaItem.Text,
					"#TYPE:Segment#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#GCODE:",
					curMetaItem.Code
				});
			}
			else if (curMetaItem is MITextDesc)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					curMetaItem.Text,
					"#TYPE:TextDesc#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#ECODE:",
					curMetaItem.Code
				});
			}
			else if (curMetaItem is MIImageAnnotate)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					curMetaItem.Text,
					"#TYPE:ImageAnnotate#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#YCODE:",
					curMetaItem.Code
				});
			}
			else if (curMetaItem is MIFigure)
			{
				text = string.Concat(new string[]
				{
					this._ITName,
					".",
					curMetaItem.Text,
					"#TYPE:Figure#TID:",
					this._ITID,
					"#TVER:",
					this._ITVersion,
					"#FCODE:",
					curMetaItem.Code,
					"#VTYPE:",
					this.GetDefaultVTYPE(curMetaItem)
				});
			}
			if (text != null)
			{
				treeNode.Tag = text;
			}
			treeNode.ImageIndex = this.GetImageIndex(curMetaItem);
			treeNode.SelectedImageIndex = this.GetImageIndex(curMetaItem);
			curNodes.Add(treeNode);
			if (curMetaItem.SubItems != null)
			{
				MMetaItemEnumerator enumerator = curMetaItem.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					MMetaItem curMetaItem2 = (MMetaItem)enumerator.Current;
					this.InitTree(curMetaItem2, treeNode.Nodes, curMetaItem);
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

		private string GetDefaultVTYPE(MMetaItem curMetaItem)
		{
			if (curMetaItem is MIString)
			{
				return "V";
			}
			if (curMetaItem is MINumber)
			{
				return "V";
			}
			if (curMetaItem is MIMonoChoice)
			{
				return "V";
			}
			if (curMetaItem is MIMultiChoice)
			{
				return "V";
			}
			if (curMetaItem is MIQuantity)
			{
				return "VC";
			}
			if (curMetaItem is MIDateTime)
			{
				return "V";
			}
			if (curMetaItem is MIDictionary)
			{
				return "V";
			}
			if (curMetaItem is MIPosition)
			{
				return "V";
			}
			if (curMetaItem is MIFigure)
			{
				return "V";
			}
			return null;
		}
	}
}
