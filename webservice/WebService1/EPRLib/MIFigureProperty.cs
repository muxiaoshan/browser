using dhcc.epr.eprlib.design.metadatadesign;
using dhcc.epr.eprlib.metadata;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class MIFigureProperty : UserControl
{
	[AccessedThroughProperty("chkBindImageLib")]
	private CheckBox _chkBindImageLib;

	[AccessedThroughProperty("txtImageLibName")]
	private TextBox _txtImageLibName;

	[AccessedThroughProperty("btnBindImageLib")]
	private Button _btnBindImageLib;

	private IContainer components;

	private MIFigure _MIFigure;

	internal virtual CheckBox chkBindImageLib
	{
		[DebuggerNonUserCode]
		get
		{
			return this._chkBindImageLib;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.chkBindImageLib_CheckedChanged);
			if (this._chkBindImageLib != null)
			{
				this._chkBindImageLib.CheckedChanged -= value2;
			}
			this._chkBindImageLib = value;
			if (this._chkBindImageLib != null)
			{
				this._chkBindImageLib.CheckedChanged += value2;
			}
		}
	}

	internal virtual TextBox txtImageLibName
	{
		[DebuggerNonUserCode]
		get
		{
			return this._txtImageLibName;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._txtImageLibName = value;
		}
	}

	internal virtual Button btnBindImageLib
	{
		[DebuggerNonUserCode]
		get
		{
			return this._btnBindImageLib;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.btnBindImageLib_Click);
			if (this._btnBindImageLib != null)
			{
				this._btnBindImageLib.Click -= value2;
			}
			this._btnBindImageLib = value;
			if (this._btnBindImageLib != null)
			{
				this._btnBindImageLib.Click += value2;
			}
		}
	}

	public MIFigure MIFigure
	{
		get
		{
			return this._MIFigure;
		}
		set
		{
			this._MIFigure = value;
			this.chkBindImageLib.Checked = this._MIFigure.BindImageLib;
			if (this._MIFigure.BindImageLib)
			{
				this.txtImageLibName.Enabled = true;
				this.btnBindImageLib.Enabled = true;
				this.txtImageLibName.Text = this._MIFigure.BindImageLibName;
			}
			else
			{
				this.txtImageLibName.Enabled = false;
				this.btnBindImageLib.Enabled = false;
			}
		}
	}

	public MIFigureProperty()
	{
		this.InitializeComponent();
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
		this.chkBindImageLib = new CheckBox();
		this.txtImageLibName = new TextBox();
		this.btnBindImageLib = new Button();
		this.SuspendLayout();
		this.chkBindImageLib.AutoSize = true;
		Control arg_45_0 = this.chkBindImageLib;
		Point location = new Point(111, 16);
		arg_45_0.Location = location;
		this.chkBindImageLib.Name = "chkBindImageLib";
		Control arg_6C_0 = this.chkBindImageLib;
		Size size = new Size(96, 16);
		arg_6C_0.Size = size;
		this.chkBindImageLib.TabIndex = 0;
		this.chkBindImageLib.Text = "是否绑定图库";
		this.chkBindImageLib.UseVisualStyleBackColor = true;
		Control arg_AB_0 = this.txtImageLibName;
		location = new Point(111, 36);
		arg_AB_0.Location = location;
		this.txtImageLibName.Name = "txtImageLibName";
		Control arg_D5_0 = this.txtImageLibName;
		size = new Size(219, 21);
		arg_D5_0.Size = size;
		this.txtImageLibName.TabIndex = 1;
		Control arg_FB_0 = this.btnBindImageLib;
		location = new Point(333, 35);
		arg_FB_0.Location = location;
		this.btnBindImageLib.Name = "btnBindImageLib";
		Control arg_122_0 = this.btnBindImageLib;
		size = new Size(36, 23);
		arg_122_0.Size = size;
		this.btnBindImageLib.TabIndex = 2;
		this.btnBindImageLib.Text = "+";
		this.btnBindImageLib.UseVisualStyleBackColor = true;
		this.Controls.Add(this.btnBindImageLib);
		this.Controls.Add(this.txtImageLibName);
		this.Controls.Add(this.chkBindImageLib);
		this.Name = "MIFigureProperty";
		size = new Size(500, 400);
		this.Size = size;
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void chkBindImageLib_CheckedChanged(object sender, EventArgs e)
	{
		this._MIFigure.BindImageLib = this.chkBindImageLib.Checked;
		this.txtImageLibName.Enabled = this.chkBindImageLib.Checked;
		this.btnBindImageLib.Enabled = this.chkBindImageLib.Checked;
	}

	private void btnBindImageLib_Click(object sender, EventArgs e)
	{
		ImageLibForm imageLibForm = new ImageLibForm();
		Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
		Control arg_23_0 = this.btnBindImageLib;
		Point p = new Point(0, 0);
		Point location = arg_23_0.PointToScreen(p);
		checked
		{
			location.Y += 28;
			if (location.X + imageLibForm.Height > workingArea.Width)
			{
				location.X = workingArea.Width - imageLibForm.Width;
			}
			if (location.Y + imageLibForm.Height > workingArea.Height)
			{
				location.Y = workingArea.Height - imageLibForm.Height;
			}
			imageLibForm.StartPosition = FormStartPosition.Manual;
			imageLibForm.Location = location;
			imageLibForm.TopMost = true;
			imageLibForm.ShowInTaskbar = false;
			if (imageLibForm.ShowDialog() == DialogResult.OK)
			{
				this.txtImageLibName.Text = imageLibForm.ImageLibName;
				this._MIFigure.BindImageLibID = imageLibForm.ImageLibID;
				this._MIFigure.BindImageLibName = imageLibForm.ImageLibName;
			}
		}
	}
}
