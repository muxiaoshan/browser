using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Xml;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureUnit
	{
		private string m_UnitName;

		private int m_StartRow;

		private int m_EndRow;

		private int m_StartColumn;

		private int m_EndColumn;

		private ArrayList m_RangeList;

		private int m_RangesCountOfModel;

		private int m_CurrentStartRow;

		private int m_CurrentEndRow;

		public int RangesCount
		{
			get
			{
				return this.m_RangeList.Count;
			}
		}

		public ArrayList RangeItems
		{
			get
			{
				return this.m_RangeList;
			}
		}

		public FigureRange this[int index]
		{
			get
			{
				return (FigureRange)this.m_RangeList[index];
			}
			set
			{
				this.m_RangeList[index] = value;
			}
		}

		public string UnitName
		{
			get
			{
				return this.m_UnitName;
			}
			set
			{
				this.m_UnitName = value;
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

		public int RangesCountOfModel
		{
			get
			{
				return this.m_RangesCountOfModel;
			}
		}

		public int CurrentStartRow
		{
			get
			{
				return this.m_CurrentStartRow;
			}
			set
			{
				this.m_CurrentStartRow = value;
			}
		}

		public int CurrentEndRow
		{
			get
			{
				return this.m_CurrentEndRow;
			}
			set
			{
				this.m_CurrentEndRow = value;
			}
		}

		public int CurrentRowsCount
		{
			get
			{
				return checked(this.m_CurrentEndRow - this.m_CurrentStartRow + 1);
			}
		}

		public FigureUnit()
		{
			this.m_RangeList = new ArrayList();
		}

		public void Add(FigureRange value)
		{
			this.m_RangeList.Add(value);
		}

		public void Sort()
		{
			FigureCompare comparer = new FigureCompare();
			this.m_RangeList.Sort(comparer);
		}

		public bool Contains(FigureRange figure)
		{
			try
			{
				IEnumerator enumerator = this.m_RangeList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FigureRange figureRange = (FigureRange)enumerator.Current;
					if (Operators.CompareString(figureRange.RangeName, figure.RangeName, false) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return false;
		}

		public void ReArrange()
		{
			int num = 100000;
			int num2 = 100000;
			int num3 = 0;
			int num4 = 0;
			this.m_RangesCountOfModel = this.m_RangeList.Count;
			try
			{
				IEnumerator enumerator = this.m_RangeList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FigureRange figureRange = (FigureRange)enumerator.Current;
					if (figureRange.StartRow < num)
					{
						num = figureRange.StartRow;
					}
					if (figureRange.EndRow > num3)
					{
						num3 = figureRange.EndRow;
					}
					if (figureRange.StartColumn < num2)
					{
						num2 = figureRange.StartColumn;
					}
					if (figureRange.EndColumn > num4)
					{
						num4 = figureRange.EndColumn;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.m_StartRow = num;
			this.m_EndRow = num3;
			this.m_StartColumn = num2;
			this.m_EndColumn = num4;
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("FigureUnit");
			writer.WriteElementString("UnitName", this.m_UnitName);
			writer.WriteElementString("StartRow", this.m_StartRow.ToString());
			writer.WriteElementString("EndRow", this.m_EndRow.ToString());
			writer.WriteElementString("StartColumn", this.m_StartColumn.ToString());
			writer.WriteElementString("EndColumn", this.m_EndColumn.ToString());
			writer.WriteElementString("RangesCountOfModel", this.m_RangesCountOfModel.ToString());
			writer.WriteStartElement("FigureRanges");
			try
			{
				IEnumerator enumerator = this.m_RangeList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FigureRange figureRange = (FigureRange)enumerator.Current;
					figureRange.XMLSerialize(writer);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (!reader.IsEmptyElement)
				{
					if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "FigureUnit", false) == 0)
					{
						break;
					}
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "UnitName", false) == 0)
					{
						reader.Read();
						this.m_UnitName = reader.Value;
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
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "RangesCountOfModel", false) == 0)
					{
						reader.Read();
						this.m_RangesCountOfModel = Conversions.ToInteger(reader.Value);
						reader.Read();
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureRanges", false) == 0)
					{
						while (reader.Read())
						{
							if (!reader.IsEmptyElement)
							{
								if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "FigureRanges", false) == 0)
								{
									break;
								}
								if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureRange", false) == 0)
								{
									FigureRange figureRange = new FigureRange();
									figureRange.XMLDeserialize(reader);
									this.m_RangeList.Add(figureRange);
								}
							}
						}
					}
				}
			}
		}
	}
}
