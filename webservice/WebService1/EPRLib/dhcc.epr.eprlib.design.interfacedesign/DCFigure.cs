using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.figure;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCFigure : DesignControl
	{
		private IContainer components;

		public PCFigure PCFigure;

		private const int WM_SETFOCUS = 7;

		public DCFigure()
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
			this.PCFigure = new PCFigure();
			this.Controls.Add(this.PCFigure);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCFigure;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCFigure.Left = x;
					this.PCFigure.Top = y;
					this.PCFigure.Width = this.Width;
					this.PCFigure.Height = this.Height;
				}
				else
				{
					this.PCFigure.Left = x;
					this.PCFigure.Top = y;
					this.PCFigure.Width = this.Width - 2 * x;
					this.PCFigure.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCFigure");
			writer.WriteElementString("Code", this.PCFigure.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("ColCount", this.PCFigure.get_ColCount().ToString());
			writer.WriteStartElement("ColWidths");
			int arg_5E_0 = 0;
			int colCount = this.PCFigure.get_ColCount();
			checked
			{
				for (int i = arg_5E_0; i <= colCount; i++)
				{
					writer.WriteElementString("ColWidth", this.PCFigure.get_ColWidths().get_Item(i).ToString());
				}
				writer.WriteEndElement();
				writer.WriteElementString("HeaderHeight", this.PCFigure.get_RowHeights().get_Item(0).ToString());
				writer.WriteEndElement();
			}
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCFigure.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCFigure.set_ColCount(int.Parse(reader.Value));
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
						if (num <= this.PCFigure.get_ColCount())
						{
							this.PCFigure.get_ColWidths().set_Item(num, int.Parse(reader.Value));
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
					this.PCFigure.get_RowHeights().set_Item(0, int.Parse(reader.Value));
					reader.Read();
				}
			}
		}
	}
}
