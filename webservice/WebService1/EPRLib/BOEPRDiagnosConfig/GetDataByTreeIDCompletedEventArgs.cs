using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BOEPRDiagnosConfig
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDataByTreeIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKBDiagnosConfigDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKBDiagnosConfigDataSet)this.results[0];
			}
		}

		internal GetDataByTreeIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
