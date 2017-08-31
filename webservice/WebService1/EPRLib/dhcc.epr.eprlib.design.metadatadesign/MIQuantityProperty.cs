using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UnitData;

namespace dhcc.epr.eprlib.design.metadatadesign
{
	public class MIQuantityProperty : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("lblUnitType")]
		private Label _lblUnitType;

		[AccessedThroughProperty("cbxUnitType")]
		private ComboBox _cbxUnitType;

		[AccessedThroughProperty("lbxUnits")]
		private ListBox _lbxUnits;

		[AccessedThroughProperty("lblUnits")]
		private Label _lblUnits;

		[AccessedThroughProperty("btnAddUnit")]
		private Button _btnAddUnit;

		[AccessedThroughProperty("btnRemoveUnit")]
		private Button _btnRemoveUnit;

		[AccessedThroughProperty("ValuePanel")]
		private Panel _ValuePanel;

		[AccessedThroughProperty("lblValue")]
		private Label _lblValue;

		[AccessedThroughProperty("cbxMinVal")]
		private ComboBox _cbxMinVal;

		[AccessedThroughProperty("numMaxVal")]
		private NumericUpDown _numMaxVal;

		[AccessedThroughProperty("cbxMaxVal")]
		private ComboBox _cbxMaxVal;

		[AccessedThroughProperty("chxMaxVal")]
		private CheckBox _chxMaxVal;

		[AccessedThroughProperty("numMinVal")]
		private NumericUpDown _numMinVal;

		[AccessedThroughProperty("chxMinVal")]
		private CheckBox _chxMinVal;

		[AccessedThroughProperty("menuAddUnits")]
		private ContextMenu _menuAddUnits;

		[AccessedThroughProperty("numDecimalPlace")]
		private NumericUpDown _numDecimalPlace;

		[AccessedThroughProperty("lblDecimalPlace")]
		private Label _lblDecimalPlace;

		private MIQuantity _MIQuantity;

		private EUnitTypeDataset _UnitTypeDataSet;

		private EUnitByCodeDataset _UnitDataSet;

		private MUnitCode _CurrentUnitCode;

		private const float MINVAL = -1E+10f;

		private const float MAXVAL = 1E+10f;

		internal virtual Label lblUnitType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUnitType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUnitType = value;
			}
		}

		internal virtual ComboBox cbxUnitType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxUnitType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxUnitType_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.cbxUnitType_DropDown);
				if (this._cbxUnitType != null)
				{
					this._cbxUnitType.SelectedIndexChanged -= value2;
					this._cbxUnitType.DropDown -= value3;
				}
				this._cbxUnitType = value;
				if (this._cbxUnitType != null)
				{
					this._cbxUnitType.SelectedIndexChanged += value2;
					this._cbxUnitType.DropDown += value3;
				}
			}
		}

		internal virtual ListBox lbxUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbxUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lbxUnits_SelectedIndexChanged);
				if (this._lbxUnits != null)
				{
					this._lbxUnits.SelectedIndexChanged -= value2;
				}
				this._lbxUnits = value;
				if (this._lbxUnits != null)
				{
					this._lbxUnits.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label lblUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUnits = value;
			}
		}

		internal virtual Button btnAddUnit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAddUnit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddUnit_Click);
				if (this._btnAddUnit != null)
				{
					this._btnAddUnit.Click -= value2;
				}
				this._btnAddUnit = value;
				if (this._btnAddUnit != null)
				{
					this._btnAddUnit.Click += value2;
				}
			}
		}

		internal virtual Button btnRemoveUnit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnRemoveUnit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRemoveUnit_Click);
				if (this._btnRemoveUnit != null)
				{
					this._btnRemoveUnit.Click -= value2;
				}
				this._btnRemoveUnit = value;
				if (this._btnRemoveUnit != null)
				{
					this._btnRemoveUnit.Click += value2;
				}
			}
		}

		internal virtual Panel ValuePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ValuePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ValuePanel = value;
			}
		}

		internal virtual Label lblValue
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblValue;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblValue = value;
			}
		}

		internal virtual ComboBox cbxMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxMinVal_SelectedIndexChanged);
				if (this._cbxMinVal != null)
				{
					this._cbxMinVal.SelectedIndexChanged -= value2;
				}
				this._cbxMinVal = value;
				if (this._cbxMinVal != null)
				{
					this._cbxMinVal.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual NumericUpDown numMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numMaxVal_TextChanged);
				EventHandler value3 = new EventHandler(this.numMaxVal_ValueChanged);
				if (this._numMaxVal != null)
				{
					this._numMaxVal.TextChanged -= value2;
					this._numMaxVal.ValueChanged -= value3;
				}
				this._numMaxVal = value;
				if (this._numMaxVal != null)
				{
					this._numMaxVal.TextChanged += value2;
					this._numMaxVal.ValueChanged += value3;
				}
			}
		}

		internal virtual ComboBox cbxMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxMaxVal_SelectedIndexChanged);
				if (this._cbxMaxVal != null)
				{
					this._cbxMaxVal.SelectedIndexChanged -= value2;
				}
				this._cbxMaxVal = value;
				if (this._cbxMaxVal != null)
				{
					this._cbxMaxVal.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual CheckBox chxMaxVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxMaxVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxMaxVal_CheckedChanged);
				if (this._chxMaxVal != null)
				{
					this._chxMaxVal.CheckedChanged -= value2;
				}
				this._chxMaxVal = value;
				if (this._chxMaxVal != null)
				{
					this._chxMaxVal.CheckedChanged += value2;
				}
			}
		}

		internal virtual NumericUpDown numMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numMinVal_TextChanged);
				EventHandler value3 = new EventHandler(this.numMinVal_ValueChanged);
				if (this._numMinVal != null)
				{
					this._numMinVal.TextChanged -= value2;
					this._numMinVal.ValueChanged -= value3;
				}
				this._numMinVal = value;
				if (this._numMinVal != null)
				{
					this._numMinVal.TextChanged += value2;
					this._numMinVal.ValueChanged += value3;
				}
			}
		}

		internal virtual CheckBox chxMinVal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chxMinVal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chxMinVal_CheckedChanged);
				if (this._chxMinVal != null)
				{
					this._chxMinVal.CheckedChanged -= value2;
				}
				this._chxMinVal = value;
				if (this._chxMinVal != null)
				{
					this._chxMinVal.CheckedChanged += value2;
				}
			}
		}

		internal virtual ContextMenu menuAddUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._menuAddUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._menuAddUnits = value;
			}
		}

		internal virtual NumericUpDown numDecimalPlace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numDecimalPlace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numDecimalPlace_TextChanged);
				EventHandler value3 = new EventHandler(this.numDecimalPlace_ValueChanged);
				if (this._numDecimalPlace != null)
				{
					this._numDecimalPlace.TextChanged -= value2;
					this._numDecimalPlace.ValueChanged -= value3;
				}
				this._numDecimalPlace = value;
				if (this._numDecimalPlace != null)
				{
					this._numDecimalPlace.TextChanged += value2;
					this._numDecimalPlace.ValueChanged += value3;
				}
			}
		}

		internal virtual Label lblDecimalPlace
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDecimalPlace;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDecimalPlace = value;
			}
		}

		public MIQuantity MIQuantity
		{
			get
			{
				return this._MIQuantity;
			}
			set
			{
				this._UnitTypeDataSet = null;
				this._UnitDataSet = null;
				this._MIQuantity = value;
				this.ValuePanel.Enabled = false;
				this.cbxUnitType.Text = this._MIQuantity.UnitTypeName;
				this.lbxUnits.Items.Clear();
				MUnitCodeEnumerator enumerator = this._MIQuantity.UnitCodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					MUnitCode mUnitCode = (MUnitCode)enumerator.Current;
					this.lbxUnits.Items.Add(mUnitCode.UnitSymbol);
				}
			}
		}

		public MIQuantityProperty()
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
			this.lblUnitType = new Label();
			this.cbxUnitType = new ComboBox();
			this.lbxUnits = new ListBox();
			this.lblUnits = new Label();
			this.btnAddUnit = new Button();
			this.btnRemoveUnit = new Button();
			this.ValuePanel = new Panel();
			this.numDecimalPlace = new NumericUpDown();
			this.lblDecimalPlace = new Label();
			this.cbxMinVal = new ComboBox();
			this.numMaxVal = new NumericUpDown();
			this.cbxMaxVal = new ComboBox();
			this.chxMaxVal = new CheckBox();
			this.numMinVal = new NumericUpDown();
			this.chxMinVal = new CheckBox();
			this.lblValue = new Label();
			this.menuAddUnits = new ContextMenu();
			this.ValuePanel.SuspendLayout();
			((ISupportInitialize)this.numDecimalPlace).BeginInit();
			((ISupportInitialize)this.numMaxVal).BeginInit();
			((ISupportInitialize)this.numMinVal).BeginInit();
			this.SuspendLayout();
			Control arg_FD_0 = this.lblUnitType;
			Point location = new Point(6, 8);
			arg_FD_0.Location = location;
			this.lblUnitType.Name = "lblUnitType";
			Control arg_124_0 = this.lblUnitType;
			Size size = new Size(105, 23);
			arg_124_0.Size = size;
			this.lblUnitType.TabIndex = 0;
			this.lblUnitType.Text = "单位类型：";
			this.lblUnitType.TextAlign = ContentAlignment.MiddleRight;
			Control arg_163_0 = this.cbxUnitType;
			location = new Point(111, 8);
			arg_163_0.Location = location;
			this.cbxUnitType.Name = "cbxUnitType";
			Control arg_18D_0 = this.cbxUnitType;
			size = new Size(232, 20);
			arg_18D_0.Size = size;
			this.cbxUnitType.TabIndex = 1;
			this.lbxUnits.ItemHeight = 12;
			Control arg_1BD_0 = this.lbxUnits;
			location = new Point(111, 42);
			arg_1BD_0.Location = location;
			this.lbxUnits.Name = "lbxUnits";
			Control arg_1EA_0 = this.lbxUnits;
			size = new Size(232, 148);
			arg_1EA_0.Size = size;
			this.lbxUnits.TabIndex = 2;
			Control arg_20C_0 = this.lblUnits;
			location = new Point(6, 42);
			arg_20C_0.Location = location;
			this.lblUnits.Name = "lblUnits";
			Control arg_233_0 = this.lblUnits;
			size = new Size(105, 23);
			arg_233_0.Size = size;
			this.lblUnits.TabIndex = 3;
			this.lblUnits.Text = "单位：";
			this.lblUnits.TextAlign = ContentAlignment.MiddleRight;
			Control arg_273_0 = this.btnAddUnit;
			location = new Point(80, 81);
			arg_273_0.Location = location;
			this.btnAddUnit.Name = "btnAddUnit";
			Control arg_29A_0 = this.btnAddUnit;
			size = new Size(24, 24);
			arg_29A_0.Size = size;
			this.btnAddUnit.TabIndex = 4;
			this.btnAddUnit.Text = "+";
			Control arg_2CD_0 = this.btnRemoveUnit;
			location = new Point(80, 118);
			arg_2CD_0.Location = location;
			this.btnRemoveUnit.Name = "btnRemoveUnit";
			Control arg_2F4_0 = this.btnRemoveUnit;
			size = new Size(24, 23);
			arg_2F4_0.Size = size;
			this.btnRemoveUnit.TabIndex = 5;
			this.btnRemoveUnit.Text = "-";
			this.ValuePanel.Controls.Add(this.numDecimalPlace);
			this.ValuePanel.Controls.Add(this.lblDecimalPlace);
			this.ValuePanel.Controls.Add(this.cbxMinVal);
			this.ValuePanel.Controls.Add(this.numMaxVal);
			this.ValuePanel.Controls.Add(this.cbxMaxVal);
			this.ValuePanel.Controls.Add(this.chxMaxVal);
			this.ValuePanel.Controls.Add(this.numMinVal);
			this.ValuePanel.Controls.Add(this.chxMinVal);
			this.ValuePanel.Controls.Add(this.lblValue);
			Control arg_3F0_0 = this.ValuePanel;
			location = new Point(19, 206);
			arg_3F0_0.Location = location;
			this.ValuePanel.Name = "ValuePanel";
			Control arg_41D_0 = this.ValuePanel;
			size = new Size(464, 154);
			arg_41D_0.Size = size;
			this.ValuePanel.TabIndex = 6;
			Control arg_443_0 = this.numDecimalPlace;
			location = new Point(136, 37);
			arg_443_0.Location = location;
			this.numDecimalPlace.Name = "numDecimalPlace";
			Control arg_46A_0 = this.numDecimalPlace;
			size = new Size(64, 21);
			arg_46A_0.Size = size;
			this.numDecimalPlace.TabIndex = 15;
			this.numDecimalPlace.TextAlign = HorizontalAlignment.Right;
			Control arg_49A_0 = this.lblDecimalPlace;
			location = new Point(16, 37);
			arg_49A_0.Location = location;
			this.lblDecimalPlace.Name = "lblDecimalPlace";
			Control arg_4C1_0 = this.lblDecimalPlace;
			size = new Size(80, 23);
			arg_4C1_0.Size = size;
			this.lblDecimalPlace.TabIndex = 14;
			this.lblDecimalPlace.Text = "小数位数：";
			this.lblDecimalPlace.TextAlign = ContentAlignment.MiddleRight;
			this.cbxMinVal.Items.AddRange(new object[]
			{
				">=",
				">"
			});
			Control arg_52D_0 = this.cbxMinVal;
			location = new Point(136, 80);
			arg_52D_0.Location = location;
			this.cbxMinVal.Name = "cbxMinVal";
			Control arg_554_0 = this.cbxMinVal;
			size = new Size(64, 20);
			arg_554_0.Size = size;
			this.cbxMinVal.TabIndex = 13;
			Control arg_57B_0 = this.numMaxVal;
			location = new Point(224, 120);
			arg_57B_0.Location = location;
			this.numMaxVal.Name = "numMaxVal";
			Control arg_5A2_0 = this.numMaxVal;
			size = new Size(88, 21);
			arg_5A2_0.Size = size;
			this.numMaxVal.TabIndex = 12;
			this.numMaxVal.TextAlign = HorizontalAlignment.Right;
			this.cbxMaxVal.Items.AddRange(new object[]
			{
				"<=",
				"< "
			});
			Control arg_5FD_0 = this.cbxMaxVal;
			location = new Point(136, 120);
			arg_5FD_0.Location = location;
			this.cbxMaxVal.Name = "cbxMaxVal";
			Control arg_624_0 = this.cbxMaxVal;
			size = new Size(64, 20);
			arg_624_0.Size = size;
			this.cbxMaxVal.TabIndex = 11;
			Control arg_648_0 = this.chxMaxVal;
			location = new Point(18, 120);
			arg_648_0.Location = location;
			this.chxMaxVal.Name = "chxMaxVal";
			Control arg_66F_0 = this.chxMaxVal;
			size = new Size(104, 24);
			arg_66F_0.Size = size;
			this.chxMaxVal.TabIndex = 10;
			this.chxMaxVal.Text = "设置最大值";
			Control arg_6A6_0 = this.numMinVal;
			location = new Point(224, 80);
			arg_6A6_0.Location = location;
			this.numMinVal.Name = "numMinVal";
			Control arg_6CD_0 = this.numMinVal;
			size = new Size(88, 21);
			arg_6CD_0.Size = size;
			this.numMinVal.TabIndex = 9;
			this.numMinVal.TextAlign = HorizontalAlignment.Right;
			Control arg_6FD_0 = this.chxMinVal;
			location = new Point(18, 78);
			arg_6FD_0.Location = location;
			this.chxMinVal.Name = "chxMinVal";
			Control arg_724_0 = this.chxMinVal;
			size = new Size(104, 24);
			arg_724_0.Size = size;
			this.chxMinVal.TabIndex = 8;
			this.chxMinVal.Text = "设置最小值";
			Control arg_755_0 = this.lblValue;
			location = new Point(8, 8);
			arg_755_0.Location = location;
			this.lblValue.Name = "lblValue";
			Control arg_77C_0 = this.lblValue;
			size = new Size(72, 16);
			arg_77C_0.Size = size;
			this.lblValue.TabIndex = 0;
			this.lblValue.Text = "设置单位值";
			this.Controls.Add(this.ValuePanel);
			this.Controls.Add(this.btnRemoveUnit);
			this.Controls.Add(this.btnAddUnit);
			this.Controls.Add(this.lblUnits);
			this.Controls.Add(this.lbxUnits);
			this.Controls.Add(this.cbxUnitType);
			this.Controls.Add(this.lblUnitType);
			this.Name = "MIQuantityProperty";
			size = new Size(500, 400);
			this.Size = size;
			this.ValuePanel.ResumeLayout(false);
			((ISupportInitialize)this.numDecimalPlace).EndInit();
			((ISupportInitialize)this.numMaxVal).EndInit();
			((ISupportInitialize)this.numMinVal).EndInit();
			this.ResumeLayout(false);
		}

		private void cbxUnitType_DropDown(object sender, EventArgs e)
		{
			if (this._UnitTypeDataSet == null)
			{
				this._UnitTypeDataSet = WebServiceLayer.UnitAccess.GetAllUnitType();
				this.cbxUnitType.Items.Clear();
				try
				{
					IEnumerator enumerator = this._UnitTypeDataSet.SelectAllType.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						EUnitTypeDataset.SelectAllTypeRow selectAllTypeRow = (EUnitTypeDataset.SelectAllTypeRow)enumerator.Current;
						this.cbxUnitType.Items.Add(selectAllTypeRow.CHSName);
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

		private void btnAddUnit_Click(object sender, EventArgs e)
		{
			if (this._UnitDataSet == null & !(this._MIQuantity.UnitTypeCode == null | Operators.CompareString(this.MIQuantity.UnitTypeCode, "", false) == 0))
			{
				this._UnitDataSet = WebServiceLayer.UnitAccess.GetUnitsByCode(this._MIQuantity.UnitTypeCode);
				this.menuAddUnits.MenuItems.Clear();
				try
				{
					IEnumerator enumerator = this._UnitDataSet.SELECTALLUNITByCode.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						EUnitByCodeDataset.SELECTALLUNITByCodeRow sELECTALLUNITByCodeRow = (EUnitByCodeDataset.SELECTALLUNITByCodeRow)enumerator.Current;
						MenuItem menuItem = new MenuItem(sELECTALLUNITByCodeRow.Symbol);
						menuItem.Click += new EventHandler(this.menuItem_Click);
						this.menuAddUnits.MenuItems.Add(menuItem);
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
			this.menuAddUnits.Show(this, this.btnAddUnit.Location);
		}

		private void cbxUnitType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxUnitType.SelectedIndex > -1)
			{
				EUnitTypeDataset.SelectAllTypeRow selectAllTypeRow = (EUnitTypeDataset.SelectAllTypeRow)this._UnitTypeDataSet.SelectAllType.Rows[this.cbxUnitType.SelectedIndex];
				this._MIQuantity.UnitTypeName = selectAllTypeRow.CHSName;
				this._MIQuantity.UnitTypeCode = selectAllTypeRow.Code;
				this._UnitDataSet = null;
				this._MIQuantity.UnitCodes.Clear();
				this.lbxUnits.Items.Clear();
			}
		}

		private void menuItem_Click(object sender, EventArgs e)
		{
			int index = this.menuAddUnits.MenuItems.IndexOf((MenuItem)sender);
			EUnitByCodeDataset.SELECTALLUNITByCodeRow sELECTALLUNITByCodeRow = (EUnitByCodeDataset.SELECTALLUNITByCodeRow)this._UnitDataSet.SELECTALLUNITByCode.Rows[index];
			MUnitCode mUnitCode = new MUnitCode();
			mUnitCode.UnitCode = sELECTALLUNITByCodeRow.Code;
			mUnitCode.UnitName = sELECTALLUNITByCodeRow.CHSMeasurementName;
			mUnitCode.UnitSymbol = sELECTALLUNITByCodeRow.Symbol;
			this._MIQuantity.UnitCodes.Add(mUnitCode);
			this.lbxUnits.Items.Add(mUnitCode.UnitSymbol);
		}

		private void btnRemoveUnit_Click(object sender, EventArgs e)
		{
			if (this.lbxUnits.SelectedIndex > -1)
			{
				this._MIQuantity.UnitCodes.RemoveAt(this.lbxUnits.SelectedIndex);
				this.lbxUnits.Items.RemoveAt(this.lbxUnits.SelectedIndex);
			}
		}

		private void lbxUnits_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lbxUnits.SelectedIndex == -1)
			{
				this.ValuePanel.Enabled = false;
				this._CurrentUnitCode = null;
			}
			else
			{
				this._CurrentUnitCode = this._MIQuantity.UnitCodes[this.lbxUnits.SelectedIndex];
				this.ValuePanel.Enabled = true;
				this.numDecimalPlace.Value = new decimal(this._CurrentUnitCode.DecimalPlace);
				if (this._CurrentUnitCode.IncludeMin)
				{
					this.cbxMinVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMinVal.SelectedIndex = 1;
				}
				this.numMinVal.DecimalPlaces = this._CurrentUnitCode.DecimalPlace;
				this.numMinVal.Maximum = 10000000000m;
				this.numMinVal.Minimum = -10000000000m;
				if (this._CurrentUnitCode.IncludeMin)
				{
					this.cbxMaxVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMaxVal.SelectedIndex = 1;
				}
				this.numMinVal.Value = new decimal(this._CurrentUnitCode.MinVal);
				if (this._CurrentUnitCode.HasMinVal)
				{
					this.chxMinVal.Checked = true;
					this.cbxMinVal.Enabled = true;
					this.numMinVal.Enabled = true;
				}
				else
				{
					this.chxMinVal.Checked = false;
					this.cbxMinVal.Enabled = false;
					this.numMinVal.Enabled = false;
				}
				this.numMaxVal.DecimalPlaces = this._CurrentUnitCode.DecimalPlace;
				this.numMaxVal.Maximum = 10000000000m;
				this.numMaxVal.Minimum = -10000000000m;
				if (this._CurrentUnitCode.IncludeMax)
				{
					this.cbxMaxVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMaxVal.SelectedIndex = 1;
				}
				this.numMaxVal.Value = new decimal(this._CurrentUnitCode.MaxVal);
				if (this._CurrentUnitCode.HasMaxVal)
				{
					this.chxMaxVal.Checked = true;
					this.cbxMaxVal.Enabled = true;
					this.numMaxVal.Enabled = true;
				}
				else
				{
					this.chxMaxVal.Checked = false;
					this.cbxMaxVal.Enabled = false;
					this.numMaxVal.Enabled = false;
				}
				if (this._CurrentUnitCode.IncludeMin)
				{
					this.cbxMinVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMinVal.SelectedIndex = 1;
				}
				this.numMinVal.Value = new decimal(this._CurrentUnitCode.MinVal);
				if (this._CurrentUnitCode.HasMinVal)
				{
					this.chxMinVal.Checked = true;
					this.cbxMinVal.Enabled = true;
					this.numMinVal.Enabled = true;
				}
				else
				{
					this.chxMinVal.Checked = false;
					this.cbxMinVal.Enabled = false;
					this.numMinVal.Enabled = false;
				}
				if (this._CurrentUnitCode.IncludeMax)
				{
					this.cbxMaxVal.SelectedIndex = 0;
				}
				else
				{
					this.cbxMaxVal.SelectedIndex = 1;
				}
				this.numMaxVal.Value = new decimal(this._CurrentUnitCode.MaxVal);
				if (this._CurrentUnitCode.HasMaxVal)
				{
					this.chxMaxVal.Checked = true;
					this.cbxMaxVal.Enabled = true;
					this.numMaxVal.Enabled = true;
				}
				else
				{
					this.chxMaxVal.Checked = false;
					this.cbxMaxVal.Enabled = false;
					this.numMaxVal.Enabled = false;
				}
			}
		}

		private void chxMinVal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chxMinVal.Checked)
			{
				this._CurrentUnitCode.HasMinVal = true;
				this.cbxMinVal.Enabled = true;
				this.numMinVal.Enabled = true;
			}
			else
			{
				this._CurrentUnitCode.HasMinVal = false;
				this.cbxMinVal.Enabled = false;
				this.numMinVal.Enabled = false;
			}
		}

		private void chxMaxVal_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chxMaxVal.Checked)
			{
				this._CurrentUnitCode.HasMaxVal = true;
				this.cbxMaxVal.Enabled = true;
				this.numMaxVal.Enabled = true;
			}
			else
			{
				this._CurrentUnitCode.HasMaxVal = false;
				this.cbxMaxVal.Enabled = false;
				this.numMaxVal.Enabled = false;
			}
		}

		private void cbxMinVal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxMinVal.SelectedIndex == 0)
			{
				this._CurrentUnitCode.IncludeMin = true;
			}
			else
			{
				this._CurrentUnitCode.IncludeMin = false;
			}
		}

		private void cbxMaxVal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbxMaxVal.SelectedIndex == 0)
			{
				this._CurrentUnitCode.IncludeMax = true;
			}
			else
			{
				this._CurrentUnitCode.IncludeMax = false;
			}
		}

		private void numMaxVal_ValueChanged(object sender, EventArgs e)
		{
			this._CurrentUnitCode.MaxVal = Convert.ToSingle(this.numMaxVal.Value);
		}

		private void numMinVal_ValueChanged(object sender, EventArgs e)
		{
			this._CurrentUnitCode.MinVal = Convert.ToSingle(this.numMinVal.Value);
		}

		private void numDecimalPlace_ValueChanged(object sender, EventArgs e)
		{
			this._CurrentUnitCode.DecimalPlace = Convert.ToInt32(this.numDecimalPlace.Value);
			this.numMinVal.DecimalPlaces = this._CurrentUnitCode.DecimalPlace;
			this.numMaxVal.DecimalPlaces = this._CurrentUnitCode.DecimalPlace;
		}

		private void numDecimalPlace_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numDecimalPlace.Text))
			{
				if (float.Parse(this.numDecimalPlace.Text) < Convert.ToSingle(this.numDecimalPlace.Minimum))
				{
					this.numDecimalPlace.Value = this.numDecimalPlace.Minimum;
				}
				else if (float.Parse(this.numDecimalPlace.Text) > Convert.ToSingle(this.numDecimalPlace.Maximum))
				{
					this.numDecimalPlace.Value = this.numDecimalPlace.Maximum;
				}
				else
				{
					this.numDecimalPlace.Value = new decimal(float.Parse(this.numDecimalPlace.Text));
				}
			}
		}

		private void numMinVal_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numMinVal.Text))
			{
				if (float.Parse(this.numMinVal.Text) < Convert.ToSingle(this.numMinVal.Minimum))
				{
					this.numMinVal.Value = this.numMinVal.Minimum;
				}
				else if (float.Parse(this.numMinVal.Text) > Convert.ToSingle(this.numMinVal.Maximum))
				{
					this.numMinVal.Value = this.numMinVal.Maximum;
				}
				else
				{
					this.numMinVal.Value = new decimal(float.Parse(this.numMinVal.Text));
				}
			}
		}

		private void numMaxVal_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numMaxVal.Text))
			{
				if (float.Parse(this.numMaxVal.Text) < Convert.ToSingle(this.numMaxVal.Minimum))
				{
					this.numMaxVal.Value = this.numMaxVal.Minimum;
				}
				else if (float.Parse(this.numMaxVal.Text) > Convert.ToSingle(this.numMaxVal.Maximum))
				{
					this.numMaxVal.Value = this.numMaxVal.Maximum;
				}
				else
				{
					this.numMaxVal.Value = new decimal(float.Parse(this.numMaxVal.Text));
				}
			}
		}
	}
}
