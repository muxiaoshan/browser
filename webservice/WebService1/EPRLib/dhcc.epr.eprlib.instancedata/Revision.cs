using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Xml;

namespace dhcc.epr.eprlib.instancedata
{
	public class Revision
	{
		public ArrayList SubRevisions;

		public string RevPerson;

		public string RevTime;

		private string _revIP;

		public string RevIP
		{
			get
			{
				return Conversions.ToString(Interaction.IIf(this._revIP == null || this._revIP.Equals(string.Empty), "未知位置", this._revIP));
			}
			set
			{
				this._revIP = value;
			}
		}

		public Revision()
		{
			this.SubRevisions = new ArrayList();
		}

		public void AddSubRevision(SubRevision objSubRevison)
		{
			this.SubRevisions.Add(objSubRevison);
			this.RefreshPos();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			this.SubRevisions.Clear();
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.RevPerson = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.RevTime = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this._revIP = reader.Value;
				reader.Read();
			}
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "SubRevision", false) == 0)
				{
					SubRevision subRevision = new SubRevision();
					subRevision.XMLDeserialize(reader);
					this.SubRevisions.Add(subRevision);
				}
				else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Revision", false) == 0)
				{
					break;
				}
			}
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("Revision");
			writer.WriteElementString("RevPerson", this.RevPerson);
			writer.WriteElementString("RevTime", this.RevTime);
			writer.WriteElementString("RevIP", this._revIP);
			try
			{
				IEnumerator enumerator = this.SubRevisions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SubRevision subRevision = (SubRevision)enumerator.Current;
					subRevision.XMLSerialize(writer);
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

		public void RefreshPos()
		{
			int num = 0;
			int arg_11_0 = 0;
			checked
			{
				int num2 = this.SubRevisions.Count - 1;
				for (int i = arg_11_0; i <= num2; i++)
				{
					SubRevision subRevision = (SubRevision)this.SubRevisions[i];
					if (subRevision.Content == null)
					{
						subRevision.Content = "";
					}
					if (Operators.CompareString(subRevision.RevType, "O", false) == 0 | Operators.CompareString(subRevision.RevType, "R", false) == 0)
					{
						subRevision.StartPos = num;
						num += subRevision.Content.Length;
						subRevision.EndPos = num;
					}
					else
					{
						subRevision.StartPos = num;
						subRevision.EndPos = num;
					}
				}
			}
		}

		public void Draw(PCTextEdit hlrtb)
		{
			try
			{
				try
				{
					IEnumerator enumerator = this.SubRevisions.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SubRevision subRevision = (SubRevision)enumerator.Current;
						subRevision.RevStartPos = hlrtb.SelectionStart;
						if (subRevision.Content == null)
						{
							subRevision.Content = "";
						}
						hlrtb.SelectedText = subRevision.Content;
						subRevision.RevEndPos = hlrtb.SelectionStart;
						hlrtb.SelectionStart = subRevision.RevStartPos;
						hlrtb.SelectionLength = checked(subRevision.RevEndPos - subRevision.RevStartPos);
						if (Operators.CompareString(subRevision.RevType, "R", false) == 0)
						{
							hlrtb.SelectionColor = Color.Red;
							hlrtb.SelectionFont = new Font(hlrtb.Font, FontStyle.Underline);
						}
						else if (Operators.CompareString(subRevision.RevType, "D", false) == 0)
						{
							hlrtb.SelectionColor = Color.Red;
							hlrtb.SelectionFont = new Font(hlrtb.Font, FontStyle.Strikeout);
						}
						else
						{
							hlrtb.SelectionColor = hlrtb.ForeColor;
							hlrtb.SelectionFont = hlrtb.Font;
						}
						hlrtb.SelectionLength = 0;
						hlrtb.SelectionStart = subRevision.RevEndPos;
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
			}
			catch (Exception expr_127)
			{
				ProjectData.SetProjectError(expr_127);
				Exception ex = expr_127;
				throw ex;
			}
		}
	}
}
