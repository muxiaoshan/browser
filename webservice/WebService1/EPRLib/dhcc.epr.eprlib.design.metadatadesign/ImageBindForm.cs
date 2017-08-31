using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class ImageBindForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("cbxAutoGen")]
		private CheckBox _cbxAutoGen;

		[AccessedThroughProperty("cmbTextDesc")]
		private ComboBox _cmbTextDesc;

		[AccessedThroughProperty("lblTextDesc")]
		private Label _lblTextDesc;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("txtSpliter")]
		private TextBox _txtSpliter;

		[AccessedThroughProperty("lblSplitter")]
		private Label _lblSplitter;

		[AccessedThroughProperty("cbxNameConvert")]
		private CheckBox _cbxNameConvert;

		[AccessedThroughProperty("cbxImageConvert")]
		private CheckBox _cbxImageConvert;

		[AccessedThroughProperty("txtConvertClass")]
		private TextBox _txtConvertClass;

		[AccessedThroughProperty("lblConvertClass")]
		private Label _lblConvertClass;

		private MMetaData _MetaData;

		private MIImageAnnotate _MIImageAnnotate;

		internal virtual CheckBox cbxAutoGen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxAutoGen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxAutoGen_CheckedChanged);
				if (this._cbxAutoGen != null)
				{
					this._cbxAutoGen.CheckedChanged -= value2;
				}
				this._cbxAutoGen = value;
				if (this._cbxAutoGen != null)
				{
					this._cbxAutoGen.CheckedChanged += value2;
				}
			}
		}

		internal virtual ComboBox cmbTextDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmbTextDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbTextDesc_SelectedIndexChanged);
				if (this._cmbTextDesc != null)
				{
					this._cmbTextDesc.SelectedIndexChanged -= value2;
				}
				this._cmbTextDesc = value;
				if (this._cmbTextDesc != null)
				{
					this._cmbTextDesc.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label lblTextDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTextDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTextDesc = value;
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

		internal virtual TextBox txtSpliter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSpliter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSpliter_TextChanged);
				if (this._txtSpliter != null)
				{
					this._txtSpliter.TextChanged -= value2;
				}
				this._txtSpliter = value;
				if (this._txtSpliter != null)
				{
					this._txtSpliter.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSplitter = value;
			}
		}

		internal virtual CheckBox cbxNameConvert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxNameConvert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxNameConvert_CheckedChanged);
				if (this._cbxNameConvert != null)
				{
					this._cbxNameConvert.CheckedChanged -= value2;
				}
				this._cbxNameConvert = value;
				if (this._cbxNameConvert != null)
				{
					this._cbxNameConvert.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxImageConvert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxImageConvert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxImageConvert_CheckedChanged);
				if (this._cbxImageConvert != null)
				{
					this._cbxImageConvert.CheckedChanged -= value2;
				}
				this._cbxImageConvert = value;
				if (this._cbxImageConvert != null)
				{
					this._cbxImageConvert.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox txtConvertClass
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtConvertClass;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtConvertClass_TextChanged);
				if (this._txtConvertClass != null)
				{
					this._txtConvertClass.TextChanged -= value2;
				}
				this._txtConvertClass = value;
				if (this._txtConvertClass != null)
				{
					this._txtConvertClass.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblConvertClass
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblConvertClass;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblConvertClass = value;
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
				this.AddTextDesc(this._MetaData.SubItems);
			}
		}

		public MIImageAnnotate MIImageAnnotate
		{
			get
			{
				return this._MIImageAnnotate;
			}
			set
			{
				this._MIImageAnnotate = value;
				this.txtSpliter.Text = this._MIImageAnnotate.Spliter;
				this.cbxNameConvert.Checked = this._MIImageAnnotate.NameConvert;
				this.cbxImageConvert.Checked = this._MIImageAnnotate.ImageConvert;
				this.txtConvertClass.Text = this._MIImageAnnotate.ConvertClass;
				if (Operators.CompareString(this._MIImageAnnotate.BindTextDescCode, "", false) == 0 | this._MIImageAnnotate.BindTextDescCode == null)
				{
					this.cbxAutoGen.Checked = false;
					this.cmbTextDesc.Enabled = false;
				}
				else
				{
					this.cbxAutoGen.Checked = true;
					this.cmbTextDesc.Enabled = true;
					try
					{
						IEnumerator enumerator = this.cmbTextDesc.Items.GetEnumerator();
						while (enumerator.MoveNext())
						{
							TextDescProperty textDescProperty = (TextDescProperty)enumerator.Current;
							if (Operators.CompareString(textDescProperty.TextDescCode, this._MIImageAnnotate.BindTextDescCode, false) == 0)
							{
								this.cmbTextDesc.SelectedItem = textDescProperty;
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
		}

		public ImageBindForm()
		{
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
			this.cbxAutoGen = new CheckBox();
			this.cmbTextDesc = new ComboBox();
			this.lblTextDesc = new Label();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.txtSpliter = new TextBox();
			this.lblSplitter = new Label();
			this.cbxNameConvert = new CheckBox();
			this.cbxImageConvert = new CheckBox();
			this.txtConvertClass = new TextBox();
			this.lblConvertClass = new Label();
			this.SuspendLayout();
			Control arg_94_0 = this.cbxAutoGen;
			Point location = new Point(16, 168);
			arg_94_0.Location = location;
			this.cbxAutoGen.Name = "cbxAutoGen";
			Control arg_BE_0 = this.cbxAutoGen;
			Size size = new Size(152, 24);
			arg_BE_0.Size = size;
			this.cbxAutoGen.TabIndex = 0;
			this.cbxAutoGen.Text = "自动生成文字描述";
			Control arg_F4_0 = this.cmbTextDesc;
			location = new Point(16, 232);
			arg_F4_0.Location = location;
			this.cmbTextDesc.Name = "cmbTextDesc";
			Control arg_11E_0 = this.cmbTextDesc;
			size = new Size(200, 20);
			arg_11E_0.Size = size;
			this.cmbTextDesc.TabIndex = 1;
			Control arg_144_0 = this.lblTextDesc;
			location = new Point(16, 208);
			arg_144_0.Location = location;
			this.lblTextDesc.Name = "lblTextDesc";
			Control arg_16B_0 = this.lblTextDesc;
			size = new Size(120, 16);
			arg_16B_0.Size = size;
			this.lblTextDesc.TabIndex = 2;
			this.lblTextDesc.Text = "选择文本描述单元：";
			Control arg_1A1_0 = this.btnOK;
			location = new Point(40, 280);
			arg_1A1_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_1C8_0 = this.btnOK;
			size = new Size(64, 23);
			arg_1C8_0.Size = size;
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "确定";
			Control arg_201_0 = this.btnCancel;
			location = new Point(136, 280);
			arg_201_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_228_0 = this.btnCancel;
			size = new Size(64, 24);
			arg_228_0.Size = size;
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "取消";
			Control arg_25B_0 = this.txtSpliter;
			location = new Point(112, 16);
			arg_25B_0.Location = location;
			this.txtSpliter.Name = "txtSpliter";
			Control arg_282_0 = this.txtSpliter;
			size = new Size(104, 21);
			arg_282_0.Size = size;
			this.txtSpliter.TabIndex = 5;
			this.txtSpliter.Text = "";
			Control arg_2B5_0 = this.lblSplitter;
			location = new Point(12, 20);
			arg_2B5_0.Location = location;
			this.lblSplitter.Name = "lblSplitter";
			Control arg_2DC_0 = this.lblSplitter;
			size = new Size(72, 16);
			arg_2DC_0.Size = size;
			this.lblSplitter.TabIndex = 6;
			this.lblSplitter.Text = "名称分割符";
			Control arg_30F_0 = this.cbxNameConvert;
			location = new Point(16, 48);
			arg_30F_0.Location = location;
			this.cbxNameConvert.Name = "cbxNameConvert";
			this.cbxNameConvert.TabIndex = 7;
			this.cbxNameConvert.Text = "支持名称转换";
			Control arg_352_0 = this.cbxImageConvert;
			location = new Point(16, 88);
			arg_352_0.Location = location;
			this.cbxImageConvert.Name = "cbxImageConvert";
			this.cbxImageConvert.TabIndex = 8;
			this.cbxImageConvert.Text = "支持图形转换";
			Control arg_398_0 = this.txtConvertClass;
			location = new Point(112, 128);
			arg_398_0.Location = location;
			this.txtConvertClass.Name = "txtConvertClass";
			this.txtConvertClass.TabIndex = 9;
			this.txtConvertClass.Text = "";
			Control arg_3DF_0 = this.lblConvertClass;
			location = new Point(16, 128);
			arg_3DF_0.Location = location;
			this.lblConvertClass.Name = "lblConvertClass";
			Control arg_406_0 = this.lblConvertClass;
			size = new Size(72, 16);
			arg_406_0.Size = size;
			this.lblConvertClass.TabIndex = 10;
			this.lblConvertClass.Text = "转换类名称";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(250, 322);
			this.ClientSize = size;
			this.Controls.Add(this.lblConvertClass);
			this.Controls.Add(this.txtConvertClass);
			this.Controls.Add(this.cbxImageConvert);
			this.Controls.Add(this.cbxNameConvert);
			this.Controls.Add(this.lblSplitter);
			this.Controls.Add(this.txtSpliter);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblTextDesc);
			this.Controls.Add(this.cmbTextDesc);
			this.Controls.Add(this.cbxAutoGen);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "ImageBindForm";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "图片属性";
			this.ResumeLayout(false);
		}

		public void AddTextDesc(MMetaItemCollection subitems)
		{
			MMetaItemEnumerator enumerator = subitems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MMetaItem mMetaItem = (MMetaItem)enumerator.Current;
				if (mMetaItem is MITextDesc)
				{
					TextDescProperty textDescProperty = new TextDescProperty();
					textDescProperty.TextDescCode = mMetaItem.Code;
					textDescProperty.TextDescName = mMetaItem.Text;
					this.cmbTextDesc.Items.Add(textDescProperty);
				}
				else if (mMetaItem is MICluster)
				{
					this.AddTextDesc(mMetaItem.SubItems);
				}
			}
		}

		private void cbxAutoGen_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbxAutoGen.Checked)
			{
				this.cmbTextDesc.Enabled = true;
				if (this.cmbTextDesc.Items.Count > 0)
				{
					this.cmbTextDesc.SelectedItem = RuntimeHelpers.GetObjectValue(this.cmbTextDesc.Items[0]);
					TextDescProperty textDescProperty = (TextDescProperty)this.cmbTextDesc.Items[0];
					this._MIImageAnnotate.BindTextDescCode = textDescProperty.TextDescCode;
				}
			}
			else
			{
				this._MIImageAnnotate.BindTextDescCode = "";
				this.cmbTextDesc.Enabled = false;
			}
		}

		private void cmbTextDesc_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbTextDesc.SelectedItem != null)
			{
				TextDescProperty textDescProperty = (TextDescProperty)this.cmbTextDesc.SelectedItem;
				this._MIImageAnnotate.BindTextDescCode = textDescProperty.TextDescCode;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void cbxImageConvert_CheckedChanged(object sender, EventArgs e)
		{
			this._MIImageAnnotate.ImageConvert = this.cbxImageConvert.Checked;
		}

		private void cbxNameConvert_CheckedChanged(object sender, EventArgs e)
		{
			this._MIImageAnnotate.NameConvert = this.cbxNameConvert.Checked;
		}

		private void txtSpliter_TextChanged(object sender, EventArgs e)
		{
			this._MIImageAnnotate.Spliter = this.txtSpliter.Text;
		}

		private void txtConvertClass_TextChanged(object sender, EventArgs e)
		{
			this._MIImageAnnotate.ConvertClass = this.txtConvertClass.Text;
		}
	}
}
