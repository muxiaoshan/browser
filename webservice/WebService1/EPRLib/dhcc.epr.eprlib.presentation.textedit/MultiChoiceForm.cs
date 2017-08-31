using CustomDictoryData;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class MultiChoiceForm : dhcc.epr.eprlib.presentation.MovableForm
	{
		public delegate void SetContrlEventHandler(string strContent, string strPesition);

		private IContainer components;

		[AccessedThroughProperty("lbxChoices")]
		private CheckedListBox _lbxChoices;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("operateAll")]
		private Button _operateAll;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("llSelAll")]
		private LinkLabel _llSelAll;

		[AccessedThroughProperty("llOK")]
		private LinkLabel _llOK;

		[AccessedThroughProperty("pCheck")]
		private Panel _pCheck;

		[AccessedThroughProperty("chkDeciduous")]
		private CheckBox _chkDeciduous;

		[AccessedThroughProperty("gbPT")]
		private GroupBox _gbPT;

		[AccessedThroughProperty("btXA4")]
		private Button _btXA4;

		[AccessedThroughProperty("btXA1")]
		private Button _btXA1;

		[AccessedThroughProperty("btXA2")]
		private Button _btXA2;

		[AccessedThroughProperty("btXA8")]
		private Button _btXA8;

		[AccessedThroughProperty("btXA7")]
		private Button _btXA7;

		[AccessedThroughProperty("btXA6")]
		private Button _btXA6;

		[AccessedThroughProperty("btXA5")]
		private Button _btXA5;

		[AccessedThroughProperty("btXA3")]
		private Button _btXA3;

		[AccessedThroughProperty("btXB3")]
		private Button _btXB3;

		[AccessedThroughProperty("btXB2")]
		private Button _btXB2;

		[AccessedThroughProperty("btXB1")]
		private Button _btXB1;

		[AccessedThroughProperty("btXB8")]
		private Button _btXB8;

		[AccessedThroughProperty("btXB7")]
		private Button _btXB7;

		[AccessedThroughProperty("btXB6")]
		private Button _btXB6;

		[AccessedThroughProperty("btXB5")]
		private Button _btXB5;

		[AccessedThroughProperty("btXB4")]
		private Button _btXB4;

		[AccessedThroughProperty("btXC3")]
		private Button _btXC3;

		[AccessedThroughProperty("btXC1")]
		private Button _btXC1;

		[AccessedThroughProperty("btXC4")]
		private Button _btXC4;

		[AccessedThroughProperty("btXC2")]
		private Button _btXC2;

		[AccessedThroughProperty("btXC5")]
		private Button _btXC5;

		[AccessedThroughProperty("btXC8")]
		private Button _btXC8;

		[AccessedThroughProperty("btXC6")]
		private Button _btXC6;

		[AccessedThroughProperty("btXC7")]
		private Button _btXC7;

		[AccessedThroughProperty("btXD2")]
		private Button _btXD2;

		[AccessedThroughProperty("btXD4")]
		private Button _btXD4;

		[AccessedThroughProperty("btXD3")]
		private Button _btXD3;

		[AccessedThroughProperty("btXD5")]
		private Button _btXD5;

		[AccessedThroughProperty("btXD1")]
		private Button _btXD1;

		[AccessedThroughProperty("btXD6")]
		private Button _btXD6;

		[AccessedThroughProperty("btXD8")]
		private Button _btXD8;

		[AccessedThroughProperty("btXD7")]
		private Button _btXD7;

		[AccessedThroughProperty("PaHeight")]
		private Panel _PaHeight;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("btYC4")]
		private Button _btYC4;

		[AccessedThroughProperty("btYC1")]
		private Button _btYC1;

		[AccessedThroughProperty("btYC2")]
		private Button _btYC2;

		[AccessedThroughProperty("btYC5")]
		private Button _btYC5;

		[AccessedThroughProperty("btYC3")]
		private Button _btYC3;

		[AccessedThroughProperty("btYA4")]
		private Button _btYA4;

		[AccessedThroughProperty("btYA1")]
		private Button _btYA1;

		[AccessedThroughProperty("btYA2")]
		private Button _btYA2;

		[AccessedThroughProperty("btYA5")]
		private Button _btYA5;

		[AccessedThroughProperty("btYA3")]
		private Button _btYA3;

		[AccessedThroughProperty("btYD2")]
		private Button _btYD2;

		[AccessedThroughProperty("btYD3")]
		private Button _btYD3;

		[AccessedThroughProperty("btYD5")]
		private Button _btYD5;

		[AccessedThroughProperty("btYD4")]
		private Button _btYD4;

		[AccessedThroughProperty("btYD1")]
		private Button _btYD1;

		[AccessedThroughProperty("btYB2")]
		private Button _btYB2;

		[AccessedThroughProperty("btYB3")]
		private Button _btYB3;

		[AccessedThroughProperty("btYB5")]
		private Button _btYB5;

		[AccessedThroughProperty("btYB4")]
		private Button _btYB4;

		[AccessedThroughProperty("btYB1")]
		private Button _btYB1;

		[AccessedThroughProperty("pYB")]
		private Panel _pYB;

		[AccessedThroughProperty("pYA")]
		private Panel _pYA;

		[AccessedThroughProperty("pXC")]
		private Panel _pXC;

		[AccessedThroughProperty("pXA")]
		private Panel _pXA;

		[AccessedThroughProperty("pYC")]
		private Panel _pYC;

		[AccessedThroughProperty("pXB")]
		private Panel _pXB;

		[AccessedThroughProperty("pYD")]
		private Panel _pYD;

		[AccessedThroughProperty("pXD")]
		private Panel _pXD;

		[AccessedThroughProperty("llCancel")]
		private LinkLabel _llCancel;

		private MIMultiChoice curMIMultiChoice;

		private string curValueCode;

		private bool BoolMouseDown;

		private Point ClickedPoint;

		private ETeethPestion dsTeethPestion;

		private MultiChoiceForm.SetContrlEventHandler OnButtionClickEvent;

		private const string TP1 = "A";

		private const string TP2 = "B";

		private const string TP3 = "C";

		private const string TP4 = "D";

		private const int WM_KEYDOWN = 256;

		private const int WM_SYSKEYDOWN = 260;

		public event MultiChoiceForm.SetContrlEventHandler OnButtionClick
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnButtionClickEvent = (MultiChoiceForm.SetContrlEventHandler)Delegate.Combine(this.OnButtionClickEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnButtionClickEvent = (MultiChoiceForm.SetContrlEventHandler)Delegate.Remove(this.OnButtionClickEvent, value);
			}
		}

		internal virtual CheckedListBox lbxChoices
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbxChoices;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbxChoices = value;
			}
		}

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= value2;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += value2;
				}
			}
		}

		internal virtual Button operateAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._operateAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.operateAll_Click);
				if (this._operateAll != null)
				{
					this._operateAll.Click -= value2;
				}
				this._operateAll = value;
				if (this._operateAll != null)
				{
					this._operateAll.Click += value2;
				}
			}
		}

		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual LinkLabel llSelAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llSelAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llSelAll_LinkClicked);
				if (this._llSelAll != null)
				{
					this._llSelAll.LinkClicked -= value2;
				}
				this._llSelAll = value;
				if (this._llSelAll != null)
				{
					this._llSelAll.LinkClicked += value2;
				}
			}
		}

		internal virtual LinkLabel llOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llOK_LinkClicked);
				if (this._llOK != null)
				{
					this._llOK.LinkClicked -= value2;
				}
				this._llOK = value;
				if (this._llOK != null)
				{
					this._llOK.LinkClicked += value2;
				}
			}
		}

		internal virtual Panel pCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pCheck = value;
			}
		}

		internal virtual CheckBox chkDeciduous
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkDeciduous;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkDeciduous_CheckedChanged);
				if (this._chkDeciduous != null)
				{
					this._chkDeciduous.CheckedChanged -= value2;
				}
				this._chkDeciduous = value;
				if (this._chkDeciduous != null)
				{
					this._chkDeciduous.CheckedChanged += value2;
				}
			}
		}

		internal virtual GroupBox gbPT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbPT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbPT = value;
			}
		}

		internal virtual Button btXA4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA4 = value;
			}
		}

		internal virtual Button btXA1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA1 = value;
			}
		}

		internal virtual Button btXA2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA2 = value;
			}
		}

		internal virtual Button btXA8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA8 = value;
			}
		}

		internal virtual Button btXA7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA7 = value;
			}
		}

		internal virtual Button btXA6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA6 = value;
			}
		}

		internal virtual Button btXA5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA5 = value;
			}
		}

		internal virtual Button btXA3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXA3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXA3 = value;
			}
		}

		internal virtual Button btXB3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB3 = value;
			}
		}

		internal virtual Button btXB2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB2 = value;
			}
		}

		internal virtual Button btXB1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB1 = value;
			}
		}

		internal virtual Button btXB8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB8 = value;
			}
		}

		internal virtual Button btXB7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB7 = value;
			}
		}

		internal virtual Button btXB6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB6 = value;
			}
		}

		internal virtual Button btXB5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB5 = value;
			}
		}

		internal virtual Button btXB4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXB4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXB4 = value;
			}
		}

		internal virtual Button btXC3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC3 = value;
			}
		}

		internal virtual Button btXC1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC1 = value;
			}
		}

		internal virtual Button btXC4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC4 = value;
			}
		}

		internal virtual Button btXC2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC2 = value;
			}
		}

		internal virtual Button btXC5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC5 = value;
			}
		}

		internal virtual Button btXC8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC8 = value;
			}
		}

		internal virtual Button btXC6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC6 = value;
			}
		}

		internal virtual Button btXC7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXC7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXC7 = value;
			}
		}

		internal virtual Button btXD2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD2 = value;
			}
		}

		internal virtual Button btXD4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD4 = value;
			}
		}

		internal virtual Button btXD3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD3 = value;
			}
		}

		internal virtual Button btXD5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD5 = value;
			}
		}

		internal virtual Button btXD1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD1 = value;
			}
		}

		internal virtual Button btXD6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD6 = value;
			}
		}

		internal virtual Button btXD8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD8 = value;
			}
		}

		internal virtual Button btXD7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btXD7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btXD7 = value;
			}
		}

		internal virtual Panel PaHeight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PaHeight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PaHeight = value;
			}
		}

		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		internal virtual Button btYC4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYC4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYC4 = value;
			}
		}

		internal virtual Button btYC1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYC1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYC1 = value;
			}
		}

		internal virtual Button btYC2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYC2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYC2 = value;
			}
		}

		internal virtual Button btYC5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYC5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYC5 = value;
			}
		}

		internal virtual Button btYC3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYC3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYC3 = value;
			}
		}

		internal virtual Button btYA4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYA4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYA4 = value;
			}
		}

		internal virtual Button btYA1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYA1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYA1 = value;
			}
		}

		internal virtual Button btYA2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYA2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYA2 = value;
			}
		}

		internal virtual Button btYA5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYA5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYA5 = value;
			}
		}

		internal virtual Button btYA3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYA3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYA3 = value;
			}
		}

		internal virtual Button btYD2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYD2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYD2 = value;
			}
		}

		internal virtual Button btYD3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYD3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYD3 = value;
			}
		}

		internal virtual Button btYD5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYD5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYD5 = value;
			}
		}

		internal virtual Button btYD4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYD4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYD4 = value;
			}
		}

		internal virtual Button btYD1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYD1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYD1 = value;
			}
		}

		internal virtual Button btYB2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYB2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYB2 = value;
			}
		}

		internal virtual Button btYB3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYB3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYB3 = value;
			}
		}

		internal virtual Button btYB5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYB5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYB5 = value;
			}
		}

		internal virtual Button btYB4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYB4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYB4 = value;
			}
		}

		internal virtual Button btYB1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btYB1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btYB1 = value;
			}
		}

		internal virtual Panel pYB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pYB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pYB = value;
			}
		}

		internal virtual Panel pYA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pYA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pYA = value;
			}
		}

		internal virtual Panel pXC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pXC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pXC = value;
			}
		}

		internal virtual Panel pXA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pXA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pXA = value;
			}
		}

		internal virtual Panel pYC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pYC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pYC = value;
			}
		}

		internal virtual Panel pXB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pXB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pXB = value;
			}
		}

		internal virtual Panel pYD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pYD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pYD = value;
			}
		}

		internal virtual Panel pXD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pXD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pXD = value;
			}
		}

		internal virtual LinkLabel llCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._llCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.llCancel_LinkClicked);
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked -= value2;
				}
				this._llCancel = value;
				if (this._llCancel != null)
				{
					this._llCancel.LinkClicked += value2;
				}
			}
		}

		public string CheckStatus
		{
			get
			{
				string text = "";
				int arg_1A_0 = 0;
				checked
				{
					int num = this.lbxChoices.Items.Count - 1;
					for (int i = arg_1A_0; i <= num; i++)
					{
						if (this.lbxChoices.GetItemChecked(i))
						{
							text += "1";
						}
						else
						{
							text += "0";
						}
					}
					return text;
				}
			}
			set
			{
				checked
				{
					if (Operators.CompareString(value, "", false) != 0)
					{
						int arg_19_0 = 0;
						int num = value.Length - 1;
						for (int i = arg_19_0; i <= num; i++)
						{
							if (Operators.CompareString(value.Substring(i, 1), "1", false) == 0 && i < this.lbxChoices.Items.Count)
							{
								this.lbxChoices.SetItemChecked(i, true);
							}
						}
					}
				}
			}
		}

		public string CheckString
		{
			get
			{
				string text = "";
				int arg_1A_0 = 0;
				checked
				{
					int num = this.lbxChoices.Items.Count - 1;
					for (int i = arg_1A_0; i <= num; i++)
					{
						if (this.lbxChoices.GetItemChecked(i))
						{
							text = text + this.curMIMultiChoice.Choices[i] + this.curMIMultiChoice.Seperator;
						}
					}
					if (text.Length > 0)
					{
						text = text.Substring(0, text.Length - this.curMIMultiChoice.Seperator.Length);
					}
					return text;
				}
			}
		}

		public MultiChoiceForm()
		{
			base.Paint += new PaintEventHandler(this.ChoiceForm_Paint);
			base.Load += new EventHandler(this.MultiChoiceForm_Load);
			this.BoolMouseDown = false;
			this.dsTeethPestion = new ETeethPestion();
			this.InitializeComponent();
			this.AddMovableHandler(this.Panel1);
			this.initEvent();
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
			this.lbxChoices = new CheckedListBox();
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.operateAll = new Button();
			this.Panel1 = new Panel();
			this.pCheck = new Panel();
			this.gbPT = new GroupBox();
			this.PaHeight = new Panel();
			this.Panel2 = new Panel();
			this.chkDeciduous = new CheckBox();
			this.llCancel = new LinkLabel();
			this.llSelAll = new LinkLabel();
			this.llOK = new LinkLabel();
			this.btXD6 = new Button();
			this.btXD7 = new Button();
			this.btXD8 = new Button();
			this.btXD2 = new Button();
			this.btXD3 = new Button();
			this.btXD5 = new Button();
			this.btXD4 = new Button();
			this.btXD1 = new Button();
			this.btXB6 = new Button();
			this.btXB5 = new Button();
			this.btXB4 = new Button();
			this.btXB3 = new Button();
			this.btXB2 = new Button();
			this.btXB1 = new Button();
			this.btXA4 = new Button();
			this.btXA1 = new Button();
			this.btXA2 = new Button();
			this.btXA8 = new Button();
			this.btXA7 = new Button();
			this.btXA6 = new Button();
			this.btXA5 = new Button();
			this.btXA3 = new Button();
			this.btXB8 = new Button();
			this.btXB7 = new Button();
			this.btXC3 = new Button();
			this.btXC1 = new Button();
			this.btXC4 = new Button();
			this.btXC2 = new Button();
			this.btXC5 = new Button();
			this.btXC8 = new Button();
			this.btXC6 = new Button();
			this.btXC7 = new Button();
			this.btYA4 = new Button();
			this.btYA1 = new Button();
			this.btYA2 = new Button();
			this.btYA5 = new Button();
			this.btYA3 = new Button();
			this.btYC4 = new Button();
			this.btYC1 = new Button();
			this.btYC2 = new Button();
			this.btYC5 = new Button();
			this.btYC3 = new Button();
			this.btYD2 = new Button();
			this.btYD3 = new Button();
			this.btYD5 = new Button();
			this.btYD4 = new Button();
			this.btYD1 = new Button();
			this.btYB2 = new Button();
			this.btYB3 = new Button();
			this.btYB5 = new Button();
			this.btYB4 = new Button();
			this.btYB1 = new Button();
			this.pYA = new Panel();
			this.pYB = new Panel();
			this.pXA = new Panel();
			this.pXC = new Panel();
			this.pYC = new Panel();
			this.pXB = new Panel();
			this.pXD = new Panel();
			this.pYD = new Panel();
			this.Panel1.SuspendLayout();
			this.pCheck.SuspendLayout();
			this.gbPT.SuspendLayout();
			this.pYA.SuspendLayout();
			this.pYB.SuspendLayout();
			this.pXA.SuspendLayout();
			this.pXC.SuspendLayout();
			this.pYC.SuspendLayout();
			this.pXB.SuspendLayout();
			this.pXD.SuspendLayout();
			this.pYD.SuspendLayout();
			this.SuspendLayout();
			this.lbxChoices.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.lbxChoices.BackColor = Color.FromArgb(239, 239, 239);
			this.lbxChoices.BorderStyle = BorderStyle.None;
			this.lbxChoices.CheckOnClick = true;
			this.lbxChoices.HorizontalScrollbar = true;
			Control arg_401_0 = this.lbxChoices;
			Point location = new Point(3, 3);
			arg_401_0.Location = location;
			this.lbxChoices.Name = "lbxChoices";
			Control arg_427_0 = this.lbxChoices;
			Size size = new Size(110, 0);
			arg_427_0.Size = size;
			this.lbxChoices.TabIndex = 4;
			this.btnCancel.BackColor = Color.FromArgb(49, 101, 156);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			Control arg_491_0 = this.btnCancel;
			location = new Point(164, 183);
			arg_491_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_4B8_0 = this.btnCancel;
			size = new Size(64, 24);
			arg_4B8_0.Size = size;
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Visible = false;
			this.btnOK.BackColor = Color.FromArgb(49, 101, 156);
			this.btnOK.FlatStyle = FlatStyle.Flat;
			this.btnOK.ForeColor = Color.White;
			Control arg_53B_0 = this.btnOK;
			location = new Point(99, 183);
			arg_53B_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_562_0 = this.btnOK;
			size = new Size(64, 24);
			arg_562_0.Size = size;
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Visible = false;
			this.operateAll.BackColor = Color.FromArgb(239, 239, 239);
			this.operateAll.FlatStyle = FlatStyle.Flat;
			this.operateAll.ForeColor = Color.Black;
			Control arg_5EB_0 = this.operateAll;
			location = new Point(9, 189);
			arg_5EB_0.Location = location;
			this.operateAll.Name = "operateAll";
			Control arg_612_0 = this.operateAll;
			size = new Size(90, 24);
			arg_612_0.Size = size;
			this.operateAll.TabIndex = 7;
			this.operateAll.Text = "全选/全消(&S)";
			this.operateAll.UseVisualStyleBackColor = false;
			this.operateAll.Visible = false;
			this.Panel1.BackColor = Color.FromArgb(239, 239, 239);
			this.Panel1.Controls.Add(this.pCheck);
			this.Panel1.Controls.Add(this.llCancel);
			this.Panel1.Controls.Add(this.llSelAll);
			this.Panel1.Controls.Add(this.llOK);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_6DE_0 = this.Panel1;
			location = new Point(0, 0);
			arg_6DE_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_70B_0 = this.Panel1;
			size = new Size(434, 209);
			arg_70B_0.Size = size;
			this.Panel1.TabIndex = 8;
			this.pCheck.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.pCheck.Controls.Add(this.operateAll);
			this.pCheck.Controls.Add(this.btnCancel);
			this.pCheck.Controls.Add(this.gbPT);
			this.pCheck.Controls.Add(this.chkDeciduous);
			this.pCheck.Controls.Add(this.btnOK);
			this.pCheck.Controls.Add(this.lbxChoices);
			Control arg_7BD_0 = this.pCheck;
			location = new Point(0, 1);
			arg_7BD_0.Location = location;
			this.pCheck.Name = "pCheck";
			Control arg_7EA_0 = this.pCheck;
			size = new Size(434, 166);
			arg_7EA_0.Size = size;
			this.pCheck.TabIndex = 8;
			this.gbPT.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.gbPT.Controls.Add(this.pYD);
			this.gbPT.Controls.Add(this.pXD);
			this.gbPT.Controls.Add(this.pXB);
			this.gbPT.Controls.Add(this.pYC);
			this.gbPT.Controls.Add(this.pXC);
			this.gbPT.Controls.Add(this.pXA);
			this.gbPT.Controls.Add(this.pYB);
			this.gbPT.Controls.Add(this.pYA);
			this.gbPT.Controls.Add(this.PaHeight);
			this.gbPT.Controls.Add(this.Panel2);
			Control arg_8F5_0 = this.gbPT;
			location = new Point(5, 20);
			arg_8F5_0.Location = location;
			this.gbPT.Name = "gbPT";
			Control arg_922_0 = this.gbPT;
			size = new Size(424, 143);
			arg_922_0.Size = size;
			this.gbPT.TabIndex = 41;
			this.gbPT.TabStop = false;
			this.gbPT.Text = "牙位图";
			this.PaHeight.BackColor = Color.Black;
			Control arg_975_0 = this.PaHeight;
			location = new Point(210, 12);
			arg_975_0.Location = location;
			Control arg_989_0 = this.PaHeight;
			Padding margin = new Padding(0);
			arg_989_0.Margin = margin;
			this.PaHeight.Name = "PaHeight";
			Control arg_9AF_0 = this.PaHeight;
			size = new Size(2, 120);
			arg_9AF_0.Size = size;
			this.PaHeight.TabIndex = 74;
			this.Panel2.BackColor = Color.Black;
			Control arg_9E2_0 = this.Panel2;
			location = new Point(7, 71);
			arg_9E2_0.Location = location;
			Control arg_9F6_0 = this.Panel2;
			margin = new Padding(0);
			arg_9F6_0.Margin = margin;
			this.Panel2.Name = "Panel2";
			Control arg_A1F_0 = this.Panel2;
			size = new Size(408, 2);
			arg_A1F_0.Size = size;
			this.Panel2.TabIndex = 73;
			this.pYA.Controls.Add(this.btYA3);
			this.pYA.Controls.Add(this.btYA5);
			this.pYA.Controls.Add(this.btYA4);
			this.pYA.Controls.Add(this.btYA2);
			this.pYA.Controls.Add(this.btYA1);
			Control arg_AB0_0 = this.pYA;
			location = new Point(7, 12);
			arg_AB0_0.Location = location;
			this.pYA.Name = "pYA";
			Control arg_ADA_0 = this.pYA;
			size = new Size(200, 27);
			arg_ADA_0.Size = size;
			this.pYA.TabIndex = 9;
			this.pYB.Controls.Add(this.btYB4);
			this.pYB.Controls.Add(this.btYB2);
			this.pYB.Controls.Add(this.btYB1);
			this.pYB.Controls.Add(this.btYB5);
			this.pYB.Controls.Add(this.btYB3);
			Control arg_B6F_0 = this.pYB;
			location = new Point(215, 12);
			arg_B6F_0.Location = location;
			this.pYB.Name = "pYB";
			Control arg_B99_0 = this.pYB;
			size = new Size(200, 27);
			arg_B99_0.Size = size;
			this.pYB.TabIndex = 9;
			this.pXA.Controls.Add(this.btXA4);
			this.pXA.Controls.Add(this.btXA1);
			this.pXA.Controls.Add(this.btXA2);
			this.pXA.Controls.Add(this.btXA8);
			this.pXA.Controls.Add(this.btXA7);
			this.pXA.Controls.Add(this.btXA3);
			this.pXA.Controls.Add(this.btXA6);
			this.pXA.Controls.Add(this.btXA5);
			Control arg_C6C_0 = this.pXA;
			location = new Point(7, 41);
			arg_C6C_0.Location = location;
			this.pXA.Name = "pXA";
			Control arg_C96_0 = this.pXA;
			size = new Size(200, 27);
			arg_C96_0.Size = size;
			this.pXA.TabIndex = 90;
			this.pXC.Controls.Add(this.btXC4);
			this.pXC.Controls.Add(this.btXC7);
			this.pXC.Controls.Add(this.btXC6);
			this.pXC.Controls.Add(this.btXC8);
			this.pXC.Controls.Add(this.btXC5);
			this.pXC.Controls.Add(this.btXC2);
			this.pXC.Controls.Add(this.btXC1);
			this.pXC.Controls.Add(this.btXC3);
			Control arg_D69_0 = this.pXC;
			location = new Point(7, 76);
			arg_D69_0.Location = location;
			this.pXC.Name = "pXC";
			Control arg_D93_0 = this.pXC;
			size = new Size(200, 27);
			arg_D93_0.Size = size;
			this.pXC.TabIndex = 91;
			this.pYC.Controls.Add(this.btYC2);
			this.pYC.Controls.Add(this.btYC3);
			this.pYC.Controls.Add(this.btYC5);
			this.pYC.Controls.Add(this.btYC1);
			this.pYC.Controls.Add(this.btYC4);
			Control arg_E24_0 = this.pYC;
			location = new Point(6, 105);
			arg_E24_0.Location = location;
			this.pYC.Name = "pYC";
			Control arg_E4E_0 = this.pYC;
			size = new Size(200, 27);
			arg_E4E_0.Size = size;
			this.pYC.TabIndex = 92;
			this.pXB.Controls.Add(this.btXB2);
			this.pXB.Controls.Add(this.btXB6);
			this.pXB.Controls.Add(this.btXB5);
			this.pXB.Controls.Add(this.btXB4);
			this.pXB.Controls.Add(this.btXB3);
			this.pXB.Controls.Add(this.btXB1);
			this.pXB.Controls.Add(this.btXB8);
			this.pXB.Controls.Add(this.btXB7);
			Control arg_F25_0 = this.pXB;
			location = new Point(215, 41);
			arg_F25_0.Location = location;
			this.pXB.Name = "pXB";
			Control arg_F4F_0 = this.pXB;
			size = new Size(200, 27);
			arg_F4F_0.Size = size;
			this.pXB.TabIndex = 93;
			this.pXD.Controls.Add(this.btXD4);
			this.pXD.Controls.Add(this.btXD1);
			this.pXD.Controls.Add(this.btXD5);
			this.pXD.Controls.Add(this.btXD3);
			this.pXD.Controls.Add(this.btXD2);
			this.pXD.Controls.Add(this.btXD8);
			this.pXD.Controls.Add(this.btXD7);
			this.pXD.Controls.Add(this.btXD6);
			Control arg_1026_0 = this.pXD;
			location = new Point(215, 76);
			arg_1026_0.Location = location;
			this.pXD.Name = "pXD";
			Control arg_1050_0 = this.pXD;
			size = new Size(200, 27);
			arg_1050_0.Size = size;
			this.pXD.TabIndex = 94;
			this.pYD.Controls.Add(this.btYD1);
			this.pYD.Controls.Add(this.btYD4);
			this.pYD.Controls.Add(this.btYD5);
			this.pYD.Controls.Add(this.btYD3);
			this.pYD.Controls.Add(this.btYD2);
			Control arg_10E5_0 = this.pYD;
			location = new Point(215, 105);
			arg_10E5_0.Location = location;
			this.pYD.Name = "pYD";
			Control arg_110F_0 = this.pYD;
			size = new Size(200, 27);
			arg_110F_0.Size = size;
			this.pYD.TabIndex = 95;
			this.chkDeciduous.AutoSize = true;
			Control arg_1141_0 = this.chkDeciduous;
			location = new Point(347, 6);
			arg_1141_0.Location = location;
			this.chkDeciduous.Name = "chkDeciduous";
			Control arg_1168_0 = this.chkDeciduous;
			size = new Size(48, 16);
			arg_1168_0.Size = size;
			this.chkDeciduous.TabIndex = 22;
			this.chkDeciduous.Text = "乳牙";
			this.chkDeciduous.UseVisualStyleBackColor = true;
			this.llCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_11BB_0 = this.llCancel;
			location = new Point(371, 188);
			arg_11BB_0.Location = location;
			this.llCancel.Name = "llCancel";
			Control arg_11E2_0 = this.llCancel;
			size = new Size(48, 16);
			arg_11E2_0.Size = size;
			this.llCancel.TabIndex = 2;
			this.llCancel.TabStop = true;
			this.llCancel.Text = "取消(&C)";
			this.llSelAll.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.llSelAll.LinkColor = Color.FromArgb(0, 0, 255);
			Control arg_1246_0 = this.llSelAll;
			location = new Point(3, 188);
			arg_1246_0.Location = location;
			this.llSelAll.Name = "llSelAll";
			Control arg_126D_0 = this.llSelAll;
			size = new Size(80, 16);
			arg_126D_0.Size = size;
			this.llSelAll.TabIndex = 0;
			this.llSelAll.TabStop = true;
			this.llSelAll.Text = "全选/全消(&S)";
			this.llOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_12BF_0 = this.llOK;
			location = new Point(303, 188);
			arg_12BF_0.Location = location;
			this.llOK.Name = "llOK";
			Control arg_12E6_0 = this.llOK;
			size = new Size(48, 16);
			arg_12E6_0.Size = size;
			this.llOK.TabIndex = 1;
			this.llOK.TabStop = true;
			this.llOK.Text = "确定(&O)";
			this.AcceptButton = this.btnOK;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(239, 239, 239);
			this.CancelButton = this.btnCancel;
			size = new Size(434, 209);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			size = new Size(200, 48);
			this.MinimumSize = size;
			this.Name = "MultiChoiceForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Panel1.ResumeLayout(false);
			this.pCheck.ResumeLayout(false);
			this.pCheck.PerformLayout();
			this.gbPT.ResumeLayout(false);
			this.pYA.ResumeLayout(false);
			this.pYB.ResumeLayout(false);
			this.pXA.ResumeLayout(false);
			this.pXC.ResumeLayout(false);
			this.pYC.ResumeLayout(false);
			this.pXB.ResumeLayout(false);
			this.pXD.ResumeLayout(false);
			this.pYD.ResumeLayout(false);
			this.ResumeLayout(false);
			this.btXA1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_149B_0 = this.btXA1;
			location = new Point(175, 0);
			arg_149B_0.Location = location;
			this.btXA1.Name = "btXA1";
			Control arg_14C2_0 = this.btXA1;
			size = new Size(25, 27);
			arg_14C2_0.Size = size;
			this.btXA1.TabIndex = 1;
			this.btXA1.UseVisualStyleBackColor = true;
			this.btXA2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1514_0 = this.btXA2;
			location = new Point(150, 0);
			arg_1514_0.Location = location;
			this.btXA2.Name = "btXA2";
			Control arg_153B_0 = this.btXA2;
			size = new Size(25, 27);
			arg_153B_0.Size = size;
			this.btXA2.TabIndex = 2;
			this.btXA2.UseVisualStyleBackColor = true;
			this.btXA3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_158A_0 = this.btXA3;
			location = new Point(125, 0);
			arg_158A_0.Location = location;
			this.btXA3.Name = "btXA3";
			Control arg_15B1_0 = this.btXA3;
			size = new Size(25, 27);
			arg_15B1_0.Size = size;
			this.btXA3.UseVisualStyleBackColor = true;
			this.btXA4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_15F4_0 = this.btXA4;
			location = new Point(100, 0);
			arg_15F4_0.Location = location;
			this.btXA4.Name = "btXA4";
			Control arg_161B_0 = this.btXA4;
			size = new Size(25, 27);
			arg_161B_0.Size = size;
			this.btXA4.TabIndex = 4;
			this.btXA4.UseVisualStyleBackColor = true;
			this.btXA5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_166A_0 = this.btXA5;
			location = new Point(75, 0);
			arg_166A_0.Location = location;
			this.btXA5.Name = "btXA5";
			Control arg_1691_0 = this.btXA5;
			size = new Size(25, 27);
			arg_1691_0.Size = size;
			this.btXA5.TabIndex = 5;
			this.btXA5.UseVisualStyleBackColor = true;
			this.btXA6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_16E0_0 = this.btXA6;
			location = new Point(50, 0);
			arg_16E0_0.Location = location;
			this.btXA6.Name = "btXA6";
			Control arg_1707_0 = this.btXA6;
			size = new Size(25, 27);
			arg_1707_0.Size = size;
			this.btXA6.TabIndex = 6;
			this.btXA6.UseVisualStyleBackColor = true;
			this.btXA7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1756_0 = this.btXA7;
			location = new Point(25, 0);
			arg_1756_0.Location = location;
			this.btXA7.Name = "btXA7";
			Control arg_177D_0 = this.btXA7;
			size = new Size(25, 27);
			arg_177D_0.Size = size;
			this.btXA7.TabIndex = 7;
			this.btXA7.UseVisualStyleBackColor = true;
			this.btXA8.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_17CB_0 = this.btXA8;
			location = new Point(0, 0);
			arg_17CB_0.Location = location;
			this.btXA8.Name = "btXA8";
			Control arg_17F2_0 = this.btXA8;
			size = new Size(25, 27);
			arg_17F2_0.Size = size;
			this.btXA8.TabIndex = 8;
			this.btXA8.UseVisualStyleBackColor = true;
			this.btXB1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1840_0 = this.btXB1;
			location = new Point(0, 0);
			arg_1840_0.Location = location;
			this.btXB1.Name = "btXB1";
			Control arg_1867_0 = this.btXB1;
			size = new Size(25, 27);
			arg_1867_0.Size = size;
			this.btXB1.TabIndex = 9;
			this.btXB1.UseVisualStyleBackColor = true;
			this.btXB2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_18B7_0 = this.btXB2;
			location = new Point(25, 0);
			arg_18B7_0.Location = location;
			this.btXB2.Name = "btXB2";
			Control arg_18DE_0 = this.btXB2;
			size = new Size(25, 27);
			arg_18DE_0.Size = size;
			this.btXB2.TabIndex = 10;
			this.btXB2.UseVisualStyleBackColor = true;
			this.btXB3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_192E_0 = this.btXB3;
			location = new Point(50, 0);
			arg_192E_0.Location = location;
			this.btXB3.Name = "btXB3";
			Control arg_1955_0 = this.btXB3;
			size = new Size(25, 27);
			arg_1955_0.Size = size;
			this.btXB3.TabIndex = 11;
			this.btXB3.UseVisualStyleBackColor = true;
			this.btXB4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_19A5_0 = this.btXB4;
			location = new Point(75, 0);
			arg_19A5_0.Location = location;
			this.btXB4.Name = "btXB4";
			Control arg_19CC_0 = this.btXB4;
			size = new Size(25, 27);
			arg_19CC_0.Size = size;
			this.btXB4.TabIndex = 12;
			this.btXB4.UseVisualStyleBackColor = true;
			this.btXB5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1A1C_0 = this.btXB5;
			location = new Point(100, 0);
			arg_1A1C_0.Location = location;
			this.btXB5.Name = "btXB5";
			Control arg_1A43_0 = this.btXB5;
			size = new Size(25, 27);
			arg_1A43_0.Size = size;
			this.btXB5.TabIndex = 13;
			this.btXB5.UseVisualStyleBackColor = true;
			this.btXB6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1A93_0 = this.btXB6;
			location = new Point(125, 0);
			arg_1A93_0.Location = location;
			this.btXB6.Name = "btXB6";
			Control arg_1ABA_0 = this.btXB6;
			size = new Size(25, 27);
			arg_1ABA_0.Size = size;
			this.btXB6.TabIndex = 14;
			this.btXB6.UseVisualStyleBackColor = true;
			this.btXB7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1B0D_0 = this.btXB7;
			location = new Point(150, 0);
			arg_1B0D_0.Location = location;
			this.btXB7.Name = "btXB7";
			Control arg_1B34_0 = this.btXB7;
			size = new Size(25, 27);
			arg_1B34_0.Size = size;
			this.btXB7.TabIndex = 15;
			this.btXB7.UseVisualStyleBackColor = true;
			this.btXB8.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1B87_0 = this.btXB8;
			location = new Point(175, 0);
			arg_1B87_0.Location = location;
			this.btXB8.Name = "btXB8";
			Control arg_1BAE_0 = this.btXB8;
			size = new Size(25, 27);
			arg_1BAE_0.Size = size;
			this.btXB8.TabIndex = 16;
			this.btXB8.UseVisualStyleBackColor = true;
			this.btXC1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1C01_0 = this.btXC1;
			location = new Point(175, 0);
			arg_1C01_0.Location = location;
			this.btXC1.Name = "btXC1";
			Control arg_1C28_0 = this.btXC1;
			size = new Size(25, 27);
			arg_1C28_0.Size = size;
			this.btXC1.TabIndex = 17;
			this.btXC1.UseVisualStyleBackColor = true;
			this.btXC2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1C7B_0 = this.btXC2;
			location = new Point(150, 0);
			arg_1C7B_0.Location = location;
			this.btXC2.Name = "btXC2";
			Control arg_1CA2_0 = this.btXC2;
			size = new Size(25, 27);
			arg_1CA2_0.Size = size;
			this.btXC2.TabIndex = 18;
			this.btXC2.UseVisualStyleBackColor = true;
			this.btXC3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1CF2_0 = this.btXC3;
			location = new Point(125, 0);
			arg_1CF2_0.Location = location;
			this.btXC3.Name = "btXC3";
			Control arg_1D19_0 = this.btXC3;
			size = new Size(25, 27);
			arg_1D19_0.Size = size;
			this.btXC3.TabIndex = 19;
			this.btXC3.UseVisualStyleBackColor = true;
			this.btXC4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1D69_0 = this.btXC4;
			location = new Point(100, 0);
			arg_1D69_0.Location = location;
			this.btXC4.Name = "btXC4";
			Control arg_1D90_0 = this.btXC4;
			size = new Size(25, 27);
			arg_1D90_0.Size = size;
			this.btXC4.TabIndex = 20;
			this.btXC4.UseVisualStyleBackColor = true;
			this.btXC5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1DE0_0 = this.btXC5;
			location = new Point(75, 0);
			arg_1DE0_0.Location = location;
			this.btXC5.Name = "btXC5";
			Control arg_1E07_0 = this.btXC5;
			size = new Size(25, 27);
			arg_1E07_0.Size = size;
			this.btXC5.TabIndex = 21;
			this.btXC5.UseVisualStyleBackColor = true;
			this.btXC6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1E57_0 = this.btXC6;
			location = new Point(50, 0);
			arg_1E57_0.Location = location;
			this.btXC6.Name = "btXC6";
			Control arg_1E7E_0 = this.btXC6;
			size = new Size(25, 27);
			arg_1E7E_0.Size = size;
			this.btXC6.TabIndex = 22;
			this.btXC6.UseVisualStyleBackColor = true;
			this.btXC7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1ECE_0 = this.btXC7;
			location = new Point(25, 0);
			arg_1ECE_0.Location = location;
			this.btXC7.Name = "btXC7";
			Control arg_1EF5_0 = this.btXC7;
			size = new Size(25, 27);
			arg_1EF5_0.Size = size;
			this.btXC7.TabIndex = 23;
			this.btXC7.UseVisualStyleBackColor = true;
			this.btXC8.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1F44_0 = this.btXC8;
			location = new Point(0, 0);
			arg_1F44_0.Location = location;
			this.btXC8.Name = "btXC8";
			Control arg_1F6B_0 = this.btXC8;
			size = new Size(25, 27);
			arg_1F6B_0.Size = size;
			this.btXC8.TabIndex = 24;
			this.btXC8.UseVisualStyleBackColor = true;
			this.btXD1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_1FBA_0 = this.btXD1;
			location = new Point(0, 0);
			arg_1FBA_0.Location = location;
			this.btXD1.Name = "btXD1";
			Control arg_1FE1_0 = this.btXD1;
			size = new Size(25, 27);
			arg_1FE1_0.Size = size;
			this.btXD1.TabIndex = 25;
			this.btXD1.UseVisualStyleBackColor = true;
			this.btXD2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2031_0 = this.btXD2;
			location = new Point(25, 0);
			arg_2031_0.Location = location;
			this.btXD2.Name = "btXD2";
			Control arg_2058_0 = this.btXD2;
			size = new Size(25, 27);
			arg_2058_0.Size = size;
			this.btXD2.TabIndex = 26;
			this.btXD2.UseVisualStyleBackColor = true;
			this.btXD3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_20A8_0 = this.btXD3;
			location = new Point(50, 0);
			arg_20A8_0.Location = location;
			this.btXD3.Name = "btXD3";
			Control arg_20CF_0 = this.btXD3;
			size = new Size(25, 27);
			arg_20CF_0.Size = size;
			this.btXD3.TabIndex = 27;
			this.btXD3.UseVisualStyleBackColor = true;
			this.btXD4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_211F_0 = this.btXD4;
			location = new Point(75, 0);
			arg_211F_0.Location = location;
			this.btXD4.Name = "btXD4";
			Control arg_2146_0 = this.btXD4;
			size = new Size(25, 27);
			arg_2146_0.Size = size;
			this.btXD4.TabIndex = 28;
			this.btXD4.UseVisualStyleBackColor = true;
			this.btXD5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2196_0 = this.btXD5;
			location = new Point(100, 0);
			arg_2196_0.Location = location;
			this.btXD5.Name = "btXD5";
			Control arg_21BD_0 = this.btXD5;
			size = new Size(25, 27);
			arg_21BD_0.Size = size;
			this.btXD5.TabIndex = 29;
			this.btXD5.UseVisualStyleBackColor = true;
			this.btXD6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_220D_0 = this.btXD6;
			location = new Point(125, 0);
			arg_220D_0.Location = location;
			this.btXD6.Name = "btXD6";
			Control arg_2234_0 = this.btXD6;
			size = new Size(25, 27);
			arg_2234_0.Size = size;
			this.btXD6.TabIndex = 30;
			this.btXD6.UseVisualStyleBackColor = true;
			this.btXD7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2287_0 = this.btXD7;
			location = new Point(150, 0);
			arg_2287_0.Location = location;
			this.btXD7.Name = "btXD7";
			Control arg_22AE_0 = this.btXD7;
			size = new Size(25, 27);
			arg_22AE_0.Size = size;
			this.btXD7.TabIndex = 31;
			this.btXD7.UseVisualStyleBackColor = true;
			this.btXD8.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2301_0 = this.btXD8;
			location = new Point(175, 0);
			arg_2301_0.Location = location;
			this.btXD8.Name = "btXD8";
			Control arg_2328_0 = this.btXD8;
			size = new Size(25, 27);
			arg_2328_0.Size = size;
			this.btXD8.TabIndex = 32;
			this.btXD8.UseVisualStyleBackColor = true;
			this.btYA1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_237B_0 = this.btYA1;
			location = new Point(175, 0);
			arg_237B_0.Location = location;
			this.btYA1.Name = "btYA1";
			Control arg_23A2_0 = this.btYA1;
			size = new Size(25, 27);
			arg_23A2_0.Size = size;
			this.btYA1.TabIndex = 33;
			this.btYA1.UseVisualStyleBackColor = true;
			this.btYA2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_23F5_0 = this.btYA2;
			location = new Point(150, 0);
			arg_23F5_0.Location = location;
			this.btYA2.Name = "btYA2";
			Control arg_241C_0 = this.btYA2;
			size = new Size(25, 27);
			arg_241C_0.Size = size;
			this.btYA2.TabIndex = 34;
			this.btYA2.UseVisualStyleBackColor = true;
			this.btYA3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_246C_0 = this.btYA3;
			location = new Point(125, 0);
			arg_246C_0.Location = location;
			this.btYA3.Name = "btYA3";
			Control arg_2493_0 = this.btYA3;
			size = new Size(25, 27);
			arg_2493_0.Size = size;
			this.btYA3.TabIndex = 35;
			this.btYA3.UseVisualStyleBackColor = true;
			this.btYA4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_24E3_0 = this.btYA4;
			location = new Point(100, 0);
			arg_24E3_0.Location = location;
			this.btYA4.Name = "btYA4";
			Control arg_250A_0 = this.btYA4;
			size = new Size(25, 27);
			arg_250A_0.Size = size;
			this.btYA4.TabIndex = 36;
			this.btYA4.UseVisualStyleBackColor = true;
			this.btYA5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_255A_0 = this.btYA5;
			location = new Point(75, 0);
			arg_255A_0.Location = location;
			this.btYA5.Name = "btYA5";
			Control arg_2581_0 = this.btYA5;
			size = new Size(25, 27);
			arg_2581_0.Size = size;
			this.btYA5.TabIndex = 37;
			this.btYA5.UseVisualStyleBackColor = true;
			this.btYB1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_25D0_0 = this.btYB1;
			location = new Point(0, 0);
			arg_25D0_0.Location = location;
			this.btYB1.Name = "btYB1";
			Control arg_25F7_0 = this.btYB1;
			size = new Size(25, 27);
			arg_25F7_0.Size = size;
			this.btYB1.TabIndex = 38;
			this.btYB1.UseVisualStyleBackColor = true;
			this.btYB2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2647_0 = this.btYB2;
			location = new Point(25, 0);
			arg_2647_0.Location = location;
			this.btYB2.Name = "btYB2";
			Control arg_266E_0 = this.btYB2;
			size = new Size(25, 27);
			arg_266E_0.Size = size;
			this.btYB2.TabIndex = 39;
			this.btYB2.UseVisualStyleBackColor = true;
			this.btYB3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_26BE_0 = this.btYB3;
			location = new Point(50, 0);
			arg_26BE_0.Location = location;
			this.btYB3.Name = "btYB3";
			Control arg_26E5_0 = this.btYB3;
			size = new Size(25, 27);
			arg_26E5_0.Size = size;
			this.btYB3.TabIndex = 40;
			this.btYB3.UseVisualStyleBackColor = true;
			this.btYB4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2735_0 = this.btYB4;
			location = new Point(75, 0);
			arg_2735_0.Location = location;
			this.btYB4.Name = "btYB4";
			Control arg_275C_0 = this.btYB4;
			size = new Size(25, 27);
			arg_275C_0.Size = size;
			this.btYB4.TabIndex = 41;
			this.btYB4.UseVisualStyleBackColor = true;
			this.btYB5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_27AC_0 = this.btYB5;
			location = new Point(100, 0);
			arg_27AC_0.Location = location;
			this.btYB5.Name = "btYB5";
			Control arg_27D3_0 = this.btYB5;
			size = new Size(25, 27);
			arg_27D3_0.Size = size;
			this.btYB5.TabIndex = 42;
			this.btYB5.UseVisualStyleBackColor = true;
			this.btYC1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2826_0 = this.btYC1;
			location = new Point(175, 0);
			arg_2826_0.Location = location;
			this.btYC1.Name = "btYC1";
			Control arg_284D_0 = this.btYC1;
			size = new Size(25, 27);
			arg_284D_0.Size = size;
			this.btYC1.TabIndex = 43;
			this.btYC1.UseVisualStyleBackColor = true;
			this.btYC2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_28A0_0 = this.btYC2;
			location = new Point(150, 0);
			arg_28A0_0.Location = location;
			this.btYC2.Name = "btYC2";
			Control arg_28C7_0 = this.btYC2;
			size = new Size(25, 27);
			arg_28C7_0.Size = size;
			this.btYC2.TabIndex = 44;
			this.btYC2.UseVisualStyleBackColor = true;
			this.btYC3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2917_0 = this.btYC3;
			location = new Point(125, 0);
			arg_2917_0.Location = location;
			this.btYC3.Name = "btYC3";
			Control arg_293E_0 = this.btYC3;
			size = new Size(25, 27);
			arg_293E_0.Size = size;
			this.btYC3.TabIndex = 45;
			this.btYC3.UseVisualStyleBackColor = true;
			this.btYC4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_298E_0 = this.btYC4;
			location = new Point(100, 0);
			arg_298E_0.Location = location;
			this.btYC4.Name = "btYC4";
			Control arg_29B5_0 = this.btYC4;
			size = new Size(25, 27);
			arg_29B5_0.Size = size;
			this.btYC4.TabIndex = 46;
			this.btYC4.UseVisualStyleBackColor = true;
			this.btYC5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2A05_0 = this.btYC5;
			location = new Point(75, 0);
			arg_2A05_0.Location = location;
			this.btYC5.Name = "btYC5";
			Control arg_2A2C_0 = this.btYC5;
			size = new Size(25, 27);
			arg_2A2C_0.Size = size;
			this.btYC5.TabIndex = 47;
			this.btYC5.UseVisualStyleBackColor = true;
			this.btYD1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2A7B_0 = this.btYD1;
			location = new Point(0, 0);
			arg_2A7B_0.Location = location;
			this.btYD1.Name = "btYD1";
			Control arg_2AA2_0 = this.btYD1;
			size = new Size(25, 27);
			arg_2AA2_0.Size = size;
			this.btYD1.TabIndex = 48;
			this.btYD1.UseVisualStyleBackColor = true;
			this.btYD2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2AF2_0 = this.btYD2;
			location = new Point(25, 0);
			arg_2AF2_0.Location = location;
			this.btYD2.Name = "btYD2";
			Control arg_2B19_0 = this.btYD2;
			size = new Size(25, 27);
			arg_2B19_0.Size = size;
			this.btYD2.TabIndex = 49;
			this.btYD2.UseVisualStyleBackColor = true;
			this.btYD3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2B69_0 = this.btYD3;
			location = new Point(50, 0);
			arg_2B69_0.Location = location;
			this.btYD3.Name = "btYD3";
			Control arg_2B90_0 = this.btYD3;
			size = new Size(25, 27);
			arg_2B90_0.Size = size;
			this.btYD3.TabIndex = 50;
			this.btYD3.UseVisualStyleBackColor = true;
			this.btYD4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2BE0_0 = this.btYD4;
			location = new Point(75, 0);
			arg_2BE0_0.Location = location;
			this.btYD4.Name = "btYD4";
			Control arg_2C07_0 = this.btYD4;
			size = new Size(25, 27);
			arg_2C07_0.Size = size;
			this.btYD4.TabIndex = 51;
			this.btYD4.UseVisualStyleBackColor = true;
			this.btYD5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			Control arg_2C57_0 = this.btYD5;
			location = new Point(100, 0);
			arg_2C57_0.Location = location;
			this.btYD5.Name = "btYD5";
			Control arg_2C7E_0 = this.btYD5;
			size = new Size(25, 27);
			arg_2C7E_0.Size = size;
			this.btYD5.TabIndex = 52;
			this.btYD5.UseVisualStyleBackColor = true;
		}

		private void InitButton()
		{
			if (this.dsTeethPestion != null && this.dsTeethPestion.Tables.Count > 0)
			{
				try
				{
					IEnumerator enumerator = this.dsTeethPestion.Tables[0].Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string left = dataRow["CtmDictCode"].ToString();
						if (Operators.CompareString(left, "btXA1", false) == 0)
						{
							this.btXA1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA2", false) == 0)
						{
							this.btXA2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA3", false) == 0)
						{
							this.btXA3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA4", false) == 0)
						{
							this.btXA4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA5", false) == 0)
						{
							this.btXA5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA6", false) == 0)
						{
							this.btXA6.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA6.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA7", false) == 0)
						{
							this.btXA7.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA7.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXA8", false) == 0)
						{
							this.btXA8.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXA8.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB1", false) == 0)
						{
							this.btXB1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB2", false) == 0)
						{
							this.btXB2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB3", false) == 0)
						{
							this.btXB3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB4", false) == 0)
						{
							this.btXB4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB5", false) == 0)
						{
							this.btXB5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB6", false) == 0)
						{
							this.btXB6.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB6.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB7", false) == 0)
						{
							this.btXB7.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB7.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXB8", false) == 0)
						{
							this.btXB8.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXB8.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC1", false) == 0)
						{
							this.btXC1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC2", false) == 0)
						{
							this.btXC2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC3", false) == 0)
						{
							this.btXC3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC4", false) == 0)
						{
							this.btXC4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC5", false) == 0)
						{
							this.btXC5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC6", false) == 0)
						{
							this.btXC6.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC6.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC7", false) == 0)
						{
							this.btXC7.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC7.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXC8", false) == 0)
						{
							this.btXC8.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXC8.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD1", false) == 0)
						{
							this.btXD1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD2", false) == 0)
						{
							this.btXD2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD3", false) == 0)
						{
							this.btXD3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD4", false) == 0)
						{
							this.btXD4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD5", false) == 0)
						{
							this.btXD5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD6", false) == 0)
						{
							this.btXD6.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD6.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD7", false) == 0)
						{
							this.btXD7.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD7.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btXD8", false) == 0)
						{
							this.btXD8.Tag = dataRow["CtmDictAlias"].ToString();
							this.btXD8.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYA1", false) == 0)
						{
							this.btYA1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYA1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYA2", false) == 0)
						{
							this.btYA2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYA2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYA3", false) == 0)
						{
							this.btYA3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYA3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYA4", false) == 0)
						{
							this.btYA4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYA4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYA5", false) == 0)
						{
							this.btYA5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYA5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYB1", false) == 0)
						{
							this.btYB1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYB1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYB2", false) == 0)
						{
							this.btYB2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYB2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYB3", false) == 0)
						{
							this.btYB3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYB3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYB4", false) == 0)
						{
							this.btYB4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYB4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYB5", false) == 0)
						{
							this.btYB5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYB5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYC1", false) == 0)
						{
							this.btYC1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYC1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYC2", false) == 0)
						{
							this.btYC2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYC2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYC3", false) == 0)
						{
							this.btYC3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYC3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYC4", false) == 0)
						{
							this.btYC4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYC4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYC5", false) == 0)
						{
							this.btYC5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYC5.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYD1", false) == 0)
						{
							this.btYD1.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYD1.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYD2", false) == 0)
						{
							this.btYD2.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYD2.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYD3", false) == 0)
						{
							this.btYD3.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYD3.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYD4", false) == 0)
						{
							this.btYD4.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYD4.Text = dataRow["CtmDictDesc"].ToString();
						}
						else if (Operators.CompareString(left, "btYD5", false) == 0)
						{
							this.btYD5.Tag = dataRow["CtmDictAlias"].ToString();
							this.btYD5.Text = dataRow["CtmDictDesc"].ToString();
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
			}
		}

		public void initEvent()
		{
			this.btXA1.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA2.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA3.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA4.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA5.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA6.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA7.Click += new EventHandler(this.GetTeecthPosition);
			this.btXA8.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB1.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB2.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB3.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB4.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB5.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB6.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB7.Click += new EventHandler(this.GetTeecthPosition);
			this.btXB8.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC1.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC2.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC3.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC4.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC5.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC6.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC7.Click += new EventHandler(this.GetTeecthPosition);
			this.btXC8.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD1.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD2.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD3.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD4.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD5.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD6.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD7.Click += new EventHandler(this.GetTeecthPosition);
			this.btXD8.Click += new EventHandler(this.GetTeecthPosition);
			this.btYA1.Click += new EventHandler(this.GetTeecthPosition);
			this.btYA2.Click += new EventHandler(this.GetTeecthPosition);
			this.btYA3.Click += new EventHandler(this.GetTeecthPosition);
			this.btYA4.Click += new EventHandler(this.GetTeecthPosition);
			this.btYA5.Click += new EventHandler(this.GetTeecthPosition);
			this.btYB1.Click += new EventHandler(this.GetTeecthPosition);
			this.btYB2.Click += new EventHandler(this.GetTeecthPosition);
			this.btYB3.Click += new EventHandler(this.GetTeecthPosition);
			this.btYB4.Click += new EventHandler(this.GetTeecthPosition);
			this.btYB5.Click += new EventHandler(this.GetTeecthPosition);
			this.btYC1.Click += new EventHandler(this.GetTeecthPosition);
			this.btYC2.Click += new EventHandler(this.GetTeecthPosition);
			this.btYC3.Click += new EventHandler(this.GetTeecthPosition);
			this.btYC4.Click += new EventHandler(this.GetTeecthPosition);
			this.btYC5.Click += new EventHandler(this.GetTeecthPosition);
			this.btYD1.Click += new EventHandler(this.GetTeecthPosition);
			this.btYD2.Click += new EventHandler(this.GetTeecthPosition);
			this.btYD3.Click += new EventHandler(this.GetTeecthPosition);
			this.btYD4.Click += new EventHandler(this.GetTeecthPosition);
			this.btYD5.Click += new EventHandler(this.GetTeecthPosition);
		}

		public MultiChoiceForm(MIMultiChoice objMIMultiChoice, string strValueCode) : this()
		{
			this.gbPT.Visible = false;
			this.chkDeciduous.Visible = false;
			this.llSelAll.Visible = true;
			this.llCancel.Visible = true;
			this.lbxChoices.Dock = DockStyle.Fill;
			this.curMIMultiChoice = objMIMultiChoice;
			StringEnumerator enumerator = this.curMIMultiChoice.Choices.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				this.lbxChoices.Items.Add(current);
			}
			this.CheckStatus = this.curValueCode;
		}

		public MultiChoiceForm(MIMultiChoice objMiMultiChoice, ETeethPestion curdsTeethPestion) : this()
		{
			this.dsTeethPestion = curdsTeethPestion;
			this.InitButton();
			this.curMIMultiChoice = objMiMultiChoice;
			this.lbxChoices.Visible = false;
			this.gbPT.Visible = true;
			Control arg_43_0 = this.gbPT;
			Point location = new Point(2, 26);
			arg_43_0.Location = location;
			this.chkDeciduous.Visible = true;
			this.llSelAll.Visible = false;
			this.llCancel.Visible = false;
			this.chkDeciduous_CheckedChanged(null, null);
		}

		private void ChoiceForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics arg_28_0 = graphics;
			Rectangle bounds = checked(new Rectangle(1, 1, this.Width - 1, this.Height - 1));
			ControlPaint.DrawBorder(arg_28_0, bounds, SystemColors.Control, ButtonBorderStyle.Outset);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.Msg == 256 | msg.Msg == 260)
			{
				if (keyData == Keys.Escape)
				{
					this.DialogResult = DialogResult.Cancel;
					return true;
				}
				if (keyData == Keys.Return)
				{
					this.DialogResult = DialogResult.OK;
					return true;
				}
				if (keyData == Keys.Tab)
				{
					if (this.lbxChoices.Items.Count > 0 & this.lbxChoices.SelectedIndex == checked(this.lbxChoices.Items.Count - 1))
					{
						this.lbxChoices.SelectedIndex = 0;
					}
					else
					{
						SendKeys.Send("{Down}");
					}
					return true;
				}
				if (keyData == (Keys)262223)
				{
					this.btnOK_Click(null, null);
					return true;
				}
				if (keyData == (Keys)262211)
				{
					this.btnCancel_Click(null, null);
					return true;
				}
				if (keyData == (Keys)262227)
				{
					this.operateAll_Click(null, null);
					return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void operateAll_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.lbxChoices.CheckedItems.Count == this.lbxChoices.Items.Count)
				{
					int arg_36_0 = 0;
					int num = this.lbxChoices.Items.Count - 1;
					for (int i = arg_36_0; i <= num; i++)
					{
						this.lbxChoices.SetItemChecked(i, false);
					}
				}
				else
				{
					int arg_64_0 = 0;
					int num2 = this.lbxChoices.Items.Count - 1;
					for (int j = arg_64_0; j <= num2; j++)
					{
						this.lbxChoices.SetItemChecked(j, true);
					}
				}
			}
		}

		private void llSelAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.operateAll_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void llCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.btnCancel_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void MultiChoiceForm_Load(object sender, EventArgs e)
		{
			this.AdjustFormWidth();
		}

		private void AdjustFormWidth()
		{
			Graphics graphics = this.lbxChoices.CreateGraphics();
			int num = 0;
			int arg_23_0 = 0;
			checked
			{
				int num2 = this.lbxChoices.Items.Count - 1;
				for (int i = arg_23_0; i <= num2; i++)
				{
					int num3 = (int)Math.Round((double)graphics.MeasureString(this.lbxChoices.Items[i].ToString(), this.lbxChoices.Font).Width);
					if (num3 > num)
					{
						num = num3;
					}
				}
				int width = Screen.PrimaryScreen.Bounds.Width;
				Point point = this.lbxChoices.PointToScreen(this.lbxChoices.Location);
				int num4 = num + 38;
				if (num4 > 192)
				{
					if (point.X + num4 <= width - 4)
					{
						this.lbxChoices.Width = num4;
					}
					else
					{
						this.lbxChoices.Width = width - 4 - point.X;
					}
				}
				int num5 = this.lbxChoices.Left + this.lbxChoices.Width + 4;
				if (num5 > 200)
				{
					this.Width = num5;
				}
			}
		}

		private void chkDeciduous_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkDeciduous.Checked)
			{
				this.SetBtVisible(true);
			}
			else
			{
				this.SetBtVisible(false);
			}
		}

		private void SetBtVisible(bool bValue)
		{
			this.pYA.Enabled = bValue;
			this.pYB.Enabled = bValue;
			this.pYC.Enabled = bValue;
			this.pYD.Enabled = bValue;
			this.pXA.Enabled = !bValue;
			this.pXB.Enabled = !bValue;
			this.pXC.Enabled = !bValue;
			this.pXD.Enabled = !bValue;
		}

		private void GetTeecthPosition(object sender, EventArgs e)
		{
			string text = Conversions.ToString(((Control)sender).Tag);
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				string name = ((Control)sender).Name;
				if (name.Contains("A"))
				{
					MultiChoiceForm.SetContrlEventHandler onButtionClickEvent = this.OnButtionClickEvent;
					if (onButtionClickEvent != null)
					{
						onButtionClickEvent(text, "A");
					}
				}
				else if (name.Contains("B"))
				{
					MultiChoiceForm.SetContrlEventHandler onButtionClickEvent = this.OnButtionClickEvent;
					if (onButtionClickEvent != null)
					{
						onButtionClickEvent(text, "B");
					}
				}
				else if (name.Contains("C"))
				{
					MultiChoiceForm.SetContrlEventHandler onButtionClickEvent = this.OnButtionClickEvent;
					if (onButtionClickEvent != null)
					{
						onButtionClickEvent(text, "C");
					}
				}
				else if (name.Contains("D"))
				{
					MultiChoiceForm.SetContrlEventHandler onButtionClickEvent = this.OnButtionClickEvent;
					if (onButtionClickEvent != null)
					{
						onButtionClickEvent(text, "D");
					}
				}
			}
		}
	}
}
