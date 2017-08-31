using System;

namespace dhcc.epr.eprlib.presentation
{
	public interface ICheck
	{
		CheckMsg CheckNull();

		CheckMsg SpecialCheck();

		void SetMsg(bool hasError);
	}
}
