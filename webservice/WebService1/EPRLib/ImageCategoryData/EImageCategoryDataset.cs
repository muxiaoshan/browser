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

namespace ImageCategoryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EImageCategoryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EImageCategoryDataset : DataSet
	{
		public delegate void GetAllImageCategoriesRowChangeEventHandler(object sender, EImageCategoryDataset.GetAllImageCategoriesRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetAllImageCategoriesDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnParentID;

			private DataColumn columnChildCount;

			private EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowChangingEvent;

			private EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowChangedEvent;

			private EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowDeletingEvent;

			private EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowDeletedEvent;

			public event EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetAllImageCategoriesRowChangingEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Combine(this.GetAllImageCategoriesRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetAllImageCategoriesRowChangingEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Remove(this.GetAllImageCategoriesRowChangingEvent, value);
				}
			}

			public event EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetAllImageCategoriesRowChangedEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Combine(this.GetAllImageCategoriesRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetAllImageCategoriesRowChangedEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Remove(this.GetAllImageCategoriesRowChangedEvent, value);
				}
			}

			public event EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetAllImageCategoriesRowDeletingEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Combine(this.GetAllImageCategoriesRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetAllImageCategoriesRowDeletingEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Remove(this.GetAllImageCategoriesRowDeletingEvent, value);
				}
			}

			public event EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler GetAllImageCategoriesRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetAllImageCategoriesRowDeletedEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Combine(this.GetAllImageCategoriesRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetAllImageCategoriesRowDeletedEvent = (EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler)Delegate.Remove(this.GetAllImageCategoriesRowDeletedEvent, value);
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
			public DataColumn ChildCountColumn
			{
				get
				{
					return this.columnChildCount;
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
			public EImageCategoryDataset.GetAllImageCategoriesRow this[int index]
			{
				get
				{
					return (EImageCategoryDataset.GetAllImageCategoriesRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetAllImageCategoriesDataTable()
			{
				this.TableName = "GetAllImageCategories";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetAllImageCategoriesDataTable(DataTable table)
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
			protected GetAllImageCategoriesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetAllImageCategoriesRow(EImageCategoryDataset.GetAllImageCategoriesRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EImageCategoryDataset.GetAllImageCategoriesRow AddGetAllImageCategoriesRow(long ID, string Name, string Description, string ParentID, long ChildCount)
			{
				EImageCategoryDataset.GetAllImageCategoriesRow getAllImageCategoriesRow = (EImageCategoryDataset.GetAllImageCategoriesRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					ParentID,
					ChildCount
				};
				getAllImageCategoriesRow.ItemArray = itemArray;
				this.Rows.Add(getAllImageCategoriesRow);
				return getAllImageCategoriesRow;
			}

			[DebuggerNonUserCode]
			public EImageCategoryDataset.GetAllImageCategoriesRow FindByID(long ID)
			{
				return (EImageCategoryDataset.GetAllImageCategoriesRow)this.Rows.Find(new object[]
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
				EImageCategoryDataset.GetAllImageCategoriesDataTable getAllImageCategoriesDataTable = (EImageCategoryDataset.GetAllImageCategoriesDataTable)base.Clone();
				getAllImageCategoriesDataTable.InitVars();
				return getAllImageCategoriesDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EImageCategoryDataset.GetAllImageCategoriesDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnParentID = base.Columns["ParentID"];
				this.columnChildCount = base.Columns["ChildCount"];
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
				this.columnChildCount = new DataColumn("ChildCount", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnChildCount);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EImageCategoryDataset.GetAllImageCategoriesRow NewGetAllImageCategoriesRow()
			{
				return (EImageCategoryDataset.GetAllImageCategoriesRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EImageCategoryDataset.GetAllImageCategoriesRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EImageCategoryDataset.GetAllImageCategoriesRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetAllImageCategoriesRowChangedEvent != null)
				{
					EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler getAllImageCategoriesRowChangedEvent = this.GetAllImageCategoriesRowChangedEvent;
					if (getAllImageCategoriesRowChangedEvent != null)
					{
						getAllImageCategoriesRowChangedEvent(this, new EImageCategoryDataset.GetAllImageCategoriesRowChangeEvent((EImageCategoryDataset.GetAllImageCategoriesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetAllImageCategoriesRowChangingEvent != null)
				{
					EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler getAllImageCategoriesRowChangingEvent = this.GetAllImageCategoriesRowChangingEvent;
					if (getAllImageCategoriesRowChangingEvent != null)
					{
						getAllImageCategoriesRowChangingEvent(this, new EImageCategoryDataset.GetAllImageCategoriesRowChangeEvent((EImageCategoryDataset.GetAllImageCategoriesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetAllImageCategoriesRowDeletedEvent != null)
				{
					EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler getAllImageCategoriesRowDeletedEvent = this.GetAllImageCategoriesRowDeletedEvent;
					if (getAllImageCategoriesRowDeletedEvent != null)
					{
						getAllImageCategoriesRowDeletedEvent(this, new EImageCategoryDataset.GetAllImageCategoriesRowChangeEvent((EImageCategoryDataset.GetAllImageCategoriesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetAllImageCategoriesRowDeletingEvent != null)
				{
					EImageCategoryDataset.GetAllImageCategoriesRowChangeEventHandler getAllImageCategoriesRowDeletingEvent = this.GetAllImageCategoriesRowDeletingEvent;
					if (getAllImageCategoriesRowDeletingEvent != null)
					{
						getAllImageCategoriesRowDeletingEvent(this, new EImageCategoryDataset.GetAllImageCategoriesRowChangeEvent((EImageCategoryDataset.GetAllImageCategoriesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetAllImageCategoriesRow(EImageCategoryDataset.GetAllImageCategoriesRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EImageCategoryDataset eImageCategoryDataset = new EImageCategoryDataset();
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
				xmlSchemaAttribute.FixedValue = eImageCategoryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetAllImageCategoriesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eImageCategoryDataset.GetSchemaSerializable();
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
		public class GetAllImageCategoriesRow : DataRow
		{
			private EImageCategoryDataset.GetAllImageCategoriesDataTable tableGetAllImageCategories;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableGetAllImageCategories.IDColumn]);
				}
				set
				{
					this[this.tableGetAllImageCategories.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetAllImageCategories.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetAllImageCategories\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetAllImageCategories.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetAllImageCategories.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetAllImageCategories\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetAllImageCategories.DescriptionColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetAllImageCategories.ParentIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetAllImageCategories\"中列\"ParentID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetAllImageCategories.ParentIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long ChildCount
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetAllImageCategories.ChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetAllImageCategories\"中列\"ChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetAllImageCategories.ChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetAllImageCategoriesRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetAllImageCategories = (EImageCategoryDataset.GetAllImageCategoriesDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetAllImageCategories.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetAllImageCategories.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetAllImageCategories.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetAllImageCategories.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParentIDNull()
			{
				return this.IsNull(this.tableGetAllImageCategories.ParentIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetParentIDNull()
			{
				this[this.tableGetAllImageCategories.ParentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsChildCountNull()
			{
				return this.IsNull(this.tableGetAllImageCategories.ChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetChildCountNull()
			{
				this[this.tableGetAllImageCategories.ChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetAllImageCategoriesRowChangeEvent : EventArgs
		{
			private EImageCategoryDataset.GetAllImageCategoriesRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EImageCategoryDataset.GetAllImageCategoriesRow Row
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
			public GetAllImageCategoriesRowChangeEvent(EImageCategoryDataset.GetAllImageCategoriesRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EImageCategoryDataset.GetAllImageCategoriesDataTable tableGetAllImageCategories;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EImageCategoryDataset.GetAllImageCategoriesDataTable GetAllImageCategories
		{
			get
			{
				return this.tableGetAllImageCategories;
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
		public EImageCategoryDataset()
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
		protected EImageCategoryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetAllImageCategories"] != null)
				{
					base.Tables.Add(new EImageCategoryDataset.GetAllImageCategoriesDataTable(dataSet.Tables["GetAllImageCategories"]));
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
			EImageCategoryDataset eImageCategoryDataset = (EImageCategoryDataset)base.Clone();
			eImageCategoryDataset.InitVars();
			eImageCategoryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eImageCategoryDataset;
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
				if (dataSet.Tables["GetAllImageCategories"] != null)
				{
					base.Tables.Add(new EImageCategoryDataset.GetAllImageCategoriesDataTable(dataSet.Tables["GetAllImageCategories"]));
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
			this.tableGetAllImageCategories = (EImageCategoryDataset.GetAllImageCategoriesDataTable)base.Tables["GetAllImageCategories"];
			if (initTable && this.tableGetAllImageCategories != null)
			{
				this.tableGetAllImageCategories.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EImageCategoryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EImageCategoryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetAllImageCategories = new EImageCategoryDataset.GetAllImageCategoriesDataTable();
			base.Tables.Add(this.tableGetAllImageCategories);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetAllImageCategories()
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
			EImageCategoryDataset eImageCategoryDataset = new EImageCategoryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eImageCategoryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eImageCategoryDataset.GetSchemaSerializable();
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
