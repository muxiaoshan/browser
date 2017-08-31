using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class SpecCharForm : dhcc.epr.eprlib.presentation.MovableForm
	{
		private GridControl curGridCtrl;

		private int curRowIndex;

		private int curColIndex;

		private const int LargeFontSize = 45;

		private IContainer components;

		[AccessedThroughProperty("tcSpecChar")]
		private TabControl _tcSpecChar;

		[AccessedThroughProperty("tpSpell")]
		private TabPage _tpSpell;

		[AccessedThroughProperty("tpNumber")]
		private TabPage _tpNumber;

		[AccessedThroughProperty("tpUnit")]
		private TabPage _tpUnit;

		[AccessedThroughProperty("tpMath")]
		private TabPage _tpMath;

		[AccessedThroughProperty("tpSpecChar")]
		private TabPage _tpSpecChar;

		[AccessedThroughProperty("tpPunctuation")]
		private TabPage _tpPunctuation;

		[AccessedThroughProperty("gcPunctuation")]
		private GridControl _gcPunctuation;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("gcSpecChar")]
		private GridControl _gcSpecChar;

		[AccessedThroughProperty("gcMath")]
		private GridControl _gcMath;

		[AccessedThroughProperty("gcUnit")]
		private GridControl _gcUnit;

		[AccessedThroughProperty("gcNumber")]
		private GridControl _gcNumber;

		[AccessedThroughProperty("gcSpell")]
		private GridControl _gcSpell;

		[AccessedThroughProperty("txtLarge")]
		private TextBox _txtLarge;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("llCancel")]
		private LinkLabel _llCancel;

		[AccessedThroughProperty("llOK")]
		private LinkLabel _llOK;

		[AccessedThroughProperty("tpCustom")]
		private TabPage _tpCustom;

		[AccessedThroughProperty("gcCustom")]
		private GridControl _gcCustom;

		internal virtual TabControl tcSpecChar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcSpecChar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tcSpecChar_SelectedIndexChanged);
				if (this._tcSpecChar != null)
				{
					this._tcSpecChar.SelectedIndexChanged -= value2;
				}
				this._tcSpecChar = value;
				if (this._tcSpecChar != null)
				{
					this._tcSpecChar.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TabPage tpSpell
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpSpell;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpSpell = value;
			}
		}

		internal virtual TabPage tpNumber
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpNumber;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpNumber = value;
			}
		}

		internal virtual TabPage tpUnit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpUnit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpUnit = value;
			}
		}

		internal virtual TabPage tpMath
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpMath;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpMath = value;
			}
		}

		internal virtual TabPage tpSpecChar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpSpecChar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpSpecChar = value;
			}
		}

		internal virtual TabPage tpPunctuation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpPunctuation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpPunctuation = value;
			}
		}

		internal virtual GridControl gcPunctuation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcPunctuation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcPunctuation != null)
				{
					this._gcPunctuation.DoubleClick -= value2;
					this._gcPunctuation.MouseMove -= value3;
					this._gcPunctuation.Click -= value4;
				}
				this._gcPunctuation = value;
				if (this._gcPunctuation != null)
				{
					this._gcPunctuation.DoubleClick += value2;
					this._gcPunctuation.MouseMove += value3;
					this._gcPunctuation.Click += value4;
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

		internal virtual GridControl gcSpecChar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcSpecChar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcSpecChar != null)
				{
					this._gcSpecChar.DoubleClick -= value2;
					this._gcSpecChar.MouseMove -= value3;
					this._gcSpecChar.Click -= value4;
				}
				this._gcSpecChar = value;
				if (this._gcSpecChar != null)
				{
					this._gcSpecChar.DoubleClick += value2;
					this._gcSpecChar.MouseMove += value3;
					this._gcSpecChar.Click += value4;
				}
			}
		}

		internal virtual GridControl gcMath
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcMath;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcMath != null)
				{
					this._gcMath.DoubleClick -= value2;
					this._gcMath.MouseMove -= value3;
					this._gcMath.Click -= value4;
				}
				this._gcMath = value;
				if (this._gcMath != null)
				{
					this._gcMath.DoubleClick += value2;
					this._gcMath.MouseMove += value3;
					this._gcMath.Click += value4;
				}
			}
		}

		internal virtual GridControl gcUnit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcUnit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcUnit != null)
				{
					this._gcUnit.DoubleClick -= value2;
					this._gcUnit.MouseMove -= value3;
					this._gcUnit.Click -= value4;
				}
				this._gcUnit = value;
				if (this._gcUnit != null)
				{
					this._gcUnit.DoubleClick += value2;
					this._gcUnit.MouseMove += value3;
					this._gcUnit.Click += value4;
				}
			}
		}

		internal virtual GridControl gcNumber
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcNumber;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcNumber != null)
				{
					this._gcNumber.DoubleClick -= value2;
					this._gcNumber.MouseMove -= value3;
					this._gcNumber.Click -= value4;
				}
				this._gcNumber = value;
				if (this._gcNumber != null)
				{
					this._gcNumber.DoubleClick += value2;
					this._gcNumber.MouseMove += value3;
					this._gcNumber.Click += value4;
				}
			}
		}

		internal virtual GridControl gcSpell
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcSpell;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcSpell != null)
				{
					this._gcSpell.DoubleClick -= value2;
					this._gcSpell.MouseMove -= value3;
					this._gcSpell.Click -= value4;
				}
				this._gcSpell = value;
				if (this._gcSpell != null)
				{
					this._gcSpell.DoubleClick += value2;
					this._gcSpell.MouseMove += value3;
					this._gcSpell.Click += value4;
				}
			}
		}

		internal virtual TextBox txtLarge
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtLarge;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtLarge = value;
			}
		}

		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual LinkLabel llCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llCancel_LinkClicked);
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked -= value2;
				}
				this._llCancel = value;
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked += value2;
				}
			}
		}

		internal virtual LinkLabel llOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llOK_LinkClicked);
				if (this._llOK != null)
				{
					this._llOK.LinkClicked -= value2;
				}
				this._llOK = value;
				if (this._llOK != null)
				{
					this._llOK.LinkClicked += value2;
				}
			}
		}

		internal virtual TabPage tpCustom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpCustom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpCustom = value;
			}
		}

		internal virtual GridControl gcCustom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gcCustom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridCtrl_DoubleClick);
				MouseEventHandler value3 = new MouseEventHandler(this.GridCtrl_MouseMove);
				EventHandler value4 = new EventHandler(this.GridCtl_Click);
				if (this._gcCustom != null)
				{
					this._gcCustom.DoubleClick -= value2;
					this._gcCustom.MouseMove -= value3;
					this._gcCustom.Click -= value4;
				}
				this._gcCustom = value;
				if (this._gcCustom != null)
				{
					this._gcCustom.DoubleClick += value2;
					this._gcCustom.MouseMove += value3;
					this._gcCustom.Click += value4;
				}
			}
		}

		public string CurrentSpecChar
		{
			get
			{
				if ((this.curGridCtrl != null & this.curRowIndex != 0 & this.curColIndex != 0) && Operators.CompareString(this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex).get_Text(), "", false) != 0)
				{
					return this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex).get_Text();
				}
				return null;
			}
		}

		public SpecCharForm()
		{
			base.Load += new EventHandler(this.SpecCharForm_Load);
			this.InitializeComponent();
			this.AddMovableHandler(this.Panel1);
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
			this.tcSpecChar = new TabControl();
			this.tpPunctuation = new TabPage();
			this.gcPunctuation = new GridControl();
			this.tpSpecChar = new TabPage();
			this.gcSpecChar = new GridControl();
			this.tpMath = new TabPage();
			this.gcMath = new GridControl();
			this.tpUnit = new TabPage();
			this.gcUnit = new GridControl();
			this.tpNumber = new TabPage();
			this.gcNumber = new GridControl();
			this.tpSpell = new TabPage();
			this.gcSpell = new GridControl();
			this.tpCustom = new TabPage();
			this.gcCustom = new GridControl();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.txtLarge = new TextBox();
			this.Panel1 = new Panel();
			this.llCancel = new LinkLabel();
			this.llOK = new LinkLabel();
			this.tcSpecChar.SuspendLayout();
			this.tpPunctuation.SuspendLayout();
			this.gcPunctuation.BeginInit();
			this.tpSpecChar.SuspendLayout();
			this.gcSpecChar.BeginInit();
			this.tpMath.SuspendLayout();
			this.gcMath.BeginInit();
			this.tpUnit.SuspendLayout();
			this.gcUnit.BeginInit();
			this.tpNumber.SuspendLayout();
			this.gcNumber.BeginInit();
			this.tpSpell.SuspendLayout();
			this.gcSpell.BeginInit();
			this.tpCustom.SuspendLayout();
			this.gcCustom.BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.tcSpecChar.Controls.Add(this.tpPunctuation);
			this.tcSpecChar.Controls.Add(this.tpSpell);
			this.tcSpecChar.Controls.Add(this.tpMath);
			this.tcSpecChar.Controls.Add(this.tpSpecChar);
			this.tcSpecChar.Controls.Add(this.tpUnit);
			this.tcSpecChar.Controls.Add(this.tpNumber);
			this.tcSpecChar.Controls.Add(this.tpCustom);
			Control arg_247_0 = this.tcSpecChar;
			Point location = new Point(8, 8);
			arg_247_0.Location = location;
			this.tcSpecChar.Multiline = true;
			this.tcSpecChar.Name = "tcSpecChar";
			this.tcSpecChar.SelectedIndex = 0;
			Control arg_28C_0 = this.tcSpecChar;
			Size size = new Size(312, 216);
			arg_28C_0.Size = size;
			this.tcSpecChar.TabIndex = 0;
			this.tpPunctuation.BackColor = Color.FromArgb(239, 239, 239);
			this.tpPunctuation.Controls.Add(this.gcPunctuation);
			TabPage arg_2E3_0 = this.tpPunctuation;
			location = new Point(4, 38);
			arg_2E3_0.Location = location;
			this.tpPunctuation.Name = "tpPunctuation";
			Control arg_310_0 = this.tpPunctuation;
			size = new Size(304, 174);
			arg_310_0.Size = size;
			this.tpPunctuation.TabIndex = 0;
			this.tpPunctuation.Text = "  标点符号  ";
			this.gcPunctuation.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcPunctuation.set_ColCount(14);
			this.gcPunctuation.set_DefaultColWidth(18);
			this.gcPunctuation.set_DefaultGridBorderStyle(6);
			this.gcPunctuation.set_DefaultRowHeight(18);
			this.gcPunctuation.set_HScrollBehavior(4);
			Control arg_38E_0 = this.gcPunctuation;
			location = new Point(19, 12);
			arg_38E_0.Location = location;
			this.gcPunctuation.Name = "gcPunctuation";
			this.gcPunctuation.get_Properties().set_ColHeaders(false);
			this.gcPunctuation.get_Properties().set_RowHeaders(false);
			this.gcPunctuation.set_RowCount(7);
			ScrollControl arg_3E9_0 = this.gcPunctuation;
			size = new Size(269, 146);
			arg_3E9_0.set_Size(size);
			this.gcPunctuation.set_TabIndex(1);
			this.gcPunctuation.set_VScrollBehavior(4);
			this.tpSpecChar.BackColor = Color.FromArgb(239, 239, 239);
			this.tpSpecChar.Controls.Add(this.gcSpecChar);
			TabPage arg_44C_0 = this.tpSpecChar;
			location = new Point(4, 38);
			arg_44C_0.Location = location;
			this.tpSpecChar.Name = "tpSpecChar";
			Control arg_479_0 = this.tpSpecChar;
			size = new Size(304, 174);
			arg_479_0.Size = size;
			this.tpSpecChar.TabIndex = 1;
			this.tpSpecChar.Text = "  特殊符号  ";
			this.gcSpecChar.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcSpecChar.set_ColCount(14);
			this.gcSpecChar.set_DefaultColWidth(18);
			this.gcSpecChar.set_DefaultGridBorderStyle(6);
			this.gcSpecChar.set_DefaultRowHeight(18);
			this.gcSpecChar.set_HScrollBehavior(4);
			Control arg_4F7_0 = this.gcSpecChar;
			location = new Point(18, 14);
			arg_4F7_0.Location = location;
			this.gcSpecChar.Name = "gcSpecChar";
			this.gcSpecChar.get_Properties().set_ColHeaders(false);
			this.gcSpecChar.get_Properties().set_RowHeaders(false);
			this.gcSpecChar.set_RowCount(7);
			ScrollControl arg_552_0 = this.gcSpecChar;
			size = new Size(269, 146);
			arg_552_0.set_Size(size);
			this.gcSpecChar.set_TabIndex(2);
			this.gcSpecChar.Text = "GridControl2";
			this.gcSpecChar.set_VScrollBehavior(4);
			this.tpMath.BackColor = Color.FromArgb(239, 239, 239);
			this.tpMath.Controls.Add(this.gcMath);
			TabPage arg_5C5_0 = this.tpMath;
			location = new Point(4, 38);
			arg_5C5_0.Location = location;
			this.tpMath.Name = "tpMath";
			Control arg_5F2_0 = this.tpMath;
			size = new Size(304, 174);
			arg_5F2_0.Size = size;
			this.tpMath.TabIndex = 2;
			this.tpMath.Text = "  数学符号  ";
			this.gcMath.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcMath.set_ColCount(14);
			this.gcMath.set_DefaultColWidth(18);
			this.gcMath.set_DefaultGridBorderStyle(6);
			this.gcMath.set_DefaultRowHeight(18);
			this.gcMath.set_HScrollBehavior(4);
			Control arg_670_0 = this.gcMath;
			location = new Point(18, 14);
			arg_670_0.Location = location;
			this.gcMath.Name = "gcMath";
			this.gcMath.get_Properties().set_ColHeaders(false);
			this.gcMath.get_Properties().set_RowHeaders(false);
			this.gcMath.set_RowCount(7);
			ScrollControl arg_6CB_0 = this.gcMath;
			size = new Size(269, 146);
			arg_6CB_0.set_Size(size);
			this.gcMath.set_TabIndex(2);
			this.gcMath.Text = "GridControl3";
			this.gcMath.set_VScrollBehavior(4);
			this.tpUnit.BackColor = Color.FromArgb(239, 239, 239);
			this.tpUnit.Controls.Add(this.gcUnit);
			TabPage arg_73E_0 = this.tpUnit;
			location = new Point(4, 38);
			arg_73E_0.Location = location;
			this.tpUnit.Name = "tpUnit";
			Control arg_76B_0 = this.tpUnit;
			size = new Size(304, 174);
			arg_76B_0.Size = size;
			this.tpUnit.TabIndex = 3;
			this.tpUnit.Text = "  单位符号  ";
			this.gcUnit.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcUnit.set_ColCount(14);
			this.gcUnit.set_DefaultColWidth(18);
			this.gcUnit.set_DefaultGridBorderStyle(6);
			this.gcUnit.set_DefaultRowHeight(18);
			this.gcUnit.set_HScrollBehavior(4);
			Control arg_7E9_0 = this.gcUnit;
			location = new Point(18, 14);
			arg_7E9_0.Location = location;
			this.gcUnit.Name = "gcUnit";
			this.gcUnit.get_Properties().set_ColHeaders(false);
			this.gcUnit.get_Properties().set_RowHeaders(false);
			this.gcUnit.set_RowCount(7);
			ScrollControl arg_844_0 = this.gcUnit;
			size = new Size(269, 146);
			arg_844_0.set_Size(size);
			this.gcUnit.set_TabIndex(2);
			this.gcUnit.Text = "GridControl4";
			this.gcUnit.set_VScrollBehavior(4);
			this.tpNumber.BackColor = Color.FromArgb(239, 239, 239);
			this.tpNumber.Controls.Add(this.gcNumber);
			TabPage arg_8B7_0 = this.tpNumber;
			location = new Point(4, 38);
			arg_8B7_0.Location = location;
			this.tpNumber.Name = "tpNumber";
			Control arg_8E4_0 = this.tpNumber;
			size = new Size(304, 174);
			arg_8E4_0.Size = size;
			this.tpNumber.TabIndex = 4;
			this.tpNumber.Text = "  数字符号  ";
			this.gcNumber.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcNumber.set_ColCount(14);
			this.gcNumber.set_DefaultColWidth(18);
			this.gcNumber.set_DefaultGridBorderStyle(6);
			this.gcNumber.set_DefaultRowHeight(18);
			this.gcNumber.set_HScrollBehavior(4);
			Control arg_962_0 = this.gcNumber;
			location = new Point(18, 14);
			arg_962_0.Location = location;
			this.gcNumber.Name = "gcNumber";
			this.gcNumber.get_Properties().set_ColHeaders(false);
			this.gcNumber.get_Properties().set_RowHeaders(false);
			this.gcNumber.set_RowCount(7);
			ScrollControl arg_9BD_0 = this.gcNumber;
			size = new Size(269, 146);
			arg_9BD_0.set_Size(size);
			this.gcNumber.set_TabIndex(2);
			this.gcNumber.Text = "GridControl5";
			this.gcNumber.set_VScrollBehavior(4);
			this.tpSpell.BackColor = Color.FromArgb(239, 239, 239);
			this.tpSpell.Controls.Add(this.gcSpell);
			TabPage arg_A30_0 = this.tpSpell;
			location = new Point(4, 38);
			arg_A30_0.Location = location;
			this.tpSpell.Name = "tpSpell";
			Control arg_A5D_0 = this.tpSpell;
			size = new Size(304, 174);
			arg_A5D_0.Size = size;
			this.tpSpell.TabIndex = 5;
			this.tpSpell.Text = "  希腊字母  ";
			this.gcSpell.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcSpell.set_ColCount(14);
			this.gcSpell.set_DefaultColWidth(18);
			this.gcSpell.set_DefaultGridBorderStyle(6);
			this.gcSpell.set_DefaultRowHeight(18);
			this.gcSpell.set_HScrollBehavior(4);
			Control arg_ADB_0 = this.gcSpell;
			location = new Point(18, 14);
			arg_ADB_0.Location = location;
			this.gcSpell.Name = "gcSpell";
			this.gcSpell.get_Properties().set_ColHeaders(false);
			this.gcSpell.get_Properties().set_RowHeaders(false);
			this.gcSpell.set_RowCount(7);
			ScrollControl arg_B36_0 = this.gcSpell;
			size = new Size(269, 146);
			arg_B36_0.set_Size(size);
			this.gcSpell.set_TabIndex(2);
			this.gcSpell.Text = "GridControl6";
			this.gcSpell.set_VScrollBehavior(4);
			this.tpCustom.Controls.Add(this.gcCustom);
			TabPage arg_B8A_0 = this.tpCustom;
			location = new Point(4, 38);
			arg_B8A_0.Location = location;
			this.tpCustom.Name = "tpCustom";
			Control arg_BB7_0 = this.tpCustom;
			size = new Size(304, 174);
			arg_BB7_0.Size = size;
			this.tpCustom.TabIndex = 6;
			this.tpCustom.Text = " 自定义";
			this.gcCustom.set_BorderStyle(BorderStyle.Fixed3D);
			this.gcCustom.set_ColCount(7);
			this.gcCustom.set_DefaultColWidth(36);
			this.gcCustom.set_DefaultGridBorderStyle(6);
			this.gcCustom.set_DefaultRowHeight(18);
			this.gcCustom.set_HScrollBehavior(4);
			Control arg_C34_0 = this.gcCustom;
			location = new Point(18, 14);
			arg_C34_0.Location = location;
			this.gcCustom.Name = "gcCustom";
			this.gcCustom.get_Properties().set_ColHeaders(false);
			this.gcCustom.get_Properties().set_RowHeaders(false);
			this.gcCustom.set_RowCount(7);
			ScrollControl arg_C8F_0 = this.gcCustom;
			size = new Size(269, 146);
			arg_C8F_0.set_Size(size);
			this.gcCustom.set_TabIndex(3);
			this.gcCustom.Text = "GridControl7";
			this.gcCustom.set_VScrollBehavior(4);
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_D06_0 = this.btnOK;
			location = new Point(320, 80);
			arg_D06_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_D2D_0 = this.btnOK;
			size = new Size(75, 26);
			arg_D2D_0.Size = size;
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.Visible = false;
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_DB0_0 = this.btnCancel;
			location = new Point(320, 112);
			arg_DB0_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_DD7_0 = this.btnCancel;
			size = new Size(75, 26);
			arg_DD7_0.Size = size;
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.Visible = false;
			this.txtLarge.BorderStyle = BorderStyle.FixedSingle;
			this.txtLarge.Font = new Font("宋体", 40f);
			this.txtLarge.ForeColor = SystemColors.HotTrack;
			Control arg_E4F_0 = this.txtLarge;
			location = new Point(328, 120);
			arg_E4F_0.Location = location;
			this.txtLarge.Multiline = true;
			this.txtLarge.Name = "txtLarge";
			Control arg_E82_0 = this.txtLarge;
			size = new Size(88, 64);
			arg_E82_0.Size = size;
			this.txtLarge.TabIndex = 4;
			this.txtLarge.Text = "";
			this.txtLarge.TextAlign = HorizontalAlignment.Center;
			this.Panel1.BackColor = Color.FromArgb(239, 239, 239);
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.llCancel);
			this.Panel1.Controls.Add(this.llOK);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_F22_0 = this.Panel1;
			location = new Point(0, 0);
			arg_F22_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_F4F_0 = this.Panel1;
			size = new Size(424, 232);
			arg_F4F_0.Size = size;
			this.Panel1.TabIndex = 5;
			this.llCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_F82_0 = this.llCancel;
			location = new Point(352, 64);
			arg_F82_0.Location = location;
			this.llCancel.Name = "llCancel";
			Control arg_FA9_0 = this.llCancel;
			size = new Size(48, 16);
			arg_FA9_0.Size = size;
			this.llCancel.TabIndex = 12;
			this.llCancel.TabStop = true;
			this.llCancel.Text = "取消(&C)";
			this.llOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_FF9_0 = this.llOK;
			location = new Point(352, 40);
			arg_FF9_0.Location = location;
			this.llOK.Name = "llOK";
			Control arg_1020_0 = this.llOK;
			size = new Size(48, 16);
			arg_1020_0.Size = size;
			this.llOK.TabIndex = 11;
			this.llOK.TabStop = true;
			this.llOK.Text = "确定(&O)";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(424, 232);
			this.ClientSize = size;
			this.Controls.Add(this.txtLarge);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tcSpecChar);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "SpecCharForm";
			this.Text = "特殊字符";
			this.tcSpecChar.ResumeLayout(false);
			this.tpPunctuation.ResumeLayout(false);
			this.gcPunctuation.EndInit();
			this.tpSpecChar.ResumeLayout(false);
			this.gcSpecChar.EndInit();
			this.tpMath.ResumeLayout(false);
			this.gcMath.EndInit();
			this.tpUnit.ResumeLayout(false);
			this.gcUnit.EndInit();
			this.tpNumber.ResumeLayout(false);
			this.gcNumber.EndInit();
			this.tpSpell.ResumeLayout(false);
			this.gcSpell.EndInit();
			this.tpCustom.ResumeLayout(false);
			this.gcCustom.EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void SpecCharForm_Load(object sender, EventArgs e)
		{
			char[] array = Conversions.ToCharArrayRankOne(" ，、。．；：？！︰…‥′‵々～‖ˇˉ﹐﹑﹒·﹔﹕﹖﹗｜–︱—︳︴﹏（）︵︶｛｝︷︸〔〕︹︺【】︻︼《》︽︾〈〉︿﹀「」﹁﹂『』﹃﹄﹙﹚﹛﹜﹝﹞‘’\"〝〞ˋˊ");
			int num = 1;
			int num2 = 1;
			int arg_19_0 = 0;
			checked
			{
				int num3 = array.Length - 1;
				for (int i = arg_19_0; i <= num3; i++)
				{
					this.gcPunctuation.get_Item(num, num2).set_Text(Conversions.ToString(array[i]));
					num2++;
					if (num2 > this.gcPunctuation.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcPunctuation.get_TableStyle().set_ReadOnly(true);
				char[] array2 = Conversions.ToCharArrayRankOne("°′″＄￥〒￠￡％＠℃℉﹩﹪‰﹫㏕㎜㎝㎞㏎㎡㎎㎏㏄°○¤" + Conversions.ToString(Convert.ToChar(181)));
				num = 1;
				num2 = 1;
				int arg_A4_0 = 0;
				int num4 = array2.Length - 1;
				for (int i = arg_A4_0; i <= num4; i++)
				{
					this.gcUnit.get_Item(num, num2).set_Text(Conversions.ToString(array2[i]));
					num2++;
					if (num2 > this.gcUnit.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcUnit.get_TableStyle().set_ReadOnly(true);
				char[] array3 = Conversions.ToCharArrayRankOne("＃＠＆＊※§〃№〓○●△▲◎☆★◇◆□■▽▼㊣℅ˉ￣＿﹉﹊﹍﹎﹋﹌﹟﹠﹡♀♂⊕⊙↑↓←→↖↗↙↘∥∣／＼∕﹨");
				num = 1;
				num2 = 1;
				int arg_11A_0 = 0;
				int num5 = array3.Length - 1;
				for (int i = arg_11A_0; i <= num5; i++)
				{
					this.gcSpecChar.get_Item(num, num2).set_Text(Conversions.ToString(array3[i]));
					num2++;
					if (num2 > this.gcSpecChar.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcSpecChar.get_TableStyle().set_ReadOnly(true);
				char[] array4 = Conversions.ToCharArrayRankOne("ⅰⅱⅲⅳⅴⅵⅶⅷⅸⅹⅠⅡⅢⅣⅤⅥⅦⅧⅨⅩⅪⅫ⒈⒉⒊⒋⒌⒍⒎⒏⒐⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛⑴⑵⑶⑷⑸⑹⑺⑻⑼⑽⑾⑿⒀⒁⒂⒃⒄⒅⒆⒇①②③④⑤⑥⑦⑧⑨⑩㈠㈡㈢㈣㈤㈥㈦㈧㈨㈩");
				num = 1;
				num2 = 1;
				int arg_18F_0 = 0;
				int num6 = array4.Length - 1;
				for (int i = arg_18F_0; i <= num6; i++)
				{
					this.gcNumber.get_Item(num, num2).set_Text(Conversions.ToString(array4[i]));
					num2++;
					if (num2 > this.gcNumber.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcNumber.get_TableStyle().set_ReadOnly(true);
				char[] array5 = Conversions.ToCharArrayRankOne("≈≡≠＝≤≥＜＞≮≯∷±＋－×÷／∫∮∝∞∧∨∑∏∪∩∈∵∴⊥∥∠⌒⊙≌∽√≦≧≒≡﹢﹣﹤﹥﹦～∟⊿㏒㏑");
				num = 1;
				num2 = 1;
				int arg_204_0 = 0;
				int num7 = array5.Length - 1;
				for (int i = arg_204_0; i <= num7; i++)
				{
					this.gcMath.get_Item(num, num2).set_Text(Conversions.ToString(array5[i]));
					num2++;
					if (num2 > this.gcMath.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcMath.get_TableStyle().set_ReadOnly(true);
				char[] array6 = Conversions.ToCharArrayRankOne("αβγδεζηθικλμνξοπρστυφχψωΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩ");
				num = 1;
				num2 = 1;
				int arg_27B_0 = 0;
				int num8 = array6.Length - 1;
				for (int i = arg_27B_0; i <= num8; i++)
				{
					this.gcSpell.get_Item(num, num2).set_Text(Conversions.ToString(array6[i]));
					num2++;
					if (num2 > this.gcSpell.get_ColCount())
					{
						num2 = 1;
						num++;
					}
				}
				this.gcSpell.get_TableStyle().set_ReadOnly(true);
				string sysOptionValue = SysOptionManager.GetSysOptionValue("CustomSpecialChar", "");
				if (Operators.CompareString(sysOptionValue, "", false) != 0 && Operators.CompareString(sysOptionValue.ToUpper(), "NULL", false) != 0)
				{
					num = 1;
					num2 = 1;
					string[] array7 = sysOptionValue.Split(new char[]
					{
						'^'
					});
					this.ResetRowCount(array7.Length);
					int arg_343_0 = 0;
					int num9 = array7.Length - 1;
					for (int i = arg_343_0; i <= num9; i++)
					{
						this.gcCustom.get_Item(num, num2).set_Text(array7[i]);
						num2++;
						if (num2 > this.gcCustom.get_ColCount())
						{
							num2 = 1;
							num++;
						}
					}
				}
				this.gcCustom.get_TableStyle().set_ReadOnly(true);
			}
		}

		private void GridCtl_Click(object sender, EventArgs e)
		{
			this.curGridCtrl = (GridControl)sender;
			GridStyleInfo gridStyleInfo;
			if (this.curRowIndex > 0 & this.curColIndex > 0)
			{
				gridStyleInfo = this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex);
				gridStyleInfo.set_Interior(new BrushInfo(SystemColors.Window));
				gridStyleInfo.set_TextColor(SystemColors.WindowText);
			}
			this.curRowIndex = this.curGridCtrl.get_CurrentCell().get_RowIndex();
			this.curColIndex = this.curGridCtrl.get_CurrentCell().get_ColIndex();
			gridStyleInfo = this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex);
			gridStyleInfo.set_Interior(new BrushInfo(SystemColors.HotTrack));
			gridStyleInfo.set_TextColor(SystemColors.Window);
			this.llOK.Select();
		}

		private void GridCtrl_MouseMove(object sender, MouseEventArgs e)
		{
			this.curGridCtrl = (GridControl)sender;
			GridControlBase arg_2A_0 = this.curGridCtrl;
			Point point = new Point(e.X, e.Y);
			int num;
			int num2;
			arg_2A_0.PointToRowCol(point, ref num, ref num2);
			this.txtLarge.Text = this.curGridCtrl.get_Item(num, num2).get_Text();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void GridCtrl_DoubleClick(object sender, EventArgs e)
		{
			this.curGridCtrl = (GridControl)sender;
			GridStyleInfo gridStyleInfo;
			if (this.curRowIndex > 0 & this.curColIndex > 0)
			{
				gridStyleInfo = this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex);
				gridStyleInfo.set_Interior(new BrushInfo(SystemColors.Window));
				gridStyleInfo.set_TextColor(SystemColors.WindowText);
			}
			this.curRowIndex = this.curGridCtrl.get_CurrentCell().get_RowIndex();
			this.curColIndex = this.curGridCtrl.get_CurrentCell().get_ColIndex();
			gridStyleInfo = this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex);
			gridStyleInfo.set_Interior(new BrushInfo(SystemColors.HotTrack));
			gridStyleInfo.set_TextColor(SystemColors.Window);
			this.DialogResult = DialogResult.OK;
		}

		private void tcSpecChar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.curRowIndex > 0 & this.curColIndex > 0)
			{
				GridStyleInfo gridStyleInfo = this.curGridCtrl.get_Item(this.curRowIndex, this.curColIndex);
				gridStyleInfo.set_Interior(new BrushInfo(SystemColors.Window));
				gridStyleInfo.set_TextColor(SystemColors.WindowText);
				this.curRowIndex = 0;
				this.curColIndex = 0;
			}
			this.curGridCtrl = null;
			this.txtLarge.Text = "";
		}

		private void llOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnCancel_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void ResetRowCount(int customCharCount)
		{
			checked
			{
				if (customCharCount <= this.gcCustom.get_RowCount() * this.gcCustom.get_ColCount())
				{
					return;
				}
				int num = (int)Math.Round((double)customCharCount / (double)this.gcCustom.get_ColCount());
				int num2 = customCharCount % this.gcCustom.get_ColCount();
				if (num2 != 0)
				{
					num++;
				}
				this.gcCustom.set_RowCount(num);
			}
		}
	}
}
