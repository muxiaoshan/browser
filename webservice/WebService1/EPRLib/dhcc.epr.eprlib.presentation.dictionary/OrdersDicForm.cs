using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using Microsoft.VisualBasic.CompilerServices;
using OrderData;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class OrdersDicForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("tcOrdersQuote")]
		private TabControl _tcOrdersQuote;

		[AccessedThroughProperty("tpOrders")]
		private TabPage _tpOrders;

		[AccessedThroughProperty("tpEpsoidList")]
		private TabPage _tpEpsoidList;

		[AccessedThroughProperty("dgBOLISData")]
		private DataGridView _dgBOLISData;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("btCancel")]
		private Button _btCancel;

		[AccessedThroughProperty("btSure")]
		private Button _btSure;

		[AccessedThroughProperty("gbEpsoide")]
		private GroupBox _gbEpsoide;

		[AccessedThroughProperty("palPreEpsoide")]
		private Panel _palPreEpsoide;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("lbDpart")]
		private Label _lbDpart;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("lbDate")]
		private Label _lbDate;

		[AccessedThroughProperty("lbType")]
		private Label _lbType;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		private string m_EpisodeID;

		private string m_DicValue;

		private string m_DicValueCode;

		[AccessedThroughProperty("tcOrders")]
		private TabControl _tcOrders;

		[AccessedThroughProperty("tpLongOrder")]
		private TabPage _tpLongOrder;

		[AccessedThroughProperty("FpSpreadLong")]
		private FpSpread _FpSpreadLong;

		[AccessedThroughProperty("FpSpreadLong_Sheet1")]
		private SheetView _FpSpreadLong_Sheet1;

		[AccessedThroughProperty("tpTempOrder")]
		private TabPage _tpTempOrder;

		[AccessedThroughProperty("FpSpreadTemp")]
		private FpSpread _FpSpreadTemp;

		[AccessedThroughProperty("FpSpreadTemp_Sheet1")]
		private SheetView _FpSpreadTemp_Sheet1;

		internal virtual TabControl tcOrdersQuote
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcOrdersQuote;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tcOrdersQuote = value;
			}
		}

		internal virtual TabPage tpOrders
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpOrders;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpOrders = value;
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

		internal virtual Button btCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btCancel_Click);
				if (this._btCancel != null)
				{
					this._btCancel.Click -= value2;
				}
				this._btCancel = value;
				if (this._btCancel != null)
				{
					this._btCancel.Click += value2;
				}
			}
		}

		internal virtual Button btSure
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btSure;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btSure_Click);
				if (this._btSure != null)
				{
					this._btSure.Click -= value2;
				}
				this._btSure = value;
				if (this._btSure != null)
				{
					this._btSure.Click += value2;
				}
			}
		}

		internal virtual GroupBox gbEpsoide
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbEpsoide;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbEpsoide = value;
			}
		}

		internal virtual Panel palPreEpsoide
		{
			[DebuggerNonUserCode]
			get
			{
				return this._palPreEpsoide;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._palPreEpsoide = value;
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

		internal virtual Label lbDpart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbDpart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbDpart = value;
			}
		}

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual Label lbDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbDate = value;
			}
		}

		internal virtual Label lbType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbType = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
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

		internal virtual TabControl tcOrders
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcOrders;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tcOrders = value;
			}
		}

		internal virtual TabPage tpLongOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpLongOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpLongOrder = value;
			}
		}

		internal virtual FpSpread FpSpreadLong
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FpSpreadLong;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FpSpreadLong = value;
			}
		}

		internal virtual SheetView FpSpreadLong_Sheet1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FpSpreadLong_Sheet1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FpSpreadLong_Sheet1 = value;
			}
		}

		internal virtual TabPage tpTempOrder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpTempOrder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpTempOrder = value;
			}
		}

		internal virtual FpSpread FpSpreadTemp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FpSpreadTemp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FpSpreadTemp = value;
			}
		}

		internal virtual SheetView FpSpreadTemp_Sheet1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FpSpreadTemp_Sheet1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FpSpreadTemp_Sheet1 = value;
			}
		}

		public OrdersDicForm()
		{
			base.Load += new EventHandler(this.OrdersDictionary_Load);
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

		private void InitializeComponent()
		{
			this.tcOrdersQuote = new TabControl();
			this.tpOrders = new TabPage();
			this.gbEpsoide = new GroupBox();
			this.palPreEpsoide = new Panel();
			this.Label7 = new Label();
			this.lbDpart = new Label();
			this.Label8 = new Label();
			this.lbDate = new Label();
			this.lbType = new Label();
			this.Label5 = new Label();
			this.Label3 = new Label();
			this.Panel1 = new Panel();
			this.btCancel = new Button();
			this.btSure = new Button();
			this.tcOrders = new TabControl();
			this.tpLongOrder = new TabPage();
			this.FpSpreadLong = new FpSpread();
			this.FpSpreadLong_Sheet1 = new SheetView();
			this.tpTempOrder = new TabPage();
			this.FpSpreadTemp = new FpSpread();
			this.FpSpreadTemp_Sheet1 = new SheetView();
			this.tpEpsoidList = new TabPage();
			this.dgBOLISData = new DataGridView();
			this.tcOrdersQuote.SuspendLayout();
			this.tpOrders.SuspendLayout();
			this.gbEpsoide.SuspendLayout();
			this.palPreEpsoide.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.tcOrders.SuspendLayout();
			this.tpLongOrder.SuspendLayout();
			this.FpSpreadLong.BeginInit();
			this.FpSpreadLong_Sheet1.BeginInit();
			this.tpTempOrder.SuspendLayout();
			this.FpSpreadTemp.BeginInit();
			this.FpSpreadTemp_Sheet1.BeginInit();
			this.tpEpsoidList.SuspendLayout();
			((ISupportInitialize)this.dgBOLISData).BeginInit();
			this.SuspendLayout();
			this.tcOrdersQuote.Controls.Add(this.tpOrders);
			this.tcOrdersQuote.Controls.Add(this.tpEpsoidList);
			this.tcOrdersQuote.Dock = DockStyle.Fill;
			Control arg_1E5_0 = this.tcOrdersQuote;
			Point location = new Point(0, 0);
			arg_1E5_0.Location = location;
			this.tcOrdersQuote.Name = "tcOrdersQuote";
			this.tcOrdersQuote.SelectedIndex = 0;
			Control arg_21E_0 = this.tcOrdersQuote;
			Size size = new Size(892, 666);
			arg_21E_0.Size = size;
			this.tcOrdersQuote.TabIndex = 0;
			this.tpOrders.BackColor = SystemColors.InactiveCaptionText;
			this.tpOrders.Controls.Add(this.gbEpsoide);
			this.tpOrders.Controls.Add(this.Panel1);
			this.tpOrders.Controls.Add(this.tcOrders);
			TabPage arg_292_0 = this.tpOrders;
			location = new Point(4, 21);
			arg_292_0.Location = location;
			this.tpOrders.Name = "tpOrders";
			Control arg_2B6_0 = this.tpOrders;
			Padding padding = new Padding(3);
			arg_2B6_0.Padding = padding;
			Control arg_2D3_0 = this.tpOrders;
			size = new Size(884, 641);
			arg_2D3_0.Size = size;
			this.tpOrders.TabIndex = 0;
			this.tpOrders.Text = "医嘱信息";
			this.gbEpsoide.BackColor = SystemColors.InactiveCaptionText;
			this.gbEpsoide.Controls.Add(this.palPreEpsoide);
			this.gbEpsoide.Controls.Add(this.lbDpart);
			this.gbEpsoide.Controls.Add(this.Label8);
			this.gbEpsoide.Controls.Add(this.lbDate);
			this.gbEpsoide.Controls.Add(this.lbType);
			this.gbEpsoide.Controls.Add(this.Label5);
			this.gbEpsoide.Controls.Add(this.Label3);
			this.gbEpsoide.Dock = DockStyle.Top;
			Control arg_3BA_0 = this.gbEpsoide;
			location = new Point(3, 3);
			arg_3BA_0.Location = location;
			this.gbEpsoide.Name = "gbEpsoide";
			Control arg_3E4_0 = this.gbEpsoide;
			size = new Size(878, 34);
			arg_3E4_0.Size = size;
			this.gbEpsoide.TabIndex = 30;
			this.gbEpsoide.TabStop = false;
			this.gbEpsoide.Text = "就诊信息";
			this.palPreEpsoide.Controls.Add(this.Label7);
			Control arg_43A_0 = this.palPreEpsoide;
			location = new Point(65, 10);
			arg_43A_0.Location = location;
			this.palPreEpsoide.Name = "palPreEpsoide";
			Control arg_464_0 = this.palPreEpsoide;
			size = new Size(576, 20);
			arg_464_0.Size = size;
			this.palPreEpsoide.TabIndex = 7;
			this.Label7.AutoSize = true;
			this.Label7.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_4B3_0 = this.Label7;
			location = new Point(13, 5);
			arg_4B3_0.Location = location;
			this.Label7.Name = "Label7";
			Control arg_4DA_0 = this.Label7;
			size = new Size(109, 12);
			arg_4DA_0.Size = size;
			this.Label7.TabIndex = 0;
			this.Label7.Text = "本次就诊检查信息";
			this.lbDpart.AutoSize = true;
			this.lbDpart.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_53D_0 = this.lbDpart;
			location = new Point(576, 14);
			arg_53D_0.Location = location;
			this.lbDpart.Name = "lbDpart";
			Control arg_563_0 = this.lbDpart;
			size = new Size(0, 12);
			arg_563_0.Size = size;
			this.lbDpart.TabIndex = 6;
			this.Label8.AutoSize = true;
			this.Label8.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_5B6_0 = this.Label8;
			location = new Point(505, 14);
			arg_5B6_0.Location = location;
			this.Label8.Name = "Label8";
			Control arg_5DD_0 = this.Label8;
			size = new Size(70, 12);
			arg_5DD_0.Size = size;
			this.Label8.TabIndex = 5;
			this.Label8.Text = "就诊科室：";
			this.lbDate.AutoSize = true;
			this.lbDate.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_640_0 = this.lbDate;
			location = new Point(134, 14);
			arg_640_0.Location = location;
			this.lbDate.Name = "lbDate";
			Control arg_666_0 = this.lbDate;
			size = new Size(0, 12);
			arg_666_0.Size = size;
			this.lbDate.TabIndex = 4;
			this.lbType.AutoSize = true;
			this.lbType.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_6B9_0 = this.lbType;
			location = new Point(412, 14);
			arg_6B9_0.Location = location;
			this.lbType.Name = "lbType";
			Control arg_6DF_0 = this.lbType;
			size = new Size(0, 12);
			arg_6DF_0.Size = size;
			this.lbType.TabIndex = 3;
			this.Label5.AutoSize = true;
			this.Label5.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_732_0 = this.Label5;
			location = new Point(341, 14);
			arg_732_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_759_0 = this.Label5;
			size = new Size(70, 12);
			arg_759_0.Size = size;
			this.Label5.TabIndex = 2;
			this.Label5.Text = "就诊类型：";
			this.Label3.AutoSize = true;
			this.Label3.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_7B9_0 = this.Label3;
			location = new Point(63, 14);
			arg_7B9_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_7E0_0 = this.Label3;
			size = new Size(70, 12);
			arg_7E0_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "就诊日期：";
			this.Panel1.BackColor = SystemColors.InactiveCaptionText;
			this.Panel1.Controls.Add(this.btCancel);
			this.Panel1.Controls.Add(this.btSure);
			this.Panel1.Dock = DockStyle.Bottom;
			Control arg_85D_0 = this.Panel1;
			location = new Point(3, 600);
			arg_85D_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_887_0 = this.Panel1;
			size = new Size(878, 38);
			arg_887_0.Size = size;
			this.Panel1.TabIndex = 29;
			this.btCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btCancel.BackColor = Color.FromArgb(9, 101, 156);
			this.btCancel.FlatStyle = FlatStyle.Flat;
			this.btCancel.ForeColor = SystemColors.ControlLightLight;
			Control arg_8EF_0 = this.btCancel;
			location = new Point(761, 7);
			arg_8EF_0.Location = location;
			this.btCancel.Name = "btCancel";
			Control arg_916_0 = this.btCancel;
			size = new Size(75, 23);
			arg_916_0.Size = size;
			this.btCancel.TabIndex = 1;
			this.btCancel.Text = "取消";
			this.btCancel.UseVisualStyleBackColor = false;
			this.btSure.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btSure.BackColor = Color.FromArgb(9, 101, 156);
			this.btSure.FlatStyle = FlatStyle.Flat;
			this.btSure.ForeColor = SystemColors.ControlLightLight;
			Control arg_999_0 = this.btSure;
			location = new Point(668, 7);
			arg_999_0.Location = location;
			this.btSure.Name = "btSure";
			Control arg_9C0_0 = this.btSure;
			size = new Size(75, 23);
			arg_9C0_0.Size = size;
			this.btSure.TabIndex = 0;
			this.btSure.Text = "确定";
			this.btSure.UseVisualStyleBackColor = false;
			this.tcOrders.Alignment = TabAlignment.Bottom;
			this.tcOrders.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tcOrders.Controls.Add(this.tpLongOrder);
			this.tcOrders.Controls.Add(this.tpTempOrder);
			Control arg_A43_0 = this.tcOrders;
			location = new Point(0, 39);
			arg_A43_0.Location = location;
			Control arg_A5A_0 = this.tcOrders;
			padding = new Padding(0, 3, 0, 3);
			arg_A5A_0.Margin = padding;
			this.tcOrders.Multiline = true;
			this.tcOrders.Name = "tcOrders";
			this.tcOrders.SelectedIndex = 0;
			Control arg_A9F_0 = this.tcOrders;
			size = new Size(881, 555);
			arg_A9F_0.Size = size;
			this.tcOrders.TabIndex = 0;
			this.tpLongOrder.BackColor = SystemColors.InactiveCaptionText;
			this.tpLongOrder.Controls.Add(this.FpSpreadLong);
			TabPage arg_AE6_0 = this.tpLongOrder;
			location = new Point(4, 4);
			arg_AE6_0.Location = location;
			Control arg_AFD_0 = this.tpLongOrder;
			padding = new Padding(0, 3, 0, 3);
			arg_AFD_0.Margin = padding;
			this.tpLongOrder.Name = "tpLongOrder";
			Control arg_B21_0 = this.tpLongOrder;
			padding = new Padding(3);
			arg_B21_0.Padding = padding;
			Control arg_B3E_0 = this.tpLongOrder;
			size = new Size(873, 530);
			arg_B3E_0.Size = size;
			this.tpLongOrder.TabIndex = 0;
			this.tpLongOrder.Text = "长期医嘱";
			this.FpSpreadLong.AccessibleDescription = "FpSpreadLong, Sheet1";
			this.FpSpreadLong.BackColor = SystemColors.Control;
			this.FpSpreadLong.set_BorderStyle(BorderStyle.FixedSingle);
			this.FpSpreadLong.Dock = DockStyle.Fill;
			this.FpSpreadLong.set_HorizontalScrollBarPolicy(0);
			Control arg_BB3_0 = this.FpSpreadLong;
			location = new Point(3, 3);
			arg_BB3_0.Location = location;
			Control arg_BCA_0 = this.FpSpreadLong;
			padding = new Padding(0, 3, 0, 3);
			arg_BCA_0.Margin = padding;
			this.FpSpreadLong.set_Name("FpSpreadLong");
			this.FpSpreadLong.get_Sheets().AddRange(new SheetView[]
			{
				this.FpSpreadLong_Sheet1
			});
			Control arg_C18_0 = this.FpSpreadLong;
			size = new Size(867, 524);
			arg_C18_0.Size = size;
			this.FpSpreadLong.TabIndex = 27;
			this.FpSpreadLong.set_VerticalScrollBarPolicy(0);
			this.FpSpreadLong.SetActiveViewport(0, 1, 1);
			this.FpSpreadLong_Sheet1.Reset();
			this.FpSpreadLong_Sheet1.set_SheetName("Sheet1");
			this.FpSpreadLong_Sheet1.set_ReferenceStyle(1);
			this.FpSpreadLong_Sheet1.set_ColumnCount(0);
			this.FpSpreadLong_Sheet1.set_RowCount(0);
			this.FpSpreadLong_Sheet1.get_RowHeader().get_Columns().get_Default().set_Resizable(false);
			this.FpSpreadLong_Sheet1.set_ReferenceStyle(0);
			this.tpTempOrder.Controls.Add(this.FpSpreadTemp);
			TabPage arg_CD0_0 = this.tpTempOrder;
			location = new Point(4, 4);
			arg_CD0_0.Location = location;
			Control arg_CE7_0 = this.tpTempOrder;
			padding = new Padding(0, 3, 0, 3);
			arg_CE7_0.Margin = padding;
			this.tpTempOrder.Name = "tpTempOrder";
			Control arg_D0B_0 = this.tpTempOrder;
			padding = new Padding(3);
			arg_D0B_0.Padding = padding;
			Control arg_D28_0 = this.tpTempOrder;
			size = new Size(873, 530);
			arg_D28_0.Size = size;
			this.tpTempOrder.TabIndex = 1;
			this.tpTempOrder.Text = "临时医嘱";
			this.tpTempOrder.UseVisualStyleBackColor = true;
			this.FpSpreadTemp.AccessibleDescription = "FpSpreadTemp, Sheet1";
			this.FpSpreadTemp.BackColor = SystemColors.Control;
			this.FpSpreadTemp.set_BorderStyle(BorderStyle.FixedSingle);
			this.FpSpreadTemp.Dock = DockStyle.Fill;
			this.FpSpreadTemp.set_HorizontalScrollBarPolicy(0);
			Control arg_DA9_0 = this.FpSpreadTemp;
			location = new Point(3, 3);
			arg_DA9_0.Location = location;
			Control arg_DC0_0 = this.FpSpreadTemp;
			padding = new Padding(0, 3, 0, 3);
			arg_DC0_0.Margin = padding;
			this.FpSpreadTemp.set_Name("FpSpreadTemp");
			this.FpSpreadTemp.get_Sheets().AddRange(new SheetView[]
			{
				this.FpSpreadTemp_Sheet1
			});
			Control arg_E0E_0 = this.FpSpreadTemp;
			size = new Size(867, 524);
			arg_E0E_0.Size = size;
			this.FpSpreadTemp.TabIndex = 27;
			this.FpSpreadTemp.set_VerticalScrollBarPolicy(0);
			this.FpSpreadTemp.SetActiveViewport(0, 1, 1);
			this.FpSpreadTemp_Sheet1.Reset();
			this.FpSpreadTemp_Sheet1.set_SheetName("Sheet1");
			this.FpSpreadTemp_Sheet1.set_ReferenceStyle(1);
			this.FpSpreadTemp_Sheet1.set_ColumnCount(0);
			this.FpSpreadTemp_Sheet1.set_RowCount(0);
			this.FpSpreadTemp_Sheet1.get_RowHeader().get_Columns().get_Default().set_Resizable(false);
			this.FpSpreadTemp_Sheet1.set_ReferenceStyle(0);
			this.tpEpsoidList.BackColor = SystemColors.InactiveCaptionText;
			this.tpEpsoidList.Controls.Add(this.dgBOLISData);
			TabPage arg_ED7_0 = this.tpEpsoidList;
			location = new Point(4, 21);
			arg_ED7_0.Location = location;
			this.tpEpsoidList.Name = "tpEpsoidList";
			Control arg_EFB_0 = this.tpEpsoidList;
			padding = new Padding(3);
			arg_EFB_0.Padding = padding;
			Control arg_F18_0 = this.tpEpsoidList;
			size = new Size(884, 641);
			arg_F18_0.Size = size;
			this.tpEpsoidList.TabIndex = 1;
			this.tpEpsoidList.Text = "就诊列表";
			this.dgBOLISData.AllowUserToAddRows = false;
			this.dgBOLISData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgBOLISData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBOLISData.Dock = DockStyle.Fill;
			Control arg_F7A_0 = this.dgBOLISData;
			location = new Point(3, 3);
			arg_F7A_0.Location = location;
			this.dgBOLISData.Name = "dgBOLISData";
			this.dgBOLISData.ReadOnly = true;
			this.dgBOLISData.RowTemplate.Height = 23;
			this.dgBOLISData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Control arg_FD1_0 = this.dgBOLISData;
			size = new Size(878, 635);
			arg_FD1_0.Size = size;
			this.dgBOLISData.TabIndex = 3;
			size = new Size(892, 666);
			this.ClientSize = size;
			this.Controls.Add(this.tcOrdersQuote);
			this.Name = "OrdersDicForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "引用医嘱信息";
			this.tcOrdersQuote.ResumeLayout(false);
			this.tpOrders.ResumeLayout(false);
			this.gbEpsoide.ResumeLayout(false);
			this.gbEpsoide.PerformLayout();
			this.palPreEpsoide.ResumeLayout(false);
			this.palPreEpsoide.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.tcOrders.ResumeLayout(false);
			this.tpLongOrder.ResumeLayout(false);
			this.FpSpreadLong.EndInit();
			this.FpSpreadLong_Sheet1.EndInit();
			this.tpTempOrder.ResumeLayout(false);
			this.FpSpreadTemp.EndInit();
			this.FpSpreadTemp_Sheet1.EndInit();
			this.tpEpsoidList.ResumeLayout(false);
			((ISupportInitialize)this.dgBOLISData).EndInit();
			this.ResumeLayout(false);
		}

		private void OrdersDictionary_Load(object sender, EventArgs e)
		{
			this.m_EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			this.QueryEpisodeList();
			this.QueryByEpisodeId();
		}

		private void QueryEpisodeList()
		{
			string valueByKey = GlobalValues.GetValueByKey("PatientID");
			CommonQuoteClass commonQuoteClass = new CommonQuoteClass();
			commonQuoteClass.QueryEpsoideList(this.dgBOLISData, valueByKey);
		}

		private void QueryByEpisodeId()
		{
			OrderListByDataSet orderListByDataSet = WebServiceLayer.OrderDataAccess.SelectOrderList(this.m_EpisodeID, string.Empty, string.Empty, string.Empty, string.Empty, "on", string.Empty, string.Empty);
			DataSet dataSet = orderListByDataSet;
			DataSet arg_47_0 = this.SetDataSet(ref dataSet);
			orderListByDataSet = (OrderListByDataSet)dataSet;
			DataSet dataSet2 = arg_47_0;
			DataSet arg_54_1 = dataSet2;
			FpSpread fpSpread = this.FpSpreadLong;
			this.BindOrdersResultSet(arg_54_1, ref fpSpread);
			this.FpSpreadLong = fpSpread;
			OrderListByDataSet orderListByDataSet2 = WebServiceLayer.OrderDataAccess.SelectOrderList(this.m_EpisodeID, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "on", string.Empty);
			dataSet = orderListByDataSet2;
			DataSet arg_A8_0 = this.SetDataSet(ref dataSet);
			orderListByDataSet2 = (OrderListByDataSet)dataSet;
			DataSet dataSet3 = arg_A8_0;
			DataSet arg_B5_1 = dataSet3;
			fpSpread = this.FpSpreadTemp;
			this.BindOrdersResultSet(arg_B5_1, ref fpSpread);
			this.FpSpreadTemp = fpSpread;
		}

		private DataSet SetDataSet(ref DataSet dsItemList)
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable();
			Type type = Type.GetType("System.String");
			dataTable = dataSet.Tables.Add("ItemList");
			checked
			{
				try
				{
					string sysOptionValue = SysOptionManager.GetSysOptionValue("OrderColumnsScheme", "OrdCreateDate:下医嘱日期,ArcimDesc:医嘱名称,DoseQty:剂量,Instr:服用方法,PHFreq:频率");
					string[] array = sysOptionValue.Split(new char[]
					{
						','
					});
					dataTable.Columns.Add("选择");
					int arg_6C_0 = 0;
					int num = array.Length - 1;
					for (int i = arg_6C_0; i <= num; i++)
					{
						dataTable.Columns.Add(array[i].Split(new char[]
						{
							':'
						})[1]);
					}
					int arg_C0_0 = 0;
					int num2 = dsItemList.Tables[0].Rows.Count - 1;
					for (int j = arg_C0_0; j <= num2; j++)
					{
						DataRow dataRow = dataTable.NewRow();
						int arg_D8_0 = 0;
						int num3 = array.Length - 1;
						for (int k = arg_D8_0; k <= num3; k++)
						{
							dataRow[array[k].Split(new char[]
							{
								':'
							})[1]] = dsItemList.Tables[0].Rows[j][array[k].Split(new char[]
							{
								':'
							})[0]].ToString();
						}
						dataTable.Rows.Add(dataRow);
					}
				}
				catch (Exception expr_168)
				{
					ProjectData.SetProjectError(expr_168);
					MessageManager.ShowInformationMessage("参数是否有效");
					ProjectData.ClearProjectError();
				}
				return dataSet;
			}
		}

		private void BindOrdersResultSet(DataSet curDataSet, ref FpSpread sprResult)
		{
			CheckBoxCellType checkBoxCellType = new CheckBoxCellType();
			checkBoxCellType.set_ThreeState(false);
			SheetView sheetView = sprResult.get_Sheets().get_Item(0);
			sheetView.set_DataSource(curDataSet);
			sheetView.set_DataMember("OrderList");
			sheetView.get_Columns().get_Item(0).set_CellType(checkBoxCellType);
			sheetView.SetColumnWidth(0, 40);
			int arg_65_0 = 1;
			checked
			{
				int num = sprResult.get_Sheets().get_Item(0).get_Columns().get_Count() - 1;
				for (int i = arg_65_0; i <= num; i++)
				{
					sprResult.get_Sheets().get_Item(0).SetColumnAllowAutoSort(i, true);
				}
				sprResult.set_HorizontalScrollBarPolicy(0);
				sprResult.set_VerticalScrollBarPolicy(0);
			}
		}

		private void btSure_Click(object sender, EventArgs e)
		{
			FpSpread fpSpread = this.FpSpreadLong;
			string text = "长期医嘱";
			string arg_1E_0 = this.ChangeDictionaryText(ref fpSpread, ref text);
			this.FpSpreadLong = fpSpread;
			string str = arg_1E_0;
			fpSpread = this.FpSpreadTemp;
			text = "临时医嘱";
			string arg_3D_0 = this.ChangeDictionaryText(ref fpSpread, ref text);
			this.FpSpreadTemp = fpSpread;
			string str2 = arg_3D_0;
			this.m_DicValueCode = "";
			this.m_DicValue = str + "\r" + str2;
			this.DialogResult = DialogResult.OK;
		}

		private string ChangeDictionaryText(ref FpSpread sprResult, ref string sprType)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				try
				{
					string[] array = SysOptionManager.GetSysOptionValue("OrderColumnsScheme", "OrdCreateDate:下医嘱日期,ArcimDesc:医嘱名称,DoseQty:剂量,Instr:服用方法,PHFreq:频率").Split(new char[]
					{
						','
					});
					string sysOptionValue = SysOptionManager.GetSysOptionValue("OrderStyleScheme", "");
					string[] array2 = sysOptionValue.Split(new char[]
					{
						'|'
					});
					string value = string.Empty;
					string[] array3 = array2[0].Split(new char[]
					{
						'%'
					});
					string[] array4 = array2[1].Split(new char[]
					{
						'^'
					});
					string[] array5 = array2[2].Split(new char[]
					{
						'^'
					});
					if (array3.Length > 0 && array4.Length > 0 && array5.Length > 0)
					{
						if (array3[1].Length > 0)
						{
							value = array3[0] + sprType + array5[0].Replace("\\r\\n", "\r");
						}
						stringBuilder.Append(value);
						int arg_11B_0 = 0;
						int num = sprResult.get_Sheets().get_Item(0).get_Rows().get_Count() - 1;
						for (int i = arg_11B_0; i <= num; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, 0).get_Value(), "True", false))
							{
								int arg_159_0 = 0;
								int num2 = array4.Length - 1;
								for (int j = arg_159_0; j <= num2; j++)
								{
									string[] array6 = array4[j].Split(new char[]
									{
										'%'
									});
									int arg_183_0 = 0;
									int num3 = array.Length - 1;
									for (int k = arg_183_0; k <= num3; k++)
									{
										if (Operators.CompareString(array6[1], array[k].Split(new char[]
										{
											':'
										})[1], false) == 0)
										{
											stringBuilder.Append(array6[0]);
											stringBuilder.Append(sprResult.get_Sheets().get_Item(0).get_Cells().get_Item(i, k + 1).get_Text());
										}
									}
								}
								stringBuilder.Append(array5[1].Replace("\\r\\n", "\r"));
							}
						}
					}
				}
				catch (Exception expr_228)
				{
					ProjectData.SetProjectError(expr_228);
					MessageManager.ShowInformationMessage("参数是否有效");
					ProjectData.ClearProjectError();
				}
				return stringBuilder.ToString();
			}
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dgBOLISData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string value = Conversions.ToString(this.dgBOLISData.CurrentCell.RowIndex);
			string episodeID = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeID"].Value.ToString();
			string text = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeDate"].Value.ToString();
			string text2 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["DeptDesc"].Value.ToString();
			string text3 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeType"].Value.ToString();
			this.lbDate.Text = text;
			this.lbDpart.Text = text2;
			this.lbType.Text = text3;
			this.m_EpisodeID = episodeID;
			this.QueryByEpisodeId();
			this.palPreEpsoide.Visible = false;
			this.tcOrdersQuote.SelectedTab = this.tpOrders;
		}
	}
}
