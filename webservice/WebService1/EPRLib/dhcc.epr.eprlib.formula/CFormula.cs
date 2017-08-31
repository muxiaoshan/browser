using dhcc.epr.eprlib.instancedata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

namespace dhcc.epr.eprlib.formula
{
	public class CFormula
	{
		private string m_sEquation;

		private CValue m_Function;

		private Token m_prevToken;

		private Token m_currentToken;

		private Token m_nextToken;

		private IEnumerator m_enumTokens;

		private SortedList m_slFunctions;

		private SortedList m_slOperations;

		private NInstanceData m_NInstanceData;

		private string m_ResultCode;

		private CVariable m_ResultCVariable;

		private Hashtable m_NIHashTable;

		public string StrFormula
		{
			get
			{
				return this.m_sEquation;
			}
			set
			{
				this.m_sEquation = value;
			}
		}

		public string ResultCode
		{
			get
			{
				return this.m_ResultCode;
			}
			set
			{
				this.m_ResultCode = value;
			}
		}

		public string ResultType
		{
			get
			{
				if (this.m_ResultCVariable == null)
				{
					return string.Empty;
				}
				return this.m_ResultCVariable.ItemVType;
			}
		}

		public Hashtable NIHashTable
		{
			get
			{
				return this.m_NIHashTable;
			}
			set
			{
				this.m_NIHashTable = value;
			}
		}

		public CFormula(string strFunction, NInstanceData objNInstanceData)
		{
			this.m_slFunctions = new SortedList();
			this.m_slOperations = new SortedList();
			this.Init(strFunction, objNInstanceData);
		}

		public void Init(string strFunction, NInstanceData objNInstanceData)
		{
			this.m_sEquation = strFunction;
			this.m_slFunctions = CFuncLib.GetFuncList();
			this.m_slOperations = COperatorLib.GetOperatorList();
			this.m_NInstanceData = objNInstanceData;
			this.m_NIHashTable = new Hashtable();
		}

		public void Compile()
		{
			this.m_currentToken = null;
			this.m_prevToken = null;
			this.m_nextToken = null;
			this.m_NIHashTable.Clear();
			Parser parser = new Parser(this.m_sEquation);
			this.m_enumTokens = parser.GetTokenEnumerator();
			this.PositionNextToken();
			this.m_Function = this.Asignment();
		}

		private bool IsBracketFunc()
		{
			return this.m_prevToken != null && this.m_prevToken.TokenType == CharType.CT_DELIM && this.m_currentToken != null && this.m_currentToken.TokenType == CharType.CT_DELIM;
		}

		private void PositionNextToken()
		{
			if (this.m_currentToken == null)
			{
				if (!this.m_enumTokens.MoveNext())
				{
					throw new ApplicationException("无效的公式");
				}
				this.m_nextToken = (Token)this.m_enumTokens.Current;
			}
			this.m_prevToken = this.m_currentToken;
			this.m_currentToken = this.m_nextToken;
			if (!this.m_enumTokens.MoveNext())
			{
				this.m_nextToken = new Token();
			}
			else
			{
				this.m_nextToken = (Token)this.m_enumTokens.Current;
			}
		}

