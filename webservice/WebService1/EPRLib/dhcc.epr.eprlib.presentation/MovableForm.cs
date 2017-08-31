using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class MovableForm : Form
	{
		private bool IsSelect;

		private Point mouseOffset;

		public MovableForm()
		{
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			this.IsSelect = false;
		}

		public void SetFormPosition(Point screenPoint)
		{
			Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
			checked
			{
				if (screenPoint.X + this.Width > workingArea.Width)
				{
					screenPoint.X -= this.Width;
				}
				if (screenPoint.Y + this.Height > workingArea.Height)
				{
					screenPoint.Y -= this.Height;
				}
				else
				{
					screenPoint.Y += 20;
				}
				this.StartPosition = FormStartPosition.Manual;
				this.Location = screenPoint;
			}
		}

		protected void AddMovableHandler(Panel pnl)
		{
			if (pnl == null)
			{
				return;
			}
			pnl.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			pnl.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			pnl.MouseUp += new MouseEventHandler(this.Me_MouseUp);
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
			this.IsSelect = false;
			this.mouseOffset = new Point(e.X, e.Y);
			this.IsSelect = true;
			this.Cursor = Cursors.SizeAll;
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				if (e.Button == MouseButtons.Left && this.IsSelect)
				{
					Point point = new Point(e.X - this.mouseOffset.X, e.Y - this.mouseOffset.Y);
					Point location = new Point(this.Location.X + point.X, this.Location.Y + point.Y);
					this.Location = location;
				}
			}
		}

		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.IsSelect = false;
		}
	}
}
