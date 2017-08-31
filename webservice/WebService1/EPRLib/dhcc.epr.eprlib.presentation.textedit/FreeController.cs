using dhcc.epr.eprlib.instancedata;
using dhcc.epr.systemframework;
using System;
using System.Diagnostics;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class FreeController : Controller
	{
		private NIFree _BindNIFree;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNIFree;
			}
			set
			{
				this._BindNIFree = (NIFree)value;
			}
		}

		[DebuggerNonUserCode]
		public FreeController()
		{
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			this.StartPos = objTextEdit.SelectionStart;
			string text = this.Text;
			text = text.Replace("\n", "&KeyEnter;");
			text = text.Replace("&KeyEnter;", "\r");
			objTextEdit.SelectedText = text.Replace("&nbsp;", " ");
			if (text.IndexOf("&KeyEnter;") != -1)
			{
				objTextEdit.SelectedText = text.Replace("&KeyEnter;", "\r");
				text = objTextEdit.SelectedText;
			}
			this.EndPos = objTextEdit.SelectionStart;
			checked
			{
				this.DrawBackColor(objTextEdit, this.StartPos, this.EndPos - this.StartPos, Color.White);
				this.DrawForeColor(objTextEdit, this.StartPos, this.EndPos - this.StartPos, Color.Black);
			}
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

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			this.Text = this.Text.Replace("&nbsp;", " ");
			this.Text = this.Text.Replace("&KeyEnter;", "\r");
			checked
			{
				int num = pos - this.StartPos;
				InsertContentAction insertContentAction = new InsertContentAction(this, value, num);
				EventLogHelper eventLogHelper = new EventLogHelper();
				this.ActionManager.AddToActionList(insertContentAction);
				insertContentAction.Execute();
				UpdateArgs updateArgs = new UpdateArgs();
				updateArgs.IsRefresh = true;
				updateArgs.Pos = pos + value.Length;
				if (this.BindInstanceItem.FormatRangeCollection != null)
				{
					this.BindInstanceItem.FormatRangeCollection.OnInsertString(num, value, this.ActionManager);
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnDelete(int pos, string value)
		{
			this.Text = this.Text.Replace("&nbsp;", " ");
			this.Text = this.Text.Replace("&KeyEnter;", "\r");
			int num = checked(pos - this.StartPos);
			DeleteContentAction deleteContentAction = new DeleteContentAction(this, value, num);
			this.ActionManager.AddToActionList(deleteContentAction);
			deleteContentAction.Execute();
			UpdateArgs updateArgs = new UpdateArgs();
			updateArgs.IsRefresh = true;
			updateArgs.Pos = pos;
			this.BindInstanceItem.FormatRangeCollection.OnDeleteString(num, value, this.ActionManager);
			return updateArgs;
		}

		public override UpdateArgs OnEnterKeyDown(int pos)
		{
			return this.OnInsertString(pos, "\r");
		}
	}
}
