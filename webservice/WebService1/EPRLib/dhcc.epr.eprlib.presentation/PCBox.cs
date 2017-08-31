using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCBox : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("gbBox")]
		private GroupBox _gbBox;

		internal virtual GroupBox gbBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbBox = value;
			}
		}

		public PCBox()
		{
			base.Paint += new PaintEventHandler(this.PCBox_Paint);
			base.Resize += new EventHandler(this.PCBox_Resize);
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
			this.gbBox = new GroupBox();
			this.SuspendLayout();
			this.gbBox.BackColor = Color.Transparent;
			Control arg_31_0 = this.gbBox;
			Point location = new Point(0, 0);
			arg_31_0.Location = location;
			this.gbBox.Name = "gbBox";
			Control arg_5E_0 = this.gbBox;
			Size size = new Size(256, 176);
			arg_5E_0.Size = size;
			this.gbBox.TabIndex = 0;
			this.gbBox.TabStop = false;
			this.Controls.Add(this.gbBox);
			this.Name = "PCBox";
			size = new Size(264, 184);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void PCBox_Paint(object sender, PaintEventArgs e)
		{
		}

		private void PCBox_Resize(object sender, EventArgs e)
		{
			checked
			{
				this.gbBox.Height = this.Height - this.gbBox.Top * 2;
				this.gbBox.Width = this.Width - this.gbBox.Left * 2;
			}
		}

		public void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
		}
	}
}
