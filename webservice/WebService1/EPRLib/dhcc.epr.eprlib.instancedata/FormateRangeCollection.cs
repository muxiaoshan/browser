using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class FormateRangeCollection : CollectionBase
	{
		public FormateRange this[int index]
		{
			get
			{
				return (FormateRange)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		public string XMLString
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringWriter stringWriter = new StringWriter(stringBuilder);
				XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
				xmlTextWriter.Formatting = Formatting.None;
				this.XMLSerialize(xmlTextWriter);
				string result = stringBuilder.ToString();
				xmlTextWriter.Close();
				stringWriter.Close();
				return result;
			}
			set
			{
				StringReader input = new StringReader(value);
				XmlTextReader xmlTextReader = new XmlTextReader(input);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				xmlTextReader.Read();
				this.XMLDeserialize(xmlTextReader);
				xmlTextReader.Close();
			}
		}

		[DebuggerNonUserCode]
		public FormateRangeCollection()
		{
		}

		public void Add(FormateRange value)
		{
			if (!this.Contains(value))
			{
				this.List.Add(value);
			}
		}

		public bool Contains(FormateRange value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(FormateRange value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, FormateRange value)
		{
			if (index > this.List.Count)
			{
				this.List.Add(value);
			}
			else
			{
				this.List.Insert(index, value);
			}
		}

		public void Remove(FormateRange value)
		{
			this.List.Remove(value);
		}

		public new FormateRangeEnumerator GetEnumerator()
		{
			return new FormateRangeEnumerator(this);
		}

		public void OnFormate(int intpos, int destpos, int Itemintpos, int Itemdestpos, int ItemnullLength, FontStruct oldFontStruct, FontStruct newFontStruct, ActionManager ActionManager)
		{
			int num = intpos;
			int num2 = this.Count;
			if (num2 == 0)
			{
				this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.Count, ActionManager);
				return;
			}
			checked
			{
				for (int i = 0; i < num2; i++)
				{
					FormateRange formateRange = this[i];
					if (destpos <= formateRange.StartPos)
					{
						this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange), ActionManager);
						i++;
						num2++;
						break;
					}
					if (num >= formateRange.EndPos)
					{
						if (i == num2 - 1)
						{
							this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange) + 1, ActionManager);
							i++;
							num2++;
							break;
						}
					}
					else if (num <= formateRange.StartPos & formateRange.EndPos <= destpos)
					{
						ReplaceFormateAction replaceFormateAction = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, num, formateRange.EndPos, newFontStruct, formateRange);
						ActionManager.AddToActionList(replaceFormateAction);
						replaceFormateAction.Execute();
						if (formateRange.EndPos >= destpos)
						{
							break;
						}
						num = formateRange.EndPos;
						if (i == num2 - 1)
						{
							this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange) + 1, ActionManager);
							i++;
							num2++;
							break;
						}
					}
					else
					{
						if (formateRange.StartPos <= num & destpos <= formateRange.EndPos)
						{
							if (formateRange.StartPos < num)
							{
								this.InsertFormateRange(formateRange.StartPos, num, Itemintpos, Itemdestpos, ItemnullLength, formateRange.FontStruct, this.IndexOf(formateRange), ActionManager);
								i++;
								num2++;
							}
							this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange), ActionManager);
							i++;
							num2++;
							if (destpos < formateRange.EndPos)
							{
								this.InsertFormateRange(destpos, formateRange.EndPos, Itemintpos, Itemdestpos, ItemnullLength, formateRange.FontStruct, this.IndexOf(formateRange), ActionManager);
								i++;
								num2++;
							}
							DeleteFormateAction deleteFormateAction = new DeleteFormateAction(this, formateRange);
							ActionManager.AddToActionList(deleteFormateAction);
							deleteFormateAction.Execute();
							i--;
							num2--;
							break;
						}
						if (formateRange.StartPos < num & num < formateRange.EndPos & formateRange.EndPos < destpos)
						{
							int startPos = formateRange.StartPos;
							int endPos = formateRange.EndPos;
							ReplaceFormateAction replaceFormateAction2 = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos, num, formateRange.FontStruct, formateRange);
							ActionManager.AddToActionList(replaceFormateAction2);
							replaceFormateAction2.Execute();
							this.InsertFormateRange(num, endPos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange) + 1, ActionManager);
							i++;
							num2++;
							num = endPos;
							if (i == num2 - 1)
							{
								this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange) + 2, ActionManager);
								break;
							}
						}
						else if (num < formateRange.StartPos & formateRange.StartPos < destpos & destpos < formateRange.EndPos)
						{
							this.InsertFormateRange(num, destpos, Itemintpos, Itemdestpos, ItemnullLength, newFontStruct, this.IndexOf(formateRange), ActionManager);
							i++;
							num2++;
							ReplaceFormateAction replaceFormateAction3 = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, destpos, formateRange.EndPos, formateRange.FontStruct, formateRange);
							ActionManager.AddToActionList(replaceFormateAction3);
							replaceFormateAction3.Execute();
							break;
						}
					}
				}
				this.CombineFormateRange(ActionManager);
			}
		}

		private void InsertFormateRange(int startPos, int endPos, int itemStartPos, int itemEndPos, int itemNullLength, FontStruct fontStruct, int index, ActionManager ActionManager)
		{
			InsertFormateAction insertFormateAction = new InsertFormateAction(this, new FormateRange
			{
				StartPos = startPos,
				EndPos = endPos,
				FontStruct = fontStruct,
				ItemStartPos = itemStartPos,
				ItemEndPos = itemEndPos,
				ItemNullLength = itemNullLength
			}, index);
			ActionManager.AddToActionList(insertFormateAction);
			insertFormateAction.Execute();
		}

		public void CombineFormateRange(ActionManager ActionManager)
		{
			int num = this.Count;
			checked
			{
				int i;
				for (i = 0; i < num; i++)
				{
					int num2 = i + 1;
					if (num2 >= num)
					{
						break;
					}
					FormateRange formateRange = this[i];
					FormateRange formateRange2 = this[num2];
					bool flag = formateRange.FontStruct.Font.Equals(formateRange2.FontStruct.Font) & formateRange.FontStruct.CharOffset == formateRange2.FontStruct.CharOffset;
					if (flag & formateRange.EndPos == formateRange2.StartPos)
					{
						ReplaceFormateAction replaceFormateAction = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos, formateRange2.EndPos, formateRange.FontStruct, formateRange);
						ActionManager.AddToActionList(replaceFormateAction);
						replaceFormateAction.Execute();
						DeleteFormateAction deleteFormateAction = new DeleteFormateAction(this, formateRange2);
						ActionManager.AddToActionList(deleteFormateAction);
						deleteFormateAction.Execute();
						i--;
						num--;
					}
				}
				i = 0;
				num = this.Count;
				while (i < num)
				{
					FormateRange formateRange3 = this[i];
					if (formateRange3.EndPos < 0)
					{
						DeleteFormateAction deleteFormateAction2 = new DeleteFormateAction(this, formateRange3);
						ActionManager.AddToActionList(deleteFormateAction2);
						deleteFormateAction2.Execute();
						i--;
						num--;
					}
					i++;
				}
			}
		}

		public void OnInsertString(int pos, string insertStr, ActionManager ActionManager)
		{
			int length = insertStr.Length;
			int num = this.Count;
			checked
			{
				for (int i = 0; i < num; i++)
				{
					FormateRange formateRange = this[i];
					if (formateRange.StartPos < pos & pos < formateRange.EndPos)
					{
						ReplaceFormateAction replaceFormateAction = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos, pos, formateRange.FontStruct, formateRange);
						ActionManager.AddToActionList(replaceFormateAction);
						replaceFormateAction.Execute();
						this.InsertFormateRange(pos + length, formateRange.EndPos + length, formateRange.ItemStartPos, formateRange.ItemEndPos, formateRange.ItemNullLength, formateRange.FontStruct, this.IndexOf(formateRange) + 1, ActionManager);
						i++;
						num++;
					}
					else if (pos <= formateRange.StartPos)
					{
						ReplaceFormateAction replaceFormateAction2 = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos + length, formateRange.EndPos + length, formateRange.FontStruct, formateRange);
						ActionManager.AddToActionList(replaceFormateAction2);
						replaceFormateAction2.Execute();
					}
				}
				this.CombineFormateRange(ActionManager);
			}
		}

		public void OnDeleteString(int pos, string deleteStr, ActionManager ActionManager)
		{
			int num = this.Count;
			int i = 0;
			checked
			{
				int num2 = pos + deleteStr.Length;
				int length = deleteStr.Length;
				while (i < num)
				{
					FormateRange formateRange = this[i];
					if (num2 <= formateRange.StartPos)
					{
						if (formateRange.StartPos - length > 0)
						{
							ReplaceFormateAction replaceFormateAction = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos - length, formateRange.EndPos - length, formateRange.FontStruct, formateRange);
							ActionManager.AddToActionList(replaceFormateAction);
							replaceFormateAction.Execute();
						}
					}
					else if (pos < formateRange.EndPos)
					{
						if (pos <= formateRange.StartPos & formateRange.EndPos <= num2)
						{
							DeleteFormateAction deleteFormateAction = new DeleteFormateAction(this, formateRange);
							ActionManager.AddToActionList(deleteFormateAction);
							deleteFormateAction.Execute();
							i--;
							num--;
						}
						else if (formateRange.StartPos <= pos & num2 <= formateRange.EndPos)
						{
							if (formateRange.StartPos < pos)
							{
								this.InsertFormateRange(formateRange.StartPos, pos, formateRange.ItemStartPos, formateRange.ItemEndPos, formateRange.ItemNullLength, formateRange.FontStruct, this.IndexOf(formateRange), ActionManager);
								i++;
								num++;
							}
							if (num2 < formateRange.EndPos)
							{
								this.InsertFormateRange(pos, formateRange.EndPos - length, formateRange.ItemStartPos, formateRange.ItemEndPos, formateRange.ItemNullLength, formateRange.FontStruct, this.IndexOf(formateRange), ActionManager);
								i++;
								num++;
							}
							DeleteFormateAction deleteFormateAction2 = new DeleteFormateAction(this, formateRange);
							ActionManager.AddToActionList(deleteFormateAction2);
							deleteFormateAction2.Execute();
							i--;
							num--;
						}
						else if (formateRange.StartPos < pos & pos < formateRange.EndPos & formateRange.EndPos < num2)
						{
							ReplaceFormateAction replaceFormateAction2 = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, formateRange.StartPos, pos, formateRange.FontStruct, formateRange);
							ActionManager.AddToActionList(replaceFormateAction2);
							replaceFormateAction2.Execute();
						}
						else if (pos < formateRange.StartPos & formateRange.StartPos < num2 & num2 < formateRange.EndPos)
						{
							ReplaceFormateAction replaceFormateAction3 = new ReplaceFormateAction(formateRange.StartPos, formateRange.EndPos, formateRange.FontStruct, pos, formateRange.EndPos - length, formateRange.FontStruct, formateRange);
							ActionManager.AddToActionList(replaceFormateAction3);
							replaceFormateAction3.Execute();
						}
					}
					i++;
				}
				this.CombineFormateRange(ActionManager);
			}
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FormatRange", false) == 0)
				{
					FormateRange formateRange = new FormateRange();
					formateRange.XMLDeserialize(reader);
					this.Add(formateRange);
				}
				else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0)
				{
					break;
				}
			}
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("FormatRangeCollection");
			FormateRangeEnumerator enumerator = this.GetEnumerator();
			while (enumerator.MoveNext())
			{
				FormateRange formateRange = (FormateRange)enumerator.Current;
				formateRange.XMLSerialize(writer);
			}
			writer.WriteEndElement();
		}
	}
}
