using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BOEPRDiagnosConfig
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetKBNodeDiagnosByIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKBNodeDiagnos Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKBNodeDiagnos)this.results[0];
			}
		}

		internal GetKBNodeDiagnosByIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}