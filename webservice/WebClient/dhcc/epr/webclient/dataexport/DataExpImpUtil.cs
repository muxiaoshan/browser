// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.dataexport.DataExpImpUtil
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.systemframework;
using dhcc.epr.webclient.dataaccess;
using InstanceData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.webclient.dataexport
{
  public class DataExpImpUtil
  {
    [DebuggerNonUserCode]
    public DataExpImpUtil()
    {
    }

    public static string ExportXML(string instanceID)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string[] strArray = instanceID.Split('^');
      stringBuilder.Append("<InstanceCollection>");
      int num1 = 0;
      int num2 = checked (strArray.Length - 1);
      int index = num1;
      while (index <= num2)
      {
        string instanceXml = DataExpImpUtil.GetInstanceXML(strArray[index].ToString());
        if (Operators.CompareString(instanceXml, "", false) != 0)
        {
          stringBuilder.Append("<InstanceInfo>");
          stringBuilder.Append("<InstanceID>" + strArray[index].ToString() + "</InstanceID>");
          stringBuilder.Append(instanceXml);
          stringBuilder.Append("</InstanceInfo>");
        }
        checked { ++index; }
      }
      stringBuilder.Append("</InstanceCollection>");
      return stringBuilder.ToString();
    }

    public static bool ImportXML(string xmlStr)
    {
      return true;
    }

    public static bool ImportXML(XmlDocument doc)
    {
      XmlNodeList xmlNodeList = doc.SelectNodes("//InstanceCollection/InstanceInfo");
      int num1 = 0;
      int num2 = checked (xmlNodeList.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        XmlNode xmlNode = xmlNodeList.Item(index);
        DataExpImpUtil.ImpInstanceXML(xmlNode.SelectSingleNode("//InstanceInfo/InstanceID").InnerText, xmlNode.SelectSingleNode("//InstanceInfo/NInstanceData").OuterXml);
        checked { ++index; }
      }
      return true;
    }

    private static string GetInstanceXML(string instanceID)
    {
      try
      {
        EInstanceData dataById = WebServiceLayer.InstanceAccess.GetDataByID(instanceID);
        if (dataById == null)
          return "";
        return dataById.InstanceData;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MessageManager.ShowErrorMessage("获取InstanceId为： " + instanceID + " 的病历时出错！" + exception.Message, new object[3]
        {
          (object) "东华结构化电子病历",
          (object) MessageBoxButtons.OK,
          (object) MessageBoxIcon.Hand
        });
        ProjectData.ClearProjectError();
      }
      return "";
    }

    private static string ImpInstanceXML(string instanceId, string instanceXML)
    {
      string str;
      try
      {
        str = WebServiceLayer.InstanceAccess.ImportInstanceData(new EInstanceData()
        {
          ID = instanceId,
          InstanceData = instanceXML
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MessageManager.ShowInformationMessage("导入数据 " + instanceId + " 失败!");
        str = "0";
        ProjectData.ClearProjectError();
      }
      return str;
    }
  }
}
