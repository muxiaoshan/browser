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

namespace HISData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "HISDataServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class HISDataService : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetEpisodeListByPIDOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetEpisodeListByPIDCompletedEventHandler GetEpisodeListByPIDCompletedEvent;

		public event GetEpisodeListByPIDCompletedEventHandler GetEpisodeListByPIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetEpisodeListByPIDCompletedEvent = (GetEpisodeListByPIDCompletedEventHandler)Delegate.Combine(this.GetEpisodeListByPIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetEpisodeListByPIDCompletedEvent = (GetEpisodeListByPIDCompletedEventHandler)Delegate.Remove(this.GetEpisodeListByPIDCompletedEvent, value);
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

		public HISDataService()
		{
			this.Url = MySettings.Default.EPRLib_HISData_HISDataService;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOHISData.GetEpisodeListByPID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EEpisodeListByPIdDataset GetEpisodeListByPID(string PatID)
		{
			object[] array = this.Invoke("GetEpisodeListByPID", new object[]
			{
				PatID
			});
			return (EEpisodeListByPIdDataset)array[0];
		}

		public void GetEpisodeListByPIDAsync(string PatID)
		{
			this.GetEpisodeListByPIDAsync(PatID, null);
		}

		public void GetEpisodeListByPIDAsync(string PatID, object userState)
		{
			if (this.GetEpisodeListByPIDOperationCompleted == null)
			{
				this.GetEpisodeListByPIDOperationCompleted = new SendOrPostCallback(this.OnGetEpisodeListByPIDOperationCompleted);
			}
			this.InvokeAsync("GetEpisodeListByPID", new object[]
			{
				PatID
			}, this.GetEpisodeListByPIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetEpisodeListByPIDOperationCompleted(object arg)
		{
			if (this.GetEpisodeListByPIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetEpisodeListByPIDCompletedEventHandler getEpisodeListByPIDCompletedEvent = this.GetEpisodeListByPIDCompletedEvent;
				if (getEpisodeListByPIDCompletedEvent != null)
				{
					getEpisodeListByPIDCompletedEvent(this, new GetEpisodeListByPIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
