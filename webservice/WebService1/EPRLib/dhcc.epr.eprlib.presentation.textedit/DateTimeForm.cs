using dhcc.epr.eprlib.instancedata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class DateTimeForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("llCancel")]
		private LinkLabel _llCancel;

		[AccessedThroughProperty("llOK")]
		private LinkLabel _llOK;

		[AccessedThroughProperty("PCDateTime")]
		private PCDateTime _PCDateTime;

		private bool BoolMouseDown;

		private Point ClickedPoint;

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

		public virtual PCDateTime PCDateTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCDateTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PCDateTime = value;
			}
		}

		public DateTimeForm()
		{
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			base.Paint += new PaintEventHandler(this.ChoiceForm_Paint);
			this.BoolMouseDown = false;
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
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.Panel1 = new Panel();
			this.llCancel = new LinkLabel();
			this.llOK = new LinkLabel();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_9B_0 = this.btnCancel;
			Point location = new Point(80, 64);
			arg_9B_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_C2_0 = this.btnCancel;
			Size size = new Size(64, 24);
			arg_C2_0.Size = size;
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.Visible = false;
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_136_0 = this.btnOK;
			location = new Point(8, 64);
			arg_136_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_15D_0 = this.btnOK;
			size = new Size(64, 24);
			arg_15D_0.Size = size;
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.Visible = false;
			this.Panel1.BackColor = Color.FromArgb(239, 239, 239);
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.llCancel);
			this.Panel1.Controls.Add(this.llOK);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_1FE_0 = this.Panel1;
			location = new Point(0, 0);
			arg_1FE_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_228_0 = this.Panel1;
			size = new Size(304, 96);
			arg_228_0.Size = size;
			this.Panel1.TabIndex = 11;
			this.llCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_25C_0 = this.llCancel;
			location = new Point(248, 72);
			arg_25C_0.Location = location;
			this.llCancel.Name = "llCancel";
			Control arg_283_0 = this.llCancel;
			size = new Size(48, 16);
			arg_283_0.Size = size;
			this.llCancel.TabIndex = 10;
			this.llCancel.TabStop = true;
			this.llCancel.Text = "取消(&C)";
			this.llOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_2D3_0 = this.llOK;
			location = new Point(184, 72);
			arg_2D3_0.Location = location;
			this.llOK.Name = "llOK";
			Control arg_2FA_0 = this.llOK;
			size = new Size(48, 16);
			arg_2FA_0.Size = size;
			this.llOK.TabIndex = 9;
			this.llOK.TabStop = true;
			this.llOK.Text = "确定(&O)";
			this.AcceptButton = this.btnOK;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.CancelButton = this.btnCancel;
			size = new Size(304, 96);
			this.ClientSize = size;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "DateTimeForm";
			this.Text = "DateTimeForm";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public DateTimeForm(NISimple objNIQuantity) : this()
		{
			this.PCDateTime = new PCDateTime();
			this.PCDateTime.BindInstanceItem = objNIQuantity;
			this.PCDateTime.Top = 4;
			this.PCDateTime.Left = 4;
			this.Controls.Add(this.PCDateTime);
			checked
			{
				this.btnOK.Top = this.PCDateTime.Top + this.PCDateTime.Height + 4;
				this.btnCancel.Top = this.btnOK.Top;
				this.btnCancel.Left = this.PCDateTime.Left + this.PCDateTime.Width - this.btnCancel.Width;
				this.btnOK.Left = this.btnCancel.Left - 12 - this.btnCancel.Width;
				this.Width = this.PCDateTime.Left + this.PCDateTime.Width + 8;
				this.Height = this.btnOK.Top + this.btnOK.Height + 8;
				this.Panel1.SendToBack();
			}
		}

		private void ChoiceForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics arg_28_0 = graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_28_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
			Point p = new Point(e.X, e.Y);
			this.ClickedPoint = this.PointToScreen(p);
			this.Cursor = Cursors.SizeAll;
			this.BoolMouseDown = true;
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.BoolMouseDown)
				{
					Point clickedPoint = default(Point);
					Point p = new Point(e.X, e.Y);
					clickedPoint = this.PointToScreen(p);
					this.Top += clickedPoint.Y - this.ClickedPoint.Y;
					this.Left += clickedPoint.X - this.ClickedPoint.X;
					this.ClickedPoint = clickedPoint;
				}
			}
		}

		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.BoolMouseDown = false;
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
