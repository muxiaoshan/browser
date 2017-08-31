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

namespace InterfaceTemplateData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ETemplateDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ETemplateDataset : DataSet
	{
		public delegate void SELECTALLByCategoryIDRowChangeEventHandler(object sender, ETemplateDataset.SELECTALLByCategoryIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLByCategoryIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnGUID;

			private DataColumn columnTemplateCategoryID;

			private DataColumn columnDescription;

			private DataColumn columnPublishVersion;

			private DataColumn columnLastVersion;

			private DataColumn columnChartItemType;

			private DataColumn columnBindPrintTemplateID;

			private DataColumn columnBindPrintName;

			private DataColumn columnTemplateProperty;

			private ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowChangingEvent;

			private ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowChangedEvent;

			private ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowDeletingEvent;

			private ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowDeletedEvent;

			public event ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLByCategoryIDRowChangingEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SELECTALLByCategoryIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLByCategoryIDRowChangingEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SELECTALLByCategoryIDRowChangingEvent, value);
				}
			}

			public event ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLByCategoryIDRowChangedEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SELECTALLByCategoryIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLByCategoryIDRowChangedEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SELECTALLByCategoryIDRowChangedEvent, value);
				}
			}

			public event ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLByCategoryIDRowDeletingEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SELECTALLByCategoryIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLByCategoryIDRowDeletingEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SELECTALLByCategoryIDRowDeletingEvent, value);
				}
			}

			public event ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler SELECTALLByCategoryIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLByCategoryIDRowDeletedEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SELECTALLByCategoryIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLByCategoryIDRowDeletedEvent = (ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SELECTALLByCategoryIDRowDeletedEvent, value);
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GUIDColumn
			{
				get
				{
					return this.columnGUID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TemplateCategoryIDColumn
			{
				get
				{
					return this.columnTemplateCategoryID;
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
			public DataColumn PublishVersionColumn
			{
				get
				{
					return this.columnPublishVersion;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn LastVersionColumn
			{
				get
				{
					return this.columnLastVersion;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ChartItemTypeColumn
			{
				get
				{
					return this.columnChartItemType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn BindPrintTemplateIDColumn
			{
				get
				{
					return this.columnBindPrintTemplateID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn BindPrintNameColumn
			{
				get
				{
					return this.columnBindPrintName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TemplatePropertyColumn
			{
				get
				{
					return this.columnTemplateProperty;
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
			public ETemplateDataset.SELECTALLByCategoryIDRow this[int index]
			{
				get
				{
					return (ETemplateDataset.SELECTALLByCategoryIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLByCategoryIDDataTable()
			{
				this.TableName = "SELECTALLByCategoryID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLByCategoryIDDataTable(DataTable table)
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
			protected SELECTALLByCategoryIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLByCategoryIDRow(ETemplateDataset.SELECTALLByCategoryIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ETemplateDataset.SELECTALLByCategoryIDRow AddSELECTALLByCategoryIDRow(long ID, string Name, string GUID, string TemplateCategoryID, string Description, long PublishVersion, long LastVersion, string ChartItemType, string BindPrintTemplateID, string BindPrintName, string TemplateProperty)
			{
				ETemplateDataset.SELECTALLByCategoryIDRow sELECTALLByCategoryIDRow = (ETemplateDataset.SELECTALLByCategoryIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					GUID,
					TemplateCategoryID,
					Description,
					PublishVersion,
					LastVersion,
					ChartItemType,
					BindPrintTemplateID,
					BindPrintName,
					TemplateProperty
				};
				sELECTALLByCategoryIDRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLByCategoryIDRow);
				return sELECTALLByCategoryIDRow;
			}

			[DebuggerNonUserCode]
			public ETemplateDataset.SELECTALLByCategoryIDRow FindByID(long ID)
			{
				return (ETemplateDataset.SELECTALLByCategoryIDRow)this.Rows.Find(new object[]
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
				ETemplateDataset.SELECTALLByCategoryIDDataTable sELECTALLByCategoryIDDataTable = (ETemplateDataset.SELECTALLByCategoryIDDataTable)base.Clone();
				sELECTALLByCategoryIDDataTable.InitVars();
				return sELECTALLByCategoryIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ETemplateDataset.SELECTALLByCategoryIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnGUID = base.Columns["GUID"];
				this.columnTemplateCategoryID = base.Columns["TemplateCategoryID"];
				this.columnDescription = base.Columns["Description"];
				this.columnPublishVersion = base.Columns["PublishVersion"];
				this.columnLastVersion = base.Columns["LastVersion"];
				this.columnChartItemType = base.Columns["ChartItemType"];
				this.columnBindPrintTemplateID = base.Columns["BindPrintTemplateID"];
				this.columnBindPrintName = base.Columns["BindPrintName"];
				this.columnTemplateProperty = base.Columns["TemplateProperty"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnGUID = new DataColumn("GUID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGUID);
				this.columnTemplateCategoryID = new DataColumn("TemplateCategoryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateCategoryID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnPublishVersion = new DataColumn("PublishVersion", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnPublishVersion);
				this.columnLastVersion = new DataColumn("LastVersion", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnLastVersion);
				this.columnChartItemType = new DataColumn("ChartItemType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnChartItemType);
				this.columnBindPrintTemplateID = new DataColumn("BindPrintTemplateID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBindPrintTemplateID);
				this.columnBindPrintName = new DataColumn("BindPrintName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBindPrintName);
				this.columnTemplateProperty = new DataColumn("TemplateProperty", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateProperty);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ETemplateDataset.SELECTALLByCategoryIDRow NewSELECTALLByCategoryIDRow()
			{
				return (ETemplateDataset.SELECTALLByCategoryIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ETemplateDataset.SELECTALLByCategoryIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ETemplateDataset.SELECTALLByCategoryIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLByCategoryIDRowChangedEvent != null)
				{
					ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler sELECTALLByCategoryIDRowChangedEvent = this.SELECTALLByCategoryIDRowChangedEvent;
					if (sELECTALLByCategoryIDRowChangedEvent != null)
					{
						sELECTALLByCategoryIDRowChangedEvent(this, new ETemplateDataset.SELECTALLByCategoryIDRowChangeEvent((ETemplateDataset.SELECTALLByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLByCategoryIDRowChangingEvent != null)
				{
					ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler sELECTALLByCategoryIDRowChangingEvent = this.SELECTALLByCategoryIDRowChangingEvent;
					if (sELECTALLByCategoryIDRowChangingEvent != null)
					{
						sELECTALLByCategoryIDRowChangingEvent(this, new ETemplateDataset.SELECTALLByCategoryIDRowChangeEvent((ETemplateDataset.SELECTALLByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLByCategoryIDRowDeletedEvent != null)
				{
					ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler sELECTALLByCategoryIDRowDeletedEvent = this.SELECTALLByCategoryIDRowDeletedEvent;
					if (sELECTALLByCategoryIDRowDeletedEvent != null)
					{
						sELECTALLByCategoryIDRowDeletedEvent(this, new ETemplateDataset.SELECTALLByCategoryIDRowChangeEvent((ETemplateDataset.SELECTALLByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLByCategoryIDRowDeletingEvent != null)
				{
					ETemplateDataset.SELECTALLByCategoryIDRowChangeEventHandler sELECTALLByCategoryIDRowDeletingEvent = this.SELECTALLByCategoryIDRowDeletingEvent;
					if (sELECTALLByCategoryIDRowDeletingEvent != null)
					{
						sELECTALLByCategoryIDRowDeletingEvent(this, new ETemplateDataset.SELECTALLByCategoryIDRowChangeEvent((ETemplateDataset.SELECTALLByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLByCategoryIDRow(ETemplateDataset.SELECTALLByCategoryIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ETemplateDataset eTemplateDataset = new ETemplateDataset();
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
				xmlSchemaAttribute.FixedValue = eTemplateDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLByCategoryIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eTemplateDataset.GetSchemaSerializable();
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
		public class SELECTALLByCategoryIDRow : DataRow
		{
			private ETemplateDataset.SELECTALLByCategoryIDDataTable tableSELECTALLByCategoryID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALLByCategoryID.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GUID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.GUIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"GUID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.GUIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string TemplateCategoryID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.TemplateCategoryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"TemplateCategoryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.TemplateCategoryIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long PublishVersion
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTALLByCategoryID.PublishVersionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"PublishVersion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.PublishVersionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long LastVersion
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTALLByCategoryID.LastVersionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"LastVersion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.LastVersionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ChartItemType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.ChartItemTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"ChartItemType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.ChartItemTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string BindPrintTemplateID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.BindPrintTemplateIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"BindPrintTemplateID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.BindPrintTemplateIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string BindPrintName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.BindPrintNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"BindPrintName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.BindPrintNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string TemplateProperty
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALLByCategoryID.TemplatePropertyColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALLByCategoryID\"中列\"TemplateProperty\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALLByCategoryID.TemplatePropertyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLByCategoryIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALLByCategoryID = (ETemplateDataset.SELECTALLByCategoryIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTALLByCategoryID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGUIDNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.GUIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGUIDNull()
			{
				this[this.tableSELECTALLByCategoryID.GUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTemplateCategoryIDNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.TemplateCategoryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplateCategoryIDNull()
			{
				this[this.tableSELECTALLByCategoryID.TemplateCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTALLByCategoryID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPublishVersionNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.PublishVersionColumn);
			}

			[DebuggerNonUserCode]
			public void SetPublishVersionNull()
			{
				this[this.tableSELECTALLByCategoryID.PublishVersionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLastVersionNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.LastVersionColumn);
			}

			[DebuggerNonUserCode]
			public void SetLastVersionNull()
			{
				this[this.tableSELECTALLByCategoryID.LastVersionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsChartItemTypeNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.ChartItemTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetChartItemTypeNull()
			{
				this[this.tableSELECTALLByCategoryID.ChartItemTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsBindPrintTemplateIDNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.BindPrintTemplateIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetBindPrintTemplateIDNull()
			{
				this[this.tableSELECTALLByCategoryID.BindPrintTemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsBindPrintNameNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.BindPrintNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetBindPrintNameNull()
			{
				this[this.tableSELECTALLByCategoryID.BindPrintNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTemplatePropertyNull()
			{
				return this.IsNull(this.tableSELECTALLByCategoryID.TemplatePropertyColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplatePropertyNull()
			{
				this[this.tableSELECTALLByCategoryID.TemplatePropertyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLByCategoryIDRowChangeEvent : EventArgs
		{
			private ETemplateDataset.SELECTALLByCategoryIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ETemplateDataset.SELECTALLByCategoryIDRow Row
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
			public SELECTALLByCategoryIDRowChangeEvent(ETemplateDataset.SELECTALLByCategoryIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ETemplateDataset.SELECTALLByCategoryIDDataTable tableSELECTALLByCategoryID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ETemplateDataset.SELECTALLByCategoryIDDataTable SELECTALLByCategoryID
		{
			get
			{
				return this.tableSELECTALLByCategoryID;
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
		public ETemplateDataset()
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
		protected ETemplateDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALLByCategoryID"] != null)
				{
					base.Tables.Add(new ETemplateDataset.SELECTALLByCategoryIDDataTable(dataSet.Tables["SELECTALLByCategoryID"]));
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
			ETemplateDataset eTemplateDataset = (ETemplateDataset)base.Clone();
			eTemplateDataset.InitVars();
			eTemplateDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eTemplateDataset;
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
				if (dataSet.Tables["SELECTALLByCategoryID"] != null)
				{
					base.Tables.Add(new ETemplateDataset.SELECTALLByCategoryIDDataTable(dataSet.Tables["SELECTALLByCategoryID"]));
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
			this.tableSELECTALLByCategoryID = (ETemplateDataset.SELECTALLByCategoryIDDataTable)base.Tables["SELECTALLByCategoryID"];
			if (initTable && this.tableSELECTALLByCategoryID != null)
			{
				this.tableSELECTALLByCategoryID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ETemplateDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ETemplateDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALLByCategoryID = new ETemplateDataset.SELECTALLByCategoryIDDataTable();
			base.Tables.Add(this.tableSELECTALLByCategoryID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALLByCategoryID()
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
			ETemplateDataset eTemplateDataset = new ETemplateDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eTemplateDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eTemplateDataset.GetSchemaSerializable();
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
