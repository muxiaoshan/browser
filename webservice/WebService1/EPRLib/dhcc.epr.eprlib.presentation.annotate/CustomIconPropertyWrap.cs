using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class CustomIconPropertyWrap
	{
		public delegate void IconPropertyChangedEventHandler();

		public CustomIconAnnotation CustomIconAnnotation;

		private CustomIconPropertyWrap.IconPropertyChangedEventHandler IconPropertyChangedEvent;

		public event CustomIconPropertyWrap.IconPropertyChangedEventHandler IconPropertyChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.IconPropertyChangedEvent = (CustomIconPropertyWrap.IconPropertyChangedEventHandler)Delegate.Combine(this.IconPropertyChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.IconPropertyChangedEvent = (CustomIconPropertyWrap.IconPropertyChangedEventHandler)Delegate.Remove(this.IconPropertyChangedEvent, value);
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图示名称"), DesignOnly(false), ReadOnly(false)]
		public string Name
		{
			get
			{
				return this.CustomIconAnnotation.IconName;
			}
			set
			{
				this.CustomIconAnnotation.IconName = value;
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图示代码"), DesignOnly(false), ReadOnly(false)]
		public string Code
		{
			get
			{
				return this.CustomIconAnnotation.IconCode;
			}
			set
			{
				this.CustomIconAnnotation.IconCode = value;
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图示说明"), DesignOnly(false), ReadOnly(false)]
		public string Desc
		{
			get
			{
				return this.CustomIconAnnotation.IconDesc;
			}
			set
			{
				this.CustomIconAnnotation.IconDesc = value;
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图像"), DesignOnly(false), ReadOnly(false)]
		public Image Image
		{
			get
			{
				return this.CustomIconAnnotation.IconImage;
			}
			set
			{
				this.CustomIconAnnotation.IconImage = value;
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				return this.CustomIconAnnotation.BackColor;
			}
			set
			{
				this.CustomIconAnnotation.BackColor = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.CustomIconAnnotation.ForeColor;
			}
			set
			{
				this.CustomIconAnnotation.ForeColor = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(3), Description("线条"), DesignOnly(false), Editor(typeof(CusntomIconHatchTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public HatchStyle HatchStyle
		{
			get
			{
				return this.CustomIconAnnotation.HatchStyle;
			}
			set
			{
				this.CustomIconAnnotation.HatchStyle = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(1), Description("边框宽度"), DesignOnly(false), Editor(typeof(CusntomIconWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int BorderWidth
		{
			get
			{
				return this.CustomIconAnnotation.BorderWidth;
			}
			set
			{
				this.CustomIconAnnotation.BorderWidth = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(false), Description("显示边框"), DesignOnly(false), ReadOnly(false)]
		public bool DrawBorder
		{
			get
			{
				return this.CustomIconAnnotation.DrawBorder;
			}
			set
			{
				this.CustomIconAnnotation.DrawBorder = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(false), Description("显示图标"), DesignOnly(false), ReadOnly(false)]
		public bool DrawImage
		{
			get
			{
				return this.CustomIconAnnotation.DrawImage;
			}
			set
			{
				this.CustomIconAnnotation.DrawImage = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(false), Description("显示线条"), DesignOnly(false), ReadOnly(false)]
		public bool DrawHatch
		{
			get
			{
				return this.CustomIconAnnotation.DrawHatch;
			}
			set
			{
				this.CustomIconAnnotation.DrawHatch = value;
				this.CustomIconAnnotation.GetIconImage();
				CustomIconPropertyWrap.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[DebuggerNonUserCode]
		public CustomIconPropertyWrap()
		{
		}
	}
}
