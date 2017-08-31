using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class Token
	{
		private string m_sToken;

		private CharType m_chType;

		public CharType TokenType
		{
			get
			{
				return this.m_chType;
			}
		}

		public override bool Equals(object sValue)
		{
			if (sValue == null)
			{
				return this.m_sToken == null;
			}
			return Operators.CompareString(Conversions.ToString(sValue), this.m_sToken, false) == 0;
		}

		public Token(string sToken, CharType chType)
		{
			this.m_sToken = sToken;
			this.m_chType = chType;
		}

		public Token()
		{
			this.m_sToken = "";
			this.m_chType = CharType.CT_UNDEF;
		}

		public Token(char chToken, CharType chType)
		{
			this.m_sToken = "";
			this.m_sToken += Conversions.ToString(chToken);
			this.m_chType = chType;
		}

		public override string ToString()
		{
			return this.m_sToken;
		}
	}
}
