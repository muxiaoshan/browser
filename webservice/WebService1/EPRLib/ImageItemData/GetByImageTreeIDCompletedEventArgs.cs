using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ImageItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetByImageTreeIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EImageItemDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EImageItemDataSet)this.results[0];
			}
		}

		internal GetByImageTreeIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
