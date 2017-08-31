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

namespace AdmImageItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "AdmImageItemInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class AdmImageItemInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateOperationCompleted;

		private SendOrPostCallback DeleteOperationCompleted;

		private SendOrPostCallback GetByEpisodeIDOperationCompleted;

		private SendOrPostCallback GetEntityOperationCompleted;

		private SendOrPostCallback UpdateOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateCompletedEventHandler CreateCompletedEvent;

		private DeleteCompletedEventHandler DeleteCompletedEvent;

		private GetByEpisodeIDCompletedEventHandler GetByEpisodeIDCompletedEvent;

		private GetEntityCompletedEventHandler GetEntityCompletedEvent;

		private UpdateCompletedEventHandler UpdateCompletedEvent;

		public event CreateCompletedEventHandler CreateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateCompletedEvent = (CreateCompletedEventHandler)Delegate.Combine(this.CreateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateCompletedEvent = (CreateCompletedEventHandler)Delegate.Remove(this.CreateCompletedEvent, value);
			}
		}

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

		public event GetByEpisodeIDCompletedEventHandler GetByEpisodeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetByEpisodeIDCompletedEvent = (GetByEpisodeIDCompletedEventHandler)Delegate.Combine(this.GetByEpisodeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetByEpisodeIDCompletedEvent = (GetByEpisodeIDCompletedEventHandler)Delegate.Remove(this.GetByEpisodeIDCompletedEvent, value);
			}
		}

		public event GetEntityCompletedEventHandler GetEntityCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetEntityCompletedEvent = (GetEntityCompletedEventHandler)Delegate.Combine(this.GetEntityCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetEntityCompletedEvent = (GetEntityCompletedEventHandler)Delegate.Remove(this.GetEntityCompletedEvent, value);
			}
		}

		public event UpdateCompletedEventHandler UpdateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateCompletedEvent = (UpdateCompletedEventHandler)Delegate.Combine(this.UpdateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateCompletedEvent = (UpdateCompletedEventHandler)Delegate.Remove(this.UpdateCompletedEvent, value);
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

		public AdmImageItemInfo()
		{
			this.Url = MySettings.Default.EPRLib_AdmImageItemData_AdmImageItemInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOAdmImageItem.Create", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Create(EAdmImageItem AEAdmImageItem)
		{
			object[] array = this.Invoke("Create", new object[]
			{
				AEAdmImageItem
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateAsync(EAdmImageItem AEAdmImageItem)
		{
			this.CreateAsync(AEAdmImageItem, null);
		}

		public void CreateAsync(EAdmImageItem AEAdmImageItem, object userState)
		{
			if (this.CreateOperationCompleted == null)
			{
				this.CreateOperationCompleted = new SendOrPostCallback(this.OnCreateOperationCompleted);
			}
			this.InvokeAsync("Create", new object[]
			{
				AEAdmImageItem
			}, this.CreateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateOperationCompleted(object arg)
		{
			if (this.CreateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateCompletedEventHandler createCompletedEvent = this.CreateCompletedEvent;
				if (createCompletedEvent != null)
				{
					createCompletedEvent(this, new CreateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOAdmImageItem.Delete", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Delete(string AAdmImageItemID)
		{
			object[] array = this.Invoke("Delete", new object[]
			{
				AAdmImageItemID
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteAsync(string AAdmImageItemID)
		{
			this.DeleteAsync(AAdmImageItemID, null);
		}

		public void DeleteAsync(string AAdmImageItemID, object userState)
		{
			if (this.DeleteOperationCompleted == null)
			{
				this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
			}
			this.InvokeAsync("Delete", new object[]
			{
				AAdmImageItemID
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOAdmImageItem.GetByEpisodeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EAdmImageItemDataSet GetByEpisodeID(string AEpisodeID)
		{
			object[] array = this.Invoke("GetByEpisodeID", new object[]
			{
				AEpisodeID
			});
			return (EAdmImageItemDataSet)array[0];
		}

		public void GetByEpisodeIDAsync(string AEpisodeID)
		{
			this.GetByEpisodeIDAsync(AEpisodeID, null);
		}

		public void GetByEpisodeIDAsync(string AEpisodeID, object userState)
		{
			if (this.GetByEpisodeIDOperationCompleted == null)
			{
				this.GetByEpisodeIDOperationCompleted = new SendOrPostCallback(this.OnGetByEpisodeIDOperationCompleted);
			}
			this.InvokeAsync("GetByEpisodeID", new object[]
			{
				AEpisodeID
			}, this.GetByEpisodeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetByEpisodeIDOperationCompleted(object arg)
		{
			if (this.GetByEpisodeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetByEpisodeIDCompletedEventHandler getByEpisodeIDCompletedEvent = this.GetByEpisodeIDCompletedEvent;
				if (getByEpisodeIDCompletedEvent != null)
				{
					getByEpisodeIDCompletedEvent(this, new GetByEpisodeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOAdmImageItem.GetEntity", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EAdmImageItem GetEntity(string AAdmImageItemID)
		{
			object[] array = this.Invoke("GetEntity", new object[]
			{
				AAdmImageItemID
			});
			return (EAdmImageItem)array[0];
		}

		public void GetEntityAsync(string AAdmImageItemID)
		{
			this.GetEntityAsync(AAdmImageItemID, null);
		}

		public void GetEntityAsync(string AAdmImageItemID, object userState)
		{
			if (this.GetEntityOperationCompleted == null)
			{
				this.GetEntityOperationCompleted = new SendOrPostCallback(this.OnGetEntityOperationCompleted);
			}
			this.InvokeAsync("GetEntity", new object[]
			{
				AAdmImageItemID
			}, this.GetEntityOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetEntityOperationCompleted(object arg)
		{
			if (this.GetEntityCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetEntityCompletedEventHandler getEntityCompletedEvent = this.GetEntityCompletedEvent;
				if (getEntityCompletedEvent != null)
				{
					getEntityCompletedEvent(this, new GetEntityCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOAdmImageItem.Update", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Update(EAdmImageItem AEAdmImageItem)
		{
			object[] array = this.Invoke("Update", new object[]
			{
				AEAdmImageItem
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateAsync(EAdmImageItem AEAdmImageItem)
		{
			this.UpdateAsync(AEAdmImageItem, null);
		}

		public void UpdateAsync(EAdmImageItem AEAdmImageItem, object userState)
		{
			if (this.UpdateOperationCompleted == null)
			{
				this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
			}
			this.InvokeAsync("Update", new object[]
			{
				AEAdmImageItem
			}, this.UpdateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateOperationCompleted(object arg)
		{
			if (this.UpdateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateCompletedEventHandler updateCompletedEvent = this.UpdateCompletedEvent;
				if (updateCompletedEvent != null)
				{
					updateCompletedEvent(this, new UpdateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
