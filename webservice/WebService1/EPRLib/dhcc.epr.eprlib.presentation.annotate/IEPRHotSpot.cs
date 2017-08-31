using System;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public interface IEPRHotSpot
	{
		Color Color
		{
			get;
			set;
		}

		EPRAnnoMode AnnoMode
		{
			get;
			set;
		}

		string HSName
		{
			get;
			set;
		}

		string HSCode
		{
			get;
			set;
		}

		string HSDesc
		{
			get;
			set;
		}

		bool MultiSelected
		{
			get;
			set;
		}
	}
}
