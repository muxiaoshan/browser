using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MISimple : MMetaItem
	{
		private bool _AllowNull;

		private string _ValidateMsg;

		public bool AllowNull
		{
			get
			{
				return this._AllowNull;
			}
			set
			{
				this._AllowNull = value;
			}
		}

		public string ValidateMsg
		{
			get
			{
				return this._ValidateMsg;
			}
			set
			{
				this._ValidateMsg = value;
			}
		}

		[DebuggerNonUserCode]
		public MISimple()
		{
		}

		public override NInstanceItem CreateInstance()
		{
			return new NISimple
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			base.XMLSerialize(writer);
			writer.WriteElementString("AllowNull", this.AllowNull.ToString());
			writer.WriteElementString("ValidateMsg", this.ValidateMsg);
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			if (base.GetDataByXMLDeserialize(reader, tagName))
			{
				return true;
			}
			if (Operators.CompareString(tagName, "AllowNull", false) == 0)
			{
				reader.Read();
				this.AllowNull = bool.Parse(reader.Value);
				reader.Read();
				return true;
			}
			if (Operators.CompareString(tagName, "ValidateMsg", false) == 0)
			{
				reader.Read();
				this.ValidateMsg = reader.Value;
				reader.Read();
				return true;
			}
			return false;
		}
	}
}
