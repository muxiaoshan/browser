using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.previewmanage.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOSysOption.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string PreviewManage_SysOptionData_SysOptionInfo
		{
			get
			{
				return (string)this["PreviewManage_SysOptionData_SysOptionInfo"];
			}
		}
	}
}
