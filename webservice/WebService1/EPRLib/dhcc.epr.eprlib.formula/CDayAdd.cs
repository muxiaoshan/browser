using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CDayAdd : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CDayAdd()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CDayAdd cDayAdd = new CDayAdd();
			cDayAdd.SetParameters(alValues);
			return cDayAdd;
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
				int num = Conversions.ToInteger(cValue2.GetValue());
				return Conversions.ToString(dateTime.AddDays((double)num));
			}
			return null;
		}

		public override string GetFunction()
		{
			return "dayadd";
		}
	}
}
