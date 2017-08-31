using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.presentation.annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	[DesignerGenerated]
	public class UCAnnoPictureBox : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("AnnoPictureBox")]
		private AnnoPictureBox _AnnoPictureBox;

		public Layer AnnoLayer;

		public Layer EPRHotSpotLayer;

		private ToolStripMenuItem miDelete;

		public ContextMenuStrip cmHotSpot;

		private bool boolHotSpot;

		private byte[] _ImageData;

		private string _HotSpotData;

		private string _AnnoData;

		private bool _NewAnnotation;

		public virtual AnnoPictureBox AnnoPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AnnoPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AnnoPictureBox_MouseEnter);
				MouseEventHandler value3 = new MouseEventHandler(this.AnnoPictureBox_MouseMove);
				EventHandler value4 = delegate(object a0, EventArgs a1)
				{
					this.AnnoPictureBox_Click(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs)a1);
				};
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseEnter -= value2;
					this._AnnoPictureBox.MouseMove -= value3;
					this._AnnoPictureBox.Click -= value4;
				}
				this._AnnoPictureBox = value;
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseEnter += value2;
					this._AnnoPictureBox.MouseMove += value3;
					this._AnnoPictureBox.Click += value4;
				}
			}
		}

		public bool NewAnnotation
		{
			get
			{
				return this._NewAnnotation;
			}
			set
			{
				this._NewAnnotation = value;
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
			}
		}

		public string HotSpotData
		{
			get
			{
				return this._HotSpotData;
			}
			set
			{
				this._HotSpotData = value;
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

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Name = "UCAnnoPictureBox";
			Size size = new Size(354, 303);
			this.Size = size;
			this.ResumeLayout(false);
		}

		public UCAnnoPictureBox()
		{
			base.Resize += new EventHandler(this.UCAnnoPictureBox_Resize);
			this.InitializeComponent();
			this.Init();
		}

		private void Init()
		{
			this.AnnoPictureBox = new AnnoPictureBox();
			this.AnnoPictureBox.Left = 0;
			this.AnnoPictureBox.Top = 0;
			this.AnnoPictureBox.AnnoCtrl.set_ToolTipControl(new ToolTip());
			this.AnnoPictureBox.Dock = DockStyle.None;
			this.AnnoPictureBox.AutoAnnotationCreated += new AnnoPictureBox.AutoAnnotationCreatedHandler(this.AutoAnnotationCreated);
			this.Controls.Add(this.AnnoPictureBox);
			this.miDelete = new ToolStripMenuItem("删除热点");
			this.miDelete.Click += new EventHandler(this.miDelete_Click);
			this.cmHotSpot = new ContextMenuStrip();
			this.cmHotSpot.Items.AddRange(new ToolStripItem[]
			{
				this.miDelete
			});
		}

		public void InitData()
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(this._ImageData, 0, this._ImageData.Length);
			this.AnnoPictureBox.Image = Image.FromStream(memoryStream);
			this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
			this.AnnoPictureBox.Location = this.GetImageLocation();
			this.InitAnnotateLayer();
			try
			{
				IEnumerator enumerator = this.AnnoPictureBox.AnnoCtrl.get_Layers().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Layer layer = (Layer)enumerator.Current;
					if (Operators.CompareString(layer.get_Name(), "EPRHotSpotLayer", false) == 0)
					{
						this.EPRHotSpotLayer = layer;
						try
						{
							IEnumerator enumerator2 = this.EPRHotSpotLayer.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Annotation annotation = (Annotation)enumerator2.Current;
								annotation.Lock();
								IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)annotation;
								iEPRHotSpot.AnnoMode = EPRAnnoMode.Edit;
							}
							continue;
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					if (Operators.CompareString(layer.get_Name(), "EPRAnnoLayer", false) == 0)
					{
						this.AnnoLayer = layer;
						try
						{
							IEnumerator enumerator3 = this.AnnoLayer.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								Annotation annotation2 = (Annotation)enumerator3.Current;
								annotation2.set_ContextMenuStrip(this.cmHotSpot);
							}
						}
						finally
						{
							IEnumerator enumerator3;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
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
			this.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.EPRHotSpotLayer);
		}

		public void SerilizeData()
		{
			this.SerializeAnnoData();
		}

		public void SerializeAnnoData()
		{
			if (this.AnnoLayer != null && this.AnnoLayer.Count > 0)
			{
				byte[] bytes = this.AnnoPictureBox.AnnoCtrl.Save(this.AnnoLayer, 0);
				this._AnnoData = Encoding.UTF8.GetString(bytes);
			}
			else
			{
				this._AnnoData = string.Empty;
			}
		}

		private void AnnoPictureBox_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && (this.AnnoPictureBox.Image != null & this.NewAnnotation))
			{
				this.NewAnnotation = false;
				this.Cursor = Cursors.Default;
			}
		}

		private void AnnoPictureBox_MouseEnter(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.NewAnnotation)
			{
				this.Cursor = Cursors.Cross;
			}
			else
			{
				this.Cursor = Cursors.Arrow;
			}
		}

		private void AnnoPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.NewAnnotation)
			{
				this.Cursor = Cursors.Cross;
			}
			else
			{
				if (!this.boolHotSpot)
				{
					this.Cursor = Cursors.Arrow;
				}
				this.boolHotSpot = false;
			}
		}

		private void miDelete_Click(object sender, EventArgs e)
		{
			this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().get_ParentLayer().Remove(this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation());
		}

		public void AddNewAnnotation(CustomIconAnnotation customAnnotation)
		{
			this.AnnoPictureBox.AnnoCtrl.get_CurrentLayer().Add(customAnnotation);
		}

		private void AutoAnnotationCreated(bool isAutoAnnoCreated)
		{
			this._NewAnnotation = isAutoAnnoCreated;
		}

		private void InitAnnotateLayer()
		{
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			string xmpAnnoData = this.GetXmpAnnoData(this._HotSpotData, this._AnnoData);
			if (string.IsNullOrEmpty(xmpAnnoData))
			{
				this.EPRHotSpotLayer = new Layer();
				this.EPRHotSpotLayer.set_Name("EPRHotSpotLayer");
				this.AnnoLayer = new Layer();
				this.AnnoLayer.set_Name("EPRAnnoLayer");
				this.AnnoPictureBox.AnnoCtrl.get_Layers().Add(this.EPRHotSpotLayer);
				this.AnnoPictureBox.AnnoCtrl.get_Layers().Add(this.AnnoLayer);
			}
			else
			{
				this.AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(xmpAnnoData), 0);
			}
		}

		private string GetXmpAnnoData(string strHotSpotData, string strAnnoData)
		{
			string result = string.Empty;
			bool flag = string.IsNullOrEmpty(strHotSpotData);
			bool flag2 = string.IsNullOrEmpty(strAnnoData);
			checked
			{
				if (!flag && !flag2)
				{
					int num = strAnnoData.IndexOf("<ann:Layer>");
					int num2 = strAnnoData.IndexOf("</ann:Layer>") + 12;
					string value = strAnnoData.Substring(num, num2 - num);
					int startIndex = strHotSpotData.IndexOf("</ann:Layer>") + 12;
					result = strHotSpotData.Insert(startIndex, value);
				}
				else if (flag && !flag2)
				{
					string value2 = "<ann:Layer><ann:Name>EPRHotSpotLayer</ann:Name><ann:EncryptedPassword></ann:EncryptedPassword><ann:Locked>False</ann:Locked><ann:Visible>True</ann:Visible><ann:AnnotationCollection></ann:AnnotationCollection></ann:Layer>";
					int startIndex2 = strAnnoData.IndexOf("<ann:Layer>");
					result = strAnnoData.Insert(startIndex2, value2);
				}
				else if (!flag && flag2)
				{
					string value3 = "<ann:Layer><ann:Name>EPRAnnoLayer</ann:Name><ann:EncryptedPassword></ann:EncryptedPassword><ann:Locked>False</ann:Locked><ann:Visible>True</ann:Visible><ann:AnnotationCollection></ann:AnnotationCollection></ann:Layer>";
					int startIndex3 = strHotSpotData.IndexOf("</ann:Layer>") + 12;
					result = strHotSpotData.Insert(startIndex3, value3);
				}
				return result;
			}
		}

		private Point GetImageLocation()
		{
			checked
			{
				int num = this.Size.Width - this.AnnoPictureBox.Size.Width;
				int num2 = this.Size.Height - this.AnnoPictureBox.Size.Height;
				num = Convert.ToInt32((double)num / 2.0);
				num2 = Convert.ToInt32((double)num2 / 2.0);
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

		private void UCAnnoPictureBox_Resize(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox == null)
			{
				return;
			}
			this.AnnoPictureBox.Location = this.GetImageLocation();
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__1(object a0, EventArgs a1)
		{
			this.AnnoPictureBox_Click(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs)a1);
		}
	}
}
