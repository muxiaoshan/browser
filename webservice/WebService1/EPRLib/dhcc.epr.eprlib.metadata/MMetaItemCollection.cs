using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata
{
	public class MMetaItemCollection : CollectionBase
	{
		public MMetaItem this[int index]
		{
			get
			{
				return (MMetaItem)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public MMetaItemCollection()
		{
		}

		public void Add(MMetaItem value)
		{
			this.List.Add(value);
		}

		public void Add(MMetaItem parent, MMetaItem value)
		{
			value.Parent = parent;
			this.List.Add(value);
		}

		public bool Contains(MMetaItem value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(MMetaItem value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, MMetaItem value)
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

		public void Insert(MMetaItem parent, int index, MMetaItem value)
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

		public void Remove(MMetaItem value)
		{
			value.Parent = null;
			this.List.Remove(value);
		}

		public new MMetaItemEnumerator GetEnumerator()
		{
			return new MMetaItemEnumerator(this);
		}
	}
}
