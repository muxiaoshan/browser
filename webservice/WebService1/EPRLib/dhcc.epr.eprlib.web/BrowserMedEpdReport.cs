using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.web
{
	public class BrowserMedEpdReport : WebBrowser
	{
		[DebuggerNonUserCode]
		public BrowserMedEpdReport()
		{
		}

		public void NavigateTo(string PatientID, string EpisodeID, string IFRowID, string LocFlag)
		{
			string text = Conversions.ToString(this.GetWebBrowserURL());
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			text = text.Replace("{IPAddress}", Configuration.DataServiceUrl);
			text = text.Replace("{IFRowID}", IFRowID);
			text = text.Replace("{LocFlag}", LocFlag);
			text = text.Replace("{PatientID}", PatientID);
			text = text.Replace("{EpisodeID}", EpisodeID);
			text = text.Replace("{UserID}", GlobalValues.GetValueByKey("UserID"));
			text = text.Replace("{UserName}", GlobalValues.GetValueByKey("UserName"));
			text = text.Replace("{CTLocID}", GlobalValues.GetValueByKey("CTLocID"));
			text = text.Replace("{SSGroupID}", GlobalValues.GetValueByKey("SSGroupID"));
			text = text.Replace("{Password}", GlobalValues.GetValueByKey("Password"));
			text = text.Replace("{EmployeeNo}", GlobalValues.GetValueByKey("EmployeeNo"));
			base.Navigate(text);
		}

		private object GetWebBrowserURL()
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("WebUrlMedEpdReport", string.Empty);
			if (string.IsNullOrEmpty(sysOptionValue))
			{
				return string.Empty;
			}
			if (Operators.CompareString(sysOptionValue.ToUpper(), "NULL", false) == 0)
			{
				return string.Empty;
			}
			return sysOptionValue;
		}
	}
}
