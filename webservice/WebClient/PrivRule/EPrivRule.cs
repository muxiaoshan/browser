// Decompiled with JetBrains decompiler
// Type: PrivRule.EPrivRule
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PrivRule
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.1433")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [Serializable]
  public class EPrivRule
  {
    private string nameField;
    private string codeField;
    private string idField;
    private string validField;
    private string privRuleTypeDRField;

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

    public string Code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
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

    public string Valid
    {
      get
      {
        return this.validField;
      }
      set
      {
        this.validField = value;
      }
    }

    public string PrivRuleTypeDR
    {
      get
      {
        return this.privRuleTypeDRField;
      }
      set
      {
        this.privRuleTypeDRField = value;
      }
    }

    [DebuggerNonUserCode]
    public EPrivRule()
    {
    }
  }
}
