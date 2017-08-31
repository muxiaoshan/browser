using System;
using System.Configuration;
using System.Diagnostics;

namespace dhcc.epr.systemframework
{
	public class Configuration
	{
		private const string TRACING_ENABLED = "SystemFramework.Tracing.Enabled";

		private const string TRACING_TRACEFILE = "SystemFramework.Tracing.TraceFile";

		private const string TRACING_TRACELEVEL = "SystemFramework.Tracing.TraceLevel";

		private const string TRACING_SWITCHNAME = "SystemFramework.Tracing.SwitchName";

		private const string TRACING_SWITCHDESCRIPTION = "SystemFramework.Tracing.SwitchDescription";

		private const string EVENTLOG_ENABLED = "SystemFramework.EventLog.Enabled";

		private const string EVENTLOG_MACHINENAME = "SystemFramework.EventLog.Machine";

		private const string EVENTLOG_SOURCENAME = "SystemFramework.EventLog.SourceName";

		private const string EVENTLOG_TRACELEVEL = "SystemFramework.EventLog.LogLevel";

		private const string DATABASE_WEBSERVICE = "SystemFramework.DataServiceUrl";

		private const bool TRACING_ENABLED_DEFAULT = false;

		private const string TRACING_TRACEFILE_DEFAULT = "ApplicationTrace.txt";

		private const TraceLevel TRACING_TRACELEVEL_DEFAULT = TraceLevel.Verbose;

		private const string TRACING_SWITCHNAME_DEFAULT = "ApplicationTraceSwitch";

		private const string TRACING_SWITCHDESCRIPTION_DEFAULT = "Application error and tracing information";

		private const bool EVENTLOG_ENABLED_DEFAULT = false;

		private const string EVENTLOG_MACHINENAME_DEFAULT = ".";

		private const string EVENTLOG_SOURCENAME_DEFAULT = "EPR 2.0";

		private const TraceLevel EVENTLOG_TRACELEVEL_DEFAULT = TraceLevel.Error;

		private const string DATABASE_WEBSERVICE_DEFAULT = "http://127.0.0.1/csp/user";

		private static bool m_TracingEnabled;

		private static string m_TracingTraceFile;

		private static TraceLevel m_TracingTraceLevel;

		private static string m_TracingSwitchName;

		private static string m_TracingSwitchDescription;

		private static bool m_EventLogEnabled;

		private static string m_EventLogMachineName;

		private static string m_EventLogSourceName;

		private static TraceLevel m_EventLogTraceLevel;

		private static string m_DataServiceUrl;

		private static string m_FormServiceUrl;

		public static bool TracingEnabled
		{
			get
			{
				return Configuration.m_TracingEnabled;
			}
		}

		public static string TracingTraceFile
		{
			get
			{
				return Configuration.m_TracingTraceFile;
			}
		}

		public static TraceLevel TracingTraceLevel
		{
			get
			{
				return Configuration.m_TracingTraceLevel;
			}
		}

		public static string TracingSwitchName
		{
			get
			{
				return Configuration.m_TracingSwitchName;
			}
		}

		public static string TracingSwitchDescription
		{
			get
			{
				return Configuration.m_TracingSwitchDescription;
			}
		}

		public static bool EventLogEnabled
		{
			get
			{
				return Configuration.m_EventLogEnabled;
			}
		}

		public static string EventLogMachineName
		{
			get
			{
				return Configuration.m_EventLogMachineName;
			}
		}

		public static string EventLogSourceName
		{
			get
			{
				return Configuration.m_EventLogSourceName;
			}
		}

		public static TraceLevel EventLogTraceLevel
		{
			get
			{
				return Configuration.m_EventLogTraceLevel;
			}
		}

		public static string DataServiceUrl
		{
			get
			{
				return Configuration.m_DataServiceUrl;
			}
			set
			{
				Configuration.m_DataServiceUrl = value;
			}
		}

		public static string FormServiceUrl
		{
			get
			{
				return Configuration.m_FormServiceUrl;
			}
			set
			{
				Configuration.m_FormServiceUrl = value;
			}
		}

		private static string readSetting(string key, string defaultValue)
		{
			string result;
			try
			{
				string text = ConfigurationSettings.AppSettings[key];
				result = ((text == "") ? defaultValue : text);
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		private static bool readSetting(string key, bool defaultValue)
		{
			bool result;
			try
			{
				string text = ConfigurationSettings.AppSettings[key];
				result = ((text == "") ? defaultValue : Convert.ToBoolean(text));
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		private static int readSetting(string key, int defaultValue)
		{
			int result;
			try
			{
				string text = ConfigurationSettings.AppSettings[key];
				result = ((text == "") ? defaultValue : Convert.ToInt32(text));
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		private static TraceLevel readSetting(string key, TraceLevel defaultValue)
		{
			TraceLevel result;
			try
			{
				string text = ConfigurationSettings.AppSettings[key];
				result = ((text == "") ? defaultValue : ((TraceLevel)Convert.ToInt32(text)));
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		public static void OnApplicationStart()
		{
			Configuration.m_TracingEnabled = Configuration.readSetting("SystemFramework.Tracing.Enabled", false);
			Configuration.m_TracingTraceFile = Configuration.readSetting("SystemFramework.Tracing.TraceFile", "ApplicationTrace.txt");
			Configuration.m_TracingTraceLevel = Configuration.readSetting("SystemFramework.Tracing.TraceLevel", TraceLevel.Verbose);
			Configuration.m_TracingSwitchName = Configuration.readSetting("SystemFramework.Tracing.SwitchName", "ApplicationTraceSwitch");
			Configuration.m_TracingSwitchDescription = Configuration.readSetting("SystemFramework.Tracing.SwitchDescription", "Application error and tracing information");
			Configuration.m_EventLogEnabled = Configuration.readSetting("SystemFramework.EventLog.Enabled", false);
			Configuration.m_EventLogMachineName = Configuration.readSetting("SystemFramework.EventLog.Machine", ".");
			Configuration.m_EventLogSourceName = Configuration.readSetting("SystemFramework.EventLog.SourceName", "EPR 2.0");
			Configuration.m_EventLogTraceLevel = Configuration.readSetting("SystemFramework.EventLog.LogLevel", TraceLevel.Error);
			Configuration.m_DataServiceUrl = Configuration.readSetting("SystemFramework.DataServiceUrl", "http://127.0.0.1/csp/user");
		}
	}
}
