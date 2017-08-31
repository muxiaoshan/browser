using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata
{
	public class ChoiceItem
	{
		private string _ChoiceValue;

		private string _ChoiceCode;

		public string ChoiceValue
		{
			get
			{
				return this._ChoiceValue;
			}
			set
			{
				this._ChoiceValue = value;
			}
		}

		public string ChoiceCode
		{
			get
			{
				return this._ChoiceCode;
			}
			set
			{
				this._ChoiceCode = value;
			}
		}

		[DebuggerNonUserCode]
		public ChoiceItem()
		{
		}

		public override string ToString()
		{
			return this._ChoiceValue;
		}
	}
}
