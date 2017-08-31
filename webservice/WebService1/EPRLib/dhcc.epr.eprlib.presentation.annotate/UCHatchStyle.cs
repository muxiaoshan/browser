using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class UCHatchStyle : UserControl
	{
		public delegate void ValueChangedEventHandler();

		private IContainer components;

		private int[] HatchStyles;

		private HatchStyle _HatchStyle;

		private UCHatchStyle.ValueChangedEventHandler ValueChangedEvent;

		public event UCHatchStyle.ValueChangedEventHandler ValueChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ValueChangedEvent = (UCHatchStyle.ValueChangedEventHandler)Delegate.Combine(this.ValueChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ValueChangedEvent = (UCHatchStyle.ValueChangedEventHandler)Delegate.Remove(this.ValueChangedEvent, value);
			}
		}

		public HatchStyle HatchStyle
		{
			get
			{
				return this._HatchStyle;
			}
			set
			{
				this._HatchStyle = value;
				this.Refresh();
				UCHatchStyle.ValueChangedEventHandler valueChangedEvent = this.ValueChangedEvent;
				if (valueChangedEvent != null)
				{
					valueChangedEvent();
				}
			}
		}

		public UCHatchStyle()
		{
			base.Paint += new PaintEventHandler(this.UCHatchStyle_Paint);
			base.MouseDown += new MouseEventHandler(this.UCHatchStyle_MouseDown);
			this.InitializeComponent();
			this.Init();
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
			this.Name = "UCHatchStyle";
			Size size = new Size(168, 192);
			this.Size = size;
		}

		private void Init()
		{
			this.HatchStyles = (int[])Enum.GetValues(typeof(HatchStyle));
		}

		public UCHatchStyle(HatchStyle val) : this()
		{
			this._HatchStyle = val;
			this.Refresh();
		}

		private void UCHatchStyle_Paint(object sender, PaintEventArgs e)
		{
			int num = 0;
			checked
			{
				do
				{
					int num2 = 0;
					do
					{
						int num3 = num * 7 + num2;
						if (this.HatchStyles[num3] == (int)this._HatchStyle)
						{
							HatchBrush brush = new HatchBrush((HatchStyle)this.HatchStyles[num3], Color.Black, Color.YellowGreen);
							e.Graphics.FillRectangle(brush, num2 * 24 + 2, num * 24 + 2, 20, 20);
						}
						else
						{
							HatchBrush brush2 = new HatchBrush((HatchStyle)this.HatchStyles[num3], Color.Black, this.BackColor);
							e.Graphics.FillRectangle(brush2, num2 * 24 + 2, num * 24 + 2, 20, 20);
						}
						num2++;
					}
					while (num2 <= 6);
					num++;
				}
				while (num <= 7);
			}
		}

		private void UCHatchStyle_MouseDown(object sender, MouseEventArgs e)
		{
			int num = e.X / 24;
			int num2 = e.Y / 24;
			int num3 = checked(num2 * 7 + num);
			this.HatchStyle = (HatchStyle)this.HatchStyles[num3];
		}
	}
}
