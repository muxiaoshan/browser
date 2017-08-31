// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.preview.AppUpdater
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.webclient.preview
{
  public class AppUpdater
  {
    private string m_UpdaterUrl;
    private string m_LocalPath;
    private string m_TempPath;
    private string m_ConfigFile;
    private ArrayList m_FilesToUpdate;

    public string UpdaterUrl
    {
      get
      {
        return this.m_UpdaterUrl;
      }
      set
      {
        if (value.EndsWith("/"))
          this.m_UpdaterUrl = value.Substring(0, checked (value.Length - 1));
        else
          this.m_UpdaterUrl = value;
      }
    }

    public string LocalPath
    {
      get
      {
        return this.m_LocalPath;
      }
      set
      {
        this.m_LocalPath = value;
      }
    }

    public string ConfigFile
    {
      get
      {
        return this.m_ConfigFile;
      }
      set
      {
        this.m_ConfigFile = value;
      }
    }

    public string TempPath
    {
      get
      {
        return this.m_TempPath;
      }
      set
      {
        this.m_TempPath = value;
      }
    }

    [DebuggerNonUserCode]
    public AppUpdater()
    {
    }

    public void Dispose()
    {
    }

    public int GetUpdateInfo()
    {
      if (!this.DownConfigFile())
      {
        this.m_FilesToUpdate = new ArrayList();
        return -1;
      }
      XmlDocument serverXmlFile = new XmlDocument();
      string str1 = this.TempPath + "\\" + this.ConfigFile;
      if (System.IO.File.Exists(str1))
      {
        int num;
        try
        {
          serverXmlFile.Load(str1);
          goto label_5;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          MessageManager.ShowErrorMessage("服务器版本配置文件VersionConfig.xml格式错误！请联系管理员");
          this.m_FilesToUpdate = new ArrayList();
          num = -1;
          ProjectData.ClearProjectError();
        }
        return num;
      }
label_5:
      XmlDocument localXmlFile = new XmlDocument();
      string str2 = this.LocalPath + "\\" + this.ConfigFile;
      if (System.IO.File.Exists(str2))
      {
        try
        {
          localXmlFile.Load(str2);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          localXmlFile = new XmlDocument();
          ProjectData.ClearProjectError();
        }
      }
      return this.GenUpdateList(ref serverXmlFile, ref localXmlFile);
    }

    private int GenUpdateList(ref XmlDocument serverXmlFile, ref XmlDocument localXmlFile)
    {
      int num1;
      try
      {
        int num2 = 0;
        ArrayList arrayList1 = new ArrayList();
        string xpath = "VersionConfig/Files";
        ArrayList arrayList2 = new ArrayList();
        XmlNode xmlNode1 = localXmlFile.SelectSingleNode(xpath);
        if (xmlNode1 != null)
        {
          XmlNodeList childNodes = xmlNode1.ChildNodes;
          int num3 = 0;
          int num4 = checked (childNodes.Count - 1);
          int index = num3;
          while (index <= num4)
          {
            string str1 = childNodes.Item(index).Attributes["Name"].Value;
            string str2 = childNodes.Item(index).Attributes["Ver"].Value;
            arrayList2.Add((object) str1);
            arrayList2.Add((object) str2);
            checked { ++index; }
          }
        }
        XmlNode xmlNode2 = serverXmlFile.SelectSingleNode(xpath);
        if (xmlNode2 != null)
        {
          XmlNodeList childNodes = xmlNode2.ChildNodes;
          int num3 = 0;
          int num4 = checked (childNodes.Count - 1);
          int index = num3;
          while (index <= num4)
          {
            string str = childNodes.Item(index).Attributes["Name"].Value;
            string serVerStr = childNodes.Item(index).Attributes["Ver"].Value;
            int num5 = arrayList2.IndexOf((object) str);
            bool flag = false;
            if (num5 == -1)
              flag = true;
            if (num5 > -1)
              flag = this.IsNewVersion(serVerStr, arrayList2[checked (num5 + 1)].ToString());
            if (flag)
            {
              checked { ++num2; }
              string[] strArray = new string[2]
              {
                str,
                serVerStr
              };
              arrayList1.Add((object) strArray);
            }
            checked { ++index; }
          }
        }
        this.m_FilesToUpdate = arrayList1;
        num1 = num2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage(exception.Message + "\n" + exception.StackTrace);
        this.m_FilesToUpdate = new ArrayList();
        num1 = -1;
        ProjectData.ClearProjectError();
      }
      return num1;
    }

    private bool IsNewVersion(string serVerStr, string localVerStr)
    {
      try
      {
        string[] strArray1 = serVerStr.Split('.');
        string[] strArray2 = localVerStr.Split('.');
        if (strArray1.Length != 4)
          throw new Exception("服务器版本配置文件错误！\n错误版本号为: " + serVerStr);
        if (strArray2.Length != 4)
          throw new Exception("本地版本配置文件错误！\n错误版本号为: " + localVerStr);
        return new Version(Convert.ToInt32(strArray1[0]), Convert.ToInt32(strArray1[1]), Convert.ToInt32(strArray1[2]), Convert.ToInt32(strArray1[3])).CompareTo(new Version(Convert.ToInt32(strArray2[0]), Convert.ToInt32(strArray2[1]), Convert.ToInt32(strArray2[2]), Convert.ToInt32(strArray2[3]))) > 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        throw new Exception("检查版本配置文件错误！\r错误信息如下：\r" + exception.Message + "\r" + exception.StackTrace);
      }
    }

    private bool DownConfigFile()
    {
      try
      {
        if (this.TempPath == null)
          this.TempPath = Environment.GetEnvironmentVariable("Temp");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.TempPath = "c:\\windows\\dhceprpreview";
        ProjectData.ClearProjectError();
      }
      if (!Directory.Exists(this.TempPath))
        Directory.CreateDirectory(this.TempPath);
      bool flag;
      try
      {
        WebResponse response = WebRequest.Create(this.UpdaterUrl + "/" + this.ConfigFile).GetResponse();
        if (response.ContentLength > 0L)
        {
          Stream responseStream = response.GetResponseStream();
          Stream stream = (Stream) System.IO.File.Create(this.TempPath + "\\" + this.ConfigFile);
          byte[] buffer = new byte[1025];
          int count;
          do
          {
            count = responseStream.Read(buffer, 0, buffer.Length);
            stream.Write(buffer, 0, count);
          }
          while (count > 0);
          responseStream.Close();
          stream.Close();
        }
        response.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string message = ex.Message;
        flag = false;
        ProjectData.ClearProjectError();
        goto label_12;
      }
      return true;
label_12:
      return flag;
    }

    public bool DownUpdateFiles()
    {
      if (!Directory.Exists(this.TempPath))
        Directory.CreateDirectory(this.TempPath);
      if (!Directory.Exists(this.LocalPath))
        Directory.CreateDirectory(this.LocalPath);
      int num1 = 0;
      int num2 = checked (this.m_FilesToUpdate.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        string[] strArray = (string[]) this.m_FilesToUpdate[index];
        string requestUriString = this.UpdaterUrl + "/" + strArray[0];
        bool flag;
        try
        {
          WebResponse response = WebRequest.Create(requestUriString).GetResponse();
          if (response.ContentLength > 0L)
          {
            Stream responseStream = response.GetResponseStream();
            Stream stream = (Stream) System.IO.File.Open(this.LocalPath + "\\" + strArray[0], FileMode.Create);
            byte[] buffer = new byte[1025];
            int count;
            do
            {
              count = responseStream.Read(buffer, 0, buffer.Length);
              stream.Write(buffer, 0, count);
            }
            while (count > 0);
            responseStream.Close();
            stream.Close();
          }
          response.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) MessageBox.Show("更新新版本文件错误，请联系管理员！\r" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          flag = false;
          ProjectData.ClearProjectError();
          goto label_15;
        }
        checked { ++index; }
        continue;
label_15:
        return flag;
      }
      return true;
    }

    private void CopyFiles()
    {
      try
      {
        if (!Directory.Exists(this.LocalPath))
          Directory.CreateDirectory(this.LocalPath);
        string[] files = Directory.GetFiles(this.TempPath);
        int num1 = 0;
        int num2 = checked (files.Length - 1);
        int index = num1;
        while (index <= num2)
        {
          string[] strArray = files[index].Split('\\');
          System.IO.File.Copy(files[index], this.LocalPath + "\\" + strArray[checked (strArray.Length - 1)], true);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("从临时下载文件夹拷贝文件错误！\r" + exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
    }
  }
}
