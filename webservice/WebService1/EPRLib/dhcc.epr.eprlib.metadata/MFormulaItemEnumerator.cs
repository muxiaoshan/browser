using System;
using System.Collections;

namespace dhcc.epr.eprlib.metadata
{
	public class MFormulaItemEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (MFormulaItem)this.baseEnumerator.Current;
			}
		}

		public MFormulaItemEnumerator(MFormulaItemCollection mappings)
		{
			this.temp = mappings;
			this.baseEnumerator = this.temp.GetEnumerator();
		}

		public bool MoveNext()
		{
			return this.baseEnumerator.MoveNext();
		}

		public void Reset()
		{
			this.baseEnumerator.Reset();
		}
	}
}
