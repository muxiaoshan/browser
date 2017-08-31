using AdmImageItemData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.imagelibdesign;
using dhcc.epr.systemframework;
using ImageItemData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.figure
{
	public class FigureViewerForm : Form
	{
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("lblDesc")]
		private Label _lblDesc;

		[AccessedThroughProperty("btnOpen")]
		private Button _btnOpen;

		[AccessedThroughProperty("rtbDesc")]
		private RichTextBox _rtbDesc;

		[AccessedThroughProperty("tcImage")]
		private TabControl _tcImage;

		[AccessedThroughProperty("tpSetImage")]
		private TabPage _tpSetImage;

		[AccessedThroughProperty("tpImageLib")]
		private TabPage _tpImageLib;

		[AccessedThroughProperty("SplitContainer2")]
		private SplitContainer _SplitContainer2;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		private IContainer components;

		private string _FigureID;

		private string _FigureType;

		private string _FigureData;

		private string _FigureDesc;

		private string _ImageLibID;

		private bool _HasChange;

		private string _AnnoData;

		private bool _BindImageLib;

		private string _ImageItemID;

		private string _ImageItemType;

		private bool _HasInitImageLib;

		[AccessedThroughProperty("picViewer")]
		private DCPreview _picViewer;

		[AccessedThroughProperty("DCImageLib")]
		private DCImageLib _DCImageLib;

		internal virtual SplitContainer SplitContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer1 = value;
			}
		}

		internal virtual Button btnSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSave;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSave_Click);
				if (this._btnSave != null)
				{
					this._btnSave.Click -= value2;
				}
				this._btnSave = value;
				if (this._btnSave != null)
				{
					this._btnSave.Click += value2;
				}
			}
		}

		internal virtual Label lblDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDesc = value;
			}
		}

		internal virtual Button btnOpen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOpen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOpen_Click);
				if (this._btnOpen != null)
				{
					this._btnOpen.Click -= value2;
				}
				this._btnOpen = value;
				if (this._btnOpen != null)
				{
					this._btnOpen.Click += value2;
				}
			}
		}

		internal virtual RichTextBox rtbDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtbDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rtbDesc_TextChanged);
				if (this._rtbDesc != null)
				{
					this._rtbDesc.TextChanged -= value2;
				}
				this._rtbDesc = value;
				if (this._rtbDesc != null)
				{
					this._rtbDesc.TextChanged += value2;
				}
			}
		}

		internal virtual TabControl tcImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tcImage_SelectedIndexChanged);
				if (this._tcImage != null)
				{
					this._tcImage.SelectedIndexChanged -= value2;
				}
				this._tcImage = value;
				if (this._tcImage != null)
				{
					this._tcImage.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TabPage tpSetImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpSetImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpSetImage = value;
			}
		}

		internal virtual TabPage tpImageLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpImageLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpImageLib = value;
			}
		}

		internal virtual SplitContainer SplitContainer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer2 = value;
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

		private virtual DCPreview picViewer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picViewer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._picViewer = value;
			}
		}

		private virtual DCImageLib DCImageLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCImageLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCImageLib = value;
			}
		}

		public string FigureData
		{
			get
			{
				return this._FigureData;
			}
			set
			{
				this._FigureData = value;
				if (!string.IsNullOrEmpty(this._FigureData))
				{
					byte[] imageData = Convert.FromBase64String(this._FigureData);
					this.picViewer.ImageData = imageData;
				}
			}
		}

		public string FigureDesc
		{
			get
			{
				return this._FigureDesc;
			}
			set
			{
				this._FigureDesc = value;
				this.rtbDesc.Text = this._FigureDesc;
			}
		}

		public bool BindImageLib
		{
			get
			{
				return this._BindImageLib;
			}
			set
			{
				this._BindImageLib = value;
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

		public string FigureID
		{
			get
			{
				return this._FigureID;
			}
			set
			{
				this._FigureID = value;
			}
		}

		public string FigureType
		{
			get
			{
				return this._FigureType;
			}
			set
			{
				this._FigureType = value;
			}
		}

		public Image BurnImage
		{
			get
			{
				if (!string.IsNullOrEmpty(this.FigureType))
				{
					return this.picViewer.BurnImageData;
				}
				return this.StrToImage(this._FigureData);
			}
		}

		public bool HasChange
		{
			get
			{
				return this._HasChange;
			}
		}

		public string AnnoData
		{
			get
			{
				return this._AnnoData;
			}
			set
			{
				this._AnnoData = value;
			}
		}

		public FigureViewerForm()
		{
			this._HasInitImageLib = false;
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
			this.SplitContainer1 = new SplitContainer();
			this.btnSave = new Button();
			this.lblDesc = new Label();
			this.btnOpen = new Button();
			this.rtbDesc = new RichTextBox();
			this.tcImage = new TabControl();
			this.tpSetImage = new TabPage();
			this.tpImageLib = new TabPage();
			this.SplitContainer2 = new SplitContainer();
			this.btnOK = new Button();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.tcImage.SuspendLayout();
			this.tpSetImage.SuspendLayout();
			this.tpImageLib.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.SuspendLayout();
			this.SplitContainer1.BorderStyle = BorderStyle.Fixed3D;
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel1;
			this.SplitContainer1.IsSplitterFixed = true;
			Control arg_10B_0 = this.SplitContainer1;
			Point location = new Point(3, 3);
			arg_10B_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel1.Controls.Add(this.btnSave);
			this.SplitContainer1.Panel1.Controls.Add(this.lblDesc);
			this.SplitContainer1.Panel1.Controls.Add(this.btnOpen);
			this.SplitContainer1.Panel1.Controls.Add(this.rtbDesc);
			Control arg_1B0_0 = this.SplitContainer1;
			Size size = new Size(818, 472);
			arg_1B0_0.Size = size;
			this.SplitContainer1.SplitterDistance = 64;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 0;
			this.btnSave.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnSave.FlatStyle = FlatStyle.System;
			Control arg_208_0 = this.btnSave;
			location = new Point(749, 33);
			arg_208_0.Location = location;
			this.btnSave.Name = "btnSave";
			Control arg_22F_0 = this.btnSave;
			size = new Size(64, 24);
			arg_22F_0.Size = size;
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "保存修改";
			Control arg_262_0 = this.lblDesc;
			location = new Point(13, 10);
			arg_262_0.Location = location;
			this.lblDesc.Name = "lblDesc";
			Control arg_289_0 = this.lblDesc;
			size = new Size(32, 42);
			arg_289_0.Size = size;
			this.lblDesc.TabIndex = 5;
			this.lblDesc.Text = "图片描述";
			this.lblDesc.TextAlign = ContentAlignment.MiddleLeft;
			this.btnOpen.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnOpen.FlatStyle = FlatStyle.System;
			Control arg_2E4_0 = this.btnOpen;
			location = new Point(749, 7);
			arg_2E4_0.Location = location;
			this.btnOpen.Name = "btnOpen";
			Control arg_30B_0 = this.btnOpen;
			size = new Size(64, 24);
			arg_30B_0.Size = size;
			this.btnOpen.TabIndex = 3;
			this.btnOpen.Text = "选择图片";
			this.rtbDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.rtbDesc.BorderStyle = BorderStyle.FixedSingle;
			Control arg_356_0 = this.rtbDesc;
			location = new Point(54, 7);
			arg_356_0.Location = location;
			this.rtbDesc.Name = "rtbDesc";
			Control arg_380_0 = this.rtbDesc;
			size = new Size(689, 50);
			arg_380_0.Size = size;
			this.rtbDesc.TabIndex = 4;
			this.rtbDesc.Text = "";
			this.tcImage.Controls.Add(this.tpSetImage);
			this.tcImage.Controls.Add(this.tpImageLib);
			this.tcImage.Dock = DockStyle.Fill;
			TabControl arg_3EB_0 = this.tcImage;
			size = new Size(80, 20);
			arg_3EB_0.ItemSize = size;
			Control arg_400_0 = this.tcImage;
			location = new Point(0, 0);
			arg_400_0.Location = location;
			this.tcImage.Name = "tcImage";
			this.tcImage.SelectedIndex = 0;
			Control arg_439_0 = this.tcImage;
			size = new Size(832, 506);
			arg_439_0.Size = size;
			this.tcImage.TabIndex = 1;
			this.tpSetImage.Controls.Add(this.SplitContainer1);
			TabPage arg_471_0 = this.tpSetImage;
			location = new Point(4, 24);
			arg_471_0.Location = location;
			this.tpSetImage.Name = "tpSetImage";
			Control arg_495_0 = this.tpSetImage;
			Padding padding = new Padding(3);
			arg_495_0.Padding = padding;
			Control arg_4B2_0 = this.tpSetImage;
			size = new Size(824, 478);
			arg_4B2_0.Size = size;
			this.tpSetImage.TabIndex = 0;
			this.tpSetImage.Text = "图片预览";
			this.tpSetImage.UseVisualStyleBackColor = true;
			this.tpImageLib.Controls.Add(this.SplitContainer2);
			TabPage arg_506_0 = this.tpImageLib;
			location = new Point(4, 24);
			arg_506_0.Location = location;
			this.tpImageLib.Name = "tpImageLib";
			Control arg_52A_0 = this.tpImageLib;
			padding = new Padding(3);
			arg_52A_0.Padding = padding;
			Control arg_547_0 = this.tpImageLib;
			size = new Size(824, 478);
			arg_547_0.Size = size;
			this.tpImageLib.TabIndex = 1;
			this.tpImageLib.Text = "图库资源";
			this.tpImageLib.UseVisualStyleBackColor = true;
			this.SplitContainer2.BorderStyle = BorderStyle.Fixed3D;
			this.SplitContainer2.Dock = DockStyle.Fill;
			this.SplitContainer2.FixedPanel = FixedPanel.Panel2;
			this.SplitContainer2.IsSplitterFixed = true;
			Control arg_5B4_0 = this.SplitContainer2;
			location = new Point(3, 3);
			arg_5B4_0.Location = location;
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = Orientation.Horizontal;
			this.SplitContainer2.Panel2.Controls.Add(this.btnOK);
			Control arg_608_0 = this.SplitContainer2;
			size = new Size(818, 472);
			arg_608_0.Size = size;
			this.SplitContainer2.SplitterDistance = 437;
			this.SplitContainer2.SplitterWidth = 2;
			this.SplitContainer2.TabIndex = 0;
			this.btnOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_656_0 = this.btnOK;
			location = new Point(737, 4);
			arg_656_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_67D_0 = this.btnOK;
			size = new Size(75, 23);
			arg_67D_0.Size = size;
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = true;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.AutoScroll = true;
			size = new Size(832, 506);
			this.ClientSize = size;
			this.Controls.Add(this.tcImage);
			this.Name = "FigureViewerForm";
			this.ShowInTaskbar = false;
			this.Text = "图库编辑器";
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.tcImage.ResumeLayout(false);
			this.tpSetImage.ResumeLayout(false);
			this.tpImageLib.ResumeLayout(false);
			this.SplitContainer2.Panel2.ResumeLayout(false);
			this.SplitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void SerializeAnnoData()
		{
			if (this.picViewer == null)
			{
				return;
			}
			this.picViewer.SerializeAnnoData();
			this._AnnoData = this.picViewer.AnnoData;
		}

		private void Init()
		{
			this.picViewer = new DCPreview(true);
			this.picViewer.Dock = DockStyle.Fill;
			this.picViewer.BorderStyle = BorderStyle.Fixed3D;
			this.SplitContainer1.Panel2.Controls.Add(this.picViewer);
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			this.tcImage.SelectTab(1);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this._HasChange = true;
			this.Close();
		}

		private void rtbDesc_TextChanged(object sender, EventArgs e)
		{
			this._FigureDesc = this.rtbDesc.Text;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string selectedImageTreeType = this.DCImageLib.SelectedImageTreeType;
			if (string.IsNullOrEmpty(selectedImageTreeType))
			{
				MessageManager.ShowErrorMessage("请选择图片节点!");
				return;
			}
			TreeNode treeNode = null;
			if (Operators.CompareString(selectedImageTreeType, ImageLibType.CI.ToString(), false) == 0)
			{
				treeNode = this.DCImageLib.ImageLibTree.SelectedNode;
			}
			else if (Operators.CompareString(selectedImageTreeType, ImageLibType.EI.ToString(), false) == 0)
			{
				treeNode = this.DCImageLib.AdmLibTree.SelectedNode;
			}
			if (treeNode == null)
			{
				MessageManager.ShowErrorMessage("请选择图片节点!");
				return;
			}
			string nodeType = ImageLibTree.GetNodeType(treeNode);
			if (Operators.CompareString(nodeType, "LF", false) != 0)
			{
				MessageManager.ShowErrorMessage("请选择有效图片节点!");
				return;
			}
			this._ImageItemID = ImageLibTree.GetNodeID(treeNode);
			this._ImageItemType = selectedImageTreeType;
			int num = Convert.ToInt32(WebServiceLayer.ImageItemAccess.CheckImageItemPublished(this._ImageItemID, this._ImageItemType));
			if (num != 1)
			{
				MessageManager.ShowErrorMessage("您当前选择的图片未发布!");
			}
			this.tcImage.SelectTab(0);
			this._FigureID = this._ImageItemID;
			this._FigureType = this._ImageItemType;
			this._FigureData = string.Empty;
			this._AnnoData = string.Empty;
			this.InitDCPreview();
		}

		private void tcImage_SelectedIndexChanged(object sender, EventArgs e)
		{
			TabPage selectedTab = this.tcImage.SelectedTab;
			if (Operators.CompareString(selectedTab.Name, "tpImageLib", false) == 0 && !this._HasInitImageLib)
			{
				this.DCImageLib = new DCImageLib();
				this.DCImageLib.Name = "DCImageLib";
				this.DCImageLib.Dock = DockStyle.Fill;
				Control arg_65_0 = this.DCImageLib;
				Point location = new Point(0, 0);
				arg_65_0.Location = location;
				this.DCImageLib.ClientMode = true;
				this.DCImageLib.BindImageLib = this.BindImageLib;
				this.DCImageLib.ImageLibID = this.ImageLibID;
				this.SplitContainer2.Panel1.Controls.Add(this.DCImageLib);
				this._HasInitImageLib = true;
			}
		}

		public void InitDCPreview()
		{
			if (!string.IsNullOrEmpty(this.FigureType))
			{
				string figureType = this._FigureType;
				if (Operators.CompareString(figureType, "CI", false) == 0)
				{
					EImageItem entity = WebServiceLayer.ImageItemAccess.GetEntity(this.FigureID);
					this.picViewer.AnnoData = this.AnnoData;
					this.picViewer.EImageItem = entity;
				}
				else if (Operators.CompareString(figureType, "EI", false) == 0)
				{
					EAdmImageItem entity2 = WebServiceLayer.AdmImageItemAccess.GetEntity(this.FigureID);
					this.picViewer.AnnoData = this.AnnoData;
					this.picViewer.EAdmImageItem = entity2;
				}
			}
			else if (this._FigureData != null && Operators.CompareString(this._FigureData, "", false) != 0)
			{
				byte[] imageData = Convert.FromBase64String(this._FigureData);
				this.picViewer.ImageData = imageData;
			}
		}

		private Image StrToImage(string Str)
		{
			if (Str != null && Operators.CompareString(Str, "", false) != 0)
			{
				MemoryStream stream = (MemoryStream)FigureViewerForm.StrToImageStream(Str);
				return Image.FromStream(stream);
			}
			return null;
		}

		private string ImageToStr(Image image)
		{
			MemoryStream memoryStream = new MemoryStream();
			image.Save(memoryStream, image.RawFormat);
			return FigureViewerForm.ImageStreamToStr(memoryStream);
		}

		public static Stream StrToImageStream(string str)
		{
			byte[] buffer = Convert.FromBase64String(str);
			return new MemoryStream(buffer);
		}

		public static string ImageStreamToStr(MemoryStream objStream)
		{
			byte[] inArray = objStream.ToArray();
			return Convert.ToBase64String(inArray);
		}
	}
}
