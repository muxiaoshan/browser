using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using mshtml;
using SHDocVw;

namespace JsBHO
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("D40C654D-7C51-4EB3-95B2-1E23905C2A2D")]
    public class JsIEAddon : IObjectWithSite, IOleCommandTarget
    {
        IWebBrowser2 browser;
        private object site;

        Log log = new Log();
        #region OnDocumentComplete
        void OnDocumentComplete(object pDisp, ref object URL)
        {
            //log.WriteLog("JsIEAddon OnDocumentComplete.");
            try
            {
                // @Eric Stob: Thanks for this hint!
                // This will prevent this method being executed more than once.
                if (pDisp != this.site)
                    return;
                
                var document = browser.Document as IHTMLDocument2;
                //添加Javascript脚本
                IHTMLElement head = (IHTMLElement)((IHTMLElementCollection)document.all.tags("head")).item(null, 0);
                IHTMLScriptElement scriptElement = (IHTMLScriptElement)document.createElement("script");
                scriptElement.type = "text/javascript";
                scriptElement.text = "function bhoSearch(text){var kw=document.getElementById('kw');kw.value=text;var form = document.forms[0];form.submit();}";
                ((HTMLHeadElement)head).appendChild((IHTMLDOMNode)scriptElement);
                log.WriteLog("JS function bhoSearch() added.");
            }
            catch (Exception ex)
            {
                log.WriteLog("JsIEAddon OnDocumentComplete exception occured." + ex);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        [Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
        [InterfaceType(1)]
        public interface IServiceProvider
        {
            int QueryService(ref Guid guidService, ref Guid riid, out IntPtr ppvObject);
        }
        #region Implementation of IObjectWithSite
        int IObjectWithSite.SetSite(object site)
        {
            //log.WriteLog("SetSite:" + site);
            this.site = site;
            try
            {
                if (site != null)
                {
                    var serviceProv = (IServiceProvider)this.site;
                    var guidIWebBrowserApp = Marshal.GenerateGuidForType(typeof(IWebBrowserApp)); // new Guid("0002DF05-0000-0000-C000-000000000046");
                    var guidIWebBrowser2 = Marshal.GenerateGuidForType(typeof(IWebBrowser2)); // new Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E");
                    IntPtr intPtr;
                    serviceProv.QueryService(ref guidIWebBrowserApp, ref guidIWebBrowser2, out intPtr);

                    browser = (IWebBrowser2)Marshal.GetObjectForIUnknown(intPtr);

                    ((DWebBrowserEvents2_Event)browser).DocumentComplete +=
                        new DWebBrowserEvents2_DocumentCompleteEventHandler(this.OnDocumentComplete);
                }
                else
                {
                    ((DWebBrowserEvents2_Event)browser).DocumentComplete -=
                        new DWebBrowserEvents2_DocumentCompleteEventHandler(this.OnDocumentComplete);
                    browser = null;
                }
            }
            catch (Exception ex)
            {
                log.WriteLog("exception occured:" + ex.ToString());
            }
            //log.WriteLog("browser:" + browser.FullName);
            return 0;
        }
        int IObjectWithSite.GetSite(ref Guid guid, out IntPtr ppvSite)
        {
            IntPtr punk = Marshal.GetIUnknownForObject(browser);
            int hr = Marshal.QueryInterface(punk, ref guid, out ppvSite);
            Marshal.Release(punk);
            return hr;
        }
        #endregion

        #region Implementation of IOleCommandTarget
        static string TextToSearch = "BHO";
        int IOleCommandTarget.QueryStatus(IntPtr pguidCmdGroup, uint cCmds, ref OLECMD prgCmds, IntPtr pCmdText)
        {
            return 0;
        }
        int IOleCommandTarget.Exec(IntPtr pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            try
            {
                //log.WriteLog("启动JS BHO组件。");
                // Accessing the document from the command-bar.
                //log.WriteLog("browser:" + browser);
                var document = browser.Document as IHTMLDocument2;
                //log.WriteLog("document:" + document);
                var window = document.parentWindow;
                //log.WriteLog("window:" + window);
                //var result = window.execScript(@"alert('You will now be allowed to configure the text to search...');");

                var form = new SearchForm();
                form.InputText = TextToSearch;
                if (form.ShowDialog() != DialogResult.Cancel)
                {
                    TextToSearch = form.InputText;
                    search(window, document, TextToSearch);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }
        void search(IHTMLWindow2 window, IHTMLDocument2 document, string textToSearch)
        {
            log.WriteLog("开始搜索:" + textToSearch);
            //执行Javascript脚本
            window.execScript(@"bhoSearch('" + textToSearch + "');");
        }
        #endregion

        #region Registering with regasm
        public static string RegBHO = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects";
        public static string RegCmd = "Software\\Microsoft\\Internet Explorer\\Extensions";

        [ComRegisterFunction]
        public static void RegisterBHO(Type type)
        {
            string guid = type.GUID.ToString("B");

            // BHO
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RegBHO, true);
                if (registryKey == null)
                    registryKey = Registry.LocalMachine.CreateSubKey(RegBHO);
                RegistryKey key = registryKey.OpenSubKey(guid);
                if (key == null)
                    key = registryKey.CreateSubKey(guid);
                key.SetValue("Alright", 1);
                registryKey.Close();
                key.Close();
            }

            // Command
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RegCmd, true);
                if (registryKey == null)
                    registryKey = Registry.LocalMachine.CreateSubKey(RegCmd);
                RegistryKey key = registryKey.OpenSubKey(guid);
                if (key == null)
                    key = registryKey.CreateSubKey(guid);
                key.SetValue("ButtonText", "JsIEAddon");
                key.SetValue("CLSID", "{1FBA04EE-3024-11d2-8F1F-0000F87ABD16}");
                key.SetValue("ClsidExtension", guid);
                key.SetValue("Icon", "");
                key.SetValue("HotIcon", "");
                key.SetValue("Default Visible", "Yes");
                key.SetValue("MenuText", "&JsIEAddon");
                key.SetValue("ToolTip", "JsIEAddon");
                //key.SetValue("KeyPath", "no");
                registryKey.Close();
                key.Close();
            }
        }

        [ComUnregisterFunction]
        public static void UnregisterBHO(Type type)
        {
            string guid = type.GUID.ToString("B");
            // BHO
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RegBHO, true);
                if (registryKey != null)
                    registryKey.DeleteSubKey(guid, false);
            }
            // Command
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(RegCmd, true);
                if (registryKey != null)
                    registryKey.DeleteSubKey(guid, false);
            }
        }
        #endregion
    }
}
