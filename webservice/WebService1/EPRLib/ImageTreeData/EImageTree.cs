using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ImageTreeData
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EImageTree
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private string imageLibIDField;

		private string parentIDField;

		private string userIDField;

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

		public string ImageLibID
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

		public string UserID
		{
			get
			{
				return this.userIDField;
			}
			set
			{
				this.userIDField = value;
			}
		}

		[DebuggerNonUserCode]
		public EImageTree()
		{
		}
	}
}
