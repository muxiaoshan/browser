using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata.ontology
{
	public class MTermBindingItem
	{
		private string _Code;

		private StringCollection _TermCodes;

		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		public StringCollection BindTermCodes
		{
			get
			{
				return this._TermCodes;
			}
			set
			{
				this._TermCodes = value;
			}
		}

		[DebuggerNonUserCode]
		public MTermBindingItem()
		{
		}
	}
}
