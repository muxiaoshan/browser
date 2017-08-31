using Atalasoft.Imaging.Annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class EllipsePropertyWrap
	{
		public EllipseAnnotation EllipseAnnotation;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.EllipseAnnotation.get_Pen().Color;
			}
			set
			{
				this.EllipseAnnotation.get_Pen().Color = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				if (this.EllipseAnnotation.get_Brush() is SolidBrush)
				{
					return ((SolidBrush)this.EllipseAnnotation.get_Brush()).Color;
				}
				Color result;
				return result;
			}
			set
			{
				if (this.EllipseAnnotation.get_Brush() is SolidBrush)
				{
					((SolidBrush)this.EllipseAnnotation.get_Brush()).Color = value;
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("线宽"), DesignOnly(false), Editor(typeof(EllipseWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int LineWidth
		{
			get
			{
				return checked((int)Math.Round((double)this.EllipseAnnotation.get_Pen().Width));
			}
			set
			{
				this.EllipseAnnotation.get_Pen().Width = (float)value;
			}
		}

		[DebuggerNonUserCode]
		public EllipsePropertyWrap()
		{
		}
	}
}
