using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace KBNodeData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EKBNode
	{
		private string descriptionField;

		private string idField;

		private string kBTreeIDField;

		private string knowledgeBaseIDField;

		private string nameField;

		private string s1InstanceDataField;

		private string s1MetaDataField;

		private string s2InstanceDataField;

		private string s2MetaDataField;

		private string s3InstanceDataField;

		private string s3MetaDataField;

		private string sequenceField;

		private string isCommonField;

		private string isInUseField;

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

		public string KBTreeID
		{
			get
			{
				return this.kBTreeIDField;
			}
			set
			{
				this.kBTreeIDField = value;
			}
		}

		public string KnowledgeBaseID
		{
			get
			{
				return this.knowledgeBaseIDField;
			}
			set
			{
				this.knowledgeBaseIDField = value;
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

		public string S1InstanceData
		{
			get
			{
				return this.s1InstanceDataField;
			}
			set
			{
				this.s1InstanceDataField = value;
			}
		}

		public string S1MetaData
		{
			get
			{
				return this.s1MetaDataField;
			}
			set
			{
				this.s1MetaDataField = value;
			}
		}

		public string S2InstanceData
		{
			get
			{
				return this.s2InstanceDataField;
			}
			set
			{
				this.s2InstanceDataField = value;
			}
		}

		public string S2MetaData
		{
			get
			{
				return this.s2MetaDataField;
			}
			set
			{
				this.s2MetaDataField = value;
			}
		}

		public string S3InstanceData
		{
			get
			{
				return this.s3InstanceDataField;
			}
			set
			{
				this.s3InstanceDataField = value;
			}
		}

		public string S3MetaData
		{
			get
			{
				return this.s3MetaDataField;
			}
			set
			{
				this.s3MetaDataField = value;
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

		public string IsCommon
		{
			get
			{
				return this.isCommonField;
			}
			set
			{
				this.isCommonField = value;
			}
		}

		public string IsInUse
		{
			get
			{
				return this.isInUseField;
			}
			set
			{
				this.isInUseField = value;
			}
		}

		[DebuggerNonUserCode]
		public EKBNode()
		{
		}
	}
}
