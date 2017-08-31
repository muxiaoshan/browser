using dhcc.epr.eprlib.instancedata;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.metadata
{
	public class MFormulaItemCollection : CollectionBase
	{
		private NInstanceData _NInstanceData;

		public MFormulaItem this[int index]
		{
			get
			{
				return (MFormulaItem)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		public NInstanceData NInstanceData
		{
			get
			{
				return this._NInstanceData;
			}
			set
			{
				this._NInstanceData = value;
				MFormulaItemEnumerator enumerator = this.GetEnumerator();
				while (enumerator.MoveNext())
				{
					MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
					mFormulaItem.NInstanceData = this._NInstanceData;
				}
			}
		}

		[DebuggerNonUserCode]
		public MFormulaItemCollection()
		{
		}

		public void Add(MFormulaItem value)
		{
			this.List.Add(value);
		}

		public bool Contains(MFormulaItem value)
		{
			return this.List.Contains(value);
		}

		public int IndexOf(MFormulaItem value)
		{
			return this.List.IndexOf(value);
		}

		public void Insert(int index, MFormulaItem value)
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

		public void Remove(MFormulaItem value)
		{
			this.List.Remove(value);
		}

		public new MFormulaItemEnumerator GetEnumerator()
		{
			return new MFormulaItemEnumerator(this);
		}
	}
}
