using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NInstanceData : NInstanceItem
	{
		private string _BindKBCode;

		public string BindKBCode
		{
			get
			{
				return this._BindKBCode;
			}
			set
			{
				this._BindKBCode = value;
			}
		}

		public NInstanceData()
		{
			this.SubItems = new NInstanceItemCollection();
		}

		public override void SyncMetaItem(MMetaItem metaitem)
		{
			if (!(metaitem is MMetaData))
			{
				return;
			}
			if (Operators.CompareString(this.Code, metaitem.Code, false) == 0)
			{
				this.BindMMetaItem = metaitem;
				metaitem.BindInstanceItem = this;
			}
			else
			{
				MessageManager.ShowInformationMessage("同步异常！");
			}
			int arg_47_0 = 0;
			checked
			{
				int num = metaitem.SubItems.Count - 1;
				for (int i = arg_47_0; i <= num; i++)
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
						else
						{
							nInstanceItem.SyncMetaItem(mMetaItem);
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
			writer.WriteStartElement("NInstanceData");
			base.XMLSerialize(writer);
			writer.WriteElementString("BindKBCode", this.BindKBCode);
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
			if (Operators.CompareString(reader.Name, "BindKBCode", false) == 0)
			{
				if (!reader.IsEmptyElement)
				{
					reader.Read();
					this._BindKBCode = reader.Value;
					reader.Read();
				}
				reader.Read();
			}
			if (!reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISimple", false) == 0)
					{
						NISimple nISimple = new NISimple();
						nISimple.XMLDeserialize(reader);
						this.SubItems.Add(this, nISimple);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NITable", false) == 0)
					{
						NITable nITable = new NITable();
						nITable.XMLDeserialize(reader);
						this.SubItems.Add(this, nITable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISegment", false) == 0)
					{
						NISegment nISegment = new NISegment();
						nISegment.XMLDeserialize(reader);
						this.SubItems.Add(this, nISegment);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NITextDesc", false) == 0)
					{
						NITextDesc nITextDesc = new NITextDesc();
						nITextDesc.XMLDeserialize(reader);
						this.SubItems.Add(this, nITextDesc);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIImageAnnotate", false) == 0)
					{
						NIImageAnnotate nIImageAnnotate = new NIImageAnnotate();
						nIImageAnnotate.XMLDeserialize(reader);
						this.SubItems.Add(this, nIImageAnnotate);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIFigure", false) == 0)
					{
						NIFigure nIFigure = new NIFigure();
						nIFigure.XMLDeserialize(reader);
						this.SubItems.Add(this, nIFigure);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}

		public NInstanceItem FindInstanceItemByCode(string code)
		{
			NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (Operators.CompareString(nInstanceItem.Code, code, false) == 0)
				{
					return nInstanceItem;
				}
				if (nInstanceItem is NICluster)
				{
					NInstanceItemEnumerator enumerator2 = nInstanceItem.SubItems.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						NInstanceItem nInstanceItem2 = (NInstanceItem)enumerator2.Current;
						if (Operators.CompareString(nInstanceItem2.Code, code, false) == 0)
						{
							return nInstanceItem2;
						}
					}
				}
			}
			return null;
		}
	}
}
