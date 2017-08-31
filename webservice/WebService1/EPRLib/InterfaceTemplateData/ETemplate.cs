using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class ETemplate
	{
		private string bindPrintNameField;

		private string bindPrintTemplateIDField;

		private string chartItemTypeField;

		private string descriptionField;

		private string gUIDField;

		private string idField;

		private long lastVersionField;

		private bool lastVersionFieldSpecified;

		private string nameField;

		private long publishVersionField;

		private bool publishVersionFieldSpecified;

		private string templateCategoryIDField;

		private string templatePropertyField;

		public string BindPrintName
		{
			get
			{
				return this.bindPrintNameField;
			}
			set
			{
				this.bindPrintNameField = value;
			}
		}

		public string BindPrintTemplateID
		{
			get
			{
				return this.bindPrintTemplateIDField;
			}
			set
			{
				this.bindPrintTemplateIDField = value;
			}
		}

		public string ChartItemType
		{
			get
			{
				return this.chartItemTypeField;
			}
			set
			{
				this.chartItemTypeField = value;
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

		public string GUID
		{
			get
			{
				return this.gUIDField;
			}
			set
			{
				this.gUIDField = value;
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

		public long LastVersion
		{
			get
			{
				return this.lastVersionField;
			}
			set
			{
				this.lastVersionField = value;
			}
		}

		[XmlIgnore]
		public bool LastVersionSpecified
		{
			get
			{
				return this.lastVersionFieldSpecified;
			}
			set
			{
				this.lastVersionFieldSpecified = value;
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

		public long PublishVersion
		{
			get
			{
				return this.publishVersionField;
			}
			set
			{
				this.publishVersionField = value;
			}
		}

		[XmlIgnore]
		public bool PublishVersionSpecified
		{
			get
			{
				return this.publishVersionFieldSpecified;
			}
			set
			{
				this.publishVersionFieldSpecified = value;
			}
		}

		public string TemplateCategoryID
		{
			get
			{
				return this.templateCategoryIDField;
			}
			set
			{
				this.templateCategoryIDField = value;
			}
		}

		public string TemplateProperty
		{
			get
			{
				return this.templatePropertyField;
			}
			set
			{
				this.templatePropertyField = value;
			}
		}

		[DebuggerNonUserCode]
		public ETemplate()
		{
		}
	}
}
