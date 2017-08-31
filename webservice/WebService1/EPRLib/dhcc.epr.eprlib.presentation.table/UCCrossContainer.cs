using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.table
{
	public class UCCrossContainer : UserControl
	{
		public delegate void GetTextChangeEventHandler();

		private IContainer components;

		[AccessedThroughProperty("tbLB")]
		private TextBox _tbLB;

		[AccessedThroughProperty("tbRT")]
		private TextBox _tbRT;

		[AccessedThroughProperty("tbRB")]
		private TextBox _tbRB;

		[AccessedThroughProperty("tbLT")]
		private TextBox _tbLT;

		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		private UCCrossContainer.GetTextChangeEventHandler OnTextChangeEvent;

		public event UCCrossContainer.GetTextChangeEventHandler OnTextChange
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnTextChangeEvent = (UCCrossContainer.GetTextChangeEventHandler)Delegate.Combine(this.OnTextChangeEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnTextChangeEvent = (UCCrossContainer.GetTextChangeEventHandler)Delegate.Remove(this.OnTextChangeEvent, value);
			}
		}

		internal virtual TextBox tbLB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbLB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbLB = value;
			}
		}

		internal virtual TextBox tbRT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbRT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbRT = value;
			}
		}

		internal virtual TextBox tbRB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbRB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbRB = value;
			}
		}

		internal virtual TextBox tbLT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbLT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbLT = value;
			}
		}

		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		public string LTContent
		{
			get
			{
				return this.tbLT.Text;
			}
			set
			{
				this.tbLT.Text = value;
			}
		}

		public string RTContent
		{
			get
			{
				return this.tbRT.Text;
			}
			set
			{
				this.tbRT.Text = value;
			}
		}

		public string LBContent
		{
			get
			{
				return this.tbLB.Text;
			}
			set
			{
				this.tbLB.Text = value;
			}
		}

		public string RBContent
		{
			get
			{
				return this.tbRB.Text;
			}
			set
			{
				this.tbRB.Text = value;
			}
		}

		public UCCrossContainer()
		{
			this.InitializeComponent();
			this.init();
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
			this.tbLB = new TextBox();
			this.tbRT = new TextBox();
			this.tbRB = new TextBox();
			this.tbLT = new TextBox();
			this.TableLayoutPanel1 = new TableLayoutPanel();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.tbLB.BorderStyle = BorderStyle.None;
			this.tbLB.Dock = DockStyle.Fill;
			Control arg_71_0 = this.tbLB;
			Point location = new Point(3, 30);
			arg_71_0.Location = location;
			Control arg_85_0 = this.tbLB;
			Padding margin = new Padding(0);
			arg_85_0.Margin = margin;
			this.tbLB.Multiline = true;
			this.tbLB.Name = "tbLB";
			this.tbLB.ScrollBars = ScrollBars.Horizontal;
			Control arg_C4_0 = this.tbLB;
			Size size = new Size(81, 25);
			arg_C4_0.Size = size;
			this.tbLB.TabIndex = 3;
			this.tbLB.TextAlign = HorizontalAlignment.Right;
			this.tbRT.BorderStyle = BorderStyle.None;
			this.tbRT.Dock = DockStyle.Fill;
			Control arg_10A_0 = this.tbRT;
			location = new Point(87, 3);
			arg_10A_0.Location = location;
			Control arg_11E_0 = this.tbRT;
			margin = new Padding(0);
			arg_11E_0.Margin = margin;
			this.tbRT.Multiline = true;
			this.tbRT.Name = "tbRT";
			this.tbRT.ScrollBars = ScrollBars.Horizontal;
			Control arg_15D_0 = this.tbRT;
			size = new Size(81, 24);
			arg_15D_0.Size = size;
			this.tbRT.TabIndex = 2;
			this.tbRB.BorderStyle = BorderStyle.None;
			this.tbRB.Dock = DockStyle.Fill;
			Control arg_198_0 = this.tbRB;
			location = new Point(87, 30);
			arg_198_0.Location = location;
			Control arg_1AC_0 = this.tbRB;
			margin = new Padding(0);
			arg_1AC_0.Margin = margin;
			this.tbRB.Multiline = true;
			this.tbRB.Name = "tbRB";
			this.tbRB.ScrollBars = ScrollBars.Horizontal;
			Control arg_1EB_0 = this.tbRB;
			size = new Size(81, 25);
			arg_1EB_0.Size = size;
			this.tbRB.TabIndex = 4;
			this.tbLT.BorderStyle = BorderStyle.None;
			this.tbLT.Dock = DockStyle.Fill;
			Control arg_224_0 = this.tbLT;
			location = new Point(3, 3);
			arg_224_0.Location = location;
			Control arg_238_0 = this.tbLT;
			margin = new Padding(0);
			arg_238_0.Margin = margin;
			this.tbLT.Multiline = true;
			this.tbLT.Name = "tbLT";
			this.tbLT.ScrollBars = ScrollBars.Horizontal;
			Control arg_277_0 = this.tbLT;
			size = new Size(81, 24);
			arg_277_0.Size = size;
			this.tbLT.TabIndex = 1;
			this.tbLT.TextAlign = HorizontalAlignment.Right;
			this.TableLayoutPanel1.BackColor = Color.White;
			this.TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.tbLT, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.tbRB, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.tbRT, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.tbLB, 0, 1);
			this.TableLayoutPanel1.Dock = DockStyle.Fill;
			Control arg_370_0 = this.TableLayoutPanel1;
			location = new Point(0, 0);
			arg_370_0.Location = location;
			Control arg_384_0 = this.TableLayoutPanel1;
			margin = new Padding(0);
			arg_384_0.Margin = margin;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			Control arg_3F2_0 = this.TableLayoutPanel1;
			size = new Size(171, 58);
			arg_3F2_0.Size = size;
			this.TableLayoutPanel1.TabIndex = 5;
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.Controls.Add(this.TableLayoutPanel1);
			margin = new Padding(0);
			this.Margin = margin;
			this.Name = "UCCrossContainer";
			size = new Size(171, 58);
			this.Size = size;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}

		private void init()
		{
			this.tbLT.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.GetTextChange();
			};
			this.tbRT.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.GetTextChange();
			};
			this.tbLB.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.GetTextChange();
			};
			this.tbRB.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.GetTextChange();
			};
		}

		private void GetTextChange()
		{
			UCCrossContainer.GetTextChangeEventHandler onTextChangeEvent = this.OnTextChangeEvent;
			if (onTextChangeEvent != null)
			{
				onTextChangeEvent();
			}
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__5(object a0, EventArgs a1)
		{
			this.GetTextChange();
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__6(object a0, EventArgs a1)
		{
			this.GetTextChange();
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__7(object a0, EventArgs a1)
		{
			this.GetTextChange();
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__8(object a0, EventArgs a1)
		{
			this.GetTextChange();
		}
	}
}
