using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation
{
	public class CheckMsgEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (CheckMsg)this.baseEnumerator.Current;
			}
		}

		public CheckMsgEnumerator(CheckMsgCollection mappings)
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
