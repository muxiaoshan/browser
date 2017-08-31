using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.table;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using SysOptionData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DesignPanel : PanelEx
	{
		public delegate void ReleaseDrawContolEventHandler();

		public delegate void RefreshControlListEventHandler();

		public struct StructMove
		{
			public Control m_ctrl;

			public List<int> m_move;

			public UndoMode m_falg;
		}

		private IContainer components;

		[AccessedThroughProperty("CoordinateTip")]
		private ToolTip _CoordinateTip;

		[AccessedThroughProperty("AlignContextMenu")]
		private ContextMenu _AlignContextMenu;

		private bool _DrawControl;

		private DrawCtrlType _DrawType;

		private NInstanceItem _DrawInstanceItem;

		private float MouseX;

		private float MouseY;

		private bool BoolMouseDown;

		private int addCWidth;

		private int addCHeight;

		private int addXPos;

		private int addYPos;

		private Graphics g;

		private const int DesignPanelMargin = 10;

		private ArrayList SelectedCtls;

		private bool LeftButtonDown;

		private bool RightButtonDown;

		private DesignControl CurrentControl;

		private DesignControl FocusControl;

		private Point ClickedPoint;

		private SizeMode CurrentSizeMode;

		private int leftest;

		private int topest;

		private int CtrlWidth;

		private int CtrlHeight;

		private int XPos;

		private int YPos;

		private ControlPropertyWrap curControlPropertyWrap;

		private DPPropertyWrap curDPPropertyWrap;

		private LablePropertyWrap curLablePropertyWrap;

		private TextValuePropertyWrap curTextPropertyWrap;

		public PropertyGrid PropertyGrid;

		[AccessedThroughProperty("mitemLeftAlign")]
		private MenuItem _mitemLeftAlign;

		[AccessedThroughProperty("mitemRightAlign")]
		private MenuItem _mitemRightAlign;

		[AccessedThroughProperty("mitemTopAlign")]
		private MenuItem _mitemTopAlign;

		[AccessedThroughProperty("mitemBottomAlgin")]
		private MenuItem _mitemBottomAlgin;

		[AccessedThroughProperty("mitemSameSizeAlgin")]
		private MenuItem _mitemSameSizeAlgin;

		[AccessedThroughProperty("mitemHSpacingAlgin")]
		private MenuItem _mitemHSpacingAlgin;

		[AccessedThroughProperty("mitemVSpacingcalAlgin")]
		private MenuItem _mitemVSpacingcalAlgin;

		private NInstanceData _InstanceData;

		private int pcount;

		private Size _GridSize;

		private const string defaultFontSizeParamName = "DefaultFontSize";

		private DesignPanel.ReleaseDrawContolEventHandler ReleaseDrawContolEvent;

		private DesignPanel.RefreshControlListEventHandler RefreshControlListEvent;

		private int k;

		private const int WM_VSCROLL = 277;

		private const int WM_HSCROLL = 276;

		private int xWidth;

		private int yHeight;

		private string designPageSize;

		private ArrayList UndoList;

		public event DesignPanel.ReleaseDrawContolEventHandler ReleaseDrawContol
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ReleaseDrawContolEvent = (DesignPanel.ReleaseDrawContolEventHandler)Delegate.Combine(this.ReleaseDrawContolEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ReleaseDrawContolEvent = (DesignPanel.ReleaseDrawContolEventHandler)Delegate.Remove(this.ReleaseDrawContolEvent, value);
			}
		}

		public event DesignPanel.RefreshControlListEventHandler RefreshControlList
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.RefreshControlListEvent = (DesignPanel.RefreshControlListEventHandler)Delegate.Combine(this.RefreshControlListEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.RefreshControlListEvent = (DesignPanel.RefreshControlListEventHandler)Delegate.Remove(this.RefreshControlListEvent, value);
			}
		}

		internal virtual ToolTip CoordinateTip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CoordinateTip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CoordinateTip = value;
			}
		}

		internal virtual ContextMenu AlignContextMenu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AlignContextMenu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AlignContextMenu = value;
			}
		}

		internal virtual MenuItem mitemLeftAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemLeftAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemLeftAlign_Click);
				if (this._mitemLeftAlign != null)
				{
					this._mitemLeftAlign.Click -= value2;
				}
				this._mitemLeftAlign = value;
				if (this._mitemLeftAlign != null)
				{
					this._mitemLeftAlign.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemRightAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemRightAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemRightAlign_Click);
				if (this._mitemRightAlign != null)
				{
					this._mitemRightAlign.Click -= value2;
				}
				this._mitemRightAlign = value;
				if (this._mitemRightAlign != null)
				{
					this._mitemRightAlign.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemTopAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemTopAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemTopAlign_Click);
				if (this._mitemTopAlign != null)
				{
					this._mitemTopAlign.Click -= value2;
				}
				this._mitemTopAlign = value;
				if (this._mitemTopAlign != null)
				{
					this._mitemTopAlign.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemBottomAlgin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemBottomAlgin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemBottomAlign_Click);
				if (this._mitemBottomAlgin != null)
				{
					this._mitemBottomAlgin.Click -= value2;
				}
				this._mitemBottomAlgin = value;
				if (this._mitemBottomAlgin != null)
				{
					this._mitemBottomAlgin.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemSameSizeAlgin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemSameSizeAlgin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemSameSizeAlgin_Click);
				if (this._mitemSameSizeAlgin != null)
				{
					this._mitemSameSizeAlgin.Click -= value2;
				}
				this._mitemSameSizeAlgin = value;
				if (this._mitemSameSizeAlgin != null)
				{
					this._mitemSameSizeAlgin.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemHSpacingAlgin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemHSpacingAlgin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemHSpacingAlgin_Click);
				if (this._mitemHSpacingAlgin != null)
				{
					this._mitemHSpacingAlgin.Click -= value2;
				}
				this._mitemHSpacingAlgin = value;
				if (this._mitemHSpacingAlgin != null)
				{
					this._mitemHSpacingAlgin.Click += value2;
				}
			}
		}

		internal virtual MenuItem mitemVSpacingcalAlgin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mitemVSpacingcalAlgin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mitemVSpacingcalAlgin_Click);
				if (this._mitemVSpacingcalAlgin != null)
				{
					this._mitemVSpacingcalAlgin.Click -= value2;
				}
				this._mitemVSpacingcalAlgin = value;
				if (this._mitemVSpacingcalAlgin != null)
				{
					this._mitemVSpacingcalAlgin.Click += value2;
				}
			}
		}

		public NInstanceItem DrawInstanceItem
		{
			get
			{
				return this._DrawInstanceItem;
			}
			set
			{
				this._DrawInstanceItem = value;
			}
		}

		public bool DrawControl
		{
			get
			{
				return this._DrawControl;
			}
			set
			{
				this._DrawControl = value;
			}
		}

		public DrawCtrlType DrawType
		{
			get
			{
				return this._DrawType;
			}
			set
			{
				this._DrawType = value;
			}
		}

		public NInstanceData InstanceData
		{
			get
			{
				return this._InstanceData;
			}
			set
			{
				this._InstanceData = value;
			}
		}

		public Size GridSize
		{
			get
			{
				return this._GridSize;
			}
			set
			{
				this._GridSize = value;
				this.Refresh();
			}
		}

		public string XMLString
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringWriter stringWriter = new StringWriter(stringBuilder);
				XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
				xmlTextWriter.Formatting = Formatting.None;
				this.XMLSerialize(xmlTextWriter);
				string result = stringBuilder.ToString();
				xmlTextWriter.Close();
				stringWriter.Close();
				return result;
			}
			set
			{
				this.Controls.Clear();
				StringReader input = new StringReader(value);
				XmlTextReader xmlTextReader = new XmlTextReader(input);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				xmlTextReader.Read();
				this.XMLDeserialize(xmlTextReader);
				xmlTextReader.Close();
			}
		}

		public DesignPanel()
		{
			base.Paint += new PaintEventHandler(this.DesignPanel_Paint);
			base.MouseMove += new MouseEventHandler(this.DesignPanel_MouseMove);
			base.KeyDown += new KeyEventHandler(this.Designpanel_KeyDown);
			base.MouseEnter += new EventHandler(this.DesignPanel_MouseEnter);
			base.MouseLeave += new EventHandler(this.DesignPanel_MouseLeave);
			base.MouseDown += new MouseEventHandler(this.DesignPanel_MouseDown);
			base.MouseUp += new MouseEventHandler(this.DesignPanel_MouseUp);
			this.SelectedCtls = new ArrayList();
			this.ClickedPoint = default(Point);
			this.curControlPropertyWrap = new ControlPropertyWrap();
			this.curDPPropertyWrap = new DPPropertyWrap();
			this.curLablePropertyWrap = new LablePropertyWrap();
			this.curTextPropertyWrap = new TextValuePropertyWrap();
			this.pcount = 0;
			this._GridSize = new Size(8, 8);
			this.xWidth = 0;
			this.yHeight = 0;
			this.designPageSize = string.Empty;
			this.UndoList = new ArrayList();
			this.InitializeComponent();
			this.mitemLeftAlign = new MenuItem();
			this.mitemRightAlign = new MenuItem();
			this.mitemTopAlign = new MenuItem();
			this.mitemBottomAlgin = new MenuItem();
			this.mitemSameSizeAlgin = new MenuItem();
			this.mitemHSpacingAlgin = new MenuItem();
			this.mitemVSpacingcalAlgin = new MenuItem();
			this.AlignContextMenu.MenuItems.AddRange(new MenuItem[]
			{
				this.mitemLeftAlign,
				this.mitemRightAlign,
				this.mitemTopAlign,
				this.mitemBottomAlgin,
				this.mitemSameSizeAlgin,
				this.mitemHSpacingAlgin,
				this.mitemVSpacingcalAlgin
			});
			this.mitemLeftAlign.Index = 0;
			this.mitemLeftAlign.Text = "左对齐";
			this.mitemRightAlign.Index = 1;
			this.mitemRightAlign.Text = "右对齐";
			this.mitemTopAlign.Index = 2;
			this.mitemTopAlign.Text = "上对齐";
			this.mitemBottomAlgin.Index = 3;
			this.mitemBottomAlgin.Text = "下对齐";
			this.mitemSameSizeAlgin.Index = 4;
			this.mitemSameSizeAlgin.Text = "使大小相同";
			this.mitemHSpacingAlgin.Index = 5;
			this.mitemHSpacingAlgin.Text = "相同水平间距";
			this.mitemVSpacingcalAlgin.Index = 6;
			this.mitemVSpacingcalAlgin.Text = "相同垂直间距";
			this.SetDefaultFont();
			this.SetEPRDesignPageSize();
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
			this.AlignContextMenu = new ContextMenu();
			this.CoordinateTip = new ToolTip(this.components);
			this.SuspendLayout();
			this.AutoScroll = true;
			this.BackColor = SystemColors.Control;
			this.ResumeLayout(false);
		}

		private void Designpanel_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteControls();
				this.curControlPropertyWrap.curControl = null;
				this.curLablePropertyWrap.curControl = null;
				this.curTextPropertyWrap.curControl = null;
			}
			if (e.KeyCode == Keys.Z)
			{
				this.UndoExecute();
			}
			if (e.Control & e.KeyCode == Keys.Left)
			{
				this.MoveControls(-1, 0);
			}
			if (e.Control & e.KeyCode == Keys.Right)
			{
				this.MoveControls(1, 0);
			}
			if (e.Control & e.KeyCode == Keys.Up)
			{
				this.MoveControls(0, -1);
			}
			if (e.Control & e.KeyCode == Keys.Down)
			{
				this.MoveControls(0, 1);
			}
			if (e.Shift & e.KeyCode == Keys.Left)
			{
				this.MoveSize(SizeMode.Right, -1, 0);
			}
			if (e.Shift & e.KeyCode == Keys.Right)
			{
				this.MoveSize(SizeMode.Right, 1, 0);
			}
			if (e.Shift & e.KeyCode == Keys.Up)
			{
				this.MoveSize(SizeMode.Down, 0, -1);
			}
			if (e.Shift & e.KeyCode == Keys.Down)
			{
				this.MoveSize(SizeMode.Down, 0, 1);
			}
			if (this.FocusControl != null)
			{
				this.ScrollControlIntoView(this.FocusControl);
				this.PropertyGrid.Refresh();
				this.FocusControl.Focus();
			}
		}

		private void DesignPanel_MouseEnter(object sender, EventArgs e)
		{
			if (this._DrawControl)
			{
				this.Cursor = Cursors.Cross;
			}
			else
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void DesignPanel_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void DesignPanel_MouseDown(object sender, MouseEventArgs e)
		{
			this.XPos = e.X;
			this.YPos = e.Y;
			checked
			{
				if (e.Button == MouseButtons.Left)
				{
					this.Cursor = Cursors.Cross;
					int arg_42_0 = 0;
					int num = this.SelectedCtls.Count - 1;
					for (int i = arg_42_0; i <= num; i++)
					{
						DesignControl designControl = (DesignControl)this.SelectedCtls[i];
						designControl.MultiSelected = false;
					}
					this.SelectedCtls.Clear();
					if (this.FocusControl != null)
					{
						this.FocusControl.Selected = false;
						this.FocusControl = null;
						this.CurrentControl = null;
						this.curControlPropertyWrap.curControl = null;
						this.curLablePropertyWrap.curControl = null;
						this.curTextPropertyWrap.curControl = null;
					}
					this.curDPPropertyWrap.curDesignPanel = this;
					this.PropertyGrid.SelectedObject = this.curDPPropertyWrap;
					this.Focus();
					this.BoolMouseDown = true;
				}
				if (e.Button == MouseButtons.Right)
				{
					if (this.SelectedCtls.Count >= 2)
					{
						this.ContextMenu = this.AlignContextMenu;
					}
					this.BoolMouseDown = false;
				}
			}
		}

		private void DesignPanel_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.DrawControl & this.BoolMouseDown)
			{
				this.g.Dispose();
				if (this._DrawInstanceItem != null)
				{
					if (this._DrawType == DrawCtrlType.Label)
					{
						if (this._DrawInstanceItem.BindMMetaItem.BindLabel | this._DrawInstanceItem.BindMMetaItem.Status == EPRStatus.ABandon)
						{
							DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
							if (releaseDrawContolEvent != null)
							{
								releaseDrawContolEvent();
								return;
							}
							return;
						}
					}
					else if (this._DrawInstanceItem.BindMMetaItem.BindControl | this._DrawInstanceItem.BindMMetaItem.Status == EPRStatus.ABandon)
					{
						DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
						if (releaseDrawContolEvent != null)
						{
							releaseDrawContolEvent();
							return;
						}
						return;
					}
				}
				if (this._DrawType == DrawCtrlType.Label)
				{
					DCLabel dCLabel = new DCLabel();
					dCLabel.Left = this.addXPos;
					dCLabel.Top = this.addYPos;
					dCLabel.Width = this.addCWidth;
					dCLabel.Height = this.addCHeight;
					if (this._DrawInstanceItem == null)
					{
						dCLabel.PCLabel.Text = "新建标签";
					}
					else
					{
						dCLabel.PCLabel.BindInstanceItem = this._DrawInstanceItem;
						this._DrawInstanceItem.BindMMetaItem.BindLabel = true;
					}
					dCLabel.PCLabel.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCLabel.PCLabel.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCLabel);
					dCLabel.Name = "lbl" + dCLabel.TabIndex.ToString();
					dCLabel.BringToFront();
					dCLabel.MultiSelected = true;
					this.SelectedCtls.Add(dCLabel);
					dCLabel.Selected = true;
					this.CurrentControl = dCLabel;
					this.FocusControl = dCLabel;
					this.curLablePropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curLablePropertyWrap;
					this.ScrollControlIntoView(dCLabel);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIString)
				{
					DCString dCString = new DCString();
					dCString.Left = this.addXPos;
					dCString.Top = this.addYPos;
					dCString.Width = this.addCWidth;
					dCString.Height = this.addCHeight;
					dCString.Enabled = true;
					dCString.PCString.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCString.PCString.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCString.PCString.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCString);
					dCString.Name = "txt" + dCString.TabIndex.ToString();
					dCString.BringToFront();
					dCString.MultiSelected = true;
					this.SelectedCtls.Add(dCString);
					dCString.Selected = true;
					this.CurrentControl = dCString;
					this.FocusControl = dCString;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCString);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MINumber)
				{
					DCNumber dCNumber = new DCNumber();
					dCNumber.Left = this.addXPos;
					dCNumber.Top = this.addYPos;
					dCNumber.Width = this.addCWidth;
					dCNumber.Height = this.addCHeight;
					dCNumber.PCNumber.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCNumber.PCNumber.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCNumber.PCNumber.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCNumber);
					dCNumber.Name = "num" + dCNumber.TabIndex.ToString();
					dCNumber.BringToFront();
					dCNumber.MultiSelected = true;
					this.SelectedCtls.Add(dCNumber);
					dCNumber.Selected = true;
					this.CurrentControl = dCNumber;
					this.FocusControl = dCNumber;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCNumber);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIMonoChoice)
				{
					DCMonoChoice dCMonoChoice = new DCMonoChoice();
					dCMonoChoice.Left = this.addXPos;
					dCMonoChoice.Top = this.addYPos;
					dCMonoChoice.Width = this.addCWidth;
					dCMonoChoice.Height = this.addCHeight;
					dCMonoChoice.PCMonoChoice.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCMonoChoice.PCMonoChoice.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCMonoChoice.PCMonoChoice.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCMonoChoice);
					dCMonoChoice.Name = "cbx" + dCMonoChoice.TabIndex.ToString();
					dCMonoChoice.BringToFront();
					dCMonoChoice.MultiSelected = true;
					this.SelectedCtls.Add(dCMonoChoice);
					dCMonoChoice.Selected = true;
					this.CurrentControl = dCMonoChoice;
					this.FocusControl = dCMonoChoice;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCMonoChoice);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIMultiChoice)
				{
					DCMultiChoice dCMultiChoice = new DCMultiChoice();
					dCMultiChoice.Left = this.addXPos;
					dCMultiChoice.Top = this.addYPos;
					dCMultiChoice.Width = this.addCWidth;
					dCMultiChoice.Height = this.addCHeight;
					dCMultiChoice.PCMultiChoice.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCMultiChoice.PCMultiChoice.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCMultiChoice.PCMultiChoice.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCMultiChoice);
					dCMultiChoice.Name = "mlt" + dCMultiChoice.TabIndex.ToString();
					dCMultiChoice.BringToFront();
					dCMultiChoice.MultiSelected = true;
					this.SelectedCtls.Add(dCMultiChoice);
					dCMultiChoice.Selected = true;
					this.CurrentControl = dCMultiChoice;
					this.FocusControl = dCMultiChoice;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCMultiChoice);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIDateTime)
				{
					DCDateTime dCDateTime = new DCDateTime();
					dCDateTime.Left = this.addXPos;
					dCDateTime.Top = this.addYPos;
					dCDateTime.Width = this.addCWidth;
					dCDateTime.Height = this.addCHeight;
					dCDateTime.PCDateTime.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCDateTime.PCDateTime.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCDateTime.PCDateTime.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCDateTime);
					dCDateTime.Name = "dtb" + dCDateTime.TabIndex.ToString();
					dCDateTime.BringToFront();
					dCDateTime.MultiSelected = true;
					this.SelectedCtls.Add(dCDateTime);
					dCDateTime.Selected = true;
					this.CurrentControl = dCDateTime;
					this.FocusControl = dCDateTime;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCDateTime);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIQuantity)
				{
					DCQuantity dCQuantity = new DCQuantity();
					dCQuantity.Left = this.addXPos;
					dCQuantity.Top = this.addYPos;
					dCQuantity.Width = this.addCWidth;
					dCQuantity.Height = this.addCHeight;
					dCQuantity.PCQuantity.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCQuantity.PCQuantity.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCQuantity.PCQuantity.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCQuantity);
					dCQuantity.Name = "qty" + dCQuantity.TabIndex.ToString();
					dCQuantity.BringToFront();
					dCQuantity.MultiSelected = true;
					this.SelectedCtls.Add(dCQuantity);
					dCQuantity.Selected = true;
					this.CurrentControl = dCQuantity;
					this.FocusControl = dCQuantity;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCQuantity);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIDictionary)
				{
					DCDictionary dCDictionary = new DCDictionary();
					dCDictionary.Left = this.addXPos;
					dCDictionary.Top = this.addYPos;
					dCDictionary.Width = this.addCWidth;
					dCDictionary.Height = this.addCHeight;
					dCDictionary.PCDictionary.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCDictionary.PCDictionary.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCDictionary.PCDictionary.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCDictionary);
					dCDictionary.Name = "dic" + dCDictionary.TabIndex.ToString();
					dCDictionary.BringToFront();
					dCDictionary.MultiSelected = true;
					this.SelectedCtls.Add(dCDictionary);
					dCDictionary.Selected = true;
					this.CurrentControl = dCDictionary;
					this.FocusControl = dCDictionary;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCDictionary);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIPosition)
				{
					DCPosition dCPosition = new DCPosition();
					dCPosition.Left = this.addXPos;
					dCPosition.Top = this.addYPos;
					dCPosition.Width = this.addCWidth;
					dCPosition.Height = this.addCHeight;
					dCPosition.PCPosition.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCPosition.PCPosition.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCPosition.PCPosition.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCPosition);
					dCPosition.Name = "pos" + dCPosition.TabIndex.ToString();
					dCPosition.BringToFront();
					dCPosition.MultiSelected = true;
					this.SelectedCtls.Add(dCPosition);
					dCPosition.Selected = true;
					this.CurrentControl = dCPosition;
					this.FocusControl = dCPosition;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCPosition);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MISegment)
				{
					DCTextEdit dCTextEdit = new DCTextEdit();
					dCTextEdit.Left = this.addXPos;
					dCTextEdit.Top = this.addYPos;
					dCTextEdit.Width = this.addCWidth;
					dCTextEdit.Height = this.addCHeight;
					dCTextEdit.PCTextEdit.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCTextEdit.PCTextEdit.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCTextEdit.PCTextEdit.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCTextEdit);
					dCTextEdit.Name = "sgm" + dCTextEdit.TabIndex.ToString();
					dCTextEdit.BringToFront();
					dCTextEdit.MultiSelected = true;
					this.SelectedCtls.Add(dCTextEdit);
					dCTextEdit.Selected = true;
					this.CurrentControl = dCTextEdit;
					this.FocusControl = dCTextEdit;
					this.curTextPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curTextPropertyWrap;
					this.ScrollControlIntoView(dCTextEdit);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MITextDesc)
				{
					DCTextEdit dCTextEdit2 = new DCTextEdit();
					dCTextEdit2.Left = this.addXPos;
					dCTextEdit2.Top = this.addYPos;
					dCTextEdit2.Width = this.addCWidth;
					dCTextEdit2.Height = this.addCHeight;
					dCTextEdit2.PCTextEdit.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCTextEdit2.PCTextEdit.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCTextEdit2.PCTextEdit.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCTextEdit2);
					dCTextEdit2.Name = "dsc" + dCTextEdit2.TabIndex.ToString();
					dCTextEdit2.BringToFront();
					dCTextEdit2.MultiSelected = true;
					this.SelectedCtls.Add(dCTextEdit2);
					dCTextEdit2.Selected = true;
					this.CurrentControl = dCTextEdit2;
					this.FocusControl = dCTextEdit2;
					this.curTextPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curTextPropertyWrap;
					this.ScrollControlIntoView(dCTextEdit2);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MITable)
				{
					DCTable dCTable = new DCTable();
					dCTable.Left = this.addXPos;
					dCTable.Top = this.addYPos;
					dCTable.Width = this.addCWidth;
					dCTable.Height = this.addCHeight;
					NITable nITable = (NITable)this._DrawInstanceItem;
					nITable.InitialData();
					dCTable.PCTable.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCTable.PCTable.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCTable.PCTable.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCTable);
					dCTable.Name = "tbl" + dCTable.TabIndex.ToString();
					dCTable.BringToFront();
					dCTable.MultiSelected = true;
					this.SelectedCtls.Add(dCTable);
					dCTable.Selected = true;
					this.CurrentControl = dCTable;
					this.FocusControl = dCTable;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCTable);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIImageAnnotate)
				{
					DCImageAnnotate dCImageAnnotate = new DCImageAnnotate();
					dCImageAnnotate.Left = this.addXPos;
					dCImageAnnotate.Top = this.addYPos;
					dCImageAnnotate.Width = this.addCWidth;
					dCImageAnnotate.Height = this.addCHeight;
					NIImageAnnotate nIImageAnnotate = (NIImageAnnotate)this._DrawInstanceItem;
					dCImageAnnotate.PCImageAnnotate.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCImageAnnotate.PCImageAnnotate.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCImageAnnotate.PCImageAnnotate.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCImageAnnotate);
					dCImageAnnotate.Name = "ano" + dCImageAnnotate.TabIndex.ToString();
					dCImageAnnotate.BringToFront();
					dCImageAnnotate.MultiSelected = true;
					this.SelectedCtls.Add(dCImageAnnotate);
					dCImageAnnotate.Selected = true;
					this.CurrentControl = dCImageAnnotate;
					this.FocusControl = dCImageAnnotate;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCImageAnnotate);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.MIFigure)
				{
					DCFigure dCFigure = new DCFigure();
					dCFigure.Left = this.addXPos;
					dCFigure.Top = this.addYPos;
					dCFigure.Width = this.addCWidth;
					dCFigure.Height = this.addCHeight;
					NIFigure nIFigure = (NIFigure)this._DrawInstanceItem;
					nIFigure.InitData();
					dCFigure.PCFigure.BindInstanceItem = this._DrawInstanceItem;
					this._DrawInstanceItem.BindMMetaItem.BindControl = true;
					dCFigure.PCFigure.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCFigure.PCFigure.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCFigure);
					dCFigure.Name = "fig" + dCFigure.TabIndex.ToString();
					dCFigure.BringToFront();
					dCFigure.MultiSelected = true;
					this.SelectedCtls.Add(dCFigure);
					dCFigure.Selected = true;
					this.CurrentControl = dCFigure;
					this.FocusControl = dCFigure;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCFigure);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.HLine)
				{
					DCHLine dCHLine = new DCHLine();
					dCHLine.Left = this.addXPos;
					dCHLine.Top = this.addYPos;
					dCHLine.Width = this.addCWidth;
					dCHLine.Height = this.addCHeight;
					dCHLine.PCHLine.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCHLine.PCHLine.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCHLine);
					dCHLine.Name = "hln" + dCHLine.TabIndex.ToString();
					dCHLine.BringToFront();
					dCHLine.MultiSelected = true;
					this.SelectedCtls.Add(dCHLine);
					dCHLine.Selected = true;
					this.CurrentControl = dCHLine;
					this.FocusControl = dCHLine;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCHLine);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.VLine)
				{
					DCVLine dCVLine = new DCVLine();
					dCVLine.Left = this.addXPos;
					dCVLine.Top = this.addYPos;
					dCVLine.Width = this.addCWidth;
					dCVLine.Height = this.addCHeight;
					dCVLine.PCVLine.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCVLine.PCVLine.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCVLine);
					dCVLine.Name = "hln" + dCVLine.TabIndex.ToString();
					dCVLine.BringToFront();
					dCVLine.MultiSelected = true;
					this.SelectedCtls.Add(dCVLine);
					dCVLine.Selected = true;
					this.CurrentControl = dCVLine;
					this.FocusControl = dCVLine;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCVLine);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.Box)
				{
					DCBox dCBox = new DCBox();
					dCBox.Left = this.addXPos;
					dCBox.Top = this.addYPos;
					dCBox.Width = this.addCWidth;
					dCBox.Height = this.addCHeight;
					dCBox.PCBox.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCBox.PCBox.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCBox);
					dCBox.Name = "box" + dCBox.TabIndex.ToString();
					dCBox.BringToFront();
					dCBox.MultiSelected = true;
					this.SelectedCtls.Add(dCBox);
					dCBox.Selected = true;
					this.CurrentControl = dCBox;
					this.FocusControl = dCBox;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCBox);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
				else if (this._DrawType == DrawCtrlType.AlignTable)
				{
					DCAlignTable dCAlignTable = new DCAlignTable();
					dCAlignTable.Left = this.addXPos;
					dCAlignTable.Top = this.addYPos;
					dCAlignTable.Width = this.addCWidth;
					dCAlignTable.Height = this.addCHeight;
					dCAlignTable.PCAlignTable.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
					dCAlignTable.PCAlignTable.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
					this.AddControl(dCAlignTable);
					dCAlignTable.DesignPanel = this;
					dCAlignTable.PCAlignTable.InstanceData = this.InstanceData;
					dCAlignTable.Name = "atb" + dCAlignTable.TabIndex.ToString();
					dCAlignTable.BringToFront();
					dCAlignTable.MultiSelected = true;
					this.SelectedCtls.Add(dCAlignTable);
					dCAlignTable.Selected = true;
					this.CurrentControl = dCAlignTable;
					this.FocusControl = dCAlignTable;
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
					this.ScrollControlIntoView(dCAlignTable);
					this.FocusControl.Focus();
					DesignPanel.ReleaseDrawContolEventHandler releaseDrawContolEvent = this.ReleaseDrawContolEvent;
					if (releaseDrawContolEvent != null)
					{
						releaseDrawContolEvent();
					}
					DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
					if (refreshControlListEvent != null)
					{
						refreshControlListEvent();
					}
				}
			}
			else if (!this.DrawControl & this.BoolMouseDown)
			{
				this.MouseX = (float)e.X;
				this.MouseY = (float)e.Y;
				this.g.Dispose();
				if (this.MouseX > (float)this.XPos & this.MouseY > (float)this.YPos)
				{
					try
					{
						IEnumerator enumerator = this.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DesignControl designControl = (DesignControl)enumerator.Current;
							if (designControl.Left > this.XPos & (float)designControl.Left < this.MouseX & designControl.Top > this.YPos & (float)designControl.Top < this.MouseY)
							{
								designControl.MultiSelected = true;
								this.SelectedCtls.Add(designControl);
							}
						}
						goto IL_1C2B;
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
				if (this.MouseX < (float)this.XPos & this.MouseY > (float)this.YPos)
				{
					try
					{
						IEnumerator enumerator2 = this.Controls.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DesignControl designControl2 = (DesignControl)enumerator2.Current;
							if (designControl2.Left < this.XPos & (float)designControl2.Left > this.MouseX & designControl2.Top > this.YPos & (float)designControl2.Top < this.MouseY)
							{
								designControl2.MultiSelected = true;
								this.SelectedCtls.Add(designControl2);
							}
						}
						goto IL_1C2B;
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
				if (this.MouseX < (float)this.XPos & this.MouseY < (float)this.YPos)
				{
					try
					{
						IEnumerator enumerator3 = this.Controls.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DesignControl designControl3 = (DesignControl)enumerator3.Current;
							if (designControl3.Left < this.XPos & (float)designControl3.Left > this.MouseX & designControl3.Top < this.YPos & (float)designControl3.Top > this.MouseY)
							{
								designControl3.MultiSelected = true;
								this.SelectedCtls.Add(designControl3);
							}
						}
						goto IL_1C2B;
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
				if (this.MouseX > (float)this.XPos & this.MouseY < (float)this.YPos)
				{
					try
					{
						IEnumerator enumerator4 = this.Controls.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DesignControl designControl4 = (DesignControl)enumerator4.Current;
							if (designControl4.Left > this.XPos & (float)designControl4.Left < this.MouseX & designControl4.Top < this.YPos & (float)designControl4.Top > this.MouseY)
							{
								designControl4.MultiSelected = true;
								this.SelectedCtls.Add(designControl4);
							}
						}
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				IL_1C2B:
				this.Focus();
			}
			this.BoolMouseDown = false;
			this.DrawControl = false;
			this.Cursor = Cursors.Default;
			this.Refresh();
		}

		private void DesignPanel_Paint(object sender, PaintEventArgs e)
		{
			this.g = this.CreateGraphics();
			ControlPaint.DrawGrid(this.g, this.DisplayRectangle, this._GridSize, this.BackColor);
			checked
			{
				if (this.BoolMouseDown)
				{
					Pen pen = new Pen(Color.Black, 1f);
					pen.DashStyle = DashStyle.Dot;
					if (this.MouseX > (float)this.XPos & this.MouseY > (float)this.YPos)
					{
						this.addCWidth = (int)Math.Round((double)(unchecked(this.MouseX - (float)this.XPos)));
						this.addCHeight = (int)Math.Round((double)(unchecked(this.MouseY - (float)this.YPos)));
						this.addXPos = this.XPos;
						this.addYPos = this.YPos;
					}
					else if (this.MouseX > (float)this.XPos & this.MouseY < (float)this.YPos)
					{
						this.addCWidth = (int)Math.Round((double)(unchecked(this.MouseX - (float)this.XPos)));
						this.addCHeight = (int)Math.Round((double)(unchecked((float)this.YPos - this.MouseY)));
						this.addXPos = this.XPos;
						this.addYPos = (int)Math.Round((double)this.MouseY);
					}
					else if (this.MouseX < (float)this.XPos & this.MouseY > (float)this.YPos)
					{
						this.addCWidth = (int)Math.Round((double)(unchecked((float)this.XPos - this.MouseX)));
						this.addCHeight = (int)Math.Round((double)(unchecked(this.MouseY - (float)this.YPos)));
						this.addXPos = (int)Math.Round((double)this.MouseX);
						this.addYPos = this.YPos;
					}
					else if (this.MouseX < (float)this.XPos & this.MouseY < (float)this.YPos)
					{
						this.addCWidth = (int)Math.Round((double)(unchecked((float)this.XPos - this.MouseX)));
						this.addCHeight = (int)Math.Round((double)(unchecked((float)this.YPos - this.MouseY)));
						this.addXPos = (int)Math.Round((double)this.MouseX);
						this.addYPos = (int)Math.Round((double)this.MouseY);
					}
					this.g.DrawRectangle(pen, this.addXPos, this.addYPos, this.addCWidth, this.addCHeight);
				}
			}
		}

		private void DesignPanel_MouseMove(object sender, MouseEventArgs e)
		{
			this.MouseX = (float)e.X;
			this.MouseY = (float)e.Y;
			if (this.BoolMouseDown)
			{
				this.Refresh();
			}
		}

		private void SetDefaultFont()
		{
			SysOptionInfo sysOptionAccess = WebServiceLayer.SysOptionAccess;
			double num = 9.0;
			double num2 = Conversions.ToDouble(SysOptionManager.GetSysOptionValue("DefaultFontSize", "9"));
			if (num2 != 0.0)
			{
				num = num2;
			}
			this.Font = new Font(this.Font.Name, (float)num);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			this.PaintLine(e);
			this.PaintScale(e);
		}

		private void AddControl(Control curControl)
		{
			curControl.MouseEnter += new EventHandler(this.MouseEnterEventHandler);
			curControl.MouseDown += new MouseEventHandler(this.MouseDownEventHandler);
			curControl.MouseMove += new MouseEventHandler(this.MouseMoveEventHandler);
			curControl.MouseUp += new MouseEventHandler(this.MouseUpEventHandler);
			curControl.MouseLeave += new EventHandler(this.MouseLeaveEventHandler);
			curControl.KeyDown += new KeyEventHandler(this.KeyDownHandler);
			Point location = curControl.Location;
			int x;
			if (location.X < 10)
			{
				x = 10;
			}
			else
			{
				location = curControl.Location;
				x = location.X;
			}
			int y;
			if (curControl.Top < 10)
			{
				y = 10;
			}
			else
			{
				location = curControl.Location;
				y = location.Y;
			}
			location = new Point(x, y);
			curControl.Location = location;
			curControl.Font = this.Font;
			this.Controls.Add(curControl);
		}

		protected void MouseEnterEventHandler(object sender, EventArgs e)
		{
			this.CurrentControl = (DesignControl)sender;
			this.CurrentControl.Cursor = Cursors.SizeAll;
		}

		protected void ChildMouseEnterEventHandler(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			control.Cursor = Cursors.Default;
		}

		protected void MouseDownEventHandler(object sender, MouseEventArgs e)
		{
			this.CurrentControl = (DesignControl)sender;
			bool flag = false;
			if ((Control.ModifierKeys & Keys.Control & ((-((!this.SelectedCtls.Contains(this.CurrentControl) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.CurrentControl.MultiSelected = true;
				flag = true;
				this.SelectedCtls.Add(this.CurrentControl);
				if (this.CurrentControl.Left < this.leftest)
				{
					this.leftest = this.CurrentControl.Left;
				}
				if (this.CurrentControl.Top < this.topest)
				{
					this.topest = this.CurrentControl.Top;
				}
			}
			else if ((~Control.ModifierKeys & Keys.Control & ((-((!this.SelectedCtls.Contains(this.CurrentControl) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				int arg_E3_0 = 0;
				checked
				{
					int num = this.SelectedCtls.Count - 1;
					for (int i = arg_E3_0; i <= num; i++)
					{
						DesignControl designControl = (DesignControl)this.SelectedCtls[i];
						designControl.MultiSelected = false;
					}
					this.SelectedCtls.Clear();
					this.SelectedCtls.Add(this.CurrentControl);
					this.CurrentControl.MultiSelected = true;
					flag = true;
					this.leftest = this.CurrentControl.Left;
					this.topest = this.CurrentControl.Top;
				}
			}
			if (this.FocusControl != null)
			{
				this.FocusControl.Selected = false;
			}
			this.FocusControl = this.CurrentControl;
			this.FocusControl.Selected = true;
			if (e.Button == MouseButtons.Left)
			{
				this.LeftButtonDown = true;
				if (flag)
				{
					Control arg_1B7_0 = this.CurrentControl;
					Point p = checked(new Point(e.X + 8, e.Y + 8));
					this.ClickedPoint = arg_1B7_0.PointToScreen(p);
				}
				else
				{
					Control arg_1DF_0 = this.CurrentControl;
					Point p = new Point(e.X, e.Y);
					this.ClickedPoint = arg_1DF_0.PointToScreen(p);
				}
			}
			if (e.Button == MouseButtons.Right)
			{
				if (this.SelectedCtls.Count >= 2)
				{
					this.FocusControl.ContextMenu = this.AlignContextMenu;
				}
				this.RightButtonDown = true;
			}
			this.Refresh();
		}

		protected void ChildMouseDownEventHandler(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			this.CurrentControl = (DesignControl)control.Parent;
			if ((Control.ModifierKeys & Keys.Control & ((-((!this.SelectedCtls.Contains(this.CurrentControl) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.CurrentControl.MultiSelected = true;
				this.SelectedCtls.Add(this.CurrentControl);
				if (this.CurrentControl.Left < this.leftest)
				{
					this.leftest = this.CurrentControl.Left;
				}
				if (this.CurrentControl.Top < this.topest)
				{
					this.topest = this.CurrentControl.Top;
				}
			}
			else if ((~Control.ModifierKeys & Keys.Control & ((-((!this.SelectedCtls.Contains(this.CurrentControl) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				int arg_F0_0 = 0;
				checked
				{
					int num = this.SelectedCtls.Count - 1;
					for (int i = arg_F0_0; i <= num; i++)
					{
						DesignControl designControl = (DesignControl)this.SelectedCtls[i];
						designControl.MultiSelected = false;
					}
					this.SelectedCtls.Clear();
					this.SelectedCtls.Add(this.CurrentControl);
					this.CurrentControl.MultiSelected = true;
					this.leftest = this.CurrentControl.Left;
					this.topest = this.CurrentControl.Top;
				}
			}
			if (this.FocusControl != null)
			{
				this.FocusControl.Selected = false;
			}
			this.FocusControl = this.CurrentControl;
		}

		protected void MouseUpEventHandler(object sender, MouseEventArgs e)
		{
			if (this.LeftButtonDown)
			{
				this.LeftButtonDown = false;
				this.ScrollControlIntoView(this.FocusControl);
				if (this.FocusControl is DCLabel)
				{
					this.curLablePropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curLablePropertyWrap;
				}
				else if (this.FocusControl is DCTextEdit)
				{
					this.curTextPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curTextPropertyWrap;
				}
				else
				{
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
				}
				this.PropertyGrid.Refresh();
				this.FocusControl.Focus();
			}
			if (this.RightButtonDown)
			{
				this.RightButtonDown = false;
			}
		}

		private void MouseMoveEventHandler(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.LeftButtonDown)
				{
					Point clickedPoint = default(Point);
					Control arg_2A_0 = this.CurrentControl;
					Point p = new Point(e.X, e.Y);
					clickedPoint = arg_2A_0.PointToScreen(p);
					this.MoveSize(this.CurrentSizeMode, clickedPoint.X - this.ClickedPoint.X, clickedPoint.Y - this.ClickedPoint.Y);
					this.ClickedPoint = clickedPoint;
				}
				else if (!this.LeftButtonDown & this.CurrentControl != null)
				{
					if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & !this.CurrentControl.FixedHeight & e.X >= 0 & e.X <= 7 & e.Y >= 0 & e.Y <= 7)
					{
						this.CurrentControl.Cursor = Cursors.SizeNWSE;
						this.CurrentSizeMode = SizeMode.UpLeft;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & !this.CurrentControl.FixedHeight & e.X >= this.CurrentControl.Width - 6 & e.X <= this.CurrentControl.Width & e.Y >= 0 & e.Y <= 7)
					{
						this.CurrentControl.Cursor = Cursors.SizeNESW;
						this.CurrentSizeMode = SizeMode.UpRight;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & !this.CurrentControl.FixedHeight & e.X >= 0 & e.X <= 7 & e.Y >= this.CurrentControl.Height - 6 & e.Y <= this.CurrentControl.Height)
					{
						this.CurrentControl.Cursor = Cursors.SizeNESW;
						this.CurrentSizeMode = SizeMode.DownLeft;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & !this.CurrentControl.FixedHeight & e.X >= this.CurrentControl.Width - 6 & e.X <= this.CurrentControl.Width & e.Y >= this.CurrentControl.Height - 6 & e.Y <= this.CurrentControl.Height)
					{
						this.CurrentControl.Cursor = Cursors.SizeNWSE;
						this.CurrentSizeMode = SizeMode.DownRight;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedHeight & e.X >= this.CurrentControl.Width / 2 - 3 & e.X <= this.CurrentControl.Width / 2 + 4 & e.Y >= 0 & e.Y <= 7)
					{
						this.CurrentControl.Cursor = Cursors.SizeNS;
						this.CurrentSizeMode = SizeMode.Up;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & e.X >= 0 & e.X <= 7 & e.Y >= this.CurrentControl.Height / 2 - 3 & e.Y <= this.CurrentControl.Height / 2 + 4)
					{
						this.CurrentControl.Cursor = Cursors.SizeWE;
						this.CurrentSizeMode = SizeMode.Left;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedHeight & e.X >= this.CurrentControl.Width / 2 - 3 & e.X <= this.CurrentControl.Width / 2 + 4 & e.Y >= this.CurrentControl.Height - 6 & e.Y <= this.CurrentControl.Height)
					{
						this.CurrentControl.Cursor = Cursors.SizeNS;
						this.CurrentSizeMode = SizeMode.Down;
					}
					else if (this.CurrentControl.MultiSelected & !this.CurrentControl.FixedWidth & e.X >= this.CurrentControl.Width - 6 & e.X <= this.CurrentControl.Width & e.Y >= this.CurrentControl.Height / 2 - 3 & e.Y <= this.CurrentControl.Height / 2 + 4)
					{
						this.CurrentControl.Cursor = Cursors.SizeWE;
						this.CurrentSizeMode = SizeMode.Right;
					}
					else
					{
						this.CurrentControl.Cursor = Cursors.SizeAll;
						this.CurrentSizeMode = SizeMode.Move;
					}
				}
			}
		}

		private void MouseLeaveEventHandler(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteControls();
				this.curControlPropertyWrap.curControl = null;
				this.curLablePropertyWrap.curControl = null;
				this.curTextPropertyWrap.curControl = null;
			}
			if ((Control.ModifierKeys & Keys.Control & ((-(((e.KeyCode == Keys.Left) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveControls(-1, 0);
			}
			if ((Control.ModifierKeys & Keys.Control & ((-(((e.KeyCode == Keys.Right) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveControls(1, 0);
			}
			if ((Control.ModifierKeys & Keys.Control & ((-(((e.KeyCode == Keys.Up) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveControls(0, -1);
			}
			if ((Control.ModifierKeys & Keys.Control & ((-(((e.KeyCode == Keys.Down) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveControls(0, 1);
			}
			if ((Control.ModifierKeys & Keys.Control & ((-(((e.KeyCode == Keys.Z) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.UndoExecute();
			}
			if ((Control.ModifierKeys & Keys.Shift & ((-(((e.KeyCode == Keys.Left) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveSize(SizeMode.Right, -1, 0);
			}
			if ((Control.ModifierKeys & Keys.Shift & ((-(((e.KeyCode == Keys.Right) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveSize(SizeMode.Right, 1, 0);
			}
			if ((Control.ModifierKeys & Keys.Shift & ((-(((e.KeyCode == Keys.Up) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveSize(SizeMode.Down, 0, -1);
			}
			if ((Control.ModifierKeys & Keys.Shift & ((-(((e.KeyCode == Keys.Down) > false) ? Keys.LButton : Keys.None)) ? Keys.LButton : Keys.None)) > Keys.None)
			{
				this.MoveSize(SizeMode.Down, 0, 1);
			}
			if (this.FocusControl != null)
			{
				this.ScrollControlIntoView(this.FocusControl);
				this.PropertyGrid.Refresh();
				this.FocusControl.Focus();
			}
		}

		private void MoveControls(int x, int y)
		{
			checked
			{
				int num = this.leftest + x;
				int num2 = this.topest + y;
				if (num >= 10 & num2 >= 10)
				{
					DesignPanel.StructMove st = default(DesignPanel.StructMove);
					try
					{
						IEnumerator enumerator = this.SelectedCtls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							control.Left += x;
							control.Top += y;
							st.m_falg = UndoMode.Move;
							st.m_ctrl = control;
							st.m_move = new List<int>();
							st.m_move.Add(x);
							st.m_move.Add(y);
							this.UndoAdd(st);
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
					this.leftest = num;
					this.topest = num2;
					if (this.FocusControl != null)
					{
						this.FocusControl.Focus();
					}
				}
			}
		}

		private void MoveSize(SizeMode curSizeMode, int x, int y)
		{
			checked
			{
				switch (curSizeMode)
				{
				case SizeMode.Move:
					this.MoveControls(x, y);
					return;
				case SizeMode.Left:
					goto IL_264;
				case SizeMode.Right:
					goto IL_31A;
				case SizeMode.Up:
					goto IL_202;
				case SizeMode.Down:
					goto IL_2C6;
				case SizeMode.UpLeft:
					this.MoveControls(x, y);
					try
					{
						IEnumerator enumerator = this.SelectedCtls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							Control control2 = control;
							control2.Width -= x;
							control2 = control;
							control2.Height -= y;
						}
						return;
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					break;
				case SizeMode.UpRight:
					goto IL_18F;
				case SizeMode.DownLeft:
					break;
				case SizeMode.DownRight:
					goto IL_124;
				default:
					return;
				}
				this.MoveControls(x, 0);
				try
				{
					IEnumerator enumerator2 = this.SelectedCtls.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Control control3 = (Control)enumerator2.Current;
						Control control2 = control3;
						control2.Width -= x;
						control2 = control3;
						control2.Height += y;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				try
				{
					IL_124:
					IEnumerator enumerator3 = this.SelectedCtls.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Control control4 = (Control)enumerator3.Current;
						Control control2 = control4;
						control2.Width += x;
						control2 = control4;
						control2.Height += y;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				IL_18F:
				this.MoveControls(0, y);
				try
				{
					IEnumerator enumerator4 = this.SelectedCtls.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						Control control5 = (Control)enumerator4.Current;
						Control control2 = control5;
						control2.Width += x;
						control2 = control5;
						control2.Height -= y;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				IL_202:
				this.MoveControls(0, y);
				try
				{
					IEnumerator enumerator5 = this.SelectedCtls.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						Control control6 = (Control)enumerator5.Current;
						Control control2 = control6;
						control2.Height -= y;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				IL_264:
				this.MoveControls(x, 0);
				try
				{
					IEnumerator enumerator6 = this.SelectedCtls.GetEnumerator();
					while (enumerator6.MoveNext())
					{
						Control control7 = (Control)enumerator6.Current;
						Control control2 = control7;
						control2.Width -= x;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
				try
				{
					IL_2C6:
					IEnumerator enumerator7 = this.SelectedCtls.GetEnumerator();
					while (enumerator7.MoveNext())
					{
						Control control8 = (Control)enumerator7.Current;
						Control control2 = control8;
						control2.Height += y;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator7;
					if (enumerator7 is IDisposable)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
				try
				{
					IL_31A:
					IEnumerator enumerator8 = this.SelectedCtls.GetEnumerator();
					while (enumerator8.MoveNext())
					{
						Control control9 = (Control)enumerator8.Current;
						Control control2 = control9;
						control2.Width += x;
					}
				}
				finally
				{
					IEnumerator enumerator8;
					if (enumerator8 is IDisposable)
					{
						(enumerator8 as IDisposable).Dispose();
					}
				}
			}
		}

		private void DeleteControls()
		{
			if (this.SelectedCtls.Count > 0)
			{
				try
				{
					IEnumerator enumerator = this.SelectedCtls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DesignControl designControl = (DesignControl)enumerator.Current;
						if (designControl is DCLabel)
						{
							DCLabel dCLabel = (DCLabel)designControl;
							if (dCLabel.PCLabel.BindInstanceItem != null)
							{
								dCLabel.PCLabel.BindInstanceItem.BindMMetaItem.BindLabel = false;
							}
						}
						else if (designControl is DCString)
						{
							DCString dCString = (DCString)designControl;
							dCString.PCString.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCNumber)
						{
							DCNumber dCNumber = (DCNumber)designControl;
							dCNumber.PCNumber.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCMonoChoice)
						{
							DCMonoChoice dCMonoChoice = (DCMonoChoice)designControl;
							dCMonoChoice.PCMonoChoice.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCMultiChoice)
						{
							DCMultiChoice dCMultiChoice = (DCMultiChoice)designControl;
							dCMultiChoice.PCMultiChoice.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCDictionary)
						{
							DCDictionary dCDictionary = (DCDictionary)designControl;
							dCDictionary.PCDictionary.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCDateTime)
						{
							DCDateTime dCDateTime = (DCDateTime)designControl;
							dCDateTime.PCDateTime.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCPosition)
						{
							DCPosition dCPosition = (DCPosition)designControl;
							dCPosition.PCPosition.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCQuantity)
						{
							DCQuantity dCQuantity = (DCQuantity)designControl;
							dCQuantity.PCQuantity.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCFigure)
						{
							DCFigure dCFigure = (DCFigure)designControl;
							dCFigure.PCFigure.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCTextEdit)
						{
							DCTextEdit dCTextEdit = (DCTextEdit)designControl;
							dCTextEdit.PCTextEdit.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						else if (designControl is DCTable)
						{
							DCTable dCTable = (DCTable)designControl;
							dCTable.PCTable.BindInstanceItem.BindMMetaItem.BindControl = false;
							dCTable.PCTable.BindInstanceItem.BindMMetaItem.BindInstanceItem.SubItems.Clear();
						}
						else if (designControl is DCImageAnnotate)
						{
							DCImageAnnotate dCImageAnnotate = (DCImageAnnotate)designControl;
							dCImageAnnotate.PCImageAnnotate.BindInstanceItem.BindMMetaItem.BindControl = false;
						}
						this.Controls.Remove(designControl);
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
				this.SelectedCtls.Clear();
				if (this.FocusControl != null)
				{
					this.FocusControl = null;
					this.PropertyGrid.SelectedObject = null;
				}
				DesignPanel.RefreshControlListEventHandler refreshControlListEvent = this.RefreshControlListEvent;
				if (refreshControlListEvent != null)
				{
					refreshControlListEvent();
				}
			}
		}

		public void HightlightControl(DesignControl control)
		{
			this.CurrentControl = control;
			int arg_18_0 = 0;
			checked
			{
				int num = this.SelectedCtls.Count - 1;
				for (int i = arg_18_0; i <= num; i++)
				{
					DesignControl designControl = (DesignControl)this.SelectedCtls[i];
					designControl.MultiSelected = false;
				}
				this.SelectedCtls.Clear();
				this.SelectedCtls.Add(this.CurrentControl);
				this.CurrentControl.MultiSelected = true;
				this.leftest = this.CurrentControl.Left;
				this.topest = this.CurrentControl.Top;
				if (this.FocusControl != null)
				{
					this.FocusControl.Selected = false;
					this.FocusControl = null;
				}
				this.FocusControl = this.CurrentControl;
				this.FocusControl.Selected = true;
				this.ScrollControlIntoView(this.FocusControl);
				if (this.FocusControl is DCLabel)
				{
					this.curLablePropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curLablePropertyWrap;
				}
				else if (this.FocusControl is DCTextEdit)
				{
					this.curTextPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curTextPropertyWrap;
				}
				else
				{
					this.curControlPropertyWrap.curControl = this.FocusControl;
					this.PropertyGrid.SelectedObject = this.curControlPropertyWrap;
				}
				this.PropertyGrid.Refresh();
				this.Refresh();
			}
		}

		public void ClearSelectedControls()
		{
			if (this.CurrentControl != null)
			{
				this.CurrentControl.Selected = false;
				this.CurrentControl = null;
			}
			if (this.FocusControl != null)
			{
				this.FocusControl.Selected = false;
				this.FocusControl = null;
			}
			this.curControlPropertyWrap.curControl = null;
			this.curLablePropertyWrap.curControl = null;
			this.curTextPropertyWrap.curControl = null;
			this.PropertyGrid.SelectedObject = null;
			this.PropertyGrid.Refresh();
			if (this.SelectedCtls.Count > 0)
			{
				try
				{
					IEnumerator enumerator = this.SelectedCtls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DesignControl designControl = (DesignControl)enumerator.Current;
						designControl.MultiSelected = false;
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
				this.SelectedCtls.Clear();
			}
			this.Refresh();
		}

		private void mitemLeftAlign_Click(object sender, EventArgs e)
		{
			int left = ((Control)this.SelectedCtls[0]).Left;
			int arg_26_0 = 1;
			checked
			{
				int num = this.SelectedCtls.Count - 1;
				for (int i = arg_26_0; i <= num; i++)
				{
					if (((Control)this.SelectedCtls[i]).Left < left)
					{
						left = ((Control)this.SelectedCtls[i]).Left;
					}
				}
				int arg_71_0 = 0;
				int num2 = this.SelectedCtls.Count - 1;
				for (int j = arg_71_0; j <= num2; j++)
				{
					((Control)this.SelectedCtls[j]).Left = left;
				}
			}
		}

		private void mitemRightAlign_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = ((Control)this.SelectedCtls[0]).Left + ((Control)this.SelectedCtls[0]).Width;
				int arg_3D_0 = 1;
				int num2 = this.SelectedCtls.Count - 1;
				for (int i = arg_3D_0; i <= num2; i++)
				{
					if (((Control)this.SelectedCtls[i]).Left + ((Control)this.SelectedCtls[0]).Width > num)
					{
						num = ((Control)this.SelectedCtls[i]).Left + ((Control)this.SelectedCtls[0]).Width;
					}
				}
				int arg_B6_0 = 0;
				int num3 = this.SelectedCtls.Count - 1;
				for (int j = arg_B6_0; j <= num3; j++)
				{
					((Control)this.SelectedCtls[j]).Left = num - ((Control)this.SelectedCtls[j]).Width;
				}
			}
		}

		private void mitemTopAlign_Click(object sender, EventArgs e)
		{
			int top = ((Control)this.SelectedCtls[0]).Top;
			int arg_26_0 = 1;
			checked
			{
				int num = this.SelectedCtls.Count - 1;
				for (int i = arg_26_0; i <= num; i++)
				{
					if (((Control)this.SelectedCtls[i]).Top < top)
					{
						top = ((Control)this.SelectedCtls[i]).Top;
					}
				}
				int arg_71_0 = 0;
				int num2 = this.SelectedCtls.Count - 1;
				for (int j = arg_71_0; j <= num2; j++)
				{
					((Control)this.SelectedCtls[j]).Top = top;
				}
			}
		}

		private void mitemBottomAlign_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = ((Control)this.SelectedCtls[0]).Top + ((Control)this.SelectedCtls[0]).Height;
				int arg_3D_0 = 1;
				int num2 = this.SelectedCtls.Count - 1;
				for (int i = arg_3D_0; i <= num2; i++)
				{
					if (((Control)this.SelectedCtls[i]).Top + ((Control)this.SelectedCtls[0]).Height > num)
					{
						num = ((Control)this.SelectedCtls[i]).Top + ((Control)this.SelectedCtls[0]).Height;
					}
				}
				int arg_B6_0 = 0;
				int num3 = this.SelectedCtls.Count - 1;
				for (int j = arg_B6_0; j <= num3; j++)
				{
					((Control)this.SelectedCtls[j]).Top = num - ((Control)this.SelectedCtls[j]).Height;
				}
			}
		}

		private void mitemSameSizeAlgin_Click(object sender, EventArgs e)
		{
			int height = ((Control)this.SelectedCtls[0]).Height;
			int width = ((Control)this.SelectedCtls[0]).Width;
			int arg_3D_0 = 0;
			checked
			{
				int num = this.SelectedCtls.Count - 1;
				for (int i = arg_3D_0; i <= num; i++)
				{
					((Control)this.SelectedCtls[i]).Height = height;
					((Control)this.SelectedCtls[i]).Width = width;
				}
			}
		}

		private void mitemVSpacingcalAlgin_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.SelectedCtls.Count > 2)
				{
					ComparerWithCtrlTop comparer = new ComparerWithCtrlTop();
					this.SelectedCtls.Sort(comparer);
					int arg_33_0 = 1;
					int num = this.SelectedCtls.Count - 1;
					int num2;
					for (int i = arg_33_0; i <= num; i++)
					{
						num2 += ((Control)this.SelectedCtls[i]).Top - ((Control)this.SelectedCtls[i - 1]).Bottom;
					}
					int num3 = (int)Math.Round((double)num2 / (double)(this.SelectedCtls.Count - 1));
					int arg_99_0 = 1;
					int num4 = this.SelectedCtls.Count - 1;
					for (int j = arg_99_0; j <= num4; j++)
					{
						((Control)this.SelectedCtls[j]).Top = ((Control)this.SelectedCtls[j - 1]).Top + ((Control)this.SelectedCtls[j - 1]).Height + num3;
					}
				}
			}
		}

		private void mitemHSpacingAlgin_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.SelectedCtls.Count > 2)
				{
					ComparerWithCtrlLeft comparer = new ComparerWithCtrlLeft();
					this.SelectedCtls.Sort(comparer);
					int arg_33_0 = 1;
					int num = this.SelectedCtls.Count - 1;
					int num2;
					for (int i = arg_33_0; i <= num; i++)
					{
						num2 += ((Control)this.SelectedCtls[i]).Location.X - ((Control)this.SelectedCtls[i - 1]).Location.X;
					}
					int num3 = (int)Math.Round((double)num2 / (double)(this.SelectedCtls.Count - 1));
					int arg_AB_0 = 1;
					int num4 = this.SelectedCtls.Count - 1;
					for (int j = arg_AB_0; j <= num4; j++)
					{
						Point location = default(Point);
						location.X = ((Control)this.SelectedCtls[j - 1]).Location.X;
						location.Y = ((Control)this.SelectedCtls[j]).Location.Y;
						location.X += num3;
						((Control)this.SelectedCtls[j]).Location = location;
					}
				}
			}
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("Panel");
			writer.WriteElementString("BackColor", this.BackColor.Name);
			writer.WriteElementString("ForeColor", this.ForeColor.Name);
			writer.WriteStartElement("Controls");
			ControlXML.ScrollX = this.AutoScrollPosition.X;
			ControlXML.ScrollY = this.AutoScrollPosition.Y;
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DesignControl designControl = (DesignControl)enumerator.Current;
					designControl.XMLSerialize(writer);
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
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.BackColor = ControlXML.StrToColor(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.ForeColor = ControlXML.StrToColor(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCString", false) == 0)
					{
						DCString dCString = new DCString();
						dCString.XMLDeserialize(reader);
						dCString.PCString.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCString.PCString.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCString);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCNumber", false) == 0)
					{
						DCNumber dCNumber = new DCNumber();
						dCNumber.XMLDeserialize(reader);
						dCNumber.PCNumber.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCNumber.PCNumber.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCNumber);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMonoChoice", false) == 0)
					{
						DCMonoChoice dCMonoChoice = new DCMonoChoice();
						dCMonoChoice.XMLDeserialize(reader);
						dCMonoChoice.PCMonoChoice.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCMonoChoice.PCMonoChoice.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCMonoChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMultiChoice", false) == 0)
					{
						DCMultiChoice dCMultiChoice = new DCMultiChoice();
						dCMultiChoice.XMLDeserialize(reader);
						dCMultiChoice.PCMultiChoice.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCMultiChoice.PCMultiChoice.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCMultiChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDictionary", false) == 0)
					{
						DCDictionary dCDictionary = new DCDictionary();
						dCDictionary.XMLDeserialize(reader);
						dCDictionary.PCDictionary.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCDictionary.PCDictionary.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCDictionary);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCPosition", false) == 0)
					{
						DCPosition dCPosition = new DCPosition();
						dCPosition.XMLDeserialize(reader);
						dCPosition.PCPosition.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCPosition.PCPosition.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCPosition);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDateTime", false) == 0)
					{
						DCDateTime dCDateTime = new DCDateTime();
						dCDateTime.XMLDeserialize(reader);
						dCDateTime.PCDateTime.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCDateTime.PCDateTime.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCDateTime);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCQuantity", false) == 0)
					{
						DCQuantity dCQuantity = new DCQuantity();
						dCQuantity.XMLDeserialize(reader);
						dCQuantity.PCQuantity.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCQuantity.PCQuantity.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCQuantity);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTextEdit", false) == 0)
					{
						DCTextEdit dCTextEdit = new DCTextEdit();
						dCTextEdit.XMLDeserialize(reader);
						dCTextEdit.PCTextEdit.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCTextEdit.PCTextEdit.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCTextEdit);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTable", false) == 0)
					{
						DCTable dCTable = new DCTable();
						dCTable.XMLDeserialize(reader);
						dCTable.PCTable.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCTable.PCTable.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCTable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCImageAnnotate", false) == 0)
					{
						DCImageAnnotate dCImageAnnotate = new DCImageAnnotate();
						dCImageAnnotate.XMLDeserialize(reader);
						dCImageAnnotate.PCImageAnnotate.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCImageAnnotate.PCImageAnnotate.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCImageAnnotate);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCFigure", false) == 0)
					{
						DCFigure dCFigure = new DCFigure();
						dCFigure.XMLDeserialize(reader);
						dCFigure.PCFigure.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCFigure.PCFigure.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCFigure);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCLabel", false) == 0)
					{
						DCLabel dCLabel = new DCLabel();
						dCLabel.XMLDeserialize(reader);
						dCLabel.PCLabel.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCLabel.PCLabel.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCLabel);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCHLine", false) == 0)
					{
						DCHLine dCHLine = new DCHLine();
						dCHLine.XMLDeserialize(reader);
						dCHLine.PCHLine.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCHLine.PCHLine.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCHLine);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCVLine", false) == 0)
					{
						DCVLine dCVLine = new DCVLine();
						dCVLine.XMLDeserialize(reader);
						dCVLine.PCVLine.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCVLine.PCVLine.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCVLine);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCBox", false) == 0)
					{
						DCBox dCBox = new DCBox();
						dCBox.XMLDeserialize(reader);
						dCBox.PCBox.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCBox.PCBox.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCBox);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCAlignTable", false) == 0)
					{
						DCAlignTable dCAlignTable = new DCAlignTable();
						dCAlignTable.PCAlignTable.InstanceData = this.InstanceData;
						dCAlignTable.XMLDeserialize(reader);
						dCAlignTable.DesignPanel = this;
						dCAlignTable.PCAlignTable.MouseDown += new MouseEventHandler(this.ChildMouseDownEventHandler);
						dCAlignTable.PCAlignTable.MouseEnter += new EventHandler(this.ChildMouseEnterEventHandler);
						this.AddControl(dCAlignTable);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}

		public void BindInstance()
		{
			checked
			{
				try
				{
					IEnumerator enumerator = this.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DesignControl designControl = (DesignControl)enumerator.Current;
						if (designControl is DCLabel)
						{
							DCLabel dCLabel = (DCLabel)designControl;
							dCLabel.PCLabel.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCLabel.PCLabel.Code);
						}
						else if (designControl is DCString)
						{
							DCString dCString = (DCString)designControl;
							dCString.PCString.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCString.PCString.Code);
						}
						else if (designControl is DCNumber)
						{
							DCNumber dCNumber = (DCNumber)designControl;
							dCNumber.PCNumber.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCNumber.PCNumber.Code);
						}
						else if (designControl is DCMonoChoice)
						{
							DCMonoChoice dCMonoChoice = (DCMonoChoice)designControl;
							dCMonoChoice.PCMonoChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCMonoChoice.PCMonoChoice.Code);
						}
						else if (designControl is DCMultiChoice)
						{
							DCMultiChoice dCMultiChoice = (DCMultiChoice)designControl;
							dCMultiChoice.PCMultiChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCMultiChoice.PCMultiChoice.Code);
						}
						else if (designControl is DCDateTime)
						{
							DCDateTime dCDateTime = (DCDateTime)designControl;
							dCDateTime.PCDateTime.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCDateTime.PCDateTime.Code);
						}
						else if (designControl is DCDictionary)
						{
							DCDictionary dCDictionary = (DCDictionary)designControl;
							dCDictionary.PCDictionary.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCDictionary.PCDictionary.Code);
						}
						else if (designControl is DCQuantity)
						{
							DCQuantity dCQuantity = (DCQuantity)designControl;
							dCQuantity.PCQuantity.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCQuantity.PCQuantity.Code);
						}
						else if (designControl is DCPosition)
						{
							DCPosition dCPosition = (DCPosition)designControl;
							dCPosition.PCPosition.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCPosition.PCPosition.Code);
						}
						else if (designControl is DCTextEdit)
						{
							DCTextEdit dCTextEdit = (DCTextEdit)designControl;
							dCTextEdit.PCTextEdit.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCTextEdit.PCTextEdit.Code);
						}
						else if (designControl is DCImageAnnotate)
						{
							DCImageAnnotate dCImageAnnotate = (DCImageAnnotate)designControl;
							dCImageAnnotate.PCImageAnnotate.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCImageAnnotate.PCImageAnnotate.Code);
						}
						else if (designControl is DCTable)
						{
							DCTable dCTable = (DCTable)designControl;
							dCTable.PCTable.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(dCTable.PCTable.Code);
						}
						else if (designControl is DCFigure)
						{
							DCFigure dCFigure = (DCFigure)designControl;
							dCFigure.PCFigure.BindInstanceItem = this.InstanceData.FindInstanceItemByCode(dCFigure.PCFigure.Code);
						}
						else if (designControl is DCAlignTable)
						{
							DCAlignTable dCAlignTable = (DCAlignTable)designControl;
							PCAlignTable pCAlignTable = dCAlignTable.PCAlignTable;
							int arg_314_0 = 1;
							int rowCount = pCAlignTable.get_RowCount();
							for (int i = arg_314_0; i <= rowCount; i++)
							{
								int arg_325_0 = 1;
								int colCount = pCAlignTable.get_ColCount();
								for (int j = arg_325_0; j <= colCount; j++)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(pCAlignTable.get_Item(i, j).get_Tag());
									if (objectValue != null && objectValue is string)
									{
										NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(Conversions.ToString(objectValue));
										if (nInstanceItem != null)
										{
											if (nInstanceItem.BindMMetaItem is MIQuantity)
											{
												pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value + nInstanceItem.ValueCode);
											}
											else
											{
												pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value);
											}
										}
									}
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

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
			case 276:
				base.WndProc(ref m);
				this.Refresh();
				break;
			case 277:
				base.WndProc(ref m);
				this.Refresh();
				break;
			default:
				base.WndProc(ref m);
				break;
			}
		}

		public override void ShowCoordinate(Control ctrl, Point p)
		{
			this.CoordinateTip.SetToolTip(ctrl, string.Concat(checked(new object[]
			{
				"(",
				p.X - this.AutoScrollPosition.X,
				",",
				p.Y - this.AutoScrollPosition.Y,
				")"
			})));
		}

		private Pen getDashPen(int index)
		{
			Color color;
			if (0 == index)
			{
				color = Color.Blue;
			}
			else if (1 == index)
			{
				color = Color.SpringGreen;
			}
			else if (2 == index)
			{
				color = Color.SlateGray;
			}
			else
			{
				color = Color.Tomato;
			}
			return new Pen(color, 1f)
			{
				DashStyle = DashStyle.Custom,
				DashPattern = new float[]
				{
					6f,
					4f,
					6f,
					4f
				}
			};
		}

		private void SetEPRDesignPageSize()
		{
			string empty = string.Empty;
			this.designPageSize = SysOptionManager.GetSysOptionValue("EPRDesignPageSize", empty);
		}

		private void PaintLine(PaintEventArgs e)
		{
			int x = this.AutoScrollPosition.X;
			int y = this.AutoScrollPosition.Y;
			checked
			{
				try
				{
					int num = 0;
					string[] array = this.designPageSize.Split(new char[]
					{
						'|'
					});
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						string text = array2[i];
						string[] array3 = text.Split(new char[]
						{
							'^'
						});
						this.xWidth = int.Parse(array3[0]);
						this.yHeight = int.Parse(array3[1]);
						if (0 != this.xWidth && 0 != this.yHeight)
						{
							Pen dashPen = this.getDashPen(num);
							e.Graphics.DrawLine(dashPen, x, this.yHeight + y, this.xWidth + x, this.yHeight + y);
							e.Graphics.DrawLine(dashPen, this.xWidth + x, y, this.xWidth + x, this.yHeight + y);
							num++;
						}
					}
				}
				catch (Exception expr_105)
				{
					ProjectData.SetProjectError(expr_105);
					this.xWidth = 0;
					this.yHeight = 0;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void PaintScale(PaintEventArgs e)
		{
			int x = this.AutoScrollPosition.X;
			int y = this.AutoScrollPosition.Y;
			Graphics graphics = e.Graphics;
			Font font = new Font("宋体", 8f);
			Pen pen = new Pen(Color.Black);
			SolidBrush solidBrush = new SolidBrush(Color.Black);
			int arg_5B_0 = 0;
			checked
			{
				int num = this.Height - y;
				for (int i = arg_5B_0; i <= num; i++)
				{
					if (0 < i && 0 == i % 100)
					{
						Graphics arg_A8_0 = graphics;
						string arg_A8_1 = ((double)i / 100.0).ToString();
						Font arg_A8_2 = font;
						Brush arg_A8_3 = solidBrush;
						RectangleF layoutRectangle = new RectangleF(0f, (float)(i + y - 5), 10f, 10f);
						arg_A8_0.DrawString(arg_A8_1, arg_A8_2, arg_A8_3, layoutRectangle);
					}
					else if (0 == i || 0 == i % 10)
					{
						graphics.DrawLine(pen, 0, i + y, 8, i + y);
					}
					else if (0 == i % 5)
					{
						graphics.DrawLine(pen, 0, i + y, 3, i + y);
					}
				}
				int arg_106_0 = 0;
				int num2 = this.Width - x;
				for (int j = arg_106_0; j <= num2; j++)
				{
					if (0 < j && 0 == j % 100)
					{
						Graphics arg_153_0 = graphics;
						string arg_153_1 = ((double)j / 100.0).ToString();
						Font arg_153_2 = font;
						Brush arg_153_3 = solidBrush;
						RectangleF layoutRectangle = new RectangleF((float)(j + x - 5), 0f, 10f, 10f);
						arg_153_0.DrawString(arg_153_1, arg_153_2, arg_153_3, layoutRectangle);
					}
					else if (0 == j || 0 == j % 10)
					{
						graphics.DrawLine(pen, j + x, 0, j + x, 8);
					}
					else if (0 == j % 5)
					{
						graphics.DrawLine(pen, j + x, 0, j + x, 3);
					}
				}
			}
		}

		private void UndoAdd(DesignPanel.StructMove st)
		{
			this.UndoList.Add(st);
		}

		public void UndoExecute()
		{
			int num = checked(this.UndoList.Count - 1);
			if (num >= 0)
			{
				object expr_1E = this.UndoList[num];
				DesignPanel.StructMove structMove2;
				DesignPanel.StructMove structMove = (expr_1E != null) ? ((DesignPanel.StructMove)expr_1E) : structMove2;
				UndoMode falg = structMove.m_falg;
				if (falg == UndoMode.Move)
				{
					int x = structMove.m_move[0];
					int y = structMove.m_move[1];
					Control ctrl = structMove.m_ctrl;
					this.UndoMove(x, y, ctrl);
				}
				this.UndoList.RemoveAt(num);
			}
		}

		public void UndoMove(int x, int y, Control ctrl)
		{
			checked
			{
				ctrl.Left -= x;
				ctrl.Top -= y;
				this.leftest = ctrl.Left;
				this.topest = ctrl.Top;
			}
		}
	}
}
