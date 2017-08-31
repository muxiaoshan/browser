using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCHLine : UserControl
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

		public PCHLine()
		{
			base.Paint += new PaintEventHandler(this.PCHLine_Paint);
			base.Resize += new EventHandler(this.PCHLine_Resize);
			base.Load += new EventHandler(this.PCHLine_Load);
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
			Point location = new Point(0, 1);
			arg_3A_0.Location = location;
			this.lblline.Name = "lblline";
			Control arg_60_0 = this.lblline;
			Size size = new Size(100, 2);
			arg_60_0.Size = size;
			this.lblline.TabIndex = 0;
			this.Controls.Add(this.lblline);
			this.Name = "PCHLine";
			size = new Size(224, 4);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void PCHLine_Paint(object sender, PaintEventArgs e)
		{
		}

		private void PCHLine_Resize(object sender, EventArgs e)
		{
			this.lblline.Width = this.Width;
		}

		public void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}

		private void PCHLine_Load(object sender, EventArgs e)
		{
		}
	}
}
