using Microsoft.VisualBasic.CompilerServices;
using My;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "StdDictionaryServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class StdDictionaryService : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateStdDictionaryOperationCompleted;

		private SendOrPostCallback DeleteStdDictionaryOperationCompleted;

		private SendOrPostCallback DeleteStdQueryTempGlobalOperationCompleted;

		private SendOrPostCallback GetStdDicListOperationCompleted;

		private SendOrPostCallback GetStdDicOrListOperationCompleted;

		private SendOrPostCallback GetStdDicPageCountOperationCompleted;

		private SendOrPostCallback GetStdDicitonaryByIDOperationCompleted;

		private SendOrPostCallback SelectALLStdDicOperationCompleted;

		private SendOrPostCallback SelectConditionByStdCodeOperationCompleted;

		private SendOrPostCallback SelectStdDicByRuleTypeTagOperationCompleted;

		private SendOrPostCallback UpdateStdDictionaryOperationCompleted;

		private SendOrPostCallback icdtestOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateStdDictionaryCompletedEventHandler CreateStdDictionaryCompletedEvent;

		private DeleteStdDictionaryCompletedEventHandler DeleteStdDictionaryCompletedEvent;

		private DeleteStdQueryTempGlobalCompletedEventHandler DeleteStdQueryTempGlobalCompletedEvent;

		private GetStdDicListCompletedEventHandler GetStdDicListCompletedEvent;

		private GetStdDicOrListCompletedEventHandler GetStdDicOrListCompletedEvent;

		private GetStdDicPageCountCompletedEventHandler GetStdDicPageCountCompletedEvent;

		private GetStdDicitonaryByIDCompletedEventHandler GetStdDicitonaryByIDCompletedEvent;

		private SelectALLStdDicCompletedEventHandler SelectALLStdDicCompletedEvent;

		private SelectConditionByStdCodeCompletedEventHandler SelectConditionByStdCodeCompletedEvent;

		private SelectStdDicByRuleTypeTagCompletedEventHandler SelectStdDicByRuleTypeTagCompletedEvent;

		private UpdateStdDictionaryCompletedEventHandler UpdateStdDictionaryCompletedEvent;

		private icdtestCompletedEventHandler icdtestCompletedEvent;

		public event CreateStdDictionaryCompletedEventHandler CreateStdDictionaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateStdDictionaryCompletedEvent = (CreateStdDictionaryCompletedEventHandler)Delegate.Combine(this.CreateStdDictionaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateStdDictionaryCompletedEvent = (CreateStdDictionaryCompletedEventHandler)Delegate.Remove(this.CreateStdDictionaryCompletedEvent, value);
			}
		}

		public event DeleteStdDictionaryCompletedEventHandler DeleteStdDictionaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteStdDictionaryCompletedEvent = (DeleteStdDictionaryCompletedEventHandler)Delegate.Combine(this.DeleteStdDictionaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteStdDictionaryCompletedEvent = (DeleteStdDictionaryCompletedEventHandler)Delegate.Remove(this.DeleteStdDictionaryCompletedEvent, value);
			}
		}

		public event DeleteStdQueryTempGlobalCompletedEventHandler DeleteStdQueryTempGlobalCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteStdQueryTempGlobalCompletedEvent = (DeleteStdQueryTempGlobalCompletedEventHandler)Delegate.Combine(this.DeleteStdQueryTempGlobalCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteStdQueryTempGlobalCompletedEvent = (DeleteStdQueryTempGlobalCompletedEventHandler)Delegate.Remove(this.DeleteStdQueryTempGlobalCompletedEvent, value);
			}
		}

		public event GetStdDicListCompletedEventHandler GetStdDicListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetStdDicListCompletedEvent = (GetStdDicListCompletedEventHandler)Delegate.Combine(this.GetStdDicListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetStdDicListCompletedEvent = (GetStdDicListCompletedEventHandler)Delegate.Remove(this.GetStdDicListCompletedEvent, value);
			}
		}

		public event GetStdDicOrListCompletedEventHandler GetStdDicOrListCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetStdDicOrListCompletedEvent = (GetStdDicOrListCompletedEventHandler)Delegate.Combine(this.GetStdDicOrListCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetStdDicOrListCompletedEvent = (GetStdDicOrListCompletedEventHandler)Delegate.Remove(this.GetStdDicOrListCompletedEvent, value);
			}
		}

		public event GetStdDicPageCountCompletedEventHandler GetStdDicPageCountCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetStdDicPageCountCompletedEvent = (GetStdDicPageCountCompletedEventHandler)Delegate.Combine(this.GetStdDicPageCountCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetStdDicPageCountCompletedEvent = (GetStdDicPageCountCompletedEventHandler)Delegate.Remove(this.GetStdDicPageCountCompletedEvent, value);
			}
		}

		public event GetStdDicitonaryByIDCompletedEventHandler GetStdDicitonaryByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetStdDicitonaryByIDCompletedEvent = (GetStdDicitonaryByIDCompletedEventHandler)Delegate.Combine(this.GetStdDicitonaryByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetStdDicitonaryByIDCompletedEvent = (GetStdDicitonaryByIDCompletedEventHandler)Delegate.Remove(this.GetStdDicitonaryByIDCompletedEvent, value);
			}
		}

		public event SelectALLStdDicCompletedEventHandler SelectALLStdDicCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectALLStdDicCompletedEvent = (SelectALLStdDicCompletedEventHandler)Delegate.Combine(this.SelectALLStdDicCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectALLStdDicCompletedEvent = (SelectALLStdDicCompletedEventHandler)Delegate.Remove(this.SelectALLStdDicCompletedEvent, value);
			}
		}

		public event SelectConditionByStdCodeCompletedEventHandler SelectConditionByStdCodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectConditionByStdCodeCompletedEvent = (SelectConditionByStdCodeCompletedEventHandler)Delegate.Combine(this.SelectConditionByStdCodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectConditionByStdCodeCompletedEvent = (SelectConditionByStdCodeCompletedEventHandler)Delegate.Remove(this.SelectConditionByStdCodeCompletedEvent, value);
			}
		}

		public event SelectStdDicByRuleTypeTagCompletedEventHandler SelectStdDicByRuleTypeTagCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectStdDicByRuleTypeTagCompletedEvent = (SelectStdDicByRuleTypeTagCompletedEventHandler)Delegate.Combine(this.SelectStdDicByRuleTypeTagCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectStdDicByRuleTypeTagCompletedEvent = (SelectStdDicByRuleTypeTagCompletedEventHandler)Delegate.Remove(this.SelectStdDicByRuleTypeTagCompletedEvent, value);
			}
		}

		public event UpdateStdDictionaryCompletedEventHandler UpdateStdDictionaryCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateStdDictionaryCompletedEvent = (UpdateStdDictionaryCompletedEventHandler)Delegate.Combine(this.UpdateStdDictionaryCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateStdDictionaryCompletedEvent = (UpdateStdDictionaryCompletedEventHandler)Delegate.Remove(this.UpdateStdDictionaryCompletedEvent, value);
			}
		}

		public event icdtestCompletedEventHandler icdtestCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.icdtestCompletedEvent = (icdtestCompletedEventHandler)Delegate.Combine(this.icdtestCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.icdtestCompletedEvent = (icdtestCompletedEventHandler)Delegate.Remove(this.icdtestCompletedEvent, value);
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

		public StdDictionaryService()
		{
			this.Url = MySettings.Default.EPRLib_DictionaryData_StdDictionaryService;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.CreateStdDictionary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateStdDictionary(EStdDictionary AEStdDictionary)
		{
			object[] array = this.Invoke("CreateStdDictionary", new object[]
			{
				AEStdDictionary
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateStdDictionaryAsync(EStdDictionary AEStdDictionary)
		{
			this.CreateStdDictionaryAsync(AEStdDictionary, null);
		}

		public void CreateStdDictionaryAsync(EStdDictionary AEStdDictionary, object userState)
		{
			if (this.CreateStdDictionaryOperationCompleted == null)
			{
				this.CreateStdDictionaryOperationCompleted = new SendOrPostCallback(this.OnCreateStdDictionaryOperationCompleted);
			}
			this.InvokeAsync("CreateStdDictionary", new object[]
			{
				AEStdDictionary
			}, this.CreateStdDictionaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateStdDictionaryOperationCompleted(object arg)
		{
			if (this.CreateStdDictionaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateStdDictionaryCompletedEventHandler createStdDictionaryCompletedEvent = this.CreateStdDictionaryCompletedEvent;
				if (createStdDictionaryCompletedEvent != null)
				{
					createStdDictionaryCompletedEvent(this, new CreateStdDictionaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.DeleteStdDictionary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteStdDictionary(string AID, ref bool DeleteStdDictionaryResult, [XmlIgnore] ref bool DeleteStdDictionaryResultSpecified)
		{
			object[] array = this.Invoke("DeleteStdDictionary", new object[]
			{
				AID
			});
			DeleteStdDictionaryResult = Conversions.ToBoolean(array[0]);
			DeleteStdDictionaryResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteStdDictionaryAsync(string AID)
		{
			this.DeleteStdDictionaryAsync(AID, null);
		}

		public void DeleteStdDictionaryAsync(string AID, object userState)
		{
			if (this.DeleteStdDictionaryOperationCompleted == null)
			{
				this.DeleteStdDictionaryOperationCompleted = new SendOrPostCallback(this.OnDeleteStdDictionaryOperationCompleted);
			}
			this.InvokeAsync("DeleteStdDictionary", new object[]
			{
				AID
			}, this.DeleteStdDictionaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteStdDictionaryOperationCompleted(object arg)
		{
			if (this.DeleteStdDictionaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteStdDictionaryCompletedEventHandler deleteStdDictionaryCompletedEvent = this.DeleteStdDictionaryCompletedEvent;
				if (deleteStdDictionaryCompletedEvent != null)
				{
					deleteStdDictionaryCompletedEvent(this, new DeleteStdDictionaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.DeleteStdQueryTempGlobal", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteStdQueryTempGlobal(string ASessionID)
		{
			this.Invoke("DeleteStdQueryTempGlobal", new object[]
			{
				ASessionID
			});
		}

		public void DeleteStdQueryTempGlobalAsync(string ASessionID)
		{
			this.DeleteStdQueryTempGlobalAsync(ASessionID, null);
		}

		public void DeleteStdQueryTempGlobalAsync(string ASessionID, object userState)
		{
			if (this.DeleteStdQueryTempGlobalOperationCompleted == null)
			{
				this.DeleteStdQueryTempGlobalOperationCompleted = new SendOrPostCallback(this.OnDeleteStdQueryTempGlobalOperationCompleted);
			}
			this.InvokeAsync("DeleteStdQueryTempGlobal", new object[]
			{
				ASessionID
			}, this.DeleteStdQueryTempGlobalOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteStdQueryTempGlobalOperationCompleted(object arg)
		{
			if (this.DeleteStdQueryTempGlobalCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteStdQueryTempGlobalCompletedEventHandler deleteStdQueryTempGlobalCompletedEvent = this.DeleteStdQueryTempGlobalCompletedEvent;
				if (deleteStdQueryTempGlobalCompletedEvent != null)
				{
					deleteStdQueryTempGlobalCompletedEvent(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.GetStdDicList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetStdDicList(string ADicCode, string AAias, string Acode, string ADesc, long APageNum, [XmlIgnore] bool APageNumSpecified, long ARowCount, [XmlIgnore] bool ARowCountSpecified)
		{
			object[] array = this.Invoke("GetStdDicList", new object[]
			{
				ADicCode,
				AAias,
				Acode,
				ADesc,
				APageNum,
				APageNumSpecified,
				ARowCount,
				ARowCountSpecified
			});
			return (DataSet)array[0];
		}

		public void GetStdDicListAsync(string ADicCode, string AAias, string Acode, string ADesc, long APageNum, bool APageNumSpecified, long ARowCount, bool ARowCountSpecified)
		{
			this.GetStdDicListAsync(ADicCode, AAias, Acode, ADesc, APageNum, APageNumSpecified, ARowCount, ARowCountSpecified, null);
		}

		public void GetStdDicListAsync(string ADicCode, string AAias, string Acode, string ADesc, long APageNum, bool APageNumSpecified, long ARowCount, bool ARowCountSpecified, object userState)
		{
			if (this.GetStdDicListOperationCompleted == null)
			{
				this.GetStdDicListOperationCompleted = new SendOrPostCallback(this.OnGetStdDicListOperationCompleted);
			}
			this.InvokeAsync("GetStdDicList", new object[]
			{
				ADicCode,
				AAias,
				Acode,
				ADesc,
				APageNum,
				APageNumSpecified,
				ARowCount,
				ARowCountSpecified
			}, this.GetStdDicListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetStdDicListOperationCompleted(object arg)
		{
			if (this.GetStdDicListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetStdDicListCompletedEventHandler getStdDicListCompletedEvent = this.GetStdDicListCompletedEvent;
				if (getStdDicListCompletedEvent != null)
				{
					getStdDicListCompletedEvent(this, new GetStdDicListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.GetStdDicOrList", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EStdDicOrListDataset GetStdDicOrList(string ADicCode, string AItem, long APageNum, [XmlIgnore] bool APageNumSpecified, long ARowCount, [XmlIgnore] bool ARowCountSpecified, string CountFlag, ref string AResultCount, ref string SessionId, string AConditionCode, string ACondition)
		{
			object[] array = this.Invoke("GetStdDicOrList", new object[]
			{
				ADicCode,
				AItem,
				APageNum,
				APageNumSpecified,
				ARowCount,
				ARowCountSpecified,
				CountFlag,
				AResultCount,
				SessionId,
				AConditionCode,
				ACondition
			});
			AResultCount = Conversions.ToString(array[1]);
			SessionId = Conversions.ToString(array[2]);
			return (EStdDicOrListDataset)array[0];
		}

		public void GetStdDicOrListAsync(string ADicCode, string AItem, long APageNum, bool APageNumSpecified, long ARowCount, bool ARowCountSpecified, string CountFlag, string AResultCount, string SessionId, string AConditionCode, string ACondition)
		{
			this.GetStdDicOrListAsync(ADicCode, AItem, APageNum, APageNumSpecified, ARowCount, ARowCountSpecified, CountFlag, AResultCount, SessionId, AConditionCode, ACondition, null);
		}

		public void GetStdDicOrListAsync(string ADicCode, string AItem, long APageNum, bool APageNumSpecified, long ARowCount, bool ARowCountSpecified, string CountFlag, string AResultCount, string SessionId, string AConditionCode, string ACondition, object userState)
		{
			if (this.GetStdDicOrListOperationCompleted == null)
			{
				this.GetStdDicOrListOperationCompleted = new SendOrPostCallback(this.OnGetStdDicOrListOperationCompleted);
			}
			this.InvokeAsync("GetStdDicOrList", new object[]
			{
				ADicCode,
				AItem,
				APageNum,
				APageNumSpecified,
				ARowCount,
				ARowCountSpecified,
				CountFlag,
				AResultCount,
				SessionId,
				AConditionCode,
				ACondition
			}, this.GetStdDicOrListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetStdDicOrListOperationCompleted(object arg)
		{
			if (this.GetStdDicOrListCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetStdDicOrListCompletedEventHandler getStdDicOrListCompletedEvent = this.GetStdDicOrListCompletedEvent;
				if (getStdDicOrListCompletedEvent != null)
				{
					getStdDicOrListCompletedEvent(this, new GetStdDicOrListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.GetStdDicPageCount", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GetStdDicPageCount(string ADicCode, string AAias, string ACode, string ADesc, long ARowCount, [XmlIgnore] bool ARowCountSpecified)
		{
			object[] array = this.Invoke("GetStdDicPageCount", new object[]
			{
				ADicCode,
				AAias,
				ACode,
				ADesc,
				ARowCount,
				ARowCountSpecified
			});
			return Conversions.ToString(array[0]);
		}

		public void GetStdDicPageCountAsync(string ADicCode, string AAias, string ACode, string ADesc, long ARowCount, bool ARowCountSpecified)
		{
			this.GetStdDicPageCountAsync(ADicCode, AAias, ACode, ADesc, ARowCount, ARowCountSpecified, null);
		}

		public void GetStdDicPageCountAsync(string ADicCode, string AAias, string ACode, string ADesc, long ARowCount, bool ARowCountSpecified, object userState)
		{
			if (this.GetStdDicPageCountOperationCompleted == null)
			{
				this.GetStdDicPageCountOperationCompleted = new SendOrPostCallback(this.OnGetStdDicPageCountOperationCompleted);
			}
			this.InvokeAsync("GetStdDicPageCount", new object[]
			{
				ADicCode,
				AAias,
				ACode,
				ADesc,
				ARowCount,
				ARowCountSpecified
			}, this.GetStdDicPageCountOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetStdDicPageCountOperationCompleted(object arg)
		{
			if (this.GetStdDicPageCountCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetStdDicPageCountCompletedEventHandler getStdDicPageCountCompletedEvent = this.GetStdDicPageCountCompletedEvent;
				if (getStdDicPageCountCompletedEvent != null)
				{
					getStdDicPageCountCompletedEvent(this, new GetStdDicPageCountCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.GetStdDicitonaryByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EStdDictionary GetStdDicitonaryByID(string AID)
		{
			object[] array = this.Invoke("GetStdDicitonaryByID", new object[]
			{
				AID
			});
			return (EStdDictionary)array[0];
		}

		public void GetStdDicitonaryByIDAsync(string AID)
		{
			this.GetStdDicitonaryByIDAsync(AID, null);
		}

		public void GetStdDicitonaryByIDAsync(string AID, object userState)
		{
			if (this.GetStdDicitonaryByIDOperationCompleted == null)
			{
				this.GetStdDicitonaryByIDOperationCompleted = new SendOrPostCallback(this.OnGetStdDicitonaryByIDOperationCompleted);
			}
			this.InvokeAsync("GetStdDicitonaryByID", new object[]
			{
				AID
			}, this.GetStdDicitonaryByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetStdDicitonaryByIDOperationCompleted(object arg)
		{
			if (this.GetStdDicitonaryByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetStdDicitonaryByIDCompletedEventHandler getStdDicitonaryByIDCompletedEvent = this.GetStdDicitonaryByIDCompletedEvent;
				if (getStdDicitonaryByIDCompletedEvent != null)
				{
					getStdDicitonaryByIDCompletedEvent(this, new GetStdDicitonaryByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.SelectALLStdDic", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EStdDictionaryDataset SelectALLStdDic()
		{
			object[] array = this.Invoke("SelectALLStdDic", new object[0]);
			return (EStdDictionaryDataset)array[0];
		}

		public void SelectALLStdDicAsync()
		{
			this.SelectALLStdDicAsync(null);
		}

		public void SelectALLStdDicAsync(object userState)
		{
			if (this.SelectALLStdDicOperationCompleted == null)
			{
				this.SelectALLStdDicOperationCompleted = new SendOrPostCallback(this.OnSelectALLStdDicOperationCompleted);
			}
			this.InvokeAsync("SelectALLStdDic", new object[0], this.SelectALLStdDicOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectALLStdDicOperationCompleted(object arg)
		{
			if (this.SelectALLStdDicCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectALLStdDicCompletedEventHandler selectALLStdDicCompletedEvent = this.SelectALLStdDicCompletedEvent;
				if (selectALLStdDicCompletedEvent != null)
				{
					selectALLStdDicCompletedEvent(this, new SelectALLStdDicCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.SelectConditionByStdCode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string SelectConditionByStdCode(string AStdDicCode)
		{
			object[] array = this.Invoke("SelectConditionByStdCode", new object[]
			{
				AStdDicCode
			});
			return Conversions.ToString(array[0]);
		}

		public void SelectConditionByStdCodeAsync(string AStdDicCode)
		{
			this.SelectConditionByStdCodeAsync(AStdDicCode, null);
		}

		public void SelectConditionByStdCodeAsync(string AStdDicCode, object userState)
		{
			if (this.SelectConditionByStdCodeOperationCompleted == null)
			{
				this.SelectConditionByStdCodeOperationCompleted = new SendOrPostCallback(this.OnSelectConditionByStdCodeOperationCompleted);
			}
			this.InvokeAsync("SelectConditionByStdCode", new object[]
			{
				AStdDicCode
			}, this.SelectConditionByStdCodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectConditionByStdCodeOperationCompleted(object arg)
		{
			if (this.SelectConditionByStdCodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectConditionByStdCodeCompletedEventHandler selectConditionByStdCodeCompletedEvent = this.SelectConditionByStdCodeCompletedEvent;
				if (selectConditionByStdCodeCompletedEvent != null)
				{
					selectConditionByStdCodeCompletedEvent(this, new SelectConditionByStdCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.SelectStdDicByRuleTypeTag", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlElement SelectStdDicByRuleTypeTag(string argRuleTypeTag)
		{
			object[] array = this.Invoke("SelectStdDicByRuleTypeTag", new object[]
			{
				argRuleTypeTag
			});
			return (XmlElement)array[0];
		}

		public void SelectStdDicByRuleTypeTagAsync(string argRuleTypeTag)
		{
			this.SelectStdDicByRuleTypeTagAsync(argRuleTypeTag, null);
		}

		public void SelectStdDicByRuleTypeTagAsync(string argRuleTypeTag, object userState)
		{
			if (this.SelectStdDicByRuleTypeTagOperationCompleted == null)
			{
				this.SelectStdDicByRuleTypeTagOperationCompleted = new SendOrPostCallback(this.OnSelectStdDicByRuleTypeTagOperationCompleted);
			}
			this.InvokeAsync("SelectStdDicByRuleTypeTag", new object[]
			{
				argRuleTypeTag
			}, this.SelectStdDicByRuleTypeTagOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnSelectStdDicByRuleTypeTagOperationCompleted(object arg)
		{
			if (this.SelectStdDicByRuleTypeTagCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				SelectStdDicByRuleTypeTagCompletedEventHandler selectStdDicByRuleTypeTagCompletedEvent = this.SelectStdDicByRuleTypeTagCompletedEvent;
				if (selectStdDicByRuleTypeTagCompletedEvent != null)
				{
					selectStdDicByRuleTypeTagCompletedEvent(this, new SelectStdDicByRuleTypeTagCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.UpdateStdDictionary", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateStdDictionary(EStdDictionary AEStdDictionary)
		{
			object[] array = this.Invoke("UpdateStdDictionary", new object[]
			{
				AEStdDictionary
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateStdDictionaryAsync(EStdDictionary AEStdDictionary)
		{
			this.UpdateStdDictionaryAsync(AEStdDictionary, null);
		}

		public void UpdateStdDictionaryAsync(EStdDictionary AEStdDictionary, object userState)
		{
			if (this.UpdateStdDictionaryOperationCompleted == null)
			{
				this.UpdateStdDictionaryOperationCompleted = new SendOrPostCallback(this.OnUpdateStdDictionaryOperationCompleted);
			}
			this.InvokeAsync("UpdateStdDictionary", new object[]
			{
				AEStdDictionary
			}, this.UpdateStdDictionaryOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateStdDictionaryOperationCompleted(object arg)
		{
			if (this.UpdateStdDictionaryCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateStdDictionaryCompletedEventHandler updateStdDictionaryCompletedEvent = this.UpdateStdDictionaryCompletedEvent;
				if (updateStdDictionaryCompletedEvent != null)
				{
					updateStdDictionaryCompletedEvent(this, new UpdateStdDictionaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOStdDictionary.icdtest", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string icdtest(string argTarget)
		{
			object[] array = this.Invoke("icdtest", new object[]
			{
				argTarget
			});
			return Conversions.ToString(array[0]);
		}

		public void icdtestAsync(string argTarget)
		{
			this.icdtestAsync(argTarget, null);
		}

		public void icdtestAsync(string argTarget, object userState)
		{
			if (this.icdtestOperationCompleted == null)
			{
				this.icdtestOperationCompleted = new SendOrPostCallback(this.OnicdtestOperationCompleted);
			}
			this.InvokeAsync("icdtest", new object[]
			{
				argTarget
			}, this.icdtestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnicdtestOperationCompleted(object arg)
		{
			if (this.icdtestCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				icdtestCompletedEventHandler icdtestCompletedEventHandler = this.icdtestCompletedEvent;
				if (icdtestCompletedEventHandler != null)
				{
					icdtestCompletedEventHandler(this, new icdtestCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
