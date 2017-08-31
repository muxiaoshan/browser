// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.LogManagement
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.webclient.dataaccess;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;

namespace dhcc.epr.webclient
{
  public class LogManagement
  {
    [DebuggerNonUserCode]
    public LogManagement()
    {
    }

    public static EInstanceLog AddLog(string parInstanceDataId, string parPreStatus, string parAction, string parFinalStatus, string parUserId, string parUserLevel)
    {
      EInstanceLog einstanceLog1;
      try
      {
        ArrayList arrayList = new ArrayList();
        EInstanceLog einstanceLog2 = new EInstanceLog();
        ArrayList log = LogManagement.GenerateLog(parPreStatus, parAction, parFinalStatus, parUserId, parUserLevel);
        try
        {
          foreach (EInstanceLog parLog in log)
          {
            if (!WebServiceLayer.InstanceAccess.AddLog(parInstanceDataId, parLog).Equals("1"))
            {
              int num = (int) Interaction.MsgBox((object) "添加日志失败！", MsgBoxStyle.OkOnly, (object) null);
              einstanceLog1 = (EInstanceLog) null;
              goto label_10;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        einstanceLog1 = WebServiceLayer.InstanceAccess.GetFinalLog(parInstanceDataId);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "添加日志失败！", MsgBoxStyle.OkOnly, (object) null);
        einstanceLog1 = (EInstanceLog) null;
        ProjectData.ClearProjectError();
      }
label_10:
      return einstanceLog1;
    }

    public static ArrayList GenerateLog(string parPreStatus, string parAction, string parFinalStatus, string parUserId, string parUserLevel)
    {
      ArrayList arrayList1;
      try
      {
        ArrayList arrayList2 = new ArrayList();
        EInstanceLog einstanceLog = new EInstanceLog();
        einstanceLog.Action = parAction;
        einstanceLog.InitStatus = parPreStatus;
        einstanceLog.OperateDate = DateAndTime.Now.ToString("yyyy-M-d");
        einstanceLog.OperateTime = DateAndTime.Now.ToString("H:mm:ss");
        einstanceLog.OperateUserID = parUserId;
        einstanceLog.FinalStatus = StatusManagement.GenerateFinalStatus(parUserLevel, einstanceLog.InitStatus, parAction);
        einstanceLog.OperateMachineIP = LogManagement.GetClientIP();
        arrayList2.Add((object) einstanceLog);
        arrayList1 = arrayList2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "生成日志失败！", MsgBoxStyle.OkOnly, (object) null);
        arrayList1 = new ArrayList();
        ProjectData.ClearProjectError();
      }
      return arrayList1;
    }

    public static bool ClearLog(string parInstanceDataId)
    {
      bool flag;
      try
      {
        flag = WebServiceLayer.InstanceAccess.ClearLog(parInstanceDataId).Equals("1");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "清除日志失败！", MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static EInstanceLog GetFinalLog(string parInstanceDataId)
    {
      EInstanceLog einstanceLog;
      try
      {
        einstanceLog = WebServiceLayer.InstanceAccess.GetFinalLog(parInstanceDataId);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取日志失败！", MsgBoxStyle.OkOnly, (object) null);
        einstanceLog = (EInstanceLog) null;
        ProjectData.ClearProjectError();
      }
      return einstanceLog;
    }

    public static string GetClientIP()
    {
      return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
    }

    public static string SingleOperLog(string parAction, string parEpisodeID, string parPrnTemplateDocID, string parTemplateDocID, string parUserID, string parTemplateID)
    {
      if (Operators.CompareString(parAction, (string) null, false) == 0 || parAction.Equals(string.Empty))
      {
        int num = (int) Interaction.MsgBox((object) "没有操作名称，不能生成日志。", MsgBoxStyle.OkOnly, (object) "提示");
        return "Error";
      }
      if (Operators.CompareString(parEpisodeID, (string) null, false) == 0 || parEpisodeID.Equals(string.Empty))
      {
        int num = (int) Interaction.MsgBox((object) "没有就诊号，不能生成日志。", MsgBoxStyle.OkOnly, (object) "提示");
        return "Error";
      }
      if (Operators.CompareString(parPrnTemplateDocID, (string) null, false) == 0 || parPrnTemplateDocID.Equals(string.Empty))
      {
        int num = (int) Interaction.MsgBox((object) "没有打印模板ID，不能生成日志。", MsgBoxStyle.OkOnly, (object) "提示");
        return "Error";
      }
      if (Operators.CompareString(parTemplateDocID, (string) null, false) == 0 || parTemplateDocID.Equals(string.Empty))
      {
        int num = (int) Interaction.MsgBox((object) "没有界面模板ID，不能生成日志。", MsgBoxStyle.OkOnly, (object) "提示");
        return "Error";
      }
      if (Operators.CompareString(parUserID, (string) null, false) != 0)
      {
        if (!parUserID.Equals(string.Empty))
        {
          string str;
          try
          {
            string clientIp = LogManagement.GetClientIP();
            return WebServiceLayer.InstanceAccess.InitAfterSingleOper(parAction, parEpisodeID, parPrnTemplateDocID, "1", parTemplateDocID, DateAndTime.Now.ToString("yyyy-M-d"), DateAndTime.Now.ToString("H:mm:ss"), clientIp, parUserID, parTemplateID);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            str = "Error";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(str.ToLower(), "error", false) == 0)
          {
            int num = (int) Interaction.MsgBox((object) "日志生成失败，请联系管理员。", MsgBoxStyle.OkOnly, (object) "提示");
          }
          return str;
        }
      }
      int num1 = (int) Interaction.MsgBox((object) "没有操作用户ID，不能生成日志。", MsgBoxStyle.OkOnly, (object) "提示");
      return "Error";
    }

    public static string MulitOperLog(string parHappenDateTime, string parAction, string parEpisodeID, string parPrnTemplateDocID, string parEPRNum, string parUserID, string parTemplateID)
    {
      string str;
      try
      {
        string clientIp = LogManagement.GetClientIP();
        string parHappenDate = parHappenDateTime.Split('^')[0];
        string parHappenTime = parHappenDateTime.Split('^')[1];
        str = WebServiceLayer.InstanceAccess.InitAfterMultiOper(parAction, parEpisodeID, parPrnTemplateDocID, parEPRNum, clientIp, parHappenDate, parHappenTime, parUserID, parTemplateID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "Error";
        ProjectData.ClearProjectError();
      }
      if (Operators.CompareString(str.ToLower(), "error", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "日志生成失败，请联系管理员。", MsgBoxStyle.OkOnly, (object) "提示");
      }
      return str;
    }

    public static bool MultiPrintLog(string parEpisodeID, string parEPRDocIDs, string parUserID)
    {
      string clientIp = LogManagement.GetClientIP();
      if (!WebServiceLayer.InstanceAccess.UpdateEPRLogs(parEpisodeID, parEPRDocIDs, "Print", clientIp, parUserID).Equals("0"))
        return true;
      int num = (int) Interaction.MsgBox((object) "日志生成失败，请联系管理员。", MsgBoxStyle.Information, (object) "提示");
      return false;
    }

    public static EInstanceLog CreateLog(string parPreStatus, string parAction, string parUserId, string parUserLevel)
    {
      try
      {
        EInstanceLog einstanceLog = new EInstanceLog();
        einstanceLog.Action = parAction;
        einstanceLog.InitStatus = parPreStatus;
        einstanceLog.OperateDate = DateAndTime.Now.ToString("yyyy-M-d");
        einstanceLog.OperateTime = DateAndTime.Now.ToString("H:mm:ss");
        einstanceLog.OperateUserID = parUserId;
        einstanceLog.FinalStatus = StatusManagement.GenerateFinalStatus(parUserLevel, einstanceLog.InitStatus, parAction);
        einstanceLog.OperateMachineIP = LogManagement.GetClientIP();
        return einstanceLog;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) "创建本地日志失败！", MsgBoxStyle.OkOnly, (object) null);
        throw new Exception(exception.Message + "\r\n" + exception.StackTrace);
      }
    }
  }
}
