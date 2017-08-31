using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCVline : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblline")]
		private Label _lblline;

		internal virtual Label lblline
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblline;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblline = value;
			}
		}

		public PCVline()
		{
			base.Resize += new EventHandler(this.PCHLine_Resize);
			base.Paint += new PaintEventHandler(this.PCVline_Paint);
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
			this.lblline = new Label();
			this.SuspendLayout();
			this.lblline.BackColor = Color.FromArgb(101, 120, 139);
			Control arg_3A_0 = this.lblline;
			Point location = new Point(1, 0);
			arg_3A_0.Location = location;
			this.lblline.Name = "lblline";
			Control arg_60_0 = this.lblline;
			Size size = new Size(2, 100);
			arg_60_0.Size = size;
			this.lblline.TabIndex = 0;
			this.lblline.Text = "Label1";
			this.Controls.Add(this.lblline);
			this.Name = "PCVline";
			size = new Size(4, 150);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void PCVline_Paint(object sender, PaintEventArgs e)
		{
		}

		private void PCHLine_Resize(object sender, EventArgs e)
		{
			this.lblline.Height = this.Height;
		}

		public void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
