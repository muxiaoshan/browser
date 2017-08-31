using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.dictionary;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class PCTextEdit : RichTextBoxEx, PControlInterface, ICheck, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		public delegate void GetFocusHandler(string eCode, string kbBaseID, int kbPartNo);

		public static PCTextEdit objPCTExitFrm = null;

		private IContainer components;

		private string _ReviceUser;

		private string _ReviceDate;

		private string _ReviceTime;

		private bool _EditStatus;

		private Controller _Controller;

		private NInstanceItem _BindInstanceItem;

		private NInstanceItem _DragInstanceItem;

		private string _Code;

		private MenuItem miFormate;

		private MenuItem miSpecChar;

		public MenuItem miShowRevHis;

		private ContextMenu cmFormate;

		private bool _DisableAutoScroll;

		private bool boolUpdate;

		private Label curLabel;

		private RichTextBox curTip;

		private PCTextEdit.VChangedEventHandler VChangedEvent;

		private MenuItem miRISData;

		private MenuItem miLISData;

		private MenuItem miOrderData;

		private MenuItem miDiagnosData;

		private MenuItem miEdit;

		private MenuItem miCopy;

		private MenuItem miPaste;

		private MenuItem miUndo;

		private MenuItem miCut;

		private MenuItem miCopys;

		private PCTextEdit.GetFocusHandler OnPCTextEditGetFocusEvent;

		public static MulitCopy FmMulitCopy;

		private const int WM_IME_COMPOSITION = 271;

		private const int WM_IME_STARTCOMPOSITION = 269;

		private const int GCS_RESULTSTR = 2048;

		private const int WM_MOUSEMOVE = 512;

		private const int MK_LBUTTON = 1;

		private const int WM_LBUTTONDBLCLK = 515;

		private const int WM_LBUTTONDOWN = 513;

		private const int IME_ESC_IME_NAME = 4102;

		private const int EM_GETLINECOUNT = 186;

		private const int EM_LINEINDEX = 187;

		private const int EM_LINELENGTH = 193;

		private const int EM_LINEFROMCHAR = 201;

		private const int WM_VSCROLL = 277;

		private const int WM_HSCROLL = 276;

		private string initValue;

		public event PCTextEdit.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCTextEdit.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCTextEdit.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
			}
		}

		public event PCTextEdit.GetFocusHandler OnPCTextEditGetFocus
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnPCTextEditGetFocusEvent = (PCTextEdit.GetFocusHandler)Delegate.Combine(this.OnPCTextEditGetFocusEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnPCTextEditGetFocusEvent = (PCTextEdit.GetFocusHandler)Delegate.Remove(this.OnPCTextEditGetFocusEvent, value);
			}
		}

		public new Color SelectionBackColor
		{
			set
			{
				if (this.SelectedText == null)
				{
					return;
				}
				if (Operators.CompareString(this.SelectedText, "", false) == 0)
				{
					return;
				}
				StringBuilder stringBuilder = new StringBuilder();
				string selectedRtf = this.SelectedRtf;
				int num = 0;
				int num2 = Strings.InStr(1, selectedRtf, "}}", CompareMethod.Binary);
				checked
				{
					stringBuilder.Append(Strings.Mid(selectedRtf, 1, num2 + 1));
					int num3 = Strings.InStr(num2, selectedRtf, "{\\colortbl", CompareMethod.Binary);
					int num4;
					string text;
					if (num3 == 0)
					{
						stringBuilder.Append("{\\colortbl ;");
						num4 = num2;
						num = 1;
					}
					else
					{
						num4 = Strings.InStr(num3, selectedRtf, "}", CompareMethod.Binary);
						num4--;
						text = Strings.Mid(selectedRtf, num2 + 2, num4 - num2 - 1);
						int arg_A7_0 = 1;
						int length = text.Length;
						for (int i = arg_A7_0; i <= length; i++)
						{
							if (Operators.CompareString(Strings.Mid(text, i, 1), ";", false) == 0)
							{
								num++;
							}
						}
						stringBuilder.Append(text);
					}
					stringBuilder.Append("\\red" + Strings.Trim(value.R.ToString()));
					stringBuilder.Append("\\green" + Strings.Trim(value.G.ToString()));
					stringBuilder.Append("\\blue" + Strings.Trim(value.B.ToString()));
					stringBuilder.Append(";");
					stringBuilder.Append("}");
					stringBuilder.Append("\\highlight" + Strings.Trim(num.ToString()));
					text = Strings.Mid(selectedRtf, num4 + 2, selectedRtf.Length - num4 - 1);
					int num5 = 1;
					while (true)
					{
						int num6 = Strings.InStr(num5, text, "\\highlight", CompareMethod.Binary);
						if (num6 == 0)
						{
							break;
						}
						int num7 = num6 + 9;
						do
						{
							num7++;
							if (Operators.CompareString(Strings.Mid(text, num7 + 1, 1), " ", false) == 0)
							{
								goto Block_7;
							}
						}
						while (Strings.InStr(1, "0123456789", Strings.Mid(text, num7 + 1, 1), CompareMethod.Binary) != 0);
						IL_220:
						stringBuilder.Append(Strings.Mid(text, num5, num6 - num5));
						num5 = num7 + 1;
						continue;
						Block_7:
						num7++;
						goto IL_220;
					}
					stringBuilder.Append(Strings.Mid(text, num5, text.Length - num5));
					this.SelectedRtf = stringBuilder.ToString();
				}
			}
		}

		public Color SelectionForeColor
		{
			set
			{
				checked
				{
					try
					{
						if (this.SelectedText != null)
						{
							if (Operators.CompareString(this.SelectedText, "", false) != 0)
							{
								StringBuilder stringBuilder = new StringBuilder();
								string selectedRtf = this.SelectedRtf;
								int num = 0;
								int num2 = Strings.InStr(1, selectedRtf, "}}", CompareMethod.Binary);
								stringBuilder.Append(Strings.Mid(selectedRtf, 1, num2 + 1));
								int num3 = Strings.InStr(num2, selectedRtf, "{\\colortbl", CompareMethod.Binary);
								int num4;
								if (num3 == 0)
								{
									stringBuilder.Append("{\\colortbl ;");
									num4 = num2;
									num = 1;
								}
								else
								{
									num4 = Strings.InStr(num3, selectedRtf, "}", CompareMethod.Binary);
									num4--;
									string text = Strings.Mid(selectedRtf, num2 + 2, num4 - num2 - 1);
									int arg_AF_0 = 1;
									int length = text.Length;
									for (int i = arg_AF_0; i <= length; i++)
									{
										if (Operators.CompareString(Strings.Mid(text, i, 1), ";", false) == 0)
										{
											num++;
										}
									}
									stringBuilder.Append(text);
								}
								stringBuilder.Append("\\red" + Strings.Trim(value.R.ToString()));
								stringBuilder.Append("\\green" + Strings.Trim(value.G.ToString()));
								stringBuilder.Append("\\blue" + Strings.Trim(value.B.ToString()));
								stringBuilder.Append(";");
								stringBuilder.Append("}");
								int num5 = Strings.InStr(num4, selectedRtf, "\\pard", CompareMethod.Binary);
								stringBuilder.Append(Strings.Mid(selectedRtf, num4 + 2, num5 + 5 - num4 - 2));
								string text2 = Strings.Mid(selectedRtf, num5 + 5, selectedRtf.Length);
								if (Strings.InStr(text2, "\\cf", CompareMethod.Binary) > 0)
								{
									int start = Strings.InStr(2, text2, "\\", CompareMethod.Binary);
									stringBuilder.Append("\\cf" + num.ToString());
									stringBuilder.Append(Strings.Mid(text2, start, text2.Length));
								}
								else
								{
									stringBuilder.Append("\\cf" + num.ToString() + text2);
								}
								this.SelectedRtf = stringBuilder.ToString();
							}
						}
					}
					catch (Exception expr_22C)
					{
						ProjectData.SetProjectError(expr_22C);
						Interaction.MsgBox("设置结构化单元前景色失败", MsgBoxStyle.OkOnly, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindInstanceItem;
			}
			set
			{
				if (value != null)
				{
					this._BindInstanceItem = value;
					if (this._BindInstanceItem is NITextDesc)
					{
						this._Code = value.Code;
						this._Controller = new TextDescController();
						this._Controller.CurrentTextEdit = this;
						this._Controller.ActionManager = new ActionManager();
						this._Controller.SyncInstanceItem(this._BindInstanceItem);
						if (this.SelectionStart == -1)
						{
							this.SelectionStart = 0;
						}
						this.ReBuildRevRevisionHistory();
						this.ReDraw();
					}
					else if (this._BindInstanceItem is NISegment)
					{
						this._Code = value.Code;
						this._Controller = new SegmentController
						{
							Standalone = true
						};
						this._Controller.CurrentTextEdit = this;
						this._Controller.ActionManager = new ActionManager();
						this._Controller.SyncInstanceItem(this._BindInstanceItem);
						if (this.SelectionStart == -1)
						{
							this.SelectionStart = 0;
						}
						this.ReDraw();
					}
					if (this._BindInstanceItem.RevisionHistory != null)
					{
						this.AddRevTip(this._BindInstanceItem.RevisionHistory);
					}
				}
			}
		}

		public bool DisableAutoScroll
		{
			get
			{
				return this._DisableAutoScroll;
			}
			set
			{
				this._DisableAutoScroll = value;
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

		public PCTextEdit()
		{
			base.TextChanged += new EventHandler(this.PCTextEdit_TextChanged);
			base.KeyDown += new KeyEventHandler(this.PCTextEdit_KeyDown);
			base.KeyPress += new KeyPressEventHandler(this.PCTextEdit_KeyPress);
			base.GotFocus += new EventHandler(this.PCTextEdit_GetFocus);
			base.MouseDown += new MouseEventHandler(this.PCTextEdit_MouseDown);
			this._EditStatus = true;
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
			this.AcceptsTab = true;
			this.AllowDrop = true;
			this.BorderStyle = BorderStyle.Fixed3D;
		}

		private void Init()
		{
			this._EditStatus = this.Enabled;
			this.cmFormate = new ContextMenu();
			this.miFormate = new MenuItem("字体格式");
			this.miSpecChar = new MenuItem("特殊字符");
			this.miShowRevHis = new MenuItem("显示修改历史");
			this.BorderStyle = BorderStyle.Fixed3D;
			this.miFormate.Click += new EventHandler(this.OnFormate);
			this.miSpecChar.Click += new EventHandler(this.OnSpecChar);
			this.miShowRevHis.Click += new EventHandler(this.OnShowRevHis);
			this.miRISData = new MenuItem("检查数据");
			this.miLISData = new MenuItem("检验数据");
			this.miOrderData = new MenuItem("医嘱数据");
			this.miDiagnosData = new MenuItem("诊断维护");
			this.miRISData.Click += new EventHandler(this.OnRISData);
			this.miLISData.Click += new EventHandler(this.OnLISData);
			this.miOrderData.Click += new EventHandler(this.OnOrderData);
			this.miDiagnosData.Click += new EventHandler(this.OnDiagnosData);
			this.miCopy = new MenuItem("复制");
			this.miCopy.Tag = 1;
			this.miCopy.Click += new EventHandler(this.OnMiEdit);
			this.miPaste = new MenuItem("粘贴");
			this.miPaste.Tag = 2;
			this.miPaste.Click += new EventHandler(this.OnMiEdit);
			this.miUndo = new MenuItem("撤销");
			this.miUndo.Tag = 3;
			this.miUndo.Click += new EventHandler(this.OnMiEdit);
			this.miCut = new MenuItem("剪切");
			this.miCut.Tag = 4;
			this.miCut.Click += new EventHandler(this.OnMiEdit);
			this.miCopys = new MenuItem("复制收集器");
			this.miCopys.Tag = 5;
			this.miCopys.Click += new EventHandler(this.OnMiEdit);
			this.miEdit = new MenuItem("文字编辑");
			this.miEdit.MenuItems.Add(this.miCopy);
			this.miEdit.MenuItems.Add(this.miPaste);
			this.miEdit.MenuItems.Add(this.miUndo);
			this.miEdit.MenuItems.Add(this.miCut);
			this.miEdit.MenuItems.Add(this.miCopys);
		}

		public void InsertItem(NInstanceItem Value)
		{
			this._Controller.OnInsertItem(this.SelectionStart, Value);
		}

		public void AddItem(NInstanceItem Value)
		{
			this.BindInstanceItem.BindMMetaItem.SubItems.Add(Value.BindMMetaItem);
			this._Controller.OnInsertItem(this.Text.Length, Value);
		}

		public void ReplaceItem(NInstanceItem Value)
		{
			this._Controller.OnDelete(0, this.Text);
			this._Controller.OnInsertItem(0, Value);
		}

		public void NewRevice(string user, string rvdate, string rvtime)
		{
			this._ReviceUser = user;
			this._ReviceDate = rvdate;
			this._ReviceTime = rvtime;
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			this.RaiseOnReDraw();
		}

		public void ReDraw()
		{
			this.Clear();
			this._Controller.Draw(this);
			this.RaiseOnReDraw();
		}

		public void ReBuildRevRevisionHistory()
		{
			NInstanceItemEnumerator enumerator = this._BindInstanceItem.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (nInstanceItem.RevisionHistory != null)
				{
					if (this.BindInstanceItem.RevisionHistory == null)
					{
						RevisionHistory revisionHistory = new RevisionHistory();
						this.BindInstanceItem.RevisionHistory = revisionHistory;
					}
					try
					{
						IEnumerator enumerator2 = nInstanceItem.RevisionHistory.Revisions.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Revision value = (Revision)enumerator2.Current;
							this.BindInstanceItem.RevisionHistory.Revisions.Add(value);
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
			}
		}

		public void RefreshRevisionHistory()
		{
			if (this._BindInstanceItem is NITextDesc)
			{
				bool flag = false;
				NInstanceItemEnumerator enumerator = this._BindInstanceItem.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					if (nInstanceItem.RevisionHistory != null)
					{
						if (!flag)
						{
							RevisionHistory revisionHistory = new RevisionHistory();
							this.BindInstanceItem.RevisionHistory = revisionHistory;
						}
						try
						{
							IEnumerator enumerator2 = nInstanceItem.RevisionHistory.Revisions.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Revision value = (Revision)enumerator2.Current;
								this.BindInstanceItem.RevisionHistory.Revisions.Add(value);
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
				}
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long LockWindowUpdate(IntPtr hwndLock);

		[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int ImmGetContext(IntPtr hwnd);

		[DllImport("imm32.dll", CharSet = CharSet.Ansi, EntryPoint = "ImmGetCompositionStringA", ExactSpelling = true, SetLastError = true)]
		private static extern int ImmGetCompositionString(int himc, int dw, [MarshalAs(UnmanagedType.LPArray)] byte[] lpstr, int dw2);

		[DllImport("imm32.dll", CharSet = CharSet.Ansi, EntryPoint = "ImmEscapeA", ExactSpelling = true, SetLastError = true)]
		private static extern int ImmEscape(long hKL, long hIMC, long un, [MarshalAs(UnmanagedType.LPArray)] byte[] lpstr);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetKeyboardLayout(int dwLayout);

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
		private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		protected override void WndProc(ref Message m)
		{
			checked
			{
				if (this._EditStatus)
				{
					int msg = m.Msg;
					if (msg == 269)
					{
						int keyboardLayout = PCTextEdit.GetKeyboardLayout(0);
						if (keyboardLayout == -536606716)
						{
							base.WndProc(ref m);
						}
					}
					else if (msg == 277)
					{
						if (!this._DisableAutoScroll)
						{
							base.WndProc(ref m);
						}
					}
					else if (msg == 276)
					{
						if (!this._DisableAutoScroll)
						{
							base.WndProc(ref m);
						}
					}
					else if (msg == 271)
					{
						if ((m.LParam.ToInt32() & 2048) > 0)
						{
							int himc = PCTextEdit.ImmGetContext(m.HWnd);
							int num = PCTextEdit.ImmGetCompositionString(himc, 2048, null, 0);
							byte[] array = new byte[num - 1 + 1];
							PCTextEdit.ImmGetCompositionString(himc, 2048, array, num);
							string @string = Encoding.Default.GetString(array);
							this._Controller.OnInsertString(this.SelectionStart, @string);
						}
						else
						{
							base.WndProc(ref m);
						}
					}
					else if (msg == 515)
					{
						this._Controller.OnDoubleClick(this.SelectionStart);
					}
					else if (msg == 513)
					{
						int num2 = m.LParam.ToInt32();
						int num3 = (int)(unchecked(((long)num2 & 32767L) | (long)(((-(((((long)num2 & 32768L) != 0L) > false) ? 1 : 0)) ? 1 : 0) & 32768)));
						int num4 = (num2 & 2147418112) / 65536 | ((unchecked(-((((num2 & -2147483648) != 0) > false) ? 1 : 0)) ? 1 : 0) & 32768);
						Point pt = new Point(num3, num4);
						int num5 = this.GetCharIndexFromPosition(pt);
						if (num5 <= this.Text.Length - 1)
						{
							Point positionFromCharIndex = this.GetPositionFromCharIndex(num5);
							if (num3 > positionFromCharIndex.X + 10 | num4 > positionFromCharIndex.Y + 10)
							{
								num5++;
							}
						}
						pt = new Point(1, 1);
						int charIndexFromPosition = this.GetCharIndexFromPosition(pt);
						this._Controller.OnCursorMove(this.SelectionStart, num5);
						base.WndProc(ref m);
						this.SelectionStart = this.Text.Length;
						this.SelectionStart = charIndexFromPosition;
						this.SelectionStart = num5;
					}
					else
					{
						base.WndProc(ref m);
					}
				}
				else
				{
					switch (m.Msg)
					{
					case 276:
						if (!this._DisableAutoScroll)
						{
							base.WndProc(ref m);
						}
						break;
					case 277:
						if (!this._DisableAutoScroll)
						{
							base.WndProc(ref m);
						}
						break;
					default:
						base.WndProc(ref m);
						break;
					}
				}
			}
		}

		private void PCTextEdit_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				if (this._EditStatus && !this.ReadOnly)
				{
					switch (e.KeyCode)
					{
					case Keys.Back:
						if (this.SelectionStart >= 0)
						{
							if (this.SelectionLength > 0)
							{
								string value = this.SelectedText;
								this._Controller.OnDelete(this.SelectionStart, value);
							}
							else if (this.SelectionStart > 0)
							{
								string value = this.Text.Substring(this.SelectionStart - 1, 1);
								this._Controller.OnDelete(this.SelectionStart - 1, value);
							}
							e.Handled = true;
						}
						break;
					case Keys.Return:
						if (this.SelectionLength > 0)
						{
							this._Controller.OnDelete(this.SelectionStart, this.SelectedText);
						}
						this._Controller.OnEnterKeyDown(this.SelectionStart);
						e.Handled = true;
						break;
					case Keys.End:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								int num = PCTextEdit.SendMessage(this.Handle.ToInt32(), 187, -1, 0);
								int num2 = PCTextEdit.SendMessage(this.Handle.ToInt32(), 193, -1, 0);
								this._Controller.OnCursorMove(this.SelectionStart, num + num2);
							}
							e.Handled = true;
						}
						break;
					case Keys.Home:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								int destPos = PCTextEdit.SendMessage(this.Handle.ToInt32(), 187, -1, 0);
								this._Controller.OnCursorMove(this.SelectionStart, destPos);
							}
							e.Handled = true;
						}
						break;
					case Keys.Left:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								this._Controller.OnCursorMove(this.SelectionStart, this.SelectionStart - 1);
							}
							e.Handled = true;
						}
						break;
					case Keys.Up:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								int selectionStart = this.SelectionStart;
								int num3 = PCTextEdit.SendMessage(this.Handle.ToInt32(), 201, selectionStart, 0);
								if (num3 > 0)
								{
									int num4 = 0;
									int arg_257_0 = 0;
									int num5 = num3 - 2;
									for (int i = arg_257_0; i <= num5; i++)
									{
										int wParam = PCTextEdit.SendMessage(this.Handle.ToInt32(), 187, i, 0);
										num4 += PCTextEdit.SendMessage(this.Handle.ToInt32(), 193, wParam, 0);
										if (char.IsWhiteSpace(this.Text, num4))
										{
											num4++;
										}
									}
									Point positionFromCharIndex = this.GetPositionFromCharIndex(num4);
									Point pt;
									pt.X = this.GetPositionFromCharIndex(selectionStart).X;
									pt.Y = positionFromCharIndex.Y;
									int charIndexFromPosition = this.GetCharIndexFromPosition(pt);
									this._Controller.OnCursorMove(this.SelectionStart, charIndexFromPosition);
								}
							}
							e.Handled = true;
						}
						break;
					case Keys.Right:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								this._Controller.OnCursorMove(this.SelectionStart, this.SelectionStart + 1);
							}
							e.Handled = true;
						}
						break;
					case Keys.Down:
						if (Control.ModifierKeys == Keys.None)
						{
							if (this.SelectionLength > 0)
							{
								this.SelectionLength = 0;
							}
							else
							{
								int selectionStart2 = this.SelectionStart;
								int num6 = PCTextEdit.SendMessage(this.Handle.ToInt32(), 186, 0, 0);
								int num7 = PCTextEdit.SendMessage(this.Handle.ToInt32(), 201, selectionStart2, 0);
								if (num7 < num6 - 1)
								{
									int num8 = 0;
									int arg_383_0 = 0;
									int num9 = num7;
									for (int j = arg_383_0; j <= num9; j++)
									{
										int wParam2 = PCTextEdit.SendMessage(this.Handle.ToInt32(), 187, j, 0);
										num8 += PCTextEdit.SendMessage(this.Handle.ToInt32(), 193, wParam2, 0);
										if (char.IsWhiteSpace(this.Text, num8))
										{
											num8++;
										}
									}
									Point positionFromCharIndex2 = this.GetPositionFromCharIndex(num8);
									Point pt2;
									pt2.X = this.GetPositionFromCharIndex(selectionStart2).X;
									pt2.Y = positionFromCharIndex2.Y;
									int charIndexFromPosition2 = this.GetCharIndexFromPosition(pt2);
									this._Controller.OnCursorMove(this.SelectionStart, charIndexFromPosition2);
								}
							}
							e.Handled = true;
						}
						break;
					case Keys.Insert:
						this.DoInsert();
						break;
					case Keys.Delete:
						if (this.SelectionStart != this.Text.Length)
						{
							string value2;
							if (this.SelectionLength > 0)
							{
								value2 = this.SelectedText;
							}
							else
							{
								value2 = Strings.Mid(this.Text, this.SelectionStart + 1, 1);
							}
							this._Controller.OnDelete(this.SelectionStart, value2);
						}
						e.Handled = true;
						break;
					case Keys.C:
						if ((Control.ModifierKeys & Keys.Control) > Keys.None)
						{
							this.doCopy();
							e.Handled = true;
						}
						break;
					case Keys.V:
						if ((Control.ModifierKeys & Keys.Control) > Keys.None)
						{
							this.doPaste();
							e.Handled = true;
						}
						break;
					case Keys.X:
						if ((Control.ModifierKeys & Keys.Control) > Keys.None)
						{
							this.doCut();
							e.Handled = true;
						}
						break;
					case Keys.Y:
						if ((Control.ModifierKeys & Keys.Control) > Keys.None)
						{
							this._Controller.OnRedo();
							e.Handled = true;
						}
						break;
					case Keys.Z:
						if ((Control.ModifierKeys & Keys.Control) > Keys.None)
						{
							this.doUndo();
							e.Handled = true;
						}
						break;
					}
					if (e.KeyCode == Keys.ProcessKey && !this.IsCommandKeyDown(e) && this.SelectionStart != this.Text.Length && this.SelectionLength > 0)
					{
						this._Controller.OnDelete(this.SelectionStart, this.SelectedText);
					}
				}
			}
		}

		private bool IsCommandKeyDown(KeyEventArgs e)
		{
			if (!e.Control)
			{
				if (!e.Alt)
				{
					if (!e.Shift)
					{
						return false;
					}
				}
			}
			return true;
		}

		private void DoInsert()
		{
			if (this.Text.Length == 0 && this.Parent is PPanel && this._BindInstanceItem is NISegment)
			{
				NISegment nISegment = (NISegment)this._BindInstanceItem;
				if (nISegment.AbNormalSupport)
				{
					NISegment nISegment2 = (NISegment)nISegment.Clone();
					if (nISegment.IsAbNormal)
					{
						nISegment.IsAbNormal = false;
						nISegment.SubItems = nISegment2.NormalSubItems;
						nISegment.FormatRangeCollection = nISegment2.NormalFormatRangeCollection;
						nISegment.SyncMetaItem(nISegment.BindMMetaItem);
						this.BindInstanceItem = nISegment;
					}
					else
					{
						nISegment.IsAbNormal = true;
						nISegment.SubItems = nISegment2.AbNormalSubItems;
						nISegment.FormatRangeCollection = nISegment2.AbNormalFormatRangeCollection;
						nISegment.SyncMetaItem(nISegment.BindMMetaItem);
						this.BindInstanceItem = nISegment;
					}
				}
			}
		}

		private void PCTextEdit_KeyPress(object sender, KeyPressEventArgs e)
		{
			int count = this._Controller.SubItems.Count;
			if (this._EditStatus & !this.ReadOnly)
			{
				if (e.KeyChar > '\u001f')
				{
					int selectionStart = this.SelectionStart;
					if (this.SelectionLength > 0)
					{
						string selectedText = this.SelectedText;
						this._Controller.OnDelete(this.SelectionStart, selectedText);
					}
					this._Controller.OnInsertString(this.SelectionStart, e.KeyChar.ToString());
					e.Handled = true;
				}
				if (e.KeyChar == '\t')
				{
					if ((Control.ModifierKeys & Keys.Shift) > Keys.None)
					{
						this._Controller.OnTabKeyPressed(this.SelectionStart, false);
					}
					else
					{
						this._Controller.OnTabKeyPressed(this.SelectionStart, true);
					}
					e.Handled = true;
				}
			}
		}

		private void PCTextEdit_GetFocus(object sender, EventArgs e)
		{
			PCTextEdit.objPCTExitFrm = this;
			if (this.BindInstanceItem != null && this.BindInstanceItem.BindMMetaItem is MITextDesc)
			{
				string bindKBBaseID = ((MITextDesc)this.BindInstanceItem.BindMMetaItem).BindKBBaseID;
				int kbPartNo = Convert.ToInt32((int)((MITextDesc)this.BindInstanceItem.BindMMetaItem).BindKBPart);
				PCTextEdit.GetFocusHandler onPCTextEditGetFocusEvent = this.OnPCTextEditGetFocusEvent;
				if (onPCTextEditGetFocusEvent != null)
				{
					onPCTextEditGetFocusEvent(this.Code, bindKBBaseID, kbPartNo);
				}
			}
		}

		private void PCTextEdit_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left && e.Button == MouseButtons.Right)
			{
				this.cmFormate.MenuItems.Clear();
				if (this._EditStatus)
				{
					if (this.cmFormate.MenuItems.IndexOf(this.miFormate) < 0)
					{
						this.cmFormate.MenuItems.Add(this.miFormate);
					}
					if (this.cmFormate.MenuItems.IndexOf(this.miSpecChar) < 0)
					{
						this.cmFormate.MenuItems.Add(this.miSpecChar);
					}
					if (this.cmFormate.MenuItems.IndexOf(this.miRISData) < 0 && Operators.CompareString(SysOptionManager.GetSysOptionValue("RISCitation", ""), "Y", false) == 0)
					{
						this.cmFormate.MenuItems.Add(this.miRISData);
					}
					if (this.cmFormate.MenuItems.IndexOf(this.miLISData) < 0 && Operators.CompareString(SysOptionManager.GetSysOptionValue("LISCitation", ""), "Y", false) == 0)
					{
						this.cmFormate.MenuItems.Add(this.miLISData);
					}
					if (this.cmFormate.MenuItems.IndexOf(this.miOrderData) < 0 && Operators.CompareString(SysOptionManager.GetSysOptionValue("OrderCitation", ""), "Y", false) == 0)
					{
						this.cmFormate.MenuItems.Add(this.miOrderData);
					}
					if (this.cmFormate.MenuItems.IndexOf(this.miDiagnosData) < 0 && Operators.CompareString(SysOptionManager.GetSysOptionValue("DiagnosCitation", ""), "Y", false) == 0)
					{
						this.cmFormate.MenuItems.Add(this.miDiagnosData);
					}
					if (CommonFuncs.CanCopyPaste && this.cmFormate.MenuItems.IndexOf(this.miEdit) < 0)
					{
						this.cmFormate.MenuItems.Add(this.miEdit);
					}
				}
				else if (this.BindInstanceItem.RevStatus)
				{
					try
					{
						IEnumerator enumerator = this.BindInstanceItem.RevisionHistory.Revisions.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Revision revision = (Revision)enumerator.Current;
							MenuItem menuItem = new MenuItem();
							menuItem.Text = string.Concat(new string[]
							{
								revision.RevPerson,
								"，",
								revision.RevTime,
								"，",
								revision.RevIP
							});
							menuItem.Click += new EventHandler(this.ChangeRevHis);
							this.cmFormate.MenuItems.Add(menuItem);
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
				if ((this.BindInstanceItem.RevStatus & this.cmFormate.MenuItems.IndexOf(this.miShowRevHis) < 0 & this.BindInstanceItem.RevisionHistory != null) && this.BindInstanceItem.RevisionHistory.Revisions.Count > 0)
				{
					this.cmFormate.MenuItems.Add(this.miShowRevHis);
				}
				ContextMenu arg_350_0 = this.cmFormate;
				Point pos = new Point(e.X, e.Y);
				arg_350_0.Show(this, pos);
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
			reader.Read();
			if (!reader.IsEmptyElement && Operators.CompareString(reader.Name, "ReadOnly", false) == 0)
			{
				reader.Read();
				this.ReadOnly = Convert.ToBoolean(reader.Value);
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}

		public void OnFormate(object sender, EventArgs e)
		{
			if (this.SelectionLength > 0)
			{
				int selectionStart = this.SelectionStart;
				int destpos = checked(this.SelectionStart + this.SelectionLength);
				FontStruct fontStruct = new FontStruct(this.SelectionFont);
				fontStruct.CharOffset = this.SelectionCharOffset;
				fontStruct.ResetFontSize(this.Font.Size);
				FormateForm formateForm = new FormateForm();
				formateForm.OldFontStruct = fontStruct;
				Point formPosition = this.PointToScreen(this.GetPositionFromCharIndex(this.SelectionStart));
				formateForm.SetFormPosition(formPosition);
				if (formateForm.ShowDialog() == DialogResult.OK)
				{
					FontStruct newFontStruct = formateForm.NewFontStruct;
					this._Controller.OnFormate(selectionStart, destpos, fontStruct, newFontStruct);
				}
			}
		}

		public void OnSpecChar(object sender, EventArgs e)
		{
			SpecCharForm specCharForm = new SpecCharForm();
			Point formPosition = this.PointToScreen(this.GetPositionFromCharIndex(this.SelectionStart));
			specCharForm.SetFormPosition(formPosition);
			if (specCharForm.ShowDialog() == DialogResult.OK && !(specCharForm.CurrentSpecChar == null | Operators.CompareString(specCharForm.CurrentSpecChar, "", false) == 0))
			{
				this._Controller.OnInsertString(this.SelectionStart, specCharForm.CurrentSpecChar);
			}
		}

		public void OnRISData(object sender, EventArgs e)
		{
			Point positionFromCharIndex = this.GetPositionFromCharIndex(this.SelectionStart);
			Point screenPoint = this.PointToScreen(positionFromCharIndex);
			dhcc.epr.eprlib.presentation.dictionary.IDictionary dic = DicFactory.Instance.getDic("PACSDictionary");
			MIDictionary midic = new MIDictionary();
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, screenPoint, niDic, "", "");
			if (dicContent != null && Operators.CompareString(dicContent.Description, "", false) != 0)
			{
				this._Controller.OnInsertString(this.SelectionStart, dicContent.Description);
			}
		}

		public void OnLISData(object sender, EventArgs e)
		{
			Point positionFromCharIndex = this.GetPositionFromCharIndex(this.SelectionStart);
			Point screenPoint = this.PointToScreen(positionFromCharIndex);
			dhcc.epr.eprlib.presentation.dictionary.IDictionary dic = DicFactory.Instance.getDic("LISDictionary");
			MIDictionary midic = new MIDictionary();
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, screenPoint, niDic, "", "");
			if (dicContent != null && Operators.CompareString(dicContent.Description, "", false) != 0)
			{
				this._Controller.OnInsertString(this.SelectionStart, dicContent.Description);
			}
		}

		public void OnOrderData(object sender, EventArgs e)
		{
			Point positionFromCharIndex = this.GetPositionFromCharIndex(this.SelectionStart);
			Point screenPoint = this.PointToScreen(positionFromCharIndex);
			dhcc.epr.eprlib.presentation.dictionary.IDictionary dic = DicFactory.Instance.getDic("OrdersDictionary");
			MIDictionary midic = new MIDictionary();
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, screenPoint, niDic, "", "");
			if (dicContent != null && Operators.CompareString(dicContent.Description, "", false) != 0)
			{
				this._Controller.OnInsertString(this.SelectionStart, dicContent.Description);
			}
		}

		public void OnDiagnosData(object sender, EventArgs e)
		{
			Point positionFromCharIndex = this.GetPositionFromCharIndex(this.SelectionStart);
			Point screenPoint = this.PointToScreen(positionFromCharIndex);
			dhcc.epr.eprlib.presentation.dictionary.IDictionary dic = DicFactory.Instance.getDic("DiagnosDictionary");
			MIDictionary midic = new MIDictionary();
			string strQuery = string.Empty;
			if (this._BindInstanceItem.BindMMetaItem is MISegment)
			{
				MISegment mISegment = new MISegment();
				mISegment = (MISegment)this._BindInstanceItem.BindMMetaItem;
				strQuery = mISegment.BindDefaultDiagnosType;
			}
			else if (this._BindInstanceItem.BindMMetaItem is MITextDesc)
			{
				MITextDesc mITextDesc = new MITextDesc();
				mITextDesc = (MITextDesc)this._BindInstanceItem.BindMMetaItem;
				strQuery = mITextDesc.BindDefaultDiagnosType;
			}
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, screenPoint, niDic, strQuery, "");
			if (dicContent != null && Operators.CompareString(dicContent.Description, "", false) != 0)
			{
				if (this.ReadOnly)
				{
					this._Controller.OnDelete(0, this.Text);
					this._Controller.OnInsertString(0, dicContent.Description);
				}
				else
				{
					this._Controller.OnInsertString(this.SelectionStart, dicContent.Description);
				}
			}
		}

		private void OnMiEdit(object sender, EventArgs e)
		{
			MenuItem menuItem = (MenuItem)sender;
			if (menuItem == null)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(menuItem.Tag, 1, false))
			{
				this.doCopy();
			}
			else if (Operators.ConditionalCompareObjectEqual(menuItem.Tag, 2, false))
			{
				this.doPaste();
			}
			else if (Operators.ConditionalCompareObjectEqual(menuItem.Tag, 3, false))
			{
				this.doUndo();
			}
			else if (Operators.ConditionalCompareObjectEqual(menuItem.Tag, 4, false))
			{
				this.doCut();
			}
			else if (Operators.ConditionalCompareObjectEqual(menuItem.Tag, 5, false))
			{
				this.doCopys();
			}
			this.RaiseOnReDraw();
		}

		private void doCopy()
		{
			if (Operators.CompareString(this.SelectedText, "", false) != 0 && CommonFuncs.CanCopyPaste)
			{
				Clipboard.SetDataObject(this.SelectedText);
			}
			if (PCTextEdit.FmMulitCopy != null && PCTextEdit.FmMulitCopy.OpenFlag)
			{
				IDataObject dataObject = Clipboard.GetDataObject();
				string copyString = Conversions.ToString(dataObject.GetData(DataFormats.Text));
				PCTextEdit.FmMulitCopy.CopyString = copyString;
			}
		}

		private void doPaste()
		{
			if (!this.ReadOnly && CommonFuncs.CanCopyPaste)
			{
				IDataObject dataObject = Clipboard.GetDataObject();
				if (dataObject.GetDataPresent(DataFormats.Text))
				{
					string strClip = Conversions.ToString(dataObject.GetData(DataFormats.Text));
					this.PastAct(strClip);
				}
			}
		}

		private void doUndo()
		{
			this._Controller.OnUndo();
		}

		private void doCut()
		{
			if (Operators.CompareString(this.SelectedText, "", false) != 0 && CommonFuncs.CanCopyPaste)
			{
				Clipboard.SetDataObject(this.SelectedText);
				this._Controller.OnDelete(this.SelectionStart, this.SelectedText);
			}
		}

		private void doCopys()
		{
			if (PCTextEdit.FmMulitCopy == null)
			{
				PCTextEdit.FmMulitCopy = new MulitCopy();
				Size size = new Size(checked(this.Location.X + this.Width), this.Location.Y);
				Point formPosition = this.PointToScreen((Point)size);
				PCTextEdit.FmMulitCopy.SetFormPosition(formPosition);
				PCTextEdit.FmMulitCopy.Show(this);
			}
		}

		public void PastAct(string strClip)
		{
			int num = 0;
			checked
			{
				do
				{
					if (strClip[num] == '\n')
					{
						strClip = strClip.Remove(num, 1);
						num--;
					}
					num++;
				}
				while (num != strClip.Length);
				if (!this.HasIllegalChar(strClip))
				{
					if (this.SelectionLength > 0)
					{
						this._Controller.OnDelete(this.SelectionStart, this.SelectedText);
					}
					this._Controller.OnInsertString(this.SelectionStart, strClip);
				}
			}
		}

		public void MoveCursor(int intpos, int endpos)
		{
			this._Controller.OnCursorMove(intpos, endpos);
		}

		private void PCTextEdit_TextChanged(object sender, EventArgs e)
		{
			if (this._BindInstanceItem != null & !this.boolUpdate)
			{
				if (this._BindInstanceItem is NISegment)
				{
					if (((MISegment)this._BindInstanceItem.BindMMetaItem).StopRaiseVChanged)
					{
						return;
					}
				}
				else if (this._BindInstanceItem is NITextDesc && ((MITextDesc)this._BindInstanceItem.BindMMetaItem).StopRaiseVChanged)
				{
					return;
				}
				PCTextEdit.VChangedEventHandler vChangedEvent = this.VChangedEvent;
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
				this.curLabel.Left = 0;
				this.curLabel.Tag = revHis;
				this.Controls.Add(this.curLabel);
				this.curLabel.BringToFront();
			}
		}

		private void TipLabel_MouseEnter(object sender, EventArgs e)
		{
			if (this.curTip == null)
			{
				this.curTip = new RichTextBox();
				this.curTip.BackColor = SystemColors.Info;
				this.curTip.BorderStyle = BorderStyle.FixedSingle;
			}
			Control control = (Control)sender;
			RevisionHistory revisionHistory = (RevisionHistory)control.Tag;
			string text = "";
			try
			{
				IEnumerator enumerator = revisionHistory.Revisions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Revision revision = (Revision)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text + revision.RevPerson + "，" + revision.RevTime + "在", Interaction.IIf(revision.RevIP == null || revision.RevIP.Equals(string.Empty), "未知位置", revision.RevIP)), "\r\n"));
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text + "从 ", NewLateBinding.LateGet(revision.SubRevisions[0], null, "Content", new object[0], null, null, null)), " 改为 【"), NewLateBinding.LateGet(revision.SubRevisions[1], null, "Content", new object[0], null, null, null)), "】"), "\r\n"));
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
			this.curTip.Text = text;
			Graphics graphics = Graphics.FromHwnd(this.curTip.Handle);
			SizeF sizeF = graphics.MeasureString(this.curTip.Text, this.curTip.Font, this.Width);
			this.curTip.Top = this.Top;
			this.curTip.Width = this.Width;
			this.curTip.Height = this.Height;
			this.curTip.Left = this.Left;
			if (checked(this.curTip.Top + this.curTip.Height) > this.Parent.ClientSize.Height)
			{
				this.curTip.DoubleClick += new EventHandler(this.TipLabel_DoubleClick);
			}
			else
			{
				this.curLabel.MouseLeave += new EventHandler(this.TipLabel_MouseLeave);
			}
			this.Parent.Controls.Add(this.curTip);
			this.curTip.BringToFront();
		}

		private void TipLabel_MouseLeave(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this.curTip);
			this.curTip = null;
		}

		private void TipLabel_DoubleClick(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this.curTip);
			this.curTip = null;
		}

		public void OnShowRevHis(object sender, EventArgs e)
		{
			if (this._EditStatus)
			{
				this._EditStatus = false;
				this.miShowRevHis.Text = "返回编辑界面";
				PCTextEdit.LockWindowUpdate(this.Handle);
				this.Clear();
				NewLateBinding.LateCall(this.BindInstanceItem.RevisionHistory.Revisions[checked(this.BindInstanceItem.RevisionHistory.Revisions.Count - 1)], null, "Draw", new object[]
				{
					this
				}, null, null, null, true);
				IntPtr hwndLock;
				PCTextEdit.LockWindowUpdate(hwndLock);
				this.ReadOnly = true;
			}
			else
			{
				this._EditStatus = true;
				this.ReadOnly = false;
				this.miShowRevHis.Text = "显示修改历史";
				this.ReDraw();
			}
		}

		public void ChangeRevHis(object sender, EventArgs e)
		{
			int index = this.cmFormate.MenuItems.IndexOf((MenuItem)sender);
			this.ReadOnly = false;
			PCTextEdit.LockWindowUpdate(this.Handle);
			this.Clear();
			NewLateBinding.LateCall(this.BindInstanceItem.RevisionHistory.Revisions[index], null, "Draw", new object[]
			{
				this
			}, null, null, null, true);
			IntPtr hwndLock;
			PCTextEdit.LockWindowUpdate(hwndLock);
			this.ReadOnly = true;
		}

		private bool HasIllegalChar(string str)
		{
			bool result = false;
			string str2 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
			string xml = str2 + "<TextEditData>" + str.Replace("&", "").Replace("<", "") + "</TextEditData>";
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
			}
			catch (Exception expr_49)
			{
				ProjectData.SetProjectError(expr_49);
				MessageBox.Show("输入内容含有非法字符！");
				result = true;
				ProjectData.ClearProjectError();
			}
			return result;
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
			return null;
		}

		public CheckMsg SpecialCheck()
		{
			return null;
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
