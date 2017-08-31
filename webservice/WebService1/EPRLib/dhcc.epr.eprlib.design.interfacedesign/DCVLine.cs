using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCVLine : DesignControl
	{
		private IContainer components;

		public PCVline PCVLine;

		private const int WM_SETFOCUS = 7;

		public DCVLine()
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
			this.FixedWidth = true;
			this.ConstWidth = 4;
			this.PCVLine = new PCVline();
			this.Controls.Add(this.PCVLine);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCVLine;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCVLine.Left = x;
					this.PCVLine.Top = y;
					this.PCVLine.Width = this.Width;
					this.PCVLine.Height = this.Height;
				}
				else
				{
					this.PCVLine.Left = x;
					this.PCVLine.Top = y;
					this.PCVLine.Width = this.Width - 2 * x;
					this.PCVLine.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCVLine");
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
