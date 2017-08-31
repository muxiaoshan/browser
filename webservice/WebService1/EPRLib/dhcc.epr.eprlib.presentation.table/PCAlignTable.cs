using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using dhcc.epr.eprlib.presentation.dictionary;
using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.table
{
	public class PCAlignTable : GridControl
	{
		public delegate void ATDragOverEventHandler(object sender, DragEventArgs e);

		public delegate void ATDragDropEventHandler(object sender, DragEventArgs e);

		private IContainer components;

		public GridBaseStyle stlHeader;

		public GridBaseStyle stlColHeader;

		public GridBaseStyle stlRowHeader;

		public GridBaseStyle stlStandard;

		public GridBaseStyle stlString;

		public GridBaseStyle stlNumber;

		public GridBaseStyle stlMonoChoice;

		public GridBaseStyle stlMultiChoice;

		public GridBaseStyle stlDictionary;

		public GridBaseStyle stlPosition;

		public GridBaseStyle stlDateTime;

		public GridBaseStyle stlQuantity;

		private MenuItem miAddRow;

		private MenuItem miDeleteRow;

		private MenuItem miAddColumn;

		private MenuItem miDeleteColumn;

		private MenuItem miCoverCells;

		private MenuItem miFormate;

		private MenuItem miShowHeader;

		private MenuItem miClear;

		private ContextMenu cmRows;

		private Label curTip;

		private PCAlignTable.ATDragOverEventHandler ATDragOverEvent;

		private PCAlignTable.ATDragDropEventHandler ATDragDropEvent;

		private bool _IsDesign;

		private NInstanceData _InstanceData;

		public event PCAlignTable.ATDragOverEventHandler ATDragOver
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ATDragOverEvent = (PCAlignTable.ATDragOverEventHandler)Delegate.Combine(this.ATDragOverEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ATDragOverEvent = (PCAlignTable.ATDragOverEventHandler)Delegate.Remove(this.ATDragOverEvent, value);
			}
		}

		public event PCAlignTable.ATDragDropEventHandler ATDragDrop
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ATDragDropEvent = (PCAlignTable.ATDragDropEventHandler)Delegate.Combine(this.ATDragDropEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ATDragDropEvent = (PCAlignTable.ATDragDropEventHandler)Delegate.Remove(this.ATDragDropEvent, value);
			}
		}

		public bool IsDesign
		{
			get
			{
				return this._IsDesign;
			}
			set
			{
				this._IsDesign = value;
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
			}
		}

		public PCAlignTable()
		{
			base.add_CurrentCellChanged(new EventHandler(this.PCTable_CurrentCellChanged));
			base.add_CellButtonClicked(new GridCellButtonClickedEventHandler(this.PCAlignTable_CellButtonClicked));
			base.MouseDown += new MouseEventHandler(this.PCAlignTable_MouseDown);
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
			ResourceManager resourceManager = new ResourceManager(typeof(PCAlignTable));
			GridStyleInfo gridStyleInfo = new GridStyleInfo();
			((ISupportInitialize)this).BeginInit();
			this.set_BorderStyle(BorderStyle.Fixed3D);
			this.set_DefaultColWidth(100);
			this.set_DefaultGridBorderStyle(6);
			this.set_DefaultRowHeight(20);
			this.set_Font(new Font("宋体", 9f));
			gridStyleInfo.get_Font().set_Facename("宋体");
			this.set_TableStyle(gridStyleInfo);
			((ISupportInitialize)this).EndInit();
		}

		private void Init()
		{
			this.get_CellModels().Add("DictionaryButton", new DictionaryCellModel(this.get_Model()));
			this.get_CellModels().Add("MultiChoiceButton", new MultiChoiceCellModel(this.get_Model()));
			this.get_CellModels().Add("QuantityButton", new QuantityCellModel(this.get_Model()));
			this.get_CellModels().Add("DateTimeButton", new DateTimeCellModel(this.get_Model()));
			this.get_CellModels().Add("PositionButton", new PositionCellModel(this.get_Model()));
			this.stlHeader = new GridBaseStyle();
			this.stlColHeader = new GridBaseStyle();
			this.stlRowHeader = new GridBaseStyle();
			this.stlStandard = new GridBaseStyle();
			this.stlString = new GridBaseStyle();
			this.stlNumber = new GridBaseStyle();
			this.stlMonoChoice = new GridBaseStyle();
			this.stlMultiChoice = new GridBaseStyle();
			this.stlDictionary = new GridBaseStyle();
			this.stlPosition = new GridBaseStyle();
			this.stlDateTime = new GridBaseStyle();
			this.stlQuantity = new GridBaseStyle();
			this.stlHeader.set_Name("Header");
			this.stlHeader.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Left(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Right(new GridBorder(1));
			this.stlHeader.get_StyleInfo().get_Borders().set_Top(new GridBorder(1));
			this.stlHeader.get_StyleInfo().set_CellType("Header");
			this.stlHeader.get_StyleInfo().set_BackColor(SystemColors.Control);
			this.stlHeader.get_StyleInfo().get_Font().set_Bold(false);
			this.stlHeader.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlHeader.get_StyleInfo().set_VerticalAlignment(1);
			this.stlColHeader.set_Name("Column Header");
			this.stlColHeader.get_StyleInfo().set_BaseStyle("Header");
			this.stlColHeader.get_StyleInfo().set_HorizontalAlignment(2);
			this.stlRowHeader.set_Name("Row Header");
			this.stlRowHeader.get_StyleInfo().set_BaseStyle("Header");
			this.stlRowHeader.get_StyleInfo().set_HorizontalAlignment(0);
			this.stlStandard.set_Name("Standard");
			this.stlStandard.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlStandard.get_StyleInfo().set_CellType("Header");
			this.stlStandard.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(1));
			this.stlStandard.get_StyleInfo().get_Borders().set_Left(new GridBorder(1));
			this.stlStandard.get_StyleInfo().get_Borders().set_Right(new GridBorder(1));
			this.stlStandard.get_StyleInfo().get_Borders().set_Top(new GridBorder(1));
			this.stlStandard.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Control));
			this.stlString.set_Name("String");
			this.stlString.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlString.get_StyleInfo().set_CellType("TextBox");
			this.stlString.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlString.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlString.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlString.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlString.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlNumber.set_Name("Number");
			this.stlNumber.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlNumber.get_StyleInfo().set_CellType("TextBox");
			this.stlNumber.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlNumber.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlNumber.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlNumber.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlNumber.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlMonoChoice.set_Name("MonoChoice");
			this.stlMonoChoice.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlMonoChoice.get_StyleInfo().set_CellType("ComboBox");
			this.stlMonoChoice.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlMonoChoice.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlMonoChoice.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlMonoChoice.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlMonoChoice.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlMultiChoice.set_Name("MultiChoice");
			this.stlMultiChoice.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlMultiChoice.get_StyleInfo().set_CellType("MultiChoiceButton");
			this.stlMultiChoice.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlMultiChoice.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlMultiChoice.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlMultiChoice.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlMultiChoice.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlDictionary.set_Name("Dictionary");
			this.stlDictionary.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlDictionary.get_StyleInfo().set_CellType("DictionaryButton");
			this.stlDictionary.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlDictionary.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlDictionary.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlDictionary.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlDictionary.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlDateTime.set_Name("DateTime");
			this.stlDateTime.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlDateTime.get_StyleInfo().set_CellType("DateTimeButton");
			this.stlDateTime.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlDateTime.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlDateTime.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlDateTime.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlDateTime.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlPosition.set_Name("Position");
			this.stlPosition.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlPosition.get_StyleInfo().set_CellType("PositionButton");
			this.stlPosition.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlPosition.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlPosition.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlPosition.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlPosition.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.stlQuantity.set_Name("Quantity");
			this.stlQuantity.get_StyleInfo().get_Font().set_Facename("宋体");
			this.stlQuantity.get_StyleInfo().set_CellType("QuantityButton");
			this.stlQuantity.get_StyleInfo().get_Borders().set_Bottom(new GridBorder(7));
			this.stlQuantity.get_StyleInfo().get_Borders().set_Left(new GridBorder(7));
			this.stlQuantity.get_StyleInfo().get_Borders().set_Right(new GridBorder(7));
			this.stlQuantity.get_StyleInfo().get_Borders().set_Top(new GridBorder(7));
			this.stlQuantity.get_StyleInfo().set_Interior(new BrushInfo(SystemColors.Window));
			this.get_BaseStylesMap().AddRange(new GridBaseStyle[]
			{
				this.stlHeader,
				this.stlColHeader,
				this.stlRowHeader,
				this.stlStandard,
				this.stlString,
				this.stlNumber,
				this.stlMonoChoice,
				this.stlMultiChoice,
				this.stlDateTime,
				this.stlDictionary,
				this.stlPosition,
				this.stlQuantity
			});
			this.set_NumberedColHeaders(false);
			this.set_NumberedRowHeaders(false);
			this.set_RowCount(5);
			this.set_ColCount(5);
			this.set_VScrollBehavior(0);
			this.set_HScrollBehavior(0);
			this.miAddRow = new MenuItem("添加行");
			this.miDeleteRow = new MenuItem("删除行");
			this.miAddColumn = new MenuItem("添加列");
			this.miDeleteColumn = new MenuItem("删除列");
			this.miClear = new MenuItem("取消绑定");
			this.miFormate = new MenuItem("设置格式");
			this.miCoverCells = new MenuItem("合并单元格");
			this.miShowHeader = new MenuItem("显示表头");
			this.cmRows = new ContextMenu();
			this.miAddRow.Click += new EventHandler(this.OnAddRow);
			this.miDeleteRow.Click += new EventHandler(this.OnDeleteRow);
			this.miAddColumn.Click += new EventHandler(this.OnAddColumn);
			this.miDeleteColumn.Click += new EventHandler(this.OnDeleteColumn);
			this.miCoverCells.Click += new EventHandler(this.OnCoverCells);
			this.miShowHeader.Click += new EventHandler(this.OnShowHeader);
			this.miFormate.Click += new EventHandler(this.OnFormate);
			this.miClear.Click += new EventHandler(this.OnClear);
			this.cmRows.MenuItems.Add(this.miAddRow);
			this.cmRows.MenuItems.Add(this.miDeleteRow);
			this.cmRows.MenuItems.Add(this.miAddColumn);
			this.cmRows.MenuItems.Add(this.miDeleteColumn);
			this.cmRows.MenuItems.Add(this.miClear);
			this.cmRows.MenuItems.Add(this.miFormate);
			this.cmRows.MenuItems.Add(this.miCoverCells);
			this.cmRows.MenuItems.Add(this.miShowHeader);
			this.set_SelectCellsMouseButtonsMask(MouseButtons.Left);
			this.set_AllowSelection(12);
			this.curTip = new Label();
			this.curTip.BackColor = SystemColors.Info;
			this.curTip.BorderStyle = BorderStyle.FixedSingle;
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

		private void PCAlignTable_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
		{
			int colIndex = e.get_ColIndex();
			int rowIndex = e.get_RowIndex();
			string code = Conversions.ToString(this.get_Item(rowIndex, colIndex).get_Tag());
			NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(code);
			MMetaItem bindMMetaItem = nInstanceItem.BindMMetaItem;
			checked
			{
				if (bindMMetaItem is MIDictionary)
				{
					Point mousePosition = Control.MousePosition;
					MIDictionary mIDictionary = (MIDictionary)bindMMetaItem;
					NISimple nISimple = (NISimple)nInstanceItem;
					DicContent dicContent;
					if (Operators.CompareString(mIDictionary.DictionaryType, "STDDIC", false) == 0)
					{
						IDictionary dic = DicFactory.Instance.getDic("StdDictionary");
						dicContent = dic.GetDicContent(mIDictionary, mousePosition, nISimple, "", "");
					}
					else
					{
						IDictionary dic = DicFactory.Instance.getDic(mIDictionary.CustDicClassName);
						dicContent = dic.GetDicContent(mIDictionary, mousePosition, nISimple, "", "");
					}
					if (dicContent != null)
					{
						nISimple.ValueCode = dicContent.Code;
						nISimple.Value = dicContent.Description;
					}
					this.get_Item(rowIndex, colIndex).set_Text(nISimple.Value);
				}
				else if (bindMMetaItem is MIPosition)
				{
					Point mousePosition2 = Control.MousePosition;
					MIPosition bindMIPosition = (MIPosition)bindMMetaItem;
					NISimple nISimple2 = (NISimple)nInstanceItem;
					SelectPosForm selectPosForm = new SelectPosForm();
					selectPosForm.BindMIPosition = bindMIPosition;
					selectPosForm.BindNIPosition = nISimple2;
					if (selectPosForm.ShowDialog() == DialogResult.OK)
					{
						nISimple2.ValueCode = selectPosForm.PosValueCode;
						nISimple2.Value = selectPosForm.PosValue;
					}
					this.get_Item(rowIndex, colIndex).set_Text(nISimple2.Value);
				}
				else if (bindMMetaItem is MIMultiChoice)
				{
					Point mousePosition3 = Control.MousePosition;
					MIMultiChoice mIMultiChoice = (MIMultiChoice)bindMMetaItem;
					NISimple nISimple3 = (NISimple)nInstanceItem;
					MultiChoiceForm multiChoiceForm = new MultiChoiceForm((MIMultiChoice)nISimple3.BindMMetaItem, nISimple3.Value);
					multiChoiceForm.SetFormPosition(mousePosition3);
					multiChoiceForm.TopMost = true;
					if (multiChoiceForm.ShowDialog() == DialogResult.OK)
					{
						nISimple3.Value = multiChoiceForm.CheckString;
						nISimple3.ValueCode = multiChoiceForm.CheckStatus;
						this.get_Item(rowIndex, colIndex).set_Text(nISimple3.Value);
					}
				}
				else if (bindMMetaItem is MIDateTime)
				{
					Point mousePosition4 = Control.MousePosition;
					MIDateTime mIDateTime = (MIDateTime)bindMMetaItem;
					NISimple nISimple4 = (NISimple)nInstanceItem;
					DateTimeForm dateTimeForm = new DateTimeForm(nISimple4);
					mousePosition4.Y += 18;
					Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
					if (mousePosition4.X + dateTimeForm.Height > workingArea.Width)
					{
						mousePosition4.X = workingArea.Width - dateTimeForm.Width;
					}
					if (mousePosition4.Y + dateTimeForm.Height > workingArea.Height)
					{
						mousePosition4.Y = workingArea.Height - dateTimeForm.Height;
					}
					dateTimeForm.StartPosition = FormStartPosition.Manual;
					dateTimeForm.Location = mousePosition4;
					dateTimeForm.TopMost = true;
					if (dateTimeForm.ShowDialog() == DialogResult.OK)
					{
						this.get_Item(rowIndex, colIndex).set_Text(nISimple4.Value);
					}
				}
				else if (bindMMetaItem is MIQuantity)
				{
					Point mousePosition5 = Control.MousePosition;
					Point location = this.PointToScreen(mousePosition5);
					MIQuantity mIQuantity = (MIQuantity)bindMMetaItem;
					NISimple nISimple5 = (NISimple)nInstanceItem;
					QuantityForm quantityForm = new QuantityForm(nISimple5);
					location.Y += 18;
					Rectangle workingArea2 = Screen.AllScreens[0].WorkingArea;
					if (location.X + quantityForm.Height > workingArea2.Width)
					{
						location.X = workingArea2.Width - quantityForm.Width;
					}
					if (location.Y + quantityForm.Height > workingArea2.Height)
					{
						location.Y = workingArea2.Height - quantityForm.Height;
					}
					quantityForm.StartPosition = FormStartPosition.Manual;
					quantityForm.Location = location;
					quantityForm.TopMost = true;
					if (quantityForm.ShowDialog() == DialogResult.OK)
					{
						this.get_Item(rowIndex, colIndex).set_Text(nISimple5.Value);
					}
				}
			}
		}

		private void PCTable_CurrentCellChanged(object sender, EventArgs e)
		{
			int rowIndex = this.get_CurrentCell().get_RowIndex();
			int colIndex = this.get_CurrentCell().get_ColIndex();
			string code = Conversions.ToString(this.get_Item(rowIndex, colIndex).get_Tag());
			NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(code);
			MMetaItem bindMMetaItem = nInstanceItem.BindMMetaItem;
			this.get_CurrentCell().EndEdit();
			NISimple nISimple = (NISimple)nInstanceItem;
			if (bindMMetaItem is MIString)
			{
				nISimple.Value = this.get_Item(rowIndex, colIndex).get_Text();
			}
			else if (bindMMetaItem is MINumber)
			{
				MINumber mINumber = (MINumber)bindMMetaItem;
				if (Versioned.IsNumeric(this.get_Item(rowIndex, colIndex).get_Text()))
				{
					if (mINumber.IncludeMin & float.Parse(this.get_Item(rowIndex, colIndex).get_Text()) < mINumber.MinVal)
					{
						nISimple.Value = mINumber.MinVal.ToString();
						this.get_Item(rowIndex, colIndex).set_Text(nISimple.Value);
					}
					else if (mINumber.IncludeMax & float.Parse(this.get_Item(rowIndex, colIndex).get_Text()) > mINumber.MaxVal)
					{
						nISimple.Value = mINumber.MaxVal.ToString();
						this.get_Item(rowIndex, colIndex).set_Text(nISimple.Value);
					}
					else
					{
						nISimple.Value = this.get_Item(rowIndex, colIndex).get_Text();
					}
				}
			}
			else if (bindMMetaItem is MIMonoChoice)
			{
				nISimple.Value = this.get_Item(rowIndex, colIndex).get_Text();
				MIMonoChoice mIMonoChoice = (MIMonoChoice)nISimple.BindMMetaItem;
				int num = 0;
				StringEnumerator enumerator = mIMonoChoice.Choices.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (current.IndexOf("|") > -1)
					{
						if (Operators.CompareString(this.get_Item(rowIndex, colIndex).get_Text(), current.Split(new char[]
						{
							'|'
						})[0], false) == 0)
						{
							nISimple.ValueCode = current.Split(new char[]
							{
								'|'
							})[1];
							break;
						}
					}
					else if (Operators.CompareString(this.get_Item(rowIndex, colIndex).get_Text(), current, false) == 0)
					{
						nISimple.ValueCode = num.ToString();
						break;
					}
				}
			}
			this.get_CurrentCell().BeginEdit();
		}

		public void OnAddRow(object sender, EventArgs e)
		{
			this.get_Rows().InsertRange(this.get_CurrentCell().get_RowIndex(), 1);
		}

		public void OnDeleteRow(object sender, EventArgs e)
		{
			this.get_Rows().RemoveRange(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_RowIndex());
		}

		public void OnAddColumn(object sender, EventArgs e)
		{
			this.get_Cols().InsertRange(this.get_CurrentCell().get_ColIndex(), 1);
		}

		public void OnDeleteColumn(object sender, EventArgs e)
		{
			this.get_Cols().RemoveRange(this.get_CurrentCell().get_ColIndex(), this.get_CurrentCell().get_ColIndex());
		}

		public void OnCoverCells(object sender, EventArgs e)
		{
			if (this.get_Selections().get_Ranges().Count > 0)
			{
				this.get_CoveredRanges().Add(this.get_Selections().get_Ranges().get_Item(0));
			}
			else
			{
				GridRangeInfo gridRangeInfo = this.get_CoveredRanges().FindRange(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex());
				if (gridRangeInfo != null)
				{
					this.get_CoveredRanges().Remove(gridRangeInfo);
				}
			}
		}

		public void OnShowHeader(object sender, EventArgs e)
		{
			if (this.get_ColWidths().get_Item(0) == 0)
			{
				this.get_ColWidths().set_Item(0, 50);
			}
			else
			{
				this.get_ColWidths().set_Item(0, 0);
			}
			if (this.get_RowHeights().get_Item(0) == 0)
			{
				this.get_RowHeights().set_Item(0, 20);
			}
			else
			{
				this.get_RowHeights().set_Item(0, 0);
			}
		}

		public void OnFormate(object sender, EventArgs e)
		{
			if (!(this.get_CurrentCell().get_ColIndex() == 0 | this.get_CurrentCell().get_RowIndex() == 0))
			{
				TableFormateForm tableFormateForm = new TableFormateForm();
				GridStyleInfo gridStyleInfo = this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex());
				tableFormateForm.txtContent.Text = gridStyleInfo.get_Text();
				if (gridStyleInfo.get_HorizontalAlignment() == 2)
				{
					tableFormateForm.cbxFont.SelectedIndex = 0;
				}
				else if (gridStyleInfo.get_HorizontalAlignment() == 0)
				{
					tableFormateForm.cbxFont.SelectedIndex = 1;
				}
				else if (gridStyleInfo.get_HorizontalAlignment() == 1)
				{
					tableFormateForm.cbxFont.SelectedIndex = 2;
				}
				if (gridStyleInfo.get_VerticalAlignment() == 1)
				{
					tableFormateForm.cbxVAlign.SelectedIndex = 0;
				}
				else if (gridStyleInfo.get_VerticalAlignment() == 0)
				{
					tableFormateForm.cbxVAlign.SelectedIndex = 1;
				}
				else if (gridStyleInfo.get_VerticalAlignment() == 2)
				{
					tableFormateForm.cbxVAlign.SelectedIndex = 2;
				}
				if (gridStyleInfo.get_HasFont())
				{
					tableFormateForm.btnFont.Font = gridStyleInfo.get_GdipFont();
				}
				if (tableFormateForm.ShowDialog() == DialogResult.OK)
				{
					gridStyleInfo.set_Text(tableFormateForm.txtContent.Text);
					if (tableFormateForm.cbxFont.SelectedIndex == 0)
					{
						gridStyleInfo.set_HorizontalAlignment(2);
					}
					else if (tableFormateForm.cbxFont.SelectedIndex == 1)
					{
						gridStyleInfo.set_HorizontalAlignment(0);
					}
					else if (tableFormateForm.cbxFont.SelectedIndex == 2)
					{
						gridStyleInfo.set_HorizontalAlignment(1);
					}
					if (tableFormateForm.cbxVAlign.SelectedIndex == 0)
					{
						gridStyleInfo.set_VerticalAlignment(1);
					}
					else if (tableFormateForm.cbxVAlign.SelectedIndex == 1)
					{
						gridStyleInfo.set_VerticalAlignment(0);
					}
					else if (tableFormateForm.cbxVAlign.SelectedIndex == 2)
					{
						gridStyleInfo.set_VerticalAlignment(2);
					}
					gridStyleInfo.get_Font().set_Facename(tableFormateForm.btnFont.Font.Name);
					gridStyleInfo.get_Font().set_FontStyle(tableFormateForm.btnFont.Font.Style);
					gridStyleInfo.get_Font().set_Size(tableFormateForm.btnFont.Font.Size);
				}
			}
		}

		public void OnClear(object sender, EventArgs e)
		{
			GridStyleInfo gridStyleInfo = this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex());
			if (Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(gridStyleInfo.get_Tag() == null, Operators.CompareObjectEqual(gridStyleInfo.get_Tag(), "", false)))))
			{
				gridStyleInfo.set_BaseStyle("");
				gridStyleInfo.set_Text("");
				string code = Conversions.ToString(gridStyleInfo.get_Tag());
				this._InstanceData.FindInstanceItemByCode(code).BindMMetaItem.BindControl = false;
			}
		}

		private void PCAlignTable_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right & this.IsDesign)
			{
				ContextMenu arg_31_0 = this.cmRows;
				Point pos = new Point(e.X, e.Y);
				arg_31_0.Show(this, pos);
			}
		}

		public void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
			this.ATDesesrialize(reader);
		}

		public void ATDesesrialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.set_RowCount(int.Parse(reader.Value));
				reader.Read();
			}
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
				num = 0;
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "RowHeight", false) == 0)
					{
						reader.Read();
						if (num <= this.get_ColCount())
						{
							this.get_RowHeights().set_Item(num, int.Parse(reader.Value));
						}
						reader.Read();
						num++;
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "RowHeights", false) == 0)
					{
						break;
					}
				}
				reader.Read();
				num = 1;
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "RowFormates", false) == 0)
					{
						int num2 = 1;
						while (reader.Read())
						{
							if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "ColFormate", false) == 0)
							{
								GridStyleInfo gridStyleInfo = this.get_Item(num, num2);
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.set_BaseStyle(reader.Value);
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.set_Text(reader.Value);
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.set_Tag(reader.Value);
									reader.Read();
								}
								if (Operators.CompareString(gridStyleInfo.get_BaseStyle(), "MonoChoice", false) == 0 && this._InstanceData != null)
								{
									NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(Conversions.ToString(gridStyleInfo.get_Tag()));
									if (nInstanceItem != null && nInstanceItem.BindMMetaItem is MIMonoChoice)
									{
										MIMonoChoice mIMonoChoice = (MIMonoChoice)nInstanceItem.BindMMetaItem;
										StringCollection stringCollection = new StringCollection();
										StringEnumerator enumerator = mIMonoChoice.Choices.GetEnumerator();
										while (enumerator.MoveNext())
										{
											string current = enumerator.Current;
											if (current.IndexOf("|") > -1)
											{
												stringCollection.Add(current.Split(new char[]
												{
													'|'
												})[0]);
											}
											else
											{
												stringCollection.Add(current);
											}
										}
										gridStyleInfo.set_ChoiceList(stringCollection);
									}
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.set_HorizontalAlignment(Conversions.ToInteger(Enum.Parse(gridStyleInfo.get_HorizontalAlignment().GetType(), reader.Value)));
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.set_VerticalAlignment(Conversions.ToInteger(Enum.Parse(gridStyleInfo.get_VerticalAlignment().GetType(), reader.Value)));
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.get_Font().set_Facename(reader.Value);
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.get_Font().set_FontStyle((FontStyle)Conversions.ToInteger(Enum.Parse(gridStyleInfo.get_Font().get_FontStyle().GetType(), reader.Value)));
									reader.Read();
								}
								reader.Read();
								if (!reader.IsEmptyElement)
								{
									reader.Read();
									gridStyleInfo.get_Font().set_Size((float)int.Parse(reader.Value));
									reader.Read();
								}
								num2++;
							}
							else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "RowFormates", false) == 0)
							{
								break;
							}
						}
						num++;
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "Formates", false) == 0)
					{
						break;
					}
				}
				reader.Read();
				num = 0;
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "Range", false) == 0)
					{
						reader.Read();
						int num3;
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							num3 = int.Parse(reader.Value);
							reader.Read();
						}
						reader.Read();
						int num4;
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							num4 = int.Parse(reader.Value);
							reader.Read();
						}
						reader.Read();
						int num5;
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							num5 = int.Parse(reader.Value);
							reader.Read();
						}
						reader.Read();
						int num6;
						if (!reader.IsEmptyElement)
						{
							reader.Read();
							num6 = int.Parse(reader.Value);
							reader.Read();
						}
						GridRangeInfo gridRangeInfo = new GridRangeInfo();
						this.get_CoveredRanges().Add(GridRangeInfo.FromTlhw(num4, num3, num6, num5));
						num++;
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "CoveredRanges", false) == 0)
					{
						break;
					}
					if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "PCAlignTable", false) == 0)
					{
						break;
					}
				}
			}
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			PCAlignTable.ATDragOverEventHandler aTDragOverEvent = this.ATDragOverEvent;
			if (aTDragOverEvent != null)
			{
				aTDragOverEvent(this, drgevent);
			}
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			PCAlignTable.ATDragDropEventHandler aTDragDropEvent = this.ATDragDropEvent;
			if (aTDragDropEvent != null)
			{
				aTDragDropEvent(this, drgevent);
			}
		}
	}
}
