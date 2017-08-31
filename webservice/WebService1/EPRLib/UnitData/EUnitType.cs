using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace UnitData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EUnitType
	{
		private string cHSNameField;

		private string codeField;

		private string eNGNameField;

		private string idField;

		public string CHSName
		{
			get
			{
				return this.cHSNameField;
			}
			set
			{
				this.cHSNameField = value;
			}
		}

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

		public string ENGName
		{
			get
			{
				return this.eNGNameField;
			}
			set
			{
				this.eNGNameField = value;
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

		[DebuggerNonUserCode]
		public EUnitType()
		{
		}
	}
}
