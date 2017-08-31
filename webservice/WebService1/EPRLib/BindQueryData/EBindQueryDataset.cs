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

namespace BindQueryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EBindQueryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EBindQueryDataset : DataSet
	{
		public delegate void SelectAllQueryRowChangeEventHandler(object sender, EBindQueryDataset.SelectAllQueryRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectAllQueryDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnClassName;

			private DataColumn columnQueryName;

			private DataColumn columnDescription;

			private DataColumn columnSingleResult;

			private EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowChangingEvent;

			private EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowChangedEvent;

			private EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowDeletingEvent;

			private EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowDeletedEvent;

			public event EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllQueryRowChangingEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Combine(this.SelectAllQueryRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllQueryRowChangingEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Remove(this.SelectAllQueryRowChangingEvent, value);
				}
			}

			public event EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllQueryRowChangedEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Combine(this.SelectAllQueryRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllQueryRowChangedEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Remove(this.SelectAllQueryRowChangedEvent, value);
				}
			}

			public event EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllQueryRowDeletingEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Combine(this.SelectAllQueryRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllQueryRowDeletingEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Remove(this.SelectAllQueryRowDeletingEvent, value);
				}
			}

			public event EBindQueryDataset.SelectAllQueryRowChangeEventHandler SelectAllQueryRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllQueryRowDeletedEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Combine(this.SelectAllQueryRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllQueryRowDeletedEvent = (EBindQueryDataset.SelectAllQueryRowChangeEventHandler)Delegate.Remove(this.SelectAllQueryRowDeletedEvent, value);
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
			public DataColumn ClassNameColumn
			{
				get
				{
					return this.columnClassName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn QueryNameColumn
			{
				get
				{
					return this.columnQueryName;
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
			public DataColumn SingleResultColumn
			{
				get
				{
					return this.columnSingleResult;
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
			public EBindQueryDataset.SelectAllQueryRow this[int index]
			{
				get
				{
					return (EBindQueryDataset.SelectAllQueryRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectAllQueryDataTable()
			{
				this.TableName = "SelectAllQuery";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectAllQueryDataTable(DataTable table)
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
			protected SelectAllQueryDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectAllQueryRow(EBindQueryDataset.SelectAllQueryRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EBindQueryDataset.SelectAllQueryRow AddSelectAllQueryRow(string ID, string Name, string ClassName, string QueryName, string Description, string SingleResult)
			{
				EBindQueryDataset.SelectAllQueryRow selectAllQueryRow = (EBindQueryDataset.SelectAllQueryRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					ClassName,
					QueryName,
					Description,
					SingleResult
				};
				selectAllQueryRow.ItemArray = itemArray;
				this.Rows.Add(selectAllQueryRow);
				return selectAllQueryRow;
			}

			[DebuggerNonUserCode]
			public EBindQueryDataset.SelectAllQueryRow FindByID(string ID)
			{
				return (EBindQueryDataset.SelectAllQueryRow)this.Rows.Find(new object[]
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
				EBindQueryDataset.SelectAllQueryDataTable selectAllQueryDataTable = (EBindQueryDataset.SelectAllQueryDataTable)base.Clone();
				selectAllQueryDataTable.InitVars();
				return selectAllQueryDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EBindQueryDataset.SelectAllQueryDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnClassName = base.Columns["ClassName"];
				this.columnQueryName = base.Columns["QueryName"];
				this.columnDescription = base.Columns["Description"];
				this.columnSingleResult = base.Columns["SingleResult"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnClassName = new DataColumn("ClassName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnClassName);
				this.columnQueryName = new DataColumn("QueryName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnQueryName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnSingleResult = new DataColumn("SingleResult", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSingleResult);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EBindQueryDataset.SelectAllQueryRow NewSelectAllQueryRow()
			{
				return (EBindQueryDataset.SelectAllQueryRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EBindQueryDataset.SelectAllQueryRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EBindQueryDataset.SelectAllQueryRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectAllQueryRowChangedEvent != null)
				{
					EBindQueryDataset.SelectAllQueryRowChangeEventHandler selectAllQueryRowChangedEvent = this.SelectAllQueryRowChangedEvent;
					if (selectAllQueryRowChangedEvent != null)
					{
						selectAllQueryRowChangedEvent(this, new EBindQueryDataset.SelectAllQueryRowChangeEvent((EBindQueryDataset.SelectAllQueryRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectAllQueryRowChangingEvent != null)
				{
					EBindQueryDataset.SelectAllQueryRowChangeEventHandler selectAllQueryRowChangingEvent = this.SelectAllQueryRowChangingEvent;
					if (selectAllQueryRowChangingEvent != null)
					{
						selectAllQueryRowChangingEvent(this, new EBindQueryDataset.SelectAllQueryRowChangeEvent((EBindQueryDataset.SelectAllQueryRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectAllQueryRowDeletedEvent != null)
				{
					EBindQueryDataset.SelectAllQueryRowChangeEventHandler selectAllQueryRowDeletedEvent = this.SelectAllQueryRowDeletedEvent;
					if (selectAllQueryRowDeletedEvent != null)
					{
						selectAllQueryRowDeletedEvent(this, new EBindQueryDataset.SelectAllQueryRowChangeEvent((EBindQueryDataset.SelectAllQueryRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectAllQueryRowDeletingEvent != null)
				{
					EBindQueryDataset.SelectAllQueryRowChangeEventHandler selectAllQueryRowDeletingEvent = this.SelectAllQueryRowDeletingEvent;
					if (selectAllQueryRowDeletingEvent != null)
					{
						selectAllQueryRowDeletingEvent(this, new EBindQueryDataset.SelectAllQueryRowChangeEvent((EBindQueryDataset.SelectAllQueryRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectAllQueryRow(EBindQueryDataset.SelectAllQueryRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EBindQueryDataset eBindQueryDataset = new EBindQueryDataset();
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
				xmlSchemaAttribute.FixedValue = eBindQueryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectAllQueryDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eBindQueryDataset.GetSchemaSerializable();
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
		public class SelectAllQueryRow : DataRow
		{
			private EBindQueryDataset.SelectAllQueryDataTable tableSelectAllQuery;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableSelectAllQuery.IDColumn]);
				}
				set
				{
					this[this.tableSelectAllQuery.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectAllQuery.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllQuery\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllQuery.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ClassName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllQuery.ClassNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllQuery\"中列\"ClassName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllQuery.ClassNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string QueryName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllQuery.QueryNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllQuery\"中列\"QueryName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllQuery.QueryNameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectAllQuery.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllQuery\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllQuery.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string SingleResult
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllQuery.SingleResultColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllQuery\"中列\"SingleResult\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllQuery.SingleResultColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectAllQueryRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectAllQuery = (EBindQueryDataset.SelectAllQueryDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectAllQuery.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectAllQuery.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsClassNameNull()
			{
				return this.IsNull(this.tableSelectAllQuery.ClassNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetClassNameNull()
			{
				this[this.tableSelectAllQuery.ClassNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsQueryNameNull()
			{
				return this.IsNull(this.tableSelectAllQuery.QueryNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetQueryNameNull()
			{
				this[this.tableSelectAllQuery.QueryNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectAllQuery.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectAllQuery.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSingleResultNull()
			{
				return this.IsNull(this.tableSelectAllQuery.SingleResultColumn);
			}

			[DebuggerNonUserCode]
			public void SetSingleResultNull()
			{
				this[this.tableSelectAllQuery.SingleResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectAllQueryRowChangeEvent : EventArgs
		{
			private EBindQueryDataset.SelectAllQueryRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EBindQueryDataset.SelectAllQueryRow Row
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
			public SelectAllQueryRowChangeEvent(EBindQueryDataset.SelectAllQueryRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EBindQueryDataset.SelectAllQueryDataTable tableSelectAllQuery;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EBindQueryDataset.SelectAllQueryDataTable SelectAllQuery
		{
			get
			{
				return this.tableSelectAllQuery;
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
		public EBindQueryDataset()
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
		protected EBindQueryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectAllQuery"] != null)
				{
					base.Tables.Add(new EBindQueryDataset.SelectAllQueryDataTable(dataSet.Tables["SelectAllQuery"]));
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
			EBindQueryDataset eBindQueryDataset = (EBindQueryDataset)base.Clone();
			eBindQueryDataset.InitVars();
			eBindQueryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eBindQueryDataset;
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
				if (dataSet.Tables["SelectAllQuery"] != null)
				{
					base.Tables.Add(new EBindQueryDataset.SelectAllQueryDataTable(dataSet.Tables["SelectAllQuery"]));
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
			this.tableSelectAllQuery = (EBindQueryDataset.SelectAllQueryDataTable)base.Tables["SelectAllQuery"];
			if (initTable && this.tableSelectAllQuery != null)
			{
				this.tableSelectAllQuery.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EBindQueryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EBindQueryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectAllQuery = new EBindQueryDataset.SelectAllQueryDataTable();
			base.Tables.Add(this.tableSelectAllQuery);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectAllQuery()
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
			EBindQueryDataset eBindQueryDataset = new EBindQueryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eBindQueryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eBindQueryDataset.GetSchemaSerializable();
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
