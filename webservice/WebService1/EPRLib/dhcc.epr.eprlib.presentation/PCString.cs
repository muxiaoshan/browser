using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCString : TextBox, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		private NISimple _BindNISimple;

		private string _Code;

		private MIString _BindMIString;

		private bool boolUpdate;

		private Label curTip;

		private PCString.VChangedEventHandler VChangedEvent;

		private const int WM_PASTE = 770;

		private const int WM_UNDO = 772;

		private const int WM_IME_STARTCOMPOSITION = 269;

		private const int WM_ENTER = 646;

		private string initValue;

		public event PCString.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCString.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCString.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
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
				this._BindMIString = (MIString)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				this.Text = this._BindNISimple.Value;
				this.boolUpdate = false;
				if (this._BindNISimple.RevisionHistory != null)
				{
					this.AddRevTip(this._BindNISimple.RevisionHistory);
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

		public PCString()
		{
			base.KeyPress += new KeyPressEventHandler(this.PCString_KeyPress);
			base.TextChanged += new EventHandler(this.PCString_TextChanged);
			this.boolUpdate = false;
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
			this.BorderStyle = BorderStyle.Fixed3D;
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
			if (this._BindMIString.AllowNull && (this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIString.Text + "】不允许为空",
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
			if (!(this._BindMIString.RegExp == null | Operators.CompareString(this._BindMIString.RegExp, "", false) == 0))
			{
				Regex regex = new Regex(this._BindMIString.RegExp);
				Match match = regex.Match(this._BindNISimple.Value);
				if (!match.Success)
				{
					return new CheckMsg
					{
						CheckType = ECheckType.Special,
						ErrorDesc = "【" + this._BindMIString.Text + "】字符串格式不符合要求",
						RelatedElements = 
						{
							{
								this.Code,
								this.BindInstanceItem
							}
						}
					};
				}
			}
			return null;
		}

		private void PCString_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\t')
			{
			}
			if (e.KeyChar != '\u0016')
			{
				if (this.NeedCheckLength())
				{
					int keyChar = (int)e.KeyChar;
					if (CommonFuncs.IsOverflowMaxLength(ref keyChar, this.GetMaxLengthFromMeta(), this.Text, this.SelectedText))
					{
						e.Handled = true;
					}
					else
					{
						e.Handled = false;
					}
				}
				else
				{
					e.Handled = false;
				}
			}
		}

		private void PCString_TextChanged(object sender, EventArgs e)
		{
			if (this._BindNISimple != null & !this.boolUpdate)
			{
				if (this.NeedCheckLength())
				{
					int num = 0;
					if (CommonFuncs.IsOverflowMaxLength(ref num, this.GetMaxLengthFromMeta(), this.Text, this.SelectedText))
					{
						string text = string.Empty;
						this.SelectionStart = 0;
						this.SelectionLength = this.GetMaxLengthFromMeta();
						text = this.SelectedText;
						this.Text = text;
						this.SelectionStart = Strings.Len(Strings.Trim(this.Text));
					}
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
						subRevision2.Content = this.Text;
						revision.SubRevisions.Add(subRevision);
						revision.SubRevisions.Add(subRevision2);
						this._BindNISimple.RevisionHistory.Revisions.Add(revision);
						this._BindNISimple.RevisionHistory.CurrentRevision = revision;
					}
					else
					{
						Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
						SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
						subRevision3.Content = this.Text;
					}
				}
				this._BindNISimple.Value = this.Text;
				PCString.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
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
			Label label = new Label();
			label.Width = 6;
			label.Height = 6;
			label.BackColor = Color.Red;
			label.Top = 0;
			label.Left = checked(this.Width - 6);
			label.Tag = revHis;
			label.MouseEnter += new EventHandler(this.TipLabel_MouseEnter);
			label.MouseLeave += new EventHandler(this.TipLabel_MouseLeave);
			this.Controls.Add(label);
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

		private bool NeedCheckLength()
		{
			MIString mIString = (MIString)this.BindInstanceItem.BindMMetaItem;
			return mIString.NeedCheckLength;
		}

		private int GetMaxLengthFromMeta()
		{
			MIString mIString = (MIString)this.BindInstanceItem.BindMMetaItem;
			return mIString.MaxLength;
		}

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetKeyboardLayout(int dwLayout);

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
			case 770:
			{
				string text = this.Text;
				try
				{
					string txt = Conversions.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, false));
					if (this.NeedCheckLength())
					{
						if (!CommonFuncs.IsOverflowMaxLength(txt, this.GetMaxLengthFromMeta(), this.Text, this.SelectedText))
						{
							base.WndProc(ref m);
						}
					}
					else
					{
						base.WndProc(ref m);
					}
					return;
				}
				catch (Exception expr_73)
				{
					ProjectData.SetProjectError(expr_73);
					this.Text = text;
					ProjectData.ClearProjectError();
					return;
				}
				break;
			}
			case 771:
				goto IL_BF;
			case 772:
				break;
			default:
				goto IL_BF;
			}
			if (this.NeedCheckLength() && CommonFuncs.IsOverflowMaxLength(this.SelectedText, this.GetMaxLengthFromMeta(), this.Text, this.SelectedText))
			{
				base.WndProc(ref m);
			}
			base.WndProc(ref m);
			return;
			IL_BF:
			base.WndProc(ref m);
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
