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

namespace BindQueryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "BindQueryServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class BindQueryService : SoapHttpClientProtocol
	{
		private SendOrPostCallback AddFieldOperationCompleted;

		private SendOrPostCallback AddParameterOperationCompleted;

		private SendOrPostCallback AddQueryOperationCompleted;

		private SendOrPostCallback DelFieldByIDOperationCompleted;

		private SendOrPostCallback DelParameterByIDOperationCompleted;

		private SendOrPostCallback DelQueryByIDOperationCompleted;

		private SendOrPostCallback GetFieldByIDOperationCompleted;

		private SendOrPostCallback GetParameterByIDOperationCompleted;

		private SendOrPostCallback GetQueryByIDOperationCompleted;

		private SendOrPostCallback SelectAllQueryOperationCompleted;

		private SendOrPostCallback SelectDistinctParameterOperationCompleted;

		private SendOrPostCallback SelectFieldByQIDOperationCompleted;

		private SendOrPostCallback SelectParameterByQIDOperationCompleted;

		private SendOrPostCallback UpdateFieldOperationCompleted;

		private SendOrPostCallback UpdateParameterOperationCompleted;

		private SendOrPostCallback UpdateQueryOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private AddFieldCompletedEventHandler AddFieldCompletedEvent;

		private AddParameterCompletedEventHandler AddParameterCompletedEvent;

		private AddQueryCompletedEventHandler AddQueryCompletedEvent;

		private DelFieldByIDCompletedEventHandler DelFieldByIDCompletedEvent;

		private DelParameterByIDCompletedEventHandler DelParameterByIDCompletedEvent;

		private DelQueryByIDCompletedEventHandler DelQueryByIDCompletedEvent;

		private GetFieldByIDCompletedEventHandler GetFieldByIDCompletedEvent;

		private GetParameterByIDCompletedEventHandler GetParameterByIDCompletedEvent;

		private GetQueryByIDCompletedEventHandler GetQueryByIDCompletedEvent;

		private SelectAllQueryCompletedEventHandler SelectAllQueryCompletedEvent;

		private SelectDistinctParameterCompletedEventHandler SelectDistinctParameterCompletedEvent;

		private SelectFieldByQIDCompletedEventHandler SelectFieldByQIDCompletedEvent;

		private SelectParameterByQIDCompletedEventHandler SelectParameterByQIDCompletedEvent;

		private UpdateFieldCompletedEventHandler UpdateFieldCompletedEvent;

		private UpdateParameterCompletedEventHandler UpdateParameterCompletedEvent;

		private UpdateQueryCompletedEventHandler UpdateQueryCompletedEvent;

		public event AddFieldCompletedEventHandler AddFieldCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddFieldCompletedEvent = (AddFieldCompletedEventHandler)Delegate.Combine(this.AddFieldCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddFieldCompletedEvent = (AddFieldCompletedEventHandler)Delegate.Remove(this.AddFieldCompletedEvent, value);
			}
		}

		public event AddParameterCompletedEventHandler AddParameterCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddParameterCompletedEvent = (AddParameterCompletedEventHandler)Delegate.Combine(this.AddParameterCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddParameterCompletedEvent = (AddParameterCompletedEventHandler)Delegate.Remove(this.AddParameterCompletedEvent, value);
			}
		}

		public event AddQueryCompletedEventHandler AddQueryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddQueryCompletedEvent = (AddQueryCompletedEventHandler)Delegate.Combine(this.AddQueryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddQueryCompletedEvent = (AddQueryCompletedEventHandler)Delegate.Remove(this.AddQueryCompletedEvent, value);
			}
		}

		public event DelFieldByIDCompletedEventHandler DelFieldByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DelFieldByIDCompletedEvent = (DelFieldByIDCompletedEventHandler)Delegate.Combine(this.DelFieldByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DelFieldByIDCompletedEvent = (DelFieldByIDCompletedEventHandler)Delegate.Remove(this.DelFieldByIDCompletedEvent, value);
			}
		}

		public event DelParameterByIDCompletedEventHandler DelParameterByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DelParameterByIDCompletedEvent = (DelParameterByIDCompletedEventHandler)Delegate.Combine(this.DelParameterByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DelParameterByIDCompletedEvent = (DelParameterByIDCompletedEventHandler)Delegate.Remove(this.DelParameterByIDCompletedEvent, value);
			}
		}

		public event DelQueryByIDCompletedEventHandler DelQueryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DelQueryByIDCompletedEvent = (DelQueryByIDCompletedEventHandler)Delegate.Combine(this.DelQueryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DelQueryByIDCompletedEvent = (DelQueryByIDCompletedEventHandler)Delegate.Remove(this.DelQueryByIDCompletedEvent, value);
			}
		}

		public event GetFieldByIDCompletedEventHandler GetFieldByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetFieldByIDCompletedEvent = (GetFieldByIDCompletedEventHandler)Delegate.Combine(this.GetFieldByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetFieldByIDCompletedEvent = (GetFieldByIDCompletedEventHandler)Delegate.Remove(this.GetFieldByIDCompletedEvent, value);
			}
		}

		public event GetParameterByIDCompletedEventHandler GetParameterByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetParameterByIDCompletedEvent = (GetParameterByIDCompletedEventHandler)Delegate.Combine(this.GetParameterByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetParameterByIDCompletedEvent = (GetParameterByIDCompletedEventHandler)Delegate.Remove(this.GetParameterByIDCompletedEvent, value);
			}
		}

		public event GetQueryByIDCompletedEventHandler GetQueryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetQueryByIDCompletedEvent = (GetQueryByIDCompletedEventHandler)Delegate.Combine(this.GetQueryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetQueryByIDCompletedEvent = (GetQueryByIDCompletedEventHandler)Delegate.Remove(this.GetQueryByIDCompletedEvent, value);
			}
		}

		public event SelectAllQueryCompletedEventHandler SelectAllQueryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectAllQueryCompletedEvent = (SelectAllQueryCompletedEventHandler)Delegate.Combine(this.SelectAllQueryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectAllQueryCompletedEvent = (SelectAllQueryCompletedEventHandler)Delegate.Remove(this.SelectAllQueryCompletedEvent, value);
			}
		}

		public event SelectDistinctParameterCompletedEventHandler SelectDistinctParameterCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectDistinctParameterCompletedEvent = (SelectDistinctParameterCompletedEventHandler)Delegate.Combine(this.SelectDistinctParameterCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectDistinctParameterCompletedEvent = (SelectDistinctParameterCompletedEventHandler)Delegate.Remove(this.SelectDistinctParameterCompletedEvent, value);
			}
		}

		public event SelectFieldByQIDCompletedEventHandler SelectFieldByQIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectFieldByQIDCompletedEvent = (SelectFieldByQIDCompletedEventHandler)Delegate.Combine(this.SelectFieldByQIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectFieldByQIDCompletedEvent = (SelectFieldByQIDCompletedEventHandler)Delegate.Remove(this.SelectFieldByQIDCompletedEvent, value);
			}
		}

		public event SelectParameterByQIDCompletedEventHandler SelectParameterByQIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectParameterByQIDCompletedEvent = (SelectParameterByQIDCompletedEventHandler)Delegate.Combine(this.SelectParameterByQIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectParameterByQIDCompletedEvent = (SelectParameterByQIDCompletedEventHandler)Delegate.Remove(this.SelectParameterByQIDCompletedEvent, value);
			}
		}

		public event UpdateFieldCompletedEventHandler UpdateFieldCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateFieldCompletedEvent = (UpdateFieldCompletedEventHandler)Delegate.Combine(this.UpdateFieldCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateFieldCompletedEvent = (UpdateFieldCompletedEventHandler)Delegate.Remove(this.UpdateFieldCompletedEvent, value);
			}
		}

		public event UpdateParameterCompletedEventHandler UpdateParameterCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateParameterCompletedEvent = (UpdateParameterCompletedEventHandler)Delegate.Combine(this.UpdateParameterCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateParameterCompletedEvent = (UpdateParameterCompletedEventHandler)Delegate.Remove(this.UpdateParameterCompletedEvent, value);
			}
		}

		public event UpdateQueryCompletedEventHandler UpdateQueryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateQueryCompletedEvent = (UpdateQueryCompletedEventHandler)Delegate.Combine(this.UpdateQueryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateQueryCompletedEvent = (UpdateQueryCompletedEventHandler)Delegate.Remove(this.UpdateQueryCompletedEvent, value);
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

		public BindQueryService()
		{
			this.Url = MySettings.Default.EPRLib_BindQueryData_BindQueryService;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.AddField", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddField(EBindField ABindField)
		{
			object[] array = this.Invoke("AddField", new object[]
			{
				ABindField
			});
			return Conversions.ToString(array[0]);
		}

		public void AddFieldAsync(EBindField ABindField)
		{
			this.AddFieldAsync(ABindField, null);
		}

		public void AddFieldAsync(EBindField ABindField, object userState)
		{
			if (this.AddFieldOperationCompleted == null)
			{
				this.AddFieldOperationCompleted = new SendOrPostCallback(this.OnAddFieldOperationCompleted);
			}
			this.InvokeAsync("AddField", new object[]
			{
				ABindField
			}, this.AddFieldOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddFieldOperationCompleted(object arg)
		{
			if (this.AddFieldCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddFieldCompletedEventHandler addFieldCompletedEvent = this.AddFieldCompletedEvent;
				if (addFieldCompletedEvent != null)
				{
					addFieldCompletedEvent(this, new AddFieldCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.AddParameter", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddParameter(EBindParameter ABindParameter)
		{
			object[] array = this.Invoke("AddParameter", new object[]
			{
				ABindParameter
			});
			return Conversions.ToString(array[0]);
		}

		public void AddParameterAsync(EBindParameter ABindParameter)
		{
			this.AddParameterAsync(ABindParameter, null);
		}

		public void AddParameterAsync(EBindParameter ABindParameter, object userState)
		{
			if (this.AddParameterOperationCompleted == null)
			{
				this.AddParameterOperationCompleted = new SendOrPostCallback(this.OnAddParameterOperationCompleted);
			}
			this.InvokeAsync("AddParameter", new object[]
			{
				ABindParameter
			}, this.AddParameterOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddParameterOperationCompleted(object arg)
		{
			if (this.AddParameterCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddParameterCompletedEventHandler addParameterCompletedEvent = this.AddParameterCompletedEvent;
				if (addParameterCompletedEvent != null)
				{
					addParameterCompletedEvent(this, new AddParameterCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.AddQuery", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddQuery(EBindQuery ABindQuery)
		{
			object[] array = this.Invoke("AddQuery", new object[]
			{
				ABindQuery
			});
			return Conversions.ToString(array[0]);
		}

		public void AddQueryAsync(EBindQuery ABindQuery)
		{
			this.AddQueryAsync(ABindQuery, null);
		}

		public void AddQueryAsync(EBindQuery ABindQuery, object userState)
		{
			if (this.AddQueryOperationCompleted == null)
			{
				this.AddQueryOperationCompleted = new SendOrPostCallback(this.OnAddQueryOperationCompleted);
			}
			this.InvokeAsync("AddQuery", new object[]
			{
				ABindQuery
			}, this.AddQueryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddQueryOperationCompleted(object arg)
		{
			if (this.AddQueryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddQueryCompletedEventHandler addQueryCompletedEvent = this.AddQueryCompletedEvent;
				if (addQueryCompletedEvent != null)
				{
					addQueryCompletedEvent(this, new AddQueryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.DelFieldByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DelFieldByID(string AID, ref bool DelFieldByIDResult, [XmlIgnore] ref bool DelFieldByIDResultSpecified)
		{
			object[] array = this.Invoke("DelFieldByID", new object[]
			{
				AID
			});
			DelFieldByIDResult = Conversions.ToBoolean(array[0]);
			DelFieldByIDResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DelFieldByIDAsync(string AID)
		{
			this.DelFieldByIDAsync(AID, null);
		}

		public void DelFieldByIDAsync(string AID, object userState)
		{
			if (this.DelFieldByIDOperationCompleted == null)
			{
				this.DelFieldByIDOperationCompleted = new SendOrPostCallback(this.OnDelFieldByIDOperationCompleted);
			}
			this.InvokeAsync("DelFieldByID", new object[]
			{
				AID
			}, this.DelFieldByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDelFieldByIDOperationCompleted(object arg)
		{
			if (this.DelFieldByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DelFieldByIDCompletedEventHandler delFieldByIDCompletedEvent = this.DelFieldByIDCompletedEvent;
				if (delFieldByIDCompletedEvent != null)
				{
					delFieldByIDCompletedEvent(this, new DelFieldByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.DelParameterByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DelParameterByID(string AID, ref bool DelParameterByIDResult, [XmlIgnore] ref bool DelParameterByIDResultSpecified)
		{
			object[] array = this.Invoke("DelParameterByID", new object[]
			{
				AID
			});
			DelParameterByIDResult = Conversions.ToBoolean(array[0]);
			DelParameterByIDResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DelParameterByIDAsync(string AID)
		{
			this.DelParameterByIDAsync(AID, null);
		}

		public void DelParameterByIDAsync(string AID, object userState)
		{
			if (this.DelParameterByIDOperationCompleted == null)
			{
				this.DelParameterByIDOperationCompleted = new SendOrPostCallback(this.OnDelParameterByIDOperationCompleted);
			}
			this.InvokeAsync("DelParameterByID", new object[]
			{
				AID
			}, this.DelParameterByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDelParameterByIDOperationCompleted(object arg)
		{
			if (this.DelParameterByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DelParameterByIDCompletedEventHandler delParameterByIDCompletedEvent = this.DelParameterByIDCompletedEvent;
				if (delParameterByIDCompletedEvent != null)
				{
					delParameterByIDCompletedEvent(this, new DelParameterByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.DelQueryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DelQueryByID(string AID, ref bool DelQueryByIDResult, [XmlIgnore] ref bool DelQueryByIDResultSpecified)
		{
			object[] array = this.Invoke("DelQueryByID", new object[]
			{
				AID
			});
			DelQueryByIDResult = Conversions.ToBoolean(array[0]);
			DelQueryByIDResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DelQueryByIDAsync(string AID)
		{
			this.DelQueryByIDAsync(AID, null);
		}

		public void DelQueryByIDAsync(string AID, object userState)
		{
			if (this.DelQueryByIDOperationCompleted == null)
			{
				this.DelQueryByIDOperationCompleted = new SendOrPostCallback(this.OnDelQueryByIDOperationCompleted);
			}
			this.InvokeAsync("DelQueryByID", new object[]
			{
				AID
			}, this.DelQueryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDelQueryByIDOperationCompleted(object arg)
		{
			if (this.DelQueryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DelQueryByIDCompletedEventHandler delQueryByIDCompletedEvent = this.DelQueryByIDCompletedEvent;
				if (delQueryByIDCompletedEvent != null)
				{
					delQueryByIDCompletedEvent(this, new DelQueryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.GetFieldByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindField GetFieldByID(string AID)
		{
			object[] array = this.Invoke("GetFieldByID", new object[]
			{
				AID
			});
			return (EBindField)array[0];
		}

		public void GetFieldByIDAsync(string AID)
		{
			this.GetFieldByIDAsync(AID, null);
		}

		public void GetFieldByIDAsync(string AID, object userState)
		{
			if (this.GetFieldByIDOperationCompleted == null)
			{
				this.GetFieldByIDOperationCompleted = new SendOrPostCallback(this.OnGetFieldByIDOperationCompleted);
			}
			this.InvokeAsync("GetFieldByID", new object[]
			{
				AID
			}, this.GetFieldByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetFieldByIDOperationCompleted(object arg)
		{
			if (this.GetFieldByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetFieldByIDCompletedEventHandler getFieldByIDCompletedEvent = this.GetFieldByIDCompletedEvent;
				if (getFieldByIDCompletedEvent != null)
				{
					getFieldByIDCompletedEvent(this, new GetFieldByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.GetParameterByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindParameter GetParameterByID(string AID)
		{
			object[] array = this.Invoke("GetParameterByID", new object[]
			{
				AID
			});
			return (EBindParameter)array[0];
		}

		public void GetParameterByIDAsync(string AID)
		{
			this.GetParameterByIDAsync(AID, null);
		}

		public void GetParameterByIDAsync(string AID, object userState)
		{
			if (this.GetParameterByIDOperationCompleted == null)
			{
				this.GetParameterByIDOperationCompleted = new SendOrPostCallback(this.OnGetParameterByIDOperationCompleted);
			}
			this.InvokeAsync("GetParameterByID", new object[]
			{
				AID
			}, this.GetParameterByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetParameterByIDOperationCompleted(object arg)
		{
			if (this.GetParameterByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetParameterByIDCompletedEventHandler getParameterByIDCompletedEvent = this.GetParameterByIDCompletedEvent;
				if (getParameterByIDCompletedEvent != null)
				{
					getParameterByIDCompletedEvent(this, new GetParameterByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.GetQueryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindQuery GetQueryByID(string AID)
		{
			object[] array = this.Invoke("GetQueryByID", new object[]
			{
				AID
			});
			return (EBindQuery)array[0];
		}

		public void GetQueryByIDAsync(string AID)
		{
			this.GetQueryByIDAsync(AID, null);
		}

		public void GetQueryByIDAsync(string AID, object userState)
		{
			if (this.GetQueryByIDOperationCompleted == null)
			{
				this.GetQueryByIDOperationCompleted = new SendOrPostCallback(this.OnGetQueryByIDOperationCompleted);
			}
			this.InvokeAsync("GetQueryByID", new object[]
			{
				AID
			}, this.GetQueryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetQueryByIDOperationCompleted(object arg)
		{
			if (this.GetQueryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetQueryByIDCompletedEventHandler getQueryByIDCompletedEvent = this.GetQueryByIDCompletedEvent;
				if (getQueryByIDCompletedEvent != null)
				{
					getQueryByIDCompletedEvent(this, new GetQueryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.SelectAllQuery", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindQueryDataset SelectAllQuery()
		{
			object[] array = this.Invoke("SelectAllQuery", new object[0]);
			return (EBindQueryDataset)array[0];
		}

		public void SelectAllQueryAsync()
		{
			this.SelectAllQueryAsync(null);
		}

		public void SelectAllQueryAsync(object userState)
		{
			if (this.SelectAllQueryOperationCompleted == null)
			{
				this.SelectAllQueryOperationCompleted = new SendOrPostCallback(this.OnSelectAllQueryOperationCompleted);
			}
			this.InvokeAsync("SelectAllQuery", new object[0], this.SelectAllQueryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectAllQueryOperationCompleted(object arg)
		{
			if (this.SelectAllQueryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectAllQueryCompletedEventHandler selectAllQueryCompletedEvent = this.SelectAllQueryCompletedEvent;
				if (selectAllQueryCompletedEvent != null)
				{
					selectAllQueryCompletedEvent(this, new SelectAllQueryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.SelectDistinctParameter", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EDataBindDisDataSet SelectDistinctParameter()
		{
			object[] array = this.Invoke("SelectDistinctParameter", new object[0]);
			return (EDataBindDisDataSet)array[0];
		}

		public void SelectDistinctParameterAsync()
		{
			this.SelectDistinctParameterAsync(null);
		}

		public void SelectDistinctParameterAsync(object userState)
		{
			if (this.SelectDistinctParameterOperationCompleted == null)
			{
				this.SelectDistinctParameterOperationCompleted = new SendOrPostCallback(this.OnSelectDistinctParameterOperationCompleted);
			}
			this.InvokeAsync("SelectDistinctParameter", new object[0], this.SelectDistinctParameterOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectDistinctParameterOperationCompleted(object arg)
		{
			if (this.SelectDistinctParameterCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectDistinctParameterCompletedEventHandler selectDistinctParameterCompletedEvent = this.SelectDistinctParameterCompletedEvent;
				if (selectDistinctParameterCompletedEvent != null)
				{
					selectDistinctParameterCompletedEvent(this, new SelectDistinctParameterCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.SelectFieldByQID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindFieldDataset SelectFieldByQID(string AQID)
		{
			object[] array = this.Invoke("SelectFieldByQID", new object[]
			{
				AQID
			});
			return (EBindFieldDataset)array[0];
		}

		public void SelectFieldByQIDAsync(string AQID)
		{
			this.SelectFieldByQIDAsync(AQID, null);
		}

		public void SelectFieldByQIDAsync(string AQID, object userState)
		{
			if (this.SelectFieldByQIDOperationCompleted == null)
			{
				this.SelectFieldByQIDOperationCompleted = new SendOrPostCallback(this.OnSelectFieldByQIDOperationCompleted);
			}
			this.InvokeAsync("SelectFieldByQID", new object[]
			{
				AQID
			}, this.SelectFieldByQIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectFieldByQIDOperationCompleted(object arg)
		{
			if (this.SelectFieldByQIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectFieldByQIDCompletedEventHandler selectFieldByQIDCompletedEvent = this.SelectFieldByQIDCompletedEvent;
				if (selectFieldByQIDCompletedEvent != null)
				{
					selectFieldByQIDCompletedEvent(this, new SelectFieldByQIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.SelectParameterByQID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EBindParameterDataset SelectParameterByQID(string AQID)
		{
			object[] array = this.Invoke("SelectParameterByQID", new object[]
			{
				AQID
			});
			return (EBindParameterDataset)array[0];
		}

		public void SelectParameterByQIDAsync(string AQID)
		{
			this.SelectParameterByQIDAsync(AQID, null);
		}

		public void SelectParameterByQIDAsync(string AQID, object userState)
		{
			if (this.SelectParameterByQIDOperationCompleted == null)
			{
				this.SelectParameterByQIDOperationCompleted = new SendOrPostCallback(this.OnSelectParameterByQIDOperationCompleted);
			}
			this.InvokeAsync("SelectParameterByQID", new object[]
			{
				AQID
			}, this.SelectParameterByQIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectParameterByQIDOperationCompleted(object arg)
		{
			if (this.SelectParameterByQIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectParameterByQIDCompletedEventHandler selectParameterByQIDCompletedEvent = this.SelectParameterByQIDCompletedEvent;
				if (selectParameterByQIDCompletedEvent != null)
				{
					selectParameterByQIDCompletedEvent(this, new SelectParameterByQIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.UpdateField", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateField(EBindField ABindField)
		{
			object[] array = this.Invoke("UpdateField", new object[]
			{
				ABindField
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateFieldAsync(EBindField ABindField)
		{
			this.UpdateFieldAsync(ABindField, null);
		}

		public void UpdateFieldAsync(EBindField ABindField, object userState)
		{
			if (this.UpdateFieldOperationCompleted == null)
			{
				this.UpdateFieldOperationCompleted = new SendOrPostCallback(this.OnUpdateFieldOperationCompleted);
			}
			this.InvokeAsync("UpdateField", new object[]
			{
				ABindField
			}, this.UpdateFieldOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateFieldOperationCompleted(object arg)
		{
			if (this.UpdateFieldCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateFieldCompletedEventHandler updateFieldCompletedEvent = this.UpdateFieldCompletedEvent;
				if (updateFieldCompletedEvent != null)
				{
					updateFieldCompletedEvent(this, new UpdateFieldCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.UpdateParameter", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateParameter(EBindParameter ABindParameter)
		{
			object[] array = this.Invoke("UpdateParameter", new object[]
			{
				ABindParameter
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateParameterAsync(EBindParameter ABindParameter)
		{
			this.UpdateParameterAsync(ABindParameter, null);
		}

		public void UpdateParameterAsync(EBindParameter ABindParameter, object userState)
		{
			if (this.UpdateParameterOperationCompleted == null)
			{
				this.UpdateParameterOperationCompleted = new SendOrPostCallback(this.OnUpdateParameterOperationCompleted);
			}
			this.InvokeAsync("UpdateParameter", new object[]
			{
				ABindParameter
			}, this.UpdateParameterOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateParameterOperationCompleted(object arg)
		{
			if (this.UpdateParameterCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateParameterCompletedEventHandler updateParameterCompletedEvent = this.UpdateParameterCompletedEvent;
				if (updateParameterCompletedEvent != null)
				{
					updateParameterCompletedEvent(this, new UpdateParameterCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOBindQueryService.UpdateQuery", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateQuery(EBindQuery ABindQuery)
		{
			object[] array = this.Invoke("UpdateQuery", new object[]
			{
				ABindQuery
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateQueryAsync(EBindQuery ABindQuery)
		{
			this.UpdateQueryAsync(ABindQuery, null);
		}

		public void UpdateQueryAsync(EBindQuery ABindQuery, object userState)
		{
			if (this.UpdateQueryOperationCompleted == null)
			{
				this.UpdateQueryOperationCompleted = new SendOrPostCallback(this.OnUpdateQueryOperationCompleted);
			}
			this.InvokeAsync("UpdateQuery", new object[]
			{
				ABindQuery
			}, this.UpdateQueryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateQueryOperationCompleted(object arg)
		{
			if (this.UpdateQueryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateQueryCompletedEventHandler updateQueryCompletedEvent = this.UpdateQueryCompletedEvent;
				if (updateQueryCompletedEvent != null)
				{
					updateQueryCompletedEvent(this, new UpdateQueryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
