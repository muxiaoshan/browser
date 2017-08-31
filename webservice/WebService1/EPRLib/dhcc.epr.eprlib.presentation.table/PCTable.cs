using CustomDictoryData;
using dhcc.epr.eprlib.dataaccess;
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
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation.table
{
	public class PCTable : GridControl, PControlInterface, ICheckValueChanged
	{
		private IContainer components;

		private GridBaseStyle stlHeader;

		private GridBaseStyle stlColHeader;

		private GridBaseStyle stlRowHeader;

		private GridBaseStyle stlStandard;

		private GridBaseStyle stlColString;

		private GridBaseStyle stlColNumber;

		private GridBaseStyle stlColChoice;

		private GridBaseStyle stlColCheck;

		private GridBaseStyle stlColDictionary;

		private GridBaseStyle stlColPosition;

		private GridBaseStyle stlColDate;

		private MenuItem miAddRow;

		private MenuItem miAddRowNext;

		private MenuItem miDeleteRow;

		private ContextMenu cmRows;

		private MenuItem miSpecChar;

		private MenuItem miDicLIS;

		private MenuItem miDicRIS;

		private ContextMenu cmDics;

		private NITable _BindNITable;

		private MITable _BindMITable;

		private string _Code;

		private Label curTip;

		private Point _CurrentLoc;

		private int _CurrentCellSelectionStart;

		private ETeethPestion _dsCustomDictiory;

		private UCCrossContainer curCrossContainer;

		private int initValue;

		public NInstanceItem BindInstanceItem
		{
			get
			{
				return this._BindNITable;
			}
			set
			{
				this._BindNITable = (NITable)value;
				this._Code = this._BindNITable.Code;
				this._BindMITable = (MITable)this._BindNITable.BindMMetaItem;
				this.ClearGrid();
				this.set_ColCount(this._BindMITable.SubItems.Count);
				int arg_64_0 = 0;
				checked
				{
					int num = this._BindMITable.SubItems.Count - 1;
					for (int i = arg_64_0; i <= num; i++)
					{
						MISimple mISimple = (MISimple)this._BindMITable.SubItems[i];
						this.get_Item(0, i + 1).set_Text(mISimple.Text);
						if (this._BindMITable.HorizontalAlignment == 1)
						{
							this.get_ColStyles().get_Item(i + 1).set_HorizontalAlignment(0);
						}
						else if (this._BindMITable.HorizontalAlignment == 2)
						{
							this.get_ColStyles().get_Item(i + 1).set_HorizontalAlignment(2);
						}
						else if (this._BindMITable.HorizontalAlignment == 3)
						{
							this.get_ColStyles().get_Item(i + 1).set_HorizontalAlignment(1);
						}
						if (mISimple is MINumber)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("TextBox");
							this.get_ColStyles().get_Item(i + 1).set_TextAlign(2);
						}
						else if (mISimple is MIString)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("TextBox");
							this.get_ColStyles().get_Item(i + 1).set_AutoSize(true);
							this.get_ColStyles().get_Item(i + 1).set_AllowEnter(true);
						}
						else if (mISimple is MIMonoChoice)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("ComboBox");
							MIMonoChoice mIMonoChoice = (MIMonoChoice)mISimple;
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
							this.get_ColStyles().get_Item(i + 1).set_ChoiceList(stringCollection);
						}
						else if (mISimple is MIDictionary)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("DictionaryButton");
						}
						else if (mISimple is MIPosition)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("PositionButton");
						}
						else if (mISimple is MIMultiChoice)
						{
							if (((MIMultiChoice)mISimple).CrossModel)
							{
								this.get_ColStyles().get_Item(i + 1).set_CellType("CrossButton");
								this._dsCustomDictiory = WebServiceLayer.CustomDictoryDataAccess.GetTeethPestion();
							}
							else
							{
								this.get_ColStyles().get_Item(i + 1).set_CellType("MultiChoiceButton");
							}
						}
						else if (mISimple is MIQuantity)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("QuantityButton");
						}
						else if (mISimple is MIDateTime)
						{
							this.get_ColStyles().get_Item(i + 1).set_CellType("DateTimeButton");
						}
					}
					this.set_RowCount(0);
					int arg_339_0 = 0;
					int num2 = this._BindNITable.SubItems.Count - 1;
					for (int j = arg_339_0; j <= num2; j++)
					{
						this.get_Rows().InsertRange(j + 1, 1);
						NIRow nIRow = (NIRow)this._BindNITable.SubItems[j];
						int arg_37A_0 = 0;
						int num3 = nIRow.SubItems.Count - 1;
						for (int k = arg_37A_0; k <= num3; k++)
						{
							if (this._BindMITable.SubItems[k] is MIString)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
								this.AutoSizeRow(j + 1, k + 1);
							}
							else if (this._BindMITable.SubItems[k] is MINumber)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
							}
							else if (this._BindMITable.SubItems[k] is MIMonoChoice)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
							}
							else if (this._BindMITable.SubItems[k] is MIMultiChoice)
							{
								if (((MIMultiChoice)this._BindMITable.SubItems[k]).CrossModel)
								{
									UCCrossContainer uCCrossContainer = new UCCrossContainer();
									string[] array = nIRow.SubItems[k].Value.Split(new char[]
									{
										'|'
									});
									if (array.Length == 4)
									{
										uCCrossContainer.LTContent = array[0];
										uCCrossContainer.RTContent = array[1];
										uCCrossContainer.LBContent = array[2];
										uCCrossContainer.RBContent = array[3];
									}
									uCCrossContainer.OnTextChange += new UCCrossContainer.GetTextChangeEventHandler(this.SyncInstanceItem);
									this.get_Item(j + 1, k + 1).set_Control(uCCrossContainer);
									this.get_RowHeights().set_Item(j + 1, uCCrossContainer.Height);
								}
								else
								{
									this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
								}
							}
							else if (this._BindMITable.SubItems[k] is MIDictionary)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
							}
							else if (this._BindMITable.SubItems[k] is MIPosition)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
							}
							else if (this._BindMITable.SubItems[k] is MIDateTime)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value);
							}
							else if (this._BindMITable.SubItems[k] is MIQuantity)
							{
								this.get_Item(j + 1, k + 1).set_Text(nIRow.SubItems[k].Value + nIRow.SubItems[k].ValueCode);
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

		public PCTable()
		{
			base.add_CurrentCellControlLostFocus(new ControlEventHandler(this.PCTable_CurrentCellControlLostFocus));
			base.add_CellButtonClicked(new GridCellButtonClickedEventHandler(this.PCTable_CellButtonClicked));
			base.add_CurrentCellChanged(new EventHandler(this.PCTable_CurrentCellChanged));
			base.MouseDown += new MouseEventHandler(this.PCTable_MouseDown);
			base.add_CurrentCellControlGotFocus(new ControlEventHandler(this.PCTable_CurrentCellControlGotFocus));
			this._CurrentCellSelectionStart = 0;
			this._dsCustomDictiory = new ETeethPestion();
			this.curCrossContainer = new UCCrossContainer();
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
			ResourceManager resourceManager = new ResourceManager(typeof(PCTable));
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
			this.get_CellModels().Add("DictionaryButton", new DictionaryCellModel(this.get_Model()));
			this.get_CellModels().Add("MultiChoiceButton", new MultiChoiceCellModel(this.get_Model()));
			this.get_CellModels().Add("QuantityButton", new QuantityCellModel(this.get_Model()));
			this.get_CellModels().Add("DateTimeButton", new DateTimeCellModel(this.get_Model()));
			this.get_CellModels().Add("PositionButton", new PositionCellModel(this.get_Model()));
			this.get_CellModels().Add("CrossButton", new CrossCellModel(this.get_Model()));
			this.set_MinResizeColSize(8);
			this.set_MinResizeRowSize(8);
			this.miAddRow = new MenuItem("添加行[行前]");
			this.miAddRowNext = new MenuItem("添加行[行后]");
			this.miDeleteRow = new MenuItem("删除行");
			this.cmRows = new ContextMenu();
			this.miAddRow.Click += new EventHandler(this.OnAddRow);
			this.miAddRowNext.Click += new EventHandler(this.OnAddRowNext);
			this.miDeleteRow.Click += new EventHandler(this.OnDeleteRow);
			this.cmRows.MenuItems.Add(this.miAddRow);
			this.cmRows.MenuItems.Add(this.miAddRowNext);
			this.cmRows.MenuItems.Add(this.miDeleteRow);
			this.miSpecChar = new MenuItem("特殊字符");
			this.miDicLIS = new MenuItem("检验数据");
			this.miDicRIS = new MenuItem("检查数据");
			this.miSpecChar.Click += new EventHandler(this.OnSpecChar);
			this.miDicLIS.Click += new EventHandler(this.OnDicLIS);
			this.miDicRIS.Click += new EventHandler(this.OnDicRIS);
			this.cmDics = new ContextMenu();
			this.cmDics.MenuItems.Add(this.miSpecChar);
			this.cmDics.MenuItems.Add(this.miDicLIS);
			this.cmDics.MenuItems.Add(this.miDicRIS);
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

		private void PCTable_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
		{
			int colIndex = e.get_ColIndex();
			int rowIndex = e.get_RowIndex();
			this.get_CurrentCell().MoveTo(rowIndex, colIndex);
			checked
			{
				if (this._BindMITable.SubItems[colIndex - 1] is MIDictionary)
				{
					Point mousePosition = Control.MousePosition;
					MIDictionary mIDictionary = (MIDictionary)this._BindMITable.SubItems[colIndex - 1];
					NISimple nISimple = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
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
				else if (this._BindMITable.SubItems[colIndex - 1] is MIPosition)
				{
					Point mousePosition2 = Control.MousePosition;
					MIPosition bindMIPosition = (MIPosition)this._BindMITable.SubItems[colIndex - 1];
					NISimple nISimple2 = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
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
				else if (this._BindMITable.SubItems[colIndex - 1] is MIMultiChoice)
				{
					Point mousePosition3 = Control.MousePosition;
					MIMultiChoice mIMultiChoice = (MIMultiChoice)this._BindMITable.SubItems[colIndex - 1];
					NISimple nISimple3 = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
					if (mIMultiChoice.CrossModel)
					{
						MultiChoiceForm multiChoiceForm = new MultiChoiceForm((MIMultiChoice)nISimple3.BindMMetaItem, this._dsCustomDictiory);
						this.curCrossContainer = (UCCrossContainer)this.get_Item(rowIndex, colIndex).get_Control();
						multiChoiceForm.OnButtionClick += new MultiChoiceForm.SetContrlEventHandler(this.setControl);
						multiChoiceForm.SetFormPosition(mousePosition3);
						multiChoiceForm.TopMost = true;
						if (multiChoiceForm.ShowDialog() == DialogResult.OK && this.curCrossContainer != null)
						{
							nISimple3.Value = string.Concat(new string[]
							{
								this.curCrossContainer.LTContent,
								"|",
								this.curCrossContainer.RTContent,
								"|",
								this.curCrossContainer.LBContent,
								"|",
								this.curCrossContainer.RBContent
							});
						}
					}
					else
					{
						MultiChoiceForm multiChoiceForm2 = new MultiChoiceForm((MIMultiChoice)nISimple3.BindMMetaItem, nISimple3.Value);
						multiChoiceForm2.SetFormPosition(mousePosition3);
						multiChoiceForm2.TopMost = true;
						if (multiChoiceForm2.ShowDialog() == DialogResult.OK)
						{
							nISimple3.Value = multiChoiceForm2.CheckString;
							nISimple3.ValueCode = multiChoiceForm2.CheckStatus;
							this.get_Item(rowIndex, colIndex).set_Text(nISimple3.Value);
						}
					}
				}
				else if (this._BindMITable.SubItems[colIndex - 1] is MIDateTime)
				{
					Point mousePosition4 = Control.MousePosition;
					MIDateTime mIDateTime = (MIDateTime)this._BindMITable.SubItems[colIndex - 1];
					NISimple nISimple4 = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
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
				else if (this._BindMITable.SubItems[colIndex - 1] is MIQuantity)
				{
					Point mousePosition5 = Control.MousePosition;
					Point location = this.PointToScreen(mousePosition5);
					MIQuantity mIQuantity = (MIQuantity)this._BindMITable.SubItems[colIndex - 1];
					NISimple nISimple5 = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
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
			this.SyncInstanceItem();
		}

		private void PCTable_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && this.get_CurrentCell().get_ColIndex() == 0)
			{
				if (this.get_CurrentCell().get_RowIndex() == 0)
				{
					this.miAddRow.Visible = false;
					this.miDeleteRow.Visible = false;
				}
				else
				{
					this.miAddRow.Visible = true;
					this.miDeleteRow.Visible = true;
				}
				ContextMenu arg_76_0 = this.cmRows;
				Point pos = new Point(e.X, e.Y);
				arg_76_0.Show(this, pos);
			}
		}

		public void OnAddRow(object sender, EventArgs e)
		{
			this.AddRow(this.get_CurrentCell().get_RowIndex());
		}

		public void OnAddRowNext(object sender, EventArgs e)
		{
			this.AddRow(checked(this.get_CurrentCell().get_RowIndex() + 1));
		}

		public void OnDeleteRow(object sender, EventArgs e)
		{
			this._BindNITable.SubItems.RemoveAt(checked(this.get_CurrentCell().get_RowIndex() - 1));
			this.get_Rows().RemoveRange(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_RowIndex());
		}

		private void AddRow(int addRowIndex)
		{
			NIRow nIRow = new NIRow();
			int arg_1B_0 = 0;
			checked
			{
				int num = this._BindMITable.SubItems.Count - 1;
				for (int i = arg_1B_0; i <= num; i++)
				{
					nIRow.SubItems.Add(this._BindMITable.SubItems[i].CreateInstance());
				}
				this._BindNITable.SubItems.Insert(addRowIndex - 1, nIRow);
				this.get_Rows().InsertRange(addRowIndex, 1);
				int arg_7E_0 = 0;
				int num2 = this._BindMITable.SubItems.Count - 1;
				for (int j = arg_7E_0; j <= num2; j++)
				{
					if (this._BindMITable.SubItems[j] is MIMultiChoice && ((MIMultiChoice)this._BindMITable.SubItems[j]).CrossModel)
					{
						UCCrossContainer uCCrossContainer = new UCCrossContainer();
						this.get_Item(addRowIndex, j + 1).set_Control(uCCrossContainer);
						this.get_RowHeights().set_Item(addRowIndex, uCCrossContainer.Height);
					}
				}
			}
		}

		private void PCTable_CurrentCellControlGotFocus(object sender, ControlEventArgs e)
		{
			if (this.IsTextBoxCell(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()))
			{
				GridTextBoxControl gridTextBoxControl = (GridTextBoxControl)e.Control;
				gridTextBoxControl.MouseClick += new MouseEventHandler(this.OnCurrentCellClick);
			}
		}

		private void PCTable_CurrentCellControlLostFocus(object sender, ControlEventArgs e)
		{
			if (this.IsTextBoxCell(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()))
			{
				GridTextBoxControl gridTextBoxControl = (GridTextBoxControl)e.Control;
				gridTextBoxControl.MouseClick -= new MouseEventHandler(this.OnCurrentCellClick);
			}
		}

		public void OnCurrentCellClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && this.IsTextBoxCell(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()))
			{
				GridTextBoxControl gridTextBoxControl = (GridTextBoxControl)this.get_CurrentCell().get_Renderer().get_Control();
				this._CurrentCellSelectionStart = gridTextBoxControl.SelectionStart;
				this._CurrentLoc = this.get_CurrentCellRenderer().get_Control().Location;
				this.cmDics.Show(this, this._CurrentLoc);
			}
		}

		public void OnSpecChar(object sender, EventArgs e)
		{
			SpecCharForm specCharForm = new SpecCharForm();
			specCharForm.SetFormPosition(this._CurrentLoc);
			if (specCharForm.ShowDialog() != DialogResult.OK)
			{
				this.ReSelect(this._CurrentCellSelectionStart);
				return;
			}
			if (specCharForm.CurrentSpecChar == null || Operators.CompareString(specCharForm.CurrentSpecChar, "", false) == 0)
			{
				this.ReSelect(this._CurrentCellSelectionStart);
				return;
			}
			string text = this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).get_Text();
			this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).set_Text(text.Insert(this._CurrentCellSelectionStart, specCharForm.CurrentSpecChar));
			this.ReSelect(checked(this._CurrentCellSelectionStart + 1));
			this.SyncInstanceItem();
		}

		public void OnDicLIS(object sender, EventArgs e)
		{
			IDictionary dic = DicFactory.Instance.getDic("LISDictionary");
			MIDictionary midic = new MIDictionary();
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, this._CurrentLoc, niDic, "", "");
			if (dicContent == null || Operators.CompareString(dicContent.Description, "", false) == 0)
			{
				this.ReSelect(this._CurrentCellSelectionStart);
				return;
			}
			string text = this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).get_Text();
			this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).set_Text(text.Insert(this._CurrentCellSelectionStart, dicContent.Description));
			this.ReSelect(checked(this._CurrentCellSelectionStart + dicContent.Description.Length));
			this.SyncInstanceItem();
		}

		public void OnDicRIS(object sender, EventArgs e)
		{
			IDictionary dic = DicFactory.Instance.getDic("PACSDictionary");
			MIDictionary midic = new MIDictionary();
			NISimple niDic = new NISimple();
			DicContent dicContent = dic.GetDicContent(midic, this._CurrentLoc, niDic, "", "");
			if (dicContent == null || Operators.CompareString(dicContent.Description, "", false) == 0)
			{
				this.ReSelect(this._CurrentCellSelectionStart);
				return;
			}
			string text = this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).get_Text();
			this.get_Item(this.get_CurrentCell().get_RowIndex(), this.get_CurrentCell().get_ColIndex()).set_Text(text.Insert(this._CurrentCellSelectionStart, dicContent.Description));
			this.ReSelect(checked(this._CurrentCellSelectionStart + dicContent.Description.Length));
			this.SyncInstanceItem();
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

		private void AutoSizeRow(int rowIndex, int colIndex)
		{
			Graphics graphics = Graphics.FromHwnd(this.Handle);
			StringFormat format = new StringFormat(StringFormat.GenericDefault);
			SizeF sizeF = graphics.MeasureString(this.get_Item(rowIndex, colIndex).get_Text(), this.get_Font(), this.get_ColWidths().get_Item(colIndex), format);
			if (sizeF.Height > (float)this.get_RowHeights().get_Item(rowIndex))
			{
				this.get_RowHeights().set_Item(rowIndex, checked((int)Math.Round((double)sizeF.Height)));
			}
			graphics.Dispose();
		}

		private void SyncInstanceItem()
		{
			int rowIndex = this.get_CurrentCell().get_RowIndex();
			int colIndex = this.get_CurrentCell().get_ColIndex();
			this.get_CurrentCell().EndEdit();
			checked
			{
				NISimple nISimple = (NISimple)this._BindNITable.SubItems[rowIndex - 1].SubItems[colIndex - 1];
				if (this._BindMITable.SubItems[colIndex - 1] is MIString)
				{
					nISimple.Value = this.get_Item(rowIndex, colIndex).get_Text();
					this.AutoSizeRow(rowIndex, colIndex);
				}
				else if (this._BindMITable.SubItems[colIndex - 1] is MINumber)
				{
					MINumber mINumber = (MINumber)this._BindMITable.SubItems[colIndex - 1];
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
				else if (this._BindMITable.SubItems[colIndex - 1] is MIMonoChoice)
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
				else if (this._BindMITable.SubItems[colIndex - 1] is MIMultiChoice && ((MIMultiChoice)this._BindMITable.SubItems[colIndex - 1]).CrossModel)
				{
					this.curCrossContainer = (UCCrossContainer)this.get_Item(rowIndex, colIndex).get_Control();
					nISimple.Value = string.Concat(new string[]
					{
						this.curCrossContainer.LTContent,
						"|",
						this.curCrossContainer.RTContent,
						"|",
						this.curCrossContainer.LBContent,
						"|",
						this.curCrossContainer.RBContent
					});
				}
				this.get_CurrentCell().BeginEdit();
			}
		}

		private void getCell()
		{
		}

		private bool IsTextBoxCell(int rowIndex, int colIndex)
		{
			return rowIndex > 0 && colIndex > 0 && Operators.CompareString(this.get_ColStyles().get_Item(colIndex).get_CellType(), "TextBox", false) == 0;
		}

		private void ReSelect(int selectStart)
		{
			try
			{
				GridTextBoxControl gridTextBoxControl = (GridTextBoxControl)this.get_CurrentCell().get_Renderer().get_Control();
				gridTextBoxControl.SelectionStart = selectStart;
			}
			catch (Exception expr_1F)
			{
				ProjectData.SetProjectError(expr_1F);
				Exception ex = expr_1F;
				MessageBox.Show("重置光标位置时转换Cell控件错误！" + ex.Message + ex.StackTrace);
				ProjectData.ClearProjectError();
			}
		}

		public void IsValueChanged(ref bool isChanged)
		{
			if (isChanged)
			{
				return;
			}
			isChanged = (this.initValue != this._BindNITable.XMLString.GetHashCode());
		}

		public void SetInitValue()
		{
			this.initValue = this._BindNITable.XMLString.GetHashCode();
		}

		public void setControl(string curStr, string curPesition)
		{
			if (Operators.CompareString(curPesition, "A", false) == 0)
			{
				this.curCrossContainer.LTContent = curStr + " " + this.curCrossContainer.LTContent;
			}
			else if (Operators.CompareString(curPesition, "B", false) == 0)
			{
				this.curCrossContainer.RTContent = this.curCrossContainer.RTContent + " " + curStr;
			}
			else if (Operators.CompareString(curPesition, "C", false) == 0)
			{
				this.curCrossContainer.LBContent = curStr + " " + this.curCrossContainer.LBContent;
			}
			else
			{
				this.curCrossContainer.RBContent = this.curCrossContainer.RBContent + " " + curStr;
			}
		}
	}
}
