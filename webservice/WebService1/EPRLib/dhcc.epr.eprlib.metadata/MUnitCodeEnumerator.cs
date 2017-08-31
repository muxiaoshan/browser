using System;
using System.Collections;

namespace dhcc.epr.eprlib.metadata
{
	public class MUnitCodeEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (MUnitCode)this.baseEnumerator.Current;
			}
		}

		public MUnitCodeEnumerator(MUnitCodeCollection mappings)
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
