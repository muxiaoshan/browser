using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CMid : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CMid()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CMid cMid = new CMid();
			cMid.SetParameters(alValues);
			return cMid;
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
			string value = cValue2.GetValue();
			string value2 = cValue3.GetValue();
			string value3 = cValue.GetValue();
			if (Versioned.IsNumeric(value) & Versioned.IsNumeric(value2) & value3 != null)
			{
				int num = int.Parse(value);
				int num2 = int.Parse(value2);
				if (num >= 0 & num < value3.Length & num2 > 0 & checked(num + num2) < value3.Length)
				{
					return Strings.Mid(value3, num, num2);
				}
			}
			return null;
		}

		public override string GetFunction()
		{
			return "mid";
		}
	}
}
