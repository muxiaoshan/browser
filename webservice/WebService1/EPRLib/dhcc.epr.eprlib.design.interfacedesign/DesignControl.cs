using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DesignControl : UserControl, ICoordinate
	{
		private bool _Selected;

		private bool _MultiSelected;

		public bool FixedHeight;

		public bool FixedWidth;

		public int ConstWidth;

		public int ConstHeight;

		public int OriginLeft;

		public int OriginTop;

		public int OriginHeight;

		public int OriginWidth;

		private string _TableField;

		private bool _IEnabled;

		public Control PControl;

		private const string defaultFontSizeParamName = "DefaultFontSize";

		private IContainer components;

		public Size OriginSize
		{
			get
			{
				Size result = new Size(this.OriginWidth, this.OriginHeight);
				return result;
			}
			set
			{
				this.OriginWidth = value.Width;
				this.OriginHeight = value.Height;
				checked
				{
					if (this.MultiSelected)
					{
						this.Width = this.OriginWidth + 16;
						this.Height = this.OriginHeight + 16;
					}
					else
					{
						this.Width = this.OriginWidth;
						this.Height = this.OriginHeight;
					}
					this.Refresh();
				}
			}
		}

		public Point OriginLocation
		{
			get
			{
				Point result = new Point(this.OriginLeft, this.OriginTop);
				return result;
			}
			set
			{
				this.OriginLeft = value.X;
				this.OriginTop = value.Y;
				checked
				{
					if (this.MultiSelected)
					{
						this.Left = this.OriginLeft - 8;
						this.Top = this.OriginTop - 8;
					}
					this.Left = this.OriginLeft;
					this.Top = this.OriginTop;
				}
			}
		}

		public bool Selected
		{
			get
			{
				return this._Selected;
			}
			set
			{
				this._Selected = value;
			}
		}

		public bool MultiSelected
		{
			get
			{
				return this._MultiSelected;
			}
			set
			{
				bool multiSelected = this._MultiSelected;
				this._MultiSelected = value;
				checked
				{
					if (value & !multiSelected)
					{
						DesignControl.LockWindowUpdate(this.Handle);
						this.SetBounds(this.Left - 8, this.Top - 8, this.Width + 16, this.Height + 16);
						IntPtr hwndLock;
						DesignControl.LockWindowUpdate(hwndLock);
					}
					else if (!value & multiSelected)
					{
						DesignControl.LockWindowUpdate(this.Handle);
						this.SetBounds(this.Left + 8, this.Top + 8, this.Width - 16, this.Height - 16);
						IntPtr hwndLock;
						DesignControl.LockWindowUpdate(hwndLock);
					}
				}
			}
		}

		public bool IEnabled
		{
			get
			{
				return this._IEnabled;
			}
			set
			{
				this._IEnabled = value;
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long LockWindowUpdate(IntPtr hwndLock);

		public DesignControl()
		{
			base.SizeChanged += new EventHandler(this.DesignControl_SizeChanged);
			base.Paint += new PaintEventHandler(this.DesignControl_Paint);
			base.LocationChanged += new EventHandler(this.DesignControl_LocationChanged);
			this._Selected = false;
			this._MultiSelected = false;
			this._IEnabled = true;
			this.InitializeComponent();
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.OriginLeft = this.Left;
			this.OriginTop = this.Top;
			this.OriginWidth = this.Width;
			this.OriginHeight = this.Height;
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
			this.BackColor = SystemColors.Control;
			this.Name = "DesignControl";
		}

		protected virtual void DrawCustomShape(Graphics g, int x, int y)
		{
		}

		private void DesignControl_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				if (this.MultiSelected)
				{
					Graphics arg_24_0 = graphics;
					Pen arg_24_1 = SystemPens.WindowFrame;
					Rectangle rect = new Rectangle(0, 0, 6, 6);
					arg_24_0.DrawRectangle(arg_24_1, rect);
					Graphics arg_42_0 = graphics;
					Pen arg_42_1 = SystemPens.WindowFrame;
					rect = new Rectangle(this.Width - 7, 0, 6, 6);
					arg_42_0.DrawRectangle(arg_42_1, rect);
					Graphics arg_60_0 = graphics;
					Pen arg_60_1 = SystemPens.WindowFrame;
					rect = new Rectangle(0, this.Height - 7, 6, 6);
					arg_60_0.DrawRectangle(arg_60_1, rect);
					Graphics arg_85_0 = graphics;
					Pen arg_85_1 = SystemPens.WindowFrame;
					rect = new Rectangle(this.Width - 7, this.Height - 7, 6, 6);
					arg_85_0.DrawRectangle(arg_85_1, rect);
					Graphics arg_A5_0 = graphics;
					Pen arg_A5_1 = SystemPens.WindowFrame;
					rect = new Rectangle(this.Width / 2 - 3, 0, 6, 6);
					arg_A5_0.DrawRectangle(arg_A5_1, rect);
					Graphics arg_CC_0 = graphics;
					Pen arg_CC_1 = SystemPens.WindowFrame;
					rect = new Rectangle(this.Width / 2 - 3, this.Height - 7, 6, 6);
					arg_CC_0.DrawRectangle(arg_CC_1, rect);
					Graphics arg_EC_0 = graphics;
					Pen arg_EC_1 = SystemPens.WindowFrame;
					rect = new Rectangle(0, this.Height / 2 - 3, 6, 6);
					arg_EC_0.DrawRectangle(arg_EC_1, rect);
					Graphics arg_113_0 = graphics;
					Pen arg_113_1 = SystemPens.WindowFrame;
					rect = new Rectangle(this.Width - 7, this.Height / 2 - 3, 6, 6);
					arg_113_0.DrawRectangle(arg_113_1, rect);
					if (this.Selected)
					{
						Graphics arg_13A_0 = graphics;
						Brush arg_13A_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(1, 1, 5, 5);
						arg_13A_0.FillRectangle(arg_13A_1, rect);
						Graphics arg_15D_0 = graphics;
						Brush arg_15D_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(this.Width - 6, 1, 5, 5);
						arg_15D_0.FillRectangle(arg_15D_1, rect);
						Graphics arg_180_0 = graphics;
						Brush arg_180_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(1, this.Height - 6, 5, 5);
						arg_180_0.FillRectangle(arg_180_1, rect);
						Graphics arg_1AA_0 = graphics;
						Brush arg_1AA_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(this.Width - 6, this.Height - 6, 5, 5);
						arg_1AA_0.FillRectangle(arg_1AA_1, rect);
						Graphics arg_1CF_0 = graphics;
						Brush arg_1CF_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(this.Width / 2 - 2, 1, 5, 5);
						arg_1CF_0.FillRectangle(arg_1CF_1, rect);
						Graphics arg_1FB_0 = graphics;
						Brush arg_1FB_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(this.Width / 2 - 2, this.Height - 6, 5, 5);
						arg_1FB_0.FillRectangle(arg_1FB_1, rect);
						Graphics arg_220_0 = graphics;
						Brush arg_220_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(1, this.Height / 2 - 2, 5, 5);
						arg_220_0.FillRectangle(arg_220_1, rect);
						Graphics arg_24C_0 = graphics;
						Brush arg_24C_1 = new SolidBrush(SystemColors.ControlDark);
						rect = new Rectangle(this.Width - 6, this.Height / 2 - 2, 5, 5);
						arg_24C_0.FillRectangle(arg_24C_1, rect);
					}
					else
					{
						Graphics arg_26D_0 = graphics;
						Brush arg_26D_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(1, 1, 5, 5);
						arg_26D_0.FillRectangle(arg_26D_1, rect);
						Graphics arg_290_0 = graphics;
						Brush arg_290_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(this.Width - 6, 1, 5, 5);
						arg_290_0.FillRectangle(arg_290_1, rect);
						Graphics arg_2B3_0 = graphics;
						Brush arg_2B3_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(1, this.Height - 6, 5, 5);
						arg_2B3_0.FillRectangle(arg_2B3_1, rect);
						Graphics arg_2DD_0 = graphics;
						Brush arg_2DD_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(this.Width - 6, this.Height - 6, 5, 5);
						arg_2DD_0.FillRectangle(arg_2DD_1, rect);
						Graphics arg_302_0 = graphics;
						Brush arg_302_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(this.Width / 2 - 2, 1, 5, 5);
						arg_302_0.FillRectangle(arg_302_1, rect);
						Graphics arg_32E_0 = graphics;
						Brush arg_32E_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(this.Width / 2 - 2, this.Height - 6, 5, 5);
						arg_32E_0.FillRectangle(arg_32E_1, rect);
						Graphics arg_353_0 = graphics;
						Brush arg_353_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(1, this.Height / 2 - 2, 5, 5);
						arg_353_0.FillRectangle(arg_353_1, rect);
						Graphics arg_37F_0 = graphics;
						Brush arg_37F_1 = new SolidBrush(SystemColors.Window);
						rect = new Rectangle(this.Width - 6, this.Height / 2 - 2, 5, 5);
						arg_37F_0.FillRectangle(arg_37F_1, rect);
					}
					Graphics arg_3A7_0 = graphics;
					Brush arg_3A7_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(8, 0, this.Width / 2 - 11, 7);
					arg_3A7_0.FillRectangle(arg_3A7_1, rect);
					Graphics arg_3CF_0 = graphics;
					Brush arg_3CF_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(0, 8, 7, this.Height / 2 - 11);
					arg_3CF_0.FillRectangle(arg_3CF_1, rect);
					Graphics arg_3FE_0 = graphics;
					Brush arg_3FE_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(8, this.Height - 7, this.Width / 2 - 11, 7);
					arg_3FE_0.FillRectangle(arg_3FE_1, rect);
					Graphics arg_42D_0 = graphics;
					Brush arg_42D_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(this.Width - 7, 8, 7, this.Height / 2 - 11);
					arg_42D_0.FillRectangle(arg_42D_1, rect);
					Graphics arg_45E_0 = graphics;
					Brush arg_45E_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(this.Width / 2 + 4, 0, this.Width / 2 - 11, 7);
					arg_45E_0.FillRectangle(arg_45E_1, rect);
					Graphics arg_48F_0 = graphics;
					Brush arg_48F_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(0, this.Height / 2 + 4, 7, this.Height / 2 - 11);
					arg_48F_0.FillRectangle(arg_48F_1, rect);
					Graphics arg_4C7_0 = graphics;
					Brush arg_4C7_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(this.Width / 2 + 4, this.Height - 7, this.Width / 2 - 11, 7);
					arg_4C7_0.FillRectangle(arg_4C7_1, rect);
					Graphics arg_4FF_0 = graphics;
					Brush arg_4FF_1 = new HatchBrush(HatchStyle.Percent75, SystemColors.Control);
					rect = new Rectangle(this.Width - 7, this.Height / 2 + 4, 7, this.Height / 2 - 11);
					arg_4FF_0.FillRectangle(arg_4FF_1, rect);
					this.DrawCustomShape(graphics, 8, 8);
				}
				else
				{
					this.DrawCustomShape(graphics, 0, 0);
				}
			}
		}

		private void DesignControl_LocationChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.MultiSelected)
				{
					this.OriginTop = this.Top + 8;
					this.OriginLeft = this.Left + 8;
				}
				else
				{
					this.OriginTop = this.Top;
					this.OriginLeft = this.Left;
				}
			}
		}

		private void DesignControl_SizeChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.MultiSelected)
				{
					if (this.FixedHeight & this.Height - 16 != this.ConstHeight)
					{
						this.Height = 16 + this.ConstHeight;
					}
					if (this.FixedWidth & this.Width - 16 != this.ConstWidth)
					{
						this.Width = 16 + this.ConstWidth;
					}
					this.OriginWidth = this.Width - 16;
					this.OriginHeight = this.Height - 16;
				}
				else
				{
					if (this.FixedHeight & this.Height != this.ConstHeight)
					{
						this.Height = this.ConstHeight;
					}
					if (this.FixedWidth & this.Width != this.ConstWidth)
					{
						this.Width = this.ConstWidth;
					}
					this.OriginWidth = this.Width;
					this.OriginHeight = this.Height;
				}
			}
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			bool flag;
			return !(keyData == Keys.Up | keyData == Keys.Left | keyData == Keys.Down | keyData == Keys.Right) && flag;
		}

		private void SetDefaultFont()
		{
			double num = 9.0;
			double num2 = Conversions.ToDouble(SysOptionManager.GetSysOptionValue("DefaultFontSize", "9"));
			if (num2 != 0.0)
			{
				num = num2;
			}
			this.Font = new Font(this.Font.Name, (float)num);
		}

		public virtual void XMLSerialize(XmlWriter writer)
		{
		}

		public virtual void XMLDeserialize(XmlReader reader)
		{
		}

		public void ShowCoordinate(Control ctrl, Point p)
		{
			if (this.Parent is ICoordinate)
			{
				ICoordinate arg_4D_0 = (ICoordinate)this.Parent;
				Point p2 = checked(new Point(p.X + this.Location.X, p.Y + this.Location.Y));
				arg_4D_0.ShowCoordinate(ctrl, p2);
			}
		}
	}
}
