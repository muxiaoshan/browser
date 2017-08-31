using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class ReplaceContentAction : IAction
	{
		private Controller _RootCtrlItem;

		private Controller _ParentCtrlItem;

		private Controller _ReplaceCtrlItem;

		private string _OriginValue;

		private string _OriginValueCode;

		private string _ReplaceValue;

		private string _ReplaceValueCode;

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

		public ReplaceContentAction(Controller objReplaceCtrlItem, string strOriginValue, string strOriginValueCode, string strReplaceValue, string strReplaceValueCode)
		{
			this._ReplaceCtrlItem = objReplaceCtrlItem;
			this._OriginValue = strOriginValue;
			this._OriginValueCode = strOriginValueCode;
			this._ReplaceValue = strReplaceValue;
			this._ReplaceValueCode = strReplaceValueCode;
			if (objReplaceCtrlItem.Parent.Parent != null)
			{
				this._RootCtrlItem = objReplaceCtrlItem.Parent.Parent;
				this._ParentCtrlItem = objReplaceCtrlItem.Parent;
			}
			else if (objReplaceCtrlItem.Parent != null)
			{
				this._RootCtrlItem = objReplaceCtrlItem.Parent;
				this._ParentCtrlItem = objReplaceCtrlItem.Parent;
			}
			else
			{
				this._RootCtrlItem = objReplaceCtrlItem;
				this._ParentCtrlItem = objReplaceCtrlItem;
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
					int num = this._RootCtrlItem.GetRealPos(this._ReplaceCtrlItem.StartPos);
					int num2 = num + this._OriginValue.Length;
					int num3 = 0;
					bool flag = false;
					try
					{
						IEnumerator enumerator = this.curRevision.SubRevisions.GetEnumerator();
						while (enumerator.MoveNext())
						{
							SubRevision subRevision = (SubRevision)enumerator.Current;
							if (num >= subRevision.StartPos & num <= subRevision.EndPos & (Operators.CompareString(subRevision.RevType, "R", false) == 0 | Operators.CompareString(subRevision.RevType, "O", false) == 0))
							{
								flag = true;
								this.OldContent = subRevision.Content;
								this.NewIns = true;
								if (num == subRevision.StartPos)
								{
									if (Operators.CompareString(this._OriginValue, "", false) == 0)
									{
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3, this.insertSubRevision);
										break;
									}
									if (num2 == subRevision.EndPos)
									{
										subRevision.RevType = "D";
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.insertSubRevision);
										break;
									}
									if (num2 < subRevision.EndPos)
									{
										this.splitSubRevision = new SubRevision();
										this.splitSubRevision.RevType = subRevision.RevType;
										this.splitSubRevision.Content = this.OldContent.Substring(num2 - subRevision.StartPos, subRevision.EndPos - num2);
										subRevision.Content = this.OldContent.Substring(0, num2 - subRevision.StartPos);
										this.curRevision.SubRevisions.Insert(num3 + 1, this.splitSubRevision);
										subRevision.RevType = "D";
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.insertSubRevision);
										break;
									}
									subRevision.RevType = "D";
									num += subRevision.Content.Length;
								}
								else if (num == subRevision.EndPos)
								{
									if (Operators.CompareString(this._OriginValue, "", false) == 0)
									{
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.insertSubRevision);
										break;
									}
								}
								else
								{
									if (Operators.CompareString(this._OriginValue, "", false) == 0)
									{
										this.splitSubRevision = new SubRevision();
										this.splitSubRevision.RevType = subRevision.RevType;
										this.splitSubRevision.Content = this.OldContent.Substring(num - subRevision.StartPos, subRevision.EndPos - num);
										this.splitSubRevision.StartPos = num;
										this.splitSubRevision.EndPos = subRevision.EndPos;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.splitSubRevision);
										subRevision.Content = this.OldContent.Substring(0, num - subRevision.StartPos);
										subRevision.EndPos = num;
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.insertSubRevision);
										break;
									}
									if (num2 > subRevision.EndPos)
									{
										int count = this.curRevision.SubRevisions.Count;
										int arg_4FC_0 = num3;
										int num4 = count - 1;
										for (int i = arg_4FC_0; i <= num4; i++)
										{
											SubRevision subRevision2 = (SubRevision)this.curRevision.SubRevisions[i];
											if (num2 > subRevision2.EndPos & (Operators.CompareString(subRevision2.RevType, "R", false) == 0 | Operators.CompareString(subRevision2.RevType, "O", false) == 0))
											{
												subRevision2.RevType = "D";
											}
											else
											{
												if (num2 == subRevision2.EndPos & (Operators.CompareString(subRevision2.RevType, "R", false) == 0 | Operators.CompareString(subRevision2.RevType, "O", false) == 0))
												{
													subRevision2.RevType = "D";
													this.insertSubRevision = new SubRevision();
													this.insertSubRevision.RevType = "R";
													this.insertSubRevision.Content = this._ReplaceValue;
													this.curRevision.SubRevisions.Insert(i + 1, this.insertSubRevision);
													break;
												}
												if (num2 < subRevision2.EndPos & (Operators.CompareString(subRevision2.RevType, "R", false) == 0 | Operators.CompareString(subRevision2.RevType, "O", false) == 0))
												{
													this.splitSubRevision = new SubRevision();
													this.splitSubRevision.RevType = subRevision2.RevType;
													this.splitSubRevision.Content = subRevision2.Content.Substring(num2 - subRevision2.StartPos, subRevision2.EndPos - num2);
													this.splitSubRevision.StartPos = num;
													this.splitSubRevision.EndPos = subRevision.EndPos;
													this.curRevision.SubRevisions.Insert(i + 1, this.splitSubRevision);
													subRevision2.Content = subRevision2.Content.Substring(0, num2 - subRevision2.StartPos);
													subRevision2.RevType = "D";
													subRevision2.EndPos = num2;
													this.insertSubRevision = new SubRevision();
													this.insertSubRevision.RevType = "R";
													this.insertSubRevision.Content = this._ReplaceValue;
													this.curRevision.SubRevisions.Insert(i + 1, this.insertSubRevision);
													break;
												}
											}
										}
										this.splitSubRevision = new SubRevision();
										this.splitSubRevision.RevType = "D";
										this.splitSubRevision.Content = this.OldContent.Substring(num - subRevision.StartPos, subRevision.EndPos - num);
										this.splitSubRevision.StartPos = num;
										this.splitSubRevision.EndPos = subRevision.EndPos;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.splitSubRevision);
										subRevision.Content = this.OldContent.Substring(0, num - subRevision.StartPos);
										subRevision.EndPos = num;
										break;
									}
									if (num2 < subRevision.EndPos)
									{
										SubRevision subRevision3 = new SubRevision();
										subRevision3.RevType = subRevision.RevType;
										subRevision3.Content = this.OldContent.Substring(num2 - subRevision.StartPos, subRevision.EndPos - num2);
										subRevision3.StartPos = num2;
										subRevision3.EndPos = subRevision.EndPos;
										this.curRevision.SubRevisions.Insert(num3 + 1, subRevision3);
										this.splitSubRevision = new SubRevision();
										this.splitSubRevision.RevType = "D";
										this.splitSubRevision.Content = this.OldContent.Substring(num - subRevision.StartPos, num2 - num);
										this.splitSubRevision.StartPos = num;
										this.splitSubRevision.EndPos = num2;
										this.curRevision.SubRevisions.Insert(num3 + 1, this.splitSubRevision);
										subRevision.Content = this.OldContent.Substring(0, num - subRevision.StartPos);
										subRevision.EndPos = num;
										this.insertSubRevision = new SubRevision();
										this.insertSubRevision.RevType = "R";
										this.insertSubRevision.Content = this._ReplaceValue;
										this.curRevision.SubRevisions.Insert(num3 + 2, this.insertSubRevision);
										break;
									}
									this.splitSubRevision = new SubRevision();
									this.splitSubRevision.RevType = "D";
									this.splitSubRevision.Content = this.OldContent.Substring(num - subRevision.StartPos, subRevision.EndPos - num);
									this.splitSubRevision.StartPos = num;
									this.splitSubRevision.EndPos = subRevision.EndPos;
									this.curRevision.SubRevisions.Insert(num3 + 1, this.splitSubRevision);
									subRevision.Content = this.OldContent.Substring(0, num - subRevision.StartPos);
									subRevision.EndPos = num;
									this.insertSubRevision = new SubRevision();
									this.insertSubRevision.RevType = "R";
									this.insertSubRevision.Content = this._ReplaceValue;
									this.curRevision.SubRevisions.Insert(num3 + 2, this.insertSubRevision);
									break;
								}
							}
							num3++;
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
						this.insertSubRevision.Content = this._OriginValue;
						this.curRevision.SubRevisions.Add(this.insertSubRevision);
					}
					this.curRevision.RefreshPos();
				}
				this._ReplaceCtrlItem.Text = this._ReplaceValue;
				this._ReplaceCtrlItem.ValueCode = this._ReplaceValueCode;
				return null;
			}
		}

		public UpdateArgs UnExecute()
		{
			this._ReplaceCtrlItem.Text = this._OriginValue;
			this._ReplaceCtrlItem.ValueCode = this._OriginValueCode;
			return null;
		}
	}
}
