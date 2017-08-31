// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.dataaccess.WebServiceLayer
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using BOCustomDictory;
using BOPowerUser;
using dhcc.epr.systemframework;
using DigitalSignService;
using EPRTemplateCategoryData;
using GateWayData;
using InstanceData;
using Microsoft.VisualBasic.CompilerServices;
using PrivRule;
using SysOption;
using System.Diagnostics;

namespace dhcc.epr.webclient.dataaccess
{
  public class WebServiceLayer
  {
    private static InstanceDataInfo _InstanceAccess = (InstanceDataInfo) null;
    private static DataGatewayInfo _GateWayAccess = (DataGatewayInfo) null;
    private static QualityService.QualityService _QualityAccess = (QualityService.QualityService) null;
    private static PrivilegePrivRule _PrivAccess = (PrivilegePrivRule) null;
    private static SysOptionInfo _SysOptionAccess = (SysOptionInfo) null;
    private static PrivilegeBOPowerUser _PowerUserAccess = (PrivilegeBOPowerUser) null;
    private static EPRTemplateCategory _EPRTemplateCategoryAccess = (EPRTemplateCategory) null;
    private static BODigitalSignature _DigitalSignAccess = (BODigitalSignature) null;
    private static CustomDictoryInfo _CustomDictoryAccess = (CustomDictoryInfo) null;
    private static string _URL;
    private const string INSTANCESERVICE = "EPRservice.BOInstanceData.cls";
    private const string GATEWAYSERVICE = "EPRservice.BODataGateway.cls";
    private const string QualityService = "EPRservice.Quality.BOQualityService.cls";
    private const string PRIVSERVICE = "EPRservice.Privilege.BOPrivRule.cls";
    private const string SYSOPTIONSERVICE = "EPRservice.BOSysOption.cls";
    private const string POWERUSERSERVICE = "EPRservice.Privilege.BOPowerUser.cls";
    private const string EPRTEMPLATECATEGORYSERVICE = "EPRservice.BOEPRTemplateCategory.cls";
    private const string DIGITALSIGNSERVICE = "EPRservice.BODigitalSignature.cls";
    private const string CUSTOMDICTORYSERVICE = "EPRservice.BOCustomDictory.cls";

    public static string URL
    {
      get
      {
        return Configuration.get_DataServiceUrl();
      }
    }

    public static InstanceDataInfo InstanceAccess
    {
      get
      {
        if (WebServiceLayer._InstanceAccess == null)
        {
          WebServiceLayer._InstanceAccess = new InstanceDataInfo();
          if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
            WebServiceLayer._InstanceAccess.Url = WebServiceLayer.URL + "EPRservice.BOInstanceData.cls";
        }
        return WebServiceLayer._InstanceAccess;
      }
    }

    public static DataGatewayInfo GateWayAccess
    {
      get
      {
        if (WebServiceLayer._GateWayAccess == null)
        {
          WebServiceLayer._GateWayAccess = new DataGatewayInfo();
          if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
            WebServiceLayer._GateWayAccess.Url = WebServiceLayer.URL + "EPRservice.BODataGateway.cls";
        }
        return WebServiceLayer._GateWayAccess;
      }
    }

    public static QualityService.QualityService QualityAccess
    {
      get
      {
        if (WebServiceLayer._QualityAccess == null)
        {
          WebServiceLayer._QualityAccess = new QualityService.QualityService();
          if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
            WebServiceLayer._QualityAccess.Url = WebServiceLayer.URL + "EPRservice.Quality.BOQualityService.cls";
        }
        return WebServiceLayer._QualityAccess;
      }
    }

    public static PrivilegePrivRule PrivAccess
    {
      get
      {
        if (WebServiceLayer._PrivAccess == null)
        {
          WebServiceLayer._PrivAccess = new PrivilegePrivRule();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._PrivAccess.Url = WebServiceLayer.URL + "EPRservice.Privilege.BOPrivRule.cls";
        }
        return WebServiceLayer._PrivAccess;
      }
    }

    public static SysOptionInfo SysOptionAccess
    {
      get
      {
        if (WebServiceLayer._SysOptionAccess == null)
        {
          WebServiceLayer._SysOptionAccess = new SysOptionInfo();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._SysOptionAccess.Url = WebServiceLayer.URL + "EPRservice.BOSysOption.cls";
        }
        return WebServiceLayer._SysOptionAccess;
      }
    }

    public static EPRTemplateCategory EPRTemplateCategoryAccess
    {
      get
      {
        if (WebServiceLayer._EPRTemplateCategoryAccess == null)
        {
          WebServiceLayer._EPRTemplateCategoryAccess = new EPRTemplateCategory();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._EPRTemplateCategoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOEPRTemplateCategory.cls";
        }
        return WebServiceLayer._EPRTemplateCategoryAccess;
      }
    }

    public static PrivilegeBOPowerUser PowerUserAccess
    {
      get
      {
        if (WebServiceLayer._PowerUserAccess == null)
        {
          WebServiceLayer._PowerUserAccess = new PrivilegeBOPowerUser();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._PowerUserAccess.Url = WebServiceLayer.URL + "EPRservice.Privilege.BOPowerUser.cls";
        }
        return WebServiceLayer._PowerUserAccess;
      }
    }

    public static BODigitalSignature DigitalSignAccess
    {
      get
      {
        if (WebServiceLayer._DigitalSignAccess == null)
        {
          WebServiceLayer._DigitalSignAccess = new BODigitalSignature();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._DigitalSignAccess.Url = WebServiceLayer.URL + "EPRservice.BODigitalSignature.cls";
        }
        return WebServiceLayer._DigitalSignAccess;
      }
    }

    public static CustomDictoryInfo CustomDictoryAccess
    {
      get
      {
        if (WebServiceLayer._CustomDictoryAccess == null)
        {
          WebServiceLayer._CustomDictoryAccess = new CustomDictoryInfo();
          if (WebServiceLayer.URL != null && !WebServiceLayer.URL.Equals(string.Empty))
            WebServiceLayer._CustomDictoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOCustomDictory.cls";
        }
        return WebServiceLayer._CustomDictoryAccess;
      }
    }

    [DebuggerNonUserCode]
    public WebServiceLayer()
    {
    }
  }
}
