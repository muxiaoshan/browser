using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIMonoChoice : MISimple
	{
		private StringCollection _Choices;

		public StringCollection Choices
		{
			get
			{
				return this._Choices;
			}
			set
			{
				this._Choices = value;
			}
		}

		public MIMonoChoice()
		{
			this._Choices = new StringCollection();
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIMonoChoice");
			base.XMLSerialize(writer);
			writer.WriteStartElement("Choices");
			StringEnumerator enumerator = this.Choices.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				writer.WriteElementString("Choice", current);
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
			if (Operators.CompareString(tagName, "Choices", false) == 0)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "Choice", false) == 0)
					{
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							this.Choices.Add(reader.Value);
						}
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Choices", false) == 0)
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
