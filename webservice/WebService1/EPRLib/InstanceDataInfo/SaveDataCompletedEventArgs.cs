using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace InstanceDataInfo
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SaveDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EInstanceData Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EInstanceData)this.results[0];
			}
		}

		public EMixInstanceLog AEMixInstanceLog
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EMixInstanceLog)this.results[1];
			}
		}

		public string AErrorMessage
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToString(this.results[2]);
			}
		}

		internal SaveDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
