using System;
using System.Collections;

namespace dhcc.epr.eprlib.previewmanage
{
	public class OptionValues
	{
		private static Hashtable m_KeyValues;

		public static void AddKeyValue(string key, string strValue)
		{
			if (OptionValues.m_KeyValues == null)
			{
				OptionValues.m_KeyValues = new Hashtable();
			}
			if (OptionValues.m_KeyValues.ContainsKey(key))
			{
				OptionValues.m_KeyValues[key] = strValue;
				return;
			}
			OptionValues.m_KeyValues.Add(key, strValue);
		}

		public static string GetValueByKey(string key)
		{
			if (OptionValues.m_KeyValues == null)
			{
				return null;
			}
			if (OptionValues.m_KeyValues.ContainsKey(key))
			{
				return OptionValues.m_KeyValues[key].ToString();
			}
			return null;
		}
	}
}
