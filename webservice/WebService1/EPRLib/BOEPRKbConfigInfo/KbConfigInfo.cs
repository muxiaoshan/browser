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

namespace BOEPRKbConfigInfo
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KbConfigInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KbConfigInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetAllLocOperationCompleted;

		private SendOrPostCallback GetBindLocByIDOperationCompleted;

		private SendOrPostCallback GetKBTreeByLocOperationCompleted;

		private SendOrPostCallback SaveBindLocOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private GetAllLocCompletedEventHandler GetAllLocCompletedEvent;

		private GetBindLocByIDCompletedEventHandler GetBindLocByIDCompletedEvent;

		private GetKBTreeByLocCompletedEventHandler GetKBTreeByLocCompletedEvent;

		private SaveBindLocCompletedEventHandler SaveBindLocCompletedEvent;

		public event GetAllLocCompletedEventHandler GetAllLocCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllLocCompletedEvent = (GetAllLocCompletedEventHandler)Delegate.Combine(this.GetAllLocCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllLocCompletedEvent = (GetAllLocCompletedEventHandler)Delegate.Remove(this.GetAllLocCompletedEvent, value);
			}
		}

		public event GetBindLocByIDCompletedEventHandler GetBindLocByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetBindLocByIDCompletedEvent = (GetBindLocByIDCompletedEventHandler)Delegate.Combine(this.GetBindLocByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetBindLocByIDCompletedEvent = (GetBindLocByIDCompletedEventHandler)Delegate.Remove(this.GetBindLocByIDCompletedEvent, value);
			}
		}

		public event GetKBTreeByLocCompletedEventHandler GetKBTreeByLocCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetKBTreeByLocCompletedEvent = (GetKBTreeByLocCompletedEventHandler)Delegate.Combine(this.GetKBTreeByLocCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetKBTreeByLocCompletedEvent = (GetKBTreeByLocCompletedEventHandler)Delegate.Remove(this.GetKBTreeByLocCompletedEvent, value);
			}
		}

		public event SaveBindLocCompletedEventHandler SaveBindLocCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveBindLocCompletedEvent = (SaveBindLocCompletedEventHandler)Delegate.Combine(this.SaveBindLocCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveBindLocCompletedEvent = (SaveBindLocCompletedEventHandler)Delegate.Remove(this.SaveBindLocCompletedEvent, value);
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

		public KbConfigInfo()
		{
			this.Url = MySettings.Default.EPRLib_BOEPRKbConfigInfo_KbConfigInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRKbConfig.GetAllLoc", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetAllLoc()
		{
			object[] array = this.Invoke("GetAllLoc", new object[0]);
			return (DataSet)array[0];
		}

		public void GetAllLocAsync()
		{
			this.GetAllLocAsync(null);
		}

		public void GetAllLocAsync(object userState)
		{
			if (this.GetAllLocOperationCompleted == null)
			{
				this.GetAllLocOperationCompleted = new SendOrPostCallback(this.OnGetAllLocOperationCompleted);
			}
			this.InvokeAsync("GetAllLoc", new object[0], this.GetAllLocOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllLocOperationCompleted(object arg)
		{
			if (this.GetAllLocCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllLocCompletedEventHandler getAllLocCompletedEvent = this.GetAllLocCompletedEvent;
				if (getAllLocCompletedEvent != null)
				{
					getAllLocCompletedEvent(this, new GetAllLocCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRKbConfig.GetBindLocByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetBindLocByID(string KbTreeID)
		{
			object[] array = this.Invoke("GetBindLocByID", new object[]
			{
				KbTreeID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetBindLocByIDAsync(string KbTreeID)
		{
			this.GetBindLocByIDAsync(KbTreeID, null);
		}

		public void GetBindLocByIDAsync(string KbTreeID, object userState)
		{
			if (this.GetBindLocByIDOperationCompleted == null)
			{
				this.GetBindLocByIDOperationCompleted = new SendOrPostCallback(this.OnGetBindLocByIDOperationCompleted);
			}
			this.InvokeAsync("GetBindLocByID", new object[]
			{
				KbTreeID
			}, this.GetBindLocByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetBindLocByIDOperationCompleted(object arg)
		{
			if (this.GetBindLocByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetBindLocByIDCompletedEventHandler getBindLocByIDCompletedEvent = this.GetBindLocByIDCompletedEvent;
				if (getBindLocByIDCompletedEvent != null)
				{
					getBindLocByIDCompletedEvent(this, new GetBindLocByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRKbConfig.GetKBTreeByLoc", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetKBTreeByLoc(string ALocID)
		{
			object[] array = this.Invoke("GetKBTreeByLoc", new object[]
			{
				ALocID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetKBTreeByLocAsync(string ALocID)
		{
			this.GetKBTreeByLocAsync(ALocID, null);
		}

		public void GetKBTreeByLocAsync(string ALocID, object userState)
		{
			if (this.GetKBTreeByLocOperationCompleted == null)
			{
				this.GetKBTreeByLocOperationCompleted = new SendOrPostCallback(this.OnGetKBTreeByLocOperationCompleted);
			}
			this.InvokeAsync("GetKBTreeByLoc", new object[]
			{
				ALocID
			}, this.GetKBTreeByLocOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetKBTreeByLocOperationCompleted(object arg)
		{
			if (this.GetKBTreeByLocCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetKBTreeByLocCompletedEventHandler getKBTreeByLocCompletedEvent = this.GetKBTreeByLocCompletedEvent;
				if (getKBTreeByLocCompletedEvent != null)
				{
					getKBTreeByLocCompletedEvent(this, new GetKBTreeByLocCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRKbConfig.SaveBindLoc", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string SaveBindLoc(string KbTreeID, string LocIDStr)
		{
			object[] array = this.Invoke("SaveBindLoc", new object[]
			{
				KbTreeID,
				LocIDStr
			});
			return Conversions.ToString(array[0]);
		}

		public void SaveBindLocAsync(string KbTreeID, string LocIDStr)
		{
			this.SaveBindLocAsync(KbTreeID, LocIDStr, null);
		}

		public void SaveBindLocAsync(string KbTreeID, string LocIDStr, object userState)
		{
			if (this.SaveBindLocOperationCompleted == null)
			{
				this.SaveBindLocOperationCompleted = new SendOrPostCallback(this.OnSaveBindLocOperationCompleted);
			}
			this.InvokeAsync("SaveBindLoc", new object[]
			{
				KbTreeID,
				LocIDStr
			}, this.SaveBindLocOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveBindLocOperationCompleted(object arg)
		{
			if (this.SaveBindLocCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveBindLocCompletedEventHandler saveBindLocCompletedEvent = this.SaveBindLocCompletedEvent;
				if (saveBindLocCompletedEvent != null)
				{
					saveBindLocCompletedEvent(this, new SaveBindLocCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
