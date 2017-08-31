using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class MulitCopy : dhcc.epr.eprlib.presentation.MovableForm
	{
		private IContainer components;

		[AccessedThroughProperty("tsmiPast")]
		private ToolStripMenuItem _tsmiPast;

		[AccessedThroughProperty("tsmiDele")]
		private ToolStripMenuItem _tsmiDele;

		[AccessedThroughProperty("lbClipBoard")]
		private ListBox _lbClipBoard;

		[AccessedThroughProperty("btClear")]
		private Button _btClear;

		[AccessedThroughProperty("btCopyall")]
		private Button _btCopyall;

		[AccessedThroughProperty("cmsStrip")]
		private ContextMenuStrip _cmsStrip;

		private bool m_OpenFlag;

		private string m_CopyString;

		public static List<string> CopysList = new List<string>();

		internal virtual ToolStripMenuItem tsmiPast
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsmiPast;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tsmiPast_Click);
				if (this._tsmiPast != null)
				{
					this._tsmiPast.Click -= value2;
				}
				this._tsmiPast = value;
				if (this._tsmiPast != null)
				{
					this._tsmiPast.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem tsmiDele
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsmiDele;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tsmiDele_Click);
				if (this._tsmiDele != null)
				{
					this._tsmiDele.Click -= value2;
				}
				this._tsmiDele = value;
				if (this._tsmiDele != null)
				{
					this._tsmiDele.Click += value2;
				}
			}
		}

		internal virtual ListBox lbClipBoard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbClipBoard;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.lbClipBoard_MouseDown);
				if (this._lbClipBoard != null)
				{
					this._lbClipBoard.MouseDown -= value2;
				}
				this._lbClipBoard = value;
				if (this._lbClipBoard != null)
				{
					this._lbClipBoard.MouseDown += value2;
				}
			}
		}

		internal virtual Button btClear
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btClear;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btClear_Click);
				if (this._btClear != null)
				{
					this._btClear.Click -= value2;
				}
				this._btClear = value;
				if (this._btClear != null)
				{
					this._btClear.Click += value2;
				}
			}
		}

		internal virtual Button btCopyall
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btCopyall;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btCopyall_Click);
				if (this._btCopyall != null)
				{
					this._btCopyall.Click -= value2;
				}
				this._btCopyall = value;
				if (this._btCopyall != null)
				{
					this._btCopyall.Click += value2;
				}
			}
		}

		internal virtual ContextMenuStrip cmsStrip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmsStrip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmsStrip = value;
			}
		}

		public bool OpenFlag
		{
			get
			{
				return this.m_OpenFlag;
			}
			set
			{
				this.m_OpenFlag = value;
			}
		}

		public string CopyString
		{
			get
			{
				return this.m_CopyString;
			}
			set
			{
				this.m_CopyString = value;
				MulitCopy.CopysList.Insert(0, this.m_CopyString);
				this.lbClipBoard.Items.Insert(0, this.m_CopyString);
			}
		}

		public MulitCopy()
		{
			base.Load += new EventHandler(this.MulitCopy_Load);
			base.FormClosed += new FormClosedEventHandler(this.MulitCopy_FormClosed);
			this.m_OpenFlag = false;
			this.m_CopyString = string.Empty;
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
			this.cmsStrip = new ContextMenuStrip(this.components);
			this.tsmiPast = new ToolStripMenuItem();
			this.tsmiDele = new ToolStripMenuItem();
			this.lbClipBoard = new ListBox();
			this.btClear = new Button();
			this.btCopyall = new Button();
			this.cmsStrip.SuspendLayout();
			this.SuspendLayout();
			this.cmsStrip.Items.AddRange(new ToolStripItem[]
			{
				this.tsmiPast,
				this.tsmiDele
			});
			this.cmsStrip.Name = "cmsStrip";
			Control arg_B0_0 = this.cmsStrip;
			Size size = new Size(95, 48);
			arg_B0_0.Size = size;
			this.tsmiPast.Name = "tsmiPast";
			ToolStripItem arg_D7_0 = this.tsmiPast;
			size = new Size(94, 22);
			arg_D7_0.Size = size;
			this.tsmiPast.Text = "粘贴";
			this.tsmiDele.Name = "tsmiDele";
			ToolStripItem arg_10E_0 = this.tsmiDele;
			size = new Size(94, 22);
			arg_10E_0.Size = size;
			this.tsmiDele.Text = "删除";
			this.lbClipBoard.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lbClipBoard.ContextMenuStrip = this.cmsStrip;
			this.lbClipBoard.FormattingEnabled = true;
			this.lbClipBoard.ItemHeight = 12;
			Control arg_16B_0 = this.lbClipBoard;
			Point location = new Point(8, 44);
			arg_16B_0.Location = location;
			this.lbClipBoard.Name = "lbClipBoard";
			Control arg_198_0 = this.lbClipBoard;
			size = new Size(208, 340);
			arg_198_0.Size = size;
			this.lbClipBoard.TabIndex = 6;
			this.btClear.BackColor = Color.FromArgb(9, 101, 156);
			this.btClear.FlatStyle = FlatStyle.Flat;
			this.btClear.ForeColor = SystemColors.ControlLightLight;
			Control arg_1F3_0 = this.btClear;
			location = new Point(137, 9);
			arg_1F3_0.Location = location;
			this.btClear.Name = "btClear";
			Control arg_21A_0 = this.btClear;
			size = new Size(75, 25);
			arg_21A_0.Size = size;
			this.btClear.TabIndex = 8;
			this.btClear.Text = "清空";
			this.btClear.UseVisualStyleBackColor = false;
			this.btCopyall.BackColor = Color.FromArgb(9, 101, 156);
			this.btCopyall.FlatStyle = FlatStyle.Flat;
			this.btCopyall.ForeColor = SystemColors.ControlLightLight;
			Control arg_28E_0 = this.btCopyall;
			location = new Point(12, 9);
			arg_28E_0.Location = location;
			this.btCopyall.Name = "btCopyall";
			Control arg_2B5_0 = this.btCopyall;
			size = new Size(95, 25);
			arg_2B5_0.Size = size;
			this.btCopyall.TabIndex = 7;
			this.btCopyall.Text = "全部粘贴";
			this.btCopyall.UseVisualStyleBackColor = false;
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.InactiveCaptionText;
			size = new Size(224, 396);
			this.ClientSize = size;
			this.Controls.Add(this.lbClipBoard);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btCopyall);
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.Name = "MulitCopy";
			this.ShowInTaskbar = false;
			this.Text = "剪贴板";
			this.cmsStrip.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void MulitCopy_Load(object sender, EventArgs e)
		{
			this.m_OpenFlag = true;
			try
			{
				List<string>.Enumerator enumerator = MulitCopy.CopysList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					this.lbClipBoard.Items.Add(current);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		private void MulitCopy_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.m_OpenFlag = false;
			PCTextEdit.FmMulitCopy = null;
		}

		private void lbClipBoard_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point point = new Point(e.X, e.Y);
				int num = this.lbClipBoard.IndexFromPoint(point.X, point.Y);
				if (num != -1)
				{
					this.lbClipBoard.SelectedIndex = num;
					this.lbClipBoard.ContextMenuStrip = this.cmsStrip;
				}
				else
				{
					this.lbClipBoard.ContextMenuStrip = null;
				}
			}
			else
			{
				this.lbClipBoard.ContextMenuStrip = null;
			}
		}

		private void tsmiPast_Click(object sender, EventArgs e)
		{
			PCTextEdit.objPCTExitFrm.PastAct(this.lbClipBoard.SelectedItem.ToString());
		}

		private void tsmiDele_Click(object sender, EventArgs e)
		{
			MulitCopy.CopysList.RemoveAt(this.lbClipBoard.SelectedIndex);
			this.lbClipBoard.Items.RemoveAt(this.lbClipBoard.SelectedIndex);
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			MulitCopy.CopysList.Clear();
			this.lbClipBoard.Items.Clear();
		}

		private void btCopyall_Click(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = this.lbClipBoard.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string strClip = Conversions.ToString(enumerator.Current);
					PCTextEdit.objPCTExitFrm.PastAct(strClip);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}
}
