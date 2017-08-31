using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	[DefaultProperty("ParentRichTextBox")]
	public class Linenum : Control
	{
		private class LineNumberItem
		{
			internal int LineNumber;

			internal Rectangle Rectangle;

			internal LineNumberItem(int zLineNumber, Rectangle zRectangle)
			{
				this.LineNumber = zLineNumber;
				this.Rectangle = zRectangle;
			}
		}

		public enum LineNumberDockSide : byte
		{
			None,
			Left,
			Right,
			Height = 4
		}

		private RichTextBoxEx withEventsField_zParent;

		private Timer withEventsField_zTimer = new Timer();

		private bool zAutoSizing = true;

		private Size zAutoSizing_Size = new Size(0, 0);

		private Rectangle zContentRectangle;

		private Linenum.LineNumberDockSide zDockSide = Linenum.LineNumberDockSide.Left;

		private bool zParentIsScrolling;

		private bool zLineNumbers_Show = true;

		private bool zLineNumbers_ShowLeadingZeroes;

		private bool zLineNumbers_ShowAsHexadecimal;

		private bool zLineNumbers_ClipByItemRectangle = true;

		private Size zLineNumbers_Offset = new Size(0, 0);

		private string zLineNumbers_Format = "0";

		private ContentAlignment zLineNumbers_Alignment = ContentAlignment.TopRight;

		private bool zLineNumbers_AntiAlias = true;

		private List<Linenum.LineNumberItem> zLNIs = new List<Linenum.LineNumberItem>();

		private Point zPointInParent = new Point(0, 0);

		private Point zPointInMe = new Point(0, 0);

		private int zParentInMe;

		private RichTextBoxEx zParent
		{
			get
			{
				return this.withEventsField_zParent;
			}
			set
			{
				if (this.withEventsField_zParent != null)
				{
					this.withEventsField_zParent.OnReDraw -= new EventHandler(this.zParent_Changed);
					this.withEventsField_zParent.HScroll -= new EventHandler(this.zParent_Scroll);
					this.withEventsField_zParent.VScroll -= new EventHandler(this.zParent_Scroll);
					this.withEventsField_zParent.Disposed -= new EventHandler(this.zParent_Disposed);
				}
				this.withEventsField_zParent = value;
				if (this.withEventsField_zParent != null)
				{
					this.withEventsField_zParent.OnReDraw += new EventHandler(this.zParent_Changed);
					this.withEventsField_zParent.HScroll += new EventHandler(this.zParent_Scroll);
					this.withEventsField_zParent.VScroll += new EventHandler(this.zParent_Scroll);
					this.withEventsField_zParent.Disposed += new EventHandler(this.zParent_Disposed);
				}
			}
		}

		private Timer zTimer
		{
			get
			{
				return this.withEventsField_zTimer;
			}
			set
			{
				Timer arg_06_0 = this.withEventsField_zTimer;
				this.withEventsField_zTimer = value;
				Timer arg_14_0 = this.withEventsField_zTimer;
			}
		}

		[Browsable(false)]
		public override bool AutoSize
		{
			get
			{
				return base.AutoSize;
			}
			set
			{
				base.AutoSize = value;
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this property to automatically resize the control (and reposition it if needed).")]
		public bool AutoSizing
		{
			get
			{
				return this.zAutoSizing;
			}
			set
			{
				this.zAutoSizing = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[Category("Add LineNumbers to"), Description("Use this property to enable LineNumbers for the chosen RichTextBoxEx.")]
		public RichTextBoxEx ParentRichTextBox
		{
			get
			{
				return this.zParent;
			}
			set
			{
				this.zParent = value;
				if (this.zParent != null)
				{
					base.Parent = this.zParent.Parent;
					this.zParent.Refresh();
				}
				this.Text = "";
				this.Refresh();
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this property to dock the LineNumbers to a chosen side of the chosen RichTextBox.")]
		public Linenum.LineNumberDockSide DockSide
		{
			get
			{
				return this.zDockSide;
			}
			set
			{
				this.zDockSide = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[Category("Additional Behavior")]
		public bool Show_LineNrs
		{
			get
			{
				return this.zLineNumbers_Show;
			}
			set
			{
				this.zLineNumbers_Show = value;
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this to set whether the LineNumbers are allowed to spill out of their item-area, or should be clipped by it.")]
		public bool LineNrs_ClippedByItemRectangle
		{
			get
			{
				return this.zLineNumbers_ClipByItemRectangle;
			}
			set
			{
				this.zLineNumbers_ClipByItemRectangle = value;
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this to set whether the LineNumbers should have leading zeroes (based on the total amount of textlines).")]
		public bool LineNrs_LeadingZeroes
		{
			get
			{
				return this.zLineNumbers_ShowLeadingZeroes;
			}
			set
			{
				this.zLineNumbers_ShowLeadingZeroes = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this to set whether the LineNumbers should be shown as hexadecimal values.")]
		public bool LineNrs_AsHexadecimal
		{
			get
			{
				return this.zLineNumbers_ShowAsHexadecimal;
			}
			set
			{
				this.zLineNumbers_ShowAsHexadecimal = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this property to manually reposition the LineNumbers, relative to their current location.")]
		public Size LineNrs_Offset
		{
			get
			{
				return this.zLineNumbers_Offset;
			}
			set
			{
				this.zLineNumbers_Offset = value;
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this to align the LineNumbers to a chosen corner (or center) within their item-area.")]
		public ContentAlignment LineNrs_Alignment
		{
			get
			{
				return this.zLineNumbers_Alignment;
			}
			set
			{
				this.zLineNumbers_Alignment = value;
				base.Invalidate();
			}
		}

		[Category("Additional Behavior"), Description("Use this to apply Anti-Aliasing to the LineNumbers (high quality). Some fonts will look better without it, though.")]
		public bool LineNrs_AntiAlias
		{
			get
			{
				return this.zLineNumbers_AntiAlias;
			}
			set
			{
				this.zLineNumbers_AntiAlias = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[Browsable(true)]
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				this.Refresh();
				base.Invalidate();
			}
		}

		[AmbientValue(""), Browsable(false), DefaultValue("")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = "";
				base.Invalidate();
			}
		}

		public Linenum()
		{
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.Margin = new Padding(0);
			base.Padding = new Padding(0, 0, 2, 0);
			this.zTimer.Enabled = true;
			this.zTimer.Interval = 200;
			this.zTimer.Stop();
			this.Update_SizeAndPosition();
			base.Invalidate();
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.AutoSize = false;
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			if (base.DesignMode)
			{
				this.Refresh();
			}
			base.OnSizeChanged(e);
			base.Invalidate();
		}

		protected override void OnLocationChanged(EventArgs e)
		{
			if (base.DesignMode)
			{
				this.Refresh();
			}
			base.OnLocationChanged(e);
			base.Invalidate();
		}

		public override void Refresh()
		{
			base.Refresh();
			this.Update_SizeAndPosition();
		}

		private void Update_SizeAndPosition()
		{
			if (this.AutoSize)
			{
				return;
			}
			if (this.Dock == DockStyle.Bottom | this.Dock == DockStyle.Fill | this.Dock == DockStyle.Top)
			{
				return;
			}
			Point location = base.Location;
			Size size = base.Size;
			if (this.zAutoSizing)
			{
				if (this.zParent == null)
				{
					if (this.zAutoSizing_Size.Width > 0)
					{
						size.Width = this.zAutoSizing_Size.Width;
					}
					if (this.zAutoSizing_Size.Height > 0)
					{
						size.Height = this.zAutoSizing_Size.Height;
					}
					base.Size = size;
					return;
				}
				if (this.Dock == DockStyle.Left | this.Dock == DockStyle.Right)
				{
					if (this.zAutoSizing_Size.Width > 0)
					{
						size.Width = this.zAutoSizing_Size.Width;
					}
					base.Width = size.Width;
					return;
				}
				if (this.zDockSide != Linenum.LineNumberDockSide.None)
				{
					if (this.zAutoSizing_Size.Width > 0)
					{
						size.Width = this.zAutoSizing_Size.Width;
					}
					size.Height = this.zParent.Height;
					if (this.zDockSide == Linenum.LineNumberDockSide.Left)
					{
						location.X = this.zParent.Left - size.Width - 1;
					}
					if (this.zDockSide == Linenum.LineNumberDockSide.Right)
					{
						location.X = this.zParent.Right + 1;
					}
					location.Y = this.zParent.Top;
					base.Location = location;
					base.Size = size;
					return;
				}
				if (this.zDockSide == Linenum.LineNumberDockSide.None)
				{
					if (this.zAutoSizing_Size.Width > 0)
					{
						size.Width = this.zAutoSizing_Size.Width;
					}
					base.Size = size;
					return;
				}
			}
			else
			{
				if (this.zParent == null)
				{
					if (this.zAutoSizing_Size.Width > 0)
					{
						size.Width = this.zAutoSizing_Size.Width;
					}
					if (this.zAutoSizing_Size.Height > 0)
					{
						size.Height = this.zAutoSizing_Size.Height;
					}
					base.Size = size;
					return;
				}
				if (this.zDockSide != Linenum.LineNumberDockSide.None)
				{
					size.Height = this.zParent.Height;
					if (this.zDockSide == Linenum.LineNumberDockSide.Left)
					{
						location.X = this.zParent.Left - size.Width - 1;
					}
					if (this.zDockSide == Linenum.LineNumberDockSide.Right)
					{
						location.X = this.zParent.Right + 1;
					}
					location.Y = this.zParent.Top;
					base.Location = location;
					base.Size = size;
				}
			}
		}

		private void Update_VisibleLineNumberItems()
		{
			this.zLNIs.Clear();
			this.zAutoSizing_Size = new Size(0, 0);
			this.zLineNumbers_Format = "0";
			if (this.zAutoSizing)
			{
				this.zAutoSizing_Size = new Size(TextRenderer.MeasureText(this.zLineNumbers_Format.Replace('0', 'W'), this.Font).Width, 0);
			}
			if (this.zParent == null || string.IsNullOrEmpty(this.zParent.Text))
			{
				return;
			}
			this.zPointInParent = this.zParent.PointToScreen(this.zParent.ClientRectangle.Location);
			this.zPointInMe = base.PointToScreen(new Point(0, 0));
			this.zParentInMe = this.zPointInParent.Y - this.zPointInMe.Y + 1;
			this.zPointInParent = this.zParent.PointToClient(this.zPointInMe);
			string[] array = this.zParent.Text.Split("\r\n".ToCharArray());
			if (array.Length < 2)
			{
				Point positionFromCharIndex = this.zParent.GetPositionFromCharIndex(0);
				this.zLNIs.Add(new Linenum.LineNumberItem(1, new Rectangle(new Point(0, positionFromCharIndex.Y - 1 + this.zParentInMe), new Size(base.Width, this.zContentRectangle.Height - positionFromCharIndex.Y))));
			}
			else
			{
				TimeSpan timeSpan = new TimeSpan(DateAndTime.Now.Ticks);
				Point positionFromCharIndex2 = new Point(0, 0);
				int num = 0;
				int i = this.zParent.Text.Length - 1;
				int y = this.zPointInParent.Y;
				this.FindStartIndex(ref num, ref i, ref y);
				this.zPointInParent.Y = y;
				num = Math.Max(0, Math.Min(this.zParent.Text.Length - 1, this.zParent.Text.Substring(0, num).LastIndexOf(Strings.Chr(10)) + 1));
				int num2 = Math.Max(0, this.zParent.Text.Substring(0, num).Split("\r\n".ToCharArray()).Length - 1);
				for (i = num2; i <= array.Length - 1; i++)
				{
					positionFromCharIndex2 = this.zParent.GetPositionFromCharIndex(num);
					num += Math.Max(1, array[i].Length + 1);
					if (positionFromCharIndex2.Y + this.zParentInMe > base.Height)
					{
						break;
					}
					this.zLNIs.Add(new Linenum.LineNumberItem(i + 1, new Rectangle(0, positionFromCharIndex2.Y - 1 + this.zParentInMe, base.Width, 1)));
					if (this.zParentIsScrolling && DateAndTime.Now.Ticks > timeSpan.Ticks + 500000L)
					{
						if (this.zLNIs.Count == 1)
						{
							this.zLNIs[0].Rectangle.Y = 0;
						}
						this.zParentIsScrolling = false;
						this.zTimer.Start();
						break;
					}
				}
				if (this.zLNIs.Count == 0)
				{
					return;
				}
				if (i < array.Length)
				{
					positionFromCharIndex2 = this.zParent.GetPositionFromCharIndex(Math.Min(num, this.zParent.Text.Length - 1));
					this.zLNIs.Add(new Linenum.LineNumberItem(-1, new Rectangle(0, positionFromCharIndex2.Y - 1 + this.zParentInMe, 0, 0)));
				}
				else
				{
					this.zLNIs.Add(new Linenum.LineNumberItem(-1, new Rectangle(0, this.zContentRectangle.Bottom, 0, 0)));
				}
				for (i = 0; i <= this.zLNIs.Count - 2; i++)
				{
					this.zLNIs[i].Rectangle.Height = Math.Max(1, this.zLNIs[i + 1].Rectangle.Y - this.zLNIs[i].Rectangle.Y);
				}
				this.zLNIs.RemoveAt(this.zLNIs.Count - 1);
				if (this.zLineNumbers_ShowAsHexadecimal)
				{
					this.zLineNumbers_Format = "".PadRight(array.Length.ToString("X").Length, '0');
				}
				else
				{
					this.zLineNumbers_Format = "".PadRight(array.Length.ToString().Length, '0');
				}
			}
			if (this.zAutoSizing)
			{
				this.zAutoSizing_Size = new Size(TextRenderer.MeasureText(this.zLineNumbers_Format.Replace('0', 'W'), this.Font).Width, 0);
			}
		}

		private void FindStartIndex(ref int zMin, ref int zMax, ref int zTarget)
		{
			if (zMax == zMin + 1 | zMin == (zMax + zMin) / 2)
			{
				return;
			}
			if (this.zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y == zTarget)
			{
				zMin = (zMax + zMin) / 2;
				return;
			}
			if (this.zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y > zTarget)
			{
				zMax = (zMax + zMin) / 2;
				this.FindStartIndex(ref zMin, ref zMax, ref zTarget);
				return;
			}
			if (this.zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y < 0)
			{
				zMin = (zMax + zMin) / 2;
				this.FindStartIndex(ref zMin, ref zMax, ref zTarget);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			this.Update_VisibleLineNumberItems();
			base.OnPaint(e);
			if (this.zLineNumbers_AntiAlias)
			{
				e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			}
			else
			{
				e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
			}
			string text = "";
			StringFormat stringFormat = new StringFormat();
			SizeF sizeF = default(SizeF);
			new Pen(this.ForeColor);
			SolidBrush brush = new SolidBrush(this.ForeColor);
			Point point = new Point(0, 0);
			Rectangle rect = new Rectangle(0, 0, 0, 0);
			GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
			new Region(base.ClientRectangle);
			if (base.DesignMode)
			{
				if (this.zParent == null)
				{
					text = "-!- Set ParentRichTextBox -!-";
				}
				else if (this.zLNIs.Count == 0)
				{
					text = "LineNrs (  " + this.zParent.Name + "  )";
				}
				if (text.Length > 0)
				{
					e.Graphics.TranslateTransform((float)(base.Width / 2), (float)(base.Height / 2));
					e.Graphics.RotateTransform(-90f);
					stringFormat.Alignment = StringAlignment.Center;
					stringFormat.LineAlignment = StringAlignment.Center;
					sizeF = e.Graphics.MeasureString(text, this.Font, point, stringFormat);
					e.Graphics.DrawString(text, this.Font, Brushes.WhiteSmoke, 1f, 1f, stringFormat);
					e.Graphics.DrawString(text, this.Font, Brushes.Firebrick, 0f, 0f, stringFormat);
					e.Graphics.ResetTransform();
					Rectangle rect2 = new Rectangle((int)((float)(base.Width / 2) - sizeF.Height / 2f), (int)((float)(base.Height / 2) - sizeF.Width / 2f), (int)sizeF.Height, (int)sizeF.Width);
					graphicsPath.AddRectangle(rect2);
					graphicsPath.CloseFigure();
					if (this.zAutoSizing)
					{
						rect2.Inflate((int)((double)sizeF.Height * 0.2), (int)((double)sizeF.Width * 0.1));
						this.zAutoSizing_Size = new Size(rect2.Width, rect2.Height);
					}
				}
			}
			if (this.zLNIs.Count > 0)
			{
				LinearGradientBrush linearGradientBrush = null;
				stringFormat.Alignment = StringAlignment.Near;
				stringFormat.LineAlignment = StringAlignment.Near;
				stringFormat.FormatFlags = (StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip);
				for (int i = 0; i <= this.zLNIs.Count - 1; i++)
				{
					if (this.zLineNumbers_Show)
					{
						string text2;
						if (this.zLineNumbers_ShowLeadingZeroes)
						{
							text2 = (this.zLineNumbers_ShowAsHexadecimal ? this.zLNIs[i].LineNumber.ToString("X") : this.zLNIs[i].LineNumber.ToString(this.zLineNumbers_Format));
						}
						else
						{
							text2 = (this.zLineNumbers_ShowAsHexadecimal ? this.zLNIs[i].LineNumber.ToString("X") : this.zLNIs[i].LineNumber.ToString());
						}
						sizeF = e.Graphics.MeasureString(text2, this.Font, point, stringFormat);
						ContentAlignment contentAlignment = this.zLineNumbers_Alignment;
						if (contentAlignment <= ContentAlignment.MiddleCenter)
						{
							switch (contentAlignment)
							{
							case ContentAlignment.TopLeft:
								point = new Point(this.zLNIs[i].Rectangle.Left + base.Padding.Left + this.zLineNumbers_Offset.Width, this.zLNIs[i].Rectangle.Top + base.Padding.Top + this.zLineNumbers_Offset.Height);
								break;
							case ContentAlignment.TopCenter:
								point = new Point((int)((float)(this.zLNIs[i].Rectangle.Width / 2 + this.zLineNumbers_Offset.Width) - sizeF.Width / 2f), this.zLNIs[i].Rectangle.Top + base.Padding.Top + this.zLineNumbers_Offset.Height);
								break;
							case (ContentAlignment)3:
								break;
							case ContentAlignment.TopRight:
								point = new Point((int)((float)(this.zLNIs[i].Rectangle.Right - base.Padding.Right + this.zLineNumbers_Offset.Width) - sizeF.Width), this.zLNIs[i].Rectangle.Top + base.Padding.Top + this.zLineNumbers_Offset.Height);
								break;
							default:
								if (contentAlignment != ContentAlignment.MiddleLeft)
								{
									if (contentAlignment == ContentAlignment.MiddleCenter)
									{
										point = new Point((int)((float)(this.zLNIs[i].Rectangle.Width / 2 + this.zLineNumbers_Offset.Width) - sizeF.Width / 2f), (int)((float)(this.zLNIs[i].Rectangle.Top + this.zLNIs[i].Rectangle.Height / 2 + this.zLineNumbers_Offset.Height) - sizeF.Height / 2f));
									}
								}
								else
								{
									point = new Point(this.zLNIs[i].Rectangle.Left + base.Padding.Left + this.zLineNumbers_Offset.Width, (int)((float)(this.zLNIs[i].Rectangle.Top + this.zLNIs[i].Rectangle.Height / 2 + this.zLineNumbers_Offset.Height) - sizeF.Height / 2f));
								}
								break;
							}
						}
						else if (contentAlignment <= ContentAlignment.BottomLeft)
						{
							if (contentAlignment != ContentAlignment.MiddleRight)
							{
								if (contentAlignment == ContentAlignment.BottomLeft)
								{
									point = new Point(this.zLNIs[i].Rectangle.Left + base.Padding.Left + this.zLineNumbers_Offset.Width, (int)((float)(this.zLNIs[i].Rectangle.Bottom - base.Padding.Bottom + 1 + this.zLineNumbers_Offset.Height) - sizeF.Height));
								}
							}
							else
							{
								point = new Point((int)((float)(this.zLNIs[i].Rectangle.Right - base.Padding.Right + this.zLineNumbers_Offset.Width) - sizeF.Width), (int)((float)(this.zLNIs[i].Rectangle.Top + this.zLNIs[i].Rectangle.Height / 2 + this.zLineNumbers_Offset.Height) - sizeF.Height / 2f));
							}
						}
						else if (contentAlignment != ContentAlignment.BottomCenter)
						{
							if (contentAlignment == ContentAlignment.BottomRight)
							{
								point = new Point((int)((float)(this.zLNIs[i].Rectangle.Right - base.Padding.Right + this.zLineNumbers_Offset.Width) - sizeF.Width), (int)((float)(this.zLNIs[i].Rectangle.Bottom - base.Padding.Bottom + 1 + this.zLineNumbers_Offset.Height) - sizeF.Height));
							}
						}
						else
						{
							point = new Point((int)((float)(this.zLNIs[i].Rectangle.Width / 2 + this.zLineNumbers_Offset.Width) - sizeF.Width / 2f), (int)((float)(this.zLNIs[i].Rectangle.Bottom - base.Padding.Bottom + 1 + this.zLineNumbers_Offset.Height) - sizeF.Height));
						}
						rect = new Rectangle(point, sizeF.ToSize());
						if (0 <= point.Y)
						{
							e.Graphics.DrawString(text2, this.Font, brush, point, stringFormat);
						}
						e.Graphics.ResetClip();
						graphicsPath.AddRectangle(rect);
						graphicsPath.CloseFigure();
					}
				}
				if (linearGradientBrush != null)
				{
					linearGradientBrush.Dispose();
				}
			}
			if (graphicsPath != null)
			{
				graphicsPath.Dispose();
			}
		}

		private void zTimer_Tick(object sender, EventArgs e)
		{
			this.zParentIsScrolling = false;
			this.zTimer.Stop();
			base.Invalidate();
		}

		private void zParent_Changed(object sender, EventArgs e)
		{
			this.Refresh();
			base.Invalidate();
		}

		private void zParent_Scroll(object sender, EventArgs e)
		{
			this.zParentIsScrolling = true;
			base.Invalidate();
		}

		private void zParent_ContentsResized(object sender, ContentsResizedEventArgs e)
		{
			this.zContentRectangle = e.NewRectangle;
			this.Refresh();
			base.Invalidate();
		}

		private void zParent_Disposed(object sender, EventArgs e)
		{
			this.ParentRichTextBox = null;
			this.Refresh();
			base.Invalidate();
		}
	}
}
