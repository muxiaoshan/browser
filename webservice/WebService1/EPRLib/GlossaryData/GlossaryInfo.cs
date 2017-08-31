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

namespace GlossaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "GlossaryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class GlossaryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CheckInternalIDOperationCompleted;

		private SendOrPostCallback CreateGlossaryOperationCompleted;

		private SendOrPostCallback DeleteGlossaryOperationCompleted;

		private SendOrPostCallback GetSubGlossariesByParentIDOperationCompleted;

		private SendOrPostCallback SelectAllGlossaryByCategoryIDOperationCompleted;

		private SendOrPostCallback SelectGlossaryByIdOperationCompleted;

		private SendOrPostCallback UpdateGlossaryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CheckInternalIDCompletedEventHandler CheckInternalIDCompletedEvent;

		private CreateGlossaryCompletedEventHandler CreateGlossaryCompletedEvent;

		private DeleteGlossaryCompletedEventHandler DeleteGlossaryCompletedEvent;

		private GetSubGlossariesByParentIDCompletedEventHandler GetSubGlossariesByParentIDCompletedEvent;

		private SelectAllGlossaryByCategoryIDCompletedEventHandler SelectAllGlossaryByCategoryIDCompletedEvent;

		private SelectGlossaryByIdCompletedEventHandler SelectGlossaryByIdCompletedEvent;

		private UpdateGlossaryCompletedEventHandler UpdateGlossaryCompletedEvent;

		public event CheckInternalIDCompletedEventHandler CheckInternalIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CheckInternalIDCompletedEvent = (CheckInternalIDCompletedEventHandler)Delegate.Combine(this.CheckInternalIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CheckInternalIDCompletedEvent = (CheckInternalIDCompletedEventHandler)Delegate.Remove(this.CheckInternalIDCompletedEvent, value);
			}
		}

		public event CreateGlossaryCompletedEventHandler CreateGlossaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateGlossaryCompletedEvent = (CreateGlossaryCompletedEventHandler)Delegate.Combine(this.CreateGlossaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateGlossaryCompletedEvent = (CreateGlossaryCompletedEventHandler)Delegate.Remove(this.CreateGlossaryCompletedEvent, value);
			}
		}

		public event DeleteGlossaryCompletedEventHandler DeleteGlossaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteGlossaryCompletedEvent = (DeleteGlossaryCompletedEventHandler)Delegate.Combine(this.DeleteGlossaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteGlossaryCompletedEvent = (DeleteGlossaryCompletedEventHandler)Delegate.Remove(this.DeleteGlossaryCompletedEvent, value);
			}
		}

		public event GetSubGlossariesByParentIDCompletedEventHandler GetSubGlossariesByParentIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetSubGlossariesByParentIDCompletedEvent = (GetSubGlossariesByParentIDCompletedEventHandler)Delegate.Combine(this.GetSubGlossariesByParentIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetSubGlossariesByParentIDCompletedEvent = (GetSubGlossariesByParentIDCompletedEventHandler)Delegate.Remove(this.GetSubGlossariesByParentIDCompletedEvent, value);
			}
		}

		public event SelectAllGlossaryByCategoryIDCompletedEventHandler SelectAllGlossaryByCategoryIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllGlossaryByCategoryIDCompletedEvent = (SelectAllGlossaryByCategoryIDCompletedEventHandler)Delegate.Combine(this.SelectAllGlossaryByCategoryIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllGlossaryByCategoryIDCompletedEvent = (SelectAllGlossaryByCategoryIDCompletedEventHandler)Delegate.Remove(this.SelectAllGlossaryByCategoryIDCompletedEvent, value);
			}
		}

		public event SelectGlossaryByIdCompletedEventHandler SelectGlossaryByIdCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectGlossaryByIdCompletedEvent = (SelectGlossaryByIdCompletedEventHandler)Delegate.Combine(this.SelectGlossaryByIdCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectGlossaryByIdCompletedEvent = (SelectGlossaryByIdCompletedEventHandler)Delegate.Remove(this.SelectGlossaryByIdCompletedEvent, value);
			}
		}

		public event UpdateGlossaryCompletedEventHandler UpdateGlossaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateGlossaryCompletedEvent = (UpdateGlossaryCompletedEventHandler)Delegate.Combine(this.UpdateGlossaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateGlossaryCompletedEvent = (UpdateGlossaryCompletedEventHandler)Delegate.Remove(this.UpdateGlossaryCompletedEvent, value);
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

		public GlossaryInfo()
		{
			this.Url = MySettings.Default.EPRLib_GlossaryData_GlossaryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.CheckInternalID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckInternalID(string AGlossaryID, string AInternalID)
		{
			object[] array = this.Invoke("CheckInternalID", new object[]
			{
				AGlossaryID,
				AInternalID
			});
			return Conversions.ToString(array[0]);
		}

		public void CheckInternalIDAsync(string AGlossaryID, string AInternalID)
		{
			this.CheckInternalIDAsync(AGlossaryID, AInternalID, null);
		}

		public void CheckInternalIDAsync(string AGlossaryID, string AInternalID, object userState)
		{
			if (this.CheckInternalIDOperationCompleted == null)
			{
				this.CheckInternalIDOperationCompleted = new SendOrPostCallback(this.OnCheckInternalIDOperationCompleted);
			}
			this.InvokeAsync("CheckInternalID", new object[]
			{
				AGlossaryID,
				AInternalID
			}, this.CheckInternalIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCheckInternalIDOperationCompleted(object arg)
		{
			if (this.CheckInternalIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CheckInternalIDCompletedEventHandler checkInternalIDCompletedEvent = this.CheckInternalIDCompletedEvent;
				if (checkInternalIDCompletedEvent != null)
				{
					checkInternalIDCompletedEvent(this, new CheckInternalIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.CreateGlossary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateGlossary(EGlossary AEGlossary)
		{
			object[] array = this.Invoke("CreateGlossary", new object[]
			{
				AEGlossary
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateGlossaryAsync(EGlossary AEGlossary)
		{
			this.CreateGlossaryAsync(AEGlossary, null);
		}

		public void CreateGlossaryAsync(EGlossary AEGlossary, object userState)
		{
			if (this.CreateGlossaryOperationCompleted == null)
			{
				this.CreateGlossaryOperationCompleted = new SendOrPostCallback(this.OnCreateGlossaryOperationCompleted);
			}
			this.InvokeAsync("CreateGlossary", new object[]
			{
				AEGlossary
			}, this.CreateGlossaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateGlossaryOperationCompleted(object arg)
		{
			if (this.CreateGlossaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateGlossaryCompletedEventHandler createGlossaryCompletedEvent = this.CreateGlossaryCompletedEvent;
				if (createGlossaryCompletedEvent != null)
				{
					createGlossaryCompletedEvent(this, new CreateGlossaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.DeleteGlossary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteGlossary(string AGlossaryID, ref bool DeleteGlossaryResult, [XmlIgnore] ref bool DeleteGlossaryResultSpecified)
		{
			object[] array = this.Invoke("DeleteGlossary", new object[]
			{
				AGlossaryID
			});
			DeleteGlossaryResult = Conversions.ToBoolean(array[0]);
			DeleteGlossaryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteGlossaryAsync(string AGlossaryID)
		{
			this.DeleteGlossaryAsync(AGlossaryID, null);
		}

		public void DeleteGlossaryAsync(string AGlossaryID, object userState)
		{
			if (this.DeleteGlossaryOperationCompleted == null)
			{
				this.DeleteGlossaryOperationCompleted = new SendOrPostCallback(this.OnDeleteGlossaryOperationCompleted);
			}
			this.InvokeAsync("DeleteGlossary", new object[]
			{
				AGlossaryID
			}, this.DeleteGlossaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteGlossaryOperationCompleted(object arg)
		{
			if (this.DeleteGlossaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteGlossaryCompletedEventHandler deleteGlossaryCompletedEvent = this.DeleteGlossaryCompletedEvent;
				if (deleteGlossaryCompletedEvent != null)
				{
					deleteGlossaryCompletedEvent(this, new DeleteGlossaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.GetSubGlossariesByParentID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossarySubDataset GetSubGlossariesByParentID(string AParentID)
		{
			object[] array = this.Invoke("GetSubGlossariesByParentID", new object[]
			{
				AParentID
			});
			return (EGlossarySubDataset)array[0];
		}

		public void GetSubGlossariesByParentIDAsync(string AParentID)
		{
			this.GetSubGlossariesByParentIDAsync(AParentID, null);
		}

		public void GetSubGlossariesByParentIDAsync(string AParentID, object userState)
		{
			if (this.GetSubGlossariesByParentIDOperationCompleted == null)
			{
				this.GetSubGlossariesByParentIDOperationCompleted = new SendOrPostCallback(this.OnGetSubGlossariesByParentIDOperationCompleted);
			}
			this.InvokeAsync("GetSubGlossariesByParentID", new object[]
			{
				AParentID
			}, this.GetSubGlossariesByParentIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetSubGlossariesByParentIDOperationCompleted(object arg)
		{
			if (this.GetSubGlossariesByParentIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetSubGlossariesByParentIDCompletedEventHandler getSubGlossariesByParentIDCompletedEvent = this.GetSubGlossariesByParentIDCompletedEvent;
				if (getSubGlossariesByParentIDCompletedEvent != null)
				{
					getSubGlossariesByParentIDCompletedEvent(this, new GetSubGlossariesByParentIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.SelectAllGlossaryByCategoryID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossaryDataset SelectAllGlossaryByCategoryID(string aCategoryID)
		{
			object[] array = this.Invoke("SelectAllGlossaryByCategoryID", new object[]
			{
				aCategoryID
			});
			return (EGlossaryDataset)array[0];
		}

		public void SelectAllGlossaryByCategoryIDAsync(string aCategoryID)
		{
			this.SelectAllGlossaryByCategoryIDAsync(aCategoryID, null);
		}

		public void SelectAllGlossaryByCategoryIDAsync(string aCategoryID, object userState)
		{
			if (this.SelectAllGlossaryByCategoryIDOperationCompleted == null)
			{
				this.SelectAllGlossaryByCategoryIDOperationCompleted = new SendOrPostCallback(this.OnSelectAllGlossaryByCategoryIDOperationCompleted);
			}
			this.InvokeAsync("SelectAllGlossaryByCategoryID", new object[]
			{
				aCategoryID
			}, this.SelectAllGlossaryByCategoryIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllGlossaryByCategoryIDOperationCompleted(object arg)
		{
			if (this.SelectAllGlossaryByCategoryIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllGlossaryByCategoryIDCompletedEventHandler selectAllGlossaryByCategoryIDCompletedEvent = this.SelectAllGlossaryByCategoryIDCompletedEvent;
				if (selectAllGlossaryByCategoryIDCompletedEvent != null)
				{
					selectAllGlossaryByCategoryIDCompletedEvent(this, new SelectAllGlossaryByCategoryIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.SelectGlossaryById", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossary SelectGlossaryById(string aGlossaryId)
		{
			object[] array = this.Invoke("SelectGlossaryById", new object[]
			{
				aGlossaryId
			});
			return (EGlossary)array[0];
		}

		public void SelectGlossaryByIdAsync(string aGlossaryId)
		{
			this.SelectGlossaryByIdAsync(aGlossaryId, null);
		}

		public void SelectGlossaryByIdAsync(string aGlossaryId, object userState)
		{
			if (this.SelectGlossaryByIdOperationCompleted == null)
			{
				this.SelectGlossaryByIdOperationCompleted = new SendOrPostCallback(this.OnSelectGlossaryByIdOperationCompleted);
			}
			this.InvokeAsync("SelectGlossaryById", new object[]
			{
				aGlossaryId
			}, this.SelectGlossaryByIdOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectGlossaryByIdOperationCompleted(object arg)
		{
			if (this.SelectGlossaryByIdCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectGlossaryByIdCompletedEventHandler selectGlossaryByIdCompletedEvent = this.SelectGlossaryByIdCompletedEvent;
				if (selectGlossaryByIdCompletedEvent != null)
				{
					selectGlossaryByIdCompletedEvent(this, new SelectGlossaryByIdCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossary.UpdateGlossary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateGlossary(EGlossary AEGlossary, ref bool UpdateGlossaryResult, [XmlIgnore] ref bool UpdateGlossaryResultSpecified)
		{
			object[] array = this.Invoke("UpdateGlossary", new object[]
			{
				AEGlossary
			});
			UpdateGlossaryResult = Conversions.ToBoolean(array[0]);
			UpdateGlossaryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateGlossaryAsync(EGlossary AEGlossary)
		{
			this.UpdateGlossaryAsync(AEGlossary, null);
		}

		public void UpdateGlossaryAsync(EGlossary AEGlossary, object userState)
		{
			if (this.UpdateGlossaryOperationCompleted == null)
			{
				this.UpdateGlossaryOperationCompleted = new SendOrPostCallback(this.OnUpdateGlossaryOperationCompleted);
			}
			this.InvokeAsync("UpdateGlossary", new object[]
			{
				AEGlossary
			}, this.UpdateGlossaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateGlossaryOperationCompleted(object arg)
		{
			if (this.UpdateGlossaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateGlossaryCompletedEventHandler updateGlossaryCompletedEvent = this.UpdateGlossaryCompletedEvent;
				if (updateGlossaryCompletedEvent != null)
				{
					updateGlossaryCompletedEvent(this, new UpdateGlossaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
