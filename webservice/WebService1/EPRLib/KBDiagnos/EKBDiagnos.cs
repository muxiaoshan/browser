using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace KBDiagnos
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EKBDiagnos
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private string diagnosField;

		private string cTLocIDField;

		private string userIDField;

		private string createDateField;

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

		public string Diagnos
		{
			get
			{
				return this.diagnosField;
			}
			set
			{
				this.diagnosField = value;
			}
		}

		public string CTLocID
		{
			get
			{
				return this.cTLocIDField;
			}
			set
			{
				this.cTLocIDField = value;
			}
		}

		public string UserID
		{
			get
			{
				return this.userIDField;
			}
			set
			{
				this.userIDField = value;
			}
		}

		public string CreateDate
		{
			get
			{
				return this.createDateField;
			}
			set
			{
				this.createDateField = value;
			}
		}

		[DebuggerNonUserCode]
		public EKBDiagnos()
		{
		}
	}
}
