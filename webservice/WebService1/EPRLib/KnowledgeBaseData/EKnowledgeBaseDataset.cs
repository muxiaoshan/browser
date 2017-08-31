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

namespace KnowledgeBaseData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKnowledgeBaseDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKnowledgeBaseDataset : DataSet
	{
		public delegate void SELECTBYCATEIDRowChangeEventHandler(object sender, EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTBYCATEIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnKBCategoryID;

			private DataColumn columnDescription;

			private DataColumn columnS1Name;

			private DataColumn columnS2Name;

			private DataColumn columnS3Name;

			private DataColumn columnSegmentNumber;

			private EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowChangingEvent;

			private EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowChangedEvent;

			private EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowDeletingEvent;

			private EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowDeletedEvent;

			public event EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYCATEIDRowChangingEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYCATEIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYCATEIDRowChangingEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYCATEIDRowChangingEvent, value);
				}
			}

			public event EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYCATEIDRowChangedEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYCATEIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYCATEIDRowChangedEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYCATEIDRowChangedEvent, value);
				}
			}

			public event EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYCATEIDRowDeletingEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYCATEIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYCATEIDRowDeletingEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYCATEIDRowDeletingEvent, value);
				}
			}

			public event EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler SELECTBYCATEIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYCATEIDRowDeletedEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYCATEIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYCATEIDRowDeletedEvent = (EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYCATEIDRowDeletedEvent, value);
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
			public DataColumn KBCategoryIDColumn
			{
				get
				{
					return this.columnKBCategoryID;
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
			public DataColumn S1NameColumn
			{
				get
				{
					return this.columnS1Name;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn S2NameColumn
			{
				get
				{
					return this.columnS2Name;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn S3NameColumn
			{
				get
				{
					return this.columnS3Name;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SegmentNumberColumn
			{
				get
				{
					return this.columnSegmentNumber;
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
			public EKnowledgeBaseDataset.SELECTBYCATEIDRow this[int index]
			{
				get
				{
					return (EKnowledgeBaseDataset.SELECTBYCATEIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTBYCATEIDDataTable()
			{
				this.TableName = "SELECTBYCATEID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTBYCATEIDDataTable(DataTable table)
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
			protected SELECTBYCATEIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTBYCATEIDRow(EKnowledgeBaseDataset.SELECTBYCATEIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKnowledgeBaseDataset.SELECTBYCATEIDRow AddSELECTBYCATEIDRow(long ID, string Name, string KBCategoryID, string Description, string S1Name, string S2Name, string S3Name, long SegmentNumber)
			{
				EKnowledgeBaseDataset.SELECTBYCATEIDRow sELECTBYCATEIDRow = (EKnowledgeBaseDataset.SELECTBYCATEIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					KBCategoryID,
					Description,
					S1Name,
					S2Name,
					S3Name,
					SegmentNumber
				};
				sELECTBYCATEIDRow.ItemArray = itemArray;
				this.Rows.Add(sELECTBYCATEIDRow);
				return sELECTBYCATEIDRow;
			}

			[DebuggerNonUserCode]
			public EKnowledgeBaseDataset.SELECTBYCATEIDRow FindByID(long ID)
			{
				return (EKnowledgeBaseDataset.SELECTBYCATEIDRow)this.Rows.Find(new object[]
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
				EKnowledgeBaseDataset.SELECTBYCATEIDDataTable sELECTBYCATEIDDataTable = (EKnowledgeBaseDataset.SELECTBYCATEIDDataTable)base.Clone();
				sELECTBYCATEIDDataTable.InitVars();
				return sELECTBYCATEIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKnowledgeBaseDataset.SELECTBYCATEIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnKBCategoryID = base.Columns["KBCategoryID"];
				this.columnDescription = base.Columns["Description"];
				this.columnS1Name = base.Columns["S1Name"];
				this.columnS2Name = base.Columns["S2Name"];
				this.columnS3Name = base.Columns["S3Name"];
				this.columnSegmentNumber = base.Columns["SegmentNumber"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnKBCategoryID = new DataColumn("KBCategoryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKBCategoryID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnS1Name = new DataColumn("S1Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnS1Name);
				this.columnS2Name = new DataColumn("S2Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnS2Name);
				this.columnS3Name = new DataColumn("S3Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnS3Name);
				this.columnSegmentNumber = new DataColumn("SegmentNumber", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnSegmentNumber);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKnowledgeBaseDataset.SELECTBYCATEIDRow NewSELECTBYCATEIDRow()
			{
				return (EKnowledgeBaseDataset.SELECTBYCATEIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKnowledgeBaseDataset.SELECTBYCATEIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKnowledgeBaseDataset.SELECTBYCATEIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTBYCATEIDRowChangedEvent != null)
				{
					EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler sELECTBYCATEIDRowChangedEvent = this.SELECTBYCATEIDRowChangedEvent;
					if (sELECTBYCATEIDRowChangedEvent != null)
					{
						sELECTBYCATEIDRowChangedEvent(this, new EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEvent((EKnowledgeBaseDataset.SELECTBYCATEIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTBYCATEIDRowChangingEvent != null)
				{
					EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler sELECTBYCATEIDRowChangingEvent = this.SELECTBYCATEIDRowChangingEvent;
					if (sELECTBYCATEIDRowChangingEvent != null)
					{
						sELECTBYCATEIDRowChangingEvent(this, new EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEvent((EKnowledgeBaseDataset.SELECTBYCATEIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTBYCATEIDRowDeletedEvent != null)
				{
					EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler sELECTBYCATEIDRowDeletedEvent = this.SELECTBYCATEIDRowDeletedEvent;
					if (sELECTBYCATEIDRowDeletedEvent != null)
					{
						sELECTBYCATEIDRowDeletedEvent(this, new EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEvent((EKnowledgeBaseDataset.SELECTBYCATEIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTBYCATEIDRowDeletingEvent != null)
				{
					EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEventHandler sELECTBYCATEIDRowDeletingEvent = this.SELECTBYCATEIDRowDeletingEvent;
					if (sELECTBYCATEIDRowDeletingEvent != null)
					{
						sELECTBYCATEIDRowDeletingEvent(this, new EKnowledgeBaseDataset.SELECTBYCATEIDRowChangeEvent((EKnowledgeBaseDataset.SELECTBYCATEIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTBYCATEIDRow(EKnowledgeBaseDataset.SELECTBYCATEIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKnowledgeBaseDataset eKnowledgeBaseDataset = new EKnowledgeBaseDataset();
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
				xmlSchemaAttribute.FixedValue = eKnowledgeBaseDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTBYCATEIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKnowledgeBaseDataset.GetSchemaSerializable();
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
		public class SELECTBYCATEIDRow : DataRow
		{
			private EKnowledgeBaseDataset.SELECTBYCATEIDDataTable tableSELECTBYCATEID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTBYCATEID.IDColumn]);
				}
				set
				{
					this[this.tableSELECTBYCATEID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string KBCategoryID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.KBCategoryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"KBCategoryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.KBCategoryIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string S1Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.S1NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"S1Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.S1NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string S2Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.S2NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"S2Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.S2NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string S3Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYCATEID.S3NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"S3Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.S3NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long SegmentNumber
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTBYCATEID.SegmentNumberColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYCATEID\"中列\"SegmentNumber\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYCATEID.SegmentNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTBYCATEIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTBYCATEID = (EKnowledgeBaseDataset.SELECTBYCATEIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTBYCATEID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBCategoryIDNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.KBCategoryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBCategoryIDNull()
			{
				this[this.tableSELECTBYCATEID.KBCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTBYCATEID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsS1NameNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.S1NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetS1NameNull()
			{
				this[this.tableSELECTBYCATEID.S1NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsS2NameNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.S2NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetS2NameNull()
			{
				this[this.tableSELECTBYCATEID.S2NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsS3NameNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.S3NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetS3NameNull()
			{
				this[this.tableSELECTBYCATEID.S3NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSegmentNumberNull()
			{
				return this.IsNull(this.tableSELECTBYCATEID.SegmentNumberColumn);
			}

			[DebuggerNonUserCode]
			public void SetSegmentNumberNull()
			{
				this[this.tableSELECTBYCATEID.SegmentNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTBYCATEIDRowChangeEvent : EventArgs
		{
			private EKnowledgeBaseDataset.SELECTBYCATEIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKnowledgeBaseDataset.SELECTBYCATEIDRow Row
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
			public SELECTBYCATEIDRowChangeEvent(EKnowledgeBaseDataset.SELECTBYCATEIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKnowledgeBaseDataset.SELECTBYCATEIDDataTable tableSELECTBYCATEID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKnowledgeBaseDataset.SELECTBYCATEIDDataTable SELECTBYCATEID
		{
			get
			{
				return this.tableSELECTBYCATEID;
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
		public EKnowledgeBaseDataset()
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
		protected EKnowledgeBaseDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTBYCATEID"] != null)
				{
					base.Tables.Add(new EKnowledgeBaseDataset.SELECTBYCATEIDDataTable(dataSet.Tables["SELECTBYCATEID"]));
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
			EKnowledgeBaseDataset eKnowledgeBaseDataset = (EKnowledgeBaseDataset)base.Clone();
			eKnowledgeBaseDataset.InitVars();
			eKnowledgeBaseDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKnowledgeBaseDataset;
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
				if (dataSet.Tables["SELECTBYCATEID"] != null)
				{
					base.Tables.Add(new EKnowledgeBaseDataset.SELECTBYCATEIDDataTable(dataSet.Tables["SELECTBYCATEID"]));
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
			this.tableSELECTBYCATEID = (EKnowledgeBaseDataset.SELECTBYCATEIDDataTable)base.Tables["SELECTBYCATEID"];
			if (initTable && this.tableSELECTBYCATEID != null)
			{
				this.tableSELECTBYCATEID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKnowledgeBaseDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKnowledgeBaseDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTBYCATEID = new EKnowledgeBaseDataset.SELECTBYCATEIDDataTable();
			base.Tables.Add(this.tableSELECTBYCATEID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTBYCATEID()
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
			EKnowledgeBaseDataset eKnowledgeBaseDataset = new EKnowledgeBaseDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKnowledgeBaseDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKnowledgeBaseDataset.GetSchemaSerializable();
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
