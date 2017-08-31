// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.onestepprint.UCOneStepPrint
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace dhcc.epr.webclient.onestepprint
{
  [DesignerGenerated]
  public class UCOneStepPrint : UserControl
  {
    private IContainer components;
    [AccessedThroughProperty("btnPause")]
    private Button _btnPause;
    [AccessedThroughProperty("btnContinue")]
    private Button _btnContinue;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("rtbStatus")]
    private RichTextBoxEx _rtbStatus;
    private string m_PrintParameters;
    private BLOneStepPrint m_BLOneStepPrint;
    private Thread m_PrintThread;
    private bool m_IsPrintFinished;

    internal virtual Button btnPause
    {
      [DebuggerNonUserCode] get
      {
        return this._btnPause;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPause_Click);
        if (this._btnPause != null)
          this._btnPause.Click -= eventHandler;
        this._btnPause = value;
        if (this._btnPause == null)
          return;
        this._btnPause.Click += eventHandler;
      }
    }

    internal virtual Button btnContinue
    {
      [DebuggerNonUserCode] get
      {
        return this._btnContinue;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
        if (this._btnContinue != null)
          this._btnContinue.Click -= eventHandler;
        this._btnContinue = value;
        if (this._btnContinue == null)
          return;
        this._btnContinue.Click += eventHandler;
      }
    }

    internal virtual Panel Panel1
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    internal virtual Panel Panel2
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel2 = value;
      }
    }

    internal virtual Splitter Splitter1
    {
      [DebuggerNonUserCode] get
      {
        return this._Splitter1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Splitter1 = value;
      }
    }

    internal virtual RichTextBoxEx rtbStatus
    {
      [DebuggerNonUserCode] get
      {
        return this._rtbStatus;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._rtbStatus = value;
      }
    }

    public string PrintParameters
    {
      get
      {
        return this.m_PrintParameters;
      }
      set
      {
        this.m_PrintParameters = value;
      }
    }

    public bool IsPrintFinished
    {
      get
      {
        return this.m_IsPrintFinished;
      }
    }

    public UCOneStepPrint()
    {
      this.Load += new EventHandler(this.UCOneStepPrint_Load);
      this.m_PrintParameters = string.Empty;
      this.m_BLOneStepPrint = (BLOneStepPrint) null;
      this.m_PrintThread = (Thread) null;
      this.m_IsPrintFinished = false;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.btnPause = new Button();
      this.btnContinue = new Button();
      this.Panel1 = new Panel();
      this.Panel2 = new Panel();
      this.Splitter1 = new Splitter();
      this.rtbStatus = new RichTextBoxEx();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.btnPause.Dock = DockStyle.Right;
      Button btnPause1 = this.btnPause;
      Point point1 = new Point(385, 0);
      Point point2 = point1;
      btnPause1.Location = point2;
      this.btnPause.Name = "btnPause";
      Button btnPause2 = this.btnPause;
      Size size1 = new Size(75, 27);
      Size size2 = size1;
      btnPause2.Size = size2;
      this.btnPause.TabIndex = 2;
      this.btnPause.Text = "暂停";
      this.btnPause.UseVisualStyleBackColor = true;
      this.btnContinue.Dock = DockStyle.Right;
      Button btnContinue1 = this.btnContinue;
      point1 = new Point(460, 0);
      Point point3 = point1;
      btnContinue1.Location = point3;
      this.btnContinue.Name = "btnContinue";
      Button btnContinue2 = this.btnContinue;
      size1 = new Size(75, 27);
      Size size3 = size1;
      btnContinue2.Size = size3;
      this.btnContinue.TabIndex = 3;
      this.btnContinue.Text = "继续";
      this.btnContinue.UseVisualStyleBackColor = true;
      this.Panel1.Controls.Add((Control) this.rtbStatus);
      this.Panel1.Dock = DockStyle.Fill;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 0);
      Point point4 = point1;
      panel1_1.Location = point4;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(535, 402);
      Size size4 = size1;
      panel1_2.Size = size4;
      this.Panel1.TabIndex = 5;
      this.Panel2.BackColor = SystemColors.ControlLight;
      this.Panel2.Controls.Add((Control) this.btnPause);
      this.Panel2.Controls.Add((Control) this.btnContinue);
      this.Panel2.Dock = DockStyle.Bottom;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(0, 375);
      Point point5 = point1;
      panel2_1.Location = point5;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(535, 27);
      Size size5 = size1;
      panel2_2.Size = size5;
      this.Panel2.TabIndex = 6;
      this.Splitter1.BackColor = SystemColors.ControlLight;
      this.Splitter1.Dock = DockStyle.Bottom;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(0, 372);
      Point point6 = point1;
      splitter1_1.Location = point6;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(535, 3);
      Size size6 = size1;
      splitter1_2.Size = size6;
      this.Splitter1.TabIndex = 7;
      this.Splitter1.TabStop = false;
      ((TextBoxBase) this.rtbStatus).BackColor = SystemColors.ControlLight;
      ((Control) this.rtbStatus).Dock = DockStyle.Fill;
      ((RichTextBox) this.rtbStatus).Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      ((RichTextBox) this.rtbStatus).ForeColor = SystemColors.GradientActiveCaption;
      RichTextBoxEx rtbStatus1 = this.rtbStatus;
      point1 = new Point(0, 0);
      Point point7 = point1;
      ((Control) rtbStatus1).Location = point7;
      ((Control) this.rtbStatus).Name = "rtbStatus";
      RichTextBoxEx rtbStatus2 = this.rtbStatus;
      size1 = new Size(535, 402);
      Size size7 = size1;
      ((Control) rtbStatus2).Size = size7;
      ((Control) this.rtbStatus).TabIndex = 4;
      ((RichTextBox) this.rtbStatus).Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.Panel1);
      this.Name = "UCOneStepPrint";
      size1 = new Size(535, 402);
      this.Size = size1;
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void PrintInMultipleThread()
    {
      this.Init();
      this.StartThread();
    }

    public void PrintInSingleThread()
    {
      this.Init();
      this.StartPrint();
    }

    private void Init()
    {
      if (this.m_BLOneStepPrint == null)
        this.m_BLOneStepPrint = new BLOneStepPrint();
      this.m_BLOneStepPrint.PrintParams = this.PrintParameters;
      this.m_BLOneStepPrint.PrintStarted += new BLOneStepPrint.PrintStartedEventHandler(this.OnPrintStarted);
      this.m_BLOneStepPrint.PrintPaused += new BLOneStepPrint.PrintPausedEventHandler(this.OnPrintPaused);
      this.m_BLOneStepPrint.PrintFinished += new BLOneStepPrint.PrintFinishedEventHandler(this.OnPrintFinished);
      this.m_BLOneStepPrint.OnePrintJobStarted += new BLOneStepPrint.OnePrintJobStartedEventHandler(this.OnOnePrintJobStarted);
      this.m_BLOneStepPrint.OnePrintJobFinished += new BLOneStepPrint.OnePrintJobFinishedEventHandler(this.OnOnePrintJobFinished);
    }

    private void StartThread()
    {
      if (this.m_PrintThread != null && this.m_PrintThread.IsAlive)
        return;
      this.m_PrintThread = new Thread(new ThreadStart(this.StartPrint));
      this.m_PrintThread.Name = "OneStepPrint";
      this.m_PrintThread.Start();
    }

    private void StartPrint()
    {
      this.m_BLOneStepPrint.StartPrint();
    }

    private void UCOneStepPrint_Load(object sender, EventArgs e)
    {
      if (!SysOptionManager.GetSysOptionValue("XPStyle", "N").Equals("Y"))
        return;
      Application.EnableVisualStyles();
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
      if (this.m_PrintThread != null && this.m_PrintThread.IsAlive)
      {
        int num = (int) MessageBox.Show("打印作业进行中......!");
      }
      else
        this.StartThread();
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
      this.SetStatus("正在暂停打印作业，请稍后......", 2);
      this.m_BLOneStepPrint.PausePrint();
    }

    private void OnPrintStarted(object sender, PrintJobEventArgs e)
    {
      this.SetStatus(e.JobInfo, 3);
    }

    private void OnPrintPaused(object sender, PrintJobEventArgs e)
    {
      this.SetStatus(e.JobInfo, 2);
    }

    private void OnPrintFinished(object sender, PrintJobEventArgs e)
    {
      this.SetStatus(e.JobInfo, 4);
      this.m_IsPrintFinished = true;
    }

    private void OnOnePrintJobFinished(object sender, PrintJobEventArgs e)
    {
      this.SetStatus(e.JobInfo, 1);
    }

    private void OnOnePrintJobStarted(object sender, PrintJobEventArgs e)
    {
      this.SetStatus(e.JobInfo, 1);
    }

    private void SetStatus(string statusInfo, int eventType)
    {
      if (((Control) this.rtbStatus).InvokeRequired)
      {
        this.Invoke((Delegate) new UCOneStepPrint.SetStatusCallback(this.SetStatus), (object) statusInfo, (object) eventType);
      }
      else
      {
        ((RichTextBox) this.rtbStatus).Text = ((RichTextBox) this.rtbStatus).Text + "\r" + statusInfo;
        this.SetBottonStatus(eventType);
      }
    }

    private void SetBottonStatus(int eventType)
    {
      if (eventType == 2)
      {
        this.btnPause.Enabled = false;
        this.btnContinue.Enabled = true;
      }
      else if (eventType == 3)
      {
        this.btnPause.Enabled = true;
        this.btnContinue.Enabled = false;
      }
      else
      {
        if (eventType != 4)
          return;
        this.btnPause.Enabled = false;
        this.btnContinue.Enabled = false;
      }
    }

    public delegate void SetStatusCallback(string text, int eventType);
  }
}
