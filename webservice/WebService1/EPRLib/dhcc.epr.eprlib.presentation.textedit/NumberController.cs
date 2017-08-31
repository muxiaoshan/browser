using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class NumberController : SimpleController
	{
		[DebuggerNonUserCode]
		public NumberController()
		{
		}

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			checked
			{
				int num;
				if (Operators.CompareString(this.Text, "", false) == 0)
				{
					num = 0;
				}
				else
				{
					num = pos - this.StartPos;
				}
				string expression = this.Text.Insert(num, value);
				bool flag = true;
				if (!Versioned.IsNumeric(expression))
				{
					flag = false;
				}
				UpdateArgs updateArgs = new UpdateArgs();
				if (flag)
				{
					InsertContentAction insertContentAction = new InsertContentAction(this, value, num);
					this.ActionManager.AddToActionList(insertContentAction);
					insertContentAction.Execute();
					updateArgs.IsRefresh = true;
					if (num == 0)
					{
						updateArgs.Pos = this.StartPos + value.Length;
					}
					else
					{
						updateArgs.Pos = pos + value.Length;
					}
				}
				else
				{
					updateArgs.IsRefresh = false;
					updateArgs.Pos = pos;
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnDelete(int pos, string value)
		{
			DeleteContentAction deleteContentAction = new DeleteContentAction(this, value, checked(pos - this.StartPos));
			this.ActionManager.AddToActionList(deleteContentAction);
			deleteContentAction.Execute();
			return new UpdateArgs
			{
				IsRefresh = true
			};
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSimple(objTextEdit);
		}
	}
}
