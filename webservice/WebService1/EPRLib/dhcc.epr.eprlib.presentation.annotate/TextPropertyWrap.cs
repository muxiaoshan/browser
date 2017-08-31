using Atalasoft.Imaging.Annotate;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class TextPropertyWrap
	{
		public TextAnnotation TextAnnotation;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.TextAnnotation.get_Pen().Color;
			}
			set
			{
				this.TextAnnotation.get_Pen().Color = value;
				this.TextAnnotation.set_FontBrush(new SolidBrush(value));
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("字体颜色"), DesignOnly(false), ReadOnly(false)]
		public Color FontColor
		{
			get
			{
				return ((SolidBrush)this.TextAnnotation.get_FontBrush()).Color;
			}
			set
			{
				this.TextAnnotation.set_FontBrush(new SolidBrush(value));
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				if (this.TextAnnotation.get_Brush() is SolidBrush)
				{
					return ((SolidBrush)this.TextAnnotation.get_Brush()).Color;
				}
				Color result;
				return result;
			}
			set
			{
				if (this.TextAnnotation.get_Brush() is SolidBrush)
				{
					((SolidBrush)this.TextAnnotation.get_Brush()).Color = value;
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("字体"), DesignOnly(false), ReadOnly(false)]
		public Font Font
		{
			get
			{
				return this.TextAnnotation.get_Font();
			}
			set
			{
				this.TextAnnotation.set_Font(value);
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("线宽"), DesignOnly(false), Editor(typeof(TextWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int LineWidth
		{
			get
			{
				return checked((int)Math.Round((double)this.TextAnnotation.get_Pen().Width));
			}
			set
			{
				this.TextAnnotation.get_Pen().Width = (float)value;
			}
		}

		[DebuggerNonUserCode]
		public TextPropertyWrap()
		{
		}
	}
}
