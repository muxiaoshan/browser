using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using System;
using System.Drawing;

namespace dhcc.epr.systemframework
{
	public class CrossCellType : TextCellType
	{
		public override void PaintCell(Graphics g, Rectangle r, Appearance appearance, object value, bool isSelected, bool isLocked, float zoomFactor)
		{
			Pen pen = new Pen(Color.Black, 2f);
			if (value != null && value.ToString().Split(new char[]
			{
				'|'
			}).Length == 4)
			{
				StringFormat stringFormat = new StringFormat();
				stringFormat.LineAlignment = StringAlignment.Center;
				string[] array = value.ToString().Split(new char[]
				{
					'|'
				});
				Rectangle r2 = default(Rectangle);
				r2.Width = r.Width / 2;
				r2.Height = r.Height / 2;
				stringFormat.Alignment = StringAlignment.Far;
				r2.X = r.X;
				r2.Y = r.Y;
				g.DrawString(array[0], appearance.get_Font(), new SolidBrush(Color.Black), r2, stringFormat);
				r2.X = r.X;
				r2.Y = r.Y + r.Height / 2;
				g.DrawString(array[2], appearance.get_Font(), new SolidBrush(Color.Black), r2, stringFormat);
				stringFormat.Alignment = StringAlignment.Near;
				r2.X = r.X + r.Width / 2;
				r2.Y = r.Y;
				g.DrawString(array[1], appearance.get_Font(), new SolidBrush(Color.Black), r2, stringFormat);
				r2.X = r.X + r.Width / 2;
				r2.Y = r.Y + r.Height / 2;
				g.DrawString(array[3], appearance.get_Font(), new SolidBrush(Color.Black), r2, stringFormat);
			}
			else
			{
				base.PaintCell(g, r, appearance, value, isSelected, isLocked, zoomFactor);
			}
			Point pt = default(Point);
			Point pt2 = default(Point);
			pt.X = r.X;
			pt.Y = r.Y + r.Height / 2;
			pt2.X = r.Location.X + r.Width;
			pt2.Y = r.Location.Y + r.Height / 2;
			g.DrawLine(pen, pt, pt2);
			pt.X = r.X + r.Width / 2;
			pt.Y = r.Y;
			pt2.X = r.X + r.Width / 2;
			pt2.Y = r.Y + r.Height;
			g.DrawLine(pen, pt, pt2);
		}
	}
}
