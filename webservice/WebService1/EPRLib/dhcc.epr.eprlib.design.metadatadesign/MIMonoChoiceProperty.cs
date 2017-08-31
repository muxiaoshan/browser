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
	public class MIMonoChoiceProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblChoices")]
		private Label _lblChoices;

		[AccessedThroughProperty("rtbChoices")]
		private RichTextBox _rtbChoices;

		private MIMonoChoice _MIMonoChoice;

		private bool _boolUpdate;

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

		public MIMonoChoice MIMonoChoice
		{
			get
			{
				return this._MIMonoChoice;
			}
			set
			{
				this._boolUpdate = false;
				this._MIMonoChoice = value;
				this.rtbChoices.Text = "";
				StringEnumerator enumerator = this._MIMonoChoice.Choices.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					this.rtbChoices.AppendText(current + "\n");
				}
				this._boolUpdate = true;
			}
		}

		public MIMonoChoiceProperty()
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
			this.lblChoices = new Label();
			this.rtbChoices = new RichTextBox();
			this.SuspendLayout();
			Control arg_2E_0 = this.lblChoices;
			Point location = new Point(32, 24);
			arg_2E_0.Location = location;
			this.lblChoices.Name = "lblChoices";
			Control arg_58_0 = this.lblChoices;
			Size size = new Size(200, 16);
			arg_58_0.Size = size;
			this.lblChoices.TabIndex = 0;
			this.lblChoices.Text = "在集合中输入备选项（每行一个）";
			Control arg_8B_0 = this.rtbChoices;
			location = new Point(32, 56);
			arg_8B_0.Location = location;
			this.rtbChoices.Name = "rtbChoices";
			Control arg_B8_0 = this.rtbChoices;
			size = new Size(312, 272);
			arg_B8_0.Size = size;
			this.rtbChoices.TabIndex = 1;
			this.rtbChoices.Text = "";
			this.Controls.Add(this.rtbChoices);
			this.Controls.Add(this.lblChoices);
			this.Name = "MIMonoChoiceProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void rtbChoices_TextChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this._boolUpdate)
				{
					this._MIMonoChoice.Choices.Clear();
					string[] lines = this.rtbChoices.Lines;
					for (int i = 0; i < lines.Length; i++)
					{
						string str = lines[i];
						if (Operators.CompareString(Strings.Trim(str), "", false) != 0)
						{
							this._MIMonoChoice.Choices.Add(Strings.Trim(str));
						}
					}
				}
			}
		}
	}
}
