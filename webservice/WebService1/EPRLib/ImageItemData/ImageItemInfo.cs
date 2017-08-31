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

namespace ImageItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ImageItemInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class ImageItemInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CheckImageItemPublishedOperationCompleted;

		private SendOrPostCallback CreateOperationCompleted;

		private SendOrPostCallback DeleteByIDOperationCompleted;

		private SendOrPostCallback GetByImageTreeIDOperationCompleted;

		private SendOrPostCallback GetEntityOperationCompleted;

		private SendOrPostCallback UpdateOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CheckImageItemPublishedCompletedEventHandler CheckImageItemPublishedCompletedEvent;

		private CreateCompletedEventHandler CreateCompletedEvent;

		private DeleteByIDCompletedEventHandler DeleteByIDCompletedEvent;

		private GetByImageTreeIDCompletedEventHandler GetByImageTreeIDCompletedEvent;

		private GetEntityCompletedEventHandler GetEntityCompletedEvent;

		private UpdateCompletedEventHandler UpdateCompletedEvent;

		public event CheckImageItemPublishedCompletedEventHandler CheckImageItemPublishedCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CheckImageItemPublishedCompletedEvent = (CheckImageItemPublishedCompletedEventHandler)Delegate.Combine(this.CheckImageItemPublishedCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CheckImageItemPublishedCompletedEvent = (CheckImageItemPublishedCompletedEventHandler)Delegate.Remove(this.CheckImageItemPublishedCompletedEvent, value);
			}
		}

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

		public event DeleteByIDCompletedEventHandler DeleteByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteByIDCompletedEvent = (DeleteByIDCompletedEventHandler)Delegate.Combine(this.DeleteByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteByIDCompletedEvent = (DeleteByIDCompletedEventHandler)Delegate.Remove(this.DeleteByIDCompletedEvent, value);
			}
		}

		public event GetByImageTreeIDCompletedEventHandler GetByImageTreeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetByImageTreeIDCompletedEvent = (GetByImageTreeIDCompletedEventHandler)Delegate.Combine(this.GetByImageTreeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetByImageTreeIDCompletedEvent = (GetByImageTreeIDCompletedEventHandler)Delegate.Remove(this.GetByImageTreeIDCompletedEvent, value);
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

		public ImageItemInfo()
		{
			this.Url = MySettings.Default.EPRLib_ImageItemData_ImageItemInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.CheckImageItemPublished", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckImageItemPublished(string AFigureID, string AFigureType)
		{
			object[] array = this.Invoke("CheckImageItemPublished", new object[]
			{
				AFigureID,
				AFigureType
			});
			return Conversions.ToString(array[0]);
		}

		public void CheckImageItemPublishedAsync(string AFigureID, string AFigureType)
		{
			this.CheckImageItemPublishedAsync(AFigureID, AFigureType, null);
		}

		public void CheckImageItemPublishedAsync(string AFigureID, string AFigureType, object userState)
		{
			if (this.CheckImageItemPublishedOperationCompleted == null)
			{
				this.CheckImageItemPublishedOperationCompleted = new SendOrPostCallback(this.OnCheckImageItemPublishedOperationCompleted);
			}
			this.InvokeAsync("CheckImageItemPublished", new object[]
			{
				AFigureID,
				AFigureType
			}, this.CheckImageItemPublishedOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCheckImageItemPublishedOperationCompleted(object arg)
		{
			if (this.CheckImageItemPublishedCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CheckImageItemPublishedCompletedEventHandler checkImageItemPublishedCompletedEvent = this.CheckImageItemPublishedCompletedEvent;
				if (checkImageItemPublishedCompletedEvent != null)
				{
					checkImageItemPublishedCompletedEvent(this, new CheckImageItemPublishedCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.Create", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Create(EImageItem AEImageItem)
		{
			object[] array = this.Invoke("Create", new object[]
			{
				AEImageItem
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateAsync(EImageItem AEImageItem)
		{
			this.CreateAsync(AEImageItem, null);
		}

		public void CreateAsync(EImageItem AEImageItem, object userState)
		{
			if (this.CreateOperationCompleted == null)
			{
				this.CreateOperationCompleted = new SendOrPostCallback(this.OnCreateOperationCompleted);
			}
			this.InvokeAsync("Create", new object[]
			{
				AEImageItem
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.DeleteByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string DeleteByID(string AImageItemID)
		{
			object[] array = this.Invoke("DeleteByID", new object[]
			{
				AImageItemID
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteByIDAsync(string AImageItemID)
		{
			this.DeleteByIDAsync(AImageItemID, null);
		}

		public void DeleteByIDAsync(string AImageItemID, object userState)
		{
			if (this.DeleteByIDOperationCompleted == null)
			{
				this.DeleteByIDOperationCompleted = new SendOrPostCallback(this.OnDeleteByIDOperationCompleted);
			}
			this.InvokeAsync("DeleteByID", new object[]
			{
				AImageItemID
			}, this.DeleteByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteByIDOperationCompleted(object arg)
		{
			if (this.DeleteByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteByIDCompletedEventHandler deleteByIDCompletedEvent = this.DeleteByIDCompletedEvent;
				if (deleteByIDCompletedEvent != null)
				{
					deleteByIDCompletedEvent(this, new DeleteByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.GetByImageTreeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageItemDataSet GetByImageTreeID(string AImageTreeID)
		{
			object[] array = this.Invoke("GetByImageTreeID", new object[]
			{
				AImageTreeID
			});
			return (EImageItemDataSet)array[0];
		}

		public void GetByImageTreeIDAsync(string AImageTreeID)
		{
			this.GetByImageTreeIDAsync(AImageTreeID, null);
		}

		public void GetByImageTreeIDAsync(string AImageTreeID, object userState)
		{
			if (this.GetByImageTreeIDOperationCompleted == null)
			{
				this.GetByImageTreeIDOperationCompleted = new SendOrPostCallback(this.OnGetByImageTreeIDOperationCompleted);
			}
			this.InvokeAsync("GetByImageTreeID", new object[]
			{
				AImageTreeID
			}, this.GetByImageTreeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetByImageTreeIDOperationCompleted(object arg)
		{
			if (this.GetByImageTreeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetByImageTreeIDCompletedEventHandler getByImageTreeIDCompletedEvent = this.GetByImageTreeIDCompletedEvent;
				if (getByImageTreeIDCompletedEvent != null)
				{
					getByImageTreeIDCompletedEvent(this, new GetByImageTreeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.GetEntity", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageItem GetEntity(string AImgeItemID)
		{
			object[] array = this.Invoke("GetEntity", new object[]
			{
				AImgeItemID
			});
			return (EImageItem)array[0];
		}

		public void GetEntityAsync(string AImgeItemID)
		{
			this.GetEntityAsync(AImgeItemID, null);
		}

		public void GetEntityAsync(string AImgeItemID, object userState)
		{
			if (this.GetEntityOperationCompleted == null)
			{
				this.GetEntityOperationCompleted = new SendOrPostCallback(this.OnGetEntityOperationCompleted);
			}
			this.InvokeAsync("GetEntity", new object[]
			{
				AImgeItemID
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageItem.Update", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Update(EImageItem AEImageItem)
		{
			object[] array = this.Invoke("Update", new object[]
			{
				AEImageItem
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateAsync(EImageItem AEImageItem)
		{
			this.UpdateAsync(AEImageItem, null);
		}

		public void UpdateAsync(EImageItem AEImageItem, object userState)
		{
			if (this.UpdateOperationCompleted == null)
			{
				this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
			}
			this.InvokeAsync("Update", new object[]
			{
				AEImageItem
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
