using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NIImageAnnotate : NInstanceItem
	{
		public delegate void XMLEventEventHandler();

		private NIImageAnnotate.XMLEventEventHandler XMLEventEvent;

		private string _AnnoData;

		private bool _IsAnnoDataChanged;

		private string _HotSpotCode;

		private bool _HasSyncHotSpotCode;

		public event NIImageAnnotate.XMLEventEventHandler XMLEvent
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.XMLEventEvent = (NIImageAnnotate.XMLEventEventHandler)Delegate.Combine(this.XMLEventEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.XMLEventEvent = (NIImageAnnotate.XMLEventEventHandler)Delegate.Remove(this.XMLEventEvent, value);
			}
		}

		public string AnnoData
		{
			get
			{
				if (this.IsAnnoDataChanged)
				{
					NIImageAnnotate.XMLEventEventHandler xMLEventEvent = this.XMLEventEvent;
					if (xMLEventEvent != null)
					{
						xMLEventEvent();
					}
					this.IsAnnoDataChanged = false;
				}
				return this._AnnoData;
			}
			set
			{
				this._AnnoData = value;
			}
		}

		public bool IsAnnoDataChanged
		{
			get
			{
				return this._IsAnnoDataChanged;
			}
			set
			{
				this._IsAnnoDataChanged = value;
				if (value)
				{
					this._HasSyncHotSpotCode = false;
				}
			}
		}

		private string HotSpotCode
		{
			get
			{
				if (!this._HasSyncHotSpotCode)
				{
					this._HotSpotCode = NIImageAnnotate.GetActiveHotSpotCode(this.AnnoData);
					this._HasSyncHotSpotCode = true;
				}
				return this._HotSpotCode;
			}
		}

		public NIImageAnnotate()
		{
			this._IsAnnoDataChanged = false;
			this._HotSpotCode = string.Empty;
			this._HasSyncHotSpotCode = false;
			this.SubItems = new NInstanceItemCollection();
		}

		public override void SyncMetaItem(MMetaItem metaitem)
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
			int arg_3E_0 = 0;
			checked
			{
				int num = metaitem.SubItems.Count - 1;
				for (int i = arg_3E_0; i <= num; i++)
				{
					MMetaItem mMetaItem = metaitem.SubItems[i];
					NInstanceItem nInstanceItem = this.SubItems[i];
					if (Operators.CompareString(mMetaItem.Code, nInstanceItem.Code, false) == 0)
					{
						if (nInstanceItem is NISimple)
						{
							nInstanceItem.BindMMetaItem = mMetaItem;
							mMetaItem.BindInstanceItem = nInstanceItem;
						}
					}
					else
					{
						MessageManager.ShowInformationMessage("同步异常！");
					}
				}
			}
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			NIImageAnnotate.XMLEventEventHandler xMLEventEvent = this.XMLEventEvent;
			if (xMLEventEvent != null)
			{
				xMLEventEvent();
			}
			writer.WriteStartElement("NIImageAnnotate");
			base.XMLSerialize(writer);
			writer.WriteStartElement("AnnoData");
			if (this.AnnoData != null)
			{
				this.AnnoData = this.AnnoData.Replace("]]>", "^^@");
			}
			writer.WriteCData(this.AnnoData);
			writer.WriteEndElement();
			writer.WriteStartElement("SubItems");
			NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				nInstanceItem.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this._AnnoData = reader.Value;
				this._AnnoData = this._AnnoData.Replace("^^@", "]]>");
				reader.Read();
			}
			reader.Read();
			if (Operators.CompareString(reader.Name, "SubItems", false) == 0 & !reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISimple", false) == 0)
					{
						NISimple nISimple = new NISimple();
						nISimple.XMLDeserialize(reader);
						this.SubItems.Add(this, nISimple);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}

		public override string GetByVType(string strType)
		{
			if (Operators.CompareString(strType.ToUpper(), "HSCODE", false) == 0)
			{
				return this.HotSpotCode;
			}
			return null;
		}

		private static string GetActiveHotSpotCode(string annoDataStr)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(annoDataStr);
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("x", "adobe:ns:meta/");
			xmlNamespaceManager.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
			xmlNamespaceManager.AddNamespace("xmp", "http://ns.abobe.com/xap/1.0/");
			xmlNamespaceManager.AddNamespace("ann", "http://ns.atalasoft.com/annotate/1.0/");
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//ann:AnnotationCollection/ann:CustomAnnotation/ann:HotSpotCode", xmlNamespaceManager);
			string text = "";
			int arg_7B_0 = 0;
			checked
			{
				int num = xmlNodeList.Count - 1;
				for (int i = arg_7B_0; i <= num; i++)
				{
					if (Operators.CompareString(xmlNodeList[i].InnerText, string.Empty, false) != 0)
					{
						if (Operators.CompareString(text, "", false) == 0)
						{
							text += xmlNodeList[i].InnerText;
						}
						else
						{
							text = text + "^" + xmlNodeList[i].InnerText;
						}
					}
				}
				return text;
			}
		}

		public static string GetXmlWithoutWangTime(string xml)
		{
			checked
			{
				string result;
				try
				{
					if (string.IsNullOrEmpty(xml))
					{
						result = xml;
					}
					else
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.LoadXml(xml);
						XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
						xmlNamespaceManager.AddNamespace("x", "adobe:ns:meta/");
						xmlNamespaceManager.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
						xmlNamespaceManager.AddNamespace("xmp", "http://ns.abobe.com/xap/1.0/");
						xmlNamespaceManager.AddNamespace("ann", "http://ns.atalasoft.com/annotate/1.0/");
						XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//AnnoData", xmlNamespaceManager);
						int arg_80_0 = 0;
						int num = xmlNodeList.Count - 1;
						for (int i = arg_80_0; i <= num; i++)
						{
							if (xmlNodeList[i].FirstChild != null)
							{
								if (xmlNodeList[i].FirstChild is XmlCDataSection)
								{
									if (!string.IsNullOrEmpty(xmlNodeList[i].FirstChild.Value))
									{
										XmlDocument xmlDocument2 = new XmlDocument();
										xmlDocument2.LoadXml(xmlNodeList[i].FirstChild.Value.Replace("<![CDATA[", ""));
										XmlNodeList xmlNodeList2 = xmlDocument2.SelectNodes("//ann:WangTime", xmlNamespaceManager);
										int arg_11C_0 = 0;
										int num2 = xmlNodeList2.Count - 1;
										for (int j = arg_11C_0; j <= num2; j++)
										{
											xmlNodeList2[j].InnerText = string.Empty;
										}
										xmlNodeList[i].FirstChild.Value = xmlDocument2.OuterXml;
									}
								}
							}
						}
						result = xmlDocument.OuterXml;
					}
				}
				catch (Exception expr_170)
				{
					ProjectData.SetProjectError(expr_170);
					Exception ex = expr_170;
					MessageManager.ShowErrorMessage("获取无WangTime内容的Xml内容错误!" + ex.StackTrace);
					result = xml;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}
	}
}
