using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIImageAnnotateProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("ToolPanel")]
		private Panel _ToolPanel;

		[AccessedThroughProperty("ImagePanel")]
		private Panel _ImagePanel;

		[AccessedThroughProperty("ImageToolPanel")]
		private Panel _ImageToolPanel;

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

		[AccessedThroughProperty("ImageToolBar")]
		private ToolBar _ImageToolBar;

		[AccessedThroughProperty("ButtonIL")]
		private ImageList _ButtonIL;

		[AccessedThroughProperty("btnNewImage")]
		private ToolBarButton _btnNewImage;

		[AccessedThroughProperty("IconListPanel")]
		private Panel _IconListPanel;

		[AccessedThroughProperty("IconGV")]
		private GroupView _IconGV;

		[AccessedThroughProperty("IconIL")]
		private ImageList _IconIL;

		[AccessedThroughProperty("btnProperty")]
		private ToolBarButton _btnProperty;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("PropertyPanel")]
		private Panel _PropertyPanel;

		[AccessedThroughProperty("PGImage")]
		private PropertyGrid _PGImage;

		[AccessedThroughProperty("HotSpotGV")]
		private GroupView _HotSpotGV;

		private MIImageAnnotate _MIImageAnnotate;

		private NIImageAnnotate _NIImageAnnotate;

		[AccessedThroughProperty("AnnoPictureBox")]
		private AnnoPictureBox _AnnoPictureBox;

		private OpenFileDialog objOpenFileDialog;

		private bool boolInsertHotSpot;

		private HotSpotType InsertHotSpotType;

		private ContextMenu cmHotSpot;

		private MenuItem miDelete;

		private MenuItem miLock;

		private ContextMenu cmIcon;

		private MenuItem miIconDelete;

		private MenuItem miIconInsert;

		private EPRHotSpotProperty _EPRHotSpotProperty;

		private EPRIconProperty _EPRIconProperty;

		private MetaItemPropertyWrap _MetaItemProperty;

		private int CurrentIconIndex;

		private Layer CurrentHotSpotLayer;

		private Layer CurrentAnnotationLayer;

		private int IconGVIndex;

		public MetaItemTree MetaItemTree;

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

		internal virtual Panel ImageToolPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageToolPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageToolPanel = value;
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
				this._AnnoPBPanel = value;
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

		internal virtual ToolBar ImageToolBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageToolBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolBarButtonClickEventHandler value2 = new ToolBarButtonClickEventHandler(this.ImageToolBar_ButtonClick);
				if (this._ImageToolBar != null)
				{
					this._ImageToolBar.ButtonClick -= value2;
				}
				this._ImageToolBar = value;
				if (this._ImageToolBar != null)
				{
					this._ImageToolBar.ButtonClick += value2;
				}
			}
		}

		internal virtual ImageList ButtonIL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonIL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonIL = value;
			}
		}

		internal virtual ToolBarButton btnNewImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNewImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnNewImage = value;
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

		internal virtual ToolBarButton btnProperty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnProperty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnProperty = value;
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
				DragEventHandler value2 = new DragEventHandler(this.AnnoPictureBox_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.AnnoPictureBox_DragEnter);
				EventHandler value4 = new EventHandler(this.AnnoPictureBox_MouseLeave);
				MouseEventHandler value5 = new MouseEventHandler(this.AnnoPictureBox_MouseDown);
				EventHandler value6 = new EventHandler(this.AnnoPictureBox_MouseEnter);
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.DragDrop -= value2;
					this._AnnoPictureBox.DragEnter -= value3;
					this._AnnoPictureBox.MouseLeave -= value4;
					this._AnnoPictureBox.MouseDown -= value5;
					this._AnnoPictureBox.MouseEnter -= value6;
				}
				this._AnnoPictureBox = value;
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.DragDrop += value2;
					this._AnnoPictureBox.DragEnter += value3;
					this._AnnoPictureBox.MouseLeave += value4;
					this._AnnoPictureBox.MouseDown += value5;
					this._AnnoPictureBox.MouseEnter += value6;
				}
			}
		}

		public MIImageAnnotate MIImageAnnotate
		{
			get
			{
				return this._MIImageAnnotate;
			}
			set
			{
				if (value != null)
				{
					this._MIImageAnnotate = value;
					this._NIImageAnnotate = (NIImageAnnotate)this._MIImageAnnotate.BindInstanceItem;
					this._MIImageAnnotate.XMLEvent += new MIImageAnnotate.XMLEventEventHandler(this.SerializeImageAnno);
					this.DeSerializeImageAnno();
					this.PGImage.SelectedObject = null;
					this.IconGV.get_GroupViewItems().Clear();
					IconAnnotationEnumerator enumerator = this._MIImageAnnotate.IconAnnotates.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IconAnnotation iconAnnotation = (IconAnnotation)enumerator.Current;
						this.IconIL.Images.Add(iconAnnotation.GetIconImage());
						this.IconGV.get_GroupViewItems().AddRange(new GroupViewItem[]
						{
							new GroupViewItem(iconAnnotation.IconName, checked(this.IconIL.Images.Count - 1))
						});
					}
					if (this.IconGV.get_GroupViewItems().Count > 0)
					{
						this.IconGV.set_SelectedItem(0);
					}
				}
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

		public MIImageAnnotateProperty()
		{
			base.ParentChanged += new EventHandler(this.MIImageAnnotateProperty_ParentChanged);
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
			ResourceManager resourceManager = new ResourceManager(typeof(MIImageAnnotateProperty));
			this.ToolPanel = new Panel();
			this.ToolTabs = new TabControlAdv();
			this.HotSpotTab = new TabPageAdv();
			this.IconTab = new TabPageAdv();
			this.IconToolPanel = new Panel();
			this.IconListPanel = new Panel();
			this.IconGV = new GroupView();
			this.IconIL = new ImageList(this.components);
			this.HotSpotIL = new ImageList(this.components);
			this.ButtonIL = new ImageList(this.components);
			this.ToolSplitter = new Splitter();
			this.ImagePanel = new Panel();
			this.AnnoPBPanel = new Panel();
			this.ImageToolPanel = new Panel();
			this.ImageToolBar = new ToolBar();
			this.btnNewImage = new ToolBarButton();
			this.btnProperty = new ToolBarButton();
			this.Splitter1 = new Splitter();
			this.PropertyPanel = new Panel();
			this.PGImage = new PropertyGrid();
			this.HotSpotGV = new GroupView();
			this.ToolPanel.SuspendLayout();
			this.ToolTabs.SuspendLayout();
			this.HotSpotTab.SuspendLayout();
			this.IconTab.SuspendLayout();
			this.IconToolPanel.SuspendLayout();
			this.IconListPanel.SuspendLayout();
			this.ImagePanel.SuspendLayout();
			this.ImageToolPanel.SuspendLayout();
			this.PropertyPanel.SuspendLayout();
			this.SuspendLayout();
			this.ToolPanel.Controls.Add(this.PropertyPanel);
			this.ToolPanel.Controls.Add(this.Splitter1);
			this.ToolPanel.Controls.Add(this.ToolTabs);
			this.ToolPanel.Dock = DockStyle.Right;
			Control arg_1DF_0 = this.ToolPanel;
			Point location = new Point(360, 0);
			arg_1DF_0.Location = location;
			this.ToolPanel.Name = "ToolPanel";
			Control arg_20C_0 = this.ToolPanel;
			Size size = new Size(140, 400);
			arg_20C_0.Size = size;
			this.ToolPanel.TabIndex = 0;
			this.ToolTabs.set_ActiveTabFont(new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
			this.ToolTabs.set_BorderStyle(BorderStyle.None);
			this.ToolTabs.Controls.Add(this.HotSpotTab);
			this.ToolTabs.Controls.Add(this.IconTab);
			this.ToolTabs.Dock = DockStyle.Top;
			this.ToolTabs.set_ImageList(this.HotSpotIL);
			Control arg_29F_0 = this.ToolTabs;
			location = new Point(0, 0);
			arg_29F_0.Location = location;
			this.ToolTabs.Name = "ToolTabs";
			Control arg_2CC_0 = this.ToolTabs;
			size = new Size(140, 200);
			arg_2CC_0.Size = size;
			this.ToolTabs.TabIndex = 0;
			this.ToolTabs.set_TabStyle(typeof(TabRenderer2D));
			this.HotSpotTab.Controls.Add(this.HotSpotGV);
			Control arg_319_0 = this.HotSpotTab;
			location = new Point(0, 24);
			arg_319_0.Location = location;
			this.HotSpotTab.Name = "HotSpotTab";
			Control arg_346_0 = this.HotSpotTab;
			size = new Size(140, 176);
			arg_346_0.Size = size;
			this.HotSpotTab.set_TabIndex(0);
			this.HotSpotTab.set_Text("热点");
			this.HotSpotTab.set_ThemesEnabled(false);
			this.IconTab.Controls.Add(this.IconToolPanel);
			Control arg_39A_0 = this.IconTab;
			location = new Point(0, 24);
			arg_39A_0.Location = location;
			this.IconTab.Name = "IconTab";
			Control arg_3C7_0 = this.IconTab;
			size = new Size(140, 176);
			arg_3C7_0.Size = size;
			this.IconTab.set_TabIndex(1);
			this.IconTab.set_Text("图示");
			this.IconTab.set_ThemesEnabled(false);
			this.IconToolPanel.Controls.Add(this.IconListPanel);
			this.IconToolPanel.Dock = DockStyle.Fill;
			Control arg_426_0 = this.IconToolPanel;
			location = new Point(0, 0);
			arg_426_0.Location = location;
			this.IconToolPanel.Name = "IconToolPanel";
			Control arg_453_0 = this.IconToolPanel;
			size = new Size(140, 176);
			arg_453_0.Size = size;
			this.IconToolPanel.TabIndex = 0;
			this.IconListPanel.Controls.Add(this.IconGV);
			this.IconListPanel.Dock = DockStyle.Fill;
			Control arg_496_0 = this.IconListPanel;
			location = new Point(0, 0);
			arg_496_0.Location = location;
			this.IconListPanel.Name = "IconListPanel";
			Control arg_4C3_0 = this.IconListPanel;
			size = new Size(140, 176);
			arg_4C3_0.Size = size;
			this.IconListPanel.TabIndex = 1;
			this.IconGV.set_BorderStyle(BorderStyle.None);
			this.IconGV.Dock = DockStyle.Fill;
			this.IconGV.set_LargeImageList(null);
			Control arg_508_0 = this.IconGV;
			location = new Point(0, 0);
			arg_508_0.Location = location;
			this.IconGV.Name = "IconGV";
			this.IconGV.set_SelectedItem(0);
			Control arg_541_0 = this.IconGV;
			size = new Size(140, 176);
			arg_541_0.Size = size;
			this.IconGV.set_SmallImageList(this.IconIL);
			this.IconGV.set_SmallImageView(true);
			this.IconGV.TabIndex = 0;
			ImageList arg_581_0 = this.IconIL;
			size = new Size(16, 16);
			arg_581_0.ImageSize = size;
			this.IconIL.TransparentColor = Color.Transparent;
			ImageList arg_5A8_0 = this.HotSpotIL;
			size = new Size(16, 16);
			arg_5A8_0.ImageSize = size;
			this.HotSpotIL.ImageStream = (ImageListStreamer)resourceManager.GetObject("HotSpotIL.ImageStream");
			this.HotSpotIL.TransparentColor = Color.Transparent;
			ImageList arg_5EA_0 = this.ButtonIL;
			size = new Size(16, 16);
			arg_5EA_0.ImageSize = size;
			this.ButtonIL.ImageStream = (ImageListStreamer)resourceManager.GetObject("ButtonIL.ImageStream");
			this.ButtonIL.TransparentColor = Color.Transparent;
			this.ToolSplitter.Dock = DockStyle.Right;
			Control arg_63A_0 = this.ToolSplitter;
			location = new Point(352, 0);
			arg_63A_0.Location = location;
			this.ToolSplitter.Name = "ToolSplitter";
			Control arg_663_0 = this.ToolSplitter;
			size = new Size(8, 400);
			arg_663_0.Size = size;
			this.ToolSplitter.TabIndex = 1;
			this.ToolSplitter.TabStop = false;
			this.ImagePanel.Controls.Add(this.AnnoPBPanel);
			this.ImagePanel.Controls.Add(this.ImageToolPanel);
			this.ImagePanel.Dock = DockStyle.Fill;
			Control arg_6C8_0 = this.ImagePanel;
			location = new Point(0, 0);
			arg_6C8_0.Location = location;
			this.ImagePanel.Name = "ImagePanel";
			Control arg_6F5_0 = this.ImagePanel;
			size = new Size(352, 400);
			arg_6F5_0.Size = size;
			this.ImagePanel.TabIndex = 2;
			this.AnnoPBPanel.AutoScroll = true;
			this.AnnoPBPanel.Dock = DockStyle.Fill;
			Control arg_72F_0 = this.AnnoPBPanel;
			location = new Point(0, 32);
			arg_72F_0.Location = location;
			this.AnnoPBPanel.Name = "AnnoPBPanel";
			Control arg_75C_0 = this.AnnoPBPanel;
			size = new Size(352, 368);
			arg_75C_0.Size = size;
			this.AnnoPBPanel.TabIndex = 1;
			this.ImageToolPanel.Controls.Add(this.ImageToolBar);
			this.ImageToolPanel.Dock = DockStyle.Top;
			Control arg_79F_0 = this.ImageToolPanel;
			location = new Point(0, 0);
			arg_79F_0.Location = location;
			this.ImageToolPanel.Name = "ImageToolPanel";
			Control arg_7C9_0 = this.ImageToolPanel;
			size = new Size(352, 32);
			arg_7C9_0.Size = size;
			this.ImageToolPanel.TabIndex = 0;
			this.ImageToolBar.Buttons.AddRange(new ToolBarButton[]
			{
				this.btnNewImage,
				this.btnProperty
			});
			this.ImageToolBar.DropDownArrows = true;
			this.ImageToolBar.ImageList = this.ButtonIL;
			Control arg_831_0 = this.ImageToolBar;
			location = new Point(0, 0);
			arg_831_0.Location = location;
			this.ImageToolBar.Name = "ImageToolBar";
			this.ImageToolBar.ShowToolTips = true;
			Control arg_867_0 = this.ImageToolBar;
			size = new Size(352, 28);
			arg_867_0.Size = size;
			this.ImageToolBar.TabIndex = 0;
			this.btnNewImage.ImageIndex = 0;
			this.btnNewImage.ToolTipText = "添加图片";
			this.btnProperty.ImageIndex = 1;
			this.btnProperty.ToolTipText = "图像属性";
			this.Splitter1.Dock = DockStyle.Top;
			Control arg_8D0_0 = this.Splitter1;
			location = new Point(0, 200);
			arg_8D0_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_8F9_0 = this.Splitter1;
			size = new Size(140, 5);
			arg_8F9_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.PropertyPanel.Controls.Add(this.PGImage);
			this.PropertyPanel.Dock = DockStyle.Fill;
			Control arg_94C_0 = this.PropertyPanel;
			location = new Point(0, 205);
			arg_94C_0.Location = location;
			this.PropertyPanel.Name = "PropertyPanel";
			Control arg_979_0 = this.PropertyPanel;
			size = new Size(140, 195);
			arg_979_0.Size = size;
			this.PropertyPanel.TabIndex = 2;
			this.PGImage.CommandsVisibleIfAvailable = true;
			this.PGImage.Dock = DockStyle.Fill;
			this.PGImage.LargeButtons = false;
			this.PGImage.LineColor = SystemColors.ScrollBar;
			Control arg_9CE_0 = this.PGImage;
			location = new Point(0, 0);
			arg_9CE_0.Location = location;
			this.PGImage.Name = "PGImage";
			Control arg_9FB_0 = this.PGImage;
			size = new Size(140, 195);
			arg_9FB_0.Size = size;
			this.PGImage.TabIndex = 0;
			this.PGImage.ToolbarVisible = false;
			this.PGImage.ViewBackColor = SystemColors.Window;
			this.PGImage.ViewForeColor = SystemColors.WindowText;
			this.HotSpotGV.set_BorderStyle(BorderStyle.None);
			this.HotSpotGV.Dock = DockStyle.Fill;
			this.HotSpotGV.set_LargeImageList(null);
			Control arg_A6C_0 = this.HotSpotGV;
			location = new Point(0, 0);
			arg_A6C_0.Location = location;
			this.HotSpotGV.Name = "HotSpotGV";
			this.HotSpotGV.set_SelectedItem(0);
			Control arg_AA5_0 = this.HotSpotGV;
			size = new Size(140, 176);
			arg_AA5_0.Size = size;
			this.HotSpotGV.set_SmallImageList(this.HotSpotIL);
			this.HotSpotGV.set_SmallImageView(true);
			this.HotSpotGV.TabIndex = 1;
			this.Controls.Add(this.ImagePanel);
			this.Controls.Add(this.ToolSplitter);
			this.Controls.Add(this.ToolPanel);
			this.Name = "MIImageAnnotateProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ToolPanel.ResumeLayout(false);
			this.ToolTabs.ResumeLayout(false);
			this.HotSpotTab.ResumeLayout(false);
			this.IconTab.ResumeLayout(false);
			this.IconToolPanel.ResumeLayout(false);
			this.IconListPanel.ResumeLayout(false);
			this.ImagePanel.ResumeLayout(false);
			this.ImageToolPanel.ResumeLayout(false);
			this.PropertyPanel.ResumeLayout(false);
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
			this._MetaItemProperty = new MetaItemPropertyWrap();
			this._EPRIconProperty.IconPropertyChanged += new EPRIconProperty.IconPropertyChangedEventHandler(this.EPRIconProperty_IconPropertyChanged);
		}

		private void LoadImage()
		{
			if (this.objOpenFileDialog == null)
			{
				this.objOpenFileDialog = new OpenFileDialog();
			}
			this.objOpenFileDialog.ShowDialog();
			string fileName = this.objOpenFileDialog.FileName;
			if (Operators.CompareString(fileName, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("未输入文件名，请重新选择！");
				return;
			}
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			this.AnnoPictureBox.Image = Image.FromFile(fileName);
			this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
			this.CurrentHotSpotLayer = new Layer();
			this.CurrentHotSpotLayer.set_Name("EPRHotSpotLayer");
			this.CurrentAnnotationLayer = new Layer();
			this.CurrentAnnotationLayer.set_Name("EPRAnnoLayer");
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Add(this.CurrentHotSpotLayer);
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Add(this.CurrentAnnotationLayer);
			this.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.CurrentHotSpotLayer);
		}

		public void SerializeImageAnno()
		{
			if (this.AnnoPictureBox.Image != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				this.AnnoPictureBox.Image.Save(memoryStream, this.AnnoPictureBox.Image.RawFormat);
				this._MIImageAnnotate.ImageData = AnnotateUtil.ImageStreamToStr(memoryStream);
				byte[] bytes = this.AnnoPictureBox.AnnoCtrl.Save(this.CurrentHotSpotLayer, 0);
				this._MIImageAnnotate.HotSpotData = Encoding.UTF8.GetString(bytes);
				byte[] bytes2 = this.AnnoPictureBox.AnnoCtrl.Save(this.CurrentAnnotationLayer, 0);
				this._NIImageAnnotate.AnnoData = Encoding.UTF8.GetString(bytes2);
			}
		}

		private void DeSerializeImageAnno()
		{
			this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			this.AnnoPictureBox.Image = null;
			checked
			{
				if (!(this._MIImageAnnotate.ImageData == null | Operators.CompareString(this._MIImageAnnotate.ImageData, "", false) == 0))
				{
					this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
					this.AnnoPictureBox.Image = Image.FromStream(AnnotateUtil.StrToImageStream(this._MIImageAnnotate.ImageData));
					this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
					string text;
					if (this._NIImageAnnotate != null)
					{
						if (this._NIImageAnnotate.AnnoData == null | Operators.CompareString(this._NIImageAnnotate.AnnoData, "", false) == 0)
						{
							text = "<ann:Layer><ann:Name>EPRAnnoLayer</ann:Name><ann:EncryptedPassword></ann:EncryptedPassword><ann:Locked>False</ann:Locked><ann:Visible>True</ann:Visible><ann:AnnotationCollection></ann:AnnotationCollection></ann:Layer>";
						}
						else
						{
							int num = this._NIImageAnnotate.AnnoData.IndexOf("<ann:Layer>");
							int num2 = this._NIImageAnnotate.AnnoData.IndexOf("</ann:Layer>") + 12;
							text = this._NIImageAnnotate.AnnoData.Substring(num, num2 - num);
						}
						int startIndex = this._MIImageAnnotate.HotSpotData.IndexOf("/ann:Layer>") + 11;
						text = this._MIImageAnnotate.HotSpotData.Insert(startIndex, text);
					}
					else
					{
						text = this._MIImageAnnotate.HotSpotData;
					}
					this.AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(text), 0);
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
										if (annotation2 is MetaItemAnnotation)
										{
											MetaItemAnnotation metaItemAnnotation = (MetaItemAnnotation)annotation2;
											MMetaItemEnumerator enumerator4 = this._MIImageAnnotate.SubItems.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												MMetaItem mMetaItem = (MMetaItem)enumerator4.Current;
												if (Operators.CompareString(mMetaItem.Code, metaItemAnnotation.BindCode, false) == 0)
												{
													metaItemAnnotation.BindMetaItem = mMetaItem;
													break;
												}
											}
										}
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
				}
			}
		}

		private void ImageToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button == this.btnNewImage)
			{
				this.LoadImage();
			}
			else if (e.Button == this.btnProperty)
			{
				MMetaItem parent = this._MIImageAnnotate.Parent;
				while (!(parent is MMetaData))
				{
					if (parent == null)
					{
						IL_48:
						ImageBindForm imageBindForm = new ImageBindForm();
						if (parent != null)
						{
							imageBindForm.MetaData = (MMetaData)parent;
						}
						imageBindForm.MIImageAnnotate = this._MIImageAnnotate;
						imageBindForm.ShowDialog();
						return;
					}
					parent = parent.Parent;
				}
				goto IL_48;
			}
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

		private void miDelete_Click(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is MetaItemAnnotation)
			{
				MetaItemAnnotation metaItemAnnotation = (MetaItemAnnotation)this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				metaItemAnnotation.BindMetaItem.BindControl = false;
			}
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
				this._MIImageAnnotate.IconAnnotates.RemoveAt(this.IconGVIndex);
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
			this._MIImageAnnotate.IconAnnotates.Add(iconAnnotation);
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
			else if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is MetaItemAnnotation)
			{
				this._MetaItemProperty.MetaItemAnnotation = (MetaItemAnnotation)this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.PGImage.SelectedObject = this._MetaItemProperty;
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
				IconAnnotation iconAnnotation = this._MIImageAnnotate.IconAnnotates[this.CurrentIconIndex];
				this._EPRIconProperty.IconAnnotation = iconAnnotation;
				this.PGImage.SelectedObject = this._EPRIconProperty;
			}
		}

		private void EPRIconProperty_IconPropertyChanged()
		{
			this.IconIL.Images[this.CurrentIconIndex] = this._MIImageAnnotate.IconAnnotates[this.CurrentIconIndex].GetIconImage();
			this.IconGV.get_GroupViewItems().get_Item(this.CurrentIconIndex).set_Text(this._MIImageAnnotate.IconAnnotates[this.CurrentIconIndex].IconName);
		}

		private void MIImageAnnotateProperty_ParentChanged(object sender, EventArgs e)
		{
			if (this.Parent == null)
			{
				this.SerializeImageAnno();
				this._MIImageAnnotate.XMLEvent -= new MIImageAnnotate.XMLEventEventHandler(this.SerializeImageAnno);
			}
		}

		private void IconGV_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.IconGVIndex = this.IconGV.get_SelectedItem();
			}
		}

		private void AnnoPictureBox_DragEnter(object sender, DragEventArgs e)
		{
			if (this.MetaItemTree.DragMetaItem != null & this.AnnoPictureBox.Image != null)
			{
				if (this.MetaItemTree.DragMetaItem.Parent == this._MIImageAnnotate)
				{
					if (this.MetaItemTree.DragMetaItem.BindControl)
					{
						this.MetaItemTree.DragMetaItem = null;
						this.MetaItemTree.DragTreeNode = null;
					}
					else
					{
						e.Effect = DragDropEffects.Move;
					}
				}
				else
				{
					e.Effect = DragDropEffects.None;
					this.MetaItemTree.DragMetaItem = null;
					this.MetaItemTree.DragTreeNode = null;
				}
			}
			else
			{
				e.Effect = DragDropEffects.None;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}

		private void AnnoPictureBox_DragDrop(object sender, DragEventArgs e)
		{
			MetaItemAnnotation metaItemAnnotation = new MetaItemAnnotation();
			metaItemAnnotation.BindMetaItem = this.MetaItemTree.DragMetaItem;
			this.MetaItemTree.DragMetaItem.BindControl = true;
			Control arg_42_0 = this.AnnoPictureBox;
			Point p = new Point(e.X, e.Y);
			Point point = arg_42_0.PointToClient(p);
			Annotation arg_61_0 = metaItemAnnotation;
			PointF location = new PointF((float)point.X, (float)point.Y);
			arg_61_0.set_Location(location);
			Annotation arg_7A_0 = metaItemAnnotation;
			SizeF size = new SizeF(100f, 40f);
			arg_7A_0.set_Size(size);
			this.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.CurrentAnnotationLayer);
			metaItemAnnotation.set_Visible(true);
			metaItemAnnotation.set_ContextMenu(this.cmHotSpot);
			this.AnnoPictureBox.AnnoCtrl.get_CurrentLayer().Add(metaItemAnnotation);
			this._MetaItemProperty.MetaItemAnnotation = metaItemAnnotation;
			this.PGImage.SelectedObject = this._MetaItemProperty;
			this.MetaItemTree.DragMetaItem = null;
			this.MetaItemTree.DragTreeNode = null;
		}
	}
}
