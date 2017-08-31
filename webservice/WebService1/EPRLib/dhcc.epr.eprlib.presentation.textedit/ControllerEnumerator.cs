using System;
using System.Collections;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class ControllerEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (Controller)this.baseEnumerator.Current;
			}
		}

		public ControllerEnumerator(ControllerCollection mappings)
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
