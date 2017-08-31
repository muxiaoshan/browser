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

namespace GlossaryItemData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EGlossaryItemDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EGlossaryItemDataset : DataSet
	{
		public delegate void GetItemsByIDRowChangeEventHandler(object sender, EGlossaryItemDataset.GetItemsByIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetItemsByIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnGlossaryID;

			private DataColumn columnTemplateID;

			private DataColumn columnItemName;

			private DataColumn columnItemCode;

			private DataColumn columnValueType;

			private EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowChangingEvent;

			private EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowChangedEvent;

			private EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowDeletingEvent;

			private EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowDeletedEvent;

			public event EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetItemsByIDRowChangingEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetItemsByIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetItemsByIDRowChangingEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetItemsByIDRowChangingEvent, value);
				}
			}

			public event EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetItemsByIDRowChangedEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetItemsByIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetItemsByIDRowChangedEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetItemsByIDRowChangedEvent, value);
				}
			}

			public event EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetItemsByIDRowDeletingEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetItemsByIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetItemsByIDRowDeletingEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetItemsByIDRowDeletingEvent, value);
				}
			}

			public event EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler GetItemsByIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetItemsByIDRowDeletedEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetItemsByIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetItemsByIDRowDeletedEvent = (EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetItemsByIDRowDeletedEvent, value);
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
			public DataColumn GlossaryIDColumn
			{
				get
				{
					return this.columnGlossaryID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TemplateIDColumn
			{
				get
				{
					return this.columnTemplateID;
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
			public DataColumn ItemCodeColumn
			{
				get
				{
					return this.columnItemCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ValueTypeColumn
			{
				get
				{
					return this.columnValueType;
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
			public EGlossaryItemDataset.GetItemsByIDRow this[int index]
			{
				get
				{
					return (EGlossaryItemDataset.GetItemsByIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetItemsByIDDataTable()
			{
				this.TableName = "GetItemsByID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetItemsByIDDataTable(DataTable table)
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
			protected GetItemsByIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetItemsByIDRow(EGlossaryItemDataset.GetItemsByIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EGlossaryItemDataset.GetItemsByIDRow AddGetItemsByIDRow(long ID, long GlossaryID, long TemplateID, string ItemName, string ItemCode, string ValueType)
			{
				EGlossaryItemDataset.GetItemsByIDRow getItemsByIDRow = (EGlossaryItemDataset.GetItemsByIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					GlossaryID,
					TemplateID,
					ItemName,
					ItemCode,
					ValueType
				};
				getItemsByIDRow.ItemArray = itemArray;
				this.Rows.Add(getItemsByIDRow);
				return getItemsByIDRow;
			}

			[DebuggerNonUserCode]
			public EGlossaryItemDataset.GetItemsByIDRow FindByID(long ID)
			{
				return (EGlossaryItemDataset.GetItemsByIDRow)this.Rows.Find(new object[]
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
				EGlossaryItemDataset.GetItemsByIDDataTable getItemsByIDDataTable = (EGlossaryItemDataset.GetItemsByIDDataTable)base.Clone();
				getItemsByIDDataTable.InitVars();
				return getItemsByIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EGlossaryItemDataset.GetItemsByIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnGlossaryID = base.Columns["GlossaryID"];
				this.columnTemplateID = base.Columns["TemplateID"];
				this.columnItemName = base.Columns["ItemName"];
				this.columnItemCode = base.Columns["ItemCode"];
				this.columnValueType = base.Columns["ValueType"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnGlossaryID = new DataColumn("GlossaryID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnGlossaryID);
				this.columnTemplateID = new DataColumn("TemplateID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateID);
				this.columnItemName = new DataColumn("ItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemName);
				this.columnItemCode = new DataColumn("ItemCode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemCode);
				this.columnValueType = new DataColumn("ValueType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValueType);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EGlossaryItemDataset.GetItemsByIDRow NewGetItemsByIDRow()
			{
				return (EGlossaryItemDataset.GetItemsByIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EGlossaryItemDataset.GetItemsByIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EGlossaryItemDataset.GetItemsByIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetItemsByIDRowChangedEvent != null)
				{
					EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler getItemsByIDRowChangedEvent = this.GetItemsByIDRowChangedEvent;
					if (getItemsByIDRowChangedEvent != null)
					{
						getItemsByIDRowChangedEvent(this, new EGlossaryItemDataset.GetItemsByIDRowChangeEvent((EGlossaryItemDataset.GetItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetItemsByIDRowChangingEvent != null)
				{
					EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler getItemsByIDRowChangingEvent = this.GetItemsByIDRowChangingEvent;
					if (getItemsByIDRowChangingEvent != null)
					{
						getItemsByIDRowChangingEvent(this, new EGlossaryItemDataset.GetItemsByIDRowChangeEvent((EGlossaryItemDataset.GetItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetItemsByIDRowDeletedEvent != null)
				{
					EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler getItemsByIDRowDeletedEvent = this.GetItemsByIDRowDeletedEvent;
					if (getItemsByIDRowDeletedEvent != null)
					{
						getItemsByIDRowDeletedEvent(this, new EGlossaryItemDataset.GetItemsByIDRowChangeEvent((EGlossaryItemDataset.GetItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetItemsByIDRowDeletingEvent != null)
				{
					EGlossaryItemDataset.GetItemsByIDRowChangeEventHandler getItemsByIDRowDeletingEvent = this.GetItemsByIDRowDeletingEvent;
					if (getItemsByIDRowDeletingEvent != null)
					{
						getItemsByIDRowDeletingEvent(this, new EGlossaryItemDataset.GetItemsByIDRowChangeEvent((EGlossaryItemDataset.GetItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetItemsByIDRow(EGlossaryItemDataset.GetItemsByIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EGlossaryItemDataset eGlossaryItemDataset = new EGlossaryItemDataset();
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
				xmlSchemaAttribute.FixedValue = eGlossaryItemDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetItemsByIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eGlossaryItemDataset.GetSchemaSerializable();
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
		public class GetItemsByIDRow : DataRow
		{
			private EGlossaryItemDataset.GetItemsByIDDataTable tableGetItemsByID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableGetItemsByID.IDColumn]);
				}
				set
				{
					this[this.tableGetItemsByID.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long GlossaryID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetItemsByID.GlossaryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetItemsByID\"中列\"GlossaryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetItemsByID.GlossaryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long TemplateID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetItemsByID.TemplateIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetItemsByID\"中列\"TemplateID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetItemsByID.TemplateIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetItemsByID.ItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetItemsByID\"中列\"ItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetItemsByID.ItemNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemCode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetItemsByID.ItemCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetItemsByID\"中列\"ItemCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetItemsByID.ItemCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ValueType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetItemsByID.ValueTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetItemsByID\"中列\"ValueType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetItemsByID.ValueTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetItemsByIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetItemsByID = (EGlossaryItemDataset.GetItemsByIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryIDNull()
			{
				return this.IsNull(this.tableGetItemsByID.GlossaryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryIDNull()
			{
				this[this.tableGetItemsByID.GlossaryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTemplateIDNull()
			{
				return this.IsNull(this.tableGetItemsByID.TemplateIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplateIDNull()
			{
				this[this.tableGetItemsByID.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemNameNull()
			{
				return this.IsNull(this.tableGetItemsByID.ItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemNameNull()
			{
				this[this.tableGetItemsByID.ItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemCodeNull()
			{
				return this.IsNull(this.tableGetItemsByID.ItemCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemCodeNull()
			{
				this[this.tableGetItemsByID.ItemCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsValueTypeNull()
			{
				return this.IsNull(this.tableGetItemsByID.ValueTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetValueTypeNull()
			{
				this[this.tableGetItemsByID.ValueTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetItemsByIDRowChangeEvent : EventArgs
		{
			private EGlossaryItemDataset.GetItemsByIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EGlossaryItemDataset.GetItemsByIDRow Row
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
			public GetItemsByIDRowChangeEvent(EGlossaryItemDataset.GetItemsByIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EGlossaryItemDataset.GetItemsByIDDataTable tableGetItemsByID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EGlossaryItemDataset.GetItemsByIDDataTable GetItemsByID
		{
			get
			{
				return this.tableGetItemsByID;
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
		public EGlossaryItemDataset()
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
		protected EGlossaryItemDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetItemsByID"] != null)
				{
					base.Tables.Add(new EGlossaryItemDataset.GetItemsByIDDataTable(dataSet.Tables["GetItemsByID"]));
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
			EGlossaryItemDataset eGlossaryItemDataset = (EGlossaryItemDataset)base.Clone();
			eGlossaryItemDataset.InitVars();
			eGlossaryItemDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eGlossaryItemDataset;
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
				if (dataSet.Tables["GetItemsByID"] != null)
				{
					base.Tables.Add(new EGlossaryItemDataset.GetItemsByIDDataTable(dataSet.Tables["GetItemsByID"]));
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
			this.tableGetItemsByID = (EGlossaryItemDataset.GetItemsByIDDataTable)base.Tables["GetItemsByID"];
			if (initTable && this.tableGetItemsByID != null)
			{
				this.tableGetItemsByID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EGlossaryItemDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EGlossaryItemDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetItemsByID = new EGlossaryItemDataset.GetItemsByIDDataTable();
			base.Tables.Add(this.tableGetItemsByID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetItemsByID()
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
			EGlossaryItemDataset eGlossaryItemDataset = new EGlossaryItemDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eGlossaryItemDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eGlossaryItemDataset.GetSchemaSerializable();
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
