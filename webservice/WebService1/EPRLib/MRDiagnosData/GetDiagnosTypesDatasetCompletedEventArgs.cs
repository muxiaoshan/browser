using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MRDiagnosData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDiagnosTypesDatasetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EMRDiagnosStatuesTypeDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EMRDiagnosStatuesTypeDataset)this.results[0];
			}
		}

		internal GetDiagnosTypesDatasetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
