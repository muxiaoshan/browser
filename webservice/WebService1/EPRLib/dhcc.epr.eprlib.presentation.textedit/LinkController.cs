using dhcc.epr.eprlib.instancedata;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class LinkController : Controller
	{
		private NILink _BindNILink;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNILink;
			}
			set
			{
				this._BindNILink = (NILink)value;
			}
		}

		[DebuggerNonUserCode]
		public LinkController()
		{
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSimple(objTextEdit);
		}

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			return null;
		}

		public override UpdateArgs OnDelete(int pos, string value)
		{
			return null;
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
