using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureRange
	{
		private string m_RangeName;

		private int m_StartRow;

		private int m_EndRow;

		private int m_StartColumn;

		private int m_EndColumn;

		private string m_FigureUnitName;

		private int m_PictureRefRow;

		private int m_PictureRefColumn;

		private int m_DescRefRow;

		private int m_DescRefColumn;

		public string RangeName
		{
			get
			{
				return this.m_RangeName;
			}
			set
			{
				this.m_RangeName = value;
			}
		}

		public string RangeBorder_Top
		{
			get
			{
				return this.m_RangeName + "_Top";
			}
		}

		public string RangeBorder_Left
		{
			get
			{
				return this.m_RangeName + "_Left";
			}
		}

		public string RangeBorder_Right
		{
			get
			{
				return this.m_RangeName + "_Right";
			}
		}

		public string RangeBorderName_Bottom
		{
			get
			{
				return this.m_RangeName + "_Bottom";
			}
		}

		public int StartRow
		{
			get
			{
				return this.m_StartRow;
			}
			set
			{
				this.m_StartRow = value;
			}
		}

		public int EndRow
		{
			get
			{
				return this.m_EndRow;
			}
			set
			{
				this.m_EndRow = value;
			}
		}

		public int StartColumn
		{
			get
			{
				return this.m_StartColumn;
			}
			set
			{
				this.m_StartColumn = value;
			}
		}

		public int EndColumn
		{
			get
			{
				return this.m_EndColumn;
			}
			set
			{
				this.m_EndColumn = value;
			}
		}

		public int RowsCount
		{
			get
			{
				return checked(this.m_EndRow - this.m_StartRow + 1);
			}
		}

		public string FigureUnitName
		{
			get
			{
				return this.m_FigureUnitName;
			}
			set
			{
				this.m_FigureUnitName = value;
			}
		}

		public int PictureRow
		{
			get
			{
				return checked(this.m_StartRow + this.m_PictureRefRow);
			}
			set
			{
				this.m_PictureRefRow = checked(value - this.m_StartRow);
			}
		}

		public int PictureColumn
		{
			get
			{
				return checked(this.m_StartColumn + this.m_PictureRefColumn);
			}
			set
			{
				this.m_PictureRefColumn = checked(value - this.m_StartColumn);
			}
		}

		public int DescRow
		{
			get
			{
				return checked(this.m_StartRow + this.m_DescRefRow);
			}
			set
			{
				this.m_DescRefRow = checked(value - this.m_StartRow);
			}
		}

		public int DescColumn
		{
			get
			{
				return checked(this.m_StartColumn + this.m_DescRefColumn);
			}
			set
			{
				this.m_DescRefColumn = checked(value - this.m_StartColumn);
			}
		}

		public bool ContainPicture
		{
			get
			{
				return this.m_PictureRefRow >= 0;
			}
		}

		public bool ContainDesc
		{
			get
			{
				return this.m_DescRefColumn >= 0;
			}
		}

		public FigureRange CopyInstance
		{
			set
			{
				this.m_StartRow = value.StartRow;
				this.m_EndRow = value.EndRow;
				this.m_StartColumn = value.StartColumn;
				this.m_EndColumn = value.EndColumn;
				this.m_FigureUnitName = value.FigureUnitName;
				checked
				{
					this.m_PictureRefRow = value.PictureRow - value.StartRow;
					this.m_PictureRefColumn = value.PictureColumn - value.StartColumn;
					this.m_DescRefRow = value.DescRow - value.StartRow;
					this.m_DescRefColumn = value.DescColumn - value.StartColumn;
				}
			}
		}

		public FigureRange()
		{
			this.m_PictureRefRow = -1;
			this.m_PictureRefColumn = -1;
			this.m_DescRefRow = -1;
			this.m_DescRefColumn = -1;
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("FigureRange");
			writer.WriteElementString("RangeName", this.m_RangeName);
			writer.WriteElementString("FigureUnitName", this.m_FigureUnitName);
			writer.WriteElementString("StartRow", this.m_StartRow.ToString());
			writer.WriteElementString("EndRow", this.m_EndRow.ToString());
			writer.WriteElementString("StartColumn", this.m_StartColumn.ToString());
			writer.WriteElementString("EndColumn", this.m_EndColumn.ToString());
			writer.WriteElementString("PictureRow", this.m_PictureRefRow.ToString());
			writer.WriteElementString("PictureColumn", this.m_PictureRefColumn.ToString());
			writer.WriteElementString("DescRow", this.m_DescRefRow.ToString());
			writer.WriteElementString("DescColumn", this.m_DescRefColumn.ToString());
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (!reader.IsEmptyElement)
				{
					if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "FigureRange", false) == 0)
					{
						break;
					}
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "RangeName", false) == 0)
					{
						reader.Read();
						this.m_RangeName = reader.Value;
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureUnitName", false) == 0)
					{
						reader.Read();
						this.m_FigureUnitName = reader.Value;
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "StartRow", false) == 0)
					{
						reader.Read();
						this.m_StartRow = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "EndRow", false) == 0)
					{
						reader.Read();
						this.m_EndRow = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "StartColumn", false) == 0)
					{
						reader.Read();
						this.m_StartColumn = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "EndColumn", false) == 0)
					{
						reader.Read();
						this.m_EndColumn = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PictureRow", false) == 0)
					{
						reader.Read();
						this.m_PictureRefRow = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PictureColumn", false) == 0)
					{
						reader.Read();
						this.m_PictureRefColumn = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "DescRow", false) == 0)
					{
						reader.Read();
						this.m_DescRefRow = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "DescColumn", false) == 0)
					{
						reader.Read();
						this.m_DescRefColumn = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
				}
			}
		}
	}
}
