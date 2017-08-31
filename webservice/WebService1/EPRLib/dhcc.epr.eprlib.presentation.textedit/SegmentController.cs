using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class SegmentController : Controller
	{
		private NISegment _BindNISegment;

		private bool _Standalone;

		private bool _CanDelInnerStuct;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNISegment;
			}
			set
			{
				this._BindNISegment = (NISegment)value;
			}
		}

		public bool Standalone
		{
			get
			{
				return this._Standalone;
			}
			set
			{
				this._Standalone = value;
			}
		}

		public override string Text
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				ControllerEnumerator enumerator = this.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Controller controller = (Controller)enumerator.Current;
					stringBuilder.Append(controller.Text);
				}
				return stringBuilder.ToString();
			}
			set
			{
			}
		}

		public SegmentController()
		{
			this._CanDelInnerStuct = true;
			this.SubItems = new ControllerCollection();
			this.ActiveItem = -1;
		}

		public override void SyncInstanceItem(NInstanceItem objInstanceItem)
		{
			this.BindInstanceItem = objInstanceItem;
			NInstanceItemEnumerator enumerator = this._BindNISegment.SubItems.GetEnumerator();
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
				else if (nInstanceItem is NILink)
				{
					LinkController linkController = new LinkController();
					linkController.BindInstanceItem = nInstanceItem;
					linkController.ActionManager = this.ActionManager;
					this.SubItems.Add(this, linkController);
				}
				else if (nInstanceItem is NISimple)
				{
					if (nInstanceItem.BindMMetaItem == null)
					{
						if (Operators.CompareString(nInstanceItem.Code, "ImagePosition", false) == 0)
						{
							PositionController positionController = new PositionController();
							positionController.BindInstanceItem = nInstanceItem;
							positionController.ActionManager = this.ActionManager;
							this.SubItems.Add(this, positionController);
						}
						else if (Operators.CompareString(nInstanceItem.Code, "ImageIcon", false) == 0)
						{
							IconAnnoController iconAnnoController = new IconAnnoController();
							iconAnnoController.BindInstanceItem = nInstanceItem;
							iconAnnoController.ActionManager = this.ActionManager;
							this.SubItems.Add(this, iconAnnoController);
						}
					}
					else if (nInstanceItem.BindMMetaItem is MIString)
					{
						StringController stringController = new StringController();
						stringController.BindInstanceItem = nInstanceItem;
						stringController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, stringController);
					}
					else if (nInstanceItem.BindMMetaItem is MINumber)
					{
						NumberController numberController = new NumberController();
						numberController.BindInstanceItem = nInstanceItem;
						numberController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, numberController);
					}
					else if (nInstanceItem.BindMMetaItem is MIMonoChoice)
					{
						MonoChoiceController monoChoiceController = new MonoChoiceController();
						monoChoiceController.BindInstanceItem = nInstanceItem;
						monoChoiceController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, monoChoiceController);
					}
					else if (nInstanceItem.BindMMetaItem is MIMultiChoice)
					{
						MultiChoiceController multiChoiceController = new MultiChoiceController();
						multiChoiceController.BindInstanceItem = nInstanceItem;
						multiChoiceController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, multiChoiceController);
					}
					else if (nInstanceItem.BindMMetaItem is MIDictionary)
					{
						DictionaryController dictionaryController = new DictionaryController();
						dictionaryController.BindInstanceItem = nInstanceItem;
						dictionaryController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, dictionaryController);
					}
					else if (nInstanceItem.BindMMetaItem is MIPosition)
					{
						PositionController positionController2 = new PositionController();
						positionController2.BindInstanceItem = nInstanceItem;
						positionController2.ActionManager = this.ActionManager;
						this.SubItems.Add(this, positionController2);
					}
					else if (nInstanceItem.BindMMetaItem is MIQuantity)
					{
						QuantityController quantityController = new QuantityController();
						quantityController.BindInstanceItem = nInstanceItem;
						quantityController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, quantityController);
					}
					else if (nInstanceItem.BindMMetaItem is MIDateTime)
					{
						DateTimeController dateTimeController = new DateTimeController();
						dateTimeController.BindInstanceItem = nInstanceItem;
						dateTimeController.ActionManager = this.ActionManager;
						this.SubItems.Add(this, dateTimeController);
					}
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
				this.StartPos = objTextEdit.SelectionStart;
				this.EndPos = objTextEdit.SelectionStart;
			}
			checked
			{
				if (this.Parent == null)
				{
					int num = 0;
					ControllerEnumerator enumerator2 = this.SubItems.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Controller controller2 = (Controller)enumerator2.Current;
						if (Operators.CompareString(controller2.Text, "", false) == 0 && !(controller2 is FreeController))
						{
							num = num + controller2.Name.Length + 2;
						}
						if (controller2.BindInstanceItem.FormatRangeCollection != null)
						{
							FormateRangeEnumerator enumerator3 = controller2.BindInstanceItem.FormatRangeCollection.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								FormateRange formateRange = (FormateRange)enumerator3.Current;
								formateRange.ItemStartPos = controller2.StartPos;
								formateRange.ItemEndPos = controller2.EndPos;
								formateRange.ItemNullLength = num;
								objTextEdit.SelectionStart = formateRange.StartPos + controller2.StartPos;
								objTextEdit.SelectionLength = Conversions.ToInteger(Interaction.IIf(formateRange.EndPos - formateRange.StartPos < 0, 0, formateRange.EndPos - formateRange.StartPos));
								objTextEdit.SelectionFont = formateRange.FontStruct.Font;
								objTextEdit.SelectionCharOffset = formateRange.FontStruct.CharOffset;
							}
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
				if (controller.StartPos < item.StartPos & Operators.CompareString(controller.Text, "", false) == 0)
				{
					arrayList.Add(controller);
				}
			}
			try
			{
				IEnumerator enumerator2 = arrayList.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Controller controller2 = (Controller)enumerator2.Current;
					num = checked(num + controller2.Name.Length + 2);
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
						if (updateArgs == null)
						{
							if (destPos > intPos)
							{
								int arg_12A_0 = 0;
								int num2 = this.SubItems.Count - 1;
								int j = arg_12A_0;
								while (j <= num2)
								{
									if (this.SubItems[j].InterSection(intPos))
									{
										if (this.SubItems[j] is FreeController)
										{
											if (j + 1 < this.SubItems.Count)
											{
												this.SubItems[this.ActiveItem].DeActive();
												this.ActiveItem = j + 1;
												updateArgs = this.SubItems[j + 1].OnCursorMove(intPos, destPos);
											}
											else
											{
												updateArgs = new UpdateArgs();
												updateArgs.IsRefresh = false;
												updateArgs.Pos = intPos;
											}
											break;
										}
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
								int arg_1DB_0 = 0;
								int num3 = this.SubItems.Count - 1;
								int k = arg_1DB_0;
								while (k <= num3)
								{
									if (this.SubItems[k].InterSection(intPos + 1))
									{
										if (this.SubItems[k] is FreeController)
										{
											if (k - 1 >= 0)
											{
												this.SubItems[this.ActiveItem].DeActive();
												this.ActiveItem = k - 1;
												updateArgs = this.SubItems[k - 1].OnCursorMove(intPos, destPos);
											}
											else
											{
												updateArgs = new UpdateArgs();
												updateArgs.IsRefresh = false;
												updateArgs.Pos = intPos;
											}
											break;
										}
										break;
									}
									else
									{
										k++;
									}
								}
							}
						}
						if (updateArgs == null)
						{
							this.SubItems[this.ActiveItem].DeActive();
							this.ActiveItem = -1;
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = intPos;
						}
					}
					else
					{
						int arg_2BB_0 = 0;
						int num4 = this.SubItems.Count - 1;
						for (int l = arg_2BB_0; l <= num4; l++)
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
					int arg_32E_0 = 0;
					int num5 = this.SubItems.Count - 1;
					for (int m = arg_32E_0; m <= num5; m++)
					{
						if (this.SubItems[m].InterSection(destPos) & !(this.SubItems[m].EndPos == destPos & destPos - intPos == -1))
						{
							this.ActiveItem = m;
							updateArgs = this.SubItems[m].OnCursorMove(intPos, destPos);
							break;
						}
					}
				}
				if (this._Standalone)
				{
					this.OnUpdate(updateArgs);
					return null;
				}
				return updateArgs;
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
				this.ActiveItem = this.SubItems.IndexOf(simpleController);
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
					this.ActiveItem = this.SubItems.IndexOf(simpleController);
					updateArgs = new UpdateArgs();
					updateArgs.Pos = simpleController.StartPos;
					updateArgs.IsRefresh = true;
				}
			}
			if (this._Standalone)
			{
				this.OnUpdate(updateArgs);
				return null;
			}
			return updateArgs;
		}

		public SimpleController PosToNextSimpleController(int pos, bool offset)
		{
			checked
			{
				if (offset)
				{
					int arg_12_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_12_0; i <= num; i++)
					{
						if (this.SubItems[i].StartPos > pos & this.SubItems[i] is SimpleController)
						{
							return (SimpleController)this.SubItems[i];
						}
					}
					return null;
				}
				for (int j = this.SubItems.Count - 1; j >= 0; j += -1)
				{
					if (this.SubItems[j].EndPos <= pos & this.SubItems[j] is SimpleController)
					{
						return (SimpleController)this.SubItems[j];
					}
				}
				return null;
			}
		}

		public override UpdateArgs OnInsertString(int pos, string value)
		{
			UpdateArgs updateArgs = null;
			checked
			{
				if (this.ActiveItem > -1)
				{
					updateArgs = this.SubItems[this.ActiveItem].OnInsertString(pos, value);
				}
				else if (pos == this.EndPos)
				{
					NIFree bindInstanceItem = new NIFree();
					FreeController freeController = new FreeController();
					freeController.BindInstanceItem = bindInstanceItem;
					freeController.ActionManager = this.ActionManager;
					InsertItemAction insertItemAction = new InsertItemAction(this, freeController, this.SubItems.Count, pos);
					this.ActionManager.AddToActionList(insertItemAction);
					insertItemAction.Execute();
					this.ActiveItem = this.SubItems.Count - 1;
					freeController.Active = true;
					freeController.StartPos = pos;
					updateArgs = freeController.OnInsertString(pos, value);
				}
				else
				{
					int arg_BA_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_BA_0; i <= num; i++)
					{
						if (this.SubItems[i].InterSection(pos + 1))
						{
							NIFree bindInstanceItem2 = new NIFree();
							FreeController freeController2 = new FreeController();
							freeController2.BindInstanceItem = bindInstanceItem2;
							freeController2.ActionManager = this.ActionManager;
							InsertItemAction insertItemAction2 = new InsertItemAction(this, freeController2, i, pos);
							this.ActionManager.AddToActionList(insertItemAction2);
							insertItemAction2.Execute();
							this.ActiveItem = i;
							freeController2.Active = true;
							freeController2.StartPos = pos;
							updateArgs = freeController2.OnInsertString(pos, value);
							break;
						}
					}
				}
				if (this.Parent == null)
				{
					FormateRangeEnumerator enumerator = this._BindNISegment.FormatRangeCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						FormateRange formateRange = (FormateRange)enumerator.Current;
						if (formateRange.ItemStartPos > pos)
						{
							formateRange.ItemStartPos += value.Length;
							formateRange.ItemEndPos += value.Length;
						}
					}
				}
				if (this._Standalone)
				{
					if (updateArgs != null)
					{
						bool arg_1DB_0 = updateArgs.IsRefresh & this._BindNISegment.FormatRangeCollection != null;
					}
					this.OnUpdate(updateArgs);
					return null;
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnInsertItem(int pos, NInstanceItem itemInsert)
		{
			UpdateArgs updateArgs = null;
			if (!(itemInsert is NISimple | itemInsert is NILink))
			{
				return null;
			}
			checked
			{
				if (this.ActiveItem > -1)
				{
					if (!(this.SubItems[this.ActiveItem] is FreeController))
					{
						this.SubItems[this.ActiveItem].DeActive();
						Controller controller = itemInsert.CreateController();
						controller.ActionManager = this.ActionManager;
						InsertItemAction insertItemAction = new InsertItemAction(this, controller, this.ActiveItem + 1, pos);
						this.ActionManager.AddToActionList(insertItemAction);
						insertItemAction.Execute();
						this.ActiveItem++;
						controller.Active = true;
						updateArgs = new UpdateArgs();
						updateArgs.IsRefresh = true;
						updateArgs.Pos = this.SubItems[this.ActiveItem - 1].EndPos;
					}
					else if (pos == this.SubItems[this.ActiveItem].StartPos)
					{
						this.SubItems[this.ActiveItem].DeActive();
						Controller controller2 = itemInsert.CreateController();
						controller2.ActionManager = this.ActionManager;
						InsertItemAction insertItemAction2 = new InsertItemAction(this, controller2, this.ActiveItem, pos);
						this.ActionManager.AddToActionList(insertItemAction2);
						insertItemAction2.Execute();
						controller2.Active = true;
						updateArgs = new UpdateArgs();
						updateArgs.IsRefresh = true;
						updateArgs.Pos = pos;
					}
					else if (pos == this.SubItems[this.ActiveItem].EndPos)
					{
						this.SubItems[this.ActiveItem].DeActive();
						Controller controller3 = itemInsert.CreateController();
						controller3.ActionManager = this.ActionManager;
						InsertItemAction insertItemAction3 = new InsertItemAction(this, controller3, this.ActiveItem + 1, pos);
						this.ActionManager.AddToActionList(insertItemAction3);
						insertItemAction3.Execute();
						this.ActiveItem++;
						controller3.Active = true;
						updateArgs = new UpdateArgs();
						updateArgs.IsRefresh = true;
						updateArgs.Pos = pos;
					}
					else
					{
						this.SubItems[this.ActiveItem].DeActive();
						FreeController freeController = (FreeController)this.SubItems[this.ActiveItem];
						string value = freeController.Text.Substring(pos - freeController.StartPos, freeController.EndPos - pos);
						freeController.OnDelete(pos, value);
						NIFree nIFree = new NIFree();
						FreeController freeController2 = (FreeController)nIFree.CreateController();
						freeController2.ActionManager = this.ActionManager;
						InsertItemAction insertItemAction4 = new InsertItemAction(this, freeController2, this.ActiveItem + 1, pos);
						this.ActionManager.AddToActionList(insertItemAction4);
						insertItemAction4.Execute();
						freeController2.StartPos = pos;
						updateArgs = freeController2.OnInsertString(pos, value);
						Controller controller4 = itemInsert.CreateController();
						controller4.ActionManager = this.ActionManager;
						controller4.SyncInstanceItem(itemInsert);
						InsertItemAction insertItemAction5 = new InsertItemAction(this, controller4, this.ActiveItem + 1, pos);
						this.ActionManager.AddToActionList(insertItemAction5);
						insertItemAction5.Execute();
						controller4.Active = true;
						updateArgs = new UpdateArgs();
						updateArgs.IsRefresh = true;
						updateArgs.Pos = pos;
					}
				}
				else if (pos == this.EndPos)
				{
					Controller controller5 = itemInsert.CreateController();
					controller5.ActionManager = this.ActionManager;
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
					int arg_3A4_0 = 0;
					int num = this.SubItems.Count - 1;
					for (int i = arg_3A4_0; i <= num; i++)
					{
						if (this.SubItems[i].InterSection(pos + 1))
						{
							Controller controller6 = itemInsert.CreateController();
							controller6.ActionManager = this.ActionManager;
							InsertItemAction insertItemAction7 = new InsertItemAction(this, controller6, i, pos);
							this.ActionManager.AddToActionList(insertItemAction7);
							insertItemAction7.Execute();
							this.ActiveItem = this.SubItems.Count - 1;
							controller6.Active = true;
							updateArgs = new UpdateArgs();
							updateArgs.IsRefresh = true;
							updateArgs.Pos = pos;
							break;
						}
					}
				}
				if (this._Standalone)
				{
					this.OnUpdate(updateArgs);
					return null;
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnDelete(int pos, string deleteValue)
		{
			MISegment mISegment = (MISegment)this.BindInstanceItem.BindMMetaItem;
			this._CanDelInnerStuct = !mISegment.FixedStructs;
			UpdateArgs updateArgs = new UpdateArgs();
			updateArgs.IsRefresh = true;
			updateArgs.Pos = pos;
			string text = deleteValue;
			int num = pos;
			bool flag = false;
			bool flag2 = false;
			string text2 = "";
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
					if (pos + deleteValue.Length <= controller.StartPos)
					{
						break;
					}
					if (flag)
					{
						if (controller is DictionaryController | controller is PositionController | controller is IconAnnoController | controller is DateTimeController | controller is MultiChoiceController | controller is QuantityController | (controller is SimpleController & (controller.Text == null | Operators.CompareString(controller.Text, "", false) == 0)) | controller is LinkController | controller is MonoChoiceController)
						{
							if (this._CanDelInnerStuct)
							{
								this.DeActive();
								DeleteItemAction deleteItemAction = new DeleteItemAction(this, controller);
								this.ActionManager.AddToActionList(deleteItemAction);
								deleteItemAction.Execute();
								if (updateArgs.Pos > controller.StartPos)
								{
									updateArgs.Pos = controller.StartPos;
								}
								i--;
								num2--;
								flag2 = true;
								text2 = "{" + controller.Name + "}";
								if (controller.EndPos < num + text.Length)
								{
									text = text.Substring(controller.EndPos - num);
									num = num + controller.EndPos - num;
								}
							}
							else
							{
								if (controller.EndPos < num + text.Length)
								{
									text = text.Substring(controller.EndPos - num);
									num = num + controller.EndPos - num;
								}
								if (updateArgs.Pos > controller.StartPos)
								{
									updateArgs.Pos = pos + 1;
								}
							}
						}
						else if (controller is StringController | controller is NumberController)
						{
							if (Operators.CompareString(deleteValue, controller.Text, false) == 0 & controller.Active)
							{
								string value = text;
								controller.OnDelete(num, value);
							}
							else if (this._CanDelInnerStuct & (num == controller.StartPos & controller.EndPos <= num + text.Length))
							{
								this.DeActive();
								DeleteItemAction deleteItemAction2 = new DeleteItemAction(this, controller);
								this.ActionManager.AddToActionList(deleteItemAction2);
								deleteItemAction2.Execute();
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
								i--;
								num2--;
								flag2 = true;
								text2 = "{" + controller.Name + "}";
							}
							else if (controller.EndPos < num + text.Length)
							{
								string value = text.Substring(0, controller.EndPos - num);
								controller.OnDelete(num, value);
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
							}
							else
							{
								string value = text;
								controller.OnDelete(num, value);
							}
						}
						else if (controller is FreeController)
						{
							if (num == controller.StartPos & controller.EndPos <= num + text.Length)
							{
								this.DeActive();
								string value = text.Substring(0, controller.EndPos - num);
								DeleteItemAction deleteItemAction3 = new DeleteItemAction(this, controller);
								this.ActionManager.AddToActionList(deleteItemAction3);
								deleteItemAction3.Execute();
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
								num2--;
								i--;
							}
							else if (controller.EndPos < num + text.Length)
							{
								string value = text.Substring(0, controller.EndPos - num);
								controller.OnDelete(num, value);
								text = text.Substring(controller.EndPos - num);
								num = num + controller.EndPos - num;
							}
							else
							{
								string value = text;
								controller.OnDelete(num, value);
							}
						}
					}
				}
				FormateRangeEnumerator enumerator = this._BindNISegment.FormatRangeCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FormateRange formateRange = (FormateRange)enumerator.Current;
					if (formateRange.ItemStartPos > pos)
					{
						if (flag2)
						{
							formateRange.ItemStartPos -= text2.Length;
							formateRange.ItemNullLength -= text2.Length;
							formateRange.ItemEndPos -= text2.Length;
						}
						else
						{
							formateRange.ItemStartPos -= deleteValue.Length;
							formateRange.ItemEndPos -= deleteValue.Length;
						}
					}
				}
				if (this._Standalone)
				{
					if (!(updateArgs.IsRefresh & this._BindNISegment.FormatRangeCollection != null) || flag2)
					{
					}
					this.OnUpdate(updateArgs);
					return null;
				}
				return updateArgs;
			}
		}

		public override UpdateArgs OnEnterKeyDown(int pos)
		{
			UpdateArgs updateArgs;
			if (this.ActiveItem == -1)
			{
				updateArgs = this.OnInsertString(pos, "\r");
			}
			else
			{
				updateArgs = this.SubItems[this.ActiveItem].OnEnterKeyDown(pos);
			}
			if (this._Standalone)
			{
				this.OnUpdate(updateArgs);
				return null;
			}
			return updateArgs;
		}

		public override UpdateArgs OnDoubleClick(int pos)
		{
			UpdateArgs updateArgs = null;
			if (this.ActiveItem != -1)
			{
				updateArgs = this.SubItems[this.ActiveItem].OnDoubleClick(pos);
			}
			if (this._Standalone)
			{
				this.OnUpdate(updateArgs);
				return null;
			}
			return updateArgs;
		}

		public override UpdateArgs OnFormate(int intpos, int destpos, FontStruct oldFontStruct, FontStruct newFontStruct)
		{
			if (this._BindNISegment.FormatRangeCollection == null)
			{
				this._BindNISegment.FormatRangeCollection = new FormateRangeCollection();
			}
			ArrayList itemsInSelected = this.GetItemsInSelected(intpos, destpos);
			checked
			{
				try
				{
					IEnumerator enumerator = itemsInSelected.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Controller controller = (Controller)enumerator.Current;
						if (Operators.CompareString(controller.Text, "", false) != 0)
						{
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
				UpdateArgs updateArgs = new UpdateArgs();
				updateArgs.IsRefresh = true;
				updateArgs.Pos = intpos;
				if (this._Standalone)
				{
					this.OnUpdate(updateArgs);
					return null;
				}
				return updateArgs;
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

		private ArrayList GetItemsInSelected(int intpos, int destpos)
		{
			ArrayList arrayList = new ArrayList();
			int arg_15_0 = 0;
			checked
			{
				int num = this.SubItems.Count - 1;
				for (int i = arg_15_0; i <= num; i++)
				{
					if (intpos < this.SubItems[i].EndPos && destpos > this.SubItems[i].StartPos)
					{
						arrayList.Add(this.SubItems[i]);
					}
				}
				return arrayList;
			}
		}
	}
}
