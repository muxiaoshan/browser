using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mshtml;
using SHDocVw;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiagnoseAssistant1
{
    ///事件绑定方式复杂，舍弃该方式
    ///
    /// Generic HTML DOM Event method handler.
    ///
    public delegate void DHTMLEvent(IHTMLEventObj e);

    class DHTMLEventHandler
    {
        public DHTMLEvent Handler;
        IHTMLDocument2 Document;

        public DHTMLEventHandler(IHTMLDocument2 doc)
        {
            this.Document = doc;
        }
        [DispId(0)]
        public void Call()
        {
            Handler(Document.parentWindow.@event);
        }
    }
    class DHTMLEventInvoker
    {
        IHTMLDocument2 Document;
        public DHTMLEventInvoker(IHTMLDocument2 Document)
        {
            this.Document = Document;
        }
        public void bindEvent()
        {
            // *** Always raise the ContextMenuClicked event
            // *** Using Custom Event Object  -   No Mouse Lockups
            IHTMLDocument2 doc = (IHTMLDocument2)this.Document;
            DHTMLEventHandler Handler = new DHTMLEventHandler(doc);
            Handler.Handler += new DHTMLEvent(this.Browser_ContextMenuStandardEvent);
            doc.onkeyup += Handler;
        }
        private void Browser_ContextMenuStandardEvent(mshtml.IHTMLEventObj e)
        {
            MessageBox.Show("Context Menu Action (Event Object) Hooked" + e.keyCode);
            e.returnValue = false;
        }
    }
}
