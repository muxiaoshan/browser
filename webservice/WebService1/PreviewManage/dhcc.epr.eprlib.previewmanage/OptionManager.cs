using System;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.previewmanage
{
	public class OptionManager
	{
		public static string GetOptionValue(string parSysOptionKey, string parDefaultValue)
		{
			string key = "SysOption-" + parSysOptionKey;
			string text = OptionValues.GetValueByKey(key);
			if (text == null)
			{
				string text2;
				try
				{
					text2 = WebServicesLayer.SysOptionAccess.GetValueByName(parSysOptionKey);
				}
				catch (Exception ex)
				{
					MessageBox.Show("读取系统参数 " + parSysOptionKey + " 时失败！  " + ex.Message);
					text2 = parDefaultValue;
				}
				if (text2 == null)
				{
					text2 = parDefaultValue;
				}
				text = text2;
				OptionValues.AddKeyValue(key, text);
			}
			return text;
		}
	}
}
