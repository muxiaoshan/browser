using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MISegment : MMetaItem
	{
		private string _KBNodeID;

		private string _SegmentNumber;

		private int _CodeNumber;

		private string _BindDefaultDiagnosType;

		private bool _FixedStructs;

		private bool _StopRaiseVChanged;

		public string KBNodeID
		{
			get
			{
				return this._KBNodeID;
			}
			set
			{
				this._KBNodeID = value;
			}
		}

		public bool FixedStructs
		{
			get
			{
				return this._FixedStructs;
			}
			set
			{
				this._FixedStructs = value;
			}
		}

		public string SegmentNumber
		{
			get
			{
				return this._SegmentNumber;
			}
			set
			{
				this._SegmentNumber = value;
			}
		}

		public string BindDefaultDiagnosType
		{
			get
			{
				return this._BindDefaultDiagnosType;
			}
			set
			{
				this._BindDefaultDiagnosType = value;
			}
		}

		public bool StopRaiseVChanged
		{
			get
			{
				return this._StopRaiseVChanged;
			}
			set
			{
				this._StopRaiseVChanged = value;
			}
		}

		public MISegment()
		{
			this._StopRaiseVChanged = false;
			this.SubItems = new MMetaItemCollection();
		}

		public void Init()
		{
			this._CodeNumber = 0;
			this.Code = "G" + this.GetStrCodeNumber();
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
			else if (objMetaItem is MIPosition)
			{
				objMetaItem.Text = "新建位置单元";
				objMetaItem.Code = "P" + this.GetStrCodeNumber();
			}
		}

		public override NInstanceItem CreateInstance()
		{
			return new NISegment
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MISegment");
			base.XMLSerialize(writer);
			writer.WriteElementString("KBNodeID", this.KBNodeID);
			writer.WriteElementString("SegmentNumber", this.SegmentNumber);
			writer.WriteElementString("CodeNumber", Conversions.ToString(this._CodeNumber));
			writer.WriteElementString("FixedStructs", Conversions.ToString(this.FixedStructs));
			writer.WriteElementString("BindDefaultDiagnosType", this.BindDefaultDiagnosType);
			writer.WriteElementString("StopRaiseVChanged", this.StopRaiseVChanged.ToString());
			writer.WriteStartElement("SubItems");
			MMetaItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MMetaItem mMetaItem = (MMetaItem)enumerator.Current;
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
			if (Operators.CompareString(tagName, "KBNodeID", false) == 0)
			{
				reader.Read();
				this.KBNodeID = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "SegmentNumber", false) == 0)
			{
				reader.Read();
				this.SegmentNumber = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "CodeNumber", false) == 0)
			{
				reader.Read();
				this._CodeNumber = Conversions.ToInteger(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "FixedStructs", false) == 0)
			{
				reader.Read();
				this._FixedStructs = Conversions.ToBoolean(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindDefaultDiagnosType", false) == 0)
			{
				reader.Read();
				this._BindDefaultDiagnosType = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "StopRaiseVChanged", false) == 0)
			{
				reader.Read();
				this._StopRaiseVChanged = Convert.ToBoolean(reader.Value);
				reader.Read();
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
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIDictionary", false) == 0)
					{
						MIDictionary mIDictionary = new MIDictionary();
						mIDictionary.XMLDeserialize(reader);
						this.SubItems.Add(this, mIDictionary);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MIPosition", false) == 0)
					{
						MIPosition mIPosition = new MIPosition();
						mIPosition.XMLDeserialize(reader);
						this.SubItems.Add(this, mIPosition);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "MILink", false) == 0)
					{
						MILink mILink = new MILink();
						mILink.XMLDeserialize(reader);
						this.SubItems.Add(this, mILink);
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
