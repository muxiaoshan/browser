using System;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public interface IAction
	{
		UpdateArgs Execute();

		UpdateArgs UnExecute();
	}
}
