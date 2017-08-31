using dhcc.epr.eprlib.instancedata;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class CVariableVControl : CVariable
	{
		public CVariableVControl(string strTID, string strCode, string strVType, string admid) : base(strTID, strCode, strVType, admid)
		{
		}

		public CVariableVControl(string strCode, string strVType, NInstanceItem item) : base(strCode, strVType, item)
		{
		}

		public override string GetValue()
		{
			return this._StrValue;
		}

		public override void SetValue(string strValue)
		{
			this._StrValue = strValue;
		}
	}
}
