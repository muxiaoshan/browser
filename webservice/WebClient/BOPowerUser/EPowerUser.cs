// Decompiled with JetBrains decompiler
// Type: BOPowerUser.EPowerUser
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace BOPowerUser
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.1433")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [DesignerCategory("code")]
  [Serializable]
  public class EPowerUser
  {
    private string childUsersField;
    private string controlByGroupField;
    private string isValidField;
    private string sSGroupIDField;
    private string userIDField;
    private string idField;
    private string userLevelField;

    public string ChildUsers
    {
      get
      {
        return this.childUsersField;
      }
      set
      {
        this.childUsersField = value;
      }
    }

    public string ControlByGroup
    {
      get
      {
        return this.controlByGroupField;
      }
      set
      {
        this.controlByGroupField = value;
      }
    }

    public string IsValid
    {
      get
      {
        return this.isValidField;
      }
      set
      {
        this.isValidField = value;
      }
    }

    public string SSGroupID
    {
      get
      {
        return this.sSGroupIDField;
      }
      set
      {
        this.sSGroupIDField = value;
      }
    }

    public string UserID
    {
      get
      {
        return this.userIDField;
      }
      set
      {
        this.userIDField = value;
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

    public string UserLevel
    {
      get
      {
        return this.userLevelField;
      }
      set
      {
        this.userLevelField = value;
      }
    }

    [DebuggerNonUserCode]
    public EPowerUser()
    {
    }
  }
}
