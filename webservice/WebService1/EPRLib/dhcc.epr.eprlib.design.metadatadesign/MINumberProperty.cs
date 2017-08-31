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
	public class MINumberProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("chxMinVal")]
		private CheckBox _chxMinVal;

		[AccessedThroughProperty("numMinVal")]
		private NumericUpDown _numMinVal;

		[AccessedThroughProperty("numMaxVal")]
		private NumericUpDown _numMaxVal;

		[AccessedThroughProperty("cbxMaxVal")]
		private ComboBox _cbxMaxVal;

		[AccessedThroughProperty("chxMaxVal")]
		private CheckBox _chxMaxVal;

		[AccessedThroughProperty("cbxMinVal")]
		private ComboBox _cbxMinVal;

		[AccessedThroughProperty("lblDecimalPlace")]
		private Label _lblDecimalPlace;

		[AccessedThroughProperty("numDecimalPlace")]
		private NumericUpDown _numDecimalPlace;

		private const float MINVAL = -1E+10f;

		private const float MAXVAL = 1E+10f;

		private MINumber _MINumber;

		internal virtual CheckBox chxMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxMinVal_CheckedChanged);
				if (this._chxMinVal != null)
				{
					this._chxMinVal.CheckedChanged -= value2;
				}
				this._chxMinVal = value;
				if (this._chxMinVal != null)
				{
					this._chxMinVal.CheckedChanged += value2;
				}
			}
		}

		internal virtual NumericUpDown numMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numMinVal_TextChanged);
				EventHandler value3 = new EventHandler(this.numMinVal_ValueChanged);
				if (this._numMinVal != null)
				{
					this._numMinVal.TextChanged -= value2;
					this._numMinVal.ValueChanged -= value3;
				}
				this._numMinVal = value;
				if (this._numMinVal != null)
				{
					this._numMinVal.TextChanged += value2;
					this._numMinVal.ValueChanged += value3;
				}
			}
		}

		internal virtual NumericUpDown numMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numMaxVal_TextChanged);
				EventHandler value3 = new EventHandler(this.numMaxVal_ValueChanged);
				if (this._numMaxVal != null)
				{
					this._numMaxVal.TextChanged -= value2;
					this._numMaxVal.ValueChanged -= value3;
				}
				this._numMaxVal = value;
				if (this._numMaxVal != null)
				{
					this._numMaxVal.TextChanged += value2;
					this._numMaxVal.ValueChanged += value3;
				}
			}
		}

		internal virtual ComboBox cbxMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxMaxVal_SelectedIndexChanged);
				if (this._cbxMaxVal != null)
				{
					this._cbxMaxVal.SelectedIndexChanged -= value2;
				}
				this._cbxMaxVal = value;
				if (this._cbxMaxVal != null)
				{
					this._cbxMaxVal.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual CheckBox chxMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxMaxVal_CheckedChanged);
				if (this._chxMaxVal != null)
				{
					this._chxMaxVal.CheckedChanged -= value2;
				}
				this._chxMaxVal = value;
				if (this._chxMaxVal != null)
				{
					this._chxMaxVal.CheckedChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbxMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxMinVal_SelectedIndexChanged);
				if (this._cbxMinVal != null)
				{
					this._cbxMinVal.SelectedIndexChanged -= value2;
				}
				this._cbxMinVal = value;
				if (this._cbxMinVal != null)
				{
					this._cbxMinVal.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label lblDecimalPlace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDecimalPlace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDecimalPlace = value;
			}
		}

		internal virtual NumericUpDown numDecimalPlace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numDecimalPlace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numDecimalPlace_TextChanged);
				EventHandler value3 = new EventHandler(this.numDecimalPlace_ValueChanged);
				if (this._numDecimalPlace != null)
				{
					this._numDecimalPlace.TextChanged -= value2;
					this._numDecimalPlace.ValueChanged -= value3;
				}
				this._numDecimalPlace = value;
				if (this._numDecimalPlace != null)
				{
					this._numDecimalPlace.TextChanged += value2;
					this._numDecimalPlace.ValueChanged += value3;
				}
			}
		}

		public MINumber MINumber
		{
			get
			{
				return this._MINumber;
			}
			set
			{
				this._MINumber = value;
				this.numDecimalPlace.Value = new decimal(this._MINumber.DecimalPlace);
				if (this._MINumber.IncludeMin)
				{
					this.cbxMinVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMinVal.SelectedIndex = 1;
				}
				this.numMinVal.DecimalPlaces = this._MINumber.DecimalPlace;
				this.numMinVal.Maximum = 10000000000m;
				this.numMinVal.Minimum = -10000000000m;
				if (this._MINumber.IncludeMin)
				{
					this.cbxMaxVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMaxVal.SelectedIndex = 1;
				}
				this.numMinVal.Value = new decimal(this._MINumber.MinVal);
				if (this._MINumber.HasMinVal)
				{
					this.chxMinVal.Checked = true;
					this.cbxMinVal.Enabled = true;
					this.numMinVal.Enabled = true;
				}
				else
				{
					this.chxMinVal.Checked = false;
					this.cbxMinVal.Enabled = false;
					this.numMinVal.Enabled = false;
				}
				this.numMaxVal.DecimalPlaces = this._MINumber.DecimalPlace;
				this.numMaxVal.Maximum = 10000000000m;
				this.numMaxVal.Minimum = -10000000000m;
				if (this._MINumber.IncludeMax)
				{
					this.cbxMaxVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMaxVal.SelectedIndex = 1;
				}
				this.numMaxVal.Value = new decimal(this._MINumber.MaxVal);
				if (this._MINumber.HasMaxVal)
				{
					this.chxMaxVal.Checked = true;
					this.cbxMaxVal.Enabled = true;
					this.numMaxVal.Enabled = true;
				}
				else
				{
					this.chxMaxVal.Checked = false;
					this.cbxMaxVal.Enabled = false;
					this.numMaxVal.Enabled = false;
				}
			}
		}

		public MINumberProperty()
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
			this.chxMinVal = new CheckBox();
			this.numMinVal = new NumericUpDown();
			this.numMaxVal = new NumericUpDown();
			this.cbxMaxVal = new ComboBox();
			this.chxMaxVal = new CheckBox();
			this.cbxMinVal = new ComboBox();
			this.lblDecimalPlace = new Label();
			this.numDecimalPlace = new NumericUpDown();
			((ISupportInitialize)this.numMinVal).BeginInit();
			((ISupportInitialize)this.numMaxVal).BeginInit();
			((ISupportInitialize)this.numDecimalPlace).BeginInit();
			this.SuspendLayout();
			Control arg_91_0 = this.chxMinVal;
			Point location = new Point(24, 56);
			arg_91_0.Location = location;
			this.chxMinVal.Name = "chxMinVal";
			this.chxMinVal.TabIndex = 0;
			this.chxMinVal.Text = "设置最小值";
			Control arg_D7_0 = this.numMinVal;
			location = new Point(232, 56);
			arg_D7_0.Location = location;
			this.numMinVal.Name = "numMinVal";
			Control arg_FE_0 = this.numMinVal;
			Size size = new Size(88, 21);
			arg_FE_0.Size = size;
			this.numMinVal.TabIndex = 2;
			this.numMinVal.TextAlign = HorizontalAlignment.Right;
			Control arg_130_0 = this.numMaxVal;
			location = new Point(232, 104);
			arg_130_0.Location = location;
			this.numMaxVal.Name = "numMaxVal";
			Control arg_157_0 = this.numMaxVal;
			size = new Size(88, 21);
			arg_157_0.Size = size;
			this.numMaxVal.TabIndex = 5;
			this.numMaxVal.TextAlign = HorizontalAlignment.Right;
			this.cbxMaxVal.Items.AddRange(new object[]
			{
				"<=",
				"< "
			});
			Control arg_1B1_0 = this.cbxMaxVal;
			location = new Point(144, 104);
			arg_1B1_0.Location = location;
			this.cbxMaxVal.Name = "cbxMaxVal";
			Control arg_1D8_0 = this.cbxMaxVal;
			size = new Size(64, 20);
			arg_1D8_0.Size = size;
			this.cbxMaxVal.TabIndex = 4;
			Control arg_1FB_0 = this.chxMaxVal;
			location = new Point(24, 104);
			arg_1FB_0.Location = location;
			this.chxMaxVal.Name = "chxMaxVal";
			this.chxMaxVal.TabIndex = 3;
			this.chxMaxVal.Text = "设置最大值";
			this.cbxMinVal.Items.AddRange(new object[]
			{
				">=",
				">"
			});
			Control arg_269_0 = this.cbxMinVal;
			location = new Point(144, 56);
			arg_269_0.Location = location;
			this.cbxMinVal.Name = "cbxMinVal";
			Control arg_290_0 = this.cbxMinVal;
			size = new Size(64, 20);
			arg_290_0.Size = size;
			this.cbxMinVal.TabIndex = 7;
			Control arg_2B3_0 = this.lblDecimalPlace;
			location = new Point(24, 16);
			arg_2B3_0.Location = location;
			this.lblDecimalPlace.Name = "lblDecimalPlace";
			Control arg_2DA_0 = this.lblDecimalPlace;
			size = new Size(80, 23);
			arg_2DA_0.Size = size;
			this.lblDecimalPlace.TabIndex = 8;
			this.lblDecimalPlace.Text = "小数位数";
			Control arg_310_0 = this.numDecimalPlace;
			location = new Point(144, 16);
			arg_310_0.Location = location;
			this.numDecimalPlace.Name = "numDecimalPlace";
			Control arg_337_0 = this.numDecimalPlace;
			size = new Size(64, 21);
			arg_337_0.Size = size;
			this.numDecimalPlace.TabIndex = 9;
			this.numDecimalPlace.TextAlign = HorizontalAlignment.Right;
			this.Controls.Add(this.numDecimalPlace);
			this.Controls.Add(this.lblDecimalPlace);
			this.Controls.Add(this.cbxMinVal);
			this.Controls.Add(this.numMaxVal);
			this.Controls.Add(this.cbxMaxVal);
			this.Controls.Add(this.chxMaxVal);
			this.Controls.Add(this.numMinVal);
			this.Controls.Add(this.chxMinVal);
			this.Name = "MINumberProperty";
			size = new Size(500, 400);
			this.Size = size;
			((ISupportInitialize)this.numMinVal).EndInit();
			((ISupportInitialize)this.numMaxVal).EndInit();
			((ISupportInitialize)this.numDecimalPlace).EndInit();
			this.ResumeLayout(false);
		}

		private void chxMinVal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chxMinVal.Checked)
			{
				this._MINumber.HasMinVal = true;
				this.cbxMinVal.Enabled = true;
				this.numMinVal.Enabled = true;
			}
			else
			{
				this._MINumber.HasMinVal = false;
				this.cbxMinVal.Enabled = false;
				this.numMinVal.Enabled = false;
			}
		}

		private void chxMaxVal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chxMaxVal.Checked)
			{
				this._MINumber.HasMaxVal = true;
				this.cbxMaxVal.Enabled = true;
				this.numMaxVal.Enabled = true;
			}
			else
			{
				this._MINumber.HasMaxVal = false;
				this.cbxMaxVal.Enabled = false;
				this.numMaxVal.Enabled = false;
			}
		}

		private void cbxMinVal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxMinVal.SelectedIndex == 0)
			{
				this._MINumber.IncludeMin = true;
			}
			else
			{
				this._MINumber.IncludeMin = false;
			}
		}

		private void cbxMaxVal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxMaxVal.SelectedIndex == 0)
			{
				this._MINumber.IncludeMax = true;
			}
			else
			{
				this._MINumber.IncludeMax = false;
			}
		}

		private void numMaxVal_ValueChanged(object sender, EventArgs e)
		{
			this._MINumber.MaxVal = Convert.ToSingle(this.numMaxVal.Value);
		}

		private void numMinVal_ValueChanged(object sender, EventArgs e)
		{
			this._MINumber.MinVal = Convert.ToSingle(this.numMinVal.Value);
		}

		private void numDecimalPlace_ValueChanged(object sender, EventArgs e)
		{
			this._MINumber.DecimalPlace = Convert.ToInt32(this.numDecimalPlace.Value);
			this.numMinVal.DecimalPlaces = this._MINumber.DecimalPlace;
			this.numMaxVal.DecimalPlaces = this._MINumber.DecimalPlace;
			this.numMinVal.Increment = new decimal(Math.Pow(10.0, (double)(checked(0 - this._MINumber.DecimalPlace))));
			this.numMaxVal.Increment = this.numMinVal.Increment;
		}

		private void numDecimalPlace_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numDecimalPlace.Text))
			{
				if (float.Parse(this.numDecimalPlace.Text) < Convert.ToSingle(this.numDecimalPlace.Minimum))
				{
					this.numDecimalPlace.Value = this.numDecimalPlace.Minimum;
				}
				else if (float.Parse(this.numDecimalPlace.Text) > Convert.ToSingle(this.numDecimalPlace.Maximum))
				{
					this.numDecimalPlace.Value = this.numDecimalPlace.Maximum;
				}
				else
				{
					this.numDecimalPlace.Value = new decimal(float.Parse(this.numDecimalPlace.Text));
				}
			}
		}

		private void numMinVal_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numMinVal.Text))
			{
				if (float.Parse(this.numMinVal.Text) < Convert.ToSingle(this.numMinVal.Minimum))
				{
					this.numMinVal.Value = this.numMinVal.Minimum;
				}
				else if (float.Parse(this.numMinVal.Text) > Convert.ToSingle(this.numMinVal.Maximum))
				{
					this.numMinVal.Value = this.numMinVal.Maximum;
				}
				else
				{
					this.numMinVal.Value = new decimal(float.Parse(this.numMinVal.Text));
				}
			}
		}

		private void numMaxVal_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numMaxVal.Text))
			{
				if (float.Parse(this.numMaxVal.Text) < Convert.ToSingle(this.numMaxVal.Minimum))
				{
					this.numMaxVal.Value = this.numMaxVal.Minimum;
				}
				else if (float.Parse(this.numMaxVal.Text) > Convert.ToSingle(this.numMaxVal.Maximum))
				{
					this.numMaxVal.Value = this.numMaxVal.Maximum;
				}
				else
				{
					this.numMaxVal.Value = new decimal(float.Parse(this.numMaxVal.Text));
				}
			}
		}
	}
}
