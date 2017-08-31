using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class EPRHotSpotProperty
	{
		public IEPRHotSpot EPRHotSpot;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("热点名称"), DesignOnly(false), ReadOnly(false)]
		public string Name
		{
			get
			{
				return this.EPRHotSpot.HSName;
			}
			set
			{
				this.EPRHotSpot.HSName = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("热点代码"), DesignOnly(false), ReadOnly(false)]
		public string Code
		{
			get
			{
				return this.EPRHotSpot.HSCode;
			}
			set
			{
				this.EPRHotSpot.HSCode = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("热点说明"), DesignOnly(false), ReadOnly(false)]
		public string Desc
		{
			get
			{
				return this.EPRHotSpot.HSDesc;
			}
			set
			{
				this.EPRHotSpot.HSDesc = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("热点颜色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				return this.EPRHotSpot.Color;
			}
			set
			{
				this.EPRHotSpot.Color = value;
			}
		}

		[DebuggerNonUserCode]
		public EPRHotSpotProperty()
		{
		}
	}
}
