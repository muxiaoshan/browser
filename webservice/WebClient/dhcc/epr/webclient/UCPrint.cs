// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.UCPrint
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.design.printreview;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using dhcc.epr.webclient.Quality;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class UCPrint : UserControl
  {
    private IContainer components;
    private string _EPRDocIDs;
    private bool _IsNewFramework;

    public string EPRDocIDs
    {
      set
      {
        this._EPRDocIDs = value;
      }
    }

    public bool IsNewFramework
    {
      set
      {
        this._IsNewFramework = value;
      }
    }

    public UCPrint()
    {
      this._IsNewFramework = false;
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
    }

    public bool PrintMultiple(string patientID, string episodeID, string instanceDataIDs, string userID, string printDocID)
    {
      SysOptionManager.InitBasicSysOption();
      PrintClient printClient = new PrintClient();
      string[] strArray = Strings.Split(instanceDataIDs, ",", -1, CompareMethod.Binary);
      bool flag;
      try
      {
        if (QualityCheck.QualityVersion().Equals("New"))
        {
          if (strArray.Length > 0)
          {
            string templateIdByInstanceId = QualityCheck.GetTemplateIdByInstanceId(strArray[0]);
            if (templateIdByInstanceId.Equals(string.Empty))
            {
              flag = false;
              goto label_16;
            }
            else
            {
              QualityCheck.QualityCtrlParam = SysOptionManager.GetSysOptionValue("MultiQualityCtrl", string.Empty);
              if (QualityCheck.OperationPass(episodeID, "Print", templateIdByInstanceId, instanceDataIDs, userID, printDocID).Equals((object) QualityCheck.QualityChkResult.ControlIllegal))
              {
                int num = (int) Interaction.MsgBox((object) "质控检查未通过，请修改后重新打印。", MsgBoxStyle.Information, (object) "质控提示");
                flag = false;
                goto label_16;
              }
            }
          }
          else
          {
            flag = false;
            goto label_16;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) (exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_16;
      }
      if (!printClient.PrintMultiple(patientID, episodeID, instanceDataIDs, userID, printDocID))
        return false;
      if (this._IsNewFramework && (this._EPRDocIDs == null || this._EPRDocIDs.Equals(string.Empty)) || !this._IsNewFramework && this._EPRDocIDs != null && !this._EPRDocIDs.Equals(string.Empty))
      {
        int num = (int) Interaction.MsgBox((object) "打印日志相关参数不足，请联系管理员。", MsgBoxStyle.OkOnly, (object) null);
        return false;
      }
      if (!this._IsNewFramework)
        return true;
      return LogManagement.MultiPrintLog(episodeID, this._EPRDocIDs, userID);
label_16:
      return flag;
    }

    public bool PreviewMultiple(string patientID, string episodeID, string instanceDataIDs, string userID, string printDocID)
    {
      SysOptionManager.InitBasicSysOption();
      try
      {
        new PrintClient().PreviewMultiple(patientID, episodeID, instanceDataIDs, userID, printDocID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage("预览病历失败！" + exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
      bool flag;
      return flag;
    }

    public bool ExportRecordMultiple(string patientID, string episodeID, string instanceDataIDs, string userID, string printDocID)
    {
      SysOptionManager.InitBasicSysOption();
      try
      {
        new PrintClient().ExportMultiple(patientID, episodeID, instanceDataIDs, userID, printDocID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage("预览病历失败！" + exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
      bool flag;
      return flag;
    }
  }
}
