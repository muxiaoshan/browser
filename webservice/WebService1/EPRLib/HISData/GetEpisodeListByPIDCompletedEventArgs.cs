using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace HISData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetEpisodeListByPIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EEpisodeListByPIdDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EEpisodeListByPIdDataset)this.results[0];
			}
		}

		internal GetEpisodeListByPIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
