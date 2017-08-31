using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		public static MySettings Default
		{
			get
			{
				return MySettings.defaultInstance;
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOBindQueryService.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_BindQueryData_BindQueryService
		{
			get
			{
				return Conversions.ToString(this["EPRLib_BindQueryData_BindQueryService"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOEPRKbConfig.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_BOEPRKbConfigInfo_KbConfigInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_BOEPRKbConfigInfo_KbConfigInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOStdDictionary.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_DictionaryData_StdDictionaryService
		{
			get
			{
				return Conversions.ToString(this["EPRLib_DictionaryData_StdDictionaryService"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BODataGateway.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_GateWayDataInfo_DataGatewayInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_GateWayDataInfo_DataGatewayInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOGlossaryCategory.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_GlossaryCategoryData_GlossaryCategoryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_GlossaryCategoryData_GlossaryCategoryInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOGlossary.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_GlossaryData_GlossaryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_GlossaryData_GlossaryInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOImagePosition.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ImagePosData_ImagePositionInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ImagePosData_ImagePositionInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://127.0.0.1/trakcarelive/trak/web/EPRservice.BOInstanceData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_InstanceDataInfo_InstanceDataInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_InstanceDataInfo_InstanceDataInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOTemplate.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_InterfaceTemplateData_TemplateInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_InterfaceTemplateData_TemplateInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOTemplateCategory.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ITCategoryData_TemplateCategoryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ITCategoryData_TemplateCategoryInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://127.0.0.1/trakcarelive/trak/web/EPRservice.BOKBCategory.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KBCategoryData_KBCategoryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KBCategoryData_KBCategoryInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOKnowledgeBase.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KnowledgeBaseData_KnowledgeBaseInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KnowledgeBaseData_KnowledgeBaseInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOLISData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_LISData_LISDataInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_LISData_LISDataInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOSysOption.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_SysOptionData_SysOptionInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_SysOptionData_SysOptionInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOUnitService.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_UnitData_UnitService
		{
			get
			{
				return Conversions.ToString(this["EPRLib_UnitData_UnitService"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://127.0.0.1/trakcarelive/trak/web/EPRservice.BOHISData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_HISData_HISDataService
		{
			get
			{
				return Conversions.ToString(this["EPRLib_HISData_HISDataService"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://192.168.1.53/DTHealth/web/EPRservice.BOOrderData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_OrderData_OrderDataService
		{
			get
			{
				return Conversions.ToString(this["EPRLib_OrderData_OrderDataService"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://127.0.0.1/trakcarelive/trak/web/EPRservice.BOGlossaryItem.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_GlossaryItemData_GlossaryItemInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_GlossaryItemData_GlossaryItemInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOEPRDiagnosConfig.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_BOEPRDiagnosConfig_DiagnosConfig
		{
			get
			{
				return Conversions.ToString(this["EPRLib_BOEPRDiagnosConfig_DiagnosConfig"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOKBDiagnos.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KBDiagnos_KBDiagnos
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KBDiagnos_KBDiagnos"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOImageLib.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ImageLibData_ImageLibInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ImageLibData_ImageLibInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOAdmImageItem.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_AdmImageItemData_AdmImageItemInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_AdmImageItemData_AdmImageItemInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOImageItem.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ImageItemData_ImageItemInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ImageItemData_ImageItemInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOImageTree.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ImageTreeData_ImageTreeInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ImageTreeData_ImageTreeInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOImageCategory.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_ImageCategoryData_ImageCategoryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_ImageCategoryData_ImageCategoryInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.TemplatePriv.BORuleType.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_TPrivRuleType_TemplatePriv_BORuleType
		{
			get
			{
				return Conversions.ToString(this["EPRLib_TPrivRuleType_TemplatePriv_BORuleType"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOKBNodeDiagnosRule.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KBNodeDiagnosRule_KBNodeDiagnosRuleInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KBNodeDiagnosRule_KBNodeDiagnosRuleInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOPACSData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_PACSData_PACSDataInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_PACSData_PACSDataInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://192.168.1.68/trakcarelive/trak/web/EPRservice.BOSystemService.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_SystemServiceData_SystemInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_SystemServiceData_SystemInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://172.21.21.32/trakcarelive/trak/web/EPRservice.BOKBNode.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KBNodeData_KBNodeInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KBNodeData_KBNodeInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://192.168.1.31/trakcarelive/trak/web/EPRservice.BOMRDiagnosData.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_MRDiagnosData_MRDiagnosDataInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_MRDiagnosData_MRDiagnosDataInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://192.168.1.31/trakcarelive/trak/web/EPRservice.BOKBTree.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_KBTreeData_KBTreeInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_KBTreeData_KBTreeInfo"]);
			}
		}

		[ApplicationScopedSetting, DefaultSettingValue("http://192.168.1.31/trakcarelive/trak/web/EPRservice.BOCustomDictory.cls"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string EPRLib_CustomDictoryData_CustomDictoryInfo
		{
			get
			{
				return Conversions.ToString(this["EPRLib_CustomDictoryData_CustomDictoryInfo"]);
			}
		}

		[DebuggerNonUserCode]
		public MySettings()
		{
		}
	}
}
