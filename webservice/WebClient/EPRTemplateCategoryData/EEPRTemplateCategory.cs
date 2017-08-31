// Decompiled with JetBrains decompiler
// Type: EPRTemplateCategoryData.EEPRTemplateCategory
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.3053")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [Serializable]
  public class EEPRTemplateCategory
  {
    private string categoryNameField;
    private string categoryTypeField;
    private string parentCategoryIDField;
    private long categorySeqField;
    private bool categorySeqFieldSpecified;
    private string bindPrnTemplateIDField;
    private string bindPrnTemplateCategoryIDField;

    public string CategoryName
    {
      get
      {
        return this.categoryNameField;
      }
      set
      {
        this.categoryNameField = value;
      }
    }

    public string CategoryType
    {
      get
      {
        return this.categoryTypeField;
      }
      set
      {
        this.categoryTypeField = value;
      }
    }

    public string ParentCategoryID
    {
      get
      {
        return this.parentCategoryIDField;
      }
      set
      {
        this.parentCategoryIDField = value;
      }
    }

    public long CategorySeq
    {
      get
      {
        return this.categorySeqField;
      }
      set
      {
        this.categorySeqField = value;
      }
    }

    [XmlIgnore]
    public bool CategorySeqSpecified
    {
      get
      {
        return this.categorySeqFieldSpecified;
      }
      set
      {
        this.categorySeqFieldSpecified = value;
      }
    }

    public string BindPrnTemplateID
    {
      get
      {
        return this.bindPrnTemplateIDField;
      }
      set
      {
        this.bindPrnTemplateIDField = value;
      }
    }

    public string BindPrnTemplateCategoryID
    {
      get
      {
        return this.bindPrnTemplateCategoryIDField;
      }
      set
      {
        this.bindPrnTemplateCategoryIDField = value;
      }
    }

    [DebuggerNonUserCode]
    public EEPRTemplateCategory()
    {
    }
  }
}
