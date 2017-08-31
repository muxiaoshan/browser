// Decompiled with JetBrains decompiler
// Type: BOCustomDictory.CustomDictoryInfo
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

namespace BOCustomDictory
{
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "CustomDictoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  public class CustomDictoryInfo : SoapHttpClientProtocol
  {
    private SendOrPostCallback GetAllDiagnosTypeByTitleOperationCompleted;
    private SendOrPostCallback GetTitleBYTidOperationCompleted;
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

    public event GetAllDiagnosTypeByTitleCompletedEventHandler GetAllDiagnosTypeByTitleCompleted;

    public event GetTitleBYTidCompletedEventHandler GetTitleBYTidCompleted;

    public CustomDictoryInfo()
    {
      this.Url = MySettings.Default.WebClient_BOCustomDictory_CustomDictoryInfo;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOCustomDictory.GetAllDiagnosTypeByTitle", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EDiagnosTypeByTitle GetAllDiagnosTypeByTitle()
    {
      return (EDiagnosTypeByTitle) this.Invoke("GetAllDiagnosTypeByTitle", new object[0])[0];
    }

    public void GetAllDiagnosTypeByTitleAsync()
    {
      this.GetAllDiagnosTypeByTitleAsync((object) null);
    }

    public void GetAllDiagnosTypeByTitleAsync(object userState)
    {
      if (this.GetAllDiagnosTypeByTitleOperationCompleted == null)
        this.GetAllDiagnosTypeByTitleOperationCompleted = new SendOrPostCallback(this.OnGetAllDiagnosTypeByTitleOperationCompleted);
      this.InvokeAsync("GetAllDiagnosTypeByTitle", new object[0], this.GetAllDiagnosTypeByTitleOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetAllDiagnosTypeByTitleOperationCompleted(object arg)
    {
      if (this.GetAllDiagnosTypeByTitleCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetAllDiagnosTypeByTitleCompletedEventHandler titleCompletedEvent = this.GetAllDiagnosTypeByTitleCompletedEvent;
      if (titleCompletedEvent == null)
        return;
      titleCompletedEvent((object) this, new GetAllDiagnosTypeByTitleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOCustomDictory.GetTitleBYTid", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetTitleBYTid(string TID)
    {
      return Conversions.ToString(this.Invoke("GetTitleBYTid", new object[1]
      {
        (object) TID
      })[0]);
    }

    public void GetTitleBYTidAsync(string TID)
    {
      this.GetTitleBYTidAsync(TID, (object) null);
    }

    public void GetTitleBYTidAsync(string TID, object userState)
    {
      if (this.GetTitleBYTidOperationCompleted == null)
        this.GetTitleBYTidOperationCompleted = new SendOrPostCallback(this.OnGetTitleBYTidOperationCompleted);
      this.InvokeAsync("GetTitleBYTid", new object[1]
      {
        (object) TID
      }, this.GetTitleBYTidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetTitleBYTidOperationCompleted(object arg)
    {
      if (this.GetTitleBYTidCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetTitleBYTidCompletedEventHandler tidCompletedEvent = this.GetTitleBYTidCompletedEvent;
      if (tidCompletedEvent == null)
        return;
      tidCompletedEvent((object) this, new GetTitleBYTidCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
