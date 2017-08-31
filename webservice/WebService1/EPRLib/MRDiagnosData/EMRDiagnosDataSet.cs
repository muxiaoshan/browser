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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosDataSet : DataSet
	{
		public delegate void GetMRDiagnosListRowChangeEventHandler(object sender, EMRDiagnosDataSet.GetMRDiagnosListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetMRDiagnosListDataTable : DataTable, IEnumerable
		{
			private DataColumn columnARowID;

			private DataColumn columnAMRADMRowId;

			private DataColumn columnADiaSubID;

			private DataColumn columnADiagnosTypeID;

			private DataColumn columnADiagnosType;

			private DataColumn columnAICDID;

			private DataColumn columnADiagnosName;

			private DataColumn columnADemo;

			private DataColumn columnAEvaluation;

			private DataColumn columnAEvaluationDesc;

			private DataColumn columnAICDCode;

			private DataColumn columnAEffects;

			private DataColumn columnAEffectsDesc;

			private DataColumn columnALevel;

			private DataColumn columnASquence;

			private DataColumn columnAUserName;

			private DataColumn columnADateTime;

			private EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowChangingEvent;

			private EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowChangedEvent;

			private EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowDeletingEvent;

			private EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowDeletedEvent;

			public event EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetMRDiagnosListRowChangingEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Combine(this.GetMRDiagnosListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetMRDiagnosListRowChangingEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Remove(this.GetMRDiagnosListRowChangingEvent, value);
				}
			}

			public event EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetMRDiagnosListRowChangedEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Combine(this.GetMRDiagnosListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetMRDiagnosListRowChangedEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Remove(this.GetMRDiagnosListRowChangedEvent, value);
				}
			}

			public event EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetMRDiagnosListRowDeletingEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Combine(this.GetMRDiagnosListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetMRDiagnosListRowDeletingEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Remove(this.GetMRDiagnosListRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler GetMRDiagnosListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetMRDiagnosListRowDeletedEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Combine(this.GetMRDiagnosListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetMRDiagnosListRowDeletedEvent = (EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler)Delegate.Remove(this.GetMRDiagnosListRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ARowIDColumn
			{
				get
				{
					return this.columnARowID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AMRADMRowIdColumn
			{
				get
				{
					return this.columnAMRADMRowId;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADiaSubIDColumn
			{
				get
				{
					return this.columnADiaSubID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADiagnosTypeIDColumn
			{
				get
				{
					return this.columnADiagnosTypeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADiagnosTypeColumn
			{
				get
				{
					return this.columnADiagnosType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AICDIDColumn
			{
				get
				{
					return this.columnAICDID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADiagnosNameColumn
			{
				get
				{
					return this.columnADiagnosName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADemoColumn
			{
				get
				{
					return this.columnADemo;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AEvaluationColumn
			{
				get
				{
					return this.columnAEvaluation;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AEvaluationDescColumn
			{
				get
				{
					return this.columnAEvaluationDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AICDCodeColumn
			{
				get
				{
					return this.columnAICDCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AEffectsColumn
			{
				get
				{
					return this.columnAEffects;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AEffectsDescColumn
			{
				get
				{
					return this.columnAEffectsDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ALevelColumn
			{
				get
				{
					return this.columnALevel;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ASquenceColumn
			{
				get
				{
					return this.columnASquence;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AUserNameColumn
			{
				get
				{
					return this.columnAUserName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADateTimeColumn
			{
				get
				{
					return this.columnADateTime;
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
			public EMRDiagnosDataSet.GetMRDiagnosListRow this[int index]
			{
				get
				{
					return (EMRDiagnosDataSet.GetMRDiagnosListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetMRDiagnosListDataTable()
			{
				this.TableName = "GetMRDiagnosList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetMRDiagnosListDataTable(DataTable table)
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
			protected GetMRDiagnosListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetMRDiagnosListRow(EMRDiagnosDataSet.GetMRDiagnosListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosDataSet.GetMRDiagnosListRow AddGetMRDiagnosListRow(string ARowID, string AMRADMRowId, string ADiaSubID, string ADiagnosTypeID, string ADiagnosType, string AICDID, string ADiagnosName, string ADemo, string AEvaluation, string AEvaluationDesc, string AICDCode, string AEffects, string AEffectsDesc, string ALevel, string ASquence, string AUserName, string ADateTime)
			{
				EMRDiagnosDataSet.GetMRDiagnosListRow getMRDiagnosListRow = (EMRDiagnosDataSet.GetMRDiagnosListRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ARowID,
					AMRADMRowId,
					ADiaSubID,
					ADiagnosTypeID,
					ADiagnosType,
					AICDID,
					ADiagnosName,
					ADemo,
					AEvaluation,
					AEvaluationDesc,
					AICDCode,
					AEffects,
					AEffectsDesc,
					ALevel,
					ASquence,
					AUserName,
					ADateTime
				};
				getMRDiagnosListRow.ItemArray = itemArray;
				this.Rows.Add(getMRDiagnosListRow);
				return getMRDiagnosListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosDataSet.GetMRDiagnosListDataTable getMRDiagnosListDataTable = (EMRDiagnosDataSet.GetMRDiagnosListDataTable)base.Clone();
				getMRDiagnosListDataTable.InitVars();
				return getMRDiagnosListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosDataSet.GetMRDiagnosListDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnARowID = base.Columns["ARowID"];
				this.columnAMRADMRowId = base.Columns["AMRADMRowId"];
				this.columnADiaSubID = base.Columns["ADiaSubID"];
				this.columnADiagnosTypeID = base.Columns["ADiagnosTypeID"];
				this.columnADiagnosType = base.Columns["ADiagnosType"];
				this.columnAICDID = base.Columns["AICDID"];
				this.columnADiagnosName = base.Columns["ADiagnosName"];
				this.columnADemo = base.Columns["ADemo"];
				this.columnAEvaluation = base.Columns["AEvaluation"];
				this.columnAEvaluationDesc = base.Columns["AEvaluationDesc"];
				this.columnAICDCode = base.Columns["AICDCode"];
				this.columnAEffects = base.Columns["AEffects"];
				this.columnAEffectsDesc = base.Columns["AEffectsDesc"];
				this.columnALevel = base.Columns["ALevel"];
				this.columnASquence = base.Columns["ASquence"];
				this.columnAUserName = base.Columns["AUserName"];
				this.columnADateTime = base.Columns["ADateTime"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnARowID = new DataColumn("ARowID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnARowID);
				this.columnAMRADMRowId = new DataColumn("AMRADMRowId", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAMRADMRowId);
				this.columnADiaSubID = new DataColumn("ADiaSubID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADiaSubID);
				this.columnADiagnosTypeID = new DataColumn("ADiagnosTypeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADiagnosTypeID);
				this.columnADiagnosType = new DataColumn("ADiagnosType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADiagnosType);
				this.columnAICDID = new DataColumn("AICDID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAICDID);
				this.columnADiagnosName = new DataColumn("ADiagnosName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADiagnosName);
				this.columnADemo = new DataColumn("ADemo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADemo);
				this.columnAEvaluation = new DataColumn("AEvaluation", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAEvaluation);
				this.columnAEvaluationDesc = new DataColumn("AEvaluationDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAEvaluationDesc);
				this.columnAICDCode = new DataColumn("AICDCode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAICDCode);
				this.columnAEffects = new DataColumn("AEffects", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAEffects);
				this.columnAEffectsDesc = new DataColumn("AEffectsDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAEffectsDesc);
				this.columnALevel = new DataColumn("ALevel", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnALevel);
				this.columnASquence = new DataColumn("ASquence", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnASquence);
				this.columnAUserName = new DataColumn("AUserName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAUserName);
				this.columnADateTime = new DataColumn("ADateTime", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADateTime);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosDataSet.GetMRDiagnosListRow NewGetMRDiagnosListRow()
			{
				return (EMRDiagnosDataSet.GetMRDiagnosListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosDataSet.GetMRDiagnosListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosDataSet.GetMRDiagnosListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetMRDiagnosListRowChangedEvent != null)
				{
					EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler getMRDiagnosListRowChangedEvent = this.GetMRDiagnosListRowChangedEvent;
					if (getMRDiagnosListRowChangedEvent != null)
					{
						getMRDiagnosListRowChangedEvent(this, new EMRDiagnosDataSet.GetMRDiagnosListRowChangeEvent((EMRDiagnosDataSet.GetMRDiagnosListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetMRDiagnosListRowChangingEvent != null)
				{
					EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler getMRDiagnosListRowChangingEvent = this.GetMRDiagnosListRowChangingEvent;
					if (getMRDiagnosListRowChangingEvent != null)
					{
						getMRDiagnosListRowChangingEvent(this, new EMRDiagnosDataSet.GetMRDiagnosListRowChangeEvent((EMRDiagnosDataSet.GetMRDiagnosListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetMRDiagnosListRowDeletedEvent != null)
				{
					EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler getMRDiagnosListRowDeletedEvent = this.GetMRDiagnosListRowDeletedEvent;
					if (getMRDiagnosListRowDeletedEvent != null)
					{
						getMRDiagnosListRowDeletedEvent(this, new EMRDiagnosDataSet.GetMRDiagnosListRowChangeEvent((EMRDiagnosDataSet.GetMRDiagnosListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetMRDiagnosListRowDeletingEvent != null)
				{
					EMRDiagnosDataSet.GetMRDiagnosListRowChangeEventHandler getMRDiagnosListRowDeletingEvent = this.GetMRDiagnosListRowDeletingEvent;
					if (getMRDiagnosListRowDeletingEvent != null)
					{
						getMRDiagnosListRowDeletingEvent(this, new EMRDiagnosDataSet.GetMRDiagnosListRowChangeEvent((EMRDiagnosDataSet.GetMRDiagnosListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetMRDiagnosListRow(EMRDiagnosDataSet.GetMRDiagnosListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosDataSet eMRDiagnosDataSet = new EMRDiagnosDataSet();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetMRDiagnosListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosDataSet.GetSchemaSerializable();
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
		public class GetMRDiagnosListRow : DataRow
		{
			private EMRDiagnosDataSet.GetMRDiagnosListDataTable tableGetMRDiagnosList;

			[DebuggerNonUserCode]
			public string ARowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ARowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ARowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ARowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AMRADMRowId
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AMRADMRowIdColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AMRADMRowId\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AMRADMRowIdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADiaSubID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADiaSubIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADiaSubID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADiaSubIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADiagnosTypeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADiagnosTypeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADiagnosTypeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADiagnosTypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADiagnosType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADiagnosTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADiagnosType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADiagnosTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AICDID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AICDIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AICDID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AICDIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADiagnosName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADiagnosNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADiagnosName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADiagnosNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADemo
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADemoColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADemo\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADemoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AEvaluation
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AEvaluationColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AEvaluation\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AEvaluationColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AEvaluationDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AEvaluationDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AEvaluationDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AEvaluationDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AICDCode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AICDCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AICDCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AICDCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AEffects
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AEffectsColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AEffects\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AEffectsColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AEffectsDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AEffectsDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AEffectsDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AEffectsDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ALevel
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ALevelColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ALevel\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ALevelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ASquence
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ASquenceColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ASquence\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ASquenceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AUserName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.AUserNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"AUserName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.AUserNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADateTime
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetMRDiagnosList.ADateTimeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetMRDiagnosList\"中列\"ADateTime\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetMRDiagnosList.ADateTimeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetMRDiagnosListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetMRDiagnosList = (EMRDiagnosDataSet.GetMRDiagnosListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsARowIDNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ARowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetARowIDNull()
			{
				this[this.tableGetMRDiagnosList.ARowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAMRADMRowIdNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AMRADMRowIdColumn);
			}

			[DebuggerNonUserCode]
			public void SetAMRADMRowIdNull()
			{
				this[this.tableGetMRDiagnosList.AMRADMRowIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADiaSubIDNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADiaSubIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetADiaSubIDNull()
			{
				this[this.tableGetMRDiagnosList.ADiaSubIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADiagnosTypeIDNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADiagnosTypeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetADiagnosTypeIDNull()
			{
				this[this.tableGetMRDiagnosList.ADiagnosTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADiagnosTypeNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADiagnosTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetADiagnosTypeNull()
			{
				this[this.tableGetMRDiagnosList.ADiagnosTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAICDIDNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AICDIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetAICDIDNull()
			{
				this[this.tableGetMRDiagnosList.AICDIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADiagnosNameNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADiagnosNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetADiagnosNameNull()
			{
				this[this.tableGetMRDiagnosList.ADiagnosNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADemoNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADemoColumn);
			}

			[DebuggerNonUserCode]
			public void SetADemoNull()
			{
				this[this.tableGetMRDiagnosList.ADemoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAEvaluationNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AEvaluationColumn);
			}

			[DebuggerNonUserCode]
			public void SetAEvaluationNull()
			{
				this[this.tableGetMRDiagnosList.AEvaluationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAEvaluationDescNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AEvaluationDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetAEvaluationDescNull()
			{
				this[this.tableGetMRDiagnosList.AEvaluationDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAICDCodeNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AICDCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetAICDCodeNull()
			{
				this[this.tableGetMRDiagnosList.AICDCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAEffectsNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AEffectsColumn);
			}

			[DebuggerNonUserCode]
			public void SetAEffectsNull()
			{
				this[this.tableGetMRDiagnosList.AEffectsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAEffectsDescNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AEffectsDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetAEffectsDescNull()
			{
				this[this.tableGetMRDiagnosList.AEffectsDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsALevelNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ALevelColumn);
			}

			[DebuggerNonUserCode]
			public void SetALevelNull()
			{
				this[this.tableGetMRDiagnosList.ALevelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsASquenceNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ASquenceColumn);
			}

			[DebuggerNonUserCode]
			public void SetASquenceNull()
			{
				this[this.tableGetMRDiagnosList.ASquenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAUserNameNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.AUserNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetAUserNameNull()
			{
				this[this.tableGetMRDiagnosList.AUserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADateTimeNull()
			{
				return this.IsNull(this.tableGetMRDiagnosList.ADateTimeColumn);
			}

			[DebuggerNonUserCode]
			public void SetADateTimeNull()
			{
				this[this.tableGetMRDiagnosList.ADateTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetMRDiagnosListRowChangeEvent : EventArgs
		{
			private EMRDiagnosDataSet.GetMRDiagnosListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosDataSet.GetMRDiagnosListRow Row
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
			public GetMRDiagnosListRowChangeEvent(EMRDiagnosDataSet.GetMRDiagnosListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosDataSet.GetMRDiagnosListDataTable tableGetMRDiagnosList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosDataSet.GetMRDiagnosListDataTable GetMRDiagnosList
		{
			get
			{
				return this.tableGetMRDiagnosList;
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
		public EMRDiagnosDataSet()
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
		protected EMRDiagnosDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetMRDiagnosList"] != null)
				{
					base.Tables.Add(new EMRDiagnosDataSet.GetMRDiagnosListDataTable(dataSet.Tables["GetMRDiagnosList"]));
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
			EMRDiagnosDataSet eMRDiagnosDataSet = (EMRDiagnosDataSet)base.Clone();
			eMRDiagnosDataSet.InitVars();
			eMRDiagnosDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosDataSet;
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
				if (dataSet.Tables["GetMRDiagnosList"] != null)
				{
					base.Tables.Add(new EMRDiagnosDataSet.GetMRDiagnosListDataTable(dataSet.Tables["GetMRDiagnosList"]));
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
			this.tableGetMRDiagnosList = (EMRDiagnosDataSet.GetMRDiagnosListDataTable)base.Tables["GetMRDiagnosList"];
			if (initTable && this.tableGetMRDiagnosList != null)
			{
				this.tableGetMRDiagnosList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetMRDiagnosList = new EMRDiagnosDataSet.GetMRDiagnosListDataTable();
			base.Tables.Add(this.tableGetMRDiagnosList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetMRDiagnosList()
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
			EMRDiagnosDataSet eMRDiagnosDataSet = new EMRDiagnosDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosDataSet.GetSchemaSerializable();
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
