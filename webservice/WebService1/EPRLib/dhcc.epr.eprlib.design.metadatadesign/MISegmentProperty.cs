using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using MRDiagnosData;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MISegmentProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("cbxNormal")]
		private CheckBox _cbxNormal;

		[AccessedThroughProperty("btnSwap")]
		private Button _btnSwap;

		[AccessedThroughProperty("cbDiagnosType")]
		private ComboBox _cbDiagnosType;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("chkStopRaiseVChanged")]
		private CheckBox _chkStopRaiseVChanged;

		[AccessedThroughProperty("cbxFixedStructs")]
		private CheckBox _cbxFixedStructs;

		[AccessedThroughProperty("PCTextEdit")]
		private PCTextEdit _PCTextEdit;

		[AccessedThroughProperty("AbPCTextEdit")]
		private PCTextEdit _AbPCTextEdit;

		[AccessedThroughProperty("SegmentTabs")]
		private TabControlAdv _SegmentTabs;

		[AccessedThroughProperty("NormalTab")]
		private TabPageAdv _NormalTab;

		[AccessedThroughProperty("AbNormalTab")]
		private TabPageAdv _AbNormalTab;

		public MetaItemTree MetaItemTree;

		private MISegment _MISegment;

		private NInstanceItem _DragInstanceItem;

		private int DragEnterSelectionStart;

		private NISegment _BindNISegment;

		private NISegment _AbNISegment;

		private string GCbDiagnosType;

		internal virtual CheckBox cbxNormal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxNormal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxNormal_CheckedChanged);
				if (this._cbxNormal != null)
				{
					this._cbxNormal.CheckedChanged -= value2;
				}
				this._cbxNormal = value;
				if (this._cbxNormal != null)
				{
					this._cbxNormal.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button btnSwap
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSwap;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSwap_Click);
				if (this._btnSwap != null)
				{
					this._btnSwap.Click -= value2;
				}
				this._btnSwap = value;
				if (this._btnSwap != null)
				{
					this._btnSwap.Click += value2;
				}
			}
		}

		internal virtual ComboBox cbDiagnosType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbDiagnosType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbDiagnosType_SelectedValueChanged);
				if (this._cbDiagnosType != null)
				{
					this._cbDiagnosType.SelectedValueChanged -= value2;
				}
				this._cbDiagnosType = value;
				if (this._cbDiagnosType != null)
				{
					this._cbDiagnosType.SelectedValueChanged += value2;
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

		internal virtual CheckBox chkStopRaiseVChanged
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkStopRaiseVChanged;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkStopRaiseVChanged_CheckedChanged);
				if (this._chkStopRaiseVChanged != null)
				{
					this._chkStopRaiseVChanged.CheckedChanged -= value2;
				}
				this._chkStopRaiseVChanged = value;
				if (this._chkStopRaiseVChanged != null)
				{
					this._chkStopRaiseVChanged.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxFixedStructs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxFixedStructs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxFixedStructs_CheckedChanged);
				if (this._cbxFixedStructs != null)
				{
					this._cbxFixedStructs.CheckedChanged -= value2;
				}
				this._cbxFixedStructs = value;
				if (this._cbxFixedStructs != null)
				{
					this._cbxFixedStructs.CheckedChanged += value2;
				}
			}
		}

		public virtual PCTextEdit PCTextEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCTextEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PCTextEdit = value;
			}
		}

		public virtual PCTextEdit AbPCTextEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AbPCTextEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AbPCTextEdit = value;
			}
		}

		public virtual TabControlAdv SegmentTabs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SegmentTabs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SegmentTabs = value;
			}
		}

		public virtual TabPageAdv NormalTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NormalTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NormalTab = value;
			}
		}

		public virtual TabPageAdv AbNormalTab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AbNormalTab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AbNormalTab = value;
			}
		}

		public MISegment MISegment
		{
			get
			{
				return this._MISegment;
			}
			set
			{
				this._MISegment = value;
				this._BindNISegment = (NISegment)this._MISegment.BindInstanceItem;
				this.GCbDiagnosType = this._MISegment.BindDefaultDiagnosType;
				this.cbxFixedStructs.Checked = this._MISegment.FixedStructs;
				this.chkStopRaiseVChanged.Checked = this._MISegment.StopRaiseVChanged;
				if (this._MISegment.Parent == null)
				{
					this.cbxNormal.Visible = false;
					this.Init();
					this.PCTextEdit.BindInstanceItem = this._BindNISegment;
					this.cbxNormal.Checked = false;
				}
				else if (this._BindNISegment.AbNormalSupport)
				{
					this.InitTabs();
					this._BindNISegment.NormalSubItems = this._BindNISegment.SubItems;
					this._BindNISegment.NormalFormatRangeCollection = this._BindNISegment.FormatRangeCollection;
					this._AbNISegment = new NISegment();
					this._AbNISegment.BindMMetaItem = this._BindNISegment.BindMMetaItem;
					this._AbNISegment.SubItems = this._BindNISegment.AbNormalSubItems;
					this._AbNISegment.FormatRangeCollection = this._BindNISegment.AbNormalFormatRangeCollection;
					this.PCTextEdit.BindInstanceItem = this._BindNISegment;
					this.AbPCTextEdit.BindInstanceItem = this._AbNISegment;
					this.cbxNormal.Checked = true;
				}
				else
				{
					this.Init();
					this.PCTextEdit.BindInstanceItem = this._BindNISegment;
					this.cbxNormal.Checked = false;
				}
				if (Operators.CompareString(this.GCbDiagnosType, string.Empty, false) != 0)
				{
					this.cbDiagnosType.SelectedValue = this.GCbDiagnosType;
				}
			}
		}

		public MISegmentProperty()
		{
			this.GCbDiagnosType = string.Empty;
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.cbxNormal = new CheckBox();
			this.btnSwap = new Button();
			this.cbxFixedStructs = new CheckBox();
			this.cbDiagnosType = new ComboBox();
			this.Label1 = new Label();
			this.chkStopRaiseVChanged = new CheckBox();
			this.SuspendLayout();
			Control arg_5A_0 = this.cbxNormal;
			Point location = new Point(22, 32);
			arg_5A_0.Location = location;
			this.cbxNormal.Name = "cbxNormal";
			Control arg_81_0 = this.cbxNormal;
			Size size = new Size(108, 32);
			arg_81_0.Size = size;
			this.cbxNormal.TabIndex = 0;
			this.cbxNormal.Text = "启用异常值支持";
			Control arg_B7_0 = this.btnSwap;
			location = new Point(132, 36);
			arg_B7_0.Location = location;
			this.btnSwap.Name = "btnSwap";
			Control arg_DE_0 = this.btnSwap;
			size = new Size(56, 23);
			arg_DE_0.Size = size;
			this.btnSwap.TabIndex = 1;
			this.btnSwap.Text = "交换值";
			Control arg_110_0 = this.cbxFixedStructs;
			location = new Point(22, 8);
			arg_110_0.Location = location;
			this.cbxFixedStructs.Name = "cbxFixedStructs";
			Control arg_137_0 = this.cbxFixedStructs;
			size = new Size(73, 22);
			arg_137_0.Size = size;
			this.cbxFixedStructs.TabIndex = 2;
			this.cbxFixedStructs.Text = "固定结构";
			this.cbDiagnosType.FormattingEnabled = true;
			Control arg_179_0 = this.cbDiagnosType;
			location = new Point(341, 10);
			arg_179_0.Location = location;
			this.cbDiagnosType.Name = "cbDiagnosType";
			Control arg_1A0_0 = this.cbDiagnosType;
			size = new Size(113, 20);
			arg_1A0_0.Size = size;
			this.cbDiagnosType.TabIndex = 3;
			this.Label1.AutoSize = true;
			Control arg_1D2_0 = this.Label1;
			location = new Point(272, 13);
			arg_1D2_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_1F9_0 = this.Label1;
			size = new Size(65, 12);
			arg_1F9_0.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "诊断类型：";
			Control arg_22E_0 = this.chkStopRaiseVChanged;
			location = new Point(135, 8);
			arg_22E_0.Location = location;
			this.chkStopRaiseVChanged.Name = "chkStopRaiseVChanged";
			Control arg_255_0 = this.chkStopRaiseVChanged;
			size = new Size(120, 22);
			arg_255_0.Size = size;
			this.chkStopRaiseVChanged.TabIndex = 5;
			this.chkStopRaiseVChanged.Text = "禁止触发计算公式";
			this.Controls.Add(this.chkStopRaiseVChanged);
			this.Controls.Add(this.cbDiagnosType);
			this.Controls.Add(this.cbxFixedStructs);
			this.Controls.Add(this.btnSwap);
			this.Controls.Add(this.cbxNormal);
			this.Controls.Add(this.Label1);
			this.Name = "MISegmentProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public void Init()
		{
			this.btnSwap.Visible = false;
			if (this.PCTextEdit == null)
			{
				this.PCTextEdit = new PCTextEdit();
				this.PCTextEdit.DragDrop += new DragEventHandler(this.PCTextEdit_DragDrop);
				this.PCTextEdit.DragEnter += new DragEventHandler(this.PCTextEdit_DragEnter);
			}
			if (this.PCTextEdit.Parent != null)
			{
				this.PCTextEdit.Parent.Controls.Remove(this.PCTextEdit);
			}
			if (this.SegmentTabs != null && this.SegmentTabs.Parent != null)
			{
				this.SegmentTabs.Parent.Controls.Remove(this.SegmentTabs);
			}
			Control arg_B9_0 = this.PCTextEdit;
			Point location = new Point(32, 72);
			arg_B9_0.Location = location;
			Control arg_D6_0 = this.PCTextEdit;
			Size size = new Size(400, 300);
			arg_D6_0.Size = size;
			this.PCTextEdit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			EMRDiagnosTypeDataset diagnosTypeDataset = WebServiceLayer.MRDiagnosDataAccess.GetDiagnosTypeDataset();
			if (diagnosTypeDataset.Tables.Count > 0)
			{
				this.cbDiagnosType.DataSource = diagnosTypeDataset.Tables[0];
				this.cbDiagnosType.ValueMember = "Code";
				this.cbDiagnosType.DisplayMember = "Desc";
			}
			this.Controls.Add(this.PCTextEdit);
		}

		public void InitTabs()
		{
			this.btnSwap.Visible = true;
			if (this.SegmentTabs == null)
			{
				this.SegmentTabs = new TabControlAdv();
				this.NormalTab = new TabPageAdv();
				this.NormalTab.set_Text("正常值");
				this.AbNormalTab = new TabPageAdv();
				this.AbNormalTab.set_Text("异常值");
				this.SegmentTabs.get_TabPages().Add(this.NormalTab);
				this.SegmentTabs.get_TabPages().Add(this.AbNormalTab);
			}
			if (this.PCTextEdit == null)
			{
				this.PCTextEdit = new PCTextEdit();
				this.PCTextEdit.DragDrop += new DragEventHandler(this.PCTextEdit_DragDrop);
				this.PCTextEdit.DragEnter += new DragEventHandler(this.PCTextEdit_DragEnter);
			}
			if (this.PCTextEdit.Parent != null)
			{
				this.PCTextEdit.Parent.Controls.Remove(this.PCTextEdit);
			}
			if (this.AbPCTextEdit == null)
			{
				this.AbPCTextEdit = new PCTextEdit();
				this.AbPCTextEdit.DragDrop += new DragEventHandler(this.PCTextEdit_DragDrop);
				this.AbPCTextEdit.DragEnter += new DragEventHandler(this.PCTextEdit_DragEnter);
			}
			if (this.AbPCTextEdit.Parent != null)
			{
				this.AbPCTextEdit.Parent.Controls.Remove(this.AbPCTextEdit);
			}
			Control arg_167_0 = this.PCTextEdit;
			Point location = new Point(8, 8);
			arg_167_0.Location = location;
			checked
			{
				this.PCTextEdit.Width = this.NormalTab.Width - 16;
				this.PCTextEdit.Height = this.NormalTab.Height - 16;
				this.PCTextEdit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				this.NormalTab.Controls.Add(this.PCTextEdit);
				Control arg_1D1_0 = this.AbPCTextEdit;
				location = new Point(8, 8);
				arg_1D1_0.Location = location;
				this.AbPCTextEdit.Width = this.AbNormalTab.Width - 16;
				this.AbPCTextEdit.Height = this.AbNormalTab.Height - 16;
				this.AbPCTextEdit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				this.AbNormalTab.Controls.Add(this.AbPCTextEdit);
				Control arg_23D_0 = this.SegmentTabs;
				location = new Point(32, 72);
				arg_23D_0.Location = location;
				Control arg_25A_0 = this.SegmentTabs;
				Size size = new Size(400, 300);
				arg_25A_0.Size = size;
				this.SegmentTabs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				this.Controls.Add(this.SegmentTabs);
			}
		}

		private void PCTextEdit_DragEnter(object sender, DragEventArgs e)
		{
			PCTextEdit pCTextEdit = (PCTextEdit)sender;
			this.DragEnterSelectionStart = pCTextEdit.SelectionStart;
			if (this.MetaItemTree.DragMetaItem != null)
			{
				if (this.MetaItemTree.DragMetaItem.Parent == pCTextEdit.BindInstanceItem.BindMMetaItem)
				{
					if (this.MetaItemTree.DragMetaItem.BindInstanceItem == null)
					{
						this.MetaItemTree.DragMetaItem.BindInstanceItem = this.MetaItemTree.DragMetaItem.CreateInstance();
					}
					this._DragInstanceItem = this.MetaItemTree.DragMetaItem.BindInstanceItem;
					if (this._MISegment.BindInstanceItem.SubItems.Contains(this._DragInstanceItem))
					{
						e.Effect = DragDropEffects.None;
						this._DragInstanceItem = null;
						this.MetaItemTree.DragMetaItem = null;
						this.MetaItemTree.DragTreeNode = null;
					}
					else
					{
						e.Effect = DragDropEffects.Move;
					}
				}
				else
				{
					e.Effect = DragDropEffects.None;
					this.MetaItemTree.DragMetaItem = null;
					this.MetaItemTree.DragTreeNode = null;
				}
			}
			else
			{
				e.Effect = DragDropEffects.None;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}

		private void PCTextEdit_DragDrop(object sender, DragEventArgs e)
		{
			PCTextEdit pCTextEdit = (PCTextEdit)sender;
			checked
			{
				if (this._DragInstanceItem != null)
				{
					RichTextBox arg_2D_0 = pCTextEdit;
					Control arg_28_0 = pCTextEdit;
					Point p = new Point(e.X, e.Y);
					int num = arg_2D_0.GetCharIndexFromPosition(arg_28_0.PointToClient(p));
					if (num == pCTextEdit.TextLength - 1)
					{
						Point positionFromCharIndex = pCTextEdit.GetPositionFromCharIndex(num);
						if (e.X > positionFromCharIndex.X + 10 | e.Y > positionFromCharIndex.Y + 10)
						{
							num++;
						}
					}
					pCTextEdit.MoveCursor(this.PCTextEdit.SelectionStart, num);
					pCTextEdit.InsertItem(this._DragInstanceItem);
					this._DragInstanceItem = null;
					this.MetaItemTree.DragMetaItem = null;
					this.MetaItemTree.DragTreeNode = null;
				}
			}
		}

		private void cbxFixedStructs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbxFixedStructs.Checked & this.cbxNormal.Checked)
			{
				this.cbxFixedStructs.Checked = false;
			}
			this._MISegment.FixedStructs = this.cbxFixedStructs.Checked;
		}

		private void cbxNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbxFixedStructs.Checked & this.cbxNormal.Checked)
			{
				this.cbxNormal.Checked = false;
			}
			if (this.cbxNormal.Checked)
			{
				this.InitTabs();
				this._BindNISegment.AbNormalSupport = true;
				this._BindNISegment.NormalSubItems = this._BindNISegment.SubItems;
				this._BindNISegment.NormalFormatRangeCollection = this._BindNISegment.FormatRangeCollection;
				this._AbNISegment = new NISegment();
				this._AbNISegment.Code = this._BindNISegment.Code;
				this._AbNISegment.BindMMetaItem = this._BindNISegment.BindMMetaItem;
				this._AbNISegment.SubItems = this._BindNISegment.AbNormalSubItems;
				this._AbNISegment.FormatRangeCollection = this._BindNISegment.AbNormalFormatRangeCollection;
				this.PCTextEdit.BindInstanceItem = this._BindNISegment;
				this.AbPCTextEdit.BindInstanceItem = this._AbNISegment;
			}
			else
			{
				this.Init();
				this._BindNISegment.AbNormalSupport = false;
				this.PCTextEdit.BindInstanceItem = this._BindNISegment;
			}
		}

		private void btnSwap_Click(object sender, EventArgs e)
		{
			this._BindNISegment.NormalSubItems = this._BindNISegment.AbNormalSubItems;
			this._BindNISegment.NormalFormatRangeCollection = this._BindNISegment.AbNormalFormatRangeCollection;
			this._BindNISegment.AbNormalSubItems = this._BindNISegment.SubItems;
			this._BindNISegment.AbNormalFormatRangeCollection = this._BindNISegment.FormatRangeCollection;
			this._BindNISegment.SubItems = this._BindNISegment.NormalSubItems;
			this._BindNISegment.FormatRangeCollection = this._BindNISegment.NormalFormatRangeCollection;
			this._AbNISegment.SubItems = this._BindNISegment.AbNormalSubItems;
			this._AbNISegment.FormatRangeCollection = this._BindNISegment.AbNormalFormatRangeCollection;
			this.PCTextEdit.BindInstanceItem = this._BindNISegment;
			this.AbPCTextEdit.BindInstanceItem = this._AbNISegment;
		}

		private void cbDiagnosType_SelectedValueChanged(object sender, EventArgs e)
		{
			this._MISegment.BindDefaultDiagnosType = this.cbDiagnosType.SelectedValue.ToString();
		}

		private void chkStopRaiseVChanged_CheckedChanged(object sender, EventArgs e)
		{
			this._MISegment.StopRaiseVChanged = this.chkStopRaiseVChanged.Checked;
		}
	}
}
