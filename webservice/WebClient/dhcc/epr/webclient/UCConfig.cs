// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.UCConfig
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.systemframework;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class UCConfig : UserControl
  {
    private IContainer components;

    public string URL
    {
      get
      {
        return Configuration.get_DataServiceUrl();
      }
      set
      {
        Configuration.set_DataServiceUrl(value);
      }
    }

    public string FormURL
    {
      get
      {
        return Configuration.get_FormServiceUrl();
      }
      set
      {
        Configuration.set_FormServiceUrl(value);
      }
    }

    public string GlobalValue1
    {
      get
      {
        return string.Empty;
      }
      set
      {
        this.SetGlobalValue(value);
      }
    }

    public string GlobalValue2
    {
      get
      {
        return string.Empty;
      }
      set
      {
        this.SetGlobalValue(value);
      }
    }

    public UCConfig()
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
      this.Name = "UCConfig";
      this.Size = new Size(8, 8);
    }

    private void SetGlobalValue(string value)
    {
      if (value.Split('^').Length != 2)
        return;
      GlobalValues.AddKeyValue(value.Split('^')[0], value.Split('^')[1]);
    }
  }
}
