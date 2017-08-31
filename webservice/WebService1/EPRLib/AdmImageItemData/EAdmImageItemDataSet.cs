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

namespace AdmImageItemData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EAdmImageItemDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EAdmImageItemDataSet : DataSet
	{
		public delegate void GetByEpisodeIDRowChangeEventHandler(object sender, EAdmImageItemDataSet.GetByEpisodeIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetByEpisodeIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnCreateDate;

			private DataColumn columnCreateTime;

			private DataColumn columnStatus;

			private DataColumn columnIsPublish;

			private EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowChangingEvent;

			private EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowChangedEvent;

			private EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowDeletingEvent;

			private EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowDeletedEvent;

			public event EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByEpisodeIDRowChangingEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Combine(this.GetByEpisodeIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByEpisodeIDRowChangingEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Remove(this.GetByEpisodeIDRowChangingEvent, value);
				}
			}

			public event EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByEpisodeIDRowChangedEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Combine(this.GetByEpisodeIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByEpisodeIDRowChangedEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Remove(this.GetByEpisodeIDRowChangedEvent, value);
				}
			}

			public event EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByEpisodeIDRowDeletingEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Combine(this.GetByEpisodeIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByEpisodeIDRowDeletingEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Remove(this.GetByEpisodeIDRowDeletingEvent, value);
				}
			}

			public event EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler GetByEpisodeIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByEpisodeIDRowDeletedEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Combine(this.GetByEpisodeIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByEpisodeIDRowDeletedEvent = (EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler)Delegate.Remove(this.GetByEpisodeIDRowDeletedEvent, value);
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
			public DataColumn CreateDateColumn
			{
				get
				{
					return this.columnCreateDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CreateTimeColumn
			{
				get
				{
					return this.columnCreateTime;
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
			public EAdmImageItemDataSet.GetByEpisodeIDRow this[int index]
			{
				get
				{
					return (EAdmImageItemDataSet.GetByEpisodeIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetByEpisodeIDDataTable()
			{
				this.TableName = "GetByEpisodeID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetByEpisodeIDDataTable(DataTable table)
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
			protected GetByEpisodeIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetByEpisodeIDRow(EAdmImageItemDataSet.GetByEpisodeIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EAdmImageItemDataSet.GetByEpisodeIDRow AddGetByEpisodeIDRow(string ID, string Name, string Description, string CreateDate, string CreateTime, string Status, string IsPublish)
			{
				EAdmImageItemDataSet.GetByEpisodeIDRow getByEpisodeIDRow = (EAdmImageItemDataSet.GetByEpisodeIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					CreateDate,
					CreateTime,
					Status,
					IsPublish
				};
				getByEpisodeIDRow.ItemArray = itemArray;
				this.Rows.Add(getByEpisodeIDRow);
				return getByEpisodeIDRow;
			}

			[DebuggerNonUserCode]
			public EAdmImageItemDataSet.GetByEpisodeIDRow FindByID(string ID)
			{
				return (EAdmImageItemDataSet.GetByEpisodeIDRow)this.Rows.Find(new object[]
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
				EAdmImageItemDataSet.GetByEpisodeIDDataTable getByEpisodeIDDataTable = (EAdmImageItemDataSet.GetByEpisodeIDDataTable)base.Clone();
				getByEpisodeIDDataTable.InitVars();
				return getByEpisodeIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EAdmImageItemDataSet.GetByEpisodeIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnCreateDate = base.Columns["CreateDate"];
				this.columnCreateTime = base.Columns["CreateTime"];
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
				this.columnCreateDate = new DataColumn("CreateDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCreateDate);
				this.columnCreateTime = new DataColumn("CreateTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCreateTime);
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
			public EAdmImageItemDataSet.GetByEpisodeIDRow NewGetByEpisodeIDRow()
			{
				return (EAdmImageItemDataSet.GetByEpisodeIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EAdmImageItemDataSet.GetByEpisodeIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EAdmImageItemDataSet.GetByEpisodeIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetByEpisodeIDRowChangedEvent != null)
				{
					EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler getByEpisodeIDRowChangedEvent = this.GetByEpisodeIDRowChangedEvent;
					if (getByEpisodeIDRowChangedEvent != null)
					{
						getByEpisodeIDRowChangedEvent(this, new EAdmImageItemDataSet.GetByEpisodeIDRowChangeEvent((EAdmImageItemDataSet.GetByEpisodeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetByEpisodeIDRowChangingEvent != null)
				{
					EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler getByEpisodeIDRowChangingEvent = this.GetByEpisodeIDRowChangingEvent;
					if (getByEpisodeIDRowChangingEvent != null)
					{
						getByEpisodeIDRowChangingEvent(this, new EAdmImageItemDataSet.GetByEpisodeIDRowChangeEvent((EAdmImageItemDataSet.GetByEpisodeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetByEpisodeIDRowDeletedEvent != null)
				{
					EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler getByEpisodeIDRowDeletedEvent = this.GetByEpisodeIDRowDeletedEvent;
					if (getByEpisodeIDRowDeletedEvent != null)
					{
						getByEpisodeIDRowDeletedEvent(this, new EAdmImageItemDataSet.GetByEpisodeIDRowChangeEvent((EAdmImageItemDataSet.GetByEpisodeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetByEpisodeIDRowDeletingEvent != null)
				{
					EAdmImageItemDataSet.GetByEpisodeIDRowChangeEventHandler getByEpisodeIDRowDeletingEvent = this.GetByEpisodeIDRowDeletingEvent;
					if (getByEpisodeIDRowDeletingEvent != null)
					{
						getByEpisodeIDRowDeletingEvent(this, new EAdmImageItemDataSet.GetByEpisodeIDRowChangeEvent((EAdmImageItemDataSet.GetByEpisodeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetByEpisodeIDRow(EAdmImageItemDataSet.GetByEpisodeIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EAdmImageItemDataSet eAdmImageItemDataSet = new EAdmImageItemDataSet();
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
				xmlSchemaAttribute.FixedValue = eAdmImageItemDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetByEpisodeIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eAdmImageItemDataSet.GetSchemaSerializable();
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
		public class GetByEpisodeIDRow : DataRow
		{
			private EAdmImageItemDataSet.GetByEpisodeIDDataTable tableGetByEpisodeID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableGetByEpisodeID.IDColumn]);
				}
				set
				{
					this[this.tableGetByEpisodeID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByEpisodeID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByEpisodeID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CreateDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByEpisodeID.CreateDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"CreateDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.CreateDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CreateTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByEpisodeID.CreateTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"CreateTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.CreateTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByEpisodeID.StatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"Status\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.StatusColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByEpisodeID.IsPublishColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByEpisodeID\"中列\"IsPublish\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByEpisodeID.IsPublishColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetByEpisodeIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetByEpisodeID = (EAdmImageItemDataSet.GetByEpisodeIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetByEpisodeID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetByEpisodeID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCreateDateNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.CreateDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCreateDateNull()
			{
				this[this.tableGetByEpisodeID.CreateDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCreateTimeNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.CreateTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCreateTimeNull()
			{
				this[this.tableGetByEpisodeID.CreateTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsStatusNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.StatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetStatusNull()
			{
				this[this.tableGetByEpisodeID.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsPublishNull()
			{
				return this.IsNull(this.tableGetByEpisodeID.IsPublishColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsPublishNull()
			{
				this[this.tableGetByEpisodeID.IsPublishColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetByEpisodeIDRowChangeEvent : EventArgs
		{
			private EAdmImageItemDataSet.GetByEpisodeIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EAdmImageItemDataSet.GetByEpisodeIDRow Row
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
			public GetByEpisodeIDRowChangeEvent(EAdmImageItemDataSet.GetByEpisodeIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EAdmImageItemDataSet.GetByEpisodeIDDataTable tableGetByEpisodeID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EAdmImageItemDataSet.GetByEpisodeIDDataTable GetByEpisodeID
		{
			get
			{
				return this.tableGetByEpisodeID;
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
		public EAdmImageItemDataSet()
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
		protected EAdmImageItemDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetByEpisodeID"] != null)
				{
					base.Tables.Add(new EAdmImageItemDataSet.GetByEpisodeIDDataTable(dataSet.Tables["GetByEpisodeID"]));
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
			EAdmImageItemDataSet eAdmImageItemDataSet = (EAdmImageItemDataSet)base.Clone();
			eAdmImageItemDataSet.InitVars();
			eAdmImageItemDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eAdmImageItemDataSet;
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
				if (dataSet.Tables["GetByEpisodeID"] != null)
				{
					base.Tables.Add(new EAdmImageItemDataSet.GetByEpisodeIDDataTable(dataSet.Tables["GetByEpisodeID"]));
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
			this.tableGetByEpisodeID = (EAdmImageItemDataSet.GetByEpisodeIDDataTable)base.Tables["GetByEpisodeID"];
			if (initTable && this.tableGetByEpisodeID != null)
			{
				this.tableGetByEpisodeID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EAdmImageItemDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EAdmImageItemDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetByEpisodeID = new EAdmImageItemDataSet.GetByEpisodeIDDataTable();
			base.Tables.Add(this.tableGetByEpisodeID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetByEpisodeID()
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
			EAdmImageItemDataSet eAdmImageItemDataSet = new EAdmImageItemDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eAdmImageItemDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eAdmImageItemDataSet.GetSchemaSerializable();
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
