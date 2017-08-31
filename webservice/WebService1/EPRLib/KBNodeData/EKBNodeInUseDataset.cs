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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBNodeInUseDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBNodeInUseDataset : DataSet
	{
		public delegate void SELECTInUseBYPARENTIDRowChangeEventHandler(object sender, EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTInUseBYPARENTIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnKBTreeID;

			private DataColumn columnKnowledgeBaseID;

			private DataColumn columnDescription;

			private DataColumn columnIsCommon;

			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowChangingEvent;

			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowChangedEvent;

			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowDeletingEvent;

			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowDeletedEvent;

			public event EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTInUseBYPARENTIDRowChangingEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTInUseBYPARENTIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTInUseBYPARENTIDRowChangingEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTInUseBYPARENTIDRowChangingEvent, value);
				}
			}

			public event EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTInUseBYPARENTIDRowChangedEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTInUseBYPARENTIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTInUseBYPARENTIDRowChangedEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTInUseBYPARENTIDRowChangedEvent, value);
				}
			}

			public event EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTInUseBYPARENTIDRowDeletingEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTInUseBYPARENTIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTInUseBYPARENTIDRowDeletingEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTInUseBYPARENTIDRowDeletingEvent, value);
				}
			}

			public event EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler SELECTInUseBYPARENTIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTInUseBYPARENTIDRowDeletedEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Combine(this.SELECTInUseBYPARENTIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTInUseBYPARENTIDRowDeletedEvent = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler)Delegate.Remove(this.SELECTInUseBYPARENTIDRowDeletedEvent, value);
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
			public EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow this[int index]
			{
				get
				{
					return (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTInUseBYPARENTIDDataTable()
			{
				this.TableName = "SELECTInUseBYPARENTID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTInUseBYPARENTIDDataTable(DataTable table)
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
			protected SELECTInUseBYPARENTIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTInUseBYPARENTIDRow(EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow AddSELECTInUseBYPARENTIDRow(long ID, string Name, string KBTreeID, string KnowledgeBaseID, string Description, string IsCommon)
			{
				EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow sELECTInUseBYPARENTIDRow = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					KBTreeID,
					KnowledgeBaseID,
					Description,
					IsCommon
				};
				sELECTInUseBYPARENTIDRow.ItemArray = itemArray;
				this.Rows.Add(sELECTInUseBYPARENTIDRow);
				return sELECTInUseBYPARENTIDRow;
			}

			[DebuggerNonUserCode]
			public EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow FindByID(long ID)
			{
				return (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)this.Rows.Find(new object[]
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
				EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable sELECTInUseBYPARENTIDDataTable = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable)base.Clone();
				sELECTInUseBYPARENTIDDataTable.InitVars();
				return sELECTInUseBYPARENTIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable();
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
			public EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow NewSELECTInUseBYPARENTIDRow()
			{
				return (EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTInUseBYPARENTIDRowChangedEvent != null)
				{
					EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler sELECTInUseBYPARENTIDRowChangedEvent = this.SELECTInUseBYPARENTIDRowChangedEvent;
					if (sELECTInUseBYPARENTIDRowChangedEvent != null)
					{
						sELECTInUseBYPARENTIDRowChangedEvent(this, new EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEvent((EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTInUseBYPARENTIDRowChangingEvent != null)
				{
					EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler sELECTInUseBYPARENTIDRowChangingEvent = this.SELECTInUseBYPARENTIDRowChangingEvent;
					if (sELECTInUseBYPARENTIDRowChangingEvent != null)
					{
						sELECTInUseBYPARENTIDRowChangingEvent(this, new EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEvent((EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTInUseBYPARENTIDRowDeletedEvent != null)
				{
					EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler sELECTInUseBYPARENTIDRowDeletedEvent = this.SELECTInUseBYPARENTIDRowDeletedEvent;
					if (sELECTInUseBYPARENTIDRowDeletedEvent != null)
					{
						sELECTInUseBYPARENTIDRowDeletedEvent(this, new EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEvent((EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTInUseBYPARENTIDRowDeletingEvent != null)
				{
					EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEventHandler sELECTInUseBYPARENTIDRowDeletingEvent = this.SELECTInUseBYPARENTIDRowDeletingEvent;
					if (sELECTInUseBYPARENTIDRowDeletingEvent != null)
					{
						sELECTInUseBYPARENTIDRowDeletingEvent(this, new EKBNodeInUseDataset.SELECTInUseBYPARENTIDRowChangeEvent((EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTInUseBYPARENTIDRow(EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBNodeInUseDataset eKBNodeInUseDataset = new EKBNodeInUseDataset();
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
				xmlSchemaAttribute.FixedValue = eKBNodeInUseDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTInUseBYPARENTIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBNodeInUseDataset.GetSchemaSerializable();
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
		public class SELECTInUseBYPARENTIDRow : DataRow
		{
			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable tableSELECTInUseBYPARENTID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTInUseBYPARENTID.IDColumn]);
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTInUseBYPARENTID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTInUseBYPARENTID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTInUseBYPARENTID.KBTreeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTInUseBYPARENTID\"中列\"KBTreeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.KBTreeIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTInUseBYPARENTID.KnowledgeBaseIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTInUseBYPARENTID\"中列\"KnowledgeBaseID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.KnowledgeBaseIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTInUseBYPARENTID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTInUseBYPARENTID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.DescriptionColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTInUseBYPARENTID.IsCommonColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTInUseBYPARENTID\"中列\"IsCommon\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTInUseBYPARENTID.IsCommonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTInUseBYPARENTIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTInUseBYPARENTID = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTInUseBYPARENTID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTInUseBYPARENTID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBTreeIDNull()
			{
				return this.IsNull(this.tableSELECTInUseBYPARENTID.KBTreeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBTreeIDNull()
			{
				this[this.tableSELECTInUseBYPARENTID.KBTreeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKnowledgeBaseIDNull()
			{
				return this.IsNull(this.tableSELECTInUseBYPARENTID.KnowledgeBaseIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKnowledgeBaseIDNull()
			{
				this[this.tableSELECTInUseBYPARENTID.KnowledgeBaseIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTInUseBYPARENTID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTInUseBYPARENTID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsCommonNull()
			{
				return this.IsNull(this.tableSELECTInUseBYPARENTID.IsCommonColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsCommonNull()
			{
				this[this.tableSELECTInUseBYPARENTID.IsCommonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTInUseBYPARENTIDRowChangeEvent : EventArgs
		{
			private EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow Row
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
			public SELECTInUseBYPARENTIDRowChangeEvent(EKBNodeInUseDataset.SELECTInUseBYPARENTIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable tableSELECTInUseBYPARENTID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable SELECTInUseBYPARENTID
		{
			get
			{
				return this.tableSELECTInUseBYPARENTID;
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
		public EKBNodeInUseDataset()
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
		protected EKBNodeInUseDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTInUseBYPARENTID"] != null)
				{
					base.Tables.Add(new EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable(dataSet.Tables["SELECTInUseBYPARENTID"]));
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
			EKBNodeInUseDataset eKBNodeInUseDataset = (EKBNodeInUseDataset)base.Clone();
			eKBNodeInUseDataset.InitVars();
			eKBNodeInUseDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBNodeInUseDataset;
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
				if (dataSet.Tables["SELECTInUseBYPARENTID"] != null)
				{
					base.Tables.Add(new EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable(dataSet.Tables["SELECTInUseBYPARENTID"]));
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
			this.tableSELECTInUseBYPARENTID = (EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable)base.Tables["SELECTInUseBYPARENTID"];
			if (initTable && this.tableSELECTInUseBYPARENTID != null)
			{
				this.tableSELECTInUseBYPARENTID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBNodeInUseDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBNodeInUseDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTInUseBYPARENTID = new EKBNodeInUseDataset.SELECTInUseBYPARENTIDDataTable();
			base.Tables.Add(this.tableSELECTInUseBYPARENTID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTInUseBYPARENTID()
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
			EKBNodeInUseDataset eKBNodeInUseDataset = new EKBNodeInUseDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBNodeInUseDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBNodeInUseDataset.GetSchemaSerializable();
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
