using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BindQueryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectParameterByQIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EBindParameterDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EBindParameterDataset)this.results[0];
			}
		}

		internal SelectParameterByQIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
