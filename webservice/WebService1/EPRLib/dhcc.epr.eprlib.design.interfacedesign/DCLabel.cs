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
	public class DCLabel : DesignControl
	{
		private IContainer components;

		public PCLabel PCLabel;

		private const int WM_SETFOCUS = 7;

		public DCLabel()
		{
			this.InitializeComponent();
			this.Init();
		}

		public DCLabel(double argFontSize) : this()
		{
			this.Font = new Font(this.Font.Name, (float)argFontSize);
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
			this.PCLabel = new PCLabel();
			this.PControl = this.PCLabel;
			this.Controls.Add(this.PCLabel);
			this.SetStyle(ControlStyles.Selectable, true);
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCLabel.Left = x;
					this.PCLabel.Top = y;
					this.PCLabel.Width = this.Width;
					this.PCLabel.Height = this.Height;
				}
				else
				{
					this.PCLabel.Left = x;
					this.PCLabel.Top = y;
					this.PCLabel.Width = this.Width - 2 * x;
					this.PCLabel.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCLabel");
			writer.WriteElementString("Code", this.PCLabel.Code);
			writer.WriteElementString("TextAlign", Conversions.ToString((int)this.PCLabel.TextAlign));
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCLabel.Code = reader.Value;
				reader.Read();
				reader.Read();
				if (Operators.CompareString(reader.Name, "TextAlign", false) == 0)
				{
					reader.Read();
					if (Operators.CompareString(reader.Value, "", false) != 0)
					{
						this.PCLabel.TextAlign = (ContentAlignment)Conversions.ToInteger(reader.Value);
					}
					reader.Read();
				}
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
