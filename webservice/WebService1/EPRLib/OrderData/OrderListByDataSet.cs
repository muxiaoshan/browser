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

namespace OrderData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("OrderListByDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class OrderListByDataSet : DataSet
	{
		public delegate void GetOrdByAdmRowChangeEventHandler(object sender, OrderListByDataSet.GetOrdByAdmRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetOrdByAdmDataTable : DataTable, IEnumerable
		{
			private DataColumn columnOrdCreateDate;

			private DataColumn columnOrdCreateTime;

			private DataColumn columnOrdStartDate;

			private DataColumn columnOrdStartTime;

			private DataColumn columnArcimDesc;

			private DataColumn columnDoseQty;

			private DataColumn columnDoseUnit;

			private DataColumn columnPriority;

			private DataColumn columnPHFreq;

			private DataColumn columnInstr;

			private DataColumn columnDoctor;

			private DataColumn columnOrdStatus;

			private DataColumn columnDura;

			private DataColumn columnOEItemID;

			private DataColumn columnPatientID;

			private DataColumn columnSeqNo;

			private DataColumn columnQtyPackUOM;

			private DataColumn columnPackUOMDesc;

			private DataColumn columnPrescNo;

			private DataColumn columndstatus;

			private DataColumn columnLabEpisodeNo;

			private DataColumn columnOrdLabSpec;

			private DataColumn columnOrdXDate;

			private DataColumn columnOrdXTime;

			private DataColumn columnOrdSkinTest;

			private DataColumn columnOrdAction;

			private DataColumn columnOrdDepProcNotes;

			private DataColumn columnOrdBilled;

			private DataColumn columnOrdSkinTestResult;

			private OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowChangingEvent;

			private OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowChangedEvent;

			private OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowDeletingEvent;

			private OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowDeletedEvent;

			public event OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetOrdByAdmRowChangingEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Combine(this.GetOrdByAdmRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetOrdByAdmRowChangingEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Remove(this.GetOrdByAdmRowChangingEvent, value);
				}
			}

			public event OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetOrdByAdmRowChangedEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Combine(this.GetOrdByAdmRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetOrdByAdmRowChangedEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Remove(this.GetOrdByAdmRowChangedEvent, value);
				}
			}

			public event OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetOrdByAdmRowDeletingEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Combine(this.GetOrdByAdmRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetOrdByAdmRowDeletingEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Remove(this.GetOrdByAdmRowDeletingEvent, value);
				}
			}

			public event OrderListByDataSet.GetOrdByAdmRowChangeEventHandler GetOrdByAdmRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetOrdByAdmRowDeletedEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Combine(this.GetOrdByAdmRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetOrdByAdmRowDeletedEvent = (OrderListByDataSet.GetOrdByAdmRowChangeEventHandler)Delegate.Remove(this.GetOrdByAdmRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdCreateDateColumn
			{
				get
				{
					return this.columnOrdCreateDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdCreateTimeColumn
			{
				get
				{
					return this.columnOrdCreateTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdStartDateColumn
			{
				get
				{
					return this.columnOrdStartDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdStartTimeColumn
			{
				get
				{
					return this.columnOrdStartTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ArcimDescColumn
			{
				get
				{
					return this.columnArcimDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DoseQtyColumn
			{
				get
				{
					return this.columnDoseQty;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DoseUnitColumn
			{
				get
				{
					return this.columnDoseUnit;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PriorityColumn
			{
				get
				{
					return this.columnPriority;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PHFreqColumn
			{
				get
				{
					return this.columnPHFreq;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn InstrColumn
			{
				get
				{
					return this.columnInstr;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DoctorColumn
			{
				get
				{
					return this.columnDoctor;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdStatusColumn
			{
				get
				{
					return this.columnOrdStatus;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DuraColumn
			{
				get
				{
					return this.columnDura;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OEItemIDColumn
			{
				get
				{
					return this.columnOEItemID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PatientIDColumn
			{
				get
				{
					return this.columnPatientID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SeqNoColumn
			{
				get
				{
					return this.columnSeqNo;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn QtyPackUOMColumn
			{
				get
				{
					return this.columnQtyPackUOM;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PackUOMDescColumn
			{
				get
				{
					return this.columnPackUOMDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn PrescNoColumn
			{
				get
				{
					return this.columnPrescNo;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn dstatusColumn
			{
				get
				{
					return this.columndstatus;
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
			public DataColumn OrdLabSpecColumn
			{
				get
				{
					return this.columnOrdLabSpec;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdXDateColumn
			{
				get
				{
					return this.columnOrdXDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdXTimeColumn
			{
				get
				{
					return this.columnOrdXTime;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdSkinTestColumn
			{
				get
				{
					return this.columnOrdSkinTest;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdActionColumn
			{
				get
				{
					return this.columnOrdAction;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdDepProcNotesColumn
			{
				get
				{
					return this.columnOrdDepProcNotes;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdBilledColumn
			{
				get
				{
					return this.columnOrdBilled;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OrdSkinTestResultColumn
			{
				get
				{
					return this.columnOrdSkinTestResult;
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
			public OrderListByDataSet.GetOrdByAdmRow this[int index]
			{
				get
				{
					return (OrderListByDataSet.GetOrdByAdmRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetOrdByAdmDataTable()
			{
				this.TableName = "GetOrdByAdm";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetOrdByAdmDataTable(DataTable table)
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
			protected GetOrdByAdmDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetOrdByAdmRow(OrderListByDataSet.GetOrdByAdmRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public OrderListByDataSet.GetOrdByAdmRow AddGetOrdByAdmRow(string OrdCreateDate, string OrdCreateTime, string OrdStartDate, string OrdStartTime, string ArcimDesc, string DoseQty, string DoseUnit, string Priority, string PHFreq, string Instr, string Doctor, string OrdStatus, string Dura, string OEItemID, string PatientID, string SeqNo, string QtyPackUOM, string PackUOMDesc, string PrescNo, string dstatus, string LabEpisodeNo, string OrdLabSpec, string OrdXDate, string OrdXTime, string OrdSkinTest, string OrdAction, string OrdDepProcNotes, string OrdBilled, string OrdSkinTestResult)
			{
				OrderListByDataSet.GetOrdByAdmRow getOrdByAdmRow = (OrderListByDataSet.GetOrdByAdmRow)this.NewRow();
				object[] itemArray = new object[]
				{
					OrdCreateDate,
					OrdCreateTime,
					OrdStartDate,
					OrdStartTime,
					ArcimDesc,
					DoseQty,
					DoseUnit,
					Priority,
					PHFreq,
					Instr,
					Doctor,
					OrdStatus,
					Dura,
					OEItemID,
					PatientID,
					SeqNo,
					QtyPackUOM,
					PackUOMDesc,
					PrescNo,
					dstatus,
					LabEpisodeNo,
					OrdLabSpec,
					OrdXDate,
					OrdXTime,
					OrdSkinTest,
					OrdAction,
					OrdDepProcNotes,
					OrdBilled,
					OrdSkinTestResult
				};
				getOrdByAdmRow.ItemArray = itemArray;
				this.Rows.Add(getOrdByAdmRow);
				return getOrdByAdmRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				OrderListByDataSet.GetOrdByAdmDataTable getOrdByAdmDataTable = (OrderListByDataSet.GetOrdByAdmDataTable)base.Clone();
				getOrdByAdmDataTable.InitVars();
				return getOrdByAdmDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new OrderListByDataSet.GetOrdByAdmDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnOrdCreateDate = base.Columns["OrdCreateDate"];
				this.columnOrdCreateTime = base.Columns["OrdCreateTime"];
				this.columnOrdStartDate = base.Columns["OrdStartDate"];
				this.columnOrdStartTime = base.Columns["OrdStartTime"];
				this.columnArcimDesc = base.Columns["ArcimDesc"];
				this.columnDoseQty = base.Columns["DoseQty"];
				this.columnDoseUnit = base.Columns["DoseUnit"];
				this.columnPriority = base.Columns["Priority"];
				this.columnPHFreq = base.Columns["PHFreq"];
				this.columnInstr = base.Columns["Instr"];
				this.columnDoctor = base.Columns["Doctor"];
				this.columnOrdStatus = base.Columns["OrdStatus"];
				this.columnDura = base.Columns["Dura"];
				this.columnOEItemID = base.Columns["OEItemID"];
				this.columnPatientID = base.Columns["PatientID"];
				this.columnSeqNo = base.Columns["SeqNo"];
				this.columnQtyPackUOM = base.Columns["QtyPackUOM"];
				this.columnPackUOMDesc = base.Columns["PackUOMDesc"];
				this.columnPrescNo = base.Columns["PrescNo"];
				this.columndstatus = base.Columns["dstatus"];
				this.columnLabEpisodeNo = base.Columns["LabEpisodeNo"];
				this.columnOrdLabSpec = base.Columns["OrdLabSpec"];
				this.columnOrdXDate = base.Columns["OrdXDate"];
				this.columnOrdXTime = base.Columns["OrdXTime"];
				this.columnOrdSkinTest = base.Columns["OrdSkinTest"];
				this.columnOrdAction = base.Columns["OrdAction"];
				this.columnOrdDepProcNotes = base.Columns["OrdDepProcNotes"];
				this.columnOrdBilled = base.Columns["OrdBilled"];
				this.columnOrdSkinTestResult = base.Columns["OrdSkinTestResult"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnOrdCreateDate = new DataColumn("OrdCreateDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdCreateDate);
				this.columnOrdCreateTime = new DataColumn("OrdCreateTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdCreateTime);
				this.columnOrdStartDate = new DataColumn("OrdStartDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdStartDate);
				this.columnOrdStartTime = new DataColumn("OrdStartTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdStartTime);
				this.columnArcimDesc = new DataColumn("ArcimDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnArcimDesc);
				this.columnDoseQty = new DataColumn("DoseQty", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDoseQty);
				this.columnDoseUnit = new DataColumn("DoseUnit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDoseUnit);
				this.columnPriority = new DataColumn("Priority", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPriority);
				this.columnPHFreq = new DataColumn("PHFreq", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPHFreq);
				this.columnInstr = new DataColumn("Instr", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInstr);
				this.columnDoctor = new DataColumn("Doctor", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDoctor);
				this.columnOrdStatus = new DataColumn("OrdStatus", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdStatus);
				this.columnDura = new DataColumn("Dura", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDura);
				this.columnOEItemID = new DataColumn("OEItemID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOEItemID);
				this.columnPatientID = new DataColumn("PatientID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPatientID);
				this.columnSeqNo = new DataColumn("SeqNo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSeqNo);
				this.columnQtyPackUOM = new DataColumn("QtyPackUOM", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnQtyPackUOM);
				this.columnPackUOMDesc = new DataColumn("PackUOMDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPackUOMDesc);
				this.columnPrescNo = new DataColumn("PrescNo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPrescNo);
				this.columndstatus = new DataColumn("dstatus", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndstatus);
				this.columnLabEpisodeNo = new DataColumn("LabEpisodeNo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLabEpisodeNo);
				this.columnOrdLabSpec = new DataColumn("OrdLabSpec", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdLabSpec);
				this.columnOrdXDate = new DataColumn("OrdXDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdXDate);
				this.columnOrdXTime = new DataColumn("OrdXTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdXTime);
				this.columnOrdSkinTest = new DataColumn("OrdSkinTest", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdSkinTest);
				this.columnOrdAction = new DataColumn("OrdAction", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdAction);
				this.columnOrdDepProcNotes = new DataColumn("OrdDepProcNotes", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdDepProcNotes);
				this.columnOrdBilled = new DataColumn("OrdBilled", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdBilled);
				this.columnOrdSkinTestResult = new DataColumn("OrdSkinTestResult", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOrdSkinTestResult);
			}

			[DebuggerNonUserCode]
			public OrderListByDataSet.GetOrdByAdmRow NewGetOrdByAdmRow()
			{
				return (OrderListByDataSet.GetOrdByAdmRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new OrderListByDataSet.GetOrdByAdmRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(OrderListByDataSet.GetOrdByAdmRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetOrdByAdmRowChangedEvent != null)
				{
					OrderListByDataSet.GetOrdByAdmRowChangeEventHandler getOrdByAdmRowChangedEvent = this.GetOrdByAdmRowChangedEvent;
					if (getOrdByAdmRowChangedEvent != null)
					{
						getOrdByAdmRowChangedEvent(this, new OrderListByDataSet.GetOrdByAdmRowChangeEvent((OrderListByDataSet.GetOrdByAdmRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetOrdByAdmRowChangingEvent != null)
				{
					OrderListByDataSet.GetOrdByAdmRowChangeEventHandler getOrdByAdmRowChangingEvent = this.GetOrdByAdmRowChangingEvent;
					if (getOrdByAdmRowChangingEvent != null)
					{
						getOrdByAdmRowChangingEvent(this, new OrderListByDataSet.GetOrdByAdmRowChangeEvent((OrderListByDataSet.GetOrdByAdmRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetOrdByAdmRowDeletedEvent != null)
				{
					OrderListByDataSet.GetOrdByAdmRowChangeEventHandler getOrdByAdmRowDeletedEvent = this.GetOrdByAdmRowDeletedEvent;
					if (getOrdByAdmRowDeletedEvent != null)
					{
						getOrdByAdmRowDeletedEvent(this, new OrderListByDataSet.GetOrdByAdmRowChangeEvent((OrderListByDataSet.GetOrdByAdmRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetOrdByAdmRowDeletingEvent != null)
				{
					OrderListByDataSet.GetOrdByAdmRowChangeEventHandler getOrdByAdmRowDeletingEvent = this.GetOrdByAdmRowDeletingEvent;
					if (getOrdByAdmRowDeletingEvent != null)
					{
						getOrdByAdmRowDeletingEvent(this, new OrderListByDataSet.GetOrdByAdmRowChangeEvent((OrderListByDataSet.GetOrdByAdmRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetOrdByAdmRow(OrderListByDataSet.GetOrdByAdmRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				OrderListByDataSet orderListByDataSet = new OrderListByDataSet();
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
				xmlSchemaAttribute.FixedValue = orderListByDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetOrdByAdmDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = orderListByDataSet.GetSchemaSerializable();
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
		public class GetOrdByAdmRow : DataRow
		{
			private OrderListByDataSet.GetOrdByAdmDataTable tableGetOrdByAdm;

			[DebuggerNonUserCode]
			public string OrdCreateDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdCreateDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdCreateDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdCreateDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdCreateTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdCreateTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdCreateTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdCreateTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdStartDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdStartDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdStartDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdStartDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdStartTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdStartTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdStartTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdStartTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ArcimDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.ArcimDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"ArcimDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.ArcimDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DoseQty
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.DoseQtyColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"DoseQty\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.DoseQtyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DoseUnit
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.DoseUnitColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"DoseUnit\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.DoseUnitColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Priority
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.PriorityColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"Priority\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.PriorityColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PHFreq
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.PHFreqColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"PHFreq\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.PHFreqColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Instr
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.InstrColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"Instr\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.InstrColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Doctor
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.DoctorColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"Doctor\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.DoctorColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdStatus
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdStatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdStatus\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdStatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Dura
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.DuraColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"Dura\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.DuraColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OEItemID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OEItemIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OEItemID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OEItemIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PatientID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.PatientIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"PatientID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.PatientIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string SeqNo
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.SeqNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"SeqNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.SeqNoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string QtyPackUOM
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.QtyPackUOMColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"QtyPackUOM\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.QtyPackUOMColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PackUOMDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.PackUOMDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"PackUOMDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.PackUOMDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PrescNo
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.PrescNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"PrescNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.PrescNoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string dstatus
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.dstatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"dstatus\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.dstatusColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetOrdByAdm.LabEpisodeNoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"LabEpisodeNo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.LabEpisodeNoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdLabSpec
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdLabSpecColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdLabSpec\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdLabSpecColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdXDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdXDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdXDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdXDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdXTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdXTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdXTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdXTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdSkinTest
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdSkinTestColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdSkinTest\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdSkinTestColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdAction
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdActionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdAction\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdActionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdDepProcNotes
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdDepProcNotesColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdDepProcNotes\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdDepProcNotesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdBilled
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdBilledColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdBilled\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdBilledColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OrdSkinTestResult
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetOrdByAdm.OrdSkinTestResultColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetOrdByAdm\"中列\"OrdSkinTestResult\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetOrdByAdm.OrdSkinTestResultColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetOrdByAdmRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetOrdByAdm = (OrderListByDataSet.GetOrdByAdmDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsOrdCreateDateNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdCreateDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdCreateDateNull()
			{
				this[this.tableGetOrdByAdm.OrdCreateDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdCreateTimeNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdCreateTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdCreateTimeNull()
			{
				this[this.tableGetOrdByAdm.OrdCreateTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdStartDateNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdStartDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdStartDateNull()
			{
				this[this.tableGetOrdByAdm.OrdStartDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdStartTimeNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdStartTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdStartTimeNull()
			{
				this[this.tableGetOrdByAdm.OrdStartTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsArcimDescNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.ArcimDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetArcimDescNull()
			{
				this[this.tableGetOrdByAdm.ArcimDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDoseQtyNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.DoseQtyColumn);
			}

			[DebuggerNonUserCode]
			public void SetDoseQtyNull()
			{
				this[this.tableGetOrdByAdm.DoseQtyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDoseUnitNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.DoseUnitColumn);
			}

			[DebuggerNonUserCode]
			public void SetDoseUnitNull()
			{
				this[this.tableGetOrdByAdm.DoseUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPriorityNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.PriorityColumn);
			}

			[DebuggerNonUserCode]
			public void SetPriorityNull()
			{
				this[this.tableGetOrdByAdm.PriorityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPHFreqNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.PHFreqColumn);
			}

			[DebuggerNonUserCode]
			public void SetPHFreqNull()
			{
				this[this.tableGetOrdByAdm.PHFreqColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsInstrNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.InstrColumn);
			}

			[DebuggerNonUserCode]
			public void SetInstrNull()
			{
				this[this.tableGetOrdByAdm.InstrColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDoctorNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.DoctorColumn);
			}

			[DebuggerNonUserCode]
			public void SetDoctorNull()
			{
				this[this.tableGetOrdByAdm.DoctorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdStatusNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdStatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdStatusNull()
			{
				this[this.tableGetOrdByAdm.OrdStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDuraNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.DuraColumn);
			}

			[DebuggerNonUserCode]
			public void SetDuraNull()
			{
				this[this.tableGetOrdByAdm.DuraColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEItemIDNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OEItemIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEItemIDNull()
			{
				this[this.tableGetOrdByAdm.OEItemIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPatientIDNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.PatientIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetPatientIDNull()
			{
				this[this.tableGetOrdByAdm.PatientIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSeqNoNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.SeqNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetSeqNoNull()
			{
				this[this.tableGetOrdByAdm.SeqNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsQtyPackUOMNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.QtyPackUOMColumn);
			}

			[DebuggerNonUserCode]
			public void SetQtyPackUOMNull()
			{
				this[this.tableGetOrdByAdm.QtyPackUOMColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPackUOMDescNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.PackUOMDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetPackUOMDescNull()
			{
				this[this.tableGetOrdByAdm.PackUOMDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPrescNoNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.PrescNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetPrescNoNull()
			{
				this[this.tableGetOrdByAdm.PrescNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsdstatusNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.dstatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetdstatusNull()
			{
				this[this.tableGetOrdByAdm.dstatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLabEpisodeNoNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.LabEpisodeNoColumn);
			}

			[DebuggerNonUserCode]
			public void SetLabEpisodeNoNull()
			{
				this[this.tableGetOrdByAdm.LabEpisodeNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdLabSpecNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdLabSpecColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdLabSpecNull()
			{
				this[this.tableGetOrdByAdm.OrdLabSpecColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdXDateNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdXDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdXDateNull()
			{
				this[this.tableGetOrdByAdm.OrdXDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdXTimeNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdXTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdXTimeNull()
			{
				this[this.tableGetOrdByAdm.OrdXTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdSkinTestNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdSkinTestColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdSkinTestNull()
			{
				this[this.tableGetOrdByAdm.OrdSkinTestColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdActionNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdActionColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdActionNull()
			{
				this[this.tableGetOrdByAdm.OrdActionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdDepProcNotesNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdDepProcNotesColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdDepProcNotesNull()
			{
				this[this.tableGetOrdByAdm.OrdDepProcNotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdBilledNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdBilledColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdBilledNull()
			{
				this[this.tableGetOrdByAdm.OrdBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOrdSkinTestResultNull()
			{
				return this.IsNull(this.tableGetOrdByAdm.OrdSkinTestResultColumn);
			}

			[DebuggerNonUserCode]
			public void SetOrdSkinTestResultNull()
			{
				this[this.tableGetOrdByAdm.OrdSkinTestResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetOrdByAdmRowChangeEvent : EventArgs
		{
			private OrderListByDataSet.GetOrdByAdmRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public OrderListByDataSet.GetOrdByAdmRow Row
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
			public GetOrdByAdmRowChangeEvent(OrderListByDataSet.GetOrdByAdmRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private OrderListByDataSet.GetOrdByAdmDataTable tableGetOrdByAdm;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public OrderListByDataSet.GetOrdByAdmDataTable GetOrdByAdm
		{
			get
			{
				return this.tableGetOrdByAdm;
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
		public OrderListByDataSet()
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
		protected OrderListByDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetOrdByAdm"] != null)
				{
					base.Tables.Add(new OrderListByDataSet.GetOrdByAdmDataTable(dataSet.Tables["GetOrdByAdm"]));
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
			OrderListByDataSet orderListByDataSet = (OrderListByDataSet)base.Clone();
			orderListByDataSet.InitVars();
			orderListByDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return orderListByDataSet;
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
				if (dataSet.Tables["GetOrdByAdm"] != null)
				{
					base.Tables.Add(new OrderListByDataSet.GetOrdByAdmDataTable(dataSet.Tables["GetOrdByAdm"]));
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
			this.tableGetOrdByAdm = (OrderListByDataSet.GetOrdByAdmDataTable)base.Tables["GetOrdByAdm"];
			if (initTable && this.tableGetOrdByAdm != null)
			{
				this.tableGetOrdByAdm.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "OrderListByDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/OrderListByDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetOrdByAdm = new OrderListByDataSet.GetOrdByAdmDataTable();
			base.Tables.Add(this.tableGetOrdByAdm);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetOrdByAdm()
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
			OrderListByDataSet orderListByDataSet = new OrderListByDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = orderListByDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = orderListByDataSet.GetSchemaSerializable();
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
