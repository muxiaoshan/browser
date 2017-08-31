using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class MonoChoiceForm : dhcc.epr.eprlib.presentation.MovableForm
	{
		private IContainer components;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("lbxChoice")]
		private ListBox _lbxChoice;

		[AccessedThroughProperty("btnClear")]
		private Button _btnClear;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("llOK")]
		private LinkLabel _llOK;

		[AccessedThroughProperty("llClear")]
		private LinkLabel _llClear;

		[AccessedThroughProperty("llCancel")]
		private LinkLabel _llCancel;

		private MIMonoChoice curMIMonoChoice;

		private string _oldValue;

		private string _oldValueCode;

		private bool BoolMouseDown;

		private Point ClickedPoint;

		private string _ChangedValue;

		private string _ChangedValueCode;

		private const int WM_KEYDOWN = 256;

		private const int WM_SYSKEYDOWN = 260;

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

		internal virtual ListBox lbxChoice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbxChoice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lbxChoice_DoubleClick);
				if (this._lbxChoice != null)
				{
					this._lbxChoice.DoubleClick -= value2;
				}
				this._lbxChoice = value;
				if (this._lbxChoice != null)
				{
					this._lbxChoice.DoubleClick += value2;
				}
			}
		}

		internal virtual Button btnClear
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnClear;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnClear_Click);
				if (this._btnClear != null)
				{
					this._btnClear.Click -= value2;
				}
				this._btnClear = value;
				if (this._btnClear != null)
				{
					this._btnClear.Click += value2;
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

		internal virtual LinkLabel llClear
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llClear;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
				if (this._llClear != null)
				{
					this._llClear.LinkClicked -= value2;
				}
				this._llClear = value;
				if (this._llClear != null)
				{
					this._llClear.LinkClicked += value2;
				}
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

		public string ChangedValue
		{
			get
			{
				return this._ChangedValue;
			}
			set
			{
				this._ChangedValue = value;
			}
		}

		public string ChangedCode
		{
			get
			{
				return this._ChangedValueCode;
			}
			set
			{
				this._ChangedValueCode = value;
			}
		}

		public MonoChoiceForm()
		{
			base.Paint += new PaintEventHandler(this.ChoiceForm_Paint);
			base.Load += new EventHandler(this.MonoChoiceForm_Load);
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
			this.lbxChoice = new ListBox();
			this.btnClear = new Button();
			this.Panel1 = new Panel();
			this.llCancel = new LinkLabel();
			this.llClear = new LinkLabel();
			this.llOK = new LinkLabel();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_C2_0 = this.btnCancel;
			Point location = new Point(184, 184);
			arg_C2_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_E9_0 = this.btnCancel;
			Size size = new Size(64, 24);
			arg_E9_0.Size = size;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Visible = false;
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_16C_0 = this.btnOK;
			location = new Point(120, 184);
			arg_16C_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_193_0 = this.btnOK;
			size = new Size(64, 32);
			arg_193_0.Size = size;
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Visible = false;
			this.lbxChoice.BackColor = Color.FromArgb(239, 239, 239);
			this.lbxChoice.BorderStyle = BorderStyle.None;
			this.lbxChoice.HorizontalScrollbar = true;
			this.lbxChoice.ItemHeight = 12;
			Control arg_220_0 = this.lbxChoice;
			location = new Point(4, 4);
			arg_220_0.Location = location;
			this.lbxChoice.Name = "lbxChoice";
			Control arg_24D_0 = this.lbxChoice;
			size = new Size(248, 216);
			arg_24D_0.Size = size;
			this.lbxChoice.TabIndex = 3;
			this.btnClear.BackColor = Color.FromArgb(49, 101, 156);
			this.btnClear.FlatStyle = FlatStyle.Flat;
			this.btnClear.ForeColor = Color.White;
			Control arg_2A7_0 = this.btnClear;
			location = new Point(8, 176);
			arg_2A7_0.Location = location;
			this.btnClear.Name = "btnClear";
			Control arg_2CE_0 = this.btnClear;
			size = new Size(64, 32);
			arg_2CE_0.Size = size;
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "清空(&L)";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Visible = false;
			this.Panel1.BackColor = Color.FromArgb(239, 239, 239);
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.llCancel);
			this.Panel1.Controls.Add(this.llClear);
			this.Panel1.Controls.Add(this.llOK);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_390_0 = this.Panel1;
			location = new Point(0, 0);
			arg_390_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_3BD_0 = this.Panel1;
			size = new Size(256, 256);
			arg_3BD_0.Size = size;
			this.Panel1.TabIndex = 7;
			this.llCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_3F3_0 = this.llCancel;
			location = new Point(200, 232);
			arg_3F3_0.Location = location;
			this.llCancel.Name = "llCancel";
			Control arg_41A_0 = this.llCancel;
			size = new Size(48, 16);
			arg_41A_0.Size = size;
			this.llCancel.TabIndex = 4;
			this.llCancel.TabStop = true;
			this.llCancel.Text = "取消(&C)";
			this.llClear.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_468_0 = this.llClear;
			location = new Point(8, 232);
			arg_468_0.Location = location;
			this.llClear.Name = "llClear";
			Control arg_48F_0 = this.llClear;
			size = new Size(48, 16);
			arg_48F_0.Size = size;
			this.llClear.TabIndex = 3;
			this.llClear.TabStop = true;
			this.llClear.Text = "清空(&L)";
			this.llOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_4E1_0 = this.llOK;
			location = new Point(144, 232);
			arg_4E1_0.Location = location;
			this.llOK.Name = "llOK";
			Control arg_508_0 = this.llOK;
			size = new Size(48, 16);
			arg_508_0.Size = size;
			this.llOK.TabIndex = 2;
			this.llOK.TabStop = true;
			this.llOK.Text = "确定(&O)";
			this.AcceptButton = this.btnOK;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.CancelButton = this.btnCancel;
			size = new Size(256, 256);
			this.ClientSize = size;
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lbxChoice);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MonoChoiceForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "MonoChoiceForm";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public MonoChoiceForm(MIMonoChoice objMIMonoChoice, string strValue, string strValueCode) : this()
		{
			this._oldValue = strValue;
			this._oldValueCode = strValueCode;
			this.curMIMonoChoice = objMIMonoChoice;
			int num = 0;
			int num2 = -1;
			StringEnumerator enumerator = objMIMonoChoice.Choices.GetEnumerator();
			checked
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					ChoiceItem choiceItem = new ChoiceItem();
					if (current.IndexOf("|") > -1)
					{
						choiceItem.ChoiceValue = current.Split(new char[]
						{
							'|'
						})[0];
						choiceItem.ChoiceCode = current.Split(new char[]
						{
							'|'
						})[1];
					}
					else
					{
						choiceItem.ChoiceValue = current;
						choiceItem.ChoiceCode = num.ToString();
					}
					this.lbxChoice.Items.Add(choiceItem);
					if (!(strValueCode == null | Operators.CompareString(strValueCode, "", false) == 0) && Operators.CompareString(strValueCode, choiceItem.ChoiceCode, false) == 0)
					{
						num2 = num;
					}
					num++;
				}
				if (num2 > -1)
				{
					this.lbxChoice.SelectedIndex = num2;
				}
				else if (this.lbxChoice.Items.Count > 0)
				{
					this.lbxChoice.SelectedIndex = 0;
				}
			}
		}

		private void ChangeChoiceText()
		{
			ChoiceItem choiceItem = (ChoiceItem)this.lbxChoice.SelectedItem;
			if (choiceItem != null)
			{
				this._ChangedValue = choiceItem.ChoiceValue;
				this._ChangedValueCode = choiceItem.ChoiceCode;
			}
		}

		private void lbxChoice_DoubleClick(object sender, EventArgs e)
		{
			this.ChangeChoiceText();
			this.DialogResult = DialogResult.OK;
		}

		private void ChoiceForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics arg_28_0 = graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_28_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.Msg == 256 | msg.Msg == 260)
			{
				if (keyData == Keys.Escape)
				{
					this.DialogResult = DialogResult.Cancel;
					return true;
				}
				if (keyData == Keys.Return)
				{
					this.ChangeChoiceText();
					this.DialogResult = DialogResult.OK;
					return true;
				}
				if (keyData == Keys.Tab)
				{
					if (this.lbxChoice.Items.Count > 0 & this.lbxChoice.SelectedIndex == checked(this.lbxChoice.Items.Count - 1))
					{
						this.lbxChoice.SelectedIndex = 0;
					}
					else
					{
						SendKeys.Send("{Down}");
					}
					this.ChangeChoiceText();
					return true;
				}
				if (keyData == (Keys)262223)
				{
					this.btnOK_Click(null, null);
					return true;
				}
				if (keyData == (Keys)262211)
				{
					this.btnCancel_Click(null, null);
					return true;
				}
				if (keyData == (Keys)262220)
				{
					this.btnClear_Click(null, null);
					return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.ChangeChoiceText();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this._ChangedValue = "";
			this._ChangedValueCode = "";
			this.DialogResult = DialogResult.OK;
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

		private void AdjustFormWidth()
		{
			Graphics graphics = this.lbxChoice.CreateGraphics();
			int num = 0;
			int arg_23_0 = 0;
			checked
			{
				int num2 = this.lbxChoice.Items.Count - 1;
				for (int i = arg_23_0; i <= num2; i++)
				{
					int num3 = (int)Math.Round((double)graphics.MeasureString(this.lbxChoice.Items[i].ToString(), this.lbxChoice.Font).Width);
					if (num3 > num)
					{
						num = num3;
					}
				}
				int width = Screen.PrimaryScreen.Bounds.Width;
				Point point = this.lbxChoice.PointToScreen(this.lbxChoice.Location);
				int num4 = num + 38;
				if (num4 > 192)
				{
					if (point.X + num4 <= width - 4)
					{
						this.lbxChoice.Width = num4;
					}
					else
					{
						this.lbxChoice.Width = width - 4 - point.X;
					}
				}
				int num5 = this.lbxChoice.Left + this.lbxChoice.Width + 4;
				if (num5 > 200)
				{
					this.Width = num5;
				}
			}
		}

		private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnClear_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnCancel_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void MonoChoiceForm_Load(object sender, EventArgs e)
		{
			this.AdjustFormWidth();
		}
	}
}
