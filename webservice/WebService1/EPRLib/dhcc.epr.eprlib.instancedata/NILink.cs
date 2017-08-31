using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NILink : NInstanceItem
	{
		public override string WholeString
		{
			get
			{
				return this.Value;
			}
		}

		public NILink()
		{
			this.Value = "";
			this.FormatRangeCollection = new FormateRangeCollection();
		}

		public override Controller CreateController()
		{
			return new LinkController
			{
				BindInstanceItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NILink");
			writer.WriteElementString("Code", this.Code);
			writer.WriteElementString("Value", this.Value);
			writer.WriteElementString("ValueCode", this.ValueCode);
			if (this.FormatRangeCollection != null)
			{
				this.FormatRangeCollection.XMLSerialize(writer);
			}
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "Code", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.Code = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "Value", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.Value = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "ValueCode", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.ValueCode = reader.Value;
					reader.Read();
				}
				if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
				{
					this.FormatRangeCollection.XMLDeserialize(reader);
				}
				if (Operators.CompareString(reader.Name, "NILink", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}

		protected override NInstanceItem.BindDataType GetEPRBindData(string str)
		{
			NInstanceItem.BindDataType result = default(NInstanceItem.BindDataType);
			string[] array = this.BindMMetaItem.EPRBindCode.Split(new char[]
			{
				'#'
			});
			if (Operators.CompareString(array[1], "TYPE:Simple", false) == 0)
			{
				result.IsTypeMatching = true;
				result.IsUseValueCode = false;
				result.Value = str.Replace("&nbsp;", " ");
			}
			else if (Operators.CompareString(array[1], "TYPE:Segment", false) == 0)
			{
				string text = str.Split(new char[]
				{
					'@'
				})[0].Replace("&nbsp;", " ");
				if (Operators.CompareString(text, "*NULL", false) == 0)
				{
					text = "";
				}
				result.IsTypeMatching = true;
				result.IsUseValueCode = false;
				result.Value = text;
			}
			else if (Operators.CompareString(array[1], "TYPE:TextDesc", false) == 0)
			{
				string text2 = str.Split(new char[]
				{
					'@'
				})[0].Replace("&nbsp;", " ");
				if (Operators.CompareString(text2, "*NULL", false) == 0)
				{
					text2 = "";
				}
				result.IsTypeMatching = true;
				result.IsUseValueCode = false;
				result.Value = text2;
			}
			return result;
		}

		protected override NInstanceItem.BindDataType GetDataBaseData(string str)
		{
			return new NInstanceItem.BindDataType
			{
				IsUseValueCode = false,
				Value = str
			};
		}
	}
}
