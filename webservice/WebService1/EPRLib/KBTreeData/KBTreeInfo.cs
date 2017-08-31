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

namespace KBTreeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KBTreeInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KBTreeInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateKBTreeOperationCompleted;

		private SendOrPostCallback DeleteKBTreeOperationCompleted;

		private SendOrPostCallback DeleteTreeNodeOperationCompleted;

		private SendOrPostCallback SelectALLKBTreeOperationCompleted;

		private SendOrPostCallback SelectKBTreeBYIDOperationCompleted;

		private SendOrPostCallback SelectKBTreeBYPARENTIDOperationCompleted;

		private SendOrPostCallback SwapSequenceOperationCompleted;

		private SendOrPostCallback UpdateKBTreeOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateKBTreeCompletedEventHandler CreateKBTreeCompletedEvent;

		private DeleteKBTreeCompletedEventHandler DeleteKBTreeCompletedEvent;

		private DeleteTreeNodeCompletedEventHandler DeleteTreeNodeCompletedEvent;

		private SelectALLKBTreeCompletedEventHandler SelectALLKBTreeCompletedEvent;

		private SelectKBTreeBYIDCompletedEventHandler SelectKBTreeBYIDCompletedEvent;

		private SelectKBTreeBYPARENTIDCompletedEventHandler SelectKBTreeBYPARENTIDCompletedEvent;

		private SwapSequenceCompletedEventHandler SwapSequenceCompletedEvent;

		private UpdateKBTreeCompletedEventHandler UpdateKBTreeCompletedEvent;

		public event CreateKBTreeCompletedEventHandler CreateKBTreeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateKBTreeCompletedEvent = (CreateKBTreeCompletedEventHandler)Delegate.Combine(this.CreateKBTreeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateKBTreeCompletedEvent = (CreateKBTreeCompletedEventHandler)Delegate.Remove(this.CreateKBTreeCompletedEvent, value);
			}
		}

		public event DeleteKBTreeCompletedEventHandler DeleteKBTreeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteKBTreeCompletedEvent = (DeleteKBTreeCompletedEventHandler)Delegate.Combine(this.DeleteKBTreeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteKBTreeCompletedEvent = (DeleteKBTreeCompletedEventHandler)Delegate.Remove(this.DeleteKBTreeCompletedEvent, value);
			}
		}

		public event DeleteTreeNodeCompletedEventHandler DeleteTreeNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteTreeNodeCompletedEvent = (DeleteTreeNodeCompletedEventHandler)Delegate.Combine(this.DeleteTreeNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteTreeNodeCompletedEvent = (DeleteTreeNodeCompletedEventHandler)Delegate.Remove(this.DeleteTreeNodeCompletedEvent, value);
			}
		}

		public event SelectALLKBTreeCompletedEventHandler SelectALLKBTreeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectALLKBTreeCompletedEvent = (SelectALLKBTreeCompletedEventHandler)Delegate.Combine(this.SelectALLKBTreeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectALLKBTreeCompletedEvent = (SelectALLKBTreeCompletedEventHandler)Delegate.Remove(this.SelectALLKBTreeCompletedEvent, value);
			}
		}

		public event SelectKBTreeBYIDCompletedEventHandler SelectKBTreeBYIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBTreeBYIDCompletedEvent = (SelectKBTreeBYIDCompletedEventHandler)Delegate.Combine(this.SelectKBTreeBYIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBTreeBYIDCompletedEvent = (SelectKBTreeBYIDCompletedEventHandler)Delegate.Remove(this.SelectKBTreeBYIDCompletedEvent, value);
			}
		}

		public event SelectKBTreeBYPARENTIDCompletedEventHandler SelectKBTreeBYPARENTIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBTreeBYPARENTIDCompletedEvent = (SelectKBTreeBYPARENTIDCompletedEventHandler)Delegate.Combine(this.SelectKBTreeBYPARENTIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBTreeBYPARENTIDCompletedEvent = (SelectKBTreeBYPARENTIDCompletedEventHandler)Delegate.Remove(this.SelectKBTreeBYPARENTIDCompletedEvent, value);
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

		public event UpdateKBTreeCompletedEventHandler UpdateKBTreeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateKBTreeCompletedEvent = (UpdateKBTreeCompletedEventHandler)Delegate.Combine(this.UpdateKBTreeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateKBTreeCompletedEvent = (UpdateKBTreeCompletedEventHandler)Delegate.Remove(this.UpdateKBTreeCompletedEvent, value);
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

		public KBTreeInfo()
		{
			this.Url = MySettings.Default.EPRLib_KBTreeData_KBTreeInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.CreateKBTree", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateKBTree(EKBTree AEKBTree)
		{
			object[] array = this.Invoke("CreateKBTree", new object[]
			{
				AEKBTree
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateKBTreeAsync(EKBTree AEKBTree)
		{
			this.CreateKBTreeAsync(AEKBTree, null);
		}

		public void CreateKBTreeAsync(EKBTree AEKBTree, object userState)
		{
			if (this.CreateKBTreeOperationCompleted == null)
			{
				this.CreateKBTreeOperationCompleted = new SendOrPostCallback(this.OnCreateKBTreeOperationCompleted);
			}
			this.InvokeAsync("CreateKBTree", new object[]
			{
				AEKBTree
			}, this.CreateKBTreeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateKBTreeOperationCompleted(object arg)
		{
			if (this.CreateKBTreeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateKBTreeCompletedEventHandler createKBTreeCompletedEvent = this.CreateKBTreeCompletedEvent;
				if (createKBTreeCompletedEvent != null)
				{
					createKBTreeCompletedEvent(this, new CreateKBTreeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.DeleteKBTree", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteKBTree(string AID, ref bool DeleteKBTreeResult, [XmlIgnore] ref bool DeleteKBTreeResultSpecified)
		{
			object[] array = this.Invoke("DeleteKBTree", new object[]
			{
				AID
			});
			DeleteKBTreeResult = Conversions.ToBoolean(array[0]);
			DeleteKBTreeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteKBTreeAsync(string AID)
		{
			this.DeleteKBTreeAsync(AID, null);
		}

		public void DeleteKBTreeAsync(string AID, object userState)
		{
			if (this.DeleteKBTreeOperationCompleted == null)
			{
				this.DeleteKBTreeOperationCompleted = new SendOrPostCallback(this.OnDeleteKBTreeOperationCompleted);
			}
			this.InvokeAsync("DeleteKBTree", new object[]
			{
				AID
			}, this.DeleteKBTreeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteKBTreeOperationCompleted(object arg)
		{
			if (this.DeleteKBTreeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteKBTreeCompletedEventHandler deleteKBTreeCompletedEvent = this.DeleteKBTreeCompletedEvent;
				if (deleteKBTreeCompletedEvent != null)
				{
					deleteKBTreeCompletedEvent(this, new DeleteKBTreeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.DeleteTreeNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string DeleteTreeNode(string AID, string AType)
		{
			object[] array = this.Invoke("DeleteTreeNode", new object[]
			{
				AID,
				AType
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteTreeNodeAsync(string AID, string AType)
		{
			this.DeleteTreeNodeAsync(AID, AType, null);
		}

		public void DeleteTreeNodeAsync(string AID, string AType, object userState)
		{
			if (this.DeleteTreeNodeOperationCompleted == null)
			{
				this.DeleteTreeNodeOperationCompleted = new SendOrPostCallback(this.OnDeleteTreeNodeOperationCompleted);
			}
			this.InvokeAsync("DeleteTreeNode", new object[]
			{
				AID,
				AType
			}, this.DeleteTreeNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteTreeNodeOperationCompleted(object arg)
		{
			if (this.DeleteTreeNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteTreeNodeCompletedEventHandler deleteTreeNodeCompletedEvent = this.DeleteTreeNodeCompletedEvent;
				if (deleteTreeNodeCompletedEvent != null)
				{
					deleteTreeNodeCompletedEvent(this, new DeleteTreeNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.SelectALLKBTree", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBTreeAllDataset SelectALLKBTree(string AKnowlodgeBase)
		{
			object[] array = this.Invoke("SelectALLKBTree", new object[]
			{
				AKnowlodgeBase
			});
			return (EKBTreeAllDataset)array[0];
		}

		public void SelectALLKBTreeAsync(string AKnowlodgeBase)
		{
			this.SelectALLKBTreeAsync(AKnowlodgeBase, null);
		}

		public void SelectALLKBTreeAsync(string AKnowlodgeBase, object userState)
		{
			if (this.SelectALLKBTreeOperationCompleted == null)
			{
				this.SelectALLKBTreeOperationCompleted = new SendOrPostCallback(this.OnSelectALLKBTreeOperationCompleted);
			}
			this.InvokeAsync("SelectALLKBTree", new object[]
			{
				AKnowlodgeBase
			}, this.SelectALLKBTreeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectALLKBTreeOperationCompleted(object arg)
		{
			if (this.SelectALLKBTreeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectALLKBTreeCompletedEventHandler selectALLKBTreeCompletedEvent = this.SelectALLKBTreeCompletedEvent;
				if (selectALLKBTreeCompletedEvent != null)
				{
					selectALLKBTreeCompletedEvent(this, new SelectALLKBTreeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.SelectKBTreeBYID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBTree SelectKBTreeBYID(string AID)
		{
			object[] array = this.Invoke("SelectKBTreeBYID", new object[]
			{
				AID
			});
			return (EKBTree)array[0];
		}

		public void SelectKBTreeBYIDAsync(string AID)
		{
			this.SelectKBTreeBYIDAsync(AID, null);
		}

		public void SelectKBTreeBYIDAsync(string AID, object userState)
		{
			if (this.SelectKBTreeBYIDOperationCompleted == null)
			{
				this.SelectKBTreeBYIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBTreeBYIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBTreeBYID", new object[]
			{
				AID
			}, this.SelectKBTreeBYIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBTreeBYIDOperationCompleted(object arg)
		{
			if (this.SelectKBTreeBYIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBTreeBYIDCompletedEventHandler selectKBTreeBYIDCompletedEvent = this.SelectKBTreeBYIDCompletedEvent;
				if (selectKBTreeBYIDCompletedEvent != null)
				{
					selectKBTreeBYIDCompletedEvent(this, new SelectKBTreeBYIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.SelectKBTreeBYPARENTID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBTreeDataset SelectKBTreeBYPARENTID(string APARENTID)
		{
			object[] array = this.Invoke("SelectKBTreeBYPARENTID", new object[]
			{
				APARENTID
			});
			return (EKBTreeDataset)array[0];
		}

		public void SelectKBTreeBYPARENTIDAsync(string APARENTID)
		{
			this.SelectKBTreeBYPARENTIDAsync(APARENTID, null);
		}

		public void SelectKBTreeBYPARENTIDAsync(string APARENTID, object userState)
		{
			if (this.SelectKBTreeBYPARENTIDOperationCompleted == null)
			{
				this.SelectKBTreeBYPARENTIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBTreeBYPARENTIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBTreeBYPARENTID", new object[]
			{
				APARENTID
			}, this.SelectKBTreeBYPARENTIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBTreeBYPARENTIDOperationCompleted(object arg)
		{
			if (this.SelectKBTreeBYPARENTIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBTreeBYPARENTIDCompletedEventHandler selectKBTreeBYPARENTIDCompletedEvent = this.SelectKBTreeBYPARENTIDCompletedEvent;
				if (selectKBTreeBYPARENTIDCompletedEvent != null)
				{
					selectKBTreeBYPARENTIDCompletedEvent(this, new SelectKBTreeBYPARENTIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.SwapSequence", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SwapSequence(string KBtreeID1, string KBtreeID2, ref bool SwapSequenceResult, [XmlIgnore] ref bool SwapSequenceResultSpecified)
		{
			object[] array = this.Invoke("SwapSequence", new object[]
			{
				KBtreeID1,
				KBtreeID2
			});
			SwapSequenceResult = Conversions.ToBoolean(array[0]);
			SwapSequenceResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void SwapSequenceAsync(string KBtreeID1, string KBtreeID2)
		{
			this.SwapSequenceAsync(KBtreeID1, KBtreeID2, null);
		}

		public void SwapSequenceAsync(string KBtreeID1, string KBtreeID2, object userState)
		{
			if (this.SwapSequenceOperationCompleted == null)
			{
				this.SwapSequenceOperationCompleted = new SendOrPostCallback(this.OnSwapSequenceOperationCompleted);
			}
			this.InvokeAsync("SwapSequence", new object[]
			{
				KBtreeID1,
				KBtreeID2
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBTree.UpdateKBTree", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateKBTree(EKBTree AEKBTree, ref bool UpdateKBTreeResult, [XmlIgnore] ref bool UpdateKBTreeResultSpecified)
		{
			object[] array = this.Invoke("UpdateKBTree", new object[]
			{
				AEKBTree
			});
			UpdateKBTreeResult = Conversions.ToBoolean(array[0]);
			UpdateKBTreeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateKBTreeAsync(EKBTree AEKBTree)
		{
			this.UpdateKBTreeAsync(AEKBTree, null);
		}

		public void UpdateKBTreeAsync(EKBTree AEKBTree, object userState)
		{
			if (this.UpdateKBTreeOperationCompleted == null)
			{
				this.UpdateKBTreeOperationCompleted = new SendOrPostCallback(this.OnUpdateKBTreeOperationCompleted);
			}
			this.InvokeAsync("UpdateKBTree", new object[]
			{
				AEKBTree
			}, this.UpdateKBTreeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateKBTreeOperationCompleted(object arg)
		{
			if (this.UpdateKBTreeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateKBTreeCompletedEventHandler updateKBTreeCompletedEvent = this.UpdateKBTreeCompletedEvent;
				if (updateKBTreeCompletedEvent != null)
				{
					updateKBTreeCompletedEvent(this, new UpdateKBTreeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
