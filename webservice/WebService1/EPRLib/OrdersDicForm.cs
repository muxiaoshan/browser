using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
internal class OrdersDicForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("tpCQYZ")]
	private TabPage _tpCQYZ;

	[AccessedThroughProperty("tpLSYZ")]
	private TabPage _tpLSYZ;

	[AccessedThroughProperty("tcOrders")]
	private TabControl _tcOrders;

	[AccessedThroughProperty("tpLongorder")]
	private TabPage _tpLongorder;

	[AccessedThroughProperty("tptemporder")]
	private TabPage _tptemporder;

	[AccessedThroughProperty("dgBOLISData")]
	private DataGridView _dgBOLISData;

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TabControl1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TabControl1 = value;
		}
	}

	internal virtual TabPage tpCQYZ
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tpCQYZ;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tpCQYZ = value;
		}
	}

	internal virtual TabPage tpLSYZ
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tpLSYZ;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tpLSYZ = value;
		}
	}

	internal virtual TabControl tcOrders
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tcOrders;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tcOrders = value;
		}
	}

	internal virtual TabPage tpLongorder
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tpLongorder;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tpLongorder = value;
		}
	}

	internal virtual TabPage tptemporder
	{
		[DebuggerNonUserCode]
		get
		{
			return this._tptemporder;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._tptemporder = value;
		}
	}

	internal virtual DataGridView dgBOLISData
	{
		[DebuggerNonUserCode]
		get
		{
			return this._dgBOLISData;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._dgBOLISData = value;
		}
	}

	[DebuggerNonUserCode]
	public OrdersDicForm()
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
		this.TabControl1 = new TabControl();
		this.tpCQYZ = new TabPage();
		this.tpLSYZ = new TabPage();
		this.tcOrders = new TabControl();
		this.tpLongorder = new TabPage();
		this.tptemporder = new TabPage();
		this.dgBOLISData = new DataGridView();
		this.TabControl1.SuspendLayout();
		this.tpCQYZ.SuspendLayout();
		this.tpLSYZ.SuspendLayout();
		this.tcOrders.SuspendLayout();
		((ISupportInitialize)this.dgBOLISData).BeginInit();
		this.SuspendLayout();
		this.TabControl1.Controls.Add(this.tpCQYZ);
		this.TabControl1.Controls.Add(this.tpLSYZ);
		this.TabControl1.Dock = DockStyle.Fill;
		Control arg_D2_0 = this.TabControl1;
		Point location = new Point(0, 0);
		arg_D2_0.Location = location;
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		Control arg_10B_0 = this.TabControl1;
		Size size = new Size(728, 454);
		arg_10B_0.Size = size;
		this.TabControl1.TabIndex = 0;
		this.tpCQYZ.Controls.Add(this.tcOrders);
		TabPage arg_143_0 = this.tpCQYZ;
		location = new Point(4, 21);
		arg_143_0.Location = location;
		this.tpCQYZ.Name = "tpCQYZ";
		Control arg_167_0 = this.tpCQYZ;
		Padding padding = new Padding(3);
		arg_167_0.Padding = padding;
		Control arg_184_0 = this.tpCQYZ;
		size = new Size(720, 429);
		arg_184_0.Size = size;
		this.tpCQYZ.TabIndex = 0;
		this.tpCQYZ.Text = "医嘱引用";
		this.tpCQYZ.UseVisualStyleBackColor = true;
		this.tpLSYZ.Controls.Add(this.dgBOLISData);
		TabPage arg_1D8_0 = this.tpLSYZ;
		location = new Point(4, 21);
		arg_1D8_0.Location = location;
		this.tpLSYZ.Name = "tpLSYZ";
		Control arg_1FC_0 = this.tpLSYZ;
		padding = new Padding(3);
		arg_1FC_0.Padding = padding;
		Control arg_219_0 = this.tpLSYZ;
		size = new Size(720, 429);
		arg_219_0.Size = size;
		this.tpLSYZ.TabIndex = 1;
		this.tpLSYZ.Text = "就诊列表";
		this.tpLSYZ.UseVisualStyleBackColor = true;
		this.tcOrders.Controls.Add(this.tpLongorder);
		this.tcOrders.Controls.Add(this.tptemporder);
		this.tcOrders.Dock = DockStyle.Fill;
		Control arg_28E_0 = this.tcOrders;
		location = new Point(3, 3);
		arg_28E_0.Location = location;
		this.tcOrders.Name = "tcOrders";
		this.tcOrders.SelectedIndex = 0;
		Control arg_2C7_0 = this.tcOrders;
		size = new Size(714, 423);
		arg_2C7_0.Size = size;
		this.tcOrders.TabIndex = 0;
		TabPage arg_2E9_0 = this.tpLongorder;
		location = new Point(4, 21);
		arg_2E9_0.Location = location;
		this.tpLongorder.Name = "tpLongorder";
		Control arg_30D_0 = this.tpLongorder;
		padding = new Padding(3);
		arg_30D_0.Padding = padding;
		Control arg_32A_0 = this.tpLongorder;
		size = new Size(706, 398);
		arg_32A_0.Size = size;
		this.tpLongorder.TabIndex = 0;
		this.tpLongorder.Text = "长期医嘱";
		this.tpLongorder.UseVisualStyleBackColor = true;
		TabPage arg_368_0 = this.tptemporder;
		location = new Point(4, 21);
		arg_368_0.Location = location;
		this.tptemporder.Name = "tptemporder";
		Control arg_38C_0 = this.tptemporder;
		padding = new Padding(3);
		arg_38C_0.Padding = padding;
		Control arg_3A9_0 = this.tptemporder;
		size = new Size(706, 398);
		arg_3A9_0.Size = size;
		this.tptemporder.TabIndex = 1;
		this.tptemporder.Text = "临时医嘱";
		this.tptemporder.UseVisualStyleBackColor = true;
		this.dgBOLISData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgBOLISData.Dock = DockStyle.Fill;
		Control arg_3FE_0 = this.dgBOLISData;
		location = new Point(3, 3);
		arg_3FE_0.Location = location;
		this.dgBOLISData.Name = "dgBOLISData";
		this.dgBOLISData.ReadOnly = true;
		this.dgBOLISData.RowTemplate.Height = 23;
		this.dgBOLISData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		Control arg_455_0 = this.dgBOLISData;
		size = new Size(714, 423);
		arg_455_0.Size = size;
		this.dgBOLISData.TabIndex = 5;
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		size = new Size(728, 454);
		this.ClientSize = size;
		this.Controls.Add(this.TabControl1);
		this.Name = "OrdersDictionary";
		this.Text = "引用医嘱信息";
		this.TabControl1.ResumeLayout(false);
		this.tpCQYZ.ResumeLayout(false);
		this.tpLSYZ.ResumeLayout(false);
		this.tcOrders.ResumeLayout(false);
		((ISupportInitialize)this.dgBOLISData).EndInit();
		this.ResumeLayout(false);
	}
}
