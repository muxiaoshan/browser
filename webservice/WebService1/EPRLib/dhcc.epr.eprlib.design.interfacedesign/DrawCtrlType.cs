using System;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public enum DrawCtrlType
	{
		Label = 1,
		VLine,
		HLine,
		Box,
		AlignTable,
		MIString = 11,
		MINumber,
		MIMonoChoice,
		MIMultiChoice,
		MIDateTime,
		MIDictionary,
		MIQuantity,
		MITable,
		MITextDesc,
		MISegment,
		MIImageAnnotate,
		MIPosition,
		MIFigure
	}
}
