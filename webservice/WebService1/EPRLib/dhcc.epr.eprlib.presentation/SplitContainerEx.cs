using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	[ToolboxBitmap(typeof(SplitContainer))]
	public class SplitContainerEx : SplitContainer
	{
		private enum MouseState
		{
			Normal,
			Hover
		}

		public enum SplitterPanelEnum
		{
			Panel1,
			Panel2
		}

		private SplitContainerEx.SplitterPanelEnum mCollpasePanel;

		private bool mCollpased;

		private Rectangle mRect;

		private SplitContainerEx.MouseState mMouseState;

		private bool mIsSplitterFixed;

		private int _HeightOrWidth;

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public new virtual int SplitterWidth
		{
			get
			{
				return base.SplitterWidth;
			}
			set
			{
				base.SplitterWidth = 9;
			}
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public new virtual int Panel1MinSize
		{
			get
			{
				return base.Panel1MinSize;
			}
			set
			{
				base.Panel1MinSize = 0;
			}
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public new virtual int Panel2MinSize
		{
			get
			{
				return base.Panel2MinSize;
			}
			set
			{
				base.Panel2MinSize = 0;
			}
		}

		[DefaultValue(1)]
		public SplitContainerEx.SplitterPanelEnum CollpasePanel
		{
			get
			{
				return this.mCollpasePanel;
			}
			set
			{
				if (value != this.mCollpasePanel)
				{
					this.mCollpasePanel = value;
					base.Invalidate(this.ControlRect);
				}
			}
		}

		public bool IsCollpased
		{
			get
			{
				return this.mCollpased;
			}
		}

		private Rectangle ControlRect
		{
			get
			{
				checked
				{
					if (this.Orientation == Orientation.Horizontal)
					{
						if (this.Width <= 80)
						{
							this.mRect.X = 0;
						}
						else
						{
							this.mRect.X = (int)Math.Round(unchecked((double)this.Width / 2.0 - 40.0));
						}
						this.mRect.Y = this.SplitterDistance;
						this.mRect.Width = 80;
						this.mRect.Height = 9;
					}
					else
					{
						this.mRect.X = this.SplitterDistance;
						if (this.Height <= 80)
						{
							this.mRect.Y = 0;
						}
						else
						{
							this.mRect.Y = (int)Math.Round(unchecked((double)this.Height / 2.0 - 40.0));
						}
						this.mRect.Width = 9;
						this.mRect.Height = 80;
					}
					return this.mRect;
				}
			}
			set
			{
			}
		}

		public new virtual bool IsSplitterFixed
		{
			get
			{
				return base.IsSplitterFixed;
			}
			set
			{
				base.IsSplitterFixed = value;
				if (value && !this.mIsSplitterFixed)
				{
					this.mIsSplitterFixed = true;
				}
			}
		}

		public SplitContainerEx()
		{
			this.mCollpasePanel = SplitContainerEx.SplitterPanelEnum.Panel2;
			this.mCollpased = false;
			this.mMouseState = SplitContainerEx.MouseState.Normal;
			this.mIsSplitterFixed = true;
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.OptimizedDoubleBuffer, true);
			this.SplitterWidth = 9;
			this.Panel1MinSize = 0;
			this.Panel2MinSize = 0;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			bool collapse = false;
			if ((this.CollpasePanel == SplitContainerEx.SplitterPanelEnum.Panel1 && !this.mCollpased) | (this.CollpasePanel == SplitContainerEx.SplitterPanelEnum.Panel2 && this.mCollpased))
			{
				collapse = true;
			}
			Color color;
			if (this.mMouseState == SplitContainerEx.MouseState.Normal)
			{
				color = SystemColors.ButtonShadow;
			}
			else
			{
				color = SystemColors.ControlDarkDark;
			}
			Bitmap bitmap = this.CreateControlImage(collapse, color);
			if (this.Orientation == Orientation.Vertical)
			{
				bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
			}
			e.Graphics.SetClip(this.SplitterRectangle);
			e.Graphics.Clear(this.BackColor);
			e.Graphics.DrawImage(bitmap, this.ControlRect);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.SplitterRectangle.Contains(e.Location))
			{
				if (this.ControlRect.Contains(e.Location))
				{
					if (!this.IsSplitterFixed)
					{
						this.IsSplitterFixed = true;
						this.mIsSplitterFixed = false;
					}
					this.Cursor = Cursors.Hand;
					this.mMouseState = SplitContainerEx.MouseState.Hover;
					this.Invalidate(this.ControlRect);
				}
			}
			else
			{
				if (!this.mIsSplitterFixed)
				{
					this.IsSplitterFixed = false;
					if (this.Orientation == Orientation.Horizontal)
					{
						this.Cursor = Cursors.HSplit;
					}
					else
					{
						this.Cursor = Cursors.VSplit;
					}
				}
				else
				{
					this.Cursor = Cursors.Default;
				}
				this.mMouseState = SplitContainerEx.MouseState.Normal;
				this.Invalidate(this.ControlRect);
			}
			base.OnMouseMove(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.mMouseState = SplitContainerEx.MouseState.Normal;
			this.Invalidate(this.ControlRect);
			base.OnMouseLeave(e);
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			if (this.ControlRect.Contains(e.Location))
			{
				this.CollpaseOrExpand();
			}
			base.OnMouseClick(e);
		}

		public void CollpaseOrExpand()
		{
			checked
			{
				if (this.mCollpased)
				{
					this.mCollpased = false;
					this.SplitterDistance = this._HeightOrWidth;
				}
				else
				{
					this.mCollpased = true;
					this._HeightOrWidth = this.SplitterDistance;
					if (this.CollpasePanel == SplitContainerEx.SplitterPanelEnum.Panel1)
					{
						this.SplitterDistance = 0;
					}
					else if (this.Orientation == Orientation.Horizontal)
					{
						this.SplitterDistance = this.Height - 9;
					}
					else
					{
						this.SplitterDistance = this.Width - 9;
					}
				}
				this.Invalidate(this.ControlRect);
			}
		}

		private Bitmap CreateControlImage(bool collapse, Color color)
		{
			Bitmap bitmap = new Bitmap(80, 9);
			int num = 5;
			checked
			{
				do
				{
					int num2 = 1;
					do
					{
						bitmap.SetPixel(num, num2, color);
						num2 += 3;
					}
					while (num2 <= 7);
					num += 5;
				}
				while (num <= 30);
				int num3 = 50;
				do
				{
					int num4 = 1;
					do
					{
						bitmap.SetPixel(num3, num4, color);
						num4 += 3;
					}
					while (num4 <= 7);
					num3 += 5;
				}
				while (num3 <= 75);
				if (collapse)
				{
					int num5 = 0;
					int num6 = 7;
					do
					{
						int arg_66_0 = 35 + num5;
						int num7 = 45 - num5;
						for (int i = arg_66_0; i <= num7; i++)
						{
							bitmap.SetPixel(i, num6, color);
						}
						num5++;
						num6 += -1;
					}
					while (num6 >= 1);
				}
				else
				{
					int num8 = 0;
					int num9 = 1;
					do
					{
						int arg_A6_0 = 35 + num8;
						int num10 = 45 - num8;
						for (int j = arg_A6_0; j <= num10; j++)
						{
							bitmap.SetPixel(j, num9, color);
						}
						num8++;
						num9++;
					}
					while (num9 <= 7);
				}
				return bitmap;
			}
		}
	}
}
