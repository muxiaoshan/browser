﻿// Decompiled with JetBrains decompiler
// Type: InstanceData.SaveMultipleDataCompletedEventArgs
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace InstanceData
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  public class SaveMultipleDataCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    public EInstanceData Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (EInstanceData) this.results[0];
      }
    }

    public EMixInstanceLog AEMixInstanceLog
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (EMixInstanceLog) this.results[1];
      }
    }

    public string AErrorMessage
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return Conversions.ToString(this.results[2]);
      }
    }

    internal SaveMultipleDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
    {
      this.results = results;
    }
  }
}