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

namespace KBNodeData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBNodeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBNodeDataset : DataSet
	{
		public delegate void SELECTBYPARENTIDRowChangeEventHandler(object sender, EKBNodeDataset.SELECTBYPARENTIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTBYPARENTIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnKBTreeID;

			private DataColumn columnKnowledgeBaseID;

			private DataColumn columnDescription;

			private DataColumn columnIsCommon;

			private EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowChangingEvent;

			private EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowChangedEvent;

			private EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowDeletingEvent;

			private EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowDeletedEvent;

			public event EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARENTIDRowChangingEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARENTIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARENTIDRowChangingEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARENTIDRowChangingEvent, value);
				}
			}

			public event EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARENTIDRowChangedEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARENTIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARENTIDRowChangedEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARENTIDRowChangedEvent, value);
				}
			}

			public event EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARENTIDRowDeletingEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARENTIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARENTIDRowDeletingEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARENTIDRowDeletingEvent, value);
				}
			}

			public event EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler SELECTBYPARENTIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARENTIDRowDeletedEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARENTIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARENTIDRowDeletedEvent = (EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARENTIDRowDeletedEvent, value);
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
			public DataColumn KBTreeIDColumn
			{
				get
				{
					return this.columnKBTreeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn KnowledgeBaseIDColumn
			{
				get
				{
					return this.columnKnowledgeBaseID;
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
			public DataColumn IsCommonColumn
			{
				get
				{
					return this.columnIsCommon;
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
			public EKBNodeDataset.SELECTBYPARENTIDRow this[int index]
			{
				get
				{
					return (EKBNodeDataset.SELECTBYPARENTIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTBYPARENTIDDataTable()
			{
				this.TableName = "SELECTBYPARENTID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTBYPARENTIDDataTable(DataTable table)
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
			protected SELECTBYPARENTIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTBYPARENTIDRow(EKBNodeDataset.SELECTBYPARENTIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBNodeDataset.SELECTBYPARENTIDRow AddSELECTBYPARENTIDRow(long ID, string Name, string KBTreeID, string KnowledgeBaseID, string Description, string IsCommon)
			{
				EKBNodeDataset.SELECTBYPARENTIDRow sELECTBYPARENTIDRow = (EKBNodeDataset.SELECTBYPARENTIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					KBTreeID,
					KnowledgeBaseID,
					Description,
					IsCommon
				};
				sELECTBYPARENTIDRow.ItemArray = itemArray;
				this.Rows.Add(sELECTBYPARENTIDRow);
				return sELECTBYPARENTIDRow;
			}

			[DebuggerNonUserCode]
			public EKBNodeDataset.SELECTBYPARENTIDRow FindByID(long ID)
			{
				return (EKBNodeDataset.SELECTBYPARENTIDRow)this.Rows.Find(new object[]
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
				EKBNodeDataset.SELECTBYPARENTIDDataTable sELECTBYPARENTIDDataTable = (EKBNodeDataset.SELECTBYPARENTIDDataTable)base.Clone();
				sELECTBYPARENTIDDataTable.InitVars();
				return sELECTBYPARENTIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBNodeDataset.SELECTBYPARENTIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnKBTreeID = base.Columns["KBTreeID"];
				this.columnKnowledgeBaseID = base.Columns["KnowledgeBaseID"];
				this.columnDescription = base.Columns["Description"];
				this.columnIsCommon = base.Columns["IsCommon"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnKBTreeID = new DataColumn("KBTreeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKBTreeID);
				this.columnKnowledgeBaseID = new DataColumn("KnowledgeBaseID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKnowledgeBaseID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnIsCommon = new DataColumn("IsCommon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIsCommon);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBNodeDataset.SELECTBYPARENTIDRow NewSELECTBYPARENTIDRow()
			{
				return (EKBNodeDataset.SELECTBYPARENTIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBNodeDataset.SELECTBYPARENTIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBNodeDataset.SELECTBYPARENTIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTBYPARENTIDRowChangedEvent != null)
				{
					EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler sELECTBYPARENTIDRowChangedEvent = this.SELECTBYPARENTIDRowChangedEvent;
					if (sELECTBYPARENTIDRowChangedEvent != null)
					{
						sELECTBYPARENTIDRowChangedEvent(this, new EKBNodeDataset.SELECTBYPARENTIDRowChangeEvent((EKBNodeDataset.SELECTBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTBYPARENTIDRowChangingEvent != null)
				{
					EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler sELECTBYPARENTIDRowChangingEvent = this.SELECTBYPARENTIDRowChangingEvent;
					if (sELECTBYPARENTIDRowChangingEvent != null)
					{
						sELECTBYPARENTIDRowChangingEvent(this, new EKBNodeDataset.SELECTBYPARENTIDRowChangeEvent((EKBNodeDataset.SELECTBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTBYPARENTIDRowDeletedEvent != null)
				{
					EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler sELECTBYPARENTIDRowDeletedEvent = this.SELECTBYPARENTIDRowDeletedEvent;
					if (sELECTBYPARENTIDRowDeletedEvent != null)
					{
						sELECTBYPARENTIDRowDeletedEvent(this, new EKBNodeDataset.SELECTBYPARENTIDRowChangeEvent((EKBNodeDataset.SELECTBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTBYPARENTIDRowDeletingEvent != null)
				{
					EKBNodeDataset.SELECTBYPARENTIDRowChangeEventHandler sELECTBYPARENTIDRowDeletingEvent = this.SELECTBYPARENTIDRowDeletingEvent;
					if (sELECTBYPARENTIDRowDeletingEvent != null)
					{
						sELECTBYPARENTIDRowDeletingEvent(this, new EKBNodeDataset.SELECTBYPARENTIDRowChangeEvent((EKBNodeDataset.SELECTBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTBYPARENTIDRow(EKBNodeDataset.SELECTBYPARENTIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBNodeDataset eKBNodeDataset = new EKBNodeDataset();
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
				xmlSchemaAttribute.FixedValue = eKBNodeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTBYPARENTIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBNodeDataset.GetSchemaSerializable();
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
		public class SELECTBYPARENTIDRow : DataRow
		{
			private EKBNodeDataset.SELECTBYPARENTIDDataTable tableSELECTBYPARENTID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTBYPARENTID.IDColumn]);
				}
				set
				{
					this[this.tableSELECTBYPARENTID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARENTID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARENTID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARENTID.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string KBTreeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYPARENTID.KBTreeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARENTID\"中列\"KBTreeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARENTID.KBTreeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string KnowledgeBaseID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYPARENTID.KnowledgeBaseIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARENTID\"中列\"KnowledgeBaseID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARENTID.KnowledgeBaseIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARENTID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARENTID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARENTID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string IsCommon
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYPARENTID.IsCommonColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARENTID\"中列\"IsCommon\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARENTID.IsCommonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTBYPARENTIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTBYPARENTID = (EKBNodeDataset.SELECTBYPARENTIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTBYPARENTID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTBYPARENTID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBTreeIDNull()
			{
				return this.IsNull(this.tableSELECTBYPARENTID.KBTreeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBTreeIDNull()
			{
				this[this.tableSELECTBYPARENTID.KBTreeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKnowledgeBaseIDNull()
			{
				return this.IsNull(this.tableSELECTBYPARENTID.KnowledgeBaseIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKnowledgeBaseIDNull()
			{
				this[this.tableSELECTBYPARENTID.KnowledgeBaseIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTBYPARENTID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTBYPARENTID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsCommonNull()
			{
				return this.IsNull(this.tableSELECTBYPARENTID.IsCommonColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsCommonNull()
			{
				this[this.tableSELECTBYPARENTID.IsCommonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTBYPARENTIDRowChangeEvent : EventArgs
		{
			private EKBNodeDataset.SELECTBYPARENTIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBNodeDataset.SELECTBYPARENTIDRow Row
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
			public SELECTBYPARENTIDRowChangeEvent(EKBNodeDataset.SELECTBYPARENTIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBNodeDataset.SELECTBYPARENTIDDataTable tableSELECTBYPARENTID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBNodeDataset.SELECTBYPARENTIDDataTable SELECTBYPARENTID
		{
			get
			{
				return this.tableSELECTBYPARENTID;
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
		public EKBNodeDataset()
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
		protected EKBNodeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTBYPARENTID"] != null)
				{
					base.Tables.Add(new EKBNodeDataset.SELECTBYPARENTIDDataTable(dataSet.Tables["SELECTBYPARENTID"]));
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
			EKBNodeDataset eKBNodeDataset = (EKBNodeDataset)base.Clone();
			eKBNodeDataset.InitVars();
			eKBNodeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBNodeDataset;
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
				if (dataSet.Tables["SELECTBYPARENTID"] != null)
				{
					base.Tables.Add(new EKBNodeDataset.SELECTBYPARENTIDDataTable(dataSet.Tables["SELECTBYPARENTID"]));
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
			this.tableSELECTBYPARENTID = (EKBNodeDataset.SELECTBYPARENTIDDataTable)base.Tables["SELECTBYPARENTID"];
			if (initTable && this.tableSELECTBYPARENTID != null)
			{
				this.tableSELECTBYPARENTID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBNodeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBNodeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTBYPARENTID = new EKBNodeDataset.SELECTBYPARENTIDDataTable();
			base.Tables.Add(this.tableSELECTBYPARENTID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTBYPARENTID()
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
			EKBNodeDataset eKBNodeDataset = new EKBNodeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBNodeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBNodeDataset.GetSchemaSerializable();
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
