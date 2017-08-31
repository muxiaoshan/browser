using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

namespace dhcc.epr.eprlib.formula
{
	public class Parser
	{
		private string m_sFunction;

		private static string m_sWhitespace = " \t";

		private static string m_sDelimiters = "+-*/^()<>=&|!,";

		private static string m_sNumbers = "0123456789.";

		private static string m_sQuotes = "\"";

		private static string m_sLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz$";

		private ArrayList m_alTokens;

		public Parser(string sFunction)
		{
			this.m_sFunction = sFunction;
			this.Parse();
		}

		public IEnumerator GetTokenEnumerator()
		{
			return this.m_alTokens.GetEnumerator();
		}

		private void Parse()
		{
			this.m_alTokens = new ArrayList();
			bool flag = false;
			bool flag2 = false;
			CharType charType = CharType.CT_UNDEF;
			string text = "";
			CharEnumerator enumerator = this.m_sFunction.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (Parser.m_sQuotes.IndexOf(enumerator.Current) > -1)
				{
					if (!flag & !flag2)
					{
						flag = true;
						charType = CharType.CT_STRING;
					}
					else if (flag & !flag2)
					{
						flag2 = true;
					}
					else if (flag & flag2)
					{
						text += Conversions.ToString(enumerator.Current);
						flag2 = false;
					}
				}
				else if (Parser.m_sWhitespace.IndexOf(enumerator.Current) > -1)
				{
					if (charType == CharType.CT_STRING)
					{
						if (flag2)
						{
							flag = false;
							flag2 = false;
							this.CheckToken(charType, text);
							text = "";
							charType = CharType.CT_UNDEF;
						}
						else
						{
							text += Conversions.ToString(enumerator.Current);
						}
					}
					else
					{
						if (text.Length > 0)
						{
							this.CheckToken(charType, text);
						}
						text = "";
						charType = CharType.CT_UNDEF;
					}
				}
				else if (Parser.m_sDelimiters.IndexOf(enumerator.Current) > -1)
				{
					if (charType == CharType.CT_STRING)
					{
						if (flag2)
						{
							this.CheckToken(charType, text);
							flag = false;
							flag2 = false;
							text = "";
							charType = CharType.CT_UNDEF;
							this.m_alTokens.Add(new Token(enumerator.Current, CharType.CT_DELIM));
						}
						else
						{
							text += Conversions.ToString(enumerator.Current);
						}
					}
					else
					{
						if (text.Length > 0)
						{
							this.CheckToken(charType, text);
						}
						text = "";
						charType = CharType.CT_UNDEF;
						this.m_alTokens.Add(new Token(enumerator.Current, CharType.CT_DELIM));
					}
				}
				else if (Parser.m_sNumbers.IndexOf(enumerator.Current) > -1)
				{
					if (charType == CharType.CT_STRING)
					{
						if (flag2)
						{
							string message = "字符串格式有问题";
							throw new ApplicationException(message);
						}
						text += Conversions.ToString(enumerator.Current);
					}
					else if (text.Length == 0 & charType == CharType.CT_UNDEF)
					{
						charType = CharType.CT_NUMBER;
						text += Conversions.ToString(enumerator.Current);
					}
					else if (charType == CharType.CT_NUMBER)
					{
						text += Conversions.ToString(enumerator.Current);
					}
					else
					{
						if (charType != CharType.CT_LETTER)
						{
							string message2 = "数值格式有问题";
							throw new ApplicationException(message2);
						}
						text += Conversions.ToString(enumerator.Current);
					}
				}
				else if (Parser.m_sLetters.IndexOf(enumerator.Current) > -1)
				{
					if (charType == CharType.CT_STRING)
					{
						if (flag2)
						{
							string message3 = "字符串格式有问题";
							throw new ApplicationException(message3);
						}
						text += Conversions.ToString(enumerator.Current);
					}
					else if (text.Length == 0 & charType == CharType.CT_UNDEF)
					{
						charType = CharType.CT_LETTER;
						text += Conversions.ToString(enumerator.Current);
					}
					else
					{
						if (charType != CharType.CT_LETTER)
						{
							string message4 = "字符格式有问题";
							throw new ApplicationException(message4);
						}
						text += Conversions.ToString(enumerator.Current);
					}
				}
				else
				{
					if (charType != CharType.CT_STRING)
					{
						string message5 = "公式格式有问题";
						throw new ApplicationException(message5);
					}
					if (flag2)
					{
						string message6 = "字符串格式有问题";
						throw new ApplicationException(message6);
					}
					text += Conversions.ToString(enumerator.Current);
				}
			}
			if (charType == CharType.CT_STRING)
			{
				if (flag2)
				{
					this.CheckToken(charType, text);
				}
			}
			else if (text.Length > 0)
			{
				this.CheckToken(charType, text);
			}
			this.CheckMultiCharOps();
		}

		private void CheckToken(CharType chType, string sToken)
		{
			if (chType == CharType.CT_NUMBER)
			{
				if (!Versioned.IsNumeric(sToken))
				{
					string message = "数值格式有问题";
					throw new ApplicationException(message);
				}
				this.m_alTokens.Add(new Token(sToken, CharType.CT_NUMBER));
			}
			else if (chType == CharType.CT_STRING)
			{
				this.m_alTokens.Add(new Token(sToken, CharType.CT_STRING));
			}
			else if (chType == CharType.CT_LETTER)
			{
				if (Operators.CompareString(Strings.LCase(sToken), "true", false) == 0 | Operators.CompareString(Strings.LCase(sToken), "false", false) == 0)
				{
					this.m_alTokens.Add(new Token(Strings.LCase(sToken), CharType.CT_BOOL));
				}
				else
				{
					this.m_alTokens.Add(new Token(sToken, CharType.CT_LETTER));
				}
			}
		}

		private void CheckMultiCharOps()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator tokenEnumerator = this.GetTokenEnumerator();
			Token token = null;
			Token token2 = null;
			if (tokenEnumerator.MoveNext())
			{
				token = (Token)tokenEnumerator.Current;
			}
			if (tokenEnumerator.MoveNext())
			{
				token2 = (Token)tokenEnumerator.Current;
			}
			while (token != null)
			{
				if (token.TokenType == CharType.CT_DELIM && token2 != null && token2.TokenType == CharType.CT_DELIM)
				{
					string text = token.ToString() + token2.ToString();
					if (Operators.CompareString(text, "&&", false) == 0 | Operators.CompareString(text, "||", false) == 0 | Operators.CompareString(text, "<=", false) == 0 | Operators.CompareString(text, ">=", false) == 0 | Operators.CompareString(text, "!=", false) == 0 | Operators.CompareString(text, "<>", false) == 0 | Operators.CompareString(text, "==", false) == 0)
					{
						token = new Token(text, CharType.CT_DELIM);
						if (tokenEnumerator.MoveNext())
						{
							token2 = (Token)tokenEnumerator.Current;
						}
					}
				}
				arrayList.Add(token);
				token = token2;
				if (token2 != null)
				{
					if (tokenEnumerator.MoveNext())
					{
						token2 = (Token)tokenEnumerator.Current;
					}
					else
					{
						token2 = null;
					}
				}
				else
				{
					token = null;
				}
			}
			this.m_alTokens = arrayList;
		}
	}
}
