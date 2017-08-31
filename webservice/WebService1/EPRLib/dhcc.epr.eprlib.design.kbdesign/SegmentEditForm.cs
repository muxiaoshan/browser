using dhcc.epr.eprlib.design.metadatadesign;
using dhcc.epr.systemframework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class SegmentEditForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		public DCMetaData DCMetaData;

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

		internal virtual SplitContainer SplitContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer1 = value;
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

		public SegmentEditForm()
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
			this.btnSave = new Button();
			this.btnCancel = new Button();
			this.SplitContainer1 = new SplitContainer();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.SuspendLayout();
			Control arg_56_0 = this.btnSave;
			Point location = new Point(772, 3);
			arg_56_0.Location = location;
			this.btnSave.Name = "btnSave";
			Control arg_7D_0 = this.btnSave;
			Size size = new Size(75, 24);
			arg_7D_0.Size = size;
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "确定";
			Control arg_B2_0 = this.btnCancel;
			location = new Point(915, 4);
			arg_B2_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_D9_0 = this.btnCancel;
			size = new Size(75, 23);
			arg_D9_0.Size = size;
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消(ESC)";
			this.SplitContainer1.Dock = DockStyle.Fill;
			Control arg_116_0 = this.SplitContainer1;
			location = new Point(0, 0);
			arg_116_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel2.Controls.Add(this.btnSave);
			this.SplitContainer1.Panel2.Controls.Add(this.btnCancel);
			Control arg_185_0 = this.SplitContainer1;
			size = new Size(1005, 600);
			arg_185_0.Size = size;
			this.SplitContainer1.SplitterDistance = 566;
			this.SplitContainer1.TabIndex = 3;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(1005, 600);
			this.ClientSize = size;
			this.Controls.Add(this.SplitContainer1);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "SegmentEditForm";
			this.ShowInTaskbar = false;
			this.Text = "编辑";
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.DCMetaData = new DCMetaData();
			this.SplitContainer1.Panel1.Controls.Add(this.DCMetaData);
			this.DCMetaData.Dock = DockStyle.Fill;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageManager.ShowQuestionMessage("将放弃所有修改，是否继续？") == DialogResult.No)
			{
				return;
			}
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
