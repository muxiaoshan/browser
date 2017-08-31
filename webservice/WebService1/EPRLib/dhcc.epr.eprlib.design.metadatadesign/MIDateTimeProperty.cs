using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIDateTimeProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblDateFormate")]
		private Label _lblDateFormate;

		[AccessedThroughProperty("cbxDateFormate")]
		private ComboBox _cbxDateFormate;

		[AccessedThroughProperty("chxIncludeDate")]
		private CheckBox _chxIncludeDate;

		[AccessedThroughProperty("chxIncludeTime")]
		private CheckBox _chxIncludeTime;

		[AccessedThroughProperty("lblTimeFormate")]
		private Label _lblTimeFormate;

		[AccessedThroughProperty("cbxTimeFormate")]
		private ComboBox _cbxTimeFormate;

		private MIDateTime _MIDateTime;

		internal virtual Label lblDateFormate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDateFormate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDateFormate = value;
			}
		}

		internal virtual ComboBox cbxDateFormate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxDateFormate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxDateFormate_SelectedIndexChanged);
				if (this._cbxDateFormate != null)
				{
					this._cbxDateFormate.SelectedIndexChanged -= value2;
				}
				this._cbxDateFormate = value;
				if (this._cbxDateFormate != null)
				{
					this._cbxDateFormate.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual CheckBox chxIncludeDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxIncludeDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxIncludeDate_CheckedChanged);
				if (this._chxIncludeDate != null)
				{
					this._chxIncludeDate.CheckedChanged -= value2;
				}
				this._chxIncludeDate = value;
				if (this._chxIncludeDate != null)
				{
					this._chxIncludeDate.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox chxIncludeTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxIncludeTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxIncludeTime_CheckedChanged);
				if (this._chxIncludeTime != null)
				{
					this._chxIncludeTime.CheckedChanged -= value2;
				}
				this._chxIncludeTime = value;
				if (this._chxIncludeTime != null)
				{
					this._chxIncludeTime.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label lblTimeFormate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTimeFormate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTimeFormate = value;
			}
		}

		internal virtual ComboBox cbxTimeFormate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxTimeFormate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxTimeFormate_SelectedIndexChanged);
				if (this._cbxTimeFormate != null)
				{
					this._cbxTimeFormate.SelectedIndexChanged -= value2;
				}
				this._cbxTimeFormate = value;
				if (this._cbxTimeFormate != null)
				{
					this._cbxTimeFormate.SelectedIndexChanged += value2;
				}
			}
		}

		public MIDateTime MIDateTime
		{
			get
			{
				return this._MIDateTime;
			}
			set
			{
				this._MIDateTime = value;
				this.chxIncludeDate.Checked = this._MIDateTime.IncludeDate;
				this.chxIncludeTime.Checked = this._MIDateTime.IncludeTime;
				if (Operators.CompareString(this._MIDateTime.DateFormate, "LONG", false) == 0)
				{
					this.cbxDateFormate.SelectedIndex = 0;
				}
				else
				{
					this.cbxDateFormate.SelectedIndex = 1;
				}
				if (!this._MIDateTime.IncludeDate)
				{
					this.cbxDateFormate.Enabled = false;
				}
				if (Operators.CompareString(this._MIDateTime.TimeFormate, "LONG", false) == 0)
				{
					this.cbxTimeFormate.SelectedIndex = 0;
				}
				else
				{
					this.cbxTimeFormate.SelectedIndex = 1;
				}
				if (!this._MIDateTime.IncludeTime)
				{
					this.cbxTimeFormate.Enabled = false;
				}
			}
		}

		public MIDateTimeProperty()
		{
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
			this.chxIncludeDate = new CheckBox();
			this.chxIncludeTime = new CheckBox();
			this.lblDateFormate = new Label();
			this.cbxDateFormate = new ComboBox();
			this.lblTimeFormate = new Label();
			this.cbxTimeFormate = new ComboBox();
			this.SuspendLayout();
			Control arg_58_0 = this.chxIncludeDate;
			Point location = new Point(6, 8);
			arg_58_0.Location = location;
			this.chxIncludeDate.Name = "chxIncludeDate";
			Control arg_7F_0 = this.chxIncludeDate;
			Size size = new Size(85, 24);
			arg_7F_0.Size = size;
			this.chxIncludeDate.TabIndex = 0;
			this.chxIncludeDate.Text = "包括日期";
			Control arg_B1_0 = this.chxIncludeTime;
			location = new Point(6, 38);
			arg_B1_0.Location = location;
			this.chxIncludeTime.Name = "chxIncludeTime";
			Control arg_D8_0 = this.chxIncludeTime;
			size = new Size(85, 24);
			arg_D8_0.Size = size;
			this.chxIncludeTime.TabIndex = 1;
			this.chxIncludeTime.Text = "包括时间";
			Control arg_10B_0 = this.lblDateFormate;
			location = new Point(110, 9);
			arg_10B_0.Location = location;
			this.lblDateFormate.Name = "lblDateFormate";
			Control arg_132_0 = this.lblDateFormate;
			size = new Size(95, 23);
			arg_132_0.Size = size;
			this.lblDateFormate.TabIndex = 2;
			this.lblDateFormate.Text = "日期显示格式：";
			this.lblDateFormate.TextAlign = ContentAlignment.MiddleRight;
			this.cbxDateFormate.Items.AddRange(new object[]
			{
				"长格式",
				"短格式"
			});
			Control arg_19D_0 = this.cbxDateFormate;
			location = new Point(213, 9);
			arg_19D_0.Location = location;
			this.cbxDateFormate.Name = "cbxDateFormate";
			Control arg_1C4_0 = this.cbxDateFormate;
			size = new Size(96, 20);
			arg_1C4_0.Size = size;
			this.cbxDateFormate.TabIndex = 3;
			Control arg_1E7_0 = this.lblTimeFormate;
			location = new Point(110, 39);
			arg_1E7_0.Location = location;
			this.lblTimeFormate.Name = "lblTimeFormate";
			Control arg_20E_0 = this.lblTimeFormate;
			size = new Size(95, 23);
			arg_20E_0.Size = size;
			this.lblTimeFormate.TabIndex = 4;
			this.lblTimeFormate.Text = "时间显示格式：";
			this.lblTimeFormate.TextAlign = ContentAlignment.MiddleRight;
			this.cbxTimeFormate.Enabled = false;
			this.cbxTimeFormate.Items.AddRange(new object[]
			{
				"长格式",
				"短格式"
			});
			Control arg_285_0 = this.cbxTimeFormate;
			location = new Point(213, 38);
			arg_285_0.Location = location;
			this.cbxTimeFormate.Name = "cbxTimeFormate";
			Control arg_2AC_0 = this.cbxTimeFormate;
			size = new Size(96, 20);
			arg_2AC_0.Size = size;
			this.cbxTimeFormate.TabIndex = 5;
			this.Controls.Add(this.cbxTimeFormate);
			this.Controls.Add(this.lblTimeFormate);
			this.Controls.Add(this.cbxDateFormate);
			this.Controls.Add(this.lblDateFormate);
			this.Controls.Add(this.chxIncludeTime);
			this.Controls.Add(this.chxIncludeDate);
			this.Name = "MIDateTimeProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void cbxDateFormate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxDateFormate.SelectedIndex == 0)
			{
				this._MIDateTime.DateFormate = "LONG";
			}
			else
			{
				this._MIDateTime.DateFormate = "SHORT";
			}
		}

		private void chxIncludeDate_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.chxIncludeDate.Checked)
			{
				this.cbxDateFormate.Enabled = false;
			}
			else
			{
				this.cbxDateFormate.Enabled = true;
			}
			this._MIDateTime.IncludeDate = this.chxIncludeDate.Checked;
			if (!this.chxIncludeDate.Checked && !this.chxIncludeTime.Checked)
			{
				this.chxIncludeTime.Checked = true;
			}
		}

		private void chxIncludeTime_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.chxIncludeTime.Checked)
			{
				this.cbxTimeFormate.Enabled = false;
			}
			else
			{
				this.cbxTimeFormate.Enabled = true;
			}
			this._MIDateTime.IncludeTime = this.chxIncludeTime.Checked;
			if (!this.chxIncludeDate.Checked && !this.chxIncludeTime.Checked)
			{
				this.chxIncludeDate.Checked = true;
			}
		}

		private void cbxTimeFormate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxTimeFormate.SelectedIndex == 0)
			{
				this._MIDateTime.TimeFormate = "LONG";
			}
			else
			{
				this._MIDateTime.TimeFormate = "SHORT";
			}
		}
	}
}
