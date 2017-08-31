using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace BOEPRDiagnosConfig
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EKBNodeDiagnos
	{
		private string idField;

		private long kBNodeIDField;

		private bool kBNodeIDFieldSpecified;

		private long kBTreeIDField;

		private bool kBTreeIDFieldSpecified;

		private long kBDiagnosIDField;

		private bool kBDiagnosIDFieldSpecified;

		private long activeFlagField;

		private bool activeFlagFieldSpecified;

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

		public long KBNodeID
		{
			get
			{
				return this.kBNodeIDField;
			}
			set
			{
				this.kBNodeIDField = value;
			}
		}

		[XmlIgnore]
		public bool KBNodeIDSpecified
		{
			get
			{
				return this.kBNodeIDFieldSpecified;
			}
			set
			{
				this.kBNodeIDFieldSpecified = value;
			}
		}

		public long KBTreeID
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

		[XmlIgnore]
		public bool KBTreeIDSpecified
		{
			get
			{
				return this.kBTreeIDFieldSpecified;
			}
			set
			{
				this.kBTreeIDFieldSpecified = value;
			}
		}

		public long KBDiagnosID
		{
			get
			{
				return this.kBDiagnosIDField;
			}
			set
			{
				this.kBDiagnosIDField = value;
			}
		}

		[XmlIgnore]
		public bool KBDiagnosIDSpecified
		{
			get
			{
				return this.kBDiagnosIDFieldSpecified;
			}
			set
			{
				this.kBDiagnosIDFieldSpecified = value;
			}
		}

		public long ActiveFlag
		{
			get
			{
				return this.activeFlagField;
			}
			set
			{
				this.activeFlagField = value;
			}
		}

		[XmlIgnore]
		public bool ActiveFlagSpecified
		{
			get
			{
				return this.activeFlagFieldSpecified;
			}
			set
			{
				this.activeFlagFieldSpecified = value;
			}
		}

		[DebuggerNonUserCode]
		public EKBNodeDiagnos()
		{
		}
	}
}
