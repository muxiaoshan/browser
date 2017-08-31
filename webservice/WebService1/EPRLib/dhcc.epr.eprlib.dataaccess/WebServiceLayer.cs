using AdmImageItemData;
using BindQueryData;
using BOEPRDiagnosConfig;
using BOEPRKbConfigInfo;
using CustomDictoryData;
using dhcc.epr.systemframework;
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
using Microsoft.VisualBasic.CompilerServices;
using MRDiagnosData;
using OrderData;
using PACSData;
using SysOptionData;
using System;
using System.Diagnostics;
using SystemServiceData;
using TPrivRuleType;
using UnitData;

namespace dhcc.epr.eprlib.dataaccess
{
	public class WebServiceLayer
	{
		private static string _URL;

		private const string UNITSERVICE = "EPRservice.BOUnitService.cls";

		private const string DICTIONARYSERVICE = "EPRservice.BOStdDictionary.cls";

		private const string KNOWLEDGEBASESERVICE = "EPRservice.BOKnowledgeBase.cls";

		private const string KBNODEERVICE = "EPRservice.BOKBNode.cls";

		private const string KBTREESERVICE = "EPRservice.BOKBTree.cls";

		private const string KBCATEGORYSERVICE = "EPRservice.BOKBCategory.cls";

		private const string INTERFACETEMPLATESERVICE = "EPRservice.BOTemplate.cls";

		private const string ITCATEGORYSERVICE = "EPRservice.BOTemplateCategory.cls";

		private const string BINDQUERYSERVICE = "EPRservice.BOBindQueryService.cls";

		private const string IMAGEPOSSERVICE = "EPRservice.BOImagePosition.cls";

		private const string SYSOPTIONSERVICE = "EPRservice.BOSysOption.cls";

		private const string INSTANCESERVICE = "EPRservice.BOInstanceData.cls";

		private const string GATEWAYSERVICE = "EPRservice.BODataGateway.cls";

		private const string GLOSSARYSERVICE = "EPRservice.BOGlossary.cls";

		private const string GLOSSARYITEMSERVICE = "EPRservice.BOGlossaryItem.cls";

		private const string GLOSSARYCATEGORYSERVICE = "EPRservice.BOGlossaryCategory.cls";

		private const string LISDATASERVICE = "EPRservice.BOLISData.cls";

		private const string HISDATASERVICE = "EPRservice.BOHISData.cls";

		private const string PACSDATASERVICE = "EPRservice.BOPACSData.cls";

		private const string LOCANDKBBASE = "EPRservice.BOEPRKbConfig.cls";

		private const string ORDERDATASERVICE = "EPRservice.BOOrderData.cls";

		private const string KBDIAGNOSSERVICE = "EPRservice.BOKBDiagnos.cls";

		private const string KBDIAGNOSCONFIGSERVICE = "EPRservice.BOEPRDiagnosConfig.cls";

		private const string IMAGECATEGORYSERVICE = "EPRservice.BOImageCategory.cls";

		private const string IMAGELIBSERVICE = "EPRservice.BOImageLib.cls";

		private const string ADMIMAGEITEMSERVICE = "EPRservice.BOAdmImageItem.cls";

		private const string IMAGETREESERVICE = "EPRservice.BOImageTree.cls";

		private const string IMAGEITEMSERVICE = "EPRservice.BOImageItem.cls";

		private const string TPRIVRULETYPESERVICE = "EPRservice.TemplatePriv.BORuleType.cls";

		private const string KBNODEDIAGNOSRULESERVICE = "EPRservice.BOKBNodeDiagnosRule.cls";

		private const string MRDIAGNOSSERVICE = "EPRservice.BOMRDiagnosData.cls";

		private const string SYSTEMSERVICE = "EPRservice.BOSystemService.cls";

		private const string CUSTOMDICTORYSERVICE = "EPRservice.BOCustomDictory.cls";

		private static InstanceDataInfo _InstanceAccess = null;

		private static DataGatewayInfo _GateWayAccess = null;

		private static UnitService _UnitAccess = null;

		private static StdDictionaryService _DictionaryAccess = null;

