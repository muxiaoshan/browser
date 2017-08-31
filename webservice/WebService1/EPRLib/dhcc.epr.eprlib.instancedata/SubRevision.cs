using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class SubRevision
	{
		public string RevType;

		public int StartPos;

		public int EndPos;

		public int RevStartPos;

		public int RevEndPos;

		public string Content;

		[DebuggerNonUserCode]
		public SubRevision()
		{
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.RevType = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Content = reader.Value;
				reader.Read();
			}
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("SubRevision");
			writer.WriteElementString("RevType", this.RevType);
			writer.WriteElementString("Content", this.Content);
			writer.WriteEndElement();
		}
	}
}
