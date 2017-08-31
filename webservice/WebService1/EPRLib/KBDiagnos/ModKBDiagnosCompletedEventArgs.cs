using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KBDiagnos
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class ModKBDiagnosCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public bool ModKBDiagnosResult
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[0]);
			}
		}

		public bool ModKBDiagnosResultSpecified
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return Conversions.ToBoolean(this.results[1]);
			}
		}

		internal ModKBDiagnosCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