		private static KnowledgeBaseInfo _KnowledgeBaseAccess = null;

		private static KBNodeInfo _KBNodeAccess = null;

		private static KBTreeInfo _KBTreeAccess = null;

		private static KBCategoryInfo _KBCategoryAccess = null;

		private static TemplateInfo _InterfaceTemplateAccess = null;

		private static TemplateCategoryInfo _ITCategoryAccess = null;

		private static BindQueryService _BindQueryAccess = null;

		private static ImagePositionInfo _ImagePosAccess = null;

		private static SysOptionInfo _SysOptionAccess = null;

		private static GlossaryInfo _GlossaryAccess = null;

		private static GlossaryItemInfo _GlossaryItemAccess = null;

		private static GlossaryCategoryInfo _GlossaryCategoryAccess = null;

		private static LISDataInfo _LISDataAccess = null;

		private static PACSDataInfo _PacsDataAccess = null;

		private static KbConfigInfo _KbConfigAccess = null;

		private static HISDataService _HISDataAccess = null;

		private static OrderDataService _OrderDataAccess = null;

		private static KBDiagnos _KBDiagnos = null;

		private static DiagnosConfig _KBDiagnosConfigAcess = null;

		private static TemplatePrivBORuleType _TPrivRuleTypeAccess = null;

		private static ImageCategoryInfo _ImageCategoryAccess = null;

		private static ImageLibInfo _ImageLibAccess = null;

		private static ImageTreeInfo _ImageTreeAccess = null;

		private static ImageItemInfo _ImageItemAccess = null;

		private static AdmImageItemInfo _AdmImageItemAccess = null;

		private static KBNodeDiagnosRuleInfo _KBNodeDiagnosRuleAccess = null;

		private static MRDiagnosDataInfo _MRDiagnosAccess = null;

		private static SystemInfo _SystemServiceAccess = null;

		private static CustomDictoryInfo _CustionDictoryAccess = null;

		public static string URL
		{
			get
			{
				if (Configuration.DataServiceUrl.EndsWith("/"))
				{
					return Configuration.DataServiceUrl;
				}
				return Configuration.DataServiceUrl + "/";
			}
		}

		public static UnitService UnitAccess
		{
			get
			{
				if (WebServiceLayer._UnitAccess == null)
				{
					WebServiceLayer._UnitAccess = new UnitService();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._UnitAccess.Url = WebServiceLayer.URL + "EPRservice.BOUnitService.cls";
					}
				}
				return WebServiceLayer._UnitAccess;
			}
		}

