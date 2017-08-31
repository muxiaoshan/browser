using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KBTreeData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectKBTreeBYPARENTIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKBTreeDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKBTreeDataset)this.results[0];
			}
		}

		internal SelectKBTreeBYPARENTIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
