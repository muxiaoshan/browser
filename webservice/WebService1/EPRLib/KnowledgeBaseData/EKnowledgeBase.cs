using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace KnowledgeBaseData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EKnowledgeBase
	{
		private string descriptionField;

		private string idField;

		private string kBCategoryIDField;

		private string nameField;

		private string s1NameField;

		private string s2NameField;

		private string s3NameField;

		private long segmentNumberField;

		private bool segmentNumberFieldSpecified;

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

		public string KBCategoryID
		{
			get
			{
				return this.kBCategoryIDField;
			}
			set
			{
				this.kBCategoryIDField = value;
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

		public string S1Name
		{
			get
			{
				return this.s1NameField;
			}
			set
			{
				this.s1NameField = value;
			}
		}

		public string S2Name
		{
			get
			{
				return this.s2NameField;
			}
			set
			{
				this.s2NameField = value;
			}
		}

		public string S3Name
		{
			get
			{
				return this.s3NameField;
			}
			set
			{
				this.s3NameField = value;
			}
		}

		public long SegmentNumber
		{
			get
			{
				return this.segmentNumberField;
			}
			set
			{
				this.segmentNumberField = value;
			}
		}

		[XmlIgnore]
		public bool SegmentNumberSpecified
		{
			get
			{
				return this.segmentNumberFieldSpecified;
			}
			set
			{
				this.segmentNumberFieldSpecified = value;
			}
		}

		[DebuggerNonUserCode]
		public EKnowledgeBase()
		{
		}
	}
}
