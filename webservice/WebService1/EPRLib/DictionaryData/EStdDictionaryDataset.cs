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

namespace DictionaryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EStdDictionaryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EStdDictionaryDataset : DataSet
	{
		public delegate void SELECTALLRowChangeEventHandler(object sender, EStdDictionaryDataset.SELECTALLRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnTableName;

			private DataColumn columnDicCodeCol;

			private DataColumn columnDicDescCol;

			private DataColumn columnDicAliasCol;

			private DataColumn columnIsRuleType;

			private DataColumn columnRuleTypeTag;

			private DataColumn columnCondition;

			private DataColumn columnConditionCode;

			private DataColumn columnIsDiagnosRuleType;

			private EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangingEvent;

			private EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangedEvent;

			private EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletingEvent;

			private EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletedEvent;

			public event EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangingEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangingEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangingEvent, value);
				}
			}

			public event EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangedEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangedEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangedEvent, value);
				}
			}

			public event EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletingEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletingEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletingEvent, value);
				}
			}

			public event EStdDictionaryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletedEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletedEvent = (EStdDictionaryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletedEvent, value);
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TableNameColumn
			{
				get
				{
					return this.columnTableName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DicCodeColColumn
			{
				get
				{
					return this.columnDicCodeCol;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DicDescColColumn
			{
				get
				{
					return this.columnDicDescCol;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DicAliasColColumn
			{
				get
				{
					return this.columnDicAliasCol;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn IsRuleTypeColumn
			{
				get
				{
					return this.columnIsRuleType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn RuleTypeTagColumn
			{
				get
				{
					return this.columnRuleTypeTag;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ConditionColumn
			{
				get
				{
					return this.columnCondition;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ConditionCodeColumn
			{
				get
				{
					return this.columnConditionCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn IsDiagnosRuleTypeColumn
			{
				get
				{
					return this.columnIsDiagnosRuleType;
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
			public EStdDictionaryDataset.SELECTALLRow this[int index]
			{
				get
				{
					return (EStdDictionaryDataset.SELECTALLRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLDataTable()
			{
				this.TableName = "SELECTALL";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLDataTable(DataTable table)
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
			protected SELECTALLDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLRow(EStdDictionaryDataset.SELECTALLRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EStdDictionaryDataset.SELECTALLRow AddSELECTALLRow(long ID, string Code, string Name, string Description, string TableName, string DicCodeCol, string DicDescCol, string DicAliasCol, string IsRuleType, string RuleTypeTag, string Condition, string ConditionCode, string IsDiagnosRuleType)
			{
				EStdDictionaryDataset.SELECTALLRow sELECTALLRow = (EStdDictionaryDataset.SELECTALLRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Code,
					Name,
					Description,
					TableName,
					DicCodeCol,
					DicDescCol,
					DicAliasCol,
					IsRuleType,
					RuleTypeTag,
					Condition,
					ConditionCode,
					IsDiagnosRuleType
				};
				sELECTALLRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLRow);
				return sELECTALLRow;
			}

			[DebuggerNonUserCode]
			public EStdDictionaryDataset.SELECTALLRow FindByID(long ID)
			{
				return (EStdDictionaryDataset.SELECTALLRow)this.Rows.Find(new object[]
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
				EStdDictionaryDataset.SELECTALLDataTable sELECTALLDataTable = (EStdDictionaryDataset.SELECTALLDataTable)base.Clone();
				sELECTALLDataTable.InitVars();
				return sELECTALLDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EStdDictionaryDataset.SELECTALLDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnCode = base.Columns["Code"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnTableName = base.Columns["TableName"];
				this.columnDicCodeCol = base.Columns["DicCodeCol"];
				this.columnDicDescCol = base.Columns["DicDescCol"];
				this.columnDicAliasCol = base.Columns["DicAliasCol"];
				this.columnIsRuleType = base.Columns["IsRuleType"];
				this.columnRuleTypeTag = base.Columns["RuleTypeTag"];
				this.columnCondition = base.Columns["Condition"];
				this.columnConditionCode = base.Columns["ConditionCode"];
				this.columnIsDiagnosRuleType = base.Columns["IsDiagnosRuleType"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnTableName = new DataColumn("TableName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTableName);
				this.columnDicCodeCol = new DataColumn("DicCodeCol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicCodeCol);
				this.columnDicDescCol = new DataColumn("DicDescCol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicDescCol);
				this.columnDicAliasCol = new DataColumn("DicAliasCol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicAliasCol);
				this.columnIsRuleType = new DataColumn("IsRuleType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIsRuleType);
				this.columnRuleTypeTag = new DataColumn("RuleTypeTag", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRuleTypeTag);
				this.columnCondition = new DataColumn("Condition", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCondition);
				this.columnConditionCode = new DataColumn("ConditionCode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnConditionCode);
				this.columnIsDiagnosRuleType = new DataColumn("IsDiagnosRuleType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIsDiagnosRuleType);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EStdDictionaryDataset.SELECTALLRow NewSELECTALLRow()
			{
				return (EStdDictionaryDataset.SELECTALLRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EStdDictionaryDataset.SELECTALLRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EStdDictionaryDataset.SELECTALLRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLRowChangedEvent != null)
				{
					EStdDictionaryDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangedEvent = this.SELECTALLRowChangedEvent;
					if (sELECTALLRowChangedEvent != null)
					{
						sELECTALLRowChangedEvent(this, new EStdDictionaryDataset.SELECTALLRowChangeEvent((EStdDictionaryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLRowChangingEvent != null)
				{
					EStdDictionaryDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangingEvent = this.SELECTALLRowChangingEvent;
					if (sELECTALLRowChangingEvent != null)
					{
						sELECTALLRowChangingEvent(this, new EStdDictionaryDataset.SELECTALLRowChangeEvent((EStdDictionaryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLRowDeletedEvent != null)
				{
					EStdDictionaryDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletedEvent = this.SELECTALLRowDeletedEvent;
					if (sELECTALLRowDeletedEvent != null)
					{
						sELECTALLRowDeletedEvent(this, new EStdDictionaryDataset.SELECTALLRowChangeEvent((EStdDictionaryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLRowDeletingEvent != null)
				{
					EStdDictionaryDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletingEvent = this.SELECTALLRowDeletingEvent;
					if (sELECTALLRowDeletingEvent != null)
					{
						sELECTALLRowDeletingEvent(this, new EStdDictionaryDataset.SELECTALLRowChangeEvent((EStdDictionaryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLRow(EStdDictionaryDataset.SELECTALLRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EStdDictionaryDataset eStdDictionaryDataset = new EStdDictionaryDataset();
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
				xmlSchemaAttribute.FixedValue = eStdDictionaryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eStdDictionaryDataset.GetSchemaSerializable();
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
		public class SELECTALLRow : DataRow
		{
			private EStdDictionaryDataset.SELECTALLDataTable tableSELECTALL;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALL.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALL.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALL.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.CodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Description
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string TableName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.TableNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"TableName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.TableNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicCodeCol
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.DicCodeColColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"DicCodeCol\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.DicCodeColColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicDescCol
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.DicDescColColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"DicDescCol\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.DicDescColColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicAliasCol
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.DicAliasColColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"DicAliasCol\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.DicAliasColColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string IsRuleType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.IsRuleTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"IsRuleType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.IsRuleTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string RuleTypeTag
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.RuleTypeTagColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"RuleTypeTag\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.RuleTypeTagColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Condition
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.ConditionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Condition\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.ConditionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ConditionCode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.ConditionCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"ConditionCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.ConditionCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string IsDiagnosRuleType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.IsDiagnosRuleTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"IsDiagnosRuleType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.IsDiagnosRuleTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALL = (EStdDictionaryDataset.SELECTALLDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSELECTALL.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSELECTALL.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTALL.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTALL.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTALL.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTALL.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTableNameNull()
			{
				return this.IsNull(this.tableSELECTALL.TableNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetTableNameNull()
			{
				this[this.tableSELECTALL.TableNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicCodeColNull()
			{
				return this.IsNull(this.tableSELECTALL.DicCodeColColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicCodeColNull()
			{
				this[this.tableSELECTALL.DicCodeColColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicDescColNull()
			{
				return this.IsNull(this.tableSELECTALL.DicDescColColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicDescColNull()
			{
				this[this.tableSELECTALL.DicDescColColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicAliasColNull()
			{
				return this.IsNull(this.tableSELECTALL.DicAliasColColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicAliasColNull()
			{
				this[this.tableSELECTALL.DicAliasColColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsRuleTypeNull()
			{
				return this.IsNull(this.tableSELECTALL.IsRuleTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsRuleTypeNull()
			{
				this[this.tableSELECTALL.IsRuleTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRuleTypeTagNull()
			{
				return this.IsNull(this.tableSELECTALL.RuleTypeTagColumn);
			}

			[DebuggerNonUserCode]
			public void SetRuleTypeTagNull()
			{
				this[this.tableSELECTALL.RuleTypeTagColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsConditionNull()
			{
				return this.IsNull(this.tableSELECTALL.ConditionColumn);
			}

			[DebuggerNonUserCode]
			public void SetConditionNull()
			{
				this[this.tableSELECTALL.ConditionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsConditionCodeNull()
			{
				return this.IsNull(this.tableSELECTALL.ConditionCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetConditionCodeNull()
			{
				this[this.tableSELECTALL.ConditionCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsIsDiagnosRuleTypeNull()
			{
				return this.IsNull(this.tableSELECTALL.IsDiagnosRuleTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetIsDiagnosRuleTypeNull()
			{
				this[this.tableSELECTALL.IsDiagnosRuleTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLRowChangeEvent : EventArgs
		{
			private EStdDictionaryDataset.SELECTALLRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EStdDictionaryDataset.SELECTALLRow Row
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
			public SELECTALLRowChangeEvent(EStdDictionaryDataset.SELECTALLRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EStdDictionaryDataset.SELECTALLDataTable tableSELECTALL;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EStdDictionaryDataset.SELECTALLDataTable SELECTALL
		{
			get
			{
				return this.tableSELECTALL;
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
		public EStdDictionaryDataset()
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
		protected EStdDictionaryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new EStdDictionaryDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			EStdDictionaryDataset eStdDictionaryDataset = (EStdDictionaryDataset)base.Clone();
			eStdDictionaryDataset.InitVars();
			eStdDictionaryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eStdDictionaryDataset;
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new EStdDictionaryDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			this.tableSELECTALL = (EStdDictionaryDataset.SELECTALLDataTable)base.Tables["SELECTALL"];
			if (initTable && this.tableSELECTALL != null)
			{
				this.tableSELECTALL.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EStdDictionaryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ETemplateDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALL = new EStdDictionaryDataset.SELECTALLDataTable();
			base.Tables.Add(this.tableSELECTALL);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALL()
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
			EStdDictionaryDataset eStdDictionaryDataset = new EStdDictionaryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eStdDictionaryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eStdDictionaryDataset.GetSchemaSerializable();
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
