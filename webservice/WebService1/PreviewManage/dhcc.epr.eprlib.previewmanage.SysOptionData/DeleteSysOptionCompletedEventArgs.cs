using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace dhcc.epr.eprlib.previewmanage.SysOptionData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class DeleteSysOptionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public bool DeleteSysOptionResult
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		public bool DeleteSysOptionResultSpecified
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[1];
			}
		}

		internal DeleteSysOptionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
