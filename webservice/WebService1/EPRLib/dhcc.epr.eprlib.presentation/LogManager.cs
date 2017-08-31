using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace dhcc.epr.eprlib.presentation
{
	public class LogManager
	{
		[DebuggerNonUserCode]
		public LogManager()
		{
		}

		public static void WriteLog(string logNote, bool timeLog)
		{
			string sysOptionValue = SysOptionManager.GetSysOptionValue("ProcessLogActivity", "N");
			if (Operators.CompareString(sysOptionValue, "Y", false) == 0)
			{
				if (timeLog)
				{
					DateTime dateTime = default(DateTime);
					dateTime = DateTime.Now;
					logNote = string.Concat(new string[]
					{
						logNote,
						"\t",
						dateTime.ToString(),
						".",
						dateTime.Millisecond.ToString()
					});
				}
				FileStream stream = new FileStream("c:\\EPRProcessLog.txt", FileMode.Append);
				StreamWriter streamWriter = new StreamWriter(stream, Encoding.GetEncoding("GB2312"));
				streamWriter.WriteLine(logNote);
				streamWriter.Close();
			}
		}

		public static void WriteLog(string logNote, string logFileName)
		{
			FileStream fileStream = null;
			StreamWriter streamWriter = null;
			try
			{
				fileStream = new FileStream(logFileName, FileMode.Append);
				streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
				streamWriter.WriteLine(logNote);
				streamWriter.Close();
				fileStream.Close();
			}
			catch (Exception expr_32)
			{
				ProjectData.SetProjectError(expr_32);
				if (streamWriter != null)
				{
					streamWriter.Close();
				}
				if (fileStream != null)
				{
					fileStream.Close();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
