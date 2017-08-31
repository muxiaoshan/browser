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

namespace BOEPRDiagnosConfig
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "DiagnosConfigSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class DiagnosConfig : SoapHttpClientProtocol
	{
		private SendOrPostCallback DeleteOperationCompleted;

		private SendOrPostCallback GetDataByTreeIDOperationCompleted;

		private SendOrPostCallback GetDiagnosByNodeIDOperationCompleted;

		private SendOrPostCallback GetKBNodeDiagnosByIDOperationCompleted;

		private SendOrPostCallback GetKBNodeDiagnosWithRulesOperationCompleted;

		private SendOrPostCallback InsertNodeOperationCompleted;

		private SendOrPostCallback SaveBindDiagnosOperationCompleted;

		private SendOrPostCallback SaveKBNodeDiagnosOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private DeleteCompletedEventHandler DeleteCompletedEvent;

		private GetDataByTreeIDCompletedEventHandler GetDataByTreeIDCompletedEvent;

		private GetDiagnosByNodeIDCompletedEventHandler GetDiagnosByNodeIDCompletedEvent;

		private GetKBNodeDiagnosByIDCompletedEventHandler GetKBNodeDiagnosByIDCompletedEvent;

		private GetKBNodeDiagnosWithRulesCompletedEventHandler GetKBNodeDiagnosWithRulesCompletedEvent;

		private InsertNodeCompletedEventHandler InsertNodeCompletedEvent;

		private SaveBindDiagnosCompletedEventHandler SaveBindDiagnosCompletedEvent;

		private SaveKBNodeDiagnosCompletedEventHandler SaveKBNodeDiagnosCompletedEvent;

		public event DeleteCompletedEventHandler DeleteCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteCompletedEvent = (DeleteCompletedEventHandler)Delegate.Combine(this.DeleteCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteCompletedEvent = (DeleteCompletedEventHandler)Delegate.Remove(this.DeleteCompletedEvent, value);
			}
		}

		public event GetDataByTreeIDCompletedEventHandler GetDataByTreeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDataByTreeIDCompletedEvent = (GetDataByTreeIDCompletedEventHandler)Delegate.Combine(this.GetDataByTreeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDataByTreeIDCompletedEvent = (GetDataByTreeIDCompletedEventHandler)Delegate.Remove(this.GetDataByTreeIDCompletedEvent, value);
			}
		}

		public event GetDiagnosByNodeIDCompletedEventHandler GetDiagnosByNodeIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDiagnosByNodeIDCompletedEvent = (GetDiagnosByNodeIDCompletedEventHandler)Delegate.Combine(this.GetDiagnosByNodeIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDiagnosByNodeIDCompletedEvent = (GetDiagnosByNodeIDCompletedEventHandler)Delegate.Remove(this.GetDiagnosByNodeIDCompletedEvent, value);
			}
		}

		public event GetKBNodeDiagnosByIDCompletedEventHandler GetKBNodeDiagnosByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetKBNodeDiagnosByIDCompletedEvent = (GetKBNodeDiagnosByIDCompletedEventHandler)Delegate.Combine(this.GetKBNodeDiagnosByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetKBNodeDiagnosByIDCompletedEvent = (GetKBNodeDiagnosByIDCompletedEventHandler)Delegate.Remove(this.GetKBNodeDiagnosByIDCompletedEvent, value);
			}
		}

		public event GetKBNodeDiagnosWithRulesCompletedEventHandler GetKBNodeDiagnosWithRulesCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetKBNodeDiagnosWithRulesCompletedEvent = (GetKBNodeDiagnosWithRulesCompletedEventHandler)Delegate.Combine(this.GetKBNodeDiagnosWithRulesCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetKBNodeDiagnosWithRulesCompletedEvent = (GetKBNodeDiagnosWithRulesCompletedEventHandler)Delegate.Remove(this.GetKBNodeDiagnosWithRulesCompletedEvent, value);
			}
		}

		public event InsertNodeCompletedEventHandler InsertNodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.InsertNodeCompletedEvent = (InsertNodeCompletedEventHandler)Delegate.Combine(this.InsertNodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.InsertNodeCompletedEvent = (InsertNodeCompletedEventHandler)Delegate.Remove(this.InsertNodeCompletedEvent, value);
			}
		}

		public event SaveBindDiagnosCompletedEventHandler SaveBindDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveBindDiagnosCompletedEvent = (SaveBindDiagnosCompletedEventHandler)Delegate.Combine(this.SaveBindDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveBindDiagnosCompletedEvent = (SaveBindDiagnosCompletedEventHandler)Delegate.Remove(this.SaveBindDiagnosCompletedEvent, value);
			}
		}

		public event SaveKBNodeDiagnosCompletedEventHandler SaveKBNodeDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SaveKBNodeDiagnosCompletedEvent = (SaveKBNodeDiagnosCompletedEventHandler)Delegate.Combine(this.SaveKBNodeDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SaveKBNodeDiagnosCompletedEvent = (SaveKBNodeDiagnosCompletedEventHandler)Delegate.Remove(this.SaveKBNodeDiagnosCompletedEvent, value);
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

		public DiagnosConfig()
		{
			this.Url = MySettings.Default.EPRLib_BOEPRDiagnosConfig_DiagnosConfig;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.Delete", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Delete(string RowID)
		{
			object[] array = this.Invoke("Delete", new object[]
			{
				RowID
			});
			return Conversions.ToString(array[0]);
		}

		public void DeleteAsync(string RowID)
		{
			this.DeleteAsync(RowID, null);
		}

		public void DeleteAsync(string RowID, object userState)
		{
			if (this.DeleteOperationCompleted == null)
			{
				this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
			}
			this.InvokeAsync("Delete", new object[]
			{
				RowID
			}, this.DeleteOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteOperationCompleted(object arg)
		{
			if (this.DeleteCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteCompletedEventHandler deleteCompletedEvent = this.DeleteCompletedEvent;
				if (deleteCompletedEvent != null)
				{
					deleteCompletedEvent(this, new DeleteCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.GetDataByTreeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBDiagnosConfigDataSet GetDataByTreeID(string TreeID, string DiagnosID, string EpisodeID)
		{
			object[] array = this.Invoke("GetDataByTreeID", new object[]
			{
				TreeID,
				DiagnosID,
				EpisodeID
			});
			return (EKBDiagnosConfigDataSet)array[0];
		}

		public void GetDataByTreeIDAsync(string TreeID, string DiagnosID, string EpisodeID)
		{
			this.GetDataByTreeIDAsync(TreeID, DiagnosID, EpisodeID, null);
		}

		public void GetDataByTreeIDAsync(string TreeID, string DiagnosID, string EpisodeID, object userState)
		{
			if (this.GetDataByTreeIDOperationCompleted == null)
			{
				this.GetDataByTreeIDOperationCompleted = new SendOrPostCallback(this.OnGetDataByTreeIDOperationCompleted);
			}
			this.InvokeAsync("GetDataByTreeID", new object[]
			{
				TreeID,
				DiagnosID,
				EpisodeID
			}, this.GetDataByTreeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDataByTreeIDOperationCompleted(object arg)
		{
			if (this.GetDataByTreeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDataByTreeIDCompletedEventHandler getDataByTreeIDCompletedEvent = this.GetDataByTreeIDCompletedEvent;
				if (getDataByTreeIDCompletedEvent != null)
				{
					getDataByTreeIDCompletedEvent(this, new GetDataByTreeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.GetDiagnosByNodeID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetDiagnosByNodeID(string NodeID)
		{
			object[] array = this.Invoke("GetDiagnosByNodeID", new object[]
			{
				NodeID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetDiagnosByNodeIDAsync(string NodeID)
		{
			this.GetDiagnosByNodeIDAsync(NodeID, null);
		}

		public void GetDiagnosByNodeIDAsync(string NodeID, object userState)
		{
			if (this.GetDiagnosByNodeIDOperationCompleted == null)
			{
				this.GetDiagnosByNodeIDOperationCompleted = new SendOrPostCallback(this.OnGetDiagnosByNodeIDOperationCompleted);
			}
			this.InvokeAsync("GetDiagnosByNodeID", new object[]
			{
				NodeID
			}, this.GetDiagnosByNodeIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDiagnosByNodeIDOperationCompleted(object arg)
		{
			if (this.GetDiagnosByNodeIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDiagnosByNodeIDCompletedEventHandler getDiagnosByNodeIDCompletedEvent = this.GetDiagnosByNodeIDCompletedEvent;
				if (getDiagnosByNodeIDCompletedEvent != null)
				{
					getDiagnosByNodeIDCompletedEvent(this, new GetDiagnosByNodeIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.GetKBNodeDiagnosByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBNodeDiagnos GetKBNodeDiagnosByID(string ARowID)
		{
			object[] array = this.Invoke("GetKBNodeDiagnosByID", new object[]
			{
				ARowID
			});
			return (EKBNodeDiagnos)array[0];
		}

		public void GetKBNodeDiagnosByIDAsync(string ARowID)
		{
			this.GetKBNodeDiagnosByIDAsync(ARowID, null);
		}

		public void GetKBNodeDiagnosByIDAsync(string ARowID, object userState)
		{
			if (this.GetKBNodeDiagnosByIDOperationCompleted == null)
			{
				this.GetKBNodeDiagnosByIDOperationCompleted = new SendOrPostCallback(this.OnGetKBNodeDiagnosByIDOperationCompleted);
			}
			this.InvokeAsync("GetKBNodeDiagnosByID", new object[]
			{
				ARowID
			}, this.GetKBNodeDiagnosByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetKBNodeDiagnosByIDOperationCompleted(object arg)
		{
			if (this.GetKBNodeDiagnosByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetKBNodeDiagnosByIDCompletedEventHandler getKBNodeDiagnosByIDCompletedEvent = this.GetKBNodeDiagnosByIDCompletedEvent;
				if (getKBNodeDiagnosByIDCompletedEvent != null)
				{
					getKBNodeDiagnosByIDCompletedEvent(this, new GetKBNodeDiagnosByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.GetKBNodeDiagnosWithRules", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetKBNodeDiagnosWithRules(string AKBNodeID)
		{
			object[] array = this.Invoke("GetKBNodeDiagnosWithRules", new object[]
			{
				AKBNodeID
			});
			return Conversions.ToString(array[0]);
		}

		public void GetKBNodeDiagnosWithRulesAsync(string AKBNodeID)
		{
			this.GetKBNodeDiagnosWithRulesAsync(AKBNodeID, null);
		}

		public void GetKBNodeDiagnosWithRulesAsync(string AKBNodeID, object userState)
		{
			if (this.GetKBNodeDiagnosWithRulesOperationCompleted == null)
			{
				this.GetKBNodeDiagnosWithRulesOperationCompleted = new SendOrPostCallback(this.OnGetKBNodeDiagnosWithRulesOperationCompleted);
			}
			this.InvokeAsync("GetKBNodeDiagnosWithRules", new object[]
			{
				AKBNodeID
			}, this.GetKBNodeDiagnosWithRulesOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetKBNodeDiagnosWithRulesOperationCompleted(object arg)
		{
			if (this.GetKBNodeDiagnosWithRulesCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetKBNodeDiagnosWithRulesCompletedEventHandler getKBNodeDiagnosWithRulesCompletedEvent = this.GetKBNodeDiagnosWithRulesCompletedEvent;
				if (getKBNodeDiagnosWithRulesCompletedEvent != null)
				{
					getKBNodeDiagnosWithRulesCompletedEvent(this, new GetKBNodeDiagnosWithRulesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.InsertNode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string InsertNode(string KBNodeID, string KBDiagnosID, string KBTreeID)
		{
			object[] array = this.Invoke("InsertNode", new object[]
			{
				KBNodeID,
				KBDiagnosID,
				KBTreeID
			});
			return Conversions.ToString(array[0]);
		}

		public void InsertNodeAsync(string KBNodeID, string KBDiagnosID, string KBTreeID)
		{
			this.InsertNodeAsync(KBNodeID, KBDiagnosID, KBTreeID, null);
		}

		public void InsertNodeAsync(string KBNodeID, string KBDiagnosID, string KBTreeID, object userState)
		{
			if (this.InsertNodeOperationCompleted == null)
			{
				this.InsertNodeOperationCompleted = new SendOrPostCallback(this.OnInsertNodeOperationCompleted);
			}
			this.InvokeAsync("InsertNode", new object[]
			{
				KBNodeID,
				KBDiagnosID,
				KBTreeID
			}, this.InsertNodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnInsertNodeOperationCompleted(object arg)
		{
			if (this.InsertNodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				InsertNodeCompletedEventHandler insertNodeCompletedEvent = this.InsertNodeCompletedEvent;
				if (insertNodeCompletedEvent != null)
				{
					insertNodeCompletedEvent(this, new InsertNodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.SaveBindDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SaveBindDiagnos(string KBNodeID, string KBDiagnosID, string KBTreeID)
		{
			this.Invoke("SaveBindDiagnos", new object[]
			{
				KBNodeID,
				KBDiagnosID,
				KBTreeID
			});
		}

		public void SaveBindDiagnosAsync(string KBNodeID, string KBDiagnosID, string KBTreeID)
		{
			this.SaveBindDiagnosAsync(KBNodeID, KBDiagnosID, KBTreeID, null);
		}

		public void SaveBindDiagnosAsync(string KBNodeID, string KBDiagnosID, string KBTreeID, object userState)
		{
			if (this.SaveBindDiagnosOperationCompleted == null)
			{
				this.SaveBindDiagnosOperationCompleted = new SendOrPostCallback(this.OnSaveBindDiagnosOperationCompleted);
			}
			this.InvokeAsync("SaveBindDiagnos", new object[]
			{
				KBNodeID,
				KBDiagnosID,
				KBTreeID
			}, this.SaveBindDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveBindDiagnosOperationCompleted(object arg)
		{
			if (this.SaveBindDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveBindDiagnosCompletedEventHandler saveBindDiagnosCompletedEvent = this.SaveBindDiagnosCompletedEvent;
				if (saveBindDiagnosCompletedEvent != null)
				{
					saveBindDiagnosCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOEPRDiagnosConfig.SaveKBNodeDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void SaveKBNodeDiagnos(string AKBNodeID, string AKBTreeID, string ADiagnosIDs)
		{
			this.Invoke("SaveKBNodeDiagnos", new object[]
			{
				AKBNodeID,
				AKBTreeID,
				ADiagnosIDs
			});
		}

		public void SaveKBNodeDiagnosAsync(string AKBNodeID, string AKBTreeID, string ADiagnosIDs)
		{
			this.SaveKBNodeDiagnosAsync(AKBNodeID, AKBTreeID, ADiagnosIDs, null);
		}

		public void SaveKBNodeDiagnosAsync(string AKBNodeID, string AKBTreeID, string ADiagnosIDs, object userState)
		{
			if (this.SaveKBNodeDiagnosOperationCompleted == null)
			{
				this.SaveKBNodeDiagnosOperationCompleted = new SendOrPostCallback(this.OnSaveKBNodeDiagnosOperationCompleted);
			}
			this.InvokeAsync("SaveKBNodeDiagnos", new object[]
			{
				AKBNodeID,
				AKBTreeID,
				ADiagnosIDs
			}, this.SaveKBNodeDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSaveKBNodeDiagnosOperationCompleted(object arg)
		{
			if (this.SaveKBNodeDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SaveKBNodeDiagnosCompletedEventHandler saveKBNodeDiagnosCompletedEvent = this.SaveKBNodeDiagnosCompletedEvent;
				if (saveKBNodeDiagnosCompletedEvent != null)
				{
					saveKBNodeDiagnosCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
