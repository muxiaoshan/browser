using System;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	public class MessageManager
	{
		private const string MESSAGE_BOX_TITLE = "系统提示";

		public const string OBJECT_IS_NULL = "必须输入[{0}]。";

		public const string NODE_DELETE_TIP = "“{0}”将被永久删除。";

		public const string IF_SAVE_CHANGES = "是否保存对“{0}”的更改？";

		public const string EXIST_NOTPUBLISHED_VERSION = "当前模板下已经存在未发布版本，无法再新增版本。";

		public const string CANNOT_DELETE_ALL_ROWS = "无法删除所有行。";

		public const string CANNOT_DELETE_ALL_COLUMNS = "无法删除所有列";

		public const string MARGIN_SET_ERROR = "输入不正确。要求页边距不能超出纸张大小。";

		public const string FONT_SIZE_FORMAT_ERROR = "字号必须介于 1 到 409 磅之间。";

		public const string OBJECT_IS_NOT_EXIST = "{0}不存在。";

		public const string MAYBE_REMOVE_RICHTEXT = "改变默认文字方向，选中区域内的复杂文本格式将被取消。";

		public const string PICTURE_FORMAT_ERROR = "图片格式错误。";

		public const string EXIST_BINDING_DATA = "该{0}已经存在绑定数据，是否覆盖先前的设置？";

		public const string GRAPHIC_NOT_BINDINGDATA = "图形未绑定元数据，不能设置该图形的显示或填充条件。";

		public const string CELL_NOT_BINDINGDATA = "单元格未绑定元数据，不能设置其所在行的显示条件。";

		public const string SAVE_SUCCESS = "{0}保存成功。";

		public const string PUBLISH_SUCCESS = "{0}发布成功。";

		public const string CANNOT_DELETE_UNITTYPE = "当前数量单位类型下还存在数量单位，无法删除此单位类型。";

		public const string VALUE_FORMAT_ERROR = "[{0}]格式不正确。";

		public const string WARNING_DELETE_BINDING_INFO = "修改此打印模板类型，将清空原有绑定界面模板信息，是否继续？";

		public const string WARNING_DELETE_SYSTEM_PARAM = "删除该系统参数，可能将导致系统无法正常运行，是否继续？";

		public const string NONE_BINDING_PRINTTEMPLATE = "系统未找到任何绑定打印模板信息，无法执行打印操作。";

		public const string STARTROW_MORETHAN_ONE = "行号必须大于 0 。";

		public const string EXIST_NONE_BINDING_ITEM = "存在未绑定打印模板的条目，是否跳过？";

		public const string TEMPLATE_DATA_ERROR = "初始化打印模板数据错误。";

		public const string TEXT_TEMPLATE_ERROR = "文本型打印模板尾行不能参与其他行的合并操作。";

		public const string EXPORT_ERROR = "{0}导出操作失败！";

		public const string INPUT_ERROR = "{0}导入操作失败，原因：文件格式错误或模板已存在！";

		public const string UPDATE_ERROR = "{0}更新操作失败，原因：文件格式错误或模板不匹配！";

		public const string NONE_BINDING_TEMPLATE_INFO = "未能搜索到已绑定界面模板信息，将导致该打印模板部分绑定数据丢失，是否继续？";

		public const string EXPORT_SUCCESS = "{0}导出成功。";

		public const string INPUT_SUCCESS = "{0}导入成功。";

		public const string UPDATE_SUCCESS = "{0}更新成功。";

		public const string FILE_NOT_SAVED = "{0}未保存，请保存后才执行导出操作！";

		public const string RICHTEXT_IN_TABLECELL = "表格单元中不能存在复杂文本格式！";

		public const string CONTAIN_INVALID_CHAR = "包含无效字符“{0}”。";

		public const string REPORT_FIELD_ROW_ERROR = "所有绑定的报表数据字段必须处于同一行中。";

		public const string REPORT_EPISODE_CON_ERROR = "至少要包含一个[入院日期]或[出院日期]条件!";

		public const string REPORT_DISDATA_CON_ERROR = "出院日期条件不能超过两个!";

		public const string CANNOT_SET_CONDITION = "非报表数据字段不能设置聚合条件！";

		public const string GROUPBY_FIELD_ERROR = "GROUPBY聚合字段前不能再插入数据字段！";

		public const string REPORT_DATA_ERROR = "报表数据字段聚合条件不统一，{0}不能保存！";

		public const string RUN_NOTSAVED_REPORT = "不能运行未保存的报表！";

		public const string NO_PUBLISHED_REPORT = "抱歉！没有已发布的报表可以运行。";

		public const string PICTURE_FILL_ERROR = "当前表格中已有元素，不能再加入图片";

		public const string PICTURE_FILL_OUT = "当前表格不属于插图区域，不能加入插图或其描述";

		public const string PRINT_BOTTOM_MOD_NUMBER = "底部结束行不能超过模板行数";

		public const string PRINT_TOP_BOTTOM_NUMBER = "顶部起始行不能大于底部结束行";

		public const string PRINT_BOTTOM_TOP_NUMBER = "底部结束行不能小于顶部起始行";

		public const string NULL_NAME_FORBIDDEN = "名称不能为空！";

		public const string SAVE_TEMPLATEXML = "界面信息有修改是否保存";

		public const string COMBINE_CELL = "选定区域包含多重数值，合并到一个单元格后只能保留最左上角的数据";

		public const string PRINT_COPY_FIGURE_MESSAGE = "只能复制、剪切一个插图单元";

		public const string PRINT_MODLE_TUNIT_MESSAGE = "固定单元格只能拖入T单元";

		public const string INTERFACE_MOLD_MESSAGE = "绑定的界面模板还没有发布，请先发布再绑定";

		public const string PRINT_DRAGDROP_PHOTO_F = "请在插图区域插入F单元";

		public const string PRINT_DRAGDROP_PHOTO_EMPTY_CELL = "选中区域中含有非空单元";

		public const string PRINT_MODLE_MESSAGE = "模板类型不一致，不能相互复制";

		public const string REFORDER_MESSAGE = "参数是否有效";

		public const string ERROR_BINDING_GET = "获取{0}错误！";

		public const string ERROR_BINDING_DELETE = "删除{0}错误！";

		public const string ERROR_BINDING_ADD = "增加{0}错误！";

		public const string ERROR_BINDING_UPDATE = "修改{0}错误！";

		public const string ERROR_BINDING_INPUT = "请填写完整的{0}信息！";

		public const string ERROR_BINDING_SELECT = "请选择一个{0}！";

		public const string ERROR_BINDING_SELECT_ADD = "请选择一个需要增加{0}的{1}！";

		public const string ERROR_BINDING_SELECT_UPDATE = "请选择一个需要修改{0}的{1}！";

		public const string ERROR_BINDING_SELECT_DELETE = "请选择一个需要删除{0}的{1}！";

		public const string SUCCEED_BINDING_DELETE = "删除{0}成功！";

		public const string SUCCEED_BINDING_ADD = "增加{0}成功！";

		public const string SUCCEED_BINDING_UPDATE = "修改{0}成功！";

		public const string DUPLICATE_ITEM = "已经存在同名的{0}，请修改！";

		public const string ERROR_PRINT_INIT = "程序没有检测到打印机。请先安装打印机，否则，将无法正常设置模板！";

		public static void ShowErrorMessage(string message)
		{
			MessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public static void ShowErrorMessage(string message, params object[] objs)
		{
			string replacedMessage = MessageManager.getReplacedMessage(message, objs);
			MessageManager.ShowErrorMessage(replacedMessage);
		}

		public static DialogResult ShowWarningMessage(string message)
		{
			return MessageBox.Show(message, "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}

		public static DialogResult ShowWarningMessage(string message, params object[] objs)
		{
			string replacedMessage = MessageManager.getReplacedMessage(message, objs);
			return MessageManager.ShowWarningMessage(replacedMessage);
		}

		public static void ShowInformationMessage(string message)
		{
			MessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public static void ShowInformationMessage(string message, params object[] objs)
		{
			string replacedMessage = MessageManager.getReplacedMessage(message, objs);
			MessageManager.ShowInformationMessage(replacedMessage);
		}

		public static DialogResult ShowQuestionMessage(string message)
		{
			return MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		public static DialogResult ShowQuestionMessage(string message, params object[] objs)
		{
			string replacedMessage = MessageManager.getReplacedMessage(message, objs);
			return MessageManager.ShowQuestionMessage(replacedMessage);
		}

		public static string getReplacedMessage(string message, params object[] objs)
		{
			string text = message;
			for (int i = 0; i < objs.Length; i++)
			{
				text = text.Replace("{" + i.ToString() + "}", objs[i].ToString());
			}
			return text;
		}
	}
}
