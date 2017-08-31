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
	public class PCNumber : NumericUpDown, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		private NISimple _BindNISimple;

		private MINumber _BindMINumber;

		private const float MINVAL = -1E+10f;

		private const float MAXVAL = 1E+10f;

		private string _Code;

		private Label curTip;

		private Label curLabel;

		private bool boolUpdate;

		private PCNumber.VChangedEventHandler VChangedEvent;

		private string initValue;

		public event PCNumber.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCNumber.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCNumber.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
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
				this._BindMINumber = (MINumber)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				this.DecimalPlaces = this._BindMINumber.DecimalPlace;
				this.Increment = new decimal(Math.Pow(10.0, (double)(checked(0 - this.DecimalPlaces))));
				if (this._BindMINumber.HasMaxVal)
				{
					this.Maximum = new decimal(this._BindMINumber.MaxVal);
				}
				else
				{
					this.Maximum = 10000000000m;
				}
				if (this._BindMINumber.HasMinVal)
				{
					this.Minimum = new decimal(this._BindMINumber.MinVal);
				}
				else
				{
					this.Minimum = -10000000000m;
				}
				if (!(this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
				{
					this.Value = new decimal(float.Parse(this._BindNISimple.Value));
				}
				this.boolUpdate = false;
				if (this._BindNISimple.RevisionHistory != null)
				{
					this.AddRevTip(this._BindNISimple.RevisionHistory);
				}
			}
		}

		public PCNumber()
		{
			base.ValueChanged += new EventHandler(this.PCNumber_ValueChanged);
			base.TextChanged += new EventHandler(this.PCNumber_TextChanged);
			base.LostFocus += new EventHandler(this.PCNumber_LostFocus);
			this.initValue = string.Empty;
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
			((ISupportInitialize)this).BeginInit();
			this.BorderStyle = BorderStyle.Fixed3D;
			this.TextAlign = HorizontalAlignment.Right;
			((ISupportInitialize)this).EndInit();
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this.BackColor = CheckMsg.ErrorColor;
			}
			else
			{
				this.BackColor = SystemColors.Window;
			}
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMINumber.AllowNull && (this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMINumber.Text + "】不允许为空",
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
		}

		private void PCNumber_ValueChanged(object sender, EventArgs e)
		{
			if (this._BindNISimple != null & !this.boolUpdate)
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
						subRevision.Content = this._BindNISimple.Value;
						SubRevision subRevision2 = new SubRevision();
						subRevision2.RevType = "R";
						subRevision2.Content = this.Value.ToString();
						revision.SubRevisions.Add(subRevision);
						revision.SubRevisions.Add(subRevision2);
						this._BindNISimple.RevisionHistory.Revisions.Add(revision);
						this._BindNISimple.RevisionHistory.CurrentRevision = revision;
					}
					else
					{
						Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
						SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
						subRevision3.Content = this.Value.ToString();
					}
				}
				this._BindNISimple.Value = this.Value.ToString();
				if (this.BackColor.Equals(Color.Red))
				{
					this.CheckNull();
				}
				PCNumber.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
				}
			}
		}

		private void PCNumber_TextChanged(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.Text))
			{
				if (float.Parse(this.Text) < Convert.ToSingle(this.Minimum))
				{
					this.Text = Conversions.ToString(this.Minimum);
				}
				else if (float.Parse(this.Text) > Convert.ToSingle(this.Maximum))
				{
					this.Text = Conversions.ToString(this.Maximum);
				}
			}
		}

		private void PCNumber_LostFocus(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.Text))
			{
				this.ParseEditText();
				this.Value = new decimal(float.Parse(this.Text));
			}
			else
			{
				this.Text = "0";
				this.Value = new decimal(float.Parse("0"));
			}
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

		public void IsValueChanged(ref bool isChanged)
		{
			if (isChanged)
			{
				return;
			}
			isChanged = Conversions.ToBoolean(Operators.NotObject(StringCompare.Equal(this.initValue, this.Text)));
		}

		public void SetInitValue()
		{
			this.initValue = this.Text;
		}
	}
}
