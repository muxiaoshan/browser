using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIPosition : MISimple
	{
		private string _ImageCode;

		private string _ImageName;

		public string ImageCode
		{
			get
			{
				return this._ImageCode;
			}
			set
			{
				this._ImageCode = value;
			}
		}

		public string ImageName
		{
			get
			{
				return this._ImageName;
			}
			set
			{
				this._ImageName = value;
			}
		}

		[DebuggerNonUserCode]
		public MIPosition()
		{
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIPosition");
			base.XMLSerialize(writer);
			writer.WriteElementString("ImageCode", this.ImageCode);
			writer.WriteElementString("ImageName", this.ImageName);
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "ImageCode", false) == 0)
			{
				reader.Read();
				this.ImageCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "ImageName", false) == 0)
			{
				reader.Read();
				this.ImageName = reader.Value;
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
