using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;

namespace dhcc.epr.eprlib.databind
{
	public class DataUntilBase
	{
		protected NInstanceData CurrentInstanceData;

		protected Hashtable keysimpleitems;

		protected Hashtable keysegmentitems;

		protected Hashtable keytextdescitems;

		protected Hashtable keysystemitems;

		protected string strQuery;

		protected string strReturn;

		protected Hashtable SystemDatasets;

		public DataUntilBase()
		{
			this.strQuery = "";
			this.strReturn = "";
		}

		public DataUntilBase(NInstanceData objInstanceData)
		{
			this.strQuery = "";
			this.strReturn = "";
			this.CurrentInstanceData = objInstanceData;
			this.SystemDatasets = new Hashtable();
		}

		public virtual void SystemDataBind()
		{
		}

		protected virtual void PreSystemDataBind(NInstanceItemCollection subitems, Hashtable keyitems)
		{
			NInstanceItemEnumerator enumerator = subitems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (nInstanceItem is NISimple)
				{
					this.PreSystemItem(nInstanceItem);
				}
				else if (nInstanceItem is NILink)
				{
					this.PreSystemItem(nInstanceItem);
				}
				else if (nInstanceItem is NISegment)
				{
					this.PreSystemDataBind(nInstanceItem.SubItems, keyitems);
				}
				else if (nInstanceItem is NICluster)
				{
					this.PreSystemDataBind(nInstanceItem.SubItems, keyitems);
				}
			}
		}

		protected virtual void PreSystemItem(NInstanceItem item)
		{
		}

		protected virtual void GetSystemData()
		{
			if (this.keysystemitems.Count < 1)
			{
				return;
			}
			IEnumerator enumerator = this.keysystemitems.Values.GetEnumerator();
			int arg_30_0 = 0;
			checked
			{
				int num = this.keysystemitems.Count - 1;
				for (int i = arg_30_0; i <= num; i++)
				{
					enumerator.MoveNext();
					string text = Conversions.ToString(enumerator.Current);
					string str = text.Split(new char[]
					{
						'#'
					})[1];
					string str2 = text.Split(new char[]
					{
						'#'
					})[2];
					string key = str + "#" + str2;
					if (!this.SystemDatasets.ContainsKey(key))
					{
						this.SystemDatasets.Add(key, null);
					}
				}
				string text2 = "";
				if (this.SystemDatasets.Count > 0)
				{
					string text3 = "";
					string text4 = "";
					try
					{
						Hashtable hashtable = (Hashtable)this.SystemDatasets.Clone();
						enumerator = hashtable.Keys.GetEnumerator();
						int arg_106_0 = 0;
						int num2 = this.SystemDatasets.Count - 1;
						for (int j = arg_106_0; j <= num2; j++)
						{
							enumerator.MoveNext();
							string text5 = Conversions.ToString(enumerator.Current);
							text3 = text5.Split(new char[]
							{
								'#'
							})[0].Split(new char[]
							{
								':'
							})[1];
							text4 = text5.Split(new char[]
							{
								'#'
							})[1].Split(new char[]
							{
								':'
							})[1];
							string text6 = WebServiceLayer.GateWayAccess.GetParameterString(text3, text4);
							if (text6 == null)
							{
								text6 = "";
							}
							string[] array = text6.Split(new char[]
							{
								','
							});
							int arg_1C2_0 = 0;
							int num3 = array.Length - 1;
							for (int k = arg_1C2_0; k <= num3; k++)
							{
								string key2 = array[k];
								text2 = text2 + GlobalValues.GetValueByKey(key2) + ",";
							}
							if (text2.Length > 0)
							{
								text2 = text2.Substring(0, text2.Length - 1);
							}
							DataSet dataByQueryName = WebServiceLayer.GateWayAccess.GetDataByQueryName(text3, text4, text2);
							this.SystemDatasets[text5] = dataByQueryName;
							text2 = string.Empty;
						}
					}
					catch (Exception expr_23C)
					{
						ProjectData.SetProjectError(expr_23C);
						Exception ex = expr_23C;
						Interaction.MsgBox(string.Concat(new string[]
						{
							ex.Message,
							"\n",
							text3,
							"－",
							text4
						}), MsgBoxStyle.Critical, "提取绑定数据错误！");
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public virtual void EPRDataBind()
		{
		}

		protected virtual void PreEPRDataBind(NInstanceItemCollection subitems, Hashtable keyitems)
		{
			NInstanceItemEnumerator enumerator = subitems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (nInstanceItem is NISimple)
				{
					this.PreEPRItem(nInstanceItem);
				}
				else if (nInstanceItem is NILink)
				{
					this.PreEPRItem(nInstanceItem);
				}
				else if (nInstanceItem is NISegment)
				{
					this.PreEPRDataBind(nInstanceItem.SubItems, keyitems);
				}
				else if (nInstanceItem is NICluster)
				{
					this.PreEPRDataBind(nInstanceItem.SubItems, keyitems);
				}
			}
		}

		protected virtual void PreEPRItem(NInstanceItem item)
		{
		}

		protected virtual void GetEPRData()
		{
			if (this.keysimpleitems.Count < 1 && this.keysegmentitems.Count < 1 && this.keytextdescitems.Count < 1)
			{
				return;
			}
			try
			{
				this.strReturn = WebServiceLayer.GateWayAccess.DBInterFaceByStream(this.strQuery).StreamData;
			}
			catch (Exception expr_48)
			{
				ProjectData.SetProjectError(expr_48);
				Exception ex = expr_48;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}
	}
}
