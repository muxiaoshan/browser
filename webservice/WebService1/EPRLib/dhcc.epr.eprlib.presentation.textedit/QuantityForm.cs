using dhcc.epr.eprlib.instancedata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class QuantityForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("PCQuantity")]
		private PCQuantity _PCQuantity;

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

		public virtual PCQuantity PCQuantity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCQuantity;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PCQuantity = value;
			}
		}

		public QuantityForm()
		{
			base.Paint += new PaintEventHandler(this.ChoiceForm_Paint);
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.MouseUp += new MouseEventHandler(this.Me_MouseUp);
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
			this.SuspendLayout();
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_7D_0 = this.btnCancel;
			Point location = new Point(184, 112);
			arg_7D_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_A4_0 = this.btnCancel;
			Size size = new Size(64, 24);
			arg_A4_0.Size = size;
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "取消(&C)";
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_10C_0 = this.btnOK;
			location = new Point(104, 112);
			arg_10C_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_133_0 = this.btnOK;
			size = new Size(64, 24);
			arg_133_0.Size = size;
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "确定(&O)";
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_17C_0 = this.Panel1;
			location = new Point(0, 0);
			arg_17C_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_1A9_0 = this.Panel1;
			size = new Size(280, 160);
			arg_1A9_0.Size = size;
			this.Panel1.TabIndex = 9;
			this.AcceptButton = this.btnOK;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.CancelButton = this.btnCancel;
			size = new Size(280, 160);
			this.ClientSize = size;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "QuantityForm";
			this.Text = "QuantityForm";
			this.ResumeLayout(false);
		}

		public QuantityForm(NISimple objNIQuantity) : this()
		{
			this.PCQuantity = new PCQuantity();
			this.PCQuantity.BindInstanceItem = objNIQuantity;
			this.PCQuantity.Top = 8;
			this.PCQuantity.Left = 8;
			this.Controls.Add(this.PCQuantity);
			checked
			{
				this.btnOK.Top = this.PCQuantity.Top + this.PCQuantity.Height + 4;
				this.btnCancel.Top = this.btnOK.Top;
				this.btnCancel.Left = this.PCQuantity.Left + this.PCQuantity.Width - this.btnCancel.Width;
				this.btnOK.Left = this.btnCancel.Left - 12 - this.btnCancel.Width;
				this.Width = this.PCQuantity.Left + this.PCQuantity.Width + 8;
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
	}
}
