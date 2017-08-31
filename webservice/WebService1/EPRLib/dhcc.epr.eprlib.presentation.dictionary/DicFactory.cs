using System;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class DicFactory
	{
		public static DicFactory theDicFactory;

		public static DicFactory Instance
		{
			get
			{
				if (DicFactory.theDicFactory == null)
				{
					DicFactory.theDicFactory = new DicFactory();
				}
				return DicFactory.theDicFactory;
			}
		}

		private DicFactory()
		{
		}

		public IDictionary getDic(string dicClass)
		{
			string typeName = "dhcc.epr.eprlib.presentation.dictionary." + dicClass;
			Type type = Type.GetType(typeName);
			return (IDictionary)Activator.CreateInstance(type);
		}
	}
}
