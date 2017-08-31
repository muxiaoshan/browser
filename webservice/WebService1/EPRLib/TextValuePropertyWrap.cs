using dhcc.epr.eprlib.design.interfacedesign;
using System;
using System.ComponentModel;
using System.Diagnostics;

public class TextValuePropertyWrap : ControlPropertyWrap
{
	[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("ReadOnly"), DesignOnly(false), ReadOnly(false)]
	public bool ReadOnly
	{
		get
		{
			if (this.curControl is DCTextEdit)
			{
				DCTextEdit dCTextEdit = (DCTextEdit)this.curControl;
				return dCTextEdit.PCTextEdit.ReadOnly;
			}
			bool result;
			return result;
		}
		set
		{
			if (this.curControl is DCTextEdit)
			{
				DCTextEdit dCTextEdit = (DCTextEdit)this.curControl;
				dCTextEdit.PCTextEdit.ReadOnly = value;
			}
		}
	}

	[DebuggerNonUserCode]
	public TextValuePropertyWrap()
	{
	}
}
