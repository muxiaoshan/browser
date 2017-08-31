using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DictionaryData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EStdDictionary
	{
		private string codeField;

		private string descriptionField;

		private string dicAliasColField;

		private string dicCodeColField;

		private string dicDescColField;

		private string idField;

		private string nameField;

		private string tableNameField;

		private string isRuleTypeField;

		private string ruleTypeTagField;

		private string conditionField;

		private string conditionCodeField;

		private string isDiagnosRuleTypeField;

		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}

		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		public string DicAliasCol
		{
			get
			{
				return this.dicAliasColField;
			}
			set
			{
				this.dicAliasColField = value;
			}
		}

		public string DicCodeCol
		{
			get
			{
				return this.dicCodeColField;
			}
			set
			{
				this.dicCodeColField = value;
			}
		}

		public string DicDescCol
		{
			get
			{
				return this.dicDescColField;
			}
			set
			{
				this.dicDescColField = value;
			}
		}

		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		public string TableName
		{
			get
			{
				return this.tableNameField;
			}
			set
			{
				this.tableNameField = value;
			}
		}

		public string IsRuleType
		{
			get
			{
				return this.isRuleTypeField;
			}
			set
			{
				this.isRuleTypeField = value;
			}
		}

		public string RuleTypeTag
		{
			get
			{
				return this.ruleTypeTagField;
			}
			set
			{
				this.ruleTypeTagField = value;
			}
		}

		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		public string ConditionCode
		{
			get
			{
				return this.conditionCodeField;
			}
			set
			{
				this.conditionCodeField = value;
			}
		}

		public string IsDiagnosRuleType
		{
			get
			{
				return this.isDiagnosRuleTypeField;
			}
			set
			{
				this.isDiagnosRuleTypeField = value;
			}
		}

		[DebuggerNonUserCode]
		public EStdDictionary()
		{
		}
	}
}
