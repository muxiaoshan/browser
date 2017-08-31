// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.EPRNormal
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.webclient.dataaccess;
using dhcc.epr.webclient.Quality;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class EPRNormal : EPRBase
  {
    private IContainer components;

    public EPRNormal()
    {
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
      this.BottomPanel.Location = new Point(0, 68);
      this.BottomPanel.Name = "BottomPanel";
      Panel bottomPanel = this.BottomPanel;
      Size size1 = new Size(616, 56);
      Size size2 = size1;
      bottomPanel.Size = size2;
      this.btnTemplate.Name = "btnTemplate";
      this.btnPrint.Name = "btnPrint";
      this.btnRefresh.Name = "btnRefresh";
      this.btnCommit.Name = "btnCommit";
      this.MainPanel.Dock = DockStyle.Fill;
      this.MainPanel.Name = "MainPanel";
      Panel mainPanel = this.MainPanel;
      size1 = new Size(616, 68);
      Size size3 = size1;
      mainPanel.Size = size3;
      this.btnSave.Name = "btnSave";
      this.Name = "EPRNormal";
      size1 = new Size(616, 124);
      this.Size = size1;
    }

    protected override void Init()
    {
      if (!this.IsAllPropertiesSet())
        return;
      this.InitSysConfig();
      this.PreInitContent();
      this.InitContent();
      this.AfterInitContent();
      this.ClearProperties();
    }

    protected override void ClearProperties()
    {
      ArrayList arrayList = new ArrayList();
      try
      {
        foreach (EPRBase.DllProperty setDllProperty in this.SetDllProperties)
        {
          if (setDllProperty.PName.Equals("ChartItemID") || setDllProperty.PName.Equals("ProfileID") || (setDllProperty.PName.Equals("Browsable") || setDllProperty.PName.Equals("Revisionable")))
            arrayList.Add((object) setDllProperty);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (EPRBase.DllProperty dllProperty in arrayList)
          this.SetDllProperties.Remove((object) dllProperty);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    protected override void InitSysConfig()
    {
      base.InitSysConfig();
      QualityCheck.QualityCtrlParam = SysOptionManager.GetSysOptionValue("SingleQualityCtrl", string.Empty);
    }

    protected override void InitContent()
    {
      try
      {
        LogManager.WriteLog("取InstanceData", true);
        if (this.m_PatientID == null || this.m_PatientID.Equals(string.Empty))
        {
          int num1 = (int) Interaction.MsgBox((object) "缺少参数PatientID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else if (this.m_EpisodeID == null || this.m_EpisodeID.Equals(string.Empty))
        {
          int num2 = (int) Interaction.MsgBox((object) "缺少参数EpisodeID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else if (this.m_EpisodeType == null || this.m_EpisodeType.Equals(string.Empty))
        {
          int num3 = (int) Interaction.MsgBox((object) "缺少参数EpisodeType，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else if (this.m_ProfileID == null || this.m_ProfileID.Equals(string.Empty))
        {
          int num4 = (int) Interaction.MsgBox((object) "缺少参数ProfileID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else if (this.m_ChartItemType == null || this.m_ChartItemType.Equals(string.Empty))
        {
          int num5 = (int) Interaction.MsgBox((object) "缺少参数ChartItemType，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else if (this.m_CategoryType == null || this.m_CategoryType.Equals(string.Empty))
        {
          int num6 = (int) Interaction.MsgBox((object) "缺少参数CategoryType，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
        }
        else
        {
          this.CurrentEInstanceData = (EInstanceData) null;
          this.CurrentEInstanceData = WebServiceLayer.InstanceAccess.GetNormalData(this.m_PatientID, this.m_EpisodeID, this.m_EpisodeType, this.m_ProfileID, this.m_ChartItemType, this.m_CategoryType, this.m_CategoryID);
          LogManager.WriteLog("End取InstanceData", true);
          if (this.CurrentEInstanceData.TemplateID == null || Operators.CompareString(this.CurrentEInstanceData.TemplateID, "", false) == 0)
          {
            this.SetPanelInvalid("当前页签没有适用的模板");
          }
          else
          {
            if (this.MainPanel.Controls.Contains((Control) this.CurrentPInterface))
              this.MainPanel.Controls.Remove((Control) this.CurrentPInterface);
            this.CurrentPInterface = new PInterface();
            ((Control) this.CurrentPInterface).Dock = DockStyle.Fill;
            EInstanceData currentEinstanceData = this.CurrentEInstanceData;
            PInterface currentPinterface = this.CurrentPInterface;
            this.InitialTemplate(currentEinstanceData, ref currentPinterface);
            this.CurrentPInterface = currentPinterface;
            this.MainPanel.Controls.Add((Control) this.CurrentPInterface);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("病历内容调入失败。" + exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    protected override string OperLog(string parAction)
    {
      string operTplId = this.GetOperTplID(parAction);
      return LogManagement.SingleOperLog(parAction, this.m_EpisodeID, this.m_PrnTemplateDocID, this.m_TemplateDocID, this.UserID, operTplId);
    }

    protected override string GetTemplateName()
    {
      return this.CurrentEInstanceData.Title;
    }
  }
}
