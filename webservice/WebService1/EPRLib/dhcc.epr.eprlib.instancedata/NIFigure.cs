using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NIFigure : NInstanceItem
	{
		public NIFigure()
		{
			this.SubItems = new NInstanceItemCollection();
		}

		public void InitData()
		{
			this.SubItems.Clear();
			NIFigureRow value = new NIFigureRow();
			this.SubItems.Add(value);
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NIFigure");
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
					if (Operators.CompareString(reader.Name, "NIFigureRow", false) == 0 & reader.NodeType == XmlNodeType.Element)
					{
						NIFigureRow nIFigureRow = new NIFigureRow();
						nIFigureRow.XMLDeserialize(reader);
						this.SubItems.Add(this, nIFigureRow);
					}
					else if (Operators.CompareString(reader.Name, "SubItems", false) == 0 && reader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
			}
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
		}
	}
}
