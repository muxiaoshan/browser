// Decompiled with JetBrains decompiler
// Type: EPRTemplateCategoryData.EPRTemplateCategory
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

namespace EPRTemplateCategoryData
{
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "EPRTemplateCategorySoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  [DesignerCategory("code")]
  public class EPRTemplateCategory : SoapHttpClientProtocol
  {
    private SendOrPostCallback AddOperationCompleted;
    private SendOrPostCallback DeleteOperationCompleted;
    private SendOrPostCallback GetAllOperationCompleted;
    private SendOrPostCallback GetByIdOperationCompleted;
    private SendOrPostCallback GetCategoryInfoByIDsOperationCompleted;
    private SendOrPostCallback GetCategoryPropertyOperationCompleted;
    private SendOrPostCallback SetCategoryPropertyOperationCompleted;
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

    public event GetAllCompletedEventHandler GetAllCompleted;

    public event GetByIdCompletedEventHandler GetByIdCompleted;

    public event GetCategoryInfoByIDsCompletedEventHandler GetCategoryInfoByIDsCompleted;

    public event GetCategoryPropertyCompletedEventHandler GetCategoryPropertyCompleted;

    public event SetCategoryPropertyCompletedEventHandler SetCategoryPropertyCompleted;

    public event UpdateCompletedEventHandler UpdateCompleted;

