// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.Quality.QuaDataListUtil
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.webclient.dataaccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace dhcc.epr.webclient.Quality
{
  public class QuaDataListUtil
  {
    private QuaExamItemCollection ExamItemCollection;
    private string _admId;
    private string _action;
    private string _templateId;
    private string _instanceDataIDs;
    private string _printTemplateDocId;

    public string AdmId
    {
      set
      {
        this._admId = value;
      }
    }

    public string Action
    {
      set
      {
        this._action = value;
      }
    }

    public string TemplateId
    {
      set
      {
        this._templateId = value;
      }
    }

    public string InstanceDataIDs
    {
      set
      {
        this._instanceDataIDs = value;
      }
    }

    public string PrintTemplateDocId
    {
      set
      {
        this._printTemplateDocId = value;
      }
    }

    public QuaDataListUtil(string parAdmId, string parAction, string parTemplateId, string parInstanceDataIDs, string parPrintTemplateDocId)
    {
      this.ExamItemCollection = new QuaExamItemCollection();
      this.AdmId = parAdmId;
      this.Action = parAction;
      this.TemplateId = parTemplateId;
      this.InstanceDataIDs = parInstanceDataIDs;
      this.PrintTemplateDocId = parPrintTemplateDocId;
    }

    private QuaExamItemCollection GetQuaExamListFromTemp(string strJob)
    {
      try
      {
        DataSet dataByQueryName = WebServiceLayer.GateWayAccess.GetDataByQueryName("EPRmeta.Quality.QualityExamSet", "GetQuaExamResult", strJob);
        return this.ParseQuaExamListData(ref dataByQueryName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    private QuaExamItemCollection ParseQuaExamListData(ref DataSet obj)
    {
      QuaExamItemCollection examItemCollection = new QuaExamItemCollection();
      if (obj != null && obj.Tables.Count > 0 && obj.Tables[0].Rows.Count > 0)
      {
        int num1 = 0;
        int num2 = checked (obj.Tables[0].Rows.Count - 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          QuaExamItem quaExamItem = new QuaExamItem();
          int num3 = 0;
          int num4 = checked (obj.Tables[0].Columns.Count - 1);
          int index2 = num3;
          while (index2 <= num4)
          {
            string columnName = obj.Tables[0].Columns[index2].ColumnName;
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj.Tables[0].Rows[index1][columnName])))
              quaExamItem.BindDataExamListData(columnName, Conversions.ToString(obj.Tables[0].Rows[index1][columnName]));
            checked { ++index2; }
          }
          examItemCollection.Add(quaExamItem);
          checked { ++index1; }
        }
      }
      return examItemCollection;
    }

    private string SetQuaExamListFromTemp()
    {
      try
      {
        if (!QualityCheck.QualityVersion().Equals("Old"))
          return WebServiceLayer.QualityAccess.GetRunTimeQuality(this._admId, this._action, this._templateId, this._instanceDataIDs, this._printTemplateDocId);
        string lower = this._action.ToLower();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "save", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "print", false) != 0)
          return (string) null;
        return WebServiceLayer.QualityAccess.CheckTemplate(this._templateId, this._admId);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    public QuaExamItemCollection CheckTemplate()
    {
      try
      {
        string strJob = this.SetQuaExamListFromTemp();
        if (strJob == null || strJob.Equals(string.Empty))
          return (QuaExamItemCollection) null;
        return this.GetQuaExamListFromTemp(strJob);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    public string GetControlType()
    {
      try
      {
        if (QualityCheck.QualityVersion().Equals("Old"))
          return "0";
        return WebServiceLayer.QualityAccess.GetControlType(this._templateId, this._action);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) ("获取质控方式错误。\r\n\r\n" + exception.Message), MsgBoxStyle.OkOnly, (object) null);
        throw exception;
      }
    }
  }
}
