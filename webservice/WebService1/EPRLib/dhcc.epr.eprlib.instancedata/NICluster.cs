using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NICluster : NInstanceItem
	{
		public NICluster()
		{
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
						if (mMetaItem is MISimple)
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
			writer.WriteStartElement("NICluster");
			base.XMLSerialize(writer);
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
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}
	}
}
