using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	public class ListViewEx : ListView
	{
		public delegate void ScrollDlg();

		private const int WM_HSCROLL = 276;

		private const int WM_VSCROLL = 277;

		private const int WM_MOUSEWHEEL = 522;

		private const int WM_LBUTTONDBLCLK = 515;

		private const int VSCROLL_BAR = 1;

		private TextBox txtBox = new TextBox
		{
			Visible = false
		};

		private int editColumn = -1;

		private bool checkChangeOnDoubleClick;

		[Description("VerticalScrollToEnd")]
		public event ListViewEx.ScrollDlg VScrollToEnd
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VScrollToEnd = (ListViewEx.ScrollDlg)Delegate.Combine(this.VScrollToEnd, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VScrollToEnd = (ListViewEx.ScrollDlg)Delegate.Remove(this.VScrollToEnd, value);
			}
		}

		public int EditColumn
		{
			get
			{
				return this.editColumn;
			}
			set
			{
				this.editColumn = value;
			}
		}

		[Description("是否允许通过双击来选中复选框")]
		public bool CheckChangeOnDoubleClick
		{
			set
			{
				this.checkChangeOnDoubleClick = value;
			}
		}

		public ListViewEx()
		{
			base.Controls.Add(this.txtBox);
			this.txtBox.KeyPress += delegate(object sender, KeyPressEventArgs e)
			{
				if ('\r' == e.KeyChar)
				{
					this.txtBox_Leave(sender, null);
				}
			};
			base.LabelEdit = false;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 276)
			{
				this.txtBox.Visible = false;
			}
			else if (m.Msg == 277)
			{
				this.txtBox.Visible = false;
				if (this.isVScrollToEnd() && this.VScrollToEnd != null)
				{
					this.VScrollToEnd();
				}
			}
			else if (m.Msg == 522)
			{
				this.txtBox.Visible = false;
			}
			else if (m.Msg == 515)
			{
				this.showTextBox();
				base.WndProc(ref m);
				if (!this.checkChangeOnDoubleClick)
				{
					Point point = base.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
					ListViewItem itemAt = base.GetItemAt(point.X, point.Y);
					if (itemAt != null)
					{
						itemAt.Checked = !itemAt.Checked;
						return;
					}
				}
			}
			base.WndProc(ref m);
		}

		protected override void OnDoubleClick(EventArgs e)
		{
			if (this.showTextBox())
			{
				return;
			}
			base.OnDoubleClick(e);
		}

		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			this.txtBox.Visible = false;
			base.OnSelectedIndexChanged(e);
		}

		private bool showTextBox()
		{
			if (this.editColumn >= 0)
			{
				Point point = base.PointToClient(Cursor.Position);
				ListViewItem item = base.HitTest(point).Item;
				ListViewItem.ListViewSubItem subItem = base.HitTest(point).SubItem;
				if (subItem != null)
				{
					int num = item.SubItems.IndexOf(subItem);
					if (num > 0 && (this.editColumn == 0 || this.editColumn == num))
					{
						this.EditItem(subItem);
						return true;
					}
				}
			}
			return false;
		}

		private void EditItem(ListViewItem.ListViewSubItem subItem)
		{
			Rectangle bounds = subItem.Bounds;
			this.txtBox.Bounds = bounds;
			this.txtBox.BringToFront();
			this.txtBox.Text = subItem.Text;
			this.txtBox.Leave += new EventHandler(this.txtBox_Leave);
			this.txtBox.TextChanged += new EventHandler(this.txtBox_TextChanged);
			this.txtBox.Visible = true;
			this.txtBox.Tag = subItem;
			this.txtBox.Select();
		}

		private void txtBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			ListViewItem.ListViewSubItem listViewSubItem = textBox.Tag as ListViewItem.ListViewSubItem;
			if (listViewSubItem != null)
			{
				listViewSubItem.Text = textBox.Text;
			}
		}

		private void txtBox_Leave(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			textBox.TextChanged -= new EventHandler(this.txtBox_TextChanged);
			textBox.Tag = null;
			textBox.Visible = false;
		}

		private bool isVScrollToEnd()
		{
			SCROLLINFO sCROLLINFO = default(SCROLLINFO);
			sCROLLINFO.cbSize = (uint)Marshal.SizeOf(sCROLLINFO);
			sCROLLINFO.fMask = 31u;
			ListViewEx.GetScrollInfo(base.Handle, 1, ref sCROLLINFO);
			int scrollPos = ListViewEx.GetScrollPos(base.Handle, 1);
			int num;
			int num2;
			ListViewEx.GetScrollRange(base.Handle, 1, out num, out num2);
			return (long)scrollPos + (long)((ulong)sCROLLINFO.nPage) > (long)num2;
		}

		public void ResizeColumnWidth(int maxColWidth)
		{
			if (base.Columns.Count == 0)
			{
				return;
			}
			int num = 0;
			string text = string.Empty;
			Graphics graphics = base.CreateGraphics();
			base.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			for (int i = 0; i < base.Columns.Count; i++)
			{
				text = base.Columns[i].Text;
				num = base.Columns[i].Width;
				foreach (ListViewItem listViewItem in base.Items)
				{
					text = listViewItem.SubItems[i].Text;
					int num2 = (int)graphics.MeasureString(text, this.Font).Width;
					if (num2 > num)
					{
						num = num2;
					}
				}
				if (maxColWidth > 0)
				{
					num = ((num > maxColWidth) ? maxColWidth : num);
				}
				if (i == 0 && base.SmallImageList != null)
				{
					base.Columns[i].Width = base.SmallImageList.ImageSize.Width + num;
				}
				else
				{
					base.Columns[i].Width = num;
				}
			}
		}

		[DllImport("user32.dll")]
		private static extern int GetScrollPos(IntPtr hwnd, int nBar);

		[DllImport("user32", CharSet = CharSet.Auto)]
		private static extern bool GetScrollRange(IntPtr hWnd, int nBar, out int lpMinPos, out int lpMaxPos);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);
	}
}
