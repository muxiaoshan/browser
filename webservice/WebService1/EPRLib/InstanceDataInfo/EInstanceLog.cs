using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace InstanceDataInfo
{
	[GeneratedCode("System.Xml", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
	[Serializable]
	public class EInstanceLog
	{
		private string actionField;

		private string operateDateField;

		private string finalStatusField;

		private string initStatusField;

		private string operateTimeField;

		private string operateUserIDField;

		private string operateMachineIPField;

		private string realOperateUserIDField;

		private string operateUserNameField;

		public string Action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		public string OperateDate
		{
			get
			{
				return this.operateDateField;
			}
			set
			{
				this.operateDateField = value;
			}
		}

		public string FinalStatus
		{
			get
			{
				return this.finalStatusField;
			}
			set
			{
				this.finalStatusField = value;
			}
		}

		public string InitStatus
		{
			get
			{
				return this.initStatusField;
			}
			set
			{
				this.initStatusField = value;
			}
		}

		public string OperateTime
		{
			get
			{
				return this.operateTimeField;
			}
			set
			{
				this.operateTimeField = value;
			}
		}

		public string OperateUserID
		{
			get
			{
				return this.operateUserIDField;
			}
			set
			{
				this.operateUserIDField = value;
			}
		}

		public string OperateMachineIP
		{
			get
			{
				return this.operateMachineIPField;
			}
			set
			{
				this.operateMachineIPField = value;
			}
		}

		public string RealOperateUserID
		{
			get
			{
				return this.realOperateUserIDField;
			}
			set
			{
				this.realOperateUserIDField = value;
			}
		}

		public string OperateUserName
		{
			get
			{
				return this.operateUserNameField;
			}
			set
			{
				this.operateUserNameField = value;
			}
		}

		[DebuggerNonUserCode]
		public EInstanceLog()
		{
		}
	}
}
