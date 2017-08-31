using dhcc.epr.eprlib.metadata.ontology;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MMetaData : MMetaItem
	{
		private string _ID;

		private string _GUID;

		private int _CodeNumber;

		private bool _BindKB;

		private string _BindKBCode;

		private string _BindKBName;

		private MOntology _Ontology;

		private MFormulaItemCollection _AuditFormulaItems;

		private MFormulaItemCollection _CalculateFormulaItems;

		private MFormulaItemCollection _TipFormulaItems;

		public MFormulaItemCollection AuditFormulaItems
		{
			get
			{
				return this._AuditFormulaItems;
			}
			set
			{
				this._AuditFormulaItems = value;
			}
		}

		public MFormulaItemCollection CalculateFormulaItems
		{
			get
			{
				return this._CalculateFormulaItems;
			}
			set
			{
				this._CalculateFormulaItems = value;
			}
		}

		public MFormulaItemCollection TipFormulaItems
		{
			get
			{
				return this._TipFormulaItems;
			}
			set
			{
				this._TipFormulaItems = value;
			}
		}

		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				this._GUID = value;
			}
		}

		public bool BindKB
		{
			get
			{
				return this._BindKB;
			}
			set
			{
				this._BindKB = value;
			}
		}

		public string BindKBCode
		{
			get
			{
				return this._BindKBCode;
			}
			set
			{
				this._BindKBCode = value;
			}
		}

		public string BindKBName
		{
			get
			{
				return this._BindKBName;
			}
			set
			{
				this._BindKBName = value;
			}
		}

		public MOntology Ontology
		{
			get
			{
				return this._Ontology;
			}
			set
			{
				this._Ontology = value;
			}
		}

		public MMetaData()
		{
			this.SubItems = new MMetaItemCollection();
			this._AuditFormulaItems = new MFormulaItemCollection();
			this._CalculateFormulaItems = new MFormulaItemCollection();
			this._TipFormulaItems = new MFormulaItemCollection();
		}

		public void Init()
		{
			this.Status = EPRStatus.Create;
			this._CodeNumber = 0;
			this.Code = "A" + this.GetStrCodeNumber();
		}

		private string GetStrCodeNumber()
		{
			string result = this._CodeNumber.ToString("0000");
			checked
			{
				this._CodeNumber++;
				return result;
			}
		}

		public override void InitMetaItem(MMetaItem objMetaItem)
		{
			objMetaItem.Status = EPRStatus.Create;
			if (objMetaItem is MIString)
			{
				objMetaItem.Text = "新建字符单元";
				objMetaItem.Code = "S" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MINumber)
			{
				objMetaItem.Text = "新建数值单元";
				objMetaItem.Code = "N" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIMonoChoice)
			{
				objMetaItem.Text = "新建单选单元";
				objMetaItem.Code = "O" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIMultiChoice)
			{
				objMetaItem.Text = "新建多选单元";
				objMetaItem.Code = "M" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIDateTime)
			{
				objMetaItem.Text = "新建日期时间单元";
				objMetaItem.Code = "D" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIQuantity)
			{
				objMetaItem.Text = "新建数量单元";
				objMetaItem.Code = "Q" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIDictionary)
			{
				objMetaItem.Text = "新建字典单元";
				objMetaItem.Code = "I" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MITable)
			{
				objMetaItem.Text = "新建表格单元";
				objMetaItem.Code = "T" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MICluster)
			{
				objMetaItem.Text = "新建集合单元";
				objMetaItem.Code = "C" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MITextDesc)
			{
				objMetaItem.Text = "新建文本描述单元";
				objMetaItem.Code = "E" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MISegment)
			{
				objMetaItem.Text = "新建文本段单元";
				objMetaItem.Code = "G" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MILink)
			{
				objMetaItem.Text = "新建链接单元";
				objMetaItem.Code = "L" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIImageAnnotate)
			{
				objMetaItem.Text = "新建图像注释单元";
				objMetaItem.Code = "Y" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIPosition)
			{
				objMetaItem.Text = "新建位置单元";
				objMetaItem.Code = "P" + this.GetStrCodeNumber();
			}
			else if (objMetaItem is MIFigure)
			{
				objMetaItem.Text = "新建图像单元";
				objMetaItem.Code = "F" + this.GetStrCodeNumber();
			}
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MMetaData");
			base.XMLSerialize(writer);
			writer.WriteElementString("ID", this.ID);
			writer.WriteElementString("GUID", this.GUID);
			writer.WriteElementString("CodeNumber", Conversions.ToString(this._CodeNumber));
			writer.WriteElementString("BindKB", this.BindKB.ToString());
			writer.WriteElementString("BindKBCode", this.BindKBCode);
			writer.WriteElementString("BindKBName", this.BindKBName);
			writer.WriteStartElement("AuditFormulaItems");
			MFormulaItemEnumerator enumerator = this.AuditFormulaItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
				mFormulaItem.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteStartElement("CalculateFormulaItems");
			MFormulaItemEnumerator enumerator2 = this.CalculateFormulaItems.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				MFormulaItem mFormulaItem2 = (MFormulaItem)enumerator2.Current;
				mFormulaItem2.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteStartElement("TipFormulaItems");
			MFormulaItemEnumerator enumerator3 = this.TipFormulaItems.GetEnumerator();
			while (enumerator3.MoveNext())
			{
				MFormulaItem mFormulaItem3 = (MFormulaItem)enumerator3.Current;
				mFormulaItem3.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteStartElement("SubItems");
			MMetaItemEnumerator enumerator4 = this.SubItems.GetEnumerator();
			while (enumerator4.MoveNext())
			{
				MMetaItem mMetaItem = (MMetaItem)enumerator4.Current;
				mMetaItem.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "ID", false) == 0)
			{
				reader.Read();
				this.ID = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "GUID", false) == 0)
			{
				reader.Read();
				this.GUID = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "CodeNumber", false) == 0)
			{
				reader.Read();
				this._CodeNumber = int.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindKB", false) == 0)
			{
				reader.Read();
				this._BindKB = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindKBCode", false) == 0)
			{
				reader.Read();
				this._BindKBCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindKBName", false) == 0)
			{
				reader.Read();
				this._BindKBName = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "AuditFormulaItems", false) == 0)
			{
				this._AuditFormulaItems.Clear();
				while (reader.Read())
				{
					if (Operators.CompareString(reader.Name, "MFormulaItem", false) == 0 & reader.IsStartElement())
					{
						MFormulaItem mFormulaItem = new MFormulaItem();
						mFormulaItem.XMLDeserialize(reader);
						this._AuditFormulaItems.Add(mFormulaItem);
					}
					else if (Operators.CompareString(reader.Name, "AuditFormulaItems", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
				return true;
			}
			if (Operators.CompareString(tagName, "CalculateFormulaItems", false) == 0)
			{
				this._CalculateFormulaItems.Clear();
				while (reader.Read())
				{
					if (Operators.CompareString(reader.Name, "MFormulaItem", false) == 0 & reader.IsStartElement())
					{
						MFormulaItem mFormulaItem2 = new MFormulaItem();
						mFormulaItem2.XMLDeserialize(reader);
						this._CalculateFormulaItems.Add(mFormulaItem2);
					}
					else if (Operators.CompareString(reader.Name, "CalculateFormulaItems", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
				return true;
			}
			if (Operators.CompareString(tagName, "TipFormulaItems", false) == 0)
			{
				this._TipFormulaItems.Clear();
				while (reader.Read())
				{
					if (Operators.CompareString(reader.Name, "MFormulaItem", false) == 0 & reader.IsStartElement())
					{
						MFormulaItem mFormulaItem3 = new MFormulaItem();
						mFormulaItem3.XMLDeserialize(reader);
						this._TipFormulaItems.Add(mFormulaItem3);
					}
					else if (Operators.CompareString(reader.Name, "TipFormulaItems", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
				return true;
			}
			if (Operators.CompareString(tagName, "SubItems", false) == 0)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIString", false) == 0)
					{
						MIString mIString = new MIString();
						mIString.XMLDeserialize(reader);
						this.SubItems.Add(this, mIString);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MINumber", false) == 0)
					{
						MINumber mINumber = new MINumber();
						mINumber.XMLDeserialize(reader);
						this.SubItems.Add(this, mINumber);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIMonoChoice", false) == 0)
					{
						MIMonoChoice mIMonoChoice = new MIMonoChoice();
						mIMonoChoice.XMLDeserialize(reader);
						this.SubItems.Add(this, mIMonoChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIMultiChoice", false) == 0)
					{
						MIMultiChoice mIMultiChoice = new MIMultiChoice();
						mIMultiChoice.XMLDeserialize(reader);
						this.SubItems.Add(this, mIMultiChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIDateTime", false) == 0)
					{
						MIDateTime mIDateTime = new MIDateTime();
						mIDateTime.XMLDeserialize(reader);
						this.SubItems.Add(this, mIDateTime);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIQuantity", false) == 0)
					{
						MIQuantity mIQuantity = new MIQuantity();
						mIQuantity.XMLDeserialize(reader);
						this.SubItems.Add(this, mIQuantity);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIPosition", false) == 0)
					{
						MIPosition mIPosition = new MIPosition();
						mIPosition.XMLDeserialize(reader);
						this.SubItems.Add(this, mIPosition);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIDictionary", false) == 0)
					{
						MIDictionary mIDictionary = new MIDictionary();
						mIDictionary.XMLDeserialize(reader);
						this.SubItems.Add(this, mIDictionary);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MISegment", false) == 0)
					{
						MISegment mISegment = new MISegment();
						mISegment.XMLDeserialize(reader);
						this.SubItems.Add(this, mISegment);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MITextDesc", false) == 0)
					{
						MITextDesc mITextDesc = new MITextDesc();
						mITextDesc.XMLDeserialize(reader);
						this.SubItems.Add(this, mITextDesc);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MITable", false) == 0)
					{
						MITable mITable = new MITable();
						mITable.XMLDeserialize(reader);
						this.SubItems.Add(this, mITable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIImageAnnotate", false) == 0)
					{
						MIImageAnnotate mIImageAnnotate = new MIImageAnnotate();
						mIImageAnnotate.XMLDeserialize(reader);
						this.SubItems.Add(this, mIImageAnnotate);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIFigure", false) == 0)
					{
						MIFigure mIFigure = new MIFigure();
						mIFigure.XMLDeserialize(reader);
						this.SubItems.Add(this, mIFigure);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
				return true;
			}
			return false;
		}
	}
}
