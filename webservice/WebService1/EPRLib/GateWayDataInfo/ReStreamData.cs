using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace GateWayDataInfo
{
	[GeneratedCode("System.Xml", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class ReStreamData
	{
		private string streamDataField;

		public string StreamData
		{
			get
			{
				return this.streamDataField;
			}
			set
			{
				this.streamDataField = value;
			}
		}

		[DebuggerNonUserCode]
		public ReStreamData()
		{
		}
	}
}
