using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

[DesignerGenerated]
internal class MovableForm : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public MovableForm()
	{
		this.InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new Container();
		this.AutoScaleMode = AutoScaleMode.Font;
		this.Text = "MovableFrom";
	}
}