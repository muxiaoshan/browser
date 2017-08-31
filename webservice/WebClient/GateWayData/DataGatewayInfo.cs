// Decompiled with JetBrains decompiler
// Type: GateWayData.DataGatewayInfo
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using Microsoft.VisualBasic.CompilerServices;
using My;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace GateWayData
{
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "DataGatewayInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  public class DataGatewayInfo : SoapHttpClientProtocol
  {
    private SendOrPostCallback DBInterFaceOperationCompleted;
    private SendOrPostCallback DBInterFaceByStreamOperationCompleted;
    private SendOrPostCallback GetDataByQueryNameOperationCompleted;
    private SendOrPostCallback GetParameterStringOperationCompleted;
    private SendOrPostCallback TestQueryOperationCompleted;
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

    public event DBInterFaceCompletedEventHandler DBInterFaceCompleted;

    public event DBInterFaceByStreamCompletedEventHandler DBInterFaceByStreamCompleted;

    public event GetDataByQueryNameCompletedEventHandler GetDataByQueryNameCompleted;

    public event GetParameterStringCompletedEventHandler GetParameterStringCompleted;

    public event TestQueryCompletedEventHandler TestQueryCompleted;

    public DataGatewayInfo()
    {
      this.Url = MySettings.Default.WebClient_GateWayData_DataGatewayInfo;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.DBInterFace", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string DBInterFace(string AReciveString)
    {
      return Conversions.ToString(this.Invoke("DBInterFace", new object[1]
      {
        (object) AReciveString
      })[0]);
    }

    public void DBInterFaceAsync(string AReciveString)
    {
      this.DBInterFaceAsync(AReciveString, (object) null);
    }

    public void DBInterFaceAsync(string AReciveString, object userState)
    {
      if (this.DBInterFaceOperationCompleted == null)
        this.DBInterFaceOperationCompleted = new SendOrPostCallback(this.OnDBInterFaceOperationCompleted);
      this.InvokeAsync("DBInterFace", new object[1]
      {
        (object) AReciveString
      }, this.DBInterFaceOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnDBInterFaceOperationCompleted(object arg)
    {
      if (this.DBInterFaceCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      DBInterFaceCompletedEventHandler faceCompletedEvent = this.DBInterFaceCompletedEvent;
      if (faceCompletedEvent == null)
        return;
      faceCompletedEvent((object) this, new DBInterFaceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.DBInterFaceByStream", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public ReStreamData DBInterFaceByStream(string AReciveString)
    {
      return (ReStreamData) this.Invoke("DBInterFaceByStream", new object[1]
      {
        (object) AReciveString
      })[0];
    }

    public void DBInterFaceByStreamAsync(string AReciveString)
    {
      this.DBInterFaceByStreamAsync(AReciveString, (object) null);
    }

    public void DBInterFaceByStreamAsync(string AReciveString, object userState)
    {
      if (this.DBInterFaceByStreamOperationCompleted == null)
        this.DBInterFaceByStreamOperationCompleted = new SendOrPostCallback(this.OnDBInterFaceByStreamOperationCompleted);
      this.InvokeAsync("DBInterFaceByStream", new object[1]
      {
        (object) AReciveString
      }, this.DBInterFaceByStreamOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnDBInterFaceByStreamOperationCompleted(object arg)
    {
      if (this.DBInterFaceByStreamCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      DBInterFaceByStreamCompletedEventHandler streamCompletedEvent = this.DBInterFaceByStreamCompletedEvent;
      if (streamCompletedEvent == null)
        return;
      streamCompletedEvent((object) this, new DBInterFaceByStreamCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.GetDataByQueryName", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public DataSet GetDataByQueryName(string AClassName, string AQueryName, string AParameterS)
    {
      return (DataSet) this.Invoke("GetDataByQueryName", new object[3]
      {
        (object) AClassName,
        (object) AQueryName,
        (object) AParameterS
      })[0];
    }

    public void GetDataByQueryNameAsync(string AClassName, string AQueryName, string AParameterS)
    {
      this.GetDataByQueryNameAsync(AClassName, AQueryName, AParameterS, (object) null);
    }

    public void GetDataByQueryNameAsync(string AClassName, string AQueryName, string AParameterS, object userState)
    {
      if (this.GetDataByQueryNameOperationCompleted == null)
        this.GetDataByQueryNameOperationCompleted = new SendOrPostCallback(this.OnGetDataByQueryNameOperationCompleted);
      this.InvokeAsync("GetDataByQueryName", new object[3]
      {
        (object) AClassName,
        (object) AQueryName,
        (object) AParameterS
      }, this.GetDataByQueryNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetDataByQueryNameOperationCompleted(object arg)
    {
      if (this.GetDataByQueryNameCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetDataByQueryNameCompletedEventHandler nameCompletedEvent = this.GetDataByQueryNameCompletedEvent;
      if (nameCompletedEvent == null)
        return;
      nameCompletedEvent((object) this, new GetDataByQueryNameCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.GetParameterString", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetParameterString(string AClassName, string AQueryName)
    {
      return Conversions.ToString(this.Invoke("GetParameterString", new object[2]
      {
        (object) AClassName,
        (object) AQueryName
      })[0]);
    }

    public void GetParameterStringAsync(string AClassName, string AQueryName)
    {
      this.GetParameterStringAsync(AClassName, AQueryName, (object) null);
    }

    public void GetParameterStringAsync(string AClassName, string AQueryName, object userState)
    {
      if (this.GetParameterStringOperationCompleted == null)
        this.GetParameterStringOperationCompleted = new SendOrPostCallback(this.OnGetParameterStringOperationCompleted);
      this.InvokeAsync("GetParameterString", new object[2]
      {
        (object) AClassName,
        (object) AQueryName
      }, this.GetParameterStringOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetParameterStringOperationCompleted(object arg)
    {
      if (this.GetParameterStringCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetParameterStringCompletedEventHandler stringCompletedEvent = this.GetParameterStringCompletedEvent;
      if (stringCompletedEvent == null)
        return;
      stringCompletedEvent((object) this, new GetParameterStringCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.TestQuery", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public DataSet TestQuery()
    {
      return (DataSet) this.Invoke("TestQuery", new object[0])[0];
    }

    public void TestQueryAsync()
    {
      this.TestQueryAsync((object) null);
    }

    public void TestQueryAsync(object userState)
    {
      if (this.TestQueryOperationCompleted == null)
        this.TestQueryOperationCompleted = new SendOrPostCallback(this.OnTestQueryOperationCompleted);
      this.InvokeAsync("TestQuery", new object[0], this.TestQueryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnTestQueryOperationCompleted(object arg)
    {
      if (this.TestQueryCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      TestQueryCompletedEventHandler queryCompletedEvent = this.TestQueryCompletedEvent;
      if (queryCompletedEvent == null)
        return;
      queryCompletedEvent((object) this, new TestQueryCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
