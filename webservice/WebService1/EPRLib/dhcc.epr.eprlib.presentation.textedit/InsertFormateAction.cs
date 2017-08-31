using dhcc.epr.eprlib.instancedata;
using System;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class InsertFormateAction : IAction
	{
		private FormateRangeCollection _FRCollection;

		private FormateRange _InsertFR;

		private int _InsertPos;

		public InsertFormateAction(FormateRangeCollection objFRCol, FormateRange objFR, int insertpos)
		{
			this._FRCollection = objFRCol;
			this._InsertFR = objFR;
			this._InsertPos = insertpos;
		}

		public UpdateArgs Execute()
		{
			this._FRCollection.Insert(this._InsertPos, this._InsertFR);
			return null;
		}

		public UpdateArgs UnExecute()
		{
			this._FRCollection.Remove(this._InsertFR);
			return null;
		}
	}
}
