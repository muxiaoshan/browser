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

namespace ImageTreeData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EImageTreeDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EImageTreeDataSet : DataSet
	{
		public delegate void GetByImageLibIDRowChangeEventHandler(object sender, EImageTreeDataSet.GetByImageLibIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetByImageLibIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnImageLibID;

			private DataColumn columnParentID;

			private DataColumn columnUserID;

			private DataColumn columnSequence;

			private DataColumn columnChildCount;

			private EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowChangingEvent;

			private EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowChangedEvent;

			private EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowDeletingEvent;

			private EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowDeletedEvent;

			public event EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageLibIDRowChangingEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Combine(this.GetByImageLibIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageLibIDRowChangingEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Remove(this.GetByImageLibIDRowChangingEvent, value);
				}
			}

			public event EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageLibIDRowChangedEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Combine(this.GetByImageLibIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageLibIDRowChangedEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Remove(this.GetByImageLibIDRowChangedEvent, value);
				}
			}

			public event EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageLibIDRowDeletingEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Combine(this.GetByImageLibIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageLibIDRowDeletingEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Remove(this.GetByImageLibIDRowDeletingEvent, value);
				}
			}

			public event EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler GetByImageLibIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetByImageLibIDRowDeletedEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Combine(this.GetByImageLibIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetByImageLibIDRowDeletedEvent = (EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler)Delegate.Remove(this.GetByImageLibIDRowDeletedEvent, value);
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
			public DataColumn ParentIDColumn
			{
				get
				{
					return this.columnParentID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn UserIDColumn
			{
				get
				{
					return this.columnUserID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SequenceColumn
			{
				get
				{
					return this.columnSequence;
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
			public EImageTreeDataSet.GetByImageLibIDRow this[int index]
			{
				get
				{
					return (EImageTreeDataSet.GetByImageLibIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetByImageLibIDDataTable()
			{
				this.TableName = "GetByImageLibID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetByImageLibIDDataTable(DataTable table)
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
			protected GetByImageLibIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetByImageLibIDRow(EImageTreeDataSet.GetByImageLibIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EImageTreeDataSet.GetByImageLibIDRow AddGetByImageLibIDRow(string ID, string Name, string Description, string ImageLibID, string ParentID, string UserID, string Sequence, string ChildCount)
			{
				EImageTreeDataSet.GetByImageLibIDRow getByImageLibIDRow = (EImageTreeDataSet.GetByImageLibIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					ImageLibID,
					ParentID,
					UserID,
					Sequence,
					ChildCount
				};
				getByImageLibIDRow.ItemArray = itemArray;
				this.Rows.Add(getByImageLibIDRow);
				return getByImageLibIDRow;
			}

			[DebuggerNonUserCode]
			public EImageTreeDataSet.GetByImageLibIDRow FindByID(string ID)
			{
				return (EImageTreeDataSet.GetByImageLibIDRow)this.Rows.Find(new object[]
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
				EImageTreeDataSet.GetByImageLibIDDataTable getByImageLibIDDataTable = (EImageTreeDataSet.GetByImageLibIDDataTable)base.Clone();
				getByImageLibIDDataTable.InitVars();
				return getByImageLibIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EImageTreeDataSet.GetByImageLibIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnImageLibID = base.Columns["ImageLibID"];
				this.columnParentID = base.Columns["ParentID"];
				this.columnUserID = base.Columns["UserID"];
				this.columnSequence = base.Columns["Sequence"];
				this.columnChildCount = base.Columns["ChildCount"];
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
				this.columnParentID = new DataColumn("ParentID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentID);
				this.columnUserID = new DataColumn("UserID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserID);
				this.columnSequence = new DataColumn("Sequence", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSequence);
				this.columnChildCount = new DataColumn("ChildCount", typeof(string), null, MappingType.Element);
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
			public EImageTreeDataSet.GetByImageLibIDRow NewGetByImageLibIDRow()
			{
				return (EImageTreeDataSet.GetByImageLibIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EImageTreeDataSet.GetByImageLibIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EImageTreeDataSet.GetByImageLibIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetByImageLibIDRowChangedEvent != null)
				{
					EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler getByImageLibIDRowChangedEvent = this.GetByImageLibIDRowChangedEvent;
					if (getByImageLibIDRowChangedEvent != null)
					{
						getByImageLibIDRowChangedEvent(this, new EImageTreeDataSet.GetByImageLibIDRowChangeEvent((EImageTreeDataSet.GetByImageLibIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetByImageLibIDRowChangingEvent != null)
				{
					EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler getByImageLibIDRowChangingEvent = this.GetByImageLibIDRowChangingEvent;
					if (getByImageLibIDRowChangingEvent != null)
					{
						getByImageLibIDRowChangingEvent(this, new EImageTreeDataSet.GetByImageLibIDRowChangeEvent((EImageTreeDataSet.GetByImageLibIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetByImageLibIDRowDeletedEvent != null)
				{
					EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler getByImageLibIDRowDeletedEvent = this.GetByImageLibIDRowDeletedEvent;
					if (getByImageLibIDRowDeletedEvent != null)
					{
						getByImageLibIDRowDeletedEvent(this, new EImageTreeDataSet.GetByImageLibIDRowChangeEvent((EImageTreeDataSet.GetByImageLibIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetByImageLibIDRowDeletingEvent != null)
				{
					EImageTreeDataSet.GetByImageLibIDRowChangeEventHandler getByImageLibIDRowDeletingEvent = this.GetByImageLibIDRowDeletingEvent;
					if (getByImageLibIDRowDeletingEvent != null)
					{
						getByImageLibIDRowDeletingEvent(this, new EImageTreeDataSet.GetByImageLibIDRowChangeEvent((EImageTreeDataSet.GetByImageLibIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetByImageLibIDRow(EImageTreeDataSet.GetByImageLibIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EImageTreeDataSet eImageTreeDataSet = new EImageTreeDataSet();
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
				xmlSchemaAttribute.FixedValue = eImageTreeDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetByImageLibIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eImageTreeDataSet.GetSchemaSerializable();
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
		public class GetByImageLibIDRow : DataRow
		{
			private EImageTreeDataSet.GetByImageLibIDDataTable tableGetByImageLibID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableGetByImageLibID.IDColumn]);
				}
				set
				{
					this[this.tableGetByImageLibID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageLibID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageLibID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.DescriptionColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageLibID.ImageLibIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"ImageLibID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.ImageLibIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetByImageLibID.ParentIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"ParentID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.ParentIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string UserID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageLibID.UserIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"UserID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.UserIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Sequence
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageLibID.SequenceColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"Sequence\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.SequenceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ChildCount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetByImageLibID.ChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetByImageLibID\"中列\"ChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetByImageLibID.ChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetByImageLibIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetByImageLibID = (EImageTreeDataSet.GetByImageLibIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetByImageLibID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetByImageLibID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetByImageLibID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetByImageLibID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsImageLibIDNull()
			{
				return this.IsNull(this.tableGetByImageLibID.ImageLibIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetImageLibIDNull()
			{
				this[this.tableGetByImageLibID.ImageLibIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParentIDNull()
			{
				return this.IsNull(this.tableGetByImageLibID.ParentIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetParentIDNull()
			{
				this[this.tableGetByImageLibID.ParentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsUserIDNull()
			{
				return this.IsNull(this.tableGetByImageLibID.UserIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetUserIDNull()
			{
				this[this.tableGetByImageLibID.UserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSequenceNull()
			{
				return this.IsNull(this.tableGetByImageLibID.SequenceColumn);
			}

			[DebuggerNonUserCode]
			public void SetSequenceNull()
			{
				this[this.tableGetByImageLibID.SequenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsChildCountNull()
			{
				return this.IsNull(this.tableGetByImageLibID.ChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetChildCountNull()
			{
				this[this.tableGetByImageLibID.ChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetByImageLibIDRowChangeEvent : EventArgs
		{
			private EImageTreeDataSet.GetByImageLibIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EImageTreeDataSet.GetByImageLibIDRow Row
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
			public GetByImageLibIDRowChangeEvent(EImageTreeDataSet.GetByImageLibIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EImageTreeDataSet.GetByImageLibIDDataTable tableGetByImageLibID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EImageTreeDataSet.GetByImageLibIDDataTable GetByImageLibID
		{
			get
			{
				return this.tableGetByImageLibID;
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
		public EImageTreeDataSet()
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
		protected EImageTreeDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetByImageLibID"] != null)
				{
					base.Tables.Add(new EImageTreeDataSet.GetByImageLibIDDataTable(dataSet.Tables["GetByImageLibID"]));
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
			EImageTreeDataSet eImageTreeDataSet = (EImageTreeDataSet)base.Clone();
			eImageTreeDataSet.InitVars();
			eImageTreeDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eImageTreeDataSet;
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
				if (dataSet.Tables["GetByImageLibID"] != null)
				{
					base.Tables.Add(new EImageTreeDataSet.GetByImageLibIDDataTable(dataSet.Tables["GetByImageLibID"]));
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
			this.tableGetByImageLibID = (EImageTreeDataSet.GetByImageLibIDDataTable)base.Tables["GetByImageLibID"];
			if (initTable && this.tableGetByImageLibID != null)
			{
				this.tableGetByImageLibID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EImageTreeDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EImageTreeDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetByImageLibID = new EImageTreeDataSet.GetByImageLibIDDataTable();
			base.Tables.Add(this.tableGetByImageLibID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetByImageLibID()
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
			EImageTreeDataSet eImageTreeDataSet = new EImageTreeDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eImageTreeDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eImageTreeDataSet.GetSchemaSerializable();
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
