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
	public class BindForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("BindTabs")]
		private TabControlAdv _BindTabs;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("SystemDataTab")]
		private TabPageAdv _SystemDataTab;

		[AccessedThroughProperty("EPRDataTab")]
		private TabPageAdv _EPRDataTab;

		[AccessedThroughProperty("lblQuery")]
		private Label _lblQuery;

		[AccessedThroughProperty("lblField")]
		private Label _lblField;

		[AccessedThroughProperty("lblUnit")]
		private Label _lblUnit;

		[AccessedThroughProperty("lblTemplate")]
		private Label _lblTemplate;

		[AccessedThroughProperty("lblVType")]
		private Label _lblVType;

		[AccessedThroughProperty("cbxVType")]
		private ComboBox _cbxVType;

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

		internal virtual TabControlAdv BindTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BindTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BindTabs = value;
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

		internal virtual Label lblQuery
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblQuery;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblQuery = value;
			}
		}

		internal virtual Label lblField
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblField;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblField = value;
			}
		}

		internal virtual Label lblUnit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUnit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUnit = value;
			}
		}

		internal virtual Label lblTemplate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTemplate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTemplate = value;
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

		public BindForm()
		{
			this.InitializeComponent();
			this.Init();
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
			this.BindTabs = new TabControlAdv();
			this.SystemDataTab = new TabPageAdv();
			this.lblField = new Label();
			this.lblQuery = new Label();
			this.EPRDataTab = new TabPageAdv();
			this.cbxVType = new ComboBox();
			this.lblVType = new Label();
			this.lblUnit = new Label();
			this.lblTemplate = new Label();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.BindTabs.SuspendLayout();
			this.SystemDataTab.SuspendLayout();
			this.EPRDataTab.SuspendLayout();
			this.SuspendLayout();
			this.BindTabs.Controls.Add(this.SystemDataTab);
			this.BindTabs.Controls.Add(this.EPRDataTab);
			Control arg_DD_0 = this.BindTabs;
			Point location = new Point(8, 16);
			arg_DD_0.Location = location;
			this.BindTabs.Name = "BindTabs";
			Control arg_10A_0 = this.BindTabs;
			Size size = new Size(424, 312);
			arg_10A_0.Size = size;
			this.BindTabs.TabIndex = 0;
			this.SystemDataTab.Controls.Add(this.lblField);
			this.SystemDataTab.Controls.Add(this.lblQuery);
			Control arg_158_0 = this.SystemDataTab;
			location = new Point(1, 28);
			arg_158_0.Location = location;
			this.SystemDataTab.Name = "SystemDataTab";
			Control arg_185_0 = this.SystemDataTab;
			size = new Size(421, 282);
			arg_185_0.Size = size;
			this.SystemDataTab.set_TabIndex(0);
			this.SystemDataTab.set_Text("系统数据");
			this.SystemDataTab.set_ThemesEnabled(false);
			Control arg_1C6_0 = this.lblField;
			location = new Point(216, 8);
			arg_1C6_0.Location = location;
			this.lblField.Name = "lblField";
			Control arg_1ED_0 = this.lblField;
			size = new Size(100, 16);
			arg_1ED_0.Size = size;
			this.lblField.TabIndex = 3;
			this.lblField.Text = "选择字段";
			Control arg_21F_0 = this.lblQuery;
			location = new Point(16, 8);
			arg_21F_0.Location = location;
			this.lblQuery.Name = "lblQuery";
			Control arg_246_0 = this.lblQuery;
			size = new Size(100, 16);
			arg_246_0.Size = size;
			this.lblQuery.TabIndex = 2;
			this.lblQuery.Text = "选择系统表";
			this.EPRDataTab.Controls.Add(this.cbxVType);
			this.EPRDataTab.Controls.Add(this.lblVType);
			this.EPRDataTab.Controls.Add(this.lblUnit);
			this.EPRDataTab.Controls.Add(this.lblTemplate);
			Control arg_2D0_0 = this.EPRDataTab;
			location = new Point(1, 28);
			arg_2D0_0.Location = location;
			this.EPRDataTab.Name = "EPRDataTab";
			Control arg_2FD_0 = this.EPRDataTab;
			size = new Size(421, 282);
			arg_2FD_0.Size = size;
			this.EPRDataTab.set_TabIndex(1);
			this.EPRDataTab.set_Text("病历数据");
			this.EPRDataTab.set_ThemesEnabled(false);
			Control arg_342_0 = this.cbxVType;
			location = new Point(224, 248);
			arg_342_0.Location = location;
			this.cbxVType.Name = "cbxVType";
			Control arg_369_0 = this.cbxVType;
			size = new Size(121, 20);
			arg_369_0.Size = size;
			this.cbxVType.TabIndex = 9;
			Control arg_390_0 = this.lblVType;
			location = new Point(96, 248);
			arg_390_0.Location = location;
			this.lblVType.Name = "lblVType";
			this.lblVType.TabIndex = 8;
			this.lblVType.Text = "设置取值类型";
			Control arg_3D6_0 = this.lblUnit;
			location = new Point(222, 15);
			arg_3D6_0.Location = location;
			this.lblUnit.Name = "lblUnit";
			Control arg_3FD_0 = this.lblUnit;
			size = new Size(100, 16);
			arg_3FD_0.Size = size;
			this.lblUnit.TabIndex = 7;
			this.lblUnit.Text = "选择单元";
			Control arg_430_0 = this.lblTemplate;
			location = new Point(22, 15);
			arg_430_0.Location = location;
			this.lblTemplate.Name = "lblTemplate";
			Control arg_457_0 = this.lblTemplate;
			size = new Size(100, 16);
			arg_457_0.Size = size;
			this.lblTemplate.TabIndex = 6;
			this.lblTemplate.Text = "选择模板";
			Control arg_490_0 = this.btnOK;
			location = new Point(200, 336);
			arg_490_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_4B7_0 = this.btnOK;
			size = new Size(64, 24);
			arg_4B7_0.Size = size;
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "确定";
			Control arg_4F0_0 = this.btnCancel;
			location = new Point(296, 336);
			arg_4F0_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_517_0 = this.btnCancel;
			size = new Size(64, 24);
			arg_517_0.Size = size;
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(450, 370);
			this.ClientSize = size;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.BindTabs);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "BindForm";
			this.Text = "选择绑定内容";
			this.BindTabs.ResumeLayout(false);
			this.SystemDataTab.ResumeLayout(false);
			this.EPRDataTab.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.UnitTree = new UnitTree();
			this.UnitTree.Left = 222;
			this.UnitTree.Top = 39;
			this.UnitTree.Width = 168;
			this.UnitTree.Height = 196;
			this.TemplateTree = new TemplateTree(TemplateTree.ShowLevel.OnlySingle);
			this.TemplateTree.Left = 22;
			this.TemplateTree.Top = 39;
			this.TemplateTree.Width = 168;
			this.TemplateTree.Height = 196;
			this.EPRDataTab.Controls.Add(this.TemplateTree);
			this.EPRDataTab.Controls.Add(this.UnitTree);
			this.TemplateTree.Init();
			this.FieldTree = new FieldTree();
			this.FieldTree.Left = 222;
			this.FieldTree.Top = 39;
			this.FieldTree.Width = 168;
			this.FieldTree.Height = 196;
			this.QueryTree = new QueryTree();
			this.QueryTree.Left = 22;
			this.QueryTree.Top = 39;
			this.QueryTree.Width = 168;
			this.QueryTree.Height = 196;
			this.SystemDataTab.Controls.Add(this.QueryTree);
			this.SystemDataTab.Controls.Add(this.FieldTree);
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
					if (!(metadataByTemplateID.MetaData == null | Operators.CompareString(metadataByTemplateID.MetaData, "", false) == 0))
					{
						this.UnitTree.ITVersion = metadataByTemplateID.VersionNumber.ToString();
						this.UnitTree.StrMetaData = metadataByTemplateID.MetaData;
					}
					return;
				}
				catch (Exception expr_C5)
				{
					ProjectData.SetProjectError(expr_C5);
					Exception ex = expr_C5;
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
				this._EPRBindCode = "";
			}
			else
			{
				this._EPRBindCode = Conversions.ToString(this.UnitTree.SelectedNode.Tag);
				this.SetVType(this._EPRBindCode);
				this._DataBaseBindCode = "";
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this._EPRBindCode != null)
			{
				string[] array = this._EPRBindCode.Split(new char[]
				{
					'#'
				});
				if (array.Length > 4)
				{
					string sourceItemCode = array[4].Split(new char[]
					{
						':'
					})[1];
					if (this._EPRBindCode != null && Operators.CompareString(this._EPRBindCode, "", false) != 0 && !this.CheckItemBind(sourceItemCode, this._TagItemCode))
					{
						MessageBox.Show("所选择的单元不允许绑定到目标单元，请重新选择！", "东华结构化电子病历");
						return;
					}
				}
			}
			this.DialogResult = DialogResult.OK;
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
	}
}
