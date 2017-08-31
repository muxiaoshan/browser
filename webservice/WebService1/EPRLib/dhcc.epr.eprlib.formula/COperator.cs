using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class COperator : CValue
	{
		[DebuggerNonUserCode]
		public COperator()
		{
		}

		public virtual bool IsMatch(Token tkn)
		{
			return false;
		}

		public virtual COperator Factory(CValue arg1, CValue arg2)
		{
			return null;
		}

		public virtual void CheckParms(string sOp, CValue arg1, CValue arg2)
		{
			if (arg1 == null | arg2 == null)
			{
				throw new ApplicationException(sOp + " 操作符缺少表达式");
			}
		}
	}
}
