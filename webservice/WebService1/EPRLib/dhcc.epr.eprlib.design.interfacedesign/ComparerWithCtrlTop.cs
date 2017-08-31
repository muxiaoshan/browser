using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class ComparerWithCtrlTop : IComparer
	{
		[DebuggerNonUserCode]
		public ComparerWithCtrlTop()
		{
		}

		public int Compare(object x, object y)
		{
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(x, null, "Top", new object[0], null, null, null), NewLateBinding.LateGet(y, null, "Top", new object[0], null, null, null), false))
			{
				return 1;
			}
			if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(x, null, "Top", new object[0], null, null, null), NewLateBinding.LateGet(y, null, "Top", new object[0], null, null, null), false))
			{
				return -1;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(x, null, "Top", new object[0], null, null, null), NewLateBinding.LateGet(y, null, "Top", new object[0], null, null, null), false))
			{
				return 0;
			}
			int result;
			return result;
		}
	}
}
