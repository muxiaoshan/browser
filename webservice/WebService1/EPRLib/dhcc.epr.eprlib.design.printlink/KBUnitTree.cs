using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using KBNodeData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.printlink
{
	public class KBUnitTree : TreeView
	{
		[AccessedThroughProperty("ItemImages")]
		private ImageList _ItemImages;

		private IContainer components;

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

		public KBUnitTree()
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KBUnitTree));
			this.ItemImages = new ImageList(this.components);
			this.SuspendLayout();
			this.ItemImages.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ItemImages.ImageStream");
			this.ItemImages.TransparentColor = Color.Transparent;
			this.ItemImages.Images.SetKeyName(0, "");
			this.ItemImages.Images.SetKeyName(1, "");
			this.ItemImages.Images.SetKeyName(2, "");
			this.ItemImages.Images.SetKeyName(3, "");
			this.ItemImages.Images.SetKeyName(4, "");
			this.ItemImages.Images.SetKeyName(5, "");
			this.ItemImages.Images.SetKeyName(6, "");
			this.ItemImages.Images.SetKeyName(7, "");
			this.ItemImages.Images.SetKeyName(8, "");
			this.ItemImages.Images.SetKeyName(9, "");
			this.ItemImages.Images.SetKeyName(10, "");
			this.ItemImages.Images.SetKeyName(11, "");
			this.ItemImages.Images.SetKeyName(12, "");
			this.ItemImages.Images.SetKeyName(13, "");
			this.ItemImages.Images.SetKeyName(14, "");
			this.ItemImages.Images.SetKeyName(15, "");
			this.HideSelection = false;
			this.ImageIndex = 0;
			this.ImageList = this.ItemImages;
			this.ItemHeight = 24;
			this.Name = "FieldTree";
			this.SelectedImageIndex = 0;
			this.ResumeLayout(false);
		}

		public void Init(string kbNodeID, int kbPartNo)
		{
			try
			{
				this.Nodes.Clear();
				string text = "";
				EKBNode eKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(kbNodeID);
				switch (kbPartNo)
				{
				case 1:
					text = eKBNode.S1MetaData;
					break;
				case 2:
					text = eKBNode.S2MetaData;
					break;
				case 3:
					text = eKBNode.S3MetaData;
					break;
				}
				if (text != null && Operators.CompareString(text, "", false) != 0)
				{
					this.InitKBUnitTree(new MMetaData
					{
						XMLString = text
					}, this.Nodes, kbNodeID, Conversions.ToString(kbPartNo));
					this.Nodes[0].Expand();
				}
			}
			catch (Exception expr_92)
			{
				ProjectData.SetProjectError(expr_92);
				Exception ex = expr_92;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitKBUnitTree(MMetaItem curMetaItem, TreeNodeCollection curNodes, string kbNodeID, string kbPartNo)
		{
			string tag = null;
			TreeNode treeNode = new TreeNode();
			treeNode.Text = curMetaItem.Text;
			int imageIndex = this.GetImageIndex(curMetaItem);
			treeNode.ImageIndex = imageIndex;
			treeNode.SelectedImageIndex = imageIndex;
			if (!(curMetaItem is MMetaData))
			{
				tag = string.Format("#TYPE:Simple#SCODE:{0}#KBNodeID:{1}#KBPartNo:{2}#VTYPE:{3}", new object[]
				{
					curMetaItem.Code,
					kbNodeID,
					kbPartNo,
					this.GetDefaultVTYPE(curMetaItem)
				});
				treeNode.Tag = tag;
				curNodes.Add(treeNode);
			}
			else
			{
				treeNode.Tag = tag;
				curNodes.Add(treeNode);
				if (curMetaItem.SubItems != null)
				{
					MMetaItemEnumerator enumerator = curMetaItem.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MMetaItem curMetaItem2 = (MMetaItem)enumerator.Current;
						this.InitKBUnitTree(curMetaItem2, treeNode.Nodes, kbNodeID, kbPartNo);
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
				return "C";
			}
			return string.Empty;
		}
	}
}
