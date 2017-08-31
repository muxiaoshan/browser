// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.UCTemplateList
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.design.printlink;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class UCTemplateList : UserControl
  {
    private IContainer components;
    [AccessedThroughProperty("TemplateList")]
    private TemplateList _TemplateList;

    private virtual TemplateList TemplateList
    {
      [DebuggerNonUserCode] get
      {
        return this._TemplateList;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TemplateList = value;
      }
    }

    public string TemplateID
    {
      get
      {
        return this.TemplateList.get_TemplateID();
      }
      set
      {
        this.TemplateList.set_TemplateID(value);
      }
    }

    public string TemplateName
    {
      get
      {
        return this.TemplateList.get_TemplateName();
      }
      set
      {
        this.TemplateList.set_TemplateName(value);
      }
    }

    public string CategoryID
    {
      get
      {
        return this.TemplateList.get_CategoryID();
      }
      set
      {
        this.TemplateList.set_CategoryID(value);
      }
    }

    public string EpisodeID
    {
      get
      {
        return this.TemplateList.get_EpisodeID();
      }
      set
      {
        this.TemplateList.set_EpisodeID(value);
      }
    }

    public UCTemplateList()
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
      this.Name = "UCTemplateList";
      this.Size = new Size(250, 300);
    }

    public void Init()
    {
      this.TemplateList = new TemplateList();
      ((Control) this.TemplateList).Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.TemplateList);
    }
  }
}
