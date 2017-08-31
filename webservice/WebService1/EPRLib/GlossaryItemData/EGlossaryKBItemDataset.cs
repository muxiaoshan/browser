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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EGlossaryKBItemDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EGlossaryKBItemDataset : DataSet
	{
		public delegate void GetKBItemsByIDRowChangeEventHandler(object sender, EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetKBItemsByIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnGlossaryID;

			private DataColumn columnContextGlossaryID;

			private DataColumn columnKBNodeID;

			private DataColumn columnKBPartNo;

			private DataColumn columnItemName;

			private DataColumn columnItemCode;

			private DataColumn columnValueType;

			private EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowChangingEvent;

			private EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowChangedEvent;

			private EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowDeletingEvent;

			private EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowDeletedEvent;

			public event EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetKBItemsByIDRowChangingEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetKBItemsByIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetKBItemsByIDRowChangingEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetKBItemsByIDRowChangingEvent, value);
				}
			}

			public event EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetKBItemsByIDRowChangedEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetKBItemsByIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetKBItemsByIDRowChangedEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetKBItemsByIDRowChangedEvent, value);
				}
			}

			public event EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetKBItemsByIDRowDeletingEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetKBItemsByIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetKBItemsByIDRowDeletingEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetKBItemsByIDRowDeletingEvent, value);
				}
			}

			public event EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler GetKBItemsByIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetKBItemsByIDRowDeletedEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Combine(this.GetKBItemsByIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetKBItemsByIDRowDeletedEvent = (EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler)Delegate.Remove(this.GetKBItemsByIDRowDeletedEvent, value);
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
			public DataColumn ContextGlossaryIDColumn
			{
				get
				{
					return this.columnContextGlossaryID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn KBNodeIDColumn
			{
				get
				{
					return this.columnKBNodeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn KBPartNoColumn
			{
				get
				{
					return this.columnKBPartNo;
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
			public EGlossaryKBItemDataset.GetKBItemsByIDRow this[int index]
			{
				get
				{
					return (EGlossaryKBItemDataset.GetKBItemsByIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetKBItemsByIDDataTable()
			{
				this.TableName = "GetKBItemsByID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetKBItemsByIDDataTable(DataTable table)
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
			protected GetKBItemsByIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetKBItemsByIDRow(EGlossaryKBItemDataset.GetKBItemsByIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EGlossaryKBItemDataset.GetKBItemsByIDRow AddGetKBItemsByIDRow(long ID, long GlossaryID, long ContextGlossaryID, long KBNodeID, long KBPartNo, string ItemName, string ItemCode, string ValueType)
			{
				EGlossaryKBItemDataset.GetKBItemsByIDRow getKBItemsByIDRow = (EGlossaryKBItemDataset.GetKBItemsByIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					GlossaryID,
					ContextGlossaryID,
					KBNodeID,
					KBPartNo,
					ItemName,
					ItemCode,
					ValueType
				};
				getKBItemsByIDRow.ItemArray = itemArray;
				this.Rows.Add(getKBItemsByIDRow);
				return getKBItemsByIDRow;
			}

			[DebuggerNonUserCode]
			public EGlossaryKBItemDataset.GetKBItemsByIDRow FindByID(long ID)
			{
				return (EGlossaryKBItemDataset.GetKBItemsByIDRow)this.Rows.Find(new object[]
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
				EGlossaryKBItemDataset.GetKBItemsByIDDataTable getKBItemsByIDDataTable = (EGlossaryKBItemDataset.GetKBItemsByIDDataTable)base.Clone();
				getKBItemsByIDDataTable.InitVars();
				return getKBItemsByIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EGlossaryKBItemDataset.GetKBItemsByIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnGlossaryID = base.Columns["GlossaryID"];
				this.columnContextGlossaryID = base.Columns["ContextGlossaryID"];
				this.columnKBNodeID = base.Columns["KBNodeID"];
				this.columnKBPartNo = base.Columns["KBPartNo"];
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
				this.columnContextGlossaryID = new DataColumn("ContextGlossaryID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnContextGlossaryID);
				this.columnKBNodeID = new DataColumn("KBNodeID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnKBNodeID);
				this.columnKBPartNo = new DataColumn("KBPartNo", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnKBPartNo);
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
			public EGlossaryKBItemDataset.GetKBItemsByIDRow NewGetKBItemsByIDRow()
			{
				return (EGlossaryKBItemDataset.GetKBItemsByIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EGlossaryKBItemDataset.GetKBItemsByIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EGlossaryKBItemDataset.GetKBItemsByIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetKBItemsByIDRowChangedEvent != null)
				{
					EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler getKBItemsByIDRowChangedEvent = this.GetKBItemsByIDRowChangedEvent;
					if (getKBItemsByIDRowChangedEvent != null)
					{
						getKBItemsByIDRowChangedEvent(this, new EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEvent((EGlossaryKBItemDataset.GetKBItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetKBItemsByIDRowChangingEvent != null)
				{
					EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler getKBItemsByIDRowChangingEvent = this.GetKBItemsByIDRowChangingEvent;
					if (getKBItemsByIDRowChangingEvent != null)
					{
						getKBItemsByIDRowChangingEvent(this, new EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEvent((EGlossaryKBItemDataset.GetKBItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetKBItemsByIDRowDeletedEvent != null)
				{
					EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler getKBItemsByIDRowDeletedEvent = this.GetKBItemsByIDRowDeletedEvent;
					if (getKBItemsByIDRowDeletedEvent != null)
					{
						getKBItemsByIDRowDeletedEvent(this, new EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEvent((EGlossaryKBItemDataset.GetKBItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetKBItemsByIDRowDeletingEvent != null)
				{
					EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEventHandler getKBItemsByIDRowDeletingEvent = this.GetKBItemsByIDRowDeletingEvent;
					if (getKBItemsByIDRowDeletingEvent != null)
					{
						getKBItemsByIDRowDeletingEvent(this, new EGlossaryKBItemDataset.GetKBItemsByIDRowChangeEvent((EGlossaryKBItemDataset.GetKBItemsByIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetKBItemsByIDRow(EGlossaryKBItemDataset.GetKBItemsByIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EGlossaryKBItemDataset eGlossaryKBItemDataset = new EGlossaryKBItemDataset();
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
				xmlSchemaAttribute.FixedValue = eGlossaryKBItemDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetKBItemsByIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eGlossaryKBItemDataset.GetSchemaSerializable();
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
		public class GetKBItemsByIDRow : DataRow
		{
			private EGlossaryKBItemDataset.GetKBItemsByIDDataTable tableGetKBItemsByID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableGetKBItemsByID.IDColumn]);
				}
				set
				{
					this[this.tableGetKBItemsByID.IDColumn] = value;
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
						result = Conversions.ToLong(this[this.tableGetKBItemsByID.GlossaryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"GlossaryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.GlossaryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long ContextGlossaryID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetKBItemsByID.ContextGlossaryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"ContextGlossaryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.ContextGlossaryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long KBNodeID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetKBItemsByID.KBNodeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"KBNodeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.KBNodeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long KBPartNo
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableGetKBItemsByID.KBPartNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"KBPartNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.KBPartNoColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetKBItemsByID.ItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"ItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.ItemNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetKBItemsByID.ItemCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"ItemCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.ItemCodeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetKBItemsByID.ValueTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetKBItemsByID\"中列\"ValueType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetKBItemsByID.ValueTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetKBItemsByIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetKBItemsByID = (EGlossaryKBItemDataset.GetKBItemsByIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryIDNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.GlossaryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryIDNull()
			{
				this[this.tableGetKBItemsByID.GlossaryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsContextGlossaryIDNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.ContextGlossaryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetContextGlossaryIDNull()
			{
				this[this.tableGetKBItemsByID.ContextGlossaryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBNodeIDNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.KBNodeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBNodeIDNull()
			{
				this[this.tableGetKBItemsByID.KBNodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBPartNoNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.KBPartNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBPartNoNull()
			{
				this[this.tableGetKBItemsByID.KBPartNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemNameNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.ItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemNameNull()
			{
				this[this.tableGetKBItemsByID.ItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemCodeNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.ItemCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemCodeNull()
			{
				this[this.tableGetKBItemsByID.ItemCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsValueTypeNull()
			{
				return this.IsNull(this.tableGetKBItemsByID.ValueTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetValueTypeNull()
			{
				this[this.tableGetKBItemsByID.ValueTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetKBItemsByIDRowChangeEvent : EventArgs
		{
			private EGlossaryKBItemDataset.GetKBItemsByIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EGlossaryKBItemDataset.GetKBItemsByIDRow Row
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
			public GetKBItemsByIDRowChangeEvent(EGlossaryKBItemDataset.GetKBItemsByIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EGlossaryKBItemDataset.GetKBItemsByIDDataTable tableGetKBItemsByID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EGlossaryKBItemDataset.GetKBItemsByIDDataTable GetKBItemsByID
		{
			get
			{
				return this.tableGetKBItemsByID;
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
		public EGlossaryKBItemDataset()
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
		protected EGlossaryKBItemDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetKBItemsByID"] != null)
				{
					base.Tables.Add(new EGlossaryKBItemDataset.GetKBItemsByIDDataTable(dataSet.Tables["GetKBItemsByID"]));
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
			EGlossaryKBItemDataset eGlossaryKBItemDataset = (EGlossaryKBItemDataset)base.Clone();
			eGlossaryKBItemDataset.InitVars();
			eGlossaryKBItemDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eGlossaryKBItemDataset;
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
				if (dataSet.Tables["GetKBItemsByID"] != null)
				{
					base.Tables.Add(new EGlossaryKBItemDataset.GetKBItemsByIDDataTable(dataSet.Tables["GetKBItemsByID"]));
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
			this.tableGetKBItemsByID = (EGlossaryKBItemDataset.GetKBItemsByIDDataTable)base.Tables["GetKBItemsByID"];
			if (initTable && this.tableGetKBItemsByID != null)
			{
				this.tableGetKBItemsByID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EGlossaryKBItemDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EGlossaryKBItemDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetKBItemsByID = new EGlossaryKBItemDataset.GetKBItemsByIDDataTable();
			base.Tables.Add(this.tableGetKBItemsByID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetKBItemsByID()
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
			EGlossaryKBItemDataset eGlossaryKBItemDataset = new EGlossaryKBItemDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eGlossaryKBItemDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eGlossaryKBItemDataset.GetSchemaSerializable();
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
