using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class KeyDownGrid : DataGrid
	{
		public delegate void EnterKeyDownEventHandler();

		public delegate void PageUpKeyDownEventHandler();

		public delegate void PageDownKeyDownEventHandler();

		public delegate void TabKeyDownEventHandler();

		public delegate void EscKeyDownEventHandler();

		public delegate void BackspaceKeyDownEventHandler();

		private KeyDownGrid.EnterKeyDownEventHandler EnterKeyDownEvent;

		private KeyDownGrid.PageUpKeyDownEventHandler PageUpKeyDownEvent;

		private KeyDownGrid.PageDownKeyDownEventHandler PageDownKeyDownEvent;

		private KeyDownGrid.TabKeyDownEventHandler TabKeyDownEvent;

		private KeyDownGrid.EscKeyDownEventHandler EscKeyDownEvent;

		private KeyDownGrid.BackspaceKeyDownEventHandler BackspaceKeyDownEvent;

		private const int WM_KEYDOWN = 256;

		public event KeyDownGrid.EnterKeyDownEventHandler EnterKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.EnterKeyDownEvent = (KeyDownGrid.EnterKeyDownEventHandler)Delegate.Combine(this.EnterKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.EnterKeyDownEvent = (KeyDownGrid.EnterKeyDownEventHandler)Delegate.Remove(this.EnterKeyDownEvent, value);
			}
		}

		public event KeyDownGrid.PageUpKeyDownEventHandler PageUpKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.PageUpKeyDownEvent = (KeyDownGrid.PageUpKeyDownEventHandler)Delegate.Combine(this.PageUpKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.PageUpKeyDownEvent = (KeyDownGrid.PageUpKeyDownEventHandler)Delegate.Remove(this.PageUpKeyDownEvent, value);
			}
		}

		public event KeyDownGrid.PageDownKeyDownEventHandler PageDownKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.PageDownKeyDownEvent = (KeyDownGrid.PageDownKeyDownEventHandler)Delegate.Combine(this.PageDownKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.PageDownKeyDownEvent = (KeyDownGrid.PageDownKeyDownEventHandler)Delegate.Remove(this.PageDownKeyDownEvent, value);
			}
		}

		public event KeyDownGrid.TabKeyDownEventHandler TabKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.TabKeyDownEvent = (KeyDownGrid.TabKeyDownEventHandler)Delegate.Combine(this.TabKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.TabKeyDownEvent = (KeyDownGrid.TabKeyDownEventHandler)Delegate.Remove(this.TabKeyDownEvent, value);
			}
		}

		public event KeyDownGrid.EscKeyDownEventHandler EscKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.EscKeyDownEvent = (KeyDownGrid.EscKeyDownEventHandler)Delegate.Combine(this.EscKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.EscKeyDownEvent = (KeyDownGrid.EscKeyDownEventHandler)Delegate.Remove(this.EscKeyDownEvent, value);
			}
		}

		public event KeyDownGrid.BackspaceKeyDownEventHandler BackspaceKeyDown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.BackspaceKeyDownEvent = (KeyDownGrid.BackspaceKeyDownEventHandler)Delegate.Combine(this.BackspaceKeyDownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.BackspaceKeyDownEvent = (KeyDownGrid.BackspaceKeyDownEventHandler)Delegate.Remove(this.BackspaceKeyDownEvent, value);
			}
		}

		[DebuggerNonUserCode]
		public KeyDownGrid()
		{
		}

		public override bool PreProcessMessage(ref Message msg)
		{
			Keys keys = (Keys)(msg.WParam.ToInt32() & 65535);
			if (msg.Msg == 256 & keys == Keys.Return)
			{
				KeyDownGrid.EnterKeyDownEventHandler enterKeyDownEvent = this.EnterKeyDownEvent;
				if (enterKeyDownEvent != null)
				{
					enterKeyDownEvent();
				}
			}
			else if (msg.Msg == 256 & (keys == Keys.Prior | keys == Keys.Left))
			{
				KeyDownGrid.PageUpKeyDownEventHandler pageUpKeyDownEvent = this.PageUpKeyDownEvent;
				if (pageUpKeyDownEvent != null)
				{
					pageUpKeyDownEvent();
				}
			}
			else if (msg.Msg == 256 & (keys == Keys.Next | keys == Keys.Right))
			{
				KeyDownGrid.PageDownKeyDownEventHandler pageDownKeyDownEvent = this.PageDownKeyDownEvent;
				if (pageDownKeyDownEvent != null)
				{
					pageDownKeyDownEvent();
				}
			}
			else if (msg.Msg == 256 & keys == Keys.Tab)
			{
				KeyDownGrid.TabKeyDownEventHandler tabKeyDownEvent = this.TabKeyDownEvent;
				if (tabKeyDownEvent != null)
				{
					tabKeyDownEvent();
				}
			}
			else if (msg.Msg == 256 & keys == Keys.Escape)
			{
				KeyDownGrid.EscKeyDownEventHandler escKeyDownEvent = this.EscKeyDownEvent;
				if (escKeyDownEvent != null)
				{
					escKeyDownEvent();
				}
			}
			else
			{
				if (!(msg.Msg == 256 & keys == Keys.Back))
				{
					return base.PreProcessMessage(ref msg);
				}
				KeyDownGrid.BackspaceKeyDownEventHandler backspaceKeyDownEvent = this.BackspaceKeyDownEvent;
				if (backspaceKeyDownEvent != null)
				{
					backspaceKeyDownEvent();
				}
			}
			return true;
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Delete)
			{
				KeyDownGrid.EnterKeyDownEventHandler enterKeyDownEvent = this.EnterKeyDownEvent;
				if (enterKeyDownEvent != null)
				{
					enterKeyDownEvent();
				}
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}
	}
}
