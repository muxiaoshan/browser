using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class MetaItemPropertyWrap
	{
		public MetaItemAnnotation MetaItemAnnotation;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("元数据名称"), DesignOnly(false), ReadOnly(true)]
		public string MetaItemName
		{
			get
			{
				return this.MetaItemAnnotation.MetaItemName;
			}
			set
			{
				this.MetaItemAnnotation.MetaItemName = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("字体"), DesignOnly(false), ReadOnly(false)]
		public Font Font
		{
			get
			{
				return this.MetaItemAnnotation.Font;
			}
			set
			{
				this.MetaItemAnnotation.Font = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("文字与边框间距"), DesignOnly(false), Editor(typeof(MetaItemIconWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int Padding
		{
			get
			{
				return this.MetaItemAnnotation.Padding;
			}
			set
			{
				this.MetaItemAnnotation.Padding = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				return this.MetaItemAnnotation.BackColor;
			}
			set
			{
				this.MetaItemAnnotation.BackColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.MetaItemAnnotation.ForeColor;
			}
			set
			{
				this.MetaItemAnnotation.ForeColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(1), Description("边框宽度"), DesignOnly(false), Editor(typeof(MetaItemIconWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int BorderWidth
		{
			get
			{
				return this.MetaItemAnnotation.BorderWidth;
			}
			set
			{
				this.MetaItemAnnotation.BorderWidth = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(false), Description("显示边框"), DesignOnly(false), ReadOnly(false)]
		public bool DrawBorder
		{
			get
			{
				return this.MetaItemAnnotation.DrawBorder;
			}
			set
			{
				this.MetaItemAnnotation.DrawBorder = value;
			}
		}

		[DebuggerNonUserCode]
		public MetaItemPropertyWrap()
		{
		}
	}
}
