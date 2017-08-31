using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.previewmanage
{
	public class UCCfg : UserControl
	{
		private Container components;

		public string DataServiceUrl
		{
			get
			{
				return Configration.DataServiceUrl;
			}
			set
			{
				Configration.DataServiceUrl = value;
			}
		}

		public string FormServiceUrl
		{
			get
			{
				return Configration.FormServiceUrl;
			}
			set
			{
				Configration.FormServiceUrl = value;
			}
		}

		public UCCfg()
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

		private void InitializeComponent()
		{
			this.components = new Container();
		}
	}
}
