// Decompiled with JetBrains decompiler
// Type: SysOption.ESysOption
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SysOption
{
  [GeneratedCode("System.Xml", "2.0.50727.1433")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class ESysOption
  {
    private string isVisibleField;
    private string descriptionField;
    private string idField;
    private string nameField;
    private string optionValueField;

    public string IsVisible
    {
      get
      {
        return this.isVisibleField;
      }
      set
      {
        this.isVisibleField = value;
      }
    }

    public string Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    public string OptionValue
    {
      get
      {
        return this.optionValueField;
      }
      set
      {
        this.optionValueField = value;
      }
    }

    [DebuggerNonUserCode]
    public ESysOption()
    {
    }
  }
}
