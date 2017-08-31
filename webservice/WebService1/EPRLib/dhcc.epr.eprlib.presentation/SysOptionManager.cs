using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SysOptionData;
using System;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation
{
	public class SysOptionManager
	{
		private static bool m_IsOptionInitialized = false;

		[DebuggerNonUserCode]
		public SysOptionManager()
		{
		}

		public static string GetSysOptionValue(string parSysOptionKey, string parDefaultValue)
		{
			string key = "SysOption-" + parSysOptionKey;
			string text = GlobalValues.GetValueByKey(key);
			if (text == null)
			{
				string text2;
				try
				{
					text2 = WebServiceLayer.SysOptionAccess.GetValueByName(parSysOptionKey);
				}
				catch (Exception expr_24)
				{
					ProjectData.SetProjectError(expr_24);
					Exception ex = expr_24;
					Interaction.MsgBox("读取系统参数 " + parSysOptionKey + " 时失败！  " + ex.Message, MsgBoxStyle.OkOnly, null);
					text2 = parDefaultValue;
					ProjectData.ClearProjectError();
				}
				if (text2 == null)
				{
					text2 = parDefaultValue;
				}
				text = text2;
				GlobalValues.AddKeyValue(key, text);
			}
			return text;
		}

		public static string GetSysOptionValue(string parSysOptionKey, string parDefaultValue, bool parReGet)
		{
			string key = "SysOption-" + parSysOptionKey;
			string text = GlobalValues.GetValueByKey(key);
			if (text != null)
			{
				if (!parReGet)
				{
					return text;
				}
			}
			string text2;
			try
			{
				text2 = WebServiceLayer.SysOptionAccess.GetValueByName(parSysOptionKey);
			}
			catch (Exception expr_27)
			{
				ProjectData.SetProjectError(expr_27);
				Exception ex = expr_27;
				throw new Exception("读取系统参数 " + parSysOptionKey + " 时失败！  " + ex.Message);
			}
			if (text2 == null)
			{
				text2 = parDefaultValue;
			}
			text = text2;
			GlobalValues.AddKeyValue(key, text);
			return text;
		}

		public static void InitBasicSysOption()
		{
			if (SysOptionManager.m_IsOptionInitialized)
			{
				return;
			}
			ESysOptionDataset eSysOptionDataset;
			try
			{
				eSysOptionDataset = WebServiceLayer.SysOptionAccess.SelectAllSysOption();
			}
			catch (Exception expr_15)
			{
				ProjectData.SetProjectError(expr_15);
				Exception ex = expr_15;
				throw new AppException("获取系统参数信息失败。\n" + ex.Message + "\n" + ex.StackTrace);
			}
			string columnName = eSysOptionDataset.SELECTALL.NameColumn.ColumnName;
			string columnName2 = eSysOptionDataset.SELECTALL.OptionValueColumn.ColumnName;
			int arg_78_0 = 1;
			checked
			{
				int num = eSysOptionDataset.SELECTALL.Rows.Count - 1;
				for (int i = arg_78_0; i <= num; i++)
				{
					string str = eSysOptionDataset.SELECTALL.Rows[i][columnName].ToString();
					string strValue = eSysOptionDataset.SELECTALL.Rows[i][columnName2].ToString();
					string key = "SysOption-" + str;
					if (GlobalValues.GetValueByKey(key) == null)
					{
						GlobalValues.AddKeyValue(key, strValue);
					}
				}
				SysOptionManager.m_IsOptionInitialized = true;
			}
		}
	}
}
