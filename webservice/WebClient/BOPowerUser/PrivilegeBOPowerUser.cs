// Decompiled with JetBrains decompiler
// Type: BOPowerUser.PrivilegeBOPowerUser
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

namespace BOPowerUser
{
  [WebServiceBinding(Name = "Privilege.BOPowerUserSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  public class PrivilegeBOPowerUser : SoapHttpClientProtocol
  {
    private SendOrPostCallback AddOperationCompleted;
    private SendOrPostCallback AddOrUpdateOperationCompleted;
    private SendOrPostCallback DeleteOperationCompleted;
    private SendOrPostCallback GetByIdOperationCompleted;
    private SendOrPostCallback SelectBySSGroupAndLevelOperationCompleted;
    private SendOrPostCallback UpdateOperationCompleted;
    private SendOrPostCallback getSSUserOperationCompleted;
    private SendOrPostCallback getSSUserSubOperationCompleted;
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

    public event AddOrUpdateCompletedEventHandler AddOrUpdateCompleted;

    public event DeleteCompletedEventHandler DeleteCompleted;

    public event GetByIdCompletedEventHandler GetByIdCompleted;

    public event SelectBySSGroupAndLevelCompletedEventHandler SelectBySSGroupAndLevelCompleted;

    public event UpdateCompletedEventHandler UpdateCompleted;

    public event getSSUserCompletedEventHandler getSSUserCompleted;

    public event getSSUserSubCompletedEventHandler getSSUserSubCompleted;

    public PrivilegeBOPowerUser()
    {
      this.Url = MySettings.Default.WebClient_BOPowerUser_Privilege_BOPowerUser;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.Add", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Add(EPowerUser argPowerUser)
    {
      return Conversions.ToString(this.Invoke("Add", new object[1]
      {
        (object) argPowerUser
      })[0]);
    }

    public void AddAsync(EPowerUser argPowerUser)
    {
      this.AddAsync(argPowerUser, (object) null);
    }

    public void AddAsync(EPowerUser argPowerUser, object userState)
    {
      if (this.AddOperationCompleted == null)
        this.AddOperationCompleted = new SendOrPostCallback(this.OnAddOperationCompleted);
      this.InvokeAsync("Add", new object[1]
      {
        (object) argPowerUser
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.AddOrUpdate", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string AddOrUpdate(EPowerUser argPowerUser, string argSkipColumn)
    {
      return Conversions.ToString(this.Invoke("AddOrUpdate", new object[2]
      {
        (object) argPowerUser,
        (object) argSkipColumn
      })[0]);
    }

    public void AddOrUpdateAsync(EPowerUser argPowerUser, string argSkipColumn)
    {
      this.AddOrUpdateAsync(argPowerUser, argSkipColumn, (object) null);
    }

    public void AddOrUpdateAsync(EPowerUser argPowerUser, string argSkipColumn, object userState)
    {
      if (this.AddOrUpdateOperationCompleted == null)
        this.AddOrUpdateOperationCompleted = new SendOrPostCallback(this.OnAddOrUpdateOperationCompleted);
      this.InvokeAsync("AddOrUpdate", new object[2]
      {
        (object) argPowerUser,
        (object) argSkipColumn
      }, this.AddOrUpdateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnAddOrUpdateOperationCompleted(object arg)
    {
      if (this.AddOrUpdateCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      AddOrUpdateCompletedEventHandler updateCompletedEvent = this.AddOrUpdateCompletedEvent;
      if (updateCompletedEvent == null)
        return;
      updateCompletedEvent((object) this, new AddOrUpdateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.Delete", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Delete(string argPowerUserID)
    {
      return Conversions.ToString(this.Invoke("Delete", new object[1]
      {
        (object) argPowerUserID
      })[0]);
    }

    public void DeleteAsync(string argPowerUserID)
    {
      this.DeleteAsync(argPowerUserID, (object) null);
    }

    public void DeleteAsync(string argPowerUserID, object userState)
    {
      if (this.DeleteOperationCompleted == null)
        this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
      this.InvokeAsync("Delete", new object[1]
      {
        (object) argPowerUserID
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.GetById", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EPowerUser GetById(string argPowerUserID)
    {
      return (EPowerUser) this.Invoke("GetById", new object[1]
      {
        (object) argPowerUserID
      })[0];
    }

    public void GetByIdAsync(string argPowerUserID)
    {
      this.GetByIdAsync(argPowerUserID, (object) null);
    }

    public void GetByIdAsync(string argPowerUserID, object userState)
    {
      if (this.GetByIdOperationCompleted == null)
        this.GetByIdOperationCompleted = new SendOrPostCallback(this.OnGetByIdOperationCompleted);
      this.InvokeAsync("GetById", new object[1]
      {
        (object) argPowerUserID
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.SelectBySSGroupAndLevel", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string SelectBySSGroupAndLevel(string argSSGroupID, string argLevel)
    {
      return Conversions.ToString(this.Invoke("SelectBySSGroupAndLevel", new object[2]
      {
        (object) argSSGroupID,
        (object) argLevel
      })[0]);
    }

    public void SelectBySSGroupAndLevelAsync(string argSSGroupID, string argLevel)
    {
      this.SelectBySSGroupAndLevelAsync(argSSGroupID, argLevel, (object) null);
    }

    public void SelectBySSGroupAndLevelAsync(string argSSGroupID, string argLevel, object userState)
    {
      if (this.SelectBySSGroupAndLevelOperationCompleted == null)
        this.SelectBySSGroupAndLevelOperationCompleted = new SendOrPostCallback(this.OnSelectBySSGroupAndLevelOperationCompleted);
      this.InvokeAsync("SelectBySSGroupAndLevel", new object[2]
      {
        (object) argSSGroupID,
        (object) argLevel
      }, this.SelectBySSGroupAndLevelOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSelectBySSGroupAndLevelOperationCompleted(object arg)
    {
      if (this.SelectBySSGroupAndLevelCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SelectBySSGroupAndLevelCompletedEventHandler levelCompletedEvent = this.SelectBySSGroupAndLevelCompletedEvent;
      if (levelCompletedEvent == null)
        return;
      levelCompletedEvent((object) this, new SelectBySSGroupAndLevelCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.Update", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Update(EPowerUser argPowerUser, string argSkipColumn)
    {
      return Conversions.ToString(this.Invoke("Update", new object[2]
      {
        (object) argPowerUser,
        (object) argSkipColumn
      })[0]);
    }

    public void UpdateAsync(EPowerUser argPowerUser, string argSkipColumn)
    {
      this.UpdateAsync(argPowerUser, argSkipColumn, (object) null);
    }

    public void UpdateAsync(EPowerUser argPowerUser, string argSkipColumn, object userState)
    {
      if (this.UpdateOperationCompleted == null)
        this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
      this.InvokeAsync("Update", new object[2]
      {
        (object) argPowerUser,
        (object) argSkipColumn
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.getSSUser", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public DataSet getSSUser(string argGroupName, string argUserName)
    {
      return (DataSet) this.Invoke("getSSUser", new object[2]
      {
        (object) argGroupName,
        (object) argUserName
      })[0];
    }

    public void getSSUserAsync(string argGroupName, string argUserName)
    {
      this.getSSUserAsync(argGroupName, argUserName, (object) null);
    }

    public void getSSUserAsync(string argGroupName, string argUserName, object userState)
    {
      if (this.getSSUserOperationCompleted == null)
        this.getSSUserOperationCompleted = new SendOrPostCallback(this.OngetSSUserOperationCompleted);
      this.InvokeAsync("getSSUser", new object[2]
      {
        (object) argGroupName,
        (object) argUserName
      }, this.getSSUserOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OngetSSUserOperationCompleted(object arg)
    {
      if (this.getSSUserCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      getSSUserCompletedEventHandler userCompletedEvent = this.getSSUserCompletedEvent;
      if (userCompletedEvent == null)
        return;
      userCompletedEvent((object) this, new getSSUserCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.Privilege.BOPowerUser.getSSUserSub", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public DataSet getSSUserSub(string argGroupName, string argUserName)
    {
      return (DataSet) this.Invoke("getSSUserSub", new object[2]
      {
        (object) argGroupName,
        (object) argUserName
      })[0];
    }

    public void getSSUserSubAsync(string argGroupName, string argUserName)
    {
      this.getSSUserSubAsync(argGroupName, argUserName, (object) null);
    }

    public void getSSUserSubAsync(string argGroupName, string argUserName, object userState)
    {
      if (this.getSSUserSubOperationCompleted == null)
        this.getSSUserSubOperationCompleted = new SendOrPostCallback(this.OngetSSUserSubOperationCompleted);
      this.InvokeAsync("getSSUserSub", new object[2]
      {
        (object) argGroupName,
        (object) argUserName
      }, this.getSSUserSubOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OngetSSUserSubOperationCompleted(object arg)
    {
      if (this.getSSUserSubCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      getSSUserSubCompletedEventHandler subCompletedEvent = this.getSSUserSubCompletedEvent;
      if (subCompletedEvent == null)
        return;
      subCompletedEvent((object) this, new getSSUserSubCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
