using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class CNotEquals : COperator
	{
		private CValue m_arg1;

		private CValue m_arg2;

		public CNotEquals()
		{
		}

		public CNotEquals(CValue arg1, CValue arg2)
		{
			this.CheckParms("<>", arg1, arg2);
			this.m_arg1 = arg1;
			this.m_arg2 = arg2;
		}

		public override string GetValue()
		{
			return Strings.LCase((Operators.CompareString(this.m_arg1.GetValue(), this.m_arg2.GetValue(), false) != 0).ToString());
		}

		public override bool IsMatch(Token tkn)
		{
			return Operators.CompareString(tkn.ToString(), "<>", false) == 0;
		}

		public override COperator Factory(CValue arg1, CValue arg2)
		{
			return new CNotEquals(arg1, arg2);
		}
	}
}
