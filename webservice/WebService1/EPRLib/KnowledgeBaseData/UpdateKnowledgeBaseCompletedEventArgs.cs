using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KnowledgeBaseData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class UpdateKnowledgeBaseCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public bool UpdateKnowledgeBaseResult
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[0]);
			}
		}

		public bool UpdateKnowledgeBaseResultSpecified
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[1]);
			}
		}

		internal UpdateKnowledgeBaseCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
