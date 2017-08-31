using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NIFree : NInstanceItem
	{
		public NIFree()
		{
			this.Value = "";
			this.FormatRangeCollection = new FormateRangeCollection();
		}

		public override Controller CreateController()
		{
			return new FreeController
			{
				BindInstanceItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			string value = this.Value;
			string text = this.Value.Replace(" ", "&nbsp;");
			this.Value = text.ToString();
			text = this.Value.Replace("\r", "&KeyEnter;");
			this.Value = text.ToString();
			writer.WriteStartElement("NIFree");
			writer.WriteElementString("Code", this.Code);
			writer.WriteElementString("Value", this.Value);
			writer.WriteElementString("ValueCode", this.ValueCode);
			if (this.FormatRangeCollection != null)
			{
				this.FormatRangeCollection.XMLSerialize(writer);
			}
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "Code", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.Code = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "Value", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.Value = reader.Value.Replace("&nbsp;", " ");
					this.Value = this.Value.Replace("&KeyEnter;", "\r");
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "ValueCode", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.ValueCode = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
				{
					this.FormatRangeCollection.XMLDeserialize(reader);
				}
				if (Operators.CompareString(reader.Name, "NIFree", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
