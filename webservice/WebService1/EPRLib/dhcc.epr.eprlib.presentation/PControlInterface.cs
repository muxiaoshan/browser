using dhcc.epr.eprlib.instancedata;
using System;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public interface PControlInterface
	{
		NInstanceItem BindInstanceItem
		{
			get;
			set;
		}

		void XMLDeserialize(XmlReader reader);
	}
}
