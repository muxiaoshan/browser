using Microsoft.VisualBasic.CompilerServices;
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

namespace GateWayDataInfo
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "DataGatewayInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class DataGatewayInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback DBInterFaceOperationCompleted;

		private SendOrPostCallback DBInterFaceByStreamOperationCompleted;

		private SendOrPostCallback GetDataByQueryNameOperationCompleted;

		private SendOrPostCallback GetParameterStringOperationCompleted;

		private SendOrPostCallback TestQueryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private DBInterFaceCompletedEventHandler DBInterFaceCompletedEvent;

		private DBInterFaceByStreamCompletedEventHandler DBInterFaceByStreamCompletedEvent;

		private GetDataByQueryNameCompletedEventHandler GetDataByQueryNameCompletedEvent;

		private GetParameterStringCompletedEventHandler GetParameterStringCompletedEvent;

		private TestQueryCompletedEventHandler TestQueryCompletedEvent;

		public event DBInterFaceCompletedEventHandler DBInterFaceCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DBInterFaceCompletedEvent = (DBInterFaceCompletedEventHandler)Delegate.Combine(this.DBInterFaceCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DBInterFaceCompletedEvent = (DBInterFaceCompletedEventHandler)Delegate.Remove(this.DBInterFaceCompletedEvent, value);
			}
		}

		public event DBInterFaceByStreamCompletedEventHandler DBInterFaceByStreamCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DBInterFaceByStreamCompletedEvent = (DBInterFaceByStreamCompletedEventHandler)Delegate.Combine(this.DBInterFaceByStreamCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DBInterFaceByStreamCompletedEvent = (DBInterFaceByStreamCompletedEventHandler)Delegate.Remove(this.DBInterFaceByStreamCompletedEvent, value);
			}
		}

		public event GetDataByQueryNameCompletedEventHandler GetDataByQueryNameCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDataByQueryNameCompletedEvent = (GetDataByQueryNameCompletedEventHandler)Delegate.Combine(this.GetDataByQueryNameCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDataByQueryNameCompletedEvent = (GetDataByQueryNameCompletedEventHandler)Delegate.Remove(this.GetDataByQueryNameCompletedEvent, value);
			}
		}

		public event GetParameterStringCompletedEventHandler GetParameterStringCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetParameterStringCompletedEvent = (GetParameterStringCompletedEventHandler)Delegate.Combine(this.GetParameterStringCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetParameterStringCompletedEvent = (GetParameterStringCompletedEventHandler)Delegate.Remove(this.GetParameterStringCompletedEvent, value);
			}
		}

		public event TestQueryCompletedEventHandler TestQueryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.TestQueryCompletedEvent = (TestQueryCompletedEventHandler)Delegate.Combine(this.TestQueryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.TestQueryCompletedEvent = (TestQueryCompletedEventHandler)Delegate.Remove(this.TestQueryCompletedEvent, value);
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

		public DataGatewayInfo()
		{
			this.Url = MySettings.Default.EPRLib_GateWayDataInfo_DataGatewayInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.DBInterFace", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string DBInterFace(string AReciveString)
		{
			object[] array = this.Invoke("DBInterFace", new object[]
			{
				AReciveString
			});
			return Conversions.ToString(array[0]);
		}

		public void DBInterFaceAsync(string AReciveString)
		{
			this.DBInterFaceAsync(AReciveString, null);
		}

		public void DBInterFaceAsync(string AReciveString, object userState)
		{
			if (this.DBInterFaceOperationCompleted == null)
			{
				this.DBInterFaceOperationCompleted = new SendOrPostCallback(this.OnDBInterFaceOperationCompleted);
			}
			this.InvokeAsync("DBInterFace", new object[]
			{
				AReciveString
			}, this.DBInterFaceOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDBInterFaceOperationCompleted(object arg)
		{
			if (this.DBInterFaceCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DBInterFaceCompletedEventHandler dBInterFaceCompletedEvent = this.DBInterFaceCompletedEvent;
				if (dBInterFaceCompletedEvent != null)
				{
					dBInterFaceCompletedEvent(this, new DBInterFaceCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.DBInterFaceByStream", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ReStreamData DBInterFaceByStream(string AReciveString)
		{
			object[] array = this.Invoke("DBInterFaceByStream", new object[]
			{
				AReciveString
			});
			return (ReStreamData)array[0];
		}

		public void DBInterFaceByStreamAsync(string AReciveString)
		{
			this.DBInterFaceByStreamAsync(AReciveString, null);
		}

		public void DBInterFaceByStreamAsync(string AReciveString, object userState)
		{
			if (this.DBInterFaceByStreamOperationCompleted == null)
			{
				this.DBInterFaceByStreamOperationCompleted = new SendOrPostCallback(this.OnDBInterFaceByStreamOperationCompleted);
			}
			this.InvokeAsync("DBInterFaceByStream", new object[]
			{
				AReciveString
			}, this.DBInterFaceByStreamOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDBInterFaceByStreamOperationCompleted(object arg)
		{
			if (this.DBInterFaceByStreamCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DBInterFaceByStreamCompletedEventHandler dBInterFaceByStreamCompletedEvent = this.DBInterFaceByStreamCompletedEvent;
				if (dBInterFaceByStreamCompletedEvent != null)
				{
					dBInterFaceByStreamCompletedEvent(this, new DBInterFaceByStreamCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.GetDataByQueryName", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetDataByQueryName(string AClassName, string AQueryName, string AParameterS)
		{
			object[] array = this.Invoke("GetDataByQueryName", new object[]
			{
				AClassName,
				AQueryName,
				AParameterS
			});
			return (DataSet)array[0];
		}

		public void GetDataByQueryNameAsync(string AClassName, string AQueryName, string AParameterS)
		{
			this.GetDataByQueryNameAsync(AClassName, AQueryName, AParameterS, null);
		}

		public void GetDataByQueryNameAsync(string AClassName, string AQueryName, string AParameterS, object userState)
		{
			if (this.GetDataByQueryNameOperationCompleted == null)
			{
				this.GetDataByQueryNameOperationCompleted = new SendOrPostCallback(this.OnGetDataByQueryNameOperationCompleted);
			}
			this.InvokeAsync("GetDataByQueryName", new object[]
			{
				AClassName,
				AQueryName,
				AParameterS
			}, this.GetDataByQueryNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDataByQueryNameOperationCompleted(object arg)
		{
			if (this.GetDataByQueryNameCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDataByQueryNameCompletedEventHandler getDataByQueryNameCompletedEvent = this.GetDataByQueryNameCompletedEvent;
				if (getDataByQueryNameCompletedEvent != null)
				{
					getDataByQueryNameCompletedEvent(this, new GetDataByQueryNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.GetParameterString", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetParameterString(string AClassName, string AQueryName)
		{
			object[] array = this.Invoke("GetParameterString", new object[]
			{
				AClassName,
				AQueryName
			});
			return Conversions.ToString(array[0]);
		}

		public void GetParameterStringAsync(string AClassName, string AQueryName)
		{
			this.GetParameterStringAsync(AClassName, AQueryName, null);
		}

		public void GetParameterStringAsync(string AClassName, string AQueryName, object userState)
		{
			if (this.GetParameterStringOperationCompleted == null)
			{
				this.GetParameterStringOperationCompleted = new SendOrPostCallback(this.OnGetParameterStringOperationCompleted);
			}
			this.InvokeAsync("GetParameterString", new object[]
			{
				AClassName,
				AQueryName
			}, this.GetParameterStringOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetParameterStringOperationCompleted(object arg)
		{
			if (this.GetParameterStringCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetParameterStringCompletedEventHandler getParameterStringCompletedEvent = this.GetParameterStringCompletedEvent;
				if (getParameterStringCompletedEvent != null)
				{
					getParameterStringCompletedEvent(this, new GetParameterStringCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BODataGateway.TestQuery", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet TestQuery()
		{
			object[] array = this.Invoke("TestQuery", new object[0]);
			return (DataSet)array[0];
		}

		public void TestQueryAsync()
		{
			this.TestQueryAsync(null);
		}

		public void TestQueryAsync(object userState)
		{
			if (this.TestQueryOperationCompleted == null)
			{
				this.TestQueryOperationCompleted = new SendOrPostCallback(this.OnTestQueryOperationCompleted);
			}
			this.InvokeAsync("TestQuery", new object[0], this.TestQueryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnTestQueryOperationCompleted(object arg)
		{
			if (this.TestQueryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				TestQueryCompletedEventHandler testQueryCompletedEvent = this.TestQueryCompletedEvent;
				if (testQueryCompletedEvent != null)
				{
					testQueryCompletedEvent(this, new TestQueryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
