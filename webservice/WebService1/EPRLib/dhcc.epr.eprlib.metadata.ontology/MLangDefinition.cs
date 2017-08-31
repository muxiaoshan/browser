using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata.ontology
{
	public class MLangDefinition
	{
		private string _LangCode;

		private Hashtable _MDefinitions;

		public string LangCode
		{
			get
			{
				return this._LangCode;
			}
			set
			{
				this._LangCode = value;
			}
		}

		[DebuggerNonUserCode]
		public MLangDefinition()
		{
		}
	}
}