    public EPRTemplateCategory()
    {
      this.Url = MySettings.Default.WebClient_EPRTemplateCategoryData_EPRTemplateCategory;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.Add", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Add(EEPRTemplateCategory argEPRTemplateCategory)
    {
      return Conversions.ToString(this.Invoke("Add", new object[1]
      {
        (object) argEPRTemplateCategory
      })[0]);
    }

    public void AddAsync(EEPRTemplateCategory argEPRTemplateCategory)
    {
      this.AddAsync(argEPRTemplateCategory, (object) null);
    }

    public void AddAsync(EEPRTemplateCategory argEPRTemplateCategory, object userState)
    {
      if (this.AddOperationCompleted == null)
        this.AddOperationCompleted = new SendOrPostCallback(this.OnAddOperationCompleted);
      this.InvokeAsync("Add", new object[1]
      {
        (object) argEPRTemplateCategory
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.Delete", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Delete(string argEPRTemplateCategoryID)
    {
      return Conversions.ToString(this.Invoke("Delete", new object[1]
      {
        (object) argEPRTemplateCategoryID
      })[0]);
    }

    public void DeleteAsync(string argEPRTemplateCategoryID)
    {
      this.DeleteAsync(argEPRTemplateCategoryID, (object) null);
    }

    public void DeleteAsync(string argEPRTemplateCategoryID, object userState)
    {
      if (this.DeleteOperationCompleted == null)
        this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
      this.InvokeAsync("Delete", new object[1]
      {
        (object) argEPRTemplateCategoryID
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.GetAll", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EEPRTemplateCategoryDatasetAll GetAll()
    {
      return (EEPRTemplateCategoryDatasetAll) this.Invoke("GetAll", new object[0])[0];
    }

    public void GetAllAsync()
    {
      this.GetAllAsync((object) null);
    }

    public void GetAllAsync(object userState)
    {
      if (this.GetAllOperationCompleted == null)
        this.GetAllOperationCompleted = new SendOrPostCallback(this.OnGetAllOperationCompleted);
      this.InvokeAsync("GetAll", new object[0], this.GetAllOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetAllOperationCompleted(object arg)
    {
      if (this.GetAllCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetAllCompletedEventHandler allCompletedEvent = this.GetAllCompletedEvent;
      if (allCompletedEvent == null)
        return;
      allCompletedEvent((object) this, new GetAllCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.GetById", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EEPRTemplateCategory GetById(string argEPRTemplateCategoryID)
    {
      return (EEPRTemplateCategory) this.Invoke("GetById", new object[1]
      {
        (object) argEPRTemplateCategoryID
      })[0];
    }

    public void GetByIdAsync(string argEPRTemplateCategoryID)
    {
      this.GetByIdAsync(argEPRTemplateCategoryID, (object) null);
    }

    public void GetByIdAsync(string argEPRTemplateCategoryID, object userState)
    {
      if (this.GetByIdOperationCompleted == null)
        this.GetByIdOperationCompleted = new SendOrPostCallback(this.OnGetByIdOperationCompleted);
      this.InvokeAsync("GetById", new object[1]
      {
        (object) argEPRTemplateCategoryID
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

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.GetCategoryInfoByIDs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EEPRTplCateInfoDataset GetCategoryInfoByIDs(string AEPRTemplateCategoryIDs)
    {
      return (EEPRTplCateInfoDataset) this.Invoke("GetCategoryInfoByIDs", new object[1]
      {
        (object) AEPRTemplateCategoryIDs
      })[0];
    }

    public void GetCategoryInfoByIDsAsync(string AEPRTemplateCategoryIDs)
    {
      this.GetCategoryInfoByIDsAsync(AEPRTemplateCategoryIDs, (object) null);
    }

    public void GetCategoryInfoByIDsAsync(string AEPRTemplateCategoryIDs, object userState)
    {
      if (this.GetCategoryInfoByIDsOperationCompleted == null)
        this.GetCategoryInfoByIDsOperationCompleted = new SendOrPostCallback(this.OnGetCategoryInfoByIDsOperationCompleted);
      this.InvokeAsync("GetCategoryInfoByIDs", new object[1]
      {
        (object) AEPRTemplateCategoryIDs
      }, this.GetCategoryInfoByIDsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCategoryInfoByIDsOperationCompleted(object arg)
    {
      if (this.GetCategoryInfoByIDsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCategoryInfoByIDsCompletedEventHandler idsCompletedEvent = this.GetCategoryInfoByIDsCompletedEvent;
      if (idsCompletedEvent == null)
        return;
      idsCompletedEvent((object) this, new GetCategoryInfoByIDsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.GetCategoryProperty", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EEPRCategoryProperty GetCategoryProperty(string argEPRCategoryID)
    {
      return (EEPRCategoryProperty) this.Invoke("GetCategoryProperty", new object[1]
      {
        (object) argEPRCategoryID
      })[0];
    }

    public void GetCategoryPropertyAsync(string argEPRCategoryID)
    {
      this.GetCategoryPropertyAsync(argEPRCategoryID, (object) null);
    }

    public void GetCategoryPropertyAsync(string argEPRCategoryID, object userState)
    {
      if (this.GetCategoryPropertyOperationCompleted == null)
        this.GetCategoryPropertyOperationCompleted = new SendOrPostCallback(this.OnGetCategoryPropertyOperationCompleted);
      this.InvokeAsync("GetCategoryProperty", new object[1]
      {
        (object) argEPRCategoryID
      }, this.GetCategoryPropertyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCategoryPropertyOperationCompleted(object arg)
    {
      if (this.GetCategoryPropertyCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCategoryPropertyCompletedEventHandler propertyCompletedEvent = this.GetCategoryPropertyCompletedEvent;
      if (propertyCompletedEvent == null)
        return;
      propertyCompletedEvent((object) this, new GetCategoryPropertyCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.SetCategoryProperty", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string SetCategoryProperty(string argEPRCategoryID, EEPRCategoryProperty argCategoryProperty)
    {
      return Conversions.ToString(this.Invoke("SetCategoryProperty", new object[2]
      {
        (object) argEPRCategoryID,
        (object) argCategoryProperty
      })[0]);
    }

    public void SetCategoryPropertyAsync(string argEPRCategoryID, EEPRCategoryProperty argCategoryProperty)
    {
      this.SetCategoryPropertyAsync(argEPRCategoryID, argCategoryProperty, (object) null);
    }

    public void SetCategoryPropertyAsync(string argEPRCategoryID, EEPRCategoryProperty argCategoryProperty, object userState)
    {
      if (this.SetCategoryPropertyOperationCompleted == null)
        this.SetCategoryPropertyOperationCompleted = new SendOrPostCallback(this.OnSetCategoryPropertyOperationCompleted);
      this.InvokeAsync("SetCategoryProperty", new object[2]
      {
        (object) argEPRCategoryID,
        (object) argCategoryProperty
      }, this.SetCategoryPropertyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSetCategoryPropertyOperationCompleted(object arg)
    {
      if (this.SetCategoryPropertyCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SetCategoryPropertyCompletedEventHandler propertyCompletedEvent = this.SetCategoryPropertyCompletedEvent;
      if (propertyCompletedEvent == null)
        return;
      propertyCompletedEvent((object) this, new SetCategoryPropertyCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRTemplateCategory.Update", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string Update(string argEPRTemplateCategoryID, EEPRTemplateCategory argEPRTemplateCategory)
    {
      return Conversions.ToString(this.Invoke("Update", new object[2]
      {
        (object) argEPRTemplateCategoryID,
        (object) argEPRTemplateCategory
      })[0]);
    }

    public void UpdateAsync(string argEPRTemplateCategoryID, EEPRTemplateCategory argEPRTemplateCategory)
    {
      this.UpdateAsync(argEPRTemplateCategoryID, argEPRTemplateCategory, (object) null);
    }

    public void UpdateAsync(string argEPRTemplateCategoryID, EEPRTemplateCategory argEPRTemplateCategory, object userState)
    {
      if (this.UpdateOperationCompleted == null)
        this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
      this.InvokeAsync("Update", new object[2]
      {
        (object) argEPRTemplateCategoryID,
        (object) argEPRTemplateCategory
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
