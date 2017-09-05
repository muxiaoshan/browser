using System;
using System.Text;
using mshtml;
using SHDocVw;
using DiagnoseAssistant1.database;

namespace DiagnoseAssistant1.crawler
{
    abstract class Crawler
    {
        /// <summary>
        /// 静态的患者就诊信息，不同爬虫间共享
        /// </summary>
        public static Episode episode { get; set; }
        /// <summary>
        /// 数据库操作
        /// </summary>
        public MySqlOp sqlOp = new MySqlOp();
        Log log = new Log();
        public void crawl(IHTMLDocument2 document)
        {
            ReadDoc(document);
        }
        //读取网页内容
        public void ReadDoc(IHTMLDocument2 doc)
        {
            log.WriteLog("解析网页【"+doc.location.href+"】DOM结构");
            foreach (IHTMLElement item in doc.all)
            {
                if (item != null && item.tagName != null)
                {
                    if (item.tagName.ToUpper().Equals("FRAME")
                        || item.tagName.ToUpper().Equals("IFRAME"))
                    {
                        mshtml.IHTMLFrameBase2 iFrame = (mshtml.IHTMLFrameBase2)item;
                        mshtml.IHTMLDocument2 iHTMLDocument2 = iFrame.contentWindow.document;
                        ReadDoc(iHTMLDocument2);
                    }
                    else
                    {
                        parseElement(item);
                    }
                }
                
            }
        }
        public abstract void parseElement(IHTMLElement item);
        /// <summary>
        /// 从html元素与其子元素中找到id为给定值的元素
        /// </summary>
        /// <param name="item">起始html元素</param>
        /// <param name="id">给定的id</param>
        /// <returns></returns>
        public IHTMLElement getChildElementById(IHTMLElement item, string id)
        {            
            foreach (IHTMLElement child in item.all)
            {
                if (child.id != null && child.id.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
