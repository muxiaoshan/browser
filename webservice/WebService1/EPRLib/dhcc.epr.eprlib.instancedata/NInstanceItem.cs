using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NInstanceItem : ICloneable
	{
		protected struct BindDataType
		{
			public string ValueCode;

			public string Value;

			public bool IsUseValueCode;

			public bool IsTypeMatching;
		}

		private NInstanceItem _Parent;

		private MMetaItem _BindMMetaItem;

		private NInstanceItemCollection _SubItems;

		private string _Code;

		private string _Value;

		private string _ValueCode;

		private FormateRangeCollection _FormatRangeCollection;

		private bool _RevStatus;

		private string _RevPerson;

		private string _RevTime;

		private string _RevIP;

		private RevisionHistory _RevisionHistory;

		public RevisionHistory RevisionHistory
		{
			get
			{
				return this._RevisionHistory;
			}
			set
			{
				this._RevisionHistory = value;
			}
		}

		public bool RevStatus
		{
			get
			{
				return this._RevStatus;
			}
			set
			{
				this._RevStatus = value;
				if (this.SubItems != null)
				{
					NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
						nInstanceItem.RevPerson = this.RevPerson;
						nInstanceItem.RevTime = this.RevTime;
						nInstanceItem.RevIP = this.RevIP;
						nInstanceItem.RevStatus = value;
					}
				}
			}
		}

		public string RevPerson
		{
			get
			{
				return this._RevPerson;
			}
			set
			{
				this._RevPerson = value;
			}
		}

		public string RevTime
		{
			get
			{
				return this._RevTime;
			}
			set
			{
				this._RevTime = value;
			}
		}

		public string RevIP
		{
			get
			{
				if (this._RevIP == null || this._RevIP.Equals(string.Empty))
				{
					return "未知位置";
				}
				return this._RevIP;
			}
			set
			{
				this._RevIP = value;
			}
		}

		public FormateRangeCollection FormatRangeCollection
		{
			get
			{
				return this._FormatRangeCollection;
			}
			set
			{
				this._FormatRangeCollection = value;
			}
		}

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

		public NInstanceItem Parent
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

		public MMetaItem BindMMetaItem
		{
			get
			{
				return this._BindMMetaItem;
			}
			set
			{
				this._BindMMetaItem = value;
			}
		}

		public NInstanceItemCollection SubItems
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

		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		public string ValueCode
		{
			get
			{
				return this._ValueCode;
			}
			set
			{
				this._ValueCode = value;
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

		public virtual string WholeString
		{
			get
			{
				string text = null;
				if (this.SubItems.Count > 0)
				{
					NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
						text += nInstanceItem.Value;
					}
				}
				return text;
			}
		}

		[DebuggerNonUserCode]
		public NInstanceItem()
		{
		}

		public virtual void XMLSerialize(XmlWriter writer)
		{
			string text = null;
			if (this.Value != null)
			{
				text = this.Value.Replace(" ", "&nbsp;");
				text = text.Replace("\r", "&KeyEnter;");
			}
			writer.WriteElementString("Code", this.Code);
			writer.WriteElementString("Value", text);
			writer.WriteElementString("ValueCode", this.ValueCode);
		}

		public virtual void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Code = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				if (reader.NodeType != XmlNodeType.EndElement)
				{
					this.Value = reader.Value.Replace("&nbsp;", " ");
					this.Value = this.Value.Replace("&KeyEnter;", "\r");
					reader.Read();
				}
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.ValueCode = reader.Value;
				reader.Read();
			}
		}

		public virtual void SyncMetaItem(MMetaItem metaitem)
		{
		}

		public virtual Controller CreateController()
		{
			return null;
		}

		public void BindEPRData(string str)
		{
			NInstanceItem.BindDataType ePRBindData = this.GetEPRBindData(str);
			if (ePRBindData.IsTypeMatching)
			{
				if (ePRBindData.IsUseValueCode)
				{
					this.Value = ePRBindData.Value.Replace("&KeyEnter;", "\r");
					this.ValueCode = ePRBindData.ValueCode.Replace("&KeyEnter;", "\r");
				}
				else
				{
					if (ePRBindData.Value == null)
					{
						ePRBindData.Value = "";
					}
					this.Value = ePRBindData.Value.Replace("&KeyEnter;", "\r");
					this.ValueCode = "";
				}
			}
		}

		public string GetEPRDataForCheckSynch(string str)
		{
			NInstanceItem.BindDataType ePRBindData = this.GetEPRBindData(str);
			if (ePRBindData.Value == null)
			{
				ePRBindData.Value = "";
			}
			return ePRBindData.Value;
		}

		protected virtual NInstanceItem.BindDataType GetEPRBindData(string str)
		{
			NInstanceItem.BindDataType result;
			return result;
		}

		public void BindDataBaseData(string str)
		{
			NInstanceItem.BindDataType dataBaseData = this.GetDataBaseData(str);
			if (dataBaseData.Value == null)
			{
				return;
			}
			if (dataBaseData.IsUseValueCode && dataBaseData.ValueCode == null)
			{
				return;
			}
			if (dataBaseData.IsUseValueCode)
			{
				this.ValueCode = dataBaseData.ValueCode;
			}
			this.Value = dataBaseData.Value;
		}

		public string GetDataBaseDataForCheckSynch(string str)
		{
			return this.GetDataBaseData(str).Value;
		}

		protected virtual NInstanceItem.BindDataType GetDataBaseData(string str)
		{
			NInstanceItem.BindDataType result;
			return result;
		}

		public virtual string GetByVType(string strVType)
		{
			return null;
		}

		public virtual void SetByVType(string strValue, string strVType)
		{
		}

		public object Clone()
		{
			NInstanceItem nInstanceItem = (NInstanceItem)Activator.CreateInstance(this.GetType());
			nInstanceItem.XMLString = this.XMLString;
			return nInstanceItem;
		}

		public virtual void SystemDataBind()
		{
		}

		public virtual void EPRDataBind()
		{
		}
	}
}