		private CValue Asignment()
		{
			CValue cValue = this.Logical();
			if (this.m_currentToken.Equals("="))
			{
				if (!(cValue is CVariable))
				{
					throw new ApplicationException("等于号左边必须为实例变量！");
				}
				CVariable cVariable = (CVariable)cValue;
				this.m_ResultCode = cVariable.ItemCode;
				this.m_ResultCVariable = cVariable;
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.Logical();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue Logical()
		{
			CValue cValue = this.Relational();
			while (this.m_currentToken.Equals("&&") | this.m_currentToken.Equals("||"))
			{
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.Relational();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue Relational()
		{
			CValue cValue = this.AddSub();
			while (this.m_currentToken.Equals("==") | this.m_currentToken.Equals("<") | this.m_currentToken.Equals(">") | this.m_currentToken.Equals("<=") | this.m_currentToken.Equals(">=") | this.m_currentToken.Equals("<>"))
			{
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.AddSub();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue AddSub()
		{
			CValue cValue = this.MultDiv();
			while (this.m_currentToken.Equals("+") | this.m_currentToken.Equals("-"))
			{
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.MultDiv();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue MultDiv()
		{
			CValue cValue = this.Power();
			while (this.m_currentToken.Equals("*") | this.m_currentToken.Equals("/"))
			{
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.Power();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue Power()
		{
			CValue cValue = this.Sign();
			while (this.m_currentToken.Equals("^"))
			{
				Token currentToken = this.m_currentToken;
				this.PositionNextToken();
				CValue cValue2 = this.Sign();
				this.CheckParms(currentToken, cValue, cValue2);
				cValue = this.OpFactory(currentToken, cValue, cValue2);
			}
			return cValue;
		}

		private CValue Bracket()
		{
			CValue result = this.Sign();
			while (this.m_currentToken.Equals("(") || this.m_currentToken.Equals(")"))
			{
			}
			return result;
		}

		private CValue Sign()
		{
			bool flag = false;
			Token oToken = null;
			if (this.m_currentToken.Equals("+") | this.m_currentToken.Equals("-"))
			{
				oToken = this.m_currentToken;
				flag = this.m_currentToken.Equals("-");
				this.PositionNextToken();
			}
			CValue cValue = this.Paren();
			if (flag)
			{
				this.CheckParms(oToken, cValue);
				cValue = new CSignNeg(cValue);
			}
			return cValue;
		}

		private CValue Paren()
		{
			bool flag = false;
			CValue cValue = null;
			if (this.IsBracketFunc())
			{
				int index = this.m_slFunctions.IndexOfKey("bracket");
				CFunction cFunction = (CFunction)this.m_slFunctions.GetByIndex(index);
				ArrayList arrayList = new ArrayList();
				do
				{
					this.PositionNextToken();
					cValue = this.Asignment();
					arrayList.Add(cValue);
				}
				while (Operators.CompareString(this.m_currentToken.ToString(), ",", false) == 0);
				this.PositionNextToken();
				flag = true;
				cValue = cFunction.CreateInstance(arrayList);
			}
			else if (Operators.CompareString(this.m_currentToken.ToString(), "(", false) == 0)
			{
				this.PositionNextToken();
				cValue = this.Relational();
				if (Operators.CompareString(this.m_currentToken.ToString(), ",", false) == 0)
				{
					return cValue;
				}
				if (Operators.CompareString(this.m_currentToken.ToString(), ")", false) != 0)
				{
					throw new ApplicationException("() 不匹配！");
				}
			}
			else
			{
				switch (this.m_currentToken.TokenType)
				{
				case CharType.CT_NUMBER:
					cValue = new CConstVarialbe(ValueType.VTNumeric, this.m_currentToken.ToString());
					break;
				case CharType.CT_STRING:
					cValue = new CConstVarialbe(ValueType.VTString, this.m_currentToken.ToString());
					break;
				case CharType.CT_BOOL:
					cValue = new CConstVarialbe(ValueType.VTBoolean, this.m_currentToken.ToString());
					break;
				case CharType.CT_LETTER:
					if (Operators.CompareString(this.m_nextToken.ToString(), "(", false) == 0)
					{
						int num = this.m_slFunctions.IndexOfKey(Strings.LCase(this.m_currentToken.ToString()));
						if (num < 0)
						{
							throw new ApplicationException("函数 " + this.m_currentToken.ToString() + " 未找到");
						}
						CFunction cFunction2 = (CFunction)this.m_slFunctions.GetByIndex(num);
						ArrayList arrayList2 = new ArrayList();
						this.PositionNextToken();
						do
						{
							this.PositionNextToken();
							cValue = this.Asignment();
							arrayList2.Add(cValue);
						}
						while (Operators.CompareString(this.m_currentToken.ToString(), ",", false) == 0);
						this.PositionNextToken();
						flag = true;
						cValue = cFunction2.CreateInstance(arrayList2);
					}
					else
					{
						string[] array = this.m_currentToken.ToString().Split(new char[]
						{
							'$'
						});
						if (array.Length == 1)
						{
							string text = array[0];
							NInstanceItem nInstanceItem = this.m_NInstanceData.FindInstanceItemByCode(text);
							if (nInstanceItem == null)
							{
								throw new ApplicationException("无法找到代码为 " + text + " 的数据项");
							}
							cValue = CVariableFactory.CreateInstance(text, "T", nInstanceItem);
							if (!this.m_NIHashTable.ContainsKey(text))
							{
								this.m_NIHashTable.Add(text, nInstanceItem);
							}
						}
						else if (array.Length == 2)
						{
							string text2 = array[0];
							NInstanceItem nInstanceItem2 = this.m_NInstanceData.FindInstanceItemByCode(text2);
							string strVType = array[1];
							if (nInstanceItem2 == null)
							{
								throw new ApplicationException("无法找到代码为 " + text2 + " 的数据项");
							}
							cValue = CVariableFactory.CreateInstance(text2, strVType, nInstanceItem2);
							if (!this.m_NIHashTable.ContainsKey(text2))
							{
								this.m_NIHashTable.Add(text2, nInstanceItem2);
							}
						}
						else if (array.Length == 3)
						{
						}
					}
					break;
				}
			}
			if (!flag)
			{
				this.PositionNextToken();
			}
			return cValue;
		}

		private void CheckParms(Token oToken, CValue arg1, CValue arg2)
		{
			if (arg1 == null | arg2 == null)
			{
				throw new ApplicationException(oToken.ToString() + "关联的参数不正确");
			}
		}

		private void CheckParms(Token oToken, CValue arg1)
		{
			if (arg1 == null)
			{
				throw new ApplicationException(oToken.ToString() + "关联的参数不正确");
			}
		}

		private CValue OpFactory(Token oSourceOp, CValue oValue1, CValue oValue2)
		{
			COperator cOperator = (COperator)this.m_slOperations[oSourceOp.ToString()];
			if (cOperator == null)
			{
				throw new ApplicationException("Invalid operator in equation.");
			}
			return cOperator.Factory(oValue1, oValue2);
		}

		public string Calculate()
		{
			try
			{
				if (this.m_Function == null)
				{
					this.Compile();
				}
				return this.m_Function.GetValue();
			}
			catch (AppException expr_1C)
			{
				ProjectData.SetProjectError(expr_1C);
				AppException ex = expr_1C;
				MessageManager.ShowErrorMessage(string.Format("{0}{1}{2}", ex.ShowInfo, '\r', ex.StackTrace));
				ProjectData.ClearProjectError();
			}
			catch (Exception expr_4C)
			{
				ProjectData.SetProjectError(expr_4C);
				Exception ex2 = expr_4C;
				MessageManager.ShowErrorMessage(string.Format("{0}{1}{2}", ex2.Message, '\r', ex2.StackTrace));
				ProjectData.ClearProjectError();
			}
			return null;
		}

		public bool IsItemVType()
		{
			return this.ResultType.StartsWith("Item");
		}

		public bool IsControlVType()
		{
			return this.ResultType.StartsWith("Control");
		}

		public bool IsItemVTypeResultValid(string strResult)
		{
			return strResult.StartsWith("Item");
		}

		public bool NeedCaculate(string itemCode)
		{
			return this.NIHashTable[itemCode] != null;
		}

		public static bool IsAuditResultOK(string auditResult)
		{
			return auditResult.Equals(string.Empty) || auditResult.ToLower().Equals("true");
		}

		public static bool IsTipResultOK(string tipResult)
		{
			return tipResult.ToLower().Equals("true");
		}
	}
}
