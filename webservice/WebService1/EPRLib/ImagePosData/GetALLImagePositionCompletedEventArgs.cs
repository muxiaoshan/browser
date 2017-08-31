using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ImagePosData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetALLImagePositionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EImagePositionDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EImagePositionDataset)this.results[0];
			}
		}

		internal GetALLImagePositionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
