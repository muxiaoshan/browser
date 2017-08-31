using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.databind
{
	public class DataOperater
	{
		[DebuggerNonUserCode]
		public DataOperater()
		{
		}

		public static ArrayList Split(string strToSplit, string strSplitor)
		{
			int num = 0;
			ArrayList arrayList = new ArrayList();
			checked
			{
				if (!(strToSplit == null | Operators.CompareString(strToSplit, "", false) == 0))
				{
					string text;
					for (int i = strToSplit.IndexOf(strSplitor, num); i > -1; i = strToSplit.IndexOf(strSplitor, num))
					{
						text = strToSplit.Substring(num, i - num);
						arrayList.Add(text);
						num = i + strSplitor.Length;
					}
					text = strToSplit.Substring(num, strToSplit.Length - num);
					if (Operators.CompareString(text, "*NULL", false) == 0)
					{
						text = "";
					}
					arrayList.Add(text);
				}
				return arrayList;
			}
		}
	}
}
