using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace dhcc.epr.systemframework
{
	public class EventLogHelper
	{
		private static TraceSwitch debugSwitch;

		private static StreamWriter debugWriter;

		private static TraceLevel eventLogTraceLevel;

		static EventLogHelper()
		{
			Type typeFromHandle = typeof(EventLogHelper);
			try
			{
				if (!Monitor.TryEnter(typeFromHandle))
				{
					Monitor.Enter(typeFromHandle);
				}
				else
				{
					bool flag = true;
					try
					{
						if (Configuration.TracingEnabled)
						{
							string tracingTraceFile = Configuration.TracingTraceFile;
							if (tracingTraceFile != string.Empty)
							{
								string tracingSwitchName = Configuration.TracingSwitchName;
								if (tracingSwitchName != string.Empty)
								{
									FileInfo fileInfo = new FileInfo(tracingTraceFile);
									EventLogHelper.debugWriter = new StreamWriter(fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
									Debug.Listeners.Add(new TextWriterTraceListener(EventLogHelper.debugWriter));
									EventLogHelper.debugSwitch = new TraceSwitch(tracingSwitchName, Configuration.TracingSwitchDescription);
									EventLogHelper.debugSwitch.Level = Configuration.TracingTraceLevel;
								}
								flag = false;
							}
						}
					}
					catch
					{
					}
					if (flag)
					{
						EventLogHelper.debugSwitch = null;
						EventLogHelper.debugWriter = null;
					}
					if (Configuration.EventLogEnabled)
					{
						EventLogHelper.eventLogTraceLevel = Configuration.EventLogTraceLevel;
					}
					else
					{
						EventLogHelper.eventLogTraceLevel = TraceLevel.Off;
					}
				}
			}
			finally
			{
				Monitor.Exit(typeFromHandle);
			}
		}

		public static void LogError(string message)
		{
			EventLogHelper.WriteLog(TraceLevel.Error, message);
		}

		public static void LogWarning(string message)
		{
			EventLogHelper.WriteLog(TraceLevel.Warning, message);
		}

		public static void LogInformation(string message)
		{
			EventLogHelper.WriteLog(TraceLevel.Info, message);
		}

		public static void LogTrace(string message)
		{
			EventLogHelper.WriteLog(TraceLevel.Verbose, message);
		}

		public static string FormatException(Exception ex, string catchInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (catchInfo != string.Empty)
			{
				stringBuilder.Append(catchInfo).Append("\r\n");
			}
			stringBuilder.Append(ex.Message).Append("\r\n").Append(ex.StackTrace);
			return stringBuilder.ToString();
		}

		private static void WriteLog(TraceLevel level, string messageText)
		{
			try
			{
				if (EventLogHelper.debugWriter != null && level <= EventLogHelper.debugSwitch.Level)
				{
					lock (EventLogHelper.debugWriter)
					{
						EventLogHelper.debugWriter.Flush();
					}
				}
				if (level <= EventLogHelper.eventLogTraceLevel)
				{
					EventLogEntryType type;
					switch (level)
					{
					case TraceLevel.Error:
						type = EventLogEntryType.Error;
						break;
					case TraceLevel.Warning:
						type = EventLogEntryType.Warning;
						break;
					case TraceLevel.Info:
						type = EventLogEntryType.Information;
						break;
					case TraceLevel.Verbose:
						type = EventLogEntryType.SuccessAudit;
						break;
					default:
						type = EventLogEntryType.SuccessAudit;
						break;
					}
					EventLog eventLog = new EventLog("Application", Configuration.EventLogMachineName, Configuration.EventLogSourceName);
					eventLog.WriteEntry(messageText, type);
				}
			}
			catch
			{
			}
		}
	}
}
