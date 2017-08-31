// Decompiled with JetBrains decompiler
// Type: InstanceData.ReStreamData
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.3053")]
  [XmlType(Namespace = "http://www.dhcc.com.cn/epr/metaservice")]
  [Serializable]
  public class ReStreamData
  {
    private string streamDataField;

    public string StreamData
    {
      get
      {
        return this.streamDataField;
      }
      set
      {
        this.streamDataField = value;
      }
    }

    [DebuggerNonUserCode]
    public ReStreamData()
    {
    }
  }
}
