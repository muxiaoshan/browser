using dhcc.epr.eprlib.previewmanage.Properties;
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

namespace dhcc.epr.eprlib.previewmanage.SysOptionData
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

		public event CreateSysOptionCompletedEventHandler CreateSysOptionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateSysOptionCompleted = (CreateSysOptionCompletedEventHandler)Delegate.Combine(this.CreateSysOptionCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateSysOptionCompleted = (CreateSysOptionCompletedEventHandler)Delegate.Remove(this.CreateSysOptionCompleted, value);
			}
		}

		public event DeleteSysOptionCompletedEventHandler DeleteSysOptionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteSysOptionCompleted = (DeleteSysOptionCompletedEventHandler)Delegate.Combine(this.DeleteSysOptionCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteSysOptionCompleted = (DeleteSysOptionCompletedEventHandler)Delegate.Remove(this.DeleteSysOptionCompleted, value);
			}
		}

		public event GetValueByNameCompletedEventHandler GetValueByNameCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetValueByNameCompleted = (GetValueByNameCompletedEventHandler)Delegate.Combine(this.GetValueByNameCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetValueByNameCompleted = (GetValueByNameCompletedEventHandler)Delegate.Remove(this.GetValueByNameCompleted, value);
			}
		}

		public event SelectAllSysOptionCompletedEventHandler SelectAllSysOptionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllSysOptionCompleted = (SelectAllSysOptionCompletedEventHandler)Delegate.Combine(this.SelectAllSysOptionCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllSysOptionCompleted = (SelectAllSysOptionCompletedEventHandler)Delegate.Remove(this.SelectAllSysOptionCompleted, value);
			}
		}

		public event UpdateSysOptionCompletedEventHandler UpdateSysOptionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateSysOptionCompleted = (UpdateSysOptionCompletedEventHandler)Delegate.Combine(this.UpdateSysOptionCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateSysOptionCompleted = (UpdateSysOptionCompletedEventHandler)Delegate.Remove(this.UpdateSysOptionCompleted, value);
			}
		}

		public event UpdateSysOptionValueCompletedEventHandler UpdateSysOptionValueCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateSysOptionValueCompleted = (UpdateSysOptionValueCompletedEventHandler)Delegate.Combine(this.UpdateSysOptionValueCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateSysOptionValueCompleted = (UpdateSysOptionValueCompletedEventHandler)Delegate.Remove(this.UpdateSysOptionValueCompleted, value);
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
			this.Url = Settings.Default.PreviewManage_SysOptionData_SysOptionInfo;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
				return;
			}
			this.useDefaultCredentialsSetExplicitly = true;
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.CreateSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateSysOption(ESysOption ASysOption)
		{
			object[] array = base.Invoke("CreateSysOption", new object[]
			{
				ASysOption
			});
			return (string)array[0];
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
			base.InvokeAsync("CreateSysOption", new object[]
			{
				ASysOption
			}, this.CreateSysOptionOperationCompleted, userState);
		}

		private void OnCreateSysOptionOperationCompleted(object arg)
		{
			if (this.CreateSysOptionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.CreateSysOptionCompleted(this, new CreateSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.DeleteSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteSysOption(string AID, out bool DeleteSysOptionResult, [XmlIgnore] out bool DeleteSysOptionResultSpecified)
		{
			object[] array = base.Invoke("DeleteSysOption", new object[]
			{
				AID
			});
			DeleteSysOptionResult = (bool)array[0];
			DeleteSysOptionResultSpecified = (bool)array[1];
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
			base.InvokeAsync("DeleteSysOption", new object[]
			{
				AID
			}, this.DeleteSysOptionOperationCompleted, userState);
		}

		private void OnDeleteSysOptionOperationCompleted(object arg)
		{
			if (this.DeleteSysOptionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteSysOptionCompleted(this, new DeleteSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.GetValueByName", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetValueByName(string AName)
		{
			object[] array = base.Invoke("GetValueByName", new object[]
			{
				AName
			});
			return (string)array[0];
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
			base.InvokeAsync("GetValueByName", new object[]
			{
				AName
			}, this.GetValueByNameOperationCompleted, userState);
		}

		private void OnGetValueByNameOperationCompleted(object arg)
		{
			if (this.GetValueByNameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetValueByNameCompleted(this, new GetValueByNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.SelectAllSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ESysOptionDataset SelectAllSysOption()
		{
			object[] array = base.Invoke("SelectAllSysOption", new object[0]);
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
			base.InvokeAsync("SelectAllSysOption", new object[0], this.SelectAllSysOptionOperationCompleted, userState);
		}

		private void OnSelectAllSysOptionOperationCompleted(object arg)
		{
			if (this.SelectAllSysOptionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SelectAllSysOptionCompleted(this, new SelectAllSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOption", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateSysOption(ESysOption ASysOption)
		{
			object[] array = base.Invoke("UpdateSysOption", new object[]
			{
				ASysOption
			});
			return (string)array[0];
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
			base.InvokeAsync("UpdateSysOption", new object[]
			{
				ASysOption
			}, this.UpdateSysOptionOperationCompleted, userState);
		}

		private void OnUpdateSysOptionOperationCompleted(object arg)
		{
			if (this.UpdateSysOptionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.UpdateSysOptionCompleted(this, new UpdateSysOptionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOSysOption.UpdateSysOptionValue", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateSysOptionValue(ESysOption ASysOption)
		{
			object[] array = base.Invoke("UpdateSysOptionValue", new object[]
			{
				ASysOption
			});
			return (string)array[0];
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
			base.InvokeAsync("UpdateSysOptionValue", new object[]
			{
				ASysOption
			}, this.UpdateSysOptionValueOperationCompleted, userState);
		}

		private void OnUpdateSysOptionValueOperationCompleted(object arg)
		{
			if (this.UpdateSysOptionValueCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.UpdateSysOptionValueCompleted(this, new UpdateSysOptionValueCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
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
