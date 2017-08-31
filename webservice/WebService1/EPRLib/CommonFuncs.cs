using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.presentation;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class CommonFuncs
{
	private static string _clientIP;

	public static int WM_CUT = 768;

	public static int WM_COPY = 769;

	public static int WM_PASTE = 770;

	public static int WM_CLEAR = 771;

	public static int WM_UNDO = 772;

	public const int MaxLength = -1;

	private const int vbFromUnicode = 128;

	public static string clientIP
	{
		get
		{
			if (CommonFuncs._clientIP == null || CommonFuncs._clientIP.Equals(string.Empty))
			{
				return CommonFuncs.GetClientIP();
			}
			return CommonFuncs._clientIP;
		}
	}

	public static bool CanCopyPaste
	{
		get
		{
			return Operators.CompareString(SysOptionManager.GetSysOptionValue("CanCopyPaste", string.Empty), "Y", false) == 0;
		}
	}

	[DebuggerNonUserCode]
	public CommonFuncs()
	{
	}

	public static bool ShowRevTip(ref Label parTip, ref object parSender, ref Control parUnitObject)
	{
		checked
		{
			try
			{
				if (parTip == null)
				{
					parTip = new Label();
					parTip.BackColor = SystemColors.Info;
					parTip.BorderStyle = BorderStyle.FixedSingle;
				}
				Control control = (Control)parSender;
				RevisionHistory revisionHistory = (RevisionHistory)control.Tag;
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = revisionHistory.Revisions.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Revision revision = (Revision)enumerator.Current;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text + revision.RevPerson + "于" + revision.RevTime + "在", Interaction.IIf(revision.RevIP == null || revision.RevIP.Equals(string.Empty), "未知位置", revision.RevIP)), "\r\n"));
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text + "从 ", NewLateBinding.LateGet(revision.SubRevisions[0], null, "Content", new object[0], null, null, null)), " 改为 "), NewLateBinding.LateGet(revision.SubRevisions[1], null, "Content", new object[0], null, null, null)), "\r\n"));
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
				parTip.Text = text;
				Graphics graphics = Graphics.FromHwnd(parTip.Handle);
				SizeF sizeF = graphics.MeasureString(parTip.Text, parTip.Font);
				parTip.Width = (int)Math.Round((double)(unchecked(sizeF.Width + 4f)));
				parTip.Height = (int)Math.Round((double)(unchecked(sizeF.Height + 4f)));
				parTip.Top = parUnitObject.Top + 30;
				parTip.Left = control.Left;
				if (parTip.Top + parTip.Height > parUnitObject.Parent.ClientSize.Height)
				{
					parTip.Top = parUnitObject.Top - parTip.Height;
				}
				if (parTip.Left + parTip.Width > parUnitObject.Parent.ClientSize.Width)
				{
					Label label = parTip;
					label.Left -= parTip.Left + parTip.Width - parUnitObject.Parent.ClientSize.Width;
				}
				parUnitObject.Parent.Controls.Add(parTip);
				parTip.BringToFront();
			}
			catch (Exception expr_29F)
			{
				ProjectData.SetProjectError(expr_29F);
				Interaction.MsgBox("显示留痕内容错误！", MsgBoxStyle.OkOnly, "提示");
				ProjectData.ClearProjectError();
			}
			bool result;
			return result;
		}
	}

	public static string GetClientIP()
	{
		string result;
		try
		{
			string hostName = Dns.GetHostName();
			IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
			IPAddress[] addressList = hostEntry.AddressList;
			result = addressList[0].ToString();
		}
		catch (Exception expr_1F)
		{
			ProjectData.SetProjectError(expr_1F);
			result = "获取IP地址错误！";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool IsOverflowMaxLength(ref int KeyAscii, int maxLen, string text, string SelText)
	{
		if (KeyAscii == 8)
		{
			return false;
		}
		checked
		{
			int num = CommonFuncs.LenB(Strings.StrConv(text, VbStrConv.SimplifiedChinese, 0)) - CommonFuncs.LenB(Strings.StrConv(SelText, VbStrConv.SimplifiedChinese, 0));
			num++;
			return num > maxLen;
		}
	}

	public static bool IsOverflowMaxLength(string txt, int maxLen, string text, string SelText)
	{
		int num = checked(CommonFuncs.LenB(Strings.StrConv(txt, VbStrConv.SimplifiedChinese, 0)) + CommonFuncs.LenB(Strings.StrConv(text, VbStrConv.SimplifiedChinese, 0)) - CommonFuncs.LenB(Strings.StrConv(SelText, VbStrConv.SimplifiedChinese, 0)));
		return maxLen < num;
	}

	public static int LenB(string ObjStr)
	{
		if (Strings.Len(ObjStr) == 0)
		{
			return 0;
		}
		return checked((int)Math.Round((double)Encoding.Unicode.GetByteCount(ObjStr) / 2.0));
	}

	public static int LenB(object Obj)
	{
		if (Obj == null)
		{
			return 0;
		}
		int result;
		try
		{
			result = Strings.Len(RuntimeHelpers.GetObjectValue(Obj));
		}
		catch (Exception arg_13_0)
		{
			ProjectData.SetProjectError(arg_13_0);
			try
			{
				result = Marshal.SizeOf(RuntimeHelpers.GetObjectValue(Obj));
				ProjectData.ClearProjectError();
			}
			catch (Exception arg_2B_0)
			{
				ProjectData.SetProjectError(arg_2B_0);
				result = -1;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	public static void DataGridStyle(ref DataGridView dgv)
	{
		dgv.BackgroundColor = Color.White;
		dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(223, 227, 233);
		dgv.EnableHeadersVisualStyles = false;
		dgv.RowHeadersVisible = false;
		dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
		dgv.ColumnHeadersHeight = 25;
	}
}
