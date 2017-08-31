using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ImageItemData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EImageItem
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private long imageLibIDField;

		private bool imageLibIDFieldSpecified;

		private long imageTreeIDField;

		private bool imageTreeIDFieldSpecified;

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

		public long ImageLibID
		{
			get
			{
				return this.imageLibIDField;
			}
			set
			{
				this.imageLibIDField = value;
			}
		}

		[XmlIgnore]
		public bool ImageLibIDSpecified
		{
			get
			{
				return this.imageLibIDFieldSpecified;
			}
			set
			{
				this.imageLibIDFieldSpecified = value;
			}
		}

		public long ImageTreeID
		{
			get
			{
				return this.imageTreeIDField;
			}
			set
			{
				this.imageTreeIDField = value;
			}
		}

		[XmlIgnore]
		public bool ImageTreeIDSpecified
		{
			get
			{
				return this.imageTreeIDFieldSpecified;
			}
			set
			{
				this.imageTreeIDFieldSpecified = value;
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
		public EImageItem()
		{
		}
	}
}
