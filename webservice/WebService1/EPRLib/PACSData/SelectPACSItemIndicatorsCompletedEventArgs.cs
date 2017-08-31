using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PACSData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectPACSItemIndicatorsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EPACSItemIndicatorsDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EPACSItemIndicatorsDataSet)this.results[0];
			}
		}

		internal SelectPACSItemIndicatorsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
