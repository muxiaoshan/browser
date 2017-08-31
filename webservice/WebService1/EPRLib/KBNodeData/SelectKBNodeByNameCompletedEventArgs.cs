using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KBNodeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectKBNodeByNameCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKBNodeSelectByNameDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKBNodeSelectByNameDataset)this.results[0];
			}
		}

		internal SelectKBNodeByNameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
