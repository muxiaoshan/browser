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

namespace PACSData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSItemIndicatorsDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSItemIndicatorsDataSet : DataSet
	{
		public delegate void SelectPACSItemIndicatorsRowChangeEventHandler(object sender, EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectPACSItemIndicatorsDataTable : DataTable, IEnumerable
		{
			private DataColumn columnretContent;

			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowChangingEvent;

			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowChangedEvent;

			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowDeletingEvent;

			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowDeletedEvent;

			public event EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemIndicatorsRowChangingEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemIndicatorsRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemIndicatorsRowChangingEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemIndicatorsRowChangingEvent, value);
				}
			}

			public event EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemIndicatorsRowChangedEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemIndicatorsRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemIndicatorsRowChangedEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemIndicatorsRowChangedEvent, value);
				}
			}

			public event EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemIndicatorsRowDeletingEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemIndicatorsRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemIndicatorsRowDeletingEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemIndicatorsRowDeletingEvent, value);
				}
			}

			public event EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler SelectPACSItemIndicatorsRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSItemIndicatorsRowDeletedEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Combine(this.SelectPACSItemIndicatorsRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSItemIndicatorsRowDeletedEvent = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler)Delegate.Remove(this.SelectPACSItemIndicatorsRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn retContentColumn
			{
				get
				{
					return this.columnretContent;
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
			public EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow this[int index]
			{
				get
				{
					return (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectPACSItemIndicatorsDataTable()
			{
				this.TableName = "SelectPACSItemIndicators";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectPACSItemIndicatorsDataTable(DataTable table)
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
			protected SelectPACSItemIndicatorsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectPACSItemIndicatorsRow(EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow AddSelectPACSItemIndicatorsRow(string retContent)
			{
				EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow selectPACSItemIndicatorsRow = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)this.NewRow();
				object[] itemArray = new object[]
				{
					retContent
				};
				selectPACSItemIndicatorsRow.ItemArray = itemArray;
				this.Rows.Add(selectPACSItemIndicatorsRow);
				return selectPACSItemIndicatorsRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable selectPACSItemIndicatorsDataTable = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable)base.Clone();
				selectPACSItemIndicatorsDataTable.InitVars();
				return selectPACSItemIndicatorsDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnretContent = base.Columns["retContent"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnretContent = new DataColumn("retContent", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnretContent);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow NewSelectPACSItemIndicatorsRow()
			{
				return (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectPACSItemIndicatorsRowChangedEvent != null)
				{
					EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler selectPACSItemIndicatorsRowChangedEvent = this.SelectPACSItemIndicatorsRowChangedEvent;
					if (selectPACSItemIndicatorsRowChangedEvent != null)
					{
						selectPACSItemIndicatorsRowChangedEvent(this, new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEvent((EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectPACSItemIndicatorsRowChangingEvent != null)
				{
					EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler selectPACSItemIndicatorsRowChangingEvent = this.SelectPACSItemIndicatorsRowChangingEvent;
					if (selectPACSItemIndicatorsRowChangingEvent != null)
					{
						selectPACSItemIndicatorsRowChangingEvent(this, new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEvent((EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectPACSItemIndicatorsRowDeletedEvent != null)
				{
					EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler selectPACSItemIndicatorsRowDeletedEvent = this.SelectPACSItemIndicatorsRowDeletedEvent;
					if (selectPACSItemIndicatorsRowDeletedEvent != null)
					{
						selectPACSItemIndicatorsRowDeletedEvent(this, new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEvent((EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectPACSItemIndicatorsRowDeletingEvent != null)
				{
					EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEventHandler selectPACSItemIndicatorsRowDeletingEvent = this.SelectPACSItemIndicatorsRowDeletingEvent;
					if (selectPACSItemIndicatorsRowDeletingEvent != null)
					{
						selectPACSItemIndicatorsRowDeletingEvent(this, new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRowChangeEvent((EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectPACSItemIndicatorsRow(EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSItemIndicatorsDataSet ePACSItemIndicatorsDataSet = new EPACSItemIndicatorsDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSItemIndicatorsDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectPACSItemIndicatorsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSItemIndicatorsDataSet.GetSchemaSerializable();
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
		public class SelectPACSItemIndicatorsRow : DataRow
		{
			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable tableSelectPACSItemIndicators;

			[DebuggerNonUserCode]
			public string retContent
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSItemIndicators.retContentColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSItemIndicators\"中列\"retContent\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSItemIndicators.retContentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectPACSItemIndicatorsRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectPACSItemIndicators = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsretContentNull()
			{
				return this.IsNull(this.tableSelectPACSItemIndicators.retContentColumn);
			}

			[DebuggerNonUserCode]
			public void SetretContentNull()
			{
				this[this.tableSelectPACSItemIndicators.retContentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectPACSItemIndicatorsRowChangeEvent : EventArgs
		{
			private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow Row
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
			public SelectPACSItemIndicatorsRowChangeEvent(EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable tableSelectPACSItemIndicators;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable SelectPACSItemIndicators
		{
			get
			{
				return this.tableSelectPACSItemIndicators;
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
		public EPACSItemIndicatorsDataSet()
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
		protected EPACSItemIndicatorsDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectPACSItemIndicators"] != null)
				{
					base.Tables.Add(new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable(dataSet.Tables["SelectPACSItemIndicators"]));
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
			EPACSItemIndicatorsDataSet ePACSItemIndicatorsDataSet = (EPACSItemIndicatorsDataSet)base.Clone();
			ePACSItemIndicatorsDataSet.InitVars();
			ePACSItemIndicatorsDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSItemIndicatorsDataSet;
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
				if (dataSet.Tables["SelectPACSItemIndicators"] != null)
				{
					base.Tables.Add(new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable(dataSet.Tables["SelectPACSItemIndicators"]));
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
			this.tableSelectPACSItemIndicators = (EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable)base.Tables["SelectPACSItemIndicators"];
			if (initTable && this.tableSelectPACSItemIndicators != null)
			{
				this.tableSelectPACSItemIndicators.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSItemIndicatorsDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSItemIndicatorsDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectPACSItemIndicators = new EPACSItemIndicatorsDataSet.SelectPACSItemIndicatorsDataTable();
			base.Tables.Add(this.tableSelectPACSItemIndicators);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectPACSItemIndicators()
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
			EPACSItemIndicatorsDataSet ePACSItemIndicatorsDataSet = new EPACSItemIndicatorsDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSItemIndicatorsDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSItemIndicatorsDataSet.GetSchemaSerializable();
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
