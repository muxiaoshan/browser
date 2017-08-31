using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCMultiChoice : DesignControl
	{
		private IContainer components;

		public PCMultiChoice PCMultiChoice;

		private const int WM_SETFOCUS = 7;

		public DCMultiChoice()
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
			this.SuspendLayout();
			this.Name = "DCMultiChoice";
			Point originLocation = new Point(15, 15);
			this.OriginLocation = originLocation;
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.PCMultiChoice = new PCMultiChoice();
			this.Controls.Add(this.PCMultiChoice);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCMultiChoice;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCMultiChoice.Left = x;
					this.PCMultiChoice.Top = y;
					this.PCMultiChoice.Width = this.Width;
					this.PCMultiChoice.Height = this.Height;
				}
				else
				{
					this.PCMultiChoice.Left = x;
					this.PCMultiChoice.Top = y;
					this.PCMultiChoice.Width = this.Width - 2 * x;
					this.PCMultiChoice.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCMultiChoice");
			writer.WriteElementString("Code", this.PCMultiChoice.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCMultiChoice.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
