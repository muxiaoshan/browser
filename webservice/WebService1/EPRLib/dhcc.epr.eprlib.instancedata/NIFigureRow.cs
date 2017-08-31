using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NIFigureRow : NInstanceItem
	{
		private string _FigureData;

		private string _FigureDesc;

		private string _FigureType;

		private string _FigureID;

		private string _AnnoData;

		public string FigureData
		{
			get
			{
				return this._FigureData;
			}
			set
			{
				this._FigureData = value;
			}
		}

		public string FigureDesc
		{
			get
			{
				return this._FigureDesc;
			}
			set
			{
				this._FigureDesc = value;
			}
		}

		public string FigureType
		{
			get
			{
				return this._FigureType;
			}
			set
			{
				this._FigureType = value;
			}
		}

		public string FigureID
		{
			get
			{
				return this._FigureID;
			}
			set
			{
				this._FigureID = value;
			}
		}

		public string AnnoData
		{
			get
			{
				return this._AnnoData;
			}
			set
			{
				this._AnnoData = value;
			}
		}

		public NIFigureRow()
		{
			this.Value = "";
			this.SubItems = new NInstanceItemCollection();
			this._FigureData = "";
			this._FigureDesc = "";
			this._FigureType = "";
			this._FigureID = "";
			this._AnnoData = "";
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NIFigureRow");
			base.XMLSerialize(writer);
			writer.WriteStartElement("FigureDesc");
			writer.WriteString(this.FigureDesc);
			writer.WriteEndElement();
			writer.WriteStartElement("FigureData");
			if (this.FigureData != null)
			{
				this.FigureData = this.FigureData.Replace("]]>", "^^@");
			}
			writer.WriteCData(this.FigureData);
			writer.WriteEndElement();
			writer.WriteStartElement("FigureType");
			writer.WriteString(this.FigureType);
			writer.WriteEndElement();
			writer.WriteStartElement("FigureID");
			writer.WriteString(this.FigureID);
			writer.WriteEndElement();
			writer.WriteStartElement("AnnoData");
			if (this.AnnoData != null)
			{
				this.AnnoData = this.AnnoData.Replace("]]>", "^^@");
			}
			writer.WriteCData(this.AnnoData);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "FigureDesc", false) == 0 && !reader.IsEmptyElement)
				{
					reader.Read();
					this.FigureDesc = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "FigureData", false) == 0 && !reader.IsEmptyElement)
				{
					reader.Read();
					this.FigureData = reader.Value;
					this.FigureData = this.FigureData.Replace("^^@", "]]>");
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "FigureType", false) == 0 && !reader.IsEmptyElement)
				{
					reader.Read();
					this.FigureType = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "FigureID", false) == 0 && !reader.IsEmptyElement)
				{
					reader.Read();
					this.FigureID = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "AnnoData", false) == 0 && !reader.IsEmptyElement)
				{
					reader.Read();
					this.AnnoData = reader.Value;
					this.AnnoData = this.AnnoData.Replace("^^@", "]]>");
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "NIFigureRow", false) == 0 && reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
