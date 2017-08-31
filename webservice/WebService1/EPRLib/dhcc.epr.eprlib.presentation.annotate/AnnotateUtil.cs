using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class AnnotateUtil
	{
		private static AnnoPictureBox _AnnoPictureBox;

		[DebuggerNonUserCode]
		public AnnotateUtil()
		{
		}

		public static Color StrToColor(string str)
		{
			if (Operators.CompareString(str.Substring(0, 2), "ff", false) == 0)
			{
				return Color.FromArgb(Convert.ToInt32(str, 16));
			}
			return Color.FromName(str);
		}

		public static Stream StrToStream(string str)
		{
			return new MemoryStream(Encoding.UTF8.GetBytes(str));
		}

		public static Stream StrToImageStream(string str)
		{
			byte[] buffer = Convert.FromBase64String(str);
			return new MemoryStream(buffer);
		}

		public static string ImageStreamToStr(MemoryStream objStream)
		{
			byte[] inArray = objStream.ToArray();
			return Convert.ToBase64String(inArray);
		}

		public static Image BurnImageData(string strImage, string strAnno)
		{
			if (AnnotateUtil._AnnoPictureBox == null)
			{
				AnnotateUtil._AnnoPictureBox = new AnnoPictureBox();
			}
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			AnnotateUtil._AnnoPictureBox.Image = Image.FromStream(AnnotateUtil.StrToImageStream(strImage));
			AnnotateUtil._AnnoPictureBox.Size = AnnotateUtil._AnnoPictureBox.Image.Size;
			strAnno = strAnno.Replace("^^@", "]]>");
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(strAnno), 0);
			Graphics graphics;
			try
			{
				graphics = Graphics.FromImage(AnnotateUtil._AnnoPictureBox.Image);
			}
			catch (Exception expr_90)
			{
				ProjectData.SetProjectError(expr_90);
				Exception ex = expr_90;
				if (!AnnotateUtil._AnnoPictureBox.Image.RawFormat.Equals(ImageFormat.Bmp))
				{
					throw ex;
				}
				int width = AnnotateUtil._AnnoPictureBox.Image.Width;
				int height = AnnotateUtil._AnnoPictureBox.Image.Height;
				Bitmap bitmap = new Bitmap(width, height);
				graphics = Graphics.FromImage(bitmap);
				Graphics arg_117_0 = graphics;
				Image arg_117_1 = AnnotateUtil._AnnoPictureBox.Image;
				Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				Rectangle arg_117_2 = rectangle;
				Rectangle srcRect = new Rectangle(0, 0, width, height);
				arg_117_0.DrawImage(arg_117_1, arg_117_2, srcRect, GraphicsUnit.Pixel);
				AnnotateUtil._AnnoPictureBox.Image = bitmap;
				ProjectData.ClearProjectError();
			}
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.PaintAllAnnotations(graphics);
			return AnnotateUtil._AnnoPictureBox.Image;
		}

		public static Image BurnImageData(byte[] strImage, string strAnno)
		{
			if (AnnotateUtil._AnnoPictureBox == null)
			{
				AnnotateUtil._AnnoPictureBox = new AnnoPictureBox();
			}
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
			MemoryStream stream = new MemoryStream(strImage);
			AnnotateUtil._AnnoPictureBox.Image = Image.FromStream(stream);
			AnnotateUtil._AnnoPictureBox.Size = AnnotateUtil._AnnoPictureBox.Image.Size;
			strAnno = strAnno.Replace("^^@", "]]>");
			if (string.IsNullOrEmpty(strAnno))
			{
				return AnnotateUtil._AnnoPictureBox.Image;
			}
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(strAnno), 0);
			Graphics graphics;
			try
			{
				graphics = Graphics.FromImage(AnnotateUtil._AnnoPictureBox.Image);
			}
			catch (Exception expr_A5)
			{
				ProjectData.SetProjectError(expr_A5);
				Exception ex = expr_A5;
				if (!AnnotateUtil._AnnoPictureBox.Image.RawFormat.Equals(ImageFormat.Bmp))
				{
					throw ex;
				}
				int width = AnnotateUtil._AnnoPictureBox.Image.Width;
				int height = AnnotateUtil._AnnoPictureBox.Image.Height;
				Bitmap bitmap = new Bitmap(width, height);
				graphics = Graphics.FromImage(bitmap);
				Graphics arg_130_0 = graphics;
				Image arg_130_1 = AnnotateUtil._AnnoPictureBox.Image;
				Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				Rectangle arg_130_2 = rectangle;
				Rectangle srcRect = new Rectangle(0, 0, width, height);
				arg_130_0.DrawImage(arg_130_1, arg_130_2, srcRect, GraphicsUnit.Pixel);
				AnnotateUtil._AnnoPictureBox.Image = bitmap;
				ProjectData.ClearProjectError();
			}
			AnnotateUtil._AnnoPictureBox.AnnoCtrl.PaintAllAnnotations(graphics);
			return AnnotateUtil._AnnoPictureBox.Image;
		}

		public static PointF[] RefinePoints(PointF[] inPointFs)
		{
			float space = 2f;
			ArrayList arrayList = new ArrayList();
			int arg_14_0 = 0;
			checked
			{
				int num = inPointFs.Length - 1;
				for (int i = arg_14_0; i <= num; i++)
				{
					if (i == 0)
					{
						PointF pointF = inPointFs[0];
						arrayList.Add(pointF);
					}
					else if (i == inPointFs.Length)
					{
						PointF pointF2 = inPointFs[0];
						PointF pointF;
						AnnotateUtil.RefineTwoPointF(pointF, pointF2, space, arrayList);
					}
					else
					{
						PointF pointF2 = inPointFs[i];
						PointF pointF;
						AnnotateUtil.RefineTwoPointF(pointF, pointF2, space, arrayList);
						arrayList.Add(pointF2);
						pointF = pointF2;
					}
				}
				PointF[] array = new PointF[arrayList.Count - 1 + 1];
				arrayList.CopyTo(0, array, 0, arrayList.Count);
				return array;
			}
		}

		public static void RefineTwoPointF(PointF startPointF, PointF endPointF, float space, ArrayList resultArray)
		{
			if (startPointF.X == endPointF.X)
			{
				float num = endPointF.Y - startPointF.Y;
				if (num < 0f)
				{
					space = -space;
					num = -num;
				}
				float num2 = space;
				while (Math.Abs(num2) < num)
				{
					PointF pointF = new PointF(startPointF.X, startPointF.Y + num2);
					resultArray.Add(pointF);
					num2 += space;
				}
			}
			else if (startPointF.Y == endPointF.Y)
			{
				float num3 = endPointF.X - startPointF.X;
				if (num3 < 0f)
				{
					space = -space;
					num3 = -num3;
				}
				float num4 = space;
				while (Math.Abs(num4) < num3)
				{
					PointF pointF = new PointF(startPointF.X + num4, startPointF.Y);
					resultArray.Add(pointF);
					num4 += space;
				}
			}
			else
			{
				float num5 = endPointF.X - startPointF.X;
				float num6 = endPointF.Y - startPointF.Y;
				float num7 = num6 / num5;
				if (num5 < 0f)
				{
					space = -space;
					num5 = -num5;
				}
				float num8 = space;
				float num9 = num8 * num7;
				while (Math.Abs(num8) < num5)
				{
					PointF pointF = new PointF(startPointF.X + num8, startPointF.Y + num9);
					resultArray.Add(pointF);
					num8 += space;
					num9 = num8 * num7;
				}
			}
		}

		public static PointF[] GetEllipsePoints(PointF centerPoint, float a, float b)
		{
			ArrayList arrayList = new ArrayList();
			float num = 0f;
			do
			{
				ArrayList arg_43_0 = arrayList;
				PointF pointF = new PointF((float)((double)centerPoint.X + (double)a * Math.Cos((double)num)), (float)((double)centerPoint.Y + (double)b * Math.Sin((double)num)));
				arg_43_0.Add(pointF);
				num += 0.02f;
			}
			while (num <= 6.26f);
			PointF[] array = new PointF[checked(arrayList.Count - 1 + 1)];
			arrayList.CopyTo(0, array, 0, arrayList.Count);
			return array;
		}
	}
}
