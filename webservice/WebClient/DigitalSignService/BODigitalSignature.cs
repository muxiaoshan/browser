// Decompiled with JetBrains decompiler
// Type: DigitalSignService.BODigitalSignature
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

namespace DigitalSignService
{
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "BODigitalSignatureSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  public class BODigitalSignature : SoapHttpClientProtocol
  {
    private SendOrPostCallback GetCAServiceStatusOperationCompleted;
    private SendOrPostCallback GetContentOperationCompleted;
    private SendOrPostCallback GetContentByIDsOperationCompleted;
    private SendOrPostCallback GetInstanceIDsOperationCompleted;
    private SendOrPostCallback GetSignImageOperationCompleted;
    private SendOrPostCallback HasValidSignOperationCompleted;
    private SendOrPostCallback LoginOperationCompleted;
    private SendOrPostCallback SetSignUnvalidOperationCompleted;
    private SendOrPostCallback SignOperationCompleted;
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

    public event GetCAServiceStatusCompletedEventHandler GetCAServiceStatusCompleted;

    public event GetContentCompletedEventHandler GetContentCompleted;

    public event GetContentByIDsCompletedEventHandler GetContentByIDsCompleted;

    public event GetInstanceIDsCompletedEventHandler GetInstanceIDsCompleted;

    public event GetSignImageCompletedEventHandler GetSignImageCompleted;

    public event HasValidSignCompletedEventHandler HasValidSignCompleted;

    public event LoginCompletedEventHandler LoginCompleted;

    public event SetSignUnvalidCompletedEventHandler SetSignUnvalidCompleted;

    public event SignCompletedEventHandler SignCompleted;

    public BODigitalSignature()
    {
      this.Url = MySettings.Default.WebClient_DigitalSignService_BODigitalSignature;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.GetCAServiceStatus", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetCAServiceStatus(string CTLocID)
    {
      return Conversions.ToString(this.Invoke("GetCAServiceStatus", new object[1]
      {
        (object) CTLocID
      })[0]);
    }

    public void GetCAServiceStatusAsync(string CTLocID)
    {
      this.GetCAServiceStatusAsync(CTLocID, (object) null);
    }

    public void GetCAServiceStatusAsync(string CTLocID, object userState)
    {
      if (this.GetCAServiceStatusOperationCompleted == null)
        this.GetCAServiceStatusOperationCompleted = new SendOrPostCallback(this.OnGetCAServiceStatusOperationCompleted);
      this.InvokeAsync("GetCAServiceStatus", new object[1]
      {
        (object) CTLocID
      }, this.GetCAServiceStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCAServiceStatusOperationCompleted(object arg)
    {
      if (this.GetCAServiceStatusCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCAServiceStatusCompletedEventHandler statusCompletedEvent = this.GetCAServiceStatusCompletedEvent;
      if (statusCompletedEvent == null)
        return;
      statusCompletedEvent((object) this, new GetCAServiceStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.GetContent", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetContent(string usrID, string printDocID, string insID, string episodeID)
    {
      return Conversions.ToString(this.Invoke("GetContent", new object[4]
      {
        (object) usrID,
        (object) printDocID,
        (object) insID,
        (object) episodeID
      })[0]);
    }

    public void GetContentAsync(string usrID, string printDocID, string insID, string episodeID)
    {
      this.GetContentAsync(usrID, printDocID, insID, episodeID, (object) null);
    }

    public void GetContentAsync(string usrID, string printDocID, string insID, string episodeID, object userState)
    {
      if (this.GetContentOperationCompleted == null)
        this.GetContentOperationCompleted = new SendOrPostCallback(this.OnGetContentOperationCompleted);
      this.InvokeAsync("GetContent", new object[4]
      {
        (object) usrID,
        (object) printDocID,
        (object) insID,
        (object) episodeID
      }, this.GetContentOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetContentOperationCompleted(object arg)
    {
      if (this.GetContentCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetContentCompletedEventHandler contentCompletedEvent = this.GetContentCompletedEvent;
      if (contentCompletedEvent == null)
        return;
      contentCompletedEvent((object) this, new GetContentCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.GetContentByIDs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetContentByIDs(string IDs)
    {
      return Conversions.ToString(this.Invoke("GetContentByIDs", new object[1]
      {
        (object) IDs
      })[0]);
    }

    public void GetContentByIDsAsync(string IDs)
    {
      this.GetContentByIDsAsync(IDs, (object) null);
    }

    public void GetContentByIDsAsync(string IDs, object userState)
    {
      if (this.GetContentByIDsOperationCompleted == null)
        this.GetContentByIDsOperationCompleted = new SendOrPostCallback(this.OnGetContentByIDsOperationCompleted);
      this.InvokeAsync("GetContentByIDs", new object[1]
      {
        (object) IDs
      }, this.GetContentByIDsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetContentByIDsOperationCompleted(object arg)
    {
      if (this.GetContentByIDsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetContentByIDsCompletedEventHandler idsCompletedEvent = this.GetContentByIDsCompletedEvent;
      if (idsCompletedEvent == null)
        return;
      idsCompletedEvent((object) this, new GetContentByIDsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.GetInstanceIDs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetInstanceIDs(string usrID, string printDocID, string episodeID)
    {
      return Conversions.ToString(this.Invoke("GetInstanceIDs", new object[3]
      {
        (object) usrID,
        (object) printDocID,
        (object) episodeID
      })[0]);
    }

    public void GetInstanceIDsAsync(string usrID, string printDocID, string episodeID)
    {
      this.GetInstanceIDsAsync(usrID, printDocID, episodeID, (object) null);
    }

    public void GetInstanceIDsAsync(string usrID, string printDocID, string episodeID, object userState)
    {
      if (this.GetInstanceIDsOperationCompleted == null)
        this.GetInstanceIDsOperationCompleted = new SendOrPostCallback(this.OnGetInstanceIDsOperationCompleted);
      this.InvokeAsync("GetInstanceIDs", new object[3]
      {
        (object) usrID,
        (object) printDocID,
        (object) episodeID
      }, this.GetInstanceIDsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetInstanceIDsOperationCompleted(object arg)
    {
      if (this.GetInstanceIDsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetInstanceIDsCompletedEventHandler idsCompletedEvent = this.GetInstanceIDsCompletedEvent;
      if (idsCompletedEvent == null)
        return;
      idsCompletedEvent((object) this, new GetInstanceIDsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.GetSignImage", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetSignImage(string episodeID, string printDocID, string instanceID, string printType)
    {
      return Conversions.ToString(this.Invoke("GetSignImage", new object[4]
      {
        (object) episodeID,
        (object) printDocID,
        (object) instanceID,
        (object) printType
      })[0]);
    }

    public void GetSignImageAsync(string episodeID, string printDocID, string instanceID, string printType)
    {
      this.GetSignImageAsync(episodeID, printDocID, instanceID, printType, (object) null);
    }

    public void GetSignImageAsync(string episodeID, string printDocID, string instanceID, string printType, object userState)
    {
      if (this.GetSignImageOperationCompleted == null)
        this.GetSignImageOperationCompleted = new SendOrPostCallback(this.OnGetSignImageOperationCompleted);
      this.InvokeAsync("GetSignImage", new object[4]
      {
        (object) episodeID,
        (object) printDocID,
        (object) instanceID,
        (object) printType
      }, this.GetSignImageOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetSignImageOperationCompleted(object arg)
    {
      if (this.GetSignImageCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetSignImageCompletedEventHandler imageCompletedEvent = this.GetSignImageCompletedEvent;
      if (imageCompletedEvent == null)
        return;
      imageCompletedEvent((object) this, new GetSignImageCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.HasValidSign", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string HasValidSign(string episodeID, string printDocID, string eprNum)
    {
      return Conversions.ToString(this.Invoke("HasValidSign", new object[3]
      {
        (object) episodeID,
        (object) printDocID,
        (object) eprNum
      })[0]);
    }

    public void HasValidSignAsync(string episodeID, string printDocID, string eprNum)
    {
      this.HasValidSignAsync(episodeID, printDocID, eprNum, (object) null);
    }

    public void HasValidSignAsync(string episodeID, string printDocID, string eprNum, object userState)
    {
      if (this.HasValidSignOperationCompleted == null)
        this.HasValidSignOperationCompleted = new SendOrPostCallback(this.OnHasValidSignOperationCompleted);
      this.InvokeAsync("HasValidSign", new object[3]
      {
        (object) episodeID,
        (object) printDocID,
        (object) eprNum
      }, this.HasValidSignOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnHasValidSignOperationCompleted(object arg)
    {
      if (this.HasValidSignCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      HasValidSignCompletedEventHandler signCompletedEvent = this.HasValidSignCompletedEvent;
      if (signCompletedEvent == null)
        return;
      signCompletedEvent((object) this, new HasValidSignCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.Login", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Login(string usrID, string certificateID, string userCert, string serverRan, string userSignedData)
    {
      return Conversions.ToString(this.Invoke("Login", new object[5]
      {
        (object) usrID,
        (object) certificateID,
        (object) userCert,
        (object) serverRan,
        (object) userSignedData
      })[0]);
    }

    public void LoginAsync(string usrID, string certificateID, string userCert, string serverRan, string userSignedData)
    {
      this.LoginAsync(usrID, certificateID, userCert, serverRan, userSignedData, (object) null);
    }

    public void LoginAsync(string usrID, string certificateID, string userCert, string serverRan, string userSignedData, object userState)
    {
      if (this.LoginOperationCompleted == null)
        this.LoginOperationCompleted = new SendOrPostCallback(this.OnLoginOperationCompleted);
      this.InvokeAsync("Login", new object[5]
      {
        (object) usrID,
        (object) certificateID,
        (object) userCert,
        (object) serverRan,
        (object) userSignedData
      }, this.LoginOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnLoginOperationCompleted(object arg)
    {
      if (this.LoginCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      LoginCompletedEventHandler loginCompletedEvent = this.LoginCompletedEvent;
      if (loginCompletedEvent == null)
        return;
      loginCompletedEvent((object) this, new LoginCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.SetSignUnvalid", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public void SetSignUnvalid(string signLogID)
    {
      this.Invoke("SetSignUnvalid", new object[1]
      {
        (object) signLogID
      });
    }

    public void SetSignUnvalidAsync(string signLogID)
    {
      this.SetSignUnvalidAsync(signLogID, (object) null);
    }

    public void SetSignUnvalidAsync(string signLogID, object userState)
    {
      if (this.SetSignUnvalidOperationCompleted == null)
        this.SetSignUnvalidOperationCompleted = new SendOrPostCallback(this.OnSetSignUnvalidOperationCompleted);
      this.InvokeAsync("SetSignUnvalid", new object[1]
      {
        (object) signLogID
      }, this.SetSignUnvalidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSetSignUnvalidOperationCompleted(object arg)
    {
      if (this.SetSignUnvalidCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SetSignUnvalidCompletedEventHandler unvalidCompletedEvent = this.SetSignUnvalidCompletedEvent;
      if (unvalidCompletedEvent == null)
        return;
      unvalidCompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODigitalSignature.Sign", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Sign(string signValue, string episodeID, string printDocID, string eprNum, string insIDs, string contentHash, string usrID)
    {
      return Conversions.ToString(this.Invoke("Sign", new object[7]
      {
        (object) signValue,
        (object) episodeID,
        (object) printDocID,
        (object) eprNum,
        (object) insIDs,
        (object) contentHash,
        (object) usrID
      })[0]);
    }

    public void SignAsync(string signValue, string episodeID, string printDocID, string eprNum, string insIDs, string contentHash, string usrID)
    {
      this.SignAsync(signValue, episodeID, printDocID, eprNum, insIDs, contentHash, usrID, (object) null);
    }

    public void SignAsync(string signValue, string episodeID, string printDocID, string eprNum, string insIDs, string contentHash, string usrID, object userState)
    {
      if (this.SignOperationCompleted == null)
        this.SignOperationCompleted = new SendOrPostCallback(this.OnSignOperationCompleted);
      this.InvokeAsync("Sign", new object[7]
      {
        (object) signValue,
        (object) episodeID,
        (object) printDocID,
        (object) eprNum,
        (object) insIDs,
        (object) contentHash,
        (object) usrID
      }, this.SignOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSignOperationCompleted(object arg)
    {
      if (this.SignCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SignCompletedEventHandler signCompletedEvent = this.SignCompletedEvent;
      if (signCompletedEvent == null)
        return;
      signCompletedEvent((object) this, new SignCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
