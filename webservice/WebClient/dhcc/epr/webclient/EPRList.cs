// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.EPRList
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using BOCustomDictory;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using dhcc.epr.webclient.dataaccess;
using dhcc.epr.webclient.Quality;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class EPRList : EPRBase
  {
    private IContainer components;
    [AccessedThroughProperty("pnlTitleDateTime")]
    private Panel _pnlTitleDateTime;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("DTPicker")]
    private DateTimePicker _DTPicker;
    [AccessedThroughProperty("cbxTitle")]
    private ComboBox _cbxTitle;
    [AccessedThroughProperty("lblRemark")]
    private Label _lblRemark;
    [AccessedThroughProperty("txtRemark")]
    private TextBox _txtRemark;
    private bool isNew;
    private string _InstanceDataID;
    private string _EPRNum;
    private string[] m_TitleList;
    private bool m_AllowNonStandardTitle;
    private EDiagnosTypeByTitle m_DiagnosTypeByTitle;

    internal virtual Panel pnlTitleDateTime
    {
      [DebuggerNonUserCode] get
      {
        return this._pnlTitleDateTime;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pnlTitleDateTime = value;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual DateTimePicker DTPicker
    {
      [DebuggerNonUserCode] get
      {
        return this._DTPicker;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._DTPicker = value;
      }
    }

    internal virtual ComboBox cbxTitle
    {
      [DebuggerNonUserCode] get
      {
        return this._cbxTitle;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cbxTitle = value;
      }
    }

    internal virtual Label lblRemark
    {
      [DebuggerNonUserCode] get
      {
        return this._lblRemark;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblRemark = value;
      }
    }

    internal virtual TextBox txtRemark
    {
      [DebuggerNonUserCode] get
      {
        return this._txtRemark;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtRemark = value;
      }
    }

    public string InstanceDataID
    {
      get
      {
        return this._InstanceDataID;
      }
      set
      {
        this._InstanceDataID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("InstanceDataID", value, true));
        this.Init();
      }
    }

    public override string HappenDateTime
    {
      get
      {
        return this.DTPicker.Value.ToString("yyyy-M-d") + "^" + this.DTPicker.Value.ToString("H:mm:ss");
      }
    }

    public string EPRNum
    {
      set
      {
        this._EPRNum = value;
      }
    }

    public string EPRListTitle
    {
      get
      {
        return this.cbxTitle.Text;
      }
    }

    public EPRList()
    {
      this.Load += new EventHandler(this.EPRList_Load);
      this.m_AllowNonStandardTitle = true;
      this.m_DiagnosTypeByTitle = new EDiagnosTypeByTitle();
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
      this.pnlTitleDateTime = new Panel();
      this.txtRemark = new TextBox();
      this.lblRemark = new Label();
      this.cbxTitle = new ComboBox();
      this.DTPicker = new DateTimePicker();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.BottomPanel.SuspendLayout();
      this.pnlTitleDateTime.SuspendLayout();
      this.SuspendLayout();
      Panel bottomPanel = this.BottomPanel;
      Point point1 = new Point(0, 208);
      Point point2 = point1;
      bottomPanel.Location = point2;
      Button btnTemplate = this.btnTemplate;
      point1 = new Point(304, 5);
      Point point3 = point1;
      btnTemplate.Location = point3;
      this.btnPrint.Anchor = AnchorStyles.Right;
      this.btnPrint.Enabled = false;
      Button btnPrint = this.btnPrint;
      point1 = new Point(616, 4);
      Point point4 = point1;
      btnPrint.Location = point4;
      this.btnPrint.Visible = false;
      Panel mainPanel = this.MainPanel;
      Size size1 = new Size(800, 176);
      Size size2 = size1;
      mainPanel.Size = size2;
      Button btnRefresh = this.btnRefresh;
      point1 = new Point(208, 5);
      Point point5 = point1;
      btnRefresh.Location = point5;
      Button btnCommit = this.btnCommit;
      point1 = new Point(112, 5);
      Point point6 = point1;
      btnCommit.Location = point6;
      this.btnSave.Anchor = AnchorStyles.Left;
      this.pnlTitleDateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.pnlTitleDateTime.BorderStyle = BorderStyle.Fixed3D;
      this.pnlTitleDateTime.Controls.Add((Control) this.txtRemark);
      this.pnlTitleDateTime.Controls.Add((Control) this.lblRemark);
      this.pnlTitleDateTime.Controls.Add((Control) this.cbxTitle);
      this.pnlTitleDateTime.Controls.Add((Control) this.DTPicker);
      this.pnlTitleDateTime.Controls.Add((Control) this.Label2);
      this.pnlTitleDateTime.Controls.Add((Control) this.Label1);
      Panel pnlTitleDateTime1 = this.pnlTitleDateTime;
      point1 = new Point(4, 176);
      Point point7 = point1;
      pnlTitleDateTime1.Location = point7;
      this.pnlTitleDateTime.Name = "pnlTitleDateTime";
      Panel pnlTitleDateTime2 = this.pnlTitleDateTime;
      size1 = new Size(800, 32);
      Size size3 = size1;
      pnlTitleDateTime2.Size = size3;
      this.pnlTitleDateTime.TabIndex = 2;
      this.txtRemark.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox txtRemark1 = this.txtRemark;
      point1 = new Point(552, 5);
      Point point8 = point1;
      txtRemark1.Location = point8;
      this.txtRemark.Name = "txtRemark";
      TextBox txtRemark2 = this.txtRemark;
      size1 = new Size(236, 21);
      Size size4 = size1;
      txtRemark2.Size = size4;
      this.txtRemark.TabIndex = 8;
      Label lblRemark1 = this.lblRemark;
      point1 = new Point(512, 8);
      Point point9 = point1;
      lblRemark1.Location = point9;
      this.lblRemark.Name = "lblRemark";
      Label lblRemark2 = this.lblRemark;
      size1 = new Size(32, 16);
      Size size5 = size1;
      lblRemark2.Size = size5;
      this.lblRemark.TabIndex = 7;
      this.lblRemark.Text = "备注";
      ComboBox cbxTitle1 = this.cbxTitle;
      point1 = new Point(56, 5);
      Point point10 = point1;
      cbxTitle1.Location = point10;
      this.cbxTitle.Name = "cbxTitle";
      ComboBox cbxTitle2 = this.cbxTitle;
      size1 = new Size(208, 20);
      Size size6 = size1;
      cbxTitle2.Size = size6;
      this.cbxTitle.TabIndex = 6;
      this.DTPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
      this.DTPicker.Format = DateTimePickerFormat.Custom;
      DateTimePicker dtPicker1 = this.DTPicker;
      point1 = new Point(352, 5);
      Point point11 = point1;
      dtPicker1.Location = point11;
      this.DTPicker.MinDate = new DateTime(1840, 12, 31, 0, 0, 0, 0);
      this.DTPicker.Name = "DTPicker";
      DateTimePicker dtPicker2 = this.DTPicker;
      size1 = new Size(152, 21);
      Size size7 = size1;
      dtPicker2.Size = size7;
      this.DTPicker.TabIndex = 5;
      Label label2_1 = this.Label2;
      point1 = new Point(288, 9);
      Point point12 = point1;
      label2_1.Location = point12;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(64, 16);
      Size size8 = size1;
      label2_2.Size = size8;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "发生时间";
      Label label1_1 = this.Label1;
      point1 = new Point(16, 9);
      Point point13 = point1;
      label1_1.Location = point13;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(32, 16);
      Size size9 = size1;
      label1_2.Size = size9;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "标题";
      this.Controls.Add((Control) this.pnlTitleDateTime);
      this.Name = "EPRList";
      size1 = new Size(800, 264);
      this.Size = size1;
      this.Controls.SetChildIndex((Control) this.pnlTitleDateTime, 0);
      this.Controls.SetChildIndex((Control) this.BottomPanel, 0);
      this.Controls.SetChildIndex((Control) this.MainPanel, 0);
      this.BottomPanel.ResumeLayout(false);
      this.pnlTitleDateTime.ResumeLayout(false);
      this.pnlTitleDateTime.PerformLayout();
      this.ResumeLayout(false);
    }

    protected override void InitCheckProperties()
    {
      if (!this.m_isIsTotalLoadSet)
        return;
      if (this.m_IsTotalLoad)
      {
        this.CheckDllProperties.Add((object) "BGColor");
        this.CheckDllProperties.Add((object) "Browsable");
        this.CheckDllProperties.Add((object) "CategoryID");
        this.CheckDllProperties.Add((object) "CategoryType");
        this.CheckDllProperties.Add((object) "ChartItemID");
        this.CheckDllProperties.Add((object) "ChartItemType");
        this.CheckDllProperties.Add((object) "ChartListNo");
        this.CheckDllProperties.Add((object) "CTLocID");
        this.CheckDllProperties.Add((object) "EpisodeID");
        this.CheckDllProperties.Add((object) "IsNewFramework");
        this.CheckDllProperties.Add((object) "PatientID");
        this.CheckDllProperties.Add((object) "ProfileID");
        this.CheckDllProperties.Add((object) "Revisionable");
        this.CheckDllProperties.Add((object) "SSGroupID");
        this.CheckDllProperties.Add((object) "TemplateID");
        this.CheckDllProperties.Add((object) "TemplateName");
        this.CheckDllProperties.Add((object) "UserID");
        this.CheckDllProperties.Add((object) "UserName");
        this.CheckDllProperties.Add((object) "InstanceDataID");
      }
      else
      {
        this.CheckDllProperties.Add((object) "BGColor");
        this.CheckDllProperties.Add((object) "Browsable");
        this.CheckDllProperties.Add((object) "CategoryID");
        this.CheckDllProperties.Add((object) "CTLocID");
        this.CheckDllProperties.Add((object) "EpisodeID");
        this.CheckDllProperties.Add((object) "PatientID");
        this.CheckDllProperties.Add((object) "InstanceDataID");
        this.CheckDllProperties.Add((object) "IsNewFramework");
        this.CheckDllProperties.Add((object) "Revisionable");
        this.CheckDllProperties.Add((object) "SSGroupID");
        this.CheckDllProperties.Add((object) "UserID");
        this.CheckDllProperties.Add((object) "UserName");
      }
    }

    protected override void Init()
    {
      if (!this.IsAllPropertiesSet())
        return;
      this.InitSysConfig();
      this.GetDiagnosType();
      this.PreInitContent();
      this.InitContentByID();
      this.AfterInitContent();
      this.InitListTitleAndTime();
    }

    protected override void InitContent()
    {
      this.CurrentPInterface = new PInterface();
      ((Control) this.CurrentPInterface).Dock = DockStyle.Fill;
      this.MainPanel.Controls.Add((Control) this.CurrentPInterface);
      try
      {
        if (this._InstanceDataID == null || this._InstanceDataID.Equals(string.Empty))
        {
          if (this.m_PatientID == null || this.m_PatientID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数PatientID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_EpisodeID == null || this.m_EpisodeID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数EpisodeID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_ProfileID == null || this.m_ProfileID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数ProfileID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_ChartItemType == null || this.m_ChartItemType.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数ChartItemType，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_ChartListNo == null || this.m_ChartListNo.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数ChartListNo，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_TemplateID == null || this.m_TemplateID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数TemplateID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_CategoryID == null || this.m_CategoryID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数CategoryID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          if (this.m_CategoryType == null || this.m_CategoryType.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数CategoryType，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          this.CurrentEInstanceData = WebServiceLayer.InstanceAccess.GetMultipleData(this.m_PatientID, this.m_EpisodeID, this.m_ProfileID, this.m_ChartItemType, this.m_ChartListNo, this.m_TemplateID, this.m_CategoryID, this.m_CategoryType);
          this.isNew = true;
        }
        else
        {
          if (this._InstanceDataID == null || this._InstanceDataID.Equals(string.Empty))
          {
            int num = (int) Interaction.MsgBox((object) "缺少参数InstanceDataID，无法加载模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          this.CurrentEInstanceData = WebServiceLayer.InstanceAccess.GetDataByID(this._InstanceDataID);
          this.isNew = false;
        }
        EInstanceData currentEinstanceData = this.CurrentEInstanceData;
        PInterface currentPinterface = this.CurrentPInterface;
        this.InitialTemplate(currentEinstanceData, ref currentPinterface);
        this.CurrentPInterface = currentPinterface;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("病历内容调入失败。\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void InitContentByID()
    {
      this.InitContent();
    }

    protected override void InitSysConfig()
    {
      base.InitSysConfig();
      QualityCheck.QualityCtrlParam = SysOptionManager.GetSysOptionValue("MultiQualityCtrl", string.Empty);
    }

    protected override void AfterInitContent()
    {
      base.AfterInitContent();
      if (!this.IsNewFramework)
        return;
      this.pnlTitleDateTime.Dock = DockStyle.Bottom;
      this.MainPanel.Dock = DockStyle.Fill;
    }

    private void GetDiagnosType()
    {
      this.m_DiagnosTypeByTitle = WebServiceLayer.CustomDictoryAccess.GetAllDiagnosTypeByTitle();
    }

    protected override bool Save(bool isAutoSave = false, string action = "Save")
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.cbxTitle.Text), string.Empty, false) == 0)
      {
        int num = (int) MessageBox.Show("标题不能为空！");
        return false;
      }
      if (!WebServiceLayer.InstanceAccess.CheckHappenDateTimeValid(this.CurrentEInstanceData.TheECRecord, this.CurrentEInstanceData.ID, this.DTPicker.Value.ToString("yyyy-M-d"), this.DTPicker.Value.ToString("H:mm:ss")).Equals("1"))
      {
        int num = (int) Interaction.MsgBox((object) "输入的日期时间与已有病历重复，请修改。", MsgBoxStyle.OkOnly, (object) null);
        this.DTPicker.Focus();
        return false;
      }
      bool flag = base.Save(isAutoSave, action);
      this._InstanceDataID = this.CurrentEInstanceData.ID;
      return flag;
    }

    protected override EInstanceData SaveEPR(bool isAutoSave, string action)
    {
      try
      {
        this.ModifyListTitleAndTime();
        string AErrorMessage = "";
        EMixInstanceLog emixInstanceLog = this.CreateEMixInstanceLog(action);
        EInstanceData einstanceData = WebServiceLayer.InstanceAccess.SaveMultipleData(this.CurrentEInstanceData, ref emixInstanceLog, ref AErrorMessage);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(AErrorMessage, "", false) != 0)
          throw new Exception(AErrorMessage);
        this.CurrentEMixInstanceLog = emixInstanceLog;
        if (einstanceData != null)
          this.isNew = false;
        return einstanceData;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        throw new Exception(exception.Message + "\r\n" + exception.StackTrace);
      }
    }

    private void EPRList_Load(object sender, EventArgs e)
    {
    }

    protected override string OperLog(string parAction)
    {
      this.EPRNum = this.CurrentEInstanceData.ListNo;
      this.GetOperTplID(parAction);
      return LogManagement.MulitOperLog(this.HappenDateTime, parAction, this.m_EpisodeID, this.m_PrnTemplateDocID, this._EPRNum, this.m_UserID, this.TemplateID);
    }

    protected override bool CanBrowse(string parInstanceID)
    {
      if (this.isNew)
        return true;
      return base.CanBrowse(parInstanceID);
    }

    protected override void GetButtonPriv(string parInstanceID)
    {
      base.GetButtonPriv(parInstanceID);
      if (!this.isNew)
        return;
      this.btnTemplate.Enabled = false;
    }

    private void InitListTitleAndTime()
    {
      try
      {
        this.DTPicker.Value = Convert.ToDateTime(Conversions.ToString(this.CurrentEInstanceData.HappenDate) + " " + Conversions.ToString(this.CurrentEInstanceData.HappenTime));
        string sysOptionValue1 = SysOptionManager.GetSysOptionValue("ListTitleEditable", "NULL");
        if (sysOptionValue1 != null && sysOptionValue1.ToUpper().Equals("Y"))
        {
          this.cbxTitle.Enabled = true;
          this.InitTitleChoiceList();
        }
        else
        {
          this.cbxTitle.DropDownStyle = ComboBoxStyle.Simple;
          this.cbxTitle.TextChanged += new EventHandler(this.cbxTitle_TextChanged);
          if (this.isNew)
            this.cbxTitle.Text = this.CurrentEInstanceData.Title;
          this.cbxTitle.Enabled = false;
        }
        if (!this.isNew)
          this.cbxTitle.Text = this.CurrentEInstanceData.Title;
        string sysOptionValue2 = SysOptionManager.GetSysOptionValue("ListTimeEditable", "NULL");
        string str1 = "N";
        string str2 = "N";
        if (sysOptionValue2 != null)
        {
          str1 = sysOptionValue2.Substring(0, 1).ToUpper();
          if (sysOptionValue2.Length == 3)
            str2 = sysOptionValue2.Substring(2, 1).ToUpper();
        }
        if (((str1.Equals("Y") ? 1 : 0) & (this.isNew || str2.Equals("Y") ? 1 : 0)) != 0)
          this.DTPicker.Enabled = true;
        else
          this.DTPicker.Enabled = false;
        this.txtRemark.Text = this.CurrentEInstanceData.Remark;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage("设置历次病历标题和发生时间错误!" + exception.Message + "\r\n" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
    }

    private void ModifyListTitleAndTime()
    {
      if (this.cbxTitle.Enabled && !this.cbxTitle.Text.Equals(string.Empty))
        this.CurrentEInstanceData.Title = this.cbxTitle.Text;
      if (this.DTPicker.Enabled && this.DTPicker.Checked)
      {
        this.CurrentEInstanceData.HappenDate = Conversions.ToDate(this.DTPicker.Value.ToString("yyyy-M-d"));
        this.CurrentEInstanceData.HappenTime = Conversions.ToDate(this.DTPicker.Value.ToString("H:mm:ss"));
      }
      this.CurrentEInstanceData.Remark = this.txtRemark.Text;
    }

    private void InitTitleChoiceList()
    {
      string titleByTid = WebServiceLayer.CustomDictoryAccess.GetTitleBYTid(this.CurrentEInstanceData.TemplateID);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(titleByTid, string.Empty, false) != 0)
      {
        string str = titleByTid.Split('$')[0];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str.ToUpper(), "Y", false) == 0)
          this.m_AllowNonStandardTitle = false;
        this.m_TitleList = titleByTid.Substring(checked (str.Length + 1)).Split('$');
      }
      if (this.m_AllowNonStandardTitle)
      {
        this.cbxTitle.DropDownStyle = ComboBoxStyle.DropDown;
        this.cbxTitle.TextChanged += new EventHandler(this.cbxTitle_TextChanged);
      }
      else
      {
        this.cbxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cbxTitle.SelectedIndexChanged += new EventHandler(this.cbxTitle_SelectedIndexChanged);
      }
      if (this.m_TitleList == null)
      {
        this.cbxTitle.DropDownStyle = ComboBoxStyle.Simple;
        this.cbxTitle.Text = this.CurrentEInstanceData.Title;
      }
      else
      {
        string[] titleList = this.m_TitleList;
        int index1 = 0;
        while (index1 < titleList.Length)
        {
          this.cbxTitle.Items.Add((object) titleList[index1].Split('-')[0]);
          checked { ++index1; }
        }
        if (this.isNew)
        {
          string[] strArray = this.m_TitleList[0].Split('-');
          if (strArray.Length == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[2].ToUpper(), "Y", false) == 0)
          {
            this.cbxTitle.Text = strArray[0];
            this.cbxTitle.SelectedIndex = 0;
          }
        }
        else
        {
          int num1 = 0;
          int num2 = checked (this.cbxTitle.Items.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(this.cbxTitle.Items[index2])), this.cbxTitle.Text, false) == 0)
              this.cbxTitle.SelectedIndex = index2;
            checked { ++index2; }
          }
        }
        this.cbxTitle.KeyUp += new KeyEventHandler(this.cbxTitle_KeyUp);
        if (!this.isNew)
          return;
        PInterface currentPinterface = this.CurrentPInterface;
        EPRList eprList = this;
        // ISSUE: virtual method pointer
        IntPtr num = __vmethodptr(eprList, InitMultipleTitleByKB);
        PInterface.SetEPRListTitleHandler listTitleHandler = new PInterface.SetEPRListTitleHandler((object) eprList, num);
        currentPinterface.add_OnKBNodeUpdate(listTitleHandler);
      }
    }

    private void cbxTitle_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cbxTitle.Items.Clear();
      int num1 = 0;
      int num2 = checked (this.m_TitleList.Length - 1);
      int index = num1;
      while (index <= num2)
      {
        string title = this.m_TitleList[index];
        if (title.IndexOf(this.cbxTitle.Text) != -1)
          this.cbxTitle.Items.Add((object) title.Split('-')[0]);
        checked { ++index; }
      }
      if (this.cbxTitle.Items.Count <= 0)
        return;
      this.cbxTitle.DroppedDown = true;
    }

    private void cbxTitle_Leave(object sender, EventArgs e)
    {
    }

    private void ChangeDiagnosType()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbxTitle.Text.Trim(), string.Empty, false) == 0)
        return;
      string typeByTitle = this.GetTypeByTitle(this.cbxTitle.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(typeByTitle, string.Empty, false) == 0)
        return;
      try
      {
        foreach (Control control in ((Control) ((PMsg) this.CurrentPInterface.PMsg).PPanel).Controls)
        {
          if (control is PCTextEdit)
          {
            PCTextEdit pcTextEdit = (PCTextEdit) control;
            string empty = string.Empty;
            if (pcTextEdit.get_BindInstanceItem().get_BindMMetaItem() is MITextDesc)
              ((MITextDesc) pcTextEdit.get_BindInstanceItem().get_BindMMetaItem()).set_BindDefaultDiagnosType(typeByTitle);
            else if (pcTextEdit.get_BindInstanceItem().get_BindMMetaItem() is MISegment)
              ((MISegment) pcTextEdit.get_BindInstanceItem().get_BindMMetaItem()).set_BindDefaultDiagnosType(typeByTitle);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    public string GetTypeByTitle(string Title)
    {
      string empty = string.Empty;
      if (this.m_DiagnosTypeByTitle != null && this.m_DiagnosTypeByTitle.Tables.Count > 0)
      {
        DataRow[] dataRowArray = this.m_DiagnosTypeByTitle.Tables[0].Select("ATitleName = '" + Title + "'");
        if (dataRowArray.Length > 0)
          empty = Conversions.ToString(dataRowArray[0]["ADiagnosTypeID"]);
      }
      return empty;
    }

    private void InitMultipleTitleByKB(string title)
    {
      if (title.Trim().Length == 0)
        return;
      if (this.m_AllowNonStandardTitle)
      {
        this.cbxTitle.Text = title;
      }
      else
      {
        if (this.m_TitleList == null)
          return;
        try
        {
          foreach (object obj in this.cbxTitle.Items)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            if (!string.IsNullOrEmpty(objectValue.ToString()) && objectValue.ToString().Contains(title))
            {
              this.cbxTitle.SelectedItem = RuntimeHelpers.GetObjectValue(objectValue);
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }

    private void cbxTitle_TextChanged(object sender, EventArgs e)
    {
      this.ChangeDiagnosType();
    }

    private void cbxTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.ChangeDiagnosType();
    }
  }
}
