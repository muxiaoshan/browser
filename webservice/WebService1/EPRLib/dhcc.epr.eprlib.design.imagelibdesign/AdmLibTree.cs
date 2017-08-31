using AdmImageItemData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class AdmLibTree : EPRTreeView
	{
		private IContainer components;

		[AccessedThroughProperty("cmAdmImageTree")]
		private ContextMenu _cmAdmImageTree;

		[AccessedThroughProperty("ilAdmImageTree")]
		private ImageList _ilAdmImageTree;

		public const int TREE_NODE_COLLAPSE_IMGINDEX = 0;

		public const int TREE_NODE_EXPAND_IMGINDEX = 1;

		public const int IMAGE_NODE_IMGINDEX = 2;

		public const string ROOT_NODE_TYPE = "RT";

		public const string RESOURCE_NODE_TYPE = "LF";

		private string _EpisodeID;

		internal virtual ContextMenu cmAdmImageTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmAdmImageTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmAdmImageTree = value;
			}
		}

		internal virtual ImageList ilAdmImageTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ilAdmImageTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ilAdmImageTree = value;
			}
		}

		public string EpisodeID
		{
			get
			{
				return this._EpisodeID;
			}
			set
			{
				this._EpisodeID = value;
				if (!string.IsNullOrEmpty(this._EpisodeID))
				{
					this.InitAdmLibTree(this._EpisodeID);
					this.ExpandAll();
				}
			}
		}

		public AdmLibTree()
		{
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdmLibTree));
			this.cmAdmImageTree = new ContextMenu();
			this.ilAdmImageTree = new ImageList(this.components);
			this.SuspendLayout();
			this.ilAdmImageTree.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ilAdmImageTree.ImageStream");
			this.ilAdmImageTree.TransparentColor = Color.Transparent;
			this.ilAdmImageTree.Images.SetKeyName(0, "");
			this.ilAdmImageTree.Images.SetKeyName(1, "");
			this.ilAdmImageTree.Images.SetKeyName(2, "");
			this.ilAdmImageTree.Images.SetKeyName(3, "");
			this.ilAdmImageTree.Images.SetKeyName(4, "");
			this.ilAdmImageTree.Images.SetKeyName(5, "");
			this.AllowDrop = true;
			this.ImageIndex = 0;
			this.ImageList = this.ilAdmImageTree;
			this.SelectedImageIndex = 0;
			this.ResumeLayout(false);
		}

		private void Init()
		{
		}

		private void InitAdmLibTree(string episodeID)
		{
			string patientNameByEpisodeID = WebServiceLayer.ImageLibAccess.GetPatientNameByEpisodeID(episodeID);
			TreeNode treeNode = new TreeNode(string.Format("{0}就诊图库", patientNameByEpisodeID), 0, 1);
			treeNode.Tag = "RT";
			this.Nodes.Add(treeNode);
			checked
			{
				try
				{
					EAdmImageItemDataSet byEpisodeID = WebServiceLayer.AdmImageItemAccess.GetByEpisodeID(episodeID);
					if (byEpisodeID != null & byEpisodeID.GetByEpisodeID != null)
					{
						string arg = string.Empty;
						string text = string.Empty;
						string text2 = string.Empty;
						EAdmImageItemDataSet.GetByEpisodeIDDataTable getByEpisodeID = byEpisodeID.GetByEpisodeID;
						DataRow[] array = getByEpisodeID.Select();
						for (int i = 0; i < array.Length; i++)
						{
							DataRow dataRow = array[i];
							arg = dataRow[getByEpisodeID.IDColumn.ColumnName].ToString();
							text = dataRow[getByEpisodeID.NameColumn.ColumnName].ToString();
							text2 = dataRow[getByEpisodeID.DescriptionColumn.ColumnName].ToString();
							TreeNode treeNode2 = new TreeNode(text, 2, 2);
							treeNode2.Tag = string.Format("{0}{1}", "LF", arg);
							treeNode.Nodes.Add(treeNode2);
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
		}

		public string GetNodeID(TreeNode node)
		{
			string result = string.Empty;
			if (node != null)
			{
				result = node.Tag.ToString().Substring(2);
			}
			return result;
		}

		public string GetNodeType(TreeNode node)
		{
			string result = string.Empty;
			if (node != null)
			{
				result = node.Tag.ToString().Substring(0, 2);
			}
			return result;
		}
	}
}
