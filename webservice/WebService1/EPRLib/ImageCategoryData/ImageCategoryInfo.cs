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

namespace ImageCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ImageCategoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class ImageCategoryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateImageCategoryOperationCompleted;

		private SendOrPostCallback DeleteImageCategoryOperationCompleted;

		private SendOrPostCallback GetAllImageCategoriesOperationCompleted;

		private SendOrPostCallback UpdateImageCategoryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateImageCategoryCompletedEventHandler CreateImageCategoryCompletedEvent;

		private DeleteImageCategoryCompletedEventHandler DeleteImageCategoryCompletedEvent;

		private GetAllImageCategoriesCompletedEventHandler GetAllImageCategoriesCompletedEvent;

		private UpdateImageCategoryCompletedEventHandler UpdateImageCategoryCompletedEvent;

		public event CreateImageCategoryCompletedEventHandler CreateImageCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateImageCategoryCompletedEvent = (CreateImageCategoryCompletedEventHandler)Delegate.Combine(this.CreateImageCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateImageCategoryCompletedEvent = (CreateImageCategoryCompletedEventHandler)Delegate.Remove(this.CreateImageCategoryCompletedEvent, value);
			}
		}

		public event DeleteImageCategoryCompletedEventHandler DeleteImageCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteImageCategoryCompletedEvent = (DeleteImageCategoryCompletedEventHandler)Delegate.Combine(this.DeleteImageCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteImageCategoryCompletedEvent = (DeleteImageCategoryCompletedEventHandler)Delegate.Remove(this.DeleteImageCategoryCompletedEvent, value);
			}
		}

		public event GetAllImageCategoriesCompletedEventHandler GetAllImageCategoriesCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllImageCategoriesCompletedEvent = (GetAllImageCategoriesCompletedEventHandler)Delegate.Combine(this.GetAllImageCategoriesCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllImageCategoriesCompletedEvent = (GetAllImageCategoriesCompletedEventHandler)Delegate.Remove(this.GetAllImageCategoriesCompletedEvent, value);
			}
		}

		public event UpdateImageCategoryCompletedEventHandler UpdateImageCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateImageCategoryCompletedEvent = (UpdateImageCategoryCompletedEventHandler)Delegate.Combine(this.UpdateImageCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateImageCategoryCompletedEvent = (UpdateImageCategoryCompletedEventHandler)Delegate.Remove(this.UpdateImageCategoryCompletedEvent, value);
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

		public ImageCategoryInfo()
		{
			this.Url = MySettings.Default.EPRLib_ImageCategoryData_ImageCategoryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageCategory.CreateImageCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateImageCategory(EImageCategory AECategory)
		{
			object[] array = this.Invoke("CreateImageCategory", new object[]
			{
				AECategory
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateImageCategoryAsync(EImageCategory AECategory)
		{
			this.CreateImageCategoryAsync(AECategory, null);
		}

		public void CreateImageCategoryAsync(EImageCategory AECategory, object userState)
		{
			if (this.CreateImageCategoryOperationCompleted == null)
			{
				this.CreateImageCategoryOperationCompleted = new SendOrPostCallback(this.OnCreateImageCategoryOperationCompleted);
			}
			this.InvokeAsync("CreateImageCategory", new object[]
			{
				AECategory
			}, this.CreateImageCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateImageCategoryOperationCompleted(object arg)
		{
			if (this.CreateImageCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateImageCategoryCompletedEventHandler createImageCategoryCompletedEvent = this.CreateImageCategoryCompletedEvent;
				if (createImageCategoryCompletedEvent != null)
				{
					createImageCategoryCompletedEvent(this, new CreateImageCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageCategory.DeleteImageCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteImageCategory(string ACategoryID, ref bool DeleteImageCategoryResult, [XmlIgnore] ref bool DeleteImageCategoryResultSpecified)
		{
			object[] array = this.Invoke("DeleteImageCategory", new object[]
			{
				ACategoryID
			});
			DeleteImageCategoryResult = Conversions.ToBoolean(array[0]);
			DeleteImageCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteImageCategoryAsync(string ACategoryID)
		{
			this.DeleteImageCategoryAsync(ACategoryID, null);
		}

		public void DeleteImageCategoryAsync(string ACategoryID, object userState)
		{
			if (this.DeleteImageCategoryOperationCompleted == null)
			{
				this.DeleteImageCategoryOperationCompleted = new SendOrPostCallback(this.OnDeleteImageCategoryOperationCompleted);
			}
			this.InvokeAsync("DeleteImageCategory", new object[]
			{
				ACategoryID
			}, this.DeleteImageCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteImageCategoryOperationCompleted(object arg)
		{
			if (this.DeleteImageCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteImageCategoryCompletedEventHandler deleteImageCategoryCompletedEvent = this.DeleteImageCategoryCompletedEvent;
				if (deleteImageCategoryCompletedEvent != null)
				{
					deleteImageCategoryCompletedEvent(this, new DeleteImageCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageCategory.GetAllImageCategories", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageCategoryDataset GetAllImageCategories()
		{
			object[] array = this.Invoke("GetAllImageCategories", new object[0]);
			return (EImageCategoryDataset)array[0];
		}

		public void GetAllImageCategoriesAsync()
		{
			this.GetAllImageCategoriesAsync(null);
		}

		public void GetAllImageCategoriesAsync(object userState)
		{
			if (this.GetAllImageCategoriesOperationCompleted == null)
			{
				this.GetAllImageCategoriesOperationCompleted = new SendOrPostCallback(this.OnGetAllImageCategoriesOperationCompleted);
			}
			this.InvokeAsync("GetAllImageCategories", new object[0], this.GetAllImageCategoriesOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllImageCategoriesOperationCompleted(object arg)
		{
			if (this.GetAllImageCategoriesCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllImageCategoriesCompletedEventHandler getAllImageCategoriesCompletedEvent = this.GetAllImageCategoriesCompletedEvent;
				if (getAllImageCategoriesCompletedEvent != null)
				{
					getAllImageCategoriesCompletedEvent(this, new GetAllImageCategoriesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageCategory.UpdateImageCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateImageCategory(EImageCategory AECategory, ref bool UpdateImageCategoryResult, [XmlIgnore] ref bool UpdateImageCategoryResultSpecified)
		{
			object[] array = this.Invoke("UpdateImageCategory", new object[]
			{
				AECategory
			});
			UpdateImageCategoryResult = Conversions.ToBoolean(array[0]);
			UpdateImageCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateImageCategoryAsync(EImageCategory AECategory)
		{
			this.UpdateImageCategoryAsync(AECategory, null);
		}

		public void UpdateImageCategoryAsync(EImageCategory AECategory, object userState)
		{
			if (this.UpdateImageCategoryOperationCompleted == null)
			{
				this.UpdateImageCategoryOperationCompleted = new SendOrPostCallback(this.OnUpdateImageCategoryOperationCompleted);
			}
			this.InvokeAsync("UpdateImageCategory", new object[]
			{
				AECategory
			}, this.UpdateImageCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateImageCategoryOperationCompleted(object arg)
		{
			if (this.UpdateImageCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateImageCategoryCompletedEventHandler updateImageCategoryCompletedEvent = this.UpdateImageCategoryCompletedEvent;
				if (updateImageCategoryCompletedEvent != null)
				{
					updateImageCategoryCompletedEvent(this, new UpdateImageCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
