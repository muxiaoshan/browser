using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using KBNodeData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NISegment : NInstanceItem
	{
		private static Hashtable EKBNodeAList;

		private string _KBNodeID;

		private string _SegmentNumber;

		private int _CodeNumber;

		private NInstanceItemCollection _NormalSubItems;

		private FormateRangeCollection _NormalFormatRangeCollection;

		private FormateRangeCollection _AbNormalFormatRangeCollection;

		private NInstanceItemCollection _AbNormalSubItems;

		private bool _AbNormalSupport;

		private bool _IsAbNormal;

		private NInstanceData CurrentInstanceData;

		private Hashtable keysimpleitems;

		private Hashtable keysegmentitems;

		private Hashtable keytextdescitems;

		private Hashtable keysystemitems;

		private string strQuery;

		private string strReturn;

		private Hashtable SystemDatasets;

		public FormateRangeCollection NormalFormatRangeCollection
		{
			get
			{
				return this._NormalFormatRangeCollection;
			}
			set
			{
				this._NormalFormatRangeCollection = value;
			}
		}

		public FormateRangeCollection AbNormalFormatRangeCollection
		{
			get
			{
				return this._AbNormalFormatRangeCollection;
			}
			set
			{
				this._AbNormalFormatRangeCollection = value;
			}
		}

		public NInstanceItemCollection NormalSubItems
		{
			get
			{
				return this._NormalSubItems;
			}
			set
			{
				this._NormalSubItems = value;
			}
		}

		public NInstanceItemCollection AbNormalSubItems
		{
			get
			{
				return this._AbNormalSubItems;
			}
			set
			{
				this._AbNormalSubItems = value;
			}
		}

		public bool AbNormalSupport
		{
			get
			{
				return this._AbNormalSupport;
			}
			set
			{
				this._AbNormalSupport = value;
			}
		}

		public bool IsAbNormal
		{
			get
			{
				return this._IsAbNormal;
			}
			set
			{
				this._IsAbNormal = value;
			}
		}

		public string KBNodeID
		{
			get
			{
				return this._KBNodeID;
			}
			set
			{
				this._KBNodeID = value;
			}
		}

		public string SegmentNumber
		{
			get
			{
				return this._SegmentNumber;
			}
			set
			{
				this._SegmentNumber = value;
			}
		}

		public override string WholeString
		{
			get
			{
				string text = "";
				NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					text += nInstanceItem.Value;
				}
				return text;
			}
		}

		public NISegment()
		{
			this.strQuery = "";
			this.strReturn = "";
			this.SubItems = new NInstanceItemCollection();
			this._NormalSubItems = new NInstanceItemCollection();
			this._AbNormalSubItems = new NInstanceItemCollection();
			this.FormatRangeCollection = new FormateRangeCollection();
			this._NormalFormatRangeCollection = new FormateRangeCollection();
			this._AbNormalFormatRangeCollection = new FormateRangeCollection();
			if (NISegment.EKBNodeAList == null)
			{
				NISegment.EKBNodeAList = new Hashtable();
			}
		}

		public override void SyncMetaItem(MMetaItem metaitem)
		{
			checked
			{
				if (metaitem == null)
				{
					if (!this.Code.StartsWith("ImageSegment"))
					{
						bool flag = false;
						int arg_2D_0 = 0;
						int num = this.SubItems.Count - 1;
						for (int i = arg_2D_0; i <= num; i++)
						{
							if (this.SubItems[i] is NISimple)
							{
								flag = true;
							}
						}
						if (flag)
						{
							if (NISegment.EKBNodeAList[this.KBNodeID] == null)
							{
								try
								{
									EKBNode value = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(this.KBNodeID);
									NISegment.EKBNodeAList.Add(this.KBNodeID, value);
								}
								catch (Exception expr_8C)
								{
									ProjectData.SetProjectError(expr_8C);
									Exception ex = expr_8C;
									MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
									ProjectData.ClearProjectError();
								}
							}
							EKBNode eKBNode = (EKBNode)NISegment.EKBNodeAList[this.KBNodeID];
							MISegment mISegment = new MISegment();
							if (Operators.CompareString(this.SegmentNumber, "1", false) == 0)
							{
								mISegment.XMLString = eKBNode.S1MetaData;
							}
							else if (Operators.CompareString(this.SegmentNumber, "2", false) == 0)
							{
								mISegment.XMLString = eKBNode.S2MetaData;
							}
							else if (Operators.CompareString(this.SegmentNumber, "3", false) == 0)
							{
								mISegment.XMLString = eKBNode.S3MetaData;
							}
							this.BindMMetaItem = mISegment;
							mISegment.BindInstanceItem = this;
							int arg_151_0 = 0;
							int num2 = this.SubItems.Count - 1;
							for (int j = arg_151_0; j <= num2; j++)
							{
								NInstanceItem nInstanceItem = this.SubItems[j];
								if (nInstanceItem is NISimple)
								{
									MMetaItemEnumerator enumerator = mISegment.SubItems.GetEnumerator();
									while (enumerator.MoveNext())
									{
										MMetaItem mMetaItem = (MMetaItem)enumerator.Current;
										if (Operators.CompareString(nInstanceItem.Code, mMetaItem.Code, false) == 0)
										{
											nInstanceItem.BindMMetaItem = mMetaItem;
											mMetaItem.BindInstanceItem = nInstanceItem;
											break;
										}
									}
								}
							}
						}
						else
						{
							this.BindMMetaItem = new MISegment
							{
								Code = this.Code,
								KBNodeID = this.KBNodeID,
								SegmentNumber = this.SegmentNumber
							};
						}
					}
				}
				else
				{
					if (Operators.CompareString(this.Code, metaitem.Code, false) == 0)
					{
						this.BindMMetaItem = metaitem;
						metaitem.BindInstanceItem = this;
					}
					else
					{
						MessageManager.ShowInformationMessage("同步异常！");
					}
					ArrayList arrayList = new ArrayList();
					int arg_24D_0 = 0;
					int num3 = this.AbNormalSubItems.Count - 1;
					for (int k = arg_24D_0; k <= num3; k++)
					{
						NInstanceItem nInstanceItem2 = this.AbNormalSubItems[k];
						if (!(nInstanceItem2 is NIFree))
						{
							bool flag2 = false;
							MMetaItemEnumerator enumerator2 = metaitem.SubItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								MMetaItem mMetaItem2 = (MMetaItem)enumerator2.Current;
								if (Operators.CompareString(nInstanceItem2.Code, mMetaItem2.Code, false) == 0)
								{
									nInstanceItem2.BindMMetaItem = mMetaItem2;
									mMetaItem2.BindInstanceItem = nInstanceItem2;
									flag2 = true;
									break;
								}
							}
							if (!flag2)
							{
								MessageManager.ShowInformationMessage("同步异常！");
								arrayList.Add(nInstanceItem2);
							}
						}
					}
					try
					{
						IEnumerator enumerator3 = arrayList.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							NInstanceItem value2 = (NInstanceItem)enumerator3.Current;
							this.AbNormalSubItems.Remove(value2);
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					arrayList.Clear();
					int arg_348_0 = 0;
					int num4 = this.NormalSubItems.Count - 1;
					for (int l = arg_348_0; l <= num4; l++)
					{
						NInstanceItem nInstanceItem3 = this.NormalSubItems[l];
						if (!(nInstanceItem3 is NIFree))
						{
							bool flag3 = false;
							MMetaItemEnumerator enumerator4 = metaitem.SubItems.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								MMetaItem mMetaItem3 = (MMetaItem)enumerator4.Current;
								if (Operators.CompareString(nInstanceItem3.Code, mMetaItem3.Code, false) == 0)
								{
									nInstanceItem3.BindMMetaItem = mMetaItem3;
									mMetaItem3.BindInstanceItem = nInstanceItem3;
									flag3 = true;
									break;
								}
							}
							if (!flag3)
							{
								MessageManager.ShowInformationMessage("同步异常！");
								arrayList.Add(nInstanceItem3);
							}
						}
					}
					try
					{
						IEnumerator enumerator5 = arrayList.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							NInstanceItem value3 = (NInstanceItem)enumerator5.Current;
							this.NormalSubItems.Remove(value3);
						}
					}
					finally
					{
						IEnumerator enumerator5;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
					arrayList.Clear();
					int arg_443_0 = 0;
					int num5 = this.SubItems.Count - 1;
					for (int m = arg_443_0; m <= num5; m++)
					{
						NInstanceItem nInstanceItem4 = this.SubItems[m];
						if (!(nInstanceItem4 is NIFree))
						{
							bool flag4 = false;
							MMetaItemEnumerator enumerator6 = metaitem.SubItems.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								MMetaItem mMetaItem4 = (MMetaItem)enumerator6.Current;
								if (Operators.CompareString(nInstanceItem4.Code, mMetaItem4.Code, false) == 0)
								{
									nInstanceItem4.BindMMetaItem = mMetaItem4;
									mMetaItem4.BindInstanceItem = nInstanceItem4;
									flag4 = true;
									break;
								}
							}
							if (!flag4)
							{
								MessageManager.ShowInformationMessage("同步异常！");
								arrayList.Add(nInstanceItem4);
							}
						}
					}
					try
					{
						IEnumerator enumerator7 = arrayList.GetEnumerator();
						while (enumerator7.MoveNext())
						{
							NInstanceItem value4 = (NInstanceItem)enumerator7.Current;
							this.SubItems.Remove(value4);
						}
					}
					finally
					{
						IEnumerator enumerator7;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		public override Controller CreateController()
		{
			return new SegmentController
			{
				BindInstanceItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NISegment");
			base.XMLSerialize(writer);
			writer.WriteElementString("KBNodeID", this.KBNodeID);
			writer.WriteElementString("SegmentNumber", this.SegmentNumber);
			writer.WriteStartElement("SubItems");
			this.FormatRangeCollection.Clear();
			NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				nInstanceItem.XMLSerialize(writer);
				FormateRangeEnumerator enumerator2 = nInstanceItem.FormatRangeCollection.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					FormateRange value = (FormateRange)enumerator2.Current;
					this.FormatRangeCollection.Add(value);
				}
			}
			writer.WriteEndElement();
			if (this.FormatRangeCollection != null)
			{
				this.FormatRangeCollection.XMLSerialize(writer);
			}
			if (this.RevisionHistory != null)
			{
				this.RevisionHistory.XMLSerialize(writer);
			}
			if (this.AbNormalSupport)
			{
				writer.WriteElementString("AbNormalSupport", this.AbNormalSupport.ToString());
				writer.WriteElementString("IsAbNormal", this.IsAbNormal.ToString());
				writer.WriteStartElement("Normal");
				writer.WriteStartElement("SubItems");
				NInstanceItemEnumerator enumerator3 = this.NormalSubItems.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator3.Current;
					nInstanceItem2.XMLSerialize(writer);
				}
				writer.WriteEndElement();
				if (this._NormalFormatRangeCollection != null)
				{
					this._NormalFormatRangeCollection.XMLSerialize(writer);
				}
				writer.WriteEndElement();
				writer.WriteStartElement("AbNormal");
				writer.WriteStartElement("SubItems");
				NInstanceItemEnumerator enumerator4 = this.AbNormalSubItems.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					NInstanceItem nInstanceItem3 = (NInstanceItem)enumerator4.Current;
					nInstanceItem3.XMLSerialize(writer);
				}
				writer.WriteEndElement();
				if (this._AbNormalFormatRangeCollection != null)
				{
					this._AbNormalFormatRangeCollection.XMLSerialize(writer);
				}
				writer.WriteEndElement();
			}
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "KBNodeID", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.KBNodeID = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "SegmentNumber", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.SegmentNumber = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "AbNormalSupport", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.AbNormalSupport = bool.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "IsAbNormal", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.IsAbNormal = bool.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "Normal", false) == 0 & !reader.IsEmptyElement)
				{
					while (reader.Read())
					{
						if (Operators.CompareString(reader.Name, "SubItems", false) == 0 & !reader.IsEmptyElement)
						{
							while (reader.Read())
							{
								if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISimple", false) == 0)
								{
									NISimple nISimple = new NISimple();
									nISimple.XMLDeserialize(reader);
									this.NormalSubItems.Add(this, nISimple);
								}
								else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIFree", false) == 0)
								{
									NIFree nIFree = new NIFree();
									nIFree.XMLDeserialize(reader);
									this.NormalSubItems.Add(this, nIFree);
								}
								else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NILink", false) == 0)
								{
									NILink nILink = new NILink();
									nILink.XMLDeserialize(reader);
									this.NormalSubItems.Add(this, nILink);
								}
								else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
								{
									break;
								}
							}
						}
						if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
						{
							this._NormalFormatRangeCollection = new FormateRangeCollection();
							this._NormalFormatRangeCollection.XMLDeserialize(reader);
						}
						if (Operators.CompareString(reader.Name, "Normal", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
						{
							break;
						}
					}
				}
				if (Operators.CompareString(reader.Name, "AbNormal", false) == 0 & !reader.IsEmptyElement)
				{
					while (reader.Read())
					{
						if (Operators.CompareString(reader.Name, "SubItems", false) == 0 & !reader.IsEmptyElement)
						{
							while (reader.Read())
							{
								if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISimple", false) == 0)
								{
									NISimple nISimple2 = new NISimple();
									nISimple2.XMLDeserialize(reader);
									this.AbNormalSubItems.Add(this, nISimple2);
								}
								else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIFree", false) == 0)
								{
									NIFree nIFree2 = new NIFree();
									nIFree2.XMLDeserialize(reader);
									this.AbNormalSubItems.Add(this, nIFree2);
								}
								else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NILink", false) == 0)
								{
									NILink nILink2 = new NILink();
									nILink2.XMLDeserialize(reader);
									this.AbNormalSubItems.Add(this, nILink2);
								}
								else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
								{
									break;
								}
							}
						}
						if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
						{
							this._AbNormalFormatRangeCollection = new FormateRangeCollection();
							this._AbNormalFormatRangeCollection.XMLDeserialize(reader);
						}
						if (Operators.CompareString(reader.Name, "AbNormal", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
						{
							break;
						}
					}
				}
				if (Operators.CompareString(reader.Name, "SubItems", false) == 0 & !reader.IsEmptyElement)
				{
					while (reader.Read())
					{
						if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISimple", false) == 0)
						{
							NISimple nISimple3 = new NISimple();
							nISimple3.XMLDeserialize(reader);
							this.SubItems.Add(this, nISimple3);
						}
						else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIFree", false) == 0)
						{
							NIFree nIFree3 = new NIFree();
							nIFree3.XMLDeserialize(reader);
							this.SubItems.Add(this, nIFree3);
						}
						else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NILink", false) == 0)
						{
							NILink nILink3 = new NILink();
							nILink3.XMLDeserialize(reader);
							this.SubItems.Add(this, nILink3);
						}
						else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
						{
							break;
						}
					}
				}
				if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
				{
					this.FormatRangeCollection = new FormateRangeCollection();
					this.FormatRangeCollection.XMLDeserialize(reader);
				}
				if (Operators.CompareString(reader.Name, "RevisionHistory", false) == 0)
				{
					RevisionHistory revisionHistory = new RevisionHistory();
					revisionHistory.XMLDeserialize(reader);
					this.RevisionHistory = revisionHistory;
				}
				if (Operators.CompareString(reader.Name, "NISegment", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
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
					this.PreEPRDataBind(this.SubItems, this.keysegmentitems);
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

		private void PreEPRDataBind(NInstanceItemCollection subitems, Hashtable keyitems)
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
				else if (nInstanceItem is NITextDesc)
				{
					NInstanceItemEnumerator enumerator2 = nInstanceItem.SubItems.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator2.Current;
						this.PreEPRDataBind(nInstanceItem2.SubItems, keyitems);
					}
				}
			}
		}

		private void PreEPRItem(NInstanceItem item)
		{
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

		private void GetEPRData()
		{
			try
			{
				this.strReturn = WebServiceLayer.GateWayAccess.DBInterFaceByStream(this.strQuery).StreamData;
			}
			catch (Exception expr_1D)
			{
				ProjectData.SetProjectError(expr_1D);
				Exception ex = expr_1D;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void ParseEPRData()
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
					ArrayList arrayList = NISegment.Split(strToSplit, "@^");
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
					ArrayList arrayList2 = NISegment.Split(strToSplit2, "@^");
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
					ArrayList arrayList3 = NISegment.Split(strToSplit3, "@^");
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

		public override void SystemDataBind()
		{
			if (this.keysystemitems == null)
			{
				this.keysystemitems = new Hashtable();
				this.PreSystemDataBind(this.SubItems, this.keysystemitems);
			}
			this.GetSystemData();
			if (this.SystemDatasets != null && this.SystemDatasets.Count > 0)
			{
				this.ParseSystemData();
			}
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
				else if (nInstanceItem is NITextDesc)
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

		protected virtual void GetSystemData()
		{
			if (this.keysystemitems.Count < 1)
			{
				return;
			}
			if (this.SystemDatasets == null)
			{
				this.SystemDatasets = new Hashtable();
			}
			IEnumerator enumerator = this.keysystemitems.Values.GetEnumerator();
			int arg_43_0 = 0;
			checked
			{
				int num = this.keysystemitems.Count - 1;
				for (int i = arg_43_0; i <= num; i++)
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
				if (this.SystemDatasets.Count > 0)
				{
					string text2 = "";
					string text3 = "";
					try
					{
						Hashtable hashtable = (Hashtable)this.SystemDatasets.Clone();
						enumerator = hashtable.Keys.GetEnumerator();
						int arg_10F_0 = 0;
						int num2 = this.SystemDatasets.Count - 1;
						for (int j = arg_10F_0; j <= num2; j++)
						{
							enumerator.MoveNext();
							string text4 = Conversions.ToString(enumerator.Current);
							text2 = text4.Split(new char[]
							{
								'#'
							})[0].Split(new char[]
							{
								':'
							})[1];
							text3 = text4.Split(new char[]
							{
								'#'
							})[1].Split(new char[]
							{
								':'
							})[1];
							string text5 = WebServiceLayer.GateWayAccess.GetParameterString(text2, text3);
							if (text5 == null)
							{
								text5 = "";
							}
							string[] array = text5.Split(new char[]
							{
								','
							});
							string text6 = "";
							int arg_1D2_0 = 0;
							int num3 = array.Length - 1;
							for (int k = arg_1D2_0; k <= num3; k++)
							{
								string key2 = array[k];
								text6 = text6 + GlobalValues.GetValueByKey(key2) + ",";
							}
							if (text6.Length > 0)
							{
								text6 = text6.Substring(0, text6.Length - 1);
							}
							DataSet dataByQueryName = WebServiceLayer.GateWayAccess.GetDataByQueryName(text2, text3, text6);
							this.SystemDatasets[text4] = dataByQueryName;
						}
					}
					catch (Exception expr_24D)
					{
						ProjectData.SetProjectError(expr_24D);
						Exception ex = expr_24D;
						Interaction.MsgBox(string.Concat(new string[]
						{
							ex.Message,
							"\n",
							ex.StackTrace,
							"\n",
							text2,
							"－",
							text3
						}), MsgBoxStyle.Critical, "提取绑定数据错误！");
						ProjectData.ClearProjectError();
					}
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
						for (int j = arg_12C_0; j <= num2; j++)
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

		private static ArrayList Split(string strToSplit, string strSplitor)
		{
			int num = 0;
			ArrayList arrayList = new ArrayList();
			checked
			{
				if (!(strToSplit == null | Operators.CompareString(strToSplit, "", false) == 0))
				{
					string text;
					for (int i = strToSplit.IndexOf(strSplitor, num); i > -1; i = strToSplit.IndexOf(strSplitor, num))
					{
						text = strToSplit.Substring(num, i - num);
						arrayList.Add(text);
						num = i + strSplitor.Length;
					}
					text = strToSplit.Substring(num, strToSplit.Length - num);
					if (Operators.CompareString(text, "*NULL", false) == 0)
					{
						text = "";
					}
					arrayList.Add(text);
				}
				return arrayList;
			}
		}

		public override void SetByVType(string strValue, string strVType)
		{
			if (this.SubItems.Count == 0)
			{
				NIFree nIFree = new NIFree();
				this.Value = strValue;
				nIFree.Value = strValue.Replace(" ", "&nbsp;");
				this.SubItems.Add(nIFree);
			}
			if (this.SubItems.Count == 1)
			{
				NIFree nIFree2 = (NIFree)this.SubItems[0];
				this.Value = strValue;
				nIFree2.Value = strValue.Replace(" ", "&nbsp;");
			}
		}

		public override string GetByVType(string strVType)
		{
			string wholeString = this.WholeString;
			if (wholeString == null)
			{
				return string.Empty;
			}
			return wholeString;
		}

		public void SwitchToNormalValue()
		{
			if (!this.AbNormalSupport)
			{
				return;
			}
			if (!this.IsAbNormal)
			{
				return;
			}
			NISegment nISegment = (NISegment)this.Clone();
			this.IsAbNormal = false;
			this.SubItems = nISegment.NormalSubItems;
			this.FormatRangeCollection = nISegment.NormalFormatRangeCollection;
			this.SyncMetaItem(this.BindMMetaItem);
		}

		public void SwitchToAbNormalValue()
		{
			if (!this.AbNormalSupport)
			{
				return;
			}
			if (this.IsAbNormal)
			{
				return;
			}
			NISegment nISegment = (NISegment)this.Clone();
			this.IsAbNormal = true;
			this.SubItems = nISegment.AbNormalSubItems;
			this.FormatRangeCollection = nISegment.AbNormalFormatRangeCollection;
			this.SyncMetaItem(this.BindMMetaItem);
		}
	}
}
