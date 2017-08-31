using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using MRDiagnosData;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class DiagnosHistoryList : Form
	{
		private IContainer components;

		private string _paitent;

		private string _IcdType;

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

		public string Paitent
		{
			get
			{
				return this._paitent;
			}
			set
			{
				this._paitent = value;
			}
		}

		public string IcdType
		{
			get
			{
				return this._IcdType;
			}
			set
			{
				this._IcdType = value;
			}
		}

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

		public DiagnosHistoryList()
		{
			base.Load += new EventHandler(this.DiagnosHistoryList_Load);
			this._paitent = string.Empty;
			this._IcdType = string.Empty;
			this.InitializeComponent();
		}

		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
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
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dgvHistoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
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
			this.dgvHistoryList.Dock = DockStyle.Fill;
			Control arg_15D_0 = this.dgvHistoryList;
			Point location = new Point(0, 0);
			arg_15D_0.Location = location;
			this.dgvHistoryList.Name = "dgvHistoryList";
			this.dgvHistoryList.ReadOnly = true;
			this.dgvHistoryList.RowHeadersVisible = false;
			this.dgvHistoryList.RowTemplate.Height = 23;
			Control arg_1B4_0 = this.dgvHistoryList;
			Size size = new Size(586, 402);
			arg_1B4_0.Size = size;
			this.dgvHistoryList.TabIndex = 0;
			this.HRowid.DataPropertyName = "Rowid";
			this.HRowid.HeaderText = "Rowid";
			this.HRowid.Name = "HRowid";
			this.HRowid.ReadOnly = true;
			this.HRowid.Visible = false;
			this.HDesc.DataPropertyName = "Desc";
			this.HDesc.HeaderText = "ICD描述";
			this.HDesc.Name = "HDesc";
			this.HDesc.ReadOnly = true;
			this.HDesc.Width = 150;
			this.HMRDesc.DataPropertyName = "MRDesc";
			this.HMRDesc.HeaderText = "描述";
			this.HMRDesc.Name = "HMRDesc";
			this.HMRDesc.ReadOnly = true;
			this.HMRDesc.Width = 60;
			this.HDoctDesc.DataPropertyName = "DoctDesc";
			this.HDoctDesc.HeaderText = "医生";
			this.HDoctDesc.Name = "HDoctDesc";
			this.HDoctDesc.ReadOnly = true;
			this.HDoctDesc.Width = 80;
			this.HMRDate.DataPropertyName = "MRDate";
			this.HMRDate.HeaderText = "日期";
			this.HMRDate.Name = "HMRDate";
			this.HMRDate.ReadOnly = true;
			this.HMRDate.Width = 80;
			this.HMRtime.DataPropertyName = "MRtime";
			this.HMRtime.HeaderText = "时间";
			this.HMRtime.Name = "HMRtime";
			this.HMRtime.ReadOnly = true;
			this.HMRtime.Width = 80;
			this.HAdmDep.DataPropertyName = "AdmDep";
			this.HAdmDep.HeaderText = "科室";
			this.HAdmDep.Name = "HAdmDep";
			this.HAdmDep.ReadOnly = true;
			size = new Size(586, 402);
			this.ClientSize = size;
			this.Controls.Add(this.dgvHistoryList);
			this.Name = "DiagnosHistoryList";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = " 诊断重复记录";
			this.TopMost = true;
			((ISupportInitialize)this.dgvHistoryList).EndInit();
			this.ResumeLayout(false);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void DiagnosHistoryList_Load(object sender, EventArgs e)
		{
			try
			{
				EMRDiagnosAllHistoryDataset eMRDiagnosAllHistoryDataset = new EMRDiagnosAllHistoryDataset();
				eMRDiagnosAllHistoryDataset = WebServiceLayer.MRDiagnosDataAccess.GetAllHistoryData(this.Paitent, this.IcdType);
				if (eMRDiagnosAllHistoryDataset != null && eMRDiagnosAllHistoryDataset.Tables.Count > 0)
				{
					this.dgvHistoryList.DataSource = eMRDiagnosAllHistoryDataset.Tables[0];
				}
			}
			catch (Exception expr_47)
			{
				ProjectData.SetProjectError(expr_47);
				MessageManager.ShowErrorMessage("数据加载出错");
				ProjectData.ClearProjectError();
			}
		}
	}
}
