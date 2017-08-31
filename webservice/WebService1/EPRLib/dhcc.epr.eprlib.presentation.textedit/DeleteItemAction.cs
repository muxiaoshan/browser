using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class DeleteItemAction : IAction
	{
		private Controller _RootCtrlItem;

		private Controller _ParentCtrlItem;

		private Controller _DeleteCtrlItem;

		private int _DeletePos;

		private int insertPos;

		private Controller curHEPRItem;

		private int pos;

		private bool offset;

		private PCTextEdit curHEPREdit;

		private NInstanceItem _BindNInstanceItem;

		private bool DelAfterDel;

		private bool DelAfterIns;

		private bool NewDel;

		private string OldContent;

		private string originContent;

		private SubRevision subrev;

		private SubRevision delSubRevision;

		private SubRevision splitSubRevision;

		private SubRevision originSubRevision;

		private Revision curRevision;

		private int posOriginSubRevision;

		public DeleteItemAction(Controller objPatentCtrlItem, Controller objInsertCtrlItem)
		{
			this._ParentCtrlItem = objPatentCtrlItem;
			this._DeleteCtrlItem = objInsertCtrlItem;
			this._DeletePos = this._ParentCtrlItem.SubItems.IndexOf(this._DeleteCtrlItem);
			this.pos = this.pos;
			if (objPatentCtrlItem.Parent != null)
			{
				this._RootCtrlItem = objPatentCtrlItem.Parent;
			}
			else
			{
				this._RootCtrlItem = objPatentCtrlItem;
			}
			this._BindNInstanceItem = this._RootCtrlItem.BindInstanceItem;
			this.offset = true;
		}

		public UpdateArgs Execute()
		{
			checked
			{
				if (this._BindNInstanceItem.RevStatus & Operators.CompareString(this._DeleteCtrlItem.Text, "", false) != 0)
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
					int realPos = this._RootCtrlItem.GetRealPos(this._DeleteCtrlItem.StartPos);
					int num = 0;
					int num2 = 0;
					try
					{
						IEnumerator enumerator = this.curRevision.SubRevisions.GetEnumerator();
						while (enumerator.MoveNext())
						{
							SubRevision subRevision = (SubRevision)enumerator.Current;
							if (subRevision.StartPos == realPos & Operators.CompareString(subRevision.RevType, "D", false) == 0)
							{
								this.DelAfterDel = true;
								this.delSubRevision = subRevision;
								num2 = num;
							}
							num++;
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
					if (this.DelAfterDel)
					{
						this.OldContent = this.delSubRevision.Content;
						this.delSubRevision.Content = this.OldContent + this._DeleteCtrlItem.Text;
						if (this.offset)
						{
							int arg_1F8_0 = num2 + 1;
							int num3 = this.curRevision.SubRevisions.Count - 1;
							for (int i = arg_1F8_0; i <= num3; i++)
							{
								SubRevision subRevision2 = (SubRevision)this.curRevision.SubRevisions[i];
								if (Operators.CompareString(subRevision2.RevType, "D", false) != 0)
								{
									this.originSubRevision = subRevision2;
									this.originContent = this.originSubRevision.Content;
									this.originSubRevision.Content = this.originContent.Substring(this._DeleteCtrlItem.Text.Length, this.originContent.Length - this._DeleteCtrlItem.Text.Length);
									break;
								}
							}
						}
					}
					else
					{
						try
						{
							IEnumerator enumerator2 = this.curRevision.SubRevisions.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								SubRevision subRevision3 = (SubRevision)enumerator2.Current;
								if ((realPos >= subRevision3.StartPos & realPos <= subRevision3.EndPos & Operators.CompareString(subRevision3.RevType, "R", false) == 0) && (realPos != subRevision3.EndPos & this.offset))
								{
									this.DelAfterIns = true;
									this.originSubRevision = subRevision3;
									this.originContent = subRevision3.Content;
									if (this.offset)
									{
										this.originSubRevision.Content = this.originContent.Remove(realPos - this.originSubRevision.StartPos, this._DeleteCtrlItem.Text.Length);
										break;
									}
									this.originSubRevision.Content = this.originContent.Remove(realPos - this.originSubRevision.StartPos - this._DeleteCtrlItem.Text.Length, this._DeleteCtrlItem.Text.Length);
									break;
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					if (!this.DelAfterDel & !this.DelAfterIns)
					{
						this.NewDel = true;
						num = 0;
						try
						{
							IEnumerator enumerator3 = this.curRevision.SubRevisions.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								SubRevision subRevision4 = (SubRevision)enumerator3.Current;
								if ((realPos >= subRevision4.StartPos & realPos <= subRevision4.EndPos) && !(subRevision4.EndPos == realPos & this.offset))
								{
									if (realPos == subRevision4.StartPos & this.offset)
									{
										this.delSubRevision = new SubRevision();
										this.delSubRevision.RevType = "D";
										this.delSubRevision.Content = this._DeleteCtrlItem.Text;
										this.originSubRevision = subRevision4;
										this.originContent = this.originSubRevision.Content;
										this.originSubRevision.Content = this.originContent.Substring(this._DeleteCtrlItem.Text.Length);
										this.curRevision.SubRevisions.Insert(num, this.delSubRevision);
										break;
									}
									if (realPos == subRevision4.EndPos & !this.offset)
									{
										this.delSubRevision = new SubRevision();
										this.delSubRevision.RevType = "D";
										this.delSubRevision.Content = this._DeleteCtrlItem.Text;
										this.originSubRevision = subRevision4;
										this.originContent = this.originSubRevision.Content;
										this.originSubRevision.Content = this.originContent.Substring(0, this.originContent.Length - this._DeleteCtrlItem.Text.Length);
										this.curRevision.SubRevisions.Insert(num + 1, this.delSubRevision);
										break;
									}
									this.originSubRevision = subRevision4;
									this.originContent = this.originSubRevision.Content;
									this.splitSubRevision = new SubRevision();
									this.splitSubRevision.RevType = this.originSubRevision.RevType;
									if (this.offset)
									{
										this.originSubRevision.Content = this.originContent.Substring(0, realPos - subRevision4.StartPos);
										this.splitSubRevision.Content = this.originContent.Substring(realPos - subRevision4.StartPos + this._DeleteCtrlItem.Text.Length, subRevision4.EndPos - realPos - this._DeleteCtrlItem.Text.Length);
									}
									else
									{
										this.originSubRevision.Content = this.originContent.Substring(0, realPos - subRevision4.StartPos - this._DeleteCtrlItem.Text.Length);
										this.splitSubRevision.Content = this.originContent.Substring(realPos - subRevision4.StartPos, subRevision4.EndPos - realPos);
									}
									this.delSubRevision = new SubRevision();
									this.delSubRevision.RevType = "D";
									this.delSubRevision.Content = this._DeleteCtrlItem.Text;
									this.curRevision.SubRevisions.Insert(num + 1, this.splitSubRevision);
									this.curRevision.SubRevisions.Insert(num + 1, this.delSubRevision);
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
							IEnumerator enumerator3;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
					}
					if (this.originSubRevision != null && Operators.CompareString(this.originSubRevision.Content, "", false) == 0)
					{
						this.posOriginSubRevision = this.curRevision.SubRevisions.IndexOf(this.originSubRevision);
						this.curRevision.SubRevisions.Remove(this.originSubRevision);
					}
					this.curRevision.RefreshPos();
				}
				this._ParentCtrlItem.SubItems.Remove(this._DeleteCtrlItem);
				this._ParentCtrlItem.BindInstanceItem.SubItems.Remove(this._DeleteCtrlItem.BindInstanceItem);
				return null;
			}
		}

		public UpdateArgs UnExecute()
		{
			this._ParentCtrlItem.SubItems.Insert(this._ParentCtrlItem, this._DeletePos, this._DeleteCtrlItem);
			this._ParentCtrlItem.BindInstanceItem.SubItems.Insert(this._ParentCtrlItem.BindInstanceItem, this._DeletePos, this._DeleteCtrlItem.BindInstanceItem);
			return null;
		}
	}
}
