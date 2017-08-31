using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using KBTreeData;
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

namespace dhcc.epr.eprlib.design.kbdesign
{
	public class DCKBTreeCategory : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("lblCategoryDesc")]
		private Label _lblCategoryDesc;

		[AccessedThroughProperty("txtCategoryName")]
		private TextBox _txtCategoryName;

		[AccessedThroughProperty("lblCategoryName")]
		private Label _lblCategoryName;

		[AccessedThroughProperty("txtCategoryDesc")]
		private TextBox _txtCategoryDesc;

		[AccessedThroughProperty("cklRuleList")]
		private CheckedListBox _cklRuleList;

		[AccessedThroughProperty("cklLocitList")]
		private CheckedListBox _cklLocitList;

		[AccessedThroughProperty("txtLocitList")]
		private TextBox _txtLocitList;

		[AccessedThroughProperty("lblRuleList")]
		private Label _lblRuleList;

		[AccessedThroughProperty("lblLocitList")]
		private Label _lblLocitList;

		[AccessedThroughProperty("btnAdd")]
		private Button _btnAdd;

		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[AccessedThroughProperty("ckbSelectAllRule")]
		private CheckBox _ckbSelectAllRule;

		[AccessedThroughProperty("ckbSelectAllLocit")]
		private CheckBox _ckbSelectAllLocit;

		private string _KBTreeID;

		private EKBTree _EKBTree;

		private bool _Editable;

		private DataSet _dsSource;

		private bool _EnableRoleKBTree;

		private List<string> _KbIDs;

		public const string WARNNING_EMPTYLOCIDSTR = "当前关联科室为空，是否确定进行保存";

		public const string ERROR_SAVEBINDLOCFAIL = "保存知识库节点与科室关联失败";

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

		internal virtual Label lblCategoryDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCategoryDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCategoryDesc = value;
			}
		}

		internal virtual TextBox txtCategoryName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCategoryName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCategoryName = value;
			}
		}

		internal virtual Label lblCategoryName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCategoryName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCategoryName = value;
			}
		}

		internal virtual TextBox txtCategoryDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCategoryDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCategoryDesc = value;
			}
		}

		internal virtual CheckedListBox cklRuleList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cklRuleList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cklRuleList = value;
			}
		}

		internal virtual CheckedListBox cklLocitList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cklLocitList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cklLocitList = value;
			}
		}

		internal virtual TextBox txtLocitList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtLocitList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtLocitList_TextChanged);
				if (this._txtLocitList != null)
				{
					this._txtLocitList.TextChanged -= value2;
				}
				this._txtLocitList = value;
				if (this._txtLocitList != null)
				{
					this._txtLocitList.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblRuleList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblRuleList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblRuleList = value;
			}
		}

		internal virtual Label lblLocitList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLocitList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLocitList = value;
			}
		}

		internal virtual Button btnAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAdd_Click);
				if (this._btnAdd != null)
				{
					this._btnAdd.Click -= value2;
				}
				this._btnAdd = value;
				if (this._btnAdd != null)
				{
					this._btnAdd.Click += value2;
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

		internal virtual CheckBox ckbSelectAllRule
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbSelectAllRule;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbSelectAllRule_CheckedChanged);
				if (this._ckbSelectAllRule != null)
				{
					this._ckbSelectAllRule.CheckedChanged -= value2;
				}
				this._ckbSelectAllRule = value;
				if (this._ckbSelectAllRule != null)
				{
					this._ckbSelectAllRule.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox ckbSelectAllLocit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbSelectAllLocit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ckbSelectAllLocit_CheckedChanged);
				if (this._ckbSelectAllLocit != null)
				{
					this._ckbSelectAllLocit.CheckedChanged -= value2;
				}
				this._ckbSelectAllLocit = value;
				if (this._ckbSelectAllLocit != null)
				{
					this._ckbSelectAllLocit.CheckedChanged += value2;
				}
			}
		}

		public string KBTreeID
		{
			get
			{
				return this._KBTreeID;
			}
			set
			{
				this._KBTreeID = value;
				try
				{
					this._EKBTree = WebServiceLayer.KBTreeAccess.SelectKBTreeBYID(this._KBTreeID);
					if (this._EKBTree != null)
					{
						this.txtCategoryName.Text = this._EKBTree.Name;
						this.txtCategoryDesc.Text = this._EKBTree.Description;
						if (Conversions.ToDouble(this._EKBTree.ParentID) == 0.0)
						{
							this.lblRuleList.Visible = true;
							this.cklRuleList.Visible = true;
							this.ckbSelectAllRule.Visible = true;
							this.lblLocitList.Visible = true;
							this.txtLocitList.Visible = true;
							this.cklLocitList.Visible = true;
							this.ckbSelectAllLocit.Visible = true;
							this.btnAdd.Visible = true;
							this.btnDelete.Visible = true;
							this.txtLocitList.Text = string.Empty;
							this.InitRuleList(this._EKBTree.ID);
							this.InitLocitList();
							this.InitSelectAllCheck();
						}
						else
						{
							this.lblRuleList.Visible = false;
							this.cklRuleList.Visible = false;
							this.ckbSelectAllRule.Visible = false;
							this.lblLocitList.Visible = false;
							this.txtLocitList.Visible = false;
							this.cklLocitList.Visible = false;
							this.ckbSelectAllLocit.Visible = false;
							this.btnAdd.Visible = false;
							this.btnDelete.Visible = false;
						}
					}
				}
				catch (Exception expr_17B)
				{
					ProjectData.SetProjectError(expr_17B);
					Exception ex = expr_17B;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
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
				this.btnSave.Visible = value;
			}
		}

		public DCKBTreeCategory()
		{
			this._EnableRoleKBTree = false;
			this.InitializeComponent();
			this.getAllLocid();
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
			this.txtCategoryDesc = new TextBox();
			this.lblCategoryDesc = new Label();
			this.txtCategoryName = new TextBox();
			this.lblCategoryName = new Label();
			this.cklRuleList = new CheckedListBox();
			this.cklLocitList = new CheckedListBox();
			this.txtLocitList = new TextBox();
			this.lblRuleList = new Label();
			this.lblLocitList = new Label();
			this.btnAdd = new Button();
			this.btnDelete = new Button();
			this.ckbSelectAllRule = new CheckBox();
			this.ckbSelectAllLocit = new CheckBox();
			this.SuspendLayout();
			Control arg_B4_0 = this.btnSave;
			Point location = new Point(352, 8);
			arg_B4_0.Location = location;
			this.btnSave.Name = "btnSave";
			Control arg_DB_0 = this.btnSave;
			Size size = new Size(75, 23);
			arg_DB_0.Size = size;
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "保存";
			Control arg_10F_0 = this.txtCategoryDesc;
			location = new Point(96, 40);
			arg_10F_0.Location = location;
			this.txtCategoryDesc.Multiline = true;
			this.txtCategoryDesc.Name = "txtCategoryDesc";
			Control arg_145_0 = this.txtCategoryDesc;
			size = new Size(408, 40);
			arg_145_0.Size = size;
			this.txtCategoryDesc.TabIndex = 23;
			Control arg_169_0 = this.lblCategoryDesc;
			location = new Point(32, 40);
			arg_169_0.Location = location;
			this.lblCategoryDesc.Name = "lblCategoryDesc";
			Control arg_190_0 = this.lblCategoryDesc;
			size = new Size(64, 16);
			arg_190_0.Size = size;
			this.lblCategoryDesc.TabIndex = 22;
			this.lblCategoryDesc.Text = "节点说明";
			Control arg_1C3_0 = this.txtCategoryName;
			location = new Point(96, 8);
			arg_1C3_0.Location = location;
			this.txtCategoryName.Name = "txtCategoryName";
			Control arg_1ED_0 = this.txtCategoryName;
			size = new Size(152, 21);
			arg_1ED_0.Size = size;
			this.txtCategoryName.TabIndex = 21;
			Control arg_210_0 = this.lblCategoryName;
			location = new Point(32, 8);
			arg_210_0.Location = location;
			this.lblCategoryName.Name = "lblCategoryName";
			Control arg_237_0 = this.lblCategoryName;
			size = new Size(64, 16);
			arg_237_0.Size = size;
			this.lblCategoryName.TabIndex = 20;
			this.lblCategoryName.Text = "目录名称";
			Control arg_26B_0 = this.cklRuleList;
			location = new Point(24, 120);
			arg_26B_0.Location = location;
			this.cklRuleList.Name = "cklRuleList";
			Control arg_298_0 = this.cklRuleList;
			size = new Size(208, 324);
			arg_298_0.Size = size;
			this.cklRuleList.TabIndex = 25;
			this.cklRuleList.Visible = false;
			Control arg_2CB_0 = this.cklLocitList;
			location = new Point(296, 120);
			arg_2CB_0.Location = location;
			this.cklLocitList.Name = "cklLocitList";
			Control arg_2F8_0 = this.cklLocitList;
			size = new Size(208, 324);
			arg_2F8_0.Size = size;
			this.cklLocitList.TabIndex = 26;
			this.cklLocitList.Visible = false;
			Control arg_32B_0 = this.txtLocitList;
			location = new Point(368, 88);
			arg_32B_0.Location = location;
			this.txtLocitList.Name = "txtLocitList";
			Control arg_355_0 = this.txtLocitList;
			size = new Size(136, 21);
			arg_355_0.Size = size;
			this.txtLocitList.TabIndex = 27;
			this.txtLocitList.Visible = false;
			Control arg_385_0 = this.lblRuleList;
			location = new Point(32, 94);
			arg_385_0.Location = location;
			this.lblRuleList.Name = "lblRuleList";
			Control arg_3AC_0 = this.lblRuleList;
			size = new Size(56, 16);
			arg_3AC_0.Size = size;
			this.lblRuleList.TabIndex = 28;
			this.lblRuleList.Text = "已选科室";
			this.lblRuleList.Visible = false;
			Control arg_3EF_0 = this.lblLocitList;
			location = new Point(296, 93);
			arg_3EF_0.Location = location;
			this.lblLocitList.Name = "lblLocitList";
			Control arg_416_0 = this.lblLocitList;
			size = new Size(72, 16);
			arg_416_0.Size = size;
			this.lblLocitList.TabIndex = 29;
			this.lblLocitList.Text = "科室字典表";
			this.lblLocitList.Visible = false;
			Control arg_45C_0 = this.btnAdd;
			location = new Point(240, 192);
			arg_45C_0.Location = location;
			this.btnAdd.Name = "btnAdd";
			Control arg_483_0 = this.btnAdd;
			size = new Size(48, 32);
			arg_483_0.Size = size;
			this.btnAdd.TabIndex = 30;
			this.btnAdd.Text = "<<";
			this.btnAdd.Visible = false;
			Control arg_4C9_0 = this.btnDelete;
			location = new Point(240, 280);
			arg_4C9_0.Location = location;
			this.btnDelete.Name = "btnDelete";
			Control arg_4F0_0 = this.btnDelete;
			size = new Size(48, 32);
			arg_4F0_0.Size = size;
			this.btnDelete.TabIndex = 31;
			this.btnDelete.Text = ">>";
			this.btnDelete.Visible = false;
			Control arg_533_0 = this.ckbSelectAllRule;
			location = new Point(24, 456);
			arg_533_0.Location = location;
			this.ckbSelectAllRule.Name = "ckbSelectAllRule";
			Control arg_55A_0 = this.ckbSelectAllRule;
			size = new Size(64, 24);
			arg_55A_0.Size = size;
			this.ckbSelectAllRule.TabIndex = 32;
			this.ckbSelectAllRule.Text = "全选";
			this.ckbSelectAllRule.Visible = false;
			Control arg_5A0_0 = this.ckbSelectAllLocit;
			location = new Point(296, 456);
			arg_5A0_0.Location = location;
			this.ckbSelectAllLocit.Name = "ckbSelectAllLocit";
			Control arg_5C7_0 = this.ckbSelectAllLocit;
			size = new Size(64, 24);
			arg_5C7_0.Size = size;
			this.ckbSelectAllLocit.TabIndex = 33;
			this.ckbSelectAllLocit.Text = "全选";
			this.ckbSelectAllLocit.Visible = false;
			this.Controls.Add(this.ckbSelectAllLocit);
			this.Controls.Add(this.ckbSelectAllRule);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblLocitList);
			this.Controls.Add(this.lblRuleList);
			this.Controls.Add(this.txtLocitList);
			this.Controls.Add(this.cklLocitList);
			this.Controls.Add(this.cklRuleList);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtCategoryDesc);
			this.Controls.Add(this.lblCategoryDesc);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.lblCategoryName);
			this.Name = "DCKBTreeCategory";
			size = new Size(528, 496);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public void SetBtnEnable()
		{
			bool enabled = !this._EnableRoleKBTree || -1 < this._KbIDs.IndexOf(this.KBTreeID);
			this.btnSave.Enabled = enabled;
		}

		public void SetRoleKBTree(bool enableRoleKBTree, ref List<string> kbIDs)
		{
			this._EnableRoleKBTree = enableRoleKBTree;
			this._KbIDs = kbIDs;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this._EKBTree != null)
					{
						TextBox txtCategoryName = this.txtCategoryName;
						string text = txtCategoryName.Text;
						TextBox txtCategoryDesc = this.txtCategoryDesc;
						string text2 = txtCategoryDesc.Text;
						this.CategoryEdit(ref text, ref text2);
						txtCategoryDesc.Text = text2;
						txtCategoryName.Text = text;
					}
					string text3 = "";
					int count = this.cklRuleList.Items.Count;
					int arg_63_0 = 0;
					int num = count - 1;
					for (int i = arg_63_0; i <= num; i++)
					{
						if (Operators.CompareString(text3, "", false) == 0)
						{
							text3 = Conversions.ToString(Operators.AddObject(text3, NewLateBinding.LateGet(this.cklRuleList.Items[i], null, "RowId", new object[0], null, null, null)));
						}
						else
						{
							text3 = Conversions.ToString(Operators.AddObject(text3, Operators.AddObject("^", NewLateBinding.LateGet(this.cklRuleList.Items[i], null, "RowId", new object[0], null, null, null))));
						}
					}
					if (Operators.CompareString(text3, "", false) == 0)
					{
						DialogResult dialogResult = MessageManager.ShowWarningMessage("当前关联科室为空，是否确定进行保存");
						if (dialogResult == DialogResult.OK)
						{
							string value = WebServiceLayer.KbConfigAccess.SaveBindLoc(this._EKBTree.ID, text3);
							if (Conversions.ToDouble(value) == 0.0)
							{
								MessageManager.ShowErrorMessage("保存知识库节点与科室关联失败");
							}
						}
					}
					else
					{
						string value2 = WebServiceLayer.KbConfigAccess.SaveBindLoc(this._EKBTree.ID, text3);
						if (Conversions.ToDouble(value2) == 0.0)
						{
							MessageManager.ShowErrorMessage("保存知识库节点与科室关联失败");
						}
					}
					this.txtLocitList.Text = string.Empty;
				}
				catch (Exception expr_18C)
				{
					ProjectData.SetProjectError(expr_18C);
					Exception ex = expr_18C;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		public void CategoryEdit(ref string CategoryName, ref string CategoryDesc)
		{
			this._EKBTree.Name = CategoryName;
			this._EKBTree.Description = CategoryDesc;
			KBTreeInfo arg_2B_0 = WebServiceLayer.KBTreeAccess;
			EKBTree arg_2B_1 = this._EKBTree;
			bool flag = true;
			bool flag2;
			arg_2B_0.UpdateKBTree(arg_2B_1, ref flag2, ref flag);
		}

		private void txtLocitList_TextChanged(object sender, EventArgs e)
		{
			this.cklLocitList.Items.Clear();
			string value = this.txtLocitList.Text.ToUpper();
			DataTable dataTable = this._dsSource.Tables[0];
			if (dataTable.Rows.Count != 0)
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						checkListItem checkListItem = default(checkListItem);
						checkListItem.RowId = Conversions.ToString(dataRow["RowId"]);
						checkListItem.Code = Conversions.ToString(dataRow["Code"]);
						checkListItem.Desc = Conversions.ToString(dataRow["Des"]);
						if (checkListItem.Desc.IndexOf(value) != -1 && !this.cklRuleList.Items.Contains(checkListItem))
						{
							this.cklLocitList.Items.Add(checkListItem);
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Collection collection = new Collection();
			checked
			{
				if (this.cklLocitList.CheckedItems.Count != 0)
				{
					int arg_2D_0 = 0;
					int num = this.cklLocitList.CheckedItems.Count - 1;
					for (int i = arg_2D_0; i <= num; i++)
					{
						this.cklRuleList.Items.Add(RuntimeHelpers.GetObjectValue(this.cklLocitList.CheckedItems[i]));
						collection.Add(RuntimeHelpers.GetObjectValue(this.cklLocitList.CheckedItems[i]), null, null, null);
					}
				}
				if (collection.Count != 0)
				{
					int arg_90_0 = 1;
					int count = collection.Count;
					for (int j = arg_90_0; j <= count; j++)
					{
						this.cklLocitList.Items.Remove(RuntimeHelpers.GetObjectValue(collection[j]));
					}
				}
				this.InitSelectAllCheck();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Collection collection = new Collection();
			checked
			{
				if (this.cklRuleList.CheckedItems.Count != 0)
				{
					int arg_2D_0 = 0;
					int num = this.cklRuleList.CheckedItems.Count - 1;
					for (int i = arg_2D_0; i <= num; i++)
					{
						this.cklLocitList.Items.Add(RuntimeHelpers.GetObjectValue(this.cklRuleList.CheckedItems[i]));
						collection.Add(RuntimeHelpers.GetObjectValue(this.cklRuleList.CheckedItems[i]), null, null, null);
					}
				}
				if (collection.Count != 0)
				{
					int arg_90_0 = 1;
					int count = collection.Count;
					for (int j = arg_90_0; j <= count; j++)
					{
						this.cklRuleList.Items.Remove(RuntimeHelpers.GetObjectValue(collection[j]));
					}
				}
				this.InitSelectAllCheck();
			}
		}

		private void ckbSelectAllRule_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.ckbSelectAllRule.Checked)
				{
					int arg_21_0 = 0;
					int num = this.cklRuleList.Items.Count - 1;
					for (int i = arg_21_0; i <= num; i++)
					{
						this.cklRuleList.SetItemChecked(i, true);
					}
				}
				else
				{
					int arg_4F_0 = 0;
					int num2 = this.cklRuleList.Items.Count - 1;
					for (int i = arg_4F_0; i <= num2; i++)
					{
						this.cklRuleList.SetItemChecked(i, false);
					}
				}
			}
		}

		private void ckbSelectAllLocit_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.ckbSelectAllLocit.Checked)
				{
					int arg_21_0 = 0;
					int num = this.cklLocitList.Items.Count - 1;
					for (int i = arg_21_0; i <= num; i++)
					{
						this.cklLocitList.SetItemChecked(i, true);
					}
				}
				else
				{
					int arg_4F_0 = 0;
					int num2 = this.cklLocitList.Items.Count - 1;
					for (int i = arg_4F_0; i <= num2; i++)
					{
						this.cklLocitList.SetItemChecked(i, false);
					}
				}
			}
		}

		private void InitRuleList(string kbID)
		{
			this.cklRuleList.Items.Clear();
			string bindLocByID = WebServiceLayer.KbConfigAccess.GetBindLocByID(kbID);
			checked
			{
				if (Operators.CompareString(bindLocByID, "", false) != 0)
				{
					string[] array = bindLocByID.Split(new char[]
					{
						'^'
					});
					int arg_4D_0 = 0;
					int num = array.Length - 1;
					for (int i = arg_4D_0; i <= num; i++)
					{
						try
						{
							IEnumerator enumerator = this._dsSource.Tables[0].Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								if (Operators.ConditionalCompareObjectEqual(dataRow["RowId"], array[i], false))
								{
									checkListItem checkListItem = default(checkListItem);
									checkListItem.RowId = Conversions.ToString(dataRow["RowId"]);
									checkListItem.Code = Conversions.ToString(dataRow["Code"]);
									checkListItem.Desc = Conversions.ToString(dataRow["Des"]);
									this.cklRuleList.Items.Add(checkListItem);
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
		}

		private void InitLocitList()
		{
			this.cklLocitList.Items.Clear();
			DataTable dataTable = this._dsSource.Tables[0];
			if (dataTable.Rows.Count != 0)
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						checkListItem checkListItem = default(checkListItem);
						checkListItem.RowId = Conversions.ToString(dataRow["RowId"]);
						checkListItem.Code = Conversions.ToString(dataRow["Code"]);
						checkListItem.Desc = Conversions.ToString(dataRow["Des"]);
						if (!this.cklRuleList.Items.Contains(checkListItem))
						{
							this.cklLocitList.Items.Add(checkListItem);
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

		private void InitSelectAllCheck()
		{
			if (this.cklLocitList.Items.Count != 0 && this.cklLocitList.SelectedItems.Count == this.cklLocitList.Items.Count)
			{
				this.ckbSelectAllLocit.Checked = true;
			}
			else
			{
				this.ckbSelectAllLocit.Checked = false;
			}
			if (this.cklRuleList.Items.Count != 0 && this.cklRuleList.SelectedItems.Count == this.cklRuleList.Items.Count)
			{
				this.ckbSelectAllRule.Checked = true;
			}
			else
			{
				this.ckbSelectAllRule.Checked = false;
			}
		}

		private void getAllLocid()
		{
			this._dsSource = WebServiceLayer.KbConfigAccess.GetAllLoc();
		}
	}
}
