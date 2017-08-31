using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIMultiChoiceProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("rtbChoices")]
		private RichTextBox _rtbChoices;

		[AccessedThroughProperty("lblChoices")]
		private Label _lblChoices;

		[AccessedThroughProperty("lblSeperator")]
		private Label _lblSeperator;

		[AccessedThroughProperty("txtSeperator")]
		private TextBox _txtSeperator;

		[AccessedThroughProperty("chkWrapChoice")]
		private CheckBox _chkWrapChoice;

		[AccessedThroughProperty("numLineSpace")]
		private NumericUpDown _numLineSpace;

		[AccessedThroughProperty("chkCrossModel")]
		private CheckBox _chkCrossModel;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		private MIMultiChoice _MIMultiChoice;

		private bool _boolUpdate;

		internal virtual RichTextBox rtbChoices
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtbChoices;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rtbChoices_TextChanged);
				if (this._rtbChoices != null)
				{
					this._rtbChoices.TextChanged -= value2;
				}
				this._rtbChoices = value;
				if (this._rtbChoices != null)
				{
					this._rtbChoices.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblChoices
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblChoices;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblChoices = value;
			}
		}

		internal virtual Label lblSeperator
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSeperator;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSeperator = value;
			}
		}

		internal virtual TextBox txtSeperator
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSeperator;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSeperator_TextChanged);
				if (this._txtSeperator != null)
				{
					this._txtSeperator.TextChanged -= value2;
				}
				this._txtSeperator = value;
				if (this._txtSeperator != null)
				{
					this._txtSeperator.TextChanged += value2;
				}
			}
		}

		internal virtual CheckBox chkWrapChoice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkWrapChoice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkWrapChoice_CheckedChanged);
				if (this._chkWrapChoice != null)
				{
					this._chkWrapChoice.CheckedChanged -= value2;
				}
				this._chkWrapChoice = value;
				if (this._chkWrapChoice != null)
				{
					this._chkWrapChoice.CheckedChanged += value2;
				}
			}
		}

		internal virtual NumericUpDown numLineSpace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numLineSpace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numLineSpace_ValueChanged);
				if (this._numLineSpace != null)
				{
					this._numLineSpace.ValueChanged -= value2;
				}
				this._numLineSpace = value;
				if (this._numLineSpace != null)
				{
					this._numLineSpace.ValueChanged += value2;
				}
			}
		}

		internal virtual CheckBox chkCrossModel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkCrossModel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbCrossModel_CheckedChanged);
				if (this._chkCrossModel != null)
				{
					this._chkCrossModel.CheckedChanged -= value2;
				}
				this._chkCrossModel = value;
				if (this._chkCrossModel != null)
				{
					this._chkCrossModel.CheckedChanged += value2;
				}
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

		public MIMultiChoice MIMultiChoice
		{
			get
			{
				return this._MIMultiChoice;
			}
			set
			{
				this._boolUpdate = false;
				this._MIMultiChoice = value;
				this.rtbChoices.Text = "";
				StringEnumerator enumerator = this._MIMultiChoice.Choices.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					this.rtbChoices.AppendText(current + "\n");
				}
				this._boolUpdate = true;
				this.txtSeperator.Text = this._MIMultiChoice.Seperator;
				this.chkWrapChoice.Checked = this._MIMultiChoice.WrapChoice;
				this.numLineSpace.Value = new decimal(this._MIMultiChoice.LineSpace);
				this.chkCrossModel.Checked = this._MIMultiChoice.CrossModel;
			}
		}

		public MIMultiChoiceProperty()
		{
			this._boolUpdate = false;
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
			this.rtbChoices = new RichTextBox();
			this.lblChoices = new Label();
			this.lblSeperator = new Label();
			this.txtSeperator = new TextBox();
			this.chkWrapChoice = new CheckBox();
			this.numLineSpace = new NumericUpDown();
			this.Label1 = new Label();
			this.chkCrossModel = new CheckBox();
			((ISupportInitialize)this.numLineSpace).BeginInit();
			this.SuspendLayout();
			Control arg_7B_0 = this.rtbChoices;
			Point location = new Point(32, 56);
			arg_7B_0.Location = location;
			this.rtbChoices.Name = "rtbChoices";
			Control arg_A8_0 = this.rtbChoices;
			Size size = new Size(312, 272);
			arg_A8_0.Size = size;
			this.rtbChoices.TabIndex = 3;
			this.rtbChoices.Text = "";
			Control arg_DB_0 = this.lblChoices;
			location = new Point(32, 24);
			arg_DB_0.Location = location;
			this.lblChoices.Name = "lblChoices";
			Control arg_105_0 = this.lblChoices;
			size = new Size(200, 16);
			arg_105_0.Size = size;
			this.lblChoices.TabIndex = 2;
			this.lblChoices.Text = "在集合中输入备选项（每行一个）";
			Control arg_13B_0 = this.lblSeperator;
			location = new Point(32, 348);
			arg_13B_0.Location = location;
			this.lblSeperator.Name = "lblSeperator";
			Control arg_162_0 = this.lblSeperator;
			size = new Size(48, 16);
			arg_162_0.Size = size;
			this.lblSeperator.TabIndex = 4;
			this.lblSeperator.Text = "分隔符";
			Control arg_198_0 = this.txtSeperator;
			location = new Point(80, 344);
			arg_198_0.Location = location;
			this.txtSeperator.Name = "txtSeperator";
			Control arg_1BF_0 = this.txtSeperator;
			size = new Size(100, 21);
			arg_1BF_0.Size = size;
			this.txtSeperator.TabIndex = 5;
			Control arg_1E5_0 = this.chkWrapChoice;
			location = new Point(360, 88);
			arg_1E5_0.Location = location;
			this.chkWrapChoice.Name = "chkWrapChoice";
			Control arg_20C_0 = this.chkWrapChoice;
			size = new Size(112, 24);
			arg_20C_0.Size = size;
			this.chkWrapChoice.TabIndex = 6;
			this.chkWrapChoice.Text = "备选项强制换行";
			Control arg_245_0 = this.numLineSpace;
			location = new Point(358, 231);
			arg_245_0.Location = location;
			NumericUpDown arg_271_0 = this.numLineSpace;
			decimal maximum = new decimal(new int[]
			{
				50,
				0,
				0,
				0
			});
			arg_271_0.Maximum = maximum;
			this.numLineSpace.Name = "numLineSpace";
			Control arg_298_0 = this.numLineSpace;
			size = new Size(104, 21);
			arg_298_0.Size = size;
			this.numLineSpace.TabIndex = 7;
			Control arg_2C1_0 = this.Label1;
			location = new Point(358, 207);
			arg_2C1_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_2E8_0 = this.Label1;
			size = new Size(100, 16);
			arg_2E8_0.Size = size;
			this.Label1.TabIndex = 8;
			this.Label1.Text = "备选项行间距";
			this.chkCrossModel.AutoSize = true;
			Control arg_32A_0 = this.chkCrossModel;
			location = new Point(360, 118);
			arg_32A_0.Location = location;
			this.chkCrossModel.Name = "chkCrossModel";
			Control arg_351_0 = this.chkCrossModel;
			size = new Size(84, 16);
			arg_351_0.Size = size;
			this.chkCrossModel.TabIndex = 9;
			this.chkCrossModel.Text = "是否十字框";
			this.chkCrossModel.UseVisualStyleBackColor = true;
			this.Controls.Add(this.chkCrossModel);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.numLineSpace);
			this.Controls.Add(this.chkWrapChoice);
			this.Controls.Add(this.txtSeperator);
			this.Controls.Add(this.lblSeperator);
			this.Controls.Add(this.rtbChoices);
			this.Controls.Add(this.lblChoices);
			this.Name = "MIMultiChoiceProperty";
			size = new Size(500, 400);
			this.Size = size;
			((ISupportInitialize)this.numLineSpace).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void rtbChoices_TextChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this._boolUpdate)
				{
					this._MIMultiChoice.Choices.Clear();
					string[] lines = this.rtbChoices.Lines;
					for (int i = 0; i < lines.Length; i++)
					{
						string str = lines[i];
						if (Operators.CompareString(Strings.Trim(str), "", false) != 0)
						{
							this._MIMultiChoice.Choices.Add(Strings.Trim(str));
						}
					}
				}
			}
		}

		private void txtSeperator_TextChanged(object sender, EventArgs e)
		{
			this._MIMultiChoice.Seperator = Strings.Trim(this.txtSeperator.Text);
		}

		private void chkWrapChoice_CheckedChanged(object sender, EventArgs e)
		{
			this._MIMultiChoice.WrapChoice = this.chkWrapChoice.Checked;
		}

		private void numLineSpace_ValueChanged(object sender, EventArgs e)
		{
			this._MIMultiChoice.LineSpace = Convert.ToInt32(this.numLineSpace.Value);
		}

		private void cbCrossModel_CheckedChanged(object sender, EventArgs e)
		{
			this._MIMultiChoice.CrossModel = this.chkCrossModel.Checked;
		}
	}
}
