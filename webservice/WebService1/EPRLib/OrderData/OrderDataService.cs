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

namespace OrderData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "OrderDataServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class OrderDataService : SoapHttpClientProtocol
	{
		private SendOrPostCallback SelectOrderListOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private SelectOrderListCompletedEventHandler SelectOrderListCompletedEvent;

		public event SelectOrderListCompletedEventHandler SelectOrderListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectOrderListCompletedEvent = (SelectOrderListCompletedEventHandler)Delegate.Combine(this.SelectOrderListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectOrderListCompletedEvent = (SelectOrderListCompletedEventHandler)Delegate.Remove(this.SelectOrderListCompletedEvent, value);
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

		public OrderDataService()
		{
			this.Url = MySettings.Default.EPRLib_OrderData_OrderDataService;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOOrderData.SelectOrderList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public OrderListByDataSet SelectOrderList(string EpisodeID, string SearchStartDate, string SearchEndDate, string CategoryID, string SubsortID, string LongOrd, string ShortOrd, string OrdStat)
		{
			object[] array = this.Invoke("SelectOrderList", new object[]
			{
				EpisodeID,
				SearchStartDate,
				SearchEndDate,
				CategoryID,
				SubsortID,
				LongOrd,
				ShortOrd,
				OrdStat
			});
			return (OrderListByDataSet)array[0];
		}

		public void SelectOrderListAsync(string EpisodeID, string SearchStartDate, string SearchEndDate, string CategoryID, string SubsortID, string LongOrd, string ShortOrd, string OrdStat)
		{
			this.SelectOrderListAsync(EpisodeID, SearchStartDate, SearchEndDate, CategoryID, SubsortID, LongOrd, ShortOrd, OrdStat, null);
		}

		public void SelectOrderListAsync(string EpisodeID, string SearchStartDate, string SearchEndDate, string CategoryID, string SubsortID, string LongOrd, string ShortOrd, string OrdStat, object userState)
		{
			if (this.SelectOrderListOperationCompleted == null)
			{
				this.SelectOrderListOperationCompleted = new SendOrPostCallback(this.OnSelectOrderListOperationCompleted);
			}
			this.InvokeAsync("SelectOrderList", new object[]
			{
				EpisodeID,
				SearchStartDate,
				SearchEndDate,
				CategoryID,
				SubsortID,
				LongOrd,
				ShortOrd,
				OrdStat
			}, this.SelectOrderListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectOrderListOperationCompleted(object arg)
		{
			if (this.SelectOrderListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectOrderListCompletedEventHandler selectOrderListCompletedEvent = this.SelectOrderListCompletedEvent;
				if (selectOrderListCompletedEvent != null)
				{
					selectOrderListCompletedEvent(this, new SelectOrderListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
