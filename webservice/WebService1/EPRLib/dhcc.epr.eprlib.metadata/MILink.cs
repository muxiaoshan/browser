using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MILink : MMetaItem
	{
		[DebuggerNonUserCode]
		public MILink()
		{
		}

		public override NInstanceItem CreateInstance()
		{
			return new NILink
			{
				Code = this.Code,
				BindMMetaItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MILink");
			base.XMLSerialize(writer);
			writer.WriteEndElement();
		}

		public override bool GetDataByXMLDeserialize(XmlReader reader, string tagName)
		{
			return base.GetDataByXMLDeserialize(reader, tagName) || Operators.CompareString(tagName, "Nothing", false) == 0;
		}
	}
}
