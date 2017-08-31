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

namespace InstanceDataInfo
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "InstanceDataInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
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

		private SendOrPostCallback GetKBDiagnosIDByEpisodeIDOperationCompleted;

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

		private AddInstanceLogCompletedEventHandler AddInstanceLogCompletedEvent;

		private AddLogCompletedEventHandler AddLogCompletedEvent;

		private ChangeStatusCompletedEventHandler ChangeStatusCompletedEvent;

		private CheckFinalStatusCompletedEventHandler CheckFinalStatusCompletedEvent;

		private CheckHappenDateTimeValidCompletedEventHandler CheckHappenDateTimeValidCompletedEvent;

		private ClearLogCompletedEventHandler ClearLogCompletedEvent;

		private GetAllLogsCompletedEventHandler GetAllLogsCompletedEvent;

		private GetCurrentStatusCompletedEventHandler GetCurrentStatusCompletedEvent;

		private GetDataCompletedEventHandler GetDataCompletedEvent;

		private GetDataByIDCompletedEventHandler GetDataByIDCompletedEvent;

		private GetDataByInstanceIDCompletedEventHandler GetDataByInstanceIDCompletedEvent;

		private GetDescDataByIDCompletedEventHandler GetDescDataByIDCompletedEvent;

		private GetFinalLogCompletedEventHandler GetFinalLogCompletedEvent;

		private GetGroupDataByIDCompletedEventHandler GetGroupDataByIDCompletedEvent;

		private GetGroupItemListCompletedEventHandler GetGroupItemListCompletedEvent;

		private GetInstanceDataCompletedEventHandler GetInstanceDataCompletedEvent;

		private GetKBDiagnosIDByEpisodeIDCompletedEventHandler GetKBDiagnosIDByEpisodeIDCompletedEvent;

		private GetMultipleDataCompletedEventHandler GetMultipleDataCompletedEvent;

		private GetNormalDataCompletedEventHandler GetNormalDataCompletedEvent;

		private GetNormalDataOldCompletedEventHandler GetNormalDataOldCompletedEvent;

		private GetParentGroupListCompletedEventHandler GetParentGroupListCompletedEvent;

		private GetRefInstanceIDCompletedEventHandler GetRefInstanceIDCompletedEvent;

		private GetTemplateIDByIDCompletedEventHandler GetTemplateIDByIDCompletedEvent;

		private ImportInstanceDataCompletedEventHandler ImportInstanceDataCompletedEvent;

		private InitAfterMultiOperCompletedEventHandler InitAfterMultiOperCompletedEvent;

		private InitAfterSingleOperCompletedEventHandler InitAfterSingleOperCompletedEvent;

		private ReplaceGroupDataCompletedEventHandler ReplaceGroupDataCompletedEvent;

		private ReplaceTemplateDataCompletedEventHandler ReplaceTemplateDataCompletedEvent;

		private SaveDataCompletedEventHandler SaveDataCompletedEvent;

		private SaveMultipleDataCompletedEventHandler SaveMultipleDataCompletedEvent;

		private TestSaveMultipleDataCompletedEventHandler TestSaveMultipleDataCompletedEvent;

		private UpdateEPRLogsCompletedEventHandler UpdateEPRLogsCompletedEvent;

		public event AddInstanceLogCompletedEventHandler AddInstanceLogCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddInstanceLogCompletedEvent = (AddInstanceLogCompletedEventHandler)Delegate.Combine(this.AddInstanceLogCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddInstanceLogCompletedEvent = (AddInstanceLogCompletedEventHandler)Delegate.Remove(this.AddInstanceLogCompletedEvent, value);
			}
		}

		public event AddLogCompletedEventHandler AddLogCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddLogCompletedEvent = (AddLogCompletedEventHandler)Delegate.Combine(this.AddLogCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddLogCompletedEvent = (AddLogCompletedEventHandler)Delegate.Remove(this.AddLogCompletedEvent, value);
			}
		}

		public event ChangeStatusCompletedEventHandler ChangeStatusCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ChangeStatusCompletedEvent = (ChangeStatusCompletedEventHandler)Delegate.Combine(this.ChangeStatusCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ChangeStatusCompletedEvent = (ChangeStatusCompletedEventHandler)Delegate.Remove(this.ChangeStatusCompletedEvent, value);
			}
		}

		public event CheckFinalStatusCompletedEventHandler CheckFinalStatusCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CheckFinalStatusCompletedEvent = (CheckFinalStatusCompletedEventHandler)Delegate.Combine(this.CheckFinalStatusCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CheckFinalStatusCompletedEvent = (CheckFinalStatusCompletedEventHandler)Delegate.Remove(this.CheckFinalStatusCompletedEvent, value);
			}
		}

		public event CheckHappenDateTimeValidCompletedEventHandler CheckHappenDateTimeValidCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CheckHappenDateTimeValidCompletedEvent = (CheckHappenDateTimeValidCompletedEventHandler)Delegate.Combine(this.CheckHappenDateTimeValidCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CheckHappenDateTimeValidCompletedEvent = (CheckHappenDateTimeValidCompletedEventHandler)Delegate.Remove(this.CheckHappenDateTimeValidCompletedEvent, value);
			}
		}

		public event ClearLogCompletedEventHandler ClearLogCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ClearLogCompletedEvent = (ClearLogCompletedEventHandler)Delegate.Combine(this.ClearLogCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ClearLogCompletedEvent = (ClearLogCompletedEventHandler)Delegate.Remove(this.ClearLogCompletedEvent, value);
			}
		}

		public event GetAllLogsCompletedEventHandler GetAllLogsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllLogsCompletedEvent = (GetAllLogsCompletedEventHandler)Delegate.Combine(this.GetAllLogsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllLogsCompletedEvent = (GetAllLogsCompletedEventHandler)Delegate.Remove(this.GetAllLogsCompletedEvent, value);
			}
		}

		public event GetCurrentStatusCompletedEventHandler GetCurrentStatusCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetCurrentStatusCompletedEvent = (GetCurrentStatusCompletedEventHandler)Delegate.Combine(this.GetCurrentStatusCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetCurrentStatusCompletedEvent = (GetCurrentStatusCompletedEventHandler)Delegate.Remove(this.GetCurrentStatusCompletedEvent, value);
			}
		}

		public event GetDataCompletedEventHandler GetDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDataCompletedEvent = (GetDataCompletedEventHandler)Delegate.Combine(this.GetDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDataCompletedEvent = (GetDataCompletedEventHandler)Delegate.Remove(this.GetDataCompletedEvent, value);
			}
		}

		public event GetDataByIDCompletedEventHandler GetDataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDataByIDCompletedEvent = (GetDataByIDCompletedEventHandler)Delegate.Combine(this.GetDataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDataByIDCompletedEvent = (GetDataByIDCompletedEventHandler)Delegate.Remove(this.GetDataByIDCompletedEvent, value);
			}
		}

		public event GetDataByInstanceIDCompletedEventHandler GetDataByInstanceIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDataByInstanceIDCompletedEvent = (GetDataByInstanceIDCompletedEventHandler)Delegate.Combine(this.GetDataByInstanceIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDataByInstanceIDCompletedEvent = (GetDataByInstanceIDCompletedEventHandler)Delegate.Remove(this.GetDataByInstanceIDCompletedEvent, value);
			}
		}

		public event GetDescDataByIDCompletedEventHandler GetDescDataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDescDataByIDCompletedEvent = (GetDescDataByIDCompletedEventHandler)Delegate.Combine(this.GetDescDataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDescDataByIDCompletedEvent = (GetDescDataByIDCompletedEventHandler)Delegate.Remove(this.GetDescDataByIDCompletedEvent, value);
			}
		}

		public event GetFinalLogCompletedEventHandler GetFinalLogCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetFinalLogCompletedEvent = (GetFinalLogCompletedEventHandler)Delegate.Combine(this.GetFinalLogCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetFinalLogCompletedEvent = (GetFinalLogCompletedEventHandler)Delegate.Remove(this.GetFinalLogCompletedEvent, value);
			}
		}

		public event GetGroupDataByIDCompletedEventHandler GetGroupDataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetGroupDataByIDCompletedEvent = (GetGroupDataByIDCompletedEventHandler)Delegate.Combine(this.GetGroupDataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetGroupDataByIDCompletedEvent = (GetGroupDataByIDCompletedEventHandler)Delegate.Remove(this.GetGroupDataByIDCompletedEvent, value);
			}
		}

		public event GetGroupItemListCompletedEventHandler GetGroupItemListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetGroupItemListCompletedEvent = (GetGroupItemListCompletedEventHandler)Delegate.Combine(this.GetGroupItemListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetGroupItemListCompletedEvent = (GetGroupItemListCompletedEventHandler)Delegate.Remove(this.GetGroupItemListCompletedEvent, value);
			}
		}

		public event GetInstanceDataCompletedEventHandler GetInstanceDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetInstanceDataCompletedEvent = (GetInstanceDataCompletedEventHandler)Delegate.Combine(this.GetInstanceDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetInstanceDataCompletedEvent = (GetInstanceDataCompletedEventHandler)Delegate.Remove(this.GetInstanceDataCompletedEvent, value);
			}
		}

		public event GetKBDiagnosIDByEpisodeIDCompletedEventHandler GetKBDiagnosIDByEpisodeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetKBDiagnosIDByEpisodeIDCompletedEvent = (GetKBDiagnosIDByEpisodeIDCompletedEventHandler)Delegate.Combine(this.GetKBDiagnosIDByEpisodeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetKBDiagnosIDByEpisodeIDCompletedEvent = (GetKBDiagnosIDByEpisodeIDCompletedEventHandler)Delegate.Remove(this.GetKBDiagnosIDByEpisodeIDCompletedEvent, value);
			}
		}

		public event GetMultipleDataCompletedEventHandler GetMultipleDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetMultipleDataCompletedEvent = (GetMultipleDataCompletedEventHandler)Delegate.Combine(this.GetMultipleDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetMultipleDataCompletedEvent = (GetMultipleDataCompletedEventHandler)Delegate.Remove(this.GetMultipleDataCompletedEvent, value);
			}
		}

		public event GetNormalDataCompletedEventHandler GetNormalDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetNormalDataCompletedEvent = (GetNormalDataCompletedEventHandler)Delegate.Combine(this.GetNormalDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetNormalDataCompletedEvent = (GetNormalDataCompletedEventHandler)Delegate.Remove(this.GetNormalDataCompletedEvent, value);
			}
		}

		public event GetNormalDataOldCompletedEventHandler GetNormalDataOldCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetNormalDataOldCompletedEvent = (GetNormalDataOldCompletedEventHandler)Delegate.Combine(this.GetNormalDataOldCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetNormalDataOldCompletedEvent = (GetNormalDataOldCompletedEventHandler)Delegate.Remove(this.GetNormalDataOldCompletedEvent, value);
			}
		}

		public event GetParentGroupListCompletedEventHandler GetParentGroupListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetParentGroupListCompletedEvent = (GetParentGroupListCompletedEventHandler)Delegate.Combine(this.GetParentGroupListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetParentGroupListCompletedEvent = (GetParentGroupListCompletedEventHandler)Delegate.Remove(this.GetParentGroupListCompletedEvent, value);
			}
		}

		public event GetRefInstanceIDCompletedEventHandler GetRefInstanceIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetRefInstanceIDCompletedEvent = (GetRefInstanceIDCompletedEventHandler)Delegate.Combine(this.GetRefInstanceIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetRefInstanceIDCompletedEvent = (GetRefInstanceIDCompletedEventHandler)Delegate.Remove(this.GetRefInstanceIDCompletedEvent, value);
			}
		}

		public event GetTemplateIDByIDCompletedEventHandler GetTemplateIDByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateIDByIDCompletedEvent = (GetTemplateIDByIDCompletedEventHandler)Delegate.Combine(this.GetTemplateIDByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateIDByIDCompletedEvent = (GetTemplateIDByIDCompletedEventHandler)Delegate.Remove(this.GetTemplateIDByIDCompletedEvent, value);
			}
		}

		public event ImportInstanceDataCompletedEventHandler ImportInstanceDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ImportInstanceDataCompletedEvent = (ImportInstanceDataCompletedEventHandler)Delegate.Combine(this.ImportInstanceDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ImportInstanceDataCompletedEvent = (ImportInstanceDataCompletedEventHandler)Delegate.Remove(this.ImportInstanceDataCompletedEvent, value);
			}
		}

		public event InitAfterMultiOperCompletedEventHandler InitAfterMultiOperCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.InitAfterMultiOperCompletedEvent = (InitAfterMultiOperCompletedEventHandler)Delegate.Combine(this.InitAfterMultiOperCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.InitAfterMultiOperCompletedEvent = (InitAfterMultiOperCompletedEventHandler)Delegate.Remove(this.InitAfterMultiOperCompletedEvent, value);
			}
		}

		public event InitAfterSingleOperCompletedEventHandler InitAfterSingleOperCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.InitAfterSingleOperCompletedEvent = (InitAfterSingleOperCompletedEventHandler)Delegate.Combine(this.InitAfterSingleOperCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.InitAfterSingleOperCompletedEvent = (InitAfterSingleOperCompletedEventHandler)Delegate.Remove(this.InitAfterSingleOperCompletedEvent, value);
			}
		}

		public event ReplaceGroupDataCompletedEventHandler ReplaceGroupDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ReplaceGroupDataCompletedEvent = (ReplaceGroupDataCompletedEventHandler)Delegate.Combine(this.ReplaceGroupDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ReplaceGroupDataCompletedEvent = (ReplaceGroupDataCompletedEventHandler)Delegate.Remove(this.ReplaceGroupDataCompletedEvent, value);
			}
		}

		public event ReplaceTemplateDataCompletedEventHandler ReplaceTemplateDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ReplaceTemplateDataCompletedEvent = (ReplaceTemplateDataCompletedEventHandler)Delegate.Combine(this.ReplaceTemplateDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ReplaceTemplateDataCompletedEvent = (ReplaceTemplateDataCompletedEventHandler)Delegate.Remove(this.ReplaceTemplateDataCompletedEvent, value);
			}
		}

		public event SaveDataCompletedEventHandler SaveDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveDataCompletedEvent = (SaveDataCompletedEventHandler)Delegate.Combine(this.SaveDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveDataCompletedEvent = (SaveDataCompletedEventHandler)Delegate.Remove(this.SaveDataCompletedEvent, value);
			}
		}

		public event SaveMultipleDataCompletedEventHandler SaveMultipleDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveMultipleDataCompletedEvent = (SaveMultipleDataCompletedEventHandler)Delegate.Combine(this.SaveMultipleDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveMultipleDataCompletedEvent = (SaveMultipleDataCompletedEventHandler)Delegate.Remove(this.SaveMultipleDataCompletedEvent, value);
			}
		}

		public event TestSaveMultipleDataCompletedEventHandler TestSaveMultipleDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.TestSaveMultipleDataCompletedEvent = (TestSaveMultipleDataCompletedEventHandler)Delegate.Combine(this.TestSaveMultipleDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.TestSaveMultipleDataCompletedEvent = (TestSaveMultipleDataCompletedEventHandler)Delegate.Remove(this.TestSaveMultipleDataCompletedEvent, value);
			}
		}

		public event UpdateEPRLogsCompletedEventHandler UpdateEPRLogsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateEPRLogsCompletedEvent = (UpdateEPRLogsCompletedEventHandler)Delegate.Combine(this.UpdateEPRLogsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateEPRLogsCompletedEvent = (UpdateEPRLogsCompletedEventHandler)Delegate.Remove(this.UpdateEPRLogsCompletedEvent, value);
			}
		}

		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.UseDefaultCredentials = false;
				}
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

		public InstanceDataInfo()
		{
			this.Url = MySettings.Default.EPRLib_InstanceDataInfo_InstanceDataInfo;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.AddInstanceLog", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddInstanceLog(string parInstanceID, EMixInstanceLog parLog)
		{
			object[] array = this.Invoke("AddInstanceLog", new object[]
			{
				parInstanceID,
				parLog
			});
			return Conversions.ToString(array[0]);
		}

		public void AddInstanceLogAsync(string parInstanceID, EMixInstanceLog parLog)
		{
			this.AddInstanceLogAsync(parInstanceID, parLog, null);
		}

		public void AddInstanceLogAsync(string parInstanceID, EMixInstanceLog parLog, object userState)
		{
			if (this.AddInstanceLogOperationCompleted == null)
			{
				this.AddInstanceLogOperationCompleted = new SendOrPostCallback(this.OnAddInstanceLogOperationCompleted);
			}
			this.InvokeAsync("AddInstanceLog", new object[]
			{
				parInstanceID,
				parLog
			}, this.AddInstanceLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddInstanceLogOperationCompleted(object arg)
		{
			if (this.AddInstanceLogCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddInstanceLogCompletedEventHandler addInstanceLogCompletedEvent = this.AddInstanceLogCompletedEvent;
				if (addInstanceLogCompletedEvent != null)
				{
					addInstanceLogCompletedEvent(this, new AddInstanceLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.AddLog", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddLog(string parInstanceID, EInstanceLog parLog)
		{
			object[] array = this.Invoke("AddLog", new object[]
			{
				parInstanceID,
				parLog
			});
			return Conversions.ToString(array[0]);
		}

		public void AddLogAsync(string parInstanceID, EInstanceLog parLog)
		{
			this.AddLogAsync(parInstanceID, parLog, null);
		}

		public void AddLogAsync(string parInstanceID, EInstanceLog parLog, object userState)
		{
			if (this.AddLogOperationCompleted == null)
			{
				this.AddLogOperationCompleted = new SendOrPostCallback(this.OnAddLogOperationCompleted);
			}
			this.InvokeAsync("AddLog", new object[]
			{
				parInstanceID,
				parLog
			}, this.AddLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddLogOperationCompleted(object arg)
		{
			if (this.AddLogCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddLogCompletedEventHandler addLogCompletedEvent = this.AddLogCompletedEvent;
				if (addLogCompletedEvent != null)
				{
					addLogCompletedEvent(this, new AddLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ChangeStatus", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string ChangeStatus(string parInstanceID, string parStatus)
		{
			object[] array = this.Invoke("ChangeStatus", new object[]
			{
				parInstanceID,
				parStatus
			});
			return Conversions.ToString(array[0]);
		}

		public void ChangeStatusAsync(string parInstanceID, string parStatus)
		{
			this.ChangeStatusAsync(parInstanceID, parStatus, null);
		}

		public void ChangeStatusAsync(string parInstanceID, string parStatus, object userState)
		{
			if (this.ChangeStatusOperationCompleted == null)
			{
				this.ChangeStatusOperationCompleted = new SendOrPostCallback(this.OnChangeStatusOperationCompleted);
			}
			this.InvokeAsync("ChangeStatus", new object[]
			{
				parInstanceID,
				parStatus
			}, this.ChangeStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnChangeStatusOperationCompleted(object arg)
		{
			if (this.ChangeStatusCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ChangeStatusCompletedEventHandler changeStatusCompletedEvent = this.ChangeStatusCompletedEvent;
				if (changeStatusCompletedEvent != null)
				{
					changeStatusCompletedEvent(this, new ChangeStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.CheckFinalStatus", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckFinalStatus(string AInstanceID, string parStatusStr)
		{
			object[] array = this.Invoke("CheckFinalStatus", new object[]
			{
				AInstanceID,
				parStatusStr
			});
			return Conversions.ToString(array[0]);
		}

		public void CheckFinalStatusAsync(string AInstanceID, string parStatusStr)
		{
			this.CheckFinalStatusAsync(AInstanceID, parStatusStr, null);
		}

		public void CheckFinalStatusAsync(string AInstanceID, string parStatusStr, object userState)
		{
			if (this.CheckFinalStatusOperationCompleted == null)
			{
				this.CheckFinalStatusOperationCompleted = new SendOrPostCallback(this.OnCheckFinalStatusOperationCompleted);
			}
			this.InvokeAsync("CheckFinalStatus", new object[]
			{
				AInstanceID,
				parStatusStr
			}, this.CheckFinalStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCheckFinalStatusOperationCompleted(object arg)
		{
			if (this.CheckFinalStatusCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CheckFinalStatusCompletedEventHandler checkFinalStatusCompletedEvent = this.CheckFinalStatusCompletedEvent;
				if (checkFinalStatusCompletedEvent != null)
				{
					checkFinalStatusCompletedEvent(this, new CheckFinalStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.CheckHappenDateTimeValid", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckHappenDateTimeValid(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime)
		{
			object[] array = this.Invoke("CheckHappenDateTimeValid", new object[]
			{
				AECRecord,
				AInstanceID,
				AHappendDate,
				AHappendTime
			});
			return Conversions.ToString(array[0]);
		}

		public void CheckHappenDateTimeValidAsync(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime)
		{
			this.CheckHappenDateTimeValidAsync(AECRecord, AInstanceID, AHappendDate, AHappendTime, null);
		}

		public void CheckHappenDateTimeValidAsync(string AECRecord, string AInstanceID, string AHappendDate, string AHappendTime, object userState)
		{
			if (this.CheckHappenDateTimeValidOperationCompleted == null)
			{
				this.CheckHappenDateTimeValidOperationCompleted = new SendOrPostCallback(this.OnCheckHappenDateTimeValidOperationCompleted);
			}
			this.InvokeAsync("CheckHappenDateTimeValid", new object[]
			{
				AECRecord,
				AInstanceID,
				AHappendDate,
				AHappendTime
			}, this.CheckHappenDateTimeValidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCheckHappenDateTimeValidOperationCompleted(object arg)
		{
			if (this.CheckHappenDateTimeValidCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CheckHappenDateTimeValidCompletedEventHandler checkHappenDateTimeValidCompletedEvent = this.CheckHappenDateTimeValidCompletedEvent;
				if (checkHappenDateTimeValidCompletedEvent != null)
				{
					checkHappenDateTimeValidCompletedEvent(this, new CheckHappenDateTimeValidCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ClearLog", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string ClearLog(string parInstanceID)
		{
			object[] array = this.Invoke("ClearLog", new object[]
			{
				parInstanceID
			});
			return Conversions.ToString(array[0]);
		}

		public void ClearLogAsync(string parInstanceID)
		{
			this.ClearLogAsync(parInstanceID, null);
		}

		public void ClearLogAsync(string parInstanceID, object userState)
		{
			if (this.ClearLogOperationCompleted == null)
			{
				this.ClearLogOperationCompleted = new SendOrPostCallback(this.OnClearLogOperationCompleted);
			}
			this.InvokeAsync("ClearLog", new object[]
			{
				parInstanceID
			}, this.ClearLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnClearLogOperationCompleted(object arg)
		{
			if (this.ClearLogCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ClearLogCompletedEventHandler clearLogCompletedEvent = this.ClearLogCompletedEvent;
				if (clearLogCompletedEvent != null)
				{
					clearLogCompletedEvent(this, new ClearLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetAllLogs", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetAllLogs(string AInstanceID)
		{
			object[] array = this.Invoke("GetAllLogs", new object[]
			{
				AInstanceID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetAllLogsAsync(string AInstanceID)
		{
			this.GetAllLogsAsync(AInstanceID, null);
		}

		public void GetAllLogsAsync(string AInstanceID, object userState)
		{
			if (this.GetAllLogsOperationCompleted == null)
			{
				this.GetAllLogsOperationCompleted = new SendOrPostCallback(this.OnGetAllLogsOperationCompleted);
			}
			this.InvokeAsync("GetAllLogs", new object[]
			{
				AInstanceID
			}, this.GetAllLogsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllLogsOperationCompleted(object arg)
		{
			if (this.GetAllLogsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllLogsCompletedEventHandler getAllLogsCompletedEvent = this.GetAllLogsCompletedEvent;
				if (getAllLogsCompletedEvent != null)
				{
					getAllLogsCompletedEvent(this, new GetAllLogsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetCurrentStatus", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetCurrentStatus(string parInstanceID)
		{
			object[] array = this.Invoke("GetCurrentStatus", new object[]
			{
				parInstanceID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetCurrentStatusAsync(string parInstanceID)
		{
			this.GetCurrentStatusAsync(parInstanceID, null);
		}

		public void GetCurrentStatusAsync(string parInstanceID, object userState)
		{
			if (this.GetCurrentStatusOperationCompleted == null)
			{
				this.GetCurrentStatusOperationCompleted = new SendOrPostCallback(this.OnGetCurrentStatusOperationCompleted);
			}
			this.InvokeAsync("GetCurrentStatus", new object[]
			{
				parInstanceID
			}, this.GetCurrentStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetCurrentStatusOperationCompleted(object arg)
		{
			if (this.GetCurrentStatusCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetCurrentStatusCompletedEventHandler getCurrentStatusCompletedEvent = this.GetCurrentStatusCompletedEvent;
				if (getCurrentStatusCompletedEvent != null)
				{
					getCurrentStatusCompletedEvent(this, new GetCurrentStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetData(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID)
		{
			object[] array = this.Invoke("GetData", new object[]
			{
				APatientID,
				AEpisodeID,
				AChartItemID,
				AChartItemType,
				AChartListNo,
				ATemplateID
			});
			return (EInstanceData)array[0];
		}

		public void GetDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID)
		{
			this.GetDataAsync(APatientID, AEpisodeID, AChartItemID, AChartItemType, AChartListNo, ATemplateID, null);
		}

		public void GetDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, object userState)
		{
			if (this.GetDataOperationCompleted == null)
			{
				this.GetDataOperationCompleted = new SendOrPostCallback(this.OnGetDataOperationCompleted);
			}
			this.InvokeAsync("GetData", new object[]
			{
				APatientID,
				AEpisodeID,
				AChartItemID,
				AChartItemType,
				AChartListNo,
				ATemplateID
			}, this.GetDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDataOperationCompleted(object arg)
		{
			if (this.GetDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDataCompletedEventHandler getDataCompletedEvent = this.GetDataCompletedEvent;
				if (getDataCompletedEvent != null)
				{
					getDataCompletedEvent(this, new GetDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetDataByID(string AID)
		{
			object[] array = this.Invoke("GetDataByID", new object[]
			{
				AID
			});
			return (EInstanceData)array[0];
		}

		public void GetDataByIDAsync(string AID)
		{
			this.GetDataByIDAsync(AID, null);
		}

		public void GetDataByIDAsync(string AID, object userState)
		{
			if (this.GetDataByIDOperationCompleted == null)
			{
				this.GetDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetDataByIDOperationCompleted);
			}
			this.InvokeAsync("GetDataByID", new object[]
			{
				AID
			}, this.GetDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDataByIDOperationCompleted(object arg)
		{
			if (this.GetDataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDataByIDCompletedEventHandler getDataByIDCompletedEvent = this.GetDataByIDCompletedEvent;
				if (getDataByIDCompletedEvent != null)
				{
					getDataByIDCompletedEvent(this, new GetDataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDataByInstanceID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ReStreamData GetDataByInstanceID(string AInstanceDataID)
		{
			object[] array = this.Invoke("GetDataByInstanceID", new object[]
			{
				AInstanceDataID
			});
			return (ReStreamData)array[0];
		}

		public void GetDataByInstanceIDAsync(string AInstanceDataID)
		{
			this.GetDataByInstanceIDAsync(AInstanceDataID, null);
		}

		public void GetDataByInstanceIDAsync(string AInstanceDataID, object userState)
		{
			if (this.GetDataByInstanceIDOperationCompleted == null)
			{
				this.GetDataByInstanceIDOperationCompleted = new SendOrPostCallback(this.OnGetDataByInstanceIDOperationCompleted);
			}
			this.InvokeAsync("GetDataByInstanceID", new object[]
			{
				AInstanceDataID
			}, this.GetDataByInstanceIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDataByInstanceIDOperationCompleted(object arg)
		{
			if (this.GetDataByInstanceIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDataByInstanceIDCompletedEventHandler getDataByInstanceIDCompletedEvent = this.GetDataByInstanceIDCompletedEvent;
				if (getDataByInstanceIDCompletedEvent != null)
				{
					getDataByInstanceIDCompletedEvent(this, new GetDataByInstanceIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetDescDataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetDescDataByID(string AID)
		{
			object[] array = this.Invoke("GetDescDataByID", new object[]
			{
				AID
			});
			return (EInstanceData)array[0];
		}

		public void GetDescDataByIDAsync(string AID)
		{
			this.GetDescDataByIDAsync(AID, null);
		}

		public void GetDescDataByIDAsync(string AID, object userState)
		{
			if (this.GetDescDataByIDOperationCompleted == null)
			{
				this.GetDescDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetDescDataByIDOperationCompleted);
			}
			this.InvokeAsync("GetDescDataByID", new object[]
			{
				AID
			}, this.GetDescDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDescDataByIDOperationCompleted(object arg)
		{
			if (this.GetDescDataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDescDataByIDCompletedEventHandler getDescDataByIDCompletedEvent = this.GetDescDataByIDCompletedEvent;
				if (getDescDataByIDCompletedEvent != null)
				{
					getDescDataByIDCompletedEvent(this, new GetDescDataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetFinalLog", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceLog GetFinalLog(string AInstanceID)
		{
			object[] array = this.Invoke("GetFinalLog", new object[]
			{
				AInstanceID
			});
			return (EInstanceLog)array[0];
		}

		public void GetFinalLogAsync(string AInstanceID)
		{
			this.GetFinalLogAsync(AInstanceID, null);
		}

		public void GetFinalLogAsync(string AInstanceID, object userState)
		{
			if (this.GetFinalLogOperationCompleted == null)
			{
				this.GetFinalLogOperationCompleted = new SendOrPostCallback(this.OnGetFinalLogOperationCompleted);
			}
			this.InvokeAsync("GetFinalLog", new object[]
			{
				AInstanceID
			}, this.GetFinalLogOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetFinalLogOperationCompleted(object arg)
		{
			if (this.GetFinalLogCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetFinalLogCompletedEventHandler getFinalLogCompletedEvent = this.GetFinalLogCompletedEvent;
				if (getFinalLogCompletedEvent != null)
				{
					getFinalLogCompletedEvent(this, new GetFinalLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetGroupDataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetGroupDataByID(string AID)
		{
			object[] array = this.Invoke("GetGroupDataByID", new object[]
			{
				AID
			});
			return (EInstanceData)array[0];
		}

		public void GetGroupDataByIDAsync(string AID)
		{
			this.GetGroupDataByIDAsync(AID, null);
		}

		public void GetGroupDataByIDAsync(string AID, object userState)
		{
			if (this.GetGroupDataByIDOperationCompleted == null)
			{
				this.GetGroupDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetGroupDataByIDOperationCompleted);
			}
			this.InvokeAsync("GetGroupDataByID", new object[]
			{
				AID
			}, this.GetGroupDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetGroupDataByIDOperationCompleted(object arg)
		{
			if (this.GetGroupDataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetGroupDataByIDCompletedEventHandler getGroupDataByIDCompletedEvent = this.GetGroupDataByIDCompletedEvent;
				if (getGroupDataByIDCompletedEvent != null)
				{
					getGroupDataByIDCompletedEvent(this, new GetGroupDataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetGroupItemList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInsGroupNewDataSet GetGroupItemList(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			object[] array = this.Invoke("GetGroupItemList", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			});
			return (EInsGroupNewDataSet)array[0];
		}

		public void GetGroupItemListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			this.GetGroupItemListAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, null);
		}

		public void GetGroupItemListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
		{
			if (this.GetGroupItemListOperationCompleted == null)
			{
				this.GetGroupItemListOperationCompleted = new SendOrPostCallback(this.OnGetGroupItemListOperationCompleted);
			}
			this.InvokeAsync("GetGroupItemList", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			}, this.GetGroupItemListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetGroupItemListOperationCompleted(object arg)
		{
			if (this.GetGroupItemListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetGroupItemListCompletedEventHandler getGroupItemListCompletedEvent = this.GetGroupItemListCompletedEvent;
				if (getGroupItemListCompletedEvent != null)
				{
					getGroupItemListCompletedEvent(this, new GetGroupItemListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetInstanceData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetInstanceData(string aEpisodeId, string aTemplateId, string aMountCategoryId)
		{
			object[] array = this.Invoke("GetInstanceData", new object[]
			{
				aEpisodeId,
				aTemplateId,
				aMountCategoryId
			});
			return (EInstanceData)array[0];
		}

		public void GetInstanceDataAsync(string aEpisodeId, string aTemplateId, string aMountCategoryId)
		{
			this.GetInstanceDataAsync(aEpisodeId, aTemplateId, aMountCategoryId, null);
		}

		public void GetInstanceDataAsync(string aEpisodeId, string aTemplateId, string aMountCategoryId, object userState)
		{
			if (this.GetInstanceDataOperationCompleted == null)
			{
				this.GetInstanceDataOperationCompleted = new SendOrPostCallback(this.OnGetInstanceDataOperationCompleted);
			}
			this.InvokeAsync("GetInstanceData", new object[]
			{
				aEpisodeId,
				aTemplateId,
				aMountCategoryId
			}, this.GetInstanceDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetInstanceDataOperationCompleted(object arg)
		{
			if (this.GetInstanceDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetInstanceDataCompletedEventHandler getInstanceDataCompletedEvent = this.GetInstanceDataCompletedEvent;
				if (getInstanceDataCompletedEvent != null)
				{
					getInstanceDataCompletedEvent(this, new GetInstanceDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetKBDiagnosIDByEpisodeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetKBDiagnosIDByEpisodeID(string AEpisodeID)
		{
			object[] array = this.Invoke("GetKBDiagnosIDByEpisodeID", new object[]
			{
				AEpisodeID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetKBDiagnosIDByEpisodeIDAsync(string AEpisodeID)
		{
			this.GetKBDiagnosIDByEpisodeIDAsync(AEpisodeID, null);
		}

		public void GetKBDiagnosIDByEpisodeIDAsync(string AEpisodeID, object userState)
		{
			if (this.GetKBDiagnosIDByEpisodeIDOperationCompleted == null)
			{
				this.GetKBDiagnosIDByEpisodeIDOperationCompleted = new SendOrPostCallback(this.OnGetKBDiagnosIDByEpisodeIDOperationCompleted);
			}
			this.InvokeAsync("GetKBDiagnosIDByEpisodeID", new object[]
			{
				AEpisodeID
			}, this.GetKBDiagnosIDByEpisodeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetKBDiagnosIDByEpisodeIDOperationCompleted(object arg)
		{
			if (this.GetKBDiagnosIDByEpisodeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetKBDiagnosIDByEpisodeIDCompletedEventHandler getKBDiagnosIDByEpisodeIDCompletedEvent = this.GetKBDiagnosIDByEpisodeIDCompletedEvent;
				if (getKBDiagnosIDByEpisodeIDCompletedEvent != null)
				{
					getKBDiagnosIDByEpisodeIDCompletedEvent(this, new GetKBDiagnosIDByEpisodeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetMultipleData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetMultipleData(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType)
		{
			object[] array = this.Invoke("GetMultipleData", new object[]
			{
				APatientID,
				AEpisodeID,
				AChartItemID,
				AChartItemType,
				AChartListNo,
				ATemplateID,
				ACategoryID,
				ACategoryType
			});
			return (EInstanceData)array[0];
		}

		public void GetMultipleDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType)
		{
			this.GetMultipleDataAsync(APatientID, AEpisodeID, AChartItemID, AChartItemType, AChartListNo, ATemplateID, ACategoryID, ACategoryType, null);
		}

		public void GetMultipleDataAsync(string APatientID, string AEpisodeID, string AChartItemID, string AChartItemType, string AChartListNo, string ATemplateID, string ACategoryID, string ACategoryType, object userState)
		{
			if (this.GetMultipleDataOperationCompleted == null)
			{
				this.GetMultipleDataOperationCompleted = new SendOrPostCallback(this.OnGetMultipleDataOperationCompleted);
			}
			this.InvokeAsync("GetMultipleData", new object[]
			{
				APatientID,
				AEpisodeID,
				AChartItemID,
				AChartItemType,
				AChartListNo,
				ATemplateID,
				ACategoryID,
				ACategoryType
			}, this.GetMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetMultipleDataOperationCompleted(object arg)
		{
			if (this.GetMultipleDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetMultipleDataCompletedEventHandler getMultipleDataCompletedEvent = this.GetMultipleDataCompletedEvent;
				if (getMultipleDataCompletedEvent != null)
				{
					getMultipleDataCompletedEvent(this, new GetMultipleDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetNormalData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetNormalData(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			object[] array = this.Invoke("GetNormalData", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			});
			return (EInstanceData)array[0];
		}

		public void GetNormalDataAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			this.GetNormalDataAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, null);
		}

		public void GetNormalDataAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
		{
			if (this.GetNormalDataOperationCompleted == null)
			{
				this.GetNormalDataOperationCompleted = new SendOrPostCallback(this.OnGetNormalDataOperationCompleted);
			}
			this.InvokeAsync("GetNormalData", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			}, this.GetNormalDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetNormalDataOperationCompleted(object arg)
		{
			if (this.GetNormalDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetNormalDataCompletedEventHandler getNormalDataCompletedEvent = this.GetNormalDataCompletedEvent;
				if (getNormalDataCompletedEvent != null)
				{
					getNormalDataCompletedEvent(this, new GetNormalDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetNormalDataOld", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData GetNormalDataOld(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			object[] array = this.Invoke("GetNormalDataOld", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			});
			return (EInstanceData)array[0];
		}

		public void GetNormalDataOldAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			this.GetNormalDataOldAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, null);
		}

		public void GetNormalDataOldAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
		{
			if (this.GetNormalDataOldOperationCompleted == null)
			{
				this.GetNormalDataOldOperationCompleted = new SendOrPostCallback(this.OnGetNormalDataOldOperationCompleted);
			}
			this.InvokeAsync("GetNormalDataOld", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			}, this.GetNormalDataOldOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetNormalDataOldOperationCompleted(object arg)
		{
			if (this.GetNormalDataOldCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetNormalDataOldCompletedEventHandler getNormalDataOldCompletedEvent = this.GetNormalDataOldCompletedEvent;
				if (getNormalDataOldCompletedEvent != null)
				{
					getNormalDataOldCompletedEvent(this, new GetNormalDataOldCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetParentGroupList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInsGroupNewDataSet GetParentGroupList(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			object[] array = this.Invoke("GetParentGroupList", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			});
			return (EInsGroupNewDataSet)array[0];
		}

		public void GetParentGroupListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID)
		{
			this.GetParentGroupListAsync(APatientID, AEpisodeID, AEpisodeType, AChartItemID, AChartItemType, ACategoryType, ACategoryID, null);
		}

		public void GetParentGroupListAsync(string APatientID, string AEpisodeID, string AEpisodeType, string AChartItemID, string AChartItemType, string ACategoryType, string ACategoryID, object userState)
		{
			if (this.GetParentGroupListOperationCompleted == null)
			{
				this.GetParentGroupListOperationCompleted = new SendOrPostCallback(this.OnGetParentGroupListOperationCompleted);
			}
			this.InvokeAsync("GetParentGroupList", new object[]
			{
				APatientID,
				AEpisodeID,
				AEpisodeType,
				AChartItemID,
				AChartItemType,
				ACategoryType,
				ACategoryID
			}, this.GetParentGroupListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetParentGroupListOperationCompleted(object arg)
		{
			if (this.GetParentGroupListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetParentGroupListCompletedEventHandler getParentGroupListCompletedEvent = this.GetParentGroupListCompletedEvent;
				if (getParentGroupListCompletedEvent != null)
				{
					getParentGroupListCompletedEvent(this, new GetParentGroupListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetRefInstanceID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetRefInstanceID(string AEpisodeID, string ATemplateID)
		{
			object[] array = this.Invoke("GetRefInstanceID", new object[]
			{
				AEpisodeID,
				ATemplateID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetRefInstanceIDAsync(string AEpisodeID, string ATemplateID)
		{
			this.GetRefInstanceIDAsync(AEpisodeID, ATemplateID, null);
		}

		public void GetRefInstanceIDAsync(string AEpisodeID, string ATemplateID, object userState)
		{
			if (this.GetRefInstanceIDOperationCompleted == null)
			{
				this.GetRefInstanceIDOperationCompleted = new SendOrPostCallback(this.OnGetRefInstanceIDOperationCompleted);
			}
			this.InvokeAsync("GetRefInstanceID", new object[]
			{
				AEpisodeID,
				ATemplateID
			}, this.GetRefInstanceIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetRefInstanceIDOperationCompleted(object arg)
		{
			if (this.GetRefInstanceIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetRefInstanceIDCompletedEventHandler getRefInstanceIDCompletedEvent = this.GetRefInstanceIDCompletedEvent;
				if (getRefInstanceIDCompletedEvent != null)
				{
					getRefInstanceIDCompletedEvent(this, new GetRefInstanceIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.GetTemplateIDByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetTemplateIDByID(string argInstanceId)
		{
			object[] array = this.Invoke("GetTemplateIDByID", new object[]
			{
				argInstanceId
			});
			return Conversions.ToString(array[0]);
		}

		public void GetTemplateIDByIDAsync(string argInstanceId)
		{
			this.GetTemplateIDByIDAsync(argInstanceId, null);
		}

		public void GetTemplateIDByIDAsync(string argInstanceId, object userState)
		{
			if (this.GetTemplateIDByIDOperationCompleted == null)
			{
				this.GetTemplateIDByIDOperationCompleted = new SendOrPostCallback(this.OnGetTemplateIDByIDOperationCompleted);
			}
			this.InvokeAsync("GetTemplateIDByID", new object[]
			{
				argInstanceId
			}, this.GetTemplateIDByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateIDByIDOperationCompleted(object arg)
		{
			if (this.GetTemplateIDByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateIDByIDCompletedEventHandler getTemplateIDByIDCompletedEvent = this.GetTemplateIDByIDCompletedEvent;
				if (getTemplateIDByIDCompletedEvent != null)
				{
					getTemplateIDByIDCompletedEvent(this, new GetTemplateIDByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ImportInstanceData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string ImportInstanceData(EInstanceData aEInstanceData)
		{
			object[] array = this.Invoke("ImportInstanceData", new object[]
			{
				aEInstanceData
			});
			return Conversions.ToString(array[0]);
		}

		public void ImportInstanceDataAsync(EInstanceData aEInstanceData)
		{
			this.ImportInstanceDataAsync(aEInstanceData, null);
		}

		public void ImportInstanceDataAsync(EInstanceData aEInstanceData, object userState)
		{
			if (this.ImportInstanceDataOperationCompleted == null)
			{
				this.ImportInstanceDataOperationCompleted = new SendOrPostCallback(this.OnImportInstanceDataOperationCompleted);
			}
			this.InvokeAsync("ImportInstanceData", new object[]
			{
				aEInstanceData
			}, this.ImportInstanceDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnImportInstanceDataOperationCompleted(object arg)
		{
			if (this.ImportInstanceDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ImportInstanceDataCompletedEventHandler importInstanceDataCompletedEvent = this.ImportInstanceDataCompletedEvent;
				if (importInstanceDataCompletedEvent != null)
				{
					importInstanceDataCompletedEvent(this, new ImportInstanceDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.InitAfterMultiOper", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string InitAfterMultiOper(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID)
		{
			object[] array = this.Invoke("InitAfterMultiOper", new object[]
			{
				parAction,
				parEpisodeID,
				parEprDocID,
				parEprNum,
				parIP,
				parHappenDate,
				parHappenTime,
				parUserID,
				parTemplateID
			});
			return Conversions.ToString(array[0]);
		}

		public void InitAfterMultiOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID)
		{
			this.InitAfterMultiOperAsync(parAction, parEpisodeID, parEprDocID, parEprNum, parIP, parHappenDate, parHappenTime, parUserID, parTemplateID, null);
		}

		public void InitAfterMultiOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parIP, string parHappenDate, string parHappenTime, string parUserID, string parTemplateID, object userState)
		{
			if (this.InitAfterMultiOperOperationCompleted == null)
			{
				this.InitAfterMultiOperOperationCompleted = new SendOrPostCallback(this.OnInitAfterMultiOperOperationCompleted);
			}
			this.InvokeAsync("InitAfterMultiOper", new object[]
			{
				parAction,
				parEpisodeID,
				parEprDocID,
				parEprNum,
				parIP,
				parHappenDate,
				parHappenTime,
				parUserID,
				parTemplateID
			}, this.InitAfterMultiOperOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnInitAfterMultiOperOperationCompleted(object arg)
		{
			if (this.InitAfterMultiOperCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				InitAfterMultiOperCompletedEventHandler initAfterMultiOperCompletedEvent = this.InitAfterMultiOperCompletedEvent;
				if (initAfterMultiOperCompletedEvent != null)
				{
					initAfterMultiOperCompletedEvent(this, new InitAfterMultiOperCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.InitAfterSingleOper", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string InitAfterSingleOper(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID)
		{
			object[] array = this.Invoke("InitAfterSingleOper", new object[]
			{
				parAction,
				parEpisodeID,
				parEprDocID,
				parEprNum,
				parTemplateDocID,
				parHappenDate,
				parHappenTime,
				parIP,
				parUserID,
				parTemplateID
			});
			return Conversions.ToString(array[0]);
		}

		public void InitAfterSingleOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID)
		{
			this.InitAfterSingleOperAsync(parAction, parEpisodeID, parEprDocID, parEprNum, parTemplateDocID, parHappenDate, parHappenTime, parIP, parUserID, parTemplateID, null);
		}

		public void InitAfterSingleOperAsync(string parAction, string parEpisodeID, string parEprDocID, string parEprNum, string parTemplateDocID, string parHappenDate, string parHappenTime, string parIP, string parUserID, string parTemplateID, object userState)
		{
			if (this.InitAfterSingleOperOperationCompleted == null)
			{
				this.InitAfterSingleOperOperationCompleted = new SendOrPostCallback(this.OnInitAfterSingleOperOperationCompleted);
			}
			this.InvokeAsync("InitAfterSingleOper", new object[]
			{
				parAction,
				parEpisodeID,
				parEprDocID,
				parEprNum,
				parTemplateDocID,
				parHappenDate,
				parHappenTime,
				parIP,
				parUserID,
				parTemplateID
			}, this.InitAfterSingleOperOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnInitAfterSingleOperOperationCompleted(object arg)
		{
			if (this.InitAfterSingleOperCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				InitAfterSingleOperCompletedEventHandler initAfterSingleOperCompletedEvent = this.InitAfterSingleOperCompletedEvent;
				if (initAfterSingleOperCompletedEvent != null)
				{
					initAfterSingleOperCompletedEvent(this, new InitAfterSingleOperCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ReplaceGroupData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData ReplaceGroupData(string AInstanceID, string ATemplateID, string ATemplateName)
		{
			object[] array = this.Invoke("ReplaceGroupData", new object[]
			{
				AInstanceID,
				ATemplateID,
				ATemplateName
			});
			return (EInstanceData)array[0];
		}

		public void ReplaceGroupDataAsync(string AInstanceID, string ATemplateID, string ATemplateName)
		{
			this.ReplaceGroupDataAsync(AInstanceID, ATemplateID, ATemplateName, null);
		}

		public void ReplaceGroupDataAsync(string AInstanceID, string ATemplateID, string ATemplateName, object userState)
		{
			if (this.ReplaceGroupDataOperationCompleted == null)
			{
				this.ReplaceGroupDataOperationCompleted = new SendOrPostCallback(this.OnReplaceGroupDataOperationCompleted);
			}
			this.InvokeAsync("ReplaceGroupData", new object[]
			{
				AInstanceID,
				ATemplateID,
				ATemplateName
			}, this.ReplaceGroupDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnReplaceGroupDataOperationCompleted(object arg)
		{
			if (this.ReplaceGroupDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ReplaceGroupDataCompletedEventHandler replaceGroupDataCompletedEvent = this.ReplaceGroupDataCompletedEvent;
				if (replaceGroupDataCompletedEvent != null)
				{
					replaceGroupDataCompletedEvent(this, new ReplaceGroupDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.ReplaceTemplateData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData ReplaceTemplateData(string AInstanceID, string ATemplateID)
		{
			object[] array = this.Invoke("ReplaceTemplateData", new object[]
			{
				AInstanceID,
				ATemplateID
			});
			return (EInstanceData)array[0];
		}

		public void ReplaceTemplateDataAsync(string AInstanceID, string ATemplateID)
		{
			this.ReplaceTemplateDataAsync(AInstanceID, ATemplateID, null);
		}

		public void ReplaceTemplateDataAsync(string AInstanceID, string ATemplateID, object userState)
		{
			if (this.ReplaceTemplateDataOperationCompleted == null)
			{
				this.ReplaceTemplateDataOperationCompleted = new SendOrPostCallback(this.OnReplaceTemplateDataOperationCompleted);
			}
			this.InvokeAsync("ReplaceTemplateData", new object[]
			{
				AInstanceID,
				ATemplateID
			}, this.ReplaceTemplateDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnReplaceTemplateDataOperationCompleted(object arg)
		{
			if (this.ReplaceTemplateDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ReplaceTemplateDataCompletedEventHandler replaceTemplateDataCompletedEvent = this.ReplaceTemplateDataCompletedEvent;
				if (replaceTemplateDataCompletedEvent != null)
				{
					replaceTemplateDataCompletedEvent(this, new ReplaceTemplateDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.SaveData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData SaveData(EInstanceData AEInstanceData, ref EMixInstanceLog AEMixInstanceLog, ref string AErrorMessage)
		{
			object[] array = this.Invoke("SaveData", new object[]
			{
				AEInstanceData,
				AEMixInstanceLog,
				AErrorMessage
			});
			AEMixInstanceLog = (EMixInstanceLog)array[1];
			AErrorMessage = Conversions.ToString(array[2]);
			return (EInstanceData)array[0];
		}

		public void SaveDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage)
		{
			this.SaveDataAsync(AEInstanceData, AEMixInstanceLog, AErrorMessage, null);
		}

		public void SaveDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage, object userState)
		{
			if (this.SaveDataOperationCompleted == null)
			{
				this.SaveDataOperationCompleted = new SendOrPostCallback(this.OnSaveDataOperationCompleted);
			}
			this.InvokeAsync("SaveData", new object[]
			{
				AEInstanceData,
				AEMixInstanceLog,
				AErrorMessage
			}, this.SaveDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveDataOperationCompleted(object arg)
		{
			if (this.SaveDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveDataCompletedEventHandler saveDataCompletedEvent = this.SaveDataCompletedEvent;
				if (saveDataCompletedEvent != null)
				{
					saveDataCompletedEvent(this, new SaveDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.SaveMultipleData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EInstanceData SaveMultipleData(EInstanceData AEInstanceData, ref EMixInstanceLog AEMixInstanceLog, ref string AErrorMessage)
		{
			object[] array = this.Invoke("SaveMultipleData", new object[]
			{
				AEInstanceData,
				AEMixInstanceLog,
				AErrorMessage
			});
			AEMixInstanceLog = (EMixInstanceLog)array[1];
			AErrorMessage = Conversions.ToString(array[2]);
			return (EInstanceData)array[0];
		}

		public void SaveMultipleDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage)
		{
			this.SaveMultipleDataAsync(AEInstanceData, AEMixInstanceLog, AErrorMessage, null);
		}

		public void SaveMultipleDataAsync(EInstanceData AEInstanceData, EMixInstanceLog AEMixInstanceLog, string AErrorMessage, object userState)
		{
			if (this.SaveMultipleDataOperationCompleted == null)
			{
				this.SaveMultipleDataOperationCompleted = new SendOrPostCallback(this.OnSaveMultipleDataOperationCompleted);
			}
			this.InvokeAsync("SaveMultipleData", new object[]
			{
				AEInstanceData,
				AEMixInstanceLog,
				AErrorMessage
			}, this.SaveMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveMultipleDataOperationCompleted(object arg)
		{
			if (this.SaveMultipleDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveMultipleDataCompletedEventHandler saveMultipleDataCompletedEvent = this.SaveMultipleDataCompletedEvent;
				if (saveMultipleDataCompletedEvent != null)
				{
					saveMultipleDataCompletedEvent(this, new SaveMultipleDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.TestSaveMultipleData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string TestSaveMultipleData(string aId)
		{
			object[] array = this.Invoke("TestSaveMultipleData", new object[]
			{
				aId
			});
			return Conversions.ToString(array[0]);
		}

		public void TestSaveMultipleDataAsync(string aId)
		{
			this.TestSaveMultipleDataAsync(aId, null);
		}

		public void TestSaveMultipleDataAsync(string aId, object userState)
		{
			if (this.TestSaveMultipleDataOperationCompleted == null)
			{
				this.TestSaveMultipleDataOperationCompleted = new SendOrPostCallback(this.OnTestSaveMultipleDataOperationCompleted);
			}
			this.InvokeAsync("TestSaveMultipleData", new object[]
			{
				aId
			}, this.TestSaveMultipleDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnTestSaveMultipleDataOperationCompleted(object arg)
		{
			if (this.TestSaveMultipleDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				TestSaveMultipleDataCompletedEventHandler testSaveMultipleDataCompletedEvent = this.TestSaveMultipleDataCompletedEvent;
				if (testSaveMultipleDataCompletedEvent != null)
				{
					testSaveMultipleDataCompletedEvent(this, new TestSaveMultipleDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOInstanceData.UpdateEPRLogs", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateEPRLogs(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID)
		{
			object[] array = this.Invoke("UpdateEPRLogs", new object[]
			{
				parEpisodeID,
				parAllStr,
				parAction,
				parIP,
				parUserID
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateEPRLogsAsync(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID)
		{
			this.UpdateEPRLogsAsync(parEpisodeID, parAllStr, parAction, parIP, parUserID, null);
		}

		public void UpdateEPRLogsAsync(string parEpisodeID, string parAllStr, string parAction, string parIP, string parUserID, object userState)
		{
			if (this.UpdateEPRLogsOperationCompleted == null)
			{
				this.UpdateEPRLogsOperationCompleted = new SendOrPostCallback(this.OnUpdateEPRLogsOperationCompleted);
			}
			this.InvokeAsync("UpdateEPRLogs", new object[]
			{
				parEpisodeID,
				parAllStr,
				parAction,
				parIP,
				parUserID
			}, this.UpdateEPRLogsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateEPRLogsOperationCompleted(object arg)
		{
			if (this.UpdateEPRLogsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateEPRLogsCompletedEventHandler updateEPRLogsCompletedEvent = this.UpdateEPRLogsCompletedEvent;
				if (updateEPRLogsCompletedEvent != null)
				{
					updateEPRLogsCompletedEvent(this, new UpdateEPRLogsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		public new void CancelAsync(object userState)
		{
			base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
		}

		private bool IsLocalFileSystemWebService(string url)
		{
			if (url == null || url == string.Empty)
			{
				return false;
			}
			Uri uri = new Uri(url);
			return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
		}
	}
}
