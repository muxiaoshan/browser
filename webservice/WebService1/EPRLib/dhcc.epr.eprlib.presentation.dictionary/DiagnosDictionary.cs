using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class DiagnosDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public DiagnosDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = new DicContent();
			DiagnosDicForm diagnosDicForm = new DiagnosDicForm();
			diagnosDicForm.m_DiagnosTypeID = strQuery;
			checked
			{
				screenPoint.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (screenPoint.X + diagnosDicForm.Height > workingArea.Width)
				{
					screenPoint.X = workingArea.Width - diagnosDicForm.Width;
				}
				if (screenPoint.Y + diagnosDicForm.Height > workingArea.Height)
				{
					screenPoint.Y = workingArea.Height - diagnosDicForm.Height;
				}
				diagnosDicForm.StartPosition = FormStartPosition.CenterScreen;
				diagnosDicForm.Location = screenPoint;
				if (diagnosDicForm.ShowDialog() == DialogResult.OK && diagnosDicForm.DicValueCode != null)
				{
					dicContent.Description = diagnosDicForm.DicValue;
					dicContent.Code = diagnosDicForm.DicValueCode;
					return dicContent;
				}
				return null;
			}
		}
	}
}
