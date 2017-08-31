using Atalasoft.Imaging.Annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class ArrowLineAnnotation : LineAnnotation
	{
		[DebuggerNonUserCode]
		public ArrowLineAnnotation()
		{
		}

		public override string ToXmp()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.ArrowLineAnnotation\">");
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
			this.get_Pen().CustomEndCap = ArrowLineAnnotation.GetEndCap(this.get_Pen());
		}

		public static AdjustableArrowCap GetEndCap(Pen pen)
		{
			return new AdjustableArrowCap(pen.Width * 4f, pen.Width * 4f, true);
		}
	}
}
