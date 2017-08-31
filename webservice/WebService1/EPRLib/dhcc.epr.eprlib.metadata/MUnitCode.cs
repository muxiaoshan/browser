using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MUnitCode
	{
		private string _UnitCode;

		private string _UnitName;

		private string _UnitSymbol;

		private bool _DefaultUnit;

		private float _MinVal;

		private float _MaxVal;

		private bool _HasMinVal;

		private bool _HasMaxVal;

		private bool _IncludeMin;

		private bool _IncludeMax;

		private int _DecimalPlace;

		public string UnitCode
		{
			get
			{
				return this._UnitCode;
			}
			set
			{
				this._UnitCode = value;
			}
		}

		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				this._UnitName = value;
			}
		}

		public string UnitSymbol
		{
			get
			{
				return this._UnitSymbol;
			}
			set
			{
				this._UnitSymbol = value;
			}
		}

		public bool DefaultUnit
		{
			get
			{
				return this._DefaultUnit;
			}
			set
			{
				this._DefaultUnit = value;
			}
		}

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

		public MUnitCode()
		{
			this._DecimalPlace = 0;
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MUnitCode");
			writer.WriteElementString("UnitCode", this.UnitCode);
			writer.WriteElementString("UnitName", this.UnitName);
			writer.WriteElementString("UnitName", this.UnitSymbol);
			writer.WriteElementString("DefaultUnit", this.DefaultUnit.ToString());
			writer.WriteElementString("MinVal", this.MinVal.ToString());
			writer.WriteElementString("MaxVal", this.MaxVal.ToString());
			writer.WriteElementString("HasMinVal", this.HasMinVal.ToString());
			writer.WriteElementString("HasMaxVal", this.HasMaxVal.ToString());
			writer.WriteElementString("IncludeMin", this.IncludeMin.ToString());
			writer.WriteElementString("IncludeMax", this.IncludeMax.ToString());
			writer.WriteElementString("DecimalPlace", this.DecimalPlace.ToString());
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.UnitCode = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.UnitName = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.UnitSymbol = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.DefaultUnit = bool.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.MinVal = float.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.MaxVal = float.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.HasMinVal = bool.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.HasMaxVal = bool.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.IncludeMin = bool.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.IncludeMax = bool.Parse(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (Operators.CompareString(reader.Name, "DecimalPlace", false) == 0 & reader.IsStartElement())
			{
				reader.Read();
				this.DecimalPlace = int.Parse(reader.Value);
				reader.Read();
			}
		}
	}
}
