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

namespace ImagePosData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EImagePositionDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EImagePositionDataset : DataSet
	{
		public delegate void SelectAllRowChangeEventHandler(object sender, EImagePositionDataset.SelectAllRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectAllDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowChangingEvent;

			private EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowChangedEvent;

			private EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowDeletingEvent;

			private EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowDeletedEvent;

			public event EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowChangingEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowChangingEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowChangingEvent, value);
				}
			}

			public event EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowChangedEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowChangedEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowChangedEvent, value);
				}
			}

			public event EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowDeletingEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowDeletingEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowDeletingEvent, value);
				}
			}

			public event EImagePositionDataset.SelectAllRowChangeEventHandler SelectAllRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllRowDeletedEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Combine(this.SelectAllRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllRowDeletedEvent = (EImagePositionDataset.SelectAllRowChangeEventHandler)Delegate.Remove(this.SelectAllRowDeletedEvent, value);
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
			public DataColumn CodeColumn
			{
				get
				{
					return this.columnCode;
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

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public EImagePositionDataset.SelectAllRow this[int index]
			{
				get
				{
					return (EImagePositionDataset.SelectAllRow)this.Rows[index];
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
			public void AddSelectAllRow(EImagePositionDataset.SelectAllRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EImagePositionDataset.SelectAllRow AddSelectAllRow(long ID, string Code, string Name, string Description)
			{
				EImagePositionDataset.SelectAllRow selectAllRow = (EImagePositionDataset.SelectAllRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Code,
					Name,
					Description
				};
				selectAllRow.ItemArray = itemArray;
				this.Rows.Add(selectAllRow);
				return selectAllRow;
			}

			[DebuggerNonUserCode]
			public EImagePositionDataset.SelectAllRow FindByID(long ID)
			{
				return (EImagePositionDataset.SelectAllRow)this.Rows.Find(new object[]
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
				EImagePositionDataset.SelectAllDataTable selectAllDataTable = (EImagePositionDataset.SelectAllDataTable)base.Clone();
				selectAllDataTable.InitVars();
				return selectAllDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EImagePositionDataset.SelectAllDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnCode = base.Columns["Code"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
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
			public EImagePositionDataset.SelectAllRow NewSelectAllRow()
			{
				return (EImagePositionDataset.SelectAllRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EImagePositionDataset.SelectAllRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EImagePositionDataset.SelectAllRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectAllRowChangedEvent != null)
				{
					EImagePositionDataset.SelectAllRowChangeEventHandler selectAllRowChangedEvent = this.SelectAllRowChangedEvent;
					if (selectAllRowChangedEvent != null)
					{
						selectAllRowChangedEvent(this, new EImagePositionDataset.SelectAllRowChangeEvent((EImagePositionDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectAllRowChangingEvent != null)
				{
					EImagePositionDataset.SelectAllRowChangeEventHandler selectAllRowChangingEvent = this.SelectAllRowChangingEvent;
					if (selectAllRowChangingEvent != null)
					{
						selectAllRowChangingEvent(this, new EImagePositionDataset.SelectAllRowChangeEvent((EImagePositionDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectAllRowDeletedEvent != null)
				{
					EImagePositionDataset.SelectAllRowChangeEventHandler selectAllRowDeletedEvent = this.SelectAllRowDeletedEvent;
					if (selectAllRowDeletedEvent != null)
					{
						selectAllRowDeletedEvent(this, new EImagePositionDataset.SelectAllRowChangeEvent((EImagePositionDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectAllRowDeletingEvent != null)
				{
					EImagePositionDataset.SelectAllRowChangeEventHandler selectAllRowDeletingEvent = this.SelectAllRowDeletingEvent;
					if (selectAllRowDeletingEvent != null)
					{
						selectAllRowDeletingEvent(this, new EImagePositionDataset.SelectAllRowChangeEvent((EImagePositionDataset.SelectAllRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectAllRow(EImagePositionDataset.SelectAllRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EImagePositionDataset eImagePositionDataset = new EImagePositionDataset();
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
				xmlSchemaAttribute.FixedValue = eImagePositionDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectAllDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eImagePositionDataset.GetSchemaSerializable();
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
			private EImagePositionDataset.SelectAllDataTable tableSelectAll;

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
			public string Code
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAll.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAll\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAll.CodeColumn] = value;
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
			internal SelectAllRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectAll = (EImagePositionDataset.SelectAllDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSelectAll.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSelectAll.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectAllRowChangeEvent : EventArgs
		{
			private EImagePositionDataset.SelectAllRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EImagePositionDataset.SelectAllRow Row
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
			public SelectAllRowChangeEvent(EImagePositionDataset.SelectAllRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EImagePositionDataset.SelectAllDataTable tableSelectAll;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EImagePositionDataset.SelectAllDataTable SelectAll
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
		public EImagePositionDataset()
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
		protected EImagePositionDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
					base.Tables.Add(new EImagePositionDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
			EImagePositionDataset eImagePositionDataset = (EImagePositionDataset)base.Clone();
			eImagePositionDataset.InitVars();
			eImagePositionDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eImagePositionDataset;
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
					base.Tables.Add(new EImagePositionDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
			this.tableSelectAll = (EImagePositionDataset.SelectAllDataTable)base.Tables["SelectAll"];
			if (initTable && this.tableSelectAll != null)
			{
				this.tableSelectAll.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EImagePositionDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EImagePositionDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectAll = new EImagePositionDataset.SelectAllDataTable();
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
			EImagePositionDataset eImagePositionDataset = new EImagePositionDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eImagePositionDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eImagePositionDataset.GetSchemaSerializable();
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
