using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class NITable : NInstanceItem
	{
		public NITable()
		{
			this.SubItems = new NInstanceItemCollection();
		}

		public void InitialData()
		{
			MITable mITable = (MITable)this.BindMMetaItem;
			this.SubItems.Clear();
			int num = 0;
			checked
			{
				do
				{
					NIRow nIRow = new NIRow();
					int arg_2F_0 = 0;
					int num2 = mITable.SubItems.Count - 1;
					for (int i = arg_2F_0; i <= num2; i++)
					{
						nIRow.SubItems.Add(mITable.SubItems[i].CreateInstance());
					}
					this.SubItems.Add(nIRow);
					num++;
				}
				while (num <= 9);
			}
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
			int arg_3F_0 = 0;
			checked
			{
				int num = this.SubItems.Count - 1;
				for (int i = arg_3F_0; i <= num; i++)
				{
					NIRow nIRow = (NIRow)this.SubItems[i];
					int arg_67_0 = 0;
					int num2 = nIRow.SubItems.Count - 1;
					for (int j = arg_67_0; j <= num2; j++)
					{
						NISimple nISimple = (NISimple)nIRow.SubItems[j];
						MISimple mISimple = (MISimple)this.BindMMetaItem.SubItems[j];
						if (Operators.CompareString(nISimple.Code, mISimple.Code, false) != 0)
						{
							MessageManager.ShowInformationMessage("同步异常！");
						}
						else
						{
							nISimple.BindMMetaItem = mISimple;
						}
					}
				}
			}
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("NITable");
			base.XMLSerialize(writer);
			writer.WriteStartElement("SubItems");
			NInstanceItemEnumerator enumerator = this.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				nInstanceItem.XMLSerialize(writer);
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			base.XMLDeserialize(reader);
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "NIRow", false) == 0)
					{
						NIRow nIRow = new NIRow();
						nIRow.XMLDeserialize(reader);
						this.SubItems.Add(this, nIRow);
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
