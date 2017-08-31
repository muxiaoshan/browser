// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.EPRBase
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.databind;
using dhcc.epr.eprlib.design.printreview;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using dhcc.epr.webclient.dataaccess;
using dhcc.epr.webclient.dataexport;
using dhcc.epr.webclient.preview;
using dhcc.epr.webclient.Privilege;
using dhcc.epr.webclient.Quality;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class EPRBase : UserControl
  {
    private IContainer components;
    [AccessedThroughProperty("stBar")]
    private StatusBar _stBar;
    [AccessedThroughProperty("sbPanelAction")]
    private StatusBarPanel _sbPanelAction;
    [AccessedThroughProperty("sbPanelStatus")]
    private StatusBarPanel _sbPanelStatus;
    [AccessedThroughProperty("BottomPanel")]
    private Panel _BottomPanel;
    [AccessedThroughProperty("btnViewLogs")]
    private Button _btnViewLogs;
    [AccessedThroughProperty("btnTemplate")]
    private Button _btnTemplate;
    [AccessedThroughProperty("btnPrint")]
    private Button _btnPrint;
    [AccessedThroughProperty("MainPanel")]
    private Panel _MainPanel;
    [AccessedThroughProperty("btnRefresh")]
    private Button _btnRefresh;
    [AccessedThroughProperty("btnCommit")]
    private Button _btnCommit;
    [AccessedThroughProperty("btnSave")]
    private Button _btnSave;
    protected string m_UserID;
    protected string m_UserName;
    protected string m_UserCode;
    protected string m_SSGroupID;
    protected string m_CTLocID;
    protected string m_TemplateID;
    protected string m_TemplateName;
    protected string m_CategoryID;
    protected string m_CategoryType;
    protected string m_CategoryName;
    protected string m_ChartItemID;
    protected string m_ProfileID;
    protected string m_ChartItemType;
    protected string m_ChartListNo;
    protected string m_EpisodeID;
    protected string m_EpisodeType;
    protected string m_PatientID;
    protected string m_BGColor;
    protected EInstanceData CurrentEInstanceData;
    [AccessedThroughProperty("CurrentPInterface")]
    private PInterface _CurrentPInterface;
    protected bool isPrivAvailable;
    protected bool isCommited;
    protected string userLevel;
    protected string patientRecordStatus;
    protected bool canBeBrowsed;
    protected Hashtable priviledgeHashTable;
    protected bool isRevisionable;
    protected Hashtable commitStatusHashTable;
    protected Hashtable logHashTable;
    protected EInstanceLog CurrentEInstanceLog;
    protected EMixInstanceLog CurrentEMixInstanceLog;
    protected Timer tmrAutoSave;
    protected int minAutoSaveTime;
    protected bool m_IsNewFramework;
    protected string m_PrnTemplateDocID;
    protected string m_TemplateDocID;
    protected string m_StatusAfterSaveNewFrameWork;
    protected bool m_IsTotalLoad;
    protected string m_QualityCtrlParam;
    protected ArrayList SetDllProperties;
    protected ArrayList CheckDllProperties;
    protected bool m_isIsTotalLoadSet;
    private string[] CASignInfo;

    internal virtual StatusBar stBar
    {
      [DebuggerNonUserCode] get
      {
        return this._stBar;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stBar = value;
      }
    }

    internal virtual StatusBarPanel sbPanelAction
    {
      [DebuggerNonUserCode] get
      {
        return this._sbPanelAction;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._sbPanelAction = value;
      }
    }

    internal virtual StatusBarPanel sbPanelStatus
    {
      [DebuggerNonUserCode] get
      {
        return this._sbPanelStatus;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._sbPanelStatus = value;
      }
    }

    protected virtual Panel BottomPanel
    {
      [DebuggerNonUserCode] get
      {
        return this._BottomPanel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._BottomPanel = value;
      }
    }

    internal virtual Button btnViewLogs
    {
      [DebuggerNonUserCode] get
      {
        return this._btnViewLogs;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnViewLogs_Click);
        if (this._btnViewLogs != null)
          this._btnViewLogs.Click -= eventHandler;
        this._btnViewLogs = value;
        if (this._btnViewLogs == null)
          return;
        this._btnViewLogs.Click += eventHandler;
      }
    }

    protected virtual Button btnTemplate
    {
      [DebuggerNonUserCode] get
      {
        return this._btnTemplate;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTemplate_Click);
        if (this._btnTemplate != null)
          this._btnTemplate.Click -= eventHandler;
        this._btnTemplate = value;
        if (this._btnTemplate == null)
          return;
        this._btnTemplate.Click += eventHandler;
      }
    }

    protected virtual Button btnPrint
    {
      [DebuggerNonUserCode] get
      {
        return this._btnPrint;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
        if (this._btnPrint != null)
          this._btnPrint.Click -= eventHandler;
        this._btnPrint = value;
        if (this._btnPrint == null)
          return;
        this._btnPrint.Click += eventHandler;
      }
    }

    protected virtual Panel MainPanel
    {
      [DebuggerNonUserCode] get
      {
        return this._MainPanel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainPanel = value;
      }
    }

    protected virtual Button btnRefresh
    {
      [DebuggerNonUserCode] get
      {
        return this._btnRefresh;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnRefresh_Click);
        if (this._btnRefresh != null)
          this._btnRefresh.Click -= eventHandler;
        this._btnRefresh = value;
        if (this._btnRefresh == null)
          return;
        this._btnRefresh.Click += eventHandler;
      }
    }

    protected virtual Button btnCommit
    {
      [DebuggerNonUserCode] get
      {
        return this._btnCommit;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCommit_Click);
        if (this._btnCommit != null)
          this._btnCommit.Click -= eventHandler;
        this._btnCommit = value;
        if (this._btnCommit == null)
          return;
        this._btnCommit.Click += eventHandler;
      }
    }

    protected virtual Button btnSave
    {
      [DebuggerNonUserCode] get
      {
        return this._btnSave;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSave_Click);
        if (this._btnSave != null)
          this._btnSave.Click -= eventHandler;
        this._btnSave = value;
        if (this._btnSave == null)
          return;
        this._btnSave.Click += eventHandler;
      }
    }

    protected virtual PInterface CurrentPInterface
    {
      [DebuggerNonUserCode] get
      {
        return this._CurrentPInterface;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._CurrentPInterface = value;
      }
    }

    public string UserID
    {
      get
      {
        return this.m_UserID;
      }
      set
      {
        this.m_UserID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("UserID", value, true));
        this.Init();
      }
    }

    public string UserName
    {
      get
      {
        return this.m_UserName;
      }
      set
      {
        this.m_UserName = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("UserName", value, true));
        this.Init();
      }
    }

    public string TemplateID
    {
      get
      {
        return this.m_TemplateID;
      }
      set
      {
        this.m_TemplateID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("TemplateID", value, false));
        this.Init();
      }
    }

    public string TemplateName
    {
      get
      {
        return this.m_TemplateName;
      }
      set
      {
        this.m_TemplateName = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("TemplateName", value, false));
        this.Init();
      }
    }

    public string CategoryID
    {
      get
      {
        return this.m_CategoryID;
      }
      set
      {
        this.m_CategoryID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("CategoryID", value, true));
        this.Init();
      }
    }

    public string CategoryName
    {
      get
      {
        return this.m_CategoryName;
      }
      set
      {
        this.m_CategoryName = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("CategoryName", value, false));
        this.Init();
      }
    }

    public string CategoryType
    {
      get
      {
        return this.m_CategoryType;
      }
      set
      {
        this.m_CategoryType = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("CategoryType", value, false));
        this.Init();
      }
    }

    public string ChartItemID
    {
      get
      {
        return this.m_ChartItemID;
      }
      set
      {
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("ChartItemID", value, false));
        this.Init();
      }
    }

    public string ProfileID
    {
      get
      {
        return this.m_ProfileID;
      }
      set
      {
        this.m_ProfileID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("ProfileID", value, true));
        this.Init();
      }
    }

    public string ChartItemType
    {
      get
      {
        return this.m_ChartItemType;
      }
      set
      {
        this.m_ChartItemType = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("ChartItemType", value, false));
        this.Init();
      }
    }

    public string PatientID
    {
      get
      {
        return this.m_PatientID;
      }
      set
      {
        this.m_PatientID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("PatientID", value, true));
        this.Init();
      }
    }

    public string EpisodeID
    {
      get
      {
        return this.m_EpisodeID;
      }
      set
      {
        this.m_EpisodeID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("EpisodeID", value, true));
        this.Init();
      }
    }

    public string EpisodeType
    {
      get
      {
        return this.m_EpisodeType;
      }
      set
      {
        this.m_EpisodeType = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("EpisodeType", value, false));
        this.Init();
      }
    }

    public string BGColor
    {
      get
      {
        return this.m_BGColor;
      }
      set
      {
        this.m_BGColor = value;
        if (new Regex("^#[0-9a-fA-F]{6}$", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace).IsMatch(this.m_BGColor))
        {
          this.BackColor = Color.FromArgb(Convert.ToInt32(this.m_BGColor.Substring(0, 2), 16), Convert.ToInt32(this.m_BGColor.Substring(2, 2), 16), Convert.ToInt32(this.m_BGColor.Substring(4, 2), 16));
          this.BottomPanel.BackColor = this.BackColor;
          this.MainPanel.BackColor = this.BackColor;
        }
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("BGColor", value, false));
        this.Init();
      }
    }

    public string SSGroupID
    {
      get
      {
        return this.m_SSGroupID;
      }
      set
      {
        this.m_SSGroupID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("SSGroupID", value, true));
        this.Init();
      }
    }

    public string CTLocID
    {
      get
      {
        return this.m_CTLocID;
      }
      set
      {
        this.m_CTLocID = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("CTLocID", value, true));
        this.Init();
      }
    }

    public string ChartListNo
    {
      get
      {
        return this.m_ChartListNo;
      }
      set
      {
        this.m_ChartListNo = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("ChartListNo", value, true));
        this.Init();
      }
    }

    public bool Revisionable
    {
      get
      {
        return this.isRevisionable;
      }
      set
      {
        this.isRevisionable = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("Revisionable", Conversions.ToString(value), false));
        this.Init();
      }
    }

    public bool Browsable
    {
      get
      {
        return this.canBeBrowsed;
      }
      set
      {
        this.canBeBrowsed = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("Browsable", Conversions.ToString(value), false));
        this.Init();
      }
    }

    public virtual string HappenDateTime
    {
      get
      {
        return DateAndTime.Now.ToString("yyyy-M-d") + "^" + DateAndTime.Now.ToString("H:mm:ss");
      }
    }

    public bool IsNewFramework
    {
      get
      {
        return this.m_IsNewFramework;
      }
      set
      {
        this.m_IsNewFramework = value;
        this.SetDllProperties.Add((object) new EPRBase.DllProperty("IsNewFramework", Conversions.ToString(value), false));
        this.Init();
      }
    }

    public string PrnTemplateDocID
    {
      get
      {
        return this.m_PrnTemplateDocID;
      }
      set
      {
        this.m_PrnTemplateDocID = value;
      }
    }

    public string TemplateDocID
    {
      set
      {
        this.m_TemplateDocID = value;
      }
    }

    public string StatusAfterSaveNewFrameWork
    {
      get
      {
        return this.m_StatusAfterSaveNewFrameWork;
      }
    }

    public bool IsTotalLoad
    {
      get
      {
        return this.m_isIsTotalLoadSet;
      }
      set
      {
        this.m_IsTotalLoad = value;
        this.m_isIsTotalLoadSet = true;
        this.Init();
      }
    }

    public string CurInstanceDataID
    {
      get
      {
        if (this.CurrentEInstanceData != null)
          return this.CurrentEInstanceData.ID;
        return "";
      }
    }

    public EPRBase()
    {
      this.isCommited = false;
      this.isRevisionable = false;
      this.CurrentEMixInstanceLog = new EMixInstanceLog();
      this.tmrAutoSave = (Timer) null;
      this.minAutoSaveTime = 60;
      this.m_IsNewFramework = false;
      this.SetDllProperties = new ArrayList();
      this.CheckDllProperties = new ArrayList();
      this.CASignInfo = new string[7];
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.components != null)
          this.components.Dispose();
        if (this.tmrAutoSave != null)
          this.tmrAutoSave.Dispose();
      }
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.BottomPanel = new Panel();
      this.btnViewLogs = new Button();
      this.stBar = new StatusBar();
      this.sbPanelAction = new StatusBarPanel();
      this.sbPanelStatus = new StatusBarPanel();
      this.btnCommit = new Button();
      this.btnTemplate = new Button();
      this.btnRefresh = new Button();
      this.btnPrint = new Button();
      this.btnSave = new Button();
      this.MainPanel = new Panel();
      this.BottomPanel.SuspendLayout();
      this.sbPanelAction.BeginInit();
      this.sbPanelStatus.BeginInit();
      this.SuspendLayout();
      this.BottomPanel.Controls.Add((Control) this.btnViewLogs);
      this.BottomPanel.Controls.Add((Control) this.stBar);
      this.BottomPanel.Controls.Add((Control) this.btnCommit);
      this.BottomPanel.Controls.Add((Control) this.btnTemplate);
      this.BottomPanel.Controls.Add((Control) this.btnRefresh);
      this.BottomPanel.Controls.Add((Control) this.btnPrint);
      this.BottomPanel.Controls.Add((Control) this.btnSave);
      this.BottomPanel.Dock = DockStyle.Bottom;
      Panel bottomPanel1 = this.BottomPanel;
      Point point1 = new Point(0, 544);
      Point point2 = point1;
      bottomPanel1.Location = point2;
      this.BottomPanel.Name = "BottomPanel";
      Panel bottomPanel2 = this.BottomPanel;
      Size size1 = new Size(800, 56);
      Size size2 = size1;
      bottomPanel2.Size = size2;
      this.BottomPanel.TabIndex = 0;
      this.btnViewLogs.BackColor = Color.FromArgb(49, 101, 156);
      this.btnViewLogs.FlatStyle = FlatStyle.Flat;
      this.btnViewLogs.ForeColor = SystemColors.ControlLightLight;
      Button btnViewLogs1 = this.btnViewLogs;
      point1 = new Point(712, 4);
      Point point3 = point1;
      btnViewLogs1.Location = point3;
      this.btnViewLogs.Name = "btnViewLogs";
      Button btnViewLogs2 = this.btnViewLogs;
      size1 = new Size(84, 24);
      Size size3 = size1;
      btnViewLogs2.Size = size3;
      this.btnViewLogs.TabIndex = 7;
      this.btnViewLogs.Text = "查看日志";
      this.btnViewLogs.Visible = false;
      this.stBar.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      StatusBar stBar1 = this.stBar;
      point1 = new Point(0, 36);
      Point point4 = point1;
      stBar1.Location = point4;
      this.stBar.Name = "stBar";
      this.stBar.Panels.AddRange(new StatusBarPanel[2]
      {
        this.sbPanelAction,
        this.sbPanelStatus
      });
      this.stBar.ShowPanels = true;
      StatusBar stBar2 = this.stBar;
      size1 = new Size(800, 20);
      Size size4 = size1;
      stBar2.Size = size4;
      this.stBar.TabIndex = 6;
      this.sbPanelAction.BorderStyle = StatusBarPanelBorderStyle.None;
      this.sbPanelAction.Text = "电子病历";
      this.sbPanelAction.Width = 490;
      this.sbPanelStatus.AutoSize = StatusBarPanelAutoSize.Spring;
      this.sbPanelStatus.BorderStyle = StatusBarPanelBorderStyle.None;
      this.sbPanelStatus.Width = 294;
      this.btnCommit.BackColor = Color.FromArgb(49, 101, 156);
      this.btnCommit.FlatStyle = FlatStyle.Flat;
      this.btnCommit.ForeColor = SystemColors.ControlLightLight;
      Button btnCommit1 = this.btnCommit;
      point1 = new Point(208, 5);
      Point point5 = point1;
      btnCommit1.Location = point5;
      this.btnCommit.Name = "btnCommit";
      Button btnCommit2 = this.btnCommit;
      size1 = new Size(84, 24);
      Size size5 = size1;
      btnCommit2.Size = size5;
      this.btnCommit.TabIndex = 5;
      this.btnCommit.Text = "提交";
      this.btnTemplate.BackColor = Color.FromArgb(49, 101, 156);
      this.btnTemplate.FlatStyle = FlatStyle.Flat;
      this.btnTemplate.ForeColor = SystemColors.ControlLightLight;
      Button btnTemplate1 = this.btnTemplate;
      point1 = new Point(400, 5);
      Point point6 = point1;
      btnTemplate1.Location = point6;
      this.btnTemplate.Name = "btnTemplate";
      Button btnTemplate2 = this.btnTemplate;
      size1 = new Size(84, 24);
      Size size6 = size1;
      btnTemplate2.Size = size6;
      this.btnTemplate.TabIndex = 3;
      this.btnTemplate.Text = "选择模板...";
      this.btnRefresh.BackColor = Color.FromArgb(49, 101, 156);
      this.btnRefresh.FlatStyle = FlatStyle.Flat;
      this.btnRefresh.ForeColor = SystemColors.ControlLightLight;
      Button btnRefresh1 = this.btnRefresh;
      point1 = new Point(304, 5);
      Point point7 = point1;
      btnRefresh1.Location = point7;
      this.btnRefresh.Name = "btnRefresh";
      Button btnRefresh2 = this.btnRefresh;
      size1 = new Size(84, 24);
      Size size7 = size1;
      btnRefresh2.Size = size7;
      this.btnRefresh.TabIndex = 2;
      this.btnRefresh.Text = "更新数据";
      this.btnPrint.BackColor = Color.FromArgb(49, 101, 156);
      this.btnPrint.FlatStyle = FlatStyle.Flat;
      this.btnPrint.ForeColor = SystemColors.ControlLightLight;
      Button btnPrint1 = this.btnPrint;
      point1 = new Point(112, 5);
      Point point8 = point1;
      btnPrint1.Location = point8;
      this.btnPrint.Name = "btnPrint";
      Button btnPrint2 = this.btnPrint;
      size1 = new Size(84, 24);
      Size size8 = size1;
      btnPrint2.Size = size8;
      this.btnPrint.TabIndex = 1;
      this.btnPrint.Text = "打印 ...";
      this.btnSave.BackColor = Color.FromArgb(49, 101, 156);
      this.btnSave.FlatStyle = FlatStyle.Flat;
      this.btnSave.ForeColor = SystemColors.ControlLightLight;
      Button btnSave1 = this.btnSave;
      point1 = new Point(16, 5);
      Point point9 = point1;
      btnSave1.Location = point9;
      this.btnSave.Name = "btnSave";
      Button btnSave2 = this.btnSave;
      size1 = new Size(84, 24);
      Size size9 = size1;
      btnSave2.Size = size9;
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "保存";
      this.MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Panel mainPanel1 = this.MainPanel;
      point1 = new Point(0, 0);
      Point point10 = point1;
      mainPanel1.Location = point10;
      this.MainPanel.Name = "MainPanel";
      Panel mainPanel2 = this.MainPanel;
      size1 = new Size(800, 544);
      Size size10 = size1;
      mainPanel2.Size = size10;
      this.MainPanel.TabIndex = 1;
      this.BackColor = SystemColors.Control;
      this.Controls.Add((Control) this.MainPanel);
      this.Controls.Add((Control) this.BottomPanel);
      this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.Name = "EPRBase";
      size1 = new Size(800, 600);
      this.Size = size1;
      this.BottomPanel.ResumeLayout(false);
      this.sbPanelAction.EndInit();
      this.sbPanelStatus.EndInit();
      this.ResumeLayout(false);
    }

    protected virtual void InitCheckProperties()
    {
      if (!this.m_isIsTotalLoadSet)
        return;
      if (this.m_IsTotalLoad)
      {
        this.CheckDllProperties.Add((object) "BGColor");
        this.CheckDllProperties.Add((object) "Browsable");
        this.CheckDllProperties.Add((object) "CategoryID");
        this.CheckDllProperties.Add((object) "CategoryName");
        this.CheckDllProperties.Add((object) "CategoryType");
        this.CheckDllProperties.Add((object) "ChartItemID");
        this.CheckDllProperties.Add((object) "ChartItemType");
        this.CheckDllProperties.Add((object) "ChartListNo");
        this.CheckDllProperties.Add((object) "CTLocID");
        this.CheckDllProperties.Add((object) "EpisodeID");
        this.CheckDllProperties.Add((object) "EpisodeType");
        this.CheckDllProperties.Add((object) "IsNewFramework");
        this.CheckDllProperties.Add((object) "PatientID");
        this.CheckDllProperties.Add((object) "ProfileID");
        this.CheckDllProperties.Add((object) "Revisionable");
        this.CheckDllProperties.Add((object) "SSGroupID");
        this.CheckDllProperties.Add((object) "UserID");
        this.CheckDllProperties.Add((object) "UserName");
      }
      else
      {
        this.CheckDllProperties.Add((object) "ChartItemID");
        this.CheckDllProperties.Add((object) "ProfileID");
        this.CheckDllProperties.Add((object) "Browsable");
        this.CheckDllProperties.Add((object) "Revisionable");
      }
    }

    protected bool IsAllPropertiesSet()
    {
      if (this.CheckDllProperties.Count <= 0)
        this.InitCheckProperties();
      return this.SetDllProperties.Count.Equals(this.CheckDllProperties.Count);
    }

    protected virtual void ClearProperties()
    {
      this.SetDllProperties.Clear();
    }

    protected virtual void Init()
    {
    }

    protected virtual void InitContent()
    {
    }

    protected void InitialTemplate(EInstanceData objEInstanceData, ref PInterface objPInterface)
    {
      LogManager.WriteLog("操作权限检查", true);
      if (!this.IsNewFramework)
        this.Browsable = this.CanBrowse(objEInstanceData.ID);
      if (!this.Browsable)
      {
        this.SetPanelInvalid("没有权限查看当前病历!");
      }
      else
      {
        LogManager.WriteLog("End操作权限检查", true);
        if (objEInstanceData.MetaData == null | Operators.CompareString(objEInstanceData.MetaData, "", false) == 0)
        {
          this.btnSave.Enabled = false;
          this.btnRefresh.Enabled = false;
        }
        else
        {
          if (objEInstanceData.InstanceData == null | Operators.CompareString(objEInstanceData.InstanceData, "", false) == 0)
          {
            this.SetPanelInvalid("当前模板实例数据为空");
            throw new Exception("当前模板实例数据为空");
          }
          LogManager.WriteLog("反序列化Meta、Instance并同步", true);
          MMetaData mmetaData = new MMetaData();
          ((MMetaItem) mmetaData).set_XMLString(objEInstanceData.MetaData);
          NInstanceData ninstanceData = new NInstanceData();
          ((NInstanceItem) ninstanceData).set_XMLString(objEInstanceData.InstanceData);
          ninstanceData.SyncMetaItem((MMetaItem) mmetaData);
          objPInterface.set_MetaData(mmetaData);
          objPInterface.set_InstanceData(ninstanceData);
          LogManager.WriteLog("End反序列化Meta、Instance并同步", true);
          PPanel.LockWindowUpdate(((Control) ((PMsg) objPInterface.PMsg).PPanel).Handle);
          ((PPanel) ((PMsg) objPInterface.PMsg).PPanel).set_InstanceStatus(objEInstanceData.Status);
          ((PPanel) ((PMsg) objPInterface.PMsg).PPanel).set_XMLString(objEInstanceData.PresentationData);
          ((Control) objPInterface).BackColor = this.BackColor;
          ((Control) ((PMsg) objPInterface.PMsg).PPanel).BackColor = this.BackColor;
          ((Control) objPInterface.PMsg).BackColor = this.BackColor;
          try
          {
            foreach (Control control in ((Control) ((PMsg) objPInterface.PMsg).PPanel).Controls)
            {
              if (control is Label | control is PCDateTime | control is PCBox | control is PCHLine | control is PCVline | control is PCMultiChoice | control is PCDictionary | control is PCPosition | control is PCQuantity)
                control.BackColor = this.BackColor;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          LogManager.WriteLog("取Trak数据", true);
          if (Operators.CompareString(objEInstanceData.Status, "UnSave", false) == 0)
          {
            try
            {
              DataBindUtil dataBindUtil = new DataBindUtil(objPInterface.get_InstanceData());
              dataBindUtil.SystemDataBind();
              dataBindUtil.EPRDataBind();
              objPInterface.BindInstance();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              MessageManager.ShowErrorMessage("数据绑定错误！！！" + exception.Message + exception.StackTrace);
              ProjectData.ClearProjectError();
            }
            this.ResetUnitEditState();
          }
          else
          {
            this.ResetUnitEditState();
            try
            {
              if (new DataSynchUtil(objPInterface.get_InstanceData()).SynchData(this.GetTemplateName()))
              {
                objPInterface.BindInstance();
                this.ShowMessageBox("数据已更新，保存后生效！", true, "");
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              MessageManager.ShowErrorMessage("数据同步错误！！！" + exception.Message + exception.StackTrace);
              ProjectData.ClearProjectError();
            }
          }
          LogManager.WriteLog("End取Trak数据", true);
          ((PPanel) ((PMsg) objPInterface.PMsg).PPanel).RunControlCalFormula();
          this.CurrentPInterface = objPInterface;
          this.InitAfterLoadContent(ref objEInstanceData);
          IntPtr num;
          PPanel.LockWindowUpdate(num);
        }
        this.InitAutoSaveTimer();
      }
    }

    protected virtual void InitSysConfig()
    {
      SysOptionManager.InitBasicSysOption();
      GlobalValues.AddKeyValue("UserName", this.m_UserName);
      if (this.IsNewFramework)
        return;
      this.userLevel = UserAuthentication.CheckUserLevel(this.m_UserID);
      QualityCheck.SSGroupID = this.SSGroupID;
      QualityCheck.CTLocID = this.CTLocID;
    }

    protected virtual void PreInitContent()
    {
      this.BottomPanel.Visible = false;
      this.stBar.Visible = false;
    }

    protected virtual void AfterInitContent()
    {
      if (this.IsNewFramework)
      {
        this.btnSave.Enabled = false;
        this.btnSave.Visible = false;
        this.btnRefresh.Enabled = false;
        this.btnRefresh.Visible = false;
        this.btnPrint.Enabled = false;
        this.btnPrint.Visible = false;
        this.btnCommit.Enabled = false;
        this.btnCommit.Visible = false;
        this.btnTemplate.Enabled = false;
        this.btnTemplate.Visible = false;
      }
      if (this.IsNewFramework && this.Browsable)
      {
        this.stBar.Height = 0;
        this.stBar.Visible = false;
        this.BottomPanel.Height = 0;
        this.BottomPanel.Visible = false;
      }
      else
      {
        this.stBar.Height = 20;
        this.stBar.Visible = true;
        this.BottomPanel.Height = 56;
        this.BottomPanel.Visible = true;
      }
      this.stBar.Enabled = !this.IsNewFramework;
      this.BottomPanel.Enabled = !this.IsNewFramework;
    }

    protected void ResetUnitEditState()
    {
      if (this.CurrentPInterface == null || this.CurrentPInterface.PMsg == null || ((PMsg) this.CurrentPInterface.PMsg).PPanel == null)
        return;
      ((PPanel) ((PMsg) this.CurrentPInterface.PMsg).PPanel).set_IsValueChanged(false);
    }

    protected bool FormulaCheck()
    {
      return ((PMsg) this.CurrentPInterface.PMsg).Check();
    }

    protected virtual bool Save(bool isAutoSave = false, string action = "Save")
    {
      string Left = "";
      if (Operators.CompareString(this.CurrentEInstanceData.Status, "UnSave", false) == 0)
        this.CurrentEInstanceData.CreateUser = this.m_UserID;
      else if (Operators.CompareString(this.CurrentEInstanceData.Status, "Save", false) == 0)
        this.CurrentEInstanceData.ModifyUser = this.m_UserID;
      this.CurrentEInstanceData.MetaData = "";
      this.CurrentEInstanceData.PresentationData = "";
      if (Operators.CompareString(this.CurrentEInstanceData.InstanceData, ((NInstanceItem) this.CurrentPInterface.get_InstanceData()).get_XMLString(), false) != 0 && !string.IsNullOrEmpty(SysOptionManager.GetSysOptionValue("CALocation", string.Empty)))
      {
        string signLogID = WebServiceLayer.DigitalSignAccess.HasValidSign(this.EpisodeID, this.PrnTemplateDocID, this.CurrentEInstanceData.ListNo);
        if (!string.IsNullOrEmpty(signLogID))
        {
          if (MsgBoxResult.Ok != Interaction.MsgBox((object) "病历已被签名。改变会导致签名失效", MsgBoxStyle.OkCancel, (object) "数字签名提示"))
            return false;
          WebServiceLayer.DigitalSignAccess.SetSignUnvalid(signLogID);
        }
      }
      this.CurrentEInstanceData.InstanceData = ((NInstanceItem) this.CurrentPInterface.get_InstanceData()).get_XMLString();
      bool flag1;
      try
      {
        if (!isAutoSave)
        {
          string lower = SysOptionManager.GetSysOptionValue("CheckFormulaBeforSave", "null").ToLower();
          if (!lower.Equals("null"))
          {
            bool flag2 = this.FormulaCheck();
            if (!flag2 && lower.Equals("control"))
            {
              int num = (int) Interaction.MsgBox((object) "公式检查未通过，不能保存。", MsgBoxStyle.Information, (object) "质控提示");
              flag1 = false;
              goto label_24;
            }
            else if (!flag2 && lower.Equals("prompt"))
              Left = "\r\n公式检查未通过。";
          }
        }
        this.CurrentEInstanceData = this.SaveEPR(isAutoSave, action);
        if (!isAutoSave && QualityCheck.OperationPass(this.CurrentEInstanceData.EpisodeID, action, this.CurrentEInstanceData.TemplateID, this.CurrentEInstanceData.ID, this.UserID) < QualityCheck.QualityChkResult.NoCheck)
          Left += "\r\n质控检查未通过。";
        this.InitAfterAction(action, this.CurrentEInstanceData.ID, this.CurrentEMixInstanceLog);
        if (!isAutoSave)
        {
          if (Operators.CompareString(Left, "", false) == 0)
            this.ShowMessageBox("保存成功。", true, "");
          else
            this.ShowMessageBox("保存成功。", true, Left.Substring(2) + "\r\n请修改后重新保存!");
        }
        this.ResetUnitEditState();
        flag1 = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage("病历保存失败。\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace);
        flag1 = false;
        ProjectData.ClearProjectError();
      }
label_24:
      return flag1;
    }

    protected virtual EInstanceData SaveEPR(bool isAutoSave, string action)
    {
      try
      {
        string AErrorMessage = "";
        EMixInstanceLog emixInstanceLog = this.CreateEMixInstanceLog(action);
        EInstanceData einstanceData = WebServiceLayer.InstanceAccess.SaveData(this.CurrentEInstanceData, ref emixInstanceLog, ref AErrorMessage);
        if (Operators.CompareString(AErrorMessage, "", false) != 0)
          throw new Exception(AErrorMessage);
        this.CurrentEMixInstanceLog = emixInstanceLog;
        return einstanceData;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        throw new Exception(exception.Message + "\r\n" + exception.StackTrace);
      }
    }

    protected void RefreshBindingData()
    {
      DataBindUtil dataBindUtil = new DataBindUtil(this.CurrentPInterface.get_InstanceData());
      dataBindUtil.SystemDataBind();
      dataBindUtil.EPRDataBind();
      this.CurrentPInterface.BindInstance();
    }

    protected bool Print(string argPrintTemplateID, string argPrintDocID)
    {
      PrintClient printClient = new PrintClient();
      bool flag1;
      try
      {
        if (QualityCheck.OperationPass(this.CurrentEInstanceData.EpisodeID, "Print", this.CurrentEInstanceData.TemplateID, string.Empty, this.UserID, argPrintDocID) == QualityCheck.QualityChkResult.ControlIllegal)
        {
          int num = (int) Interaction.MsgBox((object) "质控检查未通过，不能打印。", MsgBoxStyle.Information, (object) "质控提示");
          flag1 = false;
          goto label_10;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "未打印。", MsgBoxStyle.OkOnly, (object) null);
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_10;
      }
      bool flag2 = !this.IsNewFramework ? printClient.PrintSingle(this.m_PatientID, this.EpisodeID, this.CurrentEInstanceData.ID, this.m_UserID, this.IsNewFramework, "") : printClient.PrintSingle(this.m_PatientID, this.EpisodeID, argPrintTemplateID, this.m_UserID, this.IsNewFramework, argPrintDocID);
      if (!flag2)
        return flag2;
      if (this.IsNewFramework)
      {
        this.CurrentEMixInstanceLog.StateInfo = this.OperLog("Print");
        this.InitAfterAction("Print", this.CurrentEInstanceData.ID, this.CurrentEMixInstanceLog);
      }
      else
      {
        this.CurrentEInstanceLog = this.ChanegStatusAndAddLog("Print", this.patientRecordStatus, this.CurrentEInstanceData.ID);
        this.InitAfterAction("Print", this.CurrentEInstanceData.ID, this.CurrentEInstanceLog);
      }
      return flag2;
label_10:
      return flag1;
    }

    protected bool Commit(string argPrintTemplateID, string argPrintDocID)
    {
      bool flag;
      try
      {
        if (QualityCheck.OperationPass(this.CurrentEInstanceData.EpisodeID, "Commit", this.CurrentEInstanceData.TemplateID, this.CurrentEInstanceData.ID, this.UserID, argPrintDocID) == QualityCheck.QualityChkResult.ControlIllegal)
        {
          int num = (int) Interaction.MsgBox((object) "质控检查未通过，不能提交。", MsgBoxStyle.Information, (object) "质控提示");
          flag = false;
        }
        else if (this.IsCAOn() && !this.CASign())
        {
          flag = false;
        }
        else
        {
          if (this.IsNewFramework)
          {
            this.CurrentEMixInstanceLog.StateInfo = this.OperLog("Commit");
            this.InitAfterAction("Commit", this.CurrentEInstanceData.ID, this.CurrentEMixInstanceLog);
          }
          else
          {
            this.CurrentEInstanceLog = this.ChanegStatusAndAddLog("Commit", this.patientRecordStatus, this.CurrentEInstanceData.ID);
            this.InitAfterAction("Commit", this.CurrentEInstanceData.ID, this.CurrentEInstanceLog);
          }
          this.ShowMessageBox("提交成功！", false, "");
          this.isCommited = true;
          this.SetRevision(this.CurrentEInstanceData.ID);
          flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("提交失败。\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace), MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    protected virtual void SwitchTemplate(string parAction)
    {
      try
      {
        string ATemplateID;
        if (this.IsNewFramework)
        {
          if (parAction.Equals(string.Empty) || this.CurrentEInstanceData == null || (this.CurrentEInstanceData.ID == null || this.CurrentEInstanceData.ID.Equals(string.Empty)) || (this.CurrentEInstanceData.TemplateID == null || this.CurrentEInstanceData.TemplateID.Equals(string.Empty)))
          {
            int num = (int) Interaction.MsgBox((object) "参数不足，不能更新模板。", MsgBoxStyle.OkOnly, (object) null);
            return;
          }
          ATemplateID = this.CurrentEInstanceData.TemplateID;
        }
        else
        {
          frmChangeTemplate frmChangeTemplate = new frmChangeTemplate();
          frmChangeTemplate.BackColor = this.BackColor;
          if (this.CurrentEInstanceData.GroupItemID == null | Operators.CompareString(this.CurrentEInstanceData.GroupItemID, "", false) == 0)
          {
            frmChangeTemplate.EpisodeID = this.CurrentEInstanceData.EpisodeID;
            frmChangeTemplate.CategoryID = this.CurrentEInstanceData.CategoryID;
          }
          else
          {
            frmChangeTemplate.EpisodeID = this.CurrentEInstanceData.EpisodeID;
            frmChangeTemplate.CategoryID = this.CurrentEInstanceData.GroupItemID;
          }
          if (frmChangeTemplate.ShowDialog((IWin32Window) this) != DialogResult.OK || frmChangeTemplate.NewTemplateID == null | Operators.CompareString(frmChangeTemplate.NewTemplateID, "", false) == 0)
            return;
          ATemplateID = frmChangeTemplate.NewTemplateID;
        }
        if (this.IsNewFramework)
        {
          this.CurrentEMixInstanceLog.StateInfo = this.OperLog(parAction);
          this.InitAfterAction(parAction, this.CurrentEInstanceData.ID, this.CurrentEMixInstanceLog);
        }
        else
        {
          this.CurrentEInstanceLog = this.ChanegStatusAndAddLog("Switch", this.patientRecordStatus, this.CurrentEInstanceData.ID);
          this.InitAfterAction("Switch", this.CurrentEInstanceData.ID, this.CurrentEInstanceLog);
        }
        this.CurrentEInstanceData = WebServiceLayer.InstanceAccess.ReplaceTemplateData(this.CurrentEInstanceData.ID, ATemplateID);
        EInstanceData currentEinstanceData = this.CurrentEInstanceData;
        PInterface currentPinterface = this.CurrentPInterface;
        this.InitialTemplate(currentEinstanceData, ref currentPinterface);
        this.CurrentPInterface = currentPinterface;
        this.ShowMessageBox("模板更新成功！", true, "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.ShowMessageBox("模板更新失败！\r\n\r\n" + exception.Message + "\r\n\r\n" + exception.StackTrace, true, "");
        ProjectData.ClearProjectError();
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Save(false, "Save");
      this.Cursor = Cursors.Default;
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.RefreshBindingData();
      ((PPanel) ((PMsg) this.CurrentPInterface.PMsg).PPanel).set_IsValueChanged(true);
      this.Cursor = Cursors.Default;
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Print(string.Empty, string.Empty);
      this.Cursor = Cursors.Default;
    }

    private void btnCommit_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Commit(string.Empty, string.Empty);
      this.Cursor = Cursors.Default;
    }

    private void btnTemplate_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "本操作将清除当前病历中的所有内容，是否继续？", MsgBoxStyle.OkCancel, (object) "注意！") == MsgBoxResult.Cancel)
        return;
      this.Cursor = Cursors.WaitCursor;
      this.SwitchTemplate(string.Empty);
      this.Cursor = Cursors.Default;
    }

    private void btnViewLogs_Click(object sender, EventArgs e)
    {
    }

    protected void ShowMessageBox(string parMessageContent, bool parShowTemplateName, string parErrorMsgContent = "")
    {
      string str = "";
      if (parShowTemplateName)
      {
        str = this.GetTemplateName();
        if (!str.Equals(string.Empty))
          str = "《" + str + "》";
      }
      SaveMsgForm saveMsgForm = new SaveMsgForm();
      saveMsgForm.Message = str + parMessageContent;
      saveMsgForm.ErrorMessgae = parErrorMsgContent;
      saveMsgForm.MsgColor = this.BackColor;
      saveMsgForm.StartPosition = FormStartPosition.CenterScreen;
      int num = (int) saveMsgForm.ShowDialog();
      saveMsgForm.Close();
    }

    protected virtual string GetTemplateName()
    {
      return string.Empty;
    }

    protected string GetOperTplID(string parAction)
    {
      if (Operators.CompareString(parAction, "Save", false) == 0 || Operators.CompareString(parAction, "Switch", false) == 0)
        return this.CurrentEInstanceData.TemplateID;
      return string.Empty;
    }

    protected virtual string OperLog(string parAction)
    {
      return string.Empty;
    }

    protected EMixInstanceLog CreateEMixInstanceLog(string parAction)
    {
      EMixInstanceLog emixInstanceLog = new EMixInstanceLog();
      emixInstanceLog.IsNewFramework = this.IsNewFramework.ToString();
      emixInstanceLog.OperateUserID = this.UserID;
      emixInstanceLog.Action = parAction;
      emixInstanceLog.OperateMachineIP = LogManagement.GetClientIP();
      if (this.IsNewFramework)
      {
        emixInstanceLog.EpisodeID = this.EpisodeID;
        emixInstanceLog.PrintTemplateDocID = this.PrnTemplateDocID;
        emixInstanceLog.TemplateDocID = this.m_TemplateDocID;
      }
      else
      {
        emixInstanceLog.InitStatus = this.patientRecordStatus;
        emixInstanceLog.FinalStatus = StatusManagement.GenerateFinalStatus(this.userLevel, this.patientRecordStatus, "Save");
      }
      return emixInstanceLog;
    }

    protected void InitAfterAction(string parAction, string parInstanceID, EMixInstanceLog parEMixInstanceLog)
    {
      try
      {
        if (this.IsNewFramework)
        {
          this.m_StatusAfterSaveNewFrameWork = parEMixInstanceLog.StateInfo;
        }
        else
        {
          this.SetCurLog(parInstanceID, new EInstanceLog()
          {
            InitStatus = parEMixInstanceLog.InitStatus,
            Action = parEMixInstanceLog.Action,
            FinalStatus = parEMixInstanceLog.FinalStatus,
            OperateUserID = parEMixInstanceLog.OperateUserID,
            RealOperateUserID = parEMixInstanceLog.RealOperateUserID,
            OperateUserName = parEMixInstanceLog.OperateUserName,
            OperateDate = parEMixInstanceLog.OperateDate,
            OperateTime = parEMixInstanceLog.OperateTime,
            OperateMachineIP = parEMixInstanceLog.OperateMachineIP
          });
          this.ShowInfoInStatusBar(parInstanceID);
          if (Operators.CompareString(parAction, "Commit", false) == 0 && this.GetRevisionAvailable())
            this.SetCurCommitStatus(parInstanceID, true);
          if (!PrivManagement.PrivAvailable)
            return;
          string privString = this.GetPrivString(parInstanceID);
          this.SetCurPrivString(parInstanceID, privString);
          this.GetButtonPriv(parInstanceID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("日志处理失败。\r\n\r\n" + ex.Message), MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    protected void InitAfterAction(string parAction, string parInstanceID, EInstanceLog parEInstanceLog)
    {
      try
      {
        if (this.IsNewFramework)
          return;
        this.SetCurLog(parInstanceID, parEInstanceLog);
        this.ShowInfoInStatusBar(parInstanceID);
        if (Operators.CompareString(parAction, "Commit", false) == 0 && this.GetRevisionAvailable())
          this.SetCurCommitStatus(parInstanceID, true);
        if (!PrivManagement.PrivAvailable)
          return;
        string privString = this.GetPrivString(parInstanceID);
        this.SetCurPrivString(parInstanceID, privString);
        this.GetButtonPriv(parInstanceID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("日志处理失败。\r\n\r\n" + ex.Message), MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    protected void InitAfterLoadContent(ref EInstanceData instanceData)
    {
      if (this.IsNewFramework)
      {
        if (!this.Revisionable)
          return;
        this.StartRevision();
      }
      else
      {
        this.patientRecordStatus = instanceData.Status;
        if (instanceData.ListNo != null)
          GlobalValues.AddKeyValue("ListNo", instanceData.ListNo);
        if (instanceData.CategoryID != null)
          GlobalValues.AddKeyValue("CategoryID", instanceData.CategoryID);
        LogManager.WriteLog("处理留痕", true);
        if (instanceData != null)
          this.SetRevision(instanceData.ID);
        LogManager.WriteLog("End处理留痕", true);
        LogManager.WriteLog("操作权限检查", true);
        this.ShowInfoInStatusBar(instanceData.ID);
        this.GetButtonPriv(instanceData.ID);
        LogManager.WriteLog("End操作权限检查", true);
        LogManager.WriteLog("----------------------------------------", false);
      }
    }

    protected EInstanceLog ChanegStatusAndAddLog(string parAction, string parStatus, string parInstanceDataID)
    {
      string str = (string) null;
      try
      {
        str = StatusManagement.GenerateFinalStatus(this.userLevel, parStatus, parAction);
        if (!StatusManagement.ChangeStatus(parInstanceDataID, parStatus, str))
          return (EInstanceLog) null;
        EInstanceLog einstanceLog = LogManagement.AddLog(parInstanceDataID, parStatus, parAction, str, this.m_UserID, this.userLevel);
        return einstanceLog ?? einstanceLog;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "修改病历状态、日志错误！", MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.patientRecordStatus = str;
      }
      return (EInstanceLog) null;
    }

    protected void ShowInfoInStatusBar(string parInstanceDataID)
    {
      try
      {
        EInstanceLog curLog = this.GetCurLog(parInstanceDataID);
        string str1;
        string str2;
        if (curLog != null)
        {
          str1 = "病历由用户 " + curLog.OperateUserName + " 于 " + curLog.OperateDate + " " + curLog.OperateTime + " 在 " + curLog.OperateMachineIP + " " + GlobalValues.ConvertActionStatusChinese(curLog.Action);
          str2 = curLog.FinalStatus;
        }
        else
        {
          str1 = string.Empty;
          str2 = "UnSave";
        }
        this.patientRecordStatus = str2;
        this.stBar.Panels[0].Text = str1;
        this.stBar.Panels[1].Text = "当前状态：" + GlobalValues.ConvertActionStatusChinese(str2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取病历日志和状态信息失败！", MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    protected virtual EInstanceLog GetCurLog(string parInstanceID)
    {
      if (Operators.CompareString(parInstanceID, "", false) == 0)
        return (EInstanceLog) null;
      if (this.logHashTable == null)
        this.logHashTable = new Hashtable();
      EInstanceLog finalLog;
      if (this.logHashTable.Contains((object) parInstanceID))
      {
        finalLog = (EInstanceLog) this.logHashTable[(object) parInstanceID];
      }
      else
      {
        finalLog = LogManagement.GetFinalLog(parInstanceID);
        this.SetCurLog(parInstanceID, finalLog);
      }
      return finalLog;
    }

    protected void SetCurLog(string parInstanceID, EInstanceLog parLog)
    {
      if (Operators.CompareString(parInstanceID, "", false) == 0)
        return;
      if (this.logHashTable == null)
        this.logHashTable = new Hashtable();
      if (this.logHashTable.Contains((object) parInstanceID))
        this.logHashTable[(object) parInstanceID] = (object) parLog;
      else
        this.logHashTable.Add((object) parInstanceID, (object) parLog);
    }

    protected bool GetRevisionAvailable()
    {
      string sysOptionValue = SysOptionManager.GetSysOptionValue("Revision", "Y");
      return sysOptionValue != null && sysOptionValue.ToUpper().Equals("Y");
    }

    protected void SetRevision(string parInstanceDataId)
    {
      if (!this.GetRevisionAvailable() || !this.IsNewFramework && (this.CurrentEInstanceData == null || this.CurrentEInstanceData.Status.Equals("UnSave")) || !this.IsNewFramework && !this.GetCurCommitStatus(parInstanceDataId))
        return;
      this.isCommited = true;
      this.StartRevision();
    }

    protected void StartRevision()
    {
      ((NInstanceItem) this.CurrentPInterface.get_InstanceData()).set_RevPerson(this.m_UserName);
      ((NInstanceItem) this.CurrentPInterface.get_InstanceData()).set_RevTime(DateAndTime.Now.ToString("yyyy-M-d") + " " + DateAndTime.Now.ToString("H:mm:ss"));
      ((NInstanceItem) this.CurrentPInterface.get_InstanceData()).set_RevStatus(true);
    }

    protected virtual bool GetCurCommitStatus(string parInstanceID)
    {
      if (Operators.CompareString(parInstanceID, "", false) == 0)
        return Conversions.ToBoolean("");
      if (this.commitStatusHashTable == null)
        this.commitStatusHashTable = new Hashtable();
      bool parCommitStatus;
      if (this.commitStatusHashTable.Contains((object) parInstanceID))
      {
        parCommitStatus = bool.Parse(Conversions.ToString(this.commitStatusHashTable[(object) parInstanceID]));
      }
      else
      {
        parCommitStatus = StatusManagement.CheckStatusExist(parInstanceID, "Commit");
        this.SetCurCommitStatus(parInstanceID, parCommitStatus);
      }
      return parCommitStatus;
    }

    protected void SetCurCommitStatus(string parInstanceID, bool parCommitStatus)
    {
      if (Operators.CompareString(parInstanceID, "", false) == 0)
        return;
      if (this.commitStatusHashTable == null)
        this.commitStatusHashTable = new Hashtable();
      if (this.commitStatusHashTable.Contains((object) parInstanceID))
        this.commitStatusHashTable[(object) parInstanceID] = (object) parCommitStatus;
      else
        this.commitStatusHashTable.Add((object) parInstanceID, (object) parCommitStatus);
    }

    protected string GetPrivString(string parInstanceID)
    {
      try
      {
        if (parInstanceID == null)
          parInstanceID = string.Empty;
        return PrivManagement.GetPrivileges("userid^" + this.m_UserID + "!admid^" + this.m_EpisodeID + "!instanceid^" + parInstanceID + "!userloc^" + this.m_CTLocID + "!categoryid^" + this.m_CategoryID + "!templateid^" + this.CurrentEInstanceData.TemplateID + "!ssgroupid^" + this.m_SSGroupID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new ApplicationException("获取权限字串错误。");
      }
    }

    protected virtual void GetButtonPriv(string parInstanceID)
    {
      try
      {
        if (!this.canBeBrowsed)
          this.SetButtonEnabled(false, false, false, false);
        else if (PrivManagement.PrivAvailable)
        {
          string curPrivString = this.GetCurPrivString(parInstanceID);
          this.SetButtonEnabled(PrivManagement.ParsePriv("Save", curPrivString), PrivManagement.ParsePriv("Print", curPrivString), PrivManagement.ParsePriv("Switch", curPrivString), PrivManagement.ParsePriv("Commit", curPrivString));
        }
        else
          this.SetButtonEnabled(true, true, true, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取按钮权限错误。", MsgBoxStyle.OkOnly, (object) null);
        this.SetButtonEnabled(false, false, false, false);
        ProjectData.ClearProjectError();
      }
    }

    private void SetButtonEnabled(bool parSaveEnabled, bool parPrintEnabled, bool parSwitchEnabled, bool parCommitEnabled)
    {
      this.btnSave.Enabled = parSaveEnabled;
      this.btnRefresh.Enabled = parSaveEnabled;
      this.btnPrint.Enabled = parPrintEnabled;
      this.btnCommit.Enabled = parCommitEnabled;
      this.btnTemplate.Enabled = parSwitchEnabled;
    }

    protected virtual bool CanBrowse(string parInstanceID)
    {
      bool flag;
      try
      {
        flag = !PrivManagement.PrivAvailable || PrivManagement.ParsePriv("View", this.GetCurPrivString(parInstanceID));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "获取病历查看权限错误，将不能查看所有病历。", MsgBoxStyle.OkOnly, (object) null);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    protected virtual void SetPanelInvalid(string message)
    {
      GlobalValues.AddKeyValue("ListNo", Conversions.ToString(0));
      GlobalValues.AddKeyValue("CategoryID", "");
      this.SetButtonEnabled(false, false, false, false);
      this.btnViewLogs.Enabled = false;
      this.stBar.Panels[0].Text = message;
      this.stBar.Panels[1].Text = "";
    }

    protected virtual void SetTabInvalid()
    {
      this.SetButtonEnabled(false, false, false, false);
      this.btnViewLogs.Enabled = false;
      this.stBar.Panels[0].Text = "当前横排没有适用的页签";
      this.stBar.Panels[1].Text = "";
    }

    protected virtual string GetCurPrivString(string parInstanceID)
    {
      if (this.priviledgeHashTable == null && Operators.CompareString(parInstanceID, "", false) != 0)
        this.priviledgeHashTable = new Hashtable();
      string privString;
      if (parInstanceID != null && this.priviledgeHashTable.Contains((object) parInstanceID))
      {
        privString = Conversions.ToString(this.priviledgeHashTable[(object) parInstanceID]);
      }
      else
      {
        privString = this.GetPrivString(parInstanceID);
        if (Operators.CompareString(parInstanceID, "", false) != 0)
          this.SetCurPrivString(parInstanceID, privString);
      }
      return privString;
    }

    protected void SetCurPrivString(string parInstanceID, string parPrivString)
    {
      if (Operators.CompareString(parInstanceID, "", false) == 0)
        return;
      if (this.priviledgeHashTable == null)
        this.priviledgeHashTable = new Hashtable();
      if (this.priviledgeHashTable.Contains((object) parInstanceID))
        this.priviledgeHashTable[(object) parInstanceID] = (object) parPrivString;
      else
        this.priviledgeHashTable.Add((object) parInstanceID, (object) parPrivString);
    }

    protected void InitAutoSaveTimer()
    {
      string sysOptionValue = SysOptionManager.GetSysOptionValue("AutoSaveTime", "0");
      int num1;
      try
      {
        num1 = Convert.ToInt32(sysOptionValue);
        if (num1 > 0 && num1 < this.minAutoSaveTime)
          num1 = this.minAutoSaveTime;
        else if (num1 < 0)
          num1 = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num2 = (int) MessageBox.Show("自动保存时间转换错误！", exception.Message + exception.StackTrace);
        num1 = 0;
        ProjectData.ClearProjectError();
      }
      if (num1 == 0)
        return;
      if (this.tmrAutoSave != null)
        this.tmrAutoSave.Dispose();
      if (!this.btnSave.Enabled)
        return;
      this.tmrAutoSave = new Timer();
      this.tmrAutoSave.Interval = Convert.ToInt32(checked (num1 * 1000));
      this.tmrAutoSave.Enabled = true;
      this.tmrAutoSave.Tick += new EventHandler(this.tmrAutoSave_Tick);
    }

    private void tmrAutoSave_Tick(object sender, EventArgs e)
    {
      if (!this.btnSave.Enabled)
        return;
      this.Save(true, "Save");
    }

    public bool SaveClick(bool isAutoSave = false, string action = "Save")
    {
      this.Cursor = Cursors.WaitCursor;
      bool flag = this.Save(isAutoSave, action);
      this.Cursor = Cursors.Default;
      return flag;
    }

    public void RefreshClick()
    {
      this.Cursor = Cursors.WaitCursor;
      this.RefreshBindingData();
      this.Cursor = Cursors.Default;
    }

    public bool PrintClick(string parPrintTemplateID, string parPrintDocID)
    {
      this.Cursor = Cursors.WaitCursor;
      bool flag = this.Print(parPrintTemplateID, parPrintDocID);
      this.Cursor = Cursors.Default;
      return flag;
    }

    public bool PreviewClick(string parPrintTemplateID, string parPrintDocID)
    {
      this.Cursor = Cursors.WaitCursor;
      new PrintClient().PreviewSingle(this.m_PatientID, this.EpisodeID, parPrintTemplateID, this.m_UserID, this.IsNewFramework, parPrintDocID);
      this.Cursor = Cursors.Default;
      bool flag;
      return flag;
    }

    public bool ExportRecordClick(string parPrintTemplateID, string parPrintDocID)
    {
      this.Cursor = Cursors.WaitCursor;
      new PrintClient().ExportSingle(this.m_PatientID, this.EpisodeID, parPrintTemplateID, this.m_UserID, this.IsNewFramework, parPrintDocID);
      this.Cursor = Cursors.Default;
      bool flag;
      return flag;
    }

    public bool CommitClick(string parPrintTemplateID, string parPrintDocID)
    {
      this.Cursor = Cursors.WaitCursor;
      bool flag = this.Commit(parPrintTemplateID, parPrintDocID);
      this.Cursor = Cursors.Default;
      return flag;
    }

    public bool CASign()
    {
      string str = WebServiceLayer.DigitalSignAccess.Sign(this.CASignInfo[0], this.CASignInfo[5], this.CASignInfo[1], this.CurrentEInstanceData.ListNo, this.CASignInfo[2], this.CASignInfo[3].ToString(), this.CASignInfo[4]);
      if (string.IsNullOrEmpty(str))
        return true;
      int num = (int) Interaction.MsgBox((object) str, MsgBoxStyle.Information, (object) "数字签名提示");
      return false;
    }

    public string GetString(string content)
    {
      int num1 = 0;
      int num2 = checked (content.Length - 1);
      int length = num1;
      while (length <= num2)
      {
        if ((int) content[length] == 0)
          return content.Substring(0, length);
        checked { ++length; }
      }
      return string.Empty;
    }

    public bool CACommitClick(string episodeID, string parPrintTemplateID, string parPrintDocID, string signValue, string insIDs, string contentHash, string usrID)
    {
      this.Cursor = Cursors.WaitCursor;
      this.CASignInfo[0] = signValue.ToString();
      this.CASignInfo[1] = parPrintDocID;
      this.CASignInfo[2] = insIDs;
      this.CASignInfo[3] = contentHash;
      this.CASignInfo[4] = usrID;
      this.CASignInfo[5] = episodeID;
      bool flag = this.Commit(parPrintTemplateID, parPrintDocID);
      this.Cursor = Cursors.Default;
      return flag;
    }

    public void TemplateClick(string parAction)
    {
      if (!string.IsNullOrEmpty(SysOptionManager.GetSysOptionValue("CALocation", string.Empty)))
      {
        if (MsgBoxResult.Ok == Interaction.MsgBox((object) "本操作将清除当前模板中的所有内容，并会导致签名失效", MsgBoxStyle.OkCancel, (object) "注意！"))
        {
          string signLogID = WebServiceLayer.DigitalSignAccess.HasValidSign(this.EpisodeID, this.PrnTemplateDocID, this.CurrentEInstanceData.ListNo);
          if (!string.IsNullOrEmpty(signLogID))
            WebServiceLayer.DigitalSignAccess.SetSignUnvalid(signLogID);
        }
        else
        {
          this.m_StatusAfterSaveNewFrameWork = "UnChanged";
          return;
        }
      }
      else if (Interaction.MsgBox((object) "本操作将清除当前模板中的所有内容，是否继续？", MsgBoxStyle.OkCancel, (object) "注意！") == MsgBoxResult.Cancel)
      {
        this.m_StatusAfterSaveNewFrameWork = "UnChanged";
        return;
      }
      this.Cursor = Cursors.WaitCursor;
      this.SwitchTemplate(parAction);
      this.Cursor = Cursors.Default;
    }

    public bool GetBtnEnabled(string btnName)
    {
      if (Operators.CompareString(btnName, "Save", false) == 0)
        return this.btnSave.Enabled;
      if (Operators.CompareString(btnName, "Print", false) == 0)
        return this.btnPrint.Enabled;
      if (Operators.CompareString(btnName, "Commit", false) == 0)
        return this.btnCommit.Enabled;
      if (Operators.CompareString(btnName, "Template", false) == 0)
        return this.btnTemplate.Enabled;
      bool flag;
      return flag;
    }

    public void InvokePreviewService(string patId, string episodeId, string logId, string printTemplateID, string printType, string instanceId, string userId, string printDocId)
    {
      new PreviewManager().InvokePreviewService(patId, episodeId, logId, printTemplateID, printType, instanceId, userId, printDocId);
    }

    public void ReplaceInstanceData(string oldInstanceDataID)
    {
      this.CurrentEInstanceData.InstanceData = WebServiceLayer.InstanceAccess.GetDataByInstanceID(oldInstanceDataID).StreamData;
      EInstanceData currentEinstanceData = this.CurrentEInstanceData;
      PInterface currentPinterface = this.CurrentPInterface;
      this.InitialTemplate(currentEinstanceData, ref currentPinterface);
      this.CurrentPInterface = currentPinterface;
    }

    public string GetRefInstanceID(string episodeID, string templateID)
    {
      return WebServiceLayer.InstanceAccess.GetRefInstanceID(episodeID, templateID);
    }

    public void ExportClick(string instanceID, string recordName)
    {
      int num = (int) new DataExpImpForm(instanceID, recordName).ShowDialog();
    }

    public bool IsValueChanged()
    {
      if (this.CurrentPInterface == null || this.CurrentPInterface.PMsg == null || ((PMsg) this.CurrentPInterface.PMsg).PPanel == null)
        return false;
      return ((PPanel) ((PMsg) this.CurrentPInterface.PMsg).PPanel).get_IsValueChanged();
    }

    public void ResetUnitState()
    {
      this.ResetUnitEditState();
    }

    public string Login(string usrID, string certificateID, string userCert, string serverRan, string userSignedData)
    {
      string str = WebServiceLayer.DigitalSignAccess.Login(usrID, certificateID, userCert, serverRan, userSignedData);
      if (string.IsNullOrEmpty(str))
        str = string.Empty;
      return str;
    }

    public string GetContent(string usrID, string printDocID, string insID, string episodeID)
    {
      string str = WebServiceLayer.DigitalSignAccess.GetContent(usrID, printDocID, insID, episodeID);
      if (string.IsNullOrEmpty(str))
        str = string.Empty;
      return str;
    }

    public string GetContentByIDs(string IDs)
    {
      string str = WebServiceLayer.DigitalSignAccess.GetContentByIDs(IDs);
      if (string.IsNullOrEmpty(str))
        str = string.Empty;
      return str;
    }

    public string GetInstanceIDs(string usrID, string printDocID, string episodeID)
    {
      string str = WebServiceLayer.DigitalSignAccess.GetInstanceIDs(usrID, printDocID, episodeID);
      if (string.IsNullOrEmpty(str))
        str = string.Empty;
      return str;
    }

    public bool IsCAOn()
    {
      return Operators.CompareString(WebServiceLayer.DigitalSignAccess.GetCAServiceStatus(GlobalValues.GetValueByKey("CTLocID")), "1", false) == 0;
    }

    public bool CheckValidSign()
    {
      if (!string.IsNullOrEmpty(SysOptionManager.GetSysOptionValue("CALocation", string.Empty)))
      {
        string signLogID = WebServiceLayer.DigitalSignAccess.HasValidSign(this.EpisodeID, this.PrnTemplateDocID, this.CurrentEInstanceData.ListNo);
        if (!string.IsNullOrEmpty(signLogID))
        {
          if (MsgBoxResult.Ok != Interaction.MsgBox((object) "改变会导致签名失效", MsgBoxStyle.OkCancel, (object) "数字签名提示"))
            return false;
          WebServiceLayer.DigitalSignAccess.SetSignUnvalid(signLogID);
        }
      }
      return true;
    }

    protected class DllProperty
    {
      private string _name;
      private string _value;
      private bool _isSet;

      public string PName
      {
        get
        {
          return this._name;
        }
        set
        {
          this._name = value;
        }
      }

      public string PValue
      {
        get
        {
          return this._value;
        }
        set
        {
          this._value = value;
        }
      }

      public bool IsSet
      {
        get
        {
          return this._isSet;
        }
      }

      public DllProperty(string argPropertyName, string argPropertyValue, bool argIsGlobal)
      {
        this.PName = argPropertyName;
        this.PValue = argPropertyValue;
        this._isSet = true;
        if (!argIsGlobal)
          return;
        GlobalValues.AddKeyValue(argPropertyName, argPropertyValue);
      }
    }
  }
}
