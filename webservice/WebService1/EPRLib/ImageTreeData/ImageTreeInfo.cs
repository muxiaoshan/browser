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

namespace ImageTreeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ImageTreeInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class ImageTreeInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateOperationCompleted;

		private SendOrPostCallback GetByImageLibIDOperationCompleted;

		private SendOrPostCallback GetEntityOperationCompleted;

		private SendOrPostCallback SwapSequenceOperationCompleted;

		private SendOrPostCallback UpdateOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateCompletedEventHandler CreateCompletedEvent;

		private GetByImageLibIDCompletedEventHandler GetByImageLibIDCompletedEvent;

		private GetEntityCompletedEventHandler GetEntityCompletedEvent;

		private SwapSequenceCompletedEventHandler SwapSequenceCompletedEvent;

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

		public event GetByImageLibIDCompletedEventHandler GetByImageLibIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetByImageLibIDCompletedEvent = (GetByImageLibIDCompletedEventHandler)Delegate.Combine(this.GetByImageLibIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetByImageLibIDCompletedEvent = (GetByImageLibIDCompletedEventHandler)Delegate.Remove(this.GetByImageLibIDCompletedEvent, value);
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

		public event SwapSequenceCompletedEventHandler SwapSequenceCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SwapSequenceCompletedEvent = (SwapSequenceCompletedEventHandler)Delegate.Combine(this.SwapSequenceCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SwapSequenceCompletedEvent = (SwapSequenceCompletedEventHandler)Delegate.Remove(this.SwapSequenceCompletedEvent, value);
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

		public ImageTreeInfo()
		{
			this.Url = MySettings.Default.EPRLib_ImageTreeData_ImageTreeInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageTree.Create", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Create(EImageTree AEImageTree)
		{
			object[] array = this.Invoke("Create", new object[]
			{
				AEImageTree
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateAsync(EImageTree AEImageTree)
		{
			this.CreateAsync(AEImageTree, null);
		}

		public void CreateAsync(EImageTree AEImageTree, object userState)
		{
			if (this.CreateOperationCompleted == null)
			{
				this.CreateOperationCompleted = new SendOrPostCallback(this.OnCreateOperationCompleted);
			}
			this.InvokeAsync("Create", new object[]
			{
				AEImageTree
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageTree.GetByImageLibID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageTreeDataSet GetByImageLibID(string AImageLibID)
		{
			object[] array = this.Invoke("GetByImageLibID", new object[]
			{
				AImageLibID
			});
			return (EImageTreeDataSet)array[0];
		}

		public void GetByImageLibIDAsync(string AImageLibID)
		{
			this.GetByImageLibIDAsync(AImageLibID, null);
		}

		public void GetByImageLibIDAsync(string AImageLibID, object userState)
		{
			if (this.GetByImageLibIDOperationCompleted == null)
			{
				this.GetByImageLibIDOperationCompleted = new SendOrPostCallback(this.OnGetByImageLibIDOperationCompleted);
			}
			this.InvokeAsync("GetByImageLibID", new object[]
			{
				AImageLibID
			}, this.GetByImageLibIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetByImageLibIDOperationCompleted(object arg)
		{
			if (this.GetByImageLibIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetByImageLibIDCompletedEventHandler getByImageLibIDCompletedEvent = this.GetByImageLibIDCompletedEvent;
				if (getByImageLibIDCompletedEvent != null)
				{
					getByImageLibIDCompletedEvent(this, new GetByImageLibIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageTree.GetEntity", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EImageTree GetEntity(string AImageTreeID)
		{
			object[] array = this.Invoke("GetEntity", new object[]
			{
				AImageTreeID
			});
			return (EImageTree)array[0];
		}

		public void GetEntityAsync(string AImageTreeID)
		{
			this.GetEntityAsync(AImageTreeID, null);
		}

		public void GetEntityAsync(string AImageTreeID, object userState)
		{
			if (this.GetEntityOperationCompleted == null)
			{
				this.GetEntityOperationCompleted = new SendOrPostCallback(this.OnGetEntityOperationCompleted);
			}
			this.InvokeAsync("GetEntity", new object[]
			{
				AImageTreeID
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageTree.SwapSequence", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SwapSequence(string AImageTreeID1, string AImageTreeID2, ref bool SwapSequenceResult, [XmlIgnore] ref bool SwapSequenceResultSpecified)
		{
			object[] array = this.Invoke("SwapSequence", new object[]
			{
				AImageTreeID1,
				AImageTreeID2
			});
			SwapSequenceResult = Conversions.ToBoolean(array[0]);
			SwapSequenceResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void SwapSequenceAsync(string AImageTreeID1, string AImageTreeID2)
		{
			this.SwapSequenceAsync(AImageTreeID1, AImageTreeID2, null);
		}

		public void SwapSequenceAsync(string AImageTreeID1, string AImageTreeID2, object userState)
		{
			if (this.SwapSequenceOperationCompleted == null)
			{
				this.SwapSequenceOperationCompleted = new SendOrPostCallback(this.OnSwapSequenceOperationCompleted);
			}
			this.InvokeAsync("SwapSequence", new object[]
			{
				AImageTreeID1,
				AImageTreeID2
			}, this.SwapSequenceOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSwapSequenceOperationCompleted(object arg)
		{
			if (this.SwapSequenceCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SwapSequenceCompletedEventHandler swapSequenceCompletedEvent = this.SwapSequenceCompletedEvent;
				if (swapSequenceCompletedEvent != null)
				{
					swapSequenceCompletedEvent(this, new SwapSequenceCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOImageTree.Update", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Update(EImageTree AImageTreeID)
		{
			object[] array = this.Invoke("Update", new object[]
			{
				AImageTreeID
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateAsync(EImageTree AImageTreeID)
		{
			this.UpdateAsync(AImageTreeID, null);
		}

		public void UpdateAsync(EImageTree AImageTreeID, object userState)
		{
			if (this.UpdateOperationCompleted == null)
			{
				this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
			}
			this.InvokeAsync("Update", new object[]
			{
				AImageTreeID
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
