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

namespace GlossaryCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "GlossaryCategoryInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class GlossaryCategoryInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CheckInternalIDOperationCompleted;

		private SendOrPostCallback CreateGlossaryCategoryOperationCompleted;

		private SendOrPostCallback DeleteGlossaryCategoryOperationCompleted;

		private SendOrPostCallback SelectAllGlossaryCategoryOperationCompleted;

		private SendOrPostCallback SelectGlossaryCategoryByIDOperationCompleted;

		private SendOrPostCallback UpdateGlossaryCategoryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CheckInternalIDCompletedEventHandler CheckInternalIDCompletedEvent;

		private CreateGlossaryCategoryCompletedEventHandler CreateGlossaryCategoryCompletedEvent;

		private DeleteGlossaryCategoryCompletedEventHandler DeleteGlossaryCategoryCompletedEvent;

		private SelectAllGlossaryCategoryCompletedEventHandler SelectAllGlossaryCategoryCompletedEvent;

		private SelectGlossaryCategoryByIDCompletedEventHandler SelectGlossaryCategoryByIDCompletedEvent;

		private UpdateGlossaryCategoryCompletedEventHandler UpdateGlossaryCategoryCompletedEvent;

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

		public event CreateGlossaryCategoryCompletedEventHandler CreateGlossaryCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateGlossaryCategoryCompletedEvent = (CreateGlossaryCategoryCompletedEventHandler)Delegate.Combine(this.CreateGlossaryCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateGlossaryCategoryCompletedEvent = (CreateGlossaryCategoryCompletedEventHandler)Delegate.Remove(this.CreateGlossaryCategoryCompletedEvent, value);
			}
		}

		public event DeleteGlossaryCategoryCompletedEventHandler DeleteGlossaryCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteGlossaryCategoryCompletedEvent = (DeleteGlossaryCategoryCompletedEventHandler)Delegate.Combine(this.DeleteGlossaryCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteGlossaryCategoryCompletedEvent = (DeleteGlossaryCategoryCompletedEventHandler)Delegate.Remove(this.DeleteGlossaryCategoryCompletedEvent, value);
			}
		}

		public event SelectAllGlossaryCategoryCompletedEventHandler SelectAllGlossaryCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllGlossaryCategoryCompletedEvent = (SelectAllGlossaryCategoryCompletedEventHandler)Delegate.Combine(this.SelectAllGlossaryCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllGlossaryCategoryCompletedEvent = (SelectAllGlossaryCategoryCompletedEventHandler)Delegate.Remove(this.SelectAllGlossaryCategoryCompletedEvent, value);
			}
		}

		public event SelectGlossaryCategoryByIDCompletedEventHandler SelectGlossaryCategoryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectGlossaryCategoryByIDCompletedEvent = (SelectGlossaryCategoryByIDCompletedEventHandler)Delegate.Combine(this.SelectGlossaryCategoryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectGlossaryCategoryByIDCompletedEvent = (SelectGlossaryCategoryByIDCompletedEventHandler)Delegate.Remove(this.SelectGlossaryCategoryByIDCompletedEvent, value);
			}
		}

		public event UpdateGlossaryCategoryCompletedEventHandler UpdateGlossaryCategoryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateGlossaryCategoryCompletedEvent = (UpdateGlossaryCategoryCompletedEventHandler)Delegate.Combine(this.UpdateGlossaryCategoryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateGlossaryCategoryCompletedEvent = (UpdateGlossaryCategoryCompletedEventHandler)Delegate.Remove(this.UpdateGlossaryCategoryCompletedEvent, value);
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

		public GlossaryCategoryInfo()
		{
			this.Url = MySettings.Default.EPRLib_GlossaryCategoryData_GlossaryCategoryInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.CheckInternalID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckInternalID(string AGlossaryCategoryID, string AInternalID)
		{
			object[] array = this.Invoke("CheckInternalID", new object[]
			{
				AGlossaryCategoryID,
				AInternalID
			});
			return Conversions.ToString(array[0]);
		}

		public void CheckInternalIDAsync(string AGlossaryCategoryID, string AInternalID)
		{
			this.CheckInternalIDAsync(AGlossaryCategoryID, AInternalID, null);
		}

		public void CheckInternalIDAsync(string AGlossaryCategoryID, string AInternalID, object userState)
		{
			if (this.CheckInternalIDOperationCompleted == null)
			{
				this.CheckInternalIDOperationCompleted = new SendOrPostCallback(this.OnCheckInternalIDOperationCompleted);
			}
			this.InvokeAsync("CheckInternalID", new object[]
			{
				AGlossaryCategoryID,
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.CreateGlossaryCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateGlossaryCategory(EGlossaryCategory aEGlossaryCategory)
		{
			object[] array = this.Invoke("CreateGlossaryCategory", new object[]
			{
				aEGlossaryCategory
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateGlossaryCategoryAsync(EGlossaryCategory aEGlossaryCategory)
		{
			this.CreateGlossaryCategoryAsync(aEGlossaryCategory, null);
		}

		public void CreateGlossaryCategoryAsync(EGlossaryCategory aEGlossaryCategory, object userState)
		{
			if (this.CreateGlossaryCategoryOperationCompleted == null)
			{
				this.CreateGlossaryCategoryOperationCompleted = new SendOrPostCallback(this.OnCreateGlossaryCategoryOperationCompleted);
			}
			this.InvokeAsync("CreateGlossaryCategory", new object[]
			{
				aEGlossaryCategory
			}, this.CreateGlossaryCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateGlossaryCategoryOperationCompleted(object arg)
		{
			if (this.CreateGlossaryCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateGlossaryCategoryCompletedEventHandler createGlossaryCategoryCompletedEvent = this.CreateGlossaryCategoryCompletedEvent;
				if (createGlossaryCategoryCompletedEvent != null)
				{
					createGlossaryCategoryCompletedEvent(this, new CreateGlossaryCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.DeleteGlossaryCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteGlossaryCategory(string aGlossaryCategoryId, ref bool DeleteGlossaryCategoryResult, [XmlIgnore] ref bool DeleteGlossaryCategoryResultSpecified)
		{
			object[] array = this.Invoke("DeleteGlossaryCategory", new object[]
			{
				aGlossaryCategoryId
			});
			DeleteGlossaryCategoryResult = Conversions.ToBoolean(array[0]);
			DeleteGlossaryCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteGlossaryCategoryAsync(string aGlossaryCategoryId)
		{
			this.DeleteGlossaryCategoryAsync(aGlossaryCategoryId, null);
		}

		public void DeleteGlossaryCategoryAsync(string aGlossaryCategoryId, object userState)
		{
			if (this.DeleteGlossaryCategoryOperationCompleted == null)
			{
				this.DeleteGlossaryCategoryOperationCompleted = new SendOrPostCallback(this.OnDeleteGlossaryCategoryOperationCompleted);
			}
			this.InvokeAsync("DeleteGlossaryCategory", new object[]
			{
				aGlossaryCategoryId
			}, this.DeleteGlossaryCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteGlossaryCategoryOperationCompleted(object arg)
		{
			if (this.DeleteGlossaryCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteGlossaryCategoryCompletedEventHandler deleteGlossaryCategoryCompletedEvent = this.DeleteGlossaryCategoryCompletedEvent;
				if (deleteGlossaryCategoryCompletedEvent != null)
				{
					deleteGlossaryCategoryCompletedEvent(this, new DeleteGlossaryCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.SelectAllGlossaryCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossaryCategoryDataset SelectAllGlossaryCategory()
		{
			object[] array = this.Invoke("SelectAllGlossaryCategory", new object[0]);
			return (EGlossaryCategoryDataset)array[0];
		}

		public void SelectAllGlossaryCategoryAsync()
		{
			this.SelectAllGlossaryCategoryAsync(null);
		}

		public void SelectAllGlossaryCategoryAsync(object userState)
		{
			if (this.SelectAllGlossaryCategoryOperationCompleted == null)
			{
				this.SelectAllGlossaryCategoryOperationCompleted = new SendOrPostCallback(this.OnSelectAllGlossaryCategoryOperationCompleted);
			}
			this.InvokeAsync("SelectAllGlossaryCategory", new object[0], this.SelectAllGlossaryCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllGlossaryCategoryOperationCompleted(object arg)
		{
			if (this.SelectAllGlossaryCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllGlossaryCategoryCompletedEventHandler selectAllGlossaryCategoryCompletedEvent = this.SelectAllGlossaryCategoryCompletedEvent;
				if (selectAllGlossaryCategoryCompletedEvent != null)
				{
					selectAllGlossaryCategoryCompletedEvent(this, new SelectAllGlossaryCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.SelectGlossaryCategoryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EGlossaryCategory SelectGlossaryCategoryByID(string aGlossaryCategoryId)
		{
			object[] array = this.Invoke("SelectGlossaryCategoryByID", new object[]
			{
				aGlossaryCategoryId
			});
			return (EGlossaryCategory)array[0];
		}

		public void SelectGlossaryCategoryByIDAsync(string aGlossaryCategoryId)
		{
			this.SelectGlossaryCategoryByIDAsync(aGlossaryCategoryId, null);
		}

		public void SelectGlossaryCategoryByIDAsync(string aGlossaryCategoryId, object userState)
		{
			if (this.SelectGlossaryCategoryByIDOperationCompleted == null)
			{
				this.SelectGlossaryCategoryByIDOperationCompleted = new SendOrPostCallback(this.OnSelectGlossaryCategoryByIDOperationCompleted);
			}
			this.InvokeAsync("SelectGlossaryCategoryByID", new object[]
			{
				aGlossaryCategoryId
			}, this.SelectGlossaryCategoryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectGlossaryCategoryByIDOperationCompleted(object arg)
		{
			if (this.SelectGlossaryCategoryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectGlossaryCategoryByIDCompletedEventHandler selectGlossaryCategoryByIDCompletedEvent = this.SelectGlossaryCategoryByIDCompletedEvent;
				if (selectGlossaryCategoryByIDCompletedEvent != null)
				{
					selectGlossaryCategoryByIDCompletedEvent(this, new SelectGlossaryCategoryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOGlossaryCategory.UpdateGlossaryCategory", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateGlossaryCategory(EGlossaryCategory aEGlossaryCategory, ref bool UpdateGlossaryCategoryResult, [XmlIgnore] ref bool UpdateGlossaryCategoryResultSpecified)
		{
			object[] array = this.Invoke("UpdateGlossaryCategory", new object[]
			{
				aEGlossaryCategory
			});
			UpdateGlossaryCategoryResult = Conversions.ToBoolean(array[0]);
			UpdateGlossaryCategoryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateGlossaryCategoryAsync(EGlossaryCategory aEGlossaryCategory)
		{
			this.UpdateGlossaryCategoryAsync(aEGlossaryCategory, null);
		}

		public void UpdateGlossaryCategoryAsync(EGlossaryCategory aEGlossaryCategory, object userState)
		{
			if (this.UpdateGlossaryCategoryOperationCompleted == null)
			{
				this.UpdateGlossaryCategoryOperationCompleted = new SendOrPostCallback(this.OnUpdateGlossaryCategoryOperationCompleted);
			}
			this.InvokeAsync("UpdateGlossaryCategory", new object[]
			{
				aEGlossaryCategory
			}, this.UpdateGlossaryCategoryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateGlossaryCategoryOperationCompleted(object arg)
		{
			if (this.UpdateGlossaryCategoryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateGlossaryCategoryCompletedEventHandler updateGlossaryCategoryCompletedEvent = this.UpdateGlossaryCategoryCompletedEvent;
				if (updateGlossaryCategoryCompletedEvent != null)
				{
					updateGlossaryCategoryCompletedEvent(this, new UpdateGlossaryCategoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
