using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GlossaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectAllGlossaryByCategoryIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EGlossaryDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EGlossaryDataset)this.results[0];
			}
		}

		internal SelectAllGlossaryByCategoryIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}