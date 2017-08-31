// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.SaveMsgForm
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
  public class SaveMsgForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtMsg")]
    private TextBox _txtMsg;
    [AccessedThroughProperty("txtErrorMsg")]
    private TextBox _txtErrorMsg;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;

    internal virtual TextBox txtMsg
    {
      [DebuggerNonUserCode] get
      {
        return this._txtMsg;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtMsg = value;
      }
    }

    internal virtual TextBox txtErrorMsg
    {
      [DebuggerNonUserCode] get
      {
        return this._txtErrorMsg;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtErrorMsg = value;
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
        this._btnOK = value;
      }
    }

    public string Message
    {
      get
      {
        return this.txtMsg.Text;
      }
      set
      {
        this.txtMsg.Text = value;
      }
    }

    public string ErrorMessgae
    {
      get
      {
        return this.txtErrorMsg.Text;
      }
      set
      {
        this.txtErrorMsg.Text = value;
      }
    }

    public Color MsgColor
    {
      set
      {
        this.BackColor = value;
        this.txtMsg.BackColor = value;
        this.txtErrorMsg.BackColor = value;
      }
    }

    public SaveMsgForm()
    {
      this.Load += new EventHandler(this.SaveMsgForm_Load);
      this.BackColorChanged += new EventHandler(this.SaveMsgForm_BackColorChanged);
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
      this.txtMsg = new TextBox();
      this.txtErrorMsg = new TextBox();
      this.btnOK = new Button();
      this.SuspendLayout();
      this.txtMsg.BackColor = SystemColors.Control;
      this.txtMsg.BorderStyle = BorderStyle.None;
      TextBox txtMsg1 = this.txtMsg;
      Point point1 = new Point(24, 14);
      Point point2 = point1;
      txtMsg1.Location = point2;
      this.txtMsg.Multiline = true;
      this.txtMsg.Name = "txtMsg";
      TextBox txtMsg2 = this.txtMsg;
      Size size1 = new Size(248, 20);
      Size size2 = size1;
      txtMsg2.Size = size2;
      this.txtMsg.TabIndex = 2;
      this.txtMsg.Text = "";
      this.txtErrorMsg.BackColor = SystemColors.Control;
      this.txtErrorMsg.BorderStyle = BorderStyle.None;
      this.txtErrorMsg.CausesValidation = false;
      this.txtErrorMsg.ForeColor = Color.Red;
      TextBox txtErrorMsg1 = this.txtErrorMsg;
      point1 = new Point(24, 34);
      Point point3 = point1;
      txtErrorMsg1.Location = point3;
      this.txtErrorMsg.Multiline = true;
      this.txtErrorMsg.Name = "txtErrorMsg";
      TextBox txtErrorMsg2 = this.txtErrorMsg;
      size1 = new Size(248, 45);
      Size size3 = size1;
      txtErrorMsg2.Size = size3;
      this.txtErrorMsg.TabIndex = 3;
      this.txtErrorMsg.Text = "";
      this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
      this.btnOK.DialogResult = DialogResult.Cancel;
      this.btnOK.FlatStyle = FlatStyle.Popup;
      this.btnOK.ForeColor = SystemColors.ControlLightLight;
      Button btnOk = this.btnOK;
      point1 = new Point(216, 86);
      Point point4 = point1;
      btnOk.Location = point4;
      this.btnOK.Name = "btnOK";
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "确定(&O)";
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(298, 112);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.txtErrorMsg);
      this.Controls.Add((Control) this.txtMsg);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "SaveMsgForm";
      this.Text = "东华结构化电子病历";
      this.ResumeLayout(false);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }

    private void SaveMsgForm_BackColorChanged(object sender, EventArgs e)
    {
      this.txtMsg.BackColor = this.BackColor;
      this.txtErrorMsg.BackColor = this.BackColor;
    }

    private void SaveMsgForm_Load(object sender, EventArgs e)
    {
      this.txtMsg.ReadOnly = false;
      this.txtErrorMsg.ReadOnly = false;
      this.btnOK.Focus();
    }
  }
}
