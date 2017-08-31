using Atalasoft.Imaging.Annotate;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using ImagePosData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.annotate
{
	public class SelectPosForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("MainPanel")]
		private Panel _MainPanel;

		private MIImageAnnotate _MIImageAnnotate;

		[AccessedThroughProperty("AnnoPictureBox")]
		private AnnoPictureBox _AnnoPictureBox;

		public Layer EPRHotSpotLayer;

		private NISimple _BindNIPosition;

		private MIPosition _BindMIPosition;

		private string _PosValue;

		private string _PosValueCode;

		private bool boolHotSpot;

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= value2;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += value2;
				}
			}
		}

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		internal virtual Panel MainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainPanel = value;
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
				this._AnnoPictureBox = value;
			}
		}

		public NISimple BindNIPosition
		{
			get
			{
				return this._BindNIPosition;
			}
			set
			{
				this._BindNIPosition = value;
				checked
				{
					if (this._BindNIPosition.ValueCode != null)
					{
						string[] array = this._BindNIPosition.ValueCode.Split(new char[]
						{
							'^'
						});
						try
						{
							IEnumerator enumerator = this.EPRHotSpotLayer.GetEnumerator();
							while (enumerator.MoveNext())
							{
								IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)enumerator.Current;
								string[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									string right = array2[i];
									if (Operators.CompareString(iEPRHotSpot.HSCode, right, false) == 0)
									{
										iEPRHotSpot.MultiSelected = true;
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
				}
			}
		}

		public MIPosition BindMIPosition
		{
			get
			{
				return this._BindMIPosition;
			}
			set
			{
				this._BindMIPosition = value;
				if (!(Operators.CompareString(this._BindMIPosition.ImageCode, "", false) == 0 | this._BindMIPosition.ImageCode == null))
				{
					try
					{
						EImagePosition imagePositionByCode = WebServiceLayer.ImagePosAccess.GetImagePositionByCode(this._BindMIPosition.ImageCode);
						this._MIImageAnnotate = new MIImageAnnotate();
						this._MIImageAnnotate.XMLString = imagePositionByCode.Data;
						this.AnnoPictureBox.AnnoCtrl.get_Layers().Clear();
						this.AnnoPictureBox.Image = null;
						if (!(this._MIImageAnnotate.ImageData == null | Operators.CompareString(this._MIImageAnnotate.ImageData, "", false) == 0))
						{
							this.AnnoPictureBox.Image = Image.FromStream(AnnotateUtil.StrToImageStream(this._MIImageAnnotate.ImageData));
							this.AnnoPictureBox.Size = this.AnnoPictureBox.Image.Size;
							string hotSpotData = this._MIImageAnnotate.HotSpotData;
							this.AnnoPictureBox.AnnoCtrl.Load(AnnotateUtil.StrToStream(hotSpotData), 0);
							try
							{
								IEnumerator enumerator = this.AnnoPictureBox.AnnoCtrl.get_Layers().GetEnumerator();
								while (enumerator.MoveNext())
								{
									Layer layer = (Layer)enumerator.Current;
									if (Operators.CompareString(layer.get_Name(), "EPRHotSpotLayer", false) == 0)
									{
										this.EPRHotSpotLayer = layer;
										try
										{
											IEnumerator enumerator2 = layer.GetEnumerator();
											while (enumerator2.MoveNext())
											{
												Annotation annotation = (Annotation)enumerator2.Current;
												annotation.add_MouseMove(new MouseEventHandler(this.HotSpot_MouseMove));
												annotation.add_MouseDown(new MouseEventHandler(this.HotSpot_MouseDown));
												annotation.Lock();
												IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)annotation;
												iEPRHotSpot.AnnoMode = EPRAnnoMode.Edit;
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
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
						}
					}
					catch (Exception expr_1F0)
					{
						ProjectData.SetProjectError(expr_1F0);
						Exception ex = expr_1F0;
						MessageManager.ShowErrorMessage(ex.ToString() + ex.StackTrace.ToString());
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public string PosValue
		{
			get
			{
				return this._PosValue;
			}
			set
			{
				this._PosValue = value;
			}
		}

		public string PosValueCode
		{
			get
			{
				return this._PosValueCode;
			}
			set
			{
				this._PosValueCode = value;
			}
		}

		public SelectPosForm()
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
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.MainPanel = new Panel();
			this.SuspendLayout();
			Control arg_3B_0 = this.btnOK;
			Point location = new Point(8, 328);
			arg_3B_0.Location = location;
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "确定";
			Control arg_81_0 = this.btnCancel;
			location = new Point(96, 328);
			arg_81_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "取消";
			this.MainPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.MainPanel.AutoScroll = true;
			Control arg_DB_0 = this.MainPanel;
			location = new Point(8, 8);
			arg_DB_0.Location = location;
			this.MainPanel.Name = "MainPanel";
			Control arg_108_0 = this.MainPanel;
			Size size = new Size(408, 312);
			arg_108_0.Size = size;
			this.MainPanel.TabIndex = 2;
			size = new Size(6, 14);
			this.AutoScaleBaseSize = size;
			size = new Size(426, 362);
			this.ClientSize = size;
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "SelectPosForm";
			this.ShowInTaskbar = false;
			this.Text = "选择位置";
			this.ResumeLayout(false);
		}

		public void Init()
		{
			this.AnnoPictureBox = new AnnoPictureBox();
			this.AnnoPictureBox.Left = 0;
			this.AnnoPictureBox.Top = 0;
			this.AnnoPictureBox.AnnoCtrl.set_ToolTipControl(new ToolTip());
			this.AnnoPictureBox.Dock = DockStyle.None;
			this.MainPanel.Controls.Add(this.AnnoPictureBox);
		}

		private void HotSpot_MouseMove(object sender, MouseEventArgs e)
		{
			this.boolHotSpot = true;
			this.Cursor = Cursors.Hand;
		}

		private void HotSpot_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this._PosValueCode = "";
			this._PosValue = "";
			try
			{
				IEnumerator enumerator = this.EPRHotSpotLayer.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IEPRHotSpot iEPRHotSpot = (IEPRHotSpot)enumerator.Current;
					if (iEPRHotSpot.MultiSelected)
					{
						this._PosValueCode = this._PosValueCode + iEPRHotSpot.HSCode + "^";
						this._PosValue = this._PosValue + iEPRHotSpot.HSName + this._MIImageAnnotate.Spliter;
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
			checked
			{
				if (this._PosValueCode.Length > 0)
				{
					this._PosValueCode = this._PosValueCode.Substring(0, this._PosValueCode.Length - 1);
				}
				if (this._PosValue.Length > 0)
				{
					this._PosValue = this._PosValue.Substring(0, this._PosValue.Length - 1);
				}
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
