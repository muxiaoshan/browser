using System;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	public interface ICoordinate
	{
		void ShowCoordinate(Control ctrl, Point p);
	}
}
