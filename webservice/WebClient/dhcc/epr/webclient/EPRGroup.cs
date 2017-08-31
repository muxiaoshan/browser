// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.EPRGroup
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using dhcc.epr.webclient.dataaccess;
using dhcc.epr.webclient.Quality;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class EPRGroup : EPRBase
  {
    private IContainer components;
    [AccessedThroughProperty("btnGroupTemplate")]
    private Button _btnGroupTemplate;
    private ArrayList EInstanceDataArray;
    private ArrayList PInterfaceArray;
    private TabControlAdv PInterfacesTabs;

    internal virtual Button btnGroupTemplate
    {
      [DebuggerNonUserCode] get
      {
        return this._btnGroupTemplate;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGroupTemplate_Click);
        if (this._btnGroupTemplate != null)
          this._btnGroupTemplate.Click -= eventHandler;
        this._btnGroupTemplate = value;
        if (this._btnGroupTemplate == null)
          return;
        this._btnGroupTemplate.Click += eventHandler;
      }
    }

    public event EPRGroup.InitialTabPageEventEventHandler InitialTabPageEvent;

    public EPRGroup()
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
      this.btnGroupTemplate = new Button();
      this.BottomPanel.SuspendLayout();
      this.btnRefresh.Name = "btnRefresh";
      this.MainPanel.Name = "MainPanel";
      this.BottomPanel.Controls.Add((Control) this.btnGroupTemplate);
      this.BottomPanel.Name = "BottomPanel";
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnRefresh, 0);
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnCommit, 0);
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnPrint, 0);
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnTemplate, 0);
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnSave, 0);
      this.BottomPanel.Controls.SetChildIndex((Control) this.btnGroupTemplate, 0);
      this.btnSave.Name = "btnSave";
      this.btnPrint.Name = "btnPrint";
      this.btnTemplate.Name = "btnTemplate";
      this.btnCommit.Name = "btnCommit";
      this.btnGroupTemplate.BackColor = Color.FromArgb(49, 101, 156);
      this.btnGroupTemplate.FlatStyle = FlatStyle.Flat;
      this.btnGroupTemplate.ForeColor = SystemColors.ControlLightLight;
      this.btnGroupTemplate.Location = new Point(496, 5);
      this.btnGroupTemplate.Name = "btnGroupTemplate";
      this.btnGroupTemplate.Size = new Size(96, 24);
      this.btnGroupTemplate.TabIndex = 7;
      this.btnGroupTemplate.Text = "选择组模板...";
      this.Name = "EPRGroup";
      this.BottomPanel.ResumeLayout(false);
    }

    protected override void Init()
    {
      if (!this.IsAllPropertiesSet())
        return;
      this.InitSysConfig();
      this.PreInitContent();
      this.InitContent();
      this.AfterInitContent();
    }

    protected override void InitContent()
    {
      try
      {
        EInsGroupNewDataSet groupitemlist = (EInsGroupNewDataSet) null;
        LogManager.WriteLog("取GroupList", true);
        if (Operators.CompareString(this.m_CategoryType, "Group", false) == 0)
          groupitemlist = WebServiceLayer.InstanceAccess.GetGroupItemList(this.m_PatientID, this.m_EpisodeID, this.m_EpisodeType, this.m_ProfileID, this.m_ChartItemType, this.m_CategoryType, this.m_CategoryID);
        else if (Operators.CompareString(this.m_CategoryType, "GroupParent", false) == 0)
          groupitemlist = WebServiceLayer.InstanceAccess.GetParentGroupList(this.m_PatientID, this.m_EpisodeID, this.m_EpisodeType, this.m_ProfileID, this.m_ChartItemType, this.m_CategoryType, this.m_CategoryID);
        LogManager.WriteLog("End取GroupList", true);
        this.InitialGroup(groupitemlist);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowInformationMessage("病历内容调入失败。" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
    }

    private void InitialGroup(EInsGroupNewDataSet groupitemlist)
    {
      if (groupitemlist.SELECTGroupListNew.Rows.Count == 0)
        return;
      LogManager.WriteLog("初始化GroupList", true);
      this.PInterfacesTabs = new TabControlAdv();
      this.PInterfacesTabs.set_TabStyle(typeof (TabRenderer3D));
      ((Control) this.PInterfacesTabs).Dock = DockStyle.Fill;
      this.PInterfacesTabs.set_BorderStyle(BorderStyle.Fixed3D);
      this.PInterfacesTabs.set_ThemesEnabled(true);
      this.PInterfacesTabs.set_FocusOnTabClick(false);
      this.EInstanceDataArray = new ArrayList();
      this.PInterfaceArray = new ArrayList();
      this.PInterfacesTabs.add_SelectedIndexChanged(new EventHandler(this.PInterfacesTabs_SelectedIndexChanged));
      bool flag = false;
      try
      {
        foreach (EInsGroupNewDataSet.SELECTGroupListNewRow selectGroupListNewRow in groupitemlist.SELECTGroupListNew)
        {
          if (Operators.CompareString(selectGroupListNewRow.ItemStatus, "UnView", false) != 0)
          {
            TabPageAdv tabPageAdv = new TabPageAdv();
            tabPageAdv.set_Text(selectGroupListNewRow.GroupItemName);
            ((Panel) tabPageAdv).BorderStyle = BorderStyle.None;
            this.EInstanceDataArray.Add((object) selectGroupListNewRow.ID);
            this.PInterfaceArray.Add((object) null);
            this.PInterfacesTabs.get_TabPages().Add(tabPageAdv);
            flag = true;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.MainPanel.Controls.Add((Control) this.PInterfacesTabs);
      LogManager.WriteLog("End初始化GroupList", true);
      if (flag)
        this.InitialTabPages(0);
      else
        this.SetTabInvalid();
    }

    private void InitialTabPages(int pagenum)
    {
      LogManager.WriteLog("取InstanceData", true);
      EInstanceData groupDataById = WebServiceLayer.InstanceAccess.GetGroupDataByID(Conversions.ToString(this.EInstanceDataArray[pagenum]));
      LogManager.WriteLog("End取InstanceData", true);
      this.LoadTemplateIntoTab(pagenum, ref groupDataById);
    }

    private void LoadTemplateIntoTab(int tabIndex, ref EInstanceData instanceData)
    {
      PInterface objPInterface = (PInterface) null;
      this.EInstanceDataArray[tabIndex] = (object) instanceData;
      this.CurrentEInstanceData = instanceData;
      bool flag = false;
      if (instanceData.TemplateID != null && !instanceData.TemplateID.Equals(string.Empty))
        flag = true;
      if (!flag)
      {
        this.SetPanelInvalid("当前页签没有适用的模板");
      }
      else
      {
        objPInterface = new PInterface();
        ((Control) objPInterface).Dock = DockStyle.Fill;
        this.InitialTemplate(instanceData, ref objPInterface);
        ((Control) this.PInterfacesTabs.get_TabPages().get_Item(tabIndex)).Controls.Add((Control) objPInterface);
      }
      this.PInterfaceArray[tabIndex] = (object) objPInterface;
      this.CurrentPInterface = objPInterface;
    }

    protected override void InitSysConfig()
    {
      base.InitSysConfig();
      QualityCheck.QualityCtrlParam = SysOptionManager.GetSysOptionValue("SingleQualityCtrl", string.Empty);
    }

    protected override void SwitchTemplate(string parAction)
    {
      base.SwitchTemplate(parAction);
      this.EInstanceDataArray[this.PInterfacesTabs.get_SelectedIndex()] = (object) this.CurrentEInstanceData;
    }

    protected void SwitchTemplateGroup()
    {
      frmChangeTemplate frmChangeTemplate = new frmChangeTemplate();
      frmChangeTemplate.EpisodeID = this.CurrentEInstanceData.EpisodeID;
      frmChangeTemplate.CategoryID = !(this.CurrentEInstanceData.GroupItemID == null | Operators.CompareString(this.CurrentEInstanceData.GroupItemID, "", false) == 0) ? this.CurrentEInstanceData.GroupItemID : this.CurrentEInstanceData.CategoryID;
      if (frmChangeTemplate.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      if (!(frmChangeTemplate.NewTemplateID == null | Operators.CompareString(frmChangeTemplate.NewTemplateID, "", false) == 0))
        this.ShowGroupTemplate(frmChangeTemplate.NewTemplateID, frmChangeTemplate.NewTemplateName);
      this.ShowMessageBox("成组模板切换成功，请查看并保存其他页签的内容！", false, "");
    }

    private void ShowGroupTemplate(string newTemplateID, string newTemplateName)
    {
      int num1 = 0;
      int num2 = checked (this.EInstanceDataArray.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (this.EInstanceDataArray[index] is EInstanceData)
        {
          EInstanceData einstanceData = (EInstanceData) this.EInstanceDataArray[index];
          this.EInstanceDataArray[index] = (object) einstanceData.ID;
        }
        EInstanceLog parLog = this.ChanegStatusAndAddLog("SwitchGroup", StatusManagement.GetCurrentStatus(Conversions.ToString(this.EInstanceDataArray[index])), Conversions.ToString(this.EInstanceDataArray[index]));
        this.SetCurLog(Conversions.ToString(this.EInstanceDataArray[index]), parLog);
        this.PInterfaceArray[index] = (object) null;
        ((Control) this.PInterfacesTabs.get_TabPages().get_Item(index)).Controls.Clear();
        checked { ++index; }
      }
      this.CurrentEInstanceData = WebServiceLayer.InstanceAccess.ReplaceGroupData(this.CurrentEInstanceData.ID, newTemplateID, newTemplateName);
      this.LoadTemplateIntoTab(this.PInterfacesTabs.get_SelectedIndex(), ref this.CurrentEInstanceData);
    }

    private void PInterfacesTabs_SelectedIndexChanged(object sender, EventArgs e)
    {
      int selectedIndex = this.PInterfacesTabs.get_SelectedIndex();
      if (selectedIndex < 0)
        return;
      bool flag;
      if (this.EInstanceDataArray[selectedIndex] is string)
        flag = true;
      if (flag)
        this.InitialTabPages(selectedIndex);
      this.CurrentPInterface = (PInterface) this.PInterfaceArray[selectedIndex];
      this.CurrentEInstanceData = (EInstanceData) this.EInstanceDataArray[selectedIndex];
      if (this.CurrentPInterface == null)
      {
        if (this.CurrentEInstanceData.TemplateID == null || Operators.CompareString(this.CurrentEInstanceData.TemplateID, "", false) == 0)
          this.SetPanelInvalid("当前页签没有适用的模板");
        else
          this.SetPanelInvalid("当前模板实例数据为空");
      }
      else
      {
        if (flag)
          return;
        this.InitAfterLoadContent(ref this.CurrentEInstanceData);
      }
    }

    private void btnGroupTemplate_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "本操作将清除本组病历中的所有内容，是否继续？", MsgBoxStyle.OkCancel, (object) "注意！") == MsgBoxResult.Cancel)
        return;
      this.SwitchTemplateGroup();
    }

    protected override string GetTemplateName()
    {
      return this.PInterfacesTabs.get_TabPages().get_Item(this.PInterfacesTabs.get_SelectedIndex()).get_Text() ?? string.Empty;
    }

    protected override void GetButtonPriv(string parInstanceID)
    {
      base.GetButtonPriv(parInstanceID);
      this.btnGroupTemplate.Enabled = this.btnTemplate.Enabled;
    }

    protected override void SetPanelInvalid(string message)
    {
      base.SetPanelInvalid(message);
      this.btnGroupTemplate.Enabled = false;
    }

    public delegate void InitialTabPageEventEventHandler(int pagenum);
  }
}
