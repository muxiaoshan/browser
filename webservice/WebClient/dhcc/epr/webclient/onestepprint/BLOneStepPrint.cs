// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.onestepprint.BLOneStepPrint
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.design.printreview;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using dhcc.epr.webclient.dataaccess;
using EPRTemplateCategoryData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace dhcc.epr.webclient.onestepprint
{
  public class BLOneStepPrint
  {
    public static string PrintFlagPause = "Pause";
    public static string PrintFlagBegin = "Begin";
    private string m_PrintParams;
    private ArrayList m_PrintParamArrList;
    private ArrayList m_PrintInfoArrList;
    private string m_PrintFlag;
    private int m_CurrentPrintIndex;

    public string PrintParams
    {
      get
      {
        return this.m_PrintParams;
      }
      set
      {
        this.m_PrintParams = value;
        this.Init();
      }
    }

    public event BLOneStepPrint.PrintPausedEventHandler PrintPaused;

    public event BLOneStepPrint.PrintStartedEventHandler PrintStarted;

    public event BLOneStepPrint.PrintFinishedEventHandler PrintFinished;

    public event BLOneStepPrint.OnePrintJobFinishedEventHandler OnePrintJobFinished;

    public event BLOneStepPrint.OnePrintJobStartedEventHandler OnePrintJobStarted;

    public BLOneStepPrint()
    {
      this.m_PrintParams = string.Empty;
      this.m_PrintParamArrList = (ArrayList) null;
      this.m_PrintInfoArrList = (ArrayList) null;
      this.m_PrintFlag = string.Empty;
      this.m_CurrentPrintIndex = 0;
    }

    public void StartPrint()
    {
      this.m_PrintFlag = BLOneStepPrint.PrintFlagBegin;
      PrintJobEventArgs e = new PrintJobEventArgs();
      e.JobInfo = "打印正在启动......";
      BLOneStepPrint.PrintStartedEventHandler printStartedEvent = this.PrintStartedEvent;
      if (printStartedEvent != null)
        printStartedEvent((object) this, e);
      if (!this.IsPrintParamsValid())
        throw new Exception("打印参数错误!参数为：" + this.m_PrintParams);
      int currentPrintIndex = this.m_CurrentPrintIndex;
      int num = checked (this.m_PrintParamArrList.Count - 1);
      int index = currentPrintIndex;
      while (index <= num)
      {
        this.m_CurrentPrintIndex = index;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.m_PrintFlag, BLOneStepPrint.PrintFlagPause, false) == 0)
        {
          e.JobInfo = "打印已暂停，当前打印至：" + this.m_PrintInfoArrList[index].ToString();
          BLOneStepPrint.PrintPausedEventHandler printPausedEvent = this.PrintPausedEvent;
          if (printPausedEvent == null)
            return;
          printPausedEvent((object) this, e);
          return;
        }
        e.JobInfo = "开始打印：" + this.m_PrintInfoArrList[index].ToString();
        BLOneStepPrint.OnePrintJobStartedEventHandler printJobStartedEvent = this.OnePrintJobStartedEvent;
        if (printJobStartedEvent != null)
          printJobStartedEvent((object) this, e);
        this.ExeOnePrintJob(Convert.ToString(RuntimeHelpers.GetObjectValue(this.m_PrintParamArrList[index])));
        e.JobInfo = "完成打印：" + this.m_PrintInfoArrList[index].ToString();
        BLOneStepPrint.OnePrintJobFinishedEventHandler jobFinishedEvent = this.OnePrintJobFinishedEvent;
        if (jobFinishedEvent != null)
          jobFinishedEvent((object) this, e);
        checked { ++index; }
      }
      e.JobInfo = "打印全部完成！";
      BLOneStepPrint.PrintFinishedEventHandler printFinishedEvent = this.PrintFinishedEvent;
      if (printFinishedEvent == null)
        return;
      printFinishedEvent((object) this, e);
    }

    public void PausePrint()
    {
      if (this.m_CurrentPrintIndex >= checked (this.m_PrintParamArrList.Count - 1))
      {
        BLOneStepPrint.PrintFinishedEventHandler printFinishedEvent = this.PrintFinishedEvent;
        if (printFinishedEvent == null)
          return;
        printFinishedEvent((object) this, new PrintJobEventArgs("打印全部完成！"));
      }
      else
        this.m_PrintFlag = BLOneStepPrint.PrintFlagPause;
    }

    public void RePrint()
    {
      this.InitPrintStatus();
      this.StartPrint();
    }

    private void Init()
    {
      this.InitPrintParam();
      this.InitPrintStatus();
    }

    private void InitPrintStatus()
    {
      this.m_PrintFlag = string.Empty;
      this.m_CurrentPrintIndex = 0;
    }

    private void InitPrintParam()
    {
      this.SetPrintOrder();
      this.GetPrintInfo();
    }

    private void SetPrintOrder()
    {
      this.m_PrintParamArrList = new ArrayList();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.m_PrintParams, string.Empty, false) == 0)
        return;
      string sysOptionValue = SysOptionManager.GetSysOptionValue("PrtTplOrder", "NULL");
      string[] strArray = this.m_PrintParams.Split('!');
      int num1 = -1;
      int num2 = 0;
      int num3 = checked (strArray.Length - 2);
      int index = num2;
      while (index <= num3)
      {
        if (num1 == index)
        {
          num1 = -1;
        }
        else
        {
          string str1 = strArray[index].Split('^')[4];
          string str2 = strArray[checked (index + 1)].Split('^')[4];
          if (sysOptionValue.IndexOf(str1 + "^" + str2) > -1)
          {
            this.m_PrintParamArrList.Add((object) (strArray[index] + "!" + strArray[checked (index + 1)]));
            num1 = checked (index + 1);
          }
          else
          {
            this.m_PrintParamArrList.Add((object) strArray[index]);
            num1 = -1;
          }
        }
        checked { ++index; }
      }
      if (num1 == checked (strArray.Length - 1))
        return;
      this.m_PrintParamArrList.Add((object) strArray[checked (strArray.Length - 1)]);
    }

    private void GetPrintInfo()
    {
      this.m_PrintInfoArrList = new ArrayList();
      EEPRTplCateInfoDataset categoryInfoDataset = this.GetCategoryInfoDataset();
      if (categoryInfoDataset == null)
        return;
      int num1 = 0;
      int num2 = checked (this.m_PrintParamArrList.Count - 1);
      int index1 = num1;
      while (index1 <= num2)
      {
        string[] strArray = Convert.ToString(RuntimeHelpers.GetObjectValue(this.m_PrintParamArrList[index1])).Split('!');
        string str = string.Empty;
        int num3 = 0;
        int num4 = checked (strArray.Length - 1);
        int index2 = num3;
        while (index2 <= num4)
        {
          string printDocID = strArray[index2].ToString().Split('^')[5];
          str = index2 != 0 ? str + " + " + this.GetCaterogyInfoById(printDocID, categoryInfoDataset) : this.GetCaterogyInfoById(printDocID, categoryInfoDataset);
          checked { ++index2; }
        }
        this.m_PrintInfoArrList.Add((object) str);
        checked { ++index1; }
      }
    }

    private EEPRTplCateInfoDataset GetCategoryInfoDataset()
    {
      if (!this.IsPrintParamsValid())
        return (EEPRTplCateInfoDataset) null;
      string str = string.Empty;
      string[] strArray = this.m_PrintParams.Split('!');
      int num1 = 0;
      int num2 = checked (strArray.Length - 1);
      int index = num1;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) == 0)
          str = strArray[index].Split('^')[5];
        else
          str = str + "^" + strArray[index].Split('^')[5];
        checked { ++index; }
      }
      return WebServiceLayer.EPRTemplateCategoryAccess.GetCategoryInfoByIDs(str);
    }

    private string GetCaterogyInfoById(string printDocID, EEPRTplCateInfoDataset ds)
    {
      DataTable table = ds.Tables[0];
      int count = table.Rows.Count;
      int num1 = 0;
      int num2 = checked (count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (table.Rows[index]["EPRTemplateCategoryID"] != null && !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(table.Rows[index]["EPRTemplateCategoryID"], (object) printDocID, false))
        {
          if (table.Rows[index]["FullParentName"] == null)
            return string.Empty;
          return table.Rows[index]["FullParentName"].ToString();
        }
        checked { ++index; }
      }
      return string.Empty;
    }

    private bool IsPrintParamsValid()
    {
      if (this.m_PrintParams == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.m_PrintParams, string.Empty, false) == 0)
        return false;
      string[] strArray = this.m_PrintParams.Split('!');
      int num1 = 0;
      int num2 = checked (strArray.Length - 1);
      int index = num1;
      while (index <= num2)
      {
        if (strArray[index].Split('^').Length != 7)
          return false;
        checked { ++index; }
      }
      return true;
    }

    private void ExeOnePrintJob(string printPara)
    {
      try
      {
        new PrintClient().OneStepPrint(printPara);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage(exception.Message + "\r" + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
    }

    public delegate void PrintPausedEventHandler(object sender, PrintJobEventArgs e);

    public delegate void PrintStartedEventHandler(object sender, PrintJobEventArgs e);

    public delegate void PrintFinishedEventHandler(object sender, PrintJobEventArgs e);

    public delegate void OnePrintJobFinishedEventHandler(object sender, PrintJobEventArgs e);

    public delegate void OnePrintJobStartedEventHandler(object sender, PrintJobEventArgs e);
  }
}
