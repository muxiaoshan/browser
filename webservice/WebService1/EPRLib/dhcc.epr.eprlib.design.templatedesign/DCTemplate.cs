using BindQueryData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.databind;
using dhcc.epr.eprlib.design.interfacedesign;
using dhcc.epr.eprlib.design.metadatadesign;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Reflection;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.templatedesign
{
	public class DCTemplate : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("DCTemplateTabs")]
		private TabControlAdv _DCTemplateTabs;

		[AccessedThroughProperty("MetaDataTab")]
		private TabPageAdv _MetaDataTab;

		[AccessedThroughProperty("InterfaceDesignTab")]
		private TabPageAdv _InterfaceDesignTab;

		[AccessedThroughProperty("InterfaceTab")]
		private TabPageAdv _InterfaceTab;

		[AccessedThroughProperty("designTimeTabTypeLoader")]
		private TypeLoader _designTimeTabTypeLoader;

		[AccessedThroughProperty("PanelMain")]
		private Panel _PanelMain;

		[AccessedThroughProperty("PanelTop")]
		private Panel _PanelTop;

		[AccessedThroughProperty("PanelParams")]
		private Panel _PanelParams;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("PanelCenter")]
		private Panel _PanelCenter;

		[AccessedThroughProperty("btnTest")]
		private Button _btnTest;

		[AccessedThroughProperty("dgParams")]
		private DataGrid _dgParams;

		[AccessedThroughProperty("DataGridTableStyle1")]
		private DataGridTableStyle _DataGridTableStyle1;

		[AccessedThroughProperty("NameColumn")]
		private DataGridTextBoxColumn _NameColumn;

		[AccessedThroughProperty("ValueColumn")]
		private DataGridTextBoxColumn _ValueColumn;

		private string _TemplateName;

		private string _TemplateDescription;

		private MMetaData _MetaData;

		private NInstanceData _InstanceData;

		private string _StrMetaData;

		private string _StrInitialData;

		private string _StrPresentationData;

		[AccessedThroughProperty("DCMetaData")]
		private DCMetaData _DCMetaData;

		[AccessedThroughProperty("DCInterface")]
		private DCInterface _DCInterface;

		[AccessedThroughProperty("PInterface")]
		private PInterface _PInterface;

		private bool _IsChanged;

		private Hashtable htTestParams;

		private string _BeginMmXml;

		private string _EndMmXml;

		private string _BeginInXml;

		private string _EndInXml;

		private string _BeginPcXml;

		private string _EndPcXml;

		internal virtual TabControlAdv DCTemplateTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCTemplateTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DCTemplateTabs_SelectedIndexChanged);
				if (this._DCTemplateTabs != null)
				{
					this._DCTemplateTabs.remove_SelectedIndexChanged(eventHandler);
				}
				this._DCTemplateTabs = value;
				if (this._DCTemplateTabs != null)
				{
					this._DCTemplateTabs.add_SelectedIndexChanged(eventHandler);
				}
			}
		}

		internal virtual TabPageAdv MetaDataTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetaDataTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetaDataTab = value;
			}
		}

		internal virtual TabPageAdv InterfaceDesignTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._InterfaceDesignTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._InterfaceDesignTab = value;
			}
		}

		internal virtual TabPageAdv InterfaceTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._InterfaceTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._InterfaceTab = value;
			}
		}

		internal virtual TypeLoader designTimeTabTypeLoader
		{
			[DebuggerNonUserCode]
			get
			{
				return this._designTimeTabTypeLoader;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._designTimeTabTypeLoader = value;
			}
		}

		internal virtual Panel PanelMain
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelMain;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelMain = value;
			}
		}

		internal virtual Panel PanelTop
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelTop;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelTop = value;
			}
		}

		internal virtual Panel PanelParams
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelParams;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelParams = value;
			}
		}

		internal virtual Splitter Splitter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Splitter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter1 = value;
			}
		}

		internal virtual Panel PanelCenter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelCenter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelCenter = value;
			}
		}

		internal virtual Button btnTest
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTest;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTest_Click);
				if (this._btnTest != null)
				{
					this._btnTest.Click -= value2;
				}
				this._btnTest = value;
				if (this._btnTest != null)
				{
					this._btnTest.Click += value2;
				}
			}
		}

		internal virtual DataGrid dgParams
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgParams;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgParams = value;
			}
		}

		internal virtual DataGridTableStyle DataGridTableStyle1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGridTableStyle1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridTableStyle1 = value;
			}
		}

		internal virtual DataGridTextBoxColumn NameColumn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NameColumn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NameColumn = value;
			}
		}

		internal virtual DataGridTextBoxColumn ValueColumn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ValueColumn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ValueColumn = value;
			}
		}

		public virtual DCMetaData DCMetaData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCMetaData;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCMetaData = value;
			}
		}

		public virtual DCInterface DCInterface
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCInterface;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCInterface = value;
			}
		}

		public virtual PInterface PInterface
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PInterface;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PInterface = value;
			}
		}

		public EPRStatus Status
		{
			get
			{
				return this._MetaData.Status;
			}
			set
			{
				this._MetaData.Status = value;
				if (this._MetaData.Status == EPRStatus.Publish)
				{
					this.DCMetaData.NamePanel.Enabled = false;
					this.DCMetaData.PrivatePropertyPanel.Enabled = false;
					this.DCInterface.downDesignPanel.Enabled = false;
				}
			}
		}

		public string TemplateName
		{
			get
			{
				return this._TemplateName;
			}
			set
			{
				this._TemplateName = value;
			}
		}

		public string TemplateDescription
		{
			get
			{
				return this._TemplateDescription;
			}
			set
			{
				this._TemplateDescription = value;
			}
		}

		public string StrMetaData
		{
			get
			{
				return this._MetaData.XMLString;
			}
			set
			{
				this._StrMetaData = value;
				if (value == null | Operators.CompareString(value, "", false) == 0)
				{
					this._MetaData = new MMetaData();
					this._MetaData.Init();
					this._MetaData.Text = this._TemplateName;
					this._MetaData.Description = this._TemplateDescription;
				}
				else
				{
					this._MetaData = new MMetaData();
					this._MetaData.XMLString = value;
				}
				this.DCMetaData.MetaItem = this._MetaData;
				this.DCInterface.MetaData = this._MetaData;
				this.PInterface.MetaData = this._MetaData;
				this.DCMetaData.BindKB = this._MetaData.BindKB;
				this.DCMetaData.BindKBCode = this._MetaData.BindKBCode;
				this.DCMetaData.BindKBName = this._MetaData.BindKBName;
			}
		}

		public string StrInitialData
		{
			get
			{
				return this._InstanceData.XMLString;
			}
			set
			{
				this._StrInitialData = value;
				if (value == null | Operators.CompareString(value, "", false) == 0)
				{
					this._InstanceData = new NInstanceData();
					this._InstanceData.Code = this._MetaData.Code;
					this._InstanceData.SyncMetaItem(this._MetaData);
				}
				else
				{
					this._InstanceData = new NInstanceData();
					this._InstanceData.XMLString = this._StrInitialData;
					this._InstanceData.SyncMetaItem(this._MetaData);
				}
				this.DCMetaData.InstanceItem = this._InstanceData;
				this.DCInterface.InstanceData = this._InstanceData;
				this.PInterface.InstanceData = this._InstanceData;
			}
		}

		public string StrPresentationData
		{
			get
			{
				return this.DCInterface.DesignPanel.XMLString;
			}
			set
			{
				if (!(value == null | Operators.CompareString(value, "", false) == 0))
				{
					this.DCInterface.DesignPanel.XMLString = value;
					this.DCInterface.DesignPanel.BindInstance();
				}
			}
		}

		public bool IsChanged
		{
			get
			{
				return this._IsChanged;
			}
			set
			{
				this._IsChanged = value;
			}
		}

		public string BeginMetaDataXml
		{
			get
			{
				return this._BeginMmXml;
			}
			set
			{
				this._BeginMmXml = value;
			}
		}

		public string EndMetaDataXml
		{
			get
			{
				return this._EndMmXml;
			}
			set
			{
				this._EndMmXml = value;
			}
		}

		public string BeginInitialDataXml
		{
			get
			{
				return this._BeginInXml;
			}
			set
			{
				this._BeginInXml = value;
			}
		}

		public string EndInitialDataXml
		{
			get
			{
				return this._EndInXml;
			}
			set
			{
				this._EndInXml = value;
			}
		}

		public string BeginPresentationDataXml
		{
			get
			{
				return this._BeginPcXml;
			}
			set
			{
				this._BeginPcXml = value;
			}
		}

		public string EndPresentationDataXml
		{
			get
			{
				return this._EndPcXml;
			}
			set
			{
				this._EndPcXml = value;
			}
		}

		public DCTemplate()
		{
			this.htTestParams = new Hashtable();
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
			this.components = new Container();
			this.DCTemplateTabs = new TabControlAdv();
			this.MetaDataTab = new TabPageAdv();
			this.InterfaceDesignTab = new TabPageAdv();
			this.InterfaceTab = new TabPageAdv();
			this.PanelMain = new Panel();
			this.PanelCenter = new Panel();
			this.Splitter1 = new Splitter();
			this.PanelParams = new Panel();
			this.btnTest = new Button();
			this.dgParams = new DataGrid();
			this.DataGridTableStyle1 = new DataGridTableStyle();
			this.NameColumn = new DataGridTextBoxColumn();
			this.ValueColumn = new DataGridTextBoxColumn();
			this.PanelTop = new Panel();
			this.designTimeTabTypeLoader = new TypeLoader(this.components);
			this.DCTemplateTabs.BeginInit();
			this.DCTemplateTabs.SuspendLayout();
			this.InterfaceTab.SuspendLayout();
			this.PanelMain.SuspendLayout();
			this.PanelParams.SuspendLayout();
			((ISupportInitialize)this.dgParams).BeginInit();
			this.SuspendLayout();
			this.DCTemplateTabs.set_BorderStyle(BorderStyle.None);
			this.DCTemplateTabs.Controls.Add(this.MetaDataTab);
			this.DCTemplateTabs.Controls.Add(this.InterfaceDesignTab);
			this.DCTemplateTabs.Controls.Add(this.InterfaceTab);
			this.DCTemplateTabs.Dock = DockStyle.Fill;
			Control arg_168_0 = this.DCTemplateTabs;
			Point location = new Point(0, 0);
			arg_168_0.Location = location;
			this.DCTemplateTabs.Name = "DCTemplateTabs";
			Control arg_195_0 = this.DCTemplateTabs;
			Size size = new Size(700, 400);
			arg_195_0.Size = size;
			this.DCTemplateTabs.TabIndex = 0;
			this.DCTemplateTabs.set_TabStyle(typeof(TabRenderer2D));
			Control arg_1CC_0 = this.MetaDataTab;
			location = new Point(0, 20);
			arg_1CC_0.Location = location;
			this.MetaDataTab.Name = "MetaDataTab";
			Control arg_1F9_0 = this.MetaDataTab;
			size = new Size(700, 380);
			arg_1F9_0.Size = size;
			this.MetaDataTab.set_TabIndex(1);
			this.MetaDataTab.set_Text("元数据");
			this.MetaDataTab.set_ThemesEnabled(false);
			Control arg_237_0 = this.InterfaceDesignTab;
			location = new Point(0, 20);
			arg_237_0.Location = location;
			this.InterfaceDesignTab.Name = "InterfaceDesignTab";
			Control arg_264_0 = this.InterfaceDesignTab;
			size = new Size(700, 380);
			arg_264_0.Size = size;
			this.InterfaceDesignTab.set_TabIndex(1);
			this.InterfaceDesignTab.set_Text("界面设计");
			this.InterfaceDesignTab.set_ThemesEnabled(false);
			this.InterfaceTab.Controls.Add(this.PanelMain);
			Control arg_2B8_0 = this.InterfaceTab;
			location = new Point(0, 20);
			arg_2B8_0.Location = location;
			this.InterfaceTab.Name = "InterfaceTab";
			Control arg_2E5_0 = this.InterfaceTab;
			size = new Size(700, 380);
			arg_2E5_0.Size = size;
			this.InterfaceTab.set_TabIndex(2);
			this.InterfaceTab.set_Text("界面显示");
			this.InterfaceTab.set_ThemesEnabled(false);
			this.PanelMain.Controls.Add(this.PanelCenter);
			this.PanelMain.Controls.Add(this.Splitter1);
			this.PanelMain.Controls.Add(this.PanelParams);
			this.PanelMain.Controls.Add(this.PanelTop);
			this.PanelMain.Dock = DockStyle.Fill;
			Control arg_386_0 = this.PanelMain;
			location = new Point(0, 0);
			arg_386_0.Location = location;
			this.PanelMain.Name = "PanelMain";
			Control arg_3B3_0 = this.PanelMain;
			size = new Size(700, 380);
			arg_3B3_0.Size = size;
			this.PanelMain.TabIndex = 0;
			this.PanelCenter.BorderStyle = BorderStyle.FixedSingle;
			this.PanelCenter.Dock = DockStyle.Fill;
			Control arg_3F1_0 = this.PanelCenter;
			location = new Point(208, 24);
			arg_3F1_0.Location = location;
			this.PanelCenter.Name = "PanelCenter";
			Control arg_41E_0 = this.PanelCenter;
			size = new Size(492, 356);
			arg_41E_0.Size = size;
			this.PanelCenter.TabIndex = 3;
			Control arg_444_0 = this.Splitter1;
			location = new Point(200, 24);
			arg_444_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_46D_0 = this.Splitter1;
			size = new Size(8, 356);
			arg_46D_0.Size = size;
			this.Splitter1.TabIndex = 2;
			this.Splitter1.TabStop = false;
			this.PanelParams.BorderStyle = BorderStyle.FixedSingle;
			this.PanelParams.Controls.Add(this.btnTest);
			this.PanelParams.Controls.Add(this.dgParams);
			this.PanelParams.Dock = DockStyle.Left;
			Control arg_4DF_0 = this.PanelParams;
			location = new Point(0, 24);
			arg_4DF_0.Location = location;
			this.PanelParams.Name = "PanelParams";
			Control arg_50C_0 = this.PanelParams;
			size = new Size(200, 356);
			arg_50C_0.Size = size;
			this.PanelParams.TabIndex = 1;
			Control arg_531_0 = this.btnTest;
			location = new Point(0, 192);
			arg_531_0.Location = location;
			this.btnTest.Name = "btnTest";
			Control arg_558_0 = this.btnTest;
			size = new Size(75, 23);
			arg_558_0.Size = size;
			this.btnTest.TabIndex = 1;
			this.btnTest.Text = "测试绑定";
			this.dgParams.DataMember = "";
			this.dgParams.Dock = DockStyle.Top;
			this.dgParams.HeaderForeColor = SystemColors.ControlText;
			Control arg_5B5_0 = this.dgParams;
			location = new Point(0, 0);
			arg_5B5_0.Location = location;
			this.dgParams.Name = "dgParams";
			this.dgParams.RowHeaderWidth = 10;
			Control arg_5EF_0 = this.dgParams;
			size = new Size(198, 188);
			arg_5EF_0.Size = size;
			this.dgParams.TabIndex = 0;
			this.dgParams.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.DataGridTableStyle1
			});
			this.DataGridTableStyle1.DataGrid = this.dgParams;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.NameColumn,
				this.ValueColumn
			});
			this.DataGridTableStyle1.HeaderForeColor = SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "dtParameters";
			this.DataGridTableStyle1.RowHeaderWidth = 10;
			this.NameColumn.Format = "";
			this.NameColumn.FormatInfo = null;
			this.NameColumn.HeaderText = "参数名称";
			this.NameColumn.MappingName = "Name";
			this.NameColumn.NullText = "";
			this.NameColumn.Width = 92;
			this.ValueColumn.Format = "";
			this.ValueColumn.FormatInfo = null;
			this.ValueColumn.HeaderText = "参数值";
			this.ValueColumn.MappingName = "Value";
			this.ValueColumn.NullText = "";
			this.ValueColumn.Width = 86;
			this.PanelTop.Dock = DockStyle.Top;
			Control arg_757_0 = this.PanelTop;
			location = new Point(0, 0);
			arg_757_0.Location = location;
			this.PanelTop.Name = "PanelTop";
			Control arg_781_0 = this.PanelTop;
			size = new Size(700, 24);
			arg_781_0.Size = size;
			this.PanelTop.TabIndex = 0;
			this.designTimeTabTypeLoader.set_InvokeMemberName("TabStyleName");
			this.Controls.Add(this.DCTemplateTabs);
			this.Name = "DCTemplate";
			size = new Size(700, 400);
			this.Size = size;
			this.DCTemplateTabs.EndInit();
			this.DCTemplateTabs.ResumeLayout(false);
			this.InterfaceTab.ResumeLayout(false);
			this.PanelMain.ResumeLayout(false);
			this.PanelParams.ResumeLayout(false);
			((ISupportInitialize)this.dgParams).EndInit();
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.DCMetaData = new DCMetaData();
			this.DCMetaData.Dock = DockStyle.Fill;
			this.MetaDataTab.Controls.Add(this.DCMetaData);
			this.DCInterface = new DCInterface();
			this.DCInterface.Dock = DockStyle.Fill;
			this.InterfaceDesignTab.Controls.Add(this.DCInterface);
			this.PInterface = new PInterface();
			this.PInterface.Dock = DockStyle.Fill;
			this.PanelCenter.Controls.Add(this.PInterface);
		}

		private void DCTemplateTabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.DCTemplateTabs.get_SelectedIndex() == 1)
				{
					string xMLString = this._MetaData.XMLString;
					this.DCInterface.RefreshContentList();
					this.DCInterface.DesignPanel.BindInstance();
				}
				else if (this.DCTemplateTabs.get_SelectedIndex() == 2)
				{
					this.BindParameters();
					if (!this._MetaData.BindKB)
					{
						if (this.PInterface.KBSupport)
						{
							this.PInterface.MetaData = this._MetaData;
						}
					}
					else if (!this.PInterface.KBSupport)
					{
						this.PInterface.MetaData = this._MetaData;
					}
					this.PInterface.InstanceData = this._InstanceData;
					this.PInterface.StrPresentation = this.DCInterface.DesignPanel.XMLString;
				}
			}
			catch (Exception expr_D2)
			{
				ProjectData.SetProjectError(expr_D2);
				Exception ex = expr_D2;
				throw ex;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			int num = 0;
			int arg_12_0 = 0;
			checked
			{
				int num2 = this.dgParams.VisibleRowCount - 2;
				for (int i = arg_12_0; i <= num2; i++)
				{
					string text = Conversions.ToString(this.dgParams[i, 0]).Trim();
					string text2 = Conversions.ToString(this.dgParams[i, 1]).Trim();
					if (Operators.CompareString(text, "", false) != 0 & Operators.CompareString(text2, "", false) != 0)
					{
						if (!this.htTestParams.ContainsKey(text))
						{
							this.htTestParams.Add(text, text2);
						}
						GlobalValues.AddKeyValue(text, text2);
						num++;
					}
				}
				if (num == 0)
				{
					MessageManager.ShowInformationMessage("请输入参数进行模板绑定测试！");
					return;
				}
				PInterface pInterface = new PInterface();
				MMetaData mMetaData = new MMetaData();
				mMetaData.XMLString = this.PInterface.MetaData.XMLString;
				NInstanceData nInstanceData = new NInstanceData();
				nInstanceData.XMLString = this.PInterface.InstanceData.XMLString;
				nInstanceData.SyncMetaItem(mMetaData);
				pInterface.MetaData = mMetaData;
				pInterface.InstanceData = nInstanceData;
				pInterface.StrPresentation = this.StrPresentationData;
				DataBindUtil dataBindUtil = new DataBindUtil(pInterface.InstanceData);
				dataBindUtil.SystemDataBind();
				dataBindUtil.EPRDataBind();
				pInterface.BindInstance();
				Form form = new Form();
				form.StartPosition = FormStartPosition.CenterParent;
				form.ShowInTaskbar = false;
				form.Text = this.TemplateName + "(绑定测试)";
				Form arg_182_0 = form;
				Size size = new Size(800, 600);
				arg_182_0.Size = size;
				form.MaximizeBox = false;
				form.MinimizeBox = false;
				pInterface.Dock = DockStyle.Fill;
				form.Controls.Add(pInterface);
				form.FormClosed += new FormClosedEventHandler(this.TestForm_Closed);
				form.ShowDialog();
			}
		}

		private void BindParameters()
		{
			EDataBindDisDataSet eDataBindDisDataSet = WebServiceLayer.BindQueryAccess.SelectDistinctParameter();
			DataTable dataTable = new DataTable("dtParameters");
			DataColumn dataColumn = new DataColumn();
			dataColumn.DataType = Type.GetType("System.String");
			dataColumn.ColumnName = "Name";
			dataColumn.Unique = true;
			dataTable.Columns.Add(dataColumn);
			DataColumn dataColumn2 = new DataColumn();
			dataColumn2.DataType = Type.GetType("System.String");
			dataColumn2.ColumnName = "Value";
			dataColumn2.DefaultValue = "";
			dataTable.Columns.Add(dataColumn2);
			try
			{
				IEnumerator enumerator = eDataBindDisDataSet.Tables[0].Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					EDataBindDisDataSet.SelectDistinctParameterRow selectDistinctParameterRow = (EDataBindDisDataSet.SelectDistinctParameterRow)enumerator.Current;
					DataRow dataRow = dataTable.NewRow();
					dataRow["Name"] = selectDistinctParameterRow.ParameterName;
					dataTable.Rows.Add(dataRow);
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
			this.dgParams.DataSource = dataTable;
		}

		private void TestForm_Closed(object sender, EventArgs e)
		{
			if (this.htTestParams != null && this.htTestParams.Count > 0)
			{
				try
				{
					IEnumerator enumerator = this.htTestParams.Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (Conversions.ToBoolean(GlobalValues.GetValueByKey(Conversions.ToString(objectValue))))
						{
							GlobalValues.RemoveByKey(Conversions.ToString(objectValue));
						}
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
}
