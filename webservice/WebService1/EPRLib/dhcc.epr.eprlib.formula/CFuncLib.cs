using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CFuncLib
	{
		private static SortedList m_slFunctions;

		[DebuggerNonUserCode]
		public CFuncLib()
		{
		}

		public static SortedList GetFuncList()
		{
			if (CFuncLib.m_slFunctions == null)
			{
				CFuncLib.m_slFunctions = new SortedList();
				CFuncLib.m_slFunctions.Add("mid", new CMid());
				CFuncLib.m_slFunctions.Add("left", new CLeft());
				CFuncLib.m_slFunctions.Add("right", new CRight());
				CFuncLib.m_slFunctions.Add("len", new CLen());
				CFuncLib.m_slFunctions.Add("if", new CIf());
				CFuncLib.m_slFunctions.Add("ifelse", new CIfElse());
				CFuncLib.m_slFunctions.Add("instr", new CInStr());
				CFuncLib.m_slFunctions.Add("ageunit", new CAgeUnit());
				CFuncLib.m_slFunctions.Add("agenumber", new CAgeNumber());
				CFuncLib.m_slFunctions.Add("daysubtract", new CDaySubtract());
				CFuncLib.m_slFunctions.Add("dayadd", new CDayAdd());
				CFuncLib.m_slFunctions.Add("duplicate", new CCheckDuplicate());
				CFuncLib.m_slFunctions.Add("bracket", new CBracket());
				CFuncLib.m_slFunctions.Add("datediff", new CDateDiff());
				CFuncLib.m_slFunctions.Add("hourdiff", new CHourDiff());
			}
			return CFuncLib.m_slFunctions;
		}
	}
}
