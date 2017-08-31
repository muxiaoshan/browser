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

namespace UnitData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EUnitByCodeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EUnitByCodeDataset : DataSet
	{
		public delegate void SELECTALLUNITByCodeRowChangeEventHandler(object sender, EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLUNITByCodeDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnENGMeasurementName;

			private DataColumn columnCHSMeasurementName;

			private DataColumn columnSymbol;

			private DataColumn columnDefaultUnit;

			private DataColumn columnConversion;

			private DataColumn columnCoefficient;

			private EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowChangingEvent;

			private EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowChangedEvent;

			private EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowDeletingEvent;

			private EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowDeletedEvent;

			public event EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITByCodeRowChangingEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITByCodeRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITByCodeRowChangingEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITByCodeRowChangingEvent, value);
				}
			}

			public event EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITByCodeRowChangedEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITByCodeRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITByCodeRowChangedEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITByCodeRowChangedEvent, value);
				}
			}

			public event EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITByCodeRowDeletingEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITByCodeRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITByCodeRowDeletingEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITByCodeRowDeletingEvent, value);
				}
			}

			public event EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler SELECTALLUNITByCodeRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITByCodeRowDeletedEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITByCodeRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITByCodeRowDeletedEvent = (EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITByCodeRowDeletedEvent, value);
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
			public DataColumn CodeColumn
			{
				get
				{
					return this.columnCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ENGMeasurementNameColumn
			{
				get
				{
					return this.columnENGMeasurementName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CHSMeasurementNameColumn
			{
				get
				{
					return this.columnCHSMeasurementName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SymbolColumn
			{
				get
				{
					return this.columnSymbol;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DefaultUnitColumn
			{
				get
				{
					return this.columnDefaultUnit;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ConversionColumn
			{
				get
				{
					return this.columnConversion;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CoefficientColumn
			{
				get
				{
					return this.columnCoefficient;
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
			public EUnitByCodeDataset.SELECTALLUNITByCodeRow this[int index]
			{
				get
				{
					return (EUnitByCodeDataset.SELECTALLUNITByCodeRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLUNITByCodeDataTable()
			{
				this.TableName = "SELECTALLUNITByCode";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLUNITByCodeDataTable(DataTable table)
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
			protected SELECTALLUNITByCodeDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLUNITByCodeRow(EUnitByCodeDataset.SELECTALLUNITByCodeRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EUnitByCodeDataset.SELECTALLUNITByCodeRow AddSELECTALLUNITByCodeRow(long ID, string Code, string ENGMeasurementName, string CHSMeasurementName, string Symbol, string DefaultUnit, string Conversion, string Coefficient)
			{
				EUnitByCodeDataset.SELECTALLUNITByCodeRow sELECTALLUNITByCodeRow = (EUnitByCodeDataset.SELECTALLUNITByCodeRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Code,
					ENGMeasurementName,
					CHSMeasurementName,
					Symbol,
					DefaultUnit,
					Conversion,
					Coefficient
				};
				sELECTALLUNITByCodeRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLUNITByCodeRow);
				return sELECTALLUNITByCodeRow;
			}

			[DebuggerNonUserCode]
			public EUnitByCodeDataset.SELECTALLUNITByCodeRow FindByID(long ID)
			{
				return (EUnitByCodeDataset.SELECTALLUNITByCodeRow)this.Rows.Find(new object[]
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
				EUnitByCodeDataset.SELECTALLUNITByCodeDataTable sELECTALLUNITByCodeDataTable = (EUnitByCodeDataset.SELECTALLUNITByCodeDataTable)base.Clone();
				sELECTALLUNITByCodeDataTable.InitVars();
				return sELECTALLUNITByCodeDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EUnitByCodeDataset.SELECTALLUNITByCodeDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnCode = base.Columns["Code"];
				this.columnENGMeasurementName = base.Columns["ENGMeasurementName"];
				this.columnCHSMeasurementName = base.Columns["CHSMeasurementName"];
				this.columnSymbol = base.Columns["Symbol"];
				this.columnDefaultUnit = base.Columns["DefaultUnit"];
				this.columnConversion = base.Columns["Conversion"];
				this.columnCoefficient = base.Columns["Coefficient"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnENGMeasurementName = new DataColumn("ENGMeasurementName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnENGMeasurementName);
				this.columnCHSMeasurementName = new DataColumn("CHSMeasurementName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCHSMeasurementName);
				this.columnSymbol = new DataColumn("Symbol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSymbol);
				this.columnDefaultUnit = new DataColumn("DefaultUnit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDefaultUnit);
				this.columnConversion = new DataColumn("Conversion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnConversion);
				this.columnCoefficient = new DataColumn("Coefficient", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCoefficient);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EUnitByCodeDataset.SELECTALLUNITByCodeRow NewSELECTALLUNITByCodeRow()
			{
				return (EUnitByCodeDataset.SELECTALLUNITByCodeRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EUnitByCodeDataset.SELECTALLUNITByCodeRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EUnitByCodeDataset.SELECTALLUNITByCodeRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLUNITByCodeRowChangedEvent != null)
				{
					EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler sELECTALLUNITByCodeRowChangedEvent = this.SELECTALLUNITByCodeRowChangedEvent;
					if (sELECTALLUNITByCodeRowChangedEvent != null)
					{
						sELECTALLUNITByCodeRowChangedEvent(this, new EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEvent((EUnitByCodeDataset.SELECTALLUNITByCodeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLUNITByCodeRowChangingEvent != null)
				{
					EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler sELECTALLUNITByCodeRowChangingEvent = this.SELECTALLUNITByCodeRowChangingEvent;
					if (sELECTALLUNITByCodeRowChangingEvent != null)
					{
						sELECTALLUNITByCodeRowChangingEvent(this, new EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEvent((EUnitByCodeDataset.SELECTALLUNITByCodeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLUNITByCodeRowDeletedEvent != null)
				{
					EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler sELECTALLUNITByCodeRowDeletedEvent = this.SELECTALLUNITByCodeRowDeletedEvent;
					if (sELECTALLUNITByCodeRowDeletedEvent != null)
					{
						sELECTALLUNITByCodeRowDeletedEvent(this, new EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEvent((EUnitByCodeDataset.SELECTALLUNITByCodeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLUNITByCodeRowDeletingEvent != null)
				{
					EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEventHandler sELECTALLUNITByCodeRowDeletingEvent = this.SELECTALLUNITByCodeRowDeletingEvent;
					if (sELECTALLUNITByCodeRowDeletingEvent != null)
					{
						sELECTALLUNITByCodeRowDeletingEvent(this, new EUnitByCodeDataset.SELECTALLUNITByCodeRowChangeEvent((EUnitByCodeDataset.SELECTALLUNITByCodeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLUNITByCodeRow(EUnitByCodeDataset.SELECTALLUNITByCodeRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EUnitByCodeDataset eUnitByCodeDataset = new EUnitByCodeDataset();
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
				xmlSchemaAttribute.FixedValue = eUnitByCodeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLUNITByCodeDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eUnitByCodeDataset.GetSchemaSerializable();
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
		public class SELECTALLUNITByCodeRow : DataRow
		{
			private EUnitByCodeDataset.SELECTALLUNITByCodeDataTable tableSELECTALLUNITByCode;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALLUNITByCode.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Code
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.CodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ENGMeasurementName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.ENGMeasurementNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"ENGMeasurementName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.ENGMeasurementNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CHSMeasurementName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.CHSMeasurementNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"CHSMeasurementName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.CHSMeasurementNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Symbol
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.SymbolColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"Symbol\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.SymbolColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DefaultUnit
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.DefaultUnitColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"DefaultUnit\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.DefaultUnitColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Conversion
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.ConversionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"Conversion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.ConversionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Coefficient
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLUNITByCode.CoefficientColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNITByCode\"中列\"Coefficient\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNITByCode.CoefficientColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLUNITByCodeRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALLUNITByCode = (EUnitByCodeDataset.SELECTALLUNITByCodeDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSELECTALLUNITByCode.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsENGMeasurementNameNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.ENGMeasurementNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetENGMeasurementNameNull()
			{
				this[this.tableSELECTALLUNITByCode.ENGMeasurementNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCHSMeasurementNameNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.CHSMeasurementNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetCHSMeasurementNameNull()
			{
				this[this.tableSELECTALLUNITByCode.CHSMeasurementNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSymbolNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.SymbolColumn);
			}

			[DebuggerNonUserCode]
			public void SetSymbolNull()
			{
				this[this.tableSELECTALLUNITByCode.SymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDefaultUnitNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.DefaultUnitColumn);
			}

			[DebuggerNonUserCode]
			public void SetDefaultUnitNull()
			{
				this[this.tableSELECTALLUNITByCode.DefaultUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsConversionNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.ConversionColumn);
			}

			[DebuggerNonUserCode]
			public void SetConversionNull()
			{
				this[this.tableSELECTALLUNITByCode.ConversionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCoefficientNull()
			{
				return this.IsNull(this.tableSELECTALLUNITByCode.CoefficientColumn);
			}

			[DebuggerNonUserCode]
			public void SetCoefficientNull()
			{
				this[this.tableSELECTALLUNITByCode.CoefficientColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLUNITByCodeRowChangeEvent : EventArgs
		{
			private EUnitByCodeDataset.SELECTALLUNITByCodeRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EUnitByCodeDataset.SELECTALLUNITByCodeRow Row
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
			public SELECTALLUNITByCodeRowChangeEvent(EUnitByCodeDataset.SELECTALLUNITByCodeRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EUnitByCodeDataset.SELECTALLUNITByCodeDataTable tableSELECTALLUNITByCode;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EUnitByCodeDataset.SELECTALLUNITByCodeDataTable SELECTALLUNITByCode
		{
			get
			{
				return this.tableSELECTALLUNITByCode;
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
		public EUnitByCodeDataset()
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
		protected EUnitByCodeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALLUNITByCode"] != null)
				{
					base.Tables.Add(new EUnitByCodeDataset.SELECTALLUNITByCodeDataTable(dataSet.Tables["SELECTALLUNITByCode"]));
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
			EUnitByCodeDataset eUnitByCodeDataset = (EUnitByCodeDataset)base.Clone();
			eUnitByCodeDataset.InitVars();
			eUnitByCodeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eUnitByCodeDataset;
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
				if (dataSet.Tables["SELECTALLUNITByCode"] != null)
				{
					base.Tables.Add(new EUnitByCodeDataset.SELECTALLUNITByCodeDataTable(dataSet.Tables["SELECTALLUNITByCode"]));
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
			this.tableSELECTALLUNITByCode = (EUnitByCodeDataset.SELECTALLUNITByCodeDataTable)base.Tables["SELECTALLUNITByCode"];
			if (initTable && this.tableSELECTALLUNITByCode != null)
			{
				this.tableSELECTALLUNITByCode.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EUnitByCodeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EUnitByCodeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALLUNITByCode = new EUnitByCodeDataset.SELECTALLUNITByCodeDataTable();
			base.Tables.Add(this.tableSELECTALLUNITByCode);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALLUNITByCode()
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
			EUnitByCodeDataset eUnitByCodeDataset = new EUnitByCodeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eUnitByCodeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eUnitByCodeDataset.GetSchemaSerializable();
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
