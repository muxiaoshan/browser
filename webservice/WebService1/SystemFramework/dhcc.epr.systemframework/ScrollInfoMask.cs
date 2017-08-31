using System;

namespace dhcc.epr.systemframework
{
	internal enum ScrollInfoMask
	{
		SIF_RANGE = 1,
		SIF_PAGE,
		SIF_POS = 4,
		SIF_DISABLENOSCROLL = 8,
		SIF_TRACKPOS = 16,
		SIF_ALL = 31
	}
}
