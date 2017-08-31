using AdmImageItemData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.systemframework;
using ImageItemData;
using ImageLibData;
using ImageTreeData;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.imagelibdesign
{
	public class DCImageLib : UserControl
	{
		private IContainer components;

		[AccessedThroughProperty("tcImageLib")]
		private TabControl _tcImageLib;

		[AccessedThroughProperty("tpCommonLib")]
		private TabPage _tpCommonLib;

		[AccessedThroughProperty("tpAdmLib")]
		private TabPage _tpAdmLib;

		[AccessedThroughProperty("gbxProperty")]
		private GroupBox _gbxProperty;

		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("txtDesc")]
		private TextBox _txtDesc;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("pnlImageDetail")]
		private Panel _pnlImageDetail;

		[AccessedThroughProperty("SplitContainer2")]
		private SplitContainer _SplitContainer2;

		[AccessedThroughProperty("btnResetHotSpot")]
		private Button _btnResetHotSpot;

		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		private const string Key_EPISODEID = "EpisodeID";

		private string _ImageLibID;

		private bool _ClientMode;

		private bool _BindImageLib;

		private EImageLib _EImageLib;

		[AccessedThroughProperty("miAddAdmImageItem")]
		private MenuItem _miAddAdmImageItem;

		[AccessedThroughProperty("AdmLibTree")]
		private AdmLibTree _AdmLibTree;

		[AccessedThroughProperty("ImageLibTree")]
		private ImageLibTree _ImageLibTree;

		[AccessedThroughProperty("DCImageWizard")]
		private DCImageWizard _DCImageWizard;

		internal virtual TabControl tcImageLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tcImageLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tcImageLib = value;
			}
		}

		internal virtual TabPage tpCommonLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpCommonLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpCommonLib = value;
			}
		}

		internal virtual TabPage tpAdmLib
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tpAdmLib;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpAdmLib = value;
			}
		}

		internal virtual GroupBox gbxProperty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gbxProperty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbxProperty = value;
			}
		}

		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtName = value;
			}
		}

		internal virtual Label lblName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblName = value;
			}
		}

		internal virtual TextBox txtDesc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDesc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDesc = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Button btnSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSave;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSave_Click);
				if (this._btnSave != null)
				{
					this._btnSave.Click -= value2;
				}
				this._btnSave = value;
				if (this._btnSave != null)
				{
					this._btnSave.Click += value2;
				}
			}
		}

		internal virtual Panel pnlImageDetail
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pnlImageDetail;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlImageDetail = value;
			}
		}

		internal virtual SplitContainer SplitContainer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer2 = value;
			}
		}

		internal virtual Button btnResetHotSpot
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnResetHotSpot;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnResetHotSpot_Click);
				if (this._btnResetHotSpot != null)
				{
					this._btnResetHotSpot.Click -= value2;
				}
				this._btnResetHotSpot = value;
				if (this._btnResetHotSpot != null)
				{
					this._btnResetHotSpot.Click += value2;
				}
			}
		}

		internal virtual SplitContainer SplitContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer1 = value;
			}
		}

		private virtual MenuItem miAddAdmImageItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miAddAdmImageItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._miAddAdmImageItem = value;
			}
		}

		public virtual AdmLibTree AdmLibTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AdmLibTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AdmLibTree = value;
			}
		}

		public virtual ImageLibTree ImageLibTree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageLibTree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageLibTree = value;
			}
		}

		public virtual DCImageWizard DCImageWizard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DCImageWizard;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DCImageWizard = value;
			}
		}

		public bool ClientMode
		{
			get
			{
				return this._ClientMode;
			}
			set
			{
				this._ClientMode = value;
				if (!this.IsRealClientMode(this._ClientMode, "EpisodeID"))
				{
					this.btnSave.Visible = true;
					this.tcImageLib.Controls.RemoveByKey("tpAdmLib");
				}
				else
				{
					this.AdmLibTree = new AdmLibTree();
					this.AdmLibTree.Dock = DockStyle.Fill;
					this.tpAdmLib.Controls.Add(this.AdmLibTree);
					this.AdmLibTree.MouseDown += new MouseEventHandler(this.AdmLibTree_MouseDown);
					this.AdmLibTree.AfterSelect += new TreeViewEventHandler(this.AdmLibTree_AfterClick);
					string valueByKey = GlobalValues.GetValueByKey("EpisodeID");
					if (!string.IsNullOrEmpty(valueByKey))
					{
						this.AdmLibTree.EpisodeID = valueByKey;
					}
					else
					{
						MessageManager.ShowErrorMessage("加载患者图库时无法获取当前就诊指针!");
					}
				}
			}
		}

		public bool BindImageLib
		{
			get
			{
				return this._BindImageLib;
			}
			set
			{
				this._BindImageLib = value;
				if (!this._BindImageLib)
				{
					this.tcImageLib.Controls.RemoveByKey("tpCommonLib");
				}
				else
				{
					this.ImageLibTree = new ImageLibTree();
					this.ImageLibTree.Dock = DockStyle.Fill;
					this.tpCommonLib.Controls.Add(this.ImageLibTree);
					this.ImageLibTree.AfterSelect += new TreeViewEventHandler(this.ImageLibTree_AfterClick);
				}
			}
		}

		public EImageLib EImageLib
		{
			get
			{
				return this._EImageLib;
			}
			set
			{
				this._EImageLib = value;
			}
		}

		public string ImageLibID
		{
			get
			{
				return this._ImageLibID;
			}
			set
			{
				this._ImageLibID = value;
				if (this.ImageLibTree != null)
				{
					this.ImageLibTree.ClientMode = this.ClientMode;
					EImageLib imageLibByID = WebServiceLayer.ImageLibAccess.GetImageLibByID(this._ImageLibID);
					this.ImageLibTree.EImageLib = imageLibByID;
					this.EImageLib = imageLibByID;
				}
			}
		}

		public string SelectedImageTreeType
		{
			get
			{
				bool flag = this.IsRealClientMode(this._ClientMode, "EpisodeID");
				bool flag2 = this.BindImageLib && !string.IsNullOrEmpty(this.ImageLibID);
				if (flag2 && flag)
				{
					if (this.tcImageLib.SelectedIndex == 0)
					{
						return ImageLibType.CI.ToString();
					}
					if (this.tcImageLib.SelectedIndex == 1)
					{
						return ImageLibType.EI.ToString();
					}
					return string.Empty;
				}
				else
				{
					if (flag2)
					{
						return ImageLibType.CI.ToString();
					}
					if (flag)
					{
						return ImageLibType.EI.ToString();
					}
					return string.Empty;
				}
			}
		}

		public DCImageLib()
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
			this.pnlImageDetail = new Panel();
			this.gbxProperty = new GroupBox();
			this.btnSave = new Button();
			this.txtDesc = new TextBox();
			this.Label1 = new Label();
			this.txtName = new TextBox();
			this.lblName = new Label();
			this.tcImageLib = new TabControl();
			this.tpCommonLib = new TabPage();
			this.tpAdmLib = new TabPage();
			this.SplitContainer1 = new SplitContainer();
			this.SplitContainer2 = new SplitContainer();
			this.btnResetHotSpot = new Button();
			this.gbxProperty.SuspendLayout();
			this.tcImageLib.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.SuspendLayout();
			this.pnlImageDetail.Dock = DockStyle.Fill;
			Control arg_11D_0 = this.pnlImageDetail;
			Point location = new Point(0, 0);
			arg_11D_0.Location = location;
			this.pnlImageDetail.Name = "pnlImageDetail";
			Control arg_14A_0 = this.pnlImageDetail;
			Size size = new Size(594, 419);
			arg_14A_0.Size = size;
			this.pnlImageDetail.TabIndex = 1;
			this.gbxProperty.Controls.Add(this.btnResetHotSpot);
			this.gbxProperty.Controls.Add(this.btnSave);
			this.gbxProperty.Controls.Add(this.txtDesc);
			this.gbxProperty.Controls.Add(this.Label1);
			this.gbxProperty.Controls.Add(this.txtName);
			this.gbxProperty.Controls.Add(this.lblName);
			this.gbxProperty.Dock = DockStyle.Fill;
			Control arg_1FB_0 = this.gbxProperty;
			location = new Point(0, 0);
			arg_1FB_0.Location = location;
			this.gbxProperty.Name = "gbxProperty";
			Control arg_225_0 = this.gbxProperty;
			size = new Size(594, 75);
			arg_225_0.Size = size;
			this.gbxProperty.TabIndex = 0;
			this.gbxProperty.TabStop = false;
			this.gbxProperty.Text = "图库属性";
			Control arg_267_0 = this.btnSave;
			location = new Point(229, 18);
			arg_267_0.Location = location;
			this.btnSave.Name = "btnSave";
			Control arg_28E_0 = this.btnSave;
			size = new Size(75, 23);
			arg_28E_0.Size = size;
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.UseVisualStyleBackColor = true;
			this.txtDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_2DA_0 = this.txtDesc;
			location = new Point(74, 45);
			arg_2DA_0.Location = location;
			this.txtDesc.Name = "txtDesc";
			Control arg_304_0 = this.txtDesc;
			size = new Size(505, 21);
			arg_304_0.Size = size;
			this.txtDesc.TabIndex = 3;
			this.Label1.AutoSize = true;
			Control arg_332_0 = this.Label1;
			location = new Point(6, 49);
			arg_332_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_359_0 = this.Label1;
			size = new Size(65, 12);
			arg_359_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "节点描述：";
			Control arg_38C_0 = this.txtName;
			location = new Point(74, 19);
			arg_38C_0.Location = location;
			this.txtName.Name = "txtName";
			Control arg_3B6_0 = this.txtName;
			size = new Size(149, 21);
			arg_3B6_0.Size = size;
			this.txtName.TabIndex = 1;
			this.lblName.AutoSize = true;
			Control arg_3E4_0 = this.lblName;
			location = new Point(6, 23);
			arg_3E4_0.Location = location;
			this.lblName.Name = "lblName";
			Control arg_40B_0 = this.lblName;
			size = new Size(65, 12);
			arg_40B_0.Size = size;
			this.lblName.TabIndex = 0;
			this.lblName.Text = "节点名称：";
			this.tcImageLib.Controls.Add(this.tpCommonLib);
			this.tcImageLib.Controls.Add(this.tpAdmLib);
			this.tcImageLib.Dock = DockStyle.Fill;
			Control arg_474_0 = this.tcImageLib;
			location = new Point(0, 0);
			arg_474_0.Location = location;
			this.tcImageLib.Name = "tcImageLib";
			this.tcImageLib.SelectedIndex = 0;
			Control arg_4AD_0 = this.tcImageLib;
			size = new Size(236, 496);
			arg_4AD_0.Size = size;
			this.tcImageLib.TabIndex = 0;
			TabPage arg_4CF_0 = this.tpCommonLib;
			location = new Point(4, 21);
			arg_4CF_0.Location = location;
			this.tpCommonLib.Name = "tpCommonLib";
			Control arg_4F3_0 = this.tpCommonLib;
			Padding padding = new Padding(3);
			arg_4F3_0.Padding = padding;
			Control arg_510_0 = this.tpCommonLib;
			size = new Size(228, 471);
			arg_510_0.Size = size;
			this.tpCommonLib.TabIndex = 0;
			this.tpCommonLib.Text = "通用图库";
			this.tpCommonLib.UseVisualStyleBackColor = true;
			TabPage arg_54E_0 = this.tpAdmLib;
			location = new Point(4, 21);
			arg_54E_0.Location = location;
			this.tpAdmLib.Name = "tpAdmLib";
			Control arg_572_0 = this.tpAdmLib;
			padding = new Padding(3);
			arg_572_0.Padding = padding;
			Control arg_58F_0 = this.tpAdmLib;
			size = new Size(228, 471);
			arg_58F_0.Size = size;
			this.tpAdmLib.TabIndex = 1;
			this.tpAdmLib.Text = "患者图库";
			this.tpAdmLib.UseVisualStyleBackColor = true;
			this.SplitContainer1.BorderStyle = BorderStyle.Fixed3D;
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel1;
			Control arg_5F0_0 = this.SplitContainer1;
			location = new Point(0, 0);
			arg_5F0_0.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Panel1.Controls.Add(this.tcImageLib);
			this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
			Control arg_653_0 = this.SplitContainer1;
			size = new Size(840, 500);
			arg_653_0.Size = size;
			this.SplitContainer1.SplitterDistance = 240;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 2;
			this.SplitContainer2.Dock = DockStyle.Fill;
			this.SplitContainer2.FixedPanel = FixedPanel.Panel1;
			Control arg_6A8_0 = this.SplitContainer2;
			location = new Point(0, 0);
			arg_6A8_0.Location = location;
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = Orientation.Horizontal;
			this.SplitContainer2.Panel1.Controls.Add(this.gbxProperty);
			this.SplitContainer2.Panel2.Controls.Add(this.pnlImageDetail);
			Control arg_717_0 = this.SplitContainer2;
			size = new Size(594, 496);
			arg_717_0.Size = size;
			this.SplitContainer2.SplitterDistance = 75;
			this.SplitContainer2.SplitterWidth = 2;
			this.SplitContainer2.TabIndex = 2;
			Control arg_756_0 = this.btnResetHotSpot;
			location = new Point(329, 18);
			arg_756_0.Location = location;
			this.btnResetHotSpot.Name = "btnResetHotSpot";
			Control arg_77D_0 = this.btnResetHotSpot;
			size = new Size(75, 23);
			arg_77D_0.Size = size;
			this.btnResetHotSpot.TabIndex = 5;
			this.btnResetHotSpot.Text = "重设热点";
			this.btnResetHotSpot.UseVisualStyleBackColor = true;
			this.btnResetHotSpot.Visible = false;
			this.Controls.Add(this.SplitContainer1);
			this.Name = "DCImageLib";
			size = new Size(840, 500);
			this.Size = size;
			this.gbxProperty.ResumeLayout(false);
			this.gbxProperty.PerformLayout();
			this.tcImageLib.ResumeLayout(false);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.SplitContainer2.Panel1.ResumeLayout(false);
			this.SplitContainer2.Panel2.ResumeLayout(false);
			this.SplitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.miAddAdmImageItem = new MenuItem("新增图片");
			this.miAddAdmImageItem.Click += new EventHandler(this.AddAdmLibItem_Click);
			this.DCImageWizard = new DCImageWizard();
			this.DCImageWizard.Dock = DockStyle.Fill;
			this.DCImageWizard.Clear();
			this.pnlImageDetail.Controls.Add(this.DCImageWizard);
		}

		public void AdmLibTree_AfterClick(object sender, TreeViewEventArgs e)
		{
			string publishStatus = string.Empty;
			this.DCImageWizard.Clear();
			TreeNode node = e.Node;
			string nodeType = this.AdmLibTree.GetNodeType(node);
			if (Operators.CompareString(nodeType, "RT", false) != 0)
			{
				string nodeID = this.AdmLibTree.GetNodeID(node);
				EAdmImageItem entity = WebServiceLayer.AdmImageItemAccess.GetEntity(nodeID);
				if (entity != null)
				{
					this.txtName.Text = entity.Name;
					this.txtDesc.Text = entity.Description;
					publishStatus = entity.IsPublish;
					this.DCImageWizard.EAdmImageItem = entity;
					this.pnlImageDetail.Controls.Add(this.DCImageWizard);
				}
			}
			else
			{
				this.txtName.Text = node.Text;
				this.txtDesc.Text = string.Empty;
			}
			bool isRootNode = Operators.CompareString(nodeType, "RT", false) == 0;
			bool isAdmImageLib = true;
			this.SetImageLibProperty(isRootNode, isAdmImageLib, publishStatus);
		}

		public void AdmLibTree_MouseDown(object sender, MouseEventArgs e)
		{
			TreeNode nodeAt = this.AdmLibTree.GetNodeAt(e.Location);
			if (nodeAt != null)
			{
				string nodeType = this.AdmLibTree.GetNodeType(nodeAt);
				if (Operators.CompareString(nodeType, "RT", false) == 0 && e.Button == MouseButtons.Right)
				{
					this.AdmLibTree.cmAdmImageTree.MenuItems.Clear();
					this.AdmLibTree.cmAdmImageTree.MenuItems.Add(this.miAddAdmImageItem);
					ContextMenu arg_97_0 = this.AdmLibTree.cmAdmImageTree;
					Control arg_97_1 = this.AdmLibTree;
					Point pos = new Point(e.X, e.Y);
					arg_97_0.Show(arg_97_1, pos);
				}
			}
		}

		public void ImageLibTree_AfterClick(object sender, TreeViewEventArgs e)
		{
			bool isRootNode = false;
			string publishStatus = string.Empty;
			TreeNode node = e.Node;
			if (node != null)
			{
				string nodeID = ImageLibTree.GetNodeID(node);
				string nodeType = ImageLibTree.GetNodeType(node);
				string left = nodeType;
				if (Operators.CompareString(left, "RT", false) == 0)
				{
					this.txtName.Text = this._EImageLib.Name;
					this.txtDesc.Text = this._EImageLib.Description;
					isRootNode = true;
					this.DCImageWizard.Clear();
				}
				else if (Operators.CompareString(left, "CG", false) == 0)
				{
					EImageTree entity = WebServiceLayer.ImageTreeAccess.GetEntity(nodeID);
					this.txtName.Text = entity.Name;
					this.txtDesc.Text = entity.Description;
					this.DCImageWizard.Clear();
				}
				else if (Operators.CompareString(left, "LF", false) == 0)
				{
					EImageItem entity2 = WebServiceLayer.ImageItemAccess.GetEntity(nodeID);
					this.txtName.Text = entity2.Name;
					this.txtDesc.Text = entity2.Description;
					publishStatus = entity2.IsPublish;
					this.DCImageWizard.EImageItem = entity2;
				}
			}
			bool isAdmImageLib = false;
			this.SetImageLibProperty(isRootNode, isAdmImageLib, publishStatus);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.tcImageLib.SelectedIndex == 0)
			{
				if (this.ImageLibTree != null && this.ImageLibTree.SelectedNode != null)
				{
					TreeNode selectedNode = this.ImageLibTree.SelectedNode;
					string nodeID = ImageLibTree.GetNodeID(selectedNode);
					string nodeType = ImageLibTree.GetNodeType(selectedNode);
					string left = nodeType;
					if (Operators.CompareString(left, "CG", false) == 0)
					{
						EImageTree entity = WebServiceLayer.ImageTreeAccess.GetEntity(nodeID);
						entity.Name = this.txtName.Text.Trim();
						entity.Description = this.txtDesc.Text.Trim();
						int num = Convert.ToInt32(WebServiceLayer.ImageTreeAccess.Update(entity));
						if (num == 1)
						{
							this.SyncNodeName(selectedNode, this.txtName.Text.Trim());
							MessageManager.ShowInformationMessage("修改成功!");
						}
						else
						{
							MessageManager.ShowInformationMessage("修改失败!");
						}
					}
					else if (Operators.CompareString(left, "LF", false) == 0)
					{
						EImageItem entity2 = WebServiceLayer.ImageItemAccess.GetEntity(nodeID);
						entity2.Name = this.txtName.Text.Trim();
						entity2.Description = this.txtDesc.Text.Trim();
						int num2 = Convert.ToInt32(WebServiceLayer.ImageItemAccess.Update(entity2));
						if (num2 == 1)
						{
							this.SyncNodeName(selectedNode, this.txtName.Text.Trim());
							this.SyncWizardNameAndDesc(this.txtName.Text.Trim(), this.txtDesc.Text.Trim());
							MessageManager.ShowInformationMessage("修改成功!");
						}
						else
						{
							MessageManager.ShowInformationMessage("修改失败!");
						}
					}
				}
			}
			else if (this.tcImageLib.SelectedIndex == 1 && this.AdmLibTree != null && this.AdmLibTree.SelectedNode != null)
			{
				TreeNode selectedNode2 = this.AdmLibTree.SelectedNode;
				string nodeID2 = this.AdmLibTree.GetNodeID(selectedNode2);
				if (!string.IsNullOrEmpty(nodeID2))
				{
					EAdmImageItem entity3 = WebServiceLayer.AdmImageItemAccess.GetEntity(nodeID2);
					entity3.Name = this.txtName.Text.Trim();
					entity3.Description = this.txtDesc.Text.Trim();
					int num3 = Convert.ToInt32(WebServiceLayer.AdmImageItemAccess.Update(entity3));
					if (num3 == 1)
					{
						this.SyncNodeName(selectedNode2, this.txtName.Text.Trim());
						this.SyncWizardNameAndDesc(this.txtName.Text.Trim(), this.txtDesc.Text.Trim());
						MessageManager.ShowInformationMessage("修改成功!");
					}
					else
					{
						MessageManager.ShowInformationMessage("修改失败!");
					}
				}
			}
		}

		private void SyncNodeName(TreeNode node, string name)
		{
			node.Text = name;
		}

		private void SyncWizardNameAndDesc(string name, string desc)
		{
			if (this.DCImageWizard != null)
			{
				this.DCImageWizard.SyncNameAndDesc(name, desc);
			}
		}

		private void AddAdmLibItem_Click(object sender, EventArgs e)
		{
			EAdmImageItem eAdmImageItem = new EAdmImageItem();
			eAdmImageItem.Name = "新建图片";
			eAdmImageItem.Description = "";
			eAdmImageItem.EpisodeID = GlobalValues.GetValueByKey("EpisodeID");
			eAdmImageItem.Status = "0";
			eAdmImageItem.IsPublish = "0";
			int num = Convert.ToInt32(WebServiceLayer.AdmImageItemAccess.Create(eAdmImageItem));
			if (num == 0)
			{
				MessageManager.ShowErrorMessage("创建失败!");
			}
			else
			{
				eAdmImageItem.ID = Conversions.ToString(num);
				TreeNode treeNode = new TreeNode(eAdmImageItem.Name, 2, 2);
				treeNode.Tag = string.Format("{0}{1}", "LF", num);
				this.AdmLibTree.Nodes[0].Nodes.Add(treeNode);
				this.AdmLibTree.SelectedNode = treeNode;
				this.txtName.Text = eAdmImageItem.Name;
				this.txtDesc.Text = eAdmImageItem.Description;
				this.DCImageWizard.EAdmImageItem = eAdmImageItem;
				bool isRootNode = false;
				bool isAdmImageLib = true;
				this.SetImageLibProperty(isRootNode, isAdmImageLib, eAdmImageItem.IsPublish);
			}
		}

		private bool IsRealClientMode(bool clientMode, string globalKey)
		{
			if (!clientMode)
			{
				return false;
			}
			string valueByKey = GlobalValues.GetValueByKey(globalKey);
			return valueByKey != null && !valueByKey.Equals(string.Empty);
		}

		private void SetImageLibProperty(bool isRootNode, bool isAdmImageLib, string publishStatus)
		{
			bool flag = true;
			if (isRootNode)
			{
				flag = false;
			}
			else if (this.IsRealClientMode(this._ClientMode, "EpisodeID"))
			{
				flag = isAdmImageLib;
			}
			this.txtName.Enabled = flag;
			this.txtDesc.Enabled = flag;
			this.btnSave.Enabled = flag;
			this.btnResetHotSpot.Visible = false;
			this.btnResetHotSpot.Enabled = false;
			if (string.IsNullOrEmpty(publishStatus))
			{
				return;
			}
			if (Operators.CompareString(SysOptionManager.GetSysOptionValue("ImageLibResetEnable", "N"), "Y", false) != 0)
			{
				return;
			}
			if (flag && Operators.CompareString(publishStatus, "1", false) == 0)
			{
				this.btnResetHotSpot.Visible = true;
				this.btnResetHotSpot.Enabled = true;
			}
		}

		private void btnResetHotSpot_Click(object sender, EventArgs e)
		{
			this.DCImageWizard.ResetHotSpot();
			this.btnResetHotSpot.Enabled = false;
			this.btnSave.Enabled = false;
		}
	}
}
