using System;

namespace dhcc.epr.eprlib.formula
{
	public class CConstVarialbe : CValue
	{
		public CConstVarialbe(ValueType vtype, string strValue)
		{
			this.ValueType = vtype;
			this.SetValue(strValue);
		}
	}
}
