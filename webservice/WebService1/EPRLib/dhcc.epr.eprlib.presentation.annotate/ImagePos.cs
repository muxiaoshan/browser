using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class ImagePos
	{
		private string _Name;

		private string _Code;

		private string _Desc;

		private string _Data;

		private string _ID;

		private MIImageAnnotate _MIImageAnnotate;

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

		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				this._Data = value;
			}
		}

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

		public MIImageAnnotate MIImageAnnotate
		{
			get
			{
				return this._MIImageAnnotate;
			}
			set
			{
				this._MIImageAnnotate = value;
			}
		}

		[DebuggerNonUserCode]
		public ImagePos()
		{
		}

		public override string ToString()
		{
			return this._Name;
		}
	}
}
