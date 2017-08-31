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
	public class FieldTree : TreeView
	{
		private IContainer components;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		private string _DSName;

		private string _DSCName;

		private string _DSQName;

		private string _DSMLine;

		private string _DSID;

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

		public string DSName
		{
			get
			{
				return this._DSName;
			}
			set
			{
				this._DSName = value;
			}
		}

		public string DSCName
		{
			get
			{
				return this._DSCName;
			}
			set
			{
				this._DSCName = value;
			}
		}

		public string DSQName
		{
			get
			{
				return this._DSQName;
			}
			set
			{
				this._DSQName = value;
			}
		}

		public string DSMLine
		{
			get
			{
				return this._DSMLine;
			}
			set
			{
				this._DSMLine = value;
			}
		}

		public string DSID
		{
			get
			{
				return this._DSID;
			}
			set
			{
				this._DSID = value;
				this.InitFields(this._DSID);
			}
		}

		public FieldTree()
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
			ResourceManager resourceManager = new ResourceManager(typeof(FieldTree));
			this.treeViewIcons = new ImageList(this.components);
			ImageList arg_3E_0 = this.treeViewIcons;
			Size imageSize = new Size(16, 16);
			arg_3E_0.ImageSize = imageSize;
			this.treeViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.ImageIndex = 2;
			this.ImageList = this.treeViewIcons;
			this.ItemHeight = 24;
			this.SelectedImageIndex = 2;
			this.ShowLines = false;
			this.ShowPlusMinus = false;
			this.ShowRootLines = false;
		}

		private void InitFields(string strDSID)
		{
			try
			{
				this.Nodes.Clear();
				EBindFieldDataset eBindFieldDataset = WebServiceLayer.BindQueryAccess.SelectFieldByQID(strDSID);
				if (eBindFieldDataset != null & eBindFieldDataset.SelectFieldByQID != null)
				{
					try
					{
						IEnumerator enumerator = eBindFieldDataset.SelectFieldByQID.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							EBindFieldDataset.SelectFieldByQIDRow selectFieldByQIDRow = (EBindFieldDataset.SelectFieldByQIDRow)enumerator.Current;
							TreeNode treeNode = new TreeNode(selectFieldByQIDRow.Name);
							treeNode.Tag = string.Concat(new string[]
							{
								this._DSName,
								".",
								selectFieldByQIDRow.Name,
								"#TYPE:DataSet#CNAME:",
								this._DSCName,
								"#QNAME:",
								this._DSQName,
								"#FNAME:",
								selectFieldByQIDRow.FieldName
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
			catch (Exception expr_FF)
			{
				ProjectData.SetProjectError(expr_FF);
				Exception ex = expr_FF;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}
	}
}
