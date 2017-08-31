using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AdmImageItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetEntityCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EAdmImageItem Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EAdmImageItem)this.results[0];
			}
		}

		internal GetEntityCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
