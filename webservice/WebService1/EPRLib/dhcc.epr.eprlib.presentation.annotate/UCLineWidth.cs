using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class UCLineWidth : UserControl
	{
		public delegate void ValueChangedEventHandler();

		private IContainer components;

		[AccessedThroughProperty("line1")]
		private Label _line1;

		[AccessedThroughProperty("Line2")]
		private Label _Line2;

		[AccessedThroughProperty("Line3")]
		private Label _Line3;

		[AccessedThroughProperty("Line4")]
		private Label _Line4;

		[AccessedThroughProperty("Line5")]
		private Label _Line5;

		[AccessedThroughProperty("Line6")]
		private Label _Line6;

		[AccessedThroughProperty("Line7")]
		private Label _Line7;

		private int _LineWidth;

		private UCLineWidth.ValueChangedEventHandler ValueChangedEvent;

		public event UCLineWidth.ValueChangedEventHandler ValueChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ValueChangedEvent = (UCLineWidth.ValueChangedEventHandler)Delegate.Combine(this.ValueChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ValueChangedEvent = (UCLineWidth.ValueChangedEventHandler)Delegate.Remove(this.ValueChangedEvent, value);
			}
		}

		internal virtual Label line1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._line1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line1_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line1_Paint);
				if (this._line1 != null)
				{
					this._line1.Click -= value2;
					this._line1.Paint -= value3;
				}
				this._line1 = value;
				if (this._line1 != null)
				{
					this._line1.Click += value2;
					this._line1.Paint += value3;
				}
			}
		}

		internal virtual Label Line2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line2_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line2_Paint);
				if (this._Line2 != null)
				{
					this._Line2.Click -= value2;
					this._Line2.Paint -= value3;
				}
				this._Line2 = value;
				if (this._Line2 != null)
				{
					this._Line2.Click += value2;
					this._Line2.Paint += value3;
				}
			}
		}

		internal virtual Label Line3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line3_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line3_Paint);
				if (this._Line3 != null)
				{
					this._Line3.Click -= value2;
					this._Line3.Paint -= value3;
				}
				this._Line3 = value;
				if (this._Line3 != null)
				{
					this._Line3.Click += value2;
					this._Line3.Paint += value3;
				}
			}
		}

		internal virtual Label Line4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line4_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line4_Paint);
				if (this._Line4 != null)
				{
					this._Line4.Click -= value2;
					this._Line4.Paint -= value3;
				}
				this._Line4 = value;
				if (this._Line4 != null)
				{
					this._Line4.Click += value2;
					this._Line4.Paint += value3;
				}
			}
		}

		internal virtual Label Line5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line5_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line5_Paint);
				if (this._Line5 != null)
				{
					this._Line5.Click -= value2;
					this._Line5.Paint -= value3;
				}
				this._Line5 = value;
				if (this._Line5 != null)
				{
					this._Line5.Click += value2;
					this._Line5.Paint += value3;
				}
			}
		}

		internal virtual Label Line6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.line6_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line6_Paint);
				if (this._Line6 != null)
				{
					this._Line6.Click -= value2;
					this._Line6.Paint -= value3;
				}
				this._Line6 = value;
				if (this._Line6 != null)
				{
					this._Line6.Click += value2;
					this._Line6.Paint += value3;
				}
			}
		}

		internal virtual Label Line7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Line7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.line7_Paint);
				EventHandler value3 = new EventHandler(this.line7_Click);
				if (this._Line7 != null)
				{
					this._Line7.Paint -= value2;
					this._Line7.Click -= value3;
				}
				this._Line7 = value;
				if (this._Line7 != null)
				{
					this._Line7.Paint += value2;
					this._Line7.Click += value3;
				}
			}
		}

		public int LineWidth
		{
			get
			{
				return this._LineWidth;
			}
			set
			{
				this._LineWidth = value;
				this.Refresh();
				UCLineWidth.ValueChangedEventHandler valueChangedEvent = this.ValueChangedEvent;
				if (valueChangedEvent != null)
				{
					valueChangedEvent();
				}
			}
		}

		public UCLineWidth()
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
			this.line1 = new Label();
			this.Line2 = new Label();
			this.Line3 = new Label();
			this.Line4 = new Label();
			this.Line5 = new Label();
			this.Line6 = new Label();
			this.Line7 = new Label();
			this.SuspendLayout();
			this.line1.Dock = DockStyle.Top;
			Control arg_6F_0 = this.line1;
			Point location = new Point(0, 0);
			arg_6F_0.Location = location;
			this.line1.Name = "line1";
			Control arg_96_0 = this.line1;
			Size size = new Size(120, 16);
			arg_96_0.Size = size;
			this.line1.TabIndex = 1;
			this.Line2.Dock = DockStyle.Top;
			Control arg_C4_0 = this.Line2;
			location = new Point(0, 16);
			arg_C4_0.Location = location;
			this.Line2.Name = "Line2";
			Control arg_EB_0 = this.Line2;
			size = new Size(120, 16);
			arg_EB_0.Size = size;
			this.Line2.TabIndex = 2;
			this.Line3.Dock = DockStyle.Top;
			Control arg_119_0 = this.Line3;
			location = new Point(0, 32);
			arg_119_0.Location = location;
			this.Line3.Name = "Line3";
			Control arg_140_0 = this.Line3;
			size = new Size(120, 16);
			arg_140_0.Size = size;
			this.Line3.TabIndex = 3;
			this.Line4.Dock = DockStyle.Top;
			Control arg_16E_0 = this.Line4;
			location = new Point(0, 48);
			arg_16E_0.Location = location;
			this.Line4.Name = "Line4";
			Control arg_195_0 = this.Line4;
			size = new Size(120, 16);
			arg_195_0.Size = size;
			this.Line4.TabIndex = 4;
			this.Line5.Dock = DockStyle.Top;
			Control arg_1C3_0 = this.Line5;
			location = new Point(0, 64);
			arg_1C3_0.Location = location;
			this.Line5.Name = "Line5";
			Control arg_1EA_0 = this.Line5;
			size = new Size(120, 16);
			arg_1EA_0.Size = size;
			this.Line5.TabIndex = 5;
			this.Line6.Dock = DockStyle.Top;
			Control arg_218_0 = this.Line6;
			location = new Point(0, 80);
			arg_218_0.Location = location;
			this.Line6.Name = "Line6";
			Control arg_23F_0 = this.Line6;
			size = new Size(120, 16);
			arg_23F_0.Size = size;
			this.Line6.TabIndex = 6;
			this.Line7.Dock = DockStyle.Top;
			Control arg_26D_0 = this.Line7;
			location = new Point(0, 96);
			arg_26D_0.Location = location;
			this.Line7.Name = "Line7";
			Control arg_294_0 = this.Line7;
			size = new Size(120, 16);
			arg_294_0.Size = size;
			this.Line7.TabIndex = 7;
			this.Controls.Add(this.Line7);
			this.Controls.Add(this.Line6);
			this.Controls.Add(this.Line5);
			this.Controls.Add(this.Line4);
			this.Controls.Add(this.Line3);
			this.Controls.Add(this.Line2);
			this.Controls.Add(this.line1);
			this.Name = "UCLineWidth";
			size = new Size(120, 112);
			this.Size = size;
			this.ResumeLayout(false);
		}

		public UCLineWidth(int val) : this()
		{
			this._LineWidth = val;
			this.Refresh();
		}

		private void line1_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 1)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line1.Width, this.line1.Height);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line1.Width, this.line1.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
				}
			}
		}

		private void line2_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 2)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line2.Width, this.Line2.Height);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line2.Width, this.Line2.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
				}
			}
		}

		private void line3_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 3)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line3.Width, this.Line3.Height);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line3.Width, this.Line3.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.Black, 8, 9, this.Width - 14, 9);
				}
			}
		}

		private void line4_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 4)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line4.Width, this.Line4.Height);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line4.Width, this.Line4.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.Black, 8, 9, this.Width - 14, 9);
				}
			}
		}

		private void line5_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 5)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line5.Width, this.Line5.Height);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.White, 8, 10, this.Width - 14, 10);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line5.Width, this.Line5.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.Black, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.Black, 8, 10, this.Width - 14, 10);
				}
			}
		}

		private void line6_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 6)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line6.Width, this.Line6.Height);
					e.Graphics.DrawLine(Pens.White, 8, 5, this.Width - 14, 5);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.White, 8, 10, this.Width - 14, 10);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line6.Width, this.Line6.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 5, this.Width - 14, 5);
					e.Graphics.DrawLine(Pens.Black, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.Black, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.Black, 8, 10, this.Width - 14, 10);
				}
			}
		}

		private void line7_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 7)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Line7.Width, this.Line7.Height);
					e.Graphics.DrawLine(Pens.White, 8, 5, this.Width - 14, 5);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.White, 8, 10, this.Width - 14, 10);
					e.Graphics.DrawLine(Pens.White, 8, 11, this.Width - 14, 11);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.Line7.Width, this.Line7.Height);
					e.Graphics.DrawLine(Pens.Black, 8, 5, this.Width - 14, 5);
					e.Graphics.DrawLine(Pens.Black, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.Black, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.Black, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.Black, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.Black, 8, 10, this.Width - 14, 10);
					e.Graphics.DrawLine(Pens.Black, 8, 11, this.Width - 14, 11);
				}
			}
		}

		private void line0_Click(object sender, EventArgs e)
		{
			this.LineWidth = 0;
		}

		private void line1_Click(object sender, EventArgs e)
		{
			this.LineWidth = 1;
		}

		private void line2_Click(object sender, EventArgs e)
		{
			this.LineWidth = 2;
		}

		private void line3_Click(object sender, EventArgs e)
		{
			this.LineWidth = 3;
		}

		private void line4_Click(object sender, EventArgs e)
		{
			this.LineWidth = 4;
		}

		private void line5_Click(object sender, EventArgs e)
		{
			this.LineWidth = 5;
		}

		private void line6_Click(object sender, EventArgs e)
		{
			this.LineWidth = 6;
		}

		private void line7_Click(object sender, EventArgs e)
		{
			this.LineWidth = 7;
		}
	}
}
