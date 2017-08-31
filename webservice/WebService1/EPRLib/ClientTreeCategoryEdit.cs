using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.kbdesign;
using KBTreeData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class ClientTreeCategoryEdit : Form
{
	private IContainer components;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("txtCategoryDesc")]
	private TextBox _txtCategoryDesc;

	[AccessedThroughProperty("lblCategoryDesc")]
	private Label _lblCategoryDesc;

	[AccessedThroughProperty("txtCategoryName")]
	private TextBox _txtCategoryName;

	[AccessedThroughProperty("lblCategoryName")]
	private Label _lblCategoryName;

	[AccessedThroughProperty("DCKBTreeCategory")]
	private DCKBTreeCategory _DCKBTreeCategory;

	private string _KBTreeID;

	private EKBTree _EKBTree;

	internal virtual Button btnSave
	{
		[DebuggerNonUserCode]
		get
		{
			return this._btnSave;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.btnSave_Click);
			if (this._btnSave != null)
			{
				this._btnSave.Click -= value2;
			}
			this._btnSave = value;
			if (this._btnSave != null)
			{
				this._btnSave.Click += value2;
			}
		}
	}

	internal virtual TextBox txtCategoryDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtCategoryDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtCategoryDesc = value;
		}
	}

	internal virtual Label lblCategoryDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblCategoryDesc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblCategoryDesc = value;
		}
	}

	internal virtual TextBox txtCategoryName
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtCategoryName;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtCategoryName = value;
		}
	}

	internal virtual Label lblCategoryName
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblCategoryName;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblCategoryName = value;
		}
	}

	private virtual DCKBTreeCategory DCKBTreeCategory
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DCKBTreeCategory;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._DCKBTreeCategory = value;
		}
	}

	public string KBTreeID
	{
		get
		{
			return this._KBTreeID;
		}
		set
		{
			this._KBTreeID = value;
		}
	}

	[DebuggerNonUserCode]
	public ClientTreeCategoryEdit()
	{
		base.Load += new EventHandler(this.ClientTreeCategoryEdit_Load);
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
		this.btnSave = new Button();
		this.txtCategoryDesc = new TextBox();
		this.lblCategoryDesc = new Label();
		this.txtCategoryName = new TextBox();
		this.lblCategoryName = new Label();
		this.SuspendLayout();
		Control arg_52_0 = this.btnSave;
		Point location = new Point(337, 10);
		arg_52_0.Location = location;
		this.btnSave.Name = "btnSave";
		Control arg_79_0 = this.btnSave;
		Size size = new Size(75, 23);
		arg_79_0.Size = size;
		this.btnSave.TabIndex = 29;
		this.btnSave.Text = "保存";
		Control arg_AD_0 = this.txtCategoryDesc;
		location = new Point(68, 44);
		arg_AD_0.Location = location;
		this.txtCategoryDesc.Multiline = true;
		this.txtCategoryDesc.Name = "txtCategoryDesc";
		Control arg_E3_0 = this.txtCategoryDesc;
		size = new Size(396, 40);
		arg_E3_0.Size = size;
		this.txtCategoryDesc.TabIndex = 28;
		Control arg_106_0 = this.lblCategoryDesc;
		location = new Point(4, 44);
		arg_106_0.Location = location;
		this.lblCategoryDesc.Name = "lblCategoryDesc";
		Control arg_12D_0 = this.lblCategoryDesc;
		size = new Size(64, 16);
		arg_12D_0.Size = size;
		this.lblCategoryDesc.TabIndex = 27;
		this.lblCategoryDesc.Text = "节点说明";
		Control arg_161_0 = this.txtCategoryName;
		location = new Point(68, 12);
		arg_161_0.Location = location;
		this.txtCategoryName.Name = "txtCategoryName";
		Control arg_18B_0 = this.txtCategoryName;
		size = new Size(241, 21);
		arg_18B_0.Size = size;
		this.txtCategoryName.TabIndex = 26;
		Control arg_1AE_0 = this.lblCategoryName;
		location = new Point(4, 12);
		arg_1AE_0.Location = location;
		this.lblCategoryName.Name = "lblCategoryName";
		Control arg_1D5_0 = this.lblCategoryName;
		size = new Size(64, 16);
		arg_1D5_0.Size = size;
		this.lblCategoryName.TabIndex = 25;
		this.lblCategoryName.Text = "目录名称";
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		size = new Size(476, 115);
		this.ClientSize = size;
		this.Controls.Add(this.btnSave);
		this.Controls.Add(this.txtCategoryDesc);
		this.Controls.Add(this.lblCategoryDesc);
		this.Controls.Add(this.txtCategoryName);
		this.Controls.Add(this.lblCategoryName);
		this.Name = "ClientTreeCategoryEdit";
		this.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "目录编辑";
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		this._EKBTree.Name = this.txtCategoryName.Text;
		this._EKBTree.Description = this.txtCategoryDesc.Text;
		KBTreeInfo arg_3D_0 = WebServiceLayer.KBTreeAccess;
		EKBTree arg_3D_1 = this._EKBTree;
		bool flag = true;
		bool flag2;
		arg_3D_0.UpdateKBTree(arg_3D_1, ref flag2, ref flag);
		KBTree.ConstKBTree.UpdateNodeName(this._EKBTree.Name);
		this.Close();
	}

	private void ClientTreeCategoryEdit_Load(object sender, EventArgs e)
	{
		this._EKBTree = WebServiceLayer.KBTreeAccess.SelectKBTreeBYID(this._KBTreeID);
		this.txtCategoryName.Text = this._EKBTree.Name;
		this.txtCategoryDesc.Text = this._EKBTree.Description;
	}
}
