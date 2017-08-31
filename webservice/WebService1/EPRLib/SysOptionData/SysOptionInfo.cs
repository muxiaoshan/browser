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

namespace SysOptionData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "SysOptionInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class SysOptionInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateSysOptionOperationCompleted;

		private SendOrPostCallback DeleteSysOptionOperationCompleted;

		private SendOrPostCallback GetValueByNameOperationCompleted;

		private SendOrPostCallback SelectAllSysOptionOperationCompleted;

		private SendOrPostCallback UpdateSysOptionOperationCompleted;

		private SendOrPostCallback UpdateSysOptionValueOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateSysOptionCompletedEventHandler CreateSysOptionCompletedEvent;

		private DeleteSysOptionCompletedEventHandler DeleteSysOptionCompletedEvent;

		private GetValueByNameCompletedEventHandler GetValueByNameCompletedEvent;

		private SelectAllSysOptionCompletedEventHandler SelectAllSysOptionCompletedEvent;

		private UpdateSysOptionCompletedEventHandler UpdateSysOptionCompletedEvent;

		private UpdateSysOptionValueCompletedEventHandler UpdateSysOptionValueCompletedEvent;

		public event CreateSysOptionCompletedEventHandler CreateSysOptionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateSysOptionCompletedEvent = (CreateSysOptionCompletedEventHandler)Delegate.Combine(this.CreateSysOptionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateSysOptionCompletedEvent = (CreateSysOptionCompletedEventHandler)Delegate.Remove(this.CreateSysOptionCompletedEvent, value);
			}
		}

		public event DeleteSysOptionCompletedEventHandler DeleteSysOptionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteSysOptionCompletedEvent = (DeleteSysOptionCompletedEventHandler)Delegate.Combine(this.DeleteSysOptionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteSysOptionCompletedEvent = (DeleteSysOptionCompletedEventHandler)Delegate.Remove(this.DeleteSysOptionCompletedEvent, value);
			}
		}

		public event GetValueByNameCompletedEventHandler GetValueByNameCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetValueByNameCompletedEvent = (GetValueByNameCompletedEventHandler)Delegate.Combine(this.GetValueByNameCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetValueByNameCompletedEvent = (GetValueByNameCompletedEventHandler)Delegate.Remove(this.GetValueByNameCompletedEvent, value);
			}
		}

		public event SelectAllSysOptionCompletedEventHandler SelectAllSysOptionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllSysOptionCompletedEvent = (SelectAllSysOptionCompletedEventHandler)Delegate.Combine(this.SelectAllSysOptionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllSysOptionCompletedEvent = (SelectAllSysOptionCompletedEventHandler)Delegate.Remove(this.SelectAllSysOptionCompletedEvent, value);
			}
		}

		public event UpdateSysOptionCompletedEventHandler UpdateSysOptionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateSysOptionCompletedEvent = (UpdateSysOptionCompletedEventHandler)Delegate.Combine(this.UpdateSysOptionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateSysOptionCompletedEvent = (UpdateSysOptionCompletedEventHandler)Delegate.Remove(this.UpdateSysOptionCompletedEvent, value);
			}
		}

		public event UpdateSysOptionValueCompletedEventHandler UpdateSysOptionValueCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateSysOptionValueCompletedEvent = (UpdateSysOptionValueCompletedEventHandler)Delegate.Combine(this.UpdateSysOptionValueCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateSysOptionValueCompletedEvent = (UpdateSysOptionValueCompletedEventHandler)Delegate.Remove(this.UpdateSysOptionValueCompletedEvent, value);
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

		public SysOptionInfo()
		{
			this.Url = MySettings.Default.EPRLib_SysOptionData_SysOptionInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.CreateSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateSysOption(ESysOption ASysOption)
		{
			object[] array = this.Invoke("CreateSysOption", new object[]
			{
				ASysOption
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateSysOptionAsync(ESysOption ASysOption)
		{
			this.CreateSysOptionAsync(ASysOption, null);
		}

		public void CreateSysOptionAsync(ESysOption ASysOption, object userState)
		{
			if (this.CreateSysOptionOperationCompleted == null)
			{
				this.CreateSysOptionOperationCompleted = new SendOrPostCallback(this.OnCreateSysOptionOperationCompleted);
			}
			this.InvokeAsync("CreateSysOption", new object[]
			{
				ASysOption
			}, this.CreateSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateSysOptionOperationCompleted(object arg)
		{
			if (this.CreateSysOptionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateSysOptionCompletedEventHandler createSysOptionCompletedEvent = this.CreateSysOptionCompletedEvent;
				if (createSysOptionCompletedEvent != null)
				{
					createSysOptionCompletedEvent(this, new CreateSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.DeleteSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteSysOption(string AID, ref bool DeleteSysOptionResult, [XmlIgnore] ref bool DeleteSysOptionResultSpecified)
		{
			object[] array = this.Invoke("DeleteSysOption", new object[]
			{
				AID
			});
			DeleteSysOptionResult = Conversions.ToBoolean(array[0]);
			DeleteSysOptionResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteSysOptionAsync(string AID)
		{
			this.DeleteSysOptionAsync(AID, null);
		}

		public void DeleteSysOptionAsync(string AID, object userState)
		{
			if (this.DeleteSysOptionOperationCompleted == null)
			{
				this.DeleteSysOptionOperationCompleted = new SendOrPostCallback(this.OnDeleteSysOptionOperationCompleted);
			}
			this.InvokeAsync("DeleteSysOption", new object[]
			{
				AID
			}, this.DeleteSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteSysOptionOperationCompleted(object arg)
		{
			if (this.DeleteSysOptionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteSysOptionCompletedEventHandler deleteSysOptionCompletedEvent = this.DeleteSysOptionCompletedEvent;
				if (deleteSysOptionCompletedEvent != null)
				{
					deleteSysOptionCompletedEvent(this, new DeleteSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.GetValueByName", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetValueByName(string AName)
		{
			object[] array = this.Invoke("GetValueByName", new object[]
			{
				AName
			});
			return Conversions.ToString(array[0]);
		}

		public void GetValueByNameAsync(string AName)
		{
			this.GetValueByNameAsync(AName, null);
		}

		public void GetValueByNameAsync(string AName, object userState)
		{
			if (this.GetValueByNameOperationCompleted == null)
			{
				this.GetValueByNameOperationCompleted = new SendOrPostCallback(this.OnGetValueByNameOperationCompleted);
			}
			this.InvokeAsync("GetValueByName", new object[]
			{
				AName
			}, this.GetValueByNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetValueByNameOperationCompleted(object arg)
		{
			if (this.GetValueByNameCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetValueByNameCompletedEventHandler getValueByNameCompletedEvent = this.GetValueByNameCompletedEvent;
				if (getValueByNameCompletedEvent != null)
				{
					getValueByNameCompletedEvent(this, new GetValueByNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.SelectAllSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ESysOptionDataset SelectAllSysOption()
		{
			object[] array = this.Invoke("SelectAllSysOption", new object[0]);
			return (ESysOptionDataset)array[0];
		}

		public void SelectAllSysOptionAsync()
		{
			this.SelectAllSysOptionAsync(null);
		}

		public void SelectAllSysOptionAsync(object userState)
		{
			if (this.SelectAllSysOptionOperationCompleted == null)
			{
				this.SelectAllSysOptionOperationCompleted = new SendOrPostCallback(this.OnSelectAllSysOptionOperationCompleted);
			}
			this.InvokeAsync("SelectAllSysOption", new object[0], this.SelectAllSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllSysOptionOperationCompleted(object arg)
		{
			if (this.SelectAllSysOptionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllSysOptionCompletedEventHandler selectAllSysOptionCompletedEvent = this.SelectAllSysOptionCompletedEvent;
				if (selectAllSysOptionCompletedEvent != null)
				{
					selectAllSysOptionCompletedEvent(this, new SelectAllSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateSysOption(ESysOption ASysOption)
		{
			object[] array = this.Invoke("UpdateSysOption", new object[]
			{
				ASysOption
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateSysOptionAsync(ESysOption ASysOption)
		{
			this.UpdateSysOptionAsync(ASysOption, null);
		}

		public void UpdateSysOptionAsync(ESysOption ASysOption, object userState)
		{
			if (this.UpdateSysOptionOperationCompleted == null)
			{
				this.UpdateSysOptionOperationCompleted = new SendOrPostCallback(this.OnUpdateSysOptionOperationCompleted);
			}
			this.InvokeAsync("UpdateSysOption", new object[]
			{
				ASysOption
			}, this.UpdateSysOptionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateSysOptionOperationCompleted(object arg)
		{
			if (this.UpdateSysOptionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateSysOptionCompletedEventHandler updateSysOptionCompletedEvent = this.UpdateSysOptionCompletedEvent;
				if (updateSysOptionCompletedEvent != null)
				{
					updateSysOptionCompletedEvent(this, new UpdateSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOptionValue", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateSysOptionValue(ESysOption ASysOption)
		{
			object[] array = this.Invoke("UpdateSysOptionValue", new object[]
			{
				ASysOption
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateSysOptionValueAsync(ESysOption ASysOption)
		{
			this.UpdateSysOptionValueAsync(ASysOption, null);
		}

		public void UpdateSysOptionValueAsync(ESysOption ASysOption, object userState)
		{
			if (this.UpdateSysOptionValueOperationCompleted == null)
			{
				this.UpdateSysOptionValueOperationCompleted = new SendOrPostCallback(this.OnUpdateSysOptionValueOperationCompleted);
			}
			this.InvokeAsync("UpdateSysOptionValue", new object[]
			{
				ASysOption
			}, this.UpdateSysOptionValueOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateSysOptionValueOperationCompleted(object arg)
		{
			if (this.UpdateSysOptionValueCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateSysOptionValueCompletedEventHandler updateSysOptionValueCompletedEvent = this.UpdateSysOptionValueCompletedEvent;
				if (updateSysOptionValueCompletedEvent != null)
				{
					updateSysOptionValueCompletedEvent(this, new UpdateSysOptionValueCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
