using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CDaySubtract : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CDaySubtract()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CDaySubtract cDaySubtract = new CDaySubtract();
			cDaySubtract.SetParameters(alValues);
			return cDaySubtract;
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
			if (Operators.CompareString(cValue.GetValue(), "", false) != 0 & Operators.CompareString(cValue2.GetValue(), "", false) != 0)
			{
				DateTime dateTime = DateTime.Parse(cValue.GetValue());
				DateTime value = DateTime.Parse(cValue2.GetValue());
				return dateTime.Subtract(value).Days.ToString();
			}
			return null;
		}

		public override string GetFunction()
		{
			return "daysubtract";
		}
	}
}
