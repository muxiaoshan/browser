// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.onestepprint.PrintJobEventArgs
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;

namespace dhcc.epr.webclient.onestepprint
{
  public class PrintJobEventArgs : EventArgs
  {
    public string JobInfo;

    public PrintJobEventArgs()
    {
      this.JobInfo = string.Empty;
    }

    public PrintJobEventArgs(string jobInfo)
    {
      this.JobInfo = string.Empty;
      this.JobInfo = jobInfo;
    }
  }
}
