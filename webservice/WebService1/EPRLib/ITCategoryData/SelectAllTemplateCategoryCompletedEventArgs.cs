using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ITCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectAllTemplateCategoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ETemplateCategoryDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (ETemplateCategoryDataset)this.results[0];
			}
		}

		internal SelectAllTemplateCategoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
