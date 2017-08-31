using dhcc.epr.eprlib.design.interfacedesign;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class ControlXML
	{
		public static int ScrollX;

		public static int ScrollY;

		[DebuggerNonUserCode]
		public ControlXML()
		{
		}

		public static void XMLSerialize(XmlWriter writer, DesignControl ctrl)
		{
			writer.WriteElementString("Name", ctrl.Name);
			string value = "";
			if (ctrl.PControl is Label)
			{
				value = ctrl.PControl.Text;
			}
			writer.WriteElementString("Text", value);
			checked
			{
				writer.WriteElementString("Left", (ctrl.OriginLeft - ControlXML.ScrollX).ToString());
				writer.WriteElementString("Top", (ctrl.OriginTop - ControlXML.ScrollY).ToString());
				writer.WriteElementString("Width", Convert.ToString(ctrl.OriginWidth));
				writer.WriteElementString("Height", Convert.ToString(ctrl.OriginHeight));
				writer.WriteElementString("BackColor", ctrl.PControl.BackColor.Name);
				writer.WriteElementString("ForeColor", ctrl.PControl.ForeColor.Name);
				writer.WriteElementString("TabIndex", ctrl.TabIndex.ToString());
				writer.WriteElementString("Enabled", Conversions.ToString(ctrl.IEnabled));
				writer.WriteStartElement("Font");
				writer.WriteElementString("Name", ctrl.PControl.Font.Name);
				writer.WriteElementString("Size", ctrl.PControl.Font.Size.ToString());
				writer.WriteElementString("Unit", ctrl.PControl.Font.Unit.ToString());
				writer.WriteElementString("Bold", ctrl.PControl.Font.Bold.ToString());
				writer.WriteElementString("GdiCharset", ctrl.Font.GdiCharSet.ToString());
				writer.WriteElementString("GdiVerticalFont", Conversions.ToString(ctrl.Font.GdiVerticalFont));
				writer.WriteElementString("Italic", ctrl.PControl.Font.Italic.ToString());
				writer.WriteElementString("Strikeout", ctrl.PControl.Font.Strikeout.ToString());
				writer.WriteElementString("Underline", ctrl.PControl.Font.Underline.ToString());
				writer.WriteEndElement();
			}
		}

		public static void XMLDeserialize(XmlReader reader, Control ctrl)
		{
			bool flag = false;
			string familyName = null;
			if (ctrl is DesignControl)
			{
				DesignControl designControl = (DesignControl)ctrl;
				while (reader.Read())
				{
					if (!reader.IsEmptyElement)
					{
						if (reader.NodeType == XmlNodeType.EndElement & (Operators.CompareString(reader.Name, "PCString", false) == 0 | Operators.CompareString(reader.Name, "PCNumber", false) == 0 | Operators.CompareString(reader.Name, "PCMonoChoice", false) == 0 | Operators.CompareString(reader.Name, "PCMultiChoice", false) == 0 | Operators.CompareString(reader.Name, "PCDictionary", false) == 0 | Operators.CompareString(reader.Name, "PCDateTime", false) == 0 | Operators.CompareString(reader.Name, "PCPosition", false) == 0 | Operators.CompareString(reader.Name, "PCQuantity", false) == 0 | Operators.CompareString(reader.Name, "PCTextEdit", false) == 0 | Operators.CompareString(reader.Name, "PCImageAnnotate", false) == 0 | Operators.CompareString(reader.Name, "PCTable", false) == 0 | Operators.CompareString(reader.Name, "PCLabel", false) == 0 | Operators.CompareString(reader.Name, "PCVLine", false) == 0 | Operators.CompareString(reader.Name, "PCHLine", false) == 0 | Operators.CompareString(reader.Name, "PCBox", false) == 0 | Operators.CompareString(reader.Name, "PCAlignTable", false) == 0 | Operators.CompareString(reader.Name, "PCFigure", false) == 0))
						{
							break;
						}
						if (reader.NodeType == XmlNodeType.Element)
						{
							if (Operators.CompareString(reader.Name, "Font", false) == 0)
							{
								while (reader.Read())
								{
									if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Font", false) == 0)
									{
										bool blBold;
										bool blItalic;
										bool blStrikeout;
										bool blUnderline;
										FontStyle style = ControlXML.CombineFontStyle(blBold, blItalic, blStrikeout, blUnderline);
										float emSize;
										GraphicsUnit unit;
										byte gdiCharSet;
										bool gdiVerticalFont;
										designControl.PControl.Font = new Font(familyName, emSize, style, unit, gdiCharSet, gdiVerticalFont);
										return;
									}
									string name = reader.Name;
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											familyName = reader.Value;
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Size", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											float emSize = Convert.ToSingle(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Unit", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											GraphicsUnit unit = (GraphicsUnit)Conversions.ToInteger(Enum.Parse(typeof(GraphicsUnit), reader.Value, true));
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Bold", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blBold = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "GdiCharset", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											byte gdiCharSet = Convert.ToByte(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "GdiVerticalFont", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool gdiVerticalFont = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Italic", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blItalic = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Strikeout", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blStrikeout = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name, "Underline", false) == 0 && !reader.IsEmptyElement)
									{
										reader.Read();
										bool blUnderline = Convert.ToBoolean(reader.Value);
										reader.Read();
									}
								}
							}
							string name2 = reader.Name;
							if (Operators.CompareString(name2, "Name", false) == 0)
							{
								reader.Read();
								designControl.Name = reader.Value;
								reader.Read();
							}
							else if (Operators.CompareString(name2, "Text", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									if (reader.NodeType != XmlNodeType.EndElement)
									{
										designControl.PControl.Text = reader.Value;
										reader.Read();
									}
								}
							}
							else if (Operators.CompareString(name2, "Left", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.Left = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "Top", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.Top = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "Width", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.Width = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "Height", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.Height = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "BackColor", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.PControl.BackColor = ControlXML.StrToColor(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "ForeColor", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.PControl.ForeColor = ControlXML.StrToColor(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "TabIndex", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									designControl.TabIndex = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name2, "Enabled", false) == 0 && !reader.IsEmptyElement)
							{
								reader.Read();
								designControl.IEnabled = bool.Parse(reader.Value);
								reader.Read();
							}
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
			else
			{
				while (reader.Read())
				{
					if (!reader.IsEmptyElement)
					{
						if (reader.NodeType == XmlNodeType.EndElement & (Operators.CompareString(reader.Name, "PCString", false) == 0 | Operators.CompareString(reader.Name, "PCNumber", false) == 0 | Operators.CompareString(reader.Name, "PCMonoChoice", false) == 0 | Operators.CompareString(reader.Name, "PCMultiChoice", false) == 0 | Operators.CompareString(reader.Name, "PCDictionary", false) == 0 | Operators.CompareString(reader.Name, "PCDateTime", false) == 0 | Operators.CompareString(reader.Name, "PCPosition", false) == 0 | Operators.CompareString(reader.Name, "PCQuantity", false) == 0 | Operators.CompareString(reader.Name, "PCTextEdit", false) == 0 | Operators.CompareString(reader.Name, "PCImageAnnotate", false) == 0 | Operators.CompareString(reader.Name, "PCTable", false) == 0 | Operators.CompareString(reader.Name, "PCLabel", false) == 0 | Operators.CompareString(reader.Name, "PCVLine", false) == 0 | Operators.CompareString(reader.Name, "PCHLine", false) == 0 | Operators.CompareString(reader.Name, "PCBox", false) == 0 | Operators.CompareString(reader.Name, "PCAlignTable", false) == 0 | Operators.CompareString(reader.Name, "PCFigure", false) == 0))
						{
							break;
						}
						if (reader.NodeType == XmlNodeType.Element)
						{
							if (Operators.CompareString(reader.Name, "Font", false) == 0)
							{
								while (reader.Read())
								{
									if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Font", false) == 0)
									{
										bool blBold;
										bool blItalic;
										bool blStrikeout;
										bool blUnderline;
										FontStyle style = ControlXML.CombineFontStyle(blBold, blItalic, blStrikeout, blUnderline);
										float emSize;
										GraphicsUnit unit;
										byte gdiCharSet;
										bool gdiVerticalFont;
										ctrl.Font = new Font(familyName, emSize, style, unit, gdiCharSet, gdiVerticalFont);
										return;
									}
									string name3 = reader.Name;
									if (Operators.CompareString(name3, "Name", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											familyName = reader.Value;
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Size", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											float emSize = Convert.ToSingle(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Unit", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											GraphicsUnit unit = (GraphicsUnit)Conversions.ToInteger(Enum.Parse(typeof(GraphicsUnit), reader.Value, true));
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Bold", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blBold = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "GdiCharset", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											byte gdiCharSet = Convert.ToByte(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "GdiVerticalFont", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool gdiVerticalFont = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Italic", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blItalic = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Strikeout", false) == 0)
									{
										if (!reader.IsEmptyElement)
										{
											reader.Read();
											bool blStrikeout = Convert.ToBoolean(reader.Value);
											reader.Read();
										}
									}
									else if (Operators.CompareString(name3, "Underline", false) == 0 && !reader.IsEmptyElement)
									{
										reader.Read();
										bool blUnderline = Convert.ToBoolean(reader.Value);
										reader.Read();
									}
								}
							}
							string name4 = reader.Name;
							if (Operators.CompareString(name4, "Name", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.Name = reader.Value;
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "Text", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									if (reader.NodeType != XmlNodeType.EndElement)
									{
										ctrl.Text = reader.Value;
										reader.Read();
									}
								}
							}
							else if (Operators.CompareString(name4, "Left", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.Left = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "Top", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.Top = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "Width", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.Width = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "Height", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.Height = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "BackColor", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.BackColor = ControlXML.StrToColor(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "ForeColor", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.ForeColor = ControlXML.StrToColor(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "TabIndex", false) == 0)
							{
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									ctrl.TabIndex = Conversions.ToInteger(reader.Value);
									reader.Read();
								}
							}
							else if (Operators.CompareString(name4, "Enabled", false) == 0 && !reader.IsEmptyElement)
							{
								reader.Read();
								ctrl.Enabled = bool.Parse(reader.Value);
								reader.Read();
							}
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
		}

		public static Color StrToColor(string str)
		{
			if (Operators.CompareString(str.Substring(0, 2), "ff", false) == 0)
			{
				return Color.FromArgb(Convert.ToInt32(str, 16));
			}
			return Color.FromName(str);
		}

		public static FontStyle CombineFontStyle(bool blBold, bool blItalic, bool blStrikeout, bool blUnderline)
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
	}
}
