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

namespace LISData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "LISDataInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class LISDataInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetLISDATAListItemsOperationCompleted;

		private SendOrPostCallback GetLISItemListByCountOperationCompleted;

		private SendOrPostCallback GetLISItemListByDateOperationCompleted;

		private SendOrPostCallback GetReportByOeordIDOperationCompleted;

		private SendOrPostCallback SelectLISItemByCateIDOperationCompleted;

		private SendOrPostCallback SelectLISItemCategoryOperationCompleted;

		private SendOrPostCallback SelectLISItemIndicatorsOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetLISDATAListItemsCompletedEventHandler GetLISDATAListItemsCompletedEvent;

		private GetLISItemListByCountCompletedEventHandler GetLISItemListByCountCompletedEvent;

		private GetLISItemListByDateCompletedEventHandler GetLISItemListByDateCompletedEvent;

		private GetReportByOeordIDCompletedEventHandler GetReportByOeordIDCompletedEvent;

		private SelectLISItemByCateIDCompletedEventHandler SelectLISItemByCateIDCompletedEvent;

		private SelectLISItemCategoryCompletedEventHandler SelectLISItemCategoryCompletedEvent;

		private SelectLISItemIndicatorsCompletedEventHandler SelectLISItemIndicatorsCompletedEvent;

		public event GetLISDATAListItemsCompletedEventHandler GetLISDATAListItemsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetLISDATAListItemsCompletedEvent = (GetLISDATAListItemsCompletedEventHandler)Delegate.Combine(this.GetLISDATAListItemsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetLISDATAListItemsCompletedEvent = (GetLISDATAListItemsCompletedEventHandler)Delegate.Remove(this.GetLISDATAListItemsCompletedEvent, value);
			}
		}

		public event GetLISItemListByCountCompletedEventHandler GetLISItemListByCountCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetLISItemListByCountCompletedEvent = (GetLISItemListByCountCompletedEventHandler)Delegate.Combine(this.GetLISItemListByCountCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetLISItemListByCountCompletedEvent = (GetLISItemListByCountCompletedEventHandler)Delegate.Remove(this.GetLISItemListByCountCompletedEvent, value);
			}
		}

		public event GetLISItemListByDateCompletedEventHandler GetLISItemListByDateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetLISItemListByDateCompletedEvent = (GetLISItemListByDateCompletedEventHandler)Delegate.Combine(this.GetLISItemListByDateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetLISItemListByDateCompletedEvent = (GetLISItemListByDateCompletedEventHandler)Delegate.Remove(this.GetLISItemListByDateCompletedEvent, value);
			}
		}

		public event GetReportByOeordIDCompletedEventHandler GetReportByOeordIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetReportByOeordIDCompletedEvent = (GetReportByOeordIDCompletedEventHandler)Delegate.Combine(this.GetReportByOeordIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetReportByOeordIDCompletedEvent = (GetReportByOeordIDCompletedEventHandler)Delegate.Remove(this.GetReportByOeordIDCompletedEvent, value);
			}
		}

		public event SelectLISItemByCateIDCompletedEventHandler SelectLISItemByCateIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectLISItemByCateIDCompletedEvent = (SelectLISItemByCateIDCompletedEventHandler)Delegate.Combine(this.SelectLISItemByCateIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectLISItemByCateIDCompletedEvent = (SelectLISItemByCateIDCompletedEventHandler)Delegate.Remove(this.SelectLISItemByCateIDCompletedEvent, value);
			}
		}

		public event SelectLISItemCategoryCompletedEventHandler SelectLISItemCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectLISItemCategoryCompletedEvent = (SelectLISItemCategoryCompletedEventHandler)Delegate.Combine(this.SelectLISItemCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectLISItemCategoryCompletedEvent = (SelectLISItemCategoryCompletedEventHandler)Delegate.Remove(this.SelectLISItemCategoryCompletedEvent, value);
			}
		}

		public event SelectLISItemIndicatorsCompletedEventHandler SelectLISItemIndicatorsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectLISItemIndicatorsCompletedEvent = (SelectLISItemIndicatorsCompletedEventHandler)Delegate.Combine(this.SelectLISItemIndicatorsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectLISItemIndicatorsCompletedEvent = (SelectLISItemIndicatorsCompletedEventHandler)Delegate.Remove(this.SelectLISItemIndicatorsCompletedEvent, value);
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

		public LISDataInfo()
		{
			this.Url = MySettings.Default.EPRLib_LISData_LISDataInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.GetLISDATAListItems", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ELISDataListDataSet GetLISDATAListItems(string AID, string AStDate, string AEdDate, string AStPage, string AEdPage, string AFlag)
		{
			object[] array = this.Invoke("GetLISDATAListItems", new object[]
			{
				AID,
				AStDate,
				AEdDate,
				AStPage,
				AEdPage,
				AFlag
			});
			return (ELISDataListDataSet)array[0];
		}

		public void GetLISDATAListItemsAsync(string AID, string AStDate, string AEdDate, string AStPage, string AEdPage, string AFlag)
		{
			this.GetLISDATAListItemsAsync(AID, AStDate, AEdDate, AStPage, AEdPage, AFlag, null);
		}

		public void GetLISDATAListItemsAsync(string AID, string AStDate, string AEdDate, string AStPage, string AEdPage, string AFlag, object userState)
		{
			if (this.GetLISDATAListItemsOperationCompleted == null)
			{
				this.GetLISDATAListItemsOperationCompleted = new SendOrPostCallback(this.OnGetLISDATAListItemsOperationCompleted);
			}
			this.InvokeAsync("GetLISDATAListItems", new object[]
			{
				AID,
				AStDate,
				AEdDate,
				AStPage,
				AEdPage,
				AFlag
			}, this.GetLISDATAListItemsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetLISDATAListItemsOperationCompleted(object arg)
		{
			if (this.GetLISDATAListItemsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetLISDATAListItemsCompletedEventHandler getLISDATAListItemsCompletedEvent = this.GetLISDATAListItemsCompletedEvent;
				if (getLISDATAListItemsCompletedEvent != null)
				{
					getLISDATAListItemsCompletedEvent(this, new GetLISDATAListItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.GetLISItemListByCount", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ELISItemListByCountDataset GetLISItemListByCount(string EpisodeID, string StCount, string EndCount)
		{
			object[] array = this.Invoke("GetLISItemListByCount", new object[]
			{
				EpisodeID,
				StCount,
				EndCount
			});
			return (ELISItemListByCountDataset)array[0];
		}

		public void GetLISItemListByCountAsync(string EpisodeID, string StCount, string EndCount)
		{
			this.GetLISItemListByCountAsync(EpisodeID, StCount, EndCount, null);
		}

		public void GetLISItemListByCountAsync(string EpisodeID, string StCount, string EndCount, object userState)
		{
			if (this.GetLISItemListByCountOperationCompleted == null)
			{
				this.GetLISItemListByCountOperationCompleted = new SendOrPostCallback(this.OnGetLISItemListByCountOperationCompleted);
			}
			this.InvokeAsync("GetLISItemListByCount", new object[]
			{
				EpisodeID,
				StCount,
				EndCount
			}, this.GetLISItemListByCountOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetLISItemListByCountOperationCompleted(object arg)
		{
			if (this.GetLISItemListByCountCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetLISItemListByCountCompletedEventHandler getLISItemListByCountCompletedEvent = this.GetLISItemListByCountCompletedEvent;
				if (getLISItemListByCountCompletedEvent != null)
				{
					getLISItemListByCountCompletedEvent(this, new GetLISItemListByCountCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.GetLISItemListByDate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ELISItemListByDateDataSet GetLISItemListByDate(string EpisodeID, string StDate, string EndDate)
		{
			object[] array = this.Invoke("GetLISItemListByDate", new object[]
			{
				EpisodeID,
				StDate,
				EndDate
			});
			return (ELISItemListByDateDataSet)array[0];
		}

		public void GetLISItemListByDateAsync(string EpisodeID, string StDate, string EndDate)
		{
			this.GetLISItemListByDateAsync(EpisodeID, StDate, EndDate, null);
		}

		public void GetLISItemListByDateAsync(string EpisodeID, string StDate, string EndDate, object userState)
		{
			if (this.GetLISItemListByDateOperationCompleted == null)
			{
				this.GetLISItemListByDateOperationCompleted = new SendOrPostCallback(this.OnGetLISItemListByDateOperationCompleted);
			}
			this.InvokeAsync("GetLISItemListByDate", new object[]
			{
				EpisodeID,
				StDate,
				EndDate
			}, this.GetLISItemListByDateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetLISItemListByDateOperationCompleted(object arg)
		{
			if (this.GetLISItemListByDateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetLISItemListByDateCompletedEventHandler getLISItemListByDateCompletedEvent = this.GetLISItemListByDateCompletedEvent;
				if (getLISItemListByDateCompletedEvent != null)
				{
					getLISItemListByDateCompletedEvent(this, new GetLISItemListByDateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.GetReportByOeordID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ELISReportByOeordIDDataSet GetReportByOeordID(string OeordID)
		{
			object[] array = this.Invoke("GetReportByOeordID", new object[]
			{
				OeordID
			});
			return (ELISReportByOeordIDDataSet)array[0];
		}

		public void GetReportByOeordIDAsync(string OeordID)
		{
			this.GetReportByOeordIDAsync(OeordID, null);
		}

		public void GetReportByOeordIDAsync(string OeordID, object userState)
		{
			if (this.GetReportByOeordIDOperationCompleted == null)
			{
				this.GetReportByOeordIDOperationCompleted = new SendOrPostCallback(this.OnGetReportByOeordIDOperationCompleted);
			}
			this.InvokeAsync("GetReportByOeordID", new object[]
			{
				OeordID
			}, this.GetReportByOeordIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetReportByOeordIDOperationCompleted(object arg)
		{
			if (this.GetReportByOeordIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetReportByOeordIDCompletedEventHandler getReportByOeordIDCompletedEvent = this.GetReportByOeordIDCompletedEvent;
				if (getReportByOeordIDCompletedEvent != null)
				{
					getReportByOeordIDCompletedEvent(this, new GetReportByOeordIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.SelectLISItemByCateID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet SelectLISItemByCateID(string aCategoryID)
		{
			object[] array = this.Invoke("SelectLISItemByCateID", new object[]
			{
				aCategoryID
			});
			return (DataSet)array[0];
		}

		public void SelectLISItemByCateIDAsync(string aCategoryID)
		{
			this.SelectLISItemByCateIDAsync(aCategoryID, null);
		}

		public void SelectLISItemByCateIDAsync(string aCategoryID, object userState)
		{
			if (this.SelectLISItemByCateIDOperationCompleted == null)
			{
				this.SelectLISItemByCateIDOperationCompleted = new SendOrPostCallback(this.OnSelectLISItemByCateIDOperationCompleted);
			}
			this.InvokeAsync("SelectLISItemByCateID", new object[]
			{
				aCategoryID
			}, this.SelectLISItemByCateIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectLISItemByCateIDOperationCompleted(object arg)
		{
			if (this.SelectLISItemByCateIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectLISItemByCateIDCompletedEventHandler selectLISItemByCateIDCompletedEvent = this.SelectLISItemByCateIDCompletedEvent;
				if (selectLISItemByCateIDCompletedEvent != null)
				{
					selectLISItemByCateIDCompletedEvent(this, new SelectLISItemByCateIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.SelectLISItemCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet SelectLISItemCategory()
		{
			object[] array = this.Invoke("SelectLISItemCategory", new object[0]);
			return (DataSet)array[0];
		}

		public void SelectLISItemCategoryAsync()
		{
			this.SelectLISItemCategoryAsync(null);
		}

		public void SelectLISItemCategoryAsync(object userState)
		{
			if (this.SelectLISItemCategoryOperationCompleted == null)
			{
				this.SelectLISItemCategoryOperationCompleted = new SendOrPostCallback(this.OnSelectLISItemCategoryOperationCompleted);
			}
			this.InvokeAsync("SelectLISItemCategory", new object[0], this.SelectLISItemCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectLISItemCategoryOperationCompleted(object arg)
		{
			if (this.SelectLISItemCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectLISItemCategoryCompletedEventHandler selectLISItemCategoryCompletedEvent = this.SelectLISItemCategoryCompletedEvent;
				if (selectLISItemCategoryCompletedEvent != null)
				{
					selectLISItemCategoryCompletedEvent(this, new SelectLISItemCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOLISData.SelectLISItemIndicators", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet SelectLISItemIndicators(string aItemID)
		{
			object[] array = this.Invoke("SelectLISItemIndicators", new object[]
			{
				aItemID
			});
			return (DataSet)array[0];
		}

		public void SelectLISItemIndicatorsAsync(string aItemID)
		{
			this.SelectLISItemIndicatorsAsync(aItemID, null);
		}

		public void SelectLISItemIndicatorsAsync(string aItemID, object userState)
		{
			if (this.SelectLISItemIndicatorsOperationCompleted == null)
			{
				this.SelectLISItemIndicatorsOperationCompleted = new SendOrPostCallback(this.OnSelectLISItemIndicatorsOperationCompleted);
			}
			this.InvokeAsync("SelectLISItemIndicators", new object[]
			{
				aItemID
			}, this.SelectLISItemIndicatorsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectLISItemIndicatorsOperationCompleted(object arg)
		{
			if (this.SelectLISItemIndicatorsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectLISItemIndicatorsCompletedEventHandler selectLISItemIndicatorsCompletedEvent = this.SelectLISItemIndicatorsCompletedEvent;
				if (selectLISItemIndicatorsCompletedEvent != null)
				{
					selectLISItemIndicatorsCompletedEvent(this, new SelectLISItemIndicatorsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
