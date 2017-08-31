using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class MonoChoiceController : SimpleController
	{
		[DebuggerNonUserCode]
		public MonoChoiceController()
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
			MonoChoiceForm monoChoiceForm = new MonoChoiceForm((MIMonoChoice)this.BindInstanceItem.BindMMetaItem, this.BindInstanceItem.Value, this.BindInstanceItem.ValueCode);
			checked
			{
				location.Y += 18;
				Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
				if (location.X + monoChoiceForm.Height > workingArea.Width)
				{
					location.X = workingArea.Width - monoChoiceForm.Width;
				}
				if (location.Y + monoChoiceForm.Height > workingArea.Height)
				{
					location.Y = workingArea.Height - monoChoiceForm.Height;
				}
				monoChoiceForm.StartPosition = FormStartPosition.Manual;
				monoChoiceForm.Location = location;
				monoChoiceForm.TopMost = true;
				if (monoChoiceForm.ShowDialog() == DialogResult.OK && (Operators.CompareString(monoChoiceForm.ChangedCode, this.BindInstanceItem.ValueCode, false) != 0 || Operators.CompareString(monoChoiceForm.ChangedValue, this.BindInstanceItem.ValueCode, false) != 0))
				{
					ReplaceContentAction replaceContentAction = new ReplaceContentAction(this, this.Text, this.ValueCode, monoChoiceForm.ChangedValue, monoChoiceForm.ChangedCode);
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
