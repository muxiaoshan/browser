using System;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public interface IPosConvertor
	{
		string NameConvertor(string strName);

		Image ImageConvertor(string strCode);
	}
}
