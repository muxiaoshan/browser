using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AdmImageItemData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetByEpisodeIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EAdmImageItemDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EAdmImageItemDataSet)this.results[0];
			}
		}

		internal GetByEpisodeIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
