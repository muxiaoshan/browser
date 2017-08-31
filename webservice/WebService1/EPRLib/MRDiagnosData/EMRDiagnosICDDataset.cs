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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosICDDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosICDDataset : DataSet
	{
		public delegate void GetICDDXRowChangeEventHandler(object sender, EMRDiagnosICDDataset.GetICDDXRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetICDDXDataTable : DataTable, IEnumerable
		{
			private DataColumn columnARowID;

			private DataColumn columnADesc;

			private DataColumn columnACode;

			private EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowChangingEvent;

			private EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowChangedEvent;

			private EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowDeletingEvent;

			private EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowDeletedEvent;

			public event EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetICDDXRowChangingEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Combine(this.GetICDDXRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetICDDXRowChangingEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Remove(this.GetICDDXRowChangingEvent, value);
				}
			}

			public event EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetICDDXRowChangedEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Combine(this.GetICDDXRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetICDDXRowChangedEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Remove(this.GetICDDXRowChangedEvent, value);
				}
			}

			public event EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetICDDXRowDeletingEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Combine(this.GetICDDXRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetICDDXRowDeletingEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Remove(this.GetICDDXRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler GetICDDXRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetICDDXRowDeletedEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Combine(this.GetICDDXRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetICDDXRowDeletedEvent = (EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler)Delegate.Remove(this.GetICDDXRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ARowIDColumn
			{
				get
				{
					return this.columnARowID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADescColumn
			{
				get
				{
					return this.columnADesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ACodeColumn
			{
				get
				{
					return this.columnACode;
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
			public EMRDiagnosICDDataset.GetICDDXRow this[int index]
			{
				get
				{
					return (EMRDiagnosICDDataset.GetICDDXRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetICDDXDataTable()
			{
				this.TableName = "GetICDDX";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetICDDXDataTable(DataTable table)
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
			protected GetICDDXDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetICDDXRow(EMRDiagnosICDDataset.GetICDDXRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosICDDataset.GetICDDXRow AddGetICDDXRow(string ARowID, string ADesc, string ACode)
			{
				EMRDiagnosICDDataset.GetICDDXRow getICDDXRow = (EMRDiagnosICDDataset.GetICDDXRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ARowID,
					ADesc,
					ACode
				};
				getICDDXRow.ItemArray = itemArray;
				this.Rows.Add(getICDDXRow);
				return getICDDXRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosICDDataset.GetICDDXDataTable getICDDXDataTable = (EMRDiagnosICDDataset.GetICDDXDataTable)base.Clone();
				getICDDXDataTable.InitVars();
				return getICDDXDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosICDDataset.GetICDDXDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnARowID = base.Columns["ARowID"];
				this.columnADesc = base.Columns["ADesc"];
				this.columnACode = base.Columns["ACode"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnARowID = new DataColumn("ARowID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnARowID);
				this.columnADesc = new DataColumn("ADesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADesc);
				this.columnACode = new DataColumn("ACode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnACode);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosICDDataset.GetICDDXRow NewGetICDDXRow()
			{
				return (EMRDiagnosICDDataset.GetICDDXRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosICDDataset.GetICDDXRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosICDDataset.GetICDDXRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetICDDXRowChangedEvent != null)
				{
					EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler getICDDXRowChangedEvent = this.GetICDDXRowChangedEvent;
					if (getICDDXRowChangedEvent != null)
					{
						getICDDXRowChangedEvent(this, new EMRDiagnosICDDataset.GetICDDXRowChangeEvent((EMRDiagnosICDDataset.GetICDDXRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetICDDXRowChangingEvent != null)
				{
					EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler getICDDXRowChangingEvent = this.GetICDDXRowChangingEvent;
					if (getICDDXRowChangingEvent != null)
					{
						getICDDXRowChangingEvent(this, new EMRDiagnosICDDataset.GetICDDXRowChangeEvent((EMRDiagnosICDDataset.GetICDDXRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetICDDXRowDeletedEvent != null)
				{
					EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler getICDDXRowDeletedEvent = this.GetICDDXRowDeletedEvent;
					if (getICDDXRowDeletedEvent != null)
					{
						getICDDXRowDeletedEvent(this, new EMRDiagnosICDDataset.GetICDDXRowChangeEvent((EMRDiagnosICDDataset.GetICDDXRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetICDDXRowDeletingEvent != null)
				{
					EMRDiagnosICDDataset.GetICDDXRowChangeEventHandler getICDDXRowDeletingEvent = this.GetICDDXRowDeletingEvent;
					if (getICDDXRowDeletingEvent != null)
					{
						getICDDXRowDeletingEvent(this, new EMRDiagnosICDDataset.GetICDDXRowChangeEvent((EMRDiagnosICDDataset.GetICDDXRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetICDDXRow(EMRDiagnosICDDataset.GetICDDXRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosICDDataset eMRDiagnosICDDataset = new EMRDiagnosICDDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosICDDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetICDDXDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosICDDataset.GetSchemaSerializable();
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
		public class GetICDDXRow : DataRow
		{
			private EMRDiagnosICDDataset.GetICDDXDataTable tableGetICDDX;

			[DebuggerNonUserCode]
			public string ARowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetICDDX.ARowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetICDDX\"中列\"ARowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetICDDX.ARowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ADesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetICDDX.ADescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetICDDX\"中列\"ADesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetICDDX.ADescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ACode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetICDDX.ACodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetICDDX\"中列\"ACode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetICDDX.ACodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetICDDXRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetICDDX = (EMRDiagnosICDDataset.GetICDDXDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsARowIDNull()
			{
				return this.IsNull(this.tableGetICDDX.ARowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetARowIDNull()
			{
				this[this.tableGetICDDX.ARowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsADescNull()
			{
				return this.IsNull(this.tableGetICDDX.ADescColumn);
			}

			[DebuggerNonUserCode]
			public void SetADescNull()
			{
				this[this.tableGetICDDX.ADescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsACodeNull()
			{
				return this.IsNull(this.tableGetICDDX.ACodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetACodeNull()
			{
				this[this.tableGetICDDX.ACodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetICDDXRowChangeEvent : EventArgs
		{
			private EMRDiagnosICDDataset.GetICDDXRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosICDDataset.GetICDDXRow Row
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
			public GetICDDXRowChangeEvent(EMRDiagnosICDDataset.GetICDDXRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosICDDataset.GetICDDXDataTable tableGetICDDX;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosICDDataset.GetICDDXDataTable GetICDDX
		{
			get
			{
				return this.tableGetICDDX;
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
		public EMRDiagnosICDDataset()
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
		protected EMRDiagnosICDDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetICDDX"] != null)
				{
					base.Tables.Add(new EMRDiagnosICDDataset.GetICDDXDataTable(dataSet.Tables["GetICDDX"]));
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
			EMRDiagnosICDDataset eMRDiagnosICDDataset = (EMRDiagnosICDDataset)base.Clone();
			eMRDiagnosICDDataset.InitVars();
			eMRDiagnosICDDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosICDDataset;
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
				if (dataSet.Tables["GetICDDX"] != null)
				{
					base.Tables.Add(new EMRDiagnosICDDataset.GetICDDXDataTable(dataSet.Tables["GetICDDX"]));
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
			this.tableGetICDDX = (EMRDiagnosICDDataset.GetICDDXDataTable)base.Tables["GetICDDX"];
			if (initTable && this.tableGetICDDX != null)
			{
				this.tableGetICDDX.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosICDDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosICDDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetICDDX = new EMRDiagnosICDDataset.GetICDDXDataTable();
			base.Tables.Add(this.tableGetICDDX);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetICDDX()
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
			EMRDiagnosICDDataset eMRDiagnosICDDataset = new EMRDiagnosICDDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosICDDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosICDDataset.GetSchemaSerializable();
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
