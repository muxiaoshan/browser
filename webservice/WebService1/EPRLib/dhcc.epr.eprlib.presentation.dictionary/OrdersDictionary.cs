using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class OrdersDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public OrdersDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = new DicContent();
			OrdersDicForm ordersDicForm = new OrdersDicForm();
			checked
			{
				screenPoint.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (screenPoint.X + ordersDicForm.Height > workingArea.Width)
				{
					screenPoint.X = workingArea.Width - ordersDicForm.Width;
				}
				if (screenPoint.Y + ordersDicForm.Height > workingArea.Height)
				{
					screenPoint.Y = workingArea.Height - ordersDicForm.Height;
				}
				ordersDicForm.StartPosition = FormStartPosition.CenterScreen;
				ordersDicForm.Location = screenPoint;
				if (ordersDicForm.ShowDialog() == DialogResult.OK && ordersDicForm.DicValueCode != null)
				{
					dicContent.Description = ordersDicForm.DicValue;
					dicContent.Code = ordersDicForm.DicValueCode;
					return dicContent;
				}
				return null;
			}
		}
	}
}
