using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class PositionController : Controller
	{
		private NISimple _BindNIPosition;

		private MIPosition _BindMIPosition;

		public override NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNIPosition;
			}
			set
			{
				this._BindNIPosition = (NISimple)value;
				this._BindMIPosition = (MIPosition)this._BindNIPosition.BindMMetaItem;
			}
		}

		protected override string NullText
		{
			get
			{
				return "{无效的位置名称}";
			}
		}

		[DebuggerNonUserCode]
		public PositionController()
		{
		}

		public override void Draw(PCTextEdit objTextEdit)
		{
			base.Draw(objTextEdit);
			this.DrawSelection(objTextEdit);
		}

		public override UpdateArgs OnCursorMove(int intPos, int destPos)
		{
			UpdateArgs updateArgs = new UpdateArgs();
			if (this.Active)
			{
				updateArgs.IsRefresh = false;
				updateArgs.Pos = destPos;
				return updateArgs;
			}
			this.Active = true;
			if (Math.Abs(checked(intPos - destPos)) == 1)
			{
				updateArgs.IsRefresh = true;
				updateArgs.Pos = intPos;
				return updateArgs;
			}
			updateArgs.IsRefresh = true;
			updateArgs.Pos = destPos;
			return updateArgs;
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
			if (this._BindMIPosition == null)
			{
				return null;
			}
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
			Point point = currentTextEdit.PointToScreen(positionFromCharIndex);
			SelectPosForm selectPosForm = new SelectPosForm();
			selectPosForm.BindMIPosition = this._BindMIPosition;
			selectPosForm.BindNIPosition = this._BindNIPosition;
			if (selectPosForm.ShowDialog() == DialogResult.OK)
			{
				ReplaceContentAction replaceContentAction = new ReplaceContentAction(this, this.Text, this.ValueCode, selectPosForm.PosValue, selectPosForm.PosValueCode);
				this.ActionManager.AddToActionList(replaceContentAction);
				replaceContentAction.Execute();
				return new UpdateArgs
				{
					IsRefresh = true,
					Pos = pos
				};
			}
			return null;
		}
	}
}
