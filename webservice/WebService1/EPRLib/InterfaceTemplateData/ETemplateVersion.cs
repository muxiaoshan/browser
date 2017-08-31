using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class ETemplateVersion
	{
		private string authorField;

		private DateTime createDateField;

		private bool createDateFieldSpecified;

		private DateTime createTimeField;

		private bool createTimeFieldSpecified;

		private string idField;

		private string initialDataField;

		private DateTime lastSaveDateField;

		private bool lastSaveDateFieldSpecified;

		private DateTime lastSaveTimeField;

		private bool lastSaveTimeFieldSpecified;

		private string metaDataField;

		private string presentationDataField;

		private DateTime publicationDateField;

		private bool publicationDateFieldSpecified;

		private DateTime publicationTimeField;

		private bool publicationTimeFieldSpecified;

		private long statusField;

		private bool statusFieldSpecified;

		private string templateIDField;

		private long versionNumberField;

		private bool versionNumberFieldSpecified;

		public string Author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		[XmlElement(DataType = "date")]
		public DateTime CreateDate
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

		[XmlIgnore]
		public bool CreateDateSpecified
		{
			get
			{
				return this.createDateFieldSpecified;
			}
			set
			{
				this.createDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime CreateTime
		{
			get
			{
				return this.createTimeField;
			}
			set
			{
				this.createTimeField = value;
			}
		}

		[XmlIgnore]
		public bool CreateTimeSpecified
		{
			get
			{
				return this.createTimeFieldSpecified;
			}
			set
			{
				this.createTimeFieldSpecified = value;
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

		public string InitialData
		{
			get
			{
				return this.initialDataField;
			}
			set
			{
				this.initialDataField = value;
			}
		}

		[XmlElement(DataType = "date")]
		public DateTime LastSaveDate
		{
			get
			{
				return this.lastSaveDateField;
			}
			set
			{
				this.lastSaveDateField = value;
			}
		}

		[XmlIgnore]
		public bool LastSaveDateSpecified
		{
			get
			{
				return this.lastSaveDateFieldSpecified;
			}
			set
			{
				this.lastSaveDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime LastSaveTime
		{
			get
			{
				return this.lastSaveTimeField;
			}
			set
			{
				this.lastSaveTimeField = value;
			}
		}

		[XmlIgnore]
		public bool LastSaveTimeSpecified
		{
			get
			{
				return this.lastSaveTimeFieldSpecified;
			}
			set
			{
				this.lastSaveTimeFieldSpecified = value;
			}
		}

		public string MetaData
		{
			get
			{
				return this.metaDataField;
			}
			set
			{
				this.metaDataField = value;
			}
		}

		public string PresentationData
		{
			get
			{
				return this.presentationDataField;
			}
			set
			{
				this.presentationDataField = value;
			}
		}

		[XmlElement(DataType = "date")]
		public DateTime PublicationDate
		{
			get
			{
				return this.publicationDateField;
			}
			set
			{
				this.publicationDateField = value;
			}
		}

		[XmlIgnore]
		public bool PublicationDateSpecified
		{
			get
			{
				return this.publicationDateFieldSpecified;
			}
			set
			{
				this.publicationDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime PublicationTime
		{
			get
			{
				return this.publicationTimeField;
			}
			set
			{
				this.publicationTimeField = value;
			}
		}

		[XmlIgnore]
		public bool PublicationTimeSpecified
		{
			get
			{
				return this.publicationTimeFieldSpecified;
			}
			set
			{
				this.publicationTimeFieldSpecified = value;
			}
		}

		public long Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		[XmlIgnore]
		public bool StatusSpecified
		{
			get
			{
				return this.statusFieldSpecified;
			}
			set
			{
				this.statusFieldSpecified = value;
			}
		}

		public string TemplateID
		{
			get
			{
				return this.templateIDField;
			}
			set
			{
				this.templateIDField = value;
			}
		}

		public long VersionNumber
		{
			get
			{
				return this.versionNumberField;
			}
			set
			{
				this.versionNumberField = value;
			}
		}

		[XmlIgnore]
		public bool VersionNumberSpecified
		{
			get
			{
				return this.versionNumberFieldSpecified;
			}
			set
			{
				this.versionNumberFieldSpecified = value;
			}
		}

		[DebuggerNonUserCode]
		public ETemplateVersion()
		{
		}
	}
}
