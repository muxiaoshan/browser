using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIFigure : MMetaItem
	{
		private bool _BindImageLib;

		private string _BindImageLibID;

		private string _BindImageLibName;

		public bool BindImageLib
		{
			get
			{
				return this._BindImageLib;
			}
			set
			{
				this._BindImageLib = value;
			}
		}

		public string BindImageLibID
		{
			get
			{
				return this._BindImageLibID;
			}
			set
			{
				this._BindImageLibID = value;
			}
		}

		public string BindImageLibName
		{
			get
			{
				return this._BindImageLibName;
			}
			set
			{
				this._BindImageLibName = value;
			}
		}

		public MIFigure()
		{
			this._BindImageLib = false;
			this._BindImageLibID = string.Empty;
			this._BindImageLibName = string.Empty;
			this.SubItems = new MMetaItemCollection();
			this._BindImageLib = false;
			this._BindImageLibID = string.Empty;
			this._BindImageLibName = string.Empty;
		}

		public override NInstanceItem CreateInstance()
		{
			return new NIFigure
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIFigure");
			base.XMLSerialize(writer);
			writer.WriteElementString("BindImageLib", Conversions.ToString(this.BindImageLib));
			writer.WriteElementString("BindImageLibID", this.BindImageLibID);
			writer.WriteElementString("BindImageLibName", this.BindImageLibName);
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "BindImageLib", false) == 0)
			{
				reader.Read();
				this._BindImageLib = Conversions.ToBoolean(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindImageLibID", false) == 0)
			{
				reader.Read();
				this._BindImageLibID = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindImageLibName", false) == 0)
			{
				reader.Read();
				this._BindImageLibName = reader.Value;
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
