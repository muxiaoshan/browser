using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIClusterProperty : UserControl
	{
		private IContainer components;

		private MICluster _MICluster;

		public MICluster MICluster
		{
			get
			{
				return this._MICluster;
			}
			set
			{
				this._MICluster = value;
			}
		}

		public MIClusterProperty()
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
			this.Name = "MIClusterProperty";
			Size size = new Size(500, 400);
			this.Size = size;
		}
	}
}
