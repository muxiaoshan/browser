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

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ETemplateVersionDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ETemplateVersionDataset : DataSet
	{
		public delegate void SELECTALLRowChangeEventHandler(object sender, ETemplateVersionDataset.SELECTALLRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnTemplateID;

			private DataColumn columnAuthor;

			private DataColumn columnLastSaveDate;

			private DataColumn columnLastSaveTime;

			private DataColumn columnPublicationDate;

			private DataColumn columnPublicationTime;

			private DataColumn columnCreateDate;

			private DataColumn columnCreateTime;

			private DataColumn columnStatus;

			private DataColumn columnVersionNumber;

			private ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangingEvent;

			private ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangedEvent;

			private ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletingEvent;

			private ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletedEvent;

			public event ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangingEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangingEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangingEvent, value);
				}
			}

			public event ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangedEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangedEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangedEvent, value);
				}
			}

			public event ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletingEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletingEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletingEvent, value);
				}
			}

			public event ETemplateVersionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletedEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletedEvent = (ETemplateVersionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletedEvent, value);
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
			public DataColumn TemplateIDColumn
			{
				get
				{
					return this.columnTemplateID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AuthorColumn
			{
				get
				{
					return this.columnAuthor;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn LastSaveDateColumn
			{
				get
				{
					return this.columnLastSaveDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn LastSaveTimeColumn
			{
				get
				{
					return this.columnLastSaveTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PublicationDateColumn
			{
				get
				{
					return this.columnPublicationDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PublicationTimeColumn
			{
				get
				{
					return this.columnPublicationTime;
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
			public DataColumn VersionNumberColumn
			{
				get
				{
					return this.columnVersionNumber;
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
			public ETemplateVersionDataset.SELECTALLRow this[int index]
			{
				get
				{
					return (ETemplateVersionDataset.SELECTALLRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLDataTable()
			{
				this.TableName = "SELECTALL";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLDataTable(DataTable table)
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
			protected SELECTALLDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLRow(ETemplateVersionDataset.SELECTALLRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ETemplateVersionDataset.SELECTALLRow AddSELECTALLRow(long ID, string TemplateID, string Author, DateTime LastSaveDate, DateTime LastSaveTime, DateTime PublicationDate, DateTime PublicationTime, DateTime CreateDate, DateTime CreateTime, long Status, long VersionNumber)
			{
				ETemplateVersionDataset.SELECTALLRow sELECTALLRow = (ETemplateVersionDataset.SELECTALLRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					TemplateID,
					Author,
					LastSaveDate,
					LastSaveTime,
					PublicationDate,
					PublicationTime,
					CreateDate,
					CreateTime,
					Status,
					VersionNumber
				};
				sELECTALLRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLRow);
				return sELECTALLRow;
			}

			[DebuggerNonUserCode]
			public ETemplateVersionDataset.SELECTALLRow FindByID(long ID)
			{
				return (ETemplateVersionDataset.SELECTALLRow)this.Rows.Find(new object[]
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
				ETemplateVersionDataset.SELECTALLDataTable sELECTALLDataTable = (ETemplateVersionDataset.SELECTALLDataTable)base.Clone();
				sELECTALLDataTable.InitVars();
				return sELECTALLDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ETemplateVersionDataset.SELECTALLDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnTemplateID = base.Columns["TemplateID"];
				this.columnAuthor = base.Columns["Author"];
				this.columnLastSaveDate = base.Columns["LastSaveDate"];
				this.columnLastSaveTime = base.Columns["LastSaveTime"];
				this.columnPublicationDate = base.Columns["PublicationDate"];
				this.columnPublicationTime = base.Columns["PublicationTime"];
				this.columnCreateDate = base.Columns["CreateDate"];
				this.columnCreateTime = base.Columns["CreateTime"];
				this.columnStatus = base.Columns["Status"];
				this.columnVersionNumber = base.Columns["VersionNumber"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnTemplateID = new DataColumn("TemplateID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateID);
				this.columnAuthor = new DataColumn("Author", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAuthor);
				this.columnLastSaveDate = new DataColumn("LastSaveDate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnLastSaveDate);
				this.columnLastSaveTime = new DataColumn("LastSaveTime", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnLastSaveTime);
				this.columnPublicationDate = new DataColumn("PublicationDate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnPublicationDate);
				this.columnPublicationTime = new DataColumn("PublicationTime", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnPublicationTime);
				this.columnCreateDate = new DataColumn("CreateDate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnCreateDate);
				this.columnCreateTime = new DataColumn("CreateTime", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnCreateTime);
				this.columnStatus = new DataColumn("Status", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnStatus);
				this.columnVersionNumber = new DataColumn("VersionNumber", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnVersionNumber);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ETemplateVersionDataset.SELECTALLRow NewSELECTALLRow()
			{
				return (ETemplateVersionDataset.SELECTALLRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ETemplateVersionDataset.SELECTALLRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ETemplateVersionDataset.SELECTALLRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLRowChangedEvent != null)
				{
					ETemplateVersionDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangedEvent = this.SELECTALLRowChangedEvent;
					if (sELECTALLRowChangedEvent != null)
					{
						sELECTALLRowChangedEvent(this, new ETemplateVersionDataset.SELECTALLRowChangeEvent((ETemplateVersionDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLRowChangingEvent != null)
				{
					ETemplateVersionDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangingEvent = this.SELECTALLRowChangingEvent;
					if (sELECTALLRowChangingEvent != null)
					{
						sELECTALLRowChangingEvent(this, new ETemplateVersionDataset.SELECTALLRowChangeEvent((ETemplateVersionDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLRowDeletedEvent != null)
				{
					ETemplateVersionDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletedEvent = this.SELECTALLRowDeletedEvent;
					if (sELECTALLRowDeletedEvent != null)
					{
						sELECTALLRowDeletedEvent(this, new ETemplateVersionDataset.SELECTALLRowChangeEvent((ETemplateVersionDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLRowDeletingEvent != null)
				{
					ETemplateVersionDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletingEvent = this.SELECTALLRowDeletingEvent;
					if (sELECTALLRowDeletingEvent != null)
					{
						sELECTALLRowDeletingEvent(this, new ETemplateVersionDataset.SELECTALLRowChangeEvent((ETemplateVersionDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLRow(ETemplateVersionDataset.SELECTALLRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ETemplateVersionDataset eTemplateVersionDataset = new ETemplateVersionDataset();
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
				xmlSchemaAttribute.FixedValue = eTemplateVersionDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eTemplateVersionDataset.GetSchemaSerializable();
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
		public class SELECTALLRow : DataRow
		{
			private ETemplateVersionDataset.SELECTALLDataTable tableSELECTALL;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALL.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALL.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string TemplateID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.TemplateIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"TemplateID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.TemplateIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Author
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.AuthorColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Author\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.AuthorColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime LastSaveDate
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.LastSaveDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"LastSaveDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.LastSaveDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime LastSaveTime
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.LastSaveTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"LastSaveTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.LastSaveTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime PublicationDate
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.PublicationDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"PublicationDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.PublicationDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime PublicationTime
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.PublicationTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"PublicationTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.PublicationTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime CreateDate
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.CreateDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"CreateDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.CreateDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime CreateTime
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableSELECTALL.CreateTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"CreateTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.CreateTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long Status
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTALL.StatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Status\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.StatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long VersionNumber
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTALL.VersionNumberColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"VersionNumber\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.VersionNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALL = (ETemplateVersionDataset.SELECTALLDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsTemplateIDNull()
			{
				return this.IsNull(this.tableSELECTALL.TemplateIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplateIDNull()
			{
				this[this.tableSELECTALL.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorNull()
			{
				return this.IsNull(this.tableSELECTALL.AuthorColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorNull()
			{
				this[this.tableSELECTALL.AuthorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLastSaveDateNull()
			{
				return this.IsNull(this.tableSELECTALL.LastSaveDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetLastSaveDateNull()
			{
				this[this.tableSELECTALL.LastSaveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLastSaveTimeNull()
			{
				return this.IsNull(this.tableSELECTALL.LastSaveTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetLastSaveTimeNull()
			{
				this[this.tableSELECTALL.LastSaveTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPublicationDateNull()
			{
				return this.IsNull(this.tableSELECTALL.PublicationDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetPublicationDateNull()
			{
				this[this.tableSELECTALL.PublicationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPublicationTimeNull()
			{
				return this.IsNull(this.tableSELECTALL.PublicationTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetPublicationTimeNull()
			{
				this[this.tableSELECTALL.PublicationTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCreateDateNull()
			{
				return this.IsNull(this.tableSELECTALL.CreateDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCreateDateNull()
			{
				this[this.tableSELECTALL.CreateDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCreateTimeNull()
			{
				return this.IsNull(this.tableSELECTALL.CreateTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCreateTimeNull()
			{
				this[this.tableSELECTALL.CreateTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsStatusNull()
			{
				return this.IsNull(this.tableSELECTALL.StatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetStatusNull()
			{
				this[this.tableSELECTALL.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsVersionNumberNull()
			{
				return this.IsNull(this.tableSELECTALL.VersionNumberColumn);
			}

			[DebuggerNonUserCode]
			public void SetVersionNumberNull()
			{
				this[this.tableSELECTALL.VersionNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLRowChangeEvent : EventArgs
		{
			private ETemplateVersionDataset.SELECTALLRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ETemplateVersionDataset.SELECTALLRow Row
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
			public SELECTALLRowChangeEvent(ETemplateVersionDataset.SELECTALLRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ETemplateVersionDataset.SELECTALLDataTable tableSELECTALL;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ETemplateVersionDataset.SELECTALLDataTable SELECTALL
		{
			get
			{
				return this.tableSELECTALL;
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
		public ETemplateVersionDataset()
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
		protected ETemplateVersionDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new ETemplateVersionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			ETemplateVersionDataset eTemplateVersionDataset = (ETemplateVersionDataset)base.Clone();
			eTemplateVersionDataset.InitVars();
			eTemplateVersionDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eTemplateVersionDataset;
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new ETemplateVersionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			this.tableSELECTALL = (ETemplateVersionDataset.SELECTALLDataTable)base.Tables["SELECTALL"];
			if (initTable && this.tableSELECTALL != null)
			{
				this.tableSELECTALL.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ETemplateVersionDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ETemplateVersionDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALL = new ETemplateVersionDataset.SELECTALLDataTable();
			base.Tables.Add(this.tableSELECTALL);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALL()
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
			ETemplateVersionDataset eTemplateVersionDataset = new ETemplateVersionDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eTemplateVersionDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eTemplateVersionDataset.GetSchemaSerializable();
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
