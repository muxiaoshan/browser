using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CIfElse : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CIfElse()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CIfElse cIfElse = new CIfElse();
			cIfElse.SetParameters(alValues);
			return cIfElse;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 3);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			CValue cValue = (CValue)this.m_alValues[0];
			CValue cValue2 = (CValue)this.m_alValues[1];
			CValue cValue3 = (CValue)this.m_alValues[2];
			if (Operators.CompareString(cValue.GetValue(), "true", false) == 0)
			{
				return cValue2.GetValue();
			}
			return cValue3.GetValue();
		}

		public override string GetFunction()
		{
			return "ifelse";
		}
	}
}
