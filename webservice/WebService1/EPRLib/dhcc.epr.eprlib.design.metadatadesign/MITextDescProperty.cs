using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using MRDiagnosData;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MITextDescProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblKBPart")]
		private Label _lblKBPart;

		[AccessedThroughProperty("lblBindKBNode")]
		private Label _lblBindKBNode;

		[AccessedThroughProperty("btnAddKBNode")]
		private Button _btnAddKBNode;

		[AccessedThroughProperty("txtBindKBNode")]
		private TextBox _txtBindKBNode;

		[AccessedThroughProperty("chkBindDefaultKB")]
		private CheckBox _chkBindDefaultKB;

		[AccessedThroughProperty("cbDiagnosType")]
		private ComboBox _cbDiagnosType;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("chkStopRaiseVChanged")]
		private CheckBox _chkStopRaiseVChanged;

		[AccessedThroughProperty("cbxKBPart")]
		private ComboBox _cbxKBPart;

		private MITextDesc m_MITextDesc;

		private string ECbDiagnosType;

		internal virtual Label lblKBPart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblKBPart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblKBPart = value;
			}
		}

		internal virtual Label lblBindKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblBindKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblBindKBNode = value;
			}
		}

		internal virtual Button btnAddKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAddKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddKBNode_Click);
				if (this._btnAddKBNode != null)
				{
					this._btnAddKBNode.Click -= value2;
				}
				this._btnAddKBNode = value;
				if (this._btnAddKBNode != null)
				{
					this._btnAddKBNode.Click += value2;
				}
			}
		}

		internal virtual TextBox txtBindKBNode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBindKBNode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBindKBNode = value;
			}
		}

		internal virtual CheckBox chkBindDefaultKB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkBindDefaultKB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkBindDefaultKB_CheckedChanged);
				if (this._chkBindDefaultKB != null)
				{
					this._chkBindDefaultKB.CheckedChanged -= value2;
				}
				this._chkBindDefaultKB = value;
				if (this._chkBindDefaultKB != null)
				{
					this._chkBindDefaultKB.CheckedChanged += value2;
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

		internal virtual ComboBox cbxKBPart
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

		public MITextDesc MITextDesc
		{
			get
			{
				return this.m_MITextDesc;
			}
			set
			{
				this.m_MITextDesc = value;
				this.ECbDiagnosType = this.m_MITextDesc.BindDefaultDiagnosType;
				this.chkStopRaiseVChanged.Checked = this.m_MITextDesc.StopRaiseVChanged;
				if (this.m_MITextDesc.Parent is MMetaData && !string.IsNullOrEmpty(((MMetaData)this.m_MITextDesc.Parent).BindKBCode))
				{
					this.btnAddKBNode.Enabled = false;
					this.txtBindKBNode.Enabled = false;
					this.txtBindKBNode.Text = string.Empty;
					this.m_MITextDesc.BindKBName = string.Empty;
					this.m_MITextDesc.BindKBBaseID = string.Empty;
				}
				else
				{
					this.btnAddKBNode.Enabled = true;
					this.txtBindKBNode.Enabled = true;
					this.txtBindKBNode.Text = this.m_MITextDesc.BindKBName;
					this.chkBindDefaultKB.Checked = this.m_MITextDesc.BindDefaultKB;
					if (this.m_MITextDesc.BindKBPart == KBPart.First)
					{
						this.cbxKBPart.SelectedIndex = 0;
					}
					else if (this.m_MITextDesc.BindKBPart == KBPart.Second)
					{
						this.cbxKBPart.SelectedIndex = 1;
					}
					else if (this.m_MITextDesc.BindKBPart == KBPart.Third)
					{
						this.cbxKBPart.SelectedIndex = 2;
					}
				}
				this.intCbDiagnosType();
				if (Operators.CompareString(this.ECbDiagnosType, string.Empty, false) != 0)
				{
					this.cbDiagnosType.SelectedValue = this.ECbDiagnosType;
				}
			}
		}

		public MITextDescProperty()
		{
			this.ECbDiagnosType = string.Empty;
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
			this.lblKBPart = new Label();
			this.cbxKBPart = new ComboBox();
			this.lblBindKBNode = new Label();
			this.btnAddKBNode = new Button();
			this.txtBindKBNode = new TextBox();
			this.chkBindDefaultKB = new CheckBox();
			this.cbDiagnosType = new ComboBox();
			this.Label1 = new Label();
			this.chkStopRaiseVChanged = new CheckBox();
			this.SuspendLayout();
			Control arg_7A_0 = this.lblKBPart;
			Point location = new Point(6, 41);
			arg_7A_0.Location = location;
			this.lblKBPart.Name = "lblKBPart";
			Control arg_A1_0 = this.lblKBPart;
			Size size = new Size(105, 23);
			arg_A1_0.Size = size;
			this.lblKBPart.TabIndex = 0;
			this.lblKBPart.Text = "绑定知识库部分：";
			this.lblKBPart.TextAlign = ContentAlignment.MiddleLeft;
			this.cbxKBPart.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxKBPart.Items.AddRange(new object[]
			{
				"第一部分",
				"第二部分",
				"第三部分"
			});
			Control arg_11D_0 = this.cbxKBPart;
			location = new Point(111, 41);
			arg_11D_0.Location = location;
			this.cbxKBPart.Name = "cbxKBPart";
			Control arg_147_0 = this.cbxKBPart;
			size = new Size(200, 20);
			arg_147_0.Size = size;
			this.cbxKBPart.TabIndex = 1;
			Control arg_168_0 = this.lblBindKBNode;
			location = new Point(6, 8);
			arg_168_0.Location = location;
			this.lblBindKBNode.Name = "lblBindKBNode";
			Control arg_18F_0 = this.lblBindKBNode;
			size = new Size(105, 23);
			arg_18F_0.Size = size;
			this.lblBindKBNode.TabIndex = 2;
			this.lblBindKBNode.Text = "绑定知识库节点：";
			this.lblBindKBNode.TextAlign = ContentAlignment.MiddleLeft;
			Control arg_1D1_0 = this.btnAddKBNode;
			location = new Point(316, 7);
			arg_1D1_0.Location = location;
			this.btnAddKBNode.Name = "btnAddKBNode";
			Control arg_1F8_0 = this.btnAddKBNode;
			size = new Size(50, 23);
			arg_1F8_0.Size = size;
			this.btnAddKBNode.TabIndex = 4;
			this.btnAddKBNode.Text = "+";
			Control arg_22A_0 = this.txtBindKBNode;
			location = new Point(111, 8);
			arg_22A_0.Location = location;
			this.txtBindKBNode.Name = "txtBindKBNode";
			Control arg_254_0 = this.txtBindKBNode;
			size = new Size(200, 21);
			arg_254_0.Size = size;
			this.txtBindKBNode.TabIndex = 3;
			this.chkBindDefaultKB.AutoSize = true;
			Control arg_282_0 = this.chkBindDefaultKB;
			location = new Point(8, 107);
			arg_282_0.Location = location;
			this.chkBindDefaultKB.Name = "chkBindDefaultKB";
			Control arg_2AC_0 = this.chkBindDefaultKB;
			size = new Size(180, 16);
			arg_2AC_0.Size = size;
			this.chkBindDefaultKB.TabIndex = 5;
			this.chkBindDefaultKB.Text = "是否根据病种绑定默认知识库";
			this.chkBindDefaultKB.UseVisualStyleBackColor = true;
			this.cbDiagnosType.FormattingEnabled = true;
			Control arg_2F7_0 = this.cbDiagnosType;
			location = new Point(111, 71);
			arg_2F7_0.Location = location;
			this.cbDiagnosType.Name = "cbDiagnosType";
			Control arg_321_0 = this.cbDiagnosType;
			size = new Size(200, 20);
			arg_321_0.Size = size;
			this.cbDiagnosType.TabIndex = 6;
			this.Label1.AutoSize = true;
			Control arg_350_0 = this.Label1;
			location = new Point(40, 74);
			arg_350_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_377_0 = this.Label1;
			size = new Size(65, 12);
			arg_377_0.Size = size;
			this.Label1.TabIndex = 7;
			this.Label1.Text = "诊断类型：";
			this.chkStopRaiseVChanged.AutoSize = true;
			Control arg_3B8_0 = this.chkStopRaiseVChanged;
			location = new Point(8, 130);
			arg_3B8_0.Location = location;
			this.chkStopRaiseVChanged.Name = "chkStopRaiseVChanged";
			Control arg_3DF_0 = this.chkStopRaiseVChanged;
			size = new Size(120, 16);
			arg_3DF_0.Size = size;
			this.chkStopRaiseVChanged.TabIndex = 8;
			this.chkStopRaiseVChanged.Text = "禁止触发计算公式";
			this.chkStopRaiseVChanged.UseVisualStyleBackColor = true;
			this.Controls.Add(this.chkStopRaiseVChanged);
			this.Controls.Add(this.cbDiagnosType);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.chkBindDefaultKB);
			this.Controls.Add(this.btnAddKBNode);
			this.Controls.Add(this.txtBindKBNode);
			this.Controls.Add(this.lblBindKBNode);
			this.Controls.Add(this.cbxKBPart);
			this.Controls.Add(this.lblKBPart);
			this.Name = "MITextDescProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void cbxKBPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxKBPart.SelectedIndex == 0)
			{
				this.m_MITextDesc.BindKBPart = KBPart.First;
			}
			else if (this.cbxKBPart.SelectedIndex == 1)
			{
				this.m_MITextDesc.BindKBPart = KBPart.Second;
			}
			else if (this.cbxKBPart.SelectedIndex == 2)
			{
				this.m_MITextDesc.BindKBPart = KBPart.Third;
			}
		}

		private void btnAddKBNode_Click(object sender, EventArgs e)
		{
			KnowledgeBaseForm knowledgeBaseForm = new KnowledgeBaseForm();
			Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
			Control arg_23_0 = this.btnAddKBNode;
			Point p = new Point(0, 0);
			Point location = arg_23_0.PointToScreen(p);
			checked
			{
				location.Y += 28;
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
					this.txtBindKBNode.Text = knowledgeBaseForm.KBName;
					this.m_MITextDesc.BindKBBaseID = knowledgeBaseForm.KBCode;
					this.m_MITextDesc.BindKBName = knowledgeBaseForm.KBName;
				}
			}
		}

		private void chkBindDefaultKB_CheckedChanged(object sender, EventArgs e)
		{
			this.m_MITextDesc.BindDefaultKB = this.chkBindDefaultKB.Checked;
		}

		private void intCbDiagnosType()
		{
			EMRDiagnosTypeDataset diagnosTypeDataset = WebServiceLayer.MRDiagnosDataAccess.GetDiagnosTypeDataset();
			if (diagnosTypeDataset.Tables.Count > 0)
			{
				this.cbDiagnosType.DataSource = diagnosTypeDataset.Tables[0];
				this.cbDiagnosType.ValueMember = "Code";
				this.cbDiagnosType.DisplayMember = "Desc";
			}
		}

		private void cbDiagnosType_SelectedValueChanged(object sender, EventArgs e)
		{
			this.MITextDesc.BindDefaultDiagnosType = this.cbDiagnosType.SelectedValue.ToString();
		}

		private void chkStopRaiseVChanged_CheckedChanged(object sender, EventArgs e)
		{
			this.m_MITextDesc.StopRaiseVChanged = this.chkStopRaiseVChanged.Checked;
		}
	}
}
