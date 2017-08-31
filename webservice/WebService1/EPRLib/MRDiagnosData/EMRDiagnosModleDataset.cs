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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosModleDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosModleDataset : DataSet
	{
		public delegate void FindDiagoseTabRowChangeEventHandler(object sender, EMRDiagnosModleDataset.FindDiagoseTabRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class FindDiagoseTabDataTable : DataTable, IEnumerable
		{
			private DataColumn columnRowId;

			private DataColumn columnDesc;

			private DataColumn columnSequence;

			private EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowChangingEvent;

			private EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowChangedEvent;

			private EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowDeletingEvent;

			private EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowDeletedEvent;

			public event EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabRowChangingEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabRowChangingEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabRowChangingEvent, value);
				}
			}

			public event EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabRowChangedEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabRowChangedEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabRowChangedEvent, value);
				}
			}

			public event EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabRowDeletingEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabRowDeletingEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler FindDiagoseTabRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabRowDeletedEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabRowDeletedEvent = (EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn RowIdColumn
			{
				get
				{
					return this.columnRowId;
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

			[DebuggerNonUserCode]
			public DataColumn SequenceColumn
			{
				get
				{
					return this.columnSequence;
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
			public EMRDiagnosModleDataset.FindDiagoseTabRow this[int index]
			{
				get
				{
					return (EMRDiagnosModleDataset.FindDiagoseTabRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public FindDiagoseTabDataTable()
			{
				this.TableName = "FindDiagoseTab";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal FindDiagoseTabDataTable(DataTable table)
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
			protected FindDiagoseTabDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddFindDiagoseTabRow(EMRDiagnosModleDataset.FindDiagoseTabRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosModleDataset.FindDiagoseTabRow AddFindDiagoseTabRow(string RowId, string Desc, string Sequence)
			{
				EMRDiagnosModleDataset.FindDiagoseTabRow findDiagoseTabRow = (EMRDiagnosModleDataset.FindDiagoseTabRow)this.NewRow();
				object[] itemArray = new object[]
				{
					RowId,
					Desc,
					Sequence
				};
				findDiagoseTabRow.ItemArray = itemArray;
				this.Rows.Add(findDiagoseTabRow);
				return findDiagoseTabRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosModleDataset.FindDiagoseTabDataTable findDiagoseTabDataTable = (EMRDiagnosModleDataset.FindDiagoseTabDataTable)base.Clone();
				findDiagoseTabDataTable.InitVars();
				return findDiagoseTabDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosModleDataset.FindDiagoseTabDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnRowId = base.Columns["RowId"];
				this.columnDesc = base.Columns["Desc"];
				this.columnSequence = base.Columns["Sequence"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnRowId = new DataColumn("RowId", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRowId);
				this.columnDesc = new DataColumn("Desc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDesc);
				this.columnSequence = new DataColumn("Sequence", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSequence);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosModleDataset.FindDiagoseTabRow NewFindDiagoseTabRow()
			{
				return (EMRDiagnosModleDataset.FindDiagoseTabRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosModleDataset.FindDiagoseTabRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosModleDataset.FindDiagoseTabRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.FindDiagoseTabRowChangedEvent != null)
				{
					EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler findDiagoseTabRowChangedEvent = this.FindDiagoseTabRowChangedEvent;
					if (findDiagoseTabRowChangedEvent != null)
					{
						findDiagoseTabRowChangedEvent(this, new EMRDiagnosModleDataset.FindDiagoseTabRowChangeEvent((EMRDiagnosModleDataset.FindDiagoseTabRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.FindDiagoseTabRowChangingEvent != null)
				{
					EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler findDiagoseTabRowChangingEvent = this.FindDiagoseTabRowChangingEvent;
					if (findDiagoseTabRowChangingEvent != null)
					{
						findDiagoseTabRowChangingEvent(this, new EMRDiagnosModleDataset.FindDiagoseTabRowChangeEvent((EMRDiagnosModleDataset.FindDiagoseTabRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.FindDiagoseTabRowDeletedEvent != null)
				{
					EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler findDiagoseTabRowDeletedEvent = this.FindDiagoseTabRowDeletedEvent;
					if (findDiagoseTabRowDeletedEvent != null)
					{
						findDiagoseTabRowDeletedEvent(this, new EMRDiagnosModleDataset.FindDiagoseTabRowChangeEvent((EMRDiagnosModleDataset.FindDiagoseTabRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.FindDiagoseTabRowDeletingEvent != null)
				{
					EMRDiagnosModleDataset.FindDiagoseTabRowChangeEventHandler findDiagoseTabRowDeletingEvent = this.FindDiagoseTabRowDeletingEvent;
					if (findDiagoseTabRowDeletingEvent != null)
					{
						findDiagoseTabRowDeletingEvent(this, new EMRDiagnosModleDataset.FindDiagoseTabRowChangeEvent((EMRDiagnosModleDataset.FindDiagoseTabRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveFindDiagoseTabRow(EMRDiagnosModleDataset.FindDiagoseTabRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosModleDataset eMRDiagnosModleDataset = new EMRDiagnosModleDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosModleDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FindDiagoseTabDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosModleDataset.GetSchemaSerializable();
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
		public class FindDiagoseTabRow : DataRow
		{
			private EMRDiagnosModleDataset.FindDiagoseTabDataTable tableFindDiagoseTab;

			[DebuggerNonUserCode]
			public string RowId
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTab.RowIdColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTab\"中列\"RowId\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTab.RowIdColumn] = value;
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
						result = Conversions.ToString(this[this.tableFindDiagoseTab.DescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTab\"中列\"Desc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTab.DescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Sequence
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTab.SequenceColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTab\"中列\"Sequence\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTab.SequenceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal FindDiagoseTabRow(DataRowBuilder rb) : base(rb)
			{
				this.tableFindDiagoseTab = (EMRDiagnosModleDataset.FindDiagoseTabDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsRowIdNull()
			{
				return this.IsNull(this.tableFindDiagoseTab.RowIdColumn);
			}

			[DebuggerNonUserCode]
			public void SetRowIdNull()
			{
				this[this.tableFindDiagoseTab.RowIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescNull()
			{
				return this.IsNull(this.tableFindDiagoseTab.DescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescNull()
			{
				this[this.tableFindDiagoseTab.DescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSequenceNull()
			{
				return this.IsNull(this.tableFindDiagoseTab.SequenceColumn);
			}

			[DebuggerNonUserCode]
			public void SetSequenceNull()
			{
				this[this.tableFindDiagoseTab.SequenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FindDiagoseTabRowChangeEvent : EventArgs
		{
			private EMRDiagnosModleDataset.FindDiagoseTabRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosModleDataset.FindDiagoseTabRow Row
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
			public FindDiagoseTabRowChangeEvent(EMRDiagnosModleDataset.FindDiagoseTabRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosModleDataset.FindDiagoseTabDataTable tableFindDiagoseTab;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosModleDataset.FindDiagoseTabDataTable FindDiagoseTab
		{
			get
			{
				return this.tableFindDiagoseTab;
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
		public EMRDiagnosModleDataset()
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
		protected EMRDiagnosModleDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["FindDiagoseTab"] != null)
				{
					base.Tables.Add(new EMRDiagnosModleDataset.FindDiagoseTabDataTable(dataSet.Tables["FindDiagoseTab"]));
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
			EMRDiagnosModleDataset eMRDiagnosModleDataset = (EMRDiagnosModleDataset)base.Clone();
			eMRDiagnosModleDataset.InitVars();
			eMRDiagnosModleDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosModleDataset;
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
				if (dataSet.Tables["FindDiagoseTab"] != null)
				{
					base.Tables.Add(new EMRDiagnosModleDataset.FindDiagoseTabDataTable(dataSet.Tables["FindDiagoseTab"]));
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
			this.tableFindDiagoseTab = (EMRDiagnosModleDataset.FindDiagoseTabDataTable)base.Tables["FindDiagoseTab"];
			if (initTable && this.tableFindDiagoseTab != null)
			{
				this.tableFindDiagoseTab.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosModleDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosModleDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableFindDiagoseTab = new EMRDiagnosModleDataset.FindDiagoseTabDataTable();
			base.Tables.Add(this.tableFindDiagoseTab);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeFindDiagoseTab()
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
			EMRDiagnosModleDataset eMRDiagnosModleDataset = new EMRDiagnosModleDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosModleDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosModleDataset.GetSchemaSerializable();
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
