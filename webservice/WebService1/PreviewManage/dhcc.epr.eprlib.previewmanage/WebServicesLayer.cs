using dhcc.epr.eprlib.previewmanage.SysOptionData;
using System;

namespace dhcc.epr.eprlib.previewmanage
{
	public class WebServicesLayer
	{
		private static string m_Url;

		private static string m_SysOptionUrl = "EPRservice.BOSysOption.cls";

		private static SysOptionInfo m_SysOptionAccess = null;

		public static string URL
		{
			get
			{
				if (WebServicesLayer.m_Url == null)
				{
					WebServicesLayer.m_Url = Configration.DataServiceUrl;
				}
				return WebServicesLayer.m_Url;
			}
		}

		public static SysOptionInfo SysOptionAccess
		{
			get
			{
				try
				{
					if (WebServicesLayer.m_SysOptionAccess == null)
					{
						WebServicesLayer.m_SysOptionAccess = new SysOptionInfo();
						WebServicesLayer.m_SysOptionAccess.Url = WebServicesLayer.URL + WebServicesLayer.m_SysOptionUrl;
					}
				}
				catch (Exception ex)
				{
					throw new Exception("创建数据库链接失败！\r\n" + ex.Message + "\r\n" + ex.StackTrace, ex);
				}
				return WebServicesLayer.m_SysOptionAccess;
			}
		}
	}
}
