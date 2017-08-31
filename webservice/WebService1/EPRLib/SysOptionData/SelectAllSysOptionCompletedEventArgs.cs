using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SysOptionData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectAllSysOptionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ESysOptionDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (ESysOptionDataset)this.results[0];
			}
		}

		internal SelectAllSysOptionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
