using System;

namespace dhcc.epr.eprlib.presentation
{
	public interface ICheckValueChanged
	{
		void IsValueChanged(ref bool isChanged);

		void SetInitValue();
	}
}
