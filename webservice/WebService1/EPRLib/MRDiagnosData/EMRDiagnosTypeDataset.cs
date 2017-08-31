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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosTypeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosTypeDataset : DataSet
	{
		public delegate void SelectDiagnosTypeRowChangeEventHandler(object sender, EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectDiagnosTypeDataTable : DataTable, IEnumerable
		{
			private DataColumn columnCode;

			private DataColumn columnDesc;

			private EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowChangingEvent;

			private EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowChangedEvent;

			private EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowDeletingEvent;

			private EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowDeletedEvent;

			public event EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypeRowChangingEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypeRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypeRowChangingEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypeRowChangingEvent, value);
				}
			}

			public event EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypeRowChangedEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypeRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypeRowChangedEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypeRowChangedEvent, value);
				}
			}

			public event EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypeRowDeletingEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypeRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypeRowDeletingEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypeRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler SelectDiagnosTypeRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypeRowDeletedEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypeRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypeRowDeletedEvent = (EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypeRowDeletedEvent, value);
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
			public DataColumn DescColumn
			{
				get
				{
					return this.columnDesc;
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
			public EMRDiagnosTypeDataset.SelectDiagnosTypeRow this[int index]
			{
				get
				{
					return (EMRDiagnosTypeDataset.SelectDiagnosTypeRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectDiagnosTypeDataTable()
			{
				this.TableName = "SelectDiagnosType";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectDiagnosTypeDataTable(DataTable table)
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
			protected SelectDiagnosTypeDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectDiagnosTypeRow(EMRDiagnosTypeDataset.SelectDiagnosTypeRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosTypeDataset.SelectDiagnosTypeRow AddSelectDiagnosTypeRow(string Code, string Desc)
			{
				EMRDiagnosTypeDataset.SelectDiagnosTypeRow selectDiagnosTypeRow = (EMRDiagnosTypeDataset.SelectDiagnosTypeRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Code,
					Desc
				};
				selectDiagnosTypeRow.ItemArray = itemArray;
				this.Rows.Add(selectDiagnosTypeRow);
				return selectDiagnosTypeRow;
			}

			[DebuggerNonUserCode]
			public EMRDiagnosTypeDataset.SelectDiagnosTypeRow FindByCode(string Code)
			{
				return (EMRDiagnosTypeDataset.SelectDiagnosTypeRow)this.Rows.Find(new object[]
				{
					Code
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
				EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable selectDiagnosTypeDataTable = (EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable)base.Clone();
				selectDiagnosTypeDataTable.InitVars();
				return selectDiagnosTypeDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCode = base.Columns["Code"];
				this.columnDesc = base.Columns["Desc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnDesc = new DataColumn("Desc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDesc);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnCode
				}, true));
				this.columnCode.AllowDBNull = false;
				this.columnCode.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosTypeDataset.SelectDiagnosTypeRow NewSelectDiagnosTypeRow()
			{
				return (EMRDiagnosTypeDataset.SelectDiagnosTypeRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosTypeDataset.SelectDiagnosTypeRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosTypeDataset.SelectDiagnosTypeRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectDiagnosTypeRowChangedEvent != null)
				{
					EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler selectDiagnosTypeRowChangedEvent = this.SelectDiagnosTypeRowChangedEvent;
					if (selectDiagnosTypeRowChangedEvent != null)
					{
						selectDiagnosTypeRowChangedEvent(this, new EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEvent((EMRDiagnosTypeDataset.SelectDiagnosTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectDiagnosTypeRowChangingEvent != null)
				{
					EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler selectDiagnosTypeRowChangingEvent = this.SelectDiagnosTypeRowChangingEvent;
					if (selectDiagnosTypeRowChangingEvent != null)
					{
						selectDiagnosTypeRowChangingEvent(this, new EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEvent((EMRDiagnosTypeDataset.SelectDiagnosTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectDiagnosTypeRowDeletedEvent != null)
				{
					EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler selectDiagnosTypeRowDeletedEvent = this.SelectDiagnosTypeRowDeletedEvent;
					if (selectDiagnosTypeRowDeletedEvent != null)
					{
						selectDiagnosTypeRowDeletedEvent(this, new EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEvent((EMRDiagnosTypeDataset.SelectDiagnosTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectDiagnosTypeRowDeletingEvent != null)
				{
					EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEventHandler selectDiagnosTypeRowDeletingEvent = this.SelectDiagnosTypeRowDeletingEvent;
					if (selectDiagnosTypeRowDeletingEvent != null)
					{
						selectDiagnosTypeRowDeletingEvent(this, new EMRDiagnosTypeDataset.SelectDiagnosTypeRowChangeEvent((EMRDiagnosTypeDataset.SelectDiagnosTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectDiagnosTypeRow(EMRDiagnosTypeDataset.SelectDiagnosTypeRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosTypeDataset eMRDiagnosTypeDataset = new EMRDiagnosTypeDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosTypeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectDiagnosTypeDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosTypeDataset.GetSchemaSerializable();
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
		public class SelectDiagnosTypeRow : DataRow
		{
			private EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable tableSelectDiagnosType;

			[DebuggerNonUserCode]
			public string Code
			{
				get
				{
					return Conversions.ToString(this[this.tableSelectDiagnosType.CodeColumn]);
				}
				set
				{
					this[this.tableSelectDiagnosType.CodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Desc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectDiagnosType.DescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectDiagnosType\"中列\"Desc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectDiagnosType.DescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectDiagnosTypeRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectDiagnosType = (EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsDescNull()
			{
				return this.IsNull(this.tableSelectDiagnosType.DescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescNull()
			{
				this[this.tableSelectDiagnosType.DescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectDiagnosTypeRowChangeEvent : EventArgs
		{
			private EMRDiagnosTypeDataset.SelectDiagnosTypeRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosTypeDataset.SelectDiagnosTypeRow Row
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
			public SelectDiagnosTypeRowChangeEvent(EMRDiagnosTypeDataset.SelectDiagnosTypeRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable tableSelectDiagnosType;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable SelectDiagnosType
		{
			get
			{
				return this.tableSelectDiagnosType;
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
		public EMRDiagnosTypeDataset()
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
		protected EMRDiagnosTypeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectDiagnosType"] != null)
				{
					base.Tables.Add(new EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable(dataSet.Tables["SelectDiagnosType"]));
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
			EMRDiagnosTypeDataset eMRDiagnosTypeDataset = (EMRDiagnosTypeDataset)base.Clone();
			eMRDiagnosTypeDataset.InitVars();
			eMRDiagnosTypeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosTypeDataset;
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
				if (dataSet.Tables["SelectDiagnosType"] != null)
				{
					base.Tables.Add(new EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable(dataSet.Tables["SelectDiagnosType"]));
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
			this.tableSelectDiagnosType = (EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable)base.Tables["SelectDiagnosType"];
			if (initTable && this.tableSelectDiagnosType != null)
			{
				this.tableSelectDiagnosType.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosTypeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosTypeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectDiagnosType = new EMRDiagnosTypeDataset.SelectDiagnosTypeDataTable();
			base.Tables.Add(this.tableSelectDiagnosType);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectDiagnosType()
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
			EMRDiagnosTypeDataset eMRDiagnosTypeDataset = new EMRDiagnosTypeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosTypeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosTypeDataset.GetSchemaSerializable();
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
