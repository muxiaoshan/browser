using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation
{
	public class StringCompare
	{
		[DebuggerNonUserCode]
		public StringCompare()
		{
		}

		public static object Equal(string value1, string value2)
		{
			if (Conversions.ToBoolean(Operators.AndObject(StringCompare.IsNullOrEmptyString(value1), StringCompare.IsNullOrEmptyString(value2))))
			{
				return true;
			}
			if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.AndObject(StringCompare.IsNullOrEmptyString(value1), Operators.NotObject(StringCompare.IsNullOrEmptyString(value2)))) || Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(StringCompare.IsNullOrEmptyString(value1)), StringCompare.IsNullOrEmptyString(value2)))) ? true : false))
			{
				return false;
			}
			return Operators.CompareString(value1, value2, false) == 0;
		}

		public static object IsNullOrEmptyString(string value)
		{
			if (Operators.CompareString(value, null, false) == 0 || Operators.CompareString(value, string.Empty, false) == 0)
			{
				return true;
			}
			return false;
		}
	}
}
