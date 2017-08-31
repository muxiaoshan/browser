using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.printlink;
using dhcc.epr.systemframework;
using InterfaceTemplateData;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class BindData : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("lblVType")]
		private Label _lblVType;

		[AccessedThroughProperty("cbxVType")]
		private ComboBox _cbxVType;

		[AccessedThroughProperty("grpUnitTree")]
		private GroupBox _grpUnitTree;

		[AccessedThroughProperty("splVType")]
		private SplitContainer _splVType;

		[AccessedThroughProperty("grpTemplateTree")]
		private GroupBox _grpTemplateTree;

		[AccessedThroughProperty("splEPR")]
		private SplitContainer _splEPR;

		[AccessedThroughProperty("EPRDataTab")]
		private TabPageAdv _EPRDataTab;

		[AccessedThroughProperty("SystemDataTab")]
		private TabPageAdv _SystemDataTab;

		[AccessedThroughProperty("TabControlAdv1")]
		private TabControlAdv _TabControlAdv1;

		[AccessedThroughProperty("splMain")]
		private SplitContainer _splMain;

		[AccessedThroughProperty("TemplateTree")]
		private TemplateTree _TemplateTree;

		[AccessedThroughProperty("UnitTree")]
		private UnitTree _UnitTree;

		[AccessedThroughProperty("QueryTree")]
		private QueryTree _QueryTree;

		[AccessedThroughProperty("FieldTree")]
		private FieldTree _FieldTree;

		private string _EPRBindCode;

		private string _DataBaseBindCode;

		private DCMetaData _DCMetaData;

		private string _TagItemCode;

		private int _TagItemType;

		private const int TSINGLE = 1;

		private const int TDOUBLE = 2;

		private const int TSEGMENT = 3;

		private const string VTYPEV = "值";

		private const string VTYPEC = "代码";

		private const string VTYPEVC = "值和代码";

		private const string VTYPECV = "代码和值";

		private const string VTYPEVANDC = "值^代码";

		private const string VTYPEYEAR = "年";

		private const string VTYPEMONTH = "月";

		private const string VTYPEDAY = "日";

		private const string VTYPEHOUR = "小时";

		private const string VTYPEMINUTE = "分";

		private const string VTYPESECOND = "秒";

		[AccessedThroughProperty("splSystemData")]
		private SplitContainerAdv _splSystemData;

		[AccessedThroughProperty("grpQueryTree")]
		private GroupBox _grpQueryTree;

		[AccessedThroughProperty("grpFieldTree")]
		private GroupBox _grpFieldTree;

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
				EventHandler value2 = new EventHandler(this.cbxVType_SelectedIndexChanged);
				if (this._cbxVType != null)
				{
					this._cbxVType.SelectedIndexChanged -= value2;
				}
				this._cbxVType = value;
				if (this._cbxVType != null)
				{
					this._cbxVType.SelectedIndexChanged += value2;
				}
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

		internal virtual TabPageAdv EPRDataTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EPRDataTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EPRDataTab = value;
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
				EventHandler eventHandler = new EventHandler(this.TabControlAdv1_SelectedIndexChanged);
				if (this._TabControlAdv1 != null)
				{
					this._TabControlAdv1.remove_SelectedIndexChanged(eventHandler);
				}
				this._TabControlAdv1 = value;
				if (this._TabControlAdv1 != null)
				{
					this._TabControlAdv1.add_SelectedIndexChanged(eventHandler);
				}
			}
		}

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

		private virtual TemplateTree TemplateTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TemplateTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.TemplateTree_AfterSelect);
				if (this._TemplateTree != null)
				{
					this._TemplateTree.AfterSelect -= value2;
				}
				this._TemplateTree = value;
				if (this._TemplateTree != null)
				{
					this._TemplateTree.AfterSelect += value2;
				}
			}
		}

		private virtual UnitTree UnitTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnitTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.UnitTree_AfterSelect);
				if (this._UnitTree != null)
				{
					this._UnitTree.AfterSelect -= value2;
				}
				this._UnitTree = value;
				if (this._UnitTree != null)
				{
					this._UnitTree.AfterSelect += value2;
				}
			}
		}

		private virtual QueryTree QueryTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QueryTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.QueryTree_AfterSelect);
				if (this._QueryTree != null)
				{
					this._QueryTree.AfterSelect -= value2;
				}
				this._QueryTree = value;
				if (this._QueryTree != null)
				{
					this._QueryTree.AfterSelect += value2;
				}
			}
		}

		private virtual FieldTree FieldTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FieldTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.FieldTree_AfterSelect);
				if (this._FieldTree != null)
				{
					this._FieldTree.AfterSelect -= value2;
				}
				this._FieldTree = value;
				if (this._FieldTree != null)
				{
					this._FieldTree.AfterSelect += value2;
				}
			}
		}

		public string EPRBindCode
		{
			get
			{
				return this._EPRBindCode;
			}
			set
			{
				this._EPRBindCode = value;
			}
		}

		public string DataBaseBindCode
		{
			get
			{
				return this._DataBaseBindCode;
			}
			set
			{
				this._DataBaseBindCode = value;
			}
		}

		public string TagItemCode
		{
			get
			{
				return this._TagItemCode;
			}
			set
			{
				this._TagItemCode = value;
				this._TagItemType = this.GetItemType(value);
			}
		}

		public DCMetaData DCMetaData
		{
			get
			{
				return this._DCMetaData;
			}
			set
			{
				this._DCMetaData = value;
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

		public BindData()
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

		private void InitializeComponent()
		{
			this.splMain = new SplitContainer();
			this.TabControlAdv1 = new TabControlAdv();
			this.SystemDataTab = new TabPageAdv();
			this.splSystemData = new SplitContainerAdv();
			this.grpQueryTree = new GroupBox();
			this.grpFieldTree = new GroupBox();
			this.EPRDataTab = new TabPageAdv();
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
			this.EPRDataTab.SuspendLayout();
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
			Size size = new Size(217, 500);
			arg_234_0.Size = size;
			this.splMain.SplitterDistance = 466;
			this.splMain.TabIndex = 0;
			this.TabControlAdv1.set_BorderStyle(BorderStyle.None);
			this.TabControlAdv1.Controls.Add(this.SystemDataTab);
			this.TabControlAdv1.Controls.Add(this.EPRDataTab);
			this.TabControlAdv1.Dock = DockStyle.Fill;
			Control arg_2A9_0 = this.TabControlAdv1;
			location = new Point(0, 0);
			arg_2A9_0.Location = location;
			this.TabControlAdv1.Name = "TabControlAdv1";
			Control arg_2D6_0 = this.TabControlAdv1;
			size = new Size(217, 466);
			arg_2D6_0.Size = size;
			this.TabControlAdv1.TabIndex = 0;
			this.TabControlAdv1.set_TabStyle(typeof(TabRendererWorkbookMode));
			this.SystemDataTab.Controls.Add(this.splSystemData);
			Control arg_323_0 = this.SystemDataTab;
			location = new Point(0, 23);
			arg_323_0.Location = location;
			this.SystemDataTab.Name = "SystemDataTab";
			Control arg_350_0 = this.SystemDataTab;
			size = new Size(217, 443);
			arg_350_0.Size = size;
			this.SystemDataTab.set_TabIndex(1);
			this.SystemDataTab.set_Text("系统数据");
			this.SystemDataTab.set_ThemesEnabled(false);
			this.splSystemData.Dock = DockStyle.Fill;
			Control arg_399_0 = this.splSystemData;
			location = new Point(0, 0);
			arg_399_0.Location = location;
			this.splSystemData.Name = "splSystemData";
			this.splSystemData.set_Orientation(Orientation.Vertical);
			this.splSystemData.get_Panel1().Controls.Add(this.grpQueryTree);
			this.splSystemData.get_Panel2().Controls.Add(this.grpFieldTree);
			Control arg_408_0 = this.splSystemData;
			size = new Size(217, 443);
			arg_408_0.Size = size;
			this.splSystemData.set_SplitterDistance(219);
			this.splSystemData.TabIndex = 0;
			this.splSystemData.Text = "SplitContainerAdv1";
			this.grpQueryTree.Dock = DockStyle.Fill;
			Control arg_455_0 = this.grpQueryTree;
			location = new Point(0, 0);
			arg_455_0.Location = location;
			this.grpQueryTree.Name = "grpQueryTree";
			Control arg_482_0 = this.grpQueryTree;
			size = new Size(217, 219);
			arg_482_0.Size = size;
			this.grpQueryTree.TabIndex = 0;
			this.grpQueryTree.TabStop = false;
			this.grpQueryTree.Text = "选择系统表";
			this.grpFieldTree.Dock = DockStyle.Fill;
			Control arg_4CB_0 = this.grpFieldTree;
			location = new Point(0, 0);
			arg_4CB_0.Location = location;
			this.grpFieldTree.Name = "grpFieldTree";
			Control arg_4F8_0 = this.grpFieldTree;
			size = new Size(217, 217);
			arg_4F8_0.Size = size;
			this.grpFieldTree.TabIndex = 0;
			this.grpFieldTree.TabStop = false;
			this.grpFieldTree.Text = "选择字段";
			this.EPRDataTab.Controls.Add(this.splEPR);
			Control arg_54C_0 = this.EPRDataTab;
			location = new Point(0, 23);
			arg_54C_0.Location = location;
			this.EPRDataTab.Name = "EPRDataTab";
			Control arg_579_0 = this.EPRDataTab;
			size = new Size(217, 443);
			arg_579_0.Size = size;
			this.EPRDataTab.set_TabIndex(2);
			this.EPRDataTab.set_Text("病历数据");
			this.EPRDataTab.set_ThemesEnabled(false);
			this.splEPR.Dock = DockStyle.Fill;
			Control arg_5C2_0 = this.splEPR;
			location = new Point(0, 0);
			arg_5C2_0.Location = location;
			this.splEPR.Name = "splEPR";
			this.splEPR.Orientation = Orientation.Horizontal;
			this.splEPR.Panel1.Controls.Add(this.grpTemplateTree);
			this.splEPR.Panel2.Controls.Add(this.splVType);
			Control arg_631_0 = this.splEPR;
			size = new Size(217, 443);
			arg_631_0.Size = size;
			this.splEPR.SplitterDistance = 227;
			this.splEPR.TabIndex = 0;
			this.grpTemplateTree.AccessibleDescription = "";
			this.grpTemplateTree.Dock = DockStyle.Fill;
			Control arg_67E_0 = this.grpTemplateTree;
			location = new Point(0, 0);
			arg_67E_0.Location = location;
			this.grpTemplateTree.Name = "grpTemplateTree";
			Control arg_6AB_0 = this.grpTemplateTree;
			size = new Size(217, 227);
			arg_6AB_0.Size = size;
			this.grpTemplateTree.TabIndex = 1;
			this.grpTemplateTree.TabStop = false;
			this.grpTemplateTree.Text = "选择模板";
			this.splVType.Dock = DockStyle.Fill;
			Control arg_6F4_0 = this.splVType;
			location = new Point(0, 0);
			arg_6F4_0.Location = location;
			this.splVType.Name = "splVType";
			this.splVType.Orientation = Orientation.Horizontal;
			this.splVType.Panel1.Controls.Add(this.grpUnitTree);
			this.splVType.Panel2.Controls.Add(this.cbxVType);
			this.splVType.Panel2.Controls.Add(this.lblVType);
			Control arg_77E_0 = this.splVType;
			size = new Size(217, 212);
			arg_77E_0.Size = size;
			this.splVType.SplitterDistance = 163;
			this.splVType.TabIndex = 0;
			this.grpUnitTree.Dock = DockStyle.Fill;
			Control arg_7BB_0 = this.grpUnitTree;
			location = new Point(0, 0);
			arg_7BB_0.Location = location;
			this.grpUnitTree.Name = "grpUnitTree";
			Control arg_7E8_0 = this.grpUnitTree;
			size = new Size(217, 163);
			arg_7E8_0.Size = size;
			this.grpUnitTree.TabIndex = 0;
			this.grpUnitTree.TabStop = false;
			this.grpUnitTree.Text = "选择单元";
			Control arg_827_0 = this.cbxVType;
			location = new Point(110, 10);
			arg_827_0.Location = location;
			this.cbxVType.Name = "cbxVType";
			Control arg_84E_0 = this.cbxVType;
			size = new Size(100, 20);
			arg_84E_0.Size = size;
			this.cbxVType.TabIndex = 11;
			Control arg_871_0 = this.lblVType;
			location = new Point(4, 14);
			arg_871_0.Location = location;
			this.lblVType.Name = "lblVType";
			Control arg_898_0 = this.lblVType;
			size = new Size(79, 17);
			arg_898_0.Size = size;
			this.lblVType.TabIndex = 10;
			this.lblVType.Text = "设置取值类型";
			this.btnCancel.Dock = DockStyle.Right;
			Control arg_8DA_0 = this.btnCancel;
			location = new Point(153, 0);
			arg_8DA_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_901_0 = this.btnCancel;
			size = new Size(64, 30);
			arg_901_0.Size = size;
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "取消";
			this.btnOK.Dock = DockStyle.Left;
			Control arg_93E_0 = this.btnOK;
			location = new Point(0, 0);
			arg_93E_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_965_0 = this.btnOK;
			size = new Size(64, 30);
			arg_965_0.Size = size;
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "确定";
			this.Controls.Add(this.splMain);
			this.Name = "BindData";
			size = new Size(217, 500);
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
			this.EPRDataTab.ResumeLayout(false);
			this.splEPR.Panel1.ResumeLayout(false);
			this.splEPR.Panel2.ResumeLayout(false);
			this.splEPR.ResumeLayout(false);
			this.splVType.Panel1.ResumeLayout(false);
			this.splVType.Panel2.ResumeLayout(false);
			this.splVType.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void Init()
		{
			this.TemplateTree = new TemplateTree(TemplateTree.ShowLevel.OnlySingle);
			this.UnitTree = new UnitTree();
			this.grpTemplateTree.Controls.Add(this.TemplateTree);
			this.grpUnitTree.Controls.Add(this.UnitTree);
			this.TemplateTree.Dock = DockStyle.Fill;
			this.UnitTree.Dock = DockStyle.Fill;
			this.TemplateTree.Init();
			this.FieldTree = new FieldTree();
			this.QueryTree = new QueryTree();
			this.grpQueryTree.Controls.Add(this.QueryTree);
			this.grpFieldTree.Controls.Add(this.FieldTree);
			this.QueryTree.Dock = DockStyle.Fill;
			this.FieldTree.Dock = DockStyle.Fill;
			if (this.QueryTree.Nodes.Count > 0)
			{
				this.QueryTree.SelectedNode = this.QueryTree.Nodes[0];
			}
		}

		private void TemplateTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (Operators.CompareString(this.TemplateTree.GetNodeType(this.TemplateTree.SelectedNode), "LF", false) == 0)
			{
				this.UnitTree.ITName = this.TemplateTree.SelectedNode.Text;
				this.UnitTree.ITID = this.TemplateTree.GetNodeId(this.TemplateTree.SelectedNode);
				try
				{
					ETemplateVersion metadataByTemplateID = WebServiceLayer.InterfaceTemplateAccess.GetMetadataByTemplateID(this.UnitTree.ITID);
					if (metadataByTemplateID == null)
					{
						MessageManager.ShowInformationMessage("绑定的界面模板还没有发布，请先发布再绑定");
						this.UnitTree.Nodes.Clear();
						return;
					}
					if (Operators.CompareString(metadataByTemplateID.MetaData, "", false) != 0)
					{
						this.UnitTree.ITVersion = metadataByTemplateID.VersionNumber.ToString();
						this.UnitTree.StrMetaData = metadataByTemplateID.MetaData;
					}
					return;
				}
				catch (Exception expr_D8)
				{
					ProjectData.SetProjectError(expr_D8);
					Exception ex = expr_D8;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
					return;
				}
			}
			this.UnitTree.Nodes.Clear();
		}

		private void UnitTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (Conversions.ToBoolean(Operators.OrObject(this.UnitTree.SelectedNode.Tag == null, Operators.CompareObjectEqual(this.UnitTree.SelectedNode.Tag, "", false))))
			{
				this.cbxVType.Enabled = false;
				this.EPRBindCode = "";
			}
			else
			{
				this.EPRBindCode = Conversions.ToString(this.UnitTree.SelectedNode.Tag);
				this.SetVType(this._EPRBindCode);
				this.DataBaseBindCode = "";
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DCMetaData.splMain.Panel2Collapsed = true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this._EPRBindCode != null)
			{
				string[] array = this.EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (array.Length > 4)
				{
					string sourceItemCode = array[4].Split(new char[]
					{
						':'
					})[1];
					if (this.EPRBindCode != null && Operators.CompareString(this.EPRBindCode, "", false) != 0 && !this.CheckItemBind(sourceItemCode, this.TagItemCode))
					{
						MessageBox.Show("所选择的单元不允许绑定到目标单元，请重新选择！", "东华结构化电子病历");
						return;
					}
				}
			}
			if (!(this.EPRBindCode == null | Operators.CompareString(this.EPRBindCode, "", false) == 0))
			{
				this.DCMetaData.CurrentMetaItem.EPRBindCode = this.EPRBindCode;
				this.DCMetaData.CurrentMetaItem.DataBaseBindCode = "";
				this.DCMetaData.txtDataBind.Text = this.DCMetaData.CurrentMetaItem.EPRBindCode.Split(new char[]
				{
					'#'
				})[0];
			}
			if (!(this.DataBaseBindCode == null | Operators.CompareString(this.DataBaseBindCode, "", false) == 0))
			{
				this.DCMetaData.CurrentMetaItem.DataBaseBindCode = this.DataBaseBindCode;
				this.DCMetaData.CurrentMetaItem.EPRBindCode = "";
				this.DCMetaData.txtDataBind.Text = this.DCMetaData.CurrentMetaItem.DataBaseBindCode.Split(new char[]
				{
					'#'
				})[0];
			}
			if (Operators.CompareString(this.DCMetaData.txtDataBind.Text, "", false) == 0)
			{
				this.DCMetaData.ckbDataSynch.Enabled = false;
				this.DCMetaData.CurrentMetaItem.Synch = false;
			}
			else
			{
				this.DCMetaData.ckbDataSynch.Enabled = true;
			}
			this.DCMetaData.ckbDataSynch.Checked = this.DCMetaData.CurrentMetaItem.Synch;
		}

		private void cbxVType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this._EPRBindCode == null | Operators.CompareString(this._EPRBindCode, "", false) == 0)
			{
				return;
			}
			string[] array = this._EPRBindCode.Split(new char[]
			{
				'#'
			});
			if (Operators.CompareString(array[1], "TYPE:Simple", false) == 0)
			{
				int length = this._EPRBindCode.IndexOf("#VTYPE:");
				string str = this._EPRBindCode.Substring(0, length);
				string text = array[4].Split(new char[]
				{
					':'
				})[1];
				string text2 = array[5].Split(new char[]
				{
					':'
				})[1];
				if (!text.StartsWith("S"))
				{
					if (!text.StartsWith("N"))
					{
						if (text.StartsWith("O"))
						{
							if (this.cbxVType.SelectedIndex == 0)
							{
								this._EPRBindCode = str + "#VTYPE:V";
							}
							else if (this.cbxVType.SelectedIndex == 1)
							{
								this._EPRBindCode = str + "#VTYPE:C";
							}
							else if (this.cbxVType.SelectedIndex == 2)
							{
								this._EPRBindCode = str + "#VTYPE:VANDC";
							}
						}
						else if (text.StartsWith("M"))
						{
							if (this.cbxVType.SelectedIndex == 0)
							{
								this._EPRBindCode = str + "#VTYPE:V";
							}
							else if (this.cbxVType.SelectedIndex == 1)
							{
								this._EPRBindCode = str + "#VTYPE:C";
							}
							else if (this.cbxVType.SelectedIndex == 2)
							{
								this._EPRBindCode = str + "#VTYPE:VANDC";
							}
						}
						else if (text.StartsWith("Q"))
						{
							if (this.cbxVType.SelectedIndex == 0)
							{
								this._EPRBindCode = str + "#VTYPE:VC";
							}
							else if (this.cbxVType.SelectedIndex == 1)
							{
								this._EPRBindCode = str + "#VTYPE:V";
							}
							else if (this.cbxVType.SelectedIndex == 2)
							{
								this._EPRBindCode = str + "#VTYPE:C";
							}
							else if (this.cbxVType.SelectedIndex == 3)
							{
								this._EPRBindCode = str + "#VTYPE:VANDC";
							}
						}
						else if (text.StartsWith("D"))
						{
							if (this.cbxVType.SelectedIndex == 0)
							{
								this._EPRBindCode = str + "#VTYPE:V";
							}
							else if (this.cbxVType.SelectedIndex == 1)
							{
								this._EPRBindCode = str + "#VTYPE:C";
							}
							else if (this.cbxVType.SelectedIndex == 2)
							{
								this._EPRBindCode = str + "#VTYPE:VANDC";
							}
							else if (this.cbxVType.SelectedIndex == 3)
							{
								this._EPRBindCode = str + "#VTYPE:YEAR";
							}
							else if (this.cbxVType.SelectedIndex == 4)
							{
								this._EPRBindCode = str + "#VTYPE:MONTH";
							}
							else if (this.cbxVType.SelectedIndex == 5)
							{
								this._EPRBindCode = str + "#VTYPE:DAY";
							}
							else if (this.cbxVType.SelectedIndex == 6)
							{
								this._EPRBindCode = str + "#VTYPE:HOUR";
							}
							else if (this.cbxVType.SelectedIndex == 7)
							{
								this._EPRBindCode = str + "#VTYPE:MINUTE";
							}
							else if (this.cbxVType.SelectedIndex == 8)
							{
								this._EPRBindCode = str + "#VTYPE:SECOND";
							}
						}
						else if (text.StartsWith("I"))
						{
							if (this.cbxVType.SelectedIndex == 0)
							{
								this._EPRBindCode = str + "#VTYPE:V";
							}
							else if (this.cbxVType.SelectedIndex == 1)
							{
								this._EPRBindCode = str + "#VTYPE:C";
							}
							else if (this.cbxVType.SelectedIndex == 2)
							{
								this._EPRBindCode = str + "#VTYPE:VC";
							}
							else if (this.cbxVType.SelectedIndex == 3)
							{
								this._EPRBindCode = str + "#VTYPE:VC";
							}
							else if (this.cbxVType.SelectedIndex == 4)
							{
								this._EPRBindCode = str + "#VTYPE:VANDC";
							}
						}
					}
				}
			}
			else if (Operators.CompareString(array[1], "TYPE:Segment", false) == 0)
			{
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				this.cbxVType.Enabled = false;
			}
			else if (Operators.CompareString(array[1], "TYPE:TextDesc", false) == 0)
			{
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				this.cbxVType.Enabled = false;
			}
		}

		private void QueryTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string nodeID = this.QueryTree.GetNodeID(this.QueryTree.SelectedNode);
			string nodeName = this.QueryTree.GetNodeName(this.QueryTree.SelectedNode);
			string nodeClassName = this.QueryTree.GetNodeClassName(this.QueryTree.SelectedNode);
			string nodeQueryName = this.QueryTree.GetNodeQueryName(this.QueryTree.SelectedNode);
			if (!(nodeID == null | Operators.CompareString(nodeID, "", false) == 0))
			{
				this.FieldTree.DSName = nodeName;
				this.FieldTree.DSCName = nodeClassName;
				this.FieldTree.DSQName = nodeQueryName;
				this.FieldTree.DSID = nodeID;
			}
		}

		private void FieldTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this._DataBaseBindCode = Conversions.ToString(this.FieldTree.SelectedNode.Tag);
		}

		public void SetVType(string strCode)
		{
			string[] array = strCode.Split(new char[]
			{
				'#'
			});
			if (array.Length > 4 && !this.CheckItemBind(array[4].Split(new char[]
			{
				':'
			})[1], this._TagItemCode))
			{
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				this.cbxVType.Enabled = false;
				return;
			}
			if (Operators.CompareString(array[1], "TYPE:Simple", false) == 0)
			{
				string text = array[4].Split(new char[]
				{
					':'
				})[1];
				string text2 = array[5].Split(new char[]
				{
					':'
				})[1];
				this.cbxVType.Enabled = true;
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				if (text.StartsWith("S"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.SelectedIndex = 0;
				}
				else if (text.StartsWith("N"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.SelectedIndex = 0;
				}
				else if (text.StartsWith("O"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.Items.Add("代码");
					this.cbxVType.Items.Add("值^代码");
					if (this._TagItemType == 2)
					{
						this.cbxVType.SelectedIndex = 2;
					}
					else
					{
						this.cbxVType.SelectedIndex = 0;
					}
				}
				else if (text.StartsWith("M"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.Items.Add("代码");
					this.cbxVType.Items.Add("值^代码");
					if (this._TagItemType == 2)
					{
						this.cbxVType.SelectedIndex = 2;
					}
					else
					{
						this.cbxVType.SelectedIndex = 0;
					}
				}
				else if (text.StartsWith("Q"))
				{
					this.cbxVType.Items.Add("值和代码");
					this.cbxVType.Items.Add("值");
					this.cbxVType.Items.Add("代码");
					this.cbxVType.Items.Add("值^代码");
					if (this._TagItemType == 2)
					{
						this.cbxVType.SelectedIndex = 3;
					}
					else
					{
						this.cbxVType.SelectedIndex = 0;
					}
				}
				else if (text.StartsWith("D"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.Items.Add("代码");
					this.cbxVType.Items.Add("值^代码");
					this.cbxVType.Items.Add("年");
					this.cbxVType.Items.Add("月");
					this.cbxVType.Items.Add("日");
					this.cbxVType.Items.Add("小时");
					this.cbxVType.Items.Add("分");
					this.cbxVType.Items.Add("秒");
					if (this._TagItemType == 2)
					{
						this.cbxVType.SelectedIndex = 2;
					}
					else
					{
						this.cbxVType.SelectedIndex = 0;
					}
				}
				else if (text.StartsWith("I"))
				{
					this.cbxVType.Items.Add("值");
					this.cbxVType.Items.Add("代码");
					this.cbxVType.Items.Add("值和代码");
					this.cbxVType.Items.Add("代码和值");
					this.cbxVType.Items.Add("值^代码");
					if (this._TagItemType == 2)
					{
						this.cbxVType.SelectedIndex = 4;
					}
					else
					{
						this.cbxVType.SelectedIndex = 0;
					}
				}
			}
			else if (Operators.CompareString(array[1], "TYPE:Segment", false) == 0)
			{
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				this.cbxVType.Enabled = false;
			}
			else if (Operators.CompareString(array[1], "TYPE:TextDesc", false) == 0)
			{
				this.cbxVType.Text = "";
				this.cbxVType.Items.Clear();
				this.cbxVType.Enabled = false;
			}
		}

		private bool CheckItemBind(string sourceItemCode, string tagItemCode)
		{
			if (Operators.CompareString(sourceItemCode, "", false) == 0 | Operators.CompareString(tagItemCode, "", false) == 0)
			{
				return false;
			}
			int itemType = this.GetItemType(sourceItemCode);
			if (this._TagItemType == 2 && itemType != 2)
			{
				return false;
			}
			if (this._TagItemType == 2)
			{
				string left = null;
				if (sourceItemCode.Length > 1)
				{
					left = sourceItemCode.Substring(0, 1);
				}
				string right = null;
				if (tagItemCode.Length > 1)
				{
					right = tagItemCode.Substring(0, 1);
				}
				if (Operators.CompareString(left, right, false) != 0)
				{
					return false;
				}
			}
			return true;
		}

		private int GetItemType(string itemCode)
		{
			int result;
			if (itemCode.StartsWith("S"))
			{
				result = 1;
			}
			else if (itemCode.StartsWith("N"))
			{
				result = 1;
			}
			else if (itemCode.StartsWith("O"))
			{
				result = 2;
			}
			else if (itemCode.StartsWith("M"))
			{
				result = 2;
			}
			else if (itemCode.StartsWith("Q"))
			{
				result = 2;
			}
			else if (itemCode.StartsWith("D"))
			{
				result = 2;
			}
			else if (itemCode.StartsWith("I"))
			{
				result = 2;
			}
			else if (itemCode.StartsWith("G"))
			{
				result = 3;
			}
			else if (itemCode.StartsWith("E"))
			{
				result = 3;
			}
			return result;
		}

		private void TabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._EPRBindCode = string.Empty;
			this._DataBaseBindCode = string.Empty;
		}
	}
}
