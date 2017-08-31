using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.figure
{
	public class PictureBoxStyleProperties : GridStyleInfoCustomProperties
	{
		private static Type t;

		private static StyleInfoProperty ImageProperty;

		private static StyleInfoProperty SizeModeProperty;

		private static PictureBoxStyleProperties defaultObject;

		public static PictureBoxStyleProperties Default
		{
			get
			{
				return PictureBoxStyleProperties.defaultObject;
			}
		}

		[Browsable(true), Category("PictureBox"), Description("Indicates how the image is displayed.")]
		public PictureBoxSizeMode SizeMode
		{
			get
			{
				return (PictureBoxSizeMode)Conversions.ToInteger(this.style.GetValue(PictureBoxStyleProperties.SizeModeProperty));
			}
			set
			{
				this.style.SetValue(PictureBoxStyleProperties.SizeModeProperty, value);
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasSizeMode
		{
			get
			{
				return this.style.HasValue(PictureBoxStyleProperties.SizeModeProperty);
			}
		}

		[Browsable(true), Category("PictureBox"), Description("Gets or sets the image that the PictureBox displays.")]
		public Image Image
		{
			get
			{
				return (Image)this.style.GetValue(PictureBoxStyleProperties.ImageProperty);
			}
			set
			{
				this.style.SetValue(PictureBoxStyleProperties.ImageProperty, value);
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasImage
		{
			get
			{
				return this.style.HasValue(PictureBoxStyleProperties.ImageProperty);
			}
		}

		static PictureBoxStyleProperties()
		{
			PictureBoxStyleProperties.t = typeof(PictureBoxStyleProperties);
			PictureBoxStyleProperties.ImageProperty = GridStyleInfoCustomProperties.CreateStyleInfoProperty(PictureBoxStyleProperties.t, "Image");
			PictureBoxStyleProperties.SizeModeProperty = GridStyleInfoCustomProperties.CreateStyleInfoProperty(PictureBoxStyleProperties.t, "SizeMode");
			PictureBoxStyleProperties.defaultObject = new PictureBoxStyleProperties(GridStyleInfo.get_Default());
			PictureBoxStyleProperties.defaultObject.SizeMode = PictureBoxSizeMode.Normal;
			PictureBoxStyleProperties.defaultObject.Image = null;
		}

		public static void Initialize()
		{
		}

		public PictureBoxStyleProperties(GridStyleInfo style) : base(style)
		{
		}

		public PictureBoxStyleProperties()
		{
		}

		public void ResetSizeMode()
		{
			this.style.ResetValue(PictureBoxStyleProperties.SizeModeProperty);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private bool ShouldSerializeSizeMode()
		{
			return this.style.HasValue(PictureBoxStyleProperties.SizeModeProperty);
		}

		public void ResetImage()
		{
			this.style.ResetValue(PictureBoxStyleProperties.ImageProperty);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private bool ShouldSerializeImage()
		{
			return this.style.HasValue(PictureBoxStyleProperties.ImageProperty);
		}
	}
}
