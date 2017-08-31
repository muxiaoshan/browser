// Decompiled with JetBrains decompiler
// Type: PrivRule.PrivilegePrivRule
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

namespace PrivRule
{
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "Privilege.PrivRuleSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  public class PrivilegePrivRule : SoapHttpClientProtocol
  {
    private SendOrPostCallback AddOperationCompleted;
    private SendOrPostCallback DeleteOperationCompleted;
    private SendOrPostCallback GetAllPrivRuleOperationCompleted;
    private SendOrPostCallback GetAppointPrivOperationCompleted;
    private SendOrPostCallback GetByIdOperationCompleted;
    private SendOrPostCallback GetPrivRuleByTypeOperationCompleted;
    private SendOrPostCallback GetPrivRuleStatusOperationCompleted;
    private SendOrPostCallback GetUsedPrivRuleOperationCompleted;
    private SendOrPostCallback ParsePrivRuleOperationCompleted;
    private SendOrPostCallback ParsePrivRuleByIDOperationCompleted;
    private SendOrPostCallback UpdateOperationCompleted;
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

    public event AddCompletedEventHandler AddCompleted;

    public event DeleteCompletedEventHandler DeleteCompleted;

    public event GetAllPrivRuleCompletedEventHandler GetAllPrivRuleCompleted;

    public event GetAppointPrivCompletedEventHandler GetAppointPrivCompleted;

    public event GetByIdCompletedEventHandler GetByIdCompleted;

    public event GetPrivRuleByTypeCompletedEventHandler GetPrivRuleByTypeCompleted;

    public event GetPrivRuleStatusCompletedEventHandler GetPrivRuleStatusCompleted;

    public event GetUsedPrivRuleCompletedEventHandler GetUsedPrivRuleCompleted;

    public event ParsePrivRuleCompletedEventHandler ParsePrivRuleCompleted;

    public event ParsePrivRuleByIDCompletedEventHandler ParsePrivRuleByIDCompleted;

    public event UpdateCompletedEventHandler UpdateCompleted;

    public PrivilegePrivRule()
    {
      this.Url = MySettings.Default.WebClient_PrivRule_Privilege_PrivRule;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.Add", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Add(EPrivRule argPrivRule)
    {
      return Conversions.ToString(this.Invoke("Add", new object[1]
      {
        (object) argPrivRule
      })[0]);
    }

    public void AddAsync(EPrivRule argPrivRule)
    {
      this.AddAsync(argPrivRule, (object) null);
    }

    public void AddAsync(EPrivRule argPrivRule, object userState)
    {
      if (this.AddOperationCompleted == null)
        this.AddOperationCompleted = new SendOrPostCallback(this.OnAddOperationCompleted);
      this.InvokeAsync("Add", new object[1]
      {
        (object) argPrivRule
      }, this.AddOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnAddOperationCompleted(object arg)
    {
      if (this.AddCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      AddCompletedEventHandler addCompletedEvent = this.AddCompletedEvent;
      if (addCompletedEvent == null)
        return;
      addCompletedEvent((object) this, new AddCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.Delete", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Delete(string argPrivRuleID)
    {
      return Conversions.ToString(this.Invoke("Delete", new object[1]
      {
        (object) argPrivRuleID
      })[0]);
    }

    public void DeleteAsync(string argPrivRuleID)
    {
      this.DeleteAsync(argPrivRuleID, (object) null);
    }

    public void DeleteAsync(string argPrivRuleID, object userState)
    {
      if (this.DeleteOperationCompleted == null)
        this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
      this.InvokeAsync("Delete", new object[1]
      {
        (object) argPrivRuleID
      }, this.DeleteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnDeleteOperationCompleted(object arg)
    {
      if (this.DeleteCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      DeleteCompletedEventHandler deleteCompletedEvent = this.DeleteCompletedEvent;
      if (deleteCompletedEvent == null)
        return;
      deleteCompletedEvent((object) this, new DeleteCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetAllPrivRule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPrivRuleDataset GetAllPrivRule()
    {
      return (EPrivRuleDataset) this.Invoke("GetAllPrivRule", new object[0])[0];
    }

    public void GetAllPrivRuleAsync()
    {
      this.GetAllPrivRuleAsync((object) null);
    }

    public void GetAllPrivRuleAsync(object userState)
    {
      if (this.GetAllPrivRuleOperationCompleted == null)
        this.GetAllPrivRuleOperationCompleted = new SendOrPostCallback(this.OnGetAllPrivRuleOperationCompleted);
      this.InvokeAsync("GetAllPrivRule", new object[0], this.GetAllPrivRuleOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetAllPrivRuleOperationCompleted(object arg)
    {
      if (this.GetAllPrivRuleCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetAllPrivRuleCompletedEventHandler ruleCompletedEvent = this.GetAllPrivRuleCompletedEvent;
      if (ruleCompletedEvent == null)
        return;
      ruleCompletedEvent((object) this, new GetAllPrivRuleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetAppointPriv", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    [return: XmlArrayItem("GetAppointPrivResultItem")]
    public PairOfGetAppointPrivResultKeyString[] GetAppointPriv(string argEnvInfo)
    {
      return (PairOfGetAppointPrivResultKeyString[]) this.Invoke("GetAppointPriv", new object[1]
      {
        (object) argEnvInfo
      })[0];
    }

    public void GetAppointPrivAsync(string argEnvInfo)
    {
      this.GetAppointPrivAsync(argEnvInfo, (object) null);
    }

    public void GetAppointPrivAsync(string argEnvInfo, object userState)
    {
      if (this.GetAppointPrivOperationCompleted == null)
        this.GetAppointPrivOperationCompleted = new SendOrPostCallback(this.OnGetAppointPrivOperationCompleted);
      this.InvokeAsync("GetAppointPriv", new object[1]
      {
        (object) argEnvInfo
      }, this.GetAppointPrivOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetAppointPrivOperationCompleted(object arg)
    {
      if (this.GetAppointPrivCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetAppointPrivCompletedEventHandler privCompletedEvent = this.GetAppointPrivCompletedEvent;
      if (privCompletedEvent == null)
        return;
      privCompletedEvent((object) this, new GetAppointPrivCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetById", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPrivRule GetById(string argPrivRuleID)
    {
      return (EPrivRule) this.Invoke("GetById", new object[1]
      {
        (object) argPrivRuleID
      })[0];
    }

    public void GetByIdAsync(string argPrivRuleID)
    {
      this.GetByIdAsync(argPrivRuleID, (object) null);
    }

    public void GetByIdAsync(string argPrivRuleID, object userState)
    {
      if (this.GetByIdOperationCompleted == null)
        this.GetByIdOperationCompleted = new SendOrPostCallback(this.OnGetByIdOperationCompleted);
      this.InvokeAsync("GetById", new object[1]
      {
        (object) argPrivRuleID
      }, this.GetByIdOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetByIdOperationCompleted(object arg)
    {
      if (this.GetByIdCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetByIdCompletedEventHandler idCompletedEvent = this.GetByIdCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetByIdCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetPrivRuleByType", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPrivRuleByTypeDataSet GetPrivRuleByType(string PrivRuleTypeName)
    {
      return (EPrivRuleByTypeDataSet) this.Invoke("GetPrivRuleByType", new object[1]
      {
        (object) PrivRuleTypeName
      })[0];
    }

    public void GetPrivRuleByTypeAsync(string PrivRuleTypeName)
    {
      this.GetPrivRuleByTypeAsync(PrivRuleTypeName, (object) null);
    }

    public void GetPrivRuleByTypeAsync(string PrivRuleTypeName, object userState)
    {
      if (this.GetPrivRuleByTypeOperationCompleted == null)
        this.GetPrivRuleByTypeOperationCompleted = new SendOrPostCallback(this.OnGetPrivRuleByTypeOperationCompleted);
      this.InvokeAsync("GetPrivRuleByType", new object[1]
      {
        (object) PrivRuleTypeName
      }, this.GetPrivRuleByTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetPrivRuleByTypeOperationCompleted(object arg)
    {
      if (this.GetPrivRuleByTypeCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetPrivRuleByTypeCompletedEventHandler typeCompletedEvent = this.GetPrivRuleByTypeCompletedEvent;
      if (typeCompletedEvent == null)
        return;
      typeCompletedEvent((object) this, new GetPrivRuleByTypeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetPrivRuleStatus", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPivRuleStatusDataSet GetPrivRuleStatus()
    {
      return (EPivRuleStatusDataSet) this.Invoke("GetPrivRuleStatus", new object[0])[0];
    }

    public void GetPrivRuleStatusAsync()
    {
      this.GetPrivRuleStatusAsync((object) null);
    }

    public void GetPrivRuleStatusAsync(object userState)
    {
      if (this.GetPrivRuleStatusOperationCompleted == null)
        this.GetPrivRuleStatusOperationCompleted = new SendOrPostCallback(this.OnGetPrivRuleStatusOperationCompleted);
      this.InvokeAsync("GetPrivRuleStatus", new object[0], this.GetPrivRuleStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetPrivRuleStatusOperationCompleted(object arg)
    {
      if (this.GetPrivRuleStatusCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetPrivRuleStatusCompletedEventHandler statusCompletedEvent = this.GetPrivRuleStatusCompletedEvent;
      if (statusCompletedEvent == null)
        return;
      statusCompletedEvent((object) this, new GetPrivRuleStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.GetUsedPrivRule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPrivRuleEPRTemplateDataSet GetUsedPrivRule(string argPrivRuleID)
    {
      return (EPrivRuleEPRTemplateDataSet) this.Invoke("GetUsedPrivRule", new object[1]
      {
        (object) argPrivRuleID
      })[0];
    }

    public void GetUsedPrivRuleAsync(string argPrivRuleID)
    {
      this.GetUsedPrivRuleAsync(argPrivRuleID, (object) null);
    }

    public void GetUsedPrivRuleAsync(string argPrivRuleID, object userState)
    {
      if (this.GetUsedPrivRuleOperationCompleted == null)
        this.GetUsedPrivRuleOperationCompleted = new SendOrPostCallback(this.OnGetUsedPrivRuleOperationCompleted);
      this.InvokeAsync("GetUsedPrivRule", new object[1]
      {
        (object) argPrivRuleID
      }, this.GetUsedPrivRuleOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetUsedPrivRuleOperationCompleted(object arg)
    {
      if (this.GetUsedPrivRuleCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetUsedPrivRuleCompletedEventHandler ruleCompletedEvent = this.GetUsedPrivRuleCompletedEvent;
      if (ruleCompletedEvent == null)
        return;
      ruleCompletedEvent((object) this, new GetUsedPrivRuleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.ParsePrivRule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string ParsePrivRule(string argEnviromentInfo)
    {
      return Conversions.ToString(this.Invoke("ParsePrivRule", new object[1]
      {
        (object) argEnviromentInfo
      })[0]);
    }

    public void ParsePrivRuleAsync(string argEnviromentInfo)
    {
      this.ParsePrivRuleAsync(argEnviromentInfo, (object) null);
    }

    public void ParsePrivRuleAsync(string argEnviromentInfo, object userState)
    {
      if (this.ParsePrivRuleOperationCompleted == null)
        this.ParsePrivRuleOperationCompleted = new SendOrPostCallback(this.OnParsePrivRuleOperationCompleted);
      this.InvokeAsync("ParsePrivRule", new object[1]
      {
        (object) argEnviromentInfo
      }, this.ParsePrivRuleOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnParsePrivRuleOperationCompleted(object arg)
    {
      if (this.ParsePrivRuleCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ParsePrivRuleCompletedEventHandler ruleCompletedEvent = this.ParsePrivRuleCompletedEvent;
      if (ruleCompletedEvent == null)
        return;
      ruleCompletedEvent((object) this, new ParsePrivRuleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.ParsePrivRuleByID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    [return: XmlArrayItem("ParsePrivRuleByIDResultItem")]
    public PairOfParsePrivRuleByIDResultKeyString[] ParsePrivRuleByID(string argRuleID, string argEnviromentInfo)
    {
      return (PairOfParsePrivRuleByIDResultKeyString[]) this.Invoke("ParsePrivRuleByID", new object[2]
      {
        (object) argRuleID,
        (object) argEnviromentInfo
      })[0];
    }

    public void ParsePrivRuleByIDAsync(string argRuleID, string argEnviromentInfo)
    {
      this.ParsePrivRuleByIDAsync(argRuleID, argEnviromentInfo, (object) null);
    }

    public void ParsePrivRuleByIDAsync(string argRuleID, string argEnviromentInfo, object userState)
    {
      if (this.ParsePrivRuleByIDOperationCompleted == null)
        this.ParsePrivRuleByIDOperationCompleted = new SendOrPostCallback(this.OnParsePrivRuleByIDOperationCompleted);
      this.InvokeAsync("ParsePrivRuleByID", new object[2]
      {
        (object) argRuleID,
        (object) argEnviromentInfo
      }, this.ParsePrivRuleByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnParsePrivRuleByIDOperationCompleted(object arg)
    {
      if (this.ParsePrivRuleByIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ParsePrivRuleByIDCompletedEventHandler idCompletedEvent = this.ParsePrivRuleByIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new ParsePrivRuleByIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPrivRule.Update", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Update(EPrivRule argPrivRule)
    {
      return Conversions.ToString(this.Invoke("Update", new object[1]
      {
        (object) argPrivRule
      })[0]);
    }

    public void UpdateAsync(EPrivRule argPrivRule)
    {
      this.UpdateAsync(argPrivRule, (object) null);
    }

    public void UpdateAsync(EPrivRule argPrivRule, object userState)
    {
      if (this.UpdateOperationCompleted == null)
        this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
      this.InvokeAsync("Update", new object[1]
      {
        (object) argPrivRule
      }, this.UpdateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnUpdateOperationCompleted(object arg)
    {
      if (this.UpdateCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      UpdateCompletedEventHandler updateCompletedEvent = this.UpdateCompletedEvent;
      if (updateCompletedEvent == null)
        return;
      updateCompletedEvent((object) this, new UpdateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
