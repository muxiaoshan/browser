using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace BindQueryData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EBindQuery
	{
		private string classNameField;

		private string descriptionField;

		private string idField;

		private string nameField;

		private string queryNameField;

		private string singleResultField;

		public string ClassName
		{
			get
			{
				return this.classNameField;
			}
			set
			{
				this.classNameField = value;
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

		public string QueryName
		{
			get
			{
				return this.queryNameField;
			}
			set
			{
				this.queryNameField = value;
			}
		}

		public string SingleResult
		{
			get
			{
				return this.singleResultField;
			}
			set
			{
				this.singleResultField = value;
			}
		}

		[DebuggerNonUserCode]
		public EBindQuery()
		{
		}
	}
}
