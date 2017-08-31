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

namespace PACSData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "PACSDataInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class PACSDataInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetPACSItemListOperationCompleted;

		private SendOrPostCallback SelectPACSArcCateListOperationCompleted;

		private SendOrPostCallback SelectPACSArcItemListOperationCompleted;

		private SendOrPostCallback SelectPACSItemIndicatorsOperationCompleted;

		private SendOrPostCallback SelectPACSItemListByACRDROperationCompleted;

		private SendOrPostCallback SelectPACSItemListByDateOperationCompleted;

		private SendOrPostCallback SelectPACSRptByACRDROperationCompleted;

		private SendOrPostCallback SelectReportByOeordIDOperationCompleted;

		private SendOrPostCallback SelectRptStructureOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetPACSItemListCompletedEventHandler GetPACSItemListCompletedEvent;

		private SelectPACSArcCateListCompletedEventHandler SelectPACSArcCateListCompletedEvent;

		private SelectPACSArcItemListCompletedEventHandler SelectPACSArcItemListCompletedEvent;

		private SelectPACSItemIndicatorsCompletedEventHandler SelectPACSItemIndicatorsCompletedEvent;

		private SelectPACSItemListByACRDRCompletedEventHandler SelectPACSItemListByACRDRCompletedEvent;

		private SelectPACSItemListByDateCompletedEventHandler SelectPACSItemListByDateCompletedEvent;

		private SelectPACSRptByACRDRCompletedEventHandler SelectPACSRptByACRDRCompletedEvent;

		private SelectReportByOeordIDCompletedEventHandler SelectReportByOeordIDCompletedEvent;

		private SelectRptStructureCompletedEventHandler SelectRptStructureCompletedEvent;

		public event GetPACSItemListCompletedEventHandler GetPACSItemListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetPACSItemListCompletedEvent = (GetPACSItemListCompletedEventHandler)Delegate.Combine(this.GetPACSItemListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetPACSItemListCompletedEvent = (GetPACSItemListCompletedEventHandler)Delegate.Remove(this.GetPACSItemListCompletedEvent, value);
			}
		}

		public event SelectPACSArcCateListCompletedEventHandler SelectPACSArcCateListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSArcCateListCompletedEvent = (SelectPACSArcCateListCompletedEventHandler)Delegate.Combine(this.SelectPACSArcCateListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSArcCateListCompletedEvent = (SelectPACSArcCateListCompletedEventHandler)Delegate.Remove(this.SelectPACSArcCateListCompletedEvent, value);
			}
		}

		public event SelectPACSArcItemListCompletedEventHandler SelectPACSArcItemListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSArcItemListCompletedEvent = (SelectPACSArcItemListCompletedEventHandler)Delegate.Combine(this.SelectPACSArcItemListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSArcItemListCompletedEvent = (SelectPACSArcItemListCompletedEventHandler)Delegate.Remove(this.SelectPACSArcItemListCompletedEvent, value);
			}
		}

		public event SelectPACSItemIndicatorsCompletedEventHandler SelectPACSItemIndicatorsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSItemIndicatorsCompletedEvent = (SelectPACSItemIndicatorsCompletedEventHandler)Delegate.Combine(this.SelectPACSItemIndicatorsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSItemIndicatorsCompletedEvent = (SelectPACSItemIndicatorsCompletedEventHandler)Delegate.Remove(this.SelectPACSItemIndicatorsCompletedEvent, value);
			}
		}

		public event SelectPACSItemListByACRDRCompletedEventHandler SelectPACSItemListByACRDRCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSItemListByACRDRCompletedEvent = (SelectPACSItemListByACRDRCompletedEventHandler)Delegate.Combine(this.SelectPACSItemListByACRDRCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSItemListByACRDRCompletedEvent = (SelectPACSItemListByACRDRCompletedEventHandler)Delegate.Remove(this.SelectPACSItemListByACRDRCompletedEvent, value);
			}
		}

		public event SelectPACSItemListByDateCompletedEventHandler SelectPACSItemListByDateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSItemListByDateCompletedEvent = (SelectPACSItemListByDateCompletedEventHandler)Delegate.Combine(this.SelectPACSItemListByDateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSItemListByDateCompletedEvent = (SelectPACSItemListByDateCompletedEventHandler)Delegate.Remove(this.SelectPACSItemListByDateCompletedEvent, value);
			}
		}

		public event SelectPACSRptByACRDRCompletedEventHandler SelectPACSRptByACRDRCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectPACSRptByACRDRCompletedEvent = (SelectPACSRptByACRDRCompletedEventHandler)Delegate.Combine(this.SelectPACSRptByACRDRCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectPACSRptByACRDRCompletedEvent = (SelectPACSRptByACRDRCompletedEventHandler)Delegate.Remove(this.SelectPACSRptByACRDRCompletedEvent, value);
			}
		}

		public event SelectReportByOeordIDCompletedEventHandler SelectReportByOeordIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectReportByOeordIDCompletedEvent = (SelectReportByOeordIDCompletedEventHandler)Delegate.Combine(this.SelectReportByOeordIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectReportByOeordIDCompletedEvent = (SelectReportByOeordIDCompletedEventHandler)Delegate.Remove(this.SelectReportByOeordIDCompletedEvent, value);
			}
		}

		public event SelectRptStructureCompletedEventHandler SelectRptStructureCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectRptStructureCompletedEvent = (SelectRptStructureCompletedEventHandler)Delegate.Combine(this.SelectRptStructureCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectRptStructureCompletedEvent = (SelectRptStructureCompletedEventHandler)Delegate.Remove(this.SelectRptStructureCompletedEvent, value);
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

		public PACSDataInfo()
		{
			this.Url = MySettings.Default.EPRLib_PACSData_PACSDataInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.GetPACSItemList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSListDataset GetPACSItemList(string ID, string StDate, string EndDate, string Flag, string StartPage, string EndPage)
		{
			object[] array = this.Invoke("GetPACSItemList", new object[]
			{
				ID,
				StDate,
				EndDate,
				Flag,
				StartPage,
				EndPage
			});
			return (EPACSListDataset)array[0];
		}

		public void GetPACSItemListAsync(string ID, string StDate, string EndDate, string Flag, string StartPage, string EndPage)
		{
			this.GetPACSItemListAsync(ID, StDate, EndDate, Flag, StartPage, EndPage, null);
		}

		public void GetPACSItemListAsync(string ID, string StDate, string EndDate, string Flag, string StartPage, string EndPage, object userState)
		{
			if (this.GetPACSItemListOperationCompleted == null)
			{
				this.GetPACSItemListOperationCompleted = new SendOrPostCallback(this.OnGetPACSItemListOperationCompleted);
			}
			this.InvokeAsync("GetPACSItemList", new object[]
			{
				ID,
				StDate,
				EndDate,
				Flag,
				StartPage,
				EndPage
			}, this.GetPACSItemListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetPACSItemListOperationCompleted(object arg)
		{
			if (this.GetPACSItemListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetPACSItemListCompletedEventHandler getPACSItemListCompletedEvent = this.GetPACSItemListCompletedEvent;
				if (getPACSItemListCompletedEvent != null)
				{
					getPACSItemListCompletedEvent(this, new GetPACSItemListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSArcCateList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSArcCateListDataSet SelectPACSArcCateList()
		{
			object[] array = this.Invoke("SelectPACSArcCateList", new object[0]);
			return (EPACSArcCateListDataSet)array[0];
		}

		public void SelectPACSArcCateListAsync()
		{
			this.SelectPACSArcCateListAsync(null);
		}

		public void SelectPACSArcCateListAsync(object userState)
		{
			if (this.SelectPACSArcCateListOperationCompleted == null)
			{
				this.SelectPACSArcCateListOperationCompleted = new SendOrPostCallback(this.OnSelectPACSArcCateListOperationCompleted);
			}
			this.InvokeAsync("SelectPACSArcCateList", new object[0], this.SelectPACSArcCateListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSArcCateListOperationCompleted(object arg)
		{
			if (this.SelectPACSArcCateListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSArcCateListCompletedEventHandler selectPACSArcCateListCompletedEvent = this.SelectPACSArcCateListCompletedEvent;
				if (selectPACSArcCateListCompletedEvent != null)
				{
					selectPACSArcCateListCompletedEvent(this, new SelectPACSArcCateListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSArcItemList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSArcItemListDataSet SelectPACSArcItemList(string ArcCateID)
		{
			object[] array = this.Invoke("SelectPACSArcItemList", new object[]
			{
				ArcCateID
			});
			return (EPACSArcItemListDataSet)array[0];
		}

		public void SelectPACSArcItemListAsync(string ArcCateID)
		{
			this.SelectPACSArcItemListAsync(ArcCateID, null);
		}

		public void SelectPACSArcItemListAsync(string ArcCateID, object userState)
		{
			if (this.SelectPACSArcItemListOperationCompleted == null)
			{
				this.SelectPACSArcItemListOperationCompleted = new SendOrPostCallback(this.OnSelectPACSArcItemListOperationCompleted);
			}
			this.InvokeAsync("SelectPACSArcItemList", new object[]
			{
				ArcCateID
			}, this.SelectPACSArcItemListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSArcItemListOperationCompleted(object arg)
		{
			if (this.SelectPACSArcItemListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSArcItemListCompletedEventHandler selectPACSArcItemListCompletedEvent = this.SelectPACSArcItemListCompletedEvent;
				if (selectPACSArcItemListCompletedEvent != null)
				{
					selectPACSArcItemListCompletedEvent(this, new SelectPACSArcItemListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSItemIndicators", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSItemIndicatorsDataSet SelectPACSItemIndicators(string OEItemRowID, string TypeID)
		{
			object[] array = this.Invoke("SelectPACSItemIndicators", new object[]
			{
				OEItemRowID,
				TypeID
			});
			return (EPACSItemIndicatorsDataSet)array[0];
		}

		public void SelectPACSItemIndicatorsAsync(string OEItemRowID, string TypeID)
		{
			this.SelectPACSItemIndicatorsAsync(OEItemRowID, TypeID, null);
		}

		public void SelectPACSItemIndicatorsAsync(string OEItemRowID, string TypeID, object userState)
		{
			if (this.SelectPACSItemIndicatorsOperationCompleted == null)
			{
				this.SelectPACSItemIndicatorsOperationCompleted = new SendOrPostCallback(this.OnSelectPACSItemIndicatorsOperationCompleted);
			}
			this.InvokeAsync("SelectPACSItemIndicators", new object[]
			{
				OEItemRowID,
				TypeID
			}, this.SelectPACSItemIndicatorsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSItemIndicatorsOperationCompleted(object arg)
		{
			if (this.SelectPACSItemIndicatorsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSItemIndicatorsCompletedEventHandler selectPACSItemIndicatorsCompletedEvent = this.SelectPACSItemIndicatorsCompletedEvent;
				if (selectPACSItemIndicatorsCompletedEvent != null)
				{
					selectPACSItemIndicatorsCompletedEvent(this, new SelectPACSItemIndicatorsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSItemListByACRDR", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSOEordIDByARCDRDataSet SelectPACSItemListByACRDR(string EpisodeID, string ACRDR, string EndDate)
		{
			object[] array = this.Invoke("SelectPACSItemListByACRDR", new object[]
			{
				EpisodeID,
				ACRDR,
				EndDate
			});
			return (EPACSOEordIDByARCDRDataSet)array[0];
		}

		public void SelectPACSItemListByACRDRAsync(string EpisodeID, string ACRDR, string EndDate)
		{
			this.SelectPACSItemListByACRDRAsync(EpisodeID, ACRDR, EndDate, null);
		}

		public void SelectPACSItemListByACRDRAsync(string EpisodeID, string ACRDR, string EndDate, object userState)
		{
			if (this.SelectPACSItemListByACRDROperationCompleted == null)
			{
				this.SelectPACSItemListByACRDROperationCompleted = new SendOrPostCallback(this.OnSelectPACSItemListByACRDROperationCompleted);
			}
			this.InvokeAsync("SelectPACSItemListByACRDR", new object[]
			{
				EpisodeID,
				ACRDR,
				EndDate
			}, this.SelectPACSItemListByACRDROperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSItemListByACRDROperationCompleted(object arg)
		{
			if (this.SelectPACSItemListByACRDRCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSItemListByACRDRCompletedEventHandler selectPACSItemListByACRDRCompletedEvent = this.SelectPACSItemListByACRDRCompletedEvent;
				if (selectPACSItemListByACRDRCompletedEvent != null)
				{
					selectPACSItemListByACRDRCompletedEvent(this, new SelectPACSItemListByACRDRCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSItemListByDate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSInterFaceDataSet SelectPACSItemListByDate(string EpisodeID, string StDate, string EndDate)
		{
			object[] array = this.Invoke("SelectPACSItemListByDate", new object[]
			{
				EpisodeID,
				StDate,
				EndDate
			});
			return (EPACSInterFaceDataSet)array[0];
		}

		public void SelectPACSItemListByDateAsync(string EpisodeID, string StDate, string EndDate)
		{
			this.SelectPACSItemListByDateAsync(EpisodeID, StDate, EndDate, null);
		}

		public void SelectPACSItemListByDateAsync(string EpisodeID, string StDate, string EndDate, object userState)
		{
			if (this.SelectPACSItemListByDateOperationCompleted == null)
			{
				this.SelectPACSItemListByDateOperationCompleted = new SendOrPostCallback(this.OnSelectPACSItemListByDateOperationCompleted);
			}
			this.InvokeAsync("SelectPACSItemListByDate", new object[]
			{
				EpisodeID,
				StDate,
				EndDate
			}, this.SelectPACSItemListByDateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSItemListByDateOperationCompleted(object arg)
		{
			if (this.SelectPACSItemListByDateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSItemListByDateCompletedEventHandler selectPACSItemListByDateCompletedEvent = this.SelectPACSItemListByDateCompletedEvent;
				if (selectPACSItemListByDateCompletedEvent != null)
				{
					selectPACSItemListByDateCompletedEvent(this, new SelectPACSItemListByDateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectPACSRptByACRDR", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSRptByARCDRDataSet SelectPACSRptByACRDR(string EpisodeID, string ACRDR, string TypeID)
		{
			object[] array = this.Invoke("SelectPACSRptByACRDR", new object[]
			{
				EpisodeID,
				ACRDR,
				TypeID
			});
			return (EPACSRptByARCDRDataSet)array[0];
		}

		public void SelectPACSRptByACRDRAsync(string EpisodeID, string ACRDR, string TypeID)
		{
			this.SelectPACSRptByACRDRAsync(EpisodeID, ACRDR, TypeID, null);
		}

		public void SelectPACSRptByACRDRAsync(string EpisodeID, string ACRDR, string TypeID, object userState)
		{
			if (this.SelectPACSRptByACRDROperationCompleted == null)
			{
				this.SelectPACSRptByACRDROperationCompleted = new SendOrPostCallback(this.OnSelectPACSRptByACRDROperationCompleted);
			}
			this.InvokeAsync("SelectPACSRptByACRDR", new object[]
			{
				EpisodeID,
				ACRDR,
				TypeID
			}, this.SelectPACSRptByACRDROperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectPACSRptByACRDROperationCompleted(object arg)
		{
			if (this.SelectPACSRptByACRDRCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectPACSRptByACRDRCompletedEventHandler selectPACSRptByACRDRCompletedEvent = this.SelectPACSRptByACRDRCompletedEvent;
				if (selectPACSRptByACRDRCompletedEvent != null)
				{
					selectPACSRptByACRDRCompletedEvent(this, new SelectPACSRptByACRDRCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectReportByOeordID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSRptByOEordIDDataSet SelectReportByOeordID(string OEItemRowID)
		{
			object[] array = this.Invoke("SelectReportByOeordID", new object[]
			{
				OEItemRowID
			});
			return (EPACSRptByOEordIDDataSet)array[0];
		}

		public void SelectReportByOeordIDAsync(string OEItemRowID)
		{
			this.SelectReportByOeordIDAsync(OEItemRowID, null);
		}

		public void SelectReportByOeordIDAsync(string OEItemRowID, object userState)
		{
			if (this.SelectReportByOeordIDOperationCompleted == null)
			{
				this.SelectReportByOeordIDOperationCompleted = new SendOrPostCallback(this.OnSelectReportByOeordIDOperationCompleted);
			}
			this.InvokeAsync("SelectReportByOeordID", new object[]
			{
				OEItemRowID
			}, this.SelectReportByOeordIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectReportByOeordIDOperationCompleted(object arg)
		{
			if (this.SelectReportByOeordIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectReportByOeordIDCompletedEventHandler selectReportByOeordIDCompletedEvent = this.SelectReportByOeordIDCompletedEvent;
				if (selectReportByOeordIDCompletedEvent != null)
				{
					selectReportByOeordIDCompletedEvent(this, new SelectReportByOeordIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOPACSData.SelectRptStructure", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EPACSRptStructureDataSet SelectRptStructure()
		{
			object[] array = this.Invoke("SelectRptStructure", new object[0]);
			return (EPACSRptStructureDataSet)array[0];
		}

		public void SelectRptStructureAsync()
		{
			this.SelectRptStructureAsync(null);
		}

		public void SelectRptStructureAsync(object userState)
		{
			if (this.SelectRptStructureOperationCompleted == null)
			{
				this.SelectRptStructureOperationCompleted = new SendOrPostCallback(this.OnSelectRptStructureOperationCompleted);
			}
			this.InvokeAsync("SelectRptStructure", new object[0], this.SelectRptStructureOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectRptStructureOperationCompleted(object arg)
		{
			if (this.SelectRptStructureCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectRptStructureCompletedEventHandler selectRptStructureCompletedEvent = this.SelectRptStructureCompletedEvent;
				if (selectRptStructureCompletedEvent != null)
				{
					selectRptStructureCompletedEvent(this, new SelectRptStructureCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
