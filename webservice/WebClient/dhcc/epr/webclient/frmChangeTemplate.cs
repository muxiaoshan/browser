// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.frmChangeTemplate
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class frmChangeTemplate : Form
  {
    private string _CategoryID;
    private string _EpisodeID;
    private UCTemplateList UCTemplateList;
    private const string Tip = "选择一个模板，然后点击确定按钮";
    private IContainer components;
    [AccessedThroughProperty("sb1")]
    private StatusBar _sb1;
    [AccessedThroughProperty("sbPanel")]
    private StatusBarPanel _sbPanel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;

    internal virtual StatusBar sb1
    {
      [DebuggerNonUserCode] get
      {
        return this._sb1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._sb1 = value;
      }
    }

    internal virtual StatusBarPanel sbPanel
    {
      [DebuggerNonUserCode] get
      {
        return this._sbPanel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._sbPanel = value;
      }
    }

    internal virtual Button btnOK
    {
      [DebuggerNonUserCode] get
      {
        return this._btnOK;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOK_Click);
        if (this._btnOK != null)
          this._btnOK.Click -= eventHandler;
        this._btnOK = value;
        if (this._btnOK == null)
          return;
        this._btnOK.Click += eventHandler;
      }
    }

    internal virtual Button btnCancel
    {
      [DebuggerNonUserCode] get
      {
        return this._btnCancel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
        if (this._btnCancel != null)
          this._btnCancel.Click -= eventHandler;
        this._btnCancel = value;
        if (this._btnCancel == null)
          return;
        this._btnCancel.Click += eventHandler;
      }
    }

    public string NewTemplateID
    {
      get
      {
        return this.UCTemplateList.TemplateID;
      }
    }

    public string NewTemplateName
    {
      get
      {
        return this.UCTemplateList.TemplateName;
      }
    }

    public string CategoryID
    {
      set
      {
        this._CategoryID = value;
        this.UCTemplateList.CategoryID = this._CategoryID;
      }
    }

    public string EpisodeID
    {
      set
      {
        this._EpisodeID = value;
        this.UCTemplateList.EpisodeID = this._EpisodeID;
      }
    }

    public frmChangeTemplate()
    {
      this.InitializeComponent();
      this.Init();
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
      this.sb1 = new StatusBar();
      this.sbPanel = new StatusBarPanel();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.sbPanel.BeginInit();
      this.SuspendLayout();
      StatusBar sb1_1 = this.sb1;
      Point point1 = new Point(0, 307);
      Point point2 = point1;
      sb1_1.Location = point2;
      this.sb1.Name = "sb1";
      this.sb1.Panels.AddRange(new StatusBarPanel[1]
      {
        this.sbPanel
      });
      this.sb1.ShowPanels = true;
      StatusBar sb1_2 = this.sb1;
      Size size1 = new Size(246, 24);
      Size size2 = size1;
      sb1_2.Size = size2;
      this.sb1.TabIndex = 0;
      this.sbPanel.AutoSize = StatusBarPanelAutoSize.Spring;
      this.sbPanel.Width = 230;
      this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.FlatStyle = FlatStyle.Popup;
      this.btnOK.ForeColor = SystemColors.ControlLightLight;
      Button btnOk1 = this.btnOK;
      point1 = new Point(28, 280);
      Point point3 = point1;
      btnOk1.Location = point3;
      this.btnOK.Name = "btnOK";
      Button btnOk2 = this.btnOK;
      size1 = new Size(76, 24);
      Size size3 = size1;
      btnOk2.Size = size3;
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "确  定";
      this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.FlatStyle = FlatStyle.Popup;
      this.btnCancel.ForeColor = SystemColors.ControlLightLight;
      Button btnCancel1 = this.btnCancel;
      point1 = new Point(140, 280);
      Point point4 = point1;
      btnCancel1.Location = point4;
      this.btnCancel.Name = "btnCancel";
      Button btnCancel2 = this.btnCancel;
      size1 = new Size(76, 24);
      Size size4 = size1;
      btnCancel2.Size = size4;
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "取  消";
      this.AcceptButton = (IButtonControl) this.btnOK;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      this.BackColor = SystemColors.Control;
      this.CancelButton = (IButtonControl) this.btnCancel;
      size1 = new Size(246, 331);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.sb1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmChangeTemplate";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "选择模板";
      this.sbPanel.EndInit();
      this.ResumeLayout(false);
    }

    private void Init()
    {
      this.UCTemplateList = new UCTemplateList();
      this.UCTemplateList.Location = new Point(4, 4);
      this.UCTemplateList.Size = new Size(236, 268);
      this.UCTemplateList.TabIndex = 1;
      this.Controls.Add((Control) this.UCTemplateList);
      this.sbPanel.Text = "选择一个模板，然后点击确定按钮";
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }
  }
}
