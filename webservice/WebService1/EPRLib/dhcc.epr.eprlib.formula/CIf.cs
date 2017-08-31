using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CIf : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CIf()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CIf cIf = new CIf();
			cIf.SetParameters(alValues);
			return cIf;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 2);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			CValue cValue = (CValue)this.m_alValues[0];
			CValue cValue2 = (CValue)this.m_alValues[1];
			if (Operators.CompareString(cValue.GetValue(), "true", false) == 0)
			{
				return cValue2.GetValue();
			}
			return string.Empty;
		}

		public override string GetFunction()
		{
			return "if";
		}
	}
}
