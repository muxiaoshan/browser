using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	public class PanelEx : Panel, ICoordinate
	{
		public PanelEx()
		{
			this.DoubleBuffered = true;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.ShowCoordinate(this, new Point(e.X, e.Y));
		}

		public virtual void ShowCoordinate(Control ctrl, Point p)
		{
			if (base.Parent is ICoordinate)
			{
				(base.Parent as ICoordinate).ShowCoordinate(ctrl, new Point(p.X + base.Location.X, p.Y + base.Location.Y));
			}
		}
	}
}
