using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dhcc.epr.systemframework
{
	public class MyRichTextCellType : RichTextCellType
	{
		private struct RECT
		{
			public int Left;

			public int Top;

			public int Right;

			public int Bottom;
		}

		private struct CHARRANGE
		{
			public int cpMin;

			public int cpMax;
		}

		private struct FORMATRANGE
		{
			public IntPtr hdc;

			public IntPtr hdcTarget;

			public MyRichTextCellType.RECT rc;

			public MyRichTextCellType.RECT rcPage;

			public MyRichTextCellType.CHARRANGE chrg;
		}

		private const int WM_USER = 1024;

		private const int EM_FORMATRANGE = 1081;

		private static RichTextBox m_RTFEditor = new RichTextBox();

		[DllImport("USER32.dll", EntryPoint = "SendMessageA")]
		private static extern IntPtr SendMessage(IntPtr hwnd, int msg, IntPtr wp, IntPtr lp);

		public MyRichTextCellType()
		{
			base.set_MaxLength(32767);
			MyRichTextCellType.m_RTFEditor.MaxLength = base.get_MaxLength();
			MyRichTextCellType.m_RTFEditor.ScrollBars = RichTextBoxScrollBars.None;
		}

		public override void PaintCell(Graphics g, Rectangle r, Appearance appearance, object value, bool isSelected, bool isLocked, float zoomFactor)
		{
			if (value != null)
			{
				int num = r.Top;
				int num2 = r.Left + 1;
				MyRichTextCellType.m_RTFEditor.Width = r.Width;
				MyRichTextCellType.m_RTFEditor.WordWrap = base.get_WordWrap();
				MyRichTextCellType.m_RTFEditor.Multiline = true;
				MyRichTextCellType.m_RTFEditor.Font = appearance.get_Font();
				if (appearance.get_VerticalAlignment() == 2)
				{
					try
					{
						MyRichTextCellType.m_RTFEditor.Rtf = value.ToString();
					}
					catch (Exception)
					{
						MyRichTextCellType.m_RTFEditor.Text = value.ToString();
					}
					MyRichTextCellType.m_RTFEditor.AppendText("\r\n ");
					int y = MyRichTextCellType.m_RTFEditor.GetPositionFromCharIndex(MyRichTextCellType.m_RTFEditor.TextLength - 1).Y;
					num += (r.Height - y) / 2;
				}
				else if (appearance.get_VerticalAlignment() == 3)
				{
					try
					{
						MyRichTextCellType.m_RTFEditor.Rtf = value.ToString();
					}
					catch (Exception)
					{
						MyRichTextCellType.m_RTFEditor.Text = value.ToString();
					}
					MyRichTextCellType.m_RTFEditor.AppendText("\r\n ");
					int y2 = MyRichTextCellType.m_RTFEditor.GetPositionFromCharIndex(MyRichTextCellType.m_RTFEditor.TextLength - 1).Y;
					num += r.Height - y2;
				}
				MyRichTextCellType.m_RTFEditor.Multiline = base.get_Multiline();
				try
				{
					MyRichTextCellType.m_RTFEditor.Rtf = value.ToString();
				}
				catch (Exception)
				{
					MyRichTextCellType.m_RTFEditor.Text = value.ToString();
				}
				if (appearance.get_HorizontalAlignment() == 2)
				{
					MyRichTextCellType.m_RTFEditor.SelectAll();
					MyRichTextCellType.m_RTFEditor.SelectionAlignment = HorizontalAlignment.Center;
				}
				else if (appearance.get_HorizontalAlignment() == 3)
				{
					MyRichTextCellType.m_RTFEditor.SelectAll();
					MyRichTextCellType.m_RTFEditor.SelectionAlignment = HorizontalAlignment.Right;
				}
				MyRichTextCellType.CHARRANGE chrg;
				chrg.cpMin = 0;
				chrg.cpMax = MyRichTextCellType.m_RTFEditor.TextLength;
				double num3 = 15.0;
				if (isLocked)
				{
					num3 = 14.4;
					num2 = r.Left;
				}
				MyRichTextCellType.RECT rECT;
				rECT.Top = (int)((double)num * num3);
				rECT.Bottom = (int)((double)r.Bottom * num3);
				rECT.Left = (int)((double)num2 * num3);
				rECT.Right = (int)((double)r.Right * num3);
				IntPtr hdc = g.GetHdc();
				MyRichTextCellType.FORMATRANGE fORMATRANGE;
				fORMATRANGE.chrg = chrg;
				fORMATRANGE.hdc = hdc;
				fORMATRANGE.hdcTarget = hdc;
				fORMATRANGE.rc = rECT;
				fORMATRANGE.rcPage = rECT;
				IntPtr arg_259_0 = IntPtr.Zero;
				IntPtr wp = new IntPtr(1);
				IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(fORMATRANGE));
				Marshal.StructureToPtr(fORMATRANGE, intPtr, false);
				MyRichTextCellType.SendMessage(MyRichTextCellType.m_RTFEditor.Handle, 1081, wp, intPtr);
				Marshal.FreeCoTaskMem(intPtr);
				g.ReleaseHdc(hdc);
			}
		}

		public void SetMaxLength(int length)
		{
			base.set_MaxLength(length);
			MyRichTextCellType.m_RTFEditor.MaxLength = length;
		}
	}
}
