using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NITextDesc : NInstanceItem
	{
		public override string WholeString
		{
			get
			{
				string text = null;
				NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					if (nInstanceItem is NIFree)
					{
						text += nInstanceItem.Value;
					}
					else if (nInstanceItem is NISegment)
					{
						text += nInstanceItem.WholeString;
					}
				}
				return text;
			}
		}

		public NITextDesc()
		{
			this.SubItems = new NInstanceItemCollection();
			this.FormatRangeCollection = new FormateRangeCollection();
		}

		public override void SyncMetaItem(MMetaItem metaitem)
		{
			if (Operators.CompareString(this.Code, metaitem.Code, false) == 0)
			{
				this.BindMMetaItem = metaitem;
				metaitem.BindInstanceItem = this;
			}
			else
			{
				MessageManager.ShowInformationMessage("同步异常！");
			}
			int arg_3E_0 = 0;
			checked
			{
				int num = this.SubItems.Count - 1;
				for (int i = arg_3E_0; i <= num; i++)
				{
					NInstanceItem nInstanceItem = this.SubItems[i];
					if (nInstanceItem is NISegment && nInstanceItem is NISegment)
					{
						nInstanceItem.SyncMetaItem(null);
					}
				}
			}
		}

		public override Controller CreateController()
		{
			return new TextDescController
			{
				BindInstanceItem = this
			};
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NITextDesc");
			base.XMLSerialize(writer);
			writer.WriteStartElement("SubItems");
			this.FormatRangeCollection.Clear();
			NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				nInstanceItem.XMLSerialize(writer);
				FormateRangeEnumerator enumerator2 = nInstanceItem.FormatRangeCollection.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					FormateRange value = (FormateRange)enumerator2.Current;
					this.FormatRangeCollection.Add(value);
				}
			}
			writer.WriteEndElement();
			if (this.FormatRangeCollection != null)
			{
				this.FormatRangeCollection.XMLSerialize(writer);
			}
			if (this.RevisionHistory != null)
			{
				this.RevisionHistory.XMLSerialize(writer);
			}
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.Name, "FormatRangeCollection", false) == 0 & !reader.IsEmptyElement)
				{
					this.FormatRangeCollection.XMLDeserialize(reader);
				}
				if (Operators.CompareString(reader.Name, "RevisionHistory", false) == 0)
				{
					RevisionHistory revisionHistory = new RevisionHistory();
					revisionHistory.XMLDeserialize(reader);
					this.RevisionHistory = revisionHistory;
				}
				if (Operators.CompareString(reader.Name, "NITextDesc", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
				if (Operators.CompareString(reader.Name, "SubItems", false) == 0 & !reader.IsEmptyElement)
				{
					while (reader.Read())
					{
						if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NISegment", false) == 0)
						{
							NISegment nISegment = new NISegment();
							nISegment.XMLDeserialize(reader);
							this.SubItems.Add(this, nISegment);
						}
						else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIFree", false) == 0)
						{
							NIFree nIFree = new NIFree();
							nIFree.XMLDeserialize(reader);
							this.SubItems.Add(this, nIFree);
						}
						else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
						{
							break;
						}
					}
				}
			}
		}
	}
}
