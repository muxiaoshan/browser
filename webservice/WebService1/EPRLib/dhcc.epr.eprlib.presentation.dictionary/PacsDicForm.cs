using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using Microsoft.VisualBasic.CompilerServices;
using PACSData;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class PacsDicForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("lblPageNum")]
		private Label _lblPageNum;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("DateTimePicker1")]
		private DateTimePicker _DateTimePicker1;

		[AccessedThroughProperty("DateTimePicker2")]
		private DateTimePicker _DateTimePicker2;

		[AccessedThroughProperty("trvLisInfo")]
		private TreeView _trvLisInfo;

		[AccessedThroughProperty("tcCheckReport")]
		private TabControl _tcCheckReport;

		[AccessedThroughProperty("tpQuoted")]
		private TabPage _tpQuoted;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("EndDate")]
		private DateTimePicker _EndDate;

		[AccessedThroughProperty("StDate")]
		private DateTimePicker _StDate;

		[AccessedThroughProperty("btnCancle")]
		private Button _btnCancle;

		[AccessedThroughProperty("btnOk")]
		private Button _btnOk;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("sprResult")]
		private FpSpread _sprResult;

		[AccessedThroughProperty("sprResult_Sheet1")]
		private SheetView _sprResult_Sheet1;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("dgBOLISData")]
		private DataGridView _dgBOLISData;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("rbPresentOrder")]
		private RadioButton _rbPresentOrder;

		[AccessedThroughProperty("rbAllOrder")]
		private RadioButton _rbAllOrder;

		[AccessedThroughProperty("rbDate")]
		private RadioButton _rbDate;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("btnPrev")]
		private Button _btnPrev;

		[AccessedThroughProperty("btnNext")]
		private Button _btnNext;

		[AccessedThroughProperty("txtPageNum")]
		private TextBox _txtPageNum;

		[AccessedThroughProperty("btnQuery")]
		private Button _btnQuery;

		[AccessedThroughProperty("PDate")]
		private Panel _PDate;

		[AccessedThroughProperty("nudPageCount")]
		private NumericUpDown _nudPageCount;

		[AccessedThroughProperty("tpEpsoidList")]
		private TabPage _tpEpsoidList;

		private MIDictionary _BindMIDictionary;

		private NISimple _BindNISimple;

		private string _DicValue;

		private string _DicValueCode;

		private bool BoolMouseDown;

		private Point ClickedPoint;

		private DataGridTableStyle curDataGridTableStyle;

		private StringCollection collumcol;

		private DataTable curDataTable;

		private DataSet curDataSet;

		private int PageCount;

		private int CurrentPageNum;

		private bool boolShowDic;

		private static int _PageRowCount = 0;

		private string _strQuery;

		private string _strSessionID;

		private string _EpisodeID;

		private string _PatientID;

		private const string COLUMSTYPE = "System.String";

		private int m_CurPageNum;

		internal virtual Label lblPageNum
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblPageNum;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblPageNum = value;
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
				this._btnCancel = value;
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual DateTimePicker DateTimePicker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateTimePicker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateTimePicker1 = value;
			}
		}

		internal virtual DateTimePicker DateTimePicker2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateTimePicker2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateTimePicker2 = value;
			}
		}

		internal virtual TreeView trvLisInfo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._trvLisInfo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._trvLisInfo = value;
			}
		}

		internal virtual TabControl tcCheckReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcCheckReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tcCheckReport = value;
			}
		}

		internal virtual TabPage tpQuoted
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpQuoted;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpQuoted = value;
			}
		}

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

		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual DateTimePicker EndDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EndDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EndDate = value;
			}
		}

		internal virtual DateTimePicker StDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StDate = value;
			}
		}

		internal virtual Button btnCancle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancle_Click);
				if (this._btnCancle != null)
				{
					this._btnCancle.Click -= value2;
				}
				this._btnCancle = value;
				if (this._btnCancle != null)
				{
					this._btnCancle.Click += value2;
				}
			}
		}

		internal virtual Button btnOk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOk_Click);
				if (this._btnOk != null)
				{
					this._btnOk.Click -= value2;
				}
				this._btnOk = value;
				if (this._btnOk != null)
				{
					this._btnOk.Click += value2;
				}
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

		internal virtual FpSpread sprResult
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sprResult;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ChildViewCreatedEventHandler childViewCreatedEventHandler = new ChildViewCreatedEventHandler(this.sprResult_ChildViewCreated);
				if (this._sprResult != null)
				{
					this._sprResult.remove_ChildViewCreated(childViewCreatedEventHandler);
				}
				this._sprResult = value;
				if (this._sprResult != null)
				{
					this._sprResult.add_ChildViewCreated(childViewCreatedEventHandler);
				}
			}
		}

		internal virtual SheetView sprResult_Sheet1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sprResult_Sheet1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._sprResult_Sheet1 = value;
			}
		}

		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual DataGridView dgBOLISData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgBOLISData;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgBOLISData_CellDoubleClick);
				if (this._dgBOLISData != null)
				{
					this._dgBOLISData.CellDoubleClick -= value2;
				}
				this._dgBOLISData = value;
				if (this._dgBOLISData != null)
				{
					this._dgBOLISData.CellDoubleClick += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		internal virtual RadioButton rbPresentOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbPresentOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbPresentOrder_CheckedChanged);
				if (this._rbPresentOrder != null)
				{
					this._rbPresentOrder.CheckedChanged -= value2;
				}
				this._rbPresentOrder = value;
				if (this._rbPresentOrder != null)
				{
					this._rbPresentOrder.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rbAllOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbAllOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbAllOrder_CheckedChanged);
				if (this._rbAllOrder != null)
				{
					this._rbAllOrder.CheckedChanged -= value2;
				}
				this._rbAllOrder = value;
				if (this._rbAllOrder != null)
				{
					this._rbAllOrder.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rbDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbDate_CheckedChanged);
				if (this._rbDate != null)
				{
					this._rbDate.CheckedChanged -= value2;
				}
				this._rbDate = value;
				if (this._rbDate != null)
				{
					this._rbDate.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Button btnPrev
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPrev;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPrev_Click);
				if (this._btnPrev != null)
				{
					this._btnPrev.Click -= value2;
				}
				this._btnPrev = value;
				if (this._btnPrev != null)
				{
					this._btnPrev.Click += value2;
				}
			}
		}

		internal virtual Button btnNext
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNext;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnNext_Click);
				if (this._btnNext != null)
				{
					this._btnNext.Click -= value2;
				}
				this._btnNext = value;
				if (this._btnNext != null)
				{
					this._btnNext.Click += value2;
				}
			}
		}

		internal virtual TextBox txtPageNum
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPageNum;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPageNum = value;
			}
		}

		internal virtual Button btnQuery
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnQuery;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnQuery_Click);
				if (this._btnQuery != null)
				{
					this._btnQuery.Click -= value2;
				}
				this._btnQuery = value;
				if (this._btnQuery != null)
				{
					this._btnQuery.Click += value2;
				}
			}
		}

		internal virtual Panel PDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PDate = value;
			}
		}

		internal virtual NumericUpDown nudPageCount
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nudPageCount;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nudPageCount_ValueChanged);
				if (this._nudPageCount != null)
				{
					this._nudPageCount.ValueChanged -= value2;
				}
				this._nudPageCount = value;
				if (this._nudPageCount != null)
				{
					this._nudPageCount.ValueChanged += value2;
				}
			}
		}

		internal virtual TabPage tpEpsoidList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpEpsoidList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpEpsoidList = value;
			}
		}

		public static int PageRowCount
		{
			get
			{
				if (PacsDicForm._PageRowCount == 0)
				{
					try
					{
						string sysOptionValue = SysOptionManager.GetSysOptionValue("DicPageRowCount", "12");
						if ((sysOptionValue != null | Operators.CompareString(sysOptionValue, "", false) == 0) && Versioned.IsNumeric(sysOptionValue))
						{
							PacsDicForm._PageRowCount = int.Parse(sysOptionValue);
						}
						if (PacsDicForm._PageRowCount <= 0)
						{
							PacsDicForm._PageRowCount = 12;
						}
					}
					catch (Exception expr_55)
					{
						ProjectData.SetProjectError(expr_55);
						Exception ex = expr_55;
						MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
						PacsDicForm._PageRowCount = 12;
						ProjectData.ClearProjectError();
					}
				}
				return PacsDicForm._PageRowCount;
			}
		}

		public string DicValue
		{
			get
			{
				return this._DicValue;
			}
			set
			{
				this._DicValue = value;
			}
		}

		public string DicValueCode
		{
			get
			{
				return this._DicValueCode;
			}
			set
			{
				this._DicValueCode = value;
			}
		}

		public PacsDicForm()
		{
			base.SizeChanged += new EventHandler(this.PacsDicForm_SizeChanged);
			base.Load += new EventHandler(this.PacsDicForm_Load);
			this.BoolMouseDown = false;
			this.curDataGridTableStyle = new DataGridTableStyle();
			this.m_CurPageNum = 1;
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
			this.lblPageNum = new Label();
			this.btnCancel = new Button();
			this.GroupBox1 = new GroupBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.DateTimePicker1 = new DateTimePicker();
			this.DateTimePicker2 = new DateTimePicker();
			this.trvLisInfo = new TreeView();
			this.tcCheckReport = new TabControl();
			this.tpQuoted = new TabPage();
			this.Panel2 = new Panel();
			this.GroupBox3 = new GroupBox();
			this.PDate = new Panel();
			this.EndDate = new DateTimePicker();
			this.StDate = new DateTimePicker();
			this.Label3 = new Label();
			this.rbDate = new RadioButton();
			this.btnQuery = new Button();
			this.rbAllOrder = new RadioButton();
			this.rbPresentOrder = new RadioButton();
			this.GroupBox2 = new GroupBox();
			this.nudPageCount = new NumericUpDown();
			this.btnPrev = new Button();
			this.btnNext = new Button();
			this.Label4 = new Label();
			this.txtPageNum = new TextBox();
			this.btnCancle = new Button();
			this.btnOk = new Button();
			this.Panel1 = new Panel();
			this.sprResult = new FpSpread();
			this.sprResult_Sheet1 = new SheetView();
			this.tpEpsoidList = new TabPage();
			this.dgBOLISData = new DataGridView();
			this.Label7 = new Label();
			this.tcCheckReport.SuspendLayout();
			this.tpQuoted.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.PDate.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((ISupportInitialize)this.nudPageCount).BeginInit();
			this.Panel1.SuspendLayout();
			this.sprResult.BeginInit();
			this.sprResult_Sheet1.BeginInit();
			this.tpEpsoidList.SuspendLayout();
			((ISupportInitialize)this.dgBOLISData).BeginInit();
			this.SuspendLayout();
			Control arg_210_0 = this.lblPageNum;
			Point location = new Point(0, 0);
			arg_210_0.Location = location;
			this.lblPageNum.Name = "lblPageNum";
			Control arg_237_0 = this.lblPageNum;
			Size size = new Size(100, 23);
			arg_237_0.Size = size;
			this.lblPageNum.TabIndex = 0;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			Control arg_264_0 = this.btnCancel;
			location = new Point(0, 0);
			arg_264_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_28B_0 = this.btnCancel;
			size = new Size(75, 23);
			arg_28B_0.Size = size;
			this.btnCancel.TabIndex = 0;
			Control arg_2AC_0 = this.GroupBox1;
			location = new Point(0, 0);
			arg_2AC_0.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_2D6_0 = this.GroupBox1;
			size = new Size(200, 100);
			arg_2D6_0.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			Control arg_303_0 = this.Label1;
			location = new Point(0, 0);
			arg_303_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_32A_0 = this.Label1;
			size = new Size(100, 23);
			arg_32A_0.Size = size;
			this.Label1.TabIndex = 0;
			Control arg_34B_0 = this.Label2;
			location = new Point(0, 0);
			arg_34B_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_372_0 = this.Label2;
			size = new Size(100, 23);
			arg_372_0.Size = size;
			this.Label2.TabIndex = 0;
			Control arg_393_0 = this.DateTimePicker1;
			location = new Point(0, 0);
			arg_393_0.Location = location;
			this.DateTimePicker1.Name = "DateTimePicker1";
			Control arg_3BD_0 = this.DateTimePicker1;
			size = new Size(200, 21);
			arg_3BD_0.Size = size;
			this.DateTimePicker1.TabIndex = 0;
			Control arg_3DE_0 = this.DateTimePicker2;
			location = new Point(0, 0);
			arg_3DE_0.Location = location;
			this.DateTimePicker2.Name = "DateTimePicker2";
			Control arg_408_0 = this.DateTimePicker2;
			size = new Size(200, 21);
			arg_408_0.Size = size;
			this.DateTimePicker2.TabIndex = 0;
			this.trvLisInfo.LineColor = Color.Empty;
			Control arg_439_0 = this.trvLisInfo;
			location = new Point(0, 0);
			arg_439_0.Location = location;
			this.trvLisInfo.Name = "trvLisInfo";
			Control arg_460_0 = this.trvLisInfo;
			size = new Size(121, 97);
			arg_460_0.Size = size;
			this.trvLisInfo.TabIndex = 0;
			this.tcCheckReport.Controls.Add(this.tpQuoted);
			this.tcCheckReport.Controls.Add(this.tpEpsoidList);
			this.tcCheckReport.Dock = DockStyle.Fill;
			Control arg_4B9_0 = this.tcCheckReport;
			location = new Point(0, 0);
			arg_4B9_0.Location = location;
			this.tcCheckReport.Name = "tcCheckReport";
			this.tcCheckReport.SelectedIndex = 0;
			Control arg_4F2_0 = this.tcCheckReport;
			size = new Size(892, 666);
			arg_4F2_0.Size = size;
			this.tcCheckReport.TabIndex = 29;
			this.tpQuoted.BackColor = SystemColors.InactiveCaptionText;
			this.tpQuoted.Controls.Add(this.Panel2);
			this.tpQuoted.Controls.Add(this.Panel1);
			TabPage arg_551_0 = this.tpQuoted;
			location = new Point(4, 21);
			arg_551_0.Location = location;
			this.tpQuoted.Name = "tpQuoted";
			Control arg_575_0 = this.tpQuoted;
			Padding padding = new Padding(3);
			arg_575_0.Padding = padding;
			Control arg_592_0 = this.tpQuoted;
			size = new Size(884, 641);
			arg_592_0.Size = size;
			this.tpQuoted.TabIndex = 0;
			this.tpQuoted.Text = "报告引用";
			this.Panel2.Controls.Add(this.GroupBox3);
			this.Panel2.Controls.Add(this.GroupBox2);
			this.Panel2.Controls.Add(this.btnCancle);
			this.Panel2.Controls.Add(this.btnOk);
			this.Panel2.Dock = DockStyle.Bottom;
			Control arg_62B_0 = this.Panel2;
			location = new Point(3, 560);
			arg_62B_0.Location = location;
			this.Panel2.Name = "Panel2";
			Control arg_655_0 = this.Panel2;
			size = new Size(878, 78);
			arg_655_0.Size = size;
			this.Panel2.TabIndex = 30;
			this.GroupBox3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GroupBox3.Controls.Add(this.PDate);
			this.GroupBox3.Controls.Add(this.rbDate);
			this.GroupBox3.Controls.Add(this.btnQuery);
			this.GroupBox3.Controls.Add(this.rbAllOrder);
			this.GroupBox3.Controls.Add(this.rbPresentOrder);
			Control arg_6F1_0 = this.GroupBox3;
			location = new Point(5, 5);
			arg_6F1_0.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			Control arg_71B_0 = this.GroupBox3;
			size = new Size(303, 70);
			arg_71B_0.Size = size;
			this.GroupBox3.TabIndex = 26;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "查询方式";
			this.PDate.Controls.Add(this.EndDate);
			this.PDate.Controls.Add(this.StDate);
			this.PDate.Controls.Add(this.Label3);
			Control arg_79C_0 = this.PDate;
			location = new Point(6, 36);
			arg_79C_0.Location = location;
			this.PDate.Name = "PDate";
			Control arg_7C6_0 = this.PDate;
			size = new Size(220, 30);
			arg_7C6_0.Size = size;
			this.PDate.TabIndex = 24;
			this.EndDate.Format = DateTimePickerFormat.Short;
			Control arg_7F5_0 = this.EndDate;
			location = new Point(123, 4);
			arg_7F5_0.Location = location;
			this.EndDate.Name = "EndDate";
			Control arg_81C_0 = this.EndDate;
			size = new Size(90, 21);
			arg_81C_0.Size = size;
			this.EndDate.TabIndex = 3;
			this.StDate.Format = DateTimePickerFormat.Short;
			Control arg_849_0 = this.StDate;
			location = new Point(3, 4);
			arg_849_0.Location = location;
			this.StDate.Name = "StDate";
			Control arg_870_0 = this.StDate;
			size = new Size(90, 21);
			arg_870_0.Size = size;
			this.StDate.TabIndex = 2;
			this.Label3.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_8B3_0 = this.Label3;
			location = new Point(100, 7);
			arg_8B3_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_8DA_0 = this.Label3;
			size = new Size(16, 15);
			arg_8DA_0.Size = size;
			this.Label3.TabIndex = 24;
			this.Label3.Text = "至";
			this.rbDate.AutoSize = true;
			Control arg_91D_0 = this.rbDate;
			location = new Point(225, 14);
			arg_91D_0.Location = location;
			this.rbDate.Name = "rbDate";
			Control arg_944_0 = this.rbDate;
			size = new Size(71, 16);
			arg_944_0.Size = size;
			this.rbDate.TabIndex = 2;
			this.rbDate.TabStop = true;
			this.rbDate.Text = "开立日期";
			this.rbDate.UseVisualStyleBackColor = true;
			this.btnQuery.BackColor = Color.FromArgb(9, 101, 156);
			this.btnQuery.FlatStyle = FlatStyle.Flat;
			this.btnQuery.ForeColor = SystemColors.ControlLightLight;
			Control arg_9C7_0 = this.btnQuery;
			location = new Point(230, 39);
			arg_9C7_0.Location = location;
			this.btnQuery.Name = "btnQuery";
			Control arg_9EE_0 = this.btnQuery;
			size = new Size(65, 24);
			arg_9EE_0.Size = size;
			this.btnQuery.TabIndex = 23;
			this.btnQuery.Text = "查询";
			this.btnQuery.UseVisualStyleBackColor = false;
			this.rbAllOrder.AutoSize = true;
			Control arg_A3A_0 = this.rbAllOrder;
			location = new Point(118, 14);
			arg_A3A_0.Location = location;
			this.rbAllOrder.Name = "rbAllOrder";
			Control arg_A61_0 = this.rbAllOrder;
			size = new Size(95, 16);
			arg_A61_0.Size = size;
			this.rbAllOrder.TabIndex = 1;
			this.rbAllOrder.TabStop = true;
			this.rbAllOrder.Text = "全部就诊医嘱";
			this.rbAllOrder.UseVisualStyleBackColor = true;
			this.rbPresentOrder.AutoSize = true;
			Control arg_AB7_0 = this.rbPresentOrder;
			location = new Point(6, 15);
			arg_AB7_0.Location = location;
			this.rbPresentOrder.Name = "rbPresentOrder";
			Control arg_ADE_0 = this.rbPresentOrder;
			size = new Size(95, 16);
			arg_ADE_0.Size = size;
			this.rbPresentOrder.TabIndex = 0;
			this.rbPresentOrder.TabStop = true;
			this.rbPresentOrder.Text = "当前就诊医嘱";
			this.rbPresentOrder.UseVisualStyleBackColor = true;
			this.GroupBox2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GroupBox2.Controls.Add(this.nudPageCount);
			this.GroupBox2.Controls.Add(this.btnPrev);
			this.GroupBox2.Controls.Add(this.btnNext);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.txtPageNum);
			Control arg_BA5_0 = this.GroupBox2;
			location = new Point(328, 5);
			arg_BA5_0.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			Control arg_BCF_0 = this.GroupBox2;
			size = new Size(166, 70);
			arg_BCF_0.Size = size;
			this.GroupBox2.TabIndex = 22;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "显示方式";
			NumericUpDown arg_C24_0 = this.nudPageCount;
			decimal num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			arg_C24_0.Increment = num;
			Control arg_C3B_0 = this.nudPageCount;
			location = new Point(64, 14);
			arg_C3B_0.Location = location;
			NumericUpDown arg_C67_0 = this.nudPageCount;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_C67_0.Minimum = num;
			this.nudPageCount.Name = "nudPageCount";
			Control arg_C8E_0 = this.nudPageCount;
			size = new Size(67, 21);
			arg_C8E_0.Size = size;
			this.nudPageCount.TabIndex = 27;
			NumericUpDown arg_CC8_0 = this.nudPageCount;
			num = new decimal(new int[]
			{
				15,
				0,
				0,
				0
			});
			arg_CC8_0.Value = num;
			this.btnPrev.BackColor = Color.FromArgb(49, 101, 156);
			this.btnPrev.FlatStyle = FlatStyle.Flat;
			this.btnPrev.ForeColor = Color.White;
			Control arg_D14_0 = this.btnPrev;
			location = new Point(13, 40);
			arg_D14_0.Location = location;
			this.btnPrev.Name = "btnPrev";
			Control arg_D3B_0 = this.btnPrev;
			size = new Size(28, 24);
			arg_D3B_0.Size = size;
			this.btnPrev.TabIndex = 28;
			this.btnPrev.Text = "<";
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnNext.BackColor = Color.FromArgb(49, 101, 156);
			this.btnNext.FlatStyle = FlatStyle.Flat;
			this.btnNext.ForeColor = Color.White;
			Control arg_DB0_0 = this.btnNext;
			location = new Point(117, 40);
			arg_DB0_0.Location = location;
			this.btnNext.Name = "btnNext";
			Control arg_DD7_0 = this.btnNext;
			size = new Size(28, 24);
			arg_DD7_0.Size = size;
			this.btnNext.TabIndex = 30;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = false;
			Control arg_E17_0 = this.Label4;
			location = new Point(12, 19);
			arg_E17_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_E3E_0 = this.Label4;
			size = new Size(55, 15);
			arg_E3E_0.Size = size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "每页条数";
			this.txtPageNum.BorderStyle = BorderStyle.FixedSingle;
			Control arg_E7D_0 = this.txtPageNum;
			location = new Point(47, 42);
			arg_E7D_0.Location = location;
			this.txtPageNum.Name = "txtPageNum";
			Control arg_EA4_0 = this.txtPageNum;
			size = new Size(64, 21);
			arg_EA4_0.Size = size;
			this.txtPageNum.TabIndex = 29;
			this.btnCancle.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnCancle.BackColor = Color.FromArgb(9, 101, 156);
			this.btnCancle.FlatStyle = FlatStyle.Flat;
			this.btnCancle.ForeColor = SystemColors.ControlLightLight;
			Control arg_F0D_0 = this.btnCancle;
			location = new Point(757, 32);
			arg_F0D_0.Location = location;
			this.btnCancle.Name = "btnCancle";
			Control arg_F34_0 = this.btnCancle;
			size = new Size(60, 24);
			arg_F34_0.Size = size;
			this.btnCancle.TabIndex = 25;
			this.btnCancle.Text = "取消";
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnOk.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnOk.BackColor = Color.FromArgb(9, 101, 156);
			this.btnOk.FlatStyle = FlatStyle.Flat;
			this.btnOk.ForeColor = SystemColors.ControlLightLight;
			Control arg_FB9_0 = this.btnOk;
			location = new Point(682, 32);
			arg_FB9_0.Location = location;
			this.btnOk.Name = "btnOk";
			Control arg_FE0_0 = this.btnOk;
			size = new Size(60, 24);
			arg_FE0_0.Size = size;
			this.btnOk.TabIndex = 24;
			this.btnOk.Text = "引用";
			this.btnOk.UseVisualStyleBackColor = false;
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.sprResult);
			this.Panel1.Dock = DockStyle.Top;
			Control arg_104C_0 = this.Panel1;
			location = new Point(3, 3);
			arg_104C_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_1079_0 = this.Panel1;
			size = new Size(878, 551);
			arg_1079_0.Size = size;
			this.Panel1.TabIndex = 29;
			this.sprResult.AccessibleDescription = "sprResult, Sheet1";
			this.sprResult.BackColor = SystemColors.Control;
			this.sprResult.set_BorderStyle(BorderStyle.FixedSingle);
			this.sprResult.Dock = DockStyle.Fill;
			this.sprResult.set_HorizontalScrollBarPolicy(0);
			Control arg_10DF_0 = this.sprResult;
			location = new Point(0, 0);
			arg_10DF_0.Location = location;
			this.sprResult.set_Name("sprResult");
			this.sprResult.get_Sheets().AddRange(new SheetView[]
			{
				this.sprResult_Sheet1
			});
			Control arg_1130_0 = this.sprResult;
			size = new Size(876, 549);
			arg_1130_0.Size = size;
			this.sprResult.TabIndex = 26;
			this.sprResult.set_VerticalScrollBarPolicy(0);
			this.sprResult.SetActiveViewport(0, 1, 1);
			this.sprResult_Sheet1.Reset();
			this.sprResult_Sheet1.set_SheetName("Sheet1");
			this.sprResult_Sheet1.set_ReferenceStyle(1);
			this.sprResult_Sheet1.set_ColumnCount(0);
			this.sprResult_Sheet1.set_RowCount(0);
			this.sprResult_Sheet1.get_RowHeader().get_Columns().get_Default().set_Resizable(false);
			this.sprResult_Sheet1.set_ReferenceStyle(0);
			this.tpEpsoidList.BackColor = SystemColors.InactiveCaptionText;
			this.tpEpsoidList.Controls.Add(this.dgBOLISData);
			TabPage arg_11F9_0 = this.tpEpsoidList;
			location = new Point(4, 21);
			arg_11F9_0.Location = location;
			this.tpEpsoidList.Name = "tpEpsoidList";
			Control arg_121D_0 = this.tpEpsoidList;
			padding = new Padding(3);
			arg_121D_0.Padding = padding;
			Control arg_123A_0 = this.tpEpsoidList;
			size = new Size(720, 429);
			arg_123A_0.Size = size;
			this.tpEpsoidList.TabIndex = 1;
			this.tpEpsoidList.Text = "就诊列表";
			this.dgBOLISData.AllowUserToAddRows = false;
			this.dgBOLISData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgBOLISData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBOLISData.Dock = DockStyle.Fill;
			Control arg_129C_0 = this.dgBOLISData;
			location = new Point(3, 3);
			arg_129C_0.Location = location;
			this.dgBOLISData.Name = "dgBOLISData";
			this.dgBOLISData.ReadOnly = true;
			this.dgBOLISData.RowTemplate.Height = 23;
			this.dgBOLISData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Control arg_12F3_0 = this.dgBOLISData;
			size = new Size(714, 423);
			arg_12F3_0.Size = size;
			this.dgBOLISData.TabIndex = 4;
			this.Label7.AutoSize = true;
			this.Label7.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_1342_0 = this.Label7;
			location = new Point(13, 5);
			arg_1342_0.Location = location;
			this.Label7.Name = "Label7";
			Control arg_1369_0 = this.Label7;
			size = new Size(109, 12);
			arg_1369_0.Size = size;
			this.Label7.TabIndex = 0;
			this.Label7.Text = "本次就诊检查信息";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.CancelButton = this.btnCancel;
			size = new Size(892, 666);
			this.ClientSize = size;
			this.Controls.Add(this.tcCheckReport);
			this.Name = "PacsDicForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "引用检查报告";
			this.tcCheckReport.ResumeLayout(false);
			this.tpQuoted.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.PDate.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((ISupportInitialize)this.nudPageCount).EndInit();
			this.Panel1.ResumeLayout(false);
			this.sprResult.EndInit();
			this.sprResult_Sheet1.EndInit();
			this.tpEpsoidList.ResumeLayout(false);
			((ISupportInitialize)this.dgBOLISData).EndInit();
			this.ResumeLayout(false);
		}

		public void ShowDic(int pageCount, DataSet resultDataSet, MIDictionary objMIDictionary, string strQuery, string strSessionID)
		{
		}

		public void ShowDic(MIDictionary objMIDictionary, string strQuery)
		{
		}

		private void PacsDicForm_Load(object sender, EventArgs e)
		{
			this._EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			this._PatientID = GlobalValues.GetValueByKey("PatientID");
			this.QueryEpisodeList();
			this.rbPresentOrder.Checked = true;
			this.txtPageNum.Text = Conversions.ToString(this.m_CurPageNum);
			this.PDate.Visible = false;
			this.QueryDictionary(this._EpisodeID, "1900-01-01", DateTime.Today.ToShortDateString(), "1", Conversions.ToString(1), Conversions.ToString(this.nudPageCount.Value));
		}

		private void QueryEpisodeList()
		{
			CommonQuoteClass commonQuoteClass = new CommonQuoteClass();
			commonQuoteClass.QueryEpsoideList(this.dgBOLISData, this._PatientID);
		}

		private void dgBOLISData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string value = Conversions.ToString(this.dgBOLISData.CurrentCell.RowIndex);
			string episodeID = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeID"].Value.ToString();
			string text = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeDate"].Value.ToString();
			string text2 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["DeptDesc"].Value.ToString();
			string text3 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeType"].Value.ToString();
			this._EpisodeID = episodeID;
			this.m_CurPageNum = 1;
			this.QueryDictionary(this._EpisodeID, "1900-01-01", DateTime.Today.ToShortDateString(), "1", "1", Conversions.ToString(this.nudPageCount.Value));
			this.tcCheckReport.SelectedTab = this.tpQuoted;
			this.rbAllOrder.Checked = false;
			this.rbDate.Checked = false;
			this.rbPresentOrder.Checked = false;
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(decimal.Add(decimal.Multiply(new decimal(checked(this.m_CurPageNum - 1)), this.nudPageCount.Value), decimal.One));
			int value2 = Convert.ToInt32(decimal.Subtract(decimal.Add(new decimal(value), this.nudPageCount.Value), decimal.One));
			if (this.rbDate.Checked)
			{
				this.QueryDictionary(this._PatientID, this.StDate.Text, this.EndDate.Text, "2", Conversions.ToString(value), Conversions.ToString(value2));
			}
			else if (this.rbAllOrder.Checked)
			{
				this.QueryDictionary(this._PatientID, "1900-01-01", DateTime.Today.ToShortDateString(), "2", Conversions.ToString(value), Conversions.ToString(value2));
			}
			else
			{
				this.QueryDictionary(this._EpisodeID, "1900-01-01", DateTime.Today.ToShortDateString(), "1", Conversions.ToString(value), Conversions.ToString(value2));
			}
		}

		public void QueryDictionary(string ID, string DateSt, string DateEnd, string Flag, string StartPage, string EndPage)
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			dataTable = dataSet.Tables.Add("ItemListByDate");
			dataTable.Columns.AddRange(new DataColumn[]
			{
				new DataColumn("选择", Type.GetType("System.String")),
				new DataColumn("就诊日期", Type.GetType("System.String")),
				new DataColumn("就诊科室", Type.GetType("System.String")),
				new DataColumn("医嘱名称", Type.GetType("System.String")),
				new DataColumn("医嘱RowID", Type.GetType("System.String")),
				new DataColumn("报告RowID", Type.GetType("System.String"))
			});
			dataTable2 = dataSet.Tables.Add("ReportByOeordID");
			dataTable2.Columns.AddRange(new DataColumn[]
			{
				new DataColumn("检查所见", Type.GetType("System.String")),
				new DataColumn("诊断意见", Type.GetType("System.String")),
				new DataColumn("检查方法", Type.GetType("System.String")),
				new DataColumn("医嘱RowID", Type.GetType("System.String"))
			});
			checked
			{
				try
				{
					EPACSListDataset pACSItemList = WebServiceLayer.PACSDataAccess.GetPACSItemList(ID, DateSt, DateEnd, Flag, StartPage, EndPage);
					int arg_180_0 = 0;
					int num = pACSItemList.Tables[0].Rows.Count - 1;
					for (int i = arg_180_0; i <= num; i++)
					{
						dataTable.Rows.Add(new object[]
						{
							"",
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][0]),
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][1]),
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][2]),
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][3]),
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][4])
						});
						EPACSRptByOEordIDDataSet ePACSRptByOEordIDDataSet = WebServiceLayer.PACSDataAccess.SelectReportByOeordID(pACSItemList.Tables[0].Rows[i][3].ToString());
						dataTable2.Rows.Add(new object[]
						{
							ePACSRptByOEordIDDataSet.Tables[0].Rows[0][0].ToString().Replace("_$c(13,10)_", "\r").Replace("_$c_", ""),
							ePACSRptByOEordIDDataSet.Tables[0].Rows[0][1].ToString().Replace("_$c(13,10)_", "\r").Replace("_$c_", ""),
							RuntimeHelpers.GetObjectValue(ePACSRptByOEordIDDataSet.Tables[0].Rows[0][2]),
							RuntimeHelpers.GetObjectValue(pACSItemList.Tables[0].Rows[i][3])
						});
					}
					dataSet.Relations.Add("ItemListByDate", dataTable.Columns["医嘱RowID"], dataTable2.Columns["医嘱RowID"]);
					this.BindResultSet(dataSet);
				}
				catch (Exception expr_3CD)
				{
					ProjectData.SetProjectError(expr_3CD);
					MessageManager.ShowErrorMessage("没有数据");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void BindResultSet(DataSet curDataSet)
		{
			CheckBoxCellType checkBoxCellType = new CheckBoxCellType();
			checkBoxCellType.set_ThreeState(false);
			SheetView sheetView = this.sprResult.get_Sheets().get_Item(0);
			sheetView.set_DataSource(curDataSet);
			sheetView.set_DataMember("PACSINFO");
			sheetView.SetColumnWidth(0, 40);
			sheetView.get_Columns().get_Item(0).set_CellType(checkBoxCellType);
			sheetView.SetColumnWidth(1, 80);
			sheetView.SetColumnWidth(2, 90);
			sheetView.SetColumnWidth(3, 300);
			sheetView.get_Columns().get_Item(4).set_Visible(false);
			sheetView.get_Columns().get_Item(5).set_Visible(false);
			this.sprResult.set_HorizontalScrollBarPolicy(0);
			this.sprResult.set_VerticalScrollBarPolicy(0);
		}

		public void SetChildViewStyle(SheetView sv)
		{
			RichTextCellType richTextCellType = new RichTextCellType();
			richTextCellType.set_Multiline(true);
			richTextCellType.set_ReadOnly(true);
			richTextCellType.set_ScrollBars(RichTextBoxScrollBars.Both);
			richTextCellType.set_WordWrap(true);
			sv.get_Columns().get_Item(0).set_CellType(richTextCellType);
			sv.get_Columns().get_Item(1).set_CellType(richTextCellType);
			sv.get_Columns().get_Item(2).set_CellType(richTextCellType);
			sv.get_Columns().get_Item(0).set_Width(300f);
			sv.get_Columns().get_Item(1).set_Width(300f);
			sv.get_Columns().get_Item(2).set_Width(300f);
			sv.get_Columns().get_Item(3).set_Visible(false);
			Row row = sv.get_Rows().get_Item(0);
			float preferredHeight = row.GetPreferredHeight();
			row.set_Height(preferredHeight);
		}

		private void sprResult_ChildViewCreated(object sender, ChildViewCreatedEventArgs e)
		{
			this.SetChildViewStyle(e.get_SheetView());
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			checked
			{
				this.m_CurPageNum--;
				if (this.m_CurPageNum >= 1)
				{
					this.txtPageNum.Text = Conversions.ToString(this.m_CurPageNum);
					this.btnNext.Enabled = true;
					this.btnQuery_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					this.btnPrev.Enabled = false;
				}
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			checked
			{
				this.m_CurPageNum++;
				this.txtPageNum.Text = Conversions.ToString(this.m_CurPageNum);
				this.btnPrev.Enabled = true;
				this.btnQuery_Click(RuntimeHelpers.GetObjectValue(sender), e);
				if (decimal.Compare(new decimal(this.sprResult.get_Sheets().get_Item(0).get_RowCount()), this.nudPageCount.Value) < 0)
				{
					this.btnNext.Enabled = false;
				}
			}
		}

		private void rbPresentOrder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbPresentOrder.Checked)
			{
				this.RefreshState();
				this._EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			}
		}

		private void rbDate_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbDate.Checked)
			{
				this.PDate.Visible = true;
				this.RefreshState();
			}
			else
			{
				this.PDate.Visible = false;
			}
		}

		private void rbAllOrder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbAllOrder.Checked)
			{
				this.RefreshState();
			}
		}

		private void nudPageCount_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurPageNum = 1;
		}

		private void RefreshState()
		{
			this.btnPrev.Enabled = true;
			this.btnNext.Enabled = true;
			this.m_CurPageNum = 1;
			this.txtPageNum.Text = Conversions.ToString(this.m_CurPageNum);
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.ChangeDictionaryText();
			this.DialogResult = DialogResult.OK;
		}

		private void ChangeDictionaryText()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string sysOptionValue = SysOptionManager.GetSysOptionValue("RISRefScheme", "项目:|就诊日期:+父+1^就诊科室:+父+2^医嘱名称:+父+3^诊断所见:+子+0^诊断意见:+子+1^检查方法:+子+2|,^\\r\\n");
			string[] array = sysOptionValue.Split(new char[]
			{
				'|'
			});
			string[] array2 = array[1].Split(new char[]
			{
				'^'
			});
			string[] array3 = array[2].Split(new char[]
			{
				'^'
			});
			stringBuilder.Append(array[0]);
			int arg_8B_0 = 0;
			checked
			{
				int num = this.sprResult.get_Sheets().get_Item(0).get_Rows().get_Count() - 1;
				for (int i = arg_8B_0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, 0).get_Value(), "True", false))
					{
						string[] array4 = array2;
						for (int j = 0; j < array4.Length; j++)
						{
							string text = array4[j];
							if (Operators.CompareString(text, "", false) != 0)
							{
								string[] array5 = text.Split(new char[]
								{
									'+'
								});
								stringBuilder.Append(array5[0]);
								if (Operators.CompareString(array5[1], "父", false) == 0)
								{
									stringBuilder.Append(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, Conversions.ToInteger(array5[2])).get_Text());
								}
								else if (Operators.CompareString(array5[1], "子", false) == 0)
								{
									stringBuilder.Append(this.sprResult.get_Sheets().get_Item(0).GetChildView(i, 0).get_Cells().get_Item(0, Conversions.ToInteger(array5[2])).get_Text());
								}
								stringBuilder.Append(array3[0].Replace("\\r\\n", "\r"));
							}
						}
						stringBuilder.Remove(stringBuilder.Length - 1, 1);
						stringBuilder.Append(array3[1].Replace("\\r\\n", "\r"));
					}
				}
				this._DicValueCode = "";
				this._DicValue = stringBuilder.ToString();
			}
		}

		private void PacsDicForm_SizeChanged(object sender, EventArgs e)
		{
			this.Panel1.Height = checked(this.tpQuoted.Height - this.Panel2.Height - 5);
		}
	}
}
