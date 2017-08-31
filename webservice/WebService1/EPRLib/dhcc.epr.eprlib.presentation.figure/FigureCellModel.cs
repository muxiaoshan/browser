using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace dhcc.epr.eprlib.presentation.figure
{
	[Serializable]
	public class FigureCellModel : GridTextBoxCellModel
	{
		protected FigureCellModel(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			Size buttonBarSize = new Size(20, 20);
			base.set_ButtonBarSize(buttonBarSize);
		}

		public FigureCellModel(GridModel grid) : base(grid)
		{
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new FigureCellRenderer(control, this);
		}

		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds GridQueryBounds)
		{
			Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, GridQueryBounds);
			Size result = new Size(checked(size.Width + 20), size.Height);
			return result;
		}
	}
}