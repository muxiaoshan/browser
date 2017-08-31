using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MIImageAnnotate : MMetaItem
	{
		public delegate void XMLEventEventHandler();

		private string _HotSpotData;

		private string _ImageData;

		private IconAnnotationCollection _IconAnnotates;

		private string _BindTextDescCode;

		private bool _NameConvert;

		private bool _ImageConvert;

		private string _ConvertClass;

		private string _Spliter;

		private MIImageAnnotate.XMLEventEventHandler XMLEventEvent;

		public event MIImageAnnotate.XMLEventEventHandler XMLEvent
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.XMLEventEvent = (MIImageAnnotate.XMLEventEventHandler)Delegate.Combine(this.XMLEventEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.XMLEventEvent = (MIImageAnnotate.XMLEventEventHandler)Delegate.Remove(this.XMLEventEvent, value);
			}
		}

		public bool NameConvert
		{
			get
			{
				return this._NameConvert;
			}
			set
			{
				this._NameConvert = value;
			}
		}

		public bool ImageConvert
		{
			get
			{
				return this._ImageConvert;
			}
			set
			{
				this._ImageConvert = value;
			}
		}

		public string ConvertClass
		{
			get
			{
				return this._ConvertClass;
			}
			set
			{
				this._ConvertClass = value;
			}
		}

		public string Spliter
		{
			get
			{
				return this._Spliter;
			}
			set
			{
				this._Spliter = value;
			}
		}

		public string HotSpotData
		{
			get
			{
				return this._HotSpotData;
			}
			set
			{
				this._HotSpotData = value;
			}
		}

		public string ImageData
		{
			get
			{
				return this._ImageData;
			}
			set
			{
				this._ImageData = value;
			}
		}

		public IconAnnotationCollection IconAnnotates
		{
			get
			{
				return this._IconAnnotates;
			}
			set
			{
				this._IconAnnotates = value;
			}
		}

		public string BindTextDescCode
		{
			get
			{
				return this._BindTextDescCode;
			}
			set
			{
				this._BindTextDescCode = value;
			}
		}

		public MIImageAnnotate()
		{
			this._IconAnnotates = new IconAnnotationCollection();
			this._Spliter = "、";
			this.SubItems = new MMetaItemCollection();
		}

		public override NInstanceItem CreateInstance()
		{
			return new NIImageAnnotate
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			MIImageAnnotate.XMLEventEventHandler xMLEventEvent = this.XMLEventEvent;
			if (xMLEventEvent != null)
			{
				xMLEventEvent();
			}
			writer.WriteStartElement("MIImageAnnotate");
			base.XMLSerialize(writer);
			writer.WriteStartElement("ImageData");
			writer.WriteCData(this.ImageData);
			writer.WriteEndElement();
			writer.WriteStartElement("HotSpotData");
			writer.WriteCData(this.HotSpotData);
			writer.WriteEndElement();
			writer.WriteStartElement("IconAnnotates");
			IconAnnotationEnumerator enumerator = this._IconAnnotates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IconAnnotation iconAnnotation = (IconAnnotation)enumerator.Current;
				iconAnnotation.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteElementString("BindTextDescCode", this.BindTextDescCode);
			writer.WriteElementString("NameConvert", this.NameConvert.ToString());
			writer.WriteElementString("ImageConvert", this.ImageConvert.ToString());
			writer.WriteElementString("ConvertClass", this.ConvertClass);
			writer.WriteElementString("Spliter", this.Spliter);
			writer.WriteStartElement("SubItems");
			MMetaItemEnumerator enumerator2 = this.SubItems.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				MMetaItem mMetaItem = (MMetaItem)enumerator2.Current;
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
			if (Operators.CompareString(tagName, "ImageData", false) == 0)
			{
				reader.Read();
				this.ImageData = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "HotSpotData", false) == 0)
			{
				reader.Read();
				this.HotSpotData = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "IconAnnotates", false) == 0)
			{
				while (reader.Read())
				{
					if (Operators.CompareString(reader.Name, "IconAnnotation", false) == 0 & reader.IsStartElement())
					{
						IconAnnotation iconAnnotation = new IconAnnotation();
						iconAnnotation.XMLDeserialize(reader);
						this._IconAnnotates.Add(iconAnnotation);
					}
					else if (Operators.CompareString(reader.Name, "IconAnnotates", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
					{
						break;
					}
				}
				return true;
			}
			if (Operators.CompareString(tagName, "BindTextDescCode", false) == 0)
			{
				reader.Read();
				this.BindTextDescCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "NameConvert", false) == 0)
			{
				reader.Read();
				this.NameConvert = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "ImageConvert", false) == 0)
			{
				reader.Read();
				this.ImageConvert = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "ConvertClass", false) == 0)
			{
				reader.Read();
				this.ConvertClass = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Spliter", false) == 0)
			{
				reader.Read();
				this.Spliter = reader.Value;
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
