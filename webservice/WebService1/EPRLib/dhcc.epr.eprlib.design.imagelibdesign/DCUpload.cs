using dhcc.epr.systemframework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCUpload : UserControl
	{
		[AccessedThroughProperty("userUploadDialog")]
		private OpenFileDialog _userUploadDialog;

		[AccessedThroughProperty("SplitContainer2")]
		private SplitContainer _SplitContainer2;

		[AccessedThroughProperty("lblStep4")]
		private Label _lblStep4;

		[AccessedThroughProperty("lblStep3")]
		private Label _lblStep3;

		[AccessedThroughProperty("lblStep2")]
		private Label _lblStep2;

		[AccessedThroughProperty("lblStep1")]
		private Label _lblStep1;

		[AccessedThroughProperty("lblDesc")]
		private Label _lblDesc;

		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("gbxUpload")]
		private GroupBox _gbxUpload;

		[AccessedThroughProperty("btnPaste")]
		private Button _btnPaste;

		[AccessedThroughProperty("lblHint")]
		private Label _lblHint;

		[AccessedThroughProperty("btnUpload")]
		private Button _btnUpload;

		[AccessedThroughProperty("txtImageFile")]
		private TextBox _txtImageFile;

		[AccessedThroughProperty("btnChoose")]
		private Button _btnChoose;

		[AccessedThroughProperty("gbxPaste")]
		private GroupBox _gbxPaste;

		[AccessedThroughProperty("pbxImage")]
		private PictureBox _pbxImage;

		private IContainer components;

		private byte[] _ImageData;

		internal virtual OpenFileDialog userUploadDialog
		{
			[DebuggerNonUserCode]
			get
			{
				return this._userUploadDialog;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._userUploadDialog = value;
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

		internal virtual Label lblStep4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStep4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStep4 = value;
			}
		}

		internal virtual Label lblStep3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStep3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStep3 = value;
			}
		}

		internal virtual Label lblStep2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStep2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStep2 = value;
			}
		}

		internal virtual Label lblStep1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStep1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStep1 = value;
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

		internal virtual GroupBox gbxUpload
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxUpload;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxUpload = value;
			}
		}

		internal virtual Button btnPaste
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPaste;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPaste_Click);
				if (this._btnPaste != null)
				{
					this._btnPaste.Click -= value2;
				}
				this._btnPaste = value;
				if (this._btnPaste != null)
				{
					this._btnPaste.Click += value2;
				}
			}
		}

		internal virtual Label lblHint
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblHint;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblHint = value;
			}
		}

		internal virtual Button btnUpload
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUpload;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnUpload_Click);
				if (this._btnUpload != null)
				{
					this._btnUpload.Click -= value2;
				}
				this._btnUpload = value;
				if (this._btnUpload != null)
				{
					this._btnUpload.Click += value2;
				}
			}
		}

		internal virtual TextBox txtImageFile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtImageFile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtImageFile = value;
			}
		}

		internal virtual Button btnChoose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnChoose;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnChoose_Click);
				if (this._btnChoose != null)
				{
					this._btnChoose.Click -= value2;
				}
				this._btnChoose = value;
				if (this._btnChoose != null)
				{
					this._btnChoose.Click += value2;
				}
			}
		}

		internal virtual GroupBox gbxPaste
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxPaste;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxPaste = value;
			}
		}

		internal virtual PictureBox pbxImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pbxImage = value;
			}
		}

		public byte[] ImageData
		{
			get
			{
				return this._ImageData;
			}
			set
			{
				this._ImageData = value;
				if (this._ImageData != null && this._ImageData.Length > 0)
				{
					MemoryStream stream = new MemoryStream(this._ImageData);
					this.pbxImage.Image = Image.FromStream(stream);
				}
			}
		}

		public DCUpload()
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
			this.userUploadDialog = new OpenFileDialog();
			this.SplitContainer2 = new SplitContainer();
			this.lblStep4 = new Label();
			this.lblStep3 = new Label();
			this.lblStep2 = new Label();
			this.lblStep1 = new Label();
			this.lblDesc = new Label();
			this.SplitContainer1 = new SplitContainer();
			this.gbxUpload = new GroupBox();
			this.btnPaste = new Button();
			this.lblHint = new Label();
			this.btnUpload = new Button();
			this.txtImageFile = new TextBox();
			this.btnChoose = new Button();
			this.gbxPaste = new GroupBox();
			this.pbxImage = new PictureBox();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.gbxUpload.SuspendLayout();
			this.gbxPaste.SuspendLayout();
			((ISupportInitialize)this.pbxImage).BeginInit();
			this.SuspendLayout();
			this.userUploadDialog.Filter = "所有图片文件|*.bmp;*.jpeg;*.jpg;*.jpe";
			this.SplitContainer2.Dock = DockStyle.Fill;
			this.SplitContainer2.FixedPanel = FixedPanel.Panel1;
			Control arg_165_0 = this.SplitContainer2;
			Point location = new Point(0, 0);
			arg_165_0.Location = location;
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = Orientation.Horizontal;
			this.SplitContainer2.Panel1.Controls.Add(this.lblStep4);
			this.SplitContainer2.Panel1.Controls.Add(this.lblStep3);
			this.SplitContainer2.Panel1.Controls.Add(this.lblStep2);
			this.SplitContainer2.Panel1.Controls.Add(this.lblStep1);
			this.SplitContainer2.Panel1.Controls.Add(this.lblDesc);
			this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer1);
			Control arg_240_0 = this.SplitContainer2;
			Size size = new Size(480, 280);
			arg_240_0.Size = size;
			this.SplitContainer2.SplitterDistance = 64;
			this.SplitContainer2.SplitterWidth = 2;
			this.SplitContainer2.TabIndex = 13;
			this.lblStep4.AutoSize = true;
			Control arg_28C_0 = this.lblStep4;
			location = new Point(241, 43);
			arg_28C_0.Location = location;
			this.lblStep4.Name = "lblStep4";
			Control arg_2B3_0 = this.lblStep4;
			size = new Size(101, 12);
			arg_2B3_0.Size = size;
			this.lblStep4.TabIndex = 18;
			this.lblStep4.Text = "第四步：发布图片";
			this.lblStep3.AutoSize = true;
			Control arg_2F2_0 = this.lblStep3;
			location = new Point(6, 43);
			arg_2F2_0.Location = location;
			this.lblStep3.Name = "lblStep3";
			Control arg_31C_0 = this.lblStep3;
			size = new Size(233, 12);
			arg_31C_0.Size = size;
			this.lblStep3.TabIndex = 17;
			this.lblStep3.Text = "第三步：如果需要，可对图片设置默认热区";
			this.lblStep2.AutoSize = true;
			Control arg_35F_0 = this.lblStep2;
			location = new Point(241, 25);
			arg_35F_0.Location = location;
			this.lblStep2.Name = "lblStep2";
			Control arg_389_0 = this.lblStep2;
			size = new Size(233, 12);
			arg_389_0.Size = size;
			this.lblStep2.TabIndex = 16;
			this.lblStep2.Text = "第二步：如果需要，可对原始图片进行裁剪";
			this.lblStep1.AutoSize = true;
			Control arg_3C8_0 = this.lblStep1;
			location = new Point(6, 25);
			arg_3C8_0.Location = location;
			this.lblStep1.Name = "lblStep1";
			Control arg_3F2_0 = this.lblStep1;
			size = new Size(197, 12);
			arg_3F2_0.Size = size;
			this.lblStep1.TabIndex = 15;
			this.lblStep1.Text = "第一步：上传图片或者从剪贴板拷贝";
			this.lblDesc.AutoSize = true;
			this.lblDesc.Font = new Font("宋体", 12f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.lblDesc.ForeColor = SystemColors.ActiveCaption;
			Control arg_461_0 = this.lblDesc;
			location = new Point(4, 4);
			arg_461_0.Location = location;
			this.lblDesc.Name = "lblDesc";
			Control arg_48B_0 = this.lblDesc;
			size = new Size(152, 16);
			arg_48B_0.Size = size;
			this.lblDesc.TabIndex = 14;
			this.lblDesc.Text = "图库向导使用说明：";
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			Control arg_4D5_0 = this.SplitContainer1;
			location = new Point(0, 0);
			arg_4D5_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Panel1.Controls.Add(this.gbxUpload);
			this.SplitContainer1.Panel2.Controls.Add(this.gbxPaste);
			Control arg_538_0 = this.SplitContainer1;
			size = new Size(480, 214);
			arg_538_0.Size = size;
			this.SplitContainer1.SplitterDistance = 242;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 13;
			this.gbxUpload.Controls.Add(this.btnPaste);
			this.gbxUpload.Controls.Add(this.lblHint);
			this.gbxUpload.Controls.Add(this.btnUpload);
			this.gbxUpload.Controls.Add(this.txtImageFile);
			this.gbxUpload.Controls.Add(this.btnChoose);
			this.gbxUpload.Dock = DockStyle.Fill;
			Control arg_5F0_0 = this.gbxUpload;
			location = new Point(0, 0);
			arg_5F0_0.Location = location;
			this.gbxUpload.Name = "gbxUpload";
			Control arg_61D_0 = this.gbxUpload;
			size = new Size(242, 214);
			arg_61D_0.Size = size;
			this.gbxUpload.TabIndex = 3;
			this.gbxUpload.TabStop = false;
			this.gbxUpload.Text = "上传图片";
			Control arg_65B_0 = this.btnPaste;
			location = new Point(2, 99);
			arg_65B_0.Location = location;
			this.btnPaste.Name = "btnPaste";
			Control arg_682_0 = this.btnPaste;
			size = new Size(75, 23);
			arg_682_0.Size = size;
			this.btnPaste.TabIndex = 13;
			this.btnPaste.Text = "拷贝";
			this.btnPaste.UseVisualStyleBackColor = true;
			this.lblHint.AutoSize = true;
			this.lblHint.ForeColor = SystemColors.ActiveCaption;
			Control arg_6DD_0 = this.lblHint;
			location = new Point(3, 125);
			arg_6DD_0.Location = location;
			this.lblHint.Name = "lblHint";
			Control arg_707_0 = this.lblHint;
			size = new Size(173, 12);
			arg_707_0.Size = size;
			this.lblHint.TabIndex = 12;
			this.lblHint.Text = "【Alt + PrtSc仅拷贝当前激活窗口】";
			this.btnUpload.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_74B_0 = this.btnUpload;
			location = new Point(165, 41);
			arg_74B_0.Location = location;
			this.btnUpload.Name = "btnUpload";
			Control arg_772_0 = this.btnUpload;
			size = new Size(75, 23);
			arg_772_0.Size = size;
			this.btnUpload.TabIndex = 3;
			this.btnUpload.Text = "上传";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.txtImageFile.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_7BD_0 = this.txtImageFile;
			location = new Point(2, 17);
			arg_7BD_0.Location = location;
			this.txtImageFile.Name = "txtImageFile";
			Control arg_7E7_0 = this.txtImageFile;
			size = new Size(238, 21);
			arg_7E7_0.Size = size;
			this.txtImageFile.TabIndex = 1;
			Control arg_809_0 = this.btnChoose;
			location = new Point(2, 41);
			arg_809_0.Location = location;
			this.btnChoose.Name = "btnChoose";
			Control arg_830_0 = this.btnChoose;
			size = new Size(75, 23);
			arg_830_0.Size = size;
			this.btnChoose.TabIndex = 2;
			this.btnChoose.Text = "选择";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.gbxPaste.Controls.Add(this.pbxImage);
			this.gbxPaste.Dock = DockStyle.Fill;
			Control arg_88F_0 = this.gbxPaste;
			location = new Point(0, 0);
			arg_88F_0.Location = location;
			this.gbxPaste.Name = "gbxPaste";
			Control arg_8BC_0 = this.gbxPaste;
			size = new Size(236, 214);
			arg_8BC_0.Size = size;
			this.gbxPaste.TabIndex = 12;
			this.gbxPaste.TabStop = false;
			this.gbxPaste.Text = "图片预览";
			this.pbxImage.Dock = DockStyle.Fill;
			Control arg_907_0 = this.pbxImage;
			location = new Point(3, 17);
			arg_907_0.Location = location;
			this.pbxImage.Name = "pbxImage";
			Control arg_934_0 = this.pbxImage;
			size = new Size(230, 194);
			arg_934_0.Size = size;
			this.pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxImage.TabIndex = 10;
			this.pbxImage.TabStop = false;
			this.Controls.Add(this.SplitContainer2);
			this.Name = "DCUpload";
			size = new Size(480, 280);
			this.Size = size;
			this.SplitContainer2.Panel1.ResumeLayout(false);
			this.SplitContainer2.Panel1.PerformLayout();
			this.SplitContainer2.Panel2.ResumeLayout(false);
			this.SplitContainer2.ResumeLayout(false);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.gbxUpload.ResumeLayout(false);
			this.gbxUpload.PerformLayout();
			this.gbxPaste.ResumeLayout(false);
			((ISupportInitialize)this.pbxImage).EndInit();
			this.ResumeLayout(false);
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			if (this.userUploadDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.userUploadDialog.FileName;
				if (!string.IsNullOrEmpty(fileName))
				{
					this.txtImageFile.Text = fileName;
				}
			}
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			string text = this.txtImageFile.Text.Trim();
			checked
			{
				if (string.IsNullOrEmpty(text) || !File.Exists(text))
				{
					MessageManager.ShowWarningMessage("指定文件不存在！");
				}
				else
				{
					FileStream fileStream = new FileStream(text, FileMode.Open);
					this._ImageData = new byte[(int)(fileStream.Length - 1L) + 1];
					fileStream.Read(this._ImageData, 0, (int)fileStream.Length);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(this._ImageData, 0, this._ImageData.Length);
					this.pbxImage.Image = Image.FromStream(memoryStream);
					this.txtImageFile.Text = string.Empty;
				}
			}
		}

		private void btnPaste_Click(object sender, EventArgs e)
		{
			Image image = Clipboard.GetImage();
			if (image != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				image.Save(memoryStream, ImageFormat.Jpeg);
				this._ImageData = memoryStream.ToArray();
				this.pbxImage.Image = image;
			}
			else
			{
				MessageManager.ShowInformationMessage("当前系统剪切板中没有图片!");
			}
		}
	}
}
