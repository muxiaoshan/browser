using System;
using System.Collections;

namespace dhcc.epr.eprlib.metadata
{
	public class IconAnnotationEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public object Current
		{
			get
			{
				return (IconAnnotation)this.baseEnumerator.Current;
			}
		}

		public IconAnnotationEnumerator(IconAnnotationCollection mappings)
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
