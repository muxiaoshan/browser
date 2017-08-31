using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIPositionProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblImage")]
		private Label _lblImage;

		[AccessedThroughProperty("txtImage")]
		private TextBox _txtImage;

		[AccessedThroughProperty("btnSelect")]
		private Button _btnSelect;

		private MIPosition _MIPosition;

		internal virtual Label lblImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblImage = value;
			}
		}

		internal virtual TextBox txtImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtImage = value;
			}
		}

		internal virtual Button btnSelect
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSelect;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSelect_Click);
				if (this._btnSelect != null)
				{
					this._btnSelect.Click -= value2;
				}
				this._btnSelect = value;
				if (this._btnSelect != null)
				{
					this._btnSelect.Click += value2;
				}
			}
		}

		public MIPosition MIPosition
		{
			get
			{
				return this._MIPosition;
			}
			set
			{
				this._MIPosition = value;
				this.txtImage.Text = this._MIPosition.ImageName;
			}
		}

		public MIPositionProperty()
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
			this.lblImage = new Label();
			this.txtImage = new TextBox();
			this.btnSelect = new Button();
			this.SuspendLayout();
			Control arg_39_0 = this.lblImage;
			Point location = new Point(32, 40);
			arg_39_0.Location = location;
			this.lblImage.Name = "lblImage";
			Control arg_60_0 = this.lblImage;
			Size size = new Size(56, 21);
			arg_60_0.Size = size;
			this.lblImage.TabIndex = 0;
			this.lblImage.Text = "图片名称";
			Control arg_93_0 = this.txtImage;
			location = new Point(112, 40);
			arg_93_0.Location = location;
			this.txtImage.Name = "txtImage";
			Control arg_BD_0 = this.txtImage;
			size = new Size(144, 21);
			arg_BD_0.Size = size;
			this.txtImage.TabIndex = 1;
			this.txtImage.Text = "";
			Control arg_F3_0 = this.btnSelect;
			location = new Point(272, 40);
			arg_F3_0.Location = location;
			this.btnSelect.Name = "btnSelect";
			Control arg_11A_0 = this.btnSelect;
			size = new Size(40, 23);
			arg_11A_0.Size = size;
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "选择";
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.txtImage);
			this.Controls.Add(this.lblImage);
			this.Name = "MIPositionProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			ImagePositionForm imagePositionForm = new ImagePositionForm();
			if (imagePositionForm.ShowDialog() == DialogResult.OK && imagePositionForm.CurrentImagePos != null)
			{
				this._MIPosition.ImageCode = imagePositionForm.CurrentImagePos.Code;
				this._MIPosition.ImageName = imagePositionForm.CurrentImagePos.Name;
				this.txtImage.Text = this._MIPosition.ImageName;
			}
		}
	}
}
