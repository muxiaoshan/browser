using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class RevisionHistory
	{
		public ArrayList Revisions;

		public Revision CurrentRevision;

		public RevisionHistory()
		{
			this.Revisions = new ArrayList();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			this.Revisions.Clear();
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "Revision", false) == 0)
				{
					Revision revision = new Revision();
					revision.XMLDeserialize(reader);
					this.Revisions.Add(revision);
				}
				else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "RevisionHistory", false) == 0)
				{
					break;
				}
			}
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("RevisionHistory");
			try
			{
				IEnumerator enumerator = this.Revisions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Revision revision = (Revision)enumerator.Current;
					revision.XMLSerialize(writer);
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
			writer.WriteEndElement();
		}
	}
}
