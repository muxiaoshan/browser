using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CustomDictoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetAllDiagnosTypeByTitleCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EDiagnosTypeByTitle Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EDiagnosTypeByTitle)this.results[0];
			}
		}

		internal GetAllDiagnosTypeByTitleCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}