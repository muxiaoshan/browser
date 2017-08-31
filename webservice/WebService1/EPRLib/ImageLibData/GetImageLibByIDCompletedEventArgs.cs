using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ImageLibData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetImageLibByIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EImageLib Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EImageLib)this.results[0];
			}
		}

		internal GetImageLibByIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}