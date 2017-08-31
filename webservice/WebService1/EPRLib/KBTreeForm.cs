using dhcc.epr.eprlib.design.printlink;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class KBTreeForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("pnlKBTree")]
	private Panel _pnlKBTree;

	[AccessedThroughProperty("gbxLine")]
	private GroupBox _gbxLine;

	[AccessedThroughProperty("btnOK")]
	private Button _btnOK;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("tvKBCategory")]
	private KBCategoryTree _tvKBCategory;

	private TreeNode _KBNode;

	internal virtual Panel pnlKBTree
	{
		[DebuggerNonUserCode]
		get
		{
			return this._pnlKBTree;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._pnlKBTree = value;
		}
	}

	internal virtual GroupBox gbxLine
	{
		[DebuggerNonUserCode]
		get
		{
			return this._gbxLine;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._gbxLine = value;
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
			this._btnOK = value;
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
			this._btnCancel = value;
		}
	}

	public virtual KBCategoryTree tvKBCategory
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tvKBCategory;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tvKBCategory = value;
		}
	}

	public TreeNode KBNode
	{
		get
		{
			return this.tvKBCategory.SelectedNode;
		}
		set
		{
			this._KBNode = value;
		}
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
		this.pnlKBTree = new Panel();
		this.gbxLine = new GroupBox();
		this.btnOK = new Button();
		this.btnCancel = new Button();
		this.SuspendLayout();
		Control arg_42_0 = this.pnlKBTree;
		Point location = new Point(4, 4);
		arg_42_0.Location = location;
		this.pnlKBTree.Name = "pnlKBTree";
		Control arg_6F_0 = this.pnlKBTree;
		Size size = new Size(264, 464);
		arg_6F_0.Size = size;
		this.pnlKBTree.TabIndex = 0;
		Control arg_94_0 = this.gbxLine;
		location = new Point(4, 472);
		arg_94_0.Location = location;
		this.gbxLine.Name = "gbxLine";
		Control arg_BD_0 = this.gbxLine;
		size = new Size(264, 4);
		arg_BD_0.Size = size;
		this.gbxLine.TabIndex = 1;
		this.gbxLine.TabStop = false;
		this.btnOK.DialogResult = DialogResult.OK;
		Control arg_FB_0 = this.btnOK;
		location = new Point(112, 479);
		arg_FB_0.Location = location;
		this.btnOK.Name = "btnOK";
		Control arg_122_0 = this.btnOK;
		size = new Size(75, 23);
		arg_122_0.Size = size;
		this.btnOK.TabIndex = 2;
		this.btnOK.Text = "确定";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnCancel.DialogResult = DialogResult.Cancel;
		Control arg_173_0 = this.btnCancel;
		location = new Point(193, 479);
		arg_173_0.Location = location;
		this.btnCancel.Name = "btnCancel";
		Control arg_19A_0 = this.btnCancel;
		size = new Size(75, 23);
		arg_19A_0.Size = size;
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "取消";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.AcceptButton = this.btnOK;
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		this.CancelButton = this.btnCancel;
		size = new Size(272, 506);
		this.ClientSize = size;
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.btnOK);
		this.Controls.Add(this.gbxLine);
		this.Controls.Add(this.pnlKBTree);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "KBTreeForm";
		this.Text = "知识库";
		this.ResumeLayout(false);
	}

	public KBTreeForm()
	{
		base.Load += new EventHandler(this.KBTreeForm_Load);
		this._KBNode = null;
		this.InitializeComponent();
	}

	public KBTreeForm(Point point)
	{
		base.Load += new EventHandler(this.KBTreeForm_Load);
		this._KBNode = null;
		this.InitializeComponent();
		this.StartPosition = FormStartPosition.Manual;
		this.Location = point;
	}

	private void KBTreeForm_Load(object sender, EventArgs e)
	{
		this.tvKBCategory = new KBCategoryTree();
		this.tvKBCategory.Dock = DockStyle.Fill;
		this.tvKBCategory.Name = "tvKBCategory";
		this.tvKBCategory.ShowRootLines = true;
		this.tvKBCategory.ShowLines = true;
		this.pnlKBTree.Controls.Add(this.tvKBCategory);
	}
}
