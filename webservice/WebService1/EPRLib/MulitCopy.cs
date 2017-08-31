using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
internal class MulitCopy : Form
{
	private IContainer components;

	[AccessedThroughProperty("btCopyall")]
	private Button _btCopyall;

	[AccessedThroughProperty("btClear")]
	private Button _btClear;

	[AccessedThroughProperty("lbClipBoard")]
	private ListBox _lbClipBoard;

	[AccessedThroughProperty("cmsStrip")]
	private ContextMenuStrip _cmsStrip;

	[AccessedThroughProperty("tsmiPast")]
	private ToolStripMenuItem _tsmiPast;

	[AccessedThroughProperty("tsmiDele")]
	private ToolStripMenuItem _tsmiDele;

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
			this._btCopyall = value;
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
			this._btClear = value;
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
			this._lbClipBoard = value;
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
			this._tsmiPast = value;
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
			this._tsmiDele = value;
		}
	}

	[DebuggerNonUserCode]
	public MulitCopy()
	{
		this.InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new Container();
		this.btCopyall = new Button();
		this.btClear = new Button();
		this.lbClipBoard = new ListBox();
		this.cmsStrip = new ContextMenuStrip(this.components);
		this.tsmiPast = new ToolStripMenuItem();
		this.tsmiDele = new ToolStripMenuItem();
		this.cmsStrip.SuspendLayout();
		this.SuspendLayout();
		Control arg_76_0 = this.btCopyall;
		Point location = new Point(12, 12);
		arg_76_0.Location = location;
		this.btCopyall.Name = "btCopyall";
		Control arg_9D_0 = this.btCopyall;
		Size size = new Size(95, 23);
		arg_9D_0.Size = size;
		this.btCopyall.TabIndex = 0;
		this.btCopyall.Text = "全部粘贴";
		this.btCopyall.UseVisualStyleBackColor = true;
		Control arg_DF_0 = this.btClear;
		location = new Point(137, 12);
		arg_DF_0.Location = location;
		this.btClear.Name = "btClear";
		Control arg_106_0 = this.btClear;
		size = new Size(75, 23);
		arg_106_0.Size = size;
		this.btClear.TabIndex = 1;
		this.btClear.Text = "清空";
		this.btClear.UseVisualStyleBackColor = true;
		this.lbClipBoard.ContextMenuStrip = this.cmsStrip;
		this.lbClipBoard.FormattingEnabled = true;
		this.lbClipBoard.ItemHeight = 12;
		Control arg_16F_0 = this.lbClipBoard;
		location = new Point(12, 41);
		arg_16F_0.Location = location;
		this.lbClipBoard.Name = "lbClipBoard";
		Control arg_19C_0 = this.lbClipBoard;
		size = new Size(200, 340);
		arg_19C_0.Size = size;
		this.lbClipBoard.TabIndex = 2;
		this.cmsStrip.Items.AddRange(new ToolStripItem[]
		{
			this.tsmiPast,
			this.tsmiDele
		});
		this.cmsStrip.Name = "cmsStrip";
		Control arg_1F9_0 = this.cmsStrip;
		size = new Size(95, 48);
		arg_1F9_0.Size = size;
		this.tsmiPast.Name = "tsmiPast";
		ToolStripItem arg_220_0 = this.tsmiPast;
		size = new Size(94, 22);
		arg_220_0.Size = size;
		this.tsmiPast.Text = "粘贴";
		this.tsmiDele.Name = "tsmiDele";
		ToolStripItem arg_257_0 = this.tsmiDele;
		size = new Size(94, 22);
		arg_257_0.Size = size;
		this.tsmiDele.Text = "删除";
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		size = new Size(224, 396);
		this.ClientSize = size;
		this.Controls.Add(this.lbClipBoard);
		this.Controls.Add(this.btClear);
		this.Controls.Add(this.btCopyall);
		this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		this.Name = "MulitCopy";
		this.Text = "剪贴板";
		this.cmsStrip.ResumeLayout(false);
		this.ResumeLayout(false);
	}
}
