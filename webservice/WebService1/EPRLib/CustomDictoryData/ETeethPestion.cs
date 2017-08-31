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

namespace CustomDictoryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ETeethPestion"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ETeethPestion : DataSet
	{
		public delegate void GetTeethInformationRowChangeEventHandler(object sender, ETeethPestion.GetTeethInformationRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetTeethInformationDataTable : DataTable, IEnumerable
		{
			private DataColumn columnCtmDictCode;

			private DataColumn columnCtmDictAlias;

			private DataColumn columnCtmDictDesc;

			private ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowChangingEvent;

			private ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowChangedEvent;

			private ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowDeletingEvent;

			private ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowDeletedEvent;

			public event ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetTeethInformationRowChangingEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Combine(this.GetTeethInformationRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetTeethInformationRowChangingEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Remove(this.GetTeethInformationRowChangingEvent, value);
				}
			}

			public event ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetTeethInformationRowChangedEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Combine(this.GetTeethInformationRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetTeethInformationRowChangedEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Remove(this.GetTeethInformationRowChangedEvent, value);
				}
			}

			public event ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetTeethInformationRowDeletingEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Combine(this.GetTeethInformationRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetTeethInformationRowDeletingEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Remove(this.GetTeethInformationRowDeletingEvent, value);
				}
			}

			public event ETeethPestion.GetTeethInformationRowChangeEventHandler GetTeethInformationRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetTeethInformationRowDeletedEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Combine(this.GetTeethInformationRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetTeethInformationRowDeletedEvent = (ETeethPestion.GetTeethInformationRowChangeEventHandler)Delegate.Remove(this.GetTeethInformationRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CtmDictCodeColumn
			{
				get
				{
					return this.columnCtmDictCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CtmDictAliasColumn
			{
				get
				{
					return this.columnCtmDictAlias;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CtmDictDescColumn
			{
				get
				{
					return this.columnCtmDictDesc;
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
			public ETeethPestion.GetTeethInformationRow this[int index]
			{
				get
				{
					return (ETeethPestion.GetTeethInformationRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetTeethInformationDataTable()
			{
				this.TableName = "GetTeethInformation";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetTeethInformationDataTable(DataTable table)
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
			protected GetTeethInformationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetTeethInformationRow(ETeethPestion.GetTeethInformationRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ETeethPestion.GetTeethInformationRow AddGetTeethInformationRow(string CtmDictCode, string CtmDictAlias, string CtmDictDesc)
			{
				ETeethPestion.GetTeethInformationRow getTeethInformationRow = (ETeethPestion.GetTeethInformationRow)this.NewRow();
				object[] itemArray = new object[]
				{
					CtmDictCode,
					CtmDictAlias,
					CtmDictDesc
				};
				getTeethInformationRow.ItemArray = itemArray;
				this.Rows.Add(getTeethInformationRow);
				return getTeethInformationRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ETeethPestion.GetTeethInformationDataTable getTeethInformationDataTable = (ETeethPestion.GetTeethInformationDataTable)base.Clone();
				getTeethInformationDataTable.InitVars();
				return getTeethInformationDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ETeethPestion.GetTeethInformationDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCtmDictCode = base.Columns["CtmDictCode"];
				this.columnCtmDictAlias = base.Columns["CtmDictAlias"];
				this.columnCtmDictDesc = base.Columns["CtmDictDesc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCtmDictCode = new DataColumn("CtmDictCode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCtmDictCode);
				this.columnCtmDictAlias = new DataColumn("CtmDictAlias", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCtmDictAlias);
				this.columnCtmDictDesc = new DataColumn("CtmDictDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCtmDictDesc);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ETeethPestion.GetTeethInformationRow NewGetTeethInformationRow()
			{
				return (ETeethPestion.GetTeethInformationRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ETeethPestion.GetTeethInformationRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ETeethPestion.GetTeethInformationRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetTeethInformationRowChangedEvent != null)
				{
					ETeethPestion.GetTeethInformationRowChangeEventHandler getTeethInformationRowChangedEvent = this.GetTeethInformationRowChangedEvent;
					if (getTeethInformationRowChangedEvent != null)
					{
						getTeethInformationRowChangedEvent(this, new ETeethPestion.GetTeethInformationRowChangeEvent((ETeethPestion.GetTeethInformationRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetTeethInformationRowChangingEvent != null)
				{
					ETeethPestion.GetTeethInformationRowChangeEventHandler getTeethInformationRowChangingEvent = this.GetTeethInformationRowChangingEvent;
					if (getTeethInformationRowChangingEvent != null)
					{
						getTeethInformationRowChangingEvent(this, new ETeethPestion.GetTeethInformationRowChangeEvent((ETeethPestion.GetTeethInformationRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetTeethInformationRowDeletedEvent != null)
				{
					ETeethPestion.GetTeethInformationRowChangeEventHandler getTeethInformationRowDeletedEvent = this.GetTeethInformationRowDeletedEvent;
					if (getTeethInformationRowDeletedEvent != null)
					{
						getTeethInformationRowDeletedEvent(this, new ETeethPestion.GetTeethInformationRowChangeEvent((ETeethPestion.GetTeethInformationRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetTeethInformationRowDeletingEvent != null)
				{
					ETeethPestion.GetTeethInformationRowChangeEventHandler getTeethInformationRowDeletingEvent = this.GetTeethInformationRowDeletingEvent;
					if (getTeethInformationRowDeletingEvent != null)
					{
						getTeethInformationRowDeletingEvent(this, new ETeethPestion.GetTeethInformationRowChangeEvent((ETeethPestion.GetTeethInformationRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetTeethInformationRow(ETeethPestion.GetTeethInformationRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ETeethPestion eTeethPestion = new ETeethPestion();
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
				xmlSchemaAttribute.FixedValue = eTeethPestion.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetTeethInformationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eTeethPestion.GetSchemaSerializable();
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
		public class GetTeethInformationRow : DataRow
		{
			private ETeethPestion.GetTeethInformationDataTable tableGetTeethInformation;

			[DebuggerNonUserCode]
			public string CtmDictCode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetTeethInformation.CtmDictCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetTeethInformation\"中列\"CtmDictCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetTeethInformation.CtmDictCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CtmDictAlias
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetTeethInformation.CtmDictAliasColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetTeethInformation\"中列\"CtmDictAlias\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetTeethInformation.CtmDictAliasColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CtmDictDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetTeethInformation.CtmDictDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetTeethInformation\"中列\"CtmDictDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetTeethInformation.CtmDictDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetTeethInformationRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetTeethInformation = (ETeethPestion.GetTeethInformationDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCtmDictCodeNull()
			{
				return this.IsNull(this.tableGetTeethInformation.CtmDictCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCtmDictCodeNull()
			{
				this[this.tableGetTeethInformation.CtmDictCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCtmDictAliasNull()
			{
				return this.IsNull(this.tableGetTeethInformation.CtmDictAliasColumn);
			}

			[DebuggerNonUserCode]
			public void SetCtmDictAliasNull()
			{
				this[this.tableGetTeethInformation.CtmDictAliasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCtmDictDescNull()
			{
				return this.IsNull(this.tableGetTeethInformation.CtmDictDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetCtmDictDescNull()
			{
				this[this.tableGetTeethInformation.CtmDictDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetTeethInformationRowChangeEvent : EventArgs
		{
			private ETeethPestion.GetTeethInformationRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ETeethPestion.GetTeethInformationRow Row
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
			public GetTeethInformationRowChangeEvent(ETeethPestion.GetTeethInformationRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ETeethPestion.GetTeethInformationDataTable tableGetTeethInformation;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ETeethPestion.GetTeethInformationDataTable GetTeethInformation
		{
			get
			{
				return this.tableGetTeethInformation;
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
		public ETeethPestion()
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
		protected ETeethPestion(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetTeethInformation"] != null)
				{
					base.Tables.Add(new ETeethPestion.GetTeethInformationDataTable(dataSet.Tables["GetTeethInformation"]));
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
			ETeethPestion eTeethPestion = (ETeethPestion)base.Clone();
			eTeethPestion.InitVars();
			eTeethPestion.SchemaSerializationMode = this.SchemaSerializationMode;
			return eTeethPestion;
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
				if (dataSet.Tables["GetTeethInformation"] != null)
				{
					base.Tables.Add(new ETeethPestion.GetTeethInformationDataTable(dataSet.Tables["GetTeethInformation"]));
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
			this.tableGetTeethInformation = (ETeethPestion.GetTeethInformationDataTable)base.Tables["GetTeethInformation"];
			if (initTable && this.tableGetTeethInformation != null)
			{
				this.tableGetTeethInformation.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ETeethPestion";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ESysOptionDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetTeethInformation = new ETeethPestion.GetTeethInformationDataTable();
			base.Tables.Add(this.tableGetTeethInformation);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetTeethInformation()
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
			ETeethPestion eTeethPestion = new ETeethPestion();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eTeethPestion.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eTeethPestion.GetSchemaSerializable();
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
