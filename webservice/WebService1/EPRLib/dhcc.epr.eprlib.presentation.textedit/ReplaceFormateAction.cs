using dhcc.epr.eprlib.instancedata;
using System;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class ReplaceFormateAction : IAction
	{
		private int _NewIntPos;

		private int _NewDestPos;

		private FontStruct _NewFontStruct;

		private int _OldIntPos;

		private int _OldDestPos;

		private FontStruct _OldFontStruct;

		private FormateRange _FormateRange;

		public ReplaceFormateAction(int oldIntPos, int olddestpos, FontStruct oldFontStruct, int newintpos, int newdestpos, FontStruct newFontStruct, FormateRange objFormateRange)
		{
			this._FormateRange = objFormateRange;
			this._NewIntPos = newintpos;
			this._NewDestPos = newdestpos;
			this._NewFontStruct = newFontStruct;
			this._OldIntPos = oldIntPos;
			this._OldDestPos = olddestpos;
			this._OldFontStruct = oldFontStruct;
		}

		public UpdateArgs Execute()
		{
			this._FormateRange.StartPos = this._NewIntPos;
			this._FormateRange.EndPos = this._NewDestPos;
			this._FormateRange.FontStruct = this._NewFontStruct;
			return null;
		}

		public UpdateArgs UnExecute()
		{
			this._FormateRange.StartPos = this._OldIntPos;
			this._FormateRange.EndPos = this._OldDestPos;
			this._FormateRange.FontStruct = this._OldFontStruct;
			return null;
		}
	}
}
