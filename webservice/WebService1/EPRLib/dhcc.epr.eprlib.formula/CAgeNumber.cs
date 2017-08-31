using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CAgeNumber : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CAgeNumber()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CAgeNumber cAgeNumber = new CAgeNumber();
			cAgeNumber.SetParameters(alValues);
			return cAgeNumber;
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
						return num.ToString();
					}
					if (DateTime.IsLeapYear(dateTime.Year) & dateTime.Month < 3 & num < 366)
					{
						return DateAndTime.DateDiff(DateInterval.Month, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
					}
					if (num < 365)
					{
						return DateAndTime.DateDiff(DateInterval.Month, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
					}
					return DateAndTime.DateDiff(DateInterval.Year, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
				}
			}
			return null;
		}

		public override string GetFunction()
		{
			return "agenumber";
		}
	}
}
