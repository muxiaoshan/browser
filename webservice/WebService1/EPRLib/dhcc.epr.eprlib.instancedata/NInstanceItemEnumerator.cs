using System;
using System.Collections;

namespace dhcc.epr.eprlib.instancedata
{
	public class NInstanceItemEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (NInstanceItem)this.baseEnumerator.Current;
			}
		}

		public NInstanceItemEnumerator(NInstanceItemCollection mappings)
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
