using Atalasoft.Imaging.Annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class CustomIconAnnotation : FreehandAnnotation
	{
		private string _IconName;

		private Image _IconImage;

		private string _IconData;

		private string _IconCode;

		private string _IconDesc;

		private string _HotSpotCode;

		private HatchStyle _HatchStyle;

		private Color _BackColor;

		private Color _ForeColor;

		private int _BorderWidth;

		private bool _DrawBorder;

		private bool _DrawImage;

		private bool _DrawHatch;

		private Bitmap _tmpBitMap;

		private PointConnectMethod _PointConnect;

		public string IconData
		{
			get
			{
				return this._IconData;
			}
			set
			{
				this._IconData = value;
			}
		}

		public Image IconImage
		{
			get
			{
				return this._IconImage;
			}
			set
			{
				this._IconImage = value;
			}
		}

		public string IconName
		{
			get
			{
				return this._IconName;
			}
			set
			{
				this._IconName = value;
			}
		}

		public string IconCode
		{
			get
			{
				return this._IconCode;
			}
			set
			{
				this._IconCode = value;
			}
		}

		public string IconDesc
		{
			get
			{
				return this._IconDesc;
			}
			set
			{
				this._IconDesc = value;
			}
		}

		public string HotSpotCode
		{
			get
			{
				return this._HotSpotCode;
			}
			set
			{
				this._HotSpotCode = value;
			}
		}

		public HatchStyle HatchStyle
		{
			get
			{
				return this._HatchStyle;
			}
			set
			{
				this._HatchStyle = value;
			}
		}

		public Color BackColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				this._BackColor = value;
			}
		}

		public Color ForeColor
		{
			get
			{
				return this._ForeColor;
			}
			set
			{
				this._ForeColor = value;
			}
		}

		public int BorderWidth
		{
			get
			{
				return this._BorderWidth;
			}
			set
			{
				this._BorderWidth = value;
			}
		}

		public bool DrawBorder
		{
			get
			{
				return this._DrawBorder;
			}
			set
			{
				this._DrawBorder = value;
			}
		}

		public bool DrawImage
		{
			get
			{
				return this._DrawImage;
			}
			set
			{
				this._DrawImage = value;
			}
		}

		public bool DrawHatch
		{
			get
			{
				return this._DrawHatch;
			}
			set
			{
				this._DrawHatch = value;
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

		public CustomIconAnnotation()
		{
			this._tmpBitMap = new Bitmap(16, 16);
			this._DrawImage = true;
			this._DrawBorder = false;
			this._DrawHatch = false;
			this._BorderWidth = 1;
			this._PointConnect = 0;
		}

		public Bitmap GetIconImage()
		{
			Graphics graphics = Graphics.FromImage(this._tmpBitMap);
			graphics.Clear(Color.Transparent);
			if (this.DrawImage)
			{
				if (this.IconImage != null)
				{
					graphics.DrawImage(this.IconImage, 0, 0);
				}
			}
			else if (this.DrawHatch)
			{
				HatchBrush brush = new HatchBrush(this.HatchStyle, this.ForeColor, this.BackColor);
				graphics.FillRectangle(brush, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			else
			{
				SolidBrush brush2 = new SolidBrush(this.BackColor);
				graphics.FillRectangle(brush2, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			if (this.DrawBorder)
			{
				Pen pen = new Pen(this.ForeColor, (float)this.BorderWidth);
				graphics.DrawRectangle(pen, 0, 0, this._tmpBitMap.Width, this._tmpBitMap.Height);
			}
			return this._tmpBitMap;
		}

		public override void Paint(Graphics graphics, PointF offset, PointF zoom, float resolution)
		{
			if (this.get_IsCreating())
			{
				Pen pen = new Pen(this.ForeColor, (float)this.BorderWidth);
				graphics.DrawCurve(pen, this.GetPoints());
			}
			else
			{
				this.CheckPoints();
				if (this._DrawImage)
				{
					Region clip = graphics.Clip;
					graphics.Clip = this.GetRegion();
					graphics.DrawImage(this._IconImage, this.get_Location().X, this.get_Location().Y, this.get_Size().Width, this.get_Size().Height);
					graphics.Clip = clip;
				}
				else if (this._DrawHatch)
				{
					HatchBrush brush = new HatchBrush(this.HatchStyle, this.ForeColor, this.BackColor);
					graphics.FillClosedCurve(brush, this.GetPoints());
				}
				else
				{
					SolidBrush brush2 = new SolidBrush(this.BackColor);
					graphics.FillClosedCurve(brush2, this.GetPoints());
				}
				if (this._DrawBorder)
				{
					Pen pen2 = new Pen(this.ForeColor, (float)this.BorderWidth);
					graphics.DrawClosedCurve(this.get_Pen(), this.GetPoints());
				}
			}
		}

		private void CheckPoints()
		{
			checked
			{
				if (base.get_Points().Count < 4)
				{
					base.get_Points().Insert(base.get_Points().Count, RuntimeHelpers.GetObjectValue(base.get_Points()[base.get_Points().Count - 1]));
					base.get_Points().Insert(base.get_Points().Count, RuntimeHelpers.GetObjectValue(base.get_Points()[base.get_Points().Count - 1]));
				}
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
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.CustomIconAnnotation\">");
			stringBuilder.Append(base.SerializeBase());
			stringBuilder.Append("<ann:Image>" + base.SerializeObject(this.IconImage) + "</ann:Image>");
			stringBuilder.Append("<ann:IconName>" + this.IconName + "</ann:IconName>");
			stringBuilder.Append("<ann:IconCode>" + this.IconCode + "</ann:IconCode>");
			stringBuilder.Append("<ann:IconDesc>" + this.IconDesc + "</ann:IconDesc>");
			stringBuilder.Append("<ann:HotSpotCode>" + this.HotSpotCode + "</ann:HotSpotCode>");
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
				stringBuilder.Append("<ann:DrawBorder>" + this.DrawBorder.ToString() + "</ann:DrawBorder>");
				stringBuilder.Append("<ann:BorderWidth>" + this.BorderWidth.ToString() + "</ann:BorderWidth>");
				stringBuilder.Append("<ann:DrawImage>" + this.DrawImage.ToString() + "</ann:DrawImage>");
				stringBuilder.Append("<ann:DrawHatch>" + this.DrawHatch.ToString() + "</ann:DrawHatch>");
				stringBuilder.Append("<ann:HatchStyle>" + this.HatchStyle.ToString() + "</ann:HatchStyle>");
				stringBuilder.Append("<ann:ForeColor>" + this.ForeColor.Name + "</ann:ForeColor>");
				stringBuilder.Append("<ann:BackColor>" + this.BackColor.Name + "</ann:BackColor>");
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
				if (Operators.CompareString(reader.LocalName, "Image", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.IconImage = (Bitmap)base.DeserializeObject(reader.Value);
						reader.Read();
					}
				}
				if (Operators.CompareString(reader.LocalName, "IconName", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.IconName = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "IconCode", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.IconCode = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "IconDesc", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.IconDesc = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "HotSpotCode", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.HotSpotCode = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "HatchStyle", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.HatchStyle = (HatchStyle)Conversions.ToInteger(Enum.Parse(this.HatchStyle.GetType(), reader.Value));
					reader.Read();
				}
				else if (Operators.CompareString(reader.LocalName, "DrawBorder", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawBorder = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.LocalName, "DrawImage", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawImage = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.LocalName, "DrawHatch", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.DrawHatch = bool.Parse(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.LocalName, "ForeColor", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.ForeColor = ControlXML.StrToColor(reader.Value);
					reader.Read();
				}
				else if (Operators.CompareString(reader.LocalName, "BackColor", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.BackColor = ControlXML.StrToColor(reader.Value);
					reader.Read();
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
				bool flag = true;
				if (this.get_Points() == null)
				{
					flag = false;
				}
				else if (this.get_Points().Count == 0)
				{
					flag = false;
				}
				if (!flag)
				{
					PointF[] array2 = new PointF[4];
					array2[0] = new PointF(this.get_Location().X, this.get_Location().Y);
					array2[1] = new PointF(this.get_Location().X + this.get_Size().Width, this.get_Location().Y);
					array2[2] = new PointF(this.get_Location().X + this.get_Size().Width, this.get_Location().Y + this.get_Size().Height);
					array2[3] = new PointF(this.get_Location().X, this.get_Location().Y + this.get_Size().Height);
					this.SetPoints(AnnotateUtil.RefinePoints(array2));
				}
			}
		}
	}
}
