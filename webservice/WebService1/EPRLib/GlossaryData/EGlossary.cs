using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace GlossaryData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EGlossary
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private string gUIDField;

		private string glossaryCategoryIDField;

		private string metaItemDataField;

		private string bindItemDataField;

		private DateTime createDateField;

		private bool createDateFieldSpecified;

		private DateTime createTimeField;

		private bool createTimeFieldSpecified;

		private DateTime lastModifyDateField;

		private bool lastModifyDateFieldSpecified;

		private DateTime lastModifyTimeField;

		private bool lastModifyTimeFieldSpecified;

		private string glossaryTypeField;

		private string parentIDField;

		private long childCountField;

		private bool childCountFieldSpecified;

		private string internalIDField;

		private string metaIDField;

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

		public string GlossaryCategoryID
		{
			get
			{
				return this.glossaryCategoryIDField;
			}
			set
			{
				this.glossaryCategoryIDField = value;
			}
		}

		public string MetaItemData
		{
			get
			{
				return this.metaItemDataField;
			}
			set
			{
				this.metaItemDataField = value;
			}
		}

		public string BindItemData
		{
			get
			{
				return this.bindItemDataField;
			}
			set
			{
				this.bindItemDataField = value;
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

		[XmlElement(DataType = "date")]
		public DateTime LastModifyDate
		{
			get
			{
				return this.lastModifyDateField;
			}
			set
			{
				this.lastModifyDateField = value;
			}
		}

		[XmlIgnore]
		public bool LastModifyDateSpecified
		{
			get
			{
				return this.lastModifyDateFieldSpecified;
			}
			set
			{
				this.lastModifyDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime LastModifyTime
		{
			get
			{
				return this.lastModifyTimeField;
			}
			set
			{
				this.lastModifyTimeField = value;
			}
		}

		[XmlIgnore]
		public bool LastModifyTimeSpecified
		{
			get
			{
				return this.lastModifyTimeFieldSpecified;
			}
			set
			{
				this.lastModifyTimeFieldSpecified = value;
			}
		}

		public string GlossaryType
		{
			get
			{
				return this.glossaryTypeField;
			}
			set
			{
				this.glossaryTypeField = value;
			}
		}

		public string ParentID
		{
			get
			{
				return this.parentIDField;
			}
			set
			{
				this.parentIDField = value;
			}
		}

		public long ChildCount
		{
			get
			{
				return this.childCountField;
			}
			set
			{
				this.childCountField = value;
			}
		}

		[XmlIgnore]
		public bool ChildCountSpecified
		{
			get
			{
				return this.childCountFieldSpecified;
			}
			set
			{
				this.childCountFieldSpecified = value;
			}
		}

		public string InternalID
		{
			get
			{
				return this.internalIDField;
			}
			set
			{
				this.internalIDField = value;
			}
		}

		public string MetaID
		{
			get
			{
				return this.metaIDField;
			}
			set
			{
				this.metaIDField = value;
			}
		}

		[DebuggerNonUserCode]
		public EGlossary()
		{
		}
	}
}
