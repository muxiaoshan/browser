using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIStringProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblRegExp")]
		private Label _lblRegExp;

		[AccessedThroughProperty("txtRegExp")]
		private TextBox _txtRegExp;

		[AccessedThroughProperty("lblMaxLength")]
		private Label _lblMaxLength;

		[AccessedThroughProperty("txtMaxLength")]
		private TextBox _txtMaxLength;

		private MIString _MIString;

		internal virtual Label lblRegExp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblRegExp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblRegExp = value;
			}
		}

		internal virtual TextBox txtRegExp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtRegExp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtRegExp_TextChanged);
				if (this._txtRegExp != null)
				{
					this._txtRegExp.TextChanged -= value2;
				}
				this._txtRegExp = value;
				if (this._txtRegExp != null)
				{
					this._txtRegExp.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblMaxLength
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblMaxLength;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblMaxLength = value;
			}
		}

		internal virtual TextBox txtMaxLength
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtMaxLength;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtMaxLength_KeyPress);
				EventHandler value3 = new EventHandler(this.txtMaxLength_TextChanged);
				if (this._txtMaxLength != null)
				{
					this._txtMaxLength.KeyPress -= value2;
					this._txtMaxLength.TextChanged -= value3;
				}
				this._txtMaxLength = value;
				if (this._txtMaxLength != null)
				{
					this._txtMaxLength.KeyPress += value2;
					this._txtMaxLength.TextChanged += value3;
				}
			}
		}

		public MIString MIString
		{
			get
			{
				return this._MIString;
			}
			set
			{
				this._MIString = value;
				this.txtRegExp.Text = this._MIString.RegExp;
				if (this._MIString.MaxLength == -1)
				{
					this.txtMaxLength.Text = string.Empty;
				}
				else
				{
					this.txtMaxLength.Text = Conversions.ToString(this._MIString.MaxLength);
				}
			}
		}

		public MIStringProperty()
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
			this.lblRegExp = new Label();
			this.txtRegExp = new TextBox();
			this.lblMaxLength = new Label();
			this.txtMaxLength = new TextBox();
			this.SuspendLayout();
			Control arg_42_0 = this.lblRegExp;
			Point location = new Point(6, 8);
			arg_42_0.Location = location;
			this.lblRegExp.Name = "lblRegExp";
			Control arg_69_0 = this.lblRegExp;
			Size size = new Size(105, 23);
			arg_69_0.Size = size;
			this.lblRegExp.TabIndex = 0;
			this.lblRegExp.Text = "正则表达式：";
			this.lblRegExp.TextAlign = ContentAlignment.MiddleRight;
			Control arg_A9_0 = this.txtRegExp;
			location = new Point(111, 10);
			arg_A9_0.Location = location;
			this.txtRegExp.Name = "txtRegExp";
			Control arg_D3_0 = this.txtRegExp;
			size = new Size(216, 21);
			arg_D3_0.Size = size;
			this.txtRegExp.TabIndex = 1;
			Control arg_F5_0 = this.lblMaxLength;
			location = new Point(6, 40);
			arg_F5_0.Location = location;
			this.lblMaxLength.Name = "lblMaxLength";
			Control arg_11C_0 = this.lblMaxLength;
			size = new Size(105, 23);
			arg_11C_0.Size = size;
			this.lblMaxLength.TabIndex = 2;
			this.lblMaxLength.Text = "最大字数：";
			this.lblMaxLength.TextAlign = ContentAlignment.MiddleRight;
			this.txtMaxLength.ImeMode = ImeMode.Disable;
			Control arg_168_0 = this.txtMaxLength;
			location = new Point(111, 42);
			arg_168_0.Location = location;
			this.txtMaxLength.Name = "txtMaxLength";
			this.txtMaxLength.RightToLeft = RightToLeft.Yes;
			Control arg_19B_0 = this.txtMaxLength;
			size = new Size(48, 21);
			arg_19B_0.Size = size;
			this.txtMaxLength.TabIndex = 3;
			this.Controls.Add(this.txtMaxLength);
			this.Controls.Add(this.lblMaxLength);
			this.Controls.Add(this.txtRegExp);
			this.Controls.Add(this.lblRegExp);
			this.Name = "MIStringProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void txtRegExp_TextChanged(object sender, EventArgs e)
		{
			this._MIString.RegExp = this.txtRegExp.Text;
		}

		private void txtMaxLength_TextChanged(object sender, EventArgs e)
		{
			if (this._MIString == null)
			{
				return;
			}
			if (Operators.CompareString(this.txtMaxLength.Text, string.Empty, false) != 0)
			{
				this.txtMaxLength.Text = int.Parse(this.txtMaxLength.Text).ToString();
				this._MIString.MaxLength = int.Parse(this.txtMaxLength.Text);
				this.txtMaxLength.SelectionStart = Strings.Len(Strings.Trim(this.txtMaxLength.Text));
			}
			else
			{
				this._MIString.MaxLength = -1;
			}
		}

		private void txtMaxLength_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.txtMaxLength.Text.Length < 6 & (char.IsDigit(e.KeyChar) | e.KeyChar == '\b'))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
	}
}
