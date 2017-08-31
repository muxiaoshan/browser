using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCMultiChoice : UserControl, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		private NISimple _BindNISimple;

		private MIMultiChoice _BindMIMultiChoice;

		private string _Code;

		private Color _OriginColor;

		private bool boolUpdate;

		private Label curTip;

		private Label curLabel;

		private PCMultiChoice.VChangedEventHandler VChangedEvent;

		private int _leftMargin;

		private int _topMargin;

		private string initValue;

		public event PCMultiChoice.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCMultiChoice.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCMultiChoice.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
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
				this._BindMIMultiChoice = (MIMultiChoice)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				this.Controls.Clear();
				StringEnumerator enumerator = this._BindMIMultiChoice.Choices.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					CheckBox checkBox = new CheckBox();
					checkBox.FlatStyle = FlatStyle.System;
					checkBox.CheckedChanged += new EventHandler(this.CheckBox_CheckedChanged);
					checkBox.Text = current;
					this.Controls.Add(checkBox);
				}
				this.ReArrange();
				checked
				{
					if (Operators.CompareString(this._BindNISimple.ValueCode, "", false) != 0)
					{
						int num = 0;
						string valueCode = this._BindNISimple.ValueCode;
						try
						{
							IEnumerator enumerator2 = this.Controls.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Control control = (Control)enumerator2.Current;
								CheckBox checkBox2 = (CheckBox)control;
								if (num < valueCode.Length)
								{
									if (Operators.CompareString(valueCode.Substring(num, 1), "1", false) == 0)
									{
										checkBox2.Checked = true;
									}
									else
									{
										checkBox2.Checked = false;
									}
									num++;
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
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

		public PCMultiChoice()
		{
			base.SizeChanged += new EventHandler(this.MultiCheck_SizeChanged);
			this._leftMargin = 6;
			this._topMargin = 6;
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
			this.components = new Container();
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this._OriginColor = this.BackColor;
				try
				{
					IEnumerator enumerator = this.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						control.BackColor = CheckMsg.ErrorColor;
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
				this.BackColor = CheckMsg.ErrorColor;
			}
			else
			{
				try
				{
					IEnumerator enumerator2 = this.Controls.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Control control2 = (Control)enumerator2.Current;
						control2.BackColor = this._OriginColor;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.BackColor = this._OriginColor;
			}
		}

		private bool UnChecked()
		{
			if (this._BindNISimple.ValueCode != null)
			{
				if (Operators.CompareString(this._BindNISimple.ValueCode, string.Empty, false) != 0)
				{
					if (int.Parse(this._BindNISimple.ValueCode) != 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMIMultiChoice.AllowNull && this.UnChecked())
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIMultiChoice.Text + "】不允许为空",
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

		private void MultiCheck_SizeChanged(object sender, EventArgs e)
		{
			this.ReArrange();
		}

		private void ReArrange()
		{
			Point location = new Point(0, 0);
			Size size = new Size(0, 0);
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					CheckBox checkBox = (CheckBox)control;
					checkBox.Size = this.GetCheckBoxSize(checkBox);
					checkBox.Location = this.GetCheckBoxLoc(checkBox, location, size);
					location = checkBox.Location;
					size = checkBox.Size;
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

		private Size GetCheckBoxSize(CheckBox curCheckBox)
		{
			Graphics graphics = Graphics.FromHwnd(curCheckBox.Handle);
			SizeF sizeF = graphics.MeasureString(curCheckBox.Text, curCheckBox.Font);
			checked
			{
				int num = (int)Math.Round((double)sizeF.Height);
				int num2 = (int)Math.Round((double)(unchecked(sizeF.Width + 20f)));
				Size size;
				if (num2 > this.Width)
				{
					size = this.Size;
					int num3 = (int)Math.Round(unchecked((double)(checked(size.Width - this._leftMargin)) - (double)curCheckBox.Font.Size * 1.5));
					if (num3 > 0)
					{
						num = (int)Math.Round((double)graphics.MeasureString(curCheckBox.Text, curCheckBox.Font, num3).Height);
						size = this.Size;
						num2 = size.Width - this._leftMargin;
					}
				}
				if (num < 20)
				{
					num = 20;
				}
				size = new Size(num2, num);
				return size;
			}
		}

		private Point GetCheckBoxLoc(CheckBox curCheckBox, Point lastLoc, Size lastSize)
		{
			checked
			{
				int x;
				int num;
				Point result;
				if (this._BindMIMultiChoice.WrapChoice)
				{
					x = this._leftMargin;
					if (lastLoc.Y == 0)
					{
						num = this._topMargin;
					}
					else
					{
						num = lastLoc.Y + lastSize.Height + this._BindMIMultiChoice.LineSpace;
					}
					result = new Point(x, num);
					return result;
				}
				if (lastLoc.X + lastSize.Width + curCheckBox.Size.Width > this.Size.Width)
				{
					x = this._leftMargin;
					num = lastLoc.Y + lastSize.Height + this._BindMIMultiChoice.LineSpace;
				}
				else
				{
					x = lastLoc.X + lastSize.Width;
					num = lastLoc.Y;
				}
				if (num == 0)
				{
					num = this._topMargin;
				}
				result = new Point(x, num);
				return result;
			}
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (!this.boolUpdate)
				{
					int num = 0;
					string text = "";
					string text2 = "";
					try
					{
						IEnumerator enumerator = this.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							if (control is CheckBox)
							{
								CheckBox checkBox = (CheckBox)control;
								if (checkBox.Checked)
								{
									text += "1";
									text2 = text2 + this._BindMIMultiChoice.Choices[num] + this._BindMIMultiChoice.Seperator;
								}
								else
								{
									text += "0";
								}
								num++;
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
					if (text2.Length > 0)
					{
						text2 = text2.Substring(0, text2.Length - this._BindMIMultiChoice.Seperator.Length);
					}
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
							subRevision2.Content = text2;
							revision.SubRevisions.Add(subRevision);
							revision.SubRevisions.Add(subRevision2);
							this._BindNISimple.RevisionHistory.Revisions.Add(revision);
							this._BindNISimple.RevisionHistory.CurrentRevision = revision;
						}
						else
						{
							Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
							SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
							subRevision3.Content = text2;
						}
					}
					this._BindNISimple.Value = text2;
					this._BindNISimple.ValueCode = text;
					if (this.BackColor.Equals(Color.Red))
					{
						this.CheckNull();
					}
					PCMultiChoice.VChangedEventHandler vChangedEvent = this.VChangedEvent;
					if (vChangedEvent != null)
					{
						vChangedEvent(this.Code);
					}
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
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is CheckBox)
					{
						CheckBox checkBox = (CheckBox)control;
						if (checkBox.Checked)
						{
							text += "1";
						}
						else
						{
							text += "0";
						}
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
