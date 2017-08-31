using dhcc.epr.eprlib.design.metadatadesign;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class KBEditForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("DcMetaData")]
		private DCMetaData _DcMetaData;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("btnQuit")]
		private Button _btnQuit;

		internal virtual DCMetaData DcMetaData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DcMetaData;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DcMetaData = value;
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
				this._btnSave = value;
			}
		}

		internal virtual Button btnQuit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnQuit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnQuit = value;
			}
		}

		public KBEditForm()
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
			this.DcMetaData = new DCMetaData();
			this.btnSave = new Button();
			this.btnQuit = new Button();
			this.SuspendLayout();
			this.DcMetaData.CurrentMetaItem = null;
			this.DcMetaData.InstanceItem = null;
			Control arg_4F_0 = this.DcMetaData;
			Point location = new Point(8, 8);
			arg_4F_0.Location = location;
			this.DcMetaData.MetaItem = null;
			this.DcMetaData.Name = "DcMetaData";
			Control arg_88_0 = this.DcMetaData;
			Size size = new Size(720, 408);
			arg_88_0.Size = size;
			this.DcMetaData.TabIndex = 0;
			Control arg_B1_0 = this.btnSave;
			location = new Point(560, 432);
			arg_B1_0.Location = location;
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存";
			this.btnQuit.DialogResult = DialogResult.Cancel;
			Control arg_106_0 = this.btnQuit;
			location = new Point(656, 432);
			arg_106_0.Location = location;
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.TabIndex = 2;
			this.btnQuit.Text = "退出";
			this.AcceptButton = this.btnSave;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.CancelButton = this.btnQuit;
			size = new Size(736, 469);
			this.ClientSize = size;
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.DcMetaData);
			this.Name = "KBEditForm";
			this.Text = "编辑";
			this.ResumeLayout(false);
		}
	}
}
