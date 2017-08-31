using Atalasoft.Imaging.Annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class CurveLinesAnnotation : LinesAnnotation
	{
		[DebuggerNonUserCode]
		public CurveLinesAnnotation()
		{
		}

		public override void Paint(Graphics graphics, PointF offset, PointF zoom, float resolution)
		{
			PointF[] array = this.GetPoints();
			int num = array.Length;
			checked
			{
				if (num <= 1)
				{
					base.Paint(graphics, offset, zoom, resolution);
				}
				else
				{
					if (this.get_IsCreating())
					{
						array = (PointF[])Utils.CopyArray((Array)array, new PointF[array.Length + 1]);
						Point p = this.get_Parent().get_Control().PointToClient(Control.MousePosition);
						array.SetValue(p, array.Length - 1);
					}
					graphics.DrawCurve(this.get_Pen(), array);
				}
			}
		}

		public override string ToXmp()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.CurveLinesAnnotation\">");
			stringBuilder.Append(base.ToXmp());
			stringBuilder.Append("</ann:CustomAnnotation>");
			return stringBuilder.ToString();
		}

		public override void FromXmp(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			base.FromXmp(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.LocalName, "CustomAnnotation", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
