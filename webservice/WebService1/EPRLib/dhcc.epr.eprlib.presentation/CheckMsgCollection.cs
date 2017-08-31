using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation
{
	public class CheckMsgCollection : CollectionBase
	{
		public CheckMsg this[int index]
		{
			get
			{
				return (CheckMsg)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public CheckMsgCollection()
		{
		}

		public void Add(CheckMsg value)
		{
			this.List.Add(value);
		}

		public bool Contains(CheckMsg value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(CheckMsg value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, CheckMsg value)
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

		public void Remove(CheckMsg value)
		{
			this.List.Remove(value);
		}

		public new CheckMsgEnumerator GetEnumerator()
		{
			return new CheckMsgEnumerator(this);
		}
	}
}
