using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace InstanceDataInfo
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EInstanceData
	{
		private string categoryIDField;

		private string categoryTypeField;

		private string chartItemIDField;

		private string chartItemTypeField;

		private DateTime createDateField;

		private bool createDateFieldSpecified;

		private DateTime createTimeField;

		private bool createTimeFieldSpecified;

		private string createUserField;

		private string episodeIDField;

		private string groupItemIDField;

		private string groupItemNameField;

		private DateTime happenDateField;

		private bool happenDateFieldSpecified;

		private DateTime happenTimeField;

		private bool happenTimeFieldSpecified;

		private string idField;

		private string instanceDataField;

		private string listNoField;

		private string metaDataField;

		private DateTime modifyDateField;

		private bool modifyDateFieldSpecified;

		private DateTime modifyTimeField;

		private bool modifyTimeFieldSpecified;

		private string modifyUserField;

		private string patientIDField;

		private string presentationDataField;

		private string statusField;

		private string templateIDField;

		private long templateVersionField;

		private bool templateVersionFieldSpecified;

		private string theECRecordField;

		private string titleField;

		private string remarkField;

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

		public string CategoryType
		{
			get
			{
				return this.categoryTypeField;
			}
			set
			{
				this.categoryTypeField = value;
			}
		}

		public string ChartItemID
		{
			get
			{
				return this.chartItemIDField;
			}
			set
			{
				this.chartItemIDField = value;
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

		public string CreateUser
		{
			get
			{
				return this.createUserField;
			}
			set
			{
				this.createUserField = value;
			}
		}

		public string EpisodeID
		{
			get
			{
				return this.episodeIDField;
			}
			set
			{
				this.episodeIDField = value;
			}
		}

		public string GroupItemID
		{
			get
			{
				return this.groupItemIDField;
			}
			set
			{
				this.groupItemIDField = value;
			}
		}

		public string GroupItemName
		{
			get
			{
				return this.groupItemNameField;
			}
			set
			{
				this.groupItemNameField = value;
			}
		}

		[XmlElement(DataType = "date")]
		public DateTime HappenDate
		{
			get
			{
				return this.happenDateField;
			}
			set
			{
				this.happenDateField = value;
			}
		}

		[XmlIgnore]
		public bool HappenDateSpecified
		{
			get
			{
				return this.happenDateFieldSpecified;
			}
			set
			{
				this.happenDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime HappenTime
		{
			get
			{
				return this.happenTimeField;
			}
			set
			{
				this.happenTimeField = value;
			}
		}

		[XmlIgnore]
		public bool HappenTimeSpecified
		{
			get
			{
				return this.happenTimeFieldSpecified;
			}
			set
			{
				this.happenTimeFieldSpecified = value;
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

		public string InstanceData
		{
			get
			{
				return this.instanceDataField;
			}
			set
			{
				this.instanceDataField = value;
			}
		}

		public string ListNo
		{
			get
			{
				return this.listNoField;
			}
			set
			{
				this.listNoField = value;
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

		[XmlElement(DataType = "date")]
		public DateTime ModifyDate
		{
			get
			{
				return this.modifyDateField;
			}
			set
			{
				this.modifyDateField = value;
			}
		}

		[XmlIgnore]
		public bool ModifyDateSpecified
		{
			get
			{
				return this.modifyDateFieldSpecified;
			}
			set
			{
				this.modifyDateFieldSpecified = value;
			}
		}

		[XmlElement(DataType = "time")]
		public DateTime ModifyTime
		{
			get
			{
				return this.modifyTimeField;
			}
			set
			{
				this.modifyTimeField = value;
			}
		}

		[XmlIgnore]
		public bool ModifyTimeSpecified
		{
			get
			{
				return this.modifyTimeFieldSpecified;
			}
			set
			{
				this.modifyTimeFieldSpecified = value;
			}
		}

		public string ModifyUser
		{
			get
			{
				return this.modifyUserField;
			}
			set
			{
				this.modifyUserField = value;
			}
		}

		public string PatientID
		{
			get
			{
				return this.patientIDField;
			}
			set
			{
				this.patientIDField = value;
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

		public string Status
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

		public long TemplateVersion
		{
			get
			{
				return this.templateVersionField;
			}
			set
			{
				this.templateVersionField = value;
			}
		}

		[XmlIgnore]
		public bool TemplateVersionSpecified
		{
			get
			{
				return this.templateVersionFieldSpecified;
			}
			set
			{
				this.templateVersionFieldSpecified = value;
			}
		}

		public string TheECRecord
		{
			get
			{
				return this.theECRecordField;
			}
			set
			{
				this.theECRecordField = value;
			}
		}

		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		public string Remark
		{
			get
			{
				return this.remarkField;
			}
			set
			{
				this.remarkField = value;
			}
		}

		[DebuggerNonUserCode]
		public EInstanceData()
		{
		}
	}
}
