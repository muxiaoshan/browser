using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class ControlPropertyWrap
	{
		public DesignControl curControl;

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("控件名称"), DesignOnly(false), ReadOnly(false)]
		public string Name
		{
			get
			{
				return this.curControl.Name;
			}
			set
			{
				this.curControl.Name = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("控件文本"), DesignOnly(false), ReadOnly(false)]
		public string Text
		{
			get
			{
				if (this.curControl.PControl is Label)
				{
					return this.curControl.PControl.Text;
				}
				return "";
			}
			set
			{
				if (this.curControl.PControl is Label)
				{
					this.curControl.PControl.Text = value;
				}
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("控件位置"), DesignOnly(false), ReadOnly(false)]
		public Point Location
		{
			get
			{
				return this.curControl.OriginLocation;
			}
			set
			{
				this.curControl.OriginLocation = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("控件大小"), DesignOnly(false), ReadOnly(false)]
		public Size Size
		{
			get
			{
				return this.curControl.OriginSize;
			}
			set
			{
				this.curControl.OriginSize = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("字体"), DesignOnly(false), ReadOnly(false)]
		public Font Font
		{
			get
			{
				return this.curControl.PControl.Font;
			}
			set
			{
				this.curControl.PControl.Font = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("背景色"), DesignOnly(false), ReadOnly(false)]
		public Color BackColor
		{
			get
			{
				return this.curControl.PControl.BackColor;
			}
			set
			{
				this.curControl.PControl.BackColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("前景色"), DesignOnly(false), ReadOnly(false)]
		public Color ForeColor
		{
			get
			{
				return this.curControl.PControl.ForeColor;
			}
			set
			{
				this.curControl.PControl.ForeColor = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("Tab键顺序"), DesignOnly(false), ReadOnly(false)]
		public int TabIndex
		{
			get
			{
				return this.curControl.TabIndex;
			}
			set
			{
				this.curControl.TabIndex = value;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("元数据名称"), DesignOnly(false), ReadOnly(true)]
		public string MetaItem
		{
			get
			{
				string result = "";
				if (this.curControl is DCLabel)
				{
					DCLabel dCLabel = (DCLabel)this.curControl;
					if (dCLabel.PCLabel.BindInstanceItem != null)
					{
						result = dCLabel.PCLabel.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCString)
				{
					DCString dCString = (DCString)this.curControl;
					if (dCString.PCString.BindInstanceItem != null)
					{
						result = dCString.PCString.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCNumber)
				{
					DCNumber dCNumber = (DCNumber)this.curControl;
					if (dCNumber.PCNumber.BindInstanceItem != null)
					{
						result = dCNumber.PCNumber.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCMonoChoice)
				{
					DCMonoChoice dCMonoChoice = (DCMonoChoice)this.curControl;
					if (dCMonoChoice.PCMonoChoice.BindInstanceItem != null)
					{
						result = dCMonoChoice.PCMonoChoice.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCMultiChoice)
				{
					DCMultiChoice dCMultiChoice = (DCMultiChoice)this.curControl;
					if (dCMultiChoice.PCMultiChoice.BindInstanceItem != null)
					{
						result = dCMultiChoice.PCMultiChoice.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCDateTime)
				{
					DCDateTime dCDateTime = (DCDateTime)this.curControl;
					if (dCDateTime.PCDateTime.BindInstanceItem != null)
					{
						result = dCDateTime.PCDateTime.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCDictionary)
				{
					DCDictionary dCDictionary = (DCDictionary)this.curControl;
					if (dCDictionary.PCDictionary.BindInstanceItem != null)
					{
						result = dCDictionary.PCDictionary.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCQuantity)
				{
					DCQuantity dCQuantity = (DCQuantity)this.curControl;
					if (dCQuantity.PCQuantity.BindInstanceItem != null)
					{
						result = dCQuantity.PCQuantity.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCPosition)
				{
					DCPosition dCPosition = (DCPosition)this.curControl;
					if (dCPosition.PCPosition.BindInstanceItem != null)
					{
						result = dCPosition.PCPosition.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCTextEdit)
				{
					DCTextEdit dCTextEdit = (DCTextEdit)this.curControl;
					if (dCTextEdit.PCTextEdit.BindInstanceItem != null)
					{
						result = dCTextEdit.PCTextEdit.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCImageAnnotate)
				{
					DCImageAnnotate dCImageAnnotate = (DCImageAnnotate)this.curControl;
					if (dCImageAnnotate.PCImageAnnotate.BindInstanceItem != null)
					{
						result = dCImageAnnotate.PCImageAnnotate.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				else if (this.curControl is DCTable)
				{
					DCTable dCTable = (DCTable)this.curControl;
					if (dCTable.PCTable.BindInstanceItem != null)
					{
						result = dCTable.PCTable.BindInstanceItem.BindMMetaItem.Text;
					}
				}
				return result;
			}
		}

		[Bindable(false), Browsable(true), Category("设计"), DefaultValue(""), Description("ReadOnly"), DesignOnly(false), ReadOnly(false)]
		public bool Enabled
		{
			get
			{
				return this.curControl.IEnabled;
			}
			set
			{
				this.curControl.IEnabled = value;
			}
		}

		[DebuggerNonUserCode]
		public ControlPropertyWrap()
		{
		}
	}
}
