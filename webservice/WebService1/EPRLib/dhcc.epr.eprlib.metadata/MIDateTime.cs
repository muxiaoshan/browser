using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIDateTime : MISimple
	{
		private bool _IncludeDate;

		private bool _IncludeTime;

		private string _DateFormate;

		private string _TimeFormate;

		public const string LONDGDATE = "LONG";

		public const string SHORTDATE = "SHORT";

		public const string LONGTIME = "LONG";

		public const string SHORTTIME = "SHORT";

		public bool IncludeDate
		{
			get
			{
				return this._IncludeDate;
			}
			set
			{
				this._IncludeDate = value;
			}
		}

		public bool IncludeTime
		{
			get
			{
				return this._IncludeTime;
			}
			set
			{
				this._IncludeTime = value;
			}
		}

		public string DateFormate
		{
			get
			{
				return this._DateFormate;
			}
			set
			{
				this._DateFormate = value;
			}
		}

		public string TimeFormate
		{
			get
			{
				return this._TimeFormate;
			}
			set
			{
				this._TimeFormate = value;
			}
		}

		public MIDateTime()
		{
			this._IncludeDate = true;
			this._IncludeTime = false;
			this._DateFormate = "LONG";
			this._TimeFormate = "LONG";
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIDateTime");
			base.XMLSerialize(writer);
			writer.WriteElementString("IncludeDate", this.IncludeDate.ToString());
			writer.WriteElementString("IncludeTime", this.IncludeTime.ToString());
			writer.WriteElementString("DateFormate", this.DateFormate);
			writer.WriteElementString("TimeFormate", this.TimeFormate);
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "IncludeDate", false) == 0)
			{
				reader.Read();
				this.IncludeDate = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "IncludeTime", false) == 0)
			{
				reader.Read();
				this.IncludeTime = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "DateFormate", false) == 0)
			{
				reader.Read();
				this.DateFormate = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "TimeFormate", false) == 0)
			{
				reader.Read();
				this.TimeFormate = reader.Value;
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
