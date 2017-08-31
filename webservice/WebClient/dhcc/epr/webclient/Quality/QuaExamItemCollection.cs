// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Quality.QuaExamItemCollection
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace dhcc.epr.webclient.Quality
{
  public class QuaExamItemCollection : CollectionBase
  {
    [IndexerName("Items")]
    public QuaExamItem this[int index]
    {
      get
      {
        return (QuaExamItem) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    public QuaExamItemCollection()
    {
    }

    public void Add(QuaExamItem value)
    {
      this.List.Add((object) value);
    }

    public void Add(QuaExamItem parent, QuaExamItem value)
    {
      this.List.Add((object) value);
    }

    public bool Contains(QuaExamItem value)
    {
      return this.List.Contains((object) value);
    }

    public int IndexOf(QuaExamItem value)
    {
      return this.List.IndexOf((object) value);
    }

    public void Insert(int index, QuaExamItem value)
    {
      if (this.List.Count == index)
        this.List.Add((object) value);
      else
        this.List.Insert(index, (object) value);
    }

    public void Remove(QuaExamItem value)
    {
      this.List.Remove((object) value);
    }
  }
}
