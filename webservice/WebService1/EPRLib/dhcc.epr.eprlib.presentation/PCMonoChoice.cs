using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCMonoChoice : ComboBox, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		private NISimple _BindNISimple;

		private string _Code;

		private MenuItem miClear;

		private ContextMenu cmTool;

		private MIMonoChoice _BindMIMonoChoice;

		private Label curTip;

		private Label curLabel;

		private bool boolUpdate;

		private PCMonoChoice.VChangedEventHandler VChangedEvent;

		private string initValue;

		public event PCMonoChoice.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCMonoChoice.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCMonoChoice.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
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
				this._BindMIMonoChoice = (MIMonoChoice)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				this.Text = this._BindNISimple.Value;
				MIMonoChoice mIMonoChoice = (MIMonoChoice)this._BindNISimple.BindMMetaItem;
				this.Items.Clear();
				int num = 0;
				int num2 = -1;
				StringEnumerator enumerator = mIMonoChoice.Choices.GetEnumerator();
				checked
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						ChoiceItem choiceItem = new ChoiceItem();
						if (current.IndexOf("|") > -1)
						{
							choiceItem.ChoiceValue = current.Split(new char[]
							{
								'|'
							})[0];
							choiceItem.ChoiceCode = current.Split(new char[]
							{
								'|'
							})[1];
						}
						else
						{
							choiceItem.ChoiceValue = current;
							choiceItem.ChoiceCode = num.ToString();
						}
						this.Items.Add(choiceItem);
						if (!(this._BindNISimple.ValueCode == null | Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0) && Operators.CompareString(this._BindNISimple.ValueCode, choiceItem.ChoiceCode, false) == 0)
						{
							num2 = num;
						}
						num++;
					}
					if (num2 > -1)
					{
						this.SelectedIndex = num2;
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

		public PCMonoChoice()
		{
			base.MouseDown += new MouseEventHandler(this.PCMonoChoice_MouseDown);
			base.SelectedIndexChanged += new EventHandler(this.PCMonoChoice_SelectedIndexChanged);
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
			this.components = new Container();
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMIMonoChoice.AllowNull && (this._BindNISimple.ValueCode == null | Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIMonoChoice.Text + "】不允许为空",
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

		public CheckMsg SpecialCheck()
		{
			return null;
		}

		public void Init()
		{
			this.miClear = new MenuItem("清空数据！");
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmTool = new ContextMenu();
			this.cmTool.MenuItems.Add(this.miClear);
			this.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public void OnClear(object sender, EventArgs e)
		{
			if (this._BindNISimple != null)
			{
				this._BindNISimple.Value = "";
				this._BindNISimple.ValueCode = "";
				this.BindInstanceItem = this._BindNISimple;
			}
		}

		private void PCMonoChoice_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu arg_28_0 = this.cmTool;
				Point pos = new Point(e.X, e.Y);
				arg_28_0.Show(this, pos);
			}
		}

		private void PCMonoChoice_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this._BindNISimple != null & !this.boolUpdate)
			{
				ChoiceItem choiceItem = (ChoiceItem)this.SelectedItem;
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
						subRevision2.Content = choiceItem.ChoiceValue;
						revision.SubRevisions.Add(subRevision);
						revision.SubRevisions.Add(subRevision2);
						this._BindNISimple.RevisionHistory.Revisions.Add(revision);
						this._BindNISimple.RevisionHistory.CurrentRevision = revision;
					}
					else
					{
						Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
						SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
						subRevision3.Content = choiceItem.ChoiceValue;
					}
				}
				this._BindNISimple.Value = choiceItem.ChoiceValue;
				this._BindNISimple.ValueCode = choiceItem.ChoiceCode;
				PCMonoChoice.VChangedEventHandler vChangedEvent = this.VChangedEvent;
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
			ChoiceItem choiceItem = (ChoiceItem)this.SelectedItem;
			if (choiceItem == null)
			{
				return string.Empty;
			}
			return choiceItem.ChoiceCode;
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
