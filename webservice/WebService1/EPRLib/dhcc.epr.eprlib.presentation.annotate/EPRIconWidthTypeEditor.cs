using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Windows.Forms.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class EPRIconWidthTypeEditor : UITypeEditor
	{
		private IWindowsFormsEditorService edSvc;

		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override void PaintValue(PaintValueEventArgs pe)
		{
			int num = Conversions.ToInteger(pe.Value);
			checked
			{
				int num2 = (int)Math.Round(Math.Abs((double)pe.Bounds.Height / 2.0));
				if (num == 0)
				{
					pe.Graphics.FillRectangle(Brushes.YellowGreen, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
				}
				else if (num == 1)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
				}
				else if (num == 2)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
				}
				else if (num == 3)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 1, pe.Bounds.Width - 4, num2 - 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
				}
				else if (num == 4)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 1, pe.Bounds.Width - 4, num2 - 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 2, pe.Bounds.Width - 4, num2 + 2);
				}
				else if (num == 5)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 2, pe.Bounds.Width - 4, num2 - 2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 1, pe.Bounds.Width - 4, num2 - 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 2, pe.Bounds.Width - 4, num2 + 2);
				}
				else if (num == 6)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 2, pe.Bounds.Width - 4, num2 - 2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 1, pe.Bounds.Width - 4, num2 - 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 2, pe.Bounds.Width - 4, num2 + 2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 3, pe.Bounds.Width - 4, num2 + 3);
				}
				else if (num == 7)
				{
					pe.Graphics.FillRectangle(Brushes.Black, pe.Bounds);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 3, pe.Bounds.Width - 4, num2 - 3);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 2, pe.Bounds.Width - 4, num2 - 2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 - 1, pe.Bounds.Width - 4, num2 - 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2, pe.Bounds.Width - 4, num2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 1, pe.Bounds.Width - 4, num2 + 1);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 2, pe.Bounds.Width - 4, num2 + 2);
					pe.Graphics.DrawLine(Pens.White, 4, num2 + 3, pe.Bounds.Width - 4, num2 + 3);
				}
			}
		}

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.DropDown;
		}

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (context != null & context.Instance != null & provider != null)
			{
				this.edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				EPRIconProperty ePRIconProperty = (EPRIconProperty)context.Instance;
				if (this.edSvc != null)
				{
					UCLineWidth uCLineWidth = new UCLineWidth(ePRIconProperty.BorderWidth);
					uCLineWidth.ValueChanged += new UCLineWidth.ValueChangedEventHandler(this.ValueChanged);
					this.edSvc.DropDownControl(uCLineWidth);
					value = uCLineWidth.LineWidth;
				}
			}
			return value;
		}

		private void ValueChanged()
		{
			if (this.edSvc != null)
			{
				this.edSvc.CloseDropDown();
			}
		}
	}
}
