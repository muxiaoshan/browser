using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation;
using dhcc.epr.eprlib.presentation.table;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.design.interfacedesign
{
	public class DCAlignTable : DesignControl
	{
		private IContainer components;

		[AccessedThroughProperty("PCAlignTable")]
		private PCAlignTable _PCAlignTable;

		public DesignPanel DesignPanel;

		private const int WM_SETFOCUS = 7;

		public virtual PCAlignTable PCAlignTable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCAlignTable;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PCAlignTable.ATDragDropEventHandler obj = new PCAlignTable.ATDragDropEventHandler(this.PCAlignTable_ATDragDrop);
				PCAlignTable.ATDragOverEventHandler obj2 = new PCAlignTable.ATDragOverEventHandler(this.PCAlignTable_ATDragOver);
				if (this._PCAlignTable != null)
				{
					this._PCAlignTable.ATDragDrop -= obj;
					this._PCAlignTable.ATDragOver -= obj2;
				}
				this._PCAlignTable = value;
				if (this._PCAlignTable != null)
				{
					this._PCAlignTable.ATDragDrop += obj;
					this._PCAlignTable.ATDragOver += obj2;
				}
			}
		}

		public DCAlignTable()
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
			this.AllowDrop = true;
			this.Name = "DCAlignTable";
			Point originLocation = new Point(13, 13);
			this.OriginLocation = originLocation;
		}

		private void Init()
		{
			this.PCAlignTable = new PCAlignTable();
			this.PCAlignTable.AllowDrop = true;
			this.PCAlignTable.IsDesign = true;
			this.PCAlignTable.set_AllowDragSelectedCols(false);
			this.PCAlignTable.set_AllowDragSelectedRows(false);
			this.Controls.Add(this.PCAlignTable);
			this.SetStyle(ControlStyles.Selectable, true);
			this.PControl = this.PCAlignTable;
		}

		protected override void DrawCustomShape(Graphics g, int x, int y)
		{
			checked
			{
				if (x == 0 & y == 0)
				{
					this.PCAlignTable.Left = x;
					this.PCAlignTable.Top = y;
					this.PCAlignTable.Width = this.Width;
					this.PCAlignTable.Height = this.Height;
				}
				else
				{
					this.PCAlignTable.Left = x;
					this.PCAlignTable.Top = y;
					this.PCAlignTable.Width = this.Width - 2 * x;
					this.PCAlignTable.Height = this.Height - 2 * y;
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg != 7)
			{
				base.WndProc(ref m);
			}
		}

		public override void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("PCAlignTable");
			ControlXML.XMLSerialize(writer, this);
			writer.WriteElementString("RowCount", Conversions.ToString(this.PCAlignTable.get_RowCount()));
			writer.WriteElementString("ColCount", Conversions.ToString(this.PCAlignTable.get_ColCount()));
			writer.WriteStartElement("ColWidths");
			int arg_61_0 = 0;
			int colCount = this.PCAlignTable.get_ColCount();
			checked
			{
				for (int i = arg_61_0; i <= colCount; i++)
				{
					writer.WriteElementString("ColWidth", this.PCAlignTable.get_ColWidths().get_Item(i).ToString());
				}
				writer.WriteEndElement();
				writer.WriteStartElement("RowHeights");
				int arg_B1_0 = 0;
				int rowCount = this.PCAlignTable.get_RowCount();
				for (int j = arg_B1_0; j <= rowCount; j++)
				{
					writer.WriteElementString("RowHeight", this.PCAlignTable.get_RowHeights().get_Item(j).ToString());
				}
				writer.WriteEndElement();
				writer.WriteStartElement("Formates");
				int arg_101_0 = 1;
				int rowCount2 = this.PCAlignTable.get_RowCount();
				for (int k = arg_101_0; k <= rowCount2; k++)
				{
					writer.WriteStartElement("RowFormates");
					int arg_120_0 = 1;
					int colCount2 = this.PCAlignTable.get_ColCount();
					for (int l = arg_120_0; l <= colCount2; l++)
					{
						writer.WriteStartElement("ColFormate");
						GridStyleInfo gridStyleInfo = this.PCAlignTable.get_Item(k, l);
						string baseStyle = gridStyleInfo.get_BaseStyle();
						string value = "";
						string value2 = "";
						if (Operators.CompareString(baseStyle, "", false) == 0)
						{
							value = gridStyleInfo.get_Text();
						}
						else
						{
							value2 = Conversions.ToString(gridStyleInfo.get_Tag());
						}
						writer.WriteElementString("BaseStyle", baseStyle);
						writer.WriteElementString("Text", value);
						writer.WriteElementString("Code", value2);
						writer.WriteElementString("HAlign", gridStyleInfo.get_HorizontalAlignment().ToString());
						writer.WriteElementString("VAlign", gridStyleInfo.get_VerticalAlignment().ToString());
						writer.WriteElementString("FontName", gridStyleInfo.get_Font().get_Facename());
						writer.WriteElementString("FontStyle", gridStyleInfo.get_Font().get_FontStyle().ToString());
						writer.WriteElementString("FontSize", gridStyleInfo.get_Font().get_Size().ToString());
						writer.WriteEndElement();
					}
					writer.WriteEndElement();
				}
				writer.WriteEndElement();
				writer.WriteStartElement("CoveredRanges");
				int arg_286_0 = 0;
				int num = this.PCAlignTable.get_CoveredRanges().get_Ranges().Count - 1;
				for (int m = arg_286_0; m <= num; m++)
				{
					writer.WriteStartElement("Range");
					writer.WriteElementString("Left", Conversions.ToString(this.PCAlignTable.get_CoveredRanges().get_Ranges().get_Item(m).get_Left()));
					writer.WriteElementString("Top", Conversions.ToString(this.PCAlignTable.get_CoveredRanges().get_Ranges().get_Item(m).get_Top()));
					writer.WriteElementString("Width", Conversions.ToString(this.PCAlignTable.get_CoveredRanges().get_Ranges().get_Item(m).get_Width()));
					writer.WriteElementString("Height", Conversions.ToString(this.PCAlignTable.get_CoveredRanges().get_Ranges().get_Item(m).get_Height()));
					writer.WriteEndElement();
				}
				writer.WriteEndElement();
				writer.WriteEndElement();
			}
		}

		public override void XMLDeserialize(XmlReader reader)
		{
			ControlXML.XMLDeserialize(reader, this);
			this.PCAlignTable.ATDesesrialize(reader);
		}

		private void PCAlignTable_ATDragOver(object sender, DragEventArgs e)
		{
			Point point = new Point(e.X, e.Y);
			GridRangeInfo gridRangeInfo = this.PCAlignTable.PointToRangeInfo(this.PCAlignTable.PointToClient(point));
			this.PCAlignTable.SynchronizeCurrentCell(gridRangeInfo.get_Top(), gridRangeInfo.get_Left());
			if (gridRangeInfo.get_Left() == 0 | gridRangeInfo.get_Top() == 0)
			{
				e.Effect = DragDropEffects.None;
			}
			else if (this.DesignPanel.DrawControl)
			{
				if (this.DesignPanel.DrawType == DrawCtrlType.Label)
				{
					e.Effect = DragDropEffects.Copy;
				}
				else if (!this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl)
				{
					e.Effect = DragDropEffects.Copy;
				}
				else
				{
					e.Effect = DragDropEffects.None;
				}
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void PCAlignTable_ATDragDrop(object sender, DragEventArgs e)
		{
			Point point = new Point(e.X, e.Y);
			GridRangeInfo gridRangeInfo = this.PCAlignTable.PointToRangeInfo(this.PCAlignTable.PointToClient(point));
			if (this.DesignPanel.DrawType == DrawCtrlType.Label)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.BindMMetaItem.Text);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIString)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("String");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MINumber)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("Number");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIMonoChoice)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("MonoChoice");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				StringCollection stringCollection = new StringCollection();
				MIMonoChoice mIMonoChoice = (MIMonoChoice)this.DesignPanel.DrawInstanceItem.BindMMetaItem;
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
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_ChoiceList(stringCollection);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIMultiChoice)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("MultiChoice");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIDictionary)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("Dictionary");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIPosition)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("Position");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIQuantity)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("Quantity");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value + this.DesignPanel.DrawInstanceItem.ValueCode);
				this.DesignPanel.DrawControl = false;
			}
			else if (this.DesignPanel.DrawType == DrawCtrlType.MIDateTime)
			{
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_BaseStyle("DateTime");
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Tag(this.DesignPanel.DrawInstanceItem.Code);
				this.DesignPanel.DrawInstanceItem.BindMMetaItem.BindControl = true;
				this.PCAlignTable.get_Item(gridRangeInfo.get_Top(), gridRangeInfo.get_Left()).set_Text(this.DesignPanel.DrawInstanceItem.Value);
				this.DesignPanel.DrawControl = false;
			}
		}
	}
}
