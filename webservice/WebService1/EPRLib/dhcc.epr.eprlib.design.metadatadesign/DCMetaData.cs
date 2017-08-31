using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Reflection;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class DCMetaData : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("DCMetaDataTabs")]
		private TabControlAdv _DCMetaDataTabs;

		[AccessedThroughProperty("MetaItemTab")]
		private TabPageAdv _MetaItemTab;

		[AccessedThroughProperty("LanguageTab")]
		private TabPageAdv _LanguageTab;

		[AccessedThroughProperty("TermTab")]
		private TabPageAdv _TermTab;

		[AccessedThroughProperty("TopPanel")]
		private Panel _TopPanel;

		[AccessedThroughProperty("splMain")]
		private SplitContainer _splMain;

		[AccessedThroughProperty("MainPanel")]
		private Panel _MainPanel;

		[AccessedThroughProperty("MTreePanel")]
		private Panel _MTreePanel;

		[AccessedThroughProperty("PropertyPanel")]
		private Panel _PropertyPanel;

		[AccessedThroughProperty("TreeSplitter")]
		private Splitter _TreeSplitter;

		[AccessedThroughProperty("NamePanel")]
		private Panel _NamePanel;

		[AccessedThroughProperty("PrivatePropertyPanel")]
		private Panel _PrivatePropertyPanel;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		[AccessedThroughProperty("lblDescription")]
		private Label _lblDescription;

		[AccessedThroughProperty("txtDescription")]
		private TextBox _txtDescription;

		[AccessedThroughProperty("cbxAllowNull")]
		private CheckBox _cbxAllowNull;

		[AccessedThroughProperty("designTimeTabTypeLoader")]
		private TypeLoader _designTimeTabTypeLoader;

		[AccessedThroughProperty("ToolPanel")]
		private Panel _ToolPanel;

		[AccessedThroughProperty("btnAdd")]
		private Button _btnAdd;

		[AccessedThroughProperty("btnRemove")]
		private Button _btnRemove;

		[AccessedThroughProperty("btnUp")]
		private Button _btnUp;

		[AccessedThroughProperty("btnDown")]
		private Button _btnDown;

		[AccessedThroughProperty("pbString")]
		private PictureBox _pbString;

		[AccessedThroughProperty("pbNumber")]
		private PictureBox _pbNumber;

		[AccessedThroughProperty("pbMonoChoice")]
		private PictureBox _pbMonoChoice;

		[AccessedThroughProperty("pbMultiChoice")]
		private PictureBox _pbMultiChoice;

		[AccessedThroughProperty("pbDateTime")]
		private PictureBox _pbDateTime;

		[AccessedThroughProperty("pbDictionary")]
		private PictureBox _pbDictionary;

		[AccessedThroughProperty("pbTable")]
		private PictureBox _pbTable;

		[AccessedThroughProperty("pbCluster")]
		private PictureBox _pbCluster;

		[AccessedThroughProperty("pbTextDesc")]
		private PictureBox _pbTextDesc;

		[AccessedThroughProperty("pbQuantity")]
		private PictureBox _pbQuantity;

		[AccessedThroughProperty("pbSegment")]
		private PictureBox _pbSegment;

		[AccessedThroughProperty("pbLink")]
		private PictureBox _pbLink;

		[AccessedThroughProperty("txtDataBind")]
		private TextBox _txtDataBind;

		[AccessedThroughProperty("lblBind")]
		private Label _lblBind;

		[AccessedThroughProperty("btnBind")]
		private Button _btnBind;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("pbImageAnnotate")]
		private PictureBox _pbImageAnnotate;

		[AccessedThroughProperty("pbPosition")]
		private PictureBox _pbPosition;

		[AccessedThroughProperty("lblStatus")]
		private Label _lblStatus;

		[AccessedThroughProperty("cbxStatus")]
		private ComboBox _cbxStatus;

		[AccessedThroughProperty("ckbDataSynch")]
		private CheckBox _ckbDataSynch;

		[AccessedThroughProperty("pbFigure")]
		private PictureBox _pbFigure;

		private MMetaItem _MetaItem;

		private NInstanceItem _InstanceItem;

		private string _StrMetaData;

		private string _TemplateName;

		private string _TemplateDescription;

		private MMetaItem _DragMetaItem;

		private MMetaItem _CurrentMetaItem;

		private Hashtable PropertyHashTable;

		private bool _IsChanged;

		private TreeNode _SelectNode;

		private bool _MouseRightKey;

		private bool _needInitCurItem;

		private MenuItem miEdit;

		private MenuItem miDelete;

		private MenuItem miExportMetaItem;

		private MenuItem miCopy;

		private MenuItem miPaste;

		private static MMetaItem CopyMetaItem;

		private ContextMenu cmMetaItemTree;

		[AccessedThroughProperty("MetaItemTree")]
		private MetaItemTree _MetaItemTree;

		private TreeNode CurrentNode;

		private ToolTip _ToolTip;

		private bool AutoSetStatus;

		private string _bakName;

		private BindData mBindData;

		private bool _BindKB;

		private string _BindKBCode;

		private string _BindKBName;

		internal virtual TabControlAdv DCMetaDataTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCMetaDataTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCMetaDataTabs = value;
			}
		}

		internal virtual TabPageAdv MetaItemTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetaItemTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetaItemTab = value;
			}
		}

		internal virtual TabPageAdv LanguageTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LanguageTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LanguageTab = value;
			}
		}

		internal virtual TabPageAdv TermTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TermTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TermTab = value;
			}
		}

		internal virtual Panel TopPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TopPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TopPanel = value;
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

		internal virtual Panel MainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainPanel = value;
			}
		}

		internal virtual Panel MTreePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MTreePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MTreePanel = value;
			}
		}

		internal virtual Panel PropertyPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PropertyPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PropertyPanel = value;
			}
		}

		internal virtual Splitter TreeSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TreeSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TreeSplitter = value;
			}
		}

		internal virtual Panel NamePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NamePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NamePanel = value;
			}
		}

		internal virtual Panel PrivatePropertyPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PrivatePropertyPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PrivatePropertyPanel = value;
			}
		}

		internal virtual Label lblName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblName = value;
			}
		}

		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtName_TextChanged);
				EventHandler value3 = new EventHandler(this.txtName_LostFocus);
				EventHandler value4 = new EventHandler(this.txtName_GotFocus);
				if (this._txtName != null)
				{
					this._txtName.TextChanged -= value2;
					this._txtName.LostFocus -= value3;
					this._txtName.GotFocus -= value4;
				}
				this._txtName = value;
				if (this._txtName != null)
				{
					this._txtName.TextChanged += value2;
					this._txtName.LostFocus += value3;
					this._txtName.GotFocus += value4;
				}
			}
		}

		internal virtual Label lblDescription
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDescription;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDescription = value;
			}
		}

		internal virtual TextBox txtDescription
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDescription;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDescription_TextChanged);
				if (this._txtDescription != null)
				{
					this._txtDescription.TextChanged -= value2;
				}
				this._txtDescription = value;
				if (this._txtDescription != null)
				{
					this._txtDescription.TextChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxAllowNull
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxAllowNull;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxAllowNull_CheckedChanged);
				if (this._cbxAllowNull != null)
				{
					this._cbxAllowNull.CheckedChanged -= value2;
				}
				this._cbxAllowNull = value;
				if (this._cbxAllowNull != null)
				{
					this._cbxAllowNull.CheckedChanged += value2;
				}
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

		internal virtual Panel ToolPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolPanel = value;
			}
		}

		internal virtual Button btnAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd = value;
			}
		}

		internal virtual Button btnRemove
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnRemove;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnRemove = value;
			}
		}

		internal virtual Button btnUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnUp = value;
			}
		}

		internal virtual Button btnDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnDown = value;
			}
		}

		internal virtual PictureBox pbString
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbString;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbString != null)
				{
					this._pbString.MouseUp -= value2;
					this._pbString.MouseDown -= value3;
				}
				this._pbString = value;
				if (this._pbString != null)
				{
					this._pbString.MouseUp += value2;
					this._pbString.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbNumber
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbNumber;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbNumber != null)
				{
					this._pbNumber.MouseUp -= value2;
					this._pbNumber.MouseDown -= value3;
				}
				this._pbNumber = value;
				if (this._pbNumber != null)
				{
					this._pbNumber.MouseUp += value2;
					this._pbNumber.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbMonoChoice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbMonoChoice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbMonoChoice != null)
				{
					this._pbMonoChoice.MouseUp -= value2;
					this._pbMonoChoice.MouseDown -= value3;
				}
				this._pbMonoChoice = value;
				if (this._pbMonoChoice != null)
				{
					this._pbMonoChoice.MouseUp += value2;
					this._pbMonoChoice.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbMultiChoice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbMultiChoice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbMultiChoice != null)
				{
					this._pbMultiChoice.MouseDown -= value2;
				}
				this._pbMultiChoice = value;
				if (this._pbMultiChoice != null)
				{
					this._pbMultiChoice.MouseDown += value2;
				}
			}
		}

		internal virtual PictureBox pbDateTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbDateTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbDateTime != null)
				{
					this._pbDateTime.MouseUp -= value2;
					this._pbDateTime.MouseDown -= value3;
				}
				this._pbDateTime = value;
				if (this._pbDateTime != null)
				{
					this._pbDateTime.MouseUp += value2;
					this._pbDateTime.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbDictionary
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbDictionary;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbDictionary != null)
				{
					this._pbDictionary.MouseUp -= value2;
					this._pbDictionary.MouseDown -= value3;
				}
				this._pbDictionary = value;
				if (this._pbDictionary != null)
				{
					this._pbDictionary.MouseUp += value2;
					this._pbDictionary.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbTable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbTable;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbTable != null)
				{
					this._pbTable.MouseUp -= value2;
					this._pbTable.MouseDown -= value3;
				}
				this._pbTable = value;
				if (this._pbTable != null)
				{
					this._pbTable.MouseUp += value2;
					this._pbTable.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbCluster
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbCluster;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbCluster != null)
				{
					this._pbCluster.MouseUp -= value2;
					this._pbCluster.MouseDown -= value3;
				}
				this._pbCluster = value;
				if (this._pbCluster != null)
				{
					this._pbCluster.MouseUp += value2;
					this._pbCluster.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbTextDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbTextDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbTextDesc != null)
				{
					this._pbTextDesc.MouseUp -= value2;
					this._pbTextDesc.MouseDown -= value3;
				}
				this._pbTextDesc = value;
				if (this._pbTextDesc != null)
				{
					this._pbTextDesc.MouseUp += value2;
					this._pbTextDesc.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbQuantity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbQuantity;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbQuantity != null)
				{
					this._pbQuantity.MouseUp -= value2;
					this._pbQuantity.MouseDown -= value3;
				}
				this._pbQuantity = value;
				if (this._pbQuantity != null)
				{
					this._pbQuantity.MouseUp += value2;
					this._pbQuantity.MouseDown += value3;
				}
			}
		}

		internal virtual PictureBox pbSegment
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbSegment;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbSegment != null)
				{
					this._pbSegment.MouseDown -= value2;
				}
				this._pbSegment = value;
				if (this._pbSegment != null)
				{
					this._pbSegment.MouseDown += value2;
				}
			}
		}

		internal virtual PictureBox pbLink
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbLink;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbLink != null)
				{
					this._pbLink.MouseDown -= value2;
				}
				this._pbLink = value;
				if (this._pbLink != null)
				{
					this._pbLink.MouseDown += value2;
				}
			}
		}

		internal virtual TextBox txtDataBind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDataBind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDataBind = value;
			}
		}

		internal virtual Label lblBind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblBind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblBind = value;
			}
		}

		internal virtual Button btnBind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnBind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnBind_Click);
				if (this._btnBind != null)
				{
					this._btnBind.Click -= value2;
				}
				this._btnBind = value;
				if (this._btnBind != null)
				{
					this._btnBind.Click += value2;
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

		internal virtual PictureBox pbImageAnnotate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbImageAnnotate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbImageAnnotate != null)
				{
					this._pbImageAnnotate.MouseDown -= value2;
				}
				this._pbImageAnnotate = value;
				if (this._pbImageAnnotate != null)
				{
					this._pbImageAnnotate.MouseDown += value2;
				}
			}
		}

		internal virtual PictureBox pbPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbPosition != null)
				{
					this._pbPosition.MouseUp -= value2;
					this._pbPosition.MouseDown -= value3;
				}
				this._pbPosition = value;
				if (this._pbPosition != null)
				{
					this._pbPosition.MouseUp += value2;
					this._pbPosition.MouseDown += value3;
				}
			}
		}

		internal virtual Label lblStatus
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStatus;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStatus = value;
			}
		}

		internal virtual ComboBox cbxStatus
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxStatus;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxStatus_SelectedIndexChanged);
				if (this._cbxStatus != null)
				{
					this._cbxStatus.SelectedIndexChanged -= value2;
				}
				this._cbxStatus = value;
				if (this._cbxStatus != null)
				{
					this._cbxStatus.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual CheckBox ckbDataSynch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbDataSynch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbDataSynch_CheckedChanged);
				if (this._ckbDataSynch != null)
				{
					this._ckbDataSynch.CheckedChanged -= value2;
				}
				this._ckbDataSynch = value;
				if (this._ckbDataSynch != null)
				{
					this._ckbDataSynch.CheckedChanged += value2;
				}
			}
		}

		internal virtual PictureBox pbFigure
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbFigure;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.pbGroup_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.pbGroup_MouseDown);
				if (this._pbFigure != null)
				{
					this._pbFigure.MouseUp -= value2;
					this._pbFigure.MouseDown -= value3;
				}
				this._pbFigure = value;
				if (this._pbFigure != null)
				{
					this._pbFigure.MouseUp += value2;
					this._pbFigure.MouseDown += value3;
				}
			}
		}

		public virtual MetaItemTree MetaItemTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetaItemTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.MetaItemTree_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.MetaItemTree_MouseDown);
				KeyEventHandler value4 = new KeyEventHandler(this.MetaItemTree_KeyUp);
				TreeViewEventHandler value5 = new TreeViewEventHandler(this.MetaItemTree_AfterSelect);
				if (this._MetaItemTree != null)
				{
					this._MetaItemTree.MouseUp -= value2;
					this._MetaItemTree.MouseDown -= value3;
					this._MetaItemTree.KeyUp -= value4;
					this._MetaItemTree.AfterSelect -= value5;
				}
				this._MetaItemTree = value;
				if (this._MetaItemTree != null)
				{
					this._MetaItemTree.MouseUp += value2;
					this._MetaItemTree.MouseDown += value3;
					this._MetaItemTree.KeyUp += value4;
					this._MetaItemTree.AfterSelect += value5;
				}
			}
		}

		public MMetaItem MetaItem
		{
			get
			{
				return this._MetaItem;
			}
			set
			{
				this._needInitCurItem = true;
				this._MetaItem = value;
				this.MetaItemTree.MetaItem = this._MetaItem;
				if (this._MetaItem is MISegment)
				{
					this.pbLink.Visible = false;
					this.pbSegment.Visible = false;
					this.pbTextDesc.Visible = false;
					this.pbCluster.Visible = false;
					this.pbTable.Visible = false;
					this.pbImageAnnotate.Visible = false;
					this.pbFigure.Visible = false;
				}
			}
		}

		public NInstanceItem InstanceItem
		{
			get
			{
				return this._InstanceItem;
			}
			set
			{
				this._InstanceItem = value;
				this.MetaItemTree.InstanceItem = this._InstanceItem;
			}
		}

		public MMetaItem CurrentMetaItem
		{
			get
			{
				return this._CurrentMetaItem;
			}
			set
			{
				this._CurrentMetaItem = value;
				this.CurrentNode = this.MetaItemTree.SelectedNode;
				this.AutoSetStatus = true;
				if (this._CurrentMetaItem.Status == EPRStatus.Create)
				{
					this.cbxStatus.SelectedIndex = 0;
				}
				else if (this._CurrentMetaItem.Status == EPRStatus.Publish)
				{
					this.cbxStatus.SelectedIndex = 1;
				}
				else if (this._CurrentMetaItem.Status == EPRStatus.ABandon)
				{
					this.cbxStatus.SelectedIndex = 2;
				}
				this.AutoSetStatus = false;
				if (this._CurrentMetaItem is MISimple)
				{
					this.cbxAllowNull.Visible = true;
					MISimple mISimple = (MISimple)this._CurrentMetaItem;
					this.cbxAllowNull.Checked = mISimple.AllowNull;
					this.lblBind.Visible = true;
					this.txtDataBind.Visible = true;
					this.btnBind.Visible = true;
					this.btnCancel.Visible = true;
					this.ckbDataSynch.Visible = true;
					if (!(this._CurrentMetaItem.EPRBindCode == null | Operators.CompareString(this._CurrentMetaItem.EPRBindCode, "", false) == 0))
					{
						this.txtDataBind.Text = this._CurrentMetaItem.EPRBindCode.Split(new char[]
						{
							'#'
						})[0];
					}
					else if (!(this._CurrentMetaItem.DataBaseBindCode == null | Operators.CompareString(this._CurrentMetaItem.DataBaseBindCode, "", false) == 0))
					{
						this.txtDataBind.Text = this._CurrentMetaItem.DataBaseBindCode.Split(new char[]
						{
							'#'
						})[0];
					}
					else
					{
						this.txtDataBind.Text = "";
					}
					if (Operators.CompareString(this.txtDataBind.Text, "", false) == 0)
					{
						this.ckbDataSynch.Enabled = false;
						this._CurrentMetaItem.Synch = false;
					}
					else
					{
						this.ckbDataSynch.Enabled = true;
					}
					this.ckbDataSynch.Checked = this._CurrentMetaItem.Synch;
				}
				else if (this._CurrentMetaItem is MILink)
				{
					this.lblBind.Visible = true;
					this.txtDataBind.Visible = true;
					this.btnBind.Visible = true;
					this.btnCancel.Visible = true;
					this.ckbDataSynch.Visible = true;
					if (!(this._CurrentMetaItem.EPRBindCode == null | Operators.CompareString(this._CurrentMetaItem.EPRBindCode, "", false) == 0))
					{
						this.txtDataBind.Text = this._CurrentMetaItem.EPRBindCode.Split(new char[]
						{
							'#'
						})[0];
					}
					else if (!(this._CurrentMetaItem.DataBaseBindCode == null | Operators.CompareString(this._CurrentMetaItem.DataBaseBindCode, "", false) == 0))
					{
						this.txtDataBind.Text = this._CurrentMetaItem.DataBaseBindCode.Split(new char[]
						{
							'#'
						})[0];
					}
					else
					{
						this.txtDataBind.Text = "";
					}
					if (Operators.CompareString(this.txtDataBind.Text, "", false) == 0)
					{
						this.ckbDataSynch.Enabled = false;
						this._CurrentMetaItem.Synch = false;
					}
					else
					{
						this.ckbDataSynch.Enabled = true;
					}
					this.ckbDataSynch.Checked = this._CurrentMetaItem.Synch;
				}
				else
				{
					this.lblBind.Visible = false;
					this.txtDataBind.Visible = false;
					this.btnBind.Visible = false;
					this.btnCancel.Visible = false;
					this.cbxAllowNull.Visible = false;
					this.ckbDataSynch.Visible = false;
				}
				this.txtName.Text = this._CurrentMetaItem.Text;
				this.txtDescription.Text = this._CurrentMetaItem.Description;
				this.PrivatePropertyPanel.Controls.Clear();
				if (this._CurrentMetaItem is MMetaData)
				{
					MMetaDataProperty mMetaDataProperty;
					if (this.PropertyHashTable["A"] == null)
					{
						mMetaDataProperty = new MMetaDataProperty();
						mMetaDataProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("A", mMetaDataProperty);
						mMetaDataProperty.MetaItemTree = this.MetaItemTree;
					}
					else
					{
						mMetaDataProperty = (MMetaDataProperty)this.PropertyHashTable["A"];
					}
					this.PrivatePropertyPanel.Controls.Add(mMetaDataProperty);
					mMetaDataProperty.MetaData = (MMetaData)this._CurrentMetaItem;
					this.cbxStatus.Enabled = false;
				}
				else if (this._CurrentMetaItem is MIString)
				{
					MIStringProperty mIStringProperty;
					if (this.PropertyHashTable["S"] == null)
					{
						mIStringProperty = new MIStringProperty();
						mIStringProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("S", mIStringProperty);
					}
					else
					{
						mIStringProperty = (MIStringProperty)this.PropertyHashTable["S"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIStringProperty);
					mIStringProperty.MIString = (MIString)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MINumber)
				{
					MINumberProperty mINumberProperty;
					if (this.PropertyHashTable["N"] == null)
					{
						mINumberProperty = new MINumberProperty();
						mINumberProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("N", mINumberProperty);
					}
					else
					{
						mINumberProperty = (MINumberProperty)this.PropertyHashTable["N"];
					}
					this.PrivatePropertyPanel.Controls.Add(mINumberProperty);
					mINumberProperty.MINumber = (MINumber)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIMonoChoice)
				{
					MIMonoChoiceProperty mIMonoChoiceProperty;
					if (this.PropertyHashTable["O"] == null)
					{
						mIMonoChoiceProperty = new MIMonoChoiceProperty();
						mIMonoChoiceProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("O", mIMonoChoiceProperty);
					}
					else
					{
						mIMonoChoiceProperty = (MIMonoChoiceProperty)this.PropertyHashTable["O"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIMonoChoiceProperty);
					mIMonoChoiceProperty.MIMonoChoice = (MIMonoChoice)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIMultiChoice)
				{
					MIMultiChoiceProperty mIMultiChoiceProperty;
					if (this.PropertyHashTable["M"] == null)
					{
						mIMultiChoiceProperty = new MIMultiChoiceProperty();
						mIMultiChoiceProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("M", mIMultiChoiceProperty);
					}
					else
					{
						mIMultiChoiceProperty = (MIMultiChoiceProperty)this.PropertyHashTable["M"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIMultiChoiceProperty);
					mIMultiChoiceProperty.MIMultiChoice = (MIMultiChoice)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIDateTime)
				{
					MIDateTimeProperty mIDateTimeProperty;
					if (this.PropertyHashTable["D"] == null)
					{
						mIDateTimeProperty = new MIDateTimeProperty();
						mIDateTimeProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("D", mIDateTimeProperty);
					}
					else
					{
						mIDateTimeProperty = (MIDateTimeProperty)this.PropertyHashTable["D"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIDateTimeProperty);
					mIDateTimeProperty.MIDateTime = (MIDateTime)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIDictionary)
				{
					MIDictionaryProperty mIDictionaryProperty;
					if (this.PropertyHashTable["I"] == null)
					{
						mIDictionaryProperty = new MIDictionaryProperty();
						mIDictionaryProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("I", mIDictionaryProperty);
						mIDictionaryProperty.MetaItemTree = this.MetaItemTree;
					}
					else
					{
						mIDictionaryProperty = (MIDictionaryProperty)this.PropertyHashTable["I"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIDictionaryProperty);
					mIDictionaryProperty.MIDictionary = (MIDictionary)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIQuantity)
				{
					MIQuantityProperty mIQuantityProperty;
					if (this.PropertyHashTable["Q"] == null)
					{
						mIQuantityProperty = new MIQuantityProperty();
						mIQuantityProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("Q", mIQuantityProperty);
					}
					else
					{
						mIQuantityProperty = (MIQuantityProperty)this.PropertyHashTable["Q"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIQuantityProperty);
					mIQuantityProperty.MIQuantity = (MIQuantity)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MILink)
				{
					MILinkProperty mILinkProperty;
					if (this.PropertyHashTable["L"] == null)
					{
						mILinkProperty = new MILinkProperty();
						mILinkProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("L", mILinkProperty);
					}
					else
					{
						mILinkProperty = (MILinkProperty)this.PropertyHashTable["L"];
					}
					this.PrivatePropertyPanel.Controls.Add(mILinkProperty);
					mILinkProperty.MILink = (MILink)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MITable)
				{
					MITableProperty mITableProperty;
					if (this.PropertyHashTable["T"] == null)
					{
						mITableProperty = new MITableProperty();
						mITableProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("T", mITableProperty);
					}
					else
					{
						mITableProperty = (MITableProperty)this.PropertyHashTable["T"];
					}
					this.PrivatePropertyPanel.Controls.Add(mITableProperty);
					mITableProperty.MITable = (MITable)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MITextDesc)
				{
					MITextDescProperty mITextDescProperty;
					if (this.PropertyHashTable["E"] == null)
					{
						mITextDescProperty = new MITextDescProperty();
						mITextDescProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("E", mITextDescProperty);
					}
					else
					{
						mITextDescProperty = (MITextDescProperty)this.PropertyHashTable["E"];
					}
					mITextDescProperty.MITextDesc = (MITextDesc)this._CurrentMetaItem;
					this.PrivatePropertyPanel.Controls.Add(mITextDescProperty);
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MICluster)
				{
					MIClusterProperty mIClusterProperty;
					if (this.PropertyHashTable["C"] == null)
					{
						mIClusterProperty = new MIClusterProperty();
						mIClusterProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("C", mIClusterProperty);
					}
					else
					{
						mIClusterProperty = (MIClusterProperty)this.PropertyHashTable["C"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIClusterProperty);
					mIClusterProperty.MICluster = (MICluster)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MISegment)
				{
					MISegmentProperty mISegmentProperty;
					if (this.PropertyHashTable["G"] == null)
					{
						mISegmentProperty = new MISegmentProperty();
						mISegmentProperty.MetaItemTree = this.MetaItemTree;
						mISegmentProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("G", mISegmentProperty);
					}
					else
					{
						mISegmentProperty = (MISegmentProperty)this.PropertyHashTable["G"];
					}
					this.PrivatePropertyPanel.Controls.Add(mISegmentProperty);
					mISegmentProperty.MISegment = (MISegment)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIImageAnnotate)
				{
					MIImageAnnotateProperty mIImageAnnotateProperty;
					if (this.PropertyHashTable["Y"] == null)
					{
						mIImageAnnotateProperty = new MIImageAnnotateProperty();
						mIImageAnnotateProperty.MetaItemTree = this.MetaItemTree;
						mIImageAnnotateProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("Y", mIImageAnnotateProperty);
					}
					else
					{
						mIImageAnnotateProperty = (MIImageAnnotateProperty)this.PropertyHashTable["Y"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIImageAnnotateProperty);
					mIImageAnnotateProperty.MIImageAnnotate = (MIImageAnnotate)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIPosition)
				{
					MIPositionProperty mIPositionProperty;
					if (this.PropertyHashTable["P"] == null)
					{
						mIPositionProperty = new MIPositionProperty();
						mIPositionProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("P", mIPositionProperty);
					}
					else
					{
						mIPositionProperty = (MIPositionProperty)this.PropertyHashTable["P"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIPositionProperty);
					mIPositionProperty.MIPosition = (MIPosition)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
				else if (this._CurrentMetaItem is MIFigure)
				{
					MIFigureProperty mIFigureProperty;
					if (this.PropertyHashTable["F"] == null)
					{
						mIFigureProperty = new MIFigureProperty();
						mIFigureProperty.Dock = DockStyle.Fill;
						this.PropertyHashTable.Add("F", mIFigureProperty);
					}
					else
					{
						mIFigureProperty = (MIFigureProperty)this.PropertyHashTable["F"];
					}
					this.PrivatePropertyPanel.Controls.Add(mIFigureProperty);
					mIFigureProperty.MIFigure = (MIFigure)this._CurrentMetaItem;
					this.cbxStatus.Enabled = true;
				}
			}
		}

		public bool IsChanged
		{
			get
			{
				return this._IsChanged;
			}
		}

		public bool BindKB
		{
			get
			{
				return this._BindKB;
			}
			set
			{
				this._BindKB = value;
			}
		}

		public string BindKBCode
		{
			get
			{
				return this._BindKBCode;
			}
			set
			{
				this._BindKBCode = value;
			}
		}

		public string BindKBName
		{
			get
			{
				return this._BindKBName;
			}
			set
			{
				this._BindKBName = value;
			}
		}

		public DCMetaData()
		{
			this.PropertyHashTable = new Hashtable();
			this._needInitCurItem = true;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DCMetaData));
			this.DCMetaDataTabs = new TabControlAdv();
			this.MetaItemTab = new TabPageAdv();
			this.splMain = new SplitContainer();
			this.MainPanel = new Panel();
			this.PropertyPanel = new Panel();
			this.PrivatePropertyPanel = new Panel();
			this.NamePanel = new Panel();
			this.ckbDataSynch = new CheckBox();
			this.cbxStatus = new ComboBox();
			this.lblStatus = new Label();
			this.btnCancel = new Button();
			this.btnBind = new Button();
			this.lblBind = new Label();
			this.txtDataBind = new TextBox();
			this.cbxAllowNull = new CheckBox();
			this.txtDescription = new TextBox();
			this.lblDescription = new Label();
			this.txtName = new TextBox();
			this.lblName = new Label();
			this.TreeSplitter = new Splitter();
			this.MTreePanel = new Panel();
			this.ToolPanel = new Panel();
			this.pbPosition = new PictureBox();
			this.pbImageAnnotate = new PictureBox();
			this.pbSegment = new PictureBox();
			this.pbTextDesc = new PictureBox();
			this.pbCluster = new PictureBox();
			this.pbTable = new PictureBox();
			this.pbDictionary = new PictureBox();
			this.pbDateTime = new PictureBox();
			this.pbQuantity = new PictureBox();
			this.pbMultiChoice = new PictureBox();
			this.pbMonoChoice = new PictureBox();
			this.pbNumber = new PictureBox();
			this.btnDown = new Button();
			this.btnUp = new Button();
			this.btnRemove = new Button();
			this.btnAdd = new Button();
			this.pbString = new PictureBox();
			this.pbLink = new PictureBox();
			this.pbFigure = new PictureBox();
			this.TopPanel = new Panel();
			this.LanguageTab = new TabPageAdv();
			this.TermTab = new TabPageAdv();
			this.designTimeTabTypeLoader = new TypeLoader(this.components);
			this.DCMetaDataTabs.BeginInit();
			this.DCMetaDataTabs.SuspendLayout();
			this.MetaItemTab.SuspendLayout();
			this.splMain.Panel1.SuspendLayout();
			this.splMain.SuspendLayout();
			this.MainPanel.SuspendLayout();
			this.PropertyPanel.SuspendLayout();
			this.NamePanel.SuspendLayout();
			this.ToolPanel.SuspendLayout();
			((ISupportInitialize)this.pbPosition).BeginInit();
			((ISupportInitialize)this.pbImageAnnotate).BeginInit();
			((ISupportInitialize)this.pbSegment).BeginInit();
			((ISupportInitialize)this.pbTextDesc).BeginInit();
			((ISupportInitialize)this.pbCluster).BeginInit();
			((ISupportInitialize)this.pbTable).BeginInit();
			((ISupportInitialize)this.pbDictionary).BeginInit();
			((ISupportInitialize)this.pbDateTime).BeginInit();
			((ISupportInitialize)this.pbQuantity).BeginInit();
			((ISupportInitialize)this.pbMultiChoice).BeginInit();
			((ISupportInitialize)this.pbMonoChoice).BeginInit();
			((ISupportInitialize)this.pbNumber).BeginInit();
			((ISupportInitialize)this.pbString).BeginInit();
			((ISupportInitialize)this.pbLink).BeginInit();
			((ISupportInitialize)this.pbFigure).BeginInit();
			this.SuspendLayout();
			this.DCMetaDataTabs.set_Alignment(TabAlignment.Left);
			this.DCMetaDataTabs.set_BorderStyle(BorderStyle.None);
			this.DCMetaDataTabs.Controls.Add(this.MetaItemTab);
			this.DCMetaDataTabs.Controls.Add(this.LanguageTab);
			this.DCMetaDataTabs.Controls.Add(this.TermTab);
			this.DCMetaDataTabs.Dock = DockStyle.Fill;
			Control arg_399_0 = this.DCMetaDataTabs;
			Point location = new Point(0, 0);
			arg_399_0.Location = location;
			this.DCMetaDataTabs.Name = "DCMetaDataTabs";
			Control arg_3C6_0 = this.DCMetaDataTabs;
			Size size = new Size(960, 600);
			arg_3C6_0.Size = size;
			this.DCMetaDataTabs.TabIndex = 0;
			this.DCMetaDataTabs.set_TabStyle(typeof(TabRendererWorkbookMode));
			this.MetaItemTab.Controls.Add(this.splMain);
			this.MetaItemTab.Controls.Add(this.TopPanel);
			Control arg_429_0 = this.MetaItemTab;
			location = new Point(27, 0);
			arg_429_0.Location = location;
			this.MetaItemTab.Name = "MetaItemTab";
			Control arg_456_0 = this.MetaItemTab;
			size = new Size(933, 600);
			arg_456_0.Size = size;
			this.MetaItemTab.set_TabIndex(1);
			this.MetaItemTab.set_Text("数据项");
			this.MetaItemTab.set_ThemesEnabled(false);
			this.splMain.BorderStyle = BorderStyle.FixedSingle;
			this.splMain.Dock = DockStyle.Fill;
			Control arg_4AC_0 = this.splMain;
			location = new Point(0, 24);
			arg_4AC_0.Location = location;
			this.splMain.Name = "splMain";
			this.splMain.Panel1.AutoScroll = true;
			this.splMain.Panel1.Controls.Add(this.MainPanel);
			Control arg_505_0 = this.splMain;
			size = new Size(933, 576);
			arg_505_0.Size = size;
			this.splMain.SplitterDistance = 716;
			this.splMain.TabIndex = 3;
			this.MainPanel.Controls.Add(this.PropertyPanel);
			this.MainPanel.Controls.Add(this.TreeSplitter);
			this.MainPanel.Controls.Add(this.MTreePanel);
			this.MainPanel.Controls.Add(this.ToolPanel);
			this.MainPanel.Dock = DockStyle.Fill;
			Control arg_59A_0 = this.MainPanel;
			location = new Point(0, 0);
			arg_59A_0.Location = location;
			this.MainPanel.Name = "MainPanel";
			Control arg_5C7_0 = this.MainPanel;
			size = new Size(714, 574);
			arg_5C7_0.Size = size;
			this.MainPanel.TabIndex = 2;
			this.PropertyPanel.Controls.Add(this.PrivatePropertyPanel);
			this.PropertyPanel.Controls.Add(this.NamePanel);
			this.PropertyPanel.Dock = DockStyle.Fill;
			Control arg_624_0 = this.PropertyPanel;
			location = new Point(256, 0);
			arg_624_0.Location = location;
			this.PropertyPanel.Name = "PropertyPanel";
			Control arg_651_0 = this.PropertyPanel;
			size = new Size(458, 574);
			arg_651_0.Size = size;
			this.PropertyPanel.TabIndex = 3;
			this.PrivatePropertyPanel.Dock = DockStyle.Fill;
			Control arg_682_0 = this.PrivatePropertyPanel;
			location = new Point(0, 144);
			arg_682_0.Location = location;
			this.PrivatePropertyPanel.Name = "PrivatePropertyPanel";
			Control arg_6AF_0 = this.PrivatePropertyPanel;
			size = new Size(458, 430);
			arg_6AF_0.Size = size;
			this.PrivatePropertyPanel.TabIndex = 1;
			this.NamePanel.Controls.Add(this.ckbDataSynch);
			this.NamePanel.Controls.Add(this.cbxStatus);
			this.NamePanel.Controls.Add(this.lblStatus);
			this.NamePanel.Controls.Add(this.btnCancel);
			this.NamePanel.Controls.Add(this.btnBind);
			this.NamePanel.Controls.Add(this.lblBind);
			this.NamePanel.Controls.Add(this.txtDataBind);
			this.NamePanel.Controls.Add(this.cbxAllowNull);
			this.NamePanel.Controls.Add(this.txtDescription);
			this.NamePanel.Controls.Add(this.lblDescription);
			this.NamePanel.Controls.Add(this.txtName);
			this.NamePanel.Controls.Add(this.lblName);
			this.NamePanel.Dock = DockStyle.Top;
			Control arg_7E4_0 = this.NamePanel;
			location = new Point(0, 0);
			arg_7E4_0.Location = location;
			this.NamePanel.Name = "NamePanel";
			Control arg_811_0 = this.NamePanel;
			size = new Size(458, 144);
			arg_811_0.Size = size;
			this.NamePanel.TabIndex = 0;
			Control arg_837_0 = this.ckbDataSynch;
			location = new Point(396, 115);
			arg_837_0.Location = location;
			this.ckbDataSynch.Name = "ckbDataSynch";
			Control arg_85E_0 = this.ckbDataSynch;
			size = new Size(56, 24);
			arg_85E_0.Size = size;
			this.ckbDataSynch.TabIndex = 12;
			this.ckbDataSynch.Text = "同步";
			this.cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxStatus.Items.AddRange(new object[]
			{
				"创建",
				"发布",
				"停用"
			});
			Control arg_8CE_0 = this.cbxStatus;
			location = new Point(111, 88);
			arg_8CE_0.Location = location;
			this.cbxStatus.Name = "cbxStatus";
			Control arg_8F5_0 = this.cbxStatus;
			size = new Size(86, 20);
			arg_8F5_0.Size = size;
			this.cbxStatus.TabIndex = 11;
			Control arg_918_0 = this.lblStatus;
			location = new Point(6, 87);
			arg_918_0.Location = location;
			this.lblStatus.Name = "lblStatus";
			Control arg_93F_0 = this.lblStatus;
			size = new Size(105, 23);
			arg_93F_0.Size = size;
			this.lblStatus.TabIndex = 10;
			this.lblStatus.Text = "状态：";
			this.lblStatus.TextAlign = ContentAlignment.MiddleRight;
			Control arg_983_0 = this.btnCancel;
			location = new Point(340, 115);
			arg_983_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_9AA_0 = this.btnCancel;
			size = new Size(50, 23);
			arg_9AA_0.Size = size;
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "取消";
			Control arg_9E1_0 = this.btnBind;
			location = new Point(286, 114);
			arg_9E1_0.Location = location;
			this.btnBind.Name = "btnBind";
			Control arg_A08_0 = this.btnBind;
			size = new Size(50, 23);
			arg_A08_0.Size = size;
			this.btnBind.TabIndex = 8;
			this.btnBind.Text = "选择";
			Control arg_A3A_0 = this.lblBind;
			location = new Point(6, 114);
			arg_A3A_0.Location = location;
			this.lblBind.Name = "lblBind";
			Control arg_A61_0 = this.lblBind;
			size = new Size(105, 23);
			arg_A61_0.Size = size;
			this.lblBind.TabIndex = 7;
			this.lblBind.Text = "绑定：";
			this.lblBind.TextAlign = ContentAlignment.MiddleRight;
			Control arg_AA1_0 = this.txtDataBind;
			location = new Point(111, 114);
			arg_AA1_0.Location = location;
			this.txtDataBind.Name = "txtDataBind";
			Control arg_ACB_0 = this.txtDataBind;
			size = new Size(169, 21);
			arg_ACB_0.Size = size;
			this.txtDataBind.TabIndex = 8;
			Control arg_AF0_0 = this.cbxAllowNull;
			location = new Point(287, 7);
			arg_AF0_0.Location = location;
			this.cbxAllowNull.Name = "cbxAllowNull";
			Control arg_B17_0 = this.cbxAllowNull;
			size = new Size(93, 18);
			arg_B17_0.Size = size;
			this.cbxAllowNull.TabIndex = 5;
			this.cbxAllowNull.Text = "不允许为空";
			Control arg_B4A_0 = this.txtDescription;
			location = new Point(111, 34);
			arg_B4A_0.Location = location;
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			Control arg_B80_0 = this.txtDescription;
			size = new Size(329, 44);
			arg_B80_0.Size = size;
			this.txtDescription.TabIndex = 3;
			Control arg_BA2_0 = this.lblDescription;
			location = new Point(6, 36);
			arg_BA2_0.Location = location;
			this.lblDescription.Name = "lblDescription";
			Control arg_BC9_0 = this.lblDescription;
			size = new Size(105, 23);
			arg_BC9_0.Size = size;
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "说明：";
			this.lblDescription.TextAlign = ContentAlignment.MiddleRight;
			Control arg_C08_0 = this.txtName;
			location = new Point(111, 5);
			arg_C08_0.Location = location;
			this.txtName.Name = "txtName";
			Control arg_C32_0 = this.txtName;
			size = new Size(169, 21);
			arg_C32_0.Size = size;
			this.txtName.TabIndex = 1;
			Control arg_C53_0 = this.lblName;
			location = new Point(6, 5);
			arg_C53_0.Location = location;
			this.lblName.Name = "lblName";
			Control arg_C7A_0 = this.lblName;
			size = new Size(105, 23);
			arg_C7A_0.Size = size;
			this.lblName.TabIndex = 0;
			this.lblName.Text = "名称：";
			this.lblName.TextAlign = ContentAlignment.MiddleRight;
			this.TreeSplitter.BackColor = SystemColors.Control;
			Control arg_CCC_0 = this.TreeSplitter;
			location = new Point(248, 0);
			arg_CCC_0.Location = location;
			this.TreeSplitter.Name = "TreeSplitter";
			Control arg_CF5_0 = this.TreeSplitter;
			size = new Size(8, 574);
			arg_CF5_0.Size = size;
			this.TreeSplitter.TabIndex = 2;
			this.TreeSplitter.TabStop = false;
			this.MTreePanel.Dock = DockStyle.Left;
			Control arg_D2F_0 = this.MTreePanel;
			location = new Point(40, 0);
			arg_D2F_0.Location = location;
			this.MTreePanel.Name = "MTreePanel";
			Control arg_D54_0 = this.MTreePanel;
			Padding padding = new Padding(5);
			arg_D54_0.Padding = padding;
			Control arg_D71_0 = this.MTreePanel;
			size = new Size(208, 574);
			arg_D71_0.Size = size;
			this.MTreePanel.TabIndex = 1;
			this.ToolPanel.Controls.Add(this.pbPosition);
			this.ToolPanel.Controls.Add(this.pbImageAnnotate);
			this.ToolPanel.Controls.Add(this.pbSegment);
			this.ToolPanel.Controls.Add(this.pbTextDesc);
			this.ToolPanel.Controls.Add(this.pbCluster);
			this.ToolPanel.Controls.Add(this.pbTable);
			this.ToolPanel.Controls.Add(this.pbDictionary);
			this.ToolPanel.Controls.Add(this.pbDateTime);
			this.ToolPanel.Controls.Add(this.pbQuantity);
			this.ToolPanel.Controls.Add(this.pbMultiChoice);
			this.ToolPanel.Controls.Add(this.pbMonoChoice);
			this.ToolPanel.Controls.Add(this.pbNumber);
			this.ToolPanel.Controls.Add(this.btnDown);
			this.ToolPanel.Controls.Add(this.btnUp);
			this.ToolPanel.Controls.Add(this.btnRemove);
			this.ToolPanel.Controls.Add(this.btnAdd);
			this.ToolPanel.Controls.Add(this.pbString);
			this.ToolPanel.Controls.Add(this.pbLink);
			this.ToolPanel.Controls.Add(this.pbFigure);
			this.ToolPanel.Dock = DockStyle.Left;
			Control arg_F40_0 = this.ToolPanel;
			location = new Point(0, 0);
			arg_F40_0.Location = location;
			this.ToolPanel.Name = "ToolPanel";
			Control arg_F6A_0 = this.ToolPanel;
			size = new Size(40, 574);
			arg_F6A_0.Size = size;
			this.ToolPanel.TabIndex = 0;
			this.pbPosition.BorderStyle = BorderStyle.Fixed3D;
			this.pbPosition.Image = (Image)componentResourceManager.GetObject("pbPosition.Image");
			Control arg_FB6_0 = this.pbPosition;
			location = new Point(8, 305);
			arg_FB6_0.Location = location;
			this.pbPosition.Name = "pbPosition";
			Control arg_FDD_0 = this.pbPosition;
			size = new Size(26, 26);
			arg_FDD_0.Size = size;
			this.pbPosition.TabIndex = 16;
			this.pbPosition.TabStop = false;
			this.pbImageAnnotate.BorderStyle = BorderStyle.Fixed3D;
			this.pbImageAnnotate.Image = (Image)componentResourceManager.GetObject("pbImageAnnotate.Image");
			Control arg_1036_0 = this.pbImageAnnotate;
			location = new Point(8, 464);
			arg_1036_0.Location = location;
			this.pbImageAnnotate.Name = "pbImageAnnotate";
			Control arg_105D_0 = this.pbImageAnnotate;
			size = new Size(26, 26);
			arg_105D_0.Size = size;
			this.pbImageAnnotate.TabIndex = 15;
			this.pbImageAnnotate.TabStop = false;
			this.pbSegment.BorderStyle = BorderStyle.Fixed3D;
			this.pbSegment.Image = (Image)componentResourceManager.GetObject("pbSegment.Image");
			Control arg_10B6_0 = this.pbSegment;
			location = new Point(8, 357);
			arg_10B6_0.Location = location;
			this.pbSegment.Name = "pbSegment";
			Control arg_10DD_0 = this.pbSegment;
			size = new Size(26, 26);
			arg_10DD_0.Size = size;
			this.pbSegment.TabIndex = 14;
			this.pbSegment.TabStop = false;
			this.pbTextDesc.BorderStyle = BorderStyle.Fixed3D;
			this.pbTextDesc.Image = (Image)componentResourceManager.GetObject("pbTextDesc.Image");
			Control arg_1136_0 = this.pbTextDesc;
			location = new Point(8, 437);
			arg_1136_0.Location = location;
			this.pbTextDesc.Name = "pbTextDesc";
			Control arg_115D_0 = this.pbTextDesc;
			size = new Size(26, 26);
			arg_115D_0.Size = size;
			this.pbTextDesc.TabIndex = 12;
			this.pbTextDesc.TabStop = false;
			this.pbCluster.BorderStyle = BorderStyle.Fixed3D;
			this.pbCluster.Image = (Image)componentResourceManager.GetObject("pbCluster.Image");
			Control arg_11B6_0 = this.pbCluster;
			location = new Point(8, 410);
			arg_11B6_0.Location = location;
			this.pbCluster.Name = "pbCluster";
			Control arg_11DD_0 = this.pbCluster;
			size = new Size(26, 26);
			arg_11DD_0.Size = size;
			this.pbCluster.TabIndex = 11;
			this.pbCluster.TabStop = false;
			this.pbTable.BorderStyle = BorderStyle.Fixed3D;
			this.pbTable.Image = (Image)componentResourceManager.GetObject("pbTable.Image");
			Control arg_1236_0 = this.pbTable;
			location = new Point(8, 383);
			arg_1236_0.Location = location;
			this.pbTable.Name = "pbTable";
			Control arg_125D_0 = this.pbTable;
			size = new Size(26, 26);
			arg_125D_0.Size = size;
			this.pbTable.TabIndex = 10;
			this.pbTable.TabStop = false;
			this.pbDictionary.BorderStyle = BorderStyle.Fixed3D;
			this.pbDictionary.Image = (Image)componentResourceManager.GetObject("pbDictionary.Image");
			Control arg_12B6_0 = this.pbDictionary;
			location = new Point(8, 279);
			arg_12B6_0.Location = location;
			this.pbDictionary.Name = "pbDictionary";
			Control arg_12DD_0 = this.pbDictionary;
			size = new Size(26, 26);
			arg_12DD_0.Size = size;
			this.pbDictionary.TabIndex = 9;
			this.pbDictionary.TabStop = false;
			this.pbDateTime.BorderStyle = BorderStyle.Fixed3D;
			this.pbDateTime.Image = (Image)componentResourceManager.GetObject("pbDateTime.Image");
			Control arg_1336_0 = this.pbDateTime;
			location = new Point(8, 253);
			arg_1336_0.Location = location;
			this.pbDateTime.Name = "pbDateTime";
			Control arg_135D_0 = this.pbDateTime;
			size = new Size(26, 26);
			arg_135D_0.Size = size;
			this.pbDateTime.TabIndex = 8;
			this.pbDateTime.TabStop = false;
			this.pbQuantity.BorderStyle = BorderStyle.Fixed3D;
			this.pbQuantity.Image = (Image)componentResourceManager.GetObject("pbQuantity.Image");
			Control arg_13B5_0 = this.pbQuantity;
			location = new Point(8, 227);
			arg_13B5_0.Location = location;
			this.pbQuantity.Name = "pbQuantity";
			Control arg_13DC_0 = this.pbQuantity;
			size = new Size(26, 26);
			arg_13DC_0.Size = size;
			this.pbQuantity.TabIndex = 7;
			this.pbQuantity.TabStop = false;
			this.pbMultiChoice.BorderStyle = BorderStyle.Fixed3D;
			this.pbMultiChoice.Image = (Image)componentResourceManager.GetObject("pbMultiChoice.Image");
			Control arg_1434_0 = this.pbMultiChoice;
			location = new Point(8, 201);
			arg_1434_0.Location = location;
			this.pbMultiChoice.Name = "pbMultiChoice";
			Control arg_145B_0 = this.pbMultiChoice;
			size = new Size(26, 26);
			arg_145B_0.Size = size;
			this.pbMultiChoice.TabIndex = 6;
			this.pbMultiChoice.TabStop = false;
			this.pbMonoChoice.BorderStyle = BorderStyle.Fixed3D;
			this.pbMonoChoice.Image = (Image)componentResourceManager.GetObject("pbMonoChoice.Image");
			Control arg_14B3_0 = this.pbMonoChoice;
			location = new Point(8, 175);
			arg_14B3_0.Location = location;
			this.pbMonoChoice.Name = "pbMonoChoice";
			Control arg_14DA_0 = this.pbMonoChoice;
			size = new Size(26, 26);
			arg_14DA_0.Size = size;
			this.pbMonoChoice.TabIndex = 5;
			this.pbMonoChoice.TabStop = false;
			this.pbNumber.BorderStyle = BorderStyle.Fixed3D;
			this.pbNumber.Image = (Image)componentResourceManager.GetObject("pbNumber.Image");
			Control arg_1532_0 = this.pbNumber;
			location = new Point(8, 149);
			arg_1532_0.Location = location;
			this.pbNumber.Name = "pbNumber";
			Control arg_1559_0 = this.pbNumber;
			size = new Size(26, 26);
			arg_1559_0.Size = size;
			this.pbNumber.TabIndex = 4;
			this.pbNumber.TabStop = false;
			Control arg_1587_0 = this.btnDown;
			location = new Point(8, 87);
			arg_1587_0.Location = location;
			this.btnDown.Name = "btnDown";
			Control arg_15AE_0 = this.btnDown;
			size = new Size(26, 26);
			arg_15AE_0.Size = size;
			this.btnDown.TabIndex = 3;
			this.btnDown.Text = "↓";
			Control arg_15E0_0 = this.btnUp;
			location = new Point(8, 60);
			arg_15E0_0.Location = location;
			this.btnUp.Name = "btnUp";
			Control arg_1607_0 = this.btnUp;
			size = new Size(26, 26);
			arg_1607_0.Size = size;
			this.btnUp.TabIndex = 2;
			this.btnUp.Text = "↑";
			Control arg_1639_0 = this.btnRemove;
			location = new Point(8, 34);
			arg_1639_0.Location = location;
			this.btnRemove.Name = "btnRemove";
			Control arg_1660_0 = this.btnRemove;
			size = new Size(26, 26);
			arg_1660_0.Size = size;
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "-";
			Control arg_1691_0 = this.btnAdd;
			location = new Point(8, 8);
			arg_1691_0.Location = location;
			this.btnAdd.Name = "btnAdd";
			Control arg_16B8_0 = this.btnAdd;
			size = new Size(26, 26);
			arg_16B8_0.Size = size;
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "+";
			this.pbString.BorderStyle = BorderStyle.Fixed3D;
			this.pbString.Image = (Image)componentResourceManager.GetObject("pbString.Image");
			Control arg_1711_0 = this.pbString;
			location = new Point(8, 123);
			arg_1711_0.Location = location;
			this.pbString.Name = "pbString";
			Control arg_1738_0 = this.pbString;
			size = new Size(26, 26);
			arg_1738_0.Size = size;
			this.pbString.TabIndex = 0;
			this.pbString.TabStop = false;
			this.pbLink.BorderStyle = BorderStyle.Fixed3D;
			this.pbLink.Image = (Image)componentResourceManager.GetObject("pbLink.Image");
			Control arg_1790_0 = this.pbLink;
			location = new Point(8, 331);
			arg_1790_0.Location = location;
			this.pbLink.Name = "pbLink";
			Control arg_17B7_0 = this.pbLink;
			size = new Size(26, 26);
			arg_17B7_0.Size = size;
			this.pbLink.TabIndex = 13;
			this.pbLink.TabStop = false;
			this.pbFigure.BorderStyle = BorderStyle.Fixed3D;
			this.pbFigure.Image = (Image)componentResourceManager.GetObject("pbFigure.Image");
			Control arg_1810_0 = this.pbFigure;
			location = new Point(8, 492);
			arg_1810_0.Location = location;
			this.pbFigure.Name = "pbFigure";
			Control arg_1837_0 = this.pbFigure;
			size = new Size(26, 26);
			arg_1837_0.Size = size;
			this.pbFigure.TabIndex = 17;
			this.pbFigure.TabStop = false;
			this.TopPanel.Dock = DockStyle.Top;
			Control arg_1871_0 = this.TopPanel;
			location = new Point(0, 0);
			arg_1871_0.Location = location;
			this.TopPanel.Name = "TopPanel";
			Control arg_189B_0 = this.TopPanel;
			size = new Size(933, 24);
			arg_189B_0.Size = size;
			this.TopPanel.TabIndex = 1;
			Control arg_18BD_0 = this.LanguageTab;
			location = new Point(27, 0);
			arg_18BD_0.Location = location;
			this.LanguageTab.Name = "LanguageTab";
			Control arg_18EA_0 = this.LanguageTab;
			size = new Size(933, 600);
			arg_18EA_0.Size = size;
			this.LanguageTab.set_TabIndex(1);
			this.LanguageTab.set_Text("语言");
			this.LanguageTab.set_ThemesEnabled(false);
			Control arg_1928_0 = this.TermTab;
			location = new Point(27, 0);
			arg_1928_0.Location = location;
			this.TermTab.Name = "TermTab";
			Control arg_1955_0 = this.TermTab;
			size = new Size(933, 600);
			arg_1955_0.Size = size;
			this.TermTab.set_TabIndex(2);
			this.TermTab.set_Text("术语");
			this.TermTab.set_ThemesEnabled(false);
			this.designTimeTabTypeLoader.set_InvokeMemberName("TabStyleName");
			this.Controls.Add(this.DCMetaDataTabs);
			this.Name = "DCMetaData";
			size = new Size(960, 600);
			this.Size = size;
			this.DCMetaDataTabs.EndInit();
			this.DCMetaDataTabs.ResumeLayout(false);
			this.MetaItemTab.ResumeLayout(false);
			this.splMain.Panel1.ResumeLayout(false);
			this.splMain.ResumeLayout(false);
			this.MainPanel.ResumeLayout(false);
			this.PropertyPanel.ResumeLayout(false);
			this.NamePanel.ResumeLayout(false);
			this.NamePanel.PerformLayout();
			this.ToolPanel.ResumeLayout(false);
			((ISupportInitialize)this.pbPosition).EndInit();
			((ISupportInitialize)this.pbImageAnnotate).EndInit();
			((ISupportInitialize)this.pbSegment).EndInit();
			((ISupportInitialize)this.pbTextDesc).EndInit();
			((ISupportInitialize)this.pbCluster).EndInit();
			((ISupportInitialize)this.pbTable).EndInit();
			((ISupportInitialize)this.pbDictionary).EndInit();
			((ISupportInitialize)this.pbDateTime).EndInit();
			((ISupportInitialize)this.pbQuantity).EndInit();
			((ISupportInitialize)this.pbMultiChoice).EndInit();
			((ISupportInitialize)this.pbMonoChoice).EndInit();
			((ISupportInitialize)this.pbNumber).EndInit();
			((ISupportInitialize)this.pbString).EndInit();
			((ISupportInitialize)this.pbLink).EndInit();
			((ISupportInitialize)this.pbFigure).EndInit();
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.MetaItemTree = new MetaItemTree();
			this.MetaItemTree.Dock = DockStyle.Fill;
			this.MTreePanel.Controls.Add(this.MetaItemTree);
			this.cmMetaItemTree = new ContextMenu();
			this.miEdit = new MenuItem("编辑属性");
			this.miCopy = new MenuItem("复制单元");
			this.miPaste = new MenuItem("粘贴单元");
			this.miDelete = new MenuItem("删除单元");
			this.miExportMetaItem = new MenuItem("将元数据列表导出到剪贴板");
			this.miExportMetaItem.Click += new EventHandler(this.OnExport);
			this.miEdit.Click += new EventHandler(this.OnEdit);
			this.miDelete.Click += new EventHandler(this.OnDelete);
			this.miCopy.Click += new EventHandler(this.OnCopy);
			this.miPaste.Click += new EventHandler(this.OnPaste);
			this.cmMetaItemTree.MenuItems.Add(this.miEdit);
			this.cmMetaItemTree.MenuItems.Add(this.miCopy);
			this.cmMetaItemTree.MenuItems.Add(this.miPaste);
			this.cmMetaItemTree.MenuItems.Add(this.miDelete);
			this.cmMetaItemTree.MenuItems.Add(this.miExportMetaItem);
			this._ToolTip = new ToolTip();
			this._ToolTip.SetToolTip(this.pbString, "字符型");
			this._ToolTip.SetToolTip(this.pbNumber, "数值型");
			this._ToolTip.SetToolTip(this.pbMonoChoice, "单选型");
			this._ToolTip.SetToolTip(this.pbMultiChoice, "多选型");
			this._ToolTip.SetToolTip(this.pbQuantity, "数量型");
			this._ToolTip.SetToolTip(this.pbDateTime, "日期时间型");
			this._ToolTip.SetToolTip(this.pbDictionary, "字典型");
			this._ToolTip.SetToolTip(this.pbLink, "链接型");
			this._ToolTip.SetToolTip(this.pbPosition, "位置型");
			this._ToolTip.SetToolTip(this.pbSegment, "文本片断型");
			this._ToolTip.SetToolTip(this.pbTextDesc, "文本描述型");
			this._ToolTip.SetToolTip(this.pbTable, "表格型");
			this._ToolTip.SetToolTip(this.pbCluster, "集合型");
			this._ToolTip.SetToolTip(this.pbImageAnnotate, "图像标注型");
			this._ToolTip.SetToolTip(this.pbFigure, "图像型");
			this.mBindData = new BindData();
			this.splMain.Panel2.Controls.Add(this.mBindData);
			this.mBindData.Dock = DockStyle.Fill;
			this.mBindData.DCMetaData = this;
			this.mBindData.Init();
			this.splMain.Panel2Collapsed = true;
		}

		private void pbGroup_MouseDown(object sender, MouseEventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, "pbString", false))
			{
				this._DragMetaItem = new MIString();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbNumber", false))
			{
				this._DragMetaItem = new MINumber();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbMonoChoice", false))
			{
				this._DragMetaItem = new MIMonoChoice();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbMultiChoice", false))
			{
				this._DragMetaItem = new MIMultiChoice();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbDateTime", false))
			{
				this._DragMetaItem = new MIDateTime();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbQuantity", false))
			{
				this._DragMetaItem = new MIQuantity();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbDictionary", false))
			{
				this._DragMetaItem = new MIDictionary();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbLink", false))
			{
				this._DragMetaItem = new MILink();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbSegment", false))
			{
				this._DragMetaItem = new MISegment();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbTable", false))
			{
				this._DragMetaItem = new MITable();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbCluster", false))
			{
				this._DragMetaItem = new MICluster();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbTextDesc", false))
			{
				this._DragMetaItem = new MITextDesc();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbImageAnnotate", false))
			{
				this._DragMetaItem = new MIImageAnnotate();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbPosition", false))
			{
				this._DragMetaItem = new MIPosition();
			}
			else if (Operators.ConditionalCompareObjectEqual(left, "pbFigure", false))
			{
				this._DragMetaItem = new MIFigure();
			}
			NewLateBinding.LateSet(sender, null, "AllowDrop", new object[]
			{
				true
			}, null, null);
			Type arg_21C_1 = null;
			string arg_21C_2 = "DoDragDrop";
			object[] array = new object[]
			{
				this._DragMetaItem,
				DragDropEffects.Copy
			};
			object[] arg_21C_3 = array;
			string[] arg_21C_4 = null;
			Type[] arg_21C_5 = null;
			bool[] array2 = new bool[]
			{
				true,
				false
			};
			NewLateBinding.LateCall(sender, arg_21C_1, arg_21C_2, arg_21C_3, arg_21C_4, arg_21C_5, array2, true);
			if (array2[0])
			{
				this._DragMetaItem = (MMetaItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(MMetaItem));
			}
		}

		private void pbGroup_MouseUp(object sender, MouseEventArgs e)
		{
			this._DragMetaItem = null;
		}

		private void MetaItemTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		private void MetaItemTree_MouseDown(object sender, MouseEventArgs e)
		{
			Point point;
			point.X = e.X;
			point.Y = e.Y;
			if (e.Button == MouseButtons.Right)
			{
				this._needInitCurItem = false;
			}
			else
			{
				this._needInitCurItem = true;
			}
			this._SelectNode = this.MetaItemTree.GetNodeAt(point);
			if (this._SelectNode != null)
			{
				this.MetaItemTree.SelectedNode = this._SelectNode;
				if (e.Button == MouseButtons.Right)
				{
					if (this._SelectNode.Tag is MISimple)
					{
						this.miCopy.Enabled = true;
					}
					else
					{
						this.miCopy.Enabled = false;
					}
					if (DCMetaData.CopyMetaItem == null)
					{
						this.miPaste.Enabled = false;
					}
					else
					{
						this.miPaste.Enabled = true;
						MMetaItem mMetaItem = (MMetaItem)this._SelectNode.Tag;
						if (mMetaItem is MITable & mMetaItem.BindControl)
						{
							this.miPaste.Enabled = false;
						}
					}
					this._MouseRightKey = true;
					this.cmMetaItemTree.Show(this.MetaItemTree, point);
				}
				else
				{
					this._MouseRightKey = false;
				}
			}
		}

		private void MetaItemTree_MouseUp(object sender, MouseEventArgs e)
		{
			MMetaItem mMetaItem = (MMetaItem)this.MetaItemTree.SelectedNode.Tag;
			if (this._needInitCurItem)
			{
				this.CurrentMetaItem = (MMetaItem)this.MetaItemTree.SelectedNode.Tag;
				this.mBindData.TagItemCode = this.CurrentMetaItem.Code;
			}
		}

		public void MetaItemTree_KeyUp(object sender, KeyEventArgs e)
		{
			MMetaItem mMetaItem = (MMetaItem)this.MetaItemTree.SelectedNode.Tag;
			this.CurrentMetaItem = (MMetaItem)this.MetaItemTree.SelectedNode.Tag;
			this.mBindData.TagItemCode = this.CurrentMetaItem.Code;
		}

		public void OnEdit(object sender, EventArgs e)
		{
			this.CurrentMetaItem = (MMetaItem)this._SelectNode.Tag;
		}

		public void OnDelete(object sender, EventArgs e)
		{
			this.MetaItemTree.DeleteNode();
		}

		public void OnExport(object sender, EventArgs e)
		{
			this.MetaItemTree.ExportNode();
		}

		public void OnCopy(object sender, EventArgs e)
		{
			MMetaItem mMetaItem = (MMetaItem)this._SelectNode.Tag;
			MMetaItem mMetaItem2 = (MMetaItem)mMetaItem.Clone();
			mMetaItem2.Code = "";
			DCMetaData.CopyMetaItem = mMetaItem2;
		}

		public void OnPaste(object sender, EventArgs e)
		{
			MMetaItem mMetaItem = (MMetaItem)DCMetaData.CopyMetaItem.Clone();
			mMetaItem.Code = "";
			mMetaItem.BindControl = false;
			mMetaItem.Status = EPRStatus.Create;
			this._MetaItem.InitMetaItem(mMetaItem);
			this.MetaItemTree.InsertMetaItem(mMetaItem);
		}

		private void cbxAllowNull_CheckedChanged(object sender, EventArgs e)
		{
			MISimple mISimple = (MISimple)this._CurrentMetaItem;
			mISimple.AllowNull = this.cbxAllowNull.Checked;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			this._CurrentMetaItem.Text = this.txtName.Text;
			this.CurrentNode.Text = this.txtName.Text;
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			this._CurrentMetaItem.Description = this.txtDescription.Text;
		}

		private void txtName_GotFocus(object sender, EventArgs e)
		{
			this._bakName = this.txtName.Text;
		}

		private void txtName_LostFocus(object sender, EventArgs e)
		{
			if (this.txtName.Text == null || Operators.CompareString(this.txtName.Text, "", false) == 0)
			{
				this.txtName.Text = this._bakName;
				this._CurrentMetaItem.Text = this._bakName;
				this.CurrentNode.Text = this._bakName;
				MessageManager.ShowWarningMessage("名称不能为空！");
			}
		}

		private void btnBind_Click(object sender, EventArgs e)
		{
			this.splMain.Panel2Collapsed = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this._CurrentMetaItem.DataBaseBindCode = "";
			this._CurrentMetaItem.EPRBindCode = "";
			this.txtDataBind.Text = "";
			this.ckbDataSynch.Enabled = false;
			this.ckbDataSynch.Checked = false;
			this._CurrentMetaItem.Synch = false;
		}

		private void ckbDataSynch_CheckedChanged(object sender, EventArgs e)
		{
			this._CurrentMetaItem.Synch = this.ckbDataSynch.Checked;
		}

		private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.AutoSetStatus)
			{
				return;
			}
			if (this._CurrentMetaItem != null)
			{
				switch (this._CurrentMetaItem.Status)
				{
				case EPRStatus.Create:
					MessageManager.ShowWarningMessage("创建单元，不能手工修改状态！");
					this.AutoSetStatus = true;
					this.cbxStatus.SelectedIndex = 0;
					this.AutoSetStatus = false;
					break;
				case EPRStatus.Publish:
					if (this.cbxStatus.SelectedIndex == 0)
					{
						MessageManager.ShowWarningMessage("已发布单元，不能手工改为创建状态！");
						this.cbxStatus.SelectedIndex = 1;
					}
					else if (this.cbxStatus.SelectedIndex == 2)
					{
						if (this._CurrentMetaItem.BindControl | this._CurrentMetaItem.BindLabel)
						{
							MessageManager.ShowWarningMessage("该单元或其标签已被拖拽到界面模板上，请先移除该单元及其标签！");
							this.AutoSetStatus = true;
							this.cbxStatus.SelectedIndex = 1;
							this.AutoSetStatus = false;
						}
						else if (this._CurrentMetaItem.Parent != null && this._CurrentMetaItem.Parent is MISegment && this._CurrentMetaItem.BindInstanceItem != null)
						{
							MessageManager.ShowWarningMessage("单元已被引用，请先从界面移除对该单元的引用！");
							this.AutoSetStatus = true;
							this.cbxStatus.SelectedIndex = 1;
							this.AutoSetStatus = false;
						}
						else if (this._CurrentMetaItem.Parent != null && this._CurrentMetaItem.Parent is MITable && (this._CurrentMetaItem.Parent.BindControl | this._CurrentMetaItem.Parent.BindLabel))
						{
							MessageManager.ShowWarningMessage("单元已被引用，请先从界面移除对该单元的引用！");
							this.AutoSetStatus = true;
							this.cbxStatus.SelectedIndex = 1;
							this.AutoSetStatus = false;
						}
						else
						{
							this._CurrentMetaItem.Status = EPRStatus.ABandon;
							this._SelectNode.ForeColor = Color.Silver;
							if (this._SelectNode.GetNodeCount(true) > 0)
							{
								try
								{
									IEnumerator enumerator = this._SelectNode.Nodes.GetEnumerator();
									while (enumerator.MoveNext())
									{
										TreeNode treeNode = (TreeNode)enumerator.Current;
										treeNode.ForeColor = Color.Silver;
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
					break;
				case EPRStatus.ABandon:
					if (this.cbxStatus.SelectedIndex == 0)
					{
						MessageManager.ShowWarningMessage("已停用单元，不能手工改为创建状态！");
						this.AutoSetStatus = true;
						this.cbxStatus.SelectedIndex = 2;
						this.AutoSetStatus = false;
					}
					else if (this.cbxStatus.SelectedIndex == 1)
					{
						this._CurrentMetaItem.Status = EPRStatus.Publish;
						this._SelectNode.ForeColor = Color.Black;
						if (this._SelectNode.GetNodeCount(true) > 0)
						{
							try
							{
								IEnumerator enumerator2 = this._SelectNode.Nodes.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									TreeNode treeNode2 = (TreeNode)enumerator2.Current;
									treeNode2.ForeColor = Color.Black;
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
					break;
				}
			}
		}
	}
}
