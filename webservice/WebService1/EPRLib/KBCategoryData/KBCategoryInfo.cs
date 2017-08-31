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

namespace KBCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KBCategoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KBCategoryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateKBCategoryOperationCompleted;

		private SendOrPostCallback DeleteKBCategoryOperationCompleted;

		private SendOrPostCallback SelectAllKBCategoryOperationCompleted;

		private SendOrPostCallback SelectKBCategoryByIDOperationCompleted;

		private SendOrPostCallback UpdateKBCategoryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateKBCategoryCompletedEventHandler CreateKBCategoryCompletedEvent;

		private DeleteKBCategoryCompletedEventHandler DeleteKBCategoryCompletedEvent;

		private SelectAllKBCategoryCompletedEventHandler SelectAllKBCategoryCompletedEvent;

		private SelectKBCategoryByIDCompletedEventHandler SelectKBCategoryByIDCompletedEvent;

		private UpdateKBCategoryCompletedEventHandler UpdateKBCategoryCompletedEvent;

		public event CreateKBCategoryCompletedEventHandler CreateKBCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateKBCategoryCompletedEvent = (CreateKBCategoryCompletedEventHandler)Delegate.Combine(this.CreateKBCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateKBCategoryCompletedEvent = (CreateKBCategoryCompletedEventHandler)Delegate.Remove(this.CreateKBCategoryCompletedEvent, value);
			}
		}

		public event DeleteKBCategoryCompletedEventHandler DeleteKBCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteKBCategoryCompletedEvent = (DeleteKBCategoryCompletedEventHandler)Delegate.Combine(this.DeleteKBCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteKBCategoryCompletedEvent = (DeleteKBCategoryCompletedEventHandler)Delegate.Remove(this.DeleteKBCategoryCompletedEvent, value);
			}
		}

		public event SelectAllKBCategoryCompletedEventHandler SelectAllKBCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllKBCategoryCompletedEvent = (SelectAllKBCategoryCompletedEventHandler)Delegate.Combine(this.SelectAllKBCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllKBCategoryCompletedEvent = (SelectAllKBCategoryCompletedEventHandler)Delegate.Remove(this.SelectAllKBCategoryCompletedEvent, value);
			}
		}

		public event SelectKBCategoryByIDCompletedEventHandler SelectKBCategoryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBCategoryByIDCompletedEvent = (SelectKBCategoryByIDCompletedEventHandler)Delegate.Combine(this.SelectKBCategoryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBCategoryByIDCompletedEvent = (SelectKBCategoryByIDCompletedEventHandler)Delegate.Remove(this.SelectKBCategoryByIDCompletedEvent, value);
			}
		}

		public event UpdateKBCategoryCompletedEventHandler UpdateKBCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateKBCategoryCompletedEvent = (UpdateKBCategoryCompletedEventHandler)Delegate.Combine(this.UpdateKBCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateKBCategoryCompletedEvent = (UpdateKBCategoryCompletedEventHandler)Delegate.Remove(this.UpdateKBCategoryCompletedEvent, value);
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

		public KBCategoryInfo()
		{
			this.Url = MySettings.Default.EPRLib_KBCategoryData_KBCategoryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBCategory.CreateKBCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateKBCategory(EKBCategory AEKBCategory)
		{
			object[] array = this.Invoke("CreateKBCategory", new object[]
			{
				AEKBCategory
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateKBCategoryAsync(EKBCategory AEKBCategory)
		{
			this.CreateKBCategoryAsync(AEKBCategory, null);
		}

		public void CreateKBCategoryAsync(EKBCategory AEKBCategory, object userState)
		{
			if (this.CreateKBCategoryOperationCompleted == null)
			{
				this.CreateKBCategoryOperationCompleted = new SendOrPostCallback(this.OnCreateKBCategoryOperationCompleted);
			}
			this.InvokeAsync("CreateKBCategory", new object[]
			{
				AEKBCategory
			}, this.CreateKBCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateKBCategoryOperationCompleted(object arg)
		{
			if (this.CreateKBCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateKBCategoryCompletedEventHandler createKBCategoryCompletedEvent = this.CreateKBCategoryCompletedEvent;
				if (createKBCategoryCompletedEvent != null)
				{
					createKBCategoryCompletedEvent(this, new CreateKBCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBCategory.DeleteKBCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteKBCategory(string AID, ref bool DeleteKBCategoryResult, [XmlIgnore] ref bool DeleteKBCategoryResultSpecified)
		{
			object[] array = this.Invoke("DeleteKBCategory", new object[]
			{
				AID
			});
			DeleteKBCategoryResult = Conversions.ToBoolean(array[0]);
			DeleteKBCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteKBCategoryAsync(string AID)
		{
			this.DeleteKBCategoryAsync(AID, null);
		}

		public void DeleteKBCategoryAsync(string AID, object userState)
		{
			if (this.DeleteKBCategoryOperationCompleted == null)
			{
				this.DeleteKBCategoryOperationCompleted = new SendOrPostCallback(this.OnDeleteKBCategoryOperationCompleted);
			}
			this.InvokeAsync("DeleteKBCategory", new object[]
			{
				AID
			}, this.DeleteKBCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteKBCategoryOperationCompleted(object arg)
		{
			if (this.DeleteKBCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteKBCategoryCompletedEventHandler deleteKBCategoryCompletedEvent = this.DeleteKBCategoryCompletedEvent;
				if (deleteKBCategoryCompletedEvent != null)
				{
					deleteKBCategoryCompletedEvent(this, new DeleteKBCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBCategory.SelectAllKBCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBCategoryDataset SelectAllKBCategory()
		{
			object[] array = this.Invoke("SelectAllKBCategory", new object[0]);
			return (EKBCategoryDataset)array[0];
		}

		public void SelectAllKBCategoryAsync()
		{
			this.SelectAllKBCategoryAsync(null);
		}

		public void SelectAllKBCategoryAsync(object userState)
		{
			if (this.SelectAllKBCategoryOperationCompleted == null)
			{
				this.SelectAllKBCategoryOperationCompleted = new SendOrPostCallback(this.OnSelectAllKBCategoryOperationCompleted);
			}
			this.InvokeAsync("SelectAllKBCategory", new object[0], this.SelectAllKBCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllKBCategoryOperationCompleted(object arg)
		{
			if (this.SelectAllKBCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllKBCategoryCompletedEventHandler selectAllKBCategoryCompletedEvent = this.SelectAllKBCategoryCompletedEvent;
				if (selectAllKBCategoryCompletedEvent != null)
				{
					selectAllKBCategoryCompletedEvent(this, new SelectAllKBCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBCategory.SelectKBCategoryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBCategory SelectKBCategoryByID(string AID)
		{
			object[] array = this.Invoke("SelectKBCategoryByID", new object[]
			{
				AID
			});
			return (EKBCategory)array[0];
		}

		public void SelectKBCategoryByIDAsync(string AID)
		{
			this.SelectKBCategoryByIDAsync(AID, null);
		}

		public void SelectKBCategoryByIDAsync(string AID, object userState)
		{
			if (this.SelectKBCategoryByIDOperationCompleted == null)
			{
				this.SelectKBCategoryByIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBCategoryByIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBCategoryByID", new object[]
			{
				AID
			}, this.SelectKBCategoryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBCategoryByIDOperationCompleted(object arg)
		{
			if (this.SelectKBCategoryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBCategoryByIDCompletedEventHandler selectKBCategoryByIDCompletedEvent = this.SelectKBCategoryByIDCompletedEvent;
				if (selectKBCategoryByIDCompletedEvent != null)
				{
					selectKBCategoryByIDCompletedEvent(this, new SelectKBCategoryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBCategory.UpdateKBCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateKBCategory(EKBCategory AEKBCategory, ref bool UpdateKBCategoryResult, [XmlIgnore] ref bool UpdateKBCategoryResultSpecified)
		{
			object[] array = this.Invoke("UpdateKBCategory", new object[]
			{
				AEKBCategory
			});
			UpdateKBCategoryResult = Conversions.ToBoolean(array[0]);
			UpdateKBCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateKBCategoryAsync(EKBCategory AEKBCategory)
		{
			this.UpdateKBCategoryAsync(AEKBCategory, null);
		}

		public void UpdateKBCategoryAsync(EKBCategory AEKBCategory, object userState)
		{
			if (this.UpdateKBCategoryOperationCompleted == null)
			{
				this.UpdateKBCategoryOperationCompleted = new SendOrPostCallback(this.OnUpdateKBCategoryOperationCompleted);
			}
			this.InvokeAsync("UpdateKBCategory", new object[]
			{
				AEKBCategory
			}, this.UpdateKBCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateKBCategoryOperationCompleted(object arg)
		{
			if (this.UpdateKBCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateKBCategoryCompletedEventHandler updateKBCategoryCompletedEvent = this.UpdateKBCategoryCompletedEvent;
				if (updateKBCategoryCompletedEvent != null)
				{
					updateKBCategoryCompletedEvent(this, new UpdateKBCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
