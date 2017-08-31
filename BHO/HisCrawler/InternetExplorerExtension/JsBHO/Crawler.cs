using System;
using System.Text;
using mshtml;
using SHDocVw;
namespace JsBHO
{
    abstract class Crawler
    {
        Log log = new Log();

        string keyWords;
        
        public string getKeyWords()
        {
            return this.keyWords;
        }
        
        public void crawl(IHTMLDocument2 document, string textToSearch)
        {            
            this.keyWords = textToSearch;
            ReadDoc(document);
        }
        //读取网页内容
        public void ReadDoc(IHTMLDocument2 doc)
        {
            log.WriteLog("解析网页【"+doc.location.href+"】DOM结构，获取包含【" + this.keyWords + "】的内容");
            foreach (IHTMLElement item in doc.all)
            {
                //if (item.id == "_petName" || item.id == "userNameTopLine")
                //{
                    //this.rich_src.AppendText("     id:");
                    //this.rich_src.AppendText(item.innerText);
                //}
                //this.rich_src.AppendText("     id:");
                //this.rich_src.AppendText(item.id == null ? "未设置" : item.id);
                //this.rich_src.AppendText("     tag:");
                //this.rich_src.AppendText(item.tagName);
                //this.rich_src.AppendText("     innerHTML:");
                //this.rich_src.AppendText(item.innerHTML == null ? "未设置" : item.innerHTML);
                //this.rich_src.AppendText("\r\n-------------\r\n");                
                if (item != null && item.tagName != null)
                {
                    if (item.tagName.ToUpper().Equals("FRAME")
                        || item.tagName.ToUpper().Equals("IFRAME"))
                    {
                        //this.rich_src.AppendText(" IFRAME    id:");
                        //this.rich_src.AppendText(item.id == null ? "未设置" : item.id);
                        //this.rich_src.AppendText("\r\n-------------\r\n");
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
    }
}
