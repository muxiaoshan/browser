using System;

namespace dhcc.epr.systemframework
{
	public class AppException : Exception
	{
		public const string DATABASE_LINK_ERROR = "创建数据库链接失败。";

		public const string CATEGORY_GETALL_ERROR = "获取目录信息失败。";

		public const string CATEGORY_ADD_ERROR = "新增目录信息失败。";

		public const string CATEGORY_SET_ERROR = "更新目录信息失败。";

		public const string CATEGORY_DEL_ERROR = "删除目录失败！";

		public const string KBRESOURCE_GET_ERROR = "获取知识库信息失败。";

		public const string KBRESOURCE_ADD_ERROR = "添加知识库信息失败。";

		public const string KBRESOURCE_SET_ERROR = "更新知识库信息失败。";

		public const string KBRESOURCE_DEL_ERROR = "删除知识库失败。";

		public const string LIBRESOURCE_GET_ERROR = "获取图库信息失败。";

		public const string LIBRESOURCE_ADD_ERROR = "添加图库信息失败。";

		public const string LIBRESOURCE_SET_ERROR = "更新图库信息失败。";

		public const string LIBRESOURCE_DEL_ERROR = "删除图库失败。";

		public const string PTRESOURCE_GET_ERRPR = "获取打印模板信息失败。";

		public const string PTRESOURCE_ADD_ERROR = "添加打印模板信息失败。";

		public const string PTRESOURCE_SET_ERROR = "更新打印模板信息失败。";

		public const string PTRESOURCE_DEL_ERROR = "删除打印模板信息失败。";

		public const string RTRESOURCE_GET_ERROR = "获取报表模板信息失败。";

		public const string RTRESOURCE_ADD_ERROR = "添加报表模板信息失败。";

		public const string RTRESOURCE_SET_ERROR = "更新报表模板信息失败。";

		public const string RTRESOURCE_DEL_ERROR = "删除报表模板信息失败。";

		public const string VERSION_GET_ERROR = "获取版本信息失败。";

		public const string VERSION_ADD_ERROR = "新增版本信息失败。";

		public const string VERSION_SET_ERROR = "更新版本信息失败。";

		public const string VERSION_DEL_ERROR = "删除版本信息失败。";

		public const string VERSION_PUB_ERROE = "发布版本信息失败。";

		public const string ITRESOURCE_GET_ERRPR = "获取界面模板信息失败。";

		public const string ITRESOURCE_ADD_ERROR = "添加界面模板信息失败。";

		public const string ITRESOURCE_SET_ERROR = "更新界面模板信息失败。";

		public const string ITRESOURCE_DEL_ERROR = "删除界面模板信息失败。";

		public const string DICTIONARY_GET_ERROR = "获取字典表信息失败。";

		public const string DICTIONARY_ADD_ERROR = "新增字典表信息失败。";

		public const string DICTIONARY_SET_ERROR = "更新字典表信息失败。";

		public const string DICTIONARY_DEL_ERROR = "删除字典表信息失败。";

		public const string DICTIONARY_IS_EXIST = "字典代码已存在，操作失败。";

		public const string UNITTYPE_GET_ERROR = "获取数量单位类型信息失败。";

		public const string UNITTYPE_ADD_ERROR = "新增数量单位类型信息失败。";

		public const string UNITTYPE_SET_ERROR = "更新数量单位类型信息失败。";

		public const string UNITTYPE_DEL_ERROR = "删除数量单位类型信息失败。";

		public const string UNITTYPE_IS_EXIST = "数量单位类型代码已存在，操作失败。";

		public const string UNIT_GET_ERROR = "获取数量单位信息失败。";

		public const string UNIT_ADD_ERROR = "新增数量单位信息失败。";

		public const string UNIT_SET_ERROR = "更新数量单位信息失败。";

		public const string UNIT_DEL_ERROR = "删除数量单位信息失败。";

		public const string DEFAULTUNIT_IS_EXIST = "默认数量单位已存在，操作失败。";

		public const string METADATA_GET_ERROR = "获取界面模板元数据信息失败。";

		public const string BINDDATA_GET_ERROR = "获取绑定数据信息失败。";

		public const string SYSPARAMS_GET_ERROR = "获取系统参数信息失败。";

		public const string SYSPARAMS_ADD_ERROR = "新增系统参数信息失败。";

		public const string SYSPARAMS_SET_ERROR = "更新系统参数信息失败。";

		public const string SYSPARAMS_DEL_ERROR = "删除系统参数信息失败。";

		public const string SYSPARAMS_IS_EXIST = "系统参数名称已存在，操作失败。";

