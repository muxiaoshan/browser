using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using DictionaryData;
using Microsoft.VisualBasic;
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
	public class MIDictionaryProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblDicType")]
		private Label _lblDicType;

		[AccessedThroughProperty("cbxDicType")]
		private ComboBox _cbxDicType;

		[AccessedThroughProperty("txtDicClassName")]
		private TextBox _txtDicClassName;

		[AccessedThroughProperty("lblDicClassName")]
		private Label _lblDicClassName;

		[AccessedThroughProperty("lblStdDic")]
		private Label _lblStdDic;

		[AccessedThroughProperty("cbxStdDic")]
		private ComboBox _cbxStdDic;

		[AccessedThroughProperty("lblDisplayType")]
		private Label _lblDisplayType;

		[AccessedThroughProperty("cbxDisplayType")]
		private ComboBox _cbxDisplayType;

		[AccessedThroughProperty("txtSeporator")]
		private TextBox _txtSeporator;

		[AccessedThroughProperty("lblSeporator")]
		private Label _lblSeporator;

		[AccessedThroughProperty("lblResult")]
		private Label _lblResult;

		[AccessedThroughProperty("cbxFirstCol")]
		private ComboBox _cbxFirstCol;

		[AccessedThroughProperty("cbxSecondCol")]
		private ComboBox _cbxSecondCol;

		[AccessedThroughProperty("cbxThirdCol")]
		private ComboBox _cbxThirdCol;

		[AccessedThroughProperty("cbxAllowCodeNull")]
		private CheckBox _cbxAllowCodeNull;

		[AccessedThroughProperty("lblAssociateItem")]
		private Label _lblAssociateItem;

		[AccessedThroughProperty("txtAssociateItem")]
		private TextBox _txtAssociateItem;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("cbxAllowValueNull")]
		private CheckBox _cbxAllowValueNull;

		private MIDictionary _MIDictionary;

		private EStdDictionaryDataset _StdDicDataSet;

		public MetaItemTree MetaItemTree;

		internal virtual Label lblDicType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDicType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDicType = value;
			}
		}

		internal virtual ComboBox cbxDicType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxDicType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxDicType_SelectedIndexChanged);
				if (this._cbxDicType != null)
				{
					this._cbxDicType.SelectedIndexChanged -= value2;
				}
				this._cbxDicType = value;
				if (this._cbxDicType != null)
				{
					this._cbxDicType.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TextBox txtDicClassName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDicClassName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDicClassName_TextChanged);
				if (this._txtDicClassName != null)
				{
					this._txtDicClassName.TextChanged -= value2;
				}
				this._txtDicClassName = value;
				if (this._txtDicClassName != null)
				{
					this._txtDicClassName.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblDicClassName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDicClassName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDicClassName = value;
			}
		}

		internal virtual Label lblStdDic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStdDic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStdDic = value;
			}
		}

		internal virtual ComboBox cbxStdDic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxStdDic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxStdDic_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.cbxStdDic_DropDown);
				if (this._cbxStdDic != null)
				{
					this._cbxStdDic.SelectedIndexChanged -= value2;
					this._cbxStdDic.DropDown -= value3;
				}
				this._cbxStdDic = value;
				if (this._cbxStdDic != null)
				{
					this._cbxStdDic.SelectedIndexChanged += value2;
					this._cbxStdDic.DropDown += value3;
				}
			}
		}

		internal virtual Label lblDisplayType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDisplayType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDisplayType = value;
			}
		}

		internal virtual ComboBox cbxDisplayType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxDisplayType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxDisplayType_SelectedIndexChanged);
				if (this._cbxDisplayType != null)
				{
					this._cbxDisplayType.SelectedIndexChanged -= value2;
				}
				this._cbxDisplayType = value;
				if (this._cbxDisplayType != null)
				{
					this._cbxDisplayType.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TextBox txtSeporator
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSeporator;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSeporator_TextChanged);
				if (this._txtSeporator != null)
				{
					this._txtSeporator.TextChanged -= value2;
				}
				this._txtSeporator = value;
				if (this._txtSeporator != null)
				{
					this._txtSeporator.TextChanged += value2;
				}
			}
		}

		internal virtual Label lblSeporator
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSeporator;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblSeporator_Click);
				if (this._lblSeporator != null)
				{
					this._lblSeporator.Click -= value2;
				}
				this._lblSeporator = value;
				if (this._lblSeporator != null)
				{
					this._lblSeporator.Click += value2;
				}
			}
		}

		internal virtual Label lblResult
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblResult;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblResult = value;
			}
		}

		internal virtual ComboBox cbxFirstCol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxFirstCol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxFirstCol_SelectedIndexChanged);
				if (this._cbxFirstCol != null)
				{
					this._cbxFirstCol.SelectedIndexChanged -= value2;
				}
				this._cbxFirstCol = value;
				if (this._cbxFirstCol != null)
				{
					this._cbxFirstCol.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbxSecondCol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxSecondCol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxSecondCol_SelectedIndexChanged);
				if (this._cbxSecondCol != null)
				{
					this._cbxSecondCol.SelectedIndexChanged -= value2;
				}
				this._cbxSecondCol = value;
				if (this._cbxSecondCol != null)
				{
					this._cbxSecondCol.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbxThirdCol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxThirdCol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxThirdCol_SelectedIndexChanged);
				if (this._cbxThirdCol != null)
				{
					this._cbxThirdCol.SelectedIndexChanged -= value2;
				}
				this._cbxThirdCol = value;
				if (this._cbxThirdCol != null)
				{
					this._cbxThirdCol.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual CheckBox cbxAllowCodeNull
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxAllowCodeNull;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxAllowCodeNull_CheckStateChanged);
				if (this._cbxAllowCodeNull != null)
				{
					this._cbxAllowCodeNull.CheckStateChanged -= value2;
				}
				this._cbxAllowCodeNull = value;
				if (this._cbxAllowCodeNull != null)
				{
					this._cbxAllowCodeNull.CheckStateChanged += value2;
				}
			}
		}

		internal virtual Label lblAssociateItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAssociateItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAssociateItem = value;
			}
		}

		internal virtual TextBox txtAssociateItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAssociateItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.txtAssociateItem_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.txtAssociateItem_DragEnter);
				EventHandler value4 = new EventHandler(this.txtAssociateItem_TextChanged);
				if (this._txtAssociateItem != null)
				{
					this._txtAssociateItem.DragDrop -= value2;
					this._txtAssociateItem.DragEnter -= value3;
					this._txtAssociateItem.TextChanged -= value4;
				}
				this._txtAssociateItem = value;
				if (this._txtAssociateItem != null)
				{
					this._txtAssociateItem.DragDrop += value2;
					this._txtAssociateItem.DragEnter += value3;
					this._txtAssociateItem.TextChanged += value4;
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

		internal virtual CheckBox cbxAllowValueNull
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxAllowValueNull;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxAllowValueNull_CheckedChanged);
				if (this._cbxAllowValueNull != null)
				{
					this._cbxAllowValueNull.CheckedChanged -= value2;
				}
				this._cbxAllowValueNull = value;
				if (this._cbxAllowValueNull != null)
				{
					this._cbxAllowValueNull.CheckedChanged += value2;
				}
			}
		}

		public MIDictionary MIDictionary
		{
			get
			{
				return this._MIDictionary;
			}
			set
			{
				this._MIDictionary = value;
				this._StdDicDataSet = null;
				this.cbxStdDic.Items.Clear();
				this.cbxStdDic.Text = this._MIDictionary.StdDicName;
				this.txtDicClassName.Text = this._MIDictionary.CustDicClassName;
				if (this._MIDictionary.FirstColType == ColType.Alias)
				{
					this.cbxFirstCol.SelectedIndex = 0;
				}
				else if (this._MIDictionary.FirstColType == ColType.Code)
				{
					this.cbxFirstCol.SelectedIndex = 1;
				}
				else if (this._MIDictionary.FirstColType == ColType.Desc)
				{
					this.cbxFirstCol.SelectedIndex = 2;
				}
				else if (this._MIDictionary.FirstColType == ColType.None)
				{
					this.cbxFirstCol.SelectedIndex = 3;
				}
				if (this._MIDictionary.SecondColType == ColType.Alias)
				{
					this.cbxSecondCol.SelectedIndex = 0;
				}
				else if (this._MIDictionary.SecondColType == ColType.Code)
				{
					this.cbxSecondCol.SelectedIndex = 1;
				}
				else if (this._MIDictionary.SecondColType == ColType.Desc)
				{
					this.cbxSecondCol.SelectedIndex = 2;
				}
				else if (this._MIDictionary.SecondColType == ColType.None)
				{
					this.cbxSecondCol.SelectedIndex = 3;
				}
				if (this._MIDictionary.ThirdColType == ColType.Alias)
				{
					this.cbxThirdCol.SelectedIndex = 0;
				}
				else if (this._MIDictionary.ThirdColType == ColType.Code)
				{
					this.cbxThirdCol.SelectedIndex = 1;
				}
				else if (this._MIDictionary.ThirdColType == ColType.Desc)
				{
					this.cbxThirdCol.SelectedIndex = 2;
				}
				else if (this._MIDictionary.ThirdColType == ColType.None)
				{
					this.cbxThirdCol.SelectedIndex = 3;
				}
				if (Operators.CompareString(this._MIDictionary.DictionaryType, "STDDIC", false) == 0)
				{
					this.cbxDicType.SelectedIndex = 0;
					this.lblStdDic.Enabled = true;
					this.cbxStdDic.Enabled = true;
					this.cbxStdDic.Text = this._MIDictionary.StdDicName;
					this.lblDicClassName.Enabled = false;
					this.txtDicClassName.Enabled = false;
					this.lblResult.Enabled = true;
					this.cbxFirstCol.Enabled = true;
					this.cbxSecondCol.Enabled = true;
					this.cbxThirdCol.Enabled = true;
				}
				else
				{
					this.cbxDicType.SelectedIndex = 1;
					this.lblStdDic.Enabled = false;
					this.cbxStdDic.Enabled = false;
					this.lblDicClassName.Enabled = true;
					this.txtDicClassName.Enabled = true;
					this.lblResult.Enabled = false;
					this.cbxFirstCol.Enabled = false;
					this.cbxSecondCol.Enabled = false;
					this.cbxThirdCol.Enabled = false;
				}
				if (this._MIDictionary.DisplayType == DisplayType.Desc)
				{
					this.cbxDisplayType.SelectedIndex = 0;
					this.lblSeporator.Enabled = false;
					this.txtSeporator.Enabled = false;
				}
				else if (this._MIDictionary.DisplayType == DisplayType.Code)
				{
					this.cbxDisplayType.SelectedIndex = 1;
					this.lblSeporator.Enabled = false;
					this.txtSeporator.Enabled = false;
				}
				else if (this._MIDictionary.DisplayType == DisplayType.CodeDesc)
				{
					this.cbxDisplayType.SelectedIndex = 2;
					this.txtSeporator.Text = this._MIDictionary.Seporator;
					this.lblSeporator.Enabled = true;
					this.txtSeporator.Enabled = true;
				}
				else if (this._MIDictionary.DisplayType == DisplayType.DescCode)
				{
					this.cbxDisplayType.SelectedIndex = 3;
					this.txtSeporator.Text = this._MIDictionary.Seporator;
					this.lblSeporator.Enabled = true;
					this.txtSeporator.Enabled = true;
				}
				this.cbxAllowCodeNull.Checked = this._MIDictionary.AllowCodeNull;
				this.cbxAllowValueNull.Checked = this._MIDictionary.AllowValueNull;
				this.txtAssociateItem.Text = this._MIDictionary.AssociateItem;
			}
		}

		public MIDictionaryProperty()
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
			this.lblDicType = new Label();
			this.cbxDicType = new ComboBox();
			this.txtDicClassName = new TextBox();
			this.lblDicClassName = new Label();
			this.lblStdDic = new Label();
			this.cbxStdDic = new ComboBox();
			this.lblDisplayType = new Label();
			this.cbxDisplayType = new ComboBox();
			this.txtSeporator = new TextBox();
			this.lblSeporator = new Label();
			this.lblResult = new Label();
			this.cbxFirstCol = new ComboBox();
			this.cbxSecondCol = new ComboBox();
			this.cbxThirdCol = new ComboBox();
			this.cbxAllowCodeNull = new CheckBox();
			this.cbxAllowValueNull = new CheckBox();
			this.lblAssociateItem = new Label();
			this.txtAssociateItem = new TextBox();
			this.Label1 = new Label();
			this.SuspendLayout();
			Control arg_E7_0 = this.lblDicType;
			Point location = new Point(6, 7);
			arg_E7_0.Location = location;
			this.lblDicType.Name = "lblDicType";
			Control arg_10E_0 = this.lblDicType;
			Size size = new Size(105, 23);
			arg_10E_0.Size = size;
			this.lblDicType.TabIndex = 0;
			this.lblDicType.Text = "字典类型：";
			this.lblDicType.TextAlign = ContentAlignment.MiddleRight;
			this.cbxDicType.Items.AddRange(new object[]
			{
				"标准字典",
				"自定义字典"
			});
			Control arg_175_0 = this.cbxDicType;
			location = new Point(111, 7);
			arg_175_0.Location = location;
			this.cbxDicType.Name = "cbxDicType";
			Control arg_19F_0 = this.cbxDicType;
			size = new Size(152, 20);
			arg_19F_0.Size = size;
			this.cbxDicType.TabIndex = 1;
			Control arg_1C2_0 = this.txtDicClassName;
			location = new Point(111, 41);
			arg_1C2_0.Location = location;
			this.txtDicClassName.Name = "txtDicClassName";
			Control arg_1EC_0 = this.txtDicClassName;
			size = new Size(152, 21);
			arg_1EC_0.Size = size;
			this.txtDicClassName.TabIndex = 2;
			Control arg_20E_0 = this.lblDicClassName;
			location = new Point(6, 39);
			arg_20E_0.Location = location;
			this.lblDicClassName.Name = "lblDicClassName";
			Control arg_235_0 = this.lblDicClassName;
			size = new Size(105, 23);
			arg_235_0.Size = size;
			this.lblDicClassName.TabIndex = 3;
			this.lblDicClassName.Text = "自定义字典类名：";
			this.lblDicClassName.TextAlign = ContentAlignment.MiddleRight;
			Control arg_274_0 = this.lblStdDic;
			location = new Point(6, 71);
			arg_274_0.Location = location;
			this.lblStdDic.Name = "lblStdDic";
			Control arg_29B_0 = this.lblStdDic;
			size = new Size(105, 23);
			arg_29B_0.Size = size;
			this.lblStdDic.TabIndex = 4;
			this.lblStdDic.Text = "标准字典名称：";
			this.lblStdDic.TextAlign = ContentAlignment.MiddleRight;
			Control arg_2DB_0 = this.cbxStdDic;
			location = new Point(111, 71);
			arg_2DB_0.Location = location;
			this.cbxStdDic.Name = "cbxStdDic";
			Control arg_305_0 = this.cbxStdDic;
			size = new Size(248, 20);
			arg_305_0.Size = size;
			this.cbxStdDic.TabIndex = 5;
			Control arg_32A_0 = this.lblDisplayType;
			location = new Point(6, 135);
			arg_32A_0.Location = location;
			this.lblDisplayType.Name = "lblDisplayType";
			Control arg_351_0 = this.lblDisplayType;
			size = new Size(105, 23);
			arg_351_0.Size = size;
			this.lblDisplayType.TabIndex = 6;
			this.lblDisplayType.Text = "显示类型：";
			this.lblDisplayType.TextAlign = ContentAlignment.MiddleRight;
			this.cbxDisplayType.Items.AddRange(new object[]
			{
				"描述",
				"代码",
				"代码和描述",
				"描述和代码"
			});
			Control arg_3CC_0 = this.cbxDisplayType;
			location = new Point(111, 137);
			arg_3CC_0.Location = location;
			this.cbxDisplayType.Name = "cbxDisplayType";
			Control arg_3F6_0 = this.cbxDisplayType;
			size = new Size(152, 20);
			arg_3F6_0.Size = size;
			this.cbxDisplayType.TabIndex = 7;
			Control arg_41C_0 = this.txtSeporator;
			location = new Point(111, 169);
			arg_41C_0.Location = location;
			this.txtSeporator.Name = "txtSeporator";
			Control arg_446_0 = this.txtSeporator;
			size = new Size(152, 21);
			arg_446_0.Size = size;
			this.txtSeporator.TabIndex = 8;
			Control arg_46B_0 = this.lblSeporator;
			location = new Point(6, 167);
			arg_46B_0.Location = location;
			this.lblSeporator.Name = "lblSeporator";
			Control arg_492_0 = this.lblSeporator;
			size = new Size(105, 23);
			arg_492_0.Size = size;
			this.lblSeporator.TabIndex = 9;
			this.lblSeporator.Text = "显示分隔符：";
			this.lblSeporator.TextAlign = ContentAlignment.MiddleRight;
			Control arg_4D2_0 = this.lblResult;
			location = new Point(6, 103);
			arg_4D2_0.Location = location;
			this.lblResult.Name = "lblResult";
			Control arg_4F9_0 = this.lblResult;
			size = new Size(105, 23);
			arg_4F9_0.Size = size;
			this.lblResult.TabIndex = 10;
			this.lblResult.Text = "结果列设置：";
			this.lblResult.TextAlign = ContentAlignment.MiddleRight;
			this.cbxFirstCol.Items.AddRange(new object[]
			{
				"别名",
				"代码",
				"描述",
				"空项"
			});
			Control arg_572_0 = this.cbxFirstCol;
			location = new Point(111, 103);
			arg_572_0.Location = location;
			this.cbxFirstCol.Name = "cbxFirstCol";
			Control arg_599_0 = this.cbxFirstCol;
			size = new Size(98, 20);
			arg_599_0.Size = size;
			this.cbxFirstCol.TabIndex = 11;
			this.cbxSecondCol.Items.AddRange(new object[]
			{
				"别名",
				"代码",
				"描述",
				"空项"
			});
			Control arg_5F8_0 = this.cbxSecondCol;
			location = new Point(218, 103);
			arg_5F8_0.Location = location;
			this.cbxSecondCol.Name = "cbxSecondCol";
			Control arg_61F_0 = this.cbxSecondCol;
			size = new Size(98, 20);
			arg_61F_0.Size = size;
			this.cbxSecondCol.TabIndex = 12;
			this.cbxThirdCol.Items.AddRange(new object[]
			{
				"别名",
				"代码",
				"描述",
				"空项"
			});
			Control arg_67E_0 = this.cbxThirdCol;
			location = new Point(325, 103);
			arg_67E_0.Location = location;
			this.cbxThirdCol.Name = "cbxThirdCol";
			Control arg_6A5_0 = this.cbxThirdCol;
			size = new Size(98, 20);
			arg_6A5_0.Size = size;
			this.cbxThirdCol.TabIndex = 13;
			Control arg_6CC_0 = this.cbxAllowCodeNull;
			location = new Point(111, 201);
			arg_6CC_0.Location = location;
			this.cbxAllowCodeNull.Name = "cbxAllowCodeNull";
			Control arg_6F6_0 = this.cbxAllowCodeNull;
			size = new Size(168, 23);
			arg_6F6_0.Size = size;
			this.cbxAllowCodeNull.TabIndex = 14;
			this.cbxAllowCodeNull.Text = "允许使用非标准字典代码";
			Control arg_72D_0 = this.cbxAllowValueNull;
			location = new Point(111, 228);
			arg_72D_0.Location = location;
			this.cbxAllowValueNull.Name = "cbxAllowValueNull";
			Control arg_757_0 = this.cbxAllowValueNull;
			size = new Size(176, 24);
			arg_757_0.Size = size;
			this.cbxAllowValueNull.TabIndex = 15;
			this.cbxAllowValueNull.Text = "允许使用非标准字典描述";
			Control arg_78D_0 = this.lblAssociateItem;
			location = new Point(6, 268);
			arg_78D_0.Location = location;
			this.lblAssociateItem.Name = "lblAssociateItem";
			Control arg_7B4_0 = this.lblAssociateItem;
			size = new Size(105, 23);
			arg_7B4_0.Size = size;
			this.lblAssociateItem.TabIndex = 17;
			this.lblAssociateItem.Text = "查询条件单元：";
			this.lblAssociateItem.TextAlign = ContentAlignment.MiddleRight;
			this.txtAssociateItem.AllowDrop = true;
			Control arg_804_0 = this.txtAssociateItem;
			location = new Point(111, 270);
			arg_804_0.Location = location;
			this.txtAssociateItem.Name = "txtAssociateItem";
			Control arg_82E_0 = this.txtAssociateItem;
			size = new Size(205, 21);
			arg_82E_0.Size = size;
			this.txtAssociateItem.TabIndex = 16;
			Control arg_858_0 = this.Label1;
			location = new Point(320, 270);
			arg_858_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_882_0 = this.Label1;
			size = new Size(143, 23);
			arg_882_0.Size = size;
			this.Label1.TabIndex = 18;
			this.Label1.Text = "多个单元之间以\",\"分隔";
			this.Label1.TextAlign = ContentAlignment.MiddleLeft;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblAssociateItem);
			this.Controls.Add(this.txtAssociateItem);
			this.Controls.Add(this.cbxAllowValueNull);
			this.Controls.Add(this.cbxAllowCodeNull);
			this.Controls.Add(this.cbxThirdCol);
			this.Controls.Add(this.cbxSecondCol);
			this.Controls.Add(this.cbxFirstCol);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblSeporator);
			this.Controls.Add(this.txtSeporator);
			this.Controls.Add(this.cbxDisplayType);
			this.Controls.Add(this.lblDisplayType);
			this.Controls.Add(this.cbxStdDic);
			this.Controls.Add(this.lblStdDic);
			this.Controls.Add(this.lblDicClassName);
			this.Controls.Add(this.txtDicClassName);
			this.Controls.Add(this.cbxDicType);
			this.Controls.Add(this.lblDicType);
			this.Name = "MIDictionaryProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void cbxDicType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxDicType.SelectedIndex == 0)
			{
				this._MIDictionary.DictionaryType = "STDDIC";
				this.lblStdDic.Enabled = true;
				this.cbxStdDic.Enabled = true;
				this.lblDicClassName.Enabled = false;
				this.txtDicClassName.Enabled = false;
				this.lblResult.Enabled = true;
				this.cbxFirstCol.Enabled = true;
				this.cbxSecondCol.Enabled = true;
				this.cbxThirdCol.Enabled = true;
			}
			else
			{
				this._MIDictionary.DictionaryType = "CUSTDIC";
				this.lblStdDic.Enabled = false;
				this.cbxStdDic.Enabled = false;
				this.lblDicClassName.Enabled = true;
				this.txtDicClassName.Enabled = true;
				this.lblResult.Enabled = false;
				this.cbxFirstCol.Enabled = false;
				this.cbxSecondCol.Enabled = false;
				this.cbxThirdCol.Enabled = false;
			}
		}

		private void cbxStdDic_DropDown(object sender, EventArgs e)
		{
			if (this._StdDicDataSet == null)
			{
				this._StdDicDataSet = WebServiceLayer.DictionaryAccess.SelectALLStdDic();
			}
			this.cbxStdDic.Items.Clear();
			try
			{
				IEnumerator enumerator = this._StdDicDataSet.SELECTALL.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					EStdDictionaryDataset.SELECTALLRow sELECTALLRow = (EStdDictionaryDataset.SELECTALLRow)enumerator.Current;
					this.cbxStdDic.Items.Add(sELECTALLRow.Name);
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

		private void cbxStdDic_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this._StdDicDataSet != null)
			{
				int selectedIndex = this.cbxStdDic.SelectedIndex;
				EStdDictionaryDataset.SELECTALLRow sELECTALLRow = (EStdDictionaryDataset.SELECTALLRow)this._StdDicDataSet.SELECTALL.Rows[selectedIndex];
				this._MIDictionary.StdDicCode = sELECTALLRow.Code;
				this._MIDictionary.StdDicName = sELECTALLRow.Name;
			}
		}

		private void txtDicClassName_TextChanged(object sender, EventArgs e)
		{
			this._MIDictionary.CustDicClassName = Strings.Trim(this.txtDicClassName.Text);
		}

		private void cbxDisplayType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxDisplayType.SelectedIndex == 0)
			{
				this._MIDictionary.DisplayType = DisplayType.Desc;
				this.lblSeporator.Enabled = false;
				this.txtSeporator.Enabled = false;
			}
			else if (this.cbxDisplayType.SelectedIndex == 1)
			{
				this._MIDictionary.DisplayType = DisplayType.Code;
				this.lblSeporator.Enabled = false;
				this.txtSeporator.Enabled = false;
			}
			else if (this.cbxDisplayType.SelectedIndex == 2)
			{
				this._MIDictionary.DisplayType = DisplayType.CodeDesc;
				this.lblSeporator.Enabled = true;
				this.txtSeporator.Enabled = true;
				this.txtSeporator.Text = this._MIDictionary.Seporator;
			}
			else if (this.cbxDisplayType.SelectedIndex == 3)
			{
				this._MIDictionary.DisplayType = DisplayType.DescCode;
				this.lblSeporator.Enabled = true;
				this.txtSeporator.Enabled = true;
				this.txtSeporator.Text = this._MIDictionary.Seporator;
			}
		}

		private void txtSeporator_TextChanged(object sender, EventArgs e)
		{
			this._MIDictionary.Seporator = Strings.Trim(this.txtSeporator.Text);
		}

		private void cbxFirstCol_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxFirstCol.SelectedIndex == 0)
			{
				this._MIDictionary.FirstColType = ColType.Alias;
			}
			else if (this.cbxFirstCol.SelectedIndex == 1)
			{
				this._MIDictionary.FirstColType = ColType.Code;
			}
			else if (this.cbxFirstCol.SelectedIndex == 2)
			{
				this._MIDictionary.FirstColType = ColType.Desc;
			}
			else if (this.cbxFirstCol.SelectedIndex == 3)
			{
				this._MIDictionary.FirstColType = ColType.None;
			}
		}

		private void cbxSecondCol_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxSecondCol.SelectedIndex == 0)
			{
				this._MIDictionary.SecondColType = ColType.Alias;
			}
			else if (this.cbxSecondCol.SelectedIndex == 1)
			{
				this._MIDictionary.SecondColType = ColType.Code;
			}
			else if (this.cbxSecondCol.SelectedIndex == 2)
			{
				this._MIDictionary.SecondColType = ColType.Desc;
			}
			else if (this.cbxSecondCol.SelectedIndex == 3)
			{
				this._MIDictionary.SecondColType = ColType.None;
			}
		}

		private void cbxThirdCol_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxThirdCol.SelectedIndex == 0)
			{
				this._MIDictionary.ThirdColType = ColType.Alias;
			}
			else if (this.cbxThirdCol.SelectedIndex == 1)
			{
				this._MIDictionary.ThirdColType = ColType.Code;
			}
			else if (this.cbxThirdCol.SelectedIndex == 2)
			{
				this._MIDictionary.ThirdColType = ColType.Desc;
			}
			else if (this.cbxThirdCol.SelectedIndex == 3)
			{
				this._MIDictionary.ThirdColType = ColType.None;
			}
		}

		private void cbxAllowCodeNull_CheckStateChanged(object sender, EventArgs e)
		{
			this._MIDictionary.AllowCodeNull = this.cbxAllowCodeNull.Checked;
		}

		private void cbxAllowValueNull_CheckedChanged(object sender, EventArgs e)
		{
			this._MIDictionary.AllowValueNull = this.cbxAllowValueNull.Checked;
		}

		private void lblSeporator_Click(object sender, EventArgs e)
		{
		}

		private void txtAssociateItem_TextChanged(object sender, EventArgs e)
		{
			this._MIDictionary.AssociateItem = this.txtAssociateItem.Text.Trim();
		}

		private void txtAssociateItem_DragEnter(object sender, DragEventArgs e)
		{
			if (this.MetaItemTree.DragMetaItem != null)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void txtAssociateItem_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Effect == DragDropEffects.Move)
			{
				int selectionStart = this.txtAssociateItem.SelectionStart;
				this.txtAssociateItem.Text = this.txtAssociateItem.Text.Insert(selectionStart, this.MetaItemTree.DragMetaItem.Code);
				this.txtAssociateItem.SelectionStart = selectionStart;
				this.MetaItemTree.DragMetaItem = null;
				this.MetaItemTree.DragTreeNode = null;
			}
		}
	}
}
