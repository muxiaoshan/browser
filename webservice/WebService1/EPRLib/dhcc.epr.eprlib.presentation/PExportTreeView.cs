using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.design.glossarydesign;
using dhcc.epr.eprlib.design.printlink;
using InterfaceTemplateData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation
{
	public class PExportTreeView : UserControl
	{
		public delegate void TreeViewDoubleClickedHandler();

		public delegate void TreeViewDoubleClickedEventHandler();

		private IContainer components;

		[AccessedThroughProperty("radioInterface")]
		private RadioButton _radioInterface;

		[AccessedThroughProperty("radioGlossary")]
		private RadioButton _radioGlossary;

		[AccessedThroughProperty("treeViewIcons")]
		private ImageList _treeViewIcons;

		[AccessedThroughProperty("cmTemplate")]
		private ContextMenu _cmTemplate;

		[AccessedThroughProperty("miExportTemplateUnits")]
		private MenuItem _miExportTemplateUnits;

		[AccessedThroughProperty("tvTemplates")]
		private TemplateTree _tvTemplates;

		[AccessedThroughProperty("tvUnits")]
		private PrintUnitTree _tvUnits;

		[AccessedThroughProperty("tvGlossary")]
		private GlossaryTree _tvGlossary;

		private TreeNode m_MetaNode;

		private string m_CategoryInfo;

		private string m_NodeTag;

		private PExportTreeView.TreeViewDoubleClickedEventHandler TreeViewDoubleClickedEvent;

		public event PExportTreeView.TreeViewDoubleClickedEventHandler TreeViewDoubleClicked
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.TreeViewDoubleClickedEvent = (PExportTreeView.TreeViewDoubleClickedEventHandler)Delegate.Combine(this.TreeViewDoubleClickedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.TreeViewDoubleClickedEvent = (PExportTreeView.TreeViewDoubleClickedEventHandler)Delegate.Remove(this.TreeViewDoubleClickedEvent, value);
			}
		}

		internal virtual RadioButton radioInterface
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radioInterface;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.radioInterface_CheckedChanged);
				if (this._radioInterface != null)
				{
					this._radioInterface.CheckedChanged -= value2;
				}
				this._radioInterface = value;
				if (this._radioInterface != null)
				{
					this._radioInterface.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton radioGlossary
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radioGlossary;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radioGlossary = value;
			}
		}

		internal virtual ImageList treeViewIcons
		{
			[DebuggerNonUserCode]
			get
			{
				return this._treeViewIcons;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._treeViewIcons = value;
			}
		}

		internal virtual ContextMenu cmTemplate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmTemplate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmTemplate = value;
			}
		}

		internal virtual MenuItem miExportTemplateUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._miExportTemplateUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.miExportTemplateUnits_Click);
				if (this._miExportTemplateUnits != null)
				{
					this._miExportTemplateUnits.Click -= value2;
				}
				this._miExportTemplateUnits = value;
				if (this._miExportTemplateUnits != null)
				{
					this._miExportTemplateUnits.Click += value2;
				}
			}
		}

		public virtual TemplateTree tvTemplates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvTemplates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.tvTemplates_AfterSelect);
				MouseEventHandler value3 = new MouseEventHandler(this.tvTemplates_MouseUp);
				if (this._tvTemplates != null)
				{
					this._tvTemplates.AfterSelect -= value2;
					this._tvTemplates.MouseUp -= value3;
				}
				this._tvTemplates = value;
				if (this._tvTemplates != null)
				{
					this._tvTemplates.AfterSelect += value2;
					this._tvTemplates.MouseUp += value3;
				}
			}
		}

		public virtual PrintUnitTree tvUnits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvUnits;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tvUnits_DoubleClick);
				if (this._tvUnits != null)
				{
					this._tvUnits.DoubleClick -= value2;
				}
				this._tvUnits = value;
				if (this._tvUnits != null)
				{
					this._tvUnits.DoubleClick += value2;
				}
			}
		}

		public virtual GlossaryTree tvGlossary
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tvGlossary;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tvGlossary_DoubleClick);
				if (this._tvGlossary != null)
				{
					this._tvGlossary.DoubleClick -= value2;
				}
				this._tvGlossary = value;
				if (this._tvGlossary != null)
				{
					this._tvGlossary.DoubleClick += value2;
				}
			}
		}

		public string NodeTag
		{
			get
			{
				return this.m_NodeTag;
			}
		}

		public PExportTreeView()
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
			ResourceManager resourceManager = new ResourceManager(typeof(PExportTreeView));
			this.radioInterface = new RadioButton();
			this.radioGlossary = new RadioButton();
			this.treeViewIcons = new ImageList(this.components);
			this.cmTemplate = new ContextMenu();
			this.miExportTemplateUnits = new MenuItem();
			this.SuspendLayout();
			Control arg_6F_0 = this.radioInterface;
			Point location = new Point(56, 0);
			arg_6F_0.Location = location;
			this.radioInterface.Name = "radioInterface";
			this.radioInterface.TabIndex = 0;
			this.radioInterface.Text = "界面模板";
			Control arg_B4_0 = this.radioGlossary;
			location = new Point(152, 0);
			arg_B4_0.Location = location;
			this.radioGlossary.Name = "radioGlossary";
			this.radioGlossary.TabIndex = 1;
			this.radioGlossary.Text = "术语集";
			ImageList arg_F7_0 = this.treeViewIcons;
			Size size = new Size(16, 16);
			arg_F7_0.ImageSize = size;
			this.treeViewIcons.ImageStream = (ImageListStreamer)resourceManager.GetObject("treeViewIcons.ImageStream");
			this.treeViewIcons.TransparentColor = Color.Transparent;
			this.cmTemplate.MenuItems.AddRange(new MenuItem[]
			{
				this.miExportTemplateUnits
			});
			this.miExportTemplateUnits.Index = 0;
			this.miExportTemplateUnits.Text = "导出所有单元数据...";
			this.Controls.Add(this.radioGlossary);
			this.Controls.Add(this.radioInterface);
			this.Name = "PExportTreeView";
			size = new Size(252, 520);
			this.Size = size;
			this.ResumeLayout(false);
		}

		private void Init()
		{
			this.tvTemplates = new TemplateTree(TemplateTree.ShowLevel.Template, true);
			this.Controls.Add(this.tvTemplates);
			Control arg_2F_0 = this.tvTemplates;
			Point location = new Point(0, 25);
			arg_2F_0.Location = location;
			Control arg_4C_0 = this.tvTemplates;
			Size size = new Size(252, 245);
			arg_4C_0.Size = size;
			this.tvTemplates.Name = "tvTemplates";
			this.tvTemplates.ShowRootLines = true;
			this.tvTemplates.Init();
			this.tvUnits = new PrintUnitTree();
			this.Controls.Add(this.tvUnits);
			Control arg_A8_0 = this.tvUnits;
			location = new Point(0, 270);
			arg_A8_0.Location = location;
			Control arg_C5_0 = this.tvUnits;
			size = new Size(252, 245);
			arg_C5_0.Size = size;
			this.tvUnits.Name = "tvUnits";
			this.tvUnits.ShowRootLines = false;
			this.tvUnits.AllowDrop = true;
			this.tvUnits.ITID = null;
			this.tvUnits.ITName = null;
			this.tvUnits.ITVersion = null;
			this.tvGlossary = new GlossaryTree();
			this.Controls.Add(this.tvGlossary);
			Control arg_143_0 = this.tvGlossary;
			location = new Point(0, 25);
			arg_143_0.Location = location;
			Control arg_160_0 = this.tvGlossary;
			size = new Size(252, 495);
			arg_160_0.Size = size;
			this.tvGlossary.ItemHeight = 16;
			this.tvGlossary.Indent = 16;
			this.tvGlossary.ImageList = this.treeViewIcons;
			this.tvGlossary.Name = "tvGlossaryUnits";
			this.tvGlossary.ShowRootLines = true;
			this.tvGlossary.AllowDrop = true;
			this.tvGlossary.Visible = false;
			this.radioInterface.Checked = true;
		}

		private void radioInterface_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioInterface.Checked)
			{
				this.tvTemplates.Visible = true;
				this.tvUnits.Visible = true;
				this.tvGlossary.Visible = false;
			}
			else
			{
				this.tvTemplates.Visible = false;
				this.tvUnits.Visible = false;
				this.tvGlossary.Visible = true;
			}
		}

		private void tvTemplates_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.tvUnits.Nodes.Clear();
			if (Operators.CompareString(this.tvTemplates.GetNodeType(this.tvTemplates.SelectedNode).ToString(), "LF", false) == 0)
			{
				this.tvUnits.ITName = this.tvTemplates.SelectedNode.Text;
				this.tvUnits.ITID = this.tvTemplates.GetNodeId(this.tvTemplates.SelectedNode);
				try
				{
					ETemplateVersion metadataByTemplateID = WebServiceLayer.InterfaceTemplateAccess.GetMetadataByTemplateID(this.tvUnits.ITID);
					if (Operators.CompareString(metadataByTemplateID.MetaData, null, false) != 0 && Operators.CompareString(metadataByTemplateID.MetaData, "", false) != 0)
					{
						this.tvUnits.ITVersion = metadataByTemplateID.VersionNumber.ToString();
						this.tvUnits.StrMetaData = metadataByTemplateID.MetaData;
					}
				}
				catch (Exception expr_DE)
				{
					ProjectData.SetProjectError(expr_DE);
					Exception ex = expr_DE;
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
				}
				this.m_CategoryInfo = this.tvTemplates.GetCategoryInfo(this.tvTemplates.SelectedNode);
				if (this.m_CategoryInfo.StartsWith("界面模板"))
				{
					this.m_CategoryInfo = this.m_CategoryInfo.Substring(5);
				}
			}
			else
			{
				this.tvUnits.Nodes.Clear();
			}
		}

		private void tvUnits_DoubleClick(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.tvUnits.SelectedNode.Tag.ToString(), "", false) != 0)
			{
				this.m_NodeTag = this.tvUnits.SelectedNode.Tag.ToString();
				if (this.m_CategoryInfo != null)
				{
					this.m_NodeTag = this.m_CategoryInfo + "." + this.m_NodeTag;
				}
				PExportTreeView.TreeViewDoubleClickedEventHandler treeViewDoubleClickedEvent = this.TreeViewDoubleClickedEvent;
				if (treeViewDoubleClickedEvent != null)
				{
					treeViewDoubleClickedEvent();
				}
			}
			else
			{
				this.m_NodeTag = null;
			}
		}

		private void tvGlossary_DoubleClick(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.tvGlossary.GetNodeType(this.tvGlossary.SelectedNode), "RS", false) == 0)
			{
				this.m_NodeTag = this.tvGlossary.SelectedNode.Tag.ToString();
				this.m_NodeTag = this.m_NodeTag.Substring(3);
				PExportTreeView.TreeViewDoubleClickedEventHandler treeViewDoubleClickedEvent = this.TreeViewDoubleClickedEvent;
				if (treeViewDoubleClickedEvent != null)
				{
					treeViewDoubleClickedEvent();
				}
			}
			else
			{
				this.m_NodeTag = null;
			}
		}

		private void tvTemplates_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				TreeNode treeNode = new TreeNode();
				treeNode = this.tvTemplates.GetNodeAt(e.X, e.Y);
				if (!Information.IsNothing(treeNode))
				{
					this.tvTemplates.SelectedNode = treeNode;
					ContextMenu arg_5F_0 = this.cmTemplate;
					Control arg_5F_1 = this.tvTemplates;
					Point pos = new Point(e.X, e.Y);
					arg_5F_0.Show(arg_5F_1, pos);
				}
			}
		}

		private void miExportTemplateUnits_Click(object sender, EventArgs e)
		{
			string argContent = this.ExportTemplateUnits(this.tvTemplates.SelectedNode);
			this.GenerateTxtFile(".\\" + this.tvTemplates.SelectedNode.Text + ".txt", argContent);
		}

		private string ExportTemplateUnits(TreeNode curNode)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Operators.CompareString(this.tvTemplates.GetNodeType(curNode).ToString(), "LF", false) != 0)
			{
				if (curNode.FirstNode != null && (curNode.FirstNode.Text == null | Operators.CompareString(curNode.FirstNode.Text, "", false) == 0))
				{
					string nodeType = this.tvTemplates.GetNodeType(curNode);
					if (Operators.CompareString(nodeType, "CG", false) == 0)
					{
						this.tvTemplates.initResourceNodes(curNode);
					}
				}
				try
				{
					IEnumerator enumerator = curNode.Nodes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						TreeNode curNode2 = (TreeNode)enumerator.Current;
						stringBuilder.Append(this.ExportTemplateUnits(curNode2));
					}
					goto IL_208;
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
			this.tvUnits.Nodes.Clear();
			this.tvUnits.ITName = curNode.Text;
			this.tvUnits.ITID = this.tvTemplates.GetNodeId(curNode);
			try
			{
				ETemplateVersion metadataByTemplateID = WebServiceLayer.InterfaceTemplateAccess.GetMetadataByTemplateID(this.tvUnits.ITID);
				if (Operators.CompareString(metadataByTemplateID.MetaData, null, false) != 0 && Operators.CompareString(metadataByTemplateID.MetaData, "", false) != 0)
				{
					this.tvUnits.ITVersion = metadataByTemplateID.VersionNumber.ToString();
					this.tvUnits.StrMetaData = metadataByTemplateID.MetaData;
				}
			}
			catch (Exception expr_17A)
			{
				ProjectData.SetProjectError(expr_17A);
				Exception ex = expr_17A;
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
			try
			{
				IEnumerator enumerator2 = this.tvUnits.Nodes.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator2.Current;
					stringBuilder.Append(this.GetUnitsInfo(this.tvTemplates.GetCategoryInfo(curNode), curNode.Text, this.tvTemplates.GetNodeId(curNode), ref treeNode));
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
			IL_208:
			return stringBuilder.ToString();
		}

		private void GetAllUnitsInfo(string argCategoryinfo, string argTemplateName, string argTemplateID)
		{
			string text = "";
			try
			{
				try
				{
					IEnumerator enumerator = this.tvUnits.Nodes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator.Current;
						text += this.GetUnitsInfo(argCategoryinfo, argTemplateName, argTemplateID, ref treeNode);
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
			catch (Exception expr_57)
			{
				ProjectData.SetProjectError(expr_57);
				ProjectData.ClearProjectError();
				return;
			}
			this.GenerateTxtFile(string.Concat(new string[]
			{
				".\\",
				argCategoryinfo,
				"---",
				argTemplateName,
				".txt"
			}), text);
		}

		public string GetUnitsInfo(string argCategoryInfo, string argTemplateName, string argTemplateID, ref TreeNode argNode)
		{
			checked
			{
				string result;
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						IEnumerator enumerator = argNode.Nodes.GetEnumerator();
						while (enumerator.MoveNext())
						{
							TreeNode treeNode = (TreeNode)enumerator.Current;
							string text = Conversions.ToString(treeNode.Tag);
							if (text != null && !text.Equals(string.Empty))
							{
								int num = text.IndexOf("#");
								string text2 = text.Substring(0, num);
								int num2 = text2.IndexOf(".");
								string text3 = text2.Substring(num2 + 1).Replace("：", "").Replace(":", "");
								string text4 = text.Substring(num, text.Length - num);
								if (text4.IndexOf("SegmentSimple") != -1)
								{
									int num3 = text4.IndexOf("TCODE:");
									string text5 = text4.Substring(num3 + 6, 5);
									int num4 = text4.IndexOf("SCODE:");
									string text6 = text4.Substring(num4 + 6, 5);
									int num5 = text3.IndexOf(".");
									text3 = string.Format("{0}.{1}.{2}.{3}", new object[]
									{
										text3.Substring(0, num5),
										text5,
										text3.Substring(num5 + 1),
										text6
									});
								}
								else if (text4.IndexOf("Segment") != -1)
								{
									int num6 = text4.IndexOf("GCODE:");
									string arg = text4.Substring(num6 + 6, 5);
									text3 = string.Format("{0}.{1}", text3, arg);
								}
								else if (text4.IndexOf("TextDesc") != -1)
								{
									int num7 = text4.IndexOf("ECODE:");
									string arg2 = text4.Substring(num7 + 6, 5);
									text3 = string.Format("{0}.{1}", text3, arg2);
								}
								else
								{
									int num8 = text4.IndexOf("SCODE:");
									string arg3 = text4.Substring(num8 + 6, 5);
									text3 = string.Format("{0}.{1}", text3, arg3);
								}
								stringBuilder.AppendFormat("{0}^{1}^{2}^{3}^{4}\r\n", new object[]
								{
									argCategoryInfo,
									argTemplateName,
									argTemplateID,
									text3,
									text4
								});
								if (text4.IndexOf("TextDesc") == -1)
								{
									stringBuilder.Append(this.GetUnitsInfo(argCategoryInfo, argTemplateName, argTemplateID, ref treeNode));
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
					result = stringBuilder.ToString();
				}
				catch (Exception expr_26E)
				{
					ProjectData.SetProjectError(expr_26E);
					Exception ex = expr_26E;
					Interaction.MsgBox("获取单元信息错误。\r\n\r\n" + ex.Message, MsgBoxStyle.OkOnly, null);
					throw ex;
				}
				return result;
			}
		}

		private void GenerateTxtFile(string argFilePath, string argContent)
		{
			if (File.Exists(argFilePath) && Interaction.MsgBox("文件" + argFilePath + "已经存在，是否覆盖？", MsgBoxStyle.YesNo, "") == MsgBoxResult.No)
			{
				return;
			}
			try
			{
				StreamWriter streamWriter = File.CreateText(argFilePath);
				streamWriter.Write(argContent);
				streamWriter.Flush();
				streamWriter.Close();
			}
			catch (Exception expr_43)
			{
				ProjectData.SetProjectError(expr_43);
				Exception ex = expr_43;
				Interaction.MsgBox("生成导出文件错误。\r\n\r\n" + ex.Message, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
				return;
			}
			try
			{
				if (Interaction.MsgBox("导出文件" + argFilePath + "已经保存在本程序所在目录中，是否打开？", MsgBoxStyle.OkCancel, "提示") == MsgBoxResult.Ok)
				{
					Interaction.Shell(Environment.SystemDirectory + "\\notepad.exe " + argFilePath, AppWinStyle.NormalFocus, false, -1);
				}
			}
			catch (Exception expr_A2)
			{
				ProjectData.SetProjectError(expr_A2);
				Exception ex2 = expr_A2;
				Interaction.MsgBox("打开导出文件错误，请手工查看导出文件。\r\n\r\n" + ex2.Message, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}
	}
}