		public static StdDictionaryService DictionaryAccess
		{
			get
			{
				if (WebServiceLayer._DictionaryAccess == null)
				{
					WebServiceLayer._DictionaryAccess = new StdDictionaryService();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._DictionaryAccess.Url = WebServiceLayer.URL + "EPRservice.BOStdDictionary.cls";
					}
				}
				return WebServiceLayer._DictionaryAccess;
			}
		}

		public static KnowledgeBaseInfo KnowledgeBaseAccess
		{
			get
			{
				if (WebServiceLayer._KnowledgeBaseAccess == null)
				{
					WebServiceLayer._KnowledgeBaseAccess = new KnowledgeBaseInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KnowledgeBaseAccess.Url = WebServiceLayer.URL + "EPRservice.BOKnowledgeBase.cls";
					}
				}
				return WebServiceLayer._KnowledgeBaseAccess;
			}
		}

		public static KBNodeInfo KBNodeAccess
		{
			get
			{
				if (WebServiceLayer._KBNodeAccess == null)
				{
					WebServiceLayer._KBNodeAccess = new KBNodeInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KBNodeAccess.Url = WebServiceLayer.URL + "EPRservice.BOKBNode.cls";
					}
				}
				return WebServiceLayer._KBNodeAccess;
			}
		}

		public static KBTreeInfo KBTreeAccess
		{
			get
			{
				if (WebServiceLayer._KBTreeAccess == null)
				{
					WebServiceLayer._KBTreeAccess = new KBTreeInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KBTreeAccess.Url = WebServiceLayer.URL + "EPRservice.BOKBTree.cls";
					}
				}
				return WebServiceLayer._KBTreeAccess;
			}
		}

		public static KBDiagnos KBDiagnosAccess
		{
			get
			{
				if (WebServiceLayer._KBDiagnos == null)
				{
					WebServiceLayer._KBDiagnos = new KBDiagnos();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KBDiagnos.Url = WebServiceLayer.URL + "EPRservice.BOKBDiagnos.cls";
					}
				}
				return WebServiceLayer._KBDiagnos;
			}
		}

		public static DiagnosConfig KBDiagnosConfigAccess
		{
			get
			{
				if (WebServiceLayer._KBDiagnosConfigAcess == null)
				{
					WebServiceLayer._KBDiagnosConfigAcess = new DiagnosConfig();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KBDiagnosConfigAcess.Url = WebServiceLayer.URL + "EPRservice.BOEPRDiagnosConfig.cls";
					}
				}
				return WebServiceLayer._KBDiagnosConfigAcess;
			}
		}

		public static KBCategoryInfo KBCategoryAccess
		{
			get
			{
				if (WebServiceLayer._KBCategoryAccess == null)
				{
					WebServiceLayer._KBCategoryAccess = new KBCategoryInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KBCategoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOKBCategory.cls";
					}
				}
				return WebServiceLayer._KBCategoryAccess;
			}
		}

		public static TemplateInfo InterfaceTemplateAccess
		{
			get
			{
				if (WebServiceLayer._InterfaceTemplateAccess == null)
				{
					WebServiceLayer._InterfaceTemplateAccess = new TemplateInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._InterfaceTemplateAccess.Url = WebServiceLayer.URL + "EPRservice.BOTemplate.cls";
					}
				}
				return WebServiceLayer._InterfaceTemplateAccess;
			}
		}

		public static TemplateCategoryInfo ITCategoryAccess
		{
			get
			{
				if (WebServiceLayer._ITCategoryAccess == null)
				{
					WebServiceLayer._ITCategoryAccess = new TemplateCategoryInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._ITCategoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOTemplateCategory.cls";
					}
				}
				return WebServiceLayer._ITCategoryAccess;
			}
		}

		public static BindQueryService BindQueryAccess
		{
			get
			{
				if (WebServiceLayer._BindQueryAccess == null)
				{
					WebServiceLayer._BindQueryAccess = new BindQueryService();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._BindQueryAccess.Url = WebServiceLayer.URL + "EPRservice.BOBindQueryService.cls";
					}
				}
				return WebServiceLayer._BindQueryAccess;
			}
		}

		public static ImagePositionInfo ImagePosAccess
		{
			get
			{
				if (WebServiceLayer._ImagePosAccess == null)
				{
					WebServiceLayer._ImagePosAccess = new ImagePositionInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._ImagePosAccess.Url = WebServiceLayer.URL + "EPRservice.BOImagePosition.cls";
					}
				}
				return WebServiceLayer._ImagePosAccess;
			}
		}

		public static SysOptionInfo SysOptionAccess
		{
			get
			{
				if (WebServiceLayer._SysOptionAccess == null)
				{
					WebServiceLayer._SysOptionAccess = new SysOptionInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._SysOptionAccess.Url = WebServiceLayer.URL + "EPRservice.BOSysOption.cls";
					}
				}
				return WebServiceLayer._SysOptionAccess;
			}
		}

		public static InstanceDataInfo InstanceAccess
		{
			get
			{
				if (WebServiceLayer._InstanceAccess == null)
				{
					WebServiceLayer._InstanceAccess = new InstanceDataInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._InstanceAccess.Url = WebServiceLayer.URL + "EPRservice.BOInstanceData.cls";
					}
				}
				return WebServiceLayer._InstanceAccess;
			}
		}

		public static DataGatewayInfo GateWayAccess
		{
			get
			{
				if (WebServiceLayer._GateWayAccess == null)
				{
					WebServiceLayer._GateWayAccess = new DataGatewayInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._GateWayAccess.Url = WebServiceLayer.URL + "EPRservice.BODataGateway.cls";
					}
				}
				return WebServiceLayer._GateWayAccess;
			}
		}

		public static GlossaryInfo GlossaryAccess
		{
			get
			{
				if (WebServiceLayer._GlossaryAccess == null)
				{
					WebServiceLayer._GlossaryAccess = new GlossaryInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._GlossaryAccess.Url = WebServiceLayer.URL + "EPRservice.BOGlossary.cls";
					}
				}
				return WebServiceLayer._GlossaryAccess;
			}
		}

		public static GlossaryItemInfo GlossaryItemAccess
		{
			get
			{
				if (WebServiceLayer._GlossaryItemAccess == null)
				{
					WebServiceLayer._GlossaryItemAccess = new GlossaryItemInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._GlossaryItemAccess.Url = WebServiceLayer.URL + "EPRservice.BOGlossaryItem.cls";
					}
				}
				return WebServiceLayer._GlossaryItemAccess;
			}
		}

		public static GlossaryCategoryInfo GlossaryCategoryAccess
		{
			get
			{
				if (WebServiceLayer._GlossaryCategoryAccess == null)
				{
					WebServiceLayer._GlossaryCategoryAccess = new GlossaryCategoryInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._GlossaryCategoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOGlossaryCategory.cls";
					}
				}
				return WebServiceLayer._GlossaryCategoryAccess;
			}
		}

		public static LISDataInfo LISDataAccess
		{
			get
			{
				if (WebServiceLayer._LISDataAccess == null)
				{
					WebServiceLayer._LISDataAccess = new LISDataInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._LISDataAccess.Url = WebServiceLayer.URL + "EPRservice.BOLISData.cls";
					}
				}
				return WebServiceLayer._LISDataAccess;
			}
		}

		public static PACSDataInfo PACSDataAccess
		{
			get
			{
				if (WebServiceLayer._PacsDataAccess == null)
				{
					WebServiceLayer._PacsDataAccess = new PACSDataInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._PacsDataAccess.Url = WebServiceLayer.URL + "EPRservice.BOPACSData.cls";
					}
				}
				return WebServiceLayer._PacsDataAccess;
			}
		}

		public static OrderDataService OrderDataAccess
		{
			get
			{
				if (WebServiceLayer._OrderDataAccess == null)
				{
					WebServiceLayer._OrderDataAccess = new OrderDataService();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._OrderDataAccess.Url = WebServiceLayer.URL + "EPRservice.BOOrderData.cls";
					}
				}
				return WebServiceLayer._OrderDataAccess;
			}
		}

		public static KbConfigInfo KbConfigAccess
		{
			get
			{
				if (WebServiceLayer._KbConfigAccess == null)
				{
					WebServiceLayer._KbConfigAccess = new KbConfigInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._KbConfigAccess.Url = WebServiceLayer.URL + "EPRservice.BOEPRKbConfig.cls";
					}
				}
				return WebServiceLayer._KbConfigAccess;
			}
		}

		public static HISDataService HISDataAccess
		{
			get
			{
				if (WebServiceLayer._HISDataAccess == null)
				{
					WebServiceLayer._HISDataAccess = new HISDataService();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._HISDataAccess.Url = WebServiceLayer.URL + "EPRservice.BOHISData.cls";
					}
				}
				return WebServiceLayer._HISDataAccess;
			}
		}

		public static TemplatePrivBORuleType TPrivRuleTypeAccess
		{
			get
			{
				if (WebServiceLayer._TPrivRuleTypeAccess == null)
				{
					WebServiceLayer._TPrivRuleTypeAccess = new TemplatePrivBORuleType();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._TPrivRuleTypeAccess.Url = WebServiceLayer.URL + "EPRservice.TemplatePriv.BORuleType.cls";
					}
				}
				return WebServiceLayer._TPrivRuleTypeAccess;
			}
		}

		public static ImageCategoryInfo ImageCategoryAccess
		{
			get
			{
				if (WebServiceLayer._ImageCategoryAccess == null)
				{
					WebServiceLayer._ImageCategoryAccess = new ImageCategoryInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._ImageCategoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOImageCategory.cls";
					}
				}
				return WebServiceLayer._ImageCategoryAccess;
			}
		}

		public static ImageLibInfo ImageLibAccess
		{
			get
			{
				if (WebServiceLayer._ImageLibAccess == null)
				{
					WebServiceLayer._ImageLibAccess = new ImageLibInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._ImageLibAccess.Url = WebServiceLayer.URL + "EPRservice.BOImageLib.cls";
					}
				}
				return WebServiceLayer._ImageLibAccess;
			}
		}

		public static AdmImageItemInfo AdmImageItemAccess
		{
			get
			{
				if (WebServiceLayer._AdmImageItemAccess == null)
				{
					WebServiceLayer._AdmImageItemAccess = new AdmImageItemInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._AdmImageItemAccess.Url = WebServiceLayer.URL + "EPRservice.BOAdmImageItem.cls";
					}
				}
				return WebServiceLayer._AdmImageItemAccess;
			}
		}

		public static ImageTreeInfo ImageTreeAccess
		{
			get
			{
				if (WebServiceLayer._ImageTreeAccess == null)
				{
					WebServiceLayer._ImageTreeAccess = new ImageTreeInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._ImageTreeAccess.Url = WebServiceLayer.URL + "EPRservice.BOImageTree.cls";
					}
				}
				return WebServiceLayer._ImageTreeAccess;
			}
		}

		public static ImageItemInfo ImageItemAccess
		{
			get
			{
				if (WebServiceLayer._ImageItemAccess == null)
				{
					WebServiceLayer._ImageItemAccess = new ImageItemInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._ImageItemAccess.Url = WebServiceLayer.URL + "EPRservice.BOImageItem.cls";
					}
				}
				return WebServiceLayer._ImageItemAccess;
			}
		}

		public static KBNodeDiagnosRuleInfo KBNodeDiagnosRuleAccess
		{
			get
			{
				if (WebServiceLayer._KBNodeDiagnosRuleAccess == null)
				{
					WebServiceLayer._KBNodeDiagnosRuleAccess = new KBNodeDiagnosRuleInfo();
					if (!string.IsNullOrEmpty(WebServiceLayer.URL))
					{
						WebServiceLayer._KBNodeDiagnosRuleAccess.Url = WebServiceLayer.URL + "EPRservice.BOKBNodeDiagnosRule.cls";
					}
				}
				return WebServiceLayer._KBNodeDiagnosRuleAccess;
			}
		}

		public static MRDiagnosDataInfo MRDiagnosDataAccess
		{
			get
			{
				if (WebServiceLayer._MRDiagnosAccess == null)
				{
					WebServiceLayer._MRDiagnosAccess = new MRDiagnosDataInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._MRDiagnosAccess.Url = WebServiceLayer.URL + "EPRservice.BOMRDiagnosData.cls";
					}
				}
				return WebServiceLayer._MRDiagnosAccess;
			}
		}

		public static SystemInfo SystemServiceDataAccess
		{
			get
			{
				if (WebServiceLayer._SystemServiceAccess == null)
				{
					WebServiceLayer._SystemServiceAccess = new SystemInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._SystemServiceAccess.Url = WebServiceLayer.URL + "EPRservice.BOSystemService.cls";
					}
				}
				return WebServiceLayer._SystemServiceAccess;
			}
		}

		public static CustomDictoryInfo CustomDictoryDataAccess
		{
			get
			{
				if (WebServiceLayer._CustionDictoryAccess == null)
				{
					WebServiceLayer._CustionDictoryAccess = new CustomDictoryInfo();
					if (!(WebServiceLayer.URL == null | Operators.CompareString(WebServiceLayer.URL, "", false) == 0))
					{
						WebServiceLayer._CustionDictoryAccess.Url = WebServiceLayer.URL + "EPRservice.BOCustomDictory.cls";
					}
				}
				return WebServiceLayer._CustionDictoryAccess;
			}
		}

		[DebuggerNonUserCode]
		public WebServiceLayer()
		{
		}
	}
}
