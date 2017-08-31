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

namespace KBNodeDiagnosRule
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KBNodeDiagnosRuleInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KBNodeDiagnosRuleInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback DeleteOperationCompleted;

		private SendOrPostCallback InsertOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private DeleteCompletedEventHandler DeleteCompletedEvent;

		private InsertCompletedEventHandler InsertCompletedEvent;

		public event DeleteCompletedEventHandler DeleteCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteCompletedEvent = (DeleteCompletedEventHandler)Delegate.Combine(this.DeleteCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteCompletedEvent = (DeleteCompletedEventHandler)Delegate.Remove(this.DeleteCompletedEvent, value);
			}
		}

		public event InsertCompletedEventHandler InsertCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.InsertCompletedEvent = (InsertCompletedEventHandler)Delegate.Combine(this.InsertCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.InsertCompletedEvent = (InsertCompletedEventHandler)Delegate.Remove(this.InsertCompletedEvent, value);
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

		public KBNodeDiagnosRuleInfo()
		{
			this.Url = MySettings.Default.EPRLib_KBNodeDiagnosRule_KBNodeDiagnosRuleInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNodeDiagnosRule.Delete", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Delete(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode)
		{
			object[] array = this.Invoke("Delete", new object[]
			{
				AKBNodeDiagnosID,
				ARuleID,
				ARuleParamCode
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteAsync(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode)
		{
			this.DeleteAsync(AKBNodeDiagnosID, ARuleID, ARuleParamCode, null);
		}

		public void DeleteAsync(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode, object userState)
		{
			if (this.DeleteOperationCompleted == null)
			{
				this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
			}
			this.InvokeAsync("Delete", new object[]
			{
				AKBNodeDiagnosID,
				ARuleID,
				ARuleParamCode
			}, this.DeleteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteOperationCompleted(object arg)
		{
			if (this.DeleteCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteCompletedEventHandler deleteCompletedEvent = this.DeleteCompletedEvent;
				if (deleteCompletedEvent != null)
				{
					deleteCompletedEvent(this, new DeleteCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNodeDiagnosRule.Insert", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Insert(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode, string ARuleParamDesc)
		{
			object[] array = this.Invoke("Insert", new object[]
			{
				AKBNodeDiagnosID,
				ARuleID,
				ARuleParamCode,
				ARuleParamDesc
			});
			return Conversions.ToString(array[0]);
		}

		public void InsertAsync(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode, string ARuleParamDesc)
		{
			this.InsertAsync(AKBNodeDiagnosID, ARuleID, ARuleParamCode, ARuleParamDesc, null);
		}

		public void InsertAsync(string AKBNodeDiagnosID, string ARuleID, string ARuleParamCode, string ARuleParamDesc, object userState)
		{
			if (this.InsertOperationCompleted == null)
			{
				this.InsertOperationCompleted = new SendOrPostCallback(this.OnInsertOperationCompleted);
			}
			this.InvokeAsync("Insert", new object[]
			{
				AKBNodeDiagnosID,
				ARuleID,
				ARuleParamCode,
				ARuleParamDesc
			}, this.InsertOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnInsertOperationCompleted(object arg)
		{
			if (this.InsertCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				InsertCompletedEventHandler insertCompletedEvent = this.InsertCompletedEvent;
				if (insertCompletedEvent != null)
				{
					insertCompletedEvent(this, new InsertCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
