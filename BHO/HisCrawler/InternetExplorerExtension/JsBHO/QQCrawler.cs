using System;
using System.Text;
using mshtml;

/**
 * QQ Crawler
 * */
namespace JsBHO
{
    class QQCrawler : Crawler
    {
        Log log = new Log("QQCrawler.txt");
        public override void parseElement(IHTMLElement item)
        {
            if (item.tagName != null && item.tagName.ToUpper().Equals("A"))
            {
                String keyWords = getKeyWords();
                if (item.innerText != null && item.innerText.IndexOf(keyWords) > -1)
                {
                    log.WriteLog("Crawled:" + item.innerText);
                }
            }
        }
    }
}
