using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.table
{
	public class TableFormateForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("lblAlign")]
		private Label _lblAlign;

		[AccessedThroughProperty("lblFont")]
		private Label _lblFont;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("cbxFont")]
		private ComboBox _cbxFont;

		[AccessedThroughProperty("btnFont")]
		private Button _btnFont;

		[AccessedThroughProperty("lblText")]
		private Label _lblText;

		[AccessedThroughProperty("txtContent")]
		private TextBox _txtContent;

		[AccessedThroughProperty("cbxVAlign")]
		private ComboBox _cbxVAlign;

		[AccessedThroughProperty("lblVAlign")]
		private Label _lblVAlign;

		internal virtual Label lblAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAlign = value;
			}
		}

		internal virtual Label lblFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFont = value;
			}
		}

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= value2;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += value2;
				}
			}
		}

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		internal virtual ComboBox cbxFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxFont = value;
			}
		}

		internal virtual Button btnFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnFont_Click);
				if (this._btnFont != null)
				{
					this._btnFont.Click -= value2;
				}
				this._btnFont = value;
				if (this._btnFont != null)
				{
					this._btnFont.Click += value2;
				}
			}
		}

		internal virtual Label lblText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblText;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblText = value;
			}
		}

		internal virtual TextBox txtContent
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtContent;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtContent = value;
			}
		}

		internal virtual ComboBox cbxVAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxVAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxVAlign = value;
			}
		}

		internal virtual Label lblVAlign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblVAlign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblVAlign = value;
			}
		}

		public TableFormateForm()
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
			this.lblAlign = new Label();
			this.lblFont = new Label();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.cbxFont = new ComboBox();
			this.btnFont = new Button();
			this.lblText = new Label();
			this.txtContent = new TextBox();
			this.cbxVAlign = new ComboBox();
			this.lblVAlign = new Label();
			this.SuspendLayout();
			Control arg_86_0 = this.lblAlign;
			Point location = new Point(16, 82);
			arg_86_0.Location = location;
			this.lblAlign.Name = "lblAlign";
			Control arg_AD_0 = this.lblAlign;
			Size size = new Size(56, 16);
			arg_AD_0.Size = size;
			this.lblAlign.TabIndex = 0;
			this.lblAlign.Text = "水平对齐";
			Control arg_E3_0 = this.lblFont;
			location = new Point(16, 128);
			arg_E3_0.Location = location;
			this.lblFont.Name = "lblFont";
			Control arg_10A_0 = this.lblFont;
			size = new Size(64, 20);
			arg_10A_0.Size = size;
			this.lblFont.TabIndex = 1;
			this.lblFont.Text = "字体设置";
			Control arg_143_0 = this.btnOK;
			location = new Point(155, 174);
			arg_143_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_16A_0 = this.btnOK;
			size = new Size(56, 23);
			arg_16A_0.Size = size;
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "确定";
			Control arg_1A3_0 = this.btnCancel;
			location = new Point(235, 174);
			arg_1A3_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_1CA_0 = this.btnCancel;
			size = new Size(56, 23);
			arg_1CA_0.Size = size;
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "取消";
			this.cbxFont.Items.AddRange(new object[]
			{
				"居中",
				"居左",
				"居右"
			});
			Control arg_22D_0 = this.cbxFont;
			location = new Point(80, 80);
			arg_22D_0.Location = location;
			this.cbxFont.Name = "cbxFont";
			Control arg_254_0 = this.cbxFont;
			size = new Size(56, 20);
			arg_254_0.Size = size;
			this.cbxFont.TabIndex = 4;
			Control arg_277_0 = this.btnFont;
			location = new Point(80, 120);
			arg_277_0.Location = location;
			this.btnFont.Name = "btnFont";
			Control arg_29E_0 = this.btnFont;
			size = new Size(48, 48);
			arg_29E_0.Size = size;
			this.btnFont.TabIndex = 5;
			this.btnFont.Text = "字";
			Control arg_2D1_0 = this.lblText;
			location = new Point(16, 16);
			arg_2D1_0.Location = location;
			this.lblText.Name = "lblText";
			Control arg_2F8_0 = this.lblText;
			size = new Size(56, 16);
			arg_2F8_0.Size = size;
			this.lblText.TabIndex = 6;
			this.lblText.Text = "文字内容";
			Control arg_32B_0 = this.txtContent;
			location = new Point(80, 16);
			arg_32B_0.Location = location;
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			Control arg_361_0 = this.txtContent;
			size = new Size(208, 48);
			arg_361_0.Size = size;
			this.txtContent.TabIndex = 7;
			this.cbxVAlign.Items.AddRange(new object[]
			{
				"居中",
				"居上",
				"居下"
			});
			Control arg_3B7_0 = this.cbxVAlign;
			location = new Point(224, 80);
			arg_3B7_0.Location = location;
			this.cbxVAlign.Name = "cbxVAlign";
			Control arg_3DE_0 = this.cbxVAlign;
			size = new Size(64, 20);
			arg_3DE_0.Size = size;
			this.cbxVAlign.TabIndex = 8;
			Control arg_404_0 = this.lblVAlign;
			location = new Point(155, 82);
			arg_404_0.Location = location;
			this.lblVAlign.Name = "lblVAlign";
			Control arg_42B_0 = this.lblVAlign;
			size = new Size(56, 16);
			arg_42B_0.Size = size;
			this.lblVAlign.TabIndex = 9;
			this.lblVAlign.Text = "水平对齐";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(322, 218);
			this.ClientSize = size;
			this.Controls.Add(this.lblVAlign);
			this.Controls.Add(this.cbxVAlign);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.cbxFont);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblFont);
			this.Controls.Add(this.lblAlign);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "TableFormateForm";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "格式设置";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = this.btnFont.Font;
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.btnFont.Font = fontDialog.Font;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
