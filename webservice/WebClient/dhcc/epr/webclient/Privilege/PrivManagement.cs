// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Privilege.PrivManagement
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.webclient.dataaccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace dhcc.epr.webclient.Privilege
{
  public class PrivManagement
  {
    private static bool m_PrivAvailable = false;

    public static bool PrivAvailable
    {
      get
      {
        if (PrivManagement.m_PrivAvailable)
          return PrivManagement.m_PrivAvailable;
        bool flag = PrivManagement.IsPrivAvailable();
        PrivManagement.m_PrivAvailable = flag;
        return flag;
      }
    }

    [DebuggerNonUserCode]
    public PrivManagement()
    {
    }

    public static string GetPrivileges(string parEInstanceDataId, string parUserId, string parEpisodeId, string parCTLocID, string parCategoryID)
    {
      if (!PrivManagement.PrivAvailable)
        return string.Empty;
      if (!parUserId.Equals(string.Empty) && !parEpisodeId.Equals(string.Empty) && !parCTLocID.Equals(string.Empty))
      {
        if (!parCategoryID.Equals(string.Empty))
        {
          try
          {
            return WebServiceLayer.PrivAccess.ParsePrivRule("userid^" + parUserId + "!admid^" + parEpisodeId + "!instanceid^" + parEInstanceDataId + "!userloc^" + parCTLocID + "!categoryid^" + parCategoryID);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            throw new ApplicationException("获取权限字串失败。");
          }
        }
      }
      throw new ArgumentException("参数有误。");
    }

    public static string GetPrivileges(string parEnvString)
    {
      if (!PrivManagement.PrivAvailable)
        return string.Empty;
      if (parEnvString.Equals(string.Empty))
        throw new ArgumentException("参数不能为空字串。");
      try
      {
        return WebServiceLayer.PrivAccess.ParsePrivRule(parEnvString);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new ApplicationException("获取权限字串失败。");
      }
    }

    public static bool ParsePriv(string parFuncName, string parPrivStr)
    {
      if (!parFuncName.Equals(string.Empty))
      {
        if (!parPrivStr.Equals(string.Empty))
        {
          bool flag;
          try
          {
            int startIndex = checked (parPrivStr.ToUpper().IndexOf(parFuncName.ToUpper()) + parFuncName.Length + 1);
            flag = parPrivStr.Substring(startIndex, 1).Equals("1");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) Interaction.MsgBox((object) "解析权限字串失败！", MsgBoxStyle.OkOnly, (object) null);
            flag = false;
            ProjectData.ClearProjectError();
          }
          return flag;
        }
      }
      return false;
    }

    public static bool IsPrivAvailable()
    {
      bool flag;
      try
      {
        string sysOptionValue = SysOptionManager.GetSysOptionValue("PrivControl", "Y");
        flag = sysOptionValue != null && sysOptionValue.ToUpper().Equals("Y");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取权限控制系统参数失败！", MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }
  }
}
