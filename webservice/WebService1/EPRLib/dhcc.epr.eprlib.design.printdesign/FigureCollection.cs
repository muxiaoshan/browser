using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureCollection
	{
		private ArrayList m_FigureCollection;

		private Hashtable m_FigureUnitHash;

		public ArrayList FigureCollection
		{
			get
			{
				return this.m_FigureCollection;
			}
		}

		public Hashtable FigureUnitHash
		{
			get
			{
				return this.m_FigureUnitHash;
			}
		}

		public string XmlString
		{
			get
			{
				return this.XMLSerialize();
			}
			set
			{
				StringReader stringReader = new StringReader(value);
				XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				xmlTextReader.Read();
				this.XMLDeserialize(xmlTextReader);
				xmlTextReader.Close();
				stringReader.Close();
			}
		}

		public FigureCollection()
		{
			this.m_FigureCollection = new ArrayList();
			this.m_FigureUnitHash = new Hashtable();
		}

		public void ClearCollection()
		{
			this.m_FigureCollection.Clear();
			this.m_FigureUnitHash.Clear();
		}

		private string XMLSerialize()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringWriter stringWriter = new StringWriter(stringBuilder);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			xmlTextWriter.Formatting = Formatting.None;
			xmlTextWriter.WriteStartElement("FigureUnits");
			try
			{
				IEnumerator enumerator = this.m_FigureUnitHash.Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string key = Conversions.ToString(enumerator.Current);
					FigureUnit figureUnit = (FigureUnit)this.m_FigureUnitHash[key];
					figureUnit.XMLSerialize(xmlTextWriter);
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
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteStartElement("EmptyRanges");
			try
			{
				IEnumerator enumerator2 = this.m_FigureCollection.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					FigureRange figureRange = (FigureRange)enumerator2.Current;
					if (Operators.CompareString(figureRange.FigureUnitName, "", false) == 0)
					{
						figureRange.XMLSerialize(xmlTextWriter);
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			xmlTextWriter.WriteEndElement();
			string result = stringBuilder.ToString();
			xmlTextWriter.Close();
			stringWriter.Close();
			return result;
		}

		public void XMLDeserialize(XmlReader reader)
		{
			while (reader.Read())
			{
				if (!reader.IsEmptyElement)
				{
					if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "EPRFigures", false) == 0)
					{
						break;
					}
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureUnits", false) == 0)
					{
						while (reader.Read())
						{
							if (!reader.IsEmptyElement)
							{
								if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "FigureUnits", false) == 0)
								{
									break;
								}
								if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureUnit", false) == 0)
								{
									FigureUnit figureUnit = new FigureUnit();
									figureUnit.XMLDeserialize(reader);
									this.m_FigureUnitHash.Add(figureUnit.UnitName, figureUnit);
								}
							}
						}
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "EmptyRanges", false) == 0)
					{
						while (reader.Read())
						{
							if (!reader.IsEmptyElement)
							{
								if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "EmptyRanges", false) == 0)
								{
									break;
								}
								if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "FigureRange", false) == 0)
								{
									FigureRange figureRange = new FigureRange();
									figureRange.XMLDeserialize(reader);
									this.m_FigureCollection.Add(figureRange);
								}
							}
						}
					}
				}
			}
			try
			{
				IEnumerator enumerator = this.m_FigureUnitHash.Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string key = Conversions.ToString(enumerator.Current);
					FigureUnit figureUnit2 = (FigureUnit)this.m_FigureUnitHash[key];
					try
					{
						IEnumerator enumerator2 = figureUnit2.RangeItems.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							FigureRange value = (FigureRange)enumerator2.Current;
							this.m_FigureCollection.Add(value);
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
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
		}
	}
}
