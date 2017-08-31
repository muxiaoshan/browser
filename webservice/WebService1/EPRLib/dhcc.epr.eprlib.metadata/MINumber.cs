using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MINumber : MISimple
	{
		private float _MinVal;

		private float _MaxVal;

		private bool _HasMinVal;

		private bool _HasMaxVal;

		private bool _IncludeMin;

		private bool _IncludeMax;

		private int _DecimalPlace;

		public float MinVal
		{
			get
			{
				return this._MinVal;
			}
			set
			{
				this._MinVal = value;
			}
		}

		public float MaxVal
		{
			get
			{
				return this._MaxVal;
			}
			set
			{
				this._MaxVal = value;
			}
		}

		public bool HasMinVal
		{
			get
			{
				return this._HasMinVal;
			}
			set
			{
				this._HasMinVal = value;
			}
		}

		public bool HasMaxVal
		{
			get
			{
				return this._HasMaxVal;
			}
			set
			{
				this._HasMaxVal = value;
			}
		}

		public bool IncludeMin
		{
			get
			{
				return this._IncludeMin;
			}
			set
			{
				this._IncludeMin = value;
			}
		}

		public bool IncludeMax
		{
			get
			{
				return this._IncludeMax;
			}
			set
			{
				this._IncludeMax = value;
			}
		}

		public int DecimalPlace
		{
			get
			{
				return this._DecimalPlace;
			}
			set
			{
				this._DecimalPlace = value;
			}
		}

		public MINumber()
		{
			this._DecimalPlace = 0;
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MINumber");
			base.XMLSerialize(writer);
			writer.WriteElementString("MinVal", this.MinVal.ToString());
			writer.WriteElementString("MaxVal", this.MaxVal.ToString());
			writer.WriteElementString("HasMinVal", this.HasMinVal.ToString());
			writer.WriteElementString("HasMaxVal", this.HasMaxVal.ToString());
			writer.WriteElementString("IncludeMin", this.IncludeMin.ToString());
			writer.WriteElementString("IncludeMax", this.IncludeMax.ToString());
			writer.WriteElementString("DecimalPlace", this.DecimalPlace.ToString());
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "MinVal", false) == 0)
			{
				reader.Read();
				this.MinVal = float.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "MaxVal", false) == 0)
			{
				reader.Read();
				this.MaxVal = float.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "HasMinVal", false) == 0)
			{
				reader.Read();
				this.HasMinVal = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "HasMaxVal", false) == 0)
			{
				reader.Read();
				this.HasMaxVal = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "IncludeMin", false) == 0)
			{
				reader.Read();
				this.IncludeMin = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "IncludeMax", false) == 0)
			{
				reader.Read();
				this.IncludeMax = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "DecimalPlace", false) == 0)
			{
				reader.Read();
				this.DecimalPlace = int.Parse(reader.Value);
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
