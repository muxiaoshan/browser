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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSRptByARCDRDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSRptByARCDRDataSet : DataSet
	{
		public delegate void SelPACSRptByARCDRRowChangeEventHandler(object sender, EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelPACSRptByARCDRDataTable : DataTable, IEnumerable
		{
			private DataColumn columnItemName;

			private DataColumn columnOEOrdItemDR;

			private DataColumn columnRptRowID;

			private DataColumn columnRptContent;

			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowChangingEvent;

			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowChangedEvent;

			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowDeletingEvent;

			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowDeletedEvent;

			public event EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSRptByARCDRRowChangingEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSRptByARCDRRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSRptByARCDRRowChangingEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSRptByARCDRRowChangingEvent, value);
				}
			}

			public event EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSRptByARCDRRowChangedEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSRptByARCDRRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSRptByARCDRRowChangedEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSRptByARCDRRowChangedEvent, value);
				}
			}

			public event EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSRptByARCDRRowDeletingEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSRptByARCDRRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSRptByARCDRRowDeletingEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSRptByARCDRRowDeletingEvent, value);
				}
			}

			public event EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler SelPACSRptByARCDRRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelPACSRptByARCDRRowDeletedEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Combine(this.SelPACSRptByARCDRRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelPACSRptByARCDRRowDeletedEvent = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler)Delegate.Remove(this.SelPACSRptByARCDRRowDeletedEvent, value);
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

			[DebuggerNonUserCode]
			public DataColumn RptContentColumn
			{
				get
				{
					return this.columnRptContent;
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
			public EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow this[int index]
			{
				get
				{
					return (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelPACSRptByARCDRDataTable()
			{
				this.TableName = "SelPACSRptByARCDR";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelPACSRptByARCDRDataTable(DataTable table)
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
			protected SelPACSRptByARCDRDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelPACSRptByARCDRRow(EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow AddSelPACSRptByARCDRRow(string ItemName, string OEOrdItemDR, string RptRowID, string RptContent)
			{
				EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow selPACSRptByARCDRRow = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ItemName,
					OEOrdItemDR,
					RptRowID,
					RptContent
				};
				selPACSRptByARCDRRow.ItemArray = itemArray;
				this.Rows.Add(selPACSRptByARCDRRow);
				return selPACSRptByARCDRRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable selPACSRptByARCDRDataTable = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable)base.Clone();
				selPACSRptByARCDRDataTable.InitVars();
				return selPACSRptByARCDRDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnItemName = base.Columns["ItemName"];
				this.columnOEOrdItemDR = base.Columns["OEOrdItemDR"];
				this.columnRptRowID = base.Columns["RptRowID"];
				this.columnRptContent = base.Columns["RptContent"];
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
				this.columnRptContent = new DataColumn("RptContent", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRptContent);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow NewSelPACSRptByARCDRRow()
			{
				return (EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelPACSRptByARCDRRowChangedEvent != null)
				{
					EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler selPACSRptByARCDRRowChangedEvent = this.SelPACSRptByARCDRRowChangedEvent;
					if (selPACSRptByARCDRRowChangedEvent != null)
					{
						selPACSRptByARCDRRowChangedEvent(this, new EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEvent((EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelPACSRptByARCDRRowChangingEvent != null)
				{
					EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler selPACSRptByARCDRRowChangingEvent = this.SelPACSRptByARCDRRowChangingEvent;
					if (selPACSRptByARCDRRowChangingEvent != null)
					{
						selPACSRptByARCDRRowChangingEvent(this, new EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEvent((EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelPACSRptByARCDRRowDeletedEvent != null)
				{
					EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler selPACSRptByARCDRRowDeletedEvent = this.SelPACSRptByARCDRRowDeletedEvent;
					if (selPACSRptByARCDRRowDeletedEvent != null)
					{
						selPACSRptByARCDRRowDeletedEvent(this, new EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEvent((EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelPACSRptByARCDRRowDeletingEvent != null)
				{
					EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEventHandler selPACSRptByARCDRRowDeletingEvent = this.SelPACSRptByARCDRRowDeletingEvent;
					if (selPACSRptByARCDRRowDeletingEvent != null)
					{
						selPACSRptByARCDRRowDeletingEvent(this, new EPACSRptByARCDRDataSet.SelPACSRptByARCDRRowChangeEvent((EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelPACSRptByARCDRRow(EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSRptByARCDRDataSet ePACSRptByARCDRDataSet = new EPACSRptByARCDRDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSRptByARCDRDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelPACSRptByARCDRDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSRptByARCDRDataSet.GetSchemaSerializable();
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
		public class SelPACSRptByARCDRRow : DataRow
		{
			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable tableSelPACSRptByARCDR;

			[DebuggerNonUserCode]
			public string ItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelPACSRptByARCDR.ItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSRptByARCDR\"中列\"ItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSRptByARCDR.ItemNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelPACSRptByARCDR.OEOrdItemDRColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSRptByARCDR\"中列\"OEOrdItemDR\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSRptByARCDR.OEOrdItemDRColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelPACSRptByARCDR.RptRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSRptByARCDR\"中列\"RptRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSRptByARCDR.RptRowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string RptContent
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelPACSRptByARCDR.RptContentColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelPACSRptByARCDR\"中列\"RptContent\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelPACSRptByARCDR.RptContentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelPACSRptByARCDRRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelPACSRptByARCDR = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsItemNameNull()
			{
				return this.IsNull(this.tableSelPACSRptByARCDR.ItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemNameNull()
			{
				this[this.tableSelPACSRptByARCDR.ItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEOrdItemDRNull()
			{
				return this.IsNull(this.tableSelPACSRptByARCDR.OEOrdItemDRColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEOrdItemDRNull()
			{
				this[this.tableSelPACSRptByARCDR.OEOrdItemDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRptRowIDNull()
			{
				return this.IsNull(this.tableSelPACSRptByARCDR.RptRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetRptRowIDNull()
			{
				this[this.tableSelPACSRptByARCDR.RptRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRptContentNull()
			{
				return this.IsNull(this.tableSelPACSRptByARCDR.RptContentColumn);
			}

			[DebuggerNonUserCode]
			public void SetRptContentNull()
			{
				this[this.tableSelPACSRptByARCDR.RptContentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelPACSRptByARCDRRowChangeEvent : EventArgs
		{
			private EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow Row
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
			public SelPACSRptByARCDRRowChangeEvent(EPACSRptByARCDRDataSet.SelPACSRptByARCDRRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable tableSelPACSRptByARCDR;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable SelPACSRptByARCDR
		{
			get
			{
				return this.tableSelPACSRptByARCDR;
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
		public EPACSRptByARCDRDataSet()
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
		protected EPACSRptByARCDRDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelPACSRptByARCDR"] != null)
				{
					base.Tables.Add(new EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable(dataSet.Tables["SelPACSRptByARCDR"]));
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
			EPACSRptByARCDRDataSet ePACSRptByARCDRDataSet = (EPACSRptByARCDRDataSet)base.Clone();
			ePACSRptByARCDRDataSet.InitVars();
			ePACSRptByARCDRDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSRptByARCDRDataSet;
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
				if (dataSet.Tables["SelPACSRptByARCDR"] != null)
				{
					base.Tables.Add(new EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable(dataSet.Tables["SelPACSRptByARCDR"]));
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
			this.tableSelPACSRptByARCDR = (EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable)base.Tables["SelPACSRptByARCDR"];
			if (initTable && this.tableSelPACSRptByARCDR != null)
			{
				this.tableSelPACSRptByARCDR.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSRptByARCDRDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSRptByARCDRDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelPACSRptByARCDR = new EPACSRptByARCDRDataSet.SelPACSRptByARCDRDataTable();
			base.Tables.Add(this.tableSelPACSRptByARCDR);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelPACSRptByARCDR()
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
			EPACSRptByARCDRDataSet ePACSRptByARCDRDataSet = new EPACSRptByARCDRDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSRptByARCDRDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSRptByARCDRDataSet.GetSchemaSerializable();
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
