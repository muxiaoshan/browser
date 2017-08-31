using AdmImageItemData;
using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using dhcc.epr.systemframework;
using ImageItemData;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.figure
{
	public class PCFigure : GridControl, PControlInterface, ICheckValueChanged
	{
		private IContainer components;

		private GridBaseStyle stlHeader;

		private GridBaseStyle stlColHeader;

		private GridBaseStyle stlRowHeader;

		private GridBaseStyle stlStandard;

		private GridBaseStyle stlColFigure;

		private MenuItem miAddRowAhead;

		private MenuItem miAddRowBack;

		private MenuItem miDeleteRow;

		private ContextMenu cmRows;

		private MenuItem miSetFig;

		private MenuItem miDelFig;

		private ContextMenu cmFigure;

		private NIFigure _BindNIFigure;

		private MIFigure _BindMIFigure;

		private string _Code;

		private Label curTip;

		private int initValue;

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

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNIFigure;
			}
			set
			{
				this._BindNIFigure = (NIFigure)value;
				this._Code = this._BindNIFigure.Code;
				this._BindMIFigure = (MIFigure)this._BindNIFigure.BindMMetaItem;
				this.ClearGrid();
				this.set_ColCount(2);
				this.get_Item(0, 1).set_Text("说明");
				this.get_Item(0, 2).set_Text("缩略图");
				this.get_ColStyles().get_Item(2).set_CellType("PictureBox");
				this.set_RowCount(0);
				int arg_96_0 = 0;
				checked
				{
					int num = this._BindNIFigure.SubItems.Count - 1;
					for (int i = arg_96_0; i <= num; i++)
					{
						this.get_Rows().InsertRange(i + 1, 1);
						NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[i];
						this.get_Item(i + 1, 1).set_Text(nIFigureRow.FigureDesc);
						PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(i + 1, 2));
						pictureBoxStyleProperties.SizeMode = PictureBoxSizeMode.StretchImage;
						if (nIFigureRow.FigureData != null && Operators.CompareString(nIFigureRow.FigureData, "", false) != 0)
						{
							pictureBoxStyleProperties.Image = this.StrToImage(nIFigureRow.FigureData);
						}
						else
						{
							string figureID = nIFigureRow.FigureID;
							string figureType = nIFigureRow.FigureType;
							if (!string.IsNullOrEmpty(figureType))
							{
								string left = figureType;
								if (Operators.CompareString(left, "CI", false) == 0)
								{
									EImageItem entity = WebServiceLayer.ImageItemAccess.GetEntity(figureID);
									if (entity != null)
									{
										pictureBoxStyleProperties.Image = AnnotateUtil.BurnImageData(entity.ImageData, nIFigureRow.AnnoData);
									}
								}
								else if (Operators.CompareString(left, "EI", false) == 0)
								{
									EAdmImageItem entity2 = WebServiceLayer.AdmImageItemAccess.GetEntity(figureID);
									if (entity2 != null)
									{
										pictureBoxStyleProperties.Image = AnnotateUtil.BurnImageData(entity2.ImageData, nIFigureRow.AnnoData);
									}
								}
							}
						}
					}
				}
			}
		}

		public PCFigure(IContainer Container) : this()
		{
			Container.Add(this);
		}

		public PCFigure()
		{
			base.MouseDown += new MouseEventHandler(this.PCFigure_MouseDown);
			base.DoubleClick += new EventHandler(this.PCFigure_DoubleClick);
			base.add_CurrentCellChanged(new EventHandler(this.PCFigure_CurrentCellChanged));
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
			ResourceManager resourceManager = new ResourceManager(typeof(PCFigure));
			((ISupportInitialize)this).BeginInit();
			this.set_BorderStyle(BorderStyle.Fixed3D);
			this.set_ColCount(2);
			this.set_DefaultColWidth(100);
			this.set_DefaultRowHeight(100);
			this.set_RowCount(1);
			((ISupportInitialize)this).EndInit();
		}

		private void Init()
		{
			this.stlHeader = new GridBaseStyle();
			this.stlColHeader = new GridBaseStyle();
			this.stlRowHeader = new GridBaseStyle();
			this.stlStandard = new GridBaseStyle();
			this.stlHeader.set_Name("Header");
			this.stlHeader.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Left(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Right(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Top(new GridBorder(1));
			this.stlHeader.get_StyleInfo().set_CellType("Header");
			this.stlHeader.get_StyleInfo().get_Font().set_Bold(false);
			this.stlHeader.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlHeader.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Control));
			this.stlHeader.get_StyleInfo().set_VerticalAlignment(1);
			this.stlColHeader.set_Name("Column Header");
			this.stlColHeader.get_StyleInfo().set_BaseStyle("Header");
			this.stlColHeader.get_StyleInfo().set_HorizontalAlignment(2);
			this.stlRowHeader.set_Name("Row Header");
			this.stlRowHeader.get_StyleInfo().set_BaseStyle("Header");
			this.stlRowHeader.get_StyleInfo().set_HorizontalAlignment(0);
			this.stlRowHeader.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Control));
			this.stlStandard.set_Name("Standard");
			this.stlStandard.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlStandard.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.get_BaseStylesMap().AddRange(new GridBaseStyle[]
			{
				this.stlHeader,
				this.stlColHeader,
				this.stlRowHeader,
				this.stlStandard
			});
			this.get_CellModels().Add("PictureBox", new PictureBoxCellModel(this.get_Model()));
			this.miAddRowAhead = new MenuItem("插入行(行前)");
			this.miAddRowBack = new MenuItem("插入行(行后)");
			this.miDeleteRow = new MenuItem("删除行");
			this.miAddRowAhead.Click += new EventHandler(this.OnAddRowAhead);
			this.miAddRowBack.Click += new EventHandler(this.OnAddRowBack);
			this.miDeleteRow.Click += new EventHandler(this.OnDeleteRow);
			this.cmRows = new ContextMenu();
			this.cmRows.MenuItems.Add(this.miAddRowAhead);
			this.cmRows.MenuItems.Add(this.miAddRowBack);
			this.cmRows.MenuItems.Add(this.miDeleteRow);
			this.miSetFig = new MenuItem("编辑");
			this.miDelFig = new MenuItem("删除");
			this.miSetFig.Click += new EventHandler(this.OnSetFig);
			this.miDelFig.Click += new EventHandler(this.OnDelFig);
			this.cmFigure = new ContextMenu();
			this.cmFigure.MenuItems.Add(this.miSetFig);
			this.curTip = new Label();
			this.curTip.BackColor = SystemColors.Info;
			this.curTip.BorderStyle = BorderStyle.FixedSingle;
		}

		public void OnAddRowAhead(object sender, EventArgs e)
		{
			NIFigureRow value = new NIFigureRow();
			this._BindNIFigure.SubItems.Insert(checked(this.get_CurrentCell().get_RowIndex() - 1), value);
			this.get_Rows().InsertRange(this.get_CurrentCell().get_RowIndex(), 1);
		}

		public void OnAddRowBack(object sender, EventArgs e)
		{
			NIFigureRow value = new NIFigureRow();
			this._BindNIFigure.SubItems.Insert(this.get_CurrentCell().get_RowIndex(), value);
			this.get_Rows().InsertRange(checked(this.get_CurrentCell().get_RowIndex() + 1), 1);
		}

		public void OnDeleteRow(object sender, EventArgs e)
		{
			int rowIndex = this.get_CurrentCell().get_RowIndex();
			int colIndex = this.get_CurrentCell().get_ColIndex();
			checked
			{
				if (this.get_RowCount() == 1)
				{
					this.get_Item(rowIndex, 1).set_Text(null);
					PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(rowIndex, 2));
					if (pictureBoxStyleProperties.HasImage)
					{
						pictureBoxStyleProperties.Image = null;
						pictureBoxStyleProperties.ResetImage();
					}
					NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[this.get_CurrentCell().get_RowIndex() - 1];
					nIFigureRow.FigureDesc = null;
					nIFigureRow.FigureData = null;
					nIFigureRow.AnnoData = null;
					nIFigureRow.FigureType = string.Empty;
					nIFigureRow.FigureID = string.Empty;
				}
				else
				{
					this._BindNIFigure.SubItems.RemoveAt(this.get_CurrentCell().get_RowIndex() - 1);
					this.get_Rows().RemoveRange(rowIndex, rowIndex);
				}
			}
		}

		public void OnDelFig(object sender, EventArgs e)
		{
			PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()));
			if (pictureBoxStyleProperties.HasImage)
			{
				pictureBoxStyleProperties.Image = null;
				pictureBoxStyleProperties.ResetImage();
				NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[checked(this.get_CurrentCell().get_RowIndex() - 1)];
				nIFigureRow.FigureData = null;
				nIFigureRow.AnnoData = null;
				nIFigureRow.FigureType = string.Empty;
				nIFigureRow.FigureID = string.Empty;
			}
		}

		public void OnSetFig(object sender, EventArgs e)
		{
			PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()));
			pictureBoxStyleProperties.SizeMode = PictureBoxSizeMode.StretchImage;
			checked
			{
				NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[this.get_CurrentCell().get_RowIndex() - 1];
				FigureViewerForm figureViewerForm = new FigureViewerForm();
				figureViewerForm.ShowInTaskbar = false;
				figureViewerForm.BindImageLib = this._BindMIFigure.BindImageLib;
				figureViewerForm.ImageLibID = this._BindMIFigure.BindImageLibID;
				figureViewerForm.FigureDesc = nIFigureRow.FigureDesc;
				if (pictureBoxStyleProperties.HasImage)
				{
					figureViewerForm.FigureData = nIFigureRow.FigureData;
					figureViewerForm.FigureType = nIFigureRow.FigureType;
					figureViewerForm.FigureID = nIFigureRow.FigureID;
					figureViewerForm.AnnoData = nIFigureRow.AnnoData;
					figureViewerForm.InitDCPreview();
				}
				figureViewerForm.ShowDialog();
				if (figureViewerForm.HasChange)
				{
					pictureBoxStyleProperties.Image = figureViewerForm.BurnImage;
					this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex() - 1).set_Text(figureViewerForm.FigureDesc);
					nIFigureRow.FigureDesc = figureViewerForm.FigureDesc;
					nIFigureRow.FigureData = figureViewerForm.FigureData;
					nIFigureRow.FigureID = figureViewerForm.FigureID;
					nIFigureRow.FigureType = figureViewerForm.FigureType;
					figureViewerForm.SerializeAnnoData();
					nIFigureRow.AnnoData = figureViewerForm.AnnoData;
				}
			}
		}

		private void PCFigure_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right & this.get_CurrentCell().get_ColIndex() == 0 & this.get_CurrentCell().get_RowIndex() > 0)
			{
				ContextMenu arg_48_0 = this.cmRows;
				Point pos = new Point(e.X, e.Y);
				arg_48_0.Show(this, pos);
			}
			else if (e.Button == MouseButtons.Right & this.get_CurrentCell().get_ColIndex() == 2 & this.get_CurrentCell().get_RowIndex() > 0)
			{
				PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()));
				if (pictureBoxStyleProperties.HasImage)
				{
					this.cmFigure.MenuItems.Add(this.miDelFig);
				}
				else if (this.cmFigure.MenuItems.Contains(this.miDelFig))
				{
					this.cmFigure.MenuItems.Remove(this.miDelFig);
				}
				ContextMenu arg_10E_0 = this.cmFigure;
				Point pos = new Point(e.X, e.Y);
				arg_10E_0.Show(this, pos);
			}
		}

		private void PCFigure_DoubleClick(object sender, EventArgs e)
		{
			int colIndex = this.get_CurrentCell().get_ColIndex();
			if (colIndex == 2)
			{
				this.OnSetFig(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void PCFigure_CurrentCellChanged(object sender, EventArgs e)
		{
			int rowIndex = this.get_CurrentCell().get_RowIndex();
			int colIndex = this.get_CurrentCell().get_ColIndex();
			this.get_CurrentCell().EndEdit();
			NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[checked(rowIndex - 1)];
			if (colIndex == 1)
			{
				nIFigureRow.FigureDesc = this.get_Item(rowIndex, colIndex).get_Text();
			}
			else if (colIndex == 2)
			{
				PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(rowIndex, colIndex));
				if (pictureBoxStyleProperties.HasImage)
				{
					nIFigureRow.FigureData = this.ImageToStr(pictureBoxStyleProperties.Image);
				}
			}
			this.get_CurrentCell().BeginEdit();
		}

		private void ClearGrid()
		{
			GridStyleInfo gridStyleInfo = new GridStyleInfo();
			gridStyleInfo.set_Text("");
			this.set_ReadOnly(false);
			if (this.get_RowCount() > 0)
			{
				this.ChangeCells(GridRangeInfo.Cells(0, 1, this.get_RowCount(), this.get_ColCount()), gridStyleInfo);
			}
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
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.set_ColCount(int.Parse(reader.Value));
				reader.Read();
			}
			reader.Read();
			int num = 0;
			checked
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "ColWidth", false) == 0)
					{
						reader.Read();
						if (num <= this.get_ColCount())
						{
							this.get_ColWidths().set_Item(num, int.Parse(reader.Value));
						}
						reader.Read();
						num++;
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "ColWidths", false) == 0)
					{
						break;
					}
				}
				reader.Read();
				if (Operators.CompareString(reader.Name, "HeaderHeight", false) == 0 & !reader.IsEmptyElement)
				{
					reader.Read();
					this.get_RowHeights().set_Item(0, int.Parse(reader.Value));
					reader.Read();
				}
			}
		}

		private void AddFigure()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "所有图片文件|*.bmp;*.jpeg;*.jpg;*.jpe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				if (Operators.CompareString(fileName, "", false) == 0)
				{
					MessageManager.ShowWarningMessage("未输入图像文件，请重新选择！");
					return;
				}
				PictureBoxStyleProperties pictureBoxStyleProperties = new PictureBoxStyleProperties(this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()));
				pictureBoxStyleProperties.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBoxStyleProperties.Image = Image.FromFile(fileName);
				NIFigureRow nIFigureRow = (NIFigureRow)this._BindNIFigure.SubItems[checked(this.get_CurrentCell().get_RowIndex() - 1)];
				if (nIFigureRow != null)
				{
					nIFigureRow.FigureData = this.ImageToStr(pictureBoxStyleProperties.Image);
				}
			}
		}

		private Image StrToImage(string Str)
		{
			if (Str != null && Operators.CompareString(Str, "", false) != 0)
			{
				MemoryStream stream = (MemoryStream)PCFigure.StrToImageStream(Str);
				return Image.FromStream(stream);
			}
			return null;
		}

		private string ImageToStr(Image image)
		{
			MemoryStream memoryStream = new MemoryStream();
			image.Save(memoryStream, image.RawFormat);
			return PCFigure.ImageStreamToStr(memoryStream);
		}

		public static Stream StrToImageStream(string str)
		{
			byte[] buffer = Convert.FromBase64String(str);
			return new MemoryStream(buffer);
		}

		public static string ImageStreamToStr(MemoryStream objStream)
		{
			byte[] inArray = objStream.ToArray();
			return Convert.ToBase64String(inArray);
		}

		public void IsValueChanged(ref bool isChanged)
		{
			if (isChanged)
			{
				return;
			}
			isChanged = (this.initValue != NIImageAnnotate.GetXmlWithoutWangTime(this._BindNIFigure.XMLString).GetHashCode());
		}

		public void SetInitValue()
		{
			this.initValue = NIImageAnnotate.GetXmlWithoutWangTime(this._BindNIFigure.XMLString).GetHashCode();
		}
	}
}
