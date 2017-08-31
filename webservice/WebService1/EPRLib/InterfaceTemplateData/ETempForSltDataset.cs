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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ETempForSltDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ETempForSltDataset : DataSet
	{
		public delegate void SelectForSltByCIdRowChangeEventHandler(object sender, ETempForSltDataset.SelectForSltByCIdRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectForSltByCIdDataTable : DataTable, IEnumerable
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

			private ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowChangingEvent;

			private ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowChangedEvent;

			private ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowDeletingEvent;

			private ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowDeletedEvent;

			public event ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectForSltByCIdRowChangingEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Combine(this.SelectForSltByCIdRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectForSltByCIdRowChangingEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Remove(this.SelectForSltByCIdRowChangingEvent, value);
				}
			}

			public event ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectForSltByCIdRowChangedEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Combine(this.SelectForSltByCIdRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectForSltByCIdRowChangedEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Remove(this.SelectForSltByCIdRowChangedEvent, value);
				}
			}

			public event ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectForSltByCIdRowDeletingEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Combine(this.SelectForSltByCIdRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectForSltByCIdRowDeletingEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Remove(this.SelectForSltByCIdRowDeletingEvent, value);
				}
			}

			public event ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler SelectForSltByCIdRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectForSltByCIdRowDeletedEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Combine(this.SelectForSltByCIdRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectForSltByCIdRowDeletedEvent = (ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler)Delegate.Remove(this.SelectForSltByCIdRowDeletedEvent, value);
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
			public ETempForSltDataset.SelectForSltByCIdRow this[int index]
			{
				get
				{
					return (ETempForSltDataset.SelectForSltByCIdRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectForSltByCIdDataTable()
			{
				this.TableName = "SelectForSltByCId";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectForSltByCIdDataTable(DataTable table)
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
			protected SelectForSltByCIdDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectForSltByCIdRow(ETempForSltDataset.SelectForSltByCIdRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ETempForSltDataset.SelectForSltByCIdRow AddSelectForSltByCIdRow(string ID, string Name, string GUID, string TemplateCategoryID, string Description, string PublishVersion, string LastVersion, string ChartItemType, string BindPrintTemplateID, string BindPrintName, string TemplateProperty)
			{
				ETempForSltDataset.SelectForSltByCIdRow selectForSltByCIdRow = (ETempForSltDataset.SelectForSltByCIdRow)this.NewRow();
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
				selectForSltByCIdRow.ItemArray = itemArray;
				this.Rows.Add(selectForSltByCIdRow);
				return selectForSltByCIdRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ETempForSltDataset.SelectForSltByCIdDataTable selectForSltByCIdDataTable = (ETempForSltDataset.SelectForSltByCIdDataTable)base.Clone();
				selectForSltByCIdDataTable.InitVars();
				return selectForSltByCIdDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ETempForSltDataset.SelectForSltByCIdDataTable();
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
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnGUID = new DataColumn("GUID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGUID);
				this.columnTemplateCategoryID = new DataColumn("TemplateCategoryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateCategoryID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnPublishVersion = new DataColumn("PublishVersion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPublishVersion);
				this.columnLastVersion = new DataColumn("LastVersion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLastVersion);
				this.columnChartItemType = new DataColumn("ChartItemType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnChartItemType);
				this.columnBindPrintTemplateID = new DataColumn("BindPrintTemplateID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBindPrintTemplateID);
				this.columnBindPrintName = new DataColumn("BindPrintName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBindPrintName);
				this.columnTemplateProperty = new DataColumn("TemplateProperty", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateProperty);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ETempForSltDataset.SelectForSltByCIdRow NewSelectForSltByCIdRow()
			{
				return (ETempForSltDataset.SelectForSltByCIdRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ETempForSltDataset.SelectForSltByCIdRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ETempForSltDataset.SelectForSltByCIdRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectForSltByCIdRowChangedEvent != null)
				{
					ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler selectForSltByCIdRowChangedEvent = this.SelectForSltByCIdRowChangedEvent;
					if (selectForSltByCIdRowChangedEvent != null)
					{
						selectForSltByCIdRowChangedEvent(this, new ETempForSltDataset.SelectForSltByCIdRowChangeEvent((ETempForSltDataset.SelectForSltByCIdRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectForSltByCIdRowChangingEvent != null)
				{
					ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler selectForSltByCIdRowChangingEvent = this.SelectForSltByCIdRowChangingEvent;
					if (selectForSltByCIdRowChangingEvent != null)
					{
						selectForSltByCIdRowChangingEvent(this, new ETempForSltDataset.SelectForSltByCIdRowChangeEvent((ETempForSltDataset.SelectForSltByCIdRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectForSltByCIdRowDeletedEvent != null)
				{
					ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler selectForSltByCIdRowDeletedEvent = this.SelectForSltByCIdRowDeletedEvent;
					if (selectForSltByCIdRowDeletedEvent != null)
					{
						selectForSltByCIdRowDeletedEvent(this, new ETempForSltDataset.SelectForSltByCIdRowChangeEvent((ETempForSltDataset.SelectForSltByCIdRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectForSltByCIdRowDeletingEvent != null)
				{
					ETempForSltDataset.SelectForSltByCIdRowChangeEventHandler selectForSltByCIdRowDeletingEvent = this.SelectForSltByCIdRowDeletingEvent;
					if (selectForSltByCIdRowDeletingEvent != null)
					{
						selectForSltByCIdRowDeletingEvent(this, new ETempForSltDataset.SelectForSltByCIdRowChangeEvent((ETempForSltDataset.SelectForSltByCIdRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectForSltByCIdRow(ETempForSltDataset.SelectForSltByCIdRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ETempForSltDataset eTempForSltDataset = new ETempForSltDataset();
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
				xmlSchemaAttribute.FixedValue = eTempForSltDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectForSltByCIdDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eTempForSltDataset.GetSchemaSerializable();
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
		public class SelectForSltByCIdRow : DataRow
		{
			private ETempForSltDataset.SelectForSltByCIdDataTable tableSelectForSltByCId;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectForSltByCId.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.GUIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"GUID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.GUIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.TemplateCategoryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"TemplateCategoryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.TemplateCategoryIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string PublishVersion
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectForSltByCId.PublishVersionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"PublishVersion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.PublishVersionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string LastVersion
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectForSltByCId.LastVersionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"LastVersion\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.LastVersionColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.ChartItemTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"ChartItemType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.ChartItemTypeColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.BindPrintTemplateIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"BindPrintTemplateID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.BindPrintTemplateIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.BindPrintNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"BindPrintName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.BindPrintNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectForSltByCId.TemplatePropertyColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectForSltByCId\"中列\"TemplateProperty\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectForSltByCId.TemplatePropertyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectForSltByCIdRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectForSltByCId = (ETempForSltDataset.SelectForSltByCIdDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableSelectForSltByCId.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectForSltByCId.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGUIDNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.GUIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGUIDNull()
			{
				this[this.tableSelectForSltByCId.GUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTemplateCategoryIDNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.TemplateCategoryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplateCategoryIDNull()
			{
				this[this.tableSelectForSltByCId.TemplateCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectForSltByCId.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsPublishVersionNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.PublishVersionColumn);
			}

			[DebuggerNonUserCode]
			public void SetPublishVersionNull()
			{
				this[this.tableSelectForSltByCId.PublishVersionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsLastVersionNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.LastVersionColumn);
			}

			[DebuggerNonUserCode]
			public void SetLastVersionNull()
			{
				this[this.tableSelectForSltByCId.LastVersionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsChartItemTypeNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.ChartItemTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetChartItemTypeNull()
			{
				this[this.tableSelectForSltByCId.ChartItemTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsBindPrintTemplateIDNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.BindPrintTemplateIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetBindPrintTemplateIDNull()
			{
				this[this.tableSelectForSltByCId.BindPrintTemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsBindPrintNameNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.BindPrintNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetBindPrintNameNull()
			{
				this[this.tableSelectForSltByCId.BindPrintNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTemplatePropertyNull()
			{
				return this.IsNull(this.tableSelectForSltByCId.TemplatePropertyColumn);
			}

			[DebuggerNonUserCode]
			public void SetTemplatePropertyNull()
			{
				this[this.tableSelectForSltByCId.TemplatePropertyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectForSltByCIdRowChangeEvent : EventArgs
		{
			private ETempForSltDataset.SelectForSltByCIdRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ETempForSltDataset.SelectForSltByCIdRow Row
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
			public SelectForSltByCIdRowChangeEvent(ETempForSltDataset.SelectForSltByCIdRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ETempForSltDataset.SelectForSltByCIdDataTable tableSelectForSltByCId;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ETempForSltDataset.SelectForSltByCIdDataTable SelectForSltByCId
		{
			get
			{
				return this.tableSelectForSltByCId;
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
		public ETempForSltDataset()
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
		protected ETempForSltDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectForSltByCId"] != null)
				{
					base.Tables.Add(new ETempForSltDataset.SelectForSltByCIdDataTable(dataSet.Tables["SelectForSltByCId"]));
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
			ETempForSltDataset eTempForSltDataset = (ETempForSltDataset)base.Clone();
			eTempForSltDataset.InitVars();
			eTempForSltDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eTempForSltDataset;
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
				if (dataSet.Tables["SelectForSltByCId"] != null)
				{
					base.Tables.Add(new ETempForSltDataset.SelectForSltByCIdDataTable(dataSet.Tables["SelectForSltByCId"]));
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
			this.tableSelectForSltByCId = (ETempForSltDataset.SelectForSltByCIdDataTable)base.Tables["SelectForSltByCId"];
			if (initTable && this.tableSelectForSltByCId != null)
			{
				this.tableSelectForSltByCId.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ETempForSltDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ETempForSltDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectForSltByCId = new ETempForSltDataset.SelectForSltByCIdDataTable();
			base.Tables.Add(this.tableSelectForSltByCId);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectForSltByCId()
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
			ETempForSltDataset eTempForSltDataset = new ETempForSltDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eTempForSltDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eTempForSltDataset.GetSchemaSerializable();
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
