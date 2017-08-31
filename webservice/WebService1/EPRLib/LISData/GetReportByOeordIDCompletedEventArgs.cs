using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LISData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetReportByOeordIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ELISReportByOeordIDDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (ELISReportByOeordIDDataSet)this.results[0];
			}
		}

		internal GetReportByOeordIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
