using dhcc.epr.eprlib.instancedata;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class SimpleController : Controller
	{
		private NISimple _BindNISimple;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNISimple;
			}
			set
			{
				this._BindNISimple = (NISimple)value;
			}
		}

		[DebuggerNonUserCode]
		public SimpleController()
		{
		}

		public override UpdateArgs OnCursorMove(int intPos, int destPos)
		{
			UpdateArgs updateArgs = new UpdateArgs();
			if (this.Active)
			{
				updateArgs.IsRefresh = false;
				updateArgs.Pos = destPos;
				return updateArgs;
			}
			this.Active = true;
			if (Math.Abs(checked(intPos - destPos)) == 1)
			{
				updateArgs.IsRefresh = true;
				updateArgs.Pos = intPos;
				return updateArgs;
			}
			updateArgs.IsRefresh = true;
			updateArgs.Pos = destPos;
			return updateArgs;
		}
	}
}
