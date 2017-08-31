using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PACSData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSOEordIDByARCDRDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSOEordIDByARCDRDataSet : DataSet
	{
		public delegate void SelPACSItemListByARCDRRowChangeEventHandler(object sender, EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelPACSItemListByARCDRDataTable : DataTable, IEnumerable
		{
			private DataColumn columnItemName;

			private DataColumn columnOEOrdItemDR;

			private DataColumn columnRptRowID;

			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowChangingEvent;

			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowChangedEvent;

			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowDeletingEvent;

			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowDeletedEvent;

			public event EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSItemListByARCDRRowChangingEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSItemListByARCDRRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSItemListByARCDRRowChangingEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSItemListByARCDRRowChangingEvent, value);
				}
			}

			public event EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSItemListByARCDRRowChangedEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSItemListByARCDRRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSItemListByARCDRRowChangedEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSItemListByARCDRRowChangedEvent, value);
				}
			}

			public event EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSItemListByARCDRRowDeletingEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSItemListByARCDRRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSItemListByARCDRRowDeletingEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSItemListByARCDRRowDeletingEvent, value);
				}
			}

			public event EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler SelPACSItemListByARCDRRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSItemListByARCDRRowDeletedEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSItemListByARCDRRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSItemListByARCDRRowDeletedEvent = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSItemListByARCDRRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemNameColumn
			{
				get
				{
					return this.columnItemName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OEOrdItemDRColumn
			{
				get
				{
					return this.columnOEOrdItemDR;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn RptRowIDColumn
			{
				get
				{
					return this.columnRptRowID;
				}
			}

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow this[int index]
			{
				get
				{
					return (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelPACSItemListByARCDRDataTable()
			{
				this.TableName = "SelPACSItemListByARCDR";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelPACSItemListByARCDRDataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			protected SelPACSItemListByARCDRDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelPACSItemListByARCDRRow(EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow AddSelPACSItemListByARCDRRow(string ItemName, string OEOrdItemDR, string RptRowID)
			{
				EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow selPACSItemListByARCDRRow = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ItemName,
					OEOrdItemDR,
					RptRowID
				};
				selPACSItemListByARCDRRow.ItemArray = itemArray;
				this.Rows.Add(selPACSItemListByARCDRRow);
				return selPACSItemListByARCDRRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable selPACSItemListByARCDRDataTable = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable)base.Clone();
				selPACSItemListByARCDRDataTable.InitVars();
				return selPACSItemListByARCDRDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnItemName = base.Columns["ItemName"];
				this.columnOEOrdItemDR = base.Columns["OEOrdItemDR"];
				this.columnRptRowID = base.Columns["RptRowID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnItemName = new DataColumn("ItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemName);
				this.columnOEOrdItemDR = new DataColumn("OEOrdItemDR", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOEOrdItemDR);
				this.columnRptRowID = new DataColumn("RptRowID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRptRowID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow NewSelPACSItemListByARCDRRow()
			{
				return (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelPACSItemListByARCDRRowChangedEvent != null)
				{
					EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler selPACSItemListByARCDRRowChangedEvent = this.SelPACSItemListByARCDRRowChangedEvent;
					if (selPACSItemListByARCDRRowChangedEvent != null)
					{
						selPACSItemListByARCDRRowChangedEvent(this, new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEvent((EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelPACSItemListByARCDRRowChangingEvent != null)
				{
					EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler selPACSItemListByARCDRRowChangingEvent = this.SelPACSItemListByARCDRRowChangingEvent;
					if (selPACSItemListByARCDRRowChangingEvent != null)
					{
						selPACSItemListByARCDRRowChangingEvent(this, new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEvent((EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelPACSItemListByARCDRRowDeletedEvent != null)
				{
					EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler selPACSItemListByARCDRRowDeletedEvent = this.SelPACSItemListByARCDRRowDeletedEvent;
					if (selPACSItemListByARCDRRowDeletedEvent != null)
					{
						selPACSItemListByARCDRRowDeletedEvent(this, new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEvent((EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelPACSItemListByARCDRRowDeletingEvent != null)
				{
					EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEventHandler selPACSItemListByARCDRRowDeletingEvent = this.SelPACSItemListByARCDRRowDeletingEvent;
					if (selPACSItemListByARCDRRowDeletingEvent != null)
					{
						selPACSItemListByARCDRRowDeletingEvent(this, new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRowChangeEvent((EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelPACSItemListByARCDRRow(EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSOEordIDByARCDRDataSet ePACSOEordIDByARCDRDataSet = new EPACSOEordIDByARCDRDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle arg_31_0 = xmlSchemaAny;
				decimal minOccurs = new decimal(0);
				arg_31_0.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle arg_8B_0 = xmlSchemaAny2;
				minOccurs = new decimal(1);
				arg_8B_0.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = ePACSOEordIDByARCDRDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelPACSItemListByARCDRDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSOEordIDByARCDRDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelPACSItemListByARCDRRow : DataRow
		{
			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable tableSelPACSItemListByARCDR;

			[DebuggerNonUserCode]
			public string ItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelPACSItemListByARCDR.ItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSItemListByARCDR\"中列\"ItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSItemListByARCDR.ItemNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OEOrdItemDR
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelPACSItemListByARCDR.OEOrdItemDRColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSItemListByARCDR\"中列\"OEOrdItemDR\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSItemListByARCDR.OEOrdItemDRColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string RptRowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelPACSItemListByARCDR.RptRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSItemListByARCDR\"中列\"RptRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSItemListByARCDR.RptRowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelPACSItemListByARCDRRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelPACSItemListByARCDR = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsItemNameNull()
			{
				return this.IsNull(this.tableSelPACSItemListByARCDR.ItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemNameNull()
			{
				this[this.tableSelPACSItemListByARCDR.ItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEOrdItemDRNull()
			{
				return this.IsNull(this.tableSelPACSItemListByARCDR.OEOrdItemDRColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEOrdItemDRNull()
			{
				this[this.tableSelPACSItemListByARCDR.OEOrdItemDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRptRowIDNull()
			{
				return this.IsNull(this.tableSelPACSItemListByARCDR.RptRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetRptRowIDNull()
			{
				this[this.tableSelPACSItemListByARCDR.RptRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelPACSItemListByARCDRRowChangeEvent : EventArgs
		{
			private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			public SelPACSItemListByARCDRRowChangeEvent(EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable tableSelPACSItemListByARCDR;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable SelPACSItemListByARCDR
		{
			get
			{
				return this.tableSelPACSItemListByARCDR;
			}
		}

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[DebuggerNonUserCode]
		public EPACSOEordIDByARCDRDataSet()
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		protected EPACSOEordIDByARCDRDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			if (this.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
			if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["SelPACSItemListByARCDR"] != null)
				{
					base.Tables.Add(new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable(dataSet.Tables["SelPACSItemListByARCDR"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			this.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			EPACSOEordIDByARCDRDataSet ePACSOEordIDByARCDRDataSet = (EPACSOEordIDByARCDRDataSet)base.Clone();
			ePACSOEordIDByARCDRDataSet.InitVars();
			ePACSOEordIDByARCDRDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSOEordIDByARCDRDataSet;
		}

		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["SelPACSItemListByARCDR"] != null)
				{
					base.Tables.Add(new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable(dataSet.Tables["SelPACSItemListByARCDR"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXml(reader);
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableSelPACSItemListByARCDR = (EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable)base.Tables["SelPACSItemListByARCDR"];
			if (initTable && this.tableSelPACSItemListByARCDR != null)
			{
				this.tableSelPACSItemListByARCDR.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSOEordIDByARCDRDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSOEordIDByARCDRDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelPACSItemListByARCDR = new EPACSOEordIDByARCDRDataSet.SelPACSItemListByARCDRDataTable();
			base.Tables.Add(this.tableSelPACSItemListByARCDR);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelPACSItemListByARCDR()
		{
			return false;
		}

		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			EPACSOEordIDByARCDRDataSet ePACSOEordIDByARCDRDataSet = new EPACSOEordIDByARCDRDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSOEordIDByARCDRDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSOEordIDByARCDRDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}
}
