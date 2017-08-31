using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using KBDiagnos;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class DiagnosForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("lblCtLoc")]
	private Label _lblCtLoc;

	[AccessedThroughProperty("cbxCtLoc")]
	private ComboBox _cbxCtLoc;

	[AccessedThroughProperty("dgDiagnos")]
	private DataGridView _dgDiagnos;

	[AccessedThroughProperty("btnOK")]
	private Button _btnOK;

	[AccessedThroughProperty("gbxLine")]
	private GroupBox _gbxLine;

	[AccessedThroughProperty("btnInsert")]
	private Button _btnInsert;

	[AccessedThroughProperty("btnModify")]
	private Button _btnModify;

	[AccessedThroughProperty("txtDescription")]
	private TextBox _txtDescription;

	[AccessedThroughProperty("txtName")]
	private TextBox _txtName;

	[AccessedThroughProperty("txtDiagnos")]
	private TextBox _txtDiagnos;

	[AccessedThroughProperty("lblDesc")]
	private Label _lblDesc;

	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[AccessedThroughProperty("lblDiagnos")]
	private Label _lblDiagnos;

	[AccessedThroughProperty("IDColumn")]
	private DataGridViewTextBoxColumn _IDColumn;

	[AccessedThroughProperty("DescColumn")]
	private DataGridViewTextBoxColumn _DescColumn;

	[AccessedThroughProperty("NameColumn")]
	private DataGridViewTextBoxColumn _NameColumn;

	[AccessedThroughProperty("DiagnosColumn")]
	private DataGridViewTextBoxColumn _DiagnosColumn;

	[AccessedThroughProperty("UserNameColumn")]
	private DataGridViewTextBoxColumn _UserNameColumn;

	[AccessedThroughProperty("DateColumn")]
	private DataGridViewTextBoxColumn _DateColumn;

	[AccessedThroughProperty("UserIDColumn")]
	private DataGridViewTextBoxColumn _UserIDColumn;

	private string _CtLocID;

	private string _CtLocIDs;

	private bool _IsPersonalKBNode;

	private DataGridViewRow _CurrentRow;

	internal virtual Label lblCtLoc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblCtLoc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblCtLoc = value;
		}
	}

	internal virtual ComboBox cbxCtLoc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._cbxCtLoc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.cbxCtLoc_SelectedIndexChanged);
			if (this._cbxCtLoc != null)
			{
				this._cbxCtLoc.SelectedIndexChanged -= value2;
			}
			this._cbxCtLoc = value;
			if (this._cbxCtLoc != null)
			{
				this._cbxCtLoc.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DataGridView dgDiagnos
	{
		[DebuggerNonUserCode]
		get
		{
			return this._dgDiagnos;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgDiagnos_CellClick);
			DataGridViewRowCancelEventHandler value3 = new DataGridViewRowCancelEventHandler(this.dgDiagnos_UserDeletingRow);
			if (this._dgDiagnos != null)
			{
				this._dgDiagnos.CellClick -= value2;
				this._dgDiagnos.UserDeletingRow -= value3;
			}
			this._dgDiagnos = value;
			if (this._dgDiagnos != null)
			{
				this._dgDiagnos.CellClick += value2;
				this._dgDiagnos.UserDeletingRow += value3;
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
			this._btnOK = value;
		}
	}

	internal virtual GroupBox gbxLine
	{
		[DebuggerNonUserCode]
		get
		{
			return this._gbxLine;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._gbxLine = value;
		}
	}

	internal virtual Button btnInsert
	{
		[DebuggerNonUserCode]
		get
		{
			return this._btnInsert;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.btnInsert_Click);
			if (this._btnInsert != null)
			{
				this._btnInsert.Click -= value2;
			}
			this._btnInsert = value;
			if (this._btnInsert != null)
			{
				this._btnInsert.Click += value2;
			}
		}
	}

	internal virtual Button btnModify
	{
		[DebuggerNonUserCode]
		get
		{
			return this._btnModify;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.btnModify_Click);
			if (this._btnModify != null)
			{
				this._btnModify.Click -= value2;
			}
			this._btnModify = value;
			if (this._btnModify != null)
			{
				this._btnModify.Click += value2;
			}
		}
	}

	internal virtual TextBox txtDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtDescription;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtDescription = value;
		}
	}

	internal virtual TextBox txtName
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtName;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtName = value;
		}
	}

	internal virtual TextBox txtDiagnos
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtDiagnos;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtDiagnos = value;
		}
	}

	internal virtual Label lblDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblDesc = value;
		}
	}

	internal virtual Label lblName
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblName;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblName = value;
		}
	}

	internal virtual Label lblDiagnos
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblDiagnos;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblDiagnos = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn IDColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._IDColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._IDColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DescColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DescColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._DescColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn NameColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._NameColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._NameColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DiagnosColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DiagnosColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._DiagnosColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UserNameColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._UserNameColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._UserNameColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DateColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DateColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._DateColumn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UserIDColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return this._UserIDColumn;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._UserIDColumn = value;
		}
	}

	public string CtLocID
	{
		get
		{
			return this._CtLocID;
		}
		set
		{
			this._CtLocID = value;
		}
	}

	public string CtLocIDs
	{
		get
		{
			return this._CtLocIDs;
		}
		set
		{
			this._CtLocIDs = value;
		}
	}

	public bool IsPersonalKBNode
	{
		get
		{
			return this._IsPersonalKBNode;
		}
		set
		{
			this._IsPersonalKBNode = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		this.lblCtLoc = new Label();
		this.cbxCtLoc = new ComboBox();
		this.dgDiagnos = new DataGridView();
		this.btnOK = new Button();
		this.gbxLine = new GroupBox();
		this.btnInsert = new Button();
		this.btnModify = new Button();
		this.txtDescription = new TextBox();
		this.txtName = new TextBox();
		this.txtDiagnos = new TextBox();
		this.lblDesc = new Label();
		this.lblName = new Label();
		this.lblDiagnos = new Label();
		this.IDColumn = new DataGridViewTextBoxColumn();
		this.DescColumn = new DataGridViewTextBoxColumn();
		this.NameColumn = new DataGridViewTextBoxColumn();
		this.DiagnosColumn = new DataGridViewTextBoxColumn();
		this.UserNameColumn = new DataGridViewTextBoxColumn();
		this.DateColumn = new DataGridViewTextBoxColumn();
		this.UserIDColumn = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.dgDiagnos).BeginInit();
		this.SuspendLayout();
		this.lblCtLoc.AutoSize = true;
		Control arg_131_0 = this.lblCtLoc;
		Point location = new Point(7, 10);
		arg_131_0.Location = location;
		this.lblCtLoc.Name = "lblCtLoc";
		Control arg_159_0 = this.lblCtLoc;
		Size size = new Size(65, 12);
		arg_159_0.Size = size;
		this.lblCtLoc.TabIndex = 0;
		this.lblCtLoc.Text = "所在科室：";
		this.cbxCtLoc.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbxCtLoc.FormattingEnabled = true;
		Control arg_1A4_0 = this.cbxCtLoc;
		location = new Point(75, 6);
		arg_1A4_0.Location = location;
		this.cbxCtLoc.Name = "cbxCtLoc";
		Control arg_1CF_0 = this.cbxCtLoc;
		size = new Size(198, 20);
		arg_1CF_0.Size = size;
		this.cbxCtLoc.TabIndex = 1;
		this.dgDiagnos.AllowUserToAddRows = false;
		this.dgDiagnos.AllowUserToResizeColumns = false;
		this.dgDiagnos.AllowUserToResizeRows = false;
		this.dgDiagnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgDiagnos.Columns.AddRange(new DataGridViewColumn[]
		{
			this.IDColumn,
			this.DescColumn,
			this.NameColumn,
			this.DiagnosColumn,
			this.UserNameColumn,
			this.DateColumn,
			this.UserIDColumn
		});
		Control arg_282_0 = this.dgDiagnos;
		location = new Point(4, 32);
		arg_282_0.Location = location;
		this.dgDiagnos.MultiSelect = false;
		this.dgDiagnos.Name = "dgDiagnos";
		this.dgDiagnos.RowTemplate.Height = 23;
		this.dgDiagnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgDiagnos.ShowCellErrors = false;
		this.dgDiagnos.ShowCellToolTips = false;
		Control arg_2F2_0 = this.dgDiagnos;
		size = new Size(584, 222);
		arg_2F2_0.Size = size;
		this.dgDiagnos.TabIndex = 2;
		this.btnOK.DialogResult = DialogResult.OK;
		Control arg_328_0 = this.btnOK;
		location = new Point(513, 300);
		arg_328_0.Location = location;
		this.btnOK.Name = "btnOK";
		Control arg_350_0 = this.btnOK;
		size = new Size(75, 23);
		arg_350_0.Size = size;
		this.btnOK.TabIndex = 3;
		this.btnOK.Text = "关闭(&ESC)";
		this.btnOK.UseVisualStyleBackColor = true;
		Control arg_392_0 = this.gbxLine;
		location = new Point(0, 290);
		arg_392_0.Location = location;
		this.gbxLine.Name = "gbxLine";
		Control arg_3BC_0 = this.gbxLine;
		size = new Size(594, 4);
		arg_3BC_0.Size = size;
		this.gbxLine.TabIndex = 5;
		this.gbxLine.TabStop = false;
		Control arg_3EE_0 = this.btnInsert;
		location = new Point(4, 300);
		arg_3EE_0.Location = location;
		this.btnInsert.Name = "btnInsert";
		Control arg_416_0 = this.btnInsert;
		size = new Size(75, 23);
		arg_416_0.Size = size;
		this.btnInsert.TabIndex = 6;
		this.btnInsert.Text = "增加(&A)";
		this.btnInsert.UseVisualStyleBackColor = true;
		Control arg_459_0 = this.btnModify;
		location = new Point(85, 300);
		arg_459_0.Location = location;
		this.btnModify.Name = "btnModify";
		Control arg_481_0 = this.btnModify;
		size = new Size(75, 23);
		arg_481_0.Size = size;
		this.btnModify.TabIndex = 7;
		this.btnModify.Text = "修改(&M)";
		this.btnModify.UseVisualStyleBackColor = true;
		Control arg_4C4_0 = this.txtDescription;
		location = new Point(54, 263);
		arg_4C4_0.Location = location;
		this.txtDescription.Name = "txtDescription";
		Control arg_4EF_0 = this.txtDescription;
		size = new Size(161, 21);
		arg_4EF_0.Size = size;
		this.txtDescription.TabIndex = 8;
		Control arg_519_0 = this.txtName;
		location = new Point(288, 263);
		arg_519_0.Location = location;
		this.txtName.Name = "txtName";
		Control arg_541_0 = this.txtName;
		size = new Size(107, 21);
		arg_541_0.Size = size;
		this.txtName.TabIndex = 9;
		Control arg_56C_0 = this.txtDiagnos;
		location = new Point(463, 263);
		arg_56C_0.Location = location;
		this.txtDiagnos.Name = "txtDiagnos";
		Control arg_594_0 = this.txtDiagnos;
		size = new Size(125, 21);
		arg_594_0.Size = size;
		this.txtDiagnos.TabIndex = 10;
		this.lblDesc.AutoSize = true;
		Control arg_5C7_0 = this.lblDesc;
		location = new Point(7, 267);
		arg_5C7_0.Location = location;
		this.lblDesc.Name = "lblDesc";
		Control arg_5EF_0 = this.lblDesc;
		size = new Size(41, 12);
		arg_5EF_0.Size = size;
		this.lblDesc.TabIndex = 11;
		this.lblDesc.Text = "描述：";
		this.lblName.AutoSize = true;
		Control arg_636_0 = this.lblName;
		location = new Point(241, 267);
		arg_636_0.Location = location;
		this.lblName.Name = "lblName";
		Control arg_65E_0 = this.lblName;
		size = new Size(41, 12);
		arg_65E_0.Size = size;
		this.lblName.TabIndex = 12;
		this.lblName.Text = "代码：";
		this.lblDiagnos.AutoSize = true;
		Control arg_6A5_0 = this.lblDiagnos;
		location = new Point(416, 267);
		arg_6A5_0.Location = location;
		this.lblDiagnos.Name = "lblDiagnos";
		Control arg_6CD_0 = this.lblDiagnos;
		size = new Size(41, 12);
		arg_6CD_0.Size = size;
		this.lblDiagnos.TabIndex = 13;
		this.lblDiagnos.Text = "诊断：";
		this.IDColumn.DataPropertyName = "ID";
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.IDColumn.DefaultCellStyle = dataGridViewCellStyle;
		this.IDColumn.FillWeight = 10f;
		this.IDColumn.HeaderText = "ID";
		this.IDColumn.Name = "IDColumn";
		this.IDColumn.Visible = false;
		this.IDColumn.Width = 54;
		this.DescColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.DescColumn.DataPropertyName = "Description";
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		this.DescColumn.DefaultCellStyle = dataGridViewCellStyle2;
		this.DescColumn.FillWeight = 30f;
		this.DescColumn.HeaderText = "描述";
		this.DescColumn.Name = "DescColumn";
		this.NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.NameColumn.DataPropertyName = "Name";
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
		this.NameColumn.FillWeight = 20f;
		this.NameColumn.HeaderText = "代码";
		this.NameColumn.Name = "NameColumn";
		this.DiagnosColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.DiagnosColumn.DataPropertyName = "Diagnos";
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
		this.DiagnosColumn.DefaultCellStyle = dataGridViewCellStyle4;
		this.DiagnosColumn.FillWeight = 15f;
		this.DiagnosColumn.HeaderText = "诊断";
		this.DiagnosColumn.Name = "DiagnosColumn";
		this.UserNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.UserNameColumn.DataPropertyName = "UserName";
		dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.UserNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
		this.UserNameColumn.FillWeight = 15f;
		this.UserNameColumn.HeaderText = "创建者";
		this.UserNameColumn.Name = "UserNameColumn";
		this.UserNameColumn.ReadOnly = true;
		this.DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.DateColumn.DataPropertyName = "CreateDate";
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.DateColumn.DefaultCellStyle = dataGridViewCellStyle6;
		this.DateColumn.FillWeight = 20f;
		this.DateColumn.HeaderText = "创建日期";
		this.DateColumn.Name = "DateColumn";
		this.DateColumn.ReadOnly = true;
		this.UserIDColumn.DataPropertyName = "UserID";
		this.UserIDColumn.HeaderText = "UserID";
		this.UserIDColumn.Name = "UserIDColumn";
		this.UserIDColumn.ReadOnly = true;
		this.UserIDColumn.Visible = false;
		this.AcceptButton = this.btnOK;
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		this.CancelButton = this.btnOK;
		size = new Size(592, 326);
		this.ClientSize = size;
		this.Controls.Add(this.lblDiagnos);
		this.Controls.Add(this.lblName);
		this.Controls.Add(this.lblDesc);
		this.Controls.Add(this.txtDiagnos);
		this.Controls.Add(this.txtName);
		this.Controls.Add(this.txtDescription);
		this.Controls.Add(this.btnModify);
		this.Controls.Add(this.btnInsert);
		this.Controls.Add(this.gbxLine);
		this.Controls.Add(this.btnOK);
		this.Controls.Add(this.dgDiagnos);
		this.Controls.Add(this.cbxCtLoc);
		this.Controls.Add(this.lblCtLoc);
		this.FormBorderStyle = FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "DiagnosForm";
		this.StartPosition = FormStartPosition.CenterParent;
		this.Text = "病种维护";
		((ISupportInitialize)this.dgDiagnos).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	public DiagnosForm()
	{
		base.Load += new EventHandler(this.DiagnosForm_Load);
		this.InitializeComponent();
	}

	public DiagnosForm(string ctLocID, string ctLocIDs, bool isPersonalKBNode)
	{
		base.Load += new EventHandler(this.DiagnosForm_Load);
		this.InitializeComponent();
		this.CtLocID = ctLocID;
		this.CtLocIDs = ctLocIDs;
		this.IsPersonalKBNode = isPersonalKBNode;
	}

	private void InitCtLocDropdownList()
	{
		DataTable dataSource = WebServiceLayer.KbConfigAccess.GetAllLoc().Tables[0];
		if (!string.IsNullOrEmpty(this.CtLocIDs))
		{
			this.FilterByCtLocIDs(this.CtLocIDs, ref dataSource);
		}
		this.cbxCtLoc.DataSource = dataSource;
		this.cbxCtLoc.DisplayMember = "Des";
		this.cbxCtLoc.ValueMember = "RowId";
		if (!string.IsNullOrEmpty(this.CtLocID))
		{
			this.cbxCtLoc.SelectedValue = this.CtLocID;
		}
	}

	private void FilterByCtLocIDs(string ctLocIDs, ref DataTable dtCtLoc)
	{
		DataTable dataTable = dtCtLoc.Clone();
		string text = string.Format("^{0}^", ctLocIDs);
		try
		{
			IEnumerator enumerator = dtCtLoc.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				string value = string.Format("^{0}^", dataRow["RowId"].ToString());
				if (text.Contains(value))
				{
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["RowId"] = RuntimeHelpers.GetObjectValue(dataRow["RowId"]);
					dataRow2["Code"] = RuntimeHelpers.GetObjectValue(dataRow["Code"]);
					dataRow2["Des"] = RuntimeHelpers.GetObjectValue(dataRow["Des"]);
					dataTable.Rows.Add(dataRow2);
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
		dtCtLoc = dataTable;
	}

	private void InitDiagnosDataGridView(string ctLocID)
	{
		this.dgDiagnos.ClearSelection();
		if (!string.IsNullOrEmpty(ctLocID))
		{
			this.dgDiagnos.DataSource = WebServiceLayer.KBDiagnosAccess.GetDiagnosByCtLocID(ctLocID).Tables[0];
			if (this.IsPersonalKBNode)
			{
				string valueByKey = GlobalValues.GetValueByKey("UserID");
				try
				{
					IEnumerator enumerator = ((IEnumerable)this.dgDiagnos.Rows).GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						if (!dataGridViewRow.IsNewRow)
						{
							string text = dataGridViewRow.Cells["UserIDColumn"].Value.ToString();
							if (string.IsNullOrEmpty(text) || !text.Equals(valueByKey))
							{
								dataGridViewRow.ReadOnly = true;
								dataGridViewRow.DefaultCellStyle.BackColor = Color.Silver;
							}
						}
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
			}
			try
			{
				IEnumerator enumerator2 = ((IEnumerable)this.dgDiagnos.Rows).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)enumerator2.Current;
					if (!dataGridViewRow2.IsNewRow)
					{
						string value = dataGridViewRow2.Cells["UserIDColumn"].Value.ToString();
						if (!string.IsNullOrEmpty(value))
						{
							dataGridViewRow2.ReadOnly = true;
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.Silver;
						}
					}
				}
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
	}

	private void DiagnosForm_Load(object sender, EventArgs e)
	{
		this.InitCtLocDropdownList();
		this.InitDiagnosDataGridView(this.CtLocID);
	}

	private void cbxCtLoc_SelectedIndexChanged(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(this.cbxCtLoc.SelectedItem);
		if (objectValue != null && !string.IsNullOrEmpty(Conversions.ToString(((DataRowView)objectValue).Row["RowId"])))
		{
			this.InitDiagnosDataGridView(Conversions.ToString(((DataRowView)objectValue).Row["RowId"]));
		}
	}

	private void dgDiagnos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
	{
		DataGridViewRow row = e.Row;
		if (!row.ReadOnly)
		{
			DialogResult dialogResult = MessageManager.ShowQuestionMessage("确定要删除该病种吗？");
			if (dialogResult == DialogResult.Yes)
			{
				string text = row.Cells["IDColumn"].Value.ToString();
				bool flag = false;
				try
				{
					KBDiagnos arg_4B_0 = WebServiceLayer.KBDiagnosAccess;
					string arg_4B_1 = text;
					bool flag2 = true;
					arg_4B_0.DelKBDiagnos(arg_4B_1, ref flag, ref flag2);
					if (flag)
					{
						MessageManager.ShowInformationMessage("删除成功!");
						return;
					}
					MessageManager.ShowInformationMessage("删除失败!");
					return;
				}
				catch (Exception expr_6B)
				{
					ProjectData.SetProjectError(expr_6B);
					Exception ex = expr_6B;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
					return;
				}
			}
			e.Cancel = true;
		}
		else
		{
			MessageManager.ShowErrorMessage("没有权限删除此病种!");
			e.Cancel = true;
		}
	}

	private void btnInsert_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.txtDescription.Text.Trim()) || this.txtName.Text.Length > 50)
		{
			MessageManager.ShowErrorMessage("描述不能为空，并且不超过100个字符！");
			return;
		}
		if (string.IsNullOrEmpty(this.txtName.Text.Trim()) || this.txtName.Text.Length > 50)
		{
			MessageManager.ShowErrorMessage("代码不能为空，并且不超过50个字符！");
			return;
		}
		string text = Conversions.ToString(((DataRowView)this.cbxCtLoc.SelectedItem).Row["RowId"]);
		EKBDiagnos eKBDiagnos = new EKBDiagnos();
		eKBDiagnos.Name = this.txtName.Text.Trim();
		eKBDiagnos.Description = this.txtDescription.Text.Trim();
		eKBDiagnos.Diagnos = this.txtDiagnos.Text.Trim();
		eKBDiagnos.UserID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserID") != null, GlobalValues.GetValueByKey("UserID"), string.Empty));
		eKBDiagnos.CTLocID = text;
		switch (Convert.ToInt32(WebServiceLayer.KBDiagnosAccess.AddKBDiagnos(eKBDiagnos)))
		{
		case -1:
			MessageManager.ShowErrorMessage("代码已存在!");
			break;
		case 0:
			MessageManager.ShowErrorMessage("新增病种失败!");
			break;
		default:
			this.InitDiagnosDataGridView(text);
			break;
		}
	}

	private void btnModify_Click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(((DataRowView)this.cbxCtLoc.SelectedItem).Row["RowId"]);
		if (this._CurrentRow != null && !this._CurrentRow.ReadOnly)
		{
			EKBDiagnos eKBDiagnos = new EKBDiagnos();
			eKBDiagnos.ID = Conversions.ToString(this._CurrentRow.Cells["IDColumn"].Value);
			eKBDiagnos.Name = this.txtName.Text.Trim();
			eKBDiagnos.Description = this.txtDescription.Text.Trim();
			eKBDiagnos.Diagnos = this.txtDiagnos.Text.Trim();
			eKBDiagnos.UserID = Conversions.ToString(Interaction.IIf(GlobalValues.GetValueByKey("UserID") != null, GlobalValues.GetValueByKey("UserID"), string.Empty));
			eKBDiagnos.CTLocID = text;
			eKBDiagnos.CreateDate = DateTime.Now.ToString("yyyy-MM-dd");
			bool flag = false;
			KBDiagnos arg_10A_0 = WebServiceLayer.KBDiagnosAccess;
			EKBDiagnos arg_10A_1 = eKBDiagnos;
			bool flag2 = true;
			arg_10A_0.ModKBDiagnos(arg_10A_1, ref flag, ref flag2);
			if (!flag)
			{
				MessageManager.ShowErrorMessage("修改病种失败!");
			}
			else
			{
				this.InitDiagnosDataGridView(text);
			}
		}
		else
		{
			MessageManager.ShowWarningMessage("您当前没有权限修改此记录!");
		}
	}

	private void dgDiagnos_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		this._CurrentRow = this.dgDiagnos.Rows[e.RowIndex];
		if (this._CurrentRow != null && !this._CurrentRow.ReadOnly)
		{
			this.txtDescription.Text = Conversions.ToString(this._CurrentRow.Cells["DescColumn"].Value);
			this.txtName.Text = Conversions.ToString(this._CurrentRow.Cells["NameColumn"].Value);
			this.txtDiagnos.Text = Conversions.ToString(this._CurrentRow.Cells["DiagnosColumn"].Value);
		}
		else
		{
			this._CurrentRow = null;
			this.txtDescription.Text = string.Empty;
			this.txtName.Text = string.Empty;
			this.txtDiagnos.Text = string.Empty;
		}
	}
}
