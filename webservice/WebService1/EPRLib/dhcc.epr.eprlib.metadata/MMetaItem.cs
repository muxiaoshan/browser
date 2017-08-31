using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MMetaItem : ICloneable
	{
		private string _Code;

		private MMetaItem _Parent;

		private MMetaItemCollection _SubItems;

		private string _Text;

		private string _Description;

		private EPRStatus _Status;

		private NInstanceItem _BindInstanceItem;

		private string _DataBaseBindCode;

		private string _EPRBindCode;

		private bool _BindControl;

		private bool _BindLabel;

		private bool _Synch;

		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		public MMetaItem Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				this._Parent = value;
			}
		}

		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}

		public EPRStatus Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if (this._Status == EPRStatus.Create)
				{
					this._Status = value;
				}
				else if (this._Status == EPRStatus.Create & value == EPRStatus.Publish)
				{
					this._Status = value;
				}
				else if (this._Status == EPRStatus.Publish & value == EPRStatus.Create)
				{
					this._Status = value;
				}
				else if (this._Status == EPRStatus.Publish & value == EPRStatus.ABandon)
				{
					this._Status = value;
				}
				else if (this._Status == EPRStatus.ABandon & value == EPRStatus.Publish)
				{
					this._Status = this._Status;
				}
				if (this.SubItems != null)
				{
					MMetaItemEnumerator enumerator = this.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MMetaItem mMetaItem = (MMetaItem)enumerator.Current;
						mMetaItem.Status = value;
					}
				}
			}
		}

		public MMetaItemCollection SubItems
		{
			get
			{
				return this._SubItems;
			}
			set
			{
				this._SubItems = value;
			}
		}

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindInstanceItem;
			}
			set
			{
				this._BindInstanceItem = value;
			}
		}

		public string DataBaseBindCode
		{
			get
			{
				return this._DataBaseBindCode;
			}
			set
			{
				this._DataBaseBindCode = value;
			}
		}

		public string EPRBindCode
		{
			get
			{
				return this._EPRBindCode;
			}
			set
			{
				this._EPRBindCode = value;
			}
		}

		public bool BindControl
		{
			get
			{
				return this._BindControl;
			}
			set
			{
				this._BindControl = value;
			}
		}

		public bool BindLabel
		{
			get
			{
				return this._BindLabel;
			}
			set
			{
				this._BindLabel = value;
			}
		}

		public bool Synch
		{
			get
			{
				return this._Synch;
			}
			set
			{
				this._Synch = value;
			}
		}

		public string XMLString
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringWriter stringWriter = new StringWriter(stringBuilder);
				XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
				xmlTextWriter.Formatting = Formatting.None;
				this.XMLSerialize(xmlTextWriter);
				string result = stringBuilder.ToString();
				xmlTextWriter.Close();
				stringWriter.Close();
				return result;
			}
			set
			{
				StringReader input = new StringReader(value);
				XmlTextReader xmlTextReader = new XmlTextReader(input);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				xmlTextReader.Read();
				this.XMLDeserialize(xmlTextReader);
				xmlTextReader.Close();
			}
		}

		[DebuggerNonUserCode]
		public MMetaItem()
		{
		}

		public virtual void XMLSerialize(XmlWriter writer)
		{
			writer.WriteElementString("Code", this.Code);
			writer.WriteElementString("Text", this.Text);
			if (Operators.CompareString(this.Description, null, false) != 0 && Operators.CompareString(this.Description.Trim(), "", false) == 0)
			{
				this.Description = null;
			}
			writer.WriteElementString("Description", this.Description);
			writer.WriteElementString("Status", this.Status.ToString());
			writer.WriteElementString("BindControl", this.BindControl.ToString());
			writer.WriteElementString("EPRBindCode", this.EPRBindCode);
			writer.WriteElementString("DataBaseBindCode", this.DataBaseBindCode);
			writer.WriteElementString("BindLabel", this.BindLabel.ToString());
			writer.WriteElementString("Synch", this.Synch.ToString());
		}

		public void XMLDeserialize(XmlReader reader)
		{
			string name = reader.Name;
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, name, false) == 0)
				{
					break;
				}
				if (!reader.IsEmptyElement & reader.IsStartElement())
				{
					this.GetDataByXMLDeserialize(reader, reader.Name);
				}
			}
		}

		public virtual bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (Operators.CompareString(tagName, "Code", false) == 0)
			{
				reader.Read();
				this.Code = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Text", false) == 0)
			{
				reader.Read();
				this.Text = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Description", false) == 0)
			{
				reader.Read();
				this.Description = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Status", false) == 0)
			{
				reader.Read();
				this.Status = (EPRStatus)Conversions.ToInteger(Enum.Parse(Type.GetType("dhcc.epr.eprlib.metadata.EPRStatus"), reader.Value));
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindControl", false) == 0)
			{
				reader.Read();
				this.BindControl = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "EPRBindCode", false) == 0)
			{
				reader.Read();
				this.EPRBindCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "DataBaseBindCode", false) == 0)
			{
				reader.Read();
				this.DataBaseBindCode = reader.Value;
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "BindLabel", false) == 0)
			{
				reader.Read();
				this.BindLabel = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "Synch", false) == 0)
			{
				reader.Read();
				this.Synch = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			return false;
		}

		public virtual NInstanceItem CreateInstance()
		{
			return null;
		}

		public virtual void InitMetaItem(MMetaItem objMetaItem)
		{
		}

		public object Clone()
		{
			MMetaItem mMetaItem = (MMetaItem)Activator.CreateInstance(this.GetType());
			mMetaItem.XMLString = this.XMLString;
			return mMetaItem;
		}
	}
}
