using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetStdDicListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (DataSet)this.results[0];
			}
		}

		internal GetStdDicListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
