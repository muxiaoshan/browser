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

namespace GlossaryItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "GlossaryItemInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class GlossaryItemInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetGlossaryItemsOperationCompleted;

		private SendOrPostCallback GetGlossaryKBItemsOperationCompleted;

		private SendOrPostCallback UpdateGlossaryItemsOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetGlossaryItemsCompletedEventHandler GetGlossaryItemsCompletedEvent;

		private GetGlossaryKBItemsCompletedEventHandler GetGlossaryKBItemsCompletedEvent;

		private UpdateGlossaryItemsCompletedEventHandler UpdateGlossaryItemsCompletedEvent;

		public event GetGlossaryItemsCompletedEventHandler GetGlossaryItemsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetGlossaryItemsCompletedEvent = (GetGlossaryItemsCompletedEventHandler)Delegate.Combine(this.GetGlossaryItemsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetGlossaryItemsCompletedEvent = (GetGlossaryItemsCompletedEventHandler)Delegate.Remove(this.GetGlossaryItemsCompletedEvent, value);
			}
		}

		public event GetGlossaryKBItemsCompletedEventHandler GetGlossaryKBItemsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetGlossaryKBItemsCompletedEvent = (GetGlossaryKBItemsCompletedEventHandler)Delegate.Combine(this.GetGlossaryKBItemsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetGlossaryKBItemsCompletedEvent = (GetGlossaryKBItemsCompletedEventHandler)Delegate.Remove(this.GetGlossaryKBItemsCompletedEvent, value);
			}
		}

		public event UpdateGlossaryItemsCompletedEventHandler UpdateGlossaryItemsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateGlossaryItemsCompletedEvent = (UpdateGlossaryItemsCompletedEventHandler)Delegate.Combine(this.UpdateGlossaryItemsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateGlossaryItemsCompletedEvent = (UpdateGlossaryItemsCompletedEventHandler)Delegate.Remove(this.UpdateGlossaryItemsCompletedEvent, value);
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

		public GlossaryItemInfo()
		{
			this.Url = MySettings.Default.EPRLib_GlossaryItemData_GlossaryItemInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryItem.GetGlossaryItems", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossaryItemDataset GetGlossaryItems(string AGlossaryID)
		{
			object[] array = this.Invoke("GetGlossaryItems", new object[]
			{
				AGlossaryID
			});
			return (EGlossaryItemDataset)array[0];
		}

		public void GetGlossaryItemsAsync(string AGlossaryID)
		{
			this.GetGlossaryItemsAsync(AGlossaryID, null);
		}

		public void GetGlossaryItemsAsync(string AGlossaryID, object userState)
		{
			if (this.GetGlossaryItemsOperationCompleted == null)
			{
				this.GetGlossaryItemsOperationCompleted = new SendOrPostCallback(this.OnGetGlossaryItemsOperationCompleted);
			}
			this.InvokeAsync("GetGlossaryItems", new object[]
			{
				AGlossaryID
			}, this.GetGlossaryItemsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetGlossaryItemsOperationCompleted(object arg)
		{
			if (this.GetGlossaryItemsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetGlossaryItemsCompletedEventHandler getGlossaryItemsCompletedEvent = this.GetGlossaryItemsCompletedEvent;
				if (getGlossaryItemsCompletedEvent != null)
				{
					getGlossaryItemsCompletedEvent(this, new GetGlossaryItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryItem.GetGlossaryKBItems", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossaryKBItemDataset GetGlossaryKBItems(string AGlossaryID)
		{
			object[] array = this.Invoke("GetGlossaryKBItems", new object[]
			{
				AGlossaryID
			});
			return (EGlossaryKBItemDataset)array[0];
		}

		public void GetGlossaryKBItemsAsync(string AGlossaryID)
		{
			this.GetGlossaryKBItemsAsync(AGlossaryID, null);
		}

		public void GetGlossaryKBItemsAsync(string AGlossaryID, object userState)
		{
			if (this.GetGlossaryKBItemsOperationCompleted == null)
			{
				this.GetGlossaryKBItemsOperationCompleted = new SendOrPostCallback(this.OnGetGlossaryKBItemsOperationCompleted);
			}
			this.InvokeAsync("GetGlossaryKBItems", new object[]
			{
				AGlossaryID
			}, this.GetGlossaryKBItemsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetGlossaryKBItemsOperationCompleted(object arg)
		{
			if (this.GetGlossaryKBItemsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetGlossaryKBItemsCompletedEventHandler getGlossaryKBItemsCompletedEvent = this.GetGlossaryKBItemsCompletedEvent;
				if (getGlossaryKBItemsCompletedEvent != null)
				{
					getGlossaryKBItemsCompletedEvent(this, new GetGlossaryKBItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryItem.UpdateGlossaryItems", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateGlossaryItems(string AGlossaryItems, ref bool UpdateGlossaryItemsResult, [XmlIgnore] ref bool UpdateGlossaryItemsResultSpecified)
		{
			object[] array = this.Invoke("UpdateGlossaryItems", new object[]
			{
				AGlossaryItems
			});
			UpdateGlossaryItemsResult = Conversions.ToBoolean(array[0]);
			UpdateGlossaryItemsResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateGlossaryItemsAsync(string AGlossaryItems)
		{
			this.UpdateGlossaryItemsAsync(AGlossaryItems, null);
		}

		public void UpdateGlossaryItemsAsync(string AGlossaryItems, object userState)
		{
			if (this.UpdateGlossaryItemsOperationCompleted == null)
			{
				this.UpdateGlossaryItemsOperationCompleted = new SendOrPostCallback(this.OnUpdateGlossaryItemsOperationCompleted);
			}
			this.InvokeAsync("UpdateGlossaryItems", new object[]
			{
				AGlossaryItems
			}, this.UpdateGlossaryItemsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateGlossaryItemsOperationCompleted(object arg)
		{
			if (this.UpdateGlossaryItemsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateGlossaryItemsCompletedEventHandler updateGlossaryItemsCompletedEvent = this.UpdateGlossaryItemsCompletedEvent;
				if (updateGlossaryItemsCompletedEvent != null)
				{
					updateGlossaryItemsCompletedEvent(this, new UpdateGlossaryItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
