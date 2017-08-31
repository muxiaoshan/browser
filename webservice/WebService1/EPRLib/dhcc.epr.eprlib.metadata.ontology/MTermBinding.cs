using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata.ontology
{
	public class MTermBinding
	{
		private string _Term;

		private Hashtable _MTerms;

		public string Term
		{
			get
			{
				return this._Term;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public MTermBinding()
		{
		}
	}
}
