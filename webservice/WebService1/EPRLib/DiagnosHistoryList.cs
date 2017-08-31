using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
internal class DiagnosHistoryList : Form
{
	private IContainer components;

	[AccessedThroughProperty("dgvHistoryList")]
	private DataGridView _dgvHistoryList;

	[AccessedThroughProperty("HRowid")]
	private DataGridViewTextBoxColumn _HRowid;

	[AccessedThroughProperty("HDesc")]
	private DataGridViewTextBoxColumn _HDesc;

	[AccessedThroughProperty("HMRDesc")]
	private DataGridViewTextBoxColumn _HMRDesc;

	[AccessedThroughProperty("HDoctDesc")]
	private DataGridViewTextBoxColumn _HDoctDesc;

	[AccessedThroughProperty("HMRDate")]
	private DataGridViewTextBoxColumn _HMRDate;

	[AccessedThroughProperty("HMRtime")]
	private DataGridViewTextBoxColumn _HMRtime;

	[AccessedThroughProperty("HAdmDep")]
	private DataGridViewTextBoxColumn _HAdmDep;

	internal virtual DataGridView dgvHistoryList
	{
		[DebuggerNonUserCode]
		get
		{
			return this._dgvHistoryList;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._dgvHistoryList = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HRowid
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HRowid;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HRowid = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HDesc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HMRDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HMRDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HMRDesc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HDoctDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HDoctDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HDoctDesc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HMRDate
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HMRDate;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HMRDate = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HMRtime
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HMRtime;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HMRtime = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HAdmDep
	{
		[DebuggerNonUserCode]
		get
		{
			return this._HAdmDep;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._HAdmDep = value;
		}
	}

	[DebuggerNonUserCode]
	public DiagnosHistoryList()
	{
		this.InitializeComponent();
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
		this.dgvHistoryList = new DataGridView();
		this.HRowid = new DataGridViewTextBoxColumn();
		this.HDesc = new DataGridViewTextBoxColumn();
		this.HMRDesc = new DataGridViewTextBoxColumn();
		this.HDoctDesc = new DataGridViewTextBoxColumn();
		this.HMRDate = new DataGridViewTextBoxColumn();
		this.HMRtime = new DataGridViewTextBoxColumn();
		this.HAdmDep = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.dgvHistoryList).BeginInit();
		this.SuspendLayout();
		this.dgvHistoryList.AllowUserToAddRows = false;
		this.dgvHistoryList.AllowUserToDeleteRows = false;
		this.dgvHistoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvHistoryList.Columns.AddRange(new DataGridViewColumn[]
		{
			this.HRowid,
			this.HDesc,
			this.HMRDesc,
			this.HDoctDesc,
			this.HMRDate,
			this.HMRtime,
			this.HAdmDep
		});
		Control arg_FC_0 = this.dgvHistoryList;
		Point location = new Point(264, 173);
		arg_FC_0.Location = location;
		this.dgvHistoryList.Name = "dgvHistoryList";
		this.dgvHistoryList.ReadOnly = true;
		this.dgvHistoryList.RowHeadersVisible = false;
		this.dgvHistoryList.RowTemplate.Height = 23;
		Control arg_153_0 = this.dgvHistoryList;
		Size size = new Size(175, 147);
		arg_153_0.Size = size;
		this.dgvHistoryList.TabIndex = 0;
		this.HRowid.DataPropertyName = "Rowid";
		this.HRowid.HeaderText = "Rowid";
		this.HRowid.Name = "HRowid";
		this.HRowid.ReadOnly = true;
		this.HRowid.Visible = false;
		this.HDesc.DataPropertyName = "Desc";
		this.HDesc.HeaderText = "描述";
		this.HDesc.Name = "HDesc";
		this.HDesc.ReadOnly = true;
		this.HMRDesc.DataPropertyName = "MRDesc";
		this.HMRDesc.HeaderText = "就诊描述";
		this.HMRDesc.Name = "HMRDesc";
		this.HMRDesc.ReadOnly = true;
		this.HDoctDesc.DataPropertyName = "DoctDesc";
		this.HDoctDesc.HeaderText = "医生";
		this.HDoctDesc.Name = "HDoctDesc";
		this.HDoctDesc.ReadOnly = true;
		this.HMRDate.DataPropertyName = "MRDate";
		this.HMRDate.HeaderText = "诊断日期";
		this.HMRDate.Name = "HMRDate";
		this.HMRDate.ReadOnly = true;
		this.HMRtime.DataPropertyName = "MRtime";
		this.HMRtime.HeaderText = "诊断时间";
		this.HMRtime.Name = "HMRtime";
		this.HMRtime.ReadOnly = true;
		this.HAdmDep.DataPropertyName = "AdmDep";
		this.HAdmDep.HeaderText = "就诊科室";
		this.HAdmDep.Name = "HAdmDep";
		this.HAdmDep.ReadOnly = true;
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		size = new Size(471, 367);
		this.ClientSize = size;
		this.Controls.Add(this.dgvHistoryList);
		this.Name = "DiagnosHistoryList";
		this.Text = "历史数据";
		((ISupportInitialize)this.dgvHistoryList).EndInit();
		this.ResumeLayout(false);
	}
}
