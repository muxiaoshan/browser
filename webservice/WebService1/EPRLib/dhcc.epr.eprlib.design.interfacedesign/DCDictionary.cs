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
	public class DCDictionary : DesignControl
	{
		private IContainer components;

		public PCDictionary PCDictionary;

		private const int WM_SETFOCUS = 7;

		public DCDictionary()
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
			this.PCDictionary = new PCDictionary();
			this.Controls.Add(this.PCDictionary);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCDictionary;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCDictionary.Left = x;
					this.PCDictionary.Top = y;
					this.PCDictionary.Width = this.Width;
					this.PCDictionary.Height = this.Height;
				}
				else
				{
					this.PCDictionary.Left = x;
					this.PCDictionary.Top = y;
					this.PCDictionary.Width = this.Width - 2 * x;
					this.PCDictionary.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCDictionary");
			writer.WriteElementString("Code", this.PCDictionary.Code);
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("PanelOneWidth", Conversions.ToString(this.PCDictionary.panel1.Width));
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCDictionary.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (Operators.CompareString(reader.Name, "PanelOneWidth", false) == 0 & !reader.IsEmptyElement)
			{
				reader.Read();
				this.PCDictionary.panel1.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
			}
			this.PCDictionary.Left = 0;
			this.PCDictionary.Top = 0;
			this.PCDictionary.Width = this.Width;
			this.PCDictionary.Height = this.Height;
		}
	}
}
