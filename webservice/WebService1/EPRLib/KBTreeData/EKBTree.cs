using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace KBTreeData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EKBTree
	{
		private string descriptionField;

		private string idField;

		private string knowledgeBaseIDField;

		private string nameField;

		private string parentIDField;

		private long sequenceField;

		private bool sequenceFieldSpecified;

		private long resChildCountField;

		private bool resChildCountFieldSpecified;

		private string personalKBUserIDField;

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

		public long Sequence
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

		[XmlIgnore]
		public bool SequenceSpecified
		{
			get
			{
				return this.sequenceFieldSpecified;
			}
			set
			{
				this.sequenceFieldSpecified = value;
			}
		}

		public long ResChildCount
		{
			get
			{
				return this.resChildCountField;
			}
			set
			{
				this.resChildCountField = value;
			}
		}

		[XmlIgnore]
		public bool ResChildCountSpecified
		{
			get
			{
				return this.resChildCountFieldSpecified;
			}
			set
			{
				this.resChildCountFieldSpecified = value;
			}
		}

		public string PersonalKBUserID
		{
			get
			{
				return this.personalKBUserIDField;
			}
			set
			{
				this.personalKBUserIDField = value;
			}
		}

		[DebuggerNonUserCode]
		public EKBTree()
		{
		}
	}
}
