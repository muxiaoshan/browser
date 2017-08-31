using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
internal class BindData : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("splMain")]
	private SplitContainer _splMain;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("btnOK")]
	private Button _btnOK;

	[AccessedThroughProperty("TabControlAdv1")]
	private TabControlAdv _TabControlAdv1;

	[AccessedThroughProperty("SystemDataTab")]
	private TabPageAdv _SystemDataTab;

	[AccessedThroughProperty("EPEDataTab")]
	private TabPageAdv _EPEDataTab;

	[AccessedThroughProperty("splSystemData")]
	private SplitContainerAdv _splSystemData;

	[AccessedThroughProperty("splEPR")]
	private SplitContainer _splEPR;

	[AccessedThroughProperty("splVType")]
	private SplitContainer _splVType;

	[AccessedThroughProperty("grpTemplateTree")]
	private GroupBox _grpTemplateTree;

	[AccessedThroughProperty("grpUnitTree")]
	private GroupBox _grpUnitTree;

	[AccessedThroughProperty("cbxVType")]
	private ComboBox _cbxVType;

	[AccessedThroughProperty("lblVType")]
	private Label _lblVType;

	[AccessedThroughProperty("grpQueryTree")]
	private GroupBox _grpQueryTree;

	[AccessedThroughProperty("grpFieldTree")]
	private GroupBox _grpFieldTree;

	internal virtual SplitContainer splMain
	{
		[DebuggerNonUserCode]
		get
		{
			return this._splMain;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._splMain = value;
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

	internal virtual TabControlAdv TabControlAdv1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TabControlAdv1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TabControlAdv1 = value;
		}
	}

	internal virtual TabPageAdv SystemDataTab
	{
		[DebuggerNonUserCode]
		get
		{
			return this._SystemDataTab;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._SystemDataTab = value;
		}
	}

	internal virtual TabPageAdv EPEDataTab
	{
		[DebuggerNonUserCode]
		get
		{
			return this._EPEDataTab;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._EPEDataTab = value;
		}
	}

	internal virtual SplitContainerAdv splSystemData
	{
		[DebuggerNonUserCode]
		get
		{
			return this._splSystemData;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._splSystemData = value;
		}
	}

	internal virtual SplitContainer splEPR
	{
		[DebuggerNonUserCode]
		get
		{
			return this._splEPR;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._splEPR = value;
		}
	}

	internal virtual SplitContainer splVType
	{
		[DebuggerNonUserCode]
		get
		{
			return this._splVType;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._splVType = value;
		}
	}

	internal virtual GroupBox grpTemplateTree
	{
		[DebuggerNonUserCode]
		get
		{
			return this._grpTemplateTree;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._grpTemplateTree = value;
		}
	}

	internal virtual GroupBox grpUnitTree
	{
		[DebuggerNonUserCode]
		get
		{
			return this._grpUnitTree;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._grpUnitTree = value;
		}
	}

	internal virtual ComboBox cbxVType
	{
		[DebuggerNonUserCode]
		get
		{
			return this._cbxVType;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._cbxVType = value;
		}
	}

	internal virtual Label lblVType
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblVType;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblVType = value;
		}
	}

	internal virtual GroupBox grpQueryTree
	{
		[DebuggerNonUserCode]
		get
		{
			return this._grpQueryTree;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._grpQueryTree = value;
		}
	}

	internal virtual GroupBox grpFieldTree
	{
		[DebuggerNonUserCode]
		get
		{
			return this._grpFieldTree;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._grpFieldTree = value;
		}
	}

	[DebuggerNonUserCode]
	public BindData()
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
		this.splMain = new SplitContainer();
		this.TabControlAdv1 = new TabControlAdv();
		this.SystemDataTab = new TabPageAdv();
		this.splSystemData = new SplitContainerAdv();
		this.grpQueryTree = new GroupBox();
		this.grpFieldTree = new GroupBox();
		this.EPEDataTab = new TabPageAdv();
		this.splEPR = new SplitContainer();
		this.grpTemplateTree = new GroupBox();
		this.splVType = new SplitContainer();
		this.grpUnitTree = new GroupBox();
		this.cbxVType = new ComboBox();
		this.lblVType = new Label();
		this.btnCancel = new Button();
		this.btnOK = new Button();
		this.splMain.Panel1.SuspendLayout();
		this.splMain.Panel2.SuspendLayout();
		this.splMain.SuspendLayout();
		this.TabControlAdv1.BeginInit();
		this.TabControlAdv1.SuspendLayout();
		this.SystemDataTab.SuspendLayout();
		this.splSystemData.BeginInit();
		this.splSystemData.get_Panel1().SuspendLayout();
		this.splSystemData.get_Panel2().SuspendLayout();
		this.splSystemData.SuspendLayout();
		this.EPEDataTab.SuspendLayout();
		this.splEPR.Panel1.SuspendLayout();
		this.splEPR.Panel2.SuspendLayout();
		this.splEPR.SuspendLayout();
		this.splVType.Panel1.SuspendLayout();
		this.splVType.Panel2.SuspendLayout();
		this.splVType.SuspendLayout();
		this.SuspendLayout();
		this.splMain.Dock = DockStyle.Fill;
		Control arg_1AA_0 = this.splMain;
		Point location = new Point(0, 0);
		arg_1AA_0.Location = location;
		this.splMain.Name = "splMain";
		this.splMain.Orientation = Orientation.Horizontal;
		this.splMain.Panel1.Controls.Add(this.TabControlAdv1);
		this.splMain.Panel2.Controls.Add(this.btnCancel);
		this.splMain.Panel2.Controls.Add(this.btnOK);
		Control arg_234_0 = this.splMain;
		Size size = new Size(217, 446);
		arg_234_0.Size = size;
		this.splMain.SplitterDistance = 414;
		this.splMain.TabIndex = 0;
		this.TabControlAdv1.Controls.Add(this.SystemDataTab);
		this.TabControlAdv1.Controls.Add(this.EPEDataTab);
		this.TabControlAdv1.Dock = DockStyle.Fill;
		Control arg_29D_0 = this.TabControlAdv1;
		location = new Point(0, 0);
		arg_29D_0.Location = location;
		this.TabControlAdv1.Name = "TabControlAdv1";
		Control arg_2CA_0 = this.TabControlAdv1;
		size = new Size(217, 414);
		arg_2CA_0.Size = size;
		this.TabControlAdv1.TabIndex = 0;
		this.SystemDataTab.Controls.Add(this.splSystemData);
		Control arg_302_0 = this.SystemDataTab;
		location = new Point(1, 24);
		arg_302_0.Location = location;
		this.SystemDataTab.Name = "SystemDataTab";
		Control arg_32F_0 = this.SystemDataTab;
		size = new Size(214, 388);
		arg_32F_0.Size = size;
		this.SystemDataTab.set_TabIndex(1);
		this.SystemDataTab.set_Text("系统数据");
		this.SystemDataTab.set_ThemesEnabled(false);
		this.splSystemData.Dock = DockStyle.Fill;
		Control arg_378_0 = this.splSystemData;
		location = new Point(0, 0);
		arg_378_0.Location = location;
		this.splSystemData.Name = "splSystemData";
		this.splSystemData.set_Orientation(Orientation.Vertical);
		this.splSystemData.get_Panel1().Controls.Add(this.grpQueryTree);
		this.splSystemData.get_Panel2().Controls.Add(this.grpFieldTree);
		Control arg_3E7_0 = this.splSystemData;
		size = new Size(214, 388);
		arg_3E7_0.Size = size;
		this.splSystemData.set_SplitterDistance(193);
		this.splSystemData.TabIndex = 0;
		this.splSystemData.Text = "SplitContainerAdv1";
		this.grpQueryTree.Dock = DockStyle.Fill;
		Control arg_434_0 = this.grpQueryTree;
		location = new Point(0, 0);
		arg_434_0.Location = location;
		this.grpQueryTree.Name = "grpQueryTree";
		Control arg_461_0 = this.grpQueryTree;
		size = new Size(214, 193);
		arg_461_0.Size = size;
		this.grpQueryTree.TabIndex = 0;
		this.grpQueryTree.TabStop = false;
		this.grpQueryTree.Text = "选择系统表";
		this.grpFieldTree.Dock = DockStyle.Fill;
		Control arg_4AA_0 = this.grpFieldTree;
		location = new Point(0, 0);
		arg_4AA_0.Location = location;
		this.grpFieldTree.Name = "grpFieldTree";
		Control arg_4D7_0 = this.grpFieldTree;
		size = new Size(214, 188);
		arg_4D7_0.Size = size;
		this.grpFieldTree.TabIndex = 0;
		this.grpFieldTree.TabStop = false;
		this.grpFieldTree.Text = "选择字段";
		this.EPEDataTab.Controls.Add(this.splEPR);
		Control arg_52B_0 = this.EPEDataTab;
		location = new Point(1, 24);
		arg_52B_0.Location = location;
		this.EPEDataTab.Name = "EPEDataTab";
		Control arg_558_0 = this.EPEDataTab;
		size = new Size(214, 388);
		arg_558_0.Size = size;
		this.EPEDataTab.set_TabIndex(2);
		this.EPEDataTab.set_Text("病历数据");
		this.EPEDataTab.set_ThemesEnabled(false);
		this.splEPR.Dock = DockStyle.Fill;
		Control arg_5A1_0 = this.splEPR;
		location = new Point(0, 0);
		arg_5A1_0.Location = location;
		this.splEPR.Name = "splEPR";
		this.splEPR.Orientation = Orientation.Horizontal;
		this.splEPR.Panel1.Controls.Add(this.grpTemplateTree);
		this.splEPR.Panel2.Controls.Add(this.splVType);
		Control arg_610_0 = this.splEPR;
		size = new Size(214, 388);
		arg_610_0.Size = size;
		this.splEPR.SplitterDistance = 200;
		this.splEPR.TabIndex = 0;
		this.grpTemplateTree.AccessibleDescription = "";
		this.grpTemplateTree.Dock = DockStyle.Fill;
		Control arg_65D_0 = this.grpTemplateTree;
		location = new Point(0, 0);
		arg_65D_0.Location = location;
		this.grpTemplateTree.Name = "grpTemplateTree";
		Control arg_68A_0 = this.grpTemplateTree;
		size = new Size(214, 200);
		arg_68A_0.Size = size;
		this.grpTemplateTree.TabIndex = 1;
		this.grpTemplateTree.TabStop = false;
		this.grpTemplateTree.Text = "选择模板";
		this.splVType.Dock = DockStyle.Fill;
		Control arg_6D3_0 = this.splVType;
		location = new Point(0, 0);
		arg_6D3_0.Location = location;
		this.splVType.Name = "splVType";
		this.splVType.Orientation = Orientation.Horizontal;
		this.splVType.Panel1.Controls.Add(this.grpUnitTree);
		this.splVType.Panel2.Controls.Add(this.cbxVType);
		this.splVType.Panel2.Controls.Add(this.lblVType);
		Control arg_75D_0 = this.splVType;
		size = new Size(214, 184);
		arg_75D_0.Size = size;
		this.splVType.SplitterDistance = 142;
		this.splVType.TabIndex = 0;
		this.grpUnitTree.Dock = DockStyle.Fill;
		Control arg_79A_0 = this.grpUnitTree;
		location = new Point(0, 0);
		arg_79A_0.Location = location;
		this.grpUnitTree.Name = "grpUnitTree";
		Control arg_7C7_0 = this.grpUnitTree;
		size = new Size(214, 142);
		arg_7C7_0.Size = size;
		this.grpUnitTree.TabIndex = 0;
		this.grpUnitTree.TabStop = false;
		this.grpUnitTree.Text = "选择单元";
		Control arg_806_0 = this.cbxVType;
		location = new Point(110, 10);
		arg_806_0.Location = location;
		this.cbxVType.Name = "cbxVType";
		Control arg_82D_0 = this.cbxVType;
		size = new Size(100, 20);
		arg_82D_0.Size = size;
		this.cbxVType.TabIndex = 11;
		Control arg_850_0 = this.lblVType;
		location = new Point(4, 14);
		arg_850_0.Location = location;
		this.lblVType.Name = "lblVType";
		Control arg_877_0 = this.lblVType;
		size = new Size(79, 17);
		arg_877_0.Size = size;
		this.lblVType.TabIndex = 10;
		this.lblVType.Text = "设置取值类型";
		Control arg_8AA_0 = this.btnCancel;
		location = new Point(124, 2);
		arg_8AA_0.Location = location;
		this.btnCancel.Name = "btnCancel";
		Control arg_8D1_0 = this.btnCancel;
		size = new Size(64, 24);
		arg_8D1_0.Size = size;
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "取消";
		Control arg_903_0 = this.btnOK;
		location = new Point(28, 2);
		arg_903_0.Location = location;
		this.btnOK.Name = "btnOK";
		Control arg_92A_0 = this.btnOK;
		size = new Size(64, 24);
		arg_92A_0.Size = size;
		this.btnOK.TabIndex = 3;
		this.btnOK.Text = "确定";
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		this.Controls.Add(this.splMain);
		this.Name = "BindData";
		size = new Size(217, 446);
		this.Size = size;
		this.splMain.Panel1.ResumeLayout(false);
		this.splMain.Panel2.ResumeLayout(false);
		this.splMain.ResumeLayout(false);
		this.TabControlAdv1.EndInit();
		this.TabControlAdv1.ResumeLayout(false);
		this.SystemDataTab.ResumeLayout(false);
		this.splSystemData.get_Panel1().ResumeLayout(false);
		this.splSystemData.get_Panel2().ResumeLayout(false);
		this.splSystemData.EndInit();
		this.splSystemData.ResumeLayout(false);
		this.EPEDataTab.ResumeLayout(false);
		this.splEPR.Panel1.ResumeLayout(false);
		this.splEPR.Panel2.ResumeLayout(false);
		this.splEPR.ResumeLayout(false);
		this.splVType.Panel1.ResumeLayout(false);
		this.splVType.Panel2.ResumeLayout(false);
		this.splVType.ResumeLayout(false);
		this.ResumeLayout(false);
	}
}
