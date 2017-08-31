using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCLabel : Label, PControlInterface
	{
		private NInstanceItem _BindInstanceItem;

		private string _Code;

		private IContainer components;

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindInstanceItem;
			}
			set
			{
				if (value != null)
				{
					this._Code = value.Code;
					this._BindInstanceItem = value;
					this.Text = this._BindInstanceItem.BindMMetaItem.Text;
				}
			}
		}

		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		public PCLabel()
		{
			this.InitializeComponent();
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

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Code = reader.Value;
				reader.Read();
				reader.Read();
				if (Operators.CompareString(reader.Name, "TextAlign", false) == 0)
				{
					reader.Read();
					if (Operators.CompareString(reader.Value, "", false) != 0)
					{
						this.TextAlign = (ContentAlignment)Conversions.ToInteger(reader.Value);
					}
					reader.Read();
				}
			}
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
