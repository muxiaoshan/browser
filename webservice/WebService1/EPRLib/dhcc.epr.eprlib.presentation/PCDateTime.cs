using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
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
	public class PCDateTime : UserControl, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		[AccessedThroughProperty("DatePanel")]
		private Panel _DatePanel;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("TimePanel")]
		private Panel _TimePanel;

		[AccessedThroughProperty("timePicker")]
		private EPRDateTimePicker _timePicker;

		[AccessedThroughProperty("datePicker")]
		private EPRDateTimePicker _datePicker;

		private NISimple m_BindNISimple;

		private MIDateTime m_BindMIDateTime;

		private string _Code;

		private DateTime CurrentDateTime;

		private bool boolClear;

		private MenuItem miClear;

		private ContextMenu cmTool;

		private bool boolUpdate;

		private Label curTip;

		private Label curLabel;

		private PCDateTime.VChangedEventHandler VChangedEvent;

		private const string SHORTTIMEFORMATE = "H:mm";

		private const string LONGTIMEFORMATE = "H:mm:ss";

		private const string SHORTDATEFORMATE = "yyyy-M-d";

		private const string LONGDATEFORMATE = "yyyy年M月d日";

		private string initValue;

		public event PCDateTime.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCDateTime.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCDateTime.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
			}
		}

		internal virtual Panel DatePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DatePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PCDateTime_MouseDown);
				if (this._DatePanel != null)
				{
					this._DatePanel.MouseDown -= value2;
				}
				this._DatePanel = value;
				if (this._DatePanel != null)
				{
					this._DatePanel.MouseDown += value2;
				}
			}
		}

		internal virtual Splitter Splitter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Splitter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter1 = value;
			}
		}

		internal virtual Panel TimePanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TimePanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PCDateTime_MouseDown);
				if (this._TimePanel != null)
				{
					this._TimePanel.MouseDown -= value2;
				}
				this._TimePanel = value;
				if (this._TimePanel != null)
				{
					this._TimePanel.MouseDown += value2;
				}
			}
		}

		internal virtual EPRDateTimePicker timePicker
		{
			[DebuggerNonUserCode]
			get
			{
				return this._timePicker;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.timePicker_ValueChanged);
				if (this._timePicker != null)
				{
					this._timePicker.ValueChanged -= value2;
				}
				this._timePicker = value;
				if (this._timePicker != null)
				{
					this._timePicker.ValueChanged += value2;
				}
			}
		}

		internal virtual EPRDateTimePicker datePicker
		{
			[DebuggerNonUserCode]
			get
			{
				return this._datePicker;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.datePicker_ValueChanged);
				if (this._datePicker != null)
				{
					this._datePicker.ValueChanged -= value2;
				}
				this._datePicker = value;
				if (this._datePicker != null)
				{
					this._datePicker.ValueChanged += value2;
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

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this.m_BindNISimple;
			}
			set
			{
				this.boolUpdate = true;
				this._Code = value.Code;
				this.m_BindNISimple = (NISimple)value;
				this.m_BindMIDateTime = (MIDateTime)this.m_BindNISimple.BindMMetaItem;
				if (Operators.CompareString(this.m_BindMIDateTime.DateFormate, "SHORT", false) == 0)
				{
					this.datePicker.Format = DateTimePickerFormat.Custom;
					this.datePicker.CustomFormat = "yyyy-M-d";
				}
				if (Operators.CompareString(this.m_BindMIDateTime.TimeFormate, "SHORT", false) == 0)
				{
					this.timePicker.Format = DateTimePickerFormat.Custom;
					this.timePicker.CustomFormat = "H:mm";
				}
				if (!this.m_BindMIDateTime.IncludeDate & this.m_BindMIDateTime.IncludeTime)
				{
					this.DatePanel.Width = 0;
					this.Splitter1.Width = 0;
					this.Splitter1.Enabled = false;
					this.TimePanel.Left = 0;
					this.TimePanel.Top = 0;
					this.TimePanel.Dock = DockStyle.Fill;
				}
				else if (this.m_BindMIDateTime.IncludeDate & !this.m_BindMIDateTime.IncludeTime)
				{
					this.TimePanel.Dock = DockStyle.Right;
					this.Splitter1.Dock = DockStyle.Right;
					this.DatePanel.Dock = DockStyle.Fill;
					this.TimePanel.Width = 0;
					this.Splitter1.Width = 0;
					this.Splitter1.Enabled = false;
				}
				if (this.m_BindNISimple.ValueCode != null)
				{
					if (Operators.CompareString(this.m_BindNISimple.ValueCode, "", false) != 0)
					{
						if (Operators.CompareString(this.m_BindNISimple.ValueCode, " ", false) != 0)
						{
							this.m_BindNISimple.ValueCode = this.m_BindNISimple.ValueCode.Replace("#", " ");
							this.m_BindNISimple.ValueCode = this.m_BindNISimple.ValueCode.Replace("9999-99-99", "1753-1-1");
							this.m_BindNISimple.ValueCode = this.m_BindNISimple.ValueCode.Replace("99:99:99", "00:00:00");
							string left = this.m_BindNISimple.ValueCode.Split(new char[]
							{
								' '
							})[0];
							string left2 = this.m_BindNISimple.ValueCode.Split(new char[]
							{
								' '
							})[1];
							if (this.m_BindMIDateTime.IncludeDate && Operators.CompareString(left, "1753-1-1", false) != 0 && Operators.CompareString(left, "", false) != 0)
							{
								this.datePicker.Checked = true;
								this.datePicker.Value = DateTime.Parse(this.m_BindNISimple.ValueCode);
							}
							else
							{
								this.datePicker.Checked = false;
							}
							if (this.m_BindMIDateTime.IncludeTime && Operators.CompareString(left2, "00:00:00", false) != 0 && Operators.CompareString(left2, "", false) != 0)
							{
								this.timePicker.Checked = true;
								this.timePicker.Value = DateTime.Parse(this.m_BindNISimple.ValueCode);
								goto IL_336;
							}
							this.timePicker.Checked = false;
							goto IL_336;
						}
					}
				}
				this.timePicker.Checked = false;
				this.datePicker.Checked = false;
				IL_336:
				this.boolUpdate = false;
				if (this.m_BindNISimple.RevisionHistory != null)
				{
					this.AddRevTip(this.m_BindNISimple.RevisionHistory);
				}
			}
		}

		public PCDateTime()
		{
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
			this.DatePanel = new Panel();
			this.datePicker = new EPRDateTimePicker();
			this.Splitter1 = new Splitter();
			this.TimePanel = new Panel();
			this.timePicker = new EPRDateTimePicker();
			this.DatePanel.SuspendLayout();
			this.TimePanel.SuspendLayout();
			this.SuspendLayout();
			this.DatePanel.Controls.Add(this.datePicker);
			this.DatePanel.Dock = DockStyle.Left;
			Control arg_85_0 = this.DatePanel;
			Point location = new Point(0, 0);
			arg_85_0.Location = location;
			this.DatePanel.Name = "DatePanel";
			Control arg_AF_0 = this.DatePanel;
			Size size = new Size(136, 32);
			arg_AF_0.Size = size;
			this.DatePanel.TabIndex = 0;
			this.datePicker.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.datePicker.CustomFormat = "yyyy年M月d日";
			this.datePicker.Format = DateTimePickerFormat.Custom;
			Control arg_F9_0 = this.datePicker;
			location = new Point(6, 5);
			arg_F9_0.Location = location;
			this.datePicker.Name = "datePicker";
			this.datePicker.ShowCheckBox = true;
			Control arg_12F_0 = this.datePicker;
			size = new Size(130, 21);
			arg_12F_0.Size = size;
			this.datePicker.TabIndex = 1;
			DateTimePicker arg_15D_0 = this.datePicker;
			DateTime value = new DateTime(2010, 11, 14, 19, 59, 0, 0);
			arg_15D_0.Value = value;
			this.Splitter1.Enabled = false;
			Control arg_182_0 = this.Splitter1;
			location = new Point(136, 0);
			arg_182_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_1A8_0 = this.Splitter1;
			size = new Size(4, 32);
			arg_1A8_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.TimePanel.Controls.Add(this.timePicker);
			this.TimePanel.Dock = DockStyle.Left;
			Control arg_1FB_0 = this.TimePanel;
			location = new Point(140, 0);
			arg_1FB_0.Location = location;
			this.TimePanel.Name = "TimePanel";
			Control arg_222_0 = this.TimePanel;
			size = new Size(93, 32);
			arg_222_0.Size = size;
			this.TimePanel.TabIndex = 2;
			this.timePicker.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.timePicker.CustomFormat = "H:mm:ss";
			this.timePicker.Format = DateTimePickerFormat.Custom;
			Control arg_26C_0 = this.timePicker;
			location = new Point(0, 5);
			arg_26C_0.Location = location;
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowCheckBox = true;
			this.timePicker.ShowUpDown = true;
			Control arg_2AB_0 = this.timePicker;
			size = new Size(88, 21);
			arg_2AB_0.Size = size;
			this.timePicker.TabIndex = 0;
			DateTimePicker arg_2D7_0 = this.timePicker;
			value = new DateTime(2010, 1, 14, 10, 0, 0, 0);
			arg_2D7_0.Value = value;
			this.Controls.Add(this.TimePanel);
			this.Controls.Add(this.Splitter1);
			this.Controls.Add(this.DatePanel);
			this.Name = "PCDateTime";
			size = new Size(232, 32);
			this.Size = size;
			this.DatePanel.ResumeLayout(false);
			this.TimePanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public void initDate(DateTime sysDate)
		{
			this.datePicker.Value = sysDate;
			this.timePicker.Value = sysDate;
		}

		public void Init()
		{
			this.miClear = new MenuItem("清空数据！");
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmTool = new ContextMenu();
			this.cmTool.MenuItems.Add(this.miClear);
			this.datePicker.Value = DateTime.Now;
			this.timePicker.Value = DateTime.Now;
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this.BackColor = CheckMsg.ErrorColor;
			}
			else if (this.Parent != null)
			{
				this.BackColor = this.Parent.BackColor;
			}
		}

		public CheckMsg CheckNull()
		{
			if (this.m_BindMIDateTime.AllowNull)
			{
				CheckMsg checkMsg = new CheckMsg();
				checkMsg.CheckType = ECheckType.Null;
				bool flag = false;
				if (this.m_BindMIDateTime.IncludeDate & !this.datePicker.Checked)
				{
					checkMsg.ErrorDesc = "【" + this.m_BindMIDateTime.Text + "】日期不允许为空";
					flag = true;
				}
				else if (this.m_BindMIDateTime.IncludeTime & !this.timePicker.Checked)
				{
					checkMsg.ErrorDesc = "【" + this.m_BindMIDateTime.Text + "】时间不允许为空";
					flag = true;
				}
				else if (this.m_BindNISimple.ValueCode == null | Operators.CompareString(this.m_BindNISimple.ValueCode, "", false) == 0)
				{
					checkMsg.ErrorDesc = "【" + this.m_BindMIDateTime.Text + "】不允许为空";
					flag = true;
				}
				if (flag)
				{
					checkMsg.RelatedElements.Add(this.Code, this.BindInstanceItem);
					return checkMsg;
				}
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
			reader.Read();
			if (Operators.CompareString(reader.Name, "PanelOneWidth", false) == 0 & !reader.IsEmptyElement)
			{
				reader.Read();
				this.DatePanel.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
			}
		}

		public void OnClear(object sender, EventArgs e)
		{
			if (this.m_BindNISimple != null)
			{
				this.m_BindNISimple.Value = "";
				this.m_BindNISimple.ValueCode = "";
				this.boolClear = true;
				this.BindInstanceItem = this.m_BindNISimple;
				this.boolClear = false;
			}
		}

		private void PCDateTime_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu arg_28_0 = this.cmTool;
				Point pos = new Point(e.X, e.Y);
				arg_28_0.Show(this, pos);
			}
		}

		private void ValueChanged()
		{
			if (this.m_BindMIDateTime != null & !this.boolUpdate)
			{
				string text = "";
				string valueCode = "";
				if (this.m_BindMIDateTime.IncludeDate & !this.m_BindMIDateTime.IncludeTime)
				{
					if (this.datePicker.Checked)
					{
						if (Operators.CompareString(this.m_BindMIDateTime.DateFormate, "LONG", false) == 0)
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"年",
								this.datePicker.Value.Month.ToString(),
								"月",
								this.datePicker.Value.Day.ToString(),
								"日"
							});
						}
						else
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"-",
								this.datePicker.Value.Month.ToString(),
								"-",
								this.datePicker.Value.Day.ToString()
							});
						}
						valueCode = string.Concat(new string[]
						{
							this.datePicker.Value.Year.ToString(),
							"-",
							this.datePicker.Value.Month.ToString(),
							"-",
							this.datePicker.Value.Day.ToString(),
							" 00:00:00"
						});
					}
				}
				else if (!this.m_BindMIDateTime.IncludeDate & this.m_BindMIDateTime.IncludeTime)
				{
					if (this.timePicker.Checked)
					{
						text = this.FormateTimeValue(this.timePicker.Value);
						valueCode = "1753-1-1 " + this.FormateTime(this.timePicker.Value);
					}
				}
				else if (this.m_BindMIDateTime.IncludeDate & this.m_BindMIDateTime.IncludeTime)
				{
					if (this.datePicker.Checked & !this.timePicker.Checked)
					{
						if (Operators.CompareString(this.m_BindMIDateTime.DateFormate, "LONG", false) == 0)
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"年",
								this.datePicker.Value.Month.ToString(),
								"月",
								this.datePicker.Value.Day.ToString(),
								"日"
							});
						}
						else
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"-",
								this.datePicker.Value.Month.ToString(),
								"-",
								this.datePicker.Value.Day.ToString()
							});
						}
						valueCode = string.Concat(new string[]
						{
							this.datePicker.Value.Year.ToString(),
							"-",
							this.datePicker.Value.Month.ToString(),
							"-",
							this.datePicker.Value.Day.ToString(),
							" 00:00:00"
						});
					}
					else if (!this.datePicker.Checked & this.timePicker.Checked)
					{
						text = this.FormateTimeValue(this.timePicker.Value);
						valueCode = "1753-1-1 " + this.FormateTime(this.timePicker.Value);
					}
					else if (this.datePicker.Checked & this.timePicker.Checked)
					{
						if (Operators.CompareString(this.m_BindMIDateTime.DateFormate, "LONG", false) == 0)
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"年",
								this.datePicker.Value.Month.ToString(),
								"月",
								this.datePicker.Value.Day.ToString(),
								"日 ",
								this.FormateTimeValue(this.timePicker.Value)
							});
						}
						else
						{
							text = string.Concat(new string[]
							{
								this.datePicker.Value.Year.ToString(),
								"-",
								this.datePicker.Value.Month.ToString(),
								"-",
								this.datePicker.Value.Day.ToString(),
								" ",
								this.FormateTimeValue(this.timePicker.Value)
							});
						}
						valueCode = string.Concat(new string[]
						{
							this.datePicker.Value.Year.ToString(),
							"-",
							this.datePicker.Value.Month.ToString(),
							"-",
							this.datePicker.Value.Day.ToString(),
							" ",
							this.FormateTime(this.timePicker.Value)
						});
					}
				}
				this.SetRevContent(this.m_BindNISimple.Value, text);
				this.m_BindNISimple.ValueCode = valueCode;
				this.m_BindNISimple.Value = text;
				if (this.BackColor.Equals(Color.Red))
				{
					this.CheckNull();
				}
				PCDateTime.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
				}
			}
		}

		private string FormateTime(DateTime valDate)
		{
			return string.Format("{0:00}:{1:00}:{2:00}", valDate.Hour, valDate.Minute, valDate.Second);
		}

		private string FormateTimeValue(DateTime valDate)
		{
			if (Operators.CompareString(this.m_BindMIDateTime.TimeFormate, "SHORT", false) == 0)
			{
				return string.Format("{0:00}:{1:00}", valDate.Hour, valDate.Minute);
			}
			return string.Format("{0:00}:{1:00}:{2:00}", valDate.Hour, valDate.Minute, valDate.Second);
		}

		private void timePicker_ValueChanged(object sender, EventArgs e)
		{
			this.ValueChanged();
		}

		private void datePicker_ValueChanged(object sender, EventArgs e)
		{
			this.ValueChanged();
		}

		private void SetRevContent(string orginalContent, string newContent)
		{
			if (this.m_BindNISimple.RevStatus)
			{
				if (this.m_BindNISimple.RevisionHistory == null)
				{
					this.m_BindNISimple.RevisionHistory = new RevisionHistory();
					this.AddRevTip(this.m_BindNISimple.RevisionHistory);
				}
				if (this.m_BindNISimple.RevisionHistory.CurrentRevision == null)
				{
					Revision revision = new Revision();
					revision.RevTime = this.m_BindNISimple.RevTime;
					revision.RevPerson = this.m_BindNISimple.RevPerson;
					revision.RevIP = CommonFuncs.clientIP;
					SubRevision subRevision = new SubRevision();
					subRevision.RevType = "D";
					subRevision.Content = orginalContent;
					SubRevision subRevision2 = new SubRevision();
					subRevision2.RevType = "R";
					subRevision2.Content = newContent;
					revision.SubRevisions.Add(subRevision);
					revision.SubRevisions.Add(subRevision2);
					this.m_BindNISimple.RevisionHistory.Revisions.Add(revision);
					this.m_BindNISimple.RevisionHistory.CurrentRevision = revision;
				}
				else
				{
					Revision revision = this.m_BindNISimple.RevisionHistory.CurrentRevision;
					SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
					subRevision3.Content = newContent;
				}
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

		public string getValue()
		{
			string text = string.Empty;
			if (this.datePicker.Checked)
			{
				text = this.datePicker.Value.ToString();
			}
			if (this.timePicker.Checked)
			{
				text += this.timePicker.Value.ToString();
			}
			return text;
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
