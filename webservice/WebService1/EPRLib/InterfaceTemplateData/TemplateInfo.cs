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

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "TemplateInfoSoap", Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	public class TemplateInfo : SoapHttpClientProtocol
	{
		private SendOrPostCallback CreateCraftVersionOperationCompleted;

		private SendOrPostCallback CreateTemplateOperationCompleted;

		private SendOrPostCallback DelTemplateOperationCompleted;

		private SendOrPostCallback DeleteCraftVersionOperationCompleted;

		private SendOrPostCallback GetInitialDataByIDOperationCompleted;

		private SendOrPostCallback GetInitialDataByTemplateIDOperationCompleted;

		private SendOrPostCallback GetMetadataByIDOperationCompleted;

		private SendOrPostCallback GetMetadataByTemplateIDOperationCompleted;

		private SendOrPostCallback GetPresentationDataByIDOperationCompleted;

		private SendOrPostCallback GetTemplateAllOperationCompleted;

		private SendOrPostCallback GetTemplateAllForSltOperationCompleted;

		private SendOrPostCallback GetTemplateByGUIDOperationCompleted;

		private SendOrPostCallback GetTemplateByIDOperationCompleted;

		private SendOrPostCallback GetTemplateVersionAllOperationCompleted;

		private SendOrPostCallback GetTemplateWithGroupAllOperationCompleted;

		private SendOrPostCallback GetVersionByIDOperationCompleted;

		private SendOrPostCallback GetVersionByTemplateIDOperationCompleted;

		private SendOrPostCallback GuidMap2IDOperationCompleted;

		private SendOrPostCallback IDMap2GuidOperationCompleted;

		private SendOrPostCallback PublishVersionOperationCompleted;

		private SendOrPostCallback TestUpdateVersionOperationCompleted;

		private SendOrPostCallback UpdateCraftVersionOperationCompleted;

		private SendOrPostCallback UpdateTemplateOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		private CreateCraftVersionCompletedEventHandler CreateCraftVersionCompletedEvent;

		private CreateTemplateCompletedEventHandler CreateTemplateCompletedEvent;

		private DelTemplateCompletedEventHandler DelTemplateCompletedEvent;

		private DeleteCraftVersionCompletedEventHandler DeleteCraftVersionCompletedEvent;

		private GetInitialDataByIDCompletedEventHandler GetInitialDataByIDCompletedEvent;

		private GetInitialDataByTemplateIDCompletedEventHandler GetInitialDataByTemplateIDCompletedEvent;

		private GetMetadataByIDCompletedEventHandler GetMetadataByIDCompletedEvent;

		private GetMetadataByTemplateIDCompletedEventHandler GetMetadataByTemplateIDCompletedEvent;

		private GetPresentationDataByIDCompletedEventHandler GetPresentationDataByIDCompletedEvent;

		private GetTemplateAllCompletedEventHandler GetTemplateAllCompletedEvent;

		private GetTemplateAllForSltCompletedEventHandler GetTemplateAllForSltCompletedEvent;

		private GetTemplateByGUIDCompletedEventHandler GetTemplateByGUIDCompletedEvent;

		private GetTemplateByIDCompletedEventHandler GetTemplateByIDCompletedEvent;

		private GetTemplateVersionAllCompletedEventHandler GetTemplateVersionAllCompletedEvent;

		private GetTemplateWithGroupAllCompletedEventHandler GetTemplateWithGroupAllCompletedEvent;

		private GetVersionByIDCompletedEventHandler GetVersionByIDCompletedEvent;

		private GetVersionByTemplateIDCompletedEventHandler GetVersionByTemplateIDCompletedEvent;

		private GuidMap2IDCompletedEventHandler GuidMap2IDCompletedEvent;

		private IDMap2GuidCompletedEventHandler IDMap2GuidCompletedEvent;

		private PublishVersionCompletedEventHandler PublishVersionCompletedEvent;

		private TestUpdateVersionCompletedEventHandler TestUpdateVersionCompletedEvent;

		private UpdateCraftVersionCompletedEventHandler UpdateCraftVersionCompletedEvent;

		private UpdateTemplateCompletedEventHandler UpdateTemplateCompletedEvent;

		public event CreateCraftVersionCompletedEventHandler CreateCraftVersionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateCraftVersionCompletedEvent = (CreateCraftVersionCompletedEventHandler)Delegate.Combine(this.CreateCraftVersionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateCraftVersionCompletedEvent = (CreateCraftVersionCompletedEventHandler)Delegate.Remove(this.CreateCraftVersionCompletedEvent, value);
			}
		}

		public event CreateTemplateCompletedEventHandler CreateTemplateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CreateTemplateCompletedEvent = (CreateTemplateCompletedEventHandler)Delegate.Combine(this.CreateTemplateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CreateTemplateCompletedEvent = (CreateTemplateCompletedEventHandler)Delegate.Remove(this.CreateTemplateCompletedEvent, value);
			}
		}

		public event DelTemplateCompletedEventHandler DelTemplateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DelTemplateCompletedEvent = (DelTemplateCompletedEventHandler)Delegate.Combine(this.DelTemplateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DelTemplateCompletedEvent = (DelTemplateCompletedEventHandler)Delegate.Remove(this.DelTemplateCompletedEvent, value);
			}
		}

		public event DeleteCraftVersionCompletedEventHandler DeleteCraftVersionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DeleteCraftVersionCompletedEvent = (DeleteCraftVersionCompletedEventHandler)Delegate.Combine(this.DeleteCraftVersionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DeleteCraftVersionCompletedEvent = (DeleteCraftVersionCompletedEventHandler)Delegate.Remove(this.DeleteCraftVersionCompletedEvent, value);
			}
		}

		public event GetInitialDataByIDCompletedEventHandler GetInitialDataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetInitialDataByIDCompletedEvent = (GetInitialDataByIDCompletedEventHandler)Delegate.Combine(this.GetInitialDataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetInitialDataByIDCompletedEvent = (GetInitialDataByIDCompletedEventHandler)Delegate.Remove(this.GetInitialDataByIDCompletedEvent, value);
			}
		}

		public event GetInitialDataByTemplateIDCompletedEventHandler GetInitialDataByTemplateIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetInitialDataByTemplateIDCompletedEvent = (GetInitialDataByTemplateIDCompletedEventHandler)Delegate.Combine(this.GetInitialDataByTemplateIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetInitialDataByTemplateIDCompletedEvent = (GetInitialDataByTemplateIDCompletedEventHandler)Delegate.Remove(this.GetInitialDataByTemplateIDCompletedEvent, value);
			}
		}

		public event GetMetadataByIDCompletedEventHandler GetMetadataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetMetadataByIDCompletedEvent = (GetMetadataByIDCompletedEventHandler)Delegate.Combine(this.GetMetadataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetMetadataByIDCompletedEvent = (GetMetadataByIDCompletedEventHandler)Delegate.Remove(this.GetMetadataByIDCompletedEvent, value);
			}
		}

		public event GetMetadataByTemplateIDCompletedEventHandler GetMetadataByTemplateIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetMetadataByTemplateIDCompletedEvent = (GetMetadataByTemplateIDCompletedEventHandler)Delegate.Combine(this.GetMetadataByTemplateIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetMetadataByTemplateIDCompletedEvent = (GetMetadataByTemplateIDCompletedEventHandler)Delegate.Remove(this.GetMetadataByTemplateIDCompletedEvent, value);
			}
		}

		public event GetPresentationDataByIDCompletedEventHandler GetPresentationDataByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetPresentationDataByIDCompletedEvent = (GetPresentationDataByIDCompletedEventHandler)Delegate.Combine(this.GetPresentationDataByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetPresentationDataByIDCompletedEvent = (GetPresentationDataByIDCompletedEventHandler)Delegate.Remove(this.GetPresentationDataByIDCompletedEvent, value);
			}
		}

		public event GetTemplateAllCompletedEventHandler GetTemplateAllCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateAllCompletedEvent = (GetTemplateAllCompletedEventHandler)Delegate.Combine(this.GetTemplateAllCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateAllCompletedEvent = (GetTemplateAllCompletedEventHandler)Delegate.Remove(this.GetTemplateAllCompletedEvent, value);
			}
		}

		public event GetTemplateAllForSltCompletedEventHandler GetTemplateAllForSltCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateAllForSltCompletedEvent = (GetTemplateAllForSltCompletedEventHandler)Delegate.Combine(this.GetTemplateAllForSltCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateAllForSltCompletedEvent = (GetTemplateAllForSltCompletedEventHandler)Delegate.Remove(this.GetTemplateAllForSltCompletedEvent, value);
			}
		}

		public event GetTemplateByGUIDCompletedEventHandler GetTemplateByGUIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateByGUIDCompletedEvent = (GetTemplateByGUIDCompletedEventHandler)Delegate.Combine(this.GetTemplateByGUIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateByGUIDCompletedEvent = (GetTemplateByGUIDCompletedEventHandler)Delegate.Remove(this.GetTemplateByGUIDCompletedEvent, value);
			}
		}

		public event GetTemplateByIDCompletedEventHandler GetTemplateByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateByIDCompletedEvent = (GetTemplateByIDCompletedEventHandler)Delegate.Combine(this.GetTemplateByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateByIDCompletedEvent = (GetTemplateByIDCompletedEventHandler)Delegate.Remove(this.GetTemplateByIDCompletedEvent, value);
			}
		}

		public event GetTemplateVersionAllCompletedEventHandler GetTemplateVersionAllCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateVersionAllCompletedEvent = (GetTemplateVersionAllCompletedEventHandler)Delegate.Combine(this.GetTemplateVersionAllCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateVersionAllCompletedEvent = (GetTemplateVersionAllCompletedEventHandler)Delegate.Remove(this.GetTemplateVersionAllCompletedEvent, value);
			}
		}

		public event GetTemplateWithGroupAllCompletedEventHandler GetTemplateWithGroupAllCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetTemplateWithGroupAllCompletedEvent = (GetTemplateWithGroupAllCompletedEventHandler)Delegate.Combine(this.GetTemplateWithGroupAllCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetTemplateWithGroupAllCompletedEvent = (GetTemplateWithGroupAllCompletedEventHandler)Delegate.Remove(this.GetTemplateWithGroupAllCompletedEvent, value);
			}
		}

		public event GetVersionByIDCompletedEventHandler GetVersionByIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetVersionByIDCompletedEvent = (GetVersionByIDCompletedEventHandler)Delegate.Combine(this.GetVersionByIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetVersionByIDCompletedEvent = (GetVersionByIDCompletedEventHandler)Delegate.Remove(this.GetVersionByIDCompletedEvent, value);
			}
		}

		public event GetVersionByTemplateIDCompletedEventHandler GetVersionByTemplateIDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GetVersionByTemplateIDCompletedEvent = (GetVersionByTemplateIDCompletedEventHandler)Delegate.Combine(this.GetVersionByTemplateIDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GetVersionByTemplateIDCompletedEvent = (GetVersionByTemplateIDCompletedEventHandler)Delegate.Remove(this.GetVersionByTemplateIDCompletedEvent, value);
			}
		}

		public event GuidMap2IDCompletedEventHandler GuidMap2IDCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.GuidMap2IDCompletedEvent = (GuidMap2IDCompletedEventHandler)Delegate.Combine(this.GuidMap2IDCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.GuidMap2IDCompletedEvent = (GuidMap2IDCompletedEventHandler)Delegate.Remove(this.GuidMap2IDCompletedEvent, value);
			}
		}

		public event IDMap2GuidCompletedEventHandler IDMap2GuidCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.IDMap2GuidCompletedEvent = (IDMap2GuidCompletedEventHandler)Delegate.Combine(this.IDMap2GuidCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.IDMap2GuidCompletedEvent = (IDMap2GuidCompletedEventHandler)Delegate.Remove(this.IDMap2GuidCompletedEvent, value);
			}
		}

		public event PublishVersionCompletedEventHandler PublishVersionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.PublishVersionCompletedEvent = (PublishVersionCompletedEventHandler)Delegate.Combine(this.PublishVersionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.PublishVersionCompletedEvent = (PublishVersionCompletedEventHandler)Delegate.Remove(this.PublishVersionCompletedEvent, value);
			}
		}

		public event TestUpdateVersionCompletedEventHandler TestUpdateVersionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.TestUpdateVersionCompletedEvent = (TestUpdateVersionCompletedEventHandler)Delegate.Combine(this.TestUpdateVersionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.TestUpdateVersionCompletedEvent = (TestUpdateVersionCompletedEventHandler)Delegate.Remove(this.TestUpdateVersionCompletedEvent, value);
			}
		}

		public event UpdateCraftVersionCompletedEventHandler UpdateCraftVersionCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateCraftVersionCompletedEvent = (UpdateCraftVersionCompletedEventHandler)Delegate.Combine(this.UpdateCraftVersionCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateCraftVersionCompletedEvent = (UpdateCraftVersionCompletedEventHandler)Delegate.Remove(this.UpdateCraftVersionCompletedEvent, value);
			}
		}

		public event UpdateTemplateCompletedEventHandler UpdateTemplateCompleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.UpdateTemplateCompletedEvent = (UpdateTemplateCompletedEventHandler)Delegate.Combine(this.UpdateTemplateCompletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.UpdateTemplateCompletedEvent = (UpdateTemplateCompletedEventHandler)Delegate.Remove(this.UpdateTemplateCompletedEvent, value);
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

		public TemplateInfo()
		{
			this.Url = MySettings.Default.EPRLib_InterfaceTemplateData_TemplateInfo;
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

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.CreateCraftVersion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion CreateCraftVersion(ETemplateVersion AVersion)
		{
			object[] array = this.Invoke("CreateCraftVersion", new object[]
			{
				AVersion
			});
			return (ETemplateVersion)array[0];
		}

		public void CreateCraftVersionAsync(ETemplateVersion AVersion)
		{
			this.CreateCraftVersionAsync(AVersion, null);
		}

		public void CreateCraftVersionAsync(ETemplateVersion AVersion, object userState)
		{
			if (this.CreateCraftVersionOperationCompleted == null)
			{
				this.CreateCraftVersionOperationCompleted = new SendOrPostCallback(this.OnCreateCraftVersionOperationCompleted);
			}
			this.InvokeAsync("CreateCraftVersion", new object[]
			{
				AVersion
			}, this.CreateCraftVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateCraftVersionOperationCompleted(object arg)
		{
			if (this.CreateCraftVersionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateCraftVersionCompletedEventHandler createCraftVersionCompletedEvent = this.CreateCraftVersionCompletedEvent;
				if (createCraftVersionCompletedEvent != null)
				{
					createCraftVersionCompletedEvent(this, new CreateCraftVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.CreateTemplate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CreateTemplate(ETemplate ATemplate)
		{
			object[] array = this.Invoke("CreateTemplate", new object[]
			{
				ATemplate
			});
			return Conversions.ToString(array[0]);
		}

		public void CreateTemplateAsync(ETemplate ATemplate)
		{
			this.CreateTemplateAsync(ATemplate, null);
		}

		public void CreateTemplateAsync(ETemplate ATemplate, object userState)
		{
			if (this.CreateTemplateOperationCompleted == null)
			{
				this.CreateTemplateOperationCompleted = new SendOrPostCallback(this.OnCreateTemplateOperationCompleted);
			}
			this.InvokeAsync("CreateTemplate", new object[]
			{
				ATemplate
			}, this.CreateTemplateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnCreateTemplateOperationCompleted(object arg)
		{
			if (this.CreateTemplateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				CreateTemplateCompletedEventHandler createTemplateCompletedEvent = this.CreateTemplateCompletedEvent;
				if (createTemplateCompletedEvent != null)
				{
					createTemplateCompletedEvent(this, new CreateTemplateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.DelTemplate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DelTemplate(string AID, ref bool DelTemplateResult, [XmlIgnore] ref bool DelTemplateResultSpecified)
		{
			object[] array = this.Invoke("DelTemplate", new object[]
			{
				AID
			});
			DelTemplateResult = Conversions.ToBoolean(array[0]);
			DelTemplateResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DelTemplateAsync(string AID)
		{
			this.DelTemplateAsync(AID, null);
		}

		public void DelTemplateAsync(string AID, object userState)
		{
			if (this.DelTemplateOperationCompleted == null)
			{
				this.DelTemplateOperationCompleted = new SendOrPostCallback(this.OnDelTemplateOperationCompleted);
			}
			this.InvokeAsync("DelTemplate", new object[]
			{
				AID
			}, this.DelTemplateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDelTemplateOperationCompleted(object arg)
		{
			if (this.DelTemplateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DelTemplateCompletedEventHandler delTemplateCompletedEvent = this.DelTemplateCompletedEvent;
				if (delTemplateCompletedEvent != null)
				{
					delTemplateCompletedEvent(this, new DelTemplateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.DeleteCraftVersion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void DeleteCraftVersion(string AID, ref bool DeleteCraftVersionResult, [XmlIgnore] ref bool DeleteCraftVersionResultSpecified)
		{
			object[] array = this.Invoke("DeleteCraftVersion", new object[]
			{
				AID
			});
			DeleteCraftVersionResult = Conversions.ToBoolean(array[0]);
			DeleteCraftVersionResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void DeleteCraftVersionAsync(string AID)
		{
			this.DeleteCraftVersionAsync(AID, null);
		}

		public void DeleteCraftVersionAsync(string AID, object userState)
		{
			if (this.DeleteCraftVersionOperationCompleted == null)
			{
				this.DeleteCraftVersionOperationCompleted = new SendOrPostCallback(this.OnDeleteCraftVersionOperationCompleted);
			}
			this.InvokeAsync("DeleteCraftVersion", new object[]
			{
				AID
			}, this.DeleteCraftVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnDeleteCraftVersionOperationCompleted(object arg)
		{
			if (this.DeleteCraftVersionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				DeleteCraftVersionCompletedEventHandler deleteCraftVersionCompletedEvent = this.DeleteCraftVersionCompletedEvent;
				if (deleteCraftVersionCompletedEvent != null)
				{
					deleteCraftVersionCompletedEvent(this, new DeleteCraftVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetInitialDataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetInitialDataByID(string AID)
		{
			object[] array = this.Invoke("GetInitialDataByID", new object[]
			{
				AID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetInitialDataByIDAsync(string AID)
		{
			this.GetInitialDataByIDAsync(AID, null);
		}

		public void GetInitialDataByIDAsync(string AID, object userState)
		{
			if (this.GetInitialDataByIDOperationCompleted == null)
			{
				this.GetInitialDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetInitialDataByIDOperationCompleted);
			}
			this.InvokeAsync("GetInitialDataByID", new object[]
			{
				AID
			}, this.GetInitialDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetInitialDataByIDOperationCompleted(object arg)
		{
			if (this.GetInitialDataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetInitialDataByIDCompletedEventHandler getInitialDataByIDCompletedEvent = this.GetInitialDataByIDCompletedEvent;
				if (getInitialDataByIDCompletedEvent != null)
				{
					getInitialDataByIDCompletedEvent(this, new GetInitialDataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetInitialDataByTemplateID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetInitialDataByTemplateID(string ATemplateID)
		{
			object[] array = this.Invoke("GetInitialDataByTemplateID", new object[]
			{
				ATemplateID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetInitialDataByTemplateIDAsync(string ATemplateID)
		{
			this.GetInitialDataByTemplateIDAsync(ATemplateID, null);
		}

		public void GetInitialDataByTemplateIDAsync(string ATemplateID, object userState)
		{
			if (this.GetInitialDataByTemplateIDOperationCompleted == null)
			{
				this.GetInitialDataByTemplateIDOperationCompleted = new SendOrPostCallback(this.OnGetInitialDataByTemplateIDOperationCompleted);
			}
			this.InvokeAsync("GetInitialDataByTemplateID", new object[]
			{
				ATemplateID
			}, this.GetInitialDataByTemplateIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetInitialDataByTemplateIDOperationCompleted(object arg)
		{
			if (this.GetInitialDataByTemplateIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetInitialDataByTemplateIDCompletedEventHandler getInitialDataByTemplateIDCompletedEvent = this.GetInitialDataByTemplateIDCompletedEvent;
				if (getInitialDataByTemplateIDCompletedEvent != null)
				{
					getInitialDataByTemplateIDCompletedEvent(this, new GetInitialDataByTemplateIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetMetadataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetMetadataByID(string AID)
		{
			object[] array = this.Invoke("GetMetadataByID", new object[]
			{
				AID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetMetadataByIDAsync(string AID)
		{
			this.GetMetadataByIDAsync(AID, null);
		}

		public void GetMetadataByIDAsync(string AID, object userState)
		{
			if (this.GetMetadataByIDOperationCompleted == null)
			{
				this.GetMetadataByIDOperationCompleted = new SendOrPostCallback(this.OnGetMetadataByIDOperationCompleted);
			}
			this.InvokeAsync("GetMetadataByID", new object[]
			{
				AID
			}, this.GetMetadataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetMetadataByIDOperationCompleted(object arg)
		{
			if (this.GetMetadataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetMetadataByIDCompletedEventHandler getMetadataByIDCompletedEvent = this.GetMetadataByIDCompletedEvent;
				if (getMetadataByIDCompletedEvent != null)
				{
					getMetadataByIDCompletedEvent(this, new GetMetadataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetMetadataByTemplateID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetMetadataByTemplateID(string ATemplateID)
		{
			object[] array = this.Invoke("GetMetadataByTemplateID", new object[]
			{
				ATemplateID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetMetadataByTemplateIDAsync(string ATemplateID)
		{
			this.GetMetadataByTemplateIDAsync(ATemplateID, null);
		}

		public void GetMetadataByTemplateIDAsync(string ATemplateID, object userState)
		{
			if (this.GetMetadataByTemplateIDOperationCompleted == null)
			{
				this.GetMetadataByTemplateIDOperationCompleted = new SendOrPostCallback(this.OnGetMetadataByTemplateIDOperationCompleted);
			}
			this.InvokeAsync("GetMetadataByTemplateID", new object[]
			{
				ATemplateID
			}, this.GetMetadataByTemplateIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetMetadataByTemplateIDOperationCompleted(object arg)
		{
			if (this.GetMetadataByTemplateIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetMetadataByTemplateIDCompletedEventHandler getMetadataByTemplateIDCompletedEvent = this.GetMetadataByTemplateIDCompletedEvent;
				if (getMetadataByTemplateIDCompletedEvent != null)
				{
					getMetadataByTemplateIDCompletedEvent(this, new GetMetadataByTemplateIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetPresentationDataByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetPresentationDataByID(string AID)
		{
			object[] array = this.Invoke("GetPresentationDataByID", new object[]
			{
				AID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetPresentationDataByIDAsync(string AID)
		{
			this.GetPresentationDataByIDAsync(AID, null);
		}

		public void GetPresentationDataByIDAsync(string AID, object userState)
		{
			if (this.GetPresentationDataByIDOperationCompleted == null)
			{
				this.GetPresentationDataByIDOperationCompleted = new SendOrPostCallback(this.OnGetPresentationDataByIDOperationCompleted);
			}
			this.InvokeAsync("GetPresentationDataByID", new object[]
			{
				AID
			}, this.GetPresentationDataByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetPresentationDataByIDOperationCompleted(object arg)
		{
			if (this.GetPresentationDataByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetPresentationDataByIDCompletedEventHandler getPresentationDataByIDCompletedEvent = this.GetPresentationDataByIDCompletedEvent;
				if (getPresentationDataByIDCompletedEvent != null)
				{
					getPresentationDataByIDCompletedEvent(this, new GetPresentationDataByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateAll", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateDataset GetTemplateAll(string ACategoryID)
		{
			object[] array = this.Invoke("GetTemplateAll", new object[]
			{
				ACategoryID
			});
			return (ETemplateDataset)array[0];
		}

		public void GetTemplateAllAsync(string ACategoryID)
		{
			this.GetTemplateAllAsync(ACategoryID, null);
		}

		public void GetTemplateAllAsync(string ACategoryID, object userState)
		{
			if (this.GetTemplateAllOperationCompleted == null)
			{
				this.GetTemplateAllOperationCompleted = new SendOrPostCallback(this.OnGetTemplateAllOperationCompleted);
			}
			this.InvokeAsync("GetTemplateAll", new object[]
			{
				ACategoryID
			}, this.GetTemplateAllOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateAllOperationCompleted(object arg)
		{
			if (this.GetTemplateAllCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateAllCompletedEventHandler getTemplateAllCompletedEvent = this.GetTemplateAllCompletedEvent;
				if (getTemplateAllCompletedEvent != null)
				{
					getTemplateAllCompletedEvent(this, new GetTemplateAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateAllForSlt", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETempForSltDataset GetTemplateAllForSlt(string ACategoryID, string AEpisodeID)
		{
			object[] array = this.Invoke("GetTemplateAllForSlt", new object[]
			{
				ACategoryID,
				AEpisodeID
			});
			return (ETempForSltDataset)array[0];
		}

		public void GetTemplateAllForSltAsync(string ACategoryID, string AEpisodeID)
		{
			this.GetTemplateAllForSltAsync(ACategoryID, AEpisodeID, null);
		}

		public void GetTemplateAllForSltAsync(string ACategoryID, string AEpisodeID, object userState)
		{
			if (this.GetTemplateAllForSltOperationCompleted == null)
			{
				this.GetTemplateAllForSltOperationCompleted = new SendOrPostCallback(this.OnGetTemplateAllForSltOperationCompleted);
			}
			this.InvokeAsync("GetTemplateAllForSlt", new object[]
			{
				ACategoryID,
				AEpisodeID
			}, this.GetTemplateAllForSltOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateAllForSltOperationCompleted(object arg)
		{
			if (this.GetTemplateAllForSltCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateAllForSltCompletedEventHandler getTemplateAllForSltCompletedEvent = this.GetTemplateAllForSltCompletedEvent;
				if (getTemplateAllForSltCompletedEvent != null)
				{
					getTemplateAllForSltCompletedEvent(this, new GetTemplateAllForSltCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateByGUID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplate GetTemplateByGUID(string AGUID)
		{
			object[] array = this.Invoke("GetTemplateByGUID", new object[]
			{
				AGUID
			});
			return (ETemplate)array[0];
		}

		public void GetTemplateByGUIDAsync(string AGUID)
		{
			this.GetTemplateByGUIDAsync(AGUID, null);
		}

		public void GetTemplateByGUIDAsync(string AGUID, object userState)
		{
			if (this.GetTemplateByGUIDOperationCompleted == null)
			{
				this.GetTemplateByGUIDOperationCompleted = new SendOrPostCallback(this.OnGetTemplateByGUIDOperationCompleted);
			}
			this.InvokeAsync("GetTemplateByGUID", new object[]
			{
				AGUID
			}, this.GetTemplateByGUIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateByGUIDOperationCompleted(object arg)
		{
			if (this.GetTemplateByGUIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateByGUIDCompletedEventHandler getTemplateByGUIDCompletedEvent = this.GetTemplateByGUIDCompletedEvent;
				if (getTemplateByGUIDCompletedEvent != null)
				{
					getTemplateByGUIDCompletedEvent(this, new GetTemplateByGUIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplate GetTemplateByID(string AID)
		{
			object[] array = this.Invoke("GetTemplateByID", new object[]
			{
				AID
			});
			return (ETemplate)array[0];
		}

		public void GetTemplateByIDAsync(string AID)
		{
			this.GetTemplateByIDAsync(AID, null);
		}

		public void GetTemplateByIDAsync(string AID, object userState)
		{
			if (this.GetTemplateByIDOperationCompleted == null)
			{
				this.GetTemplateByIDOperationCompleted = new SendOrPostCallback(this.OnGetTemplateByIDOperationCompleted);
			}
			this.InvokeAsync("GetTemplateByID", new object[]
			{
				AID
			}, this.GetTemplateByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateByIDOperationCompleted(object arg)
		{
			if (this.GetTemplateByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateByIDCompletedEventHandler getTemplateByIDCompletedEvent = this.GetTemplateByIDCompletedEvent;
				if (getTemplateByIDCompletedEvent != null)
				{
					getTemplateByIDCompletedEvent(this, new GetTemplateByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateVersionAll", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersionDataset GetTemplateVersionAll(string ATemplateId)
		{
			object[] array = this.Invoke("GetTemplateVersionAll", new object[]
			{
				ATemplateId
			});
			return (ETemplateVersionDataset)array[0];
		}

		public void GetTemplateVersionAllAsync(string ATemplateId)
		{
			this.GetTemplateVersionAllAsync(ATemplateId, null);
		}

		public void GetTemplateVersionAllAsync(string ATemplateId, object userState)
		{
			if (this.GetTemplateVersionAllOperationCompleted == null)
			{
				this.GetTemplateVersionAllOperationCompleted = new SendOrPostCallback(this.OnGetTemplateVersionAllOperationCompleted);
			}
			this.InvokeAsync("GetTemplateVersionAll", new object[]
			{
				ATemplateId
			}, this.GetTemplateVersionAllOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateVersionAllOperationCompleted(object arg)
		{
			if (this.GetTemplateVersionAllCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateVersionAllCompletedEventHandler getTemplateVersionAllCompletedEvent = this.GetTemplateVersionAllCompletedEvent;
				if (getTemplateVersionAllCompletedEvent != null)
				{
					getTemplateVersionAllCompletedEvent(this, new GetTemplateVersionAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetTemplateWithGroupAll", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public DataSet GetTemplateWithGroupAll(string ACategoryID)
		{
			object[] array = this.Invoke("GetTemplateWithGroupAll", new object[]
			{
				ACategoryID
			});
			return (DataSet)array[0];
		}

		public void GetTemplateWithGroupAllAsync(string ACategoryID)
		{
			this.GetTemplateWithGroupAllAsync(ACategoryID, null);
		}

		public void GetTemplateWithGroupAllAsync(string ACategoryID, object userState)
		{
			if (this.GetTemplateWithGroupAllOperationCompleted == null)
			{
				this.GetTemplateWithGroupAllOperationCompleted = new SendOrPostCallback(this.OnGetTemplateWithGroupAllOperationCompleted);
			}
			this.InvokeAsync("GetTemplateWithGroupAll", new object[]
			{
				ACategoryID
			}, this.GetTemplateWithGroupAllOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetTemplateWithGroupAllOperationCompleted(object arg)
		{
			if (this.GetTemplateWithGroupAllCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetTemplateWithGroupAllCompletedEventHandler getTemplateWithGroupAllCompletedEvent = this.GetTemplateWithGroupAllCompletedEvent;
				if (getTemplateWithGroupAllCompletedEvent != null)
				{
					getTemplateWithGroupAllCompletedEvent(this, new GetTemplateWithGroupAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetVersionByID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetVersionByID(string AID, bool ADataFlag, [XmlIgnore] bool ADataFlagSpecified)
		{
			object[] array = this.Invoke("GetVersionByID", new object[]
			{
				AID,
				ADataFlag,
				ADataFlagSpecified
			});
			return (ETemplateVersion)array[0];
		}

		public void GetVersionByIDAsync(string AID, bool ADataFlag, bool ADataFlagSpecified)
		{
			this.GetVersionByIDAsync(AID, ADataFlag, ADataFlagSpecified, null);
		}

		public void GetVersionByIDAsync(string AID, bool ADataFlag, bool ADataFlagSpecified, object userState)
		{
			if (this.GetVersionByIDOperationCompleted == null)
			{
				this.GetVersionByIDOperationCompleted = new SendOrPostCallback(this.OnGetVersionByIDOperationCompleted);
			}
			this.InvokeAsync("GetVersionByID", new object[]
			{
				AID,
				ADataFlag,
				ADataFlagSpecified
			}, this.GetVersionByIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetVersionByIDOperationCompleted(object arg)
		{
			if (this.GetVersionByIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetVersionByIDCompletedEventHandler getVersionByIDCompletedEvent = this.GetVersionByIDCompletedEvent;
				if (getVersionByIDCompletedEvent != null)
				{
					getVersionByIDCompletedEvent(this, new GetVersionByIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GetVersionByTemplateID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion GetVersionByTemplateID(string ATemplateID)
		{
			object[] array = this.Invoke("GetVersionByTemplateID", new object[]
			{
				ATemplateID
			});
			return (ETemplateVersion)array[0];
		}

		public void GetVersionByTemplateIDAsync(string ATemplateID)
		{
			this.GetVersionByTemplateIDAsync(ATemplateID, null);
		}

		public void GetVersionByTemplateIDAsync(string ATemplateID, object userState)
		{
			if (this.GetVersionByTemplateIDOperationCompleted == null)
			{
				this.GetVersionByTemplateIDOperationCompleted = new SendOrPostCallback(this.OnGetVersionByTemplateIDOperationCompleted);
			}
			this.InvokeAsync("GetVersionByTemplateID", new object[]
			{
				ATemplateID
			}, this.GetVersionByTemplateIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGetVersionByTemplateIDOperationCompleted(object arg)
		{
			if (this.GetVersionByTemplateIDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GetVersionByTemplateIDCompletedEventHandler getVersionByTemplateIDCompletedEvent = this.GetVersionByTemplateIDCompletedEvent;
				if (getVersionByTemplateIDCompletedEvent != null)
				{
					getVersionByTemplateIDCompletedEvent(this, new GetVersionByTemplateIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.GuidMap2ID", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string GuidMap2ID(string AGuidStr)
		{
			object[] array = this.Invoke("GuidMap2ID", new object[]
			{
				AGuidStr
			});
			return Conversions.ToString(array[0]);
		}

		public void GuidMap2IDAsync(string AGuidStr)
		{
			this.GuidMap2IDAsync(AGuidStr, null);
		}

		public void GuidMap2IDAsync(string AGuidStr, object userState)
		{
			if (this.GuidMap2IDOperationCompleted == null)
			{
				this.GuidMap2IDOperationCompleted = new SendOrPostCallback(this.OnGuidMap2IDOperationCompleted);
			}
			this.InvokeAsync("GuidMap2ID", new object[]
			{
				AGuidStr
			}, this.GuidMap2IDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnGuidMap2IDOperationCompleted(object arg)
		{
			if (this.GuidMap2IDCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				GuidMap2IDCompletedEventHandler guidMap2IDCompletedEvent = this.GuidMap2IDCompletedEvent;
				if (guidMap2IDCompletedEvent != null)
				{
					guidMap2IDCompletedEvent(this, new GuidMap2IDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.IDMap2Guid", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string IDMap2Guid(string AIDStr)
		{
			object[] array = this.Invoke("IDMap2Guid", new object[]
			{
				AIDStr
			});
			return Conversions.ToString(array[0]);
		}

		public void IDMap2GuidAsync(string AIDStr)
		{
			this.IDMap2GuidAsync(AIDStr, null);
		}

		public void IDMap2GuidAsync(string AIDStr, object userState)
		{
			if (this.IDMap2GuidOperationCompleted == null)
			{
				this.IDMap2GuidOperationCompleted = new SendOrPostCallback(this.OnIDMap2GuidOperationCompleted);
			}
			this.InvokeAsync("IDMap2Guid", new object[]
			{
				AIDStr
			}, this.IDMap2GuidOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnIDMap2GuidOperationCompleted(object arg)
		{
			if (this.IDMap2GuidCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				IDMap2GuidCompletedEventHandler iDMap2GuidCompletedEvent = this.IDMap2GuidCompletedEvent;
				if (iDMap2GuidCompletedEvent != null)
				{
					iDMap2GuidCompletedEvent(this, new IDMap2GuidCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.PublishVersion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion PublishVersion(ETemplateVersion AVersion)
		{
			object[] array = this.Invoke("PublishVersion", new object[]
			{
				AVersion
			});
			return (ETemplateVersion)array[0];
		}

		public void PublishVersionAsync(ETemplateVersion AVersion)
		{
			this.PublishVersionAsync(AVersion, null);
		}

		public void PublishVersionAsync(ETemplateVersion AVersion, object userState)
		{
			if (this.PublishVersionOperationCompleted == null)
			{
				this.PublishVersionOperationCompleted = new SendOrPostCallback(this.OnPublishVersionOperationCompleted);
			}
			this.InvokeAsync("PublishVersion", new object[]
			{
				AVersion
			}, this.PublishVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnPublishVersionOperationCompleted(object arg)
		{
			if (this.PublishVersionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				PublishVersionCompletedEventHandler publishVersionCompletedEvent = this.PublishVersionCompletedEvent;
				if (publishVersionCompletedEvent != null)
				{
					publishVersionCompletedEvent(this, new PublishVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.TestUpdateVersion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion TestUpdateVersion(string templateVersionID)
		{
			object[] array = this.Invoke("TestUpdateVersion", new object[]
			{
				templateVersionID
			});
			return (ETemplateVersion)array[0];
		}

		public void TestUpdateVersionAsync(string templateVersionID)
		{
			this.TestUpdateVersionAsync(templateVersionID, null);
		}

		public void TestUpdateVersionAsync(string templateVersionID, object userState)
		{
			if (this.TestUpdateVersionOperationCompleted == null)
			{
				this.TestUpdateVersionOperationCompleted = new SendOrPostCallback(this.OnTestUpdateVersionOperationCompleted);
			}
			this.InvokeAsync("TestUpdateVersion", new object[]
			{
				templateVersionID
			}, this.TestUpdateVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnTestUpdateVersionOperationCompleted(object arg)
		{
			if (this.TestUpdateVersionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				TestUpdateVersionCompletedEventHandler testUpdateVersionCompletedEvent = this.TestUpdateVersionCompletedEvent;
				if (testUpdateVersionCompletedEvent != null)
				{
					testUpdateVersionCompletedEvent(this, new TestUpdateVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.UpdateCraftVersion", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public ETemplateVersion UpdateCraftVersion(ETemplateVersion AVersion)
		{
			object[] array = this.Invoke("UpdateCraftVersion", new object[]
			{
				AVersion
			});
			return (ETemplateVersion)array[0];
		}

		public void UpdateCraftVersionAsync(ETemplateVersion AVersion)
		{
			this.UpdateCraftVersionAsync(AVersion, null);
		}

		public void UpdateCraftVersionAsync(ETemplateVersion AVersion, object userState)
		{
			if (this.UpdateCraftVersionOperationCompleted == null)
			{
				this.UpdateCraftVersionOperationCompleted = new SendOrPostCallback(this.OnUpdateCraftVersionOperationCompleted);
			}
			this.InvokeAsync("UpdateCraftVersion", new object[]
			{
				AVersion
			}, this.UpdateCraftVersionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateCraftVersionOperationCompleted(object arg)
		{
			if (this.UpdateCraftVersionCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateCraftVersionCompletedEventHandler updateCraftVersionCompletedEvent = this.UpdateCraftVersionCompletedEvent;
				if (updateCraftVersionCompletedEvent != null)
				{
					updateCraftVersionCompletedEvent(this, new UpdateCraftVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
				}
			}
		}

		[SoapDocumentMethod("http://www.dhcc.com.cn/epr/metaservice/EPRservice.BOTemplate.UpdateTemplate", RequestNamespace = "http://www.dhcc.com.cn/epr/metaservice", ResponseNamespace = "http://www.dhcc.com.cn/epr/metaservice", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public void UpdateTemplate(ETemplate ATemplate, ref bool UpdateTemplateResult, [XmlIgnore] ref bool UpdateTemplateResultSpecified)
		{
			object[] array = this.Invoke("UpdateTemplate", new object[]
			{
				ATemplate
			});
			UpdateTemplateResult = Conversions.ToBoolean(array[0]);
			UpdateTemplateResultSpecified = Conversions.ToBoolean(array[1]);
		}

		public void UpdateTemplateAsync(ETemplate ATemplate)
		{
			this.UpdateTemplateAsync(ATemplate, null);
		}

		public void UpdateTemplateAsync(ETemplate ATemplate, object userState)
		{
			if (this.UpdateTemplateOperationCompleted == null)
			{
				this.UpdateTemplateOperationCompleted = new SendOrPostCallback(this.OnUpdateTemplateOperationCompleted);
			}
			this.InvokeAsync("UpdateTemplate", new object[]
			{
				ATemplate
			}, this.UpdateTemplateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
		}

		private void OnUpdateTemplateOperationCompleted(object arg)
		{
			if (this.UpdateTemplateCompletedEvent != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				UpdateTemplateCompletedEventHandler updateTemplateCompletedEvent = this.UpdateTemplateCompletedEvent;
				if (updateTemplateCompletedEvent != null)
				{
					updateTemplateCompletedEvent(this, new UpdateTemplateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeCompletedEventArgs.UserState)));
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
