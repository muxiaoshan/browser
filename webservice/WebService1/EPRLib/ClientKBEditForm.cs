using dhcc.epr.eprlib.design.kbdesign;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ClientKBEditForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("DCKBNode")]
	private DCKBNode _DCKBNode;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	internal virtual DCKBNode DCKBNode
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DCKBNode;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._DCKBNode = value;
		}
	}

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return this._btnExit;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.btnExit_Click);
			if (this._btnExit != null)
			{
				this._btnExit.Click -= value2;
			}
			this._btnExit = value;
			if (this._btnExit != null)
			{
				this._btnExit.Click += value2;
			}
		}
	}

	public ClientKBEditForm()
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
		this.DCKBNode = new DCKBNode();
		this.btnExit = new Button();
		this.SuspendLayout();
		this.DCKBNode.ClientMode = false;
		this.DCKBNode.Editable = true;
		Control arg_44_0 = this.DCKBNode;
		Point location = new Point(0, 0);
		arg_44_0.Location = location;
		this.DCKBNode.Name = "DCKBNode";
		this.DCKBNode.Reviced = false;
		Control arg_7D_0 = this.DCKBNode;
		Size size = new Size(480, 498);
		arg_7D_0.Size = size;
		this.DCKBNode.TabIndex = 0;
		this.btnExit.DialogResult = DialogResult.Cancel;
		Control arg_B2_0 = this.btnExit;
		location = new Point(388, 500);
		arg_B2_0.Location = location;
		this.btnExit.Name = "btnExit";
		Control arg_D9_0 = this.btnExit;
		size = new Size(84, 24);
		arg_D9_0.Size = size;
		this.btnExit.TabIndex = 1;
		this.btnExit.Text = "退出(ESC)";
		size = new Size(6, 14);
		this.AutoScaleBaseSize = size;
		this.CancelButton = this.btnExit;
		size = new Size(480, 528);
		this.ClientSize = size;
		this.Controls.Add(this.btnExit);
		this.Controls.Add(this.DCKBNode);
		this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		this.Name = "ClientKBEditForm";
		this.StartPosition = FormStartPosition.CenterParent;
		this.Text = "编辑知识库";
		this.ResumeLayout(false);
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		this.Close();
	}
}
