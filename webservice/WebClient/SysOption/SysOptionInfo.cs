// Decompiled with JetBrains decompiler
// Type: SysOption.SysOptionInfo
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
using System.Xml.Serialization;

namespace SysOption
{
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "SysOptionInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  public class SysOptionInfo : SoapHttpClientProtocol
  {
    private SendOrPostCallback CreateSysOptionOperationCompleted;
    private SendOrPostCallback DeleteSysOptionOperationCompleted;
    private SendOrPostCallback GetValueByNameOperationCompleted;
    private SendOrPostCallback SelectAllSysOptionOperationCompleted;
    private SendOrPostCallback UpdateSysOptionOperationCompleted;
    private SendOrPostCallback UpdateSysOptionValueOperationCompleted;
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

    public event CreateSysOptionCompletedEventHandler CreateSysOptionCompleted;

    public event DeleteSysOptionCompletedEventHandler DeleteSysOptionCompleted;

    public event GetValueByNameCompletedEventHandler GetValueByNameCompleted;

    public event SelectAllSysOptionCompletedEventHandler SelectAllSysOptionCompleted;

    public event UpdateSysOptionCompletedEventHandler UpdateSysOptionCompleted;

    public event UpdateSysOptionValueCompletedEventHandler UpdateSysOptionValueCompleted;

    public SysOptionInfo()
    {
      this.Url = MySettings.Default.WebClient_SysOption_SysOptionInfo;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.CreateSysOption", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string CreateSysOption(ESysOption ASysOption)
    {
      return Conversions.ToString(this.Invoke("CreateSysOption", new object[1]
      {
        (object) ASysOption
      })[0]);
    }

    public void CreateSysOptionAsync(ESysOption ASysOption)
    {
      this.CreateSysOptionAsync(ASysOption, (object) null);
    }

    public void CreateSysOptionAsync(ESysOption ASysOption, object userState)
    {
      if (this.CreateSysOptionOperationCompleted == null)
        this.CreateSysOptionOperationCompleted = new SendOrPostCallback(this.OnCreateSysOptionOperationCompleted);
      this.InvokeAsync("CreateSysOption", new object[1]
      {
        (object) ASysOption
      }, this.CreateSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnCreateSysOptionOperationCompleted(object arg)
    {
      if (this.CreateSysOptionCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      CreateSysOptionCompletedEventHandler optionCompletedEvent = this.CreateSysOptionCompletedEvent;
      if (optionCompletedEvent == null)
        return;
      optionCompletedEvent((object) this, new CreateSysOptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.DeleteSysOption", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public void DeleteSysOption(string AID, ref bool DeleteSysOptionResult, [XmlIgnore] ref bool DeleteSysOptionResultSpecified)
    {
      object[] objArray = this.Invoke("DeleteSysOption", new object[1]
      {
        (object) AID
      });
      DeleteSysOptionResult = Conversions.ToBoolean(objArray[0]);
      DeleteSysOptionResultSpecified = Conversions.ToBoolean(objArray[1]);
    }

    public void DeleteSysOptionAsync(string AID)
    {
      this.DeleteSysOptionAsync(AID, (object) null);
    }

    public void DeleteSysOptionAsync(string AID, object userState)
    {
      if (this.DeleteSysOptionOperationCompleted == null)
        this.DeleteSysOptionOperationCompleted = new SendOrPostCallback(this.OnDeleteSysOptionOperationCompleted);
      this.InvokeAsync("DeleteSysOption", new object[1]
      {
        (object) AID
      }, this.DeleteSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnDeleteSysOptionOperationCompleted(object arg)
    {
      if (this.DeleteSysOptionCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      DeleteSysOptionCompletedEventHandler optionCompletedEvent = this.DeleteSysOptionCompletedEvent;
      if (optionCompletedEvent == null)
        return;
      optionCompletedEvent((object) this, new DeleteSysOptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.GetValueByName", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetValueByName(string AName)
    {
      return Conversions.ToString(this.Invoke("GetValueByName", new object[1]
      {
        (object) AName
      })[0]);
    }

    public void GetValueByNameAsync(string AName)
    {
      this.GetValueByNameAsync(AName, (object) null);
    }

    public void GetValueByNameAsync(string AName, object userState)
    {
      if (this.GetValueByNameOperationCompleted == null)
        this.GetValueByNameOperationCompleted = new SendOrPostCallback(this.OnGetValueByNameOperationCompleted);
      this.InvokeAsync("GetValueByName", new object[1]
      {
        (object) AName
      }, this.GetValueByNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetValueByNameOperationCompleted(object arg)
    {
      if (this.GetValueByNameCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetValueByNameCompletedEventHandler nameCompletedEvent = this.GetValueByNameCompletedEvent;
      if (nameCompletedEvent == null)
        return;
      nameCompletedEvent((object) this, new GetValueByNameCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.SelectAllSysOption", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public ESysOptionDataset SelectAllSysOption()
    {
      return (ESysOptionDataset) this.Invoke("SelectAllSysOption", new object[0])[0];
    }

    public void SelectAllSysOptionAsync()
    {
      this.SelectAllSysOptionAsync((object) null);
    }

    public void SelectAllSysOptionAsync(object userState)
    {
      if (this.SelectAllSysOptionOperationCompleted == null)
        this.SelectAllSysOptionOperationCompleted = new SendOrPostCallback(this.OnSelectAllSysOptionOperationCompleted);
      this.InvokeAsync("SelectAllSysOption", new object[0], this.SelectAllSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSelectAllSysOptionOperationCompleted(object arg)
    {
      if (this.SelectAllSysOptionCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SelectAllSysOptionCompletedEventHandler optionCompletedEvent = this.SelectAllSysOptionCompletedEvent;
      if (optionCompletedEvent == null)
        return;
      optionCompletedEvent((object) this, new SelectAllSysOptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOption", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string UpdateSysOption(ESysOption ASysOption)
    {
      return Conversions.ToString(this.Invoke("UpdateSysOption", new object[1]
      {
        (object) ASysOption
      })[0]);
    }

    public void UpdateSysOptionAsync(ESysOption ASysOption)
    {
      this.UpdateSysOptionAsync(ASysOption, (object) null);
    }

    public void UpdateSysOptionAsync(ESysOption ASysOption, object userState)
    {
      if (this.UpdateSysOptionOperationCompleted == null)
        this.UpdateSysOptionOperationCompleted = new SendOrPostCallback(this.OnUpdateSysOptionOperationCompleted);
      this.InvokeAsync("UpdateSysOption", new object[1]
      {
        (object) ASysOption
      }, this.UpdateSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnUpdateSysOptionOperationCompleted(object arg)
    {
      if (this.UpdateSysOptionCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      UpdateSysOptionCompletedEventHandler optionCompletedEvent = this.UpdateSysOptionCompletedEvent;
      if (optionCompletedEvent == null)
        return;
      optionCompletedEvent((object) this, new UpdateSysOptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOptionValue", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string UpdateSysOptionValue(ESysOption ASysOption)
    {
      return Conversions.ToString(this.Invoke("UpdateSysOptionValue", new object[1]
      {
        (object) ASysOption
      })[0]);
    }

    public void UpdateSysOptionValueAsync(ESysOption ASysOption)
    {
      this.UpdateSysOptionValueAsync(ASysOption, (object) null);
    }

    public void UpdateSysOptionValueAsync(ESysOption ASysOption, object userState)
    {
      if (this.UpdateSysOptionValueOperationCompleted == null)
        this.UpdateSysOptionValueOperationCompleted = new SendOrPostCallback(this.OnUpdateSysOptionValueOperationCompleted);
      this.InvokeAsync("UpdateSysOptionValue", new object[1]
      {
        (object) ASysOption
      }, this.UpdateSysOptionValueOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnUpdateSysOptionValueOperationCompleted(object arg)
    {
      if (this.UpdateSysOptionValueCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      UpdateSysOptionValueCompletedEventHandler valueCompletedEvent = this.UpdateSysOptionValueCompletedEvent;
      if (valueCompletedEvent == null)
        return;
      valueCompletedEvent((object) this, new UpdateSysOptionValueCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
