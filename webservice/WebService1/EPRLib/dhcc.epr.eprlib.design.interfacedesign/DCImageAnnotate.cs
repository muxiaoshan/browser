using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCImageAnnotate : DesignControl
	{
		private IContainer components;

		public PCImageAnnotate PCImageAnnotate;

		private const int WM_SETFOCUS = 7;

		public DCImageAnnotate()
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
			this.PCImageAnnotate = new PCImageAnnotate();
			this.Controls.Add(this.PCImageAnnotate);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCImageAnnotate;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCImageAnnotate.Left = x;
					this.PCImageAnnotate.Top = y;
					this.PCImageAnnotate.Width = this.Width;
					this.PCImageAnnotate.Height = this.Height;
				}
				else
				{
					this.PCImageAnnotate.Left = x;
					this.PCImageAnnotate.Top = y;
					this.PCImageAnnotate.Width = this.Width - 2 * x;
					this.PCImageAnnotate.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCImageAnnotate");
			writer.WriteElementString("Code", this.PCImageAnnotate.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCImageAnnotate.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
