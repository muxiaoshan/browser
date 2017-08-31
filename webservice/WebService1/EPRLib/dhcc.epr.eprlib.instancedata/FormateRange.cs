using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class FormateRange
	{
		private FontStruct _FontStruct;

		private int _StartPos;

		private int _EndPos;

		private int _ItemStartPos;

		private int _ItemEndPos;

		private int _ItemNullLength;

		public FontStruct FontStruct
		{
			get
			{
				return this._FontStruct;
			}
			set
			{
				this._FontStruct = value;
			}
		}

		public int StartPos
		{
			get
			{
				return this._StartPos;
			}
			set
			{
				this._StartPos = value;
			}
		}

		public int EndPos
		{
			get
			{
				return this._EndPos;
			}
			set
			{
				this._EndPos = value;
			}
		}

		public int ItemStartPos
		{
			get
			{
				return this._ItemStartPos;
			}
			set
			{
				this._ItemStartPos = value;
			}
		}

		public int ItemEndPos
		{
			get
			{
				return this._ItemEndPos;
			}
			set
			{
				this._ItemEndPos = value;
			}
		}

		public int ItemNullLength
		{
			get
			{
				return this._ItemNullLength;
			}
			set
			{
				this._ItemNullLength = value;
			}
		}

		[DebuggerNonUserCode]
		public FormateRange()
		{
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("FormatRange");
			writer.WriteElementString("StartPos", this._StartPos.ToString());
			writer.WriteElementString("EndPos", this._EndPos.ToString());
			this._FontStruct.XMLSerialize(writer);
			writer.WriteElementString("ItemStartPos", this._ItemStartPos.ToString());
			writer.WriteElementString("ItemEndPos", this._ItemEndPos.ToString());
			writer.WriteElementString("ItemNullLength", this._ItemNullLength.ToString());
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "StartPos", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this._StartPos = int.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "EndPos", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this._EndPos = int.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "FontStruct", false) == 0 & !reader.IsEmptyElement)
				{
					this._FontStruct = new FontStruct();
					this._FontStruct.XMLDeserialize(reader);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "ItemStartPos", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this._ItemStartPos = int.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "ItemEndPos", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this._ItemEndPos = int.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "ItemNullLength", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this._ItemNullLength = int.Parse(reader.Value);
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "FormatRange", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
