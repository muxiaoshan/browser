using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetStdDicitonaryByIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EStdDictionary Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EStdDictionary)this.results[0];
			}
		}

		internal GetStdDicitonaryByIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
