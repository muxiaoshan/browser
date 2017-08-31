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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EUnitDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EUnitDataset : DataSet
	{
		public delegate void SELECTALLUNITRowChangeEventHandler(object sender, EUnitDataset.SELECTALLUNITRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLUNITDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnENGMeasurementName;

			private DataColumn columnCHSMeasurementName;

			private DataColumn columnSymbol;

			private DataColumn columnDefaultUnit;

			private DataColumn columnConversion;

			private DataColumn columnCoefficient;

			private EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowChangingEvent;

			private EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowChangedEvent;

			private EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowDeletingEvent;

			private EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowDeletedEvent;

			public event EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITRowChangingEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITRowChangingEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITRowChangingEvent, value);
				}
			}

			public event EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITRowChangedEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITRowChangedEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITRowChangedEvent, value);
				}
			}

			public event EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITRowDeletingEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITRowDeletingEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITRowDeletingEvent, value);
				}
			}

			public event EUnitDataset.SELECTALLUNITRowChangeEventHandler SELECTALLUNITRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLUNITRowDeletedEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Combine(this.SELECTALLUNITRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLUNITRowDeletedEvent = (EUnitDataset.SELECTALLUNITRowChangeEventHandler)Delegate.Remove(this.SELECTALLUNITRowDeletedEvent, value);
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
			public EUnitDataset.SELECTALLUNITRow this[int index]
			{
				get
				{
					return (EUnitDataset.SELECTALLUNITRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLUNITDataTable()
			{
				this.TableName = "SELECTALLUNIT";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLUNITDataTable(DataTable table)
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
			protected SELECTALLUNITDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLUNITRow(EUnitDataset.SELECTALLUNITRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EUnitDataset.SELECTALLUNITRow AddSELECTALLUNITRow(long ID, string Code, string ENGMeasurementName, string CHSMeasurementName, string Symbol, string DefaultUnit, string Conversion, string Coefficient)
			{
				EUnitDataset.SELECTALLUNITRow sELECTALLUNITRow = (EUnitDataset.SELECTALLUNITRow)this.NewRow();
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
				sELECTALLUNITRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLUNITRow);
				return sELECTALLUNITRow;
			}

			[DebuggerNonUserCode]
			public EUnitDataset.SELECTALLUNITRow FindByID(long ID)
			{
				return (EUnitDataset.SELECTALLUNITRow)this.Rows.Find(new object[]
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
				EUnitDataset.SELECTALLUNITDataTable sELECTALLUNITDataTable = (EUnitDataset.SELECTALLUNITDataTable)base.Clone();
				sELECTALLUNITDataTable.InitVars();
				return sELECTALLUNITDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EUnitDataset.SELECTALLUNITDataTable();
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
			public EUnitDataset.SELECTALLUNITRow NewSELECTALLUNITRow()
			{
				return (EUnitDataset.SELECTALLUNITRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EUnitDataset.SELECTALLUNITRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EUnitDataset.SELECTALLUNITRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLUNITRowChangedEvent != null)
				{
					EUnitDataset.SELECTALLUNITRowChangeEventHandler sELECTALLUNITRowChangedEvent = this.SELECTALLUNITRowChangedEvent;
					if (sELECTALLUNITRowChangedEvent != null)
					{
						sELECTALLUNITRowChangedEvent(this, new EUnitDataset.SELECTALLUNITRowChangeEvent((EUnitDataset.SELECTALLUNITRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLUNITRowChangingEvent != null)
				{
					EUnitDataset.SELECTALLUNITRowChangeEventHandler sELECTALLUNITRowChangingEvent = this.SELECTALLUNITRowChangingEvent;
					if (sELECTALLUNITRowChangingEvent != null)
					{
						sELECTALLUNITRowChangingEvent(this, new EUnitDataset.SELECTALLUNITRowChangeEvent((EUnitDataset.SELECTALLUNITRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLUNITRowDeletedEvent != null)
				{
					EUnitDataset.SELECTALLUNITRowChangeEventHandler sELECTALLUNITRowDeletedEvent = this.SELECTALLUNITRowDeletedEvent;
					if (sELECTALLUNITRowDeletedEvent != null)
					{
						sELECTALLUNITRowDeletedEvent(this, new EUnitDataset.SELECTALLUNITRowChangeEvent((EUnitDataset.SELECTALLUNITRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLUNITRowDeletingEvent != null)
				{
					EUnitDataset.SELECTALLUNITRowChangeEventHandler sELECTALLUNITRowDeletingEvent = this.SELECTALLUNITRowDeletingEvent;
					if (sELECTALLUNITRowDeletingEvent != null)
					{
						sELECTALLUNITRowDeletingEvent(this, new EUnitDataset.SELECTALLUNITRowChangeEvent((EUnitDataset.SELECTALLUNITRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLUNITRow(EUnitDataset.SELECTALLUNITRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EUnitDataset eUnitDataset = new EUnitDataset();
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
				xmlSchemaAttribute.FixedValue = eUnitDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLUNITDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eUnitDataset.GetSchemaSerializable();
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
		public class SELECTALLUNITRow : DataRow
		{
			private EUnitDataset.SELECTALLUNITDataTable tableSELECTALLUNIT;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALLUNIT.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALLUNIT.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.CodeColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.ENGMeasurementNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"ENGMeasurementName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.ENGMeasurementNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.CHSMeasurementNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"CHSMeasurementName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.CHSMeasurementNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.SymbolColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"Symbol\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.SymbolColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.DefaultUnitColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"DefaultUnit\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.DefaultUnitColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.ConversionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"Conversion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.ConversionColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLUNIT.CoefficientColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLUNIT\"中列\"Coefficient\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLUNIT.CoefficientColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLUNITRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALLUNIT = (EUnitDataset.SELECTALLUNITDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSELECTALLUNIT.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsENGMeasurementNameNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.ENGMeasurementNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetENGMeasurementNameNull()
			{
				this[this.tableSELECTALLUNIT.ENGMeasurementNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCHSMeasurementNameNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.CHSMeasurementNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetCHSMeasurementNameNull()
			{
				this[this.tableSELECTALLUNIT.CHSMeasurementNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSymbolNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.SymbolColumn);
			}

			[DebuggerNonUserCode]
			public void SetSymbolNull()
			{
				this[this.tableSELECTALLUNIT.SymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDefaultUnitNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.DefaultUnitColumn);
			}

			[DebuggerNonUserCode]
			public void SetDefaultUnitNull()
			{
				this[this.tableSELECTALLUNIT.DefaultUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsConversionNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.ConversionColumn);
			}

			[DebuggerNonUserCode]
			public void SetConversionNull()
			{
				this[this.tableSELECTALLUNIT.ConversionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCoefficientNull()
			{
				return this.IsNull(this.tableSELECTALLUNIT.CoefficientColumn);
			}

			[DebuggerNonUserCode]
			public void SetCoefficientNull()
			{
				this[this.tableSELECTALLUNIT.CoefficientColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLUNITRowChangeEvent : EventArgs
		{
			private EUnitDataset.SELECTALLUNITRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EUnitDataset.SELECTALLUNITRow Row
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
			public SELECTALLUNITRowChangeEvent(EUnitDataset.SELECTALLUNITRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EUnitDataset.SELECTALLUNITDataTable tableSELECTALLUNIT;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EUnitDataset.SELECTALLUNITDataTable SELECTALLUNIT
		{
			get
			{
				return this.tableSELECTALLUNIT;
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
		public EUnitDataset()
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
		protected EUnitDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALLUNIT"] != null)
				{
					base.Tables.Add(new EUnitDataset.SELECTALLUNITDataTable(dataSet.Tables["SELECTALLUNIT"]));
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
			EUnitDataset eUnitDataset = (EUnitDataset)base.Clone();
			eUnitDataset.InitVars();
			eUnitDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eUnitDataset;
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
				if (dataSet.Tables["SELECTALLUNIT"] != null)
				{
					base.Tables.Add(new EUnitDataset.SELECTALLUNITDataTable(dataSet.Tables["SELECTALLUNIT"]));
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
			this.tableSELECTALLUNIT = (EUnitDataset.SELECTALLUNITDataTable)base.Tables["SELECTALLUNIT"];
			if (initTable && this.tableSELECTALLUNIT != null)
			{
				this.tableSELECTALLUNIT.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EUnitDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EUnitDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALLUNIT = new EUnitDataset.SELECTALLUNITDataTable();
			base.Tables.Add(this.tableSELECTALLUNIT);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALLUNIT()
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
			EUnitDataset eUnitDataset = new EUnitDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eUnitDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eUnitDataset.GetSchemaSerializable();
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
