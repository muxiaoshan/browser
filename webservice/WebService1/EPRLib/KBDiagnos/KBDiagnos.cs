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
using System.Xml.Serialization;

namespace KBDiagnos
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "KBDiagnosSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class KBDiagnos : SoapHttpClientProtocol
	{
		private SendOrPostCallback AddKBDiagnosOperationCompleted;

		private SendOrPostCallback DelKBDiagnosOperationCompleted;

		private SendOrPostCallback GetAllDiagnosOperationCompleted;

		private SendOrPostCallback GetDiagnosByCtLocIDOperationCompleted;

		private SendOrPostCallback GetDiagnosByIDOperationCompleted;

		private SendOrPostCallback ModKBDiagnosOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private AddKBDiagnosCompletedEventHandler AddKBDiagnosCompletedEvent;

		private DelKBDiagnosCompletedEventHandler DelKBDiagnosCompletedEvent;

		private GetAllDiagnosCompletedEventHandler GetAllDiagnosCompletedEvent;

		private GetDiagnosByCtLocIDCompletedEventHandler GetDiagnosByCtLocIDCompletedEvent;

		private GetDiagnosByIDCompletedEventHandler GetDiagnosByIDCompletedEvent;

		private ModKBDiagnosCompletedEventHandler ModKBDiagnosCompletedEvent;

		public event AddKBDiagnosCompletedEventHandler AddKBDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AddKBDiagnosCompletedEvent = (AddKBDiagnosCompletedEventHandler)Delegate.Combine(this.AddKBDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AddKBDiagnosCompletedEvent = (AddKBDiagnosCompletedEventHandler)Delegate.Remove(this.AddKBDiagnosCompletedEvent, value);
			}
		}

		public event DelKBDiagnosCompletedEventHandler DelKBDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DelKBDiagnosCompletedEvent = (DelKBDiagnosCompletedEventHandler)Delegate.Combine(this.DelKBDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DelKBDiagnosCompletedEvent = (DelKBDiagnosCompletedEventHandler)Delegate.Remove(this.DelKBDiagnosCompletedEvent, value);
			}
		}

		public event GetAllDiagnosCompletedEventHandler GetAllDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetAllDiagnosCompletedEvent = (GetAllDiagnosCompletedEventHandler)Delegate.Combine(this.GetAllDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetAllDiagnosCompletedEvent = (GetAllDiagnosCompletedEventHandler)Delegate.Remove(this.GetAllDiagnosCompletedEvent, value);
			}
		}

		public event GetDiagnosByCtLocIDCompletedEventHandler GetDiagnosByCtLocIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDiagnosByCtLocIDCompletedEvent = (GetDiagnosByCtLocIDCompletedEventHandler)Delegate.Combine(this.GetDiagnosByCtLocIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDiagnosByCtLocIDCompletedEvent = (GetDiagnosByCtLocIDCompletedEventHandler)Delegate.Remove(this.GetDiagnosByCtLocIDCompletedEvent, value);
			}
		}

		public event GetDiagnosByIDCompletedEventHandler GetDiagnosByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetDiagnosByIDCompletedEvent = (GetDiagnosByIDCompletedEventHandler)Delegate.Combine(this.GetDiagnosByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetDiagnosByIDCompletedEvent = (GetDiagnosByIDCompletedEventHandler)Delegate.Remove(this.GetDiagnosByIDCompletedEvent, value);
			}
		}

		public event ModKBDiagnosCompletedEventHandler ModKBDiagnosCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ModKBDiagnosCompletedEvent = (ModKBDiagnosCompletedEventHandler)Delegate.Combine(this.ModKBDiagnosCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ModKBDiagnosCompletedEvent = (ModKBDiagnosCompletedEventHandler)Delegate.Remove(this.ModKBDiagnosCompletedEvent, value);
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

		public KBDiagnos()
		{
			this.Url = MySettings.Default.EPRLib_KBDiagnos_KBDiagnos;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.AddKBDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string AddKBDiagnos(EKBDiagnos AKBDiagnos)
		{
			object[] array = this.Invoke("AddKBDiagnos", new object[]
			{
				AKBDiagnos
			});
			return Conversions.ToString(array[0]);
		}

		public void AddKBDiagnosAsync(EKBDiagnos AKBDiagnos)
		{
			this.AddKBDiagnosAsync(AKBDiagnos, null);
		}

		public void AddKBDiagnosAsync(EKBDiagnos AKBDiagnos, object userState)
		{
			if (this.AddKBDiagnosOperationCompleted == null)
			{
				this.AddKBDiagnosOperationCompleted = new SendOrPostCallback(this.OnAddKBDiagnosOperationCompleted);
			}
			this.InvokeAsync("AddKBDiagnos", new object[]
			{
				AKBDiagnos
			}, this.AddKBDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnAddKBDiagnosOperationCompleted(object arg)
		{
			if (this.AddKBDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				AddKBDiagnosCompletedEventHandler addKBDiagnosCompletedEvent = this.AddKBDiagnosCompletedEvent;
				if (addKBDiagnosCompletedEvent != null)
				{
					addKBDiagnosCompletedEvent(this, new AddKBDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.DelKBDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DelKBDiagnos(string ADiagnosID, ref bool DelKBDiagnosResult, [XmlIgnore] ref bool DelKBDiagnosResultSpecified)
		{
			object[] array = this.Invoke("DelKBDiagnos", new object[]
			{
				ADiagnosID
			});
			DelKBDiagnosResult = Conversions.ToBoolean(array[0]);
			DelKBDiagnosResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DelKBDiagnosAsync(string ADiagnosID)
		{
			this.DelKBDiagnosAsync(ADiagnosID, null);
		}

		public void DelKBDiagnosAsync(string ADiagnosID, object userState)
		{
			if (this.DelKBDiagnosOperationCompleted == null)
			{
				this.DelKBDiagnosOperationCompleted = new SendOrPostCallback(this.OnDelKBDiagnosOperationCompleted);
			}
			this.InvokeAsync("DelKBDiagnos", new object[]
			{
				ADiagnosID
			}, this.DelKBDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDelKBDiagnosOperationCompleted(object arg)
		{
			if (this.DelKBDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DelKBDiagnosCompletedEventHandler delKBDiagnosCompletedEvent = this.DelKBDiagnosCompletedEvent;
				if (delKBDiagnosCompletedEvent != null)
				{
					delKBDiagnosCompletedEvent(this, new DelKBDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.GetAllDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetAllDiagnos()
		{
			object[] array = this.Invoke("GetAllDiagnos", new object[0]);
			return (DataSet)array[0];
		}

		public void GetAllDiagnosAsync()
		{
			this.GetAllDiagnosAsync(null);
		}

		public void GetAllDiagnosAsync(object userState)
		{
			if (this.GetAllDiagnosOperationCompleted == null)
			{
				this.GetAllDiagnosOperationCompleted = new SendOrPostCallback(this.OnGetAllDiagnosOperationCompleted);
			}
			this.InvokeAsync("GetAllDiagnos", new object[0], this.GetAllDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetAllDiagnosOperationCompleted(object arg)
		{
			if (this.GetAllDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetAllDiagnosCompletedEventHandler getAllDiagnosCompletedEvent = this.GetAllDiagnosCompletedEvent;
				if (getAllDiagnosCompletedEvent != null)
				{
					getAllDiagnosCompletedEvent(this, new GetAllDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.GetDiagnosByCtLocID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBDiagnosByCtLocID GetDiagnosByCtLocID(string ACtLocID)
		{
			object[] array = this.Invoke("GetDiagnosByCtLocID", new object[]
			{
				ACtLocID
			});
			return (EKBDiagnosByCtLocID)array[0];
		}

		public void GetDiagnosByCtLocIDAsync(string ACtLocID)
		{
			this.GetDiagnosByCtLocIDAsync(ACtLocID, null);
		}

		public void GetDiagnosByCtLocIDAsync(string ACtLocID, object userState)
		{
			if (this.GetDiagnosByCtLocIDOperationCompleted == null)
			{
				this.GetDiagnosByCtLocIDOperationCompleted = new SendOrPostCallback(this.OnGetDiagnosByCtLocIDOperationCompleted);
			}
			this.InvokeAsync("GetDiagnosByCtLocID", new object[]
			{
				ACtLocID
			}, this.GetDiagnosByCtLocIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDiagnosByCtLocIDOperationCompleted(object arg)
		{
			if (this.GetDiagnosByCtLocIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDiagnosByCtLocIDCompletedEventHandler getDiagnosByCtLocIDCompletedEvent = this.GetDiagnosByCtLocIDCompletedEvent;
				if (getDiagnosByCtLocIDCompletedEvent != null)
				{
					getDiagnosByCtLocIDCompletedEvent(this, new GetDiagnosByCtLocIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.GetDiagnosByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public EKBDiagnos GetDiagnosByID(string ARowID)
		{
			object[] array = this.Invoke("GetDiagnosByID", new object[]
			{
				ARowID
			});
			return (EKBDiagnos)array[0];
		}

		public void GetDiagnosByIDAsync(string ARowID)
		{
			this.GetDiagnosByIDAsync(ARowID, null);
		}

		public void GetDiagnosByIDAsync(string ARowID, object userState)
		{
			if (this.GetDiagnosByIDOperationCompleted == null)
			{
				this.GetDiagnosByIDOperationCompleted = new SendOrPostCallback(this.OnGetDiagnosByIDOperationCompleted);
			}
			this.InvokeAsync("GetDiagnosByID", new object[]
			{
				ARowID
			}, this.GetDiagnosByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetDiagnosByIDOperationCompleted(object arg)
		{
			if (this.GetDiagnosByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetDiagnosByIDCompletedEventHandler getDiagnosByIDCompletedEvent = this.GetDiagnosByIDCompletedEvent;
				if (getDiagnosByIDCompletedEvent != null)
				{
					getDiagnosByIDCompletedEvent(this, new GetDiagnosByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOKBDiagnos.ModKBDiagnos", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void ModKBDiagnos(EKBDiagnos AKBDiagnos, ref bool ModKBDiagnosResult, [XmlIgnore] ref bool ModKBDiagnosResultSpecified)
		{
			object[] array = this.Invoke("ModKBDiagnos", new object[]
			{
				AKBDiagnos
			});
			ModKBDiagnosResult = Conversions.ToBoolean(array[0]);
			ModKBDiagnosResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void ModKBDiagnosAsync(EKBDiagnos AKBDiagnos)
		{
			this.ModKBDiagnosAsync(AKBDiagnos, null);
		}

		public void ModKBDiagnosAsync(EKBDiagnos AKBDiagnos, object userState)
		{
			if (this.ModKBDiagnosOperationCompleted == null)
			{
				this.ModKBDiagnosOperationCompleted = new SendOrPostCallback(this.OnModKBDiagnosOperationCompleted);
			}
			this.InvokeAsync("ModKBDiagnos", new object[]
			{
				AKBDiagnos
			}, this.ModKBDiagnosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnModKBDiagnosOperationCompleted(object arg)
		{
			if (this.ModKBDiagnosCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				ModKBDiagnosCompletedEventHandler modKBDiagnosCompletedEvent = this.ModKBDiagnosCompletedEvent;
				if (modKBDiagnosCompletedEvent != null)
				{
					modKBDiagnosCompletedEvent(this, new ModKBDiagnosCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
