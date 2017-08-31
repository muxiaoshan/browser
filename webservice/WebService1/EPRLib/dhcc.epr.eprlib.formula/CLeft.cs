using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CLeft : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CLeft()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CLeft cLeft = new CLeft();
			cLeft.SetParameters(alValues);
			return cLeft;
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
			string value = cValue2.GetValue();
			string value2 = cValue.GetValue();
			if (Versioned.IsNumeric(value) & value2 != null)
			{
				int num = int.Parse(value);
				if (num > 0 & num <= value2.Length)
				{
					return Strings.Left(value2, num);
				}
			}
			return null;
		}

		public override string GetFunction()
		{
			return "left";
		}
	}
}
