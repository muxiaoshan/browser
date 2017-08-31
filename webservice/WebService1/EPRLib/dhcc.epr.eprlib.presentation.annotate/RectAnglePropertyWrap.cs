using Atalasoft.Imaging.Annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class RectAnglePropertyWrap
	{
		public RectangleAnnotation RectangleAnnotation;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.RectangleAnnotation.get_Pen().Color;
			}
			set
			{
				this.RectangleAnnotation.get_Pen().Color = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				if (this.RectangleAnnotation.get_Brush() is SolidBrush)
				{
					return ((SolidBrush)this.RectangleAnnotation.get_Brush()).Color;
				}
				Color result;
				return result;
			}
			set
			{
				if (this.RectangleAnnotation.get_Brush() is SolidBrush)
				{
					((SolidBrush)this.RectangleAnnotation.get_Brush()).Color = value;
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("线宽"), DesignOnly(false), Editor(typeof(RectAngleWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int LineWidth
		{
			get
			{
				return checked((int)Math.Round((double)this.RectangleAnnotation.get_Pen().Width));
			}
			set
			{
				this.RectangleAnnotation.get_Pen().Width = (float)value;
			}
		}

		[DebuggerNonUserCode]
		public RectAnglePropertyWrap()
		{
		}
	}
}
