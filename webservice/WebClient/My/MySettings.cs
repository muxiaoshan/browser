// Decompiled with JetBrains decompiler
// Type: My.MySettings
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        return MySettings.defaultInstance;
      }
    }

    [ApplicationScopedSetting]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.Privilege.BOPowerUser.cls")]
    public string WebClient_BOPowerUser_Privilege_BOPowerUser
    {
      get
      {
        return Conversions.ToString(this["WebClient_BOPowerUser_Privilege_BOPowerUser"]);
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BODataGateway.cls")]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [ApplicationScopedSetting]
    public string WebClient_GateWayData_DataGatewayInfo
    {
      get
      {
        return Conversions.ToString(this["WebClient_GateWayData_DataGatewayInfo"]);
      }
    }

    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOInstanceData.cls")]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public string WebClient_InstanceData_InstanceDataInfo
    {
      get
      {
        return Conversions.ToString(this["WebClient_InstanceData_InstanceDataInfo"]);
      }
    }

    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.Privilege.BOPrivRule.cls")]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public string WebClient_PrivRule_Privilege_PrivRule
    {
      get
      {
        return Conversions.ToString(this["WebClient_PrivRule_Privilege_PrivRule"]);
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.Quality.BOQualityService.cls")]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [ApplicationScopedSetting]
    public string WebClient_QualityService_QualityService
    {
      get
      {
        return Conversions.ToString(this["WebClient_QualityService_QualityService"]);
      }
    }

    [DefaultSettingValue("http://172.21.21.31/trakcarelive/trak/web/EPRservice.BOSysOption.cls")]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    public string WebClient_SysOption_SysOptionInfo
    {
      get
      {
        return Conversions.ToString(this["WebClient_SysOption_SysOptionInfo"]);
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("http://172.21.21.31/TrakCareLive/trak/web/EPRservice.BOEPRTemplateCategory.cls")]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    public string WebClient_EPRTemplateCategoryData_EPRTemplateCategory
    {
      get
      {
        return Conversions.ToString(this["WebClient_EPRTemplateCategoryData_EPRTemplateCategory"]);
      }
    }

    [DefaultSettingValue("http://127.0.0.1/dthealth/web/EPRservice.BODigitalSignature.cls")]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public string WebClient_DigitalSignService_BODigitalSignature
    {
      get
      {
        return Conversions.ToString(this["WebClient_DigitalSignService_BODigitalSignature"]);
      }
    }

    [DefaultSettingValue("http://192.168.1.31/trakcarelive/trak/web/EPRservice.BOCustomDictory.cls")]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [ApplicationScopedSetting]
    public string WebClient_BOCustomDictory_CustomDictoryInfo
    {
      get
      {
        return Conversions.ToString(this["WebClient_BOCustomDictory_CustomDictoryInfo"]);
      }
    }

    [DebuggerNonUserCode]
    public MySettings()
    {
    }
  }
}
