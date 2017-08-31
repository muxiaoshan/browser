using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class UCBorderLineWidth : UserControl
	{
		public delegate void ValueChangedEventHandler();

		private IContainer components;

		[AccessedThroughProperty("Line7")]
		private Label _Line7;

		[AccessedThroughProperty("Line6")]
		private Label _Line6;

		[AccessedThroughProperty("Line5")]
		private Label _Line5;

		[AccessedThroughProperty("Line4")]
		private Label _Line4;

		[AccessedThroughProperty("Line3")]
		private Label _Line3;

		[AccessedThroughProperty("Line2")]
		private Label _Line2;

		[AccessedThroughProperty("line1")]
		private Label _line1;

		[AccessedThroughProperty("line0")]
		private Label _line0;

		private int _LineWidth;

		private UCBorderLineWidth.ValueChangedEventHandler ValueChangedEvent;

		public event UCBorderLineWidth.ValueChangedEventHandler ValueChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ValueChangedEvent = (UCBorderLineWidth.ValueChangedEventHandler)Delegate.Combine(this.ValueChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ValueChangedEvent = (UCBorderLineWidth.ValueChangedEventHandler)Delegate.Remove(this.ValueChangedEvent, value);
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
				EventHandler value2 = new EventHandler(this.line7_Click);
				PaintEventHandler value3 = new PaintEventHandler(this.line7_Paint);
				if (this._Line7 != null)
				{
					this._Line7.Click -= value2;
					this._Line7.Paint -= value3;
				}
				this._Line7 = value;
				if (this._Line7 != null)
				{
					this._Line7.Click += value2;
					this._Line7.Paint += value3;
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

		internal virtual Label line0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._line0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.line0_Paint);
				EventHandler value3 = new EventHandler(this.line0_Click);
				if (this._line0 != null)
				{
					this._line0.Paint -= value2;
					this._line0.Click -= value3;
				}
				this._line0 = value;
				if (this._line0 != null)
				{
					this._line0.Paint += value2;
					this._line0.Click += value3;
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
				UCBorderLineWidth.ValueChangedEventHandler valueChangedEvent = this.ValueChangedEvent;
				if (valueChangedEvent != null)
				{
					valueChangedEvent();
				}
			}
		}

		public UCBorderLineWidth()
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
			this.Line7 = new Label();
			this.Line6 = new Label();
			this.Line5 = new Label();
			this.Line4 = new Label();
			this.Line3 = new Label();
			this.Line2 = new Label();
			this.line1 = new Label();
			this.line0 = new Label();
			this.SuspendLayout();
			this.Line7.Dock = DockStyle.Top;
			Control arg_7B_0 = this.Line7;
			Point location = new Point(0, 112);
			arg_7B_0.Location = location;
			this.Line7.Name = "Line7";
			Control arg_A2_0 = this.Line7;
			Size size = new Size(120, 16);
			arg_A2_0.Size = size;
			this.Line7.TabIndex = 15;
			this.Line6.Dock = DockStyle.Top;
			Control arg_D1_0 = this.Line6;
			location = new Point(0, 96);
			arg_D1_0.Location = location;
			this.Line6.Name = "Line6";
			Control arg_F8_0 = this.Line6;
			size = new Size(120, 16);
			arg_F8_0.Size = size;
			this.Line6.TabIndex = 14;
			this.Line5.Dock = DockStyle.Top;
			Control arg_127_0 = this.Line5;
			location = new Point(0, 80);
			arg_127_0.Location = location;
			this.Line5.Name = "Line5";
			Control arg_14E_0 = this.Line5;
			size = new Size(120, 16);
			arg_14E_0.Size = size;
			this.Line5.TabIndex = 13;
			this.Line4.Dock = DockStyle.Top;
			Control arg_17D_0 = this.Line4;
			location = new Point(0, 64);
			arg_17D_0.Location = location;
			this.Line4.Name = "Line4";
			Control arg_1A4_0 = this.Line4;
			size = new Size(120, 16);
			arg_1A4_0.Size = size;
			this.Line4.TabIndex = 12;
			this.Line3.Dock = DockStyle.Top;
			Control arg_1D3_0 = this.Line3;
			location = new Point(0, 48);
			arg_1D3_0.Location = location;
			this.Line3.Name = "Line3";
			Control arg_1FA_0 = this.Line3;
			size = new Size(120, 16);
			arg_1FA_0.Size = size;
			this.Line3.TabIndex = 11;
			this.Line2.Dock = DockStyle.Top;
			Control arg_229_0 = this.Line2;
			location = new Point(0, 32);
			arg_229_0.Location = location;
			this.Line2.Name = "Line2";
			Control arg_250_0 = this.Line2;
			size = new Size(120, 16);
			arg_250_0.Size = size;
			this.Line2.TabIndex = 10;
			this.line1.Dock = DockStyle.Top;
			Control arg_27F_0 = this.line1;
			location = new Point(0, 16);
			arg_27F_0.Location = location;
			this.line1.Name = "line1";
			Control arg_2A6_0 = this.line1;
			size = new Size(120, 16);
			arg_2A6_0.Size = size;
			this.line1.TabIndex = 9;
			this.line0.Dock = DockStyle.Top;
			Control arg_2D4_0 = this.line0;
			location = new Point(0, 0);
			arg_2D4_0.Location = location;
			this.line0.Name = "line0";
			Control arg_2FB_0 = this.line0;
			size = new Size(120, 16);
			arg_2FB_0.Size = size;
			this.line0.TabIndex = 8;
			this.Controls.Add(this.Line7);
			this.Controls.Add(this.Line6);
			this.Controls.Add(this.Line5);
			this.Controls.Add(this.Line4);
			this.Controls.Add(this.Line3);
			this.Controls.Add(this.Line2);
			this.Controls.Add(this.line1);
			this.Controls.Add(this.line0);
			this.Name = "UCBorderLineWidth";
			size = new Size(120, 128);
			this.Size = size;
			this.ResumeLayout(false);
		}

		public UCBorderLineWidth(int val) : this()
		{
			this._LineWidth = val;
			this.Refresh();
		}

		private void line0_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 0)
				{
					e.Graphics.FillRectangle(Brushes.YellowGreen, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
			}
		}

		private void line1_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.LineWidth == 1)
				{
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.White, 8, 10, this.Width - 14, 10);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
					e.Graphics.DrawLine(Pens.White, 8, 5, this.Width - 14, 5);
					e.Graphics.DrawLine(Pens.White, 8, 6, this.Width - 14, 6);
					e.Graphics.DrawLine(Pens.White, 8, 7, this.Width - 14, 7);
					e.Graphics.DrawLine(Pens.White, 8, 8, this.Width - 14, 8);
					e.Graphics.DrawLine(Pens.White, 8, 9, this.Width - 14, 9);
					e.Graphics.DrawLine(Pens.White, 8, 10, this.Width - 14, 10);
				}
				else
				{
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.line0.Width, this.line0.Height);
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
					e.Graphics.FillRectangle(SystemBrushes.Control, 0, 0, this.line0.Width, this.line0.Height);
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
