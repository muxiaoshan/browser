using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata.ontology
{
	public class MOntology
	{
		private string _PrimaryLanguage;

		private Hashtable _MLangDefinitions;

		private Hashtable _MTermBindings;

		public string PrimaryLanguage
		{
			get
			{
				return this._PrimaryLanguage;
			}
			set
			{
				this._PrimaryLanguage = value;
			}
		}

		[DebuggerNonUserCode]
		public MOntology()
		{
		}
	}
}
