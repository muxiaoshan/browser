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

namespace HISData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EEpisodeListByPIdDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EEpisodeListByPIdDataset : DataSet
	{
		public delegate void GetEpisodeListByPIDRowChangeEventHandler(object sender, EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetEpisodeListByPIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnEpisodeID;

			private DataColumn columnEpisodeDate;

			private DataColumn columnDeptDesc;

			private DataColumn columnMainDocName;

			private DataColumn columnEpisodeType;

			private DataColumn columnEpisodeReason;

			private DataColumn columnDischargeDate;

			private DataColumn columnDiagnosis;

			private EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowChangingEvent;

			private EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowChangedEvent;

			private EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowDeletingEvent;

			private EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowDeletedEvent;

			public event EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetEpisodeListByPIDRowChangingEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Combine(this.GetEpisodeListByPIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetEpisodeListByPIDRowChangingEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Remove(this.GetEpisodeListByPIDRowChangingEvent, value);
				}
			}

			public event EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetEpisodeListByPIDRowChangedEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Combine(this.GetEpisodeListByPIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetEpisodeListByPIDRowChangedEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Remove(this.GetEpisodeListByPIDRowChangedEvent, value);
				}
			}

			public event EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetEpisodeListByPIDRowDeletingEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Combine(this.GetEpisodeListByPIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetEpisodeListByPIDRowDeletingEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Remove(this.GetEpisodeListByPIDRowDeletingEvent, value);
				}
			}

			public event EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler GetEpisodeListByPIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetEpisodeListByPIDRowDeletedEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Combine(this.GetEpisodeListByPIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetEpisodeListByPIDRowDeletedEvent = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler)Delegate.Remove(this.GetEpisodeListByPIDRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeIDColumn
			{
				get
				{
					return this.columnEpisodeID;
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
			public DataColumn DeptDescColumn
			{
				get
				{
					return this.columnDeptDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn MainDocNameColumn
			{
				get
				{
					return this.columnMainDocName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeTypeColumn
			{
				get
				{
					return this.columnEpisodeType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeReasonColumn
			{
				get
				{
					return this.columnEpisodeReason;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DischargeDateColumn
			{
				get
				{
					return this.columnDischargeDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DiagnosisColumn
			{
				get
				{
					return this.columnDiagnosis;
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
			public EEpisodeListByPIdDataset.GetEpisodeListByPIDRow this[int index]
			{
				get
				{
					return (EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetEpisodeListByPIDDataTable()
			{
				this.TableName = "GetEpisodeListByPID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetEpisodeListByPIDDataTable(DataTable table)
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
			protected GetEpisodeListByPIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetEpisodeListByPIDRow(EEpisodeListByPIdDataset.GetEpisodeListByPIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EEpisodeListByPIdDataset.GetEpisodeListByPIDRow AddGetEpisodeListByPIDRow(string EpisodeID, string EpisodeDate, string DeptDesc, string MainDocName, string EpisodeType, string EpisodeReason, string DischargeDate, string Diagnosis)
			{
				EEpisodeListByPIdDataset.GetEpisodeListByPIDRow getEpisodeListByPIDRow = (EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					EpisodeID,
					EpisodeDate,
					DeptDesc,
					MainDocName,
					EpisodeType,
					EpisodeReason,
					DischargeDate,
					Diagnosis
				};
				getEpisodeListByPIDRow.ItemArray = itemArray;
				this.Rows.Add(getEpisodeListByPIDRow);
				return getEpisodeListByPIDRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable getEpisodeListByPIDDataTable = (EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable)base.Clone();
				getEpisodeListByPIDDataTable.InitVars();
				return getEpisodeListByPIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnEpisodeID = base.Columns["EpisodeID"];
				this.columnEpisodeDate = base.Columns["EpisodeDate"];
				this.columnDeptDesc = base.Columns["DeptDesc"];
				this.columnMainDocName = base.Columns["MainDocName"];
				this.columnEpisodeType = base.Columns["EpisodeType"];
				this.columnEpisodeReason = base.Columns["EpisodeReason"];
				this.columnDischargeDate = base.Columns["DischargeDate"];
				this.columnDiagnosis = base.Columns["Diagnosis"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnEpisodeID = new DataColumn("EpisodeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeID);
				this.columnEpisodeDate = new DataColumn("EpisodeDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeDate);
				this.columnDeptDesc = new DataColumn("DeptDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDeptDesc);
				this.columnMainDocName = new DataColumn("MainDocName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMainDocName);
				this.columnEpisodeType = new DataColumn("EpisodeType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeType);
				this.columnEpisodeReason = new DataColumn("EpisodeReason", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeReason);
				this.columnDischargeDate = new DataColumn("DischargeDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDischargeDate);
				this.columnDiagnosis = new DataColumn("Diagnosis", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDiagnosis);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EEpisodeListByPIdDataset.GetEpisodeListByPIDRow NewGetEpisodeListByPIDRow()
			{
				return (EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EEpisodeListByPIdDataset.GetEpisodeListByPIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EEpisodeListByPIdDataset.GetEpisodeListByPIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetEpisodeListByPIDRowChangedEvent != null)
				{
					EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler getEpisodeListByPIDRowChangedEvent = this.GetEpisodeListByPIDRowChangedEvent;
					if (getEpisodeListByPIDRowChangedEvent != null)
					{
						getEpisodeListByPIDRowChangedEvent(this, new EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEvent((EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetEpisodeListByPIDRowChangingEvent != null)
				{
					EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler getEpisodeListByPIDRowChangingEvent = this.GetEpisodeListByPIDRowChangingEvent;
					if (getEpisodeListByPIDRowChangingEvent != null)
					{
						getEpisodeListByPIDRowChangingEvent(this, new EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEvent((EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetEpisodeListByPIDRowDeletedEvent != null)
				{
					EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler getEpisodeListByPIDRowDeletedEvent = this.GetEpisodeListByPIDRowDeletedEvent;
					if (getEpisodeListByPIDRowDeletedEvent != null)
					{
						getEpisodeListByPIDRowDeletedEvent(this, new EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEvent((EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetEpisodeListByPIDRowDeletingEvent != null)
				{
					EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEventHandler getEpisodeListByPIDRowDeletingEvent = this.GetEpisodeListByPIDRowDeletingEvent;
					if (getEpisodeListByPIDRowDeletingEvent != null)
					{
						getEpisodeListByPIDRowDeletingEvent(this, new EEpisodeListByPIdDataset.GetEpisodeListByPIDRowChangeEvent((EEpisodeListByPIdDataset.GetEpisodeListByPIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetEpisodeListByPIDRow(EEpisodeListByPIdDataset.GetEpisodeListByPIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EEpisodeListByPIdDataset eEpisodeListByPIdDataset = new EEpisodeListByPIdDataset();
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
				xmlSchemaAttribute.FixedValue = eEpisodeListByPIdDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetEpisodeListByPIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eEpisodeListByPIdDataset.GetSchemaSerializable();
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
		public class GetEpisodeListByPIDRow : DataRow
		{
			private EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable tableGetEpisodeListByPID;

			[DebuggerNonUserCode]
			public string EpisodeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.EpisodeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"EpisodeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.EpisodeIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.EpisodeDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"EpisodeDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.EpisodeDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DeptDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.DeptDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"DeptDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.DeptDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string MainDocName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.MainDocNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"MainDocName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.MainDocNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.EpisodeTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"EpisodeType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.EpisodeTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeReason
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.EpisodeReasonColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"EpisodeReason\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.EpisodeReasonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DischargeDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.DischargeDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"DischargeDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.DischargeDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Diagnosis
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetEpisodeListByPID.DiagnosisColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetEpisodeListByPID\"中列\"Diagnosis\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetEpisodeListByPID.DiagnosisColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetEpisodeListByPIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetEpisodeListByPID = (EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeIDNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.EpisodeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeIDNull()
			{
				this[this.tableGetEpisodeListByPID.EpisodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeDateNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.EpisodeDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeDateNull()
			{
				this[this.tableGetEpisodeListByPID.EpisodeDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDeptDescNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.DeptDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDeptDescNull()
			{
				this[this.tableGetEpisodeListByPID.DeptDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMainDocNameNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.MainDocNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetMainDocNameNull()
			{
				this[this.tableGetEpisodeListByPID.MainDocNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeTypeNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.EpisodeTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeTypeNull()
			{
				this[this.tableGetEpisodeListByPID.EpisodeTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeReasonNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.EpisodeReasonColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeReasonNull()
			{
				this[this.tableGetEpisodeListByPID.EpisodeReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDischargeDateNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.DischargeDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetDischargeDateNull()
			{
				this[this.tableGetEpisodeListByPID.DischargeDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDiagnosisNull()
			{
				return this.IsNull(this.tableGetEpisodeListByPID.DiagnosisColumn);
			}

			[DebuggerNonUserCode]
			public void SetDiagnosisNull()
			{
				this[this.tableGetEpisodeListByPID.DiagnosisColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetEpisodeListByPIDRowChangeEvent : EventArgs
		{
			private EEpisodeListByPIdDataset.GetEpisodeListByPIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EEpisodeListByPIdDataset.GetEpisodeListByPIDRow Row
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
			public GetEpisodeListByPIDRowChangeEvent(EEpisodeListByPIdDataset.GetEpisodeListByPIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable tableGetEpisodeListByPID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable GetEpisodeListByPID
		{
			get
			{
				return this.tableGetEpisodeListByPID;
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
		public EEpisodeListByPIdDataset()
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
		protected EEpisodeListByPIdDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetEpisodeListByPID"] != null)
				{
					base.Tables.Add(new EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable(dataSet.Tables["GetEpisodeListByPID"]));
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
			EEpisodeListByPIdDataset eEpisodeListByPIdDataset = (EEpisodeListByPIdDataset)base.Clone();
			eEpisodeListByPIdDataset.InitVars();
			eEpisodeListByPIdDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eEpisodeListByPIdDataset;
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
				if (dataSet.Tables["GetEpisodeListByPID"] != null)
				{
					base.Tables.Add(new EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable(dataSet.Tables["GetEpisodeListByPID"]));
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
			this.tableGetEpisodeListByPID = (EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable)base.Tables["GetEpisodeListByPID"];
			if (initTable && this.tableGetEpisodeListByPID != null)
			{
				this.tableGetEpisodeListByPID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EEpisodeListByPIdDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPRservice.dataset.EpisodeListByPIDDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetEpisodeListByPID = new EEpisodeListByPIdDataset.GetEpisodeListByPIDDataTable();
			base.Tables.Add(this.tableGetEpisodeListByPID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetEpisodeListByPID()
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
			EEpisodeListByPIdDataset eEpisodeListByPIdDataset = new EEpisodeListByPIdDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eEpisodeListByPIdDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eEpisodeListByPIdDataset.GetSchemaSerializable();
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
