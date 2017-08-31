// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Privilege.UserAuthentication
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using BOPowerUser;
using dhcc.epr.webclient.dataaccess;
using System.Diagnostics;

namespace dhcc.epr.webclient.Privilege
{
  public class UserAuthentication
  {
    [DebuggerNonUserCode]
    public UserAuthentication()
    {
    }

    public static string CheckUserLevel(string parUserId)
    {
      EPowerUser byId = WebServiceLayer.PowerUserAccess.GetById(parUserId);
      if (byId == null || byId.UserLevel.Equals(string.Empty))
        return "Resident";
      return byId.UserLevel;
    }
  }
}
