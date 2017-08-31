using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class ActionManager
	{
		private ArrayList ActionList;

		private int curAction;

		public bool CanUndo
		{
			get
			{
				return this.curAction >= 0;
			}
		}

		public bool CanRedo
		{
			get
			{
				return this.curAction < checked(this.ActionList.Count - 1);
			}
		}

		public ActionManager()
		{
			this.curAction = -1;
			this.ActionList = new ArrayList();
		}

		public void AddToActionList(IAction Value)
		{
			checked
			{
				if (this.curAction < this.ActionList.Count - 1)
				{
					this.ActionList.RemoveRange(this.curAction + 1, this.ActionList.Count - this.curAction - 1);
				}
				this.ActionList.Add(Value);
				this.curAction++;
			}
		}

		public UpdateArgs Undo()
		{
			checked
			{
				if (this.CanUndo)
				{
					IAction action = (IAction)this.ActionList[this.curAction];
					this.curAction--;
					return action.UnExecute();
				}
				return null;
			}
		}

		public UpdateArgs Redo()
		{
			checked
			{
				if (this.CanRedo)
				{
					this.curAction++;
					IAction action = (IAction)this.ActionList[this.curAction];
					return action.Execute();
				}
				return null;
			}
		}

		public void ClearActions()
		{
			this.ActionList.Clear();
			this.curAction = -1;
		}
	}
}
