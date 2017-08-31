using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using System;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public interface IDictionary
	{
		DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition);
	}
}
