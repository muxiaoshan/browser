using dhcc.epr.eprlib.presentation;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCQuantity : DesignControl
	{
		private IContainer components;

		public PCQuantity PCQuantity;

		private const int WM_SETFOCUS = 7;

		public DCQuantity()
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
			this.PCQuantity = new PCQuantity();
			this.Controls.Add(this.PCQuantity);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCQuantity;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCQuantity.Left = x;
					this.PCQuantity.Top = y;
					this.PCQuantity.Width = this.Width;
					this.PCQuantity.Height = this.Height;
				}
				else
				{
					this.PCQuantity.Left = x;
					this.PCQuantity.Top = y;
					this.PCQuantity.Width = this.Width - 2 * x;
					this.PCQuantity.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCQuantity");
			writer.WriteElementString("Code", this.PCQuantity.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("PanelOneWidth", Conversions.ToString(this.PCQuantity.numPanel.Width));
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCQuantity.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (Operators.CompareString(reader.Name, "PanelOneWidth", false) == 0 & !reader.IsEmptyElement)
			{
				reader.Read();
				this.PCQuantity.numPanel.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
			}
		}
	}
}
