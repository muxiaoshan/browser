using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectALLStdDicCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EStdDictionaryDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EStdDictionaryDataset)this.results[0];
			}
		}

		internal SelectALLStdDicCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
