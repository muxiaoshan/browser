using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class AnnoToolForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		[AccessedThroughProperty("AnnoTabs")]
		private TabControlAdv _AnnoTabs;

		[AccessedThroughProperty("StandardTab")]
		private TabPageAdv _StandardTab;

		[AccessedThroughProperty("StandardGV")]
		private GroupView _StandardGV;

		[AccessedThroughProperty("CustomTab")]
		private TabPageAdv _CustomTab;

		[AccessedThroughProperty("CustomGV")]
		private GroupView _CustomGV;

		[AccessedThroughProperty("HotSpotIL")]
		private ImageList _HotSpotIL;

		[AccessedThroughProperty("StandardPG")]
		private PropertyGrid _StandardPG;

		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("IconIL")]
		private ImageList _IconIL;

		private PCImageAnnotate _PCImageAnnotate;

		private LinePropertyWrap _LinePropertyWrap;

		private ArrowLinePropertyWrap _ArrowLinePropertyWrap;

		private CurveLinesPropertyWrap _CurveLinesPropertyWrap;

		private FreeHandPropertyWrap _FreeHandPropertyWrap;

		private TextPropertyWrap _TextPropertyWrap;

		private AnyPropertyWrap _AnyPropertyWrap;

		private EllipsePropertyWrap _EllipsePropertyWrap;

		private RectAnglePropertyWrap _RectanglePropertyWrap;

		private PolygonPropertyWrap _PolygonPropertyWrap;

		private CustomIconPropertyWrap _CustomIconPropertyWrap;

		private MIImageAnnotate _MIImageAnnotate;

		private bool _FirstClick;

		private static string AnnoToolConfig = "N|N";

		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
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

		internal virtual Panel Panel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel3 = value;
			}
		}

		internal virtual TabControlAdv AnnoTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AnnoTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AnnoTabs = value;
			}
		}

		internal virtual TabPageAdv StandardTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StandardTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StandardTab = value;
			}
		}

		internal virtual GroupView StandardGV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StandardGV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StandardGV_GroupViewItemSelected);
				if (this._StandardGV != null)
				{
					this._StandardGV.remove_GroupViewItemSelected(eventHandler);
				}
				this._StandardGV = value;
				if (this._StandardGV != null)
				{
					this._StandardGV.add_GroupViewItemSelected(eventHandler);
				}
			}
		}

		internal virtual TabPageAdv CustomTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CustomTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CustomTab = value;
			}
		}

		internal virtual GroupView CustomGV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CustomGV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CustomGV_GroupViewItemSelected);
				EventHandler value2 = new EventHandler(this.CustomGV_DoubleClick);
				if (this._CustomGV != null)
				{
					this._CustomGV.remove_GroupViewItemSelected(eventHandler);
					this._CustomGV.DoubleClick -= value2;
				}
				this._CustomGV = value;
				if (this._CustomGV != null)
				{
					this._CustomGV.add_GroupViewItemSelected(eventHandler);
					this._CustomGV.DoubleClick += value2;
				}
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

		internal virtual PropertyGrid StandardPG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StandardPG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StandardPG = value;
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

		public PCImageAnnotate PCImageAnnotate
		{
			get
			{
				return this._PCImageAnnotate;
			}
			set
			{
				this._PCImageAnnotate = value;
				this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.add_SelectionChanged(new EventHandler(this.AnnotationSelected));
				this.StandardPG.SelectedObject = null;
				checked
				{
					for (int i = this.CustomGV.get_GroupViewItems().Count - 1; i >= 1; i += -1)
					{
						this.CustomGV.get_GroupViewItems().RemoveAt(i);
					}
					this._MIImageAnnotate = (MIImageAnnotate)this._PCImageAnnotate.BindInstanceItem.BindMMetaItem;
					for (int j = this.IconIL.Images.Count - 1; j >= 1; j += -1)
					{
						this.IconIL.Images.RemoveAt(j);
					}
					IconAnnotationEnumerator enumerator = this._MIImageAnnotate.IconAnnotates.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IconAnnotation iconAnnotation = (IconAnnotation)enumerator.Current;
						this.IconIL.Images.Add(iconAnnotation.GetIconImage());
						this.CustomGV.get_GroupViewItems().AddRange(new GroupViewItem[]
						{
							new GroupViewItem(iconAnnotation.IconName, this.IconIL.Images.Count - 1)
						});
					}
					if (this.CustomGV.get_GroupViewItems().Count > 0)
					{
						this.CustomGV.set_SelectedItem(0);
					}
				}
			}
		}

		public AnnoToolForm()
		{
			base.Closed += new EventHandler(this.AnnoToolForm_Closed);
			this._FirstClick = true;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AnnoToolForm));
			this.Panel2 = new Panel();
			this.AnnoTabs = new TabControlAdv();
			this.StandardTab = new TabPageAdv();
			this.StandardGV = new GroupView();
			this.HotSpotIL = new ImageList(this.components);
			this.CustomTab = new TabPageAdv();
			this.SplitContainer1 = new SplitContainer();
			this.CustomGV = new GroupView();
			this.IconIL = new ImageList(this.components);
			this.btnOK = new Button();
			this.Splitter1 = new Splitter();
			this.Panel3 = new Panel();
			this.StandardPG = new PropertyGrid();
			this.Panel2.SuspendLayout();
			this.AnnoTabs.BeginInit();
			this.AnnoTabs.SuspendLayout();
			this.StandardTab.SuspendLayout();
			this.CustomTab.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			this.Panel2.Controls.Add(this.AnnoTabs);
			this.Panel2.Dock = DockStyle.Fill;
			Control arg_15B_0 = this.Panel2;
			Point location = new Point(0, 0);
			arg_15B_0.Location = location;
			this.Panel2.Name = "Panel2";
			Control arg_188_0 = this.Panel2;
			Size size = new Size(152, 272);
			arg_188_0.Size = size;
			this.Panel2.TabIndex = 0;
			this.AnnoTabs.set_BorderStyle(BorderStyle.None);
			this.AnnoTabs.Controls.Add(this.StandardTab);
			this.AnnoTabs.Controls.Add(this.CustomTab);
			this.AnnoTabs.Dock = DockStyle.Fill;
			Control arg_1ED_0 = this.AnnoTabs;
			location = new Point(0, 0);
			arg_1ED_0.Location = location;
			this.AnnoTabs.Name = "AnnoTabs";
			Control arg_21A_0 = this.AnnoTabs;
			size = new Size(152, 272);
			arg_21A_0.Size = size;
			this.AnnoTabs.TabIndex = 1;
			this.AnnoTabs.set_TabStyle(typeof(TabRenderer2D));
			this.StandardTab.Controls.Add(this.StandardGV);
			Control arg_267_0 = this.StandardTab;
			location = new Point(0, 20);
			arg_267_0.Location = location;
			this.StandardTab.Name = "StandardTab";
			Control arg_294_0 = this.StandardTab;
			size = new Size(152, 252);
			arg_294_0.Size = size;
			this.StandardTab.set_TabIndex(1);
			this.StandardTab.set_Text("通用");
			this.StandardTab.set_ThemesEnabled(false);
			this.StandardGV.set_BorderStyle(BorderStyle.None);
			this.StandardGV.set_ButtonView(true);
			this.StandardGV.Dock = DockStyle.Fill;
			this.StandardGV.set_LargeImageList(null);
			Control arg_301_0 = this.StandardGV;
			location = new Point(0, 0);
			arg_301_0.Location = location;
			this.StandardGV.Name = "StandardGV";
			Control arg_32E_0 = this.StandardGV;
			size = new Size(152, 252);
			arg_32E_0.Size = size;
			this.StandardGV.set_SmallImageList(this.HotSpotIL);
			this.StandardGV.set_SmallImageView(true);
			this.StandardGV.TabIndex = 3;
			this.StandardGV.Text = "GroupView1";
			this.HotSpotIL.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("HotSpotIL.ImageStream");
			this.HotSpotIL.TransparentColor = Color.Transparent;
			this.HotSpotIL.Images.SetKeyName(0, "");
			this.HotSpotIL.Images.SetKeyName(1, "");
			this.HotSpotIL.Images.SetKeyName(2, "");
			this.HotSpotIL.Images.SetKeyName(3, "");
			this.HotSpotIL.Images.SetKeyName(4, "HotSpotArrow.ico");
			this.HotSpotIL.Images.SetKeyName(5, "HotSpotCurveLine.ico");
			this.HotSpotIL.Images.SetKeyName(6, "");
			this.HotSpotIL.Images.SetKeyName(7, "");
			this.HotSpotIL.Images.SetKeyName(8, "");
			this.HotSpotIL.Images.SetKeyName(9, "");
			this.CustomTab.Controls.Add(this.SplitContainer1);
			Control arg_49A_0 = this.CustomTab;
			location = new Point(0, -1);
			arg_49A_0.Location = location;
			this.CustomTab.Name = "CustomTab";
			Control arg_4C7_0 = this.CustomTab;
			size = new Size(152, 273);
			arg_4C7_0.Size = size;
			this.CustomTab.set_TabIndex(1);
			this.CustomTab.set_Text("自定义");
			this.CustomTab.set_ThemesEnabled(false);
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			Control arg_51C_0 = this.SplitContainer1;
			location = new Point(0, 0);
			arg_51C_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Panel1.Controls.Add(this.CustomGV);
			this.SplitContainer1.Panel2.Controls.Add(this.btnOK);
			Control arg_57F_0 = this.SplitContainer1;
			size = new Size(152, 273);
			arg_57F_0.Size = size;
			this.SplitContainer1.SplitterDistance = 122;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 4;
			this.CustomGV.set_BorderStyle(BorderStyle.None);
			this.CustomGV.set_ButtonView(true);
			this.CustomGV.Dock = DockStyle.Fill;
			this.CustomGV.set_LargeImageList(null);
			Control arg_5E9_0 = this.CustomGV;
			location = new Point(0, 0);
			arg_5E9_0.Location = location;
			this.CustomGV.Name = "CustomGV";
			Control arg_613_0 = this.CustomGV;
			size = new Size(122, 273);
			arg_613_0.Size = size;
			this.CustomGV.set_SmallImageList(this.IconIL);
			this.CustomGV.set_SmallImageView(true);
			this.CustomGV.TabIndex = 3;
			this.IconIL.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("IconIL.ImageStream");
			this.IconIL.TransparentColor = Color.Transparent;
			this.IconIL.Images.SetKeyName(0, "");
			this.btnOK.Dock = DockStyle.Fill;
			this.btnOK.Enabled = false;
			this.btnOK.FlatStyle = FlatStyle.Popup;
			Control arg_6B6_0 = this.btnOK;
			location = new Point(0, 0);
			arg_6B6_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_6E0_0 = this.btnOK;
			size = new Size(28, 273);
			arg_6E0_0.Size = size;
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "添加标注";
			this.btnOK.UseVisualStyleBackColor = false;
			this.Splitter1.Dock = DockStyle.Bottom;
			Control arg_72D_0 = this.Splitter1;
			location = new Point(0, 272);
			arg_72D_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_757_0 = this.Splitter1;
			size = new Size(152, 14);
			arg_757_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.Panel3.Controls.Add(this.StandardPG);
			this.Panel3.Dock = DockStyle.Bottom;
			Control arg_7AA_0 = this.Panel3;
			location = new Point(0, 286);
			arg_7AA_0.Location = location;
			this.Panel3.Name = "Panel3";
			Control arg_7D7_0 = this.Panel3;
			size = new Size(152, 172);
			arg_7D7_0.Size = size;
			this.Panel3.TabIndex = 2;
			this.StandardPG.Dock = DockStyle.Fill;
			this.StandardPG.LineColor = SystemColors.ScrollBar;
			Control arg_814_0 = this.StandardPG;
			location = new Point(0, 0);
			arg_814_0.Location = location;
			this.StandardPG.Name = "StandardPG";
			Control arg_841_0 = this.StandardPG;
			size = new Size(152, 172);
			arg_841_0.Size = size;
			this.StandardPG.TabIndex = 3;
			this.StandardPG.ToolbarVisible = false;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(152, 458);
			this.ClientSize = size;
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Splitter1);
			this.Controls.Add(this.Panel3);
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.Name = "AnnoToolForm";
			this.ShowInTaskbar = false;
			this.Text = "图像注释工具";
			this.Panel2.ResumeLayout(false);
			this.AnnoTabs.EndInit();
			this.AnnoTabs.ResumeLayout(false);
			this.StandardTab.ResumeLayout(false);
			this.CustomTab.ResumeLayout(false);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.StandardGV.get_GroupViewItems().AddRange(new GroupViewItem[]
			{
				new GroupViewItem("指针", 0),
				new GroupViewItem("文本", 1),
				new GroupViewItem("铅笔", 2),
				new GroupViewItem("直线", 3),
				new GroupViewItem("箭头", 4),
				new GroupViewItem("曲线", 5),
				new GroupViewItem("自由框", 6),
				new GroupViewItem("方框", 7),
				new GroupViewItem("椭圆", 8),
				new GroupViewItem("多边形", 9)
			});
			this.CustomGV.get_GroupViewItems().AddRange(new GroupViewItem[]
			{
				new GroupViewItem("指针", 0)
			});
			if (AnnoToolForm.IsPropertyGridCollapse())
			{
				this.StandardPG.CollapseAllGridItems();
			}
		}

		private void StandardGV_GroupViewItemSelected(object sender, EventArgs e)
		{
			if (this.StandardGV.get_SelectedItem() == 0)
			{
				this.StandardPG.SelectedObject = null;
				this.PCImageAnnotate.NewAnnotation = false;
				this.PCImageAnnotate.AnnoPictureBox.CancelAddAnnotation();
			}
			else if (this.StandardGV.get_SelectedItem() == 1)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				TextAnnotation textAnnotation = new TextAnnotation();
				if (AnnoToolForm.IsTextAnnoWithBlackBorder())
				{
					textAnnotation.get_Pen().Color = Color.Black;
				}
				else
				{
					textAnnotation.get_Pen().Color = Color.Transparent;
				}
				textAnnotation.set_Brush(new SolidBrush(Color.Transparent));
				textAnnotation.set_Font(new Font("宋体", 9f));
				textAnnotation.set_Text("注释");
				textAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				if (this._TextPropertyWrap == null)
				{
					this._TextPropertyWrap = new TextPropertyWrap();
				}
				this._TextPropertyWrap.TextAnnotation = textAnnotation;
				this.StandardPG.SelectedObject = this._TextPropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(textAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 2)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				FreehandAnnotation freehandAnnotation = new FreehandAnnotation();
				freehandAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				if (this._FreeHandPropertyWrap == null)
				{
					this._FreeHandPropertyWrap = new FreeHandPropertyWrap();
				}
				this._FreeHandPropertyWrap.FreeHandAnnotation = freehandAnnotation;
				this.StandardPG.SelectedObject = this._FreeHandPropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(freehandAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 3)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				LineAnnotation lineAnnotation = new LineAnnotation();
				if (this._LinePropertyWrap == null)
				{
					this._LinePropertyWrap = new LinePropertyWrap();
				}
				lineAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				this._LinePropertyWrap.LineAnnotation = lineAnnotation;
				this.StandardPG.SelectedObject = this._LinePropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(lineAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 4)
			{
				ArrowLineAnnotation arrowLineAnnotation = new ArrowLineAnnotation();
				AdjustableArrowCap customEndCap = new AdjustableArrowCap(arrowLineAnnotation.get_Pen().Width * 4f, arrowLineAnnotation.get_Pen().Width * 4f, true);
				arrowLineAnnotation.get_Pen().CustomEndCap = customEndCap;
				arrowLineAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				if (this._ArrowLinePropertyWrap == null)
				{
					this._ArrowLinePropertyWrap = new ArrowLinePropertyWrap();
				}
				this._ArrowLinePropertyWrap.ArrowLineAnnotation = arrowLineAnnotation;
				this.StandardPG.SelectedObject = this._ArrowLinePropertyWrap;
				this.PCImageAnnotate.NewAnnotation = true;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(arrowLineAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 5)
			{
				CurveLinesAnnotation curveLinesAnnotation = new CurveLinesAnnotation();
				curveLinesAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				if (this._CurveLinesPropertyWrap == null)
				{
					this._CurveLinesPropertyWrap = new CurveLinesPropertyWrap();
				}
				this._CurveLinesPropertyWrap.CurveLinesAnnotation = curveLinesAnnotation;
				this.StandardPG.SelectedObject = this._CurveLinesPropertyWrap;
				this.PCImageAnnotate.NewAnnotation = true;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(curveLinesAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 6)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				AnyAnnotation anyAnnotation = new AnyAnnotation();
				if (this._AnyPropertyWrap == null)
				{
					this._AnyPropertyWrap = new AnyPropertyWrap();
				}
				anyAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				this._AnyPropertyWrap.AnyAnnotation = anyAnnotation;
				this.StandardPG.SelectedObject = this._AnyPropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(anyAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 7)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				RectangleAnnotation rectangleAnnotation = new RectangleAnnotation();
				if (this._RectanglePropertyWrap == null)
				{
					this._RectanglePropertyWrap = new RectAnglePropertyWrap();
				}
				rectangleAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				((SolidBrush)rectangleAnnotation.get_Brush()).Color = Color.Transparent;
				this._RectanglePropertyWrap.RectangleAnnotation = rectangleAnnotation;
				this.StandardPG.SelectedObject = this._RectanglePropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(rectangleAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 8)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				EllipseAnnotation ellipseAnnotation = new EllipseAnnotation();
				if (this._EllipsePropertyWrap == null)
				{
					this._EllipsePropertyWrap = new EllipsePropertyWrap();
				}
				ellipseAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				((SolidBrush)ellipseAnnotation.get_Brush()).Color = Color.Transparent;
				this._EllipsePropertyWrap.EllipseAnnotation = ellipseAnnotation;
				this.StandardPG.SelectedObject = this._EllipsePropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(ellipseAnnotation);
			}
			else if (this.StandardGV.get_SelectedItem() == 9)
			{
				this.PCImageAnnotate.NewAnnotation = true;
				PolygonAnnotation polygonAnnotation = new PolygonAnnotation();
				if (this._PolygonPropertyWrap == null)
				{
					this._PolygonPropertyWrap = new PolygonPropertyWrap();
				}
				((SolidBrush)polygonAnnotation.get_Brush()).Color = Color.Transparent;
				polygonAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				this._PolygonPropertyWrap.PolygonAnnotation = polygonAnnotation;
				this.StandardPG.SelectedObject = this._PolygonPropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(polygonAnnotation);
			}
			if (this._FirstClick && AnnoToolForm.IsPropertyGridCollapse())
			{
				this.StandardPG.CollapseAllGridItems();
			}
			this._FirstClick = false;
		}

		private void AnnotationSelected(object sender, EventArgs e)
		{
			if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is LineAnnotation)
			{
				if (this._LinePropertyWrap == null)
				{
					this._LinePropertyWrap = new LinePropertyWrap();
				}
				this._LinePropertyWrap.LineAnnotation = (LineAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._LinePropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is TextAnnotation)
			{
				if (this._TextPropertyWrap == null)
				{
					this._TextPropertyWrap = new TextPropertyWrap();
				}
				this._TextPropertyWrap.TextAnnotation = (TextAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._TextPropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is FreehandAnnotation)
			{
				if (this._FreeHandPropertyWrap == null)
				{
					this._FreeHandPropertyWrap = new FreeHandPropertyWrap();
				}
				this._FreeHandPropertyWrap.FreeHandAnnotation = (FreehandAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._FreeHandPropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is RectangleAnnotation)
			{
				if (this._RectanglePropertyWrap == null)
				{
					this._RectanglePropertyWrap = new RectAnglePropertyWrap();
				}
				this._RectanglePropertyWrap.RectangleAnnotation = (RectangleAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._RectanglePropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is EllipseAnnotation)
			{
				if (this._EllipsePropertyWrap == null)
				{
					this._EllipsePropertyWrap = new EllipsePropertyWrap();
				}
				this._EllipsePropertyWrap.EllipseAnnotation = (EllipseAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._EllipsePropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is PolygonAnnotation)
			{
				if (this._PolygonPropertyWrap == null)
				{
					this._PolygonPropertyWrap = new PolygonPropertyWrap();
				}
				this._PolygonPropertyWrap.PolygonAnnotation = (PolygonAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._PolygonPropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is AnyAnnotation)
			{
				if (this._AnyPropertyWrap == null)
				{
					this._AnyPropertyWrap = new AnyPropertyWrap();
				}
				this._AnyPropertyWrap.AnyAnnotation = (AnyAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._AnyPropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is CustomIconAnnotation)
			{
				if (this._CustomIconPropertyWrap == null)
				{
					this._CustomIconPropertyWrap = new CustomIconPropertyWrap();
				}
				this._CustomIconPropertyWrap.CustomIconAnnotation = (CustomIconAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._CustomIconPropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is ArrowLineAnnotation)
			{
				if (this._ArrowLinePropertyWrap == null)
				{
					this._ArrowLinePropertyWrap = new ArrowLinePropertyWrap();
				}
				this._ArrowLinePropertyWrap.ArrowLineAnnotation = (ArrowLineAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._ArrowLinePropertyWrap;
			}
			else if (this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is CurveLinesAnnotation)
			{
				if (this._CurveLinesPropertyWrap == null)
				{
					this._CurveLinesPropertyWrap = new CurveLinesPropertyWrap();
				}
				this._CurveLinesPropertyWrap.CurveLinesAnnotation = (CurveLinesAnnotation)this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation();
				this.StandardPG.SelectedObject = this._CurveLinesPropertyWrap;
			}
			if (this._FirstClick & AnnoToolForm.IsPropertyGridCollapse())
			{
				this.StandardPG.CollapseAllGridItems();
			}
			this._FirstClick = false;
		}

		private void CustomGV_GroupViewItemSelected(object sender, EventArgs e)
		{
			this.btnOK.Enabled = true;
			if (this.CustomGV.get_SelectedItem() == 0)
			{
				this.StandardPG.SelectedObject = null;
				this.PCImageAnnotate.NewAnnotation = false;
				this.PCImageAnnotate.AnnoPictureBox.CancelAddAnnotation();
				this.btnOK.Enabled = false;
			}
			else
			{
				int index = checked(this.CustomGV.get_SelectedItem() - 1);
				IconAnnotation iconAnnotation = this._MIImageAnnotate.IconAnnotates[index];
				this.PCImageAnnotate.NewAnnotation = true;
				CustomIconAnnotation customIconAnnotation = new CustomIconAnnotation();
				customIconAnnotation.IconName = iconAnnotation.IconName;
				customIconAnnotation.IconCode = iconAnnotation.IconCode;
				customIconAnnotation.IconDesc = iconAnnotation.IconDesc;
				customIconAnnotation.IconImage = iconAnnotation.IconImage;
				customIconAnnotation.DrawImage = iconAnnotation.DrawImage;
				customIconAnnotation.DrawBorder = iconAnnotation.DrawBorder;
				customIconAnnotation.DrawHatch = iconAnnotation.DrawHatch;
				customIconAnnotation.HatchStyle = iconAnnotation.HatchStyle;
				customIconAnnotation.BorderWidth = iconAnnotation.BorderWidth;
				customIconAnnotation.ForeColor = iconAnnotation.ForeColor;
				customIconAnnotation.BackColor = iconAnnotation.BackColor;
				customIconAnnotation.add_Move(new EventHandler(this._PCImageAnnotate.CustomIconAnnotation_Move));
				customIconAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
				if (this._CustomIconPropertyWrap == null)
				{
					this._CustomIconPropertyWrap = new CustomIconPropertyWrap();
				}
				this._CustomIconPropertyWrap.CustomIconAnnotation = customIconAnnotation;
				this.StandardPG.SelectedObject = this._CustomIconPropertyWrap;
				this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
				this.PCImageAnnotate.AnnoPictureBox.AddAnnotaion(customIconAnnotation);
			}
		}

		private void CustomGV_DoubleClick(object sender, EventArgs e)
		{
			if (this.CustomGV.get_SelectedItem() == 0)
			{
				this.StandardPG.SelectedObject = null;
				this.PCImageAnnotate.NewAnnotation = false;
				this.PCImageAnnotate.AnnoPictureBox.CancelAddAnnotation();
			}
			else
			{
				bool flag = this.BatchAddAnnotation();
				if (flag)
				{
					this.PCImageAnnotate.RaiseVChangedEvent();
				}
				this.CustomGV.set_SelectedItem(0);
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.CustomGV.get_SelectedItem() > 0)
			{
				bool flag = this.BatchAddAnnotation();
				if (flag)
				{
					this.PCImageAnnotate.RaiseVChangedEvent();
				}
				this.CustomGV.set_SelectedItem(0);
			}
		}

		private bool BatchAddAnnotation()
		{
			bool result = false;
			try
			{
				IEnumerator enumerator = this.PCImageAnnotate.EPRHotSpotLayer.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)enumerator.Current;
					if (iEPRHotSpot.MultiSelected)
					{
						CustomIconAnnotation customIconAnnotation = new CustomIconAnnotation();
						Annotation annotation = (Annotation)iEPRHotSpot;
						customIconAnnotation.set_Location(annotation.get_Location());
						customIconAnnotation.set_Size(annotation.get_Size());
						if (iEPRHotSpot is EPRHotSpotEllipse)
						{
							float num = annotation.get_Size().Width / 2f;
							float num2 = annotation.get_Size().Height / 2f;
							PointF centerPoint = new PointF(annotation.get_Location().X + num, annotation.get_Location().Y + num2);
							customIconAnnotation.SetPoints(AnnotateUtil.GetEllipsePoints(centerPoint, num, num2));
						}
						else if (iEPRHotSpot is EPRHotSpotFreeHand)
						{
							EPRHotSpotFreeHand ePRHotSpotFreeHand = (EPRHotSpotFreeHand)iEPRHotSpot;
							customIconAnnotation.SetPoints((PointF[])ePRHotSpotFreeHand.GetPoints().Clone());
						}
						else if (iEPRHotSpot is EPRHotSpotRectAngular)
						{
							PointF[] array = new PointF[4];
							array[0] = new PointF(customIconAnnotation.get_Location().X, customIconAnnotation.get_Location().Y);
							array[1] = new PointF(customIconAnnotation.get_Location().X + customIconAnnotation.get_Size().Width, customIconAnnotation.get_Location().Y);
							array[2] = new PointF(customIconAnnotation.get_Location().X + customIconAnnotation.get_Size().Width, customIconAnnotation.get_Location().Y + customIconAnnotation.get_Size().Height);
							array[3] = new PointF(customIconAnnotation.get_Location().X, customIconAnnotation.get_Location().Y + customIconAnnotation.get_Size().Height);
							customIconAnnotation.SetPoints(AnnotateUtil.RefinePoints(array));
						}
						else if (iEPRHotSpot is EPRHotSpotPolygon)
						{
							EPRHotSpotPolygon ePRHotSpotPolygon = (EPRHotSpotPolygon)iEPRHotSpot;
							customIconAnnotation.SetPoints(AnnotateUtil.RefinePoints((PointF[])ePRHotSpotPolygon.GetPoints().Clone()));
						}
						int index = checked(this.CustomGV.get_SelectedItem() - 1);
						IconAnnotation iconAnnotation = this._MIImageAnnotate.IconAnnotates[index];
						customIconAnnotation.IconName = iconAnnotation.IconName;
						customIconAnnotation.IconCode = iconAnnotation.IconCode;
						customIconAnnotation.IconDesc = iconAnnotation.IconDesc;
						customIconAnnotation.IconImage = iconAnnotation.IconImage;
						customIconAnnotation.DrawImage = iconAnnotation.DrawImage;
						customIconAnnotation.DrawBorder = iconAnnotation.DrawBorder;
						customIconAnnotation.DrawHatch = iconAnnotation.DrawHatch;
						customIconAnnotation.HatchStyle = iconAnnotation.HatchStyle;
						customIconAnnotation.BorderWidth = iconAnnotation.BorderWidth;
						customIconAnnotation.ForeColor = iconAnnotation.ForeColor;
						customIconAnnotation.BackColor = iconAnnotation.BackColor;
						customIconAnnotation.add_Move(new EventHandler(this._PCImageAnnotate.CustomIconAnnotation_Move));
						customIconAnnotation.set_ContextMenuStrip(this.PCImageAnnotate.cmHotSpot);
						if (this._CustomIconPropertyWrap == null)
						{
							this._CustomIconPropertyWrap = new CustomIconPropertyWrap();
						}
						this._CustomIconPropertyWrap.CustomIconAnnotation = customIconAnnotation;
						this.StandardPG.SelectedObject = this._CustomIconPropertyWrap;
						this.PCImageAnnotate.AnnoPictureBox.AnnoCtrl.set_CurrentLayer(this.PCImageAnnotate.AnnoLayer);
						customIconAnnotation.set_Visible(true);
						customIconAnnotation.HotSpotCode = iEPRHotSpot.HSCode;
						this.PCImageAnnotate.AddNewAnnotationWithoutRaiseEvent(customIconAnnotation);
						result = true;
						customIconAnnotation.Lock();
						iEPRHotSpot.MultiSelected = false;
						this.PCImageAnnotate.GenerateTextDesc();
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
			return result;
		}

		private void AnnoToolForm_Closed(object sender, EventArgs e)
		{
			this.PCImageAnnotate.NewAnnotation = false;
			this.PCImageAnnotate.AnnoPictureBox.CancelAddAnnotation();
			this._PCImageAnnotate.AnnoPictureBox.AnnoCtrl.remove_SelectionChanged(new EventHandler(this.AnnotationSelected));
		}

		private static bool IsPropertyGridCollapse()
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("AnnoToolConfig", AnnoToolForm.AnnoToolConfig);
			return sysOptionValue.Split(new char[]
			{
				'|'
			}).Length >= 1 && Operators.CompareString(sysOptionValue.Split(new char[]
			{
				'|'
			})[0], "Y", false) == 0;
		}

		private static bool IsTextAnnoWithBlackBorder()
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("AnnoToolConfig", AnnoToolForm.AnnoToolConfig);
			return sysOptionValue.Split(new char[]
			{
				'|'
			}).Length >= 2 && Operators.CompareString(sysOptionValue.Split(new char[]
			{
				'|'
			})[1], "Y", false) == 0;
		}
	}
}
