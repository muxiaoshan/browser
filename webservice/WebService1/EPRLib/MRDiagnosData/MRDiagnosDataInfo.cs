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

namespace MRDiagnosData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "MRDiagnosDataInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class MRDiagnosDataInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback DeleteDiagnosOperationCompleted;

		private SendOrPostCallback GetAllHistoryDataOperationCompleted;

		private SendOrPostCallback GetDiagnosTypeDatasetOperationCompleted;

		private SendOrPostCallback GetDiagnosTypesDatasetOperationCompleted;

		private SendOrPostCallback GetHistoryDataOperationCompleted;

		private SendOrPostCallback GetICDDXDataOperationCompleted;

		private SendOrPostCallback GetMRDiagnosDatasetOperationCompleted;

		private SendOrPostCallback GetModleTabsOperationCompleted;

		private SendOrPostCallback GetModleTabsDetailOperationCompleted;

		private SendOrPostCallback PresentDiagnosCopyedOperationCompleted;

		private SendOrPostCallback SaveAsPresentDiagnosOperationCompleted;

		private SendOrPostCallback SaveDiagnosOperationCompleted;

		private SendOrPostCallback UpdateOrInsertMrDiagnosOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private DeleteDiagnosCompletedEventHandler DeleteDiagnosCompletedEvent;

		private GetAllHistoryDataCompletedEventHandler GetAllHistoryDataCompletedEvent;

		private GetDiagnosTypeDatasetCompletedEventHandler GetDiagnosTypeDatasetCompletedEvent;

		private GetDiagnosTypesDatasetCompletedEventHandler GetDiagnosTypesDatasetCompletedEvent;

		private GetHistoryDataCompletedEventHandler GetHistoryDataCompletedEvent;

		private GetICDDXDataCompletedEventHandler GetICDDXDataCompletedEvent;

		private GetMRDiagnosDatasetCompletedEventHandler GetMRDiagnosDatasetCompletedEvent;

		private GetModleTabsCompletedEventHandler GetModleTabsCompletedEvent;

		private GetModleTabsDetailCompletedEventHandler GetModleTabsDetailCompletedEvent;

		private PresentDiagnosCopyedCompletedEventHandler PresentDiagnosCopyedCompletedEvent;

		private SaveAsPresentDiagnosCompletedEventHandler SaveAsPresentDiagnosCompletedEvent;

		private SaveDiagnosCompletedEventHandler SaveDiagnosCompletedEvent;

		private UpdateOrInsertMrDiagnosCompletedEventHandler UpdateOrInsertMrDiagnosCompletedEvent;

		public event DeleteDiagnosCompletedEventHandler DeleteDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteDiagnosCompletedEvent = (DeleteDiagnosCompletedEventHandler)Delegate.Combine(this.DeleteDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteDiagnosCompletedEvent = (DeleteDiagnosCompletedEventHandler)Delegate.Remove(this.DeleteDiagnosCompletedEvent, value);
			}
		}

		public event GetAllHistoryDataCompletedEventHandler GetAllHistoryDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllHistoryDataCompletedEvent = (GetAllHistoryDataCompletedEventHandler)Delegate.Combine(this.GetAllHistoryDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllHistoryDataCompletedEvent = (GetAllHistoryDataCompletedEventHandler)Delegate.Remove(this.GetAllHistoryDataCompletedEvent, value);
			}
		}

		public event GetDiagnosTypeDatasetCompletedEventHandler GetDiagnosTypeDatasetCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDiagnosTypeDatasetCompletedEvent = (GetDiagnosTypeDatasetCompletedEventHandler)Delegate.Combine(this.GetDiagnosTypeDatasetCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDiagnosTypeDatasetCompletedEvent = (GetDiagnosTypeDatasetCompletedEventHandler)Delegate.Remove(this.GetDiagnosTypeDatasetCompletedEvent, value);
			}
		}

		public event GetDiagnosTypesDatasetCompletedEventHandler GetDiagnosTypesDatasetCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDiagnosTypesDatasetCompletedEvent = (GetDiagnosTypesDatasetCompletedEventHandler)Delegate.Combine(this.GetDiagnosTypesDatasetCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDiagnosTypesDatasetCompletedEvent = (GetDiagnosTypesDatasetCompletedEventHandler)Delegate.Remove(this.GetDiagnosTypesDatasetCompletedEvent, value);
			}
		}

		public event GetHistoryDataCompletedEventHandler GetHistoryDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetHistoryDataCompletedEvent = (GetHistoryDataCompletedEventHandler)Delegate.Combine(this.GetHistoryDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetHistoryDataCompletedEvent = (GetHistoryDataCompletedEventHandler)Delegate.Remove(this.GetHistoryDataCompletedEvent, value);
			}
		}

		public event GetICDDXDataCompletedEventHandler GetICDDXDataCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetICDDXDataCompletedEvent = (GetICDDXDataCompletedEventHandler)Delegate.Combine(this.GetICDDXDataCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetICDDXDataCompletedEvent = (GetICDDXDataCompletedEventHandler)Delegate.Remove(this.GetICDDXDataCompletedEvent, value);
			}
		}

		public event GetMRDiagnosDatasetCompletedEventHandler GetMRDiagnosDatasetCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetMRDiagnosDatasetCompletedEvent = (GetMRDiagnosDatasetCompletedEventHandler)Delegate.Combine(this.GetMRDiagnosDatasetCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetMRDiagnosDatasetCompletedEvent = (GetMRDiagnosDatasetCompletedEventHandler)Delegate.Remove(this.GetMRDiagnosDatasetCompletedEvent, value);
			}
		}

		public event GetModleTabsCompletedEventHandler GetModleTabsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetModleTabsCompletedEvent = (GetModleTabsCompletedEventHandler)Delegate.Combine(this.GetModleTabsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetModleTabsCompletedEvent = (GetModleTabsCompletedEventHandler)Delegate.Remove(this.GetModleTabsCompletedEvent, value);
			}
		}

		public event GetModleTabsDetailCompletedEventHandler GetModleTabsDetailCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetModleTabsDetailCompletedEvent = (GetModleTabsDetailCompletedEventHandler)Delegate.Combine(this.GetModleTabsDetailCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetModleTabsDetailCompletedEvent = (GetModleTabsDetailCompletedEventHandler)Delegate.Remove(this.GetModleTabsDetailCompletedEvent, value);
			}
		}

		public event PresentDiagnosCopyedCompletedEventHandler PresentDiagnosCopyedCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.PresentDiagnosCopyedCompletedEvent = (PresentDiagnosCopyedCompletedEventHandler)Delegate.Combine(this.PresentDiagnosCopyedCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.PresentDiagnosCopyedCompletedEvent = (PresentDiagnosCopyedCompletedEventHandler)Delegate.Remove(this.PresentDiagnosCopyedCompletedEvent, value);
			}
		}

		public event SaveAsPresentDiagnosCompletedEventHandler SaveAsPresentDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveAsPresentDiagnosCompletedEvent = (SaveAsPresentDiagnosCompletedEventHandler)Delegate.Combine(this.SaveAsPresentDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveAsPresentDiagnosCompletedEvent = (SaveAsPresentDiagnosCompletedEventHandler)Delegate.Remove(this.SaveAsPresentDiagnosCompletedEvent, value);
			}
		}

		public event SaveDiagnosCompletedEventHandler SaveDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveDiagnosCompletedEvent = (SaveDiagnosCompletedEventHandler)Delegate.Combine(this.SaveDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveDiagnosCompletedEvent = (SaveDiagnosCompletedEventHandler)Delegate.Remove(this.SaveDiagnosCompletedEvent, value);
			}
		}

		public event UpdateOrInsertMrDiagnosCompletedEventHandler UpdateOrInsertMrDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateOrInsertMrDiagnosCompletedEvent = (UpdateOrInsertMrDiagnosCompletedEventHandler)Delegate.Combine(this.UpdateOrInsertMrDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateOrInsertMrDiagnosCompletedEvent = (UpdateOrInsertMrDiagnosCompletedEventHandler)Delegate.Remove(this.UpdateOrInsertMrDiagnosCompletedEvent, value);
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

		public MRDiagnosDataInfo()
		{
			this.Url = MySettings.Default.EPRLib_MRDiagnosData_MRDiagnosDataInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.DeleteDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string DeleteDiagnos(string AMRID, string SubID)
		{
			object[] array = this.Invoke("DeleteDiagnos", new object[]
			{
				AMRID,
				SubID
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteDiagnosAsync(string AMRID, string SubID)
		{
			this.DeleteDiagnosAsync(AMRID, SubID, null);
		}

		public void DeleteDiagnosAsync(string AMRID, string SubID, object userState)
		{
			if (this.DeleteDiagnosOperationCompleted == null)
			{
				this.DeleteDiagnosOperationCompleted = new SendOrPostCallback(this.OnDeleteDiagnosOperationCompleted);
			}
			this.InvokeAsync("DeleteDiagnos", new object[]
			{
				AMRID,
				SubID
			}, this.DeleteDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteDiagnosOperationCompleted(object arg)
		{
			if (this.DeleteDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteDiagnosCompletedEventHandler deleteDiagnosCompletedEvent = this.DeleteDiagnosCompletedEvent;
				if (deleteDiagnosCompletedEvent != null)
				{
					deleteDiagnosCompletedEvent(this, new DeleteDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetAllHistoryData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosAllHistoryDataset GetAllHistoryData(string PatientID, string ICDType)
		{
			object[] array = this.Invoke("GetAllHistoryData", new object[]
			{
				PatientID,
				ICDType
			});
			return (EMRDiagnosAllHistoryDataset)array[0];
		}

		public void GetAllHistoryDataAsync(string PatientID, string ICDType)
		{
			this.GetAllHistoryDataAsync(PatientID, ICDType, null);
		}

		public void GetAllHistoryDataAsync(string PatientID, string ICDType, object userState)
		{
			if (this.GetAllHistoryDataOperationCompleted == null)
			{
				this.GetAllHistoryDataOperationCompleted = new SendOrPostCallback(this.OnGetAllHistoryDataOperationCompleted);
			}
			this.InvokeAsync("GetAllHistoryData", new object[]
			{
				PatientID,
				ICDType
			}, this.GetAllHistoryDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllHistoryDataOperationCompleted(object arg)
		{
			if (this.GetAllHistoryDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllHistoryDataCompletedEventHandler getAllHistoryDataCompletedEvent = this.GetAllHistoryDataCompletedEvent;
				if (getAllHistoryDataCompletedEvent != null)
				{
					getAllHistoryDataCompletedEvent(this, new GetAllHistoryDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetDiagnosTypeDataset", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosTypeDataset GetDiagnosTypeDataset()
		{
			object[] array = this.Invoke("GetDiagnosTypeDataset", new object[0]);
			return (EMRDiagnosTypeDataset)array[0];
		}

		public void GetDiagnosTypeDatasetAsync()
		{
			this.GetDiagnosTypeDatasetAsync(null);
		}

		public void GetDiagnosTypeDatasetAsync(object userState)
		{
			if (this.GetDiagnosTypeDatasetOperationCompleted == null)
			{
				this.GetDiagnosTypeDatasetOperationCompleted = new SendOrPostCallback(this.OnGetDiagnosTypeDatasetOperationCompleted);
			}
			this.InvokeAsync("GetDiagnosTypeDataset", new object[0], this.GetDiagnosTypeDatasetOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDiagnosTypeDatasetOperationCompleted(object arg)
		{
			if (this.GetDiagnosTypeDatasetCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDiagnosTypeDatasetCompletedEventHandler getDiagnosTypeDatasetCompletedEvent = this.GetDiagnosTypeDatasetCompletedEvent;
				if (getDiagnosTypeDatasetCompletedEvent != null)
				{
					getDiagnosTypeDatasetCompletedEvent(this, new GetDiagnosTypeDatasetCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetDiagnosTypesDataset", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosStatuesTypeDataset GetDiagnosTypesDataset()
		{
			object[] array = this.Invoke("GetDiagnosTypesDataset", new object[0]);
			return (EMRDiagnosStatuesTypeDataset)array[0];
		}

		public void GetDiagnosTypesDatasetAsync()
		{
			this.GetDiagnosTypesDatasetAsync(null);
		}

		public void GetDiagnosTypesDatasetAsync(object userState)
		{
			if (this.GetDiagnosTypesDatasetOperationCompleted == null)
			{
				this.GetDiagnosTypesDatasetOperationCompleted = new SendOrPostCallback(this.OnGetDiagnosTypesDatasetOperationCompleted);
			}
			this.InvokeAsync("GetDiagnosTypesDataset", new object[0], this.GetDiagnosTypesDatasetOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDiagnosTypesDatasetOperationCompleted(object arg)
		{
			if (this.GetDiagnosTypesDatasetCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDiagnosTypesDatasetCompletedEventHandler getDiagnosTypesDatasetCompletedEvent = this.GetDiagnosTypesDatasetCompletedEvent;
				if (getDiagnosTypesDatasetCompletedEvent != null)
				{
					getDiagnosTypesDatasetCompletedEvent(this, new GetDiagnosTypesDatasetCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetHistoryData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosHistoryDataset GetHistoryData(string PatientID, string ICDType)
		{
			object[] array = this.Invoke("GetHistoryData", new object[]
			{
				PatientID,
				ICDType
			});
			return (EMRDiagnosHistoryDataset)array[0];
		}

		public void GetHistoryDataAsync(string PatientID, string ICDType)
		{
			this.GetHistoryDataAsync(PatientID, ICDType, null);
		}

		public void GetHistoryDataAsync(string PatientID, string ICDType, object userState)
		{
			if (this.GetHistoryDataOperationCompleted == null)
			{
				this.GetHistoryDataOperationCompleted = new SendOrPostCallback(this.OnGetHistoryDataOperationCompleted);
			}
			this.InvokeAsync("GetHistoryData", new object[]
			{
				PatientID,
				ICDType
			}, this.GetHistoryDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetHistoryDataOperationCompleted(object arg)
		{
			if (this.GetHistoryDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetHistoryDataCompletedEventHandler getHistoryDataCompletedEvent = this.GetHistoryDataCompletedEvent;
				if (getHistoryDataCompletedEvent != null)
				{
					getHistoryDataCompletedEvent(this, new GetHistoryDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetICDDXData", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosICDDataset GetICDDXData(string QueryText)
		{
			object[] array = this.Invoke("GetICDDXData", new object[]
			{
				QueryText
			});
			return (EMRDiagnosICDDataset)array[0];
		}

		public void GetICDDXDataAsync(string QueryText)
		{
			this.GetICDDXDataAsync(QueryText, null);
		}

		public void GetICDDXDataAsync(string QueryText, object userState)
		{
			if (this.GetICDDXDataOperationCompleted == null)
			{
				this.GetICDDXDataOperationCompleted = new SendOrPostCallback(this.OnGetICDDXDataOperationCompleted);
			}
			this.InvokeAsync("GetICDDXData", new object[]
			{
				QueryText
			}, this.GetICDDXDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetICDDXDataOperationCompleted(object arg)
		{
			if (this.GetICDDXDataCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetICDDXDataCompletedEventHandler getICDDXDataCompletedEvent = this.GetICDDXDataCompletedEvent;
				if (getICDDXDataCompletedEvent != null)
				{
					getICDDXDataCompletedEvent(this, new GetICDDXDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetMRDiagnosDataset", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosDataSet GetMRDiagnosDataset(string pEpisodeID, string PTypeID)
		{
			object[] array = this.Invoke("GetMRDiagnosDataset", new object[]
			{
				pEpisodeID,
				PTypeID
			});
			return (EMRDiagnosDataSet)array[0];
		}

		public void GetMRDiagnosDatasetAsync(string pEpisodeID, string PTypeID)
		{
			this.GetMRDiagnosDatasetAsync(pEpisodeID, PTypeID, null);
		}

		public void GetMRDiagnosDatasetAsync(string pEpisodeID, string PTypeID, object userState)
		{
			if (this.GetMRDiagnosDatasetOperationCompleted == null)
			{
				this.GetMRDiagnosDatasetOperationCompleted = new SendOrPostCallback(this.OnGetMRDiagnosDatasetOperationCompleted);
			}
			this.InvokeAsync("GetMRDiagnosDataset", new object[]
			{
				pEpisodeID,
				PTypeID
			}, this.GetMRDiagnosDatasetOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetMRDiagnosDatasetOperationCompleted(object arg)
		{
			if (this.GetMRDiagnosDatasetCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetMRDiagnosDatasetCompletedEventHandler getMRDiagnosDatasetCompletedEvent = this.GetMRDiagnosDatasetCompletedEvent;
				if (getMRDiagnosDatasetCompletedEvent != null)
				{
					getMRDiagnosDatasetCompletedEvent(this, new GetMRDiagnosDatasetCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetModleTabs", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosModleDataset GetModleTabs(string UserID, string DeptID)
		{
			object[] array = this.Invoke("GetModleTabs", new object[]
			{
				UserID,
				DeptID
			});
			return (EMRDiagnosModleDataset)array[0];
		}

		public void GetModleTabsAsync(string UserID, string DeptID)
		{
			this.GetModleTabsAsync(UserID, DeptID, null);
		}

		public void GetModleTabsAsync(string UserID, string DeptID, object userState)
		{
			if (this.GetModleTabsOperationCompleted == null)
			{
				this.GetModleTabsOperationCompleted = new SendOrPostCallback(this.OnGetModleTabsOperationCompleted);
			}
			this.InvokeAsync("GetModleTabs", new object[]
			{
				UserID,
				DeptID
			}, this.GetModleTabsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetModleTabsOperationCompleted(object arg)
		{
			if (this.GetModleTabsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetModleTabsCompletedEventHandler getModleTabsCompletedEvent = this.GetModleTabsCompletedEvent;
				if (getModleTabsCompletedEvent != null)
				{
					getModleTabsCompletedEvent(this, new GetModleTabsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.GetModleTabsDetail", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EMRDiagnosModleDetailDataset GetModleTabsDetail(string ID)
		{
			object[] array = this.Invoke("GetModleTabsDetail", new object[]
			{
				ID
			});
			return (EMRDiagnosModleDetailDataset)array[0];
		}

		public void GetModleTabsDetailAsync(string ID)
		{
			this.GetModleTabsDetailAsync(ID, null);
		}

		public void GetModleTabsDetailAsync(string ID, object userState)
		{
			if (this.GetModleTabsDetailOperationCompleted == null)
			{
				this.GetModleTabsDetailOperationCompleted = new SendOrPostCallback(this.OnGetModleTabsDetailOperationCompleted);
			}
			this.InvokeAsync("GetModleTabsDetail", new object[]
			{
				ID
			}, this.GetModleTabsDetailOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetModleTabsDetailOperationCompleted(object arg)
		{
			if (this.GetModleTabsDetailCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetModleTabsDetailCompletedEventHandler getModleTabsDetailCompletedEvent = this.GetModleTabsDetailCompletedEvent;
				if (getModleTabsDetailCompletedEvent != null)
				{
					getModleTabsDetailCompletedEvent(this, new GetModleTabsDetailCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.PresentDiagnosCopyed", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void PresentDiagnosCopyed(string ApresentType, string AType, string EpsodeID, string UserID)
		{
			this.Invoke("PresentDiagnosCopyed", new object[]
			{
				ApresentType,
				AType,
				EpsodeID,
				UserID
			});
		}

		public void PresentDiagnosCopyedAsync(string ApresentType, string AType, string EpsodeID, string UserID)
		{
			this.PresentDiagnosCopyedAsync(ApresentType, AType, EpsodeID, UserID, null);
		}

		public void PresentDiagnosCopyedAsync(string ApresentType, string AType, string EpsodeID, string UserID, object userState)
		{
			if (this.PresentDiagnosCopyedOperationCompleted == null)
			{
				this.PresentDiagnosCopyedOperationCompleted = new SendOrPostCallback(this.OnPresentDiagnosCopyedOperationCompleted);
			}
			this.InvokeAsync("PresentDiagnosCopyed", new object[]
			{
				ApresentType,
				AType,
				EpsodeID,
				UserID
			}, this.PresentDiagnosCopyedOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnPresentDiagnosCopyedOperationCompleted(object arg)
		{
			if (this.PresentDiagnosCopyedCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				PresentDiagnosCopyedCompletedEventHandler presentDiagnosCopyedCompletedEvent = this.PresentDiagnosCopyedCompletedEvent;
				if (presentDiagnosCopyedCompletedEvent != null)
				{
					presentDiagnosCopyedCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.SaveAsPresentDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SaveAsPresentDiagnos(string AResult, string EpsodeID, string AUserID)
		{
			this.Invoke("SaveAsPresentDiagnos", new object[]
			{
				AResult,
				EpsodeID,
				AUserID
			});
		}

		public void SaveAsPresentDiagnosAsync(string AResult, string EpsodeID, string AUserID)
		{
			this.SaveAsPresentDiagnosAsync(AResult, EpsodeID, AUserID, null);
		}

		public void SaveAsPresentDiagnosAsync(string AResult, string EpsodeID, string AUserID, object userState)
		{
			if (this.SaveAsPresentDiagnosOperationCompleted == null)
			{
				this.SaveAsPresentDiagnosOperationCompleted = new SendOrPostCallback(this.OnSaveAsPresentDiagnosOperationCompleted);
			}
			this.InvokeAsync("SaveAsPresentDiagnos", new object[]
			{
				AResult,
				EpsodeID,
				AUserID
			}, this.SaveAsPresentDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveAsPresentDiagnosOperationCompleted(object arg)
		{
			if (this.SaveAsPresentDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveAsPresentDiagnosCompletedEventHandler saveAsPresentDiagnosCompletedEvent = this.SaveAsPresentDiagnosCompletedEvent;
				if (saveAsPresentDiagnosCompletedEvent != null)
				{
					saveAsPresentDiagnosCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.SaveDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SaveDiagnos(string AResult, string AUserID)
		{
			this.Invoke("SaveDiagnos", new object[]
			{
				AResult,
				AUserID
			});
		}

		public void SaveDiagnosAsync(string AResult, string AUserID)
		{
			this.SaveDiagnosAsync(AResult, AUserID, null);
		}

		public void SaveDiagnosAsync(string AResult, string AUserID, object userState)
		{
			if (this.SaveDiagnosOperationCompleted == null)
			{
				this.SaveDiagnosOperationCompleted = new SendOrPostCallback(this.OnSaveDiagnosOperationCompleted);
			}
			this.InvokeAsync("SaveDiagnos", new object[]
			{
				AResult,
				AUserID
			}, this.SaveDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveDiagnosOperationCompleted(object arg)
		{
			if (this.SaveDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveDiagnosCompletedEventHandler saveDiagnosCompletedEvent = this.SaveDiagnosCompletedEvent;
				if (saveDiagnosCompletedEvent != null)
				{
					saveDiagnosCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOMRDiagnosData.UpdateOrInsertMrDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateOrInsertMrDiagnos(string AEpsodeID, string ADiagnosID, string ASubID, string AType, string AIcdCode, string AIcdDesc, string AEvaluation, string AEffect, string AUserID, string ASequence)
		{
			object[] array = this.Invoke("UpdateOrInsertMrDiagnos", new object[]
			{
				AEpsodeID,
				ADiagnosID,
				ASubID,
				AType,
				AIcdCode,
				AIcdDesc,
				AEvaluation,
				AEffect,
				AUserID,
				ASequence
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateOrInsertMrDiagnosAsync(string AEpsodeID, string ADiagnosID, string ASubID, string AType, string AIcdCode, string AIcdDesc, string AEvaluation, string AEffect, string AUserID, string ASequence)
		{
			this.UpdateOrInsertMrDiagnosAsync(AEpsodeID, ADiagnosID, ASubID, AType, AIcdCode, AIcdDesc, AEvaluation, AEffect, AUserID, ASequence, null);
		}

		public void UpdateOrInsertMrDiagnosAsync(string AEpsodeID, string ADiagnosID, string ASubID, string AType, string AIcdCode, string AIcdDesc, string AEvaluation, string AEffect, string AUserID, string ASequence, object userState)
		{
			if (this.UpdateOrInsertMrDiagnosOperationCompleted == null)
			{
				this.UpdateOrInsertMrDiagnosOperationCompleted = new SendOrPostCallback(this.OnUpdateOrInsertMrDiagnosOperationCompleted);
			}
			this.InvokeAsync("UpdateOrInsertMrDiagnos", new object[]
			{
				AEpsodeID,
				ADiagnosID,
				ASubID,
				AType,
				AIcdCode,
				AIcdDesc,
				AEvaluation,
				AEffect,
				AUserID,
				ASequence
			}, this.UpdateOrInsertMrDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateOrInsertMrDiagnosOperationCompleted(object arg)
		{
			if (this.UpdateOrInsertMrDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateOrInsertMrDiagnosCompletedEventHandler updateOrInsertMrDiagnosCompletedEvent = this.UpdateOrInsertMrDiagnosCompletedEvent;
				if (updateOrInsertMrDiagnosCompletedEvent != null)
				{
					updateOrInsertMrDiagnosCompletedEvent(this, new UpdateOrInsertMrDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
