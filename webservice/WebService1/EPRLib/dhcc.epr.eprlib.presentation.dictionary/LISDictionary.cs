using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class LISDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public LISDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = new DicContent();
			LISDicForm lISDicForm = new LISDicForm();
			checked
			{
				screenPoint.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (screenPoint.X + lISDicForm.Height > workingArea.Width)
				{
					screenPoint.X = workingArea.Width - lISDicForm.Width;
				}
				if (screenPoint.Y + lISDicForm.Height > workingArea.Height)
				{
					screenPoint.Y = workingArea.Height - lISDicForm.Height;
				}
				lISDicForm.StartPosition = FormStartPosition.CenterScreen;
				lISDicForm.Location = screenPoint;
				if (lISDicForm.ShowDialog() == DialogResult.OK && lISDicForm.DicValueCode != null)
				{
					dicContent.Description = lISDicForm.DicValue;
					dicContent.Code = lISDicForm.DicValueCode;
					return dicContent;
				}
				return null;
			}
		}
	}
}
