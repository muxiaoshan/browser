using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIString : MISimple
	{
		private string _RegExp;

		public const int DefaultLength = -1;

		private int _MaxLength;

		public string RegExp
		{
			get
			{
				return this._RegExp;
			}
			set
			{
				this._RegExp = value;
			}
		}

		public bool NeedCheckLength
		{
			get
			{
				return this._MaxLength != -1;
			}
		}

		public int MaxLength
		{
			get
			{
				return this._MaxLength;
			}
			set
			{
				if (value < 0)
				{
					this._MaxLength = -1;
				}
				else if (value > 100000)
				{
					this._MaxLength = -1;
				}
				else
				{
					this._MaxLength = value;
				}
			}
		}

		public MIString()
		{
			this._MaxLength = -1;
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIString");
			base.XMLSerialize(writer);
			writer.WriteElementString("RegExp", this.RegExp);
			writer.WriteElementString("MaxLength", Conversions.ToString(this.MaxLength));
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "RegExp", false) == 0)
			{
				reader.Read();
				this.RegExp = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "MaxLength", false) == 0)
			{
				reader.Read();
				if (Operators.CompareString(reader.Value, "", false) != 0)
				{
					this.MaxLength = Conversions.ToInteger(reader.Value);
					reader.Read();
				}
				return true;
			}
			return false;
		}
	}
}
