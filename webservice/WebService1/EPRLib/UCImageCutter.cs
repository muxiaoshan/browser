using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[DesignerGenerated]
public class UCImageCutter : Control
{
	public enum ArrowType
	{
		UP,
		DOWN,
		Left,
		Right,
		LEFTUP,
		LEFTDOWN,
		RIGHTUP,
		RIGHTDOWN,
		NONE
	}

	private IContainer components;

	private Rectangle recArea;

	private Rectangle[] recArrow;

	private Point m_MousePoint;

	private Point m_LastPoint;

	private Size m_Size;

	private int m_Blank;

	private UCImageCutter.ArrowType arrow;

	public int Blank
	{
		get
		{
			return this.m_Blank;
		}
	}

	public Rectangle CurrentArea
	{
		get
		{
			return this.recArea;
		}
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
		this.SuspendLayout();
		this.ResumeLayout(false);
	}

	public UCImageCutter()
	{
		this.recArrow = new Rectangle[9];
		this.m_Blank = 8;
		this.arrow = UCImageCutter.ArrowType.NONE;
		this.InitializeComponent();
		this.Init();
	}

	private void Init()
	{
		this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		this.SetStyle(ControlStyles.Opaque, false);
		this.BackColor = Color.Transparent;
		this.SetStyle(ControlStyles.UserPaint, true);
		this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		this.SetStyle(ControlStyles.DoubleBuffer, true);
		this.UpdateStyles();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		int num = 6;
		Rectangle[] arg_67_0_cp_0 = this.recArrow;
		int arg_67_0_cp_1 = 0;
		checked
		{
			Point point = new Point((int)Math.Round(unchecked((double)this.Width / 2.0 - (double)num / 2.0)), (int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)));
			Point arg_67_1 = point;
			Size size = new Size(num, num);
			arg_67_0_cp_0[arg_67_0_cp_1] = new Rectangle(arg_67_1, size);
			Rectangle[] arg_D1_0_cp_0 = this.recArrow;
			int arg_D1_0_cp_1 = 1;
			point = new Point((int)Math.Round(unchecked((double)this.Width / 2.0 - (double)num / 2.0)), (int)Math.Round(unchecked((double)(checked(this.Height - this.m_Blank)) - (double)num / 2.0)));
			Point arg_D1_1 = point;
			size = new Size(num, num);
			arg_D1_0_cp_0[arg_D1_0_cp_1] = new Rectangle(arg_D1_1, size);
			Rectangle[] arg_134_0_cp_0 = this.recArrow;
			int arg_134_0_cp_1 = 2;
			point = new Point((int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)), (int)Math.Round(unchecked((double)this.Height / 2.0 - (double)num / 2.0)));
			Point arg_134_1 = point;
			size = new Size(num, num);
			arg_134_0_cp_0[arg_134_0_cp_1] = new Rectangle(arg_134_1, size);
			Rectangle[] arg_19E_0_cp_0 = this.recArrow;
			int arg_19E_0_cp_1 = 3;
			point = new Point((int)Math.Round(unchecked((double)(checked(this.Width - this.m_Blank)) - (double)num / 2.0)), (int)Math.Round(unchecked((double)this.Height / 2.0 - (double)num / 2.0)));
			Point arg_19E_1 = point;
			size = new Size(num, num);
			arg_19E_0_cp_0[arg_19E_0_cp_1] = new Rectangle(arg_19E_1, size);
			Rectangle[] arg_1F7_0_cp_0 = this.recArrow;
			int arg_1F7_0_cp_1 = 4;
			point = new Point((int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)), (int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)));
			Point arg_1F7_1 = point;
			size = new Size(num, num);
			arg_1F7_0_cp_0[arg_1F7_0_cp_1] = new Rectangle(arg_1F7_1, size);
			Rectangle[] arg_257_0_cp_0 = this.recArrow;
			int arg_257_0_cp_1 = 5;
			point = new Point((int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)), (int)Math.Round(unchecked((double)(checked(this.Height - this.m_Blank)) - (double)num / 2.0)));
			Point arg_257_1 = point;
			size = new Size(num, num);
			arg_257_0_cp_0[arg_257_0_cp_1] = new Rectangle(arg_257_1, size);
			Rectangle[] arg_2B7_0_cp_0 = this.recArrow;
			int arg_2B7_0_cp_1 = 6;
			point = new Point((int)Math.Round(unchecked((double)(checked(this.Width - this.m_Blank)) - (double)num / 2.0)), (int)Math.Round(unchecked((double)this.m_Blank - (double)num / 2.0)));
			Point arg_2B7_1 = point;
			size = new Size(num, num);
			arg_2B7_0_cp_0[arg_2B7_0_cp_1] = new Rectangle(arg_2B7_1, size);
			Rectangle[] arg_31E_0_cp_0 = this.recArrow;
			int arg_31E_0_cp_1 = 7;
			point = new Point((int)Math.Round(unchecked((double)(checked(this.Width - this.m_Blank)) - (double)num / 2.0)), (int)Math.Round(unchecked((double)(checked(this.Height - this.m_Blank)) - (double)num / 2.0)));
			Point arg_31E_1 = point;
			size = new Size(num, num);
			arg_31E_0_cp_0[arg_31E_0_cp_1] = new Rectangle(arg_31E_1, size);
			Rectangle[] array = this.recArrow;
			for (int i = 0; i < array.Length; i++)
			{
				Rectangle rect = array[i];
				e.Graphics.DrawRectangle(Pens.Red, rect);
			}
			point = new Point(8, 8);
			Point arg_38A_1 = point;
			size = new Size(this.Width - 16, this.Height - 16);
			this.recArea = new Rectangle(arg_38A_1, size);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color color = Color.FromArgb(50, Color.Red);
			SolidBrush brush = new SolidBrush(color);
			e.Graphics.FillRectangle(brush, this.recArea);
			e.Graphics.DrawRectangle(Pens.Red, this.recArea);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		this.arrow = UCImageCutter.ArrowType.NONE;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.m_LastPoint = this.Location;
		this.m_MousePoint = this.PointToScreen(e.Location);
		this.m_Size = this.Size;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (this.arrow != UCImageCutter.ArrowType.NONE)
		{
			this.ReSized(e);
			return;
		}
		if (e.Y <= this.recArrow[4].Bottom && e.Y >= this.recArrow[4].Top && e.X >= this.recArrow[4].Left && e.X <= this.recArrow[4].Right)
		{
			this.Cursor = Cursors.SizeNWSE;
		}
		else if (e.Y <= this.recArrow[5].Bottom && e.Y >= this.recArrow[5].Top && e.X >= this.recArrow[5].Left && e.X <= this.recArrow[5].Right)
		{
			this.Cursor = Cursors.SizeNESW;
		}
		else if (e.Y <= this.recArrow[6].Bottom && e.Y >= this.recArrow[6].Top && e.X >= this.recArrow[6].Left && e.X <= this.recArrow[6].Right)
		{
			this.Cursor = Cursors.SizeNESW;
		}
		else if (e.Y <= this.recArrow[7].Bottom && e.Y >= this.recArrow[7].Top && e.X >= this.recArrow[7].Left && e.X <= this.recArrow[7].Right)
		{
			this.Cursor = Cursors.SizeNWSE;
		}
		else if (e.Y <= this.recArrow[0].Bottom && e.Y >= this.recArrow[0].Top)
		{
			this.Cursor = Cursors.SizeNS;
		}
		else if (e.Y <= this.recArrow[1].Bottom && e.Y >= this.recArrow[1].Top)
		{
			this.Cursor = Cursors.SizeNS;
		}
		else if (e.X >= this.recArrow[2].Left && e.X <= this.recArrow[2].Right)
		{
			this.Cursor = Cursors.SizeWE;
		}
		else if (e.X >= this.recArrow[3].Left && e.X <= this.recArrow[3].Right)
		{
			this.Cursor = Cursors.SizeWE;
		}
		else
		{
			this.Cursor = Cursors.SizeAll;
		}
		checked
		{
			if (e.Button == MouseButtons.Left)
			{
				Point point = this.PointToScreen(e.Location);
				Point lastPoint = this.m_LastPoint;
				if (e.Y <= this.recArrow[4].Bottom && e.Y >= this.recArrow[4].Top && e.X >= this.recArrow[4].Left && e.X <= this.recArrow[4].Right)
				{
					this.arrow = UCImageCutter.ArrowType.LEFTUP;
				}
				else if (e.Y <= this.recArrow[5].Bottom && e.Y >= this.recArrow[5].Top && e.X >= this.recArrow[5].Left && e.X <= this.recArrow[5].Right)
				{
					this.arrow = UCImageCutter.ArrowType.LEFTDOWN;
				}
				else if (e.Y <= this.recArrow[6].Bottom && e.Y >= this.recArrow[6].Top && e.X >= this.recArrow[6].Left && e.X <= this.recArrow[6].Right)
				{
					this.arrow = UCImageCutter.ArrowType.RIGHTUP;
				}
				else if (e.Y <= this.recArrow[7].Bottom && e.Y >= this.recArrow[7].Top && e.X >= this.recArrow[7].Left && e.X <= this.recArrow[7].Right)
				{
					this.arrow = UCImageCutter.ArrowType.RIGHTDOWN;
				}
				else if (e.Y <= this.recArrow[0].Bottom && e.Y >= this.recArrow[0].Top)
				{
					this.arrow = UCImageCutter.ArrowType.UP;
				}
				else if (e.Y <= this.recArrow[1].Bottom && e.Y >= this.recArrow[1].Top)
				{
					this.arrow = UCImageCutter.ArrowType.DOWN;
				}
				else if (e.X >= this.recArrow[2].Left && e.X <= this.recArrow[2].Right)
				{
					this.arrow = UCImageCutter.ArrowType.Left;
				}
				else if (e.X >= this.recArrow[3].Left && e.X <= this.recArrow[3].Right)
				{
					this.arrow = UCImageCutter.ArrowType.Right;
				}
				else
				{
					this.arrow = UCImageCutter.ArrowType.NONE;
				}
				lastPoint.Offset(point.X - this.m_MousePoint.X, point.Y - this.m_MousePoint.Y);
				if (this.arrow != UCImageCutter.ArrowType.NONE)
				{
					this.ReSized(e);
				}
				else
				{
					this.Location = lastPoint;
					this.Refresh();
				}
			}
		}
	}

	public void ReSized(MouseEventArgs e)
	{
		Point point = this.PointToScreen(e.Location);
		Point lastPoint = this.m_LastPoint;
		checked
		{
			lastPoint.Offset(point.X - this.m_MousePoint.X, point.Y - this.m_MousePoint.Y);
			switch (this.arrow)
			{
			case UCImageCutter.ArrowType.UP:
			{
				this.Height = this.m_Size.Height - (point.Y - this.m_MousePoint.Y);
				Point location = new Point(this.m_LastPoint.X, lastPoint.Y);
				this.Location = location;
				break;
			}
			case UCImageCutter.ArrowType.DOWN:
				this.Height = this.m_Size.Height + (point.Y - this.m_MousePoint.Y);
				break;
			case UCImageCutter.ArrowType.Left:
			{
				this.Width = this.m_Size.Width - (point.X - this.m_MousePoint.X);
				Point location = new Point(lastPoint.X, this.m_LastPoint.Y);
				this.Location = location;
				break;
			}
			case UCImageCutter.ArrowType.Right:
				this.Width = this.m_Size.Width + (point.X - this.m_MousePoint.X);
				break;
			case UCImageCutter.ArrowType.LEFTUP:
			{
				this.Width = this.m_Size.Width - (point.X - this.m_MousePoint.X);
				this.Height = this.m_Size.Height - (point.Y - this.m_MousePoint.Y);
				Point location = new Point(lastPoint.X, lastPoint.Y);
				this.Location = location;
				break;
			}
			case UCImageCutter.ArrowType.LEFTDOWN:
			{
				this.Width = this.m_Size.Width - (point.X - this.m_MousePoint.X);
				this.Height = this.m_Size.Height + (point.Y - this.m_MousePoint.Y);
				Point location = new Point(lastPoint.X, this.m_LastPoint.Y);
				this.Location = location;
				break;
			}
			case UCImageCutter.ArrowType.RIGHTUP:
			{
				this.Width = this.m_Size.Width + (point.X - this.m_MousePoint.X);
				this.Height = this.m_Size.Height - (point.Y - this.m_MousePoint.Y);
				Point location = new Point(this.m_LastPoint.X, lastPoint.Y);
				this.Location = location;
				break;
			}
			case UCImageCutter.ArrowType.RIGHTDOWN:
				this.Width = this.m_Size.Width + (point.X - this.m_MousePoint.X);
				this.Height = this.m_Size.Height + (point.Y - this.m_MousePoint.Y);
				break;
			}
			this.Refresh();
		}
	}
}
