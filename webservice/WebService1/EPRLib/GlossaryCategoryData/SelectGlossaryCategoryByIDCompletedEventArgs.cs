using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GlossaryCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectGlossaryCategoryByIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EGlossaryCategory Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EGlossaryCategory)this.results[0];
			}
		}

		internal SelectGlossaryCategoryByIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}