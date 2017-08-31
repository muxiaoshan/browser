using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsBHO
{
    class CrawlerFactory
    {
        /**
         * 根据访问url获取爬虫实例
         * */
        public static Crawler getCrawler(string url)
        {
            if (url.IndexOf("qq.com") > -1)
            {
                return new QQCrawler();
            }
            else if (url.IndexOf("163.com") > -1 || url.IndexOf("126.com") > -1)
            {
                return new NeteaseCrawler();
            }
            else if (url.IndexOf("dthealth/web/csp") > -1)
            {
                return new DbHealthCrawler();
            }
            else
            {
                return new DefaultCrawler();
            }
        }
    }
}
