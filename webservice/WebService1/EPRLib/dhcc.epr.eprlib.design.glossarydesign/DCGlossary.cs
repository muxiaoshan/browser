using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.printlink;
using dhcc.epr.systemframework;
using GlossaryData;
using InterfaceTemplateData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.glossarydesign
{
	public class DCGlossary : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("mainPanel")]
		private Panel _mainPanel;

		[AccessedThroughProperty("GlossaryNodePanel")]
		private Panel _GlossaryNodePanel;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("ITemplatePanel")]
		private Panel _ITemplatePanel;

		[AccessedThroughProperty("gbxGlossary")]
		private GroupBox _gbxGlossary;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("txtNodeDesc")]
		private TextBox _txtNodeDesc;

		[AccessedThroughProperty("txtNodeName")]
		private TextBox _txtNodeName;

		[AccessedThroughProperty("lblGlossaryItems")]
		private Label _lblGlossaryItems;

		[AccessedThroughProperty("lblNodeDesc")]
		private Label _lblNodeDesc;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("pnlItem")]
		private Panel _pnlItem;

		[AccessedThroughProperty("gbxValueType")]
		private GroupBox _gbxValueType;

		[AccessedThroughProperty("pnlCategory")]
		private Panel _pnlCategory;

		[AccessedThroughProperty("cbxValueType")]
		private ComboBox _cbxValueType;

		[AccessedThroughProperty("lblItemType")]
		private Label _lblItemType;

		[AccessedThroughProperty("ctxMenu")]
		private ContextMenu _ctxMenu;

		private const string CHOICE_VALUE = "值";

		private const string CHOICE_CODE = "代码";

		private const string QUANTITY_VALUE = "值";

		private const string QUANTITY_CODE = "单位";

		private const string VALUE = "值";

		private const string DICTIONARY_VALUE = "说明";

		private const string DICTIONARY_CODE = "代码";

		private const string DATETIME_VALUE = "标准日期格式";

		private const string DATETIME_YMD = "年月日";

		private const string DATETIME_HMS = "时分秒";

		private const string DATETIME_YEAR = "年";

		private const string DATETIME_MONTH = "月";

		private const string DATETIME_DAY = "日";

		private const string DATETIME_HOUR = "时";

		private const string DATETIME_MINUTE = "分";

		private const string DATETIME_SECOND = "秒";

		private const string DATETIME_DTVALUE = "值";

		private const string DATETIME_DTCODE = "代码";

		private string m_GlossaryID;

		private string m_GlossaryType;

		private string m_ContextGlossaryID;

		private EGlossary m_EGlossary;

		[AccessedThroughProperty("tvTemplates")]
		private TemplateTree _tvTemplates;

		[AccessedThroughProperty("tvUnits")]
		private PrintUnitTree _tvUnits;

		[AccessedThroughProperty("tvGlossaryUnits")]
		private GlossaryUnitTree _tvGlossaryUnits;

		[AccessedThroughProperty("btnSelectKBNode")]
		private Button _btnSelectKBNode;

		[AccessedThroughProperty("cbxKBPart")]
		private ComboBox _cbxKBPart;

		[AccessedThroughProperty("tvKBNodes")]
		private KBNodeTree _tvKBNodes;

		[AccessedThroughProperty("tvKBUnits")]
		private KBUnitTree _tvKBUnits;

		private TreeNode m_MetaNode;

		private TreeNode m_KBMetaNode;

		private TreeNode m_GlossaryNode;

		private TreeNode m_DataTypeNode;

		private MenuItem miDelItem;

		internal virtual Panel mainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mainPanel = value;
			}
		}

		internal virtual Panel GlossaryNodePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GlossaryNodePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GlossaryNodePanel = value;
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

		internal virtual Panel ITemplatePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ITemplatePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ITemplatePanel = value;
			}
		}

		internal virtual GroupBox gbxGlossary
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxGlossary;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxGlossary = value;
			}
		}

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

		internal virtual TextBox txtNodeDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtNodeDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtNodeDesc = value;
			}
		}

		internal virtual TextBox txtNodeName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtNodeName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtNodeName = value;
			}
		}

		internal virtual Label lblGlossaryItems
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblGlossaryItems;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblGlossaryItems = value;
			}
		}

		internal virtual Label lblNodeDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblNodeDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNodeDesc = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Panel pnlItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pnlItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlItem = value;
			}
		}

		internal virtual GroupBox gbxValueType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxValueType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxValueType = value;
			}
		}

		internal virtual Panel pnlCategory
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pnlCategory;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlCategory = value;
			}
		}

		internal virtual ComboBox cbxValueType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxValueType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbxValueType = value;
			}
		}

		internal virtual Label lblItemType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblItemType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblItemType = value;
			}
		}

		internal virtual ContextMenu ctxMenu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ctxMenu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ctxMenu = value;
			}
		}

		public virtual TemplateTree tvTemplates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvTemplates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.tvTemplates_AfterSelect);
				if (this._tvTemplates != null)
				{
					this._tvTemplates.AfterSelect -= value2;
				}
				this._tvTemplates = value;
				if (this._tvTemplates != null)
				{
					this._tvTemplates.AfterSelect += value2;
				}
			}
		}

		public virtual PrintUnitTree tvUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.tvUnits_MouseDown);
				if (this._tvUnits != null)
				{
					this._tvUnits.MouseDown -= value2;
				}
				this._tvUnits = value;
				if (this._tvUnits != null)
				{
					this._tvUnits.MouseDown += value2;
				}
			}
		}

		public virtual GlossaryUnitTree tvGlossaryUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvGlossaryUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.tvGlossaryUnits_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.tvGlossaryUnits_DragEnter);
				MouseEventHandler value4 = new MouseEventHandler(this.tvGlossaryUnits_MouseDown);
				if (this._tvGlossaryUnits != null)
				{
					this._tvGlossaryUnits.DragDrop -= value2;
					this._tvGlossaryUnits.DragEnter -= value3;
					this._tvGlossaryUnits.MouseDown -= value4;
				}
				this._tvGlossaryUnits = value;
				if (this._tvGlossaryUnits != null)
				{
					this._tvGlossaryUnits.DragDrop += value2;
					this._tvGlossaryUnits.DragEnter += value3;
					this._tvGlossaryUnits.MouseDown += value4;
				}
			}
		}

		public virtual Button btnSelectKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSelectKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSelectKBNode_Click);
				if (this._btnSelectKBNode != null)
				{
					this._btnSelectKBNode.Click -= value2;
				}
				this._btnSelectKBNode = value;
				if (this._btnSelectKBNode != null)
				{
					this._btnSelectKBNode.Click += value2;
				}
			}
		}

		public virtual ComboBox cbxKBPart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxKBPart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxKBPart_SelectedIndexChanged);
				if (this._cbxKBPart != null)
				{
					this._cbxKBPart.SelectedIndexChanged -= value2;
				}
				this._cbxKBPart = value;
				if (this._cbxKBPart != null)
				{
					this._cbxKBPart.SelectedIndexChanged += value2;
				}
			}
		}

		public virtual KBNodeTree tvKBNodes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvKBNodes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.tvKBNodes_AfterSelect);
				if (this._tvKBNodes != null)
				{
					this._tvKBNodes.AfterSelect -= value2;
				}
				this._tvKBNodes = value;
				if (this._tvKBNodes != null)
				{
					this._tvKBNodes.AfterSelect += value2;
				}
			}
		}

		public virtual KBUnitTree tvKBUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvKBUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.tvKBUnits_MouseDown);
				if (this._tvKBUnits != null)
				{
					this._tvKBUnits.MouseDown -= value2;
				}
				this._tvKBUnits = value;
				if (this._tvKBUnits != null)
				{
					this._tvKBUnits.MouseDown += value2;
				}
			}
		}

		public string GlossaryID
		{
			get
			{
				return this.m_GlossaryID;
			}
			set
			{
				this.m_GlossaryID = value;
				this.InitGlossaryUnitTree(this.m_GlossaryID);
				this.txtNodeName.Text = this.m_EGlossary.Name;
				this.txtNodeDesc.Text = this.m_EGlossary.Description;
				this.txtNodeName.ReadOnly = true;
				this.txtNodeDesc.ReadOnly = true;
			}
		}

		public string GlossaryType
		{
			get
			{
				return this.m_GlossaryType;
			}
			set
			{
				this.m_GlossaryType = value;
			}
		}

		public string ContextGlossaryID
		{
			get
			{
				return this.m_ContextGlossaryID;
			}
			set
			{
				this.m_ContextGlossaryID = value;
			}
		}

		public DCGlossary()
		{
			base.Load += new EventHandler(this.DCGlossary_Load);
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
			this.mainPanel = new Panel();
			this.GlossaryNodePanel = new Panel();
			this.gbxGlossary = new GroupBox();
			this.btnSave = new Button();
			this.txtNodeDesc = new TextBox();
			this.txtNodeName = new TextBox();
			this.lblGlossaryItems = new Label();
			this.lblNodeDesc = new Label();
			this.Label1 = new Label();
			this.Splitter1 = new Splitter();
			this.ITemplatePanel = new Panel();
			this.pnlItem = new Panel();
			this.gbxValueType = new GroupBox();
			this.cbxValueType = new ComboBox();
			this.lblItemType = new Label();
			this.pnlCategory = new Panel();
			this.ctxMenu = new ContextMenu();
			this.mainPanel.SuspendLayout();
			this.GlossaryNodePanel.SuspendLayout();
			this.gbxGlossary.SuspendLayout();
			this.ITemplatePanel.SuspendLayout();
			this.gbxValueType.SuspendLayout();
			this.SuspendLayout();
			this.mainPanel.Controls.Add(this.GlossaryNodePanel);
			this.mainPanel.Controls.Add(this.Splitter1);
			this.mainPanel.Controls.Add(this.ITemplatePanel);
			this.mainPanel.Dock = DockStyle.Fill;
			Control arg_156_0 = this.mainPanel;
			Point location = new Point(0, 0);
			arg_156_0.Location = location;
			this.mainPanel.Name = "mainPanel";
			Control arg_183_0 = this.mainPanel;
			Size size = new Size(800, 610);
			arg_183_0.Size = size;
			this.mainPanel.TabIndex = 0;
			this.GlossaryNodePanel.Controls.Add(this.gbxGlossary);
			this.GlossaryNodePanel.Dock = DockStyle.Fill;
			Control arg_1CA_0 = this.GlossaryNodePanel;
			location = new Point(363, 0);
			arg_1CA_0.Location = location;
			this.GlossaryNodePanel.Name = "GlossaryNodePanel";
			Control arg_1F7_0 = this.GlossaryNodePanel;
			size = new Size(437, 610);
			arg_1F7_0.Size = size;
			this.GlossaryNodePanel.TabIndex = 2;
			this.gbxGlossary.Controls.Add(this.btnSave);
			this.gbxGlossary.Controls.Add(this.txtNodeDesc);
			this.gbxGlossary.Controls.Add(this.txtNodeName);
			this.gbxGlossary.Controls.Add(this.lblGlossaryItems);
			this.gbxGlossary.Controls.Add(this.lblNodeDesc);
			this.gbxGlossary.Controls.Add(this.Label1);
			this.gbxGlossary.Dock = DockStyle.Fill;
			Control arg_2A8_0 = this.gbxGlossary;
			location = new Point(0, 0);
			arg_2A8_0.Location = location;
			this.gbxGlossary.Name = "gbxGlossary";
			Control arg_2D5_0 = this.gbxGlossary;
			size = new Size(437, 610);
			arg_2D5_0.Size = size;
			this.gbxGlossary.TabIndex = 0;
			this.gbxGlossary.TabStop = false;
			this.gbxGlossary.Text = "术语信息";
			this.btnSave.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_324_0 = this.btnSave;
			location = new Point(356, 20);
			arg_324_0.Location = location;
			this.btnSave.Name = "btnSave";
			Control arg_34B_0 = this.btnSave;
			size = new Size(75, 23);
			arg_34B_0.Size = size;
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.txtNodeDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_397_0 = this.txtNodeDesc;
			location = new Point(87, 47);
			arg_397_0.Location = location;
			this.txtNodeDesc.Multiline = true;
			this.txtNodeDesc.Name = "txtNodeDesc";
			Control arg_3CD_0 = this.txtNodeDesc;
			size = new Size(344, 43);
			arg_3CD_0.Size = size;
			this.txtNodeDesc.TabIndex = 4;
			this.txtNodeName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_3FD_0 = this.txtNodeName;
			location = new Point(87, 20);
			arg_3FD_0.Location = location;
			this.txtNodeName.Name = "txtNodeName";
			Control arg_427_0 = this.txtNodeName;
			size = new Size(263, 21);
			arg_427_0.Size = size;
			this.txtNodeName.TabIndex = 3;
			this.lblGlossaryItems.AutoSize = true;
			Control arg_456_0 = this.lblGlossaryItems;
			location = new Point(16, 101);
			arg_456_0.Location = location;
			this.lblGlossaryItems.Name = "lblGlossaryItems";
			Control arg_47D_0 = this.lblGlossaryItems;
			size = new Size(65, 12);
			arg_47D_0.Size = size;
			this.lblGlossaryItems.TabIndex = 2;
			this.lblGlossaryItems.Text = "术语项目：";
			this.lblNodeDesc.AutoSize = true;
			Control arg_4BC_0 = this.lblNodeDesc;
			location = new Point(16, 51);
			arg_4BC_0.Location = location;
			this.lblNodeDesc.Name = "lblNodeDesc";
			Control arg_4E3_0 = this.lblNodeDesc;
			size = new Size(65, 12);
			arg_4E3_0.Size = size;
			this.lblNodeDesc.TabIndex = 1;
			this.lblNodeDesc.Text = "术语描述：";
			this.Label1.AutoSize = true;
			Control arg_522_0 = this.Label1;
			location = new Point(16, 24);
			arg_522_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_549_0 = this.Label1;
			size = new Size(65, 12);
			arg_549_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "术语名称：";
			Control arg_57E_0 = this.Splitter1;
			location = new Point(360, 0);
			arg_57E_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_5A7_0 = this.Splitter1;
			size = new Size(3, 610);
			arg_5A7_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.ITemplatePanel.Controls.Add(this.pnlItem);
			this.ITemplatePanel.Controls.Add(this.gbxValueType);
			this.ITemplatePanel.Controls.Add(this.pnlCategory);
			this.ITemplatePanel.Dock = DockStyle.Left;
			Control arg_622_0 = this.ITemplatePanel;
			location = new Point(0, 0);
			arg_622_0.Location = location;
			this.ITemplatePanel.Name = "ITemplatePanel";
			Control arg_64F_0 = this.ITemplatePanel;
			size = new Size(360, 610);
			arg_64F_0.Size = size;
			this.ITemplatePanel.TabIndex = 0;
			this.pnlItem.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_681_0 = this.pnlItem;
			location = new Point(3, 328);
			arg_681_0.Location = location;
			this.pnlItem.Name = "pnlItem";
			Control arg_6AE_0 = this.pnlItem;
			size = new Size(354, 278);
			arg_6AE_0.Size = size;
			this.pnlItem.TabIndex = 2;
			this.gbxValueType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.gbxValueType.Controls.Add(this.cbxValueType);
			this.gbxValueType.Controls.Add(this.lblItemType);
			Control arg_70C_0 = this.gbxValueType;
			location = new Point(3, 279);
			arg_70C_0.Location = location;
			this.gbxValueType.Name = "gbxValueType";
			Control arg_736_0 = this.gbxValueType;
			size = new Size(354, 43);
			arg_736_0.Size = size;
			this.gbxValueType.TabIndex = 1;
			this.gbxValueType.TabStop = false;
			this.gbxValueType.Text = "设置单元取值类型";
			this.cbxValueType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxValueType.FormattingEnabled = true;
			Control arg_78D_0 = this.cbxValueType;
			location = new Point(106, 17);
			arg_78D_0.Location = location;
			this.cbxValueType.Name = "cbxValueType";
			Control arg_7B4_0 = this.cbxValueType;
			size = new Size(123, 20);
			arg_7B4_0.Size = size;
			this.cbxValueType.TabIndex = 1;
			this.lblItemType.AutoSize = true;
			Control arg_7E3_0 = this.lblItemType;
			location = new Point(11, 20);
			arg_7E3_0.Location = location;
			this.lblItemType.Name = "lblItemType";
			Control arg_80A_0 = this.lblItemType;
			size = new Size(89, 12);
			arg_80A_0.Size = size;
			this.lblItemType.TabIndex = 0;
			this.lblItemType.Text = "单元取值类型：";
			this.lblItemType.TextAlign = ContentAlignment.MiddleLeft;
			this.pnlCategory.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_855_0 = this.pnlCategory;
			location = new Point(3, 3);
			arg_855_0.Location = location;
			this.pnlCategory.Name = "pnlCategory";
			Control arg_882_0 = this.pnlCategory;
			size = new Size(354, 274);
			arg_882_0.Size = size;
			this.pnlCategory.TabIndex = 0;
			this.Controls.Add(this.mainPanel);
			this.Name = "DCGlossary";
			size = new Size(800, 610);
			this.Size = size;
			this.mainPanel.ResumeLayout(false);
			this.GlossaryNodePanel.ResumeLayout(false);
			this.gbxGlossary.ResumeLayout(false);
			this.gbxGlossary.PerformLayout();
			this.ITemplatePanel.ResumeLayout(false);
			this.gbxValueType.ResumeLayout(false);
			this.gbxValueType.PerformLayout();
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.tvGlossaryUnits = new GlossaryUnitTree();
			this.gbxGlossary.Controls.Add(this.tvGlossaryUnits);
			this.tvGlossaryUnits.HideSelection = false;
			Control arg_3F_0 = this.tvGlossaryUnits;
			Point location = new Point(87, 100);
			arg_3F_0.Location = location;
			Control arg_5C_0 = this.tvGlossaryUnits;
			Size size = new Size(344, 506);
			arg_5C_0.Size = size;
			this.tvGlossaryUnits.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tvGlossaryUnits.Name = "tvGlossaryUnits";
			this.tvGlossaryUnits.ShowRootLines = false;
			this.tvGlossaryUnits.AllowDrop = true;
		}

		private void InitGlossaryUnitTree(string glossaryID)
		{
			try
			{
				this.m_EGlossary = WebServiceLayer.GlossaryAccess.SelectGlossaryById(glossaryID);
				this.tvGlossaryUnits.ID = this.m_EGlossary.ID;
				this.tvGlossaryUnits.GName = this.m_EGlossary.Name;
				this.tvGlossaryUnits.Desc = this.m_EGlossary.Description;
				this.tvGlossaryUnits.GUID = this.m_EGlossary.GUID;
				this.tvGlossaryUnits.CategoryID = this.m_EGlossary.GlossaryCategoryID;
				this.tvGlossaryUnits.GlossaryType = this.m_EGlossary.GlossaryType;
				this.tvGlossaryUnits.ParentID = this.m_EGlossary.ParentID;
				this.tvGlossaryUnits.InitTree();
			}
			catch (Exception expr_B8)
			{
				ProjectData.SetProjectError(expr_B8);
				Exception ex = expr_B8;
				MessageManager.ShowErrorMessage(ex.Message);
				ProjectData.ClearProjectError();
			}
		}

		private void DCGlossary_Load(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.m_GlossaryType.ToUpper(), "TG", false) == 0)
			{
				this.tvTemplates = new TemplateTree(TemplateTree.ShowLevel.OnlySingle, true);
				this.pnlCategory.Controls.Add(this.tvTemplates);
				this.tvTemplates.HideSelection = false;
				this.tvTemplates.Dock = DockStyle.Fill;
				this.tvTemplates.Name = "tvTemplates";
				this.tvTemplates.ShowRootLines = true;
				this.tvTemplates.Init();
				this.tvUnits = new PrintUnitTree();
				this.pnlItem.Controls.Add(this.tvUnits);
				this.tvUnits.HideSelection = false;
				this.tvUnits.Dock = DockStyle.Fill;
				this.tvUnits.Name = "tvUnits";
				this.tvUnits.ShowRootLines = false;
				this.tvUnits.AllowDrop = true;
				this.tvUnits.ITID = null;
				this.tvUnits.ITName = null;
				this.tvUnits.ITVersion = null;
			}
			else
			{
				this.btnSelectKBNode = new Button();
				this.btnSelectKBNode.Name = "btnSelectKBNode";
				this.btnSelectKBNode.Text = "选择知识库";
				Control arg_143_0 = this.btnSelectKBNode;
				Point location = new Point(0, 4);
				arg_143_0.Location = location;
				Control arg_15A_0 = this.btnSelectKBNode;
				Size size = new Size(120, 23);
				arg_15A_0.Size = size;
				this.btnSelectKBNode.UseVisualStyleBackColor = true;
				this.cbxKBPart = new ComboBox();
				this.cbxKBPart.Name = "cbxKBPart";
				this.cbxKBPart.DropDownStyle = ComboBoxStyle.DropDownList;
				Control arg_1A3_0 = this.cbxKBPart;
				location = new Point(124, 5);
				arg_1A3_0.Location = location;
				Control arg_1BA_0 = this.cbxKBPart;
				size = new Size(100, 23);
				arg_1BA_0.Size = size;
				this.cbxKBPart.Visible = false;
				this.InitKBPartComboBox();
				this.tvKBNodes = new KBNodeTree();
				this.tvKBNodes.HideSelection = false;
				this.tvKBNodes.Name = "tvKBNodes";
				this.tvKBNodes.ShowRootLines = true;
				Control arg_215_0 = this.tvKBNodes;
				location = new Point(0, 31);
				arg_215_0.Location = location;
				Control arg_232_0 = this.tvKBNodes;
				size = new Size(354, 239);
				arg_232_0.Size = size;
				this.tvKBNodes.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				this.pnlCategory.Controls.Add(this.btnSelectKBNode);
				this.pnlCategory.Controls.Add(this.cbxKBPart);
				this.pnlCategory.Controls.Add(this.tvKBNodes);
				this.tvKBUnits = new KBUnitTree();
				this.tvKBUnits.HideSelection = false;
				this.tvKBUnits.Dock = DockStyle.Fill;
				this.tvKBUnits.Name = "tvKBUnits";
				this.tvKBUnits.ShowRootLines = true;
				this.tvKBUnits.AllowDrop = true;
				this.pnlItem.Controls.Add(this.tvKBUnits);
			}
			this.miDelItem = new MenuItem("删除元数据项");
			this.miDelItem.Click += new EventHandler(this.miDelItem_Click);
			this.ctxMenu.MenuItems.AddRange(new MenuItem[]
			{
				this.miDelItem
			});
			this.tvGlossaryUnits.ContextMenu = this.ctxMenu;
		}

		private void tvTemplates_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.tvUnits.Nodes.Clear();
			TreeNode selectedNode = this.tvTemplates.SelectedNode;
			if (Operators.CompareString(this.tvTemplates.GetNodeType(selectedNode).ToString(), "LF", false) == 0)
			{
				this.tvUnits.ITName = selectedNode.Text;
				string nodeId = this.tvTemplates.GetNodeId(selectedNode);
				this.tvUnits.ITID = nodeId;
				try
				{
					ETemplateVersion metadataByTemplateID = WebServiceLayer.InterfaceTemplateAccess.GetMetadataByTemplateID(nodeId);
					if (Operators.CompareString(metadataByTemplateID.MetaData, null, false) != 0 && Operators.CompareString(metadataByTemplateID.MetaData, "", false) != 0)
					{
						this.tvUnits.ITVersion = metadataByTemplateID.VersionNumber.ToString();
						this.tvUnits.StrMetaData = metadataByTemplateID.MetaData;
						this.tvUnits.Tag = TemplateType.Single.ToString() + "^" + this.tvTemplates.GetCategoryInfo(selectedNode);
					}
					return;
				}
				catch (Exception arg_F0_0)
				{
					ProjectData.SetProjectError(arg_F0_0);
					ProjectData.ClearProjectError();
					return;
				}
			}
			this.tvUnits.Nodes.Clear();
		}

		private void tvKBNodes_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.RefreshKBUnitTree();
		}

		private void tvUnits_MouseDown(object sender, MouseEventArgs e)
		{
			TreeView treeView = (TreeView)sender;
			this.m_MetaNode = treeView.GetNodeAt(e.X, e.Y);
			if (this.m_MetaNode != null)
			{
				treeView.SelectedNode = this.m_MetaNode;
				if (this.m_MetaNode.Tag == null)
				{
					this.cbxValueType.DataSource = null;
				}
				else
				{
					if (this.m_DataTypeNode == null | !this.m_MetaNode.Equals(this.m_DataTypeNode))
					{
						this.InitCbxValueTypeList(this.m_MetaNode);
					}
					treeView.DoDragDrop(RuntimeHelpers.GetObjectValue(this.m_MetaNode.Tag), DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}

		private void tvKBUnits_MouseDown(object sender, MouseEventArgs e)
		{
			TreeView treeView = (TreeView)sender;
			this.m_KBMetaNode = treeView.GetNodeAt(e.X, e.Y);
			if (this.m_KBMetaNode != null)
			{
				treeView.SelectedNode = this.m_KBMetaNode;
				if (this.m_KBMetaNode.Tag == null)
				{
					this.cbxValueType.DataSource = null;
				}
				else
				{
					if (this.m_DataTypeNode == null | !this.m_KBMetaNode.Equals(this.m_DataTypeNode))
					{
						this.InitCbxValueTypeList(this.m_KBMetaNode);
					}
					treeView.DoDragDrop(RuntimeHelpers.GetObjectValue(this.m_KBMetaNode.Tag), DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}

		private void tvGlossaryUnits_MouseDown(object sender, MouseEventArgs e)
		{
			TreeView treeView = (TreeView)sender;
			this.m_GlossaryNode = treeView.GetNodeAt(e.X, e.Y);
			if (this.m_GlossaryNode != null)
			{
				treeView.SelectedNode = this.m_GlossaryNode;
			}
		}

		private void tvGlossaryUnits_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Move;
			}
		}

		private void tvGlossaryUnits_DragDrop(object sender, DragEventArgs e)
		{
			TreeView treeView = (TreeView)sender;
			int num = Conversions.ToInteger(Interaction.IIf(this.m_MetaNode != null, 0, 1));
			TreeNode treeNode = (TreeNode)Interaction.IIf(num == 0, this.m_MetaNode, this.m_KBMetaNode);
			string text = treeNode.Tag.ToString();
			if (text.IndexOf("#TYPE:Table#") != -1 | text.IndexOf("#TYPE:Figure#") != -1 | text.IndexOf("#TYPE:ImageAnnotate#") != -1)
			{
				MessageManager.ShowWarningMessage("暂不支持对T,F和Y单元术语化!");
				return;
			}
			string text2 = Conversions.ToString(this.cbxValueType.SelectedValue);
			string bindingName = this.GetBindingName(treeNode, num);
			int imageIndex = this.GetImageIndex(text);
			string text3 = this.BuildItemCode(text);
			TreeNode treeNode2 = new TreeNode(bindingName, imageIndex, imageIndex);
			checked
			{
				if (num == 0)
				{
					string iTID = this.tvUnits.ITID;
					treeNode2.Tag = string.Format("{0}^{1}^{2}", iTID, text3, text2);
				}
				else
				{
					int num2 = text.IndexOf("#KBNodeID:");
					int num3 = text.IndexOf("#KBPartNo:");
					string text4 = text.Substring(num2 + 10, num3 - num2 - 10);
					string text5 = text.Substring(num3 + 10, 1);
					treeNode2.Tag = string.Format("{0}^{1}^{2}^{3}", new object[]
					{
						text4,
						text5,
						text3,
						text2
					});
				}
				if (!this.CheckNodeExisted(treeView.Nodes[0], treeNode2))
				{
					treeView.Nodes[0].Nodes.Add(treeNode2);
					treeView.ExpandAll();
				}
				else
				{
					MessageManager.ShowWarningMessage("该节点已存在!");
				}
			}
		}

		private void miDelItem_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(this.tvGlossaryUnits.SelectedNode.Tag, "RT", false))
			{
				this.tvGlossaryUnits.Nodes.Remove(this.tvGlossaryUnits.SelectedNode);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				string text = this.BuildGlossaryItems(this.tvGlossaryUnits.Nodes[0]);
				if (Operators.CompareString(text, string.Empty, false) != 0)
				{
					WebServiceLayer.GlossaryItemAccess.UpdateGlossaryItems(text, ref flag, ref flag2);
					MessageManager.ShowInformationMessage("{0}保存成功。", new object[]
					{
						this.m_EGlossary.Name + " "
					});
				}
				else
				{
					MessageManager.ShowErrorMessage("术语项目为空，请添加数据后保存");
				}
			}
			catch (Exception expr_75)
			{
				ProjectData.SetProjectError(expr_75);
				Exception ex = expr_75;
				MessageManager.ShowErrorMessage("保存术语集错误！\r" + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void cbxKBPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.RefreshKBUnitTree();
		}

		private void btnSelectKBNode_Click(object sender, EventArgs e)
		{
			Point point = this.btnSelectKBNode.PointToScreen(this.btnSelectKBNode.Location);
			Point point2 = new Point(point.X, checked(point.Y + this.btnSelectKBNode.Height));
			KBTreeForm kBTreeForm = new KBTreeForm(point2);
			kBTreeForm.ShowDialog();
			if (kBTreeForm.DialogResult == DialogResult.OK)
			{
				TreeNode kBNode = kBTreeForm.KBNode;
				if (kBNode != null)
				{
					string kbNodeID = kBNode.Tag.ToString().Substring(2);
					string text = kBNode.Text;
					this.tvKBNodes.Init(kbNodeID, text);
					this.cbxKBPart.Visible = true;
				}
				else
				{
					MessageManager.ShowInformationMessage("请先选择一个知识库节点!");
				}
			}
		}

		private void RefreshKBUnitTree()
		{
			this.tvKBUnits.Nodes.Clear();
			TreeNode selectedNode = this.tvKBNodes.SelectedNode;
			if (selectedNode != null)
			{
				if (Operators.CompareString(this.tvKBNodes.GetNodeType(selectedNode).ToString(), "LF", false) == 0)
				{
					string nodeID = this.tvKBNodes.GetNodeID(selectedNode);
					object expr_59 = this.cbxKBPart.SelectedItem;
					KeyValuePair<string, int> keyValuePair;
					int value = ((expr_59 != null) ? ((KeyValuePair<string, int>)expr_59) : keyValuePair).Value;
					this.tvKBUnits.Init(nodeID, value);
					this.tvKBUnits.Tag = selectedNode.FullPath.Replace("\\", ".");
				}
			}
			else
			{
				MessageManager.ShowWarningMessage("请选中知识库内容!");
			}
		}

		private void InitCbxValueTypeList(TreeNode node)
		{
			this.cbxValueType.DataSource = null;
			if (node.Tag == null)
			{
				return;
			}
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			string text = Conversions.ToString((int)this.GetBidingSimpleDataType(Conversions.ToString(node.Tag)));
			string left = text;
			KeyValuePair<string, string> item;
			if (Operators.CompareString(left, Conversions.ToString(0), false) != 0)
			{
				if (Operators.CompareString(left, Conversions.ToString(2), false) != 0)
				{
					if (Operators.CompareString(left, Conversions.ToString(1), false) != 0)
					{
						if (Operators.CompareString(left, Conversions.ToString(3), false) == 0)
						{
							List<KeyValuePair<string, string>> arg_A8_0 = list;
							item = new KeyValuePair<string, string>("值", "V");
							arg_A8_0.Add(item);
							List<KeyValuePair<string, string>> arg_C1_0 = list;
							item = new KeyValuePair<string, string>("代码", "C");
							arg_C1_0.Add(item);
							List<KeyValuePair<string, string>> arg_DA_0 = list;
							item = new KeyValuePair<string, string>("值 + 代码", "VANDC");
							arg_DA_0.Add(item);
							List<KeyValuePair<string, string>> arg_F3_0 = list;
							item = new KeyValuePair<string, string>("代码+值", "CANDV");
							arg_F3_0.Add(item);
							goto IL_390;
						}
						if (Operators.CompareString(left, Conversions.ToString(4), false) == 0)
						{
							List<KeyValuePair<string, string>> arg_121_0 = list;
							item = new KeyValuePair<string, string>("值", "V");
							arg_121_0.Add(item);
							List<KeyValuePair<string, string>> arg_13A_0 = list;
							item = new KeyValuePair<string, string>("单位", "C");
							arg_13A_0.Add(item);
							List<KeyValuePair<string, string>> arg_153_0 = list;
							item = new KeyValuePair<string, string>("值+单位", "VANDC");
							arg_153_0.Add(item);
							List<KeyValuePair<string, string>> arg_16C_0 = list;
							item = new KeyValuePair<string, string>("单位+值", "CANDV");
							arg_16C_0.Add(item);
							goto IL_390;
						}
						if (Operators.CompareString(left, Conversions.ToString(7), false) == 0)
						{
							List<KeyValuePair<string, string>> arg_19A_0 = list;
							item = new KeyValuePair<string, string>("说明", "V");
							arg_19A_0.Add(item);
							List<KeyValuePair<string, string>> arg_1B3_0 = list;
							item = new KeyValuePair<string, string>("代码", "C");
							arg_1B3_0.Add(item);
							List<KeyValuePair<string, string>> arg_1CC_0 = list;
							item = new KeyValuePair<string, string>("说明+代码", "VANDC");
							arg_1CC_0.Add(item);
							List<KeyValuePair<string, string>> arg_1E5_0 = list;
							item = new KeyValuePair<string, string>("代码+说明", "CANDV");
							arg_1E5_0.Add(item);
							goto IL_390;
						}
						if (Operators.CompareString(left, Conversions.ToString(6), false) == 0)
						{
							List<KeyValuePair<string, string>> arg_213_0 = list;
							item = new KeyValuePair<string, string>("说明", "V");
							arg_213_0.Add(item);
							List<KeyValuePair<string, string>> arg_22C_0 = list;
							item = new KeyValuePair<string, string>("代码", "C");
							arg_22C_0.Add(item);
							List<KeyValuePair<string, string>> arg_245_0 = list;
							item = new KeyValuePair<string, string>("说明+代码", "VANDC");
							arg_245_0.Add(item);
							List<KeyValuePair<string, string>> arg_25E_0 = list;
							item = new KeyValuePair<string, string>("代码+说明", "CANDV");
							arg_25E_0.Add(item);
							goto IL_390;
						}
						if (Operators.CompareString(left, Conversions.ToString(5), false) == 0)
						{
							List<KeyValuePair<string, string>> arg_28F_0 = list;
							item = new KeyValuePair<string, string>("标准日期格式", "V");
							arg_28F_0.Add(item);
							List<KeyValuePair<string, string>> arg_2A8_0 = list;
							item = new KeyValuePair<string, string>("年月日", "YMD");
							arg_2A8_0.Add(item);
							List<KeyValuePair<string, string>> arg_2C1_0 = list;
							item = new KeyValuePair<string, string>("时分秒", "HMS");
							arg_2C1_0.Add(item);
							List<KeyValuePair<string, string>> arg_2DA_0 = list;
							item = new KeyValuePair<string, string>("年", "YEAR");
							arg_2DA_0.Add(item);
							List<KeyValuePair<string, string>> arg_2F3_0 = list;
							item = new KeyValuePair<string, string>("月", "Month");
							arg_2F3_0.Add(item);
							List<KeyValuePair<string, string>> arg_30C_0 = list;
							item = new KeyValuePair<string, string>("日", "Day");
							arg_30C_0.Add(item);
							List<KeyValuePair<string, string>> arg_325_0 = list;
							item = new KeyValuePair<string, string>("时", "Hour");
							arg_325_0.Add(item);
							List<KeyValuePair<string, string>> arg_33E_0 = list;
							item = new KeyValuePair<string, string>("分", "Minute");
							arg_33E_0.Add(item);
							List<KeyValuePair<string, string>> arg_357_0 = list;
							item = new KeyValuePair<string, string>("秒", "Second");
							arg_357_0.Add(item);
							List<KeyValuePair<string, string>> arg_370_0 = list;
							item = new KeyValuePair<string, string>("值+代码", "VANDC");
							arg_370_0.Add(item);
							goto IL_390;
						}
						List<KeyValuePair<string, string>> arg_38B_0 = list;
						item = new KeyValuePair<string, string>("值", "V");
						arg_38B_0.Add(item);
						goto IL_390;
					}
				}
			}
			List<KeyValuePair<string, string>> arg_7A_0 = list;
			item = new KeyValuePair<string, string>("值", "V");
			arg_7A_0.Add(item);
			IL_390:
			this.cbxValueType.DataSource = list;
			this.cbxValueType.DisplayMember = "Key";
			this.cbxValueType.ValueMember = "Value";
			string defaultValueType = this.GetDefaultValueType(Conversions.ToString(node.Tag));
			this.SetDefaultValueType(defaultValueType);
			this.m_DataTypeNode = node;
		}

		private void SetDefaultValueType(string valueType)
		{
			if (this.cbxValueType.Items.Count > 0)
			{
				try
				{
					IEnumerator enumerator = this.cbxValueType.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object expr_2C = enumerator.Current;
						KeyValuePair<string, string> keyValuePair2;
						KeyValuePair<string, string> keyValuePair = (expr_2C != null) ? ((KeyValuePair<string, string>)expr_2C) : keyValuePair2;
						if (keyValuePair.Value.Equals(valueType))
						{
							this.cbxValueType.SelectedItem = keyValuePair;
							break;
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

		private void InitKBPartComboBox()
		{
			this.cbxKBPart.DataSource = null;
			List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
			List<KeyValuePair<string, int>> arg_21_0 = list;
			KeyValuePair<string, int> item = new KeyValuePair<string, int>("第一部分", 1);
			arg_21_0.Add(item);
			List<KeyValuePair<string, int>> arg_35_0 = list;
			item = new KeyValuePair<string, int>("第二部分", 2);
			arg_35_0.Add(item);
			List<KeyValuePair<string, int>> arg_49_0 = list;
			item = new KeyValuePair<string, int>("第三部分", 3);
			arg_49_0.Add(item);
			this.cbxKBPart.DataSource = list;
			this.cbxKBPart.DisplayMember = "Key";
			this.cbxKBPart.ValueMember = "Value";
		}

		private bool CheckNodeExisted(TreeNode parNode, TreeNode itemNode)
		{
			bool result = false;
			try
			{
				IEnumerator enumerator = parNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (treeNode.Tag.Equals(RuntimeHelpers.GetObjectValue(itemNode.Tag)))
					{
						result = true;
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
			return result;
		}

		private SimpleDataType GetBidingSimpleDataType(string nodeTag)
		{
			int num = nodeTag.IndexOf("#SCODE:");
			if (num == -1)
			{
				return SimpleDataType.Others;
			}
			string text = nodeTag.Substring(checked(num + 7), 1);
			string left = text;
			if (Operators.CompareString(left, "S", false) == 0)
			{
				return SimpleDataType.MIString;
			}
			if (Operators.CompareString(left, "N", false) == 0)
			{
				return SimpleDataType.MINumber;
			}
			if (Operators.CompareString(left, "O", false) == 0)
			{
				return SimpleDataType.MIMonoChoice;
			}
			if (Operators.CompareString(left, "M", false) == 0)
			{
				return SimpleDataType.MIMultiChoice;
			}
			if (Operators.CompareString(left, "Q", false) == 0)
			{
				return SimpleDataType.MIQuantity;
			}
			if (Operators.CompareString(left, "D", false) == 0)
			{
				return SimpleDataType.MIDateTime;
			}
			if (Operators.CompareString(left, "I", false) == 0)
			{
				return SimpleDataType.MIDictionary;
			}
			if (Operators.CompareString(left, "P", false) == 0)
			{
				return SimpleDataType.MIPosition;
			}
			return SimpleDataType.Others;
		}

		private string GetDefaultValueType(string itemCode)
		{
			string text = "";
			int num = itemCode.IndexOf("#VTYPE:");
			if (num != -1)
			{
				text = itemCode.Substring(checked(num + 7));
				int num2 = text.IndexOf("#KBNodeID:");
				if (num2 != -1)
				{
					text = text.Substring(0, num2);
				}
			}
			return text;
		}

		private string GetBindingName(TreeNode node, int nodeType)
		{
			string result = string.Empty;
			string text = Conversions.ToString(node.Tag);
			SimpleDataType bidingSimpleDataType = this.GetBidingSimpleDataType(text);
			object expr_25 = this.cbxValueType.SelectedItem;
			KeyValuePair<string, string> keyValuePair;
			string key = ((expr_25 != null) ? ((KeyValuePair<string, string>)expr_25) : keyValuePair).Key;
			if (nodeType == 0)
			{
				int length = text.IndexOf("#TYPE:");
				string text2 = this.tvUnits.Tag.ToString();
				int num = text2.IndexOf("^");
				if (num != -1)
				{
					text2 = text2.Substring(checked(text2.IndexOf("^") + 1));
					if (text2.StartsWith("界面模板"))
					{
						text2 = text2.Substring(5);
					}
				}
				if (bidingSimpleDataType == SimpleDataType.Others)
				{
					result = text2 + "." + text.Substring(0, length);
				}
				else if (!Information.IsNothing(key) && Operators.CompareString(key, "", false) != 0)
				{
					result = string.Concat(new string[]
					{
						text2,
						".",
						text.Substring(0, length),
						".",
						key
					});
				}
			}
			else
			{
				object expr_12B = this.cbxKBPart.SelectedItem;
				KeyValuePair<string, int> keyValuePair2;
				string key2 = ((expr_12B != null) ? ((KeyValuePair<string, int>)expr_12B) : keyValuePair2).Key;
				result = string.Format("{0}.{1}.{2}.{3}", new object[]
				{
					this.tvKBUnits.Tag.ToString(),
					key2,
					node.Text,
					key
				});
			}
			return result;
		}

		private string BuildItemCode(string nodeTag)
		{
			string text = string.Empty;
			int startIndex = nodeTag.IndexOf("#TYPE:");
			string text2 = nodeTag.Substring(startIndex);
			int num = text2.IndexOf("#GCODE:");
			checked
			{
				if (num != -1)
				{
					string text3 = text2.Substring(num + 7, 5);
					text = text3;
				}
				int num2 = text2.IndexOf("#ECODE:");
				if (num2 != -1)
				{
					string text4 = text2.Substring(num2 + 7, 5);
					text = text4;
				}
				int num3 = text2.IndexOf("#TCODE:");
				if (num3 != -1)
				{
					string text5 = text2.Substring(num3 + 7, 5);
					text = text5;
				}
				int num4 = text2.IndexOf("#SCODE:");
				if (num4 != -1)
				{
					string text6 = text2.Substring(num4 + 7, 5);
					text = Conversions.ToString(Interaction.IIf(text != string.Empty, string.Format("{0}.{1}", text, text6), text6));
				}
				return text;
			}
		}

		private string BuildGlossaryItems(TreeNode root)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				if (root.GetNodeCount(true) > 0)
				{
					stringBuilder.Append(RuntimeHelpers.GetObjectValue(root.Tag));
					int num = 0;
					int num2 = 0;
					try
					{
						IEnumerator enumerator = root.Nodes.GetEnumerator();
						while (enumerator.MoveNext())
						{
							TreeNode treeNode = (TreeNode)enumerator.Current;
							if (num == 0)
							{
								stringBuilder.Append("|");
							}
							if (num2 > 0)
							{
								stringBuilder.Append("$");
							}
							num++;
							num2++;
							stringBuilder.Append(string.Format("{0}^{1}", RuntimeHelpers.GetObjectValue(treeNode.Tag), treeNode.Text));
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
				return stringBuilder.ToString();
			}
		}

		public int GetImageIndex(string subItem)
		{
			int num = 0;
			string left = null;
			if (subItem.IndexOf("#SCODE:") > 0)
			{
				num = subItem.IndexOf("#SCODE:");
			}
			else if (subItem.IndexOf("#GCODE:") > 0)
			{
				num = subItem.IndexOf("#GCODE:");
			}
			else if (subItem.IndexOf("#ECODE:") > 0)
			{
				num = subItem.IndexOf("#ECODE:");
			}
			if (num > 0)
			{
				left = subItem.Substring(checked(num + 7), 1);
			}
			if (Operators.CompareString(left, "S", false) == 0)
			{
				return 1;
			}
			if (Operators.CompareString(left, "N", false) == 0)
			{
				return 2;
			}
			if (Operators.CompareString(left, "O", false) == 0)
			{
				return 3;
			}
			if (Operators.CompareString(left, "M", false) == 0)
			{
				return 4;
			}
			if (Operators.CompareString(left, "Q", false) == 0)
			{
				return 5;
			}
			if (Operators.CompareString(left, "D", false) == 0)
			{
				return 6;
			}
			if (Operators.CompareString(left, "I", false) == 0)
			{
				return 7;
			}
			if (Operators.CompareString(left, "T", false) == 0)
			{
				return 8;
			}
			if (Operators.CompareString(left, "C", false) == 0)
			{
				return 9;
			}
			if (Operators.CompareString(left, "E", false) == 0)
			{
				return 10;
			}
			if (Operators.CompareString(left, "L", false) == 0)
			{
				return 11;
			}
			if (Operators.CompareString(left, "G", false) == 0)
			{
				return 12;
			}
			if (Operators.CompareString(left, "Y", false) == 0)
			{
				return 13;
			}
			if (Operators.CompareString(left, "P", false) == 0)
			{
				return 14;
			}
			int result;
			return result;
		}
	}
}
