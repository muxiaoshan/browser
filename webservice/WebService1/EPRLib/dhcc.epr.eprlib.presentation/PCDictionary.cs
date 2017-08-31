using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.dictionary;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
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
	public class PCDictionary : UserControl, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		[AccessedThroughProperty("btnDic")]
		private Button _btnDic;

		[AccessedThroughProperty("ContentPanel")]
		private Panel _ContentPanel;

		[AccessedThroughProperty("panel1")]
		private Panel _panel1;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("panel2")]
		private Panel _panel2;

		[AccessedThroughProperty("txtBox1")]
		private TextBox _txtBox1;

		[AccessedThroughProperty("txtBox2")]
		private TextBox _txtBox2;

		private NISimple _BindNISimple;

		private MIDictionary _BindMIDictionary;

		private string _Code;

		private MenuItem miClear;

		private ContextMenu cmTool;

		private TextBox TBValue;

		private TextBox TBValueCode;

		private bool IsRefresh;

		private bool boolUpdate;

		private Label curTip;

		private Label curLabel;

		private PCDictionary.VChangedEventHandler VChangedEvent;

		private string initValue;

		public event PCDictionary.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCDictionary.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCDictionary.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
			}
		}

		internal virtual Button btnDic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.btnDic_MouseDown);
				if (this._btnDic != null)
				{
					this._btnDic.MouseDown -= value2;
				}
				this._btnDic = value;
				if (this._btnDic != null)
				{
					this._btnDic.MouseDown += value2;
				}
			}
		}

		internal virtual Panel ContentPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContentPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContentPanel = value;
			}
		}

		internal virtual Panel panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._panel1 = value;
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

		internal virtual Panel panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._panel2 = value;
			}
		}

		internal virtual TextBox txtBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBox1 = value;
			}
		}

		internal virtual TextBox txtBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBox2 = value;
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
				this._BindMIDictionary = (MIDictionary)this._BindNISimple.BindMMetaItem;
				this.boolUpdate = true;
				if (this._BindMIDictionary.DisplayType == DisplayType.Code)
				{
					this.panel1.Width = 0;
					this.txtBox1.Visible = false;
					this.Splitter1.Width = 0;
					this.Splitter1.Enabled = false;
					this.panel2.Left = 0;
					this.panel2.Top = 0;
					this.TBValue = this.txtBox1;
					this.TBValueCode = this.txtBox2;
				}
				else if (this._BindMIDictionary.DisplayType == DisplayType.Desc)
				{
					this.panel1.Width = 0;
					this.txtBox1.Visible = false;
					this.Splitter1.Width = 0;
					this.Splitter1.Enabled = false;
					this.panel2.Left = 0;
					this.panel2.Top = 0;
					this.TBValue = this.txtBox2;
					this.TBValueCode = this.txtBox1;
				}
				else if (this._BindMIDictionary.DisplayType == DisplayType.CodeDesc)
				{
					if (this.panel1.Width == 0)
					{
						this.panel1.Width = 100;
						this.Splitter1.Width = 8;
					}
					this.TBValueCode = this.txtBox1;
					this.TBValue = this.txtBox2;
				}
				else if (this._BindMIDictionary.DisplayType == DisplayType.DescCode)
				{
					if (this.panel1.Width == 0)
					{
						this.panel1.Width = 100;
						this.Splitter1.Width = 8;
					}
					this.TBValueCode = this.txtBox2;
					this.TBValue = this.txtBox1;
				}
				this.RefreshtxtDesc();
				this.Refresh();
				this.boolUpdate = false;
				if (this._BindNISimple.RevisionHistory != null)
				{
					this.AddRevTip(this._BindNISimple.RevisionHistory);
				}
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ResourceManager resourceManager = new ResourceManager(typeof(PCDictionary));
			this.btnDic = new Button();
			this.ContentPanel = new Panel();
			this.panel2 = new Panel();
			this.txtBox2 = new TextBox();
			this.Splitter1 = new Splitter();
			this.panel1 = new Panel();
			this.txtBox1 = new TextBox();
			this.ContentPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			this.btnDic.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnDic.FlatStyle = FlatStyle.Flat;
			this.btnDic.ForeColor = Color.Transparent;
			this.btnDic.Image = (Image)resourceManager.GetObject("btnDic.Image");
			Control arg_DC_0 = this.btnDic;
			Point location = new Point(317, 3);
			arg_DC_0.Location = location;
			this.btnDic.Name = "btnDic";
			Control arg_103_0 = this.btnDic;
			Size size = new Size(24, 24);
			arg_103_0.Size = size;
			this.btnDic.TabIndex = 2;
			this.ContentPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ContentPanel.Controls.Add(this.panel2);
			this.ContentPanel.Controls.Add(this.Splitter1);
			this.ContentPanel.Controls.Add(this.panel1);
			Control arg_173_0 = this.ContentPanel;
			location = new Point(0, 0);
			arg_173_0.Location = location;
			this.ContentPanel.Name = "ContentPanel";
			Control arg_19D_0 = this.ContentPanel;
			size = new Size(320, 32);
			arg_19D_0.Size = size;
			this.ContentPanel.TabIndex = 1;
			this.panel2.Controls.Add(this.txtBox2);
			this.panel2.Dock = DockStyle.Fill;
			Control arg_1E1_0 = this.panel2;
			location = new Point(104, 0);
			arg_1E1_0.Location = location;
			this.panel2.Name = "panel2";
			Control arg_20B_0 = this.panel2;
			size = new Size(216, 32);
			arg_20B_0.Size = size;
			this.panel2.TabIndex = 2;
			this.txtBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_239_0 = this.txtBox2;
			location = new Point(0, 5);
			arg_239_0.Location = location;
			this.txtBox2.Name = "txtBox2";
			Control arg_263_0 = this.txtBox2;
			size = new Size(212, 21);
			arg_263_0.Size = size;
			this.txtBox2.TabIndex = 1;
			this.txtBox2.Text = "";
			Control arg_295_0 = this.Splitter1;
			location = new Point(100, 0);
			arg_295_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_2BB_0 = this.Splitter1;
			size = new Size(4, 32);
			arg_2BB_0.Size = size;
			this.Splitter1.TabIndex = 1;
			this.Splitter1.TabStop = false;
			this.panel1.Controls.Add(this.txtBox1);
			this.panel1.Dock = DockStyle.Left;
			Control arg_30A_0 = this.panel1;
			location = new Point(0, 0);
			arg_30A_0.Location = location;
			this.panel1.Name = "panel1";
			Control arg_331_0 = this.panel1;
			size = new Size(100, 32);
			arg_331_0.Size = size;
			this.panel1.TabIndex = 0;
			this.txtBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_35F_0 = this.txtBox1;
			location = new Point(0, 5);
			arg_35F_0.Location = location;
			this.txtBox1.Name = "txtBox1";
			Control arg_386_0 = this.txtBox1;
			size = new Size(99, 21);
			arg_386_0.Size = size;
			this.txtBox1.TabIndex = 0;
			this.txtBox1.Text = "";
			this.Controls.Add(this.ContentPanel);
			this.Controls.Add(this.btnDic);
			this.Name = "PCDictionary";
			size = new Size(344, 32);
			this.Size = size;
			this.ContentPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		public PCDictionary()
		{
			base.EnabledChanged += new EventHandler(this.PCDictionary_EnabledChanged);
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

		public void Init()
		{
			this.miClear = new MenuItem("清空数据！");
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmTool = new ContextMenu();
			this.cmTool.MenuItems.Add(this.miClear);
			this.txtBox1.KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
			this.txtBox2.KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
			this.txtBox1.TextChanged += new EventHandler(this.TextBox1_TextChanged);
			this.txtBox2.TextChanged += new EventHandler(this.TextBox2_TextChanged);
		}

		public void SetMsg(bool hasError)
		{
			if (hasError)
			{
				this.TBValueCode.BackColor = CheckMsg.ErrorColor;
				this.TBValue.BackColor = CheckMsg.ErrorColor;
			}
			else
			{
				this.TBValue.BackColor = SystemColors.Window;
				this.TBValueCode.BackColor = SystemColors.Window;
			}
		}

		public CheckMsg CheckNull()
		{
			if (this._BindMIDictionary.AllowNull && (((this.TBValueCode.Text == null | Operators.CompareString(this.TBValueCode.Text, "", false) == 0) & this._BindMIDictionary.DisplayType != DisplayType.Desc) | ((this.TBValue.Text == null | Operators.CompareString(this.TBValue.Text, "", false) == 0) & this._BindMIDictionary.DisplayType != DisplayType.Code)))
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Null,
					ErrorDesc = "【" + this._BindMIDictionary.Text + "】不允许为空",
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
			if (this.txtBox1.BackColor.Equals(Color.Red))
			{
				this.txtBox1.BackColor = Color.White;
			}
			if (this.txtBox2.BackColor.Equals(Color.Red))
			{
				this.txtBox2.BackColor = Color.White;
			}
			string text = this.SpecialCheckTBValue() + this.SpecialCheckTBValueCode() + this.SpecialCheckTBValueAndCode();
			if (Operators.CompareString(text, "", false) != 0)
			{
				return new CheckMsg
				{
					CheckType = ECheckType.Special,
					ErrorDesc = text,
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

		public string SpecialCheckTBValueAndCode()
		{
			string text = "";
			if (this._BindMIDictionary.AllowValueNull & !this._BindMIDictionary.AllowCodeNull)
			{
				if (Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0 & Operators.CompareString(this._BindNISimple.Value, "", false) != 0)
				{
					text = text + "【" + this._BindMIDictionary.Text + "】在代码未选择之前不允许录入描述，请通过字典选择，选择后可修改描述，当前不保存对描述进行的修改。";
					this._BindNISimple.Value = "";
				}
			}
			else if ((!this._BindMIDictionary.AllowValueNull & this._BindMIDictionary.AllowCodeNull) && (Operators.CompareString(this._BindNISimple.Value, "", false) == 0 & Operators.CompareString(this._BindNISimple.ValueCode, "", false) != 0))
			{
				text = text + "【" + this._BindMIDictionary.Text + "】在描述未选择之前不允许录入代码，请通过字典选择，选择后可修改代码，当前不保存对代码进行的修改。";
				this._BindNISimple.ValueCode = "";
			}
			return text;
		}

		public string SpecialCheckTBValueCode()
		{
			string text = "";
			if (!this._BindMIDictionary.AllowCodeNull & Operators.CompareString(this._BindNISimple.ValueCode, this.TBValueCode.Text, false) != 0)
			{
				text = text + "【" + this._BindMIDictionary.Text + "】的代码不允许直接录入，请通过字典选择，当前不保存对代码进行的修改。";
			}
			else
			{
				this._BindNISimple.ValueCode = this.TBValueCode.Text;
				if ((this._BindNISimple.ValueCode == null | Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0) && (this._BindMIDictionary.AllowNull & this._BindMIDictionary.DisplayType != DisplayType.Desc))
				{
					text = text + "【" + this._BindMIDictionary.Text + "】字典单元的代码不允许为空，请选择。";
				}
			}
			return text;
		}

		public string SpecialCheckTBValue()
		{
			string text = "";
			if (!this._BindMIDictionary.AllowValueNull & Operators.CompareString(this._BindNISimple.Value, this.TBValue.Text, false) != 0)
			{
				text = text + "【" + this._BindMIDictionary.Text + "的描述不允许直接录入，请通过字典选择，当前不保存对描述进行的修改。";
			}
			else
			{
				this._BindNISimple.Value = this.TBValue.Text;
				if ((this._BindNISimple.Value == null | Operators.CompareString(this._BindNISimple.Value, "", false) == 0) && (this._BindMIDictionary.AllowNull & this._BindMIDictionary.DisplayType != DisplayType.Code))
				{
					text = text + "【" + this._BindMIDictionary.Text + "】字典单元的描述不允许为空，请选择。";
				}
			}
			return text;
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
				this.panel1.Width = checked((int)Math.Round((double)float.Parse(reader.Value)));
				reader.Read();
				if (this.panel1.Width == 0)
				{
					this.Splitter1.Width = 0;
					this.panel2.Left = 0;
					this.panel2.Top = 0;
				}
			}
		}

		public void OnClear(object sender, EventArgs e)
		{
			if (this._BindNISimple != null)
			{
				this._BindNISimple.Value = "";
				this._BindNISimple.ValueCode = "";
				this.txtBox1.ReadOnly = false;
				this.txtBox2.ReadOnly = false;
				this.RefreshtxtDesc();
			}
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.txtBox1.BackColor.Equals(Color.Red))
			{
				this.txtBox1.BackColor = Color.White;
			}
			TextBox textBox = (TextBox)sender;
			switch (this._BindMIDictionary.DisplayType)
			{
			case DisplayType.Desc:
				if (this._BindMIDictionary.AllowCodeNull & !(!this._BindMIDictionary.AllowValueNull & Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
				{
					this.SetRevContent(this._BindNISimple.Value, textBox.Text);
					this._BindNISimple.ValueCode = textBox.Text;
				}
				break;
			case DisplayType.Code:
				if (this._BindMIDictionary.AllowValueNull & !(!this._BindMIDictionary.AllowCodeNull & Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
				{
					this.SetRevContent(this._BindNISimple.ValueCode, textBox.Text);
					this._BindNISimple.Value = textBox.Text;
				}
				break;
			case DisplayType.CodeDesc:
				if (this._BindMIDictionary.AllowCodeNull & !(!this._BindMIDictionary.AllowValueNull & Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
				{
					string orginalContent = this._BindNISimple.Code + this._BindMIDictionary.Seporator + this._BindNISimple.ValueCode;
					string newContent = this.txtBox1.Text + this._BindMIDictionary.Seporator + this.txtBox2.Text;
					this.SetRevContent(orginalContent, newContent);
					this._BindNISimple.ValueCode = textBox.Text;
				}
				break;
			case DisplayType.DescCode:
				if (this._BindMIDictionary.AllowValueNull & !(!this._BindMIDictionary.AllowCodeNull & Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
				{
					string orginalContent2 = this._BindNISimple.ValueCode + this._BindMIDictionary.Seporator + this._BindNISimple.Code;
					string newContent2 = this.txtBox1.Text + this._BindMIDictionary.Seporator + this.txtBox2.Text;
					this.SetRevContent(orginalContent2, newContent2);
					this._BindNISimple.Value = textBox.Text;
				}
				break;
			}
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			if (this.txtBox2.BackColor.Equals(Color.Red))
			{
				this.txtBox2.BackColor = Color.White;
			}
			TextBox textBox = (TextBox)sender;
			switch (this._BindMIDictionary.DisplayType)
			{
			case DisplayType.Desc:
				if (this._BindMIDictionary.AllowValueNull & !(!this._BindMIDictionary.AllowCodeNull & Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
				{
					this.SetRevContent(this._BindNISimple.Value, textBox.Text);
					this._BindNISimple.Value = textBox.Text;
				}
				break;
			case DisplayType.Code:
				if (this._BindMIDictionary.AllowCodeNull & !(!this._BindMIDictionary.AllowValueNull & Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
				{
					this.SetRevContent(this._BindNISimple.ValueCode, textBox.Text);
					this._BindNISimple.ValueCode = textBox.Text;
				}
				break;
			case DisplayType.CodeDesc:
				if (this._BindMIDictionary.AllowValueNull & !(!this._BindMIDictionary.AllowCodeNull & Operators.CompareString(this._BindNISimple.ValueCode, "", false) == 0))
				{
					string orginalContent = this._BindNISimple.Code + this._BindMIDictionary.Seporator + this._BindNISimple.ValueCode;
					string newContent = this.txtBox1.Text + this._BindMIDictionary.Seporator + this.txtBox2.Text;
					this.SetRevContent(orginalContent, newContent);
					this._BindNISimple.Value = textBox.Text;
				}
				break;
			case DisplayType.DescCode:
				if (this._BindMIDictionary.AllowCodeNull & !(!this._BindMIDictionary.AllowValueNull & Operators.CompareString(this._BindNISimple.Value, "", false) == 0))
				{
					string orginalContent2 = this._BindNISimple.ValueCode + this._BindMIDictionary.Seporator + this._BindNISimple.Code;
					string newContent2 = this.txtBox1.Text + this._BindMIDictionary.Seporator + this.txtBox2.Text;
					this.SetRevContent(orginalContent2, newContent2);
					this._BindNISimple.ValueCode = textBox.Text;
				}
				break;
			}
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return & Operators.CompareString(this._BindMIDictionary.DictionaryType, "STDDIC", false) == 0)
			{
				this.ShowDicForm();
				TextBox textBox = (TextBox)sender;
				textBox.Focus();
			}
			else
			{
				e.Handled = false;
			}
		}

		private void PCDictionary_EnabledChanged(object sender, EventArgs e)
		{
			if (!this.Enabled)
			{
				this.txtBox1.BackColor = Color.White;
				this.txtBox2.BackColor = Color.White;
			}
		}

		private void btnDic_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu arg_2D_0 = this.cmTool;
				Control arg_2D_1 = this.btnDic;
				Point pos = new Point(e.X, e.Y);
				arg_2D_0.Show(arg_2D_1, pos);
				return;
			}
			this.ShowDicForm();
			this.btnDic.Focus();
		}

		private void ShowDicForm()
		{
			Point p = new Point(0, 0);
			Point screenPoint = this.PointToScreen(p);
			string queryInputCondition = this.GetQueryInputCondition();
			string strCondition = string.Empty;
			DicContent dicContent;
			if (Operators.CompareString(this._BindMIDictionary.DictionaryType, "STDDIC", false) == 0)
			{
				strCondition = this.GetQueryPredefinedCondition(this._BindMIDictionary.StdDicCode);
				IDictionary dic = DicFactory.Instance.getDic("StdDictionary");
				dicContent = dic.GetDicContent(this._BindMIDictionary, screenPoint, this._BindNISimple, queryInputCondition, strCondition);
			}
			else
			{
				IDictionary dic = DicFactory.Instance.getDic(this._BindMIDictionary.CustDicClassName);
				dicContent = dic.GetDicContent(this._BindMIDictionary, screenPoint, this._BindNISimple, queryInputCondition, strCondition);
			}
			if (dicContent != null)
			{
				string orginalContent = "";
				string newContent = "";
				switch (this._BindMIDictionary.DisplayType)
				{
				case DisplayType.Desc:
					orginalContent = this._BindNISimple.Value;
					newContent = dicContent.Description;
					break;
				case DisplayType.Code:
					orginalContent = this._BindNISimple.Code;
					newContent = dicContent.Code;
					break;
				case DisplayType.CodeDesc:
					orginalContent = this._BindNISimple.Code + this._BindMIDictionary.Seporator + this._BindNISimple.ValueCode;
					newContent = dicContent.Code + this._BindMIDictionary.Seporator + dicContent.Description;
					break;
				case DisplayType.DescCode:
					orginalContent = this._BindNISimple.ValueCode + this._BindMIDictionary.Seporator + this._BindNISimple.Code;
					newContent = dicContent.Description + this._BindMIDictionary.Seporator + dicContent.Code;
					break;
				}
				this.SetRevContent(orginalContent, newContent);
				this._BindNISimple.ValueCode = dicContent.Code;
				this._BindNISimple.Value = dicContent.Description;
				this.RefreshtxtDesc();
			}
		}

		private void RefreshtxtDesc()
		{
			this.IsRefresh = true;
			this.TBValueCode.Text = this._BindNISimple.ValueCode;
			this.TBValue.Text = this._BindNISimple.Value;
			this.IsRefresh = false;
			if (this.txtBox1.BackColor.Equals(Color.Red) | this.txtBox2.BackColor.Equals(Color.Red))
			{
				this.CheckNull();
			}
			if (this.txtBox1.BackColor.Equals(Color.Yellow) | this.txtBox2.BackColor.Equals(Color.Yellow))
			{
				this.SpecialCheck();
			}
			if (!this.boolUpdate)
			{
				PCDictionary.VChangedEventHandler vChangedEvent = this.VChangedEvent;
				if (vChangedEvent != null)
				{
					vChangedEvent(this.Code);
				}
			}
		}

		private void SetRevContent(string orginalContent, string newContent)
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
					subRevision.Content = orginalContent;
					SubRevision subRevision2 = new SubRevision();
					subRevision2.RevType = "R";
					subRevision2.Content = newContent;
					revision.SubRevisions.Add(subRevision);
					revision.SubRevisions.Add(subRevision2);
					this._BindNISimple.RevisionHistory.Revisions.Add(revision);
					this._BindNISimple.RevisionHistory.CurrentRevision = revision;
				}
				else
				{
					Revision revision = this._BindNISimple.RevisionHistory.CurrentRevision;
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
			return this.TBValue.Text + "-" + this.TBValueCode.Text;
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

		private string GetQueryInputCondition()
		{
			string text = Strings.Trim(this.TBValue.Text);
			string text2 = Strings.Trim(this.TBValueCode.Text);
			switch (this._BindMIDictionary.DisplayType)
			{
			case (DisplayType)(-1):
				return Conversions.ToString(Interaction.IIf(Operators.CompareString(text2, string.Empty, false) != 0, text2, text));
			default:
				return Conversions.ToString(Interaction.IIf(Operators.CompareString(text, string.Empty, false) != 0, text, text2));
			}
		}

		private string GetQueryPredefinedCondition(string stdDicCode)
		{
			string empty = string.Empty;
			string text = WebServiceLayer.DictionaryAccess.SelectConditionByStdCode(stdDicCode);
			if (string.IsNullOrEmpty(text))
			{
				return empty;
			}
			if (text.Split(new char[]
			{
				'^'
			}).Length != 2)
			{
				return empty;
			}
			string str = text.Split(new char[]
			{
				'^'
			})[0].ToString();
			string text2 = text.Split(new char[]
			{
				'^'
			})[1].ToString();
			string text3 = string.Empty;
			string[] array = text2.Split(new char[]
			{
				','
			});
			int arg_A8_0 = 0;
			checked
			{
				int num = array.Length - 1;
				for (int i = arg_A8_0; i <= num; i++)
				{
					if (i > 0)
					{
						text3 += ",";
					}
					string realValue = this.GetRealValue(array[i]);
					text3 += realValue;
				}
				return str + "^" + text3;
			}
		}

		private string GetRealValue(string stdCondValue)
		{
			int length = stdCondValue.Length;
			checked
			{
				if (stdCondValue.StartsWith("{") && length > 2)
				{
					string key = stdCondValue.Substring(1, stdCondValue.Length - 2);
					string valueByKey = GlobalValues.GetValueByKey(key);
					return Conversions.ToString(Interaction.IIf(valueByKey == null, string.Empty, valueByKey));
				}
				if (stdCondValue.StartsWith("[") && length > 2)
				{
					string item = stdCondValue.Substring(1, stdCondValue.Length - 2);
					return this.GetItemValue(item);
				}
				return stdCondValue;
			}
		}

		private string GetItemValue(string item)
		{
			string text = string.Empty;
			string associateItem = ((MIDictionary)this.BindInstanceItem.BindMMetaItem).AssociateItem;
			if (string.IsNullOrEmpty(associateItem))
			{
				return text;
			}
			string text2 = string.Empty;
			if (Operators.CompareString(item.ToUpper(), "ITEM1", false) == 0)
			{
				text2 = associateItem.Split(new char[]
				{
					','
				})[0];
			}
			else if (Operators.CompareString(item.ToUpper(), "ITEM2", false) == 0 && associateItem.Split(new char[]
			{
				','
			}).Length >= 2)
			{
				text2 = associateItem.Split(new char[]
				{
					','
				})[1];
			}
			if (string.IsNullOrEmpty(text2))
			{
				return text;
			}
			string[] array = text2.Split(new char[]
			{
				'$'
			});
			string code;
			string strVType;
			if (array.Length == 2)
			{
				code = array[0];
				strVType = array[1];
			}
			else
			{
				code = array[0];
				strVType = "V";
			}
			if (this.BindInstanceItem.Parent is NInstanceData)
			{
				NInstanceItem nInstanceItem = ((NInstanceData)this.BindInstanceItem.Parent).FindInstanceItemByCode(code);
				if (nInstanceItem != null)
				{
					text = nInstanceItem.GetByVType(strVType);
				}
			}
			return Conversions.ToString(Interaction.IIf(text == null, string.Empty, text));
		}
	}
}
