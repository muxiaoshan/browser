using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using ImageCategoryData;
using ImageLibData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class ImageLibForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("tvImageLib")]
		private TreeView _tvImageLib;

		[AccessedThroughProperty("ILTree")]
		private ImageList _ILTree;

		protected const int CATEGORY_NODE_COLLAPSE_IMGINDEX = 0;

		protected const int CATEGORY_NODE_EXPAND_IMGINDEX = 1;

		protected const int KNOWLEDGEBASE_NODE_IMGINDEX = 2;

		protected const string ROOT_NODE_TYPE = "RT";

		protected const string CATEGORY_NODE_TYPE = "CG";

		protected const string RESOURCE_NODE_TYPE = "LF";

		private string _ImageLibID;

		private string _ImageLibName;

		private bool BoolMouseDown;

		private Point ClickedPoint;

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= value2;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += value2;
				}
			}
		}

		internal virtual TreeView tvImageLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvImageLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewCancelEventHandler value2 = new TreeViewCancelEventHandler(this.tvImageLib_BeforeExpand);
				TreeViewEventHandler value3 = new TreeViewEventHandler(this.tvImageLib_AfterSelect);
				if (this._tvImageLib != null)
				{
					this._tvImageLib.BeforeExpand -= value2;
					this._tvImageLib.AfterSelect -= value3;
				}
				this._tvImageLib = value;
				if (this._tvImageLib != null)
				{
					this._tvImageLib.BeforeExpand += value2;
					this._tvImageLib.AfterSelect += value3;
				}
			}
		}

		internal virtual ImageList ILTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ILTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ILTree = value;
			}
		}

		public string ImageLibID
		{
			get
			{
				return this._ImageLibID;
			}
			set
			{
				this._ImageLibID = value;
			}
		}

		public string ImageLibName
		{
			get
			{
				return this._ImageLibName;
			}
			set
			{
				this._ImageLibName = value;
			}
		}

		public ImageLibForm()
		{
			base.Paint += new PaintEventHandler(this.ImageLibForm_Paint);
			base.Load += new EventHandler(this.ImageLibForm_Load);
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			this.BoolMouseDown = false;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ImageLibForm));
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.tvImageLib = new TreeView();
			this.ILTree = new ImageList(this.components);
			this.SuspendLayout();
			Control arg_6B_0 = this.btnCancel;
			Point location = new Point(236, 341);
			arg_6B_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_92_0 = this.btnCancel;
			Size size = new Size(64, 24);
			arg_92_0.Size = size;
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "取消(&C)";
			Control arg_CC_0 = this.btnOK;
			location = new Point(167, 341);
			arg_CC_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_F3_0 = this.btnOK;
			size = new Size(64, 24);
			arg_F3_0.Size = size;
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "确定(&O)";
			this.tvImageLib.ImageIndex = 0;
			this.tvImageLib.ImageList = this.ILTree;
			Control arg_142_0 = this.tvImageLib;
			location = new Point(4, 4);
			arg_142_0.Location = location;
			this.tvImageLib.Name = "tvImageLib";
			this.tvImageLib.SelectedImageIndex = 0;
			Control arg_17B_0 = this.tvImageLib;
			size = new Size(296, 331);
			arg_17B_0.Size = size;
			this.tvImageLib.TabIndex = 13;
			this.ILTree.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ILTree.ImageStream");
			this.ILTree.TransparentColor = Color.Transparent;
			this.ILTree.Images.SetKeyName(0, "");
			this.ILTree.Images.SetKeyName(1, "");
			this.ILTree.Images.SetKeyName(2, "");
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(304, 368);
			this.ClientSize = size;
			this.Controls.Add(this.tvImageLib);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "ImageLibForm";
			this.Text = "选择图库";
			this.ResumeLayout(false);
		}

		private void ImageLibForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics arg_28_0 = graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_28_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void ImageLibForm_Load(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode("图库目录", 0, 1);
			treeNode.Tag = "RT";
			this.tvImageLib.Nodes.Add(treeNode);
			this.InitTreeViewNodes();
		}

		private void tvImageLib_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (Operators.CompareString(this.GetNodeType(this.tvImageLib.SelectedNode), "LF", false) == 0)
			{
				this._ImageLibID = this.GetNodeId(this.tvImageLib.SelectedNode);
				this._ImageLibName = this.tvImageLib.SelectedNode.Text;
			}
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
			Point p = new Point(e.X, e.Y);
			this.ClickedPoint = this.PointToScreen(p);
			this.Cursor = Cursors.SizeAll;
			this.BoolMouseDown = true;
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.BoolMouseDown)
				{
					Point clickedPoint = default(Point);
					Point p = new Point(e.X, e.Y);
					clickedPoint = this.PointToScreen(p);
					this.Top += clickedPoint.Y - this.ClickedPoint.Y;
					this.Left += clickedPoint.X - this.ClickedPoint.X;
					this.ClickedPoint = clickedPoint;
				}
			}
		}

		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.BoolMouseDown = false;
		}

		private void InitTreeViewNodes()
		{
			try
			{
				EImageCategoryDataset allImageCategories = WebServiceLayer.ImageCategoryAccess.GetAllImageCategories();
				if (allImageCategories != null && allImageCategories.GetAllImageCategories != null)
				{
					this.InitCategoryNodes(allImageCategories.GetAllImageCategories, this.tvImageLib.Nodes[0], "0");
				}
				this.tvImageLib.Nodes[0].Expand();
			}
			catch (Exception expr_50)
			{
				ProjectData.SetProjectError(expr_50);
				Exception ex = expr_50;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void InitCategoryNodes(EImageCategoryDataset.GetAllImageCategoriesDataTable dt, TreeNode parentNode, string parentID)
		{
			string filterExpression = dt.ParentIDColumn.ColumnName + "='" + parentID + "'";
			DataRow[] array = dt.Select(filterExpression);
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
					this.InitCategoryNodes(dt, treeNode, text);
					int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[dt.ChildCountColumn.ColumnName]));
					int arg_EB_0 = 0;
					int num2 = num - 1;
					for (int j = arg_EB_0; j <= num2; j++)
					{
						TreeNode treeNode2 = new TreeNode(null, 2, 2);
						treeNode2.Tag = "LF";
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
		}

		private void tvImageLib_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.FirstNode.Text == null | Operators.CompareString(e.Node.FirstNode.Text, "", false) == 0)
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
						EImageLibDataset imageLibsByCateID = WebServiceLayer.ImageLibAccess.GetImageLibsByCateID(nodeId);
						if (parentNode.Nodes.Count != imageLibsByCateID.GetImageLibsByCateID.Rows.Count)
						{
							throw new AppException("获取知识库信息失败。");
						}
						string columnName = imageLibsByCateID.GetImageLibsByCateID.IDColumn.ColumnName;
						string columnName2 = imageLibsByCateID.GetImageLibsByCateID.NameColumn.ColumnName;
						string columnName3 = imageLibsByCateID.GetImageLibsByCateID.DescriptionColumn.ColumnName;
						int arg_87_0 = 0;
						int num = imageLibsByCateID.GetImageLibsByCateID.Rows.Count - 1;
						for (int i = arg_87_0; i <= num; i++)
						{
							parentNode.Nodes[i].Tag = "LF" + imageLibsByCateID.GetImageLibsByCateID.Rows[i][columnName].ToString();
							parentNode.Nodes[i].Text = imageLibsByCateID.GetImageLibsByCateID.Rows[i][columnName2].ToString();
						}
						result = true;
					}
					catch (AppException expr_110)
					{
						ProjectData.SetProjectError(expr_110);
						AppException ex = expr_110;
						MessageManager.ShowErrorMessage(ex.ShowInfo);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
		}

		private string GetNodeId(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(2);
		}

		private string GetNodeType(TreeNode node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Tag.ToString().Substring(0, 2);
		}
	}
}
