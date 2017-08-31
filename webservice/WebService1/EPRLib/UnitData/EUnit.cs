using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace UnitData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EUnit
	{
		private string cHSMeasurementNameField;

		private string codeField;

		private string coefficientField;

		private string conversionField;

		private string defaultUnitField;

		private string eNGMeasurementNameField;

		private string idField;

		private string symbolField;

		public string CHSMeasurementName
		{
			get
			{
				return this.cHSMeasurementNameField;
			}
			set
			{
				this.cHSMeasurementNameField = value;
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

		public string Coefficient
		{
			get
			{
				return this.coefficientField;
			}
			set
			{
				this.coefficientField = value;
			}
		}

		public string Conversion
		{
			get
			{
				return this.conversionField;
			}
			set
			{
				this.conversionField = value;
			}
		}

		public string DefaultUnit
		{
			get
			{
				return this.defaultUnitField;
			}
			set
			{
				this.defaultUnitField = value;
			}
		}

		public string ENGMeasurementName
		{
			get
			{
				return this.eNGMeasurementNameField;
			}
			set
			{
				this.eNGMeasurementNameField = value;
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

		public string Symbol
		{
			get
			{
				return this.symbolField;
			}
			set
			{
				this.symbolField = value;
			}
		}

		[DebuggerNonUserCode]
		public EUnit()
		{
		}
	}
}
