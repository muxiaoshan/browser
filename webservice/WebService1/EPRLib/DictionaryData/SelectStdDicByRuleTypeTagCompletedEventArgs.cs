using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace DictionaryData
{
	[GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code"), DebuggerStepThrough]
	public class SelectStdDicByRuleTypeTagCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public XmlElement Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (XmlElement)this.results[0];
			}
		}

		internal SelectStdDicByRuleTypeTagCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
		{
			this.results = results;
		}
	}
}
