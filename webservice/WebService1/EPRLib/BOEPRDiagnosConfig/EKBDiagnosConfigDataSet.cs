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

namespace BOEPRDiagnosConfig
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBDiagnosConfigDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBDiagnosConfigDataSet : DataSet
	{
		public delegate void QueryDateByTreeIDRowChangeEventHandler(object sender, EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class QueryDateByTreeIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnKBNodeID;

			private EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowChangingEvent;

			private EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowChangedEvent;

			private EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowDeletingEvent;

			private EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowDeletedEvent;

			public event EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.QueryDateByTreeIDRowChangingEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Combine(this.QueryDateByTreeIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.QueryDateByTreeIDRowChangingEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Remove(this.QueryDateByTreeIDRowChangingEvent, value);
				}
			}

			public event EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.QueryDateByTreeIDRowChangedEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Combine(this.QueryDateByTreeIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.QueryDateByTreeIDRowChangedEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Remove(this.QueryDateByTreeIDRowChangedEvent, value);
				}
			}

			public event EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.QueryDateByTreeIDRowDeletingEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Combine(this.QueryDateByTreeIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.QueryDateByTreeIDRowDeletingEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Remove(this.QueryDateByTreeIDRowDeletingEvent, value);
				}
			}

			public event EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler QueryDateByTreeIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.QueryDateByTreeIDRowDeletedEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Combine(this.QueryDateByTreeIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.QueryDateByTreeIDRowDeletedEvent = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler)Delegate.Remove(this.QueryDateByTreeIDRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn KBNodeIDColumn
			{
				get
				{
					return this.columnKBNodeID;
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
			public EKBDiagnosConfigDataSet.QueryDateByTreeIDRow this[int index]
			{
				get
				{
					return (EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public QueryDateByTreeIDDataTable()
			{
				this.TableName = "QueryDateByTreeID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal QueryDateByTreeIDDataTable(DataTable table)
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
			protected QueryDateByTreeIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddQueryDateByTreeIDRow(EKBDiagnosConfigDataSet.QueryDateByTreeIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBDiagnosConfigDataSet.QueryDateByTreeIDRow AddQueryDateByTreeIDRow(string KBNodeID)
			{
				EKBDiagnosConfigDataSet.QueryDateByTreeIDRow queryDateByTreeIDRow = (EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					KBNodeID
				};
				queryDateByTreeIDRow.ItemArray = itemArray;
				this.Rows.Add(queryDateByTreeIDRow);
				return queryDateByTreeIDRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable queryDateByTreeIDDataTable = (EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable)base.Clone();
				queryDateByTreeIDDataTable.InitVars();
				return queryDateByTreeIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnKBNodeID = base.Columns["KBNodeID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnKBNodeID = new DataColumn("KBNodeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKBNodeID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBDiagnosConfigDataSet.QueryDateByTreeIDRow NewQueryDateByTreeIDRow()
			{
				return (EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBDiagnosConfigDataSet.QueryDateByTreeIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBDiagnosConfigDataSet.QueryDateByTreeIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.QueryDateByTreeIDRowChangedEvent != null)
				{
					EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler queryDateByTreeIDRowChangedEvent = this.QueryDateByTreeIDRowChangedEvent;
					if (queryDateByTreeIDRowChangedEvent != null)
					{
						queryDateByTreeIDRowChangedEvent(this, new EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEvent((EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.QueryDateByTreeIDRowChangingEvent != null)
				{
					EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler queryDateByTreeIDRowChangingEvent = this.QueryDateByTreeIDRowChangingEvent;
					if (queryDateByTreeIDRowChangingEvent != null)
					{
						queryDateByTreeIDRowChangingEvent(this, new EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEvent((EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.QueryDateByTreeIDRowDeletedEvent != null)
				{
					EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler queryDateByTreeIDRowDeletedEvent = this.QueryDateByTreeIDRowDeletedEvent;
					if (queryDateByTreeIDRowDeletedEvent != null)
					{
						queryDateByTreeIDRowDeletedEvent(this, new EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEvent((EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.QueryDateByTreeIDRowDeletingEvent != null)
				{
					EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEventHandler queryDateByTreeIDRowDeletingEvent = this.QueryDateByTreeIDRowDeletingEvent;
					if (queryDateByTreeIDRowDeletingEvent != null)
					{
						queryDateByTreeIDRowDeletingEvent(this, new EKBDiagnosConfigDataSet.QueryDateByTreeIDRowChangeEvent((EKBDiagnosConfigDataSet.QueryDateByTreeIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveQueryDateByTreeIDRow(EKBDiagnosConfigDataSet.QueryDateByTreeIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBDiagnosConfigDataSet eKBDiagnosConfigDataSet = new EKBDiagnosConfigDataSet();
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
				xmlSchemaAttribute.FixedValue = eKBDiagnosConfigDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "QueryDateByTreeIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBDiagnosConfigDataSet.GetSchemaSerializable();
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
		public class QueryDateByTreeIDRow : DataRow
		{
			private EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable tableQueryDateByTreeID;

			[DebuggerNonUserCode]
			public string KBNodeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableQueryDateByTreeID.KBNodeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"QueryDateByTreeID\"中列\"KBNodeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableQueryDateByTreeID.KBNodeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal QueryDateByTreeIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableQueryDateByTreeID = (EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsKBNodeIDNull()
			{
				return this.IsNull(this.tableQueryDateByTreeID.KBNodeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBNodeIDNull()
			{
				this[this.tableQueryDateByTreeID.KBNodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class QueryDateByTreeIDRowChangeEvent : EventArgs
		{
			private EKBDiagnosConfigDataSet.QueryDateByTreeIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBDiagnosConfigDataSet.QueryDateByTreeIDRow Row
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
			public QueryDateByTreeIDRowChangeEvent(EKBDiagnosConfigDataSet.QueryDateByTreeIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable tableQueryDateByTreeID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable QueryDateByTreeID
		{
			get
			{
				return this.tableQueryDateByTreeID;
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
		public EKBDiagnosConfigDataSet()
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
		protected EKBDiagnosConfigDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["QueryDateByTreeID"] != null)
				{
					base.Tables.Add(new EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable(dataSet.Tables["QueryDateByTreeID"]));
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
			EKBDiagnosConfigDataSet eKBDiagnosConfigDataSet = (EKBDiagnosConfigDataSet)base.Clone();
			eKBDiagnosConfigDataSet.InitVars();
			eKBDiagnosConfigDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBDiagnosConfigDataSet;
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
				if (dataSet.Tables["QueryDateByTreeID"] != null)
				{
					base.Tables.Add(new EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable(dataSet.Tables["QueryDateByTreeID"]));
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
			this.tableQueryDateByTreeID = (EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable)base.Tables["QueryDateByTreeID"];
			if (initTable && this.tableQueryDateByTreeID != null)
			{
				this.tableQueryDateByTreeID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBDiagnosConfigDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBDiagnosConfigDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableQueryDateByTreeID = new EKBDiagnosConfigDataSet.QueryDateByTreeIDDataTable();
			base.Tables.Add(this.tableQueryDateByTreeID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeQueryDateByTreeID()
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
			EKBDiagnosConfigDataSet eKBDiagnosConfigDataSet = new EKBDiagnosConfigDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBDiagnosConfigDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBDiagnosConfigDataSet.GetSchemaSerializable();
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
