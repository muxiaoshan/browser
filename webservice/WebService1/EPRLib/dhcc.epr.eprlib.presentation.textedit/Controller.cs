using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class Controller
	{
		private int _StartPos;

		private int _EndPos;

		private Controller _Parent;

		private ControllerCollection _SubItems;

		private bool _Active;

		private int _ActiveItem;

		private PCTextEdit _CurrentTextEdit;

		private ActionManager _ActionManager;

		public int StartPos
		{
			get
			{
				return this._StartPos;
			}
			set
			{
				this._StartPos = value;
			}
		}

		public int EndPos
		{
			get
			{
				return this._EndPos;
			}
			set
			{
				this._EndPos = value;
			}
		}

		public Controller Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				this._Parent = value;
			}
		}

		public ControllerCollection SubItems
		{
			get
			{
				return this._SubItems;
			}
			set
			{
				this._SubItems = value;
			}
		}

		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				this._Active = value;
			}
		}

		public int ActiveItem
		{
			get
			{
				return this._ActiveItem;
			}
			set
			{
				this._ActiveItem = value;
			}
		}

		public PCTextEdit CurrentTextEdit
		{
			get
			{
				return this._CurrentTextEdit;
			}
			set
			{
				this._CurrentTextEdit = value;
			}
		}

		public ActionManager ActionManager
		{
			get
			{
				return this._ActionManager;
			}
			set
			{
				this._ActionManager = value;
			}
		}

		public virtual NInstanceItem BindInstanceItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Text
		{
			get
			{
				return this.BindInstanceItem.Value;
			}
			set
			{
				this.BindInstanceItem.Value = value;
			}
		}

		public string ValueCode
		{
			get
			{
				return this.BindInstanceItem.ValueCode;
			}
			set
			{
				this.BindInstanceItem.ValueCode = value;
			}
		}

		public string Name
		{
			get
			{
				return this.BindInstanceItem.BindMMetaItem.Text;
			}
		}

		protected virtual string NullText
		{
			get
			{
				return "{" + this.Name + "}";
			}
		}

		[DebuggerNonUserCode]
		public Controller()
		{
		}

		public virtual void OnUpdate(UpdateArgs objUpdateArgs)
		{
		}

		public virtual void Draw(PCTextEdit objTextEdit)
		{
			try
			{
				this.StartPos = objTextEdit.SelectionStart;
				if (Operators.CompareString(this.Text, "", false) == 0)
				{
					objTextEdit.SelectedText = this.NullText;
				}
				else
				{
					objTextEdit.SelectedText = this.Text;
				}
				this.EndPos = objTextEdit.SelectionStart;
				objTextEdit.SelectionStart = this.StartPos;
				objTextEdit.SelectionLength = checked(this.EndPos - this.StartPos);
			}
			catch (Exception expr_67)
			{
				ProjectData.SetProjectError(expr_67);
				Interaction.MsgBox("结构化单元定位失败", MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void DrawSimple(PCTextEdit objTextEdit)
		{
			int selectionStart = objTextEdit.SelectionStart;
			int selectionLength = objTextEdit.SelectionLength;
			if (this.Active)
			{
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.Gainsboro);
			}
			else
			{
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.White);
			}
			if (this.Text.Equals(string.Empty))
			{
				this.DrawForeColor(objTextEdit, selectionStart, selectionLength, Color.FromArgb(48, 114, 0));
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.Gainsboro);
			}
			else
			{
				this.DrawForeColor(objTextEdit, selectionStart, selectionLength, Color.FromArgb(0, 165, 132));
			}
		}

		public void DrawSelection(PCTextEdit objTextEdit)
		{
			int selectionStart = objTextEdit.SelectionStart;
			int selectionLength = objTextEdit.SelectionLength;
			if (this.Active)
			{
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.Gainsboro);
			}
			else
			{
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.White);
			}
			if (this.Text.Equals(string.Empty))
			{
				this.DrawForeColor(objTextEdit, selectionStart, selectionLength, Color.FromArgb(0, 102, 255));
				this.DrawBackColor(objTextEdit, selectionStart, selectionLength, Color.Gainsboro);
			}
			else
			{
				this.DrawForeColor(objTextEdit, selectionStart, selectionLength, Color.FromArgb(0, 0, 255));
			}
		}

		internal void DrawBackColor(PCTextEdit objTextEdit, int startPosition, int textLength, Color backColor)
		{
			objTextEdit.SelectionStart = startPosition;
			objTextEdit.SelectionLength = textLength;
			objTextEdit.SelectionBackColor = backColor;
		}

		internal void DrawForeColor(PCTextEdit objTextEdit, int startPosition, int textLength, Color foreColor)
		{
			objTextEdit.SelectionStart = startPosition;
			objTextEdit.SelectionLength = textLength;
			objTextEdit.SelectionForeColor = foreColor;
		}

		public virtual UpdateArgs OnCursorMove(int intPos, int destPos)
		{
			return null;
		}

		public virtual UpdateArgs OnTabKeyPressed(int pos, bool offset)
		{
			return null;
		}

		public virtual UpdateArgs OnInsertString(int pos, string value)
		{
			return null;
		}

		public virtual UpdateArgs OnEnterKeyDown(int pos)
		{
			return null;
		}

		public virtual UpdateArgs OnDoubleClick(int pos)
		{
			return null;
		}

		public virtual UpdateArgs OnInsertItem(int pos, NInstanceItem itemInsert)
		{
			return null;
		}

		public virtual UpdateArgs OnDelete(int pos, string value)
		{
			return null;
		}

		public virtual UpdateArgs OnFormate(int intpos, int destpos, FontStruct oldFontStruct, FontStruct newFontStruct)
		{
			return null;
		}

		public virtual UpdateArgs OnUndo()
		{
			return null;
		}

		public virtual UpdateArgs OnRedo()
		{
			return null;
		}

		public virtual UpdateArgs OnUpdateLinkItem(string patientID)
		{
			return null;
		}

		public virtual int GetRealPos(int pos)
		{
			int num = 0;
			ControllerEnumerator enumerator = this.SubItems.GetEnumerator();
			checked
			{
				while (enumerator.MoveNext())
				{
					Controller controller = (Controller)enumerator.Current;
					if (pos >= controller.StartPos & pos <= controller.EndPos)
					{
						if (controller.Text != null && Operators.CompareString(controller.Text, "", false) != 0)
						{
							num += pos - controller.StartPos;
						}
						return num;
					}
					if (controller.Text != null && Operators.CompareString(controller.Text, "", false) != 0)
					{
						num += controller.Text.Length;
					}
				}
				int result;
				return result;
			}
		}

		public bool InterSection(int pos)
		{
			return pos >= this.StartPos & pos <= this.EndPos;
		}

		public void DeActive()
		{
			this.Active = false;
			if (this.SubItems != null & this.ActiveItem > -1)
			{
				this.SubItems[this.ActiveItem].Active = false;
				this.ActiveItem = -1;
			}
		}

		public virtual void SyncInstanceItem(NInstanceItem objInstanceItem)
		{
		}
	}
}
