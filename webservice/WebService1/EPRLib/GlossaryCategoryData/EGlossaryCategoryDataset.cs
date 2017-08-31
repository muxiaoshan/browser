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

namespace GlossaryCategoryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EGlossaryCategoryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EGlossaryCategoryDataset : DataSet
	{
		public delegate void SelectAllRowChangeEventHandler(object sender, EGlossaryCategoryDataset.SelectAllRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectAllDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnParentID;

			private DataColumn columnResChildCount;

			private DataColumn columnInternalID;

			private EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowChangingEvent;

			private EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowChangedEvent;

			private EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowDeletingEvent;

			private EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowDeletedEvent;

			public event EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowChangingEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowChangingEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowChangingEvent, value);
				}
			}

			public event EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowChangedEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowChangedEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowChangedEvent, value);
				}
			}

			public event EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowDeletingEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowDeletingEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowDeletingEvent, value);
				}
			}

			public event EGlossaryCategoryDataset.SelectAllRowChangeEventHandler SelectAllRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowDeletedEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowDeletedEvent = (EGlossaryCategoryDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowDeletedEvent, value);
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
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ParentIDColumn
			{
				get
				{
					return this.columnParentID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ResChildCountColumn
			{
				get
				{
					return this.columnResChildCount;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn InternalIDColumn
			{
				get
				{
					return this.columnInternalID;
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
			public EGlossaryCategoryDataset.SelectAllRow this[int index]
			{
				get
				{
					return (EGlossaryCategoryDataset.SelectAllRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectAllDataTable()
			{
				this.TableName = "SelectAll";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectAllDataTable(DataTable table)
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
			protected SelectAllDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectAllRow(EGlossaryCategoryDataset.SelectAllRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EGlossaryCategoryDataset.SelectAllRow AddSelectAllRow(long ID, string Name, string Description, string ParentID, long ResChildCount, string InternalID)
			{
				EGlossaryCategoryDataset.SelectAllRow selectAllRow = (EGlossaryCategoryDataset.SelectAllRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					ParentID,
					ResChildCount,
					InternalID
				};
				selectAllRow.ItemArray = itemArray;
				this.Rows.Add(selectAllRow);
				return selectAllRow;
			}

			[DebuggerNonUserCode]
			public EGlossaryCategoryDataset.SelectAllRow FindByID(long ID)
			{
				return (EGlossaryCategoryDataset.SelectAllRow)this.Rows.Find(new object[]
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
				EGlossaryCategoryDataset.SelectAllDataTable selectAllDataTable = (EGlossaryCategoryDataset.SelectAllDataTable)base.Clone();
				selectAllDataTable.InitVars();
				return selectAllDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EGlossaryCategoryDataset.SelectAllDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnParentID = base.Columns["ParentID"];
				this.columnResChildCount = base.Columns["ResChildCount"];
				this.columnInternalID = base.Columns["InternalID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnParentID = new DataColumn("ParentID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentID);
				this.columnResChildCount = new DataColumn("ResChildCount", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnResChildCount);
				this.columnInternalID = new DataColumn("InternalID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInternalID);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EGlossaryCategoryDataset.SelectAllRow NewSelectAllRow()
			{
				return (EGlossaryCategoryDataset.SelectAllRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EGlossaryCategoryDataset.SelectAllRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EGlossaryCategoryDataset.SelectAllRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectAllRowChangedEvent != null)
				{
					EGlossaryCategoryDataset.SelectAllRowChangeEventHandler selectAllRowChangedEvent = this.SelectAllRowChangedEvent;
					if (selectAllRowChangedEvent != null)
					{
						selectAllRowChangedEvent(this, new EGlossaryCategoryDataset.SelectAllRowChangeEvent((EGlossaryCategoryDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectAllRowChangingEvent != null)
				{
					EGlossaryCategoryDataset.SelectAllRowChangeEventHandler selectAllRowChangingEvent = this.SelectAllRowChangingEvent;
					if (selectAllRowChangingEvent != null)
					{
						selectAllRowChangingEvent(this, new EGlossaryCategoryDataset.SelectAllRowChangeEvent((EGlossaryCategoryDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectAllRowDeletedEvent != null)
				{
					EGlossaryCategoryDataset.SelectAllRowChangeEventHandler selectAllRowDeletedEvent = this.SelectAllRowDeletedEvent;
					if (selectAllRowDeletedEvent != null)
					{
						selectAllRowDeletedEvent(this, new EGlossaryCategoryDataset.SelectAllRowChangeEvent((EGlossaryCategoryDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectAllRowDeletingEvent != null)
				{
					EGlossaryCategoryDataset.SelectAllRowChangeEventHandler selectAllRowDeletingEvent = this.SelectAllRowDeletingEvent;
					if (selectAllRowDeletingEvent != null)
					{
						selectAllRowDeletingEvent(this, new EGlossaryCategoryDataset.SelectAllRowChangeEvent((EGlossaryCategoryDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectAllRow(EGlossaryCategoryDataset.SelectAllRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EGlossaryCategoryDataset eGlossaryCategoryDataset = new EGlossaryCategoryDataset();
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
				xmlSchemaAttribute.FixedValue = eGlossaryCategoryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectAllDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eGlossaryCategoryDataset.GetSchemaSerializable();
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
		public class SelectAllRow : DataRow
		{
			private EGlossaryCategoryDataset.SelectAllDataTable tableSelectAll;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSelectAll.IDColumn]);
				}
				set
				{
					this[this.tableSelectAll.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectAll.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectAll.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ParentID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAll.ParentIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"ParentID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.ParentIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long ResChildCount
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSelectAll.ResChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"ResChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.ResChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string InternalID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAll.InternalIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"InternalID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.InternalIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectAllRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectAll = (EGlossaryCategoryDataset.SelectAllDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectAll.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectAll.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectAll.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectAll.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParentIDNull()
			{
				return this.IsNull(this.tableSelectAll.ParentIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetParentIDNull()
			{
				this[this.tableSelectAll.ParentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsResChildCountNull()
			{
				return this.IsNull(this.tableSelectAll.ResChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetResChildCountNull()
			{
				this[this.tableSelectAll.ResChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsInternalIDNull()
			{
				return this.IsNull(this.tableSelectAll.InternalIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetInternalIDNull()
			{
				this[this.tableSelectAll.InternalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectAllRowChangeEvent : EventArgs
		{
			private EGlossaryCategoryDataset.SelectAllRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EGlossaryCategoryDataset.SelectAllRow Row
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
			public SelectAllRowChangeEvent(EGlossaryCategoryDataset.SelectAllRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EGlossaryCategoryDataset.SelectAllDataTable tableSelectAll;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EGlossaryCategoryDataset.SelectAllDataTable SelectAll
		{
			get
			{
				return this.tableSelectAll;
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
		public EGlossaryCategoryDataset()
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
		protected EGlossaryCategoryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectAll"] != null)
				{
					base.Tables.Add(new EGlossaryCategoryDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
			EGlossaryCategoryDataset eGlossaryCategoryDataset = (EGlossaryCategoryDataset)base.Clone();
			eGlossaryCategoryDataset.InitVars();
			eGlossaryCategoryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eGlossaryCategoryDataset;
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
				if (dataSet.Tables["SelectAll"] != null)
				{
					base.Tables.Add(new EGlossaryCategoryDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
			this.tableSelectAll = (EGlossaryCategoryDataset.SelectAllDataTable)base.Tables["SelectAll"];
			if (initTable && this.tableSelectAll != null)
			{
				this.tableSelectAll.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EGlossaryCategoryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EGlossaryCategoryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectAll = new EGlossaryCategoryDataset.SelectAllDataTable();
			base.Tables.Add(this.tableSelectAll);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectAll()
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
			EGlossaryCategoryDataset eGlossaryCategoryDataset = new EGlossaryCategoryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eGlossaryCategoryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eGlossaryCategoryDataset.GetSchemaSerializable();
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
