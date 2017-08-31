using AdmImageItemData;
using Atalasoft.Imaging.Annotate;
using ImageItemData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCPreview : UserControl
	{
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		private IContainer components;

		private EAdmImageItem _EAdmImageItem;

		private EImageItem _EImageItem;

		private UCAnnoPictureBox _UCAnnoPicBox;

		private UCAnnoTool _UCAnnoTool;

		private string _AnnoData;

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

		public byte[] ImageData
		{
			get
			{
				return this._UCAnnoPicBox.ImageData;
			}
			set
			{
				this._UCAnnoPicBox.ImageData = value;
				this._UCAnnoPicBox.InitData();
				if (this._UCAnnoTool != null)
				{
					this._UCAnnoTool.BindUCAnnoPictureBox = this._UCAnnoPicBox;
				}
			}
		}

		public string AnnoData
		{
			get
			{
				return this._UCAnnoPicBox.AnnoData;
			}
			set
			{
				this._UCAnnoPicBox.AnnoData = value;
			}
		}

		public EAdmImageItem EAdmImageItem
		{
			get
			{
				return this._EAdmImageItem;
			}
			set
			{
				this._EAdmImageItem = value;
				this._UCAnnoPicBox.ImageData = this._EAdmImageItem.ImageData;
				this._UCAnnoPicBox.HotSpotData = this._EAdmImageItem.HotSpotData;
				this._UCAnnoPicBox.InitData();
				if (this._UCAnnoTool != null)
				{
					this._UCAnnoTool.BindUCAnnoPictureBox = this._UCAnnoPicBox;
					this._UCAnnoTool.IconAnnoData = this._EAdmImageItem.IconData;
				}
			}
		}

		public EImageItem EImageItem
		{
			get
			{
				return this._EImageItem;
			}
			set
			{
				this._EImageItem = value;
				this._UCAnnoPicBox.ImageData = this._EImageItem.ImageData;
				this._UCAnnoPicBox.HotSpotData = this._EImageItem.HotSpotData;
				this._UCAnnoPicBox.InitData();
				if (this._UCAnnoTool != null)
				{
					this._UCAnnoTool.BindUCAnnoPictureBox = this._UCAnnoPicBox;
					this._UCAnnoTool.IconAnnoData = this._EImageItem.IconData;
				}
			}
		}

		public Image BurnImageData
		{
			get
			{
				try
				{
					IEnumerator enumerator = this._UCAnnoPicBox.AnnoPictureBox.AnnoCtrl.get_Layers().GetEnumerator();
					while (enumerator.MoveNext())
					{
						Layer layer = (Layer)enumerator.Current;
						if (layer.get_Name().Equals("EPRHotSpotLayer"))
						{
							this._UCAnnoPicBox.AnnoPictureBox.AnnoCtrl.get_Layers().Remove(layer);
							break;
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
				Graphics graphics = Graphics.FromImage(this._UCAnnoPicBox.AnnoPictureBox.Image);
				this._UCAnnoPicBox.AnnoPictureBox.AnnoCtrl.PaintAllAnnotations(graphics);
				return this._UCAnnoPicBox.AnnoPictureBox.Image;
			}
		}

		public DCPreview(object showUCAnnoTool)
		{
			this.InitializeComponent();
			this.Init(RuntimeHelpers.GetObjectValue(showUCAnnoTool));
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
			this.SplitContainer1.SuspendLayout();
			this.SuspendLayout();
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			Control arg_44_0 = this.SplitContainer1;
			Point location = new Point(0, 0);
			arg_44_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			Control arg_71_0 = this.SplitContainer1;
			Size size = new Size(480, 280);
			arg_71_0.Size = size;
			this.SplitContainer1.SplitterDistance = 320;
			this.SplitContainer1.TabIndex = 0;
			this.Controls.Add(this.SplitContainer1);
			this.Name = "DCPreview";
			size = new Size(480, 280);
			this.Size = size;
			this.SplitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void SerializeAnnoData()
		{
			this._UCAnnoPicBox.SerilizeData();
			this._AnnoData = this._UCAnnoPicBox.AnnoData;
		}

		private void Init(object showUCAnnoTool)
		{
			this._UCAnnoPicBox = new UCAnnoPictureBox();
			Control arg_1B_0 = this._UCAnnoPicBox;
			Point location = new Point(0, 0);
			arg_1B_0.Location = location;
			this._UCAnnoPicBox.BorderStyle = BorderStyle.Fixed3D;
			this._UCAnnoPicBox.Dock = DockStyle.Fill;
			this.SplitContainer1.Panel1.Controls.Add(this._UCAnnoPicBox);
			if (Conversions.ToBoolean(showUCAnnoTool))
			{
				this._UCAnnoTool = new UCAnnoTool();
				this._UCAnnoTool.BorderStyle = BorderStyle.Fixed3D;
				this._UCAnnoTool.Dock = DockStyle.Fill;
				this.SplitContainer1.Panel2.Controls.Add(this._UCAnnoTool);
			}
			else
			{
				this.SplitContainer1.Panel2Collapsed = true;
			}
		}
	}
}
