using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NIRow : NInstanceItem
	{
		public NIRow()
		{
			this.SubItems = new NInstanceItemCollection();
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NIRow");
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
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}
	}
}
