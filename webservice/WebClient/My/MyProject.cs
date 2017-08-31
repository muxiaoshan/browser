// Decompiled with JetBrains decompiler
// Type: My.MyProject
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using BOCustomDictory;
using BOPowerUser;
using DigitalSignService;
using EPRTemplateCategoryData;
using GateWayData;
using InstanceData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;
using PrivRule;
using SysOption;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace My
{
  [StandardModule]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [HideModuleName]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      public BODigitalSignature m_BODigitalSignature;
      public CustomDictoryInfo m_CustomDictoryInfo;
      public DataGatewayInfo m_DataGatewayInfo;
      public EPRTemplateCategory m_EPRTemplateCategory;
      public InstanceDataInfo m_InstanceDataInfo;
      public PrivilegeBOPowerUser m_PrivilegeBOPowerUser;
      public PrivilegePrivRule m_PrivilegePrivRule;
      public QualityService.QualityService m_QualityService;
      public SysOptionInfo m_SysOptionInfo;

      public BODigitalSignature BODigitalSignature
      {
        [DebuggerNonUserCode] get
        {
          this.m_BODigitalSignature = MyProject.MyWebServices.Create__Instance__<BODigitalSignature>(this.m_BODigitalSignature);
          return this.m_BODigitalSignature;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_BODigitalSignature)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<BODigitalSignature>(ref this.m_BODigitalSignature);
        }
      }

      public CustomDictoryInfo CustomDictoryInfo
      {
        [DebuggerNonUserCode] get
        {
          this.m_CustomDictoryInfo = MyProject.MyWebServices.Create__Instance__<CustomDictoryInfo>(this.m_CustomDictoryInfo);
          return this.m_CustomDictoryInfo;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_CustomDictoryInfo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<CustomDictoryInfo>(ref this.m_CustomDictoryInfo);
        }
      }

      public DataGatewayInfo DataGatewayInfo
      {
        [DebuggerNonUserCode] get
        {
          this.m_DataGatewayInfo = MyProject.MyWebServices.Create__Instance__<DataGatewayInfo>(this.m_DataGatewayInfo);
          return this.m_DataGatewayInfo;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_DataGatewayInfo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<DataGatewayInfo>(ref this.m_DataGatewayInfo);
        }
      }

      public EPRTemplateCategory EPRTemplateCategory
      {
        [DebuggerNonUserCode] get
        {
          this.m_EPRTemplateCategory = MyProject.MyWebServices.Create__Instance__<EPRTemplateCategory>(this.m_EPRTemplateCategory);
          return this.m_EPRTemplateCategory;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_EPRTemplateCategory)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<EPRTemplateCategory>(ref this.m_EPRTemplateCategory);
        }
      }

      public InstanceDataInfo InstanceDataInfo
      {
        [DebuggerNonUserCode] get
        {
          this.m_InstanceDataInfo = MyProject.MyWebServices.Create__Instance__<InstanceDataInfo>(this.m_InstanceDataInfo);
          return this.m_InstanceDataInfo;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_InstanceDataInfo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<InstanceDataInfo>(ref this.m_InstanceDataInfo);
        }
      }

      public PrivilegeBOPowerUser PrivilegeBOPowerUser
      {
        [DebuggerNonUserCode] get
        {
          this.m_PrivilegeBOPowerUser = MyProject.MyWebServices.Create__Instance__<PrivilegeBOPowerUser>(this.m_PrivilegeBOPowerUser);
          return this.m_PrivilegeBOPowerUser;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_PrivilegeBOPowerUser)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<PrivilegeBOPowerUser>(ref this.m_PrivilegeBOPowerUser);
        }
      }

      public PrivilegePrivRule PrivilegePrivRule
      {
        [DebuggerNonUserCode] get
        {
          this.m_PrivilegePrivRule = MyProject.MyWebServices.Create__Instance__<PrivilegePrivRule>(this.m_PrivilegePrivRule);
          return this.m_PrivilegePrivRule;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_PrivilegePrivRule)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<PrivilegePrivRule>(ref this.m_PrivilegePrivRule);
        }
      }

      public QualityService.QualityService QualityService
      {
        [DebuggerNonUserCode] get
        {
          this.m_QualityService = MyProject.MyWebServices.Create__Instance__<QualityService.QualityService>(this.m_QualityService);
          return this.m_QualityService;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_QualityService)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<QualityService.QualityService>(ref this.m_QualityService);
        }
      }

      public SysOptionInfo SysOptionInfo
      {
        [DebuggerNonUserCode] get
        {
          this.m_SysOptionInfo = MyProject.MyWebServices.Create__Instance__<SysOptionInfo>(this.m_SysOptionInfo);
          return this.m_SysOptionInfo;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_SysOptionInfo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SysOptionInfo>(ref this.m_SysOptionInfo);
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return Activator.CreateInstance<T>();
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      private readonly ContextValue<T> m_Context;

      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          T instance = this.m_Context.Value;
          if ((object) instance == null)
          {
            instance = Activator.CreateInstance<T>();
            this.m_Context.Value = instance;
          }
          return instance;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
        this.m_Context = new ContextValue<T>();
      }
    }
  }
}
