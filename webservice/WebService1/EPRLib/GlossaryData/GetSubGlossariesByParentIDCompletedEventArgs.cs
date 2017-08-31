using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GlossaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetSubGlossariesByParentIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EGlossarySubDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EGlossarySubDataset)this.results[0];
			}
		}

		internal GetSubGlossariesByParentIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}