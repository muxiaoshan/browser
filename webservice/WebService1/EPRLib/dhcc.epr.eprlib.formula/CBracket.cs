using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CBracket : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CBracket()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CBracket cBracket = new CBracket();
			cBracket.SetParameters(alValues);
			return cBracket;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 1);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			if (this.m_alValues[0] is COperator)
			{
				return ((COperator)this.m_alValues[0]).GetValue();
			}
			if (this.m_alValues[0] is CFunction)
			{
				return ((CFunction)this.m_alValues[0]).GetValue();
			}
			return string.Empty;
		}

		public override string GetFunction()
		{
			return "((";
		}
	}
}
