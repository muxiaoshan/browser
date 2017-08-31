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

namespace LISData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ELISItemListByDateDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ELISItemListByDateDataSet : DataSet
	{
		public delegate void SelectLISItemListByDateRowChangeEventHandler(object sender, ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectLISItemListByDateDataTable : DataTable, IEnumerable
		{
			private DataColumn columnOEordItemRowID;

			private DataColumn columnOEordItemDesc;

			private DataColumn columnLabEpisodeNo;

			private DataColumn columnSpecimenDesc;

			private DataColumn columnCollectionDate;

			private DataColumn columnCollectionTime;

			private DataColumn columnReceiveDate;

			private DataColumn columnReceiveTime;

			private DataColumn columnAuthorisationDate;

			private DataColumn columnAuthorisationTime;

			private DataColumn columnExistReport;

			private ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowChangingEvent;

			private ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowChangedEvent;

			private ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowDeletingEvent;

			private ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowDeletedEvent;

			public event ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByDateRowChangingEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByDateRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByDateRowChangingEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByDateRowChangingEvent, value);
				}
			}

			public event ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByDateRowChangedEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByDateRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByDateRowChangedEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByDateRowChangedEvent, value);
				}
			}

			public event ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByDateRowDeletingEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByDateRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByDateRowDeletingEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByDateRowDeletingEvent, value);
				}
			}

			public event ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler SelectLISItemListByDateRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByDateRowDeletedEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByDateRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByDateRowDeletedEvent = (ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByDateRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OEordItemRowIDColumn
			{
				get
				{
					return this.columnOEordItemRowID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OEordItemDescColumn
			{
				get
				{
					return this.columnOEordItemDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn LabEpisodeNoColumn
			{
				get
				{
					return this.columnLabEpisodeNo;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SpecimenDescColumn
			{
				get
				{
					return this.columnSpecimenDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CollectionDateColumn
			{
				get
				{
					return this.columnCollectionDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CollectionTimeColumn
			{
				get
				{
					return this.columnCollectionTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ReceiveDateColumn
			{
				get
				{
					return this.columnReceiveDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ReceiveTimeColumn
			{
				get
				{
					return this.columnReceiveTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AuthorisationDateColumn
			{
				get
				{
					return this.columnAuthorisationDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AuthorisationTimeColumn
			{
				get
				{
					return this.columnAuthorisationTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ExistReportColumn
			{
				get
				{
					return this.columnExistReport;
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
			public ELISItemListByDateDataSet.SelectLISItemListByDateRow this[int index]
			{
				get
				{
					return (ELISItemListByDateDataSet.SelectLISItemListByDateRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectLISItemListByDateDataTable()
			{
				this.TableName = "SelectLISItemListByDate";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectLISItemListByDateDataTable(DataTable table)
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
			protected SelectLISItemListByDateDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectLISItemListByDateRow(ELISItemListByDateDataSet.SelectLISItemListByDateRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ELISItemListByDateDataSet.SelectLISItemListByDateRow AddSelectLISItemListByDateRow(string OEordItemRowID, string OEordItemDesc, string LabEpisodeNo, string SpecimenDesc, string CollectionDate, string CollectionTime, string ReceiveDate, string ReceiveTime, string AuthorisationDate, string AuthorisationTime, string ExistReport)
			{
				ELISItemListByDateDataSet.SelectLISItemListByDateRow selectLISItemListByDateRow = (ELISItemListByDateDataSet.SelectLISItemListByDateRow)this.NewRow();
				object[] itemArray = new object[]
				{
					OEordItemRowID,
					OEordItemDesc,
					LabEpisodeNo,
					SpecimenDesc,
					CollectionDate,
					CollectionTime,
					ReceiveDate,
					ReceiveTime,
					AuthorisationDate,
					AuthorisationTime,
					ExistReport
				};
				selectLISItemListByDateRow.ItemArray = itemArray;
				this.Rows.Add(selectLISItemListByDateRow);
				return selectLISItemListByDateRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ELISItemListByDateDataSet.SelectLISItemListByDateDataTable selectLISItemListByDateDataTable = (ELISItemListByDateDataSet.SelectLISItemListByDateDataTable)base.Clone();
				selectLISItemListByDateDataTable.InitVars();
				return selectLISItemListByDateDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ELISItemListByDateDataSet.SelectLISItemListByDateDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnOEordItemRowID = base.Columns["OEordItemRowID"];
				this.columnOEordItemDesc = base.Columns["OEordItemDesc"];
				this.columnLabEpisodeNo = base.Columns["LabEpisodeNo"];
				this.columnSpecimenDesc = base.Columns["SpecimenDesc"];
				this.columnCollectionDate = base.Columns["CollectionDate"];
				this.columnCollectionTime = base.Columns["CollectionTime"];
				this.columnReceiveDate = base.Columns["ReceiveDate"];
				this.columnReceiveTime = base.Columns["ReceiveTime"];
				this.columnAuthorisationDate = base.Columns["AuthorisationDate"];
				this.columnAuthorisationTime = base.Columns["AuthorisationTime"];
				this.columnExistReport = base.Columns["ExistReport"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnOEordItemRowID = new DataColumn("OEordItemRowID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOEordItemRowID);
				this.columnOEordItemDesc = new DataColumn("OEordItemDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOEordItemDesc);
				this.columnLabEpisodeNo = new DataColumn("LabEpisodeNo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLabEpisodeNo);
				this.columnSpecimenDesc = new DataColumn("SpecimenDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSpecimenDesc);
				this.columnCollectionDate = new DataColumn("CollectionDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCollectionDate);
				this.columnCollectionTime = new DataColumn("CollectionTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCollectionTime);
				this.columnReceiveDate = new DataColumn("ReceiveDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnReceiveDate);
				this.columnReceiveTime = new DataColumn("ReceiveTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnReceiveTime);
				this.columnAuthorisationDate = new DataColumn("AuthorisationDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAuthorisationDate);
				this.columnAuthorisationTime = new DataColumn("AuthorisationTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAuthorisationTime);
				this.columnExistReport = new DataColumn("ExistReport", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnExistReport);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ELISItemListByDateDataSet.SelectLISItemListByDateRow NewSelectLISItemListByDateRow()
			{
				return (ELISItemListByDateDataSet.SelectLISItemListByDateRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ELISItemListByDateDataSet.SelectLISItemListByDateRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ELISItemListByDateDataSet.SelectLISItemListByDateRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectLISItemListByDateRowChangedEvent != null)
				{
					ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler selectLISItemListByDateRowChangedEvent = this.SelectLISItemListByDateRowChangedEvent;
					if (selectLISItemListByDateRowChangedEvent != null)
					{
						selectLISItemListByDateRowChangedEvent(this, new ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEvent((ELISItemListByDateDataSet.SelectLISItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectLISItemListByDateRowChangingEvent != null)
				{
					ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler selectLISItemListByDateRowChangingEvent = this.SelectLISItemListByDateRowChangingEvent;
					if (selectLISItemListByDateRowChangingEvent != null)
					{
						selectLISItemListByDateRowChangingEvent(this, new ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEvent((ELISItemListByDateDataSet.SelectLISItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectLISItemListByDateRowDeletedEvent != null)
				{
					ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler selectLISItemListByDateRowDeletedEvent = this.SelectLISItemListByDateRowDeletedEvent;
					if (selectLISItemListByDateRowDeletedEvent != null)
					{
						selectLISItemListByDateRowDeletedEvent(this, new ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEvent((ELISItemListByDateDataSet.SelectLISItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectLISItemListByDateRowDeletingEvent != null)
				{
					ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEventHandler selectLISItemListByDateRowDeletingEvent = this.SelectLISItemListByDateRowDeletingEvent;
					if (selectLISItemListByDateRowDeletingEvent != null)
					{
						selectLISItemListByDateRowDeletingEvent(this, new ELISItemListByDateDataSet.SelectLISItemListByDateRowChangeEvent((ELISItemListByDateDataSet.SelectLISItemListByDateRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectLISItemListByDateRow(ELISItemListByDateDataSet.SelectLISItemListByDateRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ELISItemListByDateDataSet eLISItemListByDateDataSet = new ELISItemListByDateDataSet();
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
				xmlSchemaAttribute.FixedValue = eLISItemListByDateDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectLISItemListByDateDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eLISItemListByDateDataSet.GetSchemaSerializable();
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
		public class SelectLISItemListByDateRow : DataRow
		{
			private ELISItemListByDateDataSet.SelectLISItemListByDateDataTable tableSelectLISItemListByDate;

			[DebuggerNonUserCode]
			public string OEordItemRowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.OEordItemRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"OEordItemRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.OEordItemRowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OEordItemDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.OEordItemDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"OEordItemDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.OEordItemDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string LabEpisodeNo
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.LabEpisodeNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"LabEpisodeNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.LabEpisodeNoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string SpecimenDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.SpecimenDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"SpecimenDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.SpecimenDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CollectionDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.CollectionDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"CollectionDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.CollectionDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CollectionTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.CollectionTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"CollectionTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.CollectionTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ReceiveDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.ReceiveDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"ReceiveDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.ReceiveDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ReceiveTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.ReceiveTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"ReceiveTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.ReceiveTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AuthorisationDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.AuthorisationDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"AuthorisationDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.AuthorisationDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AuthorisationTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.AuthorisationTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"AuthorisationTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.AuthorisationTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ExistReport
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByDate.ExistReportColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByDate\"中列\"ExistReport\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByDate.ExistReportColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectLISItemListByDateRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectLISItemListByDate = (ELISItemListByDateDataSet.SelectLISItemListByDateDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemRowIDNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.OEordItemRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemRowIDNull()
			{
				this[this.tableSelectLISItemListByDate.OEordItemRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemDescNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.OEordItemDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemDescNull()
			{
				this[this.tableSelectLISItemListByDate.OEordItemDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLabEpisodeNoNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.LabEpisodeNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetLabEpisodeNoNull()
			{
				this[this.tableSelectLISItemListByDate.LabEpisodeNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSpecimenDescNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.SpecimenDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetSpecimenDescNull()
			{
				this[this.tableSelectLISItemListByDate.SpecimenDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.CollectionDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionDateNull()
			{
				this[this.tableSelectLISItemListByDate.CollectionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.CollectionTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionTimeNull()
			{
				this[this.tableSelectLISItemListByDate.CollectionTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.ReceiveDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveDateNull()
			{
				this[this.tableSelectLISItemListByDate.ReceiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.ReceiveTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveTimeNull()
			{
				this[this.tableSelectLISItemListByDate.ReceiveTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.AuthorisationDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationDateNull()
			{
				this[this.tableSelectLISItemListByDate.AuthorisationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.AuthorisationTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationTimeNull()
			{
				this[this.tableSelectLISItemListByDate.AuthorisationTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsExistReportNull()
			{
				return this.IsNull(this.tableSelectLISItemListByDate.ExistReportColumn);
			}

			[DebuggerNonUserCode]
			public void SetExistReportNull()
			{
				this[this.tableSelectLISItemListByDate.ExistReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectLISItemListByDateRowChangeEvent : EventArgs
		{
			private ELISItemListByDateDataSet.SelectLISItemListByDateRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ELISItemListByDateDataSet.SelectLISItemListByDateRow Row
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
			public SelectLISItemListByDateRowChangeEvent(ELISItemListByDateDataSet.SelectLISItemListByDateRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ELISItemListByDateDataSet.SelectLISItemListByDateDataTable tableSelectLISItemListByDate;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ELISItemListByDateDataSet.SelectLISItemListByDateDataTable SelectLISItemListByDate
		{
			get
			{
				return this.tableSelectLISItemListByDate;
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
		public ELISItemListByDateDataSet()
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
		protected ELISItemListByDateDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectLISItemListByDate"] != null)
				{
					base.Tables.Add(new ELISItemListByDateDataSet.SelectLISItemListByDateDataTable(dataSet.Tables["SelectLISItemListByDate"]));
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
			ELISItemListByDateDataSet eLISItemListByDateDataSet = (ELISItemListByDateDataSet)base.Clone();
			eLISItemListByDateDataSet.InitVars();
			eLISItemListByDateDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eLISItemListByDateDataSet;
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
				if (dataSet.Tables["SelectLISItemListByDate"] != null)
				{
					base.Tables.Add(new ELISItemListByDateDataSet.SelectLISItemListByDateDataTable(dataSet.Tables["SelectLISItemListByDate"]));
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
			this.tableSelectLISItemListByDate = (ELISItemListByDateDataSet.SelectLISItemListByDateDataTable)base.Tables["SelectLISItemListByDate"];
			if (initTable && this.tableSelectLISItemListByDate != null)
			{
				this.tableSelectLISItemListByDate.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ELISItemListByDateDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ELISItemListByDateDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectLISItemListByDate = new ELISItemListByDateDataSet.SelectLISItemListByDateDataTable();
			base.Tables.Add(this.tableSelectLISItemListByDate);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectLISItemListByDate()
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
			ELISItemListByDateDataSet eLISItemListByDateDataSet = new ELISItemListByDateDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eLISItemListByDateDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eLISItemListByDateDataSet.GetSchemaSerializable();
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
