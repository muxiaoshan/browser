using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CFunction : CValue
	{
		[DebuggerNonUserCode]
		public CFunction()
		{
		}

		public virtual string GetFunction()
		{
			return null;
		}

		public virtual void SetParameters(ArrayList alValues)
		{
		}

		public virtual CFunction CreateInstance(ArrayList alValues)
		{
			return null;
		}

		protected void CheckParms(ArrayList alValues, int iRequiredValueCount)
		{
			if (alValues.Count != iRequiredValueCount)
			{
				string message = string.Format("函数 " + this.GetFunction() + " 需要 {0} 个参数", iRequiredValueCount);
				throw new ApplicationException(message);
			}
		}

		protected void CheckParms(ArrayList alValues, int iMinReq, int iMaxReq)
		{
			if (iMinReq > -1 && iMinReq > alValues.Count)
			{
				string message = string.Format("函数 " + this.GetFunction() + " 最少需要 {0} 个参数", iMinReq);
				throw new ApplicationException(message);
			}
			if (iMaxReq > -1 && iMaxReq < alValues.Count)
			{
				string message2 = string.Format("函数 " + this.GetFunction() + " 最多需要  {0} 个参数", iMaxReq);
				throw new ApplicationException(message2);
			}
		}
	}
}
