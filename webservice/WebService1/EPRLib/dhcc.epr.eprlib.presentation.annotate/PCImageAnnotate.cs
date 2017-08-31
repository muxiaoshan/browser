using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class PCImageAnnotate : Panel, PControlInterface, ICheckValueChanged
	{
		public delegate void VChangedEventHandler(string strCode);

		private IContainer components;

		private MIImageAnnotate _MIImageAnnotate;

		[AccessedThroughProperty("AnnoPictureBox")]
		private AnnoPictureBox _AnnoPictureBox;

		private NIImageAnnotate _BindNIImageAnnotate;

		private string _Code;

		private bool _NewAnnotation;

		public Layer AnnoLayer;

		public Layer EPRHotSpotLayer;

		private ContextMenuStrip cmAnno;

		private ToolStripMenuItem miShowAnnoToolForm;

		private AnnoToolForm _AnnoToolForm;

		private ToolStripMenuItem miDelete;

		public ContextMenuStrip cmHotSpot;

		private bool boolHotSpot;

		private PCTextEdit _PCTextEdit;

		private PCImageAnnotate.VChangedEventHandler VChangedEvent;

		private int initValue;

		public event PCImageAnnotate.VChangedEventHandler VChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.VChangedEvent = (PCImageAnnotate.VChangedEventHandler)Delegate.Combine(this.VChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.VChangedEvent = (PCImageAnnotate.VChangedEventHandler)Delegate.Remove(this.VChangedEvent, value);
			}
		}

		public virtual AnnoPictureBox AnnoPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AnnoPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.AnnoPictureBox_MouseMove);
				EventHandler value3 = delegate(object a0, EventArgs a1)
				{
					this.AnnoPictureBox_Click(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs)a1);
				};
				MouseEventHandler value4 = new MouseEventHandler(this.AnnoPictureBox_MouseDown);
				EventHandler value5 = new EventHandler(this.AnnoPictureBox_MouseEnter);
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseMove -= value2;
					this._AnnoPictureBox.Click -= value3;
					this._AnnoPictureBox.MouseDown -= value4;
					this._AnnoPictureBox.MouseEnter -= value5;
				}
				this._AnnoPictureBox = value;
				if (this._AnnoPictureBox != null)
				{
					this._AnnoPictureBox.MouseMove += value2;
					this._AnnoPictureBox.Click += value3;
					this._AnnoPictureBox.MouseDown += value4;
					this._AnnoPictureBox.MouseEnter += value5;
				}
			}
		}

		public bool NewAnnotation
		{
			get
			{
				return this._NewAnnotation;
			}
			set
			{
				this._NewAnnotation = value;
			}
		}

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNIImageAnnotate;
			}
			set
			{
				this._BindNIImageAnnotate = (NIImageAnnotate)value;
				this._BindNIImageAnnotate.XMLEvent += new NIImageAnnotate.XMLEventEventHandler(this.SerializeAnnoData);
				this._Code = this._BindNIImageAnnotate.Code;
				this._MIImageAnnotate = (MIImageAnnotate)this._BindNIImageAnnotate.BindMMetaItem;
				if (!(this._MIImageAnnotate.BindTextDescCode == null | Operators.CompareString(this._MIImageAnnotate.BindTextDescCode, "", false) == 0) && this.Parent is PPanel)
				{
					try
					{
						IEnumerator enumerator = this.Parent.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							if (control is PCTextEdit)
							{
								PCTextEdit pCTextEdit = (PCTextEdit)control;
								if (Operators.CompareString(pCTextEdit.Code, this._MIImageAnnotate.BindTextDescCode, false) == 0)
								{
									this._PCTextEdit = pCTextEdit;
									break;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
				this.AnnoPictureBox.Image = null;
				checked
				{
					if (!(this._MIImageAnnotate.ImageData == null | Operators.CompareString(this._MIImageAnnotate.ImageData, "", false) == 0))
					{
						this.AnnoPictureBox.Image = Image.FromStream(AnnotateUtil.StrToImageStream(this._MIImageAnnotate.ImageData));
						this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
						string text;
						if (this._BindNIImageAnnotate.AnnoData == null | Operators.CompareString(this._BindNIImageAnnotate.AnnoData, "", false) == 0)
						{
							text = "<ann:Layer><ann:Name>EPRAnnoLayer</ann:Name><ann:EncryptedPassword></ann:EncryptedPassword><ann:Locked>False</ann:Locked><ann:Visible>True</ann:Visible><ann:AnnotationCollection></ann:AnnotationCollection></ann:Layer>";
						}
						else
						{
							int num = this._BindNIImageAnnotate.AnnoData.IndexOf("<ann:Layer>");
							int num2 = this._BindNIImageAnnotate.AnnoData.IndexOf("</ann:Layer>") + 12;
							text = this._BindNIImageAnnotate.AnnoData.Substring(num, num2 - num);
						}
						int startIndex = this._MIImageAnnotate.HotSpotData.IndexOf("/ann:Layer>") + 11;
						text = this._MIImageAnnotate.HotSpotData.Insert(startIndex, text);
						this.AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(text), 0);
						try
						{
							IEnumerator enumerator2 = this.AnnoPictureBox.AnnoCtrl.get_Layers().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Layer layer = (Layer)enumerator2.Current;
								if (Operators.CompareString(layer.get_Name(), "EPRHotSpotLayer", false) == 0)
								{
									this.EPRHotSpotLayer = layer;
									try
									{
										IEnumerator enumerator3 = layer.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											Annotation annotation = (Annotation)enumerator3.Current;
											annotation.add_MouseMove(new MouseEventHandler(this.HotSpot_MouseMove));
											annotation.add_MouseDown(new MouseEventHandler(this.HotSpot_MouseDown));
											annotation.Lock();
											IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)annotation;
											iEPRHotSpot.AnnoMode = EPRAnnoMode.Edit;
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (Operators.CompareString(layer.get_Name(), "EPRAnnoLayer", false) == 0)
								{
									this.AnnoLayer = layer;
									try
									{
										IEnumerator enumerator4 = layer.GetEnumerator();
										while (enumerator4.MoveNext())
										{
											Annotation annotation2 = (Annotation)enumerator4.Current;
											annotation2.set_ContextMenuStrip(this.cmHotSpot);
											if (annotation2 is TextAnnotation)
											{
												((TextAnnotation)annotation2).get_TextBox().LostFocus += new EventHandler(this.AnnoPictureBox.OnTextAnnoLostFocus);
											}
											else if (annotation2 is CustomIconAnnotation)
											{
												annotation2.add_Move(new EventHandler(this.CustomIconAnnotation_Move));
												annotation2.Lock();
											}
											else if (annotation2 is MetaItemAnnotation)
											{
												MetaItemAnnotation metaItemAnnotation = (MetaItemAnnotation)annotation2;
												MMetaItemEnumerator enumerator5 = this._MIImageAnnotate.SubItems.GetEnumerator();
												while (enumerator5.MoveNext())
												{
													MMetaItem mMetaItem = (MMetaItem)enumerator5.Current;
													if (Operators.CompareString(mMetaItem.Code, metaItemAnnotation.BindCode, false) == 0)
													{
														metaItemAnnotation.BindMetaItem = mMetaItem;
														break;
													}
												}
											}
										}
									}
									finally
									{
										IEnumerator enumerator4;
										if (enumerator4 is IDisposable)
										{
											(enumerator4 as IDisposable).Dispose();
										}
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
				}
			}
		}

		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		public PCImageAnnotate()
		{
			base.Disposed += new EventHandler(this.PCImageAnnotate_Disposed);
			base.MouseDown += new MouseEventHandler(this.PCImageAnnotate_MouseDown);
			this.initValue = 0;
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
			this.AutoScroll = true;
		}

		private void Init()
		{
			this.AnnoPictureBox = new AnnoPictureBox();
			this.AnnoPictureBox.Left = 0;
			this.AnnoPictureBox.Top = 0;
			this.AnnoPictureBox.AnnoCtrl.set_ToolTipControl(new ToolTip());
			this.AnnoPictureBox.Dock = DockStyle.None;
			this.AnnoPictureBox.AutoAnnotationCreated += delegate(bool a0)
			{
				this.AutoAnnotationCreated(a0);
			};
			this.Controls.Add(this.AnnoPictureBox);
			this.cmAnno = new ContextMenuStrip();
			this.miShowAnnoToolForm = new ToolStripMenuItem("标注工具");
			this.cmAnno.Items.AddRange(new ToolStripItem[]
			{
				this.miShowAnnoToolForm
			});
			this.miShowAnnoToolForm.Click += new EventHandler(this.miShowAnnoToolForm_Click);
			this.miDelete = new ToolStripMenuItem("删除热点");
			this.miDelete.Click += new EventHandler(this.miDelete_Click);
			this.cmHotSpot = new ContextMenuStrip();
			this.cmHotSpot.Items.AddRange(new ToolStripItem[]
			{
				this.miDelete
			});
		}

		public void SerializeAnnoData()
		{
			byte[] bytes = this.AnnoPictureBox.AnnoCtrl.Save(this.AnnoLayer, 0);
			this._BindNIImageAnnotate.AnnoData = Encoding.UTF8.GetString(bytes);
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Code = reader.Value;
				reader.Read();
			}
			ControlXML.XMLDeserialize(reader, this);
		}

		private void miShowAnnoToolForm_Click(object sender, EventArgs e)
		{
			if (!this.IsToolFormShowed())
			{
				this.ShowToolForm();
			}
		}

		private void AnnoPictureBox_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && !this.IsToolFormShowed())
			{
				ToolStripDropDown arg_35_0 = this.cmAnno;
				Control arg_35_1 = this.AnnoPictureBox;
				Point position = new Point(e.X, e.Y);
				arg_35_0.Show(arg_35_1, position);
			}
			else if (this.AnnoPictureBox.Image != null & this.NewAnnotation)
			{
				this.NewAnnotation = false;
				this.Cursor = Cursors.Default;
			}
		}

		private void HotSpot_MouseMove(object sender, MouseEventArgs e)
		{
			this.boolHotSpot = true;
			this.Cursor = Cursors.Hand;
		}

		private void AnnoPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (!this.IsToolFormShowed())
			{
				if (this.Parent is PPanel)
				{
					((PPanel)this.Parent).HandleAnnoToolForm(this);
				}
				this.Parent.Focus();
				this.ShowToolForm();
			}
		}

		private void AnnoPictureBox_MouseEnter(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.NewAnnotation)
			{
				this.Cursor = Cursors.Cross;
			}
			else
			{
				this.Cursor = Cursors.Arrow;
			}
		}

		private void AnnoPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.AnnoPictureBox.Image != null & this.NewAnnotation)
			{
				this.Cursor = Cursors.Cross;
			}
			else
			{
				if (!this.boolHotSpot)
				{
					this.Cursor = Cursors.Arrow;
				}
				this.boolHotSpot = false;
			}
		}

		private void miDelete_Click(object sender, EventArgs e)
		{
			if (this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation() is TextAnnotation)
			{
				((TextAnnotation)this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation()).get_TextBox().LostFocus -= new EventHandler(this.AnnoPictureBox.OnTextAnnoLostFocus);
			}
			this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation().get_ParentLayer().Remove(this.AnnoPictureBox.AnnoCtrl.get_ActiveAnnotation());
			this._BindNIImageAnnotate.IsAnnoDataChanged = true;
			PCImageAnnotate.VChangedEventHandler vChangedEvent = this.VChangedEvent;
			if (vChangedEvent != null)
			{
				vChangedEvent(this.Code);
			}
		}

		private void HotSpot_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void PCImageAnnotate_Disposed(object sender, EventArgs e)
		{
			this.CloseToolForm();
			this.Dispose();
		}

		private void PCImageAnnotate_MouseDown(object sender, MouseEventArgs e)
		{
			if (!this.IsToolFormShowed())
			{
				this.Parent.Focus();
				this.ShowToolForm();
			}
		}

		private void AutoAnnotationCreated(object isAutoAnnoCreated)
		{
			this._NewAnnotation = Conversions.ToBoolean(isAutoAnnoCreated);
		}

		public void CustomIconAnnotation_Move(object sender, EventArgs e)
		{
			CustomIconAnnotation customIconAnnotation = (CustomIconAnnotation)sender;
			float num = customIconAnnotation.get_Location().X + customIconAnnotation.get_Size().Width / 2f;
			float num2 = customIconAnnotation.get_Location().Y + customIconAnnotation.get_Size().Height / 2f;
			bool flag = false;
			try
			{
				IEnumerator enumerator = this.EPRHotSpotLayer.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Annotation annotation = (Annotation)enumerator.Current;
					IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)annotation;
					if (num > annotation.get_Location().X & num < annotation.get_Location().X + annotation.get_Size().Width & num2 > annotation.get_Location().Y & num2 < annotation.get_Location().Y + annotation.get_Size().Height)
					{
						flag = true;
						if (customIconAnnotation.HotSpotCode == null | Operators.CompareString(customIconAnnotation.HotSpotCode, "", false) == 0)
						{
							customIconAnnotation.HotSpotCode = iEPRHotSpot.HSCode;
							this.GenerateTextDesc();
							break;
						}
						if (Operators.CompareString(customIconAnnotation.HotSpotCode, iEPRHotSpot.HSCode, false) != 0)
						{
							customIconAnnotation.HotSpotCode = iEPRHotSpot.HSCode;
							this.GenerateTextDesc();
							break;
						}
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (!flag && !(Operators.CompareString(customIconAnnotation.HotSpotCode, "", false) == 0 | customIconAnnotation.HotSpotCode == null))
			{
				customIconAnnotation.HotSpotCode = "";
				this.GenerateTextDesc();
			}
		}

		public void GenerateTextDesc()
		{
			checked
			{
				if (this._PCTextEdit != null)
				{
					NITextDesc nITextDesc = (NITextDesc)this._PCTextEdit.BindInstanceItem;
					nITextDesc.SubItems.Clear();
					ArrayList arrayList = new ArrayList();
					IconAnnotationEnumerator enumerator = this._MIImageAnnotate.IconAnnotates.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IconAnnotation iconAnnotation = (IconAnnotation)enumerator.Current;
						arrayList.Clear();
						try
						{
							IEnumerator enumerator2 = this.AnnoLayer.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								Annotation annotation = (Annotation)enumerator2.Current;
								if (annotation is CustomIconAnnotation)
								{
									CustomIconAnnotation customIconAnnotation = (CustomIconAnnotation)annotation;
									if (Operators.CompareString(customIconAnnotation.IconCode, iconAnnotation.IconCode, false) == 0 & !(customIconAnnotation.HotSpotCode == null | Operators.CompareString(customIconAnnotation.HotSpotCode, "", false) == 0))
									{
										arrayList.Add(customIconAnnotation);
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						if (arrayList.Count > 0)
						{
							NISimple nISimple = new NISimple();
							nISimple.Code = "ImagePosition";
							string text = "";
							string text2 = "";
							try
							{
								IEnumerator enumerator3 = arrayList.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									CustomIconAnnotation customIconAnnotation2 = (CustomIconAnnotation)enumerator3.Current;
									if (!(customIconAnnotation2.HotSpotCode == null | Operators.CompareString(customIconAnnotation2.HotSpotCode, "", false) == 0))
									{
										try
										{
											IEnumerator enumerator4 = this.EPRHotSpotLayer.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)enumerator4.Current;
												if (Operators.CompareString(iEPRHotSpot.HSCode, customIconAnnotation2.HotSpotCode, false) == 0)
												{
													text = text + iEPRHotSpot.HSCode + "^";
													text2 = text2 + iEPRHotSpot.HSName + this._MIImageAnnotate.Spliter;
												}
											}
										}
										finally
										{
											IEnumerator enumerator4;
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							if (text.Length > 0)
							{
								text = text.Substring(0, text.Length - 1);
							}
							if (text2.Length > 0)
							{
								text2 = text2.Substring(0, text2.Length - 1);
							}
							nISimple.Value = text2;
							nISimple.ValueCode = text;
							NISimple nISimple2 = new NISimple();
							nISimple2.Code = "ImageIcon";
							nISimple2.ValueCode = iconAnnotation.IconCode;
							nISimple2.Value = iconAnnotation.IconName;
							NIFree nIFree = new NIFree();
							nIFree.Value = "\r";
							NISegment nISegment = new NISegment();
							nISegment.Code = "ImageSegment^" + nISimple2.ValueCode;
							nISegment.SubItems.Add(nISimple2);
							nISegment.SubItems.Add(nISimple);
							nISegment.SubItems.Add(nIFree);
							nITextDesc.SubItems.Add(nISegment);
						}
					}
					this._PCTextEdit.BindInstanceItem = nITextDesc;
				}
			}
		}

		public void AddNewAnnotation(CustomIconAnnotation customAnnotation)
		{
			this.AnnoPictureBox.AnnoCtrl.get_CurrentLayer().Add(customAnnotation);
			this._BindNIImageAnnotate.IsAnnoDataChanged = true;
			PCImageAnnotate.VChangedEventHandler vChangedEvent = this.VChangedEvent;
			if (vChangedEvent != null)
			{
				vChangedEvent(this.Code);
			}
		}

		public void AddNewAnnotationWithoutRaiseEvent(CustomIconAnnotation customAnnotation)
		{
			this.AnnoPictureBox.AnnoCtrl.get_CurrentLayer().Add(customAnnotation);
			this._BindNIImageAnnotate.IsAnnoDataChanged = true;
		}

		public void RaiseVChangedEvent()
		{
			this._BindNIImageAnnotate.IsAnnoDataChanged = true;
			PCImageAnnotate.VChangedEventHandler vChangedEvent = this.VChangedEvent;
			if (vChangedEvent != null)
			{
				vChangedEvent(this.Code);
			}
		}

		private bool IsToolFormShowed()
		{
			return this._AnnoToolForm != null && !this._AnnoToolForm.IsDisposed;
		}

		private void ShowToolForm()
		{
			Rectangle workingArea = Screen.GetWorkingArea(this);
			Point p = new Point(0, 0);
			Point location = checked(new Point(this.PointToScreen(p).X - 165, (int)Math.Round((double)workingArea.Height / 3.0)));
			this._AnnoToolForm = new AnnoToolForm();
			this._AnnoToolForm.TopMost = true;
			this._AnnoToolForm.PCImageAnnotate = this;
			this._AnnoToolForm.StartPosition = FormStartPosition.Manual;
			this._AnnoToolForm.Location = location;
			this._AnnoToolForm.Show();
		}

		public void CloseToolForm()
		{
			if (this.IsToolFormShowed())
			{
				this._AnnoToolForm.Close();
			}
		}

		public void IsValueChanged(ref bool isChanged)
		{
			if (isChanged)
			{
				return;
			}
			isChanged = (this.initValue != NIImageAnnotate.GetXmlWithoutWangTime(this._BindNIImageAnnotate.XMLString).GetHashCode());
		}

		public void SetInitValue()
		{
			this.initValue = NIImageAnnotate.GetXmlWithoutWangTime(this._BindNIImageAnnotate.XMLString).GetHashCode();
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__3(object a0, EventArgs a1)
		{
			this.AnnoPictureBox_Click(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs)a1);
		}

		[DebuggerStepThrough, CompilerGenerated]
		private void _Lambda$__4(bool a0)
		{
			this.AutoAnnotationCreated(a0);
		}
	}
}
