using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnitData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.1433"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetUnitsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public EUnitDataset Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (EUnitDataset)this.results[0];
			}
		}

		internal GetUnitsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
