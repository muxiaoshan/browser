using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCImageCut : UserControl
	{
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		[AccessedThroughProperty("btnCut")]
		private ToolStripButton _btnCut;

		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		[AccessedThroughProperty("pnlImage")]
		private Panel _pnlImage;

		private IContainer components;

		private bool _DoCut;

		private byte[] _ImageData;

		private byte[] _CutImageData;

		[AccessedThroughProperty("ImageCutter")]
		private UCImageCutter _ImageCutter;

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
				EventHandler value2 = new EventHandler(this.SplitContainer1_Resize);
				if (this._SplitContainer1 != null)
				{
					this._SplitContainer1.Resize -= value2;
				}
				this._SplitContainer1 = value;
				if (this._SplitContainer1 != null)
				{
					this._SplitContainer1.Resize += value2;
				}
			}
		}

		internal virtual ToolStrip ToolStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		internal virtual ToolStripButton btnCut
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCut;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCut_Click);
				if (this._btnCut != null)
				{
					this._btnCut.Click -= value2;
				}
				this._btnCut = value;
				if (this._btnCut != null)
				{
					this._btnCut.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		internal virtual ToolStripButton ToolStripButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripButton2 = value;
			}
		}

		internal virtual Panel pnlImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pnlImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlImage = value;
			}
		}

		private virtual UCImageCutter ImageCutter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageCutter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageCutter = value;
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
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(value, 0, value.Length);
				Image image = Image.FromStream(memoryStream);
				this.pnlImage.BackgroundImage = image;
				this.pnlImage.BackgroundImageLayout = ImageLayout.Center;
				this.pnlImage.Size = image.Size;
				this.pnlImage.Location = this.GetImageLocation();
				this.InitImageCutter();
			}
		}

		public byte[] CutImageData
		{
			get
			{
				if (this._DoCut)
				{
					this._CutImageData = this.ConvertImageToByte(this.pnlImage.BackgroundImage);
				}
				else
				{
					this._CutImageData = this._ImageData;
				}
				return this._CutImageData;
			}
		}

		public DCImageCut()
		{
			this._DoCut = false;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DCImageCut));
			this.SplitContainer1 = new SplitContainer();
			this.pnlImage = new Panel();
			this.ToolStrip1 = new ToolStrip();
			this.btnCut = new ToolStripButton();
			this.ToolStripSeparator1 = new ToolStripSeparator();
			this.ToolStripButton2 = new ToolStripButton();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.SplitContainer1.BorderStyle = BorderStyle.Fixed3D;
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			Control arg_C2_0 = this.SplitContainer1;
			Point location = new Point(0, 0);
			arg_C2_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel1.AutoScroll = true;
			this.SplitContainer1.Panel1.Controls.Add(this.pnlImage);
			this.SplitContainer1.Panel2.Controls.Add(this.ToolStrip1);
			Control arg_142_0 = this.SplitContainer1;
			Size size = new Size(480, 280);
			arg_142_0.Size = size;
			this.SplitContainer1.SplitterDistance = 253;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 0;
			Control arg_181_0 = this.pnlImage;
			location = new Point(68, 46);
			arg_181_0.Location = location;
			this.pnlImage.Name = "pnlImage";
			Control arg_1AE_0 = this.pnlImage;
			size = new Size(330, 156);
			arg_1AE_0.Size = size;
			this.pnlImage.TabIndex = 0;
			this.ToolStrip1.Dock = DockStyle.Fill;
			this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.ToolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.btnCut,
				this.ToolStripSeparator1,
				this.ToolStripButton2
			});
			Control arg_21A_0 = this.ToolStrip1;
			location = new Point(0, 0);
			arg_21A_0.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			Control arg_244_0 = this.ToolStrip1;
			size = new Size(476, 21);
			arg_244_0.Size = size;
			this.ToolStrip1.TabIndex = 0;
			this.ToolStrip1.Text = "ToolStrip1";
			this.btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.btnCut.Image = (Image)componentResourceManager.GetObject("btnCut.Image");
			this.btnCut.ImageTransparentColor = Color.Magenta;
			this.btnCut.Name = "btnCut";
			ToolStripItem arg_2BE_0 = this.btnCut;
			size = new Size(23, 18);
			arg_2BE_0.Size = size;
			this.btnCut.Text = "裁剪";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripItem arg_2F4_0 = this.ToolStripSeparator1;
			size = new Size(6, 21);
			arg_2F4_0.Size = size;
			this.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ToolStripButton2.Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.ToolStripButton2.ImageTransparentColor = Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			ToolStripItem arg_352_0 = this.ToolStripButton2;
			size = new Size(23, 18);
			arg_352_0.Size = size;
			this.ToolStripButton2.Text = "ToolStripButton2";
			this.ToolStripButton2.Visible = false;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.Controls.Add(this.SplitContainer1);
			this.Name = "DCImageCut";
			size = new Size(480, 280);
			this.Size = size;
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.Panel2.PerformLayout();
			this.SplitContainer1.ResumeLayout(false);
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
		}

		public byte[] GetCutImage()
		{
			Point location = checked(new Point(this.ImageCutter.Location.X + this.ImageCutter.Blank, this.ImageCutter.Location.Y + this.ImageCutter.Blank));
			Rectangle rectangle = new Rectangle(location, this.ImageCutter.CurrentArea.Size);
			Image cuttedImage = this.GetCuttedImage(this.pnlImage.BackgroundImage, rectangle.Width, rectangle.Height, location.X, location.Y);
			return this.ConvertImageToByte(cuttedImage);
		}

		private byte[] ConvertImageToByte(Image image)
		{
			MemoryStream memoryStream = new MemoryStream();
			image.Save(memoryStream, ImageFormat.Jpeg);
			return memoryStream.ToArray();
		}

		private void InitImageCutter()
		{
			this.ImageCutter = new UCImageCutter();
			this.ImageCutter.Name = "ImageCutter";
			this.ImageCutter.BackColor = Color.Transparent;
			this.pnlImage.Controls.Add(this.ImageCutter);
			this.ImageCutter.Size = this.GetInitSize();
			this.ImageCutter.Location = this.GetInitLocation();
			this.ImageCutter.BringToFront();
			this.ImageCutter.DoubleClick += new EventHandler(this.ImageCutter_OnDoubleClick);
		}

		private Point GetImageLocation()
		{
			checked
			{
				int num = (int)Math.Round((double)(this.SplitContainer1.Panel1.Width - this.pnlImage.Width) / 2.0);
				int num2 = (int)Math.Round((double)(this.SplitContainer1.Panel1.Height - this.pnlImage.Height) / 2.0);
				if (num < 0)
				{
					num = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				Point result = new Point(num, num2);
				return result;
			}
		}

		private Point GetInitLocation()
		{
			checked
			{
				int num = (int)Math.Round((double)(this.pnlImage.Width - this.ImageCutter.Width) / 2.0);
				int num2 = (int)Math.Round((double)(this.pnlImage.Height - this.ImageCutter.Height) / 2.0);
				if (num < 0)
				{
					num = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				Point result = new Point(num, num2);
				return result;
			}
		}

		private Size GetInitSize()
		{
			int width = Convert.ToInt32((double)this.pnlImage.Width / 2.0);
			int height = Convert.ToInt32((double)this.pnlImage.Height / 2.0);
			Size result = new Size(width, height);
			return result;
		}

		private void SplitContainer1_Resize(object sender, EventArgs e)
		{
			this.pnlImage.Location = this.GetImageLocation();
			if (this.ImageCutter != null)
			{
				this.ImageCutter.Location = this.GetInitLocation();
			}
		}

		private void btnCut_Click(object sender, EventArgs e)
		{
			this.LoadCuttedImage();
		}

		private void ImageCutter_OnDoubleClick(object sender, EventArgs e)
		{
			this.LoadCuttedImage();
		}

		private void LoadCuttedImage()
		{
			Point location = checked(new Point(this.ImageCutter.Location.X + this.ImageCutter.Blank, this.ImageCutter.Location.Y + this.ImageCutter.Blank));
			Rectangle rectangle = new Rectangle(location, this.ImageCutter.CurrentArea.Size);
			Image cuttedImage = this.GetCuttedImage(this.pnlImage.BackgroundImage, rectangle.Width, rectangle.Height, location.X, location.Y);
			this._DoCut = true;
			this.pnlImage.BackgroundImage = cuttedImage;
		}

		private Image GetCuttedImage(Image sourceImg, int width, int height, int offsetX, int offsetY)
		{
			Image image = new Bitmap(sourceImg);
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				Rectangle destRect = new Rectangle(0, 0, width, height);
				Rectangle srcRect = checked(new Rectangle(0 + offsetX, 0 + offsetY, width, height));
				graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);
			}
			return bitmap;
		}
	}
}
