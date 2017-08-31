using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using DictionaryData;
using KBDiagnos;
using KBNodeData;
using KnowledgeBaseData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class DCKBNode : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("gbNodeName")]
		private GroupBox _gbNodeName;

		[AccessedThroughProperty("btnCancelPublic")]
		private Button _btnCancelPublic;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("txtNodeDesc")]
		private TextBox _txtNodeDesc;

		[AccessedThroughProperty("lblNodeDesc")]
		private Label _lblNodeDesc;

		[AccessedThroughProperty("txtNodeName")]
		private TextBox _txtNodeName;

		[AccessedThroughProperty("tbEdit")]
		private TabControl _tbEdit;

		[AccessedThroughProperty("tpContent")]
		private TabPage _tpContent;

		[AccessedThroughProperty("tpDiagnos")]
		private TabPage _tpDiagnos;

		[AccessedThroughProperty("cbxCtLoc")]
		private ComboBox _cbxCtLoc;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Pa1")]
		private Panel _Pa1;

		[AccessedThroughProperty("btnReplace1")]
		private Button _btnReplace1;

		[AccessedThroughProperty("btnAdd1")]
		private Button _btnAdd1;

		[AccessedThroughProperty("btnEdit1")]
		private Button _btnEdit1;

		[AccessedThroughProperty("lblSegment1")]
		private Label _lblSegment1;

		[AccessedThroughProperty("Pa2")]
		private Panel _Pa2;

		[AccessedThroughProperty("Pa3")]
		private Panel _Pa3;

		[AccessedThroughProperty("btnReplace2")]
		private Button _btnReplace2;

		[AccessedThroughProperty("btnAdd2")]
		private Button _btnAdd2;

		[AccessedThroughProperty("btnEdit2")]
		private Button _btnEdit2;

		[AccessedThroughProperty("btnReplace3")]
		private Button _btnReplace3;

		[AccessedThroughProperty("btnAdd3")]
		private Button _btnAdd3;

		[AccessedThroughProperty("btnEdit3")]
		private Button _btnEdit3;

		[AccessedThroughProperty("lblSegment3")]
		private Label _lblSegment3;

		[AccessedThroughProperty("lblSegment2")]
		private Label _lblSegment2;

		[AccessedThroughProperty("SegmentEdit3")]
		private PCTextEdit _SegmentEdit3;

		[AccessedThroughProperty("SegmentEdit2")]
		private PCTextEdit _SegmentEdit2;

		[AccessedThroughProperty("SegmentEdit1")]
		private PCTextEdit _SegmentEdit1;

		[AccessedThroughProperty("cklDiagnosList")]
		private CheckedListBox _cklDiagnosList;

		[AccessedThroughProperty("ckbAllDiagnos")]
		private CheckBox _ckbAllDiagnos;

		[AccessedThroughProperty("cklDiagnosRulesList")]
		private CheckedListBox _cklDiagnosRulesList;

		[AccessedThroughProperty("ckbAllDiagnosRules")]
		private CheckBox _ckbAllDiagnosRules;

		[AccessedThroughProperty("btnModify")]
		private Button _btnModify;

		[AccessedThroughProperty("btAdd")]
		private Button _btAdd;

		[AccessedThroughProperty("btnMaintain")]
		private Button _btnMaintain;

		[AccessedThroughProperty("chkCommon")]
		private CheckBox _chkCommon;

		[AccessedThroughProperty("cklRuleParamsList")]
		private CheckedListBox _cklRuleParamsList;

		[AccessedThroughProperty("ckbAllRuleParams")]
		private CheckBox _ckbAllRuleParams;

		[AccessedThroughProperty("cbxDiagnosRule")]
		private ComboBox _cbxDiagnosRule;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("gbxLine")]
		private GroupBox _gbxLine;

		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[AccessedThroughProperty("btnInUse")]
		private Button _btnInUse;

		[AccessedThroughProperty("lblNodeName")]
		private Label _lblNodeName;

		private EKnowledgeBase _EKnowledgeBase;

		private string _KBNodeID;

		private EKBNode _EKBNode;

		private bool _ClientMode;

		private bool _Editable;

		private bool _Reviced;

		private string _CTLogID;

		private bool _IsPersonlKBNode;

		private bool _EnableRoleKBTree;

		private List<string> _KbIDs;

		internal virtual GroupBox gbNodeName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbNodeName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbNodeName = value;
			}
		}

		internal virtual Button btnCancelPublic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancelPublic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancelPublic_Click);
				if (this._btnCancelPublic != null)
				{
					this._btnCancelPublic.Click -= value2;
				}
				this._btnCancelPublic = value;
				if (this._btnCancelPublic != null)
				{
					this._btnCancelPublic.Click += value2;
				}
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
				EventHandler value2 = new EventHandler(this.txtNodeDesc_TextChanged);
				if (this._txtNodeDesc != null)
				{
					this._txtNodeDesc.TextChanged -= value2;
				}
				this._txtNodeDesc = value;
				if (this._txtNodeDesc != null)
				{
					this._txtNodeDesc.TextChanged += value2;
				}
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
				EventHandler value2 = new EventHandler(this.txtNodeName_TextChanged);
				if (this._txtNodeName != null)
				{
					this._txtNodeName.TextChanged -= value2;
				}
				this._txtNodeName = value;
				if (this._txtNodeName != null)
				{
					this._txtNodeName.TextChanged += value2;
				}
			}
		}

		internal virtual TabControl tbEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbEdit = value;
			}
		}

		internal virtual TabPage tpContent
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpContent;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpContent = value;
			}
		}

		internal virtual TabPage tpDiagnos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpDiagnos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpDiagnos = value;
			}
		}

		internal virtual ComboBox cbxCtLoc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxCtLoc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxCtLoc_SelectedIndexChanged);
				if (this._cbxCtLoc != null)
				{
					this._cbxCtLoc.SelectedIndexChanged -= value2;
				}
				this._cbxCtLoc = value;
				if (this._cbxCtLoc != null)
				{
					this._cbxCtLoc.SelectedIndexChanged += value2;
				}
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

		internal virtual Panel Pa1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pa1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Pa1 = value;
			}
		}

		internal virtual Button btnReplace1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace1 = value;
			}
		}

		internal virtual Button btnAdd1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd1 = value;
			}
		}

		internal virtual Button btnEdit1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEdit1_Click);
				if (this._btnEdit1 != null)
				{
					this._btnEdit1.Click -= value2;
				}
				this._btnEdit1 = value;
				if (this._btnEdit1 != null)
				{
					this._btnEdit1.Click += value2;
				}
			}
		}

		internal virtual Label lblSegment1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment1 = value;
			}
		}

		internal virtual Panel Pa2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pa2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Pa2 = value;
			}
		}

		internal virtual Panel Pa3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pa3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Pa3 = value;
			}
		}

		internal virtual Button btnReplace2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace2 = value;
			}
		}

		internal virtual Button btnAdd2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd2 = value;
			}
		}

		internal virtual Button btnEdit2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEdit2_Click);
				if (this._btnEdit2 != null)
				{
					this._btnEdit2.Click -= value2;
				}
				this._btnEdit2 = value;
				if (this._btnEdit2 != null)
				{
					this._btnEdit2.Click += value2;
				}
			}
		}

		internal virtual Button btnReplace3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReplace3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnReplace3 = value;
			}
		}

		internal virtual Button btnAdd3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnAdd3 = value;
			}
		}

		internal virtual Button btnEdit3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEdit3_Click);
				if (this._btnEdit3 != null)
				{
					this._btnEdit3.Click -= value2;
				}
				this._btnEdit3 = value;
				if (this._btnEdit3 != null)
				{
					this._btnEdit3.Click += value2;
				}
			}
		}

		internal virtual Label lblSegment3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment3 = value;
			}
		}

		internal virtual Label lblSegment2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSegment2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSegment2 = value;
			}
		}

		internal virtual PCTextEdit SegmentEdit3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit3 = value;
			}
		}

		internal virtual PCTextEdit SegmentEdit2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit2 = value;
			}
		}

		internal virtual PCTextEdit SegmentEdit1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentEdit1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentEdit1 = value;
			}
		}

		internal virtual CheckedListBox cklDiagnosList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cklDiagnosList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cklDiagnosList = value;
			}
		}

		internal virtual CheckBox ckbAllDiagnos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbAllDiagnos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbAllDiagnos_CheckedChanged);
				if (this._ckbAllDiagnos != null)
				{
					this._ckbAllDiagnos.CheckedChanged -= value2;
				}
				this._ckbAllDiagnos = value;
				if (this._ckbAllDiagnos != null)
				{
					this._ckbAllDiagnos.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckedListBox cklDiagnosRulesList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cklDiagnosRulesList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cklDiagnosRulesList = value;
			}
		}

		internal virtual CheckBox ckbAllDiagnosRules
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbAllDiagnosRules;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbAllDiagnosRules_CheckedChanged);
				if (this._ckbAllDiagnosRules != null)
				{
					this._ckbAllDiagnosRules.CheckedChanged -= value2;
				}
				this._ckbAllDiagnosRules = value;
				if (this._ckbAllDiagnosRules != null)
				{
					this._ckbAllDiagnosRules.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button btnModify
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnModify;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnModify_Click);
				if (this._btnModify != null)
				{
					this._btnModify.Click -= value2;
				}
				this._btnModify = value;
				if (this._btnModify != null)
				{
					this._btnModify.Click += value2;
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

		internal virtual Button btnMaintain
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnMaintain;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnMaintain_Click);
				if (this._btnMaintain != null)
				{
					this._btnMaintain.Click -= value2;
				}
				this._btnMaintain = value;
				if (this._btnMaintain != null)
				{
					this._btnMaintain.Click += value2;
				}
			}
		}

		internal virtual CheckBox chkCommon
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkCommon;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkCommon = value;
			}
		}

		internal virtual CheckedListBox cklRuleParamsList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cklRuleParamsList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cklRuleParamsList = value;
			}
		}

		internal virtual CheckBox ckbAllRuleParams
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbAllRuleParams;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbAllRuleParams_CheckedChanged);
				if (this._ckbAllRuleParams != null)
				{
					this._ckbAllRuleParams.CheckedChanged -= value2;
				}
				this._ckbAllRuleParams = value;
				if (this._ckbAllRuleParams != null)
				{
					this._ckbAllRuleParams.CheckedChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbxDiagnosRule
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxDiagnosRule;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxDiagnosRule_SelectedIndexChanged);
				if (this._cbxDiagnosRule != null)
				{
					this._cbxDiagnosRule.SelectedIndexChanged -= value2;
				}
				this._cbxDiagnosRule = value;
				if (this._cbxDiagnosRule != null)
				{
					this._cbxDiagnosRule.SelectedIndexChanged += value2;
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

		internal virtual GroupBox gbxLine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxLine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxLine = value;
			}
		}

		internal virtual Button btnDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDelete_Click);
				if (this._btnDelete != null)
				{
					this._btnDelete.Click -= value2;
				}
				this._btnDelete = value;
				if (this._btnDelete != null)
				{
					this._btnDelete.Click += value2;
				}
			}
		}

		internal virtual Button btnInUse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnInUse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnInUse_Click);
				if (this._btnInUse != null)
				{
					this._btnInUse.Click -= value2;
				}
				this._btnInUse = value;
				if (this._btnInUse != null)
				{
					this._btnInUse.Click += value2;
				}
			}
		}

		internal virtual Label lblNodeName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblNodeName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNodeName = value;
			}
		}

		public bool Reviced
		{
			get
			{
				bool flag;
				return flag | this._SegmentEdit1.CanUndo | this._SegmentEdit2.CanUndo | this._SegmentEdit3.CanUndo;
			}
			set
			{
				this._Reviced = value;
			}
		}

		public EKBNode EKBNode
		{
			get
			{
				return this._EKBNode;
			}
			set
			{
				this._EKBNode = value;
			}
		}

		public bool ClientMode
		{
			get
			{
				return this._ClientMode;
			}
			set
			{
				this._ClientMode = value;
				this.btnAdd1.Visible = !this._ClientMode;
				this.btnAdd2.Visible = !this._ClientMode;
				this.btnAdd3.Visible = !this._ClientMode;
				this.btnReplace1.Visible = !this._ClientMode;
				this.btnReplace2.Visible = !this._ClientMode;
				this.btnReplace3.Visible = !this._ClientMode;
			}
		}

		public bool Editable
		{
			get
			{
				return this._Editable;
			}
			set
			{
				this._Editable = value;
				this.btnSave.Visible = this._Editable;
				this.btnEdit1.Visible = this._Editable;
				this.btnEdit2.Visible = this._Editable;
				this.btnEdit3.Visible = this._Editable;
			}
		}

		public EKnowledgeBase EKnowledgeBase
		{
			get
			{
				return this._EKnowledgeBase;
			}
			set
			{
				this._EKnowledgeBase = value;
				if (this._EKnowledgeBase.SegmentNumber == 1L)
				{
					this.lblSegment1.Visible = true;
					if (this._Editable)
					{
						this.btnEdit1.Visible = true;
					}
					else
					{
						this.btnEdit1.Visible = false;
					}
					this.SegmentEdit1.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace1.Visible = true;
						this.btnAdd1.Visible = true;
					}
					else
					{
						this.btnReplace1.Visible = false;
						this.btnAdd1.Visible = false;
					}
					this.lblSegment2.Visible = false;
					this.btnEdit2.Visible = false;
					this.btnReplace2.Visible = false;
					this.SegmentEdit2.Visible = false;
					this.btnReplace2.Visible = false;
					this.btnAdd2.Visible = false;
					this.lblSegment3.Visible = false;
					this.btnEdit3.Visible = false;
					this.SegmentEdit3.Visible = false;
					this.btnReplace3.Visible = false;
					this.btnAdd3.Visible = false;
					this.lblSegment1.Text = this._EKnowledgeBase.S1Name;
				}
				else if (this._EKnowledgeBase.SegmentNumber == 2L)
				{
					this.lblSegment1.Visible = true;
					if (this._Editable)
					{
						this.btnEdit1.Visible = true;
					}
					else
					{
						this.btnEdit1.Visible = false;
					}
					this.SegmentEdit1.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace1.Visible = true;
						this.btnAdd1.Visible = true;
					}
					else
					{
						this.btnReplace1.Visible = false;
						this.btnAdd1.Visible = false;
					}
					this.lblSegment2.Visible = true;
					if (this._Editable)
					{
						this.btnEdit2.Visible = true;
					}
					else
					{
						this.btnEdit2.Visible = false;
					}
					this.SegmentEdit2.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace2.Visible = true;
						this.btnAdd2.Visible = true;
					}
					else
					{
						this.btnReplace2.Visible = false;
						this.btnAdd2.Visible = false;
					}
					this.lblSegment3.Visible = false;
					this.btnEdit3.Visible = false;
					this.SegmentEdit3.Visible = false;
					this.btnReplace3.Visible = false;
					this.btnAdd3.Visible = false;
					this.lblSegment1.Text = this._EKnowledgeBase.S1Name;
					this.lblSegment2.Text = this._EKnowledgeBase.S2Name;
				}
				else if (this._EKnowledgeBase.SegmentNumber == 3L)
				{
					this.lblSegment1.Visible = true;
					if (this._Editable)
					{
						this.btnEdit1.Visible = true;
					}
					else
					{
						this.btnEdit1.Visible = false;
					}
					this.SegmentEdit1.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace1.Visible = true;
						this.btnAdd1.Visible = true;
					}
					else
					{
						this.btnReplace1.Visible = false;
						this.btnAdd1.Visible = false;
					}
					this.lblSegment2.Visible = true;
					if (this._Editable)
					{
						this.btnEdit2.Visible = true;
					}
					else
					{
						this.btnEdit2.Visible = false;
					}
					this.SegmentEdit2.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace2.Visible = true;
						this.btnAdd2.Visible = true;
					}
					else
					{
						this.btnReplace2.Visible = false;
						this.btnAdd2.Visible = false;
					}
					this.lblSegment3.Visible = true;
					if (this._Editable)
					{
						this.btnEdit3.Visible = true;
					}
					else
					{
						this.btnEdit3.Visible = false;
					}
					this.SegmentEdit3.Visible = true;
					if (this._ClientMode)
					{
						this.btnReplace3.Visible = true;
						this.btnAdd3.Visible = true;
					}
					else
					{
						this.btnReplace3.Visible = false;
						this.btnAdd3.Visible = false;
					}
					this.lblSegment1.Text = this._EKnowledgeBase.S1Name;
					this.lblSegment2.Text = this._EKnowledgeBase.S2Name;
					this.lblSegment3.Text = this._EKnowledgeBase.S3Name;
				}
			}
		}

		public bool IsPersonlKBNode
		{
			get
			{
				return this._IsPersonlKBNode;
			}
			set
			{
				this._IsPersonlKBNode = value;
			}
		}

		public string KBNodeID
		{
			get
			{
				return this._KBNodeID;
			}
			set
			{
				this._KBNodeID = value;
				try
				{
					this._EKBNode = WebServiceLayer.KBNodeAccess.SelectKBNodeByID(this._KBNodeID);
					if (this._EKBNode != null)
					{
						this.txtNodeName.Text = this._EKBNode.Name;
						this.txtNodeDesc.Text = this._EKBNode.Description;
						this.chkCommon.Checked = this._EKBNode.IsCommon.Equals("Y");
						if (string.IsNullOrEmpty(this._EKBNode.IsInUse) || Operators.CompareString("Y", this._EKBNode.IsInUse, false) == 0)
						{
							this.btnInUse.Text = "停用";
						}
						else
						{
							this.btnInUse.Text = "启用";
						}
					}
					this.InitSegmentEdit();
					this.btnCancelPublic.Visible = !this.ClientMode;
					bool flag = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(WebServiceLayer.SysOptionAccess.GetValueByName("IsPersonalKBBindDiagnos"), "Y", false) == 0, true, false));
					if (this.ClientMode && this.IsPersonlKBNode && !flag)
					{
						this.tbEdit.Controls.RemoveByKey("tpDiagnos");
					}
					else
					{
						this.InitDiagnosTab(this._KBNodeID);
					}
				}
				catch (Exception expr_147)
				{
					ProjectData.SetProjectError(expr_147);
					Exception ex = expr_147;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		public string CTLogID
		{
			get
			{
				return this._CTLogID;
			}
			set
			{
				this._CTLogID = value;
			}
		}

		public NISegment NISegment1
		{
			get
			{
				if (this.SegmentEdit1.BindInstanceItem == null)
				{
					return null;
				}
				MISegment metaitem = (MISegment)this.SegmentEdit1.BindInstanceItem.BindMMetaItem.Clone();
				NISegment nISegment = (NISegment)this.SegmentEdit1.BindInstanceItem.Clone();
				nISegment.SyncMetaItem(metaitem);
				return nISegment;
			}
		}

		public NISegment NISegment2
		{
			get
			{
				if (this.SegmentEdit2.BindInstanceItem == null)
				{
					return null;
				}
				MISegment metaitem = (MISegment)this.SegmentEdit2.BindInstanceItem.BindMMetaItem.Clone();
				NISegment nISegment = (NISegment)this.SegmentEdit2.BindInstanceItem.Clone();
				nISegment.SyncMetaItem(metaitem);
				return nISegment;
			}
		}

		public NISegment NISegment3
		{
			get
			{
				if (this.SegmentEdit3.BindInstanceItem == null)
				{
					return null;
				}
				MISegment metaitem = (MISegment)this.SegmentEdit3.BindInstanceItem.BindMMetaItem.Clone();
				NISegment nISegment = (NISegment)this.SegmentEdit3.BindInstanceItem.Clone();
				nISegment.SyncMetaItem(metaitem);
				return nISegment;
			}
		}

		public DCKBNode()
		{
			this._IsPersonlKBNode = false;
			this._EnableRoleKBTree = false;
			this.InitializeComponent();
			string text = SysOptionManager.GetSysOptionValue("CanKBStatusSwitch", "N");
			text = Strings.UCase(text);
			this.btnCancelPublic.Enabled = (Operators.CompareString(text, "Y", false) == 0);
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
			this.gbNodeName = new GroupBox();
			this.chkCommon = new CheckBox();
			this.btnCancelPublic = new Button();
			this.btnSave = new Button();
			this.txtNodeDesc = new TextBox();
			this.lblNodeDesc = new Label();
			this.txtNodeName = new TextBox();
			this.lblNodeName = new Label();
			this.tbEdit = new TabControl();
			this.tpContent = new TabPage();
			this.SegmentEdit3 = new PCTextEdit();
			this.SegmentEdit2 = new PCTextEdit();
			this.SegmentEdit1 = new PCTextEdit();
			this.Pa3 = new Panel();
			this.btnReplace3 = new Button();
			this.btnAdd3 = new Button();
			this.btnEdit3 = new Button();
			this.lblSegment3 = new Label();
			this.Pa2 = new Panel();
			this.btnReplace2 = new Button();
			this.btnAdd2 = new Button();
			this.btnEdit2 = new Button();
			this.lblSegment2 = new Label();
			this.Pa1 = new Panel();
			this.btnReplace1 = new Button();
			this.btnAdd1 = new Button();
			this.btnEdit1 = new Button();
			this.lblSegment1 = new Label();
			this.tpDiagnos = new TabPage();
			this.btnDelete = new Button();
			this.gbxLine = new GroupBox();
			this.Label3 = new Label();
			this.cbxDiagnosRule = new ComboBox();
			this.ckbAllRuleParams = new CheckBox();
			this.cklRuleParamsList = new CheckedListBox();
			this.btnMaintain = new Button();
			this.btnModify = new Button();
			this.btAdd = new Button();
			this.ckbAllDiagnosRules = new CheckBox();
			this.cklDiagnosRulesList = new CheckedListBox();
			this.ckbAllDiagnos = new CheckBox();
			this.cklDiagnosList = new CheckedListBox();
			this.cbxCtLoc = new ComboBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.btnInUse = new Button();
			this.gbNodeName.SuspendLayout();
			this.tbEdit.SuspendLayout();
			this.tpContent.SuspendLayout();
			this.Pa3.SuspendLayout();
			this.Pa2.SuspendLayout();
			this.Pa1.SuspendLayout();
			this.tpDiagnos.SuspendLayout();
			this.SuspendLayout();
			this.gbNodeName.Controls.Add(this.btnInUse);
			this.gbNodeName.Controls.Add(this.chkCommon);
			this.gbNodeName.Controls.Add(this.btnCancelPublic);
			this.gbNodeName.Controls.Add(this.btnSave);
			this.gbNodeName.Controls.Add(this.txtNodeDesc);
			this.gbNodeName.Controls.Add(this.lblNodeDesc);
			this.gbNodeName.Controls.Add(this.txtNodeName);
			this.gbNodeName.Controls.Add(this.lblNodeName);
			this.gbNodeName.Dock = DockStyle.Top;
			Control arg_319_0 = this.gbNodeName;
			Point point = new Point(0, 0);
			arg_319_0.Location = point;
			this.gbNodeName.Name = "gbNodeName";
			Control arg_343_0 = this.gbNodeName;
			Size size = new Size(496, 89);
			arg_343_0.Size = size;
			this.gbNodeName.TabIndex = 33;
			this.gbNodeName.TabStop = false;
			Control arg_376_0 = this.chkCommon;
			point = new Point(222, 17);
			arg_376_0.Location = point;
			this.chkCommon.Name = "chkCommon";
			Control arg_39D_0 = this.chkCommon;
			size = new Size(72, 18);
			arg_39D_0.Size = size;
			this.chkCommon.TabIndex = 33;
			this.chkCommon.Text = "是否通用";
			this.chkCommon.UseVisualStyleBackColor = true;
			Control arg_3E0_0 = this.btnCancelPublic;
			point = new Point(370, 13);
			arg_3E0_0.Location = point;
			this.btnCancelPublic.Name = "btnCancelPublic";
			Control arg_407_0 = this.btnCancelPublic;
			size = new Size(62, 23);
			arg_407_0.Size = size;
			this.btnCancelPublic.TabIndex = 32;
			this.btnCancelPublic.Text = "取消发布";
			Control arg_43E_0 = this.btnSave;
			point = new Point(295, 13);
			arg_43E_0.Location = point;
			this.btnSave.Name = "btnSave";
			Control arg_465_0 = this.btnSave;
			size = new Size(73, 23);
			arg_465_0.Size = size;
			this.btnSave.TabIndex = 31;
			this.btnSave.Text = "保存并发布";
			Control arg_499_0 = this.txtNodeDesc;
			point = new Point(78, 40);
			arg_499_0.Location = point;
			this.txtNodeDesc.Multiline = true;
			this.txtNodeDesc.Name = "txtNodeDesc";
			Control arg_4CF_0 = this.txtNodeDesc;
			size = new Size(408, 41);
			arg_4CF_0.Size = size;
			this.txtNodeDesc.TabIndex = 30;
			Control arg_4F2_0 = this.lblNodeDesc;
			point = new Point(4, 40);
			arg_4F2_0.Location = point;
			this.lblNodeDesc.Name = "lblNodeDesc";
			Control arg_519_0 = this.lblNodeDesc;
			size = new Size(68, 20);
			arg_519_0.Size = size;
			this.lblNodeDesc.TabIndex = 29;
			this.lblNodeDesc.Text = "节点说明：";
			this.lblNodeDesc.TextAlign = ContentAlignment.MiddleRight;
			Control arg_55A_0 = this.txtNodeName;
			point = new Point(78, 15);
			arg_55A_0.Location = point;
			this.txtNodeName.Name = "txtNodeName";
			Control arg_584_0 = this.txtNodeName;
			size = new Size(138, 21);
			arg_584_0.Size = size;
			this.txtNodeName.TabIndex = 28;
			Control arg_5A7_0 = this.lblNodeName;
			point = new Point(4, 15);
			arg_5A7_0.Location = point;
			this.lblNodeName.Name = "lblNodeName";
			Control arg_5CE_0 = this.lblNodeName;
			size = new Size(68, 20);
			arg_5CE_0.Size = size;
			this.lblNodeName.TabIndex = 27;
			this.lblNodeName.Text = "节点名称：";
			this.lblNodeName.TextAlign = ContentAlignment.MiddleRight;
			this.tbEdit.Controls.Add(this.tpContent);
			this.tbEdit.Controls.Add(this.tpDiagnos);
			this.tbEdit.Dock = DockStyle.Bottom;
			Control arg_646_0 = this.tbEdit;
			point = new Point(0, 92);
			arg_646_0.Location = point;
			Control arg_65A_0 = this.tbEdit;
			Padding margin = new Padding(0);
			arg_65A_0.Margin = margin;
			this.tbEdit.Name = "tbEdit";
			TabControl arg_67F_0 = this.tbEdit;
			point = new Point(3, 3);
			arg_67F_0.Padding = point;
			this.tbEdit.SelectedIndex = 0;
			Control arg_6A8_0 = this.tbEdit;
			size = new Size(496, 420);
			arg_6A8_0.Size = size;
			this.tbEdit.TabIndex = 34;
			this.tpContent.BackColor = SystemColors.Control;
			this.tpContent.Controls.Add(this.SegmentEdit3);
			this.tpContent.Controls.Add(this.SegmentEdit2);
			this.tpContent.Controls.Add(this.SegmentEdit1);
			this.tpContent.Controls.Add(this.Pa3);
			this.tpContent.Controls.Add(this.Pa2);
			this.tpContent.Controls.Add(this.Pa1);
			TabPage arg_75F_0 = this.tpContent;
			point = new Point(4, 21);
			arg_75F_0.Location = point;
			Control arg_773_0 = this.tpContent;
			margin = new Padding(0);
			arg_773_0.Margin = margin;
			this.tpContent.Name = "tpContent";
			Control arg_7A0_0 = this.tpContent;
			size = new Size(488, 395);
			arg_7A0_0.Size = size;
			this.tpContent.TabIndex = 0;
			this.tpContent.Text = "节点内容编辑";
			this.SegmentEdit3.AcceptsTab = true;
			this.SegmentEdit3.AllowDrop = true;
			this.SegmentEdit3.BindInstanceItem = null;
			this.SegmentEdit3.BorderStyle = BorderStyle.FixedSingle;
			this.SegmentEdit3.Code = null;
			this.SegmentEdit3.DisableAutoScroll = false;
			Control arg_81E_0 = this.SegmentEdit3;
			point = new Point(14, 293);
			arg_81E_0.Location = point;
			this.SegmentEdit3.Name = "SegmentEdit3";
			Control arg_848_0 = this.SegmentEdit3;
			size = new Size(460, 98);
			arg_848_0.Size = size;
			this.SegmentEdit3.TabIndex = 72;
			this.SegmentEdit3.Text = "";
			this.SegmentEdit2.AcceptsTab = true;
			this.SegmentEdit2.AllowDrop = true;
			this.SegmentEdit2.BindInstanceItem = null;
			this.SegmentEdit2.BorderStyle = BorderStyle.FixedSingle;
			this.SegmentEdit2.Code = null;
			this.SegmentEdit2.DisableAutoScroll = false;
			Control arg_8C7_0 = this.SegmentEdit2;
			point = new Point(14, 163);
			arg_8C7_0.Location = point;
			this.SegmentEdit2.Name = "SegmentEdit2";
			Control arg_8F1_0 = this.SegmentEdit2;
			size = new Size(460, 98);
			arg_8F1_0.Size = size;
			this.SegmentEdit2.TabIndex = 71;
			this.SegmentEdit2.Text = "";
			this.SegmentEdit1.AcceptsTab = true;
			this.SegmentEdit1.AllowDrop = true;
			this.SegmentEdit1.BindInstanceItem = null;
			this.SegmentEdit1.BorderStyle = BorderStyle.FixedSingle;
			this.SegmentEdit1.Code = null;
			this.SegmentEdit1.DisableAutoScroll = false;
			Control arg_96D_0 = this.SegmentEdit1;
			point = new Point(14, 30);
			arg_96D_0.Location = point;
			this.SegmentEdit1.Name = "SegmentEdit1";
			Control arg_997_0 = this.SegmentEdit1;
			size = new Size(460, 98);
			arg_997_0.Size = size;
			this.SegmentEdit1.TabIndex = 70;
			this.SegmentEdit1.Text = "";
			this.Pa3.Controls.Add(this.btnReplace3);
			this.Pa3.Controls.Add(this.btnAdd3);
			this.Pa3.Controls.Add(this.btnEdit3);
			this.Pa3.Controls.Add(this.lblSegment3);
			Control arg_A26_0 = this.Pa3;
			point = new Point(14, 265);
			arg_A26_0.Location = point;
			this.Pa3.Name = "Pa3";
			Control arg_A50_0 = this.Pa3;
			size = new Size(460, 28);
			arg_A50_0.Size = size;
			this.Pa3.TabIndex = 69;
			Control arg_A76_0 = this.btnReplace3;
			point = new Point(299, 2);
			arg_A76_0.Location = point;
			this.btnReplace3.Name = "btnReplace3";
			Control arg_A9D_0 = this.btnReplace3;
			size = new Size(56, 23);
			arg_A9D_0.Size = size;
			this.btnReplace3.TabIndex = 71;
			this.btnReplace3.Text = "替换";
			Control arg_AD3_0 = this.btnAdd3;
			point = new Point(212, 2);
			arg_AD3_0.Location = point;
			this.btnAdd3.Name = "btnAdd3";
			Control arg_AFA_0 = this.btnAdd3;
			size = new Size(56, 23);
			arg_AFA_0.Size = size;
			this.btnAdd3.TabIndex = 70;
			this.btnAdd3.Text = "添加";
			Control arg_B30_0 = this.btnEdit3;
			point = new Point(132, 2);
			arg_B30_0.Location = point;
			this.btnEdit3.Name = "btnEdit3";
			Control arg_B57_0 = this.btnEdit3;
			size = new Size(56, 23);
			arg_B57_0.Size = size;
			this.btnEdit3.TabIndex = 69;
			this.btnEdit3.Text = "编辑";
			Control arg_B8A_0 = this.lblSegment3;
			point = new Point(13, 7);
			arg_B8A_0.Location = point;
			this.lblSegment3.Name = "lblSegment3";
			Control arg_BB1_0 = this.lblSegment3;
			size = new Size(100, 12);
			arg_BB1_0.Size = size;
			this.lblSegment3.TabIndex = 67;
			this.Pa2.Controls.Add(this.btnReplace2);
			this.Pa2.Controls.Add(this.btnAdd2);
			this.Pa2.Controls.Add(this.btnEdit2);
			this.Pa2.Controls.Add(this.lblSegment2);
			Control arg_C30_0 = this.Pa2;
			point = new Point(14, 130);
			arg_C30_0.Location = point;
			this.Pa2.Name = "Pa2";
			Control arg_C5A_0 = this.Pa2;
			size = new Size(460, 30);
			arg_C5A_0.Size = size;
			this.Pa2.TabIndex = 68;
			Control arg_C80_0 = this.btnReplace2;
			point = new Point(299, 5);
			arg_C80_0.Location = point;
			this.btnReplace2.Name = "btnReplace2";
			Control arg_CA7_0 = this.btnReplace2;
			size = new Size(56, 23);
			arg_CA7_0.Size = size;
			this.btnReplace2.TabIndex = 68;
			this.btnReplace2.Text = "替换";
			Control arg_CDD_0 = this.btnAdd2;
			point = new Point(212, 5);
			arg_CDD_0.Location = point;
			this.btnAdd2.Name = "btnAdd2";
			Control arg_D04_0 = this.btnAdd2;
			size = new Size(56, 23);
			arg_D04_0.Size = size;
			this.btnAdd2.TabIndex = 67;
			this.btnAdd2.Text = "添加";
			Control arg_D3A_0 = this.btnEdit2;
			point = new Point(132, 5);
			arg_D3A_0.Location = point;
			this.btnEdit2.Name = "btnEdit2";
			Control arg_D61_0 = this.btnEdit2;
			size = new Size(56, 23);
			arg_D61_0.Size = size;
			this.btnEdit2.TabIndex = 66;
			this.btnEdit2.Text = "编辑";
			Control arg_D95_0 = this.lblSegment2;
			point = new Point(13, 9);
			arg_D95_0.Location = point;
			this.lblSegment2.Name = "lblSegment2";
			Control arg_DBC_0 = this.lblSegment2;
			size = new Size(100, 12);
			arg_DBC_0.Size = size;
			this.lblSegment2.TabIndex = 57;
			this.Pa1.Controls.Add(this.btnReplace1);
			this.Pa1.Controls.Add(this.btnAdd1);
			this.Pa1.Controls.Add(this.btnEdit1);
			this.Pa1.Controls.Add(this.lblSegment1);
			Control arg_E37_0 = this.Pa1;
			point = new Point(14, 1);
			arg_E37_0.Location = point;
			this.Pa1.Name = "Pa1";
			Control arg_E61_0 = this.Pa1;
			size = new Size(460, 29);
			arg_E61_0.Size = size;
			this.Pa1.TabIndex = 67;
			Control arg_E87_0 = this.btnReplace1;
			point = new Point(299, 3);
			arg_E87_0.Location = point;
			this.btnReplace1.Name = "btnReplace1";
			Control arg_EAE_0 = this.btnReplace1;
			size = new Size(56, 23);
			arg_EAE_0.Size = size;
			this.btnReplace1.TabIndex = 61;
			this.btnReplace1.Text = "替换";
			Control arg_EE4_0 = this.btnAdd1;
			point = new Point(212, 3);
			arg_EE4_0.Location = point;
			this.btnAdd1.Name = "btnAdd1";
			Control arg_F0B_0 = this.btnAdd1;
			size = new Size(56, 23);
			arg_F0B_0.Size = size;
			this.btnAdd1.TabIndex = 60;
			this.btnAdd1.Text = "添加";
			Control arg_F41_0 = this.btnEdit1;
			point = new Point(132, 3);
			arg_F41_0.Location = point;
			this.btnEdit1.Name = "btnEdit1";
			Control arg_F68_0 = this.btnEdit1;
			size = new Size(56, 23);
			arg_F68_0.Size = size;
			this.btnEdit1.TabIndex = 59;
			this.btnEdit1.Text = "编辑";
			Control arg_F9B_0 = this.lblSegment1;
			point = new Point(13, 8);
			arg_F9B_0.Location = point;
			this.lblSegment1.Name = "lblSegment1";
			Control arg_FC2_0 = this.lblSegment1;
			size = new Size(100, 12);
			arg_FC2_0.Size = size;
			this.lblSegment1.TabIndex = 57;
			this.tpDiagnos.BackColor = SystemColors.Control;
			this.tpDiagnos.Controls.Add(this.btnDelete);
			this.tpDiagnos.Controls.Add(this.gbxLine);
			this.tpDiagnos.Controls.Add(this.Label3);
			this.tpDiagnos.Controls.Add(this.cbxDiagnosRule);
			this.tpDiagnos.Controls.Add(this.ckbAllRuleParams);
			this.tpDiagnos.Controls.Add(this.cklRuleParamsList);
			this.tpDiagnos.Controls.Add(this.btnMaintain);
			this.tpDiagnos.Controls.Add(this.btnModify);
			this.tpDiagnos.Controls.Add(this.btAdd);
			this.tpDiagnos.Controls.Add(this.ckbAllDiagnosRules);
			this.tpDiagnos.Controls.Add(this.cklDiagnosRulesList);
			this.tpDiagnos.Controls.Add(this.ckbAllDiagnos);
			this.tpDiagnos.Controls.Add(this.cklDiagnosList);
			this.tpDiagnos.Controls.Add(this.cbxCtLoc);
			this.tpDiagnos.Controls.Add(this.Label1);
			this.tpDiagnos.Controls.Add(this.Label2);
			TabPage arg_1155_0 = this.tpDiagnos;
			point = new Point(4, 21);
			arg_1155_0.Location = point;
			Control arg_1169_0 = this.tpDiagnos;
			margin = new Padding(0);
			arg_1169_0.Margin = margin;
			this.tpDiagnos.Name = "tpDiagnos";
			Control arg_1196_0 = this.tpDiagnos;
			size = new Size(488, 395);
			arg_1196_0.Size = size;
			this.tpDiagnos.TabIndex = 1;
			this.tpDiagnos.Text = "疾病对应关系";
			this.btnDelete.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_11DB_0 = this.btnDelete;
			point = new Point(407, 368);
			arg_11DB_0.Location = point;
			this.btnDelete.Name = "btnDelete";
			Control arg_1202_0 = this.btnDelete;
			size = new Size(75, 23);
			arg_1202_0.Size = size;
			this.btnDelete.TabIndex = 59;
			this.btnDelete.Text = "删除";
			this.btnDelete.UseVisualStyleBackColor = true;
			Control arg_1241_0 = this.gbxLine;
			point = new Point(5, 38);
			arg_1241_0.Location = point;
			this.gbxLine.Name = "gbxLine";
			Control arg_126A_0 = this.gbxLine;
			size = new Size(481, 4);
			arg_126A_0.Size = size;
			this.gbxLine.TabIndex = 58;
			this.gbxLine.TabStop = false;
			Control arg_129D_0 = this.Label3;
			point = new Point(248, 47);
			arg_129D_0.Location = point;
			this.Label3.Name = "Label3";
			Control arg_12C4_0 = this.Label3;
			size = new Size(72, 20);
			arg_12C4_0.Size = size;
			this.Label3.TabIndex = 57;
			this.Label3.Text = "可选规则：";
			this.Label3.TextAlign = ContentAlignment.MiddleLeft;
			this.cbxDiagnosRule.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbxDiagnosRule.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbxDiagnosRule.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxDiagnosRule.FormattingEnabled = true;
			Control arg_133C_0 = this.cbxDiagnosRule;
			point = new Point(321, 47);
			arg_133C_0.Location = point;
			this.cbxDiagnosRule.Name = "cbxDiagnosRule";
			Control arg_1366_0 = this.cbxDiagnosRule;
			size = new Size(161, 20);
			arg_1366_0.Size = size;
			this.cbxDiagnosRule.TabIndex = 56;
			Control arg_1390_0 = this.ckbAllRuleParams;
			point = new Point(250, 208);
			arg_1390_0.Location = point;
			this.ckbAllRuleParams.Name = "ckbAllRuleParams";
			Control arg_13B7_0 = this.ckbAllRuleParams;
			size = new Size(64, 23);
			arg_13B7_0.Size = size;
			this.ckbAllRuleParams.TabIndex = 55;
			this.ckbAllRuleParams.Text = "全选";
			Control arg_13EE_0 = this.cklRuleParamsList;
			point = new Point(250, 73);
			arg_13EE_0.Location = point;
			this.cklRuleParamsList.Name = "cklRuleParamsList";
			Control arg_141B_0 = this.cklRuleParamsList;
			size = new Size(232, 132);
			arg_141B_0.Size = size;
			this.cklRuleParamsList.TabIndex = 54;
			Control arg_1442_0 = this.btnMaintain;
			point = new Point(250, 10);
			arg_1442_0.Location = point;
			this.btnMaintain.Name = "btnMaintain";
			Control arg_1469_0 = this.btnMaintain;
			size = new Size(75, 23);
			arg_1469_0.Size = size;
			this.btnMaintain.TabIndex = 53;
			this.btnMaintain.Text = "病种维护";
			this.btnMaintain.UseVisualStyleBackColor = true;
			Control arg_14AF_0 = this.btnModify;
			point = new Point(407, 208);
			arg_14AF_0.Location = point;
			this.btnModify.Name = "btnModify";
			Control arg_14D6_0 = this.btnModify;
			size = new Size(75, 23);
			arg_14D6_0.Size = size;
			this.btnModify.TabIndex = 52;
			this.btnModify.Text = "修改<<";
			Control arg_1510_0 = this.btAdd;
			point = new Point(168, 208);
			arg_1510_0.Location = point;
			this.btAdd.Name = "btAdd";
			Control arg_1537_0 = this.btAdd;
			size = new Size(75, 23);
			arg_1537_0.Size = size;
			this.btAdd.TabIndex = 51;
			this.btAdd.Text = "新增>>";
			this.ckbAllDiagnosRules.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_1579_0 = this.ckbAllDiagnosRules;
			point = new Point(7, 369);
			arg_1579_0.Location = point;
			this.ckbAllDiagnosRules.Name = "ckbAllDiagnosRules";
			Control arg_15A0_0 = this.ckbAllDiagnosRules;
			size = new Size(64, 23);
			arg_15A0_0.Size = size;
			this.ckbAllDiagnosRules.TabIndex = 50;
			this.ckbAllDiagnosRules.Text = "全选";
			this.cklDiagnosRulesList.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_15E2_0 = this.cklDiagnosRulesList;
			point = new Point(7, 234);
			arg_15E2_0.Location = point;
			this.cklDiagnosRulesList.Name = "cklDiagnosRulesList";
			Control arg_160F_0 = this.cklDiagnosRulesList;
			size = new Size(475, 132);
			arg_160F_0.Size = size;
			this.cklDiagnosRulesList.TabIndex = 48;
			Control arg_1635_0 = this.ckbAllDiagnos;
			point = new Point(7, 208);
			arg_1635_0.Location = point;
			this.ckbAllDiagnos.Name = "ckbAllDiagnos";
			Control arg_165C_0 = this.ckbAllDiagnos;
			size = new Size(64, 23);
			arg_165C_0.Size = size;
			this.ckbAllDiagnos.TabIndex = 47;
			this.ckbAllDiagnos.Text = "全选";
			Control arg_168F_0 = this.cklDiagnosList;
			point = new Point(7, 73);
			arg_168F_0.Location = point;
			this.cklDiagnosList.Name = "cklDiagnosList";
			Control arg_16BC_0 = this.cklDiagnosList;
			size = new Size(237, 132);
			arg_16BC_0.Size = size;
			this.cklDiagnosList.TabIndex = 46;
			this.cbxCtLoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbxCtLoc.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbxCtLoc.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxCtLoc.FormattingEnabled = true;
			Control arg_1714_0 = this.cbxCtLoc;
			point = new Point(74, 10);
			arg_1714_0.Location = point;
			this.cbxCtLoc.Name = "cbxCtLoc";
			Control arg_173E_0 = this.cbxCtLoc;
			size = new Size(170, 20);
			arg_173E_0.Size = size;
			this.cbxCtLoc.TabIndex = 45;
			Control arg_1761_0 = this.Label1;
			point = new Point(0, 46);
			arg_1761_0.Location = point;
			this.Label1.Name = "Label1";
			Control arg_1788_0 = this.Label1;
			size = new Size(70, 20);
			arg_1788_0.Size = size;
			this.Label1.TabIndex = 43;
			this.Label1.Text = "所有疾病：";
			this.Label1.TextAlign = ContentAlignment.MiddleRight;
			Control arg_17C8_0 = this.Label2;
			point = new Point(0, 11);
			arg_17C8_0.Location = point;
			this.Label2.Name = "Label2";
			Control arg_17EF_0 = this.Label2;
			size = new Size(70, 20);
			arg_17EF_0.Size = size;
			this.Label2.TabIndex = 44;
			this.Label2.Text = "所在科室：";
			this.Label2.TextAlign = ContentAlignment.MiddleRight;
			Control arg_1833_0 = this.btnInUse;
			point = new Point(434, 13);
			arg_1833_0.Location = point;
			this.btnInUse.Name = "btnInUse";
			Control arg_185A_0 = this.btnInUse;
			size = new Size(60, 23);
			arg_185A_0.Size = size;
			this.btnInUse.TabIndex = 34;
			this.btnInUse.Text = "停 用";
			this.Controls.Add(this.tbEdit);
			this.Controls.Add(this.gbNodeName);
			this.Name = "DCKBNode";
			size = new Size(496, 512);
			this.Size = size;
			this.gbNodeName.ResumeLayout(false);
			this.gbNodeName.PerformLayout();
			this.tbEdit.ResumeLayout(false);
			this.tpContent.ResumeLayout(false);
			this.Pa3.ResumeLayout(false);
			this.Pa2.ResumeLayout(false);
			this.Pa1.ResumeLayout(false);
			this.tpDiagnos.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void SetBtnEnable(string KBTreeID)
		{
			bool enabled = !this._EnableRoleKBTree || -1 < this._KbIDs.IndexOf(KBTreeID);
			this.btnSave.Enabled = enabled;
			this.btnCancelPublic.Enabled = enabled;
			this.btnInUse.Enabled = enabled;
		}

		public void SetRoleKBTree(bool enableRoleKBTree, ref List<string> kbIDs)
		{
			this._EnableRoleKBTree = enableRoleKBTree;
			this._KbIDs = kbIDs;
		}

		private void InitSegmentEdit()
		{
			checked
			{
				this.tbEdit.Height = this.Height - this.gbNodeName.Height - 5;
				if (this._EKnowledgeBase.SegmentNumber == 1L)
				{
					this.InitSegmentEdit1();
					this.SegmentEdit1.Height = this.tpContent.Height - this.Pa1.Height - 10;
					this.SegmentEdit1.Width = this.tpContent.Width - 30;
				}
				else if (this._EKnowledgeBase.SegmentNumber == 2L)
				{
					this.InitSegmentEdit1();
					this.InitSegmentEdit2();
					this.SegmentEdit1.Height = (int)Math.Round(unchecked((double)(checked(this.tpContent.Height - this.Pa1.Height - this.Pa2.Height)) / 2.0 - 10.0));
					this.SegmentEdit1.Width = this.tpContent.Width - 30;
					this.Pa2.Top = this.SegmentEdit1.Height + this.Pa1.Height;
					this.SegmentEdit2.Top = this.Pa2.Top + this.Pa2.Height + 1;
					this.SegmentEdit2.Height = this.tpContent.Height - this.Pa1.Height - this.Pa2.Height - this.SegmentEdit1.Height - 5;
					this.SegmentEdit2.Width = this.SegmentEdit1.Width;
				}
				else if (this._EKnowledgeBase.SegmentNumber == 3L)
				{
					this.InitSegmentEdit1();
					this.InitSegmentEdit2();
					this.InitSegmentEdit3();
					this.SegmentEdit1.Height = (int)Math.Round(unchecked((double)(checked(this.tpContent.Height - this.Pa1.Height - this.Pa2.Height - this.Pa3.Height)) / 3.0 - 5.0));
					this.SegmentEdit1.Width = this.tpContent.Width - 30;
					this.Pa2.Top = this.SegmentEdit1.Height + this.Pa1.Height;
					this.SegmentEdit2.Top = this.Pa2.Top + this.Pa2.Height + 1;
					this.SegmentEdit2.Width = this.SegmentEdit1.Width;
					this.SegmentEdit2.Height = this.SegmentEdit1.Height;
					this.Pa3.Top = this.SegmentEdit2.Top + this.SegmentEdit2.Height + 1;
					this.SegmentEdit3.Top = this.Pa3.Top + this.Pa3.Height + 1;
					this.SegmentEdit3.Height = this.SegmentEdit1.Height;
					this.SegmentEdit3.Width = this.SegmentEdit1.Width;
				}
			}
		}

		private void InitSegmentEdit1()
		{
			if (this._EKBNode.S1MetaData == null | Operators.CompareString(this._EKBNode.S1MetaData, "", false) == 0)
			{
				MISegment mISegment = new MISegment();
				mISegment.Init();
				mISegment.KBNodeID = this._EKBNode.ID;
				mISegment.SegmentNumber = "1";
				mISegment.Text = this._EKBNode.Name + "|" + this._EKnowledgeBase.S1Name;
				NISegment nISegment = new NISegment();
				nISegment.KBNodeID = this._EKBNode.ID;
				nISegment.SegmentNumber = "1";
				nISegment.Code = mISegment.Code;
				nISegment.SyncMetaItem(mISegment);
				this.SegmentEdit1.BindInstanceItem = nISegment;
			}
			else
			{
				MISegment mISegment2 = new MISegment();
				mISegment2.XMLString = this._EKBNode.S1MetaData;
				NISegment nISegment2 = new NISegment();
				nISegment2.XMLString = this._EKBNode.S1InstanceData;
				nISegment2.SyncMetaItem(mISegment2);
				this.SegmentEdit1.BindInstanceItem = nISegment2;
			}
		}

		private void InitSegmentEdit2()
		{
			if (this._EKBNode.S2MetaData == null | Operators.CompareString(this._EKBNode.S2MetaData, "", false) == 0)
			{
				MISegment mISegment = new MISegment();
				mISegment.Init();
				mISegment.KBNodeID = this._EKBNode.ID;
				mISegment.SegmentNumber = "2";
				mISegment.Text = this._EKBNode.Name + "|" + this._EKnowledgeBase.S2Name;
				NISegment nISegment = new NISegment();
				nISegment.KBNodeID = this._EKBNode.ID;
				nISegment.SegmentNumber = "2";
				nISegment.Code = mISegment.Code;
				nISegment.SyncMetaItem(mISegment);
				this.SegmentEdit2.BindInstanceItem = nISegment;
			}
			else
			{
				MISegment mISegment2 = new MISegment();
				mISegment2.XMLString = this._EKBNode.S2MetaData;
				NISegment nISegment2 = new NISegment();
				nISegment2.XMLString = this._EKBNode.S2InstanceData;
				nISegment2.SyncMetaItem(mISegment2);
				this.SegmentEdit2.BindInstanceItem = nISegment2;
			}
		}

		private void InitSegmentEdit3()
		{
			if (this._EKBNode.S3MetaData == null | Operators.CompareString(this._EKBNode.S3MetaData, "", false) == 0)
			{
				MISegment mISegment = new MISegment();
				mISegment.Init();
				mISegment.KBNodeID = this._EKBNode.ID;
				mISegment.SegmentNumber = "3";
				mISegment.Text = this._EKBNode.Name + "|" + this._EKnowledgeBase.S3Name;
				NISegment nISegment = new NISegment();
				nISegment.KBNodeID = this._EKBNode.ID;
				nISegment.SegmentNumber = "3";
				nISegment.Code = mISegment.Code;
				nISegment.SyncMetaItem(mISegment);
				this.SegmentEdit3.BindInstanceItem = nISegment;
			}
			else
			{
				MISegment mISegment2 = new MISegment();
				mISegment2.XMLString = this._EKBNode.S3MetaData;
				NISegment nISegment2 = new NISegment();
				nISegment2.XMLString = this._EKBNode.S3InstanceData;
				nISegment2.SyncMetaItem(mISegment2);
				this.SegmentEdit3.BindInstanceItem = nISegment2;
			}
		}

		private string ReplaceXmlStrKbNodeId(string AReplaceStr, string StrFlag, string ANodeId)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(AReplaceStr);
			if (Operators.CompareString(StrFlag, "InstanceData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//NISegment/KBNodeID");
				xmlNode.InnerText = ANodeId;
			}
			else if (Operators.CompareString(StrFlag, "MetaData", false) == 0)
			{
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//MISegment/KBNodeID");
				xmlNode.InnerText = ANodeId;
			}
			return xmlDocument.OuterXml;
		}

		private void btnEdit1_Click(object sender, EventArgs e)
		{
			SegmentEditForm segmentEditForm = new SegmentEditForm();
			MISegment mISegment = (MISegment)this.SegmentEdit1.BindInstanceItem.BindMMetaItem.Clone();
			NISegment nISegment = (NISegment)this.SegmentEdit1.BindInstanceItem.Clone();
			nISegment.SyncMetaItem(mISegment);
			segmentEditForm.DCMetaData.MetaItem = mISegment;
			segmentEditForm.DCMetaData.InstanceItem = nISegment;
			if (segmentEditForm.ShowDialog() == DialogResult.OK)
			{
				this.SegmentEdit1.BindInstanceItem = segmentEditForm.DCMetaData.InstanceItem;
				this.SegmentEdit1.ReDraw();
				this._Reviced = true;
			}
		}

		private void btnEdit2_Click(object sender, EventArgs e)
		{
			SegmentEditForm segmentEditForm = new SegmentEditForm();
			MISegment mISegment = (MISegment)this.SegmentEdit2.BindInstanceItem.BindMMetaItem.Clone();
			NISegment nISegment = (NISegment)this.SegmentEdit2.BindInstanceItem.Clone();
			nISegment.SyncMetaItem(mISegment);
			segmentEditForm.DCMetaData.MetaItem = mISegment;
			segmentEditForm.DCMetaData.InstanceItem = nISegment;
			if (segmentEditForm.ShowDialog() == DialogResult.OK)
			{
				this.SegmentEdit2.BindInstanceItem = segmentEditForm.DCMetaData.InstanceItem;
				this.SegmentEdit2.ReDraw();
				this._Reviced = true;
			}
		}

		private void btnEdit3_Click(object sender, EventArgs e)
		{
			SegmentEditForm segmentEditForm = new SegmentEditForm();
			MISegment mISegment = (MISegment)this.SegmentEdit3.BindInstanceItem.BindMMetaItem.Clone();
			NISegment nISegment = (NISegment)this.SegmentEdit3.BindInstanceItem.Clone();
			nISegment.SyncMetaItem(mISegment);
			segmentEditForm.DCMetaData.MetaItem = mISegment;
			segmentEditForm.DCMetaData.InstanceItem = nISegment;
			if (segmentEditForm.ShowDialog() == DialogResult.OK)
			{
				this.SegmentEdit3.BindInstanceItem = segmentEditForm.DCMetaData.InstanceItem;
				this.SegmentEdit3.ReDraw();
				this._Reviced = true;
			}
		}

		private void txtNodeName_TextChanged(object sender, EventArgs e)
		{
			if (this.SegmentEdit1.BindInstanceItem != null)
			{
				this.SegmentEdit1.BindInstanceItem.BindMMetaItem.Text = this.txtNodeName.Text + "|" + this._EKnowledgeBase.S1Name;
			}
			if (this.SegmentEdit2.BindInstanceItem != null)
			{
				this.SegmentEdit2.BindInstanceItem.BindMMetaItem.Text = this.txtNodeName.Text + "|" + this._EKnowledgeBase.S2Name;
			}
			if (this.SegmentEdit3.BindInstanceItem != null)
			{
				this.SegmentEdit3.BindInstanceItem.BindMMetaItem.Text = this.txtNodeName.Text + "|" + this._EKnowledgeBase.S3Name;
			}
			this._Reviced = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.txtNodeName.Text == null || Operators.CompareString(this.txtNodeName.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("名称不能为空！");
			}
			else
			{
				this.Save(EPRStatus.Publish);
				MessageManager.ShowInformationMessage("保存成功！");
				KBTree.ConstKBTree.UpdateNodeName(this.txtNodeName.Text);
			}
		}

		private void btnCancelPublic_Click(object sender, EventArgs e)
		{
			if (this.txtNodeName.Text == null || Operators.CompareString(this.txtNodeName.Text, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("名称不能为空！");
			}
			else
			{
				this.Save(EPRStatus.Create);
				MessageManager.ShowInformationMessage("已取消发布！");
			}
		}

		private void Save(EPRStatus eprStatus)
		{
			this._EKBNode.Name = this.txtNodeName.Text;
			this._EKBNode.Description = this.txtNodeDesc.Text;
			this._EKBNode.IsCommon = Conversions.ToString(Interaction.IIf(this.chkCommon.Checked, "Y", "N"));
			this._EKBNode.IsInUse = Conversions.ToString(Interaction.IIf(Operators.CompareString("停用", this.btnInUse.Text, false) == 0, "Y", "N"));
			if (this.SegmentEdit1.BindInstanceItem != null)
			{
				this.SegmentEdit1.BindInstanceItem.BindMMetaItem.Status = eprStatus;
				this._EKBNode.S1MetaData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit1.BindInstanceItem.BindMMetaItem.XMLString, "MetaData", this._EKBNode.ID);
				this._EKBNode.S1InstanceData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit1.BindInstanceItem.XMLString, "InstanceData", this._EKBNode.ID);
			}
			if (this.SegmentEdit2.BindInstanceItem != null)
			{
				this.SegmentEdit2.BindInstanceItem.BindMMetaItem.Status = eprStatus;
				this._EKBNode.S2MetaData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit2.BindInstanceItem.BindMMetaItem.XMLString, "MetaData", this._EKBNode.ID);
				this._EKBNode.S2InstanceData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit2.BindInstanceItem.XMLString, "InstanceData", this._EKBNode.ID);
			}
			if (this.SegmentEdit3.BindInstanceItem != null)
			{
				this.SegmentEdit3.BindInstanceItem.BindMMetaItem.Status = eprStatus;
				this._EKBNode.S3MetaData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit3.BindInstanceItem.BindMMetaItem.XMLString, "MetaData", this._EKBNode.ID);
				this._EKBNode.S3InstanceData = this.ReplaceXmlStrKbNodeId(this.SegmentEdit3.BindInstanceItem.XMLString, "InstanceData", this._EKBNode.ID);
			}
			try
			{
				KBNodeInfo arg_23D_0 = WebServiceLayer.KBNodeAccess;
				EKBNode arg_23D_1 = this._EKBNode;
				bool flag = true;
				bool flag2;
				arg_23D_0.UpdateKBNode(arg_23D_1, ref flag2, ref flag);
			}
			catch (Exception expr_244)
			{
				ProjectData.SetProjectError(expr_244);
				Exception ex = expr_244;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
			this._SegmentEdit1.ClearUndo();
			this._SegmentEdit2.ClearUndo();
			this._SegmentEdit3.ClearUndo();
			this._Reviced = false;
		}

		private void txtNodeDesc_TextChanged(object sender, EventArgs e)
		{
			this._Reviced = true;
		}

		private void SaveDiagnosConfig()
		{
			checked
			{
				try
				{
					string text = string.Empty;
					if (this.cklDiagnosRulesList.Items.Count > 0)
					{
						int arg_2D_0 = 0;
						int num = this.cklDiagnosRulesList.Items.Count - 1;
						for (int i = arg_2D_0; i <= num; i++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, NewLateBinding.LateGet(this.cklDiagnosRulesList.Items[i], null, "RowId", new object[0], null, null, null)), "^"));
						}
					}
					text = text.TrimEnd(new char[]
					{
						'^'
					});
					WebServiceLayer.KBDiagnosConfigAccess.SaveBindDiagnos(this._EKBNode.ID, text, this._EKBNode.KBTreeID);
				}
				catch (Exception expr_AD)
				{
					ProjectData.SetProjectError(expr_AD);
					MessageManager.ShowInformationMessage("疾病对应关系存储不成功");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void btnMaintain_Click(object sender, EventArgs e)
		{
			object expr_0B = this.cbxCtLoc.SelectedItem;
			checkListItem checkListItem;
			string rowId = ((expr_0B != null) ? ((checkListItem)expr_0B) : checkListItem).RowId;
			DialogResult dialogResult = new DiagnosForm(rowId, this.CTLogID, this.IsPersonlKBNode)
			{
				ShowInTaskbar = false
			}.ShowDialog();
			if (dialogResult.Equals(DialogResult.OK) && this.cbxCtLoc.SelectedItem != null)
			{
				object expr_73 = this.cbxCtLoc.SelectedItem;
				this.LoadDiagnosCheckBoxList(((expr_73 != null) ? ((checkListItem)expr_73) : checkListItem).RowId.ToString());
			}
		}

		private void InitDiagnosTab(string kbNodeID)
		{
			this.cbxCtLoc.Items.Clear();
			this.cbxDiagnosRule.Items.Clear();
			this.cklDiagnosList.Items.Clear();
			this.cklRuleParamsList.Items.Clear();
			this.cklDiagnosRulesList.Items.Clear();
			this.ckbAllDiagnos.Checked = false;
			this.ckbAllRuleParams.Checked = false;
			this.ckbAllDiagnosRules.Checked = false;
			this.InitCtLocComboBox();
			this.InitDiagnosRuleComboBox();
			this.InitDiagnosRuleCheckBoxList(kbNodeID);
		}

		private void InitCtLocComboBox()
		{
			string text = string.Format("^{0}^", this._CTLogID);
			DataSet allLoc = WebServiceLayer.KbConfigAccess.GetAllLoc();
			try
			{
				IEnumerator enumerator = allLoc.Tables[0].Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					string value = string.Format("^{0}^", dataRow["RowId"].ToString());
					if (this._CTLogID == null || text.Contains(value))
					{
						checkListItem checkListItem;
						checkListItem.RowId = dataRow["RowId"].ToString();
						checkListItem.Code = dataRow["Code"].ToString();
						checkListItem.Desc = dataRow["Des"].ToString();
						this.cbxCtLoc.Items.Add(checkListItem);
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
			if (this.cbxCtLoc.Items.Count > 0)
			{
				this.cbxCtLoc.SelectedIndex = 0;
			}
		}

		private void InitDiagnosRuleComboBox()
		{
			EStdDictionaryDataset eStdDictionaryDataset = WebServiceLayer.DictionaryAccess.SelectALLStdDic();
			try
			{
				IEnumerator enumerator = eStdDictionaryDataset.Tables[0].Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.CompareString(dataRow["IsDiagnosRuleType"].ToString(), "Y", false) == 0 && !string.IsNullOrEmpty(dataRow["RuleTypeTag"].ToString()))
					{
						DictionaryEntry dictionaryEntry = new DictionaryEntry(dataRow["ID"].ToString(), dataRow["Description"].ToString());
						this.cbxDiagnosRule.Items.Add(dictionaryEntry);
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
			this.cbxDiagnosRule.ValueMember = "Key";
			this.cbxDiagnosRule.DisplayMember = "Value";
			if (this.cbxDiagnosRule.Items.Count > 0)
			{
				this.cbxDiagnosRule.SelectedIndex = 0;
			}
		}

		private void InitDiagnosRuleCheckBoxList(string kbNodeID)
		{
			this.cklDiagnosRulesList.Items.Clear();
			string kBNodeDiagnosWithRules = WebServiceLayer.KBDiagnosConfigAccess.GetKBNodeDiagnosWithRules(kbNodeID);
			checked
			{
				if (!string.IsNullOrEmpty(kBNodeDiagnosWithRules))
				{
					string[] array = kBNodeDiagnosWithRules.Split(new char[]
					{
						'$'
					});
					int arg_46_0 = 0;
					int num = array.Length - 1;
					for (int i = arg_46_0; i <= num; i++)
					{
						KBNodeDiagnosRule kBNodeDiagnosRule = default(KBNodeDiagnosRule);
						string text = array[i];
						if (!string.IsNullOrEmpty(text))
						{
							string[] array2 = text.Split(new char[]
							{
								'^'
							});
							string kBNodeDiagnosID = array2[0];
							string text2 = array2[1];
							string text3 = array2[2];
							string diagnosID = array2[3];
							string text4 = array2[4];
							kBNodeDiagnosRule.DiagnosID = diagnosID;
							kBNodeDiagnosRule.KBNodeDiagnosID = kBNodeDiagnosID;
							if (array2.Length > 5)
							{
								string text5 = array2[5];
								string[] array3 = text5.Split(new char[]
								{
									'?'
								});
								int arg_DD_0 = 0;
								int num2 = array3.Length - 1;
								for (int j = arg_DD_0; j <= num2; j++)
								{
									string text6 = array3[j];
									string[] array4 = text6.Split(new char[]
									{
										'|'
									});
									string key = array4[0];
									string text7 = array4[1];
									string text8 = array4[2];
									List<DictionaryEntry> list = new List<DictionaryEntry>();
									string[] array5 = text8.Split(new char[]
									{
										'*'
									});
									int arg_13F_0 = 0;
									int num3 = array5.Length - 1;
									for (int k = arg_13F_0; k <= num3; k++)
									{
										string text9 = array5[k];
										string key2 = text9.Split(new char[]
										{
											'='
										})[0];
										string value = text9.Split(new char[]
										{
											'='
										})[1];
										DictionaryEntry item = new DictionaryEntry(key2, value);
										list.Add(item);
									}
									kBNodeDiagnosRule.DiagnosRulePairs = new Dictionary<string, List<DictionaryEntry>>
									{
										{
											key,
											list
										}
									};
								}
							}
							this.cklDiagnosRulesList.Items.Add(kBNodeDiagnosRule);
						}
					}
				}
			}
		}

		private void LoadDiagnosCheckBoxList(string ctLocID)
		{
			this.cklDiagnosList.Items.Clear();
			EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable getDiagnosByCtLocIDDataTable = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable)WebServiceLayer.KBDiagnosAccess.GetDiagnosByCtLocID(ctLocID).Tables[0];
			try
			{
				IEnumerator enumerator = getDiagnosByCtLocIDDataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					checkListItem checkListItem;
					checkListItem.RowId = dataRow["ID"].ToString();
					checkListItem.Code = dataRow["Name"].ToString();
					checkListItem.Desc = dataRow["Description"].ToString();
					this.cklDiagnosList.Items.Add(checkListItem);
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

		private void LoadRuleParamsCheckBoxList(string ruleID, string ruleDesc)
		{
			this.cklRuleParamsList.Items.Clear();
			DataTable dataTable = WebServiceLayer.TPrivRuleTypeAccess.GetRuleTypeDetails(ruleID).Tables[0];
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					RuleParamItem ruleParamItem = default(RuleParamItem);
					ruleParamItem.RuleID = ruleID;
					ruleParamItem.RuleDesc = ruleDesc;
					ruleParamItem.RuleParamCode = dataRow[0].ToString();
					ruleParamItem.RuleParamDesc = dataRow[1].ToString();
					this.cklRuleParamsList.Items.Add(ruleParamItem);
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

		private void cbxCtLoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxCtLoc.SelectedItem != null)
			{
				object expr_18 = this.cbxCtLoc.SelectedItem;
				checkListItem checkListItem;
				this.LoadDiagnosCheckBoxList(((expr_18 != null) ? ((checkListItem)expr_18) : checkListItem).RowId.ToString());
			}
		}

		private void cbxDiagnosRule_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxDiagnosRule.SelectedItem != null)
			{
				object expr_18 = this.cbxDiagnosRule.SelectedItem;
				DictionaryEntry dictionaryEntry2;
				DictionaryEntry dictionaryEntry = (expr_18 != null) ? ((DictionaryEntry)expr_18) : dictionaryEntry2;
				this.LoadRuleParamsCheckBoxList(Conversions.ToString(dictionaryEntry.Key), Conversions.ToString(dictionaryEntry.Value));
			}
		}

		private void btAdd_Click(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = this.cklDiagnosList.CheckedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object expr_1E = enumerator.Current;
					checkListItem checkListItem2;
					checkListItem checkListItem = (expr_1E != null) ? ((checkListItem)expr_1E) : checkListItem2;
					bool flag = false;
					string rowId = checkListItem.RowId;
					try
					{
						IEnumerator enumerator2 = this.cklDiagnosRulesList.Items.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							object expr_56 = enumerator2.Current;
							KBNodeDiagnosRule kBNodeDiagnosRule;
							if (((expr_56 != null) ? ((KBNodeDiagnosRule)expr_56) : kBNodeDiagnosRule).DiagnosID.Equals(rowId))
							{
								flag = true;
							}
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
					if (!flag)
					{
						string kBNodeDiagnosID = WebServiceLayer.KBDiagnosConfigAccess.InsertNode(this._EKBNode.ID, rowId, this._EKBNode.KBTreeID);
						KBNodeDiagnosRule kBNodeDiagnosRule2 = default(KBNodeDiagnosRule);
						kBNodeDiagnosRule2.DiagnosID = rowId;
						kBNodeDiagnosRule2.KBNodeDiagnosID = kBNodeDiagnosID;
						kBNodeDiagnosRule2.DiagnosRulePairs = new Dictionary<string, List<DictionaryEntry>>();
						this.cklDiagnosRulesList.Items.Add(kBNodeDiagnosRule2);
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

		private void btnModify_Click(object sender, EventArgs e)
		{
			if (this.cklRuleParamsList.CheckedItems.Count == 0)
			{
				MessageManager.ShowInformationMessage("请勾选规则参数!");
				return;
			}
			if (this.cklDiagnosRulesList.CheckedItems.Count == 0)
			{
				MessageManager.ShowInformationMessage("请勾选已选病种!");
				return;
			}
			try
			{
				IEnumerator enumerator = this.cklDiagnosRulesList.CheckedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object expr_58 = enumerator.Current;
					KBNodeDiagnosRule kBNodeDiagnosRule2;
					KBNodeDiagnosRule kBNodeDiagnosRule = (expr_58 != null) ? ((KBNodeDiagnosRule)expr_58) : kBNodeDiagnosRule2;
					try
					{
						IEnumerator enumerator2 = this.cklRuleParamsList.CheckedItems.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							object expr_89 = enumerator2.Current;
							RuleParamItem ruleParamItem2;
							RuleParamItem ruleParamItem = (expr_89 != null) ? ((RuleParamItem)expr_89) : ruleParamItem2;
							if (kBNodeDiagnosRule.DiagnosRulePairs != null)
							{
								if (kBNodeDiagnosRule.DiagnosRulePairs.ContainsKey(ruleParamItem.RuleID))
								{
									DictionaryEntry item = new DictionaryEntry(ruleParamItem.RuleParamCode, ruleParamItem.RuleParamDesc);
									if (!kBNodeDiagnosRule.DiagnosRulePairs[ruleParamItem.RuleID].Contains(item))
									{
										WebServiceLayer.KBNodeDiagnosRuleAccess.Insert(kBNodeDiagnosRule.KBNodeDiagnosID, ruleParamItem.RuleID, ruleParamItem.RuleParamCode, ruleParamItem.RuleParamDesc);
									}
								}
								else
								{
									WebServiceLayer.KBNodeDiagnosRuleAccess.Insert(kBNodeDiagnosRule.KBNodeDiagnosID, ruleParamItem.RuleID, ruleParamItem.RuleParamCode, ruleParamItem.RuleParamDesc);
								}
							}
							else
							{
								WebServiceLayer.KBNodeDiagnosRuleAccess.Insert(kBNodeDiagnosRule.KBNodeDiagnosID, ruleParamItem.RuleID, ruleParamItem.RuleParamCode, ruleParamItem.RuleParamDesc);
							}
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
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.InitDiagnosRuleCheckBoxList(this._KBNodeID);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = this.cklDiagnosRulesList.CheckedItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object expr_1E = enumerator.Current;
						KBNodeDiagnosRule kBNodeDiagnosRule2;
						KBNodeDiagnosRule kBNodeDiagnosRule = (expr_1E != null) ? ((KBNodeDiagnosRule)expr_1E) : kBNodeDiagnosRule2;
						if (kBNodeDiagnosRule.DiagnosRulePairs != null && kBNodeDiagnosRule.DiagnosRulePairs.Count > 0)
						{
							try
							{
								Dictionary<string, List<DictionaryEntry>>.KeyCollection.Enumerator enumerator2 = kBNodeDiagnosRule.DiagnosRulePairs.Keys.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									string current = enumerator2.Current;
									List<DictionaryEntry> list = kBNodeDiagnosRule.DiagnosRulePairs[current];
									int arg_85_0 = 0;
									int num = list.Count - 1;
									for (int i = arg_85_0; i <= num; i++)
									{
										DictionaryEntry dictionaryEntry = list[i];
										WebServiceLayer.KBNodeDiagnosRuleAccess.Delete(kBNodeDiagnosRule.KBNodeDiagnosID, current, Conversions.ToString(dictionaryEntry.Key));
									}
								}
							}
							finally
							{
								Dictionary<string, List<DictionaryEntry>>.KeyCollection.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						try
						{
							WebServiceLayer.KBDiagnosConfigAccess.Delete(kBNodeDiagnosRule.KBNodeDiagnosID);
						}
						catch (Exception expr_EA)
						{
							ProjectData.SetProjectError(expr_EA);
							Exception ex = expr_EA;
							MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
							ProjectData.ClearProjectError();
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
				this.InitDiagnosRuleCheckBoxList(this._KBNodeID);
			}
		}

		private void InitSelectAllCheck()
		{
			if (this.cklDiagnosList.Items.Count != 0 && this.cklDiagnosList.SelectedItems.Count == this.cklDiagnosList.Items.Count)
			{
				this.ckbAllDiagnos.Checked = true;
			}
			else
			{
				this.ckbAllDiagnos.Checked = false;
			}
			if (this.cklDiagnosRulesList.Items.Count != 0 && this.cklDiagnosRulesList.SelectedItems.Count == this.cklDiagnosRulesList.Items.Count)
			{
				this.ckbAllDiagnosRules.Checked = true;
			}
			else
			{
				this.ckbAllDiagnosRules.Checked = false;
			}
		}

		private void ckbAllDiagnos_CheckedChanged(object sender, EventArgs e)
		{
			int arg_14_0 = 0;
			checked
			{
				int num = this.cklDiagnosList.Items.Count - 1;
				for (int i = arg_14_0; i <= num; i++)
				{
					this.cklDiagnosList.SetItemChecked(i, this.ckbAllDiagnos.Checked);
				}
			}
		}

		private void ckbAllRuleParams_CheckedChanged(object sender, EventArgs e)
		{
			int arg_14_0 = 0;
			checked
			{
				int num = this.cklRuleParamsList.Items.Count - 1;
				for (int i = arg_14_0; i <= num; i++)
				{
					this.cklRuleParamsList.SetItemChecked(i, this.ckbAllRuleParams.Checked);
				}
			}
		}

		private void ckbAllDiagnosRules_CheckedChanged(object sender, EventArgs e)
		{
			int arg_14_0 = 0;
			checked
			{
				int num = this.cklDiagnosRulesList.Items.Count - 1;
				for (int i = arg_14_0; i <= num; i++)
				{
					this.cklDiagnosRulesList.SetItemChecked(i, this.ckbAllDiagnosRules.Checked);
				}
			}
		}

		private void btnInUse_Click(object sender, EventArgs e)
		{
			this.btnInUse.Text = Conversions.ToString(Interaction.IIf(this.btnInUse.Text.Equals("启用"), "停用", "启用"));
		}
	}
}
