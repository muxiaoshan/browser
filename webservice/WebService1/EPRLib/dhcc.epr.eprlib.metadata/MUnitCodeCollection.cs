using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata
{
	public class MUnitCodeCollection : CollectionBase
	{
		public MUnitCode this[int index]
		{
			get
			{
				return (MUnitCode)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public MUnitCodeCollection()
		{
		}

		public void Add(MUnitCode value)
		{
			this.List.Add(value);
		}

		public bool Contains(MUnitCode value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(MUnitCode value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, MUnitCode value)
		{
			this.List.Insert(index, value);
		}

		public void Remove(MUnitCode value)
		{
			this.List.Remove(value);
		}

		public new MUnitCodeEnumerator GetEnumerator()
		{
			return new MUnitCodeEnumerator(this);
		}
	}
}
