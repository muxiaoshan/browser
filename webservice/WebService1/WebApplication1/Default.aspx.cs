using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(@"Web reference is the simplest way to access webservice.<br/> WSDL.exe can generate proxy client to access webservice, and the command is [F:\ProgramFilesx86\MicrosoftVisualStudio2013\VC\bin\amd64\wsdl.exe  /language:c# /n:WebClient1 /out:f:/servers/webapps/csharp/webclient1/WebClient1.cs http://localhost/webservice1/WebService1.asmx?WSDL]. The WebClient1.cs is the destination file.");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("1. Web Reference:");
            Response.Write("<br/>");
            
            localhost.WebService1 wbs = new localhost.WebService1();
            string hw = wbs.HelloWorld();
            Response.Write(hw);
            Response.Write("<br/>");

            Response.Write("2. WSDL generate proxy:");
            Response.Write("<br/>");
            WebClient1.WebService1 wcs = new WebClient1.WebService1();
            hw = wcs.HelloWorld();
            Response.Write(hw);
            Response.Write("<br/>");

            Response.Write("<hr>");
            int a = 10;
            int b = 12;
            int ret = wbs.compare(a, b);
            Response.Write("1. Web Reference, compare "+a+","+b);
            Response.Write("<br/>");
            if (ret > 0)
            {
                Response.Write(a + " &gt; "+ b);
            }
            else if (ret == 0)
            {
                Response.Write(a + " == "+ b);
            }
            else
            {
                Response.Write(a + " &lt; " + b);
            }
            Response.Write("<br/>");

            Response.Write("2. WSDL generate proxy, compare " + a + "," + b);
            Response.Write("<br/>");
            ret = wcs.compare(a, b);
            if (ret > 0)
            {
                Response.Write(a + " &gt; " + b);
            }
            else if (ret == 0)
            {
                Response.Write(a + " == " + b);
            }
            else
            {
                Response.Write(a + " &lt; " + b);
            }
            Response.Write("<br/>");
        }
    }

}