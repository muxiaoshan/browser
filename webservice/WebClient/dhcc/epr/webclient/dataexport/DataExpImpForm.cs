// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.dataexport.DataExpImpForm
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.webclient.dataexport
{
  public class DataExpImpForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("tabExport")]
    private TabPage _tabExport;
    [AccessedThroughProperty("tabImport")]
    private TabPage _tabImport;
    [AccessedThroughProperty("btnClose")]
    private Button _btnClose;
    [AccessedThroughProperty("btnExport")]
    private Button _btnExport;
    [AccessedThroughProperty("gbExportFile")]
    private GroupBox _gbExportFile;
    [AccessedThroughProperty("gbExportConfig")]
    private GroupBox _gbExportConfig;
    [AccessedThroughProperty("gbImportFile")]
    private GroupBox _gbImportFile;
    [AccessedThroughProperty("txtCurRecord")]
    private TextBox _txtCurRecord;
    [AccessedThroughProperty("lbCurRecord")]
    private Label _lbCurRecord;
    [AccessedThroughProperty("rbCurRecord")]
    private RadioButton _rbCurRecord;
    [AccessedThroughProperty("btnExportFile")]
    private Button _btnExportFile;
    [AccessedThroughProperty("txtExportFile")]
    private TextBox _txtExportFile;
    [AccessedThroughProperty("lbExportFile")]
    private Label _lbExportFile;
    [AccessedThroughProperty("lbImportFile")]
    private Label _lbImportFile;
    [AccessedThroughProperty("txtImportFile")]
    private TextBox _txtImportFile;
    [AccessedThroughProperty("btnImportFile")]
    private Button _btnImportFile;
    [AccessedThroughProperty("btnImport")]
    private Button _btnImport;
    [AccessedThroughProperty("btnClose2")]
    private Button _btnClose2;
    private string m_CurInstanceID;
    private string m_CurRecordName;

    internal virtual TabControl TabControl1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabControl1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabControl1 = value;
      }
    }

    internal virtual TabPage tabExport
    {
      [DebuggerNonUserCode] get
      {
        return this._tabExport;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tabExport = value;
      }
    }

    internal virtual TabPage tabImport
    {
      [DebuggerNonUserCode] get
      {
        return this._tabImport;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tabImport = value;
      }
    }

    internal virtual Button btnClose
    {
      [DebuggerNonUserCode] get
      {
        return this._btnClose;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        if (this._btnClose != null)
          this._btnClose.Click -= eventHandler;
        this._btnClose = value;
        if (this._btnClose == null)
          return;
        this._btnClose.Click += eventHandler;
      }
    }

    internal virtual Button btnExport
    {
      [DebuggerNonUserCode] get
      {
        return this._btnExport;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnExport_Click);
        if (this._btnExport != null)
          this._btnExport.Click -= eventHandler;
        this._btnExport = value;
        if (this._btnExport == null)
          return;
        this._btnExport.Click += eventHandler;
      }
    }

    internal virtual GroupBox gbExportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._gbExportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbExportFile = value;
      }
    }

    internal virtual GroupBox gbExportConfig
    {
      [DebuggerNonUserCode] get
      {
        return this._gbExportConfig;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbExportConfig = value;
      }
    }

    internal virtual GroupBox gbImportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._gbImportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbImportFile = value;
      }
    }

    internal virtual TextBox txtCurRecord
    {
      [DebuggerNonUserCode] get
      {
        return this._txtCurRecord;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtCurRecord = value;
      }
    }

    internal virtual Label lbCurRecord
    {
      [DebuggerNonUserCode] get
      {
        return this._lbCurRecord;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbCurRecord = value;
      }
    }

    internal virtual RadioButton rbCurRecord
    {
      [DebuggerNonUserCode] get
      {
        return this._rbCurRecord;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._rbCurRecord = value;
      }
    }

    internal virtual Button btnExportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._btnExportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnExportFile_Click);
        if (this._btnExportFile != null)
          this._btnExportFile.Click -= eventHandler;
        this._btnExportFile = value;
        if (this._btnExportFile == null)
          return;
        this._btnExportFile.Click += eventHandler;
      }
    }

    internal virtual TextBox txtExportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._txtExportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtExportFile = value;
      }
    }

    internal virtual Label lbExportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._lbExportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbExportFile = value;
      }
    }

    internal virtual Label lbImportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._lbImportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbImportFile = value;
      }
    }

    internal virtual TextBox txtImportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._txtImportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtImportFile = value;
      }
    }

    internal virtual Button btnImportFile
    {
      [DebuggerNonUserCode] get
      {
        return this._btnImportFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImportFile_Click);
        if (this._btnImportFile != null)
          this._btnImportFile.Click -= eventHandler;
        this._btnImportFile = value;
        if (this._btnImportFile == null)
          return;
        this._btnImportFile.Click += eventHandler;
      }
    }

    internal virtual Button btnImport
    {
      [DebuggerNonUserCode] get
      {
        return this._btnImport;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImport_Click);
        if (this._btnImport != null)
          this._btnImport.Click -= eventHandler;
        this._btnImport = value;
        if (this._btnImport == null)
          return;
        this._btnImport.Click += eventHandler;
      }
    }

    internal virtual Button btnClose2
    {
      [DebuggerNonUserCode] get
      {
        return this._btnClose2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose2_Click);
        if (this._btnClose2 != null)
          this._btnClose2.Click -= eventHandler;
        this._btnClose2 = value;
        if (this._btnClose2 == null)
          return;
        this._btnClose2.Click += eventHandler;
      }
    }

    public string CurInstanceID
    {
      get
      {
        return this.m_CurInstanceID;
      }
      set
      {
        this.m_CurInstanceID = value;
      }
    }

    public string CurRecordName
    {
      get
      {
        return this.m_CurRecordName;
      }
      set
      {
        this.m_CurRecordName = value;
      }
    }

    public DataExpImpForm()
    {
      this.m_CurInstanceID = "";
      this.m_CurRecordName = "";
      this.InitializeComponent();
    }

    public DataExpImpForm(string instanceID, string recordName)
    {
      this.m_CurInstanceID = "";
      this.m_CurRecordName = "";
      this.InitializeComponent();
      this.m_CurInstanceID = instanceID;
      this.m_CurRecordName = recordName;
      if (Operators.CompareString(recordName, "", false) == 0)
        return;
      this.txtCurRecord.Text = this.m_CurRecordName;
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
      ResourceManager resourceManager = new ResourceManager(typeof (DataExpImpForm));
      this.TabControl1 = new TabControl();
      this.tabExport = new TabPage();
      this.btnClose = new Button();
      this.btnExport = new Button();
      this.gbExportFile = new GroupBox();
      this.btnExportFile = new Button();
      this.txtExportFile = new TextBox();
      this.lbExportFile = new Label();
      this.gbExportConfig = new GroupBox();
      this.txtCurRecord = new TextBox();
      this.lbCurRecord = new Label();
      this.rbCurRecord = new RadioButton();
      this.tabImport = new TabPage();
      this.gbImportFile = new GroupBox();
      this.txtImportFile = new TextBox();
      this.lbImportFile = new Label();
      this.btnImportFile = new Button();
      this.btnImport = new Button();
      this.btnClose2 = new Button();
      this.TabControl1.SuspendLayout();
      this.tabExport.SuspendLayout();
      this.gbExportFile.SuspendLayout();
      this.gbExportConfig.SuspendLayout();
      this.tabImport.SuspendLayout();
      this.gbImportFile.SuspendLayout();
      this.SuspendLayout();
      this.TabControl1.Controls.Add((Control) this.tabExport);
      this.TabControl1.Controls.Add((Control) this.tabImport);
      this.TabControl1.Dock = DockStyle.Fill;
      TabControl tabControl1_1 = this.TabControl1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      tabControl1_1.Location = point2;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = this.TabControl1;
      Size size1 = new Size(448, 246);
      Size size2 = size1;
      tabControl1_2.Size = size2;
      this.TabControl1.TabIndex = 0;
      this.tabExport.Controls.Add((Control) this.btnClose);
      this.tabExport.Controls.Add((Control) this.btnExport);
      this.tabExport.Controls.Add((Control) this.gbExportFile);
      this.tabExport.Controls.Add((Control) this.gbExportConfig);
      TabPage tabExport1 = this.tabExport;
      point1 = new Point(4, 21);
      Point point3 = point1;
      tabExport1.Location = point3;
      this.tabExport.Name = "tabExport";
      TabPage tabExport2 = this.tabExport;
      size1 = new Size(440, 221);
      Size size3 = size1;
      tabExport2.Size = size3;
      this.tabExport.TabIndex = 0;
      this.tabExport.Text = "病历导出";
      this.btnClose.ImeMode = ImeMode.NoControl;
      Button btnClose1 = this.btnClose;
      point1 = new Point(352, 192);
      Point point4 = point1;
      btnClose1.Location = point4;
      this.btnClose.Name = "btnClose";
      Button btnClose2 = this.btnClose;
      size1 = new Size(72, 24);
      Size size4 = size1;
      btnClose2.Size = size4;
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "关闭";
      this.btnExport.ImeMode = ImeMode.NoControl;
      Button btnExport1 = this.btnExport;
      point1 = new Point(272, 192);
      Point point5 = point1;
      btnExport1.Location = point5;
      this.btnExport.Name = "btnExport";
      Button btnExport2 = this.btnExport;
      size1 = new Size(72, 24);
      Size size5 = size1;
      btnExport2.Size = size5;
      this.btnExport.TabIndex = 6;
      this.btnExport.Text = "导出";
      this.gbExportFile.Controls.Add((Control) this.btnExportFile);
      this.gbExportFile.Controls.Add((Control) this.txtExportFile);
      this.gbExportFile.Controls.Add((Control) this.lbExportFile);
      GroupBox gbExportFile1 = this.gbExportFile;
      point1 = new Point(16, 120);
      Point point6 = point1;
      gbExportFile1.Location = point6;
      this.gbExportFile.Name = "gbExportFile";
      GroupBox gbExportFile2 = this.gbExportFile;
      size1 = new Size(416, 64);
      Size size6 = size1;
      gbExportFile2.Size = size6;
      this.gbExportFile.TabIndex = 5;
      this.gbExportFile.TabStop = false;
      this.gbExportFile.Text = "导出到文件";
      this.btnExportFile.Image = (Image) resourceManager.GetObject("btnExportFile.Image");
      this.btnExportFile.ImeMode = ImeMode.NoControl;
      Button btnExportFile1 = this.btnExportFile;
      point1 = new Point(379, 24);
      Point point7 = point1;
      btnExportFile1.Location = point7;
      this.btnExportFile.Name = "btnExportFile";
      Button btnExportFile2 = this.btnExportFile;
      size1 = new Size(28, 25);
      Size size7 = size1;
      btnExportFile2.Size = size7;
      this.btnExportFile.TabIndex = 3;
      TextBox txtExportFile1 = this.txtExportFile;
      point1 = new Point(96, 26);
      Point point8 = point1;
      txtExportFile1.Location = point8;
      this.txtExportFile.Name = "txtExportFile";
      this.txtExportFile.ReadOnly = true;
      TextBox txtExportFile2 = this.txtExportFile;
      size1 = new Size(280, 21);
      Size size8 = size1;
      txtExportFile2.Size = size8;
      this.txtExportFile.TabIndex = 1;
      this.txtExportFile.Text = "";
      this.lbExportFile.ImeMode = ImeMode.NoControl;
      Label lbExportFile1 = this.lbExportFile;
      point1 = new Point(16, 32);
      Point point9 = point1;
      lbExportFile1.Location = point9;
      this.lbExportFile.Name = "lbExportFile";
      Label lbExportFile2 = this.lbExportFile;
      size1 = new Size(72, 16);
      Size size9 = size1;
      lbExportFile2.Size = size9;
      this.lbExportFile.TabIndex = 0;
      this.lbExportFile.Text = "导出文件：";
      this.gbExportConfig.Controls.Add((Control) this.txtCurRecord);
      this.gbExportConfig.Controls.Add((Control) this.lbCurRecord);
      this.gbExportConfig.Controls.Add((Control) this.rbCurRecord);
      GroupBox gbExportConfig1 = this.gbExportConfig;
      point1 = new Point(16, 16);
      Point point10 = point1;
      gbExportConfig1.Location = point10;
      this.gbExportConfig.Name = "gbExportConfig";
      GroupBox gbExportConfig2 = this.gbExportConfig;
      size1 = new Size(416, 96);
      Size size10 = size1;
      gbExportConfig2.Size = size10;
      this.gbExportConfig.TabIndex = 4;
      this.gbExportConfig.TabStop = false;
      this.gbExportConfig.Text = "设置导出条件";
      TextBox txtCurRecord1 = this.txtCurRecord;
      point1 = new Point(96, 60);
      Point point11 = point1;
      txtCurRecord1.Location = point11;
      this.txtCurRecord.Name = "txtCurRecord";
      this.txtCurRecord.ReadOnly = true;
      TextBox txtCurRecord2 = this.txtCurRecord;
      size1 = new Size(312, 21);
      Size size11 = size1;
      txtCurRecord2.Size = size11;
      this.txtCurRecord.TabIndex = 2;
      this.txtCurRecord.Text = "";
      this.lbCurRecord.ImeMode = ImeMode.NoControl;
      Label lbCurRecord1 = this.lbCurRecord;
      point1 = new Point(16, 64);
      Point point12 = point1;
      lbCurRecord1.Location = point12;
      this.lbCurRecord.Name = "lbCurRecord";
      Label lbCurRecord2 = this.lbCurRecord;
      size1 = new Size(80, 16);
      Size size12 = size1;
      lbCurRecord2.Size = size12;
      this.lbCurRecord.TabIndex = 1;
      this.lbCurRecord.Text = "当前病历：";
      this.rbCurRecord.Checked = true;
      this.rbCurRecord.ImeMode = ImeMode.NoControl;
      RadioButton rbCurRecord = this.rbCurRecord;
      point1 = new Point(16, 24);
      Point point13 = point1;
      rbCurRecord.Location = point13;
      this.rbCurRecord.Name = "rbCurRecord";
      this.rbCurRecord.TabIndex = 0;
      this.rbCurRecord.TabStop = true;
      this.rbCurRecord.Text = "导出当前病历";
      this.tabImport.Controls.Add((Control) this.btnClose2);
      this.tabImport.Controls.Add((Control) this.btnImport);
      this.tabImport.Controls.Add((Control) this.gbImportFile);
      TabPage tabImport1 = this.tabImport;
      point1 = new Point(4, 21);
      Point point14 = point1;
      tabImport1.Location = point14;
      this.tabImport.Name = "tabImport";
      TabPage tabImport2 = this.tabImport;
      size1 = new Size(440, 221);
      Size size13 = size1;
      tabImport2.Size = size13;
      this.tabImport.TabIndex = 1;
      this.tabImport.Text = "病历导入";
      this.gbImportFile.Controls.Add((Control) this.txtImportFile);
      this.gbImportFile.Controls.Add((Control) this.lbImportFile);
      this.gbImportFile.Controls.Add((Control) this.btnImportFile);
      GroupBox gbImportFile1 = this.gbImportFile;
      point1 = new Point(8, 16);
      Point point15 = point1;
      gbImportFile1.Location = point15;
      this.gbImportFile.Name = "gbImportFile";
      GroupBox gbImportFile2 = this.gbImportFile;
      size1 = new Size(424, 72);
      Size size14 = size1;
      gbImportFile2.Size = size14;
      this.gbImportFile.TabIndex = 0;
      this.gbImportFile.TabStop = false;
      this.gbImportFile.Text = "从文件导入";
      TextBox txtImportFile1 = this.txtImportFile;
      point1 = new Point(72, 32);
      Point point16 = point1;
      txtImportFile1.Location = point16;
      this.txtImportFile.Name = "txtImportFile";
      this.txtImportFile.ReadOnly = true;
      TextBox txtImportFile2 = this.txtImportFile;
      size1 = new Size(304, 21);
      Size size15 = size1;
      txtImportFile2.Size = size15;
      this.txtImportFile.TabIndex = 1;
      this.txtImportFile.Text = "";
      Label lbImportFile1 = this.lbImportFile;
      point1 = new Point(8, 36);
      Point point17 = point1;
      lbImportFile1.Location = point17;
      this.lbImportFile.Name = "lbImportFile";
      Label lbImportFile2 = this.lbImportFile;
      size1 = new Size(72, 24);
      Size size16 = size1;
      lbImportFile2.Size = size16;
      this.lbImportFile.TabIndex = 0;
      this.lbImportFile.Text = "导入文件：";
      this.btnImportFile.Image = (Image) resourceManager.GetObject("btnImportFile.Image");
      this.btnImportFile.ImeMode = ImeMode.NoControl;
      Button btnImportFile1 = this.btnImportFile;
      point1 = new Point(384, 30);
      Point point18 = point1;
      btnImportFile1.Location = point18;
      this.btnImportFile.Name = "btnImportFile";
      Button btnImportFile2 = this.btnImportFile;
      size1 = new Size(28, 25);
      Size size17 = size1;
      btnImportFile2.Size = size17;
      this.btnImportFile.TabIndex = 4;
      Button btnImport1 = this.btnImport;
      point1 = new Point(272, 192);
      Point point19 = point1;
      btnImport1.Location = point19;
      this.btnImport.Name = "btnImport";
      Button btnImport2 = this.btnImport;
      size1 = new Size(72, 24);
      Size size18 = size1;
      btnImport2.Size = size18;
      this.btnImport.TabIndex = 1;
      this.btnImport.Text = "导入";
      Button btnClose2_1 = this.btnClose2;
      point1 = new Point(352, 192);
      Point point20 = point1;
      btnClose2_1.Location = point20;
      this.btnClose2.Name = "btnClose2";
      Button btnClose2_2 = this.btnClose2;
      size1 = new Size(72, 24);
      Size size19 = size1;
      btnClose2_2.Size = size19;
      this.btnClose2.TabIndex = 2;
      this.btnClose2.Text = "关闭";
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(448, 246);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TabControl1);
      this.Name = "DataExpImpForm";
      this.Text = "病历导出导入";
      this.TabControl1.ResumeLayout(false);
      this.tabExport.ResumeLayout(false);
      this.gbExportFile.ResumeLayout(false);
      this.gbExportConfig.ResumeLayout(false);
      this.tabImport.ResumeLayout(false);
      this.gbImportFile.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void btnExportFile_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = "选择导出文件";
      saveFileDialog.FileName = this.txtCurRecord.Text;
      saveFileDialog.Filter = "XML files (*.xml)|*.xml";
      saveFileDialog.RestoreDirectory = true;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtExportFile.Text = saveFileDialog.FileName;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtExportFile.Text, "", false) == 0)
      {
        MessageManager.ShowInformationMessage("请指定导出文件名称！");
      }
      else
      {
        if (Operators.CompareString(this.m_CurInstanceID, "", false) == 0)
          MessageManager.ShowInformationMessage("当前病历没有数据可供导出！");
        string str = DataExpImpUtil.ExportXML(this.m_CurInstanceID);
        try
        {
          FileStream fileStream = File.Create(this.txtExportFile.Text);
          StreamWriter streamWriter = new StreamWriter((Stream) fileStream, Encoding.GetEncoding("UTF-8"));
          streamWriter.Write(str);
          streamWriter.Close();
          fileStream.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          MessageManager.ShowErrorMessage("写入文件失败！");
          ProjectData.ClearProjectError();
        }
        MessageManager.ShowInformationMessage("导出成功！");
      }
    }

    private void btnImportFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "选择导入文件";
      openFileDialog.Filter = "XML files (*.xml)|*.xml";
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtImportFile.Text = openFileDialog.FileName;
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(this.txtImportFile.Text);
      DataExpImpUtil.ImportXML(doc);
      MessageManager.ShowInformationMessage("导入完毕！");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnClose2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
