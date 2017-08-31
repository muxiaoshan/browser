using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class EPRIconProperty
	{
		public delegate void IconPropertyChangedEventHandler();

		public IconAnnotation IconAnnotation;

		private EPRIconProperty.IconPropertyChangedEventHandler IconPropertyChangedEvent;

		public event EPRIconProperty.IconPropertyChangedEventHandler IconPropertyChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.IconPropertyChangedEvent = (EPRIconProperty.IconPropertyChangedEventHandler)Delegate.Combine(this.IconPropertyChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.IconPropertyChangedEvent = (EPRIconProperty.IconPropertyChangedEventHandler)Delegate.Remove(this.IconPropertyChangedEvent, value);
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图示名称"), DesignOnly(false), ReadOnly(false)]
		public string Name
		{
			get
			{
				return this.IconAnnotation.IconName;
			}
			set
			{
				this.IconAnnotation.IconName = value;
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.IconCode;
			}
			set
			{
				this.IconAnnotation.IconCode = value;
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.IconDesc;
			}
			set
			{
				this.IconAnnotation.IconDesc = value;
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("图标"), DesignOnly(false), ReadOnly(false)]
		public Image Image
		{
			get
			{
				return this.IconAnnotation.IconImage;
			}
			set
			{
				this.IconAnnotation.IconImage = value;
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.BackColor;
			}
			set
			{
				this.IconAnnotation.BackColor = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.ForeColor;
			}
			set
			{
				this.IconAnnotation.ForeColor = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(3), Description("线条"), DesignOnly(false), Editor(typeof(EPRIconHatchTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public HatchStyle HatchStyle
		{
			get
			{
				return this.IconAnnotation.HatchStyle;
			}
			set
			{
				this.IconAnnotation.HatchStyle = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(1), Description("边框宽度"), DesignOnly(false), Editor(typeof(EPRIconWidthTypeEditor), typeof(UITypeEditor)), ReadOnly(false)]
		public int BorderWidth
		{
			get
			{
				return this.IconAnnotation.BorderWidth;
			}
			set
			{
				this.IconAnnotation.BorderWidth = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.DrawBorder;
			}
			set
			{
				this.IconAnnotation.DrawBorder = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.DrawImage;
			}
			set
			{
				this.IconAnnotation.DrawImage = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
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
				return this.IconAnnotation.DrawHatch;
			}
			set
			{
				this.IconAnnotation.DrawHatch = value;
				this.IconAnnotation.GetIconImage();
				EPRIconProperty.IconPropertyChangedEventHandler iconPropertyChangedEvent = this.IconPropertyChangedEvent;
				if (iconPropertyChangedEvent != null)
				{
					iconPropertyChangedEvent();
				}
			}
		}

		[DebuggerNonUserCode]
		public EPRIconProperty()
		{
		}
	}
}
