using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCNumber : DesignControl
	{
		private IContainer components;

		public PCNumber PCNumber;

		private const int WM_SETFOCUS = 7;

		public DCNumber()
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
			this.ConstHeight = 21;
			this.PCNumber = new PCNumber();
			this.Controls.Add(this.PCNumber);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCNumber;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCNumber.Left = x;
					this.PCNumber.Top = y;
					this.PCNumber.Width = this.Width;
					this.PCNumber.Height = this.Height;
				}
				else
				{
					this.PCNumber.Left = x;
					this.PCNumber.Top = y;
					this.PCNumber.Width = this.Width - 2 * x;
					this.PCNumber.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCNumber");
			writer.WriteElementString("Code", this.PCNumber.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCNumber.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
