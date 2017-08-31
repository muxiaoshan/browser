using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using DictionaryData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class StdDicForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("dgDictionary")]
		private KeyDownGrid _dgDictionary;

		[AccessedThroughProperty("btnQuery")]
		private Button _btnQuery;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnPrev")]
		private Button _btnPrev;

		[AccessedThroughProperty("btnNext")]
		private Button _btnNext;

		[AccessedThroughProperty("btnFirst")]
		private Button _btnFirst;

		[AccessedThroughProperty("btnLast")]
		private Button _btnLast;

		[AccessedThroughProperty("lblPageNum")]
		private Label _lblPageNum;

		[AccessedThroughProperty("txtPageNum")]
		private TextBox _txtPageNum;

		[AccessedThroughProperty("txtQuery")]
		private TextBox _txtQuery;

		[AccessedThroughProperty("lblQuery")]
		private Label _lblQuery;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("chkShowAll")]
		private CheckBox _chkShowAll;

		private MIDictionary _BindMIDictionary;

		private NISimple _BindNISimple;

		private string _DicValue;

		private string _DicValueCode;

		private bool BoolMouseDown;

		private Point ClickedPoint;

		private DataGridTableStyle curDataGridTableStyle;

		private StringCollection collumcol;

		private DataTable curDataTable;

		private int PageCount;

		private int CurrentPageNum;

		private bool boolShowDic;

		private static int _PageRowCount = 0;

		private string _strQuery;

		private string _strSessionID;

		private string _strCondition;

		private string _strConditionCode;

		private DataSet _queryDataset;

		internal virtual KeyDownGrid dgDictionary
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgDictionary;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.dgDictionary_Paint);
				KeyEventHandler value3 = new KeyEventHandler(this.dgDictionary_KeyDown);
				EventHandler value4 = new EventHandler(this.dgDictionary_DoubleClick);
				if (this._dgDictionary != null)
				{
					this._dgDictionary.Paint -= value2;
					this._dgDictionary.KeyDown -= value3;
					this._dgDictionary.DoubleClick -= value4;
				}
				this._dgDictionary = value;
				if (this._dgDictionary != null)
				{
					this._dgDictionary.Paint += value2;
					this._dgDictionary.KeyDown += value3;
					this._dgDictionary.DoubleClick += value4;
				}
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

		internal virtual Button btnFirst
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFirst;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnFirst_Click);
				if (this._btnFirst != null)
				{
					this._btnFirst.Click -= value2;
				}
				this._btnFirst = value;
				if (this._btnFirst != null)
				{
					this._btnFirst.Click += value2;
				}
			}
		}

		internal virtual Button btnLast
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnLast;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnLast_Click);
				if (this._btnLast != null)
				{
					this._btnLast.Click -= value2;
				}
				this._btnLast = value;
				if (this._btnLast != null)
				{
					this._btnLast.Click += value2;
				}
			}
		}

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
				KeyEventHandler value2 = new KeyEventHandler(this.txtPageNum_KeyDown);
				if (this._txtPageNum != null)
				{
					this._txtPageNum.KeyDown -= value2;
				}
				this._txtPageNum = value;
				if (this._txtPageNum != null)
				{
					this._txtPageNum.KeyDown += value2;
				}
			}
		}

		internal virtual TextBox txtQuery
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtQuery;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txtQuerty_KeyDown);
				if (this._txtQuery != null)
				{
					this._txtQuery.KeyDown -= value2;
				}
				this._txtQuery = value;
				if (this._txtQuery != null)
				{
					this._txtQuery.KeyDown += value2;
				}
			}
		}

		internal virtual Label lblQuery
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblQuery;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblQuery = value;
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

		internal virtual CheckBox chkShowAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkShowAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkShowAll_CheckStateChanged);
				if (this._chkShowAll != null)
				{
					this._chkShowAll.CheckStateChanged -= value2;
				}
				this._chkShowAll = value;
				if (this._chkShowAll != null)
				{
					this._chkShowAll.CheckStateChanged += value2;
				}
			}
		}

		public static int PageRowCount
		{
			get
			{
				if (StdDicForm._PageRowCount == 0)
				{
					try
					{
						string sysOptionValue = SysOptionManager.GetSysOptionValue("DicPageRowCount", "12");
						if ((sysOptionValue != null | Operators.CompareString(sysOptionValue, "", false) == 0) && Versioned.IsNumeric(sysOptionValue))
						{
							StdDicForm._PageRowCount = int.Parse(sysOptionValue);
						}
						if (StdDicForm._PageRowCount <= 0)
						{
							StdDicForm._PageRowCount = 12;
						}
					}
					catch (Exception expr_55)
					{
						ProjectData.SetProjectError(expr_55);
						Exception ex = expr_55;
						MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
						StdDicForm._PageRowCount = 12;
						ProjectData.ClearProjectError();
					}
				}
				return StdDicForm._PageRowCount;
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

		public StdDicForm()
		{
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			base.Load += new EventHandler(this.StdDicForm_Load);
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			this.BoolMouseDown = false;
			this.curDataGridTableStyle = new DataGridTableStyle();
			this._strCondition = string.Empty;
			this._strConditionCode = string.Empty;
			this._queryDataset = new DataSet();
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
			this.dgDictionary = new KeyDownGrid();
			this.btnQuery = new Button();
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.txtQuery = new TextBox();
			this.btnPrev = new Button();
			this.btnNext = new Button();
			this.btnFirst = new Button();
			this.btnLast = new Button();
			this.lblPageNum = new Label();
			this.txtPageNum = new TextBox();
			this.lblQuery = new Label();
			this.chkShowAll = new CheckBox();
			this.GroupBox1 = new GroupBox();
			this.GroupBox2 = new GroupBox();
			this.GroupBox3 = new GroupBox();
			((ISupportInitialize)this.dgDictionary).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			this.dgDictionary.CaptionVisible = false;
			this.dgDictionary.DataMember = "";
			this.dgDictionary.HeaderForeColor = SystemColors.ControlText;
			Control arg_11F_0 = this.dgDictionary;
			Point location = new Point(5, 12);
			arg_11F_0.Location = location;
			this.dgDictionary.Name = "dgDictionary";
			this.dgDictionary.ReadOnly = true;
			this.dgDictionary.RowHeadersVisible = false;
			Control arg_164_0 = this.dgDictionary;
			Size size = new Size(435, 252);
			arg_164_0.Size = size;
			this.dgDictionary.TabIndex = 0;
			this.btnQuery.BackColor = Color.FromArgb(49, 101, 156);
			this.btnQuery.FlatStyle = FlatStyle.Flat;
			this.btnQuery.ForeColor = Color.White;
			Control arg_1BF_0 = this.btnQuery;
			location = new Point(372, 11);
			arg_1BF_0.Location = location;
			this.btnQuery.Name = "btnQuery";
			Control arg_1E6_0 = this.btnQuery;
			size = new Size(69, 24);
			arg_1E6_0.Size = size;
			this.btnQuery.TabIndex = 5;
			this.btnQuery.Text = "查询(&Q)";
			this.btnQuery.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_25D_0 = this.btnCancel;
			location = new Point(366, 13);
			arg_25D_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_284_0 = this.btnCancel;
			size = new Size(69, 24);
			arg_284_0.Size = size;
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_2FB_0 = this.btnOK;
			location = new Point(291, 13);
			arg_2FB_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_322_0 = this.btnOK;
			size = new Size(69, 24);
			arg_322_0.Size = size;
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = false;
			this.txtQuery.BorderStyle = BorderStyle.FixedSingle;
			Control arg_36D_0 = this.txtQuery;
			location = new Point(68, 14);
			arg_36D_0.Location = location;
			this.txtQuery.Name = "txtQuery";
			Control arg_397_0 = this.txtQuery;
			size = new Size(231, 21);
			arg_397_0.Size = size;
			this.txtQuery.TabIndex = 2;
			this.btnPrev.BackColor = Color.FromArgb(49, 101, 156);
			this.btnPrev.FlatStyle = FlatStyle.Flat;
			this.btnPrev.ForeColor = Color.White;
			Control arg_3F5_0 = this.btnPrev;
			location = new Point(271, 267);
			arg_3F5_0.Location = location;
			this.btnPrev.Name = "btnPrev";
			Control arg_41C_0 = this.btnPrev;
			size = new Size(28, 24);
			arg_41C_0.Size = size;
			this.btnPrev.TabIndex = 9;
			this.btnPrev.Text = "<";
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnNext.BackColor = Color.FromArgb(49, 101, 156);
			this.btnNext.FlatStyle = FlatStyle.Flat;
			this.btnNext.ForeColor = Color.White;
			Control arg_497_0 = this.btnNext;
			location = new Point(367, 267);
			arg_497_0.Location = location;
			this.btnNext.Name = "btnNext";
			Control arg_4BE_0 = this.btnNext;
			size = new Size(28, 24);
			arg_4BE_0.Size = size;
			this.btnNext.TabIndex = 11;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnFirst.BackColor = Color.FromArgb(49, 101, 156);
			this.btnFirst.FlatStyle = FlatStyle.Flat;
			this.btnFirst.ForeColor = Color.White;
			Control arg_539_0 = this.btnFirst;
			location = new Point(227, 267);
			arg_539_0.Location = location;
			this.btnFirst.Name = "btnFirst";
			Control arg_560_0 = this.btnFirst;
			size = new Size(28, 24);
			arg_560_0.Size = size;
			this.btnFirst.TabIndex = 8;
			this.btnFirst.Text = "|<";
			this.btnFirst.UseVisualStyleBackColor = false;
			this.btnLast.BackColor = Color.FromArgb(49, 101, 156);
			this.btnLast.FlatStyle = FlatStyle.Flat;
			this.btnLast.ForeColor = Color.White;
			Control arg_5DA_0 = this.btnLast;
			location = new Point(407, 267);
			arg_5DA_0.Location = location;
			this.btnLast.Name = "btnLast";
			Control arg_601_0 = this.btnLast;
			size = new Size(28, 24);
			arg_601_0.Size = size;
			this.btnLast.TabIndex = 12;
			this.btnLast.Text = ">|";
			this.btnLast.UseVisualStyleBackColor = false;
			this.lblPageNum.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_664_0 = this.lblPageNum;
			location = new Point(6, 271);
			arg_664_0.Location = location;
			this.lblPageNum.Name = "lblPageNum";
			Control arg_68B_0 = this.lblPageNum;
			size = new Size(88, 16);
			arg_68B_0.Size = size;
			this.lblPageNum.TabIndex = 19;
			this.lblPageNum.Text = "共   页";
			this.txtPageNum.BorderStyle = BorderStyle.FixedSingle;
			Control arg_6D1_0 = this.txtPageNum;
			location = new Point(307, 269);
			arg_6D1_0.Location = location;
			this.txtPageNum.Name = "txtPageNum";
			Control arg_6F8_0 = this.txtPageNum;
			size = new Size(52, 21);
			arg_6F8_0.Size = size;
			this.txtPageNum.TabIndex = 10;
			this.lblQuery.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_73C_0 = this.lblQuery;
			location = new Point(4, 18);
			arg_73C_0.Location = location;
			this.lblQuery.Name = "lblQuery";
			Control arg_763_0 = this.lblQuery;
			size = new Size(64, 13);
			arg_763_0.Size = size;
			this.lblQuery.TabIndex = 20;
			this.lblQuery.Text = "查询条件";
			this.chkShowAll.AutoSize = true;
			Control arg_7A6_0 = this.chkShowAll;
			location = new Point(304, 17);
			arg_7A6_0.Location = location;
			this.chkShowAll.Name = "chkShowAll";
			Control arg_7CD_0 = this.chkShowAll;
			size = new Size(72, 16);
			arg_7CD_0.Size = size;
			this.chkShowAll.TabIndex = 22;
			this.chkShowAll.Text = "显示所有";
			this.chkShowAll.UseVisualStyleBackColor = true;
			this.chkShowAll.Visible = false;
			this.GroupBox1.Controls.Add(this.btnOK);
			this.GroupBox1.Controls.Add(this.btnCancel);
			Control arg_847_0 = this.GroupBox1;
			location = new Point(6, 328);
			arg_847_0.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_871_0 = this.GroupBox1;
			size = new Size(445, 40);
			arg_871_0.Size = size;
			this.GroupBox1.TabIndex = 23;
			this.GroupBox1.TabStop = false;
			this.GroupBox2.Controls.Add(this.btnPrev);
			this.GroupBox2.Controls.Add(this.btnNext);
			this.GroupBox2.Controls.Add(this.btnFirst);
			this.GroupBox2.Controls.Add(this.btnLast);
			this.GroupBox2.Controls.Add(this.txtPageNum);
			this.GroupBox2.Controls.Add(this.dgDictionary);
			this.GroupBox2.Controls.Add(this.lblPageNum);
			Control arg_93A_0 = this.GroupBox2;
			location = new Point(6, 34);
			arg_93A_0.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			Control arg_967_0 = this.GroupBox2;
			size = new Size(445, 297);
			arg_967_0.Size = size;
			this.GroupBox2.TabIndex = 24;
			this.GroupBox2.TabStop = false;
			this.GroupBox3.Controls.Add(this.txtQuery);
			this.GroupBox3.Controls.Add(this.btnQuery);
			this.GroupBox3.Controls.Add(this.chkShowAll);
			this.GroupBox3.Controls.Add(this.lblQuery);
			Control arg_9EE_0 = this.GroupBox3;
			location = new Point(6, -4);
			arg_9EE_0.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			Control arg_A18_0 = this.GroupBox3;
			size = new Size(445, 42);
			arg_A18_0.Size = size;
			this.GroupBox3.TabIndex = 20;
			this.GroupBox3.TabStop = false;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(457, 372);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "StdDicForm";
			this.ShowInTaskbar = false;
			this.Text = "字典查找";
			this.TopMost = true;
			((ISupportInitialize)this.dgDictionary).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);
		}

		public void ShowDic(int pageCount, DataSet resultDataSet, MIDictionary objMIDictionary, string strQuery, string strSessionID, string strCondCode, string strCondition)
		{
			if (!strCondition.Equals(string.Empty))
			{
				this._strConditionCode = strCondCode;
				this._strCondition = strCondition;
				this.chkShowAll.Visible = true;
			}
			else
			{
				this.chkShowAll.Visible = false;
			}
		}

		public void ShowDic(int pageCount, DataSet resultDataSet, MIDictionary objMIDictionary, string strQuery, string strSessionID)
		{
			this.lblPageNum.Text = "共 " + pageCount.ToString() + " 页";
			this.PageCount = pageCount;
			this.boolShowDic = true;
			this._BindMIDictionary = objMIDictionary;
			this._strQuery = strQuery;
			this.txtQuery.Text = this._strQuery;
			this._strSessionID = strSessionID;
			this.BindDictionary();
			this.BindResultSet(1, resultDataSet);
		}

		public void ShowDic(MIDictionary objMIDictionary, string strQuery)
		{
			this._BindMIDictionary = objMIDictionary;
			this.BindDictionary();
			this._strQuery = strQuery;
			this.txtQuery.Text = strQuery;
			this.QueryDictionary();
		}

		public void ShowDic(MIDictionary objMIDictionary, string strQuery, string strConditionCode, string strCondition)
		{
			this._BindMIDictionary = objMIDictionary;
			this.BindDictionary();
			this._strQuery = strQuery;
			this.txtQuery.Text = strQuery;
			this._strConditionCode = strConditionCode;
			this._strCondition = strCondition;
			if (!strConditionCode.Equals(string.Empty))
			{
				this.chkShowAll.Visible = true;
				this.chkShowAll.Checked = false;
			}
			this.QueryDictionary();
		}

		private void TextBoxEnterHandler(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			control.Visible = false;
			this.dgDictionary.Focus();
		}

		private void txtQuerty_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				this.dgDictionary.Focus();
			}
			else if (e.KeyCode == Keys.Return)
			{
				this.QueryDictionary();
			}
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.QueryDictionary();
		}

		private void dgDictionary_DoubleClick(object sender, EventArgs e)
		{
			this.ChangeDictionaryText();
			this.DialogResult = DialogResult.OK;
		}

		private void dgDictionary_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.ChangeDictionaryText();
				this.DialogResult = DialogResult.OK;
			}
		}

		private void EnterKeyDown()
		{
			this.ChangeDictionaryText();
			this.DialogResult = DialogResult.OK;
		}

		private void PageUpKeyDown()
		{
			if (this.PageCount > 0 & this.CurrentPageNum > 1)
			{
				this.RefreshList(checked(this.CurrentPageNum - 1));
			}
		}

		private void PageDownKeyDown()
		{
			if (this.PageCount > 0 & this.CurrentPageNum < this.PageCount)
			{
				this.RefreshList(checked(this.CurrentPageNum + 1));
			}
		}

		private void TabKeyDown()
		{
			this.txtQuery.Focus();
		}

		private void EscKeyDown()
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void BackspaceKeyDown()
		{
			string text = this.txtQuery.Text;
			if (!text.Equals(string.Empty))
			{
				this.txtQuery.Text = text.Remove(checked(text.Length - 1), 1);
			}
			this.txtQuery.Focus();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.ChangeDictionaryText();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			if (this.PageCount > 0)
			{
				this.RefreshList(1);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (this.PageCount > 0 & this.CurrentPageNum < this.PageCount)
			{
				this.RefreshList(checked(this.CurrentPageNum + 1));
			}
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (this.PageCount > 0 & this.CurrentPageNum > 1)
			{
				this.RefreshList(checked(this.CurrentPageNum - 1));
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			if (this.PageCount > 0)
			{
				this.RefreshList(this.PageCount);
			}
		}

		private void txtPageNum_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && (this.PageCount > 0 & Versioned.IsNumeric(this.txtPageNum.Text)))
			{
				int num = int.Parse(this.txtPageNum.Text);
				if (num > 0 & num < this.PageCount)
				{
					this.RefreshList(num);
				}
			}
		}

		private void dgDictionary_Paint(object sender, PaintEventArgs e)
		{
			if (this.dgDictionary.CurrentRowIndex != -1)
			{
				this.dgDictionary.Select(this.dgDictionary.CurrentRowIndex);
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			if (this._strSessionID != null && Operators.CompareString(this._strSessionID, "", false) != 0)
			{
				WebServiceLayer.DictionaryAccess.DeleteStdQueryTempGlobal(this._strSessionID);
			}
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
			Point p = new Point(e.X, e.Y);
			this.ClickedPoint = this.PointToScreen(p);
			this.Cursor = Cursors.SizeAll;
			this.BoolMouseDown = true;
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.BoolMouseDown)
				{
					Point clickedPoint = default(Point);
					Point p = new Point(e.X, e.Y);
					clickedPoint = this.PointToScreen(p);
					this.Top += clickedPoint.Y - this.ClickedPoint.Y;
					this.Left += clickedPoint.X - this.ClickedPoint.X;
					this.ClickedPoint = clickedPoint;
				}
			}
		}

		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.BoolMouseDown = false;
		}

		private void BindDictionary()
		{
			this.curDataTable = new DataTable("Dictionary");
			if (this._BindMIDictionary.FirstColType == ColType.Alias)
			{
				this.curDataTable.Columns.Add("DicAlias");
			}
			else if (this._BindMIDictionary.FirstColType == ColType.Code)
			{
				this.curDataTable.Columns.Add("DicCode");
			}
			else if (this._BindMIDictionary.FirstColType == ColType.Desc)
			{
				this.curDataTable.Columns.Add("DicDesc");
			}
			if (this._BindMIDictionary.SecondColType == ColType.Alias)
			{
				this.curDataTable.Columns.Add("DicAlias");
			}
			else if (this._BindMIDictionary.SecondColType == ColType.Code)
			{
				this.curDataTable.Columns.Add("DicCode");
			}
			else if (this._BindMIDictionary.SecondColType == ColType.Desc)
			{
				this.curDataTable.Columns.Add("DicDesc");
			}
			if (this._BindMIDictionary.ThirdColType == ColType.Alias)
			{
				this.curDataTable.Columns.Add("DicAlias");
			}
			else if (this._BindMIDictionary.ThirdColType == ColType.Code)
			{
				this.curDataTable.Columns.Add("DicCode");
			}
			else if (this._BindMIDictionary.ThirdColType == ColType.Desc)
			{
				this.curDataTable.Columns.Add("DicDesc");
			}
			int arg_168_0 = 1;
			int pageRowCount = StdDicForm.PageRowCount;
			checked
			{
				for (int i = arg_168_0; i <= pageRowCount; i++)
				{
					DataRow dataRow = this.curDataTable.NewRow();
					int arg_18D_0 = 0;
					int num = this.curDataTable.Columns.Count - 1;
					for (int j = arg_18D_0; j <= num; j++)
					{
						dataRow[j] = "";
					}
					this.curDataTable.Rows.Add(dataRow);
				}
				this.dgDictionary.DataSource = this.curDataTable;
				this.curDataGridTableStyle.RowHeadersVisible = false;
				this.curDataGridTableStyle.MappingName = "Dictionary";
				DataGridTextBoxColumn dataGridTextBoxColumn = new DataGridTextBoxColumn();
				DataGridTextBoxColumn dataGridTextBoxColumn2 = new DataGridTextBoxColumn();
				DataGridTextBoxColumn dataGridTextBoxColumn3 = new DataGridTextBoxColumn();
				int arg_21B_0 = 0;
				int num2 = this.curDataTable.Columns.Count - 1;
				for (int k = arg_21B_0; k <= num2; k++)
				{
					if (Operators.CompareString(this.curDataTable.Columns[k].ColumnName, "DicAlias", false) == 0)
					{
						dataGridTextBoxColumn.HeaderText = "别名";
						dataGridTextBoxColumn.MappingName = "DicAlias";
						dataGridTextBoxColumn.Width = 80;
						dataGridTextBoxColumn.TextBox.Enter += new EventHandler(this.TextBoxEnterHandler);
						dataGridTextBoxColumn.TextBox.KeyDown += new KeyEventHandler(this.dgDictionary_KeyDown);
						this.curDataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn);
					}
					if (Operators.CompareString(this.curDataTable.Columns[k].ColumnName, "DicCode", false) == 0)
					{
						dataGridTextBoxColumn2.HeaderText = "代码";
						dataGridTextBoxColumn2.MappingName = "DicCode";
						dataGridTextBoxColumn2.Width = 80;
						dataGridTextBoxColumn2.TextBox.Enter += new EventHandler(this.TextBoxEnterHandler);
						dataGridTextBoxColumn2.TextBox.KeyDown += new KeyEventHandler(this.dgDictionary_KeyDown);
						this.curDataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn2);
					}
					if (Operators.CompareString(this.curDataTable.Columns[k].ColumnName, "DicDesc", false) == 0)
					{
						dataGridTextBoxColumn3.HeaderText = "描述";
						dataGridTextBoxColumn3.MappingName = "DicDesc";
						dataGridTextBoxColumn3.Width = 210;
						dataGridTextBoxColumn3.TextBox.Enter += new EventHandler(this.TextBoxEnterHandler);
						dataGridTextBoxColumn3.TextBox.KeyDown += new KeyEventHandler(this.dgDictionary_KeyDown);
						this.curDataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn3);
					}
				}
				this.curDataGridTableStyle.RowHeadersVisible = true;
				this.curDataGridTableStyle.ReadOnly = true;
				this.dgDictionary.TableStyles.Add(this.curDataGridTableStyle);
				this.dgDictionary.EnterKeyDown += new KeyDownGrid.EnterKeyDownEventHandler(this.EnterKeyDown);
				this.dgDictionary.TabKeyDown += new KeyDownGrid.TabKeyDownEventHandler(this.TabKeyDown);
				this.dgDictionary.PageUpKeyDown += new KeyDownGrid.PageUpKeyDownEventHandler(this.PageUpKeyDown);
				this.dgDictionary.PageDownKeyDown += new KeyDownGrid.PageDownKeyDownEventHandler(this.PageDownKeyDown);
				this.dgDictionary.EscKeyDown += new KeyDownGrid.EscKeyDownEventHandler(this.EscKeyDown);
				this.dgDictionary.BackspaceKeyDown += new KeyDownGrid.BackspaceKeyDownEventHandler(this.BackspaceKeyDown);
			}
		}

		public void QueryDictionary()
		{
			this.PageCount = 0;
			this._strSessionID = "";
			if (this.chkShowAll.Checked)
			{
				StdDictionaryService arg_68_0 = WebServiceLayer.DictionaryAccess;
				string arg_68_1 = this._BindMIDictionary.StdDicCode;
				string arg_68_2 = this.txtQuery.Text;
				long arg_68_3 = 1L;
				bool arg_68_4 = true;
				long arg_68_5 = (long)StdDicForm.PageRowCount;
				bool arg_68_6 = true;
				string arg_68_7 = "True";
				string value = Conversions.ToString(this.PageCount);
				DataSet arg_79_1 = arg_68_0.GetStdDicOrList(arg_68_1, arg_68_2, arg_68_3, arg_68_4, arg_68_5, arg_68_6, arg_68_7, ref value, ref this._strSessionID, "", "");
				this.PageCount = Conversions.ToInteger(value);
				this._queryDataset = arg_79_1;
			}
			else
			{
				StdDictionaryService arg_CB_0 = WebServiceLayer.DictionaryAccess;
				string arg_CB_1 = this._BindMIDictionary.StdDicCode;
				string arg_CB_2 = this.txtQuery.Text;
				long arg_CB_3 = 1L;
				bool arg_CB_4 = true;
				long arg_CB_5 = (long)StdDicForm.PageRowCount;
				bool arg_CB_6 = true;
				string arg_CB_7 = "True";
				string value = Conversions.ToString(this.PageCount);
				DataSet arg_DC_1 = arg_CB_0.GetStdDicOrList(arg_CB_1, arg_CB_2, arg_CB_3, arg_CB_4, arg_CB_5, arg_CB_6, arg_CB_7, ref value, ref this._strSessionID, this._strConditionCode, this._strCondition);
				this.PageCount = Conversions.ToInteger(value);
				this._queryDataset = arg_DC_1;
			}
			if (this.PageCount == 0)
			{
				this.BindResultSet(0, this._queryDataset);
			}
			else
			{
				this.BindResultSet(1, this._queryDataset);
			}
			this.lblPageNum.Text = "共 " + this.PageCount.ToString() + " 页";
		}

		private void GetQueryDataset(string strQuery)
		{
			DataSet dataSet = new DataSet();
			checked
			{
				if (this._queryDataset != null && this._queryDataset.Tables.Count > 0)
				{
					dataSet = this._queryDataset.Clone();
					DataRow[] array = this._queryDataset.Tables[0].Select(string.Concat(new string[]
					{
						"(DicDesc like '%",
						strQuery,
						"%') or (DicAlias like '%",
						strQuery,
						"%') or (DicCode like '%",
						strQuery,
						"%')"
					}));
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow row = array2[i];
						dataSet.Tables[0].ImportRow(row);
					}
					if (dataSet != null)
					{
						this.BindResultSet(this.CurrentPageNum, dataSet);
					}
				}
			}
		}

		private void RefreshList(int pageNum)
		{
			if (!(this._strSessionID == null | Operators.CompareString(this._strSessionID, "", false) == 0))
			{
				string text = this.PageCount.ToString();
				this._queryDataset = WebServiceLayer.DictionaryAccess.GetStdDicOrList(this._BindMIDictionary.StdDicCode, this._strQuery, (long)pageNum, true, (long)StdDicForm.PageRowCount, true, "False", ref text, ref this._strSessionID, "", "");
				this.BindResultSet(pageNum, this._queryDataset);
			}
		}

		public void BindResultSet(int pageNum, DataSet curDataSet)
		{
			if (curDataSet == null)
			{
				this.curDataTable.Rows.Clear();
				this.dgDictionary.TableStyles[0].MappingName = this.curDataTable.TableName;
			}
			else
			{
				this.dgDictionary.DataSource = curDataSet.Tables[0];
				this.curDataTable = curDataSet.Tables[0];
				this.dgDictionary.TableStyles[0].MappingName = curDataSet.Tables[0].TableName;
				if (this.curDataTable.Rows.Count > 0)
				{
					this.dgDictionary.Select(0);
					this.dgDictionary.Focus();
				}
			}
			this.CurrentPageNum = pageNum;
			this.txtPageNum.Text = pageNum.ToString();
			this.dgDictionary.Focus();
		}

		private void ChangeDictionaryText()
		{
			checked
			{
				if (this.dgDictionary.CurrentRowIndex > -1)
				{
					int num = 0;
					try
					{
						IEnumerator enumerator = this.curDataGridTableStyle.GridColumnStyles.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataGridColumnStyle dataGridColumnStyle = (DataGridColumnStyle)enumerator.Current;
							if (Operators.CompareString(dataGridColumnStyle.MappingName, "DicCode", false) == 0)
							{
								this._DicValueCode = Conversions.ToString(this.dgDictionary[this.dgDictionary.CurrentRowIndex, num]);
							}
							if (Operators.CompareString(dataGridColumnStyle.MappingName, "DicDesc", false) == 0)
							{
								this._DicValue = Conversions.ToString(this.dgDictionary[this.dgDictionary.CurrentRowIndex, num]);
							}
							num++;
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

		private void StdDicForm_Load(object sender, EventArgs e)
		{
			this.dgDictionary.Focus();
		}

		private void chkShowAll_CheckStateChanged(object sender, EventArgs e)
		{
			this.QueryDictionary();
		}
	}
}
