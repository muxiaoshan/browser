using Atalasoft.Imaging.Annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class AnyAnnotation : FreehandAnnotation
	{
		private PointConnectMethod _PointConnect;

		private Brush _Brush;

		public Brush Brush
		{
			get
			{
				return this._Brush;
			}
			set
			{
				this._Brush = value;
			}
		}

		public PointConnectMethod PointConnect
		{
			get
			{
				return this._PointConnect;
			}
			set
			{
				if (!base.get_Locked() && base.get_ParentLayer() != null && !base.get_ParentLayer().get_Locked())
				{
					this._PointConnect = value;
					Region region;
					if (!base.get_Selected())
					{
						region = this.GetRegion();
						if (region != null)
						{
							base.get_Parent().get_Control().Invalidate(region);
							region.Dispose();
						}
					}
					region = new Region(this.get_Grips().GetBounds(base.get_Parent()));
					if (region != null)
					{
						base.get_Parent().get_Control().Invalidate(region);
						region.Dispose();
					}
				}
			}
		}

		public AnyAnnotation()
		{
			this._PointConnect = 0;
			this.Brush = new SolidBrush(Color.Transparent);
		}

		public override void Paint(Graphics graphics, PointF offset, PointF zoom, float resolution)
		{
			if (this.get_IsCreating())
			{
				graphics.DrawCurve(this.get_Pen(), this.GetPoints());
			}
			else
			{
				graphics.DrawClosedCurve(this.get_Pen(), this.GetPoints());
				graphics.FillClosedCurve(this.Brush, this.GetPoints());
			}
		}

		public override Region GetRegion()
		{
			checked
			{
				if (base.get_Parent() != null & base.get_Points().Count != 0 & base.get_Pen() != null)
				{
					GraphicsPath graphicsPath = new GraphicsPath();
					int num = base.get_Points().Count;
					int num2 = 0;
					if (this.PointConnect == 1 & num > 4)
					{
						double num3 = Math.IEEERemainder(Convert.ToDouble(num - 4), 3.0);
						if (num3 != 0.0)
						{
							num2 = 3 - int.Parse(Conversions.ToString(Math.Ceiling(num3)));
							num += num2;
						}
					}
					PointF[] array = new PointF[num + 1];
					PointF pointF = new PointF(base.get_Parent().get_DocumentPosition().X, base.get_Parent().get_DocumentPosition().Y);
					int num4 = 0;
					float documentResolution = base.get_Parent().get_DocumentResolution();
					IEnumerator enumerator = base.get_Points().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object expr_F7 = enumerator.Current;
							PointF pointF3;
							PointF pointF2 = (expr_F7 != null) ? ((PointF)expr_F7) : pointF3;
							array[num4] = unchecked(new PointF((pointF2.X * base.get_Parent().get_DocumentScale().X + pointF.X) * documentResolution, (pointF2.Y * base.get_Parent().get_DocumentScale().Y + pointF.Y) * documentResolution));
							num4++;
						}
						graphicsPath.StartFigure();
						switch (this._PointConnect)
						{
						case 0:
							graphicsPath.AddLines(array);
							break;
						case 1:
							if (num2 != 0)
							{
								int arg_1B1_0 = num - num2;
								int num5 = num - 1;
								for (int i = arg_1B1_0; i <= num5; i++)
								{
									array[i] = array[i - 1];
								}
							}
							graphicsPath.AddBeziers(array);
							break;
						case 2:
							graphicsPath.AddCurve(array);
							break;
						}
					}
					finally
					{
					}
					graphicsPath.CloseFigure();
					Region result = new Region(graphicsPath);
					graphicsPath.Dispose();
					return result;
				}
				return new Region(Rectangle.Empty);
			}
		}

		public RectangleF GetBounds()
		{
			float documentResolution = base.get_Parent().get_DocumentResolution();
			PointF location = new PointF(this.get_Location().X * base.get_Parent().get_DocumentScale().X * documentResolution + base.get_Parent().get_DocumentPosition().X * documentResolution, this.get_Location().Y * base.get_Parent().get_DocumentScale().Y * documentResolution + base.get_Parent().get_DocumentPosition().Y * documentResolution);
			SizeF size = new SizeF(this.get_Size().Width * base.get_Parent().get_DocumentScale().X * documentResolution, this.get_Size().Height * base.get_Parent().get_DocumentScale().Y * documentResolution);
			if (size.Width < 0f)
			{
				location = new PointF(location.X + size.Width, location.Y);
				size = new SizeF(-size.Width, size.Height);
			}
			if (size.Height < 0f)
			{
				location = new PointF(location.X, location.Y + size.Height);
				size = new SizeF(size.Width, -size.Height);
			}
			if (this._PointConnect != 2)
			{
				RectangleF result = new RectangleF(location, size);
				return result;
			}
			RectangleF bounds = new RectangleF(location, size);
			Region region = this.GetRegion();
			if (region != null)
			{
				Graphics graphics = Graphics.FromHwnd(base.get_Parent().get_Control().Handle);
				bounds = region.GetBounds(graphics);
				graphics.Dispose();
				region.Dispose();
			}
			return bounds;
		}

		public override string ToXmp()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.AnyHotSpotFreeHand\">");
			stringBuilder.Append(base.SerializeBase());
			stringBuilder.Append("<ann:PointConnectMode>" + this.PointConnect.ToString(CultureInfo.InvariantCulture) + "</ann:PointConnectMode>");
			stringBuilder.Append("<ann:Points>");
			stringBuilder.Append("<rdf:Seq>");
			checked
			{
				PointF[] array = new PointF[base.get_Points().Count - 1 + 1];
				base.get_Points().CopyTo(0, array, 0, array.Length);
				PointF[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					PointF pointF = array2[i];
					stringBuilder.Append(string.Concat(new string[]
					{
						"<rdf:li>",
						pointF.X.ToString(CultureInfo.InvariantCulture),
						",",
						pointF.Y.ToString(CultureInfo.InvariantCulture),
						"</rdf:li>"
					}));
				}
				stringBuilder.Append("</rdf:Seq>");
				stringBuilder.Append("</ann:Points>");
				stringBuilder.Append("</ann:CustomAnnotation>");
				return stringBuilder.ToString();
			}
		}

		public override void FromXmp(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			base.DeserializeBase(reader);
			while (reader.Read())
			{
				if (Operators.CompareString(reader.LocalName, "PointConnectMode", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.PointConnect = int.Parse(reader.Value, CultureInfo.InvariantCulture);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "Points", false) == 0 & reader.IsStartElement())
				{
					ArrayList arrayList = new ArrayList();
					while (reader.Read())
					{
						if (Operators.CompareString(reader.LocalName, "li", false) == 0 & !reader.IsEmptyElement)
						{
							reader.Read();
							string value = reader.Value;
							float x = float.Parse(value.Split(new char[]
							{
								','
							})[0]);
							float y = float.Parse(value.Split(new char[]
							{
								','
							})[1]);
							PointF pointF = new PointF(x, y);
							arrayList.Add(pointF);
							reader.Read();
						}
						else if (Operators.CompareString(reader.LocalName, "Seq", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
						{
							break;
						}
					}
					if (arrayList.Count > 0)
					{
						PointF[] array = new PointF[checked(arrayList.Count - 1 + 1)];
						arrayList.CopyTo(0, array, 0, arrayList.Count);
						base.SetPoints(array);
						base.CalculateArea();
						base.CalculatePointPercentages();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "CustomAnnotation", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}
	}
}
