using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CInStr : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CInStr()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CInStr cInStr = new CInStr();
			cInStr.SetParameters(alValues);
			return cInStr;
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
			return Strings.InStr(cValue.GetValue(), cValue2.GetValue(), CompareMethod.Binary).ToString();
		}

		public override string GetFunction()
		{
			return "instr";
		}
	}
}
