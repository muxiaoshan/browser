using dhcc.epr.eprlib.design.interfacedesign;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

public class LablePropertyWrap : ControlPropertyWrap
{
	[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("文本对齐方式"), DesignOnly(false), ReadOnly(false)]
	public ContentAlignment TextAlign
	{
		get
		{
			if (this.curControl is DCLabel)
			{
				DCLabel dCLabel = (DCLabel)this.curControl;
				return dCLabel.PCLabel.TextAlign;
			}
			ContentAlignment result;
			return result;
		}
		set
		{
			if (this.curControl is DCLabel)
			{
				DCLabel dCLabel = (DCLabel)this.curControl;
				dCLabel.PCLabel.TextAlign = value;
			}
		}
	}

	[DebuggerNonUserCode]
	public LablePropertyWrap()
	{
	}
}
