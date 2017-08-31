using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCInterface : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("gbDesign")]
		private GroupBar _gbDesign;

		[AccessedThroughProperty("gbDC")]
		private GroupBarItem _gbDC;

		[AccessedThroughProperty("gbContent")]
		private GroupBarItem _gbContent;

		[AccessedThroughProperty("gbProperty")]
		private GroupBarItem _gbProperty;

		[AccessedThroughProperty("topPanel")]
		private Panel _topPanel;

		[AccessedThroughProperty("mainPanel")]
		private Panel _mainPanel;

		[AccessedThroughProperty("spDesign")]
		private Splitter _spDesign;

		[AccessedThroughProperty("downDesignPanel")]
		private Panel _downDesignPanel;

		[AccessedThroughProperty("gvDC")]
		private GroupView _gvDC;

		[AccessedThroughProperty("gvContent")]
		private GroupView _gvContent;

		[AccessedThroughProperty("dcImageList")]
		private ImageList _dcImageList;

		[AccessedThroughProperty("PropertyGrid")]
		private PropertyGrid _PropertyGrid;

		[AccessedThroughProperty("DesignPanel")]
		private DesignPanel _DesignPanel;

		private MMetaData _MetaData;

		private NInstanceData _InstanceData;

		internal virtual GroupBar gbDesign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbDesign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbDesign = value;
			}
		}

		internal virtual GroupBarItem gbDC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbDC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbDC = value;
			}
		}

		internal virtual GroupBarItem gbContent
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbContent;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbContent = value;
			}
		}

		internal virtual GroupBarItem gbProperty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbProperty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbProperty = value;
			}
		}

		internal virtual Panel topPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._topPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._topPanel = value;
			}
		}

		internal virtual Panel mainPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mainPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mainPanel = value;
			}
		}

		internal virtual Splitter spDesign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._spDesign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._spDesign = value;
			}
		}

		internal virtual Panel downDesignPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._downDesignPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._downDesignPanel = value;
			}
		}

		internal virtual GroupView gvDC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gvDC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.gvDC_GroupViewItemSelected);
				if (this._gvDC != null)
				{
					this._gvDC.remove_GroupViewItemSelected(eventHandler);
				}
				this._gvDC = value;
				if (this._gvDC != null)
				{
					this._gvDC.add_GroupViewItemSelected(eventHandler);
				}
			}
		}

		internal virtual GroupView gvContent
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gvContent;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.gvContent_KeyUp);
				KeyEventHandler value3 = new KeyEventHandler(this.gvContent_KeyUp);
				MouseEventHandler value4 = new MouseEventHandler(this.gvContent_MouseDown);
				if (this._gvContent != null)
				{
					this._gvContent.KeyDown -= value2;
					this._gvContent.KeyUp -= value3;
					this._gvContent.MouseDown -= value4;
				}
				this._gvContent = value;
				if (this._gvContent != null)
				{
					this._gvContent.KeyDown += value2;
					this._gvContent.KeyUp += value3;
					this._gvContent.MouseDown += value4;
				}
			}
		}

		internal virtual ImageList dcImageList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dcImageList;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dcImageList = value;
			}
		}

		internal virtual PropertyGrid PropertyGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PropertyGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PropertyGrid = value;
			}
		}

		public virtual DesignPanel DesignPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DesignPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DesignPanel.RefreshControlListEventHandler obj = new DesignPanel.RefreshControlListEventHandler(this.DesignPanel_RefreshControlList);
				DesignPanel.ReleaseDrawContolEventHandler obj2 = new DesignPanel.ReleaseDrawContolEventHandler(this.DesignPanel_ReleaseDrawContol);
				if (this._DesignPanel != null)
				{
					this._DesignPanel.RefreshControlList -= obj;
					this._DesignPanel.ReleaseDrawContol -= obj2;
				}
				this._DesignPanel = value;
				if (this._DesignPanel != null)
				{
					this._DesignPanel.RefreshControlList += obj;
					this._DesignPanel.ReleaseDrawContol += obj2;
				}
			}
		}

		public MMetaData MetaData
		{
			get
			{
				return this._MetaData;
			}
			set
			{
				this._MetaData = value;
			}
		}

		public NInstanceData InstanceData
		{
			get
			{
				return this._InstanceData;
			}
			set
			{
				this._InstanceData = value;
				this.DesignPanel.InstanceData = value;
			}
		}

		public bool IsAllControlsUsed
		{
			get
			{
				try
				{
					IEnumerator enumerator = this.gvContent.get_GroupViewItems().GetEnumerator();
					while (enumerator.MoveNext())
					{
						GroupViewItem groupViewItem = (GroupViewItem)enumerator.Current;
						NInstanceItem nInstanceItem = (NInstanceItem)groupViewItem.get_Tag();
						if ((groupViewItem.get_ImageIndex() != 4 & groupViewItem.get_Tag() != null) && !nInstanceItem.BindMMetaItem.BindControl)
						{
							return false;
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
				return true;
			}
		}

		public DCInterface()
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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DCInterface));
			this.gbDesign = new GroupBar();
			this.gvContent = new GroupView();
			this.dcImageList = new ImageList(this.components);
			this.PropertyGrid = new PropertyGrid();
			this.gvDC = new GroupView();
			this.gbDC = new GroupBarItem();
			this.gbContent = new GroupBarItem();
			this.gbProperty = new GroupBarItem();
			this.topPanel = new Panel();
			this.mainPanel = new Panel();
			this.downDesignPanel = new Panel();
			this.spDesign = new Splitter();
			this.gbDesign.BeginInit();
			this.gbDesign.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			this.gbDesign.AllowDrop = true;
			this.gbDesign.Controls.Add(this.PropertyGrid);
			this.gbDesign.Controls.Add(this.gvContent);
			this.gbDesign.Controls.Add(this.gvDC);
			this.gbDesign.Dock = DockStyle.Left;
			this.gbDesign.get_GroupBarItems().AddRange(new GroupBarItem[]
			{
				this.gbDC,
				this.gbContent,
				this.gbProperty
			});
			this.gbDesign.set_IntegratedScrolling(true);
			Control arg_175_0 = this.gbDesign;
			Point location = new Point(0, 0);
			arg_175_0.Location = location;
			this.gbDesign.Name = "gbDesign";
			GroupBar arg_19A_0 = this.gbDesign;
			Size size = new Size(0, 0);
			arg_19A_0.set_PopupClientSize(size);
			this.gbDesign.set_SelectedItem(2);
			Control arg_1C3_0 = this.gbDesign;
			size = new Size(200, 356);
			arg_1C3_0.Size = size;
			this.gbDesign.TabIndex = 0;
			this.gbDesign.set_TextAlign(1);
			this.gvContent.set_AllowDragDrop(true);
			this.gvContent.set_BorderStyle(BorderStyle.None);
			this.gvContent.set_ButtonView(true);
			this.gvContent.set_ItemYSpacing(1);
			this.gvContent.set_LargeImageList(null);
			Control arg_22D_0 = this.gvContent;
			location = new Point(2, 46);
			arg_22D_0.Location = location;
			this.gvContent.Name = "gvContent";
			this.gvContent.set_SelectedItemColor(Color.FromArgb(233, 229, 221));
			this.gvContent.set_SelectingItemColor(Color.FromArgb(233, 229, 221));
			Control arg_294_0 = this.gvContent;
			size = new Size(195, 0);
			arg_294_0.Size = size;
			this.gvContent.set_SmallImageList(this.dcImageList);
			this.gvContent.set_SmallImageView(true);
			this.gvContent.TabIndex = 1;
			this.dcImageList.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("dcImageList.ImageStream");
			this.dcImageList.TransparentColor = Color.Transparent;
			this.dcImageList.Images.SetKeyName(0, "");
			this.dcImageList.Images.SetKeyName(1, "");
			this.dcImageList.Images.SetKeyName(2, "");
			this.dcImageList.Images.SetKeyName(3, "");
			this.dcImageList.Images.SetKeyName(4, "");
			this.dcImageList.Images.SetKeyName(5, "");
			this.dcImageList.Images.SetKeyName(6, "");
			this.dcImageList.Images.SetKeyName(7, "");
			this.dcImageList.Images.SetKeyName(8, "");
			this.dcImageList.Images.SetKeyName(9, "");
			this.dcImageList.Images.SetKeyName(10, "");
			this.dcImageList.Images.SetKeyName(11, "");
			this.dcImageList.Images.SetKeyName(12, "");
			this.dcImageList.Images.SetKeyName(13, "");
			this.dcImageList.Images.SetKeyName(14, "");
			this.dcImageList.Images.SetKeyName(15, "");
			this.dcImageList.Images.SetKeyName(16, "");
			this.dcImageList.Images.SetKeyName(17, "");
			this.PropertyGrid.HelpVisible = false;
			this.PropertyGrid.LineColor = SystemColors.ScrollBar;
			Control arg_4AF_0 = this.PropertyGrid;
			location = new Point(2, 68);
			arg_4AF_0.Location = location;
			this.PropertyGrid.Name = "PropertyGrid";
			Control arg_4DC_0 = this.PropertyGrid;
			size = new Size(195, 264);
			arg_4DC_0.Size = size;
			this.PropertyGrid.TabIndex = 2;
			this.PropertyGrid.ToolbarVisible = false;
			this.gvDC.set_BorderStyle(BorderStyle.None);
			this.gvDC.set_ButtonView(true);
			this.gvDC.set_IntegratedScrolling(true);
			this.gvDC.set_ItemYSpacing(1);
			this.gvDC.set_LargeImageList(null);
			Control arg_546_0 = this.gvDC;
			location = new Point(2, 23);
			arg_546_0.Location = location;
			this.gvDC.Name = "gvDC";
			this.gvDC.set_SelectedItemColor(Color.FromArgb(233, 229, 221));
			this.gvDC.set_SelectingItemColor(Color.FromArgb(233, 229, 221));
			Control arg_5AD_0 = this.gvDC;
			size = new Size(196, 0);
			arg_5AD_0.Size = size;
			this.gvDC.set_SmallImageList(this.dcImageList);
			this.gvDC.set_SmallImageView(true);
			this.gvDC.TabIndex = 0;
			this.gbDC.set_Client(this.gvDC);
			this.gbDC.set_Text("设计控件");
			this.gbContent.set_Client(this.gvContent);
			this.gbContent.set_Text("内容控件");
			this.gbProperty.set_Client(this.PropertyGrid);
			this.gbProperty.set_Text("设置属性");
			this.topPanel.Dock = DockStyle.Top;
			Control arg_65A_0 = this.topPanel;
			location = new Point(0, 0);
			arg_65A_0.Location = location;
			this.topPanel.Name = "topPanel";
			Control arg_684_0 = this.topPanel;
			size = new Size(580, 24);
			arg_684_0.Size = size;
			this.topPanel.TabIndex = 1;
			this.mainPanel.Controls.Add(this.downDesignPanel);
			this.mainPanel.Controls.Add(this.spDesign);
			this.mainPanel.Controls.Add(this.gbDesign);
			this.mainPanel.Dock = DockStyle.Fill;
			Control arg_6F4_0 = this.mainPanel;
			location = new Point(0, 24);
			arg_6F4_0.Location = location;
			this.mainPanel.Name = "mainPanel";
			Control arg_721_0 = this.mainPanel;
			size = new Size(580, 356);
			arg_721_0.Size = size;
			this.mainPanel.TabIndex = 2;
			this.downDesignPanel.BorderStyle = BorderStyle.FixedSingle;
			this.downDesignPanel.Dock = DockStyle.Fill;
			Control arg_75E_0 = this.downDesignPanel;
			location = new Point(208, 0);
			arg_75E_0.Location = location;
			this.downDesignPanel.Name = "downDesignPanel";
			Control arg_78B_0 = this.downDesignPanel;
			size = new Size(372, 356);
			arg_78B_0.Size = size;
			this.downDesignPanel.TabIndex = 2;
			Control arg_7B0_0 = this.spDesign;
			location = new Point(200, 0);
			arg_7B0_0.Location = location;
			this.spDesign.Name = "spDesign";
			Control arg_7D9_0 = this.spDesign;
			size = new Size(8, 356);
			arg_7D9_0.Size = size;
			this.spDesign.TabIndex = 1;
			this.spDesign.TabStop = false;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "DCInterface";
			size = new Size(580, 380);
			this.Size = size;
			this.gbDesign.EndInit();
			this.gbDesign.ResumeLayout(false);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.DesignPanel = new DesignPanel();
			this.DesignPanel.Dock = DockStyle.Fill;
			this.DesignPanel.PropertyGrid = this.PropertyGrid;
			this.downDesignPanel.Controls.Add(this.DesignPanel);
			this.gvContent.get_GroupViewItems().AddRange(new GroupViewItem[]
			{
				new GroupViewItem("指针", 0)
			});
			this.gvDC.get_GroupViewItems().AddRange(new GroupViewItem[]
			{
				new GroupViewItem("指针", 0),
				new GroupViewItem("标签", 4),
				new GroupViewItem("方框", 3),
				new GroupViewItem("横线", 1),
				new GroupViewItem("竖线", 2),
				new GroupViewItem("表格", 12)
			});
		}

		public void RefreshContentList()
		{
			checked
			{
				int num = this.gvContent.get_GroupViewItems().Count - 1;
				int arg_16_0 = 1;
				int num2 = num;
				for (int i = arg_16_0; i <= num2; i++)
				{
					this.gvContent.get_GroupViewItems().RemoveAt(1);
				}
				if (this._InstanceData != null & this._InstanceData.BindMMetaItem != null)
				{
					GroupViewItem groupViewItem = new GroupViewItem(this._InstanceData.BindMMetaItem.Text, 4);
					groupViewItem.set_Tag(this._InstanceData);
					this.gvContent.get_GroupViewItems().Add(groupViewItem);
					if (this._InstanceData.BindMMetaItem.BindLabel)
					{
						groupViewItem.set_Enabled(false);
					}
					this.RefreshMetaItem(this._InstanceData);
				}
			}
		}

		private void RefreshMetaItem(NInstanceItem objInstanceItem)
		{
			if (objInstanceItem != null & objInstanceItem.SubItems.Count > 0)
			{
				NInstanceItemEnumerator enumerator = objInstanceItem.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
					if (nInstanceItem.BindMMetaItem is MIString)
					{
						GroupViewItem groupViewItem = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem2 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 5);
						groupViewItem2.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem, groupViewItem2);
					}
					else if (nInstanceItem.BindMMetaItem is MINumber)
					{
						GroupViewItem groupViewItem3 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem3.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem4 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 6);
						groupViewItem4.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem3, groupViewItem4);
					}
					else if (nInstanceItem.BindMMetaItem is MIMonoChoice)
					{
						GroupViewItem groupViewItem5 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem5.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem6 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 7);
						groupViewItem6.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem5, groupViewItem6);
					}
					else if (nInstanceItem.BindMMetaItem is MIMultiChoice)
					{
						GroupViewItem groupViewItem7 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem7.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem8 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 8);
						groupViewItem8.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem7, groupViewItem8);
					}
					else if (nInstanceItem.BindMMetaItem is MIDateTime)
					{
						GroupViewItem groupViewItem9 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem9.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem10 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 9);
						groupViewItem10.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem9, groupViewItem10);
					}
					else if (nInstanceItem.BindMMetaItem is MIQuantity)
					{
						GroupViewItem groupViewItem11 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem11.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem12 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 10);
						groupViewItem12.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem11, groupViewItem12);
					}
					else if (nInstanceItem.BindMMetaItem is MIDictionary)
					{
						GroupViewItem groupViewItem13 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem13.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem14 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 11);
						groupViewItem14.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem13, groupViewItem14);
					}
					else if (nInstanceItem.BindMMetaItem is MIPosition)
					{
						GroupViewItem groupViewItem15 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem15.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem16 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 16);
						groupViewItem16.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem15, groupViewItem16);
					}
					else if (nInstanceItem.BindMMetaItem is MITable)
					{
						GroupViewItem groupViewItem17 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem17.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem18 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 12);
						groupViewItem18.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem17, groupViewItem18);
					}
					else if (nInstanceItem.BindMMetaItem is MIImageAnnotate)
					{
						GroupViewItem groupViewItem19 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem19.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem20 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 15);
						groupViewItem20.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem19, groupViewItem20);
					}
					else if (nInstanceItem.BindMMetaItem is MITextDesc)
					{
						GroupViewItem groupViewItem21 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem21.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem22 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 13);
						groupViewItem22.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem21, groupViewItem22);
					}
					else if (nInstanceItem.BindMMetaItem is MISegment)
					{
						GroupViewItem groupViewItem23 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem23.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem24 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 14);
						groupViewItem24.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem23, groupViewItem24);
					}
					else if (nInstanceItem.BindMMetaItem is MIFigure)
					{
						GroupViewItem groupViewItem25 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem25.set_Tag(nInstanceItem);
						GroupViewItem groupViewItem26 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 17);
						groupViewItem26.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem25, groupViewItem26);
					}
					else if (nInstanceItem.BindMMetaItem is MICluster)
					{
						GroupViewItem groupViewItem27 = new GroupViewItem(nInstanceItem.BindMMetaItem.Text, 4);
						groupViewItem27.set_Tag(nInstanceItem);
						this.AddGroupViewItem(nInstanceItem, groupViewItem27, null);
						this.RefreshMetaItem(nInstanceItem);
					}
				}
			}
		}

		private void AddGroupViewItem(NInstanceItem item, GroupViewItem gvItemLabel, GroupViewItem gvItem)
		{
			if (item != null & item.BindMMetaItem.Status != EPRStatus.ABandon)
			{
				if (gvItemLabel != null)
				{
					this.gvContent.get_GroupViewItems().Add(gvItemLabel);
					if (this.findControl(gvItemLabel))
					{
						gvItemLabel.set_Enabled(false);
					}
					else
					{
						gvItemLabel.set_Enabled(true);
					}
				}
				if (gvItem != null)
				{
					this.gvContent.get_GroupViewItems().Add(gvItem);
					if (this.findControl(gvItem))
					{
						gvItem.set_Enabled(false);
					}
					else
					{
						gvItem.set_Enabled(true);
					}
				}
			}
		}

		public void CheckBindControl()
		{
			try
			{
				IEnumerator enumerator = this.gvContent.get_GroupViewItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupViewItem groupViewItem = (GroupViewItem)enumerator.Current;
					NInstanceItem nInstanceItem = (NInstanceItem)groupViewItem.get_Tag();
					if (groupViewItem.get_ImageIndex() != 4 & groupViewItem.get_Tag() != null)
					{
						bool arg_51_0 = nInstanceItem.BindMMetaItem.BindControl;
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

		private void gvDC_GroupViewItemSelected(object sender, EventArgs e)
		{
			if (this.gvDC.get_SelectedItem() == 0)
			{
				this.DesignPanel.DrawControl = false;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = (DrawCtrlType)0;
			}
			else if (this.gvDC.get_SelectedItem() == 1)
			{
				this.DesignPanel.DrawControl = true;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = DrawCtrlType.Label;
			}
			else if (this.gvDC.get_SelectedItem() == 2)
			{
				this.DesignPanel.DrawControl = true;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = DrawCtrlType.Box;
			}
			else if (this.gvDC.get_SelectedItem() == 3)
			{
				this.DesignPanel.DrawControl = true;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = DrawCtrlType.HLine;
			}
			else if (this.gvDC.get_SelectedItem() == 4)
			{
				this.DesignPanel.DrawControl = true;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = DrawCtrlType.VLine;
			}
			else if (this.gvDC.get_SelectedItem() == 5)
			{
				this.DesignPanel.DrawControl = true;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = DrawCtrlType.AlignTable;
			}
		}

		private void DesignPanel_ReleaseDrawContol()
		{
			if (this.gbDesign.get_SelectedItem() == 0)
			{
				this.gvDC.set_SelectedItem(0);
				this.DesignPanel.DrawControl = false;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = (DrawCtrlType)0;
			}
			else if (this.gbDesign.get_SelectedItem() == 1)
			{
				this.gvContent.set_SelectedItem(0);
				this.DesignPanel.DrawControl = false;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = (DrawCtrlType)0;
			}
		}

		private void DesignPanel_RefreshControlList()
		{
			this.RefreshContentList();
		}

		private void gvContent_MouseDown(object sender, MouseEventArgs e)
		{
			Point point = new Point(e.X, e.Y);
			int itemUnderPoint = this.gvContent.GetItemUnderPoint(point);
			this.gvContent.set_SelectedItem(itemUnderPoint);
			this.ProcessItemSelected(itemUnderPoint);
		}

		private DrawCtrlType SetDrawType(int index)
		{
			DrawCtrlType result;
			switch (index)
			{
			case 4:
				result = DrawCtrlType.Label;
				break;
			case 5:
				result = DrawCtrlType.MIString;
				break;
			case 6:
				result = DrawCtrlType.MINumber;
				break;
			case 7:
				result = DrawCtrlType.MIMonoChoice;
				break;
			case 8:
				result = DrawCtrlType.MIMultiChoice;
				break;
			case 9:
				result = DrawCtrlType.MIDateTime;
				break;
			case 10:
				result = DrawCtrlType.MIQuantity;
				break;
			case 11:
				result = DrawCtrlType.MIDictionary;
				break;
			case 12:
				result = DrawCtrlType.MITable;
				break;
			case 13:
				result = DrawCtrlType.MITextDesc;
				break;
			case 14:
				result = DrawCtrlType.MISegment;
				break;
			case 15:
				result = DrawCtrlType.MIImageAnnotate;
				break;
			case 16:
				result = DrawCtrlType.MIPosition;
				break;
			case 17:
				result = DrawCtrlType.MIFigure;
				break;
			}
			return result;
		}

		private void gvContent_KeyUp(object sender, KeyEventArgs e)
		{
			int selectedItem = ((GroupView)sender).get_SelectedItem();
			this.ProcessItemSelected(selectedItem);
		}

		private bool findControl(GroupViewItem objGVItem)
		{
			bool result = false;
			NInstanceItem nInstanceItem = (NInstanceItem)objGVItem.get_Tag();
			try
			{
				IEnumerator enumerator = this.DesignPanel.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					DesignControl designControl = (DesignControl)control;
					switch (objGVItem.get_ImageIndex())
					{
					case 4:
						if (designControl is DCLabel && Operators.CompareString(((DCLabel)designControl).PCLabel.Code, ((NInstanceItem)objGVItem.get_Tag()).Code, false) == 0)
						{
							result = true;
							return result;
						}
						break;
					case 5:
						if (designControl is DCString && ((DCString)designControl).PCString.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 6:
						if (designControl is DCNumber && ((DCNumber)designControl).PCNumber.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 7:
						if (designControl is DCMonoChoice && ((DCMonoChoice)designControl).PCMonoChoice.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 8:
						if (designControl is DCMultiChoice && ((DCMultiChoice)designControl).PCMultiChoice.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 9:
						if (designControl is DCDateTime && ((DCDateTime)designControl).PCDateTime.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 10:
						if (designControl is DCQuantity && ((DCQuantity)designControl).PCQuantity.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 11:
						if (designControl is DCDictionary && ((DCDictionary)designControl).PCDictionary.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 12:
						if (designControl is DCTable && ((DCTable)designControl).PCTable.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 13:
					case 14:
						if (designControl is DCTextEdit && ((DCTextEdit)designControl).PCTextEdit.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 15:
						if (designControl is DCImageAnnotate && ((DCImageAnnotate)designControl).PCImageAnnotate.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 16:
						if (designControl is DCPosition && ((DCPosition)designControl).PCPosition.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
						}
						break;
					case 17:
						if (designControl is DCFigure && ((DCFigure)designControl).PCFigure.BindInstanceItem == nInstanceItem)
						{
							result = true;
							return result;
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
			return result;
		}

		private void ProcessItemSelected(int index)
		{
			this.DesignPanel.ClearSelectedControls();
			if (index < 1)
			{
				this.DesignPanel.DrawControl = false;
				this.DesignPanel.DrawInstanceItem = null;
				this.DesignPanel.DrawType = (DrawCtrlType)0;
			}
			else
			{
				GroupViewItem groupViewItem = this.gvContent.get_GroupViewItems().get_Item(index);
				NInstanceItem nInstanceItem = (NInstanceItem)groupViewItem.get_Tag();
				if ((groupViewItem.get_ImageIndex() == 4 & nInstanceItem.BindMMetaItem.BindLabel) | (groupViewItem.get_ImageIndex() != 4 & nInstanceItem.BindMMetaItem.BindControl))
				{
					this.DesignPanel.DrawControl = false;
					this.DesignPanel.DrawInstanceItem = null;
					this.DesignPanel.DrawType = (DrawCtrlType)0;
					try
					{
						IEnumerator enumerator = this.DesignPanel.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							DesignControl designControl = (DesignControl)control;
							switch (groupViewItem.get_ImageIndex())
							{
							case 4:
								if (designControl is DCLabel && Operators.CompareString(((DCLabel)designControl).PCLabel.Code, ((NInstanceItem)groupViewItem.get_Tag()).Code, false) == 0)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 5:
								if (designControl is DCString && ((DCString)designControl).PCString.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 6:
								if (designControl is DCNumber && ((DCNumber)designControl).PCNumber.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 7:
								if (designControl is DCMonoChoice && ((DCMonoChoice)designControl).PCMonoChoice.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 8:
								if (designControl is DCMultiChoice && ((DCMultiChoice)designControl).PCMultiChoice.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 9:
								if (designControl is DCDateTime && ((DCDateTime)designControl).PCDateTime.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 10:
								if (designControl is DCQuantity && ((DCQuantity)designControl).PCQuantity.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 11:
								if (designControl is DCDictionary && ((DCDictionary)designControl).PCDictionary.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 12:
								if (designControl is DCTable && ((DCTable)designControl).PCTable.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 13:
							case 14:
								if (designControl is DCTextEdit && ((DCTextEdit)designControl).PCTextEdit.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 15:
								if (designControl is DCImageAnnotate && ((DCImageAnnotate)designControl).PCImageAnnotate.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 16:
								if (designControl is DCPosition && ((DCPosition)designControl).PCPosition.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
								}
								break;
							case 17:
								if (designControl is DCFigure && ((DCFigure)designControl).PCFigure.BindInstanceItem == nInstanceItem)
								{
									this.DesignPanel.HightlightControl(designControl);
									goto IL_3CB;
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
					IL_3CB:;
				}
				else
				{
					this.DesignPanel.DrawType = this.SetDrawType(groupViewItem.get_ImageIndex());
					this.DesignPanel.DrawControl = true;
					this.DesignPanel.DrawInstanceItem = (NInstanceItem)groupViewItem.get_Tag();
					this.gvContent.DoDragDrop("", DragDropEffects.Copy);
				}
			}
		}
	}
}
