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
using System.Xml.Serialization;

namespace SystemServiceData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "SystemInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class SystemInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetDateTimeOperationCompleted;

		private SendOrPostCallback SysDateOperationCompleted;

		private SendOrPostCallback SysTimeOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetDateTimeCompletedEventHandler GetDateTimeCompletedEvent;

		private SysDateCompletedEventHandler SysDateCompletedEvent;

		private SysTimeCompletedEventHandler SysTimeCompletedEvent;

		public event GetDateTimeCompletedEventHandler GetDateTimeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDateTimeCompletedEvent = (GetDateTimeCompletedEventHandler)Delegate.Combine(this.GetDateTimeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDateTimeCompletedEvent = (GetDateTimeCompletedEventHandler)Delegate.Remove(this.GetDateTimeCompletedEvent, value);
			}
		}

		public event SysDateCompletedEventHandler SysDateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SysDateCompletedEvent = (SysDateCompletedEventHandler)Delegate.Combine(this.SysDateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SysDateCompletedEvent = (SysDateCompletedEventHandler)Delegate.Remove(this.SysDateCompletedEvent, value);
			}
		}

		public event SysTimeCompletedEventHandler SysTimeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SysTimeCompletedEvent = (SysTimeCompletedEventHandler)Delegate.Combine(this.SysTimeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SysTimeCompletedEvent = (SysTimeCompletedEventHandler)Delegate.Remove(this.SysTimeCompletedEvent, value);
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

		public SystemInfo()
		{
			this.Url = MySettings.Default.EPRLib_SystemServiceData_SystemInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSystemService.GetDateTime", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetDateTime()
		{
			object[] array = this.Invoke("GetDateTime", new object[0]);
			return Conversions.ToString(array[0]);
		}

		public void GetDateTimeAsync()
		{
			this.GetDateTimeAsync(null);
		}

		public void GetDateTimeAsync(object userState)
		{
			if (this.GetDateTimeOperationCompleted == null)
			{
				this.GetDateTimeOperationCompleted = new SendOrPostCallback(this.OnGetDateTimeOperationCompleted);
			}
			this.InvokeAsync("GetDateTime", new object[0], this.GetDateTimeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDateTimeOperationCompleted(object arg)
		{
			if (this.GetDateTimeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDateTimeCompletedEventHandler getDateTimeCompletedEvent = this.GetDateTimeCompletedEvent;
				if (getDateTimeCompletedEvent != null)
				{
					getDateTimeCompletedEvent(this, new GetDateTimeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSystemService.SysDate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SysDate([XmlElement(DataType = "date")] ref DateTime SysDateResult, [XmlElement(DataType = "date"), XmlIgnore] ref bool SysDateResultSpecified)
		{
			object[] array = this.Invoke("SysDate", new object[0]);
			SysDateResult = Conversions.ToDate(array[0]);
			SysDateResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void SysDateAsync()
		{
			this.SysDateAsync(null);
		}

		public void SysDateAsync(object userState)
		{
			if (this.SysDateOperationCompleted == null)
			{
				this.SysDateOperationCompleted = new SendOrPostCallback(this.OnSysDateOperationCompleted);
			}
			this.InvokeAsync("SysDate", new object[0], this.SysDateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSysDateOperationCompleted(object arg)
		{
			if (this.SysDateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SysDateCompletedEventHandler sysDateCompletedEvent = this.SysDateCompletedEvent;
				if (sysDateCompletedEvent != null)
				{
					sysDateCompletedEvent(this, new SysDateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSystemService.SysTime", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SysTime([XmlElement(DataType = "time")] ref DateTime SysTimeResult, [XmlElement(DataType = "time"), XmlIgnore] ref bool SysTimeResultSpecified)
		{
			object[] array = this.Invoke("SysTime", new object[0]);
			SysTimeResult = Conversions.ToDate(array[0]);
			SysTimeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void SysTimeAsync()
		{
			this.SysTimeAsync(null);
		}

		public void SysTimeAsync(object userState)
		{
			if (this.SysTimeOperationCompleted == null)
			{
				this.SysTimeOperationCompleted = new SendOrPostCallback(this.OnSysTimeOperationCompleted);
			}
			this.InvokeAsync("SysTime", new object[0], this.SysTimeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSysTimeOperationCompleted(object arg)
		{
			if (this.SysTimeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SysTimeCompletedEventHandler sysTimeCompletedEvent = this.SysTimeCompletedEvent;
				if (sysTimeCompletedEvent != null)
				{
					sysTimeCompletedEvent(this, new SysTimeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
