// Decompiled with JetBrains decompiler
// Type: PrivRule.PairOfParsePrivRuleByIDResultKeyString
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
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [GeneratedCode("System.Xml", "2.0.50727.1433")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class PairOfParsePrivRuleByIDResultKeyString
  {
    private string parsePrivRuleByIDResultKeyField;
    private string valueField;

    [XmlAttribute]
    public string ParsePrivRuleByIDResultKey
    {
      get
      {
        return this.parsePrivRuleByIDResultKeyField;
      }
      set
      {
        this.parsePrivRuleByIDResultKeyField = value;
      }
    }

    [XmlText]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    [DebuggerNonUserCode]
    public PairOfParsePrivRuleByIDResultKeyString()
    {
    }
  }
}
