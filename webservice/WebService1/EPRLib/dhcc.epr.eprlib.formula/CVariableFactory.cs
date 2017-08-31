using dhcc.epr.eprlib.instancedata;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CVariableFactory
	{
		[DebuggerNonUserCode]
		public CVariableFactory()
		{
		}

		public static CVariable CreateInstance(string strCode, string strVType, NInstanceItem item)
		{
			if (strVType.IndexOf("Control") != -1)
			{
				return new CVariableVControl(strCode, strVType, item);
			}
			if (strVType.IndexOf("Item") != -1)
			{
				return new CVariableVItem(strCode, strVType, item);
			}
			return new CVariable(strCode, strVType, item);
		}

		public static CVariable CreateInstance(string strCode, string strVType, NInstanceItem item, string admID, string templateID)
		{
			return null;
		}
	}
}
