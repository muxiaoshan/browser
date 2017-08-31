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

namespace MRDiagnosData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosAllHistoryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosAllHistoryDataset : DataSet
	{
		public delegate void HisMRDiagRepRowChangeEventHandler(object sender, EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class HisMRDiagRepDataTable : DataTable, IEnumerable
		{
			private DataColumn columnRowid;

			private DataColumn columnDesc;

			private DataColumn columnMRDesc;

			private DataColumn columnDoctDesc;

			private DataColumn columnMRDate;

			private DataColumn columnMRtime;

			private DataColumn columnAdmDep;

			private EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowChangingEvent;

			private EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowChangedEvent;

			private EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowDeletingEvent;

			private EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowDeletedEvent;

			public event EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.HisMRDiagRepRowChangingEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Combine(this.HisMRDiagRepRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.HisMRDiagRepRowChangingEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Remove(this.HisMRDiagRepRowChangingEvent, value);
				}
			}

			public event EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.HisMRDiagRepRowChangedEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Combine(this.HisMRDiagRepRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.HisMRDiagRepRowChangedEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Remove(this.HisMRDiagRepRowChangedEvent, value);
				}
			}

			public event EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.HisMRDiagRepRowDeletingEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Combine(this.HisMRDiagRepRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.HisMRDiagRepRowDeletingEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Remove(this.HisMRDiagRepRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler HisMRDiagRepRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.HisMRDiagRepRowDeletedEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Combine(this.HisMRDiagRepRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.HisMRDiagRepRowDeletedEvent = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler)Delegate.Remove(this.HisMRDiagRepRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn RowidColumn
			{
				get
				{
					return this.columnRowid;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DescColumn
			{
				get
				{
					return this.columnDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn MRDescColumn
			{
				get
				{
					return this.columnMRDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DoctDescColumn
			{
				get
				{
					return this.columnDoctDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn MRDateColumn
			{
				get
				{
					return this.columnMRDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn MRtimeColumn
			{
				get
				{
					return this.columnMRtime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AdmDepColumn
			{
				get
				{
					return this.columnAdmDep;
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
			public EMRDiagnosAllHistoryDataset.HisMRDiagRepRow this[int index]
			{
				get
				{
					return (EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public HisMRDiagRepDataTable()
			{
				this.TableName = "HisMRDiagRep";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal HisMRDiagRepDataTable(DataTable table)
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
			protected HisMRDiagRepDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddHisMRDiagRepRow(EMRDiagnosAllHistoryDataset.HisMRDiagRepRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosAllHistoryDataset.HisMRDiagRepRow AddHisMRDiagRepRow(string Rowid, string Desc, string MRDesc, string DoctDesc, string MRDate, string MRtime, string AdmDep)
			{
				EMRDiagnosAllHistoryDataset.HisMRDiagRepRow hisMRDiagRepRow = (EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Rowid,
					Desc,
					MRDesc,
					DoctDesc,
					MRDate,
					MRtime,
					AdmDep
				};
				hisMRDiagRepRow.ItemArray = itemArray;
				this.Rows.Add(hisMRDiagRepRow);
				return hisMRDiagRepRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable hisMRDiagRepDataTable = (EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable)base.Clone();
				hisMRDiagRepDataTable.InitVars();
				return hisMRDiagRepDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnRowid = base.Columns["Rowid"];
				this.columnDesc = base.Columns["Desc"];
				this.columnMRDesc = base.Columns["MRDesc"];
				this.columnDoctDesc = base.Columns["DoctDesc"];
				this.columnMRDate = base.Columns["MRDate"];
				this.columnMRtime = base.Columns["MRtime"];
				this.columnAdmDep = base.Columns["AdmDep"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnRowid = new DataColumn("Rowid", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRowid);
				this.columnDesc = new DataColumn("Desc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDesc);
				this.columnMRDesc = new DataColumn("MRDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMRDesc);
				this.columnDoctDesc = new DataColumn("DoctDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDoctDesc);
				this.columnMRDate = new DataColumn("MRDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMRDate);
				this.columnMRtime = new DataColumn("MRtime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMRtime);
				this.columnAdmDep = new DataColumn("AdmDep", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAdmDep);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosAllHistoryDataset.HisMRDiagRepRow NewHisMRDiagRepRow()
			{
				return (EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosAllHistoryDataset.HisMRDiagRepRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosAllHistoryDataset.HisMRDiagRepRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.HisMRDiagRepRowChangedEvent != null)
				{
					EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler hisMRDiagRepRowChangedEvent = this.HisMRDiagRepRowChangedEvent;
					if (hisMRDiagRepRowChangedEvent != null)
					{
						hisMRDiagRepRowChangedEvent(this, new EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEvent((EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.HisMRDiagRepRowChangingEvent != null)
				{
					EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler hisMRDiagRepRowChangingEvent = this.HisMRDiagRepRowChangingEvent;
					if (hisMRDiagRepRowChangingEvent != null)
					{
						hisMRDiagRepRowChangingEvent(this, new EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEvent((EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.HisMRDiagRepRowDeletedEvent != null)
				{
					EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler hisMRDiagRepRowDeletedEvent = this.HisMRDiagRepRowDeletedEvent;
					if (hisMRDiagRepRowDeletedEvent != null)
					{
						hisMRDiagRepRowDeletedEvent(this, new EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEvent((EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.HisMRDiagRepRowDeletingEvent != null)
				{
					EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEventHandler hisMRDiagRepRowDeletingEvent = this.HisMRDiagRepRowDeletingEvent;
					if (hisMRDiagRepRowDeletingEvent != null)
					{
						hisMRDiagRepRowDeletingEvent(this, new EMRDiagnosAllHistoryDataset.HisMRDiagRepRowChangeEvent((EMRDiagnosAllHistoryDataset.HisMRDiagRepRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveHisMRDiagRepRow(EMRDiagnosAllHistoryDataset.HisMRDiagRepRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosAllHistoryDataset eMRDiagnosAllHistoryDataset = new EMRDiagnosAllHistoryDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosAllHistoryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "HisMRDiagRepDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosAllHistoryDataset.GetSchemaSerializable();
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
		public class HisMRDiagRepRow : DataRow
		{
			private EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable tableHisMRDiagRep;

			[DebuggerNonUserCode]
			public string Rowid
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.RowidColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"Rowid\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.RowidColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Desc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.DescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"Desc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.DescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string MRDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.MRDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"MRDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.MRDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DoctDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.DoctDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"DoctDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.DoctDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string MRDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.MRDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"MRDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.MRDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string MRtime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.MRtimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"MRtime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.MRtimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AdmDep
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHisMRDiagRep.AdmDepColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"HisMRDiagRep\"中列\"AdmDep\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHisMRDiagRep.AdmDepColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal HisMRDiagRepRow(DataRowBuilder rb) : base(rb)
			{
				this.tableHisMRDiagRep = (EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsRowidNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.RowidColumn);
			}

			[DebuggerNonUserCode]
			public void SetRowidNull()
			{
				this[this.tableHisMRDiagRep.RowidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.DescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescNull()
			{
				this[this.tableHisMRDiagRep.DescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRDescNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.MRDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRDescNull()
			{
				this[this.tableHisMRDiagRep.MRDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDoctDescNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.DoctDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDoctDescNull()
			{
				this[this.tableHisMRDiagRep.DoctDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRDateNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.MRDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRDateNull()
			{
				this[this.tableHisMRDiagRep.MRDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRtimeNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.MRtimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRtimeNull()
			{
				this[this.tableHisMRDiagRep.MRtimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAdmDepNull()
			{
				return this.IsNull(this.tableHisMRDiagRep.AdmDepColumn);
			}

			[DebuggerNonUserCode]
			public void SetAdmDepNull()
			{
				this[this.tableHisMRDiagRep.AdmDepColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class HisMRDiagRepRowChangeEvent : EventArgs
		{
			private EMRDiagnosAllHistoryDataset.HisMRDiagRepRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosAllHistoryDataset.HisMRDiagRepRow Row
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
			public HisMRDiagRepRowChangeEvent(EMRDiagnosAllHistoryDataset.HisMRDiagRepRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable tableHisMRDiagRep;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable HisMRDiagRep
		{
			get
			{
				return this.tableHisMRDiagRep;
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
		public EMRDiagnosAllHistoryDataset()
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
		protected EMRDiagnosAllHistoryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["HisMRDiagRep"] != null)
				{
					base.Tables.Add(new EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable(dataSet.Tables["HisMRDiagRep"]));
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
			EMRDiagnosAllHistoryDataset eMRDiagnosAllHistoryDataset = (EMRDiagnosAllHistoryDataset)base.Clone();
			eMRDiagnosAllHistoryDataset.InitVars();
			eMRDiagnosAllHistoryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosAllHistoryDataset;
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
				if (dataSet.Tables["HisMRDiagRep"] != null)
				{
					base.Tables.Add(new EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable(dataSet.Tables["HisMRDiagRep"]));
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
			this.tableHisMRDiagRep = (EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable)base.Tables["HisMRDiagRep"];
			if (initTable && this.tableHisMRDiagRep != null)
			{
				this.tableHisMRDiagRep.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosAllHistoryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosAllHistoryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableHisMRDiagRep = new EMRDiagnosAllHistoryDataset.HisMRDiagRepDataTable();
			base.Tables.Add(this.tableHisMRDiagRep);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeHisMRDiagRep()
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
			EMRDiagnosAllHistoryDataset eMRDiagnosAllHistoryDataset = new EMRDiagnosAllHistoryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosAllHistoryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosAllHistoryDataset.GetSchemaSerializable();
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
