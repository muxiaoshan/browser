using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MITableProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("cbxHAlignment")]
		private ComboBox _cbxHAlignment;

		private MITable _MITable;

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual ComboBox cbxHAlignment
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxHAlignment;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxHAlignment_SelectedIndexChanged);
				if (this._cbxHAlignment != null)
				{
					this._cbxHAlignment.SelectedIndexChanged -= value2;
				}
				this._cbxHAlignment = value;
				if (this._cbxHAlignment != null)
				{
					this._cbxHAlignment.SelectedIndexChanged += value2;
				}
			}
		}

		public MITable MITable
		{
			get
			{
				return this._MITable;
			}
			set
			{
				this._MITable = value;
				if (this._MITable.HorizontalAlignment == 1)
				{
					this.cbxHAlignment.SelectedIndex = 0;
				}
				else if (this._MITable.HorizontalAlignment == 2)
				{
					this.cbxHAlignment.SelectedIndex = 1;
				}
				else if (this._MITable.HorizontalAlignment == 3)
				{
					this.cbxHAlignment.SelectedIndex = 2;
				}
			}
		}

		public MITableProperty()
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
			this.Label1 = new Label();
			this.cbxHAlignment = new ComboBox();
			this.SuspendLayout();
			Control arg_2C_0 = this.Label1;
			Point location = new Point(6, 8);
			arg_2C_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_53_0 = this.Label1;
			Size size = new Size(105, 23);
			arg_53_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "水平对齐方式：";
			this.Label1.TextAlign = ContentAlignment.MiddleRight;
			this.cbxHAlignment.Items.AddRange(new object[]
			{
				"靠左对齐",
				"中间对齐",
				"靠右对齐"
			});
			Control arg_C2_0 = this.cbxHAlignment;
			location = new Point(111, 8);
			arg_C2_0.Location = location;
			this.cbxHAlignment.Name = "cbxHAlignment";
			Control arg_EC_0 = this.cbxHAlignment;
			size = new Size(208, 20);
			arg_EC_0.Size = size;
			this.cbxHAlignment.TabIndex = 1;
			this.Controls.Add(this.cbxHAlignment);
			this.Controls.Add(this.Label1);
			this.Name = "MITableProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void cbxHAlignment_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxHAlignment.SelectedIndex == 0)
			{
				this._MITable.HorizontalAlignment = 1;
			}
			else if (this.cbxHAlignment.SelectedIndex == 1)
			{
				this._MITable.HorizontalAlignment = 2;
			}
			else if (this.cbxHAlignment.SelectedIndex == 2)
			{
				this._MITable.HorizontalAlignment = 3;
			}
		}
	}
}
