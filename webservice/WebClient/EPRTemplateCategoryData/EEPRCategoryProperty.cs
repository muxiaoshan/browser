// Decompiled with JetBrains decompiler
// Type: EPRTemplateCategoryData.EEPRCategoryProperty
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EPRTemplateCategoryData
{
  [GeneratedCode("System.Xml", "2.0.50727.3053")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class EEPRCategoryProperty
  {
    private string nameField;
    private string necessaryTemplateField;
    private string resourceDirField;
    private string nodeRuleField;

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

    public string NecessaryTemplate
    {
      get
      {
        return this.necessaryTemplateField;
      }
      set
      {
        this.necessaryTemplateField = value;
      }
    }

    public string ResourceDir
    {
      get
      {
        return this.resourceDirField;
      }
      set
      {
        this.resourceDirField = value;
      }
    }

    public string NodeRule
    {
      get
      {
        return this.nodeRuleField;
      }
      set
      {
        this.nodeRuleField = value;
      }
    }

    [DebuggerNonUserCode]
    public EEPRCategoryProperty()
    {
    }
  }
}
