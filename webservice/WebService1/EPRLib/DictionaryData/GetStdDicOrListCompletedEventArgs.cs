using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetStdDicOrListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EStdDicOrListDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EStdDicOrListDataset)this.results[0];
			}
		}

		public string AResultCount
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToString(this.results[1]);
			}
		}

		public string SessionId
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToString(this.results[2]);
			}
		}

		internal GetStdDicOrListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
