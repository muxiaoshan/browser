using BindQueryData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.printlink
{
	public class QueryTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		private EBindQueryDataset dsQuery;

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

		public QueryTree()
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
			ResourceManager resourceManager = new ResourceManager(typeof(QueryTree));
			this.treeViewIcons = new ImageList(this.components);
			ImageList arg_3E_0 = this.treeViewIcons;
			Size imageSize = new Size(16, 16);
			arg_3E_0.ImageSize = imageSize;
			this.treeViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.ImageIndex = 0;
			this.ImageList = this.treeViewIcons;
			this.ItemHeight = 24;
			this.SelectedImageIndex = 1;
			this.ShowLines = false;
			this.ShowPlusMinus = false;
			this.ShowRootLines = false;
		}

		private void Init()
		{
			try
			{
				this.dsQuery = WebServiceLayer.BindQueryAccess.SelectAllQuery();
				if (this.dsQuery != null & this.dsQuery.SelectAllQuery != null)
				{
					try
					{
						IEnumerator enumerator = this.dsQuery.SelectAllQuery.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							EBindQueryDataset.SelectAllQueryRow selectAllQueryRow = (EBindQueryDataset.SelectAllQueryRow)enumerator.Current;
							TreeNode treeNode = new TreeNode(selectAllQueryRow.Name);
							treeNode.Tag = string.Concat(new string[]
							{
								selectAllQueryRow.ID,
								"^",
								selectAllQueryRow.ClassName,
								"^",
								selectAllQueryRow.QueryName
							});
							this.Nodes.Add(treeNode);
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
			catch (Exception expr_D5)
			{
				ProjectData.SetProjectError(expr_D5);
				Exception ex = expr_D5;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		public string GetNodeID(TreeNode node)
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

		public string GetNodeName(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Text;
		}

		public string GetNodeClassName(TreeNode node)
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

		public string GetNodeQueryName(TreeNode node)
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
	}
}
