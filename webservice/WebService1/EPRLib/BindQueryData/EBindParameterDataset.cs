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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EBindParameterDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EBindParameterDataset : DataSet
	{
		public delegate void SelectParameterByQueryIDRowChangeEventHandler(object sender, EBindParameterDataset.SelectParameterByQueryIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectParameterByQueryIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnParameterName;

			private DataColumn columnParameterType;

			private DataColumn columnQueryID;

			private EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowChangingEvent;

			private EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowChangedEvent;

			private EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowDeletingEvent;

			private EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowDeletedEvent;

			public event EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectParameterByQueryIDRowChangingEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Combine(this.SelectParameterByQueryIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectParameterByQueryIDRowChangingEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Remove(this.SelectParameterByQueryIDRowChangingEvent, value);
				}
			}

			public event EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectParameterByQueryIDRowChangedEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Combine(this.SelectParameterByQueryIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectParameterByQueryIDRowChangedEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Remove(this.SelectParameterByQueryIDRowChangedEvent, value);
				}
			}

			public event EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectParameterByQueryIDRowDeletingEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Combine(this.SelectParameterByQueryIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectParameterByQueryIDRowDeletingEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Remove(this.SelectParameterByQueryIDRowDeletingEvent, value);
				}
			}

			public event EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler SelectParameterByQueryIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectParameterByQueryIDRowDeletedEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Combine(this.SelectParameterByQueryIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectParameterByQueryIDRowDeletedEvent = (EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler)Delegate.Remove(this.SelectParameterByQueryIDRowDeletedEvent, value);
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
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ParameterNameColumn
			{
				get
				{
					return this.columnParameterName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ParameterTypeColumn
			{
				get
				{
					return this.columnParameterType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn QueryIDColumn
			{
				get
				{
					return this.columnQueryID;
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
			public EBindParameterDataset.SelectParameterByQueryIDRow this[int index]
			{
				get
				{
					return (EBindParameterDataset.SelectParameterByQueryIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectParameterByQueryIDDataTable()
			{
				this.TableName = "SelectParameterByQueryID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectParameterByQueryIDDataTable(DataTable table)
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
			protected SelectParameterByQueryIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectParameterByQueryIDRow(EBindParameterDataset.SelectParameterByQueryIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EBindParameterDataset.SelectParameterByQueryIDRow AddSelectParameterByQueryIDRow(string ID, string Name, string Description, string ParameterName, string ParameterType, string QueryID)
			{
				EBindParameterDataset.SelectParameterByQueryIDRow selectParameterByQueryIDRow = (EBindParameterDataset.SelectParameterByQueryIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					ParameterName,
					ParameterType,
					QueryID
				};
				selectParameterByQueryIDRow.ItemArray = itemArray;
				this.Rows.Add(selectParameterByQueryIDRow);
				return selectParameterByQueryIDRow;
			}

			[DebuggerNonUserCode]
			public EBindParameterDataset.SelectParameterByQueryIDRow FindByID(string ID)
			{
				return (EBindParameterDataset.SelectParameterByQueryIDRow)this.Rows.Find(new object[]
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
				EBindParameterDataset.SelectParameterByQueryIDDataTable selectParameterByQueryIDDataTable = (EBindParameterDataset.SelectParameterByQueryIDDataTable)base.Clone();
				selectParameterByQueryIDDataTable.InitVars();
				return selectParameterByQueryIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EBindParameterDataset.SelectParameterByQueryIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnParameterName = base.Columns["ParameterName"];
				this.columnParameterType = base.Columns["ParameterType"];
				this.columnQueryID = base.Columns["QueryID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnParameterName = new DataColumn("ParameterName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParameterName);
				this.columnParameterType = new DataColumn("ParameterType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParameterType);
				this.columnQueryID = new DataColumn("QueryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnQueryID);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EBindParameterDataset.SelectParameterByQueryIDRow NewSelectParameterByQueryIDRow()
			{
				return (EBindParameterDataset.SelectParameterByQueryIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EBindParameterDataset.SelectParameterByQueryIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EBindParameterDataset.SelectParameterByQueryIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectParameterByQueryIDRowChangedEvent != null)
				{
					EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler selectParameterByQueryIDRowChangedEvent = this.SelectParameterByQueryIDRowChangedEvent;
					if (selectParameterByQueryIDRowChangedEvent != null)
					{
						selectParameterByQueryIDRowChangedEvent(this, new EBindParameterDataset.SelectParameterByQueryIDRowChangeEvent((EBindParameterDataset.SelectParameterByQueryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectParameterByQueryIDRowChangingEvent != null)
				{
					EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler selectParameterByQueryIDRowChangingEvent = this.SelectParameterByQueryIDRowChangingEvent;
					if (selectParameterByQueryIDRowChangingEvent != null)
					{
						selectParameterByQueryIDRowChangingEvent(this, new EBindParameterDataset.SelectParameterByQueryIDRowChangeEvent((EBindParameterDataset.SelectParameterByQueryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectParameterByQueryIDRowDeletedEvent != null)
				{
					EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler selectParameterByQueryIDRowDeletedEvent = this.SelectParameterByQueryIDRowDeletedEvent;
					if (selectParameterByQueryIDRowDeletedEvent != null)
					{
						selectParameterByQueryIDRowDeletedEvent(this, new EBindParameterDataset.SelectParameterByQueryIDRowChangeEvent((EBindParameterDataset.SelectParameterByQueryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectParameterByQueryIDRowDeletingEvent != null)
				{
					EBindParameterDataset.SelectParameterByQueryIDRowChangeEventHandler selectParameterByQueryIDRowDeletingEvent = this.SelectParameterByQueryIDRowDeletingEvent;
					if (selectParameterByQueryIDRowDeletingEvent != null)
					{
						selectParameterByQueryIDRowDeletingEvent(this, new EBindParameterDataset.SelectParameterByQueryIDRowChangeEvent((EBindParameterDataset.SelectParameterByQueryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectParameterByQueryIDRow(EBindParameterDataset.SelectParameterByQueryIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EBindParameterDataset eBindParameterDataset = new EBindParameterDataset();
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
				xmlSchemaAttribute.FixedValue = eBindParameterDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectParameterByQueryIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eBindParameterDataset.GetSchemaSerializable();
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
		public class SelectParameterByQueryIDRow : DataRow
		{
			private EBindParameterDataset.SelectParameterByQueryIDDataTable tableSelectParameterByQueryID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableSelectParameterByQueryID.IDColumn]);
				}
				set
				{
					this[this.tableSelectParameterByQueryID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectParameterByQueryID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectParameterByQueryID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectParameterByQueryID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectParameterByQueryID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectParameterByQueryID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectParameterByQueryID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ParameterName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectParameterByQueryID.ParameterNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectParameterByQueryID\"中列\"ParameterName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectParameterByQueryID.ParameterNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ParameterType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectParameterByQueryID.ParameterTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectParameterByQueryID\"中列\"ParameterType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectParameterByQueryID.ParameterTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string QueryID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectParameterByQueryID.QueryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectParameterByQueryID\"中列\"QueryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectParameterByQueryID.QueryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectParameterByQueryIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectParameterByQueryID = (EBindParameterDataset.SelectParameterByQueryIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectParameterByQueryID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectParameterByQueryID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectParameterByQueryID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectParameterByQueryID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParameterNameNull()
			{
				return this.IsNull(this.tableSelectParameterByQueryID.ParameterNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetParameterNameNull()
			{
				this[this.tableSelectParameterByQueryID.ParameterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParameterTypeNull()
			{
				return this.IsNull(this.tableSelectParameterByQueryID.ParameterTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetParameterTypeNull()
			{
				this[this.tableSelectParameterByQueryID.ParameterTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsQueryIDNull()
			{
				return this.IsNull(this.tableSelectParameterByQueryID.QueryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetQueryIDNull()
			{
				this[this.tableSelectParameterByQueryID.QueryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectParameterByQueryIDRowChangeEvent : EventArgs
		{
			private EBindParameterDataset.SelectParameterByQueryIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EBindParameterDataset.SelectParameterByQueryIDRow Row
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
			public SelectParameterByQueryIDRowChangeEvent(EBindParameterDataset.SelectParameterByQueryIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EBindParameterDataset.SelectParameterByQueryIDDataTable tableSelectParameterByQueryID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EBindParameterDataset.SelectParameterByQueryIDDataTable SelectParameterByQueryID
		{
			get
			{
				return this.tableSelectParameterByQueryID;
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
		public EBindParameterDataset()
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
		protected EBindParameterDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectParameterByQueryID"] != null)
				{
					base.Tables.Add(new EBindParameterDataset.SelectParameterByQueryIDDataTable(dataSet.Tables["SelectParameterByQueryID"]));
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
			EBindParameterDataset eBindParameterDataset = (EBindParameterDataset)base.Clone();
			eBindParameterDataset.InitVars();
			eBindParameterDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eBindParameterDataset;
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
				if (dataSet.Tables["SelectParameterByQueryID"] != null)
				{
					base.Tables.Add(new EBindParameterDataset.SelectParameterByQueryIDDataTable(dataSet.Tables["SelectParameterByQueryID"]));
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
			this.tableSelectParameterByQueryID = (EBindParameterDataset.SelectParameterByQueryIDDataTable)base.Tables["SelectParameterByQueryID"];
			if (initTable && this.tableSelectParameterByQueryID != null)
			{
				this.tableSelectParameterByQueryID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EBindParameterDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EBindParaneterDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectParameterByQueryID = new EBindParameterDataset.SelectParameterByQueryIDDataTable();
			base.Tables.Add(this.tableSelectParameterByQueryID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectParameterByQueryID()
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
			EBindParameterDataset eBindParameterDataset = new EBindParameterDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eBindParameterDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eBindParameterDataset.GetSchemaSerializable();
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
