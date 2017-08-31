using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
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
	public class MMetaDataProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("txtBindKBName")]
		private TextBox _txtBindKBName;

		[AccessedThroughProperty("btnKB")]
		private Button _btnKB;

		[AccessedThroughProperty("cbxBindKB")]
		private CheckBox _cbxBindKB;

		[AccessedThroughProperty("FormulaTabs")]
		private TabControlAdv _FormulaTabs;

		[AccessedThroughProperty("AuditTab")]
		private TabPageAdv _AuditTab;

		[AccessedThroughProperty("CalculateTab")]
		private TabPageAdv _CalculateTab;

		[AccessedThroughProperty("btnAuditCompileAll")]
		private Button _btnAuditCompileAll;

		[AccessedThroughProperty("btnAuditCompile")]
		private Button _btnAuditCompile;

		[AccessedThroughProperty("btnAuditDown")]
		private Button _btnAuditDown;

		[AccessedThroughProperty("btnAuditUp")]
		private Button _btnAuditUp;

		[AccessedThroughProperty("btnAuditUpdate")]
		private Button _btnAuditUpdate;

		[AccessedThroughProperty("btnAuditDelete")]
		private Button _btnAuditDelete;

		[AccessedThroughProperty("btnAuditAdd")]
		private Button _btnAuditAdd;

		[AccessedThroughProperty("lblAuditDesc")]
		private Label _lblAuditDesc;

		[AccessedThroughProperty("lblAuditFormula")]
		private Label _lblAuditFormula;

		[AccessedThroughProperty("txtAuditDesc")]
		private TextBox _txtAuditDesc;

		[AccessedThroughProperty("txtAuditFormula")]
		private TextBox _txtAuditFormula;

		[AccessedThroughProperty("btnCalCompileAll")]
		private Button _btnCalCompileAll;

		[AccessedThroughProperty("btnCalCompile")]
		private Button _btnCalCompile;

		[AccessedThroughProperty("btnCalDown")]
		private Button _btnCalDown;

		[AccessedThroughProperty("btnCalUp")]
		private Button _btnCalUp;

		[AccessedThroughProperty("btnCalUpdate")]
		private Button _btnCalUpdate;

		[AccessedThroughProperty("btnCalDelete")]
		private Button _btnCalDelete;

		[AccessedThroughProperty("btnCalAdd")]
		private Button _btnCalAdd;

		[AccessedThroughProperty("lblCalDesc")]
		private Label _lblCalDesc;

		[AccessedThroughProperty("lblCalFormula")]
		private Label _lblCalFormula;

		[AccessedThroughProperty("txtCalDesc")]
		private TextBox _txtCalDesc;

		[AccessedThroughProperty("txtCalFormula")]
		private TextBox _txtCalFormula;

		[AccessedThroughProperty("CalGrid")]
		private DataGrid _CalGrid;

		[AccessedThroughProperty("AuditGrid")]
		private DataGrid _AuditGrid;

		[AccessedThroughProperty("AuditGridTableStyle")]
		private DataGridTableStyle _AuditGridTableStyle;

		[AccessedThroughProperty("colAuditFormula")]
		private DataGridTextBoxColumn _colAuditFormula;

		[AccessedThroughProperty("colAuditDesc")]
		private DataGridTextBoxColumn _colAuditDesc;

		[AccessedThroughProperty("btnRemove")]
		private Button _btnRemove;

		[AccessedThroughProperty("TipTab")]
		private TabPageAdv _TipTab;

		[AccessedThroughProperty("btnTipCompileAll")]
		private Button _btnTipCompileAll;

		[AccessedThroughProperty("btnTipCompile")]
		private Button _btnTipCompile;

		[AccessedThroughProperty("btnTipDown")]
		private Button _btnTipDown;

		[AccessedThroughProperty("btnTipUp")]
		private Button _btnTipUp;

		[AccessedThroughProperty("btnTipUpdate")]
		private Button _btnTipUpdate;

		[AccessedThroughProperty("btnTipDelete")]
		private Button _btnTipDelete;

		[AccessedThroughProperty("btnTipAdd")]
		private Button _btnTipAdd;

		[AccessedThroughProperty("lblTipDesc")]
		private Label _lblTipDesc;

		[AccessedThroughProperty("lblTipFormula")]
		private Label _lblTipFormula;

		[AccessedThroughProperty("txtTipDesc")]
		private TextBox _txtTipDesc;

		[AccessedThroughProperty("txtTipFormula")]
		private TextBox _txtTipFormula;

		[AccessedThroughProperty("DataGrid2")]
		private DataGrid _DataGrid2;

		[AccessedThroughProperty("DataGrid1")]
		private DataGrid _DataGrid1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[AccessedThroughProperty("TabPageAdv1")]
		private TabPageAdv _TabPageAdv1;

		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		[AccessedThroughProperty("TabPageAdv2")]
		private TabPageAdv _TabPageAdv2;

		[AccessedThroughProperty("DataGrid3")]
		private DataGrid _DataGrid3;

		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		[AccessedThroughProperty("TextBox6")]
		private TextBox _TextBox6;

		[AccessedThroughProperty("TipGrid")]
		private DataGrid _TipGrid;

		[AccessedThroughProperty("TipGridTableStyle")]
		private DataGridTableStyle _TipGridTableStyle;

		[AccessedThroughProperty("CalGridTableStyle")]
		private DataGridTableStyle _CalGridTableStyle;

		[AccessedThroughProperty("colCalFormula")]
		private DataGridTextBoxColumn _colCalFormula;

		[AccessedThroughProperty("colCalDesc")]
		private DataGridTextBoxColumn _colCalDesc;

		[AccessedThroughProperty("colTipFormula")]
		private DataGridTextBoxColumn _colTipFormula;

		[AccessedThroughProperty("colTipDesc")]
		private DataGridTextBoxColumn _colTipDesc;

		[AccessedThroughProperty("TabPageAdv3")]
		private TabPageAdv _TabPageAdv3;

		private int CurrentCalRow;

		private int CurrentAuditRow;

		private int CurrentTipRow;

		private MFormulaItemCollection CalFormulaItems;

		private MFormulaItemCollection AuditFormulaItems;

		private MFormulaItemCollection TipFormulaItems;

		private MFormulaItemCollection tmpCalFormulaItems;

		private MFormulaItemCollection tmpAuditFormulaItems;

		private MFormulaItemCollection tmpTipFormulaItems;

		private bool IsCalBind;

		private bool IsAuditBind;

		private bool IsTipBind;

		private MMetaData _MetaData;

		public MetaItemTree MetaItemTree;

		internal virtual TextBox txtBindKBName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBindKBName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBindKBName = value;
			}
		}

		internal virtual Button btnKB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnKB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnKB_Click);
				if (this._btnKB != null)
				{
					this._btnKB.Click -= value2;
				}
				this._btnKB = value;
				if (this._btnKB != null)
				{
					this._btnKB.Click += value2;
				}
			}
		}

		internal virtual CheckBox cbxBindKB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxBindKB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxBindKB_CheckedChanged);
				if (this._cbxBindKB != null)
				{
					this._cbxBindKB.CheckedChanged -= value2;
				}
				this._cbxBindKB = value;
				if (this._cbxBindKB != null)
				{
					this._cbxBindKB.CheckedChanged += value2;
				}
			}
		}

		internal virtual TabControlAdv FormulaTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FormulaTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FormulaTabs = value;
			}
		}

		internal virtual TabPageAdv AuditTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AuditTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AuditTab = value;
			}
		}

		internal virtual TabPageAdv CalculateTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CalculateTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CalculateTab = value;
			}
		}

		internal virtual Button btnAuditCompileAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditCompileAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditCompileAll_Click);
				if (this._btnAuditCompileAll != null)
				{
					this._btnAuditCompileAll.Click -= value2;
				}
				this._btnAuditCompileAll = value;
				if (this._btnAuditCompileAll != null)
				{
					this._btnAuditCompileAll.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditCompile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditCompile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditCompile_Click);
				if (this._btnAuditCompile != null)
				{
					this._btnAuditCompile.Click -= value2;
				}
				this._btnAuditCompile = value;
				if (this._btnAuditCompile != null)
				{
					this._btnAuditCompile.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditDown_Click);
				if (this._btnAuditDown != null)
				{
					this._btnAuditDown.Click -= value2;
				}
				this._btnAuditDown = value;
				if (this._btnAuditDown != null)
				{
					this._btnAuditDown.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditUp_Click);
				if (this._btnAuditUp != null)
				{
					this._btnAuditUp.Click -= value2;
				}
				this._btnAuditUp = value;
				if (this._btnAuditUp != null)
				{
					this._btnAuditUp.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditUpdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditUpdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditUpdate_Click);
				if (this._btnAuditUpdate != null)
				{
					this._btnAuditUpdate.Click -= value2;
				}
				this._btnAuditUpdate = value;
				if (this._btnAuditUpdate != null)
				{
					this._btnAuditUpdate.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditDelete_Click);
				if (this._btnAuditDelete != null)
				{
					this._btnAuditDelete.Click -= value2;
				}
				this._btnAuditDelete = value;
				if (this._btnAuditDelete != null)
				{
					this._btnAuditDelete.Click += value2;
				}
			}
		}

		internal virtual Button btnAuditAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAuditAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAuditAdd_Click);
				if (this._btnAuditAdd != null)
				{
					this._btnAuditAdd.Click -= value2;
				}
				this._btnAuditAdd = value;
				if (this._btnAuditAdd != null)
				{
					this._btnAuditAdd.Click += value2;
				}
			}
		}

		internal virtual Label lblAuditDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAuditDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAuditDesc = value;
			}
		}

		internal virtual Label lblAuditFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAuditFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAuditFormula = value;
			}
		}

		internal virtual TextBox txtAuditDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAuditDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtAuditDesc = value;
			}
		}

		internal virtual TextBox txtAuditFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAuditFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.txtAuditFormula_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.txtAuditFormula_DragEnter);
				if (this._txtAuditFormula != null)
				{
					this._txtAuditFormula.DragDrop -= value2;
					this._txtAuditFormula.DragEnter -= value3;
				}
				this._txtAuditFormula = value;
				if (this._txtAuditFormula != null)
				{
					this._txtAuditFormula.DragDrop += value2;
					this._txtAuditFormula.DragEnter += value3;
				}
			}
		}

		internal virtual Button btnCalCompileAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalCompileAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalCompileAll_Click);
				if (this._btnCalCompileAll != null)
				{
					this._btnCalCompileAll.Click -= value2;
				}
				this._btnCalCompileAll = value;
				if (this._btnCalCompileAll != null)
				{
					this._btnCalCompileAll.Click += value2;
				}
			}
		}

		internal virtual Button btnCalCompile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalCompile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalCompile_Click);
				if (this._btnCalCompile != null)
				{
					this._btnCalCompile.Click -= value2;
				}
				this._btnCalCompile = value;
				if (this._btnCalCompile != null)
				{
					this._btnCalCompile.Click += value2;
				}
			}
		}

		internal virtual Button btnCalDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalDown_Click);
				if (this._btnCalDown != null)
				{
					this._btnCalDown.Click -= value2;
				}
				this._btnCalDown = value;
				if (this._btnCalDown != null)
				{
					this._btnCalDown.Click += value2;
				}
			}
		}

		internal virtual Button btnCalUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalUp_Click);
				if (this._btnCalUp != null)
				{
					this._btnCalUp.Click -= value2;
				}
				this._btnCalUp = value;
				if (this._btnCalUp != null)
				{
					this._btnCalUp.Click += value2;
				}
			}
		}

		internal virtual Button btnCalUpdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalUpdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalUpdate_Click);
				if (this._btnCalUpdate != null)
				{
					this._btnCalUpdate.Click -= value2;
				}
				this._btnCalUpdate = value;
				if (this._btnCalUpdate != null)
				{
					this._btnCalUpdate.Click += value2;
				}
			}
		}

		internal virtual Button btnCalDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalDelete_Click);
				if (this._btnCalDelete != null)
				{
					this._btnCalDelete.Click -= value2;
				}
				this._btnCalDelete = value;
				if (this._btnCalDelete != null)
				{
					this._btnCalDelete.Click += value2;
				}
			}
		}

		internal virtual Button btnCalAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCalAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCalAdd_Click);
				if (this._btnCalAdd != null)
				{
					this._btnCalAdd.Click -= value2;
				}
				this._btnCalAdd = value;
				if (this._btnCalAdd != null)
				{
					this._btnCalAdd.Click += value2;
				}
			}
		}

		internal virtual Label lblCalDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCalDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCalDesc = value;
			}
		}

		internal virtual Label lblCalFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCalFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCalFormula = value;
			}
		}

		internal virtual TextBox txtCalDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCalDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCalDesc = value;
			}
		}

		internal virtual TextBox txtCalFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCalFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.txtCalFormula_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.txtCalFormula_DragEnter);
				if (this._txtCalFormula != null)
				{
					this._txtCalFormula.DragDrop -= value2;
					this._txtCalFormula.DragEnter -= value3;
				}
				this._txtCalFormula = value;
				if (this._txtCalFormula != null)
				{
					this._txtCalFormula.DragDrop += value2;
					this._txtCalFormula.DragEnter += value3;
				}
			}
		}

		internal virtual DataGrid CalGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CalGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CalGrid_CurrentCellChanged);
				PaintEventHandler value3 = new PaintEventHandler(this.CalGrid_Paint);
				if (this._CalGrid != null)
				{
					this._CalGrid.CurrentCellChanged -= value2;
					this._CalGrid.Paint -= value3;
				}
				this._CalGrid = value;
				if (this._CalGrid != null)
				{
					this._CalGrid.CurrentCellChanged += value2;
					this._CalGrid.Paint += value3;
				}
			}
		}

		internal virtual DataGrid AuditGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AuditGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AuditGrid_CurrentCellChanged);
				PaintEventHandler value3 = new PaintEventHandler(this.AuditGrid_Paint);
				if (this._AuditGrid != null)
				{
					this._AuditGrid.CurrentCellChanged -= value2;
					this._AuditGrid.Paint -= value3;
				}
				this._AuditGrid = value;
				if (this._AuditGrid != null)
				{
					this._AuditGrid.CurrentCellChanged += value2;
					this._AuditGrid.Paint += value3;
				}
			}
		}

		internal virtual DataGridTableStyle AuditGridTableStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AuditGridTableStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AuditGridTableStyle = value;
			}
		}

		internal virtual DataGridTextBoxColumn colAuditFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colAuditFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colAuditFormula = value;
			}
		}

		internal virtual DataGridTextBoxColumn colAuditDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colAuditDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colAuditDesc = value;
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
				EventHandler value2 = new EventHandler(this.btnRemove_Click);
				if (this._btnRemove != null)
				{
					this._btnRemove.Click -= value2;
				}
				this._btnRemove = value;
				if (this._btnRemove != null)
				{
					this._btnRemove.Click += value2;
				}
			}
		}

		internal virtual TabPageAdv TipTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TipTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TipTab = value;
			}
		}

		internal virtual Button btnTipCompileAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipCompileAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipCompileAll_Click);
				if (this._btnTipCompileAll != null)
				{
					this._btnTipCompileAll.Click -= value2;
				}
				this._btnTipCompileAll = value;
				if (this._btnTipCompileAll != null)
				{
					this._btnTipCompileAll.Click += value2;
				}
			}
		}

		internal virtual Button btnTipCompile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipCompile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipCompile_Click);
				if (this._btnTipCompile != null)
				{
					this._btnTipCompile.Click -= value2;
				}
				this._btnTipCompile = value;
				if (this._btnTipCompile != null)
				{
					this._btnTipCompile.Click += value2;
				}
			}
		}

		internal virtual Button btnTipDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipDown_Click);
				if (this._btnTipDown != null)
				{
					this._btnTipDown.Click -= value2;
				}
				this._btnTipDown = value;
				if (this._btnTipDown != null)
				{
					this._btnTipDown.Click += value2;
				}
			}
		}

		internal virtual Button btnTipUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipUp_Click);
				if (this._btnTipUp != null)
				{
					this._btnTipUp.Click -= value2;
				}
				this._btnTipUp = value;
				if (this._btnTipUp != null)
				{
					this._btnTipUp.Click += value2;
				}
			}
		}

		internal virtual Button btnTipUpdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipUpdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipUpdate_Click);
				if (this._btnTipUpdate != null)
				{
					this._btnTipUpdate.Click -= value2;
				}
				this._btnTipUpdate = value;
				if (this._btnTipUpdate != null)
				{
					this._btnTipUpdate.Click += value2;
				}
			}
		}

		internal virtual Button btnTipDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipDelete_Click);
				if (this._btnTipDelete != null)
				{
					this._btnTipDelete.Click -= value2;
				}
				this._btnTipDelete = value;
				if (this._btnTipDelete != null)
				{
					this._btnTipDelete.Click += value2;
				}
			}
		}

		internal virtual Button btnTipAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTipAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTipAdd_Click);
				if (this._btnTipAdd != null)
				{
					this._btnTipAdd.Click -= value2;
				}
				this._btnTipAdd = value;
				if (this._btnTipAdd != null)
				{
					this._btnTipAdd.Click += value2;
				}
			}
		}

		internal virtual Label lblTipDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTipDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTipDesc = value;
			}
		}

		internal virtual Label lblTipFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTipFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTipFormula = value;
			}
		}

		internal virtual TextBox txtTipDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTipDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTipDesc = value;
			}
		}

		internal virtual TextBox txtTipFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTipFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.txtTipFormula_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.txtTipFormula_DragEnter);
				if (this._txtTipFormula != null)
				{
					this._txtTipFormula.DragDrop -= value2;
					this._txtTipFormula.DragEnter -= value3;
				}
				this._txtTipFormula = value;
				if (this._txtTipFormula != null)
				{
					this._txtTipFormula.DragDrop += value2;
					this._txtTipFormula.DragEnter += value3;
				}
			}
		}

		internal virtual DataGrid DataGrid2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGrid2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGrid2 = value;
			}
		}

		internal virtual DataGrid DataGrid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGrid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGrid1 = value;
			}
		}

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button2 = value;
			}
		}

		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button3 = value;
			}
		}

		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button4 = value;
			}
		}

		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button5 = value;
			}
		}

		internal virtual Button Button6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button6 = value;
			}
		}

		internal virtual Button Button7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button7 = value;
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

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		internal virtual TabPageAdv TabPageAdv1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageAdv1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageAdv1 = value;
			}
		}

		internal virtual Button Button8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button8 = value;
			}
		}

		internal virtual Button Button9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button9 = value;
			}
		}

		internal virtual Button Button10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button10 = value;
			}
		}

		internal virtual Button Button11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button11 = value;
			}
		}

		internal virtual Button Button12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button12 = value;
			}
		}

		internal virtual Button Button13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button13 = value;
			}
		}

		internal virtual Button Button14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button14 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		internal virtual TextBox TextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox4 = value;
			}
		}

		internal virtual TabPageAdv TabPageAdv2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageAdv2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageAdv2 = value;
			}
		}

		internal virtual DataGrid DataGrid3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGrid3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGrid3 = value;
			}
		}

		internal virtual Button Button15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button15 = value;
			}
		}

		internal virtual Button Button16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button16 = value;
			}
		}

		internal virtual Button Button17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button17 = value;
			}
		}

		internal virtual Button Button18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button18 = value;
			}
		}

		internal virtual Button Button19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button19 = value;
			}
		}

		internal virtual Button Button20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button20 = value;
			}
		}

		internal virtual Button Button21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button21 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual TextBox TextBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox5 = value;
			}
		}

		internal virtual TextBox TextBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox6 = value;
			}
		}

		internal virtual DataGrid TipGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TipGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TipGrid_CurrentCellChanged);
				PaintEventHandler value3 = new PaintEventHandler(this.TipGrid_Paint);
				if (this._TipGrid != null)
				{
					this._TipGrid.CurrentCellChanged -= value2;
					this._TipGrid.Paint -= value3;
				}
				this._TipGrid = value;
				if (this._TipGrid != null)
				{
					this._TipGrid.CurrentCellChanged += value2;
					this._TipGrid.Paint += value3;
				}
			}
		}

		internal virtual DataGridTableStyle TipGridTableStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TipGridTableStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TipGridTableStyle = value;
			}
		}

		internal virtual DataGridTableStyle CalGridTableStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CalGridTableStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CalGridTableStyle = value;
			}
		}

		internal virtual DataGridTextBoxColumn colCalFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colCalFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colCalFormula = value;
			}
		}

		internal virtual DataGridTextBoxColumn colCalDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colCalDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colCalDesc = value;
			}
		}

		internal virtual DataGridTextBoxColumn colTipFormula
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colTipFormula;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colTipFormula = value;
			}
		}

		internal virtual DataGridTextBoxColumn colTipDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colTipDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colTipDesc = value;
			}
		}

		internal virtual TabPageAdv TabPageAdv3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageAdv3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageAdv3 = value;
			}
		}

		public MMetaData MetaData
		{
			get
			{
				return this._MetaData;
			}
			set
			{
				this._MetaData = value;
				this.txtBindKBName.Text = this._MetaData.BindKBName;
				this.cbxBindKB.Checked = this._MetaData.BindKB;
				this.txtBindKBName.Enabled = this.cbxBindKB.Checked;
				this.btnKB.Enabled = this.cbxBindKB.Checked;
				this.CalFormulaItems = this._MetaData.CalculateFormulaItems;
				this.AuditFormulaItems = this._MetaData.AuditFormulaItems;
				this.TipFormulaItems = this._MetaData.TipFormulaItems;
				this.CalFormulaItems.NInstanceData = (NInstanceData)this.MetaData.BindInstanceItem;
				this.AuditFormulaItems.NInstanceData = (NInstanceData)this.MetaData.BindInstanceItem;
				this.TipFormulaItems.NInstanceData = (NInstanceData)this.MetaData.BindInstanceItem;
				this.txtAuditDesc.Text = "";
				this.txtAuditFormula.Text = "";
				this.txtCalDesc.Text = "";
				this.txtCalFormula.Text = "";
				this.txtTipDesc.Text = "";
				this.txtTipFormula.Text = "";
				this.AuditBind();
				this.CalBind();
				this.TipBind();
			}
		}

		public MMetaDataProperty()
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
			this.txtBindKBName = new TextBox();
			this.btnKB = new Button();
			this.cbxBindKB = new CheckBox();
			this.FormulaTabs = new TabControlAdv();
			this.AuditTab = new TabPageAdv();
			this.AuditGrid = new DataGrid();
			this.AuditGridTableStyle = new DataGridTableStyle();
			this.colAuditFormula = new DataGridTextBoxColumn();
			this.colAuditDesc = new DataGridTextBoxColumn();
			this.btnAuditCompileAll = new Button();
			this.btnAuditCompile = new Button();
			this.btnAuditDown = new Button();
			this.btnAuditUp = new Button();
			this.btnAuditUpdate = new Button();
			this.btnAuditDelete = new Button();
			this.btnAuditAdd = new Button();
			this.lblAuditDesc = new Label();
			this.lblAuditFormula = new Label();
			this.txtAuditDesc = new TextBox();
			this.txtAuditFormula = new TextBox();
			this.CalculateTab = new TabPageAdv();
			this.CalGrid = new DataGrid();
			this.CalGridTableStyle = new DataGridTableStyle();
			this.colCalFormula = new DataGridTextBoxColumn();
			this.colCalDesc = new DataGridTextBoxColumn();
			this.btnCalCompileAll = new Button();
			this.btnCalCompile = new Button();
			this.btnCalDown = new Button();
			this.btnCalUp = new Button();
			this.btnCalUpdate = new Button();
			this.btnCalDelete = new Button();
			this.btnCalAdd = new Button();
			this.lblCalDesc = new Label();
			this.lblCalFormula = new Label();
			this.txtCalDesc = new TextBox();
			this.txtCalFormula = new TextBox();
			this.TipTab = new TabPageAdv();
			this.TipGrid = new DataGrid();
			this.TipGridTableStyle = new DataGridTableStyle();
			this.colTipFormula = new DataGridTextBoxColumn();
			this.colTipDesc = new DataGridTextBoxColumn();
			this.btnTipCompileAll = new Button();
			this.btnTipCompile = new Button();
			this.btnTipDown = new Button();
			this.btnTipUp = new Button();
			this.btnTipUpdate = new Button();
			this.btnTipDelete = new Button();
			this.btnTipAdd = new Button();
			this.lblTipDesc = new Label();
			this.txtTipDesc = new TextBox();
			this.txtTipFormula = new TextBox();
			this.lblTipFormula = new Label();
			this.DataGrid2 = new DataGrid();
			this.DataGrid3 = new DataGrid();
			this.btnRemove = new Button();
			this.DataGrid1 = new DataGrid();
			this.Button1 = new Button();
			this.Button2 = new Button();
			this.Button3 = new Button();
			this.Button4 = new Button();
			this.Button5 = new Button();
			this.Button6 = new Button();
			this.Button7 = new Button();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.TextBox1 = new TextBox();
			this.TextBox2 = new TextBox();
			this.TabPageAdv1 = new TabPageAdv();
			this.Button8 = new Button();
			this.Button9 = new Button();
			this.Button10 = new Button();
			this.Button11 = new Button();
			this.Button12 = new Button();
			this.Button13 = new Button();
			this.Button14 = new Button();
			this.Label3 = new Label();
			this.Label4 = new Label();
			this.TextBox3 = new TextBox();
			this.TextBox4 = new TextBox();
			this.TabPageAdv2 = new TabPageAdv();
			this.Button15 = new Button();
			this.Button16 = new Button();
			this.Button17 = new Button();
			this.Button18 = new Button();
			this.Button19 = new Button();
			this.Button20 = new Button();
			this.Button21 = new Button();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.TextBox5 = new TextBox();
			this.TextBox6 = new TextBox();
			this.TabPageAdv3 = new TabPageAdv();
			this.FormulaTabs.BeginInit();
			this.FormulaTabs.SuspendLayout();
			this.AuditTab.SuspendLayout();
			((ISupportInitialize)this.AuditGrid).BeginInit();
			this.CalculateTab.SuspendLayout();
			((ISupportInitialize)this.CalGrid).BeginInit();
			this.TipTab.SuspendLayout();
			((ISupportInitialize)this.TipGrid).BeginInit();
			((ISupportInitialize)this.DataGrid2).BeginInit();
			((ISupportInitialize)this.DataGrid3).BeginInit();
			((ISupportInitialize)this.DataGrid1).BeginInit();
			this.TabPageAdv1.SuspendLayout();
			this.TabPageAdv2.SuspendLayout();
			this.SuspendLayout();
			Control arg_49B_0 = this.txtBindKBName;
			Point location = new Point(126, 14);
			arg_49B_0.Location = location;
			this.txtBindKBName.Name = "txtBindKBName";
			Control arg_4C5_0 = this.txtBindKBName;
			Size size = new Size(200, 21);
			arg_4C5_0.Size = size;
			this.txtBindKBName.TabIndex = 1;
			Control arg_4EB_0 = this.btnKB;
			location = new Point(332, 13);
			arg_4EB_0.Location = location;
			this.btnKB.Name = "btnKB";
			Control arg_512_0 = this.btnKB;
			size = new Size(50, 23);
			arg_512_0.Size = size;
			this.btnKB.TabIndex = 2;
			this.btnKB.Text = "+";
			Control arg_544_0 = this.cbxBindKB;
			location = new Point(6, 14);
			arg_544_0.Location = location;
			this.cbxBindKB.Name = "cbxBindKB";
			Control arg_56B_0 = this.cbxBindKB;
			size = new Size(112, 24);
			arg_56B_0.Size = size;
			this.cbxBindKB.TabIndex = 3;
			this.cbxBindKB.Text = "是否绑定知识库";
			this.FormulaTabs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.FormulaTabs.set_BorderStyle(BorderStyle.None);
			this.FormulaTabs.Controls.Add(this.AuditTab);
			this.FormulaTabs.Controls.Add(this.CalculateTab);
			this.FormulaTabs.Controls.Add(this.TipTab);
			Control arg_5F8_0 = this.FormulaTabs;
			location = new Point(6, 44);
			arg_5F8_0.Location = location;
			this.FormulaTabs.Name = "FormulaTabs";
			Control arg_625_0 = this.FormulaTabs;
			size = new Size(488, 352);
			arg_625_0.Size = size;
			this.FormulaTabs.TabIndex = 4;
			this.AuditTab.Controls.Add(this.AuditGrid);
			this.AuditTab.Controls.Add(this.btnAuditCompileAll);
			this.AuditTab.Controls.Add(this.btnAuditCompile);
			this.AuditTab.Controls.Add(this.btnAuditDown);
			this.AuditTab.Controls.Add(this.btnAuditUp);
			this.AuditTab.Controls.Add(this.btnAuditUpdate);
			this.AuditTab.Controls.Add(this.btnAuditDelete);
			this.AuditTab.Controls.Add(this.btnAuditAdd);
			this.AuditTab.Controls.Add(this.lblAuditDesc);
			this.AuditTab.Controls.Add(this.lblAuditFormula);
			this.AuditTab.Controls.Add(this.txtAuditDesc);
			this.AuditTab.Controls.Add(this.txtAuditFormula);
			Control arg_74F_0 = this.AuditTab;
			location = new Point(0, 23);
			arg_74F_0.Location = location;
			this.AuditTab.Name = "AuditTab";
			Control arg_77C_0 = this.AuditTab;
			size = new Size(488, 329);
			arg_77C_0.Size = size;
			this.AuditTab.set_TabIndex(1);
			this.AuditTab.set_Text("审核公式");
			this.AuditTab.set_ThemesEnabled(false);
			this.AuditGrid.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.AuditGrid.CaptionVisible = false;
			this.AuditGrid.DataMember = "";
			this.AuditGrid.HeaderForeColor = SystemColors.ControlText;
			Control arg_7F2_0 = this.AuditGrid;
			location = new Point(5, 101);
			arg_7F2_0.Location = location;
			this.AuditGrid.Name = "AuditGrid";
			Control arg_81F_0 = this.AuditGrid;
			size = new Size(476, 226);
			arg_81F_0.Size = size;
			this.AuditGrid.TabIndex = 15;
			this.AuditGrid.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.AuditGridTableStyle
			});
			this.AuditGridTableStyle.DataGrid = this.DataGrid2;
			this.AuditGridTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.colAuditFormula,
				this.colAuditDesc
			});
			this.AuditGridTableStyle.HeaderForeColor = SystemColors.ControlText;
			this.colAuditFormula.Format = "";
			this.colAuditFormula.FormatInfo = null;
			this.colAuditFormula.HeaderText = "公式";
			this.colAuditFormula.MappingName = "StrFormula";
			this.colAuditFormula.NullText = "";
			this.colAuditFormula.Width = 200;
			this.colAuditDesc.Format = "";
			this.colAuditDesc.FormatInfo = null;
			this.colAuditDesc.HeaderText = "说明";
			this.colAuditDesc.MappingName = "Description";
			this.colAuditDesc.NullText = "";
			this.colAuditDesc.Width = 200;
			Control arg_96A_0 = this.btnAuditCompileAll;
			location = new Point(416, 72);
			arg_96A_0.Location = location;
			this.btnAuditCompileAll.Name = "btnAuditCompileAll";
			Control arg_991_0 = this.btnAuditCompileAll;
			size = new Size(60, 23);
			arg_991_0.Size = size;
			this.btnAuditCompileAll.TabIndex = 14;
			this.btnAuditCompileAll.Text = "全编";
			Control arg_9C8_0 = this.btnAuditCompile;
			location = new Point(348, 72);
			arg_9C8_0.Location = location;
			this.btnAuditCompile.Name = "btnAuditCompile";
			Control arg_9EF_0 = this.btnAuditCompile;
			size = new Size(60, 23);
			arg_9EF_0.Size = size;
			this.btnAuditCompile.TabIndex = 13;
			this.btnAuditCompile.Text = "编译";
			Control arg_A26_0 = this.btnAuditDown;
			location = new Point(280, 72);
			arg_A26_0.Location = location;
			this.btnAuditDown.Name = "btnAuditDown";
			Control arg_A4D_0 = this.btnAuditDown;
			size = new Size(60, 23);
			arg_A4D_0.Size = size;
			this.btnAuditDown.TabIndex = 12;
			this.btnAuditDown.Text = "下移";
			Control arg_A84_0 = this.btnAuditUp;
			location = new Point(212, 72);
			arg_A84_0.Location = location;
			this.btnAuditUp.Name = "btnAuditUp";
			Control arg_AAB_0 = this.btnAuditUp;
			size = new Size(60, 23);
			arg_AAB_0.Size = size;
			this.btnAuditUp.TabIndex = 11;
			this.btnAuditUp.Text = "上移";
			Control arg_ADF_0 = this.btnAuditUpdate;
			location = new Point(76, 72);
			arg_ADF_0.Location = location;
			this.btnAuditUpdate.Name = "btnAuditUpdate";
			Control arg_B06_0 = this.btnAuditUpdate;
			size = new Size(60, 23);
			arg_B06_0.Size = size;
			this.btnAuditUpdate.TabIndex = 10;
			this.btnAuditUpdate.Text = "更新";
			Control arg_B3D_0 = this.btnAuditDelete;
			location = new Point(144, 72);
			arg_B3D_0.Location = location;
			this.btnAuditDelete.Name = "btnAuditDelete";
			Control arg_B64_0 = this.btnAuditDelete;
			size = new Size(60, 23);
			arg_B64_0.Size = size;
			this.btnAuditDelete.TabIndex = 9;
			this.btnAuditDelete.Text = "删除";
			Control arg_B97_0 = this.btnAuditAdd;
			location = new Point(8, 72);
			arg_B97_0.Location = location;
			this.btnAuditAdd.Name = "btnAuditAdd";
			Control arg_BBE_0 = this.btnAuditAdd;
			size = new Size(60, 23);
			arg_BBE_0.Size = size;
			this.btnAuditAdd.TabIndex = 8;
			this.btnAuditAdd.Text = "添加";
			Control arg_BF1_0 = this.lblAuditDesc;
			location = new Point(14, 42);
			arg_BF1_0.Location = location;
			this.lblAuditDesc.Name = "lblAuditDesc";
			Control arg_C18_0 = this.lblAuditDesc;
			size = new Size(52, 23);
			arg_C18_0.Size = size;
			this.lblAuditDesc.TabIndex = 7;
			this.lblAuditDesc.Text = "说明：";
			this.lblAuditDesc.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_C58_0 = this.lblAuditFormula;
			location = new Point(14, 15);
			arg_C58_0.Location = location;
			this.lblAuditFormula.Name = "lblAuditFormula";
			Control arg_C7F_0 = this.lblAuditFormula;
			size = new Size(52, 23);
			arg_C7F_0.Size = size;
			this.lblAuditFormula.TabIndex = 6;
			this.lblAuditFormula.Text = "公式：";
			this.lblAuditFormula.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_CBF_0 = this.txtAuditDesc;
			location = new Point(72, 40);
			arg_CBF_0.Location = location;
			this.txtAuditDesc.Name = "txtAuditDesc";
			Control arg_CE9_0 = this.txtAuditDesc;
			size = new Size(404, 21);
			arg_CE9_0.Size = size;
			this.txtAuditDesc.TabIndex = 5;
			this.txtAuditFormula.AllowDrop = true;
			Control arg_D18_0 = this.txtAuditFormula;
			location = new Point(72, 13);
			arg_D18_0.Location = location;
			this.txtAuditFormula.Name = "txtAuditFormula";
			Control arg_D42_0 = this.txtAuditFormula;
			size = new Size(404, 21);
			arg_D42_0.Size = size;
			this.txtAuditFormula.TabIndex = 4;
			this.CalculateTab.Controls.Add(this.CalGrid);
			this.CalculateTab.Controls.Add(this.btnCalCompileAll);
			this.CalculateTab.Controls.Add(this.btnCalCompile);
			this.CalculateTab.Controls.Add(this.btnCalDown);
			this.CalculateTab.Controls.Add(this.btnCalUp);
			this.CalculateTab.Controls.Add(this.btnCalUpdate);
			this.CalculateTab.Controls.Add(this.btnCalDelete);
			this.CalculateTab.Controls.Add(this.btnCalAdd);
			this.CalculateTab.Controls.Add(this.lblCalDesc);
			this.CalculateTab.Controls.Add(this.lblCalFormula);
			this.CalculateTab.Controls.Add(this.txtCalDesc);
			this.CalculateTab.Controls.Add(this.txtCalFormula);
			Control arg_E6C_0 = this.CalculateTab;
			location = new Point(0, 23);
			arg_E6C_0.Location = location;
			this.CalculateTab.Name = "CalculateTab";
			Control arg_E99_0 = this.CalculateTab;
			size = new Size(488, 329);
			arg_E99_0.Size = size;
			this.CalculateTab.set_TabIndex(1);
			this.CalculateTab.set_Text("计算公式");
			this.CalculateTab.set_ThemesEnabled(false);
			this.CalGrid.AllowSorting = false;
			this.CalGrid.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.CalGrid.CaptionVisible = false;
			this.CalGrid.DataMember = "";
			this.CalGrid.HeaderForeColor = SystemColors.ControlText;
			Control arg_F1B_0 = this.CalGrid;
			location = new Point(5, 101);
			arg_F1B_0.Location = location;
			this.CalGrid.Name = "CalGrid";
			this.CalGrid.PreferredRowHeight = 20;
			Control arg_F55_0 = this.CalGrid;
			size = new Size(476, 222);
			arg_F55_0.Size = size;
			this.CalGrid.TabIndex = 22;
			this.CalGrid.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.CalGridTableStyle
			});
			this.CalGridTableStyle.DataGrid = this.CalGrid;
			this.CalGridTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.colCalFormula,
				this.colCalDesc
			});
			this.CalGridTableStyle.HeaderForeColor = SystemColors.ControlText;
			this.colCalFormula.Format = "";
			this.colCalFormula.FormatInfo = null;
			this.colCalFormula.HeaderText = "公式";
			this.colCalFormula.MappingName = "StrFormula";
			this.colCalFormula.Width = 200;
			this.colCalDesc.Format = "";
			this.colCalDesc.FormatInfo = null;
			this.colCalDesc.HeaderText = "说明";
			this.colCalDesc.MappingName = "Description";
			this.colCalDesc.Width = 200;
			Control arg_1080_0 = this.btnCalCompileAll;
			location = new Point(416, 72);
			arg_1080_0.Location = location;
			this.btnCalCompileAll.Name = "btnCalCompileAll";
			Control arg_10A7_0 = this.btnCalCompileAll;
			size = new Size(60, 23);
			arg_10A7_0.Size = size;
			this.btnCalCompileAll.TabIndex = 21;
			this.btnCalCompileAll.Text = "全编";
			Control arg_10DE_0 = this.btnCalCompile;
			location = new Point(348, 72);
			arg_10DE_0.Location = location;
			this.btnCalCompile.Name = "btnCalCompile";
			Control arg_1105_0 = this.btnCalCompile;
			size = new Size(60, 23);
			arg_1105_0.Size = size;
			this.btnCalCompile.TabIndex = 20;
			this.btnCalCompile.Text = "编译";
			Control arg_113C_0 = this.btnCalDown;
			location = new Point(280, 72);
			arg_113C_0.Location = location;
			this.btnCalDown.Name = "btnCalDown";
			Control arg_1163_0 = this.btnCalDown;
			size = new Size(60, 23);
			arg_1163_0.Size = size;
			this.btnCalDown.TabIndex = 19;
			this.btnCalDown.Text = "下移";
			Control arg_119A_0 = this.btnCalUp;
			location = new Point(212, 72);
			arg_119A_0.Location = location;
			this.btnCalUp.Name = "btnCalUp";
			Control arg_11C1_0 = this.btnCalUp;
			size = new Size(60, 23);
			arg_11C1_0.Size = size;
			this.btnCalUp.TabIndex = 18;
			this.btnCalUp.Text = "上移";
			Control arg_11F5_0 = this.btnCalUpdate;
			location = new Point(76, 72);
			arg_11F5_0.Location = location;
			this.btnCalUpdate.Name = "btnCalUpdate";
			Control arg_121C_0 = this.btnCalUpdate;
			size = new Size(60, 23);
			arg_121C_0.Size = size;
			this.btnCalUpdate.TabIndex = 17;
			this.btnCalUpdate.Text = "更新";
			Control arg_1253_0 = this.btnCalDelete;
			location = new Point(144, 72);
			arg_1253_0.Location = location;
			this.btnCalDelete.Name = "btnCalDelete";
			Control arg_127A_0 = this.btnCalDelete;
			size = new Size(60, 23);
			arg_127A_0.Size = size;
			this.btnCalDelete.TabIndex = 16;
			this.btnCalDelete.Text = "删除";
			Control arg_12AD_0 = this.btnCalAdd;
			location = new Point(8, 72);
			arg_12AD_0.Location = location;
			this.btnCalAdd.Name = "btnCalAdd";
			Control arg_12D4_0 = this.btnCalAdd;
			size = new Size(60, 23);
			arg_12D4_0.Size = size;
			this.btnCalAdd.TabIndex = 15;
			this.btnCalAdd.Text = "添加";
			Control arg_1308_0 = this.lblCalDesc;
			location = new Point(14, 42);
			arg_1308_0.Location = location;
			this.lblCalDesc.Name = "lblCalDesc";
			Control arg_132F_0 = this.lblCalDesc;
			size = new Size(50, 23);
			arg_132F_0.Size = size;
			this.lblCalDesc.TabIndex = 3;
			this.lblCalDesc.Text = "说明：";
			this.lblCalDesc.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_136F_0 = this.lblCalFormula;
			location = new Point(14, 15);
			arg_136F_0.Location = location;
			this.lblCalFormula.Name = "lblCalFormula";
			Control arg_1396_0 = this.lblCalFormula;
			size = new Size(50, 23);
			arg_1396_0.Size = size;
			this.lblCalFormula.TabIndex = 2;
			this.lblCalFormula.Text = "公式：";
			this.lblCalFormula.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_13D6_0 = this.txtCalDesc;
			location = new Point(72, 40);
			arg_13D6_0.Location = location;
			this.txtCalDesc.Name = "txtCalDesc";
			Control arg_1400_0 = this.txtCalDesc;
			size = new Size(404, 21);
			arg_1400_0.Size = size;
			this.txtCalDesc.TabIndex = 1;
			this.txtCalFormula.AllowDrop = true;
			Control arg_142F_0 = this.txtCalFormula;
			location = new Point(72, 13);
			arg_142F_0.Location = location;
			this.txtCalFormula.Name = "txtCalFormula";
			Control arg_1459_0 = this.txtCalFormula;
			size = new Size(404, 21);
			arg_1459_0.Size = size;
			this.txtCalFormula.TabIndex = 0;
			this.TipTab.Controls.Add(this.TipGrid);
			this.TipTab.Controls.Add(this.btnTipCompileAll);
			this.TipTab.Controls.Add(this.btnTipCompile);
			this.TipTab.Controls.Add(this.btnTipDown);
			this.TipTab.Controls.Add(this.btnTipUp);
			this.TipTab.Controls.Add(this.btnTipUpdate);
			this.TipTab.Controls.Add(this.btnTipDelete);
			this.TipTab.Controls.Add(this.btnTipAdd);
			this.TipTab.Controls.Add(this.lblTipDesc);
			this.TipTab.Controls.Add(this.txtTipDesc);
			this.TipTab.Controls.Add(this.txtTipFormula);
			this.TipTab.Controls.Add(this.lblTipFormula);
			Control arg_1583_0 = this.TipTab;
			location = new Point(0, 23);
			arg_1583_0.Location = location;
			this.TipTab.Name = "TipTab";
			Control arg_15B0_0 = this.TipTab;
			size = new Size(488, 329);
			arg_15B0_0.Size = size;
			this.TipTab.set_TabIndex(2);
			this.TipTab.set_Text("提示公式");
			this.TipTab.set_ThemesEnabled(false);
			this.TipGrid.AllowSorting = false;
			this.TipGrid.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.TipGrid.CaptionVisible = false;
			this.TipGrid.DataMember = "";
			this.TipGrid.HeaderForeColor = SystemColors.ControlText;
			Control arg_1632_0 = this.TipGrid;
			location = new Point(5, 101);
			arg_1632_0.Location = location;
			this.TipGrid.Name = "TipGrid";
			this.TipGrid.PreferredRowHeight = 20;
			Control arg_166C_0 = this.TipGrid;
			size = new Size(476, 222);
			arg_166C_0.Size = size;
			this.TipGrid.TabIndex = 34;
			this.TipGrid.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.TipGridTableStyle
			});
			this.TipGridTableStyle.DataGrid = this.TipGrid;
			this.TipGridTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.colTipFormula,
				this.colTipDesc
			});
			this.TipGridTableStyle.HeaderForeColor = SystemColors.ControlText;
			this.colTipFormula.Format = "";
			this.colTipFormula.FormatInfo = null;
			this.colTipFormula.HeaderText = "公式";
			this.colTipFormula.MappingName = "StrFormula";
			this.colTipFormula.Width = 200;
			this.colTipDesc.Format = "";
			this.colTipDesc.FormatInfo = null;
			this.colTipDesc.HeaderText = "说明";
			this.colTipDesc.MappingName = "Description";
			this.colTipDesc.Width = 200;
			Control arg_1797_0 = this.btnTipCompileAll;
			location = new Point(416, 72);
			arg_1797_0.Location = location;
			this.btnTipCompileAll.Name = "btnTipCompileAll";
			Control arg_17BE_0 = this.btnTipCompileAll;
			size = new Size(60, 23);
			arg_17BE_0.Size = size;
			this.btnTipCompileAll.TabIndex = 33;
			this.btnTipCompileAll.Text = "全编";
			Control arg_17F5_0 = this.btnTipCompile;
			location = new Point(348, 72);
			arg_17F5_0.Location = location;
			this.btnTipCompile.Name = "btnTipCompile";
			Control arg_181C_0 = this.btnTipCompile;
			size = new Size(60, 23);
			arg_181C_0.Size = size;
			this.btnTipCompile.TabIndex = 32;
			this.btnTipCompile.Text = "编译";
			Control arg_1853_0 = this.btnTipDown;
			location = new Point(280, 72);
			arg_1853_0.Location = location;
			this.btnTipDown.Name = "btnTipDown";
			Control arg_187A_0 = this.btnTipDown;
			size = new Size(60, 23);
			arg_187A_0.Size = size;
			this.btnTipDown.TabIndex = 31;
			this.btnTipDown.Text = "下移";
			Control arg_18B1_0 = this.btnTipUp;
			location = new Point(212, 72);
			arg_18B1_0.Location = location;
			this.btnTipUp.Name = "btnTipUp";
			Control arg_18D8_0 = this.btnTipUp;
			size = new Size(60, 23);
			arg_18D8_0.Size = size;
			this.btnTipUp.TabIndex = 30;
			this.btnTipUp.Text = "上移";
			Control arg_190C_0 = this.btnTipUpdate;
			location = new Point(76, 72);
			arg_190C_0.Location = location;
			this.btnTipUpdate.Name = "btnTipUpdate";
			Control arg_1933_0 = this.btnTipUpdate;
			size = new Size(60, 23);
			arg_1933_0.Size = size;
			this.btnTipUpdate.TabIndex = 29;
			this.btnTipUpdate.Text = "更新";
			Control arg_196A_0 = this.btnTipDelete;
			location = new Point(144, 72);
			arg_196A_0.Location = location;
			this.btnTipDelete.Name = "btnTipDelete";
			Control arg_1991_0 = this.btnTipDelete;
			size = new Size(60, 23);
			arg_1991_0.Size = size;
			this.btnTipDelete.TabIndex = 28;
			this.btnTipDelete.Text = "删除";
			Control arg_19C4_0 = this.btnTipAdd;
			location = new Point(8, 72);
			arg_19C4_0.Location = location;
			this.btnTipAdd.Name = "btnTipAdd";
			Control arg_19EB_0 = this.btnTipAdd;
			size = new Size(60, 23);
			arg_19EB_0.Size = size;
			this.btnTipAdd.TabIndex = 27;
			this.btnTipAdd.Text = "添加";
			Control arg_1A1F_0 = this.lblTipDesc;
			location = new Point(14, 42);
			arg_1A1F_0.Location = location;
			this.lblTipDesc.Name = "lblTipDesc";
			Control arg_1A46_0 = this.lblTipDesc;
			size = new Size(50, 23);
			arg_1A46_0.Size = size;
			this.lblTipDesc.TabIndex = 26;
			this.lblTipDesc.Text = "说明：";
			this.lblTipDesc.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_1A87_0 = this.txtTipDesc;
			location = new Point(72, 40);
			arg_1A87_0.Location = location;
			this.txtTipDesc.Name = "txtTipDesc";
			Control arg_1AB1_0 = this.txtTipDesc;
			size = new Size(404, 21);
			arg_1AB1_0.Size = size;
			this.txtTipDesc.TabIndex = 24;
			this.txtTipFormula.AllowDrop = true;
			Control arg_1AE1_0 = this.txtTipFormula;
			location = new Point(72, 13);
			arg_1AE1_0.Location = location;
			this.txtTipFormula.Name = "txtTipFormula";
			Control arg_1B0B_0 = this.txtTipFormula;
			size = new Size(404, 21);
			arg_1B0B_0.Size = size;
			this.txtTipFormula.TabIndex = 23;
			Control arg_1B2F_0 = this.lblTipFormula;
			location = new Point(14, 15);
			arg_1B2F_0.Location = location;
			this.lblTipFormula.Name = "lblTipFormula";
			Control arg_1B56_0 = this.lblTipFormula;
			size = new Size(50, 23);
			arg_1B56_0.Size = size;
			this.lblTipFormula.TabIndex = 25;
			this.lblTipFormula.Text = "公式：";
			this.lblTipFormula.TextAlign = ContentAlignment.MiddleLeft;
			this.DataGrid2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.DataGrid2.CaptionVisible = false;
			this.DataGrid2.DataMember = "";
			this.DataGrid2.HeaderForeColor = SystemColors.ControlText;
			Control arg_1BCE_0 = this.DataGrid2;
			location = new Point(5, 101);
			arg_1BCE_0.Location = location;
			this.DataGrid2.Name = "DataGrid2";
			Control arg_1BFB_0 = this.DataGrid2;
			size = new Size(476, 226);
			arg_1BFB_0.Size = size;
			this.DataGrid2.TabIndex = 15;
			this.DataGrid2.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.AuditGridTableStyle
			});
			this.DataGrid3.AllowSorting = false;
			this.DataGrid3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.DataGrid3.CaptionVisible = false;
			this.DataGrid3.DataMember = "";
			this.DataGrid3.HeaderForeColor = SystemColors.ControlText;
			Control arg_1C83_0 = this.DataGrid3;
			location = new Point(5, 101);
			arg_1C83_0.Location = location;
			this.DataGrid3.Name = "DataGrid3";
			this.DataGrid3.PreferredRowHeight = 20;
			Control arg_1CBD_0 = this.DataGrid3;
			size = new Size(476, 222);
			arg_1CBD_0.Size = size;
			this.DataGrid3.TabIndex = 22;
			Control arg_1CE4_0 = this.btnRemove;
			location = new Point(388, 13);
			arg_1CE4_0.Location = location;
			this.btnRemove.Name = "btnRemove";
			Control arg_1D0B_0 = this.btnRemove;
			size = new Size(50, 23);
			arg_1D0B_0.Size = size;
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "-";
			this.DataGrid1.AllowSorting = false;
			this.DataGrid1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.DataGrid1.CaptionVisible = false;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.HeaderForeColor = SystemColors.ControlText;
			Control arg_1D81_0 = this.DataGrid1;
			location = new Point(5, 101);
			arg_1D81_0.Location = location;
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.PreferredRowHeight = 20;
			Control arg_1DBB_0 = this.DataGrid1;
			size = new Size(476, 222);
			arg_1DBB_0.Size = size;
			this.DataGrid1.TabIndex = 22;
			Control arg_1DE2_0 = this.Button1;
			location = new Point(416, 72);
			arg_1DE2_0.Location = location;
			this.Button1.Name = "Button1";
			Control arg_1E09_0 = this.Button1;
			size = new Size(60, 23);
			arg_1E09_0.Size = size;
			this.Button1.TabIndex = 21;
			this.Button1.Text = "全编";
			Control arg_1E40_0 = this.Button2;
			location = new Point(348, 72);
			arg_1E40_0.Location = location;
			this.Button2.Name = "Button2";
			Control arg_1E67_0 = this.Button2;
			size = new Size(60, 23);
			arg_1E67_0.Size = size;
			this.Button2.TabIndex = 20;
			this.Button2.Text = "编译";
			Control arg_1E9E_0 = this.Button3;
			location = new Point(280, 72);
			arg_1E9E_0.Location = location;
			this.Button3.Name = "Button3";
			Control arg_1EC5_0 = this.Button3;
			size = new Size(60, 23);
			arg_1EC5_0.Size = size;
			this.Button3.TabIndex = 19;
			this.Button3.Text = "下移";
			Control arg_1EFC_0 = this.Button4;
			location = new Point(212, 72);
			arg_1EFC_0.Location = location;
			this.Button4.Name = "Button4";
			Control arg_1F23_0 = this.Button4;
			size = new Size(60, 23);
			arg_1F23_0.Size = size;
			this.Button4.TabIndex = 18;
			this.Button4.Text = "上移";
			Control arg_1F57_0 = this.Button5;
			location = new Point(76, 72);
			arg_1F57_0.Location = location;
			this.Button5.Name = "Button5";
			Control arg_1F7E_0 = this.Button5;
			size = new Size(60, 23);
			arg_1F7E_0.Size = size;
			this.Button5.TabIndex = 17;
			this.Button5.Text = "更新";
			Control arg_1FB5_0 = this.Button6;
			location = new Point(144, 72);
			arg_1FB5_0.Location = location;
			this.Button6.Name = "Button6";
			Control arg_1FDC_0 = this.Button6;
			size = new Size(60, 23);
			arg_1FDC_0.Size = size;
			this.Button6.TabIndex = 16;
			this.Button6.Text = "删除";
			Control arg_200F_0 = this.Button7;
			location = new Point(8, 72);
			arg_200F_0.Location = location;
			this.Button7.Name = "Button7";
			Control arg_2036_0 = this.Button7;
			size = new Size(60, 23);
			arg_2036_0.Size = size;
			this.Button7.TabIndex = 15;
			this.Button7.Text = "添加";
			Control arg_206A_0 = this.Label1;
			location = new Point(14, 42);
			arg_206A_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_2091_0 = this.Label1;
			size = new Size(50, 23);
			arg_2091_0.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "说明：";
			this.Label1.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_20D1_0 = this.Label2;
			location = new Point(14, 15);
			arg_20D1_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_20F8_0 = this.Label2;
			size = new Size(50, 23);
			arg_20F8_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "公式：";
			this.Label2.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_2138_0 = this.TextBox1;
			location = new Point(72, 40);
			arg_2138_0.Location = location;
			this.TextBox1.Name = "TextBox1";
			Control arg_2162_0 = this.TextBox1;
			size = new Size(404, 21);
			arg_2162_0.Size = size;
			this.TextBox1.TabIndex = 1;
			this.TextBox2.AllowDrop = true;
			Control arg_2191_0 = this.TextBox2;
			location = new Point(72, 13);
			arg_2191_0.Location = location;
			this.TextBox2.Name = "TextBox2";
			Control arg_21BB_0 = this.TextBox2;
			size = new Size(404, 21);
			arg_21BB_0.Size = size;
			this.TextBox2.TabIndex = 0;
			this.TabPageAdv1.Controls.Add(this.DataGrid2);
			this.TabPageAdv1.Controls.Add(this.Button8);
			this.TabPageAdv1.Controls.Add(this.Button9);
			this.TabPageAdv1.Controls.Add(this.Button10);
			this.TabPageAdv1.Controls.Add(this.Button11);
			this.TabPageAdv1.Controls.Add(this.Button12);
			this.TabPageAdv1.Controls.Add(this.Button13);
			this.TabPageAdv1.Controls.Add(this.Button14);
			this.TabPageAdv1.Controls.Add(this.Label3);
			this.TabPageAdv1.Controls.Add(this.Label4);
			this.TabPageAdv1.Controls.Add(this.TextBox3);
			this.TabPageAdv1.Controls.Add(this.TextBox4);
			Control arg_22E5_0 = this.TabPageAdv1;
			location = new Point(0, 23);
			arg_22E5_0.Location = location;
			this.TabPageAdv1.Name = "TabPageAdv1";
			Control arg_2312_0 = this.TabPageAdv1;
			size = new Size(488, 329);
			arg_2312_0.Size = size;
			this.TabPageAdv1.set_TabFont(null);
			this.TabPageAdv1.set_TabIndex(1);
			this.TabPageAdv1.set_Text("审核公式");
			this.TabPageAdv1.set_ThemesEnabled(false);
			Control arg_2360_0 = this.Button8;
			location = new Point(416, 72);
			arg_2360_0.Location = location;
			this.Button8.Name = "Button8";
			Control arg_2387_0 = this.Button8;
			size = new Size(60, 23);
			arg_2387_0.Size = size;
			this.Button8.TabIndex = 14;
			this.Button8.Text = "全编";
			Control arg_23BE_0 = this.Button9;
			location = new Point(348, 72);
			arg_23BE_0.Location = location;
			this.Button9.Name = "Button9";
			Control arg_23E5_0 = this.Button9;
			size = new Size(60, 23);
			arg_23E5_0.Size = size;
			this.Button9.TabIndex = 13;
			this.Button9.Text = "编译";
			Control arg_241C_0 = this.Button10;
			location = new Point(280, 72);
			arg_241C_0.Location = location;
			this.Button10.Name = "Button10";
			Control arg_2443_0 = this.Button10;
			size = new Size(60, 23);
			arg_2443_0.Size = size;
			this.Button10.TabIndex = 12;
			this.Button10.Text = "下移";
			Control arg_247A_0 = this.Button11;
			location = new Point(212, 72);
			arg_247A_0.Location = location;
			this.Button11.Name = "Button11";
			Control arg_24A1_0 = this.Button11;
			size = new Size(60, 23);
			arg_24A1_0.Size = size;
			this.Button11.TabIndex = 11;
			this.Button11.Text = "上移";
			Control arg_24D5_0 = this.Button12;
			location = new Point(76, 72);
			arg_24D5_0.Location = location;
			this.Button12.Name = "Button12";
			Control arg_24FC_0 = this.Button12;
			size = new Size(60, 23);
			arg_24FC_0.Size = size;
			this.Button12.TabIndex = 10;
			this.Button12.Text = "更新";
			Control arg_2533_0 = this.Button13;
			location = new Point(144, 72);
			arg_2533_0.Location = location;
			this.Button13.Name = "Button13";
			Control arg_255A_0 = this.Button13;
			size = new Size(60, 23);
			arg_255A_0.Size = size;
			this.Button13.TabIndex = 9;
			this.Button13.Text = "删除";
			Control arg_258D_0 = this.Button14;
			location = new Point(8, 72);
			arg_258D_0.Location = location;
			this.Button14.Name = "Button14";
			Control arg_25B4_0 = this.Button14;
			size = new Size(60, 23);
			arg_25B4_0.Size = size;
			this.Button14.TabIndex = 8;
			this.Button14.Text = "添加";
			Control arg_25E7_0 = this.Label3;
			location = new Point(14, 42);
			arg_25E7_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_260E_0 = this.Label3;
			size = new Size(52, 23);
			arg_260E_0.Size = size;
			this.Label3.TabIndex = 7;
			this.Label3.Text = "说明：";
			this.Label3.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_264E_0 = this.Label4;
			location = new Point(14, 15);
			arg_264E_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_2675_0 = this.Label4;
			size = new Size(52, 23);
			arg_2675_0.Size = size;
			this.Label4.TabIndex = 6;
			this.Label4.Text = "公式：";
			this.Label4.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_26B5_0 = this.TextBox3;
			location = new Point(72, 40);
			arg_26B5_0.Location = location;
			this.TextBox3.Name = "TextBox3";
			Control arg_26DF_0 = this.TextBox3;
			size = new Size(404, 21);
			arg_26DF_0.Size = size;
			this.TextBox3.TabIndex = 5;
			this.TextBox4.AllowDrop = true;
			Control arg_270E_0 = this.TextBox4;
			location = new Point(72, 13);
			arg_270E_0.Location = location;
			this.TextBox4.Name = "TextBox4";
			Control arg_2738_0 = this.TextBox4;
			size = new Size(404, 21);
			arg_2738_0.Size = size;
			this.TextBox4.TabIndex = 4;
			this.TabPageAdv2.Controls.Add(this.DataGrid3);
			this.TabPageAdv2.Controls.Add(this.Button15);
			this.TabPageAdv2.Controls.Add(this.Button16);
			this.TabPageAdv2.Controls.Add(this.Button17);
			this.TabPageAdv2.Controls.Add(this.Button18);
			this.TabPageAdv2.Controls.Add(this.Button19);
			this.TabPageAdv2.Controls.Add(this.Button20);
			this.TabPageAdv2.Controls.Add(this.Button21);
			this.TabPageAdv2.Controls.Add(this.Label5);
			this.TabPageAdv2.Controls.Add(this.Label6);
			this.TabPageAdv2.Controls.Add(this.TextBox5);
			this.TabPageAdv2.Controls.Add(this.TextBox6);
			Control arg_2862_0 = this.TabPageAdv2;
			location = new Point(0, 23);
			arg_2862_0.Location = location;
			this.TabPageAdv2.Name = "TabPageAdv2";
			Control arg_288F_0 = this.TabPageAdv2;
			size = new Size(488, 329);
			arg_288F_0.Size = size;
			this.TabPageAdv2.set_TabFont(null);
			this.TabPageAdv2.set_TabIndex(1);
			this.TabPageAdv2.set_Text("计算公式");
			this.TabPageAdv2.set_ThemesEnabled(false);
			Control arg_28DD_0 = this.Button15;
			location = new Point(416, 72);
			arg_28DD_0.Location = location;
			this.Button15.Name = "Button15";
			Control arg_2904_0 = this.Button15;
			size = new Size(60, 23);
			arg_2904_0.Size = size;
			this.Button15.TabIndex = 21;
			this.Button15.Text = "全编";
			Control arg_293B_0 = this.Button16;
			location = new Point(348, 72);
			arg_293B_0.Location = location;
			this.Button16.Name = "Button16";
			Control arg_2962_0 = this.Button16;
			size = new Size(60, 23);
			arg_2962_0.Size = size;
			this.Button16.TabIndex = 20;
			this.Button16.Text = "编译";
			Control arg_2999_0 = this.Button17;
			location = new Point(280, 72);
			arg_2999_0.Location = location;
			this.Button17.Name = "Button17";
			Control arg_29C0_0 = this.Button17;
			size = new Size(60, 23);
			arg_29C0_0.Size = size;
			this.Button17.TabIndex = 19;
			this.Button17.Text = "下移";
			Control arg_29F7_0 = this.Button18;
			location = new Point(212, 72);
			arg_29F7_0.Location = location;
			this.Button18.Name = "Button18";
			Control arg_2A1E_0 = this.Button18;
			size = new Size(60, 23);
			arg_2A1E_0.Size = size;
			this.Button18.TabIndex = 18;
			this.Button18.Text = "上移";
			Control arg_2A52_0 = this.Button19;
			location = new Point(76, 72);
			arg_2A52_0.Location = location;
			this.Button19.Name = "Button19";
			Control arg_2A79_0 = this.Button19;
			size = new Size(60, 23);
			arg_2A79_0.Size = size;
			this.Button19.TabIndex = 17;
			this.Button19.Text = "更新";
			Control arg_2AB0_0 = this.Button20;
			location = new Point(144, 72);
			arg_2AB0_0.Location = location;
			this.Button20.Name = "Button20";
			Control arg_2AD7_0 = this.Button20;
			size = new Size(60, 23);
			arg_2AD7_0.Size = size;
			this.Button20.TabIndex = 16;
			this.Button20.Text = "删除";
			Control arg_2B0A_0 = this.Button21;
			location = new Point(8, 72);
			arg_2B0A_0.Location = location;
			this.Button21.Name = "Button21";
			Control arg_2B31_0 = this.Button21;
			size = new Size(60, 23);
			arg_2B31_0.Size = size;
			this.Button21.TabIndex = 15;
			this.Button21.Text = "添加";
			Control arg_2B65_0 = this.Label5;
			location = new Point(14, 42);
			arg_2B65_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_2B8C_0 = this.Label5;
			size = new Size(50, 23);
			arg_2B8C_0.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "说明：";
			this.Label5.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_2BCC_0 = this.Label6;
			location = new Point(14, 15);
			arg_2BCC_0.Location = location;
			this.Label6.Name = "Label6";
			Control arg_2BF3_0 = this.Label6;
			size = new Size(50, 23);
			arg_2BF3_0.Size = size;
			this.Label6.TabIndex = 2;
			this.Label6.Text = "公式：";
			this.Label6.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_2C33_0 = this.TextBox5;
			location = new Point(72, 40);
			arg_2C33_0.Location = location;
			this.TextBox5.Name = "TextBox5";
			Control arg_2C5D_0 = this.TextBox5;
			size = new Size(404, 21);
			arg_2C5D_0.Size = size;
			this.TextBox5.TabIndex = 1;
			this.TextBox6.AllowDrop = true;
			Control arg_2C8C_0 = this.TextBox6;
			location = new Point(72, 13);
			arg_2C8C_0.Location = location;
			this.TextBox6.Name = "TextBox6";
			Control arg_2CB6_0 = this.TextBox6;
			size = new Size(404, 21);
			arg_2CB6_0.Size = size;
			this.TextBox6.TabIndex = 0;
			this.TabPageAdv3.ImeMode = ImeMode.Off;
			Control arg_2CE4_0 = this.TabPageAdv3;
			location = new Point(0, 23);
			arg_2CE4_0.Location = location;
			this.TabPageAdv3.Name = "TabPageAdv3";
			Control arg_2D11_0 = this.TabPageAdv3;
			size = new Size(488, 329);
			arg_2D11_0.Size = size;
			this.TabPageAdv3.set_TabFont(null);
			this.TabPageAdv3.set_TabIndex(2);
			this.TabPageAdv3.set_Text("提示公式");
			this.TabPageAdv3.set_ThemesEnabled(false);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.FormulaTabs);
			this.Controls.Add(this.cbxBindKB);
			this.Controls.Add(this.btnKB);
			this.Controls.Add(this.txtBindKBName);
			this.Name = "MMetaDataProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.FormulaTabs.EndInit();
			this.FormulaTabs.ResumeLayout(false);
			this.AuditTab.ResumeLayout(false);
			this.AuditTab.PerformLayout();
			((ISupportInitialize)this.AuditGrid).EndInit();
			this.CalculateTab.ResumeLayout(false);
			this.CalculateTab.PerformLayout();
			((ISupportInitialize)this.CalGrid).EndInit();
			this.TipTab.ResumeLayout(false);
			this.TipTab.PerformLayout();
			((ISupportInitialize)this.TipGrid).EndInit();
			((ISupportInitialize)this.DataGrid2).EndInit();
			((ISupportInitialize)this.DataGrid3).EndInit();
			((ISupportInitialize)this.DataGrid1).EndInit();
			this.TabPageAdv1.ResumeLayout(false);
			this.TabPageAdv1.PerformLayout();
			this.TabPageAdv2.ResumeLayout(false);
			this.TabPageAdv2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public void Init()
		{
			this.tmpCalFormulaItems = new MFormulaItemCollection();
			MFormulaItem value = new MFormulaItem();
			this.tmpCalFormulaItems.Add(value);
			this.tmpAuditFormulaItems = new MFormulaItemCollection();
			MFormulaItem value2 = new MFormulaItem();
			this.tmpAuditFormulaItems.Add(value2);
			this.tmpTipFormulaItems = new MFormulaItemCollection();
			MFormulaItem value3 = new MFormulaItem();
			this.tmpTipFormulaItems.Add(value3);
		}

		private void cbxBindKB_CheckedChanged(object sender, EventArgs e)
		{
			this._MetaData.BindKB = this.cbxBindKB.Checked;
			this.txtBindKBName.Enabled = this.cbxBindKB.Checked;
			this.btnKB.Enabled = this.cbxBindKB.Checked;
		}

		private void btnKB_Click(object sender, EventArgs e)
		{
			Control arg_10_0 = this.btnKB;
			Point p = new Point(0, 0);
			Point location = arg_10_0.PointToScreen(p);
			KnowledgeBaseForm knowledgeBaseForm = new KnowledgeBaseForm();
			checked
			{
				location.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (location.X + knowledgeBaseForm.Height > workingArea.Width)
				{
					location.X = workingArea.Width - knowledgeBaseForm.Width;
				}
				if (location.Y + knowledgeBaseForm.Height > workingArea.Height)
				{
					location.Y = workingArea.Height - knowledgeBaseForm.Height;
				}
				knowledgeBaseForm.StartPosition = FormStartPosition.Manual;
				knowledgeBaseForm.Location = location;
				knowledgeBaseForm.TopMost = true;
				knowledgeBaseForm.ShowInTaskbar = false;
				if (knowledgeBaseForm.ShowDialog() == DialogResult.OK)
				{
					this._MetaData.BindKBCode = knowledgeBaseForm.KBCode;
					this._MetaData.BindKBName = knowledgeBaseForm.KBName;
					this.txtBindKBName.Text = knowledgeBaseForm.KBName;
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this._MetaData.BindKBCode))
			{
				this._MetaData.BindKBCode = string.Empty;
				this._MetaData.BindKBName = string.Empty;
				this.txtBindKBName.Text = string.Empty;
			}
		}

		private void AuditBind()
		{
			if (this.AuditFormulaItems.Count == 0)
			{
				this.CurrentAuditRow = -1;
				this.AuditGrid.DataSource = null;
				this.AuditGrid.DataSource = this.tmpAuditFormulaItems;
				this.AuditGridTableStyle.DataGrid = this.AuditGrid;
				this.AuditGridTableStyle.MappingName = "MFormulaItemCollection";
			}
			else
			{
				this.AuditGrid.DataSource = null;
				this.AuditGrid.DataSource = this.AuditFormulaItems;
				this.AuditGridTableStyle.DataGrid = this.AuditGrid;
				this.AuditGridTableStyle.MappingName = "MFormulaItemCollection";
			}
		}

		private void AuditGrid_Paint(object sender, PaintEventArgs e)
		{
			if (this.CurrentAuditRow > -1)
			{
				this.AuditGrid.Select(this.CurrentAuditRow);
			}
		}

		private void AuditGrid_CurrentCellChanged(object sender, EventArgs e)
		{
			if (!this.IsAuditBind)
			{
				if (this.AuditGrid.DataSource.Equals(this.tmpAuditFormulaItems))
				{
					this.CurrentAuditRow = -1;
				}
				else if (this.AuditGrid.CurrentRowIndex > -1)
				{
					this.CurrentAuditRow = this.AuditGrid.CurrentRowIndex;
					this.txtAuditFormula.Text = this.AuditFormulaItems[this.CurrentAuditRow].StrFormula;
					this.txtAuditDesc.Text = this.AuditFormulaItems[this.CurrentAuditRow].Description;
				}
			}
		}

		private void btnAuditAdd_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtAuditFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			MFormulaItem mFormulaItem = new MFormulaItem();
			mFormulaItem.NInstanceData = (NInstanceData)this._MetaData.BindInstanceItem;
			mFormulaItem.StrFormula = this.txtAuditFormula.Text;
			mFormulaItem.Description = this.txtAuditDesc.Text;
			this.AuditFormulaItems.Add(mFormulaItem);
			this.CurrentAuditRow = checked(this.AuditFormulaItems.Count - 1);
			this.AuditBind();
			this.AuditGrid.CurrentRowIndex = this.CurrentAuditRow;
		}

		private void btnAuditUpdate_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtAuditFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			if (this.CurrentAuditRow == -1)
			{
				MFormulaItem mFormulaItem = new MFormulaItem();
				mFormulaItem.StrFormula = this.txtAuditFormula.Text;
				mFormulaItem.Description = this.txtAuditDesc.Text;
				this.AuditFormulaItems.Add(mFormulaItem);
				this.CurrentAuditRow = 0;
				this.AuditBind();
			}
			else
			{
				MFormulaItem mFormulaItem2 = this.AuditFormulaItems[this.CurrentAuditRow];
				mFormulaItem2.StrFormula = this.txtAuditFormula.Text;
				mFormulaItem2.Description = this.txtAuditDesc.Text;
				this.AuditBind();
			}
		}

		private void btnAuditDelete_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentAuditRow > -1)
				{
					int currentAuditRow = this.CurrentAuditRow;
					if (this.CurrentAuditRow == this.AuditFormulaItems.Count - 1 & this.AuditFormulaItems.Count > 1)
					{
						this.CurrentAuditRow = this.AuditFormulaItems.Count - 2;
					}
					this.IsAuditBind = true;
					this.AuditGrid.CurrentRowIndex = -1;
					this.AuditFormulaItems.RemoveAt(currentAuditRow);
					this.AuditBind();
					this.IsAuditBind = false;
					if (this.CurrentAuditRow > -1)
					{
						this.AuditGrid.CurrentRowIndex = this.CurrentAuditRow;
					}
				}
			}
		}

		private void btnAuditUp_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentAuditRow > 0)
				{
					this.IsAuditBind = true;
					MFormulaItem value = this.AuditFormulaItems[this.CurrentAuditRow];
					this.AuditFormulaItems.RemoveAt(this.CurrentAuditRow);
					this.CurrentAuditRow--;
					this.AuditFormulaItems.Insert(this.CurrentAuditRow, value);
					this.AuditBind();
					this.IsAuditBind = false;
					this.AuditGrid.CurrentRowIndex = this.CurrentAuditRow;
				}
			}
		}

		private void btnAuditDown_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentAuditRow > -1 & this.CurrentAuditRow < this.AuditFormulaItems.Count - 1)
				{
					this.IsAuditBind = true;
					MFormulaItem value = this.AuditFormulaItems[this.CurrentAuditRow];
					this.AuditFormulaItems.RemoveAt(this.CurrentAuditRow);
					this.CurrentAuditRow++;
					this.AuditFormulaItems.Insert(this.CurrentAuditRow, value);
					this.AuditBind();
					this.IsAuditBind = false;
					this.AuditGrid.CurrentRowIndex = this.CurrentAuditRow;
				}
			}
		}

		private void btnAuditCompile_Click(object sender, EventArgs e)
		{
			if (this.CurrentAuditRow > -1)
			{
				bool flag = true;
				MFormulaItem mFormulaItem = this.AuditFormulaItems[this.CurrentAuditRow];
				try
				{
					mFormulaItem.Formula.Compile();
				}
				catch (ApplicationException expr_2A)
				{
					ProjectData.SetProjectError(expr_2A);
					ApplicationException ex = expr_2A;
					flag = false;
					MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
					ProjectData.ClearProjectError();
				}
				if (flag)
				{
					MessageManager.ShowInformationMessage("编译成功！");
				}
			}
		}

		private void btnAuditCompileAll_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentAuditRow > -1)
				{
					bool flag = true;
					int num = 0;
					try
					{
						MFormulaItemEnumerator enumerator = this.AuditFormulaItems.GetEnumerator();
						while (enumerator.MoveNext())
						{
							MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
							mFormulaItem.Formula.Compile();
							num++;
						}
					}
					catch (ApplicationException expr_46)
					{
						ProjectData.SetProjectError(expr_46);
						ApplicationException ex = expr_46;
						flag = false;
						this.IsAuditBind = true;
						this.AuditBind();
						this.IsAuditBind = false;
						this.CurrentAuditRow = num;
						this.AuditGrid.CurrentRowIndex = num;
						MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
						ProjectData.ClearProjectError();
					}
					if (flag)
					{
						MessageManager.ShowInformationMessage("编译成功！");
					}
				}
			}
		}

		private void txtAuditFormula_DragEnter(object sender, DragEventArgs e)
		{
			if (this.MetaItemTree.DragMetaItem != null)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void txtAuditFormula_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.Move)
			{
				int selectionStart = this.txtAuditFormula.SelectionStart;
				this.txtAuditFormula.Text = this.txtAuditFormula.Text.Insert(selectionStart, this.MetaItemTree.DragMetaItem.Code);
				this.txtAuditFormula.SelectionStart = selectionStart;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}

		private void CalBind()
		{
			if (this.CalFormulaItems.Count == 0)
			{
				this.CurrentCalRow = -1;
				this.CalGrid.DataSource = null;
				this.CalGrid.DataSource = this.tmpCalFormulaItems;
				this.CalGridTableStyle.DataGrid = this.CalGrid;
				this.CalGridTableStyle.MappingName = "MFormulaItemCollection";
			}
			else
			{
				this.CalGrid.DataSource = null;
				this.CalGrid.DataSource = this.CalFormulaItems;
				this.CalGridTableStyle.DataGrid = this.CalGrid;
				this.CalGridTableStyle.MappingName = "MFormulaItemCollection";
			}
		}

		private void CalGrid_Paint(object sender, PaintEventArgs e)
		{
			if (this.CurrentCalRow > -1)
			{
				this.CalGrid.Select(this.CurrentCalRow);
			}
		}

		private void CalGrid_CurrentCellChanged(object sender, EventArgs e)
		{
			if (!this.IsCalBind)
			{
				if (this.CalGrid.DataSource.Equals(this.tmpCalFormulaItems))
				{
					this.CurrentCalRow = -1;
				}
				else if (this.CalGrid.CurrentRowIndex > -1)
				{
					this.CurrentCalRow = this.CalGrid.CurrentRowIndex;
					this.txtCalFormula.Text = this.CalFormulaItems[this.CurrentCalRow].StrFormula;
					this.txtCalDesc.Text = this.CalFormulaItems[this.CurrentCalRow].Description;
				}
			}
		}

		private void btnCalAdd_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtCalFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			MFormulaItem mFormulaItem = new MFormulaItem();
			mFormulaItem.NInstanceData = (NInstanceData)this.MetaData.BindInstanceItem;
			mFormulaItem.StrFormula = this.txtCalFormula.Text;
			mFormulaItem.Description = this.txtCalDesc.Text;
			this.CalFormulaItems.Add(mFormulaItem);
			this.CurrentCalRow = checked(this.CalFormulaItems.Count - 1);
			this.CalBind();
			this.CalGrid.CurrentRowIndex = this.CurrentCalRow;
		}

		private void btnCalUpdate_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtCalFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			if (this.CurrentCalRow == -1)
			{
				MFormulaItem mFormulaItem = new MFormulaItem();
				mFormulaItem.StrFormula = this.txtCalFormula.Text;
				mFormulaItem.Description = this.txtCalDesc.Text;
				this.CalFormulaItems.Add(mFormulaItem);
				this.CurrentCalRow = 0;
				this.CalBind();
			}
			else
			{
				MFormulaItem mFormulaItem2 = this.CalFormulaItems[this.CurrentCalRow];
				mFormulaItem2.StrFormula = this.txtCalFormula.Text;
				mFormulaItem2.Description = this.txtCalDesc.Text;
				this.CalBind();
			}
		}

		private void btnCalDelete_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentCalRow > -1)
				{
					int currentCalRow = this.CurrentCalRow;
					if (this.CurrentCalRow == this.CalFormulaItems.Count - 1 & this.CalFormulaItems.Count > 1)
					{
						this.CurrentCalRow = this.CalFormulaItems.Count - 2;
					}
					this.IsCalBind = true;
					this.CalGrid.CurrentRowIndex = -1;
					this.CalFormulaItems.RemoveAt(currentCalRow);
					this.CalBind();
					this.IsCalBind = false;
					if (this.CurrentCalRow > -1)
					{
						this.CalGrid.CurrentRowIndex = this.CurrentCalRow;
					}
				}
			}
		}

		private void btnCalUp_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentCalRow > 0)
				{
					this.IsCalBind = true;
					MFormulaItem value = this.CalFormulaItems[this.CurrentCalRow];
					this.CalFormulaItems.RemoveAt(this.CurrentCalRow);
					this.CurrentCalRow--;
					this.CalFormulaItems.Insert(this.CurrentCalRow, value);
					this.CalBind();
					this.IsCalBind = false;
					this.CalGrid.CurrentRowIndex = this.CurrentCalRow;
				}
			}
		}

		private void btnCalDown_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentCalRow > -1 & this.CurrentCalRow < this.CalFormulaItems.Count - 1)
				{
					this.IsCalBind = true;
					MFormulaItem value = this.CalFormulaItems[this.CurrentCalRow];
					this.CalFormulaItems.RemoveAt(this.CurrentCalRow);
					this.CurrentCalRow++;
					this.CalFormulaItems.Insert(this.CurrentCalRow, value);
					this.CalBind();
					this.IsCalBind = false;
					this.CalGrid.CurrentRowIndex = this.CurrentCalRow;
				}
			}
		}

		private void btnCalCompile_Click(object sender, EventArgs e)
		{
			if (this.CurrentCalRow > -1)
			{
				bool flag = true;
				MFormulaItem mFormulaItem = this.CalFormulaItems[this.CurrentCalRow];
				try
				{
					mFormulaItem.Formula.Compile();
				}
				catch (ApplicationException expr_2A)
				{
					ProjectData.SetProjectError(expr_2A);
					ApplicationException ex = expr_2A;
					flag = false;
					MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
					ProjectData.ClearProjectError();
				}
				if (flag)
				{
					MessageManager.ShowInformationMessage("编译成功！");
				}
			}
		}

		private void btnCalCompileAll_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentCalRow > -1)
				{
					bool flag = true;
					int num = 0;
					try
					{
						MFormulaItemEnumerator enumerator = this.CalFormulaItems.GetEnumerator();
						while (enumerator.MoveNext())
						{
							MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
							mFormulaItem.Formula.Compile();
							num++;
						}
					}
					catch (ApplicationException expr_46)
					{
						ProjectData.SetProjectError(expr_46);
						ApplicationException ex = expr_46;
						flag = false;
						this.IsCalBind = true;
						this.CalBind();
						this.IsCalBind = false;
						this.CurrentCalRow = num;
						this.CalGrid.CurrentRowIndex = num;
						MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
						ProjectData.ClearProjectError();
					}
					if (flag)
					{
						MessageManager.ShowInformationMessage("编译成功！");
					}
				}
			}
		}

		private void txtCalFormula_DragEnter(object sender, DragEventArgs e)
		{
			if (this.MetaItemTree.DragMetaItem != null)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void txtCalFormula_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.Move)
			{
				int selectionStart = this.txtCalFormula.SelectionStart;
				this.txtCalFormula.Text = this.txtCalFormula.Text.Insert(selectionStart, this.MetaItemTree.DragMetaItem.Code);
				this.txtCalFormula.SelectionStart = selectionStart;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}

		private void TipBind()
		{
			if (this.TipFormulaItems.Count == 0)
			{
				this.CurrentTipRow = -1;
				this.TipGrid.DataSource = null;
				this.TipGrid.DataSource = this.tmpTipFormulaItems;
				this.TipGridTableStyle.DataGrid = this.TipGrid;
				this.TipGridTableStyle.MappingName = "MFormulaItemCollection";
			}
			else
			{
				this.TipGrid.DataSource = null;
				this.TipGrid.DataSource = this.TipFormulaItems;
				this.TipGridTableStyle.DataGrid = this.TipGrid;
				this.TipGridTableStyle.MappingName = "MFormulaItemCollection";
			}
		}

		private void TipGrid_Paint(object sender, PaintEventArgs e)
		{
			if (this.CurrentTipRow > -1)
			{
				this.TipGrid.Select(this.CurrentTipRow);
			}
		}

		private void TipGrid_CurrentCellChanged(object sender, EventArgs e)
		{
			if (!this.IsTipBind)
			{
				if (this.TipGrid.DataSource.Equals(this.tmpTipFormulaItems))
				{
					this.CurrentTipRow = -1;
				}
				else if (this.TipGrid.CurrentRowIndex > -1)
				{
					this.CurrentTipRow = this.TipGrid.CurrentRowIndex;
					this.txtTipFormula.Text = this.TipFormulaItems[this.CurrentTipRow].StrFormula;
					this.txtTipDesc.Text = this.TipFormulaItems[this.CurrentTipRow].Description;
				}
			}
		}

		private void btnTipAdd_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtTipFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			MFormulaItem mFormulaItem = new MFormulaItem();
			mFormulaItem.NInstanceData = (NInstanceData)this.MetaData.BindInstanceItem;
			mFormulaItem.StrFormula = this.txtTipFormula.Text;
			mFormulaItem.Description = this.txtTipDesc.Text;
			this.TipFormulaItems.Add(mFormulaItem);
			this.CurrentTipRow = checked(this.TipFormulaItems.Count - 1);
			this.TipBind();
			this.TipGrid.CurrentRowIndex = this.CurrentTipRow;
		}

		private void btnTipUpdate_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtTipFormula.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("公式为空，请输入！");
				return;
			}
			if (this.CurrentTipRow == -1)
			{
				MFormulaItem mFormulaItem = new MFormulaItem();
				mFormulaItem.StrFormula = this.txtTipFormula.Text;
				mFormulaItem.Description = this.txtTipDesc.Text;
				this.TipFormulaItems.Add(mFormulaItem);
				this.CurrentTipRow = 0;
				this.TipBind();
			}
			else
			{
				MFormulaItem mFormulaItem2 = this.TipFormulaItems[this.CurrentTipRow];
				mFormulaItem2.StrFormula = this.txtTipFormula.Text;
				mFormulaItem2.Description = this.txtTipDesc.Text;
				this.TipBind();
			}
		}

		private void btnTipDelete_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentTipRow > -1)
				{
					int currentTipRow = this.CurrentTipRow;
					if (this.CurrentTipRow == this.TipFormulaItems.Count - 1 & this.TipFormulaItems.Count > 1)
					{
						this.CurrentTipRow = this.TipFormulaItems.Count - 2;
					}
					this.IsTipBind = true;
					this.TipGrid.CurrentRowIndex = -1;
					this.TipFormulaItems.RemoveAt(currentTipRow);
					this.TipBind();
					this.IsTipBind = false;
					if (this.CurrentTipRow > -1)
					{
						this.TipGrid.CurrentRowIndex = this.CurrentTipRow;
					}
				}
			}
		}

		private void btnTipUp_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentTipRow > 0)
				{
					this.IsTipBind = true;
					MFormulaItem value = this.TipFormulaItems[this.CurrentTipRow];
					this.TipFormulaItems.RemoveAt(this.CurrentTipRow);
					this.CurrentTipRow--;
					this.TipFormulaItems.Insert(this.CurrentTipRow, value);
					this.TipBind();
					this.IsTipBind = false;
					this.TipGrid.CurrentRowIndex = this.CurrentTipRow;
				}
			}
		}

		private void btnTipDown_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentTipRow > -1 & this.CurrentTipRow < this.TipFormulaItems.Count - 1)
				{
					this.IsTipBind = true;
					MFormulaItem value = this.TipFormulaItems[this.CurrentTipRow];
					this.TipFormulaItems.RemoveAt(this.CurrentTipRow);
					this.CurrentTipRow++;
					this.TipFormulaItems.Insert(this.CurrentTipRow, value);
					this.TipBind();
					this.IsTipBind = false;
					this.TipGrid.CurrentRowIndex = this.CurrentTipRow;
				}
			}
		}

		private void btnTipCompile_Click(object sender, EventArgs e)
		{
			if (this.CurrentTipRow > -1)
			{
				bool flag = true;
				MFormulaItem mFormulaItem = this.TipFormulaItems[this.CurrentTipRow];
				try
				{
					mFormulaItem.Formula.Compile();
				}
				catch (ApplicationException expr_2A)
				{
					ProjectData.SetProjectError(expr_2A);
					ApplicationException ex = expr_2A;
					flag = false;
					MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
					ProjectData.ClearProjectError();
				}
				if (flag)
				{
					MessageManager.ShowInformationMessage("编译成功！");
				}
			}
		}

		private void btnTipCompileAll_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.CurrentTipRow > -1)
				{
					bool flag = true;
					int num = 0;
					try
					{
						MFormulaItemEnumerator enumerator = this.TipFormulaItems.GetEnumerator();
						while (enumerator.MoveNext())
						{
							MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
							mFormulaItem.Formula.Compile();
							num++;
						}
					}
					catch (ApplicationException expr_46)
					{
						ProjectData.SetProjectError(expr_46);
						ApplicationException ex = expr_46;
						flag = false;
						this.IsTipBind = true;
						this.TipBind();
						this.IsTipBind = false;
						this.CurrentTipRow = num;
						this.TipGrid.CurrentRowIndex = num;
						MessageManager.ShowWarningMessage("公式编译错误：\r\n" + ex.Message);
						ProjectData.ClearProjectError();
					}
					if (flag)
					{
						MessageManager.ShowInformationMessage("编译成功！");
					}
				}
			}
		}

		private void txtTipFormula_DragEnter(object sender, DragEventArgs e)
		{
			if (this.MetaItemTree.DragMetaItem != null)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void txtTipFormula_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.Move)
			{
				int selectionStart = this.txtTipFormula.SelectionStart;
				this.txtTipFormula.Text = this.txtTipFormula.Text.Insert(selectionStart, this.MetaItemTree.DragMetaItem.Code);
				this.txtTipFormula.SelectionStart = selectionStart;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}
	}
}
