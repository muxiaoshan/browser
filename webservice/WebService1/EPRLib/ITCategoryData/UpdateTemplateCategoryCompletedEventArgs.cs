using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ITCategoryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class UpdateTemplateCategoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public bool UpdateTemplateCategoryResult
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[0]);
			}
		}

		public bool UpdateTemplateCategoryResultSpecified
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[1]);
			}
		}

		internal UpdateTemplateCategoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
