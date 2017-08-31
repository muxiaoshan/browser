using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class FontStruct
	{
		public bool Subscript;

		public bool Superscript;

		public string Name;

		public float Size;

		public GraphicsUnit Unit;

		public bool Bold;

		public bool Italic;

		public bool Underline;

		public bool Strikeout;

		public byte GdiCharset;

		public bool GdiVerticalFont;

		public int CharOffset;

		private Font _font;

		public Font Font
		{
			get
			{
				return this._font;
			}
			set
			{
				this.Name = value.Name;
				this.Size = value.Size;
				this.Unit = value.Unit;
				this.Bold = value.Bold;
				this.Italic = value.Italic;
				this.Underline = value.Underline;
				this.Strikeout = value.Strikeout;
				this.GdiCharset = value.GdiCharSet;
				this.GdiVerticalFont = value.GdiVerticalFont;
				this._font = value;
			}
		}

		public FontStruct()
		{
		}

		public FontStruct(Font curFont)
		{
			this.Font = curFont;
		}

		public bool IsNormal()
		{
			return !this.Bold & !this.Italic & !this.Underline & !this.Strikeout & this.CharOffset == 0;
		}

		public void ResetFont()
		{
			this.CharOffset = 0;
			if (this.Superscript)
			{
				this.CharOffset = 4;
			}
			if (this.Subscript)
			{
				this.CharOffset = -4;
			}
			float emSize;
			if (this.Superscript | this.Subscript)
			{
				emSize = this.Size - 1f;
			}
			else
			{
				emSize = this.Size;
			}
			FontStyle style = this.CombineFontStyle(this.Bold, this.Italic, this.Strikeout, this.Underline);
			this._font = new Font(this.Name, emSize, style, this.Unit, this.GdiCharset, this.GdiVerticalFont);
		}

		public void ResetFontSize(float size)
		{
			FontStyle style = this.CombineFontStyle(this.Bold, this.Italic, this.Strikeout, this.Underline);
			this._font = new Font(this.Name, size, style, this.Unit, this.GdiCharset, this.GdiVerticalFont);
		}

		private FontStyle CombineFontStyle(bool blBold, bool blItalic, bool blStrikeout, bool blUnderline)
		{
			string text = "";
			if (blBold)
			{
				text += "Bold";
			}
			if (blItalic)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += ",";
				}
				text += "Italic";
			}
			if (blStrikeout)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += ",";
				}
				text += "Strikeout";
			}
			if (blUnderline)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += ",";
				}
				text += "Underline";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				text += "Regular";
			}
			return (FontStyle)Conversions.ToInteger(Enum.Parse(typeof(FontStyle), text, true));
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("FontStruct");
			writer.WriteElementString("Name", this.Name);
			writer.WriteElementString("Size", this.Size.ToString());
			writer.WriteElementString("Unit", this.Unit.ToString());
			writer.WriteElementString("Bold", this.Bold.ToString());
			writer.WriteElementString("GdiCharset", this.GdiCharset.ToString());
			writer.WriteElementString("GdiVerticalFont", Conversions.ToString(this.GdiVerticalFont));
			writer.WriteElementString("Italic", this.Italic.ToString());
			writer.WriteElementString("Strikeout", this.Strikeout.ToString());
			writer.WriteElementString("Underline", this.Underline.ToString());
			writer.WriteElementString("Superscript", this.Superscript.ToString());
			writer.WriteElementString("Subscript", this.Subscript.ToString());
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Name = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Size = Convert.ToSingle(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Unit = (GraphicsUnit)Conversions.ToInteger(Enum.Parse(typeof(GraphicsUnit), reader.Value, true));
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Bold = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.GdiCharset = Convert.ToByte(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.GdiVerticalFont = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Italic = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Strikeout = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Underline = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Superscript = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Subscript = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			reader.Read();
			this.ResetFont();
		}
	}
}
