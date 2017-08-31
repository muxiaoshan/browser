using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class UpdateArgs
	{
		public bool IsRefresh;

		public int Pos;

		public bool TextChanged;

		[DebuggerNonUserCode]
		public UpdateArgs()
		{
		}
	}
}
