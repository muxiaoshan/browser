using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.metadatadesign;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using ImagePosData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class ImagePositionForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("lbxImagePos")]
		private ListBox _lbxImagePos;

		[AccessedThroughProperty("lblImagePos")]
		private Label _lblImagePos;

		[AccessedThroughProperty("lblCode")]
		private Label _lblCode;

		[AccessedThroughProperty("txtCode")]
		private TextBox _txtCode;

		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("txtDesc")]
		private TextBox _txtDesc;

		[AccessedThroughProperty("lblDesc")]
		private Label _lblDesc;

		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[AccessedThroughProperty("ImagePosProperty")]
		private MIImageAnnotateProperty _ImagePosProperty;

		[AccessedThroughProperty("btnCreate")]
		private Button _btnCreate;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		private ImagePos _CurrentImagePos;

		internal virtual ListBox lbxImagePos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbxImagePos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lbxImagePos_SelectedIndexChanged);
				if (this._lbxImagePos != null)
				{
					this._lbxImagePos.SelectedIndexChanged -= value2;
				}
				this._lbxImagePos = value;
				if (this._lbxImagePos != null)
				{
					this._lbxImagePos.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label lblImagePos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblImagePos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblImagePos = value;
			}
		}

		internal virtual Label lblCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCode = value;
			}
		}

		internal virtual TextBox txtCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtCode_TextChanged);
				if (this._txtCode != null)
				{
					this._txtCode.TextChanged -= value2;
				}
				this._txtCode = value;
				if (this._txtCode != null)
				{
					this._txtCode.TextChanged += value2;
				}
			}
		}

		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtName_TextChanged);
				if (this._txtName != null)
				{
					this._txtName.TextChanged -= value2;
				}
				this._txtName = value;
				if (this._txtName != null)
				{
					this._txtName.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblName = value;
			}
		}

		internal virtual TextBox txtDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDesc_TextChanged);
				if (this._txtDesc != null)
				{
					this._txtDesc.TextChanged -= value2;
				}
				this._txtDesc = value;
				if (this._txtDesc != null)
				{
					this._txtDesc.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDesc = value;
			}
		}

		internal virtual Button btnUpdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUpdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnUpdate_Click);
				if (this._btnUpdate != null)
				{
					this._btnUpdate.Click -= value2;
				}
				this._btnUpdate = value;
				if (this._btnUpdate != null)
				{
					this._btnUpdate.Click += value2;
				}
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

		internal virtual MIImageAnnotateProperty ImagePosProperty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImagePosProperty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImagePosProperty = value;
			}
		}

		internal virtual Button btnCreate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCreate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCreate_Click);
				if (this._btnCreate != null)
				{
					this._btnCreate.Click -= value2;
				}
				this._btnCreate = value;
				if (this._btnCreate != null)
				{
					this._btnCreate.Click += value2;
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

		public ImagePos CurrentImagePos
		{
			get
			{
				return this._CurrentImagePos;
			}
			set
			{
				if (value != null)
				{
					this._CurrentImagePos = value;
					this.txtCode.Text = this._CurrentImagePos.Code;
					this.txtDesc.Text = this._CurrentImagePos.Desc;
					this.txtName.Text = this._CurrentImagePos.Name;
					if (this._CurrentImagePos.MIImageAnnotate == null)
					{
						if (this._CurrentImagePos.ID == null | Operators.CompareString(this._CurrentImagePos.ID, "", false) == 0)
						{
							this._CurrentImagePos.MIImageAnnotate = new MIImageAnnotate();
						}
						else
						{
							try
							{
								EImagePosition imagePositionByID = WebServiceLayer.ImagePosAccess.GetImagePositionByID(this._CurrentImagePos.ID);
								this._CurrentImagePos.Data = imagePositionByID.Data;
								if (Operators.CompareString(this._CurrentImagePos.Data, "", false) == 0 | this._CurrentImagePos.Data == null)
								{
									this._CurrentImagePos.MIImageAnnotate = new MIImageAnnotate();
								}
								else
								{
									MIImageAnnotate mIImageAnnotate = new MIImageAnnotate();
									if (!(this._CurrentImagePos.Data == null | Operators.CompareString(this._CurrentImagePos.Data, "", false) == 0))
									{
										mIImageAnnotate.XMLString = this._CurrentImagePos.Data;
									}
									this._CurrentImagePos.MIImageAnnotate = mIImageAnnotate;
								}
							}
							catch (Exception expr_150)
							{
								ProjectData.SetProjectError(expr_150);
								Exception ex = expr_150;
								MessageManager.ShowErrorMessage(ex.ToString() + ex.StackTrace.ToString());
								ProjectData.ClearProjectError();
							}
						}
					}
					this.ImagePosProperty.MIImageAnnotate = this._CurrentImagePos.MIImageAnnotate;
				}
			}
		}

		public ImagePositionForm()
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
			this.lbxImagePos = new ListBox();
			this.lblImagePos = new Label();
			this.lblCode = new Label();
			this.txtCode = new TextBox();
			this.txtName = new TextBox();
			this.lblName = new Label();
			this.txtDesc = new TextBox();
			this.lblDesc = new Label();
			this.ImagePosProperty = new MIImageAnnotateProperty();
			this.btnUpdate = new Button();
			this.btnDelete = new Button();
			this.btnCreate = new Button();
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.SuspendLayout();
			this.lbxImagePos.ItemHeight = 12;
			Control arg_BE_0 = this.lbxImagePos;
			Point location = new Point(8, 72);
			arg_BE_0.Location = location;
			this.lbxImagePos.Name = "lbxImagePos";
			Control arg_EB_0 = this.lbxImagePos;
			Size size = new Size(160, 352);
			arg_EB_0.Size = size;
			this.lbxImagePos.TabIndex = 0;
			Control arg_10D_0 = this.lblImagePos;
			location = new Point(8, 16);
			arg_10D_0.Location = location;
			this.lblImagePos.Name = "lblImagePos";
			Control arg_134_0 = this.lblImagePos;
			size = new Size(80, 16);
			arg_134_0.Size = size;
			this.lblImagePos.TabIndex = 1;
			this.lblImagePos.Text = "图像位置列表";
			Control arg_16A_0 = this.lblCode;
			location = new Point(200, 10);
			arg_16A_0.Location = location;
			this.lblCode.Name = "lblCode";
			Control arg_191_0 = this.lblCode;
			size = new Size(40, 14);
			arg_191_0.Size = size;
			this.lblCode.TabIndex = 2;
			this.lblCode.Text = "代码";
			Control arg_1C6_0 = this.txtCode;
			location = new Point(264, 8);
			arg_1C6_0.Location = location;
			this.txtCode.Name = "txtCode";
			this.txtCode.TabIndex = 3;
			this.txtCode.Text = "";
			Control arg_20B_0 = this.txtName;
			location = new Point(424, 8);
			arg_20B_0.Location = location;
			this.txtName.Name = "txtName";
			Control arg_232_0 = this.txtName;
			size = new Size(120, 21);
			arg_232_0.Size = size;
			this.txtName.TabIndex = 5;
			this.txtName.Text = "";
			Control arg_267_0 = this.lblName;
			location = new Point(376, 8);
			arg_267_0.Location = location;
			this.lblName.Name = "lblName";
			Control arg_28E_0 = this.lblName;
			size = new Size(40, 23);
			arg_28E_0.Size = size;
			this.lblName.TabIndex = 4;
			this.lblName.Text = "名称";
			Control arg_2C4_0 = this.txtDesc;
			location = new Point(264, 40);
			arg_2C4_0.Location = location;
			this.txtDesc.Name = "txtDesc";
			Control arg_2EE_0 = this.txtDesc;
			size = new Size(280, 21);
			arg_2EE_0.Size = size;
			this.txtDesc.TabIndex = 7;
			this.txtDesc.Text = "";
			Control arg_324_0 = this.lblDesc;
			location = new Point(200, 42);
			arg_324_0.Location = location;
			this.lblDesc.Name = "lblDesc";
			Control arg_34B_0 = this.lblDesc;
			size = new Size(40, 14);
			arg_34B_0.Size = size;
			this.lblDesc.TabIndex = 6;
			this.lblDesc.Text = "说明";
			Control arg_381_0 = this.ImagePosProperty;
			location = new Point(192, 72);
			arg_381_0.Location = location;
			this.ImagePosProperty.MIImageAnnotate = null;
			this.ImagePosProperty.Name = "ImagePosProperty";
			this.ImagePosProperty.ShowIcon = false;
			Control arg_3C6_0 = this.ImagePosProperty;
			size = new Size(536, 360);
			arg_3C6_0.Size = size;
			this.ImagePosProperty.TabIndex = 8;
			Control arg_3EB_0 = this.btnUpdate;
			location = new Point(584, 4);
			arg_3EB_0.Location = location;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "更新";
			Control arg_432_0 = this.btnDelete;
			location = new Point(584, 37);
			arg_432_0.Location = location;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "删除";
			Control arg_476_0 = this.btnCreate;
			location = new Point(90, 11);
			arg_476_0.Location = location;
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.TabIndex = 11;
			this.btnCreate.Text = "新建";
			Control arg_4BD_0 = this.btnCancel;
			location = new Point(672, 36);
			arg_4BD_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "取消";
			Control arg_503_0 = this.btnOK;
			location = new Point(672, 4);
			arg_503_0.Location = location;
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "确定";
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(752, 448);
			this.ClientSize = size;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.ImagePosProperty);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.lblImagePos);
			this.Controls.Add(this.lbxImagePos);
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.Name = "ImagePositionForm";
			this.ShowInTaskbar = false;
			this.Text = "图像位置";
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.RefreshList();
		}

		public void RefreshList()
		{
			this.lbxImagePos.Items.Clear();
			try
			{
				EImagePositionDataset aLLImagePosition = WebServiceLayer.ImagePosAccess.GetALLImagePosition();
				try
				{
					IEnumerator enumerator = aLLImagePosition.SelectAll.GetEnumerator();
					while (enumerator.MoveNext())
					{
						EImagePositionDataset.SelectAllRow selectAllRow = (EImagePositionDataset.SelectAllRow)enumerator.Current;
						ImagePos imagePos = new ImagePos();
						imagePos.Name = selectAllRow.Name;
						imagePos.Code = selectAllRow.Code;
						imagePos.ID = Conversions.ToString(selectAllRow.ID);
						this.lbxImagePos.Items.Add(imagePos);
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
				if (this.lbxImagePos.Items.Count > 0)
				{
					this.lbxImagePos.SelectedIndex = 0;
				}
			}
			catch (Exception expr_BA)
			{
				ProjectData.SetProjectError(expr_BA);
				Exception ex = expr_BA;
				MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.lbxImagePos.SelectedItem == null)
			{
				MessageManager.ShowWarningMessage("未选中图像位置，无法删除！");
				return;
			}
			if (MessageManager.ShowQuestionMessage("是否删除？") != DialogResult.Yes)
			{
				return;
			}
			if (this._CurrentImagePos.Desc == null)
			{
				this._CurrentImagePos.Desc = "";
			}
			if (!(this._CurrentImagePos.ID == null | Operators.CompareString(this._CurrentImagePos.ID, "", false) == 0))
			{
				try
				{
					ImagePositionInfo arg_84_0 = WebServiceLayer.ImagePosAccess;
					string arg_84_1 = this._CurrentImagePos.ID;
					bool flag = true;
					bool flag2;
					arg_84_0.DeleteImagePosition(arg_84_1, ref flag2, ref flag);
				}
				catch (Exception expr_8B)
				{
					ProjectData.SetProjectError(expr_8B);
					Exception ex = expr_8B;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
			int selectedIndex = this.lbxImagePos.SelectedIndex;
			this.lbxImagePos.Items.Remove(RuntimeHelpers.GetObjectValue(this.lbxImagePos.SelectedItem));
			if (selectedIndex < this.lbxImagePos.Items.Count)
			{
				this.lbxImagePos.SelectedIndex = selectedIndex;
			}
			else
			{
				this.lbxImagePos.SelectedIndex = checked(this.lbxImagePos.Items.Count - 1);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (this._CurrentImagePos.Code == null | Operators.CompareString(this._CurrentImagePos.Code, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("保存失败，代码为空！");
				return;
			}
			try
			{
				IEnumerator enumerator = this.lbxImagePos.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ImagePos imagePos = (ImagePos)enumerator.Current;
					if (imagePos != this._CurrentImagePos & Operators.CompareString(imagePos.Code, this._CurrentImagePos.Code, false) == 0)
					{
						MessageManager.ShowWarningMessage("保存失败，代码重复！");
						return;
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
			if (this._CurrentImagePos.Name == null | Operators.CompareString(this._CurrentImagePos.Name, "", false) == 0)
			{
				MessageManager.ShowWarningMessage("保存失败，名称为空！");
				return;
			}
			if (this._CurrentImagePos.Desc == null)
			{
				this._CurrentImagePos.Desc = "";
			}
			EImagePosition eImagePosition = new EImagePosition();
			eImagePosition.Code = this._CurrentImagePos.Code;
			eImagePosition.Name = this._CurrentImagePos.Name;
			eImagePosition.Description = this._CurrentImagePos.Desc;
			eImagePosition.ID = this._CurrentImagePos.ID;
			eImagePosition.Data = this._CurrentImagePos.MIImageAnnotate.XMLString;
			if (eImagePosition.ID == null | Operators.CompareString(eImagePosition.ID, "", false) == 0)
			{
				try
				{
					WebServiceLayer.ImagePosAccess.CreateImagePosition(eImagePosition);
					goto IL_1F1;
				}
				catch (Exception expr_192)
				{
					ProjectData.SetProjectError(expr_192);
					Exception ex = expr_192;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
					goto IL_1F1;
				}
			}
			try
			{
				ImagePositionInfo arg_1C3_0 = WebServiceLayer.ImagePosAccess;
				EImagePosition arg_1C3_1 = eImagePosition;
				bool flag = true;
				bool flag2;
				arg_1C3_0.UpdateImagePosition(arg_1C3_1, ref flag2, ref flag);
			}
			catch (Exception expr_1CA)
			{
				ProjectData.SetProjectError(expr_1CA);
				Exception ex2 = expr_1CA;
				MessageManager.ShowErrorMessage(ex2.Message + ex2.StackTrace);
				ProjectData.ClearProjectError();
			}
			IL_1F1:
			MessageManager.ShowInformationMessage("保存成功！");
		}

		private void lbxImagePos_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CurrentImagePos = (ImagePos)this.lbxImagePos.SelectedItem;
		}

		private void txtCode_TextChanged(object sender, EventArgs e)
		{
			if (this._CurrentImagePos != null)
			{
				this._CurrentImagePos.Code = this.txtCode.Text;
			}
		}

		private void txtDesc_TextChanged(object sender, EventArgs e)
		{
			if (this._CurrentImagePos != null)
			{
				this._CurrentImagePos.Desc = this.txtDesc.Text;
			}
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (this._CurrentImagePos != null)
			{
				this._CurrentImagePos.Name = this.txtName.Text;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ImagePos imagePos = new ImagePos();
			imagePos.Name = "新建图像位置对象";
			this.lbxImagePos.Items.Add(imagePos);
			this.lbxImagePos.SelectedItem = imagePos;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
