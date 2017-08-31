using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NISimple : NInstanceItem
	{
		public NISimple()
		{
			this.Value = "";
			this.ValueCode = "";
			this.FormatRangeCollection = new FormateRangeCollection();
		}

		public override Controller CreateController()
		{
			if (this.BindMMetaItem is MIString)
			{
				return new StringController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MINumber)
			{
				return new NumberController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIMonoChoice)
			{
				return new MonoChoiceController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIMultiChoice)
			{
				return new MultiChoiceController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIDateTime)
			{
				return new DateTimeController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIDictionary)
			{
				return new DictionaryController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIPosition)
			{
				return new PositionController
				{
					BindInstanceItem = this
				};
			}
			if (this.BindMMetaItem is MIQuantity)
			{
				return new QuantityController
				{
					BindInstanceItem = this
				};
			}
			return null;
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NISimple");
			base.XMLSerialize(writer);
			if (this.FormatRangeCollection != null)
			{
				this.FormatRangeCollection.XMLSerialize(writer);
			}
			if (this.RevisionHistory != null)
			{
				this.RevisionHistory.XMLSerialize(writer);
			}
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
				{
					this.FormatRangeCollection = new FormateRangeCollection();
					this.FormatRangeCollection.XMLDeserialize(reader);
				}
				if (Operators.CompareString(reader.Name, "RevisionHistory", false) == 0)
				{
					RevisionHistory revisionHistory = new RevisionHistory();
					revisionHistory.XMLDeserialize(reader);
					this.RevisionHistory = revisionHistory;
				}
				if (Operators.CompareString(reader.Name, "NISimple", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}

		protected override NInstanceItem.BindDataType GetEPRBindData(string str)
		{
			NInstanceItem.BindDataType result = default(NInstanceItem.BindDataType);
			if (this.BindMMetaItem is MIString)
			{
				result.IsTypeMatching = true;
				if (Operators.CompareString(str, "*NULL", false) == 0)
				{
					result.IsUseValueCode = false;
					result.Value = "";
				}
				else
				{
					string text = str.Split(new char[]
					{
						'@'
					})[0];
					if (Operators.CompareString(text, "*NULL", false) == 0)
					{
						result.IsUseValueCode = false;
						result.Value = "";
					}
					else
					{
						result.IsUseValueCode = false;
						result.Value = text.Replace("&nbsp;", " ");
					}
				}
			}
			else if (this.BindMMetaItem is MINumber)
			{
				MINumber mINumber = (MINumber)this.BindMMetaItem;
				if (!Versioned.IsNumeric(str))
				{
					MessageManager.ShowWarningMessage(mINumber.Text + "数值单元数据绑定有错！");
				}
				else
				{
					bool flag = true;
					float num = float.Parse(str);
					if (mINumber.HasMaxVal)
					{
						if (mINumber.IncludeMax)
						{
							if (num > mINumber.MaxVal)
							{
								flag = false;
							}
						}
						else if (num >= mINumber.MaxVal)
						{
							flag = false;
						}
					}
					if (mINumber.HasMinVal)
					{
						if (mINumber.IncludeMin)
						{
							if (num < mINumber.MinVal)
							{
								flag = false;
							}
						}
						else if (num <= mINumber.MinVal)
						{
							flag = false;
						}
					}
					if (flag)
					{
						result.IsTypeMatching = true;
						result.IsUseValueCode = false;
						result.Value = str;
					}
					else
					{
						MessageManager.ShowWarningMessage(mINumber.Text + "数值单元数据绑定有错！");
					}
				}
			}
			else if (this.BindMMetaItem is MIMonoChoice)
			{
				string[] array = this.BindMMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (Operators.CompareString(array[1], "TYPE:Simple", false) == 0)
				{
					int length = this.BindMMetaItem.EPRBindCode.IndexOf("#VTYPE:");
					string text2 = this.BindMMetaItem.EPRBindCode.Substring(0, length);
					string text3 = array[4].Split(new char[]
					{
						':'
					})[1];
					string left = array[5].Split(new char[]
					{
						':'
					})[1];
					if (text3.StartsWith("O") & Operators.CompareString(left, "VANDC", false) == 0)
					{
						result.IsTypeMatching = true;
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[0];
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[1];
						}
					}
				}
			}
			else if (this.BindMMetaItem is MIMultiChoice)
			{
				string[] array2 = this.BindMMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (Operators.CompareString(array2[1], "TYPE:Simple", false) == 0)
				{
					int length2 = this.BindMMetaItem.EPRBindCode.IndexOf("#VTYPE:");
					string text4 = this.BindMMetaItem.EPRBindCode.Substring(0, length2);
					string text5 = array2[4].Split(new char[]
					{
						':'
					})[1];
					string left2 = array2[5].Split(new char[]
					{
						':'
					})[1];
					if (text5.StartsWith("M") & Operators.CompareString(left2, "VANDC", false) == 0)
					{
						result.IsTypeMatching = true;
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[0];
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[1];
						}
					}
				}
			}
			else if (this.BindMMetaItem is MIQuantity)
			{
				string[] array3 = this.BindMMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (Operators.CompareString(array3[1], "TYPE:Simple", false) == 0)
				{
					int length3 = this.BindMMetaItem.EPRBindCode.IndexOf("#VTYPE:");
					string text6 = this.BindMMetaItem.EPRBindCode.Substring(0, length3);
					string text7 = array3[4].Split(new char[]
					{
						':'
					})[1];
					string left3 = array3[5].Split(new char[]
					{
						':'
					})[1];
					if (text7.StartsWith("Q") & Operators.CompareString(left3, "VANDC", false) == 0)
					{
						result.IsTypeMatching = true;
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[0];
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[1];
						}
					}
				}
			}
			else if (this.BindMMetaItem is MIDateTime)
			{
				string[] array4 = this.BindMMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (Operators.CompareString(array4[1], "TYPE:Simple", false) == 0)
				{
					int length4 = this.BindMMetaItem.EPRBindCode.IndexOf("#VTYPE:");
					string text8 = this.BindMMetaItem.EPRBindCode.Substring(0, length4);
					string text9 = array4[4].Split(new char[]
					{
						':'
					})[1];
					string left4 = array4[5].Split(new char[]
					{
						':'
					})[1];
					if (text9.StartsWith("D") & Operators.CompareString(left4, "VANDC", false) == 0)
					{
						result.IsTypeMatching = true;
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[0].Replace("&nbsp;", " ");
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[1].Replace("&nbsp;", " ");
							if (Operators.CompareString(result.ValueCode, "", false) != 0 && Operators.CompareString(result.ValueCode, " ", false) != 0 && result.ValueCode.Split(new char[]
							{
								' '
							}).Length == 2)
							{
								string text10 = result.ValueCode.Split(new char[]
								{
									' '
								})[0];
								string text11 = result.ValueCode.Split(new char[]
								{
									' '
								})[1];
								MIDateTime mIDateTime = (MIDateTime)this.BindMMetaItem;
								if (Operators.CompareString(mIDateTime.DateFormate, "LONG", false) == 0 && text10.Split(new char[]
								{
									'-'
								}).Length == 3)
								{
									string text12 = text10.Split(new char[]
									{
										'-'
									})[0];
									string text13 = text10.Split(new char[]
									{
										'-'
									})[1];
									string text14 = text10.Split(new char[]
									{
										'-'
									})[2];
									text10 = string.Concat(new string[]
									{
										text12,
										"年",
										text13,
										"月",
										text14,
										"日"
									});
								}
								if (mIDateTime.IncludeDate && mIDateTime.IncludeTime)
								{
									string str2 = "";
									if (Operators.CompareString(text10, "", false) != 0 && Operators.CompareString(text11, "", false) != 0)
									{
										str2 = " ";
									}
									result.Value = text10 + str2 + text11;
								}
								else if (mIDateTime.IncludeDate && !mIDateTime.IncludeTime)
								{
									result.Value = text10;
								}
								else if (!mIDateTime.IncludeDate && mIDateTime.IncludeTime)
								{
									result.Value = text11;
								}
							}
						}
					}
				}
			}
			else if (this.BindMMetaItem is MIDictionary)
			{
				string[] array5 = this.BindMMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (Operators.CompareString(array5[1], "TYPE:Simple", false) == 0)
				{
					int length5 = this.BindMMetaItem.EPRBindCode.IndexOf("#VTYPE:");
					string text15 = this.BindMMetaItem.EPRBindCode.Substring(0, length5);
					string text16 = array5[4].Split(new char[]
					{
						':'
					})[1];
					string left5 = array5[5].Split(new char[]
					{
						':'
					})[1];
					if (text16.StartsWith("I") & Operators.CompareString(left5, "VANDC", false) == 0)
					{
						result.IsTypeMatching = true;
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[0];
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[1];
						}
					}
				}
			}
			return result;
		}

		protected override NInstanceItem.BindDataType GetDataBaseData(string str)
		{
			NInstanceItem.BindDataType result = default(NInstanceItem.BindDataType);
			checked
			{
				if (this.BindMMetaItem is MIString)
				{
					result.IsUseValueCode = false;
					result.Value = str;
				}
				else if (this.BindMMetaItem is MINumber)
				{
					MINumber mINumber = (MINumber)this.BindMMetaItem;
					if (!Versioned.IsNumeric(str))
					{
						MessageManager.ShowWarningMessage(mINumber.Text + "数值单元数据绑定有错！");
					}
					else
					{
						bool flag = true;
						float num = float.Parse(str);
						if (mINumber.HasMaxVal)
						{
							if (mINumber.IncludeMax)
							{
								if (num > mINumber.MaxVal)
								{
									flag = false;
								}
							}
							else if (num >= mINumber.MaxVal)
							{
								flag = false;
							}
						}
						if (mINumber.HasMinVal)
						{
							if (mINumber.IncludeMin)
							{
								if (num < mINumber.MinVal)
								{
									flag = false;
								}
							}
							else if (num <= mINumber.MinVal)
							{
								flag = false;
							}
						}
						if (flag)
						{
							result.IsUseValueCode = false;
							result.Value = str;
						}
						else
						{
							MessageManager.ShowWarningMessage(mINumber.Text + "数值单元数据绑定有错！");
						}
					}
				}
				else if (this.BindMMetaItem is MIMonoChoice)
				{
					MIMonoChoice mIMonoChoice = (MIMonoChoice)this.BindMMetaItem;
					int num2 = 0;
					StringEnumerator enumerator = mIMonoChoice.Choices.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						string text;
						string text2;
						if (current.IndexOf("|") > -1)
						{
							text = current.Split(new char[]
							{
								'|'
							})[0];
							text2 = current.Split(new char[]
							{
								'|'
							})[1];
						}
						else
						{
							text = current;
							text2 = num2.ToString();
						}
						if (Operators.CompareString(str, text, false) == 0 | Operators.CompareString(str, text2, false) == 0)
						{
							result.IsUseValueCode = true;
							result.Value = text;
							result.ValueCode = text2;
							break;
						}
						num2++;
					}
				}
				else if (this.BindMMetaItem is MIMultiChoice)
				{
					MIMultiChoice mIMultiChoice = (MIMultiChoice)this.BindMMetaItem;
					string[] array = str.Split(new char[]
					{
						'^'
					});
					string text3 = "";
					string text4 = "";
					StringEnumerator enumerator2 = mIMultiChoice.Choices.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						bool flag2 = false;
						int arg_24A_0 = 0;
						int num3 = array.Length - 1;
						for (int i = arg_24A_0; i <= num3; i++)
						{
							if (Operators.CompareString(current2, array[i], false) == 0)
							{
								flag2 = true;
								break;
							}
						}
						if (flag2)
						{
							text4 += "1";
							text3 = text3 + current2 + mIMultiChoice.Seperator;
						}
					}
					if (text3.Length > 0)
					{
						text3 = text3.Substring(0, text3.Length - 1);
					}
					result.IsUseValueCode = true;
					result.Value = text3;
					result.ValueCode = text4;
				}
				else if (this.BindMMetaItem is MIQuantity)
				{
					if (!(str == null | Operators.CompareString(str, "", false) == 0))
					{
						if (str.IndexOf("^") > -1)
						{
							result.IsUseValueCode = true;
							result.Value = str.Split(new char[]
							{
								'^'
							})[1];
							result.ValueCode = str.Split(new char[]
							{
								'^'
							})[0];
						}
					}
				}
				else if (this.BindMMetaItem is MIDateTime)
				{
					string text5 = "^((\\d{2}(([02468][048])|([13579][26]))[\\-]?((((0?[13578])|(1[02]))[\\-]?((0?[1-9])|([1-2][0-9])|(3[01])))|(((0?[469])|(11))[\\-]?((0?[1-9])|([1-2][0-9])|(30)))|(0?2[\\-]?((0?[1-9])|([1-2][0-9])))))|(\\d{2}(([02468][1235679])|([13579][01345789]))[\\-]?((((0?[13578])|(1[02]))[\\-]?((0?[1-9])|([1-2][0-9])|(3[01])))|(((0?[469])|(11))[\\-]?((0?[1-9])|([1-2][0-9])|(30)))|(0?2[\\-]?((0?[1-9])|(1[0-9])|(2[0-8]))))))";
					string text6 = "(((0?[0-9])|(1?[0-9])|(2?[0-3]))\\:([0-5]?[0-9])((\\s)|(\\:([0-5]?[0-9])))))?$";
					RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace;
					MIDateTime mIDateTime = (MIDateTime)this.BindMMetaItem;
					if (mIDateTime.IncludeDate & mIDateTime.IncludeTime)
					{
						Regex regex = new Regex(text5 + "(\\s" + text6, options);
						if (regex.IsMatch(str) & str.IndexOf(" ") > -1)
						{
							DateTime dateTime = DateTime.Parse(str);
							string text7 = string.Concat(new string[]
							{
								dateTime.Year.ToString(),
								"-",
								dateTime.Month.ToString(),
								"-",
								Conversions.ToString(dateTime.Day)
							});
							string text8 = string.Format("{0:00}:{1:00}:{2:00}", dateTime.Hour, dateTime.Minute, dateTime.Second);
							result.IsUseValueCode = true;
							result.ValueCode = text7 + " " + text8;
							if (Operators.CompareString(mIDateTime.DateFormate, "SHORT", false) == 0)
							{
								result.Value = text7;
							}
							else if (Operators.CompareString(mIDateTime.DateFormate, "LONG", false) == 0)
							{
								result.Value = string.Concat(new string[]
								{
									dateTime.Year.ToString(),
									"年",
									dateTime.Month.ToString(),
									"月",
									dateTime.Day.ToString(),
									"日 ",
									text8
								});
							}
						}
					}
					else if (mIDateTime.IncludeDate & !mIDateTime.IncludeTime)
					{
						Regex regex = new Regex(text5, options);
						if (regex.IsMatch(str))
						{
							DateTime dateTime2 = DateTime.Parse(str);
							string text9 = string.Concat(new string[]
							{
								dateTime2.Year.ToString(),
								"-",
								dateTime2.Month.ToString(),
								"-",
								dateTime2.Day.ToString()
							});
							result.IsUseValueCode = true;
							result.ValueCode = text9 + " 00:00:00";
							if (Operators.CompareString(mIDateTime.DateFormate, "SHORT", false) == 0)
							{
								result.Value = text9;
							}
							else if (Operators.CompareString(mIDateTime.DateFormate, "LONG", false) == 0)
							{
								result.Value = string.Concat(new string[]
								{
									dateTime2.Year.ToString(),
									"年",
									dateTime2.Month.ToString(),
									"月",
									dateTime2.Day.ToString(),
									"日"
								});
							}
						}
					}
					else if (!mIDateTime.IncludeDate & mIDateTime.IncludeTime)
					{
						Regex regex = new Regex("(" + text6, options);
						if (regex.IsMatch(str))
						{
							DateTime dateTime3 = DateTime.Parse(str);
							string text10 = string.Format("{0:00}:{1:00}:{2:00}", dateTime3.Hour, dateTime3.Minute, dateTime3.Second);
							result.IsUseValueCode = true;
							result.Value = text10;
							result.ValueCode = "1753-1-1 " + text10;
						}
					}
				}
				else if (this.BindMMetaItem is MIDictionary)
				{
					MIDictionary mIDictionary = (MIDictionary)this.BindMMetaItem;
					if (!(str == null | Operators.CompareString(str, "", false) == 0) && str.IndexOf("^") > -1)
					{
						result.IsUseValueCode = true;
						result.Value = str.Split(new char[]
						{
							'^'
						})[1];
						result.ValueCode = str.Split(new char[]
						{
							'^'
						})[0];
					}
				}
				return result;
			}
		}

		public override string GetByVType(string strVType)
		{
			if (this.BindMMetaItem is MIDateTime)
			{
				if (Operators.CompareString(strVType, "C", false) == 0)
				{
					return this.ValueCode;
				}
				if (Operators.CompareString(strVType, "T", false) == 0 || Operators.CompareString(strVType, "V", false) == 0)
				{
					return this.Value;
				}
				if (string.IsNullOrEmpty(this.ValueCode))
				{
					return string.Empty;
				}
				string[] array = this.ValueCode.Split(new char[]
				{
					' '
				});
				string text = array[0];
				string text2 = Conversions.ToString(Interaction.IIf(array.Length == 2, array[1], string.Empty));
				if (!string.IsNullOrEmpty(text))
				{
					string result = text.Split(new char[]
					{
						'-'
					})[0];
					string result2 = text.Split(new char[]
					{
						'-'
					})[1];
					string result3 = text.Split(new char[]
					{
						'-'
					})[2];
					if (Operators.CompareString(strVType, "YMD", false) == 0)
					{
						return text;
					}
					if (Operators.CompareString(strVType, "YEAR", false) == 0)
					{
						return result;
					}
					if (Operators.CompareString(strVType, "MONTH", false) == 0)
					{
						return result2;
					}
					if (Operators.CompareString(strVType, "DAY", false) == 0)
					{
						return result3;
					}
				}
				if (!string.IsNullOrEmpty(text2))
				{
					string result4 = text2.Split(new char[]
					{
						':'
					})[0];
					string result5 = text2.Split(new char[]
					{
						':'
					})[1];
					string result6 = text2.Split(new char[]
					{
						':'
					})[2];
					if (Operators.CompareString(strVType, "HMS", false) == 0)
					{
						return text2;
					}
					if (Operators.CompareString(strVType, "HOUR", false) == 0)
					{
						return result4;
					}
					if (Operators.CompareString(strVType, "MINUTE", false) == 0)
					{
						return result5;
					}
					if (Operators.CompareString(strVType, "SECOND", false) == 0)
					{
						return result6;
					}
				}
				return string.Empty;
			}
			else
			{
				if (Operators.CompareString(strVType, "C", false) == 0)
				{
					return this.ValueCode;
				}
				return this.Value;
			}
		}

		public override void SetByVType(string strValue, string strVType)
		{
			checked
			{
				if (this.BindMMetaItem is MIString)
				{
					this.Value = strValue;
				}
				else if (this.BindMMetaItem is MINumber)
				{
					MINumber mINumber = (MINumber)this.BindMMetaItem;
					if (Versioned.IsNumeric(strValue))
					{
						bool flag = true;
						float num = float.Parse(strValue);
						if (mINumber.HasMaxVal)
						{
							if (mINumber.IncludeMax)
							{
								if (num > mINumber.MaxVal)
								{
									flag = false;
								}
							}
							else if (num >= mINumber.MaxVal)
							{
								flag = false;
							}
						}
						if (mINumber.HasMinVal)
						{
							if (mINumber.IncludeMin)
							{
								if (num < mINumber.MinVal)
								{
									flag = false;
								}
							}
							else if (num <= mINumber.MinVal)
							{
								flag = false;
							}
						}
						if (flag)
						{
							this.Value = strValue;
						}
					}
				}
				else if (this.BindMMetaItem is MIMonoChoice)
				{
					MIMonoChoice mIMonoChoice = (MIMonoChoice)this.BindMMetaItem;
					if (Operators.CompareString(strVType, "C", false) == 0)
					{
						int num2 = 0;
						StringEnumerator enumerator = mIMonoChoice.Choices.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							if (current.IndexOf("|") > -1)
							{
								if (Operators.CompareString(strValue, current.Split(new char[]
								{
									'|'
								})[1], false) == 0)
								{
									this.Value = current.Split(new char[]
									{
										'|'
									})[0];
									this.ValueCode = current.Split(new char[]
									{
										'|'
									})[1];
								}
							}
							else if (Operators.CompareString(strValue, num2.ToString(), false) == 0)
							{
								this.Value = current;
								this.ValueCode = num2.ToString();
							}
							num2++;
						}
					}
					else if (Operators.CompareString(strVType, "T", false) == 0)
					{
						int num3 = 0;
						StringEnumerator enumerator2 = mIMonoChoice.Choices.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							if (current2.IndexOf("|") > -1)
							{
								if (Operators.CompareString(strValue, current2.Split(new char[]
								{
									'|'
								})[0], false) == 0)
								{
									this.Value = current2.Split(new char[]
									{
										'|'
									})[0];
									this.ValueCode = current2.Split(new char[]
									{
										'|'
									})[1];
								}
							}
							else if (Operators.CompareString(strValue, current2.ToString(), false) == 0)
							{
								this.Value = current2;
								this.ValueCode = num3.ToString();
							}
							num3++;
						}
					}
				}
				else if (this.BindMMetaItem is MIMultiChoice)
				{
					MIMultiChoice mIMultiChoice = (MIMultiChoice)this.BindMMetaItem;
					if (Operators.CompareString(strVType, "C", false) == 0)
					{
						IEnumerator enumerator3 = strValue.GetEnumerator();
						string str = "";
						string str2 = "";
						StringEnumerator enumerator4 = mIMultiChoice.Choices.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							string current3 = enumerator4.Current;
							if (enumerator3.MoveNext())
							{
								string text = Conversions.ToString(enumerator3.Current);
								if (Operators.CompareString(text, "1", false) == 0)
								{
									str2 = str2 + current3 + mIMultiChoice.Seperator;
								}
								str += text;
							}
							else
							{
								str += "0";
							}
						}
					}
				}
				else if (this.BindMMetaItem is MIQuantity)
				{
					MIQuantity mIQuantity = (MIQuantity)this.BindMMetaItem;
					if (Operators.CompareString(strVType, "C", false) == 0)
					{
						MUnitCodeEnumerator enumerator5 = mIQuantity.UnitCodes.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							MUnitCode mUnitCode = (MUnitCode)enumerator5.Current;
							if (Operators.CompareString(mUnitCode.UnitSymbol, strValue, false) == 0)
							{
								this.ValueCode = strValue;
								break;
							}
						}
					}
					else if (Operators.CompareString(strVType, "T", false) == 0)
					{
						if (!Versioned.IsNumeric(strValue))
						{
							throw new ApplicationException(mIQuantity.Code + "数量单元数据自动计算有错！");
						}
						bool flag2 = true;
						float num4 = float.Parse(strValue);
						MUnitCode mUnitCode2 = null;
						MUnitCodeEnumerator enumerator6 = mIQuantity.UnitCodes.GetEnumerator();
						while (enumerator6.MoveNext())
						{
							MUnitCode mUnitCode3 = (MUnitCode)enumerator6.Current;
							if (Operators.CompareString(mUnitCode3.UnitSymbol, this.ValueCode, false) == 0)
							{
								mUnitCode2 = mUnitCode3;
								break;
							}
						}
						if (mUnitCode2 == null)
						{
							flag2 = true;
						}
						else
						{
							if (mUnitCode2.HasMaxVal)
							{
								if (mUnitCode2.IncludeMax)
								{
									if (num4 > mUnitCode2.MaxVal)
									{
										flag2 = false;
									}
								}
								else if (num4 >= mUnitCode2.MaxVal)
								{
									flag2 = false;
								}
							}
							if (mUnitCode2.HasMinVal)
							{
								if (mUnitCode2.IncludeMin)
								{
									if (num4 < mUnitCode2.MinVal)
									{
										flag2 = false;
									}
								}
								else if (num4 <= mUnitCode2.MinVal)
								{
									flag2 = false;
								}
							}
						}
						if (!flag2)
						{
							throw new ApplicationException(mIQuantity.Code + "数量单元数据自动计算有错！");
						}
						this.Value = strValue;
					}
				}
				else if (this.BindMMetaItem is MIDateTime)
				{
					if (strValue == null | Operators.CompareString(strValue, "", false) != 0)
					{
						MIDateTime mIDateTime = (MIDateTime)this.BindMMetaItem;
						if (mIDateTime.IncludeDate & mIDateTime.IncludeTime)
						{
							DateTime dateTime = DateTime.Parse(strValue);
							string text2 = string.Concat(new string[]
							{
								dateTime.Year.ToString(),
								"-",
								dateTime.Month.ToString(),
								"-",
								Conversions.ToString(dateTime.Day)
							});
							string text3 = string.Format("{0:00}:{1:00}:{2:00}", dateTime.Hour, dateTime.Minute, dateTime.Second);
							this.ValueCode = text2 + " " + text3;
							if (Operators.CompareString(mIDateTime.DateFormate, "SHORT", false) == 0)
							{
								this.Value = text2;
							}
							else if (Operators.CompareString(mIDateTime.DateFormate, "LONG", false) == 0)
							{
								this.Value = string.Concat(new string[]
								{
									dateTime.Year.ToString(),
									"年",
									dateTime.Month.ToString(),
									"月",
									dateTime.Day.ToString(),
									"日 ",
									text3
								});
							}
						}
						else if (mIDateTime.IncludeDate & !mIDateTime.IncludeTime)
						{
							DateTime dateTime2 = DateTime.Parse(strValue);
							string text4 = string.Concat(new string[]
							{
								dateTime2.Year.ToString(),
								"-",
								dateTime2.Month.ToString(),
								"-",
								dateTime2.Day.ToString()
							});
							this.ValueCode = text4 + " 00:00:00";
							if (Operators.CompareString(mIDateTime.DateFormate, "SHORT", false) == 0)
							{
								this.Value = text4;
							}
							else if (Operators.CompareString(mIDateTime.DateFormate, "LONG", false) == 0)
							{
								this.Value = string.Concat(new string[]
								{
									dateTime2.Year.ToString(),
									"年",
									dateTime2.Month.ToString(),
									"月",
									dateTime2.Day.ToString(),
									"日"
								});
							}
						}
						else if (!mIDateTime.IncludeDate & mIDateTime.IncludeTime)
						{
							DateTime dateTime3 = DateTime.Parse(strValue);
							string text5 = string.Format("{0:00}:{1:00}:{2:00}", dateTime3.Hour, dateTime3.Minute, dateTime3.Second);
							this.ValueCode = "1753-1-1 " + text5;
							this.Value = text5;
						}
					}
				}
				else if (this.BindMMetaItem is MIDictionary)
				{
					if (Operators.CompareString(strVType, "C", false) == 0)
					{
						this.ValueCode = strValue;
					}
					else if (Operators.CompareString(strVType, "T", false) == 0)
					{
						this.Value = strValue;
					}
				}
			}
		}
	}
}
