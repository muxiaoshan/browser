// Decompiled with JetBrains decompiler
// Type: QualityService.QualityService
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using Microsoft.VisualBasic.CompilerServices;
using My;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace QualityService
{
  [WebServiceBinding(Name = "QualityServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  public class QualityService : SoapHttpClientProtocol
  {
    private SendOrPostCallback CheckTemplateOperationCompleted;
    private SendOrPostCallback GetControlTypeOperationCompleted;
    private SendOrPostCallback GetQuaExamResultOperationCompleted;
    private SendOrPostCallback GetRunTimeQualityOperationCompleted;
    private SendOrPostCallback QuaSendMsgToUserOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event CheckTemplateCompletedEventHandler CheckTemplateCompleted;

    public event GetControlTypeCompletedEventHandler GetControlTypeCompleted;

    public event GetQuaExamResultCompletedEventHandler GetQuaExamResultCompleted;

    public event GetRunTimeQualityCompletedEventHandler GetRunTimeQualityCompleted;

    public event QuaSendMsgToUserCompletedEventHandler QuaSendMsgToUserCompleted;

    public QualityService()
    {
      this.Url = MySettings.Default.WebClient_QualityService_QualityService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Quality.BOQualityService.CheckTemplate", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string CheckTemplate(string TemplateID, string EpisodeID)
    {
      return Conversions.ToString(this.Invoke("CheckTemplate", new object[2]
      {
        (object) TemplateID,
        (object) EpisodeID
      })[0]);
    }

    public void CheckTemplateAsync(string TemplateID, string EpisodeID)
    {
      this.CheckTemplateAsync(TemplateID, EpisodeID, (object) null);
    }

    public void CheckTemplateAsync(string TemplateID, string EpisodeID, object userState)
    {
      if (this.CheckTemplateOperationCompleted == null)
        this.CheckTemplateOperationCompleted = new SendOrPostCallback(this.OnCheckTemplateOperationCompleted);
      this.InvokeAsync("CheckTemplate", new object[2]
      {
        (object) TemplateID,
        (object) EpisodeID
      }, this.CheckTemplateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnCheckTemplateOperationCompleted(object arg)
    {
      if (this.CheckTemplateCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      CheckTemplateCompletedEventHandler templateCompletedEvent = this.CheckTemplateCompletedEvent;
      if (templateCompletedEvent == null)
        return;
      templateCompletedEvent((object) this, new CheckTemplateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Quality.BOQualityService.GetControlType", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetControlType(string argTemplateId, string argEventType)
    {
      return Conversions.ToString(this.Invoke("GetControlType", new object[2]
      {
        (object) argTemplateId,
        (object) argEventType
      })[0]);
    }

    public void GetControlTypeAsync(string argTemplateId, string argEventType)
    {
      this.GetControlTypeAsync(argTemplateId, argEventType, (object) null);
    }

    public void GetControlTypeAsync(string argTemplateId, string argEventType, object userState)
    {
      if (this.GetControlTypeOperationCompleted == null)
        this.GetControlTypeOperationCompleted = new SendOrPostCallback(this.OnGetControlTypeOperationCompleted);
      this.InvokeAsync("GetControlType", new object[2]
      {
        (object) argTemplateId,
        (object) argEventType
      }, this.GetControlTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetControlTypeOperationCompleted(object arg)
    {
      if (this.GetControlTypeCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetControlTypeCompletedEventHandler typeCompletedEvent = this.GetControlTypeCompletedEvent;
      if (typeCompletedEvent == null)
        return;
      typeCompletedEvent((object) this, new GetControlTypeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Quality.BOQualityService.GetQuaExamResult", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EQualityExamDataSet GetQuaExamResult(string job)
    {
      return (EQualityExamDataSet) this.Invoke("GetQuaExamResult", new object[1]
      {
        (object) job
      })[0];
    }

    public void GetQuaExamResultAsync(string job)
    {
      this.GetQuaExamResultAsync(job, (object) null);
    }

    public void GetQuaExamResultAsync(string job, object userState)
    {
      if (this.GetQuaExamResultOperationCompleted == null)
        this.GetQuaExamResultOperationCompleted = new SendOrPostCallback(this.OnGetQuaExamResultOperationCompleted);
      this.InvokeAsync("GetQuaExamResult", new object[1]
      {
        (object) job
      }, this.GetQuaExamResultOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetQuaExamResultOperationCompleted(object arg)
    {
      if (this.GetQuaExamResultCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetQuaExamResultCompletedEventHandler resultCompletedEvent = this.GetQuaExamResultCompletedEvent;
      if (resultCompletedEvent == null)
        return;
      resultCompletedEvent((object) this, new GetQuaExamResultCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Quality.BOQualityService.GetRunTimeQuality", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetRunTimeQuality(string argEpisodeID, string argEventType, string argTemplateID, string argInstanceIDs, string argPrintTemplateDocId)
    {
      return Conversions.ToString(this.Invoke("GetRunTimeQuality", new object[5]
      {
        (object) argEpisodeID,
        (object) argEventType,
        (object) argTemplateID,
        (object) argInstanceIDs,
        (object) argPrintTemplateDocId
      })[0]);
    }

    public void GetRunTimeQualityAsync(string argEpisodeID, string argEventType, string argTemplateID, string argInstanceIDs, string argPrintTemplateDocId)
    {
      this.GetRunTimeQualityAsync(argEpisodeID, argEventType, argTemplateID, argInstanceIDs, argPrintTemplateDocId, (object) null);
    }

    public void GetRunTimeQualityAsync(string argEpisodeID, string argEventType, string argTemplateID, string argInstanceIDs, string argPrintTemplateDocId, object userState)
    {
      if (this.GetRunTimeQualityOperationCompleted == null)
        this.GetRunTimeQualityOperationCompleted = new SendOrPostCallback(this.OnGetRunTimeQualityOperationCompleted);
      this.InvokeAsync("GetRunTimeQuality", new object[5]
      {
        (object) argEpisodeID,
        (object) argEventType,
        (object) argTemplateID,
        (object) argInstanceIDs,
        (object) argPrintTemplateDocId
      }, this.GetRunTimeQualityOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetRunTimeQualityOperationCompleted(object arg)
    {
      if (this.GetRunTimeQualityCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetRunTimeQualityCompletedEventHandler qualityCompletedEvent = this.GetRunTimeQualityCompletedEvent;
      if (qualityCompletedEvent == null)
        return;
      qualityCompletedEvent((object) this, new GetRunTimeQualityCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Quality.BOQualityService.QuaSendMsgToUser", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string QuaSendMsgToUser(string strMsg, string UserDr)
    {
      return Conversions.ToString(this.Invoke("QuaSendMsgToUser", new object[2]
      {
        (object) strMsg,
        (object) UserDr
      })[0]);
    }

    public void QuaSendMsgToUserAsync(string strMsg, string UserDr)
    {
      this.QuaSendMsgToUserAsync(strMsg, UserDr, (object) null);
    }

    public void QuaSendMsgToUserAsync(string strMsg, string UserDr, object userState)
    {
      if (this.QuaSendMsgToUserOperationCompleted == null)
        this.QuaSendMsgToUserOperationCompleted = new SendOrPostCallback(this.OnQuaSendMsgToUserOperationCompleted);
      this.InvokeAsync("QuaSendMsgToUser", new object[2]
      {
        (object) strMsg,
        (object) UserDr
      }, this.QuaSendMsgToUserOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnQuaSendMsgToUserOperationCompleted(object arg)
    {
      if (this.QuaSendMsgToUserCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      QuaSendMsgToUserCompletedEventHandler userCompletedEvent = this.QuaSendMsgToUserCompletedEvent;
      if (userCompletedEvent == null)
        return;
      userCompletedEvent((object) this, new QuaSendMsgToUserCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    public new void CancelAsync(object userState)
    {
      base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || (object) url == (object) string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
