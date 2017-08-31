using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCHLine : DesignControl
	{
		private IContainer components;

		public PCHLine PCHLine;

		private const int WM_SETFOCUS = 7;

		public DCHLine()
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
			this.FixedHeight = true;
			this.ConstHeight = 4;
			this.PCHLine = new PCHLine();
			this.Controls.Add(this.PCHLine);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCHLine;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCHLine.Left = x;
					this.PCHLine.Top = y;
					this.PCHLine.Width = this.Width;
					this.PCHLine.Height = this.Height;
				}
				else
				{
					this.PCHLine.Left = x;
					this.PCHLine.Top = y;
					this.PCHLine.Width = this.Width - 2 * x;
					this.PCHLine.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCHLine");
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
