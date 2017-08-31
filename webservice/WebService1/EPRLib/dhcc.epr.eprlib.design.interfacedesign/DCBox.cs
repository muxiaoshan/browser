using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCBox : DesignControl
	{
		private IContainer components;

		public PCBox PCBox;

		private const int WM_SETFOCUS = 7;

		public DCBox()
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
			this.Name = "DCBox";
			Point originLocation = new Point(13, 13);
			this.OriginLocation = originLocation;
			Size size = new Size(8, 8);
			this.OriginSize = size;
			size = new Size(8, 8);
			this.Size = size;
		}

		private void Init()
		{
			this.PCBox = new PCBox();
			this.Controls.Add(this.PCBox);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCBox;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCBox.Left = x;
					this.PCBox.Top = y;
					this.PCBox.Width = this.Width;
					this.PCBox.Height = this.Height;
				}
				else
				{
					this.PCBox.Left = x;
					this.PCBox.Top = y;
					this.PCBox.Width = this.Width - 2 * x;
					this.PCBox.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCBox");
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
