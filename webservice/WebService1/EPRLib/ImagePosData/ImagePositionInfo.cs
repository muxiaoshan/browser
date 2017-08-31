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

namespace ImagePosData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ImagePositionInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class ImagePositionInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateImagePositionOperationCompleted;

		private SendOrPostCallback DeleteImagePositionOperationCompleted;

		private SendOrPostCallback GetALLImagePositionOperationCompleted;

		private SendOrPostCallback GetImagePositionByCodeOperationCompleted;

		private SendOrPostCallback GetImagePositionByIDOperationCompleted;

		private SendOrPostCallback UpdateImagePositionOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateImagePositionCompletedEventHandler CreateImagePositionCompletedEvent;

		private DeleteImagePositionCompletedEventHandler DeleteImagePositionCompletedEvent;

		private GetALLImagePositionCompletedEventHandler GetALLImagePositionCompletedEvent;

		private GetImagePositionByCodeCompletedEventHandler GetImagePositionByCodeCompletedEvent;

		private GetImagePositionByIDCompletedEventHandler GetImagePositionByIDCompletedEvent;

		private UpdateImagePositionCompletedEventHandler UpdateImagePositionCompletedEvent;

		public event CreateImagePositionCompletedEventHandler CreateImagePositionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateImagePositionCompletedEvent = (CreateImagePositionCompletedEventHandler)Delegate.Combine(this.CreateImagePositionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateImagePositionCompletedEvent = (CreateImagePositionCompletedEventHandler)Delegate.Remove(this.CreateImagePositionCompletedEvent, value);
			}
		}

		public event DeleteImagePositionCompletedEventHandler DeleteImagePositionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteImagePositionCompletedEvent = (DeleteImagePositionCompletedEventHandler)Delegate.Combine(this.DeleteImagePositionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteImagePositionCompletedEvent = (DeleteImagePositionCompletedEventHandler)Delegate.Remove(this.DeleteImagePositionCompletedEvent, value);
			}
		}

		public event GetALLImagePositionCompletedEventHandler GetALLImagePositionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetALLImagePositionCompletedEvent = (GetALLImagePositionCompletedEventHandler)Delegate.Combine(this.GetALLImagePositionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetALLImagePositionCompletedEvent = (GetALLImagePositionCompletedEventHandler)Delegate.Remove(this.GetALLImagePositionCompletedEvent, value);
			}
		}

		public event GetImagePositionByCodeCompletedEventHandler GetImagePositionByCodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetImagePositionByCodeCompletedEvent = (GetImagePositionByCodeCompletedEventHandler)Delegate.Combine(this.GetImagePositionByCodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetImagePositionByCodeCompletedEvent = (GetImagePositionByCodeCompletedEventHandler)Delegate.Remove(this.GetImagePositionByCodeCompletedEvent, value);
			}
		}

		public event GetImagePositionByIDCompletedEventHandler GetImagePositionByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetImagePositionByIDCompletedEvent = (GetImagePositionByIDCompletedEventHandler)Delegate.Combine(this.GetImagePositionByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetImagePositionByIDCompletedEvent = (GetImagePositionByIDCompletedEventHandler)Delegate.Remove(this.GetImagePositionByIDCompletedEvent, value);
			}
		}

		public event UpdateImagePositionCompletedEventHandler UpdateImagePositionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateImagePositionCompletedEvent = (UpdateImagePositionCompletedEventHandler)Delegate.Combine(this.UpdateImagePositionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateImagePositionCompletedEvent = (UpdateImagePositionCompletedEventHandler)Delegate.Remove(this.UpdateImagePositionCompletedEvent, value);
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

		public ImagePositionInfo()
		{
			this.Url = MySettings.Default.EPRLib_ImagePosData_ImagePositionInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.CreateImagePosition", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateImagePosition(EImagePosition AEImagePosition)
		{
			object[] array = this.Invoke("CreateImagePosition", new object[]
			{
				AEImagePosition
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateImagePositionAsync(EImagePosition AEImagePosition)
		{
			this.CreateImagePositionAsync(AEImagePosition, null);
		}

		public void CreateImagePositionAsync(EImagePosition AEImagePosition, object userState)
		{
			if (this.CreateImagePositionOperationCompleted == null)
			{
				this.CreateImagePositionOperationCompleted = new SendOrPostCallback(this.OnCreateImagePositionOperationCompleted);
			}
			this.InvokeAsync("CreateImagePosition", new object[]
			{
				AEImagePosition
			}, this.CreateImagePositionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateImagePositionOperationCompleted(object arg)
		{
			if (this.CreateImagePositionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateImagePositionCompletedEventHandler createImagePositionCompletedEvent = this.CreateImagePositionCompletedEvent;
				if (createImagePositionCompletedEvent != null)
				{
					createImagePositionCompletedEvent(this, new CreateImagePositionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.DeleteImagePosition", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteImagePosition(string AID, ref bool DeleteImagePositionResult, [XmlIgnore] ref bool DeleteImagePositionResultSpecified)
		{
			object[] array = this.Invoke("DeleteImagePosition", new object[]
			{
				AID
			});
			DeleteImagePositionResult = Conversions.ToBoolean(array[0]);
			DeleteImagePositionResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteImagePositionAsync(string AID)
		{
			this.DeleteImagePositionAsync(AID, null);
		}

		public void DeleteImagePositionAsync(string AID, object userState)
		{
			if (this.DeleteImagePositionOperationCompleted == null)
			{
				this.DeleteImagePositionOperationCompleted = new SendOrPostCallback(this.OnDeleteImagePositionOperationCompleted);
			}
			this.InvokeAsync("DeleteImagePosition", new object[]
			{
				AID
			}, this.DeleteImagePositionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteImagePositionOperationCompleted(object arg)
		{
			if (this.DeleteImagePositionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteImagePositionCompletedEventHandler deleteImagePositionCompletedEvent = this.DeleteImagePositionCompletedEvent;
				if (deleteImagePositionCompletedEvent != null)
				{
					deleteImagePositionCompletedEvent(this, new DeleteImagePositionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.GetALLImagePosition", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImagePositionDataset GetALLImagePosition()
		{
			object[] array = this.Invoke("GetALLImagePosition", new object[0]);
			return (EImagePositionDataset)array[0];
		}

		public void GetALLImagePositionAsync()
		{
			this.GetALLImagePositionAsync(null);
		}

		public void GetALLImagePositionAsync(object userState)
		{
			if (this.GetALLImagePositionOperationCompleted == null)
			{
				this.GetALLImagePositionOperationCompleted = new SendOrPostCallback(this.OnGetALLImagePositionOperationCompleted);
			}
			this.InvokeAsync("GetALLImagePosition", new object[0], this.GetALLImagePositionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetALLImagePositionOperationCompleted(object arg)
		{
			if (this.GetALLImagePositionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetALLImagePositionCompletedEventHandler getALLImagePositionCompletedEvent = this.GetALLImagePositionCompletedEvent;
				if (getALLImagePositionCompletedEvent != null)
				{
					getALLImagePositionCompletedEvent(this, new GetALLImagePositionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.GetImagePositionByCode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImagePosition GetImagePositionByCode(string ACode)
		{
			object[] array = this.Invoke("GetImagePositionByCode", new object[]
			{
				ACode
			});
			return (EImagePosition)array[0];
		}

		public void GetImagePositionByCodeAsync(string ACode)
		{
			this.GetImagePositionByCodeAsync(ACode, null);
		}

		public void GetImagePositionByCodeAsync(string ACode, object userState)
		{
			if (this.GetImagePositionByCodeOperationCompleted == null)
			{
				this.GetImagePositionByCodeOperationCompleted = new SendOrPostCallback(this.OnGetImagePositionByCodeOperationCompleted);
			}
			this.InvokeAsync("GetImagePositionByCode", new object[]
			{
				ACode
			}, this.GetImagePositionByCodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetImagePositionByCodeOperationCompleted(object arg)
		{
			if (this.GetImagePositionByCodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetImagePositionByCodeCompletedEventHandler getImagePositionByCodeCompletedEvent = this.GetImagePositionByCodeCompletedEvent;
				if (getImagePositionByCodeCompletedEvent != null)
				{
					getImagePositionByCodeCompletedEvent(this, new GetImagePositionByCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.GetImagePositionByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImagePosition GetImagePositionByID(string AID)
		{
			object[] array = this.Invoke("GetImagePositionByID", new object[]
			{
				AID
			});
			return (EImagePosition)array[0];
		}

		public void GetImagePositionByIDAsync(string AID)
		{
			this.GetImagePositionByIDAsync(AID, null);
		}

		public void GetImagePositionByIDAsync(string AID, object userState)
		{
			if (this.GetImagePositionByIDOperationCompleted == null)
			{
				this.GetImagePositionByIDOperationCompleted = new SendOrPostCallback(this.OnGetImagePositionByIDOperationCompleted);
			}
			this.InvokeAsync("GetImagePositionByID", new object[]
			{
				AID
			}, this.GetImagePositionByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetImagePositionByIDOperationCompleted(object arg)
		{
			if (this.GetImagePositionByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetImagePositionByIDCompletedEventHandler getImagePositionByIDCompletedEvent = this.GetImagePositionByIDCompletedEvent;
				if (getImagePositionByIDCompletedEvent != null)
				{
					getImagePositionByIDCompletedEvent(this, new GetImagePositionByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImagePosition.UpdateImagePosition", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateImagePosition(EImagePosition AEImagePosition, ref bool UpdateImagePositionResult, [XmlIgnore] ref bool UpdateImagePositionResultSpecified)
		{
			object[] array = this.Invoke("UpdateImagePosition", new object[]
			{
				AEImagePosition
			});
			UpdateImagePositionResult = Conversions.ToBoolean(array[0]);
			UpdateImagePositionResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateImagePositionAsync(EImagePosition AEImagePosition)
		{
			this.UpdateImagePositionAsync(AEImagePosition, null);
		}

		public void UpdateImagePositionAsync(EImagePosition AEImagePosition, object userState)
		{
			if (this.UpdateImagePositionOperationCompleted == null)
			{
				this.UpdateImagePositionOperationCompleted = new SendOrPostCallback(this.OnUpdateImagePositionOperationCompleted);
			}
			this.InvokeAsync("UpdateImagePosition", new object[]
			{
				AEImagePosition
			}, this.UpdateImagePositionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateImagePositionOperationCompleted(object arg)
		{
			if (this.UpdateImagePositionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateImagePositionCompletedEventHandler updateImagePositionCompletedEvent = this.UpdateImagePositionCompletedEvent;
				if (updateImagePositionCompletedEvent != null)
				{
					updateImagePositionCompletedEvent(this, new UpdateImagePositionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
