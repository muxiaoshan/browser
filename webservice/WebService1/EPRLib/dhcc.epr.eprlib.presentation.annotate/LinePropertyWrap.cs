using Atalasoft.Imaging.Annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class LinePropertyWrap
	{
		public LineAnnotation LineAnnotation;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.LineAnnotation.get_Pen().Color;
			}
			set
			{
				this.LineAnnotation.get_Pen().Color = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("线宽"), DesignOnly(false), Editor(typeof(LineWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int LineWidth
		{
			get
			{
				return checked((int)Math.Round((double)this.LineAnnotation.get_Pen().Width));
			}
			set
			{
				this.LineAnnotation.get_Pen().Width = (float)value;
			}
		}

		[DebuggerNonUserCode]
		public LinePropertyWrap()
		{
		}
	}
}
