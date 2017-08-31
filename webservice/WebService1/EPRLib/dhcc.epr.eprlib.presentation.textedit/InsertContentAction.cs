using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class InsertContentAction : IAction
	{
		private Controller _RootCtrlItem;

		private Controller _ParentCtrlItem;

		private Controller _InsertCtrlItem;

		private string _InsertContent;

		private int _InsertPos;

		private Controller curHEPRItem;

		private string insertString;

		private int pos;

		private PCTextEdit curHEPREdit;

		private NInstanceItem _BindNInstanceItem;

		private bool InsAfterIns;

		private bool NewIns;

		private bool InsAfterDeleteAll;

		private string OldContent;

		private SubRevision subrev;

		private SubRevision insertSubRevision;

		private SubRevision splitSubRevision;

		private Revision curRevision;

		public InsertContentAction(Controller objInsertCtrlItem, string strInsertContent, int intInsertPos)
		{
			this._InsertCtrlItem = objInsertCtrlItem;
			this._InsertContent = strInsertContent;
			this._InsertPos = intInsertPos;
			if (objInsertCtrlItem.Parent.Parent != null)
			{
				this._RootCtrlItem = objInsertCtrlItem.Parent.Parent;
				this._ParentCtrlItem = objInsertCtrlItem.Parent;
			}
			else if (objInsertCtrlItem.Parent != null)
			{
				this._RootCtrlItem = objInsertCtrlItem.Parent;
				this._ParentCtrlItem = objInsertCtrlItem.Parent;
			}
			else
			{
				this._RootCtrlItem = objInsertCtrlItem;
				this._ParentCtrlItem = objInsertCtrlItem;
			}
			this._BindNInstanceItem = this._RootCtrlItem.BindInstanceItem;
		}

		public UpdateArgs Execute()
		{
			checked
			{
				if (this._BindNInstanceItem.RevStatus)
				{
					if (this._BindNInstanceItem.RevisionHistory == null)
					{
						this._BindNInstanceItem.RevisionHistory = new RevisionHistory();
					}
					if (this._BindNInstanceItem.RevisionHistory.CurrentRevision == null)
					{
						Revision revision = new Revision();
						revision.RevPerson = this._BindNInstanceItem.RevPerson;
						revision.RevTime = this._BindNInstanceItem.RevTime;
						revision.RevIP = CommonFuncs.clientIP;
						revision.AddSubRevision(new SubRevision
						{
							RevType = "O",
							Content = this._BindNInstanceItem.WholeString
						});
						this._BindNInstanceItem.RevisionHistory.Revisions.Add(revision);
						this._BindNInstanceItem.RevisionHistory.CurrentRevision = revision;
					}
					this.curRevision = this._BindNInstanceItem.RevisionHistory.CurrentRevision;
					int realPos = this._RootCtrlItem.GetRealPos(this._InsertPos + this._InsertCtrlItem.StartPos);
					int num = 0;
					bool flag = false;
					try
					{
						IEnumerator enumerator = this.curRevision.SubRevisions.GetEnumerator();
						while (enumerator.MoveNext())
						{
							SubRevision subRevision = (SubRevision)enumerator.Current;
							if (realPos >= subRevision.StartPos & realPos <= subRevision.EndPos & (Operators.CompareString(subRevision.RevType, "R", false) == 0 | Operators.CompareString(subRevision.RevType, "O", false) == 0))
							{
								flag = true;
								if (Operators.CompareString(subRevision.RevType, "R", false) == 0)
								{
									this.InsAfterIns = true;
									this.OldContent = subRevision.Content;
									subRevision.Content = subRevision.Content.Insert(realPos - subRevision.StartPos, this._InsertContent);
									break;
								}
								this.OldContent = subRevision.Content;
								this.NewIns = true;
								if (subRevision.EndPos == realPos)
								{
									this.insertSubRevision = new SubRevision();
									this.insertSubRevision.RevType = "R";
									this.insertSubRevision.Content = this._InsertContent;
									this.curRevision.SubRevisions.Insert(num + 1, this.insertSubRevision);
								}
								else if (subRevision.StartPos == realPos)
								{
									this.insertSubRevision = new SubRevision();
									this.insertSubRevision.RevType = "R";
									this.insertSubRevision.Content = this._InsertContent;
									this.curRevision.SubRevisions.Insert(num, this.insertSubRevision);
								}
								else
								{
									this.splitSubRevision = new SubRevision();
									this.splitSubRevision.RevType = subRevision.RevType;
									this.splitSubRevision.Content = this.OldContent.Substring(realPos - subRevision.StartPos, subRevision.EndPos - realPos);
									subRevision.Content = this.OldContent.Substring(0, realPos - subRevision.StartPos);
									this.curRevision.SubRevisions.Insert(num + 1, this.splitSubRevision);
									this.insertSubRevision = new SubRevision();
									this.insertSubRevision.RevType = "R";
									this.insertSubRevision.Content = this._InsertContent;
									this.curRevision.SubRevisions.Insert(num + 1, this.insertSubRevision);
								}
								break;
							}
							else
							{
								num++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (!flag)
					{
						this.InsAfterDeleteAll = true;
						this.insertSubRevision = new SubRevision();
						this.insertSubRevision.RevType = "R";
						this.insertSubRevision.Content = this._InsertContent;
						this.curRevision.SubRevisions.Add(this.insertSubRevision);
					}
					this.curRevision.RefreshPos();
				}
				this._InsertCtrlItem.Text = this._InsertCtrlItem.Text.Insert(this._InsertPos, this._InsertContent);
				return null;
			}
		}

		public UpdateArgs UnExecute()
		{
			this._InsertCtrlItem.Text = this._InsertCtrlItem.Text.Remove(this._InsertPos, this._InsertContent.Length);
			return null;
		}
	}
}
