using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class PKBNode : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("btnEdit1")]
		private Button _btnEdit1;

		[AccessedThroughProperty("SegmentEdit3")]
		private RichTextBox _SegmentEdit3;

		[AccessedThroughProperty("lblSegment3")]
		private Label _lblSegment3;

		[AccessedThroughProperty("SegmentEdit2")]
		private RichTextBox _SegmentEdit2;

		[AccessedThroughProperty("lblSegment2")]
		private Label _lblSegment2;

		[AccessedThroughProperty("SegmentEdit1")]
		private RichTextBox _SegmentEdit1;

		[AccessedThroughProperty("lblSegment1")]
		private Label _lblSegment1;

		[AccessedThroughProperty("btnAdd1")]
		private Button _btnAdd1;

		[AccessedThroughProperty("btnReplace")]
		private Button _btnReplace;

		[AccessedThroughProperty("btnReplace2")]
		private Button _btnReplace2;

		[AccessedThroughProperty("btnAdd2")]
		private Button _btnAdd2;

		[AccessedThroughProperty("btnEdit2")]
		private Button _btnEdit2;

		[AccessedThroughProperty("btnReplace3")]
		private Button _btnReplace3;

		[AccessedThroughProperty("btnAdd3")]
		private Button _btnAdd3;

		[AccessedThroughProperty("btnEdit3")]
		private Button _btnEdit3;

		internal virtual Button btnEdit1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnEdit1 = value;
			}
		}

		internal virtual RichTextBox SegmentEdit3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit3 = value;
			}
		}

		internal virtual Label lblSegment3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment3 = value;
			}
		}

		internal virtual RichTextBox SegmentEdit2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit2 = value;
			}
		}

		internal virtual Label lblSegment2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment2 = value;
			}
		}

		internal virtual RichTextBox SegmentEdit1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit1 = value;
			}
		}

		internal virtual Label lblSegment1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment1 = value;
			}
		}

		internal virtual Button btnAdd1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd1 = value;
			}
		}

		internal virtual Button btnReplace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace = value;
			}
		}

		internal virtual Button btnReplace2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace2 = value;
			}
		}

		internal virtual Button btnAdd2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd2 = value;
			}
		}

		internal virtual Button btnEdit2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnEdit2 = value;
			}
		}

		internal virtual Button btnReplace3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace3 = value;
			}
		}

		internal virtual Button btnAdd3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd3 = value;
			}
		}

		internal virtual Button btnEdit3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnEdit3 = value;
			}
		}

		public PKBNode()
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
			this.btnEdit1 = new Button();
			this.SegmentEdit3 = new RichTextBox();
			this.lblSegment3 = new Label();
			this.SegmentEdit2 = new RichTextBox();
			this.lblSegment2 = new Label();
			this.SegmentEdit1 = new RichTextBox();
			this.lblSegment1 = new Label();
			this.btnAdd1 = new Button();
			this.btnReplace = new Button();
			this.btnReplace2 = new Button();
			this.btnAdd2 = new Button();
			this.btnEdit2 = new Button();
			this.btnReplace3 = new Button();
			this.btnAdd3 = new Button();
			this.btnEdit3 = new Button();
			this.SuspendLayout();
			Control arg_BF_0 = this.btnEdit1;
			Point location = new Point(280, 8);
			arg_BF_0.Location = location;
			this.btnEdit1.Name = "btnEdit1";
			Control arg_E6_0 = this.btnEdit1;
			Size size = new Size(56, 23);
			arg_E6_0.Size = size;
			this.btnEdit1.TabIndex = 21;
			this.btnEdit1.Text = "编辑(&E)";
			Control arg_11D_0 = this.SegmentEdit3;
			location = new Point(24, 320);
			arg_11D_0.Location = location;
			this.SegmentEdit3.Name = "SegmentEdit3";
			Control arg_147_0 = this.SegmentEdit3;
			size = new Size(440, 96);
			arg_147_0.Size = size;
			this.SegmentEdit3.TabIndex = 20;
			this.SegmentEdit3.Text = "";
			Control arg_17E_0 = this.lblSegment3;
			location = new Point(24, 288);
			arg_17E_0.Location = location;
			this.lblSegment3.Name = "lblSegment3";
			this.lblSegment3.TabIndex = 19;
			Control arg_1B5_0 = this.SegmentEdit2;
			location = new Point(24, 184);
			arg_1B5_0.Location = location;
			this.SegmentEdit2.Name = "SegmentEdit2";
			Control arg_1DF_0 = this.SegmentEdit2;
			size = new Size(440, 96);
			arg_1DF_0.Size = size;
			this.SegmentEdit2.TabIndex = 18;
			this.SegmentEdit2.Text = "";
			Control arg_216_0 = this.lblSegment2;
			location = new Point(24, 160);
			arg_216_0.Location = location;
			this.lblSegment2.Name = "lblSegment2";
			this.lblSegment2.TabIndex = 17;
			Control arg_24A_0 = this.SegmentEdit1;
			location = new Point(24, 48);
			arg_24A_0.Location = location;
			this.SegmentEdit1.Name = "SegmentEdit1";
			Control arg_274_0 = this.SegmentEdit1;
			size = new Size(440, 96);
			arg_274_0.Size = size;
			this.SegmentEdit1.TabIndex = 16;
			this.SegmentEdit1.Text = "";
			Control arg_2A7_0 = this.lblSegment1;
			location = new Point(24, 8);
			arg_2A7_0.Location = location;
			this.lblSegment1.Name = "lblSegment1";
			this.lblSegment1.TabIndex = 15;
			Control arg_2DD_0 = this.btnAdd1;
			location = new Point(136, 8);
			arg_2DD_0.Location = location;
			this.btnAdd1.Name = "btnAdd1";
			Control arg_304_0 = this.btnAdd1;
			size = new Size(56, 23);
			arg_304_0.Size = size;
			this.btnAdd1.TabIndex = 24;
			this.btnAdd1.Text = "添加(&A)";
			Control arg_33A_0 = this.btnReplace;
			location = new Point(208, 8);
			arg_33A_0.Location = location;
			this.btnReplace.Name = "btnReplace";
			Control arg_361_0 = this.btnReplace;
			size = new Size(56, 23);
			arg_361_0.Size = size;
			this.btnReplace.TabIndex = 25;
			this.btnReplace.Text = "替换(&R)";
			Control arg_39B_0 = this.btnReplace2;
			location = new Point(208, 152);
			arg_39B_0.Location = location;
			this.btnReplace2.Name = "btnReplace2";
			Control arg_3C2_0 = this.btnReplace2;
			size = new Size(56, 23);
			arg_3C2_0.Size = size;
			this.btnReplace2.TabIndex = 28;
			this.btnReplace2.Text = "替换(&R)";
			Control arg_3FC_0 = this.btnAdd2;
			location = new Point(136, 152);
			arg_3FC_0.Location = location;
			this.btnAdd2.Name = "btnAdd2";
			Control arg_423_0 = this.btnAdd2;
			size = new Size(56, 23);
			arg_423_0.Size = size;
			this.btnAdd2.TabIndex = 27;
			this.btnAdd2.Text = "添加(&A)";
			Control arg_45D_0 = this.btnEdit2;
			location = new Point(280, 152);
			arg_45D_0.Location = location;
			this.btnEdit2.Name = "btnEdit2";
			Control arg_484_0 = this.btnEdit2;
			size = new Size(56, 23);
			arg_484_0.Size = size;
			this.btnEdit2.TabIndex = 26;
			this.btnEdit2.Text = "编辑(&E)";
			Control arg_4BE_0 = this.btnReplace3;
			location = new Point(208, 288);
			arg_4BE_0.Location = location;
			this.btnReplace3.Name = "btnReplace3";
			Control arg_4E5_0 = this.btnReplace3;
			size = new Size(56, 23);
			arg_4E5_0.Size = size;
			this.btnReplace3.TabIndex = 31;
			this.btnReplace3.Text = "替换(&R)";
			Control arg_51F_0 = this.btnAdd3;
			location = new Point(136, 288);
			arg_51F_0.Location = location;
			this.btnAdd3.Name = "btnAdd3";
			Control arg_546_0 = this.btnAdd3;
			size = new Size(56, 23);
			arg_546_0.Size = size;
			this.btnAdd3.TabIndex = 30;
			this.btnAdd3.Text = "添加(&A)";
			Control arg_580_0 = this.btnEdit3;
			location = new Point(280, 288);
			arg_580_0.Location = location;
			this.btnEdit3.Name = "btnEdit3";
			Control arg_5A7_0 = this.btnEdit3;
			size = new Size(56, 23);
			arg_5A7_0.Size = size;
			this.btnEdit3.TabIndex = 29;
			this.btnEdit3.Text = "编辑(&E)";
			this.Controls.Add(this.btnReplace3);
			this.Controls.Add(this.btnAdd3);
			this.Controls.Add(this.btnEdit3);
			this.Controls.Add(this.btnReplace2);
			this.Controls.Add(this.btnAdd2);
			this.Controls.Add(this.btnEdit2);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.btnAdd1);
			this.Controls.Add(this.btnEdit1);
			this.Controls.Add(this.SegmentEdit3);
			this.Controls.Add(this.lblSegment3);
			this.Controls.Add(this.SegmentEdit2);
			this.Controls.Add(this.lblSegment2);
			this.Controls.Add(this.SegmentEdit1);
			this.Controls.Add(this.lblSegment1);
			this.Name = "PKBNode";
			size = new Size(496, 440);
			this.Size = size;
			this.ResumeLayout(false);
		}
	}
}
