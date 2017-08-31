using System;
using System.Text;
using mshtml;
namespace JsBHO
{
    class DbHealthCrawler : Crawler
    {
        Log log = new Log("DbHealthCrawler.txt");

        public override void parseElement(IHTMLElement item)
        {
            if (item.tagName != null)
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
