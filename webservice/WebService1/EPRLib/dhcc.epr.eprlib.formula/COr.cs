using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class COr : COperator
	{
		private CValue m_arg1;

		private CValue m_arg2;

		public COr()
		{
		}

		public COr(CValue arg1, CValue arg2)
		{
			this.CheckParms("||", arg1, arg2);
			this.m_arg1 = arg1;
			this.m_arg2 = arg2;
		}

		public override string GetValue()
		{
			string value = this.m_arg1.GetValue();
			string value2 = this.m_arg2.GetValue();
			if ((Operators.CompareString(value, "true", false) == 0 | Operators.CompareString(value, "false", false) == 0) & (Operators.CompareString(value2, "true", false) == 0 | Operators.CompareString(value2, "false", false) == 0))
			{
				return Strings.LCase((bool.Parse(this.m_arg1.GetValue()) | bool.Parse(this.m_arg2.GetValue())).ToString());
			}
			return "false";
		}

		public override bool IsMatch(Token tkn)
		{
			return Operators.CompareString(tkn.ToString(), "||", false) == 0;
		}

		public override COperator Factory(CValue arg1, CValue arg2)
		{
			return new COr(arg1, arg2);
		}
	}
}
