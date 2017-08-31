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

namespace BindQueryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EBindFieldDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EBindFieldDataset : DataSet
	{
		public delegate void SelectFieldByQIDRowChangeEventHandler(object sender, EBindFieldDataset.SelectFieldByQIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectFieldByQIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnQueryID;

			private DataColumn columnFieldName;

			private DataColumn columnFieldType;

			private DataColumn columnDescription;

			private EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowChangingEvent;

			private EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowChangedEvent;

			private EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowDeletingEvent;

			private EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowDeletedEvent;

			public event EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectFieldByQIDRowChangingEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Combine(this.SelectFieldByQIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectFieldByQIDRowChangingEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Remove(this.SelectFieldByQIDRowChangingEvent, value);
				}
			}

			public event EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectFieldByQIDRowChangedEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Combine(this.SelectFieldByQIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectFieldByQIDRowChangedEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Remove(this.SelectFieldByQIDRowChangedEvent, value);
				}
			}

			public event EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectFieldByQIDRowDeletingEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Combine(this.SelectFieldByQIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectFieldByQIDRowDeletingEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Remove(this.SelectFieldByQIDRowDeletingEvent, value);
				}
			}

			public event EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler SelectFieldByQIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectFieldByQIDRowDeletedEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Combine(this.SelectFieldByQIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectFieldByQIDRowDeletedEvent = (EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler)Delegate.Remove(this.SelectFieldByQIDRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn QueryIDColumn
			{
				get
				{
					return this.columnQueryID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn FieldNameColumn
			{
				get
				{
					return this.columnFieldName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn FieldTypeColumn
			{
				get
				{
					return this.columnFieldType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
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
			public EBindFieldDataset.SelectFieldByQIDRow this[int index]
			{
				get
				{
					return (EBindFieldDataset.SelectFieldByQIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectFieldByQIDDataTable()
			{
				this.TableName = "SelectFieldByQID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectFieldByQIDDataTable(DataTable table)
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
			protected SelectFieldByQIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectFieldByQIDRow(EBindFieldDataset.SelectFieldByQIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EBindFieldDataset.SelectFieldByQIDRow AddSelectFieldByQIDRow(string ID, string Name, string QueryID, string FieldName, string FieldType, string Description)
			{
				EBindFieldDataset.SelectFieldByQIDRow selectFieldByQIDRow = (EBindFieldDataset.SelectFieldByQIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					QueryID,
					FieldName,
					FieldType,
					Description
				};
				selectFieldByQIDRow.ItemArray = itemArray;
				this.Rows.Add(selectFieldByQIDRow);
				return selectFieldByQIDRow;
			}

			[DebuggerNonUserCode]
			public EBindFieldDataset.SelectFieldByQIDRow FindByID(string ID)
			{
				return (EBindFieldDataset.SelectFieldByQIDRow)this.Rows.Find(new object[]
				{
					ID
				});
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EBindFieldDataset.SelectFieldByQIDDataTable selectFieldByQIDDataTable = (EBindFieldDataset.SelectFieldByQIDDataTable)base.Clone();
				selectFieldByQIDDataTable.InitVars();
				return selectFieldByQIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EBindFieldDataset.SelectFieldByQIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnQueryID = base.Columns["QueryID"];
				this.columnFieldName = base.Columns["FieldName"];
				this.columnFieldType = base.Columns["FieldType"];
				this.columnDescription = base.Columns["Description"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnQueryID = new DataColumn("QueryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnQueryID);
				this.columnFieldName = new DataColumn("FieldName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFieldName);
				this.columnFieldType = new DataColumn("FieldType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFieldType);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EBindFieldDataset.SelectFieldByQIDRow NewSelectFieldByQIDRow()
			{
				return (EBindFieldDataset.SelectFieldByQIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EBindFieldDataset.SelectFieldByQIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EBindFieldDataset.SelectFieldByQIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectFieldByQIDRowChangedEvent != null)
				{
					EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler selectFieldByQIDRowChangedEvent = this.SelectFieldByQIDRowChangedEvent;
					if (selectFieldByQIDRowChangedEvent != null)
					{
						selectFieldByQIDRowChangedEvent(this, new EBindFieldDataset.SelectFieldByQIDRowChangeEvent((EBindFieldDataset.SelectFieldByQIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectFieldByQIDRowChangingEvent != null)
				{
					EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler selectFieldByQIDRowChangingEvent = this.SelectFieldByQIDRowChangingEvent;
					if (selectFieldByQIDRowChangingEvent != null)
					{
						selectFieldByQIDRowChangingEvent(this, new EBindFieldDataset.SelectFieldByQIDRowChangeEvent((EBindFieldDataset.SelectFieldByQIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectFieldByQIDRowDeletedEvent != null)
				{
					EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler selectFieldByQIDRowDeletedEvent = this.SelectFieldByQIDRowDeletedEvent;
					if (selectFieldByQIDRowDeletedEvent != null)
					{
						selectFieldByQIDRowDeletedEvent(this, new EBindFieldDataset.SelectFieldByQIDRowChangeEvent((EBindFieldDataset.SelectFieldByQIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectFieldByQIDRowDeletingEvent != null)
				{
					EBindFieldDataset.SelectFieldByQIDRowChangeEventHandler selectFieldByQIDRowDeletingEvent = this.SelectFieldByQIDRowDeletingEvent;
					if (selectFieldByQIDRowDeletingEvent != null)
					{
						selectFieldByQIDRowDeletingEvent(this, new EBindFieldDataset.SelectFieldByQIDRowChangeEvent((EBindFieldDataset.SelectFieldByQIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectFieldByQIDRow(EBindFieldDataset.SelectFieldByQIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EBindFieldDataset eBindFieldDataset = new EBindFieldDataset();
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
				xmlSchemaAttribute.FixedValue = eBindFieldDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectFieldByQIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eBindFieldDataset.GetSchemaSerializable();
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
		public class SelectFieldByQIDRow : DataRow
		{
			private EBindFieldDataset.SelectFieldByQIDDataTable tableSelectFieldByQID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableSelectFieldByQID.IDColumn]);
				}
				set
				{
					this[this.tableSelectFieldByQID.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectFieldByQID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectFieldByQID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectFieldByQID.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string QueryID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectFieldByQID.QueryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectFieldByQID\"中列\"QueryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectFieldByQID.QueryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string FieldName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectFieldByQID.FieldNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectFieldByQID\"中列\"FieldName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectFieldByQID.FieldNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string FieldType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectFieldByQID.FieldTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectFieldByQID\"中列\"FieldType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectFieldByQID.FieldTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Description
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectFieldByQID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectFieldByQID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectFieldByQID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectFieldByQIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectFieldByQID = (EBindFieldDataset.SelectFieldByQIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectFieldByQID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectFieldByQID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsQueryIDNull()
			{
				return this.IsNull(this.tableSelectFieldByQID.QueryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetQueryIDNull()
			{
				this[this.tableSelectFieldByQID.QueryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsFieldNameNull()
			{
				return this.IsNull(this.tableSelectFieldByQID.FieldNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetFieldNameNull()
			{
				this[this.tableSelectFieldByQID.FieldNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsFieldTypeNull()
			{
				return this.IsNull(this.tableSelectFieldByQID.FieldTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetFieldTypeNull()
			{
				this[this.tableSelectFieldByQID.FieldTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectFieldByQID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectFieldByQID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectFieldByQIDRowChangeEvent : EventArgs
		{
			private EBindFieldDataset.SelectFieldByQIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EBindFieldDataset.SelectFieldByQIDRow Row
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
			public SelectFieldByQIDRowChangeEvent(EBindFieldDataset.SelectFieldByQIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EBindFieldDataset.SelectFieldByQIDDataTable tableSelectFieldByQID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EBindFieldDataset.SelectFieldByQIDDataTable SelectFieldByQID
		{
			get
			{
				return this.tableSelectFieldByQID;
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
		public EBindFieldDataset()
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
		protected EBindFieldDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectFieldByQID"] != null)
				{
					base.Tables.Add(new EBindFieldDataset.SelectFieldByQIDDataTable(dataSet.Tables["SelectFieldByQID"]));
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
			EBindFieldDataset eBindFieldDataset = (EBindFieldDataset)base.Clone();
			eBindFieldDataset.InitVars();
			eBindFieldDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eBindFieldDataset;
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
				if (dataSet.Tables["SelectFieldByQID"] != null)
				{
					base.Tables.Add(new EBindFieldDataset.SelectFieldByQIDDataTable(dataSet.Tables["SelectFieldByQID"]));
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
			this.tableSelectFieldByQID = (EBindFieldDataset.SelectFieldByQIDDataTable)base.Tables["SelectFieldByQID"];
			if (initTable && this.tableSelectFieldByQID != null)
			{
				this.tableSelectFieldByQID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EBindFieldDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EBindFieldDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectFieldByQID = new EBindFieldDataset.SelectFieldByQIDDataTable();
			base.Tables.Add(this.tableSelectFieldByQID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectFieldByQID()
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
			EBindFieldDataset eBindFieldDataset = new EBindFieldDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eBindFieldDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eBindFieldDataset.GetSchemaSerializable();
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
