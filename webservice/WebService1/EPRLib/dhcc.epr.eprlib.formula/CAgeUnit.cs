using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CAgeUnit : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CAgeUnit()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CAgeUnit cAgeUnit = new CAgeUnit();
			cAgeUnit.SetParameters(alValues);
			return cAgeUnit;
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
				DateTime dateTime2 = DateTime.Parse(cValue2.GetValue());
				if (DateTime.Compare(dateTime2, dateTime) > 0)
				{
					int num = checked((int)DateAndTime.DateDiff(DateInterval.Day, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
					if (num < DateTime.DaysInMonth(dateTime.Year, dateTime.Month))
					{
						return "天";
					}
					if (DateTime.IsLeapYear(dateTime.Year) & dateTime.Month < 3 & num < 366)
					{
						return "月";
					}
					if (num < 365)
					{
						return "月";
					}
					return "岁";
				}
			}
			return null;
		}

		public override string GetFunction()
		{
			return "ageunit";
		}
	}
}
