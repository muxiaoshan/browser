using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.table
{
	public class DictionaryCellRenderer : GridTextBoxCellRenderer
	{
		public DictionaryCellRenderer(GridControlBase grid, GridTextBoxCellModel cellModel) : base(grid, cellModel)
		{
			this.AddButton(new DictionaryButton(this));
		}

		public override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
		{
			e.get_Style().set_ShowButtons(1);
			e.get_Style().set_Clickable(true);
			e.get_Style().set_TextAlign(1);
			e.get_Style().set_VerticalAlignment(1);
			e.get_Style().set_WrapText(false);
		}

		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			checked
			{
				Rectangle rectangle = Rectangle.FromLTRB(innerBounds.Right - 20, innerBounds.Top, innerBounds.Right, innerBounds.Bottom);
				int arg_3F_0_cp_1 = 0;
				Rectangle arg_3A_0 = rectangle;
				Size size = new Size(20, 20);
				buttonsBounds[arg_3F_0_cp_1] = GridUtil.CenterInRect(arg_3A_0, size);
				innerBounds.Width -= 20;
				return innerBounds;
			}
		}
	}
}
