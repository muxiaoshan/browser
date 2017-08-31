using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AdmImageItemData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EAdmImageItem
	{
		private string idField;

		private string episodeIDField;

		private string nameField;

		private string descriptionField;

		private DateTime createDateField;

		private bool createDateFieldSpecified;

		private DateTime createTimeField;

		private bool createTimeFieldSpecified;

		private byte[] imageDataField;

		private string hotSpotDataField;

		private string iconDataField;

		private string statusField;

		private string isPublishField;

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

		[XmlElement(DataType = "base64Binary")]
		public byte[] ImageData
		{
			get
			{
				return this.imageDataField;
			}
			set
			{
				this.imageDataField = value;
			}
		}

		public string HotSpotData
		{
			get
			{
				return this.hotSpotDataField;
			}
			set
			{
				this.hotSpotDataField = value;
			}
		}

		public string IconData
		{
			get
			{
				return this.iconDataField;
			}
			set
			{
				this.iconDataField = value;
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

		public string IsPublish
		{
			get
			{
				return this.isPublishField;
			}
			set
			{
				this.isPublishField = value;
			}
		}

		[DebuggerNonUserCode]
		public EAdmImageItem()
		{
		}
	}
}
