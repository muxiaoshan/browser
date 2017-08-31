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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ELISDataListDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ELISDataListDataSet : DataSet
	{
		public delegate void GetListDataListRowChangeEventHandler(object sender, ELISDataListDataSet.GetListDataListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetListDataListDataTable : DataTable, IEnumerable
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

			private DataColumn columnEpisodeDate;

			private DataColumn columnEpisodeSection;

			private ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowChangingEvent;

			private ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowChangedEvent;

			private ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowDeletingEvent;

			private ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowDeletedEvent;

			public event ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetListDataListRowChangingEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Combine(this.GetListDataListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetListDataListRowChangingEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Remove(this.GetListDataListRowChangingEvent, value);
				}
			}

			public event ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetListDataListRowChangedEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Combine(this.GetListDataListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetListDataListRowChangedEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Remove(this.GetListDataListRowChangedEvent, value);
				}
			}

			public event ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetListDataListRowDeletingEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Combine(this.GetListDataListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetListDataListRowDeletingEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Remove(this.GetListDataListRowDeletingEvent, value);
				}
			}

			public event ELISDataListDataSet.GetListDataListRowChangeEventHandler GetListDataListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetListDataListRowDeletedEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Combine(this.GetListDataListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetListDataListRowDeletedEvent = (ELISDataListDataSet.GetListDataListRowChangeEventHandler)Delegate.Remove(this.GetListDataListRowDeletedEvent, value);
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

			[DebuggerNonUserCode]
			public DataColumn EpisodeDateColumn
			{
				get
				{
					return this.columnEpisodeDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeSectionColumn
			{
				get
				{
					return this.columnEpisodeSection;
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
			public ELISDataListDataSet.GetListDataListRow this[int index]
			{
				get
				{
					return (ELISDataListDataSet.GetListDataListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetListDataListDataTable()
			{
				this.TableName = "GetListDataList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetListDataListDataTable(DataTable table)
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
			protected GetListDataListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetListDataListRow(ELISDataListDataSet.GetListDataListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ELISDataListDataSet.GetListDataListRow AddGetListDataListRow(string OEordItemRowID, string OEordItemDesc, string LabEpisodeNo, string SpecimenDesc, string CollectionDate, string CollectionTime, string ReceiveDate, string ReceiveTime, string AuthorisationDate, string AuthorisationTime, string ExistReport, string EpisodeDate, string EpisodeSection)
			{
				ELISDataListDataSet.GetListDataListRow getListDataListRow = (ELISDataListDataSet.GetListDataListRow)this.NewRow();
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
					ExistReport,
					EpisodeDate,
					EpisodeSection
				};
				getListDataListRow.ItemArray = itemArray;
				this.Rows.Add(getListDataListRow);
				return getListDataListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ELISDataListDataSet.GetListDataListDataTable getListDataListDataTable = (ELISDataListDataSet.GetListDataListDataTable)base.Clone();
				getListDataListDataTable.InitVars();
				return getListDataListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ELISDataListDataSet.GetListDataListDataTable();
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
				this.columnEpisodeDate = base.Columns["EpisodeDate"];
				this.columnEpisodeSection = base.Columns["EpisodeSection"];
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
				this.columnEpisodeDate = new DataColumn("EpisodeDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeDate);
				this.columnEpisodeSection = new DataColumn("EpisodeSection", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeSection);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ELISDataListDataSet.GetListDataListRow NewGetListDataListRow()
			{
				return (ELISDataListDataSet.GetListDataListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ELISDataListDataSet.GetListDataListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ELISDataListDataSet.GetListDataListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetListDataListRowChangedEvent != null)
				{
					ELISDataListDataSet.GetListDataListRowChangeEventHandler getListDataListRowChangedEvent = this.GetListDataListRowChangedEvent;
					if (getListDataListRowChangedEvent != null)
					{
						getListDataListRowChangedEvent(this, new ELISDataListDataSet.GetListDataListRowChangeEvent((ELISDataListDataSet.GetListDataListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetListDataListRowChangingEvent != null)
				{
					ELISDataListDataSet.GetListDataListRowChangeEventHandler getListDataListRowChangingEvent = this.GetListDataListRowChangingEvent;
					if (getListDataListRowChangingEvent != null)
					{
						getListDataListRowChangingEvent(this, new ELISDataListDataSet.GetListDataListRowChangeEvent((ELISDataListDataSet.GetListDataListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetListDataListRowDeletedEvent != null)
				{
					ELISDataListDataSet.GetListDataListRowChangeEventHandler getListDataListRowDeletedEvent = this.GetListDataListRowDeletedEvent;
					if (getListDataListRowDeletedEvent != null)
					{
						getListDataListRowDeletedEvent(this, new ELISDataListDataSet.GetListDataListRowChangeEvent((ELISDataListDataSet.GetListDataListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetListDataListRowDeletingEvent != null)
				{
					ELISDataListDataSet.GetListDataListRowChangeEventHandler getListDataListRowDeletingEvent = this.GetListDataListRowDeletingEvent;
					if (getListDataListRowDeletingEvent != null)
					{
						getListDataListRowDeletingEvent(this, new ELISDataListDataSet.GetListDataListRowChangeEvent((ELISDataListDataSet.GetListDataListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetListDataListRow(ELISDataListDataSet.GetListDataListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ELISDataListDataSet eLISDataListDataSet = new ELISDataListDataSet();
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
				xmlSchemaAttribute.FixedValue = eLISDataListDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetListDataListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eLISDataListDataSet.GetSchemaSerializable();
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
		public class GetListDataListRow : DataRow
		{
			private ELISDataListDataSet.GetListDataListDataTable tableGetListDataList;

			[DebuggerNonUserCode]
			public string OEordItemRowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetListDataList.OEordItemRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"OEordItemRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.OEordItemRowIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.OEordItemDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"OEordItemDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.OEordItemDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.LabEpisodeNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"LabEpisodeNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.LabEpisodeNoColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.SpecimenDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"SpecimenDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.SpecimenDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.CollectionDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"CollectionDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.CollectionDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.CollectionTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"CollectionTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.CollectionTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.ReceiveDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"ReceiveDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.ReceiveDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.ReceiveTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"ReceiveTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.ReceiveTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.AuthorisationDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"AuthorisationDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.AuthorisationDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.AuthorisationTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"AuthorisationTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.AuthorisationTimeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetListDataList.ExistReportColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"ExistReport\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.ExistReportColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetListDataList.EpisodeDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"EpisodeDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.EpisodeDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeSection
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetListDataList.EpisodeSectionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetListDataList\"中列\"EpisodeSection\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetListDataList.EpisodeSectionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetListDataListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetListDataList = (ELISDataListDataSet.GetListDataListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemRowIDNull()
			{
				return this.IsNull(this.tableGetListDataList.OEordItemRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemRowIDNull()
			{
				this[this.tableGetListDataList.OEordItemRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEordItemDescNull()
			{
				return this.IsNull(this.tableGetListDataList.OEordItemDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEordItemDescNull()
			{
				this[this.tableGetListDataList.OEordItemDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLabEpisodeNoNull()
			{
				return this.IsNull(this.tableGetListDataList.LabEpisodeNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetLabEpisodeNoNull()
			{
				this[this.tableGetListDataList.LabEpisodeNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSpecimenDescNull()
			{
				return this.IsNull(this.tableGetListDataList.SpecimenDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetSpecimenDescNull()
			{
				this[this.tableGetListDataList.SpecimenDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionDateNull()
			{
				return this.IsNull(this.tableGetListDataList.CollectionDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionDateNull()
			{
				this[this.tableGetListDataList.CollectionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCollectionTimeNull()
			{
				return this.IsNull(this.tableGetListDataList.CollectionTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCollectionTimeNull()
			{
				this[this.tableGetListDataList.CollectionTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveDateNull()
			{
				return this.IsNull(this.tableGetListDataList.ReceiveDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveDateNull()
			{
				this[this.tableGetListDataList.ReceiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsReceiveTimeNull()
			{
				return this.IsNull(this.tableGetListDataList.ReceiveTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetReceiveTimeNull()
			{
				this[this.tableGetListDataList.ReceiveTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationDateNull()
			{
				return this.IsNull(this.tableGetListDataList.AuthorisationDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationDateNull()
			{
				this[this.tableGetListDataList.AuthorisationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAuthorisationTimeNull()
			{
				return this.IsNull(this.tableGetListDataList.AuthorisationTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetAuthorisationTimeNull()
			{
				this[this.tableGetListDataList.AuthorisationTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsExistReportNull()
			{
				return this.IsNull(this.tableGetListDataList.ExistReportColumn);
			}

			[DebuggerNonUserCode]
			public void SetExistReportNull()
			{
				this[this.tableGetListDataList.ExistReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeDateNull()
			{
				return this.IsNull(this.tableGetListDataList.EpisodeDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeDateNull()
			{
				this[this.tableGetListDataList.EpisodeDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeSectionNull()
			{
				return this.IsNull(this.tableGetListDataList.EpisodeSectionColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeSectionNull()
			{
				this[this.tableGetListDataList.EpisodeSectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetListDataListRowChangeEvent : EventArgs
		{
			private ELISDataListDataSet.GetListDataListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ELISDataListDataSet.GetListDataListRow Row
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
			public GetListDataListRowChangeEvent(ELISDataListDataSet.GetListDataListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ELISDataListDataSet.GetListDataListDataTable tableGetListDataList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ELISDataListDataSet.GetListDataListDataTable GetListDataList
		{
			get
			{
				return this.tableGetListDataList;
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
		public ELISDataListDataSet()
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
		protected ELISDataListDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetListDataList"] != null)
				{
					base.Tables.Add(new ELISDataListDataSet.GetListDataListDataTable(dataSet.Tables["GetListDataList"]));
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
			ELISDataListDataSet eLISDataListDataSet = (ELISDataListDataSet)base.Clone();
			eLISDataListDataSet.InitVars();
			eLISDataListDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eLISDataListDataSet;
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
				if (dataSet.Tables["GetListDataList"] != null)
				{
					base.Tables.Add(new ELISDataListDataSet.GetListDataListDataTable(dataSet.Tables["GetListDataList"]));
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
			this.tableGetListDataList = (ELISDataListDataSet.GetListDataListDataTable)base.Tables["GetListDataList"];
			if (initTable && this.tableGetListDataList != null)
			{
				this.tableGetListDataList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ELISDataListDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ELISDataListDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetListDataList = new ELISDataListDataSet.GetListDataListDataTable();
			base.Tables.Add(this.tableGetListDataList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetListDataList()
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
			ELISDataListDataSet eLISDataListDataSet = new ELISDataListDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eLISDataListDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eLISDataListDataSet.GetSchemaSerializable();
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
