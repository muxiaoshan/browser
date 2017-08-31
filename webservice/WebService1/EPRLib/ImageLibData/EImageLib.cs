using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ImageLibData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EImageLib
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private string categoryIDField;

		private string sequenceField;

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

		public string CategoryID
		{
			get
			{
				return this.categoryIDField;
			}
			set
			{
				this.categoryIDField = value;
			}
		}

		public string Sequence
		{
			get
			{
				return this.sequenceField;
			}
			set
			{
				this.sequenceField = value;
			}
		}

		[DebuggerNonUserCode]
		public EImageLib()
		{
		}
	}
}
