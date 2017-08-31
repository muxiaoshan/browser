using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class DateTimeController : SimpleController
	{
		[DebuggerNonUserCode]
		public DateTimeController()
		{
		}

		public override UpdateArgs OnEnterKeyDown(int pos)
		{
			return this.ShowInputForm(pos);
		}

		public override UpdateArgs OnDoubleClick(int pos)
		{
			return this.ShowInputForm(pos);
		}

		private UpdateArgs ShowInputForm(int pos)
		{
			SegmentController segmentController = (SegmentController)this.Parent;
			PCTextEdit currentTextEdit;
			if (segmentController.Standalone)
			{
				currentTextEdit = segmentController.CurrentTextEdit;
			}
			else
			{
				currentTextEdit = segmentController.Parent.CurrentTextEdit;
			}
			Point positionFromCharIndex = currentTextEdit.GetPositionFromCharIndex(pos);
			Point location = currentTextEdit.PointToScreen(positionFromCharIndex);
			DateTimeForm dateTimeForm = new DateTimeForm((NISimple)this.BindInstanceItem);
			checked
			{
				location.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (location.X + dateTimeForm.Height > workingArea.Width)
				{
					location.X = workingArea.Width - dateTimeForm.Width;
				}
				if (location.Y + dateTimeForm.Height > workingArea.Height)
				{
					location.Y = workingArea.Height - dateTimeForm.Height;
				}
				dateTimeForm.StartPosition = FormStartPosition.Manual;
				dateTimeForm.Location = location;
				dateTimeForm.TopMost = true;
				string text = Conversions.ToString(this.Text.Clone());
				string text2 = Conversions.ToString(this.ValueCode.Clone());
				if (dateTimeForm.ShowDialog() == DialogResult.OK && (Operators.CompareString(text, this.Text, false) != 0 | Operators.CompareString(text2, this.ValueCode, false) != 0))
				{
					string text3 = this.Text;
					string valueCode = this.ValueCode;
					this.Text = text;
					this.ValueCode = text2;
					ReplaceContentAction replaceContentAction = new ReplaceContentAction(this, text, text2, text3, valueCode);
					this.ActionManager.AddToActionList(replaceContentAction);
					replaceContentAction.Execute();
					return new UpdateArgs
					{
						IsRefresh = true,
						Pos = this.StartPos
					};
				}
				return null;
			}
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSelection(objTextEdit);
		}
	}
}