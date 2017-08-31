using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using mshtml;
using SHDocVw;
using System.Threading;
using System.Text.RegularExpressions;

namespace DiagnoseAssistant1
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    //个性化GUID
    [Guid("1194A96A-BF78-405D-8CE8-55385C878094")]
    public class DiagnoseAssistant1 : IObjectWithSite, IOleCommandTarget
    {
        IWebBrowser2 browser;
        private object site;

        Log log = new Log();

        //KeyboardHook keyboardHook = new KeyboardHook();
        /*
An outgoing call cannot be made since the application is dispatching an input-synchronous call
window.showModalDialog()报错，Additional information: 因为应用程序正在发送一个输入同步呼叫，所以无法执行传出的呼叫
         * 
All COM objects provided by the shdocvw and mshtml controls use the single- 
threaded apartment model. To access them from a MTA you need to marshal the interfaces using CoMarshalInterThreadInterfaceInStream nad CoGetInterfaceAndReleaseStream
        */
        /*
        globalKeyboardHook gkh = new globalKeyboardHook();

        public DiagnoseAssistant1()
        {
            gkh.HookedKeys.Add(Keys.A);
            gkh.HookedKeys.Add(Keys.B);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            log.WriteLog("globalKeyboardHook initialized.");
        }
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            log.WriteLog("Up\t" + e.KeyCode.ToString());
            //访问辅助诊疗
            accessFzzl();
            e.Handled = true;
        }
        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            log.WriteLog("Down\t" + e.KeyCode.ToString());
            e.Handled = true;
        }
        */

        //存放就诊编码
        static ArrayList episodes = new ArrayList();
        const string fzzlUrlPrefix = "http://172.26.111.12/newAiadt/a/home/login";
        #region OnDocumentComplete
        //页面加载，包括iframe内页面加载后调用
        void OnDocumentComplete(object pDisp, ref object URL)
        {
            log.WriteLog("DiagnoseAssistant1 OnDocumentComplete. URL:" + URL);
            try
            {
                if (URL != null)
                {
                    string urlStr = URL.ToString();
                    //访问电子病历页面
                    if (urlStr.Contains("websys.csp?a=a&TMENU=51686"))
                    {
                        Episode episode = EpisodeRegexUtils.getEpisodeFromUrl(urlStr);
                        log.WriteLog("访问门诊电子病历页面，暂存患者编码[" + episode.PatientID + "]与就诊编码[" + episode.EpisodeID + "]");
                        episodes.Add(episode);
                    }
                    //访问门诊患者列表页面
                    if (urlStr.Contains("websys.csp?a=a&TMENU=50136"))
                    {
                        log.WriteLog("访问门诊患者列表页面。已查看并暂存的门诊患者电子病历数，episodes.Count=" + episodes.Count + "，大于0则访问辅助诊疗页面。");
                        if (episodes.Count > 0)
                        {
                            accessFzzl();
                        }
                    }
                    IHTMLDocument2 document = browser.Document;
                    ((mshtml.HTMLDocumentEvents2_Event)document).onkeyup += new mshtml.HTMLDocumentEvents2_onkeyupEventHandler(onKeyUp);
                }
                // @Eric Stob: Thanks for this hint!
                // This will prevent this method being executed more than once.
                if (pDisp != this.site)
                    return;    
            }
            catch (Exception ex)
            {
                log.WriteLog("DiagnoseAssistant1 OnDocumentComplete exception occured." + ex);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        //固定GUID
        [Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
        [InterfaceType(1)]
        public interface IServiceProvider
        {
            int QueryService(ref Guid guidService, ref Guid riid, out IntPtr ppvObject);
        }
        #region Implementation of IObjectWithSite
        int IObjectWithSite.SetSite(object site)
        {
            //log.WriteLog("DiagnoseAssistant1 SetSite:" + site);
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
                    
                    //keyboardHook.Install();
                    //MessageBox.Show("hooking");                                        
                }
                else
                {
                    ((DWebBrowserEvents2_Event)browser).DocumentComplete -=
                        new DWebBrowserEvents2_DocumentCompleteEventHandler(this.OnDocumentComplete);
                    browser = null;
                    //keyboardHook.UnInstall();
                    //MessageBox.Show("UnHookMe");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog("exception occured:" + ex.ToString());
                MessageBox.Show("exception occured:" + ex.ToString());
            }
            //log.WriteLog("browser.LocationURL:" + browser.LocationURL);
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
        
       
        int IOleCommandTarget.QueryStatus(IntPtr pguidCmdGroup, uint cCmds, ref OLECMD prgCmds, IntPtr pCmdText)
        {
            return 0;
        }
        int IOleCommandTarget.Exec(IntPtr pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            try
            {
                log.WriteLog("已查看并暂存的门诊患者电子病历数，episodes.Count=" + episodes.Count);
                if (episodes.Count == 0)
                {
                    MessageBox.Show("没有查看过电子病历");
                    return 0;
                }
                else
                {
                    accessFzzl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }
        void onKeyUp(mshtml.IHTMLEventObj e)
        {
            string keyCode = e.keyCode.ToString();
            log.WriteLog("keyCode=" + keyCode);
        }
        // Summary:
        //     访问辅助诊疗页面。
        //
        void accessFzzl()
        {
            IHTMLDocument2 document = browser.Document;
            IHTMLWindow2 window = document.parentWindow;
            //取最近一个打开的病历
            Episode episode = (Episode)episodes[episodes.Count - 1];
            string fzzlUrl = fzzlUrlPrefix + "?hzbm=" + episode.PatientID + "&jzbm=" + episode.EpisodeID;
            log.WriteLog("访问辅助诊疗页面，查看最近的电子病历信息：" + fzzlUrl);
            int screenWidth = window.screen.width;
            int screenHeight = window.screen.height;
            //window.open 无法置顶窗口
            /*IHTMLWindow2 window2 = window.open(fzzlUrl, "辅助诊疗",
                "width=" + (screenWidth * 0.9) + ",height=" + (screenHeight * 0.8)
                + ",location=0,menubar=0,toolbar=0");
            window2.focus();*/
            //window.showModalDialog可置顶窗口
            window.showModalDialog(fzzlUrl, "辅助诊疗",
                "dialogWidth=" + (screenWidth * 0.9) + "px;dialogHeight=" + (screenHeight * 0.8) + "px;center=yes");
           
            //移除最后一个元素
            episodes.RemoveAt(episodes.Count - 1);
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
                key.SetValue("ButtonText", "辅助诊疗");
                //固定GUID，IE Extension的CLSID
                key.SetValue("CLSID", "{1FBA04EE-3024-11d2-8F1F-0000F87ABD16}");
                key.SetValue("ClsidExtension", guid);
                key.SetValue("Icon", "C:\\DiagnoseAssistantIcon.ico");
                key.SetValue("HotIcon", "C:\\DiagnoseAssistantIcon.ico");
                key.SetValue("Default Visible", "Yes");
                key.SetValue("MenuText", "&辅助诊疗");
                key.SetValue("ToolTip", "辅助诊疗");
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
