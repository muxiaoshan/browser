using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OrderData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectOrderListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public OrderListByDataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (OrderListByDataSet)this.results[0];
			}
		}

		internal SelectOrderListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
