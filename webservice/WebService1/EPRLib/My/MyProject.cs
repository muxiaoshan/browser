using AdmImageItemData;
using BindQueryData;
using BOEPRDiagnosConfig;
using BOEPRKbConfigInfo;
using CustomDictoryData;
using DictionaryData;
using GateWayDataInfo;
using GlossaryCategoryData;
using GlossaryData;
using GlossaryItemData;
using HISData;
using ImageCategoryData;
using ImageItemData;
using ImageLibData;
using ImagePosData;
using ImageTreeData;
using InstanceDataInfo;
using InterfaceTemplateData;
using ITCategoryData;
using KBCategoryData;
using KBDiagnos;
using KBNodeData;
using KBNodeDiagnosRule;
using KBTreeData;
using KnowledgeBaseData;
using LISData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;
using MRDiagnosData;
using OrderData;
using PACSData;
using SysOptionData;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SystemServiceData;
using TPrivRuleType;
using UnitData;

namespace My
{
	[StandardModule, HideModuleName, GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			public AdmImageItemInfo m_AdmImageItemInfo;

			public BindQueryService m_BindQueryService;

			public CustomDictoryInfo m_CustomDictoryInfo;

			public DataGatewayInfo m_DataGatewayInfo;

			public DiagnosConfig m_DiagnosConfig;

			public GlossaryCategoryInfo m_GlossaryCategoryInfo;

			public GlossaryInfo m_GlossaryInfo;

			public GlossaryItemInfo m_GlossaryItemInfo;

			public HISDataService m_HISDataService;

			public ImageCategoryInfo m_ImageCategoryInfo;

			public ImageItemInfo m_ImageItemInfo;

			public ImageLibInfo m_ImageLibInfo;

			public ImagePositionInfo m_ImagePositionInfo;

			public ImageTreeInfo m_ImageTreeInfo;

			public InstanceDataInfo m_InstanceDataInfo;

			public KBCategoryInfo m_KBCategoryInfo;

			public KbConfigInfo m_KbConfigInfo;

			public KBDiagnos m_KBDiagnos;

			public KBNodeDiagnosRuleInfo m_KBNodeDiagnosRuleInfo;

			public KBNodeInfo m_KBNodeInfo;

			public KBTreeInfo m_KBTreeInfo;

			public KnowledgeBaseInfo m_KnowledgeBaseInfo;

			public LISDataInfo m_LISDataInfo;

			public MRDiagnosDataInfo m_MRDiagnosDataInfo;

			public OrderDataService m_OrderDataService;

			public PACSDataInfo m_PACSDataInfo;

			public StdDictionaryService m_StdDictionaryService;

			public SysOptionInfo m_SysOptionInfo;

			public SystemInfo m_SystemInfo;

			public TemplateCategoryInfo m_TemplateCategoryInfo;

			public TemplateInfo m_TemplateInfo;

			public TemplatePrivBORuleType m_TemplatePrivBORuleType;

			public UnitService m_UnitService;

			public AdmImageItemInfo AdmImageItemInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_AdmImageItemInfo = MyProject.MyWebServices.Create__Instance__<AdmImageItemInfo>(this.m_AdmImageItemInfo);
					return this.m_AdmImageItemInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_AdmImageItemInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<AdmImageItemInfo>(ref this.m_AdmImageItemInfo);
				}
			}

			public BindQueryService BindQueryService
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_BindQueryService = MyProject.MyWebServices.Create__Instance__<BindQueryService>(this.m_BindQueryService);
					return this.m_BindQueryService;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_BindQueryService)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<BindQueryService>(ref this.m_BindQueryService);
				}
			}

			public CustomDictoryInfo CustomDictoryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_CustomDictoryInfo = MyProject.MyWebServices.Create__Instance__<CustomDictoryInfo>(this.m_CustomDictoryInfo);
					return this.m_CustomDictoryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_CustomDictoryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<CustomDictoryInfo>(ref this.m_CustomDictoryInfo);
				}
			}

			public DataGatewayInfo DataGatewayInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_DataGatewayInfo = MyProject.MyWebServices.Create__Instance__<DataGatewayInfo>(this.m_DataGatewayInfo);
					return this.m_DataGatewayInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_DataGatewayInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<DataGatewayInfo>(ref this.m_DataGatewayInfo);
				}
			}

			public DiagnosConfig DiagnosConfig
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_DiagnosConfig = MyProject.MyWebServices.Create__Instance__<DiagnosConfig>(this.m_DiagnosConfig);
					return this.m_DiagnosConfig;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_DiagnosConfig)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<DiagnosConfig>(ref this.m_DiagnosConfig);
				}
			}

			public GlossaryCategoryInfo GlossaryCategoryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_GlossaryCategoryInfo = MyProject.MyWebServices.Create__Instance__<GlossaryCategoryInfo>(this.m_GlossaryCategoryInfo);
					return this.m_GlossaryCategoryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_GlossaryCategoryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<GlossaryCategoryInfo>(ref this.m_GlossaryCategoryInfo);
				}
			}

			public GlossaryInfo GlossaryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_GlossaryInfo = MyProject.MyWebServices.Create__Instance__<GlossaryInfo>(this.m_GlossaryInfo);
					return this.m_GlossaryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_GlossaryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<GlossaryInfo>(ref this.m_GlossaryInfo);
				}
			}

			public GlossaryItemInfo GlossaryItemInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_GlossaryItemInfo = MyProject.MyWebServices.Create__Instance__<GlossaryItemInfo>(this.m_GlossaryItemInfo);
					return this.m_GlossaryItemInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_GlossaryItemInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<GlossaryItemInfo>(ref this.m_GlossaryItemInfo);
				}
			}

			public HISDataService HISDataService
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_HISDataService = MyProject.MyWebServices.Create__Instance__<HISDataService>(this.m_HISDataService);
					return this.m_HISDataService;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_HISDataService)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<HISDataService>(ref this.m_HISDataService);
				}
			}

			public ImageCategoryInfo ImageCategoryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ImageCategoryInfo = MyProject.MyWebServices.Create__Instance__<ImageCategoryInfo>(this.m_ImageCategoryInfo);
					return this.m_ImageCategoryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_ImageCategoryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ImageCategoryInfo>(ref this.m_ImageCategoryInfo);
				}
			}

			public ImageItemInfo ImageItemInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ImageItemInfo = MyProject.MyWebServices.Create__Instance__<ImageItemInfo>(this.m_ImageItemInfo);
					return this.m_ImageItemInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_ImageItemInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ImageItemInfo>(ref this.m_ImageItemInfo);
				}
			}

			public ImageLibInfo ImageLibInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ImageLibInfo = MyProject.MyWebServices.Create__Instance__<ImageLibInfo>(this.m_ImageLibInfo);
					return this.m_ImageLibInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_ImageLibInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ImageLibInfo>(ref this.m_ImageLibInfo);
				}
			}

			public ImagePositionInfo ImagePositionInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ImagePositionInfo = MyProject.MyWebServices.Create__Instance__<ImagePositionInfo>(this.m_ImagePositionInfo);
					return this.m_ImagePositionInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_ImagePositionInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ImagePositionInfo>(ref this.m_ImagePositionInfo);
				}
			}

			public ImageTreeInfo ImageTreeInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ImageTreeInfo = MyProject.MyWebServices.Create__Instance__<ImageTreeInfo>(this.m_ImageTreeInfo);
					return this.m_ImageTreeInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_ImageTreeInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<ImageTreeInfo>(ref this.m_ImageTreeInfo);
				}
			}

			public InstanceDataInfo InstanceDataInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_InstanceDataInfo = MyProject.MyWebServices.Create__Instance__<InstanceDataInfo>(this.m_InstanceDataInfo);
					return this.m_InstanceDataInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_InstanceDataInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<InstanceDataInfo>(ref this.m_InstanceDataInfo);
				}
			}

			public KBCategoryInfo KBCategoryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KBCategoryInfo = MyProject.MyWebServices.Create__Instance__<KBCategoryInfo>(this.m_KBCategoryInfo);
					return this.m_KBCategoryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KBCategoryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KBCategoryInfo>(ref this.m_KBCategoryInfo);
				}
			}

			public KbConfigInfo KbConfigInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KbConfigInfo = MyProject.MyWebServices.Create__Instance__<KbConfigInfo>(this.m_KbConfigInfo);
					return this.m_KbConfigInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KbConfigInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KbConfigInfo>(ref this.m_KbConfigInfo);
				}
			}

			public KBDiagnos KBDiagnos
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KBDiagnos = MyProject.MyWebServices.Create__Instance__<KBDiagnos>(this.m_KBDiagnos);
					return this.m_KBDiagnos;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KBDiagnos)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KBDiagnos>(ref this.m_KBDiagnos);
				}
			}

			public KBNodeDiagnosRuleInfo KBNodeDiagnosRuleInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KBNodeDiagnosRuleInfo = MyProject.MyWebServices.Create__Instance__<KBNodeDiagnosRuleInfo>(this.m_KBNodeDiagnosRuleInfo);
					return this.m_KBNodeDiagnosRuleInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KBNodeDiagnosRuleInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KBNodeDiagnosRuleInfo>(ref this.m_KBNodeDiagnosRuleInfo);
				}
			}

			public KBNodeInfo KBNodeInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KBNodeInfo = MyProject.MyWebServices.Create__Instance__<KBNodeInfo>(this.m_KBNodeInfo);
					return this.m_KBNodeInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KBNodeInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KBNodeInfo>(ref this.m_KBNodeInfo);
				}
			}

			public KBTreeInfo KBTreeInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KBTreeInfo = MyProject.MyWebServices.Create__Instance__<KBTreeInfo>(this.m_KBTreeInfo);
					return this.m_KBTreeInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KBTreeInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KBTreeInfo>(ref this.m_KBTreeInfo);
				}
			}

			public KnowledgeBaseInfo KnowledgeBaseInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_KnowledgeBaseInfo = MyProject.MyWebServices.Create__Instance__<KnowledgeBaseInfo>(this.m_KnowledgeBaseInfo);
					return this.m_KnowledgeBaseInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_KnowledgeBaseInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<KnowledgeBaseInfo>(ref this.m_KnowledgeBaseInfo);
				}
			}

			public LISDataInfo LISDataInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_LISDataInfo = MyProject.MyWebServices.Create__Instance__<LISDataInfo>(this.m_LISDataInfo);
					return this.m_LISDataInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_LISDataInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<LISDataInfo>(ref this.m_LISDataInfo);
				}
			}

			public MRDiagnosDataInfo MRDiagnosDataInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_MRDiagnosDataInfo = MyProject.MyWebServices.Create__Instance__<MRDiagnosDataInfo>(this.m_MRDiagnosDataInfo);
					return this.m_MRDiagnosDataInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_MRDiagnosDataInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<MRDiagnosDataInfo>(ref this.m_MRDiagnosDataInfo);
				}
			}

			public OrderDataService OrderDataService
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_OrderDataService = MyProject.MyWebServices.Create__Instance__<OrderDataService>(this.m_OrderDataService);
					return this.m_OrderDataService;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_OrderDataService)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<OrderDataService>(ref this.m_OrderDataService);
				}
			}

			public PACSDataInfo PACSDataInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_PACSDataInfo = MyProject.MyWebServices.Create__Instance__<PACSDataInfo>(this.m_PACSDataInfo);
					return this.m_PACSDataInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_PACSDataInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<PACSDataInfo>(ref this.m_PACSDataInfo);
				}
			}

			public StdDictionaryService StdDictionaryService
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_StdDictionaryService = MyProject.MyWebServices.Create__Instance__<StdDictionaryService>(this.m_StdDictionaryService);
					return this.m_StdDictionaryService;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_StdDictionaryService)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<StdDictionaryService>(ref this.m_StdDictionaryService);
				}
			}

			public SysOptionInfo SysOptionInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_SysOptionInfo = MyProject.MyWebServices.Create__Instance__<SysOptionInfo>(this.m_SysOptionInfo);
					return this.m_SysOptionInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_SysOptionInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<SysOptionInfo>(ref this.m_SysOptionInfo);
				}
			}

			public SystemInfo SystemInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_SystemInfo = MyProject.MyWebServices.Create__Instance__<SystemInfo>(this.m_SystemInfo);
					return this.m_SystemInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_SystemInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<SystemInfo>(ref this.m_SystemInfo);
				}
			}

			public TemplateCategoryInfo TemplateCategoryInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_TemplateCategoryInfo = MyProject.MyWebServices.Create__Instance__<TemplateCategoryInfo>(this.m_TemplateCategoryInfo);
					return this.m_TemplateCategoryInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_TemplateCategoryInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<TemplateCategoryInfo>(ref this.m_TemplateCategoryInfo);
				}
			}

			public TemplateInfo TemplateInfo
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_TemplateInfo = MyProject.MyWebServices.Create__Instance__<TemplateInfo>(this.m_TemplateInfo);
					return this.m_TemplateInfo;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_TemplateInfo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<TemplateInfo>(ref this.m_TemplateInfo);
				}
			}

			public TemplatePrivBORuleType TemplatePrivBORuleType
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_TemplatePrivBORuleType = MyProject.MyWebServices.Create__Instance__<TemplatePrivBORuleType>(this.m_TemplatePrivBORuleType);
					return this.m_TemplatePrivBORuleType;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_TemplatePrivBORuleType)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<TemplatePrivBORuleType>(ref this.m_TemplatePrivBORuleType);
				}
			}

			public UnitService UnitService
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_UnitService = MyProject.MyWebServices.Create__Instance__<UnitService>(this.m_UnitService);
					return this.m_UnitService;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_UnitService)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<UnitService>(ref this.m_UnitService);
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return Activator.CreateInstance<T>();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public MyWebServices()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			private readonly ContextValue<T> m_Context;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					T t = this.m_Context.Value;
					if (t == null)
					{
						t = Activator.CreateInstance<T>();
						this.m_Context.Value = t;
					}
					return t;
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
				this.m_Context = new ContextValue<T>();
			}
		}

		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
