using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIQuantity : MISimple
	{
		private string _UnitTypeCode;

		private string _UnitTypeName;

		private MUnitCodeCollection _UnitCodes;

		public string UnitTypeCode
		{
			get
			{
				return this._UnitTypeCode;
			}
			set
			{
				this._UnitTypeCode = value;
			}
		}

		public string UnitTypeName
		{
			get
			{
				return this._UnitTypeName;
			}
			set
			{
				this._UnitTypeName = value;
			}
		}

		public MUnitCodeCollection UnitCodes
		{
			get
			{
				return this._UnitCodes;
			}
			set
			{
				this._UnitCodes = value;
			}
		}

		public MIQuantity()
		{
			this._UnitCodes = new MUnitCodeCollection();
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIQuantity");
			base.XMLSerialize(writer);
			writer.WriteElementString("UnitTypeCode", this.UnitTypeCode);
			writer.WriteElementString("UnitTypeName", this.UnitTypeName);
			writer.WriteStartElement("UnitCodes");
			MUnitCodeEnumerator enumerator = this.UnitCodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MUnitCode mUnitCode = (MUnitCode)enumerator.Current;
				mUnitCode.XMLSerialize(writer);
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
			if (Operators.CompareString(tagName, "UnitTypeCode", false) == 0)
			{
				reader.Read();
				this.UnitTypeCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "UnitTypeName", false) == 0)
			{
				reader.Read();
				this.UnitTypeName = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "UnitCodes", false) == 0)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MUnitCode", false) == 0)
					{
						MUnitCode mUnitCode = new MUnitCode();
						mUnitCode.XMLDeserialize(reader);
						this.UnitCodes.Add(mUnitCode);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "UnitCodes", false) == 0)
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
