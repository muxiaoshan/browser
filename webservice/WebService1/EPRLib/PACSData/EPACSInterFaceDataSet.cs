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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSInterFaceDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSInterFaceDataSet : DataSet
	{
		public delegate void SelectPACSItemListByDateRowChangeEventHandler(object sender, EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectPACSItemListByDateDataTable : DataTable, IEnumerable
		{
			private DataColumn columnItemName;

			private DataColumn columnOEOrdItemDR;

			private DataColumn columnRptRowID;

			private EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowChangingEvent;

			private EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowChangedEvent;

			private EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowDeletingEvent;

			private EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowDeletedEvent;

			public event EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemListByDateRowChangingEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemListByDateRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemListByDateRowChangingEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemListByDateRowChangingEvent, value);
				}
			}

			public event EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemListByDateRowChangedEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemListByDateRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemListByDateRowChangedEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemListByDateRowChangedEvent, value);
				}
			}

			public event EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemListByDateRowDeletingEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemListByDateRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemListByDateRowDeletingEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemListByDateRowDeletingEvent, value);
				}
			}

			public event EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler SelectPACSItemListByDateRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemListByDateRowDeletedEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemListByDateRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemListByDateRowDeletedEvent = (EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemListByDateRowDeletedEvent, value);
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
			public EPACSInterFaceDataSet.SelectPACSItemListByDateRow this[int index]
			{
				get
				{
					return (EPACSInterFaceDataSet.SelectPACSItemListByDateRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectPACSItemListByDateDataTable()
			{
				this.TableName = "SelectPACSItemListByDate";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectPACSItemListByDateDataTable(DataTable table)
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
			protected SelectPACSItemListByDateDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectPACSItemListByDateRow(EPACSInterFaceDataSet.SelectPACSItemListByDateRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSInterFaceDataSet.SelectPACSItemListByDateRow AddSelectPACSItemListByDateRow(string ItemName, string OEOrdItemDR, string RptRowID)
			{
				EPACSInterFaceDataSet.SelectPACSItemListByDateRow selectPACSItemListByDateRow = (EPACSInterFaceDataSet.SelectPACSItemListByDateRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ItemName,
					OEOrdItemDR,
					RptRowID
				};
				selectPACSItemListByDateRow.ItemArray = itemArray;
				this.Rows.Add(selectPACSItemListByDateRow);
				return selectPACSItemListByDateRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable selectPACSItemListByDateDataTable = (EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable)base.Clone();
				selectPACSItemListByDateDataTable.InitVars();
				return selectPACSItemListByDateDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable();
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
			public EPACSInterFaceDataSet.SelectPACSItemListByDateRow NewSelectPACSItemListByDateRow()
			{
				return (EPACSInterFaceDataSet.SelectPACSItemListByDateRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSInterFaceDataSet.SelectPACSItemListByDateRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSInterFaceDataSet.SelectPACSItemListByDateRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectPACSItemListByDateRowChangedEvent != null)
				{
					EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler selectPACSItemListByDateRowChangedEvent = this.SelectPACSItemListByDateRowChangedEvent;
					if (selectPACSItemListByDateRowChangedEvent != null)
					{
						selectPACSItemListByDateRowChangedEvent(this, new EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEvent((EPACSInterFaceDataSet.SelectPACSItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectPACSItemListByDateRowChangingEvent != null)
				{
					EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler selectPACSItemListByDateRowChangingEvent = this.SelectPACSItemListByDateRowChangingEvent;
					if (selectPACSItemListByDateRowChangingEvent != null)
					{
						selectPACSItemListByDateRowChangingEvent(this, new EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEvent((EPACSInterFaceDataSet.SelectPACSItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectPACSItemListByDateRowDeletedEvent != null)
				{
					EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler selectPACSItemListByDateRowDeletedEvent = this.SelectPACSItemListByDateRowDeletedEvent;
					if (selectPACSItemListByDateRowDeletedEvent != null)
					{
						selectPACSItemListByDateRowDeletedEvent(this, new EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEvent((EPACSInterFaceDataSet.SelectPACSItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectPACSItemListByDateRowDeletingEvent != null)
				{
					EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEventHandler selectPACSItemListByDateRowDeletingEvent = this.SelectPACSItemListByDateRowDeletingEvent;
					if (selectPACSItemListByDateRowDeletingEvent != null)
					{
						selectPACSItemListByDateRowDeletingEvent(this, new EPACSInterFaceDataSet.SelectPACSItemListByDateRowChangeEvent((EPACSInterFaceDataSet.SelectPACSItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectPACSItemListByDateRow(EPACSInterFaceDataSet.SelectPACSItemListByDateRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSInterFaceDataSet ePACSInterFaceDataSet = new EPACSInterFaceDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSInterFaceDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectPACSItemListByDateDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSInterFaceDataSet.GetSchemaSerializable();
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
		public class SelectPACSItemListByDateRow : DataRow
		{
			private EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable tableSelectPACSItemListByDate;

			[DebuggerNonUserCode]
			public string ItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSItemListByDate.ItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSItemListByDate\"中列\"ItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSItemListByDate.ItemNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectPACSItemListByDate.OEOrdItemDRColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSItemListByDate\"中列\"OEOrdItemDR\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSItemListByDate.OEOrdItemDRColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectPACSItemListByDate.RptRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSItemListByDate\"中列\"RptRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSItemListByDate.RptRowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectPACSItemListByDateRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectPACSItemListByDate = (EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsItemNameNull()
			{
				return this.IsNull(this.tableSelectPACSItemListByDate.ItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemNameNull()
			{
				this[this.tableSelectPACSItemListByDate.ItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEOrdItemDRNull()
			{
				return this.IsNull(this.tableSelectPACSItemListByDate.OEOrdItemDRColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEOrdItemDRNull()
			{
				this[this.tableSelectPACSItemListByDate.OEOrdItemDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRptRowIDNull()
			{
				return this.IsNull(this.tableSelectPACSItemListByDate.RptRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetRptRowIDNull()
			{
				this[this.tableSelectPACSItemListByDate.RptRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectPACSItemListByDateRowChangeEvent : EventArgs
		{
			private EPACSInterFaceDataSet.SelectPACSItemListByDateRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSInterFaceDataSet.SelectPACSItemListByDateRow Row
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
			public SelectPACSItemListByDateRowChangeEvent(EPACSInterFaceDataSet.SelectPACSItemListByDateRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable tableSelectPACSItemListByDate;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable SelectPACSItemListByDate
		{
			get
			{
				return this.tableSelectPACSItemListByDate;
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
		public EPACSInterFaceDataSet()
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
		protected EPACSInterFaceDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectPACSItemListByDate"] != null)
				{
					base.Tables.Add(new EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable(dataSet.Tables["SelectPACSItemListByDate"]));
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
			EPACSInterFaceDataSet ePACSInterFaceDataSet = (EPACSInterFaceDataSet)base.Clone();
			ePACSInterFaceDataSet.InitVars();
			ePACSInterFaceDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSInterFaceDataSet;
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
				if (dataSet.Tables["SelectPACSItemListByDate"] != null)
				{
					base.Tables.Add(new EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable(dataSet.Tables["SelectPACSItemListByDate"]));
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
			this.tableSelectPACSItemListByDate = (EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable)base.Tables["SelectPACSItemListByDate"];
			if (initTable && this.tableSelectPACSItemListByDate != null)
			{
				this.tableSelectPACSItemListByDate.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSInterFaceDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSInterFaceDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectPACSItemListByDate = new EPACSInterFaceDataSet.SelectPACSItemListByDateDataTable();
			base.Tables.Add(this.tableSelectPACSItemListByDate);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectPACSItemListByDate()
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
			EPACSInterFaceDataSet ePACSInterFaceDataSet = new EPACSInterFaceDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSInterFaceDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSInterFaceDataSet.GetSchemaSerializable();
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
