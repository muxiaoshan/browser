using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.table;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCTable : DesignControl
	{
		private IContainer components;

		public PCTable PCTable;

		private const int WM_SETFOCUS = 7;

		public DCTable()
		{
			this.InitializeComponent();
			this.Init();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		private void Init()
		{
			this.PCTable = new PCTable();
			this.Controls.Add(this.PCTable);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCTable;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCTable.Left = x;
					this.PCTable.Top = y;
					this.PCTable.Width = this.Width;
					this.PCTable.Height = this.Height;
				}
				else
				{
					this.PCTable.Left = x;
					this.PCTable.Top = y;
					this.PCTable.Width = this.Width - 2 * x;
					this.PCTable.Height = this.Height - 2 * y;
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg != 7)
			{
				base.WndProc(ref m);
			}
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("PCTable");
			writer.WriteElementString("Code", this.PCTable.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("ColCount", this.PCTable.get_ColCount().ToString());
			writer.WriteStartElement("ColWidths");
			int arg_5E_0 = 0;
			int colCount = this.PCTable.get_ColCount();
			checked
			{
				for (int i = arg_5E_0; i <= colCount; i++)
				{
					writer.WriteElementString("ColWidth", this.PCTable.get_ColWidths().get_Item(i).ToString());
				}
				writer.WriteEndElement();
				writer.WriteElementString("HeaderHeight", this.PCTable.get_RowHeights().get_Item(0).ToString());
				writer.WriteEndElement();
			}
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCTable.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCTable.set_ColCount(int.Parse(reader.Value));
				reader.Read();
			}
			reader.Read();
			int num = 0;
			checked
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "ColWidth", false) == 0)
					{
						reader.Read();
						if (num <= this.PCTable.get_ColCount())
						{
							this.PCTable.get_ColWidths().set_Item(num, int.Parse(reader.Value));
						}
						reader.Read();
						num++;
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "ColWidths", false) == 0)
					{
						break;
					}
				}
				reader.Read();
				if (Operators.CompareString(reader.Name, "HeaderHeight", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.PCTable.get_RowHeights().set_Item(0, int.Parse(reader.Value));
					reader.Read();
				}
			}
		}
	}
}
