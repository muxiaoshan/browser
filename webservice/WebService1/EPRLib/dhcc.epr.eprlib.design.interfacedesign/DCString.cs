using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCString : DesignControl
	{
		private IContainer components;

		public PCString PCString;

		private const int WM_SETFOCUS = 7;

		public DCString()
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
			this.PCString = new PCString();
			this.PControl = this.PCString;
			this.Controls.Add(this.PCString);
			this.SetStyle(ControlStyles.Selectable, true);
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCString.Left = x;
					this.PCString.Top = y;
					this.PCString.Width = this.Width;
					this.PCString.Height = this.Height;
				}
				else
				{
					this.PCString.Left = x;
					this.PCString.Top = y;
					this.PCString.Width = this.Width - 2 * x;
					this.PCString.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCString");
			writer.WriteElementString("Code", this.PCString.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCString.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
