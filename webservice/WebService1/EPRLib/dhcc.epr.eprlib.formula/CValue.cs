using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CValue
	{
		private ValueType _ValueType;

		protected string _StrValue;

		public ValueType ValueType
		{
			get
			{
				return this._ValueType;
			}
			set
			{
				this._ValueType = this.ValueType;
			}
		}

		[DebuggerNonUserCode]
		public CValue()
		{
		}

		public virtual string GetValue()
		{
			return this._StrValue;
		}

		public virtual void SetValue(string strValue)
		{
			this._StrValue = strValue;
		}
	}
}
