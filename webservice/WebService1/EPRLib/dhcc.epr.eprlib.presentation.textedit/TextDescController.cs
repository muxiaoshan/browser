using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class TextDescController : Controller
	{
		private NITextDesc _BindNITextDesc;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNITextDesc;
			}
			set
			{
				this._BindNITextDesc = (NITextDesc)value;
			}
		}

		public TextDescController()
		{
			this.SubItems = new ControllerCollection();
			this.ActiveItem = -1;
		}

		public override void SyncInstanceItem(NInstanceItem objInstanceItem)
		{
			this.BindInstanceItem = objInstanceItem;
			NInstanceItemEnumerator enumerator = this._BindNITextDesc.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (nInstanceItem is NIFree)
				{
					FreeController freeController = new FreeController();
					freeController.BindInstanceItem = nInstanceItem;
					freeController.ActionManager = this.ActionManager;
					this.SubItems.Add(this, freeController);
				}
				else if (nInstanceItem is NISegment)
				{
					SegmentController segmentController = new SegmentController();
					segmentController.ActionManager = this.ActionManager;
					segmentController.SyncInstanceItem(nInstanceItem);
					segmentController.CurrentTextEdit = this.CurrentTextEdit;
					this.SubItems.Add(this, segmentController);
				}
			}
		}

		public override void OnUpdate(UpdateArgs objUpdateArgs)
		{
			if (objUpdateArgs != null)
			{
				if (objUpdateArgs.IsRefresh)
				{
					Point pt = new Point(1, 1);
					int charIndexFromPosition = this.CurrentTextEdit.GetCharIndexFromPosition(pt);
					PCTextEdit.LockWindowUpdate(this.CurrentTextEdit.Handle);
					this.CurrentTextEdit.Clear();
					this.Draw(this.CurrentTextEdit);
					IntPtr hwndLock;
					PCTextEdit.LockWindowUpdate(hwndLock);
					this.CurrentTextEdit.SelectionStart = charIndexFromPosition;
				}
				this.CurrentTextEdit.SelectionStart = objUpdateArgs.Pos;
			}
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			if (this.SubItems.Count > 0)
			{
				this.StartPos = objTextEdit.SelectionStart;
				ControllerEnumerator enumerator = this.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Controller controller = (Controller)enumerator.Current;
					controller.Draw(objTextEdit);
				}
				this.EndPos = objTextEdit.SelectionStart;
			}
			else
			{
				this.StartPos = 0;
				this.EndPos = 0;
			}
			int num = 0;
			ControllerEnumerator enumerator2 = this.SubItems.GetEnumerator();
			checked
			{
				while (enumerator2.MoveNext())
				{
					Controller controller2 = (Controller)enumerator2.Current;
					if (controller2 is SegmentController && controller2.SubItems != null)
					{
						ControllerEnumerator enumerator3 = controller2.SubItems.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							Controller controller3 = (Controller)enumerator3.Current;
							if (Operators.CompareString(controller3.Text, "", false) == 0 && !(controller3 is FreeController))
							{
								num = num + controller3.Name.Length + 2;
							}
							if (controller3.BindInstanceItem.FormatRangeCollection != null)
							{
								FormateRangeEnumerator enumerator4 = controller3.BindInstanceItem.FormatRangeCollection.GetEnumerator();
								while (enumerator4.MoveNext())
								{
									FormateRange formateRange = (FormateRange)enumerator4.Current;
									formateRange.ItemStartPos = controller3.StartPos;
									formateRange.ItemEndPos = controller3.EndPos;
									formateRange.ItemNullLength = num;
									objTextEdit.SelectionStart = formateRange.StartPos + controller3.StartPos;
									objTextEdit.SelectionLength = Conversions.ToInteger(Interaction.IIf(formateRange.EndPos - formateRange.StartPos < 0, 0, formateRange.EndPos - formateRange.StartPos));
									objTextEdit.SelectionFont = formateRange.FontStruct.Font;
									objTextEdit.SelectionCharOffset = formateRange.FontStruct.CharOffset;
								}
							}
						}
					}
					else if (controller2 is FreeController && controller2.BindInstanceItem.FormatRangeCollection != null)
					{
						FormateRangeEnumerator enumerator5 = controller2.BindInstanceItem.FormatRangeCollection.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							FormateRange formateRange2 = (FormateRange)enumerator5.Current;
							formateRange2.ItemStartPos = controller2.StartPos;
							formateRange2.ItemEndPos = controller2.EndPos;
							formateRange2.ItemNullLength = num;
							objTextEdit.SelectionStart = formateRange2.StartPos + controller2.StartPos;
							objTextEdit.SelectionLength = Conversions.ToInteger(Interaction.IIf(formateRange2.EndPos - formateRange2.StartPos < 0, 0, formateRange2.EndPos - formateRange2.StartPos));
							objTextEdit.SelectionFont = formateRange2.FontStruct.Font;
							objTextEdit.SelectionCharOffset = formateRange2.FontStruct.CharOffset;
						}
					}
				}
				objTextEdit.SelectionLength = 0;
			}
		}

		private int GetItemNullLength(Controller item)
		{
			ArrayList arrayList = new ArrayList();
			int num = 0;
			ControllerEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Controller controller = (Controller)enumerator.Current;
				if (controller is SegmentController)
				{
					ControllerEnumerator enumerator2 = controller.SubItems.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Controller controller2 = (Controller)enumerator2.Current;
						if (controller2.StartPos < item.StartPos & Operators.CompareString(controller2.Text, "", false) == 0)
						{
							arrayList.Add(controller2);
						}
					}
				}
			}
			try
			{
				IEnumerator enumerator3 = arrayList.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Controller controller3 = (Controller)enumerator3.Current;
					num = checked(num + controller3.Name.Length + 2);
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
			return num;
		}

		public override UpdateArgs OnCursorMove(int intPos, int destPos)
		{
			UpdateArgs updateArgs = null;
			checked
			{
				if (this.ActiveItem != -1)
				{
					if (destPos >= this.SubItems[this.ActiveItem].StartPos & destPos <= this.SubItems[this.ActiveItem].EndPos)
					{
						updateArgs = this.SubItems[this.ActiveItem].OnCursorMove(intPos, destPos);
					}
					else if (Math.Abs(intPos - destPos) == 1)
					{
						int arg_85_0 = 0;
						int num = this.SubItems.Count - 1;
						int i = arg_85_0;
						while (i <= num)
						{
							if (this.SubItems[i].InterSection(destPos) & !(this.SubItems[i].EndPos == destPos & destPos - intPos == -1))
							{
								if (this.SubItems[i] is FreeController)
								{
									this.SubItems[this.ActiveItem].DeActive();
									this.ActiveItem = i;
									updateArgs = this.SubItems[i].OnCursorMove(intPos, destPos);
									break;
								}
								break;
							}
							else
							{
								i++;
							}
						}
						if (destPos > intPos)
						{
							int arg_124_0 = 0;
							int num2 = this.SubItems.Count - 1;
							int j = arg_124_0;
							while (j <= num2)
							{
								if (this.SubItems[j].InterSection(intPos))
								{
									if (!(this.SubItems[j] is FreeController))
									{
										this.SubItems[this.ActiveItem].DeActive();
										this.ActiveItem = -1;
										updateArgs = new UpdateArgs();
										updateArgs.IsRefresh = true;
										updateArgs.Pos = intPos;
										break;
									}
									if (j + 1 < this.SubItems.Count)
									{
										this.SubItems[this.ActiveItem].DeActive();
										this.ActiveItem = j + 1;
										updateArgs = this.SubItems[j + 1].OnCursorMove(intPos, destPos);
										break;
									}
									this.SubItems[this.ActiveItem].DeActive();
									this.ActiveItem = -1;
									updateArgs = new UpdateArgs();
									updateArgs.IsRefresh = true;
									updateArgs.Pos = intPos;
									break;
								}
								else
								{
									j++;
								}
							}
						}
						else
						{
							int arg_22E_0 = 0;
							int num3 = this.SubItems.Count - 1;
							int k = arg_22E_0;
							while (k <= num3)
							{
								if (this.SubItems[k].InterSection(intPos + 1))
								{
									if (!(this.SubItems[k] is FreeController))
									{
										this.SubItems[this.ActiveItem].DeActive();
										this.ActiveItem = -1;
										updateArgs = new UpdateArgs();
										updateArgs.IsRefresh = true;
										updateArgs.Pos = intPos;
										break;
									}
									if (k - 1 >= 0)
									{
										this.SubItems[this.ActiveItem].DeActive();
										this.ActiveItem = k - 1;
										updateArgs = this.SubItems[k - 1].OnCursorMove(intPos, destPos);
										break;
									}
									this.SubItems[this.ActiveItem].DeActive();
									this.ActiveItem = -1;
									updateArgs = new UpdateArgs();
									updateArgs.IsRefresh = true;
									updateArgs.Pos = intPos;
									break;
								}
								else
								{
									k++;
								}
							}
						}
						if (updateArgs == null)
						{
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = false;
							updateArgs.Pos = intPos;
						}
					}
					else
					{
						int arg_344_0 = 0;
						int num4 = this.SubItems.Count - 1;
						for (int l = arg_344_0; l <= num4; l++)
						{
							if (this.SubItems[l].InterSection(destPos))
							{
								this.SubItems[this.ActiveItem].DeActive();
								this.ActiveItem = l;
								updateArgs = this.SubItems[l].OnCursorMove(intPos, destPos);
								break;
							}
						}
					}
				}
				else
				{
					this.Active = true;
					int arg_3B7_0 = 0;
					int num5 = this.SubItems.Count - 1;
					for (int m = arg_3B7_0; m <= num5; m++)
					{
						if (this.SubItems[m].InterSection(destPos) & !(this.SubItems[m].EndPos == destPos & destPos - intPos == -1))
						{
							this.ActiveItem = m;
							updateArgs = this.SubItems[m].OnCursorMove(intPos, destPos);
							break;
						}
					}
				}
				this.OnUpdate(updateArgs);
				return null;
			}
		}

		public override UpdateArgs OnTabKeyPressed(int pos, bool offset)
		{
			UpdateArgs updateArgs = null;
			if (this.ActiveItem > -1)
			{
				this.SubItems[this.ActiveItem].DeActive();
				this.ActiveItem = -1;
			}
			SimpleController simpleController = this.PosToNextSimpleController(pos, offset);
			if (simpleController != null)
			{
				simpleController.Active = true;
				simpleController.Parent.ActiveItem = simpleController.Parent.SubItems.IndexOf(simpleController);
				simpleController.Parent.Active = true;
				this.ActiveItem = this.SubItems.IndexOf(simpleController.Parent);
				updateArgs = new UpdateArgs();
				updateArgs.Pos = simpleController.StartPos;
				updateArgs.IsRefresh = true;
			}
			if (updateArgs == null)
			{
				if (offset)
				{
					simpleController = this.PosToNextSimpleController(-1, offset);
				}
				else
				{
					simpleController = this.PosToNextSimpleController(this.EndPos, offset);
				}
				if (simpleController != null)
				{
					simpleController.Active = true;
					simpleController.Parent.ActiveItem = simpleController.Parent.SubItems.IndexOf(simpleController);
					simpleController.Parent.Active = true;
					this.ActiveItem = this.SubItems.IndexOf(simpleController.Parent);
					updateArgs = new UpdateArgs();
					updateArgs.Pos = simpleController.StartPos;
					updateArgs.IsRefresh = true;
				}
			}
			this.OnUpdate(updateArgs);
			return null;
		}

		private SimpleController PosToNextSimpleController(int pos, bool offset)
		{
			UpdateArgs updateArgs = new UpdateArgs();
			checked
			{
				if (offset)
				{
					int arg_19_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_19_0; i <= num; i++)
					{
						if (this.SubItems[i] is SegmentController)
						{
							SegmentController segmentController = (SegmentController)this.SubItems[i];
							SimpleController simpleController = segmentController.PosToNextSimpleController(pos, offset);
							if (simpleController != null)
							{
								return simpleController;
							}
						}
					}
					return null;
				}
				for (int j = this.SubItems.Count - 1; j >= 0; j += -1)
				{
					if (this.SubItems[j] is SegmentController & this.SubItems[j].StartPos <= pos)
					{
						SegmentController segmentController2 = (SegmentController)this.SubItems[j];
						SimpleController simpleController2 = segmentController2.PosToNextSimpleController(pos, offset);
						if (simpleController2 != null)
						{
							return simpleController2;
						}
					}
				}
				return null;
			}
		}

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			UpdateArgs objUpdateArgs = null;
			checked
			{
				if (this.ActiveItem > -1)
				{
					objUpdateArgs = this.SubItems[this.ActiveItem].OnInsertString(pos, value);
				}
				else if (pos == this.EndPos)
				{
					NIFree nIFree = new NIFree();
					FreeController freeController = (FreeController)nIFree.CreateController();
					freeController.ActionManager = this.ActionManager;
					InsertItemAction insertItemAction = new InsertItemAction(this, freeController, this.SubItems.Count, pos);
					this.ActionManager.AddToActionList(insertItemAction);
					insertItemAction.Execute();
					this.ActiveItem = this.SubItems.Count - 1;
					freeController.Active = true;
					freeController.StartPos = pos;
					objUpdateArgs = freeController.OnInsertString(pos, value);
				}
				else
				{
					int arg_B9_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_B9_0; i <= num; i++)
					{
						if (this.SubItems[i].InterSection(pos + 1))
						{
							NIFree nIFree2 = new NIFree();
							FreeController freeController2 = (FreeController)nIFree2.CreateController();
							freeController2.ActionManager = this.ActionManager;
							InsertItemAction insertItemAction2 = new InsertItemAction(this, freeController2, i, pos);
							this.ActionManager.AddToActionList(insertItemAction2);
							insertItemAction2.Execute();
							this.ActiveItem = i;
							freeController2.Active = true;
							freeController2.StartPos = pos;
							objUpdateArgs = freeController2.OnInsertString(pos, value);
							break;
						}
					}
				}
				FormateRangeEnumerator enumerator = this._BindNITextDesc.FormatRangeCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FormateRange formateRange = (FormateRange)enumerator.Current;
					if (formateRange.ItemStartPos > pos)
					{
						formateRange.ItemStartPos += value.Length;
						formateRange.ItemEndPos += value.Length;
					}
				}
				this.OnUpdate(objUpdateArgs);
				return null;
			}
		}

		public override UpdateArgs OnEnterKeyDown(int pos)
		{
			UpdateArgs objUpdateArgs;
			if (this.ActiveItem == -1)
			{
				objUpdateArgs = this.OnInsertString(pos, "\r");
			}
			else
			{
				objUpdateArgs = this.SubItems[this.ActiveItem].OnEnterKeyDown(pos);
			}
			this.OnUpdate(objUpdateArgs);
			return null;
		}

		public override UpdateArgs OnDoubleClick(int pos)
		{
			UpdateArgs objUpdateArgs = null;
			if (this.ActiveItem != -1 && this.SubItems[this.ActiveItem] is SegmentController)
			{
				objUpdateArgs = this.SubItems[this.ActiveItem].OnDoubleClick(pos);
			}
			this.OnUpdate(objUpdateArgs);
			return null;
		}

		public override UpdateArgs OnInsertItem(int pos, NInstanceItem itemInsert)
		{
			UpdateArgs updateArgs = null;
			if (!(itemInsert is NISegment))
			{
				return null;
			}
			checked
			{
				if (this.ActiveItem > -1)
				{
					this.ActiveItem = this.SubItems.Count - 1;
					if (this.SubItems[this.ActiveItem] is SegmentController)
					{
						this.SubItems[this.ActiveItem].DeActive();
						Controller controller = itemInsert.CreateController();
						controller.CurrentTextEdit = this.CurrentTextEdit;
						controller.ActionManager = this.ActionManager;
						controller.SyncInstanceItem(itemInsert);
						InsertItemAction insertItemAction = new InsertItemAction(this, controller, this.ActiveItem + 1, pos);
						this.ActionManager.AddToActionList(insertItemAction);
						insertItemAction.Execute();
						this.ActiveItem++;
						controller.Active = true;
						if (controller.SubItems != null && controller.SubItems.Count > 0)
						{
							controller.ActiveItem = 0;
							controller.SubItems[0].Active = true;
						}
						updateArgs = new UpdateArgs();
						updateArgs.IsRefresh = true;
						updateArgs.Pos = this.SubItems[this.ActiveItem - 1].EndPos;
					}
					else if (this.SubItems[this.ActiveItem] is FreeController)
					{
						if (pos == this.SubItems[this.ActiveItem].StartPos)
						{
							this.SubItems[this.ActiveItem].DeActive();
							Controller controller2 = itemInsert.CreateController();
							controller2.CurrentTextEdit = this.CurrentTextEdit;
							controller2.ActionManager = this.ActionManager;
							controller2.SyncInstanceItem(itemInsert);
							InsertItemAction insertItemAction2 = new InsertItemAction(this, controller2, this.ActiveItem, pos);
							this.ActionManager.AddToActionList(insertItemAction2);
							insertItemAction2.Execute();
							controller2.Active = true;
							if (controller2.SubItems != null && controller2.SubItems.Count > 0)
							{
								controller2.ActiveItem = 0;
								controller2.SubItems[0].Active = true;
							}
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = pos;
						}
						else if (pos == this.SubItems[this.ActiveItem].EndPos)
						{
							this.SubItems[this.ActiveItem].DeActive();
							Controller controller3 = itemInsert.CreateController();
							controller3.CurrentTextEdit = this.CurrentTextEdit;
							controller3.ActionManager = this.ActionManager;
							controller3.SyncInstanceItem(itemInsert);
							InsertItemAction insertItemAction3 = new InsertItemAction(this, controller3, this.ActiveItem + 1, pos);
							this.ActionManager.AddToActionList(insertItemAction3);
							insertItemAction3.Execute();
							this.ActiveItem++;
							controller3.Active = true;
							if (controller3.SubItems != null && controller3.SubItems.Count > 0)
							{
								controller3.ActiveItem = 0;
								controller3.SubItems[0].Active = true;
							}
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = pos;
						}
						else
						{
							this.SubItems[this.ActiveItem].DeActive();
							FreeController freeController = (FreeController)this.SubItems[this.ActiveItem];
							string value = freeController.Text.Substring(pos - freeController.StartPos + 1, freeController.EndPos - pos);
							freeController.OnDelete(pos, value);
							NIFree nIFree = new NIFree();
							FreeController freeController2 = (FreeController)nIFree.CreateController();
							freeController2.Parent.CurrentTextEdit = this.CurrentTextEdit;
							freeController2.ActionManager = this.ActionManager;
							InsertItemAction insertItemAction4 = new InsertItemAction(this, freeController2, this.ActiveItem + 1, pos);
							this.ActionManager.AddToActionList(insertItemAction4);
							insertItemAction4.Execute();
							freeController2.StartPos = pos;
							updateArgs = freeController2.OnInsertString(pos, value);
							Controller controller4 = itemInsert.CreateController();
							controller4.CurrentTextEdit = this.CurrentTextEdit;
							controller4.ActionManager = this.ActionManager;
							controller4.SyncInstanceItem(itemInsert);
							InsertItemAction insertItemAction5 = new InsertItemAction(this, controller4, this.ActiveItem + 1, pos);
							this.ActionManager.AddToActionList(insertItemAction5);
							insertItemAction5.Execute();
							controller4.Active = true;
							if (controller4.SubItems != null && controller4.SubItems.Count > 0)
							{
								controller4.ActiveItem = 0;
								controller4.SubItems[0].Active = true;
							}
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = pos;
						}
					}
				}
				else if (pos == this.EndPos)
				{
					Controller controller5 = itemInsert.CreateController();
					controller5.ActionManager = this.ActionManager;
					controller5.CurrentTextEdit = this.CurrentTextEdit;
					controller5.SyncInstanceItem(itemInsert);
					InsertItemAction insertItemAction6 = new InsertItemAction(this, controller5, this.SubItems.Count, pos);
					this.ActionManager.AddToActionList(insertItemAction6);
					insertItemAction6.Execute();
					this.ActiveItem = this.SubItems.Count - 1;
					controller5.Active = true;
					updateArgs = new UpdateArgs();
					updateArgs.IsRefresh = true;
					updateArgs.Pos = pos;
				}
				else
				{
					int arg_506_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_506_0; i <= num; i++)
					{
						if (this.SubItems[i].InterSection(pos + 1))
						{
							Controller controller6 = itemInsert.CreateController();
							controller6.CurrentTextEdit = this.CurrentTextEdit;
							controller6.ActionManager = this.ActionManager;
							controller6.SyncInstanceItem(itemInsert);
							InsertItemAction insertItemAction7 = new InsertItemAction(this, controller6, i, pos);
							this.ActionManager.AddToActionList(insertItemAction7);
							insertItemAction7.Execute();
							this.ActiveItem = this.SubItems.Count - 1;
							controller6.Active = true;
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = pos;
						}
					}
				}
				this.OnUpdate(updateArgs);
				return null;
			}
		}

		public override UpdateArgs OnDelete(int pos, string value)
		{
			UpdateArgs updateArgs = new UpdateArgs();
			updateArgs.IsRefresh = true;
			updateArgs.Pos = pos;
			string text = value;
			int num = pos;
			bool flag = false;
			int num2 = this.SubItems.Count;
			checked
			{
				for (int i = 0; i < num2; i++)
				{
					Controller controller = this.SubItems[i];
					if (pos >= controller.StartPos & pos < controller.EndPos)
					{
						flag = true;
					}
					if (pos + value.Length <= controller.StartPos)
					{
						break;
					}
					if (flag)
					{
						if (controller is SegmentController)
						{
							if (num == controller.StartPos & controller.EndPos <= num + text.Length)
							{
								string value2 = text.Substring(0, controller.EndPos - num);
								DeleteItemAction deleteItemAction = new DeleteItemAction(this, controller);
								this.ActionManager.AddToActionList(deleteItemAction);
								deleteItemAction.Execute();
								num2--;
								i--;
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
								if (this.ActiveItem != -1)
								{
									this.ActiveItem = -1;
								}
							}
							else if (controller.EndPos < num + text.Length)
							{
								string value2 = text.Substring(0, controller.EndPos - num);
								UpdateArgs updateArgs2 = controller.OnDelete(num, value2);
								if (updateArgs2.Pos < updateArgs.Pos)
								{
									updateArgs.Pos = updateArgs2.Pos;
									string text2 = "{" + controller.Name + "}";
								}
								if (controller.SubItems.Count == 0)
								{
									DeleteItemAction deleteItemAction2 = new DeleteItemAction(this, controller);
									this.ActionManager.AddToActionList(deleteItemAction2);
									deleteItemAction2.Execute();
									num2--;
									i--;
								}
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
							}
							else
							{
								string value2 = text;
								UpdateArgs updateArgs2 = controller.OnDelete(num, value2);
								if (updateArgs2.Pos < updateArgs.Pos)
								{
									updateArgs.Pos = updateArgs2.Pos;
									string text2 = "{" + controller.Name + "}";
								}
								if (controller.SubItems.Count == 0)
								{
									DeleteItemAction deleteItemAction3 = new DeleteItemAction(this, controller);
									this.ActionManager.AddToActionList(deleteItemAction3);
									deleteItemAction3.Execute();
									num2--;
									i--;
									if (this.ActiveItem != -1)
									{
										this.ActiveItem = -1;
									}
								}
								else
								{
									controller.Active = true;
									this.ActiveItem = this.SubItems.IndexOf(controller);
								}
							}
						}
						else if (controller is FreeController)
						{
							if (num == controller.StartPos & controller.EndPos <= num + text.Length)
							{
								string value2 = text.Substring(0, controller.EndPos - num);
								DeleteItemAction deleteItemAction4 = new DeleteItemAction(this, controller);
								this.ActionManager.AddToActionList(deleteItemAction4);
								deleteItemAction4.Execute();
								num2--;
								i--;
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
								if (this.ActiveItem != -1)
								{
									this.ActiveItem = -1;
								}
							}
							else if (controller.EndPos < num + text.Length)
							{
								string value2 = text.Substring(0, controller.EndPos - num);
								updateArgs = controller.OnDelete(num, value2);
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
							}
							else
							{
								string value2 = text;
								updateArgs = controller.OnDelete(num, value2);
								controller.Active = true;
								this.ActiveItem = this.SubItems.IndexOf(controller);
							}
						}
					}
				}
				this.OnUpdate(updateArgs);
				return null;
			}
		}

		public override UpdateArgs OnFormate(int intpos, int destpos, FontStruct oldFontStruct, FontStruct newFontStruct)
		{
			ArrayList itemsInSelected = this.GetItemsInSelected(intpos, destpos);
			checked
			{
				try
				{
					IEnumerator enumerator = itemsInSelected.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Controller controller = (Controller)enumerator.Current;
						int startPos = controller.StartPos;
						int endPos = controller.EndPos;
						int intpos2;
						if (intpos >= startPos)
						{
							intpos2 = intpos - startPos;
						}
						else
						{
							intpos2 = 0;
						}
						int destpos2;
						if (destpos >= endPos)
						{
							destpos2 = endPos - startPos;
						}
						else
						{
							destpos2 = destpos - startPos;
						}
						int itemNullLength = this.GetItemNullLength(controller);
						if (Operators.CompareString(controller.Text, "", false) != 0)
						{
							controller.BindInstanceItem.FormatRangeCollection.OnFormate(intpos2, destpos2, startPos, endPos, itemNullLength, oldFontStruct, newFontStruct, this.ActionManager);
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
				this.OnUpdate(new UpdateArgs
				{
					IsRefresh = true,
					Pos = intpos
				});
				return null;
			}
		}

		public override UpdateArgs OnUndo()
		{
			if (this.ActionManager.CanUndo)
			{
				this.DeActive();
				this.ActionManager.Undo();
			}
			this.OnUpdate(new UpdateArgs
			{
				IsRefresh = true,
				Pos = 0
			});
			return null;
		}

		public override UpdateArgs OnRedo()
		{
			if (this.ActionManager.CanRedo)
			{
				this.DeActive();
				this.ActionManager.Redo();
			}
			this.OnUpdate(new UpdateArgs
			{
				IsRefresh = true,
				Pos = 0
			});
			return null;
		}

		public override UpdateArgs OnUpdateLinkItem(string patientID)
		{
			return null;
		}

		private ArrayList GetItemsInSelected(int intpos, int destpos)
		{
			ArrayList arrayList = new ArrayList();
			int arg_16_0 = 0;
			checked
			{
				int num = this.SubItems.Count - 1;
				for (int i = arg_16_0; i <= num; i++)
				{
					if (this.SubItems[i] is SegmentController)
					{
						int arg_4D_0 = 0;
						int num2 = this.SubItems[i].SubItems.Count - 1;
						for (int j = arg_4D_0; j <= num2; j++)
						{
							if (intpos < this.SubItems[i].SubItems[j].EndPos && destpos > this.SubItems[i].SubItems[j].StartPos)
							{
								arrayList.Add(this.SubItems[i].SubItems[j]);
							}
						}
					}
					else if (intpos < this.SubItems[i].EndPos && destpos > this.SubItems[i].StartPos)
					{
						arrayList.Add(this.SubItems[i]);
					}
				}
				return arrayList;
			}
		}

		public override int GetRealPos(int pos)
		{
			int num = 0;
			ControllerEnumerator enumerator = this.SubItems.GetEnumerator();
			checked
			{
				while (enumerator.MoveNext())
				{
					Controller controller = (Controller)enumerator.Current;
					if (controller.SubItems != null)
					{
						ControllerEnumerator enumerator2 = controller.SubItems.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Controller controller2 = (Controller)enumerator2.Current;
							if (pos >= controller2.StartPos & pos < controller2.EndPos)
							{
								if (controller2.Text != null)
								{
									num += pos - controller2.StartPos;
								}
								return num;
							}
							if (controller2.Text != null && Operators.CompareString(controller2.Text, "", false) != 0)
							{
								num += controller2.Text.Length;
							}
						}
					}
					if (controller.SubItems == null)
					{
						if (pos >= controller.StartPos & pos <= controller.EndPos)
						{
							if (controller.Text != null)
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
				}
				return num;
			}
		}
	}
}
