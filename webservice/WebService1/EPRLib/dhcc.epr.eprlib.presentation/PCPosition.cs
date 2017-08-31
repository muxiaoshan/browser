using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PCPosition : UserControl, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		[AccessedThroughProperty("txtDesc")]
		private TextBox _txtDesc;

		[AccessedThroughProperty("btnPos")]
		private Button _btnPos;

		private NISimple _BindNISimple;

		private MIPosition _BindMIPosition;

		private MenuItem miClear;

		private ContextMenu cmTool;

		private string _Code;

		private Label curTip;

		private Label curLabel;

		private PCPosition.VChangedEventHandler VChangedEvent;

		private string initValue;

		public event PCPosition.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCPosition.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCPosition.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
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
				this._txtDesc = value;
			}
		}

		internal virtual Button btnPos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPos_Click);
				if (this._btnPos != null)
				{
					this._btnPos.Click -= value2;
				}
				this._btnPos = value;
				if (this._btnPos != null)
				{
					this._btnPos.Click += value2;
				}
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
				this._BindMIPosition = (MIPosition)this._BindNISimple.BindMMetaItem;
				this.RefreshtxtDesc();
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

		public PCPosition()
		{
			base.MouseDown += new MouseEventHandler(this.PCPosition_MouseDown);
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
			ResourceManager resourceManager = new ResourceManager(typeof(PCPosition));
			this.txtDesc = new TextBox();
			this.btnPos = new Button();
			this.SuspendLayout();
			this.txtDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_4B_0 = this.txtDesc;
			Point location = new Point(12, 10);
			arg_4B_0.Location = location;
			this.txtDesc.Name = "txtDesc";
			Control arg_75_0 = this.txtDesc;
			Size size = new Size(160, 21);
			arg_75_0.Size = size;
			this.txtDesc.TabIndex = 0;
			this.txtDesc.Text = "";
			this.btnPos.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnPos.Image = (Image)resourceManager.GetObject("btnPos.Image");
			Control arg_D2_0 = this.btnPos;
			location = new Point(180, 8);
			arg_D2_0.Location = location;
			this.btnPos.Name = "btnPos";
			Control arg_F9_0 = this.btnPos;
			size = new Size(24, 24);
			arg_F9_0.Size = size;
			this.btnPos.TabIndex = 1;
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.btnPos);
			this.Name = "PCPosition";
			size = new Size(216, 40);
			this.Size = size;
			this.ResumeLayout(false);
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this.txtDesc.BackColor = CheckMsg.ErrorColor;
			}
			else
			{
				this.txtDesc.BackColor = SystemColors.Window;
			}
		}

		public void Init()
		{
			this.miClear = new MenuItem("清空数据！");
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmTool = new ContextMenu();
			this.cmTool.MenuItems.Add(this.miClear);
		}

		public CheckMsg SpecialCheck()
		{
			return null;
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMIPosition.AllowNull && (this._BindNISimple.ValueCode == null | Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIPosition.Text + "】不允许为空",
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

		private void RefreshtxtDesc()
		{
			this.txtDesc.Text = this._BindNISimple.Value;
			if (this.txtDesc.BackColor.Equals(Color.Red))
			{
				this.CheckNull();
			}
			if (this.txtDesc.BackColor.Equals(Color.Yellow))
			{
				this.SpecialCheck();
			}
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
		}

		private void PCPosition_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu arg_28_0 = this.cmTool;
				Point pos = new Point(e.X, e.Y);
				arg_28_0.Show(this, pos);
			}
		}

		private void btnPos_Click(object sender, EventArgs e)
		{
			Point p = new Point(0, 0);
			Point point = this.PointToScreen(p);
			SelectPosForm selectPosForm = new SelectPosForm();
			selectPosForm.BindMIPosition = this._BindMIPosition;
			selectPosForm.BindNIPosition = this._BindNISimple;
			if (selectPosForm.ShowDialog() == DialogResult.OK)
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
						subRevision2.Content = selectPosForm.PosValue;
						revision.SubRevisions.Add(subRevision);
						revision.SubRevisions.Add(subRevision2);
						this._BindNISimple.RevisionHistory.Revisions.Add(revision);
						this._BindNISimple.RevisionHistory.CurrentRevision = revision;
					}
					else
					{
						Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
						SubRevision subRevision3 = (SubRevision)revision.SubRevisions[1];
						subRevision3.Content = selectPosForm.PosValue;
					}
				}
				this._BindNISimple.ValueCode = selectPosForm.PosValueCode;
				this._BindNISimple.Value = selectPosForm.PosValue;
				this.RefreshtxtDesc();
				PCPosition.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
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

		public void IsValueChanged(ref bool isChanged)
		{
		}

		public void SetInitValue()
		{
		}
	}
}
