using System;
using System.Collections;

namespace dhcc.epr.eprlib.metadata
{
	public class MMetaItemEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (MMetaItem)this.baseEnumerator.Current;
			}
		}

		public MMetaItemEnumerator(MMetaItemCollection mappings)
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