		public const string EPISODE_ITEM_GET_ERROR = "获取就诊数据项信息失败。";

		public const string EPISODE_ITEM_ADD_ERROR = "新增就诊数据项信息失败。";

		public const string EPISODE_ITEM_SET_ERROR = "更新就诊数据项信息失败。";

		public const string EPISODE_ITEM_DEL_ERROR = "删除就诊数据项信息失败。";

		public const string CATEGORY_TYPE_GET_ERROR = "获取界面模板目录类型信息失败。";

		public const string CATEGORY_TYPE_ADD_ERROR = "新增界面模板目录类型信息失败。";

		public const string CATEGORY_TYPE_SET_ERROR = "更新界面模板目录类型信息失败。";

		public const string CATEGORY_TYPE_DEL_ERROR = "删除界面模板目录类型信息失败。";

		public const string PROPERTY_GET_ERROR = "获取界面模板及目录属性信息失败。";

		public const string PROPERTY_ADD_ERROR = "新增界面模板及目录属性信息失败。";

		public const string PROPERTY_SET_ERROR = "更新界面模板及目录属性信息失败。";

		public const string PROPERTY_DEL_ERROR = "删除界面模板及目录属性信息失败。";

		public const string SYSPARAM_GET_ERROR = "获取系统参数[{0}]的值失败。";

		public const string PRINTRECORD_GET_ERROR = "获取打印记录信息失败。";

		public const string PRINTRECORD_SET_ERROR = "更新打印记录信息失败。";

		public const string PTEMPLATE_INFO_IS_NULL = "打印模板信息为空，无法执行打印操作。";

		public const string RTEMPLATE_INFO_IS_NULL = "报表模板信息为空，无法运行该报表。";

		public const string TGUIDS_GET_ERROR = "获取绑定界面模板的唯一编码错误。";

		public const string NEWTIDS_GET_ERROR = "获取绑定界面模板的新编码错误。";

		public const string SYSTEMDATA_INIT_ERROR = "初始化系统数据列表失败。";

		public const string REPORT_DATA_GET_ERROR = "报表查询数据获取失败。";

		public const string EXPORTTABLE_GET_ERROR = "获取导出表失败。";

		public const string EXPORTTABLE_ADD_ERROR = "新增导出表失败。";

		public const string EXPORTTABLE_GEN_ERROR = "生成导出表失败。";

		public const string EXPORTTABLE_DEL_ERROR = "删除导出表失败。";

		public const string PrivRule_ADD_ERROR = "增加权限规则失败。";

		public const string PrivRule_DEL_ERROR = "删除权限规则失败。";

		public const string PrivRule_GET_ERROR = "获取权限规则失败。";

		public const string PrivRule_SET_ERROR = "修改权限规则失败。";

		public const string GLOSSARY_GET_ERROR = "获取术语集信息失败。";

		public const string GLOSSARY_ADD_ERROR = "添加术语集失败。";

		public const string GLOSSARY_SET_ERROR = "更新术语集失败。";

		public const string GLOSSARY_DEL_ERROR = "删除术语集失败。";

		public const string GLOSSARYITEM_GET_ERROR = "获取术语项目信息失败。";

		public const string SUPERUSER_GET_ERROR = "获取用户表信息失败。";

		public const string SUPERUSER_ADD_ERROR = "新增用户信息失败。";

		public const string SUPERUSER_IS_EXIST = "该用户ID已存在，操作失败。";

		public const string SUPERUSER_SET_ERROR = "更新用户失败。";

		public const string SUPERUSER_DEL_ERROR = "删除用户失败。";

		public const string FORMULA_WRONG_VALUE_TYPE = "错误的公式系统值类型。";

		public const string FORMULA_READONLY_VALUE_TYPE = "只读的公式系统值类型。";

		public const string FORMULA_MISMATCH_VALUE_TYPE = "公式系统中值类型与单元不匹配。";

		private string m_ShowInfo = "";

		public string ShowInfo
		{
			get
			{
				return this.m_ShowInfo;
			}
		}

		public AppException(string showInfo)
		{
			this.m_ShowInfo = showInfo;
			EventLogHelper.LogError(EventLogHelper.FormatException(this, showInfo));
		}

		public AppException(string showInfo, Exception innerException)
		{
			this.m_ShowInfo = showInfo;
			if (innerException != null)
			{
				EventLogHelper.LogError(EventLogHelper.FormatException(innerException, showInfo));
				return;
			}
			EventLogHelper.LogError(EventLogHelper.FormatException(this, showInfo));
		}
	}
}
