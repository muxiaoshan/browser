using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class MultiChoiceController : SimpleController
	{
		[DebuggerNonUserCode]
		public MultiChoiceController()
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
			Point formPosition = currentTextEdit.PointToScreen(positionFromCharIndex);
			MultiChoiceForm multiChoiceForm = new MultiChoiceForm((MIMultiChoice)this.BindInstanceItem.BindMMetaItem, this.BindInstanceItem.Value);
			multiChoiceForm.SetFormPosition(formPosition);
			multiChoiceForm.TopMost = true;
			multiChoiceForm.CheckStatus = this.ValueCode;
			if (multiChoiceForm.ShowDialog() == DialogResult.OK && Operators.CompareString(multiChoiceForm.CheckStatus, this.BindInstanceItem.ValueCode, false) != 0)
			{
				ReplaceContentAction replaceContentAction = new ReplaceContentAction(this, this.Text, this.ValueCode, multiChoiceForm.CheckString, multiChoiceForm.CheckStatus);
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

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSelection(objTextEdit);
		}
	}
}
