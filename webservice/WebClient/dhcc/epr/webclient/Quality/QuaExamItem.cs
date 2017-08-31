// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Quality.QuaExamItem
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

namespace dhcc.epr.webclient.Quality
{
  public class QuaExamItem
  {
    public const string QuaExamItemRuleDr = "RuleDr";
    public const string QuaExamItemRuleDesc = "RuleDesc";
    public const string QuaExamItemSectionDr = "SectionDr";
    public const string QuaExamItemSectionDesc = "SectionDesc";
    public const string QuaExamItemEntryDr = "EntryDr";
    public const string QuaExamItemEntryDesc = "EntryDesc";
    public const string QuaExamItemExamItem = "ExamItem";
    public const string QuaExamItemACRDesc = "ACRDesc";
    public string m_RuleDr;
    public string m_RuleDesc;
    public string m_SectionDr;
    public string m_SectionDesc;
    public string m_EntryDr;
    public string m_EntryDesc;
    public string m_ExamItem;
    public string m_ACRDesc;

    public string RuleDr
    {
      get
      {
        return this.m_RuleDr;
      }
      set
      {
        this.m_RuleDr = value;
      }
    }

    public string RuleDesc
    {
      get
      {
        return this.m_RuleDesc;
      }
      set
      {
        this.m_RuleDesc = value;
      }
    }

    public string SectionDr
    {
      get
      {
        return this.m_SectionDr;
      }
      set
      {
        this.m_RuleDesc = value;
      }
    }

    public string SectionDesc
    {
      get
      {
        return this.m_SectionDesc;
      }
      set
      {
        this.m_SectionDesc = value;
      }
    }

    public string EntryDr
    {
      get
      {
        return this.m_EntryDr;
      }
      set
      {
        this.m_EntryDr = value;
      }
    }

    public string EntryDesc
    {
      get
      {
        return this.m_EntryDesc;
      }
      set
      {
        this.m_EntryDesc = value;
      }
    }

    public string ExamItem
    {
      get
      {
        return this.m_ExamItem;
      }
      set
      {
        this.m_ExamItem = value;
      }
    }

    public string ACRDesc
    {
      get
      {
        return this.m_ACRDesc;
      }
      set
      {
        this.m_ACRDesc = value;
      }
    }

    [DebuggerNonUserCode]
    public QuaExamItem()
    {
    }

    public void BindDataExamListData(string ItemCode, string ItemValue)
    {
      string Left = ItemCode;
      if (Operators.CompareString(Left, "RuleDr", false) == 0)
        this.RuleDr = ItemValue;
      else if (Operators.CompareString(Left, "RuleDesc", false) == 0)
        this.RuleDesc = ItemValue;
      else if (Operators.CompareString(Left, "SectionDr", false) == 0)
        this.SectionDr = ItemValue;
      else if (Operators.CompareString(Left, "SectionDesc", false) == 0)
        this.SectionDesc = ItemValue;
      else if (Operators.CompareString(Left, "EntryDr", false) == 0)
        this.EntryDr = ItemValue;
      else if (Operators.CompareString(Left, "EntryDesc", false) == 0)
        this.EntryDesc = ItemValue;
      else if (Operators.CompareString(Left, "ExamItem", false) == 0)
      {
        this.ExamItem = ItemValue;
      }
      else
      {
        if (Operators.CompareString(Left, "ACRDesc", false) != 0)
          return;
        this.ACRDesc = ItemValue;
      }
    }
  }
}
