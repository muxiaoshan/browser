using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MICluster : MMetaItem
	{
		public MICluster()
		{
			this.SubItems = new MMetaItemCollection();
		}

		public override NInstanceItem CreateInstance()
		{
			return new NICluster
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MICluster");
			base.XMLSerialize(writer);
			writer.WriteStartElement("SubItems");
			MMetaItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MMetaItem mMetaItem = (MMetaItem)enumerator.Current;
				mMetaItem.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "SubItems", false) == 0)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIString", false) == 0)
					{
						MIString mIString = new MIString();
						mIString.XMLDeserialize(reader);
						this.SubItems.Add(this, mIString);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MINumber", false) == 0)
					{
						MINumber mINumber = new MINumber();
						mINumber.XMLDeserialize(reader);
						this.SubItems.Add(this, mINumber);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIMonoChoice", false) == 0)
					{
						MIMonoChoice mIMonoChoice = new MIMonoChoice();
						mIMonoChoice.XMLDeserialize(reader);
						this.SubItems.Add(this, mIMonoChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIMultiChoice", false) == 0)
					{
						MIMultiChoice mIMultiChoice = new MIMultiChoice();
						mIMultiChoice.XMLDeserialize(reader);
						this.SubItems.Add(this, mIMultiChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIDateTime", false) == 0)
					{
						MIDateTime mIDateTime = new MIDateTime();
						mIDateTime.XMLDeserialize(reader);
						this.SubItems.Add(this, mIDateTime);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIQuantity", false) == 0)
					{
						MIQuantity mIQuantity = new MIQuantity();
						mIQuantity.XMLDeserialize(reader);
						this.SubItems.Add(this, mIQuantity);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIDictionary", false) == 0)
					{
						MIDictionary mIDictionary = new MIDictionary();
						mIDictionary.XMLDeserialize(reader);
						this.SubItems.Add(this, mIDictionary);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIPosition", false) == 0)
					{
						MIPosition mIPosition = new MIPosition();
						mIPosition.XMLDeserialize(reader);
						this.SubItems.Add(this, mIPosition);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MISegment", false) == 0)
					{
						MISegment mISegment = new MISegment();
						mISegment.XMLDeserialize(reader);
						this.SubItems.Add(this, mISegment);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MITextDesc", false) == 0)
					{
						MITextDesc mITextDesc = new MITextDesc();
						mITextDesc.XMLDeserialize(reader);
						this.SubItems.Add(this, mITextDesc);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MITable", false) == 0)
					{
						MITable mITable = new MITable();
						mITable.XMLDeserialize(reader);
						this.SubItems.Add(this, mITable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIImageAnnotate", false) == 0)
					{
						MIImageAnnotate mIImageAnnotate = new MIImageAnnotate();
						mIImageAnnotate.XMLDeserialize(reader);
						this.SubItems.Add(this, mIImageAnnotate);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
				return true;
			}
			return false;
		}
	}
}
