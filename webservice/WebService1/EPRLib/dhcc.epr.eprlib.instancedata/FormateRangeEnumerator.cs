using System;
using System.Collections;

namespace dhcc.epr.eprlib.instancedata
{
	public class FormateRangeEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (FormateRange)this.baseEnumerator.Current;
			}
		}

		public FormateRangeEnumerator(FormateRangeCollection mappings)
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
