using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MILinkProperty : UserControl
	{
		private IContainer components;

		private MILink _MILink;

		public MILink MILink
		{
			get
			{
				return this._MILink;
			}
			set
			{
				this._MILink = value;
			}
		}

		public MILinkProperty()
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
			this.Name = "MILinkProperty";
			Size size = new Size(500, 400);
			this.Size = size;
		}
	}
}
