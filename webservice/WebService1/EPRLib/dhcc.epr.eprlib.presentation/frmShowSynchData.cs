using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class frmShowSynchData : Form
	{
		private DataSet _BandDataSet;

		private string _ResultTag;

		[AccessedThroughProperty("DataGridTableStyle1")]
		private DataGridTableStyle _DataGridTableStyle1;

		[AccessedThroughProperty("colCheck")]
		private DataGridBoolColumn _colCheck;

		private string _TemplateName;

		private ArrayList _FieldNames;

		private IContainer components;

		[AccessedThroughProperty("dgSynchChgData")]
		private DataGrid _dgSynchChgData;

		[AccessedThroughProperty("btn_Sure")]
		private Button _btn_Sure;

		[AccessedThroughProperty("btn_Cancel")]
		private Button _btn_Cancel;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

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

		internal virtual DataGridBoolColumn colCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._colCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._colCheck = value;
			}
		}

		public string ResultTag
		{
			get
			{
				return this._ResultTag;
			}
		}

		public ArrayList FieldArryList
		{
			get
			{
				return this._FieldNames;
			}
		}

		internal virtual DataGrid dgSynchChgData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgSynchChgData;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgSynchChgData = value;
			}
		}

		internal virtual Button btn_Sure
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_Sure;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Sure_Click);
				if (this._btn_Sure != null)
				{
					this._btn_Sure.Click -= value2;
				}
				this._btn_Sure = value;
				if (this._btn_Sure != null)
				{
					this._btn_Sure.Click += value2;
				}
			}
		}

		internal virtual Button btn_Cancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_Cancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Cancel_Click);
				if (this._btn_Cancel != null)
				{
					this._btn_Cancel.Click -= value2;
				}
				this._btn_Cancel = value;
				if (this._btn_Cancel != null)
				{
					this._btn_Cancel.Click += value2;
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

		public frmShowSynchData(string argTemplateName, DataSet parBandDataset)
		{
			base.Load += new EventHandler(this.frm_ShowReadOnlyChg_Load);
			this._FieldNames = new ArrayList();
			this.InitializeComponent();
			this._TemplateName = argTemplateName;
			this._BandDataSet = parBandDataset;
			if (Operators.CompareString(this._TemplateName, "", false) == 0)
			{
				this.dgSynchChgData.CaptionText = "系统检测到了当前模板的以下项目存在更新内容  (只检测需同步的单元)";
				this.Text = "当前模板同步数据的更新单元";
			}
			else
			{
				this.dgSynchChgData.CaptionText = "系统检测到了模板  《" + this._TemplateName + "》    的以下项目存在更新内容  (只检测需同步的单元)";
				this.Text = "同步数据的更新单元  《" + this._TemplateName + "》";
			}
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
			this.dgSynchChgData = new DataGrid();
			this.DataGridTableStyle1 = new DataGridTableStyle();
			this.colCheck = new DataGridBoolColumn();
			this.btn_Sure = new Button();
			this.btn_Cancel = new Button();
			this.Label1 = new Label();
			((ISupportInitialize)this.dgSynchChgData).BeginInit();
			this.SuspendLayout();
			this.dgSynchChgData.AllowDrop = true;
			this.dgSynchChgData.AlternatingBackColor = Color.Lavender;
			this.dgSynchChgData.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dgSynchChgData.BackColor = Color.WhiteSmoke;
			this.dgSynchChgData.BackgroundColor = Color.LightGray;
			this.dgSynchChgData.CaptionBackColor = Color.LightSteelBlue;
			this.dgSynchChgData.CaptionForeColor = Color.MidnightBlue;
			this.dgSynchChgData.CaptionText = "系统检测到了当前页签的以下项目存在更新内容  (只检测需同步的单元)";
			this.dgSynchChgData.DataMember = "";
			this.dgSynchChgData.FlatMode = true;
			this.dgSynchChgData.Font = new Font("Tahoma", 8f);
			this.dgSynchChgData.ForeColor = Color.MidnightBlue;
			this.dgSynchChgData.GridLineColor = Color.Gainsboro;
			this.dgSynchChgData.GridLineStyle = DataGridLineStyle.None;
			this.dgSynchChgData.HeaderBackColor = Color.LightSteelBlue;
			this.dgSynchChgData.HeaderFont = new Font("Tahoma", 8f, FontStyle.Bold);
			this.dgSynchChgData.HeaderForeColor = Color.WhiteSmoke;
			this.dgSynchChgData.LinkColor = Color.Teal;
			Control arg_189_0 = this.dgSynchChgData;
			Point location = new Point(0, 0);
			arg_189_0.Location = location;
			this.dgSynchChgData.Name = "dgSynchChgData";
			this.dgSynchChgData.ParentRowsBackColor = Color.Gainsboro;
			this.dgSynchChgData.ParentRowsForeColor = Color.MidnightBlue;
			this.dgSynchChgData.SelectionBackColor = Color.CadetBlue;
			this.dgSynchChgData.SelectionForeColor = Color.WhiteSmoke;
			Control arg_1F6_0 = this.dgSynchChgData;
			Size size = new Size(608, 384);
			arg_1F6_0.Size = size;
			this.dgSynchChgData.TabIndex = 1;
			this.dgSynchChgData.TableStyles.AddRange(new DataGridTableStyle[]
			{
				this.DataGridTableStyle1
			});
			this.DataGridTableStyle1.DataGrid = this.dgSynchChgData;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new DataGridColumnStyle[]
			{
				this.colCheck
			});
			this.DataGridTableStyle1.HeaderForeColor = SystemColors.ControlText;
			this.colCheck.AllowNull = false;
			this.colCheck.HeaderText = "是否更新";
			this.colCheck.MappingName = "seleCheck";
			this.colCheck.Width = 60;
			this.btn_Sure.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btn_Sure.BackColor = Color.FromArgb(49, 101, 156);
			this.btn_Sure.FlatStyle = FlatStyle.Popup;
			this.btn_Sure.ForeColor = SystemColors.ControlLightLight;
			Control arg_2FD_0 = this.btn_Sure;
			location = new Point(408, 392);
			arg_2FD_0.Location = location;
			this.btn_Sure.Name = "btn_Sure";
			Control arg_324_0 = this.btn_Sure;
			size = new Size(80, 25);
			arg_324_0.Size = size;
			this.btn_Sure.TabIndex = 3;
			this.btn_Sure.Text = "替换";
			this.btn_Sure.UseVisualStyleBackColor = false;
			this.btn_Cancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btn_Cancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btn_Cancel.FlatStyle = FlatStyle.Popup;
			this.btn_Cancel.ForeColor = SystemColors.ControlLightLight;
			Control arg_3AB_0 = this.btn_Cancel;
			location = new Point(512, 392);
			arg_3AB_0.Location = location;
			this.btn_Cancel.Name = "btn_Cancel";
			Control arg_3D2_0 = this.btn_Cancel;
			size = new Size(80, 25);
			arg_3D2_0.Size = size;
			this.btn_Cancel.TabIndex = 4;
			this.btn_Cancel.Text = "不替换";
			this.btn_Cancel.UseVisualStyleBackColor = false;
			this.Label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Label1.ForeColor = Color.MidnightBlue;
			Control arg_455_0 = this.Label1;
			location = new Point(152, 400);
			arg_455_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_47F_0 = this.Label1;
			size = new Size(248, 16);
			arg_47F_0.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "是否用新内容来替换以上所有单元的现内容";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(222, 223, 255);
			size = new Size(608, 430);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Sure);
			this.Controls.Add(this.dgSynchChgData);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "frmShowSynchData";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "同步数据的更新单元";
			((ISupportInitialize)this.dgSynchChgData).EndInit();
			this.ResumeLayout(false);
		}

		private void frm_ShowReadOnlyChg_Load(object sender, EventArgs e)
		{
			this.dgSynchChgData.DataSource = this._BandDataSet.Tables["tbSynchData"].DefaultView;
			this._BandDataSet.Tables["tbSynchData"].DefaultView.AllowNew = false;
			this.AddCustomDataTableStyle();
		}

		private void AddCustomDataTableStyle()
		{
			DataGridTableStyle dataGridTableStyle = new DataGridTableStyle();
			dataGridTableStyle.MappingName = "tbSynchData";
			this.dgSynchChgData.TableStyles.Clear();
			dataGridTableStyle.HeaderBackColor = Color.LightSteelBlue;
			dataGridTableStyle.HeaderForeColor = Color.WhiteSmoke;
			DataGridColumnStyle dataGridColumnStyle = new DataGridTextBoxColumn();
			dataGridColumnStyle.MappingName = "Caption";
			dataGridColumnStyle.Width = 100;
			dataGridColumnStyle.HeaderText = "单元名称";
			dataGridColumnStyle.ReadOnly = true;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle);
			DataGridColumnStyle dataGridColumnStyle2 = new DataGridTextBoxColumn();
			dataGridColumnStyle2.MappingName = "TextOld";
			dataGridColumnStyle2.Width = 165;
			dataGridColumnStyle2.HeaderText = "现内容";
			dataGridColumnStyle2.ReadOnly = true;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle2);
			DataGridColumnStyle dataGridColumnStyle3 = new DataGridTextBoxColumn();
			dataGridColumnStyle3.MappingName = "TextNew";
			dataGridColumnStyle3.Width = 165;
			dataGridColumnStyle3.HeaderText = "新内容";
			dataGridColumnStyle3.ReadOnly = true;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle3);
			DataGridColumnStyle dataGridColumnStyle4 = new DataGridTextBoxColumn();
			dataGridColumnStyle4.MappingName = "CtrlType";
			dataGridColumnStyle4.Width = 70;
			dataGridColumnStyle4.HeaderText = "单元类型";
			dataGridColumnStyle4.Alignment = HorizontalAlignment.Center;
			dataGridColumnStyle4.ReadOnly = true;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle4);
			dataGridTableStyle.GridColumnStyles.Add(this.colCheck);
			this.dgSynchChgData.TableStyles.Add(dataGridTableStyle);
		}

		private void btn_Sure_Click(object sender, EventArgs e)
		{
			this._ResultTag = "Replace";
			int arg_2E_0 = 0;
			checked
			{
				int num = this._BandDataSet.Tables["tbSynchData"].Rows.Count - 1;
				for (int i = arg_2E_0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(this._BandDataSet.Tables["tbSynchData"].Rows[i]["seleCheck"], true, false))
					{
						this._FieldNames.Add(RuntimeHelpers.GetObjectValue(this._BandDataSet.Tables["tbSynchData"].Rows[i]["FieldName"]));
					}
				}
				this.Close();
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this._ResultTag = "NotReplace";
			this.Close();
		}
	}
}
