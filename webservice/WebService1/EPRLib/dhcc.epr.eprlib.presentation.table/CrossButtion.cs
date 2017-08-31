using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.table
{
	public class CrossButtion : GridCellButton
	{
		private static GridIconPaint iconPainter;

		static CrossButtion()
		{
			CrossButtion.iconPainter = new GridIconPaint("", typeof(CrossButtion).Assembly);
		}

		public CrossButtion(GridGenericControlCellRenderer control) : base(control)
		{
		}

		public override void Draw(Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
		{
			base.Draw(g, rowIndex, colIndex, bActive, style);
			bool flag = this.IsHovering(rowIndex, colIndex);
			bool flag2 = this.IsMouseDown(rowIndex, colIndex);
			bool flag3 = !style.get_Clickable();
			ButtonState buttonState = ButtonState.Normal;
			if (flag3)
			{
				buttonState |= (ButtonState.Flat | ButtonState.Inactive);
			}
			else if (!flag && !flag2)
			{
				buttonState |= ButtonState.Flat;
			}
			Point empty = Point.Empty;
			if (flag2)
			{
				empty = new Point(1, 1);
				buttonState |= ButtonState.Pushed;
			}
			this.DrawButton(g, this.get_Bounds(), buttonState, style);
			string text = "MultiChoice.bmp";
			CrossButtion.iconPainter.PaintIcon(g, this.get_Bounds(), empty, text, Color.Blue);
		}
	}
}
