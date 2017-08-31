using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.dictionary;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class DictionaryController : SimpleController
	{
		public MIDictionary BindMIDictionary
		{
			get
			{
				return (MIDictionary)this.BindInstanceItem.BindMMetaItem;
			}
		}

		[DebuggerNonUserCode]
		public DictionaryController()
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
			Point screenPoint = currentTextEdit.PointToScreen(positionFromCharIndex);
			DicContent dicContent;
			if (Operators.CompareString(this.BindMIDictionary.DictionaryType, "STDDIC", false) == 0)
			{
				IDictionary dic = DicFactory.Instance.getDic("StdDictionary");
				dicContent = dic.GetDicContent(this.BindMIDictionary, screenPoint, (NISimple)base.BindInstanceItem, "", "");
			}
			else
			{
				IDictionary dic = DicFactory.Instance.getDic(this.BindMIDictionary.CustDicClassName);
				dicContent = dic.GetDicContent(this.BindMIDictionary, screenPoint, (NISimple)base.BindInstanceItem, "", "");
			}
			if (dicContent != null)
			{
				ReplaceContentAction replaceContentAction = new ReplaceContentAction(this, this.Text, this.ValueCode, dicContent.Description, dicContent.Code);
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
