using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.design.metadatadesign;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCHotSpot : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("ToolPanel")]
		private Panel _ToolPanel;

		[AccessedThroughProperty("ImagePanel")]
		private Panel _ImagePanel;

		[AccessedThroughProperty("AnnoPBPanel")]
		private Panel _AnnoPBPanel;

		[AccessedThroughProperty("ToolTabs")]
		private TabControlAdv _ToolTabs;

		[AccessedThroughProperty("HotSpotTab")]
		private TabPageAdv _HotSpotTab;

		[AccessedThroughProperty("IconTab")]
		private TabPageAdv _IconTab;

		[AccessedThroughProperty("IconToolPanel")]
		private Panel _IconToolPanel;

		[AccessedThroughProperty("ToolSplitter")]
		private Splitter _ToolSplitter;

		[AccessedThroughProperty("HotSpotIL")]
		private ImageList _HotSpotIL;

		[AccessedThroughProperty("IconListPanel")]
		private Panel _IconListPanel;

		[AccessedThroughProperty("IconGV")]
		private GroupView _IconGV;

		[AccessedThroughProperty("IconIL")]
		private ImageList _IconIL;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("PropertyPanel")]
		private Panel _PropertyPanel;

		[AccessedThroughProperty("PGImage")]
		private PropertyGrid _PGImage;

		[AccessedThroughProperty("HotSpotGV")]
		private GroupView _HotSpotGV;

		private bool boolInsertHotSpot;

		private HotSpotType InsertHotSpotType;

		[AccessedThroughProperty("AnnoPictureBox")]
		private AnnoPictureBox _AnnoPictureBox;

		private ContextMenu cmHotSpot;

		private MenuItem miDelete;

		private MenuItem miLock;

		private ContextMenu cmIcon;

		private MenuItem miIconDelete;

		private MenuItem miIconInsert;

		private EPRHotSpotProperty _EPRHotSpotProperty;

		private EPRIconProperty _EPRIconProperty;

		private Layer CurrentHotSpotLayer;

		private Layer CurrentAnnotationLayer;

		private int IconGVIndex;

		private int CurrentIconIndex;

		private byte[] _ImageData;

		private string _HotSpotData;

		private string _IconAnnoData;

		private IconAnnotationCollection _IconAnnoCollection;

		internal virtual Panel ToolPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolPanel = value;
			}
		}

		internal virtual Panel ImagePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImagePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImagePanel = value;
			}
		}

		internal virtual Panel AnnoPBPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AnnoPBPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AnnoPictureBox_Resize);
				if (this._AnnoPBPanel != null)
				{
					this._AnnoPBPanel.Resize -= value2;
				}
				this._AnnoPBPanel = value;
				if (this._AnnoPBPanel != null)
				{
					this._AnnoPBPanel.Resize += value2;
				}
			}
		}

		internal virtual TabControlAdv ToolTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTabs = value;
			}
		}

		internal virtual TabPageAdv HotSpotTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HotSpotTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HotSpotTab = value;
			}
		}

		internal virtual TabPageAdv IconTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IconTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IconTab = value;
			}
		}

		internal virtual Panel IconToolPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IconToolPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IconToolPanel = value;
			}
		}

		internal virtual Splitter ToolSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolSplitter = value;
			}
		}

		internal virtual ImageList HotSpotIL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HotSpotIL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HotSpotIL = value;
			}
		}

		internal virtual Panel IconListPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IconListPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IconListPanel = value;
			}
		}

		internal virtual GroupView IconGV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IconGV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.IconGV_MouseDown);
				EventHandler eventHandler = new EventHandler(this.IconGV_GroupViewItemSelected);
				if (this._IconGV != null)
				{
					this._IconGV.MouseDown -= value2;
					this._IconGV.remove_GroupViewItemSelected(eventHandler);
				}
				this._IconGV = value;
				if (this._IconGV != null)
				{
					this._IconGV.MouseDown += value2;
					this._IconGV.add_GroupViewItemSelected(eventHandler);
				}
			}
		}

		internal virtual ImageList IconIL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IconIL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IconIL = value;
			}
		}

		internal virtual Splitter Splitter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Splitter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter1 = value;
			}
		}

		internal virtual Panel PropertyPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PropertyPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PropertyPanel = value;
			}
		}

		internal virtual PropertyGrid PGImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PGImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PGImage = value;
			}
		}

		internal virtual GroupView HotSpotGV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HotSpotGV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HotSpotGV_GroupViewItemSelected);
				if (this._HotSpotGV != null)
				{
					this._HotSpotGV.remove_GroupViewItemSelected(eventHandler);
				}
				this._HotSpotGV = value;
				if (this._HotSpotGV != null)
				{
					this._HotSpotGV.add_GroupViewItemSelected(eventHandler);
				}
			}
		}

		private virtual AnnoPictureBox AnnoPictureBox
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
				EventHandler value3 = new EventHandler(this.AnnoPictureBox_MouseLeave);
				MouseEventHandler value4 = new MouseEventHandler(this.AnnoPictureBox_MouseDown);
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseEnter -= value2;
					this._AnnoPictureBox.MouseLeave -= value3;
					this._AnnoPictureBox.MouseDown -= value4;
				}
				this._AnnoPictureBox = value;
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseEnter += value2;
					this._AnnoPictureBox.MouseLeave += value3;
					this._AnnoPictureBox.MouseDown += value4;
				}
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

		public string IconAnnoData
		{
			get
			{
				return this._IconAnnoData;
			}
			set
			{
				this._IconAnnoData = value;
			}
		}

		public bool ShowIcon
		{
			get
			{
				return this.IconTab.get_Visible();
			}
			set
			{
				this.IconTab.set_Visible(value);
			}
		}

		public DCHotSpot()
		{
			this._IconAnnoCollection = new IconAnnotationCollection();
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
			this.ToolPanel = new Panel();
			this.PropertyPanel = new Panel();
			this.PGImage = new PropertyGrid();
			this.Splitter1 = new Splitter();
			this.ToolTabs = new TabControlAdv();
			this.HotSpotTab = new TabPageAdv();
			this.HotSpotGV = new GroupView();
			this.HotSpotIL = new ImageList(this.components);
			this.IconTab = new TabPageAdv();
			this.IconToolPanel = new Panel();
			this.IconListPanel = new Panel();
			this.IconGV = new GroupView();
			this.IconIL = new ImageList(this.components);
			this.ToolSplitter = new Splitter();
			this.ImagePanel = new Panel();
			this.AnnoPBPanel = new Panel();
			this.ToolPanel.SuspendLayout();
			this.PropertyPanel.SuspendLayout();
			this.ToolTabs.BeginInit();
			this.ToolTabs.SuspendLayout();
			this.HotSpotTab.SuspendLayout();
			this.IconTab.SuspendLayout();
			this.IconToolPanel.SuspendLayout();
			this.IconListPanel.SuspendLayout();
			this.ImagePanel.SuspendLayout();
			this.SuspendLayout();
			this.ToolPanel.BorderStyle = BorderStyle.Fixed3D;
			this.ToolPanel.Controls.Add(this.PropertyPanel);
			this.ToolPanel.Controls.Add(this.Splitter1);
			this.ToolPanel.Controls.Add(this.ToolTabs);
			this.ToolPanel.Dock = DockStyle.Right;
			Control arg_19E_0 = this.ToolPanel;
			Point location = new Point(360, 0);
			arg_19E_0.Location = location;
			this.ToolPanel.Name = "ToolPanel";
			Control arg_1CB_0 = this.ToolPanel;
			Size size = new Size(140, 400);
			arg_1CB_0.Size = size;
			this.ToolPanel.TabIndex = 0;
			this.PropertyPanel.Controls.Add(this.PGImage);
			this.PropertyPanel.Dock = DockStyle.Fill;
			Control arg_212_0 = this.PropertyPanel;
			location = new Point(0, 205);
			arg_212_0.Location = location;
			this.PropertyPanel.Name = "PropertyPanel";
			Control arg_23F_0 = this.PropertyPanel;
			size = new Size(136, 191);
			arg_23F_0.Size = size;
			this.PropertyPanel.TabIndex = 2;
			this.PGImage.Dock = DockStyle.Fill;
			this.PGImage.LineColor = SystemColors.ScrollBar;
			Control arg_27C_0 = this.PGImage;
			location = new Point(0, 0);
			arg_27C_0.Location = location;
			this.PGImage.Name = "PGImage";
			Control arg_2A9_0 = this.PGImage;
			size = new Size(136, 191);
			arg_2A9_0.Size = size;
			this.PGImage.TabIndex = 0;
			this.PGImage.ToolbarVisible = false;
			this.Splitter1.Dock = DockStyle.Top;
			Control arg_2E6_0 = this.Splitter1;
			location = new Point(0, 200);
			arg_2E6_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_30F_0 = this.Splitter1;
			size = new Size(136, 5);
			arg_30F_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.ToolTabs.set_BorderStyle(BorderStyle.None);
			this.ToolTabs.Controls.Add(this.HotSpotTab);
			this.ToolTabs.Controls.Add(this.IconTab);
			this.ToolTabs.Dock = DockStyle.Top;
			this.ToolTabs.set_ImageList(this.HotSpotIL);
			Control arg_391_0 = this.ToolTabs;
			location = new Point(0, 0);
			arg_391_0.Location = location;
			this.ToolTabs.Name = "ToolTabs";
			Control arg_3BE_0 = this.ToolTabs;
			size = new Size(136, 200);
			arg_3BE_0.Size = size;
			this.ToolTabs.TabIndex = 0;
			this.ToolTabs.set_TabStyle(typeof(TabRenderer2D));
			this.HotSpotTab.Controls.Add(this.HotSpotGV);
			Control arg_40B_0 = this.HotSpotTab;
			location = new Point(0, 24);
			arg_40B_0.Location = location;
			this.HotSpotTab.Name = "HotSpotTab";
			Control arg_438_0 = this.HotSpotTab;
			size = new Size(136, 176);
			arg_438_0.Size = size;
			this.HotSpotTab.set_TabIndex(1);
			this.HotSpotTab.set_Text("热点");
			this.HotSpotTab.set_ThemesEnabled(false);
			this.HotSpotGV.set_BorderStyle(BorderStyle.None);
			this.HotSpotGV.Dock = DockStyle.Fill;
			this.HotSpotGV.set_LargeImageList(null);
			Control arg_499_0 = this.HotSpotGV;
			location = new Point(0, 0);
			arg_499_0.Location = location;
			this.HotSpotGV.Name = "HotSpotGV";
			Control arg_4C6_0 = this.HotSpotGV;
			size = new Size(136, 176);
			arg_4C6_0.Size = size;
			this.HotSpotGV.set_SmallImageList(this.HotSpotIL);
			this.HotSpotGV.set_SmallImageView(true);
			this.HotSpotGV.TabIndex = 1;
			this.HotSpotIL.ColorDepth = ColorDepth.Depth8Bit;
			ImageList arg_512_0 = this.HotSpotIL;
			size = new Size(16, 16);
			arg_512_0.ImageSize = size;
			this.HotSpotIL.TransparentColor = Color.Transparent;
			this.IconTab.Controls.Add(this.IconToolPanel);
			Control arg_54E_0 = this.IconTab;
			location = new Point(0, 24);
			arg_54E_0.Location = location;
			this.IconTab.Name = "IconTab";
			Control arg_57B_0 = this.IconTab;
			size = new Size(136, 176);
			arg_57B_0.Size = size;
			this.IconTab.set_TabIndex(1);
			this.IconTab.set_Text("图示");
			this.IconTab.set_ThemesEnabled(false);
			this.IconToolPanel.Controls.Add(this.IconListPanel);
			this.IconToolPanel.Dock = DockStyle.Fill;
			Control arg_5DA_0 = this.IconToolPanel;
			location = new Point(0, 0);
			arg_5DA_0.Location = location;
			this.IconToolPanel.Name = "IconToolPanel";
			Control arg_607_0 = this.IconToolPanel;
			size = new Size(136, 176);
			arg_607_0.Size = size;
			this.IconToolPanel.TabIndex = 0;
			this.IconListPanel.Controls.Add(this.IconGV);
			this.IconListPanel.Dock = DockStyle.Fill;
			Control arg_64A_0 = this.IconListPanel;
			location = new Point(0, 0);
			arg_64A_0.Location = location;
			this.IconListPanel.Name = "IconListPanel";
			Control arg_677_0 = this.IconListPanel;
			size = new Size(136, 176);
			arg_677_0.Size = size;
			this.IconListPanel.TabIndex = 1;
			this.IconGV.set_BorderStyle(BorderStyle.None);
			this.IconGV.Dock = DockStyle.Fill;
			this.IconGV.set_LargeImageList(null);
			Control arg_6BC_0 = this.IconGV;
			location = new Point(0, 0);
			arg_6BC_0.Location = location;
			this.IconGV.Name = "IconGV";
			Control arg_6E9_0 = this.IconGV;
			size = new Size(136, 176);
			arg_6E9_0.Size = size;
			this.IconGV.set_SmallImageList(this.IconIL);
			this.IconGV.set_SmallImageView(true);
			this.IconGV.TabIndex = 0;
			this.IconIL.ColorDepth = ColorDepth.Depth8Bit;
			ImageList arg_735_0 = this.IconIL;
			size = new Size(16, 16);
			arg_735_0.ImageSize = size;
			this.IconIL.TransparentColor = Color.Transparent;
			this.ToolSplitter.Dock = DockStyle.Right;
			Control arg_76A_0 = this.ToolSplitter;
			location = new Point(352, 0);
			arg_76A_0.Location = location;
			this.ToolSplitter.Name = "ToolSplitter";
			Control arg_793_0 = this.ToolSplitter;
			size = new Size(8, 400);
			arg_793_0.Size = size;
			this.ToolSplitter.TabIndex = 1;
			this.ToolSplitter.TabStop = false;
			this.ImagePanel.Controls.Add(this.AnnoPBPanel);
			this.ImagePanel.Dock = DockStyle.Fill;
			Control arg_7E2_0 = this.ImagePanel;
			location = new Point(0, 0);
			arg_7E2_0.Location = location;
			this.ImagePanel.Name = "ImagePanel";
			Control arg_80F_0 = this.ImagePanel;
			size = new Size(352, 400);
			arg_80F_0.Size = size;
			this.ImagePanel.TabIndex = 2;
			this.AnnoPBPanel.AutoScroll = true;
			this.AnnoPBPanel.BorderStyle = BorderStyle.Fixed3D;
			this.AnnoPBPanel.Dock = DockStyle.Fill;
			Control arg_854_0 = this.AnnoPBPanel;
			location = new Point(0, 0);
			arg_854_0.Location = location;
			this.AnnoPBPanel.Name = "AnnoPBPanel";
			Control arg_881_0 = this.AnnoPBPanel;
			size = new Size(352, 400);
			arg_881_0.Size = size;
			this.AnnoPBPanel.TabIndex = 1;
			this.Controls.Add(this.ImagePanel);
			this.Controls.Add(this.ToolSplitter);
			this.Controls.Add(this.ToolPanel);
			this.Name = "DCHotSpot";
			size = new Size(500, 400);
			this.Size = size;
			this.ToolPanel.ResumeLayout(false);
			this.PropertyPanel.ResumeLayout(false);
			this.ToolTabs.EndInit();
			this.ToolTabs.ResumeLayout(false);
			this.HotSpotTab.ResumeLayout(false);
			this.IconTab.ResumeLayout(false);
			this.IconToolPanel.ResumeLayout(false);
			this.IconListPanel.ResumeLayout(false);
			this.ImagePanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.HotSpotGV.get_GroupViewItems().AddRange(new GroupViewItem[]
			{
				new GroupViewItem("指针", 0),
				new GroupViewItem("自由热点", 1),
				new GroupViewItem("矩形型热点", 2),
				new GroupViewItem("椭圆热点", 3),
				new GroupViewItem("多边热点", 4)
			});
			this.AnnoPictureBox = new AnnoPictureBox();
			this.AnnoPictureBox.Left = 0;
			this.AnnoPictureBox.Top = 0;
			this.AnnoPictureBox.AllowDrop = true;
			this.AnnoPictureBox.Dock = DockStyle.None;
			this.AnnoPBPanel.Controls.Add(this.AnnoPictureBox);
			this.AnnoPictureBox.AnnoCtrl.add_SelectionChanged(new EventHandler(this.SelectedAnnotation_Changed));
			this.miDelete = new MenuItem("删除热点");
			this.miDelete.Click += new EventHandler(this.miDelete_Click);
			this.miLock = new MenuItem("锁定热点");
			this.miLock.Click += new EventHandler(this.miLock_Click);
			this.cmHotSpot = new ContextMenu();
			this.cmHotSpot.MenuItems.Add(this.miDelete);
			this.cmHotSpot.MenuItems.Add(this.miLock);
			this.cmIcon = new ContextMenu();
			this.miIconDelete = new MenuItem("删除图示");
			this.miIconInsert = new MenuItem("添加图示");
			this.miIconDelete.Click += new EventHandler(this.miIconDelete_Click);
			this.miIconInsert.Click += new EventHandler(this.miIconInsert_Click);
			this.cmIcon.MenuItems.Add(this.miIconInsert);
			this.cmIcon.MenuItems.Add(this.miIconDelete);
			this.IconGV.ContextMenu = this.cmIcon;
			this._EPRHotSpotProperty = new EPRHotSpotProperty();
			this._EPRIconProperty = new EPRIconProperty();
			this._EPRIconProperty.IconPropertyChanged += new EPRIconProperty.IconPropertyChangedEventHandler(this.EPRIconProperty_IconPropertyChanged);
		}

		public void InitData()
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(this._ImageData, 0, this._ImageData.Length);
			this.AnnoPictureBox.Image = Image.FromStream(memoryStream);
			this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
			this.AnnoPictureBox.Location = this.GetImageLocation();
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			if (this._HotSpotData != null && Operators.CompareString(this._HotSpotData, "", false) != 0)
			{
				this.AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(this._HotSpotData), 0);
			}
			else
			{
				this.CurrentHotSpotLayer = new Layer();
				this.CurrentHotSpotLayer.set_Name("EPRHotSpotLayer");
				this.AnnoPictureBox.AnnoCtrl.get_Layers().Add(this.CurrentHotSpotLayer);
			}
			try
			{
				IEnumerator enumerator = this.AnnoPictureBox.AnnoCtrl.get_Layers().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Layer layer = (Layer)enumerator.Current;
					if (Operators.CompareString(layer.get_Name(), "EPRHotSpotLayer", false) == 0)
					{
						this.CurrentHotSpotLayer = layer;
						try
						{
							IEnumerator enumerator2 = this.CurrentHotSpotLayer.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Annotation annotation = (Annotation)enumerator2.Current;
								annotation.set_ContextMenu(this.cmHotSpot);
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
						this.CurrentAnnotationLayer = layer;
						try
						{
							IEnumerator enumerator3 = this.CurrentAnnotationLayer.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								Annotation annotation2 = (Annotation)enumerator3.Current;
								annotation2.set_ContextMenu(this.cmHotSpot);
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
			this.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.CurrentHotSpotLayer);
			this.PGImage.SelectedObject = null;
			this.IconGV.get_GroupViewItems().Clear();
			this.DeserializeIconAnnoData();
			if (this.IconGV.get_GroupViewItems().Count > 0)
			{
				this.IconGV.set_SelectedItem(0);
			}
		}

		private Point GetImageLocation()
		{
			checked
			{
				int num = Convert.ToInt32((double)(this.AnnoPBPanel.Width - this.AnnoPictureBox.Width) / 2.0);
				int num2 = Convert.ToInt32((double)(this.AnnoPBPanel.Height - this.AnnoPictureBox.Height) / 2.0);
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

		public void SerilizeData()
		{
			this.SerializeHotSpotData();
			this.SerializeIconAnnoData();
		}

		private void DeserializeIconAnnoData()
		{
			if (this._IconAnnoData != null)
			{
				if (this._IconAnnoData.Equals(string.Empty))
				{
					return;
				}
				StringReader input = new StringReader(this._IconAnnoData);
				XmlTextReader xmlTextReader = new XmlTextReader(input);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				while (xmlTextReader.Read())
				{
					if (Operators.CompareString(xmlTextReader.Name, "IconAnnotation", false) == 0 & xmlTextReader.IsStartElement())
					{
						IconAnnotation iconAnnotation = new IconAnnotation();
						iconAnnotation.XMLDeserialize(xmlTextReader);
						this._IconAnnoCollection.Add(iconAnnotation);
					}
					else if (Operators.CompareString(xmlTextReader.Name, "IconAnnotates", false) == 0 & xmlTextReader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
				IconAnnotationEnumerator enumerator = this._IconAnnoCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IconAnnotation iconAnnotation2 = (IconAnnotation)enumerator.Current;
					this.IconIL.Images.Add(iconAnnotation2.GetIconImage());
					this.IconGV.get_GroupViewItems().AddRange(new GroupViewItem[]
					{
						new GroupViewItem(iconAnnotation2.IconName, checked(this.IconIL.Images.Count - 1))
					});
				}
			}
		}

		private void SerializeIconAnnoData()
		{
			if (this._IconAnnoCollection.Count == 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringWriter stringWriter = new StringWriter(stringBuilder);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			xmlTextWriter.Formatting = Formatting.None;
			xmlTextWriter.WriteStartElement("IconAnnotates");
			IconAnnotationEnumerator enumerator = this._IconAnnoCollection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IconAnnotation iconAnnotation = (IconAnnotation)enumerator.Current;
				iconAnnotation.XMLSerialize(xmlTextWriter);
			}
			xmlTextWriter.WriteEndElement();
			this._IconAnnoData = stringBuilder.ToString();
			xmlTextWriter.Close();
			stringWriter.Close();
		}

		public void SerializeHotSpotData()
		{
			if (this.AnnoPictureBox.Image == null)
			{
				this._HotSpotData = string.Empty;
				return;
			}
			if (this.CurrentHotSpotLayer == null || this.CurrentHotSpotLayer.Count == 0)
			{
				this._HotSpotData = string.Empty;
				return;
			}
			byte[] bytes = this.AnnoPictureBox.AnnoCtrl.Save(this.CurrentHotSpotLayer, 0);
			this._HotSpotData = Encoding.UTF8.GetString(bytes);
		}

		private void HotSpotGV_GroupViewItemSelected(object sender, EventArgs e)
		{
			if (this.HotSpotGV.get_SelectedItem() == 0)
			{
				this.boolInsertHotSpot = false;
			}
			else if (this.HotSpotGV.get_SelectedItem() == 1)
			{
				this.boolInsertHotSpot = true;
				this.InsertHotSpotType = HotSpotType.FreeHand;
			}
			else if (this.HotSpotGV.get_SelectedItem() == 2)
			{
				this.boolInsertHotSpot = true;
				this.InsertHotSpotType = HotSpotType.RectAngular;
			}
			else if (this.HotSpotGV.get_SelectedItem() == 3)
			{
				this.boolInsertHotSpot = true;
				this.InsertHotSpotType = HotSpotType.Ellipse;
			}
			else if (this.HotSpotGV.get_SelectedItem() == 4)
			{
				this.boolInsertHotSpot = true;
				this.InsertHotSpotType = HotSpotType.Polygons;
			}
		}

		private void AnnoPictureBox_MouseEnter(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.boolInsertHotSpot)
			{
				this.Cursor = Cursors.Cross;
				switch (this.InsertHotSpotType)
				{
				case HotSpotType.FreeHand:
				{
					EPRHotSpotFreeHand ePRHotSpotFreeHand = new EPRHotSpotFreeHand();
					ePRHotSpotFreeHand.AnnoMode = EPRAnnoMode.Design;
					this.AnnoPictureBox.AddAnnotaion(ePRHotSpotFreeHand);
					ePRHotSpotFreeHand.set_ContextMenu(this.cmHotSpot);
					this.HotSpotGV.set_SelectedItem(0);
					break;
				}
				case HotSpotType.RectAngular:
				{
					EPRHotSpotRectAngular ePRHotSpotRectAngular = new EPRHotSpotRectAngular();
					ePRHotSpotRectAngular.AnnoMode = EPRAnnoMode.Design;
					this.AnnoPictureBox.AddAnnotaion(ePRHotSpotRectAngular);
					ePRHotSpotRectAngular.set_ContextMenu(this.cmHotSpot);
					this.HotSpotGV.set_SelectedItem(0);
					break;
				}
				case HotSpotType.Ellipse:
				{
					EPRHotSpotEllipse ePRHotSpotEllipse = new EPRHotSpotEllipse();
					ePRHotSpotEllipse.AnnoMode = EPRAnnoMode.Design;
					this.AnnoPictureBox.AddAnnotaion(ePRHotSpotEllipse);
					ePRHotSpotEllipse.set_ContextMenu(this.cmHotSpot);
					this.HotSpotGV.set_SelectedItem(0);
					break;
				}
				case HotSpotType.Polygons:
				{
					EPRHotSpotPolygon ePRHotSpotPolygon = new EPRHotSpotPolygon();
					ePRHotSpotPolygon.AnnoMode = EPRAnnoMode.Design;
					this.AnnoPictureBox.AddAnnotaion(ePRHotSpotPolygon);
					ePRHotSpotPolygon.set_ContextMenu(this.cmHotSpot);
					this.HotSpotGV.set_SelectedItem(0);
					break;
				}
				}
			}
			else
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void AnnoPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.boolInsertHotSpot)
			{
				this.boolInsertHotSpot = false;
				this.Cursor = Cursors.Default;
			}
		}

		private void AnnoPictureBox_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void AnnoPictureBox_Resize(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox == null)
			{
				return;
			}
			this.AnnoPictureBox.Location = this.GetImageLocation();
		}

		private void miDelete_Click(object sender, EventArgs e)
		{
			this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().get_ParentLayer().Remove(this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation());
		}

		private void miLock_Click(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().get_Locked())
			{
				this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().Unlock();
			}
			else
			{
				this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().Lock();
			}
		}

		private void miIconDelete_Click(object sender, EventArgs e)
		{
			if (this.IconGVIndex > -1)
			{
				this.PGImage.SelectedObject = null;
				this.IconGV.get_GroupViewItems().RemoveAt(this.IconGVIndex);
				this._IconAnnoCollection.RemoveAt(this.IconGVIndex);
				this.IconIL.Images.RemoveAt(this.IconGVIndex);
			}
		}

		private void miIconInsert_Click(object sender, EventArgs e)
		{
			IconAnnotation iconAnnotation = new IconAnnotation();
			iconAnnotation.IconName = "新建图示";
			iconAnnotation.DrawImage = false;
			iconAnnotation.DrawBorder = false;
			iconAnnotation.DrawHatch = true;
			iconAnnotation.BackColor = Color.White;
			iconAnnotation.ForeColor = Color.Black;
			iconAnnotation.HatchStyle = HatchStyle.BackwardDiagonal;
			this.IconIL.Images.Add(iconAnnotation.GetIconImage());
			this._IconAnnoCollection.Add(iconAnnotation);
			checked
			{
				this.IconGV.get_GroupViewItems().AddRange(new GroupViewItem[]
				{
					new GroupViewItem(iconAnnotation.IconName, this.IconIL.Images.Count - 1)
				});
				this.IconGV.set_SelectedItem(this.IconGV.get_GroupViewItems().Count - 1);
			}
		}

		private void SelectedAnnotation_Changed(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() == null)
			{
				this.PGImage.SelectedObject = null;
			}
			else if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is IEPRHotSpot)
			{
				this._EPRHotSpotProperty.EPRHotSpot = (IEPRHotSpot)this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.PGImage.SelectedObject = this._EPRHotSpotProperty;
			}
		}

		private void IconGV_GroupViewItemSelected(object sender, EventArgs e)
		{
			if (this.IconGV.get_SelectedItem() == -1)
			{
				this.PGImage.SelectedObject = null;
			}
			else
			{
				this.CurrentIconIndex = this.IconGV.get_SelectedItem();
				IconAnnotation iconAnnotation = this._IconAnnoCollection[this.CurrentIconIndex];
				this._EPRIconProperty.IconAnnotation = iconAnnotation;
				this.PGImage.SelectedObject = this._EPRIconProperty;
			}
		}

		private void EPRIconProperty_IconPropertyChanged()
		{
			this.IconIL.Images[this.CurrentIconIndex] = this._IconAnnoCollection[this.CurrentIconIndex].GetIconImage();
			this.IconGV.get_GroupViewItems().get_Item(this.CurrentIconIndex).set_Text(this._IconAnnoCollection[this.CurrentIconIndex].IconName);
		}

		private void IconGV_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.IconGVIndex = this.IconGV.get_SelectedItem();
			}
		}
	}
}
