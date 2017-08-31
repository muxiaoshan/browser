using dhcc.epr.eprlib.instancedata;
using System;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class DeleteFormateAction : IAction
	{
		private FormateRangeCollection _FRCollection;

		private FormateRange _DeleteFR;

		private int _DeletePos;

		public DeleteFormateAction(FormateRangeCollection objFRCol, FormateRange objFR)
		{
			this._FRCollection = objFRCol;
			this._DeleteFR = objFR;
			this._DeletePos = objFRCol.IndexOf(objFR);
		}

		public UpdateArgs Execute()
		{
			this._FRCollection.Remove(this._DeleteFR);
			return null;
		}

		public UpdateArgs UnExecute()
		{
			this._FRCollection.Insert(this._DeletePos, this._DeleteFR);
			return null;
		}
	}
}
