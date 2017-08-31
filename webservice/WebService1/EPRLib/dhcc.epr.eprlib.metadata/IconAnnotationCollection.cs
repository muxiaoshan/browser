using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata
{
	public class IconAnnotationCollection : CollectionBase
	{
		public IconAnnotation this[int index]
		{
			get
			{
				return (IconAnnotation)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public IconAnnotationCollection()
		{
		}

		public void Add(IconAnnotation value)
		{
			this.List.Add(value);
		}

		public bool Contains(IconAnnotation value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(IconAnnotation value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, IconAnnotation value)
		{
			if (this.List.Count == index)
			{
				this.List.Add(value);
			}
			else
			{
				this.List.Insert(index, value);
			}
		}

		public void Remove(IconAnnotation value)
		{
			this.List.Remove(value);
		}

		public new IconAnnotationEnumerator GetEnumerator()
		{
			return new IconAnnotationEnumerator(this);
		}
	}
}
