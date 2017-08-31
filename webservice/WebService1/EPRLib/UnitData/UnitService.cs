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

namespace UnitData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "UnitServiceSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class UnitService : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateUnitOperationCompleted;

		private SendOrPostCallback CreateUnitTypeOperationCompleted;

		private SendOrPostCallback DeleteUnitOperationCompleted;

		private SendOrPostCallback DeleteUnitTypeOperationCompleted;

		private SendOrPostCallback GetAllUnitTypeOperationCompleted;

		private SendOrPostCallback GetUnitsOperationCompleted;

		private SendOrPostCallback GetUnitsByCodeOperationCompleted;

		private SendOrPostCallback UpdateUnitOperationCompleted;

		private SendOrPostCallback UpdateUnitTypeOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateUnitCompletedEventHandler CreateUnitCompletedEvent;

		private CreateUnitTypeCompletedEventHandler CreateUnitTypeCompletedEvent;

		private DeleteUnitCompletedEventHandler DeleteUnitCompletedEvent;

		private DeleteUnitTypeCompletedEventHandler DeleteUnitTypeCompletedEvent;

		private GetAllUnitTypeCompletedEventHandler GetAllUnitTypeCompletedEvent;

		private GetUnitsCompletedEventHandler GetUnitsCompletedEvent;

		private GetUnitsByCodeCompletedEventHandler GetUnitsByCodeCompletedEvent;

		private UpdateUnitCompletedEventHandler UpdateUnitCompletedEvent;

		private UpdateUnitTypeCompletedEventHandler UpdateUnitTypeCompletedEvent;

		public event CreateUnitCompletedEventHandler CreateUnitCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateUnitCompletedEvent = (CreateUnitCompletedEventHandler)Delegate.Combine(this.CreateUnitCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateUnitCompletedEvent = (CreateUnitCompletedEventHandler)Delegate.Remove(this.CreateUnitCompletedEvent, value);
			}
		}

		public event CreateUnitTypeCompletedEventHandler CreateUnitTypeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateUnitTypeCompletedEvent = (CreateUnitTypeCompletedEventHandler)Delegate.Combine(this.CreateUnitTypeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateUnitTypeCompletedEvent = (CreateUnitTypeCompletedEventHandler)Delegate.Remove(this.CreateUnitTypeCompletedEvent, value);
			}
		}

		public event DeleteUnitCompletedEventHandler DeleteUnitCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteUnitCompletedEvent = (DeleteUnitCompletedEventHandler)Delegate.Combine(this.DeleteUnitCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteUnitCompletedEvent = (DeleteUnitCompletedEventHandler)Delegate.Remove(this.DeleteUnitCompletedEvent, value);
			}
		}

		public event DeleteUnitTypeCompletedEventHandler DeleteUnitTypeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteUnitTypeCompletedEvent = (DeleteUnitTypeCompletedEventHandler)Delegate.Combine(this.DeleteUnitTypeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteUnitTypeCompletedEvent = (DeleteUnitTypeCompletedEventHandler)Delegate.Remove(this.DeleteUnitTypeCompletedEvent, value);
			}
		}

		public event GetAllUnitTypeCompletedEventHandler GetAllUnitTypeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllUnitTypeCompletedEvent = (GetAllUnitTypeCompletedEventHandler)Delegate.Combine(this.GetAllUnitTypeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllUnitTypeCompletedEvent = (GetAllUnitTypeCompletedEventHandler)Delegate.Remove(this.GetAllUnitTypeCompletedEvent, value);
			}
		}

		public event GetUnitsCompletedEventHandler GetUnitsCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetUnitsCompletedEvent = (GetUnitsCompletedEventHandler)Delegate.Combine(this.GetUnitsCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetUnitsCompletedEvent = (GetUnitsCompletedEventHandler)Delegate.Remove(this.GetUnitsCompletedEvent, value);
			}
		}

		public event GetUnitsByCodeCompletedEventHandler GetUnitsByCodeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetUnitsByCodeCompletedEvent = (GetUnitsByCodeCompletedEventHandler)Delegate.Combine(this.GetUnitsByCodeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetUnitsByCodeCompletedEvent = (GetUnitsByCodeCompletedEventHandler)Delegate.Remove(this.GetUnitsByCodeCompletedEvent, value);
			}
		}

		public event UpdateUnitCompletedEventHandler UpdateUnitCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateUnitCompletedEvent = (UpdateUnitCompletedEventHandler)Delegate.Combine(this.UpdateUnitCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateUnitCompletedEvent = (UpdateUnitCompletedEventHandler)Delegate.Remove(this.UpdateUnitCompletedEvent, value);
			}
		}

		public event UpdateUnitTypeCompletedEventHandler UpdateUnitTypeCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateUnitTypeCompletedEvent = (UpdateUnitTypeCompletedEventHandler)Delegate.Combine(this.UpdateUnitTypeCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateUnitTypeCompletedEvent = (UpdateUnitTypeCompletedEventHandler)Delegate.Remove(this.UpdateUnitTypeCompletedEvent, value);
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

		public UnitService()
		{
			this.Url = MySettings.Default.EPRLib_UnitData_UnitService;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.CreateUnit", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateUnit(EUnit AEUnit)
		{
			object[] array = this.Invoke("CreateUnit", new object[]
			{
				AEUnit
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateUnitAsync(EUnit AEUnit)
		{
			this.CreateUnitAsync(AEUnit, null);
		}

		public void CreateUnitAsync(EUnit AEUnit, object userState)
		{
			if (this.CreateUnitOperationCompleted == null)
			{
				this.CreateUnitOperationCompleted = new SendOrPostCallback(this.OnCreateUnitOperationCompleted);
			}
			this.InvokeAsync("CreateUnit", new object[]
			{
				AEUnit
			}, this.CreateUnitOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateUnitOperationCompleted(object arg)
		{
			if (this.CreateUnitCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateUnitCompletedEventHandler createUnitCompletedEvent = this.CreateUnitCompletedEvent;
				if (createUnitCompletedEvent != null)
				{
					createUnitCompletedEvent(this, new CreateUnitCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.CreateUnitType", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateUnitType(EUnitType AEUnitType)
		{
			object[] array = this.Invoke("CreateUnitType", new object[]
			{
				AEUnitType
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateUnitTypeAsync(EUnitType AEUnitType)
		{
			this.CreateUnitTypeAsync(AEUnitType, null);
		}

		public void CreateUnitTypeAsync(EUnitType AEUnitType, object userState)
		{
			if (this.CreateUnitTypeOperationCompleted == null)
			{
				this.CreateUnitTypeOperationCompleted = new SendOrPostCallback(this.OnCreateUnitTypeOperationCompleted);
			}
			this.InvokeAsync("CreateUnitType", new object[]
			{
				AEUnitType
			}, this.CreateUnitTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateUnitTypeOperationCompleted(object arg)
		{
			if (this.CreateUnitTypeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateUnitTypeCompletedEventHandler createUnitTypeCompletedEvent = this.CreateUnitTypeCompletedEvent;
				if (createUnitTypeCompletedEvent != null)
				{
					createUnitTypeCompletedEvent(this, new CreateUnitTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.DeleteUnit", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteUnit(string AID, ref bool DeleteUnitResult, [XmlIgnore] ref bool DeleteUnitResultSpecified)
		{
			object[] array = this.Invoke("DeleteUnit", new object[]
			{
				AID
			});
			DeleteUnitResult = Conversions.ToBoolean(array[0]);
			DeleteUnitResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteUnitAsync(string AID)
		{
			this.DeleteUnitAsync(AID, null);
		}

		public void DeleteUnitAsync(string AID, object userState)
		{
			if (this.DeleteUnitOperationCompleted == null)
			{
				this.DeleteUnitOperationCompleted = new SendOrPostCallback(this.OnDeleteUnitOperationCompleted);
			}
			this.InvokeAsync("DeleteUnit", new object[]
			{
				AID
			}, this.DeleteUnitOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteUnitOperationCompleted(object arg)
		{
			if (this.DeleteUnitCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteUnitCompletedEventHandler deleteUnitCompletedEvent = this.DeleteUnitCompletedEvent;
				if (deleteUnitCompletedEvent != null)
				{
					deleteUnitCompletedEvent(this, new DeleteUnitCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.DeleteUnitType", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteUnitType(string AID, ref bool DeleteUnitTypeResult, [XmlIgnore] ref bool DeleteUnitTypeResultSpecified)
		{
			object[] array = this.Invoke("DeleteUnitType", new object[]
			{
				AID
			});
			DeleteUnitTypeResult = Conversions.ToBoolean(array[0]);
			DeleteUnitTypeResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteUnitTypeAsync(string AID)
		{
			this.DeleteUnitTypeAsync(AID, null);
		}

		public void DeleteUnitTypeAsync(string AID, object userState)
		{
			if (this.DeleteUnitTypeOperationCompleted == null)
			{
				this.DeleteUnitTypeOperationCompleted = new SendOrPostCallback(this.OnDeleteUnitTypeOperationCompleted);
			}
			this.InvokeAsync("DeleteUnitType", new object[]
			{
				AID
			}, this.DeleteUnitTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteUnitTypeOperationCompleted(object arg)
		{
			if (this.DeleteUnitTypeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteUnitTypeCompletedEventHandler deleteUnitTypeCompletedEvent = this.DeleteUnitTypeCompletedEvent;
				if (deleteUnitTypeCompletedEvent != null)
				{
					deleteUnitTypeCompletedEvent(this, new DeleteUnitTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.GetAllUnitType", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EUnitTypeDataset GetAllUnitType()
		{
			object[] array = this.Invoke("GetAllUnitType", new object[0]);
			return (EUnitTypeDataset)array[0];
		}

		public void GetAllUnitTypeAsync()
		{
			this.GetAllUnitTypeAsync(null);
		}

		public void GetAllUnitTypeAsync(object userState)
		{
			if (this.GetAllUnitTypeOperationCompleted == null)
			{
				this.GetAllUnitTypeOperationCompleted = new SendOrPostCallback(this.OnGetAllUnitTypeOperationCompleted);
			}
			this.InvokeAsync("GetAllUnitType", new object[0], this.GetAllUnitTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllUnitTypeOperationCompleted(object arg)
		{
			if (this.GetAllUnitTypeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllUnitTypeCompletedEventHandler getAllUnitTypeCompletedEvent = this.GetAllUnitTypeCompletedEvent;
				if (getAllUnitTypeCompletedEvent != null)
				{
					getAllUnitTypeCompletedEvent(this, new GetAllUnitTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.GetUnits", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EUnitDataset GetUnits()
		{
			object[] array = this.Invoke("GetUnits", new object[0]);
			return (EUnitDataset)array[0];
		}

		public void GetUnitsAsync()
		{
			this.GetUnitsAsync(null);
		}

		public void GetUnitsAsync(object userState)
		{
			if (this.GetUnitsOperationCompleted == null)
			{
				this.GetUnitsOperationCompleted = new SendOrPostCallback(this.OnGetUnitsOperationCompleted);
			}
			this.InvokeAsync("GetUnits", new object[0], this.GetUnitsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetUnitsOperationCompleted(object arg)
		{
			if (this.GetUnitsCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetUnitsCompletedEventHandler getUnitsCompletedEvent = this.GetUnitsCompletedEvent;
				if (getUnitsCompletedEvent != null)
				{
					getUnitsCompletedEvent(this, new GetUnitsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.GetUnitsByCode", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EUnitByCodeDataset GetUnitsByCode(string ACode)
		{
			object[] array = this.Invoke("GetUnitsByCode", new object[]
			{
				ACode
			});
			return (EUnitByCodeDataset)array[0];
		}

		public void GetUnitsByCodeAsync(string ACode)
		{
			this.GetUnitsByCodeAsync(ACode, null);
		}

		public void GetUnitsByCodeAsync(string ACode, object userState)
		{
			if (this.GetUnitsByCodeOperationCompleted == null)
			{
				this.GetUnitsByCodeOperationCompleted = new SendOrPostCallback(this.OnGetUnitsByCodeOperationCompleted);
			}
			this.InvokeAsync("GetUnitsByCode", new object[]
			{
				ACode
			}, this.GetUnitsByCodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetUnitsByCodeOperationCompleted(object arg)
		{
			if (this.GetUnitsByCodeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetUnitsByCodeCompletedEventHandler getUnitsByCodeCompletedEvent = this.GetUnitsByCodeCompletedEvent;
				if (getUnitsByCodeCompletedEvent != null)
				{
					getUnitsByCodeCompletedEvent(this, new GetUnitsByCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.UpdateUnit", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateUnit(EUnit AEUnit)
		{
			object[] array = this.Invoke("UpdateUnit", new object[]
			{
				AEUnit
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateUnitAsync(EUnit AEUnit)
		{
			this.UpdateUnitAsync(AEUnit, null);
		}

		public void UpdateUnitAsync(EUnit AEUnit, object userState)
		{
			if (this.UpdateUnitOperationCompleted == null)
			{
				this.UpdateUnitOperationCompleted = new SendOrPostCallback(this.OnUpdateUnitOperationCompleted);
			}
			this.InvokeAsync("UpdateUnit", new object[]
			{
				AEUnit
			}, this.UpdateUnitOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateUnitOperationCompleted(object arg)
		{
			if (this.UpdateUnitCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateUnitCompletedEventHandler updateUnitCompletedEvent = this.UpdateUnitCompletedEvent;
				if (updateUnitCompletedEvent != null)
				{
					updateUnitCompletedEvent(this, new UpdateUnitCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOUnitService.UpdateUnitType", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UpdateUnitType(EUnitType AEUnitType)
		{
			object[] array = this.Invoke("UpdateUnitType", new object[]
			{
				AEUnitType
			});
			return Conversions.ToString(array[0]);
		}

		public void UpdateUnitTypeAsync(EUnitType AEUnitType)
		{
			this.UpdateUnitTypeAsync(AEUnitType, null);
		}

		public void UpdateUnitTypeAsync(EUnitType AEUnitType, object userState)
		{
			if (this.UpdateUnitTypeOperationCompleted == null)
			{
				this.UpdateUnitTypeOperationCompleted = new SendOrPostCallback(this.OnUpdateUnitTypeOperationCompleted);
			}
			this.InvokeAsync("UpdateUnitType", new object[]
			{
				AEUnitType
			}, this.UpdateUnitTypeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateUnitTypeOperationCompleted(object arg)
		{
			if (this.UpdateUnitTypeCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateUnitTypeCompletedEventHandler updateUnitTypeCompletedEvent = this.UpdateUnitTypeCompletedEvent;
				if (updateUnitTypeCompletedEvent != null)
				{
					updateUnitTypeCompletedEvent(this, new UpdateUnitTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
