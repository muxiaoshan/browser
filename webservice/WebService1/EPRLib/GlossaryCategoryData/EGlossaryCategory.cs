using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace GlossaryCategoryData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EGlossaryCategory
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private string parentIDField;

		private long resChildCountField;

		private bool resChildCountFieldSpecified;

		private string internalIDField;

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

		[DebuggerNonUserCode]
		public EGlossaryCategory()
		{
		}
	}
}
