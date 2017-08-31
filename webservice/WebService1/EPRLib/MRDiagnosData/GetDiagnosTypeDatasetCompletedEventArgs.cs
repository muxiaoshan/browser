using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MRDiagnosData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDiagnosTypeDatasetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EMRDiagnosTypeDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EMRDiagnosTypeDataset)this.results[0];
			}
		}

		internal GetDiagnosTypeDatasetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
