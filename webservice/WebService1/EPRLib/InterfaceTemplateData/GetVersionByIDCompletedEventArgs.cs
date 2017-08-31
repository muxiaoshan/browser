using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetVersionByIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ETemplateVersion Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (ETemplateVersion)this.results[0];
			}
		}

		internal GetVersionByIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
