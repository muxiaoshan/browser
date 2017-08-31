using dhcc.epr.eprlib.instancedata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class FormateForm : dhcc.epr.eprlib.presentation.MovableForm
	{
		private Point ClickedPoint;

		private bool BoolMouseDown;

		private FontStruct _OldFontStruct;

		private FontStruct _NewFontStruct;

		private IContainer components;

		[AccessedThroughProperty("cbxSuperscript")]
		private CheckBox _cbxSuperscript;

		[AccessedThroughProperty("cbxSubscript")]
		private CheckBox _cbxSubscript;

		[AccessedThroughProperty("cbxBold")]
		private CheckBox _cbxBold;

		[AccessedThroughProperty("cbxItalic")]
		private CheckBox _cbxItalic;

		[AccessedThroughProperty("gbxFormate")]
		private GroupBox _gbxFormate;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("cbxStrikeout")]
		private CheckBox _cbxStrikeout;

		[AccessedThroughProperty("cbxUnderline")]
		private CheckBox _cbxUnderline;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("llCancel")]
		private LinkLabel _llCancel;

		[AccessedThroughProperty("llOK")]
		private LinkLabel _llOK;

		internal virtual CheckBox cbxSuperscript
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxSuperscript;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxSuperscript_CheckedChanged);
				if (this._cbxSuperscript != null)
				{
					this._cbxSuperscript.CheckedChanged -= value2;
				}
				this._cbxSuperscript = value;
				if (this._cbxSuperscript != null)
				{
					this._cbxSuperscript.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxSubscript
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxSubscript;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxSubscript_CheckedChanged);
				if (this._cbxSubscript != null)
				{
					this._cbxSubscript.CheckedChanged -= value2;
				}
				this._cbxSubscript = value;
				if (this._cbxSubscript != null)
				{
					this._cbxSubscript.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxBold
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxBold;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxBold = value;
			}
		}

		internal virtual CheckBox cbxItalic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxItalic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxItalic = value;
			}
		}

		internal virtual GroupBox gbxFormate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxFormate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxFormate = value;
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

		internal virtual CheckBox cbxStrikeout
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxStrikeout;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxStrikeout = value;
			}
		}

		internal virtual CheckBox cbxUnderline
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxUnderline;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxUnderline = value;
			}
		}

		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual LinkLabel llCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llCancel_LinkClicked);
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked -= value2;
				}
				this._llCancel = value;
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked += value2;
				}
			}
		}

		internal virtual LinkLabel llOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llOK_LinkClicked);
				if (this._llOK != null)
				{
					this._llOK.LinkClicked -= value2;
				}
				this._llOK = value;
				if (this._llOK != null)
				{
					this._llOK.LinkClicked += value2;
				}
			}
		}

		public FontStruct OldFontStruct
		{
			get
			{
				return this._OldFontStruct;
			}
			set
			{
				this._OldFontStruct = value;
				this.cbxSuperscript.Checked = this.OldFontStruct.Superscript;
				this.cbxSubscript.Checked = this.OldFontStruct.Subscript;
				this.cbxBold.Checked = this.OldFontStruct.Bold;
				this.cbxItalic.Checked = this.OldFontStruct.Italic;
				this.cbxUnderline.Checked = this.OldFontStruct.Underline;
				this.cbxStrikeout.Checked = this.OldFontStruct.Strikeout;
				if (value.CharOffset > 0)
				{
					this.cbxSuperscript.Checked = true;
					this.cbxSubscript.Checked = false;
				}
				else if (value.CharOffset < 0)
				{
					this.cbxSuperscript.Checked = false;
					this.cbxSubscript.Checked = true;
				}
				else
				{
					this.cbxSuperscript.Checked = false;
					this.cbxSubscript.Checked = false;
				}
			}
		}

		public FontStruct NewFontStruct
		{
			get
			{
				this._NewFontStruct = new FontStruct((Font)this.OldFontStruct.Font.Clone());
				this._NewFontStruct.Superscript = this.cbxSuperscript.Checked;
				this._NewFontStruct.Subscript = this.cbxSubscript.Checked;
				this._NewFontStruct.Bold = this.cbxBold.Checked;
				this._NewFontStruct.Italic = this.cbxItalic.Checked;
				this._NewFontStruct.Underline = this.cbxUnderline.Checked;
				this._NewFontStruct.Strikeout = this.cbxStrikeout.Checked;
				this._NewFontStruct.ResetFont();
				return this._NewFontStruct;
			}
			set
			{
				this._NewFontStruct = value;
			}
		}

		public FormateForm()
		{
			base.Paint += new PaintEventHandler(this.FormateForm_Paint);
			this.BoolMouseDown = false;
			this.InitializeComponent();
			this.AddMovableHandler(this.Panel1);
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
			this.cbxSuperscript = new CheckBox();
			this.cbxSubscript = new CheckBox();
			this.cbxBold = new CheckBox();
			this.cbxItalic = new CheckBox();
			this.gbxFormate = new GroupBox();
			this.cbxStrikeout = new CheckBox();
			this.cbxUnderline = new CheckBox();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.Panel1 = new Panel();
			this.llCancel = new LinkLabel();
			this.llOK = new LinkLabel();
			this.gbxFormate.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.cbxSuperscript.BackColor = Color.FromArgb(239, 239, 239);
			this.cbxSuperscript.FlatStyle = FlatStyle.Flat;
			Control arg_DD_0 = this.cbxSuperscript;
			Point location = new Point(24, 32);
			arg_DD_0.Location = location;
			this.cbxSuperscript.Name = "cbxSuperscript";
			Control arg_104_0 = this.cbxSuperscript;
			Size size = new Size(56, 24);
			arg_104_0.Size = size;
			this.cbxSuperscript.TabIndex = 0;
			this.cbxSuperscript.Text = "上标";
			this.cbxSuperscript.UseVisualStyleBackColor = false;
			this.cbxSubscript.BackColor = Color.FromArgb(239, 239, 239);
			this.cbxSubscript.FlatStyle = FlatStyle.Flat;
			Control arg_16E_0 = this.cbxSubscript;
			location = new Point(24, 64);
			arg_16E_0.Location = location;
			this.cbxSubscript.Name = "cbxSubscript";
			Control arg_195_0 = this.cbxSubscript;
			size = new Size(56, 24);
			arg_195_0.Size = size;
			this.cbxSubscript.TabIndex = 1;
			this.cbxSubscript.Text = "下标";
			this.cbxSubscript.UseVisualStyleBackColor = false;
			this.cbxBold.FlatStyle = FlatStyle.Flat;
			Control arg_1E0_0 = this.cbxBold;
			location = new Point(88, 24);
			arg_1E0_0.Location = location;
			this.cbxBold.Name = "cbxBold";
			Control arg_207_0 = this.cbxBold;
			size = new Size(56, 24);
			arg_207_0.Size = size;
			this.cbxBold.TabIndex = 2;
			this.cbxBold.Text = "黑体";
			this.cbxItalic.BackColor = Color.FromArgb(239, 239, 239);
			this.cbxItalic.FlatStyle = FlatStyle.Flat;
			Control arg_265_0 = this.cbxItalic;
			location = new Point(96, 64);
			arg_265_0.Location = location;
			this.cbxItalic.Name = "cbxItalic";
			Control arg_28C_0 = this.cbxItalic;
			size = new Size(56, 24);
			arg_28C_0.Size = size;
			this.cbxItalic.TabIndex = 3;
			this.cbxItalic.Text = "斜体";
			this.cbxItalic.UseVisualStyleBackColor = false;
			this.gbxFormate.BackColor = Color.FromArgb(239, 239, 239);
			this.gbxFormate.Controls.Add(this.cbxStrikeout);
			this.gbxFormate.Controls.Add(this.cbxUnderline);
			this.gbxFormate.Controls.Add(this.cbxBold);
			Control arg_32A_0 = this.gbxFormate;
			location = new Point(8, 8);
			arg_32A_0.Location = location;
			this.gbxFormate.Name = "gbxFormate";
			Control arg_354_0 = this.gbxFormate;
			size = new Size(232, 88);
			arg_354_0.Size = size;
			this.gbxFormate.TabIndex = 4;
			this.gbxFormate.TabStop = false;
			this.gbxFormate.Text = "文字效果";
			this.cbxStrikeout.FlatStyle = FlatStyle.Flat;
			Control arg_3A2_0 = this.cbxStrikeout;
			location = new Point(160, 56);
			arg_3A2_0.Location = location;
			this.cbxStrikeout.Name = "cbxStrikeout";
			Control arg_3C9_0 = this.cbxStrikeout;
			size = new Size(64, 24);
			arg_3C9_0.Size = size;
			this.cbxStrikeout.TabIndex = 3;
			this.cbxStrikeout.Text = "删除线";
			this.cbxUnderline.FlatStyle = FlatStyle.Flat;
			Control arg_40B_0 = this.cbxUnderline;
			location = new Point(160, 24);
			arg_40B_0.Location = location;
			this.cbxUnderline.Name = "cbxUnderline";
			Control arg_432_0 = this.cbxUnderline;
			size = new Size(64, 24);
			arg_432_0.Size = size;
			this.cbxUnderline.TabIndex = 0;
			this.cbxUnderline.Text = "下划线";
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_499_0 = this.btnOK;
			location = new Point(0, 88);
			arg_499_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_4C0_0 = this.btnOK;
			size = new Size(66, 16);
			arg_4C0_0.Size = size;
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Visible = false;
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_54C_0 = this.btnCancel;
			location = new Point(80, 88);
			arg_54C_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_573_0 = this.btnCancel;
			size = new Size(66, 16);
			arg_573_0.Size = size;
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Visible = false;
			this.Panel1.BackColor = Color.FromArgb(239, 239, 239);
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.llCancel);
			this.Panel1.Controls.Add(this.llOK);
			this.Panel1.Controls.Add(this.btnCancel);
			this.Panel1.Controls.Add(this.btnOK);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_64B_0 = this.Panel1;
			location = new Point(0, 0);
			arg_64B_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_678_0 = this.Panel1;
			size = new Size(248, 136);
			arg_678_0.Size = size;
			this.Panel1.TabIndex = 7;
			this.llCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_6AB_0 = this.llCancel;
			location = new Point(192, 112);
			arg_6AB_0.Location = location;
			this.llCancel.Name = "llCancel";
			Control arg_6D2_0 = this.llCancel;
			size = new Size(48, 16);
			arg_6D2_0.Size = size;
			this.llCancel.TabIndex = 8;
			this.llCancel.TabStop = true;
			this.llCancel.Text = "取消(&C)";
			this.llOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_721_0 = this.llOK;
			location = new Point(128, 112);
			arg_721_0.Location = location;
			this.llOK.Name = "llOK";
			Control arg_748_0 = this.llOK;
			size = new Size(48, 16);
			arg_748_0.Size = size;
			this.llOK.TabIndex = 7;
			this.llOK.TabStop = true;
			this.llOK.Text = "确定(&O)";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(248, 136);
			this.ClientSize = size;
			this.Controls.Add(this.cbxItalic);
			this.Controls.Add(this.cbxSubscript);
			this.Controls.Add(this.cbxSuperscript);
			this.Controls.Add(this.gbxFormate);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "FormateForm";
			this.Text = "FormateForm";
			this.gbxFormate.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void FormateForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics arg_26_0 = e.Graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_26_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void cbxSuperscript_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbxSuperscript.Checked && this.cbxSubscript.Checked)
			{
				this.cbxSubscript.Checked = false;
			}
		}

		private void cbxSubscript_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbxSubscript.Checked && this.cbxSuperscript.Checked)
			{
				this.cbxSuperscript.Checked = false;
			}
		}

		private void llOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnCancel_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
