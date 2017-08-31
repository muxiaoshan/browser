// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Quality.QualityCheck
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.webclient.dataaccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace dhcc.epr.webclient.Quality
{
  public class QualityCheck
  {
    public const string NewQuality = "New";
    public const string OldQulity = "Old";
    private static string _controlType;
    private static string _ssgroupid;
    private static string _ctlocid;
    private static string _qualityCtrlParam;

    public static string ControlType
    {
      get
      {
        string controlType = QualityCheck._controlType;
        QualityCheck._controlType = (string) null;
        return controlType;
      }
    }

    public static string SSGroupID
    {
      set
      {
        QualityCheck._ssgroupid = value;
      }
    }

    public static string CTLocID
    {
      set
      {
        QualityCheck._ctlocid = value;
      }
    }

    public static string QualityCtrlParam
    {
      set
      {
        QualityCheck._qualityCtrlParam = value;
      }
    }

    [DebuggerNonUserCode]
    public QualityCheck()
    {
    }

    public static QualityCheck.QualityChkResult OperationPass(string parEpisodeId, string parAction, string parTemplateId, string parInstanceDataIDs, string parUserId)
    {
      try
      {
        if (QualityCheck._qualityCtrlParam.Equals(string.Empty))
          return QualityCheck.QualityChkResult.NoCheck;
        string str = "^" + parAction + "^";
        if (("^" + QualityCheck._qualityCtrlParam + "^").ToLower().IndexOf(str.ToLower()) < 0)
          return QualityCheck.QualityChkResult.NoCheck;
        if (QualityCheck.TemplateQualityChk(parEpisodeId, parAction, parTemplateId, parInstanceDataIDs, parUserId, ""))
        {
          string controlType = QualityCheck.ControlType;
          if (controlType.Equals("0"))
            return QualityCheck.QualityChkResult.ControlIllegal;
          if (controlType.Equals("1"))
            return QualityCheck.QualityChkResult.PromptIllegal;
        }
        return QualityCheck.QualityChkResult.Legal;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("质控检查错误。\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        throw new Exception("质控检查错误");
      }
    }

    public static QualityCheck.QualityChkResult OperationPass(string parEpisodeId, string parAction, string parTemplateId, string parInstanceDataIDs, string parUserId, string parprintTemplateDocId)
    {
      try
      {
        if (QualityCheck._qualityCtrlParam.Equals(string.Empty))
          return QualityCheck.QualityChkResult.NoCheck;
        string str = "^" + parAction + "^";
        if (("^" + QualityCheck._qualityCtrlParam + "^").ToLower().IndexOf(str.ToLower()) < 0)
          return QualityCheck.QualityChkResult.NoCheck;
        if (QualityCheck.TemplateQualityChk(parEpisodeId, parAction, parTemplateId, parInstanceDataIDs, parUserId, parprintTemplateDocId))
        {
          string controlType = QualityCheck.ControlType;
          if (controlType.Equals("0"))
            return QualityCheck.QualityChkResult.ControlIllegal;
          if (controlType.Equals("1"))
            return QualityCheck.QualityChkResult.PromptIllegal;
        }
        return QualityCheck.QualityChkResult.Legal;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("质控检查错误。\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        throw new Exception("质控检查错误");
      }
    }

    public static bool TemplateQualityChk(string parEpisodeId, string parAction, string parTemplateId, string parInstanceDataIDs, string parUserId, string parprintTemplateDocId)
    {
      if (SysOptionManager.GetSysOptionValue("NewQualityCtrlInterface", "N").Equals("Y"))
        parAction = parAction + "^" + QualityCheck._ssgroupid + "^" + QualityCheck._ctlocid;
      QuaDataListUtil quaDataListUtil = new QuaDataListUtil(parEpisodeId, parAction, parTemplateId, parInstanceDataIDs, parprintTemplateDocId);
      QuaExamItemCollection examItemCollection1 = new QuaExamItemCollection();
      string str = "";
      bool flag = false;
      QuaExamItemCollection examItemCollection2;
      try
      {
        examItemCollection2 = quaDataListUtil.CheckTemplate();
        if (examItemCollection2 != null)
        {
          if (!examItemCollection2.Count.Equals(0))
            goto label_7;
        }
        return false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("请联系管理员检查质控配置！\r\n\r\n" + exception.Message), MsgBoxStyle.Critical, (object) "质控检查错误！");
        throw exception;
      }
label_7:
      if (examItemCollection2.Count > 0)
      {
        int num1 = 0;
        int num2 = checked (examItemCollection2.Count - 1);
        int index = num1;
        while (index <= num2)
        {
          QuaExamItem quaExamItem = new QuaExamItem();
          string strMsg = examItemCollection2[index].EntryDesc.ToString() + "\r\n";
          WebServiceLayer.QualityAccess.QuaSendMsgToUser(strMsg, parUserId);
          str += strMsg;
          checked { ++index; }
        }
        int num3 = (int) Interaction.MsgBox((object) ("病历存在质量问题,请检查每个页签填写是否完整,或是否保存！\r\n" + str), MsgBoxStyle.OkOnly, (object) "质控列表提示");
        try
        {
          QualityCheck._controlType = quaDataListUtil.GetControlType();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
        flag = true;
      }
      return flag;
    }

    public static string GetTemplateIdByInstanceId(string argInstanceId)
    {
      if (argInstanceId.Equals(string.Empty))
        return string.Empty;
      return WebServiceLayer.InstanceAccess.GetTemplateIDByID(argInstanceId);
    }

    public static string QualityVersion()
    {
      return SysOptionManager.GetSysOptionValue("EPRExamRuleDr", "New").Equals("New") ? "New" : "Old";
    }

    public enum QualityChkResult
    {
      ControlIllegal = -2,
      PromptIllegal = -1,
      NoCheck = 0,
      Legal = 1,
    }
  }
}
