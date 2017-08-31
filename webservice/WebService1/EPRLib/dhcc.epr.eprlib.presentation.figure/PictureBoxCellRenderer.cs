using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.figure
{
	public class PictureBoxCellRenderer : GridGenericControlCellRenderer
	{
		private PictureBox drawPictureBox;

		private PictureBoxCellModel cm;

		public PictureBoxCellRenderer(GridControlBase grid, GridCellModelBase cellModel) : base(grid, cellModel)
		{
			this.drawPictureBox = new PictureBox();
			this.cm = (PictureBoxCellModel)cellModel;
			this.set_SupportsFocusControl(false);
			this.FixControlParent(this.drawPictureBox);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.drawPictureBox.Dispose();
				this.drawPictureBox = null;
				this.cm = null;
			}
			base.Dispose(disposing);
		}

		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)
		{
			style.set_Control(this.drawPictureBox);
			PictureBoxCellModel.InitializePictureBox(this.drawPictureBox, style);
			base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
		}

		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			Rectangle result = base.OnLayout(rowIndex, colIndex, style, innerBounds, buttonsBounds);
			result.Inflate(-1, -1);
			return result;
		}
	}
}
