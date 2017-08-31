// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.StatusManagement
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.webclient.dataaccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace dhcc.epr.webclient
{
  public class StatusManagement
  {
    [DebuggerNonUserCode]
    public StatusManagement()
    {
    }

    public static string GenerateFinalStatus(string parOperatorLevel, string parPreStatus, string parAction)
    {
      try
      {
        if (parPreStatus == null || parPreStatus.Equals(string.Empty) || (parAction == null || parAction.Equals(string.Empty)))
          throw new ArgumentNullException();
        string Left = parAction;
        if (Operators.CompareString(Left, "Print", false) == 0)
          return parPreStatus;
        if (Operators.CompareString(Left, "Save", false) == 0)
        {
          if (Operators.CompareString(parOperatorLevel, "Attending", false) == 0 && Operators.CompareString(parPreStatus, "Commit", false) == 0)
            return "Attending_Doc_Check";
          if (Operators.CompareString(parOperatorLevel, "Chief", false) == 0 && (Operators.CompareString(parPreStatus, "Attending_Doc_Check", false) == 0 || Operators.CompareString(parPreStatus, "Commit", false) == 0))
            return "Chief_Doc_Check";
          if (Operators.CompareString(parPreStatus, "UnSave", false) == 0)
            return "Save";
          return parPreStatus;
        }
        if (Operators.CompareString(Left, "Commit", false) == 0)
        {
          if (parPreStatus.Equals("Attending_Doc_Check") || parPreStatus.Equals("Chief_Doc_Check") || parPreStatus.Equals("UnSave"))
            return parPreStatus;
          return "Commit";
        }
        if (Operators.CompareString(Left, "Switch", false) == 0 || Operators.CompareString(Left, "SwitchGroup", false) == 0)
          return "UnSave";
        return parPreStatus;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) "生成病历状态失败！", MsgBoxStyle.OkOnly, (object) null);
        throw new Exception(exception.Message + "\r\n" + exception.StackTrace);
      }
    }

    public static string GetCurrentStatus(string parInstanceDataId)
    {
      string str;
      try
      {
        str = WebServiceLayer.InstanceAccess.GetCurrentStatus(parInstanceDataId) ?? string.Empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取病历当前状态失败！", MsgBoxStyle.OkOnly, (object) null);
        str = string.Empty;
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static bool CheckStatusExist(string parInstanceDataId, string parStatus)
    {
      bool flag;
      try
      {
        flag = WebServiceLayer.InstanceAccess.CheckFinalStatus(parInstanceDataId, parStatus).Equals("1");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "检查病历状态失败！", MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static bool ChangeStatus(string parInstanceDataId, string parPreStatus, string parStatus)
    {
      bool flag;
      try
      {
        flag = parPreStatus.Equals(parStatus) || WebServiceLayer.InstanceAccess.ChangeStatus(parInstanceDataId, parStatus).Equals("1");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "修改病历状态失败！", MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }
  }
}
