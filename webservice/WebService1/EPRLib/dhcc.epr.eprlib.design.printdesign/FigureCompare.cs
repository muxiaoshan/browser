using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureCompare : IComparer
	{
		[DebuggerNonUserCode]
		public FigureCompare()
		{
		}

		public int Compare(object x, object y)
		{
			checked
			{
				int num = ((FigureRange)x).StartRow - ((FigureRange)y).StartRow;
				if (num != 0)
				{
					return num;
				}
				return ((FigureRange)x).StartColumn - ((FigureRange)y).StartColumn;
			}
		}
	}
}
