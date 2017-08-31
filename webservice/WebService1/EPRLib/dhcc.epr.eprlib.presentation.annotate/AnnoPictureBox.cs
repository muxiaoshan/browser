using Atalasoft.Imaging.Annotate;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class AnnoPictureBox : PictureBox, IAnnotate
	{
		public delegate void AutoAnnotationCreatedHandler(bool isAutoAnnoCreated);

		private IContainer components;

		[AccessedThroughProperty("_AnnoCtrl")]
		private AnnotationController __AnnoCtrl;

		private Annotation _TemplateAnno;

		private AnnoPictureBox.AutoAnnotationCreatedHandler AutoAnnotationCreatedEvent;

		public event AnnoPictureBox.AutoAnnotationCreatedHandler AutoAnnotationCreated
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.AutoAnnotationCreatedEvent = (AnnoPictureBox.AutoAnnotationCreatedHandler)Delegate.Combine(this.AutoAnnotationCreatedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.AutoAnnotationCreatedEvent = (AnnoPictureBox.AutoAnnotationCreatedHandler)Delegate.Remove(this.AutoAnnotationCreatedEvent, value);
			}
		}

		public Control Control
		{
			get
			{
				return this;
			}
		}

		public PointF DocumentPosition
		{
			get
			{
				PointF result = new PointF(0f, 0f);
				return result;
			}
		}

		public float DocumentResolution
		{
			get
			{
				return 1f;
			}
		}

		public PointF DocumentScale
		{
			get
			{
				PointF result = new PointF(1f, 1f);
				return result;
			}
		}

		public SizeF DocumentSize
		{
			get
			{
				SizeF result = new SizeF((float)this.ClientSize.Width, (float)this.ClientSize.Height);
				return result;
			}
		}

		private virtual AnnotationController _AnnoCtrl
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__AnnoCtrl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__AnnoCtrl = value;
			}
		}

		public AnnotationController AnnoCtrl
		{
			get
			{
				if (this._AnnoCtrl == null)
				{
					try
					{
						this._AnnoCtrl = new AnnotationController();
						this._AnnoCtrl.set_Parent(this);
					}
					catch (Exception expr_21)
					{
						ProjectData.SetProjectError(expr_21);
						Exception ex = expr_21;
						MessageManager.ShowErrorMessage("初始化图形标注控制器错误!" + ex.Message + ex.StackTrace);
						ProjectData.ClearProjectError();
					}
				}
				return this._AnnoCtrl;
			}
		}

		public AnnoPictureBox()
		{
			this.InitializeComponent();
			this.Init();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
		}

		private void Init()
		{
			try
			{
				this.ImeModeBase = ImeMode.On;
				this._AnnoCtrl = new AnnotationController();
				this._AnnoCtrl.set_Parent(this);
				this._AnnoCtrl.add_AnnotationCreated(delegate(object a0, EventArgs a1)
				{
					this.OnAnnotationCreated();
				});
			}
			catch (Exception expr_38)
			{
				ProjectData.SetProjectError(expr_38);
				Exception ex = expr_38;
				MessageManager.ShowErrorMessage("初始化图形标注控制器错误!" + ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		public void AddAnnotaion(Annotation objAnno)
		{
			if (objAnno is TextAnnotation)
			{
				((TextAnnotation)objAnno).get_TextBox().LostFocus += new EventHandler(this.OnTextAnnoLostFocus);
			}
			this._AnnoCtrl.CreateAnnotation(objAnno);
			if (objAnno is IEPRHotSpot)
			{
				this._TemplateAnno = null;
			}
			else if (objAnno is TextAnnotation)
			{
				this._TemplateAnno = null;
			}
			else
			{
				this._TemplateAnno = objAnno;
			}
		}

		public void CancelAddAnnotation()
		{
			this._AnnoCtrl.CancelCreateAnnotation();
			this._TemplateAnno = null;
		}

		private void OnAnnotationCreated()
		{
			if (this._TemplateAnno == null)
			{
				AnnoPictureBox.AutoAnnotationCreatedHandler autoAnnotationCreatedEvent = this.AutoAnnotationCreatedEvent;
				if (autoAnnotationCreatedEvent != null)
				{
					autoAnnotationCreatedEvent(false);
					return;
				}
			}
			else if (this._TemplateAnno is TextAnnotation)
			{
				this._TemplateAnno = null;
				AnnoPictureBox.AutoAnnotationCreatedHandler autoAnnotationCreatedEvent = this.AutoAnnotationCreatedEvent;
				if (autoAnnotationCreatedEvent != null)
				{
					autoAnnotationCreatedEvent(false);
					return;
				}
			}
			else
			{
				if (this._TemplateAnno is CustomIconAnnotation)
				{
					CustomIconAnnotation customIconAnnotation = (CustomIconAnnotation)this._TemplateAnno;
					CustomIconAnnotation customIconAnnotation2 = new CustomIconAnnotation();
					customIconAnnotation2.IconName = customIconAnnotation.IconName;
					customIconAnnotation2.IconCode = customIconAnnotation.IconCode;
					customIconAnnotation2.IconDesc = customIconAnnotation.IconDesc;
					customIconAnnotation2.IconImage = customIconAnnotation.IconImage;
					customIconAnnotation2.DrawImage = customIconAnnotation.DrawImage;
					customIconAnnotation2.DrawBorder = customIconAnnotation.DrawBorder;
					customIconAnnotation2.DrawHatch = customIconAnnotation.DrawHatch;
					customIconAnnotation2.HatchStyle = customIconAnnotation.HatchStyle;
					customIconAnnotation2.BorderWidth = customIconAnnotation.BorderWidth;
					customIconAnnotation2.ForeColor = customIconAnnotation.ForeColor;
					customIconAnnotation2.BackColor = customIconAnnotation.BackColor;
					customIconAnnotation2.set_ContextMenuStrip(customIconAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(customIconAnnotation2);
				}
				else if (this._TemplateAnno is FreehandAnnotation)
				{
					FreehandAnnotation freehandAnnotation = (FreehandAnnotation)this._TemplateAnno;
					FreehandAnnotation freehandAnnotation2 = new FreehandAnnotation();
					freehandAnnotation2.set_ContextMenuStrip(freehandAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(freehandAnnotation2);
				}
				else if (this._TemplateAnno is ArrowLineAnnotation)
				{
					ArrowLineAnnotation arrowLineAnnotation = (ArrowLineAnnotation)this._TemplateAnno;
					ArrowLineAnnotation arrowLineAnnotation2 = new ArrowLineAnnotation();
					arrowLineAnnotation2.get_Pen().CustomEndCap = arrowLineAnnotation.get_Pen().CustomEndCap;
					arrowLineAnnotation2.set_ContextMenuStrip(arrowLineAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(arrowLineAnnotation2);
				}
				else if (this._TemplateAnno is LineAnnotation)
				{
					LineAnnotation lineAnnotation = (LineAnnotation)this._TemplateAnno;
					LineAnnotation lineAnnotation2 = new LineAnnotation();
					lineAnnotation2.set_ContextMenuStrip(lineAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(lineAnnotation2);
				}
				else if (this._TemplateAnno is CurveLinesAnnotation)
				{
					CurveLinesAnnotation curveLinesAnnotation = (CurveLinesAnnotation)this._TemplateAnno;
					CurveLinesAnnotation curveLinesAnnotation2 = new CurveLinesAnnotation();
					curveLinesAnnotation2.set_ContextMenuStrip(curveLinesAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(curveLinesAnnotation2);
				}
				else if (this._TemplateAnno is AnyAnnotation)
				{
					AnyAnnotation anyAnnotation = (AnyAnnotation)this._TemplateAnno;
					AnyAnnotation anyAnnotation2 = new AnyAnnotation();
					anyAnnotation2.set_ContextMenuStrip(anyAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(anyAnnotation2);
				}
				else if (this._TemplateAnno is RectangleAnnotation)
				{
					RectangleAnnotation rectangleAnnotation = (RectangleAnnotation)this._TemplateAnno;
					RectangleAnnotation rectangleAnnotation2 = new RectangleAnnotation();
					((SolidBrush)rectangleAnnotation2.get_Brush()).Color = Color.Transparent;
					rectangleAnnotation2.set_ContextMenuStrip(rectangleAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(rectangleAnnotation2);
				}
				else if (this._TemplateAnno is EllipseAnnotation)
				{
					EllipseAnnotation ellipseAnnotation = (EllipseAnnotation)this._TemplateAnno;
					EllipseAnnotation ellipseAnnotation2 = new EllipseAnnotation();
					((SolidBrush)ellipseAnnotation2.get_Brush()).Color = Color.Transparent;
					ellipseAnnotation2.set_ContextMenuStrip(ellipseAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(ellipseAnnotation2);
				}
				else if (this._TemplateAnno is PolygonAnnotation)
				{
					PolygonAnnotation polygonAnnotation = (PolygonAnnotation)this._TemplateAnno;
					PolygonAnnotation polygonAnnotation2 = new PolygonAnnotation();
					((SolidBrush)polygonAnnotation2.get_Brush()).Color = Color.Transparent;
					polygonAnnotation2.set_ContextMenuStrip(polygonAnnotation.get_ContextMenuStrip());
					this._AnnoCtrl.CreateAnnotation(polygonAnnotation2);
				}
				AnnoPictureBox.AutoAnnotationCreatedHandler autoAnnotationCreatedEvent = this.AutoAnnotationCreatedEvent;
				if (autoAnnotationCreatedEvent != null)
				{
					autoAnnotationCreatedEvent(true);
				}
			}
		}

		public void OnTextAnnoLostFocus(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				TextBox textBox = (TextBox)sender;
				textBox.Visible = false;
				textBox.Select();
				textBox.Parent.Refresh();
			}
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__2(object a0, EventArgs a1)
		{
			this.OnAnnotationCreated();
		}
	}
}
