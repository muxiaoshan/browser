using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SysOptionData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class ESysOption
	{
		private string isVisibleField;

		private string descriptionField;

		private string idField;

		private string nameField;

		private string optionValueField;

		public string IsVisible
		{
			get
			{
				return this.isVisibleField;
			}
			set
			{
				this.isVisibleField = value;
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

		public string OptionValue
		{
			get
			{
				return this.optionValueField;
			}
			set
			{
				this.optionValueField = value;
			}
		}

		[DebuggerNonUserCode]
		public ESysOption()
		{
		}
	}
}
