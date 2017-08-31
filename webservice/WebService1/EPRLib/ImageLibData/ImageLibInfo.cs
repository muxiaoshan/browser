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

namespace ImageLibData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ImageLibInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class ImageLibInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateImageLibOperationCompleted;

		private SendOrPostCallback DeleteImageLibOperationCompleted;

		private SendOrPostCallback GetImageLibByIDOperationCompleted;

		private SendOrPostCallback GetImageLibsByCateIDOperationCompleted;

		private SendOrPostCallback GetPatientNameByEpisodeIDOperationCompleted;

		private SendOrPostCallback UpdateImageLibOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateImageLibCompletedEventHandler CreateImageLibCompletedEvent;

		private DeleteImageLibCompletedEventHandler DeleteImageLibCompletedEvent;

		private GetImageLibByIDCompletedEventHandler GetImageLibByIDCompletedEvent;

		private GetImageLibsByCateIDCompletedEventHandler GetImageLibsByCateIDCompletedEvent;

		private GetPatientNameByEpisodeIDCompletedEventHandler GetPatientNameByEpisodeIDCompletedEvent;

		private UpdateImageLibCompletedEventHandler UpdateImageLibCompletedEvent;

		public event CreateImageLibCompletedEventHandler CreateImageLibCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateImageLibCompletedEvent = (CreateImageLibCompletedEventHandler)Delegate.Combine(this.CreateImageLibCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateImageLibCompletedEvent = (CreateImageLibCompletedEventHandler)Delegate.Remove(this.CreateImageLibCompletedEvent, value);
			}
		}

		public event DeleteImageLibCompletedEventHandler DeleteImageLibCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteImageLibCompletedEvent = (DeleteImageLibCompletedEventHandler)Delegate.Combine(this.DeleteImageLibCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteImageLibCompletedEvent = (DeleteImageLibCompletedEventHandler)Delegate.Remove(this.DeleteImageLibCompletedEvent, value);
			}
		}

		public event GetImageLibByIDCompletedEventHandler GetImageLibByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetImageLibByIDCompletedEvent = (GetImageLibByIDCompletedEventHandler)Delegate.Combine(this.GetImageLibByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetImageLibByIDCompletedEvent = (GetImageLibByIDCompletedEventHandler)Delegate.Remove(this.GetImageLibByIDCompletedEvent, value);
			}
		}

		public event GetImageLibsByCateIDCompletedEventHandler GetImageLibsByCateIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetImageLibsByCateIDCompletedEvent = (GetImageLibsByCateIDCompletedEventHandler)Delegate.Combine(this.GetImageLibsByCateIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetImageLibsByCateIDCompletedEvent = (GetImageLibsByCateIDCompletedEventHandler)Delegate.Remove(this.GetImageLibsByCateIDCompletedEvent, value);
			}
		}

		public event GetPatientNameByEpisodeIDCompletedEventHandler GetPatientNameByEpisodeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetPatientNameByEpisodeIDCompletedEvent = (GetPatientNameByEpisodeIDCompletedEventHandler)Delegate.Combine(this.GetPatientNameByEpisodeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetPatientNameByEpisodeIDCompletedEvent = (GetPatientNameByEpisodeIDCompletedEventHandler)Delegate.Remove(this.GetPatientNameByEpisodeIDCompletedEvent, value);
			}
		}

		public event UpdateImageLibCompletedEventHandler UpdateImageLibCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateImageLibCompletedEvent = (UpdateImageLibCompletedEventHandler)Delegate.Combine(this.UpdateImageLibCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateImageLibCompletedEvent = (UpdateImageLibCompletedEventHandler)Delegate.Remove(this.UpdateImageLibCompletedEvent, value);
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

		public ImageLibInfo()
		{
			this.Url = MySettings.Default.EPRLib_ImageLibData_ImageLibInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.CreateImageLib", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateImageLib(EImageLib AEImageLib)
		{
			object[] array = this.Invoke("CreateImageLib", new object[]
			{
				AEImageLib
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateImageLibAsync(EImageLib AEImageLib)
		{
			this.CreateImageLibAsync(AEImageLib, null);
		}

		public void CreateImageLibAsync(EImageLib AEImageLib, object userState)
		{
			if (this.CreateImageLibOperationCompleted == null)
			{
				this.CreateImageLibOperationCompleted = new SendOrPostCallback(this.OnCreateImageLibOperationCompleted);
			}
			this.InvokeAsync("CreateImageLib", new object[]
			{
				AEImageLib
			}, this.CreateImageLibOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateImageLibOperationCompleted(object arg)
		{
			if (this.CreateImageLibCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateImageLibCompletedEventHandler createImageLibCompletedEvent = this.CreateImageLibCompletedEvent;
				if (createImageLibCompletedEvent != null)
				{
					createImageLibCompletedEvent(this, new CreateImageLibCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.DeleteImageLib", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string DeleteImageLib(string AImageLibID)
		{
			object[] array = this.Invoke("DeleteImageLib", new object[]
			{
				AImageLibID
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteImageLibAsync(string AImageLibID)
		{
			this.DeleteImageLibAsync(AImageLibID, null);
		}

		public void DeleteImageLibAsync(string AImageLibID, object userState)
		{
			if (this.DeleteImageLibOperationCompleted == null)
			{
				this.DeleteImageLibOperationCompleted = new SendOrPostCallback(this.OnDeleteImageLibOperationCompleted);
			}
			this.InvokeAsync("DeleteImageLib", new object[]
			{
				AImageLibID
			}, this.DeleteImageLibOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteImageLibOperationCompleted(object arg)
		{
			if (this.DeleteImageLibCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteImageLibCompletedEventHandler deleteImageLibCompletedEvent = this.DeleteImageLibCompletedEvent;
				if (deleteImageLibCompletedEvent != null)
				{
					deleteImageLibCompletedEvent(this, new DeleteImageLibCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.GetImageLibByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageLib GetImageLibByID(string AImageLibID)
		{
			object[] array = this.Invoke("GetImageLibByID", new object[]
			{
				AImageLibID
			});
			return (EImageLib)array[0];
		}

		public void GetImageLibByIDAsync(string AImageLibID)
		{
			this.GetImageLibByIDAsync(AImageLibID, null);
		}

		public void GetImageLibByIDAsync(string AImageLibID, object userState)
		{
			if (this.GetImageLibByIDOperationCompleted == null)
			{
				this.GetImageLibByIDOperationCompleted = new SendOrPostCallback(this.OnGetImageLibByIDOperationCompleted);
			}
			this.InvokeAsync("GetImageLibByID", new object[]
			{
				AImageLibID
			}, this.GetImageLibByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetImageLibByIDOperationCompleted(object arg)
		{
			if (this.GetImageLibByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetImageLibByIDCompletedEventHandler getImageLibByIDCompletedEvent = this.GetImageLibByIDCompletedEvent;
				if (getImageLibByIDCompletedEvent != null)
				{
					getImageLibByIDCompletedEvent(this, new GetImageLibByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.GetImageLibsByCateID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageLibDataset GetImageLibsByCateID(string ACategoryID)
		{
			object[] array = this.Invoke("GetImageLibsByCateID", new object[]
			{
				ACategoryID
			});
			return (EImageLibDataset)array[0];
		}

		public void GetImageLibsByCateIDAsync(string ACategoryID)
		{
			this.GetImageLibsByCateIDAsync(ACategoryID, null);
		}

		public void GetImageLibsByCateIDAsync(string ACategoryID, object userState)
		{
			if (this.GetImageLibsByCateIDOperationCompleted == null)
			{
				this.GetImageLibsByCateIDOperationCompleted = new SendOrPostCallback(this.OnGetImageLibsByCateIDOperationCompleted);
			}
			this.InvokeAsync("GetImageLibsByCateID", new object[]
			{
				ACategoryID
			}, this.GetImageLibsByCateIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetImageLibsByCateIDOperationCompleted(object arg)
		{
			if (this.GetImageLibsByCateIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetImageLibsByCateIDCompletedEventHandler getImageLibsByCateIDCompletedEvent = this.GetImageLibsByCateIDCompletedEvent;
				if (getImageLibsByCateIDCompletedEvent != null)
				{
					getImageLibsByCateIDCompletedEvent(this, new GetImageLibsByCateIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.GetPatientNameByEpisodeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetPatientNameByEpisodeID(string AEpisodeID)
		{
			object[] array = this.Invoke("GetPatientNameByEpisodeID", new object[]
			{
				AEpisodeID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetPatientNameByEpisodeIDAsync(string AEpisodeID)
		{
			this.GetPatientNameByEpisodeIDAsync(AEpisodeID, null);
		}

		public void GetPatientNameByEpisodeIDAsync(string AEpisodeID, object userState)
		{
			if (this.GetPatientNameByEpisodeIDOperationCompleted == null)
			{
				this.GetPatientNameByEpisodeIDOperationCompleted = new SendOrPostCallback(this.OnGetPatientNameByEpisodeIDOperationCompleted);
			}
			this.InvokeAsync("GetPatientNameByEpisodeID", new object[]
			{
				AEpisodeID
			}, this.GetPatientNameByEpisodeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetPatientNameByEpisodeIDOperationCompleted(object arg)
		{
			if (this.GetPatientNameByEpisodeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetPatientNameByEpisodeIDCompletedEventHandler getPatientNameByEpisodeIDCompletedEvent = this.GetPatientNameByEpisodeIDCompletedEvent;
				if (getPatientNameByEpisodeIDCompletedEvent != null)
				{
					getPatientNameByEpisodeIDCompletedEvent(this, new GetPatientNameByEpisodeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageLib.UpdateImageLib", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateImageLib(EImageLib AEImageLib)
		{
			object[] array = this.Invoke("UpdateImageLib", new object[]
			{
				AEImageLib
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateImageLibAsync(EImageLib AEImageLib)
		{
			this.UpdateImageLibAsync(AEImageLib, null);
		}

		public void UpdateImageLibAsync(EImageLib AEImageLib, object userState)
		{
			if (this.UpdateImageLibOperationCompleted == null)
			{
				this.UpdateImageLibOperationCompleted = new SendOrPostCallback(this.OnUpdateImageLibOperationCompleted);
			}
			this.InvokeAsync("UpdateImageLib", new object[]
			{
				AEImageLib
			}, this.UpdateImageLibOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateImageLibOperationCompleted(object arg)
		{
			if (this.UpdateImageLibCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateImageLibCompletedEventHandler updateImageLibCompletedEvent = this.UpdateImageLibCompletedEvent;
				if (updateImageLibCompletedEvent != null)
				{
					updateImageLibCompletedEvent(this, new UpdateImageLibCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
