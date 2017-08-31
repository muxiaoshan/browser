using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class StdDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public StdDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = new DicContent();
			StdDicForm stdDicForm = new StdDicForm();
			checked
			{
				screenPoint.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (screenPoint.X + stdDicForm.Height > workingArea.Width)
				{
					screenPoint.X = workingArea.Width - stdDicForm.Width;
				}
				if (screenPoint.Y + stdDicForm.Height > workingArea.Height)
				{
					screenPoint.Y = workingArea.Height - stdDicForm.Height;
				}
				stdDicForm.StartPosition = FormStartPosition.Manual;
				stdDicForm.Location = screenPoint;
				if (string.IsNullOrEmpty(strCondition))
				{
					stdDicForm.ShowDic(midic, strQuery);
				}
				else
				{
					stdDicForm.ShowDic(midic, strQuery, strCondition.Split(new char[]
					{
						'^'
					})[0], strCondition.Split(new char[]
					{
						'^'
					})[1]);
				}
				if (stdDicForm.ShowDialog() == DialogResult.OK && stdDicForm.DicValueCode != null)
				{
					dicContent.Description = stdDicForm.DicValue;
					dicContent.Code = stdDicForm.DicValueCode;
					return dicContent;
				}
				return null;
			}
		}
	}
}
