using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KBTreeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectKBTreeBYIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKBTree Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKBTree)this.results[0];
			}
		}

		internal SelectKBTreeBYIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
