using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.instancedata
{
	public class NInstanceItemCollection : CollectionBase
	{
		public NInstanceItem this[int index]
		{
			get
			{
				return (NInstanceItem)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public NInstanceItemCollection()
		{
		}

		public void Add(NInstanceItem value)
		{
			this.List.Add(value);
		}

		public void Add(NInstanceItem parent, NInstanceItem value)
		{
			value.Parent = parent;
			this.List.Add(value);
		}

		public bool Contains(NInstanceItem value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(NInstanceItem value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, NInstanceItem value)
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

		public void Insert(NInstanceItem parent, int index, NInstanceItem value)
		{
			value.Parent = parent;
			if (this.List.Count == index)
			{
				this.List.Add(value);
			}
			else
			{
				this.List.Insert(index, value);
			}
		}

		public void Remove(NInstanceItem value)
		{
			this.List.Remove(value);
		}

		public new NInstanceItemEnumerator GetEnumerator()
		{
			return new NInstanceItemEnumerator(this);
		}
	}
}
