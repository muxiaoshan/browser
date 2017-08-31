using dhcc.epr.eprlib.presentation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCMonoChoice : DesignControl
	{
		private IContainer components;

		public PCMonoChoice PCMonoChoice;

		private const int WM_SETFOCUS = 7;

		public DCMonoChoice()
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
			this.ConstHeight = 20;
			this.PCMonoChoice = new PCMonoChoice();
			this.Controls.Add(this.PCMonoChoice);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCMonoChoice;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCMonoChoice.Left = x;
					this.PCMonoChoice.Top = y;
					this.PCMonoChoice.Width = this.Width;
					this.PCMonoChoice.Height = this.Height;
				}
				else
				{
					this.PCMonoChoice.Left = x;
					this.PCMonoChoice.Top = y;
					this.PCMonoChoice.Width = this.Width - 2 * x;
					this.PCMonoChoice.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCMonoChoice");
			writer.WriteElementString("Code", this.PCMonoChoice.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCMonoChoice.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
