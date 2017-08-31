using Atalasoft.Imaging.Annotate;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class EPRHotSpotRectAngular : RectangleAnnotation, IEPRHotSpot
	{
		private Color _Color;

		private EPRAnnoMode _AnnoMode;

		private string _HSName;

		private string _HSCode;

		private string _HSDesc;

		private bool _MultiSelected;

		public bool MultiSelected
		{
			get
			{
				return this._MultiSelected;
			}
			set
			{
				this._MultiSelected = value;
				this.ResetPenAndBrush();
			}
		}

		public Color Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				this._Color = value;
				this.ResetPenAndBrush();
			}
		}

		public EPRAnnoMode AnnoMode
		{
			get
			{
				return this._AnnoMode;
			}
			set
			{
				this._AnnoMode = value;
				this.ResetPenAndBrush();
			}
		}

		public string HSName
		{
			get
			{
				return this._HSName;
			}
			set
			{
				this._HSName = value;
				base.set_ToolTip(this._HSName);
			}
		}

		public string HSCode
		{
			get
			{
				return this._HSCode;
			}
			set
			{
				this._HSCode = value;
			}
		}

		public string HSDesc
		{
			get
			{
				return this._HSDesc;
			}
			set
			{
				this._HSDesc = value;
			}
		}

		public EPRHotSpotRectAngular()
		{
			base.add_Click(new EventHandler(this.EPRHotSpotEllipse_Click));
			base.set_MouseOverCursor(Cursors.Hand);
			this._HSName = "";
			this._HSCode = "";
			this._HSDesc = "";
			this._Color = Color.FromArgb(255, 255, 255, 0);
			this.ResetPenAndBrush();
			base.set_MouseOverCursor(Cursors.Hand);
			base.set_LockedImage(null);
		}

		public void ResetPenAndBrush()
		{
			if (this.AnnoMode == EPRAnnoMode.Design)
			{
				if (this.get_Locked())
				{
					this.Unlock();
					base.set_LockedImage(null);
					Color color = Color.FromArgb(100, (int)this.Color.R, (int)this.Color.G, (int)this.Color.B);
					Brush brush = new SolidBrush(color);
					Pen pen = new Pen(color);
					this.set_Brush(brush);
					this.set_Pen(pen);
					this.Lock();
				}
				else
				{
					Color color = Color.FromArgb(100, (int)this.Color.R, (int)this.Color.G, (int)this.Color.B);
					Brush brush2 = new SolidBrush(color);
					Pen pen2 = new Pen(color);
					this.set_Brush(brush2);
					this.set_Pen(pen2);
				}
			}
			else
			{
				this.Unlock();
				base.set_LockedImage(null);
				Color color;
				if (this.MultiSelected)
				{
					color = Color.FromArgb(100, (int)this.Color.R, (int)this.Color.G, (int)this.Color.B);
				}
				else
				{
					color = Color.Transparent;
				}
				Brush brush3 = new SolidBrush(color);
				Pen pen3 = new Pen(color);
				this.set_Brush(brush3);
				this.set_Pen(pen3);
				this.Lock();
			}
		}

		public override string ToXmp()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.EPRHotSpotRectAngular\">");
			stringBuilder.Append(base.SerializeBase());
			stringBuilder.Append("<ann:HSName>" + this.HSName + "</ann:HSName>");
			stringBuilder.Append("<ann:HSCode>" + this.HSCode + "</ann:HSCode>");
			stringBuilder.Append("<ann:HSDesc>" + this.HSDesc + "</ann:HSDesc>");
			stringBuilder.Append("<ann:Color>" + this.Color.Name + "</ann:Color>");
			stringBuilder.Append("</ann:CustomAnnotation>");
			return stringBuilder.ToString();
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
				if (Operators.CompareString(reader.LocalName, "HSName", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.HSName = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "HSCode", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.HSCode = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "HSDesc", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.HSDesc = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "Color", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.Color = AnnotateUtil.StrToColor(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "CustomAnnotation", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}

		private void EPRHotSpotEllipse_Click(object sender, EventArgs e)
		{
			if (this.AnnoMode == EPRAnnoMode.Edit)
			{
				if (this.MultiSelected)
				{
					this.MultiSelected = false;
				}
				else
				{
					this.MultiSelected = true;
				}
				this.ResetPenAndBrush();
			}
		}
	}
}
