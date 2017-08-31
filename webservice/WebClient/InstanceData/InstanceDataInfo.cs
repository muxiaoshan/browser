// Decompiled with JetBrains decompiler
// Type: InstanceData.InstanceDataInfo
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

namespace InstanceData
{
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  [WebServiceBinding(Name = "InstanceDataInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class InstanceDataInfo : SoapHttpClientProtocol
  {
    private SendOrPostCallback AddInstanceLogOperationCompleted;
    private SendOrPostCallback AddLogOperationCompleted;
    private SendOrPostCallback ChangeStatusOperationCompleted;
    private SendOrPostCallback CheckFinalStatusOperationCompleted;
    private SendOrPostCallback CheckHappenDateTimeValidOperationCompleted;
    private SendOrPostCallback ClearLogOperationCompleted;
    private SendOrPostCallback GetAllLogsOperationCompleted;
    private SendOrPostCallback GetCurrentStatusOperationCompleted;
    private SendOrPostCallback GetDataOperationCompleted;
    private SendOrPostCallback GetDataByIDOperationCompleted;
    private SendOrPostCallback GetDataByInstanceIDOperationCompleted;
    private SendOrPostCallback GetDescDataByIDOperationCompleted;
    private SendOrPostCallback GetFinalLogOperationCompleted;
    private SendOrPostCallback GetGroupDataByIDOperationCompleted;
    private SendOrPostCallback GetGroupItemListOperationCompleted;
    private SendOrPostCallback GetInstanceDataOperationCompleted;
    private SendOrPostCallback GetMultipleDataOperationCompleted;
    private SendOrPostCallback GetNormalDataOperationCompleted;
    private SendOrPostCallback GetNormalDataOldOperationCompleted;
    private SendOrPostCallback GetParentGroupListOperationCompleted;
    private SendOrPostCallback GetRefInstanceIDOperationCompleted;
    private SendOrPostCallback GetTemplateIDByIDOperationCompleted;
    private SendOrPostCallback ImportInstanceDataOperationCompleted;
    private SendOrPostCallback InitAfterMultiOperOperationCompleted;
    private SendOrPostCallback InitAfterSingleOperOperationCompleted;
    private SendOrPostCallback ReplaceGroupDataOperationCompleted;
    private SendOrPostCallback ReplaceTemplateDataOperationCompleted;
    private SendOrPostCallback SaveDataOperationCompleted;
    private SendOrPostCallback SaveMultipleDataOperationCompleted;
    private SendOrPostCallback TestSaveMultipleDataOperationCompleted;
    private SendOrPostCallback UpdateEPRLogsOperationCompleted;
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

    public event AddInstanceLogCompletedEventHandler AddInstanceLogCompleted;

    public event AddLogCompletedEventHandler AddLogCompleted;

    public event ChangeStatusCompletedEventHandler ChangeStatusCompleted;

    public event CheckFinalStatusCompletedEventHandler CheckFinalStatusCompleted;

    public event CheckHappenDateTimeValidCompletedEventHandler CheckHappenDateTimeValidCompleted;

    public event ClearLogCompletedEventHandler ClearLogCompleted;

    public event GetAllLogsCompletedEventHandler GetAllLogsCompleted;

    public event GetCurrentStatusCompletedEventHandler GetCurrentStatusCompleted;

    public event GetDataCompletedEventHandler GetDataCompleted;

    public event GetDataByIDCompletedEventHandler GetDataByIDCompleted;

    public event GetDataByInstanceIDCompletedEventHandler GetDataByInstanceIDCompleted;

    public event GetDescDataByIDCompletedEventHandler GetDescDataByIDCompleted;

    public event GetFinalLogCompletedEventHandler GetFinalLogCompleted;

    public event GetGroupDataByIDCompletedEventHandler GetGroupDataByIDCompleted;

    public event GetGroupItemListCompletedEventHandler GetGroupItemListCompleted;

    public event GetInstanceDataCompletedEventHandler GetInstanceDataCompleted;

    public event GetMultipleDataCompletedEventHandler GetMultipleDataCompleted;

    public event GetNormalDataCompletedEventHandler GetNormalDataCompleted;

    public event GetNormalDataOldCompletedEventHandler GetNormalDataOldCompleted;

    public event GetParentGroupListCompletedEventHandler GetParentGroupListCompleted;

    public event GetRefInstanceIDCompletedEventHandler GetRefInstanceIDCompleted;

    public event GetTemplateIDByIDCompletedEventHandler GetTemplateIDByIDCompleted;

    public event ImportInstanceDataCompletedEventHandler ImportInstanceDataCompleted;

    public event InitAfterMultiOperCompletedEventHandler InitAfterMultiOperCompleted;

    public event InitAfterSingleOperCompletedEventHandler InitAfterSingleOperCompleted;

    public event ReplaceGroupDataCompletedEventHandler ReplaceGroupDataCompleted;

    public event ReplaceTemplateDataCompletedEventHandler ReplaceTemplateDataCompleted;

    public event SaveDataCompletedEventHandler SaveDataCompleted;

    public event SaveMultipleDataCompletedEventHandler SaveMultipleDataCompleted;

    public event TestSaveMultipleDataCompletedEventHandler TestSaveMultipleDataCompleted;

    public event UpdateEPRLogsCompletedEventHandler UpdateEPRLogsCompleted;

    public InstanceDataInfo()
    {
      this.Url = MySettings.Default.WebClient_InstanceData_InstanceDataInfo;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.AddInstanceLog", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string AddInstanceLog(string parInstanceID, EMixInstanceLog parLog)
    {
      return Conversions.ToString(this.Invoke("AddInstanceLog", new object[2]
      {
        (object) parInstanceID,
        (object) parLog
      })[0]);
    }

    public void AddInstanceLogAsync(string parInstanceID, EMixInstanceLog parLog)
    {
      this.AddInstanceLogAsync(parInstanceID, parLog, (object) null);
    }

    public void AddInstanceLogAsync(string parInstanceID, EMixInstanceLog parLog, object userState)
    {
      if (this.AddInstanceLogOperationCompleted == null)
        this.AddInstanceLogOperationCompleted = new SendOrPostCallback(this.OnAddInstanceLogOperationCompleted);
      this.InvokeAsync("AddInstanceLog", new object[2]
      {
        (object) parInstanceID,
        (object) parLog
      }, this.AddInstanceLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnAddInstanceLogOperationCompleted(object arg)
    {
      if (this.AddInstanceLogCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      AddInstanceLogCompletedEventHandler logCompletedEvent = this.AddInstanceLogCompletedEvent;
      if (logCompletedEvent == null)
        return;
      logCompletedEvent((object) this, new AddInstanceLogCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.AddLog", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string AddLog(string parInstanceID, EInstanceLog parLog)
    {
      return Conversions.ToString(this.Invoke("AddLog", new object[2]
      {
        (object) parInstanceID,
        (object) parLog
      })[0]);
    }

    public void AddLogAsync(string parInstanceID, EInstanceLog parLog)
    {
      this.AddLogAsync(parInstanceID, parLog, (object) null);
    }

    public void AddLogAsync(string parInstanceID, EInstanceLog parLog, object userState)
    {
      if (this.AddLogOperationCompleted == null)
        this.AddLogOperationCompleted = new SendOrPostCallback(this.OnAddLogOperationCompleted);
      this.InvokeAsync("AddLog", new object[2]
      {
        (object) parInstanceID,
        (object) parLog
      }, this.AddLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnAddLogOperationCompleted(object arg)
    {
      if (this.AddLogCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      AddLogCompletedEventHandler logCompletedEvent = this.AddLogCompletedEvent;
      if (logCompletedEvent == null)
        return;
      logCompletedEvent((object) this, new AddLogCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ChangeStatus", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string ChangeStatus(string parInstanceID, string parStatus)
    {
      return Conversions.ToString(this.Invoke("ChangeStatus", new object[2]
      {
        (object) parInstanceID,
        (object) parStatus
      })[0]);
    }

    public void ChangeStatusAsync(string parInstanceID, string parStatus)
    {
      this.ChangeStatusAsync(parInstanceID, parStatus, (object) null);
    }

    public void ChangeStatusAsync(string parInstanceID, string parStatus, object userState)
    {
      if (this.ChangeStatusOperationCompleted == null)
        this.ChangeStatusOperationCompleted = new SendOrPostCallback(this.OnChangeStatusOperationCompleted);
      this.InvokeAsync("ChangeStatus", new object[2]
      {
        (object) parInstanceID,
        (object) parStatus
      }, this.ChangeStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnChangeStatusOperationCompleted(object arg)
    {
      if (this.ChangeStatusCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ChangeStatusCompletedEventHandler statusCompletedEvent = this.ChangeStatusCompletedEvent;
      if (statusCompletedEvent == null)
        return;
      statusCompletedEvent((object) this, new ChangeStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.CheckFinalStatus", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string CheckFinalStatus(string AInstanceID, string parStatusStr)
    {
      return Conversions.ToString(this.Invoke("CheckFinalStatus", new object[2]
      {
        (object) AInstanceID,
        (object) parStatusStr
      })[0]);
    }

    public void CheckFinalStatusAsync(string AInstanceID, string parStatusStr)
    {
      this.CheckFinalStatusAsync(AInstanceID, parStatusStr, (object) null);
    }

    public void CheckFinalStatusAsync(string AInstanceID, string parStatusStr, object userState)
    {
      if (this.CheckFinalStatusOperationCompleted == null)
        this.CheckFinalStatusOperationCompleted = new SendOrPostCallback(this.OnCheckFinalStatusOperationCompleted);
      this.InvokeAsync("CheckFinalStatus", new object[2]
      {
        (object) AInstanceID,
        (object) parStatusStr
      }, this.CheckFinalStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnCheckFinalStatusOperationCompleted(object arg)
    {
      if (this.CheckFinalStatusCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      CheckFinalStatusCompletedEventHandler statusCompletedEvent = this.CheckFinalStatusCompletedEvent;
      if (statusCompletedEvent == null)
        return;
      statusCompletedEvent((object) this, new CheckFinalStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.CheckHappenDateTimeValid", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string CheckHappenDateTimeValid(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime)
    {
      return Conversions.ToString(this.Invoke("CheckHappenDateTimeValid", new object[4]
      {
        (object) AECRecord,
        (object) AInstanceID,
        (object) AHappendDate,
        (object) AHappendTime
      })[0]);
    }

    public void CheckHappenDateTimeValidAsync(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime)
    {
      this.CheckHappenDateTimeValidAsync(AECRecord, AInstanceID, AHappendDate, AHappendTime, (object) null);
    }

    public void CheckHappenDateTimeValidAsync(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime, object userState)
    {
      if (this.CheckHappenDateTimeValidOperationCompleted == null)
        this.CheckHappenDateTimeValidOperationCompleted = new SendOrPostCallback(this.OnCheckHappenDateTimeValidOperationCompleted);
      this.InvokeAsync("CheckHappenDateTimeValid", new object[4]
      {
        (object) AECRecord,
        (object) AInstanceID,
        (object) AHappendDate,
        (object) AHappendTime
      }, this.CheckHappenDateTimeValidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnCheckHappenDateTimeValidOperationCompleted(object arg)
    {
      if (this.CheckHappenDateTimeValidCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      CheckHappenDateTimeValidCompletedEventHandler validCompletedEvent = this.CheckHappenDateTimeValidCompletedEvent;
      if (validCompletedEvent == null)
        return;
      validCompletedEvent((object) this, new CheckHappenDateTimeValidCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ClearLog", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string ClearLog(string parInstanceID)
    {
      return Conversions.ToString(this.Invoke("ClearLog", new object[1]
      {
        (object) parInstanceID
      })[0]);
    }

    public void ClearLogAsync(string parInstanceID)
    {
      this.ClearLogAsync(parInstanceID, (object) null);
    }

    public void ClearLogAsync(string parInstanceID, object userState)
    {
      if (this.ClearLogOperationCompleted == null)
        this.ClearLogOperationCompleted = new SendOrPostCallback(this.OnClearLogOperationCompleted);
      this.InvokeAsync("ClearLog", new object[1]
      {
        (object) parInstanceID
      }, this.ClearLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnClearLogOperationCompleted(object arg)
    {
      if (this.ClearLogCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ClearLogCompletedEventHandler logCompletedEvent = this.ClearLogCompletedEvent;
      if (logCompletedEvent == null)
        return;
      logCompletedEvent((object) this, new ClearLogCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetAllLogs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetAllLogs(string AInstanceID)
    {
      return Conversions.ToString(this.Invoke("GetAllLogs", new object[1]
      {
        (object) AInstanceID
      })[0]);
    }

    public void GetAllLogsAsync(string AInstanceID)
    {
      this.GetAllLogsAsync(AInstanceID, (object) null);
    }

    public void GetAllLogsAsync(string AInstanceID, object userState)
    {
      if (this.GetAllLogsOperationCompleted == null)
        this.GetAllLogsOperationCompleted = new SendOrPostCallback(this.OnGetAllLogsOperationCompleted);
      this.InvokeAsync("GetAllLogs", new object[1]
      {
        (object) AInstanceID
      }, this.GetAllLogsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetAllLogsOperationCompleted(object arg)
    {
      if (this.GetAllLogsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetAllLogsCompletedEventHandler logsCompletedEvent = this.GetAllLogsCompletedEvent;
      if (logsCompletedEvent == null)
        return;
      logsCompletedEvent((object) this, new GetAllLogsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetCurrentStatus", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetCurrentStatus(string parInstanceID)
    {
      return Conversions.ToString(this.Invoke("GetCurrentStatus", new object[1]
      {
        (object) parInstanceID
      })[0]);
    }

    public void GetCurrentStatusAsync(string parInstanceID)
    {
      this.GetCurrentStatusAsync(parInstanceID, (object) null);
    }

    public void GetCurrentStatusAsync(string parInstanceID, object userState)
    {
      if (this.GetCurrentStatusOperationCompleted == null)
        this.GetCurrentStatusOperationCompleted = new SendOrPostCallback(this.OnGetCurrentStatusOperationCompleted);
      this.InvokeAsync("GetCurrentStatus", new object[1]
      {
        (object) parInstanceID
      }, this.GetCurrentStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetCurrentStatusOperationCompleted(object arg)
    {
      if (this.GetCurrentStatusCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetCurrentStatusCompletedEventHandler statusCompletedEvent = this.GetCurrentStatusCompletedEvent;
      if (statusCompletedEvent == null)
        return;
      statusCompletedEvent((object) this, new GetCurrentStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetData(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID)
    {
      return (EInstanceData) this.Invoke("GetData", new object[6]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) AChartListNo,
        (object) ATemplateID
      })[0];
    }

    public void GetDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID)
    {
      this.GetDataAsync(APatientID, AEpisodeID, AChartItemID, AChartItemType, AChartListNo, ATemplateID, (object) null);
    }

    public void GetDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, object userState)
    {
      if (this.GetDataOperationCompleted == null)
        this.GetDataOperationCompleted = new SendOrPostCallback(this.OnGetDataOperationCompleted);
      this.InvokeAsync("GetData", new object[6]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) AChartListNo,
        (object) ATemplateID
      }, this.GetDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetDataOperationCompleted(object arg)
    {
      if (this.GetDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetDataCompletedEventHandler dataCompletedEvent = this.GetDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new GetDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDataByID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetDataByID(string AID)
    {
      return (EInstanceData) this.Invoke("GetDataByID", new object[1]
      {
        (object) AID
      })[0];
    }

    public void GetDataByIDAsync(string AID)
    {
      this.GetDataByIDAsync(AID, (object) null);
    }

    public void GetDataByIDAsync(string AID, object userState)
    {
      if (this.GetDataByIDOperationCompleted == null)
        this.GetDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetDataByIDOperationCompleted);
      this.InvokeAsync("GetDataByID", new object[1]
      {
        (object) AID
      }, this.GetDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetDataByIDOperationCompleted(object arg)
    {
      if (this.GetDataByIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetDataByIDCompletedEventHandler idCompletedEvent = this.GetDataByIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetDataByIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDataByInstanceID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public ReStreamData GetDataByInstanceID(string AInstanceDataID)
    {
      return (ReStreamData) this.Invoke("GetDataByInstanceID", new object[1]
      {
        (object) AInstanceDataID
      })[0];
    }

    public void GetDataByInstanceIDAsync(string AInstanceDataID)
    {
      this.GetDataByInstanceIDAsync(AInstanceDataID, (object) null);
    }

    public void GetDataByInstanceIDAsync(string AInstanceDataID, object userState)
    {
      if (this.GetDataByInstanceIDOperationCompleted == null)
        this.GetDataByInstanceIDOperationCompleted = new SendOrPostCallback(this.OnGetDataByInstanceIDOperationCompleted);
      this.InvokeAsync("GetDataByInstanceID", new object[1]
      {
        (object) AInstanceDataID
      }, this.GetDataByInstanceIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetDataByInstanceIDOperationCompleted(object arg)
    {
      if (this.GetDataByInstanceIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetDataByInstanceIDCompletedEventHandler idCompletedEvent = this.GetDataByInstanceIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetDataByInstanceIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDescDataByID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetDescDataByID(string AID)
    {
      return (EInstanceData) this.Invoke("GetDescDataByID", new object[1]
      {
        (object) AID
      })[0];
    }

    public void GetDescDataByIDAsync(string AID)
    {
      this.GetDescDataByIDAsync(AID, (object) null);
    }

    public void GetDescDataByIDAsync(string AID, object userState)
    {
      if (this.GetDescDataByIDOperationCompleted == null)
        this.GetDescDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetDescDataByIDOperationCompleted);
      this.InvokeAsync("GetDescDataByID", new object[1]
      {
        (object) AID
      }, this.GetDescDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetDescDataByIDOperationCompleted(object arg)
    {
      if (this.GetDescDataByIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetDescDataByIDCompletedEventHandler idCompletedEvent = this.GetDescDataByIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetDescDataByIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetFinalLog", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceLog GetFinalLog(string AInstanceID)
    {
      return (EInstanceLog) this.Invoke("GetFinalLog", new object[1]
      {
        (object) AInstanceID
      })[0];
    }

    public void GetFinalLogAsync(string AInstanceID)
    {
      this.GetFinalLogAsync(AInstanceID, (object) null);
    }

    public void GetFinalLogAsync(string AInstanceID, object userState)
    {
      if (this.GetFinalLogOperationCompleted == null)
        this.GetFinalLogOperationCompleted = new SendOrPostCallback(this.OnGetFinalLogOperationCompleted);
      this.InvokeAsync("GetFinalLog", new object[1]
      {
        (object) AInstanceID
      }, this.GetFinalLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetFinalLogOperationCompleted(object arg)
    {
      if (this.GetFinalLogCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetFinalLogCompletedEventHandler logCompletedEvent = this.GetFinalLogCompletedEvent;
      if (logCompletedEvent == null)
        return;
      logCompletedEvent((object) this, new GetFinalLogCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetGroupDataByID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetGroupDataByID(string AID)
    {
      return (EInstanceData) this.Invoke("GetGroupDataByID", new object[1]
      {
        (object) AID
      })[0];
    }

    public void GetGroupDataByIDAsync(string AID)
    {
      this.GetGroupDataByIDAsync(AID, (object) null);
    }

    public void GetGroupDataByIDAsync(string AID, object userState)
    {
      if (this.GetGroupDataByIDOperationCompleted == null)
        this.GetGroupDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetGroupDataByIDOperationCompleted);
      this.InvokeAsync("GetGroupDataByID", new object[1]
      {
        (object) AID
      }, this.GetGroupDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetGroupDataByIDOperationCompleted(object arg)
    {
      if (this.GetGroupDataByIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetGroupDataByIDCompletedEventHandler idCompletedEvent = this.GetGroupDataByIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetGroupDataByIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetGroupItemList", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInsGroupNewDataSet GetGroupItemList(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      return (EInsGroupNewDataSet) this.Invoke("GetGroupItemList", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      })[0];
    }

    public void GetGroupItemListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      this.GetGroupItemListAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, (object) null);
    }

    public void GetGroupItemListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
    {
      if (this.GetGroupItemListOperationCompleted == null)
        this.GetGroupItemListOperationCompleted = new SendOrPostCallback(this.OnGetGroupItemListOperationCompleted);
      this.InvokeAsync("GetGroupItemList", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      }, this.GetGroupItemListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetGroupItemListOperationCompleted(object arg)
    {
      if (this.GetGroupItemListCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetGroupItemListCompletedEventHandler listCompletedEvent = this.GetGroupItemListCompletedEvent;
      if (listCompletedEvent == null)
        return;
      listCompletedEvent((object) this, new GetGroupItemListCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetInstanceData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetInstanceData(string aEpisodeId, string aTemplateId, string aMountCategoryId)
    {
      return (EInstanceData) this.Invoke("GetInstanceData", new object[3]
      {
        (object) aEpisodeId,
        (object) aTemplateId,
        (object) aMountCategoryId
      })[0];
    }

    public void GetInstanceDataAsync(string aEpisodeId, string aTemplateId, string aMountCategoryId)
    {
      this.GetInstanceDataAsync(aEpisodeId, aTemplateId, aMountCategoryId, (object) null);
    }

    public void GetInstanceDataAsync(string aEpisodeId, string aTemplateId, string aMountCategoryId, object userState)
    {
      if (this.GetInstanceDataOperationCompleted == null)
        this.GetInstanceDataOperationCompleted = new SendOrPostCallback(this.OnGetInstanceDataOperationCompleted);
      this.InvokeAsync("GetInstanceData", new object[3]
      {
        (object) aEpisodeId,
        (object) aTemplateId,
        (object) aMountCategoryId
      }, this.GetInstanceDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetInstanceDataOperationCompleted(object arg)
    {
      if (this.GetInstanceDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetInstanceDataCompletedEventHandler dataCompletedEvent = this.GetInstanceDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new GetInstanceDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetMultipleData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetMultipleData(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType)
    {
      return (EInstanceData) this.Invoke("GetMultipleData", new object[8]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) AChartListNo,
        (object) ATemplateID,
        (object) ACategoryID,
        (object) ACategoryType
      })[0];
    }

    public void GetMultipleDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType)
    {
      this.GetMultipleDataAsync(APatientID, AEpisodeID, AChartItemID, AChartItemType, AChartListNo, ATemplateID, ACategoryID, ACategoryType, (object) null);
    }

    public void GetMultipleDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType, object userState)
    {
      if (this.GetMultipleDataOperationCompleted == null)
        this.GetMultipleDataOperationCompleted = new SendOrPostCallback(this.OnGetMultipleDataOperationCompleted);
      this.InvokeAsync("GetMultipleData", new object[8]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) AChartListNo,
        (object) ATemplateID,
        (object) ACategoryID,
        (object) ACategoryType
      }, this.GetMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetMultipleDataOperationCompleted(object arg)
    {
      if (this.GetMultipleDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetMultipleDataCompletedEventHandler dataCompletedEvent = this.GetMultipleDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new GetMultipleDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetNormalData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetNormalData(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      return (EInstanceData) this.Invoke("GetNormalData", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      })[0];
    }

    public void GetNormalDataAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      this.GetNormalDataAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, (object) null);
    }

    public void GetNormalDataAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
    {
      if (this.GetNormalDataOperationCompleted == null)
        this.GetNormalDataOperationCompleted = new SendOrPostCallback(this.OnGetNormalDataOperationCompleted);
      this.InvokeAsync("GetNormalData", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      }, this.GetNormalDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetNormalDataOperationCompleted(object arg)
    {
      if (this.GetNormalDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetNormalDataCompletedEventHandler dataCompletedEvent = this.GetNormalDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new GetNormalDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetNormalDataOld", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData GetNormalDataOld(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      return (EInstanceData) this.Invoke("GetNormalDataOld", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      })[0];
    }

    public void GetNormalDataOldAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      this.GetNormalDataOldAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, (object) null);
    }

    public void GetNormalDataOldAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
    {
      if (this.GetNormalDataOldOperationCompleted == null)
        this.GetNormalDataOldOperationCompleted = new SendOrPostCallback(this.OnGetNormalDataOldOperationCompleted);
      this.InvokeAsync("GetNormalDataOld", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      }, this.GetNormalDataOldOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetNormalDataOldOperationCompleted(object arg)
    {
      if (this.GetNormalDataOldCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetNormalDataOldCompletedEventHandler oldCompletedEvent = this.GetNormalDataOldCompletedEvent;
      if (oldCompletedEvent == null)
        return;
      oldCompletedEvent((object) this, new GetNormalDataOldCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetParentGroupList", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInsGroupNewDataSet GetParentGroupList(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      return (EInsGroupNewDataSet) this.Invoke("GetParentGroupList", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      })[0];
    }

    public void GetParentGroupListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
    {
      this.GetParentGroupListAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, (object) null);
    }

    public void GetParentGroupListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
    {
      if (this.GetParentGroupListOperationCompleted == null)
        this.GetParentGroupListOperationCompleted = new SendOrPostCallback(this.OnGetParentGroupListOperationCompleted);
      this.InvokeAsync("GetParentGroupList", new object[7]
      {
        (object) APatientID,
        (object) AEpisodeID,
        (object) AEpisodeType,
        (object) AChartItemID,
        (object) AChartItemType,
        (object) ACategoryType,
        (object) ACategoryID
      }, this.GetParentGroupListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetParentGroupListOperationCompleted(object arg)
    {
      if (this.GetParentGroupListCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetParentGroupListCompletedEventHandler listCompletedEvent = this.GetParentGroupListCompletedEvent;
      if (listCompletedEvent == null)
        return;
      listCompletedEvent((object) this, new GetParentGroupListCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetRefInstanceID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetRefInstanceID(string AEpisodeID, string ATemplateID)
    {
      return Conversions.ToString(this.Invoke("GetRefInstanceID", new object[2]
      {
        (object) AEpisodeID,
        (object) ATemplateID
      })[0]);
    }

    public void GetRefInstanceIDAsync(string AEpisodeID, string ATemplateID)
    {
      this.GetRefInstanceIDAsync(AEpisodeID, ATemplateID, (object) null);
    }

    public void GetRefInstanceIDAsync(string AEpisodeID, string ATemplateID, object userState)
    {
      if (this.GetRefInstanceIDOperationCompleted == null)
        this.GetRefInstanceIDOperationCompleted = new SendOrPostCallback(this.OnGetRefInstanceIDOperationCompleted);
      this.InvokeAsync("GetRefInstanceID", new object[2]
      {
        (object) AEpisodeID,
        (object) ATemplateID
      }, this.GetRefInstanceIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetRefInstanceIDOperationCompleted(object arg)
    {
      if (this.GetRefInstanceIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetRefInstanceIDCompletedEventHandler idCompletedEvent = this.GetRefInstanceIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetRefInstanceIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetTemplateIDByID", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string GetTemplateIDByID(string argInstanceId)
    {
      return Conversions.ToString(this.Invoke("GetTemplateIDByID", new object[1]
      {
        (object) argInstanceId
      })[0]);
    }

    public void GetTemplateIDByIDAsync(string argInstanceId)
    {
      this.GetTemplateIDByIDAsync(argInstanceId, (object) null);
    }

    public void GetTemplateIDByIDAsync(string argInstanceId, object userState)
    {
      if (this.GetTemplateIDByIDOperationCompleted == null)
        this.GetTemplateIDByIDOperationCompleted = new SendOrPostCallback(this.OnGetTemplateIDByIDOperationCompleted);
      this.InvokeAsync("GetTemplateIDByID", new object[1]
      {
        (object) argInstanceId
      }, this.GetTemplateIDByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnGetTemplateIDByIDOperationCompleted(object arg)
    {
      if (this.GetTemplateIDByIDCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      GetTemplateIDByIDCompletedEventHandler idCompletedEvent = this.GetTemplateIDByIDCompletedEvent;
      if (idCompletedEvent == null)
        return;
      idCompletedEvent((object) this, new GetTemplateIDByIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ImportInstanceData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string ImportInstanceData(EInstanceData aEInstanceData)
    {
      return Conversions.ToString(this.Invoke("ImportInstanceData", new object[1]
      {
        (object) aEInstanceData
      })[0]);
    }

    public void ImportInstanceDataAsync(EInstanceData aEInstanceData)
    {
      this.ImportInstanceDataAsync(aEInstanceData, (object) null);
    }

    public void ImportInstanceDataAsync(EInstanceData aEInstanceData, object userState)
    {
      if (this.ImportInstanceDataOperationCompleted == null)
        this.ImportInstanceDataOperationCompleted = new SendOrPostCallback(this.OnImportInstanceDataOperationCompleted);
      this.InvokeAsync("ImportInstanceData", new object[1]
      {
        (object) aEInstanceData
      }, this.ImportInstanceDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnImportInstanceDataOperationCompleted(object arg)
    {
      if (this.ImportInstanceDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ImportInstanceDataCompletedEventHandler dataCompletedEvent = this.ImportInstanceDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new ImportInstanceDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.InitAfterMultiOper", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string InitAfterMultiOper(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID)
    {
      return Conversions.ToString(this.Invoke("InitAfterMultiOper", new object[9]
      {
        (object) parAction,
        (object) parEpisodeID,
        (object) parEprDocID,
        (object) parEprNum,
        (object) parIP,
        (object) parHappenDate,
        (object) parHappenTime,
        (object) parUserID,
        (object) parTemplateID
      })[0]);
    }

    public void InitAfterMultiOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID)
    {
      this.InitAfterMultiOperAsync(parAction, parEpisodeID, parEprDocID, parEprNum, parIP, parHappenDate, parHappenTime, parUserID, parTemplateID, (object) null);
    }

    public void InitAfterMultiOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID, object userState)
    {
      if (this.InitAfterMultiOperOperationCompleted == null)
        this.InitAfterMultiOperOperationCompleted = new SendOrPostCallback(this.OnInitAfterMultiOperOperationCompleted);
      this.InvokeAsync("InitAfterMultiOper", new object[9]
      {
        (object) parAction,
        (object) parEpisodeID,
        (object) parEprDocID,
        (object) parEprNum,
        (object) parIP,
        (object) parHappenDate,
        (object) parHappenTime,
        (object) parUserID,
        (object) parTemplateID
      }, this.InitAfterMultiOperOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnInitAfterMultiOperOperationCompleted(object arg)
    {
      if (this.InitAfterMultiOperCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      InitAfterMultiOperCompletedEventHandler operCompletedEvent = this.InitAfterMultiOperCompletedEvent;
      if (operCompletedEvent == null)
        return;
      operCompletedEvent((object) this, new InitAfterMultiOperCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.InitAfterSingleOper", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string InitAfterSingleOper(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID)
    {
      return Conversions.ToString(this.Invoke("InitAfterSingleOper", new object[10]
      {
        (object) parAction,
        (object) parEpisodeID,
        (object) parEprDocID,
        (object) parEprNum,
        (object) parTemplateDocID,
        (object) parHappenDate,
        (object) parHappenTime,
        (object) parIP,
        (object) parUserID,
        (object) parTemplateID
      })[0]);
    }

    public void InitAfterSingleOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID)
    {
      this.InitAfterSingleOperAsync(parAction, parEpisodeID, parEprDocID, parEprNum, parTemplateDocID, parHappenDate, parHappenTime, parIP, parUserID, parTemplateID, (object) null);
    }

    public void InitAfterSingleOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID, object userState)
    {
      if (this.InitAfterSingleOperOperationCompleted == null)
        this.InitAfterSingleOperOperationCompleted = new SendOrPostCallback(this.OnInitAfterSingleOperOperationCompleted);
      this.InvokeAsync("InitAfterSingleOper", new object[10]
      {
        (object) parAction,
        (object) parEpisodeID,
        (object) parEprDocID,
        (object) parEprNum,
        (object) parTemplateDocID,
        (object) parHappenDate,
        (object) parHappenTime,
        (object) parIP,
        (object) parUserID,
        (object) parTemplateID
      }, this.InitAfterSingleOperOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnInitAfterSingleOperOperationCompleted(object arg)
    {
      if (this.InitAfterSingleOperCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      InitAfterSingleOperCompletedEventHandler operCompletedEvent = this.InitAfterSingleOperCompletedEvent;
      if (operCompletedEvent == null)
        return;
      operCompletedEvent((object) this, new InitAfterSingleOperCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ReplaceGroupData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData ReplaceGroupData(string AInstanceID, string ATemplateID, string ATemplateName)
    {
      return (EInstanceData) this.Invoke("ReplaceGroupData", new object[3]
      {
        (object) AInstanceID,
        (object) ATemplateID,
        (object) ATemplateName
      })[0];
    }

    public void ReplaceGroupDataAsync(string AInstanceID, string ATemplateID, string ATemplateName)
    {
      this.ReplaceGroupDataAsync(AInstanceID, ATemplateID, ATemplateName, (object) null);
    }

    public void ReplaceGroupDataAsync(string AInstanceID, string ATemplateID, string ATemplateName, object userState)
    {
      if (this.ReplaceGroupDataOperationCompleted == null)
        this.ReplaceGroupDataOperationCompleted = new SendOrPostCallback(this.OnReplaceGroupDataOperationCompleted);
      this.InvokeAsync("ReplaceGroupData", new object[3]
      {
        (object) AInstanceID,
        (object) ATemplateID,
        (object) ATemplateName
      }, this.ReplaceGroupDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnReplaceGroupDataOperationCompleted(object arg)
    {
      if (this.ReplaceGroupDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ReplaceGroupDataCompletedEventHandler dataCompletedEvent = this.ReplaceGroupDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new ReplaceGroupDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ReplaceTemplateData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData ReplaceTemplateData(string AInstanceID, string ATemplateID)
    {
      return (EInstanceData) this.Invoke("ReplaceTemplateData", new object[2]
      {
        (object) AInstanceID,
        (object) ATemplateID
      })[0];
    }

    public void ReplaceTemplateDataAsync(string AInstanceID, string ATemplateID)
    {
      this.ReplaceTemplateDataAsync(AInstanceID, ATemplateID, (object) null);
    }

    public void ReplaceTemplateDataAsync(string AInstanceID, string ATemplateID, object userState)
    {
      if (this.ReplaceTemplateDataOperationCompleted == null)
        this.ReplaceTemplateDataOperationCompleted = new SendOrPostCallback(this.OnReplaceTemplateDataOperationCompleted);
      this.InvokeAsync("ReplaceTemplateData", new object[2]
      {
        (object) AInstanceID,
        (object) ATemplateID
      }, this.ReplaceTemplateDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnReplaceTemplateDataOperationCompleted(object arg)
    {
      if (this.ReplaceTemplateDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      ReplaceTemplateDataCompletedEventHandler dataCompletedEvent = this.ReplaceTemplateDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new ReplaceTemplateDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.SaveData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData SaveData(EInstanceData AEInstanceData, ref EMixInstanceLog AEMixInstanceLog, ref string AErrorMessage)
    {
      object[] objArray = this.Invoke("SaveData", new object[3]
      {
        (object) AEInstanceData,
        (object) AEMixInstanceLog,
        (object) AErrorMessage
      });
      AEMixInstanceLog = (EMixInstanceLog) objArray[1];
      AErrorMessage = Conversions.ToString(objArray[2]);
      return (EInstanceData) objArray[0];
    }

    public void SaveDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage)
    {
      this.SaveDataAsync(AEInstanceData, AEMixInstanceLog, AErrorMessage, (object) null);
    }

    public void SaveDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage, object userState)
    {
      if (this.SaveDataOperationCompleted == null)
        this.SaveDataOperationCompleted = new SendOrPostCallback(this.OnSaveDataOperationCompleted);
      this.InvokeAsync("SaveData", new object[3]
      {
        (object) AEInstanceData,
        (object) AEMixInstanceLog,
        (object) AErrorMessage
      }, this.SaveDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSaveDataOperationCompleted(object arg)
    {
      if (this.SaveDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SaveDataCompletedEventHandler dataCompletedEvent = this.SaveDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new SaveDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.SaveMultipleData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public EInstanceData SaveMultipleData(EInstanceData AEInstanceData, ref EMixInstanceLog AEMixInstanceLog, ref string AErrorMessage)
    {
      object[] objArray = this.Invoke("SaveMultipleData", new object[3]
      {
        (object) AEInstanceData,
        (object) AEMixInstanceLog,
        (object) AErrorMessage
      });
      AEMixInstanceLog = (EMixInstanceLog) objArray[1];
      AErrorMessage = Conversions.ToString(objArray[2]);
      return (EInstanceData) objArray[0];
    }

    public void SaveMultipleDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage)
    {
      this.SaveMultipleDataAsync(AEInstanceData, AEMixInstanceLog, AErrorMessage, (object) null);
    }

    public void SaveMultipleDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage, object userState)
    {
      if (this.SaveMultipleDataOperationCompleted == null)
        this.SaveMultipleDataOperationCompleted = new SendOrPostCallback(this.OnSaveMultipleDataOperationCompleted);
      this.InvokeAsync("SaveMultipleData", new object[3]
      {
        (object) AEInstanceData,
        (object) AEMixInstanceLog,
        (object) AErrorMessage
      }, this.SaveMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnSaveMultipleDataOperationCompleted(object arg)
    {
      if (this.SaveMultipleDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      SaveMultipleDataCompletedEventHandler dataCompletedEvent = this.SaveMultipleDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new SaveMultipleDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.TestSaveMultipleData", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string TestSaveMultipleData(string aId)
    {
      return Conversions.ToString(this.Invoke("TestSaveMultipleData", new object[1]
      {
        (object) aId
      })[0]);
    }

    public void TestSaveMultipleDataAsync(string aId)
    {
      this.TestSaveMultipleDataAsync(aId, (object) null);
    }

    public void TestSaveMultipleDataAsync(string aId, object userState)
    {
      if (this.TestSaveMultipleDataOperationCompleted == null)
        this.TestSaveMultipleDataOperationCompleted = new SendOrPostCallback(this.OnTestSaveMultipleDataOperationCompleted);
      this.InvokeAsync("TestSaveMultipleData", new object[1]
      {
        (object) aId
      }, this.TestSaveMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnTestSaveMultipleDataOperationCompleted(object arg)
    {
      if (this.TestSaveMultipleDataCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      TestSaveMultipleDataCompletedEventHandler dataCompletedEvent = this.TestSaveMultipleDataCompletedEvent;
      if (dataCompletedEvent == null)
        return;
      dataCompletedEvent((object) this, new TestSaveMultipleDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
    }

    [SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.UpdateEPRLogs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal)]
    public string UpdateEPRLogs(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID)
    {
      return Conversions.ToString(this.Invoke("UpdateEPRLogs", new object[5]
      {
        (object) parEpisodeID,
        (object) parAllStr,
        (object) parAction,
        (object) parIP,
        (object) parUserID
      })[0]);
    }

    public void UpdateEPRLogsAsync(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID)
    {
      this.UpdateEPRLogsAsync(parEpisodeID, parAllStr, parAction, parIP, parUserID, (object) null);
    }

    public void UpdateEPRLogsAsync(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID, object userState)
    {
      if (this.UpdateEPRLogsOperationCompleted == null)
        this.UpdateEPRLogsOperationCompleted = new SendOrPostCallback(this.OnUpdateEPRLogsOperationCompleted);
      this.InvokeAsync("UpdateEPRLogs", new object[5]
      {
        (object) parEpisodeID,
        (object) parAllStr,
        (object) parAction,
        (object) parIP,
        (object) parUserID
      }, this.UpdateEPRLogsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
    }

    private void OnUpdateEPRLogsOperationCompleted(object arg)
    {
      if (this.UpdateEPRLogsCompletedEvent == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      UpdateEPRLogsCompletedEventHandler logsCompletedEvent = this.UpdateEPRLogsCompletedEvent;
      if (logsCompletedEvent == null)
        return;
      logsCompletedEvent((object) this, new UpdateEPRLogsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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
