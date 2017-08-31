using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using LISData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class LISDicForm : Form
	{
		[AccessedThroughProperty("txtCurPage")]
		private TextBox _txtCurPage;

		[AccessedThroughProperty("btnNextPage")]
		private Button _btnNextPage;

		[AccessedThroughProperty("sprResult")]
		private FpSpread _sprResult;

		[AccessedThroughProperty("sprResult_Sheet1")]
		private SheetView _sprResult_Sheet1;

		[AccessedThroughProperty("btnPrePage")]
		private Button _btnPrePage;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("rbByDate")]
		private RadioButton _rbByDate;

		[AccessedThroughProperty("rbByOrder")]
		private RadioButton _rbByOrder;

		[AccessedThroughProperty("groupBoxByOrder")]
		private GroupBox _groupBoxByOrder;

		[AccessedThroughProperty("TctrlsResult")]
		private TabControl _TctrlsResult;

		[AccessedThroughProperty("tpResult")]
		private TabPage _tpResult;

		[AccessedThroughProperty("palBotBox")]
		private Panel _palBotBox;

		[AccessedThroughProperty("groupBoxSelType")]
		private GroupBox _groupBoxSelType;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("EndDate")]
		private DateTimePicker _EndDate;

		[AccessedThroughProperty("StDate")]
		private DateTimePicker _StDate;

		[AccessedThroughProperty("btnQuery")]
		private Button _btnQuery;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("tpList")]
		private TabPage _tpList;

		[AccessedThroughProperty("dgBOLISData")]
		private DataGridView _dgBOLISData;

		[AccessedThroughProperty("palTopList")]
		private Panel _palTopList;

		[AccessedThroughProperty("rbAllOrder")]
		private RadioButton _rbAllOrder;

		[AccessedThroughProperty("PDate")]
		private Panel _PDate;

		[AccessedThroughProperty("nudPageRow")]
		private NumericUpDown _nudPageRow;

		private IContainer components;

		private string m_EpisodeID;

		private string m_DicValue;

		private string m_DicValueCode;

		private string m_PatientID;

		private int m_CurPageNum;

		private string UnusualSelectSwich;

		private const int IndexOrderName = 3;

		private const int IndexOrderLabNo = 4;

		private const int IndexOrderLabType = 5;

		private const int IndexOrderDate = 6;

		private const int IndexOrderTime = 7;

		private const int IndexItemFlag = 1;

		private const int IndexItemName = 2;

		private const int IndexItemSyno = 3;

		private const int IndexItemResult = 4;

		private const int IndexItemUnit = 5;

		private const int IndexItemRange = 6;

		private const string DEFAULT_SYSOPTION_LISREFSCHEME = "##{ITEM}{RESULT}{UNIT}#{，|。|*}#";

		private const string DEFAULT_SYSOPTION_LISCOLUMNSCHEME = "{EpisodeDate},{EpisodeSection},{ORDER},{LabEpisodeNo},{SpecimenDesc},{DATE},{TIME}^{Flag},{ITEM},{SYNO},{RESULT},{UNIT},{RANGE}";

		internal virtual TextBox txtCurPage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCurPage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCurPage = value;
			}
		}

		internal virtual Button btnNextPage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNextPage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnNextPage_Click);
				if (this._btnNextPage != null)
				{
					this._btnNextPage.Click -= value2;
				}
				this._btnNextPage = value;
				if (this._btnNextPage != null)
				{
					this._btnNextPage.Click += value2;
				}
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
				EditorNotifyEventHandler editorNotifyEventHandler = new EditorNotifyEventHandler(this.sprResult_ButtonClicked);
				if (this._sprResult != null)
				{
					this._sprResult.remove_ChildViewCreated(childViewCreatedEventHandler);
					this._sprResult.remove_ButtonClicked(editorNotifyEventHandler);
				}
				this._sprResult = value;
				if (this._sprResult != null)
				{
					this._sprResult.add_ChildViewCreated(childViewCreatedEventHandler);
					this._sprResult.add_ButtonClicked(editorNotifyEventHandler);
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

		internal virtual Button btnPrePage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPrePage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPrePage_Click);
				if (this._btnPrePage != null)
				{
					this._btnPrePage.Click -= value2;
				}
				this._btnPrePage = value;
				if (this._btnPrePage != null)
				{
					this._btnPrePage.Click += value2;
				}
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

		internal virtual RadioButton rbByDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbByDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbByDate_CheckedChanged);
				if (this._rbByDate != null)
				{
					this._rbByDate.CheckedChanged -= value2;
				}
				this._rbByDate = value;
				if (this._rbByDate != null)
				{
					this._rbByDate.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rbByOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbByOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbByOrder_CheckedChanged);
				if (this._rbByOrder != null)
				{
					this._rbByOrder.CheckedChanged -= value2;
				}
				this._rbByOrder = value;
				if (this._rbByOrder != null)
				{
					this._rbByOrder.CheckedChanged += value2;
				}
			}
		}

		internal virtual GroupBox groupBoxByOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._groupBoxByOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._groupBoxByOrder = value;
			}
		}

		internal virtual TabControl TctrlsResult
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TctrlsResult;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TctrlsResult = value;
			}
		}

		internal virtual TabPage tpResult
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpResult;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpResult = value;
			}
		}

		internal virtual Panel palBotBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._palBotBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._palBotBox = value;
			}
		}

		internal virtual GroupBox groupBoxSelType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._groupBoxSelType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._groupBoxSelType = value;
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

		private virtual DateTimePicker StDate
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

		internal virtual TabPage tpList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpList = value;
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

		internal virtual Panel palTopList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._palTopList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._palTopList = value;
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

		internal virtual NumericUpDown nudPageRow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nudPageRow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nudPageRow_ValueChanged);
				if (this._nudPageRow != null)
				{
					this._nudPageRow.ValueChanged -= value2;
				}
				this._nudPageRow = value;
				if (this._nudPageRow != null)
				{
					this._nudPageRow.ValueChanged += value2;
				}
			}
		}

		public string DicValue
		{
			get
			{
				return this.m_DicValue;
			}
			set
			{
				this.m_DicValue = value;
			}
		}

		public string DicValueCode
		{
			get
			{
				return this.m_DicValueCode;
			}
			set
			{
				this.m_DicValueCode = value;
			}
		}

		public LISDicForm()
		{
			base.SizeChanged += new EventHandler(this.LISDicForm_SizeChanged);
			base.Load += new EventHandler(this.LISDicForm_Load);
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
			this.txtCurPage = new TextBox();
			this.btnNextPage = new Button();
			this.sprResult = new FpSpread();
			this.sprResult_Sheet1 = new SheetView();
			this.btnPrePage = new Button();
			this.Label2 = new Label();
			this.rbByDate = new RadioButton();
			this.rbByOrder = new RadioButton();
			this.groupBoxByOrder = new GroupBox();
			this.nudPageRow = new NumericUpDown();
			this.TctrlsResult = new TabControl();
			this.tpResult = new TabPage();
			this.palTopList = new Panel();
			this.palBotBox = new Panel();
			this.groupBoxSelType = new GroupBox();
			this.PDate = new Panel();
			this.Label1 = new Label();
			this.EndDate = new DateTimePicker();
			this.StDate = new DateTimePicker();
			this.rbAllOrder = new RadioButton();
			this.btnQuery = new Button();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.tpList = new TabPage();
			this.dgBOLISData = new DataGridView();
			this.sprResult.BeginInit();
			this.sprResult_Sheet1.BeginInit();
			this.groupBoxByOrder.SuspendLayout();
			((ISupportInitialize)this.nudPageRow).BeginInit();
			this.TctrlsResult.SuspendLayout();
			this.tpResult.SuspendLayout();
			this.palTopList.SuspendLayout();
			this.palBotBox.SuspendLayout();
			this.groupBoxSelType.SuspendLayout();
			this.PDate.SuspendLayout();
			this.tpList.SuspendLayout();
			((ISupportInitialize)this.dgBOLISData).BeginInit();
			this.SuspendLayout();
			this.txtCurPage.BorderStyle = BorderStyle.FixedSingle;
			Control arg_1BB_0 = this.txtCurPage;
			Point location = new Point(55, 44);
			arg_1BB_0.Location = location;
			this.txtCurPage.Name = "txtCurPage";
			this.txtCurPage.ReadOnly = true;
			Control arg_1EE_0 = this.txtCurPage;
			Size size = new Size(64, 21);
			arg_1EE_0.Size = size;
			this.txtCurPage.TabIndex = 33;
			this.btnNextPage.BackColor = Color.FromArgb(9, 101, 156);
			this.btnNextPage.FlatStyle = FlatStyle.Flat;
			this.btnNextPage.ForeColor = SystemColors.ControlLightLight;
			Control arg_247_0 = this.btnNextPage;
			location = new Point(127, 42);
			arg_247_0.Location = location;
			this.btnNextPage.Name = "btnNextPage";
			Control arg_26E_0 = this.btnNextPage;
			size = new Size(24, 24);
			arg_26E_0.Size = size;
			this.btnNextPage.TabIndex = 31;
			this.btnNextPage.Text = ">";
			this.btnNextPage.UseVisualStyleBackColor = false;
			this.sprResult.AccessibleDescription = "sprResult";
			this.sprResult.BackColor = Color.FromArgb(246, 250, 253);
			this.sprResult.set_BorderStyle(BorderStyle.None);
			this.sprResult.Dock = DockStyle.Fill;
			this.sprResult.set_HorizontalScrollBarPolicy(0);
			Control arg_2FF_0 = this.sprResult;
			location = new Point(0, 0);
			arg_2FF_0.Location = location;
			this.sprResult.set_Name("sprResult");
			this.sprResult.get_Sheets().AddRange(new SheetView[]
			{
				this.sprResult_Sheet1
			});
			Control arg_34D_0 = this.sprResult;
			size = new Size(876, 542);
			arg_34D_0.Size = size;
			this.sprResult.TabIndex = 27;
			this.sprResult.set_VerticalScrollBarPolicy(0);
			this.sprResult.SetActiveViewport(0, 1, 1);
			this.sprResult_Sheet1.Reset();
			this.sprResult_Sheet1.set_SheetName("Sheet1");
			this.sprResult_Sheet1.set_ReferenceStyle(1);
			this.sprResult_Sheet1.set_ColumnCount(0);
			this.sprResult_Sheet1.set_RowCount(0);
			this.sprResult_Sheet1.get_RowHeader().get_Columns().get_Default().set_Resizable(false);
			this.sprResult_Sheet1.set_ReferenceStyle(0);
			this.btnPrePage.BackColor = Color.FromArgb(9, 101, 156);
			this.btnPrePage.FlatStyle = FlatStyle.Flat;
			this.btnPrePage.ForeColor = SystemColors.ControlLightLight;
			Control arg_426_0 = this.btnPrePage;
			location = new Point(23, 42);
			arg_426_0.Location = location;
			this.btnPrePage.Name = "btnPrePage";
			Control arg_44D_0 = this.btnPrePage;
			size = new Size(24, 24);
			arg_44D_0.Size = size;
			this.btnPrePage.TabIndex = 30;
			this.btnPrePage.Text = "<";
			this.btnPrePage.UseVisualStyleBackColor = false;
			Control arg_48D_0 = this.Label2;
			location = new Point(19, 22);
			arg_48D_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_4B4_0 = this.Label2;
			size = new Size(54, 16);
			arg_4B4_0.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "每页条数";
			Control arg_4EA_0 = this.rbByDate;
			location = new Point(198, 20);
			arg_4EA_0.Location = location;
			this.rbByDate.Name = "rbByDate";
			Control arg_511_0 = this.rbByDate;
			size = new Size(88, 18);
			arg_511_0.Size = size;
			this.rbByDate.TabIndex = 0;
			this.rbByDate.Text = "按检验日期";
			this.rbByOrder.Checked = true;
			Control arg_54F_0 = this.rbByOrder;
			location = new Point(8, 20);
			arg_54F_0.Location = location;
			this.rbByOrder.Name = "rbByOrder";
			Control arg_576_0 = this.rbByOrder;
			size = new Size(88, 18);
			arg_576_0.Size = size;
			this.rbByOrder.TabIndex = 1;
			this.rbByOrder.TabStop = true;
			this.rbByOrder.Text = "当前就诊医嘱";
			this.groupBoxByOrder.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.groupBoxByOrder.Controls.Add(this.nudPageRow);
			this.groupBoxByOrder.Controls.Add(this.txtCurPage);
			this.groupBoxByOrder.Controls.Add(this.btnNextPage);
			this.groupBoxByOrder.Controls.Add(this.btnPrePage);
			this.groupBoxByOrder.Controls.Add(this.Label2);
			Control arg_631_0 = this.groupBoxByOrder;
			location = new Point(317, 7);
			arg_631_0.Location = location;
			this.groupBoxByOrder.Name = "groupBoxByOrder";
			Control arg_65B_0 = this.groupBoxByOrder;
			size = new Size(179, 73);
			arg_65B_0.Size = size;
			this.groupBoxByOrder.TabIndex = 32;
			this.groupBoxByOrder.TabStop = false;
			this.groupBoxByOrder.Text = "按检验医嘱";
			NumericUpDown arg_6B0_0 = this.nudPageRow;
			decimal num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			arg_6B0_0.Increment = num;
			Control arg_6C7_0 = this.nudPageRow;
			location = new Point(79, 17);
			arg_6C7_0.Location = location;
			NumericUpDown arg_6F3_0 = this.nudPageRow;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_6F3_0.Minimum = num;
			this.nudPageRow.Name = "nudPageRow";
			Control arg_71A_0 = this.nudPageRow;
			size = new Size(49, 21);
			arg_71A_0.Size = size;
			this.nudPageRow.TabIndex = 34;
			NumericUpDown arg_754_0 = this.nudPageRow;
			num = new decimal(new int[]
			{
				15,
				0,
				0,
				0
			});
			arg_754_0.Value = num;
			this.TctrlsResult.Controls.Add(this.tpResult);
			this.TctrlsResult.Controls.Add(this.tpList);
			this.TctrlsResult.Dock = DockStyle.Fill;
			Control arg_7A1_0 = this.TctrlsResult;
			location = new Point(0, 0);
			arg_7A1_0.Location = location;
			this.TctrlsResult.Name = "TctrlsResult";
			this.TctrlsResult.SelectedIndex = 0;
			Control arg_7DA_0 = this.TctrlsResult;
			size = new Size(892, 666);
			arg_7DA_0.Size = size;
			this.TctrlsResult.TabIndex = 29;
			this.tpResult.BackColor = SystemColors.InactiveCaptionText;
			this.tpResult.Controls.Add(this.palTopList);
			this.tpResult.Controls.Add(this.palBotBox);
			TabPage arg_839_0 = this.tpResult;
			location = new Point(4, 21);
			arg_839_0.Location = location;
			this.tpResult.Name = "tpResult";
			Control arg_85E_0 = this.tpResult;
			Padding padding = new Padding(3);
			arg_85E_0.Padding = padding;
			Control arg_87B_0 = this.tpResult;
			size = new Size(884, 641);
			arg_87B_0.Size = size;
			this.tpResult.TabIndex = 0;
			this.tpResult.Text = "检验结果";
			this.tpResult.UseVisualStyleBackColor = true;
			this.palTopList.BorderStyle = BorderStyle.FixedSingle;
			this.palTopList.Controls.Add(this.sprResult);
			this.palTopList.Dock = DockStyle.Top;
			Control arg_8E6_0 = this.palTopList;
			location = new Point(3, 3);
			arg_8E6_0.Location = location;
			this.palTopList.Name = "palTopList";
			Control arg_913_0 = this.palTopList;
			size = new Size(878, 544);
			arg_913_0.Size = size;
			this.palTopList.TabIndex = 34;
			this.palBotBox.Controls.Add(this.groupBoxSelType);
			this.palBotBox.Controls.Add(this.groupBoxByOrder);
			this.palBotBox.Controls.Add(this.btnOK);
			this.palBotBox.Controls.Add(this.btnCancel);
			this.palBotBox.Dock = DockStyle.Bottom;
			Control arg_99D_0 = this.palBotBox;
			location = new Point(3, 553);
			arg_99D_0.Location = location;
			this.palBotBox.Name = "palBotBox";
			Control arg_9C7_0 = this.palBotBox;
			size = new Size(878, 85);
			arg_9C7_0.Size = size;
			this.palBotBox.TabIndex = 33;
			this.groupBoxSelType.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.groupBoxSelType.Controls.Add(this.PDate);
			this.groupBoxSelType.Controls.Add(this.rbAllOrder);
			this.groupBoxSelType.Controls.Add(this.rbByOrder);
			this.groupBoxSelType.Controls.Add(this.rbByDate);
			this.groupBoxSelType.Controls.Add(this.btnQuery);
			Control arg_A63_0 = this.groupBoxSelType;
			location = new Point(8, 7);
			arg_A63_0.Location = location;
			this.groupBoxSelType.Name = "groupBoxSelType";
			Control arg_A8D_0 = this.groupBoxSelType;
			size = new Size(303, 73);
			arg_A8D_0.Size = size;
			this.groupBoxSelType.TabIndex = 33;
			this.groupBoxSelType.TabStop = false;
			this.groupBoxSelType.Text = "查询方式";
			this.PDate.Controls.Add(this.Label1);
			this.PDate.Controls.Add(this.EndDate);
			this.PDate.Controls.Add(this.StDate);
			Control arg_B0E_0 = this.PDate;
			location = new Point(8, 40);
			arg_B0E_0.Location = location;
			this.PDate.Name = "PDate";
			Control arg_B38_0 = this.PDate;
			size = new Size(200, 28);
			arg_B38_0.Size = size;
			this.PDate.TabIndex = 30;
			this.Label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_B7D_0 = this.Label1;
			location = new Point(90, 9);
			arg_B7D_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_BA4_0 = this.Label1;
			size = new Size(16, 15);
			arg_BA4_0.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "至";
			this.EndDate.Format = DateTimePickerFormat.Short;
			Control arg_BE2_0 = this.EndDate;
			location = new Point(109, 3);
			arg_BE2_0.Location = location;
			DateTimePicker arg_C03_0 = this.EndDate;
			DateTime minDate = new DateTime(1840, 12, 31, 0, 0, 0, 0);
			arg_C03_0.MinDate = minDate;
			this.EndDate.Name = "EndDate";
			Control arg_C2A_0 = this.EndDate;
			size = new Size(85, 21);
			arg_C2A_0.Size = size;
			this.EndDate.TabIndex = 3;
			this.StDate.Format = DateTimePickerFormat.Short;
			Control arg_C57_0 = this.StDate;
			location = new Point(5, 3);
			arg_C57_0.Location = location;
			DateTimePicker arg_C78_0 = this.StDate;
			minDate = new DateTime(1840, 12, 31, 0, 0, 0, 0);
			arg_C78_0.MinDate = minDate;
			this.StDate.Name = "StDate";
			Control arg_C9F_0 = this.StDate;
			size = new Size(84, 21);
			arg_C9F_0.Size = size;
			this.StDate.TabIndex = 1;
			Control arg_CC2_0 = this.rbAllOrder;
			location = new Point(104, 20);
			arg_CC2_0.Location = location;
			this.rbAllOrder.Name = "rbAllOrder";
			Control arg_CE9_0 = this.rbAllOrder;
			size = new Size(88, 18);
			arg_CE9_0.Size = size;
			this.rbAllOrder.TabIndex = 2;
			this.rbAllOrder.Text = "全部就诊医嘱";
			this.btnQuery.BackColor = Color.FromArgb(9, 101, 156);
			this.btnQuery.FlatStyle = FlatStyle.Flat;
			this.btnQuery.ForeColor = SystemColors.ControlLightLight;
			Control arg_D54_0 = this.btnQuery;
			location = new Point(212, 42);
			arg_D54_0.Location = location;
			this.btnQuery.Name = "btnQuery";
			Control arg_D7B_0 = this.btnQuery;
			size = new Size(72, 24);
			arg_D7B_0.Size = size;
			this.btnQuery.TabIndex = 29;
			this.btnQuery.Text = "查询";
			this.btnQuery.UseVisualStyleBackColor = false;
			this.btnOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnOK.BackColor = Color.FromArgb(9, 101, 156);
			this.btnOK.DialogResult = DialogResult.Cancel;
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = SystemColors.ControlLightLight;
			Control arg_E0C_0 = this.btnOK;
			location = new Point(699, 31);
			arg_E0C_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_E33_0 = this.btnOK;
			size = new Size(72, 24);
			arg_E33_0.Size = size;
			this.btnOK.TabIndex = 30;
			this.btnOK.Text = "确定";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnCancel.BackColor = Color.FromArgb(9, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = SystemColors.ControlLightLight;
			Control arg_EC4_0 = this.btnCancel;
			location = new Point(786, 31);
			arg_EC4_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_EEB_0 = this.btnCancel;
			size = new Size(72, 24);
			arg_EEB_0.Size = size;
			this.btnCancel.TabIndex = 31;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.tpList.BackColor = SystemColors.InactiveCaptionText;
			this.tpList.Controls.Add(this.dgBOLISData);
			TabPage arg_F50_0 = this.tpList;
			location = new Point(4, 21);
			arg_F50_0.Location = location;
			this.tpList.Name = "tpList";
			Control arg_F75_0 = this.tpList;
			padding = new Padding(3);
			arg_F75_0.Padding = padding;
			Control arg_F92_0 = this.tpList;
			size = new Size(720, 429);
			arg_F92_0.Size = size;
			this.tpList.TabIndex = 1;
			this.tpList.Text = "就诊列表";
			this.tpList.UseVisualStyleBackColor = true;
			this.dgBOLISData.AllowUserToAddRows = false;
			this.dgBOLISData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgBOLISData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBOLISData.Dock = DockStyle.Fill;
			Control arg_1000_0 = this.dgBOLISData;
			location = new Point(3, 3);
			arg_1000_0.Location = location;
			this.dgBOLISData.Name = "dgBOLISData";
			this.dgBOLISData.ReadOnly = true;
			this.dgBOLISData.RowTemplate.Height = 23;
			this.dgBOLISData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Control arg_1057_0 = this.dgBOLISData;
			size = new Size(714, 423);
			arg_1057_0.Size = size;
			this.dgBOLISData.TabIndex = 2;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(246, 250, 253);
			size = new Size(892, 666);
			this.ClientSize = size;
			this.Controls.Add(this.TctrlsResult);
			this.Name = "LISDicForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "引用检验结果";
			this.sprResult.EndInit();
			this.sprResult_Sheet1.EndInit();
			this.groupBoxByOrder.ResumeLayout(false);
			this.groupBoxByOrder.PerformLayout();
			((ISupportInitialize)this.nudPageRow).EndInit();
			this.TctrlsResult.ResumeLayout(false);
			this.tpResult.ResumeLayout(false);
			this.palTopList.ResumeLayout(false);
			this.palBotBox.ResumeLayout(false);
			this.groupBoxSelType.ResumeLayout(false);
			this.PDate.ResumeLayout(false);
			this.tpList.ResumeLayout(false);
			((ISupportInitialize)this.dgBOLISData).EndInit();
			this.ResumeLayout(false);
		}

		private void LISDicForm_Load(object sender, EventArgs e)
		{
			if (!LISDicForm.IsSysOptionConfigOK())
			{
				return;
			}
			this.Init();
			this.QueryEpisodeList();
		}

		private void Init()
		{
			this.m_EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			this.m_PatientID = GlobalValues.GetValueByKey("PatientID");
			this.UnusualSelectSwich = SysOptionManager.GetSysOptionValue("LisSelectUnusualSwich", "N");
			this.PDate.Visible = false;
			this.rbByOrder.Checked = true;
			this.txtCurPage.Text = this.m_CurPageNum.ToString();
			this.QueryDictionary(this.m_EpisodeID, "", "", Conversions.ToString(1), Conversions.ToString(this.nudPageRow.Value), "1");
		}

		private void QueryEpisodeList()
		{
			CommonQuoteClass commonQuoteClass = new CommonQuoteClass();
			commonQuoteClass.QueryEpsoideList(this.dgBOLISData, this.m_PatientID);
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(decimal.Add(decimal.Multiply(new decimal(checked(this.m_CurPageNum - 1)), this.nudPageRow.Value), decimal.One));
			int value2 = Convert.ToInt32(decimal.Subtract(decimal.Add(new decimal(value), this.nudPageRow.Value), decimal.One));
			if (this.m_EpisodeID != null)
			{
				if (this.rbAllOrder.Checked)
				{
					this.QueryDictionary(this.m_PatientID, "", "", Conversions.ToString(value), Conversions.ToString(value2), "2");
				}
				else if (this.rbByDate.Checked && this.IsDateValid())
				{
					this.QueryDictionary(this.m_PatientID, this.StDate.Text, this.EndDate.Text, Conversions.ToString(value), Conversions.ToString(value2), "2");
				}
				else
				{
					this.QueryDictionary(this.m_EpisodeID, "", "", Conversions.ToString(value), Conversions.ToString(value2), "1");
				}
			}
		}

		public void QueryDictionary(string Id, string StDate, string EdDate, string StPage, string EdPage, string Falg)
		{
			checked
			{
				try
				{
					string sysOptionLISColumnScheme = LISDicForm.GetSysOptionLISColumnScheme();
					string[] array = sysOptionLISColumnScheme.Split(new char[]
					{
						'^'
					})[0].Split(new char[]
					{
						','
					});
					string[] array2 = sysOptionLISColumnScheme.Split(new char[]
					{
						'^'
					})[1].Split(new char[]
					{
						','
					});
					DataSet dataSet = new DataSet();
					DataTable dataTable = new DataTable();
					DataTable dataTable2 = new DataTable();
					Type type = Type.GetType("System.String");
					dataTable = dataSet.Tables.Add("ItemList");
					dataTable.Columns.Add(new DataColumn("选择", type));
					int arg_B7_0 = 0;
					int num = array.Length - 1;
					for (int i = arg_B7_0; i <= num; i++)
					{
						string orderDataSetColumnName = LISDicForm.GetOrderDataSetColumnName(array[i]);
						dataTable.Columns.Add(new DataColumn(orderDataSetColumnName, type));
					}
					dataTable.Columns.Add(new DataColumn("医嘱RowID", type));
					dataTable2 = dataSet.Tables.Add("ReportList");
					dataTable2.Columns.Add(new DataColumn("选择", type));
					int arg_131_0 = 0;
					int num2 = array2.Length - 1;
					for (int j = arg_131_0; j <= num2; j++)
					{
						string reportDataSetColumnName = LISDicForm.GetReportDataSetColumnName(array2[j]);
						dataTable2.Columns.Add(new DataColumn(reportDataSetColumnName, type));
					}
					dataTable2.Columns.Add(new DataColumn("医嘱RowID", type));
					string text = "";
					ELISDataListDataSet lISDATAListItems = WebServiceLayer.LISDataAccess.GetLISDATAListItems(Id, StDate, EdDate, StPage, EdPage, Falg);
					int arg_1AF_0 = 0;
					int num3 = lISDATAListItems.Tables[0].Rows.Count - 1;
					for (int k = arg_1AF_0; k <= num3; k++)
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow[0] = false;
						dataRow[dataTable.Columns.Count - 1] = RuntimeHelpers.GetObjectValue(lISDATAListItems.Tables[0].Rows[k][0]);
						int arg_20D_0 = 0;
						int num4 = array.Length - 1;
						for (int l = arg_20D_0; l <= num4; l++)
						{
							string orderDataSetColumnValue = LISDicForm.GetOrderDataSetColumnValue(array[l], lISDATAListItems.Tables[0].Rows[k]);
							dataRow[l + 1] = orderDataSetColumnValue;
						}
						dataTable.Rows.Add(dataRow);
						if (Operators.CompareString(text, "", false) == 0)
						{
							text = Conversions.ToString(lISDATAListItems.Tables[0].Rows[k][0]);
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text + "^", lISDATAListItems.Tables[0].Rows[k][0]));
						}
					}
					if (Operators.CompareString(text, "", false) != 0)
					{
						ELISReportByOeordIDDataSet reportByOeordID = WebServiceLayer.LISDataAccess.GetReportByOeordID(text);
						int arg_314_0 = 0;
						int num5 = reportByOeordID.Tables[0].Rows.Count - 1;
						for (int m = arg_314_0; m <= num5; m++)
						{
							DataRow dataRow2 = dataTable2.NewRow();
							dataRow2[0] = false;
							dataRow2[dataTable2.Columns.Count - 1] = RuntimeHelpers.GetObjectValue(reportByOeordID.Tables[0].Rows[m][6]);
							int arg_373_0 = 0;
							int num6 = array2.Length - 1;
							for (int n = arg_373_0; n <= num6; n++)
							{
								string reportDataSetColumnValue = LISDicForm.GetReportDataSetColumnValue(array2[n], reportByOeordID.Tables[0].Rows[m]);
								dataRow2[n + 1] = reportDataSetColumnValue;
							}
							dataTable2.Rows.Add(dataRow2);
						}
					}
					dataSet.Relations.Add("ItemList", dataTable.Columns["医嘱RowID"], dataTable2.Columns["医嘱RowID"]);
					this.BindResultSet(dataSet);
				}
				catch (Exception expr_40D)
				{
					ProjectData.SetProjectError(expr_40D);
					Exception ex = expr_40D;
					MessageBox.Show("获取检验数据错误！\r" + ex.Message + "\r" + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void nudPageRow_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurPageNum = 1;
		}

		private bool IsDateValid()
		{
			DateTime value = this.StDate.Value;
			DateTime value2 = this.EndDate.Value;
			if (value.CompareTo(value2) > 0)
			{
				MessageBox.Show("起始日期大于结束日期！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			if (value2.CompareTo(value.AddDays(31.0)) > 0)
			{
				MessageBox.Show("查询时间段超过一个月！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			return true;
		}

		private bool SetFlagHL(string flag)
		{
			return Operators.CompareString(flag.Trim(), "高", false) == 0 | Operators.CompareString(flag.Trim(), "低", false) == 0;
		}

		private void BindResultSet(DataSet curDataSet)
		{
			this.sprResult.get_Sheets().get_Item(0).set_DataSource(curDataSet);
			this.sprResult.get_Sheets().get_Item(0).set_DataMember("LISINFO");
			CheckBoxCellType checkBoxCellType = new CheckBoxCellType();
			checkBoxCellType.set_ThreeState(false);
			this.sprResult.get_Sheets().get_Item(0).SetColumnWidth(0, 40);
			this.sprResult.get_Sheets().get_Item(0).get_Columns().get_Item(0).set_CellType(checkBoxCellType);
			string sysOptionLISColumnScheme = LISDicForm.GetSysOptionLISColumnScheme();
			string[] array = sysOptionLISColumnScheme.Split(new char[]
			{
				'^'
			})[0].Split(new char[]
			{
				','
			});
			int arg_B6_0 = 0;
			checked
			{
				int num = array.Length - 1;
				for (int i = arg_B6_0; i <= num; i++)
				{
					int orderSheetColumnWidth = LISDicForm.GetOrderSheetColumnWidth(array[i]);
					this.sprResult.get_Sheets().get_Item(0).SetColumnWidth(i + 1, orderSheetColumnWidth);
				}
				int num2 = array.Length + 2;
				this.sprResult.get_Sheets().get_Item(0).get_Columns().get_Item(num2 - 1).set_Visible(false);
				this.sprResult.set_HorizontalScrollBarPolicy(0);
				this.sprResult.set_VerticalScrollBarPolicy(0);
			}
		}

		private void sprResult_ChildViewCreated(object sender, ChildViewCreatedEventArgs e)
		{
			e.get_SheetView().SetColumnWidth(0, 40);
			e.get_SheetView().get_Columns().get_Item(0).set_CellType(new CheckBoxCellType());
			string sysOptionLISColumnScheme = LISDicForm.GetSysOptionLISColumnScheme();
			string[] array = sysOptionLISColumnScheme.Split(new char[]
			{
				'^'
			})[1].Split(new char[]
			{
				','
			});
			int arg_65_0 = 0;
			checked
			{
				int num = array.Length - 1;
				for (int i = arg_65_0; i <= num; i++)
				{
					int reportSheetColumnWidth = LISDicForm.GetReportSheetColumnWidth(array[i]);
					e.get_SheetView().SetColumnWidth(i + 1, reportSheetColumnWidth);
				}
				int num2 = array.Length + 2;
				e.get_SheetView().get_Columns().get_Item(num2 - 1).set_Visible(false);
				if (Operators.CompareString(this.UnusualSelectSwich, "Y", false) == 0)
				{
					int arg_D6_0 = 0;
					int num3 = e.get_SheetView().get_Rows().get_Count() - 1;
					for (int j = arg_D6_0; j <= num3; j++)
					{
						bool flag = this.SetFlagHL(e.get_SheetView().get_Cells().get_Item(j, 1).get_Value().ToString());
						if (flag)
						{
							e.get_SheetView().get_Cells().get_Item(j, 0).set_Value(true);
							e.get_SheetView().get_Parent().get_Cells().get_Item(e.get_SheetView().get_ParentRowIndex(), 0).set_Value(true);
							e.get_SheetView().get_Rows().get_Item(j).set_BackColor(Color.Red);
						}
						else
						{
							e.get_SheetView().get_Cells().get_Item(j, 0).set_Value(false);
						}
					}
				}
				else
				{
					int arg_1B2_0 = 0;
					int num4 = e.get_SheetView().get_Rows().get_Count() - 1;
					for (int k = arg_1B2_0; k <= num4; k++)
					{
						bool flag2 = this.SetFlagHL(e.get_SheetView().get_Cells().get_Item(k, 1).get_Value().ToString());
						if (flag2)
						{
							e.get_SheetView().get_Rows().get_Item(k).set_BackColor(Color.Red);
						}
					}
				}
			}
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			checked
			{
				this.m_CurPageNum++;
				this.txtCurPage.Text = Conversions.ToString(this.m_CurPageNum);
				this.btnPrePage.Enabled = true;
				this.btnQuery_Click(RuntimeHelpers.GetObjectValue(sender), e);
				this.palTopList.Invalidate();
				if (decimal.Compare(new decimal(this.sprResult.get_Sheets().get_Item(0).get_RowCount()), this.nudPageRow.Value) < 0)
				{
					this.btnNextPage.Enabled = false;
				}
			}
		}

		private void btnPrePage_Click(object sender, EventArgs e)
		{
			checked
			{
				this.m_CurPageNum--;
				this.txtCurPage.Text = Conversions.ToString(this.m_CurPageNum);
				this.btnNextPage.Enabled = true;
				if (this.m_CurPageNum <= 1)
				{
					this.btnPrePage.Enabled = false;
				}
				this.btnQuery_Click(RuntimeHelpers.GetObjectValue(sender), e);
				this.palTopList.Invalidate();
			}
		}

		private void rbByDate_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbByDate.Checked)
			{
				this.PDate.Visible = true;
				this.RefreshState();
			}
			else
			{
				this.PDate.Visible = false;
			}
		}

		private void rbByOrder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbByOrder.Checked)
			{
				this.RefreshState();
				this.m_EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			}
		}

		private void rbAllOrder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbAllOrder.Checked)
			{
				this.RefreshState();
			}
		}

		private void dgBOLISData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string value = Conversions.ToString(this.dgBOLISData.CurrentCell.RowIndex);
			string text = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeID"].Value.ToString();
			string text2 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeDate"].Value.ToString();
			string text3 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["DeptDesc"].Value.ToString();
			string text4 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeType"].Value.ToString();
			this.m_EpisodeID = text;
			this.QueryDictionary(text, "", "", Conversions.ToString(1), Conversions.ToString(this.nudPageRow.Value), "1");
			this.rbAllOrder.Checked = false;
			this.rbByDate.Checked = false;
			this.rbByOrder.Checked = false;
			this.m_CurPageNum = 1;
			this.TctrlsResult.SelectedTab = this.tpResult;
		}

		private void RefreshState()
		{
			this.btnPrePage.Enabled = true;
			this.btnNextPage.Enabled = true;
			this.m_CurPageNum = 1;
			this.txtCurPage.Text = Conversions.ToString(this.m_CurPageNum);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.ChangeDictionaryText();
			this.DialogResult = DialogResult.OK;
		}

		private void ChangeDictionaryText()
		{
			Hashtable hashtable = new Hashtable();
			Hashtable hashtable2 = new Hashtable();
			Regex regex = new Regex("^\\d|^\\s*\\d+");
			string sysOptionValue = SysOptionManager.GetSysOptionValue("LISRefScheme", "##{ITEM}{RESULT}{UNIT}#{，|。|*}#");
			string[] array = sysOptionValue.Split(new char[]
			{
				'#'
			});
			string text = array[0];
			string arg = array[1].Replace("{", "").Replace("}", "").Replace("\\r\\n", "\r");
			string text2 = array[2];
			string text3 = array[3].Replace("{", "").Replace("}", "");
			string arg2 = text3.Split(new char[]
			{
				'|'
			})[0];
			string arg3 = text3.Split(new char[]
			{
				'|'
			})[1];
			string arg4 = text3.Split(new char[]
			{
				'|'
			})[2];
			string arg5 = array[4].Replace("{", "").Replace("}", "").Replace("\\r\\n", "\r");
			int arg_13F_0 = 0;
			checked
			{
				int num = this.sprResult.get_Sheets().get_Item(0).get_Rows().get_Count() - 1;
				for (int i = arg_13F_0; i <= num; i++)
				{
					string newValue = Conversions.ToString(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, 3).get_Value());
					string newValue2 = Conversions.ToString(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, 6).get_Value());
					string newValue3 = Conversions.ToString(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, 7).get_Value());
					string value = text.Replace("{DATE}", newValue2).Replace("{TIME}", newValue3).Replace("{ORDER}", newValue);
					ArrayList arrayList = new ArrayList();
					SheetView sheetView = this.sprResult.get_Sheets().get_Item(0).FindChildView(i, 0);
					if (sheetView != null && sheetView.get_Rows().get_Count() > 0)
					{
						hashtable.Add(i, value);
						int arg_24E_0 = 0;
						int num2 = sheetView.get_Rows().get_Count() - 1;
						for (int j = arg_24E_0; j <= num2; j++)
						{
							string left = Conversions.ToString(sheetView.get_Cells().get_Item(j, 0).get_Value());
							if (Operators.CompareString(left, "True", false) == 0)
							{
								string newValue4 = Conversions.ToString(sheetView.get_Cells().get_Item(j, 2).get_Value());
								string newValue5 = Conversions.ToString(sheetView.get_Cells().get_Item(j, 3).get_Value());
								string newValue6 = Conversions.ToString(sheetView.get_Cells().get_Item(j, 4).get_Value());
								string text4 = Conversions.ToString(sheetView.get_Cells().get_Item(j, 5).get_Value());
								string newValue7 = Conversions.ToString(sheetView.get_Cells().get_Item(j, 1).get_Value());
								if (!string.IsNullOrEmpty(text4) && regex.IsMatch(text4))
								{
									text4 = string.Format("{0}{1}", arg4, text4);
								}
								arrayList.Add(text2.Replace("{ITEM}", newValue4).Replace("{SYNO}", newValue5).Replace("{RESULT}", newValue6).Replace("{UNIT}", text4).Replace("{Flag}", newValue7));
							}
						}
						hashtable2.Add(i, arrayList);
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (hashtable.Count > 0)
				{
					bool flag = true;
					try
					{
						IEnumerator enumerator = hashtable.Keys.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							string arg6 = Conversions.ToString(hashtable[RuntimeHelpers.GetObjectValue(objectValue)]);
							StringBuilder stringBuilder2 = new StringBuilder();
							ArrayList arrayList2 = (ArrayList)hashtable2[RuntimeHelpers.GetObjectValue(objectValue)];
							if (arrayList2.Count > 0)
							{
								if (arrayList2.Count > 1)
								{
									int arg_43C_0 = 0;
									int num3 = arrayList2.Count - 1;
									for (int k = arg_43C_0; k <= num3; k++)
									{
										if (k == arrayList2.Count - 1)
										{
											stringBuilder2.Append(string.Format("{0}{1}", arrayList2[k].ToString(), arg3));
										}
										else
										{
											stringBuilder2.Append(string.Format("{0}{1}", arrayList2[k].ToString(), arg2));
										}
									}
								}
								else
								{
									stringBuilder2.Append(string.Format("{0}{1}", arrayList2[0].ToString(), arg3));
								}
								string text5 = string.Format("{0}{1}{2}", arg6, arg, stringBuilder2.ToString());
								if (!flag)
								{
									stringBuilder.Append(string.Format("{0}{1}", arg5, text5));
								}
								else
								{
									stringBuilder.Append(text5);
								}
								flag = false;
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
				this.m_DicValueCode = "";
				this.m_DicValue = stringBuilder.ToString();
			}
		}

		private void sprResult_ButtonClicked(object sender, EditorNotifyEventArgs e)
		{
			if (e.get_View().get_Parent() == null)
			{
				SheetView childView = this.sprResult.get_Sheets().get_Item(0).GetChildView(e.get_Row(), 0);
				if (Operators.ConditionalCompareObjectEqual(this.sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(e.get_Row(), e.get_Column()).get_Value(), true, false))
				{
					this.SetChildValue(childView, true);
				}
				else
				{
					this.SetChildValue(childView, false);
				}
				this.sprResult.get_ActiveSheet().SetChildVisible(childView, true);
			}
		}

		private void SetChildValue(SheetView ChildTable, bool BValue)
		{
			checked
			{
				if (ChildTable != null)
				{
					int arg_12_0 = 0;
					int num = ChildTable.get_Rows().get_Count() - 1;
					for (int i = arg_12_0; i <= num; i++)
					{
						ChildTable.get_Cells().get_Item(i, 0).set_Value(BValue);
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void LISDicForm_SizeChanged(object sender, EventArgs e)
		{
			this.palTopList.Height = checked(this.tpResult.Height - this.palBotBox.Height - 5);
		}

		private static string GetSysOptionLISRefScheme()
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("LISRefScheme", "##{ITEM}{RESULT}{UNIT}#{，|。|*}#");
			if (string.IsNullOrEmpty(sysOptionValue))
			{
				return "##{ITEM}{RESULT}{UNIT}#{，|。|*}#";
			}
			if (Operators.CompareString(sysOptionValue.ToUpper(), "NULL", false) == 0)
			{
				return "##{ITEM}{RESULT}{UNIT}#{，|。|*}#";
			}
			return sysOptionValue;
		}

		private static string GetSysOptionLISColumnScheme()
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("LISColumnScheme", "{EpisodeDate},{EpisodeSection},{ORDER},{LabEpisodeNo},{SpecimenDesc},{DATE},{TIME}^{Flag},{ITEM},{SYNO},{RESULT},{UNIT},{RANGE}");
			if (string.IsNullOrEmpty(sysOptionValue))
			{
				return "{EpisodeDate},{EpisodeSection},{ORDER},{LabEpisodeNo},{SpecimenDesc},{DATE},{TIME}^{Flag},{ITEM},{SYNO},{RESULT},{UNIT},{RANGE}";
			}
			if (Operators.CompareString(sysOptionValue.ToUpper(), "NULL", false) == 0)
			{
				return "{EpisodeDate},{EpisodeSection},{ORDER},{LabEpisodeNo},{SpecimenDesc},{DATE},{TIME}^{Flag},{ITEM},{SYNO},{RESULT},{UNIT},{RANGE}";
			}
			return sysOptionValue;
		}

		private static bool IsSysOptionConfigOK()
		{
			string sysOptionLISColumnScheme = LISDicForm.GetSysOptionLISColumnScheme();
			if (sysOptionLISColumnScheme.Split(new char[]
			{
				'^'
			}).Length != 2)
			{
				return false;
			}
			string text = sysOptionLISColumnScheme.Split(new char[]
			{
				'^'
			})[0];
			string text2 = sysOptionLISColumnScheme.Split(new char[]
			{
				'^'
			})[1];
			if (sysOptionLISColumnScheme.IndexOf("{OEOrdRowID}") > -1)
			{
				MessageManager.ShowErrorMessage("错误的配置列信息，请联系管理员！\\r\\n 错误列信息如下：{OEOrdRowID}为保留字，禁止在参数中配置");
				return false;
			}
			string[] array = text.Split(new char[]
			{
				','
			});
			int arg_96_0 = 0;
			checked
			{
				int num = array.Length - 1;
				for (int i = arg_96_0; i <= num; i++)
				{
					if (Operators.CompareString(LISDicForm.GetOrderDataSetColumnName(array[i]), "无效名称", false) == 0)
					{
						MessageManager.ShowErrorMessage("错误的配置列信息，请联系管理员！\\r\\n 错误列信息如下：" + array[i]);
						return false;
					}
				}
				string[] array2 = text2.Split(new char[]
				{
					','
				});
				if (Operators.CompareString(array2[0], "{Flag}", false) != 0)
				{
					MessageManager.ShowErrorMessage("错误的配置列信息，请联系管理员！\\r\\n 错误列信息如下：检验结果列必须以{Flag}开始！");
					return false;
				}
				int arg_10F_0 = 0;
				int num2 = array2.Length - 1;
				for (int j = arg_10F_0; j <= num2; j++)
				{
					if (Operators.CompareString(LISDicForm.GetReportDataSetColumnName(array2[j]), "无效名称", false) == 0)
					{
						MessageManager.ShowErrorMessage("错误的配置列信息，请联系管理员！\\r\\n 错误列信息如下：" + array2[j]);
						return false;
					}
				}
				string sysOptionLISRefScheme = LISDicForm.GetSysOptionLISRefScheme();
				string text3 = "{DATE},{TIME},{ORDER},{ITEM},{SYNO},{RESULT},{UNIT},{Flag}";
				string[] array3 = text3.Split(new char[]
				{
					','
				});
				int arg_179_0 = 0;
				int num3 = array3.Length - 1;
				for (int k = arg_179_0; k <= num3; k++)
				{
					if (sysOptionLISRefScheme.IndexOf(array3[k]) > -1 && sysOptionLISColumnScheme.IndexOf(array3[k]) == -1)
					{
						MessageManager.ShowErrorMessage("错误的配置列信息，请联系管理员！\\r\\n 错误列信息如下：" + array3[k] + "未包含在参数LISColumnScheme中！");
						return false;
					}
				}
				return true;
			}
		}

		private static string GetOrderDataSetColumnName(string columnCode)
		{
			if (Operators.CompareString(columnCode, "{OEOrdRowID}", false) == 0)
			{
				return "医嘱RowID";
			}
			if (Operators.CompareString(columnCode, "{ORDER}", false) == 0)
			{
				return "医嘱名称";
			}
			if (Operators.CompareString(columnCode, "{LabEpisodeNo}", false) == 0)
			{
				return "标本号";
			}
			if (Operators.CompareString(columnCode, "{SpecimenDesc}", false) == 0)
			{
				return "标本类型";
			}
			if (Operators.CompareString(columnCode, "{CollectDate}", false) == 0)
			{
				return "采集日期";
			}
			if (Operators.CompareString(columnCode, "{CollectTime}", false) == 0)
			{
				return "采集时间";
			}
			if (Operators.CompareString(columnCode, "{DATE}", false) == 0)
			{
				return "送检日期";
			}
			if (Operators.CompareString(columnCode, "{TIME}", false) == 0)
			{
				return "送检时间";
			}
			if (Operators.CompareString(columnCode, "{AuthDate}", false) == 0)
			{
				return "审核日期";
			}
			if (Operators.CompareString(columnCode, "{AuthTime}", false) == 0)
			{
				return "审核时间";
			}
			if (Operators.CompareString(columnCode, "{ExistReport}", false) == 0)
			{
				return "返回报告";
			}
			if (Operators.CompareString(columnCode, "{EpisodeDate}", false) == 0)
			{
				return "就诊日期";
			}
			if (Operators.CompareString(columnCode, "{EpisodeSection}", false) == 0)
			{
				return "就诊科室";
			}
			return "无效名称";
		}

		private static string GetOrderDataSetColumnValue(string columnCode, DataRow tableDataRow)
		{
			int columnIndex;
			if (Operators.CompareString(columnCode, "{OEOrdRowID}", false) == 0)
			{
				columnIndex = 0;
			}
			else if (Operators.CompareString(columnCode, "{ORDER}", false) == 0)
			{
				columnIndex = 1;
			}
			else if (Operators.CompareString(columnCode, "{LabEpisodeNo}", false) == 0)
			{
				columnIndex = 2;
			}
			else if (Operators.CompareString(columnCode, "{SpecimenDesc}", false) == 0)
			{
				columnIndex = 3;
			}
			else if (Operators.CompareString(columnCode, "{CollectDate}", false) == 0)
			{
				columnIndex = 4;
			}
			else if (Operators.CompareString(columnCode, "{CollectTime}", false) == 0)
			{
				columnIndex = 5;
			}
			else if (Operators.CompareString(columnCode, "{DATE}", false) == 0)
			{
				columnIndex = 6;
			}
			else if (Operators.CompareString(columnCode, "{TIME}", false) == 0)
			{
				columnIndex = 7;
			}
			else if (Operators.CompareString(columnCode, "{AuthDate}", false) == 0)
			{
				columnIndex = 8;
			}
			else if (Operators.CompareString(columnCode, "{AuthTime}", false) == 0)
			{
				columnIndex = 9;
			}
			else if (Operators.CompareString(columnCode, "{ExistReport}", false) == 0)
			{
				columnIndex = 10;
			}
			else if (Operators.CompareString(columnCode, "{EpisodeDate}", false) == 0)
			{
				columnIndex = 11;
			}
			else if (Operators.CompareString(columnCode, "{EpisodeSection}", false) == 0)
			{
				columnIndex = 12;
			}
			else
			{
				columnIndex = 0;
			}
			if (tableDataRow[columnIndex].GetType() == typeof(DBNull))
			{
				return string.Empty;
			}
			return Conversions.ToString(tableDataRow[columnIndex]);
		}

		private static int GetOrderSheetColumnWidth(string columnCode)
		{
			if (Operators.CompareString(columnCode, "{OEOrdRowID}", false) == 0)
			{
				return 50;
			}
			if (Operators.CompareString(columnCode, "{ORDER}", false) == 0)
			{
				return 250;
			}
			if (Operators.CompareString(columnCode, "{LabEpisodeNo}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{SpecimenDesc}", false) == 0)
			{
				return 60;
			}
			if (Operators.CompareString(columnCode, "{CollectDate}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{CollectTime}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{DATE}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{TIME}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{AuthDate}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{AuthTime}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{ExistReport}", false) == 0)
			{
				return 30;
			}
			if (Operators.CompareString(columnCode, "{EpisodeDate}", false) == 0)
			{
				return 80;
			}
			if (Operators.CompareString(columnCode, "{EpisodeSection}", false) == 0)
			{
				return 90;
			}
			return 50;
		}

		private static string GetReportDataSetColumnName(string columnCode)
		{
			if (Operators.CompareString(columnCode, "{ITEM}", false) == 0)
			{
				return "描述";
			}
			if (Operators.CompareString(columnCode, "{SYNO}", false) == 0)
			{
				return "缩写";
			}
			if (Operators.CompareString(columnCode, "{RESULT}", false) == 0)
			{
				return "结果";
			}
			if (Operators.CompareString(columnCode, "{UNIT}", false) == 0)
			{
				return "单位";
			}
			if (Operators.CompareString(columnCode, "{Flag}", false) == 0)
			{
				return "异常提示";
			}
			if (Operators.CompareString(columnCode, "{RANGE}", false) == 0)
			{
				return "范围值";
			}
			return "无效名称";
		}

		private static string GetReportDataSetColumnValue(string columnCode, DataRow tableDataRow)
		{
			int columnIndex;
			if (Operators.CompareString(columnCode, "{ITEM}", false) == 0)
			{
				columnIndex = 0;
			}
			else if (Operators.CompareString(columnCode, "{SYNO}", false) == 0)
			{
				columnIndex = 1;
			}
			else if (Operators.CompareString(columnCode, "{RESULT}", false) == 0)
			{
				columnIndex = 2;
			}
			else if (Operators.CompareString(columnCode, "{UNIT}", false) == 0)
			{
				columnIndex = 3;
			}
			else if (Operators.CompareString(columnCode, "{Flag}", false) == 0)
			{
				columnIndex = 4;
			}
			else if (Operators.CompareString(columnCode, "{RANGE}", false) == 0)
			{
				columnIndex = 5;
			}
			else
			{
				columnIndex = 0;
			}
			return tableDataRow[columnIndex].ToString().Replace("$c(13,10)_", "\r");
		}

		private static int GetReportSheetColumnWidth(string columnCode)
		{
			if (Operators.CompareString(columnCode, "{ITEM}", false) == 0)
			{
				return 60;
			}
			if (Operators.CompareString(columnCode, "{SYNO}", false) == 0)
			{
				return 50;
			}
			if (Operators.CompareString(columnCode, "{RESULT}", false) == 0)
			{
				return 50;
			}
			if (Operators.CompareString(columnCode, "{UNIT}", false) == 0)
			{
				return 50;
			}
			if (Operators.CompareString(columnCode, "{Flag}", false) == 0)
			{
				return 100;
			}
			if (Operators.CompareString(columnCode, "{RANGE}", false) == 0)
			{
				return 100;
			}
			return 50;
		}
	}
}
