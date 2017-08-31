using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Security.Permissions;
using System.Windows.Forms.Design;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class HatchStyleTypeEditor : UITypeEditor
	{
		private IWindowsFormsEditorService edSvc;

		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override void PaintValue(PaintValueEventArgs pe)
		{
			HatchStyle hatchstyle = (HatchStyle)Conversions.ToInteger(pe.Value);
			HatchBrush brush = new HatchBrush(hatchstyle, Color.Black, Color.White);
			pe.Graphics.FillRectangle(brush, pe.Bounds);
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
				LinePropertyWrap linePropertyWrap = (LinePropertyWrap)context.Instance;
				IWindowsFormsEditorService arg_4B_0 = this.edSvc;
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