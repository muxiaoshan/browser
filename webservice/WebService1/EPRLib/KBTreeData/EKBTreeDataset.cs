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

namespace KBTreeData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBTreeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBTreeDataset : DataSet
	{
		public delegate void SELECTBYPARANTIDRowChangeEventHandler(object sender, EKBTreeDataset.SELECTBYPARANTIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTBYPARANTIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnParentID;

			private DataColumn columnKnowledgeBaseID;

			private DataColumn columnDescription;

			private DataColumn columnResChildCount;

			private DataColumn columnPersonalKBUserID;

			private DataColumn columnSequence;

			private EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowChangingEvent;

			private EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowChangedEvent;

			private EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowDeletingEvent;

			private EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowDeletedEvent;

			public event EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARANTIDRowChangingEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARANTIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARANTIDRowChangingEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARANTIDRowChangingEvent, value);
				}
			}

			public event EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARANTIDRowChangedEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARANTIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARANTIDRowChangedEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARANTIDRowChangedEvent, value);
				}
			}

			public event EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARANTIDRowDeletingEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARANTIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARANTIDRowDeletingEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARANTIDRowDeletingEvent, value);
				}
			}

			public event EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler SELECTBYPARANTIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYPARANTIDRowDeletedEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Combine(this.SELECTBYPARANTIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYPARANTIDRowDeletedEvent = (EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler)Delegate.Remove(this.SELECTBYPARANTIDRowDeletedEvent, value);
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
			public DataColumn ParentIDColumn
			{
				get
				{
					return this.columnParentID;
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
			public DataColumn ResChildCountColumn
			{
				get
				{
					return this.columnResChildCount;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PersonalKBUserIDColumn
			{
				get
				{
					return this.columnPersonalKBUserID;
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

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public EKBTreeDataset.SELECTBYPARANTIDRow this[int index]
			{
				get
				{
					return (EKBTreeDataset.SELECTBYPARANTIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTBYPARANTIDDataTable()
			{
				this.TableName = "SELECTBYPARANTID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTBYPARANTIDDataTable(DataTable table)
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
			protected SELECTBYPARANTIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTBYPARANTIDRow(EKBTreeDataset.SELECTBYPARANTIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBTreeDataset.SELECTBYPARANTIDRow AddSELECTBYPARANTIDRow(long ID, string Name, string ParentID, string KnowledgeBaseID, string Description, long ResChildCount, string PersonalKBUserID, string Sequence)
			{
				EKBTreeDataset.SELECTBYPARANTIDRow sELECTBYPARANTIDRow = (EKBTreeDataset.SELECTBYPARANTIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					ParentID,
					KnowledgeBaseID,
					Description,
					ResChildCount,
					PersonalKBUserID,
					Sequence
				};
				sELECTBYPARANTIDRow.ItemArray = itemArray;
				this.Rows.Add(sELECTBYPARANTIDRow);
				return sELECTBYPARANTIDRow;
			}

			[DebuggerNonUserCode]
			public EKBTreeDataset.SELECTBYPARANTIDRow FindByID(long ID)
			{
				return (EKBTreeDataset.SELECTBYPARANTIDRow)this.Rows.Find(new object[]
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
				EKBTreeDataset.SELECTBYPARANTIDDataTable sELECTBYPARANTIDDataTable = (EKBTreeDataset.SELECTBYPARANTIDDataTable)base.Clone();
				sELECTBYPARANTIDDataTable.InitVars();
				return sELECTBYPARANTIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBTreeDataset.SELECTBYPARANTIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnParentID = base.Columns["ParentID"];
				this.columnKnowledgeBaseID = base.Columns["KnowledgeBaseID"];
				this.columnDescription = base.Columns["Description"];
				this.columnResChildCount = base.Columns["ResChildCount"];
				this.columnPersonalKBUserID = base.Columns["PersonalKBUserID"];
				this.columnSequence = base.Columns["Sequence"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnParentID = new DataColumn("ParentID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentID);
				this.columnKnowledgeBaseID = new DataColumn("KnowledgeBaseID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKnowledgeBaseID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnResChildCount = new DataColumn("ResChildCount", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnResChildCount);
				this.columnPersonalKBUserID = new DataColumn("PersonalKBUserID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPersonalKBUserID);
				this.columnSequence = new DataColumn("Sequence", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSequence);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBTreeDataset.SELECTBYPARANTIDRow NewSELECTBYPARANTIDRow()
			{
				return (EKBTreeDataset.SELECTBYPARANTIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBTreeDataset.SELECTBYPARANTIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBTreeDataset.SELECTBYPARANTIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTBYPARANTIDRowChangedEvent != null)
				{
					EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler sELECTBYPARANTIDRowChangedEvent = this.SELECTBYPARANTIDRowChangedEvent;
					if (sELECTBYPARANTIDRowChangedEvent != null)
					{
						sELECTBYPARANTIDRowChangedEvent(this, new EKBTreeDataset.SELECTBYPARANTIDRowChangeEvent((EKBTreeDataset.SELECTBYPARANTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTBYPARANTIDRowChangingEvent != null)
				{
					EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler sELECTBYPARANTIDRowChangingEvent = this.SELECTBYPARANTIDRowChangingEvent;
					if (sELECTBYPARANTIDRowChangingEvent != null)
					{
						sELECTBYPARANTIDRowChangingEvent(this, new EKBTreeDataset.SELECTBYPARANTIDRowChangeEvent((EKBTreeDataset.SELECTBYPARANTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTBYPARANTIDRowDeletedEvent != null)
				{
					EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler sELECTBYPARANTIDRowDeletedEvent = this.SELECTBYPARANTIDRowDeletedEvent;
					if (sELECTBYPARANTIDRowDeletedEvent != null)
					{
						sELECTBYPARANTIDRowDeletedEvent(this, new EKBTreeDataset.SELECTBYPARANTIDRowChangeEvent((EKBTreeDataset.SELECTBYPARANTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTBYPARANTIDRowDeletingEvent != null)
				{
					EKBTreeDataset.SELECTBYPARANTIDRowChangeEventHandler sELECTBYPARANTIDRowDeletingEvent = this.SELECTBYPARANTIDRowDeletingEvent;
					if (sELECTBYPARANTIDRowDeletingEvent != null)
					{
						sELECTBYPARANTIDRowDeletingEvent(this, new EKBTreeDataset.SELECTBYPARANTIDRowChangeEvent((EKBTreeDataset.SELECTBYPARANTIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTBYPARANTIDRow(EKBTreeDataset.SELECTBYPARANTIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBTreeDataset eKBTreeDataset = new EKBTreeDataset();
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
				xmlSchemaAttribute.FixedValue = eKBTreeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTBYPARANTIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBTreeDataset.GetSchemaSerializable();
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
		public class SELECTBYPARANTIDRow : DataRow
		{
			private EKBTreeDataset.SELECTBYPARANTIDDataTable tableSELECTBYPARANTID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTBYPARANTID.IDColumn]);
				}
				set
				{
					this[this.tableSELECTBYPARANTID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.ParentIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"ParentID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.ParentIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.KnowledgeBaseIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"KnowledgeBaseID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.KnowledgeBaseIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long ResChildCount
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTBYPARANTID.ResChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"ResChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.ResChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PersonalKBUserID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.PersonalKBUserIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"PersonalKBUserID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.PersonalKBUserIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYPARANTID.SequenceColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYPARANTID\"中列\"Sequence\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYPARANTID.SequenceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTBYPARANTIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTBYPARANTID = (EKBTreeDataset.SELECTBYPARANTIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTBYPARANTID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParentIDNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.ParentIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetParentIDNull()
			{
				this[this.tableSELECTBYPARANTID.ParentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKnowledgeBaseIDNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.KnowledgeBaseIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKnowledgeBaseIDNull()
			{
				this[this.tableSELECTBYPARANTID.KnowledgeBaseIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTBYPARANTID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsResChildCountNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.ResChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetResChildCountNull()
			{
				this[this.tableSELECTBYPARANTID.ResChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPersonalKBUserIDNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.PersonalKBUserIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetPersonalKBUserIDNull()
			{
				this[this.tableSELECTBYPARANTID.PersonalKBUserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSequenceNull()
			{
				return this.IsNull(this.tableSELECTBYPARANTID.SequenceColumn);
			}

			[DebuggerNonUserCode]
			public void SetSequenceNull()
			{
				this[this.tableSELECTBYPARANTID.SequenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTBYPARANTIDRowChangeEvent : EventArgs
		{
			private EKBTreeDataset.SELECTBYPARANTIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBTreeDataset.SELECTBYPARANTIDRow Row
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
			public SELECTBYPARANTIDRowChangeEvent(EKBTreeDataset.SELECTBYPARANTIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBTreeDataset.SELECTBYPARANTIDDataTable tableSELECTBYPARANTID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBTreeDataset.SELECTBYPARANTIDDataTable SELECTBYPARANTID
		{
			get
			{
				return this.tableSELECTBYPARANTID;
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
		public EKBTreeDataset()
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
		protected EKBTreeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTBYPARANTID"] != null)
				{
					base.Tables.Add(new EKBTreeDataset.SELECTBYPARANTIDDataTable(dataSet.Tables["SELECTBYPARANTID"]));
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
			EKBTreeDataset eKBTreeDataset = (EKBTreeDataset)base.Clone();
			eKBTreeDataset.InitVars();
			eKBTreeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBTreeDataset;
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
				if (dataSet.Tables["SELECTBYPARANTID"] != null)
				{
					base.Tables.Add(new EKBTreeDataset.SELECTBYPARANTIDDataTable(dataSet.Tables["SELECTBYPARANTID"]));
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
			this.tableSELECTBYPARANTID = (EKBTreeDataset.SELECTBYPARANTIDDataTable)base.Tables["SELECTBYPARANTID"];
			if (initTable && this.tableSELECTBYPARANTID != null)
			{
				this.tableSELECTBYPARANTID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBTreeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBTreeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTBYPARANTID = new EKBTreeDataset.SELECTBYPARANTIDDataTable();
			base.Tables.Add(this.tableSELECTBYPARANTID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTBYPARANTID()
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
			EKBTreeDataset eKBTreeDataset = new EKBTreeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBTreeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBTreeDataset.GetSchemaSerializable();
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
