using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class StringController : SimpleController
	{
		private string _keyValueFlag;

		public string KeyValueFlag
		{
			get
			{
				return this._keyValueFlag;
			}
			set
			{
				this._keyValueFlag = value;
			}
		}

		public StringController()
		{
			this._keyValueFlag = string.Empty;
		}

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			UpdateArgs updateArgs = new UpdateArgs();
			updateArgs.IsRefresh = false;
			MIString mIString = (MIString)this.BindInstanceItem.BindMMetaItem;
			int maxLength = mIString.MaxLength;
			if (mIString.NeedCheckLength && CommonFuncs.IsOverflowMaxLength(value, maxLength, this.Text, string.Empty))
			{
				updateArgs.Pos = pos;
				return updateArgs;
			}
			checked
			{
				int num;
				if (Operators.CompareString(this.Text, "", false) == 0)
				{
					if (Operators.CompareString(this.KeyValueFlag, "13", false) == 0)
					{
						updateArgs.Pos = pos;
						this._keyValueFlag = string.Empty;
						return updateArgs;
					}
					num = 0;
				}
				else
				{
					num = pos - this.StartPos;
				}
				InsertContentAction insertContentAction = new InsertContentAction(this, value, num);
				this.ActionManager.AddToActionList(insertContentAction);
				insertContentAction.Execute();
				if (this.BindInstanceItem.FormatRangeCollection != null)
				{
					this.BindInstanceItem.FormatRangeCollection.OnInsertString(num, value, this.ActionManager);
				}
				updateArgs.IsRefresh = true;
				if (num == 0)
				{
					updateArgs.Pos = this.StartPos + value.Length;
				}
				else
				{
					updateArgs.Pos = pos + value.Length;
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnDelete(int pos, string value)
		{
			checked
			{
				int num = pos - this.StartPos;
				DeleteContentAction deleteContentAction = new DeleteContentAction(this, value, num);
				this.ActionManager.AddToActionList(deleteContentAction);
				deleteContentAction.Execute();
				this.BindInstanceItem.FormatRangeCollection.OnDeleteString(num, value, this.ActionManager);
				return new UpdateArgs
				{
					IsRefresh = true,
					Pos = pos + value.Length
				};
			}
		}

		public override UpdateArgs OnEnterKeyDown(int pos)
		{
			this.KeyValueFlag = "13";
			return this.OnInsertString(pos, "\r");
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSimple(objTextEdit);
		}
	}
}
