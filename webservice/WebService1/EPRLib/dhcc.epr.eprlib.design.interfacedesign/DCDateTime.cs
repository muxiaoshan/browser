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
	public class DCDateTime : DesignControl
	{
		private IContainer components;

		public PCDateTime PCDateTime;

		private const int WM_SETFOCUS = 7;

		public DCDateTime()
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
			this.PCDateTime = new PCDateTime();
			this.Controls.Add(this.PCDateTime);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCDateTime;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCDateTime.Left = x;
					this.PCDateTime.Top = y;
					this.PCDateTime.Width = this.Width;
					this.PCDateTime.Height = this.Height;
				}
				else
				{
					this.PCDateTime.Left = x;
					this.PCDateTime.Top = y;
					this.PCDateTime.Width = this.Width - 2 * x;
					this.PCDateTime.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCDateTime");
			writer.WriteElementString("Code", this.PCDateTime.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("PanelOneWidth", Conversions.ToString(this.PCDateTime.DatePanel.Width));
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCDateTime.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (Operators.CompareString(reader.Name, "PanelOneWidth", false) == 0 & !reader.IsEmptyElement)
			{
				reader.Read();
				this.PCDateTime.DatePanel.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
			}
			this.PCDateTime.Left = 0;
			this.PCDateTime.Top = 0;
			this.PCDateTime.Width = this.Width;
			this.PCDateTime.Height = this.Height;
		}
	}
}
