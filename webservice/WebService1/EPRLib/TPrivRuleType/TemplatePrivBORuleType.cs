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

namespace TPrivRuleType
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "TemplatePriv.BORuleTypeSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class TemplatePrivBORuleType : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetRuleTypeDetailsOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetRuleTypeDetailsCompletedEventHandler GetRuleTypeDetailsCompletedEvent;

		public event GetRuleTypeDetailsCompletedEventHandler GetRuleTypeDetailsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetRuleTypeDetailsCompletedEvent = (GetRuleTypeDetailsCompletedEventHandler)Delegate.Combine(this.GetRuleTypeDetailsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetRuleTypeDetailsCompletedEvent = (GetRuleTypeDetailsCompletedEventHandler)Delegate.Remove(this.GetRuleTypeDetailsCompletedEvent, value);
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

		public TemplatePrivBORuleType()
		{
			this.Url = MySettings.Default.EPRLib_TPrivRuleType_TemplatePriv_BORuleType;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.TemplatePriv.BORuleType.GetRuleTypeDetails", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetRuleTypeDetails(string parDicId)
		{
			object[] array = this.Invoke("GetRuleTypeDetails", new object[]
			{
				parDicId
			});
			return (DataSet)array[0];
		}

		public void GetRuleTypeDetailsAsync(string parDicId)
		{
			this.GetRuleTypeDetailsAsync(parDicId, null);
		}

		public void GetRuleTypeDetailsAsync(string parDicId, object userState)
		{
			if (this.GetRuleTypeDetailsOperationCompleted == null)
			{
				this.GetRuleTypeDetailsOperationCompleted = new SendOrPostCallback(this.OnGetRuleTypeDetailsOperationCompleted);
			}
			this.InvokeAsync("GetRuleTypeDetails", new object[]
			{
				parDicId
			}, this.GetRuleTypeDetailsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetRuleTypeDetailsOperationCompleted(object arg)
		{
			if (this.GetRuleTypeDetailsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetRuleTypeDetailsCompletedEventHandler getRuleTypeDetailsCompletedEvent = this.GetRuleTypeDetailsCompletedEvent;
				if (getRuleTypeDetailsCompletedEvent != null)
				{
					getRuleTypeDetailsCompletedEvent(this, new GetRuleTypeDetailsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
