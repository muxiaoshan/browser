using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class COperatorLib
	{
		private static SortedList m_slOperators;

		[DebuggerNonUserCode]
		public COperatorLib()
		{
		}

		public static SortedList GetOperatorList()
		{
			if (COperatorLib.m_slOperators == null)
			{
				COperatorLib.m_slOperators = new SortedList();
				COperatorLib.m_slOperators.Add("+", new CAdd());
				COperatorLib.m_slOperators.Add("-", new CSubtract());
				COperatorLib.m_slOperators.Add("*", new CMultiply());
				COperatorLib.m_slOperators.Add("/", new CDivide());
				COperatorLib.m_slOperators.Add("^", new CPower());
				COperatorLib.m_slOperators.Add("&&", new CAnd());
				COperatorLib.m_slOperators.Add("||", new COr());
				COperatorLib.m_slOperators.Add("<>", new CNotEquals());
				COperatorLib.m_slOperators.Add(">", new CGreaterThan());
				COperatorLib.m_slOperators.Add(">=", new CGreaterThanEquals());
				COperatorLib.m_slOperators.Add("<", new CLessThan());
				COperatorLib.m_slOperators.Add("<=", new CLessThanEquals());
				COperatorLib.m_slOperators.Add("==", new CEquals());
				COperatorLib.m_slOperators.Add("=", new CAsignment());
			}
			return COperatorLib.m_slOperators;
		}
	}
}
