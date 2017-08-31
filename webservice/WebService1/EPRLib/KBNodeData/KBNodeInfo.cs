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

namespace KBNodeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KBNodeInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KBNodeInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateKBNodeOperationCompleted;

		private SendOrPostCallback DeleteKBNodeOperationCompleted;

		private SendOrPostCallback GetDefaultKBNodeByLocDiagnosIDOperationCompleted;

		private SendOrPostCallback SelectKBNodeByIDOperationCompleted;

		private SendOrPostCallback SelectKBNodeByKBTreeIDOperationCompleted;

		private SendOrPostCallback SelectKBNodeByNameOperationCompleted;

		private SendOrPostCallback SelectKBNodeInUseByIDOperationCompleted;

		private SendOrPostCallback SwapSequenceOperationCompleted;

		private SendOrPostCallback UpdateKBNodeOperationCompleted;

		private SendOrPostCallback testCreateKBNodeOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateKBNodeCompletedEventHandler CreateKBNodeCompletedEvent;

		private DeleteKBNodeCompletedEventHandler DeleteKBNodeCompletedEvent;

		private GetDefaultKBNodeByLocDiagnosIDCompletedEventHandler GetDefaultKBNodeByLocDiagnosIDCompletedEvent;

		private SelectKBNodeByIDCompletedEventHandler SelectKBNodeByIDCompletedEvent;

		private SelectKBNodeByKBTreeIDCompletedEventHandler SelectKBNodeByKBTreeIDCompletedEvent;

		private SelectKBNodeByNameCompletedEventHandler SelectKBNodeByNameCompletedEvent;

		private SelectKBNodeInUseByIDCompletedEventHandler SelectKBNodeInUseByIDCompletedEvent;

		private SwapSequenceCompletedEventHandler SwapSequenceCompletedEvent;

		private UpdateKBNodeCompletedEventHandler UpdateKBNodeCompletedEvent;

		private testCreateKBNodeCompletedEventHandler testCreateKBNodeCompletedEvent;

		public event CreateKBNodeCompletedEventHandler CreateKBNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateKBNodeCompletedEvent = (CreateKBNodeCompletedEventHandler)Delegate.Combine(this.CreateKBNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateKBNodeCompletedEvent = (CreateKBNodeCompletedEventHandler)Delegate.Remove(this.CreateKBNodeCompletedEvent, value);
			}
		}

		public event DeleteKBNodeCompletedEventHandler DeleteKBNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteKBNodeCompletedEvent = (DeleteKBNodeCompletedEventHandler)Delegate.Combine(this.DeleteKBNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteKBNodeCompletedEvent = (DeleteKBNodeCompletedEventHandler)Delegate.Remove(this.DeleteKBNodeCompletedEvent, value);
			}
		}

		public event GetDefaultKBNodeByLocDiagnosIDCompletedEventHandler GetDefaultKBNodeByLocDiagnosIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent = (GetDefaultKBNodeByLocDiagnosIDCompletedEventHandler)Delegate.Combine(this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent = (GetDefaultKBNodeByLocDiagnosIDCompletedEventHandler)Delegate.Remove(this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent, value);
			}
		}

		public event SelectKBNodeByIDCompletedEventHandler SelectKBNodeByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBNodeByIDCompletedEvent = (SelectKBNodeByIDCompletedEventHandler)Delegate.Combine(this.SelectKBNodeByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBNodeByIDCompletedEvent = (SelectKBNodeByIDCompletedEventHandler)Delegate.Remove(this.SelectKBNodeByIDCompletedEvent, value);
			}
		}

		public event SelectKBNodeByKBTreeIDCompletedEventHandler SelectKBNodeByKBTreeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBNodeByKBTreeIDCompletedEvent = (SelectKBNodeByKBTreeIDCompletedEventHandler)Delegate.Combine(this.SelectKBNodeByKBTreeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBNodeByKBTreeIDCompletedEvent = (SelectKBNodeByKBTreeIDCompletedEventHandler)Delegate.Remove(this.SelectKBNodeByKBTreeIDCompletedEvent, value);
			}
		}

		public event SelectKBNodeByNameCompletedEventHandler SelectKBNodeByNameCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBNodeByNameCompletedEvent = (SelectKBNodeByNameCompletedEventHandler)Delegate.Combine(this.SelectKBNodeByNameCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBNodeByNameCompletedEvent = (SelectKBNodeByNameCompletedEventHandler)Delegate.Remove(this.SelectKBNodeByNameCompletedEvent, value);
			}
		}

		public event SelectKBNodeInUseByIDCompletedEventHandler SelectKBNodeInUseByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectKBNodeInUseByIDCompletedEvent = (SelectKBNodeInUseByIDCompletedEventHandler)Delegate.Combine(this.SelectKBNodeInUseByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectKBNodeInUseByIDCompletedEvent = (SelectKBNodeInUseByIDCompletedEventHandler)Delegate.Remove(this.SelectKBNodeInUseByIDCompletedEvent, value);
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

		public event UpdateKBNodeCompletedEventHandler UpdateKBNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateKBNodeCompletedEvent = (UpdateKBNodeCompletedEventHandler)Delegate.Combine(this.UpdateKBNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateKBNodeCompletedEvent = (UpdateKBNodeCompletedEventHandler)Delegate.Remove(this.UpdateKBNodeCompletedEvent, value);
			}
		}

		public event testCreateKBNodeCompletedEventHandler testCreateKBNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.testCreateKBNodeCompletedEvent = (testCreateKBNodeCompletedEventHandler)Delegate.Combine(this.testCreateKBNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.testCreateKBNodeCompletedEvent = (testCreateKBNodeCompletedEventHandler)Delegate.Remove(this.testCreateKBNodeCompletedEvent, value);
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

		public KBNodeInfo()
		{
			this.Url = MySettings.Default.EPRLib_KBNodeData_KBNodeInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.CreateKBNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateKBNode(EKBNode AEKBNode)
		{
			object[] array = this.Invoke("CreateKBNode", new object[]
			{
				AEKBNode
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateKBNodeAsync(EKBNode AEKBNode)
		{
			this.CreateKBNodeAsync(AEKBNode, null);
		}

		public void CreateKBNodeAsync(EKBNode AEKBNode, object userState)
		{
			if (this.CreateKBNodeOperationCompleted == null)
			{
				this.CreateKBNodeOperationCompleted = new SendOrPostCallback(this.OnCreateKBNodeOperationCompleted);
			}
			this.InvokeAsync("CreateKBNode", new object[]
			{
				AEKBNode
			}, this.CreateKBNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateKBNodeOperationCompleted(object arg)
		{
			if (this.CreateKBNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateKBNodeCompletedEventHandler createKBNodeCompletedEvent = this.CreateKBNodeCompletedEvent;
				if (createKBNodeCompletedEvent != null)
				{
					createKBNodeCompletedEvent(this, new CreateKBNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.DeleteKBNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteKBNode(string AID, ref bool DeleteKBNodeResult, [XmlIgnore] ref bool DeleteKBNodeResultSpecified)
		{
			object[] array = this.Invoke("DeleteKBNode", new object[]
			{
				AID
			});
			DeleteKBNodeResult = Conversions.ToBoolean(array[0]);
			DeleteKBNodeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteKBNodeAsync(string AID)
		{
			this.DeleteKBNodeAsync(AID, null);
		}

		public void DeleteKBNodeAsync(string AID, object userState)
		{
			if (this.DeleteKBNodeOperationCompleted == null)
			{
				this.DeleteKBNodeOperationCompleted = new SendOrPostCallback(this.OnDeleteKBNodeOperationCompleted);
			}
			this.InvokeAsync("DeleteKBNode", new object[]
			{
				AID
			}, this.DeleteKBNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteKBNodeOperationCompleted(object arg)
		{
			if (this.DeleteKBNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteKBNodeCompletedEventHandler deleteKBNodeCompletedEvent = this.DeleteKBNodeCompletedEvent;
				if (deleteKBNodeCompletedEvent != null)
				{
					deleteKBNodeCompletedEvent(this, new DeleteKBNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.GetDefaultKBNodeByLocDiagnosID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNode GetDefaultKBNodeByLocDiagnosID(string AEpisodeID, string AKBaseID)
		{
			object[] array = this.Invoke("GetDefaultKBNodeByLocDiagnosID", new object[]
			{
				AEpisodeID,
				AKBaseID
			});
			return (EKBNode)array[0];
		}

		public void GetDefaultKBNodeByLocDiagnosIDAsync(string AEpisodeID, string AKBaseID)
		{
			this.GetDefaultKBNodeByLocDiagnosIDAsync(AEpisodeID, AKBaseID, null);
		}

		public void GetDefaultKBNodeByLocDiagnosIDAsync(string AEpisodeID, string AKBaseID, object userState)
		{
			if (this.GetDefaultKBNodeByLocDiagnosIDOperationCompleted == null)
			{
				this.GetDefaultKBNodeByLocDiagnosIDOperationCompleted = new SendOrPostCallback(this.OnGetDefaultKBNodeByLocDiagnosIDOperationCompleted);
			}
			this.InvokeAsync("GetDefaultKBNodeByLocDiagnosID", new object[]
			{
				AEpisodeID,
				AKBaseID
			}, this.GetDefaultKBNodeByLocDiagnosIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDefaultKBNodeByLocDiagnosIDOperationCompleted(object arg)
		{
			if (this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDefaultKBNodeByLocDiagnosIDCompletedEventHandler getDefaultKBNodeByLocDiagnosIDCompletedEvent = this.GetDefaultKBNodeByLocDiagnosIDCompletedEvent;
				if (getDefaultKBNodeByLocDiagnosIDCompletedEvent != null)
				{
					getDefaultKBNodeByLocDiagnosIDCompletedEvent(this, new GetDefaultKBNodeByLocDiagnosIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.SelectKBNodeByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNode SelectKBNodeByID(string AID)
		{
			object[] array = this.Invoke("SelectKBNodeByID", new object[]
			{
				AID
			});
			return (EKBNode)array[0];
		}

		public void SelectKBNodeByIDAsync(string AID)
		{
			this.SelectKBNodeByIDAsync(AID, null);
		}

		public void SelectKBNodeByIDAsync(string AID, object userState)
		{
			if (this.SelectKBNodeByIDOperationCompleted == null)
			{
				this.SelectKBNodeByIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBNodeByIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBNodeByID", new object[]
			{
				AID
			}, this.SelectKBNodeByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBNodeByIDOperationCompleted(object arg)
		{
			if (this.SelectKBNodeByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBNodeByIDCompletedEventHandler selectKBNodeByIDCompletedEvent = this.SelectKBNodeByIDCompletedEvent;
				if (selectKBNodeByIDCompletedEvent != null)
				{
					selectKBNodeByIDCompletedEvent(this, new SelectKBNodeByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.SelectKBNodeByKBTreeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNodeDataset SelectKBNodeByKBTreeID(string AKBTreeID)
		{
			object[] array = this.Invoke("SelectKBNodeByKBTreeID", new object[]
			{
				AKBTreeID
			});
			return (EKBNodeDataset)array[0];
		}

		public void SelectKBNodeByKBTreeIDAsync(string AKBTreeID)
		{
			this.SelectKBNodeByKBTreeIDAsync(AKBTreeID, null);
		}

		public void SelectKBNodeByKBTreeIDAsync(string AKBTreeID, object userState)
		{
			if (this.SelectKBNodeByKBTreeIDOperationCompleted == null)
			{
				this.SelectKBNodeByKBTreeIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBNodeByKBTreeIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBNodeByKBTreeID", new object[]
			{
				AKBTreeID
			}, this.SelectKBNodeByKBTreeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBNodeByKBTreeIDOperationCompleted(object arg)
		{
			if (this.SelectKBNodeByKBTreeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBNodeByKBTreeIDCompletedEventHandler selectKBNodeByKBTreeIDCompletedEvent = this.SelectKBNodeByKBTreeIDCompletedEvent;
				if (selectKBNodeByKBTreeIDCompletedEvent != null)
				{
					selectKBNodeByKBTreeIDCompletedEvent(this, new SelectKBNodeByKBTreeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.SelectKBNodeByName", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNodeSelectByNameDataset SelectKBNodeByName(string AName, string AKnowledgeBaseID)
		{
			object[] array = this.Invoke("SelectKBNodeByName", new object[]
			{
				AName,
				AKnowledgeBaseID
			});
			return (EKBNodeSelectByNameDataset)array[0];
		}

		public void SelectKBNodeByNameAsync(string AName, string AKnowledgeBaseID)
		{
			this.SelectKBNodeByNameAsync(AName, AKnowledgeBaseID, null);
		}

		public void SelectKBNodeByNameAsync(string AName, string AKnowledgeBaseID, object userState)
		{
			if (this.SelectKBNodeByNameOperationCompleted == null)
			{
				this.SelectKBNodeByNameOperationCompleted = new SendOrPostCallback(this.OnSelectKBNodeByNameOperationCompleted);
			}
			this.InvokeAsync("SelectKBNodeByName", new object[]
			{
				AName,
				AKnowledgeBaseID
			}, this.SelectKBNodeByNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBNodeByNameOperationCompleted(object arg)
		{
			if (this.SelectKBNodeByNameCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBNodeByNameCompletedEventHandler selectKBNodeByNameCompletedEvent = this.SelectKBNodeByNameCompletedEvent;
				if (selectKBNodeByNameCompletedEvent != null)
				{
					selectKBNodeByNameCompletedEvent(this, new SelectKBNodeByNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.SelectKBNodeInUseByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNodeInUseDataset SelectKBNodeInUseByID(string AKBTreeID)
		{
			object[] array = this.Invoke("SelectKBNodeInUseByID", new object[]
			{
				AKBTreeID
			});
			return (EKBNodeInUseDataset)array[0];
		}

		public void SelectKBNodeInUseByIDAsync(string AKBTreeID)
		{
			this.SelectKBNodeInUseByIDAsync(AKBTreeID, null);
		}

		public void SelectKBNodeInUseByIDAsync(string AKBTreeID, object userState)
		{
			if (this.SelectKBNodeInUseByIDOperationCompleted == null)
			{
				this.SelectKBNodeInUseByIDOperationCompleted = new SendOrPostCallback(this.OnSelectKBNodeInUseByIDOperationCompleted);
			}
			this.InvokeAsync("SelectKBNodeInUseByID", new object[]
			{
				AKBTreeID
			}, this.SelectKBNodeInUseByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectKBNodeInUseByIDOperationCompleted(object arg)
		{
			if (this.SelectKBNodeInUseByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectKBNodeInUseByIDCompletedEventHandler selectKBNodeInUseByIDCompletedEvent = this.SelectKBNodeInUseByIDCompletedEvent;
				if (selectKBNodeInUseByIDCompletedEvent != null)
				{
					selectKBNodeInUseByIDCompletedEvent(this, new SelectKBNodeInUseByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.SwapSequence", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SwapSequence(string KBNodeID1, string KBNodeID2, ref bool SwapSequenceResult, [XmlIgnore] ref bool SwapSequenceResultSpecified)
		{
			object[] array = this.Invoke("SwapSequence", new object[]
			{
				KBNodeID1,
				KBNodeID2
			});
			SwapSequenceResult = Conversions.ToBoolean(array[0]);
			SwapSequenceResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void SwapSequenceAsync(string KBNodeID1, string KBNodeID2)
		{
			this.SwapSequenceAsync(KBNodeID1, KBNodeID2, null);
		}

		public void SwapSequenceAsync(string KBNodeID1, string KBNodeID2, object userState)
		{
			if (this.SwapSequenceOperationCompleted == null)
			{
				this.SwapSequenceOperationCompleted = new SendOrPostCallback(this.OnSwapSequenceOperationCompleted);
			}
			this.InvokeAsync("SwapSequence", new object[]
			{
				KBNodeID1,
				KBNodeID2
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.UpdateKBNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateKBNode(EKBNode AEKBNode, ref bool UpdateKBNodeResult, [XmlIgnore] ref bool UpdateKBNodeResultSpecified)
		{
			object[] array = this.Invoke("UpdateKBNode", new object[]
			{
				AEKBNode
			});
			UpdateKBNodeResult = Conversions.ToBoolean(array[0]);
			UpdateKBNodeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateKBNodeAsync(EKBNode AEKBNode)
		{
			this.UpdateKBNodeAsync(AEKBNode, null);
		}

		public void UpdateKBNodeAsync(EKBNode AEKBNode, object userState)
		{
			if (this.UpdateKBNodeOperationCompleted == null)
			{
				this.UpdateKBNodeOperationCompleted = new SendOrPostCallback(this.OnUpdateKBNodeOperationCompleted);
			}
			this.InvokeAsync("UpdateKBNode", new object[]
			{
				AEKBNode
			}, this.UpdateKBNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateKBNodeOperationCompleted(object arg)
		{
			if (this.UpdateKBNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateKBNodeCompletedEventHandler updateKBNodeCompletedEvent = this.UpdateKBNodeCompletedEvent;
				if (updateKBNodeCompletedEvent != null)
				{
					updateKBNodeCompletedEvent(this, new UpdateKBNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBNode.testCreateKBNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string testCreateKBNode(EKBNode AEKBNode)
		{
			object[] array = this.Invoke("testCreateKBNode", new object[]
			{
				AEKBNode
			});
			return Conversions.ToString(array[0]);
		}

		public void testCreateKBNodeAsync(EKBNode AEKBNode)
		{
			this.testCreateKBNodeAsync(AEKBNode, null);
		}

		public void testCreateKBNodeAsync(EKBNode AEKBNode, object userState)
		{
			if (this.testCreateKBNodeOperationCompleted == null)
			{
				this.testCreateKBNodeOperationCompleted = new SendOrPostCallback(this.OntestCreateKBNodeOperationCompleted);
			}
			this.InvokeAsync("testCreateKBNode", new object[]
			{
				AEKBNode
			}, this.testCreateKBNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OntestCreateKBNodeOperationCompleted(object arg)
		{
			if (this.testCreateKBNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				testCreateKBNodeCompletedEventHandler testCreateKBNodeCompletedEventHandler = this.testCreateKBNodeCompletedEvent;
				if (testCreateKBNodeCompletedEventHandler != null)
				{
					testCreateKBNodeCompletedEventHandler(this, new testCreateKBNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
