// Decompiled with JetBrains decompiler
// Type: InstanceData.EMixInstanceLog
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace InstanceData
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [GeneratedCode("System.Xml", "2.0.50727.3053")]
  [DesignerCategory("code")]
  [Serializable]
  public class EMixInstanceLog
  {
    private string idField;
    private string actionField;
    private string operateDateField;
    private string finalStatusField;
    private string initStatusField;
    private string operateTimeField;
    private string operateUserIDField;
    private string operateMachineIPField;
    private string realOperateUserIDField;
    private string operateUserNameField;
    private string isNewFrameworkField;
    private string episodeIDField;
    private string printTemplateDocIDField;
    private string templateDocIDField;
    private string stateInfoField;

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

    public string Action
    {
      get
      {
        return this.actionField;
      }
      set
      {
        this.actionField = value;
      }
    }

    public string OperateDate
    {
      get
      {
        return this.operateDateField;
      }
      set
      {
        this.operateDateField = value;
      }
    }

    public string FinalStatus
    {
      get
      {
        return this.finalStatusField;
      }
      set
      {
        this.finalStatusField = value;
      }
    }

    public string InitStatus
    {
      get
      {
        return this.initStatusField;
      }
      set
      {
        this.initStatusField = value;
      }
    }

    public string OperateTime
    {
      get
      {
        return this.operateTimeField;
      }
      set
      {
        this.operateTimeField = value;
      }
    }

    public string OperateUserID
    {
      get
      {
        return this.operateUserIDField;
      }
      set
      {
        this.operateUserIDField = value;
      }
    }

    public string OperateMachineIP
    {
      get
      {
        return this.operateMachineIPField;
      }
      set
      {
        this.operateMachineIPField = value;
      }
    }

    public string RealOperateUserID
    {
      get
      {
        return this.realOperateUserIDField;
      }
      set
      {
        this.realOperateUserIDField = value;
      }
    }

    public string OperateUserName
    {
      get
      {
        return this.operateUserNameField;
      }
      set
      {
        this.operateUserNameField = value;
      }
    }

    public string IsNewFramework
    {
      get
      {
        return this.isNewFrameworkField;
      }
      set
      {
        this.isNewFrameworkField = value;
      }
    }

    public string EpisodeID
    {
      get
      {
        return this.episodeIDField;
      }
      set
      {
        this.episodeIDField = value;
      }
    }

    public string PrintTemplateDocID
    {
      get
      {
        return this.printTemplateDocIDField;
      }
      set
      {
        this.printTemplateDocIDField = value;
      }
    }

    public string TemplateDocID
    {
      get
      {
        return this.templateDocIDField;
      }
      set
      {
        this.templateDocIDField = value;
      }
    }

    public string StateInfo
    {
      get
      {
        return this.stateInfoField;
      }
      set
      {
        this.stateInfoField = value;
      }
    }

    [DebuggerNonUserCode]
    public EMixInstanceLog()
    {
    }
  }
}
