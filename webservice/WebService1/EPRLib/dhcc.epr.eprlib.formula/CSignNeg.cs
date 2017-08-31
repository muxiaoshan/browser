using System;

namespace dhcc.epr.eprlib.formula
{
	public class CSignNeg : CValue
	{
		private CValue m_oValue;

		public CSignNeg(CValue oValue)
		{
			this.m_oValue = oValue;
		}

		public override string GetValue()
		{
			return (float.Parse(this.m_oValue.GetValue()) * -1f).ToString();
		}
	}
}
