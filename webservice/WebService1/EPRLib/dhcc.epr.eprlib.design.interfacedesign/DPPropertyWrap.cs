using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DPPropertyWrap
	{
		public DesignPanel curDesignPanel;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				return this.curDesignPanel.BackColor;
			}
			set
			{
				this.curDesignPanel.BackColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.curDesignPanel.ForeColor;
			}
			set
			{
				this.curDesignPanel.ForeColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("确定定位网格大小"), DesignOnly(false), ReadOnly(false)]
		public Size GridSize
		{
			get
			{
				return this.curDesignPanel.GridSize;
			}
			set
			{
				this.curDesignPanel.GridSize = value;
			}
		}

		[DebuggerNonUserCode]
		public DPPropertyWrap()
		{
		}
	}
}
