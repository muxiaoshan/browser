using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KnowledgeBaseData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectKnowledgeBaseBYPARENTIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EKnowledgeBaseDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EKnowledgeBaseDataset)this.results[0];
			}
		}

		internal SelectKnowledgeBaseBYPARENTIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
