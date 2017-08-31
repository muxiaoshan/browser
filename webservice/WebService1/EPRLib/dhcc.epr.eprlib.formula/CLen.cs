using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CLen : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CLen()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CLen cLen = new CLen();
			cLen.SetParameters(alValues);
			return cLen;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 1);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			CValue cValue = (CValue)this.m_alValues[0];
			if (cValue.GetValue() != null)
			{
				return Strings.Len(cValue.GetValue()).ToString();
			}
			return null;
		}

		public override string GetFunction()
		{
			return "len";
		}
	}
}
