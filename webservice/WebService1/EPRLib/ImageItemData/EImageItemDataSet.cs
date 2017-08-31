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

namespace ImageItemData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EImageItemDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EImageItemDataSet : DataSet
	{
		public delegate void GetByImageTreeIDRowChangeEventHandler(object sender, EImageItemDataSet.GetByImageTreeIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetByImageTreeIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnImageLibID;

			private DataColumn columnImageTreeID;

			private DataColumn columnStatus;

			private DataColumn columnIsPublish;

			private EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowChangingEvent;

			private EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowChangedEvent;

			private EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowDeletingEvent;

			private EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowDeletedEvent;

			public event EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageTreeIDRowChangingEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Combine(this.GetByImageTreeIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageTreeIDRowChangingEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Remove(this.GetByImageTreeIDRowChangingEvent, value);
				}
			}

			public event EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageTreeIDRowChangedEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Combine(this.GetByImageTreeIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageTreeIDRowChangedEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Remove(this.GetByImageTreeIDRowChangedEvent, value);
				}
			}

			public event EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageTreeIDRowDeletingEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Combine(this.GetByImageTreeIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageTreeIDRowDeletingEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Remove(this.GetByImageTreeIDRowDeletingEvent, value);
				}
			}

			public event EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler GetByImageTreeIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageTreeIDRowDeletedEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Combine(this.GetByImageTreeIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageTreeIDRowDeletedEvent = (EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler)Delegate.Remove(this.GetByImageTreeIDRowDeletedEvent, value);
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
			public DataColumn ImageLibIDColumn
			{
				get
				{
					return this.columnImageLibID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ImageTreeIDColumn
			{
				get
				{
					return this.columnImageTreeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn StatusColumn
			{
				get
				{
					return this.columnStatus;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn IsPublishColumn
			{
				get
				{
					return this.columnIsPublish;
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
			public EImageItemDataSet.GetByImageTreeIDRow this[int index]
			{
				get
				{
					return (EImageItemDataSet.GetByImageTreeIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetByImageTreeIDDataTable()
			{
				this.TableName = "GetByImageTreeID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetByImageTreeIDDataTable(DataTable table)
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
			protected GetByImageTreeIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetByImageTreeIDRow(EImageItemDataSet.GetByImageTreeIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EImageItemDataSet.GetByImageTreeIDRow AddGetByImageTreeIDRow(string ID, string Name, string Description, string ImageLibID, string ImageTreeID, string Status, string IsPublish)
			{
				EImageItemDataSet.GetByImageTreeIDRow getByImageTreeIDRow = (EImageItemDataSet.GetByImageTreeIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					ImageLibID,
					ImageTreeID,
					Status,
					IsPublish
				};
				getByImageTreeIDRow.ItemArray = itemArray;
				this.Rows.Add(getByImageTreeIDRow);
				return getByImageTreeIDRow;
			}

			[DebuggerNonUserCode]
			public EImageItemDataSet.GetByImageTreeIDRow FindByID(string ID)
			{
				return (EImageItemDataSet.GetByImageTreeIDRow)this.Rows.Find(new object[]
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
				EImageItemDataSet.GetByImageTreeIDDataTable getByImageTreeIDDataTable = (EImageItemDataSet.GetByImageTreeIDDataTable)base.Clone();
				getByImageTreeIDDataTable.InitVars();
				return getByImageTreeIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EImageItemDataSet.GetByImageTreeIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnImageLibID = base.Columns["ImageLibID"];
				this.columnImageTreeID = base.Columns["ImageTreeID"];
				this.columnStatus = base.Columns["Status"];
				this.columnIsPublish = base.Columns["IsPublish"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnImageLibID = new DataColumn("ImageLibID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnImageLibID);
				this.columnImageTreeID = new DataColumn("ImageTreeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnImageTreeID);
				this.columnStatus = new DataColumn("Status", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnStatus);
				this.columnIsPublish = new DataColumn("IsPublish", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIsPublish);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EImageItemDataSet.GetByImageTreeIDRow NewGetByImageTreeIDRow()
			{
				return (EImageItemDataSet.GetByImageTreeIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EImageItemDataSet.GetByImageTreeIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EImageItemDataSet.GetByImageTreeIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetByImageTreeIDRowChangedEvent != null)
				{
					EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler getByImageTreeIDRowChangedEvent = this.GetByImageTreeIDRowChangedEvent;
					if (getByImageTreeIDRowChangedEvent != null)
					{
						getByImageTreeIDRowChangedEvent(this, new EImageItemDataSet.GetByImageTreeIDRowChangeEvent((EImageItemDataSet.GetByImageTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetByImageTreeIDRowChangingEvent != null)
				{
					EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler getByImageTreeIDRowChangingEvent = this.GetByImageTreeIDRowChangingEvent;
					if (getByImageTreeIDRowChangingEvent != null)
					{
						getByImageTreeIDRowChangingEvent(this, new EImageItemDataSet.GetByImageTreeIDRowChangeEvent((EImageItemDataSet.GetByImageTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetByImageTreeIDRowDeletedEvent != null)
				{
					EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler getByImageTreeIDRowDeletedEvent = this.GetByImageTreeIDRowDeletedEvent;
					if (getByImageTreeIDRowDeletedEvent != null)
					{
						getByImageTreeIDRowDeletedEvent(this, new EImageItemDataSet.GetByImageTreeIDRowChangeEvent((EImageItemDataSet.GetByImageTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetByImageTreeIDRowDeletingEvent != null)
				{
					EImageItemDataSet.GetByImageTreeIDRowChangeEventHandler getByImageTreeIDRowDeletingEvent = this.GetByImageTreeIDRowDeletingEvent;
					if (getByImageTreeIDRowDeletingEvent != null)
					{
						getByImageTreeIDRowDeletingEvent(this, new EImageItemDataSet.GetByImageTreeIDRowChangeEvent((EImageItemDataSet.GetByImageTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetByImageTreeIDRow(EImageItemDataSet.GetByImageTreeIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EImageItemDataSet eImageItemDataSet = new EImageItemDataSet();
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
				xmlSchemaAttribute.FixedValue = eImageItemDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetByImageTreeIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eImageItemDataSet.GetSchemaSerializable();
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
		public class GetByImageTreeIDRow : DataRow
		{
			private EImageItemDataSet.GetByImageTreeIDDataTable tableGetByImageTreeID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableGetByImageTreeID.IDColumn]);
				}
				set
				{
					this[this.tableGetByImageTreeID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageTreeID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageTreeID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ImageLibID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageTreeID.ImageLibIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"ImageLibID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.ImageLibIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ImageTreeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageTreeID.ImageTreeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"ImageTreeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.ImageTreeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Status
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageTreeID.StatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"Status\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.StatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string IsPublish
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageTreeID.IsPublishColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageTreeID\"中列\"IsPublish\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageTreeID.IsPublishColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetByImageTreeIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetByImageTreeID = (EImageItemDataSet.GetByImageTreeIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetByImageTreeID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetByImageTreeID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsImageLibIDNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.ImageLibIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetImageLibIDNull()
			{
				this[this.tableGetByImageTreeID.ImageLibIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsImageTreeIDNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.ImageTreeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetImageTreeIDNull()
			{
				this[this.tableGetByImageTreeID.ImageTreeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsStatusNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.StatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetStatusNull()
			{
				this[this.tableGetByImageTreeID.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsPublishNull()
			{
				return this.IsNull(this.tableGetByImageTreeID.IsPublishColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsPublishNull()
			{
				this[this.tableGetByImageTreeID.IsPublishColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetByImageTreeIDRowChangeEvent : EventArgs
		{
			private EImageItemDataSet.GetByImageTreeIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EImageItemDataSet.GetByImageTreeIDRow Row
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
			public GetByImageTreeIDRowChangeEvent(EImageItemDataSet.GetByImageTreeIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EImageItemDataSet.GetByImageTreeIDDataTable tableGetByImageTreeID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EImageItemDataSet.GetByImageTreeIDDataTable GetByImageTreeID
		{
			get
			{
				return this.tableGetByImageTreeID;
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
		public EImageItemDataSet()
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
		protected EImageItemDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetByImageTreeID"] != null)
				{
					base.Tables.Add(new EImageItemDataSet.GetByImageTreeIDDataTable(dataSet.Tables["GetByImageTreeID"]));
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
			EImageItemDataSet eImageItemDataSet = (EImageItemDataSet)base.Clone();
			eImageItemDataSet.InitVars();
			eImageItemDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eImageItemDataSet;
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
				if (dataSet.Tables["GetByImageTreeID"] != null)
				{
					base.Tables.Add(new EImageItemDataSet.GetByImageTreeIDDataTable(dataSet.Tables["GetByImageTreeID"]));
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
			this.tableGetByImageTreeID = (EImageItemDataSet.GetByImageTreeIDDataTable)base.Tables["GetByImageTreeID"];
			if (initTable && this.tableGetByImageTreeID != null)
			{
				this.tableGetByImageTreeID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EImageItemDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EImageItemDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetByImageTreeID = new EImageItemDataSet.GetByImageTreeIDDataTable();
			base.Tables.Add(this.tableGetByImageTreeID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetByImageTreeID()
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
			EImageItemDataSet eImageItemDataSet = new EImageItemDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eImageItemDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eImageItemDataSet.GetSchemaSerializable();
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
