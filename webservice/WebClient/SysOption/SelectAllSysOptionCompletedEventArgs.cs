﻿// Decompiled with JetBrains decompiler
// Type: SysOption.SelectAllSysOptionCompletedEventArgs
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SysOption
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.1433")]
  [DesignerCategory("code")]
  public class SelectAllSysOptionCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    public ESysOptionDataset Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ESysOptionDataset) this.results[0];
      }
    }

    internal SelectAllSysOptionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
    {
      this.results = results;
    }
  }
}