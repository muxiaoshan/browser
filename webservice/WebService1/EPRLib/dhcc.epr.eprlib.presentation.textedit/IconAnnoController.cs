using dhcc.epr.eprlib.instancedata;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class IconAnnoController : Controller
	{
		private NISimple _BindNIIconAnno;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNIIconAnno;
			}
			set
			{
				this._BindNIIconAnno = (NISimple)value;
			}
		}

		protected override string NullText
		{
			get
			{
				return "{无效的自定义图释名称}";
			}
		}

		[DebuggerNonUserCode]
		public IconAnnoController()
		{
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSelection(objTextEdit);
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
