using System;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public struct RuleParamItem
	{
		public string RuleID;

		public string RuleDesc;

		public string RuleParamCode;

		public string RuleParamDesc;

		public override string ToString()
		{
			return this.RuleParamDesc;
		}
	}
}
