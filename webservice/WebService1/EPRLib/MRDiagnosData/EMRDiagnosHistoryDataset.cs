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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosHistoryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosHistoryDataset : DataSet
	{
		public delegate void GetHistoryMRDiagnoseRowChangeEventHandler(object sender, EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetHistoryMRDiagnoseDataTable : DataTable, IEnumerable
		{
			private DataColumn columnRowid;

			private DataColumn columnDesc;

			private DataColumn columnMRDesc;

			private DataColumn columnDoctDesc;

			private DataColumn columnMRDate;

			private DataColumn columnMRtime;

			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowChangingEvent;

			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowChangedEvent;

			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowDeletingEvent;

			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowDeletedEvent;

			public event EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetHistoryMRDiagnoseRowChangingEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Combine(this.GetHistoryMRDiagnoseRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetHistoryMRDiagnoseRowChangingEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Remove(this.GetHistoryMRDiagnoseRowChangingEvent, value);
				}
			}

			public event EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetHistoryMRDiagnoseRowChangedEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Combine(this.GetHistoryMRDiagnoseRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetHistoryMRDiagnoseRowChangedEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Remove(this.GetHistoryMRDiagnoseRowChangedEvent, value);
				}
			}

			public event EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetHistoryMRDiagnoseRowDeletingEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Combine(this.GetHistoryMRDiagnoseRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetHistoryMRDiagnoseRowDeletingEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Remove(this.GetHistoryMRDiagnoseRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler GetHistoryMRDiagnoseRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetHistoryMRDiagnoseRowDeletedEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Combine(this.GetHistoryMRDiagnoseRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetHistoryMRDiagnoseRowDeletedEvent = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler)Delegate.Remove(this.GetHistoryMRDiagnoseRowDeletedEvent, value);
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

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow this[int index]
			{
				get
				{
					return (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetHistoryMRDiagnoseDataTable()
			{
				this.TableName = "GetHistoryMRDiagnose";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetHistoryMRDiagnoseDataTable(DataTable table)
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
			protected GetHistoryMRDiagnoseDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetHistoryMRDiagnoseRow(EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow AddGetHistoryMRDiagnoseRow(string Rowid, string Desc, string MRDesc, string DoctDesc, string MRDate, string MRtime)
			{
				EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow getHistoryMRDiagnoseRow = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Rowid,
					Desc,
					MRDesc,
					DoctDesc,
					MRDate,
					MRtime
				};
				getHistoryMRDiagnoseRow.ItemArray = itemArray;
				this.Rows.Add(getHistoryMRDiagnoseRow);
				return getHistoryMRDiagnoseRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable getHistoryMRDiagnoseDataTable = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable)base.Clone();
				getHistoryMRDiagnoseDataTable.InitVars();
				return getHistoryMRDiagnoseDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable();
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
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow NewGetHistoryMRDiagnoseRow()
			{
				return (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetHistoryMRDiagnoseRowChangedEvent != null)
				{
					EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler getHistoryMRDiagnoseRowChangedEvent = this.GetHistoryMRDiagnoseRowChangedEvent;
					if (getHistoryMRDiagnoseRowChangedEvent != null)
					{
						getHistoryMRDiagnoseRowChangedEvent(this, new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEvent((EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetHistoryMRDiagnoseRowChangingEvent != null)
				{
					EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler getHistoryMRDiagnoseRowChangingEvent = this.GetHistoryMRDiagnoseRowChangingEvent;
					if (getHistoryMRDiagnoseRowChangingEvent != null)
					{
						getHistoryMRDiagnoseRowChangingEvent(this, new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEvent((EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetHistoryMRDiagnoseRowDeletedEvent != null)
				{
					EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler getHistoryMRDiagnoseRowDeletedEvent = this.GetHistoryMRDiagnoseRowDeletedEvent;
					if (getHistoryMRDiagnoseRowDeletedEvent != null)
					{
						getHistoryMRDiagnoseRowDeletedEvent(this, new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEvent((EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetHistoryMRDiagnoseRowDeletingEvent != null)
				{
					EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEventHandler getHistoryMRDiagnoseRowDeletingEvent = this.GetHistoryMRDiagnoseRowDeletingEvent;
					if (getHistoryMRDiagnoseRowDeletingEvent != null)
					{
						getHistoryMRDiagnoseRowDeletingEvent(this, new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRowChangeEvent((EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetHistoryMRDiagnoseRow(EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosHistoryDataset eMRDiagnosHistoryDataset = new EMRDiagnosHistoryDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosHistoryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetHistoryMRDiagnoseDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosHistoryDataset.GetSchemaSerializable();
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
		public class GetHistoryMRDiagnoseRow : DataRow
		{
			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable tableGetHistoryMRDiagnose;

			[DebuggerNonUserCode]
			public string Rowid
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.RowidColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"Rowid\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.RowidColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.DescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"Desc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.DescColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.MRDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"MRDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.MRDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.DoctDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"DoctDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.DoctDescColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.MRDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"MRDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.MRDateColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetHistoryMRDiagnose.MRtimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetHistoryMRDiagnose\"中列\"MRtime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetHistoryMRDiagnose.MRtimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetHistoryMRDiagnoseRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetHistoryMRDiagnose = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsRowidNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.RowidColumn);
			}

			[DebuggerNonUserCode]
			public void SetRowidNull()
			{
				this[this.tableGetHistoryMRDiagnose.RowidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.DescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescNull()
			{
				this[this.tableGetHistoryMRDiagnose.DescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRDescNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.MRDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRDescNull()
			{
				this[this.tableGetHistoryMRDiagnose.MRDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDoctDescNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.DoctDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDoctDescNull()
			{
				this[this.tableGetHistoryMRDiagnose.DoctDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRDateNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.MRDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRDateNull()
			{
				this[this.tableGetHistoryMRDiagnose.MRDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMRtimeNull()
			{
				return this.IsNull(this.tableGetHistoryMRDiagnose.MRtimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetMRtimeNull()
			{
				this[this.tableGetHistoryMRDiagnose.MRtimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetHistoryMRDiagnoseRowChangeEvent : EventArgs
		{
			private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow Row
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
			public GetHistoryMRDiagnoseRowChangeEvent(EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable tableGetHistoryMRDiagnose;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable GetHistoryMRDiagnose
		{
			get
			{
				return this.tableGetHistoryMRDiagnose;
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
		public EMRDiagnosHistoryDataset()
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
		protected EMRDiagnosHistoryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetHistoryMRDiagnose"] != null)
				{
					base.Tables.Add(new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable(dataSet.Tables["GetHistoryMRDiagnose"]));
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
			EMRDiagnosHistoryDataset eMRDiagnosHistoryDataset = (EMRDiagnosHistoryDataset)base.Clone();
			eMRDiagnosHistoryDataset.InitVars();
			eMRDiagnosHistoryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosHistoryDataset;
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
				if (dataSet.Tables["GetHistoryMRDiagnose"] != null)
				{
					base.Tables.Add(new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable(dataSet.Tables["GetHistoryMRDiagnose"]));
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
			this.tableGetHistoryMRDiagnose = (EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable)base.Tables["GetHistoryMRDiagnose"];
			if (initTable && this.tableGetHistoryMRDiagnose != null)
			{
				this.tableGetHistoryMRDiagnose.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosHistoryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosHistoryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetHistoryMRDiagnose = new EMRDiagnosHistoryDataset.GetHistoryMRDiagnoseDataTable();
			base.Tables.Add(this.tableGetHistoryMRDiagnose);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetHistoryMRDiagnose()
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
			EMRDiagnosHistoryDataset eMRDiagnosHistoryDataset = new EMRDiagnosHistoryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosHistoryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosHistoryDataset.GetSchemaSerializable();
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
