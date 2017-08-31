using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class PMsg : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("BPanel")]
		private Panel _BPanel;

		[AccessedThroughProperty("MsgPanel")]
		private Panel _MsgPanel;

		[AccessedThroughProperty("MsgSplitter")]
		private Splitter _MsgSplitter;

		[AccessedThroughProperty("MainPanel")]
		private Panel _MainPanel;

		[AccessedThroughProperty("DGMsg")]
		private DataGrid _DGMsg;

		[AccessedThroughProperty("MsgGridTableStyle")]
		private DataGridTableStyle _MsgGridTableStyle;

		[AccessedThroughProperty("colErrorType")]
		private DataGridTextBoxColumn _colErrorType;

		[AccessedThroughProperty("colErrorDesc")]
		private DataGridTextBoxColumn _colErrorDesc;

		public PPanel PPanel;

		private CheckMsgCollection CheckErrors;

		private bool boolBind;

		private int CurrentRow;

		internal virtual Panel BPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BPanel = value;
			}
		}

		internal virtual Panel MsgPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MsgPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MsgPanel = value;
			}
		}

		internal virtual Splitter MsgSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MsgSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MsgSplitter = value;
			}
		}

		internal virtual Panel MainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainPanel = value;
			}
		}

		internal virtual DataGrid DGMsg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DGMsg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DGMsg_CurrentCellChanged);
				PaintEventHandler value3 = new PaintEventHandler(this.DGMsg_Paint);
				if (this._DGMsg != null)
				{
					this._DGMsg.CurrentCellChanged -= value2;
					this._DGMsg.Paint -= value3;
				}
				this._DGMsg = value;
				if (this._DGMsg != null)
				{
					this._DGMsg.CurrentCellChanged += value2;
					this._DGMsg.Paint += value3;
				}
			}
		}

		internal virtual DataGridTableStyle MsgGridTableStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MsgGridTableStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MsgGridTableStyle = value;
			}
		}

		internal virtual DataGridTextBoxColumn colErrorType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colErrorType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colErrorType = value;
			}
		}

		internal virtual DataGridTextBoxColumn colErrorDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colErrorDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colErrorDesc = value;
			}
		}

		public PMsg()
		{
			base.BackColorChanged += new EventHandler(this.PMsg_BackColorChanged);
			this.boolBind = false;
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
			this.BPanel = new Panel();
			this.MainPanel = new Panel();
			this.MsgSplitter = new Splitter();
			this.MsgPanel = new Panel();
			this.DGMsg = new DataGrid();
			this.MsgGridTableStyle = new DataGridTableStyle();
			this.colErrorType = new DataGridTextBoxColumn();
			this.colErrorDesc = new DataGridTextBoxColumn();
			this.BPanel.SuspendLayout();
			this.MsgPanel.SuspendLayout();
			((ISupportInitialize)this.DGMsg).BeginInit();
			this.SuspendLayout();
			this.BPanel.Controls.Add(this.MainPanel);
			this.BPanel.Controls.Add(this.MsgSplitter);
			this.BPanel.Controls.Add(this.MsgPanel);
			this.BPanel.Dock = DockStyle.Fill;
			Control arg_DD_0 = this.BPanel;
			Point location = new Point(0, 0);
			arg_DD_0.Location = location;
			this.BPanel.Name = "BPanel";
			Control arg_10A_0 = this.BPanel;
			Size size = new Size(576, 376);
			arg_10A_0.Size = size;
			this.BPanel.TabIndex = 0;
			this.MainPanel.Dock = DockStyle.Fill;
			Control arg_137_0 = this.MainPanel;
			location = new Point(0, 0);
			arg_137_0.Location = location;
			this.MainPanel.Name = "MainPanel";
			Control arg_164_0 = this.MainPanel;
			size = new Size(576, 271);
			arg_164_0.Size = size;
			this.MainPanel.TabIndex = 2;
			this.MsgSplitter.Dock = DockStyle.Bottom;
			Control arg_195_0 = this.MsgSplitter;
			location = new Point(0, 271);
			arg_195_0.Location = location;
			this.MsgSplitter.Name = "MsgSplitter";
			Control arg_1BE_0 = this.MsgSplitter;
			size = new Size(576, 5);
			arg_1BE_0.Size = size;
			this.MsgSplitter.TabIndex = 1;
			this.MsgSplitter.TabStop = false;
			this.MsgPanel.Controls.Add(this.DGMsg);
			this.MsgPanel.Dock = DockStyle.Bottom;
			Control arg_211_0 = this.MsgPanel;
			location = new Point(0, 276);
			arg_211_0.Location = location;
			this.MsgPanel.Name = "MsgPanel";
			Control arg_235_0 = this.MsgPanel;
			Padding padding = new Padding(5);
			arg_235_0.Padding = padding;
			Control arg_24F_0 = this.MsgPanel;
			size = new Size(576, 100);
			arg_24F_0.Size = size;
			this.MsgPanel.TabIndex = 0;
			this.DGMsg.AlternatingBackColor = Color.FromArgb(246, 250, 253);
			this.DGMsg.BackColor = Color.FromArgb(246, 250, 253);
			this.DGMsg.BackgroundColor = Color.FromArgb(246, 250, 253);
			this.DGMsg.BorderStyle = BorderStyle.None;
			this.DGMsg.CaptionBackColor = Color.LightSteelBlue;
			this.DGMsg.CaptionForeColor = Color.OrangeRed;
			this.DGMsg.CaptionText = "发现病历内容有误，共";
			this.DGMsg.ColumnHeadersVisible = false;
			this.DGMsg.DataMember = "";
			this.DGMsg.Dock = DockStyle.Fill;
			this.DGMsg.FlatMode = true;
			this.DGMsg.Font = new Font("Tahoma", 8f);
			this.DGMsg.ForeColor = Color.Tomato;
			this.DGMsg.GridLineColor = Color.Gainsboro;
			this.DGMsg.GridLineStyle = DataGridLineStyle.None;
			this.DGMsg.HeaderBackColor = Color.MidnightBlue;
			this.DGMsg.HeaderFont = new Font("Tahoma", 8f, FontStyle.Bold);
			this.DGMsg.HeaderForeColor = Color.Tomato;
			this.DGMsg.LinkColor = Color.Teal;
			Control arg_3CE_0 = this.DGMsg;
			location = new Point(5, 5);
			arg_3CE_0.Location = location;
			this.DGMsg.Name = "DGMsg";
			this.DGMsg.ParentRowsBackColor = Color.Gainsboro;
			this.DGMsg.ParentRowsForeColor = Color.MidnightBlue;
			this.DGMsg.ReadOnly = true;
			this.DGMsg.RowHeadersVisible = false;
			this.DGMsg.SelectionBackColor = Color.CadetBlue;
			this.DGMsg.SelectionForeColor = Color.WhiteSmoke;
			Control arg_450_0 = this.DGMsg;
			size = new Size(566, 90);
			arg_450_0.Size = size;
			this.DGMsg.TabIndex = 0;
			this.DGMsg.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.MsgGridTableStyle
			});
			this.MsgGridTableStyle.AllowSorting = false;
			this.MsgGridTableStyle.AlternatingBackColor = Color.FromArgb(246, 250, 253);
			this.MsgGridTableStyle.BackColor = Color.FromArgb(246, 250, 253);
			this.MsgGridTableStyle.DataGrid = this.DGMsg;
			this.MsgGridTableStyle.ForeColor = Color.OrangeRed;
			this.MsgGridTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.colErrorType,
				this.colErrorDesc
			});
			this.MsgGridTableStyle.HeaderForeColor = SystemColors.ControlText;
			this.MsgGridTableStyle.MappingName = "CheckMsgCollection";
			this.MsgGridTableStyle.RowHeadersVisible = false;
			this.MsgGridTableStyle.SelectionForeColor = Color.OrangeRed;
			this.colErrorType.Format = "";
			this.colErrorType.FormatInfo = null;
			this.colErrorType.HeaderText = "错误类型";
			this.colErrorType.MappingName = "ErrorType";
			this.colErrorType.NullText = "";
			this.colErrorType.Width = 0;
			this.colErrorDesc.Format = "";
			this.colErrorDesc.FormatInfo = null;
			this.colErrorDesc.HeaderText = "错误说明";
			this.colErrorDesc.MappingName = "ErrorDesc";
			this.colErrorDesc.NullText = "";
			this.colErrorDesc.Width = 75;
			this.Controls.Add(this.BPanel);
			this.Name = "PMsg";
			size = new Size(576, 376);
			this.Size = size;
			this.BPanel.ResumeLayout(false);
			this.MsgPanel.ResumeLayout(false);
			((ISupportInitialize)this.DGMsg).EndInit();
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.PPanel = new PPanel();
			this.CheckErrors = this.PPanel.CheckErrors;
			this.PPanel.ErrorChanged += new PPanel.ErrorChangedEventHandler(this.OnErrorChanged);
			this.PPanel.Dock = DockStyle.Fill;
			this.MainPanel.Controls.Add(this.PPanel);
			this.CloseErrorPanel();
		}

		private void SetDGMsgCaption(int parErrCount)
		{
			this.DGMsg.CaptionText = "发现病历内容有误，共 " + parErrCount.ToString() + " 处";
		}

		public void OnErrorChanged()
		{
			if (this.CheckErrors.Count > 0)
			{
				this.InitErrorPanel();
				this.MsgBind();
			}
			else
			{
				this.CloseErrorPanel();
			}
			this.SetDGMsgCaption(this.CheckErrors.Count);
		}

		public bool Check()
		{
			this.CheckErrors = this.PPanel.Check();
			this.SetDGMsgCaption(this.CheckErrors.Count);
			if (this.CheckErrors.Count > 0)
			{
				this.InitErrorPanel();
				this.MsgBind();
				return false;
			}
			this.CloseErrorPanel();
			return true;
		}

		private void InitErrorPanel()
		{
			if (!this.MsgSplitter.Enabled)
			{
				this.MsgSplitter.Enabled = true;
				this.MsgSplitter.Height = 5;
				this.MsgPanel.Height = 100;
				this.colErrorDesc.Width = checked(this.DGMsg.Width - 110);
			}
		}

		private void MsgBind()
		{
			this.CurrentRow = -1;
			this.boolBind = true;
			this.DGMsg.DataSource = null;
			this.DGMsg.DataSource = this.CheckErrors;
			this.MsgGridTableStyle.DataGrid = this.DGMsg;
			this.MsgGridTableStyle.MappingName = "CheckMsgCollection";
			this.boolBind = false;
			if (this.CheckErrors.Count > 0)
			{
				this.CurrentRow = 0;
				this.DGMsg.Select(0);
				this.PPanel.SetMsg(this.CheckErrors[this.CurrentRow].RelatedElements, true);
			}
		}

		private void CloseErrorPanel()
		{
			this.CurrentRow = -1;
			this.DGMsg.DataSource = null;
			this.MsgPanel.Height = 0;
			this.MsgSplitter.Height = 0;
			this.MsgSplitter.Enabled = false;
		}

		private void DGMsg_Paint(object sender, PaintEventArgs e)
		{
			if (this.CurrentRow > -1)
			{
				this.DGMsg.Select(this.CurrentRow);
			}
		}

		private void DGMsg_CurrentCellChanged(object sender, EventArgs e)
		{
			if (!this.boolBind && this.DGMsg.CurrentRowIndex > -1 && this.CurrentRow != this.DGMsg.CurrentRowIndex)
			{
				if (this.CurrentRow > -1)
				{
					this.PPanel.SetMsg(this.CheckErrors[this.CurrentRow].RelatedElements, false);
				}
				this.CurrentRow = this.DGMsg.CurrentRowIndex;
				this.PPanel.SetMsg(this.CheckErrors[this.CurrentRow].RelatedElements, true);
			}
		}

		private void PMsg_BackColorChanged(object sender, EventArgs e)
		{
			this.MsgSplitter.BackColor = this.BackColor;
			this.MsgPanel.BackColor = this.BackColor;
			this.DGMsg.BackColor = this.BackColor;
		}
	}
}
