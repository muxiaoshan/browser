using System;
using System.Text;
using mshtml;
namespace JsBHO
{
    class NeteaseCrawler : Crawler
    {
        Log log = new Log("NeteaseCrawler.txt");

        public override void parseElement(IHTMLElement item)
        {
            if (item.tagName != null && item.tagName.ToUpper().Equals("TD"))
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
