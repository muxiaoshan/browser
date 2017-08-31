using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIMultiChoice : MISimple
	{
		private StringCollection _Choices;

		private string _Seperator;

		private bool _WrapChoice;

		private int _LineSpace;

		private bool _CrossModel;

		public StringCollection Choices
		{
			get
			{
				return this._Choices;
			}
			set
			{
				this._Choices = value;
			}
		}

		public string Seperator
		{
			get
			{
				return this._Seperator;
			}
			set
			{
				this._Seperator = value;
			}
		}

		public bool WrapChoice
		{
			get
			{
				return this._WrapChoice;
			}
			set
			{
				this._WrapChoice = value;
			}
		}

		public int LineSpace
		{
			get
			{
				return this._LineSpace;
			}
			set
			{
				this._LineSpace = value;
			}
		}

		public bool CrossModel
		{
			get
			{
				return this._CrossModel;
			}
			set
			{
				this._CrossModel = value;
			}
		}

		public MIMultiChoice()
		{
			this._Seperator = "";
			this._Choices = new StringCollection();
			this._WrapChoice = false;
			this._LineSpace = 6;
			this._CrossModel = false;
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MIMultiChoice");
			base.XMLSerialize(writer);
			writer.WriteElementString("Seperator", this.Seperator);
			writer.WriteStartElement("Choices");
			StringEnumerator enumerator = this.Choices.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				writer.WriteElementString("Choice", current);
			}
			writer.WriteEndElement();
			writer.WriteElementString("WrapChoice", this.WrapChoice.ToString());
			writer.WriteElementString("LineSpace", this.LineSpace.ToString());
			writer.WriteElementString("CrossModel", this.CrossModel.ToString());
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "Seperator", false) == 0)
			{
				reader.Read();
				this.Seperator = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Choices", false) == 0)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "Choice", false) == 0)
					{
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							this.Choices.Add(reader.Value);
						}
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Choices", false) == 0)
					{
						break;
					}
				}
				return true;
			}
			if (Operators.CompareString(tagName, "WrapChoice", false) == 0)
			{
				reader.Read();
				if (Operators.CompareString(reader.Value, "True", false) == 0)
				{
					this.WrapChoice = true;
				}
				else
				{
					this.WrapChoice = false;
				}
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "MiddleSpace", false) == 0)
			{
				reader.Read();
				this.LineSpace = Conversions.ToInteger(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "CrossModel", false) == 0)
			{
				reader.Read();
				this.CrossModel = Conversions.ToBoolean(reader.Value);
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
