using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace InstanceDataInfo
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetParentGroupListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EInsGroupNewDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EInsGroupNewDataSet)this.results[0];
			}
		}

		internal GetParentGroupListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
