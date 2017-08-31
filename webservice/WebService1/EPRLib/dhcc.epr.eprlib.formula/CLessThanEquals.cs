using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class CLessThanEquals : COperator
	{
		private CValue m_arg1;

		private CValue m_arg2;

		public CLessThanEquals()
		{
		}

		public CLessThanEquals(CValue arg1, CValue arg2)
		{
			this.CheckParms("<=", arg1, arg2);
			this.m_arg1 = arg1;
			this.m_arg2 = arg2;
		}

		public override string GetValue()
		{
			string value = this.m_arg1.GetValue();
			string value2 = this.m_arg2.GetValue();
			if (Information.IsDate(value) & Information.IsDate(value2))
			{
				return Strings.LCase((DateTime.Compare(DateTime.Parse(this.m_arg1.GetValue()), DateTime.Parse(this.m_arg2.GetValue())) <= 0).ToString());
			}
			if (Versioned.IsNumeric(value) & Versioned.IsNumeric(value2))
			{
				return Strings.LCase((float.Parse(this.m_arg1.GetValue()) <= float.Parse(this.m_arg2.GetValue())).ToString());
			}
			return "false";
		}

		public override bool IsMatch(Token tkn)
		{
			return Operators.CompareString(tkn.ToString(), "<=", false) == 0;
		}

		public override COperator Factory(CValue arg1, CValue arg2)
		{
			return new CLessThanEquals(arg1, arg2);
		}
	}
}
