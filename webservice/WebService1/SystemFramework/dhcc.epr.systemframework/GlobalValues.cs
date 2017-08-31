using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace dhcc.epr.systemframework
{
	public class GlobalValues
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct PatientRecordStatus
		{
			public const string unSave = "UnSave";

			public const string save = "Save";

			public const string reference = "Reference";

			public const string commit = "Commit";

			public const string attendingDocCheck = "Attending_Doc_Check";

			public const string chiefDocCheck = "Chief_Doc_Check";

			public const string print = "Print";

			public const string archive = "Archive";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct PatientRecordAction
		{
			public const string view = "View";

			public const string save = "Save";

			public const string print = "Print";

			public const string commit = "Commit";

			public const string reference = "Reference";

			public const string switchTemplate = "Switch";

			public const string swithcGroupTemplate = "SwitchGroup";

			public const string archive = "Archive";

			public const string refreshNecessary = "refreshNecessary";

			public const string refreshUnnecessary = "refreshUnnecessary";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UserLevel
		{
			public const string residentDoctor = "Resident";

			public const string attendingDoctor = "Attending";

			public const string chiefDoctor = "Chief";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct UserType
		{
			public const string orderlyDoctor = "Orderly";

			public const string consultantDoctor = "Consultant";
		}

		private static Hashtable _KeyValues;

		public static void AddKeyValue(string key, string strValue)
		{
			if (GlobalValues._KeyValues == null)
			{
				GlobalValues._KeyValues = new Hashtable();
			}
			if (GlobalValues._KeyValues.ContainsKey(key))
			{
				GlobalValues._KeyValues[key] = strValue;
				return;
			}
			GlobalValues._KeyValues.Add(key, strValue);
		}

		public static string GetValueByKey(string key)
		{
			if (GlobalValues._KeyValues == null)
			{
				return null;
			}
			if (GlobalValues._KeyValues.ContainsKey(key))
			{
				return GlobalValues._KeyValues[key].ToString();
			}
			return null;
		}

		public static void RemoveByKey(string key)
		{
			if (GlobalValues._KeyValues != null && GlobalValues._KeyValues.ContainsKey(key))
			{
				GlobalValues._KeyValues.Remove(key);
			}
		}

		public static string ConvertActionStatusChinese(string parEnglish)
		{
			switch (parEnglish)
			{
			case "UnSave":
				return "新建";
			case "Save":
				return "保存";
			case "Reference":
				return "引用";
			case "Commit":
				return "提交";
			case "Attending_Doc_Check":
				return "主治医师审核";
			case "Chief_Doc_Check":
				return "主任医师审核";
			case "Archive":
				return "归档";
			case "Print":
				return "打印";
			case "Switch":
				return "切换模板";
			case "SwitchGroup":
				return "成组切换模板";
			}
			return string.Empty;
		}

		public static string ConvertUserLevelChinese(string parLevel)
		{
			if (parLevel != null)
			{
				if (parLevel == "Chief")
				{
					return "主任/副主任医师";
				}
				if (parLevel == "Attending")
				{
					return "主治医师";
				}
				if (parLevel == "Resident")
				{
					return "住院医师";
				}
			}
			return "未分配";
		}
	}
}
