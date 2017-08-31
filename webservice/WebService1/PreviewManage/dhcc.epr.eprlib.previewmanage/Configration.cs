using System;

namespace dhcc.epr.eprlib.previewmanage
{
	public class Configration
	{
		private static string m_DataServiceUrl;

		private static string m_FormServiceUrl;

		public static string DataServiceUrl
		{
			get
			{
				return Configration.m_DataServiceUrl;
			}
			set
			{
				Configration.m_DataServiceUrl = value;
			}
		}

		public static string FormServiceUrl
		{
			get
			{
				return Configration.m_FormServiceUrl;
			}
			set
			{
				Configration.m_FormServiceUrl = value;
			}
		}
	}
}
