using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CHourDiff : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CHourDiff()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CHourDiff cHourDiff = new CHourDiff();
			cHourDiff.SetParameters(alValues);
			return cHourDiff;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 3);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			string result;
			try
			{
				string value = ((CValue)this.m_alValues[0]).GetValue();
				string value2 = ((CValue)this.m_alValues[1]).GetValue();
				if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value2))
				{
					result = string.Empty;
				}
				else
				{
					DateTime value3 = DateTime.Parse(value);
					DateTime dateTime = DateTime.Parse(value2);
					CValue cValue = (CValue)this.m_alValues[2];
					int numDigitsAfterDecimal = 1;
					if (!string.IsNullOrEmpty(cValue.GetValue()))
					{
						numDigitsAfterDecimal = int.Parse(cValue.GetValue());
					}
					result = Strings.FormatNumber(dateTime.Subtract(value3).TotalHours, numDigitsAfterDecimal, TriState.True, TriState.False, TriState.False);
				}
			}
			catch (FormatException expr_AF)
			{
				ProjectData.SetProjectError(expr_AF);
				throw new Exception("日期格式错误");
			}
			catch (ArgumentNullException expr_C2)
			{
				ProjectData.SetProjectError(expr_C2);
				throw new Exception("日期格式错误");
			}
			return result;
		}

		public override string GetFunction()
		{
			return "hourdiff";
		}
	}
}
