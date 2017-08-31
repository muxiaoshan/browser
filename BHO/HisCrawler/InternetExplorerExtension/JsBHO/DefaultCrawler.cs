using System;
using System.Text;
using mshtml;
namespace JsBHO
{
    class DefaultCrawler : Crawler
    {
        Log log = new Log("DefaultCrawler.txt");

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
