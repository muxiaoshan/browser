using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.table
{
	public class PositionButton : GridCellButton
	{
		private static GridIconPaint iconPainter;

		static PositionButton()
		{
			PositionButton.iconPainter = new GridIconPaint("", typeof(PositionButton).Assembly);
		}

		public PositionButton(GridTextBoxCellRenderer control) : base(control)
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
			string text = "Position.bmp";
			PositionButton.iconPainter.PaintIcon(g, this.get_Bounds(), empty, text, Color.Blue);
		}
	}
}
