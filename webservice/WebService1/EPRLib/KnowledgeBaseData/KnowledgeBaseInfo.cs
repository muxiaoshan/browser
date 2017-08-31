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

namespace KnowledgeBaseData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KnowledgeBaseInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KnowledgeBaseInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateKnowledgeBaseOperationCompleted;

		private SendOrPostCallback DeleteKnowledgeBaseOperationCompleted;

		private SendOrPostCallback SelectKnowledgeBaseBYPARENTIDOperationCompleted;

		private SendOrPostCallback SelectKnowledgeBaseByIDOperationCompleted;

		private SendOrPostCallback UpdateKnowledgeBaseOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateKnowledgeBaseCompletedEventHandler CreateKnowledgeBaseCompletedEvent;

		private DeleteKnowledgeBaseCompletedEventHandler DeleteKnowledgeBaseCompletedEvent;

		private SelectKnowledgeBaseBYPARENTIDCompletedEventHandler SelectKnowledgeBaseBYPARENTIDCompletedEvent;

		private SelectKnowledgeBaseByIDCompletedEventHandler SelectKnowledgeBaseByIDCompletedEvent;

		private UpdateKnowledgeBaseCompletedEventHandler UpdateKnowledgeBaseCompletedEvent;

		public event CreateKnowledgeBaseCompletedEventHandler CreateKnowledgeBaseCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateKnowledgeBaseCompletedEvent = (CreateKnowledgeBaseCompletedEventHandler)Delegate.Combine(this.CreateKnowledgeBaseCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateKnowledgeBaseCompletedEvent = (CreateKnowledgeBaseCompletedEventHandler)Delegate.Remove(this.CreateKnowledgeBaseCompletedEvent, value);
			}
		}

		public event DeleteKnowledgeBaseCompletedEventHandler DeleteKnowledgeBaseCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteKnowledgeBaseCompletedEvent = (DeleteKnowledgeBaseCompletedEventHandler)Delegate.Combine(this.DeleteKnowledgeBaseCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteKnowledgeBaseCompletedEvent = (DeleteKnowledgeBaseCompletedEventHandler)Delegate.Remove(this.DeleteKnowledgeBaseCompletedEvent, value);
			}
		}

		public event SelectKnowledgeBaseBYPARENTIDCompletedEventHandler SelectKnowledgeBaseBYPARENTIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKnowledgeBaseBYPARENTIDCompletedEvent = (SelectKnowledgeBaseBYPARENTIDCompletedEventHandler)Delegate.Combine(this.SelectKnowledgeBaseBYPARENTIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKnowledgeBaseBYPARENTIDCompletedEvent = (SelectKnowledgeBaseBYPARENTIDCompletedEventHandler)Delegate.Remove(this.SelectKnowledgeBaseBYPARENTIDCompletedEvent, value);
			}
		}

		public event SelectKnowledgeBaseByIDCompletedEventHandler SelectKnowledgeBaseByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKnowledgeBaseByIDCompletedEvent = (SelectKnowledgeBaseByIDCompletedEventHandler)Delegate.Combine(this.SelectKnowledgeBaseByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKnowledgeBaseByIDCompletedEvent = (SelectKnowledgeBaseByIDCompletedEventHandler)Delegate.Remove(this.SelectKnowledgeBaseByIDCompletedEvent, value);
			}
		}

		public event UpdateKnowledgeBaseCompletedEventHandler UpdateKnowledgeBaseCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateKnowledgeBaseCompletedEvent = (UpdateKnowledgeBaseCompletedEventHandler)Delegate.Combine(this.UpdateKnowledgeBaseCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateKnowledgeBaseCompletedEvent = (UpdateKnowledgeBaseCompletedEventHandler)Delegate.Remove(this.UpdateKnowledgeBaseCompletedEvent, value);
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

		public KnowledgeBaseInfo()
		{
			this.Url = MySettings.Default.EPRLib_KnowledgeBaseData_KnowledgeBaseInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKnowledgeBase.CreateKnowledgeBase", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateKnowledgeBase(EKnowledgeBase AEKnowledgeBase)
		{
			object[] array = this.Invoke("CreateKnowledgeBase", new object[]
			{
				AEKnowledgeBase
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateKnowledgeBaseAsync(EKnowledgeBase AEKnowledgeBase)
		{
			this.CreateKnowledgeBaseAsync(AEKnowledgeBase, null);
		}

		public void CreateKnowledgeBaseAsync(EKnowledgeBase AEKnowledgeBase, object userState)
		{
			if (this.CreateKnowledgeBaseOperationCompleted == null)
			{
				this.CreateKnowledgeBaseOperationCompleted = new SendOrPostCallback(this.OnCreateKnowledgeBaseOperationCompleted);
			}
			this.InvokeAsync("CreateKnowledgeBase", new object[]
			{
				AEKnowledgeBase
			}, this.CreateKnowledgeBaseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateKnowledgeBaseOperationCompleted(object arg)
		{
			if (this.CreateKnowledgeBaseCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateKnowledgeBaseCompletedEventHandler createKnowledgeBaseCompletedEvent = this.CreateKnowledgeBaseCompletedEvent;
				if (createKnowledgeBaseCompletedEvent != null)
				{
					createKnowledgeBaseCompletedEvent(this, new CreateKnowledgeBaseCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKnowledgeBase.DeleteKnowledgeBase", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteKnowledgeBase(string AID, ref bool DeleteKnowledgeBaseResult, [XmlIgnore] ref bool DeleteKnowledgeBaseResultSpecified)
		{
			object[] array = this.Invoke("DeleteKnowledgeBase", new object[]
			{
				AID
			});
			DeleteKnowledgeBaseResult = Conversions.ToBoolean(array[0]);
			DeleteKnowledgeBaseResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteKnowledgeBaseAsync(string AID)
		{
			this.DeleteKnowledgeBaseAsync(AID, null);
		}

		public void DeleteKnowledgeBaseAsync(string AID, object userState)
		{
			if (this.DeleteKnowledgeBaseOperationCompleted == null)
			{
				this.DeleteKnowledgeBaseOperationCompleted = new SendOrPostCallback(this.OnDeleteKnowledgeBaseOperationCompleted);
			}
			this.InvokeAsync("DeleteKnowledgeBase", new object[]
			{
				AID
			}, this.DeleteKnowledgeBaseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteKnowledgeBaseOperationCompleted(object arg)
		{
			if (this.DeleteKnowledgeBaseCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteKnowledgeBaseCompletedEventHandler deleteKnowledgeBaseCompletedEvent = this.DeleteKnowledgeBaseCompletedEvent;
				if (deleteKnowledgeBaseCompletedEvent != null)
				{
					deleteKnowledgeBaseCompletedEvent(this, new DeleteKnowledgeBaseCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKnowledgeBase.SelectKnowledgeBaseBYPARENTID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKnowledgeBaseDataset SelectKnowledgeBaseBYPARENTID(string ACATEID)
		{
			object[] array = this.Invoke("SelectKnowledgeBaseBYPARENTID", new object[]
			{
				ACATEID
			});
			return (EKnowledgeBaseDataset)array[0];
		}

		public void SelectKnowledgeBaseBYPARENTIDAsync(string ACATEID)
		{
			this.SelectKnowledgeBaseBYPARENTIDAsync(ACATEID, null);
		}

		public void SelectKnowledgeBaseBYPARENTIDAsync(string ACATEID, object userState)
		{
			if (this.SelectKnowledgeBaseBYPARENTIDOperationCompleted == null)
			{
				this.SelectKnowledgeBaseBYPARENTIDOperationCompleted = new SendOrPostCallback(this.OnSelectKnowledgeBaseBYPARENTIDOperationCompleted);
			}
			this.InvokeAsync("SelectKnowledgeBaseBYPARENTID", new object[]
			{
				ACATEID
			}, this.SelectKnowledgeBaseBYPARENTIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKnowledgeBaseBYPARENTIDOperationCompleted(object arg)
		{
			if (this.SelectKnowledgeBaseBYPARENTIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKnowledgeBaseBYPARENTIDCompletedEventHandler selectKnowledgeBaseBYPARENTIDCompletedEvent = this.SelectKnowledgeBaseBYPARENTIDCompletedEvent;
				if (selectKnowledgeBaseBYPARENTIDCompletedEvent != null)
				{
					selectKnowledgeBaseBYPARENTIDCompletedEvent(this, new SelectKnowledgeBaseBYPARENTIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKnowledgeBase.SelectKnowledgeBaseByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKnowledgeBase SelectKnowledgeBaseByID(string AID)
		{
			object[] array = this.Invoke("SelectKnowledgeBaseByID", new object[]
			{
				AID
			});
			return (EKnowledgeBase)array[0];
		}

		public void SelectKnowledgeBaseByIDAsync(string AID)
		{
			this.SelectKnowledgeBaseByIDAsync(AID, null);
		}

		public void SelectKnowledgeBaseByIDAsync(string AID, object userState)
		{
			if (this.SelectKnowledgeBaseByIDOperationCompleted == null)
			{
				this.SelectKnowledgeBaseByIDOperationCompleted = new SendOrPostCallback(this.OnSelectKnowledgeBaseByIDOperationCompleted);
			}
			this.InvokeAsync("SelectKnowledgeBaseByID", new object[]
			{
				AID
			}, this.SelectKnowledgeBaseByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKnowledgeBaseByIDOperationCompleted(object arg)
		{
			if (this.SelectKnowledgeBaseByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKnowledgeBaseByIDCompletedEventHandler selectKnowledgeBaseByIDCompletedEvent = this.SelectKnowledgeBaseByIDCompletedEvent;
				if (selectKnowledgeBaseByIDCompletedEvent != null)
				{
					selectKnowledgeBaseByIDCompletedEvent(this, new SelectKnowledgeBaseByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKnowledgeBase.UpdateKnowledgeBase", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateKnowledgeBase(EKnowledgeBase AEKnowledgeBase, ref bool UpdateKnowledgeBaseResult, [XmlIgnore] ref bool UpdateKnowledgeBaseResultSpecified)
		{
			object[] array = this.Invoke("UpdateKnowledgeBase", new object[]
			{
				AEKnowledgeBase
			});
			UpdateKnowledgeBaseResult = Conversions.ToBoolean(array[0]);
			UpdateKnowledgeBaseResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateKnowledgeBaseAsync(EKnowledgeBase AEKnowledgeBase)
		{
			this.UpdateKnowledgeBaseAsync(AEKnowledgeBase, null);
		}

		public void UpdateKnowledgeBaseAsync(EKnowledgeBase AEKnowledgeBase, object userState)
		{
			if (this.UpdateKnowledgeBaseOperationCompleted == null)
			{
				this.UpdateKnowledgeBaseOperationCompleted = new SendOrPostCallback(this.OnUpdateKnowledgeBaseOperationCompleted);
			}
			this.InvokeAsync("UpdateKnowledgeBase", new object[]
			{
				AEKnowledgeBase
			}, this.UpdateKnowledgeBaseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateKnowledgeBaseOperationCompleted(object arg)
		{
			if (this.UpdateKnowledgeBaseCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateKnowledgeBaseCompletedEventHandler updateKnowledgeBaseCompletedEvent = this.UpdateKnowledgeBaseCompletedEvent;
				if (updateKnowledgeBaseCompletedEvent != null)
				{
					updateKnowledgeBaseCompletedEvent(this, new UpdateKnowledgeBaseCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
