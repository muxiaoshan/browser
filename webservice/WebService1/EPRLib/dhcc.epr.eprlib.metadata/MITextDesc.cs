using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MITextDesc : MMetaItem
	{
		private string _BindKBBaseID;

		private string _BindKBName;

		private bool _BindDefaultKB;

		private KBPart _BindKBPart;

		private string _BindDefaultDiagnosType;

		private bool _StopRaiseVChanged;

		public KBPart BindKBPart
		{
			get
			{
				return this._BindKBPart;
			}
			set
			{
				this._BindKBPart = value;
			}
		}

		public string BindKBBaseID
		{
			get
			{
				return this._BindKBBaseID;
			}
			set
			{
				this._BindKBBaseID = value;
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

		public bool BindDefaultKB
		{
			get
			{
				return this._BindDefaultKB;
			}
			set
			{
				this._BindDefaultKB = value;
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

		public MITextDesc()
		{
			this._BindKBBaseID = string.Empty;
			this._BindKBName = string.Empty;
			this._BindDefaultDiagnosType = string.Empty;
			this._StopRaiseVChanged = false;
			this.SubItems = new MMetaItemCollection();
			this._BindKBPart = KBPart.First;
			this._BindDefaultKB = true;
		}

		public override NInstanceItem CreateInstance()
		{
			return new NITextDesc
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MITextDesc");
			base.XMLSerialize(writer);
			writer.WriteElementString("BindKBBaseID", this.BindKBBaseID);
			writer.WriteElementString("BindKBName", this.BindKBName);
			writer.WriteElementString("BindKBPart", this.BindKBPart.ToString());
			writer.WriteElementString("BindDefaultKB", this.BindDefaultKB.ToString());
			writer.WriteElementString("BindDefaultDiagnosType", this.BindDefaultDiagnosType);
			writer.WriteElementString("StopRaiseVChanged", this.StopRaiseVChanged.ToString());
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "BindKBPart", false) == 0)
			{
				reader.Read();
				this._BindKBPart = (KBPart)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.KBPart"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindKBBaseID", false) == 0)
			{
				reader.Read();
				this._BindKBBaseID = reader.Value;
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
			if (Operators.CompareString(tagName, "BindDefaultKB", false) == 0)
			{
				reader.Read();
				this._BindDefaultKB = Convert.ToBoolean(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindDefaultDiagnosType", false) == 0)
			{
				reader.Read();
				this._BindDefaultDiagnosType = reader.Value;
				reader.Read();
				return false;
			}
			if (Operators.CompareString(tagName, "StopRaiseVChanged", false) == 0)
			{
				reader.Read();
				this._StopRaiseVChanged = Convert.ToBoolean(reader.Value);
				reader.Read();
				return false;
			}
			return false;
		}
	}
}
