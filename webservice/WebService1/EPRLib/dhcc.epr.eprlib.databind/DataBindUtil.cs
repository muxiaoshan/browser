using dhcc.epr.eprlib.instancedata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.databind
{
	public class DataBindUtil : DataUntilBase
	{
		public DataBindUtil(NInstanceData objInstanceData) : base(objInstanceData)
		{
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
				this.ParseSystemData();
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
				if (!(dataBaseBindCode == null | Operators.CompareString(dataBaseBindCode, "", false) == 0))
				{
					int startIndex = dataBaseBindCode.IndexOf("#CNAME");
					string value = dataBaseBindCode.Substring(startIndex);
					this.keysystemitems.Add(item, value);
				}
			}
		}

		protected virtual void ParseSystemData()
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
						int j = arg_12C_0;
						while (j <= num2)
						{
							if (Operators.CompareString(dataSet.Tables[0].Columns[j].ColumnName, text2, false) == 0)
							{
								if (dataSet.Tables[0].Rows[0][text2] != null)
								{
									if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][text2])))
									{
										nInstanceItem.BindDataBaseData(Conversions.ToString(dataSet.Tables[0].Rows[0][text2]));
									}
									break;
								}
								break;
							}
							else
							{
								j++;
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
					this.ParseEPRData();
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
				if (!(ePRBindCode == null | Operators.CompareString(ePRBindCode, "", false) == 0))
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

		protected virtual void ParseEPRData()
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
						if (Operators.ConditionalCompareObjectEqual(arrayList[i], "*NULL", false))
						{
							arrayList[i] = "";
						}
						nInstanceItem.BindEPRData(Conversions.ToString(arrayList[i]));
					}
					ArrayList arrayList2 = DataOperater.Split(strToSplit2, "@^");
					enumerator = this.keysegmentitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_17E_0 = 0;
					int num8 = arrayList2.Count - 1;
					for (int j = arg_17E_0; j <= num8; j++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(arrayList2[j], "*NULL", false))
						{
							arrayList2[j] = "";
						}
						nInstanceItem2.BindEPRData(Conversions.ToString(arrayList2[j]));
					}
					ArrayList arrayList3 = DataOperater.Split(strToSplit3, "@^");
					enumerator = this.keytextdescitems.Keys.GetEnumerator();
					enumerator.Reset();
					int arg_20C_0 = 0;
					int num9 = arrayList3.Count - 1;
					for (int k = arg_20C_0; k <= num9; k++)
					{
						enumerator.MoveNext();
						NInstanceItem nInstanceItem3 = (NInstanceItem)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(arrayList3[k], "*NULL", false))
						{
							arrayList3[k] = "";
						}
						nInstanceItem3.BindEPRData(Conversions.ToString(arrayList3[k]));
					}
				}
			}
		}

		public static ArrayList Split(string strToSplit, string strSplitor)
		{
			return DataOperater.Split(strToSplit, strSplitor);
		}
	}
}
