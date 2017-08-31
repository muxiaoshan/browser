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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ELISItemListByCountDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ELISItemListByCountDataset : DataSet
	{
		public delegate void SelectLISItemListByCountRowChangeEventHandler(object sender, ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectLISItemListByCountDataTable : DataTable, IEnumerable
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

			private ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowChangingEvent;

			private ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowChangedEvent;

			private ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowDeletingEvent;

			private ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowDeletedEvent;

			public event ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByCountRowChangingEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByCountRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByCountRowChangingEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByCountRowChangingEvent, value);
				}
			}

			public event ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByCountRowChangedEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByCountRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByCountRowChangedEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByCountRowChangedEvent, value);
				}
			}

			public event ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByCountRowDeletingEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByCountRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByCountRowDeletingEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByCountRowDeletingEvent, value);
				}
			}

			public event ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler SelectLISItemListByCountRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectLISItemListByCountRowDeletedEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Combine(this.SelectLISItemListByCountRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectLISItemListByCountRowDeletedEvent = (ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler)Delegate.Remove(this.SelectLISItemListByCountRowDeletedEvent, value);
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
			public ELISItemListByCountDataset.SelectLISItemListByCountRow this[int index]
			{
				get
				{
					return (ELISItemListByCountDataset.SelectLISItemListByCountRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectLISItemListByCountDataTable()
			{
				this.TableName = "SelectLISItemListByCount";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectLISItemListByCountDataTable(DataTable table)
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
			protected SelectLISItemListByCountDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectLISItemListByCountRow(ELISItemListByCountDataset.SelectLISItemListByCountRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ELISItemListByCountDataset.SelectLISItemListByCountRow AddSelectLISItemListByCountRow(string OEordItemRowID, string OEordItemDesc, string LabEpisodeNo, string SpecimenDesc, string CollectionDate, string CollectionTime, string ReceiveDate, string ReceiveTime, string AuthorisationDate, string AuthorisationTime, string ExistReport)
			{
				ELISItemListByCountDataset.SelectLISItemListByCountRow selectLISItemListByCountRow = (ELISItemListByCountDataset.SelectLISItemListByCountRow)this.NewRow();
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
				selectLISItemListByCountRow.ItemArray = itemArray;
				this.Rows.Add(selectLISItemListByCountRow);
				return selectLISItemListByCountRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ELISItemListByCountDataset.SelectLISItemListByCountDataTable selectLISItemListByCountDataTable = (ELISItemListByCountDataset.SelectLISItemListByCountDataTable)base.Clone();
				selectLISItemListByCountDataTable.InitVars();
				return selectLISItemListByCountDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ELISItemListByCountDataset.SelectLISItemListByCountDataTable();
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
			public ELISItemListByCountDataset.SelectLISItemListByCountRow NewSelectLISItemListByCountRow()
			{
				return (ELISItemListByCountDataset.SelectLISItemListByCountRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ELISItemListByCountDataset.SelectLISItemListByCountRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ELISItemListByCountDataset.SelectLISItemListByCountRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectLISItemListByCountRowChangedEvent != null)
				{
					ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler selectLISItemListByCountRowChangedEvent = this.SelectLISItemListByCountRowChangedEvent;
					if (selectLISItemListByCountRowChangedEvent != null)
					{
						selectLISItemListByCountRowChangedEvent(this, new ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEvent((ELISItemListByCountDataset.SelectLISItemListByCountRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectLISItemListByCountRowChangingEvent != null)
				{
					ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler selectLISItemListByCountRowChangingEvent = this.SelectLISItemListByCountRowChangingEvent;
					if (selectLISItemListByCountRowChangingEvent != null)
					{
						selectLISItemListByCountRowChangingEvent(this, new ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEvent((ELISItemListByCountDataset.SelectLISItemListByCountRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectLISItemListByCountRowDeletedEvent != null)
				{
					ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler selectLISItemListByCountRowDeletedEvent = this.SelectLISItemListByCountRowDeletedEvent;
					if (selectLISItemListByCountRowDeletedEvent != null)
					{
						selectLISItemListByCountRowDeletedEvent(this, new ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEvent((ELISItemListByCountDataset.SelectLISItemListByCountRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectLISItemListByCountRowDeletingEvent != null)
				{
					ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEventHandler selectLISItemListByCountRowDeletingEvent = this.SelectLISItemListByCountRowDeletingEvent;
					if (selectLISItemListByCountRowDeletingEvent != null)
					{
						selectLISItemListByCountRowDeletingEvent(this, new ELISItemListByCountDataset.SelectLISItemListByCountRowChangeEvent((ELISItemListByCountDataset.SelectLISItemListByCountRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectLISItemListByCountRow(ELISItemListByCountDataset.SelectLISItemListByCountRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ELISItemListByCountDataset eLISItemListByCountDataset = new ELISItemListByCountDataset();
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
				xmlSchemaAttribute.FixedValue = eLISItemListByCountDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectLISItemListByCountDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eLISItemListByCountDataset.GetSchemaSerializable();
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
		public class SelectLISItemListByCountRow : DataRow
		{
			private ELISItemListByCountDataset.SelectLISItemListByCountDataTable tableSelectLISItemListByCount;

			[DebuggerNonUserCode]
			public string OEordItemRowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.OEordItemRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"OEordItemRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.OEordItemRowIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.OEordItemDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"OEordItemDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.OEordItemDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.LabEpisodeNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"LabEpisodeNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.LabEpisodeNoColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.SpecimenDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"SpecimenDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.SpecimenDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.CollectionDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"CollectionDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.CollectionDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.CollectionTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"CollectionTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.CollectionTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.ReceiveDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"ReceiveDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.ReceiveDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.ReceiveTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"ReceiveTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.ReceiveTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.AuthorisationDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"AuthorisationDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.AuthorisationDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.AuthorisationTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"AuthorisationTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.AuthorisationTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectLISItemListByCount.ExistReportColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectLISItemListByCount\"中列\"ExistReport\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectLISItemListByCount.ExistReportColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectLISItemListByCountRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectLISItemListByCount = (ELISItemListByCountDataset.SelectLISItemListByCountDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemRowIDNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.OEordItemRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemRowIDNull()
			{
				this[this.tableSelectLISItemListByCount.OEordItemRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemDescNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.OEordItemDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemDescNull()
			{
				this[this.tableSelectLISItemListByCount.OEordItemDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLabEpisodeNoNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.LabEpisodeNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetLabEpisodeNoNull()
			{
				this[this.tableSelectLISItemListByCount.LabEpisodeNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSpecimenDescNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.SpecimenDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetSpecimenDescNull()
			{
				this[this.tableSelectLISItemListByCount.SpecimenDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.CollectionDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionDateNull()
			{
				this[this.tableSelectLISItemListByCount.CollectionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.CollectionTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionTimeNull()
			{
				this[this.tableSelectLISItemListByCount.CollectionTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.ReceiveDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveDateNull()
			{
				this[this.tableSelectLISItemListByCount.ReceiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.ReceiveTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveTimeNull()
			{
				this[this.tableSelectLISItemListByCount.ReceiveTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationDateNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.AuthorisationDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationDateNull()
			{
				this[this.tableSelectLISItemListByCount.AuthorisationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationTimeNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.AuthorisationTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationTimeNull()
			{
				this[this.tableSelectLISItemListByCount.AuthorisationTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsExistReportNull()
			{
				return this.IsNull(this.tableSelectLISItemListByCount.ExistReportColumn);
			}

			[DebuggerNonUserCode]
			public void SetExistReportNull()
			{
				this[this.tableSelectLISItemListByCount.ExistReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectLISItemListByCountRowChangeEvent : EventArgs
		{
			private ELISItemListByCountDataset.SelectLISItemListByCountRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ELISItemListByCountDataset.SelectLISItemListByCountRow Row
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
			public SelectLISItemListByCountRowChangeEvent(ELISItemListByCountDataset.SelectLISItemListByCountRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ELISItemListByCountDataset.SelectLISItemListByCountDataTable tableSelectLISItemListByCount;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ELISItemListByCountDataset.SelectLISItemListByCountDataTable SelectLISItemListByCount
		{
			get
			{
				return this.tableSelectLISItemListByCount;
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
		public ELISItemListByCountDataset()
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
		protected ELISItemListByCountDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectLISItemListByCount"] != null)
				{
					base.Tables.Add(new ELISItemListByCountDataset.SelectLISItemListByCountDataTable(dataSet.Tables["SelectLISItemListByCount"]));
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
			ELISItemListByCountDataset eLISItemListByCountDataset = (ELISItemListByCountDataset)base.Clone();
			eLISItemListByCountDataset.InitVars();
			eLISItemListByCountDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eLISItemListByCountDataset;
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
				if (dataSet.Tables["SelectLISItemListByCount"] != null)
				{
					base.Tables.Add(new ELISItemListByCountDataset.SelectLISItemListByCountDataTable(dataSet.Tables["SelectLISItemListByCount"]));
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
			this.tableSelectLISItemListByCount = (ELISItemListByCountDataset.SelectLISItemListByCountDataTable)base.Tables["SelectLISItemListByCount"];
			if (initTable && this.tableSelectLISItemListByCount != null)
			{
				this.tableSelectLISItemListByCount.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ELISItemListByCountDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ELISItemListByCountDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectLISItemListByCount = new ELISItemListByCountDataset.SelectLISItemListByCountDataTable();
			base.Tables.Add(this.tableSelectLISItemListByCount);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectLISItemListByCount()
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
			ELISItemListByCountDataset eLISItemListByCountDataset = new ELISItemListByCountDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eLISItemListByCountDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eLISItemListByCountDataset.GetSchemaSerializable();
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
