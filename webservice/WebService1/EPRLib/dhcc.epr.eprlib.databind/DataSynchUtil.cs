using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.databind
{
	public class DataSynchUtil : DataUntilBase
	{
		private DataSet _SynchData;

		public DataSynchUtil(NInstanceData objInstanceData) : base(objInstanceData)
		{
			this.IniDataset();
		}

		public bool SynchData(string argTemplateName)
		{
			this.SystemDataBind();
			this.EPRDataBind();
			ArrayList arrayList = new ArrayList();
			if (this._SynchData.Tables["tbSynchData"].Rows.Count <= 0)
			{
				return false;
			}
			frmShowSynchData frmShowSynchData = new frmShowSynchData(argTemplateName, this._SynchData);
			frmShowSynchData.ShowDialog();
			arrayList = frmShowSynchData.FieldArryList;
			if (Operators.CompareString(frmShowSynchData.ResultTag, "Replace", false) != 0)
			{
				return false;
			}
			if (this.SystemDatasets.Count > 0)
			{
				this.ParseSystemData(ref arrayList);
			}
			if (Operators.CompareString(this.strQuery, "", false) != 0)
			{
				this.ParseEPRData(ref arrayList);
			}
			return true;
		}

		public override void SystemDataBind()
		{
			if (this.keysystemitems == null)
			{
				this.keysystemitems = new Hashtable();
				this.PreSystemDataBind(this.CurrentInstanceData.SubItems, this.keysegmentitems);
			}
			this.GetSystemData();
			if (this.SystemDatasets.Count > 0)
			{
				this.CheckSystemData();
			}
		}

		protected override void PreSystemItem(NInstanceItem item)
		{
			if (item != null)
			{
				if (item.BindMMetaItem == null)
				{
					return;
				}
				string dataBaseBindCode = item.BindMMetaItem.DataBaseBindCode;
				if (!(dataBaseBindCode == null | Operators.CompareString(dataBaseBindCode, "", false) == 0) && item.BindMMetaItem.Synch)
				{
					int startIndex = dataBaseBindCode.IndexOf("#CNAME");
					string value = dataBaseBindCode.Substring(startIndex);
					this.keysystemitems.Add(item, value);
				}
			}
		}

		protected virtual void CheckSystemData()
		{
			IEnumerator enumerator = this.keysystemitems.Keys.GetEnumerator();
			enumerator.Reset();
			int arg_27_0 = 0;
			checked
			{
				int num = this.keysystemitems.Count - 1;
				for (int i = arg_27_0; i <= num; i++)
				{
					enumerator.MoveNext();
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					string text = Conversions.ToString(this.keysystemitems[nInstanceItem]);
					string str = text.Split(new char[]
					{
						'#'
					})[1];
					string str2 = text.Split(new char[]
					{
						'#'
					})[2];
					string text2 = text.Split(new char[]
					{
						'#'
					})[3].Split(new char[]
					{
						':'
					})[1];
					DataSet dataSet = (DataSet)this.SystemDatasets[str + "#" + str2];
					if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
					{
						int arg_12C_0 = 0;
						int num2 = dataSet.Tables[0].Columns.Count - 1;
						for (int j = arg_12C_0; j <= num2; j++)
						{
							if (Operators.CompareString(dataSet.Tables[0].Columns[j].ColumnName, text2, false) == 0 && dataSet.Tables[0].Rows[0][text2] != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][text2])))
							{
								string dataBaseDataForCheckSynch = nInstanceItem.GetDataBaseDataForCheckSynch(Conversions.ToString(dataSet.Tables[0].Rows[0][text2]));
								NInstanceItem arg_1E7_1 = nInstanceItem;
								string arg_1E7_2 = dataBaseDataForCheckSynch;
								string arg_1E7_3 = "基础单元";
								string text3 = "1";
								this.InsertDialogRow(arg_1E7_1, arg_1E7_2, arg_1E7_3, ref text3);
							}
						}
					}
				}
			}
		}

		public override void EPRDataBind()
		{
			checked
			{
				if (Operators.CompareString(this.strQuery, "", false) == 0)
				{
					if (this.keysimpleitems == null)
					{
						this.keysimpleitems = new Hashtable();
					}
					if (this.keysegmentitems == null)
					{
						this.keysegmentitems = new Hashtable();
					}
					if (this.keytextdescitems == null)
					{
						this.keytextdescitems = new Hashtable();
					}
					this.PreEPRDataBind(this.CurrentInstanceData.SubItems, this.keysegmentitems);
					string text = "";
					IEnumerator enumerator = this.keysimpleitems.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.AddObject(enumerator.Current, ",")));
					}
					if (text.Length > 0)
					{
						text = text.Remove(text.Length - 1, 1);
					}
					string text2 = "";
					IEnumerator enumerator2 = this.keysegmentitems.Values.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.AddObject(enumerator2.Current, ",")));
					}
					if (text2.Length > 0)
					{
						text2 = text2.Remove(text2.Length - 1, 1);
					}
					string text3 = "";
					IEnumerator enumerator3 = this.keytextdescitems.Values.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						text3 = Conversions.ToString(Operators.AddObject(text3, Operators.AddObject(enumerator3.Current, ",")));
					}
					if (text3.Length > 0)
					{
						text3 = text3.Remove(text3.Length - 1, 1);
					}
					if (Operators.CompareString(text, "", false) == 0 & Operators.CompareString(text2, "", false) == 0 & Operators.CompareString(text3, "", false) == 0)
					{
						this.strQuery = "";
					}
					else
					{
						this.strQuery += "$Head{";
						this.strQuery = this.strQuery + "PatientID:" + GlobalValues.GetValueByKey("PatientID") + ",";
						this.strQuery = this.strQuery + "EpisodeID:" + GlobalValues.GetValueByKey("EpisodeID") + ",";
						this.strQuery += "InstanceDataID:";
						this.strQuery += "}";
						this.strQuery += "$Single";
						this.strQuery += "#Simple{";
						this.strQuery += text;
						this.strQuery += "}";
						this.strQuery += "#Segment{";
						this.strQuery += text2;
						this.strQuery += "}";
						this.strQuery += "#TextDesc{";
						this.strQuery += text3;
						this.strQuery += "}";
						this.strQuery += "$Multiple#Simple{}#Segment{}#TextDesc{}#InstanceData{}";
						this.strQuery += "$SystemData{}";
					}
				}
				if (Operators.CompareString(this.strQuery, "", false) != 0)
				{
					this.GetEPRData();
					this.CheckEPRData();
				}
			}
		}

		protected override void PreEPRItem(NInstanceItem item)
		{
			if (item != null)
			{
				if (item.BindMMetaItem == null)
				{
					return;
				}
				string ePRBindCode = item.BindMMetaItem.EPRBindCode;
				if (!(ePRBindCode == null | Operators.CompareString(ePRBindCode, "", false) == 0) && item.BindMMetaItem.Synch)
				{
					string[] array = ePRBindCode.Split(new char[]
					{
						'#'
					});
					if (Operators.CompareString(array[1], "TYPE:Simple", false) == 0)
					{
						string text = array[2].Split(new char[]
						{
							':'
						})[1];
						string text2 = array[4].Split(new char[]
						{
							':'
						})[1];
						string text3 = array[5].Split(new char[]
						{
							':'
						})[1];
						string value = string.Concat(new string[]
						{
							text,
							"|",
							text2,
							"|",
							text3
						});
						this.keysimpleitems.Add(item, value);
					}
					else if (Operators.CompareString(array[1], "TYPE:Segment", false) == 0)
					{
						string str = array[2].Split(new char[]
						{
							':'
						})[1];
						string str2 = array[4].Split(new char[]
						{
							':'
						})[1];
						string value2 = str + "|" + str2;
						this.keysegmentitems.Add(item, value2);
					}
					else if (Operators.CompareString(array[1], "TYPE:TextDesc", false) == 0)
					{
						string str3 = array[2].Split(new char[]
						{
							':'
						})[1];
						string str4 = array[4].Split(new char[]
						{
							':'
						})[1];
						string value3 = str3 + "|" + str4;
						this.keytextdescitems.Add(item, value3);
					}
				}
			}
		}

		protected void CheckEPRData()
		{
			checked
			{
				if (Operators.CompareString(this.strReturn, "", false) != 0)
				{
					int num = this.strReturn.IndexOf("$Single");
					int num2 = this.strReturn.IndexOf("$Multiple");
					string text = this.strReturn.Substring(num, num2 - num);
					int num3 = text.IndexOf("#Simple");
					int num4 = text.IndexOf("#Segment");
					int num5 = text.IndexOf("#TextDesc");
					int num6 = text.IndexOf("#Table");
					string strToSplit = text.Substring(num3 + 8, num4 - num3 - 9);
					string strToSplit2 = text.Substring(num4 + 9, num5 - num4 - 10);
					string strToSplit3 = text.Substring(num5 + 10, num6 - num5 - 11);
					ArrayList arrayList = DataOperater.Split(strToSplit, "@^");
					IEnumerator enumerator = this.keysimpleitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_F2_0 = 0;
					int num7 = arrayList.Count - 1;
					for (int i = arg_F2_0; i <= num7; i++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(arrayList[i], "*NULL", false))
						{
							arrayList[i] = "";
						}
						string ePRDataForCheckSynch = nInstanceItem.GetEPRDataForCheckSynch(Conversions.ToString(arrayList[i]));
						NInstanceItem arg_156_1 = nInstanceItem;
						string arg_156_2 = ePRDataForCheckSynch;
						string arg_156_3 = "基础单元";
						string text2 = "2";
						this.InsertDialogRow(arg_156_1, arg_156_2, arg_156_3, ref text2);
					}
					ArrayList arrayList2 = DataOperater.Split(strToSplit2, "@^");
					enumerator = this.keysegmentitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_198_0 = 0;
					int num8 = arrayList2.Count - 1;
					for (int j = arg_198_0; j <= num8; j++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(arrayList2[j], "*NULL", false))
						{
							arrayList2[j] = "";
						}
						string ePRDataForCheckSynch = nInstanceItem2.GetEPRDataForCheckSynch(Conversions.ToString(arrayList2[j]));
						NInstanceItem arg_1FC_1 = nInstanceItem2;
						string arg_1FC_2 = ePRDataForCheckSynch;
						string arg_1FC_3 = "复合单元";
						string text2 = "2";
						this.InsertDialogRow(arg_1FC_1, arg_1FC_2, arg_1FC_3, ref text2);
					}
					ArrayList arrayList3 = DataOperater.Split(strToSplit3, "@^");
					enumerator = this.keytextdescitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_23E_0 = 0;
					int num9 = arrayList3.Count - 1;
					for (int k = arg_23E_0; k <= num9; k++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem3 = (NInstanceItem)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(arrayList3[k], "*NULL", false))
						{
							arrayList3[k] = "";
						}
						string ePRDataForCheckSynch = nInstanceItem3.GetEPRDataForCheckSynch(Conversions.ToString(arrayList3[k]));
						NInstanceItem arg_2A2_1 = nInstanceItem3;
						string arg_2A2_2 = ePRDataForCheckSynch;
						string arg_2A2_3 = "复合单元";
						string text2 = "2";
						this.InsertDialogRow(arg_2A2_1, arg_2A2_2, arg_2A2_3, ref text2);
					}
				}
			}
		}

		private void IniDataset()
		{
			this._SynchData = new DataSet("dsSynchData");
			DataTable dataTable = new DataTable("tbSynchData");
			DataColumn column = new DataColumn("Caption", Type.GetType("System.String"));
			DataColumn column2 = new DataColumn("TextOld", Type.GetType("System.String"));
			DataColumn column3 = new DataColumn("TextNew", Type.GetType("System.String"));
			DataColumn column4 = new DataColumn("CtrlType", Type.GetType("System.String"));
			DataColumn column5 = new DataColumn("FieldName", Type.GetType("System.String"));
			DataColumn column6 = new DataColumn("seleCheck", Type.GetType("System.Boolean"));
			dataTable.Columns.Add(column);
			dataTable.Columns.Add(column2);
			dataTable.Columns.Add(column3);
			dataTable.Columns.Add(column4);
			dataTable.Columns.Add(column5);
			dataTable.Columns.Add(column6);
			this._SynchData.Tables.Add(dataTable);
		}

		private void InsertDialogRow(NInstanceItem instanceItem, string newData, string ctrlType, ref string Flag)
		{
			if (Operators.CompareString(newData, instanceItem.Value, false) != 0)
			{
				DataRow dataRow = this._SynchData.Tables["tbSynchData"].NewRow();
				dataRow["Caption"] = instanceItem.BindMMetaItem.Text;
				dataRow["TextOld"] = instanceItem.Value;
				dataRow["TextNew"] = newData;
				dataRow["CtrlType"] = ctrlType;
				if (Operators.CompareString(Flag, "1", false) == 0)
				{
					string[] array = instanceItem.BindMMetaItem.DataBaseBindCode.Split(new char[]
					{
						':'
					});
					dataRow["FieldName"] = array[checked(array.Length - 1)];
				}
				else
				{
					dataRow["FieldName"] = instanceItem.BindMMetaItem.EPRBindCode;
				}
				dataRow["seleCheck"] = true;
				this._SynchData.Tables["tbSynchData"].Rows.Add(dataRow);
			}
		}

		protected virtual void ParseSystemData(ref ArrayList FieldArraylist)
		{
			IEnumerator enumerator = this.keysystemitems.Keys.GetEnumerator();
			enumerator.Reset();
			int arg_27_0 = 0;
			checked
			{
				int num = this.keysystemitems.Count - 1;
				for (int i = arg_27_0; i <= num; i++)
				{
					enumerator.MoveNext();
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					string text = Conversions.ToString(this.keysystemitems[nInstanceItem]);
					string str = text.Split(new char[]
					{
						'#'
					})[1];
					string str2 = text.Split(new char[]
					{
						'#'
					})[2];
					string text2 = text.Split(new char[]
					{
						'#'
					})[3].Split(new char[]
					{
						':'
					})[1];
					if (FieldArraylist.Contains(text2))
					{
						DataSet dataSet = (DataSet)this.SystemDatasets[str + "#" + str2];
						if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
						{
							int arg_139_0 = 0;
							int num2 = dataSet.Tables[0].Columns.Count - 1;
							for (int j = arg_139_0; j <= num2; j++)
							{
								if (Operators.CompareString(dataSet.Tables[0].Columns[j].ColumnName, text2, false) == 0 && dataSet.Tables[0].Rows[0][text2] != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][text2])))
								{
									nInstanceItem.BindDataBaseData(Conversions.ToString(dataSet.Tables[0].Rows[0][text2]));
								}
							}
						}
					}
				}
			}
		}

		protected virtual void ParseEPRData(ref ArrayList FieldArrayList)
		{
			checked
			{
				if (Operators.CompareString(this.strReturn, "", false) != 0)
				{
					int num = this.strReturn.IndexOf("$Single");
					int num2 = this.strReturn.IndexOf("$Multiple");
					string text = this.strReturn.Substring(num, num2 - num);
					int num3 = text.IndexOf("#Simple");
					int num4 = text.IndexOf("#Segment");
					int num5 = text.IndexOf("#TextDesc");
					int num6 = text.IndexOf("#Table");
					string strToSplit = text.Substring(num3 + 8, num4 - num3 - 9);
					string strToSplit2 = text.Substring(num4 + 9, num5 - num4 - 10);
					string strToSplit3 = text.Substring(num5 + 10, num6 - num5 - 11);
					ArrayList arrayList = DataOperater.Split(strToSplit, "@^");
					IEnumerator enumerator = this.keysimpleitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_F0_0 = 0;
					int num7 = arrayList.Count - 1;
					for (int i = arg_F0_0; i <= num7; i++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
						if (FieldArrayList.Contains(nInstanceItem.BindMMetaItem.EPRBindCode))
						{
							if (Operators.ConditionalCompareObjectEqual(arrayList[i], "*NULL", false))
							{
								arrayList[i] = "";
							}
							nInstanceItem.BindEPRData(Conversions.ToString(arrayList[i]));
						}
					}
					ArrayList arrayList2 = DataOperater.Split(strToSplit2, "@^");
					enumerator = this.keysegmentitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_193_0 = 0;
					int num8 = arrayList2.Count - 1;
					for (int j = arg_193_0; j <= num8; j++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator.Current;
						if (FieldArrayList.Contains(nInstanceItem2.BindMMetaItem.EPRBindCode))
						{
							if (Operators.ConditionalCompareObjectEqual(arrayList2[j], "*NULL", false))
							{
								arrayList2[j] = "";
							}
							nInstanceItem2.BindEPRData(Conversions.ToString(arrayList2[j]));
						}
					}
					ArrayList arrayList3 = DataOperater.Split(strToSplit3, "@^");
					enumerator = this.keytextdescitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_236_0 = 0;
					int num9 = arrayList3.Count - 1;
					for (int k = arg_236_0; k <= num9; k++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem3 = (NInstanceItem)enumerator.Current;
						if (FieldArrayList.Contains(nInstanceItem3.BindMMetaItem.EPRBindCode))
						{
							if (Operators.ConditionalCompareObjectEqual(arrayList3[k], "*NULL", false))
							{
								arrayList3[k] = "";
							}
							nInstanceItem3.BindEPRData(Conversions.ToString(arrayList3[k]));
						}
					}
				}
			}
		}
	}
}
