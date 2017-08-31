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

namespace ITCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "TemplateCategoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class TemplateCategoryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateTemplateCategoryOperationCompleted;

		private SendOrPostCallback DeleteTemplateCategoryOperationCompleted;

		private SendOrPostCallback SelectAllTemplateCategoryOperationCompleted;

		private SendOrPostCallback SelectTemplateCategoryByIDOperationCompleted;

		private SendOrPostCallback UpdateTemplateCategoryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateTemplateCategoryCompletedEventHandler CreateTemplateCategoryCompletedEvent;

		private DeleteTemplateCategoryCompletedEventHandler DeleteTemplateCategoryCompletedEvent;

		private SelectAllTemplateCategoryCompletedEventHandler SelectAllTemplateCategoryCompletedEvent;

		private SelectTemplateCategoryByIDCompletedEventHandler SelectTemplateCategoryByIDCompletedEvent;

		private UpdateTemplateCategoryCompletedEventHandler UpdateTemplateCategoryCompletedEvent;

		public event CreateTemplateCategoryCompletedEventHandler CreateTemplateCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateTemplateCategoryCompletedEvent = (CreateTemplateCategoryCompletedEventHandler)Delegate.Combine(this.CreateTemplateCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateTemplateCategoryCompletedEvent = (CreateTemplateCategoryCompletedEventHandler)Delegate.Remove(this.CreateTemplateCategoryCompletedEvent, value);
			}
		}

		public event DeleteTemplateCategoryCompletedEventHandler DeleteTemplateCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteTemplateCategoryCompletedEvent = (DeleteTemplateCategoryCompletedEventHandler)Delegate.Combine(this.DeleteTemplateCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteTemplateCategoryCompletedEvent = (DeleteTemplateCategoryCompletedEventHandler)Delegate.Remove(this.DeleteTemplateCategoryCompletedEvent, value);
			}
		}

		public event SelectAllTemplateCategoryCompletedEventHandler SelectAllTemplateCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllTemplateCategoryCompletedEvent = (SelectAllTemplateCategoryCompletedEventHandler)Delegate.Combine(this.SelectAllTemplateCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllTemplateCategoryCompletedEvent = (SelectAllTemplateCategoryCompletedEventHandler)Delegate.Remove(this.SelectAllTemplateCategoryCompletedEvent, value);
			}
		}

		public event SelectTemplateCategoryByIDCompletedEventHandler SelectTemplateCategoryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectTemplateCategoryByIDCompletedEvent = (SelectTemplateCategoryByIDCompletedEventHandler)Delegate.Combine(this.SelectTemplateCategoryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectTemplateCategoryByIDCompletedEvent = (SelectTemplateCategoryByIDCompletedEventHandler)Delegate.Remove(this.SelectTemplateCategoryByIDCompletedEvent, value);
			}
		}

		public event UpdateTemplateCategoryCompletedEventHandler UpdateTemplateCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateTemplateCategoryCompletedEvent = (UpdateTemplateCategoryCompletedEventHandler)Delegate.Combine(this.UpdateTemplateCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateTemplateCategoryCompletedEvent = (UpdateTemplateCategoryCompletedEventHandler)Delegate.Remove(this.UpdateTemplateCategoryCompletedEvent, value);
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

		public TemplateCategoryInfo()
		{
			this.Url = MySettings.Default.EPRLib_ITCategoryData_TemplateCategoryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplateCategory.CreateTemplateCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateTemplateCategory(ETemplateCategory AETemplateCategory)
		{
			object[] array = this.Invoke("CreateTemplateCategory", new object[]
			{
				AETemplateCategory
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateTemplateCategoryAsync(ETemplateCategory AETemplateCategory)
		{
			this.CreateTemplateCategoryAsync(AETemplateCategory, null);
		}

		public void CreateTemplateCategoryAsync(ETemplateCategory AETemplateCategory, object userState)
		{
			if (this.CreateTemplateCategoryOperationCompleted == null)
			{
				this.CreateTemplateCategoryOperationCompleted = new SendOrPostCallback(this.OnCreateTemplateCategoryOperationCompleted);
			}
			this.InvokeAsync("CreateTemplateCategory", new object[]
			{
				AETemplateCategory
			}, this.CreateTemplateCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateTemplateCategoryOperationCompleted(object arg)
		{
			if (this.CreateTemplateCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateTemplateCategoryCompletedEventHandler createTemplateCategoryCompletedEvent = this.CreateTemplateCategoryCompletedEvent;
				if (createTemplateCategoryCompletedEvent != null)
				{
					createTemplateCategoryCompletedEvent(this, new CreateTemplateCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplateCategory.DeleteTemplateCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteTemplateCategory(string ATemplateCategoryId, ref bool DeleteTemplateCategoryResult, [XmlIgnore] ref bool DeleteTemplateCategoryResultSpecified)
		{
			object[] array = this.Invoke("DeleteTemplateCategory", new object[]
			{
				ATemplateCategoryId
			});
			DeleteTemplateCategoryResult = Conversions.ToBoolean(array[0]);
			DeleteTemplateCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteTemplateCategoryAsync(string ATemplateCategoryId)
		{
			this.DeleteTemplateCategoryAsync(ATemplateCategoryId, null);
		}

		public void DeleteTemplateCategoryAsync(string ATemplateCategoryId, object userState)
		{
			if (this.DeleteTemplateCategoryOperationCompleted == null)
			{
				this.DeleteTemplateCategoryOperationCompleted = new SendOrPostCallback(this.OnDeleteTemplateCategoryOperationCompleted);
			}
			this.InvokeAsync("DeleteTemplateCategory", new object[]
			{
				ATemplateCategoryId
			}, this.DeleteTemplateCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteTemplateCategoryOperationCompleted(object arg)
		{
			if (this.DeleteTemplateCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteTemplateCategoryCompletedEventHandler deleteTemplateCategoryCompletedEvent = this.DeleteTemplateCategoryCompletedEvent;
				if (deleteTemplateCategoryCompletedEvent != null)
				{
					deleteTemplateCategoryCompletedEvent(this, new DeleteTemplateCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplateCategory.SelectAllTemplateCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateCategoryDataset SelectAllTemplateCategory()
		{
			object[] array = this.Invoke("SelectAllTemplateCategory", new object[0]);
			return (ETemplateCategoryDataset)array[0];
		}

		public void SelectAllTemplateCategoryAsync()
		{
			this.SelectAllTemplateCategoryAsync(null);
		}

		public void SelectAllTemplateCategoryAsync(object userState)
		{
			if (this.SelectAllTemplateCategoryOperationCompleted == null)
			{
				this.SelectAllTemplateCategoryOperationCompleted = new SendOrPostCallback(this.OnSelectAllTemplateCategoryOperationCompleted);
			}
			this.InvokeAsync("SelectAllTemplateCategory", new object[0], this.SelectAllTemplateCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllTemplateCategoryOperationCompleted(object arg)
		{
			if (this.SelectAllTemplateCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllTemplateCategoryCompletedEventHandler selectAllTemplateCategoryCompletedEvent = this.SelectAllTemplateCategoryCompletedEvent;
				if (selectAllTemplateCategoryCompletedEvent != null)
				{
					selectAllTemplateCategoryCompletedEvent(this, new SelectAllTemplateCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplateCategory.SelectTemplateCategoryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateCategory SelectTemplateCategoryByID(string AID)
		{
			object[] array = this.Invoke("SelectTemplateCategoryByID", new object[]
			{
				AID
			});
			return (ETemplateCategory)array[0];
		}

		public void SelectTemplateCategoryByIDAsync(string AID)
		{
			this.SelectTemplateCategoryByIDAsync(AID, null);
		}

		public void SelectTemplateCategoryByIDAsync(string AID, object userState)
		{
			if (this.SelectTemplateCategoryByIDOperationCompleted == null)
			{
				this.SelectTemplateCategoryByIDOperationCompleted = new SendOrPostCallback(this.OnSelectTemplateCategoryByIDOperationCompleted);
			}
			this.InvokeAsync("SelectTemplateCategoryByID", new object[]
			{
				AID
			}, this.SelectTemplateCategoryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectTemplateCategoryByIDOperationCompleted(object arg)
		{
			if (this.SelectTemplateCategoryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectTemplateCategoryByIDCompletedEventHandler selectTemplateCategoryByIDCompletedEvent = this.SelectTemplateCategoryByIDCompletedEvent;
				if (selectTemplateCategoryByIDCompletedEvent != null)
				{
					selectTemplateCategoryByIDCompletedEvent(this, new SelectTemplateCategoryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplateCategory.UpdateTemplateCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateTemplateCategory(ETemplateCategory AETemplateCategory, ref bool UpdateTemplateCategoryResult, [XmlIgnore] ref bool UpdateTemplateCategoryResultSpecified)
		{
			object[] array = this.Invoke("UpdateTemplateCategory", new object[]
			{
				AETemplateCategory
			});
			UpdateTemplateCategoryResult = Conversions.ToBoolean(array[0]);
			UpdateTemplateCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateTemplateCategoryAsync(ETemplateCategory AETemplateCategory)
		{
			this.UpdateTemplateCategoryAsync(AETemplateCategory, null);
		}

		public void UpdateTemplateCategoryAsync(ETemplateCategory AETemplateCategory, object userState)
		{
			if (this.UpdateTemplateCategoryOperationCompleted == null)
			{
				this.UpdateTemplateCategoryOperationCompleted = new SendOrPostCallback(this.OnUpdateTemplateCategoryOperationCompleted);
			}
			this.InvokeAsync("UpdateTemplateCategory", new object[]
			{
				AETemplateCategory
			}, this.UpdateTemplateCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateTemplateCategoryOperationCompleted(object arg)
		{
			if (this.UpdateTemplateCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateTemplateCategoryCompletedEventHandler updateTemplateCategoryCompletedEvent = this.UpdateTemplateCategoryCompletedEvent;
				if (updateTemplateCategoryCompletedEvent != null)
				{
					updateTemplateCategoryCompletedEvent(this, new UpdateTemplateCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
