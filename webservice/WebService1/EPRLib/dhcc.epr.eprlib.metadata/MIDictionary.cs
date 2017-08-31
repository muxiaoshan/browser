using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIDictionary : MISimple
	{
		private string _DictionaryType;

		private string _StdDicName;

		private string _StdDicCode;

		private string _CustDicClassName;

		private DisplayType _DisplayType;

		private string _Seporator;

		private ColType _FirstColType;

		private ColType _SecondColType;

		private ColType _ThirdColType;

		private bool _AllowCodeNull;

		private bool _AllowValueNull;

		private string _AssociateItem;

		public const string STDDIC = "STDDIC";

		public const string CUSTDIC = "CUSTDIC";

		public string DictionaryType
		{
			get
			{
				return this._DictionaryType;
			}
			set
			{
				this._DictionaryType = value;
			}
		}

		public string StdDicName
		{
			get
			{
				return this._StdDicName;
			}
			set
			{
				this._StdDicName = value;
			}
		}

		public string StdDicCode
		{
			get
			{
				return this._StdDicCode;
			}
			set
			{
				this._StdDicCode = value;
			}
		}

		public string CustDicClassName
		{
			get
			{
				return this._CustDicClassName;
			}
			set
			{
				this._CustDicClassName = value;
			}
		}

		public DisplayType DisplayType
		{
			get
			{
				return this._DisplayType;
			}
			set
			{
				this._DisplayType = value;
			}
		}

		public string Seporator
		{
			get
			{
				return this._Seporator;
			}
			set
			{
				this._Seporator = value;
			}
		}

		public ColType FirstColType
		{
			get
			{
				return this._FirstColType;
			}
			set
			{
				this._FirstColType = value;
			}
		}

		public ColType SecondColType
		{
			get
			{
				return this._SecondColType;
			}
			set
			{
				this._SecondColType = value;
			}
		}

		public ColType ThirdColType
		{
			get
			{
				return this._ThirdColType;
			}
			set
			{
				this._ThirdColType = value;
			}
		}

		public bool AllowCodeNull
		{
			get
			{
				return this._AllowCodeNull;
			}
			set
			{
				this._AllowCodeNull = value;
			}
		}

		public bool AllowValueNull
		{
			get
			{
				return this._AllowValueNull;
			}
			set
			{
				this._AllowValueNull = value;
			}
		}

		public string AssociateItem
		{
			get
			{
				return Conversions.ToString(Interaction.IIf(this._AssociateItem == null, string.Empty, this._AssociateItem));
			}
			set
			{
				this._AssociateItem = value;
			}
		}

		public MIDictionary()
		{
			this._DictionaryType = "STDDIC";
			this._DisplayType = DisplayType.Desc;
			this._Seporator = "|";
			this._FirstColType = ColType.Alias;
			this._SecondColType = ColType.Code;
			this._ThirdColType = ColType.Desc;
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIDictionary");
			base.XMLSerialize(writer);
			writer.WriteElementString("DictionaryType", this.DictionaryType);
			writer.WriteElementString("StdDicCode", this.StdDicCode);
			writer.WriteElementString("StdDicName", this.StdDicName);
			writer.WriteElementString("CustDicClassName", this.CustDicClassName);
			writer.WriteElementString("DisplayType", this.DisplayType.ToString());
			writer.WriteElementString("Seporator", this.Seporator);
			writer.WriteElementString("FirstColType", this.FirstColType.ToString());
			writer.WriteElementString("SecondColType", this.SecondColType.ToString());
			writer.WriteElementString("ThirdColType", this.ThirdColType.ToString());
			writer.WriteElementString("AllowCodeNull", this.AllowCodeNull.ToString());
			writer.WriteElementString("AllowValueNull", this.AllowValueNull.ToString());
			writer.WriteElementString("AssociateItem", this.AssociateItem.ToString());
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "DictionaryType", false) == 0)
			{
				reader.Read();
				this.DictionaryType = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "StdDicCode", false) == 0)
			{
				reader.Read();
				this.StdDicCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "StdDicName", false) == 0)
			{
				reader.Read();
				this.StdDicName = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "CustDicClassName", false) == 0)
			{
				reader.Read();
				this.CustDicClassName = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "DisplayType", false) == 0)
			{
				reader.Read();
				this.DisplayType = (DisplayType)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.DisplayType"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Seporator", false) == 0)
			{
				reader.Read();
				this.Seporator = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "FirstColType", false) == 0)
			{
				reader.Read();
				this.FirstColType = (ColType)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.ColType"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "SecondColType", false) == 0)
			{
				reader.Read();
				this.SecondColType = (ColType)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.ColType"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "ThirdColType", false) == 0)
			{
				reader.Read();
				this.ThirdColType = (ColType)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.ColType"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "AllowCodeNull", false) == 0)
			{
				reader.Read();
				this.AllowCodeNull = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "AllowValueNull", false) == 0)
			{
				reader.Read();
				this.AllowValueNull = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "AssociateItem", false) == 0)
			{
				reader.Read();
				this.AssociateItem = reader.Value;
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
