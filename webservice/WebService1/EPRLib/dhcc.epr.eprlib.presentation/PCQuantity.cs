using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCQuantity : UserControl, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		[AccessedThroughProperty("cbxUnits")]
		private ComboBox _cbxUnits;

		[AccessedThroughProperty("numValue")]
		private NumericUpDown _numValue;

		[AccessedThroughProperty("numPanel")]
		private Panel _numPanel;

		[AccessedThroughProperty("unitPanel")]
		private Panel _unitPanel;

		[AccessedThroughProperty("BPanel")]
		private Panel _BPanel;

		[AccessedThroughProperty("QSplitter")]
		private Splitter _QSplitter;

		private NISimple _BindNISimple;

		private MIQuantity _BindMIQuantity;

		private string _Code;

		private bool boolClear;

		private bool boolUpdate;

		private const float MINVAL = -1E+10f;

		private const float MAXVAL = 1E+10f;

		private MenuItem miClear;

		private ContextMenu cmTool;

		private Label curTip;

		private Label curLabel;

		private PCQuantity.VChangedEventHandler VChangedEvent;

		private string initValue;

		public event PCQuantity.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCQuantity.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCQuantity.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
			}
		}

		internal virtual ComboBox cbxUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cbxUnits_SelectedIndexChanged);
				if (this._cbxUnits != null)
				{
					this._cbxUnits.SelectedIndexChanged -= value2;
				}
				this._cbxUnits = value;
				if (this._cbxUnits != null)
				{
					this._cbxUnits.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual NumericUpDown numValue
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numValue;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.numValue_TextChanged);
				EventHandler value3 = new EventHandler(this.numValue_ValueChanged);
				if (this._numValue != null)
				{
					this._numValue.TextChanged -= value2;
					this._numValue.ValueChanged -= value3;
				}
				this._numValue = value;
				if (this._numValue != null)
				{
					this._numValue.TextChanged += value2;
					this._numValue.ValueChanged += value3;
				}
			}
		}

		internal virtual Panel numPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._numPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._numPanel = value;
			}
		}

		internal virtual Panel unitPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._unitPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._unitPanel = value;
			}
		}

		internal virtual Panel BPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BPanel = value;
			}
		}

		internal virtual Splitter QSplitter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QSplitter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QSplitter = value;
			}
		}

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNISimple;
			}
			set
			{
				this._Code = value.Code;
				this._BindNISimple = (NISimple)value;
				this._BindMIQuantity = (MIQuantity)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				this.cbxUnits.Text = "";
				this.cbxUnits.Items.Clear();
				int num = 0;
				MUnitCodeEnumerator enumerator = this._BindMIQuantity.UnitCodes.GetEnumerator();
				checked
				{
					while (enumerator.MoveNext())
					{
						MUnitCode mUnitCode = (MUnitCode)enumerator.Current;
						this.cbxUnits.Items.Add(mUnitCode.UnitSymbol);
						if (Operators.CompareString(this._BindNISimple.ValueCode, mUnitCode.UnitSymbol, false) == 0)
						{
							this.cbxUnits.SelectedIndex = num;
						}
						num++;
					}
					if (!(this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
					{
						this.numValue.Value = new decimal(float.Parse(this._BindNISimple.Value));
					}
					else if (decimal.Compare(decimal.Zero, this.numValue.Minimum) >= 0 & decimal.Compare(decimal.Zero, this.numValue.Maximum) <= 0)
					{
						this.numValue.Value = decimal.Zero;
					}
					else
					{
						this.numValue.Value = this.numValue.Minimum;
					}
					this.boolUpdate = false;
					if (this._BindNISimple.RevisionHistory != null)
					{
						this.AddRevTip(this._BindNISimple.RevisionHistory);
					}
				}
			}
		}

		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		public PCQuantity()
		{
			base.MouseDown += new MouseEventHandler(this.PCQuantity_MouseDown);
			base.BackColorChanged += new EventHandler(this.PCQuantity_BackColorChanged);
			this.boolClear = false;
			this.boolUpdate = false;
			this.initValue = string.Empty;
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
			this.cbxUnits = new ComboBox();
			this.numValue = new NumericUpDown();
			this.numPanel = new Panel();
			this.unitPanel = new Panel();
			this.BPanel = new Panel();
			this.QSplitter = new Splitter();
			((ISupportInitialize)this.numValue).BeginInit();
			this.numPanel.SuspendLayout();
			this.unitPanel.SuspendLayout();
			this.BPanel.SuspendLayout();
			this.SuspendLayout();
			this.cbxUnits.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.cbxUnits.ItemHeight = 12;
			Control arg_9F_0 = this.cbxUnits;
			Point location = new Point(16, 8);
			arg_9F_0.Location = location;
			this.cbxUnits.Name = "cbxUnits";
			Control arg_C6_0 = this.cbxUnits;
			Size size = new Size(64, 20);
			arg_C6_0.Size = size;
			this.cbxUnits.TabIndex = 1;
			this.numValue.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_F4_0 = this.numValue;
			location = new Point(8, 8);
			arg_F4_0.Location = location;
			this.numValue.Name = "numValue";
			Control arg_11B_0 = this.numValue;
			size = new Size(88, 21);
			arg_11B_0.Size = size;
			this.numValue.TabIndex = 0;
			this.numValue.TextAlign = HorizontalAlignment.Right;
			this.numPanel.Controls.Add(this.numValue);
			this.numPanel.Dock = DockStyle.Fill;
			Control arg_16A_0 = this.numPanel;
			location = new Point(0, 0);
			arg_16A_0.Location = location;
			this.numPanel.Name = "numPanel";
			Control arg_191_0 = this.numPanel;
			size = new Size(112, 40);
			arg_191_0.Size = size;
			this.numPanel.TabIndex = 2;
			this.unitPanel.Controls.Add(this.cbxUnits);
			this.unitPanel.Dock = DockStyle.Right;
			Control arg_1D5_0 = this.unitPanel;
			location = new Point(112, 0);
			arg_1D5_0.Location = location;
			this.unitPanel.Name = "unitPanel";
			Control arg_1FC_0 = this.unitPanel;
			size = new Size(96, 40);
			arg_1FC_0.Size = size;
			this.unitPanel.TabIndex = 3;
			this.BPanel.Controls.Add(this.QSplitter);
			this.BPanel.Controls.Add(this.numPanel);
			this.BPanel.Controls.Add(this.unitPanel);
			this.BPanel.Dock = DockStyle.Fill;
			Control arg_26B_0 = this.BPanel;
			location = new Point(0, 0);
			arg_26B_0.Location = location;
			this.BPanel.Name = "BPanel";
			Control arg_295_0 = this.BPanel;
			size = new Size(208, 40);
			arg_295_0.Size = size;
			this.BPanel.TabIndex = 4;
			this.QSplitter.Dock = DockStyle.Right;
			Control arg_2C3_0 = this.QSplitter;
			location = new Point(107, 0);
			arg_2C3_0.Location = location;
			this.QSplitter.Name = "QSplitter";
			Control arg_2E9_0 = this.QSplitter;
			size = new Size(5, 40);
			arg_2E9_0.Size = size;
			this.QSplitter.TabIndex = 4;
			this.QSplitter.TabStop = false;
			this.Controls.Add(this.BPanel);
			this.Name = "PCQuantity";
			size = new Size(208, 40);
			this.Size = size;
			((ISupportInitialize)this.numValue).EndInit();
			this.numPanel.ResumeLayout(false);
			this.unitPanel.ResumeLayout(false);
			this.BPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void Init()
		{
			this.miClear = new MenuItem("清空数据！");
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmTool = new ContextMenu();
			this.cmTool.MenuItems.Add(this.miClear);
		}

		public void OnClear(object sender, EventArgs e)
		{
			if (this._BindNISimple != null)
			{
				this._BindNISimple.Value = "";
				this._BindNISimple.ValueCode = "";
				this.boolClear = true;
				this.BindInstanceItem = this._BindNISimple;
				this.boolClear = false;
			}
		}

		private void PCQuantity_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu arg_28_0 = this.cmTool;
				Point pos = new Point(e.X, e.Y);
				arg_28_0.Show(this, pos);
			}
		}

		private void cbxUnits_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this._BindNISimple.RevStatus)
			{
				if (this._BindNISimple.RevisionHistory == null)
				{
					this._BindNISimple.RevisionHistory = new RevisionHistory();
					this.AddRevTip(this._BindNISimple.RevisionHistory);
				}
				if (this._BindNISimple.RevisionHistory.CurrentRevision == null)
				{
					Revision revision = new Revision();
					revision.RevTime = this._BindNISimple.RevTime;
					revision.RevPerson = this._BindNISimple.RevPerson;
					revision.RevIP = CommonFuncs.clientIP;
					SubRevision subRevision = new SubRevision();
					subRevision.RevType = "D";
					subRevision.Content = this._BindNISimple.Value + this.cbxUnits.Text;
					SubRevision subRevision2 = new SubRevision();
					subRevision2.RevType = "R";
					subRevision2.Content = this.numValue.Value.ToString() + this._BindNISimple.ValueCode;
					revision.SubRevisions.Add(subRevision);
					revision.SubRevisions.Add(subRevision2);
					this._BindNISimple.RevisionHistory.Revisions.Add(revision);
					this._BindNISimple.RevisionHistory.CurrentRevision = revision;
				}
				else
				{
					Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
					SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
					subRevision3.Content = this._BindNISimple.Value + this.cbxUnits.Text;
				}
			}
			this._BindNISimple.ValueCode = this.cbxUnits.Text;
			MUnitCode mUnitCode = this._BindMIQuantity.UnitCodes[this.cbxUnits.SelectedIndex];
			this.numValue.DecimalPlaces = mUnitCode.DecimalPlace;
			if (mUnitCode.HasMaxVal)
			{
				this.numValue.Maximum = new decimal(mUnitCode.MaxVal);
			}
			else
			{
				this.numValue.Maximum = 10000000000m;
			}
			if (mUnitCode.HasMinVal)
			{
				this.numValue.Minimum = new decimal(mUnitCode.MinVal);
			}
			else
			{
				this.numValue.Minimum = -10000000000m;
			}
			if (!this.boolUpdate)
			{
				PCQuantity.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
				}
			}
		}

		private void numValue_ValueChanged(object sender, EventArgs e)
		{
			if (!this.boolClear & !this.boolUpdate)
			{
				if (this._BindNISimple.RevStatus)
				{
					if (this._BindNISimple.RevisionHistory == null)
					{
						this._BindNISimple.RevisionHistory = new RevisionHistory();
						this.AddRevTip(this._BindNISimple.RevisionHistory);
					}
					if (this._BindNISimple.RevisionHistory.CurrentRevision == null)
					{
						Revision revision = new Revision();
						revision.RevTime = this._BindNISimple.RevTime;
						revision.RevPerson = this._BindNISimple.RevPerson;
						revision.RevIP = CommonFuncs.clientIP;
						SubRevision subRevision = new SubRevision();
						subRevision.RevType = "D";
						subRevision.Content = this._BindNISimple.Value + this._BindNISimple.ValueCode;
						SubRevision subRevision2 = new SubRevision();
						subRevision2.RevType = "R";
						subRevision2.Content = this.numValue.Value.ToString() + this._BindNISimple.ValueCode;
						revision.SubRevisions.Add(subRevision);
						revision.SubRevisions.Add(subRevision2);
						this._BindNISimple.RevisionHistory.Revisions.Add(revision);
						this._BindNISimple.RevisionHistory.CurrentRevision = revision;
					}
					else
					{
						Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
						SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
						subRevision3.Content = this.numValue.Value.ToString() + this._BindNISimple.ValueCode;
					}
				}
				this._BindNISimple.Value = this.numValue.Value.ToString();
				if (!this.boolUpdate)
				{
					PCQuantity.VChangedEventHandler vChangedEvent = this.VChangedEvent;
					if (vChangedEvent != null)
					{
						vChangedEvent(this.Code);
					}
				}
			}
		}

		private void numValue_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.numValue.Text))
			{
				if (float.Parse(this.numValue.Text) < Convert.ToSingle(this.numValue.Minimum))
				{
					this.numValue.Value = this.numValue.Minimum;
				}
				else if (float.Parse(this.numValue.Text) > Convert.ToSingle(this.numValue.Maximum))
				{
					this.numValue.Value = this.numValue.Maximum;
				}
				else
				{
					this.numValue.Value = new decimal(float.Parse(this.numValue.Text));
				}
			}
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
			reader.Read();
			if (Operators.CompareString(reader.Name, "PanelOneWidth", false) == 0 & !reader.IsEmptyElement)
			{
				reader.Read();
				this.numPanel.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
			}
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMIQuantity.AllowNull && (this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0 | (this._BindNISimple.ValueCode == null | Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0)))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIQuantity.Text + "】不允许为空",
					RelatedElements = 
					{
						{
							this.Code,
							this.BindInstanceItem
						}
					}
				};
			}
			return null;
		}

		public CheckMsg SpecialCheck()
		{
			return null;
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this.numValue.BackColor = CheckMsg.ErrorColor;
				this.cbxUnits.BackColor = CheckMsg.ErrorColor;
			}
			else
			{
				this.numValue.BackColor = SystemColors.Window;
				this.cbxUnits.BackColor = SystemColors.Window;
			}
		}

		private void PCQuantity_BackColorChanged(object sender, EventArgs e)
		{
			this.numPanel.BackColor = this.BackColor;
			this.unitPanel.BackColor = this.BackColor;
			this.QSplitter.BackColor = this.BackColor;
		}

		private void AddRevTip(RevisionHistory revHis)
		{
			if (this.curLabel == null)
			{
				this.curLabel = new Label();
				this.curLabel.Width = 6;
				this.curLabel.Height = 6;
				this.curLabel.BackColor = Color.Red;
				this.curLabel.Top = 0;
				this.curLabel.Left = checked(this.Width - 6);
				this.curLabel.Tag = revHis;
				this.curLabel.MouseEnter += new EventHandler(this.TipLabel_MouseEnter);
				this.curLabel.MouseLeave += new EventHandler(this.TipLabel_MouseLeave);
				this.Controls.Add(this.curLabel);
				this.curLabel.BringToFront();
			}
		}

		private void TipLabel_MouseEnter(object sender, EventArgs e)
		{
			Control control = this;
			CommonFuncs.ShowRevTip(ref this.curTip, ref sender, ref control);
		}

		private void TipLabel_MouseLeave(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this.curTip);
		}

		public string getValue()
		{
			return this.numValue.Text + this.cbxUnits.Text;
		}

		public void IsValueChanged(ref bool isChanged)
		{
			if (isChanged)
			{
				return;
			}
			isChanged = Conversions.ToBoolean(Operators.NotObject(StringCompare.Equal(this.initValue, this.getValue())));
		}

		public void SetInitValue()
		{
			this.initValue = this.getValue();
		}
	}
}
