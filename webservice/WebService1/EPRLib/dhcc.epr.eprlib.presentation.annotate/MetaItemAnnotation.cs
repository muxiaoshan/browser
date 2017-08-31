using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class MetaItemAnnotation : FrameableAnnotation
	{
		private Color _BackColor;

		private Color _ForeColor;

		private Font _Font;

		private int _BorderWidth;

		private int _Padding;

		private string _MetaItemName;

		private bool _DrawBorder;

		private string _Text;

		private string _BindCode;

		private Control _BindControl;

		private MMetaItem _BindMetaItem;

		private NInstanceItem _BindInstanceItem;

		private bool _AllowEdit;

		private bool _EditMode;

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

		public Font Font
		{
			get
			{
				return this._Font;
			}
			set
			{
				this._Font = value;
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

		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		public int Padding
		{
			get
			{
				return this._Padding;
			}
			set
			{
				this._Padding = value;
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

		public string MetaItemName
		{
			get
			{
				return this._MetaItemName;
			}
			set
			{
				this._MetaItemName = value;
			}
		}

		public string BindCode
		{
			get
			{
				return this._BindCode;
			}
			set
			{
				this._BindCode = value;
			}
		}

		public MMetaItem BindMetaItem
		{
			get
			{
				return this._BindMetaItem;
			}
			set
			{
				this._BindMetaItem = value;
				this._MetaItemName = this._BindMetaItem.Text;
				this._BindInstanceItem = this._BindMetaItem.BindInstanceItem;
				if (this._Text == null | Operators.CompareString(this._Text, "", false) == 0)
				{
					this._Text = this._BindMetaItem.Text;
				}
				this.BindCode = this._BindMetaItem.Code;
			}
		}

		public MetaItemAnnotation()
		{
			this.DrawBorder = false;
			this.BorderWidth = 1;
			this.Padding = 4;
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.Black;
			this.Font = new Font("宋体", 9f, GraphicsUnit.Point);
			base.set_MouseOverCursor(Cursors.Hand);
			base.set_LockedImage(null);
			this._AllowEdit = true;
		}

		public override void Paint(Graphics graphics, PointF offset, PointF zoom, float resolution)
		{
			if (this.get_IsCreating())
			{
				Pen pen = new Pen(this.ForeColor, (float)this.BorderWidth);
				graphics.DrawRectangle(pen, this.get_Location().X, this.get_Location().Y, this.get_Size().Width, this.get_Size().Height);
			}
			else
			{
				SolidBrush brush = new SolidBrush(this.BackColor);
				graphics.FillRectangle(brush, this.get_Location().X, this.get_Location().Y, this.get_Size().Width, this.get_Size().Height);
				if (this.DrawBorder)
				{
					Pen pen2 = new Pen(this.ForeColor, (float)this.BorderWidth);
					graphics.DrawRectangle(pen2, this.get_Location().X, this.get_Location().Y, this.get_Size().Width, this.get_Size().Height);
				}
				if (!this._EditMode)
				{
					SolidBrush brush2 = new SolidBrush(this.ForeColor);
					RectangleF layoutRectangle = new RectangleF(this.get_Location().X + (float)this.Padding, this.get_Location().Y + (float)this.Padding, this.get_Size().Width - (float)(checked(2 * this.Padding)), this.get_Size().Height - (float)(checked(2 * this.Padding)));
					graphics.DrawString(this.Text, this.Font, brush2, layoutRectangle);
				}
			}
		}

		public override string ToXmp()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ann:CustomAnnotation AssemblyType=\"EPRLib,dhcc.epr.eprlib.presentation.annotate.MetaItemAnnotation\">");
			stringBuilder.Append(base.SerializeBase());
			stringBuilder.Append("<ann:BindCode>" + this.BindCode.ToString() + "</ann:BindCode>");
			stringBuilder.Append("<ann:Text>" + this.Text.ToString() + "</ann:Text>");
			stringBuilder.Append("<ann:Padding>" + this.Padding.ToString() + "</ann:Padding>");
			stringBuilder.Append("<ann:DrawBorder>" + this.DrawBorder.ToString() + "</ann:DrawBorder>");
			stringBuilder.Append("<ann:BorderWidth>" + this.BorderWidth.ToString() + "</ann:BorderWidth>");
			stringBuilder.Append("<ann:ForeColor>" + this.ForeColor.Name + "</ann:ForeColor>");
			stringBuilder.Append("<ann:BackColor>" + this.BackColor.Name + "</ann:BackColor>");
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
				if (Operators.CompareString(reader.LocalName, "BindCode", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.BindCode = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "Text", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.Text = reader.Value;
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "Padding", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.Padding = int.Parse(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "BorderWidth", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.BorderWidth = int.Parse(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "DrawBorder", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.DrawBorder = bool.Parse(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "ForeColor", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.ForeColor = AnnotateUtil.StrToColor(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "BackColor", false) == 0 & reader.IsStartElement())
				{
					reader.Read();
					if (reader.NodeType == XmlNodeType.Text)
					{
						this.BackColor = AnnotateUtil.StrToColor(reader.Value);
						reader.Read();
					}
				}
				else if (Operators.CompareString(reader.LocalName, "CustomAnnotation", false) == 0 & reader.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
			}
		}

		protected override void OnDoubleClick(EventArgs e)
		{
			base.OnDoubleClick(e);
			this.ShowEditControl();
		}

		private void ShowEditControl()
		{
			if (!base.get_Locked())
			{
				Layer arg_11_0 = base.get_ParentLayer();
				if (!base.get_ParentLayer().get_Locked() && base.get_Visible() && this._AllowEdit && base.GetInteractMode() != 0)
				{
					if (this._BindControl == null)
					{
						this.CreateEditControl();
					}
					float num = base.get_Location().X + base.get_Size().Width / 2f;
					float num2 = base.get_Location().Y + base.get_Size().Height / 2f;
					checked
					{
						this._BindControl.Left = (int)Math.Round(unchecked((double)num - (double)this._BindControl.Width / 2.0));
						this._BindControl.Top = (int)Math.Round(unchecked((double)num2 - (double)this._BindControl.Height / 2.0));
						if (this._BindControl.Parent == null)
						{
							this._BindControl.Parent = base.get_Parent().get_Control();
						}
						this._BindControl.Visible = true;
						this._BindControl.Invalidate();
						this._BindControl.Focus();
						this._EditMode = true;
						base.get_Parent().get_Control().Click += new EventHandler(this.HideEditControl);
						this.Refresh();
					}
				}
			}
		}

		private void HideEditControl(object sender, EventArgs e)
		{
			if (this._BindControl == null)
			{
				this.CreateEditControl();
			}
			if (this._BindControl.Visible)
			{
				this._EditMode = false;
				this._BindControl.Visible = false;
				base.get_Parent().get_Control().Click -= new EventHandler(this.HideEditControl);
				this.Refresh();
			}
		}

		private void CreateEditControl()
		{
			if (this._BindMetaItem is MIString)
			{
				PCString pCString = new PCString();
				pCString.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCString;
				pCString.VChanged += new PCString.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIDictionary)
			{
				PCDictionary pCDictionary = new PCDictionary();
				pCDictionary.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCDictionary;
				pCDictionary.VChanged += new PCDictionary.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIDateTime)
			{
				PCDateTime pCDateTime = new PCDateTime();
				pCDateTime.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCDateTime;
				pCDateTime.VChanged += new PCDateTime.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIMonoChoice)
			{
				PCMonoChoice pCMonoChoice = new PCMonoChoice();
				pCMonoChoice.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCMonoChoice;
				pCMonoChoice.VChanged += new PCMonoChoice.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIMultiChoice)
			{
				PCMultiChoice pCMultiChoice = new PCMultiChoice();
				pCMultiChoice.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCMultiChoice;
				pCMultiChoice.VChanged += new PCMultiChoice.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIPosition)
			{
				PCPosition pCPosition = new PCPosition();
				pCPosition.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCPosition;
				pCPosition.VChanged += new PCPosition.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MINumber)
			{
				PCNumber pCNumber = new PCNumber();
				pCNumber.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCNumber;
				pCNumber.VChanged += new PCNumber.VChangedEventHandler(this.MetaItemVChanged);
			}
			else if (this._BindMetaItem is MIQuantity)
			{
				PCQuantity pCQuantity = new PCQuantity();
				pCQuantity.BindInstanceItem = this._BindInstanceItem;
				this._BindControl = pCQuantity;
				pCQuantity.VChanged += new PCQuantity.VChangedEventHandler(this.MetaItemVChanged);
			}
			this._BindControl.Visible = false;
			if (base.get_Parent() != null)
			{
				this._BindControl.Parent = base.get_Parent().get_Control();
			}
		}

		public void MetaItemVChanged(string strCode)
		{
			if (this._BindMetaItem is MIQuantity)
			{
				this.Text = this._BindInstanceItem.Value + this._BindInstanceItem.ValueCode;
			}
			else
			{
				this.Text = this._BindInstanceItem.Value;
			}
		}
	}
}
