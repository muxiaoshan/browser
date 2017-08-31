using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using mshtml;
using SHDocVw;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace BHO_holl
{

    [ComVisible(true), Guid("e90da13b-117a-4178-8111-0f712da09ff9"), ClassInterface(ClassInterfaceType.None)]
    public class UrlTrack : IObjectWithSite
    {

        private string NavigatePath = string.Empty;

        SHDocVw.WebBrowser webBrowser;

        public int Setsite(Object newSite)
        {
            if (newSite != null)
            {
                webBrowser = (SHDocVw.WebBrowser)newSite;
                webBrowser.FileDownload += new DWebBrowserEvents2_FileDownloadEventHandler(FileDownload);
                webBrowser.BeforeNavigate2 += new DWebBrowserEvents2_BeforeNavigate2EventHandler(webBrowser_BeforeNavigate2);
            }
            else
            {
                webBrowser.FileDownload -= new DWebBrowserEvents2_FileDownloadEventHandler(FileDownload);
                webBrowser.BeforeNavigate2 -= new DWebBrowserEvents2_BeforeNavigate2EventHandler(webBrowser_BeforeNavigate2);
            }

            return 0;
        }

        public void webBrowser_BeforeNavigate2(object pDisp, ref object URl, ref object Flags,
            ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            NavigatePath = URl.ToString();
        }


         public int Getsite(ref Guid guid, out IntPtr ppvsite)
        {
            IntPtr punk = Marshal.GetIUnknownForObject(webBrowser);
            int hr = Marshal.QueryInterface(punk, ref guid, out ppvsite);

            Marshal.Release(punk);

            return hr;
        }

        public static string BHO_KEY_NAME = @"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects";

        [ComRegisterFunction]
        public static void RegisterBHO(Type type)
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BHO_KEY_NAME, true);
            if (registryKey == null)
            {
                registryKey = Registry.LocalMachine.CreateSubKey(BHO_KEY_NAME);
            }
            string guid = type.GUID.ToString("B");
            RegistryKey bhoKey = registryKey.OpenSubKey(guid, true);
            if (bhoKey == null)
            {
                bhoKey = registryKey.CreateSubKey(guid);
            }
            // NoExplorer: dword = 1 prevents the BHO to be loaded by Explorer.exe   
            bhoKey.SetValue("NoExplorer", 1);
            bhoKey.Close();
            registryKey.Close();
        }

        [ComUnregisterFunction]
        public static void UnregisterBHO(Type type)
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(BHO_KEY_NAME, true);
            string guid = type.GUID.ToString("B");
            if (registryKey != null)
                registryKey.DeleteSubKey(guid, false);
        }


        public void FileDownload(bool ActiveDocument, ref bool Cancel)
        {

            if (webBrowser.LocationURL != "")
            {

                DialogResult myresult = MessageBox.Show("有文件下载，是否打开我的程序", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (myresult == DialogResult.OK)
                {
                    OpenMainApp(NavigatePath);

                    NavigatePath = string.Empty;
                    Cancel = true;
                }
                else if (myresult == DialogResult.Cancel)
                {

                }
                else
                {
                    Cancel = true;

                }
            }

            NavigatePath = string.Empty;
        }




        public static string BHO_MainAPP_PATH = @"C:\Windows\system32\notepad.exe";


        private void OpenMainApp(string navstring)
        {
            try
            {
                System.Diagnostics.Process.Start(BHO_MainAPP_PATH);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
