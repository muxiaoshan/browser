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

namespace CustomDictoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "CustomDictoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class CustomDictoryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetAllDiagnosTypeByTitleOperationCompleted;

		private SendOrPostCallback GetTeethPestionOperationCompleted;

		private SendOrPostCallback GetTitleBYTidOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetAllDiagnosTypeByTitleCompletedEventHandler GetAllDiagnosTypeByTitleCompletedEvent;

		private GetTeethPestionCompletedEventHandler GetTeethPestionCompletedEvent;

		private GetTitleBYTidCompletedEventHandler GetTitleBYTidCompletedEvent;

		public event GetAllDiagnosTypeByTitleCompletedEventHandler GetAllDiagnosTypeByTitleCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllDiagnosTypeByTitleCompletedEvent = (GetAllDiagnosTypeByTitleCompletedEventHandler)Delegate.Combine(this.GetAllDiagnosTypeByTitleCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllDiagnosTypeByTitleCompletedEvent = (GetAllDiagnosTypeByTitleCompletedEventHandler)Delegate.Remove(this.GetAllDiagnosTypeByTitleCompletedEvent, value);
			}
		}

		public event GetTeethPestionCompletedEventHandler GetTeethPestionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTeethPestionCompletedEvent = (GetTeethPestionCompletedEventHandler)Delegate.Combine(this.GetTeethPestionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTeethPestionCompletedEvent = (GetTeethPestionCompletedEventHandler)Delegate.Remove(this.GetTeethPestionCompletedEvent, value);
			}
		}

		public event GetTitleBYTidCompletedEventHandler GetTitleBYTidCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTitleBYTidCompletedEvent = (GetTitleBYTidCompletedEventHandler)Delegate.Combine(this.GetTitleBYTidCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTitleBYTidCompletedEvent = (GetTitleBYTidCompletedEventHandler)Delegate.Remove(this.GetTitleBYTidCompletedEvent, value);
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

		public CustomDictoryInfo()
		{
			this.Url = MySettings.Default.EPRLib_CustomDictoryData_CustomDictoryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOCustomDictory.GetAllDiagnosTypeByTitle", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EDiagnosTypeByTitle GetAllDiagnosTypeByTitle()
		{
			object[] array = this.Invoke("GetAllDiagnosTypeByTitle", new object[0]);
			return (EDiagnosTypeByTitle)array[0];
		}

		public void GetAllDiagnosTypeByTitleAsync()
		{
			this.GetAllDiagnosTypeByTitleAsync(null);
		}

		public void GetAllDiagnosTypeByTitleAsync(object userState)
		{
			if (this.GetAllDiagnosTypeByTitleOperationCompleted == null)
			{
				this.GetAllDiagnosTypeByTitleOperationCompleted = new SendOrPostCallback(this.OnGetAllDiagnosTypeByTitleOperationCompleted);
			}
			this.InvokeAsync("GetAllDiagnosTypeByTitle", new object[0], this.GetAllDiagnosTypeByTitleOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllDiagnosTypeByTitleOperationCompleted(object arg)
		{
			if (this.GetAllDiagnosTypeByTitleCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllDiagnosTypeByTitleCompletedEventHandler getAllDiagnosTypeByTitleCompletedEvent = this.GetAllDiagnosTypeByTitleCompletedEvent;
				if (getAllDiagnosTypeByTitleCompletedEvent != null)
				{
					getAllDiagnosTypeByTitleCompletedEvent(this, new GetAllDiagnosTypeByTitleCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOCustomDictory.GetTeethPestion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETeethPestion GetTeethPestion()
		{
			object[] array = this.Invoke("GetTeethPestion", new object[0]);
			return (ETeethPestion)array[0];
		}

		public void GetTeethPestionAsync()
		{
			this.GetTeethPestionAsync(null);
		}

		public void GetTeethPestionAsync(object userState)
		{
			if (this.GetTeethPestionOperationCompleted == null)
			{
				this.GetTeethPestionOperationCompleted = new SendOrPostCallback(this.OnGetTeethPestionOperationCompleted);
			}
			this.InvokeAsync("GetTeethPestion", new object[0], this.GetTeethPestionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTeethPestionOperationCompleted(object arg)
		{
			if (this.GetTeethPestionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTeethPestionCompletedEventHandler getTeethPestionCompletedEvent = this.GetTeethPestionCompletedEvent;
				if (getTeethPestionCompletedEvent != null)
				{
					getTeethPestionCompletedEvent(this, new GetTeethPestionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOCustomDictory.GetTitleBYTid", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetTitleBYTid(string TID)
		{
			object[] array = this.Invoke("GetTitleBYTid", new object[]
			{
				TID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetTitleBYTidAsync(string TID)
		{
			this.GetTitleBYTidAsync(TID, null);
		}

		public void GetTitleBYTidAsync(string TID, object userState)
		{
			if (this.GetTitleBYTidOperationCompleted == null)
			{
				this.GetTitleBYTidOperationCompleted = new SendOrPostCallback(this.OnGetTitleBYTidOperationCompleted);
			}
			this.InvokeAsync("GetTitleBYTid", new object[]
			{
				TID
			}, this.GetTitleBYTidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTitleBYTidOperationCompleted(object arg)
		{
			if (this.GetTitleBYTidCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTitleBYTidCompletedEventHandler getTitleBYTidCompletedEvent = this.GetTitleBYTidCompletedEvent;
				if (getTitleBYTidCompletedEvent != null)
				{
					getTitleBYTidCompletedEvent(this, new GetTitleBYTidCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
