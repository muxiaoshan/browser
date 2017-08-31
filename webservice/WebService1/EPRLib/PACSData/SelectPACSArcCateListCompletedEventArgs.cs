using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PACSData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectPACSArcCateListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EPACSArcCateListDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EPACSArcCateListDataSet)this.results[0];
			}
		}

		internal SelectPACSArcCateListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
