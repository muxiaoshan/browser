using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace BindQueryData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EBindField
	{
		private string descriptionField;

		private string fieldNameField;

		private string fieldTypeField;

		private string idField;

		private string nameField;

		private string queryIDField;

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

		public string FieldName
		{
			get
			{
				return this.fieldNameField;
			}
			set
			{
				this.fieldNameField = value;
			}
		}

		public string FieldType
		{
			get
			{
				return this.fieldTypeField;
			}
			set
			{
				this.fieldTypeField = value;
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

		public string QueryID
		{
			get
			{
				return this.queryIDField;
			}
			set
			{
				this.queryIDField = value;
			}
		}

		[DebuggerNonUserCode]
		public EBindField()
		{
		}
	}
}
