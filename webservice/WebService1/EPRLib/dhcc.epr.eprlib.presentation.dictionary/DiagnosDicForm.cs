using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.web;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using MRDiagnosData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class DiagnosDicForm : Form
	{
		private class KeyText
		{
			private string _text;

			private object _value;

			public string Text
			{
				get
				{
					return this._text;
				}
				set
				{
					this._text = value;
				}
			}

			public object Value
			{
				get
				{
					return this._value;
				}
				set
				{
					this._value = RuntimeHelpers.GetObjectValue(value);
				}
			}

			[DebuggerNonUserCode]
			public KeyText()
			{
			}

			public override string ToString()
			{
				return this._text;
			}
		}

		private IContainer components;

		[AccessedThroughProperty("tpEpsoidList")]
		private TabPage _tpEpsoidList;

		[AccessedThroughProperty("dgBOLISData")]
		private DataGridView _dgBOLISData;

		[AccessedThroughProperty("tcCheckReport")]
		private TabControl _tcCheckReport;

		[AccessedThroughProperty("tpQuoted")]
		private TabPage _tpQuoted;

		[AccessedThroughProperty("ToolTips")]
		private ToolTip _ToolTips;

		[AccessedThroughProperty("tpWebEpdReport")]
		private TabPage _tpWebEpdReport;

		[AccessedThroughProperty("webBrowserMedEpdReport")]
		private BrowserMedEpdReport _webBrowserMedEpdReport;

		[AccessedThroughProperty("SplitContainerEx3")]
		private SplitContainerEx _SplitContainerEx3;

		[AccessedThroughProperty("gbStyle")]
		private GroupBox _gbStyle;

		[AccessedThroughProperty("rbRowModle")]
		private RadioButton _rbRowModle;

		[AccessedThroughProperty("rbLevelModle")]
		private RadioButton _rbLevelModle;

		[AccessedThroughProperty("btAdd")]
		private Button _btAdd;

		[AccessedThroughProperty("btSaveQuote")]
		private Button _btSaveQuote;

		[AccessedThroughProperty("cbDiagnosEffects")]
		private ComboBox _cbDiagnosEffects;

		[AccessedThroughProperty("cbDiagnosEvaluation")]
		private ComboBox _cbDiagnosEvaluation;

		[AccessedThroughProperty("dgvMRDiagnos")]
		private DataGridView _dgvMRDiagnos;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("dgvHistory")]
		private DataGridView _dgvHistory;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("DiagnosRowID")]
		private DataGridViewTextBoxColumn _DiagnosRowID;

		[AccessedThroughProperty("DiagnosID")]
		private DataGridViewTextBoxColumn _DiagnosID;

		[AccessedThroughProperty("DiagnosSubID")]
		private DataGridViewTextBoxColumn _DiagnosSubID;

		[AccessedThroughProperty("DiagnosTypeID")]
		private DataGridViewTextBoxColumn _DiagnosTypeID;

		[AccessedThroughProperty("DiagnosType")]
		private DataGridViewTextBoxColumn _DiagnosType;

		[AccessedThroughProperty("DiagnosNameID")]
		private DataGridViewTextBoxColumn _DiagnosNameID;

		[AccessedThroughProperty("DiagnosName")]
		private DataGridViewTextBoxColumn _DiagnosName;

		[AccessedThroughProperty("DiagnosDemo")]
		private DataGridViewTextBoxColumn _DiagnosDemo;

		[AccessedThroughProperty("DiagnosEvaluationID")]
		private DataGridViewTextBoxColumn _DiagnosEvaluationID;

		[AccessedThroughProperty("DiagnosEvaluation")]
		private DataGridViewTextBoxColumn _DiagnosEvaluation;

		[AccessedThroughProperty("ICDCode")]
		private DataGridViewTextBoxColumn _ICDCode;

		[AccessedThroughProperty("DiagnosEffectsID")]
		private DataGridViewTextBoxColumn _DiagnosEffectsID;

		[AccessedThroughProperty("DiagnosEffects")]
		private DataGridViewTextBoxColumn _DiagnosEffects;

		[AccessedThroughProperty("DiagnosDele")]
		private DataGridViewImageColumn _DiagnosDele;

		[AccessedThroughProperty("btDecrease")]
		private DataGridViewImageColumn _btDecrease;

		[AccessedThroughProperty("btIncrease")]
		private DataGridViewImageColumn _btIncrease;

		[AccessedThroughProperty("dgtbcUP")]
		private DataGridViewImageColumn _dgtbcUP;

		[AccessedThroughProperty("dgtbcDown")]
		private DataGridViewImageColumn _dgtbcDown;

		[AccessedThroughProperty("DiagnosLevel")]
		private DataGridViewTextBoxColumn _DiagnosLevel;

		[AccessedThroughProperty("DiagnosSequence")]
		private DataGridViewTextBoxColumn _DiagnosSequence;

		[AccessedThroughProperty("UserName")]
		private DataGridViewTextBoxColumn _UserName;

		[AccessedThroughProperty("DateTime")]
		private DataGridViewTextBoxColumn _DateTime;

		[AccessedThroughProperty("dgvDiagnosList")]
		private DataGridView _dgvDiagnosList;

		[AccessedThroughProperty("QCselect")]
		private DataGridViewCheckBoxColumn _QCselect;

		[AccessedThroughProperty("QCRowID")]
		private DataGridViewTextBoxColumn _QCRowID;

		[AccessedThroughProperty("QCMRADMRowId")]
		private DataGridViewTextBoxColumn _QCMRADMRowId;

		[AccessedThroughProperty("QCsubID")]
		private DataGridViewTextBoxColumn _QCsubID;

		[AccessedThroughProperty("QCDiagnosTypeID")]
		private DataGridViewTextBoxColumn _QCDiagnosTypeID;

		[AccessedThroughProperty("QCDiagnosType")]
		private DataGridViewTextBoxColumn _QCDiagnosType;

		[AccessedThroughProperty("QCICD")]
		private DataGridViewTextBoxColumn _QCICD;

		[AccessedThroughProperty("QCICDDesc")]
		private DataGridViewTextBoxColumn _QCICDDesc;

		[AccessedThroughProperty("QCDemo")]
		private DataGridViewTextBoxColumn _QCDemo;

		[AccessedThroughProperty("QCEvaluation")]
		private DataGridViewTextBoxColumn _QCEvaluation;

		[AccessedThroughProperty("QCEvalDesc")]
		private DataGridViewTextBoxColumn _QCEvalDesc;

		[AccessedThroughProperty("QCICDCode")]
		private DataGridViewTextBoxColumn _QCICDCode;

		[AccessedThroughProperty("QCEffects")]
		private DataGridViewTextBoxColumn _QCEffects;

		[AccessedThroughProperty("QCEffDesc")]
		private DataGridViewTextBoxColumn _QCEffDesc;

		[AccessedThroughProperty("QCLevel")]
		private DataGridViewTextBoxColumn _QCLevel;

		[AccessedThroughProperty("QCSquence")]
		private DataGridViewTextBoxColumn _QCSquence;

		[AccessedThroughProperty("CQUserName")]
		private DataGridViewTextBoxColumn _CQUserName;

		[AccessedThroughProperty("QCDateTime")]
		private DataGridViewTextBoxColumn _QCDateTime;

		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[AccessedThroughProperty("rbQRowModel")]
		private RadioButton _rbQRowModel;

		[AccessedThroughProperty("rbQlevelModel")]
		private RadioButton _rbQlevelModel;

		[AccessedThroughProperty("ckbCheck")]
		private CheckBox _ckbCheck;

		private string m_EpisodeID;

		private EMRDiagnosDataSet m_MRDiagnos;

		private EMRDiagnosDataSet.GetMRDiagnosListDataTable m_CurrentTable;

		private CommonQuoteClass m_EpsoideList;

		private MIDictionary m_BindMIDictionary;

		private StdDicForm m_DictionaryForm;

		public string m_DiagnosTypeID;

		private string m_PresentDiagnosTypeID;

		private string m_UserID;

		private EMRDiagnosStatuesTypeDataset dsType;

		private DataTable DTEvaluation;

		private DataTable DTEffect;

		private DataTable DTDiagnosType;

		private string m_PatientID;

		private int m_Level;

		private string m_IcdId;

		private string m_IcdName;

		private int m_RowIndex;

		private string m_MRID;

		private string m_SUBID;

		private DiagnosDicForm.KeyText m_ICD;

		private string m_StyleRadio;

		private string StyleScheme;

		private List<string> m_ButtionList;

		private bool bEditMode;

		private EMRDiagnosDataSet.GetMRDiagnosListDataTable m_CurrentDiagnosQuoteTable;

		private string m_DicValue;

		private string m_DicValueCode;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("lbICDS")]
		private ListBox _lbICDS;

		[AccessedThroughProperty("tctrolTapModle")]
		private TabControl _tctrolTapModle;

		[AccessedThroughProperty("tbICD")]
		private TextBox _tbICD;

		[AccessedThroughProperty("HRowId")]
		private DataGridViewTextBoxColumn _HRowId;

		[AccessedThroughProperty("HDesc")]
		private DataGridViewTextBoxColumn _HDesc;

		[AccessedThroughProperty("HDoctDesc")]
		private DataGridViewTextBoxColumn _HDoctDesc;

		[AccessedThroughProperty("HMRDate")]
		private DataGridViewTextBoxColumn _HMRDate;

		[AccessedThroughProperty("RTime")]
		private DataGridViewTextBoxColumn _RTime;

		[AccessedThroughProperty("HMRDesc")]
		private DataGridViewTextBoxColumn _HMRDesc;

		[AccessedThroughProperty("HDisplay")]
		private DataGridViewImageColumn _HDisplay;

		[AccessedThroughProperty("tpAllType")]
		private TabPage _tpAllType;

		[AccessedThroughProperty("lbDiagnosType")]
		private ListBox _lbDiagnosType;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("btOK")]
		private Button _btOK;

		[AccessedThroughProperty("btCancel")]
		private Button _btCancel;

		internal virtual TabPage tpEpsoidList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpEpsoidList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpEpsoidList = value;
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgBOLISData_CellDoubleClick);
				if (this._dgBOLISData != null)
				{
					this._dgBOLISData.CellDoubleClick -= value2;
				}
				this._dgBOLISData = value;
				if (this._dgBOLISData != null)
				{
					this._dgBOLISData.CellDoubleClick += value2;
				}
			}
		}

		internal virtual TabControl tcCheckReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcCheckReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tcCheckReport_SelectedIndexChanged);
				if (this._tcCheckReport != null)
				{
					this._tcCheckReport.SelectedIndexChanged -= value2;
				}
				this._tcCheckReport = value;
				if (this._tcCheckReport != null)
				{
					this._tcCheckReport.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TabPage tpQuoted
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpQuoted;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpQuoted = value;
			}
		}

		internal virtual ToolTip ToolTips
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTips;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTips = value;
			}
		}

		internal virtual TabPage tpWebEpdReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpWebEpdReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpWebEpdReport = value;
			}
		}

		internal virtual BrowserMedEpdReport webBrowserMedEpdReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._webBrowserMedEpdReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._webBrowserMedEpdReport = value;
			}
		}

		internal virtual SplitContainerEx SplitContainerEx3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainerEx3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainerEx3 = value;
			}
		}

		internal virtual GroupBox gbStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbStyle = value;
			}
		}

		internal virtual RadioButton rbRowModle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbRowModle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbRowModle_CheckedChanged);
				if (this._rbRowModle != null)
				{
					this._rbRowModle.CheckedChanged -= value2;
				}
				this._rbRowModle = value;
				if (this._rbRowModle != null)
				{
					this._rbRowModle.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rbLevelModle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbLevelModle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.rbLevelModle_CheckedChanged);
				if (this._rbLevelModle != null)
				{
					this._rbLevelModle.CheckedChanged -= value2;
				}
				this._rbLevelModle = value;
				if (this._rbLevelModle != null)
				{
					this._rbLevelModle.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button btAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btAdd_Click);
				if (this._btAdd != null)
				{
					this._btAdd.Click -= value2;
				}
				this._btAdd = value;
				if (this._btAdd != null)
				{
					this._btAdd.Click += value2;
				}
			}
		}

		internal virtual Button btSaveQuote
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btSaveQuote;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btSaveQuote_Click);
				if (this._btSaveQuote != null)
				{
					this._btSaveQuote.Click -= value2;
				}
				this._btSaveQuote = value;
				if (this._btSaveQuote != null)
				{
					this._btSaveQuote.Click += value2;
				}
			}
		}

		internal virtual ComboBox cbDiagnosEffects
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbDiagnosEffects;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbDiagnosEffects = value;
			}
		}

		internal virtual ComboBox cbDiagnosEvaluation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbDiagnosEvaluation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbDiagnosEvaluation = value;
			}
		}

		internal virtual DataGridView dgvMRDiagnos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvMRDiagnos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvMRDiagnos_CellDoubleClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvMRDiagnos_CellContentClick);
				if (this._dgvMRDiagnos != null)
				{
					this._dgvMRDiagnos.CellDoubleClick -= value2;
					this._dgvMRDiagnos.CellContentClick -= value3;
				}
				this._dgvMRDiagnos = value;
				if (this._dgvMRDiagnos != null)
				{
					this._dgvMRDiagnos.CellDoubleClick += value2;
					this._dgvMRDiagnos.CellContentClick += value3;
				}
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

		internal virtual DataGridView dgvHistory
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvHistory;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvHistory_CellDoubleClick);
				if (this._dgvHistory != null)
				{
					this._dgvHistory.CellContentClick -= value2;
					this._dgvHistory.CellDoubleClick -= value3;
				}
				this._dgvHistory = value;
				if (this._dgvHistory != null)
				{
					this._dgvHistory.CellContentClick += value2;
					this._dgvHistory.CellDoubleClick += value3;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosRowID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosRowID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosRowID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosSubID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosSubID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosSubID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosTypeID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosTypeID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosTypeID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosType = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosNameID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosNameID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosNameID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosName = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosDemo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosDemo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosDemo = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosEvaluationID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosEvaluationID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosEvaluationID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosEvaluation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosEvaluation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosEvaluation = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn ICDCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ICDCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ICDCode = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosEffectsID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosEffectsID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosEffectsID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosEffects
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosEffects;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosEffects = value;
			}
		}

		internal virtual DataGridViewImageColumn DiagnosDele
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosDele;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosDele = value;
			}
		}

		internal virtual DataGridViewImageColumn btDecrease
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btDecrease;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btDecrease = value;
			}
		}

		internal virtual DataGridViewImageColumn btIncrease
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btIncrease;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btIncrease = value;
			}
		}

		internal virtual DataGridViewImageColumn dgtbcUP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgtbcUP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgtbcUP = value;
			}
		}

		internal virtual DataGridViewImageColumn dgtbcDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgtbcDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgtbcDown = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosLevel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosLevel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosLevel = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DiagnosSequence
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiagnosSequence;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DiagnosSequence = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn UserName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UserName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UserName = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DateTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateTime = value;
			}
		}

		internal virtual DataGridView dgvDiagnosList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvDiagnosList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgvDiagnosList = value;
			}
		}

		internal virtual DataGridViewCheckBoxColumn QCselect
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCselect;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCselect = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCRowID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCRowID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCRowID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCMRADMRowId
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCMRADMRowId;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCMRADMRowId = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCsubID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCsubID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCsubID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCDiagnosTypeID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCDiagnosTypeID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCDiagnosTypeID = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCDiagnosType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCDiagnosType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCDiagnosType = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCICD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCICD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCICD = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCICDDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCICDDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCICDDesc = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCDemo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCDemo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCDemo = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCEvaluation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCEvaluation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCEvaluation = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCEvalDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCEvalDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCEvalDesc = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCICDCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCICDCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCICDCode = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCEffects
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCEffects;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCEffects = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCEffDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCEffDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCEffDesc = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCLevel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCLevel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCLevel = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCSquence
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCSquence;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCSquence = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn CQUserName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CQUserName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CQUserName = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn QCDateTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QCDateTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QCDateTime = value;
			}
		}

		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		internal virtual RadioButton rbQRowModel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbQRowModel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbQRowModel = value;
			}
		}

		internal virtual RadioButton rbQlevelModel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbQlevelModel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbQlevelModel = value;
			}
		}

		internal virtual CheckBox ckbCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbCheck_Click);
				if (this._ckbCheck != null)
				{
					this._ckbCheck.Click -= value2;
				}
				this._ckbCheck = value;
				if (this._ckbCheck != null)
				{
					this._ckbCheck.Click += value2;
				}
			}
		}

		public string DicValue
		{
			get
			{
				return this.m_DicValue;
			}
			set
			{
				this.m_DicValue = value;
			}
		}

		public string DicValueCode
		{
			get
			{
				return this.m_DicValueCode;
			}
			set
			{
				this.m_DicValueCode = value;
			}
		}

		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
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

		internal virtual ListBox lbICDS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbICDS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.lbICDS_MouseClick);
				KeyEventHandler value3 = new KeyEventHandler(this.lbICDS_KeyDown);
				EventHandler value4 = new EventHandler(this.lbICDS_SelectedIndexChanged);
				if (this._lbICDS != null)
				{
					this._lbICDS.MouseClick -= value2;
					this._lbICDS.KeyDown -= value3;
					this._lbICDS.SelectedIndexChanged -= value4;
				}
				this._lbICDS = value;
				if (this._lbICDS != null)
				{
					this._lbICDS.MouseClick += value2;
					this._lbICDS.KeyDown += value3;
					this._lbICDS.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual TabControl tctrolTapModle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tctrolTapModle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tctrolTapModle = value;
			}
		}

		internal virtual TextBox tbICD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbICD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.tbICD_KeyDown);
				EventHandler value3 = new EventHandler(this.tbICD_TextChanged);
				if (this._tbICD != null)
				{
					this._tbICD.KeyDown -= value2;
					this._tbICD.TextChanged -= value3;
				}
				this._tbICD = value;
				if (this._tbICD != null)
				{
					this._tbICD.KeyDown += value2;
					this._tbICD.TextChanged += value3;
				}
			}
		}

		internal virtual DataGridViewTextBoxColumn HRowId
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HRowId;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HRowId = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn HDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HDesc = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn HDoctDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HDoctDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HDoctDesc = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn HMRDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HMRDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HMRDate = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn RTime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RTime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RTime = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn HMRDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HMRDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HMRDesc = value;
			}
		}

		internal virtual DataGridViewImageColumn HDisplay
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HDisplay;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HDisplay = value;
			}
		}

		internal virtual TabPage tpAllType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpAllType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpAllType = value;
			}
		}

		internal virtual ListBox lbDiagnosType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbDiagnosType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lbDiagnosType_Click);
				if (this._lbDiagnosType != null)
				{
					this._lbDiagnosType.Click -= value2;
				}
				this._lbDiagnosType = value;
				if (this._lbDiagnosType != null)
				{
					this._lbDiagnosType.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		internal virtual Button btOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btOK_Click);
				if (this._btOK != null)
				{
					this._btOK.Click -= value2;
				}
				this._btOK = value;
				if (this._btOK != null)
				{
					this._btOK.Click += value2;
				}
			}
		}

		internal virtual Button btCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btCancel = value;
			}
		}

		public DiagnosDicForm()
		{
			base.Load += new EventHandler(this.DiagnosDicForm_Load);
			this.m_MRDiagnos = new EMRDiagnosDataSet();
			this.m_CurrentTable = new EMRDiagnosDataSet.GetMRDiagnosListDataTable();
			this.m_BindMIDictionary = new MIDictionary();
			this.m_DictionaryForm = new StdDicForm();
			this.m_DiagnosTypeID = string.Empty;
			this.m_PresentDiagnosTypeID = string.Empty;
			this.m_UserID = string.Empty;
			this.dsType = new EMRDiagnosStatuesTypeDataset();
			this.DTEvaluation = new DataTable();
			this.DTEffect = new DataTable();
			this.DTDiagnosType = new DataTable();
			this.m_PatientID = string.Empty;
			this.m_Level = 1;
			this.m_IcdId = string.Empty;
			this.m_IcdName = string.Empty;
			this.m_RowIndex = 0;
			this.m_MRID = string.Empty;
			this.m_SUBID = string.Empty;
			this.m_ICD = new DiagnosDicForm.KeyText();
			this.m_StyleRadio = string.Empty;
			this.StyleScheme = string.Empty;
			this.m_ButtionList = new List<string>();
			this.bEditMode = false;
			this.m_CurrentDiagnosQuoteTable = new EMRDiagnosDataSet.GetMRDiagnosListDataTable();
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
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DiagnosDicForm));
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			this.tpEpsoidList = new TabPage();
			this.dgBOLISData = new DataGridView();
			this.tcCheckReport = new TabControl();
			this.tpQuoted = new TabPage();
			this.Panel2 = new Panel();
			this.lbICDS = new ListBox();
			this.tctrolTapModle = new TabControl();
			this.Label1 = new Label();
			this.GroupBox1 = new GroupBox();
			this.tbICD = new TextBox();
			this.btAdd = new Button();
			this.cbDiagnosEvaluation = new ComboBox();
			this.cbDiagnosEffects = new ComboBox();
			this.gbStyle = new GroupBox();
			this.rbRowModle = new RadioButton();
			this.rbLevelModle = new RadioButton();
			this.btSaveQuote = new Button();
			this.SplitContainerEx3 = new SplitContainerEx();
			this.dgvMRDiagnos = new DataGridView();
			this.DiagnosRowID = new DataGridViewTextBoxColumn();
			this.DiagnosID = new DataGridViewTextBoxColumn();
			this.DiagnosSubID = new DataGridViewTextBoxColumn();
			this.DiagnosTypeID = new DataGridViewTextBoxColumn();
			this.DiagnosType = new DataGridViewTextBoxColumn();
			this.DiagnosNameID = new DataGridViewTextBoxColumn();
			this.DiagnosName = new DataGridViewTextBoxColumn();
			this.DiagnosDemo = new DataGridViewTextBoxColumn();
			this.DiagnosEvaluationID = new DataGridViewTextBoxColumn();
			this.DiagnosEvaluation = new DataGridViewTextBoxColumn();
			this.ICDCode = new DataGridViewTextBoxColumn();
			this.DiagnosEffectsID = new DataGridViewTextBoxColumn();
			this.DiagnosEffects = new DataGridViewTextBoxColumn();
			this.DiagnosDele = new DataGridViewImageColumn();
			this.btDecrease = new DataGridViewImageColumn();
			this.btIncrease = new DataGridViewImageColumn();
			this.dgtbcUP = new DataGridViewImageColumn();
			this.dgtbcDown = new DataGridViewImageColumn();
			this.DiagnosLevel = new DataGridViewTextBoxColumn();
			this.DiagnosSequence = new DataGridViewTextBoxColumn();
			this.UserName = new DataGridViewTextBoxColumn();
			this.DateTime = new DataGridViewTextBoxColumn();
			this.Label2 = new Label();
			this.dgvHistory = new DataGridView();
			this.HRowId = new DataGridViewTextBoxColumn();
			this.HDesc = new DataGridViewTextBoxColumn();
			this.HDoctDesc = new DataGridViewTextBoxColumn();
			this.HMRDate = new DataGridViewTextBoxColumn();
			this.RTime = new DataGridViewTextBoxColumn();
			this.HMRDesc = new DataGridViewTextBoxColumn();
			this.HDisplay = new DataGridViewImageColumn();
			this.Label3 = new Label();
			this.tpAllType = new TabPage();
			this.ckbCheck = new CheckBox();
			this.GroupBox4 = new GroupBox();
			this.rbQRowModel = new RadioButton();
			this.rbQlevelModel = new RadioButton();
			this.btCancel = new Button();
			this.btOK = new Button();
			this.GroupBox3 = new GroupBox();
			this.dgvDiagnosList = new DataGridView();
			this.QCselect = new DataGridViewCheckBoxColumn();
			this.QCRowID = new DataGridViewTextBoxColumn();
			this.QCMRADMRowId = new DataGridViewTextBoxColumn();
			this.QCsubID = new DataGridViewTextBoxColumn();
			this.QCDiagnosTypeID = new DataGridViewTextBoxColumn();
			this.QCDiagnosType = new DataGridViewTextBoxColumn();
			this.QCICD = new DataGridViewTextBoxColumn();
			this.QCICDDesc = new DataGridViewTextBoxColumn();
			this.QCDemo = new DataGridViewTextBoxColumn();
			this.QCEvaluation = new DataGridViewTextBoxColumn();
			this.QCEvalDesc = new DataGridViewTextBoxColumn();
			this.QCICDCode = new DataGridViewTextBoxColumn();
			this.QCEffects = new DataGridViewTextBoxColumn();
			this.QCEffDesc = new DataGridViewTextBoxColumn();
			this.QCLevel = new DataGridViewTextBoxColumn();
			this.QCSquence = new DataGridViewTextBoxColumn();
			this.CQUserName = new DataGridViewTextBoxColumn();
			this.QCDateTime = new DataGridViewTextBoxColumn();
			this.GroupBox2 = new GroupBox();
			this.lbDiagnosType = new ListBox();
			this.tpWebEpdReport = new TabPage();
			this.webBrowserMedEpdReport = new BrowserMedEpdReport();
			this.ToolTips = new ToolTip(this.components);
			this.tpEpsoidList.SuspendLayout();
			((ISupportInitialize)this.dgBOLISData).BeginInit();
			this.tcCheckReport.SuspendLayout();
			this.tpQuoted.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.gbStyle.SuspendLayout();
			this.SplitContainerEx3.Panel1.SuspendLayout();
			this.SplitContainerEx3.Panel2.SuspendLayout();
			this.SplitContainerEx3.SuspendLayout();
			((ISupportInitialize)this.dgvMRDiagnos).BeginInit();
			((ISupportInitialize)this.dgvHistory).BeginInit();
			this.tpAllType.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((ISupportInitialize)this.dgvDiagnosList).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.tpWebEpdReport.SuspendLayout();
			this.SuspendLayout();
			this.tpEpsoidList.BackColor = Color.FromArgb(200, 210, 255);
			this.tpEpsoidList.BorderStyle = BorderStyle.FixedSingle;
			this.tpEpsoidList.Controls.Add(this.dgBOLISData);
			TabPage arg_52C_0 = this.tpEpsoidList;
			Point location = new Point(4, 21);
			arg_52C_0.Location = location;
			this.tpEpsoidList.Name = "tpEpsoidList";
			Control arg_551_0 = this.tpEpsoidList;
			Padding padding = new Padding(3);
			arg_551_0.Padding = padding;
			Control arg_56F_0 = this.tpEpsoidList;
			Size size = new Size(919, 641);
			arg_56F_0.Size = size;
			this.tpEpsoidList.TabIndex = 1;
			this.tpEpsoidList.Text = "就诊列表";
			this.tpEpsoidList.UseVisualStyleBackColor = true;
			this.dgBOLISData.AllowUserToAddRows = false;
			this.dgBOLISData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgBOLISData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBOLISData.Dock = DockStyle.Fill;
			Control arg_5DE_0 = this.dgBOLISData;
			location = new Point(3, 3);
			arg_5DE_0.Location = location;
			this.dgBOLISData.Name = "dgBOLISData";
			this.dgBOLISData.ReadOnly = true;
			this.dgBOLISData.RowTemplate.Height = 23;
			this.dgBOLISData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Control arg_636_0 = this.dgBOLISData;
			size = new Size(911, 633);
			arg_636_0.Size = size;
			this.dgBOLISData.TabIndex = 4;
			this.tcCheckReport.Controls.Add(this.tpQuoted);
			this.tcCheckReport.Controls.Add(this.tpAllType);
			this.tcCheckReport.Controls.Add(this.tpEpsoidList);
			this.tcCheckReport.Controls.Add(this.tpWebEpdReport);
			this.tcCheckReport.Dock = DockStyle.Fill;
			Control arg_6BC_0 = this.tcCheckReport;
			location = new Point(0, 0);
			arg_6BC_0.Location = location;
			this.tcCheckReport.Name = "tcCheckReport";
			this.tcCheckReport.SelectedIndex = 0;
			Control arg_6F6_0 = this.tcCheckReport;
			size = new Size(927, 666);
			arg_6F6_0.Size = size;
			this.tcCheckReport.TabIndex = 32;
			this.tpQuoted.BackColor = Color.FromArgb(200, 210, 255);
			this.tpQuoted.BorderStyle = BorderStyle.FixedSingle;
			this.tpQuoted.Controls.Add(this.Panel2);
			this.tpQuoted.Controls.Add(this.SplitContainerEx3);
			this.tpQuoted.ForeColor = SystemColors.ControlText;
			TabPage arg_781_0 = this.tpQuoted;
			location = new Point(4, 21);
			arg_781_0.Location = location;
			this.tpQuoted.Name = "tpQuoted";
			Control arg_7AF_0 = this.tpQuoted;
			size = new Size(919, 641);
			arg_7AF_0.Size = size;
			this.tpQuoted.TabIndex = 2;
			this.tpQuoted.Text = "诊断管理";
			this.tpQuoted.UseVisualStyleBackColor = true;
			this.Panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.lbICDS);
			this.Panel2.Controls.Add(this.tctrolTapModle);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.GroupBox1);
			this.Panel2.Controls.Add(this.gbStyle);
			this.Panel2.Controls.Add(this.btSaveQuote);
			Control arg_88E_0 = this.Panel2;
			location = new Point(0, 349);
			arg_88E_0.Location = location;
			this.Panel2.Name = "Panel2";
			Control arg_8BC_0 = this.Panel2;
			size = new Size(919, 295);
			arg_8BC_0.Size = size;
			this.Panel2.TabIndex = 10;
			this.lbICDS.BackColor = Color.WhiteSmoke;
			this.lbICDS.BorderStyle = BorderStyle.FixedSingle;
			this.lbICDS.FormattingEnabled = true;
			this.lbICDS.ItemHeight = 12;
			Control arg_916_0 = this.lbICDS;
			location = new Point(10, 40);
			arg_916_0.Location = location;
			this.lbICDS.Name = "lbICDS";
			Control arg_941_0 = this.lbICDS;
			size = new Size(199, 86);
			arg_941_0.Size = size;
			this.lbICDS.TabIndex = 57;
			this.lbICDS.Visible = false;
			this.tctrolTapModle.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_97E_0 = this.tctrolTapModle;
			location = new Point(3, 66);
			arg_97E_0.Location = location;
			Control arg_993_0 = this.tctrolTapModle;
			padding = new Padding(0);
			arg_993_0.Margin = padding;
			this.tctrolTapModle.Name = "tctrolTapModle";
			this.tctrolTapModle.SelectedIndex = 0;
			Control arg_9CD_0 = this.tctrolTapModle;
			size = new Size(917, 225);
			arg_9CD_0.Size = size;
			this.tctrolTapModle.TabIndex = 56;
			this.Label1.AutoSize = true;
			this.Label1.Font = new Font("宋体", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_A1E_0 = this.Label1;
			location = new Point(8, 51);
			arg_A1E_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_A46_0 = this.Label1;
			size = new Size(63, 13);
			arg_A46_0.Size = size;
			this.Label1.TabIndex = 58;
			this.Label1.Text = "诊断模板";
			this.GroupBox1.Controls.Add(this.tbICD);
			this.GroupBox1.Controls.Add(this.btAdd);
			this.GroupBox1.Controls.Add(this.cbDiagnosEvaluation);
			this.GroupBox1.Controls.Add(this.cbDiagnosEffects);
			Control arg_AD1_0 = this.GroupBox1;
			location = new Point(4, 6);
			arg_AD1_0.Location = location;
			Control arg_AE6_0 = this.GroupBox1;
			padding = new Padding(0);
			arg_AE6_0.Margin = padding;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_B0B_0 = this.GroupBox1;
			padding = new Padding(0);
			arg_B0B_0.Padding = padding;
			Control arg_B26_0 = this.GroupBox1;
			size = new Size(413, 40);
			arg_B26_0.Size = size;
			this.GroupBox1.TabIndex = 52;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "诊断操作";
			Control arg_B66_0 = this.tbICD;
			location = new Point(6, 13);
			arg_B66_0.Location = location;
			this.tbICD.Name = "tbICD";
			Control arg_B91_0 = this.tbICD;
			size = new Size(199, 21);
			arg_B91_0.Size = size;
			this.tbICD.TabIndex = 54;
			this.btAdd.BackColor = Color.FromArgb(9, 101, 156);
			this.btAdd.FlatStyle = FlatStyle.Flat;
			this.btAdd.ForeColor = SystemColors.ControlLightLight;
			Control arg_BEE_0 = this.btAdd;
			location = new Point(350, 11);
			arg_BEE_0.Location = location;
			this.btAdd.Name = "btAdd";
			Control arg_C16_0 = this.btAdd;
			size = new Size(55, 25);
			arg_C16_0.Size = size;
			this.btAdd.TabIndex = 52;
			this.btAdd.Text = "添加";
			this.btAdd.UseVisualStyleBackColor = false;
			this.cbDiagnosEvaluation.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbDiagnosEvaluation.FormattingEnabled = true;
			Control arg_C72_0 = this.cbDiagnosEvaluation;
			location = new Point(209, 14);
			arg_C72_0.Location = location;
			this.cbDiagnosEvaluation.Name = "cbDiagnosEvaluation";
			Control arg_C9A_0 = this.cbDiagnosEvaluation;
			size = new Size(68, 20);
			arg_C9A_0.Size = size;
			this.cbDiagnosEvaluation.TabIndex = 50;
			this.ToolTips.SetToolTip(this.cbDiagnosEvaluation, "状态属性");
			this.cbDiagnosEffects.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbDiagnosEffects.FormattingEnabled = true;
			Control arg_CF0_0 = this.cbDiagnosEffects;
			location = new Point(281, 14);
			arg_CF0_0.Location = location;
			this.cbDiagnosEffects.Name = "cbDiagnosEffects";
			Control arg_D18_0 = this.cbDiagnosEffects;
			size = new Size(65, 20);
			arg_D18_0.Size = size;
			this.cbDiagnosEffects.TabIndex = 51;
			this.ToolTips.SetToolTip(this.cbDiagnosEffects, "转归属性");
			this.gbStyle.Controls.Add(this.rbRowModle);
			this.gbStyle.Controls.Add(this.rbLevelModle);
			Control arg_D81_0 = this.gbStyle;
			location = new Point(425, 6);
			arg_D81_0.Location = location;
			Control arg_D96_0 = this.gbStyle;
			padding = new Padding(0);
			arg_D96_0.Margin = padding;
			this.gbStyle.Name = "gbStyle";
			Control arg_DBB_0 = this.gbStyle;
			padding = new Padding(0);
			arg_DBB_0.Padding = padding;
			Control arg_DD6_0 = this.gbStyle;
			size = new Size(149, 40);
			arg_DD6_0.Size = size;
			this.gbStyle.TabIndex = 51;
			this.gbStyle.TabStop = false;
			this.gbStyle.Text = "引用格式";
			this.rbRowModle.AutoSize = true;
			Control arg_E23_0 = this.rbRowModle;
			location = new Point(83, 16);
			arg_E23_0.Location = location;
			this.rbRowModle.Name = "rbRowModle";
			Control arg_E4B_0 = this.rbRowModle;
			size = new Size(59, 16);
			arg_E4B_0.Size = size;
			this.rbRowModle.TabIndex = 54;
			this.rbRowModle.TabStop = true;
			this.rbRowModle.Text = "行模式";
			this.rbRowModle.UseVisualStyleBackColor = true;
			this.rbLevelModle.AutoSize = true;
			Control arg_EA3_0 = this.rbLevelModle;
			location = new Point(7, 16);
			arg_EA3_0.Location = location;
			this.rbLevelModle.Name = "rbLevelModle";
			Control arg_ECB_0 = this.rbLevelModle;
			size = new Size(71, 16);
			arg_ECB_0.Size = size;
			this.rbLevelModle.TabIndex = 53;
			this.rbLevelModle.TabStop = true;
			this.rbLevelModle.Text = "层级模式";
			this.rbLevelModle.UseVisualStyleBackColor = true;
			this.btSaveQuote.BackColor = Color.FromArgb(9, 101, 156);
			this.btSaveQuote.DialogResult = DialogResult.OK;
			this.btSaveQuote.FlatStyle = FlatStyle.Flat;
			this.btSaveQuote.ForeColor = SystemColors.ControlLightLight;
			Control arg_F5C_0 = this.btSaveQuote;
			location = new Point(577, 16);
			arg_F5C_0.Location = location;
			this.btSaveQuote.Name = "btSaveQuote";
			Control arg_F84_0 = this.btSaveQuote;
			size = new Size(90, 25);
			arg_F84_0.Size = size;
			this.btSaveQuote.TabIndex = 55;
			this.btSaveQuote.Text = "保存上述诊断";
			this.ToolTips.SetToolTip(this.btSaveQuote, "保存级别及顺序");
			this.btSaveQuote.UseVisualStyleBackColor = false;
			this.SplitContainerEx3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.SplitContainerEx3.BackColor = Color.FromArgb(200, 210, 255);
			this.SplitContainerEx3.CollpasePanel = SplitContainerEx.SplitterPanelEnum.Panel2;
			this.SplitContainerEx3.Cursor = Cursors.Default;
			Control arg_1021_0 = this.SplitContainerEx3;
			location = new Point(0, -1);
			arg_1021_0.Location = location;
			Control arg_1036_0 = this.SplitContainerEx3;
			padding = new Padding(0);
			arg_1036_0.Margin = padding;
			this.SplitContainerEx3.Name = "SplitContainerEx3";
			this.SplitContainerEx3.Panel1.Controls.Add(this.dgvMRDiagnos);
			this.SplitContainerEx3.Panel1.Controls.Add(this.Label2);
			this.SplitContainerEx3.Panel1MinSize = 0;
			this.SplitContainerEx3.Panel2.Controls.Add(this.dgvHistory);
			this.SplitContainerEx3.Panel2.Controls.Add(this.Label3);
			this.SplitContainerEx3.Panel2MinSize = 0;
			Control arg_10E8_0 = this.SplitContainerEx3;
			size = new Size(919, 350);
			arg_10E8_0.Size = size;
			this.SplitContainerEx3.SplitterDistance = 678;
			this.SplitContainerEx3.SplitterWidth = 9;
			this.SplitContainerEx3.TabIndex = 0;
			this.dgvMRDiagnos.AllowUserToAddRows = false;
			this.dgvMRDiagnos.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			this.dgvMRDiagnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvMRDiagnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMRDiagnos.Columns.AddRange(new DataGridViewColumn[]
			{
				this.DiagnosRowID,
				this.DiagnosID,
				this.DiagnosSubID,
				this.DiagnosTypeID,
				this.DiagnosType,
				this.DiagnosNameID,
				this.DiagnosName,
				this.DiagnosDemo,
				this.DiagnosEvaluationID,
				this.DiagnosEvaluation,
				this.ICDCode,
				this.DiagnosEffectsID,
				this.DiagnosEffects,
				this.DiagnosDele,
				this.btDecrease,
				this.btIncrease,
				this.dgtbcUP,
				this.dgtbcDown,
				this.DiagnosLevel,
				this.DiagnosSequence,
				this.UserName,
				this.DateTime
			});
			Control arg_12AD_0 = this.dgvMRDiagnos;
			location = new Point(3, 22);
			arg_12AD_0.Location = location;
			this.dgvMRDiagnos.Name = "dgvMRDiagnos";
			this.dgvMRDiagnos.ReadOnly = true;
			this.dgvMRDiagnos.RowHeadersVisible = false;
			dataGridViewCellStyle2.Font = new Font("宋体", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.dgvMRDiagnos.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMRDiagnos.RowTemplate.Height = 23;
			this.dgvMRDiagnos.SelectionMode = DataGridViewSelectionMode.CellSelect;
			Control arg_133B_0 = this.dgvMRDiagnos;
			size = new Size(672, 327);
			arg_133B_0.Size = size;
			this.dgvMRDiagnos.TabIndex = 9;
			this.DiagnosRowID.DataPropertyName = "ARowID";
			this.DiagnosRowID.HeaderText = "RowID";
			this.DiagnosRowID.Name = "DiagnosRowID";
			this.DiagnosRowID.ReadOnly = true;
			this.DiagnosRowID.Visible = false;
			this.DiagnosID.DataPropertyName = "AMRADMRowId";
			this.DiagnosID.HeaderText = "就诊ID";
			this.DiagnosID.Name = "DiagnosID";
			this.DiagnosID.ReadOnly = true;
			this.DiagnosID.Visible = false;
			this.DiagnosSubID.DataPropertyName = "ADiaSubID";
			this.DiagnosSubID.HeaderText = "subID";
			this.DiagnosSubID.Name = "DiagnosSubID";
			this.DiagnosSubID.ReadOnly = true;
			this.DiagnosSubID.Visible = false;
			this.DiagnosTypeID.DataPropertyName = "ADiagnosTypeID";
			this.DiagnosTypeID.HeaderText = "诊断类型ID";
			this.DiagnosTypeID.Name = "DiagnosTypeID";
			this.DiagnosTypeID.ReadOnly = true;
			this.DiagnosTypeID.Visible = false;
			this.DiagnosType.DataPropertyName = "ADiagnosType";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DiagnosType.DefaultCellStyle = dataGridViewCellStyle3;
			this.DiagnosType.HeaderText = "诊断类型";
			this.DiagnosType.Name = "DiagnosType";
			this.DiagnosType.ReadOnly = true;
			this.DiagnosType.Resizable = DataGridViewTriState.True;
			this.DiagnosType.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosType.Width = 80;
			this.DiagnosNameID.DataPropertyName = "AICDID";
			this.DiagnosNameID.HeaderText = "ICDid";
			this.DiagnosNameID.Name = "DiagnosNameID";
			this.DiagnosNameID.ReadOnly = true;
			this.DiagnosNameID.Visible = false;
			this.DiagnosName.DataPropertyName = "ADiagnosName";
			this.DiagnosName.HeaderText = "ICD描述";
			this.DiagnosName.MinimumWidth = 80;
			this.DiagnosName.Name = "DiagnosName";
			this.DiagnosName.ReadOnly = true;
			this.DiagnosName.Resizable = DataGridViewTriState.True;
			this.DiagnosName.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosName.Width = 150;
			this.DiagnosDemo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.DiagnosDemo.DataPropertyName = "ADemo";
			this.DiagnosDemo.HeaderText = "诊断注释";
			this.DiagnosDemo.MinimumWidth = 59;
			this.DiagnosDemo.Name = "DiagnosDemo";
			this.DiagnosDemo.ReadOnly = true;
			this.DiagnosDemo.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosEvaluationID.DataPropertyName = "AEvaluation";
			this.DiagnosEvaluationID.HeaderText = "诊断状态ID";
			this.DiagnosEvaluationID.Name = "DiagnosEvaluationID";
			this.DiagnosEvaluationID.ReadOnly = true;
			this.DiagnosEvaluationID.Visible = false;
			this.DiagnosEvaluation.DataPropertyName = "AEvaluationDesc";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DiagnosEvaluation.DefaultCellStyle = dataGridViewCellStyle4;
			this.DiagnosEvaluation.HeaderText = "诊断状态";
			this.DiagnosEvaluation.Name = "DiagnosEvaluation";
			this.DiagnosEvaluation.ReadOnly = true;
			this.DiagnosEvaluation.Resizable = DataGridViewTriState.True;
			this.DiagnosEvaluation.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosEvaluation.Width = 59;
			this.ICDCode.DataPropertyName = "AICDCode";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.ICDCode.DefaultCellStyle = dataGridViewCellStyle5;
			this.ICDCode.HeaderText = "ICD代码";
			this.ICDCode.Name = "ICDCode";
			this.ICDCode.ReadOnly = true;
			this.ICDCode.Width = 58;
			this.DiagnosEffectsID.DataPropertyName = "AEffects";
			this.DiagnosEffectsID.HeaderText = "转归属性ID";
			this.DiagnosEffectsID.Name = "DiagnosEffectsID";
			this.DiagnosEffectsID.ReadOnly = true;
			this.DiagnosEffectsID.Visible = false;
			this.DiagnosEffects.DataPropertyName = "AEffectsDesc";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DiagnosEffects.DefaultCellStyle = dataGridViewCellStyle6;
			this.DiagnosEffects.HeaderText = "转归属性";
			this.DiagnosEffects.Name = "DiagnosEffects";
			this.DiagnosEffects.ReadOnly = true;
			this.DiagnosEffects.Resizable = DataGridViewTriState.True;
			this.DiagnosEffects.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosEffects.Width = 59;
			this.DiagnosDele.HeaderText = "删除";
			this.DiagnosDele.Image = (Image)componentResourceManager.GetObject("DiagnosDele.Image");
			this.DiagnosDele.Name = "DiagnosDele";
			this.DiagnosDele.ReadOnly = true;
			this.DiagnosDele.Resizable = DataGridViewTriState.True;
			this.DiagnosDele.Width = 35;
			this.btDecrease.HeaderText = "降级";
			this.btDecrease.Image = (Image)componentResourceManager.GetObject("btDecrease.Image");
			this.btDecrease.Name = "btDecrease";
			this.btDecrease.ReadOnly = true;
			this.btDecrease.Resizable = DataGridViewTriState.True;
			this.btDecrease.ToolTipText = "减小级别";
			this.btDecrease.Width = 35;
			this.btIncrease.HeaderText = "升级";
			this.btIncrease.Image = (Image)componentResourceManager.GetObject("btIncrease.Image");
			this.btIncrease.Name = "btIncrease";
			this.btIncrease.ReadOnly = true;
			this.btIncrease.Resizable = DataGridViewTriState.True;
			this.btIncrease.ToolTipText = "增加级别";
			this.btIncrease.Width = 35;
			this.dgtbcUP.HeaderText = "上移";
			this.dgtbcUP.Image = (Image)componentResourceManager.GetObject("dgtbcUP.Image");
			this.dgtbcUP.Name = "dgtbcUP";
			this.dgtbcUP.ReadOnly = true;
			this.dgtbcUP.Resizable = DataGridViewTriState.True;
			this.dgtbcUP.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dgtbcUP.Width = 35;
			this.dgtbcDown.HeaderText = "下移";
			this.dgtbcDown.Image = (Image)componentResourceManager.GetObject("dgtbcDown.Image");
			this.dgtbcDown.Name = "dgtbcDown";
			this.dgtbcDown.ReadOnly = true;
			this.dgtbcDown.Width = 35;
			this.DiagnosLevel.DataPropertyName = "ALevel";
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DiagnosLevel.DefaultCellStyle = dataGridViewCellStyle7;
			this.DiagnosLevel.HeaderText = "级别";
			this.DiagnosLevel.Name = "DiagnosLevel";
			this.DiagnosLevel.ReadOnly = true;
			this.DiagnosLevel.Resizable = DataGridViewTriState.True;
			this.DiagnosLevel.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosLevel.Width = 35;
			this.DiagnosSequence.DataPropertyName = "ASquence";
			this.DiagnosSequence.HeaderText = "顺序";
			this.DiagnosSequence.Name = "DiagnosSequence";
			this.DiagnosSequence.ReadOnly = true;
			this.DiagnosSequence.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DiagnosSequence.Visible = false;
			this.UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.UserName.DataPropertyName = "AUserName";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.UserName.DefaultCellStyle = dataGridViewCellStyle8;
			this.UserName.HeaderText = "医生";
			this.UserName.MinimumWidth = 50;
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.DateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.DateTime.DataPropertyName = "ADateTime";
			this.DateTime.HeaderText = "日期";
			this.DateTime.MinimumWidth = 80;
			this.DateTime.Name = "DateTime";
			this.DateTime.ReadOnly = true;
			this.DateTime.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.Label2.AutoSize = true;
			this.Label2.Font = new Font("宋体", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_1BC4_0 = this.Label2;
			location = new Point(4, 5);
			arg_1BC4_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_1BEC_0 = this.Label2;
			size = new Size(63, 13);
			arg_1BEC_0.Size = size;
			this.Label2.TabIndex = 8;
			this.Label2.Text = "诊断维护";
			this.dgvHistory.AllowUserToAddRows = false;
			this.dgvHistory.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistory.Columns.AddRange(new DataGridViewColumn[]
			{
				this.HRowId,
				this.HDesc,
				this.HDoctDesc,
				this.HMRDate,
				this.RTime,
				this.HMRDesc,
				this.HDisplay
			});
			Control arg_1D07_0 = this.dgvHistory;
			location = new Point(3, 22);
			arg_1D07_0.Location = location;
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.ReadOnly = true;
			this.dgvHistory.RowHeadersVisible = false;
			this.dgvHistory.RowTemplate.Height = 23;
			Control arg_1D5F_0 = this.dgvHistory;
			size = new Size(226, 326);
			arg_1D5F_0.Size = size;
			this.dgvHistory.TabIndex = 7;
			this.HRowId.DataPropertyName = "Rowid";
			this.HRowId.HeaderText = "RowID";
			this.HRowId.Name = "HRowId";
			this.HRowId.ReadOnly = true;
			this.HRowId.Visible = false;
			this.HDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.HDesc.DataPropertyName = "Desc";
			this.HDesc.HeaderText = "ICD描述";
			this.HDesc.Name = "HDesc";
			this.HDesc.ReadOnly = true;
			this.HDoctDesc.DataPropertyName = "DoctDesc";
			this.HDoctDesc.HeaderText = "医生";
			this.HDoctDesc.Name = "HDoctDesc";
			this.HDoctDesc.ReadOnly = true;
			this.HDoctDesc.Width = 40;
			this.HMRDate.DataPropertyName = "MRDate";
			this.HMRDate.HeaderText = "日期";
			this.HMRDate.Name = "HMRDate";
			this.HMRDate.ReadOnly = true;
			this.HMRDate.Width = 50;
			this.RTime.DataPropertyName = "MRtime";
			this.RTime.HeaderText = "时间";
			this.RTime.Name = "RTime";
			this.RTime.ReadOnly = true;
			this.RTime.Visible = false;
			this.RTime.Width = 60;
			this.HMRDesc.DataPropertyName = "MRDesc";
			this.HMRDesc.HeaderText = "描述";
			this.HMRDesc.Name = "HMRDesc";
			this.HMRDesc.ReadOnly = true;
			this.HMRDesc.Visible = false;
			this.HMRDesc.Width = 60;
			this.HDisplay.FillWeight = 59f;
			this.HDisplay.HeaderText = "重复记录";
			this.HDisplay.Image = (Image)componentResourceManager.GetObject("HDisplay.Image");
			this.HDisplay.Name = "HDisplay";
			this.HDisplay.ReadOnly = true;
			this.HDisplay.Width = 59;
			this.Label3.AutoSize = true;
			this.Label3.Font = new Font("宋体", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			Control arg_1FE0_0 = this.Label3;
			location = new Point(5, 5);
			arg_1FE0_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_2008_0 = this.Label3;
			size = new Size(63, 13);
			arg_2008_0.Size = size;
			this.Label3.TabIndex = 9;
			this.Label3.Text = "历史诊断";
			this.tpAllType.BackColor = SystemColors.InactiveCaptionText;
			this.tpAllType.Controls.Add(this.ckbCheck);
			this.tpAllType.Controls.Add(this.GroupBox4);
			this.tpAllType.Controls.Add(this.btCancel);
			this.tpAllType.Controls.Add(this.btOK);
			this.tpAllType.Controls.Add(this.GroupBox3);
			this.tpAllType.Controls.Add(this.GroupBox2);
			TabPage arg_20D0_0 = this.tpAllType;
			location = new Point(4, 21);
			arg_20D0_0.Location = location;
			this.tpAllType.Name = "tpAllType";
			Control arg_20F8_0 = this.tpAllType;
			padding = new Padding(0, 5, 0, 0);
			arg_20F8_0.Padding = padding;
			Control arg_2116_0 = this.tpAllType;
			size = new Size(919, 641);
			arg_2116_0.Size = size;
			this.tpAllType.TabIndex = 4;
			this.tpAllType.Text = "按类型引用";
			this.ckbCheck.AutoSize = true;
			Control arg_215C_0 = this.ckbCheck;
			location = new Point(816, 603);
			arg_215C_0.Location = location;
			this.ckbCheck.Name = "ckbCheck";
			Control arg_2184_0 = this.ckbCheck;
			size = new Size(48, 16);
			arg_2184_0.Size = size;
			this.ckbCheck.TabIndex = 53;
			this.ckbCheck.Text = "全选";
			this.ckbCheck.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.rbQRowModel);
			this.GroupBox4.Controls.Add(this.rbQlevelModel);
			Control arg_21F7_0 = this.GroupBox4;
			location = new Point(220, 590);
			arg_21F7_0.Location = location;
			Control arg_220C_0 = this.GroupBox4;
			padding = new Padding(0);
			arg_220C_0.Margin = padding;
			this.GroupBox4.Name = "GroupBox4";
			Control arg_2231_0 = this.GroupBox4;
			padding = new Padding(0);
			arg_2231_0.Padding = padding;
			Control arg_224C_0 = this.GroupBox4;
			size = new Size(182, 40);
			arg_224C_0.Size = size;
			this.GroupBox4.TabIndex = 52;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "引用格式";
			this.rbQRowModel.AutoSize = true;
			Control arg_2299_0 = this.rbQRowModel;
			location = new Point(102, 16);
			arg_2299_0.Location = location;
			this.rbQRowModel.Name = "rbQRowModel";
			Control arg_22C1_0 = this.rbQRowModel;
			size = new Size(59, 16);
			arg_22C1_0.Size = size;
			this.rbQRowModel.TabIndex = 54;
			this.rbQRowModel.TabStop = true;
			this.rbQRowModel.Text = "行模式";
			this.rbQRowModel.UseVisualStyleBackColor = true;
			this.rbQlevelModel.AutoSize = true;
			Control arg_231A_0 = this.rbQlevelModel;
			location = new Point(9, 16);
			arg_231A_0.Location = location;
			this.rbQlevelModel.Name = "rbQlevelModel";
			Control arg_2342_0 = this.rbQlevelModel;
			size = new Size(71, 16);
			arg_2342_0.Size = size;
			this.rbQlevelModel.TabIndex = 53;
			this.rbQlevelModel.TabStop = true;
			this.rbQlevelModel.Text = "层级模式";
			this.rbQlevelModel.UseVisualStyleBackColor = true;
			this.btCancel.BackColor = Color.FromArgb(9, 101, 156);
			this.btCancel.FlatStyle = FlatStyle.Flat;
			this.btCancel.ForeColor = Color.White;
			Control arg_23CA_0 = this.btCancel;
			location = new Point(551, 599);
			arg_23CA_0.Location = location;
			this.btCancel.Name = "btCancel";
			Control arg_23F2_0 = this.btCancel;
			size = new Size(75, 23);
			arg_23F2_0.Size = size;
			this.btCancel.TabIndex = 5;
			this.btCancel.Text = "取消";
			this.btCancel.UseVisualStyleBackColor = false;
			this.btOK.BackColor = Color.FromArgb(9, 101, 156);
			this.btOK.DialogResult = DialogResult.OK;
			this.btOK.FlatStyle = FlatStyle.Flat;
			this.btOK.ForeColor = Color.White;
			Control arg_2479_0 = this.btOK;
			location = new Point(452, 599);
			arg_2479_0.Location = location;
			this.btOK.Name = "btOK";
			Control arg_24A1_0 = this.btOK;
			size = new Size(75, 23);
			arg_24A1_0.Size = size;
			this.btOK.TabIndex = 4;
			this.btOK.Text = "引用";
			this.btOK.UseVisualStyleBackColor = false;
			this.GroupBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.GroupBox3.Controls.Add(this.dgvDiagnosList);
			this.GroupBox3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2527_0 = this.GroupBox3;
			location = new Point(217, 5);
			arg_2527_0.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			Control arg_2555_0 = this.GroupBox3;
			size = new Size(699, 578);
			arg_2555_0.Size = size;
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "诊断列表";
			this.dgvDiagnosList.AllowUserToAddRows = false;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = SystemColors.Control;
			dataGridViewCellStyle10.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			this.dgvDiagnosList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvDiagnosList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDiagnosList.Columns.AddRange(new DataGridViewColumn[]
			{
				this.QCselect,
				this.QCRowID,
				this.QCMRADMRowId,
				this.QCsubID,
				this.QCDiagnosTypeID,
				this.QCDiagnosType,
				this.QCICD,
				this.QCICDDesc,
				this.QCDemo,
				this.QCEvaluation,
				this.QCEvalDesc,
				this.QCICDCode,
				this.QCEffects,
				this.QCEffDesc,
				this.QCLevel,
				this.QCSquence,
				this.CQUserName,
				this.QCDateTime
			});
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = SystemColors.Window;
			dataGridViewCellStyle11.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
			this.dgvDiagnosList.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvDiagnosList.Dock = DockStyle.Fill;
			Control arg_274F_0 = this.dgvDiagnosList;
			location = new Point(3, 17);
			arg_274F_0.Location = location;
			this.dgvDiagnosList.Name = "dgvDiagnosList";
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = SystemColors.Control;
			dataGridViewCellStyle12.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
			this.dgvDiagnosList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvDiagnosList.RowHeadersVisible = false;
			this.dgvDiagnosList.RowTemplate.Height = 23;
			Control arg_27FE_0 = this.dgvDiagnosList;
			size = new Size(693, 558);
			arg_27FE_0.Size = size;
			this.dgvDiagnosList.TabIndex = 1;
			this.QCselect.HeaderText = "选择";
			this.QCselect.Name = "QCselect";
			this.QCselect.Resizable = DataGridViewTriState.True;
			this.QCselect.SortMode = DataGridViewColumnSortMode.Automatic;
			this.QCselect.Width = 36;
			this.QCRowID.DataPropertyName = "ARowID";
			this.QCRowID.HeaderText = "QRowID";
			this.QCRowID.Name = "QCRowID";
			this.QCRowID.Visible = false;
			this.QCMRADMRowId.DataPropertyName = "AMRADMRowId";
			this.QCMRADMRowId.HeaderText = "QADMRowID";
			this.QCMRADMRowId.Name = "QCMRADMRowId";
			this.QCMRADMRowId.Visible = false;
			this.QCsubID.DataPropertyName = "ADiaSubID";
			this.QCsubID.HeaderText = "QsubID";
			this.QCsubID.Name = "QCsubID";
			this.QCsubID.Visible = false;
			this.QCDiagnosTypeID.DataPropertyName = "ADiagnosTypeID";
			this.QCDiagnosTypeID.HeaderText = "QTypeID";
			this.QCDiagnosTypeID.Name = "QCDiagnosTypeID";
			this.QCDiagnosTypeID.Visible = false;
			this.QCDiagnosType.DataPropertyName = "ADiagnosType";
			this.QCDiagnosType.HeaderText = "诊断类型";
			this.QCDiagnosType.Name = "QCDiagnosType";
			this.QCDiagnosType.Visible = false;
			this.QCICD.DataPropertyName = "AICDID";
			this.QCICD.HeaderText = "ICD代码";
			this.QCICD.Name = "QCICD";
			this.QCICD.Visible = false;
			this.QCICDDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.QCICDDesc.DataPropertyName = "ADiagnosName";
			this.QCICDDesc.HeaderText = "ICD描述";
			this.QCICDDesc.Name = "QCICDDesc";
			this.QCDemo.DataPropertyName = "ADemo";
			this.QCDemo.HeaderText = "备注";
			this.QCDemo.Name = "QCDemo";
			this.QCDemo.Width = 50;
			this.QCEvaluation.DataPropertyName = "AEvaluation";
			this.QCEvaluation.HeaderText = "状态属性ID";
			this.QCEvaluation.Name = "QCEvaluation";
			this.QCEvaluation.Visible = false;
			this.QCEvalDesc.DataPropertyName = "AEvaluationDesc";
			this.QCEvalDesc.HeaderText = "状态属性";
			this.QCEvalDesc.Name = "QCEvalDesc";
			this.QCEvalDesc.Width = 60;
			this.QCICDCode.DataPropertyName = "AICDCode";
			this.QCICDCode.HeaderText = "ICD代码";
			this.QCICDCode.Name = "QCICDCode";
			this.QCEffects.DataPropertyName = "AEffects";
			this.QCEffects.HeaderText = "转归属性ID";
			this.QCEffects.Name = "QCEffects";
			this.QCEffects.Visible = false;
			this.QCEffDesc.DataPropertyName = "AEffectsDesc";
			this.QCEffDesc.HeaderText = "转归属性";
			this.QCEffDesc.Name = "QCEffDesc";
			this.QCEffDesc.Width = 60;
			this.QCLevel.DataPropertyName = "ALevel";
			this.QCLevel.HeaderText = "级别";
			this.QCLevel.Name = "QCLevel";
			this.QCLevel.Width = 40;
			this.QCSquence.DataPropertyName = "ASquence";
			this.QCSquence.HeaderText = "顺序";
			this.QCSquence.Name = "QCSquence";
			this.QCSquence.Visible = false;
			this.CQUserName.DataPropertyName = "AUserName";
			this.CQUserName.HeaderText = "医生";
			this.CQUserName.Name = "CQUserName";
			this.CQUserName.Width = 80;
			this.QCDateTime.DataPropertyName = "ADateTime";
			this.QCDateTime.HeaderText = "日期";
			this.QCDateTime.Name = "QCDateTime";
			this.QCDateTime.Width = 80;
			this.GroupBox2.Controls.Add(this.lbDiagnosType);
			this.GroupBox2.Dock = DockStyle.Left;
			this.GroupBox2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2C9F_0 = this.GroupBox2;
			location = new Point(0, 5);
			arg_2C9F_0.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			Control arg_2CC7_0 = this.GroupBox2;
			padding = new Padding(3, 3, 3, 0);
			arg_2CC7_0.Padding = padding;
			Control arg_2CE5_0 = this.GroupBox2;
			size = new Size(214, 636);
			arg_2CE5_0.Size = size;
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "诊断类型";
			this.lbDiagnosType.Dock = DockStyle.Fill;
			this.lbDiagnosType.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.lbDiagnosType.FormattingEnabled = true;
			this.lbDiagnosType.ItemHeight = 12;
			Control arg_2D6A_0 = this.lbDiagnosType;
			location = new Point(3, 17);
			arg_2D6A_0.Location = location;
			this.lbDiagnosType.Name = "lbDiagnosType";
			Control arg_2D98_0 = this.lbDiagnosType;
			size = new Size(208, 616);
			arg_2D98_0.Size = size;
			this.lbDiagnosType.TabIndex = 1;
			this.tpWebEpdReport.BackColor = Color.FromArgb(200, 210, 255);
			this.tpWebEpdReport.BorderStyle = BorderStyle.FixedSingle;
			this.tpWebEpdReport.Controls.Add(this.webBrowserMedEpdReport);
			TabPage arg_2DFC_0 = this.tpWebEpdReport;
			location = new Point(4, 21);
			arg_2DFC_0.Location = location;
			this.tpWebEpdReport.Name = "tpWebEpdReport";
			Control arg_2E21_0 = this.tpWebEpdReport;
			padding = new Padding(3);
			arg_2E21_0.Padding = padding;
			Control arg_2E3F_0 = this.tpWebEpdReport;
			size = new Size(919, 641);
			arg_2E3F_0.Size = size;
			this.tpWebEpdReport.TabIndex = 3;
			this.tpWebEpdReport.Text = "传染病上报";
			this.tpWebEpdReport.UseVisualStyleBackColor = true;
			this.webBrowserMedEpdReport.Dock = DockStyle.Fill;
			Control arg_2E89_0 = this.webBrowserMedEpdReport;
			location = new Point(3, 3);
			arg_2E89_0.Location = location;
			Control arg_2EA1_0 = this.webBrowserMedEpdReport;
			size = new Size(20, 20);
			arg_2EA1_0.MinimumSize = size;
			this.webBrowserMedEpdReport.Name = "webBrowserMedEpdReport";
			Control arg_2ECF_0 = this.webBrowserMedEpdReport;
			size = new Size(911, 633);
			arg_2ECF_0.Size = size;
			this.webBrowserMedEpdReport.TabIndex = 0;
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(200, 210, 255);
			size = new Size(927, 666);
			this.ClientSize = size;
			this.Controls.Add(this.tcCheckReport);
			this.Name = "DiagnosDicForm";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "诊断信息引用";
			this.tpEpsoidList.ResumeLayout(false);
			((ISupportInitialize)this.dgBOLISData).EndInit();
			this.tcCheckReport.ResumeLayout(false);
			this.tpQuoted.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.gbStyle.ResumeLayout(false);
			this.gbStyle.PerformLayout();
			this.SplitContainerEx3.Panel1.ResumeLayout(false);
			this.SplitContainerEx3.Panel1.PerformLayout();
			this.SplitContainerEx3.Panel2.ResumeLayout(false);
			this.SplitContainerEx3.Panel2.PerformLayout();
			this.SplitContainerEx3.ResumeLayout(false);
			((ISupportInitialize)this.dgvMRDiagnos).EndInit();
			((ISupportInitialize)this.dgvHistory).EndInit();
			this.tpAllType.ResumeLayout(false);
			this.tpAllType.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			((ISupportInitialize)this.dgvDiagnosList).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.tpWebEpdReport.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void DiagnosDicForm_Load(object sender, EventArgs e)
		{
			this.m_EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			this.m_UserID = GlobalValues.GetValueByKey("UserID");
			this.m_PatientID = GlobalValues.GetValueByKey("PatientID");
			this.m_BindMIDictionary.StdDicCode = SysOptionManager.GetSysOptionValue("DiagnosDicCode", "S12");
			this.m_EpsoideList = new CommonQuoteClass();
			this.InitButtionList();
			this.InitDic();
			this.QueryEpisodeList();
			this.LoadDiagnos();
			this.LoadModal();
			this.LoadHistoryData();
		}

		private void InitButtionList()
		{
			this.m_ButtionList.Add("DiagnosDele");
			this.m_ButtionList.Add("btDecrease");
			this.m_ButtionList.Add("btIncrease");
			this.m_ButtionList.Add("dgtbcUP");
			this.m_ButtionList.Add("dgtbcDown");
		}

		private void LoadDiagnos()
		{
			this.InitDiagnosData();
			this.StyleScheme = SysOptionManager.GetSysOptionValue("DiagnosStyleScheme", "行模式#,^;^&^*^$|层级模式#\\r\\n^\\r\\n^\\r\\n^\\r\\n^\\r\\n");
			string[] array = this.StyleScheme.Split(new char[]
			{
				'#'
			});
			string left = array[0];
			if (Operators.CompareString(left, "行模式", false) == 0)
			{
				this.rbRowModle.Checked = true;
				this.rbQRowModel.Checked = true;
			}
			else if (Operators.CompareString(left, "层级模式", false) == 0)
			{
				this.rbLevelModle.Checked = true;
				this.rbQlevelModel.Checked = true;
			}
		}

		private void LoadDiagnosAllData()
		{
			this.m_MRDiagnos = WebServiceLayer.MRDiagnosDataAccess.GetMRDiagnosDataset(this.m_EpisodeID, "");
			if (this.m_MRDiagnos != null && this.m_MRDiagnos.Tables.Count > 0)
			{
				this.m_CurrentTable = (EMRDiagnosDataSet.GetMRDiagnosListDataTable)this.GetTalbe(this.m_MRDiagnos.Tables[0], this.m_DiagnosTypeID);
				this.dgvMRDiagnos.DataSource = this.m_CurrentTable;
				this.dgvMRDiagnos.ClearSelection();
			}
		}

		public DataTable GetTalbe(DataTable dt, string type)
		{
			DataTable dataTable = dt.Clone();
			DataRow[] array = dt.Select("ADiagnosTypeID = '" + type + "'", "ASquence");
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow row = array2[i];
					dataTable.ImportRow(row);
				}
				return dataTable;
			}
		}

		private void InitDiagnosData()
		{
			if (Operators.CompareString(this.m_EpisodeID, string.Empty, false) != 0)
			{
				this.LoadDiagnosAllData();
				if ((this.m_CurrentTable == null || this.m_CurrentTable.Rows.Count <= 0) && Operators.CompareString(this.m_PresentDiagnosTypeID, string.Empty, false) != 0)
				{
					WebServiceLayer.MRDiagnosDataAccess.PresentDiagnosCopyed(this.m_PresentDiagnosTypeID, this.m_DiagnosTypeID, this.m_EpisodeID, this.m_UserID);
					this.LoadDiagnosAllData();
				}
			}
		}

		private void InitDic()
		{
			this.dsType = WebServiceLayer.MRDiagnosDataAccess.GetDiagnosTypesDataset();
			if (this.dsType != null && this.dsType.Tables.Count > 0)
			{
				this.DTEvaluation = this.dsType.Tables[0].Clone();
				this.DTEffect = this.dsType.Tables[0].Clone();
				this.DTDiagnosType = this.dsType.Tables[0].Clone();
				try
				{
					IEnumerator enumerator = this.dsType.Tables[0].Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						object left = dataRow["Type"];
						if (Operators.ConditionalCompareObjectEqual(left, "DiagnosticEvaluation", false))
						{
							this.DTEvaluation.ImportRow(dataRow);
						}
						else if (Operators.ConditionalCompareObjectEqual(left, "TherapeuticEffects", false))
						{
							this.DTEffect.ImportRow(dataRow);
						}
						else if (Operators.ConditionalCompareObjectEqual(left, "DiagnosType", false))
						{
							if (Operators.CompareString(dataRow["Code"].ToString(), "CURRENT", false) == 0)
							{
								this.m_PresentDiagnosTypeID = dataRow["ID"].ToString();
							}
							else
							{
								this.DTDiagnosType.ImportRow(dataRow);
							}
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
				this.SetComBox(this.cbDiagnosEffects, this.DTEffect);
				this.SetComBox(this.cbDiagnosEvaluation, this.DTEvaluation);
				this.SetCbEvaluationIndex();
				this.SetListDiagnosType();
			}
		}

		private void SetComBox(ComboBox cmb, DataTable dt)
		{
			DataRow dataRow = dt.NewRow();
			dataRow["Desc"] = "  ";
			dataRow["ID"] = "0";
			dt.Rows.InsertAt(dataRow, 0);
			cmb.DataSource = dt;
			cmb.ValueMember = "ID";
			cmb.DisplayMember = "Desc";
			cmb.SelectedIndex = -1;
		}

		private void SetCbEvaluationIndex()
		{
			if (((DataTable)this.cbDiagnosEvaluation.DataSource).Rows.Count > 1)
			{
				this.cbDiagnosEvaluation.SelectedIndex = 1;
			}
		}

		private void dgvMRDiagnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				try
				{
					string name = this.dgvMRDiagnos.Columns[e.ColumnIndex].Name;
					if (Operators.CompareString(name, "btDecrease", false) == 0)
					{
						if (Operators.ConditionalCompareObjectGreater(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value, 1, false))
						{
							this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value = Operators.SubtractObject(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value, 1);
							string left = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value.ToString().Substring(0, 3);
							if (Operators.CompareString(left, "   ", false) == 0)
							{
								this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value.ToString().Substring(3);
							}
						}
					}
					else if (Operators.CompareString(name, "btIncrease", false) == 0)
					{
						if (Operators.ConditionalCompareObjectLess(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value, 5, false))
						{
							if (Operators.ConditionalCompareObjectNotEqual(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value, null, false))
							{
								this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value = Operators.AddObject(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value, 1);
							}
							else
							{
								this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value = 2;
							}
							this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value = Operators.AddObject("   ", this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value);
						}
					}
					else if (Operators.CompareString(name, "DiagnosDele", false) == 0)
					{
						string left2 = WebServiceLayer.MRDiagnosDataAccess.DeleteDiagnos(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosID"].Value.ToString(), this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosSubID"].Value.ToString());
						if (Operators.CompareString(left2, "1", false) == 0)
						{
							this.dgvMRDiagnos.Rows.Remove(this.dgvMRDiagnos.Rows[e.RowIndex]);
							this.LoadDiagnosAllData();
						}
					}
					else if (Operators.CompareString(name, "dgtbcUP", false) == 0)
					{
						this.DiagnosMove(this.dgvMRDiagnos, true);
					}
					else if (Operators.CompareString(name, "dgtbcDown", false) == 0)
					{
						this.DiagnosMove(this.dgvMRDiagnos, false);
					}
				}
				catch (Exception expr_3E6)
				{
					ProjectData.SetProjectError(expr_3E6);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void DiagnosSave()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int arg_1A_0 = 0;
			checked
			{
				int num = this.dgvMRDiagnos.Rows.Count - 1;
				for (int i = arg_1A_0; i <= num; i++)
				{
					if (!this.dgvMRDiagnos.Rows[i].IsNewRow)
					{
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosID"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosSubID"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosLevel"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(i);
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosNameID"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosDemo"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosEvaluationID"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosEffectsID"].Value.ToString());
						stringBuilder.Append("^");
						stringBuilder.Append(this.dgvMRDiagnos.Rows[i].Cells["DiagnosName"].Value.ToString().Trim());
						stringBuilder.Append("&");
					}
				}
				string text = stringBuilder.ToString().TrimEnd(new char[]
				{
					'&'
				});
				if (Operators.CompareString(text, string.Empty, false) != 0)
				{
					WebServiceLayer.MRDiagnosDataAccess.SaveAsPresentDiagnos(text, this.m_EpisodeID, this.m_UserID);
					WebServiceLayer.MRDiagnosDataAccess.SaveDiagnos(text, this.m_UserID);
				}
			}
		}

		private void btAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.m_DiagnosTypeID, string.Empty, false) != 0 && Operators.CompareString(this.tbICD.Text.Trim(), string.Empty, false) != 0)
				{
					string icdID = string.Empty;
					DialogResult dialogResult = DialogResult.Yes;
					if (this.m_IcdId != null && Operators.CompareString(this.tbICD.Text.Trim(), this.m_IcdName, false) == 0)
					{
						icdID = this.m_IcdId;
					}
					else
					{
						dialogResult = MessageManager.ShowQuestionMessage("非标准ICD诊断，是否存储？");
					}
					if (dialogResult == DialogResult.Yes)
					{
						this.UpdataOrInsert(this.m_EpisodeID, this.m_MRID, this.m_SUBID, this.m_DiagnosTypeID, icdID, this.tbICD.Text.Trim(), this.CheckComboxValue(this.cbDiagnosEvaluation), this.CheckComboxValue(this.cbDiagnosEffects), this.m_UserID, Conversions.ToString(checked(this.dgvMRDiagnos.Rows.Count - 1)));
						this.ClearControls();
					}
				}
				else
				{
					MessageManager.ShowInformationMessage("不是诊断单元(单元没有设诊断类型)或ICD描述为空");
				}
			}
			catch (Exception expr_F7)
			{
				ProjectData.SetProjectError(expr_F7);
				ProjectData.ClearProjectError();
			}
		}

		private void UpdataOrInsert(string EpsodeID, string MrID, string SubID, string TypeID, string IcdID, string IcdName, string Evaluation, string Effect, string UserID, string Sequence)
		{
			string text = WebServiceLayer.MRDiagnosDataAccess.UpdateOrInsertMrDiagnos(EpsodeID, MrID, SubID, TypeID, IcdID, IcdName, Evaluation, Effect, UserID, Sequence);
			string[] array = text.Split(new char[]
			{
				'&'
			});
			if (Operators.CompareString(array[2], "T", false) == 0)
			{
				MessageManager.ShowInformationMessage("列表中已经存在此诊断");
				return;
			}
			if (Operators.CompareString(array[0], "0", false) != 0)
			{
				this.LoadDiagnosAllData();
				if (Operators.CompareString(array[1], "", false) != 0)
				{
					string[] array2 = array[1].Split(new char[]
					{
						'^'
					});
					MessageManager.ShowInformationMessage(array2[2]);
					this.ReportEpd(this.m_PatientID, this.m_EpisodeID, array2[1], "0");
				}
			}
		}

		private void ClearControls()
		{
			this.m_MRID = string.Empty;
			this.m_SUBID = string.Empty;
			this.m_RowIndex = 0;
			this.tbICD.Text = string.Empty;
			this.lbICDS.Visible = false;
			this.m_IcdId = string.Empty;
			this.m_IcdName = string.Empty;
			this.cbDiagnosEffects.SelectedItem = null;
			this.SetCbEvaluationIndex();
		}

		private void dgvMRDiagnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (!this.m_ButtionList.Contains(this.dgvMRDiagnos.Columns[e.ColumnIndex].Name) && e.RowIndex >= 0)
			{
				this.m_MRID = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosID"].Value.ToString();
				this.m_SUBID = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosSubID"].Value.ToString();
				this.m_RowIndex = e.RowIndex;
				this.m_Level = Conversions.ToInteger(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosLevel"].Value.ToString());
				if (Operators.CompareString(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosEvaluationID"].Value.ToString(), string.Empty, false) != 0)
				{
					this.cbDiagnosEvaluation.SelectedValue = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosEvaluationID"].Value.ToString();
				}
				if (Operators.CompareString(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosEffectsID"].Value.ToString(), string.Empty, false) != 0)
				{
					this.cbDiagnosEffects.SelectedValue = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosEffectsID"].Value.ToString();
				}
				if (Operators.CompareString(this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value.ToString(), string.Empty, false) != 0)
				{
					this.tbICD.Text = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosName"].Value.ToString().Trim();
					this.m_IcdId = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosNameID"].Value.ToString();
					this.m_IcdName = this.tbICD.Text;
				}
				else
				{
					this.tbICD.Text = this.dgvMRDiagnos.Rows[e.RowIndex].Cells["DiagnosDemo"].Value.ToString();
				}
			}
		}

		private void DiagnosMove(DataGridView dgvTemp, bool Flag)
		{
			int rowIndex = dgvTemp.CurrentCell.RowIndex;
			DataTable dataTable = (DataTable)dgvTemp.DataSource;
			checked
			{
				if (Flag)
				{
					if (rowIndex > 0)
					{
						DataRow rowData = this.GetRowData(dgvTemp, rowIndex);
						dataTable.Rows.InsertAt(rowData, rowIndex - 1);
						dataTable.Rows.RemoveAt(rowIndex + 1);
						dgvTemp.DataSource = dataTable;
						dgvTemp.CurrentCell = dgvTemp[dgvTemp.CurrentCell.ColumnIndex, rowIndex - 1];
					}
				}
				else if (rowIndex < dgvTemp.Rows.Count - 1)
				{
					DataRow rowData = this.GetRowData(dgvTemp, rowIndex);
					dataTable.Rows.InsertAt(rowData, rowIndex + 2);
					dataTable.Rows.RemoveAt(rowIndex);
					dgvTemp.DataSource = dataTable;
					dgvTemp.CurrentCell = dgvTemp[dgvTemp.CurrentCell.ColumnIndex, rowIndex + 1];
				}
			}
		}

		public DataRow GetRowData(DataGridView dgvTemp, int index)
		{
			DataRow dataRow = ((DataTable)dgvTemp.DataSource).NewRow();
			dataRow["ARowID"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosRowID"].Value);
			dataRow["AMRADMRowId"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosID"].Value);
			dataRow["ADiaSubID"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosSubID"].Value);
			dataRow["ADiagnosTypeID"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosTypeID"].Value);
			dataRow["ADiagnosType"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosType"].Value);
			dataRow["AICDID"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosNameID"].Value);
			dataRow["ADiagnosName"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosName"].Value);
			dataRow["ADemo"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosDemo"].Value);
			dataRow["AEvaluation"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosEvaluationID"].Value);
			dataRow["AEvaluationDesc"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosEvaluation"].Value);
			dataRow["AICDCode"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["ICDCode"].Value);
			dataRow["AEffects"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosEffectsID"].Value);
			dataRow["AEffectsDesc"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosEffects"].Value);
			dataRow["ALevel"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosLevel"].Value);
			dataRow["ASquence"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DiagnosSequence"].Value);
			dataRow["AUserName"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["UserName"].Value);
			dataRow["ADateTime"] = RuntimeHelpers.GetObjectValue(dgvTemp.Rows[index].Cells["DateTime"].Value);
			return dataRow;
		}

		private void tbICD_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.bEditMode && Operators.CompareString(this.tbICD.Text.Trim(), string.Empty, false) != 0)
				{
					string queryText = this.tbICD.Text.Trim();
					this.lbICDS.Visible = false;
					this.lbICDS.Items.Clear();
					EMRDiagnosICDDataset eMRDiagnosICDDataset = new EMRDiagnosICDDataset();
					eMRDiagnosICDDataset = WebServiceLayer.MRDiagnosDataAccess.GetICDDXData(queryText);
					if (eMRDiagnosICDDataset.Tables[0].Rows.Count > 0)
					{
						try
						{
							IEnumerator enumerator = eMRDiagnosICDDataset.Tables[0].Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								DiagnosDicForm.KeyText keyText = new DiagnosDicForm.KeyText();
								keyText.Value = RuntimeHelpers.GetObjectValue(dataRow[0]);
								keyText.Text = Conversions.ToString(dataRow[1]);
								this.lbICDS.Items.Add(keyText);
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
						this.lbICDS.Visible = true;
					}
					this.tbICD.SelectionStart = this.tbICD.Text.Length;
				}
			}
			catch (Exception expr_134)
			{
				ProjectData.SetProjectError(expr_134);
				ProjectData.ClearProjectError();
			}
		}

		private void lbICDS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lbICDS.SelectedItem != null && Operators.CompareString(this.lbICDS.SelectedItem.ToString(), string.Empty, false) != 0)
			{
				this.m_ICD = (DiagnosDicForm.KeyText)this.lbICDS.SelectedItem;
				this.m_IcdId = this.m_ICD.Value.ToString();
				this.m_IcdName = this.m_ICD.Text.ToString();
				this.tbICD.Text = this.m_IcdName;
			}
			else
			{
				this.m_IcdId = string.Empty;
				this.m_IcdName = this.tbICD.Text;
			}
		}

		private void tbICD_KeyDown(object sender, KeyEventArgs e)
		{
			this.bEditMode = (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Return);
			if (e.KeyCode == Keys.Down)
			{
				this.lbICDS.Visible = true;
				this.lbICDS.Focus();
				this.lbICDS.SelectedIndex = 0;
			}
		}

		private void lbICDS_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.lbICDS.Visible = false;
			}
		}

		private void lbICDS_MouseClick(object sender, MouseEventArgs e)
		{
			this.lbICDS.Visible = false;
		}

		private void QueryEpisodeList()
		{
			string valueByKey = GlobalValues.GetValueByKey("PatientID");
			this.m_EpsoideList.QueryEpsoideList(this.dgBOLISData, valueByKey);
		}

		private void dgBOLISData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string value = Conversions.ToString(this.dgBOLISData.CurrentCell.RowIndex);
			string episodeID = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeID"].Value.ToString();
			string text = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeDate"].Value.ToString();
			string text2 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["DeptDesc"].Value.ToString();
			string text3 = this.dgBOLISData.Rows[Conversions.ToInteger(value)].Cells["EpisodeType"].Value.ToString();
			this.m_EpisodeID = episodeID;
			this.LoadDiagnos();
			this.tcCheckReport.SelectedTab = this.tpAllType;
		}

		private void rbRowModle_CheckedChanged(object sender, EventArgs e)
		{
			this.m_StyleRadio = this.rbRowModle.Text;
		}

		private void rbLevelModle_CheckedChanged(object sender, EventArgs e)
		{
			this.m_StyleRadio = this.rbLevelModle.Text;
		}

		private void btSaveQuote_Click(object sender, EventArgs e)
		{
			this.QuoteData();
			this.DiagnosSave();
			this.DialogResult = DialogResult.OK;
		}

		private void QuoteData()
		{
			string text = string.Empty;
			string[] array = this.StyleScheme.Split(new char[]
			{
				'|'
			});
			string[] array2 = new string[3];
			string[] array3 = array;
			checked
			{
				for (int i = 0; i < array3.Length; i++)
				{
					string text2 = array3[i];
					array2 = text2.Split(new char[]
					{
						'#'
					});
					if (Operators.CompareString(array2[0], this.m_StyleRadio, false) == 0)
					{
						break;
					}
				}
				string[] array4 = array2[1].Split(new char[]
				{
					'^'
				});
				string str = string.Empty;
				int arg_AD_0 = 0;
				int num = this.dgvMRDiagnos.Rows.Count - 1;
				for (int j = arg_AD_0; j <= num; j++)
				{
					int num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvMRDiagnos.Rows[j].Cells["DiagnosLevel"].Value));
					if (Operators.CompareString(this.m_StyleRadio, "行模式", false) == 0)
					{
						str = this.dgvMRDiagnos.Rows[j].Cells["DiagnosName"].Value.ToString().Trim();
					}
					else
					{
						str = this.dgvMRDiagnos.Rows[j].Cells["DiagnosName"].Value.ToString();
					}
					text = text + str + array4[num2 - 1].Replace("\\r\\n", "\r");
				}
				this.m_DicValueCode = "";
				this.m_DicValue = text;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private string CheckComboxValue(ComboBox cm)
		{
			string result = "";
			if (cm.SelectedValue != null && Operators.ConditionalCompareObjectNotEqual(cm.SelectedValue, 0, false))
			{
				result = cm.SelectedValue.ToString();
			}
			return result;
		}

		private void LoadModal()
		{
			EMRDiagnosModleDataset eMRDiagnosModleDataset = new EMRDiagnosModleDataset();
			EMRDiagnosModleDetailDataset eMRDiagnosModleDetailDataset = new EMRDiagnosModleDetailDataset();
			eMRDiagnosModleDataset = WebServiceLayer.MRDiagnosDataAccess.GetModleTabs(this.m_UserID, "");
			checked
			{
				if (eMRDiagnosModleDataset != null && eMRDiagnosModleDataset.Tables.Count > 0)
				{
					try
					{
						IEnumerator enumerator = eMRDiagnosModleDataset.Tables[0].Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							TabPage tabPage = new TabPage();
							tabPage.Name = dataRow["RowId"].ToString();
							tabPage.Text = dataRow["Desc"].ToString();
							tabPage.BackColor = Color.FromArgb(200, 210, 255);
							eMRDiagnosModleDetailDataset = WebServiceLayer.MRDiagnosDataAccess.GetModleTabsDetail(dataRow["RowId"].ToString());
							if (eMRDiagnosModleDetailDataset != null && eMRDiagnosModleDetailDataset.Tables.Count > 0)
							{
								int num = 0;
								int num2 = 1;
								do
								{
									DataRow[] array = eMRDiagnosModleDetailDataset.Tables[0].Select("GroupIndex = " + Conversions.ToString(num2), "GroupItemIndex");
									ListBox listBox = new ListBox();
									listBox.Name = "listBoxs" + tabPage.Name;
									Control arg_140_0 = listBox;
									Size size = new Size(176, 123);
									arg_140_0.Size = size;
									listBox.ItemHeight = 12;
									listBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
									Control arg_166_0 = listBox;
									Point location = new Point(3 + num, 2);
									arg_166_0.Location = location;
									listBox.BorderStyle = BorderStyle.FixedSingle;
									DataRow[] array2 = array;
									for (int i = 0; i < array2.Length; i++)
									{
										DataRow dataRow2 = array2[i];
										DiagnosDicForm.KeyText keyText = new DiagnosDicForm.KeyText();
										keyText.Value = dataRow2["ICDRowId"].ToString();
										keyText.Text = dataRow2["ICDDesc"].ToString();
										listBox.Items.Add(keyText);
									}
									listBox.MouseDoubleClick += new MouseEventHandler(this.ListBox_MouseDoubleClick);
									tabPage.Controls.Add(listBox);
									num += 174;
									num2++;
								}
								while (num2 <= 5);
								this.tctrolTapModle.TabPages.Add(tabPage);
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

		private void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListBox listBox = (ListBox)sender;
			DiagnosDicForm.KeyText keyText = new DiagnosDicForm.KeyText();
			keyText = (DiagnosDicForm.KeyText)listBox.SelectedItem;
			if (Operators.CompareString(this.m_DiagnosTypeID, string.Empty, false) != 0)
			{
				this.UpdataOrInsert(this.m_EpisodeID, "", "", this.m_DiagnosTypeID, Conversions.ToString(keyText.Value), keyText.Text, this.CheckComboxValue(this.cbDiagnosEvaluation), this.CheckComboxValue(this.cbDiagnosEffects), this.m_UserID, Conversions.ToString(checked(this.dgvMRDiagnos.Rows.Count - 1)));
			}
			else
			{
				MessageManager.ShowInformationMessage("请选择诊断类型");
			}
		}

		private void LoadHistoryData()
		{
			try
			{
				EMRDiagnosHistoryDataset eMRDiagnosHistoryDataset = new EMRDiagnosHistoryDataset();
				eMRDiagnosHistoryDataset = WebServiceLayer.MRDiagnosDataAccess.GetHistoryData(this.m_PatientID, "");
				if (eMRDiagnosHistoryDataset != null && eMRDiagnosHistoryDataset.Tables.Count > 0)
				{
					this.dgvHistory.DataSource = eMRDiagnosHistoryDataset.Tables[0];
				}
			}
			catch (Exception expr_46)
			{
				ProjectData.SetProjectError(expr_46);
				MessageManager.ShowErrorMessage("加载历史数据出错");
				ProjectData.ClearProjectError();
			}
		}

		private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && Operators.CompareString(this.m_DiagnosTypeID, string.Empty, false) != 0 && Operators.CompareString(this.dgvHistory.Columns[e.ColumnIndex].Name, "HDisplay", false) != 0)
			{
				string icdID = this.dgvHistory.Rows[e.RowIndex].Cells["HRowId"].Value.ToString();
				string text = this.dgvHistory.Rows[e.RowIndex].Cells["HDesc"].Value.ToString();
				if (Operators.CompareString(text.Trim(), string.Empty, false) != 0)
				{
					this.UpdataOrInsert(this.m_EpisodeID, "", "", this.m_DiagnosTypeID, icdID, text, this.CheckComboxValue(this.cbDiagnosEvaluation), this.CheckComboxValue(this.cbDiagnosEffects), this.m_UserID, Conversions.ToString(checked(this.dgvMRDiagnos.Rows.Count - 1)));
				}
				else
				{
					MessageManager.ShowInformationMessage("ICD 描述为空");
				}
			}
		}

		private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && Operators.CompareString(this.dgvHistory.Columns[e.ColumnIndex].Name, "HDisplay", false) == 0)
			{
				new DiagnosHistoryList
				{
					Paitent = this.m_PatientID,
					IcdType = this.dgvHistory.Rows[e.RowIndex].Cells["HRowId"].Value.ToString()
				}.ShowDialog();
			}
		}

		private void ReportEpd(string patientID, string episodeID, string ifRowID, string locFlag)
		{
			this.tcCheckReport.SelectTab(2);
			this.WindowState = FormWindowState.Maximized;
			this.webBrowserMedEpdReport.NavigateTo(patientID, episodeID, ifRowID, locFlag);
		}

		private void SetListDiagnosType()
		{
			this.lbDiagnosType.DataSource = this.DTDiagnosType;
			this.lbDiagnosType.DisplayMember = "Desc";
			this.lbDiagnosType.ValueMember = "ID";
			this.lbDiagnosType.ClearSelected();
		}

		private void lbDiagnosType_Click(object sender, EventArgs e)
		{
			if (this.lbDiagnosType.SelectedValue != null)
			{
				this.m_CurrentDiagnosQuoteTable = (EMRDiagnosDataSet.GetMRDiagnosListDataTable)this.GetTalbe(this.m_MRDiagnos.Tables[0], this.lbDiagnosType.SelectedValue.ToString());
				this.dgvDiagnosList.DataSource = this.m_CurrentDiagnosQuoteTable;
			}
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.dgvDiagnosList.Rows.Count > 0)
				{
					string text = string.Empty;
					if (this.rbQlevelModel.Checked)
					{
						text = this.rbQlevelModel.Text;
					}
					else
					{
						text = this.rbQRowModel.Text;
					}
					string text2 = string.Empty;
					string[] array = this.StyleScheme.Split(new char[]
					{
						'|'
					});
					string[] array2 = new string[3];
					string[] array3 = array;
					for (int i = 0; i < array3.Length; i++)
					{
						string text3 = array3[i];
						array2 = text3.Split(new char[]
						{
							'#'
						});
						if (Operators.CompareString(array2[0], text, false) == 0)
						{
							break;
						}
					}
					string[] array4 = array2[1].Split(new char[]
					{
						'^'
					});
					string str = string.Empty;
					try
					{
						IEnumerator enumerator = ((IEnumerable)this.dgvDiagnosList.Rows).GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
							if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["QCselect"].Value, true, false))
							{
								int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["QCLevel"].Value));
								if (Operators.CompareString(text, "行模式", false) == 0)
								{
									str = dataGridViewRow.Cells["QCICDDesc"].Value.ToString().Trim();
								}
								else
								{
									str = dataGridViewRow.Cells["QCICDDesc"].Value.ToString();
								}
								text2 = text2 + str + array4[num - 1].Replace("\\r\\n", "\r");
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
					this.m_DicValueCode = "";
					this.m_DicValue = text2;
				}
			}
		}

		private void ckbCheck_Click(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = ((IEnumerable)this.dgvDiagnosList.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (this.ckbCheck.Checked)
					{
						dataGridViewRow.Cells["QCselect"].Value = true;
					}
					else
					{
						dataGridViewRow.Cells["QCselect"].Value = false;
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

		private void tcCheckReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tcCheckReport.SelectedTab == this.tpAllType)
			{
				this.lbDiagnosType.SelectedIndex = 0;
				this.lbDiagnosType_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}
}
