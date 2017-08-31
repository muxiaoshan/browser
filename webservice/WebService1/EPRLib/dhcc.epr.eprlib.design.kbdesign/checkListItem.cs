using System;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public struct checkListItem
	{
		public string RowId;

		public string Code;

		public string Desc;

		public override string ToString()
		{
			return this.Desc;
		}
	}
}
