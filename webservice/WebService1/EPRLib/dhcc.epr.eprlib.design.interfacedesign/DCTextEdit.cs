using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCTextEdit : DesignControl
	{
		private IContainer components;

		public PCTextEdit PCTextEdit;

		private const int WM_SETFOCUS = 7;

		public DCTextEdit()
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
			this.PCTextEdit = new PCTextEdit();
			this.Controls.Add(this.PCTextEdit);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCTextEdit;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCTextEdit.Left = x;
					this.PCTextEdit.Top = y;
					this.PCTextEdit.Width = this.Width;
					this.PCTextEdit.Height = this.Height;
				}
				else
				{
					this.PCTextEdit.Left = x;
					this.PCTextEdit.Top = y;
					this.PCTextEdit.Width = this.Width - 2 * x;
					this.PCTextEdit.Height = this.Height - 2 * y;
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
			writer.WriteStartElement("PCTextEdit");
			writer.WriteElementString("Code", this.PCTextEdit.Code);
			writer.WriteElementString("ReadOnly", Conversions.ToString(this.PCTextEdit.ReadOnly));
			ControlXML.XMLSerialize(writer, this);
			writer.WriteEndElement();
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.PCTextEdit.Code = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement && Operators.CompareString(reader.Name, "ReadOnly", false) == 0)
			{
				reader.Read();
				this.PCTextEdit.ReadOnly = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
