using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class TextDescProperty
	{
		private string _TextDescName;

		private string _TextDescCode;

		public string TextDescName
		{
			get
			{
				return this._TextDescName;
			}
			set
			{
				this._TextDescName = value;
			}
		}

		public string TextDescCode
		{
			get
			{
				return this._TextDescCode;
			}
			set
			{
				this._TextDescCode = value;
			}
		}

		[DebuggerNonUserCode]
		public TextDescProperty()
		{
		}

		public override string ToString()
		{
			return this._TextDescName;
		}
	}
}
