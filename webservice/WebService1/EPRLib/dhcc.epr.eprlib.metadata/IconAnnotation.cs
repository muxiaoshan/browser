using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class IconAnnotation
	{
		private string _IconData;

		private string _IconName;

		private string _IconCode;

		private string _IconDesc;

		private Image _IconImage;

		private HatchStyle _HatchStyle;

		private Color _BackColor;

		private Color _ForeColor;

		private int _BorderWidth;

		private bool _DrawBorder;

		private bool _DrawImage;

		private bool _DrawHatch;

		private Bitmap _tmpBitMap;

		public string IconData
		{
			get
			{
				return this._IconData;
			}
			set
			{
				this._IconData = value;
			}
		}

		public string IconName
		{
			get
			{
				return this._IconName;
			}
			set
			{
				this._IconName = value;
			}
		}

		public string IconCode
		{
			get
			{
				return this._IconCode;
			}
			set
			{
				this._IconCode = value;
			}
		}

		public string IconDesc
		{
			get
			{
				return this._IconDesc;
			}
			set
			{
				this._IconDesc = value;
			}
		}

		public Image IconImage
		{
			get
			{
				return this._IconImage;
			}
			set
			{
				this._IconImage = value;
			}
		}

		public HatchStyle HatchStyle
		{
			get
			{
				return this._HatchStyle;
			}
			set
			{
				this._HatchStyle = value;
			}
		}

		public Color BackColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				this._BackColor = value;
			}
		}

		public Color ForeColor
		{
			get
			{
				return this._ForeColor;
			}
			set
			{
				this._ForeColor = value;
			}
		}

		public int BorderWidth
		{
			get
			{
				return this._BorderWidth;
			}
			set
			{
				this._BorderWidth = value;
			}
		}

		public bool DrawBorder
		{
			get
			{
				return this._DrawBorder;
			}
			set
			{
				this._DrawBorder = value;
			}
		}

		public bool DrawImage
		{
			get
			{
				return this._DrawImage;
			}
			set
			{
				this._DrawImage = value;
			}
		}

		public bool DrawHatch
		{
			get
			{
				return this._DrawHatch;
			}
			set
			{
				this._DrawHatch = value;
			}
		}

		public IconAnnotation()
		{
			this._tmpBitMap = new Bitmap(16, 16);
			this._DrawImage = true;
			this._DrawBorder = false;
			this._DrawHatch = false;
			this._BorderWidth = 1;
		}

		public Bitmap GetIconImage()
		{
			Graphics graphics = Graphics.FromImage(this._tmpBitMap);
			graphics.Clear(Color.Transparent);
			if (this.DrawImage)
			{
				if (this.IconImage != null)
				{
					graphics.FillRectangle(Brushes.Transparent, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
					graphics.DrawImage(this.IconImage, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
				}
			}
			else if (this.DrawHatch)
			{
				HatchBrush brush = new HatchBrush(this.HatchStyle, this.ForeColor, this.BackColor);
				graphics.FillRectangle(brush, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			else
			{
				SolidBrush brush2 = new SolidBrush(this.BackColor);
				graphics.FillRectangle(brush2, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			if (this.DrawBorder)
			{
				Pen pen = new Pen(this.ForeColor, (float)this.BorderWidth);
				graphics.DrawRectangle(pen, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			return this._tmpBitMap;
		}

		public void XMLSerialize(XmlWriter writer)
		{
			if (this.IconImage != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				this.IconImage.Save(memoryStream, this.IconImage.RawFormat);
				this.IconData = AnnotateUtil.ImageStreamToStr(memoryStream);
			}
			writer.WriteStartElement("IconAnnotation");
			writer.WriteElementString("IconName", this.IconName);
			writer.WriteElementString("IconCode", this.IconCode);
			writer.WriteElementString("IconDesc", this.IconDesc);
			writer.WriteStartElement("IconData");
			writer.WriteCData(this.IconData);
			writer.WriteEndElement();
			writer.WriteElementString("HatchStyle", this.HatchStyle.ToString());
			writer.WriteElementString("BackColor", this.BackColor.Name);
			writer.WriteElementString("ForeColor", this.ForeColor.Name);
			writer.WriteElementString("BorderWidth", this.BorderWidth.ToString());
			writer.WriteElementString("DrawBorder", this.DrawBorder.ToString());
			writer.WriteElementString("DrawImage", this.DrawImage.ToString());
			writer.WriteElementString("DrawHatch", this.DrawHatch.ToString());
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "IconName", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.IconName = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "IconCode", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.IconCode = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "IconDesc", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.IconDesc = reader.Value;
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "IconData", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.IconData = reader.Value;
					if (!(this.IconData == null | Operators.CompareString(this.IconData, "", false) == 0))
					{
						MemoryStream stream = (MemoryStream)AnnotateUtil.StrToImageStream(this.IconData);
						this.IconImage = Image.FromStream(stream);
					}
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "HatchStyle", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.HatchStyle = (HatchStyle)Conversions.ToInteger(Enum.Parse(this.HatchStyle.GetType(), reader.Value));
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "DrawBorder", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawBorder = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "DrawImage", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawImage = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "DrawHatch", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawHatch = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "ForeColor", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.ForeColor = ControlXML.StrToColor(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "BackColor", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.BackColor = ControlXML.StrToColor(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.Name, "IconAnnotation", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
