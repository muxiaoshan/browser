using AdmImageItemData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using ImageItemData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCImageWizard : UserControl
	{
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		[AccessedThroughProperty("btnPrevious")]
		private Button _btnPrevious;

		[AccessedThroughProperty("btnNext")]
		private Button _btnNext;

		[AccessedThroughProperty("btnPublish")]
		private Button _btnPublish;

		[AccessedThroughProperty("lblHint")]
		private Label _lblHint;

		private IContainer components;

		private bool _IsAdmIamgeItem;

		private string _CurrentStatus;

		private string _PublishStatus;

		private byte[] _ImageData;

		private string _HotSpotData;

		private string _IconData;

		private EImageItem _EImageItem;

		private EAdmImageItem _EAdmImageItem;

		[AccessedThroughProperty("DCUpload")]
		private DCUpload _DCUpload;

		[AccessedThroughProperty("DCImageCut")]
		private DCImageCut _DCImageCut;

		[AccessedThroughProperty("DCHotSpot")]
		private DCHotSpot _DCHotSpot;

		[AccessedThroughProperty("DCPreview")]
		private DCPreview _DCPreview;

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

		internal virtual Button btnPrevious
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPrevious;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPrevious_Click);
				if (this._btnPrevious != null)
				{
					this._btnPrevious.Click -= value2;
				}
				this._btnPrevious = value;
				if (this._btnPrevious != null)
				{
					this._btnPrevious.Click += value2;
				}
			}
		}

		internal virtual Button btnNext
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNext;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnNext_Click);
				if (this._btnNext != null)
				{
					this._btnNext.Click -= value2;
				}
				this._btnNext = value;
				if (this._btnNext != null)
				{
					this._btnNext.Click += value2;
				}
			}
		}

		internal virtual Button btnPublish
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPublish;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPublish_Click);
				if (this._btnPublish != null)
				{
					this._btnPublish.Click -= value2;
				}
				this._btnPublish = value;
				if (this._btnPublish != null)
				{
					this._btnPublish.Click += value2;
				}
			}
		}

		internal virtual Label lblHint
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblHint;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblHint = value;
			}
		}

		private virtual DCUpload DCUpload
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCUpload;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCUpload = value;
			}
		}

		private virtual DCImageCut DCImageCut
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCImageCut;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCImageCut = value;
			}
		}

		private virtual DCHotSpot DCHotSpot
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCHotSpot;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCHotSpot = value;
			}
		}

		private virtual DCPreview DCPreview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCPreview;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCPreview = value;
			}
		}

		public EImageItem EImageItem
		{
			get
			{
				return this._EImageItem;
			}
			set
			{
				this.Clear();
				this._EImageItem = value;
				this._IsAdmIamgeItem = false;
				this._CurrentStatus = this._EImageItem.Status;
				this._PublishStatus = this._EImageItem.IsPublish;
				this._ImageData = this._EImageItem.ImageData;
				this._HotSpotData = this._EImageItem.HotSpotData;
				this._IconData = this._EImageItem.IconData;
				this._EAdmImageItem = null;
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
		}

		public EAdmImageItem EAdmImageItem
		{
			get
			{
				return this._EAdmImageItem;
			}
			set
			{
				this.Clear();
				this._EAdmImageItem = value;
				this._IsAdmIamgeItem = true;
				this._CurrentStatus = this._EAdmImageItem.Status;
				this._PublishStatus = this._EAdmImageItem.IsPublish;
				this._ImageData = this._EAdmImageItem.ImageData;
				this._HotSpotData = this._EAdmImageItem.HotSpotData;
				this._IconData = this._EAdmImageItem.IconData;
				this._EImageItem = null;
				this.SetWizard(this._EAdmImageItem.Status, this._PublishStatus);
			}
		}

		public DCImageWizard()
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
			this.SplitContainer1 = new SplitContainer();
			this.btnPrevious = new Button();
			this.btnNext = new Button();
			this.btnPublish = new Button();
			this.lblHint = new Label();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.SuspendLayout();
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			Control arg_80_0 = this.SplitContainer1;
			Point location = new Point(0, 0);
			arg_80_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel2.Controls.Add(this.lblHint);
			this.SplitContainer1.Panel2.Controls.Add(this.btnPrevious);
			this.SplitContainer1.Panel2.Controls.Add(this.btnNext);
			this.SplitContainer1.Panel2.Controls.Add(this.btnPublish);
			Control arg_125_0 = this.SplitContainer1;
			Size size = new Size(500, 320);
			arg_125_0.Size = size;
			this.SplitContainer1.SplitterDistance = 288;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 0;
			this.btnPrevious.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_173_0 = this.btnPrevious;
			location = new Point(264, 4);
			arg_173_0.Location = location;
			this.btnPrevious.Name = "btnPrevious";
			Control arg_19A_0 = this.btnPrevious;
			size = new Size(75, 23);
			arg_19A_0.Size = size;
			this.btnPrevious.TabIndex = 12;
			this.btnPrevious.Text = "上一步(&P)";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnNext.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_1E9_0 = this.btnNext;
			location = new Point(342, 4);
			arg_1E9_0.Location = location;
			this.btnNext.Name = "btnNext";
			Control arg_210_0 = this.btnNext;
			size = new Size(75, 23);
			arg_210_0.Size = size;
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = "下一步(&N)";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnPublish.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_25F_0 = this.btnPublish;
			location = new Point(420, 4);
			arg_25F_0.Location = location;
			this.btnPublish.Name = "btnPublish";
			Control arg_286_0 = this.btnPublish;
			size = new Size(75, 23);
			arg_286_0.Size = size;
			this.btnPublish.TabIndex = 11;
			this.btnPublish.Text = "发布(&P)";
			this.btnPublish.UseVisualStyleBackColor = true;
			this.lblHint.AutoSize = true;
			this.lblHint.ForeColor = Color.Red;
			Control arg_2E1_0 = this.lblHint;
			location = new Point(4, 10);
			arg_2E1_0.Location = location;
			this.lblHint.Name = "lblHint";
			Control arg_30B_0 = this.lblHint;
			size = new Size(233, 12);
			arg_30B_0.Size = size;
			this.lblHint.TabIndex = 13;
			this.lblHint.Text = "提示：图片一旦发布将不能再修改或删除！";
			this.lblHint.TextAlign = ContentAlignment.MiddleLeft;
			this.Controls.Add(this.SplitContainer1);
			this.Name = "DCImageWizard";
			size = new Size(500, 320);
			this.Size = size;
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.Panel2.PerformLayout();
			this.SplitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void Clear()
		{
			this._EImageItem = null;
			this._EAdmImageItem = null;
			this._IsAdmIamgeItem = false;
			this._CurrentStatus = null;
			this._PublishStatus = null;
			this._ImageData = null;
			this._HotSpotData = null;
			this._IconData = null;
			this.SplitContainer1.Panel1.Controls.Clear();
			this.DCImageCut = null;
			this.DCHotSpot = null;
			this.DCPreview = null;
			this.btnPrevious.Visible = false;
			this.btnNext.Visible = false;
			this.btnPublish.Visible = false;
		}

		public void ResetHotSpot()
		{
			if (this._IsAdmIamgeItem)
			{
				if (this._EAdmImageItem == null)
				{
					return;
				}
			}
			else if (this._EImageItem == null)
			{
				return;
			}
			this._CurrentStatus = "2";
			this.SetWizard(this._CurrentStatus, this._PublishStatus);
		}

		public void SyncNameAndDesc(string name, string desc)
		{
			if (this._IsAdmIamgeItem)
			{
				if (this._EAdmImageItem != null)
				{
					this._EAdmImageItem.Name = name;
					this._EAdmImageItem.Description = desc;
				}
			}
			else if (this._EImageItem != null)
			{
				this._EImageItem.Name = name;
				this._EImageItem.Description = desc;
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this._CurrentStatus, "1", false) == 0)
			{
				this._CurrentStatus = "0";
				this._PublishStatus = "0";
				if (!this.UpdateImageItem())
				{
					return;
				}
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
			else if (Operators.CompareString(this._CurrentStatus, "2", false) == 0)
			{
				this._CurrentStatus = "1";
				this._PublishStatus = "0";
				if (!this.UpdateImageItem())
				{
					return;
				}
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
			else if (Operators.CompareString(this._CurrentStatus, "3", false) == 0)
			{
				this._CurrentStatus = "2";
				this._PublishStatus = "0";
				if (!this.UpdateImageItem())
				{
					return;
				}
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this._CurrentStatus, "0", false) == 0)
			{
				this._ImageData = this.DCUpload.ImageData;
				if (this._ImageData == null || this._ImageData.Length == 0)
				{
					MessageManager.ShowErrorMessage("请先上传或从剪贴板拷贝图片!");
				}
				else
				{
					this._CurrentStatus = "1";
					this._PublishStatus = "0";
					if (!this.UpdateImageItem())
					{
						return;
					}
					this.SetWizard(this._CurrentStatus, this._PublishStatus);
				}
			}
			else if (Operators.CompareString(this._CurrentStatus, "1", false) == 0)
			{
				this._ImageData = this.DCImageCut.CutImageData;
				this._CurrentStatus = "2";
				this._PublishStatus = "0";
				if (!this.UpdateImageItem())
				{
					return;
				}
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
			else if (Operators.CompareString(this._CurrentStatus, "2", false) == 0)
			{
				this._CurrentStatus = "3";
				if (Operators.CompareString(this._PublishStatus, "1", false) != 0)
				{
					this._PublishStatus = "0";
				}
				this.DCHotSpot.SerilizeData();
				this._HotSpotData = this.DCHotSpot.HotSpotData;
				this._IconData = this.DCHotSpot.IconAnnoData;
				if (!this.UpdateImageItem())
				{
					return;
				}
				this.SetWizard(this._CurrentStatus, this._PublishStatus);
			}
		}

		private void btnPublish_Click(object sender, EventArgs e)
		{
			this._PublishStatus = Conversions.ToString(1);
			this._CurrentStatus = Conversions.ToString(3);
			if (this.DCHotSpot != null)
			{
				this.DCHotSpot.SerilizeData();
				this._HotSpotData = this.DCHotSpot.HotSpotData;
				this._IconData = this.DCHotSpot.IconAnnoData;
			}
			this.UpdateImageItem();
			this.SplitContainer1.Panel1.Controls.Clear();
			this.SetDCPreview();
		}

		private void SetWizard(string status, string isPublish)
		{
			this.SplitContainer1.Panel1.Controls.Clear();
			if (Operators.CompareString(isPublish, "1", false) == 0 && Conversions.ToDouble(status) == 3.0)
			{
				this.SetDCPreview();
			}
			else if (Operators.CompareString(status, "0", false) == 0)
			{
				this.SetDCUpload();
			}
			else if (Operators.CompareString(status, "1", false) == 0)
			{
				this.SetDCImageCut();
			}
			else if (Operators.CompareString(status, "2", false) == 0)
			{
				this.SetDCHotSpot();
			}
			else if (Operators.CompareString(status, "3", false) == 0)
			{
				this.SetDCPreview();
			}
			else
			{
				MessageManager.ShowErrorMessage("图片状态错误！");
			}
		}

		private void SetDCUpload()
		{
			this.DCUpload = new DCUpload();
			this.DCUpload.Dock = DockStyle.Fill;
			this.DCUpload.ImageData = this._ImageData;
			this.SplitContainer1.Panel1.Controls.Add(this.DCUpload);
			this.btnPrevious.Visible = false;
			this.btnNext.Visible = true;
			this.btnPublish.Visible = true;
			this.btnNext.Enabled = true;
			this.btnPublish.Enabled = false;
		}

		private void SetDCImageCut()
		{
			this.DCImageCut = new DCImageCut();
			this.DCImageCut.Dock = DockStyle.Fill;
			this.DCImageCut.AutoScroll = true;
			this.DCImageCut.ImageData = this._ImageData;
			this.SplitContainer1.Panel1.Controls.Add(this.DCImageCut);
			this.btnPrevious.Visible = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnNext.Visible = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnPublish.Visible = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnPrevious.Enabled = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnNext.Enabled = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnPublish.Enabled = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
		}

		private void SetDCHotSpot()
		{
			this.DCHotSpot = new DCHotSpot();
			this.DCHotSpot.Dock = DockStyle.Fill;
			this.SplitContainer1.Panel1.Controls.Add(this.DCHotSpot);
			this.DCHotSpot.ImageData = this._ImageData;
			this.DCHotSpot.HotSpotData = this._HotSpotData;
			this.DCHotSpot.IconAnnoData = this._IconData;
			this.DCHotSpot.InitData();
			this.btnPrevious.Visible = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnPrevious.Enabled = (Operators.CompareString(this._PublishStatus, "1", false) != 0);
			this.btnNext.Visible = (Operators.CompareString(this._CurrentStatus, "2", false) == 0);
			this.btnNext.Enabled = (Operators.CompareString(this._CurrentStatus, "2", false) == 0);
			this.btnPublish.Visible = (Operators.CompareString(this._CurrentStatus, "2", false) == 0);
			this.btnPublish.Enabled = (Operators.CompareString(this._CurrentStatus, "2", false) == 0);
		}

		private void SetDCPreview()
		{
			this.DCPreview = new DCPreview(false);
			this.DCPreview.Dock = DockStyle.Fill;
			if (this._IsAdmIamgeItem)
			{
				this.DCPreview.EAdmImageItem = this._EAdmImageItem;
			}
			else
			{
				this.DCPreview.EImageItem = this._EImageItem;
			}
			this.SplitContainer1.Panel1.Controls.Add(this.DCPreview);
			this.btnNext.Visible = false;
			if (Conversions.ToDouble(this._PublishStatus) == 1.0)
			{
				this.btnPublish.Visible = false;
				this.btnPrevious.Visible = false;
			}
			else
			{
				this.btnPublish.Visible = true;
				this.btnPublish.Enabled = true;
				this.btnPrevious.Visible = true;
				this.btnPrevious.Enabled = true;
			}
		}

		private bool UpdateImageItem()
		{
			if (this._IsAdmIamgeItem)
			{
				this._EAdmImageItem.ImageData = this._ImageData;
				this._EAdmImageItem.HotSpotData = this._HotSpotData;
				this._EAdmImageItem.IconData = this._IconData;
				this._EAdmImageItem.Status = this._CurrentStatus;
				this._EAdmImageItem.IsPublish = this._PublishStatus;
				string value = WebServiceLayer.AdmImageItemAccess.Update(this._EAdmImageItem);
				return Conversions.ToBoolean(Interaction.IIf(Conversions.ToDouble(value) == 1.0, true, false));
			}
			this._EImageItem.ImageData = this._ImageData;
			this._EImageItem.HotSpotData = this._HotSpotData;
			this._EImageItem.IconData = this._IconData;
			this._EImageItem.Status = this._CurrentStatus;
			this._EImageItem.IsPublish = this._PublishStatus;
			string value2 = WebServiceLayer.ImageItemAccess.Update(this._EImageItem);
			return Conversions.ToBoolean(Interaction.IIf(Conversions.ToDouble(value2) == 1.0, true, false));
		}
	}
}
