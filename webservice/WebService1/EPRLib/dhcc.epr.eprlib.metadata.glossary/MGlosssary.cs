using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata.glossary
{
	public class MGlosssary
	{
		private string _ID;

		private string _Name;

		private string _Desc;

		private string _GUID;

		private string _GlossaryCategoryID;

		private string _GlossaryType;

		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				this._GUID = value;
			}
		}

		public string GlossaryCategoryID
		{
			get
			{
				return this._GlossaryCategoryID;
			}
			set
			{
				this._GlossaryCategoryID = value;
			}
		}

		public string GlossaryType
		{
			get
			{
				return this._GlossaryType;
			}
			set
			{
				this._GlossaryType = value;
			}
		}

		[DebuggerNonUserCode]
		public MGlosssary()
		{
		}
	}
}
