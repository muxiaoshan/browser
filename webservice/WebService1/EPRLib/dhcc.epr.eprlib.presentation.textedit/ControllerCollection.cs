using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.presentation.textedit
{
	public class ControllerCollection : CollectionBase
	{
		public Controller this[int index]
		{
			get
			{
				return (Controller)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		[DebuggerNonUserCode]
		public ControllerCollection()
		{
		}

		public void Add(Controller value)
		{
			this.List.Add(value);
		}

		public void Add(Controller parent, Controller value)
		{
			value.Parent = parent;
			this.List.Add(value);
		}

		public bool Contains(Controller value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(Controller value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, Controller value)
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

		public void Insert(Controller parent, int index, Controller value)
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

		public void Remove(Controller value)
		{
			value.Parent = null;
			this.List.Remove(value);
		}

		public new ControllerEnumerator GetEnumerator()
		{
			return new ControllerEnumerator(this);
		}
	}
}
