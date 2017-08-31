using Syncfusion.Windows.Forms.Grid;
using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.figure
{
	public class PictureBoxCellModel : GridGenericControlCellModel
	{
		public PictureBoxCellModel(GridModel grid) : base(grid)
		{
			PictureBoxStyleProperties.Initialize();
		}

		protected PictureBoxCellModel(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new PictureBoxCellRenderer(control, this);
		}

		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{
			PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(style);
			Image image = pictureBoxStyleProperties.Image;
			if (image != null)
			{
				return image.Size;
			}
			return base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds);
		}

		public static void InitializePictureBox(PictureBox c, GridStyleInfo style)
		{
			PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(style);
			c.SizeMode = pictureBoxStyleProperties.SizeMode;
			c.Image = pictureBoxStyleProperties.Image;
			c.BackColor = style.get_BackColor();
		}
	}
}
