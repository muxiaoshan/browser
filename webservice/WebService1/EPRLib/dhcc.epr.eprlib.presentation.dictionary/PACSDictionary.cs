using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class PACSDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public PACSDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = new DicContent();
			PacsDicForm pacsDicForm = new PacsDicForm();
			checked
			{
				screenPoint.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (screenPoint.X + pacsDicForm.Height > workingArea.Width)
				{
					screenPoint.X = workingArea.Width - pacsDicForm.Width;
				}
				if (screenPoint.Y + pacsDicForm.Height > workingArea.Height)
				{
					screenPoint.Y = workingArea.Height - pacsDicForm.Height;
				}
				pacsDicForm.StartPosition = FormStartPosition.CenterScreen;
				pacsDicForm.Location = screenPoint;
				if (pacsDicForm.ShowDialog() == DialogResult.OK && pacsDicForm.DicValueCode != null)
				{
					dicContent.Description = pacsDicForm.DicValue;
					dicContent.Code = pacsDicForm.DicValueCode;
					return dicContent;
				}
				return null;
			}
		}
	}
}
