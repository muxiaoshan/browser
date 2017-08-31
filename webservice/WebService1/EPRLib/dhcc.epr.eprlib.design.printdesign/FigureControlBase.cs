using System;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureControlBase
	{
		protected FigureCollection m_FigureRangeCollection;

		public string XmlString
		{
			get
			{
				if (this.m_FigureRangeCollection.FigureCollection.Count > 0)
				{
					return this.m_FigureRangeCollection.XmlString;
				}
				return "";
			}
			set
			{
				if (this.m_FigureRangeCollection.FigureCollection.Count > 0)
				{
					this.m_FigureRangeCollection.ClearCollection();
				}
				this.m_FigureRangeCollection.XmlString = value;
			}
		}

		public FigureControlBase()
		{
			this.m_FigureRangeCollection = new FigureCollection();
		}
	}
}
