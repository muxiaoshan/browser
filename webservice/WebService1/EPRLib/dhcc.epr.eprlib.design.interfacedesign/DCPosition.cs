using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCPosition : DesignControl
	{
		private IContainer components;

		public PCPosition PCPosition;

		private const int WM_SETFOCUS = 7;

		public DCPosition()
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
			this.PCPosition = new PCPosition();
			this.Controls.Add(this.PCPosition);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCPosition;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCPosition.Left = x;
					this.PCPosition.Top = y;
					this.PCPosition.Width = this.Width;
					this.PCPosition.Height = this.Height;
				}
				else
				{
					this.PCPosition.Left = x;
					this.PCPosition.Top = y;
					this.PCPosition.Width = this.Width - 2 * x;
					this.PCPosition.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCPosition");
			writer.WriteElementString("Code", this.PCPosition.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCPosition.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			this.PCPosition.Left = 0;
			this.PCPosition.Top = 0;
			this.PCPosition.Width = this.Width;
			this.PCPosition.Height = this.Height;
		}
	}
}
