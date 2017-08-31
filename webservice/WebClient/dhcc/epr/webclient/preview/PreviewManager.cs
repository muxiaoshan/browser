// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.preview.PreviewManager
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.webclient.preview
{
  public class PreviewManager
  {
    private const string PREVIEW_SRV_NAME = "PreviewService";
    private const string PREVIEW_SRV_CONFIGFILE = "VersionConfig.xml";
    private const string PREVIEW_SRV_UPDATED_FLAG = "PREVIEW_SRV_UPDATED_FLAG";
    private const string CHAR_SHARP = "#";
    private const string CHAR_ARROW = "^";
    private const string CHAR_DOLLAR = "$";
    private const string CHAR_SLASH = "/";
    private const string CHAR_BACKSLASH = "\\";
    private string m_LocalPathApp;
    private string m_LocalPathTemp;
    private string m_LocalPathXml;
    private string m_AppSrvFile;
    private string m_filePath;

    private string LocalPathApp
    {
      get
      {
        if (this.m_LocalPathApp == null)
          this.GetLocalPath();
        return this.m_LocalPathApp;
      }
    }

    private string LocalPathTemp
    {
      get
      {
        if (this.m_LocalPathTemp == null)
          this.GetLocalPath();
        return this.m_LocalPathTemp;
      }
    }

    private string LocalPathXml
    {
      get
      {
        if (this.m_LocalPathXml == null)
          this.GetLocalPath();
        return this.m_LocalPathXml;
      }
    }

    private string AppSrvFile
    {
      get
      {
        if (this.m_AppSrvFile == null)
          this.GetLocalPath();
        return this.m_AppSrvFile;
      }
    }

    [DebuggerNonUserCode]
    public PreviewManager()
    {
    }

    public void InvokePreviewService(string patId, string episodeId, string logId, string printTemplateID, string printType, string instanceId, string userId, string printDocId)
    {
      string sysOptionValue = SysOptionManager.GetSysOptionValue("SavePrintImage", "");
      if (Operators.CompareString(sysOptionValue.ToUpper(), "NULL", false) == 0 || Operators.CompareString(sysOptionValue, "", false) == 0)
        return;
      if (sysOptionValue.Split('^').Length != 6)
      {
        int num1 = (int) MessageManager.ShowWarningMessage("参数SavePrintImage设置错误，病历浏览服务已中止!\r参数信息如下：\r" + sysOptionValue);
      }
      else if (Operators.CompareString(patId, "", false) == 0 || Operators.CompareString(episodeId, "", false) == 0 || (Operators.CompareString(logId, "", false) == 0 || Operators.CompareString(printTemplateID, "", false) == 0) || Operators.CompareString(printType, "", false) == 0)
      {
        int num2 = (int) MessageManager.ShowWarningMessage("病历浏览服务获取参数不足，已中止!\r入参信息如下：\r" + ("PatientID:" + patId + "EpisodeID:" + episodeId + "LogID:" + logId + "PrintTempateID:" + printTemplateID + "PrintType:" + printType + "PrintDocID:" + printDocId));
      }
      else
      {
        if (!this.CreateXML(patId, episodeId, logId, printTemplateID, printType, instanceId, userId, printDocId))
          return;
        try
        {
          this.CheckPreviewService();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num3 = (int) MessageBox.Show("检查、更新病历预览服务错误。" + exception.Message + exception.StackTrace);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void CheckPreviewService()
    {
      if (this.IsServiceRuning("PreviewService"))
        return;
      string sysOptionValue = SysOptionManager.GetSysOptionValue("PreviewImpersonator", "");
      if (sysOptionValue.Split('^').Length == 3)
      {
        Impersonator impersonator = (Impersonator) null;
        try
        {
          impersonator = new Impersonator(sysOptionValue.Split('^')[0], sysOptionValue.Split('^')[1], sysOptionValue.Split('^')[2]);
          if (!this.IsAppUpdated() && !this.UpdateApp() || !this.IsServiceIntalled("PreviewService") && !this.InstallService("PreviewService", this.AppSrvFile))
            return;
          this.StartService("PreviewService");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num = (int) MessageBox.Show("更新预览服务错误！\r" + exception.Message + "\r" + exception.StackTrace);
          ProjectData.ClearProjectError();
        }
        finally
        {
          impersonator.Dispose();
        }
      }
      else
      {
        if (!this.IsAppUpdated() && !this.UpdateApp() || !this.IsServiceIntalled("PreviewService") && !this.InstallService("PreviewService", this.AppSrvFile))
          return;
        this.StartService("PreviewService");
      }
    }

    private bool CreateXML(string patId, string episodeId, string logId, string printTemplateID, string printType, string instanceId, string userId, string printDocId)
    {
      bool flag;
      try
      {
        if (!Directory.Exists(this.LocalPathXml))
          Directory.CreateDirectory(this.LocalPathXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("病历浏览服务创建目录" + this.LocalPathXml + "失败。\r\n\r\n" + ex.Message), MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_10;
      }
      string path1 = this.LocalPathXml + "\\" + episodeId + "-" + logId + ".xml";
      string path2 = this.LocalPathXml + "\\" + episodeId + "-" + logId + "-2.xml";
      string filename;
      if (!File.Exists(path1))
      {
        filename = path1;
      }
      else
      {
        if (File.Exists(path2))
          return true;
        filename = path2;
      }
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        XmlNode node1 = xmlDocument.CreateNode(XmlNodeType.XmlDeclaration, "", "");
        xmlDocument.AppendChild(node1);
        XmlNode node2 = xmlDocument.CreateNode(XmlNodeType.Element, "PreviewInfo", (string) null);
        xmlDocument.AppendChild(node2);
        XmlNode node3 = xmlDocument.CreateNode(XmlNodeType.Element, "ServiceURL", (string) null);
        node3.InnerText = dhcc.epr.systemframework.Configuration.get_DataServiceUrl();
        node2.AppendChild(node3);
        XmlNode node4 = xmlDocument.CreateNode(XmlNodeType.Element, "PatientID", (string) null);
        node4.InnerText = patId;
        node2.AppendChild(node4);
        XmlNode node5 = xmlDocument.CreateNode(XmlNodeType.Element, "EpisodeID", (string) null);
        node5.InnerText = episodeId;
        node2.AppendChild(node5);
        XmlNode node6 = xmlDocument.CreateNode(XmlNodeType.Element, "EPRLogsID", (string) null);
        node6.InnerText = logId;
        node2.AppendChild(node6);
        XmlNode node7 = xmlDocument.CreateNode(XmlNodeType.Element, "PrintType", (string) null);
        node7.InnerText = printType;
        node2.AppendChild(node7);
        XmlNode node8 = xmlDocument.CreateNode(XmlNodeType.Element, "PrintTemplateID", (string) null);
        node8.InnerText = printTemplateID;
        node2.AppendChild(node8);
        XmlNode node9 = xmlDocument.CreateNode(XmlNodeType.Element, "InstanceID", (string) null);
        node9.InnerText = instanceId;
        node2.AppendChild(node9);
        XmlNode node10 = xmlDocument.CreateNode(XmlNodeType.Element, "UserID", (string) null);
        node10.InnerText = userId;
        node2.AppendChild(node10);
        XmlNode node11 = xmlDocument.CreateNode(XmlNodeType.Element, "PrintDocID", (string) null);
        node11.InnerText = printDocId;
        node2.AppendChild(node11);
        xmlDocument.Save(filename);
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("病历浏览服务创建XML文件失败。\r\n\r\n" + ex.Message), MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
label_10:
      return flag;
    }

    private bool IsAppUpdated()
    {
      string valueByKey = GlobalValues.GetValueByKey("PREVIEW_SRV_UPDATED_FLAG");
      if (valueByKey == null || Operators.CompareString(valueByKey, "0", false) == 0)
        return false;
      if (Operators.CompareString(valueByKey, "1", false) == 0)
        return true;
      bool flag;
      return flag;
    }

    private bool UpdateApp()
    {
      AppUpdater appUpdater = new AppUpdater();
      appUpdater.UpdaterUrl = dhcc.epr.systemframework.Configuration.get_FormServiceUrl();
      appUpdater.LocalPath = this.LocalPathApp;
      appUpdater.TempPath = this.LocalPathTemp;
      appUpdater.ConfigFile = "VersionConfig.xml";
      if (appUpdater.GetUpdateInfo() > 0)
      {
        if (this.IsServiceRuning("PreviewService"))
          this.StopService("PreviewService");
        if (!appUpdater.DownUpdateFiles())
          return false;
      }
      this.SetAppUpdateFlag();
      return true;
    }

    private void SetAppUpdateFlag()
    {
      if (GlobalValues.GetValueByKey("PREVIEW_SRV_UPDATED_FLAG") != null)
        return;
      GlobalValues.AddKeyValue("PREVIEW_SRV_UPDATED_FLAG", "1");
    }

    private bool IsServiceRuning(string srvName)
    {
      return Process.GetProcessesByName(srvName).Length >= 1;
    }

    private bool IsServiceIntalled(string srvName)
    {
      ServiceController[] services = ServiceController.GetServices();
      int num1 = 0;
      int num2 = checked (services.Length - 1);
      int index = num1;
      while (index <= num2)
      {
        if (Operators.CompareString(services[index].ServiceName, srvName, false) == 0)
          return true;
        checked { ++index; }
      }
      return false;
    }

    private bool InstallService(string srvName, string filePath)
    {
      bool flag;
      try
      {
        ServiceController serviceController = new ServiceController(srvName);
        ManagedInstallerClass.InstallHelper(new string[1]
        {
          filePath
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("安装电子病历后台预览服务错误！\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_3;
      }
      return true;
label_3:
      return flag;
    }

    private bool UnInstallService(string srvName, string filePath)
    {
      AssemblyInstaller assemblyInstaller = new AssemblyInstaller();
      bool flag;
      try
      {
        assemblyInstaller.Path = filePath;
        assemblyInstaller.UseNewContext = true;
        assemblyInstaller.Uninstall((IDictionary) null);
        assemblyInstaller.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("卸载病历预览后台服务错误！\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_5;
      }
      finally
      {
        assemblyInstaller.Dispose();
      }
      return true;
label_5:
      return flag;
    }

    private bool ReInstallService(string srvName, string filePath)
    {
      string serviceExecutablePath = this.GetServiceExecutablePath(srvName);
      if (Operators.CompareString(serviceExecutablePath, "", false) == 0)
        return false;
      if (Operators.CompareString(serviceExecutablePath.ToLower(), filePath.ToLower(), false) != 0)
      {
        bool flag;
        try
        {
          if (!File.Exists(serviceExecutablePath))
          {
            if (!Directory.Exists(serviceExecutablePath.Substring(0, serviceExecutablePath.LastIndexOf("\\"))))
              Directory.CreateDirectory(serviceExecutablePath.Substring(0, serviceExecutablePath.LastIndexOf("\\")));
            File.Copy(filePath, serviceExecutablePath);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num = (int) MessageBox.Show("重安装服务时拷贝文件错误！\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
          flag = false;
          ProjectData.ClearProjectError();
          goto label_11;
        }
        if (!this.UnInstallService(srvName, serviceExecutablePath) || !this.InstallService(srvName, filePath))
          return false;
        goto label_10;
label_11:
        return flag;
      }
label_10:
      return true;
    }

    private bool StartService(string srvName)
    {
      bool flag;
      try
      {
        ServiceController[] services = ServiceController.GetServices();
        int num1 = 0;
        int num2 = checked (services.Length - 1);
        int index = num1;
        while (index <= num2)
        {
          ServiceController serviceController = services[index];
          if (Operators.CompareString(serviceController.ServiceName, srvName, false) == 0)
          {
            serviceController.Start();
            flag = true;
            goto label_7;
          }
          else
            checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("启动电子病历后台预览服务错误!\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_7;
      }
      return false;
label_7:
      return flag;
    }

    private bool StopService(string srvName)
    {
      bool flag;
      try
      {
        ServiceController[] services = ServiceController.GetServices();
        int num1 = 0;
        int num2 = checked (services.Length - 1);
        int index = num1;
        while (index <= num2)
        {
          ServiceController serviceController = services[index];
          if (Operators.CompareString(serviceController.ServiceName, srvName, false) == 0 && serviceController.Status == ServiceControllerStatus.Running)
          {
            serviceController.Stop();
            flag = true;
            goto label_7;
          }
          else
            checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("停止电子病历后台预览服务错误!\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_7;
      }
      return true;
label_7:
      return flag;
    }

    private void GetLocalPath()
    {
      try
      {
        string sysOptionValue = SysOptionManager.GetSysOptionValue("PreviewLocalPath", "^^");
        if (sysOptionValue.Split('^').Length == 4)
        {
          this.m_LocalPathApp = sysOptionValue.Split('^')[0].ToString();
          this.m_LocalPathTemp = sysOptionValue.Split('^')[1].ToString();
          this.m_LocalPathXml = sysOptionValue.Split('^')[2].ToString();
          this.m_AppSrvFile = this.m_LocalPathApp + "\\PreviewService.exe";
        }
        else
        {
          this.m_LocalPathApp = "";
          this.m_LocalPathTemp = "";
          this.m_LocalPathXml = "";
          this.m_AppSrvFile = "";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("获取系统参数错误！\r" + exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
    }

    private string GetServiceExecutablePath(string srvName)
    {
      string str = "";
      try
      {
        RegistryKey registryKey1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services");
        if (registryKey1 != null)
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(srvName);
          if (registryKey2 != null)
            str = Convert.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(registryKey2.GetValue("ImagePath"))));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) MessageBox.Show("没有权限读取注册表信息！\r" + exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
      return str;
    }
  }
}
